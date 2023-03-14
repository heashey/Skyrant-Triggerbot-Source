using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SRBuild
{
	// Token: 0x0200002B RID: 43
	public partial class MovingMagnifyingGlass : Form
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00012C0C File Offset: 0x00010E0C
		public MovingMagnifyingGlass()
		{
			base.Opacity = 0.75;
			base.ShowInTaskbar = false;
			base.ShowIcon = false;
			base.FormBorderStyle = FormBorderStyle.None;
			this.MagnifyingGlass.PixelSize = 10;
			this.MagnifyingGlass.PixelRange = 5;
			this.MagnifyingGlass.BackColor = Color.Black;
			this.MagnifyingGlass.ForeColor = Color.White;
			this.MagnifyingGlass.UpdateTimer.Interval = 50;
			this.MagnifyingGlass._DisplayForm = this;
			this.MagnifyingGlass.FollowCursor = true;
			this.MagnifyingGlass.BorderStyle = BorderStyle.FixedSingle;
			this.MagnifyingGlass.Resize += this.MagnifyingGlass_Resize;
			this.MagnifyingGlass.Location = new Point(0, 0);
			base.Controls.Add(this.MagnifyingGlass);
			base.Size = this.MagnifyingGlass.Size;
			this.Text = "Moving magnifying glass";
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00012D14 File Offset: 0x00010F14
		public new void Show()
		{
			this.MagnifyingGlass.MakeScreenshot();
			Cursor.Position = new Point(0, 0);
			base.Show();
			this.MagnifyingGlass.UpdateTimer.Start();
			Cursor.Hide();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00012D48 File Offset: 0x00010F48
		public new void Hide()
		{
			base.Hide();
			this.MagnifyingGlass.UpdateTimer.Stop();
			Cursor.Show();
			this.MagnifyingGlass._ScreenShot.Dispose();
			this.MagnifyingGlass._ScreenShot = null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00012D81 File Offset: 0x00010F81
		private void MagnifyingGlass_Resize(object sender, EventArgs e)
		{
			base.Size = this.MagnifyingGlass.Size;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00012D94 File Offset: 0x00010F94
		[Description("The magnifying glass object")]
		public MagnifyingGlass MagnifyingGlass
		{
			get
			{
				return this._MagnifyingGlass;
			}
		}

		// Token: 0x0400015A RID: 346
		private MagnifyingGlass _MagnifyingGlass = new MagnifyingGlass(false);
	}
}
