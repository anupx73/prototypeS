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
    public partial class CustomersBuyPackagePage : UserControl, IPrototypeUX
    {
        public CustomersBuyPackagePage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelWarning, ref panelNav);
            panelCustInfo.Margin = new Padding(7, 7, 7, 0);
            panelPackInfo.Margin = new Padding(7, 7, 7, 0);
        }
    }
}
