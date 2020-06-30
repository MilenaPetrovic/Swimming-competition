using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Mesto : IDomenskiObjekat
    {
        private int ptt;
        private string nazivMesta;

        public int Ptt { get => ptt; set => ptt = value; }
        public string NazivMesta { get => nazivMesta; set => nazivMesta = value; }

        public string NazivTabele => "Mesto";

        public string UslovPretrage => $"ptt = {Ptt}";

        public string VrednostiZaInsert => throw new NotImplementedException();

        public string VrednostiZaUpdate => throw new NotImplementedException();

        public string PrimarniKljuc => "ptt";

        public string Pretraga => throw new NotImplementedException();

        public override string ToString()
        {
            return NazivMesta;
        }

        public void PostaviPrimarniKljuc(int id)
        {
            throw new NotImplementedException();
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Mesto))
                return;

            Mesto m = (Mesto)ido;

            Ptt = m.Ptt;
            NazivMesta = m.nazivMesta;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            return;
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

        public IDomenskiObjekat VratiPodDomen()
        {
            return null;
        }
    }
}
