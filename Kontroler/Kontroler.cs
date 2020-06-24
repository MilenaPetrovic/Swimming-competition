﻿using System;
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

        public List<IDomenskiObjekat> UcitajListuPrijava(Prijava p)
        {
            IDomenskiObjekat ido = p;
            OpstaSO oso = new UcitajListuPrijava();

            try
            {
                oso.IzvrsiSO(ido);
                List<IDomenskiObjekat> lista = ((UcitajListuPrijava)oso).lista;
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public List<IDomenskiObjekat> UcitajListuTakmicenja()
        {
            IDomenskiObjekat ido = new Takmicenje();
            OpstaSO oso = new UcitajListuTakmicenja();

            try
            {
                oso.IzvrsiSO(ido);
                List<IDomenskiObjekat> lista = ((UcitajListuTakmicenja)oso).lista;
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public bool Obrisi(IDomenskiObjekat objekat)
        {
            OpstaSO oso = new Obrisi();
            try
            {
                oso.IzvrsiSO(objekat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

            return true;
        }

        public List<IDomenskiObjekat> UcitajListuPlivaca()
        {
            IDomenskiObjekat ido = new Plivac();
            OpstaSO oso = new UcitajListuPlivaca();

            try
            {
                oso.IzvrsiSO(ido);
                List<IDomenskiObjekat> lista = ((UcitajListuPlivaca)oso).lista;
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        public bool Izmeni(IDomenskiObjekat objekat)
        {
            OpstaSO oso = new Izmeni();
            try
            {
                oso.IzvrsiSO(objekat);
            }
            catch
            {
                return false;
            }

            if (((Izmeni)oso).Uspeh)
            {
                return true;
            }
            return false;
        }
    }
}
