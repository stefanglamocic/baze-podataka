using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPPP.CustomControls
{
    public partial class CustomRocketsTextBox : UserControl
    {
        public CustomRocketsTextBox()
        {
            InitializeComponent();
            this.BackColor = Colors.mainPanel;
            this.textBox.BackColor = Colors.mainPanel;
            this.label.ForeColor = Colors.labelColor;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
                textBox.ForeColor = Colors.labelColor;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "0";
                textBox.ForeColor = SystemColors.WindowFrame;
            }
        }
    }
}
