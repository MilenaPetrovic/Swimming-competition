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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();

            UcitajTakmicenja();

            //dgvTakmicenja.Columns[0].Visible = false;
            //dgvTakmicenja.Columns[1].Width = 80;
            //dgvTakmicenja.Columns[2].Width = 100;
            //dgvTakmicenja.Columns[3].Width = 100;
            //dgvTakmicenja.Columns[5].Width = 50;
        }

        private void UcitajTakmicenja()
        {
            try
            {
                KKITakmicenje.Instance.UcitajListuTakmicenja(dgvTakmicenja);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmUnosTakmicenja frmUnosTakmicenja = new FrmUnosTakmicenja();
            frmUnosTakmicenja.ShowDialog();

            KKITakmicenje.Instance.UcitajListuTakmicenja(dgvTakmicenja);
        }

        private void btnDetaljniji_Click(object sender, EventArgs e)
        {
            if (dgvTakmicenja.SelectedCells != null && dgvTakmicenja.SelectedCells.Count == 1)
            {
                int brojReda = dgvTakmicenja.SelectedCells[0].RowIndex;
                try
                {
                    KKITakmicenje.Instance.PrikaziPodatkeTakmicenja(brojReda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmTakmicenje frmTakmicenje = new FrmTakmicenje();
                frmTakmicenje.ShowDialog();
            }
            else if (dgvTakmicenja.SelectedCells != null && dgvTakmicenja.SelectedCells.Count > 1)
            {
                bool flag = true; //da li je izabrao razlicite
                int brojReda = dgvTakmicenja.SelectedCells[0].RowIndex;
                foreach (DataGridViewCell cell in dgvTakmicenja.SelectedCells)
                {
                    if (brojReda != cell.RowIndex)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    try
                    {
                        KKITakmicenje.Instance.PrikaziPodatkeTakmicenja(brojReda);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    FrmTakmicenje frmTakmicenje = new FrmTakmicenje();
                    frmTakmicenje.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Morate izabrati tacno jedan red!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati tacno jedan red!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            KKITakmicenje.Instance.UcitajListuTakmicenja(dgvTakmicenja);
        }

        private void plivaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlivaci frmPlivaci = new FrmPlivaci();
            frmPlivaci.ShowDialog();
        }
    }
}
