namespace PrototypeS
{
    partial class HostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTopNav = new System.Windows.Forms.TableLayoutPanel();
            this.panelTabArea = new System.Windows.Forms.Panel();
            this.lnkNavMarketing = new MetroFramework.Controls.MetroLink();
            this.lnkNavReports = new MetroFramework.Controls.MetroLink();
            this.lnkNavStaffs = new MetroFramework.Controls.MetroLink();
            this.lnkNavServices = new MetroFramework.Controls.MetroLink();
            this.lnkNavProducts = new MetroFramework.Controls.MetroLink();
            this.lnkNavOrders = new MetroFramework.Controls.MetroLink();
            this.lnkNavCustomers = new MetroFramework.Controls.MetroLink();
            this.lnkNavBookings = new MetroFramework.Controls.MetroLink();
            this.tlpBase.SuspendLayout();
            this.tlpTopNav.SuspendLayout();
            this.panelTabArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tlpTopNav, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(1192, 693);
            this.tlpBase.TabIndex = 0;
            // 
            // tlpTopNav
            // 
            this.tlpTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tlpTopNav.ColumnCount = 1;
            this.tlpTopNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopNav.Controls.Add(this.panelTabArea, 0, 1);
            this.tlpTopNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopNav.Location = new System.Drawing.Point(3, 3);
            this.tlpTopNav.Name = "tlpTopNav";
            this.tlpTopNav.RowCount = 2;
            this.tlpTopNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTopNav.Size = new System.Drawing.Size(1186, 122);
            this.tlpTopNav.TabIndex = 0;
            // 
            // panelTabArea
            // 
            this.panelTabArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panelTabArea.Controls.Add(this.lnkNavMarketing);
            this.panelTabArea.Controls.Add(this.lnkNavReports);
            this.panelTabArea.Controls.Add(this.lnkNavStaffs);
            this.panelTabArea.Controls.Add(this.lnkNavServices);
            this.panelTabArea.Controls.Add(this.lnkNavProducts);
            this.panelTabArea.Controls.Add(this.lnkNavOrders);
            this.panelTabArea.Controls.Add(this.lnkNavCustomers);
            this.panelTabArea.Controls.Add(this.lnkNavBookings);
            this.panelTabArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabArea.Location = new System.Drawing.Point(3, 75);
            this.panelTabArea.Name = "panelTabArea";
            this.panelTabArea.Size = new System.Drawing.Size(1180, 44);
            this.panelTabArea.TabIndex = 0;
            // 
            // lnkNavMarketing
            // 
            this.lnkNavMarketing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavMarketing.BackColor = System.Drawing.Color.Black;
            this.lnkNavMarketing.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavMarketing.ForeColor = System.Drawing.Color.White;
            this.lnkNavMarketing.Location = new System.Drawing.Point(934, 8);
            this.lnkNavMarketing.Name = "lnkNavMarketing";
            this.lnkNavMarketing.Size = new System.Drawing.Size(130, 35);
            this.lnkNavMarketing.TabIndex = 0;
            this.lnkNavMarketing.Text = "MARKETING";
            this.lnkNavMarketing.UseCustomBackColor = true;
            this.lnkNavMarketing.UseCustomForeColor = true;
            this.lnkNavMarketing.UseSelectable = true;
            this.lnkNavMarketing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // lnkNavReports
            // 
            this.lnkNavReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavReports.BackColor = System.Drawing.Color.Black;
            this.lnkNavReports.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavReports.ForeColor = System.Drawing.Color.White;
            this.lnkNavReports.Location = new System.Drawing.Point(801, 8);
            this.lnkNavReports.Name = "lnkNavReports";
            this.lnkNavReports.Size = new System.Drawing.Size(130, 35);
            this.lnkNavReports.TabIndex = 0;
            this.lnkNavReports.Text = "REPORTS";
            this.lnkNavReports.UseCustomBackColor = true;
            this.lnkNavReports.UseCustomForeColor = true;
            this.lnkNavReports.UseSelectable = true;
            this.lnkNavReports.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // lnkNavStaffs
            // 
            this.lnkNavStaffs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavStaffs.BackColor = System.Drawing.Color.Black;
            this.lnkNavStaffs.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavStaffs.ForeColor = System.Drawing.Color.White;
            this.lnkNavStaffs.Location = new System.Drawing.Point(668, 8);
            this.lnkNavStaffs.Name = "lnkNavStaffs";
            this.lnkNavStaffs.Size = new System.Drawing.Size(130, 35);
            this.lnkNavStaffs.TabIndex = 0;
            this.lnkNavStaffs.Text = "STAFFS";
            this.lnkNavStaffs.UseCustomBackColor = true;
            this.lnkNavStaffs.UseCustomForeColor = true;
            this.lnkNavStaffs.UseSelectable = true;
            this.lnkNavStaffs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // lnkNavServices
            // 
            this.lnkNavServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavServices.BackColor = System.Drawing.Color.Black;
            this.lnkNavServices.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavServices.ForeColor = System.Drawing.Color.White;
            this.lnkNavServices.Location = new System.Drawing.Point(535, 8);
            this.lnkNavServices.Name = "lnkNavServices";
            this.lnkNavServices.Size = new System.Drawing.Size(130, 35);
            this.lnkNavServices.TabIndex = 0;
            this.lnkNavServices.Text = "SERVICES";
            this.lnkNavServices.UseCustomBackColor = true;
            this.lnkNavServices.UseCustomForeColor = true;
            this.lnkNavServices.UseSelectable = true;
            this.lnkNavServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // lnkNavProducts
            // 
            this.lnkNavProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavProducts.BackColor = System.Drawing.Color.Black;
            this.lnkNavProducts.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavProducts.ForeColor = System.Drawing.Color.White;
            this.lnkNavProducts.Location = new System.Drawing.Point(402, 8);
            this.lnkNavProducts.Name = "lnkNavProducts";
            this.lnkNavProducts.Size = new System.Drawing.Size(130, 35);
            this.lnkNavProducts.TabIndex = 0;
            this.lnkNavProducts.Text = "PRODUCTS";
            this.lnkNavProducts.UseCustomBackColor = true;
            this.lnkNavProducts.UseCustomForeColor = true;
            this.lnkNavProducts.UseSelectable = true;
            this.lnkNavProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // lnkNavOrders
            // 
            this.lnkNavOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavOrders.BackColor = System.Drawing.Color.Black;
            this.lnkNavOrders.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavOrders.ForeColor = System.Drawing.Color.White;
            this.lnkNavOrders.Location = new System.Drawing.Point(269, 8);
            this.lnkNavOrders.Name = "lnkNavOrders";
            this.lnkNavOrders.Size = new System.Drawing.Size(130, 35);
            this.lnkNavOrders.TabIndex = 0;
            this.lnkNavOrders.Text = "ORDERS";
            this.lnkNavOrders.UseCustomBackColor = true;
            this.lnkNavOrders.UseCustomForeColor = true;
            this.lnkNavOrders.UseSelectable = true;
            this.lnkNavOrders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // lnkNavCustomers
            // 
            this.lnkNavCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavCustomers.BackColor = System.Drawing.Color.Black;
            this.lnkNavCustomers.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavCustomers.ForeColor = System.Drawing.Color.White;
            this.lnkNavCustomers.Location = new System.Drawing.Point(136, 8);
            this.lnkNavCustomers.Name = "lnkNavCustomers";
            this.lnkNavCustomers.Size = new System.Drawing.Size(130, 35);
            this.lnkNavCustomers.TabIndex = 0;
            this.lnkNavCustomers.Text = "CUSTOMERS";
            this.lnkNavCustomers.UseCustomBackColor = true;
            this.lnkNavCustomers.UseCustomForeColor = true;
            this.lnkNavCustomers.UseSelectable = true;
            this.lnkNavCustomers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // lnkNavBookings
            // 
            this.lnkNavBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkNavBookings.BackColor = System.Drawing.Color.Black;
            this.lnkNavBookings.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNavBookings.ForeColor = System.Drawing.Color.White;
            this.lnkNavBookings.Location = new System.Drawing.Point(3, 8);
            this.lnkNavBookings.Name = "lnkNavBookings";
            this.lnkNavBookings.Size = new System.Drawing.Size(130, 35);
            this.lnkNavBookings.TabIndex = 0;
            this.lnkNavBookings.Text = "BOOKINGS";
            this.lnkNavBookings.UseCustomBackColor = true;
            this.lnkNavBookings.UseCustomForeColor = true;
            this.lnkNavBookings.UseSelectable = true;
            this.lnkNavBookings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lnkNav_MouseDown);
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 693);
            this.Controls.Add(this.tlpBase);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "HostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostForm";
            this.tlpBase.ResumeLayout(false);
            this.tlpTopNav.ResumeLayout(false);
            this.panelTabArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpTopNav;
        private System.Windows.Forms.Panel panelTabArea;
        private MetroFramework.Controls.MetroLink lnkNavBookings;
        private MetroFramework.Controls.MetroLink lnkNavOrders;
        private MetroFramework.Controls.MetroLink lnkNavCustomers;
        private MetroFramework.Controls.MetroLink lnkNavProducts;
        private MetroFramework.Controls.MetroLink lnkNavServices;
        private MetroFramework.Controls.MetroLink lnkNavStaffs;
        private MetroFramework.Controls.MetroLink lnkNavReports;
        private MetroFramework.Controls.MetroLink lnkNavMarketing;
    }
}