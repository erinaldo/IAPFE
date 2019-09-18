namespace IAP.Win
{
    partial class ListaDePrecios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDePrecios));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkstockmayorcero = new System.Windows.Forms.CheckBox();
            this.txtcodf = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.chkcostomayorcero = new System.Windows.Forms.CheckBox();
            this.cmbgrupo = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cmbsubfamilia = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cmbfamilia = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnobtenercostos = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtincremento = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.gclista = new DevExpress.XtraGrid.GridControl();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Marcatodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Limpiatodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EnviarListaAndroid = new System.Windows.Forms.ToolStripMenuItem();
            this.gvwlista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnexportar = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnincrementomasivo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtbusqueda = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txttc = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfechatc = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbsubfamilia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbfamilia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtincremento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclista)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfechatc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkstockmayorcero);
            this.panelControl1.Controls.Add(this.txtcodf);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.chkcostomayorcero);
            this.panelControl1.Controls.Add(this.cmbgrupo);
            this.panelControl1.Controls.Add(this.cmbsubfamilia);
            this.panelControl1.Controls.Add(this.cmbfamilia);
            this.panelControl1.Controls.Add(this.btnguardar);
            this.panelControl1.Controls.Add(this.btnobtenercostos);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(2, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // chkstockmayorcero
            // 
            this.chkstockmayorcero.AutoSize = true;
            this.chkstockmayorcero.Location = new System.Drawing.Point(582, 33);
            this.chkstockmayorcero.Name = "chkstockmayorcero";
            this.chkstockmayorcero.Size = new System.Drawing.Size(72, 17);
            this.chkstockmayorcero.TabIndex = 17;
            this.chkstockmayorcero.Text = "Stock > 0";
            this.chkstockmayorcero.UseVisualStyleBackColor = true;
            // 
            // txtcodf
            // 
            this.txtcodf.Location = new System.Drawing.Point(49, 40);
            this.txtcodf.Name = "txtcodf";
            this.txtcodf.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtcodf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtcodf.Properties.Appearance.Options.UseBackColor = true;
            this.txtcodf.Properties.Appearance.Options.UseFont = true;
            this.txtcodf.Size = new System.Drawing.Size(135, 18);
            this.txtcodf.TabIndex = 16;
            this.txtcodf.EditValueChanged += new System.EventHandler(this.txtcodf_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Item";
            // 
            // chkcostomayorcero
            // 
            this.chkcostomayorcero.AutoSize = true;
            this.chkcostomayorcero.Location = new System.Drawing.Point(582, 16);
            this.chkcostomayorcero.Name = "chkcostomayorcero";
            this.chkcostomayorcero.Size = new System.Drawing.Size(114, 17);
            this.chkcostomayorcero.TabIndex = 14;
            this.chkcostomayorcero.Text = "Costo Ingreso > 0";
            this.chkcostomayorcero.UseVisualStyleBackColor = true;
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.Location = new System.Drawing.Point(436, 13);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbgrupo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.cmbgrupo.Properties.Appearance.Options.UseBackColor = true;
            this.cmbgrupo.Properties.Appearance.Options.UseFont = true;
            this.cmbgrupo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbgrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbgrupo.Size = new System.Drawing.Size(135, 19);
            this.cmbgrupo.TabIndex = 13;
            // 
            // cmbsubfamilia
            // 
            this.cmbsubfamilia.Location = new System.Drawing.Point(252, 14);
            this.cmbsubfamilia.Name = "cmbsubfamilia";
            this.cmbsubfamilia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbsubfamilia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.cmbsubfamilia.Properties.Appearance.Options.UseBackColor = true;
            this.cmbsubfamilia.Properties.Appearance.Options.UseFont = true;
            this.cmbsubfamilia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbsubfamilia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbsubfamilia.Size = new System.Drawing.Size(135, 19);
            this.cmbsubfamilia.TabIndex = 12;
            this.cmbsubfamilia.EditValueChanged += new System.EventHandler(this.cmbsubfamilia_EditValueChanged);
            // 
            // cmbfamilia
            // 
            this.cmbfamilia.Location = new System.Drawing.Point(49, 14);
            this.cmbfamilia.Name = "cmbfamilia";
            this.cmbfamilia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbfamilia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.cmbfamilia.Properties.Appearance.Options.UseBackColor = true;
            this.cmbfamilia.Properties.Appearance.Options.UseFont = true;
            this.cmbfamilia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbfamilia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbfamilia.Size = new System.Drawing.Size(135, 19);
            this.cmbfamilia.TabIndex = 11;
            this.cmbfamilia.EditValueChanged += new System.EventHandler(this.cmbfamilia_EditValueChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.ImageOptions.Image")));
            this.btnguardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnguardar.Location = new System.Drawing.Point(739, 9);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(36, 36);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.ToolTip = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnobtenercostos
            // 
            this.btnobtenercostos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnobtenercostos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnobtenercostos.ImageOptions.Image")));
            this.btnobtenercostos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnobtenercostos.Location = new System.Drawing.Point(697, 9);
            this.btnobtenercostos.Name = "btnobtenercostos";
            this.btnobtenercostos.Size = new System.Drawing.Size(36, 36);
            this.btnobtenercostos.TabIndex = 7;
            this.btnobtenercostos.ToolTip = "Obtener Costos";
            this.btnobtenercostos.Click += new System.EventHandler(this.btnobtenercostos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SubFamilia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Familia";
            // 
            // txtincremento
            // 
            this.txtincremento.Location = new System.Drawing.Point(169, 21);
            this.txtincremento.Name = "txtincremento";
            this.txtincremento.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtincremento.Properties.Appearance.Options.UseBackColor = true;
            this.txtincremento.Properties.Mask.EditMask = "n2";
            this.txtincremento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtincremento.Size = new System.Drawing.Size(66, 20);
            this.txtincremento.TabIndex = 9;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.gclista);
            this.panelControl2.Location = new System.Drawing.Point(3, 116);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1060, 382);
            this.panelControl2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1056, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lista de Precios - Ingreso en Dolares";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gclista
            // 
            this.gclista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gclista.ContextMenuStrip = this.menu;
            this.gclista.Location = new System.Drawing.Point(2, 18);
            this.gclista.MainView = this.gvwlista;
            this.gclista.Name = "gclista";
            this.gclista.Size = new System.Drawing.Size(1056, 357);
            this.gclista.TabIndex = 0;
            this.gclista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwlista});
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Marcatodo,
            this.Limpiatodo,
            this.toolStripSeparator1,
            this.EnviarListaAndroid});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(179, 76);
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked_1);
            // 
            // Marcatodo
            // 
            this.Marcatodo.Image = global::IAP.Win.Properties.Resources.Apply_32x32;
            this.Marcatodo.Name = "Marcatodo";
            this.Marcatodo.Size = new System.Drawing.Size(178, 22);
            this.Marcatodo.Text = "Marcar Todo";
            // 
            // Limpiatodo
            // 
            this.Limpiatodo.Image = global::IAP.Win.Properties.Resources.ClearFilter_32x32;
            this.Limpiatodo.Name = "Limpiatodo";
            this.Limpiatodo.Size = new System.Drawing.Size(178, 22);
            this.Limpiatodo.Text = "Limpiar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // EnviarListaAndroid
            // 
            this.EnviarListaAndroid.Image = global::IAP.Win.Properties.Resources.android;
            this.EnviarListaAndroid.Name = "EnviarListaAndroid";
            this.EnviarListaAndroid.Size = new System.Drawing.Size(178, 22);
            this.EnviarListaAndroid.Text = "Exportar Lista a APP";
            // 
            // gvwlista
            // 
            this.gvwlista.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvwlista.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvwlista.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvwlista.GridControl = this.gclista;
            this.gvwlista.Name = "gvwlista";
            this.gvwlista.OptionsView.ShowGroupPanel = false;
            this.gvwlista.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvwlista_RowCellClick);
            this.gvwlista.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvwlista_RowCellStyle);
            this.gvwlista.ShownEditor += new System.EventHandler(this.gvwlista_ShownEditor);
            this.gvwlista.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvwlista_RowUpdated);
            this.gvwlista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvwlista_KeyDown);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.btnexportar);
            this.panelControl3.Controls.Add(this.label9);
            this.panelControl3.Controls.Add(this.btnincrementomasivo);
            this.panelControl3.Controls.Add(this.txtincremento);
            this.panelControl3.Location = new System.Drawing.Point(788, 1);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(275, 63);
            this.panelControl3.TabIndex = 2;
            // 
            // btnexportar
            // 
            this.btnexportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.ImageOptions.Image")));
            this.btnexportar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnexportar.Location = new System.Drawing.Point(5, 11);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(36, 36);
            this.btnexportar.TabIndex = 17;
            this.btnexportar.ToolTip = "Guardar";
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "%INCREMENTO MASIVO";
            // 
            // btnincrementomasivo
            // 
            this.btnincrementomasivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnincrementomasivo.ImageOptions.Image")));
            this.btnincrementomasivo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnincrementomasivo.Location = new System.Drawing.Point(242, 19);
            this.btnincrementomasivo.Name = "btnincrementomasivo";
            this.btnincrementomasivo.Size = new System.Drawing.Size(26, 24);
            this.btnincrementomasivo.TabIndex = 15;
            this.btnincrementomasivo.ToolTip = "Incremento Masivo";
            this.btnincrementomasivo.Click += new System.EventHandler(this.btnincrementomasivo_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtbusqueda);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txttc);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtfechatc);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Location = new System.Drawing.Point(2, 65);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1061, 50);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Datos Adicionales";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(549, 25);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtbusqueda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtbusqueda.Properties.Appearance.Options.UseBackColor = true;
            this.txtbusqueda.Properties.Appearance.Options.UseFont = true;
            this.txtbusqueda.Size = new System.Drawing.Size(440, 20);
            this.txtbusqueda.TabIndex = 22;
            this.txtbusqueda.EditValueChanged += new System.EventHandler(this.txtbusqueda_EditValueChanged);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(487, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Busqueda";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(101, 24);
            this.txttc.Name = "txttc";
            this.txttc.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txttc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txttc.Properties.Appearance.Options.UseBackColor = true;
            this.txttc.Properties.Appearance.Options.UseFont = true;
            this.txttc.Properties.ReadOnly = true;
            this.txttc.Size = new System.Drawing.Size(53, 20);
            this.txttc.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo de Cambio";
            // 
            // txtfechatc
            // 
            this.txtfechatc.Location = new System.Drawing.Point(337, 25);
            this.txtfechatc.Name = "txtfechatc";
            this.txtfechatc.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtfechatc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtfechatc.Properties.Appearance.Options.UseBackColor = true;
            this.txtfechatc.Properties.Appearance.Options.UseFont = true;
            this.txtfechatc.Properties.ReadOnly = true;
            this.txtfechatc.Size = new System.Drawing.Size(95, 20);
            this.txtfechatc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.Location = new System.Drawing.Point(186, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha del Tipo de Cambio";
            // 
            // ListaDePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 507);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ListaDePrecios";
            this.Text = "Lista de Precios - Comercial";
            this.Activated += new System.EventHandler(this.ListaDePrecios_Activated);
            this.Load += new System.EventHandler(this.ListaDePrecios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbsubfamilia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbfamilia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtincremento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclista)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvwlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfechatc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnobtenercostos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gclista;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwlista;
        private DevExpress.XtraEditors.TextEdit txtincremento;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbfamilia;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbgrupo;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbsubfamilia;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Marcatodo;
        private System.Windows.Forms.ToolStripMenuItem Limpiatodo;
        private System.Windows.Forms.CheckBox chkcostomayorcero;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnincrementomasivo;
        private DevExpress.XtraEditors.TextEdit txtcodf;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txttc;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtfechatc;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtbusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkstockmayorcero;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnexportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EnviarListaAndroid;
    }
}