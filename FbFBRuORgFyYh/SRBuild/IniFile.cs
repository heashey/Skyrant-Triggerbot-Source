using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace SRBuild
{
	// Token: 0x02000026 RID: 38
	internal class IniFile
	{
		// Token: 0x0600011F RID: 287
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

		// Token: 0x06000120 RID: 288
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

		// Token: 0x06000121 RID: 289 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		public IniFile(string IniPath = null)
		{
			this.Path = new FileInfo(IniPath ?? (this.EXE + ".ini")).FullName;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00010B10 File Offset: 0x0000ED10
		public string Read(string Key, string Section = null)
		{
			StringBuilder RetVal = new StringBuilder(255);
			IniFile.GetPrivateProfileString(Section ?? this.EXE, Key, "", RetVal, 255, this.Path);
			return RetVal.ToString();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00010B51 File Offset: 0x0000ED51
		public void Write(string Key, string Value, string Section = null)
		{
			IniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00010B6C File Offset: 0x0000ED6C
		public void DeleteKey(string Key, string Section = null)
		{
			this.Write(Key, null, Section ?? this.EXE);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00010B81 File Offset: 0x0000ED81
		public void DeleteSection(string Section = null)
		{
			this.Write(null, null, Section ?? this.EXE);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00010B96 File Offset: 0x0000ED96
		public bool KeyExists(string Key, string Section = null)
		{
			return this.Read(Key, Section).Length > 0;
		}

		// Token: 0x0400013B RID: 315
		private string Path;

		// Token: 0x0400013C RID: 316
		private string EXE = Assembly.GetExecutingAssembly().GetName().Name;
	}
}
