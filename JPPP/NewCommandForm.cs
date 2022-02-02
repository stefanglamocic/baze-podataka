using JPPP.CustomControls;
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
    public partial class NewCommandForm : GeneralForm
    {
        int meteorologistID, operatorID;
        List<Rockets> rockets;

        public NewCommandForm(int meteorologistID, int operatorID)
        {
            InitializeComponent();
            AddUserForm.AddingFormChangeColors(this);
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            this.lblTop.Text = "Izdaj novu komandu strijelcu " + operatorID;
            this.meteorologistID = meteorologistID;
            this.operatorID = operatorID;
            rockets = RocketsDataAccess.GetRockets();
            AddControls();
        }

        private void AddControls()
        {
            foreach(Rockets r in rockets)
            {
                CustomRocketsTextBox tb = new CustomRocketsTextBox();
                tb.label.Text = r.RocketID + " (" + r.Type + ")";
                tb.Tag = r;

                this.pnlRockets.Controls.Add(tb);
            }
        }

        private void btnNewCommand_Click(object sender, EventArgs e)
        {
            List<Rockets> rocketsList = new List<Rockets>();
            var controls = pnlRockets.Controls.OfType<CustomRocketsTextBox>().ToList();
            foreach (CustomRocketsTextBox c in controls)
            {
                Rockets r = (Rockets)c.Tag;
                r.Quantity = Int32.Parse(c.textBox.Text);

                rocketsList.Add(r);
            }
                
            try
            {
                if (tbAzimuth.TextLength == 0)
                    throw new ArgumentException("Niste unijeli azimut!");
                if (tbElevation.TextLength == 0)
                    throw new ArgumentException("Niste unijeli elevaciju!");

                Command command = new Command()
                {
                    Meteorologist = new User()
                    {
                        UserID = meteorologistID
                    },

                    Operator = new User()
                    {
                        UserID = operatorID
                    },

                    Date = DateTime.Now,
                    Azimuth = Int32.Parse(tbAzimuth.Text),
                    Elevation = Int32.Parse(tbElevation.Text),
                    Rockets = rocketsList
                };

                CommandDataAccess.NewCommand(command);
                CloseOutForm();
            } catch(Exception exc)
            {
                new ErrorMessageForm(exc.Message).ShowDialog();
            }
        }

        private void tbAzimuth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CloseOutForm()
        {
            if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MeteorologistOption1"] as Forms.MeteorologistOption1).FillOperatorsGrid();
            }
            this.Close();
        }
    }
}
