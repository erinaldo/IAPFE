using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IAP.BE;

namespace IAP.WEB.Mantenimiento
{
    public partial class frmUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            SUsuario.SUsuarioClient objUsuario = new SUsuario.SUsuarioClient();
            List<Usuario> lst = new List<Usuario>();
            lst = objUsuario.ObtenerUsuariosIntranet(txtusuario.Text, "bdNava01").ToList();
            rgusuarios.DataSource = lst;
            rgusuarios.DataBind();
        }

        protected void rgusuarios_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

        }

        protected void rgusuarios_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {

        }
    }
}