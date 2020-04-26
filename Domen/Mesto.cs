using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Mesto : IDomenskiObjekat
    {
        int ptt;
        string nazivMesta;

        public int Ptt { get => ptt; set => ptt = value; }
        public string NazivMesta { get => nazivMesta; set => nazivMesta = value; }

        public string NazivTabele => "Mesto";

        public string UslovPretrage => throw new NotImplementedException();

        public string VrednostiZaInsert => throw new NotImplementedException();

        public string VrednostiZaUpdate => throw new NotImplementedException();

        public string PrimarniKljuc => "ptt";

        public void PostaviPrimarniKljuc(int id)
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> mesta = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Mesto m = new Mesto
                {
                    Ptt = (int)reader["ptt"],
                    NazivMesta = (string)reader["nazivMesta"]
                };
                mesta.Add(m);
            }
            return mesta;
        }
    }
}
