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
        private string Proveedor;

        // Public MemoryStream property containing PDF Data
        public frm_FacturasVisorPdf(string link,MemoryStream pdfStream,string proveedor)
        {
            InitializeComponent();
            linkdocumento = link;
            pdfMemoryStream = pdfStream;
            Proveedor = proveedor;

        }

        private void frm_FacturasVisorPdf_Load(object sender, EventArgs e)
        {
            try
            {
                //wbdocumento.Navigate(linkdocumento);
               
               if(Proveedor=="NUBEFACT")
                {
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
               else//TELESOLUCIONES
                {
                    pdfViewer1.LoadDocument(pdfMemoryStream);
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
