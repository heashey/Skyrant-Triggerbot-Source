namespace SRBuild
{
	// Token: 0x02000023 RID: 35
	public partial class FormOverlay : global::System.Windows.Forms.Form
	{
		// Token: 0x06000103 RID: 259 RVA: 0x0000FDD0 File Offset: 0x0000DFD0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000FDF0 File Offset: 0x0000DFF0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SRBuild.FormOverlay));
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Fuchsia;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "FormOverlay";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ZCEodONfNKeYO";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.FormOverlay_Load);
			base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.FormOverlayPaint);
			base.ResumeLayout(false);
		}

		// Token: 0x0400012B RID: 299
		private global::System.ComponentModel.IContainer components;
	}
}
