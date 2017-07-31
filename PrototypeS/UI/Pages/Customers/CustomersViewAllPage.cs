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
    public partial class CustomersViewAllPage : UserControl, IPrototypeUX
    {
        public event Action<object, SmartSearchEventArgs> EventNewCustomerFired;

        public CustomersViewAllPage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelNav, ref panelNav);
            panelGridSearch.Margin = new Padding(7, 0, 7, 0);
        }

        private void lnkNew_Click(object sender, EventArgs e)
        {
            if (EventNewCustomerFired != null)
            {
                EventNewCustomerFired(this, null);
            }
        }
    }
}
