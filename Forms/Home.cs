using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarkAirlines
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Flights_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void Passengers_Click(object sender, EventArgs e)
        {
            AddPassenger passenger = new AddPassenger();
            passenger.Show();
            this.Hide();
        }

        private void Tickets_click(object sender, EventArgs e)
        {
            TicketPage ticket = new TicketPage();
            ticket.Show();
            this.Hide();
        }

        private void Cancel_click(object sender, EventArgs e)
        {
            Cancellation cancel = new Cancellation();
            cancel.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
