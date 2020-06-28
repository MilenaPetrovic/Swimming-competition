using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Sistemske_operacije
{
    public class Login : OpstaSO
    {
        public Admin Admin { get; private set; }
        
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            List<IDomenskiObjekat> admini = broker.Pronadji((Admin)objekat);

            if (admini.Count == 0)
            {
                throw new Exception("Nije pronadjen admin!");
            }

            if (admini.Count > 1)
            {
                throw new Exception("Nadjeno je vise admina sa istim podacima!");
            }

            Admin = admini[0] as Admin;
        }
    }
}
