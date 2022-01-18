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

        private static User GetUserFromReader(MySqlDataReader reader, string userType) 
        {
            return new User()
            {
                UserID = reader.GetInt32(0),
                JMB = reader.GetString(1),
                FirstName = reader.GetString(2),
                LastName = reader.GetString(3),
                Username = reader.GetString(4),
                Password = reader.GetString(5),
                UserType = userType
            };
        }

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

        public static User GetUser(string username)
        {
            User user = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM osoba o" +
                $" JOIN administrativni_radnik a ON o.osoba_id = a.osoba_id" +
                $" WHERE o.korisnicko_ime = '{username}'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                user = GetUserFromReader(reader, "ar");
            else 
            {
                reader.Close();
                cmd.CommandText = $"SELECT * FROM osoba o" +
                $" JOIN meteorolog a ON o.osoba_id = a.osoba_id" +
                $" WHERE o.korisnicko_ime = '{username}'";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    user = GetUserFromReader(reader, "m");
                else
                {
                    reader.Close();
                    cmd.CommandText = $"SELECT * FROM osoba o" +
                    $" JOIN strijelac a ON o.osoba_id = a.osoba_id" +
                    $" WHERE o.korisnicko_ime = '{username}'";
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                        user = GetUserFromReader(reader, "s");
                }
            }

            reader.Close();
            conn.Close();
            return user;
        }

        private static List<User> GetUserGroup(string fromTable) 
        {
            List<User> users = new List<User>();

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM osoba o JOIN {fromTable} a ON o.osoba_id = a.osoba_id";
            MySqlDataReader reader = cmd.ExecuteReader();

            switch (fromTable)
            {
                case "administrativni_radnik":
                    while (reader.Read())
                        users.Add(GetUserFromReader(reader, "ar"));
                    break;
                case "strijelac":
                    while (reader.Read())
                        users.Add(GetUserFromReader(reader, "s"));
                    break;
                case "meteorolog":
                    while (reader.Read())
                        users.Add(GetUserFromReader(reader, "m"));
                    break;
            }

            reader.Close();
            conn.Close();
            return users;
        }

        public static List<User> GetAdminWorkers()
        {
            return GetUserGroup("administrativni_radnik");
        }

        public static List<User> GetMeteorologists()
        {
            return GetUserGroup("meteorolog");
        }

        public static List<User> GetOperators()
        {
            return GetUserGroup("strijelac");
        }

        public static void AddUser(User user)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("insert_user", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@type", user.UserType);
            cmd.Parameters.AddWithValue("@JMB", user.JMB);
            cmd.Parameters.AddWithValue("@ime", user.FirstName);
            cmd.Parameters.AddWithValue("@prezime", user.LastName);
            cmd.Parameters.AddWithValue("@korisnicko_ime", user.Username);
            cmd.Parameters.AddWithValue("@lozinka", user.Password);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteUser(int userID)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM osoba WHERE osoba_id=@userID";
            cmd.Parameters.AddWithValue("userID", userID);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
        }

        public static void UpdateUser(int userID, User user, bool changePassword)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();
            string tempCmd = "UPDATE osoba SET JMB=@JMB, ime=@firstName, prezime=@lastName, " +
                "korisnicko_ime=@username";

            if (changePassword)
            {
                tempCmd += ", lozinka=@password";
                cmd.Parameters.AddWithValue("@password", user.Password);
            }
            
            tempCmd += " WHERE osoba.osoba_id=@userID";
            cmd.CommandText = tempCmd;

            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@JMB", user.JMB);
            cmd.Parameters.AddWithValue("@firstName", user.FirstName);
            cmd.Parameters.AddWithValue("@lastName", user.LastName);
            cmd.Parameters.AddWithValue("@username", user.Username);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
