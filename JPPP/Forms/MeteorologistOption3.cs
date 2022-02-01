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
using JPPP.Model;

namespace JPPP.Forms
{
    public partial class MeteorologistOption3 : Form
    {
        DataTable dt;
        List<Model.Message> messages;
        int meteorologistID;
        public MeteorologistOption3(int userID)
        {
            InitializeComponent();
            meteorologistID = userID;
            AdminWorkerOption1.CustomizeDGV(this.dgvMessages);
            FillMessagesGrid();
            dgvMessages.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void FillMessagesGrid() 
        {
            dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Od");
            dt.Columns.Add("Datum");
            dt.Rows.Clear();

            messages = MessageDataAccess.GetMessages(meteorologistID);
            foreach(Model.Message m in messages)
            {
                dt.Rows.Add(new object[] { m.MessageID, m.Operator.FirstName + " " + m.Operator.LastName + 
                    " (" + m.Operator.Username + ")", m.Date});
            }

            dgvMessages.DataSource = dt;
        }

        private void dgvMessages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int msgID = Int32.Parse(dgvMessages.SelectedRows[0].Cells[0].Value.ToString());
            new MessageForm(msgID).ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillMessagesGrid();
        }
    }
}
