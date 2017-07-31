using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeS.ServicesPage
{
    public partial class ServicesNewSvcPage : UserControl, IPrototypeUX
    {
        public ServicesNewSvcPage()
        {
            InitializeComponent();
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelWarning, ref panelNav);
            panelBody.Margin = new Padding(7, 10, 7, 0);
        }
    }
}
