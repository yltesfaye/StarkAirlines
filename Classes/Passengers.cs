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
    public class Passengers : Sql, IPopulate
    {
        private RichTextBox _passengerId;    
        private RichTextBox _passengerName;
        private RichTextBox _passportNumber;
        private RichTextBox _passengerAddress;
        private ComboBox _country;
        private ComboBox _gender;
        private RichTextBox _phoneNumber;
        private DataGridView _passengerGrid;

        public Passengers(RichTextBox passengerId, RichTextBox passengerName, RichTextBox passportNumber, RichTextBox passportAddress, ComboBox country, ComboBox gender, RichTextBox phoneNumber, DataGridView grid)
        {
            _passengerId = passengerId;
            _passengerName = passengerName;
            _passportNumber = passportNumber;
            _passengerAddress = passportAddress;
            _country = country;
            _gender = gender;
            _phoneNumber = phoneNumber;
            PassengerGrid = grid;
        }
        public Passengers(RichTextBox passengerId)
        {
            this._passengerId = passengerId;
        }

        public Passengers(RichTextBox passengerId, RichTextBox passengerName, RichTextBox passportNumber, RichTextBox passportAddress, ComboBox country, ComboBox gender, RichTextBox phoneNumber)
        {
            _passengerId = passengerId;
            _passengerName = passengerName;
            _passportNumber = passportNumber;
            _passengerAddress = passportAddress;
            _country = country;
            _gender = gender;
            _phoneNumber = phoneNumber;
        }

        public Passengers(DataGridView passengerGrid)
        {
            _passengerGrid = passengerGrid;
        }

        public RichTextBox PassengerId { get => _passengerId; set => _passengerId = value; }
        public RichTextBox PassengerName { get => _passengerName; set => _passengerName = value; }
        public RichTextBox PassportNumber { get => _passportNumber; set => _passportNumber = value; }
        public RichTextBox PassengerAddress { get => _passengerAddress; set => _passengerAddress = value; }
        public ComboBox Country { get => _country; set => _country = value; }
        public ComboBox Gender { get => _gender; set => _gender = value; }
        public RichTextBox PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public DataGridView PassengerGrid { get => _passengerGrid; set => _passengerGrid = value; }


        public void Delete()
        {
            if (PassengerId.Text == "")
            {
                MessageBox.Show("Enter the Passenger to Delete");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "Delete from PassengerTbl where PassId=" + PassengerId.Text + ";";
                    SqlCommand command = new SqlCommand(query, Connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Connection.Close();
                    populate(PassengerGrid);

                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }

            }
        }

        public void populate(DataGridView dataGrid)
        {
            Connection.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
            Connection.Close();
        }
        public void Add()
        {
            if (PassengerId.Text == "" || PassengerAddress.Text == "" || PassportNumber.Text == "" || PhoneNumber.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "Insert into PassengerTbl values (" + PassengerId.Text + ", '" + PassengerName.Text + "', '" + PassengerAddress.Text + "', '" + PassportNumber.Text + "', '" + Country.SelectedItem.ToString() + "', '" + Gender.SelectedItem.ToString() + "', '" + PhoneNumber.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Connection.Close();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }
                Reset();

            }
        }
            public void  Fill(RichTextBox Id, RichTextBox Name, RichTextBox PassNumber, RichTextBox Address, ComboBox Count, ComboBox Gen)
        {
            Id.Text = PassengerGrid.SelectedRows[0].Cells[0].Value.ToString();
            Name.Text = PassengerGrid.SelectedRows[0].Cells[1].Value.ToString();
            PassNumber.Text = PassengerGrid.SelectedRows[0].Cells[2].Value.ToString();
            Address.Text = PassengerGrid.SelectedRows[0].Cells[3].Value.ToString();
            Count.SelectedItem = PassengerGrid.SelectedRows[0].Cells[4].Value.ToString();
            Gen.SelectedItem = PassengerGrid.SelectedRows[0].Cells[5].Value.ToString();
        }
        public void Update()
        {
            if (PassengerId.Text == "" || PassengerName.Text == "" || PassengerName.Text == "" || PassengerAddress.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "update PassengerTbl set PassName='" + PassengerName.Text + "' , Passport='" + PassportNumber.Text + "', PassAd =  '" + PassengerAddress.Text + "', PassNat='" + Country.SelectedItem.ToString() + "', PassGend= '" + Gender.SelectedItem.ToString() + "', PassPhone= '" + PhoneNumber.Text + "' where PassID= " + PassengerId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Information Updated Successfully");
                    Connection.Close();
                    populate(PassengerGrid);

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }
        } 

        public void Reset()
        {
            PassengerId.Text = " ";
            PassengerName.Text = " ";
            PassportNumber.Text = " ";
            PassengerAddress.Text = " ";
            PassengerName.Text = " ";
            PhoneNumber.Text = " ";
            Country.Items.Remove(Country.SelectedItem);
            Gender.Items.Remove(Country.SelectedItem);

        }
    }
}
