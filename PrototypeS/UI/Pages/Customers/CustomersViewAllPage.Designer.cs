namespace PrototypeS.Customers
{
    partial class CustomersViewAllPage
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
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.lnkNew = new MetroFramework.Controls.MetroLink();
            this.gridList = new MetroFramework.Controls.MetroGrid();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGridSearch = new MetroFramework.Controls.MetroPanel();
            this.comboType = new MetroFramework.Controls.MetroComboBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.panelHeading = new MetroFramework.Controls.MetroPanel();
            this.labelHeadingText = new MetroFramework.Controls.MetroLabel();
            this.tlpBase.SuspendLayout();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.panelGridSearch.SuspendLayout();
            this.panelHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.panelNav, 0, 3);
            this.tlpBase.Controls.Add(this.gridList, 0, 2);
            this.tlpBase.Controls.Add(this.panelGridSearch, 0, 1);
            this.tlpBase.Controls.Add(this.panelHeading, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 4;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(1200, 750);
            this.tlpBase.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.lnkBack);
            this.panelNav.Controls.Add(this.lnkNew);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNav.HorizontalScrollbarBarColor = true;
            this.panelNav.HorizontalScrollbarHighlightOnWheel = false;
            this.panelNav.HorizontalScrollbarSize = 10;
            this.panelNav.Location = new System.Drawing.Point(3, 693);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1194, 54);
            this.panelNav.TabIndex = 122;
            this.panelNav.VerticalScrollbarBarColor = true;
            this.panelNav.VerticalScrollbarHighlightOnWheel = false;
            this.panelNav.VerticalScrollbarSize = 10;
            // 
            // lnkBack
            // 
            this.lnkBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkBack.CustomLink = true;
            this.lnkBack.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.lnkBack.Image = global::PrototypeS.Properties.Resources.back_active;
            this.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.ImageSize = 35;
            this.lnkBack.Location = new System.Drawing.Point(3, 3);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.NoFocusImage = global::PrototypeS.Properties.Resources.back_active;
            this.lnkBack.Size = new System.Drawing.Size(105, 35);
            this.lnkBack.TabIndex = 26;
            this.lnkBack.Text = "&BACK";
            this.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkBack.UseCustomForeColor = true;
            this.lnkBack.UseSelectable = true;
            // 
            // lnkNew
            // 
            this.lnkNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkNew.CustomLink = true;
            this.lnkNew.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.lnkNew.Image = global::PrototypeS.Properties.Resources.add_active;
            this.lnkNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkNew.ImageSize = 35;
            this.lnkNew.Location = new System.Drawing.Point(1085, 3);
            this.lnkNew.Name = "lnkNew";
            this.lnkNew.NoFocusImage = global::PrototypeS.Properties.Resources.add_active;
            this.lnkNew.Size = new System.Drawing.Size(105, 35);
            this.lnkNew.TabIndex = 26;
            this.lnkNew.Text = "&NEW";
            this.lnkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkNew.UseCustomForeColor = true;
            this.lnkNew.UseSelectable = true;
            this.lnkNew.Click += new System.EventHandler(this.lnkNew_Click);
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
            this.Column48,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column49,
            this.Column19,
            this.Column1,
            this.Column6,
            this.Column5});
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
            this.gridList.Location = new System.Drawing.Point(3, 90);
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
            this.gridList.Size = new System.Drawing.Size(1194, 597);
            this.gridList.TabIndex = 121;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "ID";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Width = 70;
            // 
            // Column48
            // 
            this.Column48.HeaderText = "NAME";
            this.Column48.Name = "Column48";
            this.Column48.ReadOnly = true;
            this.Column48.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "AGE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DOB";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SEX";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
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
            this.Column19.HeaderText = "OTHER PHONE";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "EMAIL";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ADDRESS";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "PACKAGE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panelGridSearch
            // 
            this.panelGridSearch.AutoScroll = true;
            this.panelGridSearch.Controls.Add(this.comboType);
            this.panelGridSearch.Controls.Add(this.txtSearch);
            this.panelGridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridSearch.HorizontalScrollbar = true;
            this.panelGridSearch.HorizontalScrollbarBarColor = true;
            this.panelGridSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGridSearch.HorizontalScrollbarSize = 10;
            this.panelGridSearch.Location = new System.Drawing.Point(0, 52);
            this.panelGridSearch.Margin = new System.Windows.Forms.Padding(0);
            this.panelGridSearch.Name = "panelGridSearch";
            this.panelGridSearch.Size = new System.Drawing.Size(1200, 35);
            this.panelGridSearch.TabIndex = 120;
            this.panelGridSearch.VerticalScrollbar = true;
            this.panelGridSearch.VerticalScrollbarBarColor = true;
            this.panelGridSearch.VerticalScrollbarHighlightOnWheel = false;
            this.panelGridSearch.VerticalScrollbarSize = 10;
            // 
            // comboType
            // 
            this.comboType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboType.FormattingEnabled = true;
            this.comboType.ItemHeight = 19;
            this.comboType.Items.AddRange(new object[] {
            "Show All"});
            this.comboType.Location = new System.Drawing.Point(1100, 5);
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
            this.txtSearch.Location = new System.Drawing.Point(863, 5);
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
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(222)))), ((int)(((byte)(43)))));
            this.panelHeading.Controls.Add(this.labelHeadingText);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeading.HorizontalScrollbarBarColor = true;
            this.panelHeading.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHeading.HorizontalScrollbarSize = 10;
            this.panelHeading.Location = new System.Drawing.Point(3, 3);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(1194, 46);
            this.panelHeading.TabIndex = 117;
            this.panelHeading.UseCustomBackColor = true;
            this.panelHeading.VerticalScrollbarBarColor = true;
            this.panelHeading.VerticalScrollbarHighlightOnWheel = false;
            this.panelHeading.VerticalScrollbarSize = 10;
            // 
            // labelHeadingText
            // 
            this.labelHeadingText.AutoSize = true;
            this.labelHeadingText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelHeadingText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelHeadingText.Location = new System.Drawing.Point(6, 10);
            this.labelHeadingText.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelHeadingText.Name = "labelHeadingText";
            this.labelHeadingText.Size = new System.Drawing.Size(122, 25);
            this.labelHeadingText.TabIndex = 116;
            this.labelHeadingText.Text = "All Customers";
            this.labelHeadingText.UseCustomBackColor = true;
            // 
            // CustomersViewAllPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpBase);
            this.Name = "CustomersViewAllPage";
            this.Size = new System.Drawing.Size(1200, 750);
            this.tlpBase.ResumeLayout(false);
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.panelGridSearch.ResumeLayout(false);
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private MetroFramework.Controls.MetroPanel panelHeading;
        private MetroFramework.Controls.MetroLabel labelHeadingText;
        private MetroFramework.Controls.MetroPanel panelGridSearch;
        private MetroFramework.Controls.MetroComboBox comboType;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroGrid gridList;
        private MetroFramework.Controls.MetroPanel panelNav;
        private MetroFramework.Controls.MetroLink lnkBack;
        private MetroFramework.Controls.MetroLink lnkNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column48;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column49;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
