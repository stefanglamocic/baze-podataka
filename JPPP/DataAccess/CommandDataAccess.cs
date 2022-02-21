using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPPP.Model;
using MySql.Data.MySqlClient;

namespace JPPP.DataAccess
{
    class CommandDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;

        public static void NewCommand(Command command) 
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO naredba (meteorolog_osoba_id, strijelac_osoba_id, datum, azimut, " +
                "elevacija) VALUES (@meteorologistID, @operatorID, @date, @azimuth, @elevation)";
            cmd.Parameters.AddWithValue("@meteorologistID", command.Meteorologist.UserID);
            cmd.Parameters.AddWithValue("@operatorID", command.Operator.UserID);
            cmd.Parameters.AddWithValue("@date", command.Date);
            cmd.Parameters.AddWithValue("@azimuth", command.Azimuth);
            cmd.Parameters.AddWithValue("@elevation", command.Elevation);

            conn.Open();
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT MAX(naredba_id) FROM naredba";
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int commandID = reader.GetInt32(0);
            reader.Close();

            cmd.CommandText = "INSERT INTO naredba_ima_rakete (naredba_id, rakete_id, kolicina) " +
                "VALUES (@cmdID, @rocketsID, @quantity)";
            foreach (Rockets r in command.Rockets) 
            {
                cmd.Parameters.AddWithValue("@cmdID", commandID);
                cmd.Parameters.AddWithValue("@rocketsID", r.RocketID);
                cmd.Parameters.AddWithValue("@quantity", r.Quantity);
                

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            

            conn.Close();
        }

        public static List<Command> GetCommands(int operatorID)
        {
            List<Command> commands = new List<Command>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM komande_view WHERE strijelac_osoba_id=@operatorID";
            cmd.Parameters.AddWithValue("@operatorID", operatorID);

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Command command = new Command()
                {
                    CommandID = reader.GetInt32(0),
                    Date = reader.GetDateTime(1),
                    Meteorologist = new User()
                    {
                        UserID = reader.GetInt32(4),
                        FirstName = reader.GetString(5),
                        LastName = reader.GetString(6),
                        Username = reader.GetString(7)
                    }
                };

                commands.Add(command);
            }

            reader.Close();
            conn.Close();
            return commands;
        }

        public static Command GetCommand(int commandID)
        {
            Command command = new Command()
            { 
                Rockets = new List<Rockets>()
            };
            
            
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM strijelac_naredba_view WHERE naredba_id=@commandID";
            cmd.Parameters.AddWithValue("@commandID", commandID);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                command.Azimuth = reader.GetInt32(1);
                command.Elevation = reader.GetInt32(2);
                command.Rockets.Add(new Rockets() 
                { 
                    RocketID = reader.GetInt32(3),
                    Type = reader.GetString(4),
                    Quantity = reader.GetInt32(5)
                });
                command.Operator = new User()
                {
                    UserID = reader.GetInt32(6)
                };
                command.Meteorologist = new User()
                {
                    UserID = reader.GetInt32(7)
                };
            }

            reader.Close();
            conn.Close();
            return command;
        }

        public static void CommandDone(int commandID)
        {
            List<RocketsInStation> rockets = new List<RocketsInStation>();

            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM naredba_stanica_view WHERE naredba_id=@commandID";
            cmd.Parameters.AddWithValue("@commandID", commandID);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                rockets.Add(new RocketsInStation()
                { 
                    RocketID = reader.GetInt32(1),
                    Quantity = reader.GetInt32(2),
                    StationID = reader.GetInt32(3)
                });
            }
            reader.Close();
            cmd.Parameters.Clear();
            
            foreach (RocketsInStation r in rockets)
                Console.WriteLine(r.RocketID + " " + r.Quantity + " " + r.StationID);

            cmd.CommandText = "UPDATE stanica_ima_rakete SET kolicina=kolicina - @quantity WHERE " +
                "stanica_id=@stationID AND rakete_id=@rocketsID";
            foreach(RocketsInStation r in rockets)
            {
                cmd.Parameters.AddWithValue("@quantity", r.Quantity);
                cmd.Parameters.AddWithValue("@stationID", r.StationID);
                cmd.Parameters.AddWithValue("@rocketsID", r.RocketID);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            cmd.CommandText = "DELETE FROM naredba WHERE naredba_id=@commandID";
            cmd.Parameters.AddWithValue("@commandID", commandID);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
