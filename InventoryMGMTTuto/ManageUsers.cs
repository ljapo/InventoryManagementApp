using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMGMTTuto
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tonyl\Documents\Inventory.db.mdf;Integrated Security=True;Connect Timeout=30");
        
        void populate() // Funkcija za pravljenje i dodavanje korisnika/admina
        {
            try
            {
                Con.Open();

                string myQuerry = "select * from UserTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                var dataSet = new DataSet(); // Novi skup podataka ?
                dataAdapter.Fill(dataSet);

                usersGridView.DataSource = dataSet.Tables[0]; // Izvor informacija na Grid Viewu

                Con.Close();
            }
            catch
            {

            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //ADD
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + userNameInput.Text + "','" + fullNameInput.Text + "','" + passwordInput.Text + "','" + telephoneInput.Text + "')", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully added!");
                Con.Close();
                populate();
            }
            catch
            {

            }

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e) //DELETE
        {
            if (telephoneInput.Text == "")
            {
                MessageBox.Show("Enter the users phone number!","Error");
            }
            else
            {
                Con.Open();
                string myQuerry = "delete from UserTable where Phone='" + telephoneInput.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuerry,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted.");
                Con.Close();
                populate();
            }
        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                userNameInput.Text = usersGridView.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                fullNameInput.Text = usersGridView.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                passwordInput.Text = usersGridView.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                telephoneInput.Text = usersGridView.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTable set Username='"+userNameInput.Text+"', FullName='"+fullNameInput.Text+"', Password='"+passwordInput.Text+"' where Phone='"+telephoneInput.Text+"'", Con); // Con je konekcija na koju bazu iznad nam se tako zove to
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully edited!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            userNameInput.Text = "";
            fullNameInput.Text = "";
            passwordInput.Text = "";
            passwordInput.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
