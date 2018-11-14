namespace PlanetoidDB
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
      this.progressBarSplash = new System.Windows.Forms.ProgressBar();
      this.labelTitle = new System.Windows.Forms.Label();
      this.labelVersion = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // progressBarSplash
      // 
      this.progressBarSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBarSplash.Location = new System.Drawing.Point(0, 339);
      this.progressBarSplash.Name = "progressBarSplash";
      this.progressBarSplash.Size = new System.Drawing.Size(516, 16);
      this.progressBarSplash.Step = 1;
      this.progressBarSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBarSplash.TabIndex = 0;
      // 
      // labelTitle
      // 
      this.labelTitle.AutoSize = true;
      this.labelTitle.BackColor = System.Drawing.Color.Transparent;
      this.labelTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.ForeColor = System.Drawing.Color.LightCyan;
      this.labelTitle.Location = new System.Drawing.Point(302, 56);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(182, 39);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "PlanetoidDB";
      // 
      // labelVersion
      // 
      this.labelVersion.BackColor = System.Drawing.Color.Transparent;
      this.labelVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelVersion.ForeColor = System.Drawing.Color.White;
      this.labelVersion.Location = new System.Drawing.Point(306, 95);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(178, 25);
      this.labelVersion.TabIndex = 2;
      this.labelVersion.Text = "Version: X.X.X.X";
      this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // SplashScreenForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(516, 355);
      this.Controls.Add(this.labelVersion);
      this.Controls.Add(this.labelTitle);
      this.Controls.Add(this.progressBarSplash);
      this.Cursor = System.Windows.Forms.Cursors.AppStarting;
      this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "SplashScreenForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SplashScreen";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.SplashScreenForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBarSplash;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelVersion;
  }
}