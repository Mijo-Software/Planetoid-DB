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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppInfoForm));
			this.labelVersion = new Krypton.Toolkit.KryptonLabel();
			this.labelTitle = new Krypton.Toolkit.KryptonLabel();
			this.labelDescription = new Krypton.Toolkit.KryptonLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
			this.labelCopyright = new Krypton.Toolkit.KryptonLabel();
			this.linkLabelEmail = new Krypton.Toolkit.KryptonLinkLabel();
			this.linkLabelWebsite = new Krypton.Toolkit.KryptonLinkLabel();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelVersion
			// 
			this.labelVersion.AccessibleDescription = "Shows the version number";
			this.labelVersion.AccessibleName = "Version";
			this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelVersion.BackColor = System.Drawing.Color.Black;
			this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelVersion.ForeColor = System.Drawing.Color.White;
			this.labelVersion.Location = new System.Drawing.Point(12, 154);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(95, 20);
			this.labelVersion.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelVersion, "Shows the version number");
			this.labelVersion.Values.Text = "Version: X.X.X.X";
			this.labelVersion.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelVersion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelVersion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelVersion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelVersion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTitle
			// 
			this.labelTitle.AccessibleDescription = "Shows the application name";
			this.labelTitle.AccessibleName = "Application Name";
			this.labelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTitle.BackColor = System.Drawing.Color.Black;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
			this.labelTitle.ForeColor = System.Drawing.Color.LightCyan;
			this.labelTitle.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
			this.labelTitle.Location = new System.Drawing.Point(12, 129);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(129, 29);
			this.labelTitle.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelTitle, "Shows the application name");
			this.labelTitle.Values.Text = "Planetoid-DB";
			this.labelTitle.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelTitle.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTitle.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDescription
			// 
			this.labelDescription.AccessibleDescription = "Shows the program description";
			this.labelDescription.AccessibleName = "Program descripton";
			this.labelDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDescription.Location = new System.Drawing.Point(12, 180);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(80, 20);
			this.labelDescription.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelDescription, "Shows the program description");
			this.labelDescription.Values.Text = "[Description]";
			this.labelDescription.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDescription.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDescription.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// pictureBoxBanner
			// 
			this.pictureBoxBanner.AccessibleDescription = "Shows the banner";
			this.pictureBoxBanner.AccessibleName = "Banner";
			this.pictureBoxBanner.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBoxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanner.Image")));
			this.pictureBoxBanner.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxBanner.Name = "pictureBoxBanner";
			this.pictureBoxBanner.Size = new System.Drawing.Size(497, 120);
			this.pictureBoxBanner.TabIndex = 0;
			this.pictureBoxBanner.TabStop = false;
			this.toolTip.SetToolTip(this.pictureBoxBanner, "On the graphic you see the minor planet \"(243) Ida \".");
			this.pictureBoxBanner.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.pictureBoxBanner.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCopyright
			// 
			this.labelCopyright.AccessibleDescription = "Shows the copyright";
			this.labelCopyright.AccessibleName = "Copyright";
			this.labelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelCopyright.Location = new System.Drawing.Point(12, 200);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(72, 20);
			this.labelCopyright.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelCopyright, "Shows the copyright");
			this.labelCopyright.Values.Text = "[Copyright]";
			this.labelCopyright.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelCopyright.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCopyright.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelEmail
			// 
			this.linkLabelEmail.AccessibleDescription = "Opens the mail client";
			this.linkLabelEmail.AccessibleName = "E-Mail";
			this.linkLabelEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelEmail.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.linkLabelEmail.Location = new System.Drawing.Point(420, 200);
			this.linkLabelEmail.Name = "linkLabelEmail";
			this.linkLabelEmail.Size = new System.Drawing.Size(62, 20);
			this.linkLabelEmail.TabIndex = 5;
			this.toolTip.SetToolTip(this.linkLabelEmail, "E-Mail");
			this.linkLabelEmail.Values.Image = global::Planetoid_DB.Properties.Resources.silk_email;
			this.linkLabelEmail.Values.Text = "E-Mail";
			this.linkLabelEmail.LinkClicked += new System.EventHandler(this.LinkLabelEmail_Clicked);
			this.linkLabelEmail.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEmail.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelEmail.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEmail.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelWebsite
			// 
			this.linkLabelWebsite.AccessibleDescription = "Opens the website";
			this.linkLabelWebsite.AccessibleName = "Website";
			this.linkLabelWebsite.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelWebsite.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.linkLabelWebsite.Location = new System.Drawing.Point(420, 174);
			this.linkLabelWebsite.Name = "linkLabelWebsite";
			this.linkLabelWebsite.Size = new System.Drawing.Size(72, 20);
			this.linkLabelWebsite.TabIndex = 4;
			this.toolTip.SetToolTip(this.linkLabelWebsite, "Website");
			this.linkLabelWebsite.Values.Image = global::Planetoid_DB.Properties.Resources.silk_world;
			this.linkLabelWebsite.Values.Text = "Website";
			this.linkLabelWebsite.LinkClicked += new System.EventHandler(this.LinkLabelWebsite_Clicked);
			this.linkLabelWebsite.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelWebsite.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelWebsite.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelWebsite.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "pane";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.linkLabelEmail);
			this.panel.Controls.Add(this.linkLabelWebsite);
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.labelCopyright);
			this.panel.Controls.Add(this.labelTitle);
			this.panel.Controls.Add(this.labelVersion);
			this.panel.Controls.Add(this.labelDescription);
			this.panel.Controls.Add(this.pictureBoxBanner);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.panel.Size = new System.Drawing.Size(504, 245);
			this.panel.TabIndex = 0;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 223);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(504, 22);
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
			// AppInfoForm
			// 
			this.AccessibleDescription = "Shows the program information";
			this.AccessibleName = "Program information";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 245);
			this.Controls.Add(this.panel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppInfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Program information";
			this.toolTip.SetToolTip(this, "Program information");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppInfoForm_FormClosed);
			this.Load += new System.EventHandler(this.AppInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxBanner;
    private KryptonLabel labelVersion;
    private KryptonLabel labelTitle;
    private KryptonLabel labelDescription;
    private System.Windows.Forms.ToolTip toolTip;
		private KryptonLabel labelCopyright;
        private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private KryptonLinkLabel linkLabelWebsite;
		private KryptonLinkLabel linkLabelEmail;
	}
}