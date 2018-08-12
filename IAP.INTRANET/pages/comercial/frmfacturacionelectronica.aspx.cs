using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IAP.BL;

namespace templateApp.pages.comercial
{
    public partial class frmfacturacionelectronica : System.Web.UI.Page
    {

        #region PROCEDIMIENTOS
        private void CargarData()
        {
            BFacturacionElectronica bfe = new BFacturacionElectronica();
            string tbldocumentos= bfe.send
        }
        
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    lblmensaje.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}