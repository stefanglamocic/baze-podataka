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
        public AddUserForm(int selectedIndex)
        {
            InitializeComponent();
            this.lblTop.Text = "Novi korisnik";
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            AddingFormChangeColors(this);
            this.selectedIndex = selectedIndex;
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
            this.cbUserTypes.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userType = null;

            switch(cbUserTypes.SelectedIndex)
            {
                case 0: userType = "ar"; break;
                case 1: userType = "m"; break;
                case 2: userType = "s"; break;
            }

            try 
            {
                if (tbFirstName.TextLength == 0)
                    throw new ArgumentException("Ime nije unešeno, molimo pokušajte ponovo.");
                if(tbLastName.TextLength == 0)
                    throw new ArgumentException("Prezime nije unešeno, molimo pokušajte ponovo.");
                if(tbUsername.TextLength == 0)
                    throw new ArgumentException("Korisničko ime nije unešeno, molimo pokušajte ponovo.");
                if (tbPassword.TextLength == 0)
                    throw new ArgumentException("Lozinka nije unešena, molimo pokušajte ponovo.");
                /*if (tbJMB.TextLength != 13)
                    throw new ArgumentException("JMB nije pravilno unešen, molimo pokušajte ponovo.");*/

                User newUser = new User()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    JMB = tbJMB.Text,
                    Username = tbUsername.Text,
                    Password = tbPassword.Text,
                    UserType = userType
                };

                UserDataAccess.AddUser(newUser);

                if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["AdminWorkerOption1"] as Forms.AdminWorkerOption1).FillUsersGrid(selectedIndex);
                }
                this.Close();
            }
            catch(Exception exception)
            {
                new ErrorMessageForm(exception.Message).ShowDialog();
            }
        }
    }
}
