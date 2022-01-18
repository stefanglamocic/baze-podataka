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
            if(reader.GetValue(3) != null)
            {

            }
            return new Station()
            {
                StationID = reader.GetInt32(0),
                Municipality = reader.GetString(1),
                Place = reader.GetString(2)
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

        public static void AddStation(Station station)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("insert_station", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@opstina", station.Municipality);
            cmd.Parameters.AddWithValue("@mjesto", station.Place);
            if(station.Operator != null)
                cmd.Parameters.AddWithValue("@osoba_id", station.Operator.UserID);
            else
                cmd.Parameters.AddWithValue("@osoba_id", null);
        }
    }
}
