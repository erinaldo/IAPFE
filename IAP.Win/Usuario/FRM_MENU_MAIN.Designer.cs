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
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp1 = new DevExpress.XtraTab.XtraTabPage();
            this.dvwcxc = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.tp2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
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
            this.navBarGroupProcesos});
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
            this.comercial_FE});
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
            this.navBarGroupComercial.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_listaprecio),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_eliminararqueo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_eliminardocumento),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_cambioclave),
            new DevExpress.XtraNavBar.NavBarItemLink(this.comercial_FE)});
            this.navBarGroupComercial.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupComercial.LargeImage")));
            this.navBarGroupComercial.Name = "navBarGroupComercial";
            this.navBarGroupComercial.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupComercial.SmallImage")));
            // 
            // comercial_listaprecio
            // 
            this.comercial_listaprecio.Caption = "Lista de Precios";
            this.comercial_listaprecio.Name = "comercial_listaprecio";
            this.comercial_listaprecio.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_listaprecio.SmallImage")));
            this.comercial_listaprecio.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_listaprecio_LinkClicked);
            // 
            // comercial_eliminararqueo
            // 
            this.comercial_eliminararqueo.Caption = "Eliminar Arqueo";
            this.comercial_eliminararqueo.Name = "comercial_eliminararqueo";
            this.comercial_eliminararqueo.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_eliminararqueo.SmallImage")));
            this.comercial_eliminararqueo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_eliminararqueo_LinkClicked);
            // 
            // comercial_eliminardocumento
            // 
            this.comercial_eliminardocumento.Caption = "Eliminar Documento";
            this.comercial_eliminardocumento.Name = "comercial_eliminardocumento";
            this.comercial_eliminardocumento.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_eliminardocumento.SmallImage")));
            this.comercial_eliminardocumento.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_eliminardocumento_LinkClicked);
            // 
            // comercial_cambioclave
            // 
            this.comercial_cambioclave.Caption = "Cambio de Clave Venta";
            this.comercial_cambioclave.Name = "comercial_cambioclave";
            this.comercial_cambioclave.SmallImage = ((System.Drawing.Image)(resources.GetObject("comercial_cambioclave.SmallImage")));
            this.comercial_cambioclave.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_cambioclave_LinkClicked);
            // 
            // comercial_FE
            // 
            this.comercial_FE.Caption = "Facturacion Electronica";
            this.comercial_FE.Name = "comercial_FE";
            this.comercial_FE.SmallImage = global::IAP.Win.Properties.Resources.Sunat;
            this.comercial_FE.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.comercial_FE_LinkClicked);
            // 
            // navBarGroupContabilidad
            // 
            this.navBarGroupContabilidad.Caption = "Contabilidad";
            this.navBarGroupContabilidad.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.contabilidad_importarasiento)});
            this.navBarGroupContabilidad.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupContabilidad.LargeImage")));
            this.navBarGroupContabilidad.Name = "navBarGroupContabilidad";
            this.navBarGroupContabilidad.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupContabilidad.SmallImage")));
            // 
            // contabilidad_importarasiento
            // 
            this.contabilidad_importarasiento.Caption = "Importar Asientos al ERP";
            this.contabilidad_importarasiento.Name = "contabilidad_importarasiento";
            this.contabilidad_importarasiento.SmallImage = ((System.Drawing.Image)(resources.GetObject("contabilidad_importarasiento.SmallImage")));
            this.contabilidad_importarasiento.Tag = "1";
            this.contabilidad_importarasiento.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.contabilidad_importarasiento_LinkClicked);
            // 
            // navBarGroupReportes
            // 
            this.navBarGroupReportes.Caption = "Reportes";
            this.navBarGroupReportes.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_cdn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_ventas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_articulos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_clientes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.reportes_dw_ventas_cuota)});
            this.navBarGroupReportes.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupReportes.LargeImage")));
            this.navBarGroupReportes.Name = "navBarGroupReportes";
            this.navBarGroupReportes.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupReportes.SmallImage")));
            // 
            // reportes_cdn
            // 
            this.reportes_cdn.Caption = "Control Diario de Negocio";
            this.reportes_cdn.Name = "reportes_cdn";
            this.reportes_cdn.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_cdn.SmallImage")));
            this.reportes_cdn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.LargeImageIndex = 0;
            this.navBarSeparatorItem1.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            this.navBarSeparatorItem1.SmallImageIndex = 0;
            this.navBarSeparatorItem1.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // reportes_dw_ventas
            // 
            this.reportes_dw_ventas.Caption = "Dashboard Ventas";
            this.reportes_dw_ventas.Enabled = false;
            this.reportes_dw_ventas.Name = "reportes_dw_ventas";
            this.reportes_dw_ventas.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_ventas.SmallImage")));
            // 
            // reportes_dw_articulos
            // 
            this.reportes_dw_articulos.Caption = "Dashboard Articulos";
            this.reportes_dw_articulos.Enabled = false;
            this.reportes_dw_articulos.Name = "reportes_dw_articulos";
            this.reportes_dw_articulos.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_articulos.SmallImage")));
            // 
            // reportes_dw_clientes
            // 
            this.reportes_dw_clientes.Caption = "Dashboard Clientes";
            this.reportes_dw_clientes.Enabled = false;
            this.reportes_dw_clientes.Name = "reportes_dw_clientes";
            this.reportes_dw_clientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_clientes.SmallImage")));
            // 
            // reportes_dw_ventas_cuota
            // 
            this.reportes_dw_ventas_cuota.Caption = "Dashboard Ventas vs Cuota";
            this.reportes_dw_ventas_cuota.Enabled = false;
            this.reportes_dw_ventas_cuota.Name = "reportes_dw_ventas_cuota";
            this.reportes_dw_ventas_cuota.SmallImage = ((System.Drawing.Image)(resources.GetObject("reportes_dw_ventas_cuota.SmallImage")));
            // 
            // navBarGroupSistema
            // 
            this.navBarGroupSistema.Caption = "SISTEMA";
            this.navBarGroupSistema.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.sistema_ejecucion_sql),
            new DevExpress.XtraNavBar.NavBarItemLink(this.sistema_backup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.sistema_servicio)});
            this.navBarGroupSistema.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupSistema.LargeImage")));
            this.navBarGroupSistema.Name = "navBarGroupSistema";
            this.navBarGroupSistema.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupSistema.SmallImage")));
            // 
            // sistema_ejecucion_sql
            // 
            this.sistema_ejecucion_sql.Caption = "Ejecuacion de *.SQL";
            this.sistema_ejecucion_sql.Name = "sistema_ejecucion_sql";
            this.sistema_ejecucion_sql.SmallImage = ((System.Drawing.Image)(resources.GetObject("sistema_ejecucion_sql.SmallImage")));
            this.sistema_ejecucion_sql.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // sistema_backup
            // 
            this.sistema_backup.Caption = "Crear Backup de Base de Datos";
            this.sistema_backup.Name = "sistema_backup";
            this.sistema_backup.SmallImage = ((System.Drawing.Image)(resources.GetObject("sistema_backup.SmallImage")));
            this.sistema_backup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // sistema_servicio
            // 
            this.sistema_servicio.Caption = "Estatus Servicio";
            this.sistema_servicio.Name = "sistema_servicio";
            this.sistema_servicio.SmallImage = ((System.Drawing.Image)(resources.GetObject("sistema_servicio.SmallImage")));
            this.sistema_servicio.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.sistema_servicio_LinkClicked);
            // 
            // navBarGroupAndroid
            // 
            this.navBarGroupAndroid.Caption = "Android";
            this.navBarGroupAndroid.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_consulta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_usuarios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_estado_cuenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_importar_pedido),
            new DevExpress.XtraNavBar.NavBarItemLink(this.android_importar_articulos)});
            this.navBarGroupAndroid.Name = "navBarGroupAndroid";
            this.navBarGroupAndroid.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupAndroid.SmallImage")));
            // 
            // android_consulta
            // 
            this.android_consulta.Caption = "Consultar Pedidos";
            this.android_consulta.Name = "android_consulta";
            this.android_consulta.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_consulta.SmallImage")));
            this.android_consulta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // android_usuarios
            // 
            this.android_usuarios.Caption = "Administrar Usuarios";
            this.android_usuarios.Name = "android_usuarios";
            this.android_usuarios.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_usuarios.SmallImage")));
            this.android_usuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.android_usuarios_LinkClicked);
            // 
            // android_estado_cuenta
            // 
            this.android_estado_cuenta.Caption = "Estado de Cuenta Cliente";
            this.android_estado_cuenta.Enabled = false;
            this.android_estado_cuenta.Name = "android_estado_cuenta";
            this.android_estado_cuenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_estado_cuenta.SmallImage")));
            // 
            // android_importar_pedido
            // 
            this.android_importar_pedido.Caption = "Importar Pedidos al ERP";
            this.android_importar_pedido.Enabled = false;
            this.android_importar_pedido.Name = "android_importar_pedido";
            this.android_importar_pedido.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_importar_pedido.SmallImage")));
            // 
            // android_importar_articulos
            // 
            this.android_importar_articulos.Caption = "Importar Articulos";
            this.android_importar_articulos.Enabled = false;
            this.android_importar_articulos.Name = "android_importar_articulos";
            this.android_importar_articulos.SmallImage = ((System.Drawing.Image)(resources.GetObject("android_importar_articulos.SmallImage")));
            // 
            // navBarGroupProcesos
            // 
            this.navBarGroupProcesos.Caption = "Administracion";
            this.navBarGroupProcesos.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupProcesos.LargeImage")));
            this.navBarGroupProcesos.Name = "navBarGroupProcesos";
            this.navBarGroupProcesos.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupProcesos.SmallImage")));
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
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(848, 662);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias", System.UriKind.Absolute);
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
            this.tp1.Size = new System.Drawing.Size(848, 662);
            this.tp1.Text = "Documentos x Cobrar";
            // 
            // dvwcxc
            // 
            this.dvwcxc.CustomDBSchemaProviderEx = null;
            this.dvwcxc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvwcxc.Location = new System.Drawing.Point(0, 0);
            this.dvwcxc.Name = "dvwcxc";
            this.dvwcxc.Size = new System.Drawing.Size(848, 662);
            this.dvwcxc.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.webBrowser1);
            this.tp2.Name = "tp2";
            this.tp2.Size = new System.Drawing.Size(848, 662);
            this.tp2.Text = "Sunat Tipo Cambio";
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
    }
}