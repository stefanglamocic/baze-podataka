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
        public AddUserForm()
        {
            InitializeComponent();
            this.lblTop.Text = "Novi korisnik";
            this.btnMaximize.Hide();
            this.btnMinimize.Hide();
            AddingFormChangeColors(this);
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
    }
}
