namespace Planetoid_DB
{
  partial class SplashScreenForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
			progressBarSplash = new ProgressBar();
			labelTitle = new Label();
			labelVersion = new Label();
			labelDataLoading = new Label();
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
			progressBarSplash.Style = ProgressBarStyle.Continuous;
			progressBarSplash.TabIndex = 3;
			toolTip.SetToolTip(progressBarSplash, "Loads the data");
			// 
			// labelTitle
			// 
			labelTitle.AccessibleDescription = "Shows the applicatiopn name";
			labelTitle.AccessibleName = "Application name";
			labelTitle.AccessibleRole = AccessibleRole.Text;
			labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			labelTitle.AutoSize = true;
			labelTitle.BackColor = Color.Transparent;
			labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
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
			labelVersion.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
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
			// labelDataLoading
			// 
			labelDataLoading.AccessibleDescription = "Shows that data are loading";
			labelDataLoading.AccessibleName = "Loading text";
			labelDataLoading.AccessibleRole = AccessibleRole.Text;
			labelDataLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelDataLoading.AutoSize = true;
			labelDataLoading.BackColor = Color.Transparent;
			labelDataLoading.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			labelDataLoading.ForeColor = Color.White;
			labelDataLoading.Location = new Point(10, 279);
			labelDataLoading.Name = "labelDataLoading";
			labelDataLoading.Size = new Size(89, 15);
			labelDataLoading.TabIndex = 2;
			labelDataLoading.Text = "[ProcessAsText]";
			toolTip.SetToolTip(labelDataLoading, "Loading data");
			labelDataLoading.DoubleClick += CopyToClipboard_DoubleClick;
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
			Controls.Add(labelDataLoading);
			Controls.Add(labelVersion);
			Controls.Add(labelTitle);
			Controls.Add(progressBarSplash);
			Cursor = Cursors.AppStarting;
			Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
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

		private System.Windows.Forms.ProgressBar progressBarSplash;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelDataLoading;
		private System.Windows.Forms.ToolTip toolTip;
	}
}