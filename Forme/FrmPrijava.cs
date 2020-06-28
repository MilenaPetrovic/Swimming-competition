using Domen;
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
    public partial class FrmPrijava : Form
    {
        BindingList<Plivac> sviPlivaci = null;
        BindingList<Plivac> prijavljeniPlivaci;

        public FrmPrijava()
        {
            InitializeComponent();

            if(sviPlivaci == null)
            {
                KKI.KKIPlivac.Instance.UcitajListuPlivaca(dgvSvi);
                sviPlivaci = new BindingList<Plivac>((KKI.KKIPlivac.Instance.Plivaci).Cast<Plivac>().ToList());
            }

            dgvSvi.DataSource = sviPlivaci;

            prijavljeniPlivaci = KKI.KKITakmicenje.Instance.PrijavljeniPlivaci;
            dgvPrijavljeni.DataSource = prijavljeniPlivaci;
        }
                        
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {                
                string poruka = KKI.KKITakmicenje.Instance.SacuvajNovePrijave();
                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdjavi_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> redovi = new List<DataGridViewRow>();

            foreach (DataGridViewCell celija in dgvPrijavljeni.SelectedCells)
            {
                int rowIndex = celija.RowIndex;
                bool postoji = false;
                foreach (DataGridViewRow red in redovi)
                {
                    if (red.Index == rowIndex)
                    {
                        postoji = true;
                        break;
                    }
                }

                if (!postoji)
                {
                    redovi.Add(dgvPrijavljeni.Rows[rowIndex]);
                }
            }

            try
            {
                KKI.KKITakmicenje.Instance.IzaberiPlivace(dgvPrijavljeni, redovi);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> redovi = new List<DataGridViewRow>();

            foreach (DataGridViewCell celija in dgvSvi.SelectedCells)
            {
                int rowIndex = celija.RowIndex;
                bool postoji = false;
                foreach (DataGridViewRow red in redovi)
                {
                    if (red.Index == rowIndex)
                    {
                        postoji = true;
                        break;
                    }
                }

                if (!postoji)
                {
                    redovi.Add(dgvSvi.Rows[rowIndex]);
                }
            }

            try
            {
                KKI.KKITakmicenje.Instance.IzaberiPlivace(dgvSvi, redovi);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
