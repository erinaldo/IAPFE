namespace IAP.Win.Mensajeria
{
    partial class frm_EnvioEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EnvioEmail));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtcc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtasunto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnenviar = new DevExpress.XtraEditors.SimpleButton();
            this.lblTo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmensaje = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtasunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmensaje.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtcc);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtasunto);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtto);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnenviar);
            this.panelControl1.Controls.Add(this.lblTo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(450, 107);
            this.panelControl1.TabIndex = 0;
            // 
            // txtcc
            // 
            this.txtcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcc.Location = new System.Drawing.Point(154, 51);
            this.txtcc.Name = "txtcc";
            this.txtcc.Properties.Mask.EditMask = "[a-zA-Z0-9.-]+@[a-zA-Z0-9-]+\\.[A-Za-z]{2,6}";
            this.txtcc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtcc.Size = new System.Drawing.Size(263, 20);
            this.txtcc.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(99, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "CC :";
            // 
            // txtasunto
            // 
            this.txtasunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtasunto.Location = new System.Drawing.Point(154, 75);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(263, 20);
            this.txtasunto.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(99, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Asunto :";
            // 
            // txtto
            // 
            this.txtto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtto.Location = new System.Drawing.Point(154, 26);
            this.txtto.Name = "txtto";
            this.txtto.Properties.Mask.EditMask = "[a-zA-Z0-9.-]+@[a-zA-Z0-9-]+\\.[A-Za-z]{2,6}";
            this.txtto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtto.Size = new System.Drawing.Size(263, 20);
            this.txtto.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(99, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "To:";
            // 
            // btnenviar
            // 
            this.btnenviar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnenviar.ImageOptions.Image")));
            this.btnenviar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnenviar.Location = new System.Drawing.Point(21, 34);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(56, 57);
            this.btnenviar.TabIndex = 2;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // lblTo
            // 
            this.lblTo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lblTo.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTo.Appearance.Options.UseFont = true;
            this.lblTo.Appearance.Options.UseForeColor = true;
            this.lblTo.Location = new System.Drawing.Point(39, 6);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(100, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "slipnotxx@gmail.com";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "De :";
            // 
            // txtmensaje
            // 
            this.txtmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmensaje.Location = new System.Drawing.Point(2, 112);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(450, 118);
            this.txtmensaje.TabIndex = 1;
            // 
            // frm_EnvioEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 233);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_EnvioEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Envio de Emails";
            this.Load += new System.EventHandler(this.frm_EnvioEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtasunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmensaje.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtasunto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnenviar;
        private DevExpress.XtraEditors.LabelControl lblTo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtmensaje;
        private DevExpress.XtraEditors.TextEdit txtcc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}