using System;
using System.Linq;
using System.Security.Principal;

namespace SRBuild
{
	// Token: 0x02000004 RID: 4
	internal class Constants
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000210E File Offset: 0x0000030E
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002115 File Offset: 0x00000315
		public static string Token { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000211D File Offset: 0x0000031D
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002124 File Offset: 0x00000324
		public static string Date { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002133 File Offset: 0x00000333
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000213B File Offset: 0x0000033B
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002142 File Offset: 0x00000342
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x06000011 RID: 17 RVA: 0x0000214A File Offset: 0x0000034A
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002185 File Offset: 0x00000385
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000009 RID: 9
		public static bool Breached = false;

		// Token: 0x0400000A RID: 10
		public static bool Started = false;

		// Token: 0x0400000B RID: 11
		public static string IV = null;

		// Token: 0x0400000C RID: 12
		public static string Key = null;

		// Token: 0x0400000D RID: 13
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x0400000E RID: 14
		public static bool Initialized = false;

		// Token: 0x0400000F RID: 15
		public static Random random = new Random();
	}
}
