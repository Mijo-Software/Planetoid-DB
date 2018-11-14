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
      // SplashScreenForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(516, 355);
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

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBarSplash;
  }
}