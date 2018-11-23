using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using tessnet2;
using IAP.BL;
using DevExpress.Utils;

namespace IAP.Win.Comercial
{
    public partial class SUNAT : Form
    {

        string captcha = "";
        CookieContainer cokkie = new CookieContainer();
        string[] nrosRuc = new string[] { };
        

        public SUNAT()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtAvtividadComercioEx.Text = String.Empty;
            txtCondicionContribuyente.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEstadoContribuyente.Text = string.Empty;
            txtFechaInicioActividad.Text = string.Empty;
            txtFechaInscripcion.Text = string.Empty;
            txtNombreComercial.Text = string.Empty;
            txtTipoContribuyente.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ObtenerCapcha() {

            try
            {
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                request.CookieContainer = cokkie;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                var image = new Bitmap(responseStream);
                var ocr = new Tesseract();
                ocr.Init(@"D:\PROYECTO_UTILITARIO\IAP.Win\Content\tessdata", "eng", false);

                var result = ocr.DoOCR(image, Rectangle.Empty);
                foreach (Word word in result)
                {
                    captcha = word.Text;
                }
            }
            catch (Exception ex)
            {
                //mensaje de error
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //ObtenerCapcha();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                request.CookieContainer = cokkie;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                var image = new Bitmap(responseStream);
                var ocr = new Tesseract();
                ocr.Init(@"D:\PROYECTO_UTILITARIO\IAP.Win\Content\tessdata", "eng", false);

                var result = ocr.DoOCR(image, Rectangle.Empty);
                foreach (Word word in result)
                {
                    captcha = word.Text;
                }

                //string myurl = @"http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc="+txtNroDoc.Text.Trim()+"&codigo="+captcha.Trim().ToUpper() +"&tipdoc=1";
                string myurl = @"http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS03Alias?accion=consPorRuc&nroRuc=" + txtnroruc.Text.Trim() + "&codigo=" + captcha.Trim().ToUpper() + "&tipdoc=6";
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myurl);
                myWebRequest.CookieContainer = cokkie;
                 ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                HttpWebResponse myhttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myStream = myhttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                string xDat = ""; int pos = 0;
                txtDireccion.Text = String.Empty;
                while (!myStreamReader.EndOfStream) {
                    txtnroRucValue.Text = txtnroruc.Text;
                    xDat = myStreamReader.ReadLine();
                    pos++;

                    if (xDat.Contains("Nombre Comercial"))
                    {
                        xDat = myStreamReader.ReadLine();
                        txtNombreComercial.Text = getDatafromXML(xDat, 25);
                    }
                    if (xDat.Contains("Fecha de Inscripci"))
                    {
                        xDat = myStreamReader.ReadLine();
                        txtFechaInscripcion.Text = getDatafromXML(xDat, 25);
                    }
                    if (xDat.Contains("Estado:"))
                    {
                        xDat = myStreamReader.ReadLine();
                        txtEstadoContribuyente.Text = getDatafromXML(xDat, 25);
                    }
                    if (xDat.Contains("Condici&oacute"))
                    {
                        xDat = myStreamReader.ReadLine();
                        xDat = myStreamReader.ReadLine();
                        xDat = myStreamReader.ReadLine();
                        txtCondicionContribuyente.Text = getDatafromXML(xDat, 0);
                    }
                    if (xDat.Contains("Domicilio Fiscal"))
                    {
                        xDat = myStreamReader.ReadLine();
                        txtDireccion.Text = getDatafromXML(xDat, 25);
                    }
                    if (xDat.Contains("Tipo Contribuyente"))
                    {
                        xDat = myStreamReader.ReadLine();
                        txtTipoContribuyente.Text = getDatafromXML(xDat, 25);
                    }

                    //switch (pos) {
                    //    case 126:
                    //        txtTipoContribuyente.Text = getDatafromXML(xDat, 25);
                    //        break;
                    //    //case 131:
                    //    //    txtNombreComercial.Text = xDat.Contains("Nombre Comercial") ? getDatafromXML(xDat, 25) : ""; //getDatafromXML(xDat, 25);
                    //    //    break;
                    //    case 136:
                    //        txtFechaInscripcion.Text = getDatafromXML(xDat, 25);
                    //        break;
                    //    case 138:
                    //        txtFechaInicioActividad.Text = getDatafromXML(xDat, 25);
                    //        break;
                    //    case 142:
                    //        txtEstadoContribuyente.Text = getDatafromXML(xDat, 25);
                    //        break;
                    //    case 152:
                    //        txtCondicionContribuyente.Text = getDatafromXML(xDat, 0);
                    //        break;
                    //    case 158:
                    //        txtDireccion.Text = getDatafromXML(xDat, 25);
                    //        break;
                    //    case 176:
                    //        txtAvtividadComercioEx.Text = getDatafromXML(xDat, 25);
                    //        break;
                    //}
                    //txtDireccion.Text = txtDireccion.Text + xDat.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private string getDatafromXML(string lineRead,int len=0) {

            try
            {
                lineRead = lineRead.Trim();
                lineRead = lineRead.Remove(0, len);
                lineRead = lineRead.Replace("</td>", "");
                while (lineRead.Contains("  ")) {
                  lineRead =   lineRead.Replace("  ", " ");
                }
                return lineRead;
            }
            catch (Exception ex)
            {
                return "NO SE ENCONTRO RESULTADO";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (button2.Text == "IMPORTAR")
                //{
                //    button2.Text = "EJECUTAR";
                //    string archivoLeer = "";
                //    OpenFileDialog filedialog = new OpenFileDialog();
                //    filedialog.Filter = "Solo Archivos de Texto|*.txt";
                //    filedialog.Title = "Seleccione un Archivo de texto";
                //    if (filedialog.ShowDialog() == DialogResult.OK)
                //    {
                //        nrosRuc = new string[] { };
                //        archivoLeer = filedialog.FileName;
                //        lblArchivo.Text = archivoLeer;
                //        StreamReader streaReader = new StreamReader(archivoLeer);
                //        string cadena = streaReader.ReadToEnd();
                //        nrosRuc = cadena.Split(',');
                //    } 
                //}
                //else {
                //    button2.Text = "IMPORTAR";

                //    List<Dictionary<string, string>> obj = new List<Dictionary<string, string>>();

                //    for(int i=0;i<nrosRuc.Length;i++) {
                //        obj.Add(GetDistribuyentes(nrosRuc[i]));
                //    }

                //    frmSunatMultiple frmsunat = new frmSunatMultiple(obj);
                //    frmsunat.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                
            }
        }

        private Dictionary<string,string> GetDistribuyentes(string nroDoc) {
            try
            {
                //genCaptcha();

                string myurl = @"http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc=" + nroDoc.Trim() + "&codigo=" + captcha.Trim().ToUpper() + "&tipdoc=1";
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myurl);
                myWebRequest.CookieContainer = cokkie;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                HttpWebResponse myhttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myStream = myhttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                string xDat = ""; int pos = 0;

                Dictionary<string, string> datos = new Dictionary<string, string>();

              //  txtnroRucValue.Text = txtNroDoc.Text;
                datos.Add("RucContribuyente", nroDoc);
                while (!myStreamReader.EndOfStream)
                {
                    xDat = myStreamReader.ReadLine();
                    pos++;

                    switch (pos)
                    {
                        case 126:
                            datos.Add("TipoContribuyente", getDatafromXML(xDat, 25));
                            break;
                        case 131:
                            datos.Add("NombreComercial", getDatafromXML(xDat, 25));
                            break;
                        case 136:
                            datos.Add("FechaInscripcion", getDatafromXML(xDat, 25));
                            break;
                        case 138:
                            datos.Add("FechaInicioActividad", getDatafromXML(xDat, 25));
                            break;
                        case 142:
                            datos.Add("EstadoContribuyente", getDatafromXML(xDat, 25));
                            break;
                        case 152:
                            datos.Add("CondicionContribuyente", getDatafromXML(xDat, 0));
                            break;
                        case 158:
                            datos.Add("DireccionContribuyente", getDatafromXML(xDat, 25));
                            break;
                        case 176:
                            datos.Add("AvtividadComercioEx", getDatafromXML(xDat, 25));
                            break;
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                return new Dictionary<string, string>();
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Consultando a Sunat>>>>"))
                {
                    Limpiar();
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image");
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                    request.CookieContainer = cokkie;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();

                    var image = new Bitmap(responseStream);
                    var ocr = new Tesseract();
                    ocr.Init(@"D:\PROYECTO_UTILITARIO\IAP.Win\Content\tessdata", "eng", false);

                    var result = ocr.DoOCR(image, Rectangle.Empty);
                    foreach (Word word in result)
                    {
                        captcha = word.Text;
                    }

                    //string myurl = @"http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc="+txtNroDoc.Text.Trim()+"&codigo="+captcha.Trim().ToUpper() +"&tipdoc=1";
                    string myurl = @"http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS03Alias?accion=consPorRuc&nroRuc=" + txtnroruc.Text.Trim() + "&codigo=" + captcha.Trim().ToUpper() + "&tipdoc=6";
                    HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myurl);
                    myWebRequest.CookieContainer = cokkie;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                    HttpWebResponse myhttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                    Stream myStream = myhttpWebResponse.GetResponseStream();
                    StreamReader myStreamReader = new StreamReader(myStream);
                    string xDat = ""; int pos = 0;
                    txtDireccion.Text = String.Empty;
                    while (!myStreamReader.EndOfStream)
                    {
                        txtnroRucValue.Text = txtnroruc.Text;
                        xDat = myStreamReader.ReadLine();
                        pos++;

                        if (xDat.Contains("Nombre Comercial"))
                        {
                            xDat = myStreamReader.ReadLine();
                            txtNombreComercial.Text = getDatafromXML(xDat, 25);
                        }
                        if (xDat.Contains("Fecha de Inscripci"))
                        {
                            xDat = myStreamReader.ReadLine();
                            txtFechaInscripcion.Text = getDatafromXML(xDat, 25);
                        }
                        if (xDat.Contains("Estado:"))
                        {
                            xDat = myStreamReader.ReadLine();
                            txtEstadoContribuyente.Text = getDatafromXML(xDat, 25);
                        }
                        if (xDat.Contains("Condici&oacute"))
                        {
                            xDat = myStreamReader.ReadLine();
                            xDat = myStreamReader.ReadLine();
                            xDat = myStreamReader.ReadLine();
                            txtCondicionContribuyente.Text = getDatafromXML(xDat, 0);
                        }
                        if (xDat.Contains("Domicilio Fiscal"))
                        {
                            xDat = myStreamReader.ReadLine();
                            txtDireccion.Text = getDatafromXML(xDat, 25);
                        }
                        if (xDat.Contains("Tipo Contribuyente"))
                        {
                            xDat = myStreamReader.ReadLine();
                            txtTipoContribuyente.Text = getDatafromXML(xDat, 25);
                        }

                        //switch (pos) {
                        //    case 126:
                        //        txtTipoContribuyente.Text = getDatafromXML(xDat, 25);
                        //        break;
                        //    //case 131:
                        //    //    txtNombreComercial.Text = xDat.Contains("Nombre Comercial") ? getDatafromXML(xDat, 25) : ""; //getDatafromXML(xDat, 25);
                        //    //    break;
                        //    case 136:
                        //        txtFechaInscripcion.Text = getDatafromXML(xDat, 25);
                        //        break;
                        //    case 138:
                        //        txtFechaInicioActividad.Text = getDatafromXML(xDat, 25);
                        //        break;
                        //    case 142:
                        //        txtEstadoContribuyente.Text = getDatafromXML(xDat, 25);
                        //        break;
                        //    case 152:
                        //        txtCondicionContribuyente.Text = getDatafromXML(xDat, 0);
                        //        break;
                        //    case 158:
                        //        txtDireccion.Text = getDatafromXML(xDat, 25);
                        //        break;
                        //    case 176:
                        //        txtAvtividadComercioEx.Text = getDatafromXML(xDat, 25);
                        //        break;
                        //}
                        txtDireccion.Text = txtDireccion.Text + xDat.ToString();

                    }
                }
                    //ObtenerCapcha();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnroruc.Text.Trim().Length !=11)
                {
                    MessageBox.Show("El nro de RUC no es valido", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BL.Comercial objCo = new BL.Comercial();
                objCo.RegistrarClienteSunat(txtnroRucValue.Text, txtNombreComercial.Text, Convert.ToDateTime(txtFechaInscripcion.Text), txtEstadoContribuyente.Text, txtCondicionContribuyente.Text, txtDireccion.Text, Global.vUserBaseDatos);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
