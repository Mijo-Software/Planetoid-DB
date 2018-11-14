namespace PlanetoidDB
{
  partial class DownloadUpdateForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadUpdateForm));
      this.progressBarDownload = new System.Windows.Forms.ProgressBar();
      this.labelStatus = new System.Windows.Forms.Label();
      this.labelDownload = new System.Windows.Forms.Label();
      this.buttonCancelDownload = new System.Windows.Forms.Button();
      this.buttonDownload = new System.Windows.Forms.Button();
      this.labelSource = new System.Windows.Forms.Label();
      this.buttonCheckForUpdate = new System.Windows.Forms.Button();
      this.labelDate = new System.Windows.Forms.Label();
      this.labelSize = new System.Windows.Forms.Label();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // progressBarDownload
      // 
      this.progressBarDownload.AccessibleDescription = "Show the progress of the download";
      this.progressBarDownload.AccessibleName = "Progress of the download";
      this.progressBarDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
      this.progressBarDownload.Location = new System.Drawing.Point(12, 63);
      this.progressBarDownload.Name = "progressBarDownload";
      this.progressBarDownload.Size = new System.Drawing.Size(421, 21);
      this.progressBarDownload.TabIndex = 4;
      this.toolTip.SetToolTip(this.progressBarDownload, "Show the progress of the download");
      // 
      // labelStatus
      // 
      this.labelStatus.AccessibleDescription = "Show the status of the download";
      this.labelStatus.AccessibleName = "Status of the download";
      this.labelStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelStatus.AutoSize = true;
      this.labelStatus.Location = new System.Drawing.Point(9, 9);
      this.labelStatus.Name = "labelStatus";
      this.labelStatus.Size = new System.Drawing.Size(96, 15);
      this.labelStatus.TabIndex = 0;
      this.labelStatus.Text = "Status: [Busy?...]";
      this.toolTip.SetToolTip(this.labelStatus, "Show the status of the download");
      // 
      // labelDownload
      // 
      this.labelDownload.AccessibleDescription = "Show the percent of the downloaded bytes";
      this.labelDownload.AccessibleName = "Download in percent";
      this.labelDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelDownload.AutoSize = true;
      this.labelDownload.Location = new System.Drawing.Point(439, 69);
      this.labelDownload.Name = "labelDownload";
      this.labelDownload.Size = new System.Drawing.Size(37, 15);
      this.labelDownload.TabIndex = 5;
      this.labelDownload.Text = "xxx %";
      this.toolTip.SetToolTip(this.labelDownload, "Show the percent of the downloaded bytes");
      // 
      // buttonCancelDownload
      // 
      this.buttonCancelDownload.AccessibleDescription = "Cancel the download";
      this.buttonCancelDownload.AccessibleName = "Cancel download";
      this.buttonCancelDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonCancelDownload.Image = global::PlanetoidDB.Properties.Resources.silk_cancel;
      this.buttonCancelDownload.Location = new System.Drawing.Point(337, 90);
      this.buttonCancelDownload.Name = "buttonCancelDownload";
      this.buttonCancelDownload.Size = new System.Drawing.Size(139, 41);
      this.buttonCancelDownload.TabIndex = 8;
      this.buttonCancelDownload.Text = "Cancel download";
      this.buttonCancelDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTip.SetToolTip(this.buttonCancelDownload, "Cancel the download");
      this.buttonCancelDownload.UseVisualStyleBackColor = true;
      this.buttonCancelDownload.Click += new System.EventHandler(this.buttonCancelDownload_Click);
      // 
      // buttonDownload
      // 
      this.buttonDownload.AccessibleDescription = "Download the database";
      this.buttonDownload.AccessibleName = "Download MPCORB.DAT";
      this.buttonDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonDownload.Image = global::PlanetoidDB.Properties.Resources.silk_package_go;
      this.buttonDownload.Location = new System.Drawing.Point(153, 90);
      this.buttonDownload.Name = "buttonDownload";
      this.buttonDownload.Size = new System.Drawing.Size(178, 41);
      this.buttonDownload.TabIndex = 7;
      this.buttonDownload.Text = "Download MPCORB.DAT";
      this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTip.SetToolTip(this.buttonDownload, "Download the database");
      this.buttonDownload.UseVisualStyleBackColor = true;
      this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
      // 
      // labelSource
      // 
      this.labelSource.AccessibleDescription = "Show the download source";
      this.labelSource.AccessibleName = "Source of the download";
      this.labelSource.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelSource.AutoSize = true;
      this.labelSource.Location = new System.Drawing.Point(153, 9);
      this.labelSource.Name = "labelSource";
      this.labelSource.Size = new System.Drawing.Size(165, 15);
      this.labelSource.TabIndex = 1;
      this.labelSource.Text = "Source: [where ist MPCORB?]";
      this.toolTip.SetToolTip(this.labelSource, "Show the download source");
      // 
      // buttonCheckForUpdate
      // 
      this.buttonCheckForUpdate.AccessibleDescription = "Check for updates of the database";
      this.buttonCheckForUpdate.AccessibleName = "Check for update";
      this.buttonCheckForUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonCheckForUpdate.Image = global::PlanetoidDB.Properties.Resources.silk_lightning;
      this.buttonCheckForUpdate.Location = new System.Drawing.Point(12, 90);
      this.buttonCheckForUpdate.Name = "buttonCheckForUpdate";
      this.buttonCheckForUpdate.Size = new System.Drawing.Size(135, 41);
      this.buttonCheckForUpdate.TabIndex = 6;
      this.buttonCheckForUpdate.Text = "Check for update";
      this.buttonCheckForUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTip.SetToolTip(this.buttonCheckForUpdate, "Check for updates of the database");
      this.buttonCheckForUpdate.UseVisualStyleBackColor = true;
      this.buttonCheckForUpdate.Click += new System.EventHandler(this.buttonCheckForUpdate_Click);
      // 
      // labelDate
      // 
      this.labelDate.AccessibleDescription = "Show the last modified date of the download";
      this.labelDate.AccessibleName = "Date of the download";
      this.labelDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelDate.AutoSize = true;
      this.labelDate.Location = new System.Drawing.Point(153, 24);
      this.labelDate.Name = "labelDate";
      this.labelDate.Size = new System.Drawing.Size(159, 15);
      this.labelDate.TabIndex = 2;
      this.labelDate.Text = "date: [how old is MPCORB?]";
      this.toolTip.SetToolTip(this.labelDate, "Show the last modified date of the download");
      // 
      // labelSize
      // 
      this.labelSize.AccessibleDescription = "Show the file size of the download";
      this.labelSize.AccessibleName = "Size of the dowload";
      this.labelSize.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelSize.AutoSize = true;
      this.labelSize.Location = new System.Drawing.Point(153, 39);
      this.labelSize.Name = "labelSize";
      this.labelSize.Size = new System.Drawing.Size(157, 15);
      this.labelSize.TabIndex = 3;
      this.labelSize.Text = "size: [is MPCORB a fat file?]";
      this.toolTip.SetToolTip(this.labelSize, "Show the file size of the download");
      // 
      // DownloadUpdateForm
      // 
      this.AccessibleDescription = "Download the MPCORB.DAT";
      this.AccessibleName = "Download Dialog";
      this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(488, 144);
      this.Controls.Add(this.labelSize);
      this.Controls.Add(this.labelDate);
      this.Controls.Add(this.buttonCheckForUpdate);
      this.Controls.Add(this.labelSource);
      this.Controls.Add(this.buttonDownload);
      this.Controls.Add(this.buttonCancelDownload);
      this.Controls.Add(this.labelDownload);
      this.Controls.Add(this.labelStatus);
      this.Controls.Add(this.progressBarDownload);
      this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DownloadUpdateForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Download MPCORB.DAT";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadUpdateForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DownloadUpdateForm_FormClosed);
      this.Load += new System.EventHandler(this.DownloadUpdateForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonDownload;
    private System.Windows.Forms.ProgressBar progressBarDownload;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.Label labelDownload;
    private System.Windows.Forms.Button buttonCancelDownload;
    private System.Windows.Forms.Label labelSource;
    private System.Windows.Forms.Button buttonCheckForUpdate;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.Label labelSize;
    private System.Windows.Forms.ToolTip toolTip;
  }
}