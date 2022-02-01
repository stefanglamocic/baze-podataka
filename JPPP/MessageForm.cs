using JPPP.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPPP
{
    public partial class MessageForm : GeneralForm
    {
        int operatorID, meteorologistID;
        public MessageForm(int operatorID, int meteorologistID)
        {
            InitializeComponent();
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            this.btnOK.Hide();
            this.lblTop.Text = "Pošalji poruku";
            this.tbMessage.BackColor = Colors.mainPanel;
            this.tbMessage.ReadOnly = false;
            this.operatorID = operatorID;
            this.meteorologistID = meteorologistID;
        }

        public MessageForm(int msgID) 
        {
            InitializeComponent();
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            this.btnClose.Hide();
            this.btnCancel.Hide();
            this.btnSend.Hide();
            
            this.lblTop.Text = "Poruka";
            this.tbMessage.BackColor = Colors.mainPanel;
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ForeColor = Colors.labelColor;
            this.tbMessage.Text = MessageDataAccess.GetMessageContent(msgID).Content;
            this.tbMessage.SelectionStart = 0;
        }

        private void tbMessage_Enter(object sender, EventArgs e)
        {
            if (tbMessage.Text == "Poruka...")
            {
                tbMessage.Text = "";
                tbMessage.ForeColor = Colors.labelColor;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Model.Message msg = new Model.Message()
            {
                Content = tbMessage.Text,
                Date = DateTime.Now,
                OperatorID = operatorID,
                MeteorologistID = meteorologistID
            };

            MessageDataAccess.SendNewMessage(msg);
            CloseOutForm();
        }

        private void tbMessage_Leave(object sender, EventArgs e)
        {
            if (tbMessage.Text == "")
            {
                tbMessage.Text = "Poruka...";
                tbMessage.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void CloseOutForm()
        {
            if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["OperatorOption1"] as Forms.OperatorOption1).FillMeteorologistsGrid();
            }
            this.Close();
        }
    }
}
