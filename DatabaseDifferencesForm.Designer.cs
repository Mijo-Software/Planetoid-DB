namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	partial class DatabaseDifferencesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseDifferencesForm));
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.groupBoxResults = new Krypton.Toolkit.KryptonGroupBox();
			this.listBoxResults = new Krypton.Toolkit.KryptonListBox();
			this.buttonCancel = new Krypton.Toolkit.KryptonButton();
			this.buttonCompare = new Krypton.Toolkit.KryptonButton();
			this.groupBoxProgress = new Krypton.Toolkit.KryptonGroupBox();
			this.progressBar = new Krypton.Toolkit.KryptonProgressBar();
			this.groupBox2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonGroupBox();
			this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.labelSize2ndMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			this.labelPath2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			this.buttonOpen2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonButton();
			this.labelDate2ndMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			this.labelDate2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			this.labelPath2ndMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			this.labelSize2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			this.groupBox1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonGroupBox();
			this.tableLayoutPanel1stMpcorbDatFile = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.labelSize1stMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			this.labelPath1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			this.buttonOpen1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonButton();
			this.labelDate1stMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			this.labelDate1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			this.labelPath1stMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			this.labelSize1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.openFileDialog1stMpcorbDatFileDatabase = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2ndMpcorbDatFileDatabase = new System.Windows.Forms.OpenFileDialog();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxResults)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxResults.Panel)).BeginInit();
			this.groupBoxResults.Panel.SuspendLayout();
			this.groupBoxResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxProgress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxProgress.Panel)).BeginInit();
			this.groupBoxProgress.Panel.SuspendLayout();
			this.groupBoxProgress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2ndMpcorbDatFileDatabase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2ndMpcorbDatFileDatabase.Panel)).BeginInit();
			this.groupBox2ndMpcorbDatFileDatabase.Panel.SuspendLayout();
			this.groupBox2ndMpcorbDatFileDatabase.SuspendLayout();
			this.kryptonTableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1stMpcorbDatFileDatabase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1stMpcorbDatFileDatabase.Panel)).BeginInit();
			this.groupBox1stMpcorbDatFileDatabase.Panel.SuspendLayout();
			this.groupBox1stMpcorbDatFileDatabase.SuspendLayout();
			this.tableLayoutPanel1stMpcorbDatFile.SuspendLayout();
			this.SuspendLayout();
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
			this.statusStrip.Size = new System.Drawing.Size(841, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 10;
			this.statusStrip.Text = "status bar";
			this.statusStrip.UseWaitCursor = true;
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
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Container to arrange the toolbars";
			this.toolStripContainer.AccessibleName = "Container to arrange the toolbars";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			this.toolStripContainer.BottomToolStripPanel.UseWaitCursor = true;
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.panel);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(841, 425);
			this.toolStripContainer.ContentPanel.UseWaitCursor = true;
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			this.toolStripContainer.LeftToolStripPanel.UseWaitCursor = true;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			this.toolStripContainer.RightToolStripPanel.UseWaitCursor = true;
			this.toolStripContainer.Size = new System.Drawing.Size(841, 472);
			this.toolStripContainer.TabIndex = 11;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.UseWaitCursor = true;
			this.toolStripContainer.UseWaitCursor = true;
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "Panel";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.groupBoxResults);
			this.panel.Controls.Add(this.buttonCancel);
			this.panel.Controls.Add(this.buttonCompare);
			this.panel.Controls.Add(this.groupBoxProgress);
			this.panel.Controls.Add(this.groupBox2ndMpcorbDatFileDatabase);
			this.panel.Controls.Add(this.groupBox1stMpcorbDatFileDatabase);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(841, 425);
			this.panel.TabIndex = 0;
			this.panel.TabStop = true;
			this.panel.UseWaitCursor = true;
			// 
			// groupBoxResults
			// 
			this.groupBoxResults.AccessibleDescription = "Groups the results";
			this.groupBoxResults.AccessibleName = "Group the results";
			this.groupBoxResults.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxResults.Location = new System.Drawing.Point(14, 192);
			this.groupBoxResults.Name = "groupBoxResults";
			// 
			// groupBoxResults.Panel
			// 
			this.groupBoxResults.Panel.AccessibleDescription = "Groups the results";
			this.groupBoxResults.Panel.AccessibleName = "Group the results";
			this.groupBoxResults.Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxResults.Panel.Controls.Add(this.listBoxResults);
			this.groupBoxResults.Panel.UseWaitCursor = true;
			this.groupBoxResults.Panel.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBoxResults.Panel.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBoxResults.Panel.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBoxResults.Panel.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBoxResults.Size = new System.Drawing.Size(818, 247);
			this.groupBoxResults.TabIndex = 20;
			this.toolTip.SetToolTip(this.groupBoxResults, "Results");
			this.groupBoxResults.UseWaitCursor = true;
			this.groupBoxResults.Values.Description = "300 items added, 200 items edited, 100 items removed";
			this.groupBoxResults.Values.Heading = "Results";
			this.groupBoxResults.Values.Image = global::Planetoid_DB.Properties.Resources.silk_table;
			// 
			// listBoxResults
			// 
			this.listBoxResults.AccessibleDescription = "Shows the result in a list with changes";
			this.listBoxResults.AccessibleName = "Result list";
			this.listBoxResults.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxResults.HorizontalScrollbar = true;
			this.listBoxResults.Location = new System.Drawing.Point(0, 0);
			this.listBoxResults.Name = "listBoxResults";
			this.listBoxResults.Size = new System.Drawing.Size(814, 223);
			this.listBoxResults.TabIndex = 0;
			this.toolTip.SetToolTip(this.listBoxResults, "Results");
			this.listBoxResults.UseWaitCursor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleDescription = "Cancels the progress";
			this.buttonCancel.AccessibleName = "Cancel";
			this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancel.CornerRoundingRadius = -1F;
			this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCancel.Location = new System.Drawing.Point(99, 155);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(81, 31);
			this.buttonCancel.TabIndex = 19;
			this.toolTip.SetToolTip(this.buttonCancel, "Cancel the progress");
			this.buttonCancel.UseWaitCursor = true;
			this.buttonCancel.Values.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.buttonCancel.Values.Text = "C&ancel";
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			this.buttonCancel.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancel.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCancel.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancel.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCompare
			// 
			this.buttonCompare.AccessibleDescription = "Starts the progress and compare";
			this.buttonCompare.AccessibleName = "Compare";
			this.buttonCompare.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCompare.CornerRoundingRadius = -1F;
			this.buttonCompare.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCompare.Location = new System.Drawing.Point(12, 155);
			this.buttonCompare.Name = "buttonCompare";
			this.buttonCompare.Size = new System.Drawing.Size(81, 31);
			this.buttonCompare.TabIndex = 18;
			this.toolTip.SetToolTip(this.buttonCompare, "Start the progress and list");
			this.buttonCompare.UseWaitCursor = true;
			this.buttonCompare.Values.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.buttonCompare.Values.Text = "C&ompare";
			this.buttonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
			this.buttonCompare.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCompare.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCompare.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCompare.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupBoxProgress
			// 
			this.groupBoxProgress.AccessibleDescription = "Shows the progress status of the comparison";
			this.groupBoxProgress.AccessibleName = "Progress bar";
			this.groupBoxProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxProgress.Location = new System.Drawing.Point(186, 155);
			this.groupBoxProgress.Name = "groupBoxProgress";
			// 
			// groupBoxProgress.Panel
			// 
			this.groupBoxProgress.Panel.AccessibleDescription = "Shows the progress status of the comparison";
			this.groupBoxProgress.Panel.AccessibleName = "panel";
			this.groupBoxProgress.Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.groupBoxProgress.Panel.Controls.Add(this.progressBar);
			this.groupBoxProgress.Panel.UseWaitCursor = true;
			this.groupBoxProgress.Panel.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBoxProgress.Panel.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBoxProgress.Panel.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBoxProgress.Panel.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBoxProgress.Size = new System.Drawing.Size(646, 31);
			this.groupBoxProgress.TabIndex = 17;
			this.toolTip.SetToolTip(this.groupBoxProgress, "Shows the progress status of the comparison");
			this.groupBoxProgress.UseWaitCursor = true;
			this.groupBoxProgress.Values.Description = "100 %";
			this.groupBoxProgress.Values.Heading = "Progress";
			this.groupBoxProgress.Values.Image = global::Planetoid_DB.Properties.Resources.silk_time;
			this.groupBoxProgress.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBoxProgress.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBoxProgress.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBoxProgress.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// progressBar
			// 
			this.progressBar.AccessibleDescription = "Shows the progress status of the comparison";
			this.progressBar.AccessibleName = "Progress bar";
			this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBar.Location = new System.Drawing.Point(0, 0);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(642, 7);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 8;
			this.toolTip.SetToolTip(this.progressBar, "Shows the progress status of the comparison");
			this.progressBar.UseWaitCursor = true;
			this.progressBar.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBar.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupBox2ndMpcorbDatFileDatabase
			// 
			this.groupBox2ndMpcorbDatFileDatabase.AccessibleDescription = "Groups the data";
			this.groupBox2ndMpcorbDatFileDatabase.AccessibleName = "Group box for the second file";
			this.groupBox2ndMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBox2ndMpcorbDatFileDatabase.Location = new System.Drawing.Point(425, 12);
			this.groupBox2ndMpcorbDatFileDatabase.Name = "groupBox2ndMpcorbDatFileDatabase";
			// 
			// groupBox2ndMpcorbDatFileDatabase.Panel
			// 
			this.groupBox2ndMpcorbDatFileDatabase.Panel.AccessibleDescription = "Groups the data";
			this.groupBox2ndMpcorbDatFileDatabase.Panel.AccessibleName = "Panel";
			this.groupBox2ndMpcorbDatFileDatabase.Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.groupBox2ndMpcorbDatFileDatabase.Panel.Controls.Add(this.kryptonTableLayoutPanel1);
			this.toolTip.SetToolTip(this.groupBox2ndMpcorbDatFileDatabase.Panel, "Open the 2nd MPCORB.DAT file");
			this.groupBox2ndMpcorbDatFileDatabase.Panel.UseWaitCursor = true;
			this.groupBox2ndMpcorbDatFileDatabase.Panel.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox2ndMpcorbDatFileDatabase.Panel.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBox2ndMpcorbDatFileDatabase.Panel.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox2ndMpcorbDatFileDatabase.Panel.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBox2ndMpcorbDatFileDatabase.Size = new System.Drawing.Size(407, 137);
			this.groupBox2ndMpcorbDatFileDatabase.TabIndex = 16;
			this.toolTip.SetToolTip(this.groupBox2ndMpcorbDatFileDatabase, "Open the 2nd MPCORB.DAT file");
			this.groupBox2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			this.groupBox2ndMpcorbDatFileDatabase.Values.Heading = "The second MPCORB.DAT file";
			this.groupBox2ndMpcorbDatFileDatabase.Values.Image = global::Planetoid_DB.Properties.Resources.silk_database;
			this.groupBox2ndMpcorbDatFileDatabase.DragDrop += new System.Windows.Forms.DragEventHandler(this.GroupBox2ndMpcorbDatFileDatabase_DragDrop);
			// 
			// kryptonTableLayoutPanel1
			// 
			this.kryptonTableLayoutPanel1.AccessibleDescription = "Groups the data";
			this.kryptonTableLayoutPanel1.AccessibleName = "Panel";
			this.kryptonTableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.kryptonTableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage")));
			this.kryptonTableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.kryptonTableLayoutPanel1.ColumnCount = 2;
			this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.kryptonTableLayoutPanel1.Controls.Add(this.labelSize2ndMpcorbDatFileDatabaseValue, 1, 3);
			this.kryptonTableLayoutPanel1.Controls.Add(this.labelPath2ndMpcorbDatFileDatabase, 0, 1);
			this.kryptonTableLayoutPanel1.Controls.Add(this.buttonOpen2ndMpcorbDatFileDatabase, 0, 0);
			this.kryptonTableLayoutPanel1.Controls.Add(this.labelDate2ndMpcorbDatFileDatabaseValue, 1, 2);
			this.kryptonTableLayoutPanel1.Controls.Add(this.labelDate2ndMpcorbDatFileDatabase, 0, 2);
			this.kryptonTableLayoutPanel1.Controls.Add(this.labelPath2ndMpcorbDatFileDatabaseValue, 1, 1);
			this.kryptonTableLayoutPanel1.Controls.Add(this.labelSize2ndMpcorbDatFileDatabase, 0, 3);
			this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
			this.kryptonTableLayoutPanel1.RowCount = 4;
			this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(403, 113);
			this.kryptonTableLayoutPanel1.TabIndex = 13;
			this.toolTip.SetToolTip(this.kryptonTableLayoutPanel1, "Groups the data");
			this.kryptonTableLayoutPanel1.UseWaitCursor = true;
			// 
			// labelSize2ndMpcorbDatFileDatabaseValue
			// 
			this.labelSize2ndMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the file size of the second MPCORB.DAT file";
			this.labelSize2ndMpcorbDatFileDatabaseValue.AccessibleName = "File size of the second MPCORB.DAT file";
			this.labelSize2ndMpcorbDatFileDatabaseValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSize2ndMpcorbDatFileDatabaseValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSize2ndMpcorbDatFileDatabaseValue.Location = new System.Drawing.Point(47, 86);
			this.labelSize2ndMpcorbDatFileDatabaseValue.Name = "labelSize2ndMpcorbDatFileDatabaseValue";
			this.labelSize2ndMpcorbDatFileDatabaseValue.Size = new System.Drawing.Size(355, 24);
			this.labelSize2ndMpcorbDatFileDatabaseValue.TabIndex = 17;
			this.toolTip.SetToolTip(this.labelSize2ndMpcorbDatFileDatabaseValue, "File size of the second MPCORB.DAT file");
			this.labelSize2ndMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			this.labelSize2ndMpcorbDatFileDatabaseValue.Values.Text = "1234567890 bytes";
			this.labelSize2ndMpcorbDatFileDatabaseValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSize2ndMpcorbDatFileDatabaseValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize2ndMpcorbDatFileDatabaseValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSize2ndMpcorbDatFileDatabaseValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize2ndMpcorbDatFileDatabaseValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPath2ndMpcorbDatFileDatabase
			// 
			this.labelPath2ndMpcorbDatFileDatabase.AccessibleDescription = "Header of the path";
			this.labelPath2ndMpcorbDatFileDatabase.AccessibleName = "Header of the path";
			this.labelPath2ndMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPath2ndMpcorbDatFileDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPath2ndMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelPath2ndMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 34);
			this.labelPath2ndMpcorbDatFileDatabase.Name = "labelPath2ndMpcorbDatFileDatabase";
			this.labelPath2ndMpcorbDatFileDatabase.Size = new System.Drawing.Size(38, 20);
			this.labelPath2ndMpcorbDatFileDatabase.TabIndex = 10;
			this.toolTip.SetToolTip(this.labelPath2ndMpcorbDatFileDatabase, "Path");
			this.labelPath2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			this.labelPath2ndMpcorbDatFileDatabase.Values.Text = "Path";
			this.labelPath2ndMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath2ndMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPath2ndMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath2ndMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonOpen2ndMpcorbDatFileDatabase
			// 
			this.buttonOpen2ndMpcorbDatFileDatabase.AccessibleDescription = "Opens the second MPRCORB.DAT file";
			this.buttonOpen2ndMpcorbDatFileDatabase.AccessibleName = "Open the second MPRCORB.DAT file";
			this.buttonOpen2ndMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonTableLayoutPanel1.SetColumnSpan(this.buttonOpen2ndMpcorbDatFileDatabase, 2);
			this.buttonOpen2ndMpcorbDatFileDatabase.CornerRoundingRadius = -1F;
			this.buttonOpen2ndMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 3);
			this.buttonOpen2ndMpcorbDatFileDatabase.Name = "buttonOpen2ndMpcorbDatFileDatabase";
			this.buttonOpen2ndMpcorbDatFileDatabase.Size = new System.Drawing.Size(184, 25);
			this.buttonOpen2ndMpcorbDatFileDatabase.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonOpen2ndMpcorbDatFileDatabase, "Open 2nd MPRCORB.DAT file");
			this.buttonOpen2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			this.buttonOpen2ndMpcorbDatFileDatabase.Values.Image = global::Planetoid_DB.Properties.Resources.silk_folder;
			this.buttonOpen2ndMpcorbDatFileDatabase.Values.Text = "Open &2nd MPRCORB.DAT file";
			this.buttonOpen2ndMpcorbDatFileDatabase.Click += new System.EventHandler(this.ButtonOpen2ndMpcorbDatFileDatabase_Click);
			this.buttonOpen2ndMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpen2ndMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOpen2ndMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpen2ndMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDate2ndMpcorbDatFileDatabaseValue
			// 
			this.labelDate2ndMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the date of the second MPCORB.DAT file";
			this.labelDate2ndMpcorbDatFileDatabaseValue.AccessibleName = "Date of the second MPCORB.DAT file";
			this.labelDate2ndMpcorbDatFileDatabaseValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDate2ndMpcorbDatFileDatabaseValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDate2ndMpcorbDatFileDatabaseValue.Location = new System.Drawing.Point(47, 60);
			this.labelDate2ndMpcorbDatFileDatabaseValue.Name = "labelDate2ndMpcorbDatFileDatabaseValue";
			this.labelDate2ndMpcorbDatFileDatabaseValue.Size = new System.Drawing.Size(355, 20);
			this.labelDate2ndMpcorbDatFileDatabaseValue.TabIndex = 16;
			this.toolTip.SetToolTip(this.labelDate2ndMpcorbDatFileDatabaseValue, "Date of the second MPCORB.DAT file");
			this.labelDate2ndMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			this.labelDate2ndMpcorbDatFileDatabaseValue.Values.Text = "00.00.0000 00:00:00";
			this.labelDate2ndMpcorbDatFileDatabaseValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDate2ndMpcorbDatFileDatabaseValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate2ndMpcorbDatFileDatabaseValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDate2ndMpcorbDatFileDatabaseValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate2ndMpcorbDatFileDatabaseValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDate2ndMpcorbDatFileDatabase
			// 
			this.labelDate2ndMpcorbDatFileDatabase.AccessibleDescription = "Header of the date";
			this.labelDate2ndMpcorbDatFileDatabase.AccessibleName = "Header of the date";
			this.labelDate2ndMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDate2ndMpcorbDatFileDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDate2ndMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelDate2ndMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 60);
			this.labelDate2ndMpcorbDatFileDatabase.Name = "labelDate2ndMpcorbDatFileDatabase";
			this.labelDate2ndMpcorbDatFileDatabase.Size = new System.Drawing.Size(38, 20);
			this.labelDate2ndMpcorbDatFileDatabase.TabIndex = 11;
			this.toolTip.SetToolTip(this.labelDate2ndMpcorbDatFileDatabase, "Date");
			this.labelDate2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			this.labelDate2ndMpcorbDatFileDatabase.Values.Text = "Date";
			this.labelDate2ndMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate2ndMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDate2ndMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate2ndMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPath2ndMpcorbDatFileDatabaseValue
			// 
			this.labelPath2ndMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the path of the second MPCORB.DAT file";
			this.labelPath2ndMpcorbDatFileDatabaseValue.AccessibleName = "Path of the second MPCORB.DAT file";
			this.labelPath2ndMpcorbDatFileDatabaseValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPath2ndMpcorbDatFileDatabaseValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPath2ndMpcorbDatFileDatabaseValue.Location = new System.Drawing.Point(47, 34);
			this.labelPath2ndMpcorbDatFileDatabaseValue.Name = "labelPath2ndMpcorbDatFileDatabaseValue";
			this.labelPath2ndMpcorbDatFileDatabaseValue.Size = new System.Drawing.Size(355, 20);
			this.labelPath2ndMpcorbDatFileDatabaseValue.TabIndex = 15;
			this.toolTip.SetToolTip(this.labelPath2ndMpcorbDatFileDatabaseValue, "Path of the second MPCORB.DAT file");
			this.labelPath2ndMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			this.labelPath2ndMpcorbDatFileDatabaseValue.Values.Text = "C:\\This-can-be-a\\very-very-long\\path\\to-the-file\\MPCORB.DAT";
			this.labelPath2ndMpcorbDatFileDatabaseValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelPath2ndMpcorbDatFileDatabaseValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath2ndMpcorbDatFileDatabaseValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPath2ndMpcorbDatFileDatabaseValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath2ndMpcorbDatFileDatabaseValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSize2ndMpcorbDatFileDatabase
			// 
			this.labelSize2ndMpcorbDatFileDatabase.AccessibleDescription = "Header of the size";
			this.labelSize2ndMpcorbDatFileDatabase.AccessibleName = "Header of the size";
			this.labelSize2ndMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSize2ndMpcorbDatFileDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSize2ndMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelSize2ndMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 86);
			this.labelSize2ndMpcorbDatFileDatabase.Name = "labelSize2ndMpcorbDatFileDatabase";
			this.labelSize2ndMpcorbDatFileDatabase.Size = new System.Drawing.Size(38, 24);
			this.labelSize2ndMpcorbDatFileDatabase.TabIndex = 12;
			this.toolTip.SetToolTip(this.labelSize2ndMpcorbDatFileDatabase, "Size");
			this.labelSize2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			this.labelSize2ndMpcorbDatFileDatabase.Values.Text = "Size";
			this.labelSize2ndMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize2ndMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSize2ndMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize2ndMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// groupBox1stMpcorbDatFileDatabase
			// 
			this.groupBox1stMpcorbDatFileDatabase.AccessibleDescription = "Groups the data";
			this.groupBox1stMpcorbDatFileDatabase.AccessibleName = "Group box for the first file";
			this.groupBox1stMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBox1stMpcorbDatFileDatabase.Location = new System.Drawing.Point(12, 12);
			this.groupBox1stMpcorbDatFileDatabase.Name = "groupBox1stMpcorbDatFileDatabase";
			// 
			// groupBox1stMpcorbDatFileDatabase.Panel
			// 
			this.groupBox1stMpcorbDatFileDatabase.Panel.AccessibleDescription = "Groups the data";
			this.groupBox1stMpcorbDatFileDatabase.Panel.AccessibleName = "Panel";
			this.groupBox1stMpcorbDatFileDatabase.Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.groupBox1stMpcorbDatFileDatabase.Panel.Controls.Add(this.tableLayoutPanel1stMpcorbDatFile);
			this.toolTip.SetToolTip(this.groupBox1stMpcorbDatFileDatabase.Panel, "Open the 1st MPCORB.DAT file");
			this.groupBox1stMpcorbDatFileDatabase.Panel.UseWaitCursor = true;
			this.groupBox1stMpcorbDatFileDatabase.Panel.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox1stMpcorbDatFileDatabase.Panel.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBox1stMpcorbDatFileDatabase.Panel.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox1stMpcorbDatFileDatabase.Panel.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBox1stMpcorbDatFileDatabase.Size = new System.Drawing.Size(407, 137);
			this.groupBox1stMpcorbDatFileDatabase.TabIndex = 15;
			this.toolTip.SetToolTip(this.groupBox1stMpcorbDatFileDatabase, "Open the 1st MPCORB.DAT file");
			this.groupBox1stMpcorbDatFileDatabase.UseWaitCursor = true;
			this.groupBox1stMpcorbDatFileDatabase.Values.Heading = "The first MPCORB.DAT file";
			this.groupBox1stMpcorbDatFileDatabase.Values.Image = global::Planetoid_DB.Properties.Resources.silk_database;
			this.groupBox1stMpcorbDatFileDatabase.DragDrop += new System.Windows.Forms.DragEventHandler(this.GroupBox1stMpcorbDatFileDatabase_DragDrop);
			this.groupBox1stMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox1stMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.groupBox1stMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.groupBox1stMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel1stMpcorbDatFile
			// 
			this.tableLayoutPanel1stMpcorbDatFile.AccessibleDescription = "Groups the data";
			this.tableLayoutPanel1stMpcorbDatFile.AccessibleName = "Panel";
			this.tableLayoutPanel1stMpcorbDatFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.tableLayoutPanel1stMpcorbDatFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1stMpcorbDatFile.BackgroundImage")));
			this.tableLayoutPanel1stMpcorbDatFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel1stMpcorbDatFile.ColumnCount = 2;
			this.tableLayoutPanel1stMpcorbDatFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1stMpcorbDatFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1stMpcorbDatFile.Controls.Add(this.labelSize1stMpcorbDatFileDatabaseValue, 1, 3);
			this.tableLayoutPanel1stMpcorbDatFile.Controls.Add(this.labelPath1stMpcorbDatFileDatabase, 0, 1);
			this.tableLayoutPanel1stMpcorbDatFile.Controls.Add(this.buttonOpen1stMpcorbDatFileDatabase, 0, 0);
			this.tableLayoutPanel1stMpcorbDatFile.Controls.Add(this.labelDate1stMpcorbDatFileDatabaseValue, 1, 2);
			this.tableLayoutPanel1stMpcorbDatFile.Controls.Add(this.labelDate1stMpcorbDatFileDatabase, 0, 2);
			this.tableLayoutPanel1stMpcorbDatFile.Controls.Add(this.labelPath1stMpcorbDatFileDatabaseValue, 1, 1);
			this.tableLayoutPanel1stMpcorbDatFile.Controls.Add(this.labelSize1stMpcorbDatFileDatabase, 0, 3);
			this.tableLayoutPanel1stMpcorbDatFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1stMpcorbDatFile.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1stMpcorbDatFile.Name = "tableLayoutPanel1stMpcorbDatFile";
			this.tableLayoutPanel1stMpcorbDatFile.RowCount = 4;
			this.tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1stMpcorbDatFile.Size = new System.Drawing.Size(403, 113);
			this.tableLayoutPanel1stMpcorbDatFile.TabIndex = 13;
			this.toolTip.SetToolTip(this.tableLayoutPanel1stMpcorbDatFile, "Groups the data");
			this.tableLayoutPanel1stMpcorbDatFile.UseWaitCursor = true;
			this.tableLayoutPanel1stMpcorbDatFile.Enter += new System.EventHandler(this.ClearStatusbar_Leave);
			this.tableLayoutPanel1stMpcorbDatFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.tableLayoutPanel1stMpcorbDatFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.tableLayoutPanel1stMpcorbDatFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSize1stMpcorbDatFileDatabaseValue
			// 
			this.labelSize1stMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the file size of the first MPCORB.DAT file";
			this.labelSize1stMpcorbDatFileDatabaseValue.AccessibleName = "File size of the first MPCORB.DAT file";
			this.labelSize1stMpcorbDatFileDatabaseValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSize1stMpcorbDatFileDatabaseValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSize1stMpcorbDatFileDatabaseValue.Location = new System.Drawing.Point(47, 86);
			this.labelSize1stMpcorbDatFileDatabaseValue.Name = "labelSize1stMpcorbDatFileDatabaseValue";
			this.labelSize1stMpcorbDatFileDatabaseValue.Size = new System.Drawing.Size(355, 24);
			this.labelSize1stMpcorbDatFileDatabaseValue.TabIndex = 17;
			this.toolTip.SetToolTip(this.labelSize1stMpcorbDatFileDatabaseValue, "File size of the first MPCORB.DAT file");
			this.labelSize1stMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			this.labelSize1stMpcorbDatFileDatabaseValue.Values.Text = "1234567890 bytes";
			this.labelSize1stMpcorbDatFileDatabaseValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSize1stMpcorbDatFileDatabaseValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize1stMpcorbDatFileDatabaseValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSize1stMpcorbDatFileDatabaseValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize1stMpcorbDatFileDatabaseValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPath1stMpcorbDatFileDatabase
			// 
			this.labelPath1stMpcorbDatFileDatabase.AccessibleDescription = "Header of the path";
			this.labelPath1stMpcorbDatFileDatabase.AccessibleName = "Header of the path";
			this.labelPath1stMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPath1stMpcorbDatFileDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPath1stMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelPath1stMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 34);
			this.labelPath1stMpcorbDatFileDatabase.Name = "labelPath1stMpcorbDatFileDatabase";
			this.labelPath1stMpcorbDatFileDatabase.Size = new System.Drawing.Size(38, 20);
			this.labelPath1stMpcorbDatFileDatabase.TabIndex = 10;
			this.toolTip.SetToolTip(this.labelPath1stMpcorbDatFileDatabase, "Path");
			this.labelPath1stMpcorbDatFileDatabase.UseWaitCursor = true;
			this.labelPath1stMpcorbDatFileDatabase.Values.Text = "Path";
			this.labelPath1stMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath1stMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPath1stMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath1stMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonOpen1stMpcorbDatFileDatabase
			// 
			this.buttonOpen1stMpcorbDatFileDatabase.AccessibleDescription = "Opens the first MPRCORB.DAT file";
			this.buttonOpen1stMpcorbDatFileDatabase.AccessibleName = "Open the first MPRCORB.DAT file";
			this.buttonOpen1stMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.tableLayoutPanel1stMpcorbDatFile.SetColumnSpan(this.buttonOpen1stMpcorbDatFileDatabase, 2);
			this.buttonOpen1stMpcorbDatFileDatabase.CornerRoundingRadius = -1F;
			this.buttonOpen1stMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 3);
			this.buttonOpen1stMpcorbDatFileDatabase.Name = "buttonOpen1stMpcorbDatFileDatabase";
			this.buttonOpen1stMpcorbDatFileDatabase.Size = new System.Drawing.Size(184, 25);
			this.buttonOpen1stMpcorbDatFileDatabase.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonOpen1stMpcorbDatFileDatabase, "Open 1st MPRCORB.DAT file");
			this.buttonOpen1stMpcorbDatFileDatabase.UseWaitCursor = true;
			this.buttonOpen1stMpcorbDatFileDatabase.Values.Image = global::Planetoid_DB.Properties.Resources.silk_folder;
			this.buttonOpen1stMpcorbDatFileDatabase.Values.Text = "Open &1st MPRCORB.DAT file";
			this.buttonOpen1stMpcorbDatFileDatabase.Click += new System.EventHandler(this.ButtonOpen1stMpcorbDatFileDatabase_Click);
			this.buttonOpen1stMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpen1stMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOpen1stMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpen1stMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDate1stMpcorbDatFileDatabaseValue
			// 
			this.labelDate1stMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the date of the first MPCORB.DAT file";
			this.labelDate1stMpcorbDatFileDatabaseValue.AccessibleName = "Date of the first MPCORB.DAT file";
			this.labelDate1stMpcorbDatFileDatabaseValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDate1stMpcorbDatFileDatabaseValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDate1stMpcorbDatFileDatabaseValue.Location = new System.Drawing.Point(47, 60);
			this.labelDate1stMpcorbDatFileDatabaseValue.Name = "labelDate1stMpcorbDatFileDatabaseValue";
			this.labelDate1stMpcorbDatFileDatabaseValue.Size = new System.Drawing.Size(355, 20);
			this.labelDate1stMpcorbDatFileDatabaseValue.TabIndex = 16;
			this.toolTip.SetToolTip(this.labelDate1stMpcorbDatFileDatabaseValue, "Date of the first MPCORB.DAT file");
			this.labelDate1stMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			this.labelDate1stMpcorbDatFileDatabaseValue.Values.Text = "00.00.0000 00:00:00";
			this.labelDate1stMpcorbDatFileDatabaseValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDate1stMpcorbDatFileDatabaseValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate1stMpcorbDatFileDatabaseValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDate1stMpcorbDatFileDatabaseValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate1stMpcorbDatFileDatabaseValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDate1stMpcorbDatFileDatabase
			// 
			this.labelDate1stMpcorbDatFileDatabase.AccessibleDescription = "Header of the date";
			this.labelDate1stMpcorbDatFileDatabase.AccessibleName = "Header of the date";
			this.labelDate1stMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDate1stMpcorbDatFileDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDate1stMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelDate1stMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 60);
			this.labelDate1stMpcorbDatFileDatabase.Name = "labelDate1stMpcorbDatFileDatabase";
			this.labelDate1stMpcorbDatFileDatabase.Size = new System.Drawing.Size(38, 20);
			this.labelDate1stMpcorbDatFileDatabase.TabIndex = 11;
			this.toolTip.SetToolTip(this.labelDate1stMpcorbDatFileDatabase, "Date");
			this.labelDate1stMpcorbDatFileDatabase.UseWaitCursor = true;
			this.labelDate1stMpcorbDatFileDatabase.Values.Text = "Date";
			this.labelDate1stMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate1stMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDate1stMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDate1stMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPath1stMpcorbDatFileDatabaseValue
			// 
			this.labelPath1stMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the path of the first MPCORB.DAT file";
			this.labelPath1stMpcorbDatFileDatabaseValue.AccessibleName = "Path of the first MPCORB.DAT file";
			this.labelPath1stMpcorbDatFileDatabaseValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPath1stMpcorbDatFileDatabaseValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPath1stMpcorbDatFileDatabaseValue.Location = new System.Drawing.Point(47, 34);
			this.labelPath1stMpcorbDatFileDatabaseValue.Name = "labelPath1stMpcorbDatFileDatabaseValue";
			this.labelPath1stMpcorbDatFileDatabaseValue.Size = new System.Drawing.Size(355, 20);
			this.labelPath1stMpcorbDatFileDatabaseValue.TabIndex = 15;
			this.toolTip.SetToolTip(this.labelPath1stMpcorbDatFileDatabaseValue, "Path of the first MPCORB.DAT file");
			this.labelPath1stMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			this.labelPath1stMpcorbDatFileDatabaseValue.Values.Text = "C:\\This-can-be-a\\very-very-long\\path\\to-the-file\\MPCORB.DAT";
			this.labelPath1stMpcorbDatFileDatabaseValue.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelPath1stMpcorbDatFileDatabaseValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath1stMpcorbDatFileDatabaseValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPath1stMpcorbDatFileDatabaseValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPath1stMpcorbDatFileDatabaseValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSize1stMpcorbDatFileDatabase
			// 
			this.labelSize1stMpcorbDatFileDatabase.AccessibleDescription = "Header of the size";
			this.labelSize1stMpcorbDatFileDatabase.AccessibleName = "Header of the size";
			this.labelSize1stMpcorbDatFileDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSize1stMpcorbDatFileDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSize1stMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelSize1stMpcorbDatFileDatabase.Location = new System.Drawing.Point(3, 86);
			this.labelSize1stMpcorbDatFileDatabase.Name = "labelSize1stMpcorbDatFileDatabase";
			this.labelSize1stMpcorbDatFileDatabase.Size = new System.Drawing.Size(38, 24);
			this.labelSize1stMpcorbDatFileDatabase.TabIndex = 12;
			this.toolTip.SetToolTip(this.labelSize1stMpcorbDatFileDatabase, "Size");
			this.labelSize1stMpcorbDatFileDatabase.UseWaitCursor = true;
			this.labelSize1stMpcorbDatFileDatabase.Values.Text = "Size";
			this.labelSize1stMpcorbDatFileDatabase.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize1stMpcorbDatFileDatabase.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSize1stMpcorbDatFileDatabase.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSize1stMpcorbDatFileDatabase.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// openFileDialog1stMpcorbDatFileDatabase
			// 
			this.openFileDialog1stMpcorbDatFileDatabase.DefaultExt = "dat";
			this.openFileDialog1stMpcorbDatFileDatabase.Filter = "DAT files|*.dat|all files|*.*";
			// 
			// openFileDialog2ndMpcorbDatFileDatabase
			// 
			this.openFileDialog2ndMpcorbDatFileDatabase.DefaultExt = "dat";
			this.openFileDialog2ndMpcorbDatFileDatabase.Filter = "DAT files|*.dat|all files|*.*";
			// 
			// DatabaseDifferencesForm
			// 
			this.AccessibleDescription = "Compares two MPCORVB.DAT files";
			this.AccessibleName = "Database Differences";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 472);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DatabaseDifferencesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Database Differences";
			this.toolTip.SetToolTip(this, "Database Differences");
			this.UseWaitCursor = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseDifferencesForm_FormClosed);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBoxResults.Panel)).EndInit();
			this.groupBoxResults.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBoxResults)).EndInit();
			this.groupBoxResults.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBoxProgress.Panel)).EndInit();
			this.groupBoxProgress.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBoxProgress)).EndInit();
			this.groupBoxProgress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2ndMpcorbDatFileDatabase.Panel)).EndInit();
			this.groupBox2ndMpcorbDatFileDatabase.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2ndMpcorbDatFileDatabase)).EndInit();
			this.groupBox2ndMpcorbDatFileDatabase.ResumeLayout(false);
			this.kryptonTableLayoutPanel1.ResumeLayout(false);
			this.kryptonTableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1stMpcorbDatFileDatabase.Panel)).EndInit();
			this.groupBox1stMpcorbDatFileDatabase.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1stMpcorbDatFileDatabase)).EndInit();
			this.groupBox1stMpcorbDatFileDatabase.ResumeLayout(false);
			this.tableLayoutPanel1stMpcorbDatFile.ResumeLayout(false);
			this.tableLayoutPanel1stMpcorbDatFile.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonPanel panel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private Krypton.Toolkit.KryptonProgressBar progressBar;
		private Krypton.Toolkit.KryptonButton buttonOpen1stMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonLabel labelPath1stMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonTableLayoutPanel tableLayoutPanel1stMpcorbDatFile;
		private Krypton.Toolkit.KryptonLabel labelSize1stMpcorbDatFileDatabaseValue;
		private Krypton.Toolkit.KryptonLabel labelDate1stMpcorbDatFileDatabaseValue;
		private Krypton.Toolkit.KryptonLabel labelDate1stMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonLabel labelPath1stMpcorbDatFileDatabaseValue;
		private Krypton.Toolkit.KryptonLabel labelSize1stMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonGroupBox groupBox1stMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonGroupBox groupBox2ndMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
		private Krypton.Toolkit.KryptonLabel labelSize2ndMpcorbDatFileDatabaseValue;
		private Krypton.Toolkit.KryptonLabel labelPath2ndMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonButton buttonOpen2ndMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonLabel labelDate2ndMpcorbDatFileDatabaseValue;
		private Krypton.Toolkit.KryptonLabel labelDate2ndMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonLabel labelPath2ndMpcorbDatFileDatabaseValue;
		private Krypton.Toolkit.KryptonLabel labelSize2ndMpcorbDatFileDatabase;
		private System.Windows.Forms.OpenFileDialog openFileDialog1stMpcorbDatFileDatabase;
		private System.Windows.Forms.OpenFileDialog openFileDialog2ndMpcorbDatFileDatabase;
		private Krypton.Toolkit.KryptonGroupBox groupBoxProgress;
		private Krypton.Toolkit.KryptonButton buttonCancel;
		private Krypton.Toolkit.KryptonButton buttonCompare;
		private Krypton.Toolkit.KryptonGroupBox groupBoxResults;
		private Krypton.Toolkit.KryptonListBox listBoxResults;
	}
}