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
    public partial class Inventory : Form
    {
        string _initialSearch;
        public Inventory(string str)
        {
            InitializeComponent();
            _initialSearch = str;
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRM_DatabaseDataSet);

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRM_DatabaseDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.cRM_DatabaseDataSet.Parts);
            SearchDB(_initialSearch);
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchDB(searchBox.Text);
        }

        private void SearchDB(string str)
        {
            if (str != "")
            {
                this.partsTableAdapter.SearchDesc(this.cRM_DatabaseDataSet.Parts, str);
            }
            else
            {
                this.partsTableAdapter.Fill(this.cRM_DatabaseDataSet.Parts);
            }
        }

        private bool VerifyForms()
        {
            nameTextBox.Text = Utilities.Capitalize(nameTextBox.Text);
            compatible_makesTextBox.Text = Utilities.Capitalize(compatible_makesTextBox.Text);
            if (Utilities.DecimalFormat(priceTextBox.Text) != "")
            {
                priceTextBox.Text = Utilities.DecimalFormat(priceTextBox.Text);
            }
            try
            {
                int.Parse(stockTextBox.Text);
                int.Parse(on_orderTextBox.Text);
                decimal.Parse(priceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("The stock, on order, and price boxes must be valid numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (stockTextBox.Text == "")
            {
                MessageBox.Show("The stock box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (on_orderTextBox.Text == "")
            {
                MessageBox.Show("The on order box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (priceTextBox.Text == "")
            {
                MessageBox.Show("The on price box must be filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you'd like to delete the current item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (result)
            {
                case DialogResult.Yes:
                    partsBindingSource.RemoveCurrent();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyForms())
                {
                    partsBindingSource.AddNew();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error! {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        this.partsBindingSource.EndEdit();
                        this.partsTableAdapter.Update(this.cRM_DatabaseDataSet.Parts);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void viewCompatibleCarsBtn_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles(compatible_makesTextBox.Text);
            vehicles.ShowDialog();
        }
    }
}
