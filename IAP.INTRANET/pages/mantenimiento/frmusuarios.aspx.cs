using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IAP.BE;
using System.Configuration;

namespace templateApp.pages.mantenimiento
{
    public partial class frmusuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                if (!Page.IsPostBack)
                {
                    lblmensajes.Text = string.Empty;
                }    
                
            }
            catch (Exception ex)
            {

            }
        }
        #region PROCESOS
        private void BuscarUsuarios()
        {
            SUsuario.SUsuarioClient objUsuario = new SUsuario.SUsuarioClient();
            List<Usuario> lst = new List<Usuario>();
            
            string sqlcn = ConfigurationManager.ConnectionStrings["BdNava01"].ConnectionString;
            lst = objUsuario.ObtenerUsuariosIntranet(0,txtusuario2.Text,1, "bdNava01").ToList();
            ViewState["lstusuarios"] = lst;
            rgusuarios.DataSource = lst;
            rgusuarios.DataBind();
            lblprocesogrilla.Text = "1";
            //hdProceoGrilla
        }
        #endregion
        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        protected void rgusuarios_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if(lblprocesogrilla.Text == "1")
            {
                rgusuarios.DataSource =(List<Usuario>)ViewState["lstusuarios"];
                //rgusuarios.DataBind();
            }
        }

        protected void rgusuarios_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarUsuario")
                {
                    Response.Redirect("~/pages/mantenimiento/frmusuariosmant.aspx?Id=" + e.CommandArgument.ToString());
                    // ScriptManager.RegisterStartupScript(Page, this.GetType(), "mykey", "ShowInsertForm(" + e.CommandArgument + ");", true);
                    //txtusuario2.Text = "hola";
                }
            }
            catch (Exception ex)
            {
                lblmensajes.Text = ex.ToString();
            }
        }
    }
}