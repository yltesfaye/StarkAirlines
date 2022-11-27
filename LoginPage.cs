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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

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
            if(UidTb.Text == " " || PassTb.Text == " ")
            {
                MessageBox.Show("Enter The Username and Password");
            } else if(UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Wrong Username and Password");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
