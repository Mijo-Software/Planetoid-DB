using Krypton.Toolkit;

namespace Planetoid_DB
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
			this.labelStatusValue = new System.Windows.Forms.Label();
			this.labelDownload = new System.Windows.Forms.Label();
			this.buttonCancelDownload = new System.Windows.Forms.Button();
			this.buttonDownload = new System.Windows.Forms.Button();
			this.labelSourceValue = new System.Windows.Forms.Label();
			this.buttonCheckForUpdate = new System.Windows.Forms.Button();
			this.labelDateValue = new System.Windows.Forms.Label();
			this.labelSizeValue = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelStatusText = new System.Windows.Forms.Label();
			this.labelDateText = new System.Windows.Forms.Label();
			this.labelSourceText = new System.Windows.Forms.Label();
			this.labelSizeText = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBarDownload
			// 
			this.progressBarDownload.AccessibleDescription = "Show the progress of the download";
			this.progressBarDownload.AccessibleName = "Progress of the download";
			this.progressBarDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBarDownload.Location = new System.Drawing.Point(12, 73);
			this.progressBarDownload.Name = "progressBarDownload";
			this.progressBarDownload.Size = new System.Drawing.Size(408, 18);
			this.progressBarDownload.TabIndex = 1;
			this.toolTip.SetToolTip(this.progressBarDownload, "Show the progress of the download");
			this.progressBarDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBarDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelStatusValue
			// 
			this.labelStatusValue.AccessibleDescription = "Show the status of the download";
			this.labelStatusValue.AccessibleName = "Status of the download";
			this.labelStatusValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelStatusValue.AutoSize = true;
			this.labelStatusValue.BackColor = System.Drawing.Color.Transparent;
			this.labelStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStatusValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelStatusValue.Location = new System.Drawing.Point(55, 0);
			this.labelStatusValue.Name = "labelStatusValue";
			this.labelStatusValue.Size = new System.Drawing.Size(415, 15);
			this.labelStatusValue.TabIndex = 1;
			this.labelStatusValue.Text = "...";
			this.toolTip.SetToolTip(this.labelStatusValue, "Show the status of the download");
			this.labelStatusValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelStatusValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStatusValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelStatusValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStatusValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDownload
			// 
			this.labelDownload.AccessibleDescription = "Show the percent of the downloaded bytes";
			this.labelDownload.AccessibleName = "Download in percent";
			this.labelDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDownload.AutoSize = true;
			this.labelDownload.BackColor = System.Drawing.Color.Transparent;
			this.labelDownload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDownload.Location = new System.Drawing.Point(426, 76);
			this.labelDownload.Name = "labelDownload";
			this.labelDownload.Size = new System.Drawing.Size(38, 15);
			this.labelDownload.TabIndex = 2;
			this.labelDownload.Text = "xxx %";
			this.toolTip.SetToolTip(this.labelDownload, "Show the percent of the downloaded bytes");
			this.labelDownload.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDownload.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDownload.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCancelDownload
			// 
			this.buttonCancelDownload.AccessibleDescription = "Cancel the download";
			this.buttonCancelDownload.AccessibleName = "Cancel download";
			this.buttonCancelDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancelDownload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCancelDownload.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.buttonCancelDownload.Location = new System.Drawing.Point(333, 107);
			this.buttonCancelDownload.Name = "buttonCancelDownload";
			this.buttonCancelDownload.Size = new System.Drawing.Size(128, 36);
			this.buttonCancelDownload.TabIndex = 5;
			this.buttonCancelDownload.Text = "&Cancel download";
			this.buttonCancelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancelDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCancelDownload, "Cancel the download");
			this.buttonCancelDownload.UseVisualStyleBackColor = true;
			this.buttonCancelDownload.Click += new System.EventHandler(this.ButtonCancelDownload_Click);
			this.buttonCancelDownload.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelDownload.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCancelDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDownload
			// 
			this.buttonDownload.AccessibleDescription = "Download the database";
			this.buttonDownload.AccessibleName = "Download MPCORB.DAT";
			this.buttonDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDownload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonDownload.Image = global::Planetoid_DB.Properties.Resources.silk_package_go;
			this.buttonDownload.Location = new System.Drawing.Point(150, 107);
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.Size = new System.Drawing.Size(177, 36);
			this.buttonDownload.TabIndex = 4;
			this.buttonDownload.Text = "&Download MPCORB.DAT";
			this.buttonDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonDownload, "Download the database");
			this.buttonDownload.UseVisualStyleBackColor = true;
			this.buttonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
			this.buttonDownload.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownload.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSourceValue
			// 
			this.labelSourceValue.AccessibleDescription = "Show the download source";
			this.labelSourceValue.AccessibleName = "Source of the download";
			this.labelSourceValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSourceValue.AutoSize = true;
			this.labelSourceValue.BackColor = System.Drawing.Color.Transparent;
			this.labelSourceValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSourceValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSourceValue.Location = new System.Drawing.Point(55, 30);
			this.labelSourceValue.Name = "labelSourceValue";
			this.labelSourceValue.Size = new System.Drawing.Size(415, 15);
			this.labelSourceValue.TabIndex = 5;
			this.labelSourceValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSourceValue, "Show the download source");
			this.labelSourceValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSourceValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSourceValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCheckForUpdate
			// 
			this.buttonCheckForUpdate.AccessibleDescription = "Check for updates of the database";
			this.buttonCheckForUpdate.AccessibleName = "Check for update";
			this.buttonCheckForUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCheckForUpdate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCheckForUpdate.Image = global::Planetoid_DB.Properties.Resources.silk_lightning;
			this.buttonCheckForUpdate.Location = new System.Drawing.Point(12, 107);
			this.buttonCheckForUpdate.Name = "buttonCheckForUpdate";
			this.buttonCheckForUpdate.Size = new System.Drawing.Size(132, 36);
			this.buttonCheckForUpdate.TabIndex = 3;
			this.buttonCheckForUpdate.Text = "C&heck for update";
			this.buttonCheckForUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCheckForUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCheckForUpdate, "Check for updates of the database");
			this.buttonCheckForUpdate.UseVisualStyleBackColor = true;
			this.buttonCheckForUpdate.Click += new System.EventHandler(this.ButtonCheckForUpdate_Click);
			this.buttonCheckForUpdate.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCheckForUpdate.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCheckForUpdate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCheckForUpdate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateValue
			// 
			this.labelDateValue.AccessibleDescription = "Show the last modified date of the download file";
			this.labelDateValue.AccessibleName = "Date of the download file";
			this.labelDateValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateValue.AutoSize = true;
			this.labelDateValue.BackColor = System.Drawing.Color.Transparent;
			this.labelDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateValue.Location = new System.Drawing.Point(55, 15);
			this.labelDateValue.Name = "labelDateValue";
			this.labelDateValue.Size = new System.Drawing.Size(415, 15);
			this.labelDateValue.TabIndex = 3;
			this.labelDateValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateValue, "Show the last modified date of the download");
			this.labelDateValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSizeValue
			// 
			this.labelSizeValue.AccessibleDescription = "Show the file size of the download";
			this.labelSizeValue.AccessibleName = "Size of the dowload file";
			this.labelSizeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeValue.AutoSize = true;
			this.labelSizeValue.BackColor = System.Drawing.Color.Transparent;
			this.labelSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSizeValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSizeValue.Location = new System.Drawing.Point(55, 45);
			this.labelSizeValue.Name = "labelSizeValue";
			this.labelSizeValue.Size = new System.Drawing.Size(415, 22);
			this.labelSizeValue.TabIndex = 7;
			this.labelSizeValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSizeValue, "Show the file size of the download");
			this.labelSizeValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSizeValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSizeValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelStatusText
			// 
			this.labelStatusText.AccessibleDescription = "Status of the download";
			this.labelStatusText.AccessibleName = "Status";
			this.labelStatusText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelStatusText.AutoSize = true;
			this.labelStatusText.BackColor = System.Drawing.Color.Transparent;
			this.labelStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStatusText.Location = new System.Drawing.Point(3, 0);
			this.labelStatusText.Name = "labelStatusText";
			this.labelStatusText.Size = new System.Drawing.Size(46, 15);
			this.labelStatusText.TabIndex = 0;
			this.labelStatusText.Text = "Status:";
			this.toolTip.SetToolTip(this.labelStatusText, "Status");
			this.labelStatusText.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelStatusText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStatusText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelStatusText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStatusText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateText
			// 
			this.labelDateText.AccessibleDescription = "Date of the download file";
			this.labelDateText.AccessibleName = "Date";
			this.labelDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateText.AutoSize = true;
			this.labelDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelDateText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateText.Location = new System.Drawing.Point(3, 15);
			this.labelDateText.Name = "labelDateText";
			this.labelDateText.Size = new System.Drawing.Size(46, 15);
			this.labelDateText.TabIndex = 2;
			this.labelDateText.Text = "Date:";
			this.toolTip.SetToolTip(this.labelDateText, "Date");
			this.labelDateText.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSourceText
			// 
			this.labelSourceText.AccessibleDescription = "Show the download source";
			this.labelSourceText.AccessibleName = "Source";
			this.labelSourceText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSourceText.AutoSize = true;
			this.labelSourceText.BackColor = System.Drawing.Color.Transparent;
			this.labelSourceText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSourceText.Location = new System.Drawing.Point(3, 30);
			this.labelSourceText.Name = "labelSourceText";
			this.labelSourceText.Size = new System.Drawing.Size(46, 15);
			this.labelSourceText.TabIndex = 4;
			this.labelSourceText.Text = "Source:";
			this.toolTip.SetToolTip(this.labelSourceText, "Source");
			this.labelSourceText.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSourceText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSourceText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSizeText
			// 
			this.labelSizeText.AccessibleDescription = "Show the file size of the download";
			this.labelSizeText.AccessibleName = "Size";
			this.labelSizeText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeText.AutoSize = true;
			this.labelSizeText.BackColor = System.Drawing.Color.Transparent;
			this.labelSizeText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSizeText.Location = new System.Drawing.Point(3, 45);
			this.labelSizeText.Name = "labelSizeText";
			this.labelSizeText.Size = new System.Drawing.Size(46, 22);
			this.labelSizeText.TabIndex = 6;
			this.labelSizeText.Text = "Size:";
			this.toolTip.SetToolTip(this.labelSizeText, "Size");
			this.labelSizeText.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSizeText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSizeText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the data";
			this.tableLayoutPanel.AccessibleName = "Information";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.labelStatusText, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelSizeValue, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.labelSizeText, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.labelDateValue, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelSourceValue, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelDateText, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelSourceText, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelStatusValue, 1, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(473, 67);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.Controls.Add(this.kryptonStatusStrip);
			this.kryptonPanel.Controls.Add(this.tableLayoutPanel);
			this.kryptonPanel.Controls.Add(this.progressBarDownload);
			this.kryptonPanel.Controls.Add(this.labelDownload);
			this.kryptonPanel.Controls.Add(this.buttonCheckForUpdate);
			this.kryptonPanel.Controls.Add(this.buttonCancelDownload);
			this.kryptonPanel.Controls.Add(this.buttonDownload);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(473, 172);
			this.kryptonPanel.TabIndex = 0;
			this.kryptonPanel.TabStop = true;
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 150);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(473, 22);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 6;
			this.kryptonStatusStrip.Text = "status bar";
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Show some information";
			this.labelInformation.AccessibleName = "Show some information";
			this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelInformation.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(144, 17);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// DownloadUpdateForm
			// 
			this.AccessibleDescription = "Download the MPCORB.DAT";
			this.AccessibleName = "Download Dialog";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 172);
			this.Controls.Add(this.kryptonPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DownloadUpdateForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Download MPCORB.DAT";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadUpdateForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DownloadUpdateForm_FormClosed);
			this.Load += new System.EventHandler(this.DownloadUpdateForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonDownload;
    private System.Windows.Forms.ProgressBar progressBarDownload;
    private System.Windows.Forms.Label labelStatusValue;
    private System.Windows.Forms.Label labelDownload;
    private System.Windows.Forms.Button buttonCancelDownload;
    private System.Windows.Forms.Label labelSourceValue;
    private System.Windows.Forms.Button buttonCheckForUpdate;
    private System.Windows.Forms.Label labelDateValue;
    private System.Windows.Forms.Label labelSizeValue;
    private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label labelStatusText;
		private System.Windows.Forms.Label labelDateText;
		private System.Windows.Forms.Label labelSourceText;
		private System.Windows.Forms.Label labelSizeText;
		private KryptonTableLayoutPanel tableLayoutPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}