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
    class OperatorDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;
        public static List<Operator> GetOperators()
        {
            List<Operator> operators = new List<Operator>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM strijelac_stanica_view";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Operator newOperator = new Operator()
                {
                    UserID = reader.GetInt32(0),
                    JMB = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Username = reader.GetString(4),
                    Password = reader.GetString(5),
                };

                if (reader["stanica_id"] != DBNull.Value)
                    newOperator.StationID = reader.GetInt32(6);

                operators.Add(newOperator);
            }

            reader.Close();
            conn.Close();
            return operators;
        }
    }
}
