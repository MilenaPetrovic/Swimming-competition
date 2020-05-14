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

            PopuniFormu();

            dgvPlivaciPretraga.Columns[0].Visible = false;
            dgvPlivaciPretraga.Columns[1].Width = 80;
            dgvPlivaciPretraga.Columns[2].Width = 100;
            dgvPlivaciPretraga.Columns[3].Width = 100;
            dgvPlivaciPretraga.Columns[5].Width = 50;
        }

        private void PopuniFormu()
        {
            UcitajPlivace();
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
            }
        }
    }
}
