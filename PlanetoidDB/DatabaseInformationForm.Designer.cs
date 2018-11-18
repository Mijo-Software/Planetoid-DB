namespace PlanetoidDB
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(203, 170);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "Okay");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
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
			this.pictureBoxInformation.Click += new System.EventHandler(this.pictureBoxInformation_Click);
			// 
			// labelName
			// 
			this.labelName.AccessibleDescription = "Show the name of the database";
			this.labelName.AccessibleName = "Name";
			this.labelName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			this.toolTip.SetToolTip(this.labelName, "Name");
			this.labelName.DoubleClick += new System.EventHandler(this.labelName_DoubleClick);
			// 
			// labelDirectory
			// 
			this.labelDirectory.AccessibleDescription = "Show the directory of the database";
			this.labelDirectory.AccessibleName = "Directory";
			this.labelDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectory.AutoSize = true;
			this.labelDirectory.Location = new System.Drawing.Point(3, 21);
			this.labelDirectory.Name = "labelDirectory";
			this.labelDirectory.Size = new System.Drawing.Size(49, 13);
			this.labelDirectory.TabIndex = 2;
			this.labelDirectory.Text = "Directory";
			this.toolTip.SetToolTip(this.labelDirectory, "Directory");
			this.labelDirectory.DoubleClick += new System.EventHandler(this.labelDirectory_DoubleClick);
			// 
			// labelSize
			// 
			this.labelSize.AccessibleDescription = "Show the size of the database";
			this.labelSize.AccessibleName = "Size";
			this.labelSize.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSize.AutoSize = true;
			this.labelSize.Location = new System.Drawing.Point(3, 42);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(27, 13);
			this.labelSize.TabIndex = 4;
			this.labelSize.Text = "Size";
			this.toolTip.SetToolTip(this.labelSize, "Size");
			this.labelSize.DoubleClick += new System.EventHandler(this.labelSize_DoubleClick);
			// 
			// labelDateCreated
			// 
			this.labelDateCreated.AccessibleDescription = "Show the creation date of the database";
			this.labelDateCreated.AccessibleName = "Creation date";
			this.labelDateCreated.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreated.AutoSize = true;
			this.labelDateCreated.Location = new System.Drawing.Point(3, 63);
			this.labelDateCreated.Name = "labelDateCreated";
			this.labelDateCreated.Size = new System.Drawing.Size(70, 13);
			this.labelDateCreated.TabIndex = 6;
			this.labelDateCreated.Text = "Creation date";
			this.toolTip.SetToolTip(this.labelDateCreated, "Creation date");
			this.labelDateCreated.DoubleClick += new System.EventHandler(this.labelDateCreated_DoubleClick);
			// 
			// labelDateAccessed
			// 
			this.labelDateAccessed.AccessibleDescription = "Show the last access date of the database";
			this.labelDateAccessed.AccessibleName = "Last access date";
			this.labelDateAccessed.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessed.AutoSize = true;
			this.labelDateAccessed.Location = new System.Drawing.Point(3, 84);
			this.labelDateAccessed.Name = "labelDateAccessed";
			this.labelDateAccessed.Size = new System.Drawing.Size(88, 13);
			this.labelDateAccessed.TabIndex = 8;
			this.labelDateAccessed.Text = "Last access date";
			this.toolTip.SetToolTip(this.labelDateAccessed, "Last access date");
			this.labelDateAccessed.DoubleClick += new System.EventHandler(this.labelDateAccessed_DoubleClick);
			// 
			// labelDateWrited
			// 
			this.labelDateWrited.AccessibleDescription = "Show the last write date of the database";
			this.labelDateWrited.AccessibleName = "Last write date";
			this.labelDateWrited.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWrited.AutoSize = true;
			this.labelDateWrited.Location = new System.Drawing.Point(3, 105);
			this.labelDateWrited.Name = "labelDateWrited";
			this.labelDateWrited.Size = new System.Drawing.Size(76, 13);
			this.labelDateWrited.TabIndex = 10;
			this.labelDateWrited.Text = "Last write date";
			this.toolTip.SetToolTip(this.labelDateWrited, "Last write date");
			this.labelDateWrited.DoubleClick += new System.EventHandler(this.labelDateWrited_DoubleClick);
			// 
			// labelAttributes
			// 
			this.labelAttributes.AccessibleDescription = "Show the attributes of the database";
			this.labelAttributes.AccessibleName = "Attributes";
			this.labelAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributes.AutoSize = true;
			this.labelAttributes.Location = new System.Drawing.Point(3, 126);
			this.labelAttributes.Name = "labelAttributes";
			this.labelAttributes.Size = new System.Drawing.Size(51, 13);
			this.labelAttributes.TabIndex = 12;
			this.labelAttributes.Text = "Attributes";
			this.toolTip.SetToolTip(this.labelAttributes, "Attributes");
			this.labelAttributes.DoubleClick += new System.EventHandler(this.labelAttributes_DoubleClick);
			// 
			// labelNameValue
			// 
			this.labelNameValue.AccessibleDescription = "Show the name of the database";
			this.labelNameValue.AccessibleName = "Name value";
			this.labelNameValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNameValue.AutoSize = true;
			this.labelNameValue.Location = new System.Drawing.Point(97, 0);
			this.labelNameValue.Name = "labelNameValue";
			this.labelNameValue.Size = new System.Drawing.Size(16, 13);
			this.labelNameValue.TabIndex = 1;
			this.labelNameValue.Text = "...";
			this.toolTip.SetToolTip(this.labelNameValue, "Name");
			this.labelNameValue.DoubleClick += new System.EventHandler(this.labelNameValue_DoubleClick);
			// 
			// labelDirectoryValue
			// 
			this.labelDirectoryValue.AccessibleDescription = "Show the directory of the database";
			this.labelDirectoryValue.AccessibleName = "Directory value";
			this.labelDirectoryValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDirectoryValue.AutoSize = true;
			this.labelDirectoryValue.Location = new System.Drawing.Point(97, 21);
			this.labelDirectoryValue.Name = "labelDirectoryValue";
			this.labelDirectoryValue.Size = new System.Drawing.Size(16, 13);
			this.labelDirectoryValue.TabIndex = 3;
			this.labelDirectoryValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDirectoryValue, "Directory");
			this.labelDirectoryValue.DoubleClick += new System.EventHandler(this.labelDirectoryValue_DoubleClick);
			// 
			// labelSizeValue
			// 
			this.labelSizeValue.AccessibleDescription = "Show the size of the database";
			this.labelSizeValue.AccessibleName = "size value";
			this.labelSizeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSizeValue.AutoSize = true;
			this.labelSizeValue.Location = new System.Drawing.Point(97, 42);
			this.labelSizeValue.Name = "labelSizeValue";
			this.labelSizeValue.Size = new System.Drawing.Size(16, 13);
			this.labelSizeValue.TabIndex = 5;
			this.labelSizeValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSizeValue, "Size");
			this.labelSizeValue.DoubleClick += new System.EventHandler(this.labelSizeValue_DoubleClick);
			// 
			// labelDateCreatedValue
			// 
			this.labelDateCreatedValue.AccessibleDescription = "Show the creation date of the database";
			this.labelDateCreatedValue.AccessibleName = "Creation date value";
			this.labelDateCreatedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateCreatedValue.AutoSize = true;
			this.labelDateCreatedValue.Location = new System.Drawing.Point(97, 63);
			this.labelDateCreatedValue.Name = "labelDateCreatedValue";
			this.labelDateCreatedValue.Size = new System.Drawing.Size(16, 13);
			this.labelDateCreatedValue.TabIndex = 7;
			this.labelDateCreatedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateCreatedValue, "Creation date");
			this.labelDateCreatedValue.DoubleClick += new System.EventHandler(this.labelDateCreatedValue_DoubleClick);
			// 
			// labelDateAccessedValue
			// 
			this.labelDateAccessedValue.AccessibleDescription = "Show the last access date of the database";
			this.labelDateAccessedValue.AccessibleName = "Last access date value";
			this.labelDateAccessedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateAccessedValue.AutoSize = true;
			this.labelDateAccessedValue.Location = new System.Drawing.Point(97, 84);
			this.labelDateAccessedValue.Name = "labelDateAccessedValue";
			this.labelDateAccessedValue.Size = new System.Drawing.Size(16, 13);
			this.labelDateAccessedValue.TabIndex = 9;
			this.labelDateAccessedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateAccessedValue, "Last access date");
			this.labelDateAccessedValue.DoubleClick += new System.EventHandler(this.labelDateAccessedValue_DoubleClick);
			// 
			// labelDateWritedValue
			// 
			this.labelDateWritedValue.AccessibleDescription = "Show the last write date of the database";
			this.labelDateWritedValue.AccessibleName = "Last write date value";
			this.labelDateWritedValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDateWritedValue.AutoSize = true;
			this.labelDateWritedValue.Location = new System.Drawing.Point(97, 105);
			this.labelDateWritedValue.Name = "labelDateWritedValue";
			this.labelDateWritedValue.Size = new System.Drawing.Size(16, 13);
			this.labelDateWritedValue.TabIndex = 11;
			this.labelDateWritedValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDateWritedValue, "Last write date");
			this.labelDateWritedValue.DoubleClick += new System.EventHandler(this.labelDateWritedValue_DoubleClick);
			// 
			// labelAttributesValue
			// 
			this.labelAttributesValue.AccessibleDescription = "Show the attributes of the database";
			this.labelAttributesValue.AccessibleName = "Attributes value";
			this.labelAttributesValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelAttributesValue.AutoSize = true;
			this.labelAttributesValue.Location = new System.Drawing.Point(97, 126);
			this.labelAttributesValue.Name = "labelAttributesValue";
			this.labelAttributesValue.Size = new System.Drawing.Size(16, 13);
			this.labelAttributesValue.TabIndex = 13;
			this.labelAttributesValue.Text = "...";
			this.toolTip.SetToolTip(this.labelAttributesValue, "Attributes");
			this.labelAttributesValue.DoubleClick += new System.EventHandler(this.labelAttributesValue_DoubleClick);
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
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(379, 151);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// DatabaseInformationForm
			// 
			this.AccessibleDescription = "Show the informations about the MPCORB.DAT database";
			this.AccessibleName = "Database Information";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 203);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.pictureBoxInformation);
			this.Controls.Add(this.buttonOK);
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
  }
}