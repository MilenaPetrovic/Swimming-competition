using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Sistemske_operacije
{
    public class VratiListu : OpstaSO
    {
        public List<IDomenskiObjekat> lista;

        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            lista = broker.VratiListu(objekat);
        }       
    }
}
