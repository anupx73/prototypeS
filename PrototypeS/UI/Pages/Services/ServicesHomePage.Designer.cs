namespace PrototypeS.ServicesPage
{
    partial class ServicesHomePage
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
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPackages = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavPackage = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tlpServices = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavService = new MetroFramework.Controls.MetroPanel();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.lbPackages = new PrototypeS.UI.ListBoxEx();
            this.lbServices = new PrototypeS.UI.ListBoxEx();
            this.lnkDeletePack = new MetroFramework.Controls.MetroLink();
            this.lnkEditPack = new MetroFramework.Controls.MetroLink();
            this.lnkNewPack = new MetroFramework.Controls.MetroLink();
            this.lnkDelService = new MetroFramework.Controls.MetroLink();
            this.lnkEditService = new MetroFramework.Controls.MetroLink();
            this.lnkNewService = new MetroFramework.Controls.MetroLink();
            this.tlpBase.SuspendLayout();
            this.panelHeading.SuspendLayout();
            this.tlpBody.SuspendLayout();
            this.tlpPackages.SuspendLayout();
            this.panelNavPackage.SuspendLayout();
            this.tlpServices.SuspendLayout();
            this.panelNavService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.panelHeading, 0, 0);
            this.tlpBase.Controls.Add(this.tlpBody, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.panelHeading.TabIndex = 3;
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
            this.labelHeadingText.Size = new System.Drawing.Size(148, 25);
            this.labelHeadingText.TabIndex = 117;
            this.labelHeadingText.Text = "Service Summary";
            this.labelHeadingText.UseCustomBackColor = true;
            // 
            // tlpBody
            // 
            this.tlpBody.ColumnCount = 2;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.95477F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.04523F));
            this.tlpBody.Controls.Add(this.tlpPackages, 1, 0);
            this.tlpBody.Controls.Add(this.tlpServices, 0, 0);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.Location = new System.Drawing.Point(3, 55);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 1;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Size = new System.Drawing.Size(1194, 692);
            this.tlpBody.TabIndex = 4;
            // 
            // tlpPackages
            // 
            this.tlpPackages.ColumnCount = 1;
            this.tlpPackages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPackages.Controls.Add(this.panelNavPackage, 0, 2);
            this.tlpPackages.Controls.Add(this.metroLink1, 0, 0);
            this.tlpPackages.Controls.Add(this.lbPackages, 0, 1);
            this.tlpPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPackages.Location = new System.Drawing.Point(491, 3);
            this.tlpPackages.Name = "tlpPackages";
            this.tlpPackages.RowCount = 3;
            this.tlpPackages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPackages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPackages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpPackages.Size = new System.Drawing.Size(700, 686);
            this.tlpPackages.TabIndex = 1;
            // 
            // panelNavPackage
            // 
            this.panelNavPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(222)))), ((int)(((byte)(43)))));
            this.panelNavPackage.Controls.Add(this.lnkDeletePack);
            this.panelNavPackage.Controls.Add(this.lnkEditPack);
            this.panelNavPackage.Controls.Add(this.lnkNewPack);
            this.panelNavPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavPackage.HorizontalScrollbarBarColor = true;
            this.panelNavPackage.HorizontalScrollbarHighlightOnWheel = false;
            this.panelNavPackage.HorizontalScrollbarSize = 10;
            this.panelNavPackage.Location = new System.Drawing.Point(3, 629);
            this.panelNavPackage.Name = "panelNavPackage";
            this.panelNavPackage.Size = new System.Drawing.Size(694, 54);
            this.panelNavPackage.TabIndex = 96;
            this.panelNavPackage.VerticalScrollbarBarColor = true;
            this.panelNavPackage.VerticalScrollbarHighlightOnWheel = false;
            this.panelNavPackage.VerticalScrollbarSize = 10;
            // 
            // metroLink1
            // 
            this.metroLink1.AutoSize = true;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.ForeColor = System.Drawing.Color.Black;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(3, 0);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(194, 24);
            this.metroLink1.TabIndex = 95;
            this.metroLink1.Text = "List of Packages";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // tlpServices
            // 
            this.tlpServices.ColumnCount = 1;
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServices.Controls.Add(this.panelNavService, 0, 2);
            this.tlpServices.Controls.Add(this.metroLink4, 0, 0);
            this.tlpServices.Controls.Add(this.lbServices, 0, 1);
            this.tlpServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServices.Location = new System.Drawing.Point(3, 3);
            this.tlpServices.Name = "tlpServices";
            this.tlpServices.RowCount = 3;
            this.tlpServices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpServices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpServices.Size = new System.Drawing.Size(482, 686);
            this.tlpServices.TabIndex = 0;
            // 
            // panelNavService
            // 
            this.panelNavService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(222)))), ((int)(((byte)(43)))));
            this.panelNavService.Controls.Add(this.lnkDelService);
            this.panelNavService.Controls.Add(this.lnkEditService);
            this.panelNavService.Controls.Add(this.lnkNewService);
            this.panelNavService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavService.HorizontalScrollbarBarColor = true;
            this.panelNavService.HorizontalScrollbarHighlightOnWheel = false;
            this.panelNavService.HorizontalScrollbarSize = 10;
            this.panelNavService.Location = new System.Drawing.Point(3, 629);
            this.panelNavService.Name = "panelNavService";
            this.panelNavService.Size = new System.Drawing.Size(476, 54);
            this.panelNavService.TabIndex = 96;
            this.panelNavService.VerticalScrollbarBarColor = true;
            this.panelNavService.VerticalScrollbarHighlightOnWheel = false;
            this.panelNavService.VerticalScrollbarSize = 10;
            // 
            // metroLink4
            // 
            this.metroLink4.AutoSize = true;
            this.metroLink4.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink4.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink4.ForeColor = System.Drawing.Color.Black;
            this.metroLink4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink4.ImageSize = 32;
            this.metroLink4.Location = new System.Drawing.Point(3, 0);
            this.metroLink4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(194, 24);
            this.metroLink4.TabIndex = 95;
            this.metroLink4.Text = "List of Services";
            this.metroLink4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink4.UseCustomForeColor = true;
            this.metroLink4.UseSelectable = true;
            // 
            // lbPackages
            // 
            this.lbPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPackages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbPackages.FormattingEnabled = true;
            this.lbPackages.ItemHeight = 70;
            this.lbPackages.Location = new System.Drawing.Point(3, 38);
            this.lbPackages.Name = "lbPackages";
            this.lbPackages.Size = new System.Drawing.Size(694, 585);
            this.lbPackages.TabIndex = 97;
            // 
            // lbServices
            // 
            this.lbServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbServices.FormattingEnabled = true;
            this.lbServices.ItemHeight = 70;
            this.lbServices.Location = new System.Drawing.Point(3, 38);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(476, 585);
            this.lbServices.TabIndex = 97;
            // 
            // lnkDeletePack
            // 
            this.lnkDeletePack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDeletePack.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkDeletePack.CustomLink = true;
            this.lnkDeletePack.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkDeletePack.ForeColor = System.Drawing.Color.Black;
            this.lnkDeletePack.Image = global::PrototypeS.Properties.Resources.cancel_active;
            this.lnkDeletePack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDeletePack.ImageSize = 35;
            this.lnkDeletePack.Location = new System.Drawing.Point(586, 3);
            this.lnkDeletePack.Name = "lnkDeletePack";
            this.lnkDeletePack.NoFocusImage = global::PrototypeS.Properties.Resources.cancel_active;
            this.lnkDeletePack.Size = new System.Drawing.Size(105, 35);
            this.lnkDeletePack.TabIndex = 28;
            this.lnkDeletePack.Text = "&DELETE";
            this.lnkDeletePack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDeletePack.UseCustomForeColor = true;
            this.lnkDeletePack.UseSelectable = true;
            // 
            // lnkEditPack
            // 
            this.lnkEditPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEditPack.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkEditPack.CustomLink = true;
            this.lnkEditPack.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkEditPack.ForeColor = System.Drawing.Color.Black;
            this.lnkEditPack.Image = global::PrototypeS.Properties.Resources.edit_active;
            this.lnkEditPack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEditPack.ImageSize = 35;
            this.lnkEditPack.Location = new System.Drawing.Point(475, 3);
            this.lnkEditPack.Name = "lnkEditPack";
            this.lnkEditPack.NoFocusImage = global::PrototypeS.Properties.Resources.edit_active;
            this.lnkEditPack.Size = new System.Drawing.Size(105, 35);
            this.lnkEditPack.TabIndex = 29;
            this.lnkEditPack.Text = "&EDIT";
            this.lnkEditPack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkEditPack.UseCustomForeColor = true;
            this.lnkEditPack.UseSelectable = true;
            // 
            // lnkNewPack
            // 
            this.lnkNewPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkNewPack.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkNewPack.CustomLink = true;
            this.lnkNewPack.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNewPack.ForeColor = System.Drawing.Color.Black;
            this.lnkNewPack.Image = global::PrototypeS.Properties.Resources.add_active;
            this.lnkNewPack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkNewPack.ImageSize = 35;
            this.lnkNewPack.Location = new System.Drawing.Point(364, 3);
            this.lnkNewPack.Name = "lnkNewPack";
            this.lnkNewPack.NoFocusImage = global::PrototypeS.Properties.Resources.add_active;
            this.lnkNewPack.Size = new System.Drawing.Size(105, 35);
            this.lnkNewPack.TabIndex = 30;
            this.lnkNewPack.Text = "&NEW";
            this.lnkNewPack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkNewPack.UseCustomForeColor = true;
            this.lnkNewPack.UseSelectable = true;
            this.lnkNewPack.Click += new System.EventHandler(this.lnkNewPack_Click);
            // 
            // lnkDelService
            // 
            this.lnkDelService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDelService.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkDelService.CustomLink = true;
            this.lnkDelService.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkDelService.ForeColor = System.Drawing.Color.Black;
            this.lnkDelService.Image = global::PrototypeS.Properties.Resources.cancel_active;
            this.lnkDelService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDelService.ImageSize = 35;
            this.lnkDelService.Location = new System.Drawing.Point(367, 3);
            this.lnkDelService.Name = "lnkDelService";
            this.lnkDelService.NoFocusImage = global::PrototypeS.Properties.Resources.cancel_active;
            this.lnkDelService.Size = new System.Drawing.Size(105, 35);
            this.lnkDelService.TabIndex = 28;
            this.lnkDelService.Text = "&DELETE";
            this.lnkDelService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDelService.UseCustomForeColor = true;
            this.lnkDelService.UseSelectable = true;
            // 
            // lnkEditService
            // 
            this.lnkEditService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEditService.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkEditService.CustomLink = true;
            this.lnkEditService.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkEditService.ForeColor = System.Drawing.Color.Black;
            this.lnkEditService.Image = global::PrototypeS.Properties.Resources.edit_active;
            this.lnkEditService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEditService.ImageSize = 35;
            this.lnkEditService.Location = new System.Drawing.Point(256, 3);
            this.lnkEditService.Name = "lnkEditService";
            this.lnkEditService.NoFocusImage = global::PrototypeS.Properties.Resources.edit_active;
            this.lnkEditService.Size = new System.Drawing.Size(105, 35);
            this.lnkEditService.TabIndex = 29;
            this.lnkEditService.Text = "&EDIT";
            this.lnkEditService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkEditService.UseCustomForeColor = true;
            this.lnkEditService.UseSelectable = true;
            // 
            // lnkNewService
            // 
            this.lnkNewService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkNewService.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnkNewService.CustomLink = true;
            this.lnkNewService.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkNewService.ForeColor = System.Drawing.Color.Black;
            this.lnkNewService.Image = global::PrototypeS.Properties.Resources.add_active;
            this.lnkNewService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkNewService.ImageSize = 35;
            this.lnkNewService.Location = new System.Drawing.Point(145, 3);
            this.lnkNewService.Name = "lnkNewService";
            this.lnkNewService.NoFocusImage = global::PrototypeS.Properties.Resources.add_active;
            this.lnkNewService.Size = new System.Drawing.Size(105, 35);
            this.lnkNewService.TabIndex = 30;
            this.lnkNewService.Text = "&NEW";
            this.lnkNewService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkNewService.UseCustomForeColor = true;
            this.lnkNewService.UseSelectable = true;
            this.lnkNewService.Click += new System.EventHandler(this.lnkNewService_Click);
            // 
            // ServicesHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpBase);
            this.Name = "ServicesHomePage";
            this.Size = new System.Drawing.Size(1200, 750);
            this.tlpBase.ResumeLayout(false);
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            this.tlpBody.ResumeLayout(false);
            this.tlpPackages.ResumeLayout(false);
            this.tlpPackages.PerformLayout();
            this.panelNavPackage.ResumeLayout(false);
            this.tlpServices.ResumeLayout(false);
            this.tlpServices.PerformLayout();
            this.panelNavService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private MetroFramework.Controls.MetroPanel panelHeading;
        private MetroFramework.Controls.MetroLabel labelHeadingText;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.TableLayoutPanel tlpServices;
        private System.Windows.Forms.TableLayoutPanel tlpPackages;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroPanel panelNavPackage;
        private MetroFramework.Controls.MetroPanel panelNavService;
        private MetroFramework.Controls.MetroLink lnkDeletePack;
        private MetroFramework.Controls.MetroLink lnkEditPack;
        private MetroFramework.Controls.MetroLink lnkNewPack;
        private MetroFramework.Controls.MetroLink lnkDelService;
        private MetroFramework.Controls.MetroLink lnkEditService;
        private MetroFramework.Controls.MetroLink lnkNewService;
        private UI.ListBoxEx lbPackages;
        private UI.ListBoxEx lbServices;
    }
}
