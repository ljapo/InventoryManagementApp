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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tonyl\Documents\Inventory.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populateOrders() // Funkcija za prikaz na grid viewu
        {
            try
            {
                Con.Open();

                string myQuerry = "select * from OrderTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                var dataSet = new DataSet(); // Novi skup podataka ?
                dataAdapter.Fill(dataSet);

                viewGridView.DataSource = dataSet.Tables[0]; // Izvor informacija na Grid Viewu

                Con.Close();
            }
            catch
            {

            }
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void viewGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            {
                printDocument1.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Order Summary", new Font("Century", 23, FontStyle.Bold), Brushes.Black, new PointF(230, 10));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
