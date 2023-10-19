using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class CheckMpcorbDatForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckMpcorbDatForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelUpdateNeeded = new Krypton.Toolkit.KryptonLabel();
			this.labelMpcorbDatLocal = new Krypton.Toolkit.KryptonLabel();
			this.labelMpcorbDatOnline = new Krypton.Toolkit.KryptonLabel();
			this.labelContentLengthText = new Krypton.Toolkit.KryptonLabel();
			this.labelModifiedDateText = new Krypton.Toolkit.KryptonLabel();
			this.labelContentLengthValueLocal = new Krypton.Toolkit.KryptonLabel();
			this.labelModifiedDateValueLocal = new Krypton.Toolkit.KryptonLabel();
			this.labelContentLengthValueOnline = new Krypton.Toolkit.KryptonLabel();
			this.labelModifiedDateValueOnline = new Krypton.Toolkit.KryptonLabel();
			this.tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.tableLayoutPanel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelUpdateNeeded
			// 
			this.labelUpdateNeeded.AccessibleDescription = "Informs if an update is recommended";
			this.labelUpdateNeeded.AccessibleName = "Update text";
			this.labelUpdateNeeded.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.tableLayoutPanel.SetColumnSpan(this.labelUpdateNeeded, 3);
			this.labelUpdateNeeded.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelUpdateNeeded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUpdateNeeded.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
			this.labelUpdateNeeded.Location = new System.Drawing.Point(3, 81);
			this.labelUpdateNeeded.Name = "labelUpdateNeeded";
			this.labelUpdateNeeded.Size = new System.Drawing.Size(366, 29);
			this.labelUpdateNeeded.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelUpdateNeeded, "Informs if an update is recommended");
			this.labelUpdateNeeded.Values.Image = global::Planetoid_DB.Properties.Resources.silk_help;
			this.labelUpdateNeeded.Values.Text = "Update needed?";
			this.labelUpdateNeeded.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelUpdateNeeded.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelUpdateNeeded.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelUpdateNeeded.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMpcorbDatLocal
			// 
			this.labelMpcorbDatLocal.AccessibleDescription = "Information about the local MPCORB.DAT file";
			this.labelMpcorbDatLocal.AccessibleName = "Local MPCORB.DAT file";
			this.labelMpcorbDatLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMpcorbDatLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMpcorbDatLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMpcorbDatLocal.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.labelMpcorbDatLocal.Location = new System.Drawing.Point(110, 3);
			this.labelMpcorbDatLocal.Name = "labelMpcorbDatLocal";
			this.labelMpcorbDatLocal.Size = new System.Drawing.Size(122, 20);
			this.labelMpcorbDatLocal.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelMpcorbDatLocal, "Information about the local MPCORB.DAT file");
			this.labelMpcorbDatLocal.Values.Text = "MPCORB.DAT local";
			this.labelMpcorbDatLocal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatLocal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMpcorbDatLocal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatLocal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMpcorbDatOnline
			// 
			this.labelMpcorbDatOnline.AccessibleDescription = "Information about the online MPCORB.DAT file";
			this.labelMpcorbDatOnline.AccessibleName = "Online MPCORB.DAT file";
			this.labelMpcorbDatOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMpcorbDatOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMpcorbDatOnline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMpcorbDatOnline.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.labelMpcorbDatOnline.Location = new System.Drawing.Point(238, 3);
			this.labelMpcorbDatOnline.Name = "labelMpcorbDatOnline";
			this.labelMpcorbDatOnline.Size = new System.Drawing.Size(131, 20);
			this.labelMpcorbDatOnline.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelMpcorbDatOnline, "Information about the online MPCORB.DAT file");
			this.labelMpcorbDatOnline.Values.Text = "MPCORB.DAT online";
			this.labelMpcorbDatOnline.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatOnline.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMpcorbDatOnline.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatOnline.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelContentLengthText
			// 
			this.labelContentLengthText.AccessibleDescription = "Shows the content length";
			this.labelContentLengthText.AccessibleName = "Content length";
			this.labelContentLengthText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelContentLengthText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.labelContentLengthText.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.labelContentLengthText.Location = new System.Drawing.Point(3, 29);
			this.labelContentLengthText.Name = "labelContentLengthText";
			this.labelContentLengthText.Size = new System.Drawing.Size(101, 20);
			this.labelContentLengthText.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelContentLengthText, "Shows the content length");
			this.labelContentLengthText.Values.Text = "Content length:";
			this.labelContentLengthText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelContentLengthText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelModifiedDateText
			// 
			this.labelModifiedDateText.AccessibleDescription = "Shows the modified date";
			this.labelModifiedDateText.AccessibleName = "Modified date";
			this.labelModifiedDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelModifiedDateText.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelModifiedDateText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.labelModifiedDateText.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.labelModifiedDateText.Location = new System.Drawing.Point(3, 55);
			this.labelModifiedDateText.Name = "labelModifiedDateText";
			this.labelModifiedDateText.Size = new System.Drawing.Size(96, 20);
			this.labelModifiedDateText.TabIndex = 5;
			this.toolTip.SetToolTip(this.labelModifiedDateText, "Shows the modified date");
			this.labelModifiedDateText.Values.Text = "Modified date:";
			this.labelModifiedDateText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelModifiedDateText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelContentLengthValueLocal
			// 
			this.labelContentLengthValueLocal.AccessibleDescription = "Shows the local content length";
			this.labelContentLengthValueLocal.AccessibleName = "Local content length";
			this.labelContentLengthValueLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelContentLengthValueLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContentLengthValueLocal.Location = new System.Drawing.Point(110, 29);
			this.labelContentLengthValueLocal.Name = "labelContentLengthValueLocal";
			this.labelContentLengthValueLocal.Size = new System.Drawing.Size(122, 20);
			this.labelContentLengthValueLocal.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelContentLengthValueLocal, "Shows the local content length");
			this.labelContentLengthValueLocal.Values.Text = "123456789 bytes";
			this.labelContentLengthValueLocal.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelContentLengthValueLocal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueLocal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelContentLengthValueLocal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueLocal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelModifiedDateValueLocal
			// 
			this.labelModifiedDateValueLocal.AccessibleDescription = "Shows the local modified date";
			this.labelModifiedDateValueLocal.AccessibleName = "Local modified date";
			this.labelModifiedDateValueLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelModifiedDateValueLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifiedDateValueLocal.Location = new System.Drawing.Point(110, 55);
			this.labelModifiedDateValueLocal.Name = "labelModifiedDateValueLocal";
			this.labelModifiedDateValueLocal.Size = new System.Drawing.Size(122, 20);
			this.labelModifiedDateValueLocal.TabIndex = 6;
			this.toolTip.SetToolTip(this.labelModifiedDateValueLocal, "Shows the local modified date");
			this.labelModifiedDateValueLocal.Values.Text = "00.00.0000 00:00";
			this.labelModifiedDateValueLocal.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelModifiedDateValueLocal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueLocal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelModifiedDateValueLocal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueLocal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelContentLengthValueOnline
			// 
			this.labelContentLengthValueOnline.AccessibleDescription = "Shows the online content length";
			this.labelContentLengthValueOnline.AccessibleName = "Online content length";
			this.labelContentLengthValueOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelContentLengthValueOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContentLengthValueOnline.Location = new System.Drawing.Point(238, 29);
			this.labelContentLengthValueOnline.Name = "labelContentLengthValueOnline";
			this.labelContentLengthValueOnline.Size = new System.Drawing.Size(131, 20);
			this.labelContentLengthValueOnline.TabIndex = 4;
			this.toolTip.SetToolTip(this.labelContentLengthValueOnline, "Shows the online content length");
			this.labelContentLengthValueOnline.Values.Text = "123456789 bytes";
			this.labelContentLengthValueOnline.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelContentLengthValueOnline.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueOnline.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelContentLengthValueOnline.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueOnline.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelModifiedDateValueOnline
			// 
			this.labelModifiedDateValueOnline.AccessibleDescription = "Shows the online modified date";
			this.labelModifiedDateValueOnline.AccessibleName = "Online Modified date";
			this.labelModifiedDateValueOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelModifiedDateValueOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifiedDateValueOnline.Location = new System.Drawing.Point(238, 55);
			this.labelModifiedDateValueOnline.Name = "labelModifiedDateValueOnline";
			this.labelModifiedDateValueOnline.Size = new System.Drawing.Size(131, 20);
			this.labelModifiedDateValueOnline.TabIndex = 7;
			this.toolTip.SetToolTip(this.labelModifiedDateValueOnline, "Shows the online modified date");
			this.labelModifiedDateValueOnline.Values.Text = "00.00.0000 00:00";
			this.labelModifiedDateValueOnline.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelModifiedDateValueOnline.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueOnline.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelModifiedDateValueOnline.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueOnline.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Groups the data";
			this.tableLayoutPanel.AccessibleName = "Group pane";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel.BackgroundImage")));
			this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel.ColumnCount = 3;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.labelMpcorbDatLocal, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelMpcorbDatOnline, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.labelContentLengthText, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelModifiedDateText, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelContentLengthValueLocal, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelModifiedDateValueLocal, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelContentLengthValueOnline, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.labelModifiedDateValueOnline, 2, 2);
			this.tableLayoutPanel.Controls.Add(this.labelUpdateNeeded, 0, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(372, 86);
			this.tableLayoutPanel.TabIndex = 0;
			this.toolTip.SetToolTip(this.tableLayoutPanel, "Groups the data");
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(372, 22);
			this.statusStrip.TabIndex = 0;
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
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(372, 86);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(372, 133);
			this.toolStripContainer.TabIndex = 3;
			this.toolStripContainer.Text = "toolStripContainer";
			this.toolTip.SetToolTip(this.toolStripContainer, "Container to arrange the toolbars");
			// 
			// CheckMpcorbDatForm
			// 
			this.AccessibleDescription = "Shows the informations about the MPCORB.DAT database local and online";
			this.AccessibleName = "Check MPCORB.DAT";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 133);
			this.Controls.Add(this.toolStripContainer);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CheckMpcorbDatForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Check MPCORB.DAT";
			this.toolTip.SetToolTip(this, "Check MPCORB.DAT");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckMpcorbDatForm_FormClosed);
			this.Load += new System.EventHandler(this.CheckMpcorbDatForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private KryptonTableLayoutPanel tableLayoutPanel;
		private KryptonLabel labelUpdateNeeded;
		private KryptonLabel labelMpcorbDatLocal;
		private KryptonLabel labelMpcorbDatOnline;
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