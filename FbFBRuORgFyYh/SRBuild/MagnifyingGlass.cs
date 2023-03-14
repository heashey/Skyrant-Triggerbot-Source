using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SRBuild
{
	// Token: 0x02000028 RID: 40
	public class MagnifyingGlass : UserControl
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00011BDC File Offset: 0x0000FDDC
		public MagnifyingGlass() : this(true)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		public MagnifyingGlass(bool movingGlass)
		{
			if (movingGlass)
			{
				this._MovingGlass = new MovingMagnifyingGlass();
				this.MovingGlass.MagnifyingGlass.ShowPosition = false;
				this.MovingGlass.MagnifyingGlass.DisplayUpdated += this.MagnifyingGlass_DisplayUpdated;
				this.MovingGlass.MagnifyingGlass.Click += this._MovingGlass_Click;
				base.MouseWheel += this.MagnifyingGlass_MouseWheel;
				this.Cursor = Cursors.SizeAll;
				this.UseMovingGlass = true;
			}
			this._UpdateTimer.Tick += this._UpdateTimer_Tick;
			base.Click += this.MagnifyingGlass_Click;
			this.CalculateSize();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00011CEA File Offset: 0x0000FEEA
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00011CF4 File Offset: 0x0000FEF4
		[Description("Magnifying ratio (calculate PixelRange*PixelSize*2+PixelSize for the final control size, min. 3)")]
		public int PixelSize
		{
			get
			{
				return this._PixelSize;
			}
			set
			{
				int temp = value;
				if (temp < 3)
				{
					temp = 3;
				}
				if ((double)temp / 2.0 == Math.Floor((double)temp / 2.0))
				{
					temp++;
				}
				this._PixelSize = temp;
				this.CalculateSize();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00011D3A File Offset: 0x0000FF3A
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00011D42 File Offset: 0x0000FF42
		[Description("Get/set if the moving glass feature should be used")]
		public bool UseMovingGlass
		{
			get
			{
				return this._UseMovingGlass;
			}
			set
			{
				if (this.MovingGlass != null)
				{
					this._UseMovingGlass = value;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00011D53 File Offset: 0x0000FF53
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00011D5B File Offset: 0x0000FF5B
		[Description("Get/set the align of the position (choose everything, but not the middle")]
		public ContentAlignment PosAlign
		{
			get
			{
				return this._PosAlign;
			}
			set
			{
				this._PosAlign = ((!value.ToString().ToLower().StartsWith("middle")) ? value : ContentAlignment.TopLeft);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00011D85 File Offset: 0x0000FF85
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00011D8D File Offset: 0x0000FF8D
		[Description("Get/set the position display string format (you have to use #x and #y for the corrdinates values)")]
		public string PosFormat
		{
			get
			{
				return this._PosFormat;
			}
			set
			{
				this._PosFormat = ((value != null && value != "" && value.Contains("#x") && value.Contains("#y")) ? value : "#x ; #y");
				base.Invalidate();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00011DCD File Offset: 0x0000FFCD
		[Description("The moving glass, if the user clicks on this")]
		public MovingMagnifyingGlass MovingGlass
		{
			get
			{
				return this._MovingGlass;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00011DD5 File Offset: 0x0000FFD5
		[Browsable(false)]
		public bool IsEnabled
		{
			get
			{
				return base.Visible && base.Enabled && !base.DesignMode;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00011DF2 File Offset: 0x0000FFF2
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00011DFC File Offset: 0x0000FFFC
		[Browsable(false)]
		internal bool FollowCursor
		{
			get
			{
				return this._FollowCursor;
			}
			set
			{
				this._FollowCursor = value;
				if (!value && this._ScreenShot != null)
				{
					this._ScreenShot.Dispose();
					this._ScreenShot = null;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00011E2F File Offset: 0x0001002F
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00011E38 File Offset: 0x00010038
		[Description("Get/set the pixel range (calculate PixelRange*PixelSize*2+PixelSize for the final control size, min. 1)")]
		public int PixelRange
		{
			get
			{
				return this._PixelRange;
			}
			set
			{
				int temp = value;
				if (temp < 1)
				{
					temp = 1;
				}
				this._PixelRange = temp;
				this.CalculateSize();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00011E5A File Offset: 0x0001005A
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00011E62 File Offset: 0x00010062
		[Description("Get/set if the active pixel should be shown")]
		public bool ShowPixel
		{
			get
			{
				return this._ShowPixel;
			}
			set
			{
				this._ShowPixel = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00011E71 File Offset: 0x00010071
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00011E79 File Offset: 0x00010079
		[Description("Get/set if the current cursor position should be shown")]
		public bool ShowPosition
		{
			get
			{
				return this._ShowPosition;
			}
			set
			{
				this._ShowPosition = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00011E88 File Offset: 0x00010088
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000045B5 File Offset: 0x000027B5
		[Description("Get the control size (settings will be ignored)")]
		public new Size Size
		{
			get
			{
				return base.Size;
			}
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00011E90 File Offset: 0x00010090
		[Description("Get the timer that updates the display in an interval")]
		public Timer UpdateTimer
		{
			get
			{
				return this._UpdateTimer;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00011E98 File Offset: 0x00010098
		[Description("Get the color of the current pixel")]
		public Color PixelColor
		{
			get
			{
				Bitmap bmp = null;
				Color pixel;
				try
				{
					bmp = new Bitmap(1, 1);
					using (Graphics g = Graphics.FromImage(bmp))
					{
						bool makeScreenshot = !this.FollowCursor;
						if (makeScreenshot && this.MovingGlass != null)
						{
							makeScreenshot &= !this.MovingGlass.Visible;
						}
						if (!this.FollowCursor)
						{
							g.CopyFromScreen(Cursor.Position, new Point(0, 0), bmp.Size);
						}
						else
						{
							bool createScreenshot;
							if (this.FollowCursor)
							{
								createScreenshot = (this._ScreenShot == null);
							}
							else
							{
								createScreenshot = (this.MovingGlass.MagnifyingGlass._ScreenShot == null);
							}
							if (createScreenshot)
							{
								this.MakeScreenshot();
							}
							if (this.FollowCursor)
							{
								g.DrawImage(this._ScreenShot, new Rectangle(new Point(0, 0), new Size(1, 1)), new Rectangle(Cursor.Position, new Size(1, 1)), GraphicsUnit.Pixel);
							}
							else
							{
								g.DrawImage(this.MovingGlass.MagnifyingGlass._ScreenShot, new Rectangle(new Point(0, 0), new Size(1, 1)), new Rectangle(Cursor.Position, new Size(1, 1)), GraphicsUnit.Pixel);
							}
							if (createScreenshot)
							{
								this._ScreenShot.Dispose();
							}
						}
					}
					pixel = bmp.GetPixel(0, 0);
				}
				finally
				{
					bmp.Dispose();
				}
				return pixel;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00012010 File Offset: 0x00010210
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (!this.IsEnabled)
			{
				base.OnPaintBackground(e);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00012024 File Offset: 0x00010224
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (!this.IsEnabled)
			{
				return;
			}
			e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			Point pos = Cursor.Position;
			Rectangle scr = Screen.PrimaryScreen.Bounds;
			Point zeroPoint = new Point(0, 0);
			if (this.FollowCursor)
			{
				Point loc = new Point(Cursor.Position.X - this.PixelRange * this.PixelSize, Cursor.Position.Y - this.PixelRange * this.PixelSize);
				if (loc.X < 0)
				{
					loc = new Point(0, loc.Y);
				}
				if (loc.X + base.Width > Screen.PrimaryScreen.Bounds.Width)
				{
					loc = new Point(Screen.PrimaryScreen.Bounds.Width - base.Width, loc.Y);
				}
				if (loc.Y < 0)
				{
					loc = new Point(loc.X, 0);
				}
				if (loc.Y + base.Height > Screen.PrimaryScreen.Bounds.Height)
				{
					loc = new Point(loc.X, Screen.PrimaryScreen.Bounds.Height - base.Height);
				}
				this._DisplayForm.Location = loc;
			}
			Rectangle shot = new Rectangle(zeroPoint, new Size(this.Size.Width / this.PixelSize, this.Size.Height / this.PixelSize));
			Point defaultLocation = new Point(pos.X - this.PixelRange, pos.Y - this.PixelRange);
			shot.Location = defaultLocation;
			if (shot.Location.X < 0)
			{
				shot.Size = new Size(shot.Size.Width + shot.Location.X, shot.Size.Height);
				shot.Location = new Point(0, shot.Location.Y);
			}
			else if (shot.Location.X > scr.Width)
			{
				shot.Size = new Size(shot.Location.X - scr.Width, shot.Size.Height);
			}
			if (shot.Location.Y < 0)
			{
				shot.Size = new Size(shot.Size.Width, shot.Size.Height + shot.Location.Y);
				shot.Location = new Point(shot.Location.X, 0);
			}
			else if (shot.Location.Y > scr.Height)
			{
				shot.Size = new Size(shot.Size.Width, shot.Location.Y - scr.Height);
			}
			Bitmap screenShot = new Bitmap(shot.Width, shot.Height, PixelFormat.Format24bppRgb);
			using (Graphics g = Graphics.FromImage(screenShot))
			{
				bool makeScreenshot = !this.FollowCursor;
				if (makeScreenshot && this.MovingGlass != null)
				{
					makeScreenshot &= !this.MovingGlass.Visible;
				}
				if (makeScreenshot)
				{
					g.CopyFromScreen(shot.Location, zeroPoint, shot.Size);
				}
				else if (this.FollowCursor)
				{
					g.DrawImage(this._ScreenShot, new Rectangle(zeroPoint, screenShot.Size), shot, GraphicsUnit.Pixel);
				}
				else
				{
					g.DrawImage(this.MovingGlass.MagnifyingGlass._ScreenShot, new Rectangle(zeroPoint, screenShot.Size), shot, GraphicsUnit.Pixel);
				}
			}
			Rectangle display = new Rectangle(zeroPoint, this.Size);
			Size displaySize = new Size(shot.Width * this.PixelSize, shot.Height * this.PixelSize);
			if (defaultLocation.X < 0 || defaultLocation.X > scr.Width)
			{
				if (defaultLocation.X < 0)
				{
					display.Location = new Point(display.Width - displaySize.Width, display.Location.Y);
				}
				display.Size = new Size(displaySize.Width, display.Size.Height);
			}
			if (defaultLocation.Y < 0 || defaultLocation.Y > scr.Height)
			{
				if (defaultLocation.Y < 0)
				{
					display.Location = new Point(display.Location.X, display.Height - displaySize.Height);
				}
				display.Size = new Size(display.Size.Width, displaySize.Height);
			}
			if (displaySize != this.Size)
			{
				e.Graphics.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(zeroPoint, this.Size));
			}
			e.Graphics.DrawImage(screenShot, display);
			screenShot.Dispose();
			if (this.ShowPixel)
			{
				int xy = this.PixelSize * this.PixelRange;
				e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(new Point(xy, xy), new Size(this.PixelSize, this.PixelSize)));
				e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.White)), new Rectangle(new Point(xy + 1, xy + 1), new Size(this.PixelSize - 2, this.PixelSize - 2)));
			}
			if (this.ShowPosition)
			{
				string posText = this.PosFormat;
				posText = posText.Replace("#x", pos.X.ToString());
				posText = posText.Replace("#y", pos.Y.ToString());
				Size textSize = e.Graphics.MeasureString(posText, this.Font).ToSize();
				if (textSize.Width + 6 <= base.Width && textSize.Height + 6 <= base.Height)
				{
					string posString = this.PosAlign.ToString().ToLower();
					Point posZero = Point.Empty;
					if (posString.StartsWith("top"))
					{
						posZero = new Point(0, 0);
					}
					else
					{
						posZero = new Point(0, base.Height - textSize.Height);
					}
					if (posString.Contains("center"))
					{
						posZero = new Point((int)Math.Ceiling((double)(base.Width - textSize.Width) / 2.0), posZero.Y);
					}
					else if (posString.Contains("right"))
					{
						posZero = new Point(base.Width - textSize.Width - 6, posZero.Y);
					}
					e.Graphics.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(posZero, new Size(textSize.Width + 6, textSize.Height + 6)));
					e.Graphics.DrawString(posText, this.Font, new SolidBrush(this.ForeColor), new PointF((float)(posZero.X + 3), (float)(posZero.Y + 3)));
				}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000127E4 File Offset: 0x000109E4
		public void SetNewSize(int pixelSize, int pixelRange)
		{
			base.SuspendLayout();
			this.PixelSize = pixelSize;
			this.PixelRange = pixelRange;
			base.ResumeLayout(true);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00012804 File Offset: 0x00010A04
		private void CalculateSize()
		{
			int wh = this.PixelSize * (this.PixelRange * 2 + 1);
			base.Size = new Size(wh, wh);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00012830 File Offset: 0x00010A30
		private void _UpdateTimer_Tick(object sender, EventArgs e)
		{
			try
			{
				this.UpdateTimer.Stop();
				if (this.IsEnabled)
				{
					if (!(this._LastPosition == Cursor.Position))
					{
						this._LastPosition = Cursor.Position;
						base.Invalidate();
						this.OnDisplayUpdated();
					}
				}
			}
			finally
			{
				this.UpdateTimer.Start();
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000151 RID: 337 RVA: 0x0001289C File Offset: 0x00010A9C
		// (remove) Token: 0x06000152 RID: 338 RVA: 0x000128D4 File Offset: 0x00010AD4
		public event MagnifyingGlass.DisplayUpdatedDelegate DisplayUpdated;

		// Token: 0x06000153 RID: 339 RVA: 0x00012909 File Offset: 0x00010B09
		private void OnDisplayUpdated()
		{
			if (this.DisplayUpdated != null)
			{
				this.DisplayUpdated(this);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0001291F File Offset: 0x00010B1F
		private void MagnifyingGlass_Click(object sender, EventArgs e)
		{
			if (this.MovingGlass != null && this.IsEnabled && this.UseMovingGlass)
			{
				this.MovingGlass.Show();
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00012944 File Offset: 0x00010B44
		private void MagnifyingGlass_MouseWheel(object sender, MouseEventArgs e)
		{
			if (this._DisplayForm != null && e.Delta != 0)
			{
				if (e.Delta > 0)
				{
					if ((this.PixelRange + 1) * this.PixelRange * 2 <= Screen.PrimaryScreen.Bounds.Width && (this.PixelRange + 1) * this.PixelRange * 2 <= Screen.PrimaryScreen.Bounds.Height)
					{
						int pixelRange = this.PixelRange;
						this.PixelRange = pixelRange + 1;
						this.PixelSize += 2;
						return;
					}
				}
				else
				{
					if (this.PixelRange - 1 >= 5)
					{
						int pixelRange = this.PixelRange;
						this.PixelRange = pixelRange - 1;
					}
					if (this.PixelSize > 3)
					{
						this.PixelSize -= 2;
					}
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00012A0B File Offset: 0x00010C0B
		private void _MovingGlass_Click(object sender, EventArgs e)
		{
			this.MovingGlass.Hide();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00012A18 File Offset: 0x00010C18
		private void MagnifyingGlass_DisplayUpdated(MagnifyingGlass sender)
		{
			base.Invalidate();
			this.OnDisplayUpdated();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00012A28 File Offset: 0x00010C28
		internal void MakeScreenshot()
		{
			this.OnBeforeMakingScreenshot();
			this._ScreenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			using (Graphics g = Graphics.FromImage(this._ScreenShot))
			{
				bool visible = this._DisplayForm.Visible;
				if (visible)
				{
					this._DisplayForm.Visible = false;
				}
				g.CopyFromScreen(new Point(0, 0), new Point(0, 0), this._ScreenShot.Size);
				g.Flush();
				if (visible)
				{
					this._DisplayForm.Visible = true;
				}
			}
			this.OnAfterMakingScreenshot();
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000159 RID: 345 RVA: 0x00012AE8 File Offset: 0x00010CE8
		// (remove) Token: 0x0600015A RID: 346 RVA: 0x00012B20 File Offset: 0x00010D20
		public event MagnifyingGlass.MakingScreenshotDelegate BeforeMakingScreenshot;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600015B RID: 347 RVA: 0x00012B58 File Offset: 0x00010D58
		// (remove) Token: 0x0600015C RID: 348 RVA: 0x00012B90 File Offset: 0x00010D90
		public event MagnifyingGlass.MakingScreenshotDelegate AfterMakingScreenshot;

		// Token: 0x0600015D RID: 349 RVA: 0x00012BC5 File Offset: 0x00010DC5
		private void OnBeforeMakingScreenshot()
		{
			if (this.BeforeMakingScreenshot != null)
			{
				this.BeforeMakingScreenshot(this);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00012BDB File Offset: 0x00010DDB
		private void OnAfterMakingScreenshot()
		{
			if (this.AfterMakingScreenshot != null)
			{
				this.AfterMakingScreenshot(this);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00012BF1 File Offset: 0x00010DF1
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.Name = "MagnifyingGlass";
			base.ResumeLayout(false);
		}

		// Token: 0x0400014A RID: 330
		private Timer _UpdateTimer = new Timer();

		// Token: 0x0400014B RID: 331
		private int _PixelSize = 5;

		// Token: 0x0400014C RID: 332
		private int _PixelRange = 10;

		// Token: 0x0400014D RID: 333
		private bool _ShowPixel = true;

		// Token: 0x0400014E RID: 334
		private bool _ShowPosition = true;

		// Token: 0x0400014F RID: 335
		private string _PosFormat = "#x ; #y";

		// Token: 0x04000150 RID: 336
		private bool _FollowCursor;

		// Token: 0x04000151 RID: 337
		internal Bitmap _ScreenShot;

		// Token: 0x04000152 RID: 338
		internal MovingMagnifyingGlass _DisplayForm;

		// Token: 0x04000153 RID: 339
		private Point _LastPosition = Point.Empty;

		// Token: 0x04000154 RID: 340
		private MovingMagnifyingGlass _MovingGlass;

		// Token: 0x04000155 RID: 341
		private ContentAlignment _PosAlign = ContentAlignment.TopLeft;

		// Token: 0x04000156 RID: 342
		private bool _UseMovingGlass;

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000161 RID: 353
		public delegate void DisplayUpdatedDelegate(MagnifyingGlass sender);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000165 RID: 357
		public delegate void MakingScreenshotDelegate(object sender);
	}
}
