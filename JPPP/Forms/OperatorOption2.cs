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
    public partial class OperatorOption2 : Form
    {
        int operatorID;
        List<Command> commands;
        DataTable dt;
        public OperatorOption2(int userID)
        {
            InitializeComponent();
            operatorID = userID;
            AdminWorkerOption1.CustomizeDGV(this.dgvCommands);
            FillCommandGrid();
            dgvCommands.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void FillCommandGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Od");
            dt.Columns.Add("Datum");
            dt.Rows.Clear();

            commands = CommandDataAccess.GetCommands(operatorID);
            foreach (Command c in commands)
                dt.Rows.Add(new object[] { c.CommandID, c.Meteorologist.FirstName + " " + 
                       c.Meteorologist.LastName + " (" + c.Meteorologist.UserID + ")", c.Date});

            dgvCommands.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillCommandGrid();
        }

        private void btnDoCmd_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                int commandID = Int32.Parse(dgvCommands.SelectedRows[0].Cells[0].Value.ToString());
                new CommandInfoForm(commandID).ShowDialog();
            }
        }
    }
}
