using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
namespace IAP.Win
{
    public partial class frm_UsuariosAndroid : Form
    {
        public DataTable dt;
        public int cantidad_registros, registro_actual=0;
        public Boolean Editar = false;
        public Boolean Nuevo = false;

        public frm_UsuariosAndroid()
           
        {
            InitializeComponent();
        }

        private void frm_UsuariosAndroid_Load(object sender, EventArgs e)
        {
            //DataTable dt;
            dt = new DataTable();
            ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();
            using (WaitDialogForm waitDialog = new WaitDialogForm("Cargando lista de usuarios", "Espere por favor..."))
            {
                dt = ws.Listar_usuarios_android_pc("usuarios");
                cantidad_registros = dt.Rows.Count;
                Mostrar_usuario(registro_actual);
            }
            
        }
        private void Mostrar_usuario(int id)
        {
            if (registro_actual >= 0 && registro_actual <= cantidad_registros)
            {
                DataRow dtRow = dt.Rows[id];
                txtid.Text = dtRow["codUser"].ToString();
                txtnombre.Text = dtRow["nombre"].ToString();
                txtapellidos.Text = dtRow["apellidos"].ToString();
                cmbsexo.Text = dtRow["sexo"].ToString();
                txtusuario.Text = dtRow["usuario"].ToString();
                txtclave.Text = dtRow["clave"].ToString();
                txtruc.Text = dtRow["ruccli"].ToString();
                txtrazonsocial.Text = dtRow["nomcli"].ToString();
                txtdireccion.Text = dtRow["dircli"].ToString();
            }
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (registro_actual == 0)
            {
                return;
            }
            else
            {
                registro_actual = registro_actual - 1;
                Mostrar_usuario(registro_actual);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (registro_actual+1 == cantidad_registros)
            {
                return;
            }
            else
            {

                registro_actual = registro_actual + 1;
                Mostrar_usuario(registro_actual);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            habilitar_controles();
            Editar = true;
            
        }

        private void habilitar_controles()
        {
            txtnombre.Enabled = true;
            txtapellidos.Enabled = true;
            cmbsexo.Enabled = true;
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            txtruc.Enabled = true;
            txtrazonsocial.Enabled = true;
            txtdireccion.ReadOnly = false;
        }
        private void deshabilitar_controles()
        {
            txtnombre.Enabled = false;
            txtapellidos.Enabled = false;
            cmbsexo.Enabled = false;
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            txtruc.Enabled = false;
            txtrazonsocial.Enabled = false;
            txtdireccion.ReadOnly = true;
        }
        private void limpiar_controles()
        {
            txtnombre.Text = string.Empty;
            txtapellidos.Text = string.Empty;
            cmbsexo.Text = string.Empty;
            txtusuario.Text = string.Empty;
            txtclave.Text = string.Empty;
            txtruc.Text = string.Empty;
            txtrazonsocial.Text = string.Empty;
            txtdireccion.Text = string.Empty;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                try
                {
                    DialogResult dlg = MessageBox.Show("Desea modificar los datos del usuario?", "Modulo de Android", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Cargando Información>>>>"))
                        {
                            BL.Android.Insertar_usuario(txtid.Text, txtnombre.Text, txtapellidos.Text, cmbsexo.Text, txtusuario.Text, txtclave.Text, txtruc.Text, txtrazonsocial.Text, txtdireccion.Text, Global.vUserBaseDatosAndroid);
                        }
                        deshabilitar_controles();
                        Editar = false;
                    }
                    else
                    {
                        deshabilitar_controles();
                        Editar = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if(Nuevo)
            {
                try
                {
                    DialogResult dlg = MessageBox.Show("Desea agregar el usuario?", "Modulo de Android", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Cargando Información>>>>"))
                        {
                            BL.Android.Insertar_usuario(txtid.Text, txtnombre.Text, txtapellidos.Text, cmbsexo.Text, txtusuario.Text, txtclave.Text, txtruc.Text, txtrazonsocial.Text, txtdireccion.Text, Global.vUserBaseDatosAndroid);
                        }
                        deshabilitar_controles();
                        Nuevo = false;
                    }
                    else
                    {
                        deshabilitar_controles();
                        Nuevo = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            habilitar_controles();
            limpiar_controles();
            Nuevo = true;
            txtnombre.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
