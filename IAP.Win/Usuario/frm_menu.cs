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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            string tipo_bd;
            if (Global.vUserBaseDatos.ToUpper()=="bdnava01".ToUpper())
            {
                tipo_bd="PRODUCCIÓN";
            }
            else
            {
                tipo_bd="LABORATORIO";
            }

            this.toolStripStatusLabel1.Text = tipo_bd;
            this.toolStripStatusLabel2.Text = "|| SERVIDOR - " + System.Net.Dns.GetHostName();
            //Global.vUserServer = toolStripStatusLabel2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmborrar_documento FRM = new frmborrar_documento();
            FRM.Show();
        }

        private void btneliminararqueo_Click(object sender, EventArgs e)
        {
            frm_eliminacion_arqueo frma = new frm_eliminacion_arqueo();
            frma.Show();
        }
    }
}
