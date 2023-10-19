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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
			this.progressBarSplash = new System.Windows.Forms.ProgressBar();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelDataLoading = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// progressBarSplash
			// 
			this.progressBarSplash.AccessibleDescription = "Loads the data";
			this.progressBarSplash.AccessibleName = "Progress Bar";
			this.progressBarSplash.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBarSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBarSplash.Location = new System.Drawing.Point(0, 294);
			this.progressBarSplash.Name = "progressBarSplash";
			this.progressBarSplash.Size = new System.Drawing.Size(487, 20);
			this.progressBarSplash.Step = 1;
			this.progressBarSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarSplash.TabIndex = 3;
			this.toolTip.SetToolTip(this.progressBarSplash, "Loads the data");
			// 
			// labelTitle
			// 
			this.labelTitle.AccessibleDescription = "Shows the applicatiopn name";
			this.labelTitle.AccessibleName = "Application name";
			this.labelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.AutoSize = true;
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
			this.labelTitle.ForeColor = System.Drawing.Color.LightCyan;
			this.labelTitle.Location = new System.Drawing.Point(266, 22);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(221, 45);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Planetoid-DB";
			this.toolTip.SetToolTip(this.labelTitle, "Application name");
			this.labelTitle.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			// 
			// labelVersion
			// 
			this.labelVersion.AccessibleDescription = "Shows the version number";
			this.labelVersion.AccessibleName = "Version";
			this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelVersion.BackColor = System.Drawing.Color.Transparent;
			this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelVersion.ForeColor = System.Drawing.Color.White;
			this.labelVersion.Location = new System.Drawing.Point(266, 67);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(221, 22);
			this.labelVersion.TabIndex = 1;
			this.labelVersion.Text = "Version: X.X.X.X";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelVersion, "Version number");
			this.labelVersion.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			// 
			// labelDataLoading
			// 
			this.labelDataLoading.AccessibleDescription = "Shows that data are loading";
			this.labelDataLoading.AccessibleName = "Loading text";
			this.labelDataLoading.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDataLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDataLoading.AutoSize = true;
			this.labelDataLoading.BackColor = System.Drawing.Color.Transparent;
			this.labelDataLoading.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDataLoading.ForeColor = System.Drawing.Color.White;
			this.labelDataLoading.Location = new System.Drawing.Point(10, 279);
			this.labelDataLoading.Name = "labelDataLoading";
			this.labelDataLoading.Size = new System.Drawing.Size(89, 15);
			this.labelDataLoading.TabIndex = 2;
			this.labelDataLoading.Text = "[ProcessAsText]";
			this.toolTip.SetToolTip(this.labelDataLoading, "Loading data");
			this.labelDataLoading.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			// 
			// SplashScreenForm
			// 
			this.AccessibleDescription = "Shows the splash screen and the loading progress of the data";
			this.AccessibleName = "splash screen";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(487, 314);
			this.Controls.Add(this.labelDataLoading);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.progressBarSplash);
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashScreenForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash Screen";
			this.toolTip.SetToolTip(this, "splash screen");
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SplashScreenForm_FormClosed);
			this.Load += new System.EventHandler(this.SplashScreenForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBarSplash;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelDataLoading;
		private System.Windows.Forms.ToolTip toolTip;
	}
}