﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmUnosTakmicenja : Form
    {
        public FrmUnosTakmicenja()
        {
            InitializeComponent();
            PopuniFormu();
        }

        private void PopuniFormu()
        {
            List<string> mesta = KKI.KKITakmicenje.Instance.UcitajListuMesta();
            cmbMesta.DataSource = mesta;

            datumOdrzavanja.CustomFormat = "dd-MM-yyyy";
            datumOdrzavanja.Format = DateTimePickerFormat.Custom;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {                
                string poruka = KKI.KKITakmicenje.Instance.KreirajTakmicenje(txtNaziv.Text,cmbMesta.SelectedItem.ToString(), datumOdrzavanja.Text);

                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dispose();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("instance"))
                    MessageBox.Show("Neispravno unet naziv kategorije!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
