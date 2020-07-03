using Domen;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki;

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
                {
                    k = Stilovi[i];
                }
            }

            Plivac p = new Plivac
            {
                ImePlivaca = ime,
                PrezimePlivaca = prezime,
                Kategorija = k,
                Pol = pol,
                DatumRodjenja = datum
            };

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.KreirajPlivaca, p);
            return odg.Poruka;
        }

        public string ObrisiPlivaca()
        {
            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.Obrisi, Plivac);
            return odg.Poruka;
        }

        public void UcitajListuPlivaca(DataGridView dgvPlivaciPretraga)
        {
            Plivac t = new Plivac();
            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.UcitajListuPlivaca, t);
            List<IDomenskiObjekat> rez = (odg.Objekat as List<IDomenskiObjekat>).Cast<IDomenskiObjekat>().ToList();

            //if (rez == null) return null;

            PostaviListu(rez, dgvPlivaciPretraga);            
        }

        private void PostaviListu(List<IDomenskiObjekat> rez, DataGridView dgvPlivaciPretraga)
        {
            List<Plivac> listaPlivaca = new List<Plivac>();
            for (int i = 0; i < rez.Count(); i++)
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
                {
                    k = Stilovi[i];
                }
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

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.Izmeni, p);
            return odg.Poruka;
        }

        public string Pretraga(string text, DataGridView dgvPlivaciPretraga)
        {
            Plivac p = new Plivac();
            p.UpitPretrage = $"SELECT p.plivacID, p.imePlivaca, p.prezimePlivaca, p.datumRodjenja, p.pol, p.kategorijaID from Plivac p join Kategorija k on p.kategorijaID = k.kategorijaID WHERE imePlivaca LIKE '%{text}%' OR prezimePlivaca LIKE '%{text}%' OR p.pol LIKE '%{text}%' OR k.imeKategorije LIKE '%{text}%'";

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.Pretraga, p);
            List<IDomenskiObjekat> rez = (odg.Objekat as List<IDomenskiObjekat>).Cast<IDomenskiObjekat>().ToList();

            PostaviListu(rez, dgvPlivaciPretraga);

            if(rez.Count > 0)
            {
                return "Sistem je nasao plivace po zadatoj vrednosti!";
            }
            else
            {
                return "Sistem ne moze da nadje plivace po zadatoj vrednosti!";
            }
            
        }

        public string PrikaziPodatkePlivaca(int brojReda)
        {
            Plivac = Plivaci[brojReda];
            if (Plivac != null)
            {
                return "Sistem je nasao izabranog plivaca!";
            }
            else
            {            
                return "Sistem ne moze da nadje plivaca!";
            }
        }

        public List<string> UcitajListuStilova()
        {
            Kategorija k = new Kategorija();

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.VratiListu, k);
            List<IDomenskiObjekat> rez = (odg.Objekat as List<IDomenskiObjekat>).Cast<IDomenskiObjekat>().ToList();

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
