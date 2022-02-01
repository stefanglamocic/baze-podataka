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
    public partial class OperatorOption1 : Form
    {
        List<User> meteorologists = new List<User>();
        DataTable dt;
        int operatorID;
        public OperatorOption1(int userID)
        {
            InitializeComponent();
            AdminWorkerOption1.CustomizeDGV(this.dgvMeteorologists);
            FillMeteorologistsGrid();
            operatorID = userID;
        }

        public void FillMeteorologistsGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Rows.Clear();

            meteorologists = UserDataAccess.GetMeteorologists();
            foreach (var m in meteorologists)
                dt.Rows.Add(new object[] { m.UserID, m.FirstName, m.LastName});

            dgvMeteorologists.DataSource = dt;
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.textBox1.Text;
            if (!text.Equals("Pretraži..."))
            {
                (dgvMeteorologists.DataSource as DataTable).DefaultView.RowFilter = "Ime Like '" + text + "%' Or " +
                    "Prezime Like '" + text + "%' Or ID Like '" + text + "%'";
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            int meteorologistID = Int32.Parse(dgvMeteorologists.SelectedRows[0].Cells[0].Value.ToString());
            new MessageForm(operatorID, meteorologistID).ShowDialog();
        }
    }
}
