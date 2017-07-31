using PrototypeS.Controllers;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
//using PrototypeS.TabViews;

namespace PrototypeS
{
    partial class MainForm
    {
        private const string TEXT_THEP_AVAILABLE = "Available";
        private enum BookingView{
            DefaultView = -1,
            SearchCustomer,
            ExistingCustomer,
            NewCustomer
        };
        private BookingView appointmentView = BookingView.DefaultView;

        //User controls
        //private ViewSmartCustomerSearch viewSmartCustomerSearch = null;
        //private ViewGridSearch viewGridSearch = null;
        //private ViewExistingCustomer viewExistingCustomer = null;
        //private ElementNewCustomer viewNewCustomer = null;
        //private ViewCreateBooking viewCreateBooking = null;
        //private ViewEntryWarning viewEntryWarning = null;

        private void ConfigPanel_Booking()
        {
            bookTLPBase.Margin = new Padding(0);
            bookTLPList.Margin = new Padding(0);
            bookTLPCreate.Margin = new Padding(0);
            bookTLPBookingBase.Margin = new Padding(0);
            bookTLPCreateCustomer.Margin = new Padding(0);
            bookTLPCreateAppoint.Margin = new Padding(0);
            bookTLPCreateCustomerInner.Margin = new Padding(0);
            bookTLPCreateAppointInner.Margin = new Padding(0);

            bookPanelBookHeading.Margin = new Padding(0);
            //tabBookings.Padding = new Padding(0);
            //tabBookings.Margin = new Padding(0);

            //search cust
            //viewSmartCustomerSearch = new ViewSmartCustomerSearch();
            //viewSmartCustomerSearch.Dock = DockStyle.Fill;
            //viewSmartCustomerSearch.EventSearchFired += viewSmartCustomerSearch_SmartSearchFired;
            //bookTLPBase.Controls.Add(viewSmartCustomerSearch, 0, 0);
            
            ////grid search
            //viewGridSearch = new ViewGridSearch();
            //viewGridSearch.Dock = DockStyle.Fill;
            //bookTLPList.Controls.Add(viewGridSearch, 0, 0);

            ////exist cust
            //viewExistingCustomer = new ViewExistingCustomer();
            //viewExistingCustomer.Dock = DockStyle.Fill;

            ////new cust
            //viewNewCustomer = new ElementNewCustomer();
            //viewNewCustomer.Dock = DockStyle.Fill;

            ////booking
            //viewCreateBooking = new ViewCreateBooking();
            //viewCreateBooking.Dock = DockStyle.Fill;
            //bookTLPCreateAppointInner.Controls.Add(viewCreateBooking, 1, 0);

            ////new booking entry warning
            //viewEntryWarning = new ViewEntryWarning();
            //viewEntryWarning.Dock = DockStyle.Fill;
            //viewEntryWarning.Visible = false;
            //bookTLPCreate.Controls.Add(viewEntryWarning, 0, 2);

            SetBookingView(BookingView.SearchCustomer);
        }

        //private void viewSmartCustomerSearch_SmartSearchFired(object sender, SmartSearchEventArgs e)
        //{
        //    if (e.IsNewCutomer)
        //    {
        //        SetBookingView(BookingView.NewCustomer);
        //    }
        //    else
        //    {
        //        SetBookingView(BookingView.ExistingCustomer);
        //    }
        //}

        private void SetBookingView(BookingView currentView)
        {
            if (appointmentView == currentView)
            {
                return;
            }

            appointmentView = currentView;
            switch (currentView)
            {
                case BookingView.SearchCustomer:
                    {
                        //Base TLP
                        bookTLPBase.RowStyles[0].SizeType = SizeType.Absolute;
                        bookTLPBase.RowStyles[0].Height = 140F;
                        bookTLPBase.RowStyles[1].SizeType = SizeType.Percent;
                        bookTLPBase.RowStyles[1].Height = 100F;
                        bookTLPBase.RowStyles[2].SizeType = SizeType.Absolute;
                        bookTLPBase.RowStyles[2].Height = 0;
                    }
                    break;

                case BookingView.ExistingCustomer:
                case BookingView.NewCustomer:
                    {
                        //Base TLP
                        bookTLPBase.RowStyles[0].SizeType = SizeType.Absolute;
                        bookTLPBase.RowStyles[0].Height = 0;
                        bookTLPBase.RowStyles[1].SizeType = SizeType.Absolute;
                        bookTLPBase.RowStyles[1].Height = 0;
                        bookTLPBase.RowStyles[2].SizeType = SizeType.Percent;
                        bookTLPBase.RowStyles[2].Height = 100F;

                        //if (currentView == BookingView.NewCustomer)
                        //{
                        //    bookTLPCreateCustomerInner.Controls.Remove(viewExistingCustomer);
                        //    bookTLPCreateCustomerInner.Controls.Add(viewNewCustomer, 1, 0);
                        //}
                        //else
                        //{
                        //    bookTLPCreateCustomerInner.Controls.Remove(viewNewCustomer);
                        //    bookTLPCreateCustomerInner.Controls.Add(viewExistingCustomer, 1, 0);
                        //}
                    }
                    break;
            }
        }
        
