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
    public partial class ErrorMessageForm : GeneralForm
    {
        public ErrorMessageForm(string message)
        {
            InitializeComponent();
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            this.lblTop.Text = "Greška!";
            this.lblTop.Padding = new Padding(8, 0, 0, 0);
            this.lblTop.TextAlign = ContentAlignment.MiddleLeft;
            this.lblMessage.Text = message;
        }

        private void ErrorMessageForm_Load(object sender, EventArgs e)
        {
            this.topPanel.BackColor = Colors.topPanel;
            this.BackColor = Colors.mainPanel;
            this.lblMessage.ForeColor = Colors.labelColor;
            this.lblTop.ForeColor = Colors.labelColor;
            this.pbError.Image = System.Drawing.SystemIcons.Error.ToBitmap();
        }
    }
}
