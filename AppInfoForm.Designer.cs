﻿using System.ComponentModel;
using Krypton.Toolkit;

namespace Planetoid_DB
{
  /// <summary>
	/// 
	/// </summary>
	partial class AppInfoForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppInfoForm));
			labelVersion = new KryptonLabel();
			labelTitle = new KryptonLabel();
			labelDescription = new KryptonLabel();
			toolTip = new ToolTip(components);
			pictureBoxBanner = new PictureBox();
			labelCopyright = new KryptonLabel();
			linkLabelEmail = new KryptonLinkLabel();
			linkLabelWebsite = new KryptonLinkLabel();
			panel = new KryptonPanel();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// labelVersion
			// 
			labelVersion.AccessibleDescription = "Shows the version number";
			labelVersion.AccessibleName = "Version";
			labelVersion.AccessibleRole = AccessibleRole.StaticText;
			labelVersion.BackColor = Color.Black;
			labelVersion.Font = new Font("Segoe UI", 8.5F);
			labelVersion.ForeColor = Color.White;
			labelVersion.Location = new Point(12, 154);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(95, 20);
			labelVersion.TabIndex = 1;
			toolTip.SetToolTip(labelVersion, "Shows the version number");
			labelVersion.Values.Text = "Version: X.X.X.X";
			labelVersion.DoubleClick += CopyToClipboard_DoubleClick;
			labelVersion.Enter += SetStatusBar_Enter;
			labelVersion.Leave += ClearStatusBar_Leave;
			labelVersion.MouseEnter += SetStatusBar_Enter;
			labelVersion.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelTitle
			// 
			labelTitle.AccessibleDescription = "Shows the application name";
			labelTitle.AccessibleName = "Application Name";
			labelTitle.AccessibleRole = AccessibleRole.StaticText;
			labelTitle.BackColor = Color.Black;
			labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
			labelTitle.ForeColor = Color.LightCyan;
			labelTitle.LabelStyle = LabelStyle.TitlePanel;
			labelTitle.Location = new Point(12, 129);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(129, 29);
			labelTitle.TabIndex = 0;
			toolTip.SetToolTip(labelTitle, "Shows the application name");
			labelTitle.Values.Text = "Planetoid-DB";
			labelTitle.DoubleClick += CopyToClipboard_DoubleClick;
			labelTitle.Enter += SetStatusBar_Enter;
			labelTitle.Leave += ClearStatusBar_Leave;
			labelTitle.MouseEnter += SetStatusBar_Enter;
			labelTitle.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDescription
			// 
			labelDescription.AccessibleDescription = "Shows the program description";
			labelDescription.AccessibleName = "Program descripton";
			labelDescription.AccessibleRole = AccessibleRole.StaticText;
			labelDescription.Font = new Font("Segoe UI", 8.5F);
			labelDescription.Location = new Point(12, 180);
			labelDescription.Name = "labelDescription";
			labelDescription.Size = new Size(80, 20);
			labelDescription.TabIndex = 2;
			toolTip.SetToolTip(labelDescription, "Shows the program description");
			labelDescription.Values.Text = "[Description]";
			labelDescription.DoubleClick += CopyToClipboard_DoubleClick;
			labelDescription.Enter += SetStatusBar_Enter;
			labelDescription.Leave += ClearStatusBar_Leave;
			labelDescription.MouseEnter += SetStatusBar_Enter;
			labelDescription.MouseLeave += ClearStatusBar_Leave;
			// 
			// pictureBoxBanner
			// 
			pictureBoxBanner.AccessibleDescription = "Shows the banner";
			pictureBoxBanner.AccessibleName = "Banner";
			pictureBoxBanner.AccessibleRole = AccessibleRole.Graphic;
			pictureBoxBanner.Image = (Image)resources.GetObject("pictureBoxBanner.Image");
			pictureBoxBanner.Location = new Point(3, 3);
			pictureBoxBanner.Name = "pictureBoxBanner";
			pictureBoxBanner.Size = new Size(497, 120);
			pictureBoxBanner.TabIndex = 0;
			pictureBoxBanner.TabStop = false;
			toolTip.SetToolTip(pictureBoxBanner, "On the graphic you see the minor planet \"(243) Ida \".");
			pictureBoxBanner.MouseEnter += SetStatusBar_Enter;
			pictureBoxBanner.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelCopyright
			// 
			labelCopyright.AccessibleDescription = "Shows the copyright";
			labelCopyright.AccessibleName = "Copyright";
			labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			labelCopyright.Font = new Font("Segoe UI", 8.5F);
			labelCopyright.Location = new Point(12, 200);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(72, 20);
			labelCopyright.TabIndex = 3;
			toolTip.SetToolTip(labelCopyright, "Shows the copyright");
			labelCopyright.Values.Text = "[Copyright]";
			labelCopyright.DoubleClick += CopyToClipboard_DoubleClick;
			labelCopyright.Enter += SetStatusBar_Enter;
			labelCopyright.Leave += ClearStatusBar_Leave;
			labelCopyright.MouseEnter += SetStatusBar_Enter;
			labelCopyright.MouseLeave += ClearStatusBar_Leave;
			// 
			// linkLabelEmail
			// 
			linkLabelEmail.AccessibleDescription = "Opens the mail client";
			linkLabelEmail.AccessibleName = "E-Mail";
			linkLabelEmail.AccessibleRole = AccessibleRole.Link;
			linkLabelEmail.LinkBehavior = KryptonLinkBehavior.HoverUnderline;
			linkLabelEmail.Location = new Point(420, 200);
			linkLabelEmail.Name = "linkLabelEmail";
			linkLabelEmail.Size = new Size(62, 20);
			linkLabelEmail.TabIndex = 5;
			toolTip.SetToolTip(linkLabelEmail, "E-Mail");
			linkLabelEmail.Values.Image = Properties.Resources.silk_email;
			linkLabelEmail.Values.Text = "E-Mail";
			linkLabelEmail.LinkClicked += LinkLabelEmail_Clicked;
			linkLabelEmail.Enter += SetStatusBar_Enter;
			linkLabelEmail.Leave += ClearStatusBar_Leave;
			linkLabelEmail.MouseEnter += SetStatusBar_Enter;
			linkLabelEmail.MouseLeave += ClearStatusBar_Leave;
			// 
			// linkLabelWebsite
			// 
			linkLabelWebsite.AccessibleDescription = "Opens the website";
			linkLabelWebsite.AccessibleName = "Website";
			linkLabelWebsite.AccessibleRole = AccessibleRole.Link;
			linkLabelWebsite.LinkBehavior = KryptonLinkBehavior.HoverUnderline;
			linkLabelWebsite.Location = new Point(420, 174);
			linkLabelWebsite.Name = "linkLabelWebsite";
			linkLabelWebsite.Size = new Size(72, 20);
			linkLabelWebsite.TabIndex = 4;
			toolTip.SetToolTip(linkLabelWebsite, "Website");
			linkLabelWebsite.Values.Image = Properties.Resources.silk_world;
			linkLabelWebsite.Values.Text = "Website";
			linkLabelWebsite.LinkClicked += LinkLabelWebsite_Clicked;
			linkLabelWebsite.Enter += SetStatusBar_Enter;
			linkLabelWebsite.Leave += ClearStatusBar_Leave;
			linkLabelWebsite.MouseEnter += SetStatusBar_Enter;
			linkLabelWebsite.MouseLeave += ClearStatusBar_Leave;
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(linkLabelEmail);
			panel.Controls.Add(linkLabelWebsite);
			panel.Controls.Add(statusStrip);
			panel.Controls.Add(labelCopyright);
			panel.Controls.Add(labelTitle);
			panel.Controls.Add(labelVersion);
			panel.Controls.Add(labelDescription);
			panel.Controls.Add(pictureBoxBanner);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.PanelBackStyle = PaletteBackStyle.FormMain;
			panel.Size = new Size(504, 245);
			panel.TabIndex = 0;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 223);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(504, 22);
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
			// AppInfoForm
			// 
			AccessibleDescription = "Shows the program information";
			AccessibleName = "Program information";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(504, 245);
			Controls.Add(panel);
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AppInfoForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Program information";
			toolTip.SetToolTip(this, "Program information");
			FormClosed += AppInfoForm_FormClosed;
			Load += AppInfoForm_Load;
			KeyDown += AppInfoForm_KeyDown;
			((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private PictureBox pictureBoxBanner;
    private KryptonLabel labelVersion;
    private KryptonLabel labelTitle;
    private KryptonLabel labelDescription;
    private ToolTip toolTip;
		private KryptonLabel labelCopyright;
        private KryptonPanel panel;
		private KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private KryptonLinkLabel linkLabelWebsite;
		private KryptonLinkLabel linkLabelEmail;
	}
}