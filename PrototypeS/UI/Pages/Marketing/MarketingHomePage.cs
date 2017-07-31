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

namespace PrototypeS.Marketing
{
    public partial class MarketingHomePage : UserControl
    {
        public MarketingHomePage()
        {
            InitializeComponent();

            tlpBase.Margin = new Padding(0);
            tlpContent.Margin = new Padding(20);
            tlpCustComms.Margin = new Padding(0);
            tlpCustPromoContent.Margin = new Padding(0);
            tlpCustPromotion.Margin = new Padding(0);
            tlpRecentFeedbacks.Margin = new Padding(0);
            tlpRecentMails.Margin = new Padding(0);
            tlpSendCoupon.Margin = new Padding(0);
            tlpSendMail.Margin = new Padding(0);

            panelHeading.Margin = new Padding(0);
            panelSendMail.Margin = new Padding(0);
            panelWarning.Margin = new Padding(0);
            panelSendCoupon.Margin = new Padding(0);

            for (int i = 0; i <= 7; i++)
            {
                lbRecentFeedbacks .Items.Add(new ListBoxExItem(i + 100,
                                                         "Mia S.",
                                                         "Phone: 7287827827, Last Service: Pedicare, Message: Need to improve chairs",
                                                         Properties.Resources.user_female_small));

                lbRecentMails.Items.Add(new ListBoxExItem(i + 100,
                                                         "Mrs. Sharma",
                                                         "Greet Type: Anniverssary, Date: 20/01/2016, Style: P0892 / 2298X",
                                                         Properties.Resources.user_female_small));

            }
        }
    }
}
