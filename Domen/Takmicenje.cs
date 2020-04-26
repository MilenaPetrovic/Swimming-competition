using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Takmicenje : IDomenskiObjekat
    {
        int takmicenjeID;
        DateTime datumOdrzavanja;
        Mesto mestoOdrzavanja;
        int brojPrijava;

        public int TakmicenjeID { get => takmicenjeID; set => takmicenjeID = value; }
        public DateTime DatumOdrzavanja { get => datumOdrzavanja; set => datumOdrzavanja = value; }
        public Mesto MestoOdrzavanja { get => mestoOdrzavanja; set => mestoOdrzavanja = value; }
        public int BrojPrijava { get => brojPrijava; set => brojPrijava = value; }

        public string NazivTabele => "Takmicenje";

        public string UslovPretrage => "";

        public string VrednostiZaInsert => $"{TakmicenjeID}, '{DatumOdrzavanja}', {BrojPrijava}, '{MestoOdrzavanja.Ptt}'";

        public string VrednostiZaUpdate => "";

        public string PrimarniKljuc => "takmicenjeID";

        public void PostaviPrimarniKljuc(int id)
        {
            TakmicenjeID = id;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        //List<Plivac> plivaci; da li?
    }
}
