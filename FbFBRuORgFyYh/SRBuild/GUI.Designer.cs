namespace SRBuild
{
	// Token: 0x02000024 RID: 36
	public partial class GUI : global::System.Windows.Forms.Form
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00010148 File Offset: 0x0000E348
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00010168 File Offset: 0x0000E368
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SRBuild.GUI));
			this.button1 = new global::System.Windows.Forms.Button();
			this.R = new global::System.Windows.Forms.NumericUpDown();
			this.G = new global::System.Windows.Forms.NumericUpDown();
			this.B = new global::System.Windows.Forms.NumericUpDown();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneShadowForm1 = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.button2 = new global::System.Windows.Forms.Button();
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.magnifyingGlass1 = new global::SRBuild.MagnifyingGlass();
			((global::System.ComponentModel.ISupportInitialize)this.R).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.G).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.B).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.White;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.button1.Location = new global::System.Drawing.Point(22, 229);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(158, 31);
			this.button1.TabIndex = 8;
			this.button1.Text = "Load NEW Color";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.R.Font = new global::System.Drawing.Font("Nirmala UI", 12f);
			this.R.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.R.Location = new global::System.Drawing.Point(22, 266);
			global::System.Windows.Forms.NumericUpDown r = this.R;
			int[] array = new int[4];
			array[0] = 255;
			r.Maximum = new decimal(array);
			this.R.Name = "R";
			this.R.Size = new global::System.Drawing.Size(105, 29);
			this.R.TabIndex = 5;
			this.G.Font = new global::System.Drawing.Font("Nirmala UI", 12f);
			this.G.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.G.Location = new global::System.Drawing.Point(135, 266);
			global::System.Windows.Forms.NumericUpDown g = this.G;
			int[] array2 = new int[4];
			array2[0] = 255;
			g.Maximum = new decimal(array2);
			this.G.Name = "G";
			this.G.Size = new global::System.Drawing.Size(105, 29);
			this.G.TabIndex = 6;
			this.B.Font = new global::System.Drawing.Font("Nirmala UI", 12f);
			this.B.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.B.Location = new global::System.Drawing.Point(247, 266);
			global::System.Windows.Forms.NumericUpDown b = this.B;
			int[] array3 = new int[4];
			array3[0] = 255;
			b.Maximum = new decimal(array3);
			this.B.Name = "B";
			this.B.Size = new global::System.Drawing.Size(105, 29);
			this.B.TabIndex = 7;
			this.panel1.Location = new global::System.Drawing.Point(84, 85);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(43, 86);
			this.panel1.TabIndex = 10;
			this.panel1.Visible = false;
			this.panel2.Location = new global::System.Drawing.Point(277, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(37, 86);
			this.panel2.TabIndex = 11;
			this.panel2.Visible = false;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(313, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 12;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.pictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(84, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(220, 57);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 34;
			this.pictureBox2.TabStop = false;
			this.siticoneDragControl1.TargetControl = this;
			this.button2.BackColor = global::System.Drawing.Color.White;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Arial Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.button2.Location = new global::System.Drawing.Point(194, 229);
			this.button2.Name = "button2";
			this.button2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.button2.Size = new global::System.Drawing.Size(158, 31);
			this.button2.TabIndex = 36;
			this.button2.Text = "Load OLD Color";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.magnifyingGlass1.BackColor = global::System.Drawing.Color.White;
			this.magnifyingGlass1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.magnifyingGlass1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.magnifyingGlass1.ForeColor = global::System.Drawing.Color.White;
			this.magnifyingGlass1.Location = new global::System.Drawing.Point(148, 80);
			this.magnifyingGlass1.Name = "magnifyingGlass1";
			this.magnifyingGlass1.PixelRange = 10;
			this.magnifyingGlass1.PixelSize = 5;
			this.magnifyingGlass1.PosAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.magnifyingGlass1.PosFormat = "#x ; #y";
			this.magnifyingGlass1.ShowPixel = true;
			this.magnifyingGlass1.ShowPosition = true;
			this.magnifyingGlass1.Size = new global::System.Drawing.Size(105, 105);
			this.magnifyingGlass1.TabIndex = 0;
			this.magnifyingGlass1.UseMovingGlass = true;
			this.magnifyingGlass1.DisplayUpdated += new global::SRBuild.MagnifyingGlass.DisplayUpdatedDelegate(this.magnifyingGlass1_DisplayUpdated);
			this.magnifyingGlass1.Load += new global::System.EventHandler(this.magnifyingGlass1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(372, 311);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.B);
			base.Controls.Add(this.G);
			base.Controls.Add(this.R);
			base.Controls.Add(this.magnifyingGlass1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "GUI";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CMPAVYbUWfTgcBm";
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Deactivate += new global::System.EventHandler(this.GUI_Deactivate);
			base.Load += new global::System.EventHandler(this.GUI_Load);
			((global::System.ComponentModel.ISupportInitialize)this.R).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.G).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.B).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400012C RID: 300
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400012D RID: 301
		private global::SRBuild.MagnifyingGlass magnifyingGlass1;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.NumericUpDown R;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.NumericUpDown G;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.NumericUpDown B;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000133 RID: 307
		public global::System.Windows.Forms.Button button1;

		// Token: 0x04000134 RID: 308
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000136 RID: 310
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000137 RID: 311
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;

		// Token: 0x04000138 RID: 312
		public global::System.Windows.Forms.Button button2;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}
