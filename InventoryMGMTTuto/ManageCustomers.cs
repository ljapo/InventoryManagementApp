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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tonyl\Documents\Inventory.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) // ADD
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTable values('" + customerIDInput.Text + "','" +customerNameInput.Text + "','" + customerPhoneInput.Text + "')", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully added!");
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

        private void ManageCostumers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e) // DELETE
        {
            if (customerPhoneInput.Text == "")
            {
                MessageBox.Show("Enter the users phone number!", "Error");
            }
            else
            {
                Con.Open();
                string myQuerry = "delete from CustomerTable where CustomerPhone='" + customerPhoneInput.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuerry, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted.");
                Con.Close();
                populate();
            }
        }

        private void customersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) // GRID VIEW
        {
            if (e.RowIndex >= 0)
            {
                customerIDInput.Text = customersGridView.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                customerNameInput.Text = customersGridView.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                customerPhoneInput.Text = customersGridView.Rows[e.RowIndex].Cells["CustomerPhone"].Value.ToString();
                
               // Con.Open();
               // SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTable where CustomerId='"+customerIDInput.Text+"'",Con);
               // DataTable dt = new DataTable();
               // sda.Fill(dt);
               // orderLabel.Text = dt.Rows[0][0].ToString();

               // SqlDataAdapter sda3 = new SqlDataAdapter("select Sum from OrderTable where CustomerId='" + customerIDInput.Text + "'", Con);
                //DataTable dt3 = new DataTable();
               /// sda3.Fill(dt3);
               // amountLabel.Text = dt3.Rows[0][0].ToString();

               // SqlDataAdapter sda2 = new SqlDataAdapter("select Max(DateTime) from OrderTable where CustomerId='" + customerIDInput.Text + "'", Con);
               // DataTable dt2 = new DataTable();
               // sda2.Fill(dt2);
               // dateLabel.Text = dt2.Rows[0][0].ToString();


               // Con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e) // CLEAR
        {
            customerIDInput.Text = "";
            customerNameInput.Text = "";
            customerPhoneInput.Text = "";

        }

        private void button2_Click(object sender, EventArgs e) // EDIT
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTable set CustomerID='" + customerIDInput.Text + "', CustomerName='" + customerNameInput.Text + "' where CustomerPhone='" + customerPhoneInput.Text + "'", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer successfully edited!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void amountLabel_Click(object sender, EventArgs e)
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
