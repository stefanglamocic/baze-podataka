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
            Station station = new Station()
            {
                StationID = reader.GetInt32(0),
                Municipality = reader.GetString(1),
                Place = reader.GetString(2)
            };

            if (reader["osoba_id"] != DBNull.Value)
            {
                station.Operator = new User()
                {
                    UserID = reader.GetInt32(3),
                    JMB = reader.GetString(4),
                    FirstName = reader.GetString(5),
                    LastName = reader.GetString(6),
                    Username = reader.GetString(7)
                };
            }
            return station;
        }

        public static List<Station> GetStations()
        {
            List<Station> stations = new List<Station>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stanica_strijelac_view";
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
                stations.Add(GetStationFromReader(reader));
            reader.Close();
            conn.Close();

            return stations;
        }

        public static Station GetStationByID(int stationID)
        {
            Station station = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stanica_strijelac_view WHERE stanica_id=@stationID";
            cmd.Parameters.AddWithValue("@stationID", stationID);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            station = GetStationFromReader(reader);
            reader.Close();
            conn.Close();

            return station;
        }

        public static Station GetStationStockInfo(int stationID) 
        {
            Station station = null;
            List<Rockets> rocketStock = new List<Rockets>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM skladiste_view WHERE stanica_id=@stationID";
            cmd.Parameters.AddWithValue("@stationID", stationID);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                rocketStock.Add(new Rockets()
                {
                    RocketID = reader.GetInt32(4),
                    Type = reader.GetString(5),
                    Quantity = reader.GetInt32(6)
                });
            }
            station = new Station() {
                RocketStock = rocketStock
            };
            reader.Close();
            conn.Close();
            return station;
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

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteStation(int stationID)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "DELETE FROM stanica WHERE stanica_id=@stationID";
            cmd.Parameters.AddWithValue("@stationID", stationID);

            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
        }

        public static void UpdateStation(Station station)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE stanica SET opstina=@municipality, mjesto=@place, osoba_id=@userID " +
                "WHERE stanica_id=@stationID";
            cmd.Parameters.AddWithValue("@stationID", station.StationID);
            cmd.Parameters.AddWithValue("@municipality", station.Municipality);
            cmd.Parameters.AddWithValue("@place", station.Place);
            if (station.Operator != null)
                cmd.Parameters.AddWithValue("@userID", station.Operator.UserID);
            else
                cmd.Parameters.AddWithValue("@userID", null);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
