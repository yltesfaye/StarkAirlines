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

            Passengers passenger = new Passengers(PassId, PassName, PassportTb, PassAdd, NationalityCb, GenderCb, PhoneTb);

            passenger.Add();
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

        private void Back_clikc(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
