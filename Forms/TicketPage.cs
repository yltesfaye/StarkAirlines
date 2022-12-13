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
    public partial class TicketPage : Form
    {
        public TicketPage()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");

        
       
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {


           Tickets newTicket = new Tickets (Tid.Text, FCode.SelectedValue.ToString(), PidCb.SelectedValue.ToString(), PNameTb.Text, PpassTb.Text, PnatTb.Text, PamtTb.Text);
            newTicket.Book();
            newTicket.Reset(Tid, PamtTb);

            
        }

        private void ResetView_Click(object sender, EventArgs e)
        {

            Tickets ClearTicket = new Tickets(Tid, PNameTb, PnatTb, PamtTb, PpassTb);
            ClearTicket.Reset(Tid,PamtTb);
            
        }

        private void BackView_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

       

        private void Ticket_Load(object sender, EventArgs e)
        {
            Tickets log = new Tickets();
            log.populate(TicketDGV);
            log.fillPassengerInformation(PidCb);
            log.fillFlightCode(FCode);


        }

        private void Pid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Connect.open
            Tickets tickets = new Tickets();
            tickets.fetchPassenger(PidCb, PNameTb, PpassTb, PnatTb);
        }
    }
}
