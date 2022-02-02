using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JPPP.DataAccess;

namespace JPPP
{
    public partial class ReportMessageForm : GeneralForm
    {
        public ReportMessageForm(int reportID)
        {
            InitializeComponent();
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            this.btnClose.Hide();
            this.lblTop.Text = "Poruka";

            this.tbMessage.BackColor = Colors.mainPanel;
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ForeColor = Colors.labelColor;
            this.tbMessage.Text = ReportDataAcess.GetMessage(reportID);
        }
    }
}