        private void ReInitializeAppointControls()
        {
            SetBookingView(BookingView.SearchCustomer);

            //aptPanelCustInfo.Visible = false;
            //aptPanelCustType.Visible = false;
            //aptPanelExistCust.Visible = false;
            //aptPanelCustSearch.Visible = true;

            //aptDTAppointDate.MinDate = DateTime.Today;
            //aptListBoxPacks.Enabled = false;
            //aptListBoxPacks.Items.Clear();
            //aptListBoxPacks.Items.Add("No Packages Bought");

            //aptRadioExistCust.Select();
            ServiceListCount = 0;
            //aptDTAppointDate.Value = DateTime.Today;
            //aptDTFilter.Value = DateTime.Today;

            //aptListBoxServices.ClearSelected();
            //aptTxtCustName.Text = "";
            //aptTxtEmail.Text = "";
            //aptTxtCustPhone.Text = "";
            ////aptTxtVisits.Text = "";
            //aptTxtAddr.Text = "";

            //aptTextBoxHR.Text = DateTime.Now.ToString("HH");
            //aptTextBoxMIN.Text = DateTime.Now.ToString("mm");
            //aptTxtInclTax.Text = "";

            //aptComboTherapist.Select();
            //aptComboTherapist.Enabled = false;
            //aptListBoxHistory.Items.Clear();
            //aptListBoxHistory.Items.Add("No History Available");

            //aptTxtSearchPhone.Text = "";

            //aptTxtSearchPhone.WithError = false;
            //aptLabelAvailibility.Text = "N/A";

            //aptTxtSearchPhone.Focus();
        }

        private void LoadAppoinments()
        {
            //aptDTAppointDate.MinDate = DateTime.Today;
            //aptDTAppointDate.Value = DateTime.Today;
            //this.EventPopulateAppointments();
            //SList = new List<string>();
            //SqlDataReader reader = Program.db.get("Services");
            //if (reader.HasRows)
            //{
            //    aptListBoxServices.Items.Clear();
            //    while (reader.Read())
            //    {
            //        aptListBoxServices.Items.Add(reader["Name"]);
            //    }
            //    reader.Close();
            //}

            //reader = Program.db.get("Therapists");
            //if (reader.HasRows)
            //{
            //    aptComboTherapist.Items.Clear();
            //    while (reader.Read())
            //    {
            //        aptComboTherapist.Items.Add(reader["Name"]);
            //    }
            //    reader.Close();
            //}

            //ReInitializeAppointControls();
        }

        public void EventPopulateAppointments()
        {
            bookGridList.Rows.Clear();

            Appointments app = new Appointments();
            SqlDataReader reader = app.GetAppointments();
            //if (aptRadioShowAll.Checked)
            //{
            //    reader = app.GetAppointments();
            //}
            //else
            //{
            //    reader = app.GetAppointments(aptDTFilter.Value);
            //}

            if (reader.HasRows)
            {
                int rows = 0;
                while (reader.Read())
                {
                    bookGridList.Rows.Add();
                    SqlDataReader CusInfo = Program.db.get_where("Customers", reader["CustomerId"].ToString());
                    CusInfo.Read();
                    bookGridList.Rows[rows].Cells[0].Value = reader["Id"];
                    bookGridList.Rows[rows].Cells[1].Value = CusInfo["Name"];
                    bookGridList.Rows[rows].Cells[2].Value = CusInfo["Phone"];
                    bookGridList.Rows[rows].Cells[3].Value = CusInfo["Visits"];
                    bookGridList.Rows[rows].Cells[4].Value = Convert.ToDateTime(reader["SessionDate"]).ToString("yyyy-MM-dd");
                    bookGridList.Rows[rows].Cells[5].Value = Convert.ToDateTime(reader["StartTime"]).ToString("HH:mm");
                    bookGridList.Rows[rows].Cells[6].Value = Convert.ToDateTime(reader["EndTime"]).ToString("HH:mm");
                    Therapists t = new Therapists();
                    string TName = t.GetName(reader["TherapistId"].ToString());
                    bookGridList.Rows[rows].Cells[7].Value = TName;

                    rows++;
                }
            }
        }
        
