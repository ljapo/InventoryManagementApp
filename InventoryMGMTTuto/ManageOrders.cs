using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMGMTTuto
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tonyl\Documents\Inventory.db.mdf;Integrated Security=True;Connect Timeout=30");


        void populateCustomers() // Funkcija za prikaz na grid viewu
        {
            try
            {
                Con.Open();

                string myQuerry = "select * from CustomerTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                var dataSet = new DataSet(); // Novi skup podataka ?
                dataAdapter.Fill(dataSet);

                customersGridView.DataSource = dataSet.Tables[0]; // Izvor informacija na Grid Viewu

                Con.Close();
            }
            catch
            {

            }
        }
        void populateProducts() // Funkcija za prikaz na grid viewu
        {
            try
            {
                Con.Open();

                string myQuerry = "select * from ProductTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                var dataSet = new DataSet(); // Novi skup podataka ?
                dataAdapter.Fill(dataSet);

                productsGridView.DataSource = dataSet.Tables[0]; // Izvor informacija na Grid Viewu

                Con.Close();
            }
            catch
            {

            }
        }

        void fillcategory()
        {
            string querry = "select * from CategoryTable"; // Uzimamo sve iz tabele kategorija
            SqlCommand cmd = new SqlCommand(querry, Con); // pravimo komandu za sql konekciju
            SqlDataReader rdr; // Definiramo čitača podataka

            try
            {
                Con.Open();
                DataTable dataTable = new DataTable(); // Definiramo novu tablicu podataka
                dataTable.Columns.Add("CategoryName", typeof(string)); // Dodajemo joj kolonu iz sql CatName i tip
                rdr = cmd.ExecuteReader(); // Pokrenemo čitač
                dataTable.Load(rdr); // Proslijedimo ga tablici podataka
                // CategoryCombo.ValueMember = "CategoryName"; // Povezujemo to dvoje valjda
                // CategoryCombo.DataSource = dataTable; // I dajemo odakle da crpi podatke
                selectCombo.ValueMember = "CategoryName";
                selectCombo.DataSource = dataTable;
                Con.Close();
            }

            catch
            {

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            table.Columns.Add("num", typeof(int));
            table.Columns.Add("product", typeof(string));
            table.Columns.Add("qty", typeof(int));
            table.Columns.Add("uPrice", typeof(decimal));
            table.Columns.Add("totalPrice", typeof(decimal));
            populateCustomers();
            populateProducts();
            fillcategory();
        }

        private void customersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIDInput.Text = customersGridView.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            customerNameInput.Text = customersGridView.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
        }

        private void selectCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string myQuerry = "select * from ProductTable where ProductCategory='" + selectCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                var dataSet = new DataSet(); // Novi skup podataka ?
                dataAdapter.Fill(dataSet);

                productsGridView.DataSource = dataSet.Tables[0]; // Izvor informacija na Grid Viewu

                Con.Close();
            }
            catch
            {

            }
        }
        void reload() // Funkcija za prikaz na grid viewu
        {
            try
            {
                Con.Open();

                string myQuerry = "select * from ProductTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                var dataSet = new DataSet(); // Novi skup podataka ?
                dataAdapter.Fill(dataSet);

                productsGridView.DataSource = dataSet.Tables[0]; // Izvor informacija na Grid Viewu

                Con.Close();
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reload();
        }
        DataTable table = new DataTable();
        int num = 0;
        int uPrice = 0;
        int totalPrice = 0;
        int qty = 0;
        string product;
        int flag = 0;
        int sum;
        int stock;
        int id;
        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(productsGridView.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                product = productsGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                // qty = Convert.ToInt32(quantityInput.Text);
                uPrice = Convert.ToInt32(productsGridView.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString());
                // totalPrice = qty * uPrice;
                stock = Convert.ToInt32(productsGridView.Rows[e.RowIndex].Cells["ProductQty"].Value.ToString());
                flag = 1;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (quantityInput.Text == "")
            {
                MessageBox.Show("Enter the proper quantity");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product");
            }
            else if (stock < Convert.ToInt32(quantityInput.Text)) 
            {
                MessageBox.Show("Not enough quantity.");
            }
            else
            {
                num ++;

                

                qty = Convert.ToInt32(quantityInput.Text);
                totalPrice = qty * uPrice;
                table.Rows.Add(num, product, qty, uPrice, totalPrice);
                orderGridView.DataSource = table;
                flag = 0;
                sum = sum + totalPrice;
                totalPrice = 0;
            }
            sum = sum + totalPrice;
            sumResult.Text = "€" + sum.ToString();
        }

        private void sumResult_Click(object sender, EventArgs e)
        {

        }

        void updateProduct()
        {

            
            int newQty = stock - Convert.ToInt32(quantityInput.Text);
            if (newQty< 0)
            {
                MessageBox.Show("Operation Failed");
            }
            else
            {
                Con.Open();
                string querry = "update ProductTable set ProductQty='" + newQty + "' where ProductId='" + id + "'";
                SqlCommand cmd = new SqlCommand(querry, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateProducts();
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            if(orderIDInput.Text == "" || customerIDInput.Text == "" || 
                customerNameInput.Text == "" || sumResult.Text == "")
            {
                MessageBox.Show("Fill the data correctly!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrderTable values('" + customerIDInput.Text + "','" + orderIDInput.Text +"','"+ customerNameInput.Text + "','" + dateTimeInput.Text + "','" + sumResult.Text + "')", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order successfully added!");
                    Con.Close();
                    updateProduct();
                }
                catch
                {

                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
