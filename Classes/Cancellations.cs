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
    public class Cancellations: Sql, IPopulate
    {
        private RichTextBox _cancellationId;
        private RichTextBox _flightCode;
        private ComboBox _ticketID;
        private DateTimePicker _cancelDate;
        private DataGridView _cancelGrid;

        public Cancellations(RichTextBox cancellationId, RichTextBox flightCode, ComboBox ticketID, DateTimePicker cancelDate)
        {
            _cancellationId = cancellationId;
            _flightCode = flightCode;
            _ticketID = ticketID;
            _cancelDate = cancelDate;
        }
        public Cancellations(RichTextBox cancellationId, RichTextBox flightCode, ComboBox ticketID, DateTimePicker cancelDate, DataGridView cancelGrid)
        {
            _cancellationId = cancellationId;
            _flightCode = flightCode;
            _ticketID = ticketID;
            _cancelDate = cancelDate;
            _cancelGrid = cancelGrid;
        }

        public Cancellations(ComboBox ticketID)
        {
            _ticketID = ticketID;
        }

        public Cancellations(RichTextBox flightCode, ComboBox ticketID)
        {
            _flightCode = flightCode;
            _ticketID = ticketID;
        }

        public RichTextBox CancellationId { get => _cancellationId; set => _cancellationId = value; }
        public RichTextBox FlightCode { get => _flightCode; set => _flightCode = value; }
        public ComboBox TicketID { get => _ticketID; set => _ticketID = value; }
        public DateTimePicker CancelDate { get => _cancelDate; set => _cancelDate = value; }
        public DataGridView CancelGrid { get => _cancelGrid; set => _cancelGrid = value; }

        public void FetchCode(RichTextBox Fcode)
        {
            Connection.Open();

            string query = "select * from TicketTbl where TID=" + TicketID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                Fcode.Text = dr["Fcode"].ToString();

            }

            Connection.Close();
        }
        public void populate(DataGridView CancelGrid)
        {
            Connection.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            CancelGrid.DataSource = ds.Tables[0];
            Connection.Close();
        }
       
        public void DeleteTicket()
        {
            if (FlightCode.Text == "")
            {
                MessageBox.Show("Enter the Flight to Delete");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "Delete from TicketTbl where TId='" + TicketID.SelectedValue.ToString() + "';";
                    SqlCommand command = new SqlCommand(query, Connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Connection.Close();
                    populate(CancelGrid);

                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }

            }
        }
        public void FillTicketId()
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl", Connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("TId", typeof(string));
            table.Load(reader);
            TicketID.ValueMember = "TId";
            TicketID.DataSource = table;
            Connection.Close();
        }
        public void Cancel()
        {
            if (CancellationId.Text == "" || FlightCode.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "Insert into CancelTbl values (" + CancellationId.Text + ", '" + TicketID.SelectedValue.ToString() + "', '" + FlightCode.Text + "', '" + CancelDate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ticket Cancelled Successfully");

                    Connection.Close();
                    populate(CancelGrid);
                    DeleteTicket();

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }
        }
        public void Clear()
        {
            CancellationId.Text = " ";
            FlightCode.Text = " ";
            //TicketID.Items.Remove(TicketID.SelectedItem);
            CancelDate.ResetText();
            
        }   
    }
}
