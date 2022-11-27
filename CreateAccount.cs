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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
        public int AccountCounter = 1;
        private void CreatAcc_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || PassCA.Text == "" || NameCA.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connect.Open();
                    AccountCounter++;
                    string query = "Insert into UserLogins values ("+AccountCounter +", '" + UidCA.Text + "', '" + PassCA.Text + "', '" + NameCA.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Connect.Close();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }
            
        }
    }
}
