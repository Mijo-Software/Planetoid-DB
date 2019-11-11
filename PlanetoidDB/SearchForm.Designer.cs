namespace Planetoid_DB
{
	partial class SearchForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonFind = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBoxSearchIn = new System.Windows.Forms.GroupBox();
			this.checkedListBoxSearchIn = new System.Windows.Forms.CheckedListBox();
			this.groupBoxOptions = new System.Windows.Forms.GroupBox();
			this.radioButtonFulltext = new System.Windows.Forms.RadioButton();
			this.radioButtonParttext = new System.Windows.Forms.RadioButton();
			this.buttonSelectAll = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
			this.listViewTableMode = new System.Windows.Forms.ListView();
			this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderReadableDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonOpenSelectedObject = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonOK = new System.Windows.Forms.Button();
			this.groupBoxSearchIn.SuspendLayout();
			this.groupBoxOptions.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Term:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(52, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(233, 23);
			this.textBox1.TabIndex = 1;
			// 
			// buttonFind
			// 
			this.buttonFind.Image = global::Planetoid_DB.Properties.Resources.silk_find;
			this.buttonFind.Location = new System.Drawing.Point(291, 4);
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new System.Drawing.Size(69, 23);
			this.buttonFind.TabIndex = 2;
			this.buttonFind.Text = "&Find";
			this.buttonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonFind.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.button2.Location = new System.Drawing.Point(366, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "&Cancel";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// groupBoxSearchIn
			// 
			this.groupBoxSearchIn.Controls.Add(this.checkedListBoxSearchIn);
			this.groupBoxSearchIn.Location = new System.Drawing.Point(15, 32);
			this.groupBoxSearchIn.Name = "groupBoxSearchIn";
			this.groupBoxSearchIn.Size = new System.Drawing.Size(254, 99);
			this.groupBoxSearchIn.TabIndex = 4;
			this.groupBoxSearchIn.TabStop = false;
			this.groupBoxSearchIn.Text = "&Search in";
			// 
			// checkedListBoxSearchIn
			// 
			this.checkedListBoxSearchIn.CheckOnClick = true;
			this.checkedListBoxSearchIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxSearchIn.FormattingEnabled = true;
			this.checkedListBoxSearchIn.HorizontalScrollbar = true;
			this.checkedListBoxSearchIn.Items.AddRange(new object[] {
            "Readable designation",
            "Epoch",
            "Mean anomaly at the epoch",
            "Argument of perihelion",
            "Longitude of the ascending node",
            "Inclination to the ecliptic",
            "Orbital eccentricity",
            "Mean daily motion",
            "Semimajor axis",
            "Absolute magnitude",
            "Slope paramter",
            "Reference",
            "Number of oppositions",
            "Number of observations",
            "Observation span",
            "r.m.s. residual",
            "Computer name",
            "4-hexdigit flags",
            "Date of last observation"});
			this.checkedListBoxSearchIn.Location = new System.Drawing.Point(3, 19);
			this.checkedListBoxSearchIn.Name = "checkedListBoxSearchIn";
			this.checkedListBoxSearchIn.Size = new System.Drawing.Size(248, 77);
			this.checkedListBoxSearchIn.TabIndex = 0;
			// 
			// groupBoxOptions
			// 
			this.groupBoxOptions.Controls.Add(this.radioButtonFulltext);
			this.groupBoxOptions.Controls.Add(this.radioButtonParttext);
			this.groupBoxOptions.Location = new System.Drawing.Point(366, 35);
			this.groupBoxOptions.Name = "groupBoxOptions";
			this.groupBoxOptions.Size = new System.Drawing.Size(79, 96);
			this.groupBoxOptions.TabIndex = 5;
			this.groupBoxOptions.TabStop = false;
			this.groupBoxOptions.Text = "&Options";
			// 
			// radioButtonFulltext
			// 
			this.radioButtonFulltext.AutoSize = true;
			this.radioButtonFulltext.Location = new System.Drawing.Point(6, 42);
			this.radioButtonFulltext.Name = "radioButtonFulltext";
			this.radioButtonFulltext.Size = new System.Drawing.Size(64, 19);
			this.radioButtonFulltext.TabIndex = 1;
			this.radioButtonFulltext.Text = "full text";
			this.radioButtonFulltext.UseVisualStyleBackColor = true;
			// 
			// radioButtonParttext
			// 
			this.radioButtonParttext.AutoSize = true;
			this.radioButtonParttext.Checked = true;
			this.radioButtonParttext.Location = new System.Drawing.Point(6, 19);
			this.radioButtonParttext.Name = "radioButtonParttext";
			this.radioButtonParttext.Size = new System.Drawing.Size(68, 19);
			this.radioButtonParttext.TabIndex = 0;
			this.radioButtonParttext.TabStop = true;
			this.radioButtonParttext.Text = "part text";
			this.radioButtonParttext.UseVisualStyleBackColor = true;
			// 
			// buttonSelectAll
			// 
			this.buttonSelectAll.Image = global::Planetoid_DB.Properties.Resources.silk_asterisk_yellow;
			this.buttonSelectAll.Location = new System.Drawing.Point(275, 48);
			this.buttonSelectAll.Name = "buttonSelectAll";
			this.buttonSelectAll.Size = new System.Drawing.Size(85, 23);
			this.buttonSelectAll.TabIndex = 6;
			this.buttonSelectAll.Text = "Select &all";
			this.buttonSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSelectAll.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "&Progress:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(72, 146);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(331, 13);
			this.progressBar1.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(409, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "100 %";
			// 
			// listViewTableMode
			// 
			this.listViewTableMode.AccessibleDescription = "Show the list with the items";
			this.listViewTableMode.AccessibleName = "List";
			this.listViewTableMode.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
			this.listViewTableMode.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewTableMode.AllowColumnReorder = true;
			this.listViewTableMode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderReadableDesignation,
            this.columnHeaderItem,
            this.columnHeaderValue});
			this.listViewTableMode.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.listViewTableMode.FullRowSelect = true;
			this.listViewTableMode.GridLines = true;
			this.listViewTableMode.HideSelection = false;
			this.listViewTableMode.Location = new System.Drawing.Point(15, 165);
			this.listViewTableMode.MultiSelect = false;
			this.listViewTableMode.Name = "listViewTableMode";
			this.listViewTableMode.ShowItemToolTips = true;
			this.listViewTableMode.Size = new System.Drawing.Size(430, 166);
			this.listViewTableMode.TabIndex = 10;
			this.listViewTableMode.UseCompatibleStateImageBehavior = false;
			this.listViewTableMode.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderIndex
			// 
			this.columnHeaderIndex.Text = "Index No.";
			this.columnHeaderIndex.Width = 70;
			// 
			// columnHeaderReadableDesignation
			// 
			this.columnHeaderReadableDesignation.Text = "Readable designation";
			this.columnHeaderReadableDesignation.Width = 150;
			// 
			// columnHeaderItem
			// 
			this.columnHeaderItem.Text = "Item";
			this.columnHeaderItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderItem.Width = 100;
			// 
			// columnHeaderValue
			// 
			this.columnHeaderValue.Text = "Value";
			this.columnHeaderValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderValue.Width = 100;
			// 
			// statusBar
			// 
			this.statusBar.AccessibleDescription = "Shows some information";
			this.statusBar.AccessibleName = "Status bar of some information";
			this.statusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusBar.Location = new System.Drawing.Point(0, 369);
			this.statusBar.Name = "statusBar";
			this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusBar.ShowItemToolTips = true;
			this.statusBar.Size = new System.Drawing.Size(457, 21);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 14;
			this.statusBar.TabStop = true;
			this.statusBar.Text = "statusStrip";
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
			this.labelInformation.Size = new System.Drawing.Size(116, 16);
			this.labelInformation.Spring = true;
			this.labelInformation.Text = "Show tooltip here";
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// buttonOpenSelectedObject
			// 
			this.buttonOpenSelectedObject.Image = global::Planetoid_DB.Properties.Resources.silk_application_go;
			this.buttonOpenSelectedObject.Location = new System.Drawing.Point(291, 337);
			this.buttonOpenSelectedObject.Name = "buttonOpenSelectedObject";
			this.buttonOpenSelectedObject.Size = new System.Drawing.Size(154, 23);
			this.buttonOpenSelectedObject.TabIndex = 15;
			this.buttonOpenSelectedObject.Text = "Open selected o&bject";
			this.buttonOpenSelectedObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOpenSelectedObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonOpenSelectedObject.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Okay";
			this.buttonOK.AccessibleName = "OK";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(210, 337);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 16;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "OK");
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 390);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonOpenSelectedObject);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.listViewTableMode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSelectAll);
			this.Controls.Add(this.groupBoxOptions);
			this.Controls.Add(this.groupBoxSearchIn);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonFind);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Search";
			this.groupBoxSearchIn.ResumeLayout(false);
			this.groupBoxOptions.ResumeLayout(false);
			this.groupBoxOptions.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonFind;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBoxSearchIn;
		private System.Windows.Forms.CheckedListBox checkedListBoxSearchIn;
		private System.Windows.Forms.GroupBox groupBoxOptions;
		private System.Windows.Forms.RadioButton radioButtonFulltext;
		private System.Windows.Forms.RadioButton radioButtonParttext;
		private System.Windows.Forms.Button buttonSelectAll;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listViewTableMode;
		private System.Windows.Forms.ColumnHeader columnHeaderIndex;
		private System.Windows.Forms.ColumnHeader columnHeaderReadableDesignation;
		private System.Windows.Forms.ColumnHeader columnHeaderItem;
		private System.Windows.Forms.ColumnHeader columnHeaderValue;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.Button buttonOpenSelectedObject;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button buttonOK;
	}
}