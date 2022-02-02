using JPPP.DataAccess;
using JPPP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPPP.Forms
{
    public partial class MeteorologistOption2 : Form //Stanice
    {
        DataTable dt;
        List<Station> stations = new List<Station>();
        int meteorologistID;

        public MeteorologistOption2(int userID)
        {
            InitializeComponent();
            AdminWorkerOption1.CustomizeDGV(this.dgvStations);
            FillStationsGrid();
            meteorologistID = userID;
        }

        public void FillStationsGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Opstina");
            dt.Columns.Add("Mjesto");
            dt.Rows.Clear();

            stations = StationDataAccess.GetStations();
            foreach (var s in stations)
            {
                dt.Rows.Add(new object[] { s.StationID, s.Municipality, s.Place });
            }

            dgvStations.DataSource = dt;
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.textBox1.Text;
            if (!text.Equals("Pretraži..."))
            {
                (dgvStations.DataSource as DataTable).DefaultView.RowFilter = "ID Like '" + text + "%' Or " +
                    "Opstina Like '" + text + "%' Or Mjesto Like '" + text + "%'";
            }
        }

        private void dgvStations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int stationID = Int32.Parse(dgvStations.SelectedRows[0].Cells[0].Value.ToString());
            new StationStockInfoForm(stationID).ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int stationID = Int32.Parse(dgvStations.SelectedRows[0].Cells[0].Value.ToString());
            new ReportForm(stationID, meteorologistID).ShowDialog();
        }
    }
}
