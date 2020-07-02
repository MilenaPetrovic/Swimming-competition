using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Zajednicki;

namespace Server
{
    class Obrada
    {
        private Socket klijentskiSoket;
        private NetworkStream tok;
        private BinaryFormatter formatter = new BinaryFormatter();

        public Obrada(Socket ks)
        {
            this.klijentskiSoket = ks;
            tok = new NetworkStream(klijentskiSoket);
        }

        public void Zaustavi()
        {
            klijentskiSoket.Close();
        }

        internal void ObradaZahteva()
        {
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev = formatter.Deserialize(tok) as Zahtev;
                    Odgovor odgovor = KreirajOdgovor(zahtev);
                    formatter.Serialize(tok, odgovor);
                }
                catch
                {
                    kraj = true;
                }
            }
        }

        private Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            switch (zahtev.Operacija)
            {
                case Operacija.EvidencijaRezultata: return EvidencijaRezultata(zahtev.Objekat);
                case Operacija.Izmeni: return Izmeni(zahtev.Objekat);
                case Operacija.KreirajPlivaca: return KreirajPlivaca(zahtev.Objekat);
                case Operacija.KreirajTakmicenje: return KreirajTakmicenje(zahtev.Objekat);
                case Operacija.Login: return Login(zahtev.Objekat);
                case Operacija.Obrisi: return Obrisi(zahtev.Objekat);
                case Operacija.Pretraga: return Pretraga(zahtev.Objekat);
                case Operacija.SacuvajNovePrijave: return SacuvajNovePrijave(zahtev.Objekat);
                case Operacija.UcitajListuPlivaca: return UcitajListuPlivaca(zahtev.Objekat);
                case Operacija.UcitajListuPrijava: return UcitajListuPrijava(zahtev.Objekat);
                case Operacija.UcitajListuTakmicenja: return UcitajListuTakmicenja(zahtev.Objekat);
                case Operacija.VratiListu: return VratiListu(zahtev.Objekat);
                default:
                    Odgovor o = new Odgovor();
                    o.Poruka = "Nepostojeca operacija zahteva!";
                    o.Status = false;
                    return o;
            }
        }

        private Odgovor VratiListu(object objekat)
        {
            Odgovor odg = new Odgovor();
            try
            {
                if (!(objekat is IDomenskiObjekat))
                    throw new ArgumentException("Prosledjeni objekat nije tipa IDO.");

                List<IDomenskiObjekat> lista = Kontroler.Kontroler.Instance.VratiListu(objekat as IDomenskiObjekat);
                odg.Objekat = lista;
                odg.Status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                odg.Poruka = "Sistem ne moze da pronadje trazene objekte!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor UcitajListuTakmicenja(object objekat)
        {
            Odgovor odg = new Odgovor();
            try
            {
                List<IDomenskiObjekat> lista = Kontroler.Kontroler.Instance.UcitajListuTakmicenja(objekat as IDomenskiObjekat);
                odg.Objekat = lista;
                odg.Status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                odg.Poruka = "Sistem ne moze da pronadje takmicenja!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor UcitajListuPrijava(object objekat)
        {
            Odgovor odg = new Odgovor();
            try
            {
                List<IDomenskiObjekat> lista = Kontroler.Kontroler.Instance.UcitajListuPrijava(objekat as IDomenskiObjekat);
                odg.Objekat = lista;
                odg.Status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                odg.Poruka = "Sistem ne moze da pronadje plivace!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor UcitajListuPlivaca(object objekat)
        {
            Odgovor odg = new Odgovor();
            try
            {
                List<IDomenskiObjekat> lista = Kontroler.Kontroler.Instance.UcitajListuPlivaca(objekat as IDomenskiObjekat);
                odg.Objekat = lista;
                odg.Status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                odg.Poruka = "Sistem ne moze da pronadje plivace!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor SacuvajNovePrijave(object objekat)
        {
            Odgovor odg = new Odgovor();
            if (objekat is IDomenskiObjekat &&
                Kontroler.Kontroler.Instance.SacuvajNovePrijave(objekat as IDomenskiObjekat))
            {
                odg.Poruka = "Prijave su uspesno sacuvane!";
                odg.Status = true;
            }
            else
            {
                odg.Poruka = "Sistem ne može da zapamti prijave!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor Pretraga(object objekat)
        {
            Odgovor odg = new Odgovor();
            try
            {
                if (!(objekat is IDomenskiObjekat))
                    throw new ArgumentException("Prosledjeni objekat nije tipa IDO.");

                List<IDomenskiObjekat> lista = Kontroler.Kontroler.Instance.Pretraga(objekat as IDomenskiObjekat);
                odg.Objekat = lista;
                odg.Status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                odg.Poruka = "Sistem ne moze da pronadje trazene objekte!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor Obrisi(object objekat)
        {
            Odgovor odg = new Odgovor();
            if (objekat is IDomenskiObjekat &&
                Kontroler.Kontroler.Instance.Obrisi(objekat as IDomenskiObjekat))
            {
                odg.Poruka = "Brisanje objekta je uspesno!";
                odg.Status = true;
            }
            else
            {
                odg.Poruka = "Sistem ne može da obrise objekat!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor Login(object objekat)
        {
            Odgovor odg = new Odgovor();
            if (objekat is IDomenskiObjekat)
            {
                IDomenskiObjekat ido = Kontroler.Kontroler.Instance.Login(objekat as IDomenskiObjekat);
                if (ido != null)
                {
                    odg.Poruka = "Uspešno ste se prijavili na sistem!";
                    odg.Status = true;
                    odg.Objekat = ido;
                    return odg;
                }
            }

            odg.Poruka = "Neuspešno prijavljivanje na sistem!";
            odg.Status = false;
            return odg;
        }

        private Odgovor KreirajTakmicenje(object objekat)
        {
            Odgovor odg = new Odgovor();
            if (objekat is IDomenskiObjekat &&
                Kontroler.Kontroler.Instance.KreirajTakmicenje(objekat as IDomenskiObjekat))
            {
                odg.Poruka = "Takmicenje je uspešno kreirano!";
                odg.Status = true;
            }
            else
            {
                odg.Poruka = "Sistem ne može da kreira takmicenje!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor KreirajPlivaca(object objekat)
        {
            Odgovor odg = new Odgovor();
            if (objekat is IDomenskiObjekat &&
                Kontroler.Kontroler.Instance.KreirajPlivaca(objekat as IDomenskiObjekat))
            {
                odg.Poruka = "Plivac je uspešno kreiran!";
                odg.Status = true;
            }
            else
            {
                odg.Poruka = "Sistem ne može da kreira plivaca!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor Izmeni(object objekat)
        {
            Odgovor odg = new Odgovor();
            if (objekat is IDomenskiObjekat &&
                Kontroler.Kontroler.Instance.Izmeni(objekat as IDomenskiObjekat))
            {
                odg.Poruka = "Sistem je zapamtio objekat!";
                odg.Status = true;
            }
            else
            {
                odg.Poruka = "Sistem ne može da zapamti objekat!";
                odg.Status = false;
            }
            return odg;
        }

        private Odgovor EvidencijaRezultata(object objekat)
        {
            Odgovor odg = new Odgovor();
            if (objekat is IDomenskiObjekat &&
                Kontroler.Kontroler.Instance.EvidencijaRezultata(objekat as IDomenskiObjekat))
            {
                odg.Poruka = "Uspesno sacuvani rezultati!";
                odg.Status = true;
            }
            else
            {
                odg.Poruka = "Sistem ne moze da sacuva rezultate!";
                odg.Status = false;
            }
            return odg;
        }
    }
}
