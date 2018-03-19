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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("");
            customer.ShowDialog();
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles("");
            vehicles.ShowDialog();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory("");
            inventory.ShowDialog();
        }

        private void invoicesBtn_Click(object sender, EventArgs e)
        {
            Invoices invoices = new Invoices("");
            invoices.ShowDialog();
        }
    }
}
