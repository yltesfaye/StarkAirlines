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
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
        }

        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");


        private void FillTicketID()
        {
            Cancellations cancelticket = new Cancellations(TidCb);
            cancelticket.FillTicketId();
        }
        private void Populate()
        {
            Cancellations cancelticket = new Cancellations(CanId, FcodeTb, TidCb, CancelDate);
            cancelticket.populate(CancelDGV);
        }
        private void fetchFcode()
        {
            Cancellations cancelticket = new Cancellations(FcodeTb,TidCb);
            cancelticket.FetchCode(FcodeTb);
        }
    
    private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Cancellation_Load(object sender, EventArgs e)
        {
            Cancellations cancelticket = new Cancellations(CanId, FcodeTb, TidCb, CancelDate, CancelDGV);
            cancelticket.FillTicketId();
            cancelticket.populate(CancelDGV);

        }

        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchFcode();
        }

        private void BackView_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void deleteTicket()
        {

            Cancellations cancelticket = new Cancellations(CanId, FcodeTb, TidCb, CancelDate, CancelDGV);
            cancelticket.DeleteTicket();
        }
            
            private void Cancel_Click(object sender, EventArgs e)
        {
            Cancellations cancelticket = new Cancellations(CanId, FcodeTb, TidCb,CancelDate, CancelDGV);
            cancelticket.Cancel();
            cancelticket.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CanId.Text = " ";
            FcodeTb.Text = " ";
        }

        private void TidCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
