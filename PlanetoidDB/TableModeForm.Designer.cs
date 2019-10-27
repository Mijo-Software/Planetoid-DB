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
			this.labelMinimum = new System.Windows.Forms.Label();
			this.numericUpDownMinimum = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMaximum = new System.Windows.Forms.NumericUpDown();
			this.labelMaximum = new System.Windows.Forms.Label();
			this.pictureBoxWarning = new System.Windows.Forms.PictureBox();
			this.buttonList = new System.Windows.Forms.Button();
			this.labelWarning1 = new System.Windows.Forms.Label();
			this.labelWarning2 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelHelp = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.AccessibleDescription = "Show the progress";
			this.progressBar.AccessibleName = "Progress";
			this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBar.Location = new System.Drawing.Point(12, 52);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(720, 10);
			this.progressBar.Step = 1;
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 8;
			this.toolTip.SetToolTip(this.progressBar, "Show the progress");
			this.progressBar.MouseEnter += new System.EventHandler(this.ProgressBar_MouseEnter);
			this.progressBar.MouseLeave += new System.EventHandler(this.ProgressBar_MouseLeave);
			// 
			// labelMinimum
			// 
			this.labelMinimum.AccessibleDescription = "Show the minimum";
			this.labelMinimum.AccessibleName = "Minimum";
			this.labelMinimum.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMinimum.AutoSize = true;
			this.labelMinimum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMinimum.Location = new System.Drawing.Point(12, 17);
			this.labelMinimum.Name = "labelMinimum";
			this.labelMinimum.Size = new System.Drawing.Size(63, 15);
			this.labelMinimum.TabIndex = 0;
			this.labelMinimum.Text = "M&inimum:";
			this.toolTip.SetToolTip(this.labelMinimum, "Minimum");
			this.labelMinimum.DoubleClick += new System.EventHandler(this.LabelMinimum_DoubleClick);
			this.labelMinimum.Enter += new System.EventHandler(this.LabelMinimum_Enter);
			this.labelMinimum.Leave += new System.EventHandler(this.LabelMinimum_Leave);
			this.labelMinimum.MouseEnter += new System.EventHandler(this.LabelMinimum_Enter);
			this.labelMinimum.MouseLeave += new System.EventHandler(this.LabelMinimum_Leave);
			// 
			// numericUpDownMinimum
			// 
			this.numericUpDownMinimum.AccessibleDescription = "Show the minimum value";
			this.numericUpDownMinimum.AccessibleName = "Minimum value";
			this.numericUpDownMinimum.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownMinimum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.numericUpDownMinimum.Location = new System.Drawing.Point(81, 14);
			this.numericUpDownMinimum.Name = "numericUpDownMinimum";
			this.numericUpDownMinimum.Size = new System.Drawing.Size(64, 23);
			this.numericUpDownMinimum.TabIndex = 1;
			this.numericUpDownMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.numericUpDownMinimum, "Minimum value for the list");
			this.numericUpDownMinimum.Enter += new System.EventHandler(this.NumericUpDownMinimum_Enter);
			this.numericUpDownMinimum.Leave += new System.EventHandler(this.NumericUpDownMinimum_Leave);
			// 
			// numericUpDownMaximum
			// 
			this.numericUpDownMaximum.AccessibleDescription = "Show the maximum value";
			this.numericUpDownMaximum.AccessibleName = "Maximum value";
			this.numericUpDownMaximum.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownMaximum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.numericUpDownMaximum.Location = new System.Drawing.Point(221, 14);
			this.numericUpDownMaximum.Name = "numericUpDownMaximum";
			this.numericUpDownMaximum.Size = new System.Drawing.Size(64, 23);
			this.numericUpDownMaximum.TabIndex = 3;
			this.numericUpDownMaximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.numericUpDownMaximum, "Maximum value for the list");
			this.numericUpDownMaximum.Enter += new System.EventHandler(this.NumericUpDownMaximum_Enter);
			this.numericUpDownMaximum.Leave += new System.EventHandler(this.NumericUpDownMaximum_Leave);
			// 
			// labelMaximum
			// 
			this.labelMaximum.AccessibleDescription = "Show the maximum";
			this.labelMaximum.AccessibleName = "Maximum";
			this.labelMaximum.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMaximum.AutoSize = true;
			this.labelMaximum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMaximum.Location = new System.Drawing.Point(151, 17);
			this.labelMaximum.Name = "labelMaximum";
			this.labelMaximum.Size = new System.Drawing.Size(64, 15);
			this.labelMaximum.TabIndex = 2;
			this.labelMaximum.Text = "M&aximum:";
			this.toolTip.SetToolTip(this.labelMaximum, "Maximum");
			this.labelMaximum.DoubleClick += new System.EventHandler(this.LabelMaximum_DoubleClick);
			this.labelMaximum.Enter += new System.EventHandler(this.LabelMaximum_Enter);
			this.labelMaximum.Leave += new System.EventHandler(this.LabelMaximum_Leave);
			this.labelMaximum.MouseEnter += new System.EventHandler(this.LabelMaximum_Enter);
			this.labelMaximum.MouseLeave += new System.EventHandler(this.LabelMaximum_Leave);
			// 
			// pictureBoxWarning
			// 
			this.pictureBoxWarning.AccessibleDescription = "It\'s a warning sign.";
			this.pictureBoxWarning.AccessibleName = "Warning sign";
			this.pictureBoxWarning.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBoxWarning.Image = global::Planetoid_DB.Properties.Resources.silk_error;
			this.pictureBoxWarning.Location = new System.Drawing.Point(424, 10);
			this.pictureBoxWarning.Name = "pictureBoxWarning";
			this.pictureBoxWarning.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxWarning.TabIndex = 8;
			this.pictureBoxWarning.TabStop = false;
			this.toolTip.SetToolTip(this.pictureBoxWarning, "Warning!!!");
			this.pictureBoxWarning.DoubleClick += new System.EventHandler(this.PictureBoxWarning_DoubleClick);
			this.pictureBoxWarning.MouseEnter += new System.EventHandler(this.PictureBoxWarning_MouseEnter);
			this.pictureBoxWarning.MouseLeave += new System.EventHandler(this.PictureBoxWarning_MouseLeave);
			// 
			// buttonList
			// 
			this.buttonList.AccessibleDescription = "Start the progress and list";
			this.buttonList.AccessibleName = "List";
			this.buttonList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonList.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonList.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.buttonList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonList.Location = new System.Drawing.Point(291, 10);
			this.buttonList.Name = "buttonList";
			this.buttonList.Size = new System.Drawing.Size(52, 31);
			this.buttonList.TabIndex = 4;
			this.buttonList.Text = "&List";
			this.buttonList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonList, "Start the progress and list");
			this.buttonList.UseVisualStyleBackColor = true;
			this.buttonList.Click += new System.EventHandler(this.ButtonList_Click);
			this.buttonList.Enter += new System.EventHandler(this.ButtonList_Enter);
			this.buttonList.Leave += new System.EventHandler(this.ButtonList_Leave);
			this.buttonList.MouseEnter += new System.EventHandler(this.ButtonList_Enter);
			this.buttonList.MouseLeave += new System.EventHandler(this.ButtonList_Leave);
			// 
			// labelWarning1
			// 
			this.labelWarning1.AccessibleDescription = "Warning message: Be careful! Don\'t use a big span between minimum and maximum!";
			this.labelWarning1.AccessibleName = "Warning message 1";
			this.labelWarning1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelWarning1.AutoSize = true;
			this.labelWarning1.Font = new System.Drawing.Font("Segoe UI", 7F);
			this.labelWarning1.Location = new System.Drawing.Point(443, 14);
			this.labelWarning1.Name = "labelWarning1";
			this.labelWarning1.Size = new System.Drawing.Size(301, 12);
			this.labelWarning1.TabIndex = 6;
			this.labelWarning1.Text = "Be careful: Don\'t use a big span between minimum and maximum!";
			this.toolTip.SetToolTip(this.labelWarning1, "Be careful: Don\'t use a big span between minimum and maximum!");
			this.labelWarning1.DoubleClick += new System.EventHandler(this.LabelWarning1_DoubleClick);
			this.labelWarning1.Enter += new System.EventHandler(this.LabelWarning1_Enter);
			this.labelWarning1.Leave += new System.EventHandler(this.LabelWarning1_Leave);
			this.labelWarning1.MouseEnter += new System.EventHandler(this.LabelWarning1_Enter);
			this.labelWarning1.MouseLeave += new System.EventHandler(this.LabelWarning1_Leave);
			// 
			// labelWarning2
			// 
			this.labelWarning2.AccessibleDescription = "Warning message: The loading time and the memory increase. Use small spans!";
			this.labelWarning2.AccessibleName = "Warning message 2";
			this.labelWarning2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelWarning2.AutoSize = true;
			this.labelWarning2.Font = new System.Drawing.Font("Segoe UI", 7F);
			this.labelWarning2.Location = new System.Drawing.Point(443, 29);
			this.labelWarning2.Name = "labelWarning2";
			this.labelWarning2.Size = new System.Drawing.Size(271, 12);
			this.labelWarning2.TabIndex = 7;
			this.labelWarning2.Text = "The loading time and the memory increase. Use small spans!";
			this.toolTip.SetToolTip(this.labelWarning2, "The loading time and the memory increase. Use small spans!");
			this.labelWarning2.DoubleClick += new System.EventHandler(this.LabelWarning2_DoubleClick);
			this.labelWarning2.Enter += new System.EventHandler(this.LabelWarning2_Enter);
			this.labelWarning2.Leave += new System.EventHandler(this.LabelWarning2_Leave);
			this.labelWarning2.MouseEnter += new System.EventHandler(this.LabelWarning2_Enter);
			this.labelWarning2.MouseLeave += new System.EventHandler(this.LabelWarning2_Leave);
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleDescription = "Cancel the progress";
			this.buttonCancel.AccessibleName = "Cancel";
			this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCancel.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCancel.Location = new System.Drawing.Point(349, 10);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(69, 31);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCancel, "Cancel the progress");
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			this.buttonCancel.Enter += new System.EventHandler(this.ButtonCancel_Enter);
			this.buttonCancel.Leave += new System.EventHandler(this.ButtonCancel_Leave);
			this.buttonCancel.MouseEnter += new System.EventHandler(this.ButtonCancel_Enter);
			this.buttonCancel.MouseLeave += new System.EventHandler(this.ButtonCancel_Leave);
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
			this.listViewTableMode.Location = new System.Drawing.Point(12, 77);
			this.listViewTableMode.Name = "listViewTableMode";
			this.listViewTableMode.Size = new System.Drawing.Size(720, 299);
			this.listViewTableMode.TabIndex = 9;
			this.listViewTableMode.UseCompatibleStateImageBehavior = false;
			this.listViewTableMode.View = System.Windows.Forms.View.Details;
			this.listViewTableMode.SelectedIndexChanged += new System.EventHandler(this.ListViewTableMode_SelectedIndexChanged);
			this.listViewTableMode.Enter += new System.EventHandler(this.ListViewTableMode_Enter);
			this.listViewTableMode.Leave += new System.EventHandler(this.ListViewTableMode_Leave);
			this.listViewTableMode.MouseEnter += new System.EventHandler(this.ListViewTableMode_Enter);
			this.listViewTableMode.MouseLeave += new System.EventHandler(this.ListViewTableMode_Leave);
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
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the status";
			this.statusStrip.AccessibleName = "Status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelHelp});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 380);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(744, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 10;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelHelp
			// 
			this.labelHelp.AccessibleDescription = "Show some important informations";
			this.labelHelp.AccessibleName = "Information field";
			this.labelHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelHelp.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelHelp.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(170, 16);
			this.labelHelp.Text = "Show informative messages";
			this.labelHelp.ToolTipText = "Show informative messages";
			this.labelHelp.MouseEnter += new System.EventHandler(this.LabelStatus_MouseEnter);
			this.labelHelp.MouseLeave += new System.EventHandler(this.LabelStatus_MouseLeave);
			// 
			// TableModeForm
			// 
			this.AccessibleDescription = "List up the MPCORB.DAT into a  table";
			this.AccessibleName = "Table Mode";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 401);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelWarning2);
			this.Controls.Add(this.labelWarning1);
			this.Controls.Add(this.pictureBoxWarning);
			this.Controls.Add(this.buttonList);
			this.Controls.Add(this.numericUpDownMaximum);
			this.Controls.Add(this.labelMaximum);
			this.Controls.Add(this.numericUpDownMinimum);
			this.Controls.Add(this.labelMinimum);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.listViewTableMode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TableModeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Table Mode";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableModeForm_FormClosed);
			this.Load += new System.EventHandler(this.TableModeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.Label labelMinimum;
    private System.Windows.Forms.NumericUpDown numericUpDownMinimum;
    private System.Windows.Forms.NumericUpDown numericUpDownMaximum;
    private System.Windows.Forms.Label labelMaximum;
    private System.Windows.Forms.Button buttonList;
    private System.Windows.Forms.PictureBox pictureBoxWarning;
    private System.Windows.Forms.Label labelWarning1;
    private System.Windows.Forms.Label labelWarning2;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.ToolStripStatusLabel labelHelp;
  }
}