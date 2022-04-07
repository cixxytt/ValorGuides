using System;
using System.Windows.Forms;
using System.IO;
using DiscordRpcDemo;
using Discord.Webhook;
using System.Net;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
//download rat

namespace ValorGuides
{
	public partial class Form1 : Form
	{


		string rating1 = "C:\\Users\\Default\\AppData\\Local\\cixx\\rating1";
		string rating2 = "C:\\Users\\Default\\AppData\\Local\\cixx\\rating2";
		string rating3 = "C:\\Users\\Default\\AppData\\Local\\cixx\\rating3";
		string rating4 = "C:\\Users\\Default\\AppData\\Local\\cixx\\rating4";
		string rating5 = "C:\\Users\\Default\\AppData\\Local\\cixx\\rating5";

		WebClient webClient = new WebClient();

		private DiscordRpc.EventHandlers handlers;
		private DiscordRpc.RichPresence presence;

		public Form1()
		{
			InitializeComponent();

			Directory.CreateDirectory("C:\\Users\\Default\\AppData\\Local\\cixx");

			//Discord RPC
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("947296555923279933", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("947296555923279933", ref this.handlers, true, null);
			this.presence.details = "============";
			this.presence.state = "Managing VALORANT";
			this.presence.largeImageKey = "valo";
			this.presence.smallImageKey = "cixx";
			this.presence.largeImageText = "ValorGuides";
			this.presence.smallImageText = "Made with <3 by cixx";
			DiscordRpc.UpdatePresence(ref this.presence);

			//Check for rating
			if (File.Exists(rating1))
			{
				bunifuRating1.Value = 1;
			}

			if (File.Exists(rating2))
			{
				bunifuRating1.Value = 2;
			}

			if (File.Exists(rating3))
			{
				bunifuRating1.Value = 3;
			}

			if (File.Exists(rating4))
			{
				bunifuRating1.Value = 4;
			}

			if (File.Exists(rating5))
			{
				bunifuRating1.Value = 5;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			wikiForm1.Show();
			settingsForm1.Hide();
		}

		private void bunifuButton4_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			wikiForm1.Show();
			settingsForm1.Hide();
		}

		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			wikiForm1.Hide();
			settingsForm1.Show();
		}

		//Rating System with Webhooks
		private async void bunifuRating1_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
		{
			//fixx cixx'ss shityy codee
			if (File.Exists(rating1) || File.Exists(rating2) || File.Exists(rating3) || File.Exists(rating4) || File.Exists(rating5))
			{
				return;
			}

			//Create WebhookObject
			var webobj = new WebhookObject();
			if (bunifuRating1.Value == 5)
			{
				webobj.AddEmbed(builder =>
				{
					builder.WithTitle("You've recieved a rating!")
						.WithDescription("A User has given your application a 5 Star rating!")
						.WithColor(Colors.Yellow);

				});
				await new Webhook("https://discord.com/api/webhooks/961459188901478410/HhAcRY57bv15cCo5mVSMt-nBKytUeG6A3vA4WBNvdf7y81LLuA4Y1QUZ3YD6jZukX0qe").SendAsync(webobj);
				bunifuRating1.ReadOnly = true;

				if (File.Exists(rating5))
				{
					webobj.AddEmbed(builder =>
					{
						builder.WithTitle("You've recieved a rating!")
							.WithDescription("A User has given your application a 5 Star rating!")
							.WithColor(Colors.Yellow);

					});
					await new Webhook("https://discord.com/api/webhooks/961459188901478410/HhAcRY57bv15cCo5mVSMt-nBKytUeG6A3vA4WBNvdf7y81LLuA4Y1QUZ3YD6jZukX0qe").SendAsync(webobj);
					bunifuRating1.Value = 5;

				}
				else if (!File.Exists(rating5))
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/961408572820967434/961470965932498974/rating5", rating5);
				}
			}
			else if (bunifuRating1.Value == 4)
			{
				webobj.AddEmbed(builder =>
				{
					builder.WithTitle("You've recieved a rating!")
						.WithDescription("A User has given your application a 4 Star rating!")
						.WithColor(Colors.Yellow);

				});
				await new Webhook("https://discord.com/api/webhooks/961459188901478410/HhAcRY57bv15cCo5mVSMt-nBKytUeG6A3vA4WBNvdf7y81LLuA4Y1QUZ3YD6jZukX0qe").SendAsync(webobj);
				bunifuRating1.ReadOnly = true;

				if (File.Exists(rating4))
				{
					bunifuRating1.Value = 4;
				}
				else if (!File.Exists(rating4))
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/961408572820967434/961470965798293554/rating4", rating4);
				}
			}
			else if (bunifuRating1.Value == 3)
			{
				webobj.AddEmbed(builder =>
				{
					builder.WithTitle("You've recieved a rating!")
						.WithDescription("A User has given your application a 3 Star rating!")
						.WithColor(Colors.Orange);

				});
				await new Webhook("https://discord.com/api/webhooks/961459188901478410/HhAcRY57bv15cCo5mVSMt-nBKytUeG6A3vA4WBNvdf7y81LLuA4Y1QUZ3YD6jZukX0qe").SendAsync(webobj);
				bunifuRating1.ReadOnly = true;

				if (File.Exists(rating3))
				{
					bunifuRating1.Value = 3;
				}
				else if (!File.Exists(rating3))
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/961408572820967434/961470965630513152/rating3", rating3);
				}
			}
			else if (bunifuRating1.Value == 2)
			{
				webobj.AddEmbed(builder =>
				{
					builder.WithTitle("You've recieved a rating!")
						.WithDescription("A User has given your application a 2 Star rating!")
						.WithColor(Colors.Red);

				});
				await new Webhook("https://discord.com/api/webhooks/961459188901478410/HhAcRY57bv15cCo5mVSMt-nBKytUeG6A3vA4WBNvdf7y81LLuA4Y1QUZ3YD6jZukX0qe").SendAsync(webobj);
				bunifuRating1.ReadOnly = true;

				if (File.Exists(rating2))
				{
					bunifuRating1.Value = 2;
				}
				else if (!File.Exists(rating2))
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/961408572820967434/961470965479510066/rating2", rating2);
				}
			}
			else if (bunifuRating1.Value == 1)
			{
				webobj.AddEmbed(builder =>
				{
					builder.WithTitle("You've recieved a rating!")
						.WithDescription("A User has given your application a 1 Star rating!")
						.WithColor(Colors.DarkRed);

				});
				await new Webhook("https://discord.com/api/webhooks/961459188901478410/HhAcRY57bv15cCo5mVSMt-nBKytUeG6A3vA4WBNvdf7y81LLuA4Y1QUZ3YD6jZukX0qe").SendAsync(webobj);
				bunifuRating1.ReadOnly = true;

				
				if (File.Exists(rating1))
				{
					bunifuRating1.Value = 1;
				}
				else if (!File.Exists(rating1))
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/961408572820967434/961465527698612294/rating1", rating1);
				}
			}

			

		}
	}
}
