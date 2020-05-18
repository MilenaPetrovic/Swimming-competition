using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Broker
{
    public class Broker
    {
        private SqlConnection konekcija;
        private SqlTransaction transakcija;

        public Broker()
        {
            konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlivackaTakmicenja;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        public void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        public void ZatvoriKonekciju()
        {
            konekcija.Close();
        }

        public void ZapocniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
        }

        public void Commit()
        {
            transakcija.Commit();
        }

        public void Rollback()
        {
            transakcija.Rollback();
        }

        public List<IDomenskiObjekat> Pronadji(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"SELECT * FROM {objekat.NazivTabele} WHERE {objekat.UslovPretrage}";
            SqlDataReader reader = command.ExecuteReader();
            List<IDomenskiObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }
        public List<IDomenskiObjekat> VratiListu(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"SELECT * FROM {objekat.NazivTabele}";
            SqlDataReader reader = command.ExecuteReader();
            List<IDomenskiObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        } 

        public int Kreiraj(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"INSERT INTO {objekat.NazivTabele} VALUES ({objekat.VrednostiZaInsert})";
            return command.ExecuteNonQuery();
        }

        public object VratiNajveciID(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"SELECT MAX({objekat.PrimarniKljuc}) FROM " +
                $"{objekat.NazivTabele}";
            object rez = command.ExecuteScalar();
            return rez;
        }

        public int Obrisi(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"DELETE FROM {objekat.NazivTabele} WHERE" +
                $" {objekat.UslovPretrage}";
            return command.ExecuteNonQuery();
        }

        public int Izmeni(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", konekcija, transakcija);
            command.CommandText = $"UPDATE {objekat.NazivTabele} SET {objekat.VrednostiZaUpdate} " +
                $"WHERE {objekat.UslovPretrage}";
            return command.ExecuteNonQuery();            
        }

    }
}
