using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broker;
using Domen;
using Sistemske_operacije;

namespace Kontroler
{
    public class Kontroler
    {       
        private static Kontroler _instance;
        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Kontroler();
                }

                return _instance;
            }
        }

        private Kontroler()
        {
        }

        //Prijava admina
        public IDomenskiObjekat Login(IDomenskiObjekat objekat)
        {
            OpstaSO oso = new Login();

            try
            {
                oso.IzvrsiSO(objekat);
                return ((Login)oso).Admin;
            }
            catch
            {
                return null;
            }
        }

        public bool KreirajPlivaca(IDomenskiObjekat objekat)
        {
            OpstaSO oso = new KreirajPlivaca();
            try
            {
                oso.IzvrsiSO(objekat);
            }
            catch
            {
                return false;
            }

            if(((KreirajPlivaca)oso).Plivac != null)
            {
                return true;
            }
            return false;
        }

        public bool KreirajTakmicenje(IDomenskiObjekat objekat)
        {
            OpstaSO oso = new KreirajTakmicenje();
            try
            {
                oso.IzvrsiSO(objekat);
            }
            catch
            {
                return false;
            }

            if (((KreirajTakmicenje)oso).Takmicenje != null)
            {
                return true;
            }
            return false;
        }

        public List<IDomenskiObjekat> VratiListu(IDomenskiObjekat objekat)
        {
            OpstaSO oso = new VratiListu();
            try
            {
                oso.IzvrsiSO(objekat);
                List<IDomenskiObjekat> lista = ((VratiListu)oso).lista;
                return lista;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
