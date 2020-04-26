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
            this.prijaveIRezultatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPrijavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaRezultataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plivaciToolStripMenuItem,
            this.prijaveIRezultatiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plivaciToolStripMenuItem
            // 
            this.plivaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogToolStripMenuItem,
            this.brisanjeToolStripMenuItem,
            this.izmenaToolStripMenuItem});
            this.plivaciToolStripMenuItem.Name = "plivaciToolStripMenuItem";
            this.plivaciToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.plivaciToolStripMenuItem.Text = "Plivaci";
            // 
            // prijaveIRezultatiToolStripMenuItem
            // 
            this.prijaveIRezultatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPrijavaToolStripMenuItem,
            this.evidencijaRezultataToolStripMenuItem});
            this.prijaveIRezultatiToolStripMenuItem.Name = "prijaveIRezultatiToolStripMenuItem";
            this.prijaveIRezultatiToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.prijaveIRezultatiToolStripMenuItem.Text = "Prijave i rezultati";
            // 
            // unosNovogToolStripMenuItem
            // 
            this.unosNovogToolStripMenuItem.Name = "unosNovogToolStripMenuItem";
            this.unosNovogToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.unosNovogToolStripMenuItem.Text = "Unos novog";
            // 
            // brisanjeToolStripMenuItem
            // 
            this.brisanjeToolStripMenuItem.Name = "brisanjeToolStripMenuItem";
            this.brisanjeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.brisanjeToolStripMenuItem.Text = "Obrisi";
            // 
            // izmenaToolStripMenuItem
            // 
            this.izmenaToolStripMenuItem.Name = "izmenaToolStripMenuItem";
            this.izmenaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.izmenaToolStripMenuItem.Text = "Izmeni";
            // 
            // novaPrijavaToolStripMenuItem
            // 
            this.novaPrijavaToolStripMenuItem.Name = "novaPrijavaToolStripMenuItem";
            this.novaPrijavaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.novaPrijavaToolStripMenuItem.Text = "Nova prijava";
            // 
            // evidencijaRezultataToolStripMenuItem
            // 
            this.evidencijaRezultataToolStripMenuItem.Name = "evidencijaRezultataToolStripMenuItem";
            this.evidencijaRezultataToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.evidencijaRezultataToolStripMenuItem.Text = "Evidencija rezultata";
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 453);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plivaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijaveIRezultatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPrijavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaRezultataToolStripMenuItem;
    }
}