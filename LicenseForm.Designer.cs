﻿using System.ComponentModel;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class LicenseForm
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(LicenseForm));
			panel = new KryptonPanel();
			kryptonButtonCopyLicenseToClipboard = new KryptonButton();
			kryptonButtonSaveLicense = new KryptonButton();
			kryptonButtonClose = new KryptonButton();
			kryptonPictureBoxLicenseLogo = new KryptonPictureBox();
			kryptonTextBoxLicense = new KryptonTextBox();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolTip = new ToolTip(components);
			saveFileDialog = new SaveFileDialog();
			kryptonManager = new KryptonManager(components);
			((ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			((ISupportInitialize)kryptonPictureBoxLicenseLogo).BeginInit();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(kryptonButtonCopyLicenseToClipboard);
			panel.Controls.Add(kryptonButtonSaveLicense);
			panel.Controls.Add(kryptonButtonClose);
			panel.Controls.Add(kryptonPictureBoxLicenseLogo);
			panel.Controls.Add(kryptonTextBoxLicense);
			panel.Controls.Add(statusStrip);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.PanelBackStyle = PaletteBackStyle.FormMain;
			panel.Size = new Size(577, 225);
			panel.TabIndex = 0;
			// 
			// kryptonButtonCopyLicenseToClipboard
			// 
			kryptonButtonCopyLicenseToClipboard.AccessibleDescription = "Copys the license to the clipboard";
			kryptonButtonCopyLicenseToClipboard.AccessibleName = "Copy the license to the clipboard";
			kryptonButtonCopyLicenseToClipboard.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonCopyLicenseToClipboard.Location = new Point(438, 105);
			kryptonButtonCopyLicenseToClipboard.Name = "kryptonButtonCopyLicenseToClipboard";
			kryptonButtonCopyLicenseToClipboard.Size = new Size(127, 25);
			kryptonButtonCopyLicenseToClipboard.TabIndex = 1;
			toolTip.SetToolTip(kryptonButtonCopyLicenseToClipboard, "Copy the license to the clipboard");
			kryptonButtonCopyLicenseToClipboard.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonCopyLicenseToClipboard.Values.Image = Properties.Resources.silk_clipboard;
			kryptonButtonCopyLicenseToClipboard.Values.Text = "&Copy to clipboard";
			kryptonButtonCopyLicenseToClipboard.Click += KryptonButtonCopyLicenseToClipboard_Click;
			kryptonButtonCopyLicenseToClipboard.Enter += SetStatusBar_Enter;
			kryptonButtonCopyLicenseToClipboard.Leave += ClearStatusBar_Leave;
			kryptonButtonCopyLicenseToClipboard.MouseEnter += SetStatusBar_Enter;
			kryptonButtonCopyLicenseToClipboard.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonSaveLicense
			// 
			kryptonButtonSaveLicense.AccessibleDescription = "Saves the license to the hard drive";
			kryptonButtonSaveLicense.AccessibleName = "Save the license";
			kryptonButtonSaveLicense.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonSaveLicense.Location = new Point(439, 136);
			kryptonButtonSaveLicense.Name = "kryptonButtonSaveLicense";
			kryptonButtonSaveLicense.Size = new Size(127, 25);
			kryptonButtonSaveLicense.TabIndex = 2;
			toolTip.SetToolTip(kryptonButtonSaveLicense, "Save the license");
			kryptonButtonSaveLicense.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonSaveLicense.Values.Image = Properties.Resources.silk_disk;
			kryptonButtonSaveLicense.Values.Text = "&Save license";
			kryptonButtonSaveLicense.Click += KryptonButtonSaveLicense_Click;
			kryptonButtonSaveLicense.Enter += SetStatusBar_Enter;
			kryptonButtonSaveLicense.Leave += ClearStatusBar_Leave;
			kryptonButtonSaveLicense.MouseEnter += SetStatusBar_Enter;
			kryptonButtonSaveLicense.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonButtonClose
			// 
			kryptonButtonClose.AccessibleDescription = "Closes the form";
			kryptonButtonClose.AccessibleName = "Close the form";
			kryptonButtonClose.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonClose.DialogResult = DialogResult.Cancel;
			kryptonButtonClose.Location = new Point(439, 167);
			kryptonButtonClose.Name = "kryptonButtonClose";
			kryptonButtonClose.Size = new Size(127, 25);
			kryptonButtonClose.TabIndex = 3;
			toolTip.SetToolTip(kryptonButtonClose, "Close");
			kryptonButtonClose.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonClose.Values.Image = Properties.Resources.silk_cancel;
			kryptonButtonClose.Values.Text = "C&lose";
			kryptonButtonClose.Enter += SetStatusBar_Enter;
			kryptonButtonClose.Leave += ClearStatusBar_Leave;
			kryptonButtonClose.MouseEnter += SetStatusBar_Enter;
			kryptonButtonClose.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonPictureBoxLicenseLogo
			// 
			kryptonPictureBoxLicenseLogo.AccessibleDescription = "Shows the logo of the license";
			kryptonPictureBoxLicenseLogo.AccessibleName = "GPL Logo";
			kryptonPictureBoxLicenseLogo.AccessibleRole = AccessibleRole.Graphic;
			kryptonPictureBoxLicenseLogo.Image = (Image)resources.GetObject("kryptonPictureBoxLicenseLogo.Image");
			kryptonPictureBoxLicenseLogo.Location = new Point(439, 12);
			kryptonPictureBoxLicenseLogo.Name = "kryptonPictureBoxLicenseLogo";
			kryptonPictureBoxLicenseLogo.Size = new Size(127, 71);
			kryptonPictureBoxLicenseLogo.SizeMode = PictureBoxSizeMode.Zoom;
			kryptonPictureBoxLicenseLogo.TabIndex = 8;
			kryptonPictureBoxLicenseLogo.TabStop = false;
			toolTip.SetToolTip(kryptonPictureBoxLicenseLogo, "GPL v3 Logo");
			kryptonPictureBoxLicenseLogo.MouseEnter += SetStatusBar_Enter;
			kryptonPictureBoxLicenseLogo.MouseLeave += ClearStatusBar_Leave;
			// 
			// kryptonTextBoxLicense
			// 
			kryptonTextBoxLicense.AccessibleDescription = "Show the license";
			kryptonTextBoxLicense.AccessibleName = "License";
			kryptonTextBoxLicense.AccessibleRole = AccessibleRole.Text;
			kryptonTextBoxLicense.InputControlStyle = InputControlStyle.PanelAlternate;
			kryptonTextBoxLicense.Location = new Point(12, 12);
			kryptonTextBoxLicense.Multiline = true;
			kryptonTextBoxLicense.Name = "kryptonTextBoxLicense";
			kryptonTextBoxLicense.ReadOnly = true;
			kryptonTextBoxLicense.ScrollBars = ScrollBars.Both;
			kryptonTextBoxLicense.Size = new Size(421, 180);
			kryptonTextBoxLicense.TabIndex = 0;
			kryptonTextBoxLicense.TabStop = false;
			kryptonTextBoxLicense.Text = resources.GetString("kryptonTextBoxLicense.Text");
			toolTip.SetToolTip(kryptonTextBoxLicense, "License");
			kryptonTextBoxLicense.Enter += SetStatusBar_Enter;
			kryptonTextBoxLicense.Leave += ClearStatusBar_Leave;
			kryptonTextBoxLicense.MouseEnter += SetStatusBar_Enter;
			kryptonTextBoxLicense.MouseLeave += ClearStatusBar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 203);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(577, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 4;
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
			// saveFileDialog
			// 
			saveFileDialog.Filter = "all files|*.*";
			// 
			// kryptonManager
			// 
			kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
			// 
			// LicenseForm
			// 
			AccessibleDescription = "Shows the license information";
			AccessibleName = "License information";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(577, 225);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "LicenseForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "License: GPL-3.0";
			toolTip.SetToolTip(this, "License information");
			FormClosed += LicenseForm_FormClosed;
			Load += LicenseForm_Load;
			KeyDown += LicenseForm_KeyDown;
			((ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			((ISupportInitialize)kryptonPictureBoxLicenseLogo).EndInit();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private KryptonPanel panel;
		private KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolTip toolTip;
		private KryptonTextBox kryptonTextBoxLicense;
		private KryptonPictureBox kryptonPictureBoxLicenseLogo;
		private KryptonButton kryptonButtonClose;
		private KryptonButton kryptonButtonSaveLicense;
		private SaveFileDialog saveFileDialog;
		private KryptonButton kryptonButtonCopyLicenseToClipboard;
		private KryptonManager kryptonManager;
	}
}