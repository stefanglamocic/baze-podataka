
namespace JPPP
{
    partial class CommandInfoForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDoCmd = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAzimuth = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.lblRocketsInfo = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(464, 28);
            // 
            // lblTop
            // 
            this.lblTop.Size = new System.Drawing.Size(464, 28);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(380, 0);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(408, 0);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(436, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(267, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Poništi";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDoCmd
            // 
            this.btnDoCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnDoCmd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnDoCmd.FlatAppearance.BorderSize = 0;
            this.btnDoCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoCmd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoCmd.ForeColor = System.Drawing.Color.White;
            this.btnDoCmd.Location = new System.Drawing.Point(85, 360);
            this.btnDoCmd.Name = "btnDoCmd";
            this.btnDoCmd.Size = new System.Drawing.Size(112, 36);
            this.btnDoCmd.TabIndex = 26;
            this.btnDoCmd.Text = "Izvrši";
            this.btnDoCmd.UseVisualStyleBackColor = false;
            this.btnDoCmd.Click += new System.EventHandler(this.btnDoCmd_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl1.Location = new System.Drawing.Point(29, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 21);
            this.lbl1.TabIndex = 28;
            this.lbl1.Text = "Azimut:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(269, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Elevacija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Rakete:";
            // 
            // lblAzimuth
            // 
            this.lblAzimuth.AutoSize = true;
            this.lblAzimuth.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzimuth.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAzimuth.Location = new System.Drawing.Point(100, 64);
            this.lblAzimuth.Name = "lblAzimuth";
            this.lblAzimuth.Size = new System.Drawing.Size(29, 18);
            this.lblAzimuth.TabIndex = 31;
            this.lblAzimuth.Text = "123";
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevation.ForeColor = System.Drawing.Color.DarkGray;
            this.lblElevation.Location = new System.Drawing.Point(350, 64);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(29, 18);
            this.lblElevation.TabIndex = 32;
            this.lblElevation.Text = "123";
            // 
            // lblRocketsInfo
            // 
            this.lblRocketsInfo.AutoSize = true;
            this.lblRocketsInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRocketsInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRocketsInfo.Location = new System.Drawing.Point(119, 148);
            this.lblRocketsInfo.Name = "lblRocketsInfo";
            this.lblRocketsInfo.Size = new System.Drawing.Size(49, 54);
            this.lblRocketsInfo.TabIndex = 33;
            this.lblRocketsInfo.Text = "123\r\naosoaf\r\nasfl";
            // 
            // CommandInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 430);
            this.Controls.Add(this.lblRocketsInfo);
            this.Controls.Add(this.lblElevation);
            this.Controls.Add(this.lblAzimuth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnDoCmd);
            this.Controls.Add(this.btnCancel);
            this.Name = "CommandInfoForm";
            this.Text = "CommandInfoForm";
            this.Load += new System.EventHandler(this.CommandInfoForm_Load);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnDoCmd, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblAzimuth, 0);
            this.Controls.SetChildIndex(this.lblElevation, 0);
            this.Controls.SetChildIndex(this.lblRocketsInfo, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDoCmd;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAzimuth;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Label lblRocketsInfo;
    }
}