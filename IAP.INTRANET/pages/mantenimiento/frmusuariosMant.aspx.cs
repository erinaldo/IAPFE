using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IAP.BE;


namespace templateApp.pages.mantenimiento
{
    public partial class frmusuariosMant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    lblId.Value = Request.QueryString["Id"].ToString();
                    Session["Id"] = lblId.Value.ToString();
                    CargarData(lblId.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                lblmensajes.Text = "ERROR: " + ex.Message;
                lblmensajes.CssClass = "mensajeError";
            }
        }
        #region Procedimientos
        private void CargarData(string id)
        {
            List<Usuario> lstusu = new List<Usuario>();
            SUsuario.SUsuarioClient objSusuario = new SUsuario.SUsuarioClient();
            lstusu = objSusuario.ObtenerUsuariosIntranet(Convert.ToInt32(lblId.Value), string.Empty, 0, "BdNava01").ToList();
            txtapellidos.Text = lstusu.Select(x => x.Apellidos).First();
            txtemail.Text = lstusu.Select(x => x.Correo).First();
            txtid.Text = id;
            txtnombre.Text = lstusu.Select(x => x.Nombres).First();
            txtpassword.Text = lstusu.Select(x => x.Contrasena).First();
            txtrazonsocial.Text = lstusu.Select(x => x.RazonSocial).First();
        }
        private void RegistrarUsuarioIntranet()
        {
            try
            {
                SUsuario.SUsuarioClient objUsuario = new SUsuario.SUsuarioClient();
                Usuario eu = new Usuario(
                    txtid.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtid.Text.Trim()),
                    txtnombre.Text,
                    txtapellidos.Text,
                    txtrazonsocial.Text,
                    txtemail.Text,
                    txtpassword.Text,
                    DateTime.Now);
                objUsuario.RegistrarUsuarioIntranet(eu, "BdNava01");
            }
            catch(Exception ex)
            {
                lblmensajes.Text = "ERROR: "+ ex.Message.ToString();
                
            }
            
        }
        private bool ValidarDatos()
        {
            if(txtnombre.Text.Trim()==string.Empty)
            {
                lblmensajes.Text = "ERROR: El campo Nombre es obligatorio";
                return false;
            }
            else if(txtemail.Text.Trim()==string.Empty)
            {
                lblmensajes.Text = "ERROR: El campo Email es obligatorio";
                return false;
            }
            else if(txtpassword.Text.Trim()==string.Empty)
            {
                lblmensajes.Text = "ERROR: El campo password es obligatorio";
                return false;
            }
            return true;
        }
        

        #endregion

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
                RegistrarUsuarioIntranet();
        }

        protected void btnsalir_Click(object sender, EventArgs e)
        {

            //ScriptManager.RegisterStartupScript(Page, this.GetType(), "mykey", "CloseAndRebind(1);", true);
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "CloseRadWindow();", true);
            //Response.Redirect("~/pages/mantenimiento/frmusuarios.aspx");
            //Response.Redirect("~/Security/frmCerrar.aspx");
        }
    }
}