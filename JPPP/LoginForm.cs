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
    public partial class LoginForm : GeneralForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Korisničko Ime")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Colors.labelColor;
            }
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "Korisničko Ime";
                tbUserName.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Lozinka")
            {
                tbPassword.Text = "";
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.ForeColor = Colors.labelColor;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Lozinka";
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.ForeColor = SystemColors.WindowFrame;
            }
        }
    }
}
