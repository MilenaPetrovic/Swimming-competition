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
        List<Plivac> sviPlivaci = KKI.KKIPlivac.Instance.Plivaci;

        public FrmPrijava()
        {
            InitializeComponent();

            if(sviPlivaci == null)
            {
                KKI.KKIPlivac.Instance.UcitajListuPlivaca(dgvSvi);
                sviPlivaci = KKI.KKIPlivac.Instance.Plivaci;
            }

            PopuniFormu();

            dgvSvi.DataSource = sviPlivaci;           

        }

        private void PopuniFormu()
        {
            //prilikom dodavanja proveriti da li vec postoji u prijavljenim
        }
    }
}
