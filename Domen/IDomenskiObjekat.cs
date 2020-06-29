using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IDomenskiObjekat
    {
        string NazivTabele { get; }
        string UslovPretrage { get; }
        string VrednostiZaInsert { get; }
        string VrednostiZaUpdate { get; }
        string PrimarniKljuc { get; }
        string Pretraga { get; }

        List<IDomenskiObjekat> VratiListu(SqlDataReader reader);
        void PostaviPrimarniKljuc(int id);

        IDomenskiObjekat VratiPodDomen();
        void PostaviVrednost(IDomenskiObjekat ido);
        void PostaviVrednostPodDomena(IDomenskiObjekat ido);
    }
}
