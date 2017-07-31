using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeS.Products
{
    public partial class ProductsHomePage : UserControl, IPrototypeUX
    {
        public event Action<object, SmartSearchEventArgs> EventAddProductFired;

        public ProductsHomePage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelNav, ref panelNav);
            panelGridSearch.Margin = new Padding(7, 0, 7, 0);
            gridList.Margin = new Padding(7, 0, 7, 0);
        }

        private void lnkAddNew_Click(object sender, EventArgs e)
        {
            if (EventAddProductFired != null)
            {
                EventAddProductFired(this, null);
            }
        }
    }
}
