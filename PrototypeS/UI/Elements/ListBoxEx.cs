using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PrototypeS.UI
{
    class ListBoxExItem
    {
        private string _title;
        private string _details;
        private Image _itemImage;
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public ListBoxExItem(int id, string title, string details, Image image)
        {
            _id = id;
            _title = title;
            _details = details;
            _itemImage = image;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        public Image ItemImage
        {
            get { return _itemImage; }
            set { _itemImage = value; }
        }

        public void drawItem(DrawItemEventArgs e, Padding margin, 
                             Font titleFont, Font detailsFont, StringFormat aligment, 
                             Size imageSize)
        {            

            // if selected, mark the background differently
			Color colorSelect = Color.FromArgb(238, 238, 238);
			Color colorNormal = Color.FromArgb(255, 255, 255);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
				e.Graphics.FillRectangle(new SolidBrush(colorSelect), e.Bounds);
            }
            else
            {
				e.Graphics.FillRectangle(new SolidBrush(colorNormal), e.Bounds);
            }

            // draw some item separator
            e.Graphics.DrawLine(Pens.WhiteSmoke, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            // draw item image
			e.Graphics.DrawImage(this.ItemImage, e.Bounds.X + margin.Left, e.Bounds.Y + margin.Top, _itemImage.Size.Width, _itemImage.Size.Height);

            // calculate bounds for title text drawing
            Rectangle titleBounds = new Rectangle(e.Bounds.X + margin.Horizontal + imageSize.Width,
                                                  e.Bounds.Y + margin.Top,
                                                  e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal,
                                                  (int)titleFont.GetHeight() + 2);
            
            // calculate bounds for details text drawing
            Rectangle detailBounds = new Rectangle(e.Bounds.X + margin.Horizontal + imageSize.Width,
                                                   e.Bounds.Y + (int)titleFont.GetHeight() + 2 + margin.Vertical + margin.Top,
                                                   e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal,
                                                   e.Bounds.Height - margin.Bottom - (int)titleFont.GetHeight() - 2 - margin.Vertical - margin.Top);

            // draw the text within the bounds
            e.Graphics.DrawString(this.Title, titleFont, Brushes.Black, titleBounds, aligment);
            e.Graphics.DrawString(this.Details, detailsFont, Brushes.DarkGray, detailBounds, aligment);            
            
            // put some focus rectangle
            e.DrawFocusRectangle();
        
        }

    }

	public partial class ListBoxEx : ListBox
	{
        private Size _imageSize;
        private StringFormat _fmt;
        private Font _titleFont;
        private Font _detailsFont;

		//Custom font
		#region P/Invoke Imports
		[DllImport("gdi32")]
		internal static extern IntPtr AddFontMemResourceEx(IntPtr pbFont,
														   uint cbFont,
														   IntPtr pdv,
														   [In] ref uint pcFonts);
		[DllImport("gdi32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool RemoveFontMemResourceEx(IntPtr fh);
		#endregion

		private PrivateFontCollection m_PFC;
		private GCHandle m_pFont;
		private IntPtr m_hFont;
		private Font m_Font_Gothic10px;
		private Font m_Font_Gothic9px;

		private void SetupFont()
		{
			m_PFC = new PrivateFontCollection();

			//Load Data
			int rsxLen = PrototypeS.Properties.Resources.GOTHIC.Length;
			m_pFont = GCHandle.Alloc(PrototypeS.Properties.Resources.GOTHIC, GCHandleType.Pinned);
			m_PFC.AddMemoryFont(m_pFont.AddrOfPinnedObject(), rsxLen);
			uint rsxCnt = 1;

			//Register font
			m_hFont = AddFontMemResourceEx(m_pFont.AddrOfPinnedObject(),
												 (uint)rsxLen, IntPtr.Zero, ref rsxCnt);

			//Create font
			FontFamily ff = m_PFC.Families[0];
			if (ff.IsStyleAvailable(FontStyle.Regular))
			{
				m_Font_Gothic10px = new Font(ff, 10f, FontStyle.Regular, GraphicsUnit.Point);
				m_Font_Gothic9px = new Font(ff, 9f, FontStyle.Regular, GraphicsUnit.Point);
			}
			else
			{
				MessageBox.Show("Font error, something went terribly wrong...");
				m_Font_Gothic10px = DefaultFont;
				m_Font_Gothic9px = DefaultFont;
			}
		}

		//public ListBoxEx(Font titleFont, Font detailsFont, Size imageSize, 
		//				 StringAlignment aligment, StringAlignment lineAligment)
		//{
		//	_titleFont = titleFont;
		//	_detailsFont = detailsFont;
		//	_imageSize = imageSize;
		//	this.ItemHeight = _imageSize.Height + this.Margin.Vertical;
		//	_fmt = new StringFormat();
		//	_fmt.Alignment = aligment;
		//	_fmt.LineAlignment = lineAligment;
		//	_titleFont = titleFont;
		//	_detailsFont = detailsFont;
		//}

		public ListBoxEx()
        {
            InitializeComponent();
            _imageSize = new Size(64,64);
            this.ItemHeight = _imageSize.Height + this.Margin.Vertical;
            _fmt = new StringFormat();
            _fmt.Alignment = StringAlignment.Near;
            _fmt.LineAlignment = StringAlignment.Near;
            //_titleFont = new Font(this.Font, FontStyle.Bold);
            //_detailsFont = new Font(this.Font, FontStyle.Regular);
			SetupFont();
			_titleFont = m_Font_Gothic10px;
			_detailsFont = m_Font_Gothic9px;
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // prevent from error Visual Designer
            if (this.Items.Count > 0)            
            {                
                ListBoxExItem item = (ListBoxExItem)this.Items[e.Index];                
                item.drawItem(e, this.Margin, _titleFont, _detailsFont, _fmt, this._imageSize);
            }
		}
       

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

		protected override void Dispose(bool disposing)
		{
			#region Release Managed
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			#endregion

			#region Release Unmanaged
			m_PFC.Dispose();
			m_pFont.Free();
			RemoveFontMemResourceEx(m_hFont);
			#endregion

			base.Dispose(disposing);
		}
	}
	
	//{
	//	public ListcontrolEx()
	//	{
	//		InitializeComponent();
	//	}

	//	public ListcontrolEx(IContainer container)
	//	{
	//		container.Add(this);

	//		InitializeComponent();
	//	}
	//}
}
