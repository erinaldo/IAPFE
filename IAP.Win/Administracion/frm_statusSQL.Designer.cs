namespace IAP.Win
{
    partial class frm_statusSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_statusSQL));
            this.txtestado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btniniciar = new DevExpress.XtraEditors.SimpleButton();
            this.btndetener = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtestado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(117, 45);
            this.txtestado.Name = "txtestado";
            this.txtestado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtestado.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtestado.Properties.Appearance.Options.UseFont = true;
            this.txtestado.Properties.Appearance.Options.UseForeColor = true;
            this.txtestado.Size = new System.Drawing.Size(266, 20);
            this.txtestado.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Estado del Servicio";
            // 
            // btniniciar
            // 
            this.btniniciar.Image = ((System.Drawing.Image)(resources.GetObject("btniniciar.Image")));
            this.btniniciar.Location = new System.Drawing.Point(403, 38);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(45, 35);
            this.btniniciar.TabIndex = 2;
            this.btniniciar.ToolTip = "Iniciar Servicio BD";
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btndetener
            // 
            this.btndetener.Image = ((System.Drawing.Image)(resources.GetObject("btndetener.Image")));
            this.btndetener.Location = new System.Drawing.Point(454, 38);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(42, 35);
            this.btndetener.TabIndex = 3;
            this.btndetener.ToolTip = "Detener Servicio BD";
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtestado);
            this.groupControl1.Controls.Add(this.btndetener);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btniniciar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(516, 91);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Verficación de Estado del Servidor";
            // 
            // frm_statusSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 91);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(532, 130);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(532, 130);
            this.Name = "frm_statusSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_statusSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtestado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtestado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btniniciar;
        private DevExpress.XtraEditors.SimpleButton btndetener;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}