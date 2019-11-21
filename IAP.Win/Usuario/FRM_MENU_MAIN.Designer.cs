namespace IAP.Win
{
    partial class FRM_MENU_MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MENU_MAIN));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupComercial = new DevExpress.XtraNavBar.NavBarGroup();
            this.comercial_listaprecio = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_eliminararqueo = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_eliminardocumento = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_cambioclave = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_FE = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_OS = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_ImportarCliente = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_arqueoOS = new DevExpress.XtraNavBar.NavBarItem();
            this.comercial_OSPlanta = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupContabilidad = new DevExpress.XtraNavBar.NavBarGroup();
            this.contabilidad_importarasiento = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupReportes = new DevExpress.XtraNavBar.NavBarGroup();
            this.reportes_cdn = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.reportes_dw_ventas = new DevExpress.XtraNavBar.NavBarItem();
            this.reportes_dw_articulos = new DevExpress.XtraNavBar.NavBarItem();
            this.reportes_dw_clientes = new DevExpress.XtraNavBar.NavBarItem();
            this.reportes_dw_ventas_cuota = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupSistema = new DevExpress.XtraNavBar.NavBarGroup();
            this.sistema_ejecucion_sql = new DevExpress.XtraNavBar.NavBarItem();
            this.sistema_backup = new DevExpress.XtraNavBar.NavBarItem();
            this.sistema_servicio = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupAndroid = new DevExpress.XtraNavBar.NavBarGroup();
            this.android_consulta = new DevExpress.XtraNavBar.NavBarItem();
            this.android_usuarios = new DevExpress.XtraNavBar.NavBarItem();
            this.android_estado_cuenta = new DevExpress.XtraNavBar.NavBarItem();
            this.android_importar_pedido = new DevExpress.XtraNavBar.NavBarItem();
            this.android_importar_articulos = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupProcesos = new DevExpress.XtraNavBar.NavBarGroup();
            this.administracion_cargartxtFac = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.creditos_letrasemitidas = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp1 = new DevExpress.XtraTab.XtraTabPage();
            this.dvwcxc = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.tp2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.comercial_GuiaE = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwcxc)).BeginInit();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupComercial;
            this.navBarControl1.Appearance.NavigationPaneHeader.BackColor = System.Drawing.Color.White;
            this.navBarControl1.Appearance.NavigationPaneHeader.Options.UseBackColor = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupComercial,
            this.navBarGroupContabilidad,
            this.navBarGroupReportes,
            this.navBarGroupSistema,
            this.navBarGroupAndroid,
            this.navBarGroupProcesos,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.reportes_cdn,
            this.sistema_ejecucion_sql,
            this.sistema_backup,
            this.android_consulta,
            this.android_usuarios,
            this.sistema_servicio,
            this.android_estado_cuenta,
            this.android_importar_pedido,
            this.android_importar_articulos,
            this.navBarSeparatorItem1,
            this.reportes_dw_ventas,
            this.reportes_dw_articulos,
            this.reportes_dw_clientes,
            this.reportes_dw_ventas_cuota,
            this.comercial_listaprecio,
            this.comercial_eliminararqueo,
            this.comercial_eliminardocumento,
            this.contabilidad_importarasiento,
            this.comercial_cambioclave,
            this.comercial_FE,
            this.administracion_cargartxtFac,
            this.comercial_OS,
            this.comercial_ImportarCliente,
            this.creditos_letrasemitidas,
            this.comercial_arqueoOS,
            this.comercial_OSPlanta,
            this.navBarSeparatorItem2,
            this.comercial_GuiaE});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 201;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(201, 694);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("VS2010");
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navBarGroupComercial
            // 
            this.navBarGroupComercial.Caption = "Comercial";
            this.navBarGroupComercial.Expanded = true;
            this.navBarGroupComercial.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupComercial.ImageOptions.LargeImage")));
            this.navBarGroupComercial.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupComercial.ImageOptions.SmallImage")));
            this.navBarGroupComercial.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_listaprecio),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_eliminararqueo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_eliminardocumento),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_cambioclave),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_FE),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_OS),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_ImportarCliente),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_arqueoOS),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_OSPlanta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_GuiaE)});
            this.navBarGroupComercial.Name = "navBarGroupComercial";
            // 
            // comercial_listaprecio
            // 
            this.comercial_listaprecio.Caption = "Lista de Precios";
            this.comercial_listaprecio.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_listaprecio.ImageOptions.SmallImage")));
            this.comercial_listaprecio.Name = "comercial_listaprecio";
            this.comercial_listaprecio.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_listaprecio_LinkClicked);
            // 
            // comercial_eliminararqueo
            // 
            this.comercial_eliminararqueo.Caption = "Eliminar Arqueo";
            this.comercial_eliminararqueo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_eliminararqueo.ImageOptions.SmallImage")));
            this.comercial_eliminararqueo.Name = "comercial_eliminararqueo";
            this.comercial_eliminararqueo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_eliminararqueo_LinkClicked);
            // 
            // comercial_eliminardocumento
            // 
            this.comercial_eliminardocumento.Caption = "Eliminar Documento";
            this.comercial_eliminardocumento.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_eliminardocumento.ImageOptions.SmallImage")));
            this.comercial_eliminardocumento.Name = "comercial_eliminardocumento";
            this.comercial_eliminardocumento.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_eliminardocumento_LinkClicked);
            // 
            // comercial_cambioclave
            // 
            this.comercial_cambioclave.Caption = "Cambio de Clave Venta";
            this.comercial_cambioclave.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_cambioclave.ImageOptions.SmallImage")));
            this.comercial_cambioclave.Name = "comercial_cambioclave";
            this.comercial_cambioclave.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_cambioclave_LinkClicked);
            // 
            // comercial_FE
            // 
            this.comercial_FE.Caption = "Facturacion Electronica";
            this.comercial_FE.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_FE.ImageOptions.SmallImage")));
            this.comercial_FE.Name = "comercial_FE";
            this.comercial_FE.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_FE_LinkClicked);
            // 
            // comercial_OS
            // 
            this.comercial_OS.Caption = "Ordenes Servicio";
            this.comercial_OS.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_OS.ImageOptions.SmallImage")));
            this.comercial_OS.Name = "comercial_OS";
            this.comercial_OS.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_OS_LinkClicked);
            // 
            // comercial_ImportarCliente
            // 
            this.comercial_ImportarCliente.Caption = "Importar Cliente";
            this.comercial_ImportarCliente.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_ImportarCliente.ImageOptions.SmallImage")));
            this.comercial_ImportarCliente.Name = "comercial_ImportarCliente";
            this.comercial_ImportarCliente.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_ImportarCliente_LinkClicked);
            // 
            // comercial_arqueoOS
            // 
            this.comercial_arqueoOS.Caption = "Arqueo OS";
            this.comercial_arqueoOS.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_arqueoOS.ImageOptions.SmallImage")));
            this.comercial_arqueoOS.Name = "comercial_arqueoOS";
            this.comercial_arqueoOS.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_arqueoOS_LinkClicked);
            // 
            // comercial_OSPlanta
            // 
            this.comercial_OSPlanta.Caption = "OS Planta";
            this.comercial_OSPlanta.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_OSPlanta.ImageOptions.SmallImage")));
            this.comercial_OSPlanta.Name = "comercial_OSPlanta";
            this.comercial_OSPlanta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_OSPlanta_LinkClicked);
            // 
            // navBarGroupContabilidad
            // 
            this.navBarGroupContabilidad.Caption = "Contabilidad";
            this.navBarGroupContabilidad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupContabilidad.ImageOptions.LargeImage")));
            this.navBarGroupContabilidad.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupContabilidad.ImageOptions.SmallImage")));
            this.navBarGroupContabilidad.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.contabilidad_importarasiento)});
            this.navBarGroupContabilidad.Name = "navBarGroupContabilidad";
            // 
            // contabilidad_importarasiento
            // 
            this.contabilidad_importarasiento.Caption = "Importar Asientos al ERP";
            this.contabilidad_importarasiento.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("contabilidad_importarasiento.ImageOptions.SmallImage")));
            this.contabilidad_importarasiento.Name = "contabilidad_importarasiento";
            this.contabilidad_importarasiento.Tag = "1";
            this.contabilidad_importarasiento.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.contabilidad_importarasiento_LinkClicked);
            // 
            // navBarGroupReportes
            // 
            this.navBarGroupReportes.Caption = "Reportes";
            this.navBarGroupReportes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupReportes.ImageOptions.LargeImage")));
            this.navBarGroupReportes.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupReportes.ImageOptions.SmallImage")));
            this.navBarGroupReportes.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_cdn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_ventas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_articulos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_clientes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_ventas_cuota)});
            this.navBarGroupReportes.Name = "navBarGroupReportes";
            // 
            // reportes_cdn
            // 
            this.reportes_cdn.Caption = "Control Diario de Negocio";
            this.reportes_cdn.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_cdn.ImageOptions.SmallImage")));
            this.reportes_cdn.Name = "reportes_cdn";
            this.reportes_cdn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            // 
            // reportes_dw_ventas
            // 
            this.reportes_dw_ventas.Caption = "Dashboard Ventas";
            this.reportes_dw_ventas.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_ventas.ImageOptions.SmallImage")));
            this.reportes_dw_ventas.Name = "reportes_dw_ventas";
            this.reportes_dw_ventas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.reportes_dw_ventas_LinkClicked);
            // 
            // reportes_dw_articulos
            // 
            this.reportes_dw_articulos.Caption = "Dashboard Articulos";
            this.reportes_dw_articulos.Enabled = false;
            this.reportes_dw_articulos.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_articulos.ImageOptions.SmallImage")));
            this.reportes_dw_articulos.Name = "reportes_dw_articulos";
            // 
            // reportes_dw_clientes
            // 
            this.reportes_dw_clientes.Caption = "Dashboard Clientes";
            this.reportes_dw_clientes.Enabled = false;
            this.reportes_dw_clientes.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_clientes.ImageOptions.SmallImage")));
            this.reportes_dw_clientes.Name = "reportes_dw_clientes";
            // 
            // reportes_dw_ventas_cuota
            // 
            this.reportes_dw_ventas_cuota.Caption = "Dashboard Ventas vs Cuota";
            this.reportes_dw_ventas_cuota.Enabled = false;
            this.reportes_dw_ventas_cuota.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_ventas_cuota.ImageOptions.SmallImage")));
            this.reportes_dw_ventas_cuota.Name = "reportes_dw_ventas_cuota";
            // 
            // navBarGroupSistema
            // 
            this.navBarGroupSistema.Caption = "SISTEMA";
            this.navBarGroupSistema.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupSistema.ImageOptions.LargeImage")));
            this.navBarGroupSistema.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupSistema.ImageOptions.SmallImage")));
            this.navBarGroupSistema.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.sistema_ejecucion_sql),
            new DevExpress.XtraNavBar.NavBarItemLink(this.sistema_backup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.sistema_servicio)});
            this.navBarGroupSistema.Name = "navBarGroupSistema";
            // 
            // sistema_ejecucion_sql
            // 
            this.sistema_ejecucion_sql.Caption = "Ejecuacion de *.SQL";
            this.sistema_ejecucion_sql.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("sistema_ejecucion_sql.ImageOptions.SmallImage")));
            this.sistema_ejecucion_sql.Name = "sistema_ejecucion_sql";
            this.sistema_ejecucion_sql.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // sistema_backup
            // 
            this.sistema_backup.Caption = "Crear Backup de Base de Datos";
            this.sistema_backup.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("sistema_backup.ImageOptions.SmallImage")));
            this.sistema_backup.Name = "sistema_backup";
            this.sistema_backup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // sistema_servicio
            // 
            this.sistema_servicio.Caption = "Estatus Servicio";
            this.sistema_servicio.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("sistema_servicio.ImageOptions.SmallImage")));
            this.sistema_servicio.Name = "sistema_servicio";
            this.sistema_servicio.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.sistema_servicio_LinkClicked);
            // 
            // navBarGroupAndroid
            // 
            this.navBarGroupAndroid.Caption = "Android";
            this.navBarGroupAndroid.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupAndroid.ImageOptions.SmallImage")));
            this.navBarGroupAndroid.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_consulta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_usuarios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_estado_cuenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_importar_pedido),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_importar_articulos)});
            this.navBarGroupAndroid.Name = "navBarGroupAndroid";
            // 
            // android_consulta
            // 
            this.android_consulta.Caption = "Consultar Pedidos";
            this.android_consulta.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_consulta.ImageOptions.SmallImage")));
            this.android_consulta.Name = "android_consulta";
            this.android_consulta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // android_usuarios
            // 
            this.android_usuarios.Caption = "Administrar Usuarios";
            this.android_usuarios.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_usuarios.ImageOptions.SmallImage")));
            this.android_usuarios.Name = "android_usuarios";
            this.android_usuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.android_usuarios_LinkClicked);
            // 
            // android_estado_cuenta
            // 
            this.android_estado_cuenta.Caption = "Estado de Cuenta Cliente";
            this.android_estado_cuenta.Enabled = false;
            this.android_estado_cuenta.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_estado_cuenta.ImageOptions.SmallImage")));
            this.android_estado_cuenta.Name = "android_estado_cuenta";
            // 
            // android_importar_pedido
            // 
            this.android_importar_pedido.Caption = "Importar Pedidos al ERP";
            this.android_importar_pedido.Enabled = false;
            this.android_importar_pedido.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_importar_pedido.ImageOptions.SmallImage")));
            this.android_importar_pedido.Name = "android_importar_pedido";
            // 
            // android_importar_articulos
            // 
            this.android_importar_articulos.Caption = "Importar Articulos";
            this.android_importar_articulos.Enabled = false;
            this.android_importar_articulos.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_importar_articulos.ImageOptions.SmallImage")));
            this.android_importar_articulos.Name = "android_importar_articulos";
            // 
            // navBarGroupProcesos
            // 
            this.navBarGroupProcesos.Caption = "Administracion";
            this.navBarGroupProcesos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupProcesos.ImageOptions.LargeImage")));
            this.navBarGroupProcesos.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupProcesos.ImageOptions.SmallImage")));
            this.navBarGroupProcesos.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.administracion_cargartxtFac)});
            this.navBarGroupProcesos.Name = "navBarGroupProcesos";
            // 
            // administracion_cargartxtFac
            // 
            this.administracion_cargartxtFac.Caption = "Cargar Txt Facturas";
            this.administracion_cargartxtFac.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("administracion_cargartxtFac.ImageOptions.SmallImage")));
            this.administracion_cargartxtFac.Name = "administracion_cargartxtFac";
            this.administracion_cargartxtFac.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.administracion_cargartxtFac_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Creditos";
            this.navBarGroup1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.SmallImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.creditos_letrasemitidas)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // creditos_letrasemitidas
            // 
            this.creditos_letrasemitidas.Caption = "Letras Emitidas";
            this.creditos_letrasemitidas.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("creditos_letrasemitidas.ImageOptions.SmallImage")));
            this.creditos_letrasemitidas.Name = "creditos_letrasemitidas";
            this.creditos_letrasemitidas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.creditos_letrasemitidas_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Control Diario de Negocio";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Ninguno";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(843, 636);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias", System.UriKind.Absolute);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp1;
            this.xtraTabControl1.Size = new System.Drawing.Size(854, 690);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp1,
            this.tp2});
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.dvwcxc);
            this.tp1.Name = "tp1";
            this.tp1.PageVisible = false;
            this.tp1.Size = new System.Drawing.Size(849, 664);
            this.tp1.Text = "Documentos x Cobrar";
            // 
            // dvwcxc
            // 
            this.dvwcxc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvwcxc.Location = new System.Drawing.Point(0, 0);
            this.dvwcxc.Name = "dvwcxc";
            this.dvwcxc.Size = new System.Drawing.Size(849, 664);
            this.dvwcxc.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.btnguardar);
            this.tp2.Controls.Add(this.webBrowser1);
            this.tp2.Name = "tp2";
            this.tp2.Size = new System.Drawing.Size(849, 664);
            this.tp2.Text = "Consulta Sunat";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(770, 634);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(201, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(858, 694);
            this.panelControl1.TabIndex = 5;
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            // 
            // comercial_GuiaE
            // 
            this.comercial_GuiaE.Caption = "Guia Electronica";
            this.comercial_GuiaE.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.comercial_GuiaE.Name = "comercial_GuiaE";
            this.comercial_GuiaE.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_GuiaE_LinkClicked);
            // 
            // FRM_MENU_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 694);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarControl1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(857, 590);
            this.Name = "FRM_MENU_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion del Sistema - Base de Datos Actual(bdNava01)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_MENU_MAIN_FormClosed);
            this.Load += new System.EventHandler(this.FRM_MENU_MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvwcxc)).EndInit();
            this.tp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupReportes;
        private DevExpress.XtraNavBar.NavBarItem reportes_cdn;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupProcesos;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupSistema;
        private DevExpress.XtraNavBar.NavBarItem sistema_ejecucion_sql;
        private DevExpress.XtraNavBar.NavBarItem sistema_backup;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupAndroid;
        private DevExpress.XtraNavBar.NavBarItem android_consulta;
        private DevExpress.XtraNavBar.NavBarItem android_usuarios;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraNavBar.NavBarItem sistema_servicio;
        private DevExpress.XtraNavBar.NavBarItem android_estado_cuenta;
        private DevExpress.XtraNavBar.NavBarItem android_importar_pedido;
        private DevExpress.XtraNavBar.NavBarItem android_importar_articulos;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem reportes_dw_ventas;
        private DevExpress.XtraNavBar.NavBarItem reportes_dw_articulos;
        private DevExpress.XtraNavBar.NavBarItem reportes_dw_clientes;
        private DevExpress.XtraNavBar.NavBarItem reportes_dw_ventas_cuota;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupComercial;
        private DevExpress.XtraNavBar.NavBarItem comercial_listaprecio;
        private DevExpress.XtraNavBar.NavBarItem comercial_eliminararqueo;
        private DevExpress.XtraNavBar.NavBarItem comercial_eliminardocumento;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupContabilidad;
        private DevExpress.XtraNavBar.NavBarItem contabilidad_importarasiento;
        private DevExpress.XtraNavBar.NavBarItem comercial_cambioclave;
        private DevExpress.XtraNavBar.NavBarItem comercial_FE;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp1;
        private DevExpress.DashboardWin.DashboardViewer dvwcxc;
        private DevExpress.XtraTab.XtraTabPage tp2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarItem administracion_cargartxtFac;
        private DevExpress.XtraNavBar.NavBarItem comercial_OS;
        private DevExpress.XtraNavBar.NavBarItem comercial_ImportarCliente;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem creditos_letrasemitidas;
        private DevExpress.XtraNavBar.NavBarItem comercial_arqueoOS;
        private DevExpress.XtraNavBar.NavBarItem comercial_OSPlanta;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarItem comercial_GuiaE;
    }
}