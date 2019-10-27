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
			this.pictureBoxInformation = new System.Windows.Forms.PictureBox();
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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelHelp = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(185, 131);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "Okay");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			this.buttonOK.Enter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ButtonOK_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.MouseLeave += new System.EventHandler(this.ButtonOK_Leave);
			// 
			// pictureBoxInformation
			// 
			this.pictureBoxInformation.AccessibleDescription = "This is a information sign";
			this.pictureBoxInformation.AccessibleName = "Information";
			this.pictureBoxInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBoxInformation.Image = global::Planetoid_DB.Properties.Resources.silk_information;
			this.pictureBoxInformation.Location = new System.Drawing.Point(13, 13);
			this.pictureBoxInformation.Name = "pictureBoxInformation";
			this.pictureBoxInformation.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxInformation.TabIndex = 1;
			this.pictureBoxInformation.TabStop = false;
			this.toolTip.SetToolTip(this.pictureBoxInformation, "Information");
			this.pictureBoxInformation.Click += new System.EventHandler(this.PictureBoxInformation_Click);
			this.pictureBoxInformation.MouseEnter += new System.EventHandler(this.PictureBoxInformation_MouseEnter);
			this.pictureBoxInformation.MouseLeave += new System.EventHandler(this.PictureBoxInformation_MouseLeave);
			// 
			// labelName
			// 
			this.labelName.AccessibleDescription = "Show the name of the database";
			this.labelName.AccessibleName = "Name";
			this.labelName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(39, 15);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			this.toolTip.SetToolTip(this.labelName, "Name");
			this.labelName.DoubleClick += new System.EventHandler(this.LabelName_DoubleClick);
			this.labelName.Enter += new System.EventHandler(this.LabelName_Enter);
			this.labelName.Leave += new System.EventHandler(this.LabelName_Leave);
			this.labelName.MouseEnter += new System.EventHandler(this.LabelName_Enter);
			this.labelName.MouseLeave += new System.EventHandler(this.LabelName_Leave);
			// 
			// labelDirectory
			// 
			this.labelDirectory.AccessibleDescription = "Show the directory of the database";
			this.labelDirectory.AccessibleName = "Directory";
			this.labelDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectory.AutoSize = true;
			this.labelDirectory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDirectory.Location = new System.Drawing.Point(3, 15);
			this.labelDirectory.Name = "labelDirectory";
			this.labelDirectory.Size = new System.Drawing.Size(55, 15);
			this.labelDirectory.TabIndex = 2;
			this.labelDirectory.Text = "Directory";
			this.toolTip.SetToolTip(this.labelDirectory, "Directory");
			this.labelDirectory.DoubleClick += new System.EventHandler(this.LabelDirectory_DoubleClick);
			this.labelDirectory.Enter += new System.EventHandler(this.LabelDirectory_Enter);
			this.labelDirectory.Leave += new System.EventHandler(this.LabelDirectory_Leave);
			this.labelDirectory.MouseEnter += new System.EventHandler(this.LabelDirectory_Enter);
			// 
			// labelSize
			// 
			this.labelSize.AccessibleDescription = "Show the size of the database";
			this.labelSize.AccessibleName = "Size";
			this.labelSize.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSize.AutoSize = true;
			this.labelSize.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSize.Location = new System.Drawing.Point(3, 30);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(27, 15);
			this.labelSize.TabIndex = 4;
			this.labelSize.Text = "Size";
			this.toolTip.SetToolTip(this.labelSize, "Size");
			this.labelSize.DoubleClick += new System.EventHandler(this.LabelSize_DoubleClick);
			this.labelSize.Enter += new System.EventHandler(this.LabelSize_Enter);
			this.labelSize.Leave += new System.EventHandler(this.LabelSize_Leave);
			// 
			// labelDateCreated
			// 
			this.labelDateCreated.AccessibleDescription = "Show the creation date of the database";
			this.labelDateCreated.AccessibleName = "Creation date";
			this.labelDateCreated.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreated.AutoSize = true;
			this.labelDateCreated.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateCreated.Location = new System.Drawing.Point(3, 45);
			this.labelDateCreated.Name = "labelDateCreated";
			this.labelDateCreated.Size = new System.Drawing.Size(78, 15);
			this.labelDateCreated.TabIndex = 6;
			this.labelDateCreated.Text = "Creation date";
			this.toolTip.SetToolTip(this.labelDateCreated, "Creation date");
			this.labelDateCreated.DoubleClick += new System.EventHandler(this.LabelDateCreated_DoubleClick);
			this.labelDateCreated.Enter += new System.EventHandler(this.LabelDateCreated_Enter);
			this.labelDateCreated.Leave += new System.EventHandler(this.LabelDateCreated_Leave);
			this.labelDateCreated.MouseEnter += new System.EventHandler(this.LabelDateCreated_Enter);
			this.labelDateCreated.MouseLeave += new System.EventHandler(this.LabelDateCreated_Leave);
			// 
			// labelDateAccessed
			// 
			this.labelDateAccessed.AccessibleDescription = "Show the last access date of the database";
			this.labelDateAccessed.AccessibleName = "Last access date";
			this.labelDateAccessed.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessed.AutoSize = true;
			this.labelDateAccessed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateAccessed.Location = new System.Drawing.Point(3, 60);
			this.labelDateAccessed.Name = "labelDateAccessed";
			this.labelDateAccessed.Size = new System.Drawing.Size(91, 15);
			this.labelDateAccessed.TabIndex = 8;
			this.labelDateAccessed.Text = "Last access date";
			this.toolTip.SetToolTip(this.labelDateAccessed, "Last access date");
			this.labelDateAccessed.DoubleClick += new System.EventHandler(this.LabelDateAccessed_DoubleClick);
			this.labelDateAccessed.Enter += new System.EventHandler(this.LabelDateAccessed_Enter);
			this.labelDateAccessed.Leave += new System.EventHandler(this.LabelDateAccessed_Leave);
			this.labelDateAccessed.MouseEnter += new System.EventHandler(this.LabelDateAccessed_Enter);
			this.labelDateAccessed.MouseLeave += new System.EventHandler(this.LabelDateAccessed_Leave);
			// 
			// labelDateWrited
			// 
			this.labelDateWrited.AccessibleDescription = "Show the last write date of the database";
			this.labelDateWrited.AccessibleName = "Last write date";
			this.labelDateWrited.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWrited.AutoSize = true;
			this.labelDateWrited.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateWrited.Location = new System.Drawing.Point(3, 75);
			this.labelDateWrited.Name = "labelDateWrited";
			this.labelDateWrited.Size = new System.Drawing.Size(83, 15);
			this.labelDateWrited.TabIndex = 10;
			this.labelDateWrited.Text = "Last write date";
			this.toolTip.SetToolTip(this.labelDateWrited, "Last write date");
			this.labelDateWrited.DoubleClick += new System.EventHandler(this.LabelDateWrited_DoubleClick);
			this.labelDateWrited.Enter += new System.EventHandler(this.LabelDateWrited_Enter);
			this.labelDateWrited.Leave += new System.EventHandler(this.LabelDateWrited_Leave);
			this.labelDateWrited.MouseEnter += new System.EventHandler(this.LabelDateWrited_Enter);
			this.labelDateWrited.MouseLeave += new System.EventHandler(this.LabelDateWrited_Leave);
			// 
			// labelAttributes
			// 
			this.labelAttributes.AccessibleDescription = "Show the attributes of the database";
			this.labelAttributes.AccessibleName = "Attributes";
			this.labelAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributes.AutoSize = true;
			this.labelAttributes.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelAttributes.Location = new System.Drawing.Point(3, 90);
			this.labelAttributes.Name = "labelAttributes";
			this.labelAttributes.Size = new System.Drawing.Size(59, 15);
			this.labelAttributes.TabIndex = 12;
			this.labelAttributes.Text = "Attributes";
			this.toolTip.SetToolTip(this.labelAttributes, "Attributes");
			this.labelAttributes.DoubleClick += new System.EventHandler(this.LabelAttributes_DoubleClick);
			this.labelAttributes.Enter += new System.EventHandler(this.LabelAttributes_Enter);
			this.labelAttributes.Leave += new System.EventHandler(this.LabelAttributes_Leave);
			this.labelAttributes.MouseEnter += new System.EventHandler(this.LabelAttributes_Enter);
			this.labelAttributes.MouseLeave += new System.EventHandler(this.LabelAttributes_Leave);
			// 
			// labelNameValue
			// 
			this.labelNameValue.AccessibleDescription = "Show the name of the database";
			this.labelNameValue.AccessibleName = "Name value";
			this.labelNameValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNameValue.AutoSize = true;
			this.labelNameValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelNameValue.Location = new System.Drawing.Point(100, 0);
			this.labelNameValue.Name = "labelNameValue";
			this.labelNameValue.Size = new System.Drawing.Size(16, 15);
			this.labelNameValue.TabIndex = 1;
			this.labelNameValue.Text = "...";
			this.toolTip.SetToolTip(this.labelNameValue, "Show the name of the database");
			this.labelNameValue.DoubleClick += new System.EventHandler(this.LabelNameValue_DoubleClick);
			this.labelNameValue.Enter += new System.EventHandler(this.LabelNameValue_Enter);
			this.labelNameValue.Leave += new System.EventHandler(this.LabelNameValue_Leave);
			this.labelNameValue.MouseEnter += new System.EventHandler(this.LabelNameValue_Enter);
			this.labelNameValue.MouseLeave += new System.EventHandler(this.LabelNameValue_Leave);
			// 
			// labelDirectoryValue
			// 
			this.labelDirectoryValue.AccessibleDescription = "Show the directory of the database";
			this.labelDirectoryValue.AccessibleName = "Directory value";
			this.labelDirectoryValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectoryValue.AutoSize = true;
			this.labelDirectoryValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDirectoryValue.Location = new System.Drawing.Point(100, 15);
			this.labelDirectoryValue.Name = "labelDirectoryValue";
			this.labelDirectoryValue.Size = new System.Drawing.Size(16, 15);
			this.labelDirectoryValue.TabIndex = 3;
			this.labelDirectoryValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDirectoryValue, "Show the directory of the database");
			this.labelDirectoryValue.DoubleClick += new System.EventHandler(this.LabelDirectoryValue_DoubleClick);
			this.labelDirectoryValue.Enter += new System.EventHandler(this.LabelDirectoryValue_Enter);
			this.labelDirectoryValue.Leave += new System.EventHandler(this.LabelDirectoryValue_Leave);
			this.labelDirectoryValue.MouseEnter += new System.EventHandler(this.LabelDirectoryValue_Enter);
			this.labelDirectoryValue.MouseLeave += new System.EventHandler(this.LabelDirectoryValue_Leave);
			// 
			// labelSizeValue
			// 
			this.labelSizeValue.AccessibleDescription = "Show the size of the database";
			this.labelSizeValue.AccessibleName = "size value";
			this.labelSizeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeValue.AutoSize = true;
			this.labelSizeValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSizeValue.Location = new System.Drawing.Point(100, 30);
			this.labelSizeValue.Name = "labelSizeValue";
			this.labelSizeValue.Size = new System.Drawing.Size(16, 15);
			this.labelSizeValue.TabIndex = 5;
			this.labelSizeValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSizeValue, "Show the size of the database");
			this.labelSizeValue.DoubleClick += new System.EventHandler(this.LabelSizeValue_DoubleClick);
			this.labelSizeValue.Enter += new System.EventHandler(this.LabelSizeValue_Enter);
			this.labelSizeValue.Leave += new System.EventHandler(this.LabelSizeValue_Leave);
			this.labelSizeValue.MouseEnter += new System.EventHandler(this.LabelSizeValue_Enter);
			this.labelSizeValue.MouseLeave += new System.EventHandler(this.LabelSizeValue_Leave);
			// 
			// labelDateCreatedValue
			// 
			this.labelDateCreatedValue.AccessibleDescription = "Show the creation date of the database";
			this.labelDateCreatedValue.AccessibleName = "Creation date value";
			this.labelDateCreatedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreatedValue.AutoSize = true;
			this.labelDateCreatedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateCreatedValue.Location = new System.Drawing.Point(100, 45);
			this.labelDateCreatedValue.Name = "labelDateCreatedValue";
			this.labelDateCreatedValue.Size = new System.Drawing.Size(16, 15);
			this.labelDateCreatedValue.TabIndex = 7;
			this.labelDateCreatedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateCreatedValue, "Show the creation date of the database");
			this.labelDateCreatedValue.DoubleClick += new System.EventHandler(this.LabelDateCreatedValue_DoubleClick);
			this.labelDateCreatedValue.Enter += new System.EventHandler(this.LabelDateCreatedValue_Enter);
			this.labelDateCreatedValue.Leave += new System.EventHandler(this.LabelDateCreatedValue_Leave);
			this.labelDateCreatedValue.MouseEnter += new System.EventHandler(this.LabelDateCreatedValue_Enter);
			this.labelDateCreatedValue.MouseLeave += new System.EventHandler(this.LabelDateCreatedValue_Leave);
			// 
			// labelDateAccessedValue
			// 
			this.labelDateAccessedValue.AccessibleDescription = "Show the last access date of the database";
			this.labelDateAccessedValue.AccessibleName = "Last access date value";
			this.labelDateAccessedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessedValue.AutoSize = true;
			this.labelDateAccessedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateAccessedValue.Location = new System.Drawing.Point(100, 60);
			this.labelDateAccessedValue.Name = "labelDateAccessedValue";
			this.labelDateAccessedValue.Size = new System.Drawing.Size(16, 15);
			this.labelDateAccessedValue.TabIndex = 9;
			this.labelDateAccessedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateAccessedValue, "Show the last access date of the database");
			this.labelDateAccessedValue.DoubleClick += new System.EventHandler(this.LabelDateAccessedValue_DoubleClick);
			this.labelDateAccessedValue.Enter += new System.EventHandler(this.LabelDateAccessedValue_Enter);
			this.labelDateAccessedValue.Leave += new System.EventHandler(this.LabelDateAccessedValue_Leave);
			this.labelDateAccessedValue.MouseEnter += new System.EventHandler(this.LabelDateAccessedValue_Enter);
			this.labelDateAccessedValue.MouseLeave += new System.EventHandler(this.LabelDateAccessedValue_Leave);
			// 
			// labelDateWritedValue
			// 
			this.labelDateWritedValue.AccessibleDescription = "Show the last write date of the database";
			this.labelDateWritedValue.AccessibleName = "Last write date value";
			this.labelDateWritedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWritedValue.AutoSize = true;
			this.labelDateWritedValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelDateWritedValue.Location = new System.Drawing.Point(100, 75);
			this.labelDateWritedValue.Name = "labelDateWritedValue";
			this.labelDateWritedValue.Size = new System.Drawing.Size(16, 15);
			this.labelDateWritedValue.TabIndex = 11;
			this.labelDateWritedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateWritedValue, "Show the last write date of the database");
			this.labelDateWritedValue.DoubleClick += new System.EventHandler(this.LabelDateWritedValue_DoubleClick);
			this.labelDateWritedValue.Enter += new System.EventHandler(this.LabelDateWritedValue_Enter);
			this.labelDateWritedValue.Leave += new System.EventHandler(this.LabelDateWritedValue_Leave);
			this.labelDateWritedValue.MouseEnter += new System.EventHandler(this.LabelDateWritedValue_Enter);
			this.labelDateWritedValue.MouseLeave += new System.EventHandler(this.LabelDateWritedValue_Leave);
			// 
			// labelAttributesValue
			// 
			this.labelAttributesValue.AccessibleDescription = "Show the attributes of the database";
			this.labelAttributesValue.AccessibleName = "Attributes value";
			this.labelAttributesValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributesValue.AutoSize = true;
			this.labelAttributesValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelAttributesValue.Location = new System.Drawing.Point(100, 90);
			this.labelAttributesValue.Name = "labelAttributesValue";
			this.labelAttributesValue.Size = new System.Drawing.Size(16, 15);
			this.labelAttributesValue.TabIndex = 13;
			this.labelAttributesValue.Text = "...";
			this.toolTip.SetToolTip(this.labelAttributesValue, "Show the attributes of the database");
			this.labelAttributesValue.DoubleClick += new System.EventHandler(this.LabelAttributesValue_DoubleClick);
			this.labelAttributesValue.Enter += new System.EventHandler(this.LabelAttributesValue_Enter);
			this.labelAttributesValue.Leave += new System.EventHandler(this.LabelAttributesValue_Leave);
			this.labelAttributesValue.MouseEnter += new System.EventHandler(this.LabelAttributesValue_Enter);
			this.labelAttributesValue.MouseLeave += new System.EventHandler(this.LabelAttributesValue_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the information";
			this.tableLayoutPanel.AccessibleName = "Information";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
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
			this.tableLayoutPanel.Location = new System.Drawing.Point(35, 13);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 7;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(379, 110);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the status";
			this.statusStrip.AccessibleName = "Status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelHelp});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 164);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(444, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 12;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelHelp
			// 
			this.labelHelp.AccessibleDescription = "Show some important informations";
			this.labelHelp.AccessibleName = "Information field";
			this.labelHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelHelp.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelHelp.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(170, 16);
			this.labelHelp.Text = "Show informative messages";
			this.labelHelp.ToolTipText = "Show informative messages";
			// 
			// DatabaseInformationForm
			// 
			this.AccessibleDescription = "Show the informations about the MPCORB.DAT database";
			this.AccessibleName = "Database Information";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 185);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.pictureBoxInformation);
			this.Controls.Add(this.buttonOK);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DatabaseInformationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database information";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseInformationForm_FormClosed);
			this.Load += new System.EventHandler(this.DatabaseInformationForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.PictureBox pictureBoxInformation;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
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
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelHelp;
	}
}