using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using IAP.BL;
using IAP.BE;
using System.Data;

namespace EnvioDocElectronico
{
    class Program
    {
        public static IAP.BL.BFacturacionElectronica blFE = new BFacturacionElectronica();
        static void Main(string[] args)
        {
            List<EnvioEmailFE> lst = new List<EnvioEmailFE>();
            string basedatos= ConfigurationSettings.AppSettings["BD"].ToString();

            try
            {
                lst = blFE.ObtenerDocumentosPendientes_EnvioFE(basedatos);
                foreach (EnvioEmailFE e in lst.Where(x=> x.Correo.Trim()!= string.Empty).ToList())
                {
                    try
                    {
                        EnvioCorreo(e.Correo, e.Correo, "", "", "Envio de Documento Electrónico", e.SerieFE, e.NumeroFE, e.Nomcli, e.Fecha,
                    e.Totn, e.Moneda);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error al enviar el Correo: " + ex.Message);
                    }
                    finally
                    {
                        
                    }
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }

        public static void EnvioCorreo(string to, string toCorreo, string cc, string ccCorreo, string asunto, string cdocu, string ndocu, string cliente, DateTime fecha, double monto, string moneda)
        {
            using (SmtpClient client = new SmtpClient())
            {
                try
                {

                    var host = ConfigurationSettings.AppSettings["SmtpHost"];
                    var port = ConfigurationSettings.AppSettings["SmtpPort"];
                    var credentialUser = ConfigurationSettings.AppSettings["SmtpCredentialUser"];
                    var credentialPass = ConfigurationSettings.AppSettings["SmtpCredentialPass"];
                    string rucEmisor= ConfigurationSettings.AppSettings["RucEmisor"];

                    client.Host = host.ToString();
                    client.Port = int.Parse(port);
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(credentialUser.ToString(), credentialPass.ToString());


                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(credentialUser.ToString(), "Ventas Perfiles Metalicos J&J");

                    message.To.Add(new MailAddress(toCorreo, to));
                    //if (ccCorreo != null && cc != null) message.CC.Add(new MailAddress(ccCorreo, cc));
                    message.Subject = asunto;

                    message.Body = Mensaje(cdocu, ndocu, cliente, fecha, monto, moneda, rucEmisor);
                    //message.BodyEncoding = Encoding.UTF8;
                    message.IsBodyHtml = true;
                    client.Send(message);

                }
                catch (Exception ex)
                {
                    throw new ArgumentException("" + ex.Message);

                }


            }
        }
        public static string Mensaje(string cdocu, string ndocu, string cliente, DateTime fecha, double monto, string moneda,string rucEmisor)
        {
            string mensaje = "";
            mensaje += "<html>";
            mensaje += "<body>";
            mensaje += "<p>Estimado cliente,</p>";
            mensaje += "<p>se le informa que puede descargar su comprobante electr&oacute;nico desde el siguiente link:</p>";
            mensaje += "<p><a href=\"https://app.facturaonline.pe/invitado#/formulario\" target=\"_blank\" rel=\"noopener\">www.facturaonline.pe</a></p>";
            mensaje += "<table style=\"height: 49px; width: 515px; \" border=\"1px\">";
            mensaje += "<tbody>";
            mensaje += "<tr>";
            mensaje += "<td style=\"width: 86px; \" bgcolor=\"#DCDFF3\"><strong>Empresa</strong></td>";
            mensaje += "<td style=\"width: 293px; \">Perfiles Metalicos J&amp;J</td>";
            mensaje += "<td style=\"width: 118px; \" bgcolor=\"#DCDFF3\"><strong>RUC</strong></td>";
            mensaje += "<td style=\"width: 118px; \">&nbsp;" + rucEmisor  +"</td>";
            mensaje += "</tr>";
            mensaje += "<tr>";
            mensaje += "<td style=\"width: 86px; \" bgcolor=\"#DCDFF3\"><strong>Cliente</strong></td>";
            mensaje += "<td style=\"width: 293px; \" colspan=\"3\">" + cliente + "</td>";
            mensaje += "</tr>";
            mensaje += "<tr>";
            mensaje += "<td style=\"width: 86px; \" bgcolor=\"#DCDFF3\"><strong>Documento</strong></td>";
            mensaje += "<td style=\"width: 293px; \">" + cdocu + "-" + ndocu + "</td>";
            mensaje += "<td style=\"width: 118px; \" bgcolor=\"#DCDFF3\"><strong>Fecha</strong></td>";
            mensaje += "<td style=\"width: 118px; \">&nbsp;" + fecha.ToShortDateString() + "</td>";
            mensaje += "</tr>";
            mensaje += "<tr>";
            mensaje += "<td style=\"width: 86px; \" bgcolor=\"#DCDFF3\"><strong>Moneda</strong></td>";
            mensaje += "<td style=\"width: 293px; \">" + moneda + "</td>";
            mensaje += "<td style=\"width: 118px; \" bgcolor=\"#DCDFF3\"><strong>Monto</strong></td>";
            mensaje += "<td style=\"width: 118px; \">&nbsp;" + Convert.ToString(monto) + "</td>";
            mensaje += "</tr>";
            mensaje += "</tbody>";
            mensaje += "</table>";
            mensaje += "<p>Atte.</p>";
            mensaje += "<p>Ventas - Perfiles Metalicos J&amp;J</p>";
            mensaje += "<p>&nbsp;</p>";
            mensaje += "<p>&nbsp;</p>";
            mensaje += "</body>";
            mensaje += "</html>";

            return mensaje;
        }

        //public DataSet ListarDataSet(string query)
        //{

        //    Database db;
        //    //db = string.Format(ConfigurationManager.ConnectionStrings[dci.Empresa.SingleOrDefault(x => x.idEmpresa == idEmpresa).baseDatos].ConnectionString, "usrGEN" + (10000 + codigoUsuario).ToString().Substring(1, 4));
        //    //string coneccion;
        //    //coneccion = GS.configuration.Init.GetValue(Constant.sistema, Constant.key, Constant.BD);
        //    //coneccion = ConfigurationManager.ConnectionStrings["genesys"].ConnectionString; 

        //    //db = new SqlDatabase(ConfigurationManager.ConnectionStrings["genesys"].ConnectionString);
        //    db = new SqlDatabase(GS.configuration.Init.GetValue(Constant.sistema, Constant.key, Constant.BD));

        //    DataSet ds = null;
        //    using (DbConnection connection = db.CreateConnection())
        //    {
        //        connection.Open();
        //        ds = db.ExecuteDataSet(CommandType.Text, query);
        //        connection.Close();
        //    }
        //    return ds;
        //}
    }
}