        public void EventAppoint_Go(object sender, EventArgs e)
        {
            //if (aptTxtSearchPhone.Text.Length < UIUtility.PhoneMinLength)
            //{
            //    return;
            //}

            //aptTLPBase.ColumnStyles[0].SizeType = SizeType.Percent;
            //aptTLPBase.ColumnStyles[0].Width = 0F;
            //aptTLPBase.ColumnStyles[1].SizeType = SizeType.Percent;
            //aptTLPBase.ColumnStyles[1].Width = 100F;
            SetBookingView(BookingView.ExistingCustomer);

            //aptPanelBook.AutoScrollPosition = new Point(aptPanelCustPacks.Location.X, aptPanelCustPacks.Location.Y + aptPanelCustPacks.Size.Height + 10);
            //aptPanelBook.VerticalScroll.Value = VerticalScroll.Maximum;
            //aptPanelBook.PerformLayout();

            //SqlDataReader reader = Program.db.Search("Customers", aptTxtSearchPhone.Text, "Phone");
            //if (reader != null && reader.HasRows)
            //{
            //    reader.Read();
            //    //aptTxtCustName.Text = reader["Name"].ToString();
            //    //aptTxtCustPhone.Text = reader["Phone"].ToString();
            //    //aptTxtEmail.Text = reader["Email"].ToString();
            //    ////aptTxtVisits.Text = reader["Visits"].ToString();
            //    //aptTxtAddr.Text = reader["Address"].ToString();
            //    aptRadioExistCust.Enabled = true;
            //    aptRadioExistCust.Focus();
            //    aptRadioExistCust.Enabled = false;
            //    aptComboTherapist.Enabled = true;

            //    //Service History
            //    string CusId = reader["Id"].ToString();
            //    reader.Close();

            //    Appointments app = new Appointments();
            //    reader = app.GetAppointmentList(CusId);
            //    if (reader.HasRows)
            //    {
            //        int count = 0;
            //        Services s = new Services();
            //        aptListBoxHistory.Items.Clear();
            //        aptListGrid.Rows.Clear();
            //        int rows = 0;
            //        while (reader.Read())
            //        {
            //            List<int> Sids = app.GetServiceList(reader["Id"].ToString());

            //            foreach (var i in Sids)
            //            {
            //                string sName = s.GetServiceName(i.ToString());
            //                aptListBoxHistory.Items.Add(sName);
            //                ++count;
            //                if (count == 4)
            //                {
            //                    break;
            //                }
            //            }

            //            if (count == 4)
            //            {
            //                break;
            //            }

            //            //Change Grid
            //            aptListGrid.Rows.Add();
            //            aptListGrid.Rows[rows].Cells[0].Value = reader["Id"].ToString();
            //            //aptListGrid.Rows[rows].Cells[1].Value = aptTxtCustName.Text;
            //            //aptListGrid.Rows[rows].Cells[2].Value = aptTxtCustPhone.Text;
            //            //aptListGrid.Rows[rows].Cells[3].Value = aptTxtVisits.Text;
            //            aptListGrid.Rows[rows].Cells[4].Value = Convert.ToDateTime(reader["SessionDate"]).ToString("yyyy-MM-dd");
            //            aptListGrid.Rows[rows].Cells[5].Value = Convert.ToDateTime(reader["StartTime"]).ToString("HH:mm");
            //            aptListGrid.Rows[rows].Cells[6].Value = Convert.ToDateTime(reader["EndTime"]).ToString("HH:mm");
            //            Therapists t = new Therapists();
            //            string TName = t.GetName(reader["TherapistId"].ToString());
            //            aptListGrid.Rows[rows].Cells[7].Value = TName;
            //            rows++;
            //        }
            //    }
            //    else
            //    {
            //        aptListBoxHistory.Items.Clear();
            //    }

            //    //Package History
            //    reader.Close();
            //    Packages pack = new Packages();
            //    List<int> packids = new List<int>();
            //    packids = pack.GetPackageCustomer(CusId);
            //    if (packids.Count > 0)
            //    {
            //        aptListBoxPacks.Enabled = true;
            //        aptListBoxPacks.Items.Clear();
            //        foreach (var i in packids)
            //        {
            //            string packname = pack.GetPackageName(i.ToString());
            //            aptListBoxPacks.Items.Add(packname);
            //        }
            //    }
            //    else
            //    {
            //        aptListBoxPacks.Items.Clear();
            //        aptListBoxPacks.Items.Add("No Packages Found");
            //        aptListBoxPacks.Enabled = false;
            //    }
            //}
            //else
            //{
            //    //aptTxtCustPhone.Text = aptTxtSearchPhone.Text;
            //    //aptTxtCustName.Focus();
            //    //aptRadioNewCust.Enabled = true;
            //    //aptRadioNewCust.Focus();
            //    //aptRadioNewCust.Enabled = false;
            //    aptComboTherapist.Enabled = true;
            //}
        }

        private void EventAppoint_HRUp()
        {
            //int timeHr = Convert.ToInt32(aptTextBoxHR.Text);
            //if (timeHr >= 23)
            //    timeHr = 0;
            //else
            //    timeHr++;

            //string strOutput = String.Format("{0:00}", timeHr);
            //aptTextBoxHR.Text = strOutput;
        }

        private void EventAppoint_HRdown()
        {
            //int timeHr = Convert.ToInt32(aptTextBoxHR.Text);
            //if (timeHr <= 0)
            //    timeHr = 23;
            //else
            //    timeHr--;

            //string strOutput = String.Format("{0:00}", timeHr);
            //aptTextBoxHR.Text = strOutput;
        }

        private void EventAppoint_MinUp()
        {
            //int timeMin = Convert.ToInt32(aptTextBoxMIN.Text);
            //if (timeMin >= 59)
            //    timeMin = 0;
            //else
            //    timeMin++;

            //string strOutput = String.Format("{0:00}", timeMin);
            //aptTextBoxMIN.Text = strOutput;
        }
        private void EventAppoint_MinDown()
        {
            //int timeMin = Convert.ToInt32(aptTextBoxMIN.Text);
            //if (timeMin <= 0)
            //    timeMin = 59;
            //else
            //    timeMin--;

            //string strOutput = String.Format("{0:00}", timeMin);
            //aptTextBoxMIN.Text = strOutput;
        }

        private void PopulateCurrentDateTimeForAppointment()
        {
            //aptTextBoxHR.Text = DateTime.Now.ToString("HH");
            //aptTextBoxMIN.Text = DateTime.Now.ToString("mm");
        }

