namespace PlanetoidDB
{
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
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.linkLabelWWW = new System.Windows.Forms.LinkLabel();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
      // 
      // labelVersion
      // 
      this.labelVersion.AccessibleDescription = "Show the version number";
      this.labelVersion.AccessibleName = "Version";
      this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelVersion.BackColor = System.Drawing.Color.Black;
      this.labelVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelVersion.ForeColor = System.Drawing.Color.White;
      this.labelVersion.Location = new System.Drawing.Point(30, 71);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(169, 25);
      this.labelVersion.TabIndex = 1;
      this.labelVersion.Text = "Version: X.X.X.X";
      this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.toolTip.SetToolTip(this.labelVersion, "Show the version number");
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
      this.labelTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.ForeColor = System.Drawing.Color.LightCyan;
      this.labelTitle.Location = new System.Drawing.Point(26, 32);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(182, 39);
      this.labelTitle.TabIndex = 0;
      this.labelTitle.Text = "PlanetoidDB";
      this.toolTip.SetToolTip(this.labelTitle, "Show the applicatiopn name");
      // 
      // buttonOK
      // 
      this.buttonOK.AccessibleDescription = "Okay";
      this.buttonOK.AccessibleName = "OK";
      this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonOK.Image = global::PlanetoidDB.Properties.Resources.silk_accept;
      this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonOK.Location = new System.Drawing.Point(400, 185);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOK.TabIndex = 5;
      this.buttonOK.Text = "OK";
      this.toolTip.SetToolTip(this.buttonOK, "OK");
      this.buttonOK.UseVisualStyleBackColor = true;
      // 
      // labelDescription
      // 
      this.labelDescription.AccessibleDescription = "Show the program description";
      this.labelDescription.AccessibleName = "Program descripton";
      this.labelDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.labelDescription.AutoSize = true;
      this.labelDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelDescription.Location = new System.Drawing.Point(12, 162);
      this.labelDescription.Name = "labelDescription";
      this.labelDescription.Size = new System.Drawing.Size(78, 15);
      this.labelDescription.TabIndex = 3;
      this.labelDescription.Text = "[Description]";
      this.toolTip.SetToolTip(this.labelDescription, "Show the program description");
      // 
      // linkLabelCopyright
      // 
      this.linkLabelCopyright.AccessibleDescription = "Show the copyright";
      this.linkLabelCopyright.AccessibleName = "Copyright";
      this.linkLabelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
      this.linkLabelCopyright.AutoSize = true;
      this.linkLabelCopyright.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabelCopyright.Location = new System.Drawing.Point(12, 141);
      this.linkLabelCopyright.Name = "linkLabelCopyright";
      this.linkLabelCopyright.Size = new System.Drawing.Size(106, 21);
      this.linkLabelCopyright.TabIndex = 2;
      this.linkLabelCopyright.TabStop = true;
      this.linkLabelCopyright.Text = "linkLabelCopyright";
      this.toolTip.SetToolTip(this.linkLabelCopyright, "Show the copyright");
      this.linkLabelCopyright.UseCompatibleTextRendering = true;
      this.linkLabelCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCopyright_LinkClicked);
      // 
      // pictureBox2
      // 
      this.pictureBox2.AccessibleDescription = "Show a globe";
      this.pictureBox2.AccessibleName = "Earth";
      this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
      this.pictureBox2.Image = global::PlanetoidDB.Properties.Resources.silk_world;
      this.pictureBox2.Location = new System.Drawing.Point(15, 190);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(16, 16);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 9;
      this.pictureBox2.TabStop = false;
      this.toolTip.SetToolTip(this.pictureBox2, "Earth");
      // 
      // linkLabelWWW
      // 
      this.linkLabelWWW.AccessibleDescription = "Click to open the homepage";
      this.linkLabelWWW.AccessibleName = "Website";
      this.linkLabelWWW.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
      this.linkLabelWWW.AutoSize = true;
      this.linkLabelWWW.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabelWWW.Location = new System.Drawing.Point(37, 191);
      this.linkLabelWWW.Name = "linkLabelWWW";
      this.linkLabelWWW.Size = new System.Drawing.Size(60, 15);
      this.linkLabelWWW.TabIndex = 4;
      this.linkLabelWWW.TabStop = true;
      this.linkLabelWWW.Text = "[Website]";
      this.toolTip.SetToolTip(this.linkLabelWWW, "Visit the website!");
      this.linkLabelWWW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWWW_LinkClicked);
      // 
      // AppInfoForm
      // 
      this.AccessibleDescription = "Show the program information";
      this.AccessibleName = "Program information";
      this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(487, 220);
      this.Controls.Add(this.linkLabelWWW);
      this.Controls.Add(this.pictureBox2);
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
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Program information";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppInfoForm_FormClosed);
      this.Load += new System.EventHandler(this.AppInfoForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.LinkLabel linkLabelWWW;
    private System.Windows.Forms.ToolTip toolTip;
  }
}