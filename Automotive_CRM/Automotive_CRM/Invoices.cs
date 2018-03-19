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
            try
            {
                Console.WriteLine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\Data\" + idTextBox + ".txt")); //why doesn't this work
                StreamWriter sw;
                using (sw = File.CreateText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"~\Data\" + idTextBox + ".txt")))
                {
                    sw.WriteLine("Owner's PN: " + customer_phoneTextBox.Text);
                    sw.WriteLine("Part Used: " + parts_usedTextBox.Text);
                    sw.WriteLine("Labor Cost: " + labor_costTextBox.Text);
                    sw.WriteLine("Fluids Checked: " + fluid_checkCheckBox.Text);
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
}
