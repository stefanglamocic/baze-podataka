
namespace JPPP.Forms
{
    partial class AdminWorkerOption2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmsAdminOption2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.podesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new JPPP.CustomControls.SearchTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.cmsAdminOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStations
            // 
            this.dgvStations.AllowUserToAddRows = false;
            this.dgvStations.AllowUserToDeleteRows = false;
            this.dgvStations.AllowUserToResizeColumns = false;
            this.dgvStations.AllowUserToResizeRows = false;
            this.dgvStations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dgvStations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStations.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStations.EnableHeadersVisualStyles = false;
            this.dgvStations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dgvStations.Location = new System.Drawing.Point(12, 57);
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStations.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvStations.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStations.Size = new System.Drawing.Size(606, 381);
            this.dgvStations.TabIndex = 18;
            this.dgvStations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStations_CellDoubleClick);
            this.dgvStations.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStations_CellMouseDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(658, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 42);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmsAdminOption2
            // 
            this.cmsAdminOption2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesiToolStripMenuItem,
            this.obrišiToolStripMenuItem});
            this.cmsAdminOption2.Name = "cmsAdminOption2";
            this.cmsAdminOption2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsAdminOption2.ShowImageMargin = false;
            this.cmsAdminOption2.Size = new System.Drawing.Size(156, 70);
            this.cmsAdminOption2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsAdminOption2_ItemClicked);
            // 
            // podesiToolStripMenuItem
            // 
            this.podesiToolStripMenuItem.Name = "podesiToolStripMenuItem";
            this.podesiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.podesiToolStripMenuItem.Text = "Podesi";
            this.podesiToolStripMenuItem.MouseEnter += new System.EventHandler(this.podesiToolStripMenuItem_MouseEnter);
            this.podesiToolStripMenuItem.MouseLeave += new System.EventHandler(this.podesiToolStripMenuItem_MouseLeave);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.MouseEnter += new System.EventHandler(this.podesiToolStripMenuItem_MouseEnter);
            this.obrišiToolStripMenuItem.MouseLeave += new System.EventHandler(this.podesiToolStripMenuItem_MouseLeave);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSearch.BorderSize = 1;
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(12, 16);
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(5);
            this.tbSearch.Size = new System.Drawing.Size(200, 30);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.UnderlinedStyle = false;
            this.tbSearch._TextChanged += new System.EventHandler(this.tbSearch__TextChanged);
            // 
            // AdminWorkerOption2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvStations);
            this.Name = "AdminWorkerOption2";
            this.Text = "AdminWorkerOption2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.cmsAdminOption2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStations;
        private CustomControls.SearchTextBox tbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip cmsAdminOption2;
        private System.Windows.Forms.ToolStripMenuItem podesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
    }
}