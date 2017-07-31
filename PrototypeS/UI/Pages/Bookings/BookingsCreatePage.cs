using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeS.Bookings
{
    public partial class BookingsCreatePage : UserControl, IPrototypeUX
    {
        public BookingsCreatePage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelWarning, ref panelNav);
            tlpBookingDetails.Margin = new Padding(7, 0, 7, 0);
        }

    }
}
