using Krypton.Toolkit;

namespace Planetoid_DB
{
  partial class DatabaseInformationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseInformationForm));
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
			labelName.Font = new Font("Segoe UI", 8.5F);
			labelName.LabelStyle = LabelStyle.BoldPanel;
			labelName.Location = new Point(3, 3);
			labelName.Name = "labelName";
			labelName.Size = new Size(102, 20);
			labelName.TabIndex = 0;
			toolTip.SetToolTip(labelName, "Name");
			labelName.Values.Text = "Name";
			labelName.DoubleClick += CopyToClipboard_DoubleClick;
			labelName.Enter += SetStatusbar_Enter;
			labelName.Leave += ClearStatusbar_Leave;
			labelName.MouseEnter += SetStatusbar_Enter;
			labelName.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDirectory
			// 
			labelDirectory.AccessibleDescription = "Shows the directory of the database";
			labelDirectory.AccessibleName = "Directory";
			labelDirectory.AccessibleRole = AccessibleRole.Text;
			labelDirectory.Dock = DockStyle.Fill;
			labelDirectory.Font = new Font("Segoe UI", 8.5F);
			labelDirectory.LabelStyle = LabelStyle.BoldPanel;
			labelDirectory.Location = new Point(3, 29);
			labelDirectory.Name = "labelDirectory";
			labelDirectory.Size = new Size(102, 20);
			labelDirectory.TabIndex = 2;
			toolTip.SetToolTip(labelDirectory, "Directory");
			labelDirectory.Values.Text = "Directory";
			labelDirectory.DoubleClick += CopyToClipboard_DoubleClick;
			labelDirectory.Enter += SetStatusbar_Enter;
			labelDirectory.Leave += ClearStatusbar_Leave;
			labelDirectory.MouseEnter += SetStatusbar_Enter;
			labelDirectory.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSize
			// 
			labelSize.AccessibleDescription = "Shows the size of the database";
			labelSize.AccessibleName = "Size";
			labelSize.AccessibleRole = AccessibleRole.Text;
			labelSize.Dock = DockStyle.Fill;
			labelSize.Font = new Font("Segoe UI", 8.5F);
			labelSize.LabelStyle = LabelStyle.BoldPanel;
			labelSize.Location = new Point(3, 55);
			labelSize.Name = "labelSize";
			labelSize.Size = new Size(102, 20);
			labelSize.TabIndex = 4;
			toolTip.SetToolTip(labelSize, "Size");
			labelSize.Values.Text = "Size";
			labelSize.DoubleClick += CopyToClipboard_DoubleClick;
			labelSize.Enter += SetStatusbar_Enter;
			labelSize.Leave += ClearStatusbar_Leave;
			labelSize.MouseEnter += SetStatusbar_Enter;
			labelSize.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateCreated
			// 
			labelDateCreated.AccessibleDescription = "Shows the creation date of the database";
			labelDateCreated.AccessibleName = "Creation date";
			labelDateCreated.AccessibleRole = AccessibleRole.Text;
			labelDateCreated.Dock = DockStyle.Fill;
			labelDateCreated.Font = new Font("Segoe UI", 8.5F);
			labelDateCreated.LabelStyle = LabelStyle.BoldPanel;
			labelDateCreated.Location = new Point(3, 81);
			labelDateCreated.Name = "labelDateCreated";
			labelDateCreated.Size = new Size(102, 20);
			labelDateCreated.TabIndex = 6;
			toolTip.SetToolTip(labelDateCreated, "Creation date");
			labelDateCreated.Values.Text = "Creation date";
			labelDateCreated.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateCreated.Enter += SetStatusbar_Enter;
			labelDateCreated.Leave += ClearStatusbar_Leave;
			labelDateCreated.MouseEnter += SetStatusbar_Enter;
			labelDateCreated.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateAccessed
			// 
			labelDateAccessed.AccessibleDescription = "Shows the last access date of the database";
			labelDateAccessed.AccessibleName = "Last access date";
			labelDateAccessed.AccessibleRole = AccessibleRole.Text;
			labelDateAccessed.Dock = DockStyle.Fill;
			labelDateAccessed.Font = new Font("Segoe UI", 8.5F);
			labelDateAccessed.LabelStyle = LabelStyle.BoldPanel;
			labelDateAccessed.Location = new Point(3, 107);
			labelDateAccessed.Name = "labelDateAccessed";
			labelDateAccessed.Size = new Size(102, 20);
			labelDateAccessed.TabIndex = 8;
			toolTip.SetToolTip(labelDateAccessed, "Last access date");
			labelDateAccessed.Values.Text = "Last access date";
			labelDateAccessed.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateAccessed.Enter += SetStatusbar_Enter;
			labelDateAccessed.Leave += ClearStatusbar_Leave;
			labelDateAccessed.MouseEnter += SetStatusbar_Enter;
			labelDateAccessed.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateWrited
			// 
			labelDateWrited.AccessibleDescription = "Shows the last write date of the database";
			labelDateWrited.AccessibleName = "Last write date";
			labelDateWrited.AccessibleRole = AccessibleRole.Text;
			labelDateWrited.Dock = DockStyle.Fill;
			labelDateWrited.Font = new Font("Segoe UI", 8.5F);
			labelDateWrited.LabelStyle = LabelStyle.BoldPanel;
			labelDateWrited.Location = new Point(3, 133);
			labelDateWrited.Name = "labelDateWrited";
			labelDateWrited.Size = new Size(102, 20);
			labelDateWrited.TabIndex = 10;
			toolTip.SetToolTip(labelDateWrited, "Last write date");
			labelDateWrited.Values.Text = "Last write date";
			labelDateWrited.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateWrited.Enter += SetStatusbar_Enter;
			labelDateWrited.Leave += ClearStatusbar_Leave;
			labelDateWrited.MouseEnter += SetStatusbar_Enter;
			labelDateWrited.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAttributes
			// 
			labelAttributes.AccessibleDescription = "Shows the attributes of the database";
			labelAttributes.AccessibleName = "Attributes";
			labelAttributes.AccessibleRole = AccessibleRole.Text;
			labelAttributes.Dock = DockStyle.Fill;
			labelAttributes.Font = new Font("Segoe UI", 8.5F);
			labelAttributes.LabelStyle = LabelStyle.BoldPanel;
			labelAttributes.Location = new Point(3, 159);
			labelAttributes.Name = "labelAttributes";
			labelAttributes.Size = new Size(102, 20);
			labelAttributes.TabIndex = 12;
			toolTip.SetToolTip(labelAttributes, "Attributes");
			labelAttributes.Values.Text = "Attributes";
			labelAttributes.DoubleClick += CopyToClipboard_DoubleClick;
			labelAttributes.Enter += SetStatusbar_Enter;
			labelAttributes.Leave += ClearStatusbar_Leave;
			labelAttributes.MouseEnter += SetStatusbar_Enter;
			labelAttributes.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNameValue
			// 
			labelNameValue.AccessibleDescription = "Shows the name of the database";
			labelNameValue.AccessibleName = "Name value";
			labelNameValue.AccessibleRole = AccessibleRole.Text;
			labelNameValue.Dock = DockStyle.Fill;
			labelNameValue.Font = new Font("Segoe UI", 8.5F);
			labelNameValue.Location = new Point(111, 3);
			labelNameValue.Name = "labelNameValue";
			labelNameValue.Size = new Size(375, 20);
			labelNameValue.TabIndex = 1;
			toolTip.SetToolTip(labelNameValue, "Shows the name of the database");
			labelNameValue.Values.Text = "..........";
			labelNameValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelNameValue.Enter += SetStatusbar_Enter;
			labelNameValue.Leave += ClearStatusbar_Leave;
			labelNameValue.MouseEnter += SetStatusbar_Enter;
			labelNameValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDirectoryValue
			// 
			labelDirectoryValue.AccessibleDescription = "Shows the directory of the database";
			labelDirectoryValue.AccessibleName = "Directory value";
			labelDirectoryValue.AccessibleRole = AccessibleRole.Text;
			labelDirectoryValue.Dock = DockStyle.Fill;
			labelDirectoryValue.Font = new Font("Segoe UI", 8.5F);
			labelDirectoryValue.Location = new Point(111, 29);
			labelDirectoryValue.Name = "labelDirectoryValue";
			labelDirectoryValue.Size = new Size(375, 20);
			labelDirectoryValue.TabIndex = 3;
			toolTip.SetToolTip(labelDirectoryValue, "Shows the directory of the database");
			labelDirectoryValue.Values.Text = "..........";
			labelDirectoryValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDirectoryValue.Enter += SetStatusbar_Enter;
			labelDirectoryValue.Leave += ClearStatusbar_Leave;
			labelDirectoryValue.MouseEnter += SetStatusbar_Enter;
			labelDirectoryValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSizeValue
			// 
			labelSizeValue.AccessibleDescription = "Shows the size of the database";
			labelSizeValue.AccessibleName = "size value";
			labelSizeValue.AccessibleRole = AccessibleRole.Text;
			labelSizeValue.Dock = DockStyle.Fill;
			labelSizeValue.Font = new Font("Segoe UI", 8.5F);
			labelSizeValue.Location = new Point(111, 55);
			labelSizeValue.Name = "labelSizeValue";
			labelSizeValue.Size = new Size(375, 20);
			labelSizeValue.TabIndex = 5;
			toolTip.SetToolTip(labelSizeValue, "Shows the size of the database");
			labelSizeValue.Values.Text = "..........";
			labelSizeValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelSizeValue.Enter += SetStatusbar_Enter;
			labelSizeValue.Leave += ClearStatusbar_Leave;
			labelSizeValue.MouseEnter += SetStatusbar_Enter;
			labelSizeValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateCreatedValue
			// 
			labelDateCreatedValue.AccessibleDescription = "Shows the creation date of the database";
			labelDateCreatedValue.AccessibleName = "Creation date value";
			labelDateCreatedValue.AccessibleRole = AccessibleRole.Text;
			labelDateCreatedValue.Dock = DockStyle.Fill;
			labelDateCreatedValue.Font = new Font("Segoe UI", 8.5F);
			labelDateCreatedValue.Location = new Point(111, 81);
			labelDateCreatedValue.Name = "labelDateCreatedValue";
			labelDateCreatedValue.Size = new Size(375, 20);
			labelDateCreatedValue.TabIndex = 7;
			toolTip.SetToolTip(labelDateCreatedValue, "Shows the creation date of the database");
			labelDateCreatedValue.Values.Text = "..........";
			labelDateCreatedValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateCreatedValue.Enter += SetStatusbar_Enter;
			labelDateCreatedValue.Leave += ClearStatusbar_Leave;
			labelDateCreatedValue.MouseEnter += SetStatusbar_Enter;
			labelDateCreatedValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateAccessedValue
			// 
			labelDateAccessedValue.AccessibleDescription = "Shows the last access date of the database";
			labelDateAccessedValue.AccessibleName = "Last access date value";
			labelDateAccessedValue.AccessibleRole = AccessibleRole.Text;
			labelDateAccessedValue.Dock = DockStyle.Fill;
			labelDateAccessedValue.Font = new Font("Segoe UI", 8.5F);
			labelDateAccessedValue.Location = new Point(111, 107);
			labelDateAccessedValue.Name = "labelDateAccessedValue";
			labelDateAccessedValue.Size = new Size(375, 20);
			labelDateAccessedValue.TabIndex = 9;
			toolTip.SetToolTip(labelDateAccessedValue, "Shows the last access date of the database");
			labelDateAccessedValue.Values.Text = "..........";
			labelDateAccessedValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateAccessedValue.Enter += SetStatusbar_Enter;
			labelDateAccessedValue.Leave += ClearStatusbar_Leave;
			labelDateAccessedValue.MouseEnter += SetStatusbar_Enter;
			labelDateAccessedValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateWritedValue
			// 
			labelDateWritedValue.AccessibleDescription = "Shows the last write date of the database";
			labelDateWritedValue.AccessibleName = "Last write date value";
			labelDateWritedValue.AccessibleRole = AccessibleRole.Text;
			labelDateWritedValue.Dock = DockStyle.Fill;
			labelDateWritedValue.Font = new Font("Segoe UI", 8.5F);
			labelDateWritedValue.Location = new Point(111, 133);
			labelDateWritedValue.Name = "labelDateWritedValue";
			labelDateWritedValue.Size = new Size(375, 20);
			labelDateWritedValue.TabIndex = 11;
			toolTip.SetToolTip(labelDateWritedValue, "Shows the last write date of the database");
			labelDateWritedValue.Values.Text = "..........";
			labelDateWritedValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateWritedValue.Enter += SetStatusbar_Enter;
			labelDateWritedValue.Leave += ClearStatusbar_Leave;
			labelDateWritedValue.MouseEnter += SetStatusbar_Enter;
			labelDateWritedValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAttributesValue
			// 
			labelAttributesValue.AccessibleDescription = "Shows the attributes of the database";
			labelAttributesValue.AccessibleName = "Attributes value";
			labelAttributesValue.AccessibleRole = AccessibleRole.Text;
			labelAttributesValue.Dock = DockStyle.Fill;
			labelAttributesValue.Font = new Font("Segoe UI", 8.5F);
			labelAttributesValue.Location = new Point(111, 159);
			labelAttributesValue.Name = "labelAttributesValue";
			labelAttributesValue.Size = new Size(375, 20);
			labelAttributesValue.TabIndex = 13;
			toolTip.SetToolTip(labelAttributesValue, "Shows the attributes of the database");
			labelAttributesValue.Values.Text = "..........";
			labelAttributesValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelAttributesValue.Enter += SetStatusbar_Enter;
			labelAttributesValue.Leave += ClearStatusbar_Leave;
			labelAttributesValue.MouseEnter += SetStatusbar_Enter;
			labelAttributesValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Groups the information";
			tableLayoutPanel.AccessibleName = "Information";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel.AutoScroll = true;
			tableLayoutPanel.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel.BackgroundImage");
			tableLayoutPanel.BackgroundImageLayout = ImageLayout.None;
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
			tableLayoutPanel.Size = new Size(489, 162);
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
			toolStripContainer.ContentPanel.Size = new Size(489, 162);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(489, 209);
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
			UseDropShadow = true;
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
		private System.Windows.Forms.ToolTip toolTip;
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
	private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	private System.Windows.Forms.ToolStripContainer toolStripContainer;
	}
}