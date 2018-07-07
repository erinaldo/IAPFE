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
namespace IAP.Win
{
    public partial class frm_crear_backup : Form
    {
        public frm_crear_backup()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv= new SaveFileDialog();
            sv.Filter = "Archivos bk|*.bak";
            sv.Title = "Generacion de Copias de Seguridad";
            sv.InitialDirectory="C:\\";
            sv.ShowDialog();
            this.txtarchivo.Text = sv.FileName;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if ((this.txtarchivo.Text.Trim()).Length != 0)
            {
                if (MessageBox.Show("Desea Crear la Copia de Seguridad?", "Administración del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Generando Copia de Seguridad...", "<<<<Cargando Información>>>>"))
                    {
                        BL.Administracion.Generar_Backup(this.txtarchivo.Text.Trim(), Global.vUserBaseDatos);
                        this.txtarchivo.Text = string.Empty;
                    }
                }
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
