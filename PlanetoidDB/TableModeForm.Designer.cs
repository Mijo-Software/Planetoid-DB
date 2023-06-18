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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableModeForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.labelMinimum = new Krypton.Toolkit.KryptonLabel();
			this.numericUpDownMinimum = new Krypton.Toolkit.KryptonNumericUpDown();
			this.numericUpDownMaximum = new Krypton.Toolkit.KryptonNumericUpDown();
			this.labelMaximum = new Krypton.Toolkit.KryptonLabel();
			this.buttonList = new Krypton.Toolkit.KryptonButton();
			this.labelWarning = new System.Windows.Forms.Label();
			this.buttonCancel = new Krypton.Toolkit.KryptonButton();
			this.listViewTableMode = new System.Windows.Forms.ListView();
			this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderReadableDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderEpoch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderMeanAnomaly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderArgumentPerihelion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderLongitudeAscendingNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderInclination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrbitalEccentricity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderMeanDailyMotion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSemimajorAxis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderAbsoluteMagnitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSlopeParameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderReference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderNumberOppositions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderNumberObservations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderObservationSpan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderRmsResidual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderComputerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDateLastObservation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.AccessibleDescription = "Show the progress";
			this.progressBar.AccessibleName = "Progress";
			this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBar.Location = new System.Drawing.Point(13, 56);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(720, 10);
			this.progressBar.Step = 1;
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 7;
			this.toolTip.SetToolTip(this.progressBar, "Show the progress");
			this.progressBar.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBar.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMinimum
			// 
			this.labelMinimum.AccessibleDescription = "Show the minimum";
			this.labelMinimum.AccessibleName = "Minimum";
			this.labelMinimum.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMinimum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMinimum.Location = new System.Drawing.Point(13, 21);
			this.labelMinimum.Name = "labelMinimum";
			this.labelMinimum.Size = new System.Drawing.Size(66, 20);
			this.labelMinimum.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelMinimum, "Minimum");
			this.labelMinimum.Values.Text = "M&inimum:";
			this.labelMinimum.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMinimum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinimum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMinimum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinimum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericUpDownMinimum
			// 
			this.numericUpDownMinimum.AccessibleDescription = "Show the minimum value";
			this.numericUpDownMinimum.AccessibleName = "Minimum value";
			this.numericUpDownMinimum.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownMinimum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.numericUpDownMinimum.Location = new System.Drawing.Point(82, 18);
			this.numericUpDownMinimum.Name = "numericUpDownMinimum";
			this.numericUpDownMinimum.Size = new System.Drawing.Size(64, 22);
			this.numericUpDownMinimum.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.numericUpDownMinimum.TabIndex = 1;
			this.toolTip.SetToolTip(this.numericUpDownMinimum, "Minimum value for the list");
			this.numericUpDownMinimum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownMinimum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericUpDownMaximum
			// 
			this.numericUpDownMaximum.AccessibleDescription = "Show the maximum value";
			this.numericUpDownMaximum.AccessibleName = "Maximum value";
			this.numericUpDownMaximum.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownMaximum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.numericUpDownMaximum.Location = new System.Drawing.Point(222, 18);
			this.numericUpDownMaximum.Name = "numericUpDownMaximum";
			this.numericUpDownMaximum.Size = new System.Drawing.Size(64, 22);
			this.numericUpDownMaximum.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.numericUpDownMaximum.TabIndex = 3;
			this.toolTip.SetToolTip(this.numericUpDownMaximum, "Maximum value for the list");
			this.numericUpDownMaximum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownMaximum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMaximum
			// 
			this.labelMaximum.AccessibleDescription = "Show the maximum";
			this.labelMaximum.AccessibleName = "Maximum";
			this.labelMaximum.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMaximum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMaximum.Location = new System.Drawing.Point(152, 21);
			this.labelMaximum.Name = "labelMaximum";
			this.labelMaximum.Size = new System.Drawing.Size(68, 20);
			this.labelMaximum.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelMaximum, "Maximum");
			this.labelMaximum.Values.Text = "M&aximum:";
			this.labelMaximum.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMaximum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMaximum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMaximum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMaximum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonList
			// 
			this.buttonList.AccessibleDescription = "Start the progress and list";
			this.buttonList.AccessibleName = "List";
			this.buttonList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonList.CornerRoundingRadius = -1F;
			this.buttonList.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonList.Location = new System.Drawing.Point(292, 14);
			this.buttonList.Name = "buttonList";
			this.buttonList.Size = new System.Drawing.Size(52, 31);
			this.buttonList.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonList, "Start the progress and list");
			this.buttonList.Values.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.buttonList.Values.Text = "&List";
			this.buttonList.Click += new System.EventHandler(this.ButtonList_Click);
			this.buttonList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelWarning
			// 
			this.labelWarning.AccessibleDescription = "Warning message: Be careful! Don\'t use a big span between minimum and maximum!";
			this.labelWarning.AccessibleName = "Warning message";
			this.labelWarning.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelWarning.BackColor = System.Drawing.Color.SeaShell;
			this.labelWarning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 7F);
			this.labelWarning.Location = new System.Drawing.Point(425, 14);
			this.labelWarning.Name = "labelWarning";
			this.labelWarning.Size = new System.Drawing.Size(308, 31);
			this.labelWarning.TabIndex = 6;
			this.labelWarning.Text = "Be careful: Don\'t use a big span between minimum and maximum! The loading time an" +
    "d the memory increase. Use small spans!";
			this.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelWarning, "Be careful: Don\'t use a big span between minimum and maximum!");
			this.labelWarning.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelWarning.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelWarning.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelWarning.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelWarning.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleDescription = "Cancel the progress";
			this.buttonCancel.AccessibleName = "Cancel";
			this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancel.CornerRoundingRadius = -1F;
			this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCancel.Location = new System.Drawing.Point(350, 14);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(69, 31);
			this.buttonCancel.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonCancel, "Cancel the progress");
			this.buttonCancel.Values.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.buttonCancel.Values.Text = "&Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			this.buttonCancel.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancel.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCancel.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancel.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
            this.columnHeaderEpoch,
            this.columnHeaderMeanAnomaly,
            this.columnHeaderArgumentPerihelion,
            this.columnHeaderLongitudeAscendingNode,
            this.columnHeaderInclination,
            this.columnHeaderOrbitalEccentricity,
            this.columnHeaderMeanDailyMotion,
            this.columnHeaderSemimajorAxis,
            this.columnHeaderAbsoluteMagnitude,
            this.columnHeaderSlopeParameter,
            this.columnHeaderReference,
            this.columnHeaderNumberOppositions,
            this.columnHeaderNumberObservations,
            this.columnHeaderObservationSpan,
            this.columnHeaderRmsResidual,
            this.columnHeaderComputerName,
            this.columnHeaderFlags,
            this.columnHeaderDateLastObservation});
			this.listViewTableMode.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.listViewTableMode.FullRowSelect = true;
			this.listViewTableMode.GridLines = true;
			this.listViewTableMode.HideSelection = false;
			this.listViewTableMode.Location = new System.Drawing.Point(13, 81);
			this.listViewTableMode.Name = "listViewTableMode";
			this.listViewTableMode.Size = new System.Drawing.Size(720, 299);
			this.listViewTableMode.TabIndex = 8;
			this.listViewTableMode.UseCompatibleStateImageBehavior = false;
			this.listViewTableMode.View = System.Windows.Forms.View.Details;
			this.listViewTableMode.SelectedIndexChanged += new System.EventHandler(this.ListViewTableMode_SelectedIndexChanged);
			this.listViewTableMode.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listViewTableMode.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.listViewTableMode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listViewTableMode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// columnHeaderIndex
			// 
			this.columnHeaderIndex.Text = "Index No.";
			// 
			// columnHeaderReadableDesignation
			// 
			this.columnHeaderReadableDesignation.Text = "Readable designation";
			this.columnHeaderReadableDesignation.Width = 120;
			// 
			// columnHeaderEpoch
			// 
			this.columnHeaderEpoch.Text = "Epoch";
			this.columnHeaderEpoch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeaderMeanAnomaly
			// 
			this.columnHeaderMeanAnomaly.Text = "Mean anomaly at the epoch, in degrees";
			this.columnHeaderMeanAnomaly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderMeanAnomaly.Width = 70;
			// 
			// columnHeaderArgumentPerihelion
			// 
			this.columnHeaderArgumentPerihelion.Text = "Argument of perihelion, J2000.0 (degrees)";
			this.columnHeaderArgumentPerihelion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderArgumentPerihelion.Width = 70;
			// 
			// columnHeaderLongitudeAscendingNode
			// 
			this.columnHeaderLongitudeAscendingNode.Text = "Longitude of the ascending node";
			this.columnHeaderLongitudeAscendingNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderLongitudeAscendingNode.Width = 70;
			// 
			// columnHeaderInclination
			// 
			this.columnHeaderInclination.Text = "Inclination";
			this.columnHeaderInclination.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeaderOrbitalEccentricity
			// 
			this.columnHeaderOrbitalEccentricity.Text = "Orbital eccentricity";
			this.columnHeaderOrbitalEccentricity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderOrbitalEccentricity.Width = 70;
			// 
			// columnHeaderMeanDailyMotion
			// 
			this.columnHeaderMeanDailyMotion.Text = "Mean daily motion";
			this.columnHeaderMeanDailyMotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderMeanDailyMotion.Width = 70;
			// 
			// columnHeaderSemimajorAxis
			// 
			this.columnHeaderSemimajorAxis.Text = "Semimajor axis";
			this.columnHeaderSemimajorAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderSemimajorAxis.Width = 75;
			// 
			// columnHeaderAbsoluteMagnitude
			// 
			this.columnHeaderAbsoluteMagnitude.Text = "Absolute magnitude";
			this.columnHeaderAbsoluteMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeaderSlopeParameter
			// 
			this.columnHeaderSlopeParameter.Text = "Slope parameter";
			this.columnHeaderSlopeParameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeaderReference
			// 
			this.columnHeaderReference.Text = "Reference";
			this.columnHeaderReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderReference.Width = 80;
			// 
			// columnHeaderNumberOppositions
			// 
			this.columnHeaderNumberOppositions.Text = "Number of oppositions";
			this.columnHeaderNumberOppositions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeaderNumberObservations
			// 
			this.columnHeaderNumberObservations.Text = "Number of observations";
			this.columnHeaderNumberObservations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeaderObservationSpan
			// 
			this.columnHeaderObservationSpan.Text = "Observation span";
			this.columnHeaderObservationSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderObservationSpan.Width = 80;
			// 
			// columnHeaderRmsResidual
			// 
			this.columnHeaderRmsResidual.Text = "r.m.s. residual";
			this.columnHeaderRmsResidual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeaderComputerName
			// 
			this.columnHeaderComputerName.Text = "Computer name";
			this.columnHeaderComputerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderComputerName.Width = 80;
			// 
			// columnHeaderFlags
			// 
			this.columnHeaderFlags.Text = "4-hexdigit flags";
			this.columnHeaderFlags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeaderDateLastObservation
			// 
			this.columnHeaderDateLastObservation.Text = "Date of last observation";
			this.columnHeaderDateLastObservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.Controls.Add(this.kryptonStatusStrip);
			this.kryptonPanel.Controls.Add(this.labelMinimum);
			this.kryptonPanel.Controls.Add(this.buttonCancel);
			this.kryptonPanel.Controls.Add(this.listViewTableMode);
			this.kryptonPanel.Controls.Add(this.labelWarning);
			this.kryptonPanel.Controls.Add(this.progressBar);
			this.kryptonPanel.Controls.Add(this.buttonList);
			this.kryptonPanel.Controls.Add(this.numericUpDownMinimum);
			this.kryptonPanel.Controls.Add(this.numericUpDownMaximum);
			this.kryptonPanel.Controls.Add(this.labelMaximum);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(744, 401);
			this.kryptonPanel.TabIndex = 0;
			this.kryptonPanel.TabStop = true;
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 379);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(744, 22);
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
			// TableModeForm
			// 
			this.AccessibleDescription = "List the MPCORB.DAT into a  table";
			this.AccessibleName = "Table Mode";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 401);
			this.Controls.Add(this.kryptonPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TableModeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Table Mode";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableModeForm_FormClosed);
			this.Load += new System.EventHandler(this.TableModeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ListView listViewTableMode;
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
    private System.Windows.Forms.ProgressBar progressBar;
    private System.ComponentModel.BackgroundWorker backgroundWorker;
		private Krypton.Toolkit.KryptonLabel labelMinimum;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimum;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximum;
		private Krypton.Toolkit.KryptonLabel labelMaximum;
    private Krypton.Toolkit.KryptonButton buttonList;
    private System.Windows.Forms.Label labelWarning;
    private Krypton.Toolkit.KryptonButton buttonCancel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}