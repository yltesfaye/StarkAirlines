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
            Connect.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl", Connect);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("TId", typeof(string));
            table.Load(reader);
            TidCb.ValueMember = "TId";
            TidCb.DataSource = table;
            Connect.Close();
        }
        private void Populate()
        {
            Connect.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }
        private void fetchFcode()
        {
            Connect.Open();

            string query = "select * from TicketTbl where TID=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                FcodeTb.Text = dr["Fcode"].ToString();
               
                //  page = Convert.ToInt32(dr["PassAd"].ToString());

            }

            Connect.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Cancellation_Load(object sender, EventArgs e)
        {
            FillTicketID();
            Populate();

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
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter the Flight to Delete");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "Delete from TicketTbl where TId='" + TidCb.SelectedValue.ToString() + "';";
                    SqlCommand command = new SqlCommand(query, Connect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Connect.Close();
                    Populate();

                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }

            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (CanId.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "Insert into CancelTbl values (" + CanId.Text + ", '" + TidCb.SelectedValue.ToString() + "', '" + FcodeTb.Text + "', '" + CancelDate.Value.Date + "')"; 
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ticket Cancelled Successfully");

                    Connect.Close();
                    Populate();
                    deleteTicket();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CanId.Text = " ";
            FcodeTb.Text = " ";
        }
    }
}
