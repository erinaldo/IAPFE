<%@ Page Title="" Language="C#" MasterPageFile="~/popup.Master" AutoEventWireup="true" CodeBehind="frmusuariosMant.aspx.cs" Inherits="templateApp.pages.mantenimiento.frmusuariosMant" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        function CloseRadWindow() {
            //get a reference to the current RadWindow
            var wndow = GetRadWindow();
            wndow.Close();
        }
        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow;
            else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
            return oWindow;
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-primary"  >
                <div class="panel-heading">

                    <h2 class="panel-title">Edicion de Usuario</h2>
                </div>
                <div class="panel-body">
                
                    <div class="row" style="padding-bottom:5px;">
                        <div class="col-xs-1">
                            <telerik:RadLabel Text="Id" runat="server"></telerik:RadLabel>
                        </div>
                        <div class="col-xs-2">
                            <asp:TextBox ID="txtid" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="col-xs-9"></div>

                    </div>
                    <div class="row" style="padding-bottom:5px;">
                        <div class="col-xs-1">
                            <telerik:RadLabel Text="Nombres: " runat="server" RequiredMark=""></telerik:RadLabel>
                            
                        </div>
                        <div class="col-xs-4">
                            <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                            
                        </div>
                        <div class="col-xs-1">
                            <telerik:RadLabel Text="Apellidos" runat="server"></telerik:RadLabel>
                        </div>
                        <div class="col-xs-6">
                            <asp:TextBox ID="txtapellidos" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                        </div>
                        
                    </div>
                    <div class="row" style="padding-bottom:5px;">
                        <div class="col-xs-1">
                            <telerik:RadLabel Text="Razon Social" runat="server"></telerik:RadLabel>
                        </div>
                        <div class="col-xs-11">
                            <asp:TextBox ID="txtrazonsocial" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        
                    </div>
                    <div class="row" style="padding-bottom:5px;">
                        <div class="col-xs-1">
                            <telerik:RadLabel Text="Email: " runat="server"></telerik:RadLabel>
                        </div>
                        <div class="col-xs-4">
                            <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-xs-1">
                            <telerik:RadLabel Text="Password" runat="server"></telerik:RadLabel>
                        </div>
                        <div class="col-xs-6">
                            <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                        </div>
                        
                    </div>

                    <div class="row" style="padding-bottom:25px;">
                        
                            <div class="col-xs-4 col-md-offset-3">
                                <asp:Button CssClass="btn-primary" runat="server" Text="Guardar" ID="btnguardar" OnClick="btnguardar_Click" />
                            </div>
                            <div class="col-xs-4 col-md-offset-3">
                                <asp:Button CssClass="btn-primary" runat="server" Text="Salir" ID="btnsalir" OnClick="btnsalir_Click" />
                            </div>
                            <div class="col-xs-4">
                            </div>
                        
                        
                    </div>
                </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mensajes" runat="server">
            <div class="row">
                <asp:HiddenField ID="lblId" runat="server" />
                <div class="col-xs-12">
                    <asp:Label ID="lblprocesogrilla" runat="server" />
                </div>
                <div class="col-xs-12">
                    <asp:Label ID="lblmensajes" runat="server" CssClass="Error" />
                </div>
            </div>
</asp:Content>

