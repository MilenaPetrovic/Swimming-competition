using Domen;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKI
{
    public class KKITakmicenje
    {
        private static KKITakmicenje _instance;

        private List<Mesto> mesta;
        public List<Mesto> Mesta { get => mesta; set => mesta = value; }
        public List<Takmicenje> Takmicenja { get; private set; }

        public static KKITakmicenje Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KKITakmicenje();
                return _instance;
            }
        }


        private KKITakmicenje()
        {

        }

        public string KreirajTakmicenje(string naziv, string mesto, string datumOdrzavanja)
        {
            if (string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(naziv))
                throw new Exception("Unesite sve podatke!");

            if (string.IsNullOrEmpty(mesto) || string.IsNullOrEmpty(mesto))
                throw new Exception("Unesite sve podatke!");

            if (!DateTime.TryParseExact(datumOdrzavanja, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
                throw new Exception("Neispravno unet datum!");

            Mesto m = new Mesto();
            for (int i = 0; i < mesta.Count; i++)
            {
                if (mesta[i].NazivMesta == mesto)
                    m = mesta[i];
            }

            Takmicenje t = new Takmicenje
            {
                NazivTakmicenja = naziv,
                MestoOdrzavanja = m,
                BrojPrijava = 0,
                DatumOdrzavanja = datum
            };

            if (Kontroler.Kontroler.Instance.KreirajTakmicenje(t))
                return "Uspesno dodato takmicenje!";
            else return "Neuspesno dodavanje takmicenja!";
        }

        public void UcitajListuTakmicenja(DataGridView dgvTakmicenja)
        {
            List<IDomenskiObjekat> rez = Kontroler.Kontroler.Instance.UcitajListuTakmicenja();

            //if (rez == null) return null;

            List<Takmicenje> listaTakmicenja = new List<Takmicenje>();
            for (int i = 0; i < rez.Count(); i++)
            {
                listaTakmicenja.Add((Takmicenje)rez[i]);
            }

            Takmicenja = listaTakmicenja;

            dgvTakmicenja.DataSource = Takmicenja;
        }

        public List<string> UcitajListuMesta()
        {
            Mesto m = new Mesto();

            List<IDomenskiObjekat> rez = Kontroler.Kontroler.Instance.VratiListu(m);
            if (rez == null) return null;

            List<Mesto> listaMesta = new List<Mesto>();
            List<string> imenaMesta = new List<string>();
            for (int i = 0; i < rez.Count(); i++)
            {
                listaMesta.Add((Mesto)rez[i]);
                imenaMesta.Add(listaMesta[i].NazivMesta);
            }

            Mesta = listaMesta;

            return imenaMesta;
        }
    }
}
