using Domen;
using Sistemske_operacije;
using System;

namespace Kontroler
{
    public class IzmeniPlivaca : OpstaSO
    {
        public Plivac Plivac { get; private set; }
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {

            int brojRedova = broker.Izmeni(objekat);
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