using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class CheckAstorbDatForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAstorbDatForm));
			toolTip = new ToolTip(components);
			labelUpdateNeeded = new KryptonLabel();
			labelAstorbDatLocal = new KryptonLabel();
			labelAstorbDatOnline = new KryptonLabel();
			labelContentLengthText = new KryptonLabel();
			labelModifiedDateText = new KryptonLabel();
			labelContentLengthValueLocal = new KryptonLabel();
			labelModifiedDateValueLocal = new KryptonLabel();
			labelContentLengthValueOnline = new KryptonLabel();
			labelModifiedDateValueOnline = new KryptonLabel();
			tableLayoutPanel = new KryptonTableLayoutPanel();
			toolStripContainer = new ToolStripContainer();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			tableLayoutPanel.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// labelUpdateNeeded
			// 
			labelUpdateNeeded.AccessibleDescription = "Informs if an update is recommended";
			labelUpdateNeeded.AccessibleName = "Update text";
			labelUpdateNeeded.AccessibleRole = AccessibleRole.Text;
			tableLayoutPanel.SetColumnSpan(labelUpdateNeeded, 3);
			labelUpdateNeeded.Dock = DockStyle.Fill;
			labelUpdateNeeded.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelUpdateNeeded.LabelStyle = LabelStyle.TitleControl;
			labelUpdateNeeded.Location = new Point(3, 81);
			labelUpdateNeeded.Name = "labelUpdateNeeded";
			labelUpdateNeeded.Size = new Size(366, 29);
			labelUpdateNeeded.TabIndex = 8;
			toolTip.SetToolTip(labelUpdateNeeded, "Informs if an update is recommended");
			labelUpdateNeeded.Values.Image = Properties.Resources.silk_help;
			labelUpdateNeeded.Values.Text = "Update needed?";
			labelUpdateNeeded.DoubleClick += LabelUpdateNeeded_DoubleClick;
			labelUpdateNeeded.Enter += SetStatusbar_Enter;
			labelUpdateNeeded.Leave += ClearStatusbar_Leave;
			labelUpdateNeeded.MouseEnter += SetStatusbar_Enter;
			labelUpdateNeeded.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAstorbDatLocal
			// 
			labelAstorbDatLocal.AccessibleDescription = "Information about the local ASTORB.DAT file";
			labelAstorbDatLocal.AccessibleName = "Local ASTORB.DAT file";
			labelAstorbDatLocal.AccessibleRole = AccessibleRole.Text;
			labelAstorbDatLocal.Dock = DockStyle.Fill;
			labelAstorbDatLocal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			labelAstorbDatLocal.LabelStyle = LabelStyle.BoldControl;
			labelAstorbDatLocal.Location = new Point(110, 3);
			labelAstorbDatLocal.Name = "labelAstorbDatLocal";
			labelAstorbDatLocal.Size = new Size(118, 20);
			labelAstorbDatLocal.TabIndex = 0;
			toolTip.SetToolTip(labelAstorbDatLocal, "Information about the local ASTORB.DAT file");
			labelAstorbDatLocal.Values.Text = "ASTORB.DAT local";
			labelAstorbDatLocal.Enter += SetStatusbar_Enter;
			labelAstorbDatLocal.Leave += ClearStatusbar_Leave;
			labelAstorbDatLocal.MouseEnter += SetStatusbar_Enter;
			labelAstorbDatLocal.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAstorbDatOnline
			// 
			labelAstorbDatOnline.AccessibleDescription = "Information about the online ASTORB.DAT file";
			labelAstorbDatOnline.AccessibleName = "Online ASTORB.DAT file";
			labelAstorbDatOnline.AccessibleRole = AccessibleRole.Text;
			labelAstorbDatOnline.Dock = DockStyle.Fill;
			labelAstorbDatOnline.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			labelAstorbDatOnline.LabelStyle = LabelStyle.BoldControl;
			labelAstorbDatOnline.Location = new Point(234, 3);
			labelAstorbDatOnline.Name = "labelAstorbDatOnline";
			labelAstorbDatOnline.Size = new Size(135, 20);
			labelAstorbDatOnline.TabIndex = 1;
			toolTip.SetToolTip(labelAstorbDatOnline, "Information about the online ASTORB.DAT file");
			labelAstorbDatOnline.Values.Text = "ASTORB.DAT online";
			labelAstorbDatOnline.Enter += SetStatusbar_Enter;
			labelAstorbDatOnline.Leave += ClearStatusbar_Leave;
			labelAstorbDatOnline.MouseEnter += SetStatusbar_Enter;
			labelAstorbDatOnline.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelContentLengthText
			// 
			labelContentLengthText.AccessibleDescription = "Shows the content length";
			labelContentLengthText.AccessibleName = "Content length";
			labelContentLengthText.AccessibleRole = AccessibleRole.Text;
			labelContentLengthText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			labelContentLengthText.LabelStyle = LabelStyle.BoldControl;
			labelContentLengthText.Location = new Point(3, 29);
			labelContentLengthText.Name = "labelContentLengthText";
			labelContentLengthText.Size = new Size(101, 20);
			labelContentLengthText.TabIndex = 2;
			toolTip.SetToolTip(labelContentLengthText, "Shows the content length");
			labelContentLengthText.Values.Text = "Content length:";
			labelContentLengthText.Enter += SetStatusbar_Enter;
			labelContentLengthText.Leave += ClearStatusbar_Leave;
			labelContentLengthText.MouseEnter += SetStatusbar_Enter;
			labelContentLengthText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelModifiedDateText
			// 
			labelModifiedDateText.AccessibleDescription = "Shows the modified date";
			labelModifiedDateText.AccessibleName = "Modified date";
			labelModifiedDateText.AccessibleRole = AccessibleRole.Text;
			labelModifiedDateText.Dock = DockStyle.Left;
			labelModifiedDateText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			labelModifiedDateText.LabelStyle = LabelStyle.BoldControl;
			labelModifiedDateText.Location = new Point(3, 55);
			labelModifiedDateText.Name = "labelModifiedDateText";
			labelModifiedDateText.Size = new Size(96, 20);
			labelModifiedDateText.TabIndex = 5;
			toolTip.SetToolTip(labelModifiedDateText, "Shows the modified date");
			labelModifiedDateText.Values.Text = "Modified date:";
			labelModifiedDateText.Enter += SetStatusbar_Enter;
			labelModifiedDateText.Leave += ClearStatusbar_Leave;
			labelModifiedDateText.MouseEnter += SetStatusbar_Enter;
			labelModifiedDateText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelContentLengthValueLocal
			// 
			labelContentLengthValueLocal.AccessibleDescription = "Shows the local content length";
			labelContentLengthValueLocal.AccessibleName = "Local content length";
			labelContentLengthValueLocal.AccessibleRole = AccessibleRole.Text;
			labelContentLengthValueLocal.Dock = DockStyle.Fill;
			labelContentLengthValueLocal.Location = new Point(110, 29);
			labelContentLengthValueLocal.Name = "labelContentLengthValueLocal";
			labelContentLengthValueLocal.Size = new Size(118, 20);
			labelContentLengthValueLocal.TabIndex = 3;
			toolTip.SetToolTip(labelContentLengthValueLocal, "Shows the local content length");
			labelContentLengthValueLocal.Values.Text = "123456789 bytes";
			labelContentLengthValueLocal.DoubleClick += CopyToClipboard_DoubleClick;
			labelContentLengthValueLocal.Enter += SetStatusbar_Enter;
			labelContentLengthValueLocal.Leave += ClearStatusbar_Leave;
			labelContentLengthValueLocal.MouseEnter += SetStatusbar_Enter;
			labelContentLengthValueLocal.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelModifiedDateValueLocal
			// 
			labelModifiedDateValueLocal.AccessibleDescription = "Shows the local modified date";
			labelModifiedDateValueLocal.AccessibleName = "Local modified date";
			labelModifiedDateValueLocal.AccessibleRole = AccessibleRole.Text;
			labelModifiedDateValueLocal.Dock = DockStyle.Fill;
			labelModifiedDateValueLocal.Location = new Point(110, 55);
			labelModifiedDateValueLocal.Name = "labelModifiedDateValueLocal";
			labelModifiedDateValueLocal.Size = new Size(118, 20);
			labelModifiedDateValueLocal.TabIndex = 6;
			toolTip.SetToolTip(labelModifiedDateValueLocal, "Shows the local modified date");
			labelModifiedDateValueLocal.Values.Text = "00.00.0000 00:00";
			labelModifiedDateValueLocal.DoubleClick += CopyToClipboard_DoubleClick;
			labelModifiedDateValueLocal.Enter += SetStatusbar_Enter;
			labelModifiedDateValueLocal.Leave += ClearStatusbar_Leave;
			labelModifiedDateValueLocal.MouseEnter += SetStatusbar_Enter;
			labelModifiedDateValueLocal.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelContentLengthValueOnline
			// 
			labelContentLengthValueOnline.AccessibleDescription = "Shows the online content length";
			labelContentLengthValueOnline.AccessibleName = "Online content length";
			labelContentLengthValueOnline.AccessibleRole = AccessibleRole.Text;
			labelContentLengthValueOnline.Dock = DockStyle.Fill;
			labelContentLengthValueOnline.Location = new Point(234, 29);
			labelContentLengthValueOnline.Name = "labelContentLengthValueOnline";
			labelContentLengthValueOnline.Size = new Size(135, 20);
			labelContentLengthValueOnline.TabIndex = 4;
			toolTip.SetToolTip(labelContentLengthValueOnline, "Shows the online content length");
			labelContentLengthValueOnline.Values.Text = "123456789 bytes";
			labelContentLengthValueOnline.DoubleClick += CopyToClipboard_DoubleClick;
			labelContentLengthValueOnline.Enter += SetStatusbar_Enter;
			labelContentLengthValueOnline.Leave += ClearStatusbar_Leave;
			labelContentLengthValueOnline.MouseEnter += SetStatusbar_Enter;
			labelContentLengthValueOnline.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelModifiedDateValueOnline
			// 
			labelModifiedDateValueOnline.AccessibleDescription = "Shows the online modified date";
			labelModifiedDateValueOnline.AccessibleName = "Online Modified date";
			labelModifiedDateValueOnline.AccessibleRole = AccessibleRole.Text;
			labelModifiedDateValueOnline.Dock = DockStyle.Fill;
			labelModifiedDateValueOnline.Location = new Point(234, 55);
			labelModifiedDateValueOnline.Name = "labelModifiedDateValueOnline";
			labelModifiedDateValueOnline.Size = new Size(135, 20);
			labelModifiedDateValueOnline.TabIndex = 7;
			toolTip.SetToolTip(labelModifiedDateValueOnline, "Shows the online modified date");
			labelModifiedDateValueOnline.Values.Text = "00.00.0000 00:00";
			labelModifiedDateValueOnline.DoubleClick += CopyToClipboard_DoubleClick;
			labelModifiedDateValueOnline.Enter += SetStatusbar_Enter;
			labelModifiedDateValueOnline.Leave += ClearStatusbar_Leave;
			labelModifiedDateValueOnline.MouseEnter += SetStatusbar_Enter;
			labelModifiedDateValueOnline.MouseLeave += ClearStatusbar_Leave;
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Groups the data";
			tableLayoutPanel.AccessibleName = "Group pane";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanel.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel.BackgroundImage");
			tableLayoutPanel.BackgroundImageLayout = ImageLayout.None;
			tableLayoutPanel.ColumnCount = 3;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.Controls.Add(labelAstorbDatLocal, 1, 0);
			tableLayoutPanel.Controls.Add(labelAstorbDatOnline, 2, 0);
			tableLayoutPanel.Controls.Add(labelContentLengthText, 0, 1);
			tableLayoutPanel.Controls.Add(labelModifiedDateText, 0, 2);
			tableLayoutPanel.Controls.Add(labelContentLengthValueLocal, 1, 1);
			tableLayoutPanel.Controls.Add(labelModifiedDateValueLocal, 1, 2);
			tableLayoutPanel.Controls.Add(labelContentLengthValueOnline, 2, 1);
			tableLayoutPanel.Controls.Add(labelModifiedDateValueOnline, 2, 2);
			tableLayoutPanel.Controls.Add(labelUpdateNeeded, 0, 3);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.PanelBackStyle = PaletteBackStyle.FormMain;
			tableLayoutPanel.RowCount = 4;
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.Size = new Size(372, 111);
			tableLayoutPanel.TabIndex = 0;
			toolTip.SetToolTip(tableLayoutPanel, "Groups the data");
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
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanel);
			toolStripContainer.ContentPanel.Size = new Size(372, 111);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(372, 133);
			toolStripContainer.TabIndex = 3;
			toolStripContainer.Text = "toolStripContainer";
			toolTip.SetToolTip(toolStripContainer, "Container to arrange the toolbars");
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(372, 22);
			statusStrip.TabIndex = 0;
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
			// CheckAstorbDatForm
			// 
			AccessibleDescription = "Shows the informations about the ASTORB.DAT database local and online";
			AccessibleName = "Check ASTORB.DAT";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 133);
			Controls.Add(toolStripContainer);
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CheckAstorbDatForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Check ASTORB.DAT";
			toolTip.SetToolTip(this, "Check ASTORB.DAT");
			FormClosed += CheckAstorbDatForm_FormClosed;
			Load += CheckAstorbDatForm_Load;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private KryptonTableLayoutPanel tableLayoutPanel;
		private KryptonLabel labelUpdateNeeded;
		private KryptonLabel labelAstorbDatLocal;
		private KryptonLabel labelAstorbDatOnline;
		private KryptonLabel labelContentLengthText;
		private KryptonLabel labelModifiedDateText;
		private KryptonLabel labelContentLengthValueLocal;
		private KryptonLabel labelModifiedDateValueLocal;
		private KryptonLabel labelContentLengthValueOnline;
		private KryptonLabel labelModifiedDateValueOnline;
		private KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
	}
}