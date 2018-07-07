<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMenu.aspx.cs" Inherits="IAP.WEB.Menu.frmMenu" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>



<!DOCTYPE html>
<html lang="es">
	<head>
		<title></title>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
        <link href="../bootstrap/csslogin/login_css.css" rel="stylesheet" />
        <link href="../bootstrap/css/bootstrap.min.css" rel="stylesheet" />
        <link href="../bootstrap/cssempresa/css_menu.css" rel="stylesheet" />
	</head>

	<body>
        <form id="frmmenu" runat="server">
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
            <telerik:RadSkinManager ID="RadSkinManager1" runat="server" ShowChooser="false" Visible="false" />
            <div class="demo-container no-bg">
                <img src="../Image/header-home.jpg" class="headerHome" alt="Home" width="730" height="204" />
                <telerik:RadMenu RenderMode="Lightweight" ID="RadMenu1"  runat="server" ShowToggleHandle="true" CssClass="mainMenu">
                    <Items>
                        <telerik:RadMenuItem Text="Inicio" NavigateUrl="frmMenu.aspx" />
                        <telerik:RadMenuItem Text="Mantenimiento">
                            <GroupSettings Width="200px" />
                            <Items>
                                <telerik:RadMenuItem Text="Usuarios" NavigateUrl="../Mantenimiento/frmUsuarios.aspx" EnableImageSprite="true" CssClass="icon-chair"></telerik:RadMenuItem>
                                <telerik:RadMenuItem Text="Cambio de Clave" NavigateUrl="DefaultCS.aspx?page=sofas" EnableImageSprite="true" CssClass="icon-sofa"></telerik:RadMenuItem>
                                <telerik:RadMenuItem Text="Mesas" NavigateUrl="DefaultCS.aspx?page=tables" EnableImageSprite="true" CssClass="icon-table"></telerik:RadMenuItem>
                            </Items>
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem Text="Stores" NavigateUrl="DefaultCS.aspx?page=strores" />
                        <telerik:RadMenuItem Text="About" NavigateUrl="DefaultCS.aspx?page=aboutus" />
                    </Items>
                </telerik:RadMenu>
                <asp:PlaceHolder runat="server" ID="Content" />
            </div>

        </form>
        <script src="../bootstrap/js/jquery.js"></script>
        <script src="../bootstrap/js/bootstrap.min.js"></script>
	</body>
</html>
