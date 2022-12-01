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
            Login Account = new Login(UidTb, PassTb);
            Account.Reset();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login Account = new Login(UidTb.Text, PassTb.Text);
            Account.loginAccount();
            this.Hide();
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
