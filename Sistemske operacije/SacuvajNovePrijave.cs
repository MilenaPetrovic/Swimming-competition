using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Sistemske_operacije
{
    public class SacuvajNovePrijave : OpstaSO
    {
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            Takmicenje takmicenje = objekat as Takmicenje;

            Prijava prijava = new Prijava();
            prijava.Takmicenje = new Takmicenje();
            prijava.Takmicenje.TakmicenjeID = takmicenje.TakmicenjeID;
            broker.Obrisi(prijava);

            foreach (Prijava p in takmicenje.Prijave)
            {
                broker.Kreiraj(p);
            }

            broker.Izmeni(takmicenje);
        }
    }
}
