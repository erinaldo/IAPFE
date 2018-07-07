namespace IAP.Win
{
    partial class frmborrar_documento
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmborrar_documento));
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnverificar = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(195, 154);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(63, 23);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(137, 49);
            this.txtnumero.MaxLength = 12;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(121, 20);
            this.txtnumero.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero de Documento :";
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "FACTURA",
            "BOLETA",
            "GUIA REMISION"});
            this.cmbtipo.Location = new System.Drawing.Point(137, 12);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(121, 21);
            this.cmbtipo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo De Documento :";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(114, 154);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(66, 23);
            this.btnborrar.TabIndex = 6;
            this.btnborrar.Text = "BORRAR";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnverificar
            // 
            this.btnverificar.Image = ((System.Drawing.Image)(resources.GetObject("btnverificar.Image")));
            this.btnverificar.Location = new System.Drawing.Point(265, 41);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(27, 28);
            this.btnverificar.TabIndex = 13;
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst
            // 
            this.lst.BackColor = System.Drawing.SystemColors.Info;
            this.lst.Font = new System.Drawing.Font("Arimo", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 11;
            this.lst.Location = new System.Drawing.Point(6, 83);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(295, 59);
            this.lst.TabIndex = 12;
            // 
            // frmborrar_documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnborrar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 223);
            this.MinimizeBox = false;
            this.Name = "frmborrar_documento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrado de Data";
            this.Load += new System.EventHandler(this.frmborrar_documento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.ListBox lst;
    }
}

