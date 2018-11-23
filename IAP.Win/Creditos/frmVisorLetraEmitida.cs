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

        //private void cargar_reportveawer()
        //{


        //    rpvwletra.LocalReport.DataSources.Clear();
        //    ReportDataSource rds = new ReportDataSource();
        //    rds.Name = "dsCabBol";
        //    rds.Value = _lstfac;
        //    this.rpvwboleta.LocalReport.DataSources.Add(rds);

        //    rds = new ReportDataSource();
        //    rds.Name = "dsDetBol";
        //    rds.Value = _lstdet;
        //    this.rpvwboleta.LocalReport.DataSources.Add(rds);

        //    List<ParametrosFormatos> parametros = cls.ObtenerParametroFormatosFB("bdNava01");

        //    if (parametros.Where(x => x.IdParametro.Trim() == "FormatoBoletaElectronica" && x.Valor.Trim() == "1").Any())
        //    {
        //        this.rpvwboleta.LocalReport.ReportEmbeddedResource =
        //        "FormatoBoletaFE.RptBoletaFE.rdlc";
        //    }
        //    else
        //    {
        //        this.rpvwboleta.LocalReport.ReportEmbeddedResource =
        //        "FormatoBoletaFE.RptBoleta.rdlc";
        //    }



        //    //ReportParameter[] pa = new ReportParameter[1];
        //    //pa[0] = new ReportParameter("UsuarioEncargado", usuario.UsuCod.ToString());
        //    //this.rpvwfactura.LocalReport.SetParameters(pa);

        //    rpvwboleta.ProcessingMode = ProcessingMode.Local;


        //    rpvwboleta.LocalReport.Refresh();
        //    this.rpvwboleta.RefreshReport();
        //}


        private void frmVisorLetraEmitida_Load(object sender, EventArgs e)
        {


        }
    }
}
