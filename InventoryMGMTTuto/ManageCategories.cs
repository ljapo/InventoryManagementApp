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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tonyl\Documents\Inventory.db.mdf;Integrated Security=True;Connect Timeout=30");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            categoryIDInput.Text = "";
            categoryNameInput.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTable values('" + categoryIDInput.Text + "','" + categoryNameInput.Text + "')", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully added!");
                Con.Close();
                populate();
                categoryIDInput.Text = "";
                categoryNameInput.Text = "";
            }
            catch
            {

            }
        }
        void populate() // Funkcija za pravljenje i dodavanje korisnika/admina
        {
            try
            {
                Con.Open();

                string myQuerry = "select * from CategoryTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                var dataSet = new DataSet(); // Novi skup podataka ?
                dataAdapter.Fill(dataSet);

                categoriesGridView.DataSource = dataSet.Tables[0]; // Izvor informacija na Grid Viewu

                Con.Close();
            }
            catch
            {

            }
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (categoryIDInput.Text == "")
            {
                MessageBox.Show("Enter the category ID!", "Error");
            }
            else
            {
                Con.Open();
                string myQuerry = "delete from CategoryTable where CategoriesID='" + categoryIDInput.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuerry, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully deleted.");
                Con.Close();
                populate();
                categoryIDInput.Text = "";
                categoryNameInput.Text = "";
            }
        }

        private void categoriesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                categoryIDInput.Text = categoriesGridView.Rows[e.RowIndex].Cells["CategoriesID"].Value.ToString();
                categoryNameInput.Text = categoriesGridView.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTable set CategoryName='" + categoryNameInput.Text + "' where CategoriesID='" + categoryIDInput.Text + "'", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer successfully edited!");
                Con.Close();
                populate();
                categoryIDInput.Text = "";
                categoryNameInput.Text = "";
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
