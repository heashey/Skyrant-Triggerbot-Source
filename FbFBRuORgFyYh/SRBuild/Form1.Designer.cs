namespace SRBuild
{
	// Token: 0x02000013 RID: 19
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00007711 File Offset: 0x00005911
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007730 File Offset: 0x00005930
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SRBuild.Form1));
			this.AimbotBtt = new global::System.Windows.Forms.CheckBox();
			this.Speed = new global::System.Windows.Forms.NumericUpDown();
			this.FovXNum = new global::System.Windows.Forms.NumericUpDown();
			this.offsetNum = new global::System.Windows.Forms.NumericUpDown();
			this.Speed3 = new global::System.Windows.Forms.NumericUpDown();
			this.Delayx = new global::System.Windows.Forms.NumericUpDown();
			this.SmoothX = new global::System.Windows.Forms.NumericUpDown();
			this.AimkeyBtt = new global::System.Windows.Forms.Button();
			this.rcs = new global::System.Windows.Forms.NumericUpDown();
			this.RecoilBtt = new global::System.Windows.Forms.CheckBox();
			this.TriggerbotBtt = new global::System.Windows.Forms.CheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ChangeMonitorBtt = new global::System.Windows.Forms.Button();
			this.AimKeyToggle = new global::System.Windows.Forms.CheckBox();
			this.IsHoldToggle = new global::System.Windows.Forms.CheckBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.label4 = new global::System.Windows.Forms.Label();
			this.FireRateNum = new global::System.Windows.Forms.NumericUpDown();
			this.label9 = new global::System.Windows.Forms.Label();
			this.Customcolor = new global::System.Windows.Forms.RadioButton();
			this.Redinput = new global::System.Windows.Forms.NumericUpDown();
			this.Greeninput = new global::System.Windows.Forms.NumericUpDown();
			this.Blueinput = new global::System.Windows.Forms.NumericUpDown();
			this.Pingx = new global::System.Windows.Forms.NumericUpDown();
			this.ScreenX2 = new global::System.Windows.Forms.NumericUpDown();
			this.ScreenY2 = new global::System.Windows.Forms.NumericUpDown();
			this.label18 = new global::System.Windows.Forms.Label();
			this.ScreenY = new global::System.Windows.Forms.Label();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.Bhopinput = new global::System.Windows.Forms.NumericUpDown();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.label21 = new global::System.Windows.Forms.Label();
			this.label22 = new global::System.Windows.Forms.Label();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label28 = new global::System.Windows.Forms.Label();
			this.Bdelay = new global::System.Windows.Forms.NumericUpDown();
			this.label30 = new global::System.Windows.Forms.Label();
			this.label31 = new global::System.Windows.Forms.Label();
			this.CircleBlue = new global::System.Windows.Forms.NumericUpDown();
			this.CircleGreen = new global::System.Windows.Forms.NumericUpDown();
			this.CircleRed = new global::System.Windows.Forms.NumericUpDown();
			this.label32 = new global::System.Windows.Forms.Label();
			this.label37 = new global::System.Windows.Forms.Label();
			this.label38 = new global::System.Windows.Forms.Label();
			this.ColB = new global::System.Windows.Forms.NumericUpDown();
			this.ColG = new global::System.Windows.Forms.NumericUpDown();
			this.ColR = new global::System.Windows.Forms.NumericUpDown();
			this.label39 = new global::System.Windows.Forms.Label();
			this.label41 = new global::System.Windows.Forms.Label();
			this.ColY = new global::System.Windows.Forms.NumericUpDown();
			this.ColX = new global::System.Windows.Forms.NumericUpDown();
			this.label42 = new global::System.Windows.Forms.Label();
			this.CircleWidth = new global::System.Windows.Forms.NumericUpDown();
			this.label48 = new global::System.Windows.Forms.Label();
			this.ColWidth = new global::System.Windows.Forms.NumericUpDown();
			this.label49 = new global::System.Windows.Forms.Label();
			this.TargetCheck = new global::System.Windows.Forms.CheckBox();
			this.chanceval = new global::System.Windows.Forms.NumericUpDown();
			this.label24 = new global::System.Windows.Forms.Label();
			this.Ragebot = new global::System.Windows.Forms.CheckBox();
			this.label52 = new global::System.Windows.Forms.Label();
			this.Firerage = new global::System.Windows.Forms.NumericUpDown();
			this.label57 = new global::System.Windows.Forms.Label();
			this.Norecoilaimval = new global::System.Windows.Forms.NumericUpDown();
			this.FovYNum = new global::System.Windows.Forms.NumericUpDown();
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.label34 = new global::System.Windows.Forms.Label();
			this.label35 = new global::System.Windows.Forms.Label();
			this.customres = new global::Siticone.UI.WinForms.SiticoneCheckBox();
			this.SaveSettings = new global::System.Windows.Forms.Button();
			this.LoadSettings = new global::System.Windows.Forms.Button();
			this.TriggerKeyBtt = new global::System.Windows.Forms.Button();
			this.contextMenuStrip2 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.label23 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label27 = new global::System.Windows.Forms.Label();
			this.label26 = new global::System.Windows.Forms.Label();
			this.label29 = new global::System.Windows.Forms.Label();
			this.label36 = new global::System.Windows.Forms.Label();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.label16 = new global::System.Windows.Forms.Label();
			this.TabControl = new global::MetroFramework.Controls.MetroTabControl();
			this.Home = new global::MetroFramework.Controls.MetroTabPage();
			this.metroToggle1 = new global::MetroFramework.Controls.MetroToggle();
			this.Username1 = new global::System.Windows.Forms.Label();
			this.Username = new global::System.Windows.Forms.Label();
			this.label33 = new global::System.Windows.Forms.Label();
			this.TriggerBot = new global::MetroFramework.Controls.MetroTabPage();
			this.metroTabPage1 = new global::MetroFramework.Controls.MetroTabPage();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.metroTabPage2 = new global::MetroFramework.Controls.MetroTabPage();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox3 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox4 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.fovcircle2 = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.Speed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovXNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.offsetNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Speed3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Delayx).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SmoothX).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.rcs).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FireRateNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Redinput).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Greeninput).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Blueinput).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Pingx).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ScreenX2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ScreenY2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bhopinput).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bdelay).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleBlue).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleGreen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleRed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColB).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColG).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColR).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColY).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColX).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleWidth).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColWidth).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chanceval).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Firerage).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Norecoilaimval).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovYNum).BeginInit();
			this.TabControl.SuspendLayout();
			this.Home.SuspendLayout();
			this.TriggerBot.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.metroTabPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.AimbotBtt.AutoSize = true;
			this.AimbotBtt.BackColor = global::System.Drawing.Color.Transparent;
			this.AimbotBtt.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.AimbotBtt.ForeColor = global::System.Drawing.Color.White;
			this.AimbotBtt.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.AimbotBtt.Location = new global::System.Drawing.Point(242, 544);
			this.AimbotBtt.Margin = new global::System.Windows.Forms.Padding(2);
			this.AimbotBtt.Name = "AimbotBtt";
			this.AimbotBtt.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.AimbotBtt.Size = new global::System.Drawing.Size(58, 17);
			this.AimbotBtt.TabIndex = 0;
			this.AimbotBtt.TabStop = false;
			this.AimbotBtt.Text = "Aimbot";
			this.toolTip1.SetToolTip(this.AimbotBtt, "This feature aims automatically at your enemy");
			this.AimbotBtt.UseVisualStyleBackColor = false;
			this.AimbotBtt.Visible = false;
			this.AimbotBtt.CheckedChanged += new global::System.EventHandler(this.IsAimbot_changed);
			this.Speed.BackColor = global::System.Drawing.SystemColors.Window;
			this.Speed.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Speed.DecimalPlaces = 2;
			this.Speed.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.Speed.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.Speed.Increment = new decimal(new int[]
			{
				5,
				0,
				0,
				131072
			});
			this.Speed.InterceptArrowKeys = false;
			this.Speed.Location = new global::System.Drawing.Point(77, 471);
			this.Speed.Margin = new global::System.Windows.Forms.Padding(2);
			this.Speed.Name = "Speed";
			this.Speed.Size = new global::System.Drawing.Size(90, 20);
			this.Speed.TabIndex = 3;
			this.Speed.TabStop = false;
			this.toolTip1.SetToolTip(this.Speed, "Change the Speed of your Aimbot while it is searching and aiming for your target.\r\n\r\nLower Values are more legit.");
			this.Speed.Value = new decimal(new int[]
			{
				15,
				0,
				0,
				131072
			});
			this.Speed.Visible = false;
			this.Speed.ValueChanged += new global::System.EventHandler(this.Speed_changed);
			this.FovXNum.BackColor = global::System.Drawing.SystemColors.Window;
			this.FovXNum.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.FovXNum.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.FovXNum.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.FovXNum.InterceptArrowKeys = false;
			this.FovXNum.Location = new global::System.Drawing.Point(77, 495);
			this.FovXNum.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown fovXNum = this.FovXNum;
			int[] array = new int[4];
			array[0] = 10000;
			fovXNum.Maximum = new decimal(array);
			this.FovXNum.Name = "FovXNum";
			this.FovXNum.Size = new global::System.Drawing.Size(90, 20);
			this.FovXNum.TabIndex = 5;
			this.FovXNum.TabStop = false;
			this.toolTip1.SetToolTip(this.FovXNum, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
			global::System.Windows.Forms.NumericUpDown fovXNum2 = this.FovXNum;
			int[] array2 = new int[4];
			array2[0] = 350;
			fovXNum2.Value = new decimal(array2);
			this.FovXNum.Visible = false;
			this.FovXNum.ValueChanged += new global::System.EventHandler(this.FovX_changed);
			this.offsetNum.BackColor = global::System.Drawing.SystemColors.Window;
			this.offsetNum.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.offsetNum.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.offsetNum.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.offsetNum.InterceptArrowKeys = false;
			this.offsetNum.Location = new global::System.Drawing.Point(77, 543);
			this.offsetNum.Margin = new global::System.Windows.Forms.Padding(2);
			this.offsetNum.Minimum = new decimal(new int[]
			{
				20,
				0,
				0,
				int.MinValue
			});
			this.offsetNum.Name = "offsetNum";
			this.offsetNum.Size = new global::System.Drawing.Size(90, 20);
			this.offsetNum.TabIndex = 16;
			this.offsetNum.TabStop = false;
			this.toolTip1.SetToolTip(this.offsetNum, "Will change the Aimspot.\r\n\r\n- Lower Value (Aims lower at your Body)\r\n- High Value (Aims higher at your Head)");
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.offsetNum;
			int[] array3 = new int[4];
			array3[0] = 15;
			numericUpDown.Value = new decimal(array3);
			this.offsetNum.Visible = false;
			this.offsetNum.ValueChanged += new global::System.EventHandler(this.OffsetY_changed);
			this.Speed3.BackColor = global::System.Drawing.SystemColors.Window;
			this.Speed3.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Speed3.DecimalPlaces = 2;
			this.Speed3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.Speed3.ImeMode = global::System.Windows.Forms.ImeMode.On;
			this.Speed3.Increment = new decimal(new int[]
			{
				5,
				0,
				0,
				131072
			});
			this.Speed3.Location = new global::System.Drawing.Point(542, 678);
			this.Speed3.Margin = new global::System.Windows.Forms.Padding(2);
			this.Speed3.Name = "Speed3";
			this.Speed3.Size = new global::System.Drawing.Size(90, 20);
			this.Speed3.TabIndex = 55;
			this.toolTip1.SetToolTip(this.Speed3, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crosshair or the Smooth Aim Pixels.\r\nThis is like a second Fov on Lockon.\r\n\r\nLower Values are more legit.\r\n");
			this.Speed3.Value = new decimal(new int[]
			{
				5,
				0,
				0,
				131072
			});
			this.Speed3.Visible = false;
			this.Speed3.ValueChanged += new global::System.EventHandler(this.NumericUpDown1_ValueChanged_1);
			this.Delayx.BackColor = global::System.Drawing.SystemColors.Window;
			this.Delayx.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Delayx.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.Delayx.ImeMode = global::System.Windows.Forms.ImeMode.On;
			this.Delayx.Location = new global::System.Drawing.Point(379, 501);
			this.Delayx.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.Delayx;
			int[] array4 = new int[4];
			array4[0] = 10000;
			numericUpDown2.Maximum = new decimal(array4);
			this.Delayx.Name = "Delayx";
			this.Delayx.Size = new global::System.Drawing.Size(90, 20);
			this.Delayx.TabIndex = 59;
			this.toolTip1.SetToolTip(this.Delayx, resources.GetString("Delayx.ToolTip"));
			this.Delayx.Visible = false;
			this.Delayx.ValueChanged += new global::System.EventHandler(this.NumericUpDown1_ValueChanged_2);
			this.SmoothX.BackColor = global::System.Drawing.SystemColors.Window;
			this.SmoothX.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.SmoothX.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.SmoothX.ImeMode = global::System.Windows.Forms.ImeMode.On;
			this.SmoothX.Location = new global::System.Drawing.Point(542, 702);
			this.SmoothX.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown smoothX = this.SmoothX;
			int[] array5 = new int[4];
			array5[0] = 200;
			smoothX.Maximum = new decimal(array5);
			global::System.Windows.Forms.NumericUpDown smoothX2 = this.SmoothX;
			int[] array6 = new int[4];
			array6[0] = 1;
			smoothX2.Minimum = new decimal(array6);
			this.SmoothX.Name = "SmoothX";
			this.SmoothX.Size = new global::System.Drawing.Size(90, 20);
			this.SmoothX.TabIndex = 62;
			this.toolTip1.SetToolTip(this.SmoothX, resources.GetString("SmoothX.ToolTip"));
			global::System.Windows.Forms.NumericUpDown smoothX3 = this.SmoothX;
			int[] array7 = new int[4];
			array7[0] = 120;
			smoothX3.Value = new decimal(array7);
			this.SmoothX.Visible = false;
			this.AimkeyBtt.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.AimkeyBtt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.AimkeyBtt.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.AimkeyBtt.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.AimkeyBtt.Location = new global::System.Drawing.Point(1064, 293);
			this.AimkeyBtt.Margin = new global::System.Windows.Forms.Padding(2);
			this.AimkeyBtt.Name = "AimkeyBtt";
			this.AimkeyBtt.Size = new global::System.Drawing.Size(82, 25);
			this.AimkeyBtt.TabIndex = 14;
			this.AimkeyBtt.Text = "Keybind";
			this.toolTip1.SetToolTip(this.AimkeyBtt, "Keybinding for Aimbot and Ragebot");
			this.AimkeyBtt.UseVisualStyleBackColor = false;
			this.AimkeyBtt.Visible = false;
			this.AimkeyBtt.Click += new global::System.EventHandler(this.AimKeyDrop);
			this.rcs.BackColor = global::System.Drawing.SystemColors.Window;
			this.rcs.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.rcs.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.rcs.Location = new global::System.Drawing.Point(1157, 430);
			this.rcs.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.rcs;
			int[] array8 = new int[4];
			array8[0] = 10;
			numericUpDown3.Maximum = new decimal(array8);
			this.rcs.Minimum = new decimal(new int[]
			{
				10,
				0,
				0,
				int.MinValue
			});
			this.rcs.Name = "rcs";
			this.rcs.Size = new global::System.Drawing.Size(90, 20);
			this.rcs.TabIndex = 57;
			this.toolTip1.SetToolTip(this.rcs, resources.GetString("rcs.ToolTip"));
			this.rcs.Visible = false;
			this.RecoilBtt.AutoSize = true;
			this.RecoilBtt.BackColor = global::System.Drawing.Color.Transparent;
			this.RecoilBtt.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.RecoilBtt.ForeColor = global::System.Drawing.Color.White;
			this.RecoilBtt.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.RecoilBtt.Location = new global::System.Drawing.Point(982, 473);
			this.RecoilBtt.Margin = new global::System.Windows.Forms.Padding(2);
			this.RecoilBtt.Name = "RecoilBtt";
			this.RecoilBtt.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.RecoilBtt.Size = new global::System.Drawing.Size(70, 17);
			this.RecoilBtt.TabIndex = 47;
			this.RecoilBtt.TabStop = false;
			this.RecoilBtt.Text = "NoRecoil";
			this.toolTip1.SetToolTip(this.RecoilBtt, "This feature will countermeasures against the recoil");
			this.RecoilBtt.UseVisualStyleBackColor = false;
			this.RecoilBtt.Visible = false;
			this.RecoilBtt.CheckedChanged += new global::System.EventHandler(this.Recoilcheckbox_CheckedChanged_1);
			this.TriggerbotBtt.AutoSize = true;
			this.TriggerbotBtt.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.TriggerbotBtt.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.TriggerbotBtt.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9.75f);
			this.TriggerbotBtt.ForeColor = global::System.Drawing.Color.Gold;
			this.TriggerbotBtt.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TriggerbotBtt.Location = new global::System.Drawing.Point(150, 30);
			this.TriggerbotBtt.Margin = new global::System.Windows.Forms.Padding(2);
			this.TriggerbotBtt.Name = "TriggerbotBtt";
			this.TriggerbotBtt.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.TriggerbotBtt.Size = new global::System.Drawing.Size(65, 20);
			this.TriggerbotBtt.TabIndex = 1;
			this.TriggerbotBtt.Text = "Hunter";
			this.TriggerbotBtt.UseVisualStyleBackColor = false;
			this.TriggerbotBtt.CheckedChanged += new global::System.EventHandler(this.IsTriggerbot_changed);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(177, 473);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(57, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Humanizer";
			this.toolTip1.SetToolTip(this.label1, "Change the Speed of your Aimbot while it is searching and aiming for your target.\r\n\r\nLower Values are more legit.\r\n");
			this.label1.Visible = false;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(177, 497);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Fov X";
			this.toolTip1.SetToolTip(this.label2, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov but may slow down your Aimbot Performance.\r\n");
			this.label2.Visible = false;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new global::System.Drawing.Point(177, 521);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(35, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Fov Y";
			this.toolTip1.SetToolTip(this.label3, "Your Y Fov for Up and Down.\r\n\r\nHigher Value will increase the Fov but may slow down your Aimbot Performance.\r\n");
			this.label3.Visible = false;
			this.ChangeMonitorBtt.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.ChangeMonitorBtt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ChangeMonitorBtt.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.ChangeMonitorBtt.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.ChangeMonitorBtt.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.ChangeMonitorBtt.Location = new global::System.Drawing.Point(88, 192);
			this.ChangeMonitorBtt.Margin = new global::System.Windows.Forms.Padding(2);
			this.ChangeMonitorBtt.Name = "ChangeMonitorBtt";
			this.ChangeMonitorBtt.Size = new global::System.Drawing.Size(181, 30);
			this.ChangeMonitorBtt.TabIndex = 11;
			this.ChangeMonitorBtt.Text = "CHANGE SCREEN";
			this.toolTip1.SetToolTip(this.ChangeMonitorBtt, "Change your Monitor");
			this.ChangeMonitorBtt.UseVisualStyleBackColor = false;
			this.ChangeMonitorBtt.Click += new global::System.EventHandler(this.ChangeMonitorBtt_Click);
			this.AimKeyToggle.AutoSize = true;
			this.AimKeyToggle.BackColor = global::System.Drawing.Color.FromArgb(32, 30, 45);
			this.AimKeyToggle.Checked = true;
			this.AimKeyToggle.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.AimKeyToggle.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9.75f);
			this.AimKeyToggle.ForeColor = global::System.Drawing.Color.Gold;
			this.AimKeyToggle.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.AimKeyToggle.Location = new global::System.Drawing.Point(118, 94);
			this.AimKeyToggle.Margin = new global::System.Windows.Forms.Padding(2);
			this.AimKeyToggle.Name = "AimKeyToggle";
			this.AimKeyToggle.Size = new global::System.Drawing.Size(67, 20);
			this.AimKeyToggle.TabIndex = 12;
			this.AimKeyToggle.Text = "Toggle";
			this.AimKeyToggle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.AimKeyToggle.UseVisualStyleBackColor = false;
			this.AimKeyToggle.CheckedChanged += new global::System.EventHandler(this.AimKeyToggle_CheckedChanged);
			this.AimKeyToggle.Click += new global::System.EventHandler(this.IsAimKeyChanged);
			this.IsHoldToggle.AutoSize = true;
			this.IsHoldToggle.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.IsHoldToggle.Checked = true;
			this.IsHoldToggle.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.IsHoldToggle.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9.75f);
			this.IsHoldToggle.ForeColor = global::System.Drawing.Color.Gold;
			this.IsHoldToggle.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.IsHoldToggle.Location = new global::System.Drawing.Point(204, 94);
			this.IsHoldToggle.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsHoldToggle.Name = "IsHoldToggle";
			this.IsHoldToggle.Size = new global::System.Drawing.Size(54, 20);
			this.IsHoldToggle.TabIndex = 13;
			this.IsHoldToggle.Text = "Hold";
			this.IsHoldToggle.UseVisualStyleBackColor = false;
			this.IsHoldToggle.CheckedChanged += new global::System.EventHandler(this.IsHold_changed);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(61, 4);
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new global::System.Drawing.Point(177, 545);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(50, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Aimoffset";
			this.toolTip1.SetToolTip(this.label4, "Will change the Aimspot.\r\n\r\n- Lower Value (Aims lower at your Body)\r\n- High Value (Aims higher at your Head)");
			this.label4.Visible = false;
			this.FireRateNum.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.FireRateNum.Location = new global::System.Drawing.Point(167, 285);
			this.FireRateNum.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown fireRateNum = this.FireRateNum;
			int[] array9 = new int[4];
			array9[0] = 250;
			fireRateNum.Maximum = new decimal(array9);
			this.FireRateNum.Name = "FireRateNum";
			this.FireRateNum.Size = new global::System.Drawing.Size(46, 26);
			this.FireRateNum.TabIndex = 18;
			global::System.Windows.Forms.NumericUpDown fireRateNum2 = this.FireRateNum;
			int[] array10 = new int[4];
			array10[0] = 10;
			fireRateNum2.Value = new decimal(array10);
			this.FireRateNum.ValueChanged += new global::System.EventHandler(this.FireRate_changed);
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.label9.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new global::System.Drawing.Point(1060, 266);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(154, 20);
			this.label9.TabIndex = 23;
			this.label9.Text = "Aimbot / Ragebot:";
			this.label9.Visible = false;
			this.Customcolor.AutoSize = true;
			this.Customcolor.BackColor = global::System.Drawing.Color.Transparent;
			this.Customcolor.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.Customcolor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.Customcolor.Location = new global::System.Drawing.Point(642, 404);
			this.Customcolor.Margin = new global::System.Windows.Forms.Padding(0);
			this.Customcolor.Name = "Customcolor";
			this.Customcolor.Size = new global::System.Drawing.Size(61, 18);
			this.Customcolor.TabIndex = 25;
			this.Customcolor.TabStop = true;
			this.Customcolor.Text = "Custom";
			this.toolTip1.SetToolTip(this.Customcolor, "Custom RGB Color if it doesn't detect the predefined one.");
			this.Customcolor.UseCompatibleTextRendering = true;
			this.Customcolor.UseVisualStyleBackColor = false;
			this.Customcolor.Visible = false;
			this.Redinput.Font = new global::System.Drawing.Font("Nirmala UI", 12f);
			this.Redinput.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.Redinput.Location = new global::System.Drawing.Point(4, 578);
			this.Redinput.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown redinput = this.Redinput;
			int[] array11 = new int[4];
			array11[0] = 255;
			redinput.Maximum = new decimal(array11);
			this.Redinput.Name = "Redinput";
			this.Redinput.Size = new global::System.Drawing.Size(105, 29);
			this.Redinput.TabIndex = 28;
			this.toolTip1.SetToolTip(this.Redinput, "Custom RGB Color if it doesn't detect the predefined one.");
			this.Redinput.Visible = false;
			this.Greeninput.Font = new global::System.Drawing.Font("Nirmala UI", 12f);
			this.Greeninput.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.Greeninput.Location = new global::System.Drawing.Point(113, 578);
			this.Greeninput.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown greeninput = this.Greeninput;
			int[] array12 = new int[4];
			array12[0] = 255;
			greeninput.Maximum = new decimal(array12);
			this.Greeninput.Name = "Greeninput";
			this.Greeninput.Size = new global::System.Drawing.Size(105, 29);
			this.Greeninput.TabIndex = 29;
			this.toolTip1.SetToolTip(this.Greeninput, "Custom RGB Color if it doesn't detect the predefined one.");
			this.Greeninput.Visible = false;
			this.Blueinput.Font = new global::System.Drawing.Font("Nirmala UI", 12f);
			this.Blueinput.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.Blueinput.Location = new global::System.Drawing.Point(219, 578);
			this.Blueinput.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown blueinput = this.Blueinput;
			int[] array13 = new int[4];
			array13[0] = 255;
			blueinput.Maximum = new decimal(array13);
			this.Blueinput.Name = "Blueinput";
			this.Blueinput.Size = new global::System.Drawing.Size(105, 29);
			this.Blueinput.TabIndex = 30;
			this.toolTip1.SetToolTip(this.Blueinput, "Custom RGB Color if it doesn't detect the predefined one.");
			this.Blueinput.Visible = false;
			this.Pingx.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Pingx.Location = new global::System.Drawing.Point(167, 217);
			this.Pingx.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown pingx = this.Pingx;
			int[] array14 = new int[4];
			array14[0] = 250;
			pingx.Maximum = new decimal(array14);
			global::System.Windows.Forms.NumericUpDown pingx2 = this.Pingx;
			int[] array15 = new int[4];
			array15[0] = 1;
			pingx2.Minimum = new decimal(array15);
			this.Pingx.Name = "Pingx";
			this.Pingx.Size = new global::System.Drawing.Size(35, 26);
			this.Pingx.TabIndex = 34;
			global::System.Windows.Forms.NumericUpDown pingx3 = this.Pingx;
			int[] array16 = new int[4];
			array16[0] = 5;
			pingx3.Value = new decimal(array16);
			this.ScreenX2.Location = new global::System.Drawing.Point(111, 71);
			this.ScreenX2.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown screenX = this.ScreenX2;
			int[] array17 = new int[4];
			array17[0] = 10000;
			screenX.Maximum = new decimal(array17);
			this.ScreenX2.Name = "ScreenX2";
			this.ScreenX2.Size = new global::System.Drawing.Size(90, 20);
			this.ScreenX2.TabIndex = 39;
			this.ScreenX2.Tag = "";
			this.toolTip1.SetToolTip(this.ScreenX2, "Screen Resoltuion X");
			this.ScreenY2.Location = new global::System.Drawing.Point(111, 95);
			this.ScreenY2.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown screenY = this.ScreenY2;
			int[] array18 = new int[4];
			array18[0] = 10000;
			screenY.Maximum = new decimal(array18);
			this.ScreenY2.Name = "ScreenY2";
			this.ScreenY2.Size = new global::System.Drawing.Size(90, 20);
			this.ScreenY2.TabIndex = 40;
			this.toolTip1.SetToolTip(this.ScreenY2, "Screen Resoltuion Y");
			this.label18.AutoSize = true;
			this.label18.BackColor = global::System.Drawing.Color.Transparent;
			this.label18.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label18.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label18.Location = new global::System.Drawing.Point(210, 73);
			this.label18.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(50, 16);
			this.label18.TabIndex = 41;
			this.label18.Text = "Pixel X";
			this.ScreenY.AutoSize = true;
			this.ScreenY.BackColor = global::System.Drawing.Color.Transparent;
			this.ScreenY.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ScreenY.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.ScreenY.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.ScreenY.Location = new global::System.Drawing.Point(210, 97);
			this.ScreenY.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ScreenY.Name = "ScreenY";
			this.ScreenY.Size = new global::System.Drawing.Size(49, 16);
			this.ScreenY.TabIndex = 42;
			this.ScreenY.Text = "Pixel Y";
			this.toolTip1.AutoPopDelay = 15000;
			this.toolTip1.InitialDelay = 100;
			this.toolTip1.ReshowDelay = 100;
			this.Bhopinput.Location = new global::System.Drawing.Point(613, 503);
			this.Bhopinput.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown bhopinput = this.Bhopinput;
			int[] array19 = new int[4];
			array19[0] = 254;
			bhopinput.Maximum = new decimal(array19);
			this.Bhopinput.Name = "Bhopinput";
			this.Bhopinput.Size = new global::System.Drawing.Size(90, 20);
			this.Bhopinput.TabIndex = 49;
			this.toolTip1.SetToolTip(this.Bhopinput, "Keybind for Bhop - Default is \"Middle Mouse\" (4)\r\n\r\n(Spacebar does not work)\r\n\r\nKeybinds here: http://cherrytree.at/misc/vk.htm");
			global::System.Windows.Forms.NumericUpDown bhopinput2 = this.Bhopinput;
			int[] array20 = new int[4];
			array20[0] = 32;
			bhopinput2.Value = new decimal(array20);
			this.Bhopinput.Visible = false;
			this.Bhopinput.ValueChanged += new global::System.EventHandler(this.NumericUpDown1_ValueChanged);
			this.label10.AutoSize = true;
			this.label10.BackColor = global::System.Drawing.Color.Transparent;
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new global::System.Drawing.Point(708, 510);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(77, 13);
			this.label10.TabIndex = 54;
			this.label10.Text = "Bhop Keycode";
			this.toolTip1.SetToolTip(this.label10, "Keybind for Bhop - Default is \"Middle Mouse\" (4)\r\n\r\n(Spacebar does not work)\r\n\r\nKeybinds here: http://cherrytree.at/misc/vk.htm\r\n");
			this.label10.Visible = false;
			this.label20.AutoSize = true;
			this.label20.BackColor = global::System.Drawing.Color.Transparent;
			this.label20.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label20.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label20.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label20.Location = new global::System.Drawing.Point(641, 680);
			this.label20.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(57, 13);
			this.label20.TabIndex = 56;
			this.label20.Text = "Humanizer";
			this.toolTip1.SetToolTip(this.label20, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crosshair or the Smooth Aim Pixels.\r\nThis is like a second Fov on Lockon.\r\n\r\nLower Values are more legit.");
			this.label20.Visible = false;
			this.label21.AutoSize = true;
			this.label21.BackColor = global::System.Drawing.Color.Transparent;
			this.label21.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label21.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label21.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label21.Location = new global::System.Drawing.Point(1257, 432);
			this.label21.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(108, 13);
			this.label21.TabIndex = 58;
			this.label21.Text = "NoRecoil Standalone";
			this.toolTip1.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
			this.label21.Visible = false;
			this.label22.AutoSize = true;
			this.label22.BackColor = global::System.Drawing.Color.Transparent;
			this.label22.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label22.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label22.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label22.Location = new global::System.Drawing.Point(479, 503);
			this.label22.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(34, 13);
			this.label22.TabIndex = 60;
			this.label22.Text = "Delay";
			this.toolTip1.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
			this.label22.Visible = false;
			this.label25.AutoSize = true;
			this.label25.BackColor = global::System.Drawing.Color.Transparent;
			this.label25.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label25.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label25.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label25.Location = new global::System.Drawing.Point(641, 704);
			this.label25.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(72, 13);
			this.label25.TabIndex = 63;
			this.label25.Text = "Pixel Fov X/Y";
			this.toolTip1.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
			this.label25.Visible = false;
			this.label28.AutoSize = true;
			this.label28.BackColor = global::System.Drawing.Color.Transparent;
			this.label28.ForeColor = global::System.Drawing.Color.White;
			this.label28.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label28.Location = new global::System.Drawing.Point(708, 534);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(62, 13);
			this.label28.TabIndex = 76;
			this.label28.Text = "Bhop Delay";
			this.toolTip1.SetToolTip(this.label28, "Delay for Bhop \r\n\r\n(Pressing each X ms your Spacebar to jump)\r\n");
			this.label28.Visible = false;
			this.Bdelay.Location = new global::System.Drawing.Point(613, 527);
			this.Bdelay.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown bdelay = this.Bdelay;
			int[] array21 = new int[4];
			array21[0] = 254;
			bdelay.Maximum = new decimal(array21);
			this.Bdelay.Name = "Bdelay";
			this.Bdelay.Size = new global::System.Drawing.Size(90, 20);
			this.Bdelay.TabIndex = 75;
			this.toolTip1.SetToolTip(this.Bdelay, "Delay for Bhop \r\n\r\n(Pressing each X ms your Spacebar to jump)");
			global::System.Windows.Forms.NumericUpDown bdelay2 = this.Bdelay;
			int[] array22 = new int[4];
			array22[0] = 20;
			bdelay2.Value = new decimal(array22);
			this.Bdelay.Visible = false;
			this.label30.AutoSize = true;
			this.label30.BackColor = global::System.Drawing.Color.Transparent;
			this.label30.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label30.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label30.Location = new global::System.Drawing.Point(889, 681);
			this.label30.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label30.Name = "label30";
			this.label30.Size = new global::System.Drawing.Size(28, 13);
			this.label30.TabIndex = 85;
			this.label30.Text = "Blue";
			this.toolTip1.SetToolTip(this.label30, "Amount of Blue Color in your Circle\r\n\r\n");
			this.label30.Visible = false;
			this.label31.AutoSize = true;
			this.label31.BackColor = global::System.Drawing.Color.Transparent;
			this.label31.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label31.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label31.Location = new global::System.Drawing.Point(889, 657);
			this.label31.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label31.Name = "label31";
			this.label31.Size = new global::System.Drawing.Size(36, 13);
			this.label31.TabIndex = 84;
			this.label31.Text = "Green";
			this.toolTip1.SetToolTip(this.label31, "Amount of Green Color in your Circle\r\n\r\n");
			this.label31.Visible = false;
			this.CircleBlue.Location = new global::System.Drawing.Point(789, 679);
			this.CircleBlue.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown circleBlue = this.CircleBlue;
			int[] array23 = new int[4];
			array23[0] = 255;
			circleBlue.Maximum = new decimal(array23);
			this.CircleBlue.Name = "CircleBlue";
			this.CircleBlue.Size = new global::System.Drawing.Size(90, 20);
			this.CircleBlue.TabIndex = 83;
			this.toolTip1.SetToolTip(this.CircleBlue, "Amount of Blue Color in your Circle\r\n");
			global::System.Windows.Forms.NumericUpDown circleBlue2 = this.CircleBlue;
			int[] array24 = new int[4];
			array24[0] = 1;
			circleBlue2.Value = new decimal(array24);
			this.CircleBlue.Visible = false;
			this.CircleGreen.Location = new global::System.Drawing.Point(789, 655);
			this.CircleGreen.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown circleGreen = this.CircleGreen;
			int[] array25 = new int[4];
			array25[0] = 255;
			circleGreen.Maximum = new decimal(array25);
			this.CircleGreen.Name = "CircleGreen";
			this.CircleGreen.Size = new global::System.Drawing.Size(90, 20);
			this.CircleGreen.TabIndex = 82;
			this.toolTip1.SetToolTip(this.CircleGreen, "Amount of Green Color in your Circle\r\n");
			global::System.Windows.Forms.NumericUpDown circleGreen2 = this.CircleGreen;
			int[] array26 = new int[4];
			array26[0] = 1;
			circleGreen2.Value = new decimal(array26);
			this.CircleGreen.Visible = false;
			this.CircleRed.Location = new global::System.Drawing.Point(789, 631);
			this.CircleRed.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown circleRed = this.CircleRed;
			int[] array27 = new int[4];
			array27[0] = 255;
			circleRed.Maximum = new decimal(array27);
			this.CircleRed.Name = "CircleRed";
			this.CircleRed.Size = new global::System.Drawing.Size(90, 20);
			this.CircleRed.TabIndex = 81;
			this.toolTip1.SetToolTip(this.CircleRed, "Amount of Red Color in your Circle");
			global::System.Windows.Forms.NumericUpDown circleRed2 = this.CircleRed;
			int[] array28 = new int[4];
			array28[0] = 255;
			circleRed2.Value = new decimal(array28);
			this.CircleRed.Visible = false;
			this.label32.AutoSize = true;
			this.label32.BackColor = global::System.Drawing.Color.Transparent;
			this.label32.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label32.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label32.Location = new global::System.Drawing.Point(889, 633);
			this.label32.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label32.Name = "label32";
			this.label32.Size = new global::System.Drawing.Size(27, 13);
			this.label32.TabIndex = 80;
			this.label32.Text = "Red";
			this.toolTip1.SetToolTip(this.label32, "Amount of Red Color in your Circle\r\n");
			this.label32.Visible = false;
			this.label37.AutoSize = true;
			this.label37.BackColor = global::System.Drawing.Color.Transparent;
			this.label37.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label37.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label37.Location = new global::System.Drawing.Point(913, 392);
			this.label37.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label37.Name = "label37";
			this.label37.Size = new global::System.Drawing.Size(28, 13);
			this.label37.TabIndex = 98;
			this.label37.Text = "Blue";
			this.toolTip1.SetToolTip(this.label37, "Amount of Blue Color in your Box\r\n");
			this.label37.Visible = false;
			this.label38.AutoSize = true;
			this.label38.BackColor = global::System.Drawing.Color.Transparent;
			this.label38.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label38.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label38.Location = new global::System.Drawing.Point(913, 366);
			this.label38.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label38.Name = "label38";
			this.label38.Size = new global::System.Drawing.Size(36, 13);
			this.label38.TabIndex = 97;
			this.label38.Text = "Green";
			this.toolTip1.SetToolTip(this.label38, "Amount of Green Color in your Box\r\n");
			this.label38.Visible = false;
			this.ColB.Location = new global::System.Drawing.Point(813, 390);
			this.ColB.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown colB = this.ColB;
			int[] array29 = new int[4];
			array29[0] = 255;
			colB.Maximum = new decimal(array29);
			this.ColB.Name = "ColB";
			this.ColB.Size = new global::System.Drawing.Size(90, 20);
			this.ColB.TabIndex = 96;
			this.toolTip1.SetToolTip(this.ColB, "Amount of Blue Color in your Box");
			this.ColB.Visible = false;
			this.ColG.Location = new global::System.Drawing.Point(813, 366);
			this.ColG.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown colG = this.ColG;
			int[] array30 = new int[4];
			array30[0] = 255;
			colG.Maximum = new decimal(array30);
			this.ColG.Name = "ColG";
			this.ColG.Size = new global::System.Drawing.Size(90, 20);
			this.ColG.TabIndex = 95;
			this.toolTip1.SetToolTip(this.ColG, "Amount of Green Color in your Box\r\n");
			this.ColG.Visible = false;
			this.ColR.Location = new global::System.Drawing.Point(813, 342);
			this.ColR.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown colR = this.ColR;
			int[] array31 = new int[4];
			array31[0] = 255;
			colR.Maximum = new decimal(array31);
			this.ColR.Name = "ColR";
			this.ColR.Size = new global::System.Drawing.Size(90, 20);
			this.ColR.TabIndex = 94;
			this.toolTip1.SetToolTip(this.ColR, "Amount of Red Color in your Box");
			global::System.Windows.Forms.NumericUpDown colR2 = this.ColR;
			int[] array32 = new int[4];
			array32[0] = 255;
			colR2.Value = new decimal(array32);
			this.ColR.Visible = false;
			this.label39.AutoSize = true;
			this.label39.BackColor = global::System.Drawing.Color.Transparent;
			this.label39.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label39.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label39.Location = new global::System.Drawing.Point(913, 344);
			this.label39.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label39.Name = "label39";
			this.label39.Size = new global::System.Drawing.Size(27, 13);
			this.label39.TabIndex = 93;
			this.label39.Text = "Red";
			this.toolTip1.SetToolTip(this.label39, "Amount of Red Color in your Box\r\n");
			this.label39.Visible = false;
			this.label41.AutoSize = true;
			this.label41.BackColor = global::System.Drawing.Color.Transparent;
			this.label41.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label41.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label41.Location = new global::System.Drawing.Point(913, 320);
			this.label41.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label41.Name = "label41";
			this.label41.Size = new global::System.Drawing.Size(37, 13);
			this.label41.TabIndex = 103;
			this.label41.Text = "Size Y";
			this.toolTip1.SetToolTip(this.label41, "Size of your ESP Boxes in Y");
			this.label41.Visible = false;
			this.ColY.Location = new global::System.Drawing.Point(813, 318);
			this.ColY.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown colY = this.ColY;
			int[] array33 = new int[4];
			array33[0] = 255;
			colY.Maximum = new decimal(array33);
			this.ColY.Name = "ColY";
			this.ColY.Size = new global::System.Drawing.Size(90, 20);
			this.ColY.TabIndex = 101;
			this.toolTip1.SetToolTip(this.ColY, "Size of your ESP Boxes in Y\r\n\r\n");
			global::System.Windows.Forms.NumericUpDown colY2 = this.ColY;
			int[] array34 = new int[4];
			array34[0] = 160;
			colY2.Value = new decimal(array34);
			this.ColY.Visible = false;
			this.ColX.Location = new global::System.Drawing.Point(813, 294);
			this.ColX.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown colX = this.ColX;
			int[] array35 = new int[4];
			array35[0] = 255;
			colX.Maximum = new decimal(array35);
			this.ColX.Name = "ColX";
			this.ColX.Size = new global::System.Drawing.Size(90, 20);
			this.ColX.TabIndex = 100;
			this.toolTip1.SetToolTip(this.ColX, "Size of your ESP Boxes in X\r\n");
			global::System.Windows.Forms.NumericUpDown colX2 = this.ColX;
			int[] array36 = new int[4];
			array36[0] = 60;
			colX2.Value = new decimal(array36);
			this.ColX.Visible = false;
			this.label42.AutoSize = true;
			this.label42.BackColor = global::System.Drawing.Color.Transparent;
			this.label42.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label42.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label42.Location = new global::System.Drawing.Point(913, 296);
			this.label42.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label42.Name = "label42";
			this.label42.Size = new global::System.Drawing.Size(37, 13);
			this.label42.TabIndex = 99;
			this.label42.Text = "Size X";
			this.toolTip1.SetToolTip(this.label42, "Size of your ESP Boxes in X\r\n\r\n");
			this.label42.Visible = false;
			this.CircleWidth.Location = new global::System.Drawing.Point(789, 607);
			this.CircleWidth.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown circleWidth = this.CircleWidth;
			int[] array37 = new int[4];
			array37[0] = 255;
			circleWidth.Maximum = new decimal(array37);
			this.CircleWidth.Name = "CircleWidth";
			this.CircleWidth.Size = new global::System.Drawing.Size(90, 20);
			this.CircleWidth.TabIndex = 116;
			this.toolTip1.SetToolTip(this.CircleWidth, "Width of your Fov Circle");
			global::System.Windows.Forms.NumericUpDown circleWidth2 = this.CircleWidth;
			int[] array38 = new int[4];
			array38[0] = 1;
			circleWidth2.Value = new decimal(array38);
			this.CircleWidth.Visible = false;
			this.CircleWidth.ValueChanged += new global::System.EventHandler(this.CircleWidth_ValueChanged);
			this.label48.AutoSize = true;
			this.label48.BackColor = global::System.Drawing.Color.Transparent;
			this.label48.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label48.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label48.Location = new global::System.Drawing.Point(889, 609);
			this.label48.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label48.Name = "label48";
			this.label48.Size = new global::System.Drawing.Size(35, 13);
			this.label48.TabIndex = 115;
			this.label48.Text = "Width";
			this.toolTip1.SetToolTip(this.label48, "Width of your Fov Circle\r\n");
			this.label48.Visible = false;
			this.ColWidth.Location = new global::System.Drawing.Point(813, 414);
			this.ColWidth.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown colWidth = this.ColWidth;
			int[] array39 = new int[4];
			array39[0] = 255;
			colWidth.Maximum = new decimal(array39);
			this.ColWidth.Name = "ColWidth";
			this.ColWidth.Size = new global::System.Drawing.Size(90, 20);
			this.ColWidth.TabIndex = 119;
			this.toolTip1.SetToolTip(this.ColWidth, "Amount of Width of your Box");
			global::System.Windows.Forms.NumericUpDown colWidth2 = this.ColWidth;
			int[] array40 = new int[4];
			array40[0] = 2;
			colWidth2.Value = new decimal(array40);
			this.ColWidth.Visible = false;
			this.label49.AutoSize = true;
			this.label49.BackColor = global::System.Drawing.Color.Transparent;
			this.label49.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label49.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label49.Location = new global::System.Drawing.Point(913, 416);
			this.label49.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label49.Name = "label49";
			this.label49.Size = new global::System.Drawing.Size(35, 13);
			this.label49.TabIndex = 120;
			this.label49.Text = "Width";
			this.toolTip1.SetToolTip(this.label49, "Amount of Width of your Box\r\n");
			this.label49.Visible = false;
			this.TargetCheck.AutoSize = true;
			this.TargetCheck.BackColor = global::System.Drawing.Color.Transparent;
			this.TargetCheck.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.TargetCheck.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.TargetCheck.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TargetCheck.Location = new global::System.Drawing.Point(542, 656);
			this.TargetCheck.Name = "TargetCheck";
			this.TargetCheck.Size = new global::System.Drawing.Size(105, 17);
			this.TargetCheck.TabIndex = 123;
			this.TargetCheck.Text = "Enable / Disable";
			this.toolTip1.SetToolTip(this.TargetCheck, "THIS MIGHT SLOW DOWN YOUR AIMBOT!\r\n\r\nCheckbox to Enable - Disable the Target Aimbot\r\n\r\nWill Disable all Settings in \"Aimbot - Target\" and only use the \"Aimbot - Searching\" Settings.");
			this.TargetCheck.UseVisualStyleBackColor = false;
			this.TargetCheck.Visible = false;
			this.chanceval.BackColor = global::System.Drawing.SystemColors.Window;
			this.chanceval.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.chanceval.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.chanceval.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.chanceval.InterceptArrowKeys = false;
			this.chanceval.Location = new global::System.Drawing.Point(1032, 642);
			this.chanceval.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.chanceval;
			int[] array41 = new int[4];
			array41[0] = 1;
			numericUpDown4.Minimum = new decimal(array41);
			this.chanceval.Name = "chanceval";
			this.chanceval.Size = new global::System.Drawing.Size(90, 20);
			this.chanceval.TabIndex = 125;
			this.chanceval.TabStop = false;
			this.toolTip1.SetToolTip(this.chanceval, resources.GetString("chanceval.ToolTip"));
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.chanceval;
			int[] array42 = new int[4];
			array42[0] = 85;
			numericUpDown5.Value = new decimal(array42);
			this.chanceval.Visible = false;
			this.label24.AutoSize = true;
			this.label24.BackColor = global::System.Drawing.Color.Transparent;
			this.label24.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label24.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label24.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label24.Location = new global::System.Drawing.Point(1132, 644);
			this.label24.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(56, 13);
			this.label24.TabIndex = 126;
			this.label24.Text = "Hitchance";
			this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
			this.label24.Visible = false;
			this.Ragebot.AutoSize = true;
			this.Ragebot.BackColor = global::System.Drawing.Color.Transparent;
			this.Ragebot.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Ragebot.ForeColor = global::System.Drawing.Color.White;
			this.Ragebot.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.Ragebot.Location = new global::System.Drawing.Point(982, 452);
			this.Ragebot.Margin = new global::System.Windows.Forms.Padding(2);
			this.Ragebot.Name = "Ragebot";
			this.Ragebot.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.Ragebot.Size = new global::System.Drawing.Size(67, 17);
			this.Ragebot.TabIndex = 128;
			this.Ragebot.TabStop = false;
			this.Ragebot.Text = "Ragebot";
			this.toolTip1.SetToolTip(this.Ragebot, "Simple Ragebot. Aims at your Enemy and auto shoots like Triggerbot.\r\n\r\nOnly works with Keybind!");
			this.Ragebot.UseVisualStyleBackColor = false;
			this.Ragebot.Visible = false;
			this.Ragebot.CheckedChanged += new global::System.EventHandler(this.CheckBox1_CheckedChanged);
			this.label52.AutoSize = true;
			this.label52.BackColor = global::System.Drawing.Color.Transparent;
			this.label52.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label52.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label52.Location = new global::System.Drawing.Point(1132, 668);
			this.label52.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label52.Name = "label52";
			this.label52.Size = new global::System.Drawing.Size(42, 13);
			this.label52.TabIndex = 130;
			this.label52.Text = "Firerate";
			this.toolTip1.SetToolTip(this.label52, "Firerate of your Weapon.\r\n\r\nHigher Value = Higher Delay = Slower Shooting\r\nLower Value = Lower Delay = Faster Shooting\r\n\r\n(If your Triggerbot is still slow increase the Prefire Values)");
			this.label52.Visible = false;
			this.Firerage.Location = new global::System.Drawing.Point(1032, 666);
			this.Firerage.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown firerage = this.Firerage;
			int[] array43 = new int[4];
			array43[0] = 10000;
			firerage.Maximum = new decimal(array43);
			this.Firerage.Name = "Firerage";
			this.Firerage.Size = new global::System.Drawing.Size(90, 20);
			this.Firerage.TabIndex = 129;
			this.toolTip1.SetToolTip(this.Firerage, "Firerate of your Weapon.\r\n\r\nHigher Value = Higher Delay = Slower Shooting\r\nLower Value = Lower Delay = Faster Shooting\r\n\r\n(If your Triggerbot is still slow increase the Prefire Values)");
			global::System.Windows.Forms.NumericUpDown firerage2 = this.Firerage;
			int[] array44 = new int[4];
			array44[0] = 145;
			firerage2.Value = new decimal(array44);
			this.Firerage.Visible = false;
			this.Firerage.ValueChanged += new global::System.EventHandler(this.Firerage_ValueChanged_3);
			this.label57.AutoSize = true;
			this.label57.BackColor = global::System.Drawing.Color.Transparent;
			this.label57.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label57.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label57.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label57.Location = new global::System.Drawing.Point(1257, 456);
			this.label57.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label57.Name = "label57";
			this.label57.Size = new global::System.Drawing.Size(86, 13);
			this.label57.TabIndex = 140;
			this.label57.Text = "NoRecoil Aimbot";
			this.toolTip1.SetToolTip(this.label57, "change the strength of the NoRecoil while Aimbot is autoshooting.\r\n\r\n+ 1 = 1 pixel stronger recoilreduction\r\n-1 = 1 pixel less recoilreduction\r\n\r\n");
			this.label57.Visible = false;
			this.Norecoilaimval.BackColor = global::System.Drawing.SystemColors.Window;
			this.Norecoilaimval.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Norecoilaimval.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.Norecoilaimval.Location = new global::System.Drawing.Point(1157, 454);
			this.Norecoilaimval.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown norecoilaimval = this.Norecoilaimval;
			int[] array45 = new int[4];
			array45[0] = 10;
			norecoilaimval.Maximum = new decimal(array45);
			this.Norecoilaimval.Minimum = new decimal(new int[]
			{
				10,
				0,
				0,
				int.MinValue
			});
			this.Norecoilaimval.Name = "Norecoilaimval";
			this.Norecoilaimval.Size = new global::System.Drawing.Size(90, 20);
			this.Norecoilaimval.TabIndex = 139;
			this.toolTip1.SetToolTip(this.Norecoilaimval, "change the strength of the NoRecoil while Aimbot is autoshooting.\r\n\r\n+ 1 = 1 pixel stronger recoilreduction\r\n-1 = 1 pixel less recoilreduction\r\n");
			global::System.Windows.Forms.NumericUpDown norecoilaimval2 = this.Norecoilaimval;
			int[] array46 = new int[4];
			array46[0] = 1;
			norecoilaimval2.Value = new decimal(array46);
			this.Norecoilaimval.Visible = false;
			this.FovYNum.BackColor = global::System.Drawing.SystemColors.Window;
			this.FovYNum.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.FovYNum.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.FovYNum.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.FovYNum.InterceptArrowKeys = false;
			this.FovYNum.Location = new global::System.Drawing.Point(77, 519);
			this.FovYNum.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown fovYNum = this.FovYNum;
			int[] array47 = new int[4];
			array47[0] = 10000;
			fovYNum.Maximum = new decimal(array47);
			this.FovYNum.Name = "FovYNum";
			this.FovYNum.Size = new global::System.Drawing.Size(90, 20);
			this.FovYNum.TabIndex = 141;
			this.FovYNum.TabStop = false;
			this.toolTip1.SetToolTip(this.FovYNum, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
			global::System.Windows.Forms.NumericUpDown fovYNum2 = this.FovYNum;
			int[] array48 = new int[4];
			array48[0] = 350;
			fovYNum2.Value = new decimal(array48);
			this.FovYNum.Visible = false;
			this.FovYNum.ValueChanged += new global::System.EventHandler(this.FovYNum_ValueChanged);
			this.radioButton1.AutoSize = true;
			this.radioButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButton1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioButton1.Location = new global::System.Drawing.Point(4, 511);
			this.radioButton1.Margin = new global::System.Windows.Forms.Padding(0);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new global::System.Drawing.Size(59, 18);
			this.radioButton1.TabIndex = 25;
			this.radioButton1.Text = "custom";
			this.toolTip1.SetToolTip(this.radioButton1, "The values given in the Color Finder go into these boxes in the exact same order.");
			this.radioButton1.UseCompatibleTextRendering = true;
			this.radioButton1.UseVisualStyleBackColor = false;
			this.radioButton1.Visible = false;
			this.label34.AutoSize = true;
			this.label34.BackColor = global::System.Drawing.Color.Transparent;
			this.label34.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.label34.ForeColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.label34.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label34.Location = new global::System.Drawing.Point(130, 261);
			this.label34.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label34.Name = "label34";
			this.label34.Size = new global::System.Drawing.Size(93, 18);
			this.label34.TabIndex = 19;
			this.label34.Text = "Click Speed";
			this.toolTip1.SetToolTip(this.label34, resources.GetString("label34.ToolTip"));
			this.label35.AutoSize = true;
			this.label35.BackColor = global::System.Drawing.Color.Transparent;
			this.label35.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.label35.ForeColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.label35.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label35.Location = new global::System.Drawing.Point(123, 184);
			this.label35.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label35.Name = "label35";
			this.label35.Size = new global::System.Drawing.Size(98, 18);
			this.label35.TabIndex = 35;
			this.label35.Text = "Field of View";
			this.toolTip1.SetToolTip(this.label35, "The detection area range of your Triggerbot, smaller is more accurate but too small isn't good either, we recommend the default values.\n\n");
			this.customres.AutoSize = true;
			this.customres.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.customres.CheckedState.BorderRadius = 0;
			this.customres.CheckedState.BorderThickness = 0;
			this.customres.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.customres.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9.75f);
			this.customres.ForeColor = global::System.Drawing.Color.Gold;
			this.customres.Location = new global::System.Drawing.Point(112, 46);
			this.customres.Name = "customres";
			this.customres.Size = new global::System.Drawing.Size(135, 20);
			this.customres.TabIndex = 80;
			this.customres.Text = "Custom Resolution";
			this.toolTip1.SetToolTip(this.customres, "Set custom resolution. If it doesnt work for you");
			this.customres.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.customres.UncheckedState.BorderRadius = 0;
			this.customres.UncheckedState.BorderThickness = 0;
			this.customres.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.customres.CheckedChanged += new global::System.EventHandler(this.customres_CheckedChanged);
			this.SaveSettings.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.SaveSettings.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SaveSettings.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.SaveSettings.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.SaveSettings.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.SaveSettings.Location = new global::System.Drawing.Point(40, 276);
			this.SaveSettings.Margin = new global::System.Windows.Forms.Padding(2);
			this.SaveSettings.Name = "SaveSettings";
			this.SaveSettings.Size = new global::System.Drawing.Size(140, 30);
			this.SaveSettings.TabIndex = 72;
			this.SaveSettings.Text = "Save Settings";
			this.SaveSettings.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.toolTip1.SetToolTip(this.SaveSettings, "Keybinding for Triggerbot");
			this.SaveSettings.UseVisualStyleBackColor = false;
			this.SaveSettings.Click += new global::System.EventHandler(this.SaveSettings_Click);
			this.LoadSettings.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.LoadSettings.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LoadSettings.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.LoadSettings.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.LoadSettings.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.LoadSettings.Location = new global::System.Drawing.Point(184, 276);
			this.LoadSettings.Margin = new global::System.Windows.Forms.Padding(2);
			this.LoadSettings.Name = "LoadSettings";
			this.LoadSettings.Size = new global::System.Drawing.Size(140, 30);
			this.LoadSettings.TabIndex = 73;
			this.LoadSettings.Text = "Load Settings";
			this.LoadSettings.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.toolTip1.SetToolTip(this.LoadSettings, "Keybinding for Triggerbot");
			this.LoadSettings.UseVisualStyleBackColor = false;
			this.LoadSettings.Click += new global::System.EventHandler(this.LoadSettings_Click);
			this.TriggerKeyBtt.BackColor = global::System.Drawing.Color.White;
			this.TriggerKeyBtt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TriggerKeyBtt.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.TriggerKeyBtt.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.TriggerKeyBtt.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TriggerKeyBtt.Location = new global::System.Drawing.Point(118, 118);
			this.TriggerKeyBtt.Margin = new global::System.Windows.Forms.Padding(2);
			this.TriggerKeyBtt.Name = "TriggerKeyBtt";
			this.TriggerKeyBtt.Size = new global::System.Drawing.Size(143, 31);
			this.TriggerKeyBtt.TabIndex = 52;
			this.TriggerKeyBtt.Text = "Keybind";
			this.TriggerKeyBtt.UseVisualStyleBackColor = false;
			this.TriggerKeyBtt.Click += new global::System.EventHandler(this.TriggerKeyDrop);
			this.contextMenuStrip2.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new global::System.Drawing.Size(61, 4);
			this.label23.AutoSize = true;
			this.label23.BackColor = global::System.Drawing.Color.Transparent;
			this.label23.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label23.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label23.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.label23.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label23.Location = new global::System.Drawing.Point(538, 633);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(138, 20);
			this.label23.TabIndex = 61;
			this.label23.Text = "Aimbot - Target:";
			this.label23.Visible = false;
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.label7.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new global::System.Drawing.Point(73, 447);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(155, 20);
			this.label7.TabIndex = 72;
			this.label7.Text = "Aimbot - Ragebot:";
			this.label7.Visible = false;
			this.label27.AutoSize = true;
			this.label27.BackColor = global::System.Drawing.Color.Transparent;
			this.label27.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label27.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.label27.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new global::System.Drawing.Point(1145, 293);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(86, 20);
			this.label27.TabIndex = 73;
			this.label27.Text = "NoRecoil:";
			this.label27.Visible = false;
			this.label26.AutoSize = true;
			this.label26.BackColor = global::System.Drawing.Color.Transparent;
			this.label26.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label26.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.label26.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label26.Location = new global::System.Drawing.Point(1175, 521);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(56, 20);
			this.label26.TabIndex = 74;
			this.label26.Text = "Bhop:";
			this.label26.Visible = false;
			this.label29.AutoSize = true;
			this.label29.BackColor = global::System.Drawing.Color.Transparent;
			this.label29.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label29.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.label29.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label29.Location = new global::System.Drawing.Point(785, 584);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(100, 20);
			this.label29.TabIndex = 77;
			this.label29.Text = "FOV Circle:";
			this.label29.Visible = false;
			this.label36.AutoSize = true;
			this.label36.BackColor = global::System.Drawing.Color.Transparent;
			this.label36.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.label36.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.label36.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label36.Location = new global::System.Drawing.Point(809, 272);
			this.label36.Name = "label36";
			this.label36.Size = new global::System.Drawing.Size(96, 20);
			this.label36.TabIndex = 92;
			this.label36.Text = "Color ESP:";
			this.label36.Visible = false;
			this.label16.AutoSize = true;
			this.label16.BackColor = global::System.Drawing.Color.Transparent;
			this.label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.Location = new global::System.Drawing.Point(1032, 627);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(92, 13);
			this.label16.TabIndex = 142;
			this.label16.Text = "Ragebot Settings:";
			this.label16.Visible = false;
			this.TabControl.Controls.Add(this.Home);
			this.TabControl.Controls.Add(this.TriggerBot);
			this.TabControl.Controls.Add(this.metroTabPage1);
			this.TabControl.Controls.Add(this.metroTabPage2);
			this.TabControl.HotTrack = true;
			this.TabControl.ItemSize = new global::System.Drawing.Size(97, 20);
			this.TabControl.Location = new global::System.Drawing.Point(-4, 68);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 2;
			this.TabControl.Size = new global::System.Drawing.Size(394, 360);
			this.TabControl.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.TabControl.Style = 11;
			this.TabControl.TabIndex = 145;
			this.TabControl.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.TabControl.UseCustomBackColor = true;
			this.TabControl.UseCustomForeColor = true;
			this.TabControl.UseSelectable = true;
			this.TabControl.UseStyleColors = true;
			this.Home.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.Home.Controls.Add(this.metroToggle1);
			this.Home.Controls.Add(this.Username1);
			this.Home.Controls.Add(this.Username);
			this.Home.Controls.Add(this.label33);
			this.Home.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Home.HorizontalScrollbarBarColor = true;
			this.Home.HorizontalScrollbarHighlightOnWheel = true;
			this.Home.HorizontalScrollbarSize = 0;
			this.Home.Location = new global::System.Drawing.Point(4, 24);
			this.Home.Name = "Home";
			this.Home.Size = new global::System.Drawing.Size(386, 332);
			this.Home.TabIndex = 1;
			this.Home.Text = "Home";
			this.Home.UseCustomBackColor = true;
			this.Home.VerticalScrollbarBarColor = false;
			this.Home.VerticalScrollbarHighlightOnWheel = false;
			this.Home.VerticalScrollbarSize = 0;
			this.metroToggle1.AutoSize = true;
			this.metroToggle1.Location = new global::System.Drawing.Point(126, 48);
			this.metroToggle1.Name = "metroToggle1";
			this.metroToggle1.Size = new global::System.Drawing.Size(80, 24);
			this.metroToggle1.TabIndex = 81;
			this.metroToggle1.Text = "Off";
			this.metroToggle1.UseSelectable = true;
			this.metroToggle1.CheckedChanged += new global::System.EventHandler(this.metroToggle1_CheckedChanged);
			this.Username1.AutoSize = true;
			this.Username1.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.Username1.ForeColor = global::System.Drawing.Color.Gold;
			this.Username1.Location = new global::System.Drawing.Point(123, 219);
			this.Username1.Name = "Username1";
			this.Username1.Size = new global::System.Drawing.Size(80, 18);
			this.Username1.TabIndex = 76;
			this.Username1.Text = "Username";
			this.Username.AutoSize = true;
			this.Username.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.Username.ForeColor = global::System.Drawing.Color.White;
			this.Username.Location = new global::System.Drawing.Point(123, 201);
			this.Username.Name = "Username";
			this.Username.Size = new global::System.Drawing.Size(76, 18);
			this.Username.TabIndex = 74;
			this.Username.Text = "Welcome:";
			this.label33.AutoSize = true;
			this.label33.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.label33.ForeColor = global::System.Drawing.Color.White;
			this.label33.Location = new global::System.Drawing.Point(114, 27);
			this.label33.Name = "label33";
			this.label33.Size = new global::System.Drawing.Size(153, 18);
			this.label33.TabIndex = 73;
			this.label33.Text = "Enable Color Hunter";
			this.TriggerBot.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.TriggerBot.Controls.Add(this.label34);
			this.TriggerBot.Controls.Add(this.label35);
			this.TriggerBot.Controls.Add(this.Pingx);
			this.TriggerBot.Controls.Add(this.FireRateNum);
			this.TriggerBot.Controls.Add(this.TriggerbotBtt);
			this.TriggerBot.Controls.Add(this.TriggerKeyBtt);
			this.TriggerBot.Controls.Add(this.AimKeyToggle);
			this.TriggerBot.Controls.Add(this.IsHoldToggle);
			this.TriggerBot.HorizontalScrollbarBarColor = true;
			this.TriggerBot.HorizontalScrollbarHighlightOnWheel = false;
			this.TriggerBot.HorizontalScrollbarSize = 10;
			this.TriggerBot.Location = new global::System.Drawing.Point(4, 24);
			this.TriggerBot.Name = "TriggerBot";
			this.TriggerBot.Size = new global::System.Drawing.Size(386, 332);
			this.TriggerBot.TabIndex = 2;
			this.TriggerBot.Text = "Settings";
			this.TriggerBot.UseCustomBackColor = true;
			this.TriggerBot.VerticalScrollbarBarColor = false;
			this.TriggerBot.VerticalScrollbarHighlightOnWheel = false;
			this.TriggerBot.VerticalScrollbarSize = 0;
			this.metroTabPage1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroTabPage1.Controls.Add(this.label11);
			this.metroTabPage1.Controls.Add(this.LoadSettings);
			this.metroTabPage1.Controls.Add(this.label8);
			this.metroTabPage1.Controls.Add(this.label5);
			this.metroTabPage1.Controls.Add(this.SaveSettings);
			this.metroTabPage1.Controls.Add(this.button5);
			this.metroTabPage1.Controls.Add(this.button2);
			this.metroTabPage1.Controls.Add(this.button3);
			this.metroTabPage1.Controls.Add(this.button4);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new global::System.Drawing.Point(4, 24);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new global::System.Drawing.Size(386, 332);
			this.metroTabPage1.TabIndex = 3;
			this.metroTabPage1.Text = "Profiles";
			this.metroTabPage1.UseCustomBackColor = true;
			this.metroTabPage1.UseCustomForeColor = true;
			this.metroTabPage1.UseStyleColors = true;
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Arial Black", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(103, 252);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(165, 18);
			this.label11.TabIndex = 74;
			this.label11.Text = "Custom Configuration";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Arial Black", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(294, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(28, 18);
			this.label8.TabIndex = 68;
			this.label8.Text = "4K";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Arial Black", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(54, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(53, 18);
			this.label5.TabIndex = 67;
			this.label5.Text = "1080P";
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.button5.Location = new global::System.Drawing.Point(11, 23);
			this.button5.Margin = new global::System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(169, 63);
			this.button5.TabIndex = 61;
			this.button5.Text = "FOV: 5\r\nClick Speed: 50\r\n";
			this.button5.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.button2.Location = new global::System.Drawing.Point(208, 23);
			this.button2.Margin = new global::System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(162, 63);
			this.button2.TabIndex = 62;
			this.button2.Text = "FOV: 32\rClick Speed: 50\r\n\r\n";
			this.button2.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.button3.Location = new global::System.Drawing.Point(11, 105);
			this.button3.Margin = new global::System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(169, 60);
			this.button3.TabIndex = 63;
			this.button3.Text = "FOV: 7\r\nClick Speed: 150\r\n";
			this.button3.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.button4.Location = new global::System.Drawing.Point(208, 105);
			this.button4.Margin = new global::System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(162, 60);
			this.button4.TabIndex = 64;
			this.button4.Text = "FOV: 40\r\nClick Speed: 150\r\n\r\n";
			this.button4.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.metroTabPage2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroTabPage2.Controls.Add(this.customres);
			this.metroTabPage2.Controls.Add(this.button1);
			this.metroTabPage2.Controls.Add(this.ScreenX2);
			this.metroTabPage2.Controls.Add(this.ScreenY);
			this.metroTabPage2.Controls.Add(this.label18);
			this.metroTabPage2.Controls.Add(this.ScreenY2);
			this.metroTabPage2.Controls.Add(this.ChangeMonitorBtt);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new global::System.Drawing.Point(4, 24);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new global::System.Drawing.Size(386, 332);
			this.metroTabPage2.TabIndex = 4;
			this.metroTabPage2.Text = "Others";
			this.metroTabPage2.UseCustomBackColor = true;
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(175, 15, 71);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.button1.Location = new global::System.Drawing.Point(88, 157);
			this.button1.Margin = new global::System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(181, 31);
			this.button1.TabIndex = 57;
			this.button1.Text = "RGB SELECTOR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(236, 56);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 146;
			this.pictureBox1.TabStop = false;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.FromArgb(32, 30, 45);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(32, 30, 45);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(-625, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 148;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.FromArgb(32, 30, 45);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(32, 30, 45);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(-580, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 149;
			this.siticoneControlBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox3.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.siticoneControlBox3.BorderRadius = 10;
			this.siticoneControlBox3.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.siticoneControlBox3.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox3.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox3.Location = new global::System.Drawing.Point(314, 4);
			this.siticoneControlBox3.Name = "siticoneControlBox3";
			this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox3.TabIndex = 150;
			this.siticoneControlBox3.Click += new global::System.EventHandler(this.siticoneControlBox3_Click);
			this.siticoneControlBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox4.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.siticoneControlBox4.BorderRadius = 10;
			this.siticoneControlBox4.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneControlBox4.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.siticoneControlBox4.HoveredState.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox4.Location = new global::System.Drawing.Point(269, 4);
			this.siticoneControlBox4.Name = "siticoneControlBox4";
			this.siticoneControlBox4.ShadowDecoration.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox4.TabIndex = 151;
			this.siticoneDragControl1.TargetControl = this;
			this.fovcircle2.AutoSize = true;
			this.fovcircle2.Location = new global::System.Drawing.Point(604, 361);
			this.fovcircle2.Name = "fovcircle2";
			this.fovcircle2.Size = new global::System.Drawing.Size(72, 17);
			this.fovcircle2.TabIndex = 152;
			this.fovcircle2.Text = "fovcircle2";
			this.fovcircle2.UseVisualStyleBackColor = true;
			this.fovcircle2.Visible = false;
			this.fovcircle2.CheckedChanged += new global::System.EventHandler(this.fovcircle2_CheckedChanged);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(373, 418);
			base.Controls.Add(this.fovcircle2);
			base.Controls.Add(this.siticoneControlBox3);
			base.Controls.Add(this.siticoneControlBox4);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.radioButton1);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.Bhopinput);
			base.Controls.Add(this.Bdelay);
			base.Controls.Add(this.label28);
			base.Controls.Add(this.Redinput);
			base.Controls.Add(this.Greeninput);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.Blueinput);
			base.Controls.Add(this.TabControl);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.FovYNum);
			base.Controls.Add(this.label57);
			base.Controls.Add(this.Norecoilaimval);
			base.Controls.Add(this.label52);
			base.Controls.Add(this.Firerage);
			base.Controls.Add(this.Ragebot);
			base.Controls.Add(this.label24);
			base.Controls.Add(this.chanceval);
			base.Controls.Add(this.TargetCheck);
			base.Controls.Add(this.label49);
			base.Controls.Add(this.ColWidth);
			base.Controls.Add(this.CircleWidth);
			base.Controls.Add(this.label48);
			base.Controls.Add(this.label41);
			base.Controls.Add(this.ColY);
			base.Controls.Add(this.ColX);
			base.Controls.Add(this.label42);
			base.Controls.Add(this.label37);
			base.Controls.Add(this.label38);
			base.Controls.Add(this.ColB);
			base.Controls.Add(this.ColG);
			base.Controls.Add(this.ColR);
			base.Controls.Add(this.label39);
			base.Controls.Add(this.label36);
			base.Controls.Add(this.label30);
			base.Controls.Add(this.label31);
			base.Controls.Add(this.CircleBlue);
			base.Controls.Add(this.CircleGreen);
			base.Controls.Add(this.CircleRed);
			base.Controls.Add(this.label32);
			base.Controls.Add(this.label29);
			base.Controls.Add(this.label26);
			base.Controls.Add(this.label27);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label25);
			base.Controls.Add(this.SmoothX);
			base.Controls.Add(this.label23);
			base.Controls.Add(this.label22);
			base.Controls.Add(this.Delayx);
			base.Controls.Add(this.label21);
			base.Controls.Add(this.rcs);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.Speed3);
			base.Controls.Add(this.RecoilBtt);
			base.Controls.Add(this.Customcolor);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.offsetNum);
			base.Controls.Add(this.AimkeyBtt);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.FovXNum);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.Speed);
			base.Controls.Add(this.AimbotBtt);
			this.DoubleBuffered = true;
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "yxDYUpiwUrn";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			base.Load += new global::System.EventHandler(this.Main_load);
			((global::System.ComponentModel.ISupportInitialize)this.Speed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovXNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.offsetNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Speed3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Delayx).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SmoothX).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.rcs).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FireRateNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Redinput).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Greeninput).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Blueinput).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Pingx).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ScreenX2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ScreenY2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bhopinput).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Bdelay).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleBlue).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleGreen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleRed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColB).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColG).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColR).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColY).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColX).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CircleWidth).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColWidth).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chanceval).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Firerage).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Norecoilaimval).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovYNum).EndInit();
			this.TabControl.ResumeLayout(false);
			this.Home.ResumeLayout(false);
			this.Home.PerformLayout();
			this.TriggerBot.ResumeLayout(false);
			this.TriggerBot.PerformLayout();
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage1.PerformLayout();
			this.metroTabPage2.ResumeLayout(false);
			this.metroTabPage2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000079 RID: 121
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400007A RID: 122
		public global::System.Windows.Forms.NumericUpDown CircleBlue;

		// Token: 0x0400007B RID: 123
		public global::System.Windows.Forms.NumericUpDown CircleGreen;

		// Token: 0x0400007C RID: 124
		public global::System.Windows.Forms.NumericUpDown CircleRed;

		// Token: 0x0400007D RID: 125
		public global::System.Windows.Forms.NumericUpDown CircleWidth;

		// Token: 0x0400007E RID: 126
		public global::System.Windows.Forms.CheckBox TriggerbotBtt;

		// Token: 0x0400007F RID: 127
		public global::System.Windows.Forms.Label label1;

		// Token: 0x04000080 RID: 128
		public global::System.Windows.Forms.Label label2;

		// Token: 0x04000081 RID: 129
		public global::System.Windows.Forms.Label label3;

		// Token: 0x04000082 RID: 130
		public global::System.Windows.Forms.Button ChangeMonitorBtt;

		// Token: 0x04000083 RID: 131
		public global::System.Windows.Forms.CheckBox AimKeyToggle;

		// Token: 0x04000084 RID: 132
		public global::System.Windows.Forms.CheckBox IsHoldToggle;

		// Token: 0x04000085 RID: 133
		public global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000086 RID: 134
		public global::System.Windows.Forms.Label label4;

		// Token: 0x04000087 RID: 135
		public global::System.Windows.Forms.NumericUpDown FireRateNum;

		// Token: 0x04000088 RID: 136
		public global::System.Windows.Forms.Label label9;

		// Token: 0x04000089 RID: 137
		public global::System.Windows.Forms.RadioButton Customcolor;

		// Token: 0x0400008A RID: 138
		public global::System.Windows.Forms.NumericUpDown Redinput;

		// Token: 0x0400008B RID: 139
		public global::System.Windows.Forms.NumericUpDown Greeninput;

		// Token: 0x0400008C RID: 140
		public global::System.Windows.Forms.NumericUpDown Blueinput;

		// Token: 0x0400008D RID: 141
		public global::System.Windows.Forms.NumericUpDown Pingx;

		// Token: 0x0400008E RID: 142
		public global::System.Windows.Forms.NumericUpDown ScreenX2;

		// Token: 0x0400008F RID: 143
		public global::System.Windows.Forms.NumericUpDown ScreenY2;

		// Token: 0x04000090 RID: 144
		public global::System.Windows.Forms.Label label18;

		// Token: 0x04000091 RID: 145
		public global::System.Windows.Forms.Label ScreenY;

		// Token: 0x04000092 RID: 146
		public global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000093 RID: 147
		public global::System.Windows.Forms.NumericUpDown Bhopinput;

		// Token: 0x04000094 RID: 148
		public global::System.Windows.Forms.Button TriggerKeyBtt;

		// Token: 0x04000095 RID: 149
		public global::System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

		// Token: 0x04000096 RID: 150
		public global::System.Windows.Forms.Label label10;

		// Token: 0x04000097 RID: 151
		public global::System.Windows.Forms.Label label20;

		// Token: 0x04000098 RID: 152
		public global::System.Windows.Forms.Label label21;

		// Token: 0x04000099 RID: 153
		public global::System.Windows.Forms.Label label22;

		// Token: 0x0400009A RID: 154
		public global::System.Windows.Forms.Label label23;

		// Token: 0x0400009B RID: 155
		public global::System.Windows.Forms.Label label25;

		// Token: 0x0400009C RID: 156
		public global::System.Windows.Forms.CheckBox RecoilBtt;

		// Token: 0x0400009D RID: 157
		public global::System.Windows.Forms.Label label7;

		// Token: 0x0400009E RID: 158
		public global::System.Windows.Forms.Label label27;

		// Token: 0x0400009F RID: 159
		public global::System.Windows.Forms.Label label26;

		// Token: 0x040000A0 RID: 160
		public global::System.Windows.Forms.Label label28;

		// Token: 0x040000A1 RID: 161
		public global::System.Windows.Forms.NumericUpDown Bdelay;

		// Token: 0x040000A2 RID: 162
		public global::System.Windows.Forms.Label label30;

		// Token: 0x040000A3 RID: 163
		public global::System.Windows.Forms.Label label31;

		// Token: 0x040000A4 RID: 164
		public global::System.Windows.Forms.Label label32;

		// Token: 0x040000A5 RID: 165
		public global::System.Windows.Forms.Label label29;

		// Token: 0x040000A6 RID: 166
		public global::System.Windows.Forms.Label label36;

		// Token: 0x040000A7 RID: 167
		public global::System.Windows.Forms.Label label37;

		// Token: 0x040000A8 RID: 168
		public global::System.Windows.Forms.Label label38;

		// Token: 0x040000A9 RID: 169
		public global::System.Windows.Forms.NumericUpDown ColB;

		// Token: 0x040000AA RID: 170
		public global::System.Windows.Forms.NumericUpDown ColG;

		// Token: 0x040000AB RID: 171
		public global::System.Windows.Forms.NumericUpDown ColR;

		// Token: 0x040000AC RID: 172
		public global::System.Windows.Forms.Label label39;

		// Token: 0x040000AD RID: 173
		public global::System.Windows.Forms.Label label41;

		// Token: 0x040000AE RID: 174
		public global::System.Windows.Forms.NumericUpDown ColY;

		// Token: 0x040000AF RID: 175
		public global::System.Windows.Forms.NumericUpDown ColX;

		// Token: 0x040000B0 RID: 176
		public global::System.Windows.Forms.Label label42;

		// Token: 0x040000B1 RID: 177
		public global::System.Windows.Forms.CheckBox AimbotBtt;

		// Token: 0x040000B2 RID: 178
		public global::System.Windows.Forms.NumericUpDown Speed;

		// Token: 0x040000B3 RID: 179
		public global::System.Windows.Forms.NumericUpDown FovXNum;

		// Token: 0x040000B4 RID: 180
		public global::System.Windows.Forms.NumericUpDown offsetNum;

		// Token: 0x040000B5 RID: 181
		public global::System.Windows.Forms.NumericUpDown Speed3;

		// Token: 0x040000B6 RID: 182
		public global::System.Windows.Forms.NumericUpDown Delayx;

		// Token: 0x040000B7 RID: 183
		public global::System.Windows.Forms.NumericUpDown SmoothX;

		// Token: 0x040000B8 RID: 184
		public global::System.Windows.Forms.NumericUpDown rcs;

		// Token: 0x040000B9 RID: 185
		public global::System.Windows.Forms.Button AimkeyBtt;

		// Token: 0x040000BA RID: 186
		public global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x040000BB RID: 187
		public global::System.Windows.Forms.Label label48;

		// Token: 0x040000BC RID: 188
		public global::System.Windows.Forms.NumericUpDown ColWidth;

		// Token: 0x040000BD RID: 189
		public global::System.Windows.Forms.Label label49;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.CheckBox TargetCheck;

		// Token: 0x040000BF RID: 191
		public global::System.Windows.Forms.NumericUpDown chanceval;

		// Token: 0x040000C0 RID: 192
		public global::System.Windows.Forms.Label label24;

		// Token: 0x040000C1 RID: 193
		public global::System.Windows.Forms.CheckBox Ragebot;

		// Token: 0x040000C2 RID: 194
		public global::System.Windows.Forms.Label label52;

		// Token: 0x040000C3 RID: 195
		public global::System.Windows.Forms.NumericUpDown Firerage;

		// Token: 0x040000C4 RID: 196
		public global::System.Windows.Forms.Label label57;

		// Token: 0x040000C5 RID: 197
		public global::System.Windows.Forms.NumericUpDown Norecoilaimval;

		// Token: 0x040000C6 RID: 198
		public global::System.Windows.Forms.NumericUpDown FovYNum;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040000C8 RID: 200
		private global::MetroFramework.Controls.MetroTabControl TabControl;

		// Token: 0x040000C9 RID: 201
		private global::MetroFramework.Controls.MetroTabPage Home;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Label Username1;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label Username;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label33;

		// Token: 0x040000CD RID: 205
		public global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x040000CE RID: 206
		private global::MetroFramework.Controls.MetroTabPage TriggerBot;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000D0 RID: 208
		public global::System.Windows.Forms.Label label34;

		// Token: 0x040000D1 RID: 209
		public global::System.Windows.Forms.Label label35;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000D3 RID: 211
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x040000D4 RID: 212
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040000D5 RID: 213
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;

		// Token: 0x040000D6 RID: 214
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox4;

		// Token: 0x040000D7 RID: 215
		private global::MetroFramework.Controls.MetroToggle metroToggle1;

		// Token: 0x040000D8 RID: 216
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040000D9 RID: 217
		private global::MetroFramework.Controls.MetroTabPage metroTabPage1;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.CheckBox fovcircle2;

		// Token: 0x040000DB RID: 219
		private global::Siticone.UI.WinForms.SiticoneCheckBox customres;

		// Token: 0x040000DC RID: 220
		private global::MetroFramework.Controls.MetroTabPage metroTabPage2;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Button button5;

		// Token: 0x040000E3 RID: 227
		public global::System.Windows.Forms.Button LoadSettings;

		// Token: 0x040000E4 RID: 228
		public global::System.Windows.Forms.Button SaveSettings;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label label11;
	}
}
