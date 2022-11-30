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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\DSU\OneDrive - Dakota State University\Documents\AirlineDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetLogin_Click(object sender, EventArgs e)
        {
            UidTb.Text = " ";
            PassTb.Text = " ";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //if(UidTb.Text == " " || PassTb.Text == " ")
            //{
            //    MessageBox.Show("Enter The Username and Password");
            //} else if(UidTb.Text == "Admin" && PassTb.Text == "Admin")
            //{
            //    Home home = new Home();
            //    home.Show();
            //    this.Hide();
            //} else
            //{
            //    MessageBox.Show("Wrong Username and Password");
            //}
            SqlCommand cmd = new SqlCommand("select * from UserLogins where UserName=@UserName and Password=@Password", Connect);
            cmd.Parameters.AddWithValue("@UserName", UidTb.Text);
            cmd.Parameters.AddWithValue("@Password", PassTb.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Connect.Open();
            int i = cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                Home login = new Home();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
            }


            Connect.Close();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
                
        }

        private void CreatAcc_Click(object sender, EventArgs e)
        {
            CreateAccount create = new CreateAccount();
            create.Show();
            this.Hide();
        }
    }
}
