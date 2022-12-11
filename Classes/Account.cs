using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StarkAirlines
{
    public class Account : Sql
    {
        private RichTextBox _name;
        private RichTextBox _username;
        private RichTextBox _managercode;
        private string _password;
        


        public Account(RichTextBox Name, RichTextBox Username, string Password)
        {
            _name = Name;
            _username = Username;
            _password = Password;
        }
        public Account(RichTextBox Name, RichTextBox Username, string Password, RichTextBox ManagerCode )
        {
            _name = Name;
            _username = Username;
            _password = Password;
            _managercode = ManagerCode;
        }
        public RichTextBox Name { get { return _name; } }
        public RichTextBox Username { get { return _username; } }
        public string Password { get { return _password; } }

        public RichTextBox Managercode { get => _managercode; set => _managercode = value; }

        public void CreateAccount()
        {
            if (Username.Text == "" || Password == "" || Name.Text == "" || Managercode.Text == "")
            {
                MessageBox.Show("Missing Information;");

            } else if(Managercode.Text != "402")
            {
                MessageBox.Show("Incorrect Mananger Code!");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "Insert into UserLogins values ('" + Username.Text + "', '" + Password + "', '" + Name.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    LoginPage login = new LoginPage();
                    login.Show();

                    Connection.Close();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }
        }
    }
}