        public static List<int> serviceIds;
        public static int therapistId;

        public DateTime GetAppointmentDate()
        {
            //int hr = Convert.ToInt32(aptTextBoxHR.Text);
            //int min = Convert.ToInt32(aptTextBoxMIN.Text);
            //int year = Convert.ToInt32(aptDTAppointDate.Value.ToString("yyyy"));
            //int month = Convert.ToInt32(aptDTAppointDate.Value.ToString("MM"));
            //int day = Convert.ToInt32(aptDTAppointDate.Value.ToString("dd"));

            //DateTime appointmentDate = new DateTime(year, month, day, hr, min, 0);
            //return appointmentDate;
            return DateTime.Today;
        }

        public void GetAvailibilityStatus()
        {
            //therapistId = GetTherapistId();
            //double duration = Convert.ToDouble(aptTxtDuration.Text);
            //DateTime appdate = this.GetAppointmentDate();
            //Appointments obj = new Appointments();

            //bool ifAvailable = obj.AppointmentAvailable(therapistId, appdate, duration);
            //if (ifAvailable)
            //{
            //    aptLabelAvailibility.Text = TEXT_THEP_AVAILABLE;
            //}
            //else
            //{
            //    string id = Appointments.AppId;
            //    Dictionary<string, string> data = new Dictionary<string, string>();
            //    data.Add("TherapistId", "" + therapistId + "");
            //    data.Add("Id", "" + id + "");
            //    SqlDataReader reader = Program.db.get_where_custom("Appointments", data);
            //    while (reader.Read())
            //    {
            //        aptLabelAvailibility.Text = "After" + reader["EndTime"];
            //    }
            //}
        }

        public static int ServiceListCount;
        public static List<string> SList;

        private void EventAppoint_ServiceSelection(object sender, EventArgs e)
        {
        }
        //    var controlList = (ListBox)sender;
        //    if (controlList.Items.Count <= 0)
        //    {
        //        return;
        //    }

        //    Services s = new Services();
        //    int CurrCount;
        //    ListBox.SelectedObjectCollection SelectedItems = aptListBoxServices.SelectedItems;
        //    CurrCount = SelectedItems.Count;

        //    int dur = 0;
        //    if (!String.IsNullOrEmpty(aptTxtDuration.Text))
        //    {
        //        dur = Convert.ToInt32(aptTxtDuration.Text);
        //    }
        //    int price = 0;
        //    if (!String.IsNullOrEmpty(aptTxtPrice.Text))
        //    {
        //        price = Convert.ToInt32(aptTxtPrice.Text);
        //    }

        //    if (CurrCount > ServiceListCount)
        //    {
        //        //Item Inserted

        //        //Find the Service Id of the Item Added

        //        if (SList.Count == 0)
        //        {
        //            //The List is Empty

        //            string sid = s.GetServiceID(aptListBoxServices.SelectedItem.ToString());
        //            string SDur = s.GetServiceDuration(sid);
        //            string SPrice = s.GetServicePrice(sid);

        //            int TotalPrice = price + Convert.ToInt32(SPrice);
        //            int TotalDur = dur + Convert.ToInt32(SDur);

        //            aptTxtPrice.Text = TotalPrice.ToString();
        //            aptTxtDuration.Text = TotalDur.ToString();

        //            SList.Add(aptListBoxServices.SelectedItem.ToString());
        //        }
        //        else
        //        {
        //            foreach (var i in SelectedItems)
        //            {
        //                if (SList.Contains(i.ToString()) == false)
        //                {
        //                    //This is the Newly Added Item.
        //                    string sid = s.GetServiceID(i.ToString());
        //                    string SDur = s.GetServiceDuration(sid);
        //                    string SPrice = s.GetServicePrice(sid);

        //                    int TotalPrice = price + Convert.ToInt32(SPrice);
        //                    int TotalDur = dur + Convert.ToInt32(SDur);

        //                    aptTxtPrice.Text = TotalPrice.ToString();
        //                    aptTxtDuration.Text = TotalDur.ToString();

        //                    SList.Add(i.ToString());
        //                }
        //            }
        //        }

        //        aptComboTherapist.Enabled = true;
        //    }
        //    else
        //    {
        //        //Item Removed

        //        if (CurrCount == 0)
        //        {
        //            aptTxtDuration.Text = "";
        //            aptTxtPrice.Text = "";
        //            aptTxtInclTax.Text = "";
        //            SList.Clear();
        //            aptComboTherapist.Enabled = false;
        //            ServiceListCount = 0;
        //            return;
        //        }

        //        //Find the ServiceId of the Item Removed

        //        string remove = "";

        //        foreach (var i in SList)
        //        {
        //            if (SelectedItems.Contains(i.ToString()) == false)
        //            {
        //                //This is the Item Removed
        //                string sid = s.GetServiceID(i.ToString());
        //                string SDur = s.GetServiceDuration(sid);
        //                string SPrice = s.GetServicePrice(sid);

        //                int TotalPrice = price - Convert.ToInt32(SPrice);
        //                int TotalDur = dur - Convert.ToInt32(SDur);

        //                aptTxtPrice.Text = TotalPrice.ToString();
        //                aptTxtDuration.Text = TotalDur.ToString();

