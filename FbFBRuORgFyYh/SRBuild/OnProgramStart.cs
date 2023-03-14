using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;

namespace SRBuild
{
	// Token: 0x02000008 RID: 8
	internal class OnProgramStart
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000231C File Offset: 0x0000051C
		public static void Initialize(string name, string aid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(aid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				MessageBox.Show("Invalid application information!", "", MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			OnProgramStart.AID = aid;
			OnProgramStart.Secret = secret;
			OnProgramStart.Version = version;
			OnProgramStart.Name = name;
			string[] response = new string[0];
			using (WebClient wc = new WebClient())
			{
				try
				{
					wc.Proxy = null;
					Security.Start();
					Encoding @default = Encoding.Default;
					WebClient webClient = wc;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("start");
					response = Encryption.DecryptService(@default.GetString(webClient.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					if (Security.MaliciousCheck(response[1]))
					{
						MessageBox.Show("For verification checks, please re-log", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					if (Constants.Breached)
					{
						MessageBox.Show("For verification checks, please re-log", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					if (response[0] != Constants.Token)
					{
						MessageBox.Show("Security error has been triggered!", "", MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
					string a = response[2];
					if (!(a == "success"))
					{
						if (a == "binderror")
						{
							MessageBox.Show(Encryption.Decode("RmFpbGVkIHRvIGJpbmQgdG8gc2VydmVyLCBjaGVjayB5b3VyIEFJRCAmIFNlY3JldCBpbiB5b3VyIGNvZGUh"), "", MessageBoxButton.OK, MessageBoxImage.Hand);
							Process.GetCurrentProcess().Kill();
							return;
						}
						if (a == "banned")
						{
							MessageBox.Show("This application has been banned for violating the TOS" + Environment.NewLine + "Contact us at support@auth.gg", "", MessageBoxButton.OK, MessageBoxImage.Hand);
							Process.GetCurrentProcess().Kill();
							return;
						}
					}
					else
					{
						Constants.Initialized = true;
						if (response[3] == "Enabled")
						{
							ApplicationSettings.Status = true;
						}
						if (response[4] == "Enabled")
						{
							ApplicationSettings.DeveloperMode = true;
						}
						ApplicationSettings.Hash = response[5];
						ApplicationSettings.Version = response[6];
						ApplicationSettings.Update_Link = response[7];
						if (response[8] == "Enabled")
						{
							ApplicationSettings.Freemode = true;
						}
						if (response[9] == "Enabled")
						{
							ApplicationSettings.Login = true;
						}
						ApplicationSettings.Name = response[10];
						if (response[11] == "Enabled")
						{
							ApplicationSettings.Register = true;
						}
						if (ApplicationSettings.DeveloperMode)
						{
							MessageBox.Show("Application is in Developer Mode, bypassing integrity and update check!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
							File.Create(Environment.CurrentDirectory + "/integrity.log").Close();
							string hash = Security.Integrity(Process.GetCurrentProcess().MainModule.FileName);
							File.WriteAllText(Environment.CurrentDirectory + "/integrity.log", hash);
							MessageBox.Show("Your applications hash has been saved to integrity.txt, please refer to this when your application is ready for release!", "", MessageBoxButton.OK, MessageBoxImage.Asterisk);
						}
						else
						{
							if (response[12] == "Enabled" && ApplicationSettings.Hash != Security.Integrity(Process.GetCurrentProcess().MainModule.FileName))
							{
								MessageBox.Show("File has been tampered with, couldn't verify integrity!", "", MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.GetCurrentProcess().Kill();
							}
							if (ApplicationSettings.Version != OnProgramStart.Version)
							{
								MessageBox.Show("Update " + ApplicationSettings.Version + " available, redirecting to update!", "", MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.Start(ApplicationSettings.Update_Link);
								Process.GetCurrentProcess().Kill();
							}
						}
						if (!ApplicationSettings.Status)
						{
							MessageBox.Show("Looks like this application is disabled, please try again later!", "", MessageBoxButton.OK, MessageBoxImage.Hand);
							Process.GetCurrentProcess().Kill();
						}
					}
					Security.End();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x04000026 RID: 38
		public static string AID;

		// Token: 0x04000027 RID: 39
		public static string Secret;

		// Token: 0x04000028 RID: 40
		public static string Version;

		// Token: 0x04000029 RID: 41
		public static string Name;

		// Token: 0x0400002A RID: 42
		public static string Salt;
	}
}
