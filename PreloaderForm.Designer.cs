﻿using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class PreloaderForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreloaderForm));
			toolTip = new ToolTip(components);
			kryptonCommandLinkButtonExit = new KryptonCommandLinkButton();
			kryptonCommandLinkButtonLoadInternalDemoData = new KryptonCommandLinkButton();
			kryptonCommandLinkButtonDownloadMprcorbDat = new KryptonCommandLinkButton();
			kryptonCommandLinkButtonOpenLocalFile = new KryptonCommandLinkButton();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			panel = new KryptonPanel();
			openFileDialog = new OpenFileDialog();
			statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// kryptonCommandLinkButtonExit
			// 
			kryptonCommandLinkButtonExit.AccessibleDescription = "Cancels und quits the application";
			kryptonCommandLinkButtonExit.AccessibleName = "Quit the application";
			kryptonCommandLinkButtonExit.AccessibleRole = AccessibleRole.PushButton;
			kryptonCommandLinkButtonExit.CommandLinkImageValues.Image = Properties.Resources.silk_door_in;
			kryptonCommandLinkButtonExit.CommandLinkTextValues.Description = "Cancel and quit the application";
			kryptonCommandLinkButtonExit.CommandLinkTextValues.DescriptionTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonExit.CommandLinkTextValues.DescriptionTextVAlignment = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonExit.CommandLinkTextValues.Heading = "Quit the application";
			kryptonCommandLinkButtonExit.CommandLinkTextValues.HeadingTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonExit.CommandLinkTextValues.HeadingTextVAlignment = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonExit.DialogResult = DialogResult.Cancel;
			kryptonCommandLinkButtonExit.Location = new Point(12, 210);
			kryptonCommandLinkButtonExit.Name = "kryptonCommandLinkButtonExit";
			kryptonCommandLinkButtonExit.OverrideFocus.Border.Draw = InheritBool.True;
			kryptonCommandLinkButtonExit.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
			kryptonCommandLinkButtonExit.OverrideFocus.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
			kryptonCommandLinkButtonExit.Size = new Size(350, 60);
			kryptonCommandLinkButtonExit.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonExit.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonExit.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonExit.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonExit.TabIndex = 3;
			toolTip.SetToolTip(kryptonCommandLinkButtonExit, "Quit the application");
			kryptonCommandLinkButtonExit.ToolTipValues.EnableToolTips = true;
			kryptonCommandLinkButtonExit.Enter += SetStatusbar_Enter;
			kryptonCommandLinkButtonExit.Leave += ClearStatusbar_Leave;
			kryptonCommandLinkButtonExit.MouseEnter += SetStatusbar_Enter;
			kryptonCommandLinkButtonExit.MouseLeave += ClearStatusbar_Leave;
			// 
			// kryptonCommandLinkButtonLoadInternalDemoData
			// 
			kryptonCommandLinkButtonLoadInternalDemoData.AccessibleDescription = "Loads internal demo data";
			kryptonCommandLinkButtonLoadInternalDemoData.AccessibleName = "Load internal demo data";
			kryptonCommandLinkButtonLoadInternalDemoData.AccessibleRole = AccessibleRole.PushButton;
			kryptonCommandLinkButtonLoadInternalDemoData.CommandLinkImageValues.Image = Properties.Resources.silk_database;
			kryptonCommandLinkButtonLoadInternalDemoData.CommandLinkTextValues.Description = "The internal demo data contains 10'000 minor planets";
			kryptonCommandLinkButtonLoadInternalDemoData.CommandLinkTextValues.DescriptionTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonLoadInternalDemoData.CommandLinkTextValues.DescriptionTextVAlignment = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonLoadInternalDemoData.CommandLinkTextValues.Heading = "Load internal demo data";
			kryptonCommandLinkButtonLoadInternalDemoData.CommandLinkTextValues.HeadingTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonLoadInternalDemoData.CommandLinkTextValues.HeadingTextVAlignment = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonLoadInternalDemoData.Location = new Point(12, 144);
			kryptonCommandLinkButtonLoadInternalDemoData.Name = "kryptonCommandLinkButtonLoadInternalDemoData";
			kryptonCommandLinkButtonLoadInternalDemoData.OverrideFocus.Border.Draw = InheritBool.True;
			kryptonCommandLinkButtonLoadInternalDemoData.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
			kryptonCommandLinkButtonLoadInternalDemoData.OverrideFocus.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
			kryptonCommandLinkButtonLoadInternalDemoData.Size = new Size(350, 60);
			kryptonCommandLinkButtonLoadInternalDemoData.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonLoadInternalDemoData.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonLoadInternalDemoData.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonLoadInternalDemoData.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonLoadInternalDemoData.TabIndex = 2;
			toolTip.SetToolTip(kryptonCommandLinkButtonLoadInternalDemoData, "Load internal demo data");
			kryptonCommandLinkButtonLoadInternalDemoData.Click += KryptonCommandLinkButtonLoadInternalDemoData_Click;
			kryptonCommandLinkButtonLoadInternalDemoData.Enter += SetStatusbar_Enter;
			kryptonCommandLinkButtonLoadInternalDemoData.Leave += ClearStatusbar_Leave;
			kryptonCommandLinkButtonLoadInternalDemoData.MouseEnter += SetStatusbar_Enter;
			kryptonCommandLinkButtonLoadInternalDemoData.MouseLeave += ClearStatusbar_Leave;
			// 
			// kryptonCommandLinkButtonDownloadMprcorbDat
			// 
			kryptonCommandLinkButtonDownloadMprcorbDat.AccessibleDescription = "Downloads MPCORB.DAT from the IAU Minor Planet Center";
			kryptonCommandLinkButtonDownloadMprcorbDat.AccessibleName = "Download MPCORB.DAT";
			kryptonCommandLinkButtonDownloadMprcorbDat.AccessibleRole = AccessibleRole.PushButton;
			kryptonCommandLinkButtonDownloadMprcorbDat.CommandLinkImageValues.Image = Properties.Resources.silk_world;
			kryptonCommandLinkButtonDownloadMprcorbDat.CommandLinkTextValues.Description = "Download MPCORB.DAT from the IAU Minor Planet Center";
			kryptonCommandLinkButtonDownloadMprcorbDat.CommandLinkTextValues.DescriptionTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonDownloadMprcorbDat.CommandLinkTextValues.DescriptionTextVAlignment = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonDownloadMprcorbDat.CommandLinkTextValues.Heading = "Download MPCORB.DAT";
			kryptonCommandLinkButtonDownloadMprcorbDat.CommandLinkTextValues.HeadingTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonDownloadMprcorbDat.CommandLinkTextValues.HeadingTextVAlignment = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonDownloadMprcorbDat.Location = new Point(12, 78);
			kryptonCommandLinkButtonDownloadMprcorbDat.Name = "kryptonCommandLinkButtonDownloadMprcorbDat";
			kryptonCommandLinkButtonDownloadMprcorbDat.OverrideFocus.Border.Draw = InheritBool.True;
			kryptonCommandLinkButtonDownloadMprcorbDat.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
			kryptonCommandLinkButtonDownloadMprcorbDat.OverrideFocus.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
			kryptonCommandLinkButtonDownloadMprcorbDat.Size = new Size(350, 60);
			kryptonCommandLinkButtonDownloadMprcorbDat.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonDownloadMprcorbDat.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonDownloadMprcorbDat.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonDownloadMprcorbDat.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonDownloadMprcorbDat.TabIndex = 1;
			toolTip.SetToolTip(kryptonCommandLinkButtonDownloadMprcorbDat, "Download MPCORB.DAT");
			kryptonCommandLinkButtonDownloadMprcorbDat.Click += KryptonCommandLinkButtonDownloadMprcorbDat_Click;
			kryptonCommandLinkButtonDownloadMprcorbDat.Enter += SetStatusbar_Enter;
			kryptonCommandLinkButtonDownloadMprcorbDat.Leave += ClearStatusbar_Leave;
			kryptonCommandLinkButtonDownloadMprcorbDat.MouseEnter += SetStatusbar_Enter;
			kryptonCommandLinkButtonDownloadMprcorbDat.MouseLeave += ClearStatusbar_Leave;
			// 
			// kryptonCommandLinkButtonOpenLocalFile
			// 
			kryptonCommandLinkButtonOpenLocalFile.AccessibleDescription = "Opens a local MPCORB.DAT file from hard drive";
			kryptonCommandLinkButtonOpenLocalFile.AccessibleName = "Open a local MPCORB.DAT file";
			kryptonCommandLinkButtonOpenLocalFile.AccessibleRole = AccessibleRole.PushButton;
			kryptonCommandLinkButtonOpenLocalFile.CommandLinkImageValues.Image = Properties.Resources.silk_folder;
			kryptonCommandLinkButtonOpenLocalFile.CommandLinkTextValues.Description = "Open a local MPCORB.DAT file from hard drive";
			kryptonCommandLinkButtonOpenLocalFile.CommandLinkTextValues.DescriptionTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonOpenLocalFile.CommandLinkTextValues.DescriptionTextVAlignment = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonOpenLocalFile.CommandLinkTextValues.Heading = "Open a local MPCORB.DAT file";
			kryptonCommandLinkButtonOpenLocalFile.CommandLinkTextValues.HeadingTextHAlignment = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonOpenLocalFile.CommandLinkTextValues.HeadingTextVAlignment = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonOpenLocalFile.Location = new Point(12, 12);
			kryptonCommandLinkButtonOpenLocalFile.Name = "kryptonCommandLinkButtonOpenLocalFile";
			kryptonCommandLinkButtonOpenLocalFile.OverrideFocus.Border.Draw = InheritBool.True;
			kryptonCommandLinkButtonOpenLocalFile.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
			kryptonCommandLinkButtonOpenLocalFile.OverrideFocus.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
			kryptonCommandLinkButtonOpenLocalFile.Size = new Size(350, 60);
			kryptonCommandLinkButtonOpenLocalFile.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonOpenLocalFile.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
			kryptonCommandLinkButtonOpenLocalFile.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
			kryptonCommandLinkButtonOpenLocalFile.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
			kryptonCommandLinkButtonOpenLocalFile.TabIndex = 0;
			toolTip.SetToolTip(kryptonCommandLinkButtonOpenLocalFile, "Open a local MPCORB.DAT file");
			kryptonCommandLinkButtonOpenLocalFile.Click += KryptonCommandLinkButtonOpenLocalFile_Click;
			kryptonCommandLinkButtonOpenLocalFile.Enter += SetStatusbar_Enter;
			kryptonCommandLinkButtonOpenLocalFile.Leave += ClearStatusbar_Leave;
			kryptonCommandLinkButtonOpenLocalFile.MouseEnter += SetStatusbar_Enter;
			kryptonCommandLinkButtonOpenLocalFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 278);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(376, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 1;
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
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(kryptonCommandLinkButtonExit);
			panel.Controls.Add(kryptonCommandLinkButtonLoadInternalDemoData);
			panel.Controls.Add(kryptonCommandLinkButtonDownloadMprcorbDat);
			panel.Controls.Add(kryptonCommandLinkButtonOpenLocalFile);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.PanelBackStyle = PaletteBackStyle.FormMain;
			panel.Size = new Size(376, 278);
			panel.TabIndex = 0;
			panel.TabStop = true;
			// 
			// openFileDialog
			// 
			openFileDialog.DefaultExt = "dat";
			openFileDialog.FileName = "mpcorb.dat";
			openFileDialog.Filter = "DAT files|*.dat|all files|*.*";
			openFileDialog.Title = "Open MPCORB.DAT";
			// 
			// PreloaderForm
			// 
			AccessibleDescription = "Handles of the file MPCORB.DAT ist missing";
			AccessibleName = "Preloader";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(376, 300);
			Controls.Add(panel);
			Controls.Add(statusStrip);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "PreloaderForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Planetoid-DB Preloader";
			toolTip.SetToolTip(this, "Preloader");
			FormClosed += PreloaderForm_FormClosed;
			Load += PreloaderForm_Load;
			KeyDown += PreloaderForm_KeyDown;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolTip toolTip;
		private KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private KryptonPanel panel;
		private KryptonCommandLinkButton kryptonCommandLinkButtonOpenLocalFile;
		private KryptonCommandLinkButton kryptonCommandLinkButtonExit;
		private KryptonCommandLinkButton kryptonCommandLinkButtonLoadInternalDemoData;
		private KryptonCommandLinkButton kryptonCommandLinkButtonDownloadMprcorbDat;
		private OpenFileDialog openFileDialog;
	}
}