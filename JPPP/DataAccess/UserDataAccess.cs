﻿using System;
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

            while (reader.Read())
            {
                users.Add(new User()
                {
                    UserID = reader.GetInt32(0),
                    JMB = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Username = reader.GetString(4),
                    Password = reader.GetString(5),
                });
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
    }
}
