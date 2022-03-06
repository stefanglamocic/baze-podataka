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
using Message = JPPP.Model.Message;

namespace JPPP
{
    public partial class DoCommandForm : GeneralForm
    {
        Command command;
        public DoCommandForm(Command command)
        {
            InitializeComponent();
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            this.lblTop.Text = "Unesite informacije";
            this.pnlContainer.AutoScroll = true;
            this.tbMessage.BackColor = Colors.mainPanel;
            this.command = command;
            AddControls();
        }

        private void AddControls() {
            List<Rockets> rockets = command.Rockets;
            foreach (Rockets r in rockets)
            {
                if(r.Quantity > 0)
                {
                    CustomRocketsTextBox tb = new CustomRocketsTextBox();
                    tb.label.Text = r.RocketID + " (" + r.Type + ")";
                    tb.Tag = r;

                    this.pnlContainer.Controls.Add(tb);
                    tb.Anchor = AnchorStyles.Top;
                    tb.Dock = DockStyle.Top;
                    tb.BringToFront();
                }
            }
        }

        private void tbMessage_Enter(object sender, EventArgs e)
        {
            if (tbMessage.Text == "Poruka...")
            {
                tbMessage.Text = "";
                tbMessage.ForeColor = Colors.labelColor;
            }
        }

        private void tbMessage_Leave(object sender, EventArgs e)
        {
            if (tbMessage.Text == "")
            {
                tbMessage.Text = "Poruka...";
                tbMessage.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void btnDoCmd_Click(object sender, EventArgs e)
        {
            try
            {
                CommandDone done = new CommandDone()
                {
                    CommandID = command.CommandID,
                    Meteorologist = command.Meteorologist,
                    Operator = command.Operator,
                    Date = DateTime.Now,
                    Rockets = new List<Rockets>()
                };

                foreach (CustomRocketsTextBox tb in pnlContainer.Controls)
                {
                    Rockets rockets = (Rockets)tb.Tag;
                    int quantity = Int32.Parse(tb.textBox.Text);
                    if (quantity > rockets.Quantity)
                        throw new ArgumentException("Unijeli ste veći broj raketa nego što je izdato\n" +
                            "u naredbi");
                    else
                    {
                        done.Rockets.Add(new Rockets()
                        {
                            RocketID = rockets.RocketID,
                            Type = rockets.Type,
                            Quantity = quantity
                        });
                    }
                }


                if (!(tbMessage.Text.Equals("") || tbMessage.Text.Equals("Poruka...")))
                {
                    done.Text = tbMessage.Text;
                }

                CommandDoneDataAccess.AddCommandDone(done);
                CommandDataAccess.CommandDone(done.CommandID);
                CloseOutForm();
            }
            catch(Exception exc)
            {
                new ErrorMessageForm(exc.Message).ShowDialog();
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
    }
}
