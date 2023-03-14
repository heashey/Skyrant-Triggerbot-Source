using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SRBuild
{
	// Token: 0x02000023 RID: 35
	public partial class FormOverlay : Form
	{
		// Token: 0x060000FA RID: 250 RVA: 0x0000FB76 File Offset: 0x0000DD76
		public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
		{
			if (IntPtr.Size == 8)
			{
				return FormOverlay.SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
			}
			return new IntPtr(FormOverlay.SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
		}

		// Token: 0x060000FB RID: 251
		[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
		private static extern int SetWindowLong32(HandleRef hWnd, int nIndex, int dwNewLong);

		// Token: 0x060000FC RID: 252
		[DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
		private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

		// Token: 0x060000FD RID: 253
		[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
		private static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

		// Token: 0x060000FE RID: 254 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public FormOverlay()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		private void FormOverlay_Load(object sender, EventArgs e)
		{
			try
			{
				this.BackColor = Color.Fuchsia;
				base.TransparencyKey = Color.Fuchsia;
				base.TopMost = true;
				base.MaximizeBox = true;
				base.FormBorderStyle = FormBorderStyle.None;
				HandleRef handleRef = new HandleRef(this, base.Handle);
				IntPtr initialStyle = FormOverlay.GetWindowLongPtr(base.Handle, -20);
				int test = (int)initialStyle | 524288 | 32;
				FormOverlay.SetWindowLongPtr(handleRef, -20, new IntPtr(test));
				Form1 form = new Form1();
			}
			catch
			{
				MessageBox.Show("Failure Code - 10 - There might be an issue with the FovCircle!");
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000FC48 File Offset: 0x0000DE48
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= 512;
				return cp;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000FC70 File Offset: 0x0000DE70
		private void WaitNSeconds(int segundos)
		{
			if (segundos < 1)
			{
				return;
			}
			DateTime _desired = DateTime.Now.AddSeconds((double)segundos);
			while (DateTime.Now < _desired)
			{
				Application.DoEvents();
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		public void FormOverlayPaint(object sender, PaintEventArgs e)
		{
			for (;;)
			{
				IL_00:
				try
				{
					Form1 form = new Form1();
					base.Top = (form.ySize - form.fovY) / 2;
					base.Left = (form.xSize - form.fovX) / 2;
					base.Size = new Size(form.fovX + 50, form.fovY + 50);
					if (!form.isCircle)
					{
						base.Invalidate();
						base.Close();
					}
					else
					{
						for (;;)
						{
							try
							{
								this.g = e.Graphics;
								Color col = Color.FromArgb(form.FovCircleRed, form.FovCircleGreen, form.FovCircleBlue);
								Pen New = new Pen(col)
								{
									Width = (float)form.FovCircleWidth
								};
								e.Graphics.Clear(Color.Fuchsia);
								this.g.DrawEllipse(New, 0, 0, form.fovX, form.fovY);
								this.WaitNSeconds(5);
								goto IL_00;
							}
							catch
							{
								MessageBox.Show("Failure Code - 12 - There might be an issue with the FovCircle!");
								base.Close();
								continue;
							}
							break;
						}
					}
				}
				catch
				{
					MessageBox.Show("Failure Code - 13 - There might be an issue with the FovCircle!");
				}
				break;
			}
		}

		// Token: 0x0400012A RID: 298
		private Graphics g;
	}
}
