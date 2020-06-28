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

                IzvrsiOperaciju(objekat);

                broker.Commit(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                broker.Rollback();
                throw new Exception("Zabranjeno brisanje!");
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

        protected abstract void IzvrsiOperaciju(IDomenskiObjekat objekat);
    }
}
