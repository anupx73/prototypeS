using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeS.Customers
{
    public partial class CustomersCreatePage : UserControl, IPrototypeUX
    {
        public event Action<object, SmartSearchEventArgs> EventContinueBookFired;

        public CustomersCreatePage()
        {
            InitializeComponent();
            SetupPageMargins();
            lnkContinueBook.Location = new Point(1013, 3);
        }
        
        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelWarning, ref panelNav);
            panelBody.Margin = new Padding(7, 0, 7, 0);
        }

        public void EnableNewBookingView(bool newBooking)
        {
            lnkSave.Visible = !newBooking;
            lnkNew.Visible = !newBooking;
            lnkContinueBook.Visible = newBooking;
        }

        private void lnkContinueBook_Click(object sender, EventArgs e)
        {
            if (EventContinueBookFired != null)
            {
                EventContinueBookFired(this, null);
            }
        }
    }
}
