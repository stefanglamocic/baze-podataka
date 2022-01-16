
namespace JPPP.Forms
{
    partial class MeteorologistOption1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperators = new System.Windows.Forms.DataGridView();
            this.tbSearch = new JPPP.CustomControls.SearchTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperators)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperators
            // 
            this.dgvOperators.AllowUserToAddRows = false;
            this.dgvOperators.AllowUserToDeleteRows = false;
            this.dgvOperators.AllowUserToResizeColumns = false;
            this.dgvOperators.AllowUserToResizeRows = false;
            this.dgvOperators.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperators.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dgvOperators.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOperators.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperators.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOperators.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperators.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOperators.EnableHeadersVisualStyles = false;
            this.dgvOperators.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dgvOperators.Location = new System.Drawing.Point(12, 57);
            this.dgvOperators.Name = "dgvOperators";
            this.dgvOperators.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperators.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOperators.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvOperators.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOperators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperators.Size = new System.Drawing.Size(776, 381);
            this.dgvOperators.TabIndex = 19;
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
            this.tbSearch.TabIndex = 23;
            this.tbSearch.UnderlinedStyle = false;
            // 
            // MeteorologistOption1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvOperators);
            this.Name = "MeteorologistOption1";
            this.Text = "MeteorologistOption1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperators)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperators;
        private CustomControls.SearchTextBox tbSearch;
    }
}