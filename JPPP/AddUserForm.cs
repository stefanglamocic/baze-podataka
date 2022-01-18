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
    public partial class AddUserForm : GeneralForm
    {
        int selectedIndex;
        bool changeUser = false;
        User userToChange;
        List<User> allUsers = UserDataAccess.GetUsers();
        
        public AddUserForm(int selectedIndex)
        {
            InitializeComponent();
            this.lblTop.Text = "Novi korisnik";
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            AddingFormChangeColors(this);
            this.selectedIndex = selectedIndex;
        }

        public AddUserForm(string username)
        {
            InitializeComponent();
            this.lblTop.Text = "Promijeni informacije o korisniku";
            changeUser = true;
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            AddingFormChangeColors(this);
            userToChange = UserDataAccess.GetUser(username);
        }

        public static void AddingFormChangeColors(Form form)
        {
            foreach(var c in form.Controls)
            {
                if (c is Label)
                    ((Label)c).ForeColor = Colors.labelColor;
                else if (c is TextBox)
                    ((TextBox)c).BackColor = Colors.mainPanel;
            }
        }

        private void cbUserTypes_Load(object sender, EventArgs e)
        {
            if(changeUser)
            {
                switch(userToChange.UserType)
                {
                    case "ar": this.cbUserTypes.SelectedIndex = 0; break;
                    case "m": this.cbUserTypes.SelectedIndex = 1; break;
                    case "s": this.cbUserTypes.SelectedIndex = 2; break;
                }
                cbUserTypes.Enabled = false;
            }
            else
                this.cbUserTypes.SelectedIndex = 0;
        }

        private bool UsernameExists(string username)
        {
            foreach (var u in allUsers)
                if (u.Username.Equals(username))
                    return true;
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userType = null;

            switch (cbUserTypes.SelectedIndex)
            {
                case 0: userType = "ar"; break;
                case 1: userType = "m"; break;
                case 2: userType = "s"; break;
            }

            try
            {
                if (tbFirstName.TextLength == 0)
                    throw new ArgumentException("Ime nije unešeno, molimo pokušajte ponovo.");
                if (tbLastName.TextLength == 0)
                    throw new ArgumentException("Prezime nije unešeno, molimo pokušajte ponovo.");
                if (tbUsername.TextLength == 0)
                    throw new ArgumentException("Korisničko ime nije unešeno, molimo pokušajte ponovo.");
                if (tbPassword.TextLength == 0 && !changeUser)
                    throw new ArgumentException("Lozinka nije unešena, molimo pokušajte ponovo.");
                if (UsernameExists(tbUsername.Text) && !changeUser)
                    throw new ArgumentException("Korisničko ime već postoji!");
                if (tbJMB.TextLength == 0) //tbJMB.TextLength != 13
                    throw new ArgumentException("JMB nije pravilno unešen, molimo pokušajte ponovo.");

                User newUser = new User()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    JMB = tbJMB.Text,
                    Username = tbUsername.Text,
                    Password = tbPassword.Text,
                    UserType = userType
                };

                if(changeUser)
                {
                    if (tbPassword.TextLength == 0)
                        UserDataAccess.UpdateUser(userToChange.UserID, newUser, false);
                    else
                        UserDataAccess.UpdateUser(userToChange.UserID, newUser, true);
                }
                else
                    UserDataAccess.AddUser(newUser);

                CloseOutForm();
            }
            catch (Exception exception)
            {
                new ErrorMessageForm(exception.Message).ShowDialog();
            }
        }

        private void CloseOutForm()
        {
            if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["AdminWorkerOption1"] as Forms.AdminWorkerOption1).FillUsersGrid(selectedIndex);
            }
            this.Close();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            pbEye.BackColor = Colors.mainPanel;
            tbPassword.UseSystemPasswordChar = true;
            if (changeUser)
            {
                tbFirstName.Text = userToChange.FirstName;
                tbLastName.Text = userToChange.LastName;
                tbJMB.Text = userToChange.JMB;
                tbUsername.Text = userToChange.Username;
            }
        }

        private void pbEye_MouseDown(object sender, MouseEventArgs e)
        {
            this.pbEye.Image = Properties.Resources.eye_icon_selected;
            this.tbPassword.UseSystemPasswordChar = false;
        }

        private void pbEye_MouseUp(object sender, MouseEventArgs e)
        {
            this.pbEye.Image = Properties.Resources.eye_icon;
            this.tbPassword.UseSystemPasswordChar = true;
        }
    }
}
