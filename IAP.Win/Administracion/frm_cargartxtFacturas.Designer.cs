namespace IAP.Win.Administracion
{
    partial class frm_cargartxtFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cargartxtFacturas));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btncargar = new DevExpress.XtraEditors.SimpleButton();
            this.btnabrir = new DevExpress.XtraEditors.SimpleButton();
            this.txtcabecera = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gctxt = new DevExpress.XtraGrid.GridControl();
            this.gvwtxt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtdetalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnabrirdet = new DevExpress.XtraEditors.SimpleButton();
            this.ofdcab = new System.Windows.Forms.OpenFileDialog();
            this.ofddet = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcabecera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwtxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdetalle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnabrirdet);
            this.panelControl1.Controls.Add(this.txtdetalle);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btncargar);
            this.panelControl1.Controls.Add(this.btnabrir);
            this.panelControl1.Controls.Add(this.txtcabecera);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(6, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(847, 88);
            this.panelControl1.TabIndex = 0;
            // 
            // btncargar
            // 
            this.btncargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.ImageOptions.Image")));
            this.btncargar.Location = new System.Drawing.Point(549, 7);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(28, 23);
            this.btncargar.TabIndex = 3;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnabrir
            // 
            this.btnabrir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnabrir.ImageOptions.Image")));
            this.btnabrir.Location = new System.Drawing.Point(515, 7);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(28, 23);
            this.btnabrir.TabIndex = 2;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // txtcabecera
            // 
            this.txtcabecera.Location = new System.Drawing.Point(65, 10);
            this.txtcabecera.Name = "txtcabecera";
            this.txtcabecera.Size = new System.Drawing.Size(435, 20);
            this.txtcabecera.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cabecera";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.gctxt);
            this.panelControl2.Location = new System.Drawing.Point(6, 117);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(847, 302);
            this.panelControl2.TabIndex = 0;
            // 
            // gctxt
            // 
            this.gctxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gctxt.Location = new System.Drawing.Point(5, 5);
            this.gctxt.MainView = this.gvwtxt;
            this.gctxt.Name = "gctxt";
            this.gctxt.Size = new System.Drawing.Size(837, 292);
            this.gctxt.TabIndex = 0;
            this.gctxt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwtxt});
            // 
            // gvwtxt
            // 
            this.gvwtxt.GridControl = this.gctxt;
            this.gvwtxt.Name = "gvwtxt";
            this.gvwtxt.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(859, 433);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Carga de Facturas  desde TXT";
            // 
            // txtdetalle
            // 
            this.txtdetalle.Location = new System.Drawing.Point(65, 36);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(435, 20);
            this.txtdetalle.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Detalle";
            // 
            // btnabrirdet
            // 
            this.btnabrirdet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnabrirdet.Location = new System.Drawing.Point(515, 33);
            this.btnabrirdet.Name = "btnabrirdet";
            this.btnabrirdet.Size = new System.Drawing.Size(28, 23);
            this.btnabrirdet.TabIndex = 6;
            this.btnabrirdet.Click += new System.EventHandler(this.btnabrirdet_Click);
            // 
            // ofdcab
            // 
            this.ofdcab.FileName = "openFileDialog1";
            // 
            // ofddet
            // 
            this.ofddet.FileName = "openFileDialog1";
            // 
            // frm_cargartxtFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 433);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_cargartxtFacturas";
            this.Text = "Cargar Facturas desde TXT";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcabecera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwtxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdetalle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btncargar;
        private DevExpress.XtraEditors.SimpleButton btnabrir;
        private DevExpress.XtraEditors.TextEdit txtcabecera;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gctxt;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwtxt;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnabrirdet;
        private DevExpress.XtraEditors.TextEdit txtdetalle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.OpenFileDialog ofdcab;
        private System.Windows.Forms.OpenFileDialog ofddet;
    }
}