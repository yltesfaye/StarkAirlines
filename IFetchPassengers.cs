using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StarkAirlines
{
    public interface IFetchPassengers
    {
        void fetchPassenger(ComboBox PassengerId, RichTextBox PassengerName, RichTextBox PassengerPassword, RichTextBox PassengerNationality);
    }
}
