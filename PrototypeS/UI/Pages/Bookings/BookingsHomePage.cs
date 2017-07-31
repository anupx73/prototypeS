using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PrototypeS.Bookings
{
    public partial class BookingsHomePage : UserControl, IPrototypeUX
    {
        private string searchType = String.Empty;
        public event Action<object, SmartSearchEventArgs> EventSearchFired;
        public event Action<object, SmartSearchEventArgs> EventEditBookingFired;
        public event Action<object, SmartSearchEventArgs> EventBookingCheckOutFired;

        public BookingsHomePage()
        {
            InitializeComponent();
            
            searchType = lnkDropDownName.Text;
            SetupPageMargins();
        }

        public void SetupPageMargins()
        {
            UIUtility.SetupCommonMargins(ref tlpBase, ref panelNav, ref panelNav, ref panelNav);
            panelSmartSearch.Margin = new Padding(0);
            panelGridSearch.Margin = new Padding(7, 0, 7, 0);
            gridList.Margin = new Padding(7, 0, 7, 0);
        }

        private void panelSmartSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTypeDropDown.Visible)
            {
                panelTypeDropDown.Hide();
            }
        }

        private void linkSearchType_MouseDown(object sender, MouseEventArgs e)
        {
            if (searchType.CompareTo(lnkDropDownName.Text) == 0)
            {
                lnkDropDownName.Image = Properties.Resources.tick_small;
                lnkDropDownName.NoFocusImage = Properties.Resources.tick_small;

                lnkDropDownPhone.Image = null;
                lnkDropDownPhone.NoFocusImage = null;
                lnkDropDownEmail.Image = null;
                lnkDropDownEmail.NoFocusImage = null;
            }
            else if (searchType.CompareTo(lnkDropDownPhone.Text) == 0)
            {
                lnkDropDownPhone.Image = Properties.Resources.tick_small;
                lnkDropDownPhone.NoFocusImage = Properties.Resources.tick_small;

                lnkDropDownName.Image = null;
                lnkDropDownName.NoFocusImage = null;
                lnkDropDownEmail.Image = null;
                lnkDropDownEmail.NoFocusImage = null;
            }
            else
            {
                lnkDropDownEmail.Image = Properties.Resources.tick_small;
                lnkDropDownEmail.NoFocusImage = Properties.Resources.tick_small;

                lnkDropDownName.Image = null;
                lnkDropDownName.NoFocusImage = null;
                lnkDropDownPhone.Image = null;
                lnkDropDownPhone.NoFocusImage = null;
            }

            panelTypeDropDown.Show();
        }

        private void lnkDropDown_Click(object sender, EventArgs e)
        {
            MetroLink lnkControl = (MetroLink)sender;

            searchType = lnkControl.Text;
            linkSearchType.Text = lnkControl.Text; //Need trim here for db operation
            panelTypeDropDown.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (EventSearchFired != null)
                {
                    if (Control.ModifierKeys == Keys.Control)
                    {
                        EventSearchFired(this, new SmartSearchEventArgs(true));
                    }
                    else
                    {
                        EventSearchFired(this, new SmartSearchEventArgs(false));
                    }
                }
            }
        }

        private void bookLnkEdit_Click(object sender, EventArgs e)
        {
            if (EventEditBookingFired != null)
            {
                EventEditBookingFired(this, null);
            }
        }

        private void bookLnkCheckOut_Click(object sender, EventArgs e)
        {
            if (EventBookingCheckOutFired != null)
            {
                EventBookingCheckOutFired(this, null);
            }
        }
    }
}
