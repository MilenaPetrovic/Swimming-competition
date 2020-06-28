using Domen;
using Sistemske_operacije;
using System;

namespace Kontroler
{
    public class KreirajTakmicenje : OpstaSO
    {
        public Takmicenje Takmicenje { get; private set; }

        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            object rezultat = broker.VratiNajveciID(objekat);
            if (rezultat is DBNull)
            {
                throw new Exception($"{objekat.NazivTabele} ne postoji!");
            }

            int noviID = (int)rezultat + 1;

            objekat.PostaviPrimarniKljuc(noviID);
            int brojRedova = broker.Kreiraj(objekat);
            if (brojRedova == 1)
            {
                Takmicenje = objekat as Takmicenje;
            }
            else
            {
                Takmicenje = null;
                throw new System.Exception("Sistem ne moze da zapamti novog plivaca");
            }
        }
    }
}