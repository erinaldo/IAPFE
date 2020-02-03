using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Net;
using IAP.BE;
using IAP.BL;
using DevExpress.Utils;

namespace IAP.Win.Mensajeria
{
    public partial class frm_EnvioEmail : Form
    {
        public string _cdocu;
        public string _ndocu;
        public string _ruccli;
        public string _nomcli;
        public string _serie;
        public string _numero;
        public string _moneda;
        public double _total;
        public DateTime _fechadocumento;
        BL.BFacturacionElectronica BLFe = new BFacturacionElectronica();
        public frm_EnvioEmail()
        {
            InitializeComponent();
            
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtto.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("No ha ingresado un correo destino, por favor ingrese un correo válido", "ERP Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Desea enviar el correo electronico?", "ERP Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Enviando Correo>>>>"))
                    {
                        EnvioCorreo(_nomcli, txtto.Text, "", txtcc.Text.Trim() == string.Empty ? null : txtcc.Text.Trim(), "Envio de Documento Electrónico", _serie, _numero, _nomcli, _fechadocumento,
                    _total, _moneda);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void EnvioCorreo(string to, string toCorreo, string cc, string ccCorreo, string asunto, string cdocu, string ndocu, string cliente, DateTime fecha, double monto, string moneda)
        {
            using (SmtpClient client = new SmtpClient())
            {
                try
                {

                    var host = ConfigurationSettings.AppSettings["SmtpHost"];
                    var port = ConfigurationSettings.AppSettings["SmtpPort"];
                    var credentialUser = ConfigurationSettings.AppSettings["SmtpCredentialUser"];
                    var credentialPass = ConfigurationSettings.AppSettings["SmtpCredentialPass"];

                    client.Host = host.ToString();
                    client.Port = int.Parse(port);
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(credentialUser.ToString(), credentialPass.ToString());


                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(credentialUser.ToString(), "Ventas " + Global.vUserNombreEmpresa);

                    message.To.Add(new MailAddress(toCorreo, to));
                    if (ccCorreo != null && cc != null) message.CC.Add(new MailAddress(ccCorreo, ccCorreo));
                    message.Subject = asunto;

                    message.Body = Mensaje(cdocu, ndocu, cliente, fecha, monto, moneda,txtmensaje.Text.ToString().Trim());
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
        public string Mensaje(string cdocu, string ndocu, string cliente, DateTime fecha, double monto, string moneda,string mensajepersonalizado)
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
            mensaje += "<td style=\"width: 293px; \">" + Global.vUserNombreEmpresa +  "</td>";
            mensaje += "<td style=\"width: 118px; \" bgcolor=\"#DCDFF3\"><strong>RUC</strong></td>";
            mensaje += "<td style=\"width: 118px; \">&nbsp;" + Global.vUserRucEmpresa + " </td>";
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
            mensaje += "<p>" + mensajepersonalizado +"</p>";
            mensaje += "<p>Atte.</p>";
            mensaje += "<p>Ventas - Perfiles Metalicos J&amp;J</p>";
            mensaje += "<p>&nbsp;</p>";
            mensaje += "<p>&nbsp;</p>";
            mensaje += "</body>";
            mensaje += "</html>";

            return mensaje;
        }

        private void frm_EnvioEmail_Load(object sender, EventArgs e)
        {
            lblTo.Text = ConfigurationSettings.AppSettings["SmtpCredentialUser"].ToString();
            txtto.Text = "";
            Cliente cli = BLFe.ObtenerEmailCliente(_ruccli, Global.vUserBaseDatos);
            txtto.Text = cli.Email;

        }
    }
}
