using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototypeS.UI;

namespace PrototypeS.Customers
{
    public partial class CustomersHomePage : UserControl
    {
        public event Action<object, SmartSearchEventArgs> EventSearchFired;
        public event Action<object, SmartSearchEventArgs> EventCreateNewFired;
        public event Action<object, SmartSearchEventArgs> EventViewAllFired;

        public CustomersHomePage()
        {
            InitializeComponent();

            tlpBase.Margin = new Padding(0);
            panelSmartSearch.Margin = new Padding(0);
            tlpContent.Margin = new Padding(20);
            tlpRecentCust.Margin = new Padding(0);
            panelCustActions.Margin = new Padding(0);

            for (int i = 0; i <= 3; i++)
            {
                lbRecentCust.Items.Add(new ListBoxExItem(i+100, 
                                                         "Kia P.", 
                                                         "Phone: 7287827827, Last Service: Pedicare, Last seen: 20/01/2016, Style: P0892 / 2298X", 
                                                         Properties.Resources.user_female_small));
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (EventSearchFired != null)
                {
                    EventSearchFired(this, null);
                }
            }
        }

        private void lbRecentCust_Click(object sender, EventArgs e)
        {
            if (EventSearchFired != null)
            {
                EventSearchFired(this, null);
            }
        }

        private void lnkNew_Click(object sender, EventArgs e)
        {
            if (EventCreateNewFired != null)
            {
                EventCreateNewFired(this, null);
            }
        }

        private void lnkViewAll_Click(object sender, EventArgs e)
        {
            if (EventViewAllFired != null)
            {
                EventViewAllFired(this, null);
            }
        }
    }
}
