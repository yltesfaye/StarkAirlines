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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void Populate()
        {
            Connect.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }
        private void fillPassenger()
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl", Connect);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("PassId", typeof(int));
            table.Load(reader);
            PidCb.ValueMember = "PassId";
            PidCb.DataSource = table;
            Connect.Close();
        }
        private void fillFlightCode()
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", Connect);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Fcode", typeof(string));
            table.Load(reader);
            FCode.ValueMember = "Fcode";
            FCode.DataSource = table;
            Connect.Close();
        }
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
        //properites
        string pname, ppass, padd, pnat;
        int page;

        private void Book_Click(object sender, EventArgs e)
        {


            Tickets newTicket = new Tickets(sti); 

            if (Tid.Text == "" || PNameTb.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "Insert into TicketTbl values (" + Tid.Text + ", '" + FCode.SelectedValue.ToString() + "', '" + PidCb.SelectedValue.ToString() + "', '" + PNameTb.Text + "', '" + PpassTb.Text + "', '" + PnatTb.Text + "', " + PamtTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
           
                    MessageBox.Show("Ticket Booked Successfully");

                    Connect.Close();
                    Populate();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }
        }

        private void ResetView_Click(object sender, EventArgs e)
        {
            Tid.Text = " ";
            PNameTb.Text = " ";
            PnatTb.Text = " ";
            PamtTb.Text = " ";
            PpassTb.Text = " ";
            
            
        }

        private void BackView_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void fetchPassenger()
        {
            Connect.Open();

            string query = "select * from PassengerTbl where PassId=" + PidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows) {

                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassAd"].ToString();
                PNameTb.Text = pname;
                PpassTb.Text = ppass;
                PnatTb.Text = pnat;

              //  page = Convert.ToInt32(dr["PassAd"].ToString());

            }

            Connect.Close();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            Populate();


        }

        private void Pid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Connect.open
            fetchPassenger();
        }
    }
}
