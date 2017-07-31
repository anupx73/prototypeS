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

namespace PrototypeS.Orders
{
    public partial class OrdersHomePage : UserControl, IPrototypeUX
    {
        public event Action<object, SmartSearchEventArgs> EventViewAllFired;

        public OrdersHomePage()
        {
            InitializeComponent();
            SetupPageMargins();
            SwitchToBuildOrderView(true);
            for (int i = 0; i <= 6; i++)
            {
                lbQuickServices.Items.Add(new ListBoxExItem(i + 100,
                                                         "Hait Cut",
                                                         "Duration: 15 mins, Price: Rs. 150/-",
                                                         Properties.Resources.scissors));
            }
            for (int i = 0; i <= 4; i++)
            {
                lbQuickProducts.Items.Add(new ListBoxExItem(i + 200,
                                                         "Lotion",
                                                         "Quantity: 60ml Price: Rs. 300/-",
                                                         Properties.Resources.products));
            }
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelHeading, ref panelWarning, ref panelNav);
            tlpBody.Margin = new Padding(0);
            tlpBodyDetails.Margin = new Padding(0);
            tlpQuickAdd.Margin = new Padding(7, 0, 7, 0);
            panelBuildHeader.Margin = new Padding(0);
            panelContinueHeader.Margin = new Padding(0);
            panelTotal.Margin = new Padding(0);
            //panelQuickServices.Margin = new Padding(0);
            //panelQuickProducts.Margin = new Padding(0);
            tlpPaymentMode.Margin = new Padding(0);
            panelPaymentType.Margin = new Padding(0);
            panelCardDetails.Margin = new Padding(0);
            gridList.Margin = new Padding(0);
            tlpOrderHeader.Margin = new Padding(0);
            lbQuickServices.Margin = new Padding(0, 10, 0, 10);
            lbQuickProducts.Margin = new Padding(0, 10, 0, 10);
        }

        private void lnkShowAll_Click(object sender, EventArgs e)
        {
            if (EventViewAllFired != null)
            {
                EventViewAllFired(this, null);
            }
        }

        private void radioCard_CheckedChanged(object sender, EventArgs e)
        {
            panelCardDetails.Visible = true;
        }

        private void radioCash_CheckedChanged(object sender, EventArgs e)
        {
            panelCardDetails.Visible = false;
        }

        public void SwitchToBuildOrderView(bool buildView)
        {
            if (buildView)
            {
                labelHeadingText.Text = "Build an Order";
                tlpOrderHeader.ColumnStyles[0].SizeType = SizeType.Percent;
                tlpOrderHeader.ColumnStyles[0].Width = 100;
                tlpOrderHeader.ColumnStyles[1].SizeType = SizeType.Absolute;
                tlpOrderHeader.ColumnStyles[1].Width = 0;
                lnkEmailBill.Visible = false;
                lnkCancel.Visible = false;
            }
            else
            {
                labelHeadingText.Text = "Order Summary";
                tlpOrderHeader.ColumnStyles[0].SizeType = SizeType.Absolute;
                tlpOrderHeader.ColumnStyles[0].Width = 0;
                tlpOrderHeader.ColumnStyles[1].SizeType = SizeType.Percent;
                tlpOrderHeader.ColumnStyles[1].Width = 100;
                lnkEmailBill.Visible = true;
                lnkCancel.Visible = true;
            }
        }

        private void lnkCancel_Click(object sender, EventArgs e)
        {
            SwitchToBuildOrderView(true);
        }
    }
}
