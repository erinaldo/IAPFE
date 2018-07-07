namespace IAP.Win.Comercial
{
    partial class frm_PasswordVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PasswordVentas));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnnuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtclave = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtfecha = new DevExpress.XtraEditors.TextEdit();
            this.gcpassword = new DevExpress.XtraGrid.GridControl();
            this.gvwpassword = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtclave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnnuevo);
            this.panelControl1.Controls.Add(this.btnguardar);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtclave);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtfecha);
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(434, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnnuevo.Location = new System.Drawing.Point(365, 5);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(30, 24);
            this.btnnuevo.TabIndex = 12;
            this.btnnuevo.ToolTip = "Guardar";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnguardar.Location = new System.Drawing.Point(399, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(30, 24);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.ToolTip = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(175, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Clave";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(208, 7);
            this.txtclave.Name = "txtclave";
            this.txtclave.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtclave.Properties.Appearance.Options.UseBackColor = true;
            this.txtclave.Size = new System.Drawing.Size(151, 20);
            this.txtclave.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fecha";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(54, 7);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtfecha.Properties.Appearance.Options.UseBackColor = true;
            this.txtfecha.Properties.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 0;
            // 
            // gcpassword
            // 
            this.gcpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcpassword.Location = new System.Drawing.Point(2, 52);
            this.gcpassword.MainView = this.gvwpassword;
            this.gcpassword.Name = "gcpassword";
            this.gcpassword.Size = new System.Drawing.Size(434, 225);
            this.gcpassword.TabIndex = 1;
            this.gcpassword.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwpassword});
            // 
            // gvwpassword
            // 
            this.gvwpassword.GridControl = this.gcpassword;
            this.gvwpassword.Name = "gvwpassword";
            this.gvwpassword.OptionsView.ShowGroupPanel = false;
            // 
            // frm_PasswordVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 285);
            this.Controls.Add(this.gcpassword);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_PasswordVentas";
            this.Text = "Cambio de Clave Ventas";
            this.Activated += new System.EventHandler(this.frm_PasswordVentas_Activated);
            this.Load += new System.EventHandler(this.frm_PasswordVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtclave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwpassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtclave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtfecha;
        private DevExpress.XtraEditors.SimpleButton btnnuevo;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraGrid.GridControl gcpassword;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwpassword;
    }
}