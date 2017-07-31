using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using PrototypeS.Bookings;
using PrototypeS.Customers;
using PrototypeS.Products;
using PrototypeS.Orders;
using PrototypeS.ServicesPage;
using PrototypeS.Staffs;
using PrototypeS.Marketing;
using PrototypeS.Reporting;

namespace PrototypeS
{
    public partial class HostForm : Form
    {
        private List<MetroLink> navList = new List<MetroLink>();
        private List<UserControl> pageList = new List<UserControl>();
        
        //private Queue<UserControl> backQueue = new Queue<UserControl>();

        public HostForm()
        {
            InitializeComponent();

            tlpBase.Margin = new Padding(0);
            tlpTopNav.Margin = new Padding(0);
            panelTabArea.Margin = new Padding(0);

            CreateBookingPages();
            CreateCustomerPages();
            CreateOrderPages();
            CreateProductsPages();
            CreateServicePage();
            CreateStaffPages();
            CreateReportPages();
            CreateMarketingPages();

            navList.Add(lnkNavBookings);
            navList.Add(lnkNavCustomers);
            navList.Add(lnkNavOrders);
            navList.Add(lnkNavProducts);
            navList.Add(lnkNavServices);
            navList.Add(lnkNavStaffs);
            navList.Add(lnkNavReports);
            navList.Add(lnkNavMarketing);

            pageList.Add(bookingsHomePage);
            pageList.Add(customersHomePage);
            pageList.Add(ordersHomePage);
            pageList.Add(productsHomePage);
            pageList.Add(servicesHomePage);
            pageList.Add(staffsHomePage);
            pageList.Add(reportsHomePage);
            pageList.Add(marketingHomePage);
        }

        private void lnkNav_MouseDown(object sender, MouseEventArgs e)
        {
            MetroLink lnkNavSelected = (MetroLink)sender;
            int pageIndex = 0;
            foreach (MetroLink lnkNav in navList)
            {
                if (lnkNav == lnkNavSelected)
                {
                    lnkNav.Location = new Point(lnkNav.Location.X, 0);
                    lnkNav.Size = new System.Drawing.Size(lnkNav.Size.Width, 51);
                    lnkNav.BackColor = Color.FromArgb(251, 222, 43);
                    lnkNav.ForeColor = Color.Black;

                    if (pageIndex < pageList.Count)
                    {
                        tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
                        tlpBase.Controls.Add(pageList[pageIndex], 0, 1);
                    }
                }
                else
                {
                    lnkNav.Location = new Point(lnkNav.Location.X, 14);
                    lnkNav.Size = new System.Drawing.Size(lnkNav.Size.Width, 35);
                    lnkNav.BackColor = Color.Black;
                    lnkNav.ForeColor = Color.White;
                }
                pageIndex++;
            }
        }

        #region Page_Bookings
        private BookingsHomePage bookingsHomePage = null;
        private BookingsCreatePage bookingsCreatePage = null;

        void CreateBookingPages()
        {
            bookingsHomePage = new BookingsHomePage();
            bookingsHomePage.Margin = new Padding(0);
            bookingsHomePage.Dock = DockStyle.Fill;
            bookingsHomePage.EventSearchFired += bookingsHomePage_EventSearchFired;
            bookingsHomePage.EventEditBookingFired += bookingsHomePage_EventEditBookingFired;
            bookingsHomePage.EventBookingCheckOutFired += bookingsHomePage_EventBookingCheckOutFired;

            bookingsCreatePage = new BookingsCreatePage();
            bookingsCreatePage.Margin = new Padding(0);
            bookingsCreatePage.Dock = DockStyle.Fill;
        }

        void bookingsHomePage_EventBookingCheckOutFired(object arg1, SmartSearchEventArgs arg2)
        {
            ordersHomePage.SwitchToBuildOrderView(false);
            lnkNav_MouseDown(lnkNavOrders, null);
        }

        void bookingsHomePage_EventEditBookingFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(bookingsCreatePage, 0, 1);
        }

