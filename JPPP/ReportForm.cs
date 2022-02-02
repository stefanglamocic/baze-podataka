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
    public partial class ReportForm : GeneralForm
    {
        int stationID, meteorologistID;
        List<User> adminWorkers;
        public ReportForm(int stationID, int meteorologistID)
        {
            InitializeComponent();
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            this.lblTop.Text = "Napiši izvještaj za stanicu " + stationID;
            this.stationID = stationID;
            this.meteorologistID = meteorologistID;
            this.tbMessage.BackColor = Colors.mainPanel;
            this.tbMessage.ForeColor = Colors.labelColor;
            adminWorkers = UserDataAccess.GetAdminWorkers();
            AddAdminWorkersToCB();
            cbAdminWorkers.SelectedIndex = 0;
        }

        private void CloseOutForm()
        {
            if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MeteorologistOption2"] as Forms.MeteorologistOption2).FillStationsGrid();
            }
            this.Close();
        }

        private void AddAdminWorkersToCB()
        {
            foreach (User u in adminWorkers)
                cbAdminWorkers.Items.Add(u.UserID.ToString());
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMessage.TextLength == 0)
                    throw new ArgumentException("Niste unijeli poruku!");

                Report report = new Report()
                {
                    Date = DateTime.Now,
                    Message = tbMessage.Text,
                    Station = new Station()
                    {
                        StationID = stationID
                    },
                    Meteorologist = new User()
                    {
                        UserID = meteorologistID
                    },
                    AdminWorker = new User()
                    {
                        UserID = Int32.Parse(cbAdminWorkers.SelectedItem.ToString())
                    }
                };

                ReportDataAcess.SendReport(report);
                CloseOutForm();
            } catch(Exception exc)
            {
                new ErrorMessageForm(exc.Message).ShowDialog();
            }
        }
    }
}
