using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace JPPP.CustomControls
{
    [DefaultEvent("OnIndexChanged")]
    class CustomComboBox : UserControl
    {
        private int borderSize = 1;

        private ComboBox cbList;
        private Label lblText;
        private Button btnIcon;

        public event EventHandler OnIndexChanged;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cbList.Items; }
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cbList.DataSource; }
            set { cbList.DataSource = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cbList.AutoCompleteCustomSource; }
            set { cbList.AutoCompleteCustomSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cbList.AutoCompleteSource; }
            set { cbList.AutoCompleteSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cbList.AutoCompleteMode; }
            set { cbList.AutoCompleteMode = value; }
        }

        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cbList.SelectedItem; }
            set { cbList.SelectedItem = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cbList.SelectedIndex; }
            set { cbList.SelectedIndex = value; }
        }

        public CustomComboBox()
        {
            cbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cbList.BackColor = Colors.mainPanel;
            cbList.Font = new Font("Calibri", 10f);
            cbList.ForeColor = Colors.labelColor;
            cbList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbList.DrawMode = DrawMode.OwnerDrawFixed;
            cbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cbList.TextChanged += new EventHandler(ComboBox_TextChanged);
            cbList.DrawItem += new DrawItemEventHandler(ComboBox_DrawItem);

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = Colors.mainPanel;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            lblText.AutoSize = false;
            lblText.Dock = DockStyle.Fill;
            lblText.BackColor = Colors.mainPanel;
            lblText.ForeColor = Colors.labelColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(4,0,0,0);
            lblText.Font = new Font("Calibri", 10f);
            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cbList);
            this.MinimumSize = new Size(100,30);
            this.Size = new Size(100, 30);
            this.ForeColor = Colors.labelColor;
            this.Padding = new Padding(borderSize);
            base.BackColor = SystemColors.WindowFrame;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Colors.selectedPanel),
                                         e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(combo.BackColor),
                                         e.Bounds);

            e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
                                  new SolidBrush(combo.ForeColor),
                                  new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void AdjustComboBoxDimensions()
        {
            cbList.Width = lblText.Width;
            cbList.Location = new Point
            {
                X = this.Width - this.Padding.Right - cbList.Width,
                Y = lblText.Bottom - cbList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            cbList.Select();
            if (cbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cbList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(SystemColors.WindowFrame, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            cbList.Select();
            cbList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cbList.Text;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnIndexChanged != null)
                OnIndexChanged.Invoke(sender, e);
            lblText.Text = cbList.Text;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
