using System;

namespace SRBuild
{
	// Token: 0x02000007 RID: 7
	internal class ApplicationSettings
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002293 File Offset: 0x00000493
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000229A File Offset: 0x0000049A
		public static bool Status { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000022A2 File Offset: 0x000004A2
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000022A9 File Offset: 0x000004A9
		public static bool DeveloperMode { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000022B1 File Offset: 0x000004B1
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000022B8 File Offset: 0x000004B8
		public static string Hash { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000022C0 File Offset: 0x000004C0
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000022C7 File Offset: 0x000004C7
		public static string Version { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000022CF File Offset: 0x000004CF
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000022D6 File Offset: 0x000004D6
		public static string Update_Link { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022DE File Offset: 0x000004DE
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000022E5 File Offset: 0x000004E5
		public static bool Freemode { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000022ED File Offset: 0x000004ED
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000022F4 File Offset: 0x000004F4
		public static bool Login { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000022FC File Offset: 0x000004FC
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002303 File Offset: 0x00000503
		public static string Name { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000230B File Offset: 0x0000050B
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002312 File Offset: 0x00000512
		public static bool Register { get; set; }
	}
}
