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
    public partial class AddStationForm : GeneralForm
    {
        bool change = false;
        Station station;
        List<User> availableOperators;
        
        public AddStationForm()
        {
            InitializeComponent();
            this.lblTop.Text = "Dodaj novu stanicu";
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            AddUserForm.AddingFormChangeColors(this);
            availableOperators = UserDataAccess.GetAvailableOperators();
            AddOperatorsToCB();
        }

        public AddStationForm(int stationID) : this()
        {
            this.lblTop.Text = "Podesi informacije o stanici";
            change = true;
            station = StationDataAccess.GetStationByID(stationID);
            tbMunicipality.Text = station.Municipality;
            tbPlace.Text = station.Place;
            if(station.Operator != null) 
            {
                availableOperators.Insert(0, station.Operator);
                cbOperators.SelectedIndex = 0;
            }
                
            cbOperators.Items.Clear();
            AddOperatorsToCB();
        }

        private void AddOperatorsToCB()
        {
            foreach (User u in availableOperators)
                cbOperators.Items.Add(u.UserID.ToString() + "/" + u.Username);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMunicipality.TextLength == 0)
                    throw new ArgumentException("Niste unijeli opstinu. Molimo pokusajte ponovo.");
                if (tbPlace.TextLength == 0)
                    throw new ArgumentException("Niste unijeli mjesto. Molimo pokusajte ponovo.");

                Station station = new Station()
                {
                    Municipality = tbMunicipality.Text,
                    Place = tbPlace.Text
                };

                if(cbOperators.SelectedIndex > -1)
                {
                    station.Operator = GetOperatorFromCB();
                }

                if(!change)
                    StationDataAccess.AddStation(station);
                else
                {
                    //update stanice
                    station.StationID = this.station.StationID;
                    StationDataAccess.UpdateStation(station);
                }

                CloseOutForm();
            }
            catch(Exception exception)
            {
                new ErrorMessageForm(exception.Message).ShowDialog();
            }
        }

        private User GetOperatorFromCB()
        {
            string username = (cbOperators.SelectedItem.ToString().Split('/'))[1];
            return UserDataAccess.GetUser(username);
        }

        private void CloseOutForm()
        {
            if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["AdminWorkerOption2"] as Forms.AdminWorkerOption2).FillStationsGrid();
            }
            this.Close();
        }
    }
}
