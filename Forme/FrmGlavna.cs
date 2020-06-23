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
    }
}
