using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JPPP.DataAccess;
using JPPP.Model;

namespace JPPP
{
    public partial class LoginForm : GeneralForm
    {
        
        static string themeFile = "theme.txt";
        string themePath = Path.Combine(Environment.CurrentDirectory, themeFile);
        string theme = "dark";
        string language = "srb";
        
        public LoginForm()
        {
            StreamReader reader = null;
            InitializeComponent();
            this.AcceptButton = this.btnLogin;
            try
            {
                reader = new StreamReader(themePath);
                theme = reader.ReadLine();
                if (theme.Equals("light"))
                {
                    reader.Close();
                    lblThemeLight_Click(lblThemeLight, new EventArgs());
                }
                else if (theme.Equals("dark"))
                {
                    reader.Close();
                    lblThemeDark_Click(lblThemeDark, new EventArgs());
                }
                else if(theme.Equals("pop"))
                {
                    reader.Close();
                    lblThemePop_Click(lblThemePop, new EventArgs());
                }
            }
            catch (Exception)
            {
                lblThemeDark_Click(lblThemeDark, new EventArgs());
            }
            finally 
            {
                if(reader != null)
                    reader.Close();
            }
            pbSrb_Click(pbSrb, new EventArgs());
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

        private void lblThemeDark_Click(object sender, EventArgs e)
        {
            Colors.topPanel = Colors.topPanelDark;
            Colors.topLabel = Colors.topLabelColorDark;
            Colors.menuPanel = Colors.menuPanelDark;
            Colors.mainPanel = Colors.mainPanelDark;
            Colors.labelColor = Colors.labelColorDark;
            Colors.selectedControl = Colors.selectedControlDark;
            Colors.selectedLabelColor = Colors.labelColorLight;

            ChangeColors();
            lblThemeDark.ForeColor = Colors.selectedPanel;
            lblThemeLight.ForeColor = Colors.labelColor;
            lblThemePop.ForeColor = Colors.labelColor;

            WriteToFile("dark");
        }

        private void lblThemeLight_Click(object sender, EventArgs e)
        {
            Colors.topPanel = Colors.topPanelLight;
            Colors.topLabel = Colors.topLabelColorLight;
            Colors.menuPanel = Colors.menuPanelLight;
            Colors.mainPanel = Colors.mainPanelLight;
            Colors.labelColor = Colors.labelColorLight;
            Colors.selectedControl = Colors.selectedControlLight;
            Colors.selectedLabelColor = Colors.labelColorDark;

            ChangeColors();
            lblThemeDark.ForeColor = Colors.labelColor;
            lblThemeLight.ForeColor = Colors.selectedPanel;
            lblThemePop.ForeColor = Colors.labelColor;

            WriteToFile("light");
        }

        private void lblThemePop_Click(object sender, EventArgs e)
        {
            Colors.topPanel = Colors.topPanelPop;
            Colors.topLabel = Colors.topLabelColorPop;
            Colors.menuPanel = Colors.menuPanelPop;
            Colors.mainPanel = Colors.mainPanelPop;
            Colors.labelColor = Colors.labelColorPop;
            Colors.selectedControl = Colors.selectedControlPop;
            Colors.selectedLabelColor = Colors.labelColorDark;

            ChangeColors();
            lblThemeDark.ForeColor = Colors.labelColor;
            lblThemeLight.ForeColor = Colors.labelColor;
            lblThemePop.ForeColor = Colors.selectedPanel;
            WriteToFile("pop");
        }

        private void WriteToFile(string theme) 
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(themePath);
                writer.WriteLine(theme);
            }
            finally 
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            User user = UserDataAccess.GetUser(username);
            if (user == null)
            {
                new ErrorMessageForm("Korisnik ne postoji").ShowDialog();
                //MessageBox.Show("Korisnik ne postoji", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user.Password.Equals(password)) // pw je za sada u plaintext-u
                {
                    this.Hide();
                    Form userForm = new GeneralMenuForm(user);
                    userForm.ShowDialog();

                    tbUserName.Clear();
                    tbPassword.Clear();
                    tbUserName.Text = "Korisničko Ime";
                    tbUserName.ForeColor = SystemColors.WindowFrame;
                    tbPassword.UseSystemPasswordChar = false;
                    tbPassword.Text = "Lozinka";
                    tbPassword.ForeColor = SystemColors.WindowFrame;
                    btnLogin.Focus();
                }
                else
                    new ErrorMessageForm("Pogrešna lozinka!").ShowDialog();
                    //MessageBox.Show("Pogresna lozinka!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseLoginFormManually()
        {
            this.Close();
        }

        public void ShowLoginForm() 
        {
            this.Show();
            //UserDataAccess userDataAccess = new UserDataAccess();
            //users = userDataAccess.GetUsers();
        }

        private void ChangeColors() 
        {
            this.topPanel.BackColor = Colors.topPanel;
            this.lblTop.ForeColor = Colors.topLabel;
            this.tbUserName.BackColor = Colors.menuPanel;
            this.tbPassword.BackColor = Colors.menuPanel;
            if(tbUserName.Text == "Korisničko Ime")
                tbUserName.ForeColor = SystemColors.WindowFrame;
            else
                this.tbUserName.ForeColor = Colors.labelColor;
            if(tbPassword.Text == "Lozinka")
                tbPassword.ForeColor = SystemColors.WindowFrame;
            else
                this.tbPassword.ForeColor = Colors.labelColor;
            this.BackColor = Colors.menuPanel;
            this.btnClose.BackColor = Colors.topPanel;
            this.btnMinimize.BackColor = Colors.topPanel;
            this.pnlContainerSrb.BackColor = this.pnlContainerUK.BackColor = Colors.menuPanel;
            if (language.Equals("srb"))
                pbSrb_Click(pbSrb, new EventArgs());
            else
                pbUK_Click(pbUK, new EventArgs());
        }

        private void pbSrb_Click(object sender, EventArgs e)
        {
            language = "srb";
            pnlContainerSrb.BackColor = Colors.selectedPanel;
            pnlContainerUK.BackColor = Colors.menuPanel;
        }

        private void pbUK_Click(object sender, EventArgs e)
        {
            language = "eng";
            pnlContainerUK.BackColor = Colors.selectedPanel;
            pnlContainerSrb.BackColor = Colors.menuPanel;
        }
    }
}
