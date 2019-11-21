using Microsoft.Reporting.WinForms;
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
//using Gma.QrCodeNet.Encoding;
//using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;

namespace FormatoGuiaFE
{
    public partial class FtoImpGuiaFe : Form
    {
        List<TelesolucionesGuiaRemisionFormato> Cab = new List<TelesolucionesGuiaRemisionFormato>();
        List<TelesolucionesGuiaRemisionLineaFormato> Det = new List<TelesolucionesGuiaRemisionLineaFormato>();

        Comercial objCom = new Comercial();
        BFacturacionElectronica eBFE = new BFacturacionElectronica();

        string cdocu;
        string ndocu;
        public FtoImpGuiaFe()
        {
            InitializeComponent();
        }

        void rpvwguia_Print(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("impreso");
            //if()
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rpvwguia.Print += new ReportPrintEventHandler(rpvwguia_Print);
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                String[] parametros = Environment.GetCommandLineArgs();
                for (int i = 0; i < parametros.Length; i++)
                {
                    if (i == 1)
                        cdocu = parametros[i].ToString();
                    if (i == 2)
                        ndocu = parametros[i].ToString();
                    //MessageBox.Show("Parámetro :" + parametros[i]);
                }
            }

            //string cn = ConfigurationManager.AppSettings["bdNava01"];
            TelesolucionesGuiaRemisionFormato ecab = new TelesolucionesGuiaRemisionFormato();
            ecab = eBFE.TelesolucionesObtenerGuiaRemisionFormato(ndocu, "BdNava01");
            Cab.Add(ecab);
            Det = eBFE.TelesolucionesObtenerGuiaRemisionLineaFormato(ndocu, "BdNava01");

            //objCom.ObtenerCabeceraGuia(cdocu, ndocu, "bdNava01", ref _eGuia, ref _lstdet);
            
            
            //lstfactura.Add(new Factura(cdocu, ndocu, "Andy Ex", "46119959", "", img));
            cargar_reportveawer();
            
            this.rpvwguia.RefreshReport();
        }

        private void cargar_reportveawer()
        {


            rpvwguia.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsCabecera";
            rds.Value = Cab;
            this.rpvwguia.LocalReport.DataSources.Add(rds);

            rds = new ReportDataSource();
            rds.Name = "dsDetalle";
            rds.Value = Det;
            this.rpvwguia.LocalReport.DataSources.Add(rds);

            this.rpvwguia.LocalReport.ReportEmbeddedResource =
                "FormatoGuiaFE.RptGuiaFE.rdlc";

            //ReportParameter[] pa = new ReportParameter[1];
            //pa[0] = new ReportParameter("UsuarioEncargado", usuario.UsuCod.ToString());
            //this.rpvwfactura.LocalReport.SetParameters(pa);

            rpvwguia.ProcessingMode = ProcessingMode.Local;


            rpvwguia.LocalReport.Refresh();
            this.rpvwguia.RefreshReport();
        }
    }
}
