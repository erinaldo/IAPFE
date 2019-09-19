using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAP.Win
{
    public partial class frm_eliminacion_arqueo : Form
    {
        public frm_eliminacion_arqueo()
        {
            InitializeComponent();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if ((this.txtplanilla.Text.Trim()).Length !=12)
            {
                MessageBox.Show("El numero de planilla debe tener 12 caracteres", "Administración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resp;
            resp = MessageBox.Show("Esta seguro de eliminar el arqueo de Caja?", "Administración del Sistema!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    BL.Administracion.borrar_arqueo(this.txtplanilla.Text.Trim(), Global.vUserBaseDatos, Global.vUsuarioBD, Global.vPasswordBD, Global.vIpServidor);
                    MessageBox.Show("Se borro el arqueo satisfactoriamente", "Administración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtplanilla.Text=string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
