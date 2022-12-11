using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarkAirlines
{
    class RichPassword : RichTextBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on ES_PASSWORD
                var cp = base.CreateParams;
                cp.Style |= 0x20;
                return cp;
            }
        }
    }
}
