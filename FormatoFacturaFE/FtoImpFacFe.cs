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
            string rucEmpresa= ConfigurationManager.AppSettings.Get("RUCEMPRESA");
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

            string bd = ConfigurationManager.AppSettings["BD"];
            objCom.ObtenerCabeceraFBNCND(cdocu, ndocu, bd, ref _efactura,ref _lstdet);
            string serie = _efactura.Cdocu=="01" ? "F" + _efactura.Ndocu.Substring(0,3) : "B" + _efactura.Ndocu.Substring(0, 3);
            int  numero = Convert.ToInt32(_efactura.Ndocu.Substring(4, 8));
            string contenidoQR = rucEmpresa + "|" + _efactura.Cdocu + "|" + serie + "|" + numero.ToString() + "|" + _efactura.Toti.ToString() + "|" + _efactura.Totn + "|" +
                _efactura.Fecha.ToString("yyy-MM-dd") + "|" + (_efactura.RucCliente.Substring(0, 3) == "DNI" ? "01" : "06") + "|" +
                (_efactura.RucCliente.Substring(0, 3) == "DNI" ? _efactura.RucCliente.Substring(3, 8) : _efactura.RucCliente);

            Byte[] img = GenerarCodigoQr(contenidoQR);
            _efactura.CodigoQR = img;
            _efactura.NumeroLetras = NumeroLetra.Convertir(_efactura.Totn.ToString(), true);
            _efactura.NumeroLetras=_efactura.NumeroLetras + (_efactura.Moneda == "S" ? " SOLES" : "DOLARES");
            _lstfac.Add(_efactura);
            //lstfactura.Add(new Factura(cdocu, ndocu, "Andy Ex", "46119959", "", img));
            cargar_reportveawer();
            this.rpvwfactura.RefreshReport();
            //GenerarCodigoQr();
        }
        private void cargar_reportveawer()
        {
            Comercial cls = new Comercial();
            
            rpvwfactura.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsCabFac";
            rds.Value = _lstfac;
            this.rpvwfactura.LocalReport.DataSources.Add(rds);

            rds = new ReportDataSource();
            rds.Name = "dsDetFac";
            rds.Value = _lstdet;
            this.rpvwfactura.LocalReport.DataSources.Add(rds);

            List<ParametrosFormatos> parametros = cls.ObtenerParametroFormatosFB("bdNava01");

            if(parametros.Where(x=> x.IdParametro.Trim()== "FormatoFacturaElectronica" && x.Valor.Trim()=="1").Any())
            {

                this.rpvwfactura.LocalReport.ReportEmbeddedResource =
                //"FormatoFacturaFE.RptFacturaFE.rdlc";
                "FormatoFacturaFE.RptFacturaFEA4.rdlc";
            }
            else if(parametros.Where(x => x.IdParametro.Trim() == "FormatoFacturaElectronica" && x.Valor.Trim() == "2").Any())
            {
                this.rpvwfactura.LocalReport.ReportEmbeddedResource =
                "FormatoFacturaFE.RptFacturaFEA4x2.rdlc";
            }
            else
            {
                this.rpvwfactura.LocalReport.ReportEmbeddedResource =
                "FormatoFacturaFE.RptFactura.rdlc";
            }
            

            //ReportParameter[] pa = new ReportParameter[1];
            //pa[0] = new ReportParameter("UsuarioEncargado", usuario.UsuCod.ToString());
            //this.rpvwfactura.LocalReport.SetParameters(pa);

            rpvwfactura.ProcessingMode = ProcessingMode.Local;


            rpvwfactura.LocalReport.Refresh();
            this.rpvwfactura.RefreshReport();
        }
        private byte[] GenerarCodigoQr(string contenidoQr)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(contenidoQr, out qrCode);

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
