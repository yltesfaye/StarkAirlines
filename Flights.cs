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


namespace StarkAirlines
{
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");


        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fcode.Text == "" || Fsource.Text == "" || Fdest.Text == "" || Fdate.Text == "" || Fseatnum.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "Insert into FlightTbl values (" + Fcode.Text + ", '" + Fsource.SelectedItem.ToString() + "', '" + Fdest.SelectedItem.ToString() + "', '" + Fdate.Value.ToString() + "', '" + Fseatnum.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    Connect.Close();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }
        }

        private void Flights_Load(object sender, EventArgs e)
        {

        }
    }
}
