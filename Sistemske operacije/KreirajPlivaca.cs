using Domen;
using Sistemske_operacije;
using System;

namespace Kontroler
{
    public class KreirajPlivaca : OpstaSO
    {
        public Plivac Plivac { get; private set; }
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {

            object rezultat = broker.VratiNajveciID(objekat);
            if(rezultat is DBNull)
            {
                throw new Exception($"{objekat.NazivTabele} ne postoji!");
            }

            int noviID = (int)rezultat + 1;

            objekat.PostaviPrimarniKljuc(noviID);
            int brojRedova = broker.Kreiraj(objekat);
            if(brojRedova == 1)
            {
                Plivac = objekat as Plivac;
            }
            else
            {
                Plivac = null;
                throw new System.Exception("Sistem ne moze da zapamti novog plivaca");
            }
        }

        protected override void Validacija(IDomenskiObjekat objekat)
        {
            throw new System.NotImplementedException();
        }
    }
}