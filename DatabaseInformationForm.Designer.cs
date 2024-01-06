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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseInformationForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelName = new Krypton.Toolkit.KryptonLabel();
			this.labelDirectory = new Krypton.Toolkit.KryptonLabel();
			this.labelSize = new Krypton.Toolkit.KryptonLabel();
			this.labelDateCreated = new Krypton.Toolkit.KryptonLabel();
			this.labelDateAccessed = new Krypton.Toolkit.KryptonLabel();
			this.labelDateWrited = new Krypton.Toolkit.KryptonLabel();
			this.labelAttributes = new Krypton.Toolkit.KryptonLabel();
			this.labelNameValue = new Krypton.Toolkit.KryptonLabel();
			this.labelDirectoryValue = new Krypton.Toolkit.KryptonLabel();
			this.labelSizeValue = new Krypton.Toolkit.KryptonLabel();
			this.labelDateCreatedValue = new Krypton.Toolkit.KryptonLabel();
			this.labelDateAccessedValue = new Krypton.Toolkit.KryptonLabel();
			this.labelDateWritedValue = new Krypton.Toolkit.KryptonLabel();
			this.labelAttributesValue = new Krypton.Toolkit.KryptonLabel();
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
			// labelName
			// 
			this.labelName.AccessibleDescription = "Shows the name of the database";
			this.labelName.AccessibleName = "Name";
			this.labelName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelName.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelName.Location = new System.Drawing.Point(3, 3);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(102, 20);
			this.labelName.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelName, "Name");
			this.labelName.Values.Text = "Name";
			this.labelName.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDirectory
			// 
			this.labelDirectory.AccessibleDescription = "Shows the directory of the database";
			this.labelDirectory.AccessibleName = "Directory";
			this.labelDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDirectory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDirectory.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelDirectory.Location = new System.Drawing.Point(3, 29);
			this.labelDirectory.Name = "labelDirectory";
			this.labelDirectory.Size = new System.Drawing.Size(102, 20);
			this.labelDirectory.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelDirectory, "Directory");
			this.labelDirectory.Values.Text = "Directory";
			this.labelDirectory.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDirectory.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectory.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDirectory.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectory.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSize
			// 
			this.labelSize.AccessibleDescription = "Shows the size of the database";
			this.labelSize.AccessibleName = "Size";
			this.labelSize.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSize.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSize.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelSize.Location = new System.Drawing.Point(3, 55);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(102, 20);
			this.labelSize.TabIndex = 4;
			this.toolTip.SetToolTip(this.labelSize, "Size");
			this.labelSize.Values.Text = "Size";
			this.labelSize.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSize.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSize.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateCreated
			// 
			this.labelDateCreated.AccessibleDescription = "Shows the creation date of the database";
			this.labelDateCreated.AccessibleName = "Creation date";
			this.labelDateCreated.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateCreated.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateCreated.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelDateCreated.Location = new System.Drawing.Point(3, 81);
			this.labelDateCreated.Name = "labelDateCreated";
			this.labelDateCreated.Size = new System.Drawing.Size(102, 20);
			this.labelDateCreated.TabIndex = 6;
			this.toolTip.SetToolTip(this.labelDateCreated, "Creation date");
			this.labelDateCreated.Values.Text = "Creation date";
			this.labelDateCreated.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateCreated.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreated.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateCreated.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreated.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateAccessed
			// 
			this.labelDateAccessed.AccessibleDescription = "Shows the last access date of the database";
			this.labelDateAccessed.AccessibleName = "Last access date";
			this.labelDateAccessed.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessed.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateAccessed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateAccessed.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelDateAccessed.Location = new System.Drawing.Point(3, 107);
			this.labelDateAccessed.Name = "labelDateAccessed";
			this.labelDateAccessed.Size = new System.Drawing.Size(102, 20);
			this.labelDateAccessed.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelDateAccessed, "Last access date");
			this.labelDateAccessed.Values.Text = "Last access date";
			this.labelDateAccessed.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateAccessed.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessed.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateAccessed.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessed.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateWrited
			// 
			this.labelDateWrited.AccessibleDescription = "Shows the last write date of the database";
			this.labelDateWrited.AccessibleName = "Last write date";
			this.labelDateWrited.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWrited.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateWrited.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateWrited.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelDateWrited.Location = new System.Drawing.Point(3, 133);
			this.labelDateWrited.Name = "labelDateWrited";
			this.labelDateWrited.Size = new System.Drawing.Size(102, 20);
			this.labelDateWrited.TabIndex = 10;
			this.toolTip.SetToolTip(this.labelDateWrited, "Last write date");
			this.labelDateWrited.Values.Text = "Last write date";
			this.labelDateWrited.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateWrited.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWrited.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateWrited.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWrited.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAttributes
			// 
			this.labelAttributes.AccessibleDescription = "Shows the attributes of the database";
			this.labelAttributes.AccessibleName = "Attributes";
			this.labelAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAttributes.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelAttributes.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelAttributes.Location = new System.Drawing.Point(3, 159);
			this.labelAttributes.Name = "labelAttributes";
			this.labelAttributes.Size = new System.Drawing.Size(102, 20);
			this.labelAttributes.TabIndex = 12;
			this.toolTip.SetToolTip(this.labelAttributes, "Attributes");
			this.labelAttributes.Values.Text = "Attributes";
			this.labelAttributes.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelAttributes.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributes.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAttributes.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributes.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNameValue
			// 
			this.labelNameValue.AccessibleDescription = "Shows the name of the database";
			this.labelNameValue.AccessibleName = "Name value";
			this.labelNameValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNameValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelNameValue.Location = new System.Drawing.Point(111, 3);
			this.labelNameValue.Name = "labelNameValue";
			this.labelNameValue.Size = new System.Drawing.Size(375, 20);
			this.labelNameValue.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelNameValue, "Shows the name of the database");
			this.labelNameValue.Values.Text = "..........";
			this.labelNameValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelNameValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNameValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNameValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNameValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDirectoryValue
			// 
			this.labelDirectoryValue.AccessibleDescription = "Shows the directory of the database";
			this.labelDirectoryValue.AccessibleName = "Directory value";
			this.labelDirectoryValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectoryValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDirectoryValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDirectoryValue.Location = new System.Drawing.Point(111, 29);
			this.labelDirectoryValue.Name = "labelDirectoryValue";
			this.labelDirectoryValue.Size = new System.Drawing.Size(375, 20);
			this.labelDirectoryValue.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelDirectoryValue, "Shows the directory of the database");
			this.labelDirectoryValue.Values.Text = "..........";
			this.labelDirectoryValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDirectoryValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectoryValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDirectoryValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectoryValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSizeValue
			// 
			this.labelSizeValue.AccessibleDescription = "Shows the size of the database";
			this.labelSizeValue.AccessibleName = "size value";
			this.labelSizeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSizeValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSizeValue.Location = new System.Drawing.Point(111, 55);
			this.labelSizeValue.Name = "labelSizeValue";
			this.labelSizeValue.Size = new System.Drawing.Size(375, 20);
			this.labelSizeValue.TabIndex = 5;
			this.toolTip.SetToolTip(this.labelSizeValue, "Shows the size of the database");
			this.labelSizeValue.Values.Text = "..........";
			this.labelSizeValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSizeValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSizeValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateCreatedValue
			// 
			this.labelDateCreatedValue.AccessibleDescription = "Shows the creation date of the database";
			this.labelDateCreatedValue.AccessibleName = "Creation date value";
			this.labelDateCreatedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreatedValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateCreatedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateCreatedValue.Location = new System.Drawing.Point(111, 81);
			this.labelDateCreatedValue.Name = "labelDateCreatedValue";
			this.labelDateCreatedValue.Size = new System.Drawing.Size(375, 20);
			this.labelDateCreatedValue.TabIndex = 7;
			this.toolTip.SetToolTip(this.labelDateCreatedValue, "Shows the creation date of the database");
			this.labelDateCreatedValue.Values.Text = "..........";
			this.labelDateCreatedValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateCreatedValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreatedValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateCreatedValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreatedValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateAccessedValue
			// 
			this.labelDateAccessedValue.AccessibleDescription = "Shows the last access date of the database";
			this.labelDateAccessedValue.AccessibleName = "Last access date value";
			this.labelDateAccessedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessedValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateAccessedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateAccessedValue.Location = new System.Drawing.Point(111, 107);
			this.labelDateAccessedValue.Name = "labelDateAccessedValue";
			this.labelDateAccessedValue.Size = new System.Drawing.Size(375, 20);
			this.labelDateAccessedValue.TabIndex = 9;
			this.toolTip.SetToolTip(this.labelDateAccessedValue, "Shows the last access date of the database");
			this.labelDateAccessedValue.Values.Text = "..........";
			this.labelDateAccessedValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateAccessedValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessedValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateAccessedValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessedValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateWritedValue
			// 
			this.labelDateWritedValue.AccessibleDescription = "Shows the last write date of the database";
			this.labelDateWritedValue.AccessibleName = "Last write date value";
			this.labelDateWritedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWritedValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateWritedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateWritedValue.Location = new System.Drawing.Point(111, 133);
			this.labelDateWritedValue.Name = "labelDateWritedValue";
			this.labelDateWritedValue.Size = new System.Drawing.Size(375, 20);
			this.labelDateWritedValue.TabIndex = 11;
			this.toolTip.SetToolTip(this.labelDateWritedValue, "Shows the last write date of the database");
			this.labelDateWritedValue.Values.Text = "..........";
			this.labelDateWritedValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateWritedValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWritedValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateWritedValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWritedValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAttributesValue
			// 
			this.labelAttributesValue.AccessibleDescription = "Shows the attributes of the database";
			this.labelAttributesValue.AccessibleName = "Attributes value";
			this.labelAttributesValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributesValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAttributesValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelAttributesValue.Location = new System.Drawing.Point(111, 159);
			this.labelAttributesValue.Name = "labelAttributesValue";
			this.labelAttributesValue.Size = new System.Drawing.Size(375, 20);
			this.labelAttributesValue.TabIndex = 13;
			this.toolTip.SetToolTip(this.labelAttributesValue, "Shows the attributes of the database");
			this.labelAttributesValue.Values.Text = "..........";
			this.labelAttributesValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelAttributesValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributesValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAttributesValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributesValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Groups the information";
			this.tableLayoutPanel.AccessibleName = "Information";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.tableLayoutPanel.AutoScroll = true;
			this.tableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel.BackgroundImage")));
			this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.labelName, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelDirectory, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelSize, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelDateCreated, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.labelDateAccessed, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.labelDateWrited, 0, 5);
			this.tableLayoutPanel.Controls.Add(this.labelAttributes, 0, 6);
			this.tableLayoutPanel.Controls.Add(this.labelNameValue, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelDirectoryValue, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelSizeValue, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelDateCreatedValue, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.labelDateAccessedValue, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.labelDateWritedValue, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.labelAttributesValue, 1, 6);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.tableLayoutPanel.RowCount = 7;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(489, 162);
			this.tableLayoutPanel.TabIndex = 0;
			this.tableLayoutPanel.TabStop = true;
			this.toolTip.SetToolTip(this.tableLayoutPanel, "Groups the information");
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
			this.statusStrip.Size = new System.Drawing.Size(489, 22);
			this.statusStrip.TabIndex = 2;
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
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(489, 162);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(489, 209);
			this.toolStripContainer.TabIndex = 3;
			this.toolStripContainer.Text = "toolStripContainer";
			this.toolTip.SetToolTip(this.toolStripContainer, "Container to arrange the toolbars");
			// 
			// DatabaseInformationForm
			// 
			this.AccessibleDescription = "Shows the informations about the MPCORB.DAT database";
			this.AccessibleName = "Database Information";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 209);
			this.Controls.Add(this.toolStripContainer);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DatabaseInformationForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Database information";
			this.toolTip.SetToolTip(this, "Database Information");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseInformationForm_FormClosed);
			this.Load += new System.EventHandler(this.DatabaseInformationForm_Load);
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