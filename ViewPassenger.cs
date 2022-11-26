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

            if (PidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "update PassengerTbl set PassName='" + PnameTb.Text + "' , Passport='" + PpassTb.Text + "', PassAd =  '" + PaddTb.Text + "', PassNat='" + NatCb.SelectedItem.ToString() + "', PassGend= '" + GendCb.SelectedItem.ToString() + "', PassPhone= '" + PphoneTB.Text + "' where PassID= " + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connect);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Information Updated Successfully");
                    Connect.Close();
                    Populate();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }

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

        private void DeleteView_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "")
            {
                MessageBox.Show("Enter the Passenger to Delete");
            } else
            {
                try
                {
                    Connect.Open();
                    string query = "Delete from PassengerTbl where PassId=" + PidTb.Text + ";";
                    SqlCommand command = new SqlCommand(query, Connect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Connect.Close();
                    Populate();

                } catch(Exception except)
                {
                    MessageBox.Show(except.Message);
                }

            }
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PaddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            NatCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            GendCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();



        }

        private void ResetView_Click(object sender, EventArgs e)
        {
            PidTb.Text = " ";
            PnameTb.Text = " ";
            PpassTb.Text = " ";
            PaddTb.Text = " ";
            PnameTb.Text = " ";
            PphoneTB.Text = " ";
            NatCb.Items.Remove(NatCb.SelectedItem);
            GendCb.Items.Remove(GendCb.SelectedItem);


        }
    }
}
