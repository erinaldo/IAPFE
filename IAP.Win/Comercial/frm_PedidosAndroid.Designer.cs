namespace IAP.Win.Comercial
{
    partial class frm_PedidosAndroid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PedidosAndroid));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcdetalle = new DevExpress.XtraGrid.GridControl();
            this.gvwdetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gccabecera = new DevExpress.XtraGrid.GridControl();
            this.gvwcabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtcliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechafinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechainicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.leEstado = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leEstado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, -1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1141, 524);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp1});
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.labelControl5);
            this.tp1.Controls.Add(this.gcdetalle);
            this.tp1.Controls.Add(this.gccabecera);
            this.tp1.Controls.Add(this.panelControl1);
            this.tp1.Name = "tp1";
            this.tp1.Size = new System.Drawing.Size(1136, 498);
            this.tp1.Text = "Consultas";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(8, 268);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(127, 11);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "DETALLE DEL DOCUMENTO";
            // 
            // gcdetalle
            // 
            this.gcdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcdetalle.Location = new System.Drawing.Point(3, 286);
            this.gcdetalle.MainView = this.gvwdetalle;
            this.gcdetalle.Name = "gcdetalle";
            this.gcdetalle.Size = new System.Drawing.Size(1130, 208);
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
            this.gccabecera.Location = new System.Drawing.Point(3, 48);
            this.gccabecera.MainView = this.gvwcabecera;
            this.gccabecera.Name = "gccabecera";
            this.gccabecera.Size = new System.Drawing.Size(1130, 214);
            this.gccabecera.TabIndex = 7;
            this.gccabecera.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwcabecera});
            // 
            // gvwcabecera
            // 
            this.gvwcabecera.GridControl = this.gccabecera;
            this.gvwcabecera.Name = "gvwcabecera";
            this.gvwcabecera.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.leEstado);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.btnbuscar);
            this.panelControl1.Controls.Add(this.txtcliente);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dtfechafinal);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dtfechainicial);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1134, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(685, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Estado";
            // 
            // btnbuscar
            // 
            this.btnbuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.ImageOptions.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(907, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 34);
            this.btnbuscar.TabIndex = 8;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(400, 10);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(279, 20);
            this.txtcliente.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(354, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cliente";
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.EditValue = null;
            this.dtfechafinal.Location = new System.Drawing.Point(233, 7);
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
            this.labelControl2.Location = new System.Drawing.Point(188, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "F. Final";
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.EditValue = null;
            this.dtfechainicial.Location = new System.Drawing.Point(65, 7);
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
            this.labelControl1.Location = new System.Drawing.Point(4, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "F. Inicial";
            // 
            // leEstado
            // 
            this.leEstado.Location = new System.Drawing.Point(726, 11);
            this.leEstado.Name = "leEstado";
            this.leEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leEstado.Size = new System.Drawing.Size(162, 20);
            this.leEstado.TabIndex = 13;
            // 
            // frm_PedidosAndroid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 524);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frm_PedidosAndroid";
            this.Text = "frm_PedidosAndroid";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leEstado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gcdetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwdetalle;
        private DevExpress.XtraGrid.GridControl gccabecera;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwcabecera;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.TextEdit txtcliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtfechafinal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtfechainicial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit leEstado;
    }
}