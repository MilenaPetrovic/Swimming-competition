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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTakmicenja = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
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
            this.unosNovogToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.unosNovogToolStripMenuItem.Text = "Unos novog";
            // 
            // btnDetaljniji
            // 
            this.btnDetaljniji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaljniji.Location = new System.Drawing.Point(77, 481);
            this.btnDetaljniji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetaljniji.Name = "btnDetaljniji";
            this.btnDetaljniji.Size = new System.Drawing.Size(205, 41);
            this.btnDetaljniji.TabIndex = 20;
            this.btnDetaljniji.Text = "Detaljniji pregled";
            this.btnDetaljniji.UseVisualStyleBackColor = true;
            this.btnDetaljniji.Click += new System.EventHandler(this.btnDetaljniji_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rbZ);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(551, 180);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            this.groupBox1.Enter += new System.EventHandler(this.s);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 105);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(475, 46);
            this.rbZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(45, 29);
            this.rbZ.TabIndex = 8;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Z";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(408, 46);
            this.rbM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(50, 29);
            this.rbM.TabIndex = 7;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mesto:";
            // 
            // dgvTakmicenja
            // 
            this.dgvTakmicenja.AllowUserToAddRows = false;
            this.dgvTakmicenja.AllowUserToDeleteRows = false;
            this.dgvTakmicenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakmicenja.Location = new System.Drawing.Point(31, 241);
            this.dgvTakmicenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTakmicenja.Name = "dgvTakmicenja";
            this.dgvTakmicenja.RowTemplate.Height = 24;
            this.dgvTakmicenja.Size = new System.Drawing.Size(551, 224);
            this.dgvTakmicenja.TabIndex = 18;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(376, 481);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(161, 41);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj novo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDetaljniji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvTakmicenja);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plivaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogToolStripMenuItem;
        private System.Windows.Forms.Button btnDetaljniji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTakmicenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}