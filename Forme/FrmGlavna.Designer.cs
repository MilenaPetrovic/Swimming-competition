namespace Forme
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.menusStrip1 = new System.Windows.Forms.MenuStrip();
            this.plivaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaMTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetaljniji = new System.Windows.Forms.Button();
            this.dgvTakmicenja = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.menusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenja)).BeginInit();
            this.SuspendLayout();
            // 
            // menusStrip1
            // 
            this.menusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plivaciToolStripMenuItem,
            this.odjavaMTSI,
            this.adminMTSI});
            this.menusStrip1.Location = new System.Drawing.Point(0, 0);
            this.menusStrip1.Name = "menusStrip1";
            this.menusStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menusStrip1.Size = new System.Drawing.Size(713, 28);
            this.menusStrip1.TabIndex = 0;
            // 
            // plivaciToolStripMenuItem
            // 
            this.plivaciToolStripMenuItem.Name = "plivaciToolStripMenuItem";
            this.plivaciToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.plivaciToolStripMenuItem.Text = "Plivaci";
            this.plivaciToolStripMenuItem.Click += new System.EventHandler(this.plivaciToolStripMenuItem_Click);
            // 
            // odjavaMTSI
            // 
            this.odjavaMTSI.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjavaMTSI.Name = "odjavaMTSI";
            this.odjavaMTSI.Size = new System.Drawing.Size(68, 24);
            this.odjavaMTSI.Text = "Odjava";
            this.odjavaMTSI.Click += new System.EventHandler(this.odjavaMTSI_Click);
            // 
            // adminMTSI
            // 
            this.adminMTSI.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminMTSI.Name = "adminMTSI";
            this.adminMTSI.Size = new System.Drawing.Size(65, 24);
            this.adminMTSI.Text = "Admin";
            // 
            // btnDetaljniji
            // 
            this.btnDetaljniji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaljniji.Location = new System.Drawing.Point(126, 364);
            this.btnDetaljniji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetaljniji.Name = "btnDetaljniji";
            this.btnDetaljniji.Size = new System.Drawing.Size(205, 41);
            this.btnDetaljniji.TabIndex = 20;
            this.btnDetaljniji.Text = "Detaljniji pregled";
            this.btnDetaljniji.UseVisualStyleBackColor = true;
            this.btnDetaljniji.Click += new System.EventHandler(this.btnDetaljniji_Click);
            // 
            // dgvTakmicenja
            // 
            this.dgvTakmicenja.AllowUserToAddRows = false;
            this.dgvTakmicenja.AllowUserToDeleteRows = false;
            this.dgvTakmicenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakmicenja.Location = new System.Drawing.Point(36, 113);
            this.dgvTakmicenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTakmicenja.Name = "dgvTakmicenja";
            this.dgvTakmicenja.RowTemplate.Height = 24;
            this.dgvTakmicenja.Size = new System.Drawing.Size(641, 224);
            this.dgvTakmicenja.TabIndex = 18;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(423, 364);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(161, 41);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj novo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(112, 52);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(245, 34);
            this.txtPretraga.TabIndex = 21;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(423, 50);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(161, 41);
            this.btnPretrazi.TabIndex = 22;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 422);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnDetaljniji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.menusStrip1);
            this.Controls.Add(this.dgvTakmicenja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menusStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plivacka takmicenja";
            this.menusStrip1.ResumeLayout(false);
            this.menusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menusStrip1;
        private System.Windows.Forms.ToolStripMenuItem plivaciToolStripMenuItem;
        private System.Windows.Forms.Button btnDetaljniji;
        private System.Windows.Forms.DataGridView dgvTakmicenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odjavaMTSI;
        private System.Windows.Forms.ToolStripMenuItem adminMTSI;
    }
}