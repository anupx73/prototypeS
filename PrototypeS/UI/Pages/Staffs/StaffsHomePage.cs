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
using MetroFramework.Controls;

namespace PrototypeS.Staffs
{
    public partial class StaffsHomePage : UserControl
    {
        public event Action<object, SmartSearchEventArgs> EventNewStaffFired;

        public StaffsHomePage()
        {
            InitializeComponent();
            SetupPageMargins();
            ShowDetailsView(false);
            for (int i = 0; i <= 9; i++)
            {
                lbStaffs.Items.Add(new ListBoxExItem(i + 200,
                                                         "Pamela Nail",
                                                         "Phone: 08568545454/0724582454, Join date: 15/02/2016 \r\nLast service: Hair trim style, 02/03/2016 06:09PM",
                                                         Properties.Resources.user_female_small));
            }
        }

        void SetupPageMargins()
        {
            tlpBase.Margin = new Padding(0);
            panelHeading.Margin = new Padding(0);
            tlpBody.Margin = new Padding(10);
            tlpBodyLeft.Margin = new Padding(0);
            tlpBodyRight.Margin = new Padding(0);
            lbStaffs.Margin = new Padding(10);
            panelProfile.Margin = new Padding(0);
            panelTab.Margin = new Padding(0);
            tlpTabViews.Margin = new Padding(0);
            gridSales.Margin = new Padding(0, 0, 0, 20);
            gridUpcoming.Margin = new Padding(0, 0, 0, 20);
        }

        private void lnkTabNav_MouseDown(object sender, MouseEventArgs e)
        {
            MetroLink lnkNavSelected = (MetroLink)sender;
            if (lnkNavSelected == lnkTabNavUpcoming)
            {
                lnkTabNavUpcoming.Location = new Point(lnkTabNavUpcoming.Location.X, 6);
                lnkTabNavUpcoming.Size = new System.Drawing.Size(lnkTabNavUpcoming.Size.Width, 34);
                lnkTabNavUpcoming.BackColor = Color.FromArgb(251, 222, 43);
                lnkTabNavUpcoming.ForeColor = Color.Black;

                lnkTabNavSales.Location = new Point(lnkTabNavSales.Location.X, 12);
                lnkTabNavSales.Size = new System.Drawing.Size(lnkTabNavSales.Size.Width, 28);
                lnkTabNavSales.BackColor = Color.FromArgb(222, 222, 222);
                lnkTabNavSales.ForeColor = Color.Gray;

                tlpTabViews.ColumnStyles[0].SizeType = SizeType.Percent;
                tlpTabViews.ColumnStyles[0].Width = 100F;
                tlpTabViews.ColumnStyles[1].SizeType = SizeType.Absolute;
                tlpTabViews.ColumnStyles[1].Width = 0;
            }
            else
            {
                lnkTabNavUpcoming.Location = new Point(lnkTabNavUpcoming.Location.X, 12);
                lnkTabNavUpcoming.Size = new System.Drawing.Size(lnkTabNavUpcoming.Size.Width, 28);
                lnkTabNavUpcoming.BackColor = Color.FromArgb(222, 222, 222);
                lnkTabNavUpcoming.ForeColor = Color.Gray;

                lnkTabNavSales.Location = new Point(lnkTabNavSales.Location.X, 6);
                lnkTabNavSales.Size = new System.Drawing.Size(lnkTabNavSales.Size.Width, 34);
                lnkTabNavSales.BackColor = Color.FromArgb(251, 222, 43);
                lnkTabNavSales.ForeColor = Color.Black;

                tlpTabViews.ColumnStyles[1].SizeType = SizeType.Percent;
                tlpTabViews.ColumnStyles[1].Width = 100F;
                tlpTabViews.ColumnStyles[0].SizeType = SizeType.Absolute;
                tlpTabViews.ColumnStyles[0].Width = 0;
            }
        }

        private bool showDetailPanels = false;
        private void ShowDetailsView(bool show)
        {
            if (!show)
            {
                tlpBodyRight.RowStyles[0].SizeType = SizeType.Percent;
                tlpBodyRight.RowStyles[0].Height = 50F;
                tlpBodyRight.RowStyles[1].SizeType = SizeType.Percent;
                tlpBodyRight.RowStyles[1].Height = 50F;
                tlpBodyRight.RowStyles[2].SizeType = SizeType.Absolute;
                tlpBodyRight.RowStyles[2].Height = 0;
                tlpBodyRight.RowStyles[3].SizeType = SizeType.Absolute;
                tlpBodyRight.RowStyles[3].Height = 0;
            }
            else
            {
                tlpBodyRight.RowStyles[0].SizeType = SizeType.Absolute;
                tlpBodyRight.RowStyles[0].Height = 0;
                tlpBodyRight.RowStyles[1].SizeType = SizeType.Absolute;
                tlpBodyRight.RowStyles[1].Height = 300;
                tlpBodyRight.RowStyles[2].SizeType = SizeType.Absolute;
                tlpBodyRight.RowStyles[2].Height = 40;
                tlpBodyRight.RowStyles[3].SizeType = SizeType.Percent;
                tlpBodyRight.RowStyles[3].Height = 100;
                
                lnkTabNav_MouseDown(lnkTabNavUpcoming, null);
            }
            panelProfile.Visible = show;
            this.showDetailPanels = show;
        }

        private void lbStaffs_Click(object sender, EventArgs e)
        {
            if (!this.showDetailPanels)
            {
                ShowDetailsView(true);
            }
        }

        private void lnkNew_Click(object sender, EventArgs e)
        {
            if (EventNewStaffFired != null)
            {
                EventNewStaffFired(this, null);
            }
        }
    }
}
