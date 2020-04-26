
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Admin : IDomenskiObjekat
    {
        int adminID;
        string username;
        string password;
        string ime;
        string prezime;

        public int AdminID { get => adminID; set => adminID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public string NazivTabele => "Admin";

        public string UslovPretrage => $"username='{username}' AND password='{password}'";

        public string VrednostiZaInsert => throw new NotImplementedException();

        public string VrednostiZaUpdate => throw new NotImplementedException();

        public string PrimarniKljuc => throw new NotImplementedException();

        public void PostaviPrimarniKljuc(int id)
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IDomenskiObjekat> admini = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                Admin a = new Admin
                { 
                    AdminID = (int)reader["adminID"],
                    Username = (string)reader["username"],
                    Password = (string)reader["password"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"]
                };
                admini.Add(a);
            }
            return admini;
        }
    }
}
