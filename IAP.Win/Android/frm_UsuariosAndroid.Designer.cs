namespace IAP.Win
{
    partial class frm_UsuariosAndroid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UsuariosAndroid));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkactualizaclave = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnnuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.btneditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnsiguiente = new DevExpress.XtraEditors.SimpleButton();
            this.btnanterior = new DevExpress.XtraEditors.SimpleButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtrazonsocial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtruc = new DevExpress.XtraEditors.TextEdit();
            this.txtclave = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtusuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtapellidos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtnombre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrazonsocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtruc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtclave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtapellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkactualizaclave);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.txtclave);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtusuario);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmbsexo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtapellidos);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtnombre);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(261, 374);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Administración de Usuarios";
            // 
            // chkactualizaclave
            // 
            this.chkactualizaclave.AutoSize = true;
            this.chkactualizaclave.Location = new System.Drawing.Point(204, 128);
            this.chkactualizaclave.Name = "chkactualizaclave";
            this.chkactualizaclave.Size = new System.Drawing.Size(47, 17);
            this.chkactualizaclave.TabIndex = 15;
            this.chkactualizaclave.Text = "Mod";
            this.chkactualizaclave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btnsiguiente);
            this.panel1.Controls.Add(this.btnanterior);
            this.panel1.Location = new System.Drawing.Point(5, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 37);
            this.panel1.TabIndex = 14;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(160, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(24, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.ToolTip = "Cerrar";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(130, 4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(24, 23);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.ToolTip = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(100, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(24, 23);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.ToolTip = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(70, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(24, 23);
            this.btneditar.TabIndex = 3;
            this.btneditar.ToolTip = "Modificar";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnsiguiente.Image")));
            this.btnsiguiente.Location = new System.Drawing.Point(40, 4);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(24, 23);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.ToolTip = "Siguiente";
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Image = ((System.Drawing.Image)(resources.GetObject("btnanterior.Image")));
            this.btnanterior.Location = new System.Drawing.Point(10, 4);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(24, 23);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.ToolTip = "Anterior";
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(209, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(40, 20);
            this.txtid.TabIndex = 13;
            this.txtid.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtrazonsocial);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.txtruc);
            this.groupBox1.Location = new System.Drawing.Point(5, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 173);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(58, 69);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.ReadOnly = true;
            this.txtdireccion.Size = new System.Drawing.Size(186, 98);
            this.txtdireccion.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 73);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "Dirección:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Nombre:";
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Enabled = false;
            this.txtrazonsocial.Location = new System.Drawing.Point(58, 43);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(186, 20);
            this.txtrazonsocial.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(31, 22);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Ruc:";
            // 
            // txtruc
            // 
            this.txtruc.Enabled = false;
            this.txtruc.Location = new System.Drawing.Point(58, 19);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(135, 20);
            this.txtruc.TabIndex = 6;
            // 
            // txtclave
            // 
            this.txtclave.Enabled = false;
            this.txtclave.Location = new System.Drawing.Point(68, 127);
            this.txtclave.Name = "txtclave";
            this.txtclave.Properties.PasswordChar = '-';
            this.txtclave.Size = new System.Drawing.Size(130, 20);
            this.txtclave.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(31, 129);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Clave:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(68, 103);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(130, 20);
            this.txtusuario.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Sexo:";
            // 
            // cmbsexo
            // 
            this.cmbsexo.Enabled = false;
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(68, 76);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(62, 21);
            this.cmbsexo.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Apellidos:";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Enabled = false;
            this.txtapellidos.Location = new System.Drawing.Point(68, 53);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(181, 20);
            this.txtapellidos.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nombre :";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(68, 29);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(130, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // frm_UsuariosAndroid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 374);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UsuariosAndroid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_UsuariosAndroid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrazonsocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtruc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtclave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtapellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtrazonsocial;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtruc;
        private DevExpress.XtraEditors.TextEdit txtclave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtusuario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbsexo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtapellidos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtnombre;
        private DevExpress.XtraEditors.SimpleButton btnanterior;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnsalir;
        private DevExpress.XtraEditors.SimpleButton btnnuevo;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraEditors.SimpleButton btneditar;
        private DevExpress.XtraEditors.SimpleButton btnsiguiente;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.CheckBox chkactualizaclave;
    }
}