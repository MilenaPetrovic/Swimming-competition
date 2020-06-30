using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Kategorija : IDomenskiObjekat
    {
        private int kategorijaID;
        private string imeKategorije;

        public int KategorijaID { get => kategorijaID; set => kategorijaID = value; }
        public string ImeKategorije { get => imeKategorije; set => imeKategorije = value; }

        public string NazivTabele => "Kategorija";

        public string UslovPretrage => $"kategorijaID = {KategorijaID}";

        public string VrednostiZaInsert => throw new NotImplementedException();

        public string VrednostiZaUpdate => throw new NotImplementedException();

        public string PrimarniKljuc => "kategorijaID";

        public string Pretraga => throw new NotImplementedException();

        public override string ToString()
        {
            return ImeKategorije;
            //return "jes";
        }

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

        public IDomenskiObjekat VratiPodDomen()
        {
            return null;
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Kategorija))
            {
                return;
            }

            Kategorija k = (Kategorija)ido;

            KategorijaID = k.KategorijaID;
            ImeKategorije = k.ImeKategorije;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            return;
        }
    }
}
