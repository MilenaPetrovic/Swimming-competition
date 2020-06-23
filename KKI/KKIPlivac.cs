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
    public class KKIPlivac
    {
        public List<Kategorija> Stilovi { get; private set; }
        public List<Plivac> Plivaci { get; private set; }
        public Plivac Plivac { get; set; }
        
        private static KKIPlivac _instance;
        public static KKIPlivac Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KKIPlivac();
                return _instance;
            }
        }


        private KKIPlivac()
        {

        }

        public string KreirajPlivaca(string ime, string prezime, string stil, string pol, string datumRodjenja)
        {
            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime))
                throw new Exception("Unesite sve podatke!");

            if (string.IsNullOrEmpty(stil) || string.IsNullOrEmpty(stil))
                throw new Exception("Unesite sve podatke!");

            if (pol[0] != 'M' && pol[0] != 'Z')
                throw new Exception("Nije odabran pol!");

            if (!DateTime.TryParseExact(datumRodjenja, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
                throw new Exception("Neispravno unet datum!");

            Kategorija k = new Kategorija();
            for (int i = 0; i < Stilovi.Count; i++)
            {
                if (Stilovi[i].ImeKategorije == stil)
                    k = Stilovi[i];
            }

            Plivac p = new Plivac
            {
                ImePlivaca = ime,
                PrezimePlivaca = prezime,
                Kategorija = k,
                Pol = pol,
                DatumRodjenja = datum
            };

            if (Kontroler.Kontroler.Instance.KreirajPlivaca(p))
                return "Uspesno dodat plivac!";
            else return "Neuspesno dodavanje plivaca!";
        }

        public string ObrisiPlivaca()
        {
            if (Kontroler.Kontroler.Instance.Obrisi(Plivac))
                return "Uspesno je obrisan plivac!";
            else return "Nije uspelo brisanje plivaca!";
        }

        public void UcitajListuPlivaca(DataGridView dgvPlivaciPretraga)
        {
            List<IDomenskiObjekat> rez = Kontroler.Kontroler.Instance.UcitajListuPlivaca();
            
            //if (rez == null) return null;

            List<Plivac> listaPlivaca = new List<Plivac>();
            for(int i=0; i<rez.Count(); i++)
            {
                listaPlivaca.Add((Plivac)rez[i]);
            }

            Plivaci = listaPlivaca;

            dgvPlivaciPretraga.DataSource = Plivaci;
        }

        public string IzmeniPlivaca(string ime, string prezime, string stil, string pol, string datumRodjenja)
        {
            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime))
                throw new Exception("Unesite sve podatke!");

            if (string.IsNullOrEmpty(stil) || string.IsNullOrEmpty(stil))
                throw new Exception("Unesite sve podatke!");

            if (pol[0] != 'M' && pol[0] != 'Z')
                throw new Exception("Nije odabran pol!");

            if (!DateTime.TryParseExact(datumRodjenja, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
                throw new Exception("Neispravno unet datum!");

            Kategorija k = new Kategorija();
            for (int i = 0; i < Stilovi.Count; i++)
            {
                if (Stilovi[i].ImeKategorije == stil)
                    k = Stilovi[i];
            }

            Plivac p = new Plivac
            {
                PlivacID = Plivac.PlivacID,
                ImePlivaca = ime,
                PrezimePlivaca = prezime,
                Kategorija = k,
                Pol = pol,
                DatumRodjenja = datum
            };

            if (Kontroler.Kontroler.Instance.Izmeni(p))
                return "Uspesno izmenjen plivac!";
            else return "Neuspesna izmena plivaca!";
        }

        public void PrikaziPodatkePlivaca(int brojReda)
        {
            Plivac = Plivaci[brojReda];
        }

        public List<string> UcitajListuStilova()
        {
            Kategorija k = new Kategorija();
            List<IDomenskiObjekat> rez = Kontroler.Kontroler.Instance.VratiListu(k);
            if (rez == null) return null;

            List<Kategorija> listaStilova = new List<Kategorija>();
            List<string> imenaStilova = new List<string>();
            for (int i = 0; i < rez.Count(); i++)
            {
                listaStilova.Add((Kategorija)rez[i]);
                imenaStilova.Add(listaStilova[i].ImeKategorije);
            }

            Stilovi = listaStilova;

            return imenaStilova;
        }
    }
}
