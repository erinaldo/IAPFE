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
using System.IO;

namespace IAP.Win.Comercial
{
    public partial class frm_FacturasVisorPdf : Form
    {
        string linkdocumento;

        // Member variable to store the MemoryStream Data
        private MemoryStream pdfMemoryStream;

        // Public MemoryStream property containing PDF Data
        public frm_FacturasVisorPdf(string link)
        {
            InitializeComponent();
            linkdocumento = link;
        }

        private void frm_FacturasVisorPdf_Load(object sender, EventArgs e)
        {
            try
            {
                //wbdocumento.Navigate(linkdocumento);
               
               
                if (this.pdfMemoryStream == null)
                {
                    WebClient client = new WebClient();
                    try
                    {
                        this.pdfMemoryStream =
                          new MemoryStream(client.DownloadData(linkdocumento));
                        pdfViewer1.LoadDocument(pdfMemoryStream);
                        
                    }
                    finally
                    {
                        client.Dispose();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        
       
    }
}
