using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace IAP.WEB.Menu
{
    public partial class frmMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnInit(EventArgs e)
        {

            RadMenuItem currentItem = RadMenu1.FindItemByUrl(Request.Url.PathAndQuery);
            if (currentItem != null)
            {
                currentItem.HighlightPath();

                switch (currentItem.Text)
                {
                    case "Home":
                        Control userControlHome = Page.LoadControl("frmMenu.aspx");
                        Content.Controls.Add(userControlHome);
                        break;
                    case "Usuarios":
                        Control userControlChairs = Page.LoadControl("../Mantenimiento/frmUsuarios.aspx");
                        Content.Controls.Add(userControlChairs);
                        break;
                    case "Sofas":
                        Control userControlSofas = Page.LoadControl("UserControls/Sofas.ascx");
                        Content.Controls.Add(userControlSofas);
                        break;
                    case "Tables":
                        Control userControlTables = Page.LoadControl("UserControls/Tables.ascx");
                        Content.Controls.Add(userControlTables);
                        break;
                    case "Stores":
                        Control userControl = Page.LoadControl("UserControls/Stores.ascx");
                        Content.Controls.Add(userControl);
                        break;
                    case "About":
                        Control userControlAbout = Page.LoadControl("UserControls/About.ascx");
                        Content.Controls.Add(userControlAbout);
                        break;
                }
            }
            else
            {
                Control userControlHome = Page.LoadControl("UserControls/Home.ascx");
                Content.Controls.Add(userControlHome);
            }


            base.OnInit(e);
        }
    }
}