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
        public Takmicenje Takmicenje { get; set; }


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

        public string IzmeniTakmicenje(string nazivTakmicenja, string brojPrijavljenih, string datumOdrzavanja, string mesto)
        {
            if (string.IsNullOrEmpty(nazivTakmicenja) || string.IsNullOrEmpty(nazivTakmicenja))
                throw new Exception("Unesite sve podatke!");

            if (string.IsNullOrEmpty(mesto) || string.IsNullOrEmpty(mesto))
                throw new Exception("Unesite sve podatke!");

            if (!DateTime.TryParseExact(datumOdrzavanja, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
                throw new Exception("Neispravno unet datum!");

            Mesto m = new Mesto();
            for (int i = 0; i < Mesta.Count; i++)
            {
                if (Mesta[i].NazivMesta == mesto)
                    m = Mesta[i];
            }

            Takmicenje t = new Takmicenje
            {
                TakmicenjeID = Takmicenje.TakmicenjeID,
                NazivTakmicenja = nazivTakmicenja,
                DatumOdrzavanja = datum,
                MestoOdrzavanja = m
            };

            if (Kontroler.Kontroler.Instance.Izmeni(t))
                return "Uspesno izmenjeno takmicenje!";
            else return "Neuspesna izmena takmicenja!";
        }

        public string ObrisiTakmicenje()
        {
            if (Kontroler.Kontroler.Instance.Obrisi(Takmicenje))
                return "Uspesno je obrisano takmicenje!";
            else return "Nije uspelo brisanje takmicenja!";
        }

        public void UcitajPrijave(DataGridView dgvPrijavljeni)
        {
            Prijava p = new Prijava();
            p.Takmicenje = Takmicenje;

            List<IDomenskiObjekat> rez = Kontroler.Kontroler.Instance.UcitajListuPrijava(p);

            //if (rez == null) return null;

            List<Prijava> listaPrijava = new List<Prijava>();
            for (int i = 0; i < rez.Count(); i++)
            {
                listaPrijava.Add((Prijava)rez[i]);
            }

            Takmicenje.Prijave = listaPrijava;

            dgvPrijavljeni.DataSource = Takmicenje.Prijave;
        }

        public void PrikaziPodatkeTakmicenja(int brojReda)
        {
            Takmicenje = Takmicenja[brojReda];
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
