using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace SRBuild
{
	// Token: 0x0200000F RID: 15
	internal class InfoManager
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000418D File Offset: 0x0000238D
		public InfoManager()
		{
			this.lastGateway = this.GetGatewayMAC();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000041A1 File Offset: 0x000023A1
		public void StartListener()
		{
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000041C4 File Offset: 0x000023C4
		private void OnCallBack()
		{
			this.timer.Dispose();
			if (!(this.GetGatewayMAC() == this.lastGateway))
			{
				Constants.Breached = true;
				MessageBox.Show("ARP Cache poisoning has been detected!", "", MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.lastGateway = this.GetGatewayMAC();
			}
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004240 File Offset: 0x00002440
		public static IPAddress GetDefaultGateway()
		{
			return (from a in (from n in NetworkInterface.GetAllNetworkInterfaces()
			where n.OperationalStatus == OperationalStatus.Up
			where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select n).SelectMany(delegate(NetworkInterface n)
			{
				IPInterfaceProperties ipproperties = n.GetIPProperties();
				if (ipproperties == null)
				{
					return null;
				}
				return ipproperties.GatewayAddresses;
			}).Select(delegate(GatewayIPAddressInformation g)
			{
				if (g == null)
				{
					return null;
				}
				return g.Address;
			})
			where a != null
			select a).FirstOrDefault<IPAddress>();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000430C File Offset: 0x0000250C
		private string GetArpTable()
		{
			string drive = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = drive + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}))
			{
				using (StreamReader reader = process.StandardOutput)
				{
					result = reader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000043A8 File Offset: 0x000025A8
		private string GetGatewayMAC()
		{
			string routerIP = InfoManager.GetDefaultGateway().ToString();
			string regx = string.Format("({0} [\\W]*) ([a-z0-9-]*)", routerIP);
			Regex regex = new Regex(regx);
			Match matches = regex.Match(this.GetArpTable());
			return matches.Groups[2].ToString();
		}

		// Token: 0x04000030 RID: 48
		private Timer timer;

		// Token: 0x04000031 RID: 49
		private string lastGateway;
	}
}
