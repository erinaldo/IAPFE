namespace FormatoGuiaFE
{
    partial class FtoImpGuiaFe
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpvwguia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvwguia
            // 
            this.rpvwguia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvwguia.Location = new System.Drawing.Point(0, 0);
            this.rpvwguia.Name = "rpvwguia";
            this.rpvwguia.ServerReport.BearerToken = null;
            this.rpvwguia.Size = new System.Drawing.Size(800, 450);
            this.rpvwguia.TabIndex = 0;
            // 
            // FtoImpGuiaFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvwguia);
            this.Name = "FtoImpGuiaFe";
            this.Text = ".:: Formato de Guia de Remision Remitente ::.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvwguia;
    }
}

