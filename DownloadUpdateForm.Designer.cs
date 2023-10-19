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
			this.progressBarDownload = new Krypton.Toolkit.KryptonProgressBar();
			this.labelStatusValue = new Krypton.Toolkit.KryptonLabel();
			this.labelDownload = new Krypton.Toolkit.KryptonLabel();
			this.buttonCancelDownload = new Krypton.Toolkit.KryptonButton();
			this.buttonDownload = new Krypton.Toolkit.KryptonButton();
			this.labelSourceValue = new Krypton.Toolkit.KryptonLabel();
			this.buttonCheckForUpdate = new Krypton.Toolkit.KryptonButton();
			this.labelDateValue = new Krypton.Toolkit.KryptonLabel();
			this.labelSizeValue = new Krypton.Toolkit.KryptonLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelStatusText = new Krypton.Toolkit.KryptonLabel();
			this.labelDateText = new Krypton.Toolkit.KryptonLabel();
			this.labelSourceText = new Krypton.Toolkit.KryptonLabel();
			this.labelSizeText = new Krypton.Toolkit.KryptonLabel();
			this.tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBarDownload
			// 
			this.progressBarDownload.AccessibleDescription = "Shows the progress of the download";
			this.progressBarDownload.AccessibleName = "Progress of the download";
			this.progressBarDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBarDownload.Location = new System.Drawing.Point(12, 121);
			this.progressBarDownload.Name = "progressBarDownload";
			this.progressBarDownload.Size = new System.Drawing.Size(408, 18);
			this.progressBarDownload.TabIndex = 1;
			this.toolTip.SetToolTip(this.progressBarDownload, "Shows the progress of the download");
			this.progressBarDownload.UseKrypton = true;
			this.progressBarDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBarDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelStatusValue
			// 
			this.labelStatusValue.AccessibleDescription = "Shows the status of the download";
			this.labelStatusValue.AccessibleName = "Status of the download";
			this.labelStatusValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStatusValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelStatusValue.Location = new System.Drawing.Point(59, 3);
			this.labelStatusValue.Name = "labelStatusValue";
			this.labelStatusValue.Size = new System.Drawing.Size(411, 20);
			this.labelStatusValue.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelStatusValue, "Shows the status of the download");
			this.labelStatusValue.Values.Text = "...";
			this.labelStatusValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelStatusValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStatusValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelStatusValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStatusValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDownload
			// 
			this.labelDownload.AccessibleDescription = "Shows the percent of the downloaded bytes";
			this.labelDownload.AccessibleName = "Download in percent";
			this.labelDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDownload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDownload.Location = new System.Drawing.Point(426, 124);
			this.labelDownload.Name = "labelDownload";
			this.labelDownload.Size = new System.Drawing.Size(41, 20);
			this.labelDownload.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelDownload, "Shows the percent of the downloaded bytes");
			this.labelDownload.Values.Text = "xxx %";
			this.labelDownload.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDownload.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDownload.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCancelDownload
			// 
			this.buttonCancelDownload.AccessibleDescription = "Cancels the download";
			this.buttonCancelDownload.AccessibleName = "Cancel download";
			this.buttonCancelDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancelDownload.CornerRoundingRadius = -1F;
			this.buttonCancelDownload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCancelDownload.Location = new System.Drawing.Point(333, 155);
			this.buttonCancelDownload.Name = "buttonCancelDownload";
			this.buttonCancelDownload.Size = new System.Drawing.Size(128, 36);
			this.buttonCancelDownload.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonCancelDownload, "Cancel download");
			this.buttonCancelDownload.Values.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.buttonCancelDownload.Values.Text = "&Cancel download";
			this.buttonCancelDownload.Click += new System.EventHandler(this.ButtonCancelDownload_Click);
			this.buttonCancelDownload.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelDownload.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCancelDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDownload
			// 
			this.buttonDownload.AccessibleDescription = "Downloads the database";
			this.buttonDownload.AccessibleName = "Download MPCORB.DAT";
			this.buttonDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDownload.CornerRoundingRadius = -1F;
			this.buttonDownload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonDownload.Location = new System.Drawing.Point(150, 155);
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.Size = new System.Drawing.Size(177, 36);
			this.buttonDownload.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonDownload, "Download MPCORB.DAT");
			this.buttonDownload.Values.Image = global::Planetoid_DB.Properties.Resources.silk_package_go;
			this.buttonDownload.Values.Text = "&Download MPCORB.DAT";
			this.buttonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
			this.buttonDownload.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownload.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSourceValue
			// 
			this.labelSourceValue.AccessibleDescription = "Shows the download source";
			this.labelSourceValue.AccessibleName = "Source of the download";
			this.labelSourceValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSourceValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSourceValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSourceValue.Location = new System.Drawing.Point(59, 55);
			this.labelSourceValue.Name = "labelSourceValue";
			this.labelSourceValue.Size = new System.Drawing.Size(411, 20);
			this.labelSourceValue.TabIndex = 5;
			this.toolTip.SetToolTip(this.labelSourceValue, "Shows the download source");
			this.labelSourceValue.Values.Text = "...";
			this.labelSourceValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSourceValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSourceValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCheckForUpdate
			// 
			this.buttonCheckForUpdate.AccessibleDescription = "Checks updates of the database";
			this.buttonCheckForUpdate.AccessibleName = "Check updates";
			this.buttonCheckForUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCheckForUpdate.CornerRoundingRadius = -1F;
			this.buttonCheckForUpdate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCheckForUpdate.Location = new System.Drawing.Point(12, 155);
			this.buttonCheckForUpdate.Name = "buttonCheckForUpdate";
			this.buttonCheckForUpdate.Size = new System.Drawing.Size(132, 36);
			this.buttonCheckForUpdate.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonCheckForUpdate, "Check updates");
			this.buttonCheckForUpdate.Values.Image = global::Planetoid_DB.Properties.Resources.silk_lightning;
			this.buttonCheckForUpdate.Values.Text = "C&heck for update";
			this.buttonCheckForUpdate.Click += new System.EventHandler(this.ButtonCheckForUpdate_Click);
			this.buttonCheckForUpdate.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCheckForUpdate.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCheckForUpdate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCheckForUpdate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateValue
			// 
			this.labelDateValue.AccessibleDescription = "Shows the last modified date of the download file";
			this.labelDateValue.AccessibleName = "Date of the download file";
			this.labelDateValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateValue.Location = new System.Drawing.Point(59, 29);
			this.labelDateValue.Name = "labelDateValue";
			this.labelDateValue.Size = new System.Drawing.Size(411, 20);
			this.labelDateValue.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelDateValue, "Shows the last modified date of the download");
			this.labelDateValue.Values.Text = "...";
			this.labelDateValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSizeValue
			// 
			this.labelSizeValue.AccessibleDescription = "Shows the file size of the download";
			this.labelSizeValue.AccessibleName = "Size of the dowload file";
			this.labelSizeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSizeValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSizeValue.Location = new System.Drawing.Point(59, 81);
			this.labelSizeValue.Name = "labelSizeValue";
			this.labelSizeValue.Size = new System.Drawing.Size(411, 22);
			this.labelSizeValue.TabIndex = 7;
			this.toolTip.SetToolTip(this.labelSizeValue, "Shows the file size of the download");
			this.labelSizeValue.Values.Text = "...";
			this.labelSizeValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
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
			this.labelStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStatusText.Location = new System.Drawing.Point(3, 3);
			this.labelStatusText.Name = "labelStatusText";
			this.labelStatusText.Size = new System.Drawing.Size(50, 20);
			this.labelStatusText.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelStatusText, "Status");
			this.labelStatusText.Values.Text = "Status:";
			this.labelStatusText.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
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
			this.labelDateText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateText.Location = new System.Drawing.Point(3, 29);
			this.labelDateText.Name = "labelDateText";
			this.labelDateText.Size = new System.Drawing.Size(50, 20);
			this.labelDateText.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelDateText, "Date");
			this.labelDateText.Values.Text = "Date:";
			this.labelDateText.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSourceText
			// 
			this.labelSourceText.AccessibleDescription = "Shows the download source";
			this.labelSourceText.AccessibleName = "Source";
			this.labelSourceText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSourceText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSourceText.Location = new System.Drawing.Point(3, 55);
			this.labelSourceText.Name = "labelSourceText";
			this.labelSourceText.Size = new System.Drawing.Size(50, 20);
			this.labelSourceText.TabIndex = 4;
			this.toolTip.SetToolTip(this.labelSourceText, "Source");
			this.labelSourceText.Values.Text = "Source:";
			this.labelSourceText.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSourceText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSourceText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSourceText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSizeText
			// 
			this.labelSizeText.AccessibleDescription = "Shows the file size of the download";
			this.labelSizeText.AccessibleName = "Size";
			this.labelSizeText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSizeText.Location = new System.Drawing.Point(3, 81);
			this.labelSizeText.Name = "labelSizeText";
			this.labelSizeText.Size = new System.Drawing.Size(50, 22);
			this.labelSizeText.TabIndex = 6;
			this.toolTip.SetToolTip(this.labelSizeText, "Size");
			this.labelSizeText.Values.Text = "Size:";
			this.labelSizeText.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSizeText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSizeText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Groups the data";
			this.tableLayoutPanel.AccessibleName = "Information";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel.BackgroundImage")));
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
			this.tableLayoutPanel.Size = new System.Drawing.Size(473, 106);
			this.tableLayoutPanel.TabIndex = 0;
			this.toolTip.SetToolTip(this.tableLayoutPanel, "Groups the data");
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "pane";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.tableLayoutPanel);
			this.panel.Controls.Add(this.progressBarDownload);
			this.panel.Controls.Add(this.labelDownload);
			this.panel.Controls.Add(this.buttonCheckForUpdate);
			this.panel.Controls.Add(this.buttonCancelDownload);
			this.panel.Controls.Add(this.buttonDownload);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.panel.Size = new System.Drawing.Size(473, 216);
			this.panel.TabIndex = 0;
			this.panel.TabStop = true;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Showss some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 194);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(473, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 6;
			this.statusStrip.Text = "status bar";
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Shows some information";
			this.labelInformation.AccessibleName = "Shows some information";
			this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelInformation.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(144, 17);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Shows some information";
			// 
			// DownloadUpdateForm
			// 
			this.AccessibleDescription = "Downloads the MPCORB.DAT";
			this.AccessibleName = "Download MPCORB.DAT";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 216);
			this.Controls.Add(this.panel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DownloadUpdateForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Download MPCORB.DAT";
			this.toolTip.SetToolTip(this, "Download MPCORB.DAT");
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadUpdateForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DownloadUpdateForm_FormClosed);
			this.Load += new System.EventHandler(this.DownloadUpdateForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private KryptonButton buttonDownload;
    private KryptonLabel labelStatusValue;
    private KryptonLabel labelDownload;
    private KryptonButton buttonCancelDownload;
    private KryptonLabel labelSourceValue;
    private KryptonButton buttonCheckForUpdate;
    private KryptonLabel labelDateValue;
    private KryptonLabel labelSizeValue;
    private System.Windows.Forms.ToolTip toolTip;
		private KryptonLabel labelStatusText;
		private KryptonLabel labelDateText;
		private KryptonLabel labelSourceText;
		private KryptonLabel labelSizeText;
		private KryptonTableLayoutPanel tableLayoutPanel;
        private KryptonPanel panel;
		private KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private KryptonProgressBar progressBarDownload;
	}
}