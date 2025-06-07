using System.ComponentModel;
using Krypton.Toolkit;

namespace Planetoid_DB
{
  partial class SplashScreenForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
			progressBarSplash = new KryptonProgressBar();
			labelTitle = new Label();
			labelVersion = new Label();
			toolTip = new ToolTip(components);
			SuspendLayout();
			// 
			// progressBarSplash
			// 
			progressBarSplash.AccessibleDescription = "Loads the data";
			progressBarSplash.AccessibleName = "Progress Bar";
			progressBarSplash.AccessibleRole = AccessibleRole.ProgressBar;
			progressBarSplash.Dock = DockStyle.Bottom;
			progressBarSplash.Location = new Point(0, 294);
			progressBarSplash.Name = "progressBarSplash";
			progressBarSplash.Size = new Size(487, 20);
			progressBarSplash.Step = 1;
			progressBarSplash.TabIndex = 3;
			progressBarSplash.Text = "Loading data...";
			toolTip.SetToolTip(progressBarSplash, "Loads the data");
			progressBarSplash.Values.Text = "Loading data...";
			// 
			// labelTitle
			// 
			labelTitle.AccessibleDescription = "Shows the applicatiopn name";
			labelTitle.AccessibleName = "Application name";
			labelTitle.AccessibleRole = AccessibleRole.Text;
			labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			labelTitle.AutoSize = true;
			labelTitle.BackColor = Color.Transparent;
			labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
			labelTitle.ForeColor = Color.LightCyan;
			labelTitle.Location = new Point(266, 22);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(221, 45);
			labelTitle.TabIndex = 0;
			labelTitle.Text = "Planetoid-DB";
			toolTip.SetToolTip(labelTitle, "Application name");
			labelTitle.DoubleClick += CopyToClipboard_DoubleClick;
			// 
			// labelVersion
			// 
			labelVersion.AccessibleDescription = "Shows the version number";
			labelVersion.AccessibleName = "Version";
			labelVersion.AccessibleRole = AccessibleRole.Text;
			labelVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			labelVersion.BackColor = Color.Transparent;
			labelVersion.Font = new Font("Segoe UI", 8.5F);
			labelVersion.ForeColor = Color.White;
			labelVersion.Location = new Point(266, 67);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(221, 22);
			labelVersion.TabIndex = 1;
			labelVersion.Text = "Version: X.X.X.X";
			labelVersion.TextAlign = ContentAlignment.MiddleCenter;
			toolTip.SetToolTip(labelVersion, "Version number");
			labelVersion.DoubleClick += CopyToClipboard_DoubleClick;
			// 
			// SplashScreenForm
			// 
			AccessibleDescription = "Shows the splash screen and the loading progress of the data";
			AccessibleName = "splash screen";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(487, 314);
			CloseBox = false;
			Controls.Add(labelVersion);
			Controls.Add(labelTitle);
			Controls.Add(progressBarSplash);
			Cursor = Cursors.AppStarting;
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SplashScreenForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Splash Screen";
			toolTip.SetToolTip(this, "splash screen");
			TopMost = true;
			FormClosed += SplashScreenForm_FormClosed;
			Load += SplashScreenForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private KryptonProgressBar progressBarSplash;
    private Label labelTitle;
    private Label labelVersion;
		private ToolTip toolTip;
	}
}