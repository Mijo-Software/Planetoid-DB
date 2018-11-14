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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.labelVersion = new System.Windows.Forms.Label();
      this.labelTitle = new System.Windows.Forms.Label();
      this.buttonOK = new System.Windows.Forms.Button();
      this.labelDescription = new System.Windows.Forms.Label();
      this.linkLabelCopyright = new System.Windows.Forms.LinkLabel();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.linkLabelWWW = new System.Windows.Forms.LinkLabel();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(490, 120);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // labelVersion
      // 
      this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.labelVersion.BackColor = System.Drawing.Color.Black;
      this.labelVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelVersion.ForeColor = System.Drawing.Color.White;
      this.labelVersion.Location = new System.Drawing.Point(30, 71);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(169, 25);
      this.labelVersion.TabIndex = 4;
      this.labelVersion.Text = "Version: X.X.X.X";
      this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelTitle
      // 
      this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.labelTitle.AutoSize = true;
      this.labelTitle.BackColor = System.Drawing.Color.Black;
      this.labelTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.ForeColor = System.Drawing.Color.LightCyan;
      this.labelTitle.Location = new System.Drawing.Point(26, 32);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(182, 39);
      this.labelTitle.TabIndex = 3;
      this.labelTitle.Text = "PlanetoidDB";
      // 
      // buttonOK
      // 
      this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
      this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.labelDescription.AutoSize = true;
      this.labelDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelDescription.Location = new System.Drawing.Point(12, 162);
      this.labelDescription.Name = "labelDescription";
      this.labelDescription.Size = new System.Drawing.Size(78, 15);
      this.labelDescription.TabIndex = 7;
      this.labelDescription.Text = "[Description]";
      this.toolTip.SetToolTip(this.labelDescription, "Description of the application");
      // 
      // linkLabelCopyright
      // 
      this.linkLabelCopyright.AutoSize = true;
      this.linkLabelCopyright.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabelCopyright.Location = new System.Drawing.Point(12, 141);
      this.linkLabelCopyright.Name = "linkLabelCopyright";
      this.linkLabelCopyright.Size = new System.Drawing.Size(106, 21);
      this.linkLabelCopyright.TabIndex = 8;
      this.linkLabelCopyright.TabStop = true;
      this.linkLabelCopyright.Text = "linkLabelCopyright";
      this.toolTip.SetToolTip(this.linkLabelCopyright, "Copyright");
      this.linkLabelCopyright.UseCompatibleTextRendering = true;
      this.linkLabelCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCopyright_LinkClicked);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::PlanetoidDB.Properties.Resources.silk_world;
      this.pictureBox2.Location = new System.Drawing.Point(15, 190);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(16, 16);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 9;
      this.pictureBox2.TabStop = false;
      // 
      // linkLabelWWW
      // 
      this.linkLabelWWW.AutoSize = true;
      this.linkLabelWWW.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabelWWW.Location = new System.Drawing.Point(37, 193);
      this.linkLabelWWW.Name = "linkLabelWWW";
      this.linkLabelWWW.Size = new System.Drawing.Size(60, 15);
      this.linkLabelWWW.TabIndex = 10;
      this.linkLabelWWW.TabStop = true;
      this.linkLabelWWW.Text = "[Website]";
      this.toolTip.SetToolTip(this.linkLabelWWW, "Visit the website!");
      this.linkLabelWWW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWWW_LinkClicked);
      // 
      // AppInfoForm
      // 
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
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AppInfoForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Program information";
      this.Load += new System.EventHandler(this.AppInfoForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
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