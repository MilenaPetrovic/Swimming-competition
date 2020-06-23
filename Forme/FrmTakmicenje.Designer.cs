namespace Forme
{
    partial class FrmTakmicenje
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
            this.dgvPrijavljeni = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.datumOdrzavanja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cmbMesta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojPrijavljenih = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijavljeni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrijavljeni
            // 
            this.dgvPrijavljeni.AllowUserToAddRows = false;
            this.dgvPrijavljeni.AllowUserToDeleteRows = false;
            this.dgvPrijavljeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijavljeni.Location = new System.Drawing.Point(52, 194);
            this.dgvPrijavljeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrijavljeni.Name = "dgvPrijavljeni";
            this.dgvPrijavljeni.ReadOnly = true;
            this.dgvPrijavljeni.RowTemplate.Height = 24;
            this.dgvPrijavljeni.Size = new System.Drawing.Size(851, 233);
            this.dgvPrijavljeni.TabIndex = 27;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(509, 448);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(161, 41);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // datumOdrzavanja
            // 
            this.datumOdrzavanja.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumOdrzavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumOdrzavanja.Location = new System.Drawing.Point(227, 95);
            this.datumOdrzavanja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datumOdrzavanja.Name = "datumOdrzavanja";
            this.datumOdrzavanja.Size = new System.Drawing.Size(272, 30);
            this.datumOdrzavanja.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Datum odrzavanja:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(279, 448);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(199, 41);
            this.btnIzmeni.TabIndex = 21;
            this.btnIzmeni.Text = "Sacuvaj izmene";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // cmbMesta
            // 
            this.cmbMesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesta.FormattingEnabled = true;
            this.cmbMesta.Location = new System.Drawing.Point(620, 28);
            this.cmbMesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMesta.Name = "cmbMesta";
            this.cmbMesta.Size = new System.Drawing.Size(253, 33);
            this.cmbMesta.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mesto:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(187, 31);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(255, 30);
            this.txtNaziv.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Naziv:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(713, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 41);
            this.button1.TabIndex = 46;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Takmicari i rezultati";
            // 
            // txtBrojPrijavljenih
            // 
            this.txtBrojPrijavljenih.Enabled = false;
            this.txtBrojPrijavljenih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojPrijavljenih.Location = new System.Drawing.Point(693, 94);
            this.txtBrojPrijavljenih.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojPrijavljenih.Name = "txtBrojPrijavljenih";
            this.txtBrojPrijavljenih.Size = new System.Drawing.Size(180, 30);
            this.txtBrojPrijavljenih.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Broj prijavljenih:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(77, 448);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 41);
            this.button2.TabIndex = 52;
            this.button2.Text = "Prijave";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmTakmicenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBrojPrijavljenih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPrijavljeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.datumOdrzavanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzmeni);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTakmicenje";
            this.Text = "FrmTakmicenje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijavljeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrijavljeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DateTimePicker datumOdrzavanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox cmbMesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojPrijavljenih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}