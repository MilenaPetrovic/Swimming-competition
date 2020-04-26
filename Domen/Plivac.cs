using System;
using System.Collections.Generic;
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
        char pol;

        public int PlivacID { get => plivacID; set => plivacID = value; }
        public string ImePlivaca { get => imePlivaca; set => imePlivaca = value; }
        public string PrezimePlivaca { get => prezimePlivaca; set => prezimePlivaca = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public Kategorija Kategorija { get => kategorija; set => kategorija = value; }
        public char Pol { get => pol; set => pol = value; }

        public string NazivTabele => "Plivac";

        public string UslovPretrage => "";

        public string VrednostiZaInsert => $"{PlivacID},'{ImePlivaca}', '{PrezimePlivaca}', '{DatumRodjenja}', {Kategorija.KategorijaID}, '{Pol}'";

        public string VrednostiZaUpdate => "";

        public string PrimarniKljuc => "plivacID";

        public void PostaviPrimarniKljuc(int id)
        {
            PlivacID = id;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
