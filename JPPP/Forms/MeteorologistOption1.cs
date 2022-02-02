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
    public partial class MeteorologistOption1 : Form //Strijelci
    {
        DataTable dt;
        List<Operator> operators = new List<Operator>();
        int meteorologistID;
        public MeteorologistOption1(int userID)
        {
            InitializeComponent();
            meteorologistID = userID;
            AdminWorkerOption1.CustomizeDGV(this.dgvOperators);
            FillOperatorsGrid();
        }

        public void FillOperatorsGrid() 
        {
            dt = new DataTable();
            dt.Columns.Add("ID Strijelca");
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("ID Stanice");
            dt.Rows.Clear();

            operators = OperatorDataAccess.GetOperators();
            foreach(Operator o in operators)
            {
                if (o.StationID == null)
                    dt.Rows.Add(new object[] { o.UserID, o.FirstName, o.LastName, "N/A"});
                else
                    dt.Rows.Add(new object[] { o.UserID, o.FirstName, o.LastName, o.StationID });
            }
            
            dgvOperators.DataSource = dt;
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.textBox1.Text;
            if (!text.Equals("Pretraži..."))
            {
                (dgvOperators.DataSource as DataTable).DefaultView.RowFilter = "[ID Strijelca] Like '" + text + "%' Or " +
                    "Ime Like '" + text + "%' Or Prezime Like '" + text + "%'";
            }
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            int operatorID = Int32.Parse(dgvOperators.SelectedRows[0].Cells[0].Value.ToString());
            String stationID = dgvOperators.SelectedRows[0].Cells[3].Value.ToString();
            if (stationID.Equals("N/A"))
                new ErrorMessageForm("Strijelac " + operatorID + " nije registrovan " +
                    "ni u jednoj stanici").ShowDialog();
            else
                new NewCommandForm(meteorologistID, operatorID).ShowDialog();
        }
    }
}
