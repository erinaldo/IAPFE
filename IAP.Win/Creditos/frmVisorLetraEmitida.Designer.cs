namespace IAP.Win.Creditos
{
    partial class frmVisorLetraEmitida
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvwletras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(746, 406);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // rpvwletras
            // 
            this.rpvwletras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvwletras.Location = new System.Drawing.Point(0, 0);
            this.rpvwletras.Name = "rpvwletras";
            this.rpvwletras.ServerReport.BearerToken = null;
            this.rpvwletras.Size = new System.Drawing.Size(800, 450);
            this.rpvwletras.TabIndex = 1;
            // 
            // frmVisorLetraEmitida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvwletras);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisorLetraEmitida";
            this.Text = "Visor de Letras Electronicas";
            this.Load += new System.EventHandler(this.frmVisorLetraEmitida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvwletras;
    }
}