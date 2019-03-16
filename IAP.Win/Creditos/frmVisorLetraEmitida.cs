using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IAP.BE;
using IAP.BL;
using Microsoft.Reporting.WinForms;

namespace IAP.Win.Creditos
{
    public partial class frmVisorLetraEmitida : Form
    {
        List<LetrasEmitidas> _lstLetras = new List<LetrasEmitidas>();
        public frmVisorLetraEmitida(List<LetrasEmitidas> lst)
        {
            InitializeComponent();
            _lstLetras = lst;
        }

        private void cargar_reportveawer()
        {

            
            rpvwletras.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsLetras";
            rds.Value = _lstLetras;
            this.rpvwletras.LocalReport.DataSources.Add(rds);


            this.rpvwletras.LocalReport.ReportEmbeddedResource =
                "IAP.Win.Rpts.rptLetraEmitida.rdlc";
            
            //ReportParameter[] pa = new ReportParameter[1];
            //pa[0] = new ReportParameter("UsuarioEncargado", usuario.UsuCod.ToString());
            //this.rpvwfactura.LocalReport.SetParameters(pa);

            rpvwletras.ProcessingMode = ProcessingMode.Local;


            rpvwletras.LocalReport.Refresh();
            this.rpvwletras.RefreshReport();
        }


        private void frmVisorLetraEmitida_Load(object sender, EventArgs e)
        {
            cargar_reportveawer();

            this.reportViewer1.RefreshReport();
            this.rpvwletras.RefreshReport();
        }
    }
}
