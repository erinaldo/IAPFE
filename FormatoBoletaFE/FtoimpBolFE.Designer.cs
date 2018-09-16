namespace FormatoBoletaFE
{
    partial class FtoimpBolFE
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
            this.rpvwboleta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvwboleta
            // 
            this.rpvwboleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvwboleta.Location = new System.Drawing.Point(0, 0);
            this.rpvwboleta.Name = "rpvwboleta";
            this.rpvwboleta.ServerReport.BearerToken = null;
            this.rpvwboleta.Size = new System.Drawing.Size(800, 450);
            this.rpvwboleta.TabIndex = 0;
            // 
            // FtoimpBolFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvwboleta);
            this.Name = "FtoimpBolFE";
            this.Text = ".:: Formato Impresion Boleta de Venta ::.";
            this.Load += new System.EventHandler(this.FtoimpBolFE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvwboleta;
    }
}

