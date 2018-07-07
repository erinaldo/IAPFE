namespace IAP.Win
{
    partial class frm_consultas_sql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultas_sql));
            this.label1 = new System.Windows.Forms.Label();
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo :";
            // 
            // txtarchivo
            // 
            this.txtarchivo.BackColor = System.Drawing.SystemColors.Info;
            this.txtarchivo.Location = new System.Drawing.Point(64, 21);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.ReadOnly = true;
            this.txtarchivo.Size = new System.Drawing.Size(356, 20);
            this.txtarchivo.TabIndex = 1;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(294, 47);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(53, 23);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Ok";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(367, 47);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(53, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(426, 19);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(45, 23);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frm_consultas_sql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 82);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtarchivo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(492, 120);
            this.MinimumSize = new System.Drawing.Size(492, 120);
            this.Name = "frm_consultas_sql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecuciones masivas";
            this.Load += new System.EventHandler(this.frm_consultas_sql_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtarchivo;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
    }
}