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
        int plivacID;
        string imePlivaca;
        string prezimePlivaca;
        DateTime datumRodjenja;
        Kategorija kategorija;
        string pol;

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
        public string UslovPretrage => "";

        [Browsable(false)]
        public string VrednostiZaInsert => $"{PlivacID},'{ImePlivaca}', '{PrezimePlivaca}', '{DatumRodjenja}', {Kategorija.KategorijaID}, '{Pol}'";

        [Browsable(false)]
        public string VrednostiZaUpdate => "";

        [Browsable(false)]
        public string PrimarniKljuc => "plivacID";

        public void PostaviPrimarniKljuc(int id)
        {
            PlivacID = id;
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
    }
}
