
namespace JPPP
{
    partial class AddStationForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMunicipality = new System.Windows.Forms.Label();
            this.tbMunicipality = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.cbOperators = new JPPP.CustomControls.CustomComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(503, 28);
            // 
            // lblTop
            // 
            this.lblTop.Size = new System.Drawing.Size(503, 28);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(419, 0);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(447, 0);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(475, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(363, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Poništi";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(225, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 36);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMunicipality
            // 
            this.lblMunicipality.AutoSize = true;
            this.lblMunicipality.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipality.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMunicipality.Location = new System.Drawing.Point(30, 89);
            this.lblMunicipality.Name = "lblMunicipality";
            this.lblMunicipality.Size = new System.Drawing.Size(59, 18);
            this.lblMunicipality.TabIndex = 26;
            this.lblMunicipality.Text = "Opština:";
            // 
            // tbMunicipality
            // 
            this.tbMunicipality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.tbMunicipality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMunicipality.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMunicipality.ForeColor = System.Drawing.Color.White;
            this.tbMunicipality.Location = new System.Drawing.Point(33, 110);
            this.tbMunicipality.Name = "tbMunicipality";
            this.tbMunicipality.Size = new System.Drawing.Size(188, 28);
            this.tbMunicipality.TabIndex = 25;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPlace.Location = new System.Drawing.Point(30, 205);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(55, 18);
            this.lblPlace.TabIndex = 28;
            this.lblPlace.Text = "Mjesto:";
            // 
            // tbPlace
            // 
            this.tbPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.tbPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlace.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlace.ForeColor = System.Drawing.Color.White;
            this.tbPlace.Location = new System.Drawing.Point(33, 226);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(188, 28);
            this.tbPlace.TabIndex = 27;
            // 
            // cbOperators
            // 
            this.cbOperators.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbOperators.ForeColor = System.Drawing.SystemColors.Info;
            this.cbOperators.Location = new System.Drawing.Point(299, 168);
            this.cbOperators.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbOperators.Name = "cbOperators";
            this.cbOperators.Padding = new System.Windows.Forms.Padding(1);
            this.cbOperators.Size = new System.Drawing.Size(165, 30);
            this.cbOperators.TabIndex = 29;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.DarkGray;
            this.lblOperator.Location = new System.Drawing.Point(296, 147);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(141, 18);
            this.lblOperator.TabIndex = 30;
            this.lblOperator.Text = "Registrovani strijelac:";
            // 
            // AddStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 446);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.cbOperators);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.lblMunicipality);
            this.Controls.Add(this.tbMunicipality);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "AddStationForm";
            this.Text = "AddStationForm";
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tbMunicipality, 0);
            this.Controls.SetChildIndex(this.lblMunicipality, 0);
            this.Controls.SetChildIndex(this.tbPlace, 0);
            this.Controls.SetChildIndex(this.lblPlace, 0);
            this.Controls.SetChildIndex(this.cbOperators, 0);
            this.Controls.SetChildIndex(this.lblOperator, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMunicipality;
        private System.Windows.Forms.TextBox tbMunicipality;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox tbPlace;
        private CustomControls.CustomComboBox cbOperators;
        private System.Windows.Forms.Label lblOperator;
    }
}