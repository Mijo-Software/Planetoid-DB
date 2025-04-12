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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseDifferencesForm));
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			panel = new Krypton.Toolkit.KryptonPanel();
			groupBoxResults = new Krypton.Toolkit.KryptonGroupBox();
			listBoxResults = new Krypton.Toolkit.KryptonListBox();
			buttonCancel = new Krypton.Toolkit.KryptonButton();
			buttonCompare = new Krypton.Toolkit.KryptonButton();
			groupBoxProgress = new Krypton.Toolkit.KryptonGroupBox();
			progressBar = new Krypton.Toolkit.KryptonProgressBar();
			groupBox2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonGroupBox();
			kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
			labelSize2ndMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			labelPath2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			buttonOpen2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonButton();
			labelDate2ndMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			labelDate2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			labelPath2ndMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			labelSize2ndMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			groupBox1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonGroupBox();
			tableLayoutPanel1stMpcorbDatFile = new Krypton.Toolkit.KryptonTableLayoutPanel();
			labelSize1stMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			labelPath1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			buttonOpen1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonButton();
			labelDate1stMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			labelDate1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			labelPath1stMpcorbDatFileDatabaseValue = new Krypton.Toolkit.KryptonLabel();
			labelSize1stMpcorbDatFileDatabase = new Krypton.Toolkit.KryptonLabel();
			toolTip = new ToolTip(components);
			backgroundWorker = new System.ComponentModel.BackgroundWorker();
			openFileDialog1stMpcorbDatFileDatabase = new OpenFileDialog();
			openFileDialog2ndMpcorbDatFileDatabase = new OpenFileDialog();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)groupBoxResults).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupBoxResults.Panel).BeginInit();
			groupBoxResults.Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)groupBoxProgress).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupBoxProgress.Panel).BeginInit();
			groupBoxProgress.Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)groupBox2ndMpcorbDatFileDatabase).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupBox2ndMpcorbDatFileDatabase.Panel).BeginInit();
			groupBox2ndMpcorbDatFileDatabase.Panel.SuspendLayout();
			kryptonTableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)groupBox1stMpcorbDatFileDatabase).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupBox1stMpcorbDatFileDatabase.Panel).BeginInit();
			groupBox1stMpcorbDatFileDatabase.Panel.SuspendLayout();
			tableLayoutPanel1stMpcorbDatFile.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(981, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 10;
			statusStrip.Text = "status bar";
			statusStrip.UseWaitCursor = true;
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
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Container to arrange the toolbars";
			toolStripContainer.AccessibleName = "Container to arrange the toolbars";
			toolStripContainer.AccessibleRole = AccessibleRole.StatusBar;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			toolStripContainer.BottomToolStripPanel.UseWaitCursor = true;
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(panel);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(981, 498);
			toolStripContainer.ContentPanel.UseWaitCursor = true;
			toolStripContainer.Dock = DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			toolStripContainer.LeftToolStripPanel.UseWaitCursor = true;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			toolStripContainer.RightToolStripPanel.UseWaitCursor = true;
			toolStripContainer.Size = new Size(981, 545);
			toolStripContainer.TabIndex = 11;
			toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.UseWaitCursor = true;
			toolStripContainer.UseWaitCursor = true;
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "Panel";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(groupBoxResults);
			panel.Controls.Add(buttonCancel);
			panel.Controls.Add(buttonCompare);
			panel.Controls.Add(groupBoxProgress);
			panel.Controls.Add(groupBox2ndMpcorbDatFileDatabase);
			panel.Controls.Add(groupBox1stMpcorbDatFileDatabase);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Margin = new Padding(4, 3, 4, 3);
			panel.Name = "panel";
			panel.Size = new Size(981, 498);
			panel.TabIndex = 0;
			panel.TabStop = true;
			panel.UseWaitCursor = true;
			// 
			// groupBoxResults
			// 
			groupBoxResults.AccessibleDescription = "Groups the results";
			groupBoxResults.AccessibleName = "Group the results";
			groupBoxResults.AccessibleRole = AccessibleRole.Grouping;
			groupBoxResults.Location = new Point(16, 222);
			groupBoxResults.Margin = new Padding(4, 3, 4, 3);
			groupBoxResults.Name = "groupBoxResults";
			// 
			// 
			// 
			groupBoxResults.Panel.AccessibleDescription = "Groups the results";
			groupBoxResults.Panel.AccessibleName = "Group the results";
			groupBoxResults.Panel.AccessibleRole = AccessibleRole.Grouping;
			groupBoxResults.Panel.Controls.Add(listBoxResults);
			groupBoxResults.Panel.UseWaitCursor = true;
			groupBoxResults.Panel.Enter += SetStatusbar_Enter;
			groupBoxResults.Panel.Leave += ClearStatusbar_Leave;
			groupBoxResults.Panel.MouseEnter += SetStatusbar_Enter;
			groupBoxResults.Panel.MouseLeave += ClearStatusbar_Leave;
			groupBoxResults.Size = new Size(954, 285);
			groupBoxResults.TabIndex = 20;
			toolTip.SetToolTip(groupBoxResults, "Results");
			groupBoxResults.UseWaitCursor = true;
			groupBoxResults.Values.Description = "300 items added, 200 items edited, 100 items removed";
			groupBoxResults.Values.Heading = "Results";
			groupBoxResults.Values.Image = Properties.Resources.silk_table;
			// 
			// listBoxResults
			// 
			listBoxResults.AccessibleDescription = "Shows the result in a list with changes";
			listBoxResults.AccessibleName = "Result list";
			listBoxResults.AccessibleRole = AccessibleRole.List;
			listBoxResults.Dock = DockStyle.Fill;
			listBoxResults.HorizontalScrollbar = true;
			listBoxResults.Location = new Point(0, 0);
			listBoxResults.Margin = new Padding(4, 3, 4, 3);
			listBoxResults.Name = "listBoxResults";
			listBoxResults.Size = new Size(950, 261);
			listBoxResults.TabIndex = 0;
			toolTip.SetToolTip(listBoxResults, "Results");
			listBoxResults.UseWaitCursor = true;
			// 
			// buttonCancel
			// 
			buttonCancel.AccessibleDescription = "Cancels the progress";
			buttonCancel.AccessibleName = "Cancel";
			buttonCancel.AccessibleRole = AccessibleRole.PushButton;
			buttonCancel.Font = new Font("Segoe UI", 8.5F);
			buttonCancel.Location = new Point(115, 179);
			buttonCancel.Margin = new Padding(4, 3, 4, 3);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(94, 36);
			buttonCancel.TabIndex = 19;
			toolTip.SetToolTip(buttonCancel, "Cancel the progress");
			buttonCancel.UseWaitCursor = true;
			buttonCancel.Values.DropDownArrowColor = Color.Empty;
			buttonCancel.Values.Image = Properties.Resources.silk_cancel;
			buttonCancel.Values.Text = "C&ancel";
			buttonCancel.Click += ButtonCancel_Click;
			buttonCancel.Enter += SetStatusbar_Enter;
			buttonCancel.Leave += ClearStatusbar_Leave;
			buttonCancel.MouseEnter += SetStatusbar_Enter;
			buttonCancel.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCompare
			// 
			buttonCompare.AccessibleDescription = "Starts the progress and compare";
			buttonCompare.AccessibleName = "Compare";
			buttonCompare.AccessibleRole = AccessibleRole.PushButton;
			buttonCompare.Font = new Font("Segoe UI", 8.5F);
			buttonCompare.Location = new Point(14, 179);
			buttonCompare.Margin = new Padding(4, 3, 4, 3);
			buttonCompare.Name = "buttonCompare";
			buttonCompare.Size = new Size(94, 36);
			buttonCompare.TabIndex = 18;
			toolTip.SetToolTip(buttonCompare, "Start the progress and list");
			buttonCompare.UseWaitCursor = true;
			buttonCompare.Values.DropDownArrowColor = Color.Empty;
			buttonCompare.Values.Image = Properties.Resources.silk_go;
			buttonCompare.Values.Text = "C&ompare";
			buttonCompare.Click += ButtonCompare_Click;
			buttonCompare.Enter += SetStatusbar_Enter;
			buttonCompare.Leave += ClearStatusbar_Leave;
			buttonCompare.MouseEnter += SetStatusbar_Enter;
			buttonCompare.MouseLeave += ClearStatusbar_Leave;
			// 
			// groupBoxProgress
			// 
			groupBoxProgress.AccessibleDescription = "Shows the progress status of the comparison";
			groupBoxProgress.AccessibleName = "Progress bar";
			groupBoxProgress.AccessibleRole = AccessibleRole.Grouping;
			groupBoxProgress.Location = new Point(217, 179);
			groupBoxProgress.Margin = new Padding(4, 3, 4, 3);
			groupBoxProgress.Name = "groupBoxProgress";
			// 
			// 
			// 
			groupBoxProgress.Panel.AccessibleDescription = "Shows the progress status of the comparison";
			groupBoxProgress.Panel.AccessibleName = "panel";
			groupBoxProgress.Panel.AccessibleRole = AccessibleRole.Pane;
			groupBoxProgress.Panel.Controls.Add(progressBar);
			groupBoxProgress.Panel.UseWaitCursor = true;
			groupBoxProgress.Panel.Enter += SetStatusbar_Enter;
			groupBoxProgress.Panel.Leave += ClearStatusbar_Leave;
			groupBoxProgress.Panel.MouseEnter += SetStatusbar_Enter;
			groupBoxProgress.Panel.MouseLeave += ClearStatusbar_Leave;
			groupBoxProgress.Size = new Size(754, 36);
			groupBoxProgress.TabIndex = 17;
			toolTip.SetToolTip(groupBoxProgress, "Shows the progress status of the comparison");
			groupBoxProgress.UseWaitCursor = true;
			groupBoxProgress.Values.Description = "100 %";
			groupBoxProgress.Values.Heading = "Progress";
			groupBoxProgress.Values.Image = Properties.Resources.silk_time;
			groupBoxProgress.Enter += SetStatusbar_Enter;
			groupBoxProgress.Leave += ClearStatusbar_Leave;
			groupBoxProgress.MouseEnter += SetStatusbar_Enter;
			groupBoxProgress.MouseLeave += ClearStatusbar_Leave;
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Shows the progress status of the comparison";
			progressBar.AccessibleName = "Progress bar";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Dock = DockStyle.Fill;
			progressBar.Location = new Point(0, 0);
			progressBar.Margin = new Padding(4, 3, 4, 3);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(750, 12);
			progressBar.TabIndex = 8;
			toolTip.SetToolTip(progressBar, "Shows the progress status of the comparison");
			progressBar.UseWaitCursor = true;
			progressBar.Values.Text = "";
			progressBar.MouseEnter += SetStatusbar_Enter;
			progressBar.MouseLeave += ClearStatusbar_Leave;
			// 
			// groupBox2ndMpcorbDatFileDatabase
			// 
			groupBox2ndMpcorbDatFileDatabase.AccessibleDescription = "Groups the data";
			groupBox2ndMpcorbDatFileDatabase.AccessibleName = "Group box for the second file";
			groupBox2ndMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.Grouping;
			groupBox2ndMpcorbDatFileDatabase.Location = new Point(496, 14);
			groupBox2ndMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			groupBox2ndMpcorbDatFileDatabase.Name = "groupBox2ndMpcorbDatFileDatabase";
			// 
			// 
			// 
			groupBox2ndMpcorbDatFileDatabase.Panel.AccessibleDescription = "Groups the data";
			groupBox2ndMpcorbDatFileDatabase.Panel.AccessibleName = "Panel";
			groupBox2ndMpcorbDatFileDatabase.Panel.AccessibleRole = AccessibleRole.Pane;
			groupBox2ndMpcorbDatFileDatabase.Panel.Controls.Add(kryptonTableLayoutPanel1);
			groupBox2ndMpcorbDatFileDatabase.Panel.UseWaitCursor = true;
			groupBox2ndMpcorbDatFileDatabase.Panel.Enter += SetStatusbar_Enter;
			groupBox2ndMpcorbDatFileDatabase.Panel.Leave += ClearStatusbar_Leave;
			groupBox2ndMpcorbDatFileDatabase.Panel.MouseEnter += SetStatusbar_Enter;
			groupBox2ndMpcorbDatFileDatabase.Panel.MouseLeave += ClearStatusbar_Leave;
			groupBox2ndMpcorbDatFileDatabase.Size = new Size(475, 158);
			groupBox2ndMpcorbDatFileDatabase.TabIndex = 16;
			toolTip.SetToolTip(groupBox2ndMpcorbDatFileDatabase, "Open the 2nd MPCORB.DAT file");
			groupBox2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			groupBox2ndMpcorbDatFileDatabase.Values.Heading = "The second MPCORB.DAT file";
			groupBox2ndMpcorbDatFileDatabase.Values.Image = Properties.Resources.silk_database;
			groupBox2ndMpcorbDatFileDatabase.DragDrop += GroupBox2ndMpcorbDatFileDatabase_DragDrop;
			// 
			// kryptonTableLayoutPanel1
			// 
			kryptonTableLayoutPanel1.AccessibleDescription = "Groups the data";
			kryptonTableLayoutPanel1.AccessibleName = "Panel";
			kryptonTableLayoutPanel1.AccessibleRole = AccessibleRole.Grouping;
			kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
			kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
			kryptonTableLayoutPanel1.ColumnCount = 2;
			kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			kryptonTableLayoutPanel1.Controls.Add(labelSize2ndMpcorbDatFileDatabaseValue, 1, 3);
			kryptonTableLayoutPanel1.Controls.Add(labelPath2ndMpcorbDatFileDatabase, 0, 1);
			kryptonTableLayoutPanel1.Controls.Add(buttonOpen2ndMpcorbDatFileDatabase, 0, 0);
			kryptonTableLayoutPanel1.Controls.Add(labelDate2ndMpcorbDatFileDatabaseValue, 1, 2);
			kryptonTableLayoutPanel1.Controls.Add(labelDate2ndMpcorbDatFileDatabase, 0, 2);
			kryptonTableLayoutPanel1.Controls.Add(labelPath2ndMpcorbDatFileDatabaseValue, 1, 1);
			kryptonTableLayoutPanel1.Controls.Add(labelSize2ndMpcorbDatFileDatabase, 0, 3);
			kryptonTableLayoutPanel1.Dock = DockStyle.Fill;
			kryptonTableLayoutPanel1.Location = new Point(0, 0);
			kryptonTableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
			kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
			kryptonTableLayoutPanel1.RowCount = 4;
			kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle());
			kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle());
			kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle());
			kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle());
			kryptonTableLayoutPanel1.Size = new Size(471, 134);
			kryptonTableLayoutPanel1.TabIndex = 13;
			toolTip.SetToolTip(kryptonTableLayoutPanel1, "Groups the data");
			kryptonTableLayoutPanel1.UseWaitCursor = true;
			// 
			// labelSize2ndMpcorbDatFileDatabaseValue
			// 
			labelSize2ndMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the file size of the second MPCORB.DAT file";
			labelSize2ndMpcorbDatFileDatabaseValue.AccessibleName = "File size of the second MPCORB.DAT file";
			labelSize2ndMpcorbDatFileDatabaseValue.AccessibleRole = AccessibleRole.StaticText;
			labelSize2ndMpcorbDatFileDatabaseValue.Dock = DockStyle.Fill;
			labelSize2ndMpcorbDatFileDatabaseValue.Location = new Point(50, 90);
			labelSize2ndMpcorbDatFileDatabaseValue.Margin = new Padding(4, 3, 4, 3);
			labelSize2ndMpcorbDatFileDatabaseValue.Name = "labelSize2ndMpcorbDatFileDatabaseValue";
			labelSize2ndMpcorbDatFileDatabaseValue.Size = new Size(417, 41);
			labelSize2ndMpcorbDatFileDatabaseValue.TabIndex = 17;
			toolTip.SetToolTip(labelSize2ndMpcorbDatFileDatabaseValue, "File size of the second MPCORB.DAT file");
			labelSize2ndMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			labelSize2ndMpcorbDatFileDatabaseValue.Values.Text = "1234567890 bytes";
			labelSize2ndMpcorbDatFileDatabaseValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelSize2ndMpcorbDatFileDatabaseValue.Enter += SetStatusbar_Enter;
			labelSize2ndMpcorbDatFileDatabaseValue.Leave += ClearStatusbar_Leave;
			labelSize2ndMpcorbDatFileDatabaseValue.MouseEnter += SetStatusbar_Enter;
			labelSize2ndMpcorbDatFileDatabaseValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPath2ndMpcorbDatFileDatabase
			// 
			labelPath2ndMpcorbDatFileDatabase.AccessibleDescription = "Header of the path";
			labelPath2ndMpcorbDatFileDatabase.AccessibleName = "Header of the path";
			labelPath2ndMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.StaticText;
			labelPath2ndMpcorbDatFileDatabase.Dock = DockStyle.Fill;
			labelPath2ndMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelPath2ndMpcorbDatFileDatabase.Location = new Point(4, 38);
			labelPath2ndMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			labelPath2ndMpcorbDatFileDatabase.Name = "labelPath2ndMpcorbDatFileDatabase";
			labelPath2ndMpcorbDatFileDatabase.Size = new Size(38, 20);
			labelPath2ndMpcorbDatFileDatabase.TabIndex = 10;
			toolTip.SetToolTip(labelPath2ndMpcorbDatFileDatabase, "Path");
			labelPath2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			labelPath2ndMpcorbDatFileDatabase.Values.Text = "Path";
			labelPath2ndMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			labelPath2ndMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			labelPath2ndMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			labelPath2ndMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonOpen2ndMpcorbDatFileDatabase
			// 
			buttonOpen2ndMpcorbDatFileDatabase.AccessibleDescription = "Opens the second MPRCORB.DAT file";
			buttonOpen2ndMpcorbDatFileDatabase.AccessibleName = "Open the second MPRCORB.DAT file";
			buttonOpen2ndMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.PushButton;
			kryptonTableLayoutPanel1.SetColumnSpan(buttonOpen2ndMpcorbDatFileDatabase, 2);
			buttonOpen2ndMpcorbDatFileDatabase.Location = new Point(4, 3);
			buttonOpen2ndMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			buttonOpen2ndMpcorbDatFileDatabase.Name = "buttonOpen2ndMpcorbDatFileDatabase";
			buttonOpen2ndMpcorbDatFileDatabase.Size = new Size(215, 29);
			buttonOpen2ndMpcorbDatFileDatabase.TabIndex = 9;
			toolTip.SetToolTip(buttonOpen2ndMpcorbDatFileDatabase, "Open 2nd MPRCORB.DAT file");
			buttonOpen2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			buttonOpen2ndMpcorbDatFileDatabase.Values.DropDownArrowColor = Color.Empty;
			buttonOpen2ndMpcorbDatFileDatabase.Values.Image = Properties.Resources.silk_folder;
			buttonOpen2ndMpcorbDatFileDatabase.Values.Text = "Open &2nd MPRCORB.DAT file";
			buttonOpen2ndMpcorbDatFileDatabase.Click += ButtonOpen2ndMpcorbDatFileDatabase_Click;
			buttonOpen2ndMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			buttonOpen2ndMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			buttonOpen2ndMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			buttonOpen2ndMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDate2ndMpcorbDatFileDatabaseValue
			// 
			labelDate2ndMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the date of the second MPCORB.DAT file";
			labelDate2ndMpcorbDatFileDatabaseValue.AccessibleName = "Date of the second MPCORB.DAT file";
			labelDate2ndMpcorbDatFileDatabaseValue.AccessibleRole = AccessibleRole.StaticText;
			labelDate2ndMpcorbDatFileDatabaseValue.Dock = DockStyle.Fill;
			labelDate2ndMpcorbDatFileDatabaseValue.Location = new Point(50, 64);
			labelDate2ndMpcorbDatFileDatabaseValue.Margin = new Padding(4, 3, 4, 3);
			labelDate2ndMpcorbDatFileDatabaseValue.Name = "labelDate2ndMpcorbDatFileDatabaseValue";
			labelDate2ndMpcorbDatFileDatabaseValue.Size = new Size(417, 20);
			labelDate2ndMpcorbDatFileDatabaseValue.TabIndex = 16;
			toolTip.SetToolTip(labelDate2ndMpcorbDatFileDatabaseValue, "Date of the second MPCORB.DAT file");
			labelDate2ndMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			labelDate2ndMpcorbDatFileDatabaseValue.Values.Text = "00.00.0000 00:00:00";
			labelDate2ndMpcorbDatFileDatabaseValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDate2ndMpcorbDatFileDatabaseValue.Enter += SetStatusbar_Enter;
			labelDate2ndMpcorbDatFileDatabaseValue.Leave += ClearStatusbar_Leave;
			labelDate2ndMpcorbDatFileDatabaseValue.MouseEnter += SetStatusbar_Enter;
			labelDate2ndMpcorbDatFileDatabaseValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDate2ndMpcorbDatFileDatabase
			// 
			labelDate2ndMpcorbDatFileDatabase.AccessibleDescription = "Header of the date";
			labelDate2ndMpcorbDatFileDatabase.AccessibleName = "Header of the date";
			labelDate2ndMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.StaticText;
			labelDate2ndMpcorbDatFileDatabase.Dock = DockStyle.Fill;
			labelDate2ndMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelDate2ndMpcorbDatFileDatabase.Location = new Point(4, 64);
			labelDate2ndMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			labelDate2ndMpcorbDatFileDatabase.Name = "labelDate2ndMpcorbDatFileDatabase";
			labelDate2ndMpcorbDatFileDatabase.Size = new Size(38, 20);
			labelDate2ndMpcorbDatFileDatabase.TabIndex = 11;
			toolTip.SetToolTip(labelDate2ndMpcorbDatFileDatabase, "Date");
			labelDate2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			labelDate2ndMpcorbDatFileDatabase.Values.Text = "Date";
			labelDate2ndMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			labelDate2ndMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			labelDate2ndMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			labelDate2ndMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPath2ndMpcorbDatFileDatabaseValue
			// 
			labelPath2ndMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the path of the second MPCORB.DAT file";
			labelPath2ndMpcorbDatFileDatabaseValue.AccessibleName = "Path of the second MPCORB.DAT file";
			labelPath2ndMpcorbDatFileDatabaseValue.AccessibleRole = AccessibleRole.StaticText;
			labelPath2ndMpcorbDatFileDatabaseValue.Dock = DockStyle.Fill;
			labelPath2ndMpcorbDatFileDatabaseValue.Location = new Point(50, 38);
			labelPath2ndMpcorbDatFileDatabaseValue.Margin = new Padding(4, 3, 4, 3);
			labelPath2ndMpcorbDatFileDatabaseValue.Name = "labelPath2ndMpcorbDatFileDatabaseValue";
			labelPath2ndMpcorbDatFileDatabaseValue.Size = new Size(417, 20);
			labelPath2ndMpcorbDatFileDatabaseValue.TabIndex = 15;
			toolTip.SetToolTip(labelPath2ndMpcorbDatFileDatabaseValue, "Path of the second MPCORB.DAT file");
			labelPath2ndMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			labelPath2ndMpcorbDatFileDatabaseValue.Values.Text = "C:\\This-can-be-a\\very-very-long\\path\\to-the-file\\MPCORB.DAT";
			labelPath2ndMpcorbDatFileDatabaseValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelPath2ndMpcorbDatFileDatabaseValue.Enter += SetStatusbar_Enter;
			labelPath2ndMpcorbDatFileDatabaseValue.Leave += ClearStatusbar_Leave;
			labelPath2ndMpcorbDatFileDatabaseValue.MouseEnter += SetStatusbar_Enter;
			labelPath2ndMpcorbDatFileDatabaseValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSize2ndMpcorbDatFileDatabase
			// 
			labelSize2ndMpcorbDatFileDatabase.AccessibleDescription = "Header of the size";
			labelSize2ndMpcorbDatFileDatabase.AccessibleName = "Header of the size";
			labelSize2ndMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.StaticText;
			labelSize2ndMpcorbDatFileDatabase.Dock = DockStyle.Fill;
			labelSize2ndMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelSize2ndMpcorbDatFileDatabase.Location = new Point(4, 90);
			labelSize2ndMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			labelSize2ndMpcorbDatFileDatabase.Name = "labelSize2ndMpcorbDatFileDatabase";
			labelSize2ndMpcorbDatFileDatabase.Size = new Size(38, 41);
			labelSize2ndMpcorbDatFileDatabase.TabIndex = 12;
			toolTip.SetToolTip(labelSize2ndMpcorbDatFileDatabase, "Size");
			labelSize2ndMpcorbDatFileDatabase.UseWaitCursor = true;
			labelSize2ndMpcorbDatFileDatabase.Values.Text = "Size";
			labelSize2ndMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			labelSize2ndMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			labelSize2ndMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			labelSize2ndMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// groupBox1stMpcorbDatFileDatabase
			// 
			groupBox1stMpcorbDatFileDatabase.AccessibleDescription = "Groups the data";
			groupBox1stMpcorbDatFileDatabase.AccessibleName = "Group box for the first file";
			groupBox1stMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.Grouping;
			groupBox1stMpcorbDatFileDatabase.Location = new Point(14, 14);
			groupBox1stMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			groupBox1stMpcorbDatFileDatabase.Name = "groupBox1stMpcorbDatFileDatabase";
			// 
			// 
			// 
			groupBox1stMpcorbDatFileDatabase.Panel.AccessibleDescription = "Groups the data";
			groupBox1stMpcorbDatFileDatabase.Panel.AccessibleName = "Panel";
			groupBox1stMpcorbDatFileDatabase.Panel.AccessibleRole = AccessibleRole.Pane;
			groupBox1stMpcorbDatFileDatabase.Panel.Controls.Add(tableLayoutPanel1stMpcorbDatFile);
			groupBox1stMpcorbDatFileDatabase.Panel.UseWaitCursor = true;
			groupBox1stMpcorbDatFileDatabase.Panel.Enter += SetStatusbar_Enter;
			groupBox1stMpcorbDatFileDatabase.Panel.Leave += ClearStatusbar_Leave;
			groupBox1stMpcorbDatFileDatabase.Panel.MouseEnter += SetStatusbar_Enter;
			groupBox1stMpcorbDatFileDatabase.Panel.MouseLeave += ClearStatusbar_Leave;
			groupBox1stMpcorbDatFileDatabase.Size = new Size(475, 158);
			groupBox1stMpcorbDatFileDatabase.TabIndex = 15;
			toolTip.SetToolTip(groupBox1stMpcorbDatFileDatabase, "Open the 1st MPCORB.DAT file");
			groupBox1stMpcorbDatFileDatabase.UseWaitCursor = true;
			groupBox1stMpcorbDatFileDatabase.Values.Heading = "The first MPCORB.DAT file";
			groupBox1stMpcorbDatFileDatabase.Values.Image = Properties.Resources.silk_database;
			groupBox1stMpcorbDatFileDatabase.DragDrop += GroupBox1stMpcorbDatFileDatabase_DragDrop;
			groupBox1stMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			groupBox1stMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			groupBox1stMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			groupBox1stMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// tableLayoutPanel1stMpcorbDatFile
			// 
			tableLayoutPanel1stMpcorbDatFile.AccessibleDescription = "Groups the data";
			tableLayoutPanel1stMpcorbDatFile.AccessibleName = "Panel";
			tableLayoutPanel1stMpcorbDatFile.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel1stMpcorbDatFile.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1stMpcorbDatFile.BackgroundImage");
			tableLayoutPanel1stMpcorbDatFile.BackgroundImageLayout = ImageLayout.None;
			tableLayoutPanel1stMpcorbDatFile.ColumnCount = 2;
			tableLayoutPanel1stMpcorbDatFile.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1stMpcorbDatFile.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1stMpcorbDatFile.Controls.Add(labelSize1stMpcorbDatFileDatabaseValue, 1, 3);
			tableLayoutPanel1stMpcorbDatFile.Controls.Add(labelPath1stMpcorbDatFileDatabase, 0, 1);
			tableLayoutPanel1stMpcorbDatFile.Controls.Add(buttonOpen1stMpcorbDatFileDatabase, 0, 0);
			tableLayoutPanel1stMpcorbDatFile.Controls.Add(labelDate1stMpcorbDatFileDatabaseValue, 1, 2);
			tableLayoutPanel1stMpcorbDatFile.Controls.Add(labelDate1stMpcorbDatFileDatabase, 0, 2);
			tableLayoutPanel1stMpcorbDatFile.Controls.Add(labelPath1stMpcorbDatFileDatabaseValue, 1, 1);
			tableLayoutPanel1stMpcorbDatFile.Controls.Add(labelSize1stMpcorbDatFileDatabase, 0, 3);
			tableLayoutPanel1stMpcorbDatFile.Dock = DockStyle.Fill;
			tableLayoutPanel1stMpcorbDatFile.Location = new Point(0, 0);
			tableLayoutPanel1stMpcorbDatFile.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanel1stMpcorbDatFile.Name = "tableLayoutPanel1stMpcorbDatFile";
			tableLayoutPanel1stMpcorbDatFile.RowCount = 4;
			tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new RowStyle());
			tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new RowStyle());
			tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new RowStyle());
			tableLayoutPanel1stMpcorbDatFile.RowStyles.Add(new RowStyle());
			tableLayoutPanel1stMpcorbDatFile.Size = new Size(471, 134);
			tableLayoutPanel1stMpcorbDatFile.TabIndex = 13;
			toolTip.SetToolTip(tableLayoutPanel1stMpcorbDatFile, "Groups the data");
			tableLayoutPanel1stMpcorbDatFile.UseWaitCursor = true;
			tableLayoutPanel1stMpcorbDatFile.Enter += ClearStatusbar_Leave;
			tableLayoutPanel1stMpcorbDatFile.Leave += ClearStatusbar_Leave;
			tableLayoutPanel1stMpcorbDatFile.MouseEnter += SetStatusbar_Enter;
			tableLayoutPanel1stMpcorbDatFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSize1stMpcorbDatFileDatabaseValue
			// 
			labelSize1stMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the file size of the first MPCORB.DAT file";
			labelSize1stMpcorbDatFileDatabaseValue.AccessibleName = "File size of the first MPCORB.DAT file";
			labelSize1stMpcorbDatFileDatabaseValue.AccessibleRole = AccessibleRole.StaticText;
			labelSize1stMpcorbDatFileDatabaseValue.Dock = DockStyle.Fill;
			labelSize1stMpcorbDatFileDatabaseValue.Location = new Point(50, 90);
			labelSize1stMpcorbDatFileDatabaseValue.Margin = new Padding(4, 3, 4, 3);
			labelSize1stMpcorbDatFileDatabaseValue.Name = "labelSize1stMpcorbDatFileDatabaseValue";
			labelSize1stMpcorbDatFileDatabaseValue.Size = new Size(417, 41);
			labelSize1stMpcorbDatFileDatabaseValue.TabIndex = 17;
			toolTip.SetToolTip(labelSize1stMpcorbDatFileDatabaseValue, "File size of the first MPCORB.DAT file");
			labelSize1stMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			labelSize1stMpcorbDatFileDatabaseValue.Values.Text = "1234567890 bytes";
			labelSize1stMpcorbDatFileDatabaseValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelSize1stMpcorbDatFileDatabaseValue.Enter += SetStatusbar_Enter;
			labelSize1stMpcorbDatFileDatabaseValue.Leave += ClearStatusbar_Leave;
			labelSize1stMpcorbDatFileDatabaseValue.MouseEnter += SetStatusbar_Enter;
			labelSize1stMpcorbDatFileDatabaseValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPath1stMpcorbDatFileDatabase
			// 
			labelPath1stMpcorbDatFileDatabase.AccessibleDescription = "Header of the path";
			labelPath1stMpcorbDatFileDatabase.AccessibleName = "Header of the path";
			labelPath1stMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.StaticText;
			labelPath1stMpcorbDatFileDatabase.Dock = DockStyle.Fill;
			labelPath1stMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelPath1stMpcorbDatFileDatabase.Location = new Point(4, 38);
			labelPath1stMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			labelPath1stMpcorbDatFileDatabase.Name = "labelPath1stMpcorbDatFileDatabase";
			labelPath1stMpcorbDatFileDatabase.Size = new Size(38, 20);
			labelPath1stMpcorbDatFileDatabase.TabIndex = 10;
			toolTip.SetToolTip(labelPath1stMpcorbDatFileDatabase, "Path");
			labelPath1stMpcorbDatFileDatabase.UseWaitCursor = true;
			labelPath1stMpcorbDatFileDatabase.Values.Text = "Path";
			labelPath1stMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			labelPath1stMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			labelPath1stMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			labelPath1stMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonOpen1stMpcorbDatFileDatabase
			// 
			buttonOpen1stMpcorbDatFileDatabase.AccessibleDescription = "Opens the first MPRCORB.DAT file";
			buttonOpen1stMpcorbDatFileDatabase.AccessibleName = "Open the first MPRCORB.DAT file";
			buttonOpen1stMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.PushButton;
			tableLayoutPanel1stMpcorbDatFile.SetColumnSpan(buttonOpen1stMpcorbDatFileDatabase, 2);
			buttonOpen1stMpcorbDatFileDatabase.Location = new Point(4, 3);
			buttonOpen1stMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			buttonOpen1stMpcorbDatFileDatabase.Name = "buttonOpen1stMpcorbDatFileDatabase";
			buttonOpen1stMpcorbDatFileDatabase.Size = new Size(215, 29);
			buttonOpen1stMpcorbDatFileDatabase.TabIndex = 9;
			toolTip.SetToolTip(buttonOpen1stMpcorbDatFileDatabase, "Open 1st MPRCORB.DAT file");
			buttonOpen1stMpcorbDatFileDatabase.UseWaitCursor = true;
			buttonOpen1stMpcorbDatFileDatabase.Values.DropDownArrowColor = Color.Empty;
			buttonOpen1stMpcorbDatFileDatabase.Values.Image = Properties.Resources.silk_folder;
			buttonOpen1stMpcorbDatFileDatabase.Values.Text = "Open &1st MPRCORB.DAT file";
			buttonOpen1stMpcorbDatFileDatabase.Click += ButtonOpen1stMpcorbDatFileDatabase_Click;
			buttonOpen1stMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			buttonOpen1stMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			buttonOpen1stMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			buttonOpen1stMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDate1stMpcorbDatFileDatabaseValue
			// 
			labelDate1stMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the date of the first MPCORB.DAT file";
			labelDate1stMpcorbDatFileDatabaseValue.AccessibleName = "Date of the first MPCORB.DAT file";
			labelDate1stMpcorbDatFileDatabaseValue.AccessibleRole = AccessibleRole.StaticText;
			labelDate1stMpcorbDatFileDatabaseValue.Dock = DockStyle.Fill;
			labelDate1stMpcorbDatFileDatabaseValue.Location = new Point(50, 64);
			labelDate1stMpcorbDatFileDatabaseValue.Margin = new Padding(4, 3, 4, 3);
			labelDate1stMpcorbDatFileDatabaseValue.Name = "labelDate1stMpcorbDatFileDatabaseValue";
			labelDate1stMpcorbDatFileDatabaseValue.Size = new Size(417, 20);
			labelDate1stMpcorbDatFileDatabaseValue.TabIndex = 16;
			toolTip.SetToolTip(labelDate1stMpcorbDatFileDatabaseValue, "Date of the first MPCORB.DAT file");
			labelDate1stMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			labelDate1stMpcorbDatFileDatabaseValue.Values.Text = "00.00.0000 00:00:00";
			labelDate1stMpcorbDatFileDatabaseValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelDate1stMpcorbDatFileDatabaseValue.Enter += SetStatusbar_Enter;
			labelDate1stMpcorbDatFileDatabaseValue.Leave += ClearStatusbar_Leave;
			labelDate1stMpcorbDatFileDatabaseValue.MouseEnter += SetStatusbar_Enter;
			labelDate1stMpcorbDatFileDatabaseValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDate1stMpcorbDatFileDatabase
			// 
			labelDate1stMpcorbDatFileDatabase.AccessibleDescription = "Header of the date";
			labelDate1stMpcorbDatFileDatabase.AccessibleName = "Header of the date";
			labelDate1stMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.StaticText;
			labelDate1stMpcorbDatFileDatabase.Dock = DockStyle.Fill;
			labelDate1stMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelDate1stMpcorbDatFileDatabase.Location = new Point(4, 64);
			labelDate1stMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			labelDate1stMpcorbDatFileDatabase.Name = "labelDate1stMpcorbDatFileDatabase";
			labelDate1stMpcorbDatFileDatabase.Size = new Size(38, 20);
			labelDate1stMpcorbDatFileDatabase.TabIndex = 11;
			toolTip.SetToolTip(labelDate1stMpcorbDatFileDatabase, "Date");
			labelDate1stMpcorbDatFileDatabase.UseWaitCursor = true;
			labelDate1stMpcorbDatFileDatabase.Values.Text = "Date";
			labelDate1stMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			labelDate1stMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			labelDate1stMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			labelDate1stMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPath1stMpcorbDatFileDatabaseValue
			// 
			labelPath1stMpcorbDatFileDatabaseValue.AccessibleDescription = "Shows the path of the first MPCORB.DAT file";
			labelPath1stMpcorbDatFileDatabaseValue.AccessibleName = "Path of the first MPCORB.DAT file";
			labelPath1stMpcorbDatFileDatabaseValue.AccessibleRole = AccessibleRole.StaticText;
			labelPath1stMpcorbDatFileDatabaseValue.Dock = DockStyle.Fill;
			labelPath1stMpcorbDatFileDatabaseValue.Location = new Point(50, 38);
			labelPath1stMpcorbDatFileDatabaseValue.Margin = new Padding(4, 3, 4, 3);
			labelPath1stMpcorbDatFileDatabaseValue.Name = "labelPath1stMpcorbDatFileDatabaseValue";
			labelPath1stMpcorbDatFileDatabaseValue.Size = new Size(417, 20);
			labelPath1stMpcorbDatFileDatabaseValue.TabIndex = 15;
			toolTip.SetToolTip(labelPath1stMpcorbDatFileDatabaseValue, "Path of the first MPCORB.DAT file");
			labelPath1stMpcorbDatFileDatabaseValue.UseWaitCursor = true;
			labelPath1stMpcorbDatFileDatabaseValue.Values.Text = "C:\\This-can-be-a\\very-very-long\\path\\to-the-file\\MPCORB.DAT";
			labelPath1stMpcorbDatFileDatabaseValue.DoubleClick += CopyToClipboard_DoubleClick;
			labelPath1stMpcorbDatFileDatabaseValue.Enter += SetStatusbar_Enter;
			labelPath1stMpcorbDatFileDatabaseValue.Leave += ClearStatusbar_Leave;
			labelPath1stMpcorbDatFileDatabaseValue.MouseEnter += SetStatusbar_Enter;
			labelPath1stMpcorbDatFileDatabaseValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSize1stMpcorbDatFileDatabase
			// 
			labelSize1stMpcorbDatFileDatabase.AccessibleDescription = "Header of the size";
			labelSize1stMpcorbDatFileDatabase.AccessibleName = "Header of the size";
			labelSize1stMpcorbDatFileDatabase.AccessibleRole = AccessibleRole.StaticText;
			labelSize1stMpcorbDatFileDatabase.Dock = DockStyle.Fill;
			labelSize1stMpcorbDatFileDatabase.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelSize1stMpcorbDatFileDatabase.Location = new Point(4, 90);
			labelSize1stMpcorbDatFileDatabase.Margin = new Padding(4, 3, 4, 3);
			labelSize1stMpcorbDatFileDatabase.Name = "labelSize1stMpcorbDatFileDatabase";
			labelSize1stMpcorbDatFileDatabase.Size = new Size(38, 41);
			labelSize1stMpcorbDatFileDatabase.TabIndex = 12;
			toolTip.SetToolTip(labelSize1stMpcorbDatFileDatabase, "Size");
			labelSize1stMpcorbDatFileDatabase.UseWaitCursor = true;
			labelSize1stMpcorbDatFileDatabase.Values.Text = "Size";
			labelSize1stMpcorbDatFileDatabase.Enter += SetStatusbar_Enter;
			labelSize1stMpcorbDatFileDatabase.Leave += ClearStatusbar_Leave;
			labelSize1stMpcorbDatFileDatabase.MouseEnter += SetStatusbar_Enter;
			labelSize1stMpcorbDatFileDatabase.MouseLeave += ClearStatusbar_Leave;
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			// 
			// openFileDialog1stMpcorbDatFileDatabase
			// 
			openFileDialog1stMpcorbDatFileDatabase.DefaultExt = "dat";
			openFileDialog1stMpcorbDatFileDatabase.Filter = "DAT files|*.dat|all files|*.*";
			// 
			// openFileDialog2ndMpcorbDatFileDatabase
			// 
			openFileDialog2ndMpcorbDatFileDatabase.DefaultExt = "dat";
			openFileDialog2ndMpcorbDatFileDatabase.Filter = "DAT files|*.dat|all files|*.*";
			// 
			// DatabaseDifferencesForm
			// 
			AccessibleDescription = "Compares two MPCORVB.DAT files";
			AccessibleName = "Database Differences";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(981, 545);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DatabaseDifferencesForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Database Differences";
			toolTip.SetToolTip(this, "Database Differences");
			UseWaitCursor = true;
			FormClosed += DatabaseDifferencesForm_FormClosed;
			Load += DatabaseDifferencesForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)groupBoxResults.Panel).EndInit();
			groupBoxResults.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)groupBoxResults).EndInit();
			((System.ComponentModel.ISupportInitialize)groupBoxProgress.Panel).EndInit();
			groupBoxProgress.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)groupBoxProgress).EndInit();
			((System.ComponentModel.ISupportInitialize)groupBox2ndMpcorbDatFileDatabase.Panel).EndInit();
			groupBox2ndMpcorbDatFileDatabase.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)groupBox2ndMpcorbDatFileDatabase).EndInit();
			kryptonTableLayoutPanel1.ResumeLayout(false);
			kryptonTableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)groupBox1stMpcorbDatFileDatabase.Panel).EndInit();
			groupBox1stMpcorbDatFileDatabase.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)groupBox1stMpcorbDatFileDatabase).EndInit();
			tableLayoutPanel1stMpcorbDatFile.ResumeLayout(false);
			tableLayoutPanel1stMpcorbDatFile.PerformLayout();
			ResumeLayout(false);

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