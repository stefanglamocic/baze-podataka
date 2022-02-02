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
    class ReportDataAcess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["JPPGP"].ConnectionString;

        public static void SendReport(Report report)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO izvjestaj (datum, napomena, stanica_id, meteorolog_osoba_id, " +
                "administrativni_radnik_osoba_id) VALUES (@date, @message, @stationID, @meteorologistID, " +
                "@adminWorkerID)";
            cmd.Parameters.AddWithValue("@date", report.Date);
            cmd.Parameters.AddWithValue("@message", report.Message);
            cmd.Parameters.AddWithValue("@stationID", report.Station.StationID);
            cmd.Parameters.AddWithValue("@meteorologistID", report.Meteorologist.UserID);
            cmd.Parameters.AddWithValue("@adminWorkerID", report.AdminWorker.UserID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteReport(int reportID)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "DELETE FROM izvjestaj WHERE izvjestaj_id=@reportID";
            cmd.Parameters.AddWithValue("@reportID", reportID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Report> GetReports(int adminWorkerID)
        {
            List<Report> reports = new List<Report>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM izvjestaj i JOIN meteorolozi_view m ON i.meteorolog_osoba_id=m.osoba_id" +
                " WHERE administrativni_radnik_osoba_id=@adminWorkerID";
            cmd.Parameters.AddWithValue("@adminWorkerID", adminWorkerID);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                reports.Add(new Report()
                { 
                    ReportID = reader.GetInt32(0),
                    Date = reader.GetDateTime(1),
                    Message = reader.GetString(2),
                    Station = new Station()
                    {
                        StationID = reader.GetInt32(3)
                    },
                    Meteorologist = new User()
                    {
                        UserID = reader.GetInt32(4),
                        FirstName = reader.GetString(8),
                        LastName = reader.GetString(9),
                        Username = reader.GetString(10)
                    }
                });
            }

            reader.Close();
            conn.Close();
            return reports;
        }

        public static String GetMessage(int reportID)
        {
            String msg = "";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM izvjestaj WHERE izvjestaj_id=@reportID";
            cmd.Parameters.AddWithValue("@reportID", reportID);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            msg = reader.GetString(2);

            return msg;
        }
    }
}
