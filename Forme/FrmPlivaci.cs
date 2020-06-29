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
    public partial class FrmPlivaci : Form
    {        
        public FrmPlivaci()
        {
            InitializeComponent();

            UcitajPlivace();

            //sad nesto nece
            dgvPlivaciPretraga.Columns[0].Visible = false;
            dgvPlivaciPretraga.Columns[1].Width = 80;
            dgvPlivaciPretraga.Columns[2].Width = 100;
            dgvPlivaciPretraga.Columns[3].Width = 100;
            dgvPlivaciPretraga.Columns[5].Width = 50;
        }

        private void UcitajPlivace()
        {
            try
            {
                KKIPlivac.Instance.UcitajListuPlivaca(dgvPlivaciPretraga);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetaljniji_Click(object sender, EventArgs e)
        {
            if(dgvPlivaciPretraga.SelectedCells != null && dgvPlivaciPretraga.SelectedCells.Count == 1)
            {
                int brojReda = dgvPlivaciPretraga.SelectedCells[0].RowIndex;
                try
                {
                    KKIPlivac.Instance.PrikaziPodatkePlivaca(brojReda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmPlivac frmPlivac = new FrmPlivac();
                frmPlivac.ShowDialog();
            }
            else if (dgvPlivaciPretraga.SelectedCells != null && dgvPlivaciPretraga.SelectedCells.Count > 1)
            {
                bool flag = true; //da li je izabrao razlicite
                int brojReda = dgvPlivaciPretraga.SelectedCells[0].RowIndex;
                foreach (DataGridViewCell cell in dgvPlivaciPretraga.SelectedCells)
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
                        KKIPlivac.Instance.PrikaziPodatkePlivaca(brojReda);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    FrmPlivac frmPlivac = new FrmPlivac();
                    frmPlivac.ShowDialog();
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

            KKIPlivac.Instance.UcitajListuPlivaca(dgvPlivaciPretraga);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmUnosPlivaca frmUnosPlivaca = new FrmUnosPlivaca();
            frmUnosPlivaca.ShowDialog();

            KKIPlivac.Instance.UcitajListuPlivaca(dgvPlivaciPretraga);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            KKI.KKIPlivac.Instance.Pretraga(txtPretraga.Text, dgvPlivaciPretraga);
        }
    }
}
