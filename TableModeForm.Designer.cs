﻿using Krypton.Toolkit;

namespace Planetoid_DB
{
  partial class TableModeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableModeForm));
			toolTip = new ToolTip(components);
			progressBar = new KryptonProgressBar();
			labelMinimum = new KryptonLabel();
			numericUpDownMinimum = new KryptonNumericUpDown();
			numericUpDownMaximum = new KryptonNumericUpDown();
			labelMaximum = new KryptonLabel();
			buttonList = new KryptonButton();
			labelWarning = new Label();
			buttonCancel = new KryptonButton();
			listView = new ListView();
			columnHeaderIndex = new ColumnHeader();
			columnHeaderReadableDesignation = new ColumnHeader();
			columnHeaderEpoch = new ColumnHeader();
			columnHeaderMeanAnomaly = new ColumnHeader();
			columnHeaderArgumentPerihelion = new ColumnHeader();
			columnHeaderLongitudeAscendingNode = new ColumnHeader();
			columnHeaderInclination = new ColumnHeader();
			columnHeaderOrbitalEccentricity = new ColumnHeader();
			columnHeaderMeanDailyMotion = new ColumnHeader();
			columnHeaderSemimajorAxis = new ColumnHeader();
			columnHeaderAbsoluteMagnitude = new ColumnHeader();
			columnHeaderSlopeParameter = new ColumnHeader();
			columnHeaderReference = new ColumnHeader();
			columnHeaderNumberOppositions = new ColumnHeader();
			columnHeaderNumberObservations = new ColumnHeader();
			columnHeaderObservationSpan = new ColumnHeader();
			columnHeaderRmsResidual = new ColumnHeader();
			columnHeaderComputerName = new ColumnHeader();
			columnHeaderFlags = new ColumnHeader();
			columnHeaderDateLastObservation = new ColumnHeader();
			backgroundWorker = new System.ComponentModel.BackgroundWorker();
			panel = new KryptonPanel();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Shows the progress";
			progressBar.AccessibleName = "Progress";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Location = new Point(13, 56);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(720, 19);
			progressBar.Step = 1;
			progressBar.TabIndex = 7;
			toolTip.SetToolTip(progressBar, "Shows the progress");
			progressBar.Values.Text = "";
			progressBar.MouseEnter += SetStatusbar_Enter;
			progressBar.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMinimum
			// 
			labelMinimum.AccessibleDescription = "Shows the minimum";
			labelMinimum.AccessibleName = "Minimum";
			labelMinimum.AccessibleRole = AccessibleRole.Text;
			labelMinimum.Font = new Font("Segoe UI", 8.5F);
			labelMinimum.Location = new Point(13, 21);
			labelMinimum.Name = "labelMinimum";
			labelMinimum.Size = new Size(66, 20);
			labelMinimum.TabIndex = 0;
			toolTip.SetToolTip(labelMinimum, "Minimum");
			labelMinimum.Values.Text = "M&inimum:";
			labelMinimum.DoubleClick += CopyToClipboard_DoubleClick;
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
			numericUpDownMinimum.Font = new Font("Segoe UI", 8.5F);
			numericUpDownMinimum.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimum.Location = new Point(82, 18);
			numericUpDownMinimum.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimum.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimum.Name = "numericUpDownMinimum";
			numericUpDownMinimum.Size = new Size(64, 22);
			numericUpDownMinimum.StateCommon.Content.TextH = PaletteRelativeAlign.Center;
			numericUpDownMinimum.TabIndex = 1;
			toolTip.SetToolTip(numericUpDownMinimum, "Minimum value for the list");
			numericUpDownMinimum.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimum.Enter += SetStatusbar_Enter;
			numericUpDownMinimum.Leave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximum
			// 
			numericUpDownMaximum.AccessibleDescription = "Shows the maximum value";
			numericUpDownMaximum.AccessibleName = "Maximum value";
			numericUpDownMaximum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximum.Font = new Font("Segoe UI", 8.5F);
			numericUpDownMaximum.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximum.Location = new Point(222, 18);
			numericUpDownMaximum.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximum.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximum.Name = "numericUpDownMaximum";
			numericUpDownMaximum.Size = new Size(64, 22);
			numericUpDownMaximum.StateCommon.Content.TextH = PaletteRelativeAlign.Center;
			numericUpDownMaximum.TabIndex = 3;
			toolTip.SetToolTip(numericUpDownMaximum, "Maximum value for the list");
			numericUpDownMaximum.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximum.Enter += SetStatusbar_Enter;
			numericUpDownMaximum.Leave += ClearStatusbar_Leave;
			// 
			// labelMaximum
			// 
			labelMaximum.AccessibleDescription = "Shows the maximum";
			labelMaximum.AccessibleName = "Maximum";
			labelMaximum.AccessibleRole = AccessibleRole.Text;
			labelMaximum.Font = new Font("Segoe UI", 8.5F);
			labelMaximum.Location = new Point(152, 21);
			labelMaximum.Name = "labelMaximum";
			labelMaximum.Size = new Size(68, 20);
			labelMaximum.TabIndex = 2;
			toolTip.SetToolTip(labelMaximum, "Maximum");
			labelMaximum.Values.Text = "M&aximum:";
			labelMaximum.DoubleClick += CopyToClipboard_DoubleClick;
			labelMaximum.Enter += SetStatusbar_Enter;
			labelMaximum.Leave += ClearStatusbar_Leave;
			labelMaximum.MouseEnter += SetStatusbar_Enter;
			labelMaximum.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonList
			// 
			buttonList.AccessibleDescription = "Starts the progress and list";
			buttonList.AccessibleName = "List";
			buttonList.AccessibleRole = AccessibleRole.PushButton;
			buttonList.Font = new Font("Segoe UI", 8.5F);
			buttonList.Location = new Point(292, 14);
			buttonList.Name = "buttonList";
			buttonList.Size = new Size(52, 31);
			buttonList.TabIndex = 4;
			toolTip.SetToolTip(buttonList, "Start the progress and list");
			buttonList.Values.DropDownArrowColor = Color.Empty;
			buttonList.Values.Image = Properties.Resources.silk_table;
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
			labelWarning.Font = new Font("Segoe UI", 7F);
			labelWarning.Location = new Point(425, 14);
			labelWarning.Name = "labelWarning";
			labelWarning.Size = new Size(308, 39);
			labelWarning.TabIndex = 6;
			labelWarning.Text = "Be careful: Do not use large ranges between minimum and maximum! This can increase loading time and memory. Use small ranges! You can cancel any time.";
			labelWarning.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelWarning, "Be careful: do not use large ranges between minimum and maximum! This can increase loading time and memory. Use small spans!");
			labelWarning.DoubleClick += CopyToClipboard_DoubleClick;
			labelWarning.Enter += SetStatusbar_Enter;
			labelWarning.Leave += ClearStatusbar_Leave;
			labelWarning.MouseEnter += SetStatusbar_Enter;
			labelWarning.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCancel
			// 
			buttonCancel.AccessibleDescription = "Cancels the progress";
			buttonCancel.AccessibleName = "Cancel";
			buttonCancel.AccessibleRole = AccessibleRole.PushButton;
			buttonCancel.Font = new Font("Segoe UI", 8.5F);
			buttonCancel.Location = new Point(350, 14);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(69, 31);
			buttonCancel.TabIndex = 5;
			toolTip.SetToolTip(buttonCancel, "Cancel the progress");
			buttonCancel.Values.DropDownArrowColor = Color.Empty;
			buttonCancel.Values.Image = Properties.Resources.silk_cancel;
			buttonCancel.Values.Text = "&Cancel";
			buttonCancel.Click += ButtonCancel_Click;
			buttonCancel.Enter += SetStatusbar_Enter;
			buttonCancel.Leave += ClearStatusbar_Leave;
			buttonCancel.MouseEnter += SetStatusbar_Enter;
			buttonCancel.MouseLeave += ClearStatusbar_Leave;
			// 
			// listView
			// 
			listView.AccessibleDescription = "Shows the list with the items";
			listView.AccessibleName = "List";
			listView.AccessibleRole = AccessibleRole.ListItem;
			listView.Activation = ItemActivation.OneClick;
			listView.AllowColumnReorder = true;
			listView.Columns.AddRange(new ColumnHeader[] { columnHeaderIndex, columnHeaderReadableDesignation, columnHeaderEpoch, columnHeaderMeanAnomaly, columnHeaderArgumentPerihelion, columnHeaderLongitudeAscendingNode, columnHeaderInclination, columnHeaderOrbitalEccentricity, columnHeaderMeanDailyMotion, columnHeaderSemimajorAxis, columnHeaderAbsoluteMagnitude, columnHeaderSlopeParameter, columnHeaderReference, columnHeaderNumberOppositions, columnHeaderNumberObservations, columnHeaderObservationSpan, columnHeaderRmsResidual, columnHeaderComputerName, columnHeaderFlags, columnHeaderDateLastObservation });
			listView.Font = new Font("Segoe UI", 8.5F);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.Location = new Point(13, 81);
			listView.MultiSelect = false;
			listView.Name = "listView";
			listView.ShowItemToolTips = true;
			listView.Size = new Size(720, 299);
			listView.TabIndex = 8;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = View.Details;
			listView.SelectedIndexChanged += ListViewTableMode_SelectedIndexChanged;
			listView.Enter += SetStatusbar_Enter;
			listView.Leave += ClearStatusbar_Leave;
			listView.MouseEnter += SetStatusbar_Enter;
			listView.MouseLeave += ClearStatusbar_Leave;
			// 
			// columnHeaderIndex
			// 
			columnHeaderIndex.Text = "Index No.";
			// 
			// columnHeaderReadableDesignation
			// 
			columnHeaderReadableDesignation.Text = "Readable designation";
			columnHeaderReadableDesignation.Width = 120;
			// 
			// columnHeaderEpoch
			// 
			columnHeaderEpoch.Text = "Epoch";
			columnHeaderEpoch.TextAlign = HorizontalAlignment.Center;
			// 
			// columnHeaderMeanAnomaly
			// 
			columnHeaderMeanAnomaly.Text = "Mean anomaly at the epoch, in degrees";
			columnHeaderMeanAnomaly.TextAlign = HorizontalAlignment.Right;
			columnHeaderMeanAnomaly.Width = 70;
			// 
			// columnHeaderArgumentPerihelion
			// 
			columnHeaderArgumentPerihelion.Text = "Argument of perihelion, J2000.0 (degrees)";
			columnHeaderArgumentPerihelion.TextAlign = HorizontalAlignment.Right;
			columnHeaderArgumentPerihelion.Width = 70;
			// 
			// columnHeaderLongitudeAscendingNode
			// 
			columnHeaderLongitudeAscendingNode.Text = "Longitude of the ascending node";
			columnHeaderLongitudeAscendingNode.TextAlign = HorizontalAlignment.Right;
			columnHeaderLongitudeAscendingNode.Width = 70;
			// 
			// columnHeaderInclination
			// 
			columnHeaderInclination.Text = "Inclination";
			columnHeaderInclination.TextAlign = HorizontalAlignment.Right;
			// 
			// columnHeaderOrbitalEccentricity
			// 
			columnHeaderOrbitalEccentricity.Text = "Orbital eccentricity";
			columnHeaderOrbitalEccentricity.TextAlign = HorizontalAlignment.Right;
			columnHeaderOrbitalEccentricity.Width = 70;
			// 
			// columnHeaderMeanDailyMotion
			// 
			columnHeaderMeanDailyMotion.Text = "Mean daily motion";
			columnHeaderMeanDailyMotion.TextAlign = HorizontalAlignment.Right;
			columnHeaderMeanDailyMotion.Width = 70;
			// 
			// columnHeaderSemimajorAxis
			// 
			columnHeaderSemimajorAxis.Text = "Semimajor axis";
			columnHeaderSemimajorAxis.TextAlign = HorizontalAlignment.Right;
			columnHeaderSemimajorAxis.Width = 75;
			// 
			// columnHeaderAbsoluteMagnitude
			// 
			columnHeaderAbsoluteMagnitude.Text = "Absolute magnitude";
			columnHeaderAbsoluteMagnitude.TextAlign = HorizontalAlignment.Center;
			// 
			// columnHeaderSlopeParameter
			// 
			columnHeaderSlopeParameter.Text = "Slope parameter";
			columnHeaderSlopeParameter.TextAlign = HorizontalAlignment.Center;
			// 
			// columnHeaderReference
			// 
			columnHeaderReference.Text = "Reference";
			columnHeaderReference.TextAlign = HorizontalAlignment.Center;
			columnHeaderReference.Width = 80;
			// 
			// columnHeaderNumberOppositions
			// 
			columnHeaderNumberOppositions.Text = "Number of oppositions";
			columnHeaderNumberOppositions.TextAlign = HorizontalAlignment.Center;
			// 
			// columnHeaderNumberObservations
			// 
			columnHeaderNumberObservations.Text = "Number of observations";
			columnHeaderNumberObservations.TextAlign = HorizontalAlignment.Center;
			// 
			// columnHeaderObservationSpan
			// 
			columnHeaderObservationSpan.Text = "Observation span";
			columnHeaderObservationSpan.TextAlign = HorizontalAlignment.Center;
			columnHeaderObservationSpan.Width = 80;
			// 
			// columnHeaderRmsResidual
			// 
			columnHeaderRmsResidual.Text = "r.m.s. residual";
			columnHeaderRmsResidual.TextAlign = HorizontalAlignment.Center;
			// 
			// columnHeaderComputerName
			// 
			columnHeaderComputerName.Text = "Computer name";
			columnHeaderComputerName.TextAlign = HorizontalAlignment.Center;
			columnHeaderComputerName.Width = 80;
			// 
			// columnHeaderFlags
			// 
			columnHeaderFlags.Text = "4-hexdigit flags";
			columnHeaderFlags.TextAlign = HorizontalAlignment.Center;
			// 
			// columnHeaderDateLastObservation
			// 
			columnHeaderDateLastObservation.Text = "Date of last observation";
			columnHeaderDateLastObservation.TextAlign = HorizontalAlignment.Center;
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(statusStrip);
			panel.Controls.Add(labelMinimum);
			panel.Controls.Add(buttonCancel);
			panel.Controls.Add(listView);
			panel.Controls.Add(labelWarning);
			panel.Controls.Add(progressBar);
			panel.Controls.Add(buttonList);
			panel.Controls.Add(numericUpDownMinimum);
			panel.Controls.Add(numericUpDownMaximum);
			panel.Controls.Add(labelMaximum);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.PanelBackStyle = PaletteBackStyle.FormMain;
			panel.Size = new Size(744, 415);
			panel.TabIndex = 0;
			panel.TabStop = true;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 393);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(744, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 9;
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
			// TableModeForm
			// 
			AccessibleDescription = "Lists the MPCORB.DAT into a  table";
			AccessibleName = "Table Mode";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(744, 415);
			Controls.Add(panel);
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "TableModeForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Table Mode";
			toolTip.SetToolTip(this, "Table Mode");
			UseDropShadow = true;
			FormClosed += TableModeForm_FormClosed;
			Load += TableModeForm_Load;
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ListView listView;
    private System.Windows.Forms.ColumnHeader columnHeaderIndex;
    private System.Windows.Forms.ColumnHeader columnHeaderReadableDesignation;
    private System.Windows.Forms.ColumnHeader columnHeaderEpoch;
    private System.Windows.Forms.ColumnHeader columnHeaderMeanAnomaly;
    private System.Windows.Forms.ColumnHeader columnHeaderArgumentPerihelion;
    private System.Windows.Forms.ColumnHeader columnHeaderLongitudeAscendingNode;
    private System.Windows.Forms.ColumnHeader columnHeaderInclination;
    private System.Windows.Forms.ColumnHeader columnHeaderOrbitalEccentricity;
    private System.Windows.Forms.ColumnHeader columnHeaderMeanDailyMotion;
    private System.Windows.Forms.ColumnHeader columnHeaderSemimajorAxis;
    private System.Windows.Forms.ColumnHeader columnHeaderAbsoluteMagnitude;
    private System.Windows.Forms.ColumnHeader columnHeaderSlopeParameter;
    private System.Windows.Forms.ColumnHeader columnHeaderReference;
    private System.Windows.Forms.ColumnHeader columnHeaderNumberOppositions;
    private System.Windows.Forms.ColumnHeader columnHeaderNumberObservations;
    private System.Windows.Forms.ColumnHeader columnHeaderObservationSpan;
    private System.Windows.Forms.ColumnHeader columnHeaderRmsResidual;
    private System.Windows.Forms.ColumnHeader columnHeaderComputerName;
    private System.Windows.Forms.ColumnHeader columnHeaderFlags;
    private System.Windows.Forms.ColumnHeader columnHeaderDateLastObservation;
    private KryptonProgressBar progressBar;
    private System.ComponentModel.BackgroundWorker backgroundWorker;
		private Krypton.Toolkit.KryptonLabel labelMinimum;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimum;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximum;
		private Krypton.Toolkit.KryptonLabel labelMaximum;
    private Krypton.Toolkit.KryptonButton buttonList;
    private System.Windows.Forms.Label labelWarning;
    private Krypton.Toolkit.KryptonButton buttonCancel;
        private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}