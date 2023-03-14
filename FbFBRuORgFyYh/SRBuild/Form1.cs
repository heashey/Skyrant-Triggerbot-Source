using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using SRBuild.Properties;

namespace SRBuild
{
	// Token: 0x02000013 RID: 19
	public partial class Form1 : Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00006138 File Offset: 0x00004338
		public Form1()
		{
			this.InitializeComponent();
			this.isTriggerbot = this.GetKey<bool>("isTriggerbot");
			this.isAimbot = this.GetKey<bool>("isAimbot");
			this.isEsp = this.GetKey<bool>("isEsp");
			this.fovX = this.GetKey<int>("fovX");
			this.fovY = this.GetKey<int>("fovY");
			this.TriggerRage = this.GetKey<bool>("TriggerRage");
			this.isCircle = this.GetKey<bool>("isCircle");
			this.speed = this.GetKey<decimal>("speed");
			this.speed3 = this.GetKey<decimal>("speed3");
			this.delayx = this.GetKey<decimal>("delayx");
			this.Bhop = this.GetKey<decimal>("Bhop");
			this.FovCircleRed = this.GetKey<int>("FovCircleRed");
			this.isRunning = this.GetKey<bool>("isRunning");
			this.FovCircleGreen = this.GetKey<int>("FovCircleGreen");
			this.FovCircleBlue = this.GetKey<int>("FovCircleBlue");
			this.FovCircleWidth = this.GetKey<int>("FovCircleWidth");
			this.color = (Form1.ColorType)this.GetKey<int>("color");
			this.mainAimKey = (Form1.AimKey)this.GetKey<int>("mainAimKey");
			this.Bhopxkey = (Form1.Bhopkey)this.GetKey<int>("Bhopxkey");
			this.isAimKey = this.GetKey<bool>("isAimKey");
			this.isHold = this.GetKey<bool>("isHold");
			this.monitor = this.GetKey<int>("monitor");
			this.offsetY = this.GetKey<int>("offsetY");
			this.msShootTime = this.GetKey<int>("msShootTime");
			this.isRecoil = this.GetKey<bool>("isRecoil");
			this.isBhop = this.GetKey<bool>("isBhop");
			this.PingX = this.GetKey<decimal>("PingX");
			Form1.ColorType colorType = this.color;
			if (colorType == Form1.ColorType.Custom)
			{
				this.Customcolor.Checked = true;
			}
			else
			{
				this.Customcolor.Checked = true;
			}
			this.UpdateUI();
			this.IsHoldToggle.Checked = this.isHold;
			this.AimbotBtt.Checked = this.isAimbot;
			this.Ragebot.Checked = this.TriggerRage;
			this.fovcircle2.Checked = this.isCircle;
			this.RecoilBtt.Checked = this.isRecoil;
			this.AimKeyToggle.Checked = this.isAimKey;
			this.Speed.Value = this.speed;
			this.Speed3.Value = this.speed3;
			this.Delayx.Value = this.delayx;
			this.Bhopinput.Value = this.Bhop;
			this.FovXNum.Value = this.fovX;
			this.FovYNum.Value = this.fovY;
			this.CircleRed.Value = this.FovCircleRed;
			this.CircleGreen.Value = this.FovCircleGreen;
			this.CircleBlue.Value = this.FovCircleBlue;
			this.CircleWidth.Value = this.FovCircleWidth;
			this.TriggerbotBtt.Checked = this.isTriggerbot;
			this.offsetNum.Value = this.offsetY;
			this.FireRateNum.Value = this.msShootTime;
			foreach (string text in Enum.GetNames(typeof(Form1.AimKey)))
			{
				this.contextMenuStrip1.Items.Add(text);
			}
			this.contextMenuStrip1.ItemClicked += delegate(object o, ToolStripItemClickedEventArgs e)
			{
				this.mainAimKey = (Form1.AimKey)Enum.Parse(typeof(Form1.AimKey), e.ClickedItem.ToString());
				this.SetKey("mainAimKey", (int)this.mainAimKey);
				this.UpdateUI();
			};
			foreach (string text2 in Enum.GetNames(typeof(Form1.Bhopkey)))
			{
				this.contextMenuStrip2.Items.Add(text2);
			}
			this.contextMenuStrip2.ItemClicked += delegate(object o, ToolStripItemClickedEventArgs e)
			{
				this.Bhopxkey = (Form1.Bhopkey)Enum.Parse(typeof(Form1.Bhopkey), e.ClickedItem.ToString());
				this.SetKey("Bhopxkey", (int)this.Bhopxkey);
				this.UpdateUI();
			};
		}

		// Token: 0x0600008D RID: 141
		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		// Token: 0x0600008E RID: 142 RVA: 0x0000660C File Offset: 0x0000480C
		private static float GetScalingFactor()
		{
			IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
			int deviceCaps = Form1.GetDeviceCaps(hdc, 10);
			return (float)Form1.GetDeviceCaps(hdc, 117) / (float)deviceCaps;
		}

		// Token: 0x0600008F RID: 143
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(int vKey);

		// Token: 0x06000090 RID: 144
		[DllImport("USER32.dll")]
		private static extern short GetKeyState(int nVirtKey);

		// Token: 0x06000091 RID: 145 RVA: 0x00006640 File Offset: 0x00004840
		private void xAimbot()
		{
			Form1.<xAimbot>d__7 <xAimbot>d__;
			<xAimbot>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<xAimbot>d__.<>4__this = this;
			<xAimbot>d__.<>1__state = -1;
			<xAimbot>d__.<>t__builder.Start<Form1.<xAimbot>d__7>(ref <xAimbot>d__);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006678 File Offset: 0x00004878
		private void XNoRecoil()
		{
			Form1.<XNoRecoil>d__8 <XNoRecoil>d__;
			<XNoRecoil>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<XNoRecoil>d__.<>4__this = this;
			<XNoRecoil>d__.<>1__state = -1;
			<XNoRecoil>d__.<>t__builder.Start<Form1.<XNoRecoil>d__8>(ref <XNoRecoil>d__);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000066B0 File Offset: 0x000048B0
		private void XBhop()
		{
			Form1.<XBhop>d__9 <XBhop>d__;
			<XBhop>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<XBhop>d__.<>4__this = this;
			<XBhop>d__.<>1__state = -1;
			<XBhop>d__.<>t__builder.Start<Form1.<XBhop>d__9>(ref <XBhop>d__);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000066E7 File Offset: 0x000048E7
		public static int GetColor(Form1.ColorType color)
		{
			if (color == Form1.ColorType.Red)
			{
				return 10092544;
			}
			if (color != Form1.ColorType.Purple)
			{
				return 10626210;
			}
			return 11480751;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006704 File Offset: 0x00004904
		private void UpdateDisplayInformation()
		{
			try
			{
				if (this.customres.Checked)
				{
					int x = int.Parse(this.ScreenX2.Text);
					int y = int.Parse(this.ScreenY2.Text);
					this.xSize = x;
					this.ySize = y;
				}
				else
				{
					this.zoom = Form1.GetScalingFactor();
					Screen screen = this.CurrentScreen();
					bool primary = screen.Primary;
					this.xSize = (int)((float)screen.Bounds.Width * (primary ? this.zoom : 1f));
					this.ySize = (int)((float)screen.Bounds.Height * (primary ? this.zoom : 1f));
				}
			}
			catch
			{
				MessageBox.Show("Failure Code - 8 - There might be an issue with the Screen Detection!");
			}
		}

		// Token: 0x06000096 RID: 150
		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, uint dwData, UIntPtr dwInformation);

		// Token: 0x06000097 RID: 151 RVA: 0x000067DC File Offset: 0x000049DC
		public new void Move(int x, int y, bool lm = false)
		{
			if (lm)
			{
				if (DateTime.Now.Subtract(this.lastShot).TotalMilliseconds < (double)this.msShootTime)
				{
					lm = false;
				}
				else
				{
					this.lastShot = DateTime.Now;
				}
			}
			this._mevent = new Form1.MoveInfo
			{
				MovementSettings = (Form1.InternCaseMoveSettings)8196,
				xAmount = x,
				yAmount = y
			};
			if (lm)
			{
				this._mevent = new Form1.MoveInfo
				{
					MovementSettings = (Form1.InternCaseMoveSettings)8194
				};
			}
			Form1.CaseExecute.ExecuteMovementCase(this._mevent);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006874 File Offset: 0x00004A74
		public Screen CurrentScreen()
		{
			return Screen.AllScreens[this.monitor];
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006884 File Offset: 0x00004A84
		public unsafe Point[] PixelSearch(Rectangle rect, Color PixelColor, int ShadeVariation)
		{
			ArrayList arrayList = new ArrayList();
			Point[] result;
			using (Bitmap tile = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb))
			{
				if (this.monitor >= Screen.AllScreens.Length)
				{
					this.monitor = 0;
					this.UpdateUI();
				}
				int left = Screen.AllScreens[this.monitor].Bounds.Left;
				int top = Screen.AllScreens[this.monitor].Bounds.Top;
				using (Graphics g = Graphics.FromImage(tile))
				{
					g.CopyFromScreen(rect.X + left, rect.Y + top, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
				}
				BitmapData bitmapData = tile.LockBits(new Rectangle(0, 0, tile.Width, tile.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
				int[] array = new int[]
				{
					(int)PixelColor.B,
					(int)PixelColor.G,
					(int)PixelColor.R
				};
				for (int i = 0; i < bitmapData.Height; i++)
				{
					byte* ptr = (byte*)((void*)bitmapData.Scan0) + i * bitmapData.Stride;
					for (int j = 0; j < bitmapData.Width; j++)
					{
						if (((int)ptr[j * 3] >= array[0] - ShadeVariation & (int)ptr[j * 3] <= array[0] + ShadeVariation) && ((int)ptr[j * 3 + 1] >= array[1] - ShadeVariation & (int)ptr[j * 3 + 1] <= array[1] + ShadeVariation) && ((int)ptr[j * 3 + 2] >= array[2] - ShadeVariation & (int)ptr[j * 3 + 2] <= array[2] + ShadeVariation))
						{
							arrayList.Add(new Point(j + rect.X, i + rect.Y));
						}
					}
				}
				result = (Point[])arrayList.ToArray(typeof(Point));
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006AD8 File Offset: 0x00004CD8
		private void Red_changed(object sender, EventArgs e)
		{
			this.color = Form1.ColorType.Red;
			this.SetKey("color", (int)this.color);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006AF2 File Offset: 0x00004CF2
		private void Purple_changed(object sender, EventArgs e)
		{
			this.color = Form1.ColorType.Purple;
			this.SetKey("color", (int)this.color);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006B0C File Offset: 0x00004D0C
		private void Speed_changed(object sender, EventArgs e)
		{
			this.speed = this.Speed.Value;
			this.SetKey("speed", this.speed);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006B30 File Offset: 0x00004D30
		private void FovX_changed(object sender, EventArgs e)
		{
			this.fovX = (int)this.FovXNum.Value;
			this.SetKey("fovX", this.fovX);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006B59 File Offset: 0x00004D59
		private void FovYNum_ValueChanged(object sender, EventArgs e)
		{
			this.fovY = (int)this.FovYNum.Value;
			this.SetKey("fovY", this.fovY);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006B84 File Offset: 0x00004D84
		private void IsAimbot_changed(object sender, EventArgs e)
		{
			if (this.AimbotBtt.Checked)
			{
				this.Ragebot.Enabled = false;
				this.chanceval.Enabled = false;
				this.Firerage.Enabled = false;
				this.Ragebot.Checked = false;
			}
			else
			{
				this.Ragebot.Enabled = true;
				this.chanceval.Enabled = true;
				this.Firerage.Enabled = true;
			}
			this.isAimbot = this.AimbotBtt.Checked;
			this.SetKey("isAimbot", this.isAimbot);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00006C18 File Offset: 0x00004E18
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Ragebot.Checked)
			{
				this.AimbotBtt.Enabled = false;
				this.TriggerbotBtt.Enabled = false;
				this.FireRateNum.Enabled = false;
				this.AimbotBtt.Checked = false;
				this.TriggerbotBtt.Checked = false;
				this.msShootTime = (int)this.Firerage.Value;
			}
			else
			{
				this.AimbotBtt.Enabled = true;
				this.TriggerbotBtt.Enabled = true;
				this.FireRateNum.Enabled = true;
			}
			this.TriggerRage = this.Ragebot.Checked;
			this.SetKey("TriggerRage", this.TriggerRage);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006CCC File Offset: 0x00004ECC
		private void IsTriggerbot_changed(object sender, EventArgs e)
		{
			this.msShootTime = (int)this.FireRateNum.Value;
			this.SetKey("msShootTime", this.msShootTime);
			this.isTriggerbot = this.TriggerbotBtt.Checked;
			this.SetKey("isTriggerbot", this.isTriggerbot);
			bool @checked = this.TriggerbotBtt.Checked;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006D30 File Offset: 0x00004F30
		private void Main_load(object sender, EventArgs e)
		{
			this.Username.Text = "Welcome:";
			this.Username1.Text = User.Username;
			IniFile MyIni = new IniFile("Colors.ini");
			string line = MyIni.Read("Red", "Color Outlines");
			string line2 = MyIni.Read("Green", "Color Outlines");
			string line3 = MyIni.Read("Blue", "Color Outlines");
			this.Redinput.Text = line;
			this.Greeninput.Text = line2;
			this.Blueinput.Text = line3;
			this.mainThread = new Thread(delegate()
			{
				this.XNoRecoil();
				this.XBhop();
				this.xAimbot();
			});
			this.mainThread.Start();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006DE1 File Offset: 0x00004FE1
		private void SetKey(string key, bool o)
		{
			Settings.Default[key] = o;
			Settings.Default.Save();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006DFE File Offset: 0x00004FFE
		private void SetKey(string key, int o)
		{
			Settings.Default[key] = o;
			Settings.Default.Save();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006E1B File Offset: 0x0000501B
		private void SetKey(string key, decimal o)
		{
			Settings.Default[key] = o;
			Settings.Default.Save();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006E38 File Offset: 0x00005038
		private T GetKey<T>(string key)
		{
			return (T)((object)Settings.Default[key]);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006E4A File Offset: 0x0000504A
		protected override void OnHandleDestroyed(EventArgs e)
		{
			this.mainThread.Abort();
			Settings.Default.Save();
			base.OnHandleDestroyed(e);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006E68 File Offset: 0x00005068
		private void UpdateUI()
		{
			this.metroToggle1.Text = (this.isRunning ? "Disable" : "Enable");
			this.UpdateDisplayInformation();
			this.ChangeMonitorBtt.Text = string.Concat(new string[]
			{
				"DISPLAY ",
				this.monitor.ToString(),
				" - ",
				this.xSize.ToString(),
				"x",
				this.ySize.ToString()
			});
			this.AimkeyBtt.Text = Enum.GetName(typeof(Form1.AimKey), this.mainAimKey);
			this.TriggerKeyBtt.Text = Enum.GetName(typeof(Form1.Bhopkey), this.Bhopxkey);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006F3C File Offset: 0x0000513C
		private void IsAimKeyChanged(object sender, EventArgs e)
		{
			this.isAimKey = this.AimKeyToggle.Checked;
			this.SetKey("isAimKey", this.isAimKey);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006F60 File Offset: 0x00005160
		private void IsHold_changed(object sender, EventArgs e)
		{
			this.isHold = this.IsHoldToggle.Checked;
			this.SetKey("isHold", this.isHold);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006F84 File Offset: 0x00005184
		private void AimKeyDrop(object sender, EventArgs e)
		{
			if (this.AimkeyBtt.PointToScreen(new Point(this.AimkeyBtt.Left, this.AimkeyBtt.Bottom)).Y + this.contextMenuStrip1.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
			{
				this.contextMenuStrip1.Show(this.AimkeyBtt, new Point(0, -this.contextMenuStrip1.Size.Height));
				return;
			}
			this.contextMenuStrip1.Show(this.AimkeyBtt, new Point(0, this.AimkeyBtt.Height));
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007038 File Offset: 0x00005238
		private void TriggerKeyDrop(object sender, EventArgs e)
		{
			if (this.TriggerKeyBtt.PointToScreen(new Point(this.TriggerKeyBtt.Left, this.TriggerKeyBtt.Bottom)).Y + this.contextMenuStrip2.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
			{
				this.contextMenuStrip2.Show(this.TriggerKeyBtt, new Point(0, -this.contextMenuStrip2.Size.Height));
				return;
			}
			this.contextMenuStrip2.Show(this.TriggerKeyBtt, new Point(0, this.TriggerKeyBtt.Height));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000070E9 File Offset: 0x000052E9
		private void OffsetY_changed(object sender, EventArgs e)
		{
			this.offsetY = (int)this.offsetNum.Value;
			this.SetKey("offsetY", this.offsetY);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007112 File Offset: 0x00005312
		private void FireRate_changed(object sender, EventArgs e)
		{
			if (this.isTriggerbot)
			{
				this.msShootTime = (int)this.FireRateNum.Value;
				this.SetKey("msShootTime", this.msShootTime);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007143 File Offset: 0x00005343
		private void Recoilcheckbox_CheckedChanged_1(object sender, EventArgs e)
		{
			this.isRecoil = this.RecoilBtt.Checked;
			this.SetKey("isRecoil", this.isRecoil);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007167 File Offset: 0x00005367
		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.Bhop = this.Bhopinput.Value;
			this.SetKey("Bhop", this.Bhop);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000718B File Offset: 0x0000538B
		private void NumericUpDown1_ValueChanged_1(object sender, EventArgs e)
		{
			this.speed3 = this.Speed3.Value;
			this.SetKey("speed3", this.speed3);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000071AF File Offset: 0x000053AF
		private void NumericUpDown1_ValueChanged_2(object sender, EventArgs e)
		{
			this.delayx = this.Delayx.Value;
			this.SetKey("delayx", this.delayx);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000071D3 File Offset: 0x000053D3
		private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
		{
			this.SetKey("isEsp", this.isEsp);
			this.TriggerbotBtt.Checked = true;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000071F4 File Offset: 0x000053F4
		private void CheckBox3_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.fovcircle2.Checked && this.isRunning)
			{
				MessageBox.Show("Please Stop and Start the Cheat again for the Fov Circle!");
			}
			this.isCircle = this.fovcircle2.Checked;
			this.SetKey("isCircle", this.isCircle);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00007243 File Offset: 0x00005443
		private void Redinput_ValueChanged(object sender, EventArgs e)
		{
			this.FovCircleRed = (int)this.Redinput.Value;
			this.SetKey("FovCircleRed", this.FovCircleRed);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000726C File Offset: 0x0000546C
		private void CircleWidth_ValueChanged(object sender, EventArgs e)
		{
			this.FovCircleWidth = (int)this.CircleWidth.Value;
			this.SetKey("FovCircleWidth", this.FovCircleWidth);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00007295 File Offset: 0x00005495
		private void Greeninput_ValueChanged(object sender, EventArgs e)
		{
			this.FovCircleGreen = (int)this.Greeninput.Value;
			this.SetKey("FovCircleGreen", this.FovCircleGreen);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000072BE File Offset: 0x000054BE
		private void Blueinput_ValueChanged(object sender, EventArgs e)
		{
			this.FovCircleBlue = (int)this.Blueinput.Value;
			this.SetKey("FovCircleBlue", this.FovCircleBlue);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000072E8 File Offset: 0x000054E8
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				Environment.Exit(0);
				base.Close();
			}
			catch
			{
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007318 File Offset: 0x00005518
		private void Firerage_ValueChanged_3(object sender, EventArgs e)
		{
			if (!this.isAimbot)
			{
				this.msShootTime = (int)this.Firerage.Value;
				this.SetKey("msShootTime", this.msShootTime);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000734C File Offset: 0x0000554C
		private void AimKeyToggle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.AimKeyToggle.Checked)
			{
				this.IsHoldToggle.Enabled = true;
				this.label1.ForeColor = Color.Red;
				this.label1.Text = "Hold is on";
				return;
			}
			this.IsHoldToggle.Enabled = false;
			this.IsHoldToggle.Checked = false;
			this.label1.ForeColor = Color.Green;
			this.label1.Text = "Hold is off";
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000073CC File Offset: 0x000055CC
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
			GUI f = new GUI();
			f.Show();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000073EB File Offset: 0x000055EB
		private void siticoneControlBox3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000073F4 File Offset: 0x000055F4
		private void metroToggle1_CheckedChanged(object sender, EventArgs e)
		{
			FormOverlay formoverlay = new FormOverlay();
			if (this.isRunning)
			{
				try
				{
					formoverlay.Close();
					FormOverlay obj = (FormOverlay)Application.OpenForms["FormOverlay"];
					obj.Close();
					this.fovcircle2.Checked = false;
				}
				catch
				{
				}
			}
			this.isRunning = !this.isRunning;
			this.UpdateUI();
			if (this.fovcircle2.Checked)
			{
				try
				{
					formoverlay.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000045B5 File Offset: 0x000027B5
		private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000748C File Offset: 0x0000568C
		private void ChangeMonitorBtt_Click(object sender, EventArgs e)
		{
			this.monitor++;
			if (this.monitor >= Screen.AllScreens.Length)
			{
				this.monitor = 0;
			}
			this.SetKey("monitor", this.monitor);
			this.UpdateUI();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000074C9 File Offset: 0x000056C9
		private void Bhopbox_CheckedChanged(object sender, EventArgs e)
		{
			this.SetKey("isBhop", this.isBhop);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000074DC File Offset: 0x000056DC
		private void fovcircle2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.fovcircle2.Checked && this.isRunning)
			{
				MessageBox.Show("Please Stop and Start the Cheat again for the Fov Circle!");
			}
			this.isCircle = this.fovcircle2.Checked;
			this.SetKey("isCircle", this.isCircle);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000045B5 File Offset: 0x000027B5
		private void customres_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000045B5 File Offset: 0x000027B5
		private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000752C File Offset: 0x0000572C
		private void LoadSettings_Click(object sender, EventArgs e)
		{
			OpenFileDialog o = new OpenFileDialog();
			o.Filter = "INI FILE |*.ini";
			if (o.ShowDialog() == DialogResult.OK)
			{
				Form1.INIFile ini = new Form1.INIFile(o.FileName);
				string FOV = ini.Read("Weapon Profiles", "Field");
				int fov = int.Parse(FOV);
				this.Pingx.Value = fov;
				string Firerate = ini.Read("Weapon Profiles", "Click Speed");
				int fr = int.Parse(Firerate);
				this.FireRateNum.Value = fr;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000075B8 File Offset: 0x000057B8
		private void SaveSettings_Click(object sender, EventArgs e)
		{
			SaveFileDialog s = new SaveFileDialog();
			s.Filter = "INI FILE |*.ini";
			if (s.ShowDialog() == DialogResult.OK)
			{
				Form1.INIFile ini = new Form1.INIFile(s.FileName);
				ini.Write("Weapon Profiles", "Field", this.Pingx.Text.ToString());
				ini.Write("Weapon Profiles", "Click Speed", this.FireRateNum.Text.ToString());
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000762B File Offset: 0x0000582B
		private void button5_Click(object sender, EventArgs e)
		{
			this.Pingx.Value = 5m;
			this.FireRateNum.Value = 50m;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007650 File Offset: 0x00005850
		private void button3_Click(object sender, EventArgs e)
		{
			this.Pingx.Value = 7m;
			this.FireRateNum.Value = 150m;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00007678 File Offset: 0x00005878
		private void button7_Click(object sender, EventArgs e)
		{
			this.Pingx.Value = 12m;
			this.FireRateNum.Value = 3m;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000769D File Offset: 0x0000589D
		private void button2_Click(object sender, EventArgs e)
		{
			this.Pingx.Value = 32m;
			this.FireRateNum.Value = 50m;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000076C3 File Offset: 0x000058C3
		private void button4_Click(object sender, EventArgs e)
		{
			this.Pingx.Value = 40m;
			this.FireRateNum.Value = 150m;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000076EC File Offset: 0x000058EC
		private void button6_Click(object sender, EventArgs e)
		{
			this.Pingx.Value = 28m;
			this.FireRateNum.Value = 3m;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000045B5 File Offset: 0x000027B5
		private void label40_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000052 RID: 82
		public int pubx;

		// Token: 0x04000053 RID: 83
		public int puby;

		// Token: 0x04000054 RID: 84
		private Form1.MoveInfo _mevent;

		// Token: 0x04000055 RID: 85
		public int xSize;

		// Token: 0x04000056 RID: 86
		public int ySize;

		// Token: 0x04000057 RID: 87
		private int msShootTime = 225;

		// Token: 0x04000058 RID: 88
		private DateTime lastShot = DateTime.Now;

		// Token: 0x04000059 RID: 89
		private int offsetY = 10;

		// Token: 0x0400005A RID: 90
		private bool isTriggerbot;

		// Token: 0x0400005B RID: 91
		private bool isAimbot;

		// Token: 0x0400005C RID: 92
		private bool isEsp;

		// Token: 0x0400005D RID: 93
		private bool TriggerRage;

		// Token: 0x0400005E RID: 94
		public bool isCircle;

		// Token: 0x0400005F RID: 95
		private bool isRecoil;

		// Token: 0x04000060 RID: 96
		private bool isBhop;

		// Token: 0x04000061 RID: 97
		private decimal PingX = 50m;

		// Token: 0x04000062 RID: 98
		private decimal speed = 1m;

		// Token: 0x04000063 RID: 99
		private decimal speed3 = 1m;

		// Token: 0x04000064 RID: 100
		private decimal Bhop = 4m;

		// Token: 0x04000065 RID: 101
		private decimal delayx = 100m;

		// Token: 0x04000066 RID: 102
		public int fovX;

		// Token: 0x04000067 RID: 103
		public int fovY;

		// Token: 0x04000068 RID: 104
		public int FovCircleWidth = 1;

		// Token: 0x04000069 RID: 105
		public int FovCircleRed = 1;

		// Token: 0x0400006A RID: 106
		public int FovCircleGreen = 1;

		// Token: 0x0400006B RID: 107
		public int FovCircleBlue = 1;

		// Token: 0x0400006C RID: 108
		private bool isAimKey;

		// Token: 0x0400006D RID: 109
		private bool isHold = true;

		// Token: 0x0400006E RID: 110
		private int monitor;

		// Token: 0x0400006F RID: 111
		private int colorVariation = 25;

		// Token: 0x04000070 RID: 112
		private Form1.AimKey mainAimKey = Form1.AimKey.Alt;

		// Token: 0x04000071 RID: 113
		private Form1.Bhopkey Bhopxkey = Form1.Bhopkey.Alt;

		// Token: 0x04000072 RID: 114
		private Form1.ColorType color = Form1.ColorType.Purple;

		// Token: 0x04000073 RID: 115
		private float zoom = 1f;

		// Token: 0x04000074 RID: 116
		private Thread mainThread;

		// Token: 0x04000075 RID: 117
		private bool isRunning;

		// Token: 0x04000076 RID: 118
		private bool slowmove;

		// Token: 0x04000077 RID: 119
		private int antirecoilval;

		// Token: 0x04000078 RID: 120
		private enabled f = new enabled();

		// Token: 0x02000014 RID: 20
		public class DirectBitmap : IDisposable
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000DF27 File Offset: 0x0000C127
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000DF2F File Offset: 0x0000C12F
			public Bitmap Bitmap { get; private set; }

			// Token: 0x060000D6 RID: 214 RVA: 0x0000DF38 File Offset: 0x0000C138
			public int[] GetBits()
			{
				return this.bits;
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x0000DF40 File Offset: 0x0000C140
			private void SetBits(int[] value)
			{
				this.bits = value;
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000DF49 File Offset: 0x0000C149
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000DF51 File Offset: 0x0000C151
			public bool Disposed { get; private set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000DA RID: 218 RVA: 0x0000DF5A File Offset: 0x0000C15A
			// (set) Token: 0x060000DB RID: 219 RVA: 0x0000DF62 File Offset: 0x0000C162
			public int Height { get; private set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000DC RID: 220 RVA: 0x0000DF6B File Offset: 0x0000C16B
			// (set) Token: 0x060000DD RID: 221 RVA: 0x0000DF73 File Offset: 0x0000C173
			public int Width { get; private set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000DE RID: 222 RVA: 0x0000DF7C File Offset: 0x0000C17C
			// (set) Token: 0x060000DF RID: 223 RVA: 0x0000DF84 File Offset: 0x0000C184
			private protected GCHandle BitsHandle { protected get; private set; }

			// Token: 0x060000E0 RID: 224 RVA: 0x0000DF90 File Offset: 0x0000C190
			public DirectBitmap(int width, int height)
			{
				this.Width = width;
				this.Height = height;
				this.SetBits(new int[width * height]);
				this.BitsHandle = GCHandle.Alloc(this.GetBits(), GCHandleType.Pinned);
				this.Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, this.BitsHandle.AddrOfPinnedObject());
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
			public void SetPixel(int x, int y, Color colour)
			{
				int index = x + y * this.Width;
				int col = colour.ToArgb();
				this.GetBits()[index] = col;
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x0000E020 File Offset: 0x0000C220
			public Color GetPixel(int x, int y)
			{
				int index = x + y * this.Width;
				int col = this.GetBits()[index];
				return Color.FromArgb(col);
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x0000E04C File Offset: 0x0000C24C
			void IDisposable.Dispose()
			{
				if (this.Disposed)
				{
					return;
				}
				this.Disposed = true;
				this.Bitmap.Dispose();
				this.BitsHandle.Free();
			}

			// Token: 0x040000E7 RID: 231
			private int[] bits;
		}

		// Token: 0x02000015 RID: 21
		private enum AimKey
		{
			// Token: 0x040000ED RID: 237
			LeftMouse = 1,
			// Token: 0x040000EE RID: 238
			RightMouse,
			// Token: 0x040000EF RID: 239
			X1Mouse = 5,
			// Token: 0x040000F0 RID: 240
			X2Button,
			// Token: 0x040000F1 RID: 241
			Shift = 160,
			// Token: 0x040000F2 RID: 242
			Ctrl = 162,
			// Token: 0x040000F3 RID: 243
			Alt = 164,
			// Token: 0x040000F4 RID: 244
			Capslock = 20,
			// Token: 0x040000F5 RID: 245
			Numpad0 = 96,
			// Token: 0x040000F6 RID: 246
			Numlock = 144
		}

		// Token: 0x02000016 RID: 22
		private enum Bhopkey
		{
			// Token: 0x040000F8 RID: 248
			LeftMouse = 1,
			// Token: 0x040000F9 RID: 249
			RightMouse,
			// Token: 0x040000FA RID: 250
			X1Mouse = 5,
			// Token: 0x040000FB RID: 251
			X2Button,
			// Token: 0x040000FC RID: 252
			Shift = 160,
			// Token: 0x040000FD RID: 253
			Ctrl = 162,
			// Token: 0x040000FE RID: 254
			Alt = 164,
			// Token: 0x040000FF RID: 255
			Capslock = 20,
			// Token: 0x04000100 RID: 256
			Numpad0 = 96,
			// Token: 0x04000101 RID: 257
			Numlock = 144
		}

		// Token: 0x02000017 RID: 23
		public enum DeviceCap
		{
			// Token: 0x04000103 RID: 259
			VERTRES = 10,
			// Token: 0x04000104 RID: 260
			DESKTOPVERTRES = 117
		}

		// Token: 0x02000018 RID: 24
		public enum ColorType
		{
			// Token: 0x04000106 RID: 262
			Red,
			// Token: 0x04000107 RID: 263
			Purple,
			// Token: 0x04000108 RID: 264
			Custom
		}

		// Token: 0x02000019 RID: 25
		public struct MoveInfo
		{
			// Token: 0x04000109 RID: 265
			public int xAmount;

			// Token: 0x0400010A RID: 266
			public int yAmount;

			// Token: 0x0400010B RID: 267
			public uint MovePack;

			// Token: 0x0400010C RID: 268
			public Form1.InternCaseMoveSettings MovementSettings;

			// Token: 0x0400010D RID: 269
			public uint Waittimems;

			// Token: 0x0400010E RID: 270
			public IntPtr Information;
		}

		// Token: 0x0200001A RID: 26
		public enum InternCaseMoveSettings
		{
			// Token: 0x04000110 RID: 272
			LeftDown = 2,
			// Token: 0x04000111 RID: 273
			LeftUp = 4,
			// Token: 0x04000112 RID: 274
			Move = 1,
			// Token: 0x04000113 RID: 275
			MoveNoCoalesce = 8192
		}

		// Token: 0x0200001B RID: 27
		public static class CaseExecute
		{
			// Token: 0x060000E4 RID: 228 RVA: 0x0000E082 File Offset: 0x0000C282
			public static void ExecuteMovementCase(Form1.MoveInfo input)
			{
				Form1.CaseExecute.ExecuteMovementCase(new Form1.MoveInfo[]
				{
					input
				});
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x0000E097 File Offset: 0x0000C297
			public static void ExecuteMovementCase(Form1.MoveInfo[] inputs)
			{
				if (!Form1.Execute.InjectMouseInput(inputs, inputs.Length))
				{
					throw new Win32Exception();
				}
			}
		}

		// Token: 0x0200001C RID: 28
		public static class Execute
		{
			// Token: 0x060000E6 RID: 230
			[DllImport("User32.dll")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool InjectMouseInput([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Form1.MoveInfo[] inputs, int count);
		}

		// Token: 0x0200001D RID: 29
		private class INIFile
		{
			// Token: 0x060000E7 RID: 231
			[DllImport("kernel32")]
			private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

			// Token: 0x060000E8 RID: 232
			[DllImport("kernel32")]
			private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

			// Token: 0x060000E9 RID: 233 RVA: 0x0000E0AA File Offset: 0x0000C2AA
			public INIFile(string filePath)
			{
				this.filePath = filePath;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x0000E0B9 File Offset: 0x0000C2B9
			public void Write(string section, string key, string value)
			{
				Form1.INIFile.WritePrivateProfileString(section, key, value.ToLower(), this.filePath);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
			public string Read(string section, string key)
			{
				StringBuilder SB = new StringBuilder(255);
				int i = Form1.INIFile.GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
				return SB.ToString();
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000EC RID: 236 RVA: 0x0000E107 File Offset: 0x0000C307
			// (set) Token: 0x060000ED RID: 237 RVA: 0x0000E10F File Offset: 0x0000C30F
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

			// Token: 0x04000114 RID: 276
			private string filePath;
		}
	}
}
