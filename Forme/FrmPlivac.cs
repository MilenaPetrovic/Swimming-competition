using System;
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
    public partial class FrmPlivac : Form
    {
        public FrmPlivac()
        {
            InitializeComponent();

            PopuniFormu();
        }

        private void PopuniFormu()
        {
            List<string> stilovi = KKI.KKIPlivac.Instance.UcitajListuStilova();
            cmbStil.DataSource = stilovi;

            datumRodjenja.CustomFormat = "dd-MM-yyyy";
            datumRodjenja.Format = DateTimePickerFormat.Custom;

            txtIme.Text = KKI.KKIPlivac.Instance.Plivac.ImePlivaca;
            txtPrezime.Text = KKI.KKIPlivac.Instance.Plivac.PrezimePlivaca;
            datumRodjenja.Text = KKI.KKIPlivac.Instance.Plivac.DatumRodjenja.ToString("dd-MM-yyyy");            
            cmbStil.Text = KKI.KKIPlivac.Instance.Plivac.Kategorija.ImeKategorije;

            string pol = KKI.KKIPlivac.Instance.Plivac.Pol;

            if(pol[0] == 'M')
            {
                rbM.Select();
            }
            else
            {
                rbZ.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranog plivaca?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rez == DialogResult.Cancel)
                return;

            try
            {
                string poruka = KKI.KKIPlivac.Instance.ObrisiPlivaca();
                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string pol = "";
                if (rbM.Checked)
                {
                    pol = "M";
                }
                else if (rbZ.Checked)
                {
                    pol = "Z";
                }
                else
                {
                    MessageBox.Show("Odaberite pol!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string poruka = KKI.KKIPlivac.Instance.IzmeniPlivaca(txtIme.Text, txtPrezime.Text, cmbStil.SelectedItem.ToString(), pol, datumRodjenja.Text);

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
    }
}
