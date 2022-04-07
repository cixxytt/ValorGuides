using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorGuides
{
	public partial class SettingsForm : UserControl
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{

		}

		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			siticoneNotificationPaint1.Text = "kys fag";
		}
	}
}
