using System.Windows.Forms;
namespace PrototypeS.Bookings
{
    partial class BookingsCreatePage
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
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeading = new MetroFramework.Controls.MetroPanel();
            this.labelHeadingText = new MetroFramework.Controls.MetroLabel();
            this.panelNav = new MetroFramework.Controls.MetroPanel();
            this.panelWarning = new MetroFramework.Controls.MetroPanel();
            this.labelWarningText = new MetroFramework.Controls.MetroLabel();
            this.tlpBookingDetails = new System.Windows.Forms.TableLayoutPanel();
            this.panelBookInfo = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.txtNote = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel81 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.listBoxEx1 = new System.Windows.Forms.ListBox();
            this.aptBtnMinDown = new System.Windows.Forms.Button();
            this.aptBtnMinUp = new System.Windows.Forms.Button();
            this.aptTextBoxMIN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.aptBtnHRDown = new System.Windows.Forms.Button();
            this.aptBtnHRUp = new System.Windows.Forms.Button();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.aptTextBoxHR = new MetroFramework.Controls.MetroTextBox();
            this.aptLabelAvailibility = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel65 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.aptComboTherapist = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel64 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel61 = new MetroFramework.Controls.MetroLabel();
            this.aptDTAppointDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel60 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.panelCustInfo = new MetroFramework.Controls.MetroPanel();
            this.label003 = new MetroFramework.Controls.MetroLabel();
            this.label002 = new MetroFramework.Controls.MetroLabel();
            this.label007 = new MetroFramework.Controls.MetroLabel();
            this.label006 = new MetroFramework.Controls.MetroLabel();
            this.label005 = new MetroFramework.Controls.MetroLabel();
            this.label004 = new MetroFramework.Controls.MetroLabel();
            this.labelCustSex = new MetroFramework.Controls.MetroLabel();
            this.labelCustAddr = new MetroFramework.Controls.MetroLabel();
            this.labelCustEmail = new MetroFramework.Controls.MetroLabel();
            this.labelCustOtherPhone = new MetroFramework.Controls.MetroLabel();
            this.labelCustPhone = new MetroFramework.Controls.MetroLabel();
            this.labelCustDOB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labelCustID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label001 = new MetroFramework.Controls.MetroLabel();
            this.labelCustName = new MetroFramework.Controls.MetroLabel();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.lnkSave = new MetroFramework.Controls.MetroLink();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.tlpBase.SuspendLayout();
            this.panelHeading.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.panelWarning.SuspendLayout();
            this.tlpBookingDetails.SuspendLayout();
            this.panelBookInfo.SuspendLayout();
            this.panelCustInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.panelHeading, 0, 0);
            this.tlpBase.Controls.Add(this.panelNav, 0, 3);
            this.tlpBase.Controls.Add(this.panelWarning, 0, 2);
            this.tlpBase.Controls.Add(this.tlpBookingDetails, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 4;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBase.Size = new System.Drawing.Size(1200, 750);
            this.tlpBase.TabIndex = 0;
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
            this.panelHeading.TabIndex = 116;
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
            this.labelHeadingText.Size = new System.Drawing.Size(204, 25);
            this.labelHeadingText.TabIndex = 116;
            this.labelHeadingText.Text = "Book New Appointment";
            this.labelHeadingText.UseCustomBackColor = true;
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.lnkBack);
            this.panelNav.Controls.Add(this.lnkSave);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNav.HorizontalScrollbarBarColor = true;
            this.panelNav.HorizontalScrollbarHighlightOnWheel = false;
            this.panelNav.HorizontalScrollbarSize = 10;
            this.panelNav.Location = new System.Drawing.Point(3, 693);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1194, 54);
            this.panelNav.TabIndex = 117;
            this.panelNav.VerticalScrollbarBarColor = true;
            this.panelNav.VerticalScrollbarHighlightOnWheel = false;
            this.panelNav.VerticalScrollbarSize = 10;
            // 
            // panelWarning
            // 
            this.panelWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.panelWarning.Controls.Add(this.labelWarningText);
            this.panelWarning.Controls.Add(this.pictureBox2);
            this.panelWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWarning.HorizontalScrollbarBarColor = true;
            this.panelWarning.HorizontalScrollbarHighlightOnWheel = false;
            this.panelWarning.HorizontalScrollbarSize = 10;
            this.panelWarning.Location = new System.Drawing.Point(3, 653);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(1194, 34);
            this.panelWarning.TabIndex = 120;
            this.panelWarning.UseCustomBackColor = true;
            this.panelWarning.VerticalScrollbarBarColor = true;
            this.panelWarning.VerticalScrollbarHighlightOnWheel = false;
            this.panelWarning.VerticalScrollbarSize = 10;
            this.panelWarning.Visible = false;
            // 
            // labelWarningText
            // 
            this.labelWarningText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarningText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelWarningText.ForeColor = System.Drawing.Color.White;
            this.labelWarningText.Location = new System.Drawing.Point(63, 12);
            this.labelWarningText.Name = "labelWarningText";
            this.labelWarningText.Size = new System.Drawing.Size(1091, 19);
            this.labelWarningText.TabIndex = 3;
            this.labelWarningText.Text = "Warning shown here";
            this.labelWarningText.UseCustomBackColor = true;
            this.labelWarningText.UseCustomForeColor = true;
            // 
            // tlpBookingDetails
            // 
            this.tlpBookingDetails.ColumnCount = 1;
            this.tlpBookingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBookingDetails.Controls.Add(this.panelBookInfo, 0, 1);
            this.tlpBookingDetails.Controls.Add(this.panelCustInfo, 0, 0);
            this.tlpBookingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBookingDetails.Location = new System.Drawing.Point(3, 55);
            this.tlpBookingDetails.Name = "tlpBookingDetails";
            this.tlpBookingDetails.RowCount = 2;
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBookingDetails.Size = new System.Drawing.Size(1194, 592);
            this.tlpBookingDetails.TabIndex = 121;
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.AutoScroll = true;
            this.panelBookInfo.Controls.Add(this.metroTextBox2);
            this.panelBookInfo.Controls.Add(this.txtNote);
            this.panelBookInfo.Controls.Add(this.metroLabel81);
            this.panelBookInfo.Controls.Add(this.metroLabel1);
            this.panelBookInfo.Controls.Add(this.metroLabel4);
            this.panelBookInfo.Controls.Add(this.metroLabel48);
            this.panelBookInfo.Controls.Add(this.metroLabel41);
            this.panelBookInfo.Controls.Add(this.listBoxEx1);
            this.panelBookInfo.Controls.Add(this.aptBtnMinDown);
            this.panelBookInfo.Controls.Add(this.aptBtnMinUp);
            this.panelBookInfo.Controls.Add(this.aptTextBoxMIN);
            this.panelBookInfo.Controls.Add(this.metroLabel5);
            this.panelBookInfo.Controls.Add(this.aptBtnHRDown);
            this.panelBookInfo.Controls.Add(this.aptBtnHRUp);
            this.panelBookInfo.Controls.Add(this.metroLabel39);
            this.panelBookInfo.Controls.Add(this.aptTextBoxHR);
            this.panelBookInfo.Controls.Add(this.aptLabelAvailibility);
            this.panelBookInfo.Controls.Add(this.metroLabel7);
            this.panelBookInfo.Controls.Add(this.metroLabel65);
            this.panelBookInfo.Controls.Add(this.metroComboBox2);
            this.panelBookInfo.Controls.Add(this.aptComboTherapist);
            this.panelBookInfo.Controls.Add(this.metroLabel64);
            this.panelBookInfo.Controls.Add(this.metroLabel61);
            this.panelBookInfo.Controls.Add(this.aptDTAppointDate);
            this.panelBookInfo.Controls.Add(this.metroLabel60);
            this.panelBookInfo.Controls.Add(this.metroLabel17);
            this.panelBookInfo.Controls.Add(this.metroLabel49);
            this.panelBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookInfo.HorizontalScrollbar = true;
            this.panelBookInfo.HorizontalScrollbarBarColor = true;
            this.panelBookInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBookInfo.HorizontalScrollbarSize = 10;
            this.panelBookInfo.Location = new System.Drawing.Point(3, 163);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Size = new System.Drawing.Size(1188, 426);
            this.panelBookInfo.TabIndex = 123;
            this.panelBookInfo.VerticalScrollbar = true;
            this.panelBookInfo.VerticalScrollbarBarColor = true;
            this.panelBookInfo.VerticalScrollbarHighlightOnWheel = false;
            this.panelBookInfo.VerticalScrollbarSize = 10;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(142, 107);
            this.metroTextBox2.MaxLength = 100;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(211, 23);
            this.metroTextBox2.TabIndex = 176;
            this.metroTextBox2.UseCustomBackColor = true;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNote.CustomButton.Image = null;
            this.txtNote.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txtNote.CustomButton.Name = "";
            this.txtNote.CustomButton.Size = new System.Drawing.Size(135, 135);
            this.txtNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNote.CustomButton.TabIndex = 1;
            this.txtNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNote.CustomButton.UseSelectable = true;
            this.txtNote.CustomButton.Visible = false;
            this.txtNote.Lines = new string[0];
            this.txtNote.Location = new System.Drawing.Point(844, 43);
            this.txtNote.MaxLength = 500;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PromptText = "Any additional details here..";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNote.SelectedText = "";
            this.txtNote.SelectionLength = 0;
            this.txtNote.SelectionStart = 0;
            this.txtNote.ShortcutsEnabled = true;
            this.txtNote.Size = new System.Drawing.Size(283, 140);
            this.txtNote.TabIndex = 174;
            this.txtNote.UseCustomBackColor = true;
            this.txtNote.UseSelectable = true;
            this.txtNote.WaterMark = "Any additional details here..";
            this.txtNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel81
            // 
            this.metroLabel81.AutoSize = true;
            this.metroLabel81.Location = new System.Drawing.Point(779, 43);
            this.metroLabel81.Name = "metroLabel81";
            this.metroLabel81.Size = new System.Drawing.Size(43, 19);
            this.metroLabel81.TabIndex = 173;
            this.metroLabel81.Text = "Notes";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(222)))), ((int)(((byte)(43)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(176, 25);
            this.metroLabel1.TabIndex = 172;
            this.metroLabel1.Text = "Appointment Details";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(959, 297);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 171;
            this.metroLabel4.Text = "Incl Tax (Rs.)";
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Location = new System.Drawing.Point(959, 272);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(66, 19);
            this.metroLabel48.TabIndex = 171;
            this.metroLabel48.Text = "Price (Rs.)";
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.Location = new System.Drawing.Point(959, 225);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(92, 38);
            this.metroLabel41.TabIndex = 170;
            this.metroLabel41.Text = "Total Duration\r\n(Mins)";
            // 
            // listBoxEx1
            // 
            this.listBoxEx1.BackColor = System.Drawing.Color.White;
            this.listBoxEx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxEx1.Enabled = false;
            this.listBoxEx1.FormattingEnabled = true;
            this.listBoxEx1.Location = new System.Drawing.Point(493, 77);
            this.listBoxEx1.Name = "listBoxEx1";
            this.listBoxEx1.Size = new System.Drawing.Size(246, 106);
            this.listBoxEx1.TabIndex = 162;
            this.listBoxEx1.TabStop = false;
            this.listBoxEx1.UseTabStops = false;
            // 
            // aptBtnMinDown
            // 
            this.aptBtnMinDown.BackColor = System.Drawing.Color.Black;
            this.aptBtnMinDown.FlatAppearance.BorderSize = 0;
            this.aptBtnMinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aptBtnMinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptBtnMinDown.ForeColor = System.Drawing.Color.White;
            this.aptBtnMinDown.Location = new System.Drawing.Point(330, 89);
            this.aptBtnMinDown.Name = "aptBtnMinDown";
            this.aptBtnMinDown.Size = new System.Drawing.Size(21, 11);
            this.aptBtnMinDown.TabIndex = 156;
            this.aptBtnMinDown.Text = "^";
            this.aptBtnMinDown.UseVisualStyleBackColor = false;
            // 
            // aptBtnMinUp
            // 
            this.aptBtnMinUp.BackColor = System.Drawing.Color.Black;
            this.aptBtnMinUp.FlatAppearance.BorderSize = 0;
            this.aptBtnMinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aptBtnMinUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptBtnMinUp.ForeColor = System.Drawing.Color.White;
            this.aptBtnMinUp.Location = new System.Drawing.Point(330, 77);
            this.aptBtnMinUp.Name = "aptBtnMinUp";
            this.aptBtnMinUp.Size = new System.Drawing.Size(21, 11);
            this.aptBtnMinUp.TabIndex = 155;
            this.aptBtnMinUp.Text = "^";
            this.aptBtnMinUp.UseVisualStyleBackColor = false;
            // 
            // aptTextBoxMIN
            // 
            // 
            // 
            // 
            this.aptTextBoxMIN.CustomButton.Image = null;
            this.aptTextBoxMIN.CustomButton.Location = new System.Drawing.Point(20, 1);
            this.aptTextBoxMIN.CustomButton.Name = "";
            this.aptTextBoxMIN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aptTextBoxMIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aptTextBoxMIN.CustomButton.TabIndex = 1;
            this.aptTextBoxMIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aptTextBoxMIN.CustomButton.UseSelectable = true;
            this.aptTextBoxMIN.CustomButton.Visible = false;
            this.aptTextBoxMIN.Lines = new string[0];
            this.aptTextBoxMIN.Location = new System.Drawing.Point(286, 77);
            this.aptTextBoxMIN.MaxLength = 2;
            this.aptTextBoxMIN.Name = "aptTextBoxMIN";
            this.aptTextBoxMIN.PasswordChar = '\0';
            this.aptTextBoxMIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aptTextBoxMIN.SelectedText = "";
            this.aptTextBoxMIN.SelectionLength = 0;
            this.aptTextBoxMIN.SelectionStart = 0;
            this.aptTextBoxMIN.ShortcutsEnabled = true;
            this.aptTextBoxMIN.Size = new System.Drawing.Size(42, 23);
            this.aptTextBoxMIN.TabIndex = 154;
            this.aptTextBoxMIN.UseSelectable = true;
            this.aptTextBoxMIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aptTextBoxMIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(251, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 166;
            this.metroLabel5.Text = "Min";
            // 
            // aptBtnHRDown
            // 
            this.aptBtnHRDown.BackColor = System.Drawing.Color.Black;
            this.aptBtnHRDown.FlatAppearance.BorderSize = 0;
            this.aptBtnHRDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aptBtnHRDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptBtnHRDown.ForeColor = System.Drawing.Color.White;
            this.aptBtnHRDown.Location = new System.Drawing.Point(213, 89);
            this.aptBtnHRDown.Name = "aptBtnHRDown";
            this.aptBtnHRDown.Size = new System.Drawing.Size(21, 11);
            this.aptBtnHRDown.TabIndex = 153;
            this.aptBtnHRDown.UseVisualStyleBackColor = false;
            // 
            // aptBtnHRUp
            // 
            this.aptBtnHRUp.BackColor = System.Drawing.Color.Black;
            this.aptBtnHRUp.FlatAppearance.BorderSize = 0;
            this.aptBtnHRUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aptBtnHRUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptBtnHRUp.ForeColor = System.Drawing.Color.White;
            this.aptBtnHRUp.Location = new System.Drawing.Point(213, 77);
            this.aptBtnHRUp.Margin = new System.Windows.Forms.Padding(0);
            this.aptBtnHRUp.Name = "aptBtnHRUp";
            this.aptBtnHRUp.Size = new System.Drawing.Size(21, 11);
            this.aptBtnHRUp.TabIndex = 152;
            this.aptBtnHRUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aptBtnHRUp.UseVisualStyleBackColor = false;
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Location = new System.Drawing.Point(141, 79);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(26, 19);
            this.metroLabel39.TabIndex = 165;
            this.metroLabel39.Text = "HR";
            // 
            // aptTextBoxHR
            // 
            // 
            // 
            // 
            this.aptTextBoxHR.CustomButton.Image = null;
            this.aptTextBoxHR.CustomButton.Location = new System.Drawing.Point(20, 1);
            this.aptTextBoxHR.CustomButton.Name = "";
            this.aptTextBoxHR.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aptTextBoxHR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aptTextBoxHR.CustomButton.TabIndex = 1;
            this.aptTextBoxHR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aptTextBoxHR.CustomButton.UseSelectable = true;
            this.aptTextBoxHR.CustomButton.Visible = false;
            this.aptTextBoxHR.Lines = new string[0];
            this.aptTextBoxHR.Location = new System.Drawing.Point(169, 77);
            this.aptTextBoxHR.MaxLength = 2;
            this.aptTextBoxHR.Name = "aptTextBoxHR";
            this.aptTextBoxHR.PasswordChar = '\0';
            this.aptTextBoxHR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aptTextBoxHR.SelectedText = "";
            this.aptTextBoxHR.SelectionLength = 0;
            this.aptTextBoxHR.SelectionStart = 0;
            this.aptTextBoxHR.ShortcutsEnabled = true;
            this.aptTextBoxHR.Size = new System.Drawing.Size(42, 23);
            this.aptTextBoxHR.TabIndex = 151;
            this.aptTextBoxHR.UseSelectable = true;
            this.aptTextBoxHR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aptTextBoxHR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aptLabelAvailibility
            // 
            this.aptLabelAvailibility.AutoSize = true;
            this.aptLabelAvailibility.Location = new System.Drawing.Point(142, 169);
            this.aptLabelAvailibility.Name = "aptLabelAvailibility";
            this.aptLabelAvailibility.Size = new System.Drawing.Size(33, 19);
            this.aptLabelAvailibility.TabIndex = 164;
            this.aptLabelAvailibility.Text = "N/A";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(8, 107);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 19);
            this.metroLabel7.TabIndex = 163;
            this.metroLabel7.Text = "Room / Chair No";
            // 
            // metroLabel65
            // 
            this.metroLabel65.AutoSize = true;
            this.metroLabel65.Location = new System.Drawing.Point(8, 169);
            this.metroLabel65.Name = "metroLabel65";
            this.metroLabel65.Size = new System.Drawing.Size(67, 19);
            this.metroLabel65.TabIndex = 163;
            this.metroLabel65.Text = "Availibility";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 19;
            this.metroComboBox2.Location = new System.Drawing.Point(493, 43);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.PromptText = "New";
            this.metroComboBox2.Size = new System.Drawing.Size(246, 25);
            this.metroComboBox2.TabIndex = 157;
            this.metroComboBox2.UseSelectable = true;
            // 
            // aptComboTherapist
            // 
            this.aptComboTherapist.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.aptComboTherapist.FormattingEnabled = true;
            this.aptComboTherapist.ItemHeight = 19;
            this.aptComboTherapist.Location = new System.Drawing.Point(142, 137);
            this.aptComboTherapist.Name = "aptComboTherapist";
            this.aptComboTherapist.PromptText = "Any";
            this.aptComboTherapist.Size = new System.Drawing.Size(209, 25);
            this.aptComboTherapist.TabIndex = 157;
            this.aptComboTherapist.UseSelectable = true;
            // 
            // metroLabel64
            // 
            this.metroLabel64.AutoSize = true;
            this.metroLabel64.Location = new System.Drawing.Point(8, 137);
            this.metroLabel64.Name = "metroLabel64";
            this.metroLabel64.Size = new System.Drawing.Size(35, 19);
            this.metroLabel64.TabIndex = 161;
            this.metroLabel64.Text = "Staff";
            // 
            // metroLabel61
            // 
            this.metroLabel61.AutoSize = true;
            this.metroLabel61.Location = new System.Drawing.Point(8, 76);
            this.metroLabel61.Name = "metroLabel61";
            this.metroLabel61.Size = new System.Drawing.Size(38, 19);
            this.metroLabel61.TabIndex = 160;
            this.metroLabel61.Text = "Time";
            // 
            // aptDTAppointDate
            // 
            this.aptDTAppointDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptDTAppointDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.aptDTAppointDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.aptDTAppointDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aptDTAppointDate.Location = new System.Drawing.Point(143, 46);
            this.aptDTAppointDate.Margin = new System.Windows.Forms.Padding(0);
            this.aptDTAppointDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.aptDTAppointDate.Name = "aptDTAppointDate";
            this.aptDTAppointDate.Size = new System.Drawing.Size(210, 25);
            this.aptDTAppointDate.TabIndex = 150;
            this.aptDTAppointDate.Value = new System.DateTime(2015, 9, 18, 0, 0, 0, 0);
            // 
            // metroLabel60
            // 
            this.metroLabel60.AutoSize = true;
            this.metroLabel60.Location = new System.Drawing.Point(8, 46);
            this.metroLabel60.Name = "metroLabel60";
            this.metroLabel60.Size = new System.Drawing.Size(36, 19);
            this.metroLabel60.TabIndex = 159;
            this.metroLabel60.Text = "Date";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(392, 77);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(92, 19);
            this.metroLabel17.TabIndex = 158;
            this.metroLabel17.Text = "Service Details";
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.Location = new System.Drawing.Point(392, 43);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(82, 19);
            this.metroLabel49.TabIndex = 158;
            this.metroLabel49.Text = "Service Type";
            // 
            // panelCustInfo
            // 
            this.panelCustInfo.Controls.Add(this.picCustomer);
            this.panelCustInfo.Controls.Add(this.label003);
            this.panelCustInfo.Controls.Add(this.label002);
            this.panelCustInfo.Controls.Add(this.label007);
            this.panelCustInfo.Controls.Add(this.label006);
            this.panelCustInfo.Controls.Add(this.label005);
            this.panelCustInfo.Controls.Add(this.label004);
            this.panelCustInfo.Controls.Add(this.labelCustSex);
            this.panelCustInfo.Controls.Add(this.labelCustAddr);
            this.panelCustInfo.Controls.Add(this.labelCustEmail);
            this.panelCustInfo.Controls.Add(this.labelCustOtherPhone);
            this.panelCustInfo.Controls.Add(this.labelCustPhone);
            this.panelCustInfo.Controls.Add(this.labelCustDOB);
            this.panelCustInfo.Controls.Add(this.metroLabel3);
            this.panelCustInfo.Controls.Add(this.labelCustID);
            this.panelCustInfo.Controls.Add(this.metroLabel2);
            this.panelCustInfo.Controls.Add(this.label001);
            this.panelCustInfo.Controls.Add(this.labelCustName);
            this.panelCustInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustInfo.HorizontalScrollbarBarColor = true;
            this.panelCustInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCustInfo.HorizontalScrollbarSize = 10;
            this.panelCustInfo.Location = new System.Drawing.Point(3, 3);
            this.panelCustInfo.Name = "panelCustInfo";
            this.panelCustInfo.Size = new System.Drawing.Size(1188, 154);
            this.panelCustInfo.TabIndex = 122;
            this.panelCustInfo.VerticalScrollbarBarColor = true;
            this.panelCustInfo.VerticalScrollbarHighlightOnWheel = false;
            this.panelCustInfo.VerticalScrollbarSize = 10;
            // 
            // label003
            // 
            this.label003.AutoSize = true;
            this.label003.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label003.Location = new System.Drawing.Point(143, 117);
            this.label003.Name = "label003";
            this.label003.Size = new System.Drawing.Size(29, 19);
            this.label003.TabIndex = 3;
            this.label003.Text = "Sex";
            // 
            // label002
            // 
            this.label002.AutoSize = true;
            this.label002.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label002.Location = new System.Drawing.Point(143, 90);
            this.label002.Name = "label002";
            this.label002.Size = new System.Drawing.Size(87, 19);
            this.label002.TabIndex = 3;
            this.label002.Text = "Date of Birth";
            // 
            // label007
            // 
            this.label007.AutoSize = true;
            this.label007.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label007.Location = new System.Drawing.Point(494, 115);
            this.label007.Name = "label007";
            this.label007.Size = new System.Drawing.Size(58, 19);
            this.label007.TabIndex = 3;
            this.label007.Text = "Address";
            // 
            // label006
            // 
            this.label006.AutoSize = true;
            this.label006.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label006.Location = new System.Drawing.Point(494, 89);
            this.label006.Name = "label006";
            this.label006.Size = new System.Drawing.Size(41, 19);
            this.label006.TabIndex = 3;
            this.label006.Text = "Email";
            // 
            // label005
            // 
            this.label005.AutoSize = true;
            this.label005.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label005.Location = new System.Drawing.Point(494, 63);
            this.label005.Name = "label005";
            this.label005.Size = new System.Drawing.Size(88, 19);
            this.label005.TabIndex = 3;
            this.label005.Text = "Other Phone";
            // 
            // label004
            // 
            this.label004.AutoSize = true;
            this.label004.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label004.Location = new System.Drawing.Point(494, 37);
            this.label004.Name = "label004";
            this.label004.Size = new System.Drawing.Size(48, 19);
            this.label004.TabIndex = 3;
            this.label004.Text = "Phone";
            // 
            // labelCustSex
            // 
            this.labelCustSex.AutoSize = true;
            this.labelCustSex.Location = new System.Drawing.Point(276, 117);
            this.labelCustSex.Name = "labelCustSex";
            this.labelCustSex.Size = new System.Drawing.Size(52, 19);
            this.labelCustSex.TabIndex = 3;
            this.labelCustSex.Text = "Female";
            // 
            // labelCustAddr
            // 
            this.labelCustAddr.AutoSize = true;
            this.labelCustAddr.Location = new System.Drawing.Point(629, 119);
            this.labelCustAddr.Name = "labelCustAddr";
            this.labelCustAddr.Size = new System.Drawing.Size(35, 19);
            this.labelCustAddr.TabIndex = 3;
            this.labelCustAddr.Text = "- - -";
            // 
            // labelCustEmail
            // 
            this.labelCustEmail.AutoSize = true;
            this.labelCustEmail.Location = new System.Drawing.Point(629, 91);
            this.labelCustEmail.Name = "labelCustEmail";
            this.labelCustEmail.Size = new System.Drawing.Size(129, 19);
            this.labelCustEmail.TabIndex = 3;
            this.labelCustEmail.Text = "pia.kaur@email.com";
            // 
            // labelCustOtherPhone
            // 
            this.labelCustOtherPhone.AutoSize = true;
            this.labelCustOtherPhone.Location = new System.Drawing.Point(629, 64);
            this.labelCustOtherPhone.Name = "labelCustOtherPhone";
            this.labelCustOtherPhone.Size = new System.Drawing.Size(35, 19);
            this.labelCustOtherPhone.TabIndex = 3;
            this.labelCustOtherPhone.Text = "- - -";
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.Location = new System.Drawing.Point(629, 37);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(79, 19);
            this.labelCustPhone.TabIndex = 3;
            this.labelCustPhone.Text = "0789656565";
            // 
            // labelCustDOB
            // 
            this.labelCustDOB.AutoSize = true;
            this.labelCustDOB.Location = new System.Drawing.Point(276, 90);
            this.labelCustDOB.Name = "labelCustDOB";
            this.labelCustDOB.Size = new System.Drawing.Size(75, 19);
            this.labelCustDOB.TabIndex = 3;
            this.labelCustDOB.Text = "02/02/1985";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(277, 37);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Mrs. Pia Kaur";
            // 
            // labelCustID
            // 
            this.labelCustID.AutoSize = true;
            this.labelCustID.Location = new System.Drawing.Point(276, 63);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(37, 19);
            this.labelCustID.TabIndex = 3;
            this.labelCustID.Text = "0015";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(143, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Customer Name";
            // 
            // label001
            // 
            this.label001.AutoSize = true;
            this.label001.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label001.Location = new System.Drawing.Point(143, 63);
            this.label001.Name = "label001";
            this.label001.Size = new System.Drawing.Size(87, 19);
            this.label001.TabIndex = 3;
            this.label001.Text = "Customer ID";
            // 
            // labelCustName
            // 
            this.labelCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustName.AutoSize = true;
            this.labelCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(222)))), ((int)(((byte)(43)))));
            this.labelCustName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelCustName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCustName.Location = new System.Drawing.Point(3, 1);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(147, 25);
            this.labelCustName.TabIndex = 2;
            this.labelCustName.Text = "Customer Details";
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
            // lnkSave
            // 
            this.lnkSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkSave.CustomLink = true;
            this.lnkSave.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.lnkSave.Image = global::PrototypeS.Properties.Resources.save_active;
            this.lnkSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkSave.ImageSize = 35;
            this.lnkSave.Location = new System.Drawing.Point(1083, 3);
            this.lnkSave.Name = "lnkSave";
            this.lnkSave.NoFocusImage = global::PrototypeS.Properties.Resources.save_active;
            this.lnkSave.Size = new System.Drawing.Size(105, 35);
            this.lnkSave.TabIndex = 25;
            this.lnkSave.Text = "&BOOK";
            this.lnkSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkSave.UseCustomForeColor = true;
            this.lnkSave.UseSelectable = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrototypeS.Properties.Resources.warning_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 40);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.Image = global::PrototypeS.Properties.Resources.user_female;
            this.picCustomer.Location = new System.Drawing.Point(8, 36);
            this.picCustomer.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(110, 110);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCustomer.TabIndex = 119;
            this.picCustomer.TabStop = false;
            // 
            // BookingsCreatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpBase);
            this.Name = "BookingsCreatePage";
            this.Size = new System.Drawing.Size(1200, 750);
            this.tlpBase.ResumeLayout(false);
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.panelWarning.ResumeLayout(false);
            this.tlpBookingDetails.ResumeLayout(false);
            this.panelBookInfo.ResumeLayout(false);
            this.panelBookInfo.PerformLayout();
            this.panelCustInfo.ResumeLayout(false);
            this.panelCustInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private MetroFramework.Controls.MetroPanel panelHeading;
        private MetroFramework.Controls.MetroLabel labelHeadingText;
        private MetroFramework.Controls.MetroPanel panelNav;
        private MetroFramework.Controls.MetroLink lnkBack;
        private MetroFramework.Controls.MetroLink lnkSave;
        private MetroFramework.Controls.MetroPanel panelWarning;
        private MetroFramework.Controls.MetroLabel labelWarningText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TableLayoutPanel tlpBookingDetails;
        private MetroFramework.Controls.MetroPanel panelCustInfo;
        private PictureBox picCustomer;
        private MetroFramework.Controls.MetroLabel label003;
        private MetroFramework.Controls.MetroLabel label002;
        private MetroFramework.Controls.MetroLabel label007;
        private MetroFramework.Controls.MetroLabel label006;
        private MetroFramework.Controls.MetroLabel label005;
        private MetroFramework.Controls.MetroLabel label004;
        private MetroFramework.Controls.MetroLabel labelCustSex;
        private MetroFramework.Controls.MetroLabel labelCustAddr;
        private MetroFramework.Controls.MetroLabel labelCustEmail;
        private MetroFramework.Controls.MetroLabel labelCustOtherPhone;
        private MetroFramework.Controls.MetroLabel labelCustPhone;
        private MetroFramework.Controls.MetroLabel labelCustDOB;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labelCustID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel label001;
        private MetroFramework.Controls.MetroLabel labelCustName;
        private MetroFramework.Controls.MetroPanel panelBookInfo;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox txtNote;
        private MetroFramework.Controls.MetroLabel metroLabel81;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel48;
        private MetroFramework.Controls.MetroLabel metroLabel41;
        private ListBox listBoxEx1;
        private Button aptBtnMinDown;
        private Button aptBtnMinUp;
        private MetroFramework.Controls.MetroTextBox aptTextBoxMIN;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private Button aptBtnHRDown;
        private Button aptBtnHRUp;
        private MetroFramework.Controls.MetroLabel metroLabel39;
        private MetroFramework.Controls.MetroTextBox aptTextBoxHR;
        private MetroFramework.Controls.MetroLabel aptLabelAvailibility;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel65;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox aptComboTherapist;
        private MetroFramework.Controls.MetroLabel metroLabel64;
        private MetroFramework.Controls.MetroLabel metroLabel61;
        private MetroFramework.Controls.MetroDateTime aptDTAppointDate;
        private MetroFramework.Controls.MetroLabel metroLabel60;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel49;

    }
}
