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
    class StationDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;

        private static Station GetStationFromReader(MySqlDataReader reader) 
        {
            return new Station()
            {
                StationID = reader.GetInt32(0),
                Municipality = reader.GetString(1),
                Place = reader.GetString(2),
                RegisteredOperatorID = reader.GetInt32(3)
            };
        }

        public static List<Station> GetStations()
        {
            List<Station> stations = new List<Station>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stanica";
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
                stations.Add(GetStationFromReader(reader));
            reader.Close();
            conn.Close();

            return stations;
        }
    }
}
