using System.ComponentModel;
using Krypton.Toolkit;

using Planetoid_DB.Resources;

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
			this.components = new Container();
			var resources = new ComponentResourceManager(typeof(AppInfoForm));
			this.labelVersion = new KryptonLabel();
			this.labelTitle = new KryptonLabel();
			this.labelDescription = new KryptonLabel();
			this.toolTip = new ToolTip(this.components);
			this.pictureBoxBanner = new PictureBox();
			this.labelCopyright = new KryptonLabel();
			this.linkLabelEmail = new KryptonLinkLabel();
			this.linkLabelWebsite = new KryptonLinkLabel();
			this.panel = new KryptonPanel();
			this.statusStrip = new KryptonStatusStrip();
			this.labelInformation = new ToolStripStatusLabel();
			this.kryptonManager = new KryptonManager(this.components);
			((ISupportInitialize)this.pictureBoxBanner).BeginInit();
			((ISupportInitialize)this.panel).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelVersion
			// 
			this.labelVersion.AccessibleDescription = "Shows the version number";
			this.labelVersion.AccessibleName = "Version";
			this.labelVersion.AccessibleRole = AccessibleRole.StaticText;
			this.labelVersion.Location = new Point(12, 154);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new Size(95, 20);
			this.labelVersion.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelVersion, "Shows the version number");
			this.labelVersion.Values.Text = "Version: X.X.X.X";
			this.labelVersion.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelVersion.Enter += this.SetStatusBar_Enter;
			this.labelVersion.Leave += this.ClearStatusBar_Leave;
			this.labelVersion.MouseEnter += this.SetStatusBar_Enter;
			this.labelVersion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelTitle
			// 
			this.labelTitle.AccessibleDescription = "Shows the application name";
			this.labelTitle.AccessibleName = "Application Name";
			this.labelTitle.AccessibleRole = AccessibleRole.StaticText;
			this.labelTitle.LabelStyle = LabelStyle.TitlePanel;
			this.labelTitle.Location = new Point(12, 129);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new Size(129, 29);
			this.labelTitle.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelTitle, "Shows the application name");
			this.labelTitle.Values.Text = "Planetoid-DB";
			this.labelTitle.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelTitle.Enter += this.SetStatusBar_Enter;
			this.labelTitle.Leave += this.ClearStatusBar_Leave;
			this.labelTitle.MouseEnter += this.SetStatusBar_Enter;
			this.labelTitle.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelDescription
			// 
			this.labelDescription.AccessibleDescription = "Shows the program description";
			this.labelDescription.AccessibleName = "Program descripton";
			this.labelDescription.AccessibleRole = AccessibleRole.StaticText;
			this.labelDescription.Location = new Point(12, 180);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new Size(80, 20);
			this.labelDescription.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelDescription, "Shows the program description");
			this.labelDescription.Values.Text = "[Description]";
			this.labelDescription.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelDescription.Enter += this.SetStatusBar_Enter;
			this.labelDescription.Leave += this.ClearStatusBar_Leave;
			this.labelDescription.MouseEnter += this.SetStatusBar_Enter;
			this.labelDescription.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// pictureBoxBanner
			// 
			this.pictureBoxBanner.AccessibleDescription = "Shows the banner";
			this.pictureBoxBanner.AccessibleName = "Banner";
			this.pictureBoxBanner.AccessibleRole = AccessibleRole.Graphic;
			this.pictureBoxBanner.Image = (Image)resources.GetObject("pictureBoxBanner.Image");
			this.pictureBoxBanner.Location = new Point(3, 3);
			this.pictureBoxBanner.Name = "pictureBoxBanner";
			this.pictureBoxBanner.Size = new Size(497, 120);
			this.pictureBoxBanner.TabIndex = 0;
			this.pictureBoxBanner.TabStop = false;
			this.toolTip.SetToolTip(this.pictureBoxBanner, "On the graphic you see the minor planet \"(243) Ida \".");
			this.pictureBoxBanner.MouseEnter += this.SetStatusBar_Enter;
			this.pictureBoxBanner.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelCopyright
			// 
			this.labelCopyright.AccessibleDescription = "Shows the copyright";
			this.labelCopyright.AccessibleName = "Copyright";
			this.labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			this.labelCopyright.Location = new Point(12, 200);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new Size(72, 20);
			this.labelCopyright.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelCopyright, "Shows the copyright");
			this.labelCopyright.Values.Text = "[Copyright]";
			this.labelCopyright.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelCopyright.Enter += this.SetStatusBar_Enter;
			this.labelCopyright.Leave += this.ClearStatusBar_Leave;
			this.labelCopyright.MouseEnter += this.SetStatusBar_Enter;
			this.labelCopyright.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// linkLabelEmail
			// 
			this.linkLabelEmail.AccessibleDescription = "Opens the mail client";
			this.linkLabelEmail.AccessibleName = "E-Mail";
			this.linkLabelEmail.AccessibleRole = AccessibleRole.Link;
			this.linkLabelEmail.LinkBehavior = KryptonLinkBehavior.HoverUnderline;
			this.linkLabelEmail.Location = new Point(420, 200);
			this.linkLabelEmail.Name = "linkLabelEmail";
			this.linkLabelEmail.Size = new Size(62, 20);
			this.linkLabelEmail.TabIndex = 5;
			this.toolTip.SetToolTip(this.linkLabelEmail, "E-Mail");
			this.linkLabelEmail.Values.Image = FatcowIcons16px.fatcow_email_16px;
			this.linkLabelEmail.Values.Text = "E-Mail";
			this.linkLabelEmail.Visible = false;
			this.linkLabelEmail.LinkClicked += this.LinkLabelEmail_Clicked;
			this.linkLabelEmail.Enter += this.SetStatusBar_Enter;
			this.linkLabelEmail.Leave += this.ClearStatusBar_Leave;
			this.linkLabelEmail.MouseEnter += this.SetStatusBar_Enter;
			this.linkLabelEmail.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// linkLabelWebsite
			// 
			this.linkLabelWebsite.AccessibleDescription = "Opens the website";
			this.linkLabelWebsite.AccessibleName = "Website";
			this.linkLabelWebsite.AccessibleRole = AccessibleRole.Link;
			this.linkLabelWebsite.LinkBehavior = KryptonLinkBehavior.HoverUnderline;
			this.linkLabelWebsite.Location = new Point(420, 174);
			this.linkLabelWebsite.Name = "linkLabelWebsite";
			this.linkLabelWebsite.Size = new Size(72, 20);
			this.linkLabelWebsite.TabIndex = 4;
			this.toolTip.SetToolTip(this.linkLabelWebsite, "Website");
			this.linkLabelWebsite.Values.Image = FatcowIcons16px.fatcow_world_16px;
			this.linkLabelWebsite.Values.Text = "Website";
			this.linkLabelWebsite.Visible = false;
			this.linkLabelWebsite.LinkClicked += this.LinkLabelWebsite_Clicked;
			this.linkLabelWebsite.Enter += this.SetStatusBar_Enter;
			this.linkLabelWebsite.Leave += this.ClearStatusBar_Leave;
			this.linkLabelWebsite.MouseEnter += this.SetStatusBar_Enter;
			this.linkLabelWebsite.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "pane";
			this.panel.AccessibleRole = AccessibleRole.Pane;
			this.panel.Controls.Add(this.linkLabelEmail);
			this.panel.Controls.Add(this.linkLabelWebsite);
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.labelCopyright);
			this.panel.Controls.Add(this.labelTitle);
			this.panel.Controls.Add(this.labelVersion);
			this.panel.Controls.Add(this.labelDescription);
			this.panel.Controls.Add(this.pictureBoxBanner);
			this.panel.Dock = DockStyle.Fill;
			this.panel.Location = new Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = PaletteBackStyle.FormMain;
			this.panel.Size = new Size(512, 246);
			this.panel.TabIndex = 0;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			this.statusStrip.Font = new Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new ToolStripItem[] { this.labelInformation });
			this.statusStrip.Location = new Point(0, 224);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new Size(512, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 6;
			this.statusStrip.Text = "status bar";
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Shows some information";
			this.labelInformation.AccessibleName = "Shows some information";
			this.labelInformation.AccessibleRole = AccessibleRole.StaticText;
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Image = FatcowIcons16px.fatcow_lightbulb_16px;
			this.labelInformation.Margin = new Padding(5, 3, 0, 2);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new Size(144, 17);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Shows some information";
			// 
			// kryptonManager
			// 
			this.kryptonManager.GlobalPaletteMode = PaletteMode.Global;
			// 
			// AppInfoForm
			// 
			this.AccessibleDescription = "Shows the program information";
			this.AccessibleName = "Program information";
			this.AccessibleRole = AccessibleRole.Dialog;
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(512, 246);
			this.Controls.Add(this.panel);
			this.Font = new Font("Segoe UI", 8.5F);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppInfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Program information";
			this.toolTip.SetToolTip(this, "Program information");
			this.FormClosed += this.AppInfoForm_FormClosed;
			this.Load += this.AppInfoForm_Load;
			this.KeyDown += this.AppInfoForm_KeyDown;
			((ISupportInitialize)this.pictureBoxBanner).EndInit();
			((ISupportInitialize)this.panel).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

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
		private KryptonManager kryptonManager;
	}
}