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
			this.buttonOK = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelName = new System.Windows.Forms.Label();
			this.labelDirectory = new System.Windows.Forms.Label();
			this.labelSize = new System.Windows.Forms.Label();
			this.labelDateCreated = new System.Windows.Forms.Label();
			this.labelDateAccessed = new System.Windows.Forms.Label();
			this.labelDateWrited = new System.Windows.Forms.Label();
			this.labelAttributes = new System.Windows.Forms.Label();
			this.labelNameValue = new System.Windows.Forms.Label();
			this.labelDirectoryValue = new System.Windows.Forms.Label();
			this.labelSizeValue = new System.Windows.Forms.Label();
			this.labelDateCreatedValue = new System.Windows.Forms.Label();
			this.labelDateAccessedValue = new System.Windows.Forms.Label();
			this.labelDateWritedValue = new System.Windows.Forms.Label();
			this.labelAttributesValue = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(175, 125);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
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
			// labelName
			// 
			this.labelName.AccessibleDescription = "Show the name of the database";
			this.labelName.AccessibleName = "Name";
			this.labelName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelName.AutoSize = true;
			this.labelName.BackColor = System.Drawing.Color.Transparent;
			this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(91, 15);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			this.toolTip.SetToolTip(this.labelName, "Name");
			this.labelName.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDirectory
			// 
			this.labelDirectory.AccessibleDescription = "Show the directory of the database";
			this.labelDirectory.AccessibleName = "Directory";
			this.labelDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectory.AutoSize = true;
			this.labelDirectory.BackColor = System.Drawing.Color.Transparent;
			this.labelDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDirectory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDirectory.Location = new System.Drawing.Point(3, 15);
			this.labelDirectory.Name = "labelDirectory";
			this.labelDirectory.Size = new System.Drawing.Size(91, 15);
			this.labelDirectory.TabIndex = 2;
			this.labelDirectory.Text = "Directory";
			this.toolTip.SetToolTip(this.labelDirectory, "Directory");
			this.labelDirectory.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDirectory.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectory.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDirectory.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectory.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSize
			// 
			this.labelSize.AccessibleDescription = "Show the size of the database";
			this.labelSize.AccessibleName = "Size";
			this.labelSize.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSize.AutoSize = true;
			this.labelSize.BackColor = System.Drawing.Color.Transparent;
			this.labelSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSize.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSize.Location = new System.Drawing.Point(3, 30);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(91, 15);
			this.labelSize.TabIndex = 4;
			this.labelSize.Text = "Size";
			this.toolTip.SetToolTip(this.labelSize, "Size");
			this.labelSize.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSize.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSize.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateCreated
			// 
			this.labelDateCreated.AccessibleDescription = "Show the creation date of the database";
			this.labelDateCreated.AccessibleName = "Creation date";
			this.labelDateCreated.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreated.AutoSize = true;
			this.labelDateCreated.BackColor = System.Drawing.Color.Transparent;
			this.labelDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateCreated.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateCreated.Location = new System.Drawing.Point(3, 45);
			this.labelDateCreated.Name = "labelDateCreated";
			this.labelDateCreated.Size = new System.Drawing.Size(91, 15);
			this.labelDateCreated.TabIndex = 6;
			this.labelDateCreated.Text = "Creation date";
			this.toolTip.SetToolTip(this.labelDateCreated, "Creation date");
			this.labelDateCreated.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateCreated.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreated.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateCreated.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreated.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateAccessed
			// 
			this.labelDateAccessed.AccessibleDescription = "Show the last access date of the database";
			this.labelDateAccessed.AccessibleName = "Last access date";
			this.labelDateAccessed.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessed.AutoSize = true;
			this.labelDateAccessed.BackColor = System.Drawing.Color.Transparent;
			this.labelDateAccessed.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateAccessed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateAccessed.Location = new System.Drawing.Point(3, 60);
			this.labelDateAccessed.Name = "labelDateAccessed";
			this.labelDateAccessed.Size = new System.Drawing.Size(91, 15);
			this.labelDateAccessed.TabIndex = 8;
			this.labelDateAccessed.Text = "Last access date";
			this.toolTip.SetToolTip(this.labelDateAccessed, "Last access date");
			this.labelDateAccessed.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateAccessed.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessed.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateAccessed.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessed.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateWrited
			// 
			this.labelDateWrited.AccessibleDescription = "Show the last write date of the database";
			this.labelDateWrited.AccessibleName = "Last write date";
			this.labelDateWrited.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWrited.AutoSize = true;
			this.labelDateWrited.BackColor = System.Drawing.Color.Transparent;
			this.labelDateWrited.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateWrited.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateWrited.Location = new System.Drawing.Point(3, 75);
			this.labelDateWrited.Name = "labelDateWrited";
			this.labelDateWrited.Size = new System.Drawing.Size(91, 15);
			this.labelDateWrited.TabIndex = 10;
			this.labelDateWrited.Text = "Last write date";
			this.toolTip.SetToolTip(this.labelDateWrited, "Last write date");
			this.labelDateWrited.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateWrited.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWrited.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateWrited.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWrited.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAttributes
			// 
			this.labelAttributes.AccessibleDescription = "Show the attributes of the database";
			this.labelAttributes.AccessibleName = "Attributes";
			this.labelAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributes.AutoSize = true;
			this.labelAttributes.BackColor = System.Drawing.Color.Transparent;
			this.labelAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAttributes.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelAttributes.Location = new System.Drawing.Point(3, 90);
			this.labelAttributes.Name = "labelAttributes";
			this.labelAttributes.Size = new System.Drawing.Size(91, 20);
			this.labelAttributes.TabIndex = 12;
			this.labelAttributes.Text = "Attributes";
			this.toolTip.SetToolTip(this.labelAttributes, "Attributes");
			this.labelAttributes.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelAttributes.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributes.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAttributes.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributes.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNameValue
			// 
			this.labelNameValue.AccessibleDescription = "Show the name of the database";
			this.labelNameValue.AccessibleName = "Name value";
			this.labelNameValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNameValue.AutoEllipsis = true;
			this.labelNameValue.AutoSize = true;
			this.labelNameValue.BackColor = System.Drawing.Color.Transparent;
			this.labelNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNameValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelNameValue.Location = new System.Drawing.Point(100, 0);
			this.labelNameValue.Name = "labelNameValue";
			this.labelNameValue.Size = new System.Drawing.Size(341, 15);
			this.labelNameValue.TabIndex = 1;
			this.labelNameValue.Text = "...";
			this.toolTip.SetToolTip(this.labelNameValue, "Show the name of the database");
			this.labelNameValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelNameValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNameValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNameValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNameValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDirectoryValue
			// 
			this.labelDirectoryValue.AccessibleDescription = "Show the directory of the database";
			this.labelDirectoryValue.AccessibleName = "Directory value";
			this.labelDirectoryValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectoryValue.AutoEllipsis = true;
			this.labelDirectoryValue.AutoSize = true;
			this.labelDirectoryValue.BackColor = System.Drawing.Color.Transparent;
			this.labelDirectoryValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDirectoryValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDirectoryValue.Location = new System.Drawing.Point(100, 15);
			this.labelDirectoryValue.Name = "labelDirectoryValue";
			this.labelDirectoryValue.Size = new System.Drawing.Size(341, 15);
			this.labelDirectoryValue.TabIndex = 3;
			this.labelDirectoryValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDirectoryValue, "Show the directory of the database");
			this.labelDirectoryValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDirectoryValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectoryValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDirectoryValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDirectoryValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSizeValue
			// 
			this.labelSizeValue.AccessibleDescription = "Show the size of the database";
			this.labelSizeValue.AccessibleName = "size value";
			this.labelSizeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeValue.AutoEllipsis = true;
			this.labelSizeValue.AutoSize = true;
			this.labelSizeValue.BackColor = System.Drawing.Color.Transparent;
			this.labelSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSizeValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSizeValue.Location = new System.Drawing.Point(100, 30);
			this.labelSizeValue.Name = "labelSizeValue";
			this.labelSizeValue.Size = new System.Drawing.Size(341, 15);
			this.labelSizeValue.TabIndex = 5;
			this.labelSizeValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSizeValue, "Show the size of the database");
			this.labelSizeValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSizeValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSizeValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSizeValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateCreatedValue
			// 
			this.labelDateCreatedValue.AccessibleDescription = "Show the creation date of the database";
			this.labelDateCreatedValue.AccessibleName = "Creation date value";
			this.labelDateCreatedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreatedValue.AutoEllipsis = true;
			this.labelDateCreatedValue.AutoSize = true;
			this.labelDateCreatedValue.BackColor = System.Drawing.Color.Transparent;
			this.labelDateCreatedValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateCreatedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateCreatedValue.Location = new System.Drawing.Point(100, 45);
			this.labelDateCreatedValue.Name = "labelDateCreatedValue";
			this.labelDateCreatedValue.Size = new System.Drawing.Size(341, 15);
			this.labelDateCreatedValue.TabIndex = 7;
			this.labelDateCreatedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateCreatedValue, "Show the creation date of the database");
			this.labelDateCreatedValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateCreatedValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreatedValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateCreatedValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateCreatedValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateAccessedValue
			// 
			this.labelDateAccessedValue.AccessibleDescription = "Show the last access date of the database";
			this.labelDateAccessedValue.AccessibleName = "Last access date value";
			this.labelDateAccessedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessedValue.AutoEllipsis = true;
			this.labelDateAccessedValue.AutoSize = true;
			this.labelDateAccessedValue.BackColor = System.Drawing.Color.Transparent;
			this.labelDateAccessedValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateAccessedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateAccessedValue.Location = new System.Drawing.Point(100, 60);
			this.labelDateAccessedValue.Name = "labelDateAccessedValue";
			this.labelDateAccessedValue.Size = new System.Drawing.Size(341, 15);
			this.labelDateAccessedValue.TabIndex = 9;
			this.labelDateAccessedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateAccessedValue, "Show the last access date of the database");
			this.labelDateAccessedValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateAccessedValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessedValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateAccessedValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateAccessedValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateWritedValue
			// 
			this.labelDateWritedValue.AccessibleDescription = "Show the last write date of the database";
			this.labelDateWritedValue.AccessibleName = "Last write date value";
			this.labelDateWritedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWritedValue.AutoEllipsis = true;
			this.labelDateWritedValue.AutoSize = true;
			this.labelDateWritedValue.BackColor = System.Drawing.Color.Transparent;
			this.labelDateWritedValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateWritedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateWritedValue.Location = new System.Drawing.Point(100, 75);
			this.labelDateWritedValue.Name = "labelDateWritedValue";
			this.labelDateWritedValue.Size = new System.Drawing.Size(341, 15);
			this.labelDateWritedValue.TabIndex = 11;
			this.labelDateWritedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateWritedValue, "Show the last write date of the database");
			this.labelDateWritedValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelDateWritedValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWritedValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateWritedValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateWritedValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAttributesValue
			// 
			this.labelAttributesValue.AccessibleDescription = "Show the attributes of the database";
			this.labelAttributesValue.AccessibleName = "Attributes value";
			this.labelAttributesValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributesValue.AutoEllipsis = true;
			this.labelAttributesValue.AutoSize = true;
			this.labelAttributesValue.BackColor = System.Drawing.Color.Transparent;
			this.labelAttributesValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAttributesValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelAttributesValue.Location = new System.Drawing.Point(100, 90);
			this.labelAttributesValue.Name = "labelAttributesValue";
			this.labelAttributesValue.Size = new System.Drawing.Size(341, 20);
			this.labelAttributesValue.TabIndex = 13;
			this.labelAttributesValue.Text = "...";
			this.toolTip.SetToolTip(this.labelAttributesValue, "Show the attributes of the database");
			this.labelAttributesValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelAttributesValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributesValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAttributesValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAttributesValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the information";
			this.tableLayoutPanel.AccessibleName = "Information";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.AutoScroll = true;
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
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 7;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(444, 110);
			this.tableLayoutPanel.TabIndex = 0;
			this.tableLayoutPanel.TabStop = true;
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.Controls.Add(this.kryptonStatusStrip);
			this.kryptonPanel.Controls.Add(this.buttonOK);
			this.kryptonPanel.Controls.Add(this.tableLayoutPanel);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(444, 180);
			this.kryptonPanel.TabIndex = 13;
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 158);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(444, 22);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 2;
			this.kryptonStatusStrip.Text = "status bar";
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Show some information";
			this.labelInformation.AccessibleName = "Show some information";
			this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelInformation.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(144, 17);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// DatabaseInformationForm
			// 
			this.AccessibleDescription = "Show the informations about the MPCORB.DAT database";
			this.AccessibleName = "Database Information";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 180);
			this.Controls.Add(this.kryptonPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DatabaseInformationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Database information";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseInformationForm_FormClosed);
			this.Load += new System.EventHandler(this.DatabaseInformationForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.ToolTip toolTip;
    private KryptonTableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelDirectory;
    private System.Windows.Forms.Label labelSize;
    private System.Windows.Forms.Label labelDateCreated;
    private System.Windows.Forms.Label labelDateAccessed;
    private System.Windows.Forms.Label labelDateWrited;
    private System.Windows.Forms.Label labelAttributes;
    private System.Windows.Forms.Label labelNameValue;
    private System.Windows.Forms.Label labelDirectoryValue;
    private System.Windows.Forms.Label labelSizeValue;
    private System.Windows.Forms.Label labelDateCreatedValue;
    private System.Windows.Forms.Label labelDateAccessedValue;
    private System.Windows.Forms.Label labelDateWritedValue;
    private System.Windows.Forms.Label labelAttributesValue;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}