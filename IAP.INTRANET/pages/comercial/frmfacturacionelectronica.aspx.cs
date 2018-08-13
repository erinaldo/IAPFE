using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IAP.BL;
using IAP.BE;
using IAP.DL;
using Newtonsoft.Json;
namespace templateApp.pages.comercial
{
    public partial class frmfacturacionelectronica : System.Web.UI.Page
    {
        Procedimientos_GeneralesDL dl = new Procedimientos_GeneralesDL();
        List<Documentov> lstdv = new List<Documentov>();
        List<DocumentovDet> lstdvdet = new List<DocumentovDet>();
        string ruta = string.Empty;
        string respuesta = string.Empty;

        #region PROCEDIMIENTOS
        private void CargarTipoDocumento()
        {
            //BFacturacionElectronica bfe = new BFacturacionElectronica();
            Procedimientos_GeneralesBL bp = new Procedimientos_GeneralesBL();
            dynamic lst;
            ruta = "http://servicio.constructoratgo.com/api/procedimientos/GetTbl01Doc";
            respuesta = bp.ObtenerDataApiRest(ruta,string.Empty, "token");
            //lst = JsonHelper.JsonDeserialize<List<TipoDocumento>>((string)respuesta);
            lst = JsonConvert.DeserializeObject<dynamic>((string)respuesta);

            cmbtipodocumento.DataSource = lst;
            cmbtipodocumento.DataTextField = "Ndocu";
            cmbtipodocumento.DataValueField = "Cdocu";
            cmbtipodocumento.DataBind();
            cmbtipodocumento.SelectedIndex = 0;
        }
        private void CargarDocumentosCab()
        {
            Procedimientos_GeneralesBL bp = new Procedimientos_GeneralesBL();
            ruta = "http://servicio.constructoratgo.com/api/fe/GetMst01fac";
            GetMst01Fac e = new GetMst01Fac {
                cdocu = cmbtipodocumento.SelectedValue,
                fechai = Convert.ToDateTime(dpfechainicial.SelectedDate),
                fechaf = Convert.ToDateTime(dpfechafinal.SelectedDate),
                cliente = txtcliente.Text.Trim(),
                documento = string.Empty,
                enviadosunat = 2,
                anulado = 0
            };

            respuesta = bp.ObtenerDataApiRest(ruta,e, "token");
            lstdv=JsonHelper.JsonDeserialize<List<Documentov>>((string)respuesta);
            gvwcabecera.DataSource = lstdv;
            gvwcabecera.DataBind();
        }
        
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    lblmensaje.Text = string.Empty;
                    dpfechainicial.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    dpfechafinal.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    CargarTipoDocumento();
                    CargarDocumentosCab();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}