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

namespace JPPP
{
    public partial class StationInfoForm : GeneralForm
    {
        Station station = null;
        public StationInfoForm(int stationID)
        {
            InitializeComponent();
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            this.btnClose.Hide();
            this.lblTop.Text = "Informacije o registrovanom strijelcu";
            station = StationDataAccess.GetStationByID(stationID);
            WriteDetails();
        }

        private void StationInfoForm_Load(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is Label)
                    ((Label)c).ForeColor = Colors.labelColor;
            }
        }

        private void WriteDetails()
        {
            lblStationID.Text = station.StationID.ToString();
            if (station.Operator != null)
            {
                User op = station.Operator;
                lblOperatorInfo.Text = $"ID: {op.UserID}\nKorisnicko ime: {op.Username}\n" +
                    $"JMB: {op.JMB}\nIme: {op.FirstName}\nPrezime: {op.LastName}";
            }
            else
                lblOperatorInfo.Text = "Na ovoj stanici trenutno nije registrovan nijedan strijelac.";
        }
    }
}
