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
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;

namespace FormatoFacturaFE
{
    public partial class FtoImpFacFe : Form
    {
        Factura _efactura = new Factura();
        List<Factura> _lstfac = new List<Factura>();
        List<DetalleFactura> _lstdet = new List<DetalleFactura>();
        Comercial objCom = new Comercial();
        NumLetra NumeroLetra = new NumLetra();
        string cdocu;
        string ndocu;
        public FtoImpFacFe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            Byte[] img = GenerarCodigoQr();
            //string cn = ConfigurationManager.AppSettings["bdNava01"];
            objCom.ObtenerCabeceraFBNCND(cdocu, ndocu, "bdNava01", ref _efactura,ref _lstdet);
            _efactura.CodigoQR = img;
            _efactura.NumeroLetras = NumeroLetra.Convertir(_efactura.Totn.ToString(), true);
            _efactura.NumeroLetras=_efactura.NumeroLetras + (_efactura.Moneda == "S" ? " SOLES" : "DOLARES");
            _lstfac.Add(_efactura);
            //lstfactura.Add(new Factura(cdocu, ndocu, "Andy Ex", "46119959", "", img));
            cargar_reportveawer();
            this.rpvwfactura.RefreshReport();
            GenerarCodigoQr();
        }
        private void cargar_reportveawer()
        {
            
            
            rpvwfactura.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsCabFac";
            rds.Value = _lstfac;
            this.rpvwfactura.LocalReport.DataSources.Add(rds);

            rds = new ReportDataSource();
            rds.Name = "dsDetFac";
            rds.Value = _lstdet;
            this.rpvwfactura.LocalReport.DataSources.Add(rds);

            this.rpvwfactura.LocalReport.ReportEmbeddedResource =
                "FormatoFacturaFE.RptFacturaFE.rdlc";

            //ReportParameter[] pa = new ReportParameter[1];
            //pa[0] = new ReportParameter("UsuarioEncargado", usuario.UsuCod.ToString());
            //this.rpvwfactura.LocalReport.SetParameters(pa);

            rpvwfactura.ProcessingMode = ProcessingMode.Local;


            rpvwfactura.LocalReport.Refresh();
            this.rpvwfactura.RefreshReport();
        }
        private byte[] GenerarCodigoQr()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode("Mi nombre es susan la cholita", out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
            //panelResultado.BackgroundImage = imagen;

            MemoryStream msimagen = new MemoryStream();
            imagen.Save(msimagen, ImageFormat.Png);
            //
            //Retornamos el arreglo de bytes
            return ms.ToArray();
        }

        

    }
}
