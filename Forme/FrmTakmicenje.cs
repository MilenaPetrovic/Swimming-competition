using KKI;
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
    public partial class FrmTakmicenje : Form
    {
        public FrmTakmicenje()
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

            txtNaziv.Text = KKI.KKITakmicenje.Instance.Takmicenje.NazivTakmicenja;
            txtBrojPrijavljenih.Text = KKI.KKITakmicenje.Instance.Takmicenje.BrojPrijava.ToString();
            datumOdrzavanja.Text = KKI.KKITakmicenje.Instance.Takmicenje.DatumOdrzavanja.ToString("dd-MM-yyyy");
            cmbMesta.Text = KKI.KKITakmicenje.Instance.Takmicenje.MestoOdrzavanja.NazivMesta;

            UcitajPrijave();

            dgvPrijavljeni.Columns[0].Visible = false;
            dgvPrijavljeni.Columns[1].Visible = false;
            dgvPrijavljeni.Columns[2].ReadOnly = true;
            dgvPrijavljeni.Columns[3].ReadOnly = true;
            dgvPrijavljeni.Columns[4].ReadOnly = true;

            dgvPrijavljeni.Columns[5].Width = 80;
            dgvPrijavljeni.Columns[6].Width = 80;
        }

        private void UcitajPrijave()
        {
            try
            {
                KKITakmicenje.Instance.UcitajPrijave(dgvPrijavljeni);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prijave frmPrijava = new Prijave();
            frmPrijava.ShowDialog();
            KKITakmicenje.Instance.UcitajPrijave(dgvPrijavljeni);
            txtBrojPrijavljenih.Text = KKITakmicenje.Instance.Takmicenje.Prijave.Count().ToString();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string poruka = KKI.KKITakmicenje.Instance.IzmeniTakmicenje(txtNaziv.Text, txtBrojPrijavljenih.Text, datumOdrzavanja.Text, cmbMesta.SelectedItem.ToString());
                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("instance"))
                    MessageBox.Show("Neispravno unet naziv kategorije!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrano takmicenje?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rez == DialogResult.Cancel)
                return;

            try
            {
                string poruka = KKI.KKITakmicenje.Instance.ObrisiTakmicenje();
                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezultati_Click(object sender, EventArgs e)
        {
            string poruka = KKI.KKITakmicenje.Instance.EvidencijaRezultata();
            MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
