using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace SRBuild
{
	// Token: 0x0200002D RID: 45
	public partial class Register : Form
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00012E09 File Offset: 0x00011009
		public Register()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00012E18 File Offset: 0x00011018
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			Login f = new Login();
			f.Show();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00010C7B File Offset: 0x0000EE7B
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00012E38 File Offset: 0x00011038
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			if (API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text))
			{
				MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00012E8B File Offset: 0x0001108B
		private void username_Enter(object sender, EventArgs e)
		{
			this.username.SelectAll();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00012E98 File Offset: 0x00011098
		private void password_Enter(object sender, EventArgs e)
		{
			this.password.SelectAll();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00012EA5 File Offset: 0x000110A5
		private void email_Enter(object sender, EventArgs e)
		{
			this.email.SelectAll();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00012EB2 File Offset: 0x000110B2
		private void license_Enter(object sender, EventArgs e)
		{
			this.license.SelectAll();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000045B5 File Offset: 0x000027B5
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000045B5 File Offset: 0x000027B5
		private void Register_Load(object sender, EventArgs e)
		{
		}
	}
}
