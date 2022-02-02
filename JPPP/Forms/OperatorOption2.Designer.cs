
namespace JPPP.Forms
{
    partial class OperatorOption2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCommands = new System.Windows.Forms.DataGridView();
            this.btnDoCmd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommands
            // 
            this.dgvCommands.AllowUserToAddRows = false;
            this.dgvCommands.AllowUserToDeleteRows = false;
            this.dgvCommands.AllowUserToResizeColumns = false;
            this.dgvCommands.AllowUserToResizeRows = false;
            this.dgvCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommands.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dgvCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCommands.ColumnHeadersHeight = 40;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommands.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCommands.EnableHeadersVisualStyles = false;
            this.dgvCommands.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dgvCommands.Location = new System.Drawing.Point(12, 57);
            this.dgvCommands.Name = "dgvCommands";
            this.dgvCommands.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommands.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCommands.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            this.dgvCommands.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommands.Size = new System.Drawing.Size(606, 381);
            this.dgvCommands.TabIndex = 21;
            // 
            // btnDoCmd
            // 
            this.btnDoCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnDoCmd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnDoCmd.FlatAppearance.BorderSize = 0;
            this.btnDoCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoCmd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoCmd.ForeColor = System.Drawing.Color.White;
            this.btnDoCmd.Location = new System.Drawing.Point(659, 384);
            this.btnDoCmd.Name = "btnDoCmd";
            this.btnDoCmd.Size = new System.Drawing.Size(118, 54);
            this.btnDoCmd.TabIndex = 27;
            this.btnDoCmd.Text = "Izvrši\r\nnaredbu\r\n";
            this.btnDoCmd.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::JPPP.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 38);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // OperatorOption2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDoCmd);
            this.Controls.Add(this.dgvCommands);
            this.Name = "OperatorOption2";
            this.Text = "OperatorOption2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommands;
        private System.Windows.Forms.Button btnDoCmd;
        private System.Windows.Forms.Button btnRefresh;
    }
}