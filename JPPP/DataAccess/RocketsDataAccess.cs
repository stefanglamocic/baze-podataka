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
    class RocketsDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;

        public static List<Rockets> GetRockets()
        {
            List<Rockets> rockets = new List<Rockets>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM rakete";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Rockets r = new Rockets()
                {
                    RocketID = reader.GetInt32(0),
                    Type = reader.GetString(1)
                };

                rockets.Add(r);
            }

            reader.Close();
            conn.Close();
            return rockets;
        }
    }
}
