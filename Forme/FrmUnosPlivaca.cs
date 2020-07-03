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

                string poruka = KKI.KKIPlivac.Instance.KreirajPlivaca(txtIme.Text, txtPrezime.Text, cmbStil.SelectedItem.ToString(), pol, datum.Text);

                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("instance"))
                    MessageBox.Show("Neispravno unet naziv kategorije!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
