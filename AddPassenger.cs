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
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }



        private void AddPassenger_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassAdd.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information;");
            } else
            {
                try
                {
                    Connect.Open();
                   string query = "Insert into PassengerTbl values (" + PassId.Text + ", '" + PassName.Text + "', '" + PassAdd.Text + "', '" + PassportTb.Text + "', '" + NationalityCb.SelectedItem.ToString() + "', '" + GenderCb.SelectedItem.ToString() + "', '" + PhoneTb.Text + "')";
                   SqlCommand cmd = new SqlCommand(query, Connect);
                   cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Connect.Close();
               
                } catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void ViewPassengers_Click(object sender, EventArgs e)
        {
            ViewPassenger view = new ViewPassenger();
            view.Show();
            this.Hide();
        }
    }
}
