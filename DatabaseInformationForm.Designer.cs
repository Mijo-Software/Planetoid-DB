﻿using System.ComponentModel;
using Krypton.Toolkit;

namespace Planetoid_DB
{
  partial class DatabaseInformationForm
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(DatabaseInformationForm));
			toolTip = new ToolTip(components);
			labelName = new KryptonLabel();
			labelDirectory = new KryptonLabel();
			labelSize = new KryptonLabel();
			labelDateCreated = new KryptonLabel();
			labelDateAccessed = new KryptonLabel();
			labelDateWrited = new KryptonLabel();
			labelAttributes = new KryptonLabel();
			labelNameValue = new KryptonLabel();
			labelDirectoryValue = new KryptonLabel();
			labelSizeValue = new KryptonLabel();
			labelDateCreatedValue = new KryptonLabel();
			labelDateAccessedValue = new KryptonLabel();
			labelDateWritedValue = new KryptonLabel();
			labelAttributesValue = new KryptonLabel();
			tableLayoutPanel = new KryptonTableLayoutPanel();
			toolStripContainer = new ToolStripContainer();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			kryptonManager = new KryptonManager(components);
			tableLayoutPanel.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// labelName
			// 
			labelName.AccessibleDescription = "Shows the name of the database";
			labelName.AccessibleName = "Name";
			labelName.AccessibleRole = AccessibleRole.Text;
			labelName.Dock = DockStyle.Fill;
			labelName.LabelStyle = LabelStyle.BoldPanel;
			labelName.Location = new Point(3, 3);
			labelName.Name = "labelName";
			labelName.Size = new Size(102, 20);
			labelName.TabIndex = 0;
			toolTip.SetToolTip(labelName, "Name");
			labelName.Values.Text = "Name";
			labelName.DoubleClick += CopyToClipboard_DoubleClick;
			labelName.Enter += SetStatusBar_Enter;
			labelName.Leave += ClearStatusBar_Leave;
			labelName.MouseEnter += SetStatusBar_Enter;
			labelName.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDirectory
			// 
			labelDirectory.AccessibleDescription = "Shows the directory of the database";
			labelDirectory.AccessibleName = "Directory";
			labelDirectory.AccessibleRole = AccessibleRole.Text;
			labelDirectory.Dock = DockStyle.Fill;
			labelDirectory.LabelStyle = LabelStyle.BoldPanel;
			labelDirectory.Location = new Point(3, 29);
			labelDirectory.Name = "labelDirectory";
			labelDirectory.Size = new Size(102, 20);
			labelDirectory.TabIndex = 2;
			toolTip.SetToolTip(labelDirectory, "Directory");
			labelDirectory.Values.Text = "Directory";
			labelDirectory.DoubleClick += CopyToClipboard_DoubleClick;
			labelDirectory.Enter += SetStatusBar_Enter;
			labelDirectory.Leave += ClearStatusBar_Leave;
			labelDirectory.MouseEnter += SetStatusBar_Enter;
			labelDirectory.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelSize
			// 
			labelSize.AccessibleDescription = "Shows the size of the database";
			labelSize.AccessibleName = "Size";
			labelSize.AccessibleRole = AccessibleRole.Text;
			labelSize.Dock = DockStyle.Fill;
			labelSize.LabelStyle = LabelStyle.BoldPanel;
			labelSize.Location = new Point(3, 55);
			labelSize.Name = "labelSize";
			labelSize.Size = new Size(102, 20);
			labelSize.TabIndex = 4;
			toolTip.SetToolTip(labelSize, "Size");
			labelSize.Values.Text = "Size";
			labelSize.DoubleClick += CopyToClipboard_DoubleClick;
			labelSize.Enter += SetStatusBar_Enter;
			labelSize.Leave += ClearStatusBar_Leave;
			labelSize.MouseEnter += SetStatusBar_Enter;
			labelSize.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateCreated
			// 
			labelDateCreated.AccessibleDescription = "Shows the creation date of the database";
			labelDateCreated.AccessibleName = "Creation date";
			labelDateCreated.AccessibleRole = AccessibleRole.Text;
			labelDateCreated.Dock = DockStyle.Fill;
			labelDateCreated.LabelStyle = LabelStyle.BoldPanel;
			labelDateCreated.Location = new Point(3, 81);
			labelDateCreated.Name = "labelDateCreated";
			labelDateCreated.Size = new Size(102, 20);
			labelDateCreated.TabIndex = 6;
			toolTip.SetToolTip(labelDateCreated, "Creation date");
			labelDateCreated.Values.Text = "Creation date";
			labelDateCreated.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateCreated.Enter += SetStatusBar_Enter;
			labelDateCreated.Leave += ClearStatusBar_Leave;
			labelDateCreated.MouseEnter += SetStatusBar_Enter;
			labelDateCreated.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateAccessed
			// 
			labelDateAccessed.AccessibleDescription = "Shows the last access date of the database";
			labelDateAccessed.AccessibleName = "Last access date";
			labelDateAccessed.AccessibleRole = AccessibleRole.Text;
			labelDateAccessed.Dock = DockStyle.Fill;
			labelDateAccessed.LabelStyle = LabelStyle.BoldPanel;
			labelDateAccessed.Location = new Point(3, 107);
			labelDateAccessed.Name = "labelDateAccessed";
			labelDateAccessed.Size = new Size(102, 20);
			labelDateAccessed.TabIndex = 8;
			toolTip.SetToolTip(labelDateAccessed, "Last access date");
			labelDateAccessed.Values.Text = "Last access date";
			labelDateAccessed.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateAccessed.Enter += SetStatusBar_Enter;
			labelDateAccessed.Leave += ClearStatusBar_Leave;
			labelDateAccessed.MouseEnter += SetStatusBar_Enter;
			labelDateAccessed.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateWrited
			// 
			labelDateWrited.AccessibleDescription = "Shows the last write date of the database";
			labelDateWrited.AccessibleName = "Last write date";
			labelDateWrited.AccessibleRole = AccessibleRole.Text;
			labelDateWrited.Dock = DockStyle.Fill;
			labelDateWrited.LabelStyle = LabelStyle.BoldPanel;
			labelDateWrited.Location = new Point(3, 133);
			labelDateWrited.Name = "labelDateWrited";
			labelDateWrited.Size = new Size(102, 20);
			labelDateWrited.TabIndex = 10;
			toolTip.SetToolTip(labelDateWrited, "Last write date");
			labelDateWrited.Values.Text = "Last write date";
			labelDateWrited.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateWrited.Enter += SetStatusBar_Enter;
			labelDateWrited.Leave += ClearStatusBar_Leave;
			labelDateWrited.MouseEnter += SetStatusBar_Enter;
			labelDateWrited.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelAttributes
			// 
			labelAttributes.AccessibleDescription = "Shows the attributes of the database";
			labelAttributes.AccessibleName = "Attributes";
			labelAttributes.AccessibleRole = AccessibleRole.Text;
			labelAttributes.Dock = DockStyle.Fill;
			labelAttributes.LabelStyle = LabelStyle.BoldPanel;
			labelAttributes.Location = new Point(3, 159);
			labelAttributes.Name = "labelAttributes";
			labelAttributes.Size = new Size(102, 25);
			labelAttributes.TabIndex = 12;
			toolTip.SetToolTip(labelAttributes, "Attributes");
			labelAttributes.Values.Text = "Attributes";
			labelAttributes.DoubleClick += CopyToClipboard_DoubleClick;
			labelAttributes.Enter += SetStatusBar_Enter;
			labelAttributes.Leave += ClearStatusBar_Leave;
			labelAttributes.MouseEnter += SetStatusBar_Enter;
			labelAttributes.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelNameValue
			// 
			labelNameValue.AccessibleDescription = "Shows the name of the database";
			labelNameValue.AccessibleName = "Name value";
			labelNameValue.AccessibleRole = AccessibleRole.Text;
			labelNameValue.Dock = DockStyle.Fill;
			labelNameValue.Location = new Point(111, 3);
			labelNameValue.Name = "labelNameValue";
			labelNameValue.Size = new Size(375, 20);
			labelNameValue.TabIndex = 1;
			toolTip.SetToolTip(labelNameValue, "Shows the name of the database");
			labelNameValue.Values.Text = "..........";
			labelNameValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelNameValue.Enter += SetStatusBar_Enter;
			labelNameValue.Leave += ClearStatusBar_Leave;
			labelNameValue.MouseEnter += SetStatusBar_Enter;
			labelNameValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDirectoryValue
			// 
			labelDirectoryValue.AccessibleDescription = "Shows the directory of the database";
			labelDirectoryValue.AccessibleName = "Directory value";
			labelDirectoryValue.AccessibleRole = AccessibleRole.Text;
			labelDirectoryValue.Dock = DockStyle.Fill;
			labelDirectoryValue.Location = new Point(111, 29);
			labelDirectoryValue.Name = "labelDirectoryValue";
			labelDirectoryValue.Size = new Size(375, 20);
			labelDirectoryValue.TabIndex = 3;
			toolTip.SetToolTip(labelDirectoryValue, "Shows the directory of the database");
			labelDirectoryValue.Values.Text = "..........";
			labelDirectoryValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDirectoryValue.Enter += SetStatusBar_Enter;
			labelDirectoryValue.Leave += ClearStatusBar_Leave;
			labelDirectoryValue.MouseEnter += SetStatusBar_Enter;
			labelDirectoryValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelSizeValue
			// 
			labelSizeValue.AccessibleDescription = "Shows the size of the database";
			labelSizeValue.AccessibleName = "size value";
			labelSizeValue.AccessibleRole = AccessibleRole.Text;
			labelSizeValue.Dock = DockStyle.Fill;
			labelSizeValue.Location = new Point(111, 55);
			labelSizeValue.Name = "labelSizeValue";
			labelSizeValue.Size = new Size(375, 20);
			labelSizeValue.TabIndex = 5;
			toolTip.SetToolTip(labelSizeValue, "Shows the size of the database");
			labelSizeValue.Values.Text = "..........";
			labelSizeValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelSizeValue.Enter += SetStatusBar_Enter;
			labelSizeValue.Leave += ClearStatusBar_Leave;
			labelSizeValue.MouseEnter += SetStatusBar_Enter;
			labelSizeValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateCreatedValue
			// 
			labelDateCreatedValue.AccessibleDescription = "Shows the creation date of the database";
			labelDateCreatedValue.AccessibleName = "Creation date value";
			labelDateCreatedValue.AccessibleRole = AccessibleRole.Text;
			labelDateCreatedValue.Dock = DockStyle.Fill;
			labelDateCreatedValue.Location = new Point(111, 81);
			labelDateCreatedValue.Name = "labelDateCreatedValue";
			labelDateCreatedValue.Size = new Size(375, 20);
			labelDateCreatedValue.TabIndex = 7;
			toolTip.SetToolTip(labelDateCreatedValue, "Shows the creation date of the database");
			labelDateCreatedValue.Values.Text = "..........";
			labelDateCreatedValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateCreatedValue.Enter += SetStatusBar_Enter;
			labelDateCreatedValue.Leave += ClearStatusBar_Leave;
			labelDateCreatedValue.MouseEnter += SetStatusBar_Enter;
			labelDateCreatedValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateAccessedValue
			// 
			labelDateAccessedValue.AccessibleDescription = "Shows the last access date of the database";
			labelDateAccessedValue.AccessibleName = "Last access date value";
			labelDateAccessedValue.AccessibleRole = AccessibleRole.Text;
			labelDateAccessedValue.Dock = DockStyle.Fill;
			labelDateAccessedValue.Location = new Point(111, 107);
			labelDateAccessedValue.Name = "labelDateAccessedValue";
			labelDateAccessedValue.Size = new Size(375, 20);
			labelDateAccessedValue.TabIndex = 9;
			toolTip.SetToolTip(labelDateAccessedValue, "Shows the last access date of the database");
			labelDateAccessedValue.Values.Text = "..........";
			labelDateAccessedValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateAccessedValue.Enter += SetStatusBar_Enter;
			labelDateAccessedValue.Leave += ClearStatusBar_Leave;
			labelDateAccessedValue.MouseEnter += SetStatusBar_Enter;
			labelDateAccessedValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelDateWritedValue
			// 
			labelDateWritedValue.AccessibleDescription = "Shows the last write date of the database";
			labelDateWritedValue.AccessibleName = "Last write date value";
			labelDateWritedValue.AccessibleRole = AccessibleRole.Text;
			labelDateWritedValue.Dock = DockStyle.Fill;
			labelDateWritedValue.Location = new Point(111, 133);
			labelDateWritedValue.Name = "labelDateWritedValue";
			labelDateWritedValue.Size = new Size(375, 20);
			labelDateWritedValue.TabIndex = 11;
			toolTip.SetToolTip(labelDateWritedValue, "Shows the last write date of the database");
			labelDateWritedValue.Values.Text = "..........";
			labelDateWritedValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateWritedValue.Enter += SetStatusBar_Enter;
			labelDateWritedValue.Leave += ClearStatusBar_Leave;
			labelDateWritedValue.MouseEnter += SetStatusBar_Enter;
			labelDateWritedValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelAttributesValue
			// 
			labelAttributesValue.AccessibleDescription = "Shows the attributes of the database";
			labelAttributesValue.AccessibleName = "Attributes value";
			labelAttributesValue.AccessibleRole = AccessibleRole.Text;
			labelAttributesValue.Dock = DockStyle.Fill;
			labelAttributesValue.Location = new Point(111, 159);
			labelAttributesValue.Name = "labelAttributesValue";
			labelAttributesValue.Size = new Size(375, 25);
			labelAttributesValue.TabIndex = 13;
			toolTip.SetToolTip(labelAttributesValue, "Shows the attributes of the database");
			labelAttributesValue.Values.Text = "..........";
			labelAttributesValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelAttributesValue.Enter += SetStatusBar_Enter;
			labelAttributesValue.Leave += ClearStatusBar_Leave;
			labelAttributesValue.MouseEnter += SetStatusBar_Enter;
			labelAttributesValue.MouseLeave += ClearStatusBar_Leave;
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Groups the information";
			tableLayoutPanel.AccessibleName = "Information";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel.AutoScroll = true;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Controls.Add(labelName, 0, 0);
			tableLayoutPanel.Controls.Add(labelDirectory, 0, 1);
			tableLayoutPanel.Controls.Add(labelSize, 0, 2);
			tableLayoutPanel.Controls.Add(labelDateCreated, 0, 3);
			tableLayoutPanel.Controls.Add(labelDateAccessed, 0, 4);
			tableLayoutPanel.Controls.Add(labelDateWrited, 0, 5);
			tableLayoutPanel.Controls.Add(labelAttributes, 0, 6);
			tableLayoutPanel.Controls.Add(labelNameValue, 1, 0);
			tableLayoutPanel.Controls.Add(labelDirectoryValue, 1, 1);
			tableLayoutPanel.Controls.Add(labelSizeValue, 1, 2);
			tableLayoutPanel.Controls.Add(labelDateCreatedValue, 1, 3);
			tableLayoutPanel.Controls.Add(labelDateAccessedValue, 1, 4);
			tableLayoutPanel.Controls.Add(labelDateWritedValue, 1, 5);
			tableLayoutPanel.Controls.Add(labelAttributesValue, 1, 6);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.PanelBackStyle = PaletteBackStyle.FormMain;
			tableLayoutPanel.RowCount = 7;
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.Size = new Size(489, 187);
			tableLayoutPanel.TabIndex = 0;
			tableLayoutPanel.TabStop = true;
			toolTip.SetToolTip(tableLayoutPanel, "Groups the information");
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
			toolStripContainer.ContentPanel.Size = new Size(489, 187);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(489, 209);
			toolStripContainer.TabIndex = 3;
			toolStripContainer.Text = "toolStripContainer";
			toolTip.SetToolTip(toolStripContainer, "Container to arrange the toolbars");
			toolStripContainer.TopToolStripPanelVisible = false;
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
			statusStrip.Size = new Size(489, 22);
			statusStrip.TabIndex = 2;
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
			// kryptonManager
			// 
			kryptonManager.GlobalPaletteMode = PaletteMode.Global;
			// 
			// DatabaseInformationForm
			// 
			AccessibleDescription = "Shows the informations about the MPCORB.DAT database";
			AccessibleName = "Database Information";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(489, 209);
			Controls.Add(toolStripContainer);
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DatabaseInformationForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Database information";
			toolTip.SetToolTip(this, "Database Information");
			FormClosed += DatabaseInformationForm_FormClosed;
			Load += DatabaseInformationForm_Load;
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
		private ToolTip toolTip;
    private KryptonTableLayoutPanel tableLayoutPanel;
    private KryptonLabel labelName;
    private KryptonLabel labelDirectory;
    private KryptonLabel labelSize;
    private KryptonLabel labelDateCreated;
    private KryptonLabel labelDateAccessed;
    private KryptonLabel labelDateWrited;
    private KryptonLabel labelAttributes;
    private KryptonLabel labelNameValue;
    private KryptonLabel labelDirectoryValue;
    private KryptonLabel labelSizeValue;
    private KryptonLabel labelDateCreatedValue;
    private KryptonLabel labelDateAccessedValue;
    private KryptonLabel labelDateWritedValue;
    private KryptonLabel labelAttributesValue;
	private KryptonStatusStrip statusStrip;
	private ToolStripStatusLabel labelInformation;
	private ToolStripContainer toolStripContainer;
		private KryptonManager kryptonManager;
	}
}