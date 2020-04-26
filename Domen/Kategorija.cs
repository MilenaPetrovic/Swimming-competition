using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Kategorija : IDomenskiObjekat
    {
        int kategorijaID;
        string imeKategorije;

        public int KategorijaID { get => kategorijaID; set => kategorijaID = value; }
        public string ImeKategorije { get => imeKategorije; set => imeKategorije = value; }

        public string NazivTabele => "Kategorija";

        public string UslovPretrage => throw new NotImplementedException();

        public string VrednostiZaInsert => throw new NotImplementedException();

        public string VrednostiZaUpdate => throw new NotImplementedException();

        public string PrimarniKljuc => "kategorijaID";

        public void PostaviPrimarniKljuc(int id)
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> stilovi = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Kategorija k = new Kategorija
                {
                    KategorijaID = (int)reader["kategorijaID"],
                    ImeKategorije = (string)reader["imeKategorije"]
                };
                stilovi.Add(k);
            }
            return stilovi;
        }
    }
}
