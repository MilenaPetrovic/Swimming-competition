using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //slanje kontroleru

            a = (Admin)Kontroler.Kontroler.Instance.Login(a);

            if (a != null)
            {
                Sesija.Instance.Admin = a;
                return "Dobrodosli " + a.Ime + " " + a.Prezime + "!";
            }
            else return "Username ili password nisu ispravni!";

        }

    }
}
