using JPPP.CustomControls;
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
            if(!(tbMessage.Text.Equals("") || tbMessage.Text.Equals("Poruka...")))
            {
                //Console.WriteLine("saljem poruku meteorologu");
            }
            else
            {
                //Console.WriteLine("ne salje se poruka");
            }
        }
    }
}
