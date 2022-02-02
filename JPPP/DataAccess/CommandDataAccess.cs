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
    }
}
