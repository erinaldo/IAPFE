<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmfacturacionelectronica.aspx.cs" Inherits="templateApp.pages.comercial.frmfacturacionelectronica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <telerik:RadAjaxManager ID="ramFE" runat="server">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="btnbuscar">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl LoadingPanelID="ralpFE" ControlID="rapFE"/>
                            <telerik:AjaxUpdatedControl ControlID="lblmensajes" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>

                    <telerik:AjaxSetting AjaxControlID="gvwFE">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="gvwFE" LoadingPanelID="ralpFE" />
                            <telerik:AjaxUpdatedControl ControlID="lblmensajes" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>

                    <telerik:AjaxSetting AjaxControlID="gvwFE">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="rapFE" ></telerik:AjaxUpdatedControl>
                            <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    
                </AjaxSettings>
        </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="ralpFE" Runat="server" Skin="Default" Height="100%"></telerik:RadAjaxLoadingPanel>

        <telerik:RadWindowManager ID="rwmFE" runat="server" EnableShadow="true">
            <Windows>
                <telerik:RadWindow ID="rwFE" runat="server" Width="770px" Height="450px" ReloadOnShow="true"
                    ShowContentDuringLoad="false" Behaviors="Close, Move" Modal="true">
                </telerik:RadWindow>

            </Windows>
        </telerik:RadWindowManager>

        <telerik:RadAjaxPanel ID="rapFE" runat="server" >
            <div class="panel panel-primary"  >
                <div class="panel-heading">

                    <h2 class="panel-title">Consulta de Documentos</h2>
                </div>
                <div class="panel-body">
                    
                    <div class="row" style="padding-bottom: 10px">
                        <%--<div class="col-md-2">
                            <telerik:RadLabel Text="Fecha Inicial" runat="server" Width="100%"></telerik:RadLabel>
                        </div>--%>
                        <div class="col-md-3">
                            <telerik:RadDatePicker ID="dpfechainicial" runat="server" Width="100%" DateInput-ReadOnly="true" DateInput-Label="Fecha Inicial" DateInput-LabelWidth="48%" >
                                <DateInput runat="server" DateFormat="dd/MM/yyyy"></DateInput>
                            </telerik:RadDatePicker>
                        </div>
                        
                        <div class="col-md-3">
                            <telerik:RadDatePicker ID="dpfechafinal" runat="server" Width="100%" DateInput-ReadOnly="true" DateInput-Label="Fecha Final">
                                <DateInput runat="server" DateFormat="dd/MM/yyyy"></DateInput>
                            </telerik:RadDatePicker>
                        </div>
                        <div class="col-md-4">
                            <telerik:RadRadioButtonList ID="rbtnestados" runat="server" Direction="Horizontal" CssClass="custom-control-input" >
                                <Items>
                                    <telerik:ButtonListItem Text="Enviado" Value="1" />
                                    <telerik:ButtonListItem Text="Sin Enviar" Value="0" />
                                    <telerik:ButtonListItem Text="Todos" Value="2" />
                                </Items>
                            </telerik:RadRadioButtonList>
                            <%--<asp:RadioButtonList ID="rbtnestado" runat="server">
                                <asp:ListItem Text ="Enviado" Value="1" />
                                <asp:ListItem Text ="Sin Enviar" Value="0" />
                                <asp:ListItem Text ="Todo" Value="2" />
                            </asp:RadioButtonList>--%>
                        </div>
                        
                        <div class="col-md-2"></div>
                    </div>



                    <div class="row" style="padding-bottom: 10px">
                        
                        <div class="col-md-3">
                            <telerik:RadComboBox ID="cmbtipodocumento" runat="server" CheckBoxes="true" Label="Tipo Documento">
                            </telerik:RadComboBox>
                        </div>
                        <div class="col-md-6">
                            <telerik:RadTextBox runat="server" ID="txtcliente" Label="Cliente" LabelWidth="17%" Width="100%" CssClass="form-control"></telerik:RadTextBox>
                        </div>
                        <div class="col-md-1">
                            <telerik:RadButton ID="btnbuscar" runat="server" Text="Buscar"></telerik:RadButton>
                        </div>
                        <div class="col-md-2"></div>
                    </div>
                    
                    
                    <div class="row">
                        <div class="col-md-12">
                            <telerik:RadGrid RenderMode="Lightweight" ID="gvwcabecera" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" CellSpacing="1" GridLines="Both" Height="300px">
                                
                                <MasterTableView AutoGenerateColumns="false">
                                    <Columns>
                                        <%--<telerik:GridTemplateColumn HeaderText="Edit." AllowFiltering="false">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="imgbtnEditar" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="EditarUsuario"
                                                    ImageUrl="~/imagenes/pencil-16.png" />
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>--%>

                                        <telerik:GridCheckBoxColumn DataField="FlgCheck" HeaderText="Seleccionar" UniqueName="FlgCheck">
                                        </telerik:GridCheckBoxColumn>

                                        <telerik:GridBoundColumn DataField="Fecha" HeaderText="Fecha"  UniqueName="Fecha">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Cdocu" HeaderText="Tipo Doc" UniqueName="Cdocu">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Ndocu" HeaderText="Numero Doc" UniqueName="Ndocu">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Drefe" HeaderText="DRefe"  UniqueName="Drefe">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Crefe" HeaderText="Tipo Ref."  UniqueName="Crefe">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Nrefe" HeaderText="Numero Ref."  UniqueName="Nrefe">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Cli.Nombre" HeaderText="Cliente" UniqueName="Cli.Nombre">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Cli.Ruc" HeaderText="Ruc" UniqueName="Cli.Ruc">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="CondicionV.Codcdv" HeaderText="Codcdv"  UniqueName="CondicionV.Codcdv">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="CondicionV.Nomcdv" HeaderText="Condicion Venta"  UniqueName="CondicionV.Nomcdv">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Flag" HeaderText="Flag"  UniqueName="Flag">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Estado" HeaderText="Estado"  UniqueName="Estado">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Mone" HeaderText="Moneda"  UniqueName="Mone">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Tcam" HeaderText="TCambio"  UniqueName="Tcam">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Tota" HeaderText="Total"  UniqueName="Tota">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Toti" HeaderText="Total Igv"  UniqueName="Toti">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Totn" HeaderText="Total Neto"  UniqueName="Totn">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Flg_Fe" HeaderText="Flag_Fe"  UniqueName="Flg_Fe">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="EstadoFe" HeaderText="Estado FE"  UniqueName="EstadoFe">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Serie" HeaderText="Serie"  UniqueName="Serie">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Numero" HeaderText="Numero"  UniqueName="Numero">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Enlace" HeaderText="Enlacce"  UniqueName="Enlace">
                                        </telerik:GridBoundColumn>

                                        <%--<telerik:GridBoundColumn DataField="AceptadaPorSunat" HeaderText="Correo"  UniqueName="column5">
                                        </telerik:GridBoundColumn>--%>

                                        <telerik:GridCheckBoxColumn DataField="AceptadaPorSunat" HeaderText="AceptadaPorSunat"  UniqueName="AceptadaPorSunat">
                                        </telerik:GridCheckBoxColumn>

                                        <telerik:GridBoundColumn DataField="SunatDescription" HeaderText="SunatDescription"  UniqueName="SunatDescription">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="SunatNote" HeaderText="SunatNote"  UniqueName="SunatNote">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="SunatResponseCode" HeaderText="SunatResponseCode"  UniqueName="SunatResponseCode">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="SunatSoapError" HeaderText="SunatSoapError"  UniqueName="SunatSoapError">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="EnlaceDelPdf" HeaderText="EnlaceDelPdf"  UniqueName="EnlaceDelPdf">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="EnlaceDelPdfAnulado" HeaderText="EnlaceDelPdfAnulado"  UniqueName="EnlaceDelPdfAnulado">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="EnlaceDelCdr" HeaderText="EnlaceDelCdr"  UniqueName="EnlaceDelCdr">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="EnlaceDelXml" HeaderText="EnlaceDelXml"  UniqueName="EnlaceDelXml">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Tipo_de_comprobante" HeaderText="Tipo_de_comprobante"  UniqueName="Tipo_de_comprobante">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Motivo_Anulacion" HeaderText="Motivo_Anulacion"  UniqueName="Motivo_Anulacion">
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

                    <div class="row">
                        <div class="col-md-12">
                            <asp:Label Text="..:Detalle:.." runat="server"></asp:Label>
                        </div>
                        
                    </div>

                    <div class="row">
                        <div class="col-md-12">
                            <telerik:RadGrid RenderMode="Lightweight" ID="gvwdetalle" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" CellSpacing="1" GridLines="Both" Height="300px">
                                <MasterTableView AutoGenerateColumns="false">
                                    <Columns>
                                        

                                        <telerik:GridBoundColumn DataField="Product.Codi" HeaderText="Codigo Sistema"  UniqueName="Product.Codi">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Product.Codf" HeaderText="Codigo Usuario" UniqueName="Product.Codf">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn DataField="Product.Marc" HeaderText="Marca" UniqueName="Product.Marc">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Product.Descr" HeaderText="Descripción"  UniqueName="Product.Descr">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Product.Umed" HeaderText="Unidad Medida"  UniqueName="Product.Umed">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Cant" HeaderText="Cantidad"  UniqueName="Cant">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Preu" HeaderText="Precio Unit." UniqueName="Preu">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="Total" HeaderText="Total" UniqueName="Total">
                                        </telerik:GridBoundColumn>


                                    </Columns>
                                </MasterTableView>
                                <ClientSettings>
                                    
                                    <Scrolling AllowScroll="True"  SaveScrollPosition="true"></Scrolling>
                                    <Selecting AllowRowSelect="True"></Selecting>
                                </ClientSettings>
                            </telerik:RadGrid>
                        </div>
                    </div>

                 </div>
               
            </div>
        </telerik:RadAjaxPanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Variables" runat="server">
</asp:Content>
