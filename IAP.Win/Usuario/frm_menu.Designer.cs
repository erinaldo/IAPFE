namespace IAP.Win
{
    partial class frm_menu
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
            this.btneliminardoc = new System.Windows.Forms.Button();
            this.btneliminararqueo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneliminardoc
            // 
            this.btneliminardoc.Location = new System.Drawing.Point(75, 34);
            this.btneliminardoc.Name = "btneliminardoc";
            this.btneliminardoc.Size = new System.Drawing.Size(144, 29);
            this.btneliminardoc.TabIndex = 0;
            this.btneliminardoc.Text = "ELIMINAR F-B-G";
            this.btneliminardoc.UseVisualStyleBackColor = true;
            this.btneliminardoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminararqueo
            // 
            this.btneliminararqueo.Location = new System.Drawing.Point(75, 82);
            this.btneliminararqueo.Name = "btneliminararqueo";
            this.btneliminararqueo.Size = new System.Drawing.Size(144, 28);
            this.btneliminararqueo.TabIndex = 1;
            this.btneliminararqueo.Text = "ELIMINAR ARQUEO";
            this.btneliminararqueo.UseVisualStyleBackColor = true;
            this.btneliminararqueo.Click += new System.EventHandler(this.btneliminararqueo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 161);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(277, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 183);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btneliminararqueo);
            this.Controls.Add(this.btneliminardoc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Administración";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminardoc;
        private System.Windows.Forms.Button btneliminararqueo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}