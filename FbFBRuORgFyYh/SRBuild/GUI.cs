using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SRBuild
{
	// Token: 0x02000024 RID: 36
	public partial class GUI : Form
	{
		// Token: 0x06000105 RID: 261 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		public GUI()
		{
			this.InitializeComponent();
			this.magnifyingGlass1.UpdateTimer.Start();
			this.magnifyingGlass1.MovingGlass.MagnifyingGlass.Click += this.MagnifyingGlass_Click;
			this.magnifyingGlass1.MovingGlass.VisibleChanged += this.MovingGlass_VisibleChanged;
			this.magnifyingGlass1.MovingGlass.MagnifyingGlass.BeforeMakingScreenshot += this.MagnifyingGlass_BeforeMakingScreenshot;
			this.magnifyingGlass1.MovingGlass.MagnifyingGlass.AfterMakingScreenshot += this.MagnifyingGlass_AfterMakingScreenshot;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000FF68 File Offset: 0x0000E168
		private void MovingGlass_VisibleChanged(object sender, EventArgs e)
		{
			base.TopMost = !this.magnifyingGlass1.MovingGlass.Visible;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000FF83 File Offset: 0x0000E183
		private void MagnifyingGlass_Click(object sender, EventArgs e)
		{
			this.SelectColor();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000FF8B File Offset: 0x0000E18B
		private void magnifyingGlass1_DisplayUpdated(MagnifyingGlass sender)
		{
			this.panel1.BackColor = this.magnifyingGlass1.PixelColor;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000045B5 File Offset: 0x000027B5
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000045B5 File Offset: 0x000027B5
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000FFA3 File Offset: 0x0000E1A3
		private void GUI_Deactivate(object sender, EventArgs e)
		{
			if (!this.magnifyingGlass1.MovingGlass.Visible)
			{
				this.SelectColor();
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		private void SelectColor()
		{
			this.panel2.BackColor = this.panel1.BackColor;
			this.R.Text = (this.panel2.BackColor.R.ToString() ?? "");
			this.G.Text = (this.panel2.BackColor.G.ToString() ?? "");
			this.B.Text = (this.panel2.BackColor.B.ToString() ?? "");
			base.Activate();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00010076 File Offset: 0x0000E276
		private void MagnifyingGlass_AfterMakingScreenshot(object sender)
		{
			base.Show();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001007E File Offset: 0x0000E27E
		private void MagnifyingGlass_BeforeMakingScreenshot(object sender)
		{
			base.Hide();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000045B5 File Offset: 0x000027B5
		private void magnifyingGlass2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00010088 File Offset: 0x0000E288
		private void button1_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", this.R.Value.ToString(), "Color Outlines");
			MyIni.Write("Green", this.G.Value.ToString(), "Color Outlines");
			MyIni.Write("Blue", this.B.Value.ToString(), "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000045B5 File Offset: 0x000027B5
		private void magnifyingGlass1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001011C File Offset: 0x0000E31C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000073EB File Offset: 0x000055EB
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001013B File Offset: 0x0000E33B
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=BWkTNDYUG6A");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000045B5 File Offset: 0x000027B5
		private void GUI_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x02000025 RID: 37
		private class INIFile
		{
			// Token: 0x06000118 RID: 280
			[DllImport("kernel32")]
			private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

			// Token: 0x06000119 RID: 281
			[DllImport("kernel32")]
			private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

			// Token: 0x0600011A RID: 282 RVA: 0x00010A51 File Offset: 0x0000EC51
			public INIFile(string filePath)
			{
				this.filePath = filePath;
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00010A60 File Offset: 0x0000EC60
			public void Write(string section, string key, string value)
			{
				GUI.INIFile.WritePrivateProfileString(section, key, value.ToLower(), this.filePath);
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00010A78 File Offset: 0x0000EC78
			public string Read(string section, string key)
			{
				StringBuilder SB = new StringBuilder(255);
				int i = GUI.INIFile.GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
				return SB.ToString();
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00010AAF File Offset: 0x0000ECAF
			// (set) Token: 0x0600011E RID: 286 RVA: 0x00010AB7 File Offset: 0x0000ECB7
			public string FilePath
			{
				get
				{
					return this.filePath;
				}
				set
				{
					this.filePath = value;
				}
			}

			// Token: 0x0400013A RID: 314
			private string filePath;
		}
	}
}
