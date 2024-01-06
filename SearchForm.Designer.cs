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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
			checkedListBox = new Krypton.Toolkit.KryptonCheckedListBox();
			panel = new Krypton.Toolkit.KryptonPanel();
			listView = new ListView();
			columnHeaderIndex = new ColumnHeader();
			columnHeaderProperty = new ColumnHeader();
			columnHeaderValue = new ColumnHeader();
			buttonCancel = new Krypton.Toolkit.KryptonButton();
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			labelEntriesFound = new Krypton.Toolkit.KryptonLabel();
			progressBar = new Krypton.Toolkit.KryptonProgressBar();
			groupBox = new Krypton.Toolkit.KryptonGroupBox();
			buttonClear = new Krypton.Toolkit.KryptonButton();
			textBox = new Krypton.Toolkit.KryptonTextBox();
			buttonOpen = new Krypton.Toolkit.KryptonButton();
			buttonUnmarkAll = new Krypton.Toolkit.KryptonButton();
			buttonMarkAll = new Krypton.Toolkit.KryptonButton();
			buttonSearch = new Krypton.Toolkit.KryptonButton();
			toolTip = new ToolTip(components);
			backgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)groupBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupBox.Panel).BeginInit();
			groupBox.Panel.SuspendLayout();
			SuspendLayout();
			// 
			// checkedListBox
			// 
			checkedListBox.AccessibleDescription = "Box with selectable orbital elements to search";
			checkedListBox.AccessibleName = "Box with selectable orbital elements";
			checkedListBox.AccessibleRole = AccessibleRole.CheckButton;
			checkedListBox.BackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
			checkedListBox.CheckOnClick = true;
			checkedListBox.Items.AddRange(new object[] { "Index No.", "Readable designation", "Epoch (in packed form, .0 TT)", "Mean anomaly at the epoch (°)", "Argument of perihelion, J2000.0 (°)", "Longitude of the ascending node, J2000.0 (°)", "Inclination to the ecliptic, J2000.0 (°)", "Orbital eccentricity", "Mean daily motion (°/day)", "Semi-major axis (AU)", "Absolute magnitude, H", "Slope parameter, G", "Reference", "Number of oppositions", "Number of observations", "Observation span", "r.m.s. residual (\")", "Computer name", "4-hexdigit flags", "Date of last observation (YYYMMDD)" });
			checkedListBox.Location = new Point(4, 74);
			checkedListBox.Margin = new Padding(4, 3, 4, 3);
			checkedListBox.Name = "checkedListBox";
			checkedListBox.Size = new Size(266, 194);
			checkedListBox.TabIndex = 1;
			toolTip.SetToolTip(checkedListBox, "Box with selectable orbital elements");
			checkedListBox.Enter += SetStatusbar_Enter;
			checkedListBox.Leave += ClearStatusbar_Leave;
			checkedListBox.MouseEnter += SetStatusbar_Enter;
			checkedListBox.MouseLeave += ClearStatusbar_Leave;
			// 
			// panel
			// 
			panel.AccessibleDescription = "Panel of the search form";
			panel.AccessibleName = "Panel of the search form";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(listView);
			panel.Controls.Add(buttonCancel);
			panel.Controls.Add(statusStrip);
			panel.Controls.Add(labelEntriesFound);
			panel.Controls.Add(progressBar);
			panel.Controls.Add(groupBox);
			panel.Controls.Add(buttonOpen);
			panel.Controls.Add(buttonUnmarkAll);
			panel.Controls.Add(buttonMarkAll);
			panel.Controls.Add(buttonSearch);
			panel.Controls.Add(checkedListBox);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Margin = new Padding(4, 3, 4, 3);
			panel.Name = "panel";
			panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			panel.Size = new Size(387, 525);
			panel.TabIndex = 0;
			// 
			// listView
			// 
			listView.AccessibleDescription = "Shows the search results";
			listView.AccessibleName = "Search results";
			listView.Columns.AddRange(new ColumnHeader[] { columnHeaderIndex, columnHeaderProperty, columnHeaderValue });
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.Location = new Point(4, 300);
			listView.Name = "listView";
			listView.ShowItemToolTips = true;
			listView.Size = new Size(377, 200);
			listView.TabIndex = 9;
			toolTip.SetToolTip(listView, "Shows the search results");
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = View.Details;
			listView.Enter += SetStatusbar_Enter;
			listView.Leave += ClearStatusbar_Leave;
			listView.MouseEnter += SetStatusbar_Enter;
			listView.MouseLeave += ClearStatusbar_Leave;
			// 
			// columnHeaderIndex
			// 
			columnHeaderIndex.Text = "Index";
			// 
			// columnHeaderProperty
			// 
			columnHeaderProperty.Text = "Property";
			columnHeaderProperty.Width = 180;
			// 
			// columnHeaderValue
			// 
			columnHeaderValue.Text = "Value";
			columnHeaderValue.Width = 120;
			// 
			// buttonCancel
			// 
			buttonCancel.AccessibleDescription = "Cancels the search";
			buttonCancel.AccessibleName = "Cancel";
			buttonCancel.AccessibleRole = AccessibleRole.PushButton;
			buttonCancel.Location = new Point(276, 180);
			buttonCancel.Margin = new Padding(4, 3, 4, 3);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(105, 29);
			buttonCancel.TabIndex = 5;
			toolTip.SetToolTip(buttonCancel, "Cancel");
			buttonCancel.Values.Image = Properties.Resources.silk_cancel;
			buttonCancel.Values.Text = "&Cancel";
			buttonCancel.Click += ButtonCancel_Click;
			buttonCancel.Enter += SetStatusbar_Enter;
			buttonCancel.Leave += ClearStatusbar_Leave;
			buttonCancel.MouseEnter += SetStatusbar_Enter;
			buttonCancel.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 503);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(387, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 10;
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
			labelInformation.ToolTipText = "Show some information";
			// 
			// labelEntriesFound
			// 
			labelEntriesFound.AccessibleDescription = "Shows the found entries";
			labelEntriesFound.AccessibleName = "Found entries";
			labelEntriesFound.AccessibleRole = AccessibleRole.StaticText;
			labelEntriesFound.Location = new Point(255, 274);
			labelEntriesFound.Margin = new Padding(4, 3, 4, 3);
			labelEntriesFound.Name = "labelEntriesFound";
			labelEntriesFound.RightToLeft = RightToLeft.No;
			labelEntriesFound.Size = new Size(93, 20);
			labelEntriesFound.TabIndex = 8;
			toolTip.SetToolTip(labelEntriesFound, "Shows the found entries");
			labelEntriesFound.Values.Text = "0 entries found";
			labelEntriesFound.Enter += SetStatusbar_Enter;
			labelEntriesFound.Leave += ClearStatusbar_Leave;
			labelEntriesFound.MouseEnter += SetStatusbar_Enter;
			labelEntriesFound.MouseLeave += ClearStatusbar_Leave;
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Shows the progress status of the search";
			progressBar.AccessibleName = "Progress bar";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Location = new Point(4, 274);
			progressBar.Margin = new Padding(4, 3, 4, 3);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(243, 20);
			progressBar.TabIndex = 7;
			toolTip.SetToolTip(progressBar, "Shows the progress status of the search");
			progressBar.Values.Text = "";
			progressBar.MouseEnter += SetStatusbar_Enter;
			progressBar.MouseLeave += ClearStatusbar_Leave;
			// 
			// groupBox
			// 
			groupBox.AccessibleDescription = "Groups the search element";
			groupBox.AccessibleName = "Group the search element";
			groupBox.AccessibleRole = AccessibleRole.Grouping;
			groupBox.Location = new Point(4, 3);
			groupBox.Margin = new Padding(4, 3, 4, 3);
			groupBox.Name = "groupBox";
			// 
			// 
			// 
			groupBox.Panel.AccessibleDescription = "Groups the search element";
			groupBox.Panel.AccessibleName = "Group the search element";
			groupBox.Panel.AccessibleRole = AccessibleRole.Grouping;
			groupBox.Panel.AutoScroll = true;
			groupBox.Panel.Controls.Add(buttonClear);
			groupBox.Panel.Controls.Add(textBox);
			groupBox.Size = new Size(378, 63);
			groupBox.TabIndex = 0;
			toolTip.SetToolTip(groupBox, "Group the search element");
			groupBox.Values.Heading = "Word, number, keyword, ...";
			groupBox.Values.Image = Properties.Resources.silk_pencil;
			groupBox.Enter += SetStatusbar_Enter;
			groupBox.Leave += ClearStatusbar_Leave;
			groupBox.MouseEnter += SetStatusbar_Enter;
			groupBox.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonClear
			// 
			buttonClear.AccessibleDescription = "Clears the search box";
			buttonClear.AccessibleName = "Clear the search box";
			buttonClear.AccessibleRole = AccessibleRole.PushButton;
			buttonClear.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonClear.Location = new Point(300, 5);
			buttonClear.Margin = new Padding(4, 3, 4, 3);
			buttonClear.Name = "buttonClear";
			buttonClear.Size = new Size(68, 25);
			buttonClear.TabIndex = 1;
			toolTip.SetToolTip(buttonClear, "Clear the search box");
			buttonClear.Values.Image = Properties.Resources.silk_cross;
			buttonClear.Values.Text = "&Clear";
			buttonClear.Click += ButtonClear_Click;
			buttonClear.Enter += SetStatusbar_Enter;
			buttonClear.Leave += ClearStatusbar_Leave;
			buttonClear.MouseEnter += SetStatusbar_Enter;
			buttonClear.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBox
			// 
			textBox.AccessibleDescription = "Shows the search box to input some key words";
			textBox.AccessibleName = "Search box";
			textBox.AccessibleRole = AccessibleRole.Text;
			textBox.Location = new Point(5, 5);
			textBox.Margin = new Padding(4, 3, 4, 3);
			textBox.Name = "textBox";
			textBox.Size = new Size(288, 23);
			textBox.TabIndex = 0;
			toolTip.SetToolTip(textBox, "Search box");
			textBox.TextChanged += TextBox_TextChanged;
			textBox.Enter += SetStatusbar_Enter;
			textBox.Leave += ClearStatusbar_Leave;
			textBox.MouseEnter += SetStatusbar_Enter;
			textBox.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonOpen
			// 
			buttonOpen.AccessibleDescription = "Opens the selected result item";
			buttonOpen.AccessibleName = "Open the selected result item";
			buttonOpen.AccessibleRole = AccessibleRole.PushButton;
			buttonOpen.Location = new Point(276, 239);
			buttonOpen.Margin = new Padding(4, 3, 4, 3);
			buttonOpen.Name = "buttonOpen";
			buttonOpen.Size = new Size(105, 29);
			buttonOpen.TabIndex = 6;
			toolTip.SetToolTip(buttonOpen, "Open the selected result item");
			buttonOpen.Values.Image = Properties.Resources.silk_go;
			buttonOpen.Values.Text = "&Open";
			buttonOpen.Click += ButtonOpen_Click;
			buttonOpen.Enter += SetStatusbar_Enter;
			buttonOpen.Leave += ClearStatusbar_Leave;
			buttonOpen.MouseEnter += SetStatusbar_Enter;
			buttonOpen.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonUnmarkAll
			// 
			buttonUnmarkAll.AccessibleDescription = "Umarks all orbital elements";
			buttonUnmarkAll.AccessibleName = "Umark all orbital elements";
			buttonUnmarkAll.AccessibleRole = AccessibleRole.PushButton;
			buttonUnmarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonUnmarkAll.Location = new Point(276, 110);
			buttonUnmarkAll.Margin = new Padding(4, 3, 4, 3);
			buttonUnmarkAll.Name = "buttonUnmarkAll";
			buttonUnmarkAll.Size = new Size(105, 29);
			buttonUnmarkAll.TabIndex = 3;
			toolTip.SetToolTip(buttonUnmarkAll, "Umark all orbital elements");
			buttonUnmarkAll.Values.Text = "&Unmark all";
			buttonUnmarkAll.Click += ButtonUnmarkAll_Click;
			buttonUnmarkAll.Enter += SetStatusbar_Enter;
			buttonUnmarkAll.Leave += ClearStatusbar_Leave;
			buttonUnmarkAll.MouseEnter += SetStatusbar_Enter;
			buttonUnmarkAll.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonMarkAll
			// 
			buttonMarkAll.AccessibleDescription = "Marks all orbital elements to search";
			buttonMarkAll.AccessibleName = "Mark all orbital elements";
			buttonMarkAll.AccessibleRole = AccessibleRole.PushButton;
			buttonMarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonMarkAll.Location = new Point(276, 74);
			buttonMarkAll.Margin = new Padding(4, 3, 4, 3);
			buttonMarkAll.Name = "buttonMarkAll";
			buttonMarkAll.Size = new Size(105, 29);
			buttonMarkAll.TabIndex = 2;
			toolTip.SetToolTip(buttonMarkAll, "Mark all orbital elements");
			buttonMarkAll.Values.Image = Properties.Resources.silk_asterisk_orange;
			buttonMarkAll.Values.Text = "&Mark all";
			buttonMarkAll.Click += ButtonMarkAll_Click;
			buttonMarkAll.Enter += SetStatusbar_Enter;
			buttonMarkAll.Leave += ClearStatusbar_Leave;
			buttonMarkAll.MouseEnter += SetStatusbar_Enter;
			buttonMarkAll.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSearch
			// 
			buttonSearch.AccessibleDescription = "Searchs the keyword";
			buttonSearch.AccessibleName = "Search";
			buttonSearch.AccessibleRole = AccessibleRole.PushButton;
			buttonSearch.Location = new Point(276, 145);
			buttonSearch.Margin = new Padding(4, 3, 4, 3);
			buttonSearch.Name = "buttonSearch";
			buttonSearch.Size = new Size(105, 29);
			buttonSearch.TabIndex = 4;
			toolTip.SetToolTip(buttonSearch, "Search");
			buttonSearch.Values.Image = Properties.Resources.silk_magnifier;
			buttonSearch.Values.Text = "&Search";
			buttonSearch.Click += ButtonSearch_Click;
			buttonSearch.Enter += SetStatusbar_Enter;
			buttonSearch.Leave += ClearStatusbar_Leave;
			buttonSearch.MouseEnter += SetStatusbar_Enter;
			buttonSearch.MouseLeave += ClearStatusbar_Leave;
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			// 
			// SearchForm
			// 
			AccessibleDescription = "Dialog to search a word, a keyword or a number";
			AccessibleName = "Search";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(387, 525);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SearchForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Search";
			toolTip.SetToolTip(this, "Search");
			FormClosed += SearchForm_FormClosed;
			Load += SearchForm_Load;
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)groupBox.Panel).EndInit();
			groupBox.Panel.ResumeLayout(false);
			groupBox.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)groupBox).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Krypton.Toolkit.KryptonCheckedListBox checkedListBox;
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonButton buttonUnmarkAll;
		private Krypton.Toolkit.KryptonButton buttonMarkAll;
		private Krypton.Toolkit.KryptonButton buttonSearch;
		private Krypton.Toolkit.KryptonButton buttonOpen;
		private Krypton.Toolkit.KryptonGroupBox groupBox;
		private Krypton.Toolkit.KryptonTextBox textBox;
		private Krypton.Toolkit.KryptonButton buttonClear;
		private Krypton.Toolkit.KryptonLabel labelEntriesFound;
		private Krypton.Toolkit.KryptonProgressBar progressBar;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private Krypton.Toolkit.KryptonButton buttonCancel;
		private ListView listView;
		private ColumnHeader columnHeaderIndex;
		private ColumnHeader columnHeaderProperty;
		private ColumnHeader columnHeaderValue;
	}
}