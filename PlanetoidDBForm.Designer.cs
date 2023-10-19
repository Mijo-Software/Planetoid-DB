using Krypton.Toolkit;

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
			this.menuitemNavigateStep10 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateStep100 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateStep1000 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateStep10000 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateStep100000 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateSomeDataBackward = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateSomeDataForward = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButtonStepForward = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSplitButtonStepBackward = new System.Windows.Forms.ToolStripSplitButton();
			this.tableLayoutPanelData = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.labelIndexData = new Krypton.Toolkit.KryptonLabel();
			this.labelReadableDesignationData = new Krypton.Toolkit.KryptonLabel();
			this.labelEpochData = new Krypton.Toolkit.KryptonLabel();
			this.labelMeanAnomalyAtTheEpochData = new Krypton.Toolkit.KryptonLabel();
			this.labelArgumentOfPerihelionData = new Krypton.Toolkit.KryptonLabel();
			this.labelLongitudeOfTheAscendingNodeData = new Krypton.Toolkit.KryptonLabel();
			this.labelInclinationToTheEclipticData = new Krypton.Toolkit.KryptonLabel();
			this.labelOrbitalEccentricityData = new Krypton.Toolkit.KryptonLabel();
			this.labelMeanDailyMotionData = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiMajorAxisData = new Krypton.Toolkit.KryptonLabel();
			this.labelAbsoluteMagnitudeData = new Krypton.Toolkit.KryptonLabel();
			this.labelSlopeParameterData = new Krypton.Toolkit.KryptonLabel();
			this.labelReferenceData = new Krypton.Toolkit.KryptonLabel();
			this.labelNumberOfOppositionsData = new Krypton.Toolkit.KryptonLabel();
			this.labelNumberOfObservationsData = new Krypton.Toolkit.KryptonLabel();
			this.labelObservationSpanData = new Krypton.Toolkit.KryptonLabel();
			this.labelRmsResidualData = new Krypton.Toolkit.KryptonLabel();
			this.labelComputerNameData = new Krypton.Toolkit.KryptonLabel();
			this.labelFlagsData = new Krypton.Toolkit.KryptonLabel();
			this.labelDateLastObservationData = new Krypton.Toolkit.KryptonLabel();
			this.labelIndexDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelReadableDesignationDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelEpochDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelMeanAnomalyAtTheEpochDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelArgumentOfPerihelionDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelLongitudeOfTheAscendingNodeDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelInclinationToTheEclipticDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelOrbitalEccentricityDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelMeanDailyMotionDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiMajorAxisDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelAbsoluteMagnitudeDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelSlopeParameterDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelReferenceDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelNumberOfOppositionsDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelNumberOfObservationsDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelObservationSpanDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelRmsResidualDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelComputerNameDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelFlagsDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelDateLastObservationDesc = new Krypton.Toolkit.KryptonLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.contextMenuTopTenRecords = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuitemRecordsSortDirection = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsSortDirectionAscending = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsSortDirectionDescending = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemRecordsMeanAnomalyAtTheEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsInclination = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsOrbitalEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsSemiMajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsSlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsComputername = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecordsDateOfTheLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRecords = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuDistributions = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuitemDistributionMeanAnomalyAtTheEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionInclination = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionOrbitalEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionSemiMajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionSlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistributionComputerName = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistribution = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuCopyToClipboardOrbitalElements = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuitemCopyToClipboardIndexNumber = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardReadableDesignation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardInclinationToTheEcliptic = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardOrbitalEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardSemiMajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardSlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardReference = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardComputerName = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardDateOfTheLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardFlags = new System.Windows.Forms.ToolStripMenuItem();
			this.splitbuttonCopyToClipboard = new System.Windows.Forms.ToolStripSplitButton();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.menuitemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOpenALocalMpcorbdatFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemExportDataEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemRestart = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopytoClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemRandomMinorPlanet = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorNavigation1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemNavigateToTheBeginning = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateToThePreviousData = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateToTheNextData = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemNavigateToTheEnd = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemTools = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDerivatedOrbitElements = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorTools1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparatorTools2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemDatabaseInformation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemTableMode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemTerminology = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCheckMpcorbDat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDownloadMpcorbDat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemStyle = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemIconsetSilk = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemIconsetFugue = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemIconsetFatcow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorOptions = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemOptionStayOnTop = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOptionEnabledCopyingByDoubleClicking = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOptionEnableLinkingToTerminology = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorMisc1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemOpenWebsitePDB = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOpenWebsiteMPC = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOpenMPCORBWebsite = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusBar = new Krypton.Toolkit.KryptonStatusStrip();
			this.toolStripStatusLabelUpdate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBarBackgroundDownload = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelCancelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripIcons = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonDatabaseInformation = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTableMode = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTerminology = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.splitbuttonTopTenRecords = new System.Windows.Forms.ToolStripSplitButton();
			this.splitbuttonDistribution = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonCheckMpcorbDat = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDownloadMpcorbDat = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpenWebsitePDB = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelQuickSearch = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
			this.splitbuttonSearch = new System.Windows.Forms.ToolStripSplitButton();
			this.menuitemSearchIndex = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchReadableDesignation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchMeanAnomalyAtTheEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchInclination = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchOrbitalEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchSemiMajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchSlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchReference = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchComputerName = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchDateOfTheLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchFlags = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripNavigation = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonLoadRandomMinorPlanet = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonStepToBegin = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStepBackwardOne = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStepForwardOne = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStepToEnd = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelGoToIndex = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxGotoIndex = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonGoToIndex = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelIndexPosition = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonDerivatedOrbitElements = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorOptions2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparatorOptions1 = new System.Windows.Forms.ToolStripSeparator();
			this.backgroundWorkerLoadingDatabase = new System.ComponentModel.BackgroundWorker();
			this.timerBlinkForUpdateAvailable = new System.Windows.Forms.Timer(this.components);
			this.timerCheckForNewMpcorbDatFile = new System.Windows.Forms.Timer(this.components);
			this.contextMenuNavigationStep.SuspendLayout();
			this.tableLayoutPanelData.SuspendLayout();
			this.contextMenuTopTenRecords.SuspendLayout();
			this.contextMenuDistributions.SuspendLayout();
			this.contextMenuCopyToClipboardOrbitalElements.SuspendLayout();
			this.menu.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.toolStripIcons.SuspendLayout();
			this.toolStripNavigation.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuNavigationStep
			// 
			this.contextMenuNavigationStep.AccessibleDescription = "Shows the context menu of data items";
			this.contextMenuNavigationStep.AccessibleName = "Context menu of items";
			this.contextMenuNavigationStep.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuNavigationStep.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuNavigationStep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemNavigateStep10,
            this.menuitemNavigateStep100,
            this.menuitemNavigateStep1000,
            this.menuitemNavigateStep10000,
            this.menuitemNavigateStep100000});
			this.contextMenuNavigationStep.Name = "contextMenu";
			this.contextMenuNavigationStep.OwnerItem = this.toolStripSplitButtonStepBackward;
			this.contextMenuNavigationStep.ShowCheckMargin = true;
			this.contextMenuNavigationStep.ShowImageMargin = false;
			this.contextMenuNavigationStep.Size = new System.Drawing.Size(111, 114);
			this.contextMenuNavigationStep.TabStop = true;
			this.contextMenuNavigationStep.Text = "Navigation step";
			this.toolTip.SetToolTip(this.contextMenuNavigationStep, "Show the context name of data items");
			this.contextMenuNavigationStep.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.contextMenuNavigationStep.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateStep10
			// 
			this.menuitemNavigateStep10.AccessibleDescription = "Jumps 10 items backward/forward";
			this.menuitemNavigateStep10.AccessibleName = "Jumps 10 items backward/forward";
			this.menuitemNavigateStep10.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateStep10.CheckOnClick = true;
			this.menuitemNavigateStep10.Name = "menuitemNavigateStep10";
			this.menuitemNavigateStep10.Size = new System.Drawing.Size(110, 22);
			this.menuitemNavigateStep10.Text = "10";
			this.menuitemNavigateStep10.ToolTipText = "Jump 10 items backward/forward";
			this.menuitemNavigateStep10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
			this.menuitemNavigateStep10.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateStep10.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateStep100
			// 
			this.menuitemNavigateStep100.AccessibleDescription = "Jumps 100 items backward/forward";
			this.menuitemNavigateStep100.AccessibleName = "Jumps 100 items backward/forward";
			this.menuitemNavigateStep100.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateStep100.Checked = true;
			this.menuitemNavigateStep100.CheckOnClick = true;
			this.menuitemNavigateStep100.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemNavigateStep100.Name = "menuitemNavigateStep100";
			this.menuitemNavigateStep100.Size = new System.Drawing.Size(110, 22);
			this.menuitemNavigateStep100.Text = "100";
			this.menuitemNavigateStep100.ToolTipText = "Jump 100 items backward/forward";
			this.menuitemNavigateStep100.Click += new System.EventHandler(this.ToolStripMenuItem100_Click);
			this.menuitemNavigateStep100.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateStep100.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateStep1000
			// 
			this.menuitemNavigateStep1000.AccessibleDescription = "Jumps 1000 items backward/forward";
			this.menuitemNavigateStep1000.AccessibleName = "Jumps 1000 items backward/forward";
			this.menuitemNavigateStep1000.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateStep1000.CheckOnClick = true;
			this.menuitemNavigateStep1000.Name = "menuitemNavigateStep1000";
			this.menuitemNavigateStep1000.Size = new System.Drawing.Size(110, 22);
			this.menuitemNavigateStep1000.Text = "1000";
			this.menuitemNavigateStep1000.ToolTipText = "Jump 1000 items backward/forward";
			this.menuitemNavigateStep1000.Click += new System.EventHandler(this.ToolStripMenuItem1000_Click);
			this.menuitemNavigateStep1000.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateStep1000.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateStep10000
			// 
			this.menuitemNavigateStep10000.AccessibleDescription = "Jumps 10000 items backward/forward";
			this.menuitemNavigateStep10000.AccessibleName = "Jumps 10000 items backward/forward";
			this.menuitemNavigateStep10000.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateStep10000.CheckOnClick = true;
			this.menuitemNavigateStep10000.Name = "menuitemNavigateStep10000";
			this.menuitemNavigateStep10000.Size = new System.Drawing.Size(110, 22);
			this.menuitemNavigateStep10000.Text = "10000";
			this.menuitemNavigateStep10000.ToolTipText = "Jump 10000 items backward/forward";
			this.menuitemNavigateStep10000.Click += new System.EventHandler(this.ToolStripMenuItem10000_Click);
			this.menuitemNavigateStep10000.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateStep10000.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateStep100000
			// 
			this.menuitemNavigateStep100000.AccessibleDescription = "Jumps 100000 items backward/forward";
			this.menuitemNavigateStep100000.AccessibleName = "Jumps 100000 items backward/forward";
			this.menuitemNavigateStep100000.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateStep100000.CheckOnClick = true;
			this.menuitemNavigateStep100000.Name = "menuitemNavigateStep100000";
			this.menuitemNavigateStep100000.Size = new System.Drawing.Size(110, 22);
			this.menuitemNavigateStep100000.Text = "100000";
			this.menuitemNavigateStep100000.ToolTipText = "Jump 100000 items backward/forward";
			this.menuitemNavigateStep100000.Click += new System.EventHandler(this.ToolStripMenuItem100000_Click);
			this.menuitemNavigateStep100000.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateStep100000.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateSomeDataBackward
			// 
			this.menuitemNavigateSomeDataBackward.AccessibleDescription = "Navigates some data backward";
			this.menuitemNavigateSomeDataBackward.AccessibleName = "Navigates some data backward";
			this.menuitemNavigateSomeDataBackward.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateSomeDataBackward.AutoToolTip = true;
			this.menuitemNavigateSomeDataBackward.DoubleClickEnabled = true;
			this.menuitemNavigateSomeDataBackward.DropDown = this.contextMenuNavigationStep;
			this.menuitemNavigateSomeDataBackward.Image = global::Planetoid_DB.Properties.Resources.silk_backward_green;
			this.menuitemNavigateSomeDataBackward.Name = "menuitemNavigateSomeDataBackward";
			this.menuitemNavigateSomeDataBackward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
			this.menuitemNavigateSomeDataBackward.Size = new System.Drawing.Size(274, 22);
			this.menuitemNavigateSomeDataBackward.Text = "Navigate some data back&ward";
			this.menuitemNavigateSomeDataBackward.Click += new System.EventHandler(this.ToolStripMenuItemNavigateSomeDataBackward_Click);
			this.menuitemNavigateSomeDataBackward.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateSomeDataBackward.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateSomeDataForward
			// 
			this.menuitemNavigateSomeDataForward.AccessibleDescription = "Navigates some data forward";
			this.menuitemNavigateSomeDataForward.AccessibleName = "Navigates some data forward";
			this.menuitemNavigateSomeDataForward.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateSomeDataForward.AutoToolTip = true;
			this.menuitemNavigateSomeDataForward.DoubleClickEnabled = true;
			this.menuitemNavigateSomeDataForward.DropDown = this.contextMenuNavigationStep;
			this.menuitemNavigateSomeDataForward.Image = global::Planetoid_DB.Properties.Resources.silk_forward_green;
			this.menuitemNavigateSomeDataForward.Name = "menuitemNavigateSomeDataForward";
			this.menuitemNavigateSomeDataForward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.menuitemNavigateSomeDataForward.Size = new System.Drawing.Size(274, 22);
			this.menuitemNavigateSomeDataForward.Text = "Navigate some data &forward";
			this.menuitemNavigateSomeDataForward.Click += new System.EventHandler(this.ToolStripMenuItemNavigateSomeDataForward_Click);
			this.menuitemNavigateSomeDataForward.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateSomeDataForward.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSplitButtonStepForward
			// 
			this.toolStripSplitButtonStepForward.AccessibleDescription = "Navigates some data forward";
			this.toolStripSplitButtonStepForward.AccessibleName = "Navigate some data forward";
			this.toolStripSplitButtonStepForward.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButtonStepForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonStepForward.DropDown = this.contextMenuNavigationStep;
			this.toolStripSplitButtonStepForward.Image = global::Planetoid_DB.Properties.Resources.silk_forward_green;
			this.toolStripSplitButtonStepForward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonStepForward.Name = "toolStripSplitButtonStepForward";
			this.toolStripSplitButtonStepForward.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButtonStepForward.Text = "Navigate some data forward";
			this.toolStripSplitButtonStepForward.ButtonClick += new System.EventHandler(this.ToolStripButtonStepForward_Click);
			this.toolStripSplitButtonStepForward.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButtonStepForward.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSplitButtonStepBackward
			// 
			this.toolStripSplitButtonStepBackward.AccessibleDescription = "Navigates some data backward";
			this.toolStripSplitButtonStepBackward.AccessibleName = "Navigate some data backward";
			this.toolStripSplitButtonStepBackward.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButtonStepBackward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonStepBackward.DropDown = this.contextMenuNavigationStep;
			this.toolStripSplitButtonStepBackward.Image = global::Planetoid_DB.Properties.Resources.silk_backward_green;
			this.toolStripSplitButtonStepBackward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonStepBackward.Name = "toolStripSplitButtonStepBackward";
			this.toolStripSplitButtonStepBackward.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButtonStepBackward.Text = "Navigate some data backward";
			this.toolStripSplitButtonStepBackward.ButtonClick += new System.EventHandler(this.ToolStripButtonStepBackward_Click);
			this.toolStripSplitButtonStepBackward.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButtonStepBackward.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanelData
			// 
			this.tableLayoutPanelData.AccessibleDescription = "Groups the data";
			this.tableLayoutPanelData.AccessibleName = "Table panel";
			this.tableLayoutPanelData.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanelData.BackgroundImage")));
			this.tableLayoutPanelData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanelData.ColumnCount = 4;
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.Controls.Add(this.labelIndexData, 1, 0);
			this.tableLayoutPanelData.Controls.Add(this.labelReadableDesignationData, 1, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelEpochData, 1, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanAnomalyAtTheEpochData, 1, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelArgumentOfPerihelionData, 1, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelLongitudeOfTheAscendingNodeData, 1, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelInclinationToTheEclipticData, 1, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelOrbitalEccentricityData, 1, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanDailyMotionData, 1, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelSemiMajorAxisData, 1, 9);
			this.tableLayoutPanelData.Controls.Add(this.labelAbsoluteMagnitudeData, 1, 10);
			this.tableLayoutPanelData.Controls.Add(this.labelSlopeParameterData, 3, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelReferenceData, 3, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelNumberOfOppositionsData, 3, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelNumberOfObservationsData, 3, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelObservationSpanData, 3, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelRmsResidualData, 3, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelComputerNameData, 3, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelFlagsData, 3, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelDateLastObservationData, 3, 9);
			this.tableLayoutPanelData.Controls.Add(this.labelIndexDesc, 0, 0);
			this.tableLayoutPanelData.Controls.Add(this.labelReadableDesignationDesc, 0, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelEpochDesc, 0, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanAnomalyAtTheEpochDesc, 0, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelArgumentOfPerihelionDesc, 0, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelLongitudeOfTheAscendingNodeDesc, 0, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelInclinationToTheEclipticDesc, 0, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelOrbitalEccentricityDesc, 0, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanDailyMotionDesc, 0, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelSemiMajorAxisDesc, 0, 9);
			this.tableLayoutPanelData.Controls.Add(this.labelAbsoluteMagnitudeDesc, 0, 10);
			this.tableLayoutPanelData.Controls.Add(this.labelSlopeParameterDesc, 2, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelReferenceDesc, 2, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelNumberOfOppositionsDesc, 2, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelNumberOfObservationsDesc, 2, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelObservationSpanDesc, 2, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelRmsResidualDesc, 2, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelComputerNameDesc, 2, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelFlagsDesc, 2, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelDateLastObservationDesc, 2, 9);
			this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelData.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelData.Name = "tableLayoutPanelData";
			this.tableLayoutPanelData.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
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
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanelData.Size = new System.Drawing.Size(804, 290);
			this.tableLayoutPanelData.TabIndex = 0;
			this.tableLayoutPanelData.TabStop = true;
			this.toolTip.SetToolTip(this.tableLayoutPanelData, "table panel");
			this.tableLayoutPanelData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.tableLayoutPanelData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.tableLayoutPanelData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.tableLayoutPanelData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelIndexData
			// 
			this.labelIndexData.AccessibleDescription = "Shows the information of \"Index No.\"";
			this.labelIndexData.AccessibleName = "Shows the information of \"Index No.\"";
			this.labelIndexData.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelIndexData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIndexData.Location = new System.Drawing.Point(273, 3);
			this.labelIndexData.Name = "labelIndexData";
			this.labelIndexData.Size = new System.Drawing.Size(143, 20);
			this.labelIndexData.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelIndexData, "Shows the information of \"Index No.\"");
			this.labelIndexData.Values.Text = "..................";
			this.labelIndexData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelIndexData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelIndexData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelIndexData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelIndexData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelReadableDesignationData
			// 
			this.labelReadableDesignationData.AccessibleDescription = "Shows the information of \"Readable designation\"";
			this.labelReadableDesignationData.AccessibleName = "Shows the information of \"Readable designation\"";
			this.labelReadableDesignationData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReadableDesignationData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReadableDesignationData.Location = new System.Drawing.Point(273, 29);
			this.labelReadableDesignationData.Name = "labelReadableDesignationData";
			this.labelReadableDesignationData.Size = new System.Drawing.Size(143, 20);
			this.labelReadableDesignationData.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelReadableDesignationData, "Shows the information of \"Readable designation\"");
			this.labelReadableDesignationData.Values.Text = "..................";
			this.labelReadableDesignationData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelReadableDesignationData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReadableDesignationData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelReadableDesignationData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReadableDesignationData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEpochData
			// 
			this.labelEpochData.AccessibleDescription = "Shows the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochData.AccessibleName = "Shows the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochData.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelEpochData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEpochData.Location = new System.Drawing.Point(273, 55);
			this.labelEpochData.Name = "labelEpochData";
			this.labelEpochData.Size = new System.Drawing.Size(143, 20);
			this.labelEpochData.TabIndex = 5;
			this.toolTip.SetToolTip(this.labelEpochData, "Shows the information of \"Epoch (in packed form, .0 TT)\"");
			this.labelEpochData.Values.Text = "..................";
			this.labelEpochData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelEpochData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEpochData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEpochData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEpochData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanAnomalyAtTheEpochData
			// 
			this.labelMeanAnomalyAtTheEpochData.AccessibleDescription = "Shows the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyAtTheEpochData.AccessibleName = "Shows the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyAtTheEpochData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanAnomalyAtTheEpochData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAnomalyAtTheEpochData.Location = new System.Drawing.Point(273, 81);
			this.labelMeanAnomalyAtTheEpochData.Name = "labelMeanAnomalyAtTheEpochData";
			this.labelMeanAnomalyAtTheEpochData.Size = new System.Drawing.Size(143, 20);
			this.labelMeanAnomalyAtTheEpochData.TabIndex = 7;
			this.toolTip.SetToolTip(this.labelMeanAnomalyAtTheEpochData, "Shows the information of \"Mean anomaly at the epoch, in degrees\"");
			this.labelMeanAnomalyAtTheEpochData.Values.Text = "..................";
			this.labelMeanAnomalyAtTheEpochData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelMeanAnomalyAtTheEpochData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAnomalyAtTheEpochData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanAnomalyAtTheEpochData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAnomalyAtTheEpochData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelArgumentOfPerihelionData
			// 
			this.labelArgumentOfPerihelionData.AccessibleDescription = "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgumentOfPerihelionData.AccessibleName = "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgumentOfPerihelionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelArgumentOfPerihelionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentOfPerihelionData.Location = new System.Drawing.Point(273, 107);
			this.labelArgumentOfPerihelionData.Name = "labelArgumentOfPerihelionData";
			this.labelArgumentOfPerihelionData.Size = new System.Drawing.Size(143, 20);
			this.labelArgumentOfPerihelionData.TabIndex = 9;
			this.toolTip.SetToolTip(this.labelArgumentOfPerihelionData, "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"");
			this.labelArgumentOfPerihelionData.Values.Text = "..................";
			this.labelArgumentOfPerihelionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelArgumentOfPerihelionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentOfPerihelionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelArgumentOfPerihelionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentOfPerihelionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLongitudeOfTheAscendingNodeData
			// 
			this.labelLongitudeOfTheAscendingNodeData.AccessibleDescription = "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			this.labelLongitudeOfTheAscendingNodeData.AccessibleName = "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			this.labelLongitudeOfTheAscendingNodeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLongitudeOfTheAscendingNodeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeOfTheAscendingNodeData.Location = new System.Drawing.Point(273, 133);
			this.labelLongitudeOfTheAscendingNodeData.Name = "labelLongitudeOfTheAscendingNodeData";
			this.labelLongitudeOfTheAscendingNodeData.Size = new System.Drawing.Size(143, 20);
			this.labelLongitudeOfTheAscendingNodeData.TabIndex = 11;
			this.toolTip.SetToolTip(this.labelLongitudeOfTheAscendingNodeData, "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"");
			this.labelLongitudeOfTheAscendingNodeData.Values.Text = "..................";
			// 
			// labelInclinationToTheEclipticData
			// 
			this.labelInclinationToTheEclipticData.AccessibleDescription = "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclinationToTheEclipticData.AccessibleName = "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclinationToTheEclipticData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelInclinationToTheEclipticData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInclinationToTheEclipticData.Location = new System.Drawing.Point(273, 159);
			this.labelInclinationToTheEclipticData.Name = "labelInclinationToTheEclipticData";
			this.labelInclinationToTheEclipticData.Size = new System.Drawing.Size(143, 20);
			this.labelInclinationToTheEclipticData.TabIndex = 13;
			this.toolTip.SetToolTip(this.labelInclinationToTheEclipticData, "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"");
			this.labelInclinationToTheEclipticData.Values.Text = "..................";
			this.labelInclinationToTheEclipticData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelInclinationToTheEclipticData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInclinationToTheEclipticData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelInclinationToTheEclipticData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInclinationToTheEclipticData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalEccentricityData
			// 
			this.labelOrbitalEccentricityData.AccessibleDescription = "Shows the information of \"Orbital eccentricity\"";
			this.labelOrbitalEccentricityData.AccessibleName = "Shows the information of \"Orbital eccentricity\"";
			this.labelOrbitalEccentricityData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalEccentricityData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalEccentricityData.Location = new System.Drawing.Point(273, 185);
			this.labelOrbitalEccentricityData.Name = "labelOrbitalEccentricityData";
			this.labelOrbitalEccentricityData.Size = new System.Drawing.Size(143, 20);
			this.labelOrbitalEccentricityData.TabIndex = 15;
			this.toolTip.SetToolTip(this.labelOrbitalEccentricityData, "Shows the information of \"Orbital eccentricity\"");
			this.labelOrbitalEccentricityData.Values.Text = "..................";
			this.labelOrbitalEccentricityData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelOrbitalEccentricityData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalEccentricityData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalEccentricityData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalEccentricityData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanDailyMotionData
			// 
			this.labelMeanDailyMotionData.AccessibleDescription = "Shows the information of \"Mean daily motion (degrees per day)\"";
			this.labelMeanDailyMotionData.AccessibleName = "Shows the information of \"Mean daily motion (degrees per day)\"";
			this.labelMeanDailyMotionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanDailyMotionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanDailyMotionData.Location = new System.Drawing.Point(273, 211);
			this.labelMeanDailyMotionData.Name = "labelMeanDailyMotionData";
			this.labelMeanDailyMotionData.Size = new System.Drawing.Size(143, 20);
			this.labelMeanDailyMotionData.TabIndex = 17;
			this.toolTip.SetToolTip(this.labelMeanDailyMotionData, "Shows the information of \"Mean daily motion (degrees per day)\"");
			this.labelMeanDailyMotionData.Values.Text = "..................";
			this.labelMeanDailyMotionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelMeanDailyMotionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanDailyMotionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanDailyMotionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanDailyMotionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMajorAxisData
			// 
			this.labelSemiMajorAxisData.AccessibleDescription = "Shows the information of \"Semi-major axis (AU)\"";
			this.labelSemiMajorAxisData.AccessibleName = "Shows the information of \"Semi-major axis (AU)\"";
			this.labelSemiMajorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMajorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMajorAxisData.Location = new System.Drawing.Point(273, 237);
			this.labelSemiMajorAxisData.Name = "labelSemiMajorAxisData";
			this.labelSemiMajorAxisData.Size = new System.Drawing.Size(143, 20);
			this.labelSemiMajorAxisData.TabIndex = 19;
			this.toolTip.SetToolTip(this.labelSemiMajorAxisData, "Shows the information of \"Semi-major axis (AU)\"");
			this.labelSemiMajorAxisData.Values.Text = "..................";
			this.labelSemiMajorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSemiMajorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMajorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMajorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMajorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAbsoluteMagnitudeData
			// 
			this.labelAbsoluteMagnitudeData.AccessibleDescription = "Shows the information of \"Absolute magnitude, H\"";
			this.labelAbsoluteMagnitudeData.AccessibleName = "Shows the information of \"Absolute magnitude, H\"";
			this.labelAbsoluteMagnitudeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelAbsoluteMagnitudeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAbsoluteMagnitudeData.Location = new System.Drawing.Point(273, 263);
			this.labelAbsoluteMagnitudeData.Name = "labelAbsoluteMagnitudeData";
			this.labelAbsoluteMagnitudeData.Size = new System.Drawing.Size(143, 24);
			this.labelAbsoluteMagnitudeData.TabIndex = 21;
			this.toolTip.SetToolTip(this.labelAbsoluteMagnitudeData, "Shows the information of \"Absolute magnitude, H\"");
			this.labelAbsoluteMagnitudeData.Values.Text = "..................";
			this.labelAbsoluteMagnitudeData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelAbsoluteMagnitudeData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAbsoluteMagnitudeData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAbsoluteMagnitudeData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAbsoluteMagnitudeData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSlopeParameterData
			// 
			this.labelSlopeParameterData.AccessibleDescription = "Shows the information of \"Slope parameter, G\"";
			this.labelSlopeParameterData.AccessibleName = "Shows the information of \"Slope parameter, G\"";
			this.labelSlopeParameterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSlopeParameterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSlopeParameterData.Location = new System.Drawing.Point(650, 29);
			this.labelSlopeParameterData.Name = "labelSlopeParameterData";
			this.labelSlopeParameterData.Size = new System.Drawing.Size(151, 20);
			this.labelSlopeParameterData.TabIndex = 23;
			this.toolTip.SetToolTip(this.labelSlopeParameterData, "Shows the information of \"Slope parameter, G\"");
			this.labelSlopeParameterData.Values.Text = "..................";
			this.labelSlopeParameterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSlopeParameterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSlopeParameterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSlopeParameterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSlopeParameterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelReferenceData
			// 
			this.labelReferenceData.AccessibleDescription = "Shows the information of \"Reference\"";
			this.labelReferenceData.AccessibleName = "Shows the information of \"Reference\"";
			this.labelReferenceData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReferenceData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReferenceData.Location = new System.Drawing.Point(650, 55);
			this.labelReferenceData.Name = "labelReferenceData";
			this.labelReferenceData.Size = new System.Drawing.Size(151, 20);
			this.labelReferenceData.TabIndex = 25;
			this.toolTip.SetToolTip(this.labelReferenceData, "Shows the information of \"Reference\"");
			this.labelReferenceData.Values.Text = "..................";
			this.labelReferenceData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelReferenceData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReferenceData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelReferenceData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReferenceData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNumberOfOppositionsData
			// 
			this.labelNumberOfOppositionsData.AccessibleDescription = "Shows the information of \"Number of oppositions\"";
			this.labelNumberOfOppositionsData.AccessibleName = "Shows the information of \"Number of oppositions\"";
			this.labelNumberOfOppositionsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelNumberOfOppositionsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumberOfOppositionsData.Location = new System.Drawing.Point(650, 81);
			this.labelNumberOfOppositionsData.Name = "labelNumberOfOppositionsData";
			this.labelNumberOfOppositionsData.Size = new System.Drawing.Size(151, 20);
			this.labelNumberOfOppositionsData.TabIndex = 27;
			this.toolTip.SetToolTip(this.labelNumberOfOppositionsData, "Shows the information of \"Number of oppositions\"");
			this.labelNumberOfOppositionsData.Values.Text = "..................";
			this.labelNumberOfOppositionsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelNumberOfOppositionsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfOppositionsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNumberOfOppositionsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfOppositionsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNumberOfObservationsData
			// 
			this.labelNumberOfObservationsData.AccessibleDescription = "Shows the information of \"Number of observations\"";
			this.labelNumberOfObservationsData.AccessibleName = "Shows the information of \"Number of observations\"";
			this.labelNumberOfObservationsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelNumberOfObservationsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumberOfObservationsData.Location = new System.Drawing.Point(650, 107);
			this.labelNumberOfObservationsData.Name = "labelNumberOfObservationsData";
			this.labelNumberOfObservationsData.Size = new System.Drawing.Size(151, 20);
			this.labelNumberOfObservationsData.TabIndex = 29;
			this.toolTip.SetToolTip(this.labelNumberOfObservationsData, "Shows the information of \"Number of observations\"");
			this.labelNumberOfObservationsData.Values.Text = "..................";
			this.labelNumberOfObservationsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelNumberOfObservationsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfObservationsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNumberOfObservationsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfObservationsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelObservationSpanData
			// 
			this.labelObservationSpanData.AccessibleDescription = "Shows the information of \"Observation span\"";
			this.labelObservationSpanData.AccessibleName = "Shows the information of \"Observation span\"";
			this.labelObservationSpanData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelObservationSpanData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelObservationSpanData.Location = new System.Drawing.Point(650, 133);
			this.labelObservationSpanData.Name = "labelObservationSpanData";
			this.labelObservationSpanData.Size = new System.Drawing.Size(151, 20);
			this.labelObservationSpanData.TabIndex = 31;
			this.toolTip.SetToolTip(this.labelObservationSpanData, "Shows the information of \"Observation span\"");
			this.labelObservationSpanData.Values.Text = "..................";
			this.labelObservationSpanData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelObservationSpanData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelObservationSpanData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelObservationSpanData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelObservationSpanData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelRmsResidualData
			// 
			this.labelRmsResidualData.AccessibleDescription = "Shows the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualData.AccessibleName = "Shows the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRmsResidualData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRmsResidualData.Location = new System.Drawing.Point(650, 159);
			this.labelRmsResidualData.Name = "labelRmsResidualData";
			this.labelRmsResidualData.Size = new System.Drawing.Size(151, 20);
			this.labelRmsResidualData.TabIndex = 33;
			this.toolTip.SetToolTip(this.labelRmsResidualData, "Shows the information of \"r.m.s residual (\")\"");
			this.labelRmsResidualData.Values.Text = "..................";
			this.labelRmsResidualData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelRmsResidualData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRmsResidualData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelRmsResidualData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRmsResidualData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelComputerNameData
			// 
			this.labelComputerNameData.AccessibleDescription = "Shows the information of \"Computer name\"";
			this.labelComputerNameData.AccessibleName = "Shows the information of \"Computer name\"";
			this.labelComputerNameData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelComputerNameData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComputerNameData.Location = new System.Drawing.Point(650, 185);
			this.labelComputerNameData.Name = "labelComputerNameData";
			this.labelComputerNameData.Size = new System.Drawing.Size(151, 20);
			this.labelComputerNameData.TabIndex = 35;
			this.toolTip.SetToolTip(this.labelComputerNameData, "Shows the information of \"Computer name\"");
			this.labelComputerNameData.Values.Text = "..................";
			this.labelComputerNameData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelComputerNameData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelComputerNameData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelComputerNameData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelComputerNameData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelFlagsData
			// 
			this.labelFlagsData.AccessibleDescription = "Shows the information of \"4-hexdigit flags\"";
			this.labelFlagsData.AccessibleName = "Shows the information of \"4-hexdigit flags\"";
			this.labelFlagsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFlagsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFlagsData.Location = new System.Drawing.Point(650, 211);
			this.labelFlagsData.Name = "labelFlagsData";
			this.labelFlagsData.Size = new System.Drawing.Size(151, 20);
			this.labelFlagsData.TabIndex = 37;
			this.toolTip.SetToolTip(this.labelFlagsData, "Shows the information of \"4-hexdigit flags\"");
			this.labelFlagsData.Values.Text = "..................";
			this.labelFlagsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelFlagsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFlagsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelFlagsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFlagsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateLastObservationData
			// 
			this.labelDateLastObservationData.AccessibleDescription = "Shows the information of \"Date of last observation\"";
			this.labelDateLastObservationData.AccessibleName = "Shows the information of \"Date of last observation\"";
			this.labelDateLastObservationData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateLastObservationData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateLastObservationData.Location = new System.Drawing.Point(650, 237);
			this.labelDateLastObservationData.Name = "labelDateLastObservationData";
			this.labelDateLastObservationData.Size = new System.Drawing.Size(151, 20);
			this.labelDateLastObservationData.TabIndex = 39;
			this.toolTip.SetToolTip(this.labelDateLastObservationData, "Shows the information of \"Date of last observation\"");
			this.labelDateLastObservationData.Values.Text = "..................";
			this.labelDateLastObservationData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateLastObservationData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateLastObservationData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateLastObservationData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateLastObservationData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelIndexDesc
			// 
			this.labelIndexDesc.AccessibleDescription = "Index No.";
			this.labelIndexDesc.AccessibleName = "Index No.";
			this.labelIndexDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelIndexDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIndexDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.labelIndexDesc.Location = new System.Drawing.Point(3, 3);
			this.labelIndexDesc.Name = "labelIndexDesc";
			this.labelIndexDesc.Size = new System.Drawing.Size(264, 20);
			this.labelIndexDesc.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelIndexDesc, "Index No.");
			this.labelIndexDesc.Values.Text = "Index No.";
			this.labelIndexDesc.DoubleClick += new System.EventHandler(this.LabelIndexDesc_DoubleClick);
			this.labelIndexDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelIndexDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelIndexDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelIndexDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelReadableDesignationDesc
			// 
			this.labelReadableDesignationDesc.AccessibleDescription = "Readable designation";
			this.labelReadableDesignationDesc.AccessibleName = "Readable designation";
			this.labelReadableDesignationDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReadableDesignationDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReadableDesignationDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelReadableDesignationDesc.Location = new System.Drawing.Point(3, 29);
			this.labelReadableDesignationDesc.Name = "labelReadableDesignationDesc";
			this.labelReadableDesignationDesc.Size = new System.Drawing.Size(264, 20);
			this.labelReadableDesignationDesc.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelReadableDesignationDesc, "Readable designation");
			this.labelReadableDesignationDesc.Values.Text = "Readable designation";
			this.labelReadableDesignationDesc.DoubleClick += new System.EventHandler(this.LabelReadableDesignationNameDesc_DoubleClick);
			this.labelReadableDesignationDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReadableDesignationDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelReadableDesignationDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReadableDesignationDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEpochDesc
			// 
			this.labelEpochDesc.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			this.labelEpochDesc.AccessibleName = "Epoch (in packed form, .0 TT)";
			this.labelEpochDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEpochDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEpochDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelEpochDesc.Location = new System.Drawing.Point(3, 55);
			this.labelEpochDesc.Name = "labelEpochDesc";
			this.labelEpochDesc.Size = new System.Drawing.Size(264, 20);
			this.labelEpochDesc.TabIndex = 4;
			this.toolTip.SetToolTip(this.labelEpochDesc, "Epoch (in packed form, .0 TT)");
			this.labelEpochDesc.Values.Text = "Epoch (in packed form, .0 TT)";
			this.labelEpochDesc.DoubleClick += new System.EventHandler(this.LabelEpochDesc_DoubleClick);
			this.labelEpochDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEpochDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEpochDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEpochDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanAnomalyAtTheEpochDesc
			// 
			this.labelMeanAnomalyAtTheEpochDesc.AccessibleDescription = "Mean anomaly at the epoch (degrees)";
			this.labelMeanAnomalyAtTheEpochDesc.AccessibleName = "Mean anomaly at the epoch (degrees)";
			this.labelMeanAnomalyAtTheEpochDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanAnomalyAtTheEpochDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAnomalyAtTheEpochDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelMeanAnomalyAtTheEpochDesc.Location = new System.Drawing.Point(3, 81);
			this.labelMeanAnomalyAtTheEpochDesc.Name = "labelMeanAnomalyAtTheEpochDesc";
			this.labelMeanAnomalyAtTheEpochDesc.Size = new System.Drawing.Size(264, 20);
			this.labelMeanAnomalyAtTheEpochDesc.TabIndex = 6;
			this.toolTip.SetToolTip(this.labelMeanAnomalyAtTheEpochDesc, "Mean anomaly at the epoch (degrees)");
			this.labelMeanAnomalyAtTheEpochDesc.Values.ExtraText = "°";
			this.labelMeanAnomalyAtTheEpochDesc.Values.Text = "Mean anomaly at the epoch";
			this.labelMeanAnomalyAtTheEpochDesc.DoubleClick += new System.EventHandler(this.KryptonLabelMeanAnomalyAtTheEpochDesc_DoubleClick);
			this.labelMeanAnomalyAtTheEpochDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAnomalyAtTheEpochDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanAnomalyAtTheEpochDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAnomalyAtTheEpochDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelArgumentOfPerihelionDesc
			// 
			this.labelArgumentOfPerihelionDesc.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgumentOfPerihelionDesc.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgumentOfPerihelionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelArgumentOfPerihelionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentOfPerihelionDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelArgumentOfPerihelionDesc.Location = new System.Drawing.Point(3, 107);
			this.labelArgumentOfPerihelionDesc.Name = "labelArgumentOfPerihelionDesc";
			this.labelArgumentOfPerihelionDesc.Size = new System.Drawing.Size(264, 20);
			this.labelArgumentOfPerihelionDesc.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelArgumentOfPerihelionDesc, "Argument of perihelion, J2000.0 (degrees)");
			this.labelArgumentOfPerihelionDesc.Values.ExtraText = "°";
			this.labelArgumentOfPerihelionDesc.Values.Text = "Argument of perihelion, J2000.0";
			this.labelArgumentOfPerihelionDesc.DoubleClick += new System.EventHandler(this.LabelArgumentOfPerihelionDesc_DoubleClick);
			this.labelArgumentOfPerihelionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentOfPerihelionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelArgumentOfPerihelionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentOfPerihelionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLongitudeOfTheAscendingNodeDesc
			// 
			this.labelLongitudeOfTheAscendingNodeDesc.AccessibleDescription = "Longitude of the ascending node, J2000.0 (degrees)";
			this.labelLongitudeOfTheAscendingNodeDesc.AccessibleName = "Longitude of the ascending node, J2000.0 (degrees)";
			this.labelLongitudeOfTheAscendingNodeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLongitudeOfTheAscendingNodeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeOfTheAscendingNodeDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelLongitudeOfTheAscendingNodeDesc.Location = new System.Drawing.Point(3, 133);
			this.labelLongitudeOfTheAscendingNodeDesc.Name = "labelLongitudeOfTheAscendingNodeDesc";
			this.labelLongitudeOfTheAscendingNodeDesc.Size = new System.Drawing.Size(264, 20);
			this.labelLongitudeOfTheAscendingNodeDesc.TabIndex = 10;
			this.toolTip.SetToolTip(this.labelLongitudeOfTheAscendingNodeDesc, "Longitude of the ascending node, J2000.0 (degrees)");
			this.labelLongitudeOfTheAscendingNodeDesc.Values.ExtraText = "°";
			this.labelLongitudeOfTheAscendingNodeDesc.Values.Text = "Longitude of the ascending node, J2000.0";
			this.labelLongitudeOfTheAscendingNodeDesc.DoubleClick += new System.EventHandler(this.LabelLongitudeOfTheAscendingNodeDesc_DoubleClick);
			this.labelLongitudeOfTheAscendingNodeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeOfTheAscendingNodeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLongitudeOfTheAscendingNodeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeOfTheAscendingNodeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelInclinationToTheEclipticDesc
			// 
			this.labelInclinationToTheEclipticDesc.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelInclinationToTheEclipticDesc.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelInclinationToTheEclipticDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelInclinationToTheEclipticDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInclinationToTheEclipticDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelInclinationToTheEclipticDesc.Location = new System.Drawing.Point(3, 159);
			this.labelInclinationToTheEclipticDesc.Name = "labelInclinationToTheEclipticDesc";
			this.labelInclinationToTheEclipticDesc.Size = new System.Drawing.Size(264, 20);
			this.labelInclinationToTheEclipticDesc.TabIndex = 12;
			this.toolTip.SetToolTip(this.labelInclinationToTheEclipticDesc, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.labelInclinationToTheEclipticDesc.Values.ExtraText = "°";
			this.labelInclinationToTheEclipticDesc.Values.Text = "Inclination to the ecliptic, J2000.0";
			this.labelInclinationToTheEclipticDesc.DoubleClick += new System.EventHandler(this.LabelInclinationToTheEclipticDesc_DoubleClick);
			this.labelInclinationToTheEclipticDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInclinationToTheEclipticDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelInclinationToTheEclipticDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInclinationToTheEclipticDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalEccentricityDesc
			// 
			this.labelOrbitalEccentricityDesc.AccessibleDescription = "Orbital eccentricity";
			this.labelOrbitalEccentricityDesc.AccessibleName = "Orbital eccentricity";
			this.labelOrbitalEccentricityDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalEccentricityDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalEccentricityDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelOrbitalEccentricityDesc.Location = new System.Drawing.Point(3, 185);
			this.labelOrbitalEccentricityDesc.Name = "labelOrbitalEccentricityDesc";
			this.labelOrbitalEccentricityDesc.Size = new System.Drawing.Size(264, 20);
			this.labelOrbitalEccentricityDesc.TabIndex = 14;
			this.toolTip.SetToolTip(this.labelOrbitalEccentricityDesc, "Orbital eccentricity");
			this.labelOrbitalEccentricityDesc.Values.Text = "Orbital eccentricity";
			this.labelOrbitalEccentricityDesc.DoubleClick += new System.EventHandler(this.LabelOrbitalEccentricityDesc_DoubleClick);
			this.labelOrbitalEccentricityDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalEccentricityDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalEccentricityDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalEccentricityDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanDailyMotionDesc
			// 
			this.labelMeanDailyMotionDesc.AccessibleDescription = "Mean daily motion (degrees per day)";
			this.labelMeanDailyMotionDesc.AccessibleName = "Mean daily motion (degrees per day)";
			this.labelMeanDailyMotionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanDailyMotionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanDailyMotionDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelMeanDailyMotionDesc.Location = new System.Drawing.Point(3, 211);
			this.labelMeanDailyMotionDesc.Name = "labelMeanDailyMotionDesc";
			this.labelMeanDailyMotionDesc.Size = new System.Drawing.Size(264, 20);
			this.labelMeanDailyMotionDesc.TabIndex = 16;
			this.toolTip.SetToolTip(this.labelMeanDailyMotionDesc, "Mean daily motion (degrees per day)");
			this.labelMeanDailyMotionDesc.Values.ExtraText = "°/day";
			this.labelMeanDailyMotionDesc.Values.Text = "Mean daily motion";
			this.labelMeanDailyMotionDesc.DoubleClick += new System.EventHandler(this.LabelMeanDailyMotionDesc_DoubleClick);
			this.labelMeanDailyMotionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanDailyMotionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanDailyMotionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanDailyMotionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMajorAxisDesc
			// 
			this.labelSemiMajorAxisDesc.AccessibleDescription = "Semi-major axis (AU)";
			this.labelSemiMajorAxisDesc.AccessibleName = "Semi-major axis (AU)";
			this.labelSemiMajorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMajorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMajorAxisDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelSemiMajorAxisDesc.Location = new System.Drawing.Point(3, 237);
			this.labelSemiMajorAxisDesc.Name = "labelSemiMajorAxisDesc";
			this.labelSemiMajorAxisDesc.Size = new System.Drawing.Size(264, 20);
			this.labelSemiMajorAxisDesc.TabIndex = 18;
			this.toolTip.SetToolTip(this.labelSemiMajorAxisDesc, "Semi-major axis (AU)");
			this.labelSemiMajorAxisDesc.Values.ExtraText = "AU";
			this.labelSemiMajorAxisDesc.Values.Text = "Semi-major axis";
			this.labelSemiMajorAxisDesc.DoubleClick += new System.EventHandler(this.LabelSemiMajorAxisDesc_DoubleClick);
			this.labelSemiMajorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMajorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMajorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMajorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAbsoluteMagnitudeDesc
			// 
			this.labelAbsoluteMagnitudeDesc.AccessibleDescription = "Absolute magnitude, H";
			this.labelAbsoluteMagnitudeDesc.AccessibleName = "Absolute magnitude, H";
			this.labelAbsoluteMagnitudeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelAbsoluteMagnitudeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAbsoluteMagnitudeDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelAbsoluteMagnitudeDesc.Location = new System.Drawing.Point(3, 263);
			this.labelAbsoluteMagnitudeDesc.Name = "labelAbsoluteMagnitudeDesc";
			this.labelAbsoluteMagnitudeDesc.Size = new System.Drawing.Size(264, 24);
			this.labelAbsoluteMagnitudeDesc.TabIndex = 20;
			this.toolTip.SetToolTip(this.labelAbsoluteMagnitudeDesc, "Absolute magnitude, H");
			this.labelAbsoluteMagnitudeDesc.Values.ExtraText = "mag";
			this.labelAbsoluteMagnitudeDesc.Values.Text = "Absolute magnitude, H";
			this.labelAbsoluteMagnitudeDesc.DoubleClick += new System.EventHandler(this.LabelAbsoluteMagnitudeDesc_DoubleClick);
			this.labelAbsoluteMagnitudeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAbsoluteMagnitudeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAbsoluteMagnitudeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAbsoluteMagnitudeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSlopeParameterDesc
			// 
			this.labelSlopeParameterDesc.AccessibleDescription = "Slope parameter, G";
			this.labelSlopeParameterDesc.AccessibleName = "Slope parameter, G";
			this.labelSlopeParameterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSlopeParameterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSlopeParameterDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.labelSlopeParameterDesc.Location = new System.Drawing.Point(422, 29);
			this.labelSlopeParameterDesc.Name = "labelSlopeParameterDesc";
			this.labelSlopeParameterDesc.Size = new System.Drawing.Size(222, 20);
			this.labelSlopeParameterDesc.TabIndex = 22;
			this.toolTip.SetToolTip(this.labelSlopeParameterDesc, "Slope parameter, G");
			this.labelSlopeParameterDesc.Values.Text = "Slope parameter, G";
			this.labelSlopeParameterDesc.DoubleClick += new System.EventHandler(this.LabelSlopeParameterDesc_DoubleClick);
			this.labelSlopeParameterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSlopeParameterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSlopeParameterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSlopeParameterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelReferenceDesc
			// 
			this.labelReferenceDesc.AccessibleDescription = "Reference";
			this.labelReferenceDesc.AccessibleName = "Reference";
			this.labelReferenceDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReferenceDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReferenceDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelReferenceDesc.Location = new System.Drawing.Point(422, 55);
			this.labelReferenceDesc.Name = "labelReferenceDesc";
			this.labelReferenceDesc.Size = new System.Drawing.Size(222, 20);
			this.labelReferenceDesc.TabIndex = 24;
			this.toolTip.SetToolTip(this.labelReferenceDesc, "Reference");
			this.labelReferenceDesc.Values.Text = "Reference";
			this.labelReferenceDesc.DoubleClick += new System.EventHandler(this.LabelReferenceDesc_DoubleClick);
			this.labelReferenceDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReferenceDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelReferenceDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReferenceDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNumberOfOppositionsDesc
			// 
			this.labelNumberOfOppositionsDesc.AccessibleDescription = "Number of oppositions";
			this.labelNumberOfOppositionsDesc.AccessibleName = "Number of oppositions";
			this.labelNumberOfOppositionsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelNumberOfOppositionsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumberOfOppositionsDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelNumberOfOppositionsDesc.Location = new System.Drawing.Point(422, 81);
			this.labelNumberOfOppositionsDesc.Name = "labelNumberOfOppositionsDesc";
			this.labelNumberOfOppositionsDesc.Size = new System.Drawing.Size(222, 20);
			this.labelNumberOfOppositionsDesc.TabIndex = 26;
			this.toolTip.SetToolTip(this.labelNumberOfOppositionsDesc, "Number of oppositions");
			this.labelNumberOfOppositionsDesc.Values.Text = "Number of oppositions";
			this.labelNumberOfOppositionsDesc.DoubleClick += new System.EventHandler(this.LabelNumberOfOppositionsDesc_DoubleClick);
			this.labelNumberOfOppositionsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfOppositionsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNumberOfOppositionsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfOppositionsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNumberOfObservationsDesc
			// 
			this.labelNumberOfObservationsDesc.AccessibleDescription = "Number of observations";
			this.labelNumberOfObservationsDesc.AccessibleName = "Number of observations";
			this.labelNumberOfObservationsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelNumberOfObservationsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumberOfObservationsDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelNumberOfObservationsDesc.Location = new System.Drawing.Point(422, 107);
			this.labelNumberOfObservationsDesc.Name = "labelNumberOfObservationsDesc";
			this.labelNumberOfObservationsDesc.Size = new System.Drawing.Size(222, 20);
			this.labelNumberOfObservationsDesc.TabIndex = 28;
			this.toolTip.SetToolTip(this.labelNumberOfObservationsDesc, "Number of observations");
			this.labelNumberOfObservationsDesc.Values.Text = "Number of observations";
			this.labelNumberOfObservationsDesc.DoubleClick += new System.EventHandler(this.LabelNumberOfObservationsDesc_DoubleClick);
			this.labelNumberOfObservationsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfObservationsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNumberOfObservationsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOfObservationsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelObservationSpanDesc
			// 
			this.labelObservationSpanDesc.AccessibleDescription = "Observation span";
			this.labelObservationSpanDesc.AccessibleName = "Observation span";
			this.labelObservationSpanDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelObservationSpanDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelObservationSpanDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelObservationSpanDesc.Location = new System.Drawing.Point(422, 133);
			this.labelObservationSpanDesc.Name = "labelObservationSpanDesc";
			this.labelObservationSpanDesc.Size = new System.Drawing.Size(222, 20);
			this.labelObservationSpanDesc.TabIndex = 30;
			this.toolTip.SetToolTip(this.labelObservationSpanDesc, "Observation span");
			this.labelObservationSpanDesc.Values.Text = "Observation span";
			this.labelObservationSpanDesc.DoubleClick += new System.EventHandler(this.LabelObservationSpanDesc_DoubleClick);
			this.labelObservationSpanDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelObservationSpanDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelObservationSpanDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelObservationSpanDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelRmsResidualDesc
			// 
			this.labelRmsResidualDesc.AccessibleDescription = "r.m.s. residual (arcseconds)";
			this.labelRmsResidualDesc.AccessibleName = "r.m.s. residual (arcseconds)";
			this.labelRmsResidualDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRmsResidualDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRmsResidualDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelRmsResidualDesc.Location = new System.Drawing.Point(422, 159);
			this.labelRmsResidualDesc.Name = "labelRmsResidualDesc";
			this.labelRmsResidualDesc.Size = new System.Drawing.Size(222, 20);
			this.labelRmsResidualDesc.TabIndex = 32;
			this.toolTip.SetToolTip(this.labelRmsResidualDesc, "r.m.s. residual (arcseconds)");
			this.labelRmsResidualDesc.Values.ExtraText = "\"";
			this.labelRmsResidualDesc.Values.Text = "r.m.s. residual";
			this.labelRmsResidualDesc.DoubleClick += new System.EventHandler(this.LabelRmsResidualDesc_DoubleClick);
			this.labelRmsResidualDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRmsResidualDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelRmsResidualDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRmsResidualDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelComputerNameDesc
			// 
			this.labelComputerNameDesc.AccessibleDescription = "Computer name";
			this.labelComputerNameDesc.AccessibleName = "Computer name";
			this.labelComputerNameDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelComputerNameDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComputerNameDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelComputerNameDesc.Location = new System.Drawing.Point(422, 185);
			this.labelComputerNameDesc.Name = "labelComputerNameDesc";
			this.labelComputerNameDesc.Size = new System.Drawing.Size(222, 20);
			this.labelComputerNameDesc.TabIndex = 34;
			this.toolTip.SetToolTip(this.labelComputerNameDesc, "Computer name");
			this.labelComputerNameDesc.Values.Text = "Computer name";
			this.labelComputerNameDesc.DoubleClick += new System.EventHandler(this.LabelComputerNameDesc_DoubleClick);
			this.labelComputerNameDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelComputerNameDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelComputerNameDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelComputerNameDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelFlagsDesc
			// 
			this.labelFlagsDesc.AccessibleDescription = "4-hexdigit flags";
			this.labelFlagsDesc.AccessibleName = "4-hexdigit flags";
			this.labelFlagsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFlagsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFlagsDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelFlagsDesc.Location = new System.Drawing.Point(422, 211);
			this.labelFlagsDesc.Name = "labelFlagsDesc";
			this.labelFlagsDesc.Size = new System.Drawing.Size(222, 20);
			this.labelFlagsDesc.TabIndex = 36;
			this.toolTip.SetToolTip(this.labelFlagsDesc, "4-hexdigit flags");
			this.labelFlagsDesc.Values.Text = "4-hexdigit flags";
			this.labelFlagsDesc.DoubleClick += new System.EventHandler(this.LabelFlagsDesc_DoubleClick);
			this.labelFlagsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFlagsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelFlagsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFlagsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateLastObservationDesc
			// 
			this.labelDateLastObservationDesc.AccessibleDescription = "Date of last observation (YYYYMMDD)";
			this.labelDateLastObservationDesc.AccessibleName = "Date of last observation (YYYYMMDD)";
			this.labelDateLastObservationDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateLastObservationDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateLastObservationDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelDateLastObservationDesc.Location = new System.Drawing.Point(422, 237);
			this.labelDateLastObservationDesc.Name = "labelDateLastObservationDesc";
			this.labelDateLastObservationDesc.Size = new System.Drawing.Size(222, 20);
			this.labelDateLastObservationDesc.TabIndex = 38;
			this.toolTip.SetToolTip(this.labelDateLastObservationDesc, "Date of last observation (YYYYMMDD)");
			this.labelDateLastObservationDesc.Values.ExtraText = "YYYYMMDD";
			this.labelDateLastObservationDesc.Values.Text = "Date of last observation";
			this.labelDateLastObservationDesc.DoubleClick += new System.EventHandler(this.LabelDateLastObservationDesc_DoubleClick);
			this.labelDateLastObservationDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateLastObservationDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateLastObservationDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateLastObservationDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuTopTenRecords
			// 
			this.contextMenuTopTenRecords.AccessibleDescription = "Shows the context menu of the top ten records";
			this.contextMenuTopTenRecords.AccessibleName = "context menu of the top ten records";
			this.contextMenuTopTenRecords.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuTopTenRecords.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuTopTenRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemRecordsSortDirection,
            this.toolStripSeparator12,
            this.menuitemRecordsMeanAnomalyAtTheEpoch,
            this.menuitemRecordsArgumentOfPerihelion,
            this.menuitemRecordsLongitudeOfTheAscendingNode,
            this.menuitemRecordsInclination,
            this.menuitemRecordsOrbitalEccentricity,
            this.menuitemRecordsMeanDailyMotion,
            this.menuitemRecordsSemiMajorAxis,
            this.menuitemRecordsAbsoluteMagnitude,
            this.menuitemRecordsSlopeParameter,
            this.menuitemRecordsNumberOfOppositions,
            this.menuitemRecordsNumberOfObservations,
            this.menuitemRecordsObservationSpan,
            this.menuitemRecordsRmsResidual,
            this.menuitemRecordsComputername,
            this.menuitemRecordsDateOfTheLastObservation});
			this.contextMenuTopTenRecords.Name = "contextMenuTopTenRecords";
			this.contextMenuTopTenRecords.OwnerItem = this.splitbuttonTopTenRecords;
			this.contextMenuTopTenRecords.Size = new System.Drawing.Size(250, 362);
			this.contextMenuTopTenRecords.TabStop = true;
			this.contextMenuTopTenRecords.Text = "Top ten records";
			this.toolTip.SetToolTip(this.contextMenuTopTenRecords, "Top ten records");
			this.contextMenuTopTenRecords.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.contextMenuTopTenRecords.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsSortDirection
			// 
			this.menuitemRecordsSortDirection.AccessibleDescription = "Shows the sort direction of the top ten records";
			this.menuitemRecordsSortDirection.AccessibleName = "Sort direction";
			this.menuitemRecordsSortDirection.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemRecordsSortDirection.AutoToolTip = true;
			this.menuitemRecordsSortDirection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemRecordsSortDirectionAscending,
            this.menuitemRecordsSortDirectionDescending});
			this.menuitemRecordsSortDirection.Enabled = false;
			this.menuitemRecordsSortDirection.Image = global::Planetoid_DB.Properties.Resources.silk_cog;
			this.menuitemRecordsSortDirection.Name = "menuitemRecordsSortDirection";
			this.menuitemRecordsSortDirection.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsSortDirection.Text = "Sort direction";
			this.menuitemRecordsSortDirection.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsSortDirection.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsSortDirectionAscending
			// 
			this.menuitemRecordsSortDirectionAscending.AccessibleDescription = "Chooses the ascending sort direction of the top ten records";
			this.menuitemRecordsSortDirectionAscending.AccessibleName = "Sorted ascending";
			this.menuitemRecordsSortDirectionAscending.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsSortDirectionAscending.Checked = true;
			this.menuitemRecordsSortDirectionAscending.CheckOnClick = true;
			this.menuitemRecordsSortDirectionAscending.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemRecordsSortDirectionAscending.Enabled = false;
			this.menuitemRecordsSortDirectionAscending.Name = "menuitemRecordsSortDirectionAscending";
			this.menuitemRecordsSortDirectionAscending.Size = new System.Drawing.Size(136, 22);
			this.menuitemRecordsSortDirectionAscending.Text = "Ascending";
			this.menuitemRecordsSortDirectionAscending.ToolTipText = "Ascending sort direction";
			this.menuitemRecordsSortDirectionAscending.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsSortDirectionAscending.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsSortDirectionDescending
			// 
			this.menuitemRecordsSortDirectionDescending.AccessibleDescription = "Chooses the descending sort direction of the top ten records";
			this.menuitemRecordsSortDirectionDescending.AccessibleName = "Sorted descending";
			this.menuitemRecordsSortDirectionDescending.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsSortDirectionDescending.CheckOnClick = true;
			this.menuitemRecordsSortDirectionDescending.Enabled = false;
			this.menuitemRecordsSortDirectionDescending.Name = "menuitemRecordsSortDirectionDescending";
			this.menuitemRecordsSortDirectionDescending.Size = new System.Drawing.Size(136, 22);
			this.menuitemRecordsSortDirectionDescending.Text = "Descending";
			this.menuitemRecordsSortDirectionDescending.ToolTipText = "Descending sort direction";
			this.menuitemRecordsSortDirectionDescending.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsSortDirectionDescending.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.AccessibleDescription = "Just a separator";
			this.toolStripSeparator12.AccessibleName = "Just a separator";
			this.toolStripSeparator12.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(246, 6);
			this.toolStripSeparator12.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator12.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsMeanAnomalyAtTheEpoch
			// 
			this.menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the record of the mean anomaly at the epoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleName = "Record of the mean anomaly at the epoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Enabled = false;
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsMeanAnomalyAtTheEpoch.Image")));
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Name = "menuitemRecordsMeanAnomalyAtTheEpoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Click += new System.EventHandler(this.MenuitemRecordsMeanAnomalyAtTheEpoch_Click);
			this.menuitemRecordsMeanAnomalyAtTheEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsMeanAnomalyAtTheEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsArgumentOfPerihelion
			// 
			this.menuitemRecordsArgumentOfPerihelion.AccessibleDescription = "Shows the record of the argument of the perihelion";
			this.menuitemRecordsArgumentOfPerihelion.AccessibleName = "Record of the argument of the perihelion";
			this.menuitemRecordsArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsArgumentOfPerihelion.Enabled = false;
			this.menuitemRecordsArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsArgumentOfPerihelion.Image")));
			this.menuitemRecordsArgumentOfPerihelion.Name = "menuitemRecordsArgumentOfPerihelion";
			this.menuitemRecordsArgumentOfPerihelion.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsArgumentOfPerihelion.Text = "Argument of perihelion";
			this.menuitemRecordsArgumentOfPerihelion.Click += new System.EventHandler(this.MenuitemRecordsArgumentOfPerihelion_Click);
			this.menuitemRecordsArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsLongitudeOfTheAscendingNode
			// 
			this.menuitemRecordsLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the record of the longitude of the ascending node";
			this.menuitemRecordsLongitudeOfTheAscendingNode.AccessibleName = "Record of the longitude of the ascending node";
			this.menuitemRecordsLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsLongitudeOfTheAscendingNode.Enabled = false;
			this.menuitemRecordsLongitudeOfTheAscendingNode.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsLongitudeOfTheAscendingNode.Image")));
			this.menuitemRecordsLongitudeOfTheAscendingNode.Name = "menuitemRecordsLongitudeOfTheAscendingNode";
			this.menuitemRecordsLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node";
			this.menuitemRecordsLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.MenuitemRecordsLongitudeOfTheAscendingNode_Click);
			this.menuitemRecordsLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsInclination
			// 
			this.menuitemRecordsInclination.AccessibleDescription = "Shows the record of the inclination to the ecliptic";
			this.menuitemRecordsInclination.AccessibleName = "Record of the inclination to the ecliptic";
			this.menuitemRecordsInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsInclination.Enabled = false;
			this.menuitemRecordsInclination.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsInclination.Image")));
			this.menuitemRecordsInclination.Name = "menuitemRecordsInclination";
			this.menuitemRecordsInclination.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsInclination.Text = "Inclination to the ecliptic";
			this.menuitemRecordsInclination.Click += new System.EventHandler(this.MenuitemRecordsInclination_Click);
			this.menuitemRecordsInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsOrbitalEccentricity
			// 
			this.menuitemRecordsOrbitalEccentricity.AccessibleDescription = "Shows the record of the orbital eccentricity";
			this.menuitemRecordsOrbitalEccentricity.AccessibleName = "Record of the orbital eccentricity";
			this.menuitemRecordsOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsOrbitalEccentricity.Enabled = false;
			this.menuitemRecordsOrbitalEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsOrbitalEccentricity.Image")));
			this.menuitemRecordsOrbitalEccentricity.Name = "menuitemRecordsOrbitalEccentricity";
			this.menuitemRecordsOrbitalEccentricity.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemRecordsOrbitalEccentricity.Click += new System.EventHandler(this.MenuitemRecordsOrbitalEccentricity_Click);
			this.menuitemRecordsOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsMeanDailyMotion
			// 
			this.menuitemRecordsMeanDailyMotion.AccessibleDescription = "Shows the record of the mean daily motion";
			this.menuitemRecordsMeanDailyMotion.AccessibleName = "Record of the mean daily motion";
			this.menuitemRecordsMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsMeanDailyMotion.Enabled = false;
			this.menuitemRecordsMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsMeanDailyMotion.Image")));
			this.menuitemRecordsMeanDailyMotion.Name = "menuitemRecordsMeanDailyMotion";
			this.menuitemRecordsMeanDailyMotion.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsMeanDailyMotion.Text = "Mean daily motion";
			this.menuitemRecordsMeanDailyMotion.Click += new System.EventHandler(this.MenuitemRecordsMeanDailyMotion_Click);
			this.menuitemRecordsMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsSemiMajorAxis
			// 
			this.menuitemRecordsSemiMajorAxis.AccessibleDescription = "Shows the record of the semi-major axis";
			this.menuitemRecordsSemiMajorAxis.AccessibleName = "Record of the semi-major axis";
			this.menuitemRecordsSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsSemiMajorAxis.Enabled = false;
			this.menuitemRecordsSemiMajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsSemiMajorAxis.Image")));
			this.menuitemRecordsSemiMajorAxis.Name = "menuitemRecordsSemiMajorAxis";
			this.menuitemRecordsSemiMajorAxis.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsSemiMajorAxis.Text = "Semi-major axis";
			this.menuitemRecordsSemiMajorAxis.Click += new System.EventHandler(this.MenuitemRecordsSemiMajorAxis_Click);
			this.menuitemRecordsSemiMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsSemiMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsAbsoluteMagnitude
			// 
			this.menuitemRecordsAbsoluteMagnitude.AccessibleDescription = "Shows the record of the absolute magnitude";
			this.menuitemRecordsAbsoluteMagnitude.AccessibleName = "Record of the absolute magnitude";
			this.menuitemRecordsAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsAbsoluteMagnitude.Enabled = false;
			this.menuitemRecordsAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsAbsoluteMagnitude.Image")));
			this.menuitemRecordsAbsoluteMagnitude.Name = "menuitemRecordsAbsoluteMagnitude";
			this.menuitemRecordsAbsoluteMagnitude.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsAbsoluteMagnitude.Text = "Absolute magnitude";
			this.menuitemRecordsAbsoluteMagnitude.Click += new System.EventHandler(this.MenuitemRecordsAbsoluteMagnitude_Click);
			this.menuitemRecordsAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsSlopeParameter
			// 
			this.menuitemRecordsSlopeParameter.AccessibleDescription = "Shows the record of the slope parameter";
			this.menuitemRecordsSlopeParameter.AccessibleName = "Record of the slope parameter";
			this.menuitemRecordsSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsSlopeParameter.Enabled = false;
			this.menuitemRecordsSlopeParameter.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsSlopeParameter.Image")));
			this.menuitemRecordsSlopeParameter.Name = "menuitemRecordsSlopeParameter";
			this.menuitemRecordsSlopeParameter.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsSlopeParameter.Text = "Slope parameter";
			this.menuitemRecordsSlopeParameter.Click += new System.EventHandler(this.MenuitemRecordsSlopeParameter_Click);
			this.menuitemRecordsSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsNumberOfOppositions
			// 
			this.menuitemRecordsNumberOfOppositions.AccessibleDescription = "Shows the record of the number of oppositions";
			this.menuitemRecordsNumberOfOppositions.AccessibleName = "Record of the number of oppositions";
			this.menuitemRecordsNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsNumberOfOppositions.Enabled = false;
			this.menuitemRecordsNumberOfOppositions.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsNumberOfOppositions.Image")));
			this.menuitemRecordsNumberOfOppositions.Name = "menuitemRecordsNumberOfOppositions";
			this.menuitemRecordsNumberOfOppositions.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemRecordsNumberOfOppositions.Click += new System.EventHandler(this.MenuitemRecordsNumberOfOppositions_Click);
			this.menuitemRecordsNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsNumberOfObservations
			// 
			this.menuitemRecordsNumberOfObservations.AccessibleDescription = "Shows the record of the number of observations";
			this.menuitemRecordsNumberOfObservations.AccessibleName = "Record of the number of observations";
			this.menuitemRecordsNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsNumberOfObservations.Enabled = false;
			this.menuitemRecordsNumberOfObservations.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsNumberOfObservations.Image")));
			this.menuitemRecordsNumberOfObservations.Name = "menuitemRecordsNumberOfObservations";
			this.menuitemRecordsNumberOfObservations.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsNumberOfObservations.Text = "Number of observations";
			this.menuitemRecordsNumberOfObservations.Click += new System.EventHandler(this.MenuitemRecordsNumberOfObservations_Click);
			this.menuitemRecordsNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsObservationSpan
			// 
			this.menuitemRecordsObservationSpan.AccessibleDescription = "Shows the record of the observation span";
			this.menuitemRecordsObservationSpan.AccessibleName = "Record of the observation span";
			this.menuitemRecordsObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsObservationSpan.Enabled = false;
			this.menuitemRecordsObservationSpan.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsObservationSpan.Image")));
			this.menuitemRecordsObservationSpan.Name = "menuitemRecordsObservationSpan";
			this.menuitemRecordsObservationSpan.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsObservationSpan.Text = "Observation span";
			this.menuitemRecordsObservationSpan.Click += new System.EventHandler(this.MenuitemRecordsObservationSpan_Click);
			this.menuitemRecordsObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsRmsResidual
			// 
			this.menuitemRecordsRmsResidual.AccessibleDescription = "Shows the record of the r.m.s. residual";
			this.menuitemRecordsRmsResidual.AccessibleName = "Record of the r.m.s. residual";
			this.menuitemRecordsRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsRmsResidual.Enabled = false;
			this.menuitemRecordsRmsResidual.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsRmsResidual.Image")));
			this.menuitemRecordsRmsResidual.Name = "menuitemRecordsRmsResidual";
			this.menuitemRecordsRmsResidual.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsRmsResidual.Text = "r.m.s. residual";
			this.menuitemRecordsRmsResidual.Click += new System.EventHandler(this.MenuitemRecordsRmsResidual_Click);
			this.menuitemRecordsRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsComputername
			// 
			this.menuitemRecordsComputername.AccessibleDescription = "Shows the record of the computer name";
			this.menuitemRecordsComputername.AccessibleName = "Record of the computer name";
			this.menuitemRecordsComputername.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsComputername.Enabled = false;
			this.menuitemRecordsComputername.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsComputername.Image")));
			this.menuitemRecordsComputername.Name = "menuitemRecordsComputername";
			this.menuitemRecordsComputername.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsComputername.Text = "Computer name";
			this.menuitemRecordsComputername.Click += new System.EventHandler(this.MenuitemRecordsComputername_Click);
			this.menuitemRecordsComputername.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsComputername.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsDateOfTheLastObservation
			// 
			this.menuitemRecordsDateOfTheLastObservation.AccessibleDescription = "Shows the record of the date of the last observation";
			this.menuitemRecordsDateOfTheLastObservation.AccessibleName = "Record of the date of the last observation";
			this.menuitemRecordsDateOfTheLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsDateOfTheLastObservation.Enabled = false;
			this.menuitemRecordsDateOfTheLastObservation.Image = ((System.Drawing.Image)(resources.GetObject("menuitemRecordsDateOfTheLastObservation.Image")));
			this.menuitemRecordsDateOfTheLastObservation.Name = "menuitemRecordsDateOfTheLastObservation";
			this.menuitemRecordsDateOfTheLastObservation.Size = new System.Drawing.Size(249, 22);
			this.menuitemRecordsDateOfTheLastObservation.Text = "Date of the last observation";
			this.menuitemRecordsDateOfTheLastObservation.Click += new System.EventHandler(this.MenuitemRecordsDateOfTheLastObservation_Click);
			this.menuitemRecordsDateOfTheLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsDateOfTheLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecords
			// 
			this.menuitemRecords.AccessibleDescription = "Shows some topn ten records";
			this.menuitemRecords.AccessibleName = "Top ten records";
			this.menuitemRecords.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecords.AutoToolTip = true;
			this.menuitemRecords.DropDown = this.contextMenuTopTenRecords;
			this.menuitemRecords.Enabled = false;
			this.menuitemRecords.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_numbers;
			this.menuitemRecords.Name = "menuitemRecords";
			this.menuitemRecords.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.menuitemRecords.Size = new System.Drawing.Size(251, 22);
			this.menuitemRecords.Text = "Top ten &records";
			this.menuitemRecords.Click += new System.EventHandler(this.MenuitemTopTenRecords_Click);
			this.menuitemRecords.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecords.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuDistributions
			// 
			this.contextMenuDistributions.AccessibleDescription = "Shows the context menu of the distributions";
			this.contextMenuDistributions.AccessibleName = "context menu of the distributions";
			this.contextMenuDistributions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuDistributions.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuDistributions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDistributionMeanAnomalyAtTheEpoch,
            this.menuitemDistributionArgumentOfPerihelion,
            this.menuitemDistributionLongitudeOfTheAscendingNode,
            this.menuitemDistributionInclination,
            this.menuitemDistributionOrbitalEccentricity,
            this.menuitemDistributionMeanDailyMotion,
            this.menuitemDistributionSemiMajorAxis,
            this.menuitemDistributionAbsoluteMagnitude,
            this.menuitemDistributionSlopeParameter,
            this.menuitemDistributionNumberOfOppositions,
            this.menuitemDistributionNumberOfObservations,
            this.menuitemDistributionObservationSpan,
            this.menuitemDistributionRmsResidual,
            this.menuitemDistributionComputerName});
			this.contextMenuDistributions.Name = "contextMenuDistributions";
			this.contextMenuDistributions.OwnerItem = this.splitbuttonDistribution;
			this.contextMenuDistributions.Size = new System.Drawing.Size(250, 312);
			this.contextMenuDistributions.Text = "Distributions";
			this.toolTip.SetToolTip(this.contextMenuDistributions, "Distributions");
			// 
			// menuitemDistributionMeanAnomalyAtTheEpoch
			// 
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the distribution of mean anomaly at the epoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleName = "Distribution of mean anomaly at the epoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AutoToolTip = true;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Enabled = false;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionMeanAnomalyAtTheEpoch.Image")));
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Name = "menuitemDistributionMeanAnomalyAtTheEpoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Click += new System.EventHandler(this.MenuitemDistributionMeanAnomalyAtTheEpoch_Click);
			this.menuitemDistributionMeanAnomalyAtTheEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionMeanAnomalyAtTheEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionArgumentOfPerihelion
			// 
			this.menuitemDistributionArgumentOfPerihelion.AccessibleDescription = "Shows the distribution of the argument of perihelion";
			this.menuitemDistributionArgumentOfPerihelion.AccessibleName = "Distribution of the argument of perihelion";
			this.menuitemDistributionArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionArgumentOfPerihelion.AutoToolTip = true;
			this.menuitemDistributionArgumentOfPerihelion.Enabled = false;
			this.menuitemDistributionArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionArgumentOfPerihelion.Image")));
			this.menuitemDistributionArgumentOfPerihelion.Name = "menuitemDistributionArgumentOfPerihelion";
			this.menuitemDistributionArgumentOfPerihelion.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionArgumentOfPerihelion.Text = "Argument of perihelion";
			this.menuitemDistributionArgumentOfPerihelion.Click += new System.EventHandler(this.MenuitemDistributionArgumentOfPerihelion_Click);
			this.menuitemDistributionArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionLongitudeOfTheAscendingNode
			// 
			this.menuitemDistributionLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the distribution of the longitude of the ascending node";
			this.menuitemDistributionLongitudeOfTheAscendingNode.AccessibleName = "Distribution of the longitude of the ascending node";
			this.menuitemDistributionLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.menuitemDistributionLongitudeOfTheAscendingNode.Enabled = false;
			this.menuitemDistributionLongitudeOfTheAscendingNode.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionLongitudeOfTheAscendingNode.Image")));
			this.menuitemDistributionLongitudeOfTheAscendingNode.Name = "menuitemDistributionLongitudeOfTheAscendingNode";
			this.menuitemDistributionLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node";
			this.menuitemDistributionLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.MenuitemDistributionLongitudeOfTheAscendingNode_Click);
			this.menuitemDistributionLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionInclination
			// 
			this.menuitemDistributionInclination.AccessibleDescription = "Shows the distribution of the inclination to the ecliptic";
			this.menuitemDistributionInclination.AccessibleName = "Distribution of the inclination to the ecliptic";
			this.menuitemDistributionInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionInclination.AutoToolTip = true;
			this.menuitemDistributionInclination.Enabled = false;
			this.menuitemDistributionInclination.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionInclination.Image")));
			this.menuitemDistributionInclination.Name = "menuitemDistributionInclination";
			this.menuitemDistributionInclination.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionInclination.Text = "Inclination to the ecliptic";
			this.menuitemDistributionInclination.Click += new System.EventHandler(this.MenuitemDistributionInclination_Click);
			this.menuitemDistributionInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionOrbitalEccentricity
			// 
			this.menuitemDistributionOrbitalEccentricity.AccessibleDescription = "Shows the distribution of the orbital eccentricity";
			this.menuitemDistributionOrbitalEccentricity.AccessibleName = "Distribution of the orbital eccentricity";
			this.menuitemDistributionOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionOrbitalEccentricity.AutoToolTip = true;
			this.menuitemDistributionOrbitalEccentricity.Enabled = false;
			this.menuitemDistributionOrbitalEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionOrbitalEccentricity.Image")));
			this.menuitemDistributionOrbitalEccentricity.Name = "menuitemDistributionOrbitalEccentricity";
			this.menuitemDistributionOrbitalEccentricity.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemDistributionOrbitalEccentricity.Click += new System.EventHandler(this.MenuitemDistributionOrbitalEccentricity_Click);
			this.menuitemDistributionOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionMeanDailyMotion
			// 
			this.menuitemDistributionMeanDailyMotion.AccessibleDescription = "Shows the distribution of the mean daily motion";
			this.menuitemDistributionMeanDailyMotion.AccessibleName = "Distribution of the mean daily motion";
			this.menuitemDistributionMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionMeanDailyMotion.AutoToolTip = true;
			this.menuitemDistributionMeanDailyMotion.Enabled = false;
			this.menuitemDistributionMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionMeanDailyMotion.Image")));
			this.menuitemDistributionMeanDailyMotion.Name = "menuitemDistributionMeanDailyMotion";
			this.menuitemDistributionMeanDailyMotion.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionMeanDailyMotion.Text = "Mean daily motion";
			this.menuitemDistributionMeanDailyMotion.Click += new System.EventHandler(this.MenuitemDistributionMeanDailyMotion_Click);
			this.menuitemDistributionMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionSemiMajorAxis
			// 
			this.menuitemDistributionSemiMajorAxis.AccessibleDescription = "Shows the distribution of the semi-major axis";
			this.menuitemDistributionSemiMajorAxis.AccessibleName = "Distribution of the semi-major axis";
			this.menuitemDistributionSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionSemiMajorAxis.AutoToolTip = true;
			this.menuitemDistributionSemiMajorAxis.Enabled = false;
			this.menuitemDistributionSemiMajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionSemiMajorAxis.Image")));
			this.menuitemDistributionSemiMajorAxis.Name = "menuitemDistributionSemiMajorAxis";
			this.menuitemDistributionSemiMajorAxis.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionSemiMajorAxis.Text = "Semi-major axis";
			this.menuitemDistributionSemiMajorAxis.Click += new System.EventHandler(this.MenuitemDistributionSemiMajorAxis_Click);
			this.menuitemDistributionSemiMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionSemiMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionAbsoluteMagnitude
			// 
			this.menuitemDistributionAbsoluteMagnitude.AccessibleDescription = "Shows the distribution of the absolute magnitude";
			this.menuitemDistributionAbsoluteMagnitude.AccessibleName = "Distribution of the absolute magnitude";
			this.menuitemDistributionAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionAbsoluteMagnitude.AutoToolTip = true;
			this.menuitemDistributionAbsoluteMagnitude.Enabled = false;
			this.menuitemDistributionAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionAbsoluteMagnitude.Image")));
			this.menuitemDistributionAbsoluteMagnitude.Name = "menuitemDistributionAbsoluteMagnitude";
			this.menuitemDistributionAbsoluteMagnitude.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionAbsoluteMagnitude.Text = "Absolute magnitude";
			this.menuitemDistributionAbsoluteMagnitude.Click += new System.EventHandler(this.MenuitemDistributionAbsoluteMagnitude_Click);
			this.menuitemDistributionAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionSlopeParameter
			// 
			this.menuitemDistributionSlopeParameter.AccessibleDescription = "Shows the distribution of the slope parameter";
			this.menuitemDistributionSlopeParameter.AccessibleName = "Distribution of the slope parameter";
			this.menuitemDistributionSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionSlopeParameter.AutoToolTip = true;
			this.menuitemDistributionSlopeParameter.Enabled = false;
			this.menuitemDistributionSlopeParameter.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionSlopeParameter.Image")));
			this.menuitemDistributionSlopeParameter.Name = "menuitemDistributionSlopeParameter";
			this.menuitemDistributionSlopeParameter.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionSlopeParameter.Text = "Slope parameter";
			this.menuitemDistributionSlopeParameter.Click += new System.EventHandler(this.MenuitemDistributionSlopeParameter_Click);
			this.menuitemDistributionSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionNumberOfOppositions
			// 
			this.menuitemDistributionNumberOfOppositions.AccessibleDescription = "Shows the distribution of the number of oppositions";
			this.menuitemDistributionNumberOfOppositions.AccessibleName = "Distribution of the number of oppositions";
			this.menuitemDistributionNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionNumberOfOppositions.AutoToolTip = true;
			this.menuitemDistributionNumberOfOppositions.Enabled = false;
			this.menuitemDistributionNumberOfOppositions.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionNumberOfOppositions.Image")));
			this.menuitemDistributionNumberOfOppositions.Name = "menuitemDistributionNumberOfOppositions";
			this.menuitemDistributionNumberOfOppositions.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemDistributionNumberOfOppositions.Click += new System.EventHandler(this.MenuitemDistributionNumberOfOppositions_Click);
			this.menuitemDistributionNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionNumberOfObservations
			// 
			this.menuitemDistributionNumberOfObservations.AccessibleDescription = "Show the distribution of the number of observations";
			this.menuitemDistributionNumberOfObservations.AccessibleName = "Distribution of the number of observations";
			this.menuitemDistributionNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionNumberOfObservations.AutoToolTip = true;
			this.menuitemDistributionNumberOfObservations.Enabled = false;
			this.menuitemDistributionNumberOfObservations.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionNumberOfObservations.Image")));
			this.menuitemDistributionNumberOfObservations.Name = "menuitemDistributionNumberOfObservations";
			this.menuitemDistributionNumberOfObservations.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionNumberOfObservations.Text = "Number of observations";
			this.menuitemDistributionNumberOfObservations.Click += new System.EventHandler(this.MenuitemDistributionNumberOfObservations_Click);
			this.menuitemDistributionNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionObservationSpan
			// 
			this.menuitemDistributionObservationSpan.AccessibleDescription = "Shows the distribution of the observation span";
			this.menuitemDistributionObservationSpan.AccessibleName = "Distribution of the observation span";
			this.menuitemDistributionObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionObservationSpan.AutoToolTip = true;
			this.menuitemDistributionObservationSpan.Enabled = false;
			this.menuitemDistributionObservationSpan.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionObservationSpan.Image")));
			this.menuitemDistributionObservationSpan.Name = "menuitemDistributionObservationSpan";
			this.menuitemDistributionObservationSpan.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionObservationSpan.Text = "Observation span";
			this.menuitemDistributionObservationSpan.Click += new System.EventHandler(this.MenuitemDistributionObservationSpan_Click);
			this.menuitemDistributionObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionRmsResidual
			// 
			this.menuitemDistributionRmsResidual.AccessibleDescription = "Shows the distribution of the r.m.s. residual";
			this.menuitemDistributionRmsResidual.AccessibleName = "Distribution of the r.m.s. residual";
			this.menuitemDistributionRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionRmsResidual.AutoToolTip = true;
			this.menuitemDistributionRmsResidual.Enabled = false;
			this.menuitemDistributionRmsResidual.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionRmsResidual.Image")));
			this.menuitemDistributionRmsResidual.Name = "menuitemDistributionRmsResidual";
			this.menuitemDistributionRmsResidual.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionRmsResidual.Text = "r.m.s. residual";
			this.menuitemDistributionRmsResidual.Click += new System.EventHandler(this.MenuitemDistributionRmsResidual_Click);
			this.menuitemDistributionRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionComputerName
			// 
			this.menuitemDistributionComputerName.AccessibleDescription = "Shows the distribution of the computer name";
			this.menuitemDistributionComputerName.AccessibleName = "Distribution of the computer name";
			this.menuitemDistributionComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionComputerName.AutoToolTip = true;
			this.menuitemDistributionComputerName.Enabled = false;
			this.menuitemDistributionComputerName.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionComputerName.Image")));
			this.menuitemDistributionComputerName.Name = "menuitemDistributionComputerName";
			this.menuitemDistributionComputerName.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionComputerName.Text = "Computer name";
			this.menuitemDistributionComputerName.Click += new System.EventHandler(this.MenuitemDistributionComputerName_Click);
			this.menuitemDistributionComputerName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionComputerName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistribution
			// 
			this.menuitemDistribution.AccessibleDescription = "Shows some distributions";
			this.menuitemDistribution.AccessibleName = "Distributions";
			this.menuitemDistribution.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistribution.AutoToolTip = true;
			this.menuitemDistribution.DoubleClickEnabled = true;
			this.menuitemDistribution.DropDown = this.contextMenuDistributions;
			this.menuitemDistribution.Enabled = false;
			this.menuitemDistribution.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.menuitemDistribution.Name = "menuitemDistribution";
			this.menuitemDistribution.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.menuitemDistribution.Size = new System.Drawing.Size(251, 22);
			this.menuitemDistribution.Text = "&Distributions";
			this.menuitemDistribution.Click += new System.EventHandler(this.MenuitemDistribution_Click);
			this.menuitemDistribution.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistribution.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuCopyToClipboardOrbitalElements
			// 
			this.contextMenuCopyToClipboardOrbitalElements.AccessibleDescription = "Shows the context menu of the orbital elements to copy to clipboard";
			this.contextMenuCopyToClipboardOrbitalElements.AccessibleName = "context menu of the orbital elements to copy to clipboard";
			this.contextMenuCopyToClipboardOrbitalElements.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuCopyToClipboardOrbitalElements.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuCopyToClipboardOrbitalElements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemCopyToClipboardIndexNumber,
            this.menuitemCopyToClipboardReadableDesignation,
            this.menuitemCopyToClipboardEpoch,
            this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch,
            this.menuitemCopyToClipboardArgumentOfPerihelion,
            this.menuitemCopyToClipboardLongitudeOfTheAscendingNode,
            this.menuitemCopyToClipboardInclinationToTheEcliptic,
            this.menuitemCopyToClipboardOrbitalEccentricity,
            this.menuitemCopyToClipboardMeanDailyMotion,
            this.menuitemCopyToClipboardSemiMajorAxis,
            this.menuitemCopyToClipboardAbsoluteMagnitude,
            this.menuitemCopyToClipboardSlopeParameter,
            this.menuitemCopyToClipboardReference,
            this.menuitemCopyToClipboardNumberOfOppositions,
            this.menuitemCopyToClipboardNumberOfObservations,
            this.menuitemCopyToClipboardObservationSpan,
            this.menuitemCopyToClipboardRmsResidual,
            this.menuitemCopyToClipboardComputerName,
            this.menuitemCopyToClipboardDateOfTheLastObservation,
            this.menuitemCopyToClipboardFlags});
			this.contextMenuCopyToClipboardOrbitalElements.Name = "contextMenuCopyToClipboardOrbitalElements";
			this.contextMenuCopyToClipboardOrbitalElements.OwnerItem = this.menuitemCopytoClipboard;
			this.contextMenuCopyToClipboardOrbitalElements.Size = new System.Drawing.Size(309, 444);
			this.contextMenuCopyToClipboardOrbitalElements.Text = "Copy to clipboard";
			this.toolTip.SetToolTip(this.contextMenuCopyToClipboardOrbitalElements, "Copy to clipboard");
			// 
			// menuitemCopyToClipboardIndexNumber
			// 
			this.menuitemCopyToClipboardIndexNumber.AccessibleDescription = "Copy to clipboard: Index number";
			this.menuitemCopyToClipboardIndexNumber.AccessibleName = "Copy to clipboard: Index number";
			this.menuitemCopyToClipboardIndexNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardIndexNumber.AutoToolTip = true;
			this.menuitemCopyToClipboardIndexNumber.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardIndexNumber.Image")));
			this.menuitemCopyToClipboardIndexNumber.Name = "menuitemCopyToClipboardIndexNumber";
			this.menuitemCopyToClipboardIndexNumber.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardIndexNumber.Text = "Index No.";
			this.menuitemCopyToClipboardIndexNumber.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardIndexNumber_Click);
			this.menuitemCopyToClipboardIndexNumber.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardIndexNumber.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardReadableDesignation
			// 
			this.menuitemCopyToClipboardReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			this.menuitemCopyToClipboardReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			this.menuitemCopyToClipboardReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardReadableDesignation.AutoToolTip = true;
			this.menuitemCopyToClipboardReadableDesignation.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardReadableDesignation.Image")));
			this.menuitemCopyToClipboardReadableDesignation.Name = "menuitemCopyToClipboardReadableDesignation";
			this.menuitemCopyToClipboardReadableDesignation.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardReadableDesignation.Text = "Readable designation";
			this.menuitemCopyToClipboardReadableDesignation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReadableDesignation_Click);
			this.menuitemCopyToClipboardReadableDesignation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardReadableDesignation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardEpoch
			// 
			this.menuitemCopyToClipboardEpoch.AccessibleDescription = "Copy to clipboard: Epoch";
			this.menuitemCopyToClipboardEpoch.AccessibleName = "Copy to clipboard: Epoch";
			this.menuitemCopyToClipboardEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardEpoch.AutoToolTip = true;
			this.menuitemCopyToClipboardEpoch.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardEpoch.Image")));
			this.menuitemCopyToClipboardEpoch.Name = "menuitemCopyToClipboardEpoch";
			this.menuitemCopyToClipboardEpoch.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.menuitemCopyToClipboardEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardEpoch_Click);
			this.menuitemCopyToClipboardEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardMeanAnomalyAtTheEpoch
			// 
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AutoToolTip = true;
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Image")));
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Name = "menuitemCopyToClipboardMeanAnomalyAtTheEpoch";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch (°)";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanAnomaly_Click);
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardArgumentOfPerihelion
			// 
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardArgumentOfPerihelion.AutoToolTip = true;
			this.menuitemCopyToClipboardArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardArgumentOfPerihelion.Image")));
			this.menuitemCopyToClipboardArgumentOfPerihelion.Name = "menuitemCopyToClipboardArgumentOfPerihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (°)";
			this.menuitemCopyToClipboardArgumentOfPerihelion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click);
			this.menuitemCopyToClipboardArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardLongitudeOfTheAscendingNode
			// 
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardLongitudeOfTheAscendingNode.Image")));
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Name = "menuitemCopyToClipboardLongitudeOfTheAscendingNode";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0 (°)";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click);
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardInclinationToTheEcliptic
			// 
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleDescription = "Copy to clipboard: Inclination";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleName = "Copy to clipboard: Inclination";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AutoToolTip = true;
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardInclinationToTheEcliptic.Image")));
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Name = "menuitemCopyToClipboardInclinationToTheEcliptic";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Text = "Inclination to the ecliptic, J2000.0 (°)";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardInclinationToTheEcliptic_Click);
			this.menuitemCopyToClipboardInclinationToTheEcliptic.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardInclinationToTheEcliptic.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardOrbitalEccentricity
			// 
			this.menuitemCopyToClipboardOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardOrbitalEccentricity.AutoToolTip = true;
			this.menuitemCopyToClipboardOrbitalEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardOrbitalEccentricity.Image")));
			this.menuitemCopyToClipboardOrbitalEccentricity.Name = "menuitemCopyToClipboardOrbitalEccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click);
			this.menuitemCopyToClipboardOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardMeanDailyMotion
			// 
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardMeanDailyMotion.AutoToolTip = true;
			this.menuitemCopyToClipboardMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardMeanDailyMotion.Image")));
			this.menuitemCopyToClipboardMeanDailyMotion.Name = "menuitemCopyToClipboardMeanDailyMotion";
			this.menuitemCopyToClipboardMeanDailyMotion.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardMeanDailyMotion.Text = "Mean daily motion (°/day)";
			this.menuitemCopyToClipboardMeanDailyMotion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click);
			this.menuitemCopyToClipboardMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardSemiMajorAxis
			// 
			this.menuitemCopyToClipboardSemiMajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis";
			this.menuitemCopyToClipboardSemiMajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis";
			this.menuitemCopyToClipboardSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardSemiMajorAxis.AutoToolTip = true;
			this.menuitemCopyToClipboardSemiMajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardSemiMajorAxis.Image")));
			this.menuitemCopyToClipboardSemiMajorAxis.Name = "menuitemCopyToClipboardSemiMajorAxis";
			this.menuitemCopyToClipboardSemiMajorAxis.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardSemiMajorAxis.Text = "Semi-major axis (AU)";
			this.menuitemCopyToClipboardSemiMajorAxis.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardSemiMajorAxis_Click);
			this.menuitemCopyToClipboardSemiMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardSemiMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardAbsoluteMagnitude
			// 
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardAbsoluteMagnitude.AutoToolTip = true;
			this.menuitemCopyToClipboardAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardAbsoluteMagnitude.Image")));
			this.menuitemCopyToClipboardAbsoluteMagnitude.Name = "menuitemCopyToClipboardAbsoluteMagnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardAbsoluteMagnitude.Text = "Absolute magnitude, H";
			this.menuitemCopyToClipboardAbsoluteMagnitude.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click);
			this.menuitemCopyToClipboardAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardSlopeParameter
			// 
			this.menuitemCopyToClipboardSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter";
			this.menuitemCopyToClipboardSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter";
			this.menuitemCopyToClipboardSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardSlopeParameter.AutoToolTip = true;
			this.menuitemCopyToClipboardSlopeParameter.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardSlopeParameter.Image")));
			this.menuitemCopyToClipboardSlopeParameter.Name = "menuitemCopyToClipboardSlopeParameter";
			this.menuitemCopyToClipboardSlopeParameter.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardSlopeParameter.Text = "Slope parameter, G";
			this.menuitemCopyToClipboardSlopeParameter.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardSlopeParameter_Click);
			this.menuitemCopyToClipboardSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardReference
			// 
			this.menuitemCopyToClipboardReference.AccessibleDescription = "Copy to clipboard: Reference";
			this.menuitemCopyToClipboardReference.AccessibleName = "Copy to clipboard: Reference";
			this.menuitemCopyToClipboardReference.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardReference.AutoToolTip = true;
			this.menuitemCopyToClipboardReference.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardReference.Image")));
			this.menuitemCopyToClipboardReference.Name = "menuitemCopyToClipboardReference";
			this.menuitemCopyToClipboardReference.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardReference.Text = "Reference";
			this.menuitemCopyToClipboardReference.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReference_Click);
			this.menuitemCopyToClipboardReference.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardReference.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardNumberOfOppositions
			// 
			this.menuitemCopyToClipboardNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			this.menuitemCopyToClipboardNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions ";
			this.menuitemCopyToClipboardNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardNumberOfOppositions.AutoToolTip = true;
			this.menuitemCopyToClipboardNumberOfOppositions.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardNumberOfOppositions.Image")));
			this.menuitemCopyToClipboardNumberOfOppositions.Name = "menuitemCopyToClipboardNumberOfOppositions";
			this.menuitemCopyToClipboardNumberOfOppositions.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemCopyToClipboardNumberOfOppositions.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click);
			this.menuitemCopyToClipboardNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardNumberOfObservations
			// 
			this.menuitemCopyToClipboardNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			this.menuitemCopyToClipboardNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			this.menuitemCopyToClipboardNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardNumberOfObservations.AutoToolTip = true;
			this.menuitemCopyToClipboardNumberOfObservations.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardNumberOfObservations.Image")));
			this.menuitemCopyToClipboardNumberOfObservations.Name = "menuitemCopyToClipboardNumberOfObservations";
			this.menuitemCopyToClipboardNumberOfObservations.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardNumberOfObservations.Text = "Number of observations";
			this.menuitemCopyToClipboardNumberOfObservations.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfObservations_Click);
			this.menuitemCopyToClipboardNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardObservationSpan
			// 
			this.menuitemCopyToClipboardObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.menuitemCopyToClipboardObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.menuitemCopyToClipboardObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardObservationSpan.AutoToolTip = true;
			this.menuitemCopyToClipboardObservationSpan.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardObservationSpan.Image")));
			this.menuitemCopyToClipboardObservationSpan.Name = "menuitemCopyToClipboardObservationSpan";
			this.menuitemCopyToClipboardObservationSpan.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardObservationSpan.Text = "Observation span";
			this.menuitemCopyToClipboardObservationSpan.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardObservationSpan_Click);
			this.menuitemCopyToClipboardObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardRmsResidual
			// 
			this.menuitemCopyToClipboardRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual";
			this.menuitemCopyToClipboardRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual";
			this.menuitemCopyToClipboardRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardRmsResidual.AutoToolTip = true;
			this.menuitemCopyToClipboardRmsResidual.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardRmsResidual.Image")));
			this.menuitemCopyToClipboardRmsResidual.Name = "menuitemCopyToClipboardRmsResidual";
			this.menuitemCopyToClipboardRmsResidual.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardRmsResidual.Text = "r.m.s. residual (\")";
			this.menuitemCopyToClipboardRmsResidual.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardRmsResidual_Click);
			this.menuitemCopyToClipboardRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardComputerName
			// 
			this.menuitemCopyToClipboardComputerName.AccessibleDescription = "Copy to clipboard: Computer name";
			this.menuitemCopyToClipboardComputerName.AccessibleName = "Copy to clipboard: Computer name";
			this.menuitemCopyToClipboardComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardComputerName.AutoToolTip = true;
			this.menuitemCopyToClipboardComputerName.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardComputerName.Image")));
			this.menuitemCopyToClipboardComputerName.Name = "menuitemCopyToClipboardComputerName";
			this.menuitemCopyToClipboardComputerName.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardComputerName.Text = "Computer name";
			this.menuitemCopyToClipboardComputerName.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardComputerName_Click);
			this.menuitemCopyToClipboardComputerName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardComputerName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardDateOfTheLastObservation
			// 
			this.menuitemCopyToClipboardDateOfTheLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.AccessibleName = "Copy to clipboard: Date of last observation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardDateOfTheLastObservation.AutoToolTip = true;
			this.menuitemCopyToClipboardDateOfTheLastObservation.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardDateOfTheLastObservation.Image")));
			this.menuitemCopyToClipboardDateOfTheLastObservation.Name = "menuitemCopyToClipboardDateOfTheLastObservation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardDateOfTheLastObservation.Text = "Date of last observation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click);
			this.menuitemCopyToClipboardDateOfTheLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardDateOfTheLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardFlags
			// 
			this.menuitemCopyToClipboardFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardFlags.AutoToolTip = true;
			this.menuitemCopyToClipboardFlags.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardFlags.Image")));
			this.menuitemCopyToClipboardFlags.Name = "menuitemCopyToClipboardFlags";
			this.menuitemCopyToClipboardFlags.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyToClipboardFlags.Text = "4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.Click += new System.EventHandler(this.MenuitemRecordsDateOfTheLastObservation_Click);
			this.menuitemCopyToClipboardFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// splitbuttonCopyToClipboard
			// 
			this.splitbuttonCopyToClipboard.AccessibleDescription = "Copys to clipboard";
			this.splitbuttonCopyToClipboard.AccessibleName = "Copy to clipboard";
			this.splitbuttonCopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonCopyToClipboard.DropDown = this.contextMenuCopyToClipboardOrbitalElements;
			this.splitbuttonCopyToClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.splitbuttonCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.splitbuttonCopyToClipboard.Name = "splitbuttonCopyToClipboard";
			this.splitbuttonCopyToClipboard.Size = new System.Drawing.Size(32, 22);
			this.splitbuttonCopyToClipboard.Text = "Copy to clipboard";
			this.splitbuttonCopyToClipboard.ButtonClick += new System.EventHandler(this.ToolStripButtonCopyToClipboard_Click);
			this.splitbuttonCopyToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.splitbuttonCopyToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menu
			// 
			this.menu.AccessibleDescription = "Shows the menubar";
			this.menu.AccessibleName = "menu";
			this.menu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.menu.AllowItemReorder = true;
			this.menu.Dock = System.Windows.Forms.DockStyle.None;
			this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.menu.GripMargin = new System.Windows.Forms.Padding(0);
			this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemFile,
            this.menuitemEdit,
            this.menuitemNavigation,
            this.menuitemTools,
            this.menuitemUpdate,
            this.menuitemOptions,
            this.menuitemHelp});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.menu.ShowItemToolTips = true;
			this.menu.Size = new System.Drawing.Size(804, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menu";
			this.toolTip.SetToolTip(this.menu, "Menu");
			this.menu.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menu.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.menu.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menu.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemFile
			// 
			this.menuitemFile.AccessibleDescription = "Opens the menu \"file\"";
			this.menuitemFile.AccessibleName = "File";
			this.menuitemFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemFile.AutoToolTip = true;
			this.menuitemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemOpenALocalMpcorbdatFile,
            this.toolStripSeparator13,
            this.menuitemExportDataEntry,
            this.menuitemPrint,
            this.toolStripSeparatorFile1,
            this.menuitemRestart,
            this.menuitemExit});
			this.menuitemFile.Name = "menuitemFile";
			this.menuitemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.menuitemFile.Size = new System.Drawing.Size(37, 24);
			this.menuitemFile.Text = "&File";
			this.menuitemFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOpenALocalMpcorbdatFile
			// 
			this.menuitemOpenALocalMpcorbdatFile.AccessibleDescription = "Opens a local MPCORB.DAT file";
			this.menuitemOpenALocalMpcorbdatFile.AccessibleName = "Open";
			this.menuitemOpenALocalMpcorbdatFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOpenALocalMpcorbdatFile.AutoToolTip = true;
			this.menuitemOpenALocalMpcorbdatFile.Enabled = false;
			this.menuitemOpenALocalMpcorbdatFile.Image = global::Planetoid_DB.Properties.Resources.silk_folder;
			this.menuitemOpenALocalMpcorbdatFile.Name = "menuitemOpenALocalMpcorbdatFile";
			this.menuitemOpenALocalMpcorbdatFile.Size = new System.Drawing.Size(235, 22);
			this.menuitemOpenALocalMpcorbdatFile.Text = "&Open a local MPCORB.DAT file";
			this.menuitemOpenALocalMpcorbdatFile.Click += new System.EventHandler(this.MenuitemOpenALocalMpcorbdatFile_Click);
			this.menuitemOpenALocalMpcorbdatFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOpenALocalMpcorbdatFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator13
			// 
			this.toolStripSeparator13.AccessibleDescription = "Just a separator";
			this.toolStripSeparator13.AccessibleName = "Just a separator";
			this.toolStripSeparator13.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new System.Drawing.Size(232, 6);
			this.toolStripSeparator13.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator13.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportDataEntry
			// 
			this.menuitemExportDataEntry.AccessibleDescription = "Exports data entry";
			this.menuitemExportDataEntry.AccessibleName = "Export";
			this.menuitemExportDataEntry.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportDataEntry.AutoToolTip = true;
			this.menuitemExportDataEntry.Image = global::Planetoid_DB.Properties.Resources.silk_page_save;
			this.menuitemExportDataEntry.Name = "menuitemExportDataEntry";
			this.menuitemExportDataEntry.Size = new System.Drawing.Size(235, 22);
			this.menuitemExportDataEntry.Text = "&Export data entry";
			this.menuitemExportDataEntry.Click += new System.EventHandler(this.ToolStripSplitButtonExport_Click);
			this.menuitemExportDataEntry.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportDataEntry.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemPrint
			// 
			this.menuitemPrint.AccessibleDescription = "Prints the information";
			this.menuitemPrint.AccessibleName = "Print";
			this.menuitemPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemPrint.AutoToolTip = true;
			this.menuitemPrint.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
			this.menuitemPrint.Name = "menuitemPrint";
			this.menuitemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.menuitemPrint.Size = new System.Drawing.Size(235, 22);
			this.menuitemPrint.Text = "&Print data sheet";
			this.menuitemPrint.Click += new System.EventHandler(this.ToolStripMenuItemPrint_Click);
			this.menuitemPrint.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemPrint.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorFile1
			// 
			this.toolStripSeparatorFile1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorFile1.AccessibleName = "Just a separator";
			this.toolStripSeparatorFile1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			this.toolStripSeparatorFile1.Size = new System.Drawing.Size(232, 6);
			this.toolStripSeparatorFile1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorFile1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRestart
			// 
			this.menuitemRestart.AccessibleDescription = "Restarts the application";
			this.menuitemRestart.AccessibleName = "Restart";
			this.menuitemRestart.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRestart.AutoToolTip = true;
			this.menuitemRestart.Image = global::Planetoid_DB.Properties.Resources.silk_reload;
			this.menuitemRestart.Name = "menuitemRestart";
			this.menuitemRestart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.menuitemRestart.Size = new System.Drawing.Size(235, 22);
			this.menuitemRestart.Text = "&Restart";
			this.menuitemRestart.Click += new System.EventHandler(this.ToolStripMenuItemRestart_Click);
			this.menuitemRestart.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRestart.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExit
			// 
			this.menuitemExit.AccessibleDescription = "Exits the application";
			this.menuitemExit.AccessibleName = "Exit";
			this.menuitemExit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExit.AutoToolTip = true;
			this.menuitemExit.DoubleClickEnabled = true;
			this.menuitemExit.Image = global::Planetoid_DB.Properties.Resources.silk_door_in;
			this.menuitemExit.Name = "menuitemExit";
			this.menuitemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.menuitemExit.Size = new System.Drawing.Size(235, 22);
			this.menuitemExit.Text = "E&xit";
			this.menuitemExit.Click += new System.EventHandler(this.MenuitemExit_Click);
			this.menuitemExit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemEdit
			// 
			this.menuitemEdit.AccessibleDescription = "Opens the menu \"edit\"";
			this.menuitemEdit.AccessibleName = "Edit";
			this.menuitemEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemEdit.AutoToolTip = true;
			this.menuitemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemCopytoClipboard,
            this.menuitemSearch});
			this.menuitemEdit.Name = "menuitemEdit";
			this.menuitemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
			this.menuitemEdit.Size = new System.Drawing.Size(39, 24);
			this.menuitemEdit.Text = "&Edit";
			this.menuitemEdit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemEdit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopytoClipboard
			// 
			this.menuitemCopytoClipboard.AccessibleDescription = "Copy to clipboard";
			this.menuitemCopytoClipboard.AccessibleName = "Copy to clipboard";
			this.menuitemCopytoClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopytoClipboard.AutoToolTip = true;
			this.menuitemCopytoClipboard.DoubleClickEnabled = true;
			this.menuitemCopytoClipboard.DropDown = this.contextMenuCopyToClipboardOrbitalElements;
			this.menuitemCopytoClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.menuitemCopytoClipboard.Name = "menuitemCopytoClipboard";
			this.menuitemCopytoClipboard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.menuitemCopytoClipboard.Size = new System.Drawing.Size(145, 22);
			this.menuitemCopytoClipboard.Text = "&Copy";
			this.menuitemCopytoClipboard.Click += new System.EventHandler(this.ToolStripButtonCopyToClipboard_Click);
			this.menuitemCopytoClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopytoClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearch
			// 
			this.menuitemSearch.AccessibleDescription = "Search";
			this.menuitemSearch.AccessibleName = "Search";
			this.menuitemSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearch.AutoToolTip = true;
			this.menuitemSearch.DoubleClickEnabled = true;
			this.menuitemSearch.Image = global::Planetoid_DB.Properties.Resources.silk_magnifier;
			this.menuitemSearch.Name = "menuitemSearch";
			this.menuitemSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.menuitemSearch.Size = new System.Drawing.Size(145, 22);
			this.menuitemSearch.Text = "&Search";
			this.menuitemSearch.Click += new System.EventHandler(this.ToolStripMenuItemSearch_Click);
			this.menuitemSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigation
			// 
			this.menuitemNavigation.AccessibleDescription = "Opens the menu \"navigation\"";
			this.menuitemNavigation.AccessibleName = "Navigation";
			this.menuitemNavigation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemNavigation.AutoToolTip = true;
			this.menuitemNavigation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemRandomMinorPlanet,
            this.toolStripSeparatorNavigation1,
            this.menuitemNavigateToTheBeginning,
            this.menuitemNavigateSomeDataBackward,
            this.menuitemNavigateToThePreviousData,
            this.menuitemNavigateToTheNextData,
            this.menuitemNavigateSomeDataForward,
            this.menuitemNavigateToTheEnd});
			this.menuitemNavigation.Name = "menuitemNavigation";
			this.menuitemNavigation.Size = new System.Drawing.Size(77, 24);
			this.menuitemNavigation.Text = "&Navigation";
			this.menuitemNavigation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRandomMinorPlanet
			// 
			this.menuitemRandomMinorPlanet.AccessibleDescription = "Loads a random minor planet";
			this.menuitemRandomMinorPlanet.AccessibleName = "Random minor planet";
			this.menuitemRandomMinorPlanet.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRandomMinorPlanet.AutoToolTip = true;
			this.menuitemRandomMinorPlanet.DoubleClickEnabled = true;
			this.menuitemRandomMinorPlanet.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_refresh;
			this.menuitemRandomMinorPlanet.Name = "menuitemRandomMinorPlanet";
			this.menuitemRandomMinorPlanet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.menuitemRandomMinorPlanet.Size = new System.Drawing.Size(274, 22);
			this.menuitemRandomMinorPlanet.Text = "&Random minor planet";
			this.menuitemRandomMinorPlanet.Click += new System.EventHandler(this.ToolStripMenuItemRandomMinorPlanet_Click);
			this.menuitemRandomMinorPlanet.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRandomMinorPlanet.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorNavigation1
			// 
			this.toolStripSeparatorNavigation1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorNavigation1.AccessibleName = "Just a separator";
			this.toolStripSeparatorNavigation1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorNavigation1.Name = "toolStripSeparatorNavigation1";
			this.toolStripSeparatorNavigation1.Size = new System.Drawing.Size(271, 6);
			this.toolStripSeparatorNavigation1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorNavigation1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateToTheBeginning
			// 
			this.menuitemNavigateToTheBeginning.AccessibleDescription = "Navigates to the beginning of the data";
			this.menuitemNavigateToTheBeginning.AccessibleName = "Navigates to the beginning";
			this.menuitemNavigateToTheBeginning.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateToTheBeginning.AutoToolTip = true;
			this.menuitemNavigateToTheBeginning.DoubleClickEnabled = true;
			this.menuitemNavigateToTheBeginning.Image = global::Planetoid_DB.Properties.Resources.silk_backward_end_green;
			this.menuitemNavigateToTheBeginning.Name = "menuitemNavigateToTheBeginning";
			this.menuitemNavigateToTheBeginning.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
			this.menuitemNavigateToTheBeginning.Size = new System.Drawing.Size(274, 22);
			this.menuitemNavigateToTheBeginning.Text = "Navigate to the &beginning";
			this.menuitemNavigateToTheBeginning.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToTheBegin_Click);
			this.menuitemNavigateToTheBeginning.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateToTheBeginning.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateToThePreviousData
			// 
			this.menuitemNavigateToThePreviousData.AccessibleDescription = "Navigates to the previous data";
			this.menuitemNavigateToThePreviousData.AccessibleName = "Navigates to the previous";
			this.menuitemNavigateToThePreviousData.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateToThePreviousData.AutoToolTip = true;
			this.menuitemNavigateToThePreviousData.DoubleClickEnabled = true;
			this.menuitemNavigateToThePreviousData.Image = global::Planetoid_DB.Properties.Resources.silk_backward_1_green;
			this.menuitemNavigateToThePreviousData.Name = "menuitemNavigateToThePreviousData";
			this.menuitemNavigateToThePreviousData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.menuitemNavigateToThePreviousData.Size = new System.Drawing.Size(274, 22);
			this.menuitemNavigateToThePreviousData.Text = "Navigate to the &previous";
			this.menuitemNavigateToThePreviousData.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToThePreviousData_Click);
			this.menuitemNavigateToThePreviousData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateToThePreviousData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateToTheNextData
			// 
			this.menuitemNavigateToTheNextData.AccessibleDescription = "Navigates to the next data";
			this.menuitemNavigateToTheNextData.AccessibleName = "Navigates to the next";
			this.menuitemNavigateToTheNextData.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateToTheNextData.AutoToolTip = true;
			this.menuitemNavigateToTheNextData.DoubleClickEnabled = true;
			this.menuitemNavigateToTheNextData.Image = global::Planetoid_DB.Properties.Resources.silk_forward_1_green;
			this.menuitemNavigateToTheNextData.Name = "menuitemNavigateToTheNextData";
			this.menuitemNavigateToTheNextData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
			this.menuitemNavigateToTheNextData.Size = new System.Drawing.Size(274, 22);
			this.menuitemNavigateToTheNextData.Text = "Navigate to the &next";
			this.menuitemNavigateToTheNextData.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToTheNextData_Click);
			this.menuitemNavigateToTheNextData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateToTheNextData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateToTheEnd
			// 
			this.menuitemNavigateToTheEnd.AccessibleDescription = "Navigates to the end of the data";
			this.menuitemNavigateToTheEnd.AccessibleName = "Navigates to the end";
			this.menuitemNavigateToTheEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemNavigateToTheEnd.AutoToolTip = true;
			this.menuitemNavigateToTheEnd.DoubleClickEnabled = true;
			this.menuitemNavigateToTheEnd.Image = global::Planetoid_DB.Properties.Resources.silk_forward_end_green;
			this.menuitemNavigateToTheEnd.Name = "menuitemNavigateToTheEnd";
			this.menuitemNavigateToTheEnd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
			this.menuitemNavigateToTheEnd.Size = new System.Drawing.Size(274, 22);
			this.menuitemNavigateToTheEnd.Text = "Navigate to the &end";
			this.menuitemNavigateToTheEnd.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToTheEnd_Click);
			this.menuitemNavigateToTheEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemNavigateToTheEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemTools
			// 
			this.menuitemTools.AccessibleDescription = "Opens the menu \"tools\"";
			this.menuitemTools.AccessibleName = "Tools";
			this.menuitemTools.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemTools.AutoToolTip = true;
			this.menuitemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDerivatedOrbitElements,
            this.menuitemFilter,
            this.toolStripSeparatorTools1,
            this.menuitemRecords,
            this.toolStripSeparator10,
            this.menuitemDistribution,
            this.toolStripSeparatorTools2,
            this.menuitemDatabaseInformation,
            this.menuitemTableMode,
            this.menuitemTerminology});
			this.menuitemTools.Name = "menuitemTools";
			this.menuitemTools.Size = new System.Drawing.Size(46, 24);
			this.menuitemTools.Text = "&Tools";
			this.menuitemTools.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemTools.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDerivatedOrbitElements
			// 
			this.menuitemDerivatedOrbitElements.AccessibleDescription = "Calculates derivated orbital elements";
			this.menuitemDerivatedOrbitElements.AccessibleName = "Derivated orbital elements";
			this.menuitemDerivatedOrbitElements.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDerivatedOrbitElements.AutoToolTip = true;
			this.menuitemDerivatedOrbitElements.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_branch;
			this.menuitemDerivatedOrbitElements.Name = "menuitemDerivatedOrbitElements";
			this.menuitemDerivatedOrbitElements.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.menuitemDerivatedOrbitElements.Size = new System.Drawing.Size(251, 22);
			this.menuitemDerivatedOrbitElements.Text = "Derivated &orbital elements";
			this.menuitemDerivatedOrbitElements.Click += new System.EventHandler(this.ToolStripMenuItemDerivatedOrbitElements_Click);
			this.menuitemDerivatedOrbitElements.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDerivatedOrbitElements.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemFilter
			// 
			this.menuitemFilter.AccessibleDescription = "Filters the orbital elements in some ranges";
			this.menuitemFilter.AccessibleName = "Filter";
			this.menuitemFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemFilter.AutoToolTip = true;
			this.menuitemFilter.Enabled = false;
			this.menuitemFilter.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_divide;
			this.menuitemFilter.Name = "menuitemFilter";
			this.menuitemFilter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.menuitemFilter.Size = new System.Drawing.Size(251, 22);
			this.menuitemFilter.Text = "&Filter";
			this.menuitemFilter.Click += new System.EventHandler(this.ToolStripMenuItemFilter_Click);
			this.menuitemFilter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemFilter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorTools1
			// 
			this.toolStripSeparatorTools1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorTools1.AccessibleName = "Just a separator";
			this.toolStripSeparatorTools1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorTools1.Name = "toolStripSeparatorTools1";
			this.toolStripSeparatorTools1.Size = new System.Drawing.Size(248, 6);
			this.toolStripSeparatorTools1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorTools1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.AccessibleDescription = "Just a separator";
			this.toolStripSeparator10.AccessibleName = "Just a separator";
			this.toolStripSeparator10.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(248, 6);
			// 
			// toolStripSeparatorTools2
			// 
			this.toolStripSeparatorTools2.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorTools2.AccessibleName = "Just a separator";
			this.toolStripSeparatorTools2.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorTools2.Name = "toolStripSeparatorTools2";
			this.toolStripSeparatorTools2.Size = new System.Drawing.Size(248, 6);
			this.toolStripSeparatorTools2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorTools2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDatabaseInformation
			// 
			this.menuitemDatabaseInformation.AccessibleDescription = "Shows the information of the MPCORB.DAT databbase";
			this.menuitemDatabaseInformation.AccessibleName = "Database information";
			this.menuitemDatabaseInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDatabaseInformation.AutoToolTip = true;
			this.menuitemDatabaseInformation.DoubleClickEnabled = true;
			this.menuitemDatabaseInformation.Image = global::Planetoid_DB.Properties.Resources.silk_database;
			this.menuitemDatabaseInformation.Name = "menuitemDatabaseInformation";
			this.menuitemDatabaseInformation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
			this.menuitemDatabaseInformation.Size = new System.Drawing.Size(251, 22);
			this.menuitemDatabaseInformation.Text = "Database &information";
			this.menuitemDatabaseInformation.Click += new System.EventHandler(this.ToolStripMenuItemDatabaseInformation_Click);
			this.menuitemDatabaseInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDatabaseInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemTableMode
			// 
			this.menuitemTableMode.AccessibleDescription = "Activates the table mode";
			this.menuitemTableMode.AccessibleName = "Table mode";
			this.menuitemTableMode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemTableMode.AutoToolTip = true;
			this.menuitemTableMode.DoubleClickEnabled = true;
			this.menuitemTableMode.Image = global::Planetoid_DB.Properties.Resources.silk_table;
			this.menuitemTableMode.Name = "menuitemTableMode";
			this.menuitemTableMode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
			this.menuitemTableMode.Size = new System.Drawing.Size(251, 22);
			this.menuitemTableMode.Text = "&Table mode";
			this.menuitemTableMode.Click += new System.EventHandler(this.ToolStripMenuItemTableMode_Click);
			this.menuitemTableMode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemTableMode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemTerminology
			// 
			this.menuitemTerminology.AccessibleDescription = "Shows the terminology";
			this.menuitemTerminology.AccessibleName = "Terminology";
			this.menuitemTerminology.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemTerminology.AutoToolTip = true;
			this.menuitemTerminology.DoubleClickEnabled = true;
			this.menuitemTerminology.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_bullets;
			this.menuitemTerminology.Name = "menuitemTerminology";
			this.menuitemTerminology.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
			this.menuitemTerminology.Size = new System.Drawing.Size(251, 22);
			this.menuitemTerminology.Text = "Terminolog&y";
			this.menuitemTerminology.Click += new System.EventHandler(this.ToolStripMenuItemTerminology_Click);
			this.menuitemTerminology.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemTerminology.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemUpdate
			// 
			this.menuitemUpdate.AccessibleDescription = "Opens the menu \"updates\"";
			this.menuitemUpdate.AccessibleName = "Update";
			this.menuitemUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemCheckMpcorbDat,
            this.menuitemDownloadMpcorbDat});
			this.menuitemUpdate.Name = "menuitemUpdate";
			this.menuitemUpdate.Size = new System.Drawing.Size(57, 24);
			this.menuitemUpdate.Text = "&Update";
			this.menuitemUpdate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemUpdate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCheckMpcorbDat
			// 
			this.menuitemCheckMpcorbDat.AccessibleDescription = "Checks for updates of the database";
			this.menuitemCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			this.menuitemCheckMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCheckMpcorbDat.AutoToolTip = true;
			this.menuitemCheckMpcorbDat.DoubleClickEnabled = true;
			this.menuitemCheckMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.menuitemCheckMpcorbDat.Name = "menuitemCheckMpcorbDat";
			this.menuitemCheckMpcorbDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.menuitemCheckMpcorbDat.Size = new System.Drawing.Size(242, 22);
			this.menuitemCheckMpcorbDat.Text = "&Check MPCORB.DAT";
			this.menuitemCheckMpcorbDat.Click += new System.EventHandler(this.MenuitemCheckMpcorbDat_Click);
			this.menuitemCheckMpcorbDat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCheckMpcorbDat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDownloadMpcorbDat
			// 
			this.menuitemDownloadMpcorbDat.AccessibleDescription = "Downloads the database";
			this.menuitemDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			this.menuitemDownloadMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDownloadMpcorbDat.AutoToolTip = true;
			this.menuitemDownloadMpcorbDat.DoubleClickEnabled = true;
			this.menuitemDownloadMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_package;
			this.menuitemDownloadMpcorbDat.Name = "menuitemDownloadMpcorbDat";
			this.menuitemDownloadMpcorbDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.menuitemDownloadMpcorbDat.Size = new System.Drawing.Size(242, 22);
			this.menuitemDownloadMpcorbDat.Text = "&Download MPCORB.DAT";
			this.menuitemDownloadMpcorbDat.Click += new System.EventHandler(this.MenuitemDownloadMpcorbDat_Click);
			this.menuitemDownloadMpcorbDat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDownloadMpcorbDat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOptions
			// 
			this.menuitemOptions.AccessibleDescription = "Opens the menu \"options\"";
			this.menuitemOptions.AccessibleName = "Options";
			this.menuitemOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemOptions.AutoToolTip = true;
			this.menuitemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemSettings,
            this.menuitemStyle,
            this.toolStripSeparatorOptions,
            this.menuitemOptionStayOnTop,
            this.menuitemOptionEnabledCopyingByDoubleClicking,
            this.menuitemOptionEnableLinkingToTerminology});
			this.menuitemOptions.Name = "menuitemOptions";
			this.menuitemOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.menuitemOptions.Size = new System.Drawing.Size(61, 24);
			this.menuitemOptions.Text = "&Options";
			this.menuitemOptions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOptions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSettings
			// 
			this.menuitemSettings.AccessibleDescription = "Changes the settings";
			this.menuitemSettings.AccessibleName = "settings";
			this.menuitemSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSettings.AutoToolTip = true;
			this.menuitemSettings.Enabled = false;
			this.menuitemSettings.Image = global::Planetoid_DB.Properties.Resources.silk_wrench;
			this.menuitemSettings.Name = "menuitemSettings";
			this.menuitemSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.menuitemSettings.Size = new System.Drawing.Size(302, 22);
			this.menuitemSettings.Text = "&Settings";
			this.menuitemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
			this.menuitemSettings.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSettings.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemStyle
			// 
			this.menuitemStyle.AccessibleDescription = "Changes the style";
			this.menuitemStyle.AccessibleName = "Look and Feel";
			this.menuitemStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemStyle.AutoToolTip = true;
			this.menuitemStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemIconsetSilk,
            this.menuitemIconsetFugue,
            this.menuitemIconsetFatcow});
			this.menuitemStyle.Image = global::Planetoid_DB.Properties.Resources.silk_theme;
			this.menuitemStyle.Name = "menuitemStyle";
			this.menuitemStyle.ShortcutKeyDisplayString = "";
			this.menuitemStyle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
			this.menuitemStyle.Size = new System.Drawing.Size(302, 22);
			this.menuitemStyle.Text = "&Look and Feel";
			this.menuitemStyle.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemStyle.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemIconsetSilk
			// 
			this.menuitemIconsetSilk.AccessibleDescription = "Changes the icon set to Silk icons";
			this.menuitemIconsetSilk.AccessibleName = "Silk icons";
			this.menuitemIconsetSilk.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemIconsetSilk.AutoToolTip = true;
			this.menuitemIconsetSilk.Checked = true;
			this.menuitemIconsetSilk.CheckOnClick = true;
			this.menuitemIconsetSilk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemIconsetSilk.Enabled = false;
			this.menuitemIconsetSilk.Name = "menuitemIconsetSilk";
			this.menuitemIconsetSilk.Size = new System.Drawing.Size(143, 22);
			this.menuitemIconsetSilk.Text = "Silk icons";
			this.menuitemIconsetSilk.Click += new System.EventHandler(this.ToolStripMenuItemIconsetSilk_Click);
			this.menuitemIconsetSilk.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemIconsetSilk.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemIconsetFugue
			// 
			this.menuitemIconsetFugue.AccessibleDescription = "Changes the icon set to Fugue icons";
			this.menuitemIconsetFugue.AccessibleName = "Fugue icons";
			this.menuitemIconsetFugue.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemIconsetFugue.AutoToolTip = true;
			this.menuitemIconsetFugue.CheckOnClick = true;
			this.menuitemIconsetFugue.Enabled = false;
			this.menuitemIconsetFugue.Name = "menuitemIconsetFugue";
			this.menuitemIconsetFugue.Size = new System.Drawing.Size(143, 22);
			this.menuitemIconsetFugue.Text = "Fugue icons";
			this.menuitemIconsetFugue.Click += new System.EventHandler(this.ToolStripMenuItemIconsetFugue_Click);
			this.menuitemIconsetFugue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemIconsetFugue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemIconsetFatcow
			// 
			this.menuitemIconsetFatcow.AccessibleDescription = "Changes the icon set to Fatcow icons";
			this.menuitemIconsetFatcow.AccessibleName = "Fatcow icons";
			this.menuitemIconsetFatcow.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemIconsetFatcow.AutoToolTip = true;
			this.menuitemIconsetFatcow.CheckOnClick = true;
			this.menuitemIconsetFatcow.Enabled = false;
			this.menuitemIconsetFatcow.Name = "menuitemIconsetFatcow";
			this.menuitemIconsetFatcow.Size = new System.Drawing.Size(143, 22);
			this.menuitemIconsetFatcow.Text = "Fatcow icons";
			this.menuitemIconsetFatcow.Click += new System.EventHandler(this.ToolStripMenuItemIconsetFatcow_Click);
			this.menuitemIconsetFatcow.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemIconsetFatcow.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorOptions
			// 
			this.toolStripSeparatorOptions.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorOptions.AccessibleName = "Just a separator";
			this.toolStripSeparatorOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorOptions.Name = "toolStripSeparatorOptions";
			this.toolStripSeparatorOptions.Size = new System.Drawing.Size(299, 6);
			this.toolStripSeparatorOptions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorOptions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOptionStayOnTop
			// 
			this.menuitemOptionStayOnTop.AccessibleDescription = "Stays the application always on top";
			this.menuitemOptionStayOnTop.AccessibleName = "Stays always on top";
			this.menuitemOptionStayOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOptionStayOnTop.AutoToolTip = true;
			this.menuitemOptionStayOnTop.CheckOnClick = true;
			this.menuitemOptionStayOnTop.Name = "menuitemOptionStayOnTop";
			this.menuitemOptionStayOnTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
			this.menuitemOptionStayOnTop.Size = new System.Drawing.Size(302, 22);
			this.menuitemOptionStayOnTop.Text = "Stay always on &top";
			this.menuitemOptionStayOnTop.Click += new System.EventHandler(this.ToolStripMenuItemStayOnTop_Click);
			this.menuitemOptionStayOnTop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOptionStayOnTop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOptionEnabledCopyingByDoubleClicking
			// 
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleDescription = "Enableds copying data to the clipboard by double-clicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleName = "Enableds copying by double-clicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOptionEnabledCopyingByDoubleClicking.AutoToolTip = true;
			this.menuitemOptionEnabledCopyingByDoubleClicking.Checked = true;
			this.menuitemOptionEnabledCopyingByDoubleClicking.CheckOnClick = true;
			this.menuitemOptionEnabledCopyingByDoubleClicking.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemOptionEnabledCopyingByDoubleClicking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuitemOptionEnabledCopyingByDoubleClicking.Name = "menuitemOptionEnabledCopyingByDoubleClicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.menuitemOptionEnabledCopyingByDoubleClicking.Size = new System.Drawing.Size(302, 22);
			this.menuitemOptionEnabledCopyingByDoubleClicking.Text = "Enabled &copying by double-clicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.Click += new System.EventHandler(this.ToolStripMenuItemEnableCopyingByDoubleClicking_Click);
			this.menuitemOptionEnabledCopyingByDoubleClicking.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOptionEnabledCopyingByDoubleClicking.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOptionEnableLinkingToTerminology
			// 
			this.menuitemOptionEnableLinkingToTerminology.AccessibleDescription = "Enables linking to terminology";
			this.menuitemOptionEnableLinkingToTerminology.AccessibleName = "Enables linking to terminology";
			this.menuitemOptionEnableLinkingToTerminology.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOptionEnableLinkingToTerminology.AutoToolTip = true;
			this.menuitemOptionEnableLinkingToTerminology.Checked = true;
			this.menuitemOptionEnableLinkingToTerminology.CheckOnClick = true;
			this.menuitemOptionEnableLinkingToTerminology.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemOptionEnableLinkingToTerminology.Enabled = false;
			this.menuitemOptionEnableLinkingToTerminology.Name = "menuitemOptionEnableLinkingToTerminology";
			this.menuitemOptionEnableLinkingToTerminology.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
			this.menuitemOptionEnableLinkingToTerminology.Size = new System.Drawing.Size(302, 22);
			this.menuitemOptionEnableLinkingToTerminology.Text = "Enable linking to terminolog&y";
			this.menuitemOptionEnableLinkingToTerminology.Click += new System.EventHandler(this.ToolStripMenuItemEnableLinkingToTerminology_Click);
			this.menuitemOptionEnableLinkingToTerminology.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOptionEnableLinkingToTerminology.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemHelp
			// 
			this.menuitemHelp.AccessibleDescription = "Opens the menu \"help\"";
			this.menuitemHelp.AccessibleName = "Help";
			this.menuitemHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemHelp.AutoToolTip = true;
			this.menuitemHelp.DoubleClickEnabled = true;
			this.menuitemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemAbout,
            this.toolStripSeparatorMisc1,
            this.menuitemOpenWebsitePDB,
            this.menuitemOpenWebsiteMPC,
            this.menuitemOpenMPCORBWebsite});
			this.menuitemHelp.Name = "menuitemHelp";
			this.menuitemHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
			this.menuitemHelp.Size = new System.Drawing.Size(44, 24);
			this.menuitemHelp.Text = "&Help";
			this.menuitemHelp.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemHelp.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.menuitemAbout.Size = new System.Drawing.Size(236, 22);
			this.menuitemAbout.Text = "&About";
			this.menuitemAbout.ToolTipText = "More information about the application";
			this.menuitemAbout.Click += new System.EventHandler(this.MenuitemAbout_Click);
			this.menuitemAbout.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemAbout.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorMisc1
			// 
			this.toolStripSeparatorMisc1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorMisc1.AccessibleName = "Just a separator";
			this.toolStripSeparatorMisc1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorMisc1.Name = "toolStripSeparatorMisc1";
			this.toolStripSeparatorMisc1.Size = new System.Drawing.Size(233, 6);
			this.toolStripSeparatorMisc1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorMisc1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOpenWebsitePDB
			// 
			this.menuitemOpenWebsitePDB.AccessibleDescription = "Opens the Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.AccessibleName = "Opens Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOpenWebsitePDB.AutoToolTip = true;
			this.menuitemOpenWebsitePDB.DoubleClickEnabled = true;
			this.menuitemOpenWebsitePDB.Image = global::Planetoid_DB.Properties.Resources.silk_house;
			this.menuitemOpenWebsitePDB.Name = "menuitemOpenWebsitePDB";
			this.menuitemOpenWebsitePDB.Size = new System.Drawing.Size(236, 22);
			this.menuitemOpenWebsitePDB.Text = "Open Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.ToolTipText = "Opens the Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.Click += new System.EventHandler(this.MenuitemOpenWebsitePDB_Click);
			this.menuitemOpenWebsitePDB.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOpenWebsitePDB.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.menuitemOpenWebsiteMPC.Size = new System.Drawing.Size(236, 22);
			this.menuitemOpenWebsiteMPC.Text = "Open MPC homepage";
			this.menuitemOpenWebsiteMPC.ToolTipText = "Opens the MPC homepage";
			this.menuitemOpenWebsiteMPC.Click += new System.EventHandler(this.MenuitemOpenWebsiteMPC_Click);
			this.menuitemOpenWebsiteMPC.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOpenWebsiteMPC.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.menuitemOpenMPCORBWebsite.Size = new System.Drawing.Size(236, 22);
			this.menuitemOpenMPCORBWebsite.Text = "Open MPCORB website";
			this.menuitemOpenMPCORBWebsite.ToolTipText = "Opens the MPCORB website";
			this.menuitemOpenMPCORBWebsite.Click += new System.EventHandler(this.MenuitemOpenMPCORBWebsite_Click);
			this.menuitemOpenMPCORBWebsite.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOpenMPCORBWebsite.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Container";
			this.toolStripContainer.AccessibleName = "Container";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.AccessibleDescription = "Lower part of the control panel";
			this.toolStripContainer.BottomToolStripPanel.AccessibleName = "Lower part of the control panel";
			this.toolStripContainer.BottomToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusBar);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.AccessibleDescription = "Group the controls";
			this.toolStripContainer.ContentPanel.AccessibleName = "Container Panel";
			this.toolStripContainer.ContentPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.ContentPanel.AutoScroll = true;
			this.toolStripContainer.ContentPanel.BackColor = System.Drawing.Color.Transparent;
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanelData);
			this.toolStripContainer.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(804, 290);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			this.toolStripContainer.LeftToolStripPanel.AccessibleDescription = "Left part of the container panel";
			this.toolStripContainer.LeftToolStripPanel.AccessibleName = "Left part of the container panel";
			this.toolStripContainer.LeftToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			this.toolStripContainer.RightToolStripPanel.AccessibleDescription = "Right part of the container panel";
			this.toolStripContainer.RightToolStripPanel.AccessibleName = "Right part of the container panel";
			this.toolStripContainer.RightToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.Size = new System.Drawing.Size(804, 386);
			this.toolStripContainer.TabIndex = 16;
			this.toolTip.SetToolTip(this.toolStripContainer, "container");
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.AccessibleDescription = "Upper part of the container panel";
			this.toolStripContainer.TopToolStripPanel.AccessibleName = "Upper part of the container panel";
			this.toolStripContainer.TopToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menu);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripIcons);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripNavigation);
			// 
			// statusBar
			// 
			this.statusBar.AccessibleDescription = "Shows some information";
			this.statusBar.AccessibleName = "Status bar of some information";
			this.statusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
			this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUpdate,
            this.toolStripStatusLabelBackgroundDownload,
            this.toolStripProgressBarBackgroundDownload,
            this.toolStripStatusLabelCancelBackgroundDownload,
            this.labelInformation});
			this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusBar.Location = new System.Drawing.Point(0, 0);
			this.statusBar.Name = "statusBar";
			this.statusBar.ProgressBars = null;
			this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusBar.ShowItemToolTips = true;
			this.statusBar.Size = new System.Drawing.Size(804, 22);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 0;
			this.statusBar.TabStop = true;
			this.statusBar.Text = "statusStrip";
			// 
			// toolStripStatusLabelUpdate
			// 
			this.toolStripStatusLabelUpdate.AccessibleDescription = "Shows that an MPCORB.DAT update is aviable";
			this.toolStripStatusLabelUpdate.AccessibleName = "Update information";
			this.toolStripStatusLabelUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabelUpdate.AutoToolTip = true;
			this.toolStripStatusLabelUpdate.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.toolStripStatusLabelUpdate.IsLink = true;
			this.toolStripStatusLabelUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.toolStripStatusLabelUpdate.LinkColor = System.Drawing.SystemColors.ControlText;
			this.toolStripStatusLabelUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.toolStripStatusLabelUpdate.Name = "toolStripStatusLabelUpdate";
			this.toolStripStatusLabelUpdate.Size = new System.Drawing.Size(185, 16);
			this.toolStripStatusLabelUpdate.Text = "MPCORB.DAT update available";
			this.toolStripStatusLabelUpdate.ToolTipText = "MPCORB.DAT update aviable";
			this.toolStripStatusLabelUpdate.Click += new System.EventHandler(this.ToolStripStatusLabelUpdate_Click);
			this.toolStripStatusLabelUpdate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripStatusLabelUpdate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripStatusLabelBackgroundDownload
			// 
			this.toolStripStatusLabelBackgroundDownload.AccessibleDescription = "Shows the download progres";
			this.toolStripStatusLabelBackgroundDownload.AccessibleName = "Download progress";
			this.toolStripStatusLabelBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.toolStripStatusLabelBackgroundDownload.AutoToolTip = true;
			this.toolStripStatusLabelBackgroundDownload.Image = global::Planetoid_DB.Properties.Resources.silk_package_go;
			this.toolStripStatusLabelBackgroundDownload.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.toolStripStatusLabelBackgroundDownload.Name = "toolStripStatusLabelBackgroundDownload";
			this.toolStripStatusLabelBackgroundDownload.Size = new System.Drawing.Size(80, 16);
			this.toolStripStatusLabelBackgroundDownload.Text = "Download:";
			this.toolStripStatusLabelBackgroundDownload.ToolTipText = "Show the download progres";
			this.toolStripStatusLabelBackgroundDownload.DoubleClick += new System.EventHandler(this.EasterEgg_DoubleClick);
			this.toolStripStatusLabelBackgroundDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripStatusLabelBackgroundDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripProgressBarBackgroundDownload
			// 
			this.toolStripProgressBarBackgroundDownload.AccessibleDescription = "Shows the download progres";
			this.toolStripProgressBarBackgroundDownload.AccessibleName = "Download progress";
			this.toolStripProgressBarBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.toolStripProgressBarBackgroundDownload.AutoToolTip = true;
			this.toolStripProgressBarBackgroundDownload.Enabled = false;
			this.toolStripProgressBarBackgroundDownload.Name = "toolStripProgressBarBackgroundDownload";
			this.toolStripProgressBarBackgroundDownload.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBarBackgroundDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.toolStripProgressBarBackgroundDownload.ToolTipText = "Show the download progres";
			this.toolStripProgressBarBackgroundDownload.DoubleClick += new System.EventHandler(this.EasterEgg_DoubleClick);
			this.toolStripProgressBarBackgroundDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripProgressBarBackgroundDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripStatusLabelCancelBackgroundDownload
			// 
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleDescription = "Cancels the background download";
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleName = "Cancel download";
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.toolStripStatusLabelCancelBackgroundDownload.AutoToolTip = true;
			this.toolStripStatusLabelCancelBackgroundDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStatusLabelCancelBackgroundDownload.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.toolStripStatusLabelCancelBackgroundDownload.Name = "toolStripStatusLabelCancelBackgroundDownload";
			this.toolStripStatusLabelCancelBackgroundDownload.Size = new System.Drawing.Size(16, 16);
			this.toolStripStatusLabelCancelBackgroundDownload.Text = "Cancel background download";
			this.toolStripStatusLabelCancelBackgroundDownload.Click += new System.EventHandler(this.ToolStripStatusLabelCancelBackgroundDownload_Click);
			this.toolStripStatusLabelCancelBackgroundDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripStatusLabelCancelBackgroundDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.labelInformation.Size = new System.Drawing.Size(144, 16);
			this.labelInformation.Spring = true;
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Shows some information";
			// 
			// toolStripIcons
			// 
			this.toolStripIcons.AccessibleDescription = "Toolbar of main functions";
			this.toolStripIcons.AccessibleName = "Toolbar of main functions";
			this.toolStripIcons.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.toolStripIcons.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripIcons.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonExport,
            this.toolStripButtonPrint,
            this.splitbuttonCopyToClipboard,
            this.toolStripSeparator4,
            this.toolStripButtonDatabaseInformation,
            this.toolStripButtonTableMode,
            this.toolStripButtonTerminology,
            this.toolStripSeparator3,
            this.splitbuttonTopTenRecords,
            this.splitbuttonDistribution,
            this.toolStripSeparator5,
            this.toolStripButtonCheckMpcorbDat,
            this.toolStripButtonDownloadMpcorbDat,
            this.toolStripSeparator1,
            this.toolStripButtonAbout,
            this.toolStripButtonOpenWebsitePDB,
            this.toolStripSeparator2,
            this.toolStripLabelQuickSearch,
            this.toolStripTextBoxSearch,
            this.splitbuttonSearch});
			this.toolStripIcons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripIcons.Location = new System.Drawing.Point(0, 24);
			this.toolStripIcons.Name = "toolStripIcons";
			this.toolStripIcons.Size = new System.Drawing.Size(804, 25);
			this.toolStripIcons.Stretch = true;
			this.toolStripIcons.TabIndex = 1;
			this.toolStripIcons.TabStop = true;
			this.toolStripIcons.Text = "Toolbar of main functions";
			this.toolStripIcons.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripIcons.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.toolStripIcons.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripIcons.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonOpen
			// 
			this.toolStripButtonOpen.AccessibleDescription = "Opens a local MPCORB.DAT file";
			this.toolStripButtonOpen.AccessibleName = "Open";
			this.toolStripButtonOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpen.Enabled = false;
			this.toolStripButtonOpen.Image = global::Planetoid_DB.Properties.Resources.silk_folder;
			this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpen.Name = "toolStripButtonOpen";
			this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonOpen.Text = "Open";
			this.toolStripButtonOpen.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
			this.toolStripButtonOpen.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonOpen.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonExport
			// 
			this.toolStripButtonExport.AccessibleDescription = "Exports data entry";
			this.toolStripButtonExport.AccessibleName = "Export";
			this.toolStripButtonExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExport.Image = global::Planetoid_DB.Properties.Resources.silk_page_save;
			this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExport.Name = "toolStripButtonExport";
			this.toolStripButtonExport.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExport.Text = "Export";
			this.toolStripButtonExport.Click += new System.EventHandler(this.ToolStripSplitButtonExport_Click);
			this.toolStripButtonExport.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonExport.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonPrint
			// 
			this.toolStripButtonPrint.AccessibleDescription = "Prints the information";
			this.toolStripButtonPrint.AccessibleName = "Print";
			this.toolStripButtonPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Print";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.ToolStripButtonPrint_Click);
			this.toolStripButtonPrint.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonPrint.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AccessibleDescription = "Just a separator";
			this.toolStripSeparator4.AccessibleName = "Just a separator";
			this.toolStripSeparator4.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator4.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator4.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonDatabaseInformation
			// 
			this.toolStripButtonDatabaseInformation.AccessibleDescription = "Shows some information of the MPCORB.DAT database";
			this.toolStripButtonDatabaseInformation.AccessibleName = "Database Information";
			this.toolStripButtonDatabaseInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonDatabaseInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDatabaseInformation.Image = global::Planetoid_DB.Properties.Resources.silk_database;
			this.toolStripButtonDatabaseInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDatabaseInformation.Name = "toolStripButtonDatabaseInformation";
			this.toolStripButtonDatabaseInformation.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDatabaseInformation.Text = "Database information";
			this.toolStripButtonDatabaseInformation.Click += new System.EventHandler(this.ToolStripButtonDatabaseInformation_Click);
			this.toolStripButtonDatabaseInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonDatabaseInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonTableMode
			// 
			this.toolStripButtonTableMode.AccessibleDescription = "Activates the table mode";
			this.toolStripButtonTableMode.AccessibleName = "Table mode";
			this.toolStripButtonTableMode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonTableMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTableMode.Image = global::Planetoid_DB.Properties.Resources.silk_table;
			this.toolStripButtonTableMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonTableMode.Name = "toolStripButtonTableMode";
			this.toolStripButtonTableMode.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonTableMode.Text = "Table mode";
			this.toolStripButtonTableMode.ToolTipText = "Activate the table mode";
			this.toolStripButtonTableMode.Click += new System.EventHandler(this.ToolStripButtonTableMode_Click);
			this.toolStripButtonTableMode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonTableMode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonTerminology
			// 
			this.toolStripButtonTerminology.AccessibleDescription = "Shows the terminology";
			this.toolStripButtonTerminology.AccessibleName = "Terminology";
			this.toolStripButtonTerminology.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonTerminology.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTerminology.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_bullets;
			this.toolStripButtonTerminology.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonTerminology.Name = "toolStripButtonTerminology";
			this.toolStripButtonTerminology.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonTerminology.Text = "Terminology";
			this.toolStripButtonTerminology.ToolTipText = "Show the terminology";
			this.toolStripButtonTerminology.Click += new System.EventHandler(this.ToolStripButtonTerminology_Click);
			this.toolStripButtonTerminology.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonTerminology.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AccessibleDescription = "Just a separator";
			this.toolStripSeparator3.AccessibleName = "Just a separator";
			this.toolStripSeparator3.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator3.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator3.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// splitbuttonTopTenRecords
			// 
			this.splitbuttonTopTenRecords.AccessibleDescription = "Shows the top ten records";
			this.splitbuttonTopTenRecords.AccessibleName = "Top ten records";
			this.splitbuttonTopTenRecords.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonTopTenRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonTopTenRecords.DropDown = this.contextMenuTopTenRecords;
			this.splitbuttonTopTenRecords.Enabled = false;
			this.splitbuttonTopTenRecords.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_numbers;
			this.splitbuttonTopTenRecords.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.splitbuttonTopTenRecords.Name = "splitbuttonTopTenRecords";
			this.splitbuttonTopTenRecords.Size = new System.Drawing.Size(32, 22);
			this.splitbuttonTopTenRecords.Text = "Top ten records";
			this.splitbuttonTopTenRecords.ButtonClick += new System.EventHandler(this.SplitbuttonTopTenRecords_ButtonClick);
			this.splitbuttonTopTenRecords.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.splitbuttonTopTenRecords.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// splitbuttonDistribution
			// 
			this.splitbuttonDistribution.AccessibleDescription = "Shows some distributions";
			this.splitbuttonDistribution.AccessibleName = "Distributions";
			this.splitbuttonDistribution.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonDistribution.DropDown = this.contextMenuDistributions;
			this.splitbuttonDistribution.Enabled = false;
			this.splitbuttonDistribution.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.splitbuttonDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.splitbuttonDistribution.Name = "splitbuttonDistribution";
			this.splitbuttonDistribution.Size = new System.Drawing.Size(32, 22);
			this.splitbuttonDistribution.Text = "Distributions";
			this.splitbuttonDistribution.ButtonClick += new System.EventHandler(this.SplitbuttonDistribution_ButtonClick);
			this.splitbuttonDistribution.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.splitbuttonDistribution.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.AccessibleDescription = "Just a separator";
			this.toolStripSeparator5.AccessibleName = "Just a separator";
			this.toolStripSeparator5.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator5.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator5.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonCheckMpcorbDat
			// 
			this.toolStripButtonCheckMpcorbDat.AccessibleDescription = "Checks for updates of the database";
			this.toolStripButtonCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonCheckMpcorbDat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCheckMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.toolStripButtonCheckMpcorbDat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCheckMpcorbDat.Name = "toolStripButtonCheckMpcorbDat";
			this.toolStripButtonCheckMpcorbDat.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonCheckMpcorbDat.Text = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.ToolTipText = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.Click += new System.EventHandler(this.ToolStripButtonCheckMpcorbDat_Click);
			this.toolStripButtonCheckMpcorbDat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonCheckMpcorbDat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonDownloadMpcorbDat
			// 
			this.toolStripButtonDownloadMpcorbDat.AccessibleDescription = "Downloads the database";
			this.toolStripButtonDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			this.toolStripButtonDownloadMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonDownloadMpcorbDat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDownloadMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_package_go;
			this.toolStripButtonDownloadMpcorbDat.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonDownloadMpcorbDat.Name = "toolStripButtonDownloadMpcorbDat";
			this.toolStripButtonDownloadMpcorbDat.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDownloadMpcorbDat.Text = "Download MPCORB.DAT";
			this.toolStripButtonDownloadMpcorbDat.ToolTipText = "Download the database";
			this.toolStripButtonDownloadMpcorbDat.Click += new System.EventHandler(this.ToolStripButtonDownloadMpcorbDat_Click);
			this.toolStripButtonDownloadMpcorbDat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonDownloadMpcorbDat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AccessibleDescription = "Just a separator";
			this.toolStripSeparator1.AccessibleName = "Just a separator";
			this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.AccessibleDescription = "More information about the application";
			this.toolStripButtonAbout.AccessibleName = "About";
			this.toolStripButtonAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.Image = global::Planetoid_DB.Properties.Resources.silk_information;
			this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAbout.Text = "About";
			this.toolStripButtonAbout.ToolTipText = "More information about the application";
			this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
			this.toolStripButtonAbout.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonAbout.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonOpenWebsitePDB
			// 
			this.toolStripButtonOpenWebsitePDB.AccessibleDescription = "Opens the Planetoid-DB homepage";
			this.toolStripButtonOpenWebsitePDB.AccessibleName = "Open Planetoid-DB homepage";
			this.toolStripButtonOpenWebsitePDB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonOpenWebsitePDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpenWebsitePDB.Image = global::Planetoid_DB.Properties.Resources.silk_house;
			this.toolStripButtonOpenWebsitePDB.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpenWebsitePDB.Name = "toolStripButtonOpenWebsitePDB";
			this.toolStripButtonOpenWebsitePDB.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonOpenWebsitePDB.Text = "Open Planetoid-DB homepage";
			this.toolStripButtonOpenWebsitePDB.Click += new System.EventHandler(this.ToolStripButtonOpenWebsitePDB_Click);
			this.toolStripButtonOpenWebsitePDB.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonOpenWebsitePDB.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AccessibleDescription = "Just a separator";
			this.toolStripSeparator2.AccessibleName = "Just a separator";
			this.toolStripSeparator2.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripLabelQuickSearch
			// 
			this.toolStripLabelQuickSearch.AccessibleDescription = "Quick search";
			this.toolStripLabelQuickSearch.AccessibleName = "Quick search";
			this.toolStripLabelQuickSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripLabelQuickSearch.AutoToolTip = true;
			this.toolStripLabelQuickSearch.Name = "toolStripLabelQuickSearch";
			this.toolStripLabelQuickSearch.Size = new System.Drawing.Size(78, 22);
			this.toolStripLabelQuickSearch.Text = "Quick search:";
			this.toolStripLabelQuickSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripLabelQuickSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripTextBoxSearch
			// 
			this.toolStripTextBoxSearch.AccessibleDescription = "Enter the search term";
			this.toolStripTextBoxSearch.AccessibleName = "Seach field";
			this.toolStripTextBoxSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.toolStripTextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.toolStripTextBoxSearch.AutoToolTip = true;
			this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
			this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxSearch.ToolTipText = "Search";
			this.toolStripTextBoxSearch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripTextBoxSearch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.toolStripTextBoxSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripTextBoxSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// splitbuttonSearch
			// 
			this.splitbuttonSearch.AccessibleDescription = "Search";
			this.splitbuttonSearch.AccessibleName = "Search";
			this.splitbuttonSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemSearchIndex,
            this.menuitemSearchReadableDesignation,
            this.menuitemSearchEpoch,
            this.menuitemSearchMeanAnomalyAtTheEpoch,
            this.menuitemSearchArgumentOfPerihelion,
            this.menuitemSearchLongitudeOfTheAscendingNode,
            this.menuitemSearchInclination,
            this.menuitemSearchOrbitalEccentricity,
            this.menuitemSearchMeanDailyMotion,
            this.menuitemSearchSemiMajorAxis,
            this.menuitemSearchAbsoluteMagnitude,
            this.menuitemSearchSlopeParameter,
            this.menuitemSearchReference,
            this.menuitemSearchNumberOfOppositions,
            this.menuitemSearchNumberOfObservations,
            this.menuitemSearchObservationSpan,
            this.menuitemSearchRmsResidual,
            this.menuitemSearchComputerName,
            this.menuitemSearchDateOfTheLastObservation,
            this.menuitemSearchFlags});
			this.splitbuttonSearch.Image = global::Planetoid_DB.Properties.Resources.silk_magnifier;
			this.splitbuttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.splitbuttonSearch.Name = "splitbuttonSearch";
			this.splitbuttonSearch.Size = new System.Drawing.Size(32, 22);
			this.splitbuttonSearch.Text = "Search";
			this.splitbuttonSearch.ButtonClick += new System.EventHandler(this.ToolStripMenuItemSearch_Click);
			this.splitbuttonSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.splitbuttonSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchIndex
			// 
			this.menuitemSearchIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchIndex.AutoToolTip = true;
			this.menuitemSearchIndex.Checked = true;
			this.menuitemSearchIndex.CheckOnClick = true;
			this.menuitemSearchIndex.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchIndex.Name = "menuitemSearchIndex";
			this.menuitemSearchIndex.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchIndex.Text = "Index No.";
			this.menuitemSearchIndex.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchIndex.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchReadableDesignation
			// 
			this.menuitemSearchReadableDesignation.AccessibleDescription = "Enables/disables the readable designation for the search";
			this.menuitemSearchReadableDesignation.AccessibleName = "Enables/disables the readable designation for the search";
			this.menuitemSearchReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchReadableDesignation.AutoToolTip = true;
			this.menuitemSearchReadableDesignation.Checked = true;
			this.menuitemSearchReadableDesignation.CheckOnClick = true;
			this.menuitemSearchReadableDesignation.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchReadableDesignation.Name = "menuitemSearchReadableDesignation";
			this.menuitemSearchReadableDesignation.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchReadableDesignation.Text = "Readable designation";
			this.menuitemSearchReadableDesignation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchReadableDesignation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchEpoch
			// 
			this.menuitemSearchEpoch.AccessibleDescription = "Enables/disables the epoch for the search";
			this.menuitemSearchEpoch.AccessibleName = "Enables/disables the epoch for the search";
			this.menuitemSearchEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchEpoch.AutoToolTip = true;
			this.menuitemSearchEpoch.Checked = true;
			this.menuitemSearchEpoch.CheckOnClick = true;
			this.menuitemSearchEpoch.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchEpoch.Name = "menuitemSearchEpoch";
			this.menuitemSearchEpoch.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.menuitemSearchEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchMeanAnomalyAtTheEpoch
			// 
			this.menuitemSearchMeanAnomalyAtTheEpoch.AccessibleDescription = "Enables/disables the mean anomaly at the epoch for the search";
			this.menuitemSearchMeanAnomalyAtTheEpoch.AccessibleName = "Enables/disables the mean anomaly at the epoch for the search";
			this.menuitemSearchMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchMeanAnomalyAtTheEpoch.AutoToolTip = true;
			this.menuitemSearchMeanAnomalyAtTheEpoch.Checked = true;
			this.menuitemSearchMeanAnomalyAtTheEpoch.CheckOnClick = true;
			this.menuitemSearchMeanAnomalyAtTheEpoch.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchMeanAnomalyAtTheEpoch.Name = "menuitemSearchMeanAnomalyAtTheEpoch";
			this.menuitemSearchMeanAnomalyAtTheEpoch.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch (°)";
			this.menuitemSearchMeanAnomalyAtTheEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchMeanAnomalyAtTheEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchArgumentOfPerihelion
			// 
			this.menuitemSearchArgumentOfPerihelion.AccessibleDescription = "Enables/disables the argument of perihelion for the search";
			this.menuitemSearchArgumentOfPerihelion.AccessibleName = "Enables/disables the argument of perihelion for the search";
			this.menuitemSearchArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchArgumentOfPerihelion.AutoToolTip = true;
			this.menuitemSearchArgumentOfPerihelion.Checked = true;
			this.menuitemSearchArgumentOfPerihelion.CheckOnClick = true;
			this.menuitemSearchArgumentOfPerihelion.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchArgumentOfPerihelion.Name = "menuitemSearchArgumentOfPerihelion";
			this.menuitemSearchArgumentOfPerihelion.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (°)";
			this.menuitemSearchArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchLongitudeOfTheAscendingNode
			// 
			this.menuitemSearchLongitudeOfTheAscendingNode.AccessibleDescription = "Enables/disables the longitude of the ascending node for the search";
			this.menuitemSearchLongitudeOfTheAscendingNode.AccessibleName = "Enables/disables the longitude of the ascending node for the search";
			this.menuitemSearchLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.menuitemSearchLongitudeOfTheAscendingNode.Checked = true;
			this.menuitemSearchLongitudeOfTheAscendingNode.CheckOnClick = true;
			this.menuitemSearchLongitudeOfTheAscendingNode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchLongitudeOfTheAscendingNode.Name = "menuitemSearchLongitudeOfTheAscendingNode";
			this.menuitemSearchLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0 (°)";
			this.menuitemSearchLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchInclination
			// 
			this.menuitemSearchInclination.AccessibleDescription = "Enables/disables the inclination to the ecliptic for the search";
			this.menuitemSearchInclination.AccessibleName = "Enables/disables the inclination to the ecliptic for the search";
			this.menuitemSearchInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchInclination.AutoToolTip = true;
			this.menuitemSearchInclination.Checked = true;
			this.menuitemSearchInclination.CheckOnClick = true;
			this.menuitemSearchInclination.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchInclination.Name = "menuitemSearchInclination";
			this.menuitemSearchInclination.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchInclination.Text = "Inclination to the ecliptic, J2000.0 (°)";
			this.menuitemSearchInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchOrbitalEccentricity
			// 
			this.menuitemSearchOrbitalEccentricity.AccessibleDescription = "Enables/disables the orbital eccentricity for the search";
			this.menuitemSearchOrbitalEccentricity.AccessibleName = "Enables/disables the orbital eccentricity for the search";
			this.menuitemSearchOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchOrbitalEccentricity.AutoToolTip = true;
			this.menuitemSearchOrbitalEccentricity.Checked = true;
			this.menuitemSearchOrbitalEccentricity.CheckOnClick = true;
			this.menuitemSearchOrbitalEccentricity.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchOrbitalEccentricity.Name = "menuitemSearchOrbitalEccentricity";
			this.menuitemSearchOrbitalEccentricity.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemSearchOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchMeanDailyMotion
			// 
			this.menuitemSearchMeanDailyMotion.AccessibleDescription = "Enables/disables the mean daily motion for the search";
			this.menuitemSearchMeanDailyMotion.AccessibleName = "Enables/disables the mean daily motion for the search";
			this.menuitemSearchMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchMeanDailyMotion.AutoToolTip = true;
			this.menuitemSearchMeanDailyMotion.Checked = true;
			this.menuitemSearchMeanDailyMotion.CheckOnClick = true;
			this.menuitemSearchMeanDailyMotion.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchMeanDailyMotion.Name = "menuitemSearchMeanDailyMotion";
			this.menuitemSearchMeanDailyMotion.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchMeanDailyMotion.Text = "Mean daily motion (°/day)";
			this.menuitemSearchMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchSemiMajorAxis
			// 
			this.menuitemSearchSemiMajorAxis.AccessibleDescription = "Enables/disables the semi major axis for the search";
			this.menuitemSearchSemiMajorAxis.AccessibleName = "Enables/disables the semi major axis for the search";
			this.menuitemSearchSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchSemiMajorAxis.AutoToolTip = true;
			this.menuitemSearchSemiMajorAxis.Checked = true;
			this.menuitemSearchSemiMajorAxis.CheckOnClick = true;
			this.menuitemSearchSemiMajorAxis.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchSemiMajorAxis.Name = "menuitemSearchSemiMajorAxis";
			this.menuitemSearchSemiMajorAxis.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchSemiMajorAxis.Text = "Semi-major axis (AU)";
			this.menuitemSearchSemiMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchSemiMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchAbsoluteMagnitude
			// 
			this.menuitemSearchAbsoluteMagnitude.AccessibleDescription = "Enables/disables the index number for the search";
			this.menuitemSearchAbsoluteMagnitude.AccessibleName = "Enables/disables the index number for the search";
			this.menuitemSearchAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchAbsoluteMagnitude.AutoToolTip = true;
			this.menuitemSearchAbsoluteMagnitude.Checked = true;
			this.menuitemSearchAbsoluteMagnitude.CheckOnClick = true;
			this.menuitemSearchAbsoluteMagnitude.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchAbsoluteMagnitude.Name = "menuitemSearchAbsoluteMagnitude";
			this.menuitemSearchAbsoluteMagnitude.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchAbsoluteMagnitude.Text = "Absolute magnitude, H (mag)";
			this.menuitemSearchAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchSlopeParameter
			// 
			this.menuitemSearchSlopeParameter.AccessibleDescription = "Enables/disables the slope parameter for the search";
			this.menuitemSearchSlopeParameter.AccessibleName = "Enables/disables the slope parameter for the search";
			this.menuitemSearchSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchSlopeParameter.AutoToolTip = true;
			this.menuitemSearchSlopeParameter.Checked = true;
			this.menuitemSearchSlopeParameter.CheckOnClick = true;
			this.menuitemSearchSlopeParameter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchSlopeParameter.Name = "menuitemSearchSlopeParameter";
			this.menuitemSearchSlopeParameter.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchSlopeParameter.Text = "Slope parameter, G";
			this.menuitemSearchSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchReference
			// 
			this.menuitemSearchReference.AccessibleDescription = "Enables/disables the reference for the search";
			this.menuitemSearchReference.AccessibleName = "Enables/disables the reference for the search";
			this.menuitemSearchReference.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchReference.AutoToolTip = true;
			this.menuitemSearchReference.Checked = true;
			this.menuitemSearchReference.CheckOnClick = true;
			this.menuitemSearchReference.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchReference.Name = "menuitemSearchReference";
			this.menuitemSearchReference.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchReference.Text = "Reference";
			this.menuitemSearchReference.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchReference.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchNumberOfOppositions
			// 
			this.menuitemSearchNumberOfOppositions.AccessibleDescription = "Enables/disables the number of oppositions for the search";
			this.menuitemSearchNumberOfOppositions.AccessibleName = "Enables/disables the number of oppositions for the search";
			this.menuitemSearchNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchNumberOfOppositions.AutoToolTip = true;
			this.menuitemSearchNumberOfOppositions.Checked = true;
			this.menuitemSearchNumberOfOppositions.CheckOnClick = true;
			this.menuitemSearchNumberOfOppositions.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchNumberOfOppositions.Name = "menuitemSearchNumberOfOppositions";
			this.menuitemSearchNumberOfOppositions.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemSearchNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchNumberOfObservations
			// 
			this.menuitemSearchNumberOfObservations.AccessibleDescription = "Enables/disables the number of observations for the search";
			this.menuitemSearchNumberOfObservations.AccessibleName = "Enables/disables the number of observations for the search";
			this.menuitemSearchNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchNumberOfObservations.AutoToolTip = true;
			this.menuitemSearchNumberOfObservations.Checked = true;
			this.menuitemSearchNumberOfObservations.CheckOnClick = true;
			this.menuitemSearchNumberOfObservations.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchNumberOfObservations.Name = "menuitemSearchNumberOfObservations";
			this.menuitemSearchNumberOfObservations.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchNumberOfObservations.Text = "Number of observations";
			this.menuitemSearchNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchObservationSpan
			// 
			this.menuitemSearchObservationSpan.AccessibleDescription = "Enables/disables the observation span for the search";
			this.menuitemSearchObservationSpan.AccessibleName = "Enables/disables the observation span for the search";
			this.menuitemSearchObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchObservationSpan.AutoToolTip = true;
			this.menuitemSearchObservationSpan.Checked = true;
			this.menuitemSearchObservationSpan.CheckOnClick = true;
			this.menuitemSearchObservationSpan.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchObservationSpan.Name = "menuitemSearchObservationSpan";
			this.menuitemSearchObservationSpan.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchObservationSpan.Text = "Observation span";
			this.menuitemSearchObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchRmsResidual
			// 
			this.menuitemSearchRmsResidual.AccessibleDescription = "Enables/disables the r.m.s. residual for the search";
			this.menuitemSearchRmsResidual.AccessibleName = "Enables/disables the r.m.s. residual for the search";
			this.menuitemSearchRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchRmsResidual.AutoToolTip = true;
			this.menuitemSearchRmsResidual.Checked = true;
			this.menuitemSearchRmsResidual.CheckOnClick = true;
			this.menuitemSearchRmsResidual.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchRmsResidual.Name = "menuitemSearchRmsResidual";
			this.menuitemSearchRmsResidual.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchRmsResidual.Text = "r.m.s. residual (\")";
			this.menuitemSearchRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchComputerName
			// 
			this.menuitemSearchComputerName.AccessibleDescription = "Enables/disables the computer name for the search";
			this.menuitemSearchComputerName.AccessibleName = "Enables/disables the computer name for the search";
			this.menuitemSearchComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchComputerName.AutoToolTip = true;
			this.menuitemSearchComputerName.Checked = true;
			this.menuitemSearchComputerName.CheckOnClick = true;
			this.menuitemSearchComputerName.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchComputerName.Name = "menuitemSearchComputerName";
			this.menuitemSearchComputerName.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchComputerName.Text = "Computer name";
			this.menuitemSearchComputerName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchComputerName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchDateOfTheLastObservation
			// 
			this.menuitemSearchDateOfTheLastObservation.AccessibleDescription = "Enables/disables the date of the last observation for the search";
			this.menuitemSearchDateOfTheLastObservation.AccessibleName = "Enables/disables the date of the last observation for the search";
			this.menuitemSearchDateOfTheLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchDateOfTheLastObservation.AutoToolTip = true;
			this.menuitemSearchDateOfTheLastObservation.Checked = true;
			this.menuitemSearchDateOfTheLastObservation.CheckOnClick = true;
			this.menuitemSearchDateOfTheLastObservation.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchDateOfTheLastObservation.Name = "menuitemSearchDateOfTheLastObservation";
			this.menuitemSearchDateOfTheLastObservation.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchDateOfTheLastObservation.Text = "Date of the last observation (YYYDDMM)";
			this.menuitemSearchDateOfTheLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchDateOfTheLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchFlags
			// 
			this.menuitemSearchFlags.AccessibleDescription = "Enables/disables the 4-hexdigit flags for the search";
			this.menuitemSearchFlags.AccessibleName = "Enables/disables the 4-hexdigit flags for the search";
			this.menuitemSearchFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchFlags.AutoToolTip = true;
			this.menuitemSearchFlags.Checked = true;
			this.menuitemSearchFlags.CheckOnClick = true;
			this.menuitemSearchFlags.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchFlags.Name = "menuitemSearchFlags";
			this.menuitemSearchFlags.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchFlags.Text = "4-hexdigit flags";
			this.menuitemSearchFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripNavigation
			// 
			this.toolStripNavigation.AccessibleDescription = "Toolbar of the navigation";
			this.toolStripNavigation.AccessibleName = "Toolbar of the navigation";
			this.toolStripNavigation.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.toolStripNavigation.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripNavigation.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadRandomMinorPlanet,
            this.toolStripSeparator8,
            this.toolStripButtonStepToBegin,
            this.toolStripSplitButtonStepBackward,
            this.toolStripButtonStepBackwardOne,
            this.toolStripButtonStepForwardOne,
            this.toolStripSplitButtonStepForward,
            this.toolStripButtonStepToEnd,
            this.toolStripSeparator6,
            this.toolStripLabelGoToIndex,
            this.toolStripTextBoxGotoIndex,
            this.toolStripButtonGoToIndex,
            this.toolStripSeparator7,
            this.toolStripLabelIndexPosition,
            this.toolStripSeparator9,
            this.toolStripButtonDerivatedOrbitElements,
            this.toolStripButtonFilter});
			this.toolStripNavigation.Location = new System.Drawing.Point(0, 49);
			this.toolStripNavigation.Name = "toolStripNavigation";
			this.toolStripNavigation.Size = new System.Drawing.Size(804, 25);
			this.toolStripNavigation.Stretch = true;
			this.toolStripNavigation.TabIndex = 2;
			this.toolStripNavigation.Text = "Navigation";
			this.toolStripNavigation.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripNavigation.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.toolStripNavigation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripNavigation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonLoadRandomMinorPlanet
			// 
			this.toolStripButtonLoadRandomMinorPlanet.AccessibleDescription = "Loads a random minor planet";
			this.toolStripButtonLoadRandomMinorPlanet.AccessibleName = "Random minor planet";
			this.toolStripButtonLoadRandomMinorPlanet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonLoadRandomMinorPlanet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonLoadRandomMinorPlanet.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_refresh;
			this.toolStripButtonLoadRandomMinorPlanet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonLoadRandomMinorPlanet.Name = "toolStripButtonLoadRandomMinorPlanet";
			this.toolStripButtonLoadRandomMinorPlanet.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonLoadRandomMinorPlanet.Text = "Random minor planet";
			this.toolStripButtonLoadRandomMinorPlanet.Click += new System.EventHandler(this.ToolStripButtonLoadRandomMinorPlanet_Click);
			this.toolStripButtonLoadRandomMinorPlanet.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonLoadRandomMinorPlanet.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.AccessibleDescription = "Just a separator";
			this.toolStripSeparator8.AccessibleName = "Just a separator";
			this.toolStripSeparator8.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator8.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator8.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonStepToBegin
			// 
			this.toolStripButtonStepToBegin.AccessibleDescription = "Navigates to the begin of the data";
			this.toolStripButtonStepToBegin.AccessibleName = "Begin of the data";
			this.toolStripButtonStepToBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonStepToBegin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepToBegin.Image = global::Planetoid_DB.Properties.Resources.silk_backward_end_green;
			this.toolStripButtonStepToBegin.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStepToBegin.Name = "toolStripButtonStepToBegin";
			this.toolStripButtonStepToBegin.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonStepToBegin.Text = "Begin of the data";
			this.toolStripButtonStepToBegin.Click += new System.EventHandler(this.ToolStripButtonStepToBegin_Click);
			this.toolStripButtonStepToBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonStepToBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonStepBackwardOne
			// 
			this.toolStripButtonStepBackwardOne.AccessibleDescription = "Navigates to the previous data";
			this.toolStripButtonStepBackwardOne.AccessibleName = "Navigate to the previous data";
			this.toolStripButtonStepBackwardOne.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonStepBackwardOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepBackwardOne.Image = global::Planetoid_DB.Properties.Resources.silk_backward_1_green;
			this.toolStripButtonStepBackwardOne.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStepBackwardOne.Name = "toolStripButtonStepBackwardOne";
			this.toolStripButtonStepBackwardOne.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonStepBackwardOne.Text = "Navigate to the previous data";
			this.toolStripButtonStepBackwardOne.Click += new System.EventHandler(this.ToolStripButtonStepBackwardOne_Click);
			this.toolStripButtonStepBackwardOne.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonStepBackwardOne.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonStepForwardOne
			// 
			this.toolStripButtonStepForwardOne.AccessibleDescription = "Navigates to the next data";
			this.toolStripButtonStepForwardOne.AccessibleName = "Navigate to the next data";
			this.toolStripButtonStepForwardOne.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonStepForwardOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepForwardOne.Image = global::Planetoid_DB.Properties.Resources.silk_forward_1_green;
			this.toolStripButtonStepForwardOne.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStepForwardOne.Name = "toolStripButtonStepForwardOne";
			this.toolStripButtonStepForwardOne.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonStepForwardOne.Text = "Navigate to the next data";
			this.toolStripButtonStepForwardOne.Click += new System.EventHandler(this.ToolStripButtonStepForwardOne_Click);
			this.toolStripButtonStepForwardOne.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonStepForwardOne.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonStepToEnd
			// 
			this.toolStripButtonStepToEnd.AccessibleDescription = "Navigates to the end of the data";
			this.toolStripButtonStepToEnd.AccessibleName = "End of the data";
			this.toolStripButtonStepToEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonStepToEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepToEnd.Image = global::Planetoid_DB.Properties.Resources.silk_forward_end_green;
			this.toolStripButtonStepToEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStepToEnd.Name = "toolStripButtonStepToEnd";
			this.toolStripButtonStepToEnd.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonStepToEnd.Text = "End of the data";
			this.toolStripButtonStepToEnd.Click += new System.EventHandler(this.ToolStripButtonStepToEnd_Click);
			this.toolStripButtonStepToEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonStepToEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.AccessibleDescription = "Just a separator";
			this.toolStripSeparator6.AccessibleName = "Just a separator";
			this.toolStripSeparator6.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator6.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator6.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripLabelGoToIndex
			// 
			this.toolStripLabelGoToIndex.AccessibleDescription = "Go to index";
			this.toolStripLabelGoToIndex.AccessibleName = "Index";
			this.toolStripLabelGoToIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripLabelGoToIndex.AutoToolTip = true;
			this.toolStripLabelGoToIndex.Name = "toolStripLabelGoToIndex";
			this.toolStripLabelGoToIndex.Size = new System.Drawing.Size(71, 22);
			this.toolStripLabelGoToIndex.Text = "Go to index:";
			this.toolStripLabelGoToIndex.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripLabelGoToIndex.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripTextBoxGotoIndex
			// 
			this.toolStripTextBoxGotoIndex.AcceptsReturn = true;
			this.toolStripTextBoxGotoIndex.AccessibleDescription = "Enter the index number of the planetoid";
			this.toolStripTextBoxGotoIndex.AccessibleName = "Index field";
			this.toolStripTextBoxGotoIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.toolStripTextBoxGotoIndex.AutoToolTip = true;
			this.toolStripTextBoxGotoIndex.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBoxGotoIndex.Name = "toolStripTextBoxGotoIndex";
			this.toolStripTextBoxGotoIndex.Size = new System.Drawing.Size(80, 25);
			this.toolStripTextBoxGotoIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolStripTextBoxGotoIndex.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripTextBoxGotoIndex.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.toolStripTextBoxGotoIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripTextBoxGotoIndex_KeyPress);
			this.toolStripTextBoxGotoIndex.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripTextBoxGotoIndex.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonGoToIndex
			// 
			this.toolStripButtonGoToIndex.AccessibleDescription = "Click to show the data of the planetoid";
			this.toolStripButtonGoToIndex.AccessibleName = "Go to index";
			this.toolStripButtonGoToIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonGoToIndex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonGoToIndex.Image = global::Planetoid_DB.Properties.Resources.silk_go;
			this.toolStripButtonGoToIndex.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonGoToIndex.Name = "toolStripButtonGoToIndex";
			this.toolStripButtonGoToIndex.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonGoToIndex.Text = "Go to index";
			this.toolStripButtonGoToIndex.Click += new System.EventHandler(this.ToolStripButtonGoToIndex_Click);
			this.toolStripButtonGoToIndex.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonGoToIndex.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.AccessibleDescription = "Just a separator";
			this.toolStripSeparator7.AccessibleName = "Just a separator";
			this.toolStripSeparator7.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator7.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator7.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripLabelIndexPosition
			// 
			this.toolStripLabelIndexPosition.AccessibleDescription = "Shows the current index position";
			this.toolStripLabelIndexPosition.AccessibleName = "Index info";
			this.toolStripLabelIndexPosition.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripLabelIndexPosition.AutoToolTip = true;
			this.toolStripLabelIndexPosition.Name = "toolStripLabelIndexPosition";
			this.toolStripLabelIndexPosition.Size = new System.Drawing.Size(125, 22);
			this.toolStripLabelIndexPosition.Text = "index: 123456 / 999999";
			this.toolStripLabelIndexPosition.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripLabelIndexPosition.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.AccessibleDescription = "Just a separator";
			this.toolStripSeparator9.AccessibleName = "Just a separator";
			this.toolStripSeparator9.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator9.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator9.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonDerivatedOrbitElements
			// 
			this.toolStripButtonDerivatedOrbitElements.AccessibleDescription = "Calculates derivated orbital elements";
			this.toolStripButtonDerivatedOrbitElements.AccessibleName = "Derivated orbit elements";
			this.toolStripButtonDerivatedOrbitElements.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonDerivatedOrbitElements.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDerivatedOrbitElements.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_branch;
			this.toolStripButtonDerivatedOrbitElements.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDerivatedOrbitElements.Name = "toolStripButtonDerivatedOrbitElements";
			this.toolStripButtonDerivatedOrbitElements.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDerivatedOrbitElements.Text = "Derivated orbit elements";
			this.toolStripButtonDerivatedOrbitElements.Click += new System.EventHandler(this.ToolStripButtonDerivatedOrbitElements_Click);
			this.toolStripButtonDerivatedOrbitElements.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonDerivatedOrbitElements.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonFilter
			// 
			this.toolStripButtonFilter.AccessibleDescription = "Filters the orbital elements in some ranges";
			this.toolStripButtonFilter.AccessibleName = "Filter";
			this.toolStripButtonFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFilter.Enabled = false;
			this.toolStripButtonFilter.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_divide;
			this.toolStripButtonFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonFilter.Name = "toolStripButtonFilter";
			this.toolStripButtonFilter.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFilter.Text = "Filter";
			this.toolStripButtonFilter.Click += new System.EventHandler(this.ToolStripButtonFilter_Click);
			this.toolStripButtonFilter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonFilter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorOptions2
			// 
			this.toolStripSeparatorOptions2.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorOptions2.AccessibleName = "Just a separator";
			this.toolStripSeparatorOptions2.Name = "toolStripSeparatorOptions2";
			this.toolStripSeparatorOptions2.Size = new System.Drawing.Size(6, 6);
			// 
			// toolStripSeparatorOptions1
			// 
			this.toolStripSeparatorOptions1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorOptions1.AccessibleName = "Just a separator";
			this.toolStripSeparatorOptions1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorOptions1.Name = "toolStripSeparatorOptions1";
			this.toolStripSeparatorOptions1.Size = new System.Drawing.Size(6, 6);
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
			// timerCheckForNewMpcorbDatFile
			// 
			this.timerCheckForNewMpcorbDatFile.Enabled = true;
			this.timerCheckForNewMpcorbDatFile.Interval = 1440000;
			this.timerCheckForNewMpcorbDatFile.Tick += new System.EventHandler(this.TimerCheckForNewMpcorbDatFile_Tick);
			// 
			// PlanetoidDBForm
			// 
			this.AccessibleDescription = "Viewer for the MPC Orbit (MPCORB) Database";
			this.AccessibleName = "Planetoid-DB";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AllowButtonSpecToolTips = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(804, 386);
			this.Controls.Add(this.toolStripContainer);
			this.CornerRoundingRadius = 5F;
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.MaximizeBox = false;
			this.Name = "PlanetoidDBForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.StateCommon.Border.Rounding = 5F;
			this.Text = "Planetoid-DB";
			this.TextExtra = "x.x.x.x";
			this.toolTip.SetToolTip(this, "Planetoid-DB");
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanetoidDBForm_FormClosing);
			this.Load += new System.EventHandler(this.PlanetoidDBForm_Load);
			this.Shown += new System.EventHandler(this.PlanetoidDBForm_Shown);
			this.contextMenuNavigationStep.ResumeLayout(false);
			this.tableLayoutPanelData.ResumeLayout(false);
			this.tableLayoutPanelData.PerformLayout();
			this.contextMenuTopTenRecords.ResumeLayout(false);
			this.contextMenuDistributions.ResumeLayout(false);
			this.contextMenuCopyToClipboardOrbitalElements.ResumeLayout(false);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.toolStripIcons.ResumeLayout(false);
			this.toolStripIcons.PerformLayout();
			this.toolStripNavigation.ResumeLayout(false);
			this.toolStripNavigation.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ToolTip toolTip;
    private KryptonStatusStrip statusBar;
    private System.Windows.Forms.ContextMenuStrip contextMenuNavigationStep;
    private System.Windows.Forms.ToolStripMenuItem menuitemNavigateStep10;
    private System.Windows.Forms.ToolStripMenuItem menuitemNavigateStep100;
    private System.Windows.Forms.ToolStripMenuItem menuitemNavigateStep1000;
    private System.Windows.Forms.ToolStripMenuItem menuitemNavigateStep10000;
    private System.Windows.Forms.ToolStripMenuItem menuitemNavigateStep100000;
    private System.Windows.Forms.MenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem menuitemFile;
    private System.Windows.Forms.ToolStripMenuItem menuitemExit;
    private System.Windows.Forms.ToolStripMenuItem menuitemHelp;
    private System.Windows.Forms.ToolStripMenuItem menuitemAbout;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMisc1;
    private System.Windows.Forms.ToolStripMenuItem menuitemOpenWebsitePDB;
    private System.Windows.Forms.ToolStripMenuItem menuitemOpenWebsiteMPC;
    private System.Windows.Forms.ToolStripMenuItem menuitemOpenMPCORBWebsite;
    private System.Windows.Forms.ToolStripMenuItem menuitemOptions;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarBackgroundDownload;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBackgroundDownload;
    private System.ComponentModel.BackgroundWorker backgroundWorkerLoadingDatabase;
    private System.Windows.Forms.ToolStripStatusLabel labelInformation;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUpdate;
    private System.Windows.Forms.Timer timerBlinkForUpdateAvailable;
    private System.Windows.Forms.ToolStrip toolStripIcons;
    private System.Windows.Forms.ToolStripButton toolStripButtonCheckMpcorbDat;
    private System.Windows.Forms.ToolStripButton toolStripButtonDownloadMpcorbDat;
    private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton toolStripButtonOpenWebsitePDB;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripLabel toolStripLabelQuickSearch;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
    private System.Windows.Forms.ToolStripButton toolStripButtonTableMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton toolStripButtonDatabaseInformation;
    private System.Windows.Forms.ToolStripSplitButton splitbuttonDistribution;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStrip toolStripNavigation;
    private System.Windows.Forms.ToolStripButton toolStripButtonStepToBegin;
    private System.Windows.Forms.ToolStripButton toolStripButtonStepBackwardOne;
    private System.Windows.Forms.ToolStripButton toolStripButtonStepForwardOne;
    private System.Windows.Forms.ToolStripButton toolStripButtonStepToEnd;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripLabel toolStripLabelIndexPosition;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripLabel toolStripLabelGoToIndex;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGotoIndex;
    private System.Windows.Forms.ToolStripButton toolStripButtonGoToIndex;
    private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
    private System.Windows.Forms.ToolStripMenuItem menuitemEdit;
    private System.Windows.Forms.ToolStripMenuItem menuitemCopytoClipboard;
    private System.Windows.Forms.ToolStripMenuItem menuitemSearch;
    private System.Windows.Forms.ToolStripMenuItem menuitemPrint;
    private System.Windows.Forms.ToolStripMenuItem menuitemTableMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions1;
    private System.Windows.Forms.ToolStripMenuItem menuitemDistribution;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions2;
    private System.Windows.Forms.ToolStripContainer toolStripContainer;
    private System.Windows.Forms.ToolStripMenuItem menuitemStyle;
    private System.Windows.Forms.Timer timerCheckForNewMpcorbDatFile;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCancelBackgroundDownload;
		private System.Windows.Forms.ToolStripMenuItem menuitemTerminology;
		private System.Windows.Forms.ToolStripButton toolStripButtonTerminology;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStepBackward;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStepForward;
		private System.Windows.Forms.ToolStripButton toolStripButtonLoadRandomMinorPlanet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem menuitemNavigation;
		private System.Windows.Forms.ToolStripMenuItem menuitemRandomMinorPlanet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorNavigation1;
		private System.Windows.Forms.ToolStripMenuItem menuitemNavigateToTheBeginning;
		private System.Windows.Forms.ToolStripMenuItem menuitemNavigateSomeDataBackward;
		private System.Windows.Forms.ToolStripMenuItem menuitemNavigateToThePreviousData;
		private System.Windows.Forms.ToolStripMenuItem menuitemNavigateToTheNextData;
		private System.Windows.Forms.ToolStripMenuItem menuitemNavigateSomeDataForward;
		private System.Windows.Forms.ToolStripMenuItem menuitemNavigateToTheEnd;
		private System.Windows.Forms.ToolStripMenuItem menuitemTools;
		private System.Windows.Forms.ToolStripMenuItem menuitemDatabaseInformation;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools1;
		private System.Windows.Forms.ToolStripMenuItem menuitemSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile1;
		private System.Windows.Forms.ToolStripMenuItem menuitemRestart;
		private System.Windows.Forms.ToolStripMenuItem menuitemDerivatedOrbitElements;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton toolStripButtonDerivatedOrbitElements;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportDataEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem menuitemRecords;
        private System.Windows.Forms.ToolStripMenuItem menuitemIconsetSilk;
        private System.Windows.Forms.ToolStripMenuItem menuitemIconsetFatcow;
        private System.Windows.Forms.ToolStripMenuItem menuitemIconsetFugue;
        private System.Windows.Forms.ToolStripMenuItem menuitemOpenALocalMpcorbdatFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSplitButton splitbuttonTopTenRecords;
        private System.Windows.Forms.ToolStripMenuItem menuitemOptionStayOnTop;
        private System.Windows.Forms.ToolStripMenuItem menuitemOptionEnabledCopyingByDoubleClicking;
        private System.Windows.Forms.ToolStripMenuItem menuitemOptionEnableLinkingToTerminology;
        private System.Windows.Forms.ToolStripMenuItem menuitemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuitemCheckMpcorbDat;
        private System.Windows.Forms.ToolStripMenuItem menuitemDownloadMpcorbDat;
        private System.Windows.Forms.ToolStripMenuItem menuitemFilter;
        private KryptonTableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripSplitButton splitbuttonCopyToClipboard;
		private KryptonLabel labelIndexData;
		private KryptonLabel labelReadableDesignationData;
		private KryptonLabel labelEpochData;
		private KryptonLabel labelMeanAnomalyAtTheEpochData;
		private KryptonLabel labelArgumentOfPerihelionData;
		private KryptonLabel labelLongitudeOfTheAscendingNodeData;
		private KryptonLabel labelInclinationToTheEclipticData;
		private KryptonLabel labelOrbitalEccentricityData;
		private KryptonLabel labelMeanDailyMotionData;
		private KryptonLabel labelSemiMajorAxisData;
		private KryptonLabel labelAbsoluteMagnitudeData;
		private KryptonLabel labelSlopeParameterData;
		private KryptonLabel labelReferenceData;
		private KryptonLabel labelNumberOfOppositionsData;
		private KryptonLabel labelNumberOfObservationsData;
		private KryptonLabel labelObservationSpanData;
		private KryptonLabel labelRmsResidualData;
		private KryptonLabel labelComputerNameData;
		private KryptonLabel labelFlagsData;
		private KryptonLabel labelDateLastObservationData;
		private KryptonLabel labelIndexDesc;
		private KryptonLabel labelReadableDesignationDesc;
		private KryptonLabel labelEpochDesc;
		private KryptonLabel labelMeanAnomalyAtTheEpochDesc;
		private KryptonLabel labelArgumentOfPerihelionDesc;
		private KryptonLabel labelLongitudeOfTheAscendingNodeDesc;
		private KryptonLabel labelInclinationToTheEclipticDesc;
		private KryptonLabel labelOrbitalEccentricityDesc;
		private KryptonLabel labelMeanDailyMotionDesc;
		private KryptonLabel labelSemiMajorAxisDesc;
		private KryptonLabel labelAbsoluteMagnitudeDesc;
		private KryptonLabel labelSlopeParameterDesc;
		private KryptonLabel labelReferenceDesc;
		private KryptonLabel labelNumberOfOppositionsDesc;
		private KryptonLabel labelNumberOfObservationsDesc;
		private KryptonLabel labelObservationSpanDesc;
		private KryptonLabel labelRmsResidualDesc;
		private KryptonLabel labelComputerNameDesc;
		private KryptonLabel labelFlagsDesc;
		private KryptonLabel labelDateLastObservationDesc;
		private System.Windows.Forms.ToolStripSplitButton splitbuttonSearch;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchIndex;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchReadableDesignation;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchEpoch;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchMeanAnomalyAtTheEpoch;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchArgumentOfPerihelion;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchLongitudeOfTheAscendingNode;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchInclination;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchOrbitalEccentricity;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchMeanDailyMotion;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchSemiMajorAxis;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchAbsoluteMagnitude;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchSlopeParameter;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchReference;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchNumberOfOppositions;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchNumberOfObservations;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchObservationSpan;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchRmsResidual;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchComputerName;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchFlags;
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchDateOfTheLastObservation;
		private System.Windows.Forms.ContextMenuStrip contextMenuTopTenRecords;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsSortDirection;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsSortDirectionAscending;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsSortDirectionDescending;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsMeanAnomalyAtTheEpoch;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsArgumentOfPerihelion;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsLongitudeOfTheAscendingNode;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsInclination;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsOrbitalEccentricity;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsMeanDailyMotion;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsSemiMajorAxis;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsAbsoluteMagnitude;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsSlopeParameter;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsNumberOfOppositions;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsNumberOfObservations;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsObservationSpan;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsRmsResidual;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsComputername;
		private System.Windows.Forms.ToolStripMenuItem menuitemRecordsDateOfTheLastObservation;
		private System.Windows.Forms.ContextMenuStrip contextMenuDistributions;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionMeanAnomalyAtTheEpoch;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionArgumentOfPerihelion;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionLongitudeOfTheAscendingNode;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionInclination;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionOrbitalEccentricity;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionMeanDailyMotion;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionSemiMajorAxis;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionAbsoluteMagnitude;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionSlopeParameter;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionNumberOfOppositions;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionNumberOfObservations;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionObservationSpan;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionRmsResidual;
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionComputerName;
		private System.Windows.Forms.ToolStripButton toolStripButtonExport;
		private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
		private System.Windows.Forms.ContextMenuStrip contextMenuCopyToClipboardOrbitalElements;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardIndexNumber;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardReadableDesignation;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardEpoch;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardMeanAnomalyAtTheEpoch;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardArgumentOfPerihelion;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardLongitudeOfTheAscendingNode;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardInclinationToTheEcliptic;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardOrbitalEccentricity;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardMeanDailyMotion;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardSemiMajorAxis;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardAbsoluteMagnitude;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardSlopeParameter;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardReference;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardNumberOfOppositions;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardNumberOfObservations;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardObservationSpan;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardRmsResidual;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardComputerName;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardDateOfTheLastObservation;
		private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardFlags;
	}
}

