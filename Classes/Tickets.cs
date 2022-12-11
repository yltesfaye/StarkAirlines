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
    public class Tickets : Sql, IPopulate, IFillPassenger, IFillFlight, IFetchPassengers
    {
        private string _ticketId;
        private string _flightCode;     
        private string _passengerID;
        private string _passengerName;
        private string _passengerPassport;
        private string _passengerNationality;
        private string _ticketAmount;
        private RichTextBox ticketId;
        private RichTextBox _passengerNameRTB;
        private RichTextBox _nationality;
        private RichTextBox _amount;
        private RichTextBox _passportNumber;

        public string TicketId { get => _ticketId; set => _ticketId = value; }
        public string FlightCode { get => _flightCode; set => _flightCode = value; }
        public string PassengerID { get => _passengerID; set => _passengerID = value; }
        public string PassengerName { get => _passengerName; set => _passengerName = value; }
        public string PassengerPassport { get => _passengerPassport; set => _passengerPassport = value; }
        public string PassengerNationality { get => _passengerNationality; set => _passengerNationality = value; }
        public string TicketAmount { get => _ticketAmount; set => _ticketAmount = value; }
        public RichTextBox TicketId1 { get => ticketId; set => ticketId = value; }
        public RichTextBox PassengerNameRTB { get => _passengerNameRTB; set => _passengerNameRTB = value; }
        public RichTextBox Nationality { get => _nationality; set => _nationality = value; }
        public RichTextBox Amount { get => _amount; set => _amount = value; }
        public RichTextBox PassportNumber { get => _passportNumber; set => _passportNumber = value; }


        public Tickets()
        {

        }
        public Tickets(string ticketId, string flightCode, string passengerID, string passengerName, string passengerPassport, string passengerNationality, string ticketAmount)
        {
            TicketId = ticketId;
            FlightCode = flightCode;
            PassengerID = passengerID;
            PassengerName = passengerName;
            PassengerPassport = passengerPassport;
            PassengerNationality = passengerNationality;
            TicketAmount = ticketAmount;
           
        }
        public Tickets(RichTextBox ticketId, RichTextBox PassengerName, RichTextBox Nationality, RichTextBox Amount, RichTextBox PassportNumber)
        {
            this.PassengerNameRTB = PassengerName;
            this.Nationality = Nationality;
            this.Amount = Amount;
            this.PassportNumber = PassportNumber;
        }


        public void Book()
        {
            if (TicketId == "" || PassengerName == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "Insert into TicketTbl values (" + TicketId + ", '" + FlightCode + "', '" + PassengerID + "', '" + PassengerName + "', '" + PassengerPassport + "', '" + PassengerNationality + "', " + TicketAmount + ")";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ticket Booked Successfully");

                    Connection.Close();
                    

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }

        }

        public void Reset()
        {
            TicketId1.Clear();
            PassengerNameRTB.Clear();
            Nationality.Clear();
            Amount.Clear();
            PassportNumber.Clear();
        }

        public void populate(DataGridView data)
        {
            Connection.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            data.DataSource = ds.Tables[0];
            Connection.Close();
        }

        public void fillPassengerInformation(ComboBox PassengerID)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl", Connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("PassId", typeof(int));
            table.Load(reader);
            PassengerID.ValueMember = "PassId";
            PassengerID.DataSource = table;
            Connection.Close();
        }

        public void fillFlightCode(ComboBox FlightCode)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", Connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Fcode", typeof(string));
            table.Load(reader);
            FlightCode.ValueMember = "Fcode";
            FlightCode.DataSource = table;
            Connection.Close();
        }
        private string PName;
        private string Ppass;
        private string Pnat;
        public void fetchPassenger(ComboBox FPassengerId, RichTextBox FPassengerName, RichTextBox FPassengerPassword, RichTextBox FPassengerNationality)
        {

            Connection.Open();

            string query = "select * from PassengerTbl where PassId=" + FPassengerId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                PName = dr["PassName"].ToString();
                Ppass = dr["Passport"].ToString();
                Pnat = dr["PassAd"].ToString();
                FPassengerName.Text = PName;
                FPassengerPassword.Text = Ppass;
                FPassengerNationality.Text = Pnat;

                //  page = Convert.ToInt32(dr["PassAd"].ToString());

            }

            Connection.Close();

        }
       

    }
}
