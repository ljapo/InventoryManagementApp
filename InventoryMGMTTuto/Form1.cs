


using System.Data;
using System.Data.SqlClient;

namespace InventoryMGMTTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tonyl\Documents\Inventory.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PasswordTab.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTab.UseSystemPasswordChar = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            UsernameTab.Text = "";
            PasswordTab.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTable where Username='"+UsernameTab.Text+"' and Password='"+PasswordTab.Text+"'",Con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            if (dta.Rows[0][0].ToString() == "1")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            
            Con.Close();
        }
    }
}