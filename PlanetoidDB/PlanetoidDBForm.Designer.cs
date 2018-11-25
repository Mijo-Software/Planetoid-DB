namespace Planetoid_DB
{
  /// <summary>
	/// 
	/// </summary>
	partial class PlanetoidDBForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetoidDBForm));
			this.contextMenuNavigationStep = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1000 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10000 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem100000 = new System.Windows.Forms.ToolStripMenuItem();
			this.labelIndex = new System.Windows.Forms.Label();
			this.labelMagAbs = new System.Windows.Forms.Label();
			this.labelSlopeParam = new System.Windows.Forms.Label();
			this.labelEpoch = new System.Windows.Forms.Label();
			this.labelMeanAnomaly = new System.Windows.Forms.Label();
			this.labelArgPeri = new System.Windows.Forms.Label();
			this.labelLongAscNode = new System.Windows.Forms.Label();
			this.labelIncl = new System.Windows.Forms.Label();
			this.labelOrbEcc = new System.Windows.Forms.Label();
			this.labelMotion = new System.Windows.Forms.Label();
			this.labelSemiMajorAxis = new System.Windows.Forms.Label();
			this.labelRef = new System.Windows.Forms.Label();
			this.labelNumbObs = new System.Windows.Forms.Label();
			this.labelNumbOppos = new System.Windows.Forms.Label();
			this.labelObsSpan = new System.Windows.Forms.Label();
			this.labelRmsResidual = new System.Windows.Forms.Label();
			this.labelComputerName = new System.Windows.Forms.Label();
			this.labelDesgnName = new System.Windows.Forms.Label();
			this.labelObsLastDate = new System.Windows.Forms.Label();
			this.labelFlags = new System.Windows.Forms.Label();
			this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
			this.labelDesgnNameValue = new System.Windows.Forms.Label();
			this.labelEpochValue = new System.Windows.Forms.Label();
			this.labelMeanAnomalyValue = new System.Windows.Forms.Label();
			this.labelArgPeriValue = new System.Windows.Forms.Label();
			this.labelLongAscNodeValue = new System.Windows.Forms.Label();
			this.labelInclValue = new System.Windows.Forms.Label();
			this.labelOrbEccValue = new System.Windows.Forms.Label();
			this.labelMotionValue = new System.Windows.Forms.Label();
			this.labelSemiMajorAxisValue = new System.Windows.Forms.Label();
			this.labelSlopeParamValue = new System.Windows.Forms.Label();
			this.labelIndexValue = new System.Windows.Forms.Label();
			this.labelMagAbsValue = new System.Windows.Forms.Label();
			this.labelRefValue = new System.Windows.Forms.Label();
			this.labelNumbOpposValue = new System.Windows.Forms.Label();
			this.labelNumbObsValue = new System.Windows.Forms.Label();
			this.labelObsSpanValue = new System.Windows.Forms.Label();
			this.labelRmsResidualValue = new System.Windows.Forms.Label();
			this.labelComputerNameValue = new System.Windows.Forms.Label();
			this.labelFlagsValue = new System.Windows.Forms.Label();
			this.labelObsLastDateValue = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.numericUpDownGotoIndex = new System.Windows.Forms.NumericUpDown();
			this.labelIndexPos = new System.Windows.Forms.Label();
			this.trackBarIndex = new System.Windows.Forms.TrackBar();
			this.buttonGotoIndex = new System.Windows.Forms.Button();
			this.buttonStepForward = new System.Windows.Forms.Button();
			this.buttonStepToEnd = new System.Windows.Forms.Button();
			this.buttonStepForward1 = new System.Windows.Forms.Button();
			this.buttonStepBackward1 = new System.Windows.Forms.Button();
			this.buttonStepBackward = new System.Windows.Forms.Button();
			this.buttonStepToBegin = new System.Windows.Forms.Button();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelUpdate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBarBackgroundDownload = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelCancelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelHelp = new System.Windows.Forms.ToolStripStatusLabel();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.menuitemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopytoClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDatabaseInformation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTableMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorOptions1 = new System.Windows.Forms.ToolStripSeparator();
			this.chartBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chartCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chartPieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorOptions2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemCheckMpcorbDat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDownloadMpcorbDat = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorOptions3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemStyle = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemStyleProfessional = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemStyleOffice2007 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemStyleSystem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemStyleVs2008 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemQuest = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorMisc = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemOpenWebsitePDB = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOpenWebsiteMPC = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOpenMPCORBWebsite = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripIcons = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCopyToClipboard = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonDatabaseInformation = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTableMode = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonCheckMpcorbDat = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDownloadMpcorbDat = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpenWebsitePDB = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelSearch = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
			this.labelGottoIndex = new System.Windows.Forms.Label();
			this.backgroundWorkerLoadingDatabase = new System.ComponentModel.BackgroundWorker();
			this.timerBlinkForUpdateAvailable = new System.Windows.Forms.Timer(this.components);
			this.toolStripNavigation = new System.Windows.Forms.ToolStrip();
			this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.timerCheckForNewMpcorbDatFile = new System.Windows.Forms.Timer(this.components);
			this.notifyIconUpdate = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.checkMPCORBDATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadMPCORBDATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuNavigationStep.SuspendLayout();
			this.tableLayoutPanelData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownGotoIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIndex)).BeginInit();
			this.statusBar.SuspendLayout();
			this.menu.SuspendLayout();
			this.toolStripIcons.SuspendLayout();
			this.toolStripNavigation.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.contextMenuNotifyIcon.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuNavigationStep
			// 
			this.contextMenuNavigationStep.AccessibleDescription = "Show the context name of data items";
			this.contextMenuNavigationStep.AccessibleName = "Context menu of items";
			this.contextMenuNavigationStep.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuNavigationStep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem100,
            this.toolStripMenuItem1000,
            this.toolStripMenuItem10000,
            this.toolStripMenuItem100000});
			this.contextMenuNavigationStep.Name = "contextMenu";
			this.contextMenuNavigationStep.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.contextMenuNavigationStep.ShowCheckMargin = true;
			this.contextMenuNavigationStep.ShowImageMargin = false;
			this.contextMenuNavigationStep.Size = new System.Drawing.Size(111, 114);
			this.contextMenuNavigationStep.Text = "Navigation step";
			this.toolTip.SetToolTip(this.contextMenuNavigationStep, "Show the context name of data items");
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.CheckOnClick = true;
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem10.Text = "10";
			this.toolStripMenuItem10.ToolTipText = "Jump 10 items backward/forward";
			this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
			// 
			// toolStripMenuItem100
			// 
			this.toolStripMenuItem100.Checked = true;
			this.toolStripMenuItem100.CheckOnClick = true;
			this.toolStripMenuItem100.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItem100.Name = "toolStripMenuItem100";
			this.toolStripMenuItem100.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem100.Text = "100";
			this.toolStripMenuItem100.ToolTipText = "Jump 100 items backward/forward";
			this.toolStripMenuItem100.Click += new System.EventHandler(this.ToolStripMenuItem100_Click);
			// 
			// toolStripMenuItem1000
			// 
			this.toolStripMenuItem1000.CheckOnClick = true;
			this.toolStripMenuItem1000.Name = "toolStripMenuItem1000";
			this.toolStripMenuItem1000.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem1000.Text = "1000";
			this.toolStripMenuItem1000.ToolTipText = "Jump 1000 items backward/forward";
			this.toolStripMenuItem1000.Click += new System.EventHandler(this.ToolStripMenuItem1000_Click);
			// 
			// toolStripMenuItem10000
			// 
			this.toolStripMenuItem10000.CheckOnClick = true;
			this.toolStripMenuItem10000.Name = "toolStripMenuItem10000";
			this.toolStripMenuItem10000.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem10000.Text = "10000";
			this.toolStripMenuItem10000.ToolTipText = "Jump 10000 items backward/forward";
			this.toolStripMenuItem10000.Click += new System.EventHandler(this.ToolStripMenuItem10000_Click);
			// 
			// toolStripMenuItem100000
			// 
			this.toolStripMenuItem100000.CheckOnClick = true;
			this.toolStripMenuItem100000.Name = "toolStripMenuItem100000";
			this.toolStripMenuItem100000.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem100000.Text = "100000";
			this.toolStripMenuItem100000.ToolTipText = "Jump 100000 items backward/forward";
			this.toolStripMenuItem100000.Click += new System.EventHandler(this.ToolStripMenuItem100000_Click);
			// 
			// labelIndex
			// 
			this.labelIndex.AccessibleDescription = "Index No.";
			this.labelIndex.AccessibleName = "Index No.";
			this.labelIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelIndex.AutoSize = true;
			this.labelIndex.Location = new System.Drawing.Point(3, 0);
			this.labelIndex.Name = "labelIndex";
			this.labelIndex.Padding = new System.Windows.Forms.Padding(3);
			this.labelIndex.Size = new System.Drawing.Size(64, 21);
			this.labelIndex.TabIndex = 0;
			this.labelIndex.Text = "Index No.";
			this.toolTip.SetToolTip(this.labelIndex, "Index No.");
			this.labelIndex.Click += new System.EventHandler(this.LabelIndex_Click);
			this.labelIndex.DoubleClick += new System.EventHandler(this.LabelIndex_DoubleClick);
			this.labelIndex.Enter += new System.EventHandler(this.LabelIndex_Enter);
			this.labelIndex.Leave += new System.EventHandler(this.LabelIndex_Leave);
			this.labelIndex.MouseEnter += new System.EventHandler(this.LabelIndex_Enter);
			this.labelIndex.MouseLeave += new System.EventHandler(this.LabelIndex_Leave);
			// 
			// labelMagAbs
			// 
			this.labelMagAbs.AccessibleDescription = "Absolute magnitude, H";
			this.labelMagAbs.AccessibleName = "Absolute magnitude, H";
			this.labelMagAbs.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMagAbs.AutoSize = true;
			this.labelMagAbs.Location = new System.Drawing.Point(3, 210);
			this.labelMagAbs.Name = "labelMagAbs";
			this.labelMagAbs.Padding = new System.Windows.Forms.Padding(3);
			this.labelMagAbs.Size = new System.Drawing.Size(136, 21);
			this.labelMagAbs.TabIndex = 38;
			this.labelMagAbs.Text = "Absolute magnitude, H";
			this.toolTip.SetToolTip(this.labelMagAbs, "Absolute magnitude, H");
			this.labelMagAbs.Click += new System.EventHandler(this.LabelMagAbs_Click);
			this.labelMagAbs.DoubleClick += new System.EventHandler(this.LabelMagAbs_DoubleClick);
			this.labelMagAbs.Enter += new System.EventHandler(this.LabelMagAbs_Enter);
			this.labelMagAbs.Leave += new System.EventHandler(this.LabelMagAbs_Leave);
			this.labelMagAbs.MouseEnter += new System.EventHandler(this.LabelMagAbs_Enter);
			this.labelMagAbs.MouseLeave += new System.EventHandler(this.LabelMagAbs_Leave);
			// 
			// labelSlopeParam
			// 
			this.labelSlopeParam.AccessibleDescription = "Slope parameter, G";
			this.labelSlopeParam.AccessibleName = "Slope parameter, G";
			this.labelSlopeParam.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSlopeParam.AutoSize = true;
			this.labelSlopeParam.Location = new System.Drawing.Point(434, 21);
			this.labelSlopeParam.Name = "labelSlopeParam";
			this.labelSlopeParam.Padding = new System.Windows.Forms.Padding(3);
			this.labelSlopeParam.Size = new System.Drawing.Size(116, 21);
			this.labelSlopeParam.TabIndex = 4;
			this.labelSlopeParam.Text = "Slope parameter, G";
			this.toolTip.SetToolTip(this.labelSlopeParam, "Slope parameter, G");
			this.labelSlopeParam.Click += new System.EventHandler(this.LabelSlopeParam_Click);
			this.labelSlopeParam.DoubleClick += new System.EventHandler(this.LabelSlopeParam_DoubleClick);
			this.labelSlopeParam.Enter += new System.EventHandler(this.LabelSlopeParam_Enter);
			this.labelSlopeParam.Leave += new System.EventHandler(this.LabelSlopeParam_Leave);
			this.labelSlopeParam.MouseEnter += new System.EventHandler(this.LabelSlopeParam_Enter);
			this.labelSlopeParam.MouseLeave += new System.EventHandler(this.LabelSlopeParam_Leave);
			// 
			// labelEpoch
			// 
			this.labelEpoch.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.AccessibleName = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelEpoch.AutoSize = true;
			this.labelEpoch.Location = new System.Drawing.Point(3, 42);
			this.labelEpoch.Name = "labelEpoch";
			this.labelEpoch.Padding = new System.Windows.Forms.Padding(3);
			this.labelEpoch.Size = new System.Drawing.Size(170, 21);
			this.labelEpoch.TabIndex = 6;
			this.labelEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.toolTip.SetToolTip(this.labelEpoch, "Epoch (in packed form, .0 TT)");
			this.labelEpoch.Click += new System.EventHandler(this.LabelEpoch_Click);
			this.labelEpoch.DoubleClick += new System.EventHandler(this.LabelEpoch_DoubleClick);
			this.labelEpoch.Enter += new System.EventHandler(this.LabelEpoch_Enter);
			this.labelEpoch.Leave += new System.EventHandler(this.LabelEpoch_Leave);
			this.labelEpoch.MouseEnter += new System.EventHandler(this.LabelEpoch_Enter);
			this.labelEpoch.MouseLeave += new System.EventHandler(this.LabelEpoch_Leave);
			// 
			// labelMeanAnomaly
			// 
			this.labelMeanAnomaly.AccessibleDescription = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.AccessibleName = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMeanAnomaly.AutoSize = true;
			this.labelMeanAnomaly.Location = new System.Drawing.Point(3, 63);
			this.labelMeanAnomaly.Name = "labelMeanAnomaly";
			this.labelMeanAnomaly.Padding = new System.Windows.Forms.Padding(3);
			this.labelMeanAnomaly.Size = new System.Drawing.Size(227, 21);
			this.labelMeanAnomaly.TabIndex = 10;
			this.labelMeanAnomaly.Text = "Mean anomaly at the epoch, in degrees";
			this.toolTip.SetToolTip(this.labelMeanAnomaly, "Mean anomaly at the epoch, in degrees");
			this.labelMeanAnomaly.Click += new System.EventHandler(this.LabelMeanAnomaly_Click);
			this.labelMeanAnomaly.DoubleClick += new System.EventHandler(this.LabelMeanAnomaly_DoubleClick);
			this.labelMeanAnomaly.Enter += new System.EventHandler(this.LabelMeanAnomaly_Enter);
			this.labelMeanAnomaly.Leave += new System.EventHandler(this.LabelMeanAnomaly_Leave);
			this.labelMeanAnomaly.MouseEnter += new System.EventHandler(this.LabelMeanAnomaly_Enter);
			this.labelMeanAnomaly.MouseLeave += new System.EventHandler(this.LabelMeanAnomaly_Leave);
			// 
			// labelArgPeri
			// 
			this.labelArgPeri.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelArgPeri.AutoSize = true;
			this.labelArgPeri.Location = new System.Drawing.Point(3, 84);
			this.labelArgPeri.Name = "labelArgPeri";
			this.labelArgPeri.Padding = new System.Windows.Forms.Padding(3);
			this.labelArgPeri.Size = new System.Drawing.Size(240, 21);
			this.labelArgPeri.TabIndex = 14;
			this.labelArgPeri.Text = "Argument of perihelion, J2000.0 (degrees)";
			this.toolTip.SetToolTip(this.labelArgPeri, "Argument of perihelion, J2000.0 (degrees)");
			this.labelArgPeri.Click += new System.EventHandler(this.LabelArgPeri_Click);
			this.labelArgPeri.DoubleClick += new System.EventHandler(this.LabelArgPeri_DoubleClick);
			this.labelArgPeri.Enter += new System.EventHandler(this.LabelArgPeri_Enter);
			this.labelArgPeri.Leave += new System.EventHandler(this.LabelArgPeri_Leave);
			this.labelArgPeri.MouseEnter += new System.EventHandler(this.LabelArgPeri_Enter);
			this.labelArgPeri.MouseLeave += new System.EventHandler(this.LabelArgPeri_Leave);
			// 
			// labelLongAscNode
			// 
			this.labelLongAscNode.AccessibleDescription = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.AccessibleName = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelLongAscNode.AutoSize = true;
			this.labelLongAscNode.Location = new System.Drawing.Point(3, 105);
			this.labelLongAscNode.Name = "labelLongAscNode";
			this.labelLongAscNode.Padding = new System.Windows.Forms.Padding(3);
			this.labelLongAscNode.Size = new System.Drawing.Size(237, 21);
			this.labelLongAscNode.TabIndex = 18;
			this.labelLongAscNode.Text = "Longitude of the ascending node, J2000.0";
			this.toolTip.SetToolTip(this.labelLongAscNode, "Longitude of the ascending node, J2000.0");
			this.labelLongAscNode.Click += new System.EventHandler(this.LabelLongAscNode_Click);
			this.labelLongAscNode.DoubleClick += new System.EventHandler(this.LabelLongAscNode_DoubleClick);
			this.labelLongAscNode.Enter += new System.EventHandler(this.LabelLongAscNode_Enter);
			this.labelLongAscNode.Leave += new System.EventHandler(this.LabelLongAscNode_Leave);
			this.labelLongAscNode.MouseEnter += new System.EventHandler(this.LabelLongAscNode_Enter);
			this.labelLongAscNode.MouseLeave += new System.EventHandler(this.LabelLongAscNode_Leave);
			// 
			// labelIncl
			// 
			this.labelIncl.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelIncl.AutoSize = true;
			this.labelIncl.Location = new System.Drawing.Point(3, 126);
			this.labelIncl.Name = "labelIncl";
			this.labelIncl.Padding = new System.Windows.Forms.Padding(3);
			this.labelIncl.Size = new System.Drawing.Size(251, 21);
			this.labelIncl.TabIndex = 22;
			this.labelIncl.Text = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.toolTip.SetToolTip(this.labelIncl, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.labelIncl.Click += new System.EventHandler(this.LabelIncl_Click);
			this.labelIncl.DoubleClick += new System.EventHandler(this.LabelIncl_DoubleClick);
			this.labelIncl.Enter += new System.EventHandler(this.LabelIncl_Enter);
			this.labelIncl.Leave += new System.EventHandler(this.LabelIncl_Leave);
			this.labelIncl.MouseEnter += new System.EventHandler(this.LabelIncl_Enter);
			this.labelIncl.MouseLeave += new System.EventHandler(this.LabelIncl_Leave);
			// 
			// labelOrbEcc
			// 
			this.labelOrbEcc.AccessibleDescription = "Orbital eccentricity";
			this.labelOrbEcc.AccessibleName = "Orbital eccentricity";
			this.labelOrbEcc.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelOrbEcc.AutoSize = true;
			this.labelOrbEcc.Location = new System.Drawing.Point(3, 147);
			this.labelOrbEcc.Name = "labelOrbEcc";
			this.labelOrbEcc.Padding = new System.Windows.Forms.Padding(3);
			this.labelOrbEcc.Size = new System.Drawing.Size(120, 21);
			this.labelOrbEcc.TabIndex = 26;
			this.labelOrbEcc.Text = "Orbital eccentricity";
			this.toolTip.SetToolTip(this.labelOrbEcc, "Orbital eccentricity");
			this.labelOrbEcc.Click += new System.EventHandler(this.LabelOrbEcc_Click);
			this.labelOrbEcc.DoubleClick += new System.EventHandler(this.LabelOrbEcc_DoubleClick);
			this.labelOrbEcc.Enter += new System.EventHandler(this.LabelOrbEcc_Enter);
			this.labelOrbEcc.Leave += new System.EventHandler(this.LabelOrbEcc_Leave);
			this.labelOrbEcc.MouseEnter += new System.EventHandler(this.LabelOrbEcc_Enter);
			this.labelOrbEcc.MouseLeave += new System.EventHandler(this.LabelOrbEcc_Leave);
			// 
			// labelMotion
			// 
			this.labelMotion.AccessibleDescription = "Mean daily motion (degrees per day)";
			this.labelMotion.AccessibleName = "Mean daily motion (degrees per day)";
			this.labelMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMotion.AutoSize = true;
			this.labelMotion.Location = new System.Drawing.Point(3, 168);
			this.labelMotion.Name = "labelMotion";
			this.labelMotion.Padding = new System.Windows.Forms.Padding(3);
			this.labelMotion.Size = new System.Drawing.Size(213, 21);
			this.labelMotion.TabIndex = 30;
			this.labelMotion.Text = "Mean daily motion (degrees per day)";
			this.toolTip.SetToolTip(this.labelMotion, "Mean daily motion (degrees per day)");
			this.labelMotion.Click += new System.EventHandler(this.LabelMotion_Click);
			this.labelMotion.DoubleClick += new System.EventHandler(this.LabelMotion_DoubleClick);
			this.labelMotion.Enter += new System.EventHandler(this.LabelMotion_Enter);
			this.labelMotion.Leave += new System.EventHandler(this.LabelMotion_Leave);
			this.labelMotion.MouseEnter += new System.EventHandler(this.LabelMotion_Enter);
			this.labelMotion.MouseLeave += new System.EventHandler(this.LabelMotion_Leave);
			// 
			// labelSemiMajorAxis
			// 
			this.labelSemiMajorAxis.AccessibleDescription = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.AccessibleName = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSemiMajorAxis.AutoSize = true;
			this.labelSemiMajorAxis.Location = new System.Drawing.Point(3, 189);
			this.labelSemiMajorAxis.Name = "labelSemiMajorAxis";
			this.labelSemiMajorAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiMajorAxis.Size = new System.Drawing.Size(124, 21);
			this.labelSemiMajorAxis.TabIndex = 34;
			this.labelSemiMajorAxis.Text = "Semimajor axis (AU)";
			this.toolTip.SetToolTip(this.labelSemiMajorAxis, "Semimajor axis (AU)");
			this.labelSemiMajorAxis.Click += new System.EventHandler(this.LabelSemiMajorAxis_Click);
			this.labelSemiMajorAxis.DoubleClick += new System.EventHandler(this.LabelSemiMajorAxis_DoubleClick);
			this.labelSemiMajorAxis.Enter += new System.EventHandler(this.LabelSemiMajorAxis_Enter);
			this.labelSemiMajorAxis.Leave += new System.EventHandler(this.LabelSemiMajorAxis_Leave);
			this.labelSemiMajorAxis.MouseEnter += new System.EventHandler(this.LabelSemiMajorAxis_Enter);
			this.labelSemiMajorAxis.MouseLeave += new System.EventHandler(this.LabelSemiMajorAxis_Leave);
			// 
			// labelRef
			// 
			this.labelRef.AccessibleDescription = "Reference";
			this.labelRef.AccessibleName = "Reference";
			this.labelRef.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRef.AutoSize = true;
			this.labelRef.Location = new System.Drawing.Point(434, 42);
			this.labelRef.Name = "labelRef";
			this.labelRef.Padding = new System.Windows.Forms.Padding(3);
			this.labelRef.Size = new System.Drawing.Size(66, 21);
			this.labelRef.TabIndex = 8;
			this.labelRef.Text = "Reference";
			this.toolTip.SetToolTip(this.labelRef, "Reference");
			this.labelRef.Click += new System.EventHandler(this.LabelRef_Click);
			this.labelRef.DoubleClick += new System.EventHandler(this.LabelRef_DoubleClick);
			this.labelRef.Enter += new System.EventHandler(this.LabelRef_Enter);
			this.labelRef.Leave += new System.EventHandler(this.LabelRef_Leave);
			this.labelRef.MouseEnter += new System.EventHandler(this.LabelRef_Enter);
			this.labelRef.MouseLeave += new System.EventHandler(this.LabelRef_Leave);
			// 
			// labelNumbObs
			// 
			this.labelNumbObs.AccessibleDescription = "Number of observations";
			this.labelNumbObs.AccessibleName = "Number of observations";
			this.labelNumbObs.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNumbObs.AutoSize = true;
			this.labelNumbObs.Location = new System.Drawing.Point(434, 84);
			this.labelNumbObs.Name = "labelNumbObs";
			this.labelNumbObs.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbObs.Size = new System.Drawing.Size(144, 21);
			this.labelNumbObs.TabIndex = 16;
			this.labelNumbObs.Text = "Number of observations";
			this.toolTip.SetToolTip(this.labelNumbObs, "Number of observations");
			this.labelNumbObs.Click += new System.EventHandler(this.LabelNumbObs_Click);
			this.labelNumbObs.DoubleClick += new System.EventHandler(this.LabelNumbObs_DoubleClick);
			this.labelNumbObs.Enter += new System.EventHandler(this.LabelNumbObs_Enter);
			this.labelNumbObs.Leave += new System.EventHandler(this.LabelNumbObs_Leave);
			this.labelNumbObs.MouseEnter += new System.EventHandler(this.LabelNumbObs_Enter);
			this.labelNumbObs.MouseLeave += new System.EventHandler(this.LabelNumbObs_Leave);
			// 
			// labelNumbOppos
			// 
			this.labelNumbOppos.AccessibleDescription = "Number of oppositions";
			this.labelNumbOppos.AccessibleName = "Number of oppositions";
			this.labelNumbOppos.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNumbOppos.AutoSize = true;
			this.labelNumbOppos.Location = new System.Drawing.Point(434, 63);
			this.labelNumbOppos.Name = "labelNumbOppos";
			this.labelNumbOppos.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbOppos.Size = new System.Drawing.Size(138, 21);
			this.labelNumbOppos.TabIndex = 12;
			this.labelNumbOppos.Text = "Number of oppositions";
			this.toolTip.SetToolTip(this.labelNumbOppos, "Number of oppositions");
			this.labelNumbOppos.Click += new System.EventHandler(this.LabelNumbOppos_Click);
			this.labelNumbOppos.DoubleClick += new System.EventHandler(this.LabelNumbOppos_DoubleClick);
			this.labelNumbOppos.Enter += new System.EventHandler(this.LabelNumbOppos_Enter);
			this.labelNumbOppos.Leave += new System.EventHandler(this.LabelNumbOppos_Leave);
			this.labelNumbOppos.MouseEnter += new System.EventHandler(this.LabelNumbOppos_Enter);
			this.labelNumbOppos.MouseLeave += new System.EventHandler(this.LabelNumbOppos_Leave);
			// 
			// labelObsSpan
			// 
			this.labelObsSpan.AccessibleDescription = "Observation span";
			this.labelObsSpan.AccessibleName = "Observation span";
			this.labelObsSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelObsSpan.AutoSize = true;
			this.labelObsSpan.Location = new System.Drawing.Point(434, 105);
			this.labelObsSpan.Name = "labelObsSpan";
			this.labelObsSpan.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsSpan.Size = new System.Drawing.Size(110, 21);
			this.labelObsSpan.TabIndex = 20;
			this.labelObsSpan.Text = "Observation span";
			this.toolTip.SetToolTip(this.labelObsSpan, "Observation span");
			this.labelObsSpan.Click += new System.EventHandler(this.LabelObsSpan_Click);
			this.labelObsSpan.DoubleClick += new System.EventHandler(this.LabelObsSpan_DoubleClick);
			this.labelObsSpan.Enter += new System.EventHandler(this.LabelObsSpan_Enter);
			this.labelObsSpan.Leave += new System.EventHandler(this.LabelObsSpan_Leave);
			this.labelObsSpan.MouseEnter += new System.EventHandler(this.LabelObsSpan_Enter);
			this.labelObsSpan.MouseLeave += new System.EventHandler(this.LabelObsSpan_Leave);
			// 
			// labelRmsResidual
			// 
			this.labelRmsResidual.AccessibleDescription = "r.m.s. residual (\")";
			this.labelRmsResidual.AccessibleName = "r.m.s. residual (\")";
			this.labelRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRmsResidual.AutoSize = true;
			this.labelRmsResidual.Location = new System.Drawing.Point(434, 126);
			this.labelRmsResidual.Name = "labelRmsResidual";
			this.labelRmsResidual.Padding = new System.Windows.Forms.Padding(3);
			this.labelRmsResidual.Size = new System.Drawing.Size(107, 21);
			this.labelRmsResidual.TabIndex = 24;
			this.labelRmsResidual.Text = "r.m.s. residual (\")";
			this.toolTip.SetToolTip(this.labelRmsResidual, "r.m.s residual (\")");
			this.labelRmsResidual.Click += new System.EventHandler(this.LabelRmsResidual_Click);
			this.labelRmsResidual.DoubleClick += new System.EventHandler(this.LabelRmsResidual_DoubleClick);
			this.labelRmsResidual.Enter += new System.EventHandler(this.LabelRmsResidual_Enter);
			this.labelRmsResidual.Leave += new System.EventHandler(this.LabelRmsResidual_Leave);
			this.labelRmsResidual.MouseEnter += new System.EventHandler(this.LabelRmsResidual_Enter);
			this.labelRmsResidual.MouseLeave += new System.EventHandler(this.LabelRmsResidual_Leave);
			// 
			// labelComputerName
			// 
			this.labelComputerName.AccessibleDescription = "Computer name";
			this.labelComputerName.AccessibleName = "Computer name";
			this.labelComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelComputerName.AutoSize = true;
			this.labelComputerName.Location = new System.Drawing.Point(434, 147);
			this.labelComputerName.Name = "labelComputerName";
			this.labelComputerName.Padding = new System.Windows.Forms.Padding(3);
			this.labelComputerName.Size = new System.Drawing.Size(99, 21);
			this.labelComputerName.TabIndex = 28;
			this.labelComputerName.Text = "Computer name";
			this.toolTip.SetToolTip(this.labelComputerName, "Computer name");
			this.labelComputerName.Click += new System.EventHandler(this.LabelComputerName_Click);
			this.labelComputerName.DoubleClick += new System.EventHandler(this.LabelComputerName_DoubleClick);
			this.labelComputerName.Enter += new System.EventHandler(this.LabelComputerName_Enter);
			this.labelComputerName.Leave += new System.EventHandler(this.LabelComputerName_Leave);
			this.labelComputerName.MouseEnter += new System.EventHandler(this.LabelComputerName_Enter);
			this.labelComputerName.MouseLeave += new System.EventHandler(this.LabelComputerName_Leave);
			// 
			// labelDesgnName
			// 
			this.labelDesgnName.AccessibleDescription = "Readable designation";
			this.labelDesgnName.AccessibleName = "Readable designation";
			this.labelDesgnName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDesgnName.AutoSize = true;
			this.labelDesgnName.Location = new System.Drawing.Point(3, 21);
			this.labelDesgnName.Name = "labelDesgnName";
			this.labelDesgnName.Padding = new System.Windows.Forms.Padding(3);
			this.labelDesgnName.Size = new System.Drawing.Size(131, 21);
			this.labelDesgnName.TabIndex = 2;
			this.labelDesgnName.Text = "Readable designation";
			this.toolTip.SetToolTip(this.labelDesgnName, "Readable designation");
			this.labelDesgnName.Click += new System.EventHandler(this.LabelDesgnName_Click);
			this.labelDesgnName.DoubleClick += new System.EventHandler(this.LabelDesgnName_DoubleClick);
			this.labelDesgnName.Enter += new System.EventHandler(this.LabelDesgnName_Enter);
			this.labelDesgnName.Leave += new System.EventHandler(this.LabelDesgnName_Leave);
			this.labelDesgnName.MouseEnter += new System.EventHandler(this.LabelDesgnName_Enter);
			this.labelDesgnName.MouseLeave += new System.EventHandler(this.LabelDesgnName_Leave);
			// 
			// labelObsLastDate
			// 
			this.labelObsLastDate.AccessibleDescription = "Date of last observation";
			this.labelObsLastDate.AccessibleName = "Date of last observation";
			this.labelObsLastDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelObsLastDate.AutoSize = true;
			this.labelObsLastDate.Location = new System.Drawing.Point(434, 189);
			this.labelObsLastDate.Name = "labelObsLastDate";
			this.labelObsLastDate.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsLastDate.Size = new System.Drawing.Size(144, 21);
			this.labelObsLastDate.TabIndex = 36;
			this.labelObsLastDate.Text = "Date of last observation";
			this.toolTip.SetToolTip(this.labelObsLastDate, "Date of last observation");
			this.labelObsLastDate.Click += new System.EventHandler(this.LabelObsLastDate_Click);
			this.labelObsLastDate.DoubleClick += new System.EventHandler(this.LabelObsLastDate_DoubleClick);
			this.labelObsLastDate.Enter += new System.EventHandler(this.LabelObsLastDate_Enter);
			this.labelObsLastDate.Leave += new System.EventHandler(this.LabelObsLastDate_Leave);
			this.labelObsLastDate.MouseEnter += new System.EventHandler(this.LabelObsLastDate_Enter);
			this.labelObsLastDate.MouseLeave += new System.EventHandler(this.LabelObsLastDate_Leave);
			// 
			// labelFlags
			// 
			this.labelFlags.AccessibleDescription = "4-hexdigit flags";
			this.labelFlags.AccessibleName = "4-hexdigit flags";
			this.labelFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelFlags.AutoSize = true;
			this.labelFlags.Location = new System.Drawing.Point(434, 168);
			this.labelFlags.Name = "labelFlags";
			this.labelFlags.Padding = new System.Windows.Forms.Padding(3);
			this.labelFlags.Size = new System.Drawing.Size(97, 21);
			this.labelFlags.TabIndex = 32;
			this.labelFlags.Text = "4-hexdigit flags";
			this.toolTip.SetToolTip(this.labelFlags, "4-hexdigit flags");
			this.labelFlags.Click += new System.EventHandler(this.LabelFlags_Click);
			this.labelFlags.DoubleClick += new System.EventHandler(this.LabelFlags_DoubleClick);
			this.labelFlags.Enter += new System.EventHandler(this.LabelFlags_Enter);
			this.labelFlags.Leave += new System.EventHandler(this.LabelFlags_Leave);
			this.labelFlags.MouseEnter += new System.EventHandler(this.LabelFlags_Enter);
			this.labelFlags.MouseLeave += new System.EventHandler(this.LabelFlags_Leave);
			// 
			// tableLayoutPanelData
			// 
			this.tableLayoutPanelData.AccessibleDescription = "Group the data";
			this.tableLayoutPanelData.AccessibleName = "Table Panel";
			this.tableLayoutPanelData.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelData.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanelData.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanelData.ColumnCount = 4;
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
			this.tableLayoutPanelData.Controls.Add(this.labelIndex, 0, 0);
			this.tableLayoutPanelData.Controls.Add(this.labelDesgnName, 0, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelEpoch, 0, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanAnomaly, 0, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelArgPeri, 0, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelLongAscNode, 0, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelIncl, 0, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelOrbEcc, 0, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelMotion, 0, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelSemiMajorAxis, 0, 9);
			this.tableLayoutPanelData.Controls.Add(this.labelMagAbs, 0, 10);
			this.tableLayoutPanelData.Controls.Add(this.labelSlopeParam, 2, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelDesgnNameValue, 1, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelEpochValue, 1, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanAnomalyValue, 1, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelArgPeriValue, 1, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelLongAscNodeValue, 1, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelInclValue, 1, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelOrbEccValue, 1, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelMotionValue, 1, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelSemiMajorAxisValue, 1, 9);
			this.tableLayoutPanelData.Controls.Add(this.labelSlopeParamValue, 3, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelIndexValue, 1, 0);
			this.tableLayoutPanelData.Controls.Add(this.labelMagAbsValue, 1, 10);
			this.tableLayoutPanelData.Controls.Add(this.labelRef, 2, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelNumbOppos, 2, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelNumbObs, 2, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelObsSpan, 2, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelRmsResidual, 2, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelComputerName, 2, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelFlags, 2, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelRefValue, 3, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelNumbOpposValue, 3, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelNumbObsValue, 3, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelObsSpanValue, 3, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelRmsResidualValue, 3, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelComputerNameValue, 3, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelFlagsValue, 3, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelObsLastDate, 2, 9);
			this.tableLayoutPanelData.Controls.Add(this.labelObsLastDateValue, 3, 9);
			this.tableLayoutPanelData.Location = new System.Drawing.Point(12, 87);
			this.tableLayoutPanelData.Name = "tableLayoutPanelData";
			this.tableLayoutPanelData.RowCount = 11;
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelData.Size = new System.Drawing.Size(723, 235);
			this.tableLayoutPanelData.TabIndex = 12;
			// 
			// labelDesgnNameValue
			// 
			this.labelDesgnNameValue.AccessibleDescription = "Show the information of \"Readable designation\"";
			this.labelDesgnNameValue.AccessibleName = "Show the information of \"Readable designation\"";
			this.labelDesgnNameValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDesgnNameValue.AutoSize = true;
			this.labelDesgnNameValue.Location = new System.Drawing.Point(260, 21);
			this.labelDesgnNameValue.Name = "labelDesgnNameValue";
			this.labelDesgnNameValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelDesgnNameValue.Size = new System.Drawing.Size(22, 21);
			this.labelDesgnNameValue.TabIndex = 3;
			this.labelDesgnNameValue.Text = "...";
			this.toolTip.SetToolTip(this.labelDesgnNameValue, "Show the information of  \"Readable designation\"");
			this.labelDesgnNameValue.DoubleClick += new System.EventHandler(this.LabelDesgnNameValue_DoubleClick);
			this.labelDesgnNameValue.Enter += new System.EventHandler(this.LabelDesgnNameValue_Enter);
			this.labelDesgnNameValue.Leave += new System.EventHandler(this.LabelDesgnNameValue_Leave);
			this.labelDesgnNameValue.MouseEnter += new System.EventHandler(this.LabelDesgnNameValue_Enter);
			this.labelDesgnNameValue.MouseLeave += new System.EventHandler(this.LabelDesgnNameValue_Leave);
			// 
			// labelEpochValue
			// 
			this.labelEpochValue.AccessibleDescription = "Show the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochValue.AccessibleName = "Show the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelEpochValue.AutoSize = true;
			this.labelEpochValue.Location = new System.Drawing.Point(260, 42);
			this.labelEpochValue.Name = "labelEpochValue";
			this.labelEpochValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelEpochValue.Size = new System.Drawing.Size(22, 21);
			this.labelEpochValue.TabIndex = 7;
			this.labelEpochValue.Text = "...";
			this.toolTip.SetToolTip(this.labelEpochValue, "Show the information of \"Epoch (in packed form, .0 TT)\"");
			this.labelEpochValue.DoubleClick += new System.EventHandler(this.LabelEpochValue_DoubleClick);
			this.labelEpochValue.Enter += new System.EventHandler(this.LabelEpochValue_Enter);
			this.labelEpochValue.Leave += new System.EventHandler(this.LabelEpochValue_Leave);
			this.labelEpochValue.MouseEnter += new System.EventHandler(this.LabelEpochValue_Enter);
			this.labelEpochValue.MouseLeave += new System.EventHandler(this.LabelEpochValue_Leave);
			// 
			// labelMeanAnomalyValue
			// 
			this.labelMeanAnomalyValue.AccessibleDescription = "Show the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyValue.AccessibleName = "Show the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMeanAnomalyValue.AutoSize = true;
			this.labelMeanAnomalyValue.Location = new System.Drawing.Point(260, 63);
			this.labelMeanAnomalyValue.Name = "labelMeanAnomalyValue";
			this.labelMeanAnomalyValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelMeanAnomalyValue.Size = new System.Drawing.Size(22, 21);
			this.labelMeanAnomalyValue.TabIndex = 11;
			this.labelMeanAnomalyValue.Text = "...";
			this.toolTip.SetToolTip(this.labelMeanAnomalyValue, "Show the information of \"Mean anomaly at the epoch, in degrees\"");
			this.labelMeanAnomalyValue.DoubleClick += new System.EventHandler(this.LabelMeanAnomalyValue_DoubleClick);
			this.labelMeanAnomalyValue.Enter += new System.EventHandler(this.LabelMeanAnomalyValue_Enter);
			this.labelMeanAnomalyValue.Leave += new System.EventHandler(this.LabelMeanAnomalyValue_Leave);
			this.labelMeanAnomalyValue.MouseEnter += new System.EventHandler(this.LabelMeanAnomalyValue_Enter);
			this.labelMeanAnomalyValue.MouseLeave += new System.EventHandler(this.LabelMeanAnomalyValue_Leave);
			// 
			// labelArgPeriValue
			// 
			this.labelArgPeriValue.AccessibleDescription = "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgPeriValue.AccessibleName = "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgPeriValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelArgPeriValue.AutoSize = true;
			this.labelArgPeriValue.Location = new System.Drawing.Point(260, 84);
			this.labelArgPeriValue.Name = "labelArgPeriValue";
			this.labelArgPeriValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelArgPeriValue.Size = new System.Drawing.Size(22, 21);
			this.labelArgPeriValue.TabIndex = 15;
			this.labelArgPeriValue.Text = "...";
			this.toolTip.SetToolTip(this.labelArgPeriValue, "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"");
			this.labelArgPeriValue.DoubleClick += new System.EventHandler(this.LabelArgPeriValue_DoubleClick);
			this.labelArgPeriValue.Enter += new System.EventHandler(this.LabelArgPeriValue_Enter);
			this.labelArgPeriValue.Leave += new System.EventHandler(this.LabelArgPeriValue_Leave);
			this.labelArgPeriValue.MouseEnter += new System.EventHandler(this.LabelArgPeriValue_Enter);
			this.labelArgPeriValue.MouseLeave += new System.EventHandler(this.LabelArgPeriValue_Leave);
			// 
			// labelLongAscNodeValue
			// 
			this.labelLongAscNodeValue.AccessibleDescription = "Show the information of \"Longitude of the ascending node, J2000.0\"";
			this.labelLongAscNodeValue.AccessibleName = "Show the information of \"Longitude of the ascending node, J2000.0\"";
			this.labelLongAscNodeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelLongAscNodeValue.AutoSize = true;
			this.labelLongAscNodeValue.Location = new System.Drawing.Point(260, 105);
			this.labelLongAscNodeValue.Name = "labelLongAscNodeValue";
			this.labelLongAscNodeValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelLongAscNodeValue.Size = new System.Drawing.Size(22, 21);
			this.labelLongAscNodeValue.TabIndex = 19;
			this.labelLongAscNodeValue.Text = "...";
			this.toolTip.SetToolTip(this.labelLongAscNodeValue, "Show the information of \"Longitude of the ascending node, J2000.0\"");
			this.labelLongAscNodeValue.DoubleClick += new System.EventHandler(this.LabelLongAscNodeValue_DoubleClick);
			this.labelLongAscNodeValue.Enter += new System.EventHandler(this.LabelLongAscNodeValue_Enter);
			this.labelLongAscNodeValue.Leave += new System.EventHandler(this.LabelLongAscNodeValue_Leave);
			this.labelLongAscNodeValue.MouseEnter += new System.EventHandler(this.LabelLongAscNodeValue_Enter);
			this.labelLongAscNodeValue.MouseLeave += new System.EventHandler(this.LabelLongAscNodeValue_Leave);
			// 
			// labelInclValue
			// 
			this.labelInclValue.AccessibleDescription = "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclValue.AccessibleName = "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelInclValue.AutoSize = true;
			this.labelInclValue.Location = new System.Drawing.Point(260, 126);
			this.labelInclValue.Name = "labelInclValue";
			this.labelInclValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelInclValue.Size = new System.Drawing.Size(22, 21);
			this.labelInclValue.TabIndex = 23;
			this.labelInclValue.Text = "...";
			this.toolTip.SetToolTip(this.labelInclValue, "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"");
			this.labelInclValue.DoubleClick += new System.EventHandler(this.LabelInclValue_DoubleClick);
			this.labelInclValue.Enter += new System.EventHandler(this.LabelInclValue_Enter);
			this.labelInclValue.Leave += new System.EventHandler(this.LabelInclValue_Leave);
			this.labelInclValue.MouseEnter += new System.EventHandler(this.LabelInclValue_Enter);
			this.labelInclValue.MouseLeave += new System.EventHandler(this.LabelInclValue_Leave);
			// 
			// labelOrbEccValue
			// 
			this.labelOrbEccValue.AccessibleDescription = "Show the information of \"Orbital eccentricity\"";
			this.labelOrbEccValue.AccessibleName = "Show the information of \"Orbital eccentricity\"";
			this.labelOrbEccValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelOrbEccValue.AutoSize = true;
			this.labelOrbEccValue.Location = new System.Drawing.Point(260, 147);
			this.labelOrbEccValue.Name = "labelOrbEccValue";
			this.labelOrbEccValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelOrbEccValue.Size = new System.Drawing.Size(22, 21);
			this.labelOrbEccValue.TabIndex = 27;
			this.labelOrbEccValue.Text = "...";
			this.toolTip.SetToolTip(this.labelOrbEccValue, "Show the information of \"Orbital eccentricity\"");
			this.labelOrbEccValue.DoubleClick += new System.EventHandler(this.LabelOrbEccValue_DoubleClick);
			this.labelOrbEccValue.Enter += new System.EventHandler(this.LabelOrbEccValue_Enter);
			this.labelOrbEccValue.Leave += new System.EventHandler(this.LabelOrbEccValue_Leave);
			this.labelOrbEccValue.MouseEnter += new System.EventHandler(this.LabelOrbEccValue_Enter);
			this.labelOrbEccValue.MouseLeave += new System.EventHandler(this.LabelOrbEccValue_Leave);
			// 
			// labelMotionValue
			// 
			this.labelMotionValue.AccessibleDescription = "Show the information of \"Mean daily motion (degrees per day)\"";
			this.labelMotionValue.AccessibleName = "Show the information of \"Mean daily motion (degrees per day)\"";
			this.labelMotionValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMotionValue.AutoSize = true;
			this.labelMotionValue.Location = new System.Drawing.Point(260, 168);
			this.labelMotionValue.Name = "labelMotionValue";
			this.labelMotionValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelMotionValue.Size = new System.Drawing.Size(22, 21);
			this.labelMotionValue.TabIndex = 31;
			this.labelMotionValue.Text = "...";
			this.toolTip.SetToolTip(this.labelMotionValue, "Show the information of \"Mean daily motion (degrees per day)\"");
			this.labelMotionValue.DoubleClick += new System.EventHandler(this.LabelMotionValue_DoubleClick);
			this.labelMotionValue.Enter += new System.EventHandler(this.LabelMotionValue_Enter);
			this.labelMotionValue.Leave += new System.EventHandler(this.LabelMotionValue_Leave);
			this.labelMotionValue.MouseEnter += new System.EventHandler(this.LabelMotionValue_Enter);
			this.labelMotionValue.MouseLeave += new System.EventHandler(this.LabelMotionValue_Leave);
			// 
			// labelSemiMajorAxisValue
			// 
			this.labelSemiMajorAxisValue.AccessibleDescription = "Show the information of \"Semimajor axis (AU)\"";
			this.labelSemiMajorAxisValue.AccessibleName = "Show the information of \"Semimajor axis (AU)\"";
			this.labelSemiMajorAxisValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSemiMajorAxisValue.AutoSize = true;
			this.labelSemiMajorAxisValue.Location = new System.Drawing.Point(260, 189);
			this.labelSemiMajorAxisValue.Name = "labelSemiMajorAxisValue";
			this.labelSemiMajorAxisValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiMajorAxisValue.Size = new System.Drawing.Size(22, 21);
			this.labelSemiMajorAxisValue.TabIndex = 35;
			this.labelSemiMajorAxisValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSemiMajorAxisValue, "Show the information of \"Semimajor axis (AU)\"");
			this.labelSemiMajorAxisValue.DoubleClick += new System.EventHandler(this.LabelSemiMajorAxisValue_DoubleClick);
			this.labelSemiMajorAxisValue.Enter += new System.EventHandler(this.LabelSemiMajorAxisValue_Enter);
			this.labelSemiMajorAxisValue.Leave += new System.EventHandler(this.LabelSemiMajorAxisValue_Leave);
			this.labelSemiMajorAxisValue.MouseEnter += new System.EventHandler(this.LabelSemiMajorAxisValue_Enter);
			this.labelSemiMajorAxisValue.MouseLeave += new System.EventHandler(this.LabelSemiMajorAxisValue_Leave);
			// 
			// labelSlopeParamValue
			// 
			this.labelSlopeParamValue.AccessibleDescription = "Show the information of \"Slope parameter, G\"";
			this.labelSlopeParamValue.AccessibleName = "Show the information of \"Slope parameter, G\"";
			this.labelSlopeParamValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSlopeParamValue.AutoSize = true;
			this.labelSlopeParamValue.Location = new System.Drawing.Point(584, 21);
			this.labelSlopeParamValue.Name = "labelSlopeParamValue";
			this.labelSlopeParamValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelSlopeParamValue.Size = new System.Drawing.Size(22, 21);
			this.labelSlopeParamValue.TabIndex = 5;
			this.labelSlopeParamValue.Text = "...";
			this.toolTip.SetToolTip(this.labelSlopeParamValue, "Show the information of \"Slope parameter, G\"");
			this.labelSlopeParamValue.DoubleClick += new System.EventHandler(this.LabelSlopeParamValue_DoubleClick);
			this.labelSlopeParamValue.Enter += new System.EventHandler(this.LabelSlopeParamValue_Enter);
			this.labelSlopeParamValue.Leave += new System.EventHandler(this.LabelSlopeParamValue_Leave);
			this.labelSlopeParamValue.MouseEnter += new System.EventHandler(this.LabelSlopeParamValue_Enter);
			this.labelSlopeParamValue.MouseLeave += new System.EventHandler(this.LabelSlopeParamValue_Leave);
			// 
			// labelIndexValue
			// 
			this.labelIndexValue.AccessibleDescription = "Show the information of \"Index No.\"";
			this.labelIndexValue.AccessibleName = "Show the information of \"Index No.\"";
			this.labelIndexValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelIndexValue.AutoSize = true;
			this.labelIndexValue.Location = new System.Drawing.Point(260, 0);
			this.labelIndexValue.Name = "labelIndexValue";
			this.labelIndexValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelIndexValue.Size = new System.Drawing.Size(22, 21);
			this.labelIndexValue.TabIndex = 1;
			this.labelIndexValue.Text = "...";
			this.toolTip.SetToolTip(this.labelIndexValue, "Show the information of \"Index No.\"");
			this.labelIndexValue.DoubleClick += new System.EventHandler(this.LabelIndexValue_DoubleClick);
			this.labelIndexValue.Enter += new System.EventHandler(this.LabelIndexValue_Enter);
			this.labelIndexValue.Leave += new System.EventHandler(this.LabelIndexValue_Leave);
			this.labelIndexValue.MouseEnter += new System.EventHandler(this.LabelIndexValue_Enter);
			this.labelIndexValue.MouseLeave += new System.EventHandler(this.LabelIndexValue_Leave);
			// 
			// labelMagAbsValue
			// 
			this.labelMagAbsValue.AccessibleDescription = "Show the information of \"Absolute magnitude, H\"";
			this.labelMagAbsValue.AccessibleName = "Show the information of \"Absolute magnitude, H\"";
			this.labelMagAbsValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMagAbsValue.AutoSize = true;
			this.labelMagAbsValue.Location = new System.Drawing.Point(260, 210);
			this.labelMagAbsValue.Name = "labelMagAbsValue";
			this.labelMagAbsValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelMagAbsValue.Size = new System.Drawing.Size(22, 21);
			this.labelMagAbsValue.TabIndex = 39;
			this.labelMagAbsValue.Text = "...";
			this.toolTip.SetToolTip(this.labelMagAbsValue, "Show the information of \"Absolute magnitude, H\"");
			this.labelMagAbsValue.DoubleClick += new System.EventHandler(this.LabelMagAbsValue_DoubleClick);
			this.labelMagAbsValue.Enter += new System.EventHandler(this.LabelMagAbsValue_Enter);
			this.labelMagAbsValue.Leave += new System.EventHandler(this.LabelMagAbsValue_Leave);
			this.labelMagAbsValue.MouseEnter += new System.EventHandler(this.LabelMagAbsValue_Enter);
			this.labelMagAbsValue.MouseLeave += new System.EventHandler(this.LabelMagAbsValue_Leave);
			// 
			// labelRefValue
			// 
			this.labelRefValue.AccessibleDescription = "Show the information of \"Reference\"";
			this.labelRefValue.AccessibleName = "Show the information of \"Reference\"";
			this.labelRefValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRefValue.AutoSize = true;
			this.labelRefValue.Location = new System.Drawing.Point(584, 42);
			this.labelRefValue.Name = "labelRefValue";
			this.labelRefValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelRefValue.Size = new System.Drawing.Size(22, 21);
			this.labelRefValue.TabIndex = 9;
			this.labelRefValue.Text = "...";
			this.toolTip.SetToolTip(this.labelRefValue, "Show the information of \"Reference\"");
			this.labelRefValue.DoubleClick += new System.EventHandler(this.LabelRefValue_DoubleClick);
			this.labelRefValue.Enter += new System.EventHandler(this.LabelRefValue_Enter);
			this.labelRefValue.Leave += new System.EventHandler(this.LabelRefValue_Leave);
			this.labelRefValue.MouseEnter += new System.EventHandler(this.LabelRefValue_Enter);
			this.labelRefValue.MouseLeave += new System.EventHandler(this.LabelRefValue_Leave);
			// 
			// labelNumbOpposValue
			// 
			this.labelNumbOpposValue.AccessibleDescription = "Show the information of \"Number of oppositions\"";
			this.labelNumbOpposValue.AccessibleName = "Show the information of \"Number of oppositions\"";
			this.labelNumbOpposValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNumbOpposValue.AutoSize = true;
			this.labelNumbOpposValue.Location = new System.Drawing.Point(584, 63);
			this.labelNumbOpposValue.Name = "labelNumbOpposValue";
			this.labelNumbOpposValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbOpposValue.Size = new System.Drawing.Size(22, 21);
			this.labelNumbOpposValue.TabIndex = 13;
			this.labelNumbOpposValue.Text = "...";
			this.toolTip.SetToolTip(this.labelNumbOpposValue, "Show the information of \"Number of oppositions\"");
			this.labelNumbOpposValue.DoubleClick += new System.EventHandler(this.LabelNumbOpposValue_DoubleClick);
			this.labelNumbOpposValue.Enter += new System.EventHandler(this.LabelNumbOpposValue_Enter);
			this.labelNumbOpposValue.Leave += new System.EventHandler(this.LabelNumbOpposValue_Leave);
			this.labelNumbOpposValue.MouseEnter += new System.EventHandler(this.LabelNumbOpposValue_Enter);
			this.labelNumbOpposValue.MouseLeave += new System.EventHandler(this.LabelNumbOpposValue_Leave);
			// 
			// labelNumbObsValue
			// 
			this.labelNumbObsValue.AccessibleDescription = "Show the information of \"Number of observations\"";
			this.labelNumbObsValue.AccessibleName = "Show the information of \"Number of observations\"";
			this.labelNumbObsValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNumbObsValue.AutoSize = true;
			this.labelNumbObsValue.Location = new System.Drawing.Point(584, 84);
			this.labelNumbObsValue.Name = "labelNumbObsValue";
			this.labelNumbObsValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbObsValue.Size = new System.Drawing.Size(22, 21);
			this.labelNumbObsValue.TabIndex = 17;
			this.labelNumbObsValue.Text = "...";
			this.toolTip.SetToolTip(this.labelNumbObsValue, "Show the information of \"Number of observations\"");
			this.labelNumbObsValue.DoubleClick += new System.EventHandler(this.LabelNumbObsValue_DoubleClick);
			this.labelNumbObsValue.Enter += new System.EventHandler(this.LabelNumbObsValue_Enter);
			this.labelNumbObsValue.Leave += new System.EventHandler(this.LabelNumbObsValue_Leave);
			this.labelNumbObsValue.MouseEnter += new System.EventHandler(this.LabelNumbObsValue_Enter);
			this.labelNumbObsValue.MouseLeave += new System.EventHandler(this.LabelNumbObsValue_Leave);
			// 
			// labelObsSpanValue
			// 
			this.labelObsSpanValue.AccessibleDescription = "Show the information of \"Observation span\"";
			this.labelObsSpanValue.AccessibleName = "Show the information of \"Observation span\"";
			this.labelObsSpanValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelObsSpanValue.AutoSize = true;
			this.labelObsSpanValue.Location = new System.Drawing.Point(584, 105);
			this.labelObsSpanValue.Name = "labelObsSpanValue";
			this.labelObsSpanValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsSpanValue.Size = new System.Drawing.Size(22, 21);
			this.labelObsSpanValue.TabIndex = 21;
			this.labelObsSpanValue.Text = "...";
			this.toolTip.SetToolTip(this.labelObsSpanValue, "Show the information of \"Observation span\"");
			this.labelObsSpanValue.DoubleClick += new System.EventHandler(this.LabelObsSpanValue_DoubleClick);
			this.labelObsSpanValue.Enter += new System.EventHandler(this.LabelObsSpanValue_Enter);
			this.labelObsSpanValue.Leave += new System.EventHandler(this.LabelObsSpanValue_Leave);
			this.labelObsSpanValue.MouseEnter += new System.EventHandler(this.LabelObsSpanValue_Enter);
			this.labelObsSpanValue.MouseLeave += new System.EventHandler(this.LabelObsSpanValue_Leave);
			// 
			// labelRmsResidualValue
			// 
			this.labelRmsResidualValue.AccessibleDescription = "Show the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualValue.AccessibleName = "Show the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRmsResidualValue.AutoSize = true;
			this.labelRmsResidualValue.Location = new System.Drawing.Point(584, 126);
			this.labelRmsResidualValue.Name = "labelRmsResidualValue";
			this.labelRmsResidualValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelRmsResidualValue.Size = new System.Drawing.Size(22, 21);
			this.labelRmsResidualValue.TabIndex = 25;
			this.labelRmsResidualValue.Text = "...";
			this.toolTip.SetToolTip(this.labelRmsResidualValue, "Show the information of \"r.m.s residual (\")\"");
			this.labelRmsResidualValue.DoubleClick += new System.EventHandler(this.LabelRmsResidualValue_DoubleClick);
			this.labelRmsResidualValue.Enter += new System.EventHandler(this.LabelRmsResidualValue_Enter);
			this.labelRmsResidualValue.Leave += new System.EventHandler(this.LabelRmsResidualValue_Leave);
			this.labelRmsResidualValue.MouseEnter += new System.EventHandler(this.LabelRmsResidualValue_Enter);
			this.labelRmsResidualValue.MouseLeave += new System.EventHandler(this.LabelRmsResidualValue_Leave);
			// 
			// labelComputerNameValue
			// 
			this.labelComputerNameValue.AccessibleDescription = "Show the information of \"Computer name\"";
			this.labelComputerNameValue.AccessibleName = "Show the information of \"Computer name\"";
			this.labelComputerNameValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelComputerNameValue.AutoSize = true;
			this.labelComputerNameValue.Location = new System.Drawing.Point(584, 147);
			this.labelComputerNameValue.Name = "labelComputerNameValue";
			this.labelComputerNameValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelComputerNameValue.Size = new System.Drawing.Size(22, 21);
			this.labelComputerNameValue.TabIndex = 29;
			this.labelComputerNameValue.Text = "...";
			this.toolTip.SetToolTip(this.labelComputerNameValue, "Show the information of \"Computer name\"");
			this.labelComputerNameValue.DoubleClick += new System.EventHandler(this.LabelComputerNameValue_DoubleClick);
			this.labelComputerNameValue.Enter += new System.EventHandler(this.LabelComputerNameValue_Enter);
			this.labelComputerNameValue.Leave += new System.EventHandler(this.LabelComputerNameValue_Leave);
			this.labelComputerNameValue.MouseEnter += new System.EventHandler(this.LabelComputerNameValue_Enter);
			this.labelComputerNameValue.MouseLeave += new System.EventHandler(this.LabelComputerNameValue_Leave);
			// 
			// labelFlagsValue
			// 
			this.labelFlagsValue.AccessibleDescription = "Show the information of \"4-hexdigit flags\"";
			this.labelFlagsValue.AccessibleName = "Show the information of \"4-hexdigit flags\"";
			this.labelFlagsValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelFlagsValue.AutoSize = true;
			this.labelFlagsValue.Location = new System.Drawing.Point(584, 168);
			this.labelFlagsValue.Name = "labelFlagsValue";
			this.labelFlagsValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelFlagsValue.Size = new System.Drawing.Size(22, 21);
			this.labelFlagsValue.TabIndex = 33;
			this.labelFlagsValue.Text = "...";
			this.toolTip.SetToolTip(this.labelFlagsValue, "Show the information of \"4-hexdigit flags\"");
			this.labelFlagsValue.DoubleClick += new System.EventHandler(this.LabelFlagsValue_DoubleClick);
			this.labelFlagsValue.Enter += new System.EventHandler(this.LabelFlagsValue_Enter);
			this.labelFlagsValue.Leave += new System.EventHandler(this.LabelFlagsValue_Leave);
			this.labelFlagsValue.MouseEnter += new System.EventHandler(this.LabelFlagsValue_Enter);
			this.labelFlagsValue.MouseLeave += new System.EventHandler(this.LabelFlagsValue_Leave);
			// 
			// labelObsLastDateValue
			// 
			this.labelObsLastDateValue.AccessibleDescription = "Show the information of \"Date of last observation\"";
			this.labelObsLastDateValue.AccessibleName = "Show the information of \"Date of last observation\"";
			this.labelObsLastDateValue.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelObsLastDateValue.AutoSize = true;
			this.labelObsLastDateValue.Location = new System.Drawing.Point(584, 189);
			this.labelObsLastDateValue.Name = "labelObsLastDateValue";
			this.labelObsLastDateValue.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsLastDateValue.Size = new System.Drawing.Size(22, 21);
			this.labelObsLastDateValue.TabIndex = 37;
			this.labelObsLastDateValue.Text = "...";
			this.toolTip.SetToolTip(this.labelObsLastDateValue, "Show the information of \"Date of last observation\"");
			this.labelObsLastDateValue.DoubleClick += new System.EventHandler(this.LabelObsLastDateValue_DoubleClick);
			this.labelObsLastDateValue.Enter += new System.EventHandler(this.LabelObsLastDateValue_Enter);
			this.labelObsLastDateValue.Leave += new System.EventHandler(this.LabelObsLastDateValue_Leave);
			this.labelObsLastDateValue.MouseEnter += new System.EventHandler(this.LabelObsLastDateValue_Enter);
			this.labelObsLastDateValue.MouseLeave += new System.EventHandler(this.LabelObsLastDateValue_Leave);
			// 
			// numericUpDownGotoIndex
			// 
			this.numericUpDownGotoIndex.AccessibleDescription = "Enter the index no. of the planetoid";
			this.numericUpDownGotoIndex.AccessibleName = "Index field";
			this.numericUpDownGotoIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownGotoIndex.Location = new System.Drawing.Point(620, 5);
			this.numericUpDownGotoIndex.Name = "numericUpDownGotoIndex";
			this.numericUpDownGotoIndex.Size = new System.Drawing.Size(78, 23);
			this.numericUpDownGotoIndex.TabIndex = 8;
			this.numericUpDownGotoIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.numericUpDownGotoIndex, "Enter the index no. of the planetoid");
			// 
			// labelIndexPos
			// 
			this.labelIndexPos.AccessibleDescription = "Show the current index position";
			this.labelIndexPos.AccessibleName = "Index-Info";
			this.labelIndexPos.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelIndexPos.AutoSize = true;
			this.labelIndexPos.BackColor = System.Drawing.SystemColors.Control;
			this.labelIndexPos.Location = new System.Drawing.Point(295, 9);
			this.labelIndexPos.Name = "labelIndexPos";
			this.labelIndexPos.Size = new System.Drawing.Size(52, 15);
			this.labelIndexPos.TabIndex = 6;
			this.labelIndexPos.Text = "Index: ...";
			this.toolTip.SetToolTip(this.labelIndexPos, "Show the current index position");
			this.labelIndexPos.Enter += new System.EventHandler(this.LabelIndexPos_Enter);
			this.labelIndexPos.Leave += new System.EventHandler(this.LabelIndexPos_Leave);
			this.labelIndexPos.MouseEnter += new System.EventHandler(this.LabelIndexPos_Enter);
			this.labelIndexPos.MouseLeave += new System.EventHandler(this.LabelIndexPos_Leave);
			// 
			// trackBarIndex
			// 
			this.trackBarIndex.AccessibleDescription = "Shift to navigate in the data";
			this.trackBarIndex.AccessibleName = "Index range";
			this.trackBarIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
			this.trackBarIndex.LargeChange = 100;
			this.trackBarIndex.Location = new System.Drawing.Point(12, 35);
			this.trackBarIndex.Maximum = 1000;
			this.trackBarIndex.Name = "trackBarIndex";
			this.trackBarIndex.Size = new System.Drawing.Size(723, 45);
			this.trackBarIndex.TabIndex = 11;
			this.trackBarIndex.TickFrequency = 1000;
			this.trackBarIndex.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.trackBarIndex, "Shift to navigate in the data");
			this.trackBarIndex.Value = 1;
			this.trackBarIndex.Scroll += new System.EventHandler(this.TrackBarIndex_Scroll);
			this.trackBarIndex.Enter += new System.EventHandler(this.TrackBarIndex_MouseEnter);
			this.trackBarIndex.Leave += new System.EventHandler(this.TrackBarIndex_MouseLeave);
			this.trackBarIndex.MouseEnter += new System.EventHandler(this.TrackBarIndex_MouseEnter);
			this.trackBarIndex.MouseLeave += new System.EventHandler(this.TrackBarIndex_MouseLeave);
			// 
			// buttonGotoIndex
			// 
			this.buttonGotoIndex.AccessibleDescription = "Click to show the data of the planetoid";
			this.buttonGotoIndex.AccessibleName = "Go to index";
			this.buttonGotoIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonGotoIndex.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.buttonGotoIndex.Location = new System.Drawing.Point(704, 3);
			this.buttonGotoIndex.Name = "buttonGotoIndex";
			this.buttonGotoIndex.Size = new System.Drawing.Size(29, 26);
			this.buttonGotoIndex.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonGotoIndex, "Click to show the data of the planetoid");
			this.buttonGotoIndex.UseVisualStyleBackColor = true;
			this.buttonGotoIndex.Click += new System.EventHandler(this.ButtonGotoIndex_Click);
			this.buttonGotoIndex.Enter += new System.EventHandler(this.ButtonGotoIndex_Enter);
			this.buttonGotoIndex.Leave += new System.EventHandler(this.ButtonGotoIndex_Leave);
			this.buttonGotoIndex.MouseEnter += new System.EventHandler(this.ButtonGotoIndex_Enter);
			this.buttonGotoIndex.MouseLeave += new System.EventHandler(this.ButtonGotoIndex_Leave);
			// 
			// buttonStepForward
			// 
			this.buttonStepForward.AccessibleDescription = "Navigate some data after";
			this.buttonStepForward.AccessibleName = "Navigate some data after";
			this.buttonStepForward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepForward.ContextMenuStrip = this.contextMenuNavigationStep;
			this.buttonStepForward.Image = global::Planetoid_DB.Properties.Resources.silk_forward_green;
			this.buttonStepForward.Location = new System.Drawing.Point(152, 3);
			this.buttonStepForward.Name = "buttonStepForward";
			this.buttonStepForward.Size = new System.Drawing.Size(29, 26);
			this.buttonStepForward.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonStepForward, "Navigate some data after");
			this.buttonStepForward.UseVisualStyleBackColor = true;
			this.buttonStepForward.Click += new System.EventHandler(this.ButtonStepForward_Click);
			this.buttonStepForward.Enter += new System.EventHandler(this.ButtonStepForward_Enter);
			this.buttonStepForward.Leave += new System.EventHandler(this.ButtonStepForward_Leave);
			this.buttonStepForward.MouseEnter += new System.EventHandler(this.ButtonStepForward_Enter);
			this.buttonStepForward.MouseLeave += new System.EventHandler(this.ButtonStepForward_Leave);
			// 
			// buttonStepToEnd
			// 
			this.buttonStepToEnd.AccessibleDescription = "Navigate to the end of the data";
			this.buttonStepToEnd.AccessibleName = "End of the data";
			this.buttonStepToEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepToEnd.Image = global::Planetoid_DB.Properties.Resources.silk_forward_end_green;
			this.buttonStepToEnd.Location = new System.Drawing.Point(187, 3);
			this.buttonStepToEnd.Name = "buttonStepToEnd";
			this.buttonStepToEnd.Size = new System.Drawing.Size(29, 26);
			this.buttonStepToEnd.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonStepToEnd, "Navigate to the end of the dataset");
			this.buttonStepToEnd.UseVisualStyleBackColor = true;
			this.buttonStepToEnd.Click += new System.EventHandler(this.ButtonStepToEnd_Click);
			this.buttonStepToEnd.Enter += new System.EventHandler(this.ButtonStepToEnd_Enter);
			this.buttonStepToEnd.Leave += new System.EventHandler(this.ButtonStepToEnd_Leave);
			this.buttonStepToEnd.MouseEnter += new System.EventHandler(this.ButtonStepToEnd_Enter);
			this.buttonStepToEnd.MouseLeave += new System.EventHandler(this.ButtonStepToEnd_Leave);
			// 
			// buttonStepForward1
			// 
			this.buttonStepForward1.AccessibleDescription = "Navigate to the next datafield";
			this.buttonStepForward1.AccessibleName = "Navigate to the next datafield";
			this.buttonStepForward1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepForward1.Image = global::Planetoid_DB.Properties.Resources.silk_forward_1_green;
			this.buttonStepForward1.Location = new System.Drawing.Point(117, 3);
			this.buttonStepForward1.Name = "buttonStepForward1";
			this.buttonStepForward1.Size = new System.Drawing.Size(29, 26);
			this.buttonStepForward1.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonStepForward1, "Navigate to the next datafield");
			this.buttonStepForward1.UseVisualStyleBackColor = true;
			this.buttonStepForward1.Click += new System.EventHandler(this.ButtonStepForward1_Click);
			this.buttonStepForward1.Enter += new System.EventHandler(this.ButtonStepForward1_Enter);
			this.buttonStepForward1.Leave += new System.EventHandler(this.ButtonStepForward1_Leave);
			this.buttonStepForward1.MouseEnter += new System.EventHandler(this.ButtonStepForward1_Enter);
			this.buttonStepForward1.MouseLeave += new System.EventHandler(this.ButtonStepForward1_Leave);
			// 
			// buttonStepBackward1
			// 
			this.buttonStepBackward1.AccessibleDescription = "Navigate to the previous datafield";
			this.buttonStepBackward1.AccessibleName = "Navigate to the previous datafield";
			this.buttonStepBackward1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepBackward1.Image = global::Planetoid_DB.Properties.Resources.silk_backward_1_green;
			this.buttonStepBackward1.Location = new System.Drawing.Point(82, 3);
			this.buttonStepBackward1.Name = "buttonStepBackward1";
			this.buttonStepBackward1.Size = new System.Drawing.Size(29, 26);
			this.buttonStepBackward1.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonStepBackward1, "Navigate to the previous datafield");
			this.buttonStepBackward1.UseVisualStyleBackColor = true;
			this.buttonStepBackward1.Click += new System.EventHandler(this.ButtonStepBackward1_Click);
			this.buttonStepBackward1.Enter += new System.EventHandler(this.ButtonStepBackward1_Enter);
			this.buttonStepBackward1.Leave += new System.EventHandler(this.ButtonStepBackward1_Leave);
			this.buttonStepBackward1.MouseEnter += new System.EventHandler(this.ButtonStepBackward1_Enter);
			this.buttonStepBackward1.MouseLeave += new System.EventHandler(this.ButtonStepBackward1_Leave);
			// 
			// buttonStepBackward
			// 
			this.buttonStepBackward.AccessibleDescription = "Navigate some data before";
			this.buttonStepBackward.AccessibleName = "Navigate some data before";
			this.buttonStepBackward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepBackward.ContextMenuStrip = this.contextMenuNavigationStep;
			this.buttonStepBackward.Image = global::Planetoid_DB.Properties.Resources.silk_backward_green;
			this.buttonStepBackward.Location = new System.Drawing.Point(47, 3);
			this.buttonStepBackward.Name = "buttonStepBackward";
			this.buttonStepBackward.Size = new System.Drawing.Size(29, 26);
			this.buttonStepBackward.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonStepBackward, "Navigate some data before");
			this.buttonStepBackward.UseVisualStyleBackColor = true;
			this.buttonStepBackward.Click += new System.EventHandler(this.ButtonStepBackward_Click);
			this.buttonStepBackward.Enter += new System.EventHandler(this.ButtonStepBackward_Enter);
			this.buttonStepBackward.Leave += new System.EventHandler(this.ButtonStepBackward_Leave);
			this.buttonStepBackward.MouseEnter += new System.EventHandler(this.ButtonStepBackward_Enter);
			this.buttonStepBackward.MouseLeave += new System.EventHandler(this.ButtonStepBackward_Leave);
			// 
			// buttonStepToBegin
			// 
			this.buttonStepToBegin.AccessibleDescription = "Navigate to the begin of the data";
			this.buttonStepToBegin.AccessibleName = "Begin of the data";
			this.buttonStepToBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStepToBegin.Image = global::Planetoid_DB.Properties.Resources.silk_backward_end_green;
			this.buttonStepToBegin.Location = new System.Drawing.Point(12, 3);
			this.buttonStepToBegin.Name = "buttonStepToBegin";
			this.buttonStepToBegin.Size = new System.Drawing.Size(29, 26);
			this.buttonStepToBegin.TabIndex = 0;
			this.toolTip.SetToolTip(this.buttonStepToBegin, "Navigate to the begin of the data");
			this.buttonStepToBegin.UseVisualStyleBackColor = true;
			this.buttonStepToBegin.Click += new System.EventHandler(this.ButtonStepToBegin_Click);
			this.buttonStepToBegin.Enter += new System.EventHandler(this.ButtonStepToBegin_Enter);
			this.buttonStepToBegin.Leave += new System.EventHandler(this.ButtonStepToBegin_Leave);
			this.buttonStepToBegin.MouseEnter += new System.EventHandler(this.ButtonStepToBegin_Enter);
			this.buttonStepToBegin.MouseLeave += new System.EventHandler(this.ButtonStepToBegin_Leave);
			// 
			// statusBar
			// 
			this.statusBar.AccessibleDescription = "Shows some information";
			this.statusBar.AccessibleName = "Status bar of some information";
			this.statusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
			this.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUpdate,
            this.toolStripStatusLabelBackgroundDownload,
            this.toolStripProgressBarBackgroundDownload,
            this.toolStripStatusLabelCancelBackgroundDownload,
            this.labelHelp});
			this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusBar.Location = new System.Drawing.Point(0, 0);
			this.statusBar.Name = "statusBar";
			this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusBar.ShowItemToolTips = true;
			this.statusBar.Size = new System.Drawing.Size(744, 22);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 13;
			this.statusBar.TabStop = true;
			this.statusBar.Text = "statusStrip";
			// 
			// toolStripStatusLabelUpdate
			// 
			this.toolStripStatusLabelUpdate.AccessibleDescription = "Show that an MPCORB.DAT update is aviable";
			this.toolStripStatusLabelUpdate.AccessibleName = "Update information";
			this.toolStripStatusLabelUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.toolStripStatusLabelUpdate.AutoToolTip = true;
			this.toolStripStatusLabelUpdate.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.toolStripStatusLabelUpdate.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.toolStripStatusLabelUpdate.Name = "toolStripStatusLabelUpdate";
			this.toolStripStatusLabelUpdate.Size = new System.Drawing.Size(186, 16);
			this.toolStripStatusLabelUpdate.Text = "MPCORB.DAT update available";
			this.toolStripStatusLabelUpdate.ToolTipText = "MPCORB.DAT update aviable";
			this.toolStripStatusLabelUpdate.Click += new System.EventHandler(this.ToolStripStatusLabelUpdate_Click);
			this.toolStripStatusLabelUpdate.MouseEnter += new System.EventHandler(this.ToolStripStatusLabelUpdate_MouseEnter);
			this.toolStripStatusLabelUpdate.MouseLeave += new System.EventHandler(this.ToolStripStatusLabelUpdate_MouseLeave);
			// 
			// toolStripStatusLabelBackgroundDownload
			// 
			this.toolStripStatusLabelBackgroundDownload.AccessibleDescription = "Show the download progres";
			this.toolStripStatusLabelBackgroundDownload.AccessibleName = "Download progress";
			this.toolStripStatusLabelBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.toolStripStatusLabelBackgroundDownload.AutoToolTip = true;
			this.toolStripStatusLabelBackgroundDownload.Image = global::Planetoid_DB.Properties.Resources.silk_package_go;
			this.toolStripStatusLabelBackgroundDownload.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.toolStripStatusLabelBackgroundDownload.Name = "toolStripStatusLabelBackgroundDownload";
			this.toolStripStatusLabelBackgroundDownload.Size = new System.Drawing.Size(80, 16);
			this.toolStripStatusLabelBackgroundDownload.Text = "Download:";
			this.toolStripStatusLabelBackgroundDownload.ToolTipText = "Show the download progres";
			this.toolStripStatusLabelBackgroundDownload.DoubleClick += new System.EventHandler(this.ToolStripStatusLabelBackgroundDownload_DoubleClick);
			this.toolStripStatusLabelBackgroundDownload.MouseEnter += new System.EventHandler(this.ToolStripStatusLabelBackgroundDownload_MouseEnter);
			this.toolStripStatusLabelBackgroundDownload.MouseLeave += new System.EventHandler(this.ToolStripStatusLabelBackgroundDownload_MouseLeave);
			// 
			// toolStripProgressBarBackgroundDownload
			// 
			this.toolStripProgressBarBackgroundDownload.AccessibleDescription = "Show the download progres";
			this.toolStripProgressBarBackgroundDownload.AccessibleName = "Download progress";
			this.toolStripProgressBarBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.toolStripProgressBarBackgroundDownload.AutoToolTip = true;
			this.toolStripProgressBarBackgroundDownload.Enabled = false;
			this.toolStripProgressBarBackgroundDownload.Name = "toolStripProgressBarBackgroundDownload";
			this.toolStripProgressBarBackgroundDownload.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBarBackgroundDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.toolStripProgressBarBackgroundDownload.ToolTipText = "Show the download progres";
			this.toolStripProgressBarBackgroundDownload.DoubleClick += new System.EventHandler(this.ToolStripProgressBarBackgroundDownload_DoubleClick);
			this.toolStripProgressBarBackgroundDownload.MouseEnter += new System.EventHandler(this.ToolStripProgressBarBackgroundDownload_MouseEnter);
			this.toolStripProgressBarBackgroundDownload.MouseLeave += new System.EventHandler(this.ToolStripProgressBarBackgroundDownload_MouseLeave);
			// 
			// toolStripStatusLabelCancelBackgroundDownload
			// 
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleDescription = "Cancel the background download";
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleName = "Cancel download";
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.toolStripStatusLabelCancelBackgroundDownload.AutoToolTip = true;
			this.toolStripStatusLabelCancelBackgroundDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStatusLabelCancelBackgroundDownload.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.toolStripStatusLabelCancelBackgroundDownload.Name = "toolStripStatusLabelCancelBackgroundDownload";
			this.toolStripStatusLabelCancelBackgroundDownload.Size = new System.Drawing.Size(16, 16);
			this.toolStripStatusLabelCancelBackgroundDownload.Text = "Cancel background download";
			this.toolStripStatusLabelCancelBackgroundDownload.Click += new System.EventHandler(this.ToolStripStatusLabelCancelBackgroundDownload_Click);
			this.toolStripStatusLabelCancelBackgroundDownload.MouseEnter += new System.EventHandler(this.ToolStripStatusLabelCancelBackgroundDownload_MouseEnter);
			this.toolStripStatusLabelCancelBackgroundDownload.MouseLeave += new System.EventHandler(this.ToolStripStatusLabelCancelBackgroundDownload_MouseLeave);
			// 
			// labelHelp
			// 
			this.labelHelp.AccessibleDescription = "Show some information";
			this.labelHelp.AccessibleName = "Show some information";
			this.labelHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelHelp.AutoToolTip = true;
			this.labelHelp.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelHelp.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(116, 16);
			this.labelHelp.Text = "Show tooltip here";
			this.labelHelp.ToolTipText = "Show some information";
			// 
			// menu
			// 
			this.menu.AccessibleDescription = "Show the menubar";
			this.menu.AccessibleName = "menu";
			this.menu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.menu.Dock = System.Windows.Forms.DockStyle.None;
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemFile,
            this.menuitemEdit,
            this.menuitemOptions,
            this.menuitemQuest});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(744, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menu";
			// 
			// menuitemFile
			// 
			this.menuitemFile.AccessibleDescription = "Open the menu \"file\"";
			this.menuitemFile.AccessibleName = "File";
			this.menuitemFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemFile.AutoToolTip = true;
			this.menuitemFile.DoubleClickEnabled = true;
			this.menuitemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPrint,
            this.menuitemExit});
			this.menuitemFile.Name = "menuitemFile";
			this.menuitemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.menuitemFile.Size = new System.Drawing.Size(37, 20);
			this.menuitemFile.Text = "&File";
			this.menuitemFile.ToolTipText = "Open the menu \"file\"";
			this.menuitemFile.MouseEnter += new System.EventHandler(this.MenuitemFile_MouseEnter);
			this.menuitemFile.MouseLeave += new System.EventHandler(this.MenuitemFile_MouseLeave);
			// 
			// toolStripMenuItemPrint
			// 
			this.toolStripMenuItemPrint.AccessibleDescription = "Print the information";
			this.toolStripMenuItemPrint.AccessibleName = "Print";
			this.toolStripMenuItemPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemPrint.AutoToolTip = true;
			this.toolStripMenuItemPrint.DoubleClickEnabled = true;
			this.toolStripMenuItemPrint.Enabled = false;
			this.toolStripMenuItemPrint.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
			this.toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
			this.toolStripMenuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.toolStripMenuItemPrint.Size = new System.Drawing.Size(136, 22);
			this.toolStripMenuItemPrint.Text = "&Print";
			this.toolStripMenuItemPrint.Click += new System.EventHandler(this.ToolStripMenuItemPrint_Click);
			this.toolStripMenuItemPrint.MouseEnter += new System.EventHandler(this.ToolStripMenuItemPrint_MouseEnter);
			this.toolStripMenuItemPrint.MouseLeave += new System.EventHandler(this.ToolStripMenuItemPrint_MouseLeave);
			// 
			// menuitemExit
			// 
			this.menuitemExit.AccessibleDescription = "Exit the application";
			this.menuitemExit.AccessibleName = "Exit";
			this.menuitemExit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExit.AutoToolTip = true;
			this.menuitemExit.DoubleClickEnabled = true;
			this.menuitemExit.Image = global::Planetoid_DB.Properties.Resources.silk_door_in;
			this.menuitemExit.Name = "menuitemExit";
			this.menuitemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.menuitemExit.Size = new System.Drawing.Size(136, 22);
			this.menuitemExit.Text = "E&xit";
			this.menuitemExit.ToolTipText = "Exit the application";
			this.menuitemExit.Click += new System.EventHandler(this.MenuitemExit_Click);
			this.menuitemExit.MouseEnter += new System.EventHandler(this.MenuitemExit_MouseEnter);
			this.menuitemExit.MouseLeave += new System.EventHandler(this.MenuitemExit_MouseLeave);
			// 
			// menuitemEdit
			// 
			this.menuitemEdit.AccessibleDescription = "Open the menu \"edit\"";
			this.menuitemEdit.AccessibleName = "Edit";
			this.menuitemEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemEdit.AutoToolTip = true;
			this.menuitemEdit.DoubleClickEnabled = true;
			this.menuitemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopytoClipboard,
            this.toolStripMenuItemSearch});
			this.menuitemEdit.Name = "menuitemEdit";
			this.menuitemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
			this.menuitemEdit.Size = new System.Drawing.Size(39, 20);
			this.menuitemEdit.Text = "&Edit";
			this.menuitemEdit.ToolTipText = "Open the menu \"edit\"";
			this.menuitemEdit.MouseEnter += new System.EventHandler(this.MenuitemEdit_MouseEnter);
			this.menuitemEdit.MouseLeave += new System.EventHandler(this.MenuitemEdit_MouseLeave);
			// 
			// toolStripMenuItemCopytoClipboard
			// 
			this.toolStripMenuItemCopytoClipboard.AccessibleDescription = "Copy to clipboard";
			this.toolStripMenuItemCopytoClipboard.AccessibleName = "Copy to clipboard";
			this.toolStripMenuItemCopytoClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopytoClipboard.AutoToolTip = true;
			this.toolStripMenuItemCopytoClipboard.DoubleClickEnabled = true;
			this.toolStripMenuItemCopytoClipboard.Enabled = false;
			this.toolStripMenuItemCopytoClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.toolStripMenuItemCopytoClipboard.Name = "toolStripMenuItemCopytoClipboard";
			this.toolStripMenuItemCopytoClipboard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.toolStripMenuItemCopytoClipboard.Size = new System.Drawing.Size(140, 22);
			this.toolStripMenuItemCopytoClipboard.Text = "Copy";
			this.toolStripMenuItemCopytoClipboard.ToolTipText = "Copy to clipboard";
			this.toolStripMenuItemCopytoClipboard.Click += new System.EventHandler(this.ToolStripMenuItemCopytoClipboard_Click);
			this.toolStripMenuItemCopytoClipboard.MouseEnter += new System.EventHandler(this.ToolStripMenuItemCopytoClipboard_MouseEnter);
			this.toolStripMenuItemCopytoClipboard.MouseLeave += new System.EventHandler(this.ToolStripMenuItemCopytoClipboard_MouseLeave);
			// 
			// toolStripMenuItemSearch
			// 
			this.toolStripMenuItemSearch.AccessibleDescription = "Search";
			this.toolStripMenuItemSearch.AccessibleName = "Search";
			this.toolStripMenuItemSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemSearch.AutoToolTip = true;
			this.toolStripMenuItemSearch.DoubleClickEnabled = true;
			this.toolStripMenuItemSearch.Enabled = false;
			this.toolStripMenuItemSearch.Image = global::Planetoid_DB.Properties.Resources.silk_magnifier;
			this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
			this.toolStripMenuItemSearch.Size = new System.Drawing.Size(140, 22);
			this.toolStripMenuItemSearch.Text = "Search";
			this.toolStripMenuItemSearch.Click += new System.EventHandler(this.ToolStripMenuItemSearch_Click);
			this.toolStripMenuItemSearch.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSearch_MouseEnter);
			this.toolStripMenuItemSearch.MouseLeave += new System.EventHandler(this.ToolStripMenuItemSearch_MouseLeave);
			// 
			// menuitemOptions
			// 
			this.menuitemOptions.AccessibleDescription = "Open the menu \"options\"";
			this.menuitemOptions.AccessibleName = "Options";
			this.menuitemOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemOptions.AutoToolTip = true;
			this.menuitemOptions.DoubleClickEnabled = true;
			this.menuitemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDatabaseInformation,
            this.toolStripMenuItemTableMode,
            this.toolStripSeparatorOptions1,
            this.chartBarToolStripMenuItem,
            this.chartCurveToolStripMenuItem,
            this.chartPieToolStripMenuItem,
            this.toolStripSeparatorOptions2,
            this.menuitemCheckMpcorbDat,
            this.menuitemDownloadMpcorbDat,
            this.toolStripSeparatorOptions3,
            this.ToolStripMenuItemStyle});
			this.menuitemOptions.Name = "menuitemOptions";
			this.menuitemOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.menuitemOptions.Size = new System.Drawing.Size(61, 20);
			this.menuitemOptions.Text = "&Options";
			this.menuitemOptions.ToolTipText = "Open the menu \"options\"";
			this.menuitemOptions.MouseEnter += new System.EventHandler(this.MenuitemOptions_MouseEnter);
			this.menuitemOptions.MouseLeave += new System.EventHandler(this.MenuitemOptions_MouseLeave);
			// 
			// toolStripMenuItemDatabaseInformation
			// 
			this.toolStripMenuItemDatabaseInformation.AccessibleDescription = "Show the information of the MPCORB.DAT databbase";
			this.toolStripMenuItemDatabaseInformation.AccessibleName = "Database information";
			this.toolStripMenuItemDatabaseInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemDatabaseInformation.AutoToolTip = true;
			this.toolStripMenuItemDatabaseInformation.DoubleClickEnabled = true;
			this.toolStripMenuItemDatabaseInformation.Image = global::Planetoid_DB.Properties.Resources.silk_database;
			this.toolStripMenuItemDatabaseInformation.Name = "toolStripMenuItemDatabaseInformation";
			this.toolStripMenuItemDatabaseInformation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
			this.toolStripMenuItemDatabaseInformation.Size = new System.Drawing.Size(243, 22);
			this.toolStripMenuItemDatabaseInformation.Text = "Database information";
			this.toolStripMenuItemDatabaseInformation.Click += new System.EventHandler(this.ToolStripMenuItemDatabaseInformation_Click);
			this.toolStripMenuItemDatabaseInformation.MouseEnter += new System.EventHandler(this.ToolStripMenuItemDatabaseInformation_MouseEnter);
			this.toolStripMenuItemDatabaseInformation.MouseLeave += new System.EventHandler(this.ToolStripMenuItemDatabaseInformation_MouseLeave);
			// 
			// toolStripMenuItemTableMode
			// 
			this.toolStripMenuItemTableMode.AccessibleDescription = "Activate the table mode";
			this.toolStripMenuItemTableMode.AccessibleName = "Table mode";
			this.toolStripMenuItemTableMode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemTableMode.AutoToolTip = true;
			this.toolStripMenuItemTableMode.DoubleClickEnabled = true;
			this.toolStripMenuItemTableMode.Image = global::Planetoid_DB.Properties.Resources.silk_table;
			this.toolStripMenuItemTableMode.Name = "toolStripMenuItemTableMode";
			this.toolStripMenuItemTableMode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
			this.toolStripMenuItemTableMode.Size = new System.Drawing.Size(243, 22);
			this.toolStripMenuItemTableMode.Text = "&Table mode";
			this.toolStripMenuItemTableMode.ToolTipText = "Activate the table mode";
			this.toolStripMenuItemTableMode.Click += new System.EventHandler(this.ToolStripMenuItemTableMode_Click);
			this.toolStripMenuItemTableMode.MouseEnter += new System.EventHandler(this.ToolStripMenuItemTableMode_MouseEnter);
			this.toolStripMenuItemTableMode.MouseLeave += new System.EventHandler(this.ToolStripMenuItemTableMode_MouseLeave);
			// 
			// toolStripSeparatorOptions1
			// 
			this.toolStripSeparatorOptions1.Name = "toolStripSeparatorOptions1";
			this.toolStripSeparatorOptions1.Size = new System.Drawing.Size(240, 6);
			// 
			// chartBarToolStripMenuItem
			// 
			this.chartBarToolStripMenuItem.AutoToolTip = true;
			this.chartBarToolStripMenuItem.DoubleClickEnabled = true;
			this.chartBarToolStripMenuItem.Enabled = false;
			this.chartBarToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.chartBarToolStripMenuItem.Name = "chartBarToolStripMenuItem";
			this.chartBarToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.chartBarToolStripMenuItem.Text = "Chart bar";
			// 
			// chartCurveToolStripMenuItem
			// 
			this.chartCurveToolStripMenuItem.AutoToolTip = true;
			this.chartCurveToolStripMenuItem.DoubleClickEnabled = true;
			this.chartCurveToolStripMenuItem.Enabled = false;
			this.chartCurveToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_chart_curve;
			this.chartCurveToolStripMenuItem.Name = "chartCurveToolStripMenuItem";
			this.chartCurveToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.chartCurveToolStripMenuItem.Text = "Chart curve";
			// 
			// chartPieToolStripMenuItem
			// 
			this.chartPieToolStripMenuItem.AutoToolTip = true;
			this.chartPieToolStripMenuItem.DoubleClickEnabled = true;
			this.chartPieToolStripMenuItem.Enabled = false;
			this.chartPieToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_chart_pie;
			this.chartPieToolStripMenuItem.Name = "chartPieToolStripMenuItem";
			this.chartPieToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.chartPieToolStripMenuItem.Text = "Chart pie";
			// 
			// toolStripSeparatorOptions2
			// 
			this.toolStripSeparatorOptions2.Name = "toolStripSeparatorOptions2";
			this.toolStripSeparatorOptions2.Size = new System.Drawing.Size(240, 6);
			// 
			// menuitemCheckMpcorbDat
			// 
			this.menuitemCheckMpcorbDat.AccessibleDescription = "Check for updates of the database";
			this.menuitemCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			this.menuitemCheckMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCheckMpcorbDat.AutoToolTip = true;
			this.menuitemCheckMpcorbDat.DoubleClickEnabled = true;
			this.menuitemCheckMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.menuitemCheckMpcorbDat.Name = "menuitemCheckMpcorbDat";
			this.menuitemCheckMpcorbDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.menuitemCheckMpcorbDat.Size = new System.Drawing.Size(243, 22);
			this.menuitemCheckMpcorbDat.Text = "&Check MPCORB.DAT";
			this.menuitemCheckMpcorbDat.ToolTipText = "Check for updates of the database";
			this.menuitemCheckMpcorbDat.Click += new System.EventHandler(this.MenuitemCheckMpcorbDat_Click);
			this.menuitemCheckMpcorbDat.MouseEnter += new System.EventHandler(this.MenuitemCheckMpcorbDat_MouseEnter);
			this.menuitemCheckMpcorbDat.MouseLeave += new System.EventHandler(this.MenuitemCheckMpcorbDat_MouseLeave);
			// 
			// menuitemDownloadMpcorbDat
			// 
			this.menuitemDownloadMpcorbDat.AccessibleDescription = "Download the database";
			this.menuitemDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			this.menuitemDownloadMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDownloadMpcorbDat.AutoToolTip = true;
			this.menuitemDownloadMpcorbDat.DoubleClickEnabled = true;
			this.menuitemDownloadMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_package;
			this.menuitemDownloadMpcorbDat.Name = "menuitemDownloadMpcorbDat";
			this.menuitemDownloadMpcorbDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.menuitemDownloadMpcorbDat.Size = new System.Drawing.Size(243, 22);
			this.menuitemDownloadMpcorbDat.Text = "&Download MPCORB.DAT";
			this.menuitemDownloadMpcorbDat.ToolTipText = "Download the database";
			this.menuitemDownloadMpcorbDat.Click += new System.EventHandler(this.MenuitemDownloadMpcorbDat_Click);
			this.menuitemDownloadMpcorbDat.MouseEnter += new System.EventHandler(this.MenuitemDownloadMpcorbDat_MouseEnter);
			this.menuitemDownloadMpcorbDat.MouseLeave += new System.EventHandler(this.MenuitemDownloadMpcorbDat_MouseLeave);
			// 
			// toolStripSeparatorOptions3
			// 
			this.toolStripSeparatorOptions3.Name = "toolStripSeparatorOptions3";
			this.toolStripSeparatorOptions3.Size = new System.Drawing.Size(240, 6);
			// 
			// ToolStripMenuItemStyle
			// 
			this.ToolStripMenuItemStyle.AccessibleDescription = "Change the style";
			this.ToolStripMenuItemStyle.AccessibleName = "Look and Feel";
			this.ToolStripMenuItemStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.ToolStripMenuItemStyle.AutoToolTip = true;
			this.ToolStripMenuItemStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStyleProfessional,
            this.toolStripMenuItemStyleOffice2007,
            this.toolStripMenuItemStyleSystem,
            this.toolStripMenuItemStyleVs2008});
			this.ToolStripMenuItemStyle.Image = global::Planetoid_DB.Properties.Resources.silk_theme;
			this.ToolStripMenuItemStyle.Name = "ToolStripMenuItemStyle";
			this.ToolStripMenuItemStyle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
			this.ToolStripMenuItemStyle.Size = new System.Drawing.Size(243, 22);
			this.ToolStripMenuItemStyle.Text = "Look and Feel";
			this.ToolStripMenuItemStyle.MouseEnter += new System.EventHandler(this.ToolStripMenuItemStyle_MouseEnter);
			this.ToolStripMenuItemStyle.MouseLeave += new System.EventHandler(this.ToolStripMenuItemStyle_MouseLeave);
			// 
			// toolStripMenuItemStyleProfessional
			// 
			this.toolStripMenuItemStyleProfessional.AccessibleDescription = "Change the style to \"Professionell\"";
			this.toolStripMenuItemStyleProfessional.AccessibleName = "Style \"Professionell\"";
			this.toolStripMenuItemStyleProfessional.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStyleProfessional.AutoToolTip = true;
			this.toolStripMenuItemStyleProfessional.CheckOnClick = true;
			this.toolStripMenuItemStyleProfessional.DoubleClickEnabled = true;
			this.toolStripMenuItemStyleProfessional.Name = "toolStripMenuItemStyleProfessional";
			this.toolStripMenuItemStyleProfessional.Size = new System.Drawing.Size(141, 22);
			this.toolStripMenuItemStyleProfessional.Text = "Professionell";
			this.toolStripMenuItemStyleProfessional.ToolTipText = "Style \"Professionell\"";
			this.toolStripMenuItemStyleProfessional.Click += new System.EventHandler(this.ToolStripMenuItemStyleProfessionell_Click);
			this.toolStripMenuItemStyleProfessional.MouseEnter += new System.EventHandler(this.ToolStripMenuItemStyleProfessionell_MouseEnter);
			this.toolStripMenuItemStyleProfessional.MouseLeave += new System.EventHandler(this.ToolStripMenuItemStyleProfessionell_MouseLeave);
			// 
			// toolStripMenuItemStyleOffice2007
			// 
			this.toolStripMenuItemStyleOffice2007.AccessibleDescription = "Change the style \"Office 2007\"";
			this.toolStripMenuItemStyleOffice2007.AccessibleName = "Style \"Office 2007\"";
			this.toolStripMenuItemStyleOffice2007.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStyleOffice2007.AutoToolTip = true;
			this.toolStripMenuItemStyleOffice2007.Checked = true;
			this.toolStripMenuItemStyleOffice2007.CheckOnClick = true;
			this.toolStripMenuItemStyleOffice2007.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemStyleOffice2007.DoubleClickEnabled = true;
			this.toolStripMenuItemStyleOffice2007.Name = "toolStripMenuItemStyleOffice2007";
			this.toolStripMenuItemStyleOffice2007.Size = new System.Drawing.Size(141, 22);
			this.toolStripMenuItemStyleOffice2007.Text = "Office 2007";
			this.toolStripMenuItemStyleOffice2007.ToolTipText = "Style \"Office 2007\"";
			this.toolStripMenuItemStyleOffice2007.Click += new System.EventHandler(this.ToolStripMenuItemStyleOffice2007_Click);
			// 
			// toolStripMenuItemStyleSystem
			// 
			this.toolStripMenuItemStyleSystem.AccessibleDescription = "Change the style to \"System\"";
			this.toolStripMenuItemStyleSystem.AccessibleName = "Style \"System\"";
			this.toolStripMenuItemStyleSystem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStyleSystem.AutoToolTip = true;
			this.toolStripMenuItemStyleSystem.CheckOnClick = true;
			this.toolStripMenuItemStyleSystem.DoubleClickEnabled = true;
			this.toolStripMenuItemStyleSystem.Name = "toolStripMenuItemStyleSystem";
			this.toolStripMenuItemStyleSystem.Size = new System.Drawing.Size(141, 22);
			this.toolStripMenuItemStyleSystem.Text = "System";
			this.toolStripMenuItemStyleSystem.ToolTipText = "Style \"System\"";
			this.toolStripMenuItemStyleSystem.Click += new System.EventHandler(this.ToolStripMenuItemSystem_Click);
			this.toolStripMenuItemStyleSystem.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSystem_MouseEnter);
			this.toolStripMenuItemStyleSystem.MouseLeave += new System.EventHandler(this.ToolStripMenuItemSystem_MouseLeave);
			// 
			// toolStripMenuItemStyleVs2008
			// 
			this.toolStripMenuItemStyleVs2008.AccessibleDescription = "Change the style to \"VS 2008\"";
			this.toolStripMenuItemStyleVs2008.AccessibleName = "Style \"VS 2008\"";
			this.toolStripMenuItemStyleVs2008.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStyleVs2008.AutoToolTip = true;
			this.toolStripMenuItemStyleVs2008.DoubleClickEnabled = true;
			this.toolStripMenuItemStyleVs2008.Name = "toolStripMenuItemStyleVs2008";
			this.toolStripMenuItemStyleVs2008.Size = new System.Drawing.Size(141, 22);
			this.toolStripMenuItemStyleVs2008.Text = "VS 2008";
			this.toolStripMenuItemStyleVs2008.ToolTipText = "Style \"VS 2008\"";
			this.toolStripMenuItemStyleVs2008.Click += new System.EventHandler(this.ToolStripMenuItemVs2008_Click);
			this.toolStripMenuItemStyleVs2008.MouseEnter += new System.EventHandler(this.ToolStripMenuItemVs2008_MouseEnter);
			this.toolStripMenuItemStyleVs2008.MouseLeave += new System.EventHandler(this.ToolStripMenuItemVs2008_MouseLeave);
			// 
			// menuitemQuest
			// 
			this.menuitemQuest.AccessibleDescription = "Open the menu \"?\"";
			this.menuitemQuest.AccessibleName = "?";
			this.menuitemQuest.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemQuest.AutoToolTip = true;
			this.menuitemQuest.DoubleClickEnabled = true;
			this.menuitemQuest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemAbout,
            this.toolStripSeparatorMisc,
            this.menuitemOpenWebsitePDB,
            this.menuitemOpenWebsiteMPC,
            this.menuitemOpenMPCORBWebsite});
			this.menuitemQuest.Name = "menuitemQuest";
			this.menuitemQuest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.OemQuestion)));
			this.menuitemQuest.Size = new System.Drawing.Size(24, 20);
			this.menuitemQuest.Text = "&?";
			this.menuitemQuest.ToolTipText = "Open the menu \"?\"";
			this.menuitemQuest.MouseEnter += new System.EventHandler(this.MenuitemQuest_MouseEnter);
			this.menuitemQuest.MouseLeave += new System.EventHandler(this.MenuitemQuest_MouseLeave);
			// 
			// menuitemAbout
			// 
			this.menuitemAbout.AccessibleDescription = "More information about the application";
			this.menuitemAbout.AccessibleName = "About";
			this.menuitemAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemAbout.AutoToolTip = true;
			this.menuitemAbout.DoubleClickEnabled = true;
			this.menuitemAbout.Image = global::Planetoid_DB.Properties.Resources.silk_information;
			this.menuitemAbout.Name = "menuitemAbout";
			this.menuitemAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
			this.menuitemAbout.Size = new System.Drawing.Size(231, 22);
			this.menuitemAbout.Text = "&About";
			this.menuitemAbout.ToolTipText = "More information about the application";
			this.menuitemAbout.Click += new System.EventHandler(this.MenuitemAbout_Click);
			this.menuitemAbout.MouseEnter += new System.EventHandler(this.MenuitemAbout_MouseEnter);
			this.menuitemAbout.MouseLeave += new System.EventHandler(this.MenuitemAbout_MouseLeave);
			// 
			// toolStripSeparatorMisc
			// 
			this.toolStripSeparatorMisc.AccessibleDescription = "There is an easter egg in it. Find out how to get!";
			this.toolStripSeparatorMisc.AccessibleName = "Separator";
			this.toolStripSeparatorMisc.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorMisc.Name = "toolStripSeparatorMisc";
			this.toolStripSeparatorMisc.Size = new System.Drawing.Size(228, 6);
			this.toolStripSeparatorMisc.Click += new System.EventHandler(this.ToolStripSeparatorMisc_Click);
			this.toolStripSeparatorMisc.MouseEnter += new System.EventHandler(this.ToolStripSeparatorMisc_MouseEnter);
			this.toolStripSeparatorMisc.MouseLeave += new System.EventHandler(this.ToolStripSeparatorMisc_MouseLeave);
			// 
			// menuitemOpenWebsitePDB
			// 
			this.menuitemOpenWebsitePDB.AccessibleDescription = "Open the PlanetoidDB homepage";
			this.menuitemOpenWebsitePDB.AccessibleName = "Open PlanetoidDB homepage";
			this.menuitemOpenWebsitePDB.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOpenWebsitePDB.AutoToolTip = true;
			this.menuitemOpenWebsitePDB.DoubleClickEnabled = true;
			this.menuitemOpenWebsitePDB.Image = global::Planetoid_DB.Properties.Resources.silk_house;
			this.menuitemOpenWebsitePDB.Name = "menuitemOpenWebsitePDB";
			this.menuitemOpenWebsitePDB.Size = new System.Drawing.Size(231, 22);
			this.menuitemOpenWebsitePDB.Text = "Open PlanetoidDB homepage";
			this.menuitemOpenWebsitePDB.ToolTipText = "Opens the PlanetoidDB homepage";
			this.menuitemOpenWebsitePDB.Click += new System.EventHandler(this.MenuitemOpenWebsitePDB_Click);
			this.menuitemOpenWebsitePDB.MouseEnter += new System.EventHandler(this.MenuitemOpenWebsitePDB_MouseEnter);
			this.menuitemOpenWebsitePDB.MouseLeave += new System.EventHandler(this.MenuitemOpenWebsitePDB_MouseLeave);
			// 
			// menuitemOpenWebsiteMPC
			// 
			this.menuitemOpenWebsiteMPC.AccessibleDescription = "Opens the MPC homepage";
			this.menuitemOpenWebsiteMPC.AccessibleName = "Opens MPC homepage";
			this.menuitemOpenWebsiteMPC.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOpenWebsiteMPC.AutoToolTip = true;
			this.menuitemOpenWebsiteMPC.DoubleClickEnabled = true;
			this.menuitemOpenWebsiteMPC.Image = global::Planetoid_DB.Properties.Resources.silk_world;
			this.menuitemOpenWebsiteMPC.Name = "menuitemOpenWebsiteMPC";
			this.menuitemOpenWebsiteMPC.Size = new System.Drawing.Size(231, 22);
			this.menuitemOpenWebsiteMPC.Text = "Open MPC homepage";
			this.menuitemOpenWebsiteMPC.ToolTipText = "Opens the MPC homepage";
			this.menuitemOpenWebsiteMPC.Click += new System.EventHandler(this.MenuitemOpenWebsiteMPC_Click);
			this.menuitemOpenWebsiteMPC.MouseEnter += new System.EventHandler(this.MenuitemOpenWebsiteMPC_MouseEnter);
			this.menuitemOpenWebsiteMPC.MouseLeave += new System.EventHandler(this.MenuitemOpenWebsiteMPC_MouseLeave);
			// 
			// menuitemOpenMPCORBWebsite
			// 
			this.menuitemOpenMPCORBWebsite.AccessibleDescription = "Opens the MPCORB website";
			this.menuitemOpenMPCORBWebsite.AccessibleName = "Opens MPCORB homepage";
			this.menuitemOpenMPCORBWebsite.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOpenMPCORBWebsite.AutoToolTip = true;
			this.menuitemOpenMPCORBWebsite.DoubleClickEnabled = true;
			this.menuitemOpenMPCORBWebsite.Image = global::Planetoid_DB.Properties.Resources.silk_world;
			this.menuitemOpenMPCORBWebsite.Name = "menuitemOpenMPCORBWebsite";
			this.menuitemOpenMPCORBWebsite.Size = new System.Drawing.Size(231, 22);
			this.menuitemOpenMPCORBWebsite.Text = "Open MPCORB website";
			this.menuitemOpenMPCORBWebsite.ToolTipText = "Opens the MPCORB website";
			this.menuitemOpenMPCORBWebsite.Click += new System.EventHandler(this.MenuitemOpenMPCORBWebsite_Click);
			this.menuitemOpenMPCORBWebsite.MouseEnter += new System.EventHandler(this.MenuitemOpenMPCORBWebsite_MouseEnter);
			this.menuitemOpenMPCORBWebsite.MouseLeave += new System.EventHandler(this.MenuitemOpenMPCORBWebsite_MouseLeave);
			// 
			// toolStripIcons
			// 
			this.toolStripIcons.AccessibleName = "Toolbar of main functions";
			this.toolStripIcons.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.toolStripIcons.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonCopyToClipboard,
            this.toolStripSeparator4,
            this.toolStripButtonDatabaseInformation,
            this.toolStripButtonTableMode,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSeparator5,
            this.toolStripButtonCheckMpcorbDat,
            this.toolStripButtonDownloadMpcorbDat,
            this.toolStripSeparator1,
            this.toolStripButtonAbout,
            this.toolStripButtonOpenWebsitePDB,
            this.toolStripSeparator2,
            this.toolStripLabelSearch,
            this.toolStripTextBoxSearch,
            this.toolStripButtonSearch});
			this.toolStripIcons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripIcons.Location = new System.Drawing.Point(0, 24);
			this.toolStripIcons.Name = "toolStripIcons";
			this.toolStripIcons.Size = new System.Drawing.Size(744, 25);
			this.toolStripIcons.Stretch = true;
			this.toolStripIcons.TabIndex = 1;
			this.toolStripIcons.TabStop = true;
			this.toolStripIcons.Text = "Toolbar of main functions";
			// 
			// toolStripButtonPrint
			// 
			this.toolStripButtonPrint.AccessibleDescription = "Print the information";
			this.toolStripButtonPrint.AccessibleName = "Print";
			this.toolStripButtonPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.DoubleClickEnabled = true;
			this.toolStripButtonPrint.Enabled = false;
			this.toolStripButtonPrint.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Print";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.ToolStripButtonPrint_Click);
			this.toolStripButtonPrint.MouseEnter += new System.EventHandler(this.ToolStripButtonPrint_MouseEnter);
			this.toolStripButtonPrint.MouseLeave += new System.EventHandler(this.ToolStripButtonPrint_MouseLeave);
			// 
			// toolStripButtonCopyToClipboard
			// 
			this.toolStripButtonCopyToClipboard.AccessibleDescription = "Copy to clipboard";
			this.toolStripButtonCopyToClipboard.AccessibleName = "Copy to clipboard";
			this.toolStripButtonCopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCopyToClipboard.DoubleClickEnabled = true;
			this.toolStripButtonCopyToClipboard.Enabled = false;
			this.toolStripButtonCopyToClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.toolStripButtonCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCopyToClipboard.Name = "toolStripButtonCopyToClipboard";
			this.toolStripButtonCopyToClipboard.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonCopyToClipboard.Text = "Copy to clipboard";
			this.toolStripButtonCopyToClipboard.ToolTipText = "Copy to clipboard";
			this.toolStripButtonCopyToClipboard.Click += new System.EventHandler(this.ToolStripButtonCopyToClipboard_Click);
			this.toolStripButtonCopyToClipboard.MouseEnter += new System.EventHandler(this.ToolStripButtonCopyToClipboard_MouseEnter);
			this.toolStripButtonCopyToClipboard.MouseLeave += new System.EventHandler(this.ToolStripButtonCopyToClipboard_MouseLeave);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonDatabaseInformation
			// 
			this.toolStripButtonDatabaseInformation.AccessibleDescription = "Show some information of the MPCORB.DAT database";
			this.toolStripButtonDatabaseInformation.AccessibleName = "Database Information";
			this.toolStripButtonDatabaseInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonDatabaseInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDatabaseInformation.DoubleClickEnabled = true;
			this.toolStripButtonDatabaseInformation.Image = global::Planetoid_DB.Properties.Resources.silk_database;
			this.toolStripButtonDatabaseInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDatabaseInformation.Name = "toolStripButtonDatabaseInformation";
			this.toolStripButtonDatabaseInformation.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDatabaseInformation.Text = "Database information";
			this.toolStripButtonDatabaseInformation.Click += new System.EventHandler(this.ToolStripButtonDatabaseInformation_Click);
			this.toolStripButtonDatabaseInformation.MouseEnter += new System.EventHandler(this.ToolStripButtonDatabaseInformation_MouseEnter);
			this.toolStripButtonDatabaseInformation.MouseLeave += new System.EventHandler(this.ToolStripButtonDatabaseInformation_MouseLeave);
			// 
			// toolStripButtonTableMode
			// 
			this.toolStripButtonTableMode.AccessibleDescription = "Activate the table mode";
			this.toolStripButtonTableMode.AccessibleName = "Table mode";
			this.toolStripButtonTableMode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonTableMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTableMode.DoubleClickEnabled = true;
			this.toolStripButtonTableMode.Image = global::Planetoid_DB.Properties.Resources.silk_table;
			this.toolStripButtonTableMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonTableMode.Name = "toolStripButtonTableMode";
			this.toolStripButtonTableMode.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonTableMode.Text = "Table mode";
			this.toolStripButtonTableMode.ToolTipText = "Activate the table mode";
			this.toolStripButtonTableMode.Click += new System.EventHandler(this.ToolStripButtonTableMode_Click);
			this.toolStripButtonTableMode.MouseEnter += new System.EventHandler(this.ToolStripButtonTableMode_MouseEnter);
			this.toolStripButtonTableMode.MouseLeave += new System.EventHandler(this.ToolStripButtonTableMode_MouseLeave);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.AccessibleDescription = "Chart bar";
			this.toolStripSplitButton1.AccessibleName = "Chart bar";
			this.toolStripSplitButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.DoubleClickEnabled = true;
			this.toolStripSplitButton1.Enabled = false;
			this.toolStripSplitButton1.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton1.Text = "Chart bar";
			// 
			// toolStripSplitButton2
			// 
			this.toolStripSplitButton2.AccessibleDescription = "Chart line";
			this.toolStripSplitButton2.AccessibleName = "Chart line";
			this.toolStripSplitButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton2.DoubleClickEnabled = true;
			this.toolStripSplitButton2.Enabled = false;
			this.toolStripSplitButton2.Image = global::Planetoid_DB.Properties.Resources.silk_chart_curve;
			this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton2.Name = "toolStripSplitButton2";
			this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton2.Text = "Chart line";
			// 
			// toolStripSplitButton3
			// 
			this.toolStripSplitButton3.AccessibleDescription = "Chart pie";
			this.toolStripSplitButton3.AccessibleName = "Chart pie";
			this.toolStripSplitButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton3.DoubleClickEnabled = true;
			this.toolStripSplitButton3.Enabled = false;
			this.toolStripSplitButton3.Image = global::Planetoid_DB.Properties.Resources.silk_chart_pie;
			this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton3.Name = "toolStripSplitButton3";
			this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton3.Text = "Chart pie";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonCheckMpcorbDat
			// 
			this.toolStripButtonCheckMpcorbDat.AccessibleDescription = "Check for updates of the database";
			this.toolStripButtonCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonCheckMpcorbDat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCheckMpcorbDat.DoubleClickEnabled = true;
			this.toolStripButtonCheckMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.toolStripButtonCheckMpcorbDat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCheckMpcorbDat.Name = "toolStripButtonCheckMpcorbDat";
			this.toolStripButtonCheckMpcorbDat.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonCheckMpcorbDat.Text = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.ToolTipText = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.Click += new System.EventHandler(this.ToolStripButtonCheckMpcorbDat_Click);
			this.toolStripButtonCheckMpcorbDat.MouseEnter += new System.EventHandler(this.ToolStripButtonCheckMpcorbDat_MouseEnter);
			this.toolStripButtonCheckMpcorbDat.MouseLeave += new System.EventHandler(this.ToolStripButtonCheckMpcorbDat_MouseLeave);
			// 
			// toolStripButtonDownloadMpcorbDat
			// 
			this.toolStripButtonDownloadMpcorbDat.AccessibleDescription = "Download the database";
			this.toolStripButtonDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			this.toolStripButtonDownloadMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonDownloadMpcorbDat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDownloadMpcorbDat.DoubleClickEnabled = true;
			this.toolStripButtonDownloadMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_package_go;
			this.toolStripButtonDownloadMpcorbDat.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonDownloadMpcorbDat.Name = "toolStripButtonDownloadMpcorbDat";
			this.toolStripButtonDownloadMpcorbDat.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDownloadMpcorbDat.Text = "Download MPCORB.DAT";
			this.toolStripButtonDownloadMpcorbDat.ToolTipText = "Download the database";
			this.toolStripButtonDownloadMpcorbDat.Click += new System.EventHandler(this.ToolStripButtonDownloadMpcorbDat_Click);
			this.toolStripButtonDownloadMpcorbDat.MouseEnter += new System.EventHandler(this.ToolStripButtonDownloadMpcorbDat_MouseEnter);
			this.toolStripButtonDownloadMpcorbDat.MouseLeave += new System.EventHandler(this.ToolStripButtonDownloadMpcorbDat_MouseLeave);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.AccessibleDescription = "More information about the application";
			this.toolStripButtonAbout.AccessibleName = "About";
			this.toolStripButtonAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.DoubleClickEnabled = true;
			this.toolStripButtonAbout.Image = global::Planetoid_DB.Properties.Resources.silk_information;
			this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAbout.Text = "About";
			this.toolStripButtonAbout.ToolTipText = "More information about the application";
			this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
			this.toolStripButtonAbout.MouseEnter += new System.EventHandler(this.ToolStripButtonAbout_MouseEnter);
			this.toolStripButtonAbout.MouseLeave += new System.EventHandler(this.ToolStripButtonAbout_MouseLeave);
			// 
			// toolStripButtonOpenWebsitePDB
			// 
			this.toolStripButtonOpenWebsitePDB.AccessibleDescription = "Open the PlanetoidDB homepage";
			this.toolStripButtonOpenWebsitePDB.AccessibleName = "Open PlanetoidDB homepage";
			this.toolStripButtonOpenWebsitePDB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonOpenWebsitePDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpenWebsitePDB.DoubleClickEnabled = true;
			this.toolStripButtonOpenWebsitePDB.Image = global::Planetoid_DB.Properties.Resources.silk_house;
			this.toolStripButtonOpenWebsitePDB.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpenWebsitePDB.Name = "toolStripButtonOpenWebsitePDB";
			this.toolStripButtonOpenWebsitePDB.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonOpenWebsitePDB.Text = "Open PlanetoidDB homepage";
			this.toolStripButtonOpenWebsitePDB.ToolTipText = "Open the PlanetoidDB homepage";
			this.toolStripButtonOpenWebsitePDB.Click += new System.EventHandler(this.ToolStripButtonOpenWebsitePDB_Click);
			this.toolStripButtonOpenWebsitePDB.MouseEnter += new System.EventHandler(this.ToolStripButtonOpenWebsitePDB_MouseEnter);
			this.toolStripButtonOpenWebsitePDB.MouseLeave += new System.EventHandler(this.ToolStripButtonOpenWebsitePDB_MouseLeave);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabelSearch
			// 
			this.toolStripLabelSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.toolStripLabelSearch.DoubleClickEnabled = true;
			this.toolStripLabelSearch.Enabled = false;
			this.toolStripLabelSearch.Name = "toolStripLabelSearch";
			this.toolStripLabelSearch.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabelSearch.Text = "Search:";
			// 
			// toolStripTextBoxSearch
			// 
			this.toolStripTextBoxSearch.AccessibleDescription = "Enter the search term";
			this.toolStripTextBoxSearch.AccessibleName = "Seach field";
			this.toolStripTextBoxSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.toolStripTextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.toolStripTextBoxSearch.AutoToolTip = true;
			this.toolStripTextBoxSearch.Enabled = false;
			this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
			this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxSearch.ToolTipText = "Search";
			this.toolStripTextBoxSearch.MouseEnter += new System.EventHandler(this.ToolStripTextBoxSearch_MouseEnter);
			this.toolStripTextBoxSearch.MouseLeave += new System.EventHandler(this.ToolStripTextBoxSearch_MouseLeave);
			// 
			// toolStripButtonSearch
			// 
			this.toolStripButtonSearch.AccessibleDescription = "Search";
			this.toolStripButtonSearch.AccessibleName = "Search";
			this.toolStripButtonSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSearch.DoubleClickEnabled = true;
			this.toolStripButtonSearch.Enabled = false;
			this.toolStripButtonSearch.Image = global::Planetoid_DB.Properties.Resources.silk_magnifier;
			this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSearch.Name = "toolStripButtonSearch";
			this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSearch.Text = "Search";
			this.toolStripButtonSearch.Click += new System.EventHandler(this.ToolStripButtonSearch_Click);
			this.toolStripButtonSearch.MouseEnter += new System.EventHandler(this.ToolStripButtonSearch_MouseEnter);
			this.toolStripButtonSearch.MouseLeave += new System.EventHandler(this.ToolStripButtonSearch_MouseLeave);
			// 
			// labelGottoIndex
			// 
			this.labelGottoIndex.AccessibleDescription = "Go to index";
			this.labelGottoIndex.AccessibleName = "Index";
			this.labelGottoIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			this.labelGottoIndex.AutoSize = true;
			this.labelGottoIndex.BackColor = System.Drawing.Color.Transparent;
			this.labelGottoIndex.Location = new System.Drawing.Point(542, 9);
			this.labelGottoIndex.Name = "labelGottoIndex";
			this.labelGottoIndex.Size = new System.Drawing.Size(72, 15);
			this.labelGottoIndex.TabIndex = 7;
			this.labelGottoIndex.Text = "Go to Index:";
			// 
			// backgroundWorkerLoadingDatabase
			// 
			this.backgroundWorkerLoadingDatabase.WorkerReportsProgress = true;
			this.backgroundWorkerLoadingDatabase.WorkerSupportsCancellation = true;
			this.backgroundWorkerLoadingDatabase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerLoadingDatabase_DoWork);
			this.backgroundWorkerLoadingDatabase.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerLoadingDatabase_ProgressChanged);
			this.backgroundWorkerLoadingDatabase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerLoadingDatabase_RunWorkerCompleted);
			// 
			// timerBlinkForUpdateAvailable
			// 
			this.timerBlinkForUpdateAvailable.Interval = 500;
			this.timerBlinkForUpdateAvailable.Tick += new System.EventHandler(this.TimerBlinkForUpdateAvailable_Tick);
			// 
			// toolStripNavigation
			// 
			this.toolStripNavigation.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripSeparator6,
            this.toolStripLabel2,
            this.toolStripSeparator7,
            this.toolStripLabel3,
            this.toolStripTextBox2,
            this.toolStripButton15});
			this.toolStripNavigation.Location = new System.Drawing.Point(0, 49);
			this.toolStripNavigation.Name = "toolStripNavigation";
			this.toolStripNavigation.Size = new System.Drawing.Size(478, 25);
			this.toolStripNavigation.Stretch = true;
			this.toolStripNavigation.TabIndex = 15;
			this.toolStripNavigation.Text = "Navigation";
			this.toolStripNavigation.Visible = false;
			// 
			// toolStripButton9
			// 
			this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton9.Image = global::Planetoid_DB.Properties.Resources.silk_backward_end_blue;
			this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton9.Name = "toolStripButton9";
			this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton9.Text = "toolStripButton9";
			// 
			// toolStripButton10
			// 
			this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton10.Image = global::Planetoid_DB.Properties.Resources.silk_backward_1_blue;
			this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton10.Name = "toolStripButton10";
			this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton10.Text = "toolStripButton10";
			// 
			// toolStripButton11
			// 
			this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton11.Image = global::Planetoid_DB.Properties.Resources.silk_backward_blue;
			this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton11.Name = "toolStripButton11";
			this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton11.Text = "toolStripButton11";
			// 
			// toolStripButton12
			// 
			this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton12.Image = global::Planetoid_DB.Properties.Resources.silk_forward_blue;
			this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton12.Name = "toolStripButton12";
			this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton12.Text = "toolStripButton12";
			// 
			// toolStripButton13
			// 
			this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton13.Image = global::Planetoid_DB.Properties.Resources.silk_forward_1_blue;
			this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton13.Name = "toolStripButton13";
			this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton13.Text = "toolStripButton13";
			// 
			// toolStripButton14
			// 
			this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton14.Image = global::Planetoid_DB.Properties.Resources.silk_forward_end_blue;
			this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton14.Name = "toolStripButton14";
			this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton14.Text = "toolStripButton14";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(121, 22);
			this.toolStripLabel2.Text = "Index 123456 / 999999";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(70, 22);
			this.toolStripLabel3.Text = "Go to index:";
			// 
			// toolStripTextBox2
			// 
			this.toolStripTextBox2.Name = "toolStripTextBox2";
			this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
			// 
			// toolStripButton15
			// 
			this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton15.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton15.Name = "toolStripButton15";
			this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton15.Text = "toolStripButton15";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusBar);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.trackBarIndex);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonGotoIndex);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.numericUpDownGotoIndex);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelGottoIndex);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelIndexPos);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonStepForward);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonStepToEnd);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonStepForward1);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanelData);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonStepBackward1);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonStepBackward);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonStepToBegin);
			this.toolStripContainer1.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(744, 330);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(744, 401);
			this.toolStripContainer1.TabIndex = 16;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menu);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripIcons);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripNavigation);
			// 
			// timerCheckForNewMpcorbDatFile
			// 
			this.timerCheckForNewMpcorbDatFile.Enabled = true;
			this.timerCheckForNewMpcorbDatFile.Interval = 1440000;
			this.timerCheckForNewMpcorbDatFile.Tick += new System.EventHandler(this.TimerCheckForNewMpcorbDatFile_Tick);
			// 
			// notifyIconUpdate
			// 
			this.notifyIconUpdate.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconUpdate.Icon")));
			this.notifyIconUpdate.Text = "PlanetoidDB";
			this.notifyIconUpdate.Click += new System.EventHandler(this.NotifyIconUpdate_Click);
			// 
			// contextMenuNotifyIcon
			// 
			this.contextMenuNotifyIcon.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkMPCORBDATToolStripMenuItem,
            this.downloadMPCORBDATToolStripMenuItem});
			this.contextMenuNotifyIcon.Name = "contextMenuNotifyIcon";
			this.contextMenuNotifyIcon.Size = new System.Drawing.Size(206, 48);
			// 
			// checkMPCORBDATToolStripMenuItem
			// 
			this.checkMPCORBDATToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.checkMPCORBDATToolStripMenuItem.Name = "checkMPCORBDATToolStripMenuItem";
			this.checkMPCORBDATToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.checkMPCORBDATToolStripMenuItem.Text = "Check MPCORB.DAT";
			// 
			// downloadMPCORBDATToolStripMenuItem
			// 
			this.downloadMPCORBDATToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_package_go;
			this.downloadMPCORBDATToolStripMenuItem.Name = "downloadMPCORBDATToolStripMenuItem";
			this.downloadMPCORBDATToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.downloadMPCORBDATToolStripMenuItem.Text = "Download MPCORB.DAT";
			// 
			// PlanetoidDBForm
			// 
			this.AccessibleDescription = "Viewer for the MPC Orbit (MPCORB) Database";
			this.AccessibleName = "PlanetoidDB";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(744, 401);
			this.Controls.Add(this.toolStripContainer1);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.MaximizeBox = false;
			this.Name = "PlanetoidDBForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Planetoid-DB";
			this.Load += new System.EventHandler(this.PlanetoidDBForm_Load);
			this.Shown += new System.EventHandler(this.PlanetoidDBForm_Shown);
			this.contextMenuNavigationStep.ResumeLayout(false);
			this.tableLayoutPanelData.ResumeLayout(false);
			this.tableLayoutPanelData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownGotoIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIndex)).EndInit();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.toolStripIcons.ResumeLayout(false);
			this.toolStripIcons.PerformLayout();
			this.toolStripNavigation.ResumeLayout(false);
			this.toolStripNavigation.PerformLayout();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.contextMenuNotifyIcon.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonStepToBegin;
    private System.Windows.Forms.Button buttonStepBackward;
    private System.Windows.Forms.Button buttonStepBackward1;
    private System.Windows.Forms.Button buttonStepForward1;
    private System.Windows.Forms.Button buttonStepForward;
    private System.Windows.Forms.Button buttonStepToEnd;
    private System.Windows.Forms.Label labelIndex;
    private System.Windows.Forms.Label labelMagAbs;
    private System.Windows.Forms.Label labelSlopeParam;
    private System.Windows.Forms.Label labelEpoch;
    private System.Windows.Forms.Label labelMeanAnomaly;
    private System.Windows.Forms.Label labelArgPeri;
    private System.Windows.Forms.Label labelLongAscNode;
    private System.Windows.Forms.Label labelIncl;
    private System.Windows.Forms.Label labelOrbEcc;
    private System.Windows.Forms.Label labelMotion;
    private System.Windows.Forms.Label labelSemiMajorAxis;
    private System.Windows.Forms.Label labelRef;
    private System.Windows.Forms.Label labelNumbObs;
    private System.Windows.Forms.Label labelNumbOppos;
    private System.Windows.Forms.Label labelObsSpan;
    private System.Windows.Forms.Label labelRmsResidual;
    private System.Windows.Forms.Label labelComputerName;
    private System.Windows.Forms.Label labelDesgnName;
    private System.Windows.Forms.Label labelObsLastDate;
    private System.Windows.Forms.Label labelFlags;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
    private System.Windows.Forms.Label labelFlagsValue;
    private System.Windows.Forms.Label labelRefValue;
    private System.Windows.Forms.Label labelDesgnNameValue;
    private System.Windows.Forms.Label labelEpochValue;
    private System.Windows.Forms.Label labelMeanAnomalyValue;
    private System.Windows.Forms.Label labelArgPeriValue;
    private System.Windows.Forms.Label labelLongAscNodeValue;
    private System.Windows.Forms.Label labelInclValue;
    private System.Windows.Forms.Label labelOrbEccValue;
    private System.Windows.Forms.Label labelMotionValue;
    private System.Windows.Forms.Label labelSemiMajorAxisValue;
    private System.Windows.Forms.Label labelSlopeParamValue;
    private System.Windows.Forms.Label labelNumbOpposValue;
    private System.Windows.Forms.Label labelNumbObsValue;
    private System.Windows.Forms.Label labelObsSpanValue;
    private System.Windows.Forms.Label labelRmsResidualValue;
    private System.Windows.Forms.Label labelComputerNameValue;
    private System.Windows.Forms.Label labelObsLastDateValue;
    private System.Windows.Forms.Label labelIndexValue;
    private System.Windows.Forms.Label labelMagAbsValue;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.StatusStrip statusBar;
    private System.Windows.Forms.Label labelIndexPos;
    private System.Windows.Forms.Label labelGottoIndex;
    private System.Windows.Forms.NumericUpDown numericUpDownGotoIndex;
    private System.Windows.Forms.Button buttonGotoIndex;
    private System.Windows.Forms.ContextMenuStrip contextMenuNavigationStep;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1000;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10000;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100000;
    private System.Windows.Forms.MenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem menuitemFile;
    private System.Windows.Forms.ToolStripMenuItem menuitemExit;
    private System.Windows.Forms.ToolStripMenuItem menuitemQuest;
    private System.Windows.Forms.ToolStripMenuItem menuitemAbout;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMisc;
    private System.Windows.Forms.ToolStripMenuItem menuitemOpenWebsitePDB;
    private System.Windows.Forms.ToolStripMenuItem menuitemOpenWebsiteMPC;
    private System.Windows.Forms.ToolStripMenuItem menuitemOpenMPCORBWebsite;
    private System.Windows.Forms.ToolStripMenuItem menuitemOptions;
    private System.Windows.Forms.ToolStripMenuItem menuitemDownloadMpcorbDat;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarBackgroundDownload;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBackgroundDownload;
    private System.ComponentModel.BackgroundWorker backgroundWorkerLoadingDatabase;
    private System.Windows.Forms.TrackBar trackBarIndex;
    private System.Windows.Forms.ToolStripMenuItem menuitemCheckMpcorbDat;
    private System.Windows.Forms.ToolStripStatusLabel labelHelp;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUpdate;
    private System.Windows.Forms.Timer timerBlinkForUpdateAvailable;
    private System.Windows.Forms.ToolStrip toolStripIcons;
    private System.Windows.Forms.ToolStripButton toolStripButtonCheckMpcorbDat;
    private System.Windows.Forms.ToolStripButton toolStripButtonDownloadMpcorbDat;
    private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton toolStripButtonOpenWebsitePDB;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripLabel toolStripLabelSearch;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
    private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
    private System.Windows.Forms.ToolStripButton toolStripButtonTableMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton toolStripButtonCopyToClipboard;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton toolStripButtonDatabaseInformation;
    private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
    private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStrip toolStripNavigation;
    private System.Windows.Forms.ToolStripButton toolStripButton9;
    private System.Windows.Forms.ToolStripButton toolStripButton10;
    private System.Windows.Forms.ToolStripButton toolStripButton11;
    private System.Windows.Forms.ToolStripButton toolStripButton12;
    private System.Windows.Forms.ToolStripButton toolStripButton13;
    private System.Windows.Forms.ToolStripButton toolStripButton14;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    private System.Windows.Forms.ToolStripButton toolStripButton15;
    private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
    private System.Windows.Forms.ToolStripMenuItem menuitemEdit;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopytoClipboard;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrint;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDatabaseInformation;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTableMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions1;
    private System.Windows.Forms.ToolStripMenuItem chartBarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem chartCurveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem chartPieToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions2;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions3;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStyle;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleOffice2007;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleProfessional;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleSystem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleVs2008;
    private System.Windows.Forms.Timer timerCheckForNewMpcorbDatFile;
    private System.Windows.Forms.NotifyIcon notifyIconUpdate;
    private System.Windows.Forms.ContextMenuStrip contextMenuNotifyIcon;
    private System.Windows.Forms.ToolStripMenuItem checkMPCORBDATToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem downloadMPCORBDATToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCancelBackgroundDownload;
	}
}

