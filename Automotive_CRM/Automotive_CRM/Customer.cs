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
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRM_DatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.cRM_DatabaseDataSet.Customers);

        }
    }
}
