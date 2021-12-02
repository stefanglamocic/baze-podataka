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

namespace JPPP
{
    public partial class LoginForm : GeneralForm
    {

        static string themeFile = "theme.txt";
        string themePath = Path.Combine(Environment.CurrentDirectory, themeFile);
        string theme = "dark";
        
        public LoginForm()
        {
            StreamReader reader = null;
            InitializeComponent();
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
            Colors.menuPanel = Colors.menuPanelDark;
            Colors.mainPanel = Colors.mainPanelDark;
            Colors.labelColor = Colors.labelColorDark;
            Colors.selectedControl = Colors.selectedControlDark;

            InitializeComponent();
            this.Refresh();

            lblThemeDark.ForeColor = Colors.selectedPanel;
            lblThemeLight.ForeColor = Colors.labelColor;

            WriteToFile("dark");
        }

        private void lblThemeLight_Click(object sender, EventArgs e)
        {
            Colors.topPanel = Colors.topPanelLight;
            Colors.menuPanel = Colors.menuPanelLight;
            Colors.mainPanel = Colors.mainPanelLight;
            Colors.labelColor = Colors.labelColorLight;
            Colors.selectedControl = Colors.selectedControlLight;

            InitializeComponent();
            this.Refresh();

            lblThemeDark.ForeColor = Colors.labelColor;
            lblThemeLight.ForeColor = Colors.selectedPanel;

            WriteToFile("light");
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
    }
}
