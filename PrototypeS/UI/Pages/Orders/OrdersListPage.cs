using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeS.Orders
{
    public partial class OrdersListPage : UserControl, IPrototypeUX
    {
        public OrdersListPage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelNav, ref panelNav);
            panelGridSearch.Margin = new Padding(7, 0, 7, 0);
        }
    }
}
