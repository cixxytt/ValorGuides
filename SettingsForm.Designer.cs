
namespace ValorGuides
{
	partial class SettingsForm
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.siticoneDeviceInfo1 = new Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo(this.components);
			this.siticoneNotificationPaint1 = new Siticone.Desktop.UI.WinForms.SiticoneNotificationPaint(this.components);
			this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.SuspendLayout();
			// 
			// siticoneButton1
			// 
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
			this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.siticoneButton1.ForeColor = System.Drawing.Color.White;
			this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new System.Drawing.Point(278, 379);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
			this.siticoneButton1.TabIndex = 0;
			this.siticoneButton1.Text = "siticoneButton1";
			this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.siticoneButton1);
			this.Name = "SettingsForm";
			this.Size = new System.Drawing.Size(892, 708);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog1;
		private Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo siticoneDeviceInfo1;
		private Siticone.Desktop.UI.WinForms.SiticoneNotificationPaint siticoneNotificationPaint1;
		private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
	}
}
