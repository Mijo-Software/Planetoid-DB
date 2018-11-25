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
			this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelDescription = new System.Windows.Forms.Label();
			this.linkLabelCopyright = new System.Windows.Forms.LinkLabel();
			this.pictureBoxWorld = new System.Windows.Forms.PictureBox();
			this.linkLabelWWW = new System.Windows.Forms.LinkLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelHelp = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorld)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxBanner
			// 
			this.pictureBoxBanner.AccessibleDescription = "Show the banner";
			this.pictureBoxBanner.AccessibleName = "banner";
			this.pictureBoxBanner.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBoxBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanner.Image")));
			this.pictureBoxBanner.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxBanner.Name = "pictureBoxBanner";
			this.pictureBoxBanner.Size = new System.Drawing.Size(490, 120);
			this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxBanner.TabIndex = 0;
			this.pictureBoxBanner.TabStop = false;
			this.toolTip.SetToolTip(this.pictureBoxBanner, "On the graphic you see the planetiod \"(243) Ida \".");
			this.pictureBoxBanner.MouseEnter += new System.EventHandler(this.PictureBoxBanner_MouseEnter);
			this.pictureBoxBanner.MouseLeave += new System.EventHandler(this.PictureBoxBanner_MouseLeave);
			// 
			// labelVersion
			// 
			this.labelVersion.AccessibleDescription = "Show the version number";
			this.labelVersion.AccessibleName = "Version";
			this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelVersion.BackColor = System.Drawing.Color.Black;
			this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelVersion.ForeColor = System.Drawing.Color.White;
			this.labelVersion.Location = new System.Drawing.Point(15, 71);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(218, 25);
			this.labelVersion.TabIndex = 1;
			this.labelVersion.Text = "Version: X.X.X.X";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelVersion, "Show the version number");
			this.labelVersion.Enter += new System.EventHandler(this.LabelVersion_Enter);
			this.labelVersion.Leave += new System.EventHandler(this.LabelVersion_Leave);
			this.labelVersion.MouseEnter += new System.EventHandler(this.LabelVersion_Enter);
			this.labelVersion.MouseLeave += new System.EventHandler(this.LabelVersion_Leave);
			// 
			// labelTitle
			// 
			this.labelTitle.AccessibleDescription = "Show the applicatiopn name";
			this.labelTitle.AccessibleName = "Application Name";
			this.labelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.AutoSize = true;
			this.labelTitle.BackColor = System.Drawing.Color.Black;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
			this.labelTitle.ForeColor = System.Drawing.Color.LightCyan;
			this.labelTitle.Location = new System.Drawing.Point(12, 26);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(221, 45);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Planetoid-DB";
			this.toolTip.SetToolTip(this.labelTitle, "Show the applicatiopn name");
			this.labelTitle.Enter += new System.EventHandler(this.LabelTitle_Enter);
			this.labelTitle.Leave += new System.EventHandler(this.LabelTitle_Leave);
			this.labelTitle.MouseEnter += new System.EventHandler(this.LabelTitle_Enter);
			this.labelTitle.MouseLeave += new System.EventHandler(this.LabelTitle_Leave);
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Okay";
			this.buttonOK.AccessibleName = "OK";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(400, 188);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "OK");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Enter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ButtonOK_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.MouseLeave += new System.EventHandler(this.ButtonOK_Leave);
			// 
			// labelDescription
			// 
			this.labelDescription.AccessibleDescription = "Show the program description";
			this.labelDescription.AccessibleName = "Program descripton";
			this.labelDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDescription.Location = new System.Drawing.Point(9, 161);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(75, 15);
			this.labelDescription.TabIndex = 3;
			this.labelDescription.Text = "[Description]";
			this.toolTip.SetToolTip(this.labelDescription, "Show the program description");
			this.labelDescription.Enter += new System.EventHandler(this.LabelDescription_Enter);
			this.labelDescription.Leave += new System.EventHandler(this.LabelDescription_Leave);
			this.labelDescription.MouseEnter += new System.EventHandler(this.LabelDescription_Enter);
			this.labelDescription.MouseLeave += new System.EventHandler(this.LabelDescription_Leave);
			// 
			// linkLabelCopyright
			// 
			this.linkLabelCopyright.AccessibleDescription = "Show the copyright";
			this.linkLabelCopyright.AccessibleName = "Copyright";
			this.linkLabelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelCopyright.AutoSize = true;
			this.linkLabelCopyright.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelCopyright.Location = new System.Drawing.Point(12, 141);
			this.linkLabelCopyright.Name = "linkLabelCopyright";
			this.linkLabelCopyright.Size = new System.Drawing.Size(107, 15);
			this.linkLabelCopyright.TabIndex = 2;
			this.linkLabelCopyright.TabStop = true;
			this.linkLabelCopyright.Text = "linkLabelCopyright";
			this.toolTip.SetToolTip(this.linkLabelCopyright, "Show the copyright");
			this.linkLabelCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCopyright_LinkClicked);
			this.linkLabelCopyright.Enter += new System.EventHandler(this.LinkLabelCopyright_Enter);
			this.linkLabelCopyright.Leave += new System.EventHandler(this.LinkLabelCopyright_Leave);
			this.linkLabelCopyright.MouseEnter += new System.EventHandler(this.LinkLabelCopyright_Enter);
			this.linkLabelCopyright.MouseLeave += new System.EventHandler(this.LinkLabelCopyright_Leave);
			// 
			// pictureBoxWorld
			// 
			this.pictureBoxWorld.AccessibleDescription = "Show a globe";
			this.pictureBoxWorld.AccessibleName = "Earth";
			this.pictureBoxWorld.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBoxWorld.Image = global::Planetoid_DB.Properties.Resources.silk_world;
			this.pictureBoxWorld.Location = new System.Drawing.Point(15, 190);
			this.pictureBoxWorld.Name = "pictureBoxWorld";
			this.pictureBoxWorld.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxWorld.TabIndex = 9;
			this.pictureBoxWorld.TabStop = false;
			this.toolTip.SetToolTip(this.pictureBoxWorld, "Earth");
			this.pictureBoxWorld.MouseEnter += new System.EventHandler(this.PictureBoxWorld_MouseEnter);
			this.pictureBoxWorld.MouseLeave += new System.EventHandler(this.PictureBoxWorld_MouseLeave);
			// 
			// linkLabelWWW
			// 
			this.linkLabelWWW.AccessibleDescription = "Click to open the homepage";
			this.linkLabelWWW.AccessibleName = "Website";
			this.linkLabelWWW.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelWWW.AutoSize = true;
			this.linkLabelWWW.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelWWW.Location = new System.Drawing.Point(37, 191);
			this.linkLabelWWW.Name = "linkLabelWWW";
			this.linkLabelWWW.Size = new System.Drawing.Size(57, 15);
			this.linkLabelWWW.TabIndex = 4;
			this.linkLabelWWW.TabStop = true;
			this.linkLabelWWW.Text = "[Website]";
			this.linkLabelWWW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.linkLabelWWW, "Visit the website!");
			this.linkLabelWWW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelWWW_LinkClicked);
			this.linkLabelWWW.Enter += new System.EventHandler(this.LinkLabelWWW_Enter);
			this.linkLabelWWW.Leave += new System.EventHandler(this.LinkLabelWWW_Leave);
			this.linkLabelWWW.MouseEnter += new System.EventHandler(this.LinkLabelWWW_Enter);
			this.linkLabelWWW.MouseLeave += new System.EventHandler(this.LinkLabelWWW_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the status";
			this.statusStrip.AccessibleName = "Status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelHelp});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 219);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(487, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 11;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelHelp
			// 
			this.labelHelp.AccessibleDescription = "Show some important informations";
			this.labelHelp.AccessibleName = "Information field";
			this.labelHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelHelp.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelHelp.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(170, 16);
			this.labelHelp.Text = "Show informative messages";
			this.labelHelp.ToolTipText = "Show informative messages";
			// 
			// AppInfoForm
			// 
			this.AccessibleDescription = "Show the program information";
			this.AccessibleName = "Program information";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 240);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.linkLabelWWW);
			this.Controls.Add(this.pictureBoxWorld);
			this.Controls.Add(this.linkLabelCopyright);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBoxBanner);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Program information";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppInfoForm_FormClosed);
			this.Load += new System.EventHandler(this.AppInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorld)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxBanner;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Label labelDescription;
    private System.Windows.Forms.LinkLabel linkLabelCopyright;
    private System.Windows.Forms.PictureBox pictureBoxWorld;
    private System.Windows.Forms.LinkLabel linkLabelWWW;
    private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelHelp;
	}
}