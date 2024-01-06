﻿namespace Planetoid_DB
{
	partial class ListReadableDesignationsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListReadableDesignationsForm));
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			backgroundWorker = new System.ComponentModel.BackgroundWorker();
			toolTip = new ToolTip(components);
			buttonCancel = new Krypton.Toolkit.KryptonButton();
			progressBar = new Krypton.Toolkit.KryptonProgressBar();
			buttonList = new Krypton.Toolkit.KryptonButton();
			labelWarning = new Label();
			buttonLoad = new Krypton.Toolkit.KryptonButton();
			labelMinimum = new Krypton.Toolkit.KryptonLabel();
			numericUpDownMinimum = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximum = new Krypton.Toolkit.KryptonNumericUpDown();
			labelMaximum = new Krypton.Toolkit.KryptonLabel();
			contextMenuStripSaveList = new ContextMenuStrip(components);
			toolStripMenuItemSaveAsCsv = new ToolStripMenuItem();
			toolStripMenuItemSaveAsHtml = new ToolStripMenuItem();
			toolStripMenuItemSaveAsXml = new ToolStripMenuItem();
			toolStripMenuItemSaveAsJson = new ToolStripMenuItem();
			dropButtonSaveList = new Krypton.Toolkit.KryptonDropButton();
			panel = new Krypton.Toolkit.KryptonPanel();
			listView = new ListView();
			columnHeaderIndex = new ColumnHeader();
			columnHeaderReadableDesignation = new ColumnHeader();
			saveFileDialogCsv = new SaveFileDialog();
			saveFileDialogJson = new SaveFileDialog();
			saveFileDialogHtml = new SaveFileDialog();
			saveFileDialogXml = new SaveFileDialog();
			statusStrip.SuspendLayout();
			contextMenuStripSaveList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 393);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(312, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 1;
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
			labelInformation.ToolTipText = "Shows some information";
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			// 
			// buttonCancel
			// 
			buttonCancel.AccessibleDescription = "Cancels the progress";
			buttonCancel.AccessibleName = "Cancel";
			buttonCancel.AccessibleRole = AccessibleRole.PushButton;
			buttonCancel.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Location = new Point(70, 38);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(69, 31);
			buttonCancel.TabIndex = 5;
			toolTip.SetToolTip(buttonCancel, "Cancel the progress");
			buttonCancel.Values.Image = Properties.Resources.silk_cancel;
			buttonCancel.Values.Text = "&Cancel";
			buttonCancel.Click += ButtonCancel_Click;
			buttonCancel.Enter += SetStatusbar_Enter;
			buttonCancel.Leave += ClearStatusbar_Leave;
			buttonCancel.MouseEnter += SetStatusbar_Enter;
			buttonCancel.MouseLeave += ClearStatusbar_Leave;
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Shows the progress";
			progressBar.AccessibleName = "Progress";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Location = new Point(12, 75);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(288, 19);
			progressBar.Step = 1;
			progressBar.TabIndex = 8;
			toolTip.SetToolTip(progressBar, "Shows the progress");
			progressBar.Values.Text = "";
			progressBar.MouseEnter += SetStatusbar_Enter;
			progressBar.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonList
			// 
			buttonList.AccessibleDescription = "Starts the progress and list";
			buttonList.AccessibleName = "List";
			buttonList.AccessibleRole = AccessibleRole.PushButton;
			buttonList.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			buttonList.Location = new Point(12, 38);
			buttonList.Name = "buttonList";
			buttonList.Size = new Size(52, 31);
			buttonList.TabIndex = 4;
			toolTip.SetToolTip(buttonList, "Start the progress and list");
			buttonList.Values.Image = Properties.Resources.silk_page_white_text;
			buttonList.Values.Text = "&List";
			buttonList.Click += ButtonList_Click;
			buttonList.Enter += SetStatusbar_Enter;
			buttonList.Leave += ClearStatusbar_Leave;
			buttonList.MouseEnter += SetStatusbar_Enter;
			buttonList.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelWarning
			// 
			labelWarning.AccessibleDescription = "Warning message: Be careful: do not use large ranges between minimum and maximum! This can increase loading time and memory. Use small spans!";
			labelWarning.AccessibleName = "Warning message";
			labelWarning.AccessibleRole = AccessibleRole.Text;
			labelWarning.BackColor = Color.SeaShell;
			labelWarning.BorderStyle = BorderStyle.Fixed3D;
			labelWarning.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
			labelWarning.Location = new Point(12, 97);
			labelWarning.Name = "labelWarning";
			labelWarning.Size = new Size(288, 35);
			labelWarning.TabIndex = 9;
			labelWarning.Text = "Be careful: This can increase loading time and memory. You can cancel any time.";
			labelWarning.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelWarning, "Be careful: do not use large ranges between minimum and maximum! This can increase loading time and memory. Use small spans!");
			labelWarning.Click += CopyToClipboard_DoubleClick;
			labelWarning.Enter += SetStatusbar_Enter;
			labelWarning.Leave += ClearStatusbar_Leave;
			labelWarning.MouseEnter += SetStatusbar_Enter;
			labelWarning.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonLoad
			// 
			buttonLoad.AccessibleDescription = "Load the selected planetoid";
			buttonLoad.AccessibleName = "Load";
			buttonLoad.AccessibleRole = AccessibleRole.PushButton;
			buttonLoad.DialogResult = DialogResult.OK;
			buttonLoad.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			buttonLoad.Location = new Point(145, 38);
			buttonLoad.Name = "buttonLoad";
			buttonLoad.Size = new Size(56, 31);
			buttonLoad.TabIndex = 6;
			toolTip.SetToolTip(buttonLoad, "Load the selected planetoid");
			buttonLoad.Values.Image = Properties.Resources.silk_go;
			buttonLoad.Values.Text = "L&oad";
			buttonLoad.Enter += SetStatusbar_Enter;
			buttonLoad.Leave += ClearStatusbar_Leave;
			buttonLoad.MouseEnter += SetStatusbar_Enter;
			buttonLoad.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMinimum
			// 
			labelMinimum.AccessibleDescription = "Shows the minimum";
			labelMinimum.AccessibleName = "Minimum";
			labelMinimum.AccessibleRole = AccessibleRole.Text;
			labelMinimum.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			labelMinimum.Location = new Point(12, 12);
			labelMinimum.Name = "labelMinimum";
			labelMinimum.Size = new Size(66, 20);
			labelMinimum.TabIndex = 0;
			toolTip.SetToolTip(labelMinimum, "Minimum");
			labelMinimum.Values.Text = "M&inimum:";
			labelMinimum.Click += CopyToClipboard_DoubleClick;
			labelMinimum.Enter += SetStatusbar_Enter;
			labelMinimum.Leave += ClearStatusbar_Leave;
			labelMinimum.MouseEnter += SetStatusbar_Enter;
			labelMinimum.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimum
			// 
			numericUpDownMinimum.AccessibleDescription = "Shows the minimum value";
			numericUpDownMinimum.AccessibleName = "Minimum value";
			numericUpDownMinimum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimum.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			numericUpDownMinimum.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimum.Location = new Point(84, 10);
			numericUpDownMinimum.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimum.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimum.Name = "numericUpDownMinimum";
			numericUpDownMinimum.Size = new Size(64, 22);
			numericUpDownMinimum.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			numericUpDownMinimum.TabIndex = 1;
			toolTip.SetToolTip(numericUpDownMinimum, "Minimum value for the list");
			numericUpDownMinimum.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimum.Enter += SetStatusbar_Enter;
			numericUpDownMinimum.Leave += ClearStatusbar_Leave;
			numericUpDownMinimum.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimum.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximum
			// 
			numericUpDownMaximum.AccessibleDescription = "Shows the maximum value";
			numericUpDownMaximum.AccessibleName = "Maximum value";
			numericUpDownMaximum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximum.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			numericUpDownMaximum.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximum.Location = new Point(226, 10);
			numericUpDownMaximum.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximum.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximum.Name = "numericUpDownMaximum";
			numericUpDownMaximum.Size = new Size(64, 22);
			numericUpDownMaximum.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			numericUpDownMaximum.TabIndex = 3;
			toolTip.SetToolTip(numericUpDownMaximum, "Maximum value for the list");
			numericUpDownMaximum.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximum.Enter += SetStatusbar_Enter;
			numericUpDownMaximum.Leave += ClearStatusbar_Leave;
			numericUpDownMaximum.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximum.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMaximum
			// 
			labelMaximum.AccessibleDescription = "Shows the maximum";
			labelMaximum.AccessibleName = "Maximum";
			labelMaximum.AccessibleRole = AccessibleRole.Text;
			labelMaximum.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			labelMaximum.Location = new Point(154, 12);
			labelMaximum.Name = "labelMaximum";
			labelMaximum.Size = new Size(68, 20);
			labelMaximum.TabIndex = 2;
			toolTip.SetToolTip(labelMaximum, "Maximum");
			labelMaximum.Values.Text = "M&aximum:";
			labelMaximum.Click += CopyToClipboard_DoubleClick;
			labelMaximum.Enter += SetStatusbar_Enter;
			labelMaximum.Leave += ClearStatusbar_Leave;
			labelMaximum.MouseEnter += SetStatusbar_Enter;
			labelMaximum.MouseLeave += ClearStatusbar_Leave;
			// 
			// contextMenuStripSaveList
			// 
			contextMenuStripSaveList.AccessibleDescription = "Save the list as file";
			contextMenuStripSaveList.AccessibleName = "Save list";
			contextMenuStripSaveList.AccessibleRole = AccessibleRole.MenuPopup;
			contextMenuStripSaveList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			contextMenuStripSaveList.Items.AddRange(new ToolStripItem[] { toolStripMenuItemSaveAsCsv, toolStripMenuItemSaveAsHtml, toolStripMenuItemSaveAsXml, toolStripMenuItemSaveAsJson });
			contextMenuStripSaveList.Name = "contextMenuStrip1";
			contextMenuStripSaveList.Size = new Size(148, 92);
			contextMenuStripSaveList.TabStop = true;
			contextMenuStripSaveList.Text = "&Save List";
			toolTip.SetToolTip(contextMenuStripSaveList, "Save List");
			contextMenuStripSaveList.MouseEnter += SetStatusbar_Enter;
			contextMenuStripSaveList.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemSaveAsCsv
			// 
			toolStripMenuItemSaveAsCsv.AccessibleDescription = "Save the list as CSV file";
			toolStripMenuItemSaveAsCsv.AccessibleName = "Save as CSV";
			toolStripMenuItemSaveAsCsv.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemSaveAsCsv.AutoToolTip = true;
			toolStripMenuItemSaveAsCsv.Image = Properties.Resources.silk_page_white_text;
			toolStripMenuItemSaveAsCsv.Name = "toolStripMenuItemSaveAsCsv";
			toolStripMenuItemSaveAsCsv.Size = new Size(147, 22);
			toolStripMenuItemSaveAsCsv.Text = "Save as &CSV";
			toolStripMenuItemSaveAsCsv.Click += ToolStripMenuItemSaveAsCsv_Click;
			toolStripMenuItemSaveAsCsv.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemSaveAsCsv.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemSaveAsHtml
			// 
			toolStripMenuItemSaveAsHtml.AccessibleDescription = "Save the list as HTML file";
			toolStripMenuItemSaveAsHtml.AccessibleName = "Save as HTML";
			toolStripMenuItemSaveAsHtml.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemSaveAsHtml.AutoToolTip = true;
			toolStripMenuItemSaveAsHtml.Image = Properties.Resources.silk_page_white_code;
			toolStripMenuItemSaveAsHtml.Name = "toolStripMenuItemSaveAsHtml";
			toolStripMenuItemSaveAsHtml.Size = new Size(147, 22);
			toolStripMenuItemSaveAsHtml.Text = "Save as &HTML";
			toolStripMenuItemSaveAsHtml.Click += ToolStripMenuItemSaveAsHtml_Click;
			toolStripMenuItemSaveAsHtml.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemSaveAsHtml.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemSaveAsXml
			// 
			toolStripMenuItemSaveAsXml.AccessibleDescription = "Save the list as XML file";
			toolStripMenuItemSaveAsXml.AccessibleName = "Save as XML";
			toolStripMenuItemSaveAsXml.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemSaveAsXml.AutoToolTip = true;
			toolStripMenuItemSaveAsXml.Image = Properties.Resources.silk_page_white_code;
			toolStripMenuItemSaveAsXml.Name = "toolStripMenuItemSaveAsXml";
			toolStripMenuItemSaveAsXml.Size = new Size(147, 22);
			toolStripMenuItemSaveAsXml.Text = "Save as &XML";
			toolStripMenuItemSaveAsXml.Click += ToolStripMenuItemSaveAsXml_Click;
			toolStripMenuItemSaveAsXml.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemSaveAsXml.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemSaveAsJson
			// 
			toolStripMenuItemSaveAsJson.AccessibleDescription = "Save the list as JSON file";
			toolStripMenuItemSaveAsJson.AccessibleName = "Save as JSON";
			toolStripMenuItemSaveAsJson.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemSaveAsJson.AutoToolTip = true;
			toolStripMenuItemSaveAsJson.Image = Properties.Resources.silk_page_white_code;
			toolStripMenuItemSaveAsJson.Name = "toolStripMenuItemSaveAsJson";
			toolStripMenuItemSaveAsJson.Size = new Size(147, 22);
			toolStripMenuItemSaveAsJson.Text = "Save as &JSON";
			toolStripMenuItemSaveAsJson.Click += ToolStripMenuItemSaveAsJson_Click;
			toolStripMenuItemSaveAsJson.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemSaveAsJson.MouseLeave += ClearStatusbar_Leave;
			// 
			// dropButtonSaveList
			// 
			dropButtonSaveList.AccessibleDescription = "Saves the list as file";
			dropButtonSaveList.AccessibleName = "Save list";
			dropButtonSaveList.AccessibleRole = AccessibleRole.ButtonDropDown;
			dropButtonSaveList.ContextMenuStrip = contextMenuStripSaveList;
			dropButtonSaveList.Location = new Point(207, 38);
			dropButtonSaveList.Name = "dropButtonSaveList";
			dropButtonSaveList.Size = new Size(93, 31);
			dropButtonSaveList.Splitter = false;
			dropButtonSaveList.TabIndex = 7;
			toolTip.SetToolTip(dropButtonSaveList, "Save List");
			dropButtonSaveList.Values.ImageStates.ImageCheckedNormal = null;
			dropButtonSaveList.Values.ImageStates.ImageCheckedPressed = null;
			dropButtonSaveList.Values.ImageStates.ImageCheckedTracking = null;
			dropButtonSaveList.Values.ImageStates.ImageDisabled = Properties.Resources.silk_disk;
			dropButtonSaveList.Values.ImageStates.ImageNormal = Properties.Resources.silk_disk;
			dropButtonSaveList.Values.ImageStates.ImagePressed = Properties.Resources.silk_disk;
			dropButtonSaveList.Values.ImageStates.ImageTracking = Properties.Resources.silk_disk;
			dropButtonSaveList.Values.Text = "&Save List";
			dropButtonSaveList.Enter += SetStatusbar_Enter;
			dropButtonSaveList.Leave += ClearStatusbar_Leave;
			dropButtonSaveList.MouseEnter += SetStatusbar_Enter;
			dropButtonSaveList.MouseLeave += ClearStatusbar_Leave;
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(dropButtonSaveList);
			panel.Controls.Add(labelMinimum);
			panel.Controls.Add(numericUpDownMinimum);
			panel.Controls.Add(numericUpDownMaximum);
			panel.Controls.Add(labelMaximum);
			panel.Controls.Add(buttonLoad);
			panel.Controls.Add(labelWarning);
			panel.Controls.Add(buttonCancel);
			panel.Controls.Add(listView);
			panel.Controls.Add(progressBar);
			panel.Controls.Add(buttonList);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			panel.Size = new Size(312, 393);
			panel.TabIndex = 0;
			panel.TabStop = true;
			// 
			// listView
			// 
			listView.AccessibleDescription = "Shows the list with the items";
			listView.AccessibleName = "List";
			listView.AccessibleRole = AccessibleRole.ListItem;
			listView.Activation = ItemActivation.OneClick;
			listView.AllowColumnReorder = true;
			listView.Columns.AddRange(new ColumnHeader[] { columnHeaderIndex, columnHeaderReadableDesignation });
			listView.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.Location = new Point(12, 135);
			listView.MultiSelect = false;
			listView.Name = "listView";
			listView.ShowItemToolTips = true;
			listView.Size = new Size(288, 255);
			listView.TabIndex = 10;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = View.Details;
			listView.SelectedIndexChanged += SelectedIndexChanged;
			listView.Enter += SetStatusbar_Enter;
			listView.Leave += ClearStatusbar_Leave;
			listView.MouseEnter += SetStatusbar_Enter;
			listView.MouseLeave += ClearStatusbar_Leave;
			// 
			// columnHeaderIndex
			// 
			columnHeaderIndex.Text = "Index No.";
			columnHeaderIndex.Width = 80;
			// 
			// columnHeaderReadableDesignation
			// 
			columnHeaderReadableDesignation.Text = "Readable designation";
			columnHeaderReadableDesignation.Width = 180;
			// 
			// saveFileDialogCsv
			// 
			saveFileDialogCsv.DefaultExt = "csv";
			saveFileDialogCsv.Filter = "CSV files|*.csv|all files|*.*";
			// 
			// saveFileDialogJson
			// 
			saveFileDialogJson.DefaultExt = "json";
			saveFileDialogJson.Filter = "JSON files|*.json|all files|*.*";
			// 
			// saveFileDialogHtml
			// 
			saveFileDialogHtml.DefaultExt = "html";
			saveFileDialogHtml.Filter = "HTML files|*.html|all files|*.*";
			// 
			// saveFileDialogXml
			// 
			saveFileDialogXml.DefaultExt = "xml";
			saveFileDialogXml.Filter = "XML files|*.xml|all files|*.*";
			// 
			// ListReadableDesignationsForm
			// 
			AccessibleDescription = "List readable designations";
			AccessibleName = "List of readable designations";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(312, 415);
			Controls.Add(panel);
			Controls.Add(statusStrip);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ListReadableDesignationsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "List of readable designations";
			toolTip.SetToolTip(this, "List of readable designations ");
			FormClosed += ListReadableDesignationsForm_FormClosed;
			Load += ListReadableDesignationsForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			contextMenuStripSaveList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private ToolTip toolTip;
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonButton buttonCancel;
		private ListView listView;
		private ColumnHeader columnHeaderIndex;
		private ColumnHeader columnHeaderReadableDesignation;
		private Krypton.Toolkit.KryptonProgressBar progressBar;
		private Krypton.Toolkit.KryptonButton buttonList;
		private Label labelWarning;
		private Krypton.Toolkit.KryptonButton buttonLoad;
		private Krypton.Toolkit.KryptonLabel labelMinimum;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimum;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximum;
		private Krypton.Toolkit.KryptonLabel labelMaximum;
		private Krypton.Toolkit.KryptonDropButton dropButtonSaveList;
		private ContextMenuStrip contextMenuStripSaveList;
		private ToolStripMenuItem toolStripMenuItemSaveAsCsv;
		private ToolStripMenuItem toolStripMenuItemSaveAsHtml;
		private ToolStripMenuItem toolStripMenuItemSaveAsXml;
		private ToolStripMenuItem toolStripMenuItemSaveAsJson;
		private SaveFileDialog saveFileDialogCsv;
		private SaveFileDialog saveFileDialogJson;
		private SaveFileDialog saveFileDialogHtml;
		private SaveFileDialog saveFileDialogXml;
	}
}