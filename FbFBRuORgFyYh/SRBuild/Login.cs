using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using SRBuild.Properties;

namespace SRBuild
{
	// Token: 0x02000027 RID: 39
	public partial class Login : Form
	{
		// Token: 0x06000127 RID: 295
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000128 RID: 296
		public string getVersion()
		{
			return this.Version;
		}

		// Token: 0x06000129 RID: 297
		private void checkForUpdate()
		{
			string str = "https://skyrant.website/";
			string serverVersionName = "Update.txt";
			string ServerVersion = new StreamReader(WebRequest.Create(str + serverVersionName).GetResponse().GetResponseStream()).ReadLine();
			if (this.getVersion() != ServerVersion)
			{
				MessageBox.Show("Request a new build on the forums!", "Updates", MessageBoxButtons.OK);
				base.Close();
				return;
			}
			MessageBox.Show("You are currently running the latest version, you won't have to requesst a new build, enjoy!", "Updates", MessageBoxButtons.OK);
			new Colors().Show();
		}

		// Token: 0x0600012A RID: 298
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			base.Hide();
			new Register().Show();
		}

		// Token: 0x0600012B RID: 299
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600012C RID: 300
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			if (this.RememberMe.Checked)
			{
				Settings.Default.Username = this.username.Text;
				Settings.Default.Password = this.password.Text;
				Settings.Default.Save();
			}
			MessageBox.Show("Login successful! now checking for updates", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.checkForUpdate();
			base.Hide();
		}

		// Token: 0x0600012D RID: 301
		private void username_Enter(object sender, EventArgs e)
		{
			this.username.SelectAll();
		}

		// Token: 0x0600012E RID: 302
		private void password_Enter(object sender, EventArgs e)
		{
			this.password.SelectAll();
		}

		// Token: 0x0600012F RID: 303
		private void Login_Load(object sender, EventArgs e)
		{
			if (Settings.Default.Username != string.Empty)
			{
				this.username.Text = Settings.Default.Username;
				this.password.Text = Settings.Default.Password;
			}
		}

		// Token: 0x06000130 RID: 304
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000131 RID: 305
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400013D RID: 317
		private readonly string Version = "730.0";
	}
}
