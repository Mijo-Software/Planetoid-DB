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
			this.kryptonCheckedListBox = new Krypton.Toolkit.KryptonCheckedListBox();
			this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			this.kryptonLabelPercent = new Krypton.Toolkit.KryptonLabel();
			this.kryptonProgressBar = new Krypton.Toolkit.KryptonProgressBar();
			this.kryptonGroupBox = new Krypton.Toolkit.KryptonGroupBox();
			this.kryptonButtonClear = new Krypton.Toolkit.KryptonButton();
			this.kryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
			this.kryptonButtonOpen = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonUnmarkAll = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonMarkAll = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonSearch = new Krypton.Toolkit.KryptonButton();
			this.kryptonListView = new Krypton.Toolkit.KryptonListView();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox.Panel)).BeginInit();
			this.kryptonGroupBox.Panel.SuspendLayout();
			this.kryptonGroupBox.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// kryptonCheckedListBox
			// 
			this.kryptonCheckedListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.kryptonCheckedListBox.BackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
			this.kryptonCheckedListBox.CheckOnClick = true;
			this.kryptonCheckedListBox.CornerRoundingRadius = -1F;
			this.kryptonCheckedListBox.ItemCornerRoundingRadius = -1F;
			this.kryptonCheckedListBox.Items.AddRange(new object[] {
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
			this.kryptonCheckedListBox.Location = new System.Drawing.Point(3, 64);
			this.kryptonCheckedListBox.Name = "kryptonCheckedListBox";
			this.kryptonCheckedListBox.Size = new System.Drawing.Size(228, 168);
			this.kryptonCheckedListBox.TabIndex = 1;
			this.kryptonCheckedListBox.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonCheckedListBox.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonCheckedListBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonCheckedListBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.kryptonPanel.Controls.Add(this.kryptonStatusStrip);
			this.kryptonPanel.Controls.Add(this.kryptonLabelPercent);
			this.kryptonPanel.Controls.Add(this.kryptonProgressBar);
			this.kryptonPanel.Controls.Add(this.kryptonGroupBox);
			this.kryptonPanel.Controls.Add(this.kryptonButtonOpen);
			this.kryptonPanel.Controls.Add(this.kryptonButtonUnmarkAll);
			this.kryptonPanel.Controls.Add(this.kryptonButtonMarkAll);
			this.kryptonPanel.Controls.Add(this.kryptonButtonSearch);
			this.kryptonPanel.Controls.Add(this.kryptonListView);
			this.kryptonPanel.Controls.Add(this.kryptonCheckedListBox);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(332, 376);
			this.kryptonPanel.TabIndex = 0;
			// 
			// kryptonLabelPercent
			// 
			this.kryptonLabelPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelPercent.Location = new System.Drawing.Point(283, 332);
			this.kryptonLabelPercent.Name = "kryptonLabelPercent";
			this.kryptonLabelPercent.Size = new System.Drawing.Size(44, 20);
			this.kryptonLabelPercent.TabIndex = 8;
			this.kryptonLabelPercent.Values.Text = "100 %";
			this.kryptonLabelPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonProgressBar
			// 
			this.kryptonProgressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.kryptonProgressBar.Location = new System.Drawing.Point(3, 335);
			this.kryptonProgressBar.Name = "kryptonProgressBar";
			this.kryptonProgressBar.Size = new System.Drawing.Size(274, 17);
			this.kryptonProgressBar.TabIndex = 7;
			this.kryptonProgressBar.UseKrypton = true;
			this.kryptonProgressBar.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonProgressBar.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonGroupBox
			// 
			this.kryptonGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.kryptonGroupBox.Location = new System.Drawing.Point(3, 3);
			this.kryptonGroupBox.Name = "kryptonGroupBox";
			// 
			// kryptonGroupBox.Panel
			// 
			this.kryptonGroupBox.Panel.Controls.Add(this.kryptonButtonClear);
			this.kryptonGroupBox.Panel.Controls.Add(this.kryptonTextBox);
			this.kryptonGroupBox.Size = new System.Drawing.Size(324, 55);
			this.kryptonGroupBox.TabIndex = 0;
			this.kryptonGroupBox.Values.Heading = "Word, number, keyword, ...";
			this.kryptonGroupBox.Values.Image = global::Planetoid_DB.Properties.Resources.silk_pencil;
			this.kryptonGroupBox.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonGroupBox.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonGroupBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonGroupBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonClear
			// 
			this.kryptonButtonClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonClear.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonClear.CornerRoundingRadius = -1F;
			this.kryptonButtonClear.Location = new System.Drawing.Point(257, 4);
			this.kryptonButtonClear.Name = "kryptonButtonClear";
			this.kryptonButtonClear.Size = new System.Drawing.Size(58, 22);
			this.kryptonButtonClear.TabIndex = 1;
			this.kryptonButtonClear.Values.Image = global::Planetoid_DB.Properties.Resources.silk_cross;
			this.kryptonButtonClear.Values.Text = "&Clear";
			this.kryptonButtonClear.Click += new System.EventHandler(this.KryptonButtonClear_Click);
			this.kryptonButtonClear.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonClear.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonClear.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonClear.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonTextBox
			// 
			this.kryptonTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.kryptonTextBox.Location = new System.Drawing.Point(4, 4);
			this.kryptonTextBox.Name = "kryptonTextBox";
			this.kryptonTextBox.Size = new System.Drawing.Size(247, 23);
			this.kryptonTextBox.TabIndex = 0;
			this.kryptonTextBox.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonTextBox.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonTextBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonTextBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonOpen
			// 
			this.kryptonButtonOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonOpen.CornerRoundingRadius = -1F;
			this.kryptonButtonOpen.Location = new System.Drawing.Point(237, 207);
			this.kryptonButtonOpen.Name = "kryptonButtonOpen";
			this.kryptonButtonOpen.Size = new System.Drawing.Size(90, 25);
			this.kryptonButtonOpen.TabIndex = 5;
			this.kryptonButtonOpen.Values.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.kryptonButtonOpen.Values.Text = "&Open";
			this.kryptonButtonOpen.Click += new System.EventHandler(this.KryptonButtonOpen_Click);
			this.kryptonButtonOpen.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonOpen.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonOpen.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonOpen.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonUnmarkAll
			// 
			this.kryptonButtonUnmarkAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonUnmarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonUnmarkAll.CornerRoundingRadius = -1F;
			this.kryptonButtonUnmarkAll.Location = new System.Drawing.Point(237, 95);
			this.kryptonButtonUnmarkAll.Name = "kryptonButtonUnmarkAll";
			this.kryptonButtonUnmarkAll.Size = new System.Drawing.Size(90, 25);
			this.kryptonButtonUnmarkAll.TabIndex = 3;
			this.kryptonButtonUnmarkAll.Values.Text = "&Unmark all";
			this.kryptonButtonUnmarkAll.Click += new System.EventHandler(this.KryptonButtonUnmarkAll_Click);
			this.kryptonButtonUnmarkAll.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonUnmarkAll.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonUnmarkAll.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonUnmarkAll.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonMarkAll
			// 
			this.kryptonButtonMarkAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonMarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonMarkAll.CornerRoundingRadius = -1F;
			this.kryptonButtonMarkAll.Location = new System.Drawing.Point(237, 64);
			this.kryptonButtonMarkAll.Name = "kryptonButtonMarkAll";
			this.kryptonButtonMarkAll.Size = new System.Drawing.Size(90, 25);
			this.kryptonButtonMarkAll.TabIndex = 2;
			this.kryptonButtonMarkAll.Values.Image = global::Planetoid_DB.Properties.Resources.silk_asterisk_orange;
			this.kryptonButtonMarkAll.Values.Text = "&Mark all";
			this.kryptonButtonMarkAll.Click += new System.EventHandler(this.KryptonButtonMarkAll_Click);
			this.kryptonButtonMarkAll.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonMarkAll.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonMarkAll.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonMarkAll.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonSearch
			// 
			this.kryptonButtonSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonSearch.CornerRoundingRadius = -1F;
			this.kryptonButtonSearch.Location = new System.Drawing.Point(237, 126);
			this.kryptonButtonSearch.Name = "kryptonButtonSearch";
			this.kryptonButtonSearch.Size = new System.Drawing.Size(90, 25);
			this.kryptonButtonSearch.TabIndex = 4;
			this.kryptonButtonSearch.Values.Image = global::Planetoid_DB.Properties.Resources.silk_zoom;
			this.kryptonButtonSearch.Values.Text = "&Search";
			this.kryptonButtonSearch.Click += new System.EventHandler(this.KryptonButtonSearch_Click);
			this.kryptonButtonSearch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonSearch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonListView
			// 
			this.kryptonListView.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.kryptonListView.HideSelection = false;
			this.kryptonListView.ItemStyle = Krypton.Toolkit.ButtonStyle.ListItem;
			this.kryptonListView.Location = new System.Drawing.Point(3, 238);
			this.kryptonListView.Name = "kryptonListView";
			this.kryptonListView.OwnerDraw = true;
			this.kryptonListView.Size = new System.Drawing.Size(324, 91);
			this.kryptonListView.StateCommon.Item.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
			this.kryptonListView.StateCommon.Item.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.kryptonListView.StateCommon.Item.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.kryptonListView.TabIndex = 6;
			this.kryptonListView.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonListView.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonListView.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonListView.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 354);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(332, 22);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 9;
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
			// SearchForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 376);
			this.Controls.Add(this.kryptonPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Search";
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox.Panel)).EndInit();
			this.kryptonGroupBox.Panel.ResumeLayout(false);
			this.kryptonGroupBox.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox)).EndInit();
			this.kryptonGroupBox.ResumeLayout(false);
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox;
		private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private Krypton.Toolkit.KryptonButton kryptonButtonUnmarkAll;
		private Krypton.Toolkit.KryptonButton kryptonButtonMarkAll;
		private Krypton.Toolkit.KryptonButton kryptonButtonSearch;
		private Krypton.Toolkit.KryptonListView kryptonListView;
		private Krypton.Toolkit.KryptonButton kryptonButtonOpen;
		private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox;
		private Krypton.Toolkit.KryptonTextBox kryptonTextBox;
		private Krypton.Toolkit.KryptonButton kryptonButtonClear;
		private Krypton.Toolkit.KryptonLabel kryptonLabelPercent;
		private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
	}
}