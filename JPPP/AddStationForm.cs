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
    public partial class AddStationForm : GeneralForm
    {
        public AddStationForm()
        {
            InitializeComponent();
            this.lblTop.Text = "Dodaj novu stanicu";
            this.btnMinimize.Hide();
            this.btnMaximize.Hide();
            AddUserForm.AddingFormChangeColors(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMunicipality.TextLength == 0)
                    throw new ArgumentException("Niste unijeli opstinu. Molimo pokusajte ponovo.");
                if (tbPlace.TextLength == 0)
                    throw new ArgumentException("Niste unijeli mjesto. Molimo pokusajte ponovo.");

                //insert station
                CloseOutForm();
            }
            catch(Exception exception)
            {
                new ErrorMessageForm(exception.Message).ShowDialog();
            }
        }

        private void CloseOutForm()
        {
            if (System.Windows.Forms.Application.OpenForms["GeneralMenuForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["AdminWorkerOption2"] as Forms.AdminWorkerOption2).FillStationsGrid();
            }
            this.Close();
        }
    }
}
