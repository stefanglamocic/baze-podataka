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
        List<User> adminWorkers, meteorologists, operators;
        DataTable dt;
        public AdminWorkerOption1()
        {
            InitializeComponent();
            CustomizeDGV(dgvUsers);
            FillUsersGrid(cbUserTypes.SelectedIndex);
            dgvUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public static void CustomizeDGV(DataGridView dgv)
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

        private void customComboBox1_OnIndexChanged(object sender, EventArgs e)
        {
            FillUsersGrid(cbUserTypes.SelectedIndex);
        }

        private void searchTextBox1__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.textBox1.Text;
            if (!text.Equals("Pretraži..."))
            {
                (dgvUsers.DataSource as DataTable).DefaultView.RowFilter = "Ime Like '" + text + "%' Or " +
                    "Prezime Like '" + text + "%' Or JMB Like '" + text + "%'";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddUserForm().ShowDialog();
        }

        private void FillUsersGrid(int optionSelected) 
        {
            dt = new DataTable();
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("JMB");
            dt.Columns.Add("Tip Korisnika");
            users.Clear();
            adminWorkers = UserDataAccess.GetAdminWorkers();
            meteorologists = UserDataAccess.GetMeteorologists();
            operators = UserDataAccess.GetOperators();

            switch (optionSelected) 
            {
                case 1: users.AddRange(adminWorkers);
                    break;
                case 2: users.AddRange(meteorologists);
                    break;
                case 3: users.AddRange(operators);
                    break;
                default:
                    {
                        users.AddRange(adminWorkers);
                        users.AddRange(meteorologists);
                        users.AddRange(operators);
                    }
                    break;
            }
            

            DataGridView dgv = dgvUsers;
            dt.Rows.Clear();
            //dgv.Rows.Clear();

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

                dt.Rows.Add(new object[] { u.FirstName, u.LastName, u.JMB, userType });
                
                //row.CreateCells(dgv, u.FirstName, u.LastName, u.JMB, userType);
                //dgv.Rows.Add(row);
            }
            dgv.DataSource = dt;
        }

        private void customComboBox1_Load(object sender, EventArgs e)
        {
            this.cbUserTypes.SelectedIndex = 0;
        }
    }
}
