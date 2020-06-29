using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Plivac : IDomenskiObjekat
    {
        private int plivacID;
        private string imePlivaca;
        private string prezimePlivaca;
        private DateTime datumRodjenja;
        private Kategorija kategorija;
        private string pol;

        [Browsable(false)]
        private string upitPretrage;

        public int PlivacID { get => plivacID; set => plivacID = value; }
        [DisplayName("Ime plivaca")]
        public string ImePlivaca { get => imePlivaca; set => imePlivaca = value; }
        [DisplayName("Prezime plivaca")]
        public string PrezimePlivaca { get => prezimePlivaca; set => prezimePlivaca = value; }
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        [DisplayName("Stil plivanja")]
        public Kategorija Kategorija { get => kategorija; set => kategorija = value; }
        public string Pol { get => pol; set => pol = value; }

        [Browsable(false)]
        public string NazivTabele => "Plivac";

        [Browsable(false)]
        public string VrednostiZaInsert => $"{PlivacID},'{ImePlivaca}', '{PrezimePlivaca}', '{DatumRodjenja}', {Kategorija.KategorijaID}, '{Pol}'";

        [Browsable(false)]
        public string VrednostiZaUpdate => $"plivacID = {PlivacID}, imePlivaca = '{ImePlivaca}', prezimePlivaca = '{PrezimePlivaca}', datumRodjenja = '{DatumRodjenja}', kategorijaID = {Kategorija.KategorijaID}, pol = '{Pol}'";

        [Browsable(false)]
        public string PrimarniKljuc => "plivacID";

        [Browsable(false)]
        public string UslovPretrage => $"plivacID = {PlivacID}";

        [Browsable(false)]
        public string UpitPretrage { get => upitPretrage; set => upitPretrage = value; }

        [Browsable(false)]
        public string Pretraga => UpitPretrage;

        public void PostaviPrimarniKljuc(int id)
        {
            PlivacID = id;
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Plivac))
                return;

            Plivac p = (Plivac)ido;

            PlivacID = p.PlivacID;
            ImePlivaca = p.ImePlivaca;
            PrezimePlivaca = p.PrezimePlivaca;
            DatumRodjenja = p.DatumRodjenja;
            Kategorija = p.Kategorija;
            Pol = p.Pol;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            if(ido is Kategorija)
            {
                Kategorija = (Kategorija)ido;
            }
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> plivaci = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Plivac p = new Plivac
                {
                    PlivacID = (int)reader["plivacID"],
                    ImePlivaca = (string)reader["imePlivaca"],
                    PrezimePlivaca = (string)reader["prezimePlivaca"],
                    DatumRodjenja = (DateTime)reader["datumRodjenja"],
                    Kategorija = new Kategorija()
                    {
                        KategorijaID = (int)reader["kategorijaID"]
                    },
                    Pol = (string)reader["pol"]
                };
                plivaci.Add(p);
            }
            return plivaci;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            if(Kategorija != null && Kategorija.ImeKategorije == null)
            {
                return Kategorija as IDomenskiObjekat;
            }

            return null;
        }
    }
}
