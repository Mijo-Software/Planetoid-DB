namespace Planetoid_DB
{
	partial class LicenseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonOK = new System.Windows.Forms.Button();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the status";
			this.statusStrip.AccessibleName = "Status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 429);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(589, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 2;
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
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(0, 394);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(589, 35);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "Okay");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			this.buttonOK.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// webBrowser
			// 
			this.webBrowser.AccessibleDescription = "Inform about some definitions";
			this.webBrowser.AccessibleName = "Webbrowser";
			this.webBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Top;
			this.webBrowser.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(589, 394);
			this.webBrowser.TabIndex = 3;
			// 
			// LicenseForm
			// 
			this.AccessibleDescription = "Show the license pf the application";
			this.AccessibleName = "License";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 450);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LicenseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "License";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LicenseForm_FormClosing);
			this.Load += new System.EventHandler(this.LicenseForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Button buttonOK;
	}
}