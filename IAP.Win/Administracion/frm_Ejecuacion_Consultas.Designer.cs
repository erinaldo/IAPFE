namespace IAP.Win
{
    partial class frm_Ejecuacion_Consultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.btnejecutar = new System.Windows.Forms.Button();
            this.txtdescifrado = new System.Windows.Forms.TextBox();
            this.txtnormal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto :";
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(66, 32);
            this.txtconsulta.Multiline = true;
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(551, 422);
            this.txtconsulta.TabIndex = 1;
            // 
            // btnejecutar
            // 
            this.btnejecutar.Location = new System.Drawing.Point(1147, 3);
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.Size = new System.Drawing.Size(75, 23);
            this.btnejecutar.TabIndex = 2;
            this.btnejecutar.Text = "PROCESAR";
            this.btnejecutar.UseVisualStyleBackColor = true;
            this.btnejecutar.Click += new System.EventHandler(this.btnejecutar_Click);
            // 
            // txtdescifrado
            // 
            this.txtdescifrado.Location = new System.Drawing.Point(640, 32);
            this.txtdescifrado.Multiline = true;
            this.txtdescifrado.Name = "txtdescifrado";
            this.txtdescifrado.Size = new System.Drawing.Size(551, 422);
            this.txtdescifrado.TabIndex = 3;
            // 
            // txtnormal
            // 
            this.txtnormal.Location = new System.Drawing.Point(52, 460);
            this.txtnormal.Multiline = true;
            this.txtnormal.Name = "txtnormal";
            this.txtnormal.Size = new System.Drawing.Size(1139, 158);
            this.txtnormal.TabIndex = 4;
            // 
            // frm_Ejecuacion_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 630);
            this.Controls.Add(this.txtnormal);
            this.Controls.Add(this.txtdescifrado);
            this.Controls.Add(this.btnejecutar);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.label1);
            this.Name = "frm_Ejecuacion_Consultas";
            this.Text = "frm_Ejecuacion_Consultas";
            this.Load += new System.EventHandler(this.frm_Ejecuacion_Consultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button btnejecutar;
        private System.Windows.Forms.TextBox txtdescifrado;
        private System.Windows.Forms.TextBox txtnormal;
    }
}