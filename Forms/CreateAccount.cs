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
            Account newAccount = new Account(NameCA, UidCA, PassCA.Text, ManCodeTB);

            newAccount.CreateAccount();
            this.Hide();
            
        }

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the MessageBox is shown
            if (MessageBox.Show("Are you sure you want to close the form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the closing of the form
                e.Cancel = true;
            }
        }

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if the form was closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Show the MessageBox
                if (MessageBox.Show("Are you sure you want to close the form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // Re-open the form
                    this.Show();
                }
            }
        }
    }
}
