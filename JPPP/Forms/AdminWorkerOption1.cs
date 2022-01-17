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
using JPPP.Renderer;

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
            dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUsers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomizeCMS(cmsAWOption1);
        }

        public static void CustomizeCMS(ContextMenuStrip cms)
        {
            cms.BackColor = Colors.menuPanel;
            foreach(ToolStripMenuItem i in cms.Items)
            {
                i.ForeColor = Colors.labelColor;
            }
            cms.Renderer = new CustomRenderer();
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
                    "Prezime Like '" + text + "%' Or [Korisničko ime] Like '" + text + "%' Or ID Like '" + text + "%'";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddUserForm(cbUserTypes.SelectedIndex).ShowDialog();
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView temp = (sender as DataGridView);
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    temp.CurrentCell = clickedCell;
                    var relativeMousePosition = temp.PointToClient(Cursor.Position);
                    cmsAWOption1.Show(temp, relativeMousePosition);
                }
            }
        }

        private void izmjenaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (sender as ToolStripMenuItem);
            temp.ForeColor = Colors.selectedLabelColor;
        }

        private void izmjenaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (sender as ToolStripMenuItem);
            temp.ForeColor = Colors.labelColor;
        }

        private void cmsAWOption1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string username = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
            int userID = Int32.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
            switch (e.ClickedItem.Name.ToString())
            {
                case "obrišiToolStripMenuItem":
                    {
                        DialogResult dialogResult = new WarningMessageForm("Da li ste sigurni da zelite obrisati korisnika " + username).ShowDialog();
                        if(dialogResult == DialogResult.Yes)
                        {
                            UserDataAccess.DeleteUser(userID);
                        }
                    }
                    break;
            }
            FillUsersGrid(cbUserTypes.SelectedIndex);
        }

        public void FillUsersGrid(int optionSelected) 
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("Korisničko ime");
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
                /*DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = u
                };*/

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
                
                dt.Rows.Add(new object[] { u.UserID, u.FirstName, u.LastName, u.Username, userType });
                
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
