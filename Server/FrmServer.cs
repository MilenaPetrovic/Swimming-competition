using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();

            txtStatus.Text = "Server je ugasen.";
            txtStatus.Enabled = false;
            btnZaustavi.Enabled = false;
            btnPokreni.Focus();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            if (Server.Instance.PokreniServer())
            {
                txtStatus.Text = "Server je pokrenut i radi...";
                btnZaustavi.Enabled = true;
                btnPokreni.Enabled = false;
                btnZaustavi.Focus();
            }
            else
            {
                MessageBox.Show("Sistem nije uspeo da pokrene server!");
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.Instance.ZaustaviServer())
            {
                txtStatus.Text = "Server je ugasen.";
                btnZaustavi.Enabled = false;
                btnPokreni.Enabled = true;
                btnPokreni.Focus();
            }
            else
            {
                MessageBox.Show("Sistem nije uspeo da ugasi server!");
            }
        }
    }
}
