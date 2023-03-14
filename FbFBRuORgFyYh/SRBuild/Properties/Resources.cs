using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SRBuild.Properties
{
	// Token: 0x0200002E RID: 46
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00002057 File Offset: 0x00000257
		internal Resources()
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001404C File Offset: 0x0001224C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager temp = new ResourceManager("SRBuild.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00014085 File Offset: 0x00012285
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0001408C File Offset: 0x0001228C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000168 RID: 360
		private static ResourceManager resourceMan;

		// Token: 0x04000169 RID: 361
		private static CultureInfo resourceCulture;
	}
}
