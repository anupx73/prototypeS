namespace PrototypeS.Bookings
{
    partial class BookingsHomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.panelNav = new MetroFramework.Controls.MetroPanel();
            this.bookLnkCancel = new MetroFramework.Controls.MetroLink();
            this.bookLnkCheckOut = new MetroFramework.Controls.MetroLink();
            this.bookLnkEdit = new MetroFramework.Controls.MetroLink();
            this.gridList = new MetroFramework.Controls.MetroGrid();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGridSearch = new MetroFramework.Controls.MetroPanel();
            this.lnkFilterTomorrow = new MetroFramework.Controls.MetroLink();
            this.lnkFilterToday = new MetroFramework.Controls.MetroLink();
            this.comboType = new MetroFramework.Controls.MetroComboBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel113 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel123 = new MetroFramework.Controls.MetroLabel();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.txtHeader = new MetroFramework.Controls.MetroLabel();
            this.panelSmartSearch = new System.Windows.Forms.Panel();
            this.panelTypeDropDown = new System.Windows.Forms.Panel();
            this.lnkDropDownEmail = new MetroFramework.Controls.MetroLink();
            this.lnkDropDownPhone = new MetroFramework.Controls.MetroLink();
            this.lnkDropDownName = new MetroFramework.Controls.MetroLink();
            this.linkSearchType = new MetroFramework.Controls.MetroLink();
            this.panelSearchBoxBk = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.labelHeading = new MetroFramework.Controls.MetroLabel();
            this.tlpBase.SuspendLayout();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.panelGridSearch.SuspendLayout();
            this.panelSmartSearch.SuspendLayout();
            this.panelTypeDropDown.SuspendLayout();
            this.panelSearchBoxBk.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.panelNav, 0, 2);
            this.tlpBase.Controls.Add(this.gridList, 0, 1);
            this.tlpBase.Controls.Add(this.panelGridSearch, 0, 1);
            this.tlpBase.Controls.Add(this.panelSmartSearch, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 3;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(1200, 750);
            this.tlpBase.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNav.Controls.Add(this.bookLnkCancel);
            this.panelNav.Controls.Add(this.bookLnkCheckOut);
            this.panelNav.Controls.Add(this.bookLnkEdit);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNav.HorizontalScrollbarBarColor = true;
            this.panelNav.HorizontalScrollbarHighlightOnWheel = false;
            this.panelNav.HorizontalScrollbarSize = 10;
            this.panelNav.Location = new System.Drawing.Point(3, 693);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1194, 54);
            this.panelNav.TabIndex = 86;
            this.panelNav.VerticalScrollbarBarColor = true;
            this.panelNav.VerticalScrollbarHighlightOnWheel = false;
            this.panelNav.VerticalScrollbarSize = 10;
            // 
            // bookLnkCancel
            // 
            this.bookLnkCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookLnkCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookLnkCancel.CustomLink = true;
            this.bookLnkCancel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bookLnkCancel.ForeColor = System.Drawing.Color.Black;
            this.bookLnkCancel.Image = global::PrototypeS.Properties.Resources.cancel_active;
            this.bookLnkCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookLnkCancel.ImageSize = 35;
            this.bookLnkCancel.Location = new System.Drawing.Point(843, 3);
            this.bookLnkCancel.Name = "bookLnkCancel";
            this.bookLnkCancel.NoFocusImage = global::PrototypeS.Properties.Resources.cancel_active;
            this.bookLnkCancel.Size = new System.Drawing.Size(105, 35);
            this.bookLnkCancel.TabIndex = 2;
            this.bookLnkCancel.Text = "&CANCEL";
            this.bookLnkCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookLnkCancel.UseCustomForeColor = true;
            this.bookLnkCancel.UseSelectable = true;
            // 
            // bookLnkCheckOut
            // 
            this.bookLnkCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookLnkCheckOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookLnkCheckOut.CustomLink = true;
            this.bookLnkCheckOut.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bookLnkCheckOut.ForeColor = System.Drawing.Color.Black;
            this.bookLnkCheckOut.Image = global::PrototypeS.Properties.Resources.bill_active;
            this.bookLnkCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookLnkCheckOut.ImageSize = 35;
            this.bookLnkCheckOut.Location = new System.Drawing.Point(1065, 3);
            this.bookLnkCheckOut.Name = "bookLnkCheckOut";
            this.bookLnkCheckOut.NoFocusImage = global::PrototypeS.Properties.Resources.bill_active;
            this.bookLnkCheckOut.Size = new System.Drawing.Size(123, 35);
            this.bookLnkCheckOut.TabIndex = 2;
            this.bookLnkCheckOut.Text = "C&HECK OUT";
            this.bookLnkCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookLnkCheckOut.UseCustomForeColor = true;
            this.bookLnkCheckOut.UseSelectable = true;
            this.bookLnkCheckOut.Click += new System.EventHandler(this.bookLnkCheckOut_Click);
            // 
            // bookLnkEdit
            // 
            this.bookLnkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookLnkEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookLnkEdit.CustomLink = true;
            this.bookLnkEdit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bookLnkEdit.ForeColor = System.Drawing.Color.Black;
            this.bookLnkEdit.Image = global::PrototypeS.Properties.Resources.edit_active;
            this.bookLnkEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookLnkEdit.ImageSize = 35;
            this.bookLnkEdit.Location = new System.Drawing.Point(954, 3);
            this.bookLnkEdit.Name = "bookLnkEdit";
            this.bookLnkEdit.NoFocusImage = global::PrototypeS.Properties.Resources.edit_active;
            this.bookLnkEdit.Size = new System.Drawing.Size(105, 35);
            this.bookLnkEdit.TabIndex = 2;
            this.bookLnkEdit.Text = "&EDIT";
            this.bookLnkEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookLnkEdit.UseCustomForeColor = true;
            this.bookLnkEdit.UseSelectable = true;
            this.bookLnkEdit.Click += new System.EventHandler(this.bookLnkEdit_Click);
            // 
            // gridList
            // 
            this.gridList.AllowUserToAddRows = false;
            this.gridList.AllowUserToDeleteRows = false;
            this.gridList.AllowUserToResizeRows = false;
            this.gridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridList.ColumnHeadersHeight = 30;
            this.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column28,
            this.Column36,
            this.Column47,
            this.Column48,
            this.Column49,
            this.Column19,
            this.Column50,
            this.Column18,
            this.Column51,
            this.Column29});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.EnableHeadersVisualStyles = false;
            this.gridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridList.Location = new System.Drawing.Point(3, 178);
            this.gridList.Name = "gridList";
            this.gridList.ReadOnly = true;
            this.gridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridList.RowHeadersVisible = false;
            this.gridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridList.Size = new System.Drawing.Size(1194, 509);
            this.gridList.TabIndex = 85;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "ID";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Width = 70;
            // 
            // Column36
            // 
            this.Column36.HeaderText = "DATE";
            this.Column36.Name = "Column36";
            this.Column36.ReadOnly = true;
            this.Column36.Width = 80;
            // 
            // Column47
            // 
            this.Column47.HeaderText = "TIME";
            this.Column47.Name = "Column47";
            this.Column47.ReadOnly = true;
            this.Column47.Width = 80;
            // 
            // Column48
            // 
            this.Column48.HeaderText = "NAME";
            this.Column48.Name = "Column48";
            this.Column48.ReadOnly = true;
            this.Column48.Width = 180;
            // 
            // Column49
            // 
            this.Column49.HeaderText = "PHONE";
            this.Column49.Name = "Column49";
            this.Column49.ReadOnly = true;
            this.Column49.Width = 130;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "ALT. PHONE";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 130;
            // 
            // Column50
            // 
            this.Column50.HeaderText = "SERVICES";
            this.Column50.Name = "Column50";
            this.Column50.ReadOnly = true;
            this.Column50.Width = 180;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "CHAIR NO";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column51
            // 
            this.Column51.HeaderText = "STAFF";
            this.Column51.MinimumWidth = 50;
            this.Column51.Name = "Column51";
            this.Column51.ReadOnly = true;
            this.Column51.Width = 150;
            // 
            // Column29
            // 
            this.Column29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column29.HeaderText = "STATUS";
            this.Column29.MinimumWidth = 50;
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            // 
            // panelGridSearch
            // 
            this.panelGridSearch.AutoScroll = true;
            this.panelGridSearch.Controls.Add(this.lnkFilterTomorrow);
            this.panelGridSearch.Controls.Add(this.lnkFilterToday);
            this.panelGridSearch.Controls.Add(this.comboType);
            this.panelGridSearch.Controls.Add(this.txtSearch);
            this.panelGridSearch.Controls.Add(this.metroLabel113);
            this.panelGridSearch.Controls.Add(this.metroLabel123);
            this.panelGridSearch.Controls.Add(this.dtTo);
            this.panelGridSearch.Controls.Add(this.dtFrom);
            this.panelGridSearch.Controls.Add(this.txtHeader);
            this.panelGridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridSearch.HorizontalScrollbar = true;
            this.panelGridSearch.HorizontalScrollbarBarColor = true;
            this.panelGridSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGridSearch.HorizontalScrollbarSize = 10;
            this.panelGridSearch.Location = new System.Drawing.Point(0, 140);
            this.panelGridSearch.Margin = new System.Windows.Forms.Padding(0);
            this.panelGridSearch.Name = "panelGridSearch";
            this.panelGridSearch.Size = new System.Drawing.Size(1200, 35);
            this.panelGridSearch.TabIndex = 84;
            this.panelGridSearch.VerticalScrollbar = true;
            this.panelGridSearch.VerticalScrollbarBarColor = true;
            this.panelGridSearch.VerticalScrollbarHighlightOnWheel = false;
            this.panelGridSearch.VerticalScrollbarSize = 10;
            // 
            // lnkFilterTomorrow
            // 
            this.lnkFilterTomorrow.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkFilterTomorrow.ForeColor = System.Drawing.Color.Black;
            this.lnkFilterTomorrow.Image = global::PrototypeS.Properties.Resources.tomorrow_filter;
            this.lnkFilterTomorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkFilterTomorrow.Location = new System.Drawing.Point(315, 5);
            this.lnkFilterTomorrow.Name = "lnkFilterTomorrow";
            this.lnkFilterTomorrow.NoFocusImage = global::PrototypeS.Properties.Resources.tomorrow_filter;
            this.lnkFilterTomorrow.Size = new System.Drawing.Size(155, 23);
            this.lnkFilterTomorrow.TabIndex = 102;
            this.lnkFilterTomorrow.Text = "Tomorrow\'s Booking";
            this.lnkFilterTomorrow.UseCustomForeColor = true;
            this.lnkFilterTomorrow.UseSelectable = true;
            // 
            // lnkFilterToday
            // 
            this.lnkFilterToday.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkFilterToday.Image = global::PrototypeS.Properties.Resources.today_filter;
            this.lnkFilterToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkFilterToday.Location = new System.Drawing.Point(182, 5);
            this.lnkFilterToday.Name = "lnkFilterToday";
            this.lnkFilterToday.NoFocusImage = global::PrototypeS.Properties.Resources.today_filter;
            this.lnkFilterToday.Size = new System.Drawing.Size(129, 23);
            this.lnkFilterToday.TabIndex = 102;
            this.lnkFilterToday.Text = "Today\'s Booking";
            this.lnkFilterToday.UseCustomForeColor = true;
            this.lnkFilterToday.UseSelectable = true;
            // 
            // comboType
            // 
            this.comboType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboType.FormattingEnabled = true;
            this.comboType.ItemHeight = 19;
            this.comboType.Items.AddRange(new object[] {
            "Show All"});
            this.comboType.Location = new System.Drawing.Point(848, 4);
            this.comboType.Name = "comboType";
            this.comboType.PromptText = "All";
            this.comboType.Size = new System.Drawing.Size(92, 25);
            this.comboType.TabIndex = 100;
            this.comboType.UseSelectable = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Icon = global::PrototypeS.Properties.Resources.search_small;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(611, 4);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(239, 25);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.White;
            this.txtSearch.TabIndex = 101;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel113
            // 
            this.metroLabel113.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel113.AutoSize = true;
            this.metroLabel113.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel113.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel113.Location = new System.Drawing.Point(1085, 8);
            this.metroLabel113.Name = "metroLabel113";
            this.metroLabel113.Size = new System.Drawing.Size(21, 15);
            this.metroLabel113.TabIndex = 98;
            this.metroLabel113.Text = "To";
            // 
            // metroLabel123
            // 
            this.metroLabel123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel123.AutoSize = true;
            this.metroLabel123.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel123.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel123.Location = new System.Drawing.Point(952, 8);
            this.metroLabel123.Name = "metroLabel123";
            this.metroLabel123.Size = new System.Drawing.Size(35, 15);
            this.metroLabel123.TabIndex = 99;
            this.metroLabel123.Text = "From";
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.dtTo.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtTo.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(1109, 4);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(87, 25);
            this.dtTo.TabIndex = 96;
            this.dtTo.TabStop = false;
            this.dtTo.Value = new System.DateTime(2015, 9, 18, 0, 0, 0, 0);
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.dtFrom.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtFrom.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(990, 4);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(87, 25);
            this.dtFrom.TabIndex = 97;
            this.dtFrom.TabStop = false;
            this.dtFrom.Value = new System.DateTime(2015, 9, 18, 0, 0, 0, 0);
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtHeader.ForeColor = System.Drawing.Color.Black;
            this.txtHeader.Location = new System.Drawing.Point(0, 2);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(109, 25);
            this.txtHeader.TabIndex = 58;
            this.txtHeader.Text = "Booking List";
            this.txtHeader.UseCustomForeColor = true;
            // 
            // panelSmartSearch
            // 
            this.panelSmartSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(222)))), ((int)(((byte)(43)))));
            this.panelSmartSearch.Controls.Add(this.panelTypeDropDown);
            this.panelSmartSearch.Controls.Add(this.linkSearchType);
            this.panelSmartSearch.Controls.Add(this.panelSearchBoxBk);
            this.panelSmartSearch.Controls.Add(this.labelHeading);
            this.panelSmartSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSmartSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSmartSearch.Name = "panelSmartSearch";
            this.panelSmartSearch.Size = new System.Drawing.Size(1194, 134);
            this.panelSmartSearch.TabIndex = 83;
            this.panelSmartSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelSmartSearch_MouseClick);
            // 
            // panelTypeDropDown
            // 
            this.panelTypeDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTypeDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(209)))), ((int)(((byte)(7)))));
            this.panelTypeDropDown.Controls.Add(this.lnkDropDownEmail);
            this.panelTypeDropDown.Controls.Add(this.lnkDropDownPhone);
            this.panelTypeDropDown.Controls.Add(this.lnkDropDownName);
            this.panelTypeDropDown.Location = new System.Drawing.Point(1014, 62);
            this.panelTypeDropDown.Margin = new System.Windows.Forms.Padding(0);
            this.panelTypeDropDown.Name = "panelTypeDropDown";
            this.panelTypeDropDown.Size = new System.Drawing.Size(149, 69);
            this.panelTypeDropDown.TabIndex = 4;
            this.panelTypeDropDown.Visible = false;
            // 
            // lnkDropDownEmail
            // 
            this.lnkDropDownEmail.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkDropDownEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDropDownEmail.Location = new System.Drawing.Point(4, 47);
            this.lnkDropDownEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lnkDropDownEmail.Name = "lnkDropDownEmail";
            this.lnkDropDownEmail.Size = new System.Drawing.Size(122, 16);
            this.lnkDropDownEmail.TabIndex = 2;
            this.lnkDropDownEmail.Text = "      Email";
            this.lnkDropDownEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDropDownEmail.UseCustomBackColor = true;
            this.lnkDropDownEmail.UseCustomForeColor = true;
            this.lnkDropDownEmail.UseSelectable = true;
            this.lnkDropDownEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkDropDown_Click);
            // 
            // lnkDropDownPhone
            // 
            this.lnkDropDownPhone.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkDropDownPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDropDownPhone.Location = new System.Drawing.Point(4, 26);
            this.lnkDropDownPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lnkDropDownPhone.Name = "lnkDropDownPhone";
            this.lnkDropDownPhone.Size = new System.Drawing.Size(122, 16);
            this.lnkDropDownPhone.TabIndex = 1;
            this.lnkDropDownPhone.Text = "      Phone";
            this.lnkDropDownPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDropDownPhone.UseCustomBackColor = true;
            this.lnkDropDownPhone.UseCustomForeColor = true;
            this.lnkDropDownPhone.UseSelectable = true;
            this.lnkDropDownPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkDropDown_Click);
            // 
            // lnkDropDownName
            // 
            this.lnkDropDownName.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkDropDownName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDropDownName.Location = new System.Drawing.Point(4, 4);
            this.lnkDropDownName.Margin = new System.Windows.Forms.Padding(0);
            this.lnkDropDownName.Name = "lnkDropDownName";
            this.lnkDropDownName.Size = new System.Drawing.Size(122, 16);
            this.lnkDropDownName.TabIndex = 0;
            this.lnkDropDownName.Text = "      Name";
            this.lnkDropDownName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDropDownName.UseCustomBackColor = true;
            this.lnkDropDownName.UseCustomForeColor = true;
            this.lnkDropDownName.UseSelectable = true;
            this.lnkDropDownName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkDropDown_Click);
            // 
            // linkSearchType
            // 
            this.linkSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSearchType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(209)))), ((int)(((byte)(7)))));
            this.linkSearchType.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkSearchType.Image = global::PrototypeS.Properties.Resources.drop_down_arrow;
            this.linkSearchType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkSearchType.ImageSize = 36;
            this.linkSearchType.Location = new System.Drawing.Point(1018, 27);
            this.linkSearchType.Margin = new System.Windows.Forms.Padding(3, 41, 3, 0);
            this.linkSearchType.Name = "linkSearchType";
            this.linkSearchType.NoFocusImage = global::PrototypeS.Properties.Resources.drop_down_arrow;
            this.linkSearchType.Size = new System.Drawing.Size(144, 36);
            this.linkSearchType.TabIndex = 3;
            this.linkSearchType.Text = "      Name";
            this.linkSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkSearchType.UseCustomBackColor = true;
            this.linkSearchType.UseCustomForeColor = true;
            this.linkSearchType.UseSelectable = true;
            this.linkSearchType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.linkSearchType_MouseDown);
            // 
            // panelSearchBoxBk
            // 
            this.panelSearchBoxBk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchBoxBk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(209)))), ((int)(((byte)(7)))));
            this.panelSearchBoxBk.Controls.Add(this.metroTextBox1);
            this.panelSearchBoxBk.Location = new System.Drawing.Point(175, 27);
            this.panelSearchBoxBk.Name = "panelSearchBoxBk";
            this.panelSearchBoxBk.Padding = new System.Windows.Forms.Padding(5);
            this.panelSearchBoxBk.Size = new System.Drawing.Size(844, 36);
            this.panelSearchBoxBk.TabIndex = 2;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(810, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Icon = global::PrototypeS.Properties.Resources.search_small;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(5, 5);
            this.metroTextBox1.MaxLength = 100;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search or Add Customer Name / Phone / Email";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowClearButton = true;
            this.metroTextBox1.Size = new System.Drawing.Size(834, 26);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMark = "Search or Add Customer Name / Phone / Email";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelHeading.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelHeading.Location = new System.Drawing.Point(12, 30);
            this.labelHeading.Margin = new System.Windows.Forms.Padding(13, 45, 3, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(158, 25);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "New Appointment";
            this.labelHeading.UseCustomBackColor = true;
            // 
            // BookingsHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpBase);
            this.Name = "BookingsHomePage";
            this.Size = new System.Drawing.Size(1200, 750);
            this.tlpBase.ResumeLayout(false);
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.panelGridSearch.ResumeLayout(false);
            this.panelGridSearch.PerformLayout();
            this.panelSmartSearch.ResumeLayout(false);
            this.panelSmartSearch.PerformLayout();
            this.panelTypeDropDown.ResumeLayout(false);
            this.panelSearchBoxBk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Panel panelSmartSearch;
        private System.Windows.Forms.Panel panelTypeDropDown;
        private MetroFramework.Controls.MetroLink lnkDropDownEmail;
        private MetroFramework.Controls.MetroLink lnkDropDownPhone;
        private MetroFramework.Controls.MetroLink lnkDropDownName;
        private MetroFramework.Controls.MetroLink linkSearchType;
        private System.Windows.Forms.Panel panelSearchBoxBk;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel labelHeading;
        private MetroFramework.Controls.MetroPanel panelGridSearch;
        private MetroFramework.Controls.MetroLink lnkFilterTomorrow;
        private MetroFramework.Controls.MetroLink lnkFilterToday;
        private MetroFramework.Controls.MetroComboBox comboType;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel113;
        private MetroFramework.Controls.MetroLabel metroLabel123;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroLabel txtHeader;
        private MetroFramework.Controls.MetroGrid gridList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column47;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column48;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column49;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column50;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column51;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private MetroFramework.Controls.MetroPanel panelNav;
        private MetroFramework.Controls.MetroLink bookLnkCancel;
        private MetroFramework.Controls.MetroLink bookLnkCheckOut;
        private MetroFramework.Controls.MetroLink bookLnkEdit;

    }
}
