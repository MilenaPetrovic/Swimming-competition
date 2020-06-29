using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Takmicenje : IDomenskiObjekat
    {
        private int takmicenjeID;
        private string nazivTakmicenja;
        private DateTime datumOdrzavanja;
        private Mesto mestoOdrzavanja;
        private int brojPrijava;
        private List<Prijava> prijave;

        [Browsable(false)]
        private string upitPretrage;
        

        public int TakmicenjeID { get => takmicenjeID; set => takmicenjeID = value; }
        [DisplayName("Naziv takmicenja")]
        public string NazivTakmicenja { get => nazivTakmicenja; set => nazivTakmicenja = value; }
        [DisplayName("Datum odrzavanja")]
        public DateTime DatumOdrzavanja { get => datumOdrzavanja; set => datumOdrzavanja = value; }
        [DisplayName("Mesto odrzavanja")]
        public Mesto MestoOdrzavanja { get => mestoOdrzavanja; set => mestoOdrzavanja = value; }
        [DisplayName("Broj prijava")]
        public int BrojPrijava { get => brojPrijava; set => brojPrijava = value; }
        [Browsable(false)]
        public List<Prijava> Prijave { get => prijave; set => prijave = value; }

        public Takmicenje()
        {
            Prijave = new List<Prijava>();
        }

        [Browsable(false)]
        public string NazivTabele => "Takmicenje";

        [Browsable(false)]
        public string UslovPretrage => $"takmicenjeID = {TakmicenjeID}";

        [Browsable(false)]
        public string VrednostiZaInsert => $"{TakmicenjeID}, '{NazivTakmicenja}', '{DatumOdrzavanja}', {BrojPrijava}, '{MestoOdrzavanja.Ptt}'";

        [Browsable(false)]
        public string VrednostiZaUpdate => $"takmicenjeID = {TakmicenjeID}, nazivTakmicenja = '{NazivTakmicenja}', datumOdrzavanja = '{DatumOdrzavanja}', brojPrijava = {BrojPrijava}, mestoOdrzavanja = '{MestoOdrzavanja.Ptt}'";

        [Browsable(false)]
        public string PrimarniKljuc => "takmicenjeID";

        [Browsable(false)]
        public string Pretraga => UpitPretrage;

        [Browsable(false)]
        public string UpitPretrage { get => upitPretrage; set => upitPretrage = value; }

        public void PostaviPrimarniKljuc(int id)
        {
            TakmicenjeID = id;
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Takmicenje))
                return;

            Takmicenje t = (Takmicenje)ido;

            TakmicenjeID = t.TakmicenjeID;
            NazivTakmicenja = t.NazivTakmicenja;
            DatumOdrzavanja = t.DatumOdrzavanja;
            BrojPrijava = t.BrojPrijava;
            MestoOdrzavanja = t.MestoOdrzavanja;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            if(ido is Mesto)
            {
                MestoOdrzavanja = (Mesto)ido;
            }
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> takmicenja = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Takmicenje t = new Takmicenje
                {
                    TakmicenjeID = (int)reader["takmicenjeID"],
                    NazivTakmicenja = (string)reader["nazivTakmicenja"],
                    DatumOdrzavanja = (DateTime)reader["datumOdrzavanja"],
                    BrojPrijava = (int)reader["brojPrijava"],
                    MestoOdrzavanja = new Mesto()
                    {
                        Ptt = (int)reader["mestoOdrzavanja"]
                    }
                };
                takmicenja.Add(t);
            }
            return takmicenja;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            if (MestoOdrzavanja != null && MestoOdrzavanja.NazivMesta == null)
            {
                return MestoOdrzavanja as IDomenskiObjekat;
            }

            return null;
        }
    }
}
