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

        
        private void label3_Click(object sender, EventArgs e)
        {

        }
                

        private void Update_Click(object sender, EventArgs e)
        {
            Passengers passenger = new Passengers(PidTb, PnameTb, PpassTb, PaddTb, NatCb, GendCb, PphoneTB, PassengerDGV);

            passenger.Update();

        }
    

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
        }

        private void BackView_Click(object sender, EventArgs e)
        {
            AddPassenger passenger = new AddPassenger();
            passenger.Show();
            this.Hide();
        }

        private void DeleteView_Click(object sender, EventArgs e)
        {
            
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Passengers passenger = new Passengers(PidTb, PnameTb, PpassTb, PaddTb, NatCb, GendCb, PphoneTB, PassengerDGV);
            passenger.Fill();
           



        }

        private void ResetView_Click(object sender, EventArgs e)
        {
            Passengers passenger = new Passengers(PidTb, PnameTb, PpassTb, PaddTb, NatCb, GendCb, PphoneTB, PassengerDGV);
            passenger.Reset();

        }
    }
}
