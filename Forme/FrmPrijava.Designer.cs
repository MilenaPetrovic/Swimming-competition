namespace Forme
{
    partial class Prijave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijave));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSvi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvPrijavljeni = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdjavi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijavljeni)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 66;
            this.label8.Text = "Prijavi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Odjavi";
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijavi.Location = new System.Drawing.Point(512, 206);
            this.btnPrijavi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(126, 41);
            this.btnPrijavi.TabIndex = 64;
            this.btnPrijavi.Text = "←";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(670, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Svi takmicari:";
            // 
            // dgvSvi
            // 
            this.dgvSvi.AllowUserToAddRows = false;
            this.dgvSvi.AllowUserToDeleteRows = false;
            this.dgvSvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSvi.Location = new System.Drawing.Point(657, 68);
            this.dgvSvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSvi.Name = "dgvSvi";
            this.dgvSvi.ReadOnly = true;
            this.dgvSvi.RowTemplate.Height = 24;
            this.dgvSvi.Size = new System.Drawing.Size(479, 233);
            this.dgvSvi.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Prijavljeni takmicari:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(675, 335);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(161, 41);
            this.btnOdustani.TabIndex = 59;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvPrijavljeni
            // 
            this.dgvPrijavljeni.AllowUserToAddRows = false;
            this.dgvPrijavljeni.AllowUserToDeleteRows = false;
            this.dgvPrijavljeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijavljeni.Location = new System.Drawing.Point(32, 68);
            this.dgvPrijavljeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrijavljeni.Name = "dgvPrijavljeni";
            this.dgvPrijavljeni.ReadOnly = true;
            this.dgvPrijavljeni.RowTemplate.Height = 24;
            this.dgvPrijavljeni.Size = new System.Drawing.Size(460, 233);
            this.dgvPrijavljeni.TabIndex = 58;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(306, 335);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(161, 41);
            this.btnSacuvaj.TabIndex = 56;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdjavi
            // 
            this.btnOdjavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjavi.Location = new System.Drawing.Point(512, 118);
            this.btnOdjavi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdjavi.Name = "btnOdjavi";
            this.btnOdjavi.Size = new System.Drawing.Size(126, 41);
            this.btnOdjavi.TabIndex = 63;
            this.btnOdjavi.Text = "→";
            this.btnOdjavi.UseVisualStyleBackColor = true;
            this.btnOdjavi.Click += new System.EventHandler(this.btnOdjavi_Click);
            // 
            // Prijave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 399);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrijavi);
            this.Controls.Add(this.btnOdjavi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSvi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dgvPrijavljeni);
            this.Controls.Add(this.btnSacuvaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Prijave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrijava";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijavljeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSvi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvPrijavljeni;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdjavi;
    }
}