<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmusuarios.aspx.cs" Inherits="templateApp.pages.mantenimiento.frmusuarios"  %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>--%>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        function ShowInsertForm(id) {
            window.radopen("frmusuariosMant.aspx?Id=" + id, "rwUsuarios");
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
        
        <%--<telerik:RadScriptManager runat="server" ID="RadScriptManager1" />--%>
    
        <telerik:RadAjaxManager ID="ramUsuarios" runat="server">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="btnbuscar">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl LoadingPanelID="ralpUsuarios" ControlID="rapUsuarios"/>
                            <telerik:AjaxUpdatedControl ControlID="lblmensajes" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>

                    <telerik:AjaxSetting AjaxControlID="rgusuarios">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="rgusuarios" LoadingPanelID="ralpUsuarios" />
                            <telerik:AjaxUpdatedControl ControlID="lblmensajes" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>

                    <telerik:AjaxSetting AjaxControlID="rgusuarios">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="rapUsuarios" ></telerik:AjaxUpdatedControl>
                            <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>

                </AjaxSettings>
        </telerik:RadAjaxManager>
            
        <telerik:RadAjaxLoadingPanel ID="ralpUsuarios" Runat="server" Skin="Default" Height="100%"></telerik:RadAjaxLoadingPanel>

        <telerik:RadWindowManager ID="rwmUsuarios" runat="server" EnableShadow="true">
            <Windows>
                <%--carga la ventana popup--%>
                <telerik:RadWindow ID="rwUsuarios" runat="server" Width="770px" Height="450px" ReloadOnShow="true"
                    ShowContentDuringLoad="false" Behaviors="Close, Move" Modal="true">
                </telerik:RadWindow>

                <%--<telerik:RadWindow ID="rwPDF" runat="server" Width="850px" Height="100%" ReloadOnShow="true"
                    ShowContentDuringLoad="false" Behaviors="Close, Move" Modal="true">
                </telerik:RadWindow>--%>

            </Windows>
        </telerik:RadWindowManager>

        <telerik:RadAjaxPanel ID="rapUsuarios" runat="server" ClientEvents-OnRequestStart="requestStart" > 
        

            <div class="panel panel-primary"  >
                <div class="panel-heading">

                    <h2 class="panel-title">Mantenimiento de Usuarios</h2>
                </div>
                <div class="panel-body">
                
               
                    <div class="row" style="padding-bottom:10px">
                        <div class="col-md-1">
                            <telerik:RadLabel Text="Usuario: " runat="server"></telerik:RadLabel>
                        </div>
          
                        <div class="col-md-4">
                            <%--<telerik:RadTextBox runat="server" ID="txtusuario" placeholder="Nombre del usuario" Width="100%"></telerik:RadTextBox>--%>
                            <asp:TextBox ID="txtusuario2" runat="server" Width="100%" placeholder="Nombre del usuario" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-7">
                            
                            <telerik:RadButton runat="server" ID="btnbuscar" Text="Buscar Usuario"  OnClick="btnbuscar_Click" OnClientClicked="btnbuscar_Click"></telerik:RadButton>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <telerik:RadGrid RenderMode="Lightweight" ID="rgusuarios" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False"
                                OnNeedDataSource="rgusuarios_NeedDataSource"
                            
                                OnItemCommand="rgusuarios_ItemCommand" CellSpacing="1" GridLines="Both" Height="800px">
                                <GroupingSettings CaseSensitive="false" />
                                <MasterTableView AutoGenerateColumns="false" DataKeyNames="Id" ClientDataKeyNames="Id">
                                    <Columns>
                                        <telerik:GridTemplateColumn HeaderText="Edit." AllowFiltering="false">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="imgbtnEditar" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="EditarUsuario"
                                                    ImageUrl="~/imagenes/pencil-16.png" />
                                            </ItemTemplate>
                                            <%--<HeaderStyle Width="40px" />--%>
                                        </telerik:GridTemplateColumn>
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
                                    
                                    <Scrolling AllowScroll="True"  SaveScrollPosition="true" FrozenColumnsCount="3"></Scrolling>
                                    <Selecting AllowRowSelect="True"></Selecting>
                                </ClientSettings>
                            </telerik:RadGrid>
                        </div>
                    </div>
                 </div>
               
            </div>

        </telerik:RadAjaxPanel>

        

        
</asp:Content>

<asp:Content ID="contentVariables" ContentPlaceHolderID="Variables" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:label ID="lblprocesogrilla" runat="server" />
            </div>
            <div class="col-md-12">
                <asp:label ID="lblmensajes" runat="server" />
            </div>
        </div>
        
    </div>
</asp:Content>
