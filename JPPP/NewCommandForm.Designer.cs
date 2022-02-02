
namespace JPPP
{
    partial class NewCommandForm
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
            this.lblAzimuth = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.tbAzimuth = new System.Windows.Forms.TextBox();
            this.tbElevation = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewCommand = new System.Windows.Forms.Button();
            this.pnlRockets = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(455, 28);
            // 
            // lblTop
            // 
            this.lblTop.Size = new System.Drawing.Size(455, 28);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(371, 0);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(399, 0);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(427, 0);
            // 
            // lblAzimuth
            // 
            this.lblAzimuth.AutoSize = true;
            this.lblAzimuth.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzimuth.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAzimuth.Location = new System.Drawing.Point(41, 59);
            this.lblAzimuth.Name = "lblAzimuth";
            this.lblAzimuth.Size = new System.Drawing.Size(56, 18);
            this.lblAzimuth.TabIndex = 27;
            this.lblAzimuth.Text = "Azimut:";
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevation.ForeColor = System.Drawing.Color.DarkGray;
            this.lblElevation.Location = new System.Drawing.Point(254, 59);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(66, 18);
            this.lblElevation.TabIndex = 28;
            this.lblElevation.Text = "Elevacija:";
            // 
            // tbAzimuth
            // 
            this.tbAzimuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.tbAzimuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAzimuth.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAzimuth.ForeColor = System.Drawing.Color.White;
            this.tbAzimuth.Location = new System.Drawing.Point(103, 55);
            this.tbAzimuth.Name = "tbAzimuth";
            this.tbAzimuth.Size = new System.Drawing.Size(63, 28);
            this.tbAzimuth.TabIndex = 29;
            this.tbAzimuth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAzimuth_KeyPress);
            // 
            // tbElevation
            // 
            this.tbElevation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.tbElevation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbElevation.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbElevation.ForeColor = System.Drawing.Color.White;
            this.tbElevation.Location = new System.Drawing.Point(326, 55);
            this.tbElevation.Name = "tbElevation";
            this.tbElevation.Size = new System.Drawing.Size(63, 28);
            this.tbElevation.TabIndex = 30;
            this.tbElevation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAzimuth_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(245, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Poništi";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnNewCommand
            // 
            this.btnNewCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnNewCommand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnNewCommand.FlatAppearance.BorderSize = 0;
            this.btnNewCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCommand.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCommand.ForeColor = System.Drawing.Color.White;
            this.btnNewCommand.Location = new System.Drawing.Point(92, 382);
            this.btnNewCommand.Name = "btnNewCommand";
            this.btnNewCommand.Size = new System.Drawing.Size(112, 36);
            this.btnNewCommand.TabIndex = 32;
            this.btnNewCommand.Text = "Izdaj";
            this.btnNewCommand.UseVisualStyleBackColor = false;
            this.btnNewCommand.Click += new System.EventHandler(this.btnNewCommand_Click);
            // 
            // pnlRockets
            // 
            this.pnlRockets.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlRockets.Location = new System.Drawing.Point(66, 151);
            this.pnlRockets.Name = "pnlRockets";
            this.pnlRockets.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRockets.Size = new System.Drawing.Size(265, 225);
            this.pnlRockets.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(78, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Rakete:";
            // 
            // NewCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlRockets);
            this.Controls.Add(this.btnNewCommand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbElevation);
            this.Controls.Add(this.tbAzimuth);
            this.Controls.Add(this.lblElevation);
            this.Controls.Add(this.lblAzimuth);
            this.Name = "NewCommandForm";
            this.Text = "NewCommandForm";
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.lblAzimuth, 0);
            this.Controls.SetChildIndex(this.lblElevation, 0);
            this.Controls.SetChildIndex(this.tbAzimuth, 0);
            this.Controls.SetChildIndex(this.tbElevation, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnNewCommand, 0);
            this.Controls.SetChildIndex(this.pnlRockets, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAzimuth;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.TextBox tbAzimuth;
        private System.Windows.Forms.TextBox tbElevation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewCommand;
        private System.Windows.Forms.FlowLayoutPanel pnlRockets;
        private System.Windows.Forms.Label label1;
    }
}