﻿using System.ComponentModel;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class TerminologyForm
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(TerminologyForm));
			toolTip = new ToolTip(components);
			toolStripContainer = new ToolStripContainer();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			splitContainer = new KryptonSplitContainer();
			listBox = new KryptonListBox();
			webBrowser = new KryptonWebBrowser();
			kryptonManager = new KryptonManager(components);
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			statusStrip.SuspendLayout();
			((ISupportInitialize)splitContainer).BeginInit();
			(splitContainer.Panel1).BeginInit();
			splitContainer.Panel1.SuspendLayout();
			(splitContainer.Panel2).BeginInit();
			splitContainer.Panel2.SuspendLayout();
			SuspendLayout();
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Container to arrange the toolbars";
			toolStripContainer.AccessibleName = "Container to arrange the toolbars";
			toolStripContainer.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(splitContainer);
			toolStripContainer.ContentPanel.Size = new Size(609, 503);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(609, 525);
			toolStripContainer.TabIndex = 5;
			toolStripContainer.Text = "toolStripContainer";
			toolTip.SetToolTip(toolStripContainer, "Container to arrange the toolbars");
			toolStripContainer.TopToolStripPanelVisible = false;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar with some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(609, 22);
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
			// splitContainer
			// 
			splitContainer.AccessibleDescription = "Splits the pane in half with the list of terms you can look up and in the other half with the web browser";
			splitContainer.AccessibleName = "Splits the pane in half with the list of terms you can look up and in the other half with the web browser";
			splitContainer.AccessibleRole = AccessibleRole.Pane;
			splitContainer.ContainerBackStyle = PaletteBackStyle.FormMain;
			splitContainer.Dock = DockStyle.Fill;
			splitContainer.Location = new Point(0, 0);
			// 
			// 
			// 
			splitContainer.Panel1.Controls.Add(listBox);
			// 
			// 
			// 
			splitContainer.Panel2.Controls.Add(webBrowser);
			splitContainer.SeparatorStyle = SeparatorStyle.HighProfile;
			splitContainer.Size = new Size(609, 503);
			splitContainer.SplitterDistance = 263;
			splitContainer.TabIndex = 8;
			toolTip.SetToolTip(splitContainer, "Splits the pane in half with the list of terms you can look up and in the other half with the web browser");
			// 
			// listBox
			// 
			listBox.AccessibleDescription = "Lists the terms that can be looked up";
			listBox.AccessibleName = "Terms that can be looked up";
			listBox.AccessibleRole = AccessibleRole.List;
			listBox.BackStyle = PaletteBackStyle.PanelClient;
			listBox.Dock = DockStyle.Fill;
			listBox.Items.AddRange(new object[] { "Index No.", "Readable designation", "Epoch (in packed form, .0 TT)", "Mean anomaly at the epoch", "Argument of perihelion, J2000.0", "Longitude of the ascending node, J2000.0", "Inclination to the ecliptic, J2000.0", "Orbital eccentricity", "Mean daily motion", "Semi-major axis", "Absolute magnitude, H", "Slope parameter, G", "Reference", "Number of oppositions", "Number of observations", "Observation span", "r.m.s. residual", "Computer name", "4-hexdigit flags", "Date of last observation", "Linear eccentricity", "Semi-minor axis", "Major axis", "Minor axis", "Eccenctric anomaly", "True anomaly", "Perihelion distance", "Aphelion distance", "Longitude of the descending node", "Argument of aphelion", "Focal parameter", "Semi-latus rectum", "Latus rectum", "Orbital period", "Orbital area", "Orbital perimeter", "Semi-mean axis", "Mean axis", "Standard gravitational parameter" });
			listBox.Location = new Point(0, 0);
			listBox.Name = "listBox";
			listBox.Size = new Size(263, 503);
			listBox.TabIndex = 7;
			toolTip.SetToolTip(listBox, "Terms that can be looked up");
			listBox.SelectedValueChanged += ListBox_SelectedValueChanged;
			listBox.Enter += SetStatusBar_Enter;
			listBox.Leave += ClearStatusBar_Leave;
			listBox.MouseEnter += SetStatusBar_Enter;
			listBox.MouseLeave += ClearStatusBar_Leave;
			// 
			// webBrowser
			// 
			webBrowser.AccessibleDescription = "Informs about some definitions";
			webBrowser.AccessibleName = "Webbrowser";
			webBrowser.AccessibleRole = AccessibleRole.Document;
			webBrowser.Dock = DockStyle.Fill;
			webBrowser.Location = new Point(0, 0);
			webBrowser.Name = "webBrowser";
			webBrowser.Size = new Size(341, 503);
			webBrowser.TabIndex = 1;
			toolTip.SetToolTip(webBrowser, "Webbrowser");
			// 
			// kryptonManager
			// 
			kryptonManager.GlobalPaletteMode = PaletteMode.Global;
			// 
			// TerminologyForm
			// 
			AccessibleDescription = "Informs about some definitions";
			AccessibleName = "Terminology";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(609, 525);
			Controls.Add(toolStripContainer);
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "TerminologyForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Terminology";
			FormClosed += TerminologyForm_FormClosed;
			Load += TerminologyForm_Load;
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			(splitContainer.Panel1).EndInit();
			splitContainer.Panel1.ResumeLayout(false);
			(splitContainer.Panel2).EndInit();
			splitContainer.Panel2.ResumeLayout(false);
			((ISupportInitialize)splitContainer).EndInit();
			ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTip;
		private KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolStripContainer toolStripContainer;
		private KryptonSplitContainer splitContainer;
		private KryptonListBox listBox;
		private KryptonWebBrowser webBrowser;
		private KryptonManager kryptonManager;
	}
}