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
    public partial class ProductsDetailsPage : UserControl, IPrototypeUX
    {
        public ProductsDetailsPage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelWarning, ref panelNav);
            tlpBody.Margin = new Padding(7, 0, 7, 0);
        }
    }
}
