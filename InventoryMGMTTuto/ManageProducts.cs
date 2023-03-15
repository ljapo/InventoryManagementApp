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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tonyl\Documents\Inventory.db.mdf;Integrated Security=True;Connect Timeout=30");

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
                CategoryCombo.ValueMember = "CategoryName"; // Povezujemo to dvoje valjda
                CategoryCombo.DataSource = dataTable; // I dajemo odakle da crpi podatke
                selectCombo.ValueMember = "CategoryName";
                selectCombo.DataSource = dataTable;
                Con.Close();
            }

            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {

            fillcategory();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTable values('" + productIDInput.Text + "','" + productNameInput.Text + "','" + productQtyInput.Text + "','" + productPriceInput.Text + "','" + descriptionInput.Text + "' , '" + CategoryCombo.SelectedValue.ToString() + "')", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully added!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        void populate() // Funkcija za prikaz na grid viewu
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
        void filterByCategory() // Funkcija za prikaz na grid viewu
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (productIDInput.Text == "")
            {
                MessageBox.Show("Enter the users phone number!", "Error");
            }
            else
            {
                Con.Open();
                string myQuerry = "delete from ProductTable where ProductId='" + productIDInput.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuerry, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully deleted.");
                Con.Close();
                populate();
            }
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                productIDInput.Text = productsGridView.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                productNameInput.Text = productsGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                productQtyInput.Text = productsGridView.Rows[e.RowIndex].Cells["ProductQty"].Value.ToString();
                productPriceInput.Text = productsGridView.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString();
                descriptionInput.Text = productsGridView.Rows[e.RowIndex].Cells["ProductDescription"].Value.ToString();
                CategoryCombo.SelectedValue = productsGridView.Rows[e.RowIndex].Cells["ProductCategory"].Value.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            productIDInput.Text = "";
            productNameInput.Text = "";
            productQtyInput.Text = "";
            productPriceInput.Text = "";
            descriptionInput.Text = "";
            CategoryCombo.SelectedValue = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTable set ProductId='" + productIDInput.Text + "', ProductName='" + productNameInput.Text + "', ProductQty='" + productQtyInput.Text + "', ProductPrice='" + productPriceInput.Text + "', ProductDescription='" + descriptionInput.Text + "', ProductCategory='" + CategoryCombo.SelectedValue.ToString() + "' where ProductId='" + productIDInput.Text + "'", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully edited!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void selectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
