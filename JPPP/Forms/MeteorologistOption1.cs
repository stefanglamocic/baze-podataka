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
    public partial class MeteorologistOption1 : Form
    {
        List<User> operators = new List<User>();
        DataTable dt;

        public MeteorologistOption1()
        {
            InitializeComponent();
            AdminWorkerOption1.CustomizeDGV(this.dgvOperators);
            FillOperatorsGrid();
        }

        private void FillOperatorsGrid() 
        {
            dt = new DataTable();
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("ID Stanice");
            dt.Rows.Clear();

            //dodati strijelce u grid...

            dgvOperators.DataSource = dt;
        }
    }
}
