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
    class MessageDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;

        public static void SendNewMessage(Message message)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO poruka (sadrzaj, datum, strijelac_osoba_id, meteorolog_osoba_id) " +
                "VALUES (@content, @date, @operatorID, @meteorologistID)";
            cmd.Parameters.AddWithValue("@content", message.Content);
            cmd.Parameters.AddWithValue("@date", message.Date);
            cmd.Parameters.AddWithValue("@operatorID", message.OperatorID);
            cmd.Parameters.AddWithValue("@meteorologistID", message.MeteorologistID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static Message GetMessageContent(int msgID)
        {
            Message msg = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM poruka WHERE poruka_id=@msgID";
            cmd.Parameters.AddWithValue("@msgID", msgID);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            msg = new Message()
            { 
                Content = reader.GetString(1)
            };

            conn.Close();
            return msg;
        }

        public static List<Message> GetMessages(int meteorologistID) 
        {
            List<Message> messages = new List<Message>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM poruke_view WHERE meteorolog_osoba_id=@meteorologistID";
            cmd.Parameters.AddWithValue("@meteorologistID", meteorologistID);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Message msg = new Message()
                {
                    MessageID = reader.GetInt32(0),
                    Content = reader.GetString(1),
                    Date = reader.GetDateTime(2),
                    Operator = new User()
                    {
                      UserID = reader.GetInt32(3),
                      FirstName = reader.GetString(4),
                      LastName = reader.GetString(5),
                      Username = reader.GetString(6)
                    },
                    Meteorologist = new User()
                    {
                        UserID = reader.GetInt32(7),
                        FirstName = reader.GetString(8),
                        LastName = reader.GetString(9),
                        Username = reader.GetString(10)
                    }
                };

                messages.Add(msg);
            }

            reader.Close();
            conn.Close();
            return messages;
        }
    }
}
