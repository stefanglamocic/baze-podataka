using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using JPPP.Model;
using MySql.Data.MySqlClient;

namespace JPPP.DataAccess
{
    class UserDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;

        public static List<User> GetUsers() 
        {
            List<User> users = new List<User>();

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM osoba";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                users.Add(new User()
                {
                    UserID = reader.GetInt32(0),
                    JMB = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Username = reader.GetString(4),
                    Password = reader.GetString(5)
                }) ;
            }

            reader.Close();
            conn.Close();
            return users;
        }
    }
}
