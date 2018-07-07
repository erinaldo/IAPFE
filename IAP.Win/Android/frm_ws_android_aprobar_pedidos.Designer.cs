namespace IAP.Win
{
    partial class frm_ws_android_aprobar_pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ws_android_aprobar_pedidos));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ruc = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_fechaf = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_fechai = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gcpedido_det = new DevExpress.XtraGrid.GridControl();
            this.gvw_pedido_det = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcpedido_cab = new DevExpress.XtraGrid.GridControl();
            this.gvw_pedido_cab = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_lista = new DevExpress.XtraGrid.GridControl();
            this.gvw_lista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_grabar_lista = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cargar_excel = new DevExpress.XtraEditors.SimpleButton();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfamilia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cargar_lista = new DevExpress.XtraEditors.SimpleButton();
            this.btnobtener_lista = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcpedido_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_pedido_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpedido_cab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_pedido_cab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_buscar);
            this.groupControl1.Controls.Add(this.txt_cliente);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_ruc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dtp_fechaf);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dtp_fechai);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1015, 77);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Pedidos Registrados en el Servidor";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(871, 27);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(42, 41);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.SystemColors.Info;
            this.txt_cliente.Location = new System.Drawing.Point(314, 52);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(295, 20);
            this.txt_cliente.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(228, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Nombre Cliente :";
            // 
            // txt_ruc
            // 
            this.txt_ruc.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ruc.Location = new System.Drawing.Point(95, 52);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Size = new System.Drawing.Size(100, 20);
            this.txt_ruc.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "R.U.C.:";
            // 
            // dtp_fechaf
            // 
            this.dtp_fechaf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaf.Location = new System.Drawing.Point(314, 27);
            this.dtp_fechaf.Name = "dtp_fechaf";
            this.dtp_fechaf.Size = new System.Drawing.Size(99, 20);
            this.dtp_fechaf.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(250, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha Final:";
            // 
            // dtp_fechai
            // 
            this.dtp_fechai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechai.Location = new System.Drawing.Point(96, 26);
            this.dtp_fechai.Name = "dtp_fechai";
            this.dtp_fechai.Size = new System.Drawing.Size(99, 20);
            this.dtp_fechai.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha Inicial:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcpedido_det);
            this.splitContainer1.Panel2.Controls.Add(this.gcpedido_cab);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 543);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 1;
            // 
            // gcpedido_det
            // 
            this.gcpedido_det.Location = new System.Drawing.Point(3, 234);
            this.gcpedido_det.MainView = this.gvw_pedido_det;
            this.gcpedido_det.Name = "gcpedido_det";
            this.gcpedido_det.Size = new System.Drawing.Size(1015, 217);
            this.gcpedido_det.TabIndex = 1;
            this.gcpedido_det.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvw_pedido_det});
            // 
            // gvw_pedido_det
            // 
            this.gvw_pedido_det.GridControl = this.gcpedido_det;
            this.gvw_pedido_det.Name = "gvw_pedido_det";
            this.gvw_pedido_det.OptionsView.ShowGroupPanel = false;
            // 
            // gcpedido_cab
            // 
            this.gcpedido_cab.Location = new System.Drawing.Point(3, 3);
            this.gcpedido_cab.MainView = this.gvw_pedido_cab;
            this.gcpedido_cab.Name = "gcpedido_cab";
            this.gcpedido_cab.Size = new System.Drawing.Size(1015, 229);
            this.gcpedido_cab.TabIndex = 0;
            this.gcpedido_cab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvw_pedido_cab});
            // 
            // gvw_pedido_cab
            // 
            this.gvw_pedido_cab.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue;
            this.gvw_pedido_cab.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvw_pedido_cab.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvw_pedido_cab.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvw_pedido_cab.GridControl = this.gcpedido_cab;
            this.gvw_pedido_cab.Name = "gvw_pedido_cab";
            this.gvw_pedido_cab.OptionsView.ShowGroupPanel = false;
            this.gvw_pedido_cab.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvw_pedido_cab_CustomDrawCell);
            this.gvw_pedido_cab.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvw_pedido_cab_RowStyle);
            this.gvw_pedido_cab.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvw_pedido_cab_FocusedRowChanged);
            this.gvw_pedido_cab.DoubleClick += new System.EventHandler(this.gvw_pedido_cab_DoubleClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1027, 590);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainer1);
            this.xtraTabPage1.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1021, 543);
            this.xtraTabPage1.Text = "Pedidos";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gc_lista);
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1021, 543);
            this.xtraTabPage2.Text = "Lista de Precios";
            // 
            // gc_lista
            // 
            this.gc_lista.Location = new System.Drawing.Point(3, 74);
            this.gc_lista.MainView = this.gvw_lista;
            this.gc_lista.Name = "gc_lista";
            this.gc_lista.Size = new System.Drawing.Size(1015, 466);
            this.gc_lista.TabIndex = 1;
            this.gc_lista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvw_lista});
            // 
            // gvw_lista
            // 
            this.gvw_lista.GridControl = this.gc_lista;
            this.gvw_lista.Name = "gvw_lista";
            this.gvw_lista.OptionsView.ShowGroupPanel = false;
            this.gvw_lista.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvw_lista_CustomRowCellEdit);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_grabar_lista);
            this.groupControl2.Controls.Add(this.btn_cargar_excel);
            this.groupControl2.Controls.Add(this.txtarticulo);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtfamilia);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.btn_cargar_lista);
            this.groupControl2.Controls.Add(this.btnobtener_lista);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1015, 67);
            this.groupControl2.TabIndex = 0;
            // 
            // btn_grabar_lista
            // 
            this.btn_grabar_lista.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabar_lista.Image")));
            this.btn_grabar_lista.Location = new System.Drawing.Point(660, 24);
            this.btn_grabar_lista.Name = "btn_grabar_lista";
            this.btn_grabar_lista.Size = new System.Drawing.Size(105, 35);
            this.btn_grabar_lista.TabIndex = 7;
            this.btn_grabar_lista.Text = "Grabar Data";
            this.btn_grabar_lista.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_cargar_excel
            // 
            this.btn_cargar_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cargar_excel.Image")));
            this.btn_cargar_excel.Location = new System.Drawing.Point(611, 24);
            this.btn_cargar_excel.Name = "btn_cargar_excel";
            this.btn_cargar_excel.Size = new System.Drawing.Size(43, 35);
            this.btn_cargar_excel.TabIndex = 6;
            this.btn_cargar_excel.ToolTip = "El nombre de la hoja debe ser \"lista\"";
            this.btn_cargar_excel.Click += new System.EventHandler(this.btn_cargar_excel_Click);
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(61, 28);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(218, 20);
            this.txtarticulo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Articulo :";
            // 
            // txtfamilia
            // 
            this.txtfamilia.Location = new System.Drawing.Point(333, 28);
            this.txtfamilia.Name = "txtfamilia";
            this.txtfamilia.Size = new System.Drawing.Size(217, 20);
            this.txtfamilia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Familia:";
            // 
            // btn_cargar_lista
            // 
            this.btn_cargar_lista.Image = ((System.Drawing.Image)(resources.GetObject("btn_cargar_lista.Image")));
            this.btn_cargar_lista.Location = new System.Drawing.Point(890, 24);
            this.btn_cargar_lista.Name = "btn_cargar_lista";
            this.btn_cargar_lista.Size = new System.Drawing.Size(117, 35);
            this.btn_cargar_lista.TabIndex = 1;
            this.btn_cargar_lista.Text = "Actualizar Lista";
            this.btn_cargar_lista.Click += new System.EventHandler(this.btn_cargar_lista_Click);
            // 
            // btnobtener_lista
            // 
            this.btnobtener_lista.Image = ((System.Drawing.Image)(resources.GetObject("btnobtener_lista.Image")));
            this.btnobtener_lista.Location = new System.Drawing.Point(771, 24);
            this.btnobtener_lista.Name = "btnobtener_lista";
            this.btnobtener_lista.Size = new System.Drawing.Size(113, 35);
            this.btnobtener_lista.TabIndex = 0;
            this.btnobtener_lista.Text = "Obtener Lista";
            this.btnobtener_lista.Click += new System.EventHandler(this.btnobtener_lista_Click);
            // 
            // frm_ws_android_aprobar_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 589);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frm_ws_android_aprobar_pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ws_android_aprobar_pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcpedido_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_pedido_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpedido_cab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_pedido_cab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_buscar;
        private System.Windows.Forms.TextBox txt_cliente;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txt_ruc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtp_fechaf;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtp_fechai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcpedido_det;
        private DevExpress.XtraGrid.Views.Grid.GridView gvw_pedido_det;
        private DevExpress.XtraGrid.GridControl gcpedido_cab;
        private DevExpress.XtraGrid.Views.Grid.GridView gvw_pedido_cab;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gc_lista;
        private DevExpress.XtraGrid.Views.Grid.GridView gvw_lista;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_cargar_lista;
        private DevExpress.XtraEditors.SimpleButton btnobtener_lista;
        private System.Windows.Forms.TextBox txtfamilia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_cargar_excel;
        private DevExpress.XtraEditors.SimpleButton btn_grabar_lista;
    }
}