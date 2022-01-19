
namespace JPPP
{
    partial class StationInfoForm
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblStationID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperatorInfo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(505, 28);
            // 
            // lblTop
            // 
            this.lblTop.Size = new System.Drawing.Size(505, 28);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(421, 0);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(449, 0);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(477, 0);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl1.Location = new System.Drawing.Point(23, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 21);
            this.lbl1.TabIndex = 27;
            this.lbl1.Text = "Stanica:";
            // 
            // lblStationID
            // 
            this.lblStationID.AutoSize = true;
            this.lblStationID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationID.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStationID.Location = new System.Drawing.Point(85, 50);
            this.lblStationID.Name = "lblStationID";
            this.lblStationID.Size = new System.Drawing.Size(29, 18);
            this.lblStationID.TabIndex = 28;
            this.lblStationID.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Strijelac:";
            // 
            // lblOperatorInfo
            // 
            this.lblOperatorInfo.AutoSize = true;
            this.lblOperatorInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblOperatorInfo.Location = new System.Drawing.Point(56, 99);
            this.lblOperatorInfo.Name = "lblOperatorInfo";
            this.lblOperatorInfo.Size = new System.Drawing.Size(0, 18);
            this.lblOperatorInfo.TabIndex = 30;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(197, 206);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 28);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // StationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 246);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblOperatorInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStationID);
            this.Controls.Add(this.lbl1);
            this.Name = "StationInfoForm";
            this.Text = "StationInfoForm";
            this.Load += new System.EventHandler(this.StationInfoForm_Load);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.lblStationID, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblOperatorInfo, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblStationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperatorInfo;
        private System.Windows.Forms.Button btnOK;
    }
}