        //                remove = i.ToString();
        //            }
        //        }

        //        SList.Remove(remove);
        //    }

        //    ServiceListCount = CurrCount;
        //    aptComboTherapist.Enabled = true;
        //    if (aptTxtPrice.Text != "0")
        //    {
        //        double cp = Convert.ToDouble(aptTxtPrice.Text);
        //        double cwt = (14.5 / 100) * cp;
        //        cwt = cwt + cp;
        //        aptTxtInclTax.Text = String.Format("{0:N2}", cwt.ToString());
        //    }
        //    else
        //    {
        //        aptTxtInclTax.Text = "";
        //    }
        //}


        private bool Validate_Appoint()
        {
            return true;
        }
        //{
        //    //booking validation
        //    if (String.IsNullOrWhiteSpace(aptTxtDuration.Text))
        //    {
        //        ToggleAppointStatus(true, true, "Service cannot be blank");
        //        return false;
        //    }

        //    if (aptComboTherapist.SelectedIndex == -1 ||
        //        String.IsNullOrWhiteSpace(aptComboTherapist.SelectedItem.ToString()))
        //    {
        //        ToggleAppointStatus(true, true, "Choose therapist before making a booking");
        //        return false;
        //    }

        //    if (aptLabelAvailibility.Text.CompareTo(TEXT_THEP_AVAILABLE) != 0)
        //    {
        //        ToggleAppointStatus(true, true, "Selected Therapist is not available for time choosen");
        //        return false;
        //    }

        //    //customer validation
        //    if (String.IsNullOrWhiteSpace(aptTxtSearchPhone.Text))
        //    {
        //        aptTxtSearchPhone.WithError = true;
        //        ToggleAppointStatus(true, true, "Add a customer before saving appointment");
        //        return false;
        //    }

        //    //if (String.IsNullOrWhiteSpace(aptTxtCustName.Text))
        //    //{
        //    //    aptTxtCustName.WithError = true;
        //    //    ToggleAppointStatus(true, true, "Customer name cannot be blank");
        //    //    return false;
        //    //}

        //    //if (String.IsNullOrWhiteSpace(aptTxtCustPhone.Text))
        //    //{
        //    //    aptTxtCustPhone.WithError = true;
        //    //    ToggleAppointStatus(true, true, "Customer phone number cannot be blank");
        //    //    return false;
        //    //}

        //    return true;
        //}

        private void EventAppoint_Save(object sender, EventArgs e)
        { }
        //{
        //    if (!Validate_Appoint())
        //    {
        //        return;
        //    }

        //    List<int> ServiceIds = new List<int>();
        //    int thearapistId;
        //    double Duration;

        //    ListBox.SelectedObjectCollection col = aptListBoxServices.SelectedItems;
        //    Services s = new Services();

        //    foreach (var i in col)
        //    {
        //        ServiceIds.Add(Convert.ToInt32(s.GetServiceID(i.ToString())));
        //    }
        //    string tName = aptComboTherapist.SelectedItem.ToString();
        //    Therapists t = new Therapists();
        //    thearapistId = Convert.ToInt32(t.GetId(tName));

        //    Duration = Convert.ToDouble(aptTxtDuration.Text);
        //    double Price = Convert.ToDouble(aptTxtPrice.Text);

        //    Appointments app = new Appointments();
        //    DateTime appDate = this.GetAppointmentDate();

        //    //Customer Info
        //    string name = "";//aptTxtCustName.Text;
        //    string phone = null;
        //    try
        //    {
        //        phone = "";// aptTxtCustPhone.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.AppError(ex.Message);
        //        ToggleAppointStatus(true, true, "Phone Number cannot be Blank");
        //        //MetroMessageBox.Show(this.FindForm(), "Phone Number cannot be Blank");
        //    }

        //    string email = "";
        //    int visits = 0;
        //    string address = "";

        //    //if (string.IsNullOrWhiteSpace(aptTxtEmail.Text))
        //    //{
        //    //    email = null;
        //    //}
        //    //else
        //    //{
        //    //    email = aptTxtEmail.Text;
        //    //}
        //    //if (string.IsNullOrWhiteSpace(aptTxtAddr.Text))
        //    //{
        //    //    address = null;
        //    //}
        //    //else
        //    //{
        //    //    address = aptTxtAddr.Text;
        //    //}
        //    //if (string.IsNullOrWhiteSpace(aptTxtVisits.Text))
        //    //{
        //    //    visits = 0;
        //    //}
        //    //else
        //    //{
        //    //    visits = Convert.ToInt32(aptTxtVisits.Text);
        //    //}
        //    Boolean success = false;
        //    if (isPackageAppointment)
        //    {
        //        string packname = aptListBoxPacks.SelectedItem.ToString();
        //        Packages p = new Packages();
        //        string pId = p.GetPackageID(packname);
        //        Customers cus = new Customers();
        //        string cusId = cus.CustomerExsits("");//aptTxtCustPhone.Text);
        //        success = app.RegisterPackageAppoinment(thearapistId, Convert.ToInt32(cusId), Duration, Price, appDate, pId);
        //    }
        //    else
        //    {
        //        success = app.RegisterServiceAppoinment(thearapistId, Duration, Price, appDate, ServiceIds, name, phone, email, visits, address);
        //    }

        //    if (!success)
        //    {
        //        Log.AppError("Appointment Failed");
        //        MetroMessageBox.Show(this.FindForm(), "Something went terrible wrong. Contact System Administrator.", "Result", MessageBoxButtons.OK);
        //    }
        //    else
        //    {
        //        ToggleAppointStatus(true, false, "Appointment booked successfully");
        //        //ReInitializeAppointControls();
        //    }

        //    this.EventPopulateAppointments();
        //    this.populateSessions();
        //    this.populateCustomers();
        //}

        private void aptListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        { }
        //{
        //    //  buttonAppointmentDelete.PerformClick();
        //    int row = e.RowIndex;

        //    //Fetching Row Data
        //    int Id = Convert.ToInt32(aptListGrid.Rows[row].Cells[0].Value);

        //    Dictionary<string, string> d = new Dictionary<string, string>();
        //    d.Add("Id", "'" + Id + "'");

        //    SqlDataReader appreader = Program.db.get_where_custom("Appointments", d);
        //    d.Clear();
        //    appreader.Read();
        //    int custId = Convert.ToInt32(appreader["CustomerId"].ToString());

        //    d.Add("Id", "'" + custId + "'");
        //    SqlDataReader reader = Program.db.get_where_custom("Customers", d);
        //    if (reader.HasRows)
        //    {
        //        reader.Read();
        //        //aptTxtCustName.Text = reader["Name"].ToString();
        //        //aptTxtCustPhone.Text = reader["Phone"].ToString();
        //        //aptTxtEmail.Text = reader["Email"].ToString();
        //        ////aptTxtVisits.Text = reader["Visits"].ToString();
        //        //aptTxtAddr.Text = reader["Address"].ToString();
        //        aptRadioExistCust.Enabled = true;
        //        aptRadioExistCust.Focus();
        //        aptRadioExistCust.Enabled = false;
        //        aptDTAppointDate.Value = Convert.ToDateTime(appreader["SessionDate"]);
        //        aptTextBoxHR.Text = Convert.ToDateTime(appreader["StartTime"]).ToString("HH");
        //        aptTextBoxMIN.Text = Convert.ToDateTime(appreader["StartTime"]).ToString("mm");

        //        //Select Services
        //        Appointments app = new Appointments();
        //        Services s = new Services();
        //        List<int> Sids = app.GetServiceList(appreader["id"].ToString());
        //        aptListBoxServices.BeginUpdate();
        //        try
        //        {
        //            // do with listBoxPackService.Items[i]
        //            foreach (var j in Sids)
        //            {
        //                int index = -1;
        //                string SName = s.GetServiceName(j.ToString());
        //                index = aptListBoxServices.FindString(SName);
        //                if (index != -1)
        //                {
        //                    aptListBoxServices.SetSelected(index, true);
        //                }
        //            }
        //        }
        //        finally
        //        {
        //            aptListBoxServices.EndUpdate();
        //        }

        //        Therapists t = new Therapists();
        //        string tName = t.GetName(appreader["TherapistId"].ToString());
        //        aptComboTherapist.SelectedItem = tName;
        //        string CusId = reader["Id"].ToString();
        //        reader.Close();
        //        reader = app.GetAppointmentList(CusId);
        //        if (reader.HasRows)
        //        {
        //            int count = 0;
        //            aptListBoxHistory.Items.Clear();
        //            while (reader.Read())
        //            {
        //                List<int> serIds = app.GetServiceList(reader["Id"].ToString());

        //                foreach (var i in serIds)
        //                {
        //                    string sName = s.GetServiceName(i.ToString());
        //                    aptListBoxHistory.Items.Add(sName);
        //                    ++count;
        //                    if (count == 4)
        //                    {
        //                        break;
        //                    }
        //                }

        //                if (count == 4)
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            aptListBoxHistory.Items.Clear();
        //            aptListBoxHistory.Items.Add("No Service History Found");
        //        }

        //        //Package History
        //        reader.Close();
        //        Packages pack = new Packages();
        //        List<int> packids = new List<int>();
        //        packids = pack.GetPackageCustomer(CusId);
        //        if (packids.Count > 0)
        //        {
        //            aptListBoxPacks.Enabled = true;
        //            aptListBoxPacks.Items.Clear();
        //            foreach (var i in packids)
        //            {
        //                string packname = pack.GetPackageName(i.ToString());
        //                aptListBoxPacks.Items.Add(packname);
        //            }
        //        }
        //        else
        //        {
        //            aptListBoxPacks.Items.Clear();
        //            aptListBoxPacks.Items.Add("No Packages Found");
        //            aptListBoxPacks.Enabled = false;
        //        }

        //        reader.Close();
        //    }
        //    else
        //    {
        //        //aptTxtCustName.Focus();
        //        reader.Close();
        //    }
        //}

        private void EventAppoint_HRChanged(object sender, EventArgs e)
        { }
        //{
        //    bool bChangeRqd = false;
        //    Int32 hour = Convert.ToInt32(aptTextBoxHR.Text);

        //    if (aptDTAppointDate.Value.CompareTo(DateTime.Today) == 0)
        //    {
        //        Int32 sysHour = Convert.ToInt32(DateTime.Now.ToString("HH"));
        //        if (hour < sysHour)
        //        {
        //            bChangeRqd = true;
        //            hour = sysHour;
        //        }
        //    }

