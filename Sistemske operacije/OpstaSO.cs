using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemske_operacije
{
    public abstract class OpstaSO
    {
        protected Broker.Broker broker = new Broker.Broker();

        public void IzvrsiSO(IDomenskiObjekat objekat)
        {
            try
            {
                broker.OtvoriKonekciju();
                broker.ZapocniTransakciju();

                //Validacija(objekat);
                IzvrsiOperaciju(objekat);

                broker.Commit(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                broker.Rollback();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

        protected abstract void Validacija(IDomenskiObjekat objekat);
        protected abstract void IzvrsiOperaciju(IDomenskiObjekat objekat);
    }
}
