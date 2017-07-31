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

namespace PrototypeS.ServicesPage
{
    public partial class ServicesHomePage : UserControl
    {
        public event Action<object, SmartSearchEventArgs> EventNewServiceFired;
        public event Action<object, SmartSearchEventArgs> EventNewPackageFired;

        public ServicesHomePage()
        {
            InitializeComponent();
            SetupPageMargins();

            for (int i = 0; i <= 10; i++)
            {
                lbServices.Items.Add(new ListBoxExItem(i + 100,
                                                         "Hair Cut",
                                                         "Duration: 20 Mins, Price: Rs. 250/- \r\nDescription: Hair cut with complimentary massage",
                                                         Properties.Resources.scissors));
            }

            for (int i = 0; i <= 4; i++)
            {
                lbPackages.Items.Add(new ListBoxExItem(i + 200,
                                                         "Bride Makeup",
                                                         "Duration: 1Hr 20 Mins, Price: Rs. 950/-, Service Incl: Hair cut, Facial, Trimming \r\nDescription: Last minute beauti touchups before any occassion",
                                                         Properties.Resources.user_female_small));
            }
        }

        void SetupPageMargins()
        {
            tlpBase.Margin = new Padding(0);
            tlpBody.Margin = new Padding(7, 20, 7, 10);
            panelHeading.Margin = new Padding(0);
            tlpServices.Margin = new Padding(0);
            tlpPackages.Margin = new Padding(0);
        }

        private void lnkNewService_Click(object sender, EventArgs e)
        {
            if (EventNewServiceFired != null)
            {
                EventNewServiceFired(this, null);
            }
        }

        private void lnkNewPack_Click(object sender, EventArgs e)
        {
            if (EventNewPackageFired != null)
            {
                EventNewPackageFired(this, null);
            }
        }
    }
}