        //    if (hour > 24)
        //    {
        //        bChangeRqd = true;
        //        hour = 24;
        //    }

        //    if (bChangeRqd)
        //    {
        //        aptTextBoxHR.Text = String.Format("{0:00}", hour);
        //    }

        //    if (!String.IsNullOrWhiteSpace(aptTxtDuration.Text) && aptComboTherapist.SelectedItem != null)
        //    {
        //        GetAvailibilityStatus();
        //    }
        //}

        private void EventAppoint_MINChanged(object sender, EventArgs e)
        { }
        //{
        //    Int32 min = Convert.ToInt32(aptTextBoxMIN.Text);
        //    Int32 hour = Convert.ToInt32(aptTextBoxHR.Text);
        //    bool bChangeRqd = false;

        //    if (aptDTAppointDate.Value.CompareTo(DateTime.Today) == 0)
        //    {
        //        Int32 sysMin = Convert.ToInt32(DateTime.Now.ToString("mm"));
        //        Int32 sysHour = Convert.ToInt32(DateTime.Now.ToString("HH"));
        //        if (hour == sysHour && min < sysMin)
        //        {
        //            bChangeRqd = true;
        //            min = sysMin;
        //        }
        //    }

        //    if (min > 59)
        //    {
        //        bChangeRqd = true;
        //        min = 59;
        //    }

        //    if (bChangeRqd)
        //    {
        //        aptTextBoxMIN.Text = String.Format("{0:00}", min);
        //    }


        //    if (!String.IsNullOrWhiteSpace(aptTxtDuration.Text) && aptComboTherapist.SelectedItem != null)
        //    {
        //        GetAvailibilityStatus();
        //    }
        //}

        private void EventAptDTChanged(object sender, EventArgs e)
        {
            //if (this.FindForm().Visible == true)
            //{
            //    if (!String.IsNullOrWhiteSpace(aptTxtDuration.Text) && aptComboTherapist.SelectedItem != null)
            //    {
            //        GetAvailibilityStatus();
            //    }
            //}
        }

