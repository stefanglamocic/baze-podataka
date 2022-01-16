
namespace JPPP.Forms
{
    partial class MeteorologistOption2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.tbSearch = new JPPP.CustomControls.SearchTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
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
            this.dgvStations.Size = new System.Drawing.Size(776, 381);
            this.dgvStations.TabIndex = 20;
            // 
            // tbSearch
            // 
            this.tbSearch.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSearch.BorderSize = 1;
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(12, 12);
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(5);
            this.tbSearch.Size = new System.Drawing.Size(200, 30);
            this.tbSearch.TabIndex = 24;
            this.tbSearch.UnderlinedStyle = false;
            this.tbSearch._TextChanged += new System.EventHandler(this.tbSearch__TextChanged);
            // 
            // MeteorologistOption2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvStations);
            this.Name = "MeteorologistOption2";
            this.Text = "MeteorologistOption2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStations;
        private CustomControls.SearchTextBox tbSearch;
    }
}