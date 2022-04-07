using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.IO;
using DiscordRPC;
using DiscordRpcDemo;

namespace ValorGuides
{
	public partial class Form1 : Form
	{

		private DiscordRpc.EventHandlers handlers;
		private DiscordRpc.RichPresence presence;

		public Form1()
		{


			InitializeComponent();

			

			//Discord RPC
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("947296555923279933", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("947296555923279933", ref this.handlers, true, null);
			this.presence.details = "============";
			this.presence.state = "Managing VALORANT";
			this.presence.largeImageKey = "valo";
			this.presence.smallImageKey = "cixx";
			this.presence.largeImageText = "BONEWORKS Mod Loader";
			this.presence.smallImageText = "Made with <3 by cixx";
			DiscordRpc.UpdatePresence(ref this.presence);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
