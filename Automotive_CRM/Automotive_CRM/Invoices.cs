using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Automotive_CRM
{
    public partial class Invoices : Form
    {
        string _initialSearch;
        public Invoices(string str)
        {
            InitializeComponent();
            _initialSearch = str;
        }

        decimal laborCost, partCost, total;

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRM_DatabaseDataSet);
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRM_DatabaseDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.cRM_DatabaseDataSet.Invoices);
            SearchDB(_initialSearch);
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchDB(searchBox.Text);
        }

        private void SearchDB(string str)
        {
            if(str != "")
            {
                this.invoicesTableAdapter.SearchDesc(this.cRM_DatabaseDataSet.Invoices, str);
            }
            else
            {
                this.invoicesTableAdapter.Fill(this.cRM_DatabaseDataSet.Invoices);
            }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForms())
            {
                try
                {
                    Console.WriteLine(Path.Combine(AppContext.BaseDirectory + @"\Data\" + idTextBox.Text + ".txt")); //why doesn't this work
                    StreamWriter sw;
                    using (sw = File.CreateText(Path.Combine(AppContext.BaseDirectory + @"\Data\" + idTextBox.Text + ".txt")))
                    {
                        sw.WriteLine("Owner's PN: " + customer_phoneTextBox.Text);
                        sw.WriteLine("Part Used: " + parts_usedTextBox.Text);
                        sw.WriteLine("Labor Cost: " + labor_costTextBox.Text);
                        sw.WriteLine("Fluids Checked: " + fluid_checkCheckBox.Checked);
                        sw.WriteLine("=====================");
                        sw.WriteLine("Total: " + totalTextBox.Text);
                        sw.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForms())
            {
                DialogResult result = MessageBox.Show("Are you sure you'd like to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                switch (result)
                {
                    case DialogResult.Yes:
                        this.Validate();
                        this.invoicesBindingSource.EndEdit();
                        this.invoicesTableAdapter.Update(this.cRM_DatabaseDataSet.Invoices);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void CalculateCost()
        {
            total = partCost + laborCost;
            totalTextBox.Text = total.ToString("c");
        }

        private bool ValidateForms()
        {
            parts_usedTextBox.Text = Utilities.Capitalize(parts_usedTextBox.Text);
            if (Utilities.PhoneNumberFormat(customer_phoneTextBox.Text) == string.Empty)
            {
                MessageBox.Show("The phone number box must be completely filled out! (It must contain only numbers)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                laborCost = decimal.Parse(labor_costTextBox.Text);
            }
            catch
            {
                MessageBox.Show("The labor cost isn't a valid number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                partCost = (decimal)this.partsTableAdapter1.PriceSearch(parts_usedTextBox.Text);
                MessageBox.Show(partCost.ToString());
            }
            catch
            {
                MessageBox.Show(string.Format("\"{0}\" was not found!", parts_usedTextBox.Text), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            customer_phoneTextBox.Text = Utilities.PhoneNumberFormat(customer_phoneTextBox.Text);
            CalculateCost();
            return true;
        }
        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((AppContext.BaseDirectory + @"\Data\"));
        }

        private void viewCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(customer_phoneTextBox.Text);
            customer.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you'd like to delete the current item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (result)
            {
                case DialogResult.Yes:
                    this.invoicesBindingSource.RemoveCurrent();
                    break;
                case DialogResult.No:
                    break;

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForms())
            {
                this.invoicesBindingSource.AddNew();
            }
        }
    }
}