        void bookingsHomePage_EventSearchFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            if (!arg2.IsNewCustomer)
            {
                tlpBase.Controls.Add(bookingsCreatePage, 0, 1);
            }
            else
            {
                customersCreatePage.EnableNewBookingView(true);
                tlpBase.Controls.Add(customersCreatePage, 0, 1);
            }
        }
        #endregion

        #region Page_Customers
        private CustomersHomePage customersHomePage = null;
        private CustomersSummaryPage customersSummaryPage = null;
        private CustomersViewAllPage customersViewAllPage = null;
        private CustomersCreatePage customersCreatePage = null;
        private CustomersBuyPackagePage customersBuyPackagePage = null;

        void CreateCustomerPages()
        {
            customersHomePage = new CustomersHomePage();
            customersHomePage.Margin = new Padding(0);
            customersHomePage.Dock = DockStyle.Fill;
            customersHomePage.EventSearchFired += customersHomePage_EventSearchFired;
            customersHomePage.EventCreateNewFired += customersHomePage_EventCreateNewCustomerFired;
            customersHomePage.EventViewAllFired += customersHomePage_EventViewAllFired;

            customersSummaryPage = new CustomersSummaryPage();
            customersSummaryPage.Margin = new Padding(0);
            customersSummaryPage.Dock = DockStyle.Fill;
            customersSummaryPage.EventBookAppointmentFired += customersCreatePage_EventContinueBookFired;
            customersSummaryPage.EventViewAllCustomerFired += customersHomePage_EventViewAllFired;
            customersSummaryPage.EventEditCustomerFired += customersHomePage_EventCreateNewCustomerFired;
            customersSummaryPage.EventBuyPackageFired += customersSummaryPage_EventBuyPackageFired;

            customersViewAllPage = new CustomersViewAllPage();
            customersViewAllPage.Margin = new Padding(0);
            customersViewAllPage.Dock = DockStyle.Fill;
            customersViewAllPage.EventNewCustomerFired += customersHomePage_EventCreateNewCustomerFired;

            customersCreatePage = new CustomersCreatePage();
            customersCreatePage.Margin = new Padding(0);
            customersCreatePage.Dock = DockStyle.Fill;
            customersCreatePage.EventContinueBookFired += customersCreatePage_EventContinueBookFired;

            customersBuyPackagePage = new CustomersBuyPackagePage();
            customersBuyPackagePage.Margin = new Padding(0);
            customersBuyPackagePage.Dock = DockStyle.Fill;
        }

        void customersSummaryPage_EventBuyPackageFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(customersBuyPackagePage, 0, 1);
        }

        void customersCreatePage_EventContinueBookFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(bookingsCreatePage, 0, 1);
        }

        void customersHomePage_EventViewAllFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(customersViewAllPage, 0, 1);
        }

        void customersHomePage_EventCreateNewCustomerFired(object arg1, SmartSearchEventArgs arg2)
        {
            customersCreatePage.EnableNewBookingView(false);
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(customersCreatePage, 0, 1);
        }

        void customersHomePage_EventSearchFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(customersSummaryPage, 0, 1);
        }
        #endregion

        #region Order_Page
        private OrdersHomePage ordersHomePage = null;
        private OrdersListPage ordersListPage = null;

        void CreateOrderPages()
        {
            ordersHomePage = new OrdersHomePage();
            ordersHomePage.Margin = new Padding(0);
            ordersHomePage.Dock = DockStyle.Fill;
            ordersHomePage.EventViewAllFired += ordersHomePage_EventViewAllFired;

            ordersListPage = new OrdersListPage();
            ordersListPage.Margin = new Padding(0);
            ordersListPage.Dock = DockStyle.Fill;
        }

        void ordersHomePage_EventViewAllFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(ordersListPage, 0, 1);
        }
        #endregion

        #region Product_Page
        private ProductsHomePage productsHomePage = null;
        private ProductsDetailsPage productsDetailsPage = null;

        void CreateProductsPages()
        {
            productsHomePage = new ProductsHomePage();
            productsHomePage.Margin = new Padding(0);
            productsHomePage.Dock = DockStyle.Fill;
            productsHomePage.EventAddProductFired += productsHomePage_EventAddProductFired;

            productsDetailsPage = new ProductsDetailsPage();
            productsDetailsPage.Margin = new Padding(0);
            productsDetailsPage.Dock = DockStyle.Fill;
        }

        void productsHomePage_EventAddProductFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(productsDetailsPage, 0, 1);
        }
        #endregion

        #region Service_Page
        private ServicesHomePage servicesHomePage = null;
        private ServicesNewSvcPage servicesCreateServicePage = null;
        private ServicesNewPackPage servicesNewPackPage = null;

        void CreateServicePage()
        {
            servicesHomePage = new ServicesHomePage();
            servicesHomePage.Dock = DockStyle.Fill;
            servicesHomePage.Margin = new Padding(0);
            servicesHomePage.EventNewServiceFired += servicesHomePage_EventNewServiceFired;
            servicesHomePage.EventNewPackageFired += servicesHomePage_EventNewPackageFired;

            servicesCreateServicePage = new ServicesNewSvcPage();
            servicesCreateServicePage.Dock = DockStyle.Fill;
            servicesCreateServicePage.Margin = new Padding(0);

            servicesNewPackPage = new ServicesNewPackPage();
            servicesNewPackPage.Dock = DockStyle.Fill;
            servicesNewPackPage.Margin = new Padding(0);
        }

        void servicesHomePage_EventNewServiceFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(servicesCreateServicePage, 0, 1);
        }

        void servicesHomePage_EventNewPackageFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(servicesNewPackPage, 0, 1);     
        }
        #endregion

        #region Staff_Page
        private StaffsHomePage staffsHomePage = null;
        private StaffsNewPage staffsNewPage = null;

        void CreateStaffPages()
        {
            staffsHomePage = new StaffsHomePage();
            staffsHomePage.Dock = DockStyle.Fill;
            staffsHomePage.Margin = new Padding(0);
            staffsHomePage.EventNewStaffFired += staffsHomePage_EventNewStaffFired;

            staffsNewPage = new StaffsNewPage();
            staffsNewPage.Dock = DockStyle.Fill;
            staffsNewPage.Margin = new Padding(0);
        }

        void staffsHomePage_EventNewStaffFired(object arg1, SmartSearchEventArgs arg2)
        {
            tlpBase.Controls.Remove(tlpBase.GetControlFromPosition(0, 1));
            tlpBase.Controls.Add(staffsNewPage, 0, 1);
        }
        #endregion

        #region Marketing_Page
        private MarketingHomePage marketingHomePage = null;

        void CreateMarketingPages()
        {
            marketingHomePage = new MarketingHomePage();
            marketingHomePage.Dock = DockStyle.Fill;
            marketingHomePage.Margin = new Padding(0);
        }
        #endregion

        #region Reports_Page
        private ReportsHomePage reportsHomePage = null;

        void CreateReportPages()
        {
            reportsHomePage = new ReportsHomePage();
            reportsHomePage.Dock = DockStyle.Fill;
            reportsHomePage.Margin = new Padding(0);
        }
        #endregion
    }
}
