using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SRBuild
{
	// Token: 0x0200002C RID: 44
	internal static class Program
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00012D9C File Offset: 0x00010F9C
		[STAThread]
		private static void Main()
		{
			OnProgramStart.Initialize("SkyRant", "842667", "sTdgPJsQ9aUgs21H64gDBgKihArlPU3A26d", "1.0");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
			string url = "https://developers.auth.gg/whitelist/";
			WebRequest request = WebRequest.Create(url);
			WebResponse response = request.GetResponse();
			string result = new StreamReader(response.GetResponseStream()).ReadToEnd();
			string result2 = new WebClient().DownloadString(url);
		}
	}
}
