using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAP.Win.Comercial
{
    public partial class frm_VisorArchivos : Form
    {
        string txtJson;
        public frm_VisorArchivos(string archivo)
        {
            txtJson = archivo;
            InitializeComponent();
        }

        private void frm_VisorArchivos_Load(object sender, EventArgs e)
        {
            txtarchivo.Text = txtJson;
        }
    }
}
