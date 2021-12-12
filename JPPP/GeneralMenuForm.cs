using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JPPP.Model;
using JPPP.DataAccess;

namespace JPPP
{
    public partial class GeneralMenuForm : GeneralForm
    {
        public GeneralMenuForm(User user)
        {
            InitializeComponent();
            this.lblWelcome.Text = $"Dobrodošli {user.FirstName} {user.LastName} \n Odaberite neku od opcija na lijevom panelu";
            this.lblUsername.Text = user.Username;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["LoginForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["LoginForm"] as LoginForm).CloseLoginFormManually();
            }
            this.Close();
        }

        private void ChangeColors() 
        {
            this.btnLogout.BackColor = Colors.menuPanel;
            this.btnLogout.ForeColor = Colors.labelColor;
            this.pnlMenu.BackColor = Colors.menuPanel;
            this.lblUsername.ForeColor = Colors.labelColor;
            this.lblWelcome.ForeColor = Colors.labelColor;
            if (Colors.labelColor == Colors.labelColorDark)
                this.btnLogout.Image = Properties.Resources.log_out_icon1;
            else if(Colors.labelColor == Colors.labelColorLight)
                this.btnLogout.Image = Properties.Resources.log_out_icon2;
        }

        private void GeneralMenuForm_Load(object sender, EventArgs e)
        {
            ChangeColors();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["LoginForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["LoginForm"] as LoginForm).ShowLoginForm();
            }
            this.Close();
        }
    }
}
