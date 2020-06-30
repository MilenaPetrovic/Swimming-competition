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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Komunikacija.Instance.PoveziSe())
                    throw new Exception("Neuspesno povezivanje na server.");

                string poruka = KKIGlavna.Instance.Login(txtUsername.Text, txtPassword.Text);
                MessageBox.Show(poruka, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmGlavna frmGlavna = new FrmGlavna();
                frmGlavna.ShowDialog();

                Dispose();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
