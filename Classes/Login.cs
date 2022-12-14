using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
    using System.Data;
namespace StarkAirlines
{
    public class Login : Sql
    {
        private string _username;
        private string _password;
        private RichTextBox _usernameRTB;
        private RichTextBox _passwordRTB;


        public Login (String Username, string Password)
        {
            _username = Username;
            _password = Password;
        }

        public Login(RichTextBox Username, RichTextBox Password) {
            _usernameRTB = Username;
            _passwordRTB = Password;
        }
        public string Username { get { return _username; } set { value = _username; } }
        public string Password { get { return _password; } set { value = _password; } }

        public RichTextBox UsernameRTB { get { return _usernameRTB; } set { value = _usernameRTB; } }
        public RichTextBox PasswordRTB { get { return _passwordRTB; } set { value = _passwordRTB; } }

        public void Reset()
        {
            UsernameRTB.Clear();
            PasswordRTB.Clear();
        }


        public void loginAccount()
        {
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from UserLogins where UserName=@UserName and Password=@Password", Connection);
                    cmd.Parameters.AddWithValue("@UserName", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful!");
                        Home login = new Home();
                        login.Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Username and Password");
                    }


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
