using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki;

namespace KKI
{
    public class KKITakmicenje
    {
        private static KKITakmicenje _instance;

        private List<Mesto> mesta;
        public List<Mesto> Mesta { get => mesta; set => mesta = value; }
        public List<Takmicenje> Takmicenja { get; private set; }
        public Takmicenje Takmicenje { get; set; }
        public BindingList<Plivac> PrijavljeniPlivaci { get; set; }

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
            PrijavljeniPlivaci = new BindingList<Plivac>();
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
                                    
            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.KreirajTakmicenje, t);
            return odg.Poruka;
            
        }

        public void IzaberiPlivace(DataGridView dgvI, List<DataGridViewRow> redovi)
        {
            foreach (DataGridViewRow red in redovi)
            {
                Plivac p = new Plivac
                {
                    PlivacID = (int)red.Cells[0].Value,
                    ImePlivaca = (string)red.Cells[1].Value,
                    PrezimePlivaca = (string)red.Cells[2].Value,
                    DatumRodjenja = (DateTime)red.Cells[3].Value,
                    Kategorija = red.Cells[4].Value as Kategorija,
                    Pol = (string)red.Cells[5].Value
                };

                if (dgvI.Name.Equals("dgvSvi"))
                {
                    DodajPlivaca(p);                    
                }
                else
                {
                    UkloniPlivaca(p);
                }
            }
        }

        private void DodajPlivaca(Plivac p)
        {
            List<Plivac> dodavanje = new List<Plivac>();
            foreach (Plivac pl in PrijavljeniPlivaci)
            {
                dodavanje.Add(pl);
            }

            foreach (Plivac pl in dodavanje)
                if (pl.PlivacID == p.PlivacID)
                    return;
            //igrac dodat, prikazati poruku?
                
            PrijavljeniPlivaci.Add(p);                
        }

        public string EvidencijaRezultata()
        {
            if (Kontroler.Kontroler.Instance.EvidencijaRezultata(Takmicenje))
            {
                return "Uspesno evidentirani rezultati!";
            }
            else
            {
                return "Neuspesna evidencija rezultata!";
            }
        }

        public string SacuvajNovePrijave()
        {
            List<Prijava> novePrijave = new List<Prijava>();
            bool postoji = false;

            foreach (Plivac plivac in PrijavljeniPlivaci)
            {
                foreach (Prijava prijava in Takmicenje.Prijave)
                {
                    if (prijava.Plivac.PlivacID == plivac.PlivacID)
                    {
                        novePrijave.Add(prijava);
                        postoji = true;
                        continue;
                    }
                }
                if (!postoji)
                {
                    Prijava p = new Prijava
                    {
                        Takmicenje = Takmicenje,
                        Plivac = plivac,
                        DatumPrijave = DateTime.Now,
                        Pozicija = 0,
                        OstvarenoVreme = 0
                    };
                    novePrijave.Add(p);
                }
                postoji = false;
            }

            Takmicenje.Prijave = novePrijave;
            Takmicenje.BrojPrijava = Takmicenje.Prijave.Count();
            
            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.SacuvajNovePrijave, Takmicenje);
            return odg.Poruka;            
        }

        public void Pretraga(string text, DataGridView dgvTakmicenja)
        {
            Takmicenje t = new Takmicenje();
            t.UpitPretrage = $"SELECT t.takmicenjeID, t.nazivTakmicenja, t.datumOdrzavanja, t.brojPrijava, t.mestoOdrzavanja from Takmicenje t join Mesto m on t.mestoOdrzavanja = m.ptt WHERE nazivTakmicenja LIKE '%{text}%' OR datumOdrzavanja LIKE '%{text}%' OR brojPrijava LIKE '%{text}%' OR m.nazivMesta LIKE '%{text}%'";

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.Pretraga, t);
            List<IDomenskiObjekat> rez = (odg.Objekat as List<IDomenskiObjekat>).Cast<IDomenskiObjekat>().ToList();

            PostaviListu(rez, dgvTakmicenja);
        }

        private void UkloniPlivaca(Plivac p)
        {
            List<Plivac> uklanjanje = new List<Plivac>();
            foreach (Plivac pl in PrijavljeniPlivaci)
            {
                uklanjanje.Add(pl);
            }

            foreach (Plivac plivac in uklanjanje)
            {
                if (p.PlivacID == plivac.PlivacID)
                    PrijavljeniPlivaci.Remove(plivac);
            }
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

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.Izmeni, t);
            return odg.Poruka;
        }

        public string ObrisiTakmicenje()
        {
            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.Obrisi, Takmicenje);
            return odg.Poruka;
        }

        public void UcitajPrijave(DataGridView dgvPrijavljeni)
        {
            Prijava p = new Prijava();
            p.Takmicenje = Takmicenje;

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.UcitajListuPrijava, p);            
            List<IDomenskiObjekat> rez = (odg.Objekat as List<IDomenskiObjekat>).Cast<IDomenskiObjekat>().ToList();

            //if (rez == null) return null;

            List<Prijava> listaPrijava = new List<Prijava>();
            for (int i = 0; i < rez.Count(); i++)
            {
                listaPrijava.Add((Prijava)rez[i]);
            }

            Takmicenje.Prijave = listaPrijava;
            dgvPrijavljeni.DataSource = Takmicenje.Prijave;

            PrijavljeniPlivaci.Clear();
            foreach (Prijava pl in Takmicenje.Prijave)
            {
                PrijavljeniPlivaci.Add(pl.Plivac);
            }
        }

        public void PrikaziPodatkeTakmicenja(int brojReda)
        {
            Takmicenje = Takmicenja[brojReda];
        }

        public void UcitajListuTakmicenja(DataGridView dgvTakmicenja)
        {
            Takmicenje t = new Takmicenje();
            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.UcitajListuTakmicenja, t);
            List<IDomenskiObjekat> rez = (odg.Objekat as List<IDomenskiObjekat>).Cast<IDomenskiObjekat>().ToList();

            //if (rez == null) return null;

            PostaviListu(rez, dgvTakmicenja);
        }

        private void PostaviListu(List<IDomenskiObjekat> rez, DataGridView dgvTakmicenja)
        {
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

            Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.VratiListu, m);
            List<IDomenskiObjekat> rez = (odg.Objekat as List<IDomenskiObjekat>).Cast<IDomenskiObjekat>().ToList();

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
