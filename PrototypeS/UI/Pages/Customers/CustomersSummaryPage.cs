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
    public partial class CustomersSummaryPage : UserControl, IPrototypeUX
    {
        public event Action<object, SmartSearchEventArgs> EventBookAppointmentFired;
        public event Action<object, SmartSearchEventArgs> EventViewAllCustomerFired;
        public event Action<object, SmartSearchEventArgs> EventEditCustomerFired;
        public event Action<object, SmartSearchEventArgs> EventBuyPackageFired;

        public CustomersSummaryPage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelNav, ref panelNav);

            tlpBody.Margin = new Padding(7, 0, 0, 0);
            panelBodyLeft.Margin = new Padding(0);

            tlpCustDetails.Margin = new Padding(0);
            panelCustPersonal.Margin = new Padding(0);
            panelCustBusiness.Margin = new Padding(0);

            tlpBusinessList.Margin = new Padding(0);
            labelListHeading1.Margin = new Padding(0);
            labelListHeading2.Margin = new Padding(0);
            labelListHeading3.Margin = new Padding(0);

            gridBookingList.Margin = new Padding(0, 0, 0, 5);
            gridPackList.Margin = new Padding(0, 0, 0, 5);
        }

        private void lnkViewAllCustomer_Click(object sender, EventArgs e)
        {
            if (EventViewAllCustomerFired != null)
            {
                EventViewAllCustomerFired(this, null);
            }
        }

        private void lnkBookAppoint_Click(object sender, EventArgs e)
        {
            if (EventBookAppointmentFired != null)
            {
                EventBookAppointmentFired(this, null);
            }
        }

        private void lnkCustEdit_Click(object sender, EventArgs e)
        {
            if (EventEditCustomerFired != null)
            {
                EventEditCustomerFired(this, null);
            }
        }

        private void lnkBuyPackage_Click(object sender, EventArgs e)
        {
            if (EventBuyPackageFired != null)
            {
                EventBuyPackageFired(this, null);
            }
        }
    }
}
