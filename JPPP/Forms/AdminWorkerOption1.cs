using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JPPP.Model;
using JPPP.DataAccess;

namespace JPPP.Forms
{
    public partial class AdminWorkerOption1 : Form
    {
        List<User> users = new List<User>();
        public AdminWorkerOption1()
        {
            InitializeComponent();
            this.BackColor = Colors.mainPanel;
            CustomizeDGV(dgvUsers);
            FillUsersGrid();
        }

        private void CustomizeDGV(DataGridView dgv)
        {
            dgv.BackgroundColor = Colors.menuPanel;
            dgv.GridColor = Colors.menuPanel;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Colors.mainPanel;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Colors.labelColor;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Colors.mainPanel;
            dgv.DefaultCellStyle.SelectionBackColor = Colors.selectedPanel;
            dgv.DefaultCellStyle.ForeColor = Colors.labelColor;
            dgv.DefaultCellStyle.Font = new Font("Calibri", 9f);
            dgv.RowsDefaultCellStyle.BackColor = Colors.menuPanel;
            dgv.RowsDefaultCellStyle.ForeColor = Colors.labelColor;
        }

        private void FillUsersGrid() 
        {
            users.AddRange(UserDataAccess.GetAdminWorkers());
            users.AddRange(UserDataAccess.GetMeteorologists());
            users.AddRange(UserDataAccess.GetOperators());

            DataGridView dgv = dgvUsers;
            dgv.Rows.Clear();

            foreach(var u in users)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = u
                };

                string userType = null;
                switch(u.UserType)
                {
                    case "ar": userType = "administrativni radnik";
                        break;
                    case "m": userType = "meteorolog";
                        break;
                    case "s": userType = "strijelac";
                        break;
                }

                row.CreateCells(dgv, u.FirstName, u.LastName, u.JMB, userType);
                dgv.Rows.Add(row);
            }
        }
    }
}
