using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class TerminologyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminologyForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer = new Krypton.Toolkit.KryptonSplitContainer();
			this.listBox = new Krypton.Toolkit.KryptonListBox();
			this.webBrowser = new Krypton.Toolkit.KryptonWebBrowser();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).BeginInit();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Container to arrange the toolbars";
			this.toolStripContainer.AccessibleName = "Container to arrange the toolbars";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(609, 478);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(609, 525);
			this.toolStripContainer.TabIndex = 5;
			this.toolStripContainer.Text = "toolStripContainer";
			this.toolTip.SetToolTip(this.toolStripContainer, "Container to arrange the toolbars");
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar with some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(609, 22);
			this.statusStrip.TabIndex = 4;
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
			// splitContainer
			// 
			this.splitContainer.AccessibleDescription = "Splits the pane in half with the list of terms you can look up and in the other h" +
    "alf with the web browser";
			this.splitContainer.AccessibleName = "Splits the pane in half with the list of terms you can look up and in the other h" +
    "alf with the web browser";
			this.splitContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.splitContainer.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.listBox);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.webBrowser);
			this.splitContainer.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.HighProfile;
			this.splitContainer.Size = new System.Drawing.Size(609, 478);
			this.splitContainer.SplitterDistance = 263;
			this.splitContainer.TabIndex = 8;
			this.toolTip.SetToolTip(this.splitContainer, "Splits the pane in half with the list of terms you can look up and in the other h" +
        "alf with the web browser");
			// 
			// listBox
			// 
			this.listBox.AccessibleDescription = "Lists the terms that can be looked up";
			this.listBox.AccessibleName = "Terms that can be looked up";
			this.listBox.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.listBox.BackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
			this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox.Items.AddRange(new object[] {
            "Index No.",
            "Readable designation",
            "Epoch (in packed form, .0 TT)",
            "Mean anomaly at the epoch",
            "Argument of perihelion, J2000.0",
            "Longitude of the ascending node, J2000.0",
            "Inclination to the ecliptic, J2000.0",
            "Orbital eccentricity",
            "Mean daily motion",
            "Semi-major axis",
            "Absolute magnitude, H",
            "Slope parameter, G",
            "Reference",
            "Number of oppositions",
            "Number of observations",
            "Observation span",
            "r.m.s. residual",
            "Computer name",
            "4-hexdigit flags",
            "Date of last observation",
            "Linear eccentricity",
            "Semi-minor axis",
            "Major axis",
            "Minor axis",
            "Eccenctric anomaly",
            "True anomaly",
            "Perihelion distance",
            "Aphelion distance",
            "Longitude of the descending node",
            "Argument of aphelion",
            "Focal parameter",
            "Semi-latus rectum",
            "Latus rectum",
            "Orbital period",
            "Orbital area",
            "Orbital perimeter",
            "Semi-mean axis",
            "Mean axis",
            "Standard gravitational parameter"});
			this.listBox.Location = new System.Drawing.Point(0, 0);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(263, 478);
			this.listBox.TabIndex = 7;
			this.toolTip.SetToolTip(this.listBox, "Terms that can be looked up");
			this.listBox.SelectedValueChanged += new System.EventHandler(this.ListBox_SelectedValueChanged);
			this.listBox.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listBox.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.listBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// webBrowser
			// 
			this.webBrowser.AccessibleDescription = "Informs about some definitions";
			this.webBrowser.AccessibleName = "Webbrowser";
			this.webBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(341, 478);
			this.webBrowser.TabIndex = 1;
			this.toolTip.SetToolTip(this.webBrowser, "Webbrowser");
			// 
			// TerminologyForm
			// 
			this.AccessibleDescription = "Informs about some definitions";
			this.AccessibleName = "Terminology";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 525);
			this.Controls.Add(this.toolStripContainer);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TerminologyForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.Text = "Terminology";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerminologyForm_FormClosed);
			this.Load += new System.EventHandler(this.TerminologyForm_Load);
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).EndInit();
			this.splitContainer.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).EndInit();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private KryptonSplitContainer splitContainer;
		private KryptonListBox listBox;
		private KryptonWebBrowser webBrowser;
	}
}