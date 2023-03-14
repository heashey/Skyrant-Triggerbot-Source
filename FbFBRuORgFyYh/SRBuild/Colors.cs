using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SRBuild
{
	// Token: 0x02000011 RID: 17
	public partial class Colors : Form
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00004445 File Offset: 0x00002645
		public Colors()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004454 File Offset: 0x00002654
		private void button4_Click(object sender, EventArgs e)
		{
			base.Hide();
			GUI f = new GUI();
			f.Show();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004474 File Offset: 0x00002674
		private void button1_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "255", "Color Outlines");
			MyIni.Write("Green", "255", "Color Outlines");
			MyIni.Write("Blue", "22", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000044E0 File Offset: 0x000026E0
		private void button2_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "255", "Color Outlines");
			MyIni.Write("Green", "38", "Color Outlines");
			MyIni.Write("Blue", "40", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000454C File Offset: 0x0000274C
		private void button3_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "254", "Color Outlines");
			MyIni.Write("Green", "72", "Color Outlines");
			MyIni.Write("Blue", "255", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000045B5 File Offset: 0x000027B5
		private void Colors_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000045B8 File Offset: 0x000027B8
		private void button5_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "255", "Color Outlines");
			MyIni.Write("Green", "0", "Color Outlines");
			MyIni.Write("Blue", "2", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004624 File Offset: 0x00002824
		private void button6_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "204", "Color Outlines");
			MyIni.Write("Green", "43", "Color Outlines");
			MyIni.Write("Blue", "45", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004690 File Offset: 0x00002890
		private void button7_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "219", "Color Outlines");
			MyIni.Write("Green", "219", "Color Outlines");
			MyIni.Write("Blue", "35", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000046FC File Offset: 0x000028FC
		private void button8_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "232", "Color Outlines");
			MyIni.Write("Green", "232", "Color Outlines");
			MyIni.Write("Blue", "0", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004768 File Offset: 0x00002968
		private void button9_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "254", "Color Outlines");
			MyIni.Write("Green", "0", "Color Outlines");
			MyIni.Write("Blue", "255", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000047D4 File Offset: 0x000029D4
		private void button10_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "219", "Color Outlines");
			MyIni.Write("Green", "17", "Color Outlines");
			MyIni.Write("Blue", "220", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004840 File Offset: 0x00002A40
		private void button13_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "0", "Color Outlines");
			MyIni.Write("Green", "6", "Color Outlines");
			MyIni.Write("Blue", "255", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000048AC File Offset: 0x00002AAC
		private void button12_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "38", "Color Outlines");
			MyIni.Write("Green", "43", "Color Outlines");
			MyIni.Write("Blue", "228", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004918 File Offset: 0x00002B18
		private void button11_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "0", "Color Outlines");
			MyIni.Write("Green", "5", "Color Outlines");
			MyIni.Write("Blue", "214", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004984 File Offset: 0x00002B84
		private void button16_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "18", "Color Outlines");
			MyIni.Write("Green", "255", "Color Outlines");
			MyIni.Write("Blue", "0", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000049F0 File Offset: 0x00002BF0
		private void button15_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "50", "Color Outlines");
			MyIni.Write("Green", "212", "Color Outlines");
			MyIni.Write("Blue", "37", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004A5C File Offset: 0x00002C5C
		private void button14_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "40", "Color Outlines");
			MyIni.Write("Green", "156", "Color Outlines");
			MyIni.Write("Blue", "31", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004AC8 File Offset: 0x00002CC8
		private void button19_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "255", "Color Outlines");
			MyIni.Write("Green", "132", "Color Outlines");
			MyIni.Write("Blue", "0", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004B34 File Offset: 0x00002D34
		private void button18_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "208", "Color Outlines");
			MyIni.Write("Green", "129", "Color Outlines");
			MyIni.Write("Blue", "43", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004BA0 File Offset: 0x00002DA0
		private void button17_Click(object sender, EventArgs e)
		{
			IniFile MyIni = new IniFile("Colors.ini");
			MyIni.Write("Red", "255", "Color Outlines");
			MyIni.Write("Green", "96", "Color Outlines");
			MyIni.Write("Blue", "0", "Color Outlines");
			base.Hide();
			Form1 f = new Form1();
			f.Show();
		}
	}
}
