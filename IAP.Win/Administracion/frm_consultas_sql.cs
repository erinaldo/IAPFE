using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.Utils;
namespace IAP.Win
{
    public partial class frm_consultas_sql : Form
    {
        public frm_consultas_sql()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Archivos de Sistema|*.sql";
            fd.FileName = "Archivos de Sistema";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.txtarchivo.Text = fd.FileName;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            
            StreamReader sr;
            string consulta;
            if ((this.txtarchivo.Text.Trim()).Length != 0)
            {
                try
                {

                    sr = File.OpenText(this.txtarchivo.Text);
                    consulta = sr.ReadToEnd();
                    sr.Close();
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Ejecutando Consulta...", "<<<<Cargando Información>>>>"))
                    {
                        BL.Administracion.Script_sql_BL(consulta, Global.vUserBaseDatos, Global.vUsuarioBD, Global.vPasswordBD, Global.vIpServidor);
                    }
                    MessageBox.Show("Se ejecuto el archivo correctamente", "Administración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtarchivo.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frm_consultas_sql_Load(object sender, EventArgs e)
        {
            this.txtarchivo.Text = string.Empty;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
