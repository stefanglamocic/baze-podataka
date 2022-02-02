
namespace JPPP.CustomControls
{
    partial class CustomRocketsTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(67, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 15);
            this.label.TabIndex = 0;
            this.label.Text = "label1";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox.Location = new System.Drawing.Point(190, 7);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(67, 27);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "0";
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // CustomRocketsTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Name = "CustomRocketsTextBox";
            this.Size = new System.Drawing.Size(271, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.Label label;
    }
}
