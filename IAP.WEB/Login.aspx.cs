using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IAP.BE;
using IAP.BL;

namespace IAP.WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncliente_Click(object sender, EventArgs e)
        {
            
            
            SUsuario.SUsuarioClient objUsuario = new SUsuario.SUsuarioClient();
            Boolean ExisteUsuario = objUsuario.ObtenerExistenciaUsuario(txtcorreo.Text, txtcontrasena.Text);
            if (ExisteUsuario)
                Response.Redirect("inicio.aspx");
        }
    }
}