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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void Populate()
        {
            Connect.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void BackView_Click(object sender, EventArgs e)
        {
            AddPassenger passenger = new AddPassenger();
            passenger.Show();
            this.Hide();
        }
    }
}
