<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/frmMaestro.Master" CodeBehind="frmUsuarios.aspx.cs" Inherits="IAP.WEB.Mantenimiento.frmUsuarios" validateRequest="false" enableEventValidation="false" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <%--<telerik:RadScriptManager runat="server" ID="RadScriptManager1" />--%>
    
        <telerik:RadAjaxManager ID="ramUsuarios" runat="server">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="panel1">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="panel1" LoadingPanelID="ralpUsuarios" />
                            <%--<telerik:AjaxUpdatedControl ControlID="rapUsuarios" LoadingPanelID="ralpUsuarios" />

                            <telerik:AjaxUpdatedControl ControlID="rgusuarios" LoadingPanelID="ralpUsuarios"/>--%>
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                </AjaxSettings>
        </telerik:RadAjaxManager>
            <telerik:RadAjaxPanel ID="rapUsuarios" runat="server">
                </telerik:RadAjaxPanel>
        <telerik:RadAjaxLoadingPanel ID="ralpUsuarios" Runat="server" Skin="Default">
        </telerik:RadAjaxLoadingPanel>



        <asp:Panel ID="panel1" runat="server">
            <div >
                <div class="row">
                    <div class="col-md-12">
                        <h2>Mantenimiento de Usuarios</h2>
                    </div>
                </div>
                <div class="row" >
                    <div class="col-md-1">
                        <telerik:RadLabel Text="Usuario: " runat="server"></telerik:RadLabel>
                    </div>
          
                    <div class="col-md-1">
                        <telerik:RadTextBox runat="server" ID="txtusuario" placeholder="Nombre del usuario" Width="100%"></telerik:RadTextBox>
                    </div>
                    <div class="col-md-9">
                        <telerik:RadButton runat="server" ID="btnbuscar" Text="Buscar Usuario" class="btn btn-primary" OnClick="btnbuscar_Click"></telerik:RadButton>
                    </div>
                </div>
                <div class="row" >
                    <div class="row">
                        <div class="col-md-12">
                        
                            <telerik:RadGrid RenderMode="Lightweight" ID="rgusuarios" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False"
                                OnNeedDataSource="rgusuarios_NeedDataSource"
                            
                                OnItemCommand="rgusuarios_ItemCommand" CellSpacing="1" GridLines="Both">
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView>
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="Id" HeaderText="Id" AndCurrentFilterFunction="Contains" UniqueName="column1">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Nombres" HeaderText="Nombres" AndCurrentFilterFunction="Contains" UniqueName="column2">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Apellidos" HeaderText="Apellidos"  UniqueName="column3">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="RazonSocial" HeaderText="Razon Social"  UniqueName="column4">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Correo" HeaderText="Correo"  UniqueName="column5">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Contrasena" HeaderText="Contraseña" UniqueName="column6">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="FechaRegistro" HeaderText="Fecha Registro"  UniqueName="column7">
                                        </telerik:GridBoundColumn>
                                    
                                    </Columns>
                                </MasterTableView>
                                <ClientSettings>
                                    <Selecting AllowRowSelect="true" />
                                    <Scrolling AllowScroll="true"/>
                                </ClientSettings>
                            </telerik:RadGrid>
                        </div>
                    </div>
                </div>
    
            </div>

    </asp:Panel>

        

        
</asp:Content>
