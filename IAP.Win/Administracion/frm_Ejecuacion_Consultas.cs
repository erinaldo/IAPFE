using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace IAP.Win
{
    public partial class frm_Ejecuacion_Consultas : Form
    {
       
        public frm_Ejecuacion_Consultas()
        {
            InitializeComponent();
        }

        private void frm_Ejecuacion_Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            string cadena_cifrada=string.Empty;
            cadena_cifrada=BL.Administracion.cifrar(this.txtconsulta.Text.Trim());
            this.txtdescifrado.Text = cadena_cifrada;
            this.txtnormal.Text = BL.Administracion.descifrar(cadena_cifrada);
        }
        
    }
}
