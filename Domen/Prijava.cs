using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Prijava : IDomenskiObjekat
    {
        private Takmicenje takmicenje;
        private Plivac plivac;
        private DateTime datumPrijave;
        private int pozicija;
        private double ostvarenoVreme;

        public Takmicenje Takmicenje { get => takmicenje; set => takmicenje = value; }
        public Plivac Plivac { get => plivac; set => plivac = value; }
        [DisplayName("Ime plivaca")]
        public string Ime
        {
            get => Plivac.ImePlivaca;
        }
        [DisplayName("Prezime plivaca")]
        public string Prezime
        {
            get => Plivac.PrezimePlivaca;
        }
        [DisplayName("Datum prijave")]
        public DateTime DatumPrijave { get => datumPrijave; set => datumPrijave = value; }
        [DisplayName("Pozicija")]
        public int Pozicija { get => pozicija; set => pozicija = value; }
        [DisplayName("Ostvareno vreme")]
        public double OstvarenoVreme { get => ostvarenoVreme; set => ostvarenoVreme = value; }

        [Browsable(false)]
        public string NazivTabele => "Prijava";

        [Browsable(false)]
        public string UslovPretrage
        {
            get
            {
                if (Takmicenje != null && Plivac == null)
                {
                    return $"takmicenjeID = {Takmicenje.TakmicenjeID}";
                }
                //else if (Takmicenje.TakmicenjeID == 0 && Plivac != null)
                //{
                //    return $"plivacID = '{Plivac.PlivacID}'";
                //}
                else
                {
                    return $"takmicenjeID = {Takmicenje.TakmicenjeID} AND plivacID = '{Plivac.PlivacID}'";
                }
            }
        }
        [Browsable(false)]
        public string VrednostiZaInsert => throw new NotImplementedException();
        [Browsable(false)]
        public string VrednostiZaUpdate => throw new NotImplementedException();
        [Browsable(false)]
        public string PrimarniKljuc => throw new NotImplementedException();


        public void PostaviPrimarniKljuc(int id)
        {
            throw new NotImplementedException();
        }

        public void PostaviVrednost(IDomenskiObjekat ido)
        {
            if (!(ido is Prijava))
                return;

            Prijava p = ido as Prijava;

            Plivac.PlivacID = p.Plivac.PlivacID;
            Takmicenje.TakmicenjeID = p.Takmicenje.TakmicenjeID;
            DatumPrijave = p.DatumPrijave;
            Pozicija = p.Pozicija;
            OstvarenoVreme = p.OstvarenoVreme;
        }

        public void PostaviVrednostPodDomena(IDomenskiObjekat ido)
        {
            if (ido is Plivac)
            {
                Plivac = (Plivac)ido;
            }

            if (ido is Takmicenje)
            {
                Takmicenje = (Takmicenje)ido;
            }
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (reader.Read())
            {


                Prijava p = new Prijava
                {
                    Plivac = new Plivac
                    {
                        PlivacID = (int)reader["plivacID"]
                    },
                    Takmicenje = new Takmicenje
                    {
                        TakmicenjeID = (int)reader["takmicenjeID"]
                    },
                    DatumPrijave = (DateTime)reader["datumPrijave"],
                    Pozicija = (int)reader["pozicija"],
                    OstvarenoVreme = (double)reader["ostvarenoVreme"]
                };

                lista.Add(p);
            }

            return lista;
        }

        public IDomenskiObjekat VratiPodDomen()
        {
            if (Plivac != null && Plivac.ImePlivaca == null)
            {
                return Plivac as IDomenskiObjekat;
            }

            if (Takmicenje != null && Takmicenje.NazivTakmicenja == null)
            {
                return Takmicenje as IDomenskiObjekat;
            }

            return null;
        }
    }
}
