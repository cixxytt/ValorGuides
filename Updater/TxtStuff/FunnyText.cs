﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace vital1310
{
	internal class fText
	{
		public static void FunnyText()
		{
			int num = 80;
            _ = (new char[62]);
			char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
			RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
			byte[] array2 = new byte[num];
			randomNumberGenerator.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(num);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % (array.Length - 1)]);
			}
			Console.Title = (((stringBuilder != null) ? stringBuilder.ToString() : null) ?? "");
			new Thread(new ThreadStart(fText.FunnyText)).Start();
		}

		public static void Print(string message, int sec = 40)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
				Thread.Sleep(sec);
			}
		}
	}
}
