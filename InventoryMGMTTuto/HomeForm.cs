using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMGMTTuto
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCategories categories= new ManageCategories();
            categories.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCustomers customers = new ManageCustomers();
            customers.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageProducts products = new ManageProducts();
            products.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewOrders orders= new ViewOrders();
            orders.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageOrders manage = new ManageOrders();
            manage.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
