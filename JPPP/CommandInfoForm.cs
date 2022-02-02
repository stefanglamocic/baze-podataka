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
    public partial class CommandInfoForm : GeneralForm
    {
        Command command;
        public CommandInfoForm(int commandID)
        {
            InitializeComponent();
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            this.lblTop.Text = "Izvrsi naredbu " + commandID;
            command = CommandDataAccess.GetCommand(commandID);
            command.CommandID = commandID;
            WriteDetails();
        }

        private void WriteDetails()
        {
            lblAzimuth.Text = command.Azimuth.ToString();
            lblElevation.Text = command.Elevation.ToString();
            lblRocketsInfo.Text = "";
            foreach(Rockets r in command.Rockets)
            {
                lblRocketsInfo.Text += r.RocketID + " (" + r.Type + ")" + "       Kolicina: " + r.Quantity + "\n";
            }
        }

        private void CloseOutForm()
        {
            if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["OperatorOption2"] as Forms.OperatorOption2).FillCommandGrid();
            }
            this.Close();
        }

        private void CommandInfoForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                    ((Label)c).ForeColor = Colors.labelColor;
            }
        }

        private void btnDoCmd_Click(object sender, EventArgs e)
        {
            CommandDataAccess.CommandDone(command.CommandID);
            CloseOutForm();
        }
    }
}
