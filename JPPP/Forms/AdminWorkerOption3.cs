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
using JPPP.DataAccess;

namespace JPPP.Forms
{
    public partial class AdminWorkerOption3 : Form
    {
        DataTable dt;
        int adminWorkerID;
        List<Report> reports;
        public AdminWorkerOption3(int userID)
        {
            InitializeComponent();
            adminWorkerID = userID;
            this.BackColor = Colors.mainPanel;
            AdminWorkerOption1.CustomizeDGV(this.dgvReports);
            FillReportsGrid();
            dgvReports.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReports.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void FillReportsGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Od");
            dt.Columns.Add("Datum");
            dt.Columns.Add("ID Stanice");
            dt.Rows.Clear();

            reports = ReportDataAcess.GetReports(adminWorkerID);
            foreach (Report r in reports)
                dt.Rows.Add(new object[] { r.ReportID, r.Meteorologist.FirstName + " " + 
                    r.Meteorologist.LastName + " (" + r.Meteorologist.UserID + ")", r.Date, r.Station.StationID});

            dgvReports.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                int reportID = Int32.Parse(dgvReports.SelectedRows[0].Cells[0].Value.ToString());
                ReportDataAcess.DeleteReport(reportID);
                FillReportsGrid();
            }
        }

        private void dgvReports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int reportID = Int32.Parse(dgvReports.SelectedRows[0].Cells[0].Value.ToString());
            new ReportMessageForm(reportID).ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillReportsGrid();
        }
    }
}
