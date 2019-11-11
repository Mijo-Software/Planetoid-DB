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
			this.labelSearchterm = new System.Windows.Forms.Label();
			this.textBoxSearchfield = new System.Windows.Forms.TextBox();
			this.buttonFindSearchterm = new System.Windows.Forms.Button();
			this.buttonCancelSearch = new System.Windows.Forms.Button();
			this.groupBoxSearchIn = new System.Windows.Forms.GroupBox();
			this.buttonUnselectAllItems = new System.Windows.Forms.Button();
			this.checkedListBoxSearchIn = new System.Windows.Forms.CheckedListBox();
			this.buttonSelectAllItems = new System.Windows.Forms.Button();
			this.groupBoxSearchOptions = new System.Windows.Forms.GroupBox();
			this.radioButtonFulltext = new System.Windows.Forms.RadioButton();
			this.radioButtonParttext = new System.Windows.Forms.RadioButton();
			this.labelProgress = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.labelProgressPercent = new System.Windows.Forms.Label();
			this.listViewResults = new System.Windows.Forms.ListView();
			this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderReadableDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonOpenSelectedObject = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonOK = new System.Windows.Forms.Button();
			this.numericUpDownRangeMaximum = new System.Windows.Forms.NumericUpDown();
			this.labelRangeMaximum = new System.Windows.Forms.Label();
			this.numericUpDownRangeMinimum = new System.Windows.Forms.NumericUpDown();
			this.labelRangeMinimum = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBoxRange = new System.Windows.Forms.GroupBox();
			this.buttonSetDefaultSettings = new System.Windows.Forms.Button();
			this.groupBoxSearchIn.SuspendLayout();
			this.groupBoxSearchOptions.SuspendLayout();
			this.statusBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMaximum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMinimum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.groupBoxRange.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelSearchterm
			// 
			this.labelSearchterm.AutoSize = true;
			this.labelSearchterm.Location = new System.Drawing.Point(12, 9);
			this.labelSearchterm.Name = "labelSearchterm";
			this.labelSearchterm.Size = new System.Drawing.Size(38, 15);
			this.labelSearchterm.TabIndex = 0;
			this.labelSearchterm.Text = "&Term:";
			this.labelSearchterm.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSearchterm.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSearchterm.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSearchterm.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// textBoxSearchfield
			// 
			this.textBoxSearchfield.Location = new System.Drawing.Point(52, 6);
			this.textBoxSearchfield.Name = "textBoxSearchfield";
			this.textBoxSearchfield.Size = new System.Drawing.Size(253, 23);
			this.textBoxSearchfield.TabIndex = 1;
			this.textBoxSearchfield.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSearchfield.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.textBoxSearchfield.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSearchfield.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonFindSearchterm
			// 
			this.buttonFindSearchterm.Image = global::Planetoid_DB.Properties.Resources.silk_find;
			this.buttonFindSearchterm.Location = new System.Drawing.Point(311, 4);
			this.buttonFindSearchterm.Name = "buttonFindSearchterm";
			this.buttonFindSearchterm.Size = new System.Drawing.Size(69, 25);
			this.buttonFindSearchterm.TabIndex = 2;
			this.buttonFindSearchterm.Text = "&Find";
			this.buttonFindSearchterm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonFindSearchterm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonFindSearchterm.UseVisualStyleBackColor = true;
			this.buttonFindSearchterm.Click += new System.EventHandler(this.ButtonFindSearchterm_Click);
			this.buttonFindSearchterm.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonFindSearchterm.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonFindSearchterm.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonFindSearchterm.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCancelSearch
			// 
			this.buttonCancelSearch.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.buttonCancelSearch.Location = new System.Drawing.Point(386, 4);
			this.buttonCancelSearch.Name = "buttonCancelSearch";
			this.buttonCancelSearch.Size = new System.Drawing.Size(69, 25);
			this.buttonCancelSearch.TabIndex = 3;
			this.buttonCancelSearch.Text = "&Cancel";
			this.buttonCancelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCancelSearch.UseVisualStyleBackColor = true;
			this.buttonCancelSearch.Click += new System.EventHandler(this.ButtonCancelSearch_Click);
			this.buttonCancelSearch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelSearch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCancelSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupBoxSearchIn
			// 
			this.groupBoxSearchIn.Controls.Add(this.buttonUnselectAllItems);
			this.groupBoxSearchIn.Controls.Add(this.checkedListBoxSearchIn);
			this.groupBoxSearchIn.Controls.Add(this.buttonSelectAllItems);
			this.groupBoxSearchIn.Location = new System.Drawing.Point(15, 32);
			this.groupBoxSearchIn.Name = "groupBoxSearchIn";
			this.groupBoxSearchIn.Size = new System.Drawing.Size(354, 99);
			this.groupBoxSearchIn.TabIndex = 4;
			this.groupBoxSearchIn.TabStop = false;
			this.groupBoxSearchIn.Text = "&Search in";
			// 
			// buttonUnselectAllItems
			// 
			this.buttonUnselectAllItems.Image = global::Planetoid_DB.Properties.Resources.silk_asterisk_yellow;
			this.buttonUnselectAllItems.Location = new System.Drawing.Point(254, 47);
			this.buttonUnselectAllItems.Name = "buttonUnselectAllItems";
			this.buttonUnselectAllItems.Size = new System.Drawing.Size(94, 23);
			this.buttonUnselectAllItems.TabIndex = 2;
			this.buttonUnselectAllItems.Text = "&Unselect all";
			this.buttonUnselectAllItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonUnselectAllItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonUnselectAllItems.UseVisualStyleBackColor = true;
			this.buttonUnselectAllItems.Click += new System.EventHandler(this.ButtonUnselectAllItems_Click);
			this.buttonUnselectAllItems.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonUnselectAllItems.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonUnselectAllItems.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonUnselectAllItems.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// checkedListBoxSearchIn
			// 
			this.checkedListBoxSearchIn.CheckOnClick = true;
			this.checkedListBoxSearchIn.Dock = System.Windows.Forms.DockStyle.Left;
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
			this.checkedListBoxSearchIn.Size = new System.Drawing.Size(243, 77);
			this.checkedListBoxSearchIn.TabIndex = 0;
			this.checkedListBoxSearchIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkedListBoxSearchIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkedListBoxSearchIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkedListBoxSearchIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSelectAllItems
			// 
			this.buttonSelectAllItems.Image = global::Planetoid_DB.Properties.Resources.silk_asterisk_yellow;
			this.buttonSelectAllItems.Location = new System.Drawing.Point(254, 18);
			this.buttonSelectAllItems.Name = "buttonSelectAllItems";
			this.buttonSelectAllItems.Size = new System.Drawing.Size(94, 23);
			this.buttonSelectAllItems.TabIndex = 1;
			this.buttonSelectAllItems.Text = "Select &all";
			this.buttonSelectAllItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSelectAllItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSelectAllItems.UseVisualStyleBackColor = true;
			this.buttonSelectAllItems.Click += new System.EventHandler(this.ButtonSelectAllItems_Click);
			this.buttonSelectAllItems.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSelectAllItems.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSelectAllItems.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSelectAllItems.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupBoxSearchOptions
			// 
			this.groupBoxSearchOptions.Controls.Add(this.radioButtonFulltext);
			this.groupBoxSearchOptions.Controls.Add(this.radioButtonParttext);
			this.groupBoxSearchOptions.Location = new System.Drawing.Point(375, 35);
			this.groupBoxSearchOptions.Name = "groupBoxSearchOptions";
			this.groupBoxSearchOptions.Size = new System.Drawing.Size(79, 96);
			this.groupBoxSearchOptions.TabIndex = 5;
			this.groupBoxSearchOptions.TabStop = false;
			this.groupBoxSearchOptions.Text = "T&ext";
			// 
			// radioButtonFulltext
			// 
			this.radioButtonFulltext.AutoSize = true;
			this.radioButtonFulltext.Location = new System.Drawing.Point(6, 42);
			this.radioButtonFulltext.Name = "radioButtonFulltext";
			this.radioButtonFulltext.Size = new System.Drawing.Size(64, 19);
			this.radioButtonFulltext.TabIndex = 1;
			this.radioButtonFulltext.Text = "full &text";
			this.radioButtonFulltext.UseVisualStyleBackColor = true;
			this.radioButtonFulltext.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.radioButtonFulltext.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.radioButtonFulltext.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.radioButtonFulltext.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.radioButtonParttext.Text = "&part text";
			this.radioButtonParttext.UseVisualStyleBackColor = true;
			this.radioButtonParttext.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.radioButtonParttext.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.radioButtonParttext.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.radioButtonParttext.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelProgress
			// 
			this.labelProgress.AutoSize = true;
			this.labelProgress.Location = new System.Drawing.Point(15, 200);
			this.labelProgress.Name = "labelProgress";
			this.labelProgress.Size = new System.Drawing.Size(55, 15);
			this.labelProgress.TabIndex = 8;
			this.labelProgress.Text = "Pro&gress:";
			this.labelProgress.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelProgress.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelProgress.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelProgress.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(76, 200);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(339, 13);
			this.progressBar.TabIndex = 9;
			this.progressBar.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBar.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelProgressPercent
			// 
			this.labelProgressPercent.AutoSize = true;
			this.labelProgressPercent.Location = new System.Drawing.Point(421, 200);
			this.labelProgressPercent.Name = "labelProgressPercent";
			this.labelProgressPercent.Size = new System.Drawing.Size(38, 15);
			this.labelProgressPercent.TabIndex = 10;
			this.labelProgressPercent.Text = "100 &%";
			this.labelProgressPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelProgressPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelProgressPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelProgressPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// listViewResults
			// 
			this.listViewResults.AccessibleDescription = "Show the list with the items";
			this.listViewResults.AccessibleName = "List";
			this.listViewResults.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
			this.listViewResults.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewResults.AllowColumnReorder = true;
			this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderReadableDesignation,
            this.columnHeaderItem,
            this.columnHeaderValue});
			this.listViewResults.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.listViewResults.FullRowSelect = true;
			this.listViewResults.GridLines = true;
			this.listViewResults.HideSelection = false;
			this.listViewResults.Location = new System.Drawing.Point(15, 219);
			this.listViewResults.MultiSelect = false;
			this.listViewResults.Name = "listViewResults";
			this.listViewResults.ShowItemToolTips = true;
			this.listViewResults.Size = new System.Drawing.Size(440, 166);
			this.listViewResults.TabIndex = 11;
			this.listViewResults.UseCompatibleStateImageBehavior = false;
			this.listViewResults.View = System.Windows.Forms.View.Details;
			this.listViewResults.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listViewResults.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.listViewResults.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listViewResults.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.statusBar.Location = new System.Drawing.Point(0, 426);
			this.statusBar.Name = "statusBar";
			this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusBar.ShowItemToolTips = true;
			this.statusBar.Size = new System.Drawing.Size(471, 21);
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
			this.buttonOpenSelectedObject.Location = new System.Drawing.Point(301, 391);
			this.buttonOpenSelectedObject.Name = "buttonOpenSelectedObject";
			this.buttonOpenSelectedObject.Size = new System.Drawing.Size(154, 23);
			this.buttonOpenSelectedObject.TabIndex = 13;
			this.buttonOpenSelectedObject.Text = "Open selected o&bject";
			this.buttonOpenSelectedObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOpenSelectedObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonOpenSelectedObject.UseVisualStyleBackColor = true;
			this.buttonOpenSelectedObject.Click += new System.EventHandler(this.ButtonOpenSelectedObject_Click);
			this.buttonOpenSelectedObject.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenSelectedObject.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOpenSelectedObject.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenSelectedObject.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Okay";
			this.buttonOK.AccessibleName = "OK";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(222, 391);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 12;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "OK");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			this.buttonOK.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericUpDownRangeMaximum
			// 
			this.numericUpDownRangeMaximum.AccessibleDescription = "Show the maximum value";
			this.numericUpDownRangeMaximum.AccessibleName = "Maximum value";
			this.numericUpDownRangeMaximum.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownRangeMaximum.Location = new System.Drawing.Point(215, 16);
			this.numericUpDownRangeMaximum.Name = "numericUpDownRangeMaximum";
			this.numericUpDownRangeMaximum.Size = new System.Drawing.Size(64, 23);
			this.numericUpDownRangeMaximum.TabIndex = 3;
			this.numericUpDownRangeMaximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.numericUpDownRangeMaximum, "Maximum value for the list");
			this.numericUpDownRangeMaximum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownRangeMaximum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelRangeMaximum
			// 
			this.labelRangeMaximum.AccessibleDescription = "Show the maximum";
			this.labelRangeMaximum.AccessibleName = "Maximum";
			this.labelRangeMaximum.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRangeMaximum.AutoSize = true;
			this.labelRangeMaximum.BackColor = System.Drawing.Color.Transparent;
			this.labelRangeMaximum.Location = new System.Drawing.Point(145, 19);
			this.labelRangeMaximum.Name = "labelRangeMaximum";
			this.labelRangeMaximum.Size = new System.Drawing.Size(64, 15);
			this.labelRangeMaximum.TabIndex = 2;
			this.labelRangeMaximum.Text = "M&aximum:";
			this.toolTip.SetToolTip(this.labelRangeMaximum, "Maximum");
			this.labelRangeMaximum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRangeMaximum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelRangeMaximum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRangeMaximum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericUpDownRangeMinimum
			// 
			this.numericUpDownRangeMinimum.AccessibleDescription = "Show the minimum value";
			this.numericUpDownRangeMinimum.AccessibleName = "Minimum value";
			this.numericUpDownRangeMinimum.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownRangeMinimum.Location = new System.Drawing.Point(75, 16);
			this.numericUpDownRangeMinimum.Name = "numericUpDownRangeMinimum";
			this.numericUpDownRangeMinimum.Size = new System.Drawing.Size(64, 23);
			this.numericUpDownRangeMinimum.TabIndex = 1;
			this.numericUpDownRangeMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.numericUpDownRangeMinimum, "Minimum value for the list");
			this.numericUpDownRangeMinimum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownRangeMinimum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelRangeMinimum
			// 
			this.labelRangeMinimum.AccessibleDescription = "Show the minimum";
			this.labelRangeMinimum.AccessibleName = "Minimum";
			this.labelRangeMinimum.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRangeMinimum.AutoSize = true;
			this.labelRangeMinimum.BackColor = System.Drawing.Color.Transparent;
			this.labelRangeMinimum.Location = new System.Drawing.Point(6, 19);
			this.labelRangeMinimum.Name = "labelRangeMinimum";
			this.labelRangeMinimum.Size = new System.Drawing.Size(63, 15);
			this.labelRangeMinimum.TabIndex = 0;
			this.labelRangeMinimum.Text = "M&inimum:";
			this.toolTip.SetToolTip(this.labelRangeMinimum, "Minimum");
			this.labelRangeMinimum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRangeMinimum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelRangeMinimum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRangeMinimum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// groupBoxRange
			// 
			this.groupBoxRange.Controls.Add(this.labelRangeMinimum);
			this.groupBoxRange.Controls.Add(this.numericUpDownRangeMaximum);
			this.groupBoxRange.Controls.Add(this.numericUpDownRangeMinimum);
			this.groupBoxRange.Controls.Add(this.labelRangeMaximum);
			this.groupBoxRange.Location = new System.Drawing.Point(18, 135);
			this.groupBoxRange.Name = "groupBoxRange";
			this.groupBoxRange.Size = new System.Drawing.Size(351, 50);
			this.groupBoxRange.TabIndex = 6;
			this.groupBoxRange.TabStop = false;
			this.groupBoxRange.Text = "Range";
			// 
			// buttonSetDefaultSettings
			// 
			this.buttonSetDefaultSettings.Image = global::Planetoid_DB.Properties.Resources.silk_control_blank;
			this.buttonSetDefaultSettings.Location = new System.Drawing.Point(376, 137);
			this.buttonSetDefaultSettings.Name = "buttonSetDefaultSettings";
			this.buttonSetDefaultSettings.Size = new System.Drawing.Size(79, 48);
			this.buttonSetDefaultSettings.TabIndex = 7;
			this.buttonSetDefaultSettings.Text = "&Default settings";
			this.buttonSetDefaultSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSetDefaultSettings.UseVisualStyleBackColor = true;
			this.buttonSetDefaultSettings.Click += new System.EventHandler(this.ButtonSetDefaultSettings_Click);
			this.buttonSetDefaultSettings.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSetDefaultSettings.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSetDefaultSettings.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSetDefaultSettings.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 447);
			this.Controls.Add(this.buttonSetDefaultSettings);
			this.Controls.Add(this.groupBoxRange);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonOpenSelectedObject);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.listViewResults);
			this.Controls.Add(this.labelProgressPercent);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.labelProgress);
			this.Controls.Add(this.groupBoxSearchOptions);
			this.Controls.Add(this.groupBoxSearchIn);
			this.Controls.Add(this.buttonCancelSearch);
			this.Controls.Add(this.buttonFindSearchterm);
			this.Controls.Add(this.textBoxSearchfield);
			this.Controls.Add(this.labelSearchterm);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Search";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
			this.Load += new System.EventHandler(this.SearchForm_Load);
			this.groupBoxSearchIn.ResumeLayout(false);
			this.groupBoxSearchOptions.ResumeLayout(false);
			this.groupBoxSearchOptions.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMaximum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMinimum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.groupBoxRange.ResumeLayout(false);
			this.groupBoxRange.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSearchterm;
		private System.Windows.Forms.TextBox textBoxSearchfield;
		private System.Windows.Forms.Button buttonFindSearchterm;
		private System.Windows.Forms.Button buttonCancelSearch;
		private System.Windows.Forms.GroupBox groupBoxSearchIn;
		private System.Windows.Forms.CheckedListBox checkedListBoxSearchIn;
		private System.Windows.Forms.GroupBox groupBoxSearchOptions;
		private System.Windows.Forms.RadioButton radioButtonFulltext;
		private System.Windows.Forms.RadioButton radioButtonParttext;
		private System.Windows.Forms.Button buttonSelectAllItems;
		private System.Windows.Forms.Label labelProgress;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label labelProgressPercent;
		private System.Windows.Forms.ListView listViewResults;
		private System.Windows.Forms.ColumnHeader columnHeaderIndex;
		private System.Windows.Forms.ColumnHeader columnHeaderReadableDesignation;
		private System.Windows.Forms.ColumnHeader columnHeaderItem;
		private System.Windows.Forms.ColumnHeader columnHeaderValue;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.Button buttonOpenSelectedObject;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonUnselectAllItems;
		private System.Windows.Forms.NumericUpDown numericUpDownRangeMaximum;
		private System.Windows.Forms.Label labelRangeMaximum;
		private System.Windows.Forms.NumericUpDown numericUpDownRangeMinimum;
		private System.Windows.Forms.Label labelRangeMinimum;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Button buttonSetDefaultSettings;
		private System.Windows.Forms.GroupBox groupBoxRange;
	}
}