using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKI
{
    public class Sesija
    {
        private Admin admin;
        private static Sesija _instance;
        public static Sesija Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Sesija();
                }

                return _instance;
            }
        }

        private Sesija()
        {

        }

        public Admin Admin { get => admin; set => admin = value; }
        
        public void OdjaviAdmina()
        {
            Admin = null;
        }

        public string VratiImeAdmina()
        {
            return $"{Admin.Ime} {Admin.Prezime}";
        }

        public void Odjava()
        {
            admin = null;
        }

        public void Prijava(Admin a)
        {
            admin = a;
        }
    }
}
