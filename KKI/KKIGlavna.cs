using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki;

namespace KKI
{
    public class KKIGlavna
    {

        private static KKIGlavna _instance;
        public static KKIGlavna Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KKIGlavna();
                return _instance;
            }
        }

        private KKIGlavna()
        {

        }

        public string Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Unesite username i password!");
            }

            Admin a = new Admin();
            a.Username = username;
            a.Password = password;


            // slanje
            try
            {
                Odgovor odg = Komunikacija.Instance.KreirajZahtev(Operacija.Login, a);

                a = (Admin)odg.Objekat;

                if (a != null)
                {
                    Sesija.Instance.Prijava(a);
                    return "Uspesno ste se prijavili na sistem!";
                }
                else return "Neuspesno prijavljivanje na sistem!";
            }
            catch (Exception exc)
            {
                throw exc;
            }    
        }
    }
}
