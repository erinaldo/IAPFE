<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="IAP.WEB.prueba" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" Culture="es-ES">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
            <ClientSettings>
                <Selecting AllowRowSelect="True" />
                <Scrolling AllowScroll="True" UseStaticHeaders="True" />
            </ClientSettings>
            <MasterTableView>
                <Columns>
                    <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" DataField="IdUsuario" FilterControlAltText="" HeaderText="dfdfdf" UniqueName="column">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn FilterControlAltText="Filter column1 column" UniqueName="column1">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn FilterControlAltText="Filter column2 column" UniqueName="column2">
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    
    </div>
    </form>
</body>
</html>
