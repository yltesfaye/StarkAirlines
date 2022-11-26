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

        private void Populate()
        {
            Connect.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void BackFlight(object sender, EventArgs e)
        {
            FlightTbl AddFlight = new FlightTbl();
            AddFlight.Show();
            this.Hide();
        }

    

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            //PROBLEM HERER
                   FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
                   SeatNum.Text = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
             SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
                     DstCb.Text = FlightDGV.SelectedRows[0].Cells[3].Value.ToString();
             DstCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
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
                    string query = "Delete from FlightTbl where Fcode='" + FcodeTb.Text + "';";
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

        private void Update_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "update FlightTbl set Fsrc='" + SrcCb.Text + "' , FDest='" + DstCb.SelectedItem.ToString() + "', FDate =  '" + FDate.Value.Date.ToString() + "', FCap=" + SeatNum.Text + " where Fcode= '" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Connect);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Information Updated Successfully");
                    Connect.Close();
                    Populate();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = " ";
            SeatNum.Text = " ";
            SrcCb.Items.Remove(SrcCb.SelectedItem);
            DstCb.Items.Remove(DstCb.SelectedItem);
        }
    }
}
