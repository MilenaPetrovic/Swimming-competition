﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Sistemske_operacije
{
    public class Obrisi : OpstaSO
    {
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            broker.Obrisi(objekat);
        }       
    }
}
