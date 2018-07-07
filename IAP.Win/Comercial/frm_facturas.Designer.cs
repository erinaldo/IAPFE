namespace IAP.Win
{
    partial class frm_facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturas));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcdetalle = new DevExpress.XtraGrid.GridControl();
            this.gvwdetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gccabecera = new DevExpress.XtraGrid.GridControl();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnumarcartodo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulimpiartodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuenviardocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuanulardocumento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuverpdf = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuverpdfanulado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuconsultardoc = new System.Windows.Forms.ToolStripMenuItem();
            this.gvwcabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkanulados = new DevExpress.XtraEditors.CheckEdit();
            this.rbtnenviado = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbotipodocumento = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtdocumento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtcliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechafinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechainicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.mnuverjson = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkanulados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnenviado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbotipodocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1201, 655);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp1});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.labelControl5);
            this.tp1.Controls.Add(this.gcdetalle);
            this.tp1.Controls.Add(this.gccabecera);
            this.tp1.Controls.Add(this.panelControl1);
            this.tp1.Name = "tp1";
            this.tp1.Size = new System.Drawing.Size(1195, 627);
            this.tp1.Text = "Consultas";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(8, 372);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(127, 11);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "DETALLE DEL DOCUMENTO";
            // 
            // gcdetalle
            // 
            this.gcdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcdetalle.Location = new System.Drawing.Point(3, 391);
            this.gcdetalle.MainView = this.gvwdetalle;
            this.gcdetalle.Name = "gcdetalle";
            this.gcdetalle.Size = new System.Drawing.Size(1189, 233);
            this.gcdetalle.TabIndex = 11;
            this.gcdetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwdetalle});
            // 
            // gvwdetalle
            // 
            this.gvwdetalle.GridControl = this.gcdetalle;
            this.gvwdetalle.Name = "gvwdetalle";
            this.gvwdetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gccabecera
            // 
            this.gccabecera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gccabecera.ContextMenuStrip = this.menu;
            this.gccabecera.Location = new System.Drawing.Point(3, 70);
            this.gccabecera.MainView = this.gvwcabecera;
            this.gccabecera.Name = "gccabecera";
            this.gccabecera.Size = new System.Drawing.Size(1189, 296);
            this.gccabecera.TabIndex = 7;
            this.gccabecera.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwcabecera});
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnumarcartodo,
            this.mnulimpiartodo,
            this.toolStripSeparator1,
            this.mnuenviardocumentos,
            this.mnuanulardocumento,
            this.mnuverpdf,
            this.mnuverpdfanulado,
            this.toolStripSeparator2,
            this.mnuconsultardoc,
            this.mnuverjson});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(205, 192);
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // mnumarcartodo
            // 
            this.mnumarcartodo.Image = global::IAP.Win.Properties.Resources.check;
            this.mnumarcartodo.Name = "mnumarcartodo";
            this.mnumarcartodo.Size = new System.Drawing.Size(204, 22);
            this.mnumarcartodo.Text = "Marcar Todo";
            // 
            // mnulimpiartodo
            // 
            this.mnulimpiartodo.Image = global::IAP.Win.Properties.Resources.ClearFilter_32x32;
            this.mnulimpiartodo.Name = "mnulimpiartodo";
            this.mnulimpiartodo.Size = new System.Drawing.Size(204, 22);
            this.mnulimpiartodo.Text = "Limpiar Todo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuenviardocumentos
            // 
            this.mnuenviardocumentos.Image = global::IAP.Win.Properties.Resources.Sunat;
            this.mnuenviardocumentos.Name = "mnuenviardocumentos";
            this.mnuenviardocumentos.Size = new System.Drawing.Size(204, 22);
            this.mnuenviardocumentos.Text = "Enviar a Sunat";
            // 
            // mnuanulardocumento
            // 
            this.mnuanulardocumento.Image = global::IAP.Win.Properties.Resources.Interrogación;
            this.mnuanulardocumento.Name = "mnuanulardocumento";
            this.mnuanulardocumento.Size = new System.Drawing.Size(204, 22);
            this.mnuanulardocumento.Text = "Anular Documento";
            // 
            // mnuverpdf
            // 
            this.mnuverpdf.Image = global::IAP.Win.Properties.Resources.pdf_16x16;
            this.mnuverpdf.Name = "mnuverpdf";
            this.mnuverpdf.Size = new System.Drawing.Size(204, 22);
            this.mnuverpdf.Text = "Ver Documento";
            // 
            // mnuverpdfanulado
            // 
            this.mnuverpdfanulado.Image = global::IAP.Win.Properties.Resources.Warning_32x32;
            this.mnuverpdfanulado.Name = "mnuverpdfanulado";
            this.mnuverpdfanulado.Size = new System.Drawing.Size(204, 22);
            this.mnuverpdfanulado.Text = "Ver Documento Anulado";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuconsultardoc
            // 
            this.mnuconsultardoc.Image = global::IAP.Win.Properties.Resources.Preview_32x32;
            this.mnuconsultardoc.Name = "mnuconsultardoc";
            this.mnuconsultardoc.Size = new System.Drawing.Size(204, 22);
            this.mnuconsultardoc.Text = "Consultar Documento";
            // 
            // gvwcabecera
            // 
            this.gvwcabecera.GridControl = this.gccabecera;
            this.gvwcabecera.Name = "gvwcabecera";
            this.gvwcabecera.OptionsView.ShowGroupPanel = false;
            this.gvwcabecera.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvwcabecera_RowCellClick);
            this.gvwcabecera.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvwcabecera_RowCellStyle);
            this.gvwcabecera.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gvwcabecera_FocusedRowObjectChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.chkanulados);
            this.panelControl1.Controls.Add(this.rbtnenviado);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cbotipodocumento);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.btnbuscar);
            this.panelControl1.Controls.Add(this.txtdocumento);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtcliente);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dtfechafinal);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dtfechainicial);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1193, 65);
            this.panelControl1.TabIndex = 0;
            // 
            // chkanulados
            // 
            this.chkanulados.Location = new System.Drawing.Point(590, 41);
            this.chkanulados.Name = "chkanulados";
            this.chkanulados.Properties.Caption = "Anulados";
            this.chkanulados.Size = new System.Drawing.Size(67, 19);
            this.chkanulados.TabIndex = 14;
            // 
            // rbtnenviado
            // 
            this.rbtnenviado.Location = new System.Drawing.Point(590, 10);
            this.rbtnenviado.Name = "rbtnenviado";
            this.rbtnenviado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Si"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "No"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Todos")});
            this.rbtnenviado.Size = new System.Drawing.Size(202, 22);
            this.rbtnenviado.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(548, 14);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Enviado";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.Location = new System.Drawing.Point(65, 11);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbotipodocumento.Size = new System.Drawing.Size(109, 20);
            this.cbotipodocumento.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 8);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 26);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Tipo \r\nDocumento";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(833, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 34);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(447, 37);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(72, 20);
            this.txtdocumento.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(387, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Documento";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(240, 11);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(279, 20);
            this.txtcliente.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(201, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cliente";
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.EditValue = null;
            this.dtfechafinal.Location = new System.Drawing.Point(240, 37);
            this.dtfechafinal.Name = "dtfechafinal";
            this.dtfechafinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechafinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechafinal.Size = new System.Drawing.Size(108, 20);
            this.dtfechafinal.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(199, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "F. Final";
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.EditValue = null;
            this.dtfechainicial.Location = new System.Drawing.Point(65, 37);
            this.dtfechainicial.Name = "dtfechainicial";
            this.dtfechainicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechainicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechainicial.Size = new System.Drawing.Size(108, 20);
            this.dtfechainicial.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "F. Inicial";
            // 
            // mnuverjson
            // 
            this.mnuverjson.Image = global::IAP.Win.Properties.Resources.Edit_32x32;
            this.mnuverjson.Name = "mnuverjson";
            this.mnuverjson.Size = new System.Drawing.Size(204, 22);
            this.mnuverjson.Text = "Ver Archivo Json";
            // 
            // frm_facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 655);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frm_facturas";
            this.Text = ".:: Modulo de Facturacion Electronica ::.";
            this.Load += new System.EventHandler(this.frm_facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkanulados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnenviado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbotipodocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.TextEdit txtdocumento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtcliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtfechafinal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtfechainicial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbotipodocumento;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuenviardocumentos;
        private System.Windows.Forms.ToolStripMenuItem mnumarcartodo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnulimpiartodo;
        private System.Windows.Forms.ToolStripMenuItem mnuverpdf;
        private System.Windows.Forms.ToolStripMenuItem mnuanulardocumento;
        private System.Windows.Forms.ToolStripMenuItem mnuverpdfanulado;
        private DevExpress.XtraEditors.RadioGroup rbtnenviado;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit chkanulados;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gcdetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwdetalle;
        private DevExpress.XtraGrid.GridControl gccabecera;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwcabecera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuconsultardoc;
        private System.Windows.Forms.ToolStripMenuItem mnuverjson;
    }
}