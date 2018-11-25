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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelHelp = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel.SuspendLayout();
			this.statusStrip.SuspendLayout();
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
			this.progressBarDownload.MouseEnter += new System.EventHandler(this.ProgressBarDownload_MouseEnter);
			this.progressBarDownload.MouseLeave += new System.EventHandler(this.ProgressBarDownload_MouseLeave);
			// 
			// labelStatusValue
			// 
			this.labelStatusValue.AccessibleDescription = "Show the status of the download";
			this.labelStatusValue.AccessibleName = "Status of the download";
			this.labelStatusValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelStatusValue.AutoSize = true;
			this.labelStatusValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelStatusValue.Location = new System.Drawing.Point(55, 0);
			this.labelStatusValue.Name = "labelStatusValue";
			this.labelStatusValue.Size = new System.Drawing.Size(16, 15);
			this.labelStatusValue.TabIndex = 1;
			this.labelStatusValue.Text = "...";
			this.toolTip.SetToolTip(this.labelStatusValue, "Show the status of the download");
			this.labelStatusValue.DoubleClick += new System.EventHandler(this.LabelStatusValue_DoubleClick);
			this.labelStatusValue.Enter += new System.EventHandler(this.LabelStatusValue_Enter);
			this.labelStatusValue.Leave += new System.EventHandler(this.LabelStatusValue_Leave);
			this.labelStatusValue.MouseEnter += new System.EventHandler(this.LabelStatusValue_Enter);
			this.labelStatusValue.MouseLeave += new System.EventHandler(this.LabelStatusValue_Leave);
			// 
			// labelDownload
			// 
			this.labelDownload.AccessibleDescription = "Show the percent of the downloaded bytes";
			this.labelDownload.AccessibleName = "Download in percent";
			this.labelDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDownload.AutoSize = true;
			this.labelDownload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDownload.Location = new System.Drawing.Point(426, 76);
			this.labelDownload.Name = "labelDownload";
			this.labelDownload.Size = new System.Drawing.Size(35, 15);
			this.labelDownload.TabIndex = 2;
			this.labelDownload.Text = "xxx %";
			this.toolTip.SetToolTip(this.labelDownload, "Show the percent of the downloaded bytes");
			this.labelDownload.Enter += new System.EventHandler(this.LabelDownload_Enter);
			this.labelDownload.Leave += new System.EventHandler(this.LabelDownload_Leave);
			this.labelDownload.MouseEnter += new System.EventHandler(this.LabelDownload_Enter);
			this.labelDownload.MouseLeave += new System.EventHandler(this.LabelDownload_Leave);
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
			this.buttonCancelDownload.Text = "Cancel download";
			this.buttonCancelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancelDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCancelDownload, "Cancel the download");
			this.buttonCancelDownload.UseVisualStyleBackColor = true;
			this.buttonCancelDownload.Click += new System.EventHandler(this.ButtonCancelDownload_Click);
			this.buttonCancelDownload.Enter += new System.EventHandler(this.ButtonCancelDownload_Enter);
			this.buttonCancelDownload.Leave += new System.EventHandler(this.ButtonCancelDownload_Leave);
			this.buttonCancelDownload.MouseEnter += new System.EventHandler(this.ButtonCancelDownload_Enter);
			this.buttonCancelDownload.MouseLeave += new System.EventHandler(this.ButtonCancelDownload_Leave);
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
			this.buttonDownload.Text = "Download MPCORB.DAT";
			this.buttonDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonDownload, "Download the database");
			this.buttonDownload.UseVisualStyleBackColor = true;
			this.buttonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
			this.buttonDownload.Enter += new System.EventHandler(this.ButtonDownload_Enter);
			this.buttonDownload.Leave += new System.EventHandler(this.ButtonDownload_Leave);
			this.buttonDownload.MouseEnter += new System.EventHandler(this.ButtonDownload_Enter);
			this.buttonDownload.MouseLeave += new System.EventHandler(this.ButtonDownload_Leave);
			// 
			// labelSourceValue
			// 
			this.labelSourceValue.AccessibleDescription = "Show the download source";
			this.labelSourceValue.AccessibleName = "Source of the download";
			this.labelSourceValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSourceValue.AutoSize = true;
			this.labelSourceValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSourceValue.Location = new System.Drawing.Point(55, 30);
			this.labelSourceValue.Name = "labelSourceValue";
			this.labelSourceValue.Size = new System.Drawing.Size(16, 15);
			this.labelSourceValue.TabIndex = 5;
			this.labelSourceValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSourceValue, "Show the download source");
			this.labelSourceValue.DoubleClick += new System.EventHandler(this.LabelSourceValue_DoubleClick);
			this.labelSourceValue.Enter += new System.EventHandler(this.LabelSourceValue_Enter);
			this.labelSourceValue.Leave += new System.EventHandler(this.LabelSourceValue_Leave);
			this.labelSourceValue.MouseEnter += new System.EventHandler(this.LabelSourceValue_Enter);
			this.labelSourceValue.MouseLeave += new System.EventHandler(this.LabelSourceValue_Leave);
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
			this.buttonCheckForUpdate.Text = "Check for update";
			this.buttonCheckForUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCheckForUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCheckForUpdate, "Check for updates of the database");
			this.buttonCheckForUpdate.UseVisualStyleBackColor = true;
			this.buttonCheckForUpdate.Click += new System.EventHandler(this.ButtonCheckForUpdate_Click);
			this.buttonCheckForUpdate.Enter += new System.EventHandler(this.ButtonCheckForUpdate_Enter);
			this.buttonCheckForUpdate.Leave += new System.EventHandler(this.ButtonCheckForUpdate_Leave);
			this.buttonCheckForUpdate.MouseEnter += new System.EventHandler(this.ButtonCheckForUpdate_Enter);
			this.buttonCheckForUpdate.MouseLeave += new System.EventHandler(this.ButtonCheckForUpdate_Leave);
			// 
			// labelDateValue
			// 
			this.labelDateValue.AccessibleDescription = "Show the last modified date of the download file";
			this.labelDateValue.AccessibleName = "Date of the download file";
			this.labelDateValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateValue.AutoSize = true;
			this.labelDateValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateValue.Location = new System.Drawing.Point(55, 15);
			this.labelDateValue.Name = "labelDateValue";
			this.labelDateValue.Size = new System.Drawing.Size(16, 15);
			this.labelDateValue.TabIndex = 3;
			this.labelDateValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateValue, "Show the last modified date of the download");
			this.labelDateValue.DoubleClick += new System.EventHandler(this.LabelDateValue_DoubleClick);
			this.labelDateValue.Enter += new System.EventHandler(this.LabelDateValue_Enter);
			this.labelDateValue.Leave += new System.EventHandler(this.LabelDateValue_Leave);
			this.labelDateValue.MouseEnter += new System.EventHandler(this.LabelDateValue_Enter);
			this.labelDateValue.MouseLeave += new System.EventHandler(this.LabelDateValue_Leave);
			// 
			// labelSizeValue
			// 
			this.labelSizeValue.AccessibleDescription = "Show the file size of the download";
			this.labelSizeValue.AccessibleName = "Size of the dowload file";
			this.labelSizeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeValue.AutoSize = true;
			this.labelSizeValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSizeValue.Location = new System.Drawing.Point(55, 45);
			this.labelSizeValue.Name = "labelSizeValue";
			this.labelSizeValue.Size = new System.Drawing.Size(16, 15);
			this.labelSizeValue.TabIndex = 7;
			this.labelSizeValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSizeValue, "Show the file size of the download");
			this.labelSizeValue.DoubleClick += new System.EventHandler(this.LabelSizeValue_DoubleClick);
			this.labelSizeValue.Enter += new System.EventHandler(this.LabelSizeValue_Enter);
			this.labelSizeValue.Leave += new System.EventHandler(this.LabelSizeValue_Leave);
			this.labelSizeValue.MouseEnter += new System.EventHandler(this.LabelSizeValue_Enter);
			this.labelSizeValue.MouseLeave += new System.EventHandler(this.LabelSizeValue_Leave);
			// 
			// labelStatusText
			// 
			this.labelStatusText.AccessibleDescription = "Status of the download";
			this.labelStatusText.AccessibleName = "Status";
			this.labelStatusText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelStatusText.AutoSize = true;
			this.labelStatusText.Location = new System.Drawing.Point(3, 0);
			this.labelStatusText.Name = "labelStatusText";
			this.labelStatusText.Size = new System.Drawing.Size(42, 15);
			this.labelStatusText.TabIndex = 0;
			this.labelStatusText.Text = "Status:";
			this.toolTip.SetToolTip(this.labelStatusText, "Status");
			this.labelStatusText.Enter += new System.EventHandler(this.LabelStatusText_Enter);
			this.labelStatusText.Leave += new System.EventHandler(this.LabelStatusText_Leave);
			this.labelStatusText.MouseEnter += new System.EventHandler(this.LabelStatusText_Enter);
			this.labelStatusText.MouseLeave += new System.EventHandler(this.LabelStatusText_Leave);
			// 
			// labelDateText
			// 
			this.labelDateText.AccessibleDescription = "Date of the download file";
			this.labelDateText.AccessibleName = "Date";
			this.labelDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateText.AutoSize = true;
			this.labelDateText.Location = new System.Drawing.Point(3, 15);
			this.labelDateText.Name = "labelDateText";
			this.labelDateText.Size = new System.Drawing.Size(34, 15);
			this.labelDateText.TabIndex = 2;
			this.labelDateText.Text = "Date:";
			this.toolTip.SetToolTip(this.labelDateText, "Date");
			this.labelDateText.Enter += new System.EventHandler(this.LabelDateText_Enter);
			this.labelDateText.Leave += new System.EventHandler(this.LabelDateText_Leave);
			this.labelDateText.MouseEnter += new System.EventHandler(this.LabelDateText_Enter);
			this.labelDateText.MouseLeave += new System.EventHandler(this.LabelDateText_Leave);
			// 
			// labelSourceText
			// 
			this.labelSourceText.AccessibleDescription = "Show the download source";
			this.labelSourceText.AccessibleName = "Source";
			this.labelSourceText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSourceText.AutoSize = true;
			this.labelSourceText.Location = new System.Drawing.Point(3, 30);
			this.labelSourceText.Name = "labelSourceText";
			this.labelSourceText.Size = new System.Drawing.Size(46, 15);
			this.labelSourceText.TabIndex = 4;
			this.labelSourceText.Text = "Source:";
			this.toolTip.SetToolTip(this.labelSourceText, "Source");
			this.labelSourceText.Enter += new System.EventHandler(this.LabelSourceText_Enter);
			this.labelSourceText.Leave += new System.EventHandler(this.LabelSourceText_Leave);
			this.labelSourceText.MouseEnter += new System.EventHandler(this.LabelSourceText_Enter);
			this.labelSourceText.MouseHover += new System.EventHandler(this.LabelSourceText_Leave);
			// 
			// labelSizeText
			// 
			this.labelSizeText.AccessibleDescription = "Show the file size of the download";
			this.labelSizeText.AccessibleName = "Size";
			this.labelSizeText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeText.AutoSize = true;
			this.labelSizeText.Location = new System.Drawing.Point(3, 45);
			this.labelSizeText.Name = "labelSizeText";
			this.labelSizeText.Size = new System.Drawing.Size(30, 15);
			this.labelSizeText.TabIndex = 6;
			this.labelSizeText.Text = "Size:";
			this.toolTip.SetToolTip(this.labelSizeText, "Size");
			this.labelSizeText.Enter += new System.EventHandler(this.LabelSizeText_Enter);
			this.labelSizeText.Leave += new System.EventHandler(this.LabelSizeText_Leave);
			this.labelSizeText.MouseEnter += new System.EventHandler(this.LabelSizeText_Enter);
			this.labelSizeText.MouseLeave += new System.EventHandler(this.LabelSizeText_Leave);
			// 
			// tableLayoutPanel
			// 
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
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelHelp});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 151);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(473, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 6;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelHelp
			// 
			this.labelHelp.AccessibleDescription = "Show some information";
			this.labelHelp.AccessibleName = "Show some information";
			this.labelHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelHelp.DoubleClickEnabled = true;
			this.labelHelp.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelHelp.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(116, 16);
			this.labelHelp.Text = "Show tooltip here";
			this.labelHelp.ToolTipText = "Show some information";
			// 
			// DownloadUpdateForm
			// 
			this.AccessibleDescription = "Download the MPCORB.DAT";
			this.AccessibleName = "Download Dialog";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 172);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.buttonCheckForUpdate);
			this.Controls.Add(this.buttonDownload);
			this.Controls.Add(this.buttonCancelDownload);
			this.Controls.Add(this.labelDownload);
			this.Controls.Add(this.progressBarDownload);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
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
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelHelp;
	}
}