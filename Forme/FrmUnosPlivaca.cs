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
    public partial class FrmUnosPlivaca : Form
    {
        public FrmUnosPlivaca()
        {
            InitializeComponent();
            PopuniFormu();
        }

        private void PopuniFormu()
        {  
            List<string> stilovi = KKI.KKIPlivac.Instance.UcitajListuStilova();
            cmbStil.DataSource = stilovi;

            datum.CustomFormat = "dd-MM-yyyy";
            datum.Format = DateTimePickerFormat.Custom;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string pol;
                if (rbM.Checked)
                {
                    pol = "M";
                }
                else
                {
                    pol = "Z";
                }

                string poruka = KKI.KKIPlivac.Instance.KreirajPlivaca(txtIme.Text, txtPrezime.Text, cmbStil.SelectedItem.ToString(), pol, datum.Text);

                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
