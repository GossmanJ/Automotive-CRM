using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_CRM
{
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRM_DatabaseDataSet);

        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRM_DatabaseDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.cRM_DatabaseDataSet.Vehicle);
        }

        private void SearchDB(string str)
        {
            if (str != "")
            {
                this.vehicleTableAdapter.SearchDesc(this.cRM_DatabaseDataSet.Vehicle, str);
            }
            else
            {
                this.vehicleTableAdapter.Fill(this.cRM_DatabaseDataSet.Vehicle);
            }
        }

        private bool VerifyForms() //Verifies each form and displays the appropriate errors
        {
            owner_nameTextBox.Text = Utilities.Capitalize(owner_nameTextBox.Text);
            makeTextBox.Text = Utilities.Capitalize(makeTextBox.Text);
            modelTextBox.Text = Utilities.Capitalize(modelTextBox.Text);
            if (owner_nameTextBox.Text == "")
            {
                MessageBox.Show("The name box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Utilities.PhoneNumberFormat(owner_numberTextBox.Text) == string.Empty)
            {
                MessageBox.Show("The phone number box must be completely filled out! (It must contain only numbers)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (makeTextBox.Text == "")
            {
                MessageBox.Show("The make box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (modelTextBox.Text == "")
            {
                MessageBox.Show("The model box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (yearTextBox.Text == "")
            {
                MessageBox.Show("The year box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (date_recievedDateTimePicker.Text == "")
            {
                MessageBox.Show("The year box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            owner_numberTextBox.Text = Utilities.PhoneNumberFormat(owner_numberTextBox.Text);
            return true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (VerifyForms())
            {
                DialogResult result = MessageBox.Show("Are you sure you'd like to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                switch (result)
                {
                    case DialogResult.Yes:
                        this.Validate();
                        this.vehicleBindingSource.EndEdit();
                        this.vehicleTableAdapter.Update(this.cRM_DatabaseDataSet.Vehicle);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchDB(searchBox.Text);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyForms())
                {
                    vehicleBindingSource.AddNew();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error! {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you'd like to delete the current item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (result)
            {
                case DialogResult.Yes:
                    vehicleBindingSource.RemoveCurrent();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
