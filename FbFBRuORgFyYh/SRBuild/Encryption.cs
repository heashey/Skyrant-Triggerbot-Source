using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SRBuild
{
	// Token: 0x0200000E RID: 14
	internal class Encryption
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003EA8 File Offset: 0x000020A8
		public static string APIService(string value)
		{
			string password = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			SHA256 mySHA256 = SHA256.Create();
			byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
			byte[] iv = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.EncryptString(value, key, iv);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003F14 File Offset: 0x00002114
		public static string EncryptService(string value)
		{
			string password = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			SHA256 mySHA256 = SHA256.Create();
			byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
			byte[] iv = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			string encrypted = Encryption.EncryptString(value, key, iv);
			int property = int.Parse(OnProgramStart.AID.Substring(0, 2));
			return encrypted + Security.Obfuscate(property);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003FA0 File Offset: 0x000021A0
		public static string DecryptService(string value)
		{
			string password = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			SHA256 mySHA256 = SHA256.Create();
			byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
			byte[] iv = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.DecryptString(value, key, iv);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000400C File Offset: 0x0000220C
		public static string EncryptString(string plainText, byte[] key, byte[] iv)
		{
			Aes encryptor = Aes.Create();
			encryptor.Mode = CipherMode.CBC;
			encryptor.Key = key;
			encryptor.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);
			byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);
			cryptoStream.Write(plainBytes, 0, plainBytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] cipherBytes = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004090 File Offset: 0x00002290
		public static string DecryptString(string cipherText, byte[] key, byte[] iv)
		{
			Aes encryptor = Aes.Create();
			encryptor.Mode = CipherMode.CBC;
			encryptor.Key = key;
			encryptor.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);
			string plainText = string.Empty;
			try
			{
				byte[] cipherBytes = Convert.FromBase64String(cipherText);
				cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
				cryptoStream.FlushFinalBlock();
				byte[] plainBytes = memoryStream.ToArray();
				plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return plainText;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000412C File Offset: 0x0000232C
		public static string Decode(string text)
		{
			text = text.Replace('_', '/').Replace('-', '+');
			int num = text.Length % 4;
			if (num != 2)
			{
				if (num == 3)
				{
					text += "=";
				}
			}
			else
			{
				text += "==";
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(text));
		}
	}
}
