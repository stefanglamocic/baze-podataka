using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPPP.Model;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace JPPP.DataAccess
{
    class CommandDoneDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;

        public static void AddCommandDone(CommandDone done)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();

            cmd.CommandText = "INSERT INTO izvrsavanje_naredbe (naredba_id, rakete_id, kolicina, datum, napomena) " +
                "VALUES (@cmdID, @rocketsID, @quantity, @date, @note)";
            foreach(Rockets r in done.Rockets)
            {
                cmd.Parameters.AddWithValue("@cmdID", done.CommandID);
                cmd.Parameters.AddWithValue("@rocketsID", r.RocketID);
                cmd.Parameters.AddWithValue("@quantity", r.Quantity);
                cmd.Parameters.AddWithValue("@date", done.Date);
                cmd.Parameters.AddWithValue("@note", done.Text);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            conn.Close();
        }
    }
}
