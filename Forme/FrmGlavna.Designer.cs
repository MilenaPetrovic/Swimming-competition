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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plivaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetaljniji = new System.Windows.Forms.Button();
            this.dgvTakmicenja = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenja)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plivaciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(713, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plivaciToolStripMenuItem
            // 
            this.plivaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogToolStripMenuItem});
            this.plivaciToolStripMenuItem.Name = "plivaciToolStripMenuItem";
            this.plivaciToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.plivaciToolStripMenuItem.Text = "Plivaci";
            this.plivaciToolStripMenuItem.Click += new System.EventHandler(this.plivaciToolStripMenuItem_Click);
            // 
            // unosNovogToolStripMenuItem
            // 
            this.unosNovogToolStripMenuItem.Name = "unosNovogToolStripMenuItem";
            this.unosNovogToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.unosNovogToolStripMenuItem.Text = "Unos novog";
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
            this.dgvTakmicenja.Location = new System.Drawing.Point(34, 115);
            this.dgvTakmicenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTakmicenja.Name = "dgvTakmicenja";
            this.dgvTakmicenja.RowTemplate.Height = 24;
            this.dgvTakmicenja.Size = new System.Drawing.Size(642, 224);
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
            this.btnPretrazi.Location = new System.Drawing.Point(423, 52);
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
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvTakmicenja);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plivaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogToolStripMenuItem;
        private System.Windows.Forms.Button btnDetaljniji;
        private System.Windows.Forms.DataGridView dgvTakmicenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
    }
}