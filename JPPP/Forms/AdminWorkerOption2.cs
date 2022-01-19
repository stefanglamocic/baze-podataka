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
    public partial class AdminWorkerOption2 : Form
    {
        DataTable dt;
        List<Station> stations = new List<Station>();
        ToolStripMenuItem menuItem;

        public AdminWorkerOption2()
        {
            InitializeComponent();
            menuItem = new ToolStripMenuItem();
            menuItem.Name = "unregisterOperator";
            menuItem.Text = "Razduži strijelca";
            cmsAdminOption2.Items.Add(menuItem);
            menuItem.MouseEnter += podesiToolStripMenuItem_MouseEnter;
            menuItem.MouseLeave += podesiToolStripMenuItem_MouseLeave;
            AdminWorkerOption1.CustomizeDGV(this.dgvStations);
            AdminWorkerOption1.CustomizeCMS(this.cmsAdminOption2);
            FillStationsGrid();
        }

        public void FillStationsGrid() 
        {
            dt = new DataTable();
            dt.Columns.Add("ID Stanice");
            dt.Columns.Add("Opstina");
            dt.Columns.Add("Mjesto");
            dt.Columns.Add("Strijelac");
            dt.Rows.Clear();

            stations = StationDataAccess.GetStations();
            foreach (var s in stations) 
            {
                if(s.Operator == null)
                    dt.Rows.Add(new object[] { s.StationID, s.Municipality, s.Place, "N/A" });
                else
                    dt.Rows.Add(new object[] { s.StationID, s.Municipality, s.Place, s.Operator.Username });
            }

            dgvStations.DataSource = dt;
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.textBox1.Text;
            if (!text.Equals("Pretraži..."))
            {
                (dgvStations.DataSource as DataTable).DefaultView.RowFilter = "[ID Stanice] Like '" + text + "%' Or " +
                    "Opstina Like '" + text + "%' Or Mjesto Like '" + text + "%'";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddStationForm().ShowDialog();
        }

        private void dgvStations_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView temp = (sender as DataGridView);
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    temp.CurrentCell = clickedCell;
                    var relativeMousePosition = temp.PointToClient(Cursor.Position);
                    string registeredOperator = dgvStations.SelectedRows[0].Cells[3].Value.ToString();
                    Console.WriteLine(registeredOperator);
                    
                    if (registeredOperator.Equals("N/A")) // i ako postoji treca opcija(dodati)
                    {
                        //ukloniti trecu opciju
                        cmsAdminOption2.Items[2].Visible = false;
                    }
                    else
                    {
                        //dodati trecu opciju
                        cmsAdminOption2.Items[2].Visible = true;
                    }
                    cmsAdminOption2.Show(temp, relativeMousePosition);
                }
            }
        }

        private void podesiToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (sender as ToolStripMenuItem);
            temp.ForeColor = Colors.selectedLabelColor;
        }

        private void podesiToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (sender as ToolStripMenuItem);
            temp.ForeColor = Colors.labelColor;
        }

        private void dgvStations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int stationID = Int32.Parse(dgvStations.SelectedRows[0].Cells[0].Value.ToString());
            new StationInfoForm(stationID).ShowDialog();
        }

        private void cmsAdminOption2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int stationID = Int32.Parse(dgvStations.SelectedRows[0].Cells[0].Value.ToString());
            switch(e.ClickedItem.Name.ToString())
            {
                case "podesiToolStripMenuItem":
                    {
                        new AddStationForm(stationID).ShowDialog();
                    }break;
                case "obrišiToolStripMenuItem":
                    {
                        DialogResult dialogResult = new WarningMessageForm("Da li ste sigurni da zelite " +
                            "obrisati stanicu: " + stationID).ShowDialog();
                        if (dialogResult == DialogResult.Yes)
                            StationDataAccess.DeleteStation(stationID);
                    }break;
                case "unregisterOperator":
                    {
                        Station station = StationDataAccess.GetStationByID(stationID);
                        station.Operator = null;
                        StationDataAccess.UpdateStation(station);
                    }break;
            }
            FillStationsGrid();
        }
    }
}
