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
    [DefaultEvent("_TextChanged")]
    public partial class SearchTextBox : UserControl
    {
        private Color borderColor = SystemColors.WindowFrame;
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private bool isFocused = false;
        private Color borderFocusColor = Colors.selectedPanel;
        public SearchTextBox()
        {
            InitializeComponent();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image = Properties.Resources.edit_find_icon_181110;
            this.textBox1.BackColor = Colors.mainPanel;
            this.textBox1.ForeColor = SystemColors.WindowFrame;
            this.textBox1.Text = "Pretraži...";
        }

        public event EventHandler _TextChanged;

        public Color BorderColor { get => borderColor; 
            set 
            { 
                borderColor = value;
                this.Invalidate();
            } 
        }
        public int BorderSize 
        { 
            get => borderSize; 
            set
            { 
                borderSize = value; 
                this.Invalidate(); 
            } 
        }
        public bool UnderlinedStyle 
        { 
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;
                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else 
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            if (textBox1.Text == "Pretraži...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Colors.labelColor;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            if (textBox1.Text == "")
            {
                textBox1.Text = "Pretraži...";
                textBox1.ForeColor = SystemColors.WindowFrame;
            }
        }
    }
}