        private void EventAptTxtSearchKeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && aptTxtSearchPhone.Text.Length >= UIUtility.PhoneMinLength)
            //{
            //    aptBtnGo.PerformClick();
            //}
        }

        private void Validate_PhoneField(object sender)
        {
            var control = (MetroTextBox)sender;
            if (control.Text.Length < UIUtility.PhoneMinLength)
            {
                control.WithError = true;
            }
        }

        private void Validate_EmailField(object sender)
        {
            var control = (MetroTextBox)sender;
            if (!UIUtility.IsValidEmailAddress(control.Text))
            {
                control.WithError = true;
            }
        }

        private void EventAppoint_PacksSelectionChanged(object sender, EventArgs e)
        { }
        //{
        //    var controlList = (ListBox)sender;
        //    if (controlList.Items.Count <= 0)
        //    {
        //        return;
        //    }
        //    ListBox.SelectedObjectCollection col = aptListBoxPacks.SelectedItems;
        //    if (col.Count > 0)
        //    {
        //        //Get Customer ID
        //        string CusPh = "";// aptTxtCustPhone.Text;
        //        Customers cus = new Customers();
        //        string CusId = cus.CustomerExsits(CusPh);
        //        string packname = aptListBoxPacks.SelectedItem.ToString();
        //        Packages p = new Packages();
        //        string packId = p.GetPackageID(packname);

        //        List<int> vsids = new List<int>();
        //        vsids = p.ValidServices(CusId, packId);

        //        if (vsids.Count > 0)
        //        {
        //            Services s = new Services();
        //            isPackageAppointment = true;
        //            aptListBoxServices.Items.Clear();
        //            foreach (var i in vsids)
        //            {
        //                string sName = s.GetServiceName(i.ToString());
        //                aptListBoxServices.Items.Add(sName);
        //            }
        //        }
        //        else
        //        {
        //            aptListBoxServices.Items.Clear();
        //            aptListBoxServices.Items.Add("No Valid Services Found");
        //        }
        //    }
        //    else
        //    {
        //        aptListBoxServices.Items.Clear();
        //        SqlDataReader reader = Program.db.get("Services");
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                aptListBoxServices.Items.Add(reader["Name"].ToString());
        //            }
        //        }
        //        isPackageAppointment = false;
        //        reader.Close();
        //    }
        //}

        private void EventAppoint_ThepSelectionChanged()
        { }
        //{
        //    therapistId = GetTherapistId();
        //    serviceIds = new List<int>();
        //    Dictionary<string, string> d = new Dictionary<string, string>();

        //    ListBox.SelectedObjectCollection col = aptListBoxServices.SelectedItems;

        //    if (col.Count != 0)
        //    {
        //        Services s = new Services();
        //        foreach (var item in aptListBoxServices.SelectedItems)
        //        {
        //            string sid = s.GetServiceID(item.ToString());

        //            serviceIds.Add(Convert.ToInt32(sid));
        //        }

        //        double duration = Convert.ToDouble(aptTxtDuration.Text);

        //        DateTime appdate = this.GetAppointmentDate();

        //        Appointments obj = new Appointments();

        //        bool ifAvailable = obj.AppointmentAvailable(therapistId, appdate, duration);
        //        if (ifAvailable)
        //        {
        //            aptLabelAvailibility.Text = TEXT_THEP_AVAILABLE;
        //        }
        //        else
        //        {
        //            string id = Appointments.AppId;

        //            Dictionary<string, string> data = new Dictionary<string, string>();
        //            data.Add("TherapistId", "" + therapistId + "");
        //            data.Add("Id", "" + id + "");
        //            SqlDataReader reader = Program.db.get_where_custom("Appointments", data);
        //            while (reader.Read())
        //            {
        //                aptLabelAvailibility.Text = "After " + reader["EndTime"];
        //            }
        //        }
        //    }
        //    else
        //    {
        //        //MetroMessageBox.Show(this.FindForm(), "Please Select a Service First", "Select service", MessageBoxButtons.OK);
        //        ToggleAppointStatus(true, true, "Select a service first");
        //    }
        //}

        public void populateSessions()
        {
            //Appointments app = new Appointments();
            //SqlDataReader reader = app.GetLiveAppointments();
            //billTodaySessGrid.Rows.Clear();
            //if (reader.HasRows)
            //{
            //    int row = 0;
            //    billTodaySessGrid.Rows.Clear();
            //    Customers cus = new Customers();
            //    while (reader.Read())
            //    {
            //        billTodaySessGrid.Rows.Add();
            //        billTodaySessGrid.Rows[row].Cells[0].Value = reader["id"].ToString();
            //        billTodaySessGrid.Rows[row].Cells[1].Value = cus.GetCustomerName(reader["CustomerId"].ToString());
            //        billTodaySessGrid.Rows[row].Cells[2].Value = Convert.ToDateTime(reader["StartTime"]).ToString("HH:mm");
            //        billTodaySessGrid.Rows[row].Cells[3].Value = Convert.ToDateTime(reader["EndTime"]).ToString("HH:mm");
            //        billTodaySessGrid.Rows[row].Cells[4].Value = reader["Price"].ToString();
            //        row++;
            //    }
            //}
        }

        private void EventAppointDTChanged(object sender, EventArgs e)
        {
            bookGridList.Rows.Clear();
            Appointments app = new Appointments();
            SqlDataReader reader = null; // app.GetAppointments(aptDTFilter.Value);
            if (reader.HasRows)
            {
                int rows = 0;

                while (reader.Read())
                {
                    bookGridList.Rows.Add();
                    SqlDataReader CusInfo = Program.db.get_where("Customers", reader["CustomerId"].ToString());
                    CusInfo.Read();
                    bookGridList.Rows[rows].Cells[0].Value = reader["Id"];
                    bookGridList.Rows[rows].Cells[1].Value = CusInfo["Name"];
                    bookGridList.Rows[rows].Cells[2].Value = CusInfo["Phone"];
                    bookGridList.Rows[rows].Cells[3].Value = CusInfo["Visits"];
                    bookGridList.Rows[rows].Cells[4].Value = Convert.ToDateTime(reader["SessionDate"]).ToString("yyyy-MM-dd");
                    bookGridList.Rows[rows].Cells[5].Value = Convert.ToDateTime(reader["StartTime"]).ToString("HH:mm");
                    bookGridList.Rows[rows].Cells[6].Value = Convert.ToDateTime(reader["EndTime"]).ToString("HH:mm");
                    Therapists t = new Therapists();
                    string TName = t.GetName(reader["TherapistId"].ToString());
                    bookGridList.Rows[rows].Cells[7].Value = TName;

                    rows++;
                }
            }
            else
            {
                //MetroMessageBox.Show(this.FindForm(), "No Records Found", "AppointmentList");
            }
        }

        //private bool bAppntSaveTimerFired = false;
        private Timer appntTimer = new Timer();
        
        private void ToggleAppointStatus(bool bShow, bool bWarning = false, string text = "")
        {
            //if (!bShow)
            //{
            //    if (bAppntSaveTimerFired)
            //    {
            //        appntTimer.Stop();
            //        bAppntSaveTimerFired = false;
            //    }

            //    aptLnkStatus.Text = String.Empty;
            //    aptPanelStatus.Visible = false;
            //}
            //else
            //{
            //    if (bWarning)
            //    {
            //        aptLnkStatus.Image = Properties.Resources.warning_icon;
            //        aptLnkStatus.NoFocusImage = Properties.Resources.warning_icon;
            //    }
            //    else
            //    {
            //        aptLnkStatus.Image = Properties.Resources.thumb_up_small;
            //        aptLnkStatus.NoFocusImage = Properties.Resources.thumb_up_small;

            //        if (!bAppntSaveTimerFired)
            //        {
            //            appntTimer.Interval = 2000;
            //            appntTimer.Tick += AppntTimer_Tick;
            //            appntTimer.Start();
            //            bAppntSaveTimerFired = true;
            //        }
            //    }

            //    aptLnkStatus.Text = text;
            //    aptPanelStatus.Visible = true;
            //}
        }

        private void AppntTimer_Tick(object sender, EventArgs e)
        {
            ReInitializeAppointControls();
            ToggleAppointStatus(false);
        }

        private void EventAppoint_TopNavBack()
        {
            if (appointmentView != BookingView.SearchCustomer)
            {
                ReInitializeAppointControls();
            }
        }
    }
}
