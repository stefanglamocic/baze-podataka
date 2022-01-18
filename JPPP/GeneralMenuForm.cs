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
        private CustomButton button1, button2, button3, selectedButton;
        User user;
        private Form activeForm;

        public GeneralMenuForm(User user)
        {
            InitializeComponent();
            this.lblTop.Text = "JP Protivgradna preventiva";
            this.lblWelcome.Text = $"Dobro došli {user.FirstName} {user.LastName} \n Odaberite neku od opcija na lijevom panelu";
            this.lblUsername.Text = user.Username;
            SetUserType(user);
            this.user = user;
        }

        private void SetUserType(User user) 
        {
            switch (user.UserType)
            {
                case "ar":
                    this.lblRole.Text = "administrativni radnik";
                    break;
                case "m":
                    this.lblRole.Text = "meteorolog";
                    break;
                case "s":
                    this.lblRole.Text = "strijelac";
                    break;
            }
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
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            button1 = new CustomButton();
            pnlGroup.Controls.Add(button1);
            button1.Dock = DockStyle.Top;
            button1.BringToFront();
            button1.Click += Button1_Click;

            button2 = new CustomButton();
            pnlGroup.Controls.Add(button2);
            button2.Dock = DockStyle.Top;
            button2.BringToFront();
            button2.Click += Button2_Click;

            button3 = new CustomButton();
            pnlGroup.Controls.Add(button3);
            button3.Dock = DockStyle.Top;
            button3.BringToFront();
            button3.Click += Button3_Click;

            if (user.UserType.Equals("ar"))
            {
                button1.Text = "Korisnici";
                button2.Text = "Stanice";
                button3.Text = "Izvjestaji";
            }
            else if(user.UserType.Equals("m"))
            {
                button1.Text = "Strijelci";
                button2.Text = "Stanice";
                button3.Text = "Poruke";
            }
            else if(user.UserType.Equals("s"))
            {
                button1.Text = "Meteorolozi";
                button2.Text = "Naredbe";
                button3.Hide();
            }
        }

        private void HighlightButton(object sender) 
        {
            if (sender != null)
            { 
                if(selectedButton != (CustomButton)sender)
                {
                    DeselectButtons();
                    selectedButton = (CustomButton)sender;
                    selectedButton.BackColor = Colors.selectedPanel;
                    selectedButton.ForeColor = Colors.selectedLabelColor;
                    lblTop.Text = selectedButton.Text;
                    lblWelcome.Hide();
                }
            }
        }

        private void DeselectButtons()
        {
            foreach(Control c in pnlGroup.Controls)
            { 
                if(c.GetType() == typeof(CustomButton))
                {
                    c.BackColor = Colors.menuPanel;
                    c.ForeColor = Colors.labelColor;
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(childForm);
            this.pnlMain.Tag = childForm;
            childForm.BackColor = Colors.mainPanel;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            if (user.UserType.Equals("ar"))
                OpenChildForm(new Forms.AdminWorkerOption1(user.Username));
            else if (user.UserType.Equals("m"))
                OpenChildForm(new Forms.MeteorologistOption1());
            else if (user.UserType.Equals("s"))
                OpenChildForm(new Forms.OperatorOption1());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            if (user.UserType.Equals("ar"))
                OpenChildForm(new Forms.AdminWorkerOption2());
            else if (user.UserType.Equals("m"))
                OpenChildForm(new Forms.MeteorologistOption2());
            else if (user.UserType.Equals("s"))
                OpenChildForm(new Forms.OperatorOption2());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            if (user.UserType.Equals("ar"))
                OpenChildForm(new Forms.AdminWorkerOption3());
            else if (user.UserType.Equals("m"))
                OpenChildForm(new Forms.MeteorologistOption3());
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
