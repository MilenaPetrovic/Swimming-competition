using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Prijava : IDomenskiObjekat
    {
        DateTime datumPrijave;
        Plivac plivac;
        Takmicenje takmicenje;

        public DateTime DatumPrijave { get => datumPrijave; set => datumPrijave = value; }
        public Plivac Plivac { get => plivac; set => plivac = value; }
        public Takmicenje TakmicenjeID { get => takmicenje; set => takmicenje = value; }

        public string NazivTabele => throw new NotImplementedException();

        public string UslovPretrage => throw new NotImplementedException();

        public string VrednostiZaInsert => throw new NotImplementedException();

        public string VrednostiZaUpdate => throw new NotImplementedException();

        public string PrimarniKljuc => throw new NotImplementedException();

        public Takmicenje Takmicenje { get => takmicenje; set => takmicenje = value; }

        public void PostaviPrimarniKljuc(int id)
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
