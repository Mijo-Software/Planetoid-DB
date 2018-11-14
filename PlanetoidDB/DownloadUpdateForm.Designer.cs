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
        this.SuspendLayout();
        // 
        // progressBarDownload
        // 
        this.progressBarDownload.Location = new System.Drawing.Point(12, 40);
        this.progressBarDownload.Name = "progressBarDownload";
        this.progressBarDownload.Size = new System.Drawing.Size(332, 21);
        this.progressBarDownload.TabIndex = 1;
        // 
        // labelStatus
        // 
        this.labelStatus.AutoSize = true;
        this.labelStatus.Location = new System.Drawing.Point(12, 9);
        this.labelStatus.Name = "labelStatus";
        this.labelStatus.Size = new System.Drawing.Size(196, 15);
        this.labelStatus.TabIndex = 2;
        this.labelStatus.Text = "Status: [Is Busy... | Downloading...]";
        // 
        // labelDownload
        // 
        this.labelDownload.AutoSize = true;
        this.labelDownload.Location = new System.Drawing.Point(350, 46);
        this.labelDownload.Name = "labelDownload";
        this.labelDownload.Size = new System.Drawing.Size(37, 15);
        this.labelDownload.TabIndex = 3;
        this.labelDownload.Text = "xxx %";
        // 
        // buttonClose
        // 
        this.buttonClose.Image = global::PlanetoidDB.Properties.Resources.silk_application_put;
        this.buttonClose.Location = new System.Drawing.Point(353, 80);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new System.Drawing.Size(159, 41);
        this.buttonClose.TabIndex = 5;
        this.buttonClose.Text = "Close && Downloading in Background";
        this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Visible = false;
        this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
        // 
        // buttonCancelDownload
        // 
        this.buttonCancelDownload.Image = global::PlanetoidDB.Properties.Resources.silk_cancel;
        this.buttonCancelDownload.Location = new System.Drawing.Point(205, 79);
        this.buttonCancelDownload.Name = "buttonCancelDownload";
        this.buttonCancelDownload.Size = new System.Drawing.Size(139, 41);
        this.buttonCancelDownload.TabIndex = 4;
        this.buttonCancelDownload.Text = "Cancel Download";
        this.buttonCancelDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonCancelDownload.UseVisualStyleBackColor = true;
        this.buttonCancelDownload.Click += new System.EventHandler(this.buttonCancelDownload_Click);
        // 
        // buttonDownload
        // 
        this.buttonDownload.Image = global::PlanetoidDB.Properties.Resources.silk_package_go;
        this.buttonDownload.Location = new System.Drawing.Point(12, 79);
        this.buttonDownload.Name = "buttonDownload";
        this.buttonDownload.Size = new System.Drawing.Size(178, 41);
        this.buttonDownload.TabIndex = 0;
        this.buttonDownload.Text = "Download MPCORB.DAT";
        this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonDownload.UseVisualStyleBackColor = true;
        this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
        // 
        // DownloadUpdateForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(402, 133);
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
  }
}