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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            Flights flight = new Flights(); 
            flight.Populate(FlightDGV);
        }

        private void BackFlight(object sender, EventArgs e)
        {
            FlightTbl AddFlight = new FlightTbl();
            AddFlight.Show();
            this.Hide();
        }

    

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flights flight = new Flights();
            flight.Fill_Table(FcodeTb,SeatNum,SrcCb,DstCb);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights();
            flights.Delete(FcodeTb, FlightDGV);
        }

        private void Update_Click(object sender, EventArgs e)

        {
            Flights flights = new Flights();
            flights.Update(FcodeTb, SeatNum, SrcCb, DstCb, FDate, FlightDGV);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights();
            flights.Reset(FcodeTb, SeatNum, SrcCb, DstCb);
           
        }
    }
}
