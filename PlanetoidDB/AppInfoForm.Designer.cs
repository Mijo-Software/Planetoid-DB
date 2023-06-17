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
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.linkLabelMailAddress = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelWWW = new System.Windows.Forms.LinkLabel();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButtonOkay = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AccessibleDescription = "Show the version number";
            this.labelVersion.AccessibleName = "Version";
            this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(37, 65);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(159, 25);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version: X.X.X.X";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelVersion, "Show the version number");
            this.labelVersion.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
            this.labelVersion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelVersion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelVersion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelVersion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AccessibleDescription = "Show the application name";
            this.labelTitle.AccessibleName = "Application Name";
            this.labelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Black;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.LightCyan;
            this.labelTitle.Location = new System.Drawing.Point(12, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(221, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Planetoid-DB";
            this.toolTip.SetToolTip(this.labelTitle, "Show the applicatiopn name");
            this.labelTitle.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
            this.labelTitle.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelTitle.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelTitle.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelTitle.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelDescription
            // 
            this.labelDescription.AccessibleDescription = "Show the program description";
            this.labelDescription.AccessibleName = "Program descripton";
            this.labelDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelDescription.Location = new System.Drawing.Point(22, 134);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 15);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "[Description]";
            this.toolTip.SetToolTip(this.labelDescription, "Show the program description");
            this.labelDescription.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
            this.labelDescription.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelDescription.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelDescription.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelDescription.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // linkLabelMailAddress
            // 
            this.linkLabelMailAddress.AccessibleDescription = "Show the mail address";
            this.linkLabelMailAddress.AccessibleName = "Mail address";
            this.linkLabelMailAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.linkLabelMailAddress.AutoSize = true;
            this.linkLabelMailAddress.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelMailAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.linkLabelMailAddress.Image = global::Planetoid_DB.Properties.Resources.silk_email;
            this.linkLabelMailAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelMailAddress.Location = new System.Drawing.Point(22, 199);
            this.linkLabelMailAddress.Name = "linkLabelMailAddress";
            this.linkLabelMailAddress.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.linkLabelMailAddress.Size = new System.Drawing.Size(91, 15);
            this.linkLabelMailAddress.TabIndex = 5;
            this.linkLabelMailAddress.TabStop = true;
            this.linkLabelMailAddress.Text = "Mail address";
            this.toolTip.SetToolTip(this.linkLabelMailAddress, "Show the mail address");
            this.linkLabelMailAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCopyright_Clicked);
            this.linkLabelMailAddress.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
            this.linkLabelMailAddress.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.linkLabelMailAddress.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.linkLabelMailAddress.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.linkLabelMailAddress.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // linkLabelWWW
            // 
            this.linkLabelWWW.AccessibleDescription = "Click to open the homepage";
            this.linkLabelWWW.AccessibleName = "Website";
            this.linkLabelWWW.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.linkLabelWWW.AutoSize = true;
            this.linkLabelWWW.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelWWW.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.linkLabelWWW.Image = global::Planetoid_DB.Properties.Resources.silk_world;
            this.linkLabelWWW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelWWW.Location = new System.Drawing.Point(22, 176);
            this.linkLabelWWW.Name = "linkLabelWWW";
            this.linkLabelWWW.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.linkLabelWWW.Size = new System.Drawing.Size(75, 15);
            this.linkLabelWWW.TabIndex = 4;
            this.linkLabelWWW.TabStop = true;
            this.linkLabelWWW.Text = "[Website]";
            this.linkLabelWWW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.linkLabelWWW, "Visit the website!");
            this.linkLabelWWW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelWWW_Clicked);
            this.linkLabelWWW.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
            this.linkLabelWWW.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.linkLabelWWW.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.linkLabelWWW.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.linkLabelWWW.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.AccessibleDescription = "Show the banner";
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
            this.labelCopyright.AccessibleDescription = "Show the copyright";
            this.labelCopyright.AccessibleName = "Copyright";
            this.labelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelCopyright.Location = new System.Drawing.Point(22, 149);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(68, 15);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "[Copyright]";
            this.toolTip.SetToolTip(this.labelCopyright, "Show the program description");
            this.labelCopyright.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AccessibleDescription = "Show the status";
            this.statusStrip.AccessibleName = "Status bar";
            this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 224);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(504, 21);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.TabStop = true;
            this.statusStrip.Text = "statusStrip";
            // 
            // labelInformation
            // 
            this.labelInformation.AccessibleDescription = "Show some important informations";
            this.labelInformation.AccessibleName = "Information field";
            this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.labelInformation.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
            this.labelInformation.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(170, 16);
            this.labelInformation.Text = "Show informative messages";
            this.labelInformation.ToolTipText = "Show informative messages";
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonButtonOkay);
            this.kryptonPanel.Controls.Add(this.labelCopyright);
            this.kryptonPanel.Controls.Add(this.labelTitle);
            this.kryptonPanel.Controls.Add(this.labelVersion);
            this.kryptonPanel.Controls.Add(this.linkLabelWWW);
            this.kryptonPanel.Controls.Add(this.linkLabelMailAddress);
            this.kryptonPanel.Controls.Add(this.labelDescription);
            this.kryptonPanel.Controls.Add(this.pictureBoxBanner);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(504, 224);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonButtonOkay
            // 
            this.kryptonButtonOkay.AccessibleDescription = "Okay";
            this.kryptonButtonOkay.AccessibleName = "OK";
            this.kryptonButtonOkay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.kryptonButtonOkay.CornerRoundingRadius = -1F;
            this.kryptonButtonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kryptonButtonOkay.Location = new System.Drawing.Point(410, 196);
            this.kryptonButtonOkay.Name = "kryptonButtonOkay";
            this.kryptonButtonOkay.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonOkay.TabIndex = 6;
            this.toolTip.SetToolTip(this.kryptonButtonOkay, "Okay");
            this.kryptonButtonOkay.UseAsADialogButton = true;
            this.kryptonButtonOkay.Values.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
            this.kryptonButtonOkay.Values.Text = "O&K";
            this.kryptonButtonOkay.Click += new System.EventHandler(this.ButtonOK_Click);
            this.kryptonButtonOkay.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.kryptonButtonOkay.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.kryptonButtonOkay.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.kryptonButtonOkay.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // AppInfoForm
            // 
            this.AccessibleDescription = "Show the program information";
            this.AccessibleName = "Program information";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 245);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppInfoForm_FormClosed);
            this.Load += new System.EventHandler(this.AppInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxBanner;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelDescription;
    private System.Windows.Forms.LinkLabel linkLabelMailAddress;
    private System.Windows.Forms.LinkLabel linkLabelWWW;
    private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.Label labelCopyright;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Krypton.Toolkit.KryptonButton kryptonButtonOkay;
    }
}