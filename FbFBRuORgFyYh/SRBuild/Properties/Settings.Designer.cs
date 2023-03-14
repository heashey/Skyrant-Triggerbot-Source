using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SRBuild.Properties
{
	// Token: 0x0200002F RID: 47
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00014094 File Offset: 0x00012294
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001409B File Offset: 0x0001229B
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000140AD File Offset: 0x000122AD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isTriggerbot
		{
			get
			{
				return (bool)this["isTriggerbot"];
			}
			set
			{
				this["isTriggerbot"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000140C0 File Offset: 0x000122C0
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000140D2 File Offset: 0x000122D2
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isPing
		{
			get
			{
				return (bool)this["isPing"];
			}
			set
			{
				this["isPing"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000140E5 File Offset: 0x000122E5
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000140F7 File Offset: 0x000122F7
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isAimbot
		{
			get
			{
				return (bool)this["isAimbot"];
			}
			set
			{
				this["isAimbot"] = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001410A File Offset: 0x0001230A
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0001411C File Offset: 0x0001231C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isEsp
		{
			get
			{
				return (bool)this["isEsp"];
			}
			set
			{
				this["isEsp"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001412F File Offset: 0x0001232F
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00014141 File Offset: 0x00012341
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool TriggerRage
		{
			get
			{
				return (bool)this["TriggerRage"];
			}
			set
			{
				this["TriggerRage"] = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00014154 File Offset: 0x00012354
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00014166 File Offset: 0x00012366
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isCircle
		{
			get
			{
				return (bool)this["isCircle"];
			}
			set
			{
				this["isCircle"] = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00014179 File Offset: 0x00012379
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0001418B File Offset: 0x0001238B
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isRecoil
		{
			get
			{
				return (bool)this["isRecoil"];
			}
			set
			{
				this["isRecoil"] = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0001419E File Offset: 0x0001239E
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000141B0 File Offset: 0x000123B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isBhop
		{
			get
			{
				return (bool)this["isBhop"];
			}
			set
			{
				this["isBhop"] = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000141C3 File Offset: 0x000123C3
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000141D5 File Offset: 0x000123D5
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.15")]
		public decimal speed
		{
			get
			{
				return (decimal)this["speed"];
			}
			set
			{
				this["speed"] = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000141E8 File Offset: 0x000123E8
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000141FA File Offset: 0x000123FA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.05")]
		public decimal speed3
		{
			get
			{
				return (decimal)this["speed3"];
			}
			set
			{
				this["speed3"] = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0001420D File Offset: 0x0001240D
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0001421F File Offset: 0x0001241F
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("50")]
		public decimal delayx
		{
			get
			{
				return (decimal)this["delayx"];
			}
			set
			{
				this["delayx"] = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00014232 File Offset: 0x00012432
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00014244 File Offset: 0x00012444
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("4")]
		public decimal Bhop
		{
			get
			{
				return (decimal)this["Bhop"];
			}
			set
			{
				this["Bhop"] = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00014257 File Offset: 0x00012457
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00014269 File Offset: 0x00012469
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("50")]
		public decimal PingX
		{
			get
			{
				return (decimal)this["PingX"];
			}
			set
			{
				this["PingX"] = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0001427C File Offset: 0x0001247C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0001428E File Offset: 0x0001248E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("400")]
		public int fovX
		{
			get
			{
				return (int)this["fovX"];
			}
			set
			{
				this["fovX"] = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000142A1 File Offset: 0x000124A1
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000142B3 File Offset: 0x000124B3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("200")]
		public int fovY
		{
			get
			{
				return (int)this["fovY"];
			}
			set
			{
				this["fovY"] = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000142C6 File Offset: 0x000124C6
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000142D8 File Offset: 0x000124D8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int FovCircleRed
		{
			get
			{
				return (int)this["FovCircleRed"];
			}
			set
			{
				this["FovCircleRed"] = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000142EB File Offset: 0x000124EB
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000142FD File Offset: 0x000124FD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isRunning
		{
			get
			{
				return (bool)this["isRunning"];
			}
			set
			{
				this["isRunning"] = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00014310 File Offset: 0x00012510
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00014322 File Offset: 0x00012522
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int FovCircleGreen
		{
			get
			{
				return (int)this["FovCircleGreen"];
			}
			set
			{
				this["FovCircleGreen"] = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00014335 File Offset: 0x00012535
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00014347 File Offset: 0x00012547
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int FovCircleBlue
		{
			get
			{
				return (int)this["FovCircleBlue"];
			}
			set
			{
				this["FovCircleBlue"] = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0001435A File Offset: 0x0001255A
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0001436C File Offset: 0x0001256C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int FovCircleWidth
		{
			get
			{
				return (int)this["FovCircleWidth"];
			}
			set
			{
				this["FovCircleWidth"] = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0001437F File Offset: 0x0001257F
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00014391 File Offset: 0x00012591
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int color
		{
			get
			{
				return (int)this["color"];
			}
			set
			{
				this["color"] = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000143A4 File Offset: 0x000125A4
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000143B6 File Offset: 0x000125B6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("164")]
		public int mainAimKey
		{
			get
			{
				return (int)this["mainAimKey"];
			}
			set
			{
				this["mainAimKey"] = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000143C9 File Offset: 0x000125C9
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000143DB File Offset: 0x000125DB
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("164")]
		public int Bhopxkey
		{
			get
			{
				return (int)this["Bhopxkey"];
			}
			set
			{
				this["Bhopxkey"] = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000143EE File Offset: 0x000125EE
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00014400 File Offset: 0x00012600
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool isHold
		{
			get
			{
				return (bool)this["isHold"];
			}
			set
			{
				this["isHold"] = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00014413 File Offset: 0x00012613
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00014425 File Offset: 0x00012625
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isAimKey
		{
			get
			{
				return (bool)this["isAimKey"];
			}
			set
			{
				this["isAimKey"] = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00014438 File Offset: 0x00012638
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0001444A File Offset: 0x0001264A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int monitor
		{
			get
			{
				return (int)this["monitor"];
			}
			set
			{
				this["monitor"] = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001445D File Offset: 0x0001265D
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0001446F File Offset: 0x0001266F
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("25")]
		public int offsetY
		{
			get
			{
				return (int)this["offsetY"];
			}
			set
			{
				this["offsetY"] = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00014482 File Offset: 0x00012682
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00014494 File Offset: 0x00012694
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("130")]
		public int msShootTime
		{
			get
			{
				return (int)this["msShootTime"];
			}
			set
			{
				this["msShootTime"] = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000144A7 File Offset: 0x000126A7
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000144B9 File Offset: 0x000126B9
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Username
		{
			get
			{
				return (string)this["Username"];
			}
			set
			{
				this["Username"] = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000144C7 File Offset: 0x000126C7
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000144D9 File Offset: 0x000126D9
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x0400016A RID: 362
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
