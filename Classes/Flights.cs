using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;


namespace StarkAirlines
{
    public class Flights : Sql, IPopulate
    {

        RichTextBox _flightCode;
        RichTextBox _seatNum;
        ComboBox _source;
        ComboBox _destination;
        DateTimePicker _date;
        DataGridView _flightGrid;

        public RichTextBox FlightCode { get => _flightCode; set => _flightCode = value; }
        public RichTextBox SeatNum { get => _seatNum; set => _seatNum = value; }
        public ComboBox Source { get => _source; set => _source = value; }
        public ComboBox Destination { get => _destination; set => _destination = value; }
        public DateTimePicker Date { get => _date; set => _date = value; }
        public DataGridView FlightGrid { get => _flightGrid; set => _flightGrid = value; }

        public Flights()
        {

        }

        public Flights(RichTextBox flightCode, RichTextBox seatNum, ComboBox source, ComboBox destination, DateTimePicker date, DataGridView flightgrid)
        {
            FlightCode = flightCode;
            SeatNum = seatNum;
            Source = source;
            Destination = destination;
            Date = date;
            FlightGrid = flightgrid;
        }

        public void Fill_Table(RichTextBox FlightCode, RichTextBox SeatNum,ComboBox Source ,ComboBox Destination)
        {
            FlightCode.Text = FlightGrid.SelectedRows[0].Cells[0].Value.ToString();
            SeatNum.Text = FlightGrid.SelectedRows[0].Cells[1].Value.ToString();
            Source.SelectedItem = FlightGrid.SelectedRows[0].Cells[2].Value.ToString();
            Destination.Text = FlightGrid.SelectedRows[0].Cells[3].Value.ToString();
            Destination.SelectedItem = FlightGrid.SelectedRows[0].Cells[4].Value.ToString();
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

        public void Delete(RichTextBox FlightCdoe, DataGridView FlightGrid)
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
                    string query = "Delete from FlightTbl where Fcode='" + FlightCode.Text + "';";
                    SqlCommand command = new SqlCommand(query, Connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Connection.Close();
                    populate(FlightGrid);

                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }

            }

        }

        public void Update(RichTextBox FlightCode, RichTextBox SeatNum, ComboBox Source, ComboBox Destination, DateTimePicker Date, DataGridView FlightGrid )
        {
            if (FlightCode.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information;");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "update FlightTbl set Fsrc='" + Source.Text + "' , FDest='" + Destination.SelectedItem.ToString() + "', FDate =  '" + Date.Value.Date.ToString() + "', FCap=" + SeatNum.Text + " where Fcode= '" + FlightCode.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Connection);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Information Updated Successfully");
                    Connection.Close();
                    populate(FlightGrid);

                }
                catch (Exception Excpt)
                {
                    MessageBox.Show(Excpt.Message);
                }

            }

        }

        public void Back()
        {
            FlightTbl AddFlight = new FlightTbl();
            AddFlight.Show();
        }
        public void Reset(RichTextBox FlightCode, RichTextBox SeatNum, ComboBox Source, ComboBox Destination)
        {
            FlightCode.Text = " ";
            SeatNum.Text = " ";
            Source.Items.Remove(Source.SelectedItem);
            Destination.Items.Remove(Destination.SelectedItem);
        }

        public void Populate(DataGridView FlightGrid)
        {
            Connection.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            FlightGrid.DataSource = ds.Tables[0];
            Connection.Close();
        }
    }
}
