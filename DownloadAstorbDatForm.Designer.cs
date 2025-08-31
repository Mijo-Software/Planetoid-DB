﻿using System.ComponentModel;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class DownloadAstorbDatForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(DownloadAstorbDatForm));
			progressBarDownload = new KryptonProgressBar();
			labelStatusValue = new KryptonLabel();
			labelDownload = new KryptonLabel();
			buttonCancelDownload = new KryptonButton();
			buttonDownload = new KryptonButton();
			labelSourceValue = new KryptonLabel();
			buttonCheckForUpdate = new KryptonButton();
			labelDateValue = new KryptonLabel();
			labelSizeValue = new KryptonLabel();
			toolTip = new ToolTip(components);
			labelStatusText = new KryptonLabel();
			labelDateText = new KryptonLabel();
			labelSourceText = new KryptonLabel();
			labelSizeText = new KryptonLabel();
			tableLayoutPanel = new KryptonTableLayoutPanel();
			panel = new KryptonPanel();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			kryptonManager = new KryptonManager(components);
			tableLayoutPanel.SuspendLayout();
			((ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// progressBarDownload
			// 
			progressBarDownload.AccessibleDescription = "Shows the progress of the download";
			progressBarDownload.AccessibleName = "Progress of the download";
			progressBarDownload.AccessibleRole = AccessibleRole.ProgressBar;
			progressBarDownload.Location = new Point(12, 121);
			progressBarDownload.Name = "progressBarDownload";
			progressBarDownload.Size = new Size(408, 18);
			progressBarDownload.TabIndex = 1;
			toolTip.SetToolTip(progressBarDownload, "Shows the progress of the download");
			progressBarDownload.Values.Text = "";
			progressBarDownload.MouseEnter += SetStatusBar_Enter;
			progressBarDownload.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelStatusValue
			// 
			labelStatusValue.AccessibleDescription = "Shows the status of the download";
			labelStatusValue.AccessibleName = "Status of the download";
			labelStatusValue.AccessibleRole = AccessibleRole.Text;
			labelStatusValue.Dock = DockStyle.Fill;
			labelStatusValue.Location = new Point(59, 3);
			labelStatusValue.Name = "labelStatusValue";
			labelStatusValue.Size = new Size(415, 20);
			labelStatusValue.TabIndex = 1;
			toolTip.SetToolTip(labelStatusValue, "Shows the status of the download");
			labelStatusValue.Values.Text = "...";
			labelStatusValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelStatusValue.Enter += SetStatusBar_Enter;
			labelStatusValue.Leave += ClearStatusBar_Leave;
			labelStatusValue.MouseEnter += SetStatusBar_Enter;
			labelStatusValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDownload
			// 
			labelDownload.AccessibleDescription = "Shows the percent of the downloaded bytes";
			labelDownload.AccessibleName = "Download in percent";
			labelDownload.AccessibleRole = AccessibleRole.Text;
			labelDownload.Location = new Point(426, 124);
			labelDownload.Name = "labelDownload";
			labelDownload.Size = new Size(41, 20);
			labelDownload.TabIndex = 2;
			toolTip.SetToolTip(labelDownload, "Shows the percent of the downloaded bytes");
			labelDownload.Values.Text = "xxx %";
			labelDownload.DoubleClick += CopyToClipboard_DoubleClick;
			labelDownload.Enter += SetStatusBar_Enter;
			labelDownload.Leave += ClearStatusBar_Leave;
			labelDownload.MouseEnter += SetStatusBar_Enter;
			labelDownload.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonCancelDownload
			// 
			buttonCancelDownload.AccessibleDescription = "Cancels the download";
			buttonCancelDownload.AccessibleName = "Cancel download";
			buttonCancelDownload.AccessibleRole = AccessibleRole.PushButton;
			buttonCancelDownload.Location = new Point(333, 155);
			buttonCancelDownload.Name = "buttonCancelDownload";
			buttonCancelDownload.Size = new Size(128, 36);
			buttonCancelDownload.TabIndex = 5;
			toolTip.SetToolTip(buttonCancelDownload, "Cancel download");
			buttonCancelDownload.Values.DropDownArrowColor = Color.Empty;
			buttonCancelDownload.Values.Image = Properties.Resources.silk_cancel;
			buttonCancelDownload.Values.Text = "&Cancel download";
			buttonCancelDownload.Click += ButtonCancelDownload_Click;
			buttonCancelDownload.Enter += SetStatusBar_Enter;
			buttonCancelDownload.Leave += ClearStatusBar_Leave;
			buttonCancelDownload.MouseEnter += SetStatusBar_Enter;
			buttonCancelDownload.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonDownload
			// 
			buttonDownload.AccessibleDescription = "Downloads the database ASTORB.DAT";
			buttonDownload.AccessibleName = "Download ASTORB.DAT";
			buttonDownload.AccessibleRole = AccessibleRole.PushButton;
			buttonDownload.Location = new Point(150, 155);
			buttonDownload.Name = "buttonDownload";
			buttonDownload.Size = new Size(177, 36);
			buttonDownload.TabIndex = 4;
			toolTip.SetToolTip(buttonDownload, "Download ASTORB.DAT");
			buttonDownload.Values.DropDownArrowColor = Color.Empty;
			buttonDownload.Values.Image = Properties.Resources.silk_package_go;
			buttonDownload.Values.Text = "&Download ASTORB.DAT";
			buttonDownload.Click += ButtonDownload_Click;
			buttonDownload.Enter += SetStatusBar_Enter;
			buttonDownload.Leave += ClearStatusBar_Leave;
			buttonDownload.MouseEnter += SetStatusBar_Enter;
			buttonDownload.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelSourceValue
			// 
			labelSourceValue.AccessibleDescription = "Shows the download source";
			labelSourceValue.AccessibleName = "Source of the download";
			labelSourceValue.AccessibleRole = AccessibleRole.Text;
			labelSourceValue.Dock = DockStyle.Fill;
			labelSourceValue.Location = new Point(59, 55);
			labelSourceValue.Name = "labelSourceValue";
			labelSourceValue.Size = new Size(415, 20);
			labelSourceValue.TabIndex = 5;
			toolTip.SetToolTip(labelSourceValue, "Shows the download source");
			labelSourceValue.Values.Text = "...";
			labelSourceValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelSourceValue.Enter += SetStatusBar_Enter;
			labelSourceValue.Leave += ClearStatusBar_Leave;
			labelSourceValue.MouseEnter += SetStatusBar_Enter;
			labelSourceValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonCheckForUpdate
			// 
			buttonCheckForUpdate.AccessibleDescription = "Checks updates of the database ASTORB.DAT";
			buttonCheckForUpdate.AccessibleName = "Check updates";
			buttonCheckForUpdate.AccessibleRole = AccessibleRole.PushButton;
			buttonCheckForUpdate.Location = new Point(12, 155);
			buttonCheckForUpdate.Name = "buttonCheckForUpdate";
			buttonCheckForUpdate.Size = new Size(132, 36);
			buttonCheckForUpdate.TabIndex = 3;
			toolTip.SetToolTip(buttonCheckForUpdate, "Check updates");
			buttonCheckForUpdate.Values.DropDownArrowColor = Color.Empty;
			buttonCheckForUpdate.Values.Image = Properties.Resources.silk_lightning;
			buttonCheckForUpdate.Values.Text = "C&heck for update";
			buttonCheckForUpdate.Click += ButtonCheckForUpdate_Click;
			buttonCheckForUpdate.Enter += SetStatusBar_Enter;
			buttonCheckForUpdate.Leave += ClearStatusBar_Leave;
			buttonCheckForUpdate.MouseEnter += SetStatusBar_Enter;
			buttonCheckForUpdate.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateValue
			// 
			labelDateValue.AccessibleDescription = "Shows the last modified date of the download file";
			labelDateValue.AccessibleName = "Date of the download file";
			labelDateValue.AccessibleRole = AccessibleRole.Text;
			labelDateValue.Dock = DockStyle.Fill;
			labelDateValue.Location = new Point(59, 29);
			labelDateValue.Name = "labelDateValue";
			labelDateValue.Size = new Size(415, 20);
			labelDateValue.TabIndex = 3;
			toolTip.SetToolTip(labelDateValue, "Shows the last modified date of the download");
			labelDateValue.Values.Text = "...";
			labelDateValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateValue.Enter += SetStatusBar_Enter;
			labelDateValue.Leave += ClearStatusBar_Leave;
			labelDateValue.MouseEnter += SetStatusBar_Enter;
			labelDateValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelSizeValue
			// 
			labelSizeValue.AccessibleDescription = "Shows the file size of the download";
			labelSizeValue.AccessibleName = "Size of the dowload file";
			labelSizeValue.AccessibleRole = AccessibleRole.Text;
			labelSizeValue.Dock = DockStyle.Fill;
			labelSizeValue.Location = new Point(59, 81);
			labelSizeValue.Name = "labelSizeValue";
			labelSizeValue.Size = new Size(415, 22);
			labelSizeValue.TabIndex = 7;
			toolTip.SetToolTip(labelSizeValue, "Shows the file size of the download");
			labelSizeValue.Values.Text = "...";
			labelSizeValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelSizeValue.Enter += SetStatusBar_Enter;
			labelSizeValue.Leave += ClearStatusBar_Leave;
			labelSizeValue.MouseEnter += SetStatusBar_Enter;
			labelSizeValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelStatusText
			// 
			labelStatusText.AccessibleDescription = "Status of the download";
			labelStatusText.AccessibleName = "Status";
			labelStatusText.AccessibleRole = AccessibleRole.Text;
			labelStatusText.Dock = DockStyle.Fill;
			labelStatusText.Location = new Point(3, 3);
			labelStatusText.Name = "labelStatusText";
			labelStatusText.Size = new Size(50, 20);
			labelStatusText.TabIndex = 0;
			toolTip.SetToolTip(labelStatusText, "Status");
			labelStatusText.Values.Text = "Status:";
			labelStatusText.DoubleClick += CopyToClipboard_DoubleClick;
			labelStatusText.Enter += SetStatusBar_Enter;
			labelStatusText.Leave += ClearStatusBar_Leave;
			labelStatusText.MouseEnter += SetStatusBar_Enter;
			labelStatusText.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateText
			// 
			labelDateText.AccessibleDescription = "Date of the download file";
			labelDateText.AccessibleName = "Date";
			labelDateText.AccessibleRole = AccessibleRole.Text;
			labelDateText.Dock = DockStyle.Fill;
			labelDateText.Location = new Point(3, 29);
			labelDateText.Name = "labelDateText";
			labelDateText.Size = new Size(50, 20);
			labelDateText.TabIndex = 2;
			toolTip.SetToolTip(labelDateText, "Date");
			labelDateText.Values.Text = "Date:";
			labelDateText.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateText.Enter += SetStatusBar_Enter;
			labelDateText.Leave += ClearStatusBar_Leave;
			labelDateText.MouseEnter += SetStatusBar_Enter;
			labelDateText.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelSourceText
			// 
			labelSourceText.AccessibleDescription = "Shows the download source";
			labelSourceText.AccessibleName = "Source";
			labelSourceText.AccessibleRole = AccessibleRole.Text;
			labelSourceText.Dock = DockStyle.Fill;
			labelSourceText.Location = new Point(3, 55);
			labelSourceText.Name = "labelSourceText";
			labelSourceText.Size = new Size(50, 20);
			labelSourceText.TabIndex = 4;
			toolTip.SetToolTip(labelSourceText, "Source");
			labelSourceText.Values.Text = "Source:";
			labelSourceText.DoubleClick += CopyToClipboard_DoubleClick;
			labelSourceText.Enter += SetStatusBar_Enter;
			labelSourceText.Leave += ClearStatusBar_Leave;
			labelSourceText.MouseEnter += SetStatusBar_Enter;
			labelSourceText.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelSizeText
			// 
			labelSizeText.AccessibleDescription = "Shows the file size of the download";
			labelSizeText.AccessibleName = "Size";
			labelSizeText.AccessibleRole = AccessibleRole.Text;
			labelSizeText.Dock = DockStyle.Fill;
			labelSizeText.Location = new Point(3, 81);
			labelSizeText.Name = "labelSizeText";
			labelSizeText.Size = new Size(50, 22);
			labelSizeText.TabIndex = 6;
			toolTip.SetToolTip(labelSizeText, "Size");
			labelSizeText.Values.Text = "Size:";
			labelSizeText.DoubleClick += CopyToClipboard_DoubleClick;
			labelSizeText.Enter += SetStatusBar_Enter;
			labelSizeText.Leave += ClearStatusBar_Leave;
			labelSizeText.MouseEnter += SetStatusBar_Enter;
			labelSizeText.MouseLeave += ClearStatusBar_Leave;
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Groups the data";
			tableLayoutPanel.AccessibleName = "Information";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanel.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel.BackgroundImage");
			tableLayoutPanel.BackgroundImageLayout = ImageLayout.None;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.Controls.Add(labelStatusText, 0, 0);
			tableLayoutPanel.Controls.Add(labelSizeValue, 1, 3);
			tableLayoutPanel.Controls.Add(labelSizeText, 0, 3);
			tableLayoutPanel.Controls.Add(labelDateValue, 1, 1);
			tableLayoutPanel.Controls.Add(labelSourceValue, 1, 2);
			tableLayoutPanel.Controls.Add(labelDateText, 0, 1);
			tableLayoutPanel.Controls.Add(labelSourceText, 0, 2);
			tableLayoutPanel.Controls.Add(labelStatusValue, 1, 0);
			tableLayoutPanel.Dock = DockStyle.Top;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 4;
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.Size = new Size(477, 106);
			tableLayoutPanel.TabIndex = 0;
			toolTip.SetToolTip(tableLayoutPanel, "Groups the data");
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(tableLayoutPanel);
			panel.Controls.Add(progressBarDownload);
			panel.Controls.Add(labelDownload);
			panel.Controls.Add(buttonCheckForUpdate);
			panel.Controls.Add(buttonCancelDownload);
			panel.Controls.Add(buttonDownload);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.PanelBackStyle = PaletteBackStyle.FormMain;
			panel.Size = new Size(477, 174);
			panel.TabIndex = 0;
			panel.TabStop = true;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Showss some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(477, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 6;
			statusStrip.Text = "status bar";
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Shows some information";
			labelInformation.AccessibleName = "Shows some information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Image = Properties.Resources.silk_lightbulb;
			labelInformation.Margin = new Padding(5, 3, 0, 2);
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(144, 17);
			labelInformation.Text = "some information here";
			labelInformation.ToolTipText = "Shows some information";
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(panel);
			toolStripContainer.ContentPanel.Size = new Size(477, 174);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(477, 221);
			toolStripContainer.TabIndex = 1;
			// 
			// kryptonManager
			// 
			kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
			// 
			// DownloadAstorbDatForm
			// 
			AccessibleDescription = "Downloads the ASTORB.DAT";
			AccessibleName = "Download ASTORB.DAT";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(477, 221);
			Controls.Add(toolStripContainer);
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DownloadAstorbDatForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Download ASTORB.DAT";
			toolTip.SetToolTip(this, "Download ASTORB.DAT");
			FormClosing += DownloadAstorbDatForm_FormClosing;
			FormClosed += DownloadAstorbDatForm_FormClosed;
			Load += DownloadAstorbDatForm_Load;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			((ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);
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
		private ToolTip toolTip;
		private KryptonLabel labelStatusText;
		private KryptonLabel labelDateText;
		private KryptonLabel labelSourceText;
		private KryptonLabel labelSizeText;
		private KryptonTableLayoutPanel tableLayoutPanel;
		private KryptonPanel panel;
		private KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private KryptonProgressBar progressBarDownload;
		private ToolStripContainer toolStripContainer;
		private KryptonManager kryptonManager;
	}
}