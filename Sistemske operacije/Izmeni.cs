using Domen;
using Sistemske_operacije;
using System;

namespace Kontroler
{
    public class Izmeni : OpstaSO
    {
        public Plivac Plivac { get; private set; }
        public Takmicenje Takmicenje { get; private set; }
        public bool Uspeh { get; private set; }
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {

            int brojRedova = broker.Izmeni(objekat);
            if(brojRedova == 1)
            {
                if(objekat is Plivac)
                    Plivac = objekat as Plivac;
                if (objekat is Takmicenje)
                    Takmicenje = objekat as Takmicenje;

                Uspeh = true;
            }
            else
            {
                throw new System.Exception("Sistem ne moze da zapamti novi objekat");
            }
        }
    }
}