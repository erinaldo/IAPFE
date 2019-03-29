using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace IAP.Win
{
    public partial class frm_AccesoUsuario : Form
    {
        public int num_intentos = 0;
        //public DialogResult DialogResult_form;
        //public Boolean UserAdministrador = false;


        public frm_AccesoUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar_Ingreso();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.login_conforme = "no";
            this.Close();
            
        }

        private void frm_AccesoUsuario_Load(object sender, EventArgs e)
        {
            //txtBaseDatos.Text = "Hans-PC";
            //txtBaseDatos.Text = "hans-pc";
            //txtBaseDatos.Text = "HANS-PC";
            txtBaseDatos.Text = "LOCALHOST";
            cmbbd.SelectedIndex = 0;
            txtUsuario.Text = "cliente";
            txtPassword.Focus();
        }



        private static bool ValidaIP(string sIP)
        {
            try
            {
                if (sIP.ToUpper().Trim() == "VENTAS")
                {
                    return true;
                }
                else
                {
                    IPAddress ip = IPAddress.Parse(sIP);
                }

            }
            catch
            { return false; }

            return true;
        }

        private void comboBoxEdit1_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Validar_Ingreso()
        {
            if (txtBaseDatos.Text.Trim() == string.Empty || txtUsuario.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty || cmbbd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe llenar los campos requeridos para iniciar sesión", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (num_intentos == 3)
            {
                Application.Exit();
            }
            if (Global.vUserAdministrador == this.txtUsuario.Text.Trim() && Global.vUserPassAdministrador == this.txtPassword.Text.Trim() ||
                Global.vUserCliente == this.txtUsuario.Text.Trim() && Global.vUserPassCliente == txtPassword.Text.Trim())
            {
                Global.vIpServidor = txtBaseDatos.Text.Trim();
                Global.login_conforme = "si";
                Global.vUserBaseDatos = cmbbd.SelectedIndex==0 ? "BdNava01" : "Bdnava02";
                Global.vUserServer = cmbbd.Text;
                if (txtUsuario.Text.Trim().ToUpper() == "ADMINISTRADOR")
                {
                    Global.UserAdministrador = true;
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                num_intentos = num_intentos + 1;
                this.txtPassword.Text = "";
                MessageBox.Show("Las credenciales ingresadas son incorrectos", "Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                Validar_Ingreso();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
