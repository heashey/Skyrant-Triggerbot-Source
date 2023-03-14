using System;
using System.Collections.Generic;

namespace SRBuild
{
	// Token: 0x02000003 RID: 3
	internal class App
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				if (User.ID != null || User.HWID != null || User.IP != null || !Constants.Breached)
				{
					result = App.Variables[name];
				}
				else
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x04000003 RID: 3
		public static string Error = null;

		// Token: 0x04000004 RID: 4
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
