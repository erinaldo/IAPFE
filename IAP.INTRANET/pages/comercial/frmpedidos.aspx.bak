<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmpedidos.aspx.cs" Inherits="templateApp.pages.comercial.frmpedidos" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-primary"  >
                <div class="panel-heading">

                    <h2 class="panel-title">Consulta de Documentos</h2>
                </div>
                <div class="panel-body">
                    <div class="row" style="padding-bottom: 10px">
                        <div class="col-md-3">
                            <dx:ASPxLabel Text="Fecha Inicial" runat="server"></dx:ASPxLabel>
                            <dx:ASPxDateEdit ID="dtpfechainicial" runat="server"></dx:ASPxDateEdit> 
                        </div>
                        <div class="col-md-3">
                            <dx:ASPxLabel Text="Fecha Final" runat="server"></dx:ASPxLabel>
                            <dx:ASPxDateEdit ID="dtpfechafinal" runat="server"></dx:ASPxDateEdit>
                        </div>
                        <div class="col-md-3">
                            <dx:ASPxLabel Text="Cliente" runat="server"></dx:ASPxLabel>
                            <dx:ASPxTextBox runat="server" Width="100px"></dx:ASPxTextBox>
                        </div>
                        <div class="col-md-3">
                            <dx:ASPxButton runat="server" Text="Buscar"></dx:ASPxButton>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <dx:ASPxGridView ID="gvwpedidos" ClientInstanceName="grid" runat="server" KeyFieldName="ID"
                                Width="100%" AutoGenerateColumns="False">
                                <Columns>
                                    <dx:GridViewDataTextColumn FieldName="NroPedido" Width="200px" Caption="Nro Pedido" />
                                    <dx:GridViewDataTextColumn FieldName="Fecha" />
                                    <dx:GridViewDataDateColumn FieldName="Cliente" Width="100px" />
                                    <dx:GridViewDataTextColumn FieldName="Moneda" Width="80px" />
                                </Columns>
                                <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowGroupPanel="true" ShowFooter="true" VerticalScrollBarMode="Auto" HorizontalScrollBarMode="Auto" />
                                
                                
                                
                            </dx:ASPxGridView>
                        </div>

                    </div>
                </div>
    </div>

    
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Variables" runat="server">
</asp:Content>
