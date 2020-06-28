using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Sistemske_operacije
{
    public class EvidencijaRezultata : OpstaSO
    {
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            Takmicenje takmicenje = objekat as Takmicenje;

            Prijava prijava = new Prijava();
            prijava.Takmicenje = new Takmicenje();
            
            foreach (Prijava p in takmicenje.Prijave)
            {
                broker.Izmeni(p);
            }
        }
    }
}
