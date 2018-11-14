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
        this.progressBarDownload = new System.Windows.Forms.ProgressBar();
        this.labelStatus = new System.Windows.Forms.Label();
        this.labelDownload = new System.Windows.Forms.Label();
        this.buttonClose = new System.Windows.Forms.Button();
        this.buttonCancelDownload = new System.Windows.Forms.Button();
        this.buttonDownload = new System.Windows.Forms.Button();
        this.labelSource = new System.Windows.Forms.Label();
        this.buttonCheckForUpdate = new System.Windows.Forms.Button();
        this.labelDate = new System.Windows.Forms.Label();
        this.labelSize = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // progressBarDownload
        // 
        this.progressBarDownload.Location = new System.Drawing.Point(15, 57);
        this.progressBarDownload.Name = "progressBarDownload";
        this.progressBarDownload.Size = new System.Drawing.Size(405, 21);
        this.progressBarDownload.TabIndex = 4;
        // 
        // labelStatus
        // 
        this.labelStatus.AutoSize = true;
        this.labelStatus.Location = new System.Drawing.Point(12, 9);
        this.labelStatus.Name = "labelStatus";
        this.labelStatus.Size = new System.Drawing.Size(96, 15);
        this.labelStatus.TabIndex = 0;
        this.labelStatus.Text = "Status: [Busy?...]";
        // 
        // labelDownload
        // 
        this.labelDownload.AutoSize = true;
        this.labelDownload.Location = new System.Drawing.Point(426, 63);
        this.labelDownload.Name = "labelDownload";
        this.labelDownload.Size = new System.Drawing.Size(37, 15);
        this.labelDownload.TabIndex = 5;
        this.labelDownload.Text = "xxx %";
        // 
        // buttonClose
        // 
        this.buttonClose.Image = global::PlanetoidDB.Properties.Resources.silk_application_put;
        this.buttonClose.Location = new System.Drawing.Point(374, 9);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new System.Drawing.Size(159, 41);
        this.buttonClose.TabIndex = 9;
        this.buttonClose.Text = "Close && Downloading in Background";
        this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Visible = false;
        this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
        // 
        // buttonCancelDownload
        // 
        this.buttonCancelDownload.Image = global::PlanetoidDB.Properties.Resources.silk_cancel;
        this.buttonCancelDownload.Location = new System.Drawing.Point(340, 84);
        this.buttonCancelDownload.Name = "buttonCancelDownload";
        this.buttonCancelDownload.Size = new System.Drawing.Size(139, 41);
        this.buttonCancelDownload.TabIndex = 8;
        this.buttonCancelDownload.Text = "Cancel Download";
        this.buttonCancelDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonCancelDownload.UseVisualStyleBackColor = true;
        this.buttonCancelDownload.Click += new System.EventHandler(this.buttonCancelDownload_Click);
        // 
        // buttonDownload
        // 
        this.buttonDownload.Image = global::PlanetoidDB.Properties.Resources.silk_package_go;
        this.buttonDownload.Location = new System.Drawing.Point(156, 84);
        this.buttonDownload.Name = "buttonDownload";
        this.buttonDownload.Size = new System.Drawing.Size(178, 41);
        this.buttonDownload.TabIndex = 7;
        this.buttonDownload.Text = "Download MPCORB.DAT";
        this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonDownload.UseVisualStyleBackColor = true;
        this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
        // 
        // labelSource
        // 
        this.labelSource.AutoSize = true;
        this.labelSource.Location = new System.Drawing.Point(153, 9);
        this.labelSource.Name = "labelSource";
        this.labelSource.Size = new System.Drawing.Size(165, 15);
        this.labelSource.TabIndex = 1;
        this.labelSource.Text = "Source: [where ist MPCORB?]";
        // 
        // buttonCheckForUpdate
        // 
        this.buttonCheckForUpdate.Image = global::PlanetoidDB.Properties.Resources.lightning;
        this.buttonCheckForUpdate.Location = new System.Drawing.Point(15, 84);
        this.buttonCheckForUpdate.Name = "buttonCheckForUpdate";
        this.buttonCheckForUpdate.Size = new System.Drawing.Size(135, 41);
        this.buttonCheckForUpdate.TabIndex = 6;
        this.buttonCheckForUpdate.Text = "Check for Update";
        this.buttonCheckForUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonCheckForUpdate.UseVisualStyleBackColor = true;
        this.buttonCheckForUpdate.Click += new System.EventHandler(this.buttonCheckForUpdate_Click);
        // 
        // labelDate
        // 
        this.labelDate.AutoSize = true;
        this.labelDate.Location = new System.Drawing.Point(153, 24);
        this.labelDate.Name = "labelDate";
        this.labelDate.Size = new System.Drawing.Size(159, 15);
        this.labelDate.TabIndex = 2;
        this.labelDate.Text = "date: [how old is MPCORB?]";
        // 
        // labelSize
        // 
        this.labelSize.AutoSize = true;
        this.labelSize.Location = new System.Drawing.Point(153, 39);
        this.labelSize.Name = "labelSize";
        this.labelSize.Size = new System.Drawing.Size(157, 15);
        this.labelSize.TabIndex = 3;
        this.labelSize.Text = "size: [is MPCORB a fat file?]";
        // 
        // DownloadUpdateForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(488, 139);
        this.Controls.Add(this.labelSize);
        this.Controls.Add(this.labelDate);
        this.Controls.Add(this.buttonCheckForUpdate);
        this.Controls.Add(this.labelSource);
        this.Controls.Add(this.buttonDownload);
        this.Controls.Add(this.buttonCancelDownload);
        this.Controls.Add(this.labelDownload);
        this.Controls.Add(this.buttonClose);
        this.Controls.Add(this.labelStatus);
        this.Controls.Add(this.progressBarDownload);
        this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "DownloadUpdateForm";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Download MPCORB";
        this.Load += new System.EventHandler(this.DownloadUpdateForm_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadUpdateForm_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonDownload;
    private System.Windows.Forms.ProgressBar progressBarDownload;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.Label labelDownload;
    private System.Windows.Forms.Button buttonCancelDownload;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Label labelSource;
    private System.Windows.Forms.Button buttonCheckForUpdate;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.Label labelSize;
  }
}