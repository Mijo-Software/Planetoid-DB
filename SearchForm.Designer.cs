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
			this.checkedListBox = new Krypton.Toolkit.KryptonCheckedListBox();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelPercent = new Krypton.Toolkit.KryptonLabel();
			this.progressBar = new Krypton.Toolkit.KryptonProgressBar();
			this.groupBox = new Krypton.Toolkit.KryptonGroupBox();
			this.buttonClear = new Krypton.Toolkit.KryptonButton();
			this.textBox = new Krypton.Toolkit.KryptonTextBox();
			this.buttonOpen = new Krypton.Toolkit.KryptonButton();
			this.buttonUnmarkAll = new Krypton.Toolkit.KryptonButton();
			this.buttonMarkAll = new Krypton.Toolkit.KryptonButton();
			this.buttonSearch = new Krypton.Toolkit.KryptonButton();
			this.listView = new Krypton.Toolkit.KryptonListView();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox.Panel)).BeginInit();
			this.groupBox.Panel.SuspendLayout();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkedListBox
			// 
			this.checkedListBox.AccessibleDescription = "Box with selectable orbital elements to search";
			this.checkedListBox.AccessibleName = "Box with selectable orbital elements";
			this.checkedListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkedListBox.BackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
			this.checkedListBox.CheckOnClick = true;
			this.checkedListBox.CornerRoundingRadius = -1F;
			this.checkedListBox.ItemCornerRoundingRadius = -1F;
			this.checkedListBox.Items.AddRange(new object[] {
            "Index No.",
            "Readable designation",
            "Epoch (in packed form, .0 TT)",
            "Mean anomaly at the epoch (°)",
            "Argument of perihelion, J2000.0 (°)",
            "Longitude of the ascending node, J2000.0 (°)",
            "Inclination to the ecliptic, J2000.0 (°)",
            "Orbital eccentricity",
            "Mean daily motion (°/day)",
            "Semi-major axis (AU)",
            "Absolute magnitude, H",
            "Slope parameter, G",
            "Reference",
            "Number of oppositions",
            "Number of observations",
            "Observation span",
            "r.m.s. residual (\")",
            "Computer name",
            "4-hexdigit flags",
            "Date of last observation (YYYMMDD)"});
			this.checkedListBox.Location = new System.Drawing.Point(3, 64);
			this.checkedListBox.Name = "checkedListBox";
			this.checkedListBox.Size = new System.Drawing.Size(228, 168);
			this.checkedListBox.TabIndex = 1;
			this.toolTip.SetToolTip(this.checkedListBox, "Box with selectable orbital elements");
			this.checkedListBox.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkedListBox.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkedListBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkedListBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Panel of the search form";
			this.panel.AccessibleName = "Panel of the search form";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.labelPercent);
			this.panel.Controls.Add(this.progressBar);
			this.panel.Controls.Add(this.groupBox);
			this.panel.Controls.Add(this.buttonOpen);
			this.panel.Controls.Add(this.buttonUnmarkAll);
			this.panel.Controls.Add(this.buttonMarkAll);
			this.panel.Controls.Add(this.buttonSearch);
			this.panel.Controls.Add(this.listView);
			this.panel.Controls.Add(this.checkedListBox);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.panel.Size = new System.Drawing.Size(332, 376);
			this.panel.TabIndex = 0;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 354);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(332, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 9;
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
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// labelPercent
			// 
			this.labelPercent.AccessibleDescription = "Shows the percent status of the search";
			this.labelPercent.AccessibleName = "Percent status of the search";
			this.labelPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPercent.Location = new System.Drawing.Point(283, 332);
			this.labelPercent.Name = "labelPercent";
			this.labelPercent.Size = new System.Drawing.Size(44, 20);
			this.labelPercent.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelPercent, "Shows the progress status of the search");
			this.labelPercent.Values.Text = "100 %";
			this.labelPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// progressBar
			// 
			this.progressBar.AccessibleDescription = "Shows the progress status of the search";
			this.progressBar.AccessibleName = "Progress bar";
			this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBar.Location = new System.Drawing.Point(3, 335);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(274, 17);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 7;
			this.toolTip.SetToolTip(this.progressBar, "Shows the progress status of the search");
			this.progressBar.UseKrypton = true;
			this.progressBar.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBar.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupBox
			// 
			this.groupBox.AccessibleDescription = "Groups the search element";
			this.groupBox.AccessibleName = "Group the search element";
			this.groupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBox.Location = new System.Drawing.Point(3, 3);
			this.groupBox.Name = "groupBox";
			// 
			// groupBox.Panel
			// 
			this.groupBox.Panel.AccessibleDescription = "Groups the search element";
			this.groupBox.Panel.AccessibleName = "Group the search element";
			this.groupBox.Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBox.Panel.AutoScroll = true;
			this.groupBox.Panel.Controls.Add(this.buttonClear);
			this.groupBox.Panel.Controls.Add(this.textBox);
			this.toolTip.SetToolTip(this.groupBox.Panel, "Group the search element");
			this.groupBox.Size = new System.Drawing.Size(324, 55);
			this.groupBox.TabIndex = 0;
			this.toolTip.SetToolTip(this.groupBox, "Group the search element");
			this.groupBox.Values.Heading = "Word, number, keyword, ...";
			this.groupBox.Values.Image = global::Planetoid_DB.Properties.Resources.silk_pencil;
			this.groupBox.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonClear
			// 
			this.buttonClear.AccessibleDescription = "Clears the search box";
			this.buttonClear.AccessibleName = "Clear the search box";
			this.buttonClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClear.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonClear.CornerRoundingRadius = -1F;
			this.buttonClear.Location = new System.Drawing.Point(257, 4);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(58, 22);
			this.buttonClear.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonClear, "Clear the search box");
			this.buttonClear.Values.Image = global::Planetoid_DB.Properties.Resources.silk_cross;
			this.buttonClear.Values.Text = "&Clear";
			this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
			this.buttonClear.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonClear.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonClear.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonClear.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// textBox
			// 
			this.textBox.AccessibleDescription = "Shows the search box to input some key words";
			this.textBox.AccessibleName = "Search box";
			this.textBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBox.Location = new System.Drawing.Point(4, 4);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(247, 23);
			this.textBox.TabIndex = 0;
			this.toolTip.SetToolTip(this.textBox, "Search box");
			this.textBox.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBox.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.textBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonOpen
			// 
			this.buttonOpen.AccessibleDescription = "Opens the selected result item";
			this.buttonOpen.AccessibleName = "Open the selected result item";
			this.buttonOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpen.CornerRoundingRadius = -1F;
			this.buttonOpen.Location = new System.Drawing.Point(237, 207);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(90, 25);
			this.buttonOpen.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonOpen, "Open the selected result item");
			this.buttonOpen.Values.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.buttonOpen.Values.Text = "&Open";
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
			this.buttonOpen.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpen.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOpen.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpen.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonUnmarkAll
			// 
			this.buttonUnmarkAll.AccessibleDescription = "Umarks all orbital elements";
			this.buttonUnmarkAll.AccessibleName = "Umark all orbital elements";
			this.buttonUnmarkAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonUnmarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonUnmarkAll.CornerRoundingRadius = -1F;
			this.buttonUnmarkAll.Location = new System.Drawing.Point(237, 95);
			this.buttonUnmarkAll.Name = "buttonUnmarkAll";
			this.buttonUnmarkAll.Size = new System.Drawing.Size(90, 25);
			this.buttonUnmarkAll.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonUnmarkAll, "Umark all orbital elements");
			this.buttonUnmarkAll.Values.Text = "&Unmark all";
			this.buttonUnmarkAll.Click += new System.EventHandler(this.ButtonUnmarkAll_Click);
			this.buttonUnmarkAll.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonUnmarkAll.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonUnmarkAll.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonUnmarkAll.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonMarkAll
			// 
			this.buttonMarkAll.AccessibleDescription = "Marks all orbital elements to search";
			this.buttonMarkAll.AccessibleName = "Mark all orbital elements";
			this.buttonMarkAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonMarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonMarkAll.CornerRoundingRadius = -1F;
			this.buttonMarkAll.Location = new System.Drawing.Point(237, 64);
			this.buttonMarkAll.Name = "buttonMarkAll";
			this.buttonMarkAll.Size = new System.Drawing.Size(90, 25);
			this.buttonMarkAll.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonMarkAll, "Mark all orbital elements");
			this.buttonMarkAll.Values.Image = global::Planetoid_DB.Properties.Resources.silk_asterisk_orange;
			this.buttonMarkAll.Values.Text = "&Mark all";
			this.buttonMarkAll.Click += new System.EventHandler(this.ButtonMarkAll_Click);
			this.buttonMarkAll.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMarkAll.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonMarkAll.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMarkAll.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSearch
			// 
			this.buttonSearch.AccessibleDescription = "Searchs the keyword";
			this.buttonSearch.AccessibleName = "Search";
			this.buttonSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSearch.CornerRoundingRadius = -1F;
			this.buttonSearch.Location = new System.Drawing.Point(237, 126);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(90, 25);
			this.buttonSearch.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonSearch, "Search");
			this.buttonSearch.Values.Image = global::Planetoid_DB.Properties.Resources.silk_magnifier;
			this.buttonSearch.Values.Text = "&Search";
			this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
			this.buttonSearch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSearch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// listView
			// 
			this.listView.AccessibleDescription = "Shows the search results";
			this.listView.AccessibleName = "Search results";
			this.listView.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.listView.HideSelection = false;
			this.listView.ItemStyle = Krypton.Toolkit.ButtonStyle.ListItem;
			this.listView.Location = new System.Drawing.Point(3, 238);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.OwnerDraw = true;
			this.listView.ShowItemToolTips = true;
			this.listView.Size = new System.Drawing.Size(324, 91);
			this.listView.StateCommon.Item.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
			this.listView.StateCommon.Item.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.listView.StateCommon.Item.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.listView.TabIndex = 6;
			this.toolTip.SetToolTip(this.listView, "Search results");
			this.listView.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listView.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.listView.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listView.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// SearchForm
			// 
			this.AccessibleDescription = "Dialog to search a word, a keyword or a number";
			this.AccessibleName = "Search";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 376);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Search";
			this.toolTip.SetToolTip(this, "Search");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox.Panel)).EndInit();
			this.groupBox.Panel.ResumeLayout(false);
			this.groupBox.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox)).EndInit();
			this.groupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Krypton.Toolkit.KryptonCheckedListBox checkedListBox;
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonButton buttonUnmarkAll;
		private Krypton.Toolkit.KryptonButton buttonMarkAll;
		private Krypton.Toolkit.KryptonButton buttonSearch;
		private Krypton.Toolkit.KryptonListView listView;
		private Krypton.Toolkit.KryptonButton buttonOpen;
		private Krypton.Toolkit.KryptonGroupBox groupBox;
		private Krypton.Toolkit.KryptonTextBox textBox;
		private Krypton.Toolkit.KryptonButton buttonClear;
		private Krypton.Toolkit.KryptonLabel labelPercent;
		private Krypton.Toolkit.KryptonProgressBar progressBar;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
	}
}