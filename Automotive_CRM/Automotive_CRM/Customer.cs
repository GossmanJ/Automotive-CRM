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
    public partial class Customer : Form
    {
        List<string> names = new List<string>();
        public Customer()
        {
            InitializeComponent();
        }
        
        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRM_DatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.cRM_DatabaseDataSet.Customers);
        }

        private bool VerifyForms() //Verifies each form and displays the appropriate errors
        {
            phone_numberTextBox.Text = Utilities.PhoneNumberFormat(phone_numberTextBox.Text);
            nameTextBox.Text = Utilities.Capitalize(nameTextBox.Text);
            addressTextBox.Text = Utilities.Capitalize(addressTextBox.Text);
            if (!Utilities.EmailCheck(email_addressTextBox.Text))
            {
                MessageBox.Show("Invalid Email!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("The name box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Utilities.PhoneNumberFormat(phone_numberTextBox.Text) == string.Empty)
            {
                MessageBox.Show("The phone number box must be completely filled out! (It must contain only numbers)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (alternate_phoneTextBox.Text != "")
            {
                if (Utilities.PhoneNumberFormat(alternate_phoneTextBox.Text) != "")
                {
                    alternate_phoneTextBox.Text = Utilities.PhoneNumberFormat(alternate_phoneTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Alternate phone number box isn't completely filled out! (It must only contain numbers)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (addressTextBox.Text == "")
            {
                MessageBox.Show("The address box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
                        this.customersBindingSource.EndEdit();
                        this.customersTableAdapter.Update(this.cRM_DatabaseDataSet.Customers);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                this.customersTableAdapter.SearchDesc(this.cRM_DatabaseDataSet.Customers, searchBox.Text);
            }
            else
            {
                this.customersTableAdapter.Fill(this.cRM_DatabaseDataSet.Customers);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyForms())
                {
                    customersBindingSource.AddNew();
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
                    customersBindingSource.RemoveCurrent();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
