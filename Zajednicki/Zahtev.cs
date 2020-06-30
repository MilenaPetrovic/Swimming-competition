using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki
{
    public enum Operacija
    {
        EvidencijaRezultata,
        Izmeni,
        KreirajPlivaca,
        KreirajTakmicenje,
        Login,
        Obrisi,
        Pretraga,
        SacuvajNovePrijave,
        UcitajListuPlivaca,
        UcitajListuPrijava,
        UcitajListuTakmicenja,
        VratiListu
    }

    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }

        public Zahtev()
        {

        }

        public Zahtev(Operacija operacija, object objekat)
        {
            Operacija = operacija;
            Objekat = objekat;
        }

    }
}
