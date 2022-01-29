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
    public partial class StationStockInfoForm : GeneralForm
    {
        Station station;
        public StationStockInfoForm(int stationID)
        {
            InitializeComponent();
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            this.btnClose.Hide();
            this.tbInfo.BackColor = Colors.mainPanel;
            this.tbInfo.ForeColor = Colors.labelColor;
            this.lblTop.Text = "Stanje u skladistu na stanici " + stationID;
            station = StationDataAccess.GetStationStockInfo(stationID);
            WriteInfo();
        }

        private void WriteInfo()
        {
            foreach(Rockets r in station.RocketStock)
            {
                tbInfo.AppendText(String.Format("{0,-57} {1,-53} {2, -60}", r.RocketID, r.Type, r.Quantity));
                tbInfo.AppendText(Environment.NewLine);
            }
        }
    }
}
