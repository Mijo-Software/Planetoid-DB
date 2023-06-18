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
			this.kryptonLabelIndexData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelDesignationNameData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelEpochData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelMeanAnomalyData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelArgumentPerihelionData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelLongitudeAscendingNodeData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelInclinationData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelOrbitalEccentricityData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelMeanDailyMotionData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelSemiMajorAxisData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelAbsoluteMagnitudeData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelSlopeParameterData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelReferenceData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelNumberOppositionsData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelNumberObservationsData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelObservationSpanData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelRmsResidualData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelComputerNameData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelFlagsData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelDateLastObservationData = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelIndexDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelDesignationNameDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelEpochDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelMeanAnomalyDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelArgumentPerihelionDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelLongitudeAscendingNodeDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelInclinationDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelOrbitalEccentricityDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelMeanDailyMotionDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelSemiMajorAxisDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelAbsoluteMagnitudeDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelSlopeParameterDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelReferenceDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelNumberOppositionsDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelNumberObservationsDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelObservationSpanDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelRmsResidualDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelComputerNameDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelFlagsDesc = new Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelDateLastObservationDesc = new Krypton.Toolkit.KryptonLabel();
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
			this.menuitemDistributionDateOfTheLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemDistribution = new System.Windows.Forms.ToolStripMenuItem();
			this.splitbuttonTopTenRecords = new System.Windows.Forms.ToolStripSplitButton();
			this.splitbuttonDistribution = new System.Windows.Forms.ToolStripSplitButton();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelUpdate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBarBackgroundDownload = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelCancelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.menuitemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOpenALocalMpcorbdatFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemExportDataEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExportDataEntryAsTxt = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExportDataEntryAsHtml = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExportDataEntryAsXml = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExportDataEntryAsJson = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuitemRestart = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopytoClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardIndexNumber = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardReadableDesignation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardMeanAnomaly = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardInclination = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardSemimajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardSlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardReference = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardComputername = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardDateOfLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyToClipboardFlags = new System.Windows.Forms.ToolStripMenuItem();
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
			this.menuitemTopTenRecords = new System.Windows.Forms.ToolStripMenuItem();
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
			this.toolStripSeparatorOptions2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparatorOptions1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripIcons = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
			this.splitbuttonExport = new System.Windows.Forms.ToolStripSplitButton();
			this.menuitemExportAsTxt = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExportAsHtml = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExportAsXml = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExportAsJson = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.splitbuttonCopyToClipboard = new System.Windows.Forms.ToolStripSplitButton();
			this.menuitemCopyIndexNumber = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyReadableDesignation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyMeanAnomalyAtTheEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyInclination = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopySemiMajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopySlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyReference = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyComputerName = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyDateOfLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCopyFlags = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonDatabaseInformation = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTableMode = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTerminology = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
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
			this.menuitemSearchNumberOfObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchComputerName = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchDateOfTheLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemSearchFlags = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundWorkerLoadingDatabase = new System.ComponentModel.BackgroundWorker();
			this.timerBlinkForUpdateAvailable = new System.Windows.Forms.Timer(this.components);
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
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.timerCheckForNewMpcorbDatFile = new System.Windows.Forms.Timer(this.components);
			this.contextMenuNavigationStep.SuspendLayout();
			this.tableLayoutPanelData.SuspendLayout();
			this.contextMenuTopTenRecords.SuspendLayout();
			this.contextMenuDistributions.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.menu.SuspendLayout();
			this.toolStripIcons.SuspendLayout();
			this.toolStripNavigation.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuNavigationStep
			// 
			this.contextMenuNavigationStep.AccessibleDescription = "Show the context menu of data items";
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
			this.menuitemNavigateStep10.AccessibleDescription = "Jump 10 items backward/forward";
			this.menuitemNavigateStep10.AccessibleName = "Jump 10 items backward/forward";
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
			this.menuitemNavigateStep100.AccessibleDescription = "Jump 100 items backward/forward";
			this.menuitemNavigateStep100.AccessibleName = "Jump 100 items backward/forward";
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
			this.menuitemNavigateStep1000.AccessibleDescription = "Jump 1000 items backward/forward";
			this.menuitemNavigateStep1000.AccessibleName = "Jump 1000 items backward/forward";
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
			this.menuitemNavigateStep10000.AccessibleDescription = "Jump 10000 items backward/forward";
			this.menuitemNavigateStep10000.AccessibleName = "Jump 10000 items backward/forward";
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
			this.menuitemNavigateStep100000.AccessibleDescription = "Jump 100000 items backward/forward";
			this.menuitemNavigateStep100000.AccessibleName = "Jump 100000 items backward/forward";
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
			this.menuitemNavigateSomeDataBackward.AccessibleDescription = "Navigate some data backward";
			this.menuitemNavigateSomeDataBackward.AccessibleName = "Navigate some data backward";
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
			this.menuitemNavigateSomeDataForward.AccessibleDescription = "Navigate some data forward";
			this.menuitemNavigateSomeDataForward.AccessibleName = "Navigate some data forward";
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
			this.toolStripSplitButtonStepForward.AccessibleDescription = "Navigate some data forward";
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
			this.toolStripSplitButtonStepBackward.AccessibleDescription = "Navigate some data backward";
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
			this.tableLayoutPanelData.AccessibleDescription = "Group the data";
			this.tableLayoutPanelData.AccessibleName = "Table Panel";
			this.tableLayoutPanelData.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanelData.BackgroundImage")));
			this.tableLayoutPanelData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanelData.ColumnCount = 4;
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelIndexData, 1, 0);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelDesignationNameData, 1, 1);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelEpochData, 1, 2);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelMeanAnomalyData, 1, 3);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelArgumentPerihelionData, 1, 4);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelLongitudeAscendingNodeData, 1, 5);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelInclinationData, 1, 6);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelOrbitalEccentricityData, 1, 7);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelMeanDailyMotionData, 1, 8);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelSemiMajorAxisData, 1, 9);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelAbsoluteMagnitudeData, 1, 10);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelSlopeParameterData, 3, 1);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelReferenceData, 3, 2);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelNumberOppositionsData, 3, 3);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelNumberObservationsData, 3, 4);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelObservationSpanData, 3, 5);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelRmsResidualData, 3, 6);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelComputerNameData, 3, 7);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelFlagsData, 3, 8);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelDateLastObservationData, 3, 9);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelIndexDesc, 0, 0);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelDesignationNameDesc, 0, 1);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelEpochDesc, 0, 2);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelMeanAnomalyDesc, 0, 3);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelArgumentPerihelionDesc, 0, 4);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelLongitudeAscendingNodeDesc, 0, 5);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelInclinationDesc, 0, 6);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelOrbitalEccentricityDesc, 0, 7);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelMeanDailyMotionDesc, 0, 8);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelSemiMajorAxisDesc, 0, 9);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelAbsoluteMagnitudeDesc, 0, 10);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelSlopeParameterDesc, 2, 1);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelReferenceDesc, 2, 2);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelNumberOppositionsDesc, 2, 3);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelNumberObservationsDesc, 2, 4);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelObservationSpanDesc, 2, 5);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelRmsResidualDesc, 2, 6);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelComputerNameDesc, 2, 7);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelFlagsDesc, 2, 8);
			this.tableLayoutPanelData.Controls.Add(this.kryptonLabelDateLastObservationDesc, 2, 9);
			this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelData.Location = new System.Drawing.Point(0, 0);
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
			this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanelData.Size = new System.Drawing.Size(804, 290);
			this.tableLayoutPanelData.TabIndex = 0;
			this.tableLayoutPanelData.TabStop = true;
			this.tableLayoutPanelData.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tableLayoutPanelData_Scroll);
			this.tableLayoutPanelData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.tableLayoutPanelData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.tableLayoutPanelData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.tableLayoutPanelData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelIndexData
			// 
			this.kryptonLabelIndexData.AccessibleDescription = "Show the information of \"Index No.\"";
			this.kryptonLabelIndexData.AccessibleName = "Show the information of \"Index No.\"";
			this.kryptonLabelIndexData.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonLabelIndexData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelIndexData.Location = new System.Drawing.Point(273, 3);
			this.kryptonLabelIndexData.Name = "kryptonLabelIndexData";
			this.kryptonLabelIndexData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelIndexData.TabIndex = 1;
			this.toolTip.SetToolTip(this.kryptonLabelIndexData, "Show the information of \"Index No.\"");
			this.kryptonLabelIndexData.Values.Text = "..................";
			this.kryptonLabelIndexData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelIndexData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelIndexData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelIndexData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelIndexData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelDesignationNameData
			// 
			this.kryptonLabelDesignationNameData.AccessibleDescription = "Show the information of \"Readable designation\"";
			this.kryptonLabelDesignationNameData.AccessibleName = "Show the information of \"Readable designation\"";
			this.kryptonLabelDesignationNameData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelDesignationNameData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelDesignationNameData.Location = new System.Drawing.Point(273, 29);
			this.kryptonLabelDesignationNameData.Name = "kryptonLabelDesignationNameData";
			this.kryptonLabelDesignationNameData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelDesignationNameData.TabIndex = 3;
			this.toolTip.SetToolTip(this.kryptonLabelDesignationNameData, "Show the information of \"Readable designation\"");
			this.kryptonLabelDesignationNameData.Values.Text = "..................";
			this.kryptonLabelDesignationNameData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelDesignationNameData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDesignationNameData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelDesignationNameData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDesignationNameData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelEpochData
			// 
			this.kryptonLabelEpochData.AccessibleDescription = "Show the information of \"Epoch (in packed form, .0 TT)\"";
			this.kryptonLabelEpochData.AccessibleName = "Show the information of \"Epoch (in packed form, .0 TT)\"";
			this.kryptonLabelEpochData.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonLabelEpochData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelEpochData.Location = new System.Drawing.Point(273, 55);
			this.kryptonLabelEpochData.Name = "kryptonLabelEpochData";
			this.kryptonLabelEpochData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelEpochData.TabIndex = 5;
			this.toolTip.SetToolTip(this.kryptonLabelEpochData, "Show the information of \"Epoch (in packed form, .0 TT)\"");
			this.kryptonLabelEpochData.Values.Text = "..................";
			this.kryptonLabelEpochData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelEpochData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelEpochData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelEpochData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelEpochData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelMeanAnomalyData
			// 
			this.kryptonLabelMeanAnomalyData.AccessibleDescription = "Show the information of \"Mean anomaly at the epoch, in degrees\"";
			this.kryptonLabelMeanAnomalyData.AccessibleName = "Show the information of \"Mean anomaly at the epoch, in degrees\"";
			this.kryptonLabelMeanAnomalyData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelMeanAnomalyData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelMeanAnomalyData.Location = new System.Drawing.Point(273, 81);
			this.kryptonLabelMeanAnomalyData.Name = "kryptonLabelMeanAnomalyData";
			this.kryptonLabelMeanAnomalyData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelMeanAnomalyData.TabIndex = 7;
			this.toolTip.SetToolTip(this.kryptonLabelMeanAnomalyData, "Show the information of \"Mean anomaly at the epoch, in degrees\"");
			this.kryptonLabelMeanAnomalyData.Values.Text = "..................";
			this.kryptonLabelMeanAnomalyData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelMeanAnomalyData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanAnomalyData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelMeanAnomalyData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanAnomalyData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelArgumentPerihelionData
			// 
			this.kryptonLabelArgumentPerihelionData.AccessibleDescription = "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.kryptonLabelArgumentPerihelionData.AccessibleName = "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.kryptonLabelArgumentPerihelionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelArgumentPerihelionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelArgumentPerihelionData.Location = new System.Drawing.Point(273, 107);
			this.kryptonLabelArgumentPerihelionData.Name = "kryptonLabelArgumentPerihelionData";
			this.kryptonLabelArgumentPerihelionData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelArgumentPerihelionData.TabIndex = 9;
			this.toolTip.SetToolTip(this.kryptonLabelArgumentPerihelionData, "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"");
			this.kryptonLabelArgumentPerihelionData.Values.Text = "..................";
			this.kryptonLabelArgumentPerihelionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelArgumentPerihelionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelArgumentPerihelionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelArgumentPerihelionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelArgumentPerihelionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelLongitudeAscendingNodeData
			// 
			this.kryptonLabelLongitudeAscendingNodeData.AccessibleDescription = "Show the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			this.kryptonLabelLongitudeAscendingNodeData.AccessibleName = "Show the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			this.kryptonLabelLongitudeAscendingNodeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelLongitudeAscendingNodeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelLongitudeAscendingNodeData.Location = new System.Drawing.Point(273, 133);
			this.kryptonLabelLongitudeAscendingNodeData.Name = "kryptonLabelLongitudeAscendingNodeData";
			this.kryptonLabelLongitudeAscendingNodeData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelLongitudeAscendingNodeData.TabIndex = 11;
			this.toolTip.SetToolTip(this.kryptonLabelLongitudeAscendingNodeData, "Show the information of \"Longitude of the ascending node, J2000.0 (degrees)\"");
			this.kryptonLabelLongitudeAscendingNodeData.Values.Text = "..................";
			// 
			// kryptonLabelInclinationData
			// 
			this.kryptonLabelInclinationData.AccessibleDescription = "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.kryptonLabelInclinationData.AccessibleName = "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.kryptonLabelInclinationData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelInclinationData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelInclinationData.Location = new System.Drawing.Point(273, 159);
			this.kryptonLabelInclinationData.Name = "kryptonLabelInclinationData";
			this.kryptonLabelInclinationData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelInclinationData.TabIndex = 13;
			this.toolTip.SetToolTip(this.kryptonLabelInclinationData, "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"");
			this.kryptonLabelInclinationData.Values.Text = "..................";
			this.kryptonLabelInclinationData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelInclinationData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelInclinationData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelInclinationData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelInclinationData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelOrbitalEccentricityData
			// 
			this.kryptonLabelOrbitalEccentricityData.AccessibleDescription = "Show the information of \"Orbital eccentricity\"";
			this.kryptonLabelOrbitalEccentricityData.AccessibleName = "Show the information of \"Orbital eccentricity\"";
			this.kryptonLabelOrbitalEccentricityData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelOrbitalEccentricityData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelOrbitalEccentricityData.Location = new System.Drawing.Point(273, 185);
			this.kryptonLabelOrbitalEccentricityData.Name = "kryptonLabelOrbitalEccentricityData";
			this.kryptonLabelOrbitalEccentricityData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelOrbitalEccentricityData.TabIndex = 15;
			this.toolTip.SetToolTip(this.kryptonLabelOrbitalEccentricityData, "Show the information of \"Orbital eccentricity\"");
			this.kryptonLabelOrbitalEccentricityData.Values.Text = "..................";
			this.kryptonLabelOrbitalEccentricityData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelOrbitalEccentricityData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelOrbitalEccentricityData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelOrbitalEccentricityData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelOrbitalEccentricityData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelMeanDailyMotionData
			// 
			this.kryptonLabelMeanDailyMotionData.AccessibleDescription = "Show the information of \"Mean daily motion (degrees per day)\"";
			this.kryptonLabelMeanDailyMotionData.AccessibleName = "Show the information of \"Mean daily motion (degrees per day)\"";
			this.kryptonLabelMeanDailyMotionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelMeanDailyMotionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelMeanDailyMotionData.Location = new System.Drawing.Point(273, 211);
			this.kryptonLabelMeanDailyMotionData.Name = "kryptonLabelMeanDailyMotionData";
			this.kryptonLabelMeanDailyMotionData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelMeanDailyMotionData.TabIndex = 17;
			this.toolTip.SetToolTip(this.kryptonLabelMeanDailyMotionData, "Show the information of \"Mean daily motion (degrees per day)\"");
			this.kryptonLabelMeanDailyMotionData.Values.Text = "..................";
			this.kryptonLabelMeanDailyMotionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelMeanDailyMotionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanDailyMotionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelMeanDailyMotionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanDailyMotionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelSemiMajorAxisData
			// 
			this.kryptonLabelSemiMajorAxisData.AccessibleDescription = "Show the information of \"Semi-major axis (AU)\"";
			this.kryptonLabelSemiMajorAxisData.AccessibleName = "Show the information of \"Semi-major axis (AU)\"";
			this.kryptonLabelSemiMajorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelSemiMajorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelSemiMajorAxisData.Location = new System.Drawing.Point(273, 237);
			this.kryptonLabelSemiMajorAxisData.Name = "kryptonLabelSemiMajorAxisData";
			this.kryptonLabelSemiMajorAxisData.Size = new System.Drawing.Size(143, 20);
			this.kryptonLabelSemiMajorAxisData.TabIndex = 19;
			this.toolTip.SetToolTip(this.kryptonLabelSemiMajorAxisData, "Show the information of \"Semi-major axis (AU)\"");
			this.kryptonLabelSemiMajorAxisData.Values.Text = "..................";
			this.kryptonLabelSemiMajorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelSemiMajorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSemiMajorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelSemiMajorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSemiMajorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelAbsoluteMagnitudeData
			// 
			this.kryptonLabelAbsoluteMagnitudeData.AccessibleDescription = "Show the information of \"Absolute magnitude, H\"";
			this.kryptonLabelAbsoluteMagnitudeData.AccessibleName = "Show the information of \"Absolute magnitude, H\"";
			this.kryptonLabelAbsoluteMagnitudeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelAbsoluteMagnitudeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelAbsoluteMagnitudeData.Location = new System.Drawing.Point(273, 263);
			this.kryptonLabelAbsoluteMagnitudeData.Name = "kryptonLabelAbsoluteMagnitudeData";
			this.kryptonLabelAbsoluteMagnitudeData.Size = new System.Drawing.Size(143, 24);
			this.kryptonLabelAbsoluteMagnitudeData.TabIndex = 21;
			this.toolTip.SetToolTip(this.kryptonLabelAbsoluteMagnitudeData, "Show the information of \"Absolute magnitude, H\"");
			this.kryptonLabelAbsoluteMagnitudeData.Values.Text = "..................";
			this.kryptonLabelAbsoluteMagnitudeData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelAbsoluteMagnitudeData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelAbsoluteMagnitudeData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelAbsoluteMagnitudeData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelAbsoluteMagnitudeData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelSlopeParameterData
			// 
			this.kryptonLabelSlopeParameterData.AccessibleDescription = "Show the information of \"Slope parameter, G\"";
			this.kryptonLabelSlopeParameterData.AccessibleName = "Show the information of \"Slope parameter, G\"";
			this.kryptonLabelSlopeParameterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelSlopeParameterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelSlopeParameterData.Location = new System.Drawing.Point(650, 29);
			this.kryptonLabelSlopeParameterData.Name = "kryptonLabelSlopeParameterData";
			this.kryptonLabelSlopeParameterData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelSlopeParameterData.TabIndex = 23;
			this.toolTip.SetToolTip(this.kryptonLabelSlopeParameterData, "Show the information of \"Slope parameter, G\"");
			this.kryptonLabelSlopeParameterData.Values.Text = "..................";
			this.kryptonLabelSlopeParameterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelSlopeParameterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSlopeParameterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelSlopeParameterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSlopeParameterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelReferenceData
			// 
			this.kryptonLabelReferenceData.AccessibleDescription = "Show the information of \"Reference\"";
			this.kryptonLabelReferenceData.AccessibleName = "Show the information of \"Reference\"";
			this.kryptonLabelReferenceData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelReferenceData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelReferenceData.Location = new System.Drawing.Point(650, 55);
			this.kryptonLabelReferenceData.Name = "kryptonLabelReferenceData";
			this.kryptonLabelReferenceData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelReferenceData.TabIndex = 25;
			this.toolTip.SetToolTip(this.kryptonLabelReferenceData, "Show the information of \"Reference\"");
			this.kryptonLabelReferenceData.Values.Text = "..................";
			this.kryptonLabelReferenceData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelReferenceData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelReferenceData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelReferenceData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelReferenceData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelNumberOppositionsData
			// 
			this.kryptonLabelNumberOppositionsData.AccessibleDescription = "Show the information of \"Number of oppositions\"";
			this.kryptonLabelNumberOppositionsData.AccessibleName = "Show the information of \"Number of oppositions\"";
			this.kryptonLabelNumberOppositionsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelNumberOppositionsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelNumberOppositionsData.Location = new System.Drawing.Point(650, 81);
			this.kryptonLabelNumberOppositionsData.Name = "kryptonLabelNumberOppositionsData";
			this.kryptonLabelNumberOppositionsData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelNumberOppositionsData.TabIndex = 27;
			this.toolTip.SetToolTip(this.kryptonLabelNumberOppositionsData, "Show the information of \"Number of oppositions\"");
			this.kryptonLabelNumberOppositionsData.Values.Text = "..................";
			this.kryptonLabelNumberOppositionsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelNumberOppositionsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberOppositionsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelNumberOppositionsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberOppositionsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelNumberObservationsData
			// 
			this.kryptonLabelNumberObservationsData.AccessibleDescription = "Show the information of \"Number of observations\"";
			this.kryptonLabelNumberObservationsData.AccessibleName = "Show the information of \"Number of observations\"";
			this.kryptonLabelNumberObservationsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelNumberObservationsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelNumberObservationsData.Location = new System.Drawing.Point(650, 107);
			this.kryptonLabelNumberObservationsData.Name = "kryptonLabelNumberObservationsData";
			this.kryptonLabelNumberObservationsData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelNumberObservationsData.TabIndex = 29;
			this.toolTip.SetToolTip(this.kryptonLabelNumberObservationsData, "Show the information of \"Number of observations\"");
			this.kryptonLabelNumberObservationsData.Values.Text = "..................";
			this.kryptonLabelNumberObservationsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelNumberObservationsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberObservationsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelNumberObservationsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberObservationsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelObservationSpanData
			// 
			this.kryptonLabelObservationSpanData.AccessibleDescription = "Show the information of \"Observation span\"";
			this.kryptonLabelObservationSpanData.AccessibleName = "Show the information of \"Observation span\"";
			this.kryptonLabelObservationSpanData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelObservationSpanData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelObservationSpanData.Location = new System.Drawing.Point(650, 133);
			this.kryptonLabelObservationSpanData.Name = "kryptonLabelObservationSpanData";
			this.kryptonLabelObservationSpanData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelObservationSpanData.TabIndex = 31;
			this.toolTip.SetToolTip(this.kryptonLabelObservationSpanData, "Show the information of \"Observation span\"");
			this.kryptonLabelObservationSpanData.Values.Text = "..................";
			this.kryptonLabelObservationSpanData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelObservationSpanData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelObservationSpanData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelObservationSpanData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelObservationSpanData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelRmsResidualData
			// 
			this.kryptonLabelRmsResidualData.AccessibleDescription = "Show the information of \"r.m.s residual (\")\"";
			this.kryptonLabelRmsResidualData.AccessibleName = "Show the information of \"r.m.s residual (\")\"";
			this.kryptonLabelRmsResidualData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelRmsResidualData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelRmsResidualData.Location = new System.Drawing.Point(650, 159);
			this.kryptonLabelRmsResidualData.Name = "kryptonLabelRmsResidualData";
			this.kryptonLabelRmsResidualData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelRmsResidualData.TabIndex = 33;
			this.toolTip.SetToolTip(this.kryptonLabelRmsResidualData, "Show the information of \"r.m.s residual (\")\"");
			this.kryptonLabelRmsResidualData.Values.Text = "..................";
			this.kryptonLabelRmsResidualData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelRmsResidualData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelRmsResidualData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelRmsResidualData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelRmsResidualData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelComputerNameData
			// 
			this.kryptonLabelComputerNameData.AccessibleDescription = "Show the information of \"Computer name\"";
			this.kryptonLabelComputerNameData.AccessibleName = "Show the information of \"Computer name\"";
			this.kryptonLabelComputerNameData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelComputerNameData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelComputerNameData.Location = new System.Drawing.Point(650, 185);
			this.kryptonLabelComputerNameData.Name = "kryptonLabelComputerNameData";
			this.kryptonLabelComputerNameData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelComputerNameData.TabIndex = 35;
			this.toolTip.SetToolTip(this.kryptonLabelComputerNameData, "Show the information of \"Computer name\"");
			this.kryptonLabelComputerNameData.Values.Text = "..................";
			this.kryptonLabelComputerNameData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelComputerNameData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelComputerNameData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelComputerNameData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelComputerNameData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelFlagsData
			// 
			this.kryptonLabelFlagsData.AccessibleDescription = "Show the information of \"4-hexdigit flags\"";
			this.kryptonLabelFlagsData.AccessibleName = "Show the information of \"4-hexdigit flags\"";
			this.kryptonLabelFlagsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelFlagsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelFlagsData.Location = new System.Drawing.Point(650, 211);
			this.kryptonLabelFlagsData.Name = "kryptonLabelFlagsData";
			this.kryptonLabelFlagsData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelFlagsData.TabIndex = 37;
			this.toolTip.SetToolTip(this.kryptonLabelFlagsData, "Show the information of \"4-hexdigit flags\"");
			this.kryptonLabelFlagsData.Values.Text = "..................";
			this.kryptonLabelFlagsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelFlagsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelFlagsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelFlagsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelFlagsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelDateLastObservationData
			// 
			this.kryptonLabelDateLastObservationData.AccessibleDescription = "Show the information of \"Date of last observation\"";
			this.kryptonLabelDateLastObservationData.AccessibleName = "Show the information of \"Date of last observation\"";
			this.kryptonLabelDateLastObservationData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelDateLastObservationData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelDateLastObservationData.Location = new System.Drawing.Point(650, 237);
			this.kryptonLabelDateLastObservationData.Name = "kryptonLabelDateLastObservationData";
			this.kryptonLabelDateLastObservationData.Size = new System.Drawing.Size(151, 20);
			this.kryptonLabelDateLastObservationData.TabIndex = 39;
			this.toolTip.SetToolTip(this.kryptonLabelDateLastObservationData, "Show the information of \"Date of last observation\"");
			this.kryptonLabelDateLastObservationData.Values.Text = "..................";
			this.kryptonLabelDateLastObservationData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.kryptonLabelDateLastObservationData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDateLastObservationData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelDateLastObservationData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDateLastObservationData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelIndexDesc
			// 
			this.kryptonLabelIndexDesc.AccessibleDescription = "Index No.";
			this.kryptonLabelIndexDesc.AccessibleName = "Index No.";
			this.kryptonLabelIndexDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelIndexDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelIndexDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.kryptonLabelIndexDesc.Location = new System.Drawing.Point(3, 3);
			this.kryptonLabelIndexDesc.Name = "kryptonLabelIndexDesc";
			this.kryptonLabelIndexDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelIndexDesc.TabIndex = 0;
			this.toolTip.SetToolTip(this.kryptonLabelIndexDesc, "Index No.");
			this.kryptonLabelIndexDesc.Values.Text = "Index No.";
			this.kryptonLabelIndexDesc.DoubleClick += new System.EventHandler(this.KryptonLabelIndexDesc_DoubleClick);
			this.kryptonLabelIndexDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelIndexDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelIndexDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelIndexDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelDesignationNameDesc
			// 
			this.kryptonLabelDesignationNameDesc.AccessibleDescription = "Readable designation";
			this.kryptonLabelDesignationNameDesc.AccessibleName = "Readable designation";
			this.kryptonLabelDesignationNameDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelDesignationNameDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelDesignationNameDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelDesignationNameDesc.Location = new System.Drawing.Point(3, 29);
			this.kryptonLabelDesignationNameDesc.Name = "kryptonLabelDesignationNameDesc";
			this.kryptonLabelDesignationNameDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelDesignationNameDesc.TabIndex = 2;
			this.toolTip.SetToolTip(this.kryptonLabelDesignationNameDesc, "Readable designation");
			this.kryptonLabelDesignationNameDesc.Values.Text = "Readable designation";
			this.kryptonLabelDesignationNameDesc.DoubleClick += new System.EventHandler(this.KryptonLabelDesignationNameDesc_DoubleClick);
			this.kryptonLabelDesignationNameDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDesignationNameDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelDesignationNameDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDesignationNameDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelEpochDesc
			// 
			this.kryptonLabelEpochDesc.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			this.kryptonLabelEpochDesc.AccessibleName = "Epoch (in packed form, .0 TT)";
			this.kryptonLabelEpochDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelEpochDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelEpochDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelEpochDesc.Location = new System.Drawing.Point(3, 55);
			this.kryptonLabelEpochDesc.Name = "kryptonLabelEpochDesc";
			this.kryptonLabelEpochDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelEpochDesc.TabIndex = 4;
			this.toolTip.SetToolTip(this.kryptonLabelEpochDesc, "Epoch (in packed form, .0 TT)");
			this.kryptonLabelEpochDesc.Values.Text = "Epoch (in packed form, .0 TT)";
			this.kryptonLabelEpochDesc.DoubleClick += new System.EventHandler(this.KryptonLabelEpochDesc_DoubleClick);
			this.kryptonLabelEpochDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelEpochDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelEpochDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelEpochDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelMeanAnomalyDesc
			// 
			this.kryptonLabelMeanAnomalyDesc.AccessibleDescription = "Mean anomaly at the epoch (degrees)";
			this.kryptonLabelMeanAnomalyDesc.AccessibleName = "Mean anomaly at the epoch (degrees)";
			this.kryptonLabelMeanAnomalyDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelMeanAnomalyDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelMeanAnomalyDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelMeanAnomalyDesc.Location = new System.Drawing.Point(3, 81);
			this.kryptonLabelMeanAnomalyDesc.Name = "kryptonLabelMeanAnomalyDesc";
			this.kryptonLabelMeanAnomalyDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelMeanAnomalyDesc.TabIndex = 6;
			this.toolTip.SetToolTip(this.kryptonLabelMeanAnomalyDesc, "Mean anomaly at the epoch (degrees)");
			this.kryptonLabelMeanAnomalyDesc.Values.ExtraText = "°";
			this.kryptonLabelMeanAnomalyDesc.Values.Text = "Mean anomaly at the epoch";
			this.kryptonLabelMeanAnomalyDesc.DoubleClick += new System.EventHandler(this.KryptonLabelMeanAnomalyDesc_DoubleClick);
			this.kryptonLabelMeanAnomalyDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanAnomalyDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelMeanAnomalyDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanAnomalyDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelArgumentPerihelionDesc
			// 
			this.kryptonLabelArgumentPerihelionDesc.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			this.kryptonLabelArgumentPerihelionDesc.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			this.kryptonLabelArgumentPerihelionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelArgumentPerihelionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelArgumentPerihelionDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelArgumentPerihelionDesc.Location = new System.Drawing.Point(3, 107);
			this.kryptonLabelArgumentPerihelionDesc.Name = "kryptonLabelArgumentPerihelionDesc";
			this.kryptonLabelArgumentPerihelionDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelArgumentPerihelionDesc.TabIndex = 8;
			this.toolTip.SetToolTip(this.kryptonLabelArgumentPerihelionDesc, "Argument of perihelion, J2000.0 (degrees)");
			this.kryptonLabelArgumentPerihelionDesc.Values.ExtraText = "°";
			this.kryptonLabelArgumentPerihelionDesc.Values.Text = "Argument of perihelion, J2000.0";
			this.kryptonLabelArgumentPerihelionDesc.DoubleClick += new System.EventHandler(this.KryptonLabelArgumentPerihelionDesc_DoubleClick);
			this.kryptonLabelArgumentPerihelionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelArgumentPerihelionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelArgumentPerihelionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelArgumentPerihelionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelLongitudeAscendingNodeDesc
			// 
			this.kryptonLabelLongitudeAscendingNodeDesc.AccessibleDescription = "Longitude of the ascending node, J2000.0 (degrees)";
			this.kryptonLabelLongitudeAscendingNodeDesc.AccessibleName = "Longitude of the ascending node, J2000.0 (degrees)";
			this.kryptonLabelLongitudeAscendingNodeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelLongitudeAscendingNodeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelLongitudeAscendingNodeDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelLongitudeAscendingNodeDesc.Location = new System.Drawing.Point(3, 133);
			this.kryptonLabelLongitudeAscendingNodeDesc.Name = "kryptonLabelLongitudeAscendingNodeDesc";
			this.kryptonLabelLongitudeAscendingNodeDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelLongitudeAscendingNodeDesc.TabIndex = 10;
			this.toolTip.SetToolTip(this.kryptonLabelLongitudeAscendingNodeDesc, "Longitude of the ascending node, J2000.0 (degrees)");
			this.kryptonLabelLongitudeAscendingNodeDesc.Values.ExtraText = "°";
			this.kryptonLabelLongitudeAscendingNodeDesc.Values.Text = "Longitude of the ascending node, J2000.0";
			this.kryptonLabelLongitudeAscendingNodeDesc.DoubleClick += new System.EventHandler(this.KryptonLabelLongitudeAscendingNodeDesc_DoubleClick);
			this.kryptonLabelLongitudeAscendingNodeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelLongitudeAscendingNodeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelLongitudeAscendingNodeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelLongitudeAscendingNodeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelInclinationDesc
			// 
			this.kryptonLabelInclinationDesc.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.kryptonLabelInclinationDesc.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.kryptonLabelInclinationDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelInclinationDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelInclinationDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelInclinationDesc.Location = new System.Drawing.Point(3, 159);
			this.kryptonLabelInclinationDesc.Name = "kryptonLabelInclinationDesc";
			this.kryptonLabelInclinationDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelInclinationDesc.TabIndex = 12;
			this.toolTip.SetToolTip(this.kryptonLabelInclinationDesc, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.kryptonLabelInclinationDesc.Values.ExtraText = "°";
			this.kryptonLabelInclinationDesc.Values.Text = "Inclination to the ecliptic, J2000.0";
			this.kryptonLabelInclinationDesc.DoubleClick += new System.EventHandler(this.KryptonLabelInclinationDesc_DoubleClick);
			this.kryptonLabelInclinationDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelInclinationDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelInclinationDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelInclinationDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelOrbitalEccentricityDesc
			// 
			this.kryptonLabelOrbitalEccentricityDesc.AccessibleDescription = "Orbital eccentricity";
			this.kryptonLabelOrbitalEccentricityDesc.AccessibleName = "Orbital eccentricity";
			this.kryptonLabelOrbitalEccentricityDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelOrbitalEccentricityDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelOrbitalEccentricityDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelOrbitalEccentricityDesc.Location = new System.Drawing.Point(3, 185);
			this.kryptonLabelOrbitalEccentricityDesc.Name = "kryptonLabelOrbitalEccentricityDesc";
			this.kryptonLabelOrbitalEccentricityDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelOrbitalEccentricityDesc.TabIndex = 14;
			this.toolTip.SetToolTip(this.kryptonLabelOrbitalEccentricityDesc, "Orbital eccentricity");
			this.kryptonLabelOrbitalEccentricityDesc.Values.Text = "Orbital eccentricity";
			this.kryptonLabelOrbitalEccentricityDesc.DoubleClick += new System.EventHandler(this.KryptonLabelOrbitalEccentricityDesc_DoubleClick);
			this.kryptonLabelOrbitalEccentricityDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelOrbitalEccentricityDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelOrbitalEccentricityDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelOrbitalEccentricityDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelMeanDailyMotionDesc
			// 
			this.kryptonLabelMeanDailyMotionDesc.AccessibleDescription = "Mean daily motion (degrees per day)";
			this.kryptonLabelMeanDailyMotionDesc.AccessibleName = "Mean daily motion (degrees per day)";
			this.kryptonLabelMeanDailyMotionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelMeanDailyMotionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelMeanDailyMotionDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelMeanDailyMotionDesc.Location = new System.Drawing.Point(3, 211);
			this.kryptonLabelMeanDailyMotionDesc.Name = "kryptonLabelMeanDailyMotionDesc";
			this.kryptonLabelMeanDailyMotionDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelMeanDailyMotionDesc.TabIndex = 16;
			this.toolTip.SetToolTip(this.kryptonLabelMeanDailyMotionDesc, "Mean daily motion (degrees per day)");
			this.kryptonLabelMeanDailyMotionDesc.Values.ExtraText = "°/day";
			this.kryptonLabelMeanDailyMotionDesc.Values.Text = "Mean daily motion";
			this.kryptonLabelMeanDailyMotionDesc.DoubleClick += new System.EventHandler(this.KryptonLabelMeanDailyMotionDesc_DoubleClick);
			this.kryptonLabelMeanDailyMotionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanDailyMotionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelMeanDailyMotionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelMeanDailyMotionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelSemiMajorAxisDesc
			// 
			this.kryptonLabelSemiMajorAxisDesc.AccessibleDescription = "Semi-major axis (AU)";
			this.kryptonLabelSemiMajorAxisDesc.AccessibleName = "Semi-major axis (AU)";
			this.kryptonLabelSemiMajorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelSemiMajorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelSemiMajorAxisDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelSemiMajorAxisDesc.Location = new System.Drawing.Point(3, 237);
			this.kryptonLabelSemiMajorAxisDesc.Name = "kryptonLabelSemiMajorAxisDesc";
			this.kryptonLabelSemiMajorAxisDesc.Size = new System.Drawing.Size(264, 20);
			this.kryptonLabelSemiMajorAxisDesc.TabIndex = 18;
			this.toolTip.SetToolTip(this.kryptonLabelSemiMajorAxisDesc, "Semi-major axis (AU)");
			this.kryptonLabelSemiMajorAxisDesc.Values.ExtraText = "AU";
			this.kryptonLabelSemiMajorAxisDesc.Values.Text = "Semi-major axis";
			this.kryptonLabelSemiMajorAxisDesc.DoubleClick += new System.EventHandler(this.KryptonLabelSemiMajorAxisDesc_DoubleClick);
			this.kryptonLabelSemiMajorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSemiMajorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelSemiMajorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSemiMajorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelAbsoluteMagnitudeDesc
			// 
			this.kryptonLabelAbsoluteMagnitudeDesc.AccessibleDescription = "Absolute magnitude, H";
			this.kryptonLabelAbsoluteMagnitudeDesc.AccessibleName = "Absolute magnitude, H";
			this.kryptonLabelAbsoluteMagnitudeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelAbsoluteMagnitudeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelAbsoluteMagnitudeDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelAbsoluteMagnitudeDesc.Location = new System.Drawing.Point(3, 263);
			this.kryptonLabelAbsoluteMagnitudeDesc.Name = "kryptonLabelAbsoluteMagnitudeDesc";
			this.kryptonLabelAbsoluteMagnitudeDesc.Size = new System.Drawing.Size(264, 24);
			this.kryptonLabelAbsoluteMagnitudeDesc.TabIndex = 20;
			this.toolTip.SetToolTip(this.kryptonLabelAbsoluteMagnitudeDesc, "Absolute magnitude, H");
			this.kryptonLabelAbsoluteMagnitudeDesc.Values.ExtraText = "mag";
			this.kryptonLabelAbsoluteMagnitudeDesc.Values.Text = "Absolute magnitude, H";
			this.kryptonLabelAbsoluteMagnitudeDesc.DoubleClick += new System.EventHandler(this.KryptonLabelAbsoluteMagnitudeDesc_DoubleClick);
			this.kryptonLabelAbsoluteMagnitudeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelAbsoluteMagnitudeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelAbsoluteMagnitudeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelAbsoluteMagnitudeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelSlopeParameterDesc
			// 
			this.kryptonLabelSlopeParameterDesc.AccessibleDescription = "Slope parameter, G";
			this.kryptonLabelSlopeParameterDesc.AccessibleName = "Slope parameter, G";
			this.kryptonLabelSlopeParameterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelSlopeParameterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelSlopeParameterDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
			this.kryptonLabelSlopeParameterDesc.Location = new System.Drawing.Point(422, 29);
			this.kryptonLabelSlopeParameterDesc.Name = "kryptonLabelSlopeParameterDesc";
			this.kryptonLabelSlopeParameterDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelSlopeParameterDesc.TabIndex = 22;
			this.toolTip.SetToolTip(this.kryptonLabelSlopeParameterDesc, "Slope parameter, G");
			this.kryptonLabelSlopeParameterDesc.Values.Text = "Slope parameter, G";
			this.kryptonLabelSlopeParameterDesc.DoubleClick += new System.EventHandler(this.KryptonLabelSlopeParameterDesc_DoubleClick);
			this.kryptonLabelSlopeParameterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSlopeParameterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelSlopeParameterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelSlopeParameterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelReferenceDesc
			// 
			this.kryptonLabelReferenceDesc.AccessibleDescription = "Reference";
			this.kryptonLabelReferenceDesc.AccessibleName = "Reference";
			this.kryptonLabelReferenceDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelReferenceDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelReferenceDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelReferenceDesc.Location = new System.Drawing.Point(422, 55);
			this.kryptonLabelReferenceDesc.Name = "kryptonLabelReferenceDesc";
			this.kryptonLabelReferenceDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelReferenceDesc.TabIndex = 24;
			this.toolTip.SetToolTip(this.kryptonLabelReferenceDesc, "Reference");
			this.kryptonLabelReferenceDesc.Values.Text = "Reference";
			this.kryptonLabelReferenceDesc.DoubleClick += new System.EventHandler(this.KryptonLabelReferenceDesc_DoubleClick);
			this.kryptonLabelReferenceDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelReferenceDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelReferenceDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelReferenceDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelNumberOppositionsDesc
			// 
			this.kryptonLabelNumberOppositionsDesc.AccessibleDescription = "Number of oppositions";
			this.kryptonLabelNumberOppositionsDesc.AccessibleName = "Number of oppositions";
			this.kryptonLabelNumberOppositionsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelNumberOppositionsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelNumberOppositionsDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelNumberOppositionsDesc.Location = new System.Drawing.Point(422, 81);
			this.kryptonLabelNumberOppositionsDesc.Name = "kryptonLabelNumberOppositionsDesc";
			this.kryptonLabelNumberOppositionsDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelNumberOppositionsDesc.TabIndex = 26;
			this.toolTip.SetToolTip(this.kryptonLabelNumberOppositionsDesc, "Number of oppositions");
			this.kryptonLabelNumberOppositionsDesc.Values.Text = "Number of oppositions";
			this.kryptonLabelNumberOppositionsDesc.DoubleClick += new System.EventHandler(this.KryptonLabelNumberOppositionsDesc_DoubleClick);
			this.kryptonLabelNumberOppositionsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberOppositionsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelNumberOppositionsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberOppositionsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelNumberObservationsDesc
			// 
			this.kryptonLabelNumberObservationsDesc.AccessibleDescription = "Number of observations";
			this.kryptonLabelNumberObservationsDesc.AccessibleName = "Number of observations";
			this.kryptonLabelNumberObservationsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelNumberObservationsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelNumberObservationsDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelNumberObservationsDesc.Location = new System.Drawing.Point(422, 107);
			this.kryptonLabelNumberObservationsDesc.Name = "kryptonLabelNumberObservationsDesc";
			this.kryptonLabelNumberObservationsDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelNumberObservationsDesc.TabIndex = 28;
			this.toolTip.SetToolTip(this.kryptonLabelNumberObservationsDesc, "Number of observations");
			this.kryptonLabelNumberObservationsDesc.Values.Text = "Number of observations";
			this.kryptonLabelNumberObservationsDesc.DoubleClick += new System.EventHandler(this.KryptonLabelNumberObservationsDesc_DoubleClick);
			this.kryptonLabelNumberObservationsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberObservationsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelNumberObservationsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelNumberObservationsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelObservationSpanDesc
			// 
			this.kryptonLabelObservationSpanDesc.AccessibleDescription = "Observation span";
			this.kryptonLabelObservationSpanDesc.AccessibleName = "Observation span";
			this.kryptonLabelObservationSpanDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelObservationSpanDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelObservationSpanDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelObservationSpanDesc.Location = new System.Drawing.Point(422, 133);
			this.kryptonLabelObservationSpanDesc.Name = "kryptonLabelObservationSpanDesc";
			this.kryptonLabelObservationSpanDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelObservationSpanDesc.TabIndex = 30;
			this.toolTip.SetToolTip(this.kryptonLabelObservationSpanDesc, "Observation span");
			this.kryptonLabelObservationSpanDesc.Values.Text = "Observation span";
			this.kryptonLabelObservationSpanDesc.DoubleClick += new System.EventHandler(this.KryptonLabelObservationSpanDesc_DoubleClick);
			this.kryptonLabelObservationSpanDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelObservationSpanDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelObservationSpanDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelObservationSpanDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelRmsResidualDesc
			// 
			this.kryptonLabelRmsResidualDesc.AccessibleDescription = "r.m.s. residual (arcseconds)";
			this.kryptonLabelRmsResidualDesc.AccessibleName = "r.m.s. residual (arcseconds)";
			this.kryptonLabelRmsResidualDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelRmsResidualDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelRmsResidualDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelRmsResidualDesc.Location = new System.Drawing.Point(422, 159);
			this.kryptonLabelRmsResidualDesc.Name = "kryptonLabelRmsResidualDesc";
			this.kryptonLabelRmsResidualDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelRmsResidualDesc.TabIndex = 32;
			this.toolTip.SetToolTip(this.kryptonLabelRmsResidualDesc, "r.m.s. residual (arcseconds)");
			this.kryptonLabelRmsResidualDesc.Values.ExtraText = "\"";
			this.kryptonLabelRmsResidualDesc.Values.Text = "r.m.s. residual";
			this.kryptonLabelRmsResidualDesc.DoubleClick += new System.EventHandler(this.KryptonLabelRmsResidualDesc_DoubleClick);
			this.kryptonLabelRmsResidualDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelRmsResidualDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelRmsResidualDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelRmsResidualDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelComputerNameDesc
			// 
			this.kryptonLabelComputerNameDesc.AccessibleDescription = "Computer name";
			this.kryptonLabelComputerNameDesc.AccessibleName = "Computer name";
			this.kryptonLabelComputerNameDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelComputerNameDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelComputerNameDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelComputerNameDesc.Location = new System.Drawing.Point(422, 185);
			this.kryptonLabelComputerNameDesc.Name = "kryptonLabelComputerNameDesc";
			this.kryptonLabelComputerNameDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelComputerNameDesc.TabIndex = 34;
			this.toolTip.SetToolTip(this.kryptonLabelComputerNameDesc, "Computer name");
			this.kryptonLabelComputerNameDesc.Values.Text = "Computer name";
			this.kryptonLabelComputerNameDesc.DoubleClick += new System.EventHandler(this.KryptonLabelComputerNameDesc_DoubleClick);
			this.kryptonLabelComputerNameDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelComputerNameDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelComputerNameDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelComputerNameDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelFlagsDesc
			// 
			this.kryptonLabelFlagsDesc.AccessibleDescription = "4-hexdigit flags";
			this.kryptonLabelFlagsDesc.AccessibleName = "4-hexdigit flags";
			this.kryptonLabelFlagsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelFlagsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelFlagsDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelFlagsDesc.Location = new System.Drawing.Point(422, 211);
			this.kryptonLabelFlagsDesc.Name = "kryptonLabelFlagsDesc";
			this.kryptonLabelFlagsDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelFlagsDesc.TabIndex = 36;
			this.toolTip.SetToolTip(this.kryptonLabelFlagsDesc, "4-hexdigit flags");
			this.kryptonLabelFlagsDesc.Values.Text = "4-hexdigit flags";
			this.kryptonLabelFlagsDesc.DoubleClick += new System.EventHandler(this.KryptonLabelFlagsDesc_DoubleClick);
			this.kryptonLabelFlagsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelFlagsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelFlagsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelFlagsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelDateLastObservationDesc
			// 
			this.kryptonLabelDateLastObservationDesc.AccessibleDescription = "Date of last observation (YYYYMMDD)";
			this.kryptonLabelDateLastObservationDesc.AccessibleName = "Date of last observation (YYYYMMDD)";
			this.kryptonLabelDateLastObservationDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelDateLastObservationDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonLabelDateLastObservationDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonLabelDateLastObservationDesc.Location = new System.Drawing.Point(422, 237);
			this.kryptonLabelDateLastObservationDesc.Name = "kryptonLabelDateLastObservationDesc";
			this.kryptonLabelDateLastObservationDesc.Size = new System.Drawing.Size(222, 20);
			this.kryptonLabelDateLastObservationDesc.TabIndex = 38;
			this.toolTip.SetToolTip(this.kryptonLabelDateLastObservationDesc, "Date of last observation (YYYYMMDD)");
			this.kryptonLabelDateLastObservationDesc.Values.ExtraText = "YYYYMMDD";
			this.kryptonLabelDateLastObservationDesc.Values.Text = "Date of last observation";
			this.kryptonLabelDateLastObservationDesc.DoubleClick += new System.EventHandler(this.KryptonLabelDateLastObservationDesc_DoubleClick);
			this.kryptonLabelDateLastObservationDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDateLastObservationDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelDateLastObservationDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelDateLastObservationDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuTopTenRecords
			// 
			this.contextMenuTopTenRecords.AccessibleDescription = "Show the context menu of the top ten records";
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
			this.contextMenuTopTenRecords.OwnerItem = this.menuitemTopTenRecords;
			this.contextMenuTopTenRecords.Size = new System.Drawing.Size(250, 362);
			this.contextMenuTopTenRecords.TabStop = true;
			this.contextMenuTopTenRecords.Text = "Top ten records";
			this.toolTip.SetToolTip(this.contextMenuTopTenRecords, "Top ten records");
			this.contextMenuTopTenRecords.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.contextMenuTopTenRecords.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsSortDirection
			// 
			this.menuitemRecordsSortDirection.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
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
			this.menuitemRecordsSortDirectionAscending.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsSortDirectionAscending.Checked = true;
			this.menuitemRecordsSortDirectionAscending.CheckOnClick = true;
			this.menuitemRecordsSortDirectionAscending.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemRecordsSortDirectionAscending.Enabled = false;
			this.menuitemRecordsSortDirectionAscending.Name = "menuitemRecordsSortDirectionAscending";
			this.menuitemRecordsSortDirectionAscending.Size = new System.Drawing.Size(136, 22);
			this.menuitemRecordsSortDirectionAscending.Text = "Ascending";
			this.menuitemRecordsSortDirectionAscending.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsSortDirectionAscending.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsSortDirectionDescending
			// 
			this.menuitemRecordsSortDirectionDescending.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemRecordsSortDirectionDescending.CheckOnClick = true;
			this.menuitemRecordsSortDirectionDescending.Enabled = false;
			this.menuitemRecordsSortDirectionDescending.Name = "menuitemRecordsSortDirectionDescending";
			this.menuitemRecordsSortDirectionDescending.Size = new System.Drawing.Size(136, 22);
			this.menuitemRecordsSortDirectionDescending.Text = "Descending";
			this.menuitemRecordsSortDirectionDescending.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemRecordsSortDirectionDescending.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(246, 6);
			this.toolStripSeparator12.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator12.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRecordsMeanAnomalyAtTheEpoch
			// 
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
			// contextMenuDistributions
			// 
			this.contextMenuDistributions.AccessibleDescription = "Show the context menu of the distributions";
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
            this.menuitemDistributionComputerName,
            this.menuitemDistributionDateOfTheLastObservation});
			this.contextMenuDistributions.Name = "contextMenuDistributions";
			this.contextMenuDistributions.OwnerItem = this.splitbuttonDistribution;
			this.contextMenuDistributions.Size = new System.Drawing.Size(250, 334);
			this.contextMenuDistributions.Text = "Distributions";
			this.toolTip.SetToolTip(this.contextMenuDistributions, "Distributions");
			// 
			// menuitemDistributionMeanAnomalyAtTheEpoch
			// 
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Enabled = false;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionMeanAnomalyAtTheEpoch.Image")));
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Name = "menuitemDistributionMeanAnomalyAtTheEpoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionMeanAnomalyAtTheEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionArgumentOfPerihelion
			// 
			this.menuitemDistributionArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionArgumentOfPerihelion.Enabled = false;
			this.menuitemDistributionArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionArgumentOfPerihelion.Image")));
			this.menuitemDistributionArgumentOfPerihelion.Name = "menuitemDistributionArgumentOfPerihelion";
			this.menuitemDistributionArgumentOfPerihelion.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionArgumentOfPerihelion.Text = "Argument of perihelion";
			this.menuitemDistributionArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionLongitudeOfTheAscendingNode
			// 
			this.menuitemDistributionLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionLongitudeOfTheAscendingNode.Enabled = false;
			this.menuitemDistributionLongitudeOfTheAscendingNode.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionLongitudeOfTheAscendingNode.Image")));
			this.menuitemDistributionLongitudeOfTheAscendingNode.Name = "menuitemDistributionLongitudeOfTheAscendingNode";
			this.menuitemDistributionLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node";
			this.menuitemDistributionLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionInclination
			// 
			this.menuitemDistributionInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionInclination.Enabled = false;
			this.menuitemDistributionInclination.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionInclination.Image")));
			this.menuitemDistributionInclination.Name = "menuitemDistributionInclination";
			this.menuitemDistributionInclination.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionInclination.Text = "Inclination to the ecliptic";
			this.menuitemDistributionInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionOrbitalEccentricity
			// 
			this.menuitemDistributionOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionOrbitalEccentricity.Enabled = false;
			this.menuitemDistributionOrbitalEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionOrbitalEccentricity.Image")));
			this.menuitemDistributionOrbitalEccentricity.Name = "menuitemDistributionOrbitalEccentricity";
			this.menuitemDistributionOrbitalEccentricity.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemDistributionOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionMeanDailyMotion
			// 
			this.menuitemDistributionMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionMeanDailyMotion.Enabled = false;
			this.menuitemDistributionMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionMeanDailyMotion.Image")));
			this.menuitemDistributionMeanDailyMotion.Name = "menuitemDistributionMeanDailyMotion";
			this.menuitemDistributionMeanDailyMotion.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionMeanDailyMotion.Text = "Mean daily motion";
			this.menuitemDistributionMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionSemiMajorAxis
			// 
			this.menuitemDistributionSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionSemiMajorAxis.Enabled = false;
			this.menuitemDistributionSemiMajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionSemiMajorAxis.Image")));
			this.menuitemDistributionSemiMajorAxis.Name = "menuitemDistributionSemiMajorAxis";
			this.menuitemDistributionSemiMajorAxis.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionSemiMajorAxis.Text = "Semi-major axis";
			this.menuitemDistributionSemiMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionSemiMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionAbsoluteMagnitude
			// 
			this.menuitemDistributionAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionAbsoluteMagnitude.Enabled = false;
			this.menuitemDistributionAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionAbsoluteMagnitude.Image")));
			this.menuitemDistributionAbsoluteMagnitude.Name = "menuitemDistributionAbsoluteMagnitude";
			this.menuitemDistributionAbsoluteMagnitude.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionAbsoluteMagnitude.Text = "Absolute magnitude";
			this.menuitemDistributionAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionSlopeParameter
			// 
			this.menuitemDistributionSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionSlopeParameter.Enabled = false;
			this.menuitemDistributionSlopeParameter.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionSlopeParameter.Image")));
			this.menuitemDistributionSlopeParameter.Name = "menuitemDistributionSlopeParameter";
			this.menuitemDistributionSlopeParameter.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionSlopeParameter.Text = "Slope parameter";
			this.menuitemDistributionSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionNumberOfOppositions
			// 
			this.menuitemDistributionNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionNumberOfOppositions.Enabled = false;
			this.menuitemDistributionNumberOfOppositions.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionNumberOfOppositions.Image")));
			this.menuitemDistributionNumberOfOppositions.Name = "menuitemDistributionNumberOfOppositions";
			this.menuitemDistributionNumberOfOppositions.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemDistributionNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionNumberOfObservations
			// 
			this.menuitemDistributionNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionNumberOfObservations.Enabled = false;
			this.menuitemDistributionNumberOfObservations.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionNumberOfObservations.Image")));
			this.menuitemDistributionNumberOfObservations.Name = "menuitemDistributionNumberOfObservations";
			this.menuitemDistributionNumberOfObservations.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionNumberOfObservations.Text = "Number of observations";
			this.menuitemDistributionNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionObservationSpan
			// 
			this.menuitemDistributionObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionObservationSpan.Enabled = false;
			this.menuitemDistributionObservationSpan.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionObservationSpan.Image")));
			this.menuitemDistributionObservationSpan.Name = "menuitemDistributionObservationSpan";
			this.menuitemDistributionObservationSpan.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionObservationSpan.Text = "Observation span";
			this.menuitemDistributionObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionRmsResidual
			// 
			this.menuitemDistributionRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionRmsResidual.Enabled = false;
			this.menuitemDistributionRmsResidual.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionRmsResidual.Image")));
			this.menuitemDistributionRmsResidual.Name = "menuitemDistributionRmsResidual";
			this.menuitemDistributionRmsResidual.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionRmsResidual.Text = "r.m.s. residual";
			this.menuitemDistributionRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionComputerName
			// 
			this.menuitemDistributionComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionComputerName.Enabled = false;
			this.menuitemDistributionComputerName.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionComputerName.Image")));
			this.menuitemDistributionComputerName.Name = "menuitemDistributionComputerName";
			this.menuitemDistributionComputerName.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionComputerName.Text = "Computer name";
			this.menuitemDistributionComputerName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionComputerName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistributionDateOfTheLastObservation
			// 
			this.menuitemDistributionDateOfTheLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemDistributionDateOfTheLastObservation.Enabled = false;
			this.menuitemDistributionDateOfTheLastObservation.Image = ((System.Drawing.Image)(resources.GetObject("menuitemDistributionDateOfTheLastObservation.Image")));
			this.menuitemDistributionDateOfTheLastObservation.Name = "menuitemDistributionDateOfTheLastObservation";
			this.menuitemDistributionDateOfTheLastObservation.Size = new System.Drawing.Size(249, 22);
			this.menuitemDistributionDateOfTheLastObservation.Text = "Date of the last observation";
			this.menuitemDistributionDateOfTheLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistributionDateOfTheLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDistribution
			// 
			this.menuitemDistribution.AutoToolTip = true;
			this.menuitemDistribution.DoubleClickEnabled = true;
			this.menuitemDistribution.DropDown = this.contextMenuDistributions;
			this.menuitemDistribution.Enabled = false;
			this.menuitemDistribution.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.menuitemDistribution.Name = "menuitemDistribution";
			this.menuitemDistribution.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.menuitemDistribution.Size = new System.Drawing.Size(251, 22);
			this.menuitemDistribution.Text = "&Distributions";
			this.menuitemDistribution.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemDistribution.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// splitbuttonTopTenRecords
			// 
			this.splitbuttonTopTenRecords.AccessibleDescription = "Chart bar";
			this.splitbuttonTopTenRecords.AccessibleName = "Chart bar";
			this.splitbuttonTopTenRecords.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonTopTenRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonTopTenRecords.DoubleClickEnabled = true;
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
			this.splitbuttonDistribution.AccessibleDescription = "Chart bar";
			this.splitbuttonDistribution.AccessibleName = "Chart bar";
			this.splitbuttonDistribution.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonDistribution.DoubleClickEnabled = true;
			this.splitbuttonDistribution.DropDown = this.contextMenuDistributions;
			this.splitbuttonDistribution.Enabled = false;
			this.splitbuttonDistribution.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.splitbuttonDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.splitbuttonDistribution.Name = "splitbuttonDistribution";
			this.splitbuttonDistribution.Size = new System.Drawing.Size(32, 22);
			this.splitbuttonDistribution.Text = "Distributions";
			this.splitbuttonDistribution.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.splitbuttonDistribution.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripStatusLabelUpdate.AccessibleDescription = "Show that an MPCORB.DAT update is aviable";
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
			this.toolStripStatusLabelBackgroundDownload.AccessibleDescription = "Show the download progres";
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
			this.toolStripProgressBarBackgroundDownload.AccessibleDescription = "Show the download progres";
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
			this.toolStripStatusLabelCancelBackgroundDownload.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripStatusLabelCancelBackgroundDownload.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.labelInformation.Size = new System.Drawing.Size(144, 16);
			this.labelInformation.Spring = true;
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// menu
			// 
			this.menu.AccessibleDescription = "Show the menubar";
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
			this.menu.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menu.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.menu.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menu.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemFile
			// 
			this.menuitemFile.AccessibleDescription = "Open the menu \"file\"";
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
			this.menuitemOpenALocalMpcorbdatFile.AccessibleDescription = "Open a local MPCORB.DAT file";
			this.menuitemOpenALocalMpcorbdatFile.AccessibleName = "Open";
			this.menuitemOpenALocalMpcorbdatFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemOpenALocalMpcorbdatFile.AutoToolTip = true;
			this.menuitemOpenALocalMpcorbdatFile.Enabled = false;
			this.menuitemOpenALocalMpcorbdatFile.Image = global::Planetoid_DB.Properties.Resources.silk_folder;
			this.menuitemOpenALocalMpcorbdatFile.Name = "menuitemOpenALocalMpcorbdatFile";
			this.menuitemOpenALocalMpcorbdatFile.Size = new System.Drawing.Size(235, 22);
			this.menuitemOpenALocalMpcorbdatFile.Text = "&Open a local MPCORB.DAT file";
			this.menuitemOpenALocalMpcorbdatFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOpenALocalMpcorbdatFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator13
			// 
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new System.Drawing.Size(232, 6);
			this.toolStripSeparator13.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator13.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportDataEntry
			// 
			this.menuitemExportDataEntry.AccessibleDescription = "Export data entry";
			this.menuitemExportDataEntry.AccessibleName = "Export";
			this.menuitemExportDataEntry.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportDataEntry.AutoToolTip = true;
			this.menuitemExportDataEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemExportDataEntryAsTxt,
            this.menuitemExportDataEntryAsHtml,
            this.menuitemExportDataEntryAsXml,
            this.menuitemExportDataEntryAsJson});
			this.menuitemExportDataEntry.Image = global::Planetoid_DB.Properties.Resources.silk_page_save;
			this.menuitemExportDataEntry.Name = "menuitemExportDataEntry";
			this.menuitemExportDataEntry.Size = new System.Drawing.Size(235, 22);
			this.menuitemExportDataEntry.Text = "&Export data entry";
			this.menuitemExportDataEntry.Click += new System.EventHandler(this.ExportDataEntryToolStripMenuItem_Click);
			this.menuitemExportDataEntry.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportDataEntry.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportDataEntryAsTxt
			// 
			this.menuitemExportDataEntryAsTxt.AccessibleDescription = "Export data entry as TXT";
			this.menuitemExportDataEntryAsTxt.AccessibleName = "Export data entry as TXT";
			this.menuitemExportDataEntryAsTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportDataEntryAsTxt.AutoToolTip = true;
			this.menuitemExportDataEntryAsTxt.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_text;
			this.menuitemExportDataEntryAsTxt.Name = "menuitemExportDataEntryAsTxt";
			this.menuitemExportDataEntryAsTxt.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportDataEntryAsTxt.Text = "Export as &TXT";
			this.menuitemExportDataEntryAsTxt.ToolTipText = "Export data entry as TXT";
			this.menuitemExportDataEntryAsTxt.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsTxt_Click);
			this.menuitemExportDataEntryAsTxt.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportDataEntryAsTxt.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportDataEntryAsHtml
			// 
			this.menuitemExportDataEntryAsHtml.AccessibleDescription = "Export data entry as HTML";
			this.menuitemExportDataEntryAsHtml.AccessibleName = "Export data entry as HTML";
			this.menuitemExportDataEntryAsHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportDataEntryAsHtml.AutoToolTip = true;
			this.menuitemExportDataEntryAsHtml.Image = ((System.Drawing.Image)(resources.GetObject("menuitemExportDataEntryAsHtml.Image")));
			this.menuitemExportDataEntryAsHtml.Name = "menuitemExportDataEntryAsHtml";
			this.menuitemExportDataEntryAsHtml.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportDataEntryAsHtml.Text = "Export as &HTML";
			this.menuitemExportDataEntryAsHtml.ToolTipText = "Export data entry as HTML";
			this.menuitemExportDataEntryAsHtml.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsHtml_Click);
			this.menuitemExportDataEntryAsHtml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportDataEntryAsHtml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportDataEntryAsXml
			// 
			this.menuitemExportDataEntryAsXml.AccessibleDescription = "Export data entry as XML";
			this.menuitemExportDataEntryAsXml.AccessibleName = "Export data entry as XML";
			this.menuitemExportDataEntryAsXml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportDataEntryAsXml.AutoToolTip = true;
			this.menuitemExportDataEntryAsXml.Image = ((System.Drawing.Image)(resources.GetObject("menuitemExportDataEntryAsXml.Image")));
			this.menuitemExportDataEntryAsXml.Name = "menuitemExportDataEntryAsXml";
			this.menuitemExportDataEntryAsXml.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportDataEntryAsXml.Text = "Export as &XML";
			this.menuitemExportDataEntryAsXml.ToolTipText = "Export data entry as XML";
			this.menuitemExportDataEntryAsXml.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsXml_Click);
			this.menuitemExportDataEntryAsXml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportDataEntryAsXml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportDataEntryAsJson
			// 
			this.menuitemExportDataEntryAsJson.AccessibleDescription = "Export data entry as JSON";
			this.menuitemExportDataEntryAsJson.AccessibleName = "Export data entry as JSON";
			this.menuitemExportDataEntryAsJson.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportDataEntryAsJson.AutoToolTip = true;
			this.menuitemExportDataEntryAsJson.Image = ((System.Drawing.Image)(resources.GetObject("menuitemExportDataEntryAsJson.Image")));
			this.menuitemExportDataEntryAsJson.Name = "menuitemExportDataEntryAsJson";
			this.menuitemExportDataEntryAsJson.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportDataEntryAsJson.Text = "Export as &JSON";
			this.menuitemExportDataEntryAsJson.ToolTipText = "Export data entry as JSON";
			this.menuitemExportDataEntryAsJson.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsJson_Click);
			this.menuitemExportDataEntryAsJson.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportDataEntryAsJson.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemPrint
			// 
			this.menuitemPrint.AccessibleDescription = "Print the information";
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
			this.toolStripSeparatorFile1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			this.toolStripSeparatorFile1.Size = new System.Drawing.Size(232, 6);
			this.toolStripSeparatorFile1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorFile1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemRestart
			// 
			this.menuitemRestart.AccessibleDescription = "Restart the application";
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
			this.menuitemExit.AccessibleDescription = "Exit the application";
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
			this.menuitemEdit.AccessibleDescription = "Open the menu \"edit\"";
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
			this.menuitemCopytoClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemCopyToClipboardIndexNumber,
            this.menuitemCopyToClipboardReadableDesignation,
            this.menuitemCopyToClipboardEpoch,
            this.menuitemCopyToClipboardMeanAnomaly,
            this.menuitemCopyToClipboardArgumentOfPerihelion,
            this.menuitemCopyToClipboardLongitudeOfTheAscendingNode,
            this.menuitemCopyToClipboardInclination,
            this.menuitemCopyToClipboardEccentricity,
            this.menuitemCopyToClipboardMeanDailyMotion,
            this.menuitemCopyToClipboardSemimajorAxis,
            this.menuitemCopyToClipboardAbsoluteMagnitude,
            this.menuitemCopyToClipboardSlopeParameter,
            this.menuitemCopyToClipboardReference,
            this.menuitemCopyToClipboardNumberOfOppositions,
            this.menuitemCopyToClipboardNumberOfObservations,
            this.menuitemCopyToClipboardObservationSpan,
            this.menuitemCopyToClipboardRmsResidual,
            this.menuitemCopyToClipboardComputername,
            this.menuitemCopyToClipboardDateOfLastObservation,
            this.menuitemCopyToClipboardFlags});
			this.menuitemCopytoClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.menuitemCopytoClipboard.Name = "menuitemCopytoClipboard";
			this.menuitemCopytoClipboard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.menuitemCopytoClipboard.Size = new System.Drawing.Size(145, 22);
			this.menuitemCopytoClipboard.Text = "&Copy";
			this.menuitemCopytoClipboard.Click += new System.EventHandler(this.ToolStripButtonCopyToClipboard_Click);
			this.menuitemCopytoClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopytoClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardIndexNumber
			// 
			this.menuitemCopyToClipboardIndexNumber.AccessibleDescription = "Copy to clipboard: Index number";
			this.menuitemCopyToClipboardIndexNumber.AccessibleName = "Copy to clipboard: Index number";
			this.menuitemCopyToClipboardIndexNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardIndexNumber.AutoToolTip = true;
			this.menuitemCopyToClipboardIndexNumber.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardIndexNumber.Image")));
			this.menuitemCopyToClipboardIndexNumber.Name = "menuitemCopyToClipboardIndexNumber";
			this.menuitemCopyToClipboardIndexNumber.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardReadableDesignation.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardEpoch.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.menuitemCopyToClipboardEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardEpoch_Click);
			this.menuitemCopyToClipboardEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardMeanAnomaly
			// 
			this.menuitemCopyToClipboardMeanAnomaly.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyToClipboardMeanAnomaly.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyToClipboardMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardMeanAnomaly.AutoToolTip = true;
			this.menuitemCopyToClipboardMeanAnomaly.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardMeanAnomaly.Image")));
			this.menuitemCopyToClipboardMeanAnomaly.Name = "menuitemCopyToClipboardMeanAnomaly";
			this.menuitemCopyToClipboardMeanAnomaly.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardMeanAnomaly.Text = "Mean anomaly at the epoch (degrees)";
			this.menuitemCopyToClipboardMeanAnomaly.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanAnomaly_Click);
			this.menuitemCopyToClipboardMeanAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardMeanAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardArgumentOfPerihelion
			// 
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardArgumentOfPerihelion.AutoToolTip = true;
			this.menuitemCopyToClipboardArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardArgumentOfPerihelion.Image")));
			this.menuitemCopyToClipboardArgumentOfPerihelion.Name = "menuitemCopyToClipboardArgumentOfPerihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (degrees)";
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
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click);
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardInclination
			// 
			this.menuitemCopyToClipboardInclination.AccessibleDescription = "Copy to clipboard: Inclination";
			this.menuitemCopyToClipboardInclination.AccessibleName = "Copy to clipboard: Inclination";
			this.menuitemCopyToClipboardInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardInclination.AutoToolTip = true;
			this.menuitemCopyToClipboardInclination.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardInclination.Image")));
			this.menuitemCopyToClipboardInclination.Name = "menuitemCopyToClipboardInclination";
			this.menuitemCopyToClipboardInclination.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardInclination.Text = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.menuitemCopyToClipboardInclination.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardInclination_Click);
			this.menuitemCopyToClipboardInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardEccentricity
			// 
			this.menuitemCopyToClipboardEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyToClipboardEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyToClipboardEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardEccentricity.AutoToolTip = true;
			this.menuitemCopyToClipboardEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardEccentricity.Image")));
			this.menuitemCopyToClipboardEccentricity.Name = "menuitemCopyToClipboardEccentricity";
			this.menuitemCopyToClipboardEccentricity.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardEccentricity.Text = "Orbital eccentricity";
			this.menuitemCopyToClipboardEccentricity.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click);
			this.menuitemCopyToClipboardEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardMeanDailyMotion
			// 
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardMeanDailyMotion.AutoToolTip = true;
			this.menuitemCopyToClipboardMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardMeanDailyMotion.Image")));
			this.menuitemCopyToClipboardMeanDailyMotion.Name = "menuitemCopyToClipboardMeanDailyMotion";
			this.menuitemCopyToClipboardMeanDailyMotion.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardMeanDailyMotion.Text = "Mean daily motion (degrees per day)";
			this.menuitemCopyToClipboardMeanDailyMotion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click);
			this.menuitemCopyToClipboardMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardSemimajorAxis
			// 
			this.menuitemCopyToClipboardSemimajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis";
			this.menuitemCopyToClipboardSemimajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis";
			this.menuitemCopyToClipboardSemimajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardSemimajorAxis.AutoToolTip = true;
			this.menuitemCopyToClipboardSemimajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardSemimajorAxis.Image")));
			this.menuitemCopyToClipboardSemimajorAxis.Name = "menuitemCopyToClipboardSemimajorAxis";
			this.menuitemCopyToClipboardSemimajorAxis.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardSemimajorAxis.Text = "Semi-major axis (AU)";
			this.menuitemCopyToClipboardSemimajorAxis.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardSemimajorAxis_Click);
			this.menuitemCopyToClipboardSemimajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardSemimajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardAbsoluteMagnitude
			// 
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardAbsoluteMagnitude.AutoToolTip = true;
			this.menuitemCopyToClipboardAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardAbsoluteMagnitude.Image")));
			this.menuitemCopyToClipboardAbsoluteMagnitude.Name = "menuitemCopyToClipboardAbsoluteMagnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardSlopeParameter.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardReference.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardNumberOfOppositions.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardNumberOfObservations.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardObservationSpan.Size = new System.Drawing.Size(300, 22);
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
			this.menuitemCopyToClipboardRmsResidual.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardRmsResidual.Text = "r.m.s. residual (\")";
			this.menuitemCopyToClipboardRmsResidual.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardRmsResidual_Click);
			this.menuitemCopyToClipboardRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardComputername
			// 
			this.menuitemCopyToClipboardComputername.AccessibleDescription = "Copy to clipboard: Computer name";
			this.menuitemCopyToClipboardComputername.AccessibleName = "Copy to clipboard: Computer name";
			this.menuitemCopyToClipboardComputername.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardComputername.AutoToolTip = true;
			this.menuitemCopyToClipboardComputername.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardComputername.Image")));
			this.menuitemCopyToClipboardComputername.Name = "menuitemCopyToClipboardComputername";
			this.menuitemCopyToClipboardComputername.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardComputername.Text = "Computer name";
			this.menuitemCopyToClipboardComputername.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardComputername_Click);
			this.menuitemCopyToClipboardComputername.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardComputername.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardDateOfLastObservation
			// 
			this.menuitemCopyToClipboardDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation";
			this.menuitemCopyToClipboardDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation";
			this.menuitemCopyToClipboardDateOfLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardDateOfLastObservation.AutoToolTip = true;
			this.menuitemCopyToClipboardDateOfLastObservation.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardDateOfLastObservation.Image")));
			this.menuitemCopyToClipboardDateOfLastObservation.Name = "menuitemCopyToClipboardDateOfLastObservation";
			this.menuitemCopyToClipboardDateOfLastObservation.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardDateOfLastObservation.Text = "Date of last observation";
			this.menuitemCopyToClipboardDateOfLastObservation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click);
			this.menuitemCopyToClipboardDateOfLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardDateOfLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyToClipboardFlags
			// 
			this.menuitemCopyToClipboardFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardFlags.AutoToolTip = true;
			this.menuitemCopyToClipboardFlags.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyToClipboardFlags.Image")));
			this.menuitemCopyToClipboardFlags.Name = "menuitemCopyToClipboardFlags";
			this.menuitemCopyToClipboardFlags.Size = new System.Drawing.Size(300, 22);
			this.menuitemCopyToClipboardFlags.Text = "4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardFlags_Click);
			this.menuitemCopyToClipboardFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyToClipboardFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.menuitemNavigation.AccessibleDescription = "Open the menu \"navigation\"";
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
			this.menuitemRandomMinorPlanet.AccessibleDescription = "Load a random minor planet";
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
			this.toolStripSeparatorNavigation1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorNavigation1.Name = "toolStripSeparatorNavigation1";
			this.toolStripSeparatorNavigation1.Size = new System.Drawing.Size(271, 6);
			this.toolStripSeparatorNavigation1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorNavigation1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemNavigateToTheBeginning
			// 
			this.menuitemNavigateToTheBeginning.AccessibleDescription = "Navigate to the beginning of the data";
			this.menuitemNavigateToTheBeginning.AccessibleName = "Navigate to the beginning";
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
			this.menuitemNavigateToThePreviousData.AccessibleDescription = "Navigate to the previous data";
			this.menuitemNavigateToThePreviousData.AccessibleName = "Navigate to the previous";
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
			this.menuitemNavigateToTheNextData.AccessibleDescription = "Navigate to the next data";
			this.menuitemNavigateToTheNextData.AccessibleName = "Navigate to the next";
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
			this.menuitemNavigateToTheEnd.AccessibleDescription = "Navigate to the end of the data";
			this.menuitemNavigateToTheEnd.AccessibleName = "Navigate to the end";
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
			this.menuitemTools.AccessibleDescription = "Open the menu \"tools\"";
			this.menuitemTools.AccessibleName = "Tools";
			this.menuitemTools.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemTools.AutoToolTip = true;
			this.menuitemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDerivatedOrbitElements,
            this.menuitemFilter,
            this.toolStripSeparatorTools1,
            this.menuitemTopTenRecords,
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
			this.menuitemDerivatedOrbitElements.AccessibleDescription = "Calculate derivated orbital elements";
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
			this.toolStripSeparatorTools1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorTools1.Name = "toolStripSeparatorTools1";
			this.toolStripSeparatorTools1.Size = new System.Drawing.Size(248, 6);
			this.toolStripSeparatorTools1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorTools1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemTopTenRecords
			// 
			this.menuitemTopTenRecords.AutoToolTip = true;
			this.menuitemTopTenRecords.DropDown = this.contextMenuTopTenRecords;
			this.menuitemTopTenRecords.Enabled = false;
			this.menuitemTopTenRecords.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_numbers;
			this.menuitemTopTenRecords.Name = "menuitemTopTenRecords";
			this.menuitemTopTenRecords.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.menuitemTopTenRecords.Size = new System.Drawing.Size(251, 22);
			this.menuitemTopTenRecords.Text = "Top ten &records";
			this.menuitemTopTenRecords.Click += new System.EventHandler(this.MenuitemTopTenRecords_Click);
			this.menuitemTopTenRecords.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemTopTenRecords.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(248, 6);
			// 
			// toolStripSeparatorTools2
			// 
			this.toolStripSeparatorTools2.Name = "toolStripSeparatorTools2";
			this.toolStripSeparatorTools2.Size = new System.Drawing.Size(248, 6);
			this.toolStripSeparatorTools2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorTools2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemDatabaseInformation
			// 
			this.menuitemDatabaseInformation.AccessibleDescription = "Show the information of the MPCORB.DAT databbase";
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
			this.menuitemTableMode.AccessibleDescription = "Activate the table mode";
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
			this.menuitemTerminology.AccessibleDescription = "Show the terminology";
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
			this.menuitemCheckMpcorbDat.AccessibleDescription = "Check for updates of the database";
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
			this.menuitemDownloadMpcorbDat.AccessibleDescription = "Download the database";
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
			this.menuitemOptions.AccessibleDescription = "Open the menu \"options\"";
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
			this.menuitemStyle.AccessibleDescription = "Change the style";
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
			this.menuitemIconsetSilk.AccessibleDescription = "Change the icon set to Silk icons";
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
			this.menuitemIconsetFugue.AccessibleDescription = "Change the icon set to Fugue icons";
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
			this.menuitemIconsetFatcow.AccessibleDescription = "Change the icon set to Fatcow icons";
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
			this.toolStripSeparatorOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorOptions.Name = "toolStripSeparatorOptions";
			this.toolStripSeparatorOptions.Size = new System.Drawing.Size(299, 6);
			this.toolStripSeparatorOptions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorOptions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOptionStayOnTop
			// 
			this.menuitemOptionStayOnTop.AccessibleDescription = "Stay the application always on top";
			this.menuitemOptionStayOnTop.AccessibleName = "Stay always on top";
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
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleDescription = "Enabled copying data to the clipboard by double-clicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleName = "Enabled copying by double-clicking";
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
			this.menuitemOptionEnableLinkingToTerminology.AccessibleDescription = "Enable linking to terminology";
			this.menuitemOptionEnableLinkingToTerminology.AccessibleName = "Enable linking to terminology";
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
			this.menuitemHelp.AccessibleDescription = "Open the menu \"help\"";
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
			this.menuitemAbout.Size = new System.Drawing.Size(231, 22);
			this.menuitemAbout.Text = "&About";
			this.menuitemAbout.ToolTipText = "More information about the application";
			this.menuitemAbout.Click += new System.EventHandler(this.MenuitemAbout_Click);
			this.menuitemAbout.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemAbout.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorMisc1
			// 
			this.toolStripSeparatorMisc1.AccessibleDescription = "";
			this.toolStripSeparatorMisc1.AccessibleName = "";
			this.toolStripSeparatorMisc1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorMisc1.Name = "toolStripSeparatorMisc1";
			this.toolStripSeparatorMisc1.Size = new System.Drawing.Size(228, 6);
			this.toolStripSeparatorMisc1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorMisc1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.menuitemOpenWebsiteMPC.Size = new System.Drawing.Size(231, 22);
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
			this.menuitemOpenMPCORBWebsite.Size = new System.Drawing.Size(231, 22);
			this.menuitemOpenMPCORBWebsite.Text = "Open MPCORB website";
			this.menuitemOpenMPCORBWebsite.ToolTipText = "Opens the MPCORB website";
			this.menuitemOpenMPCORBWebsite.Click += new System.EventHandler(this.MenuitemOpenMPCORBWebsite_Click);
			this.menuitemOpenMPCORBWebsite.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOpenMPCORBWebsite.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorOptions2
			// 
			this.toolStripSeparatorOptions2.Name = "toolStripSeparatorOptions2";
			this.toolStripSeparatorOptions2.Size = new System.Drawing.Size(6, 6);
			// 
			// toolStripSeparatorOptions1
			// 
			this.toolStripSeparatorOptions1.Name = "toolStripSeparatorOptions1";
			this.toolStripSeparatorOptions1.Size = new System.Drawing.Size(6, 6);
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
            this.splitbuttonExport,
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
			this.toolStripButtonOpen.AccessibleDescription = "Open a local MPCORB.DAT file";
			this.toolStripButtonOpen.AccessibleName = "Open";
			this.toolStripButtonOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpen.Enabled = false;
			this.toolStripButtonOpen.Image = global::Planetoid_DB.Properties.Resources.silk_folder;
			this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpen.Name = "toolStripButtonOpen";
			this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonOpen.Text = "Open";
			this.toolStripButtonOpen.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonOpen.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// splitbuttonExport
			// 
			this.splitbuttonExport.AccessibleDescription = "ExprtDataEntry";
			this.splitbuttonExport.AccessibleName = "Export";
			this.splitbuttonExport.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemExportAsTxt,
            this.menuitemExportAsHtml,
            this.menuitemExportAsXml,
            this.menuitemExportAsJson});
			this.splitbuttonExport.Image = global::Planetoid_DB.Properties.Resources.silk_page_save;
			this.splitbuttonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.splitbuttonExport.Name = "splitbuttonExport";
			this.splitbuttonExport.Size = new System.Drawing.Size(32, 22);
			this.splitbuttonExport.Text = "Export";
			this.splitbuttonExport.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonExport_ButtonClick);
			this.splitbuttonExport.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.splitbuttonExport.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportAsTxt
			// 
			this.menuitemExportAsTxt.AccessibleDescription = "Export data entry as TXT";
			this.menuitemExportAsTxt.AccessibleName = "Export data entry as TXT";
			this.menuitemExportAsTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportAsTxt.AutoToolTip = true;
			this.menuitemExportAsTxt.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_text;
			this.menuitemExportAsTxt.Name = "menuitemExportAsTxt";
			this.menuitemExportAsTxt.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportAsTxt.Text = "Export as &TXT";
			this.menuitemExportAsTxt.ToolTipText = "Export data entry as TXT";
			this.menuitemExportAsTxt.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsTxt_Click);
			this.menuitemExportAsTxt.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportAsTxt.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportAsHtml
			// 
			this.menuitemExportAsHtml.AccessibleDescription = "Export data entry as HTML";
			this.menuitemExportAsHtml.AccessibleName = "Export data entry as HTML";
			this.menuitemExportAsHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportAsHtml.AutoToolTip = true;
			this.menuitemExportAsHtml.Image = ((System.Drawing.Image)(resources.GetObject("menuitemExportAsHtml.Image")));
			this.menuitemExportAsHtml.Name = "menuitemExportAsHtml";
			this.menuitemExportAsHtml.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportAsHtml.Text = "Export as &HTML";
			this.menuitemExportAsHtml.ToolTipText = "Export data entry as HTML";
			this.menuitemExportAsHtml.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsHtml_Click);
			this.menuitemExportAsHtml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportAsHtml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportAsXml
			// 
			this.menuitemExportAsXml.AccessibleDescription = "Export data entry as XML";
			this.menuitemExportAsXml.AccessibleName = "Export data entry as XML";
			this.menuitemExportAsXml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportAsXml.AutoToolTip = true;
			this.menuitemExportAsXml.Image = ((System.Drawing.Image)(resources.GetObject("menuitemExportAsXml.Image")));
			this.menuitemExportAsXml.Name = "menuitemExportAsXml";
			this.menuitemExportAsXml.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportAsXml.Text = "Export as &XML";
			this.menuitemExportAsXml.ToolTipText = "Export data entry as XML";
			this.menuitemExportAsXml.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsXml_Click);
			this.menuitemExportAsXml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportAsXml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemExportAsJson
			// 
			this.menuitemExportAsJson.AccessibleDescription = "Export data entry as JSON";
			this.menuitemExportAsJson.AccessibleName = "Export data entry as JSON";
			this.menuitemExportAsJson.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemExportAsJson.AutoToolTip = true;
			this.menuitemExportAsJson.Image = ((System.Drawing.Image)(resources.GetObject("menuitemExportAsJson.Image")));
			this.menuitemExportAsJson.Name = "menuitemExportAsJson";
			this.menuitemExportAsJson.Size = new System.Drawing.Size(157, 22);
			this.menuitemExportAsJson.Text = "Export as &JSON";
			this.menuitemExportAsJson.ToolTipText = "Export data entry as JSON";
			this.menuitemExportAsJson.Click += new System.EventHandler(this.ToolStripMenuItemExportDataEntryAsJson_Click);
			this.menuitemExportAsJson.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemExportAsJson.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonPrint
			// 
			this.toolStripButtonPrint.AccessibleDescription = "Print the information";
			this.toolStripButtonPrint.AccessibleName = "Print";
			this.toolStripButtonPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonPrint.CheckOnClick = true;
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.DoubleClickEnabled = true;
			this.toolStripButtonPrint.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Print";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.ToolStripButtonPrint_Click);
			this.toolStripButtonPrint.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonPrint.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// splitbuttonCopyToClipboard
			// 
			this.splitbuttonCopyToClipboard.AccessibleDescription = "Copy to clipboard";
			this.splitbuttonCopyToClipboard.AccessibleName = "Copy to clipboard";
			this.splitbuttonCopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.splitbuttonCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.splitbuttonCopyToClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemCopyIndexNumber,
            this.menuitemCopyReadableDesignation,
            this.menuitemCopyEpoch,
            this.menuitemCopyMeanAnomalyAtTheEpoch,
            this.menuitemCopyArgumentOfPerihelion,
            this.menuitemCopyLongitudeOfTheAscendingNode,
            this.menuitemCopyInclination,
            this.menuitemCopyEccentricity,
            this.menuitemCopyMeanDailyMotion,
            this.menuitemCopySemiMajorAxis,
            this.menuitemCopyAbsoluteMagnitude,
            this.menuitemCopySlopeParameter,
            this.menuitemCopyReference,
            this.menuitemCopyNumberOfOppositions,
            this.menuitemCopyNumberOfObservations,
            this.menuitemCopyObservationSpan,
            this.menuitemCopyRmsResidual,
            this.menuitemCopyComputerName,
            this.menuitemCopyDateOfLastObservation,
            this.menuitemCopyFlags});
			this.splitbuttonCopyToClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.splitbuttonCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.splitbuttonCopyToClipboard.Name = "splitbuttonCopyToClipboard";
			this.splitbuttonCopyToClipboard.Size = new System.Drawing.Size(32, 22);
			this.splitbuttonCopyToClipboard.Text = "Copy to clipboard";
			this.splitbuttonCopyToClipboard.ButtonClick += new System.EventHandler(this.ToolStripButtonCopyToClipboard_Click);
			this.splitbuttonCopyToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.splitbuttonCopyToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyIndexNumber
			// 
			this.menuitemCopyIndexNumber.AccessibleDescription = "Copy to clipboard: Index number";
			this.menuitemCopyIndexNumber.AccessibleName = "Copy to clipboard: Index number";
			this.menuitemCopyIndexNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyIndexNumber.AutoToolTip = true;
			this.menuitemCopyIndexNumber.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyIndexNumber.Image")));
			this.menuitemCopyIndexNumber.Name = "menuitemCopyIndexNumber";
			this.menuitemCopyIndexNumber.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyIndexNumber.Text = "Index No.";
			this.menuitemCopyIndexNumber.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardIndexNumber_Click);
			this.menuitemCopyIndexNumber.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyIndexNumber.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyReadableDesignation
			// 
			this.menuitemCopyReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			this.menuitemCopyReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			this.menuitemCopyReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyReadableDesignation.AutoToolTip = true;
			this.menuitemCopyReadableDesignation.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyReadableDesignation.Image")));
			this.menuitemCopyReadableDesignation.Name = "menuitemCopyReadableDesignation";
			this.menuitemCopyReadableDesignation.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyReadableDesignation.Text = "Readable designation";
			this.menuitemCopyReadableDesignation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReadableDesignation_Click);
			this.menuitemCopyReadableDesignation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyReadableDesignation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyEpoch
			// 
			this.menuitemCopyEpoch.AccessibleDescription = "Copy to clipboard: Epoch";
			this.menuitemCopyEpoch.AccessibleName = "Copy to clipboard: Epoch";
			this.menuitemCopyEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyEpoch.AutoToolTip = true;
			this.menuitemCopyEpoch.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyEpoch.Image")));
			this.menuitemCopyEpoch.Name = "menuitemCopyEpoch";
			this.menuitemCopyEpoch.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.menuitemCopyEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardEpoch_Click);
			this.menuitemCopyEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyMeanAnomalyAtTheEpoch
			// 
			this.menuitemCopyMeanAnomalyAtTheEpoch.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyMeanAnomalyAtTheEpoch.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyMeanAnomalyAtTheEpoch.AutoToolTip = true;
			this.menuitemCopyMeanAnomalyAtTheEpoch.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyMeanAnomalyAtTheEpoch.Image")));
			this.menuitemCopyMeanAnomalyAtTheEpoch.Name = "menuitemCopyMeanAnomalyAtTheEpoch";
			this.menuitemCopyMeanAnomalyAtTheEpoch.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch (°)";
			this.menuitemCopyMeanAnomalyAtTheEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanAnomaly_Click);
			this.menuitemCopyMeanAnomalyAtTheEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyMeanAnomalyAtTheEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyArgumentOfPerihelion
			// 
			this.menuitemCopyArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyArgumentOfPerihelion.AutoToolTip = true;
			this.menuitemCopyArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyArgumentOfPerihelion.Image")));
			this.menuitemCopyArgumentOfPerihelion.Name = "menuitemCopyArgumentOfPerihelion";
			this.menuitemCopyArgumentOfPerihelion.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (°)";
			this.menuitemCopyArgumentOfPerihelion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click);
			this.menuitemCopyArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyLongitudeOfTheAscendingNode
			// 
			this.menuitemCopyLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node";
			this.menuitemCopyLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node";
			this.menuitemCopyLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.menuitemCopyLongitudeOfTheAscendingNode.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyLongitudeOfTheAscendingNode.Image")));
			this.menuitemCopyLongitudeOfTheAscendingNode.Name = "menuitemCopyLongitudeOfTheAscendingNode";
			this.menuitemCopyLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0 (°)";
			this.menuitemCopyLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click);
			this.menuitemCopyLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyInclination
			// 
			this.menuitemCopyInclination.AccessibleDescription = "Copy to clipboard: Inclination";
			this.menuitemCopyInclination.AccessibleName = "Copy to clipboard: Inclination";
			this.menuitemCopyInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyInclination.AutoToolTip = true;
			this.menuitemCopyInclination.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyInclination.Image")));
			this.menuitemCopyInclination.Name = "menuitemCopyInclination";
			this.menuitemCopyInclination.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyInclination.Text = "Inclination to the ecliptic, J2000.0 (°)";
			this.menuitemCopyInclination.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardInclination_Click);
			this.menuitemCopyInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyEccentricity
			// 
			this.menuitemCopyEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyEccentricity.AutoToolTip = true;
			this.menuitemCopyEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyEccentricity.Image")));
			this.menuitemCopyEccentricity.Name = "menuitemCopyEccentricity";
			this.menuitemCopyEccentricity.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyEccentricity.Text = "Orbital eccentricity";
			this.menuitemCopyEccentricity.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click);
			this.menuitemCopyEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyMeanDailyMotion
			// 
			this.menuitemCopyMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyMeanDailyMotion.AutoToolTip = true;
			this.menuitemCopyMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyMeanDailyMotion.Image")));
			this.menuitemCopyMeanDailyMotion.Name = "menuitemCopyMeanDailyMotion";
			this.menuitemCopyMeanDailyMotion.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyMeanDailyMotion.Text = "Mean daily motion (°/day)";
			this.menuitemCopyMeanDailyMotion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click);
			this.menuitemCopyMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopySemiMajorAxis
			// 
			this.menuitemCopySemiMajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis";
			this.menuitemCopySemiMajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis";
			this.menuitemCopySemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopySemiMajorAxis.AutoToolTip = true;
			this.menuitemCopySemiMajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopySemiMajorAxis.Image")));
			this.menuitemCopySemiMajorAxis.Name = "menuitemCopySemiMajorAxis";
			this.menuitemCopySemiMajorAxis.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopySemiMajorAxis.Text = "Semi-major axis (AU)";
			this.menuitemCopySemiMajorAxis.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardSemimajorAxis_Click);
			this.menuitemCopySemiMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopySemiMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyAbsoluteMagnitude
			// 
			this.menuitemCopyAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyAbsoluteMagnitude.AutoToolTip = true;
			this.menuitemCopyAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyAbsoluteMagnitude.Image")));
			this.menuitemCopyAbsoluteMagnitude.Name = "menuitemCopyAbsoluteMagnitude";
			this.menuitemCopyAbsoluteMagnitude.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyAbsoluteMagnitude.Text = "Absolute magnitude, H";
			this.menuitemCopyAbsoluteMagnitude.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click);
			this.menuitemCopyAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopySlopeParameter
			// 
			this.menuitemCopySlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter";
			this.menuitemCopySlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter";
			this.menuitemCopySlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopySlopeParameter.AutoToolTip = true;
			this.menuitemCopySlopeParameter.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopySlopeParameter.Image")));
			this.menuitemCopySlopeParameter.Name = "menuitemCopySlopeParameter";
			this.menuitemCopySlopeParameter.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopySlopeParameter.Text = "Slope parameter, G";
			this.menuitemCopySlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopySlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyReference
			// 
			this.menuitemCopyReference.AccessibleDescription = "Copy to clipboard: Reference";
			this.menuitemCopyReference.AccessibleName = "Copy to clipboard: Reference";
			this.menuitemCopyReference.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyReference.AutoToolTip = true;
			this.menuitemCopyReference.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyReference.Image")));
			this.menuitemCopyReference.Name = "menuitemCopyReference";
			this.menuitemCopyReference.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyReference.Text = "Reference";
			this.menuitemCopyReference.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReference_Click);
			this.menuitemCopyReference.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyReference.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyNumberOfOppositions
			// 
			this.menuitemCopyNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			this.menuitemCopyNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions ";
			this.menuitemCopyNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyNumberOfOppositions.AutoToolTip = true;
			this.menuitemCopyNumberOfOppositions.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyNumberOfOppositions.Image")));
			this.menuitemCopyNumberOfOppositions.Name = "menuitemCopyNumberOfOppositions";
			this.menuitemCopyNumberOfOppositions.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemCopyNumberOfOppositions.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click);
			this.menuitemCopyNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyNumberOfObservations
			// 
			this.menuitemCopyNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			this.menuitemCopyNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			this.menuitemCopyNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyNumberOfObservations.AutoToolTip = true;
			this.menuitemCopyNumberOfObservations.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyNumberOfObservations.Image")));
			this.menuitemCopyNumberOfObservations.Name = "menuitemCopyNumberOfObservations";
			this.menuitemCopyNumberOfObservations.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyNumberOfObservations.Text = "Number of observations";
			this.menuitemCopyNumberOfObservations.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfObservations_Click);
			this.menuitemCopyNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyObservationSpan
			// 
			this.menuitemCopyObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.menuitemCopyObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.menuitemCopyObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyObservationSpan.AutoToolTip = true;
			this.menuitemCopyObservationSpan.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyObservationSpan.Image")));
			this.menuitemCopyObservationSpan.Name = "menuitemCopyObservationSpan";
			this.menuitemCopyObservationSpan.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyObservationSpan.Text = "Observation span";
			this.menuitemCopyObservationSpan.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardObservationSpan_Click);
			this.menuitemCopyObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyRmsResidual
			// 
			this.menuitemCopyRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual";
			this.menuitemCopyRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual";
			this.menuitemCopyRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyRmsResidual.AutoToolTip = true;
			this.menuitemCopyRmsResidual.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyRmsResidual.Image")));
			this.menuitemCopyRmsResidual.Name = "menuitemCopyRmsResidual";
			this.menuitemCopyRmsResidual.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyRmsResidual.Text = "r.m.s. residual (\")";
			this.menuitemCopyRmsResidual.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardRmsResidual_Click);
			this.menuitemCopyRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyComputerName
			// 
			this.menuitemCopyComputerName.AccessibleDescription = "Copy to clipboard: Computer name";
			this.menuitemCopyComputerName.AccessibleName = "Copy to clipboard: Computer name";
			this.menuitemCopyComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyComputerName.AutoToolTip = true;
			this.menuitemCopyComputerName.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyComputerName.Image")));
			this.menuitemCopyComputerName.Name = "menuitemCopyComputerName";
			this.menuitemCopyComputerName.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyComputerName.Text = "Computer name";
			this.menuitemCopyComputerName.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardComputername_Click);
			this.menuitemCopyComputerName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyComputerName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyDateOfLastObservation
			// 
			this.menuitemCopyDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation";
			this.menuitemCopyDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation";
			this.menuitemCopyDateOfLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyDateOfLastObservation.AutoToolTip = true;
			this.menuitemCopyDateOfLastObservation.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyDateOfLastObservation.Image")));
			this.menuitemCopyDateOfLastObservation.Name = "menuitemCopyDateOfLastObservation";
			this.menuitemCopyDateOfLastObservation.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyDateOfLastObservation.Text = "Date of last observation";
			this.menuitemCopyDateOfLastObservation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click);
			this.menuitemCopyDateOfLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyDateOfLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCopyFlags
			// 
			this.menuitemCopyFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCopyFlags.AutoToolTip = true;
			this.menuitemCopyFlags.Image = ((System.Drawing.Image)(resources.GetObject("menuitemCopyFlags.Image")));
			this.menuitemCopyFlags.Name = "menuitemCopyFlags";
			this.menuitemCopyFlags.Size = new System.Drawing.Size(308, 22);
			this.menuitemCopyFlags.Text = "4-hexdigit flags";
			this.menuitemCopyFlags.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardFlags_Click);
			this.menuitemCopyFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCopyFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator4.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator4.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripButtonDatabaseInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonDatabaseInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripButtonTableMode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonTableMode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonTerminology
			// 
			this.toolStripButtonTerminology.AccessibleDescription = "Show the terminology";
			this.toolStripButtonTerminology.AccessibleName = "Terminology";
			this.toolStripButtonTerminology.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonTerminology.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTerminology.DoubleClickEnabled = true;
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
			this.toolStripSeparator3.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator3.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator3.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator5.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator5.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripButtonCheckMpcorbDat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonCheckMpcorbDat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripButtonDownloadMpcorbDat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonDownloadMpcorbDat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator1
			// 
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
			this.toolStripButtonAbout.DoubleClickEnabled = true;
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
			this.toolStripButtonOpenWebsitePDB.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonOpenWebsitePDB.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator2
			// 
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
            this.menuitemSearchNumberOfObservation,
            this.menuitemSearchObservationSpan,
            this.menuitemSearchRmsResidual,
            this.menuitemSearchComputerName,
            this.menuitemSearchDateOfTheLastObservation,
            this.menuitemSearchFlags});
			this.splitbuttonSearch.Image = global::Planetoid_DB.Properties.Resources.silk_zoom;
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
			this.menuitemSearchReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchReference.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchNumberOfOppositions.Checked = true;
			this.menuitemSearchNumberOfOppositions.CheckOnClick = true;
			this.menuitemSearchNumberOfOppositions.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchNumberOfOppositions.Name = "menuitemSearchNumberOfOppositions";
			this.menuitemSearchNumberOfOppositions.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemSearchNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchNumberOfObservation
			// 
			this.menuitemSearchNumberOfObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchNumberOfObservation.Checked = true;
			this.menuitemSearchNumberOfObservation.CheckOnClick = true;
			this.menuitemSearchNumberOfObservation.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchNumberOfObservation.Name = "menuitemSearchNumberOfObservation";
			this.menuitemSearchNumberOfObservation.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchNumberOfObservation.Text = "Number of observations";
			this.menuitemSearchNumberOfObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchNumberOfObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemSearchObservationSpan
			// 
			this.menuitemSearchObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchDateOfTheLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
			this.menuitemSearchFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemSearchFlags.Checked = true;
			this.menuitemSearchFlags.CheckOnClick = true;
			this.menuitemSearchFlags.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuitemSearchFlags.Name = "menuitemSearchFlags";
			this.menuitemSearchFlags.Size = new System.Drawing.Size(308, 22);
			this.menuitemSearchFlags.Text = "4-hexdigit flags";
			this.menuitemSearchFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemSearchFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
            this.toolStripButtonDerivatedOrbitElements});
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
			this.toolStripButtonLoadRandomMinorPlanet.AccessibleDescription = "Load a random minor planet";
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
			this.toolStripSeparator8.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator8.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator8.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonStepToBegin
			// 
			this.toolStripButtonStepToBegin.AccessibleDescription = "Navigate to the begin of the data";
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
			this.toolStripButtonStepBackwardOne.AccessibleDescription = "Navigate to the previous data";
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
			this.toolStripButtonStepForwardOne.AccessibleDescription = "Navigate to the next data";
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
			this.toolStripButtonStepToEnd.AccessibleDescription = "Navigate to the end of the data";
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
			this.toolStripSeparator7.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator7.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator7.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripLabelIndexPosition
			// 
			this.toolStripLabelIndexPosition.AccessibleDescription = "Show the current index position";
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
			this.toolStripSeparator9.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator9.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator9.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripButtonDerivatedOrbitElements
			// 
			this.toolStripButtonDerivatedOrbitElements.AccessibleDescription = "Calculate derivated orbital elements";
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
			// toolStripContainer
			// 
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
			// timerCheckForNewMpcorbDatFile
			// 
			this.timerCheckForNewMpcorbDatFile.Enabled = true;
			this.timerCheckForNewMpcorbDatFile.Interval = 1440000;
			this.timerCheckForNewMpcorbDatFile.Tick += new System.EventHandler(this.TimerCheckForNewMpcorbDatFile_Tick);
			// 
			// PlanetoidDBForm
			// 
			this.AccessibleDescription = "Viewer for the MPC Orbit (MPCORB) Database";
			this.AccessibleName = "PlanetoidDB";
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanetoidDBForm_FormClosing);
			this.Load += new System.EventHandler(this.PlanetoidDBForm_Load);
			this.Shown += new System.EventHandler(this.PlanetoidDBForm_Shown);
			this.contextMenuNavigationStep.ResumeLayout(false);
			this.tableLayoutPanelData.ResumeLayout(false);
			this.tableLayoutPanelData.PerformLayout();
			this.contextMenuTopTenRecords.ResumeLayout(false);
			this.contextMenuDistributions.ResumeLayout(false);
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.toolStripIcons.ResumeLayout(false);
			this.toolStripIcons.PerformLayout();
			this.toolStripNavigation.ResumeLayout(false);
			this.toolStripNavigation.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.StatusStrip statusBar;
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
        private System.Windows.Forms.ToolStripMenuItem menuitemExportDataEntryAsTxt;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportDataEntryAsHtml;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportDataEntryAsXml;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportDataEntryAsJson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem menuitemTopTenRecords;
        private System.Windows.Forms.ToolStripMenuItem menuitemIconsetSilk;
        private System.Windows.Forms.ToolStripMenuItem menuitemIconsetFatcow;
        private System.Windows.Forms.ToolStripMenuItem menuitemIconsetFugue;
        private System.Windows.Forms.ToolStripMenuItem menuitemOpenALocalMpcorbdatFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardIndexNumber;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardReadableDesignation;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardEpoch;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardMeanAnomaly;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardArgumentOfPerihelion;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardLongitudeOfTheAscendingNode;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardInclination;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardEccentricity;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardMeanDailyMotion;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardSemimajorAxis;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardAbsoluteMagnitude;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardSlopeParameter;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardReference;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardNumberOfOppositions;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardNumberOfObservations;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardObservationSpan;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardRmsResidual;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardComputername;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardFlags;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyToClipboardDateOfLastObservation;
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
        private System.Windows.Forms.ToolStripSplitButton splitbuttonExport;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportAsTxt;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportAsHtml;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportAsXml;
        private System.Windows.Forms.ToolStripMenuItem menuitemExportAsJson;
        private System.Windows.Forms.ToolStripSplitButton splitbuttonCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyIndexNumber;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyReadableDesignation;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyEpoch;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyMeanAnomalyAtTheEpoch;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyArgumentOfPerihelion;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyLongitudeOfTheAscendingNode;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyInclination;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyEccentricity;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyMeanDailyMotion;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopySemiMajorAxis;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyAbsoluteMagnitude;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopySlopeParameter;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyReference;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyNumberOfOppositions;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyNumberOfObservations;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyObservationSpan;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyRmsResidual;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyComputerName;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyDateOfLastObservation;
        private System.Windows.Forms.ToolStripMenuItem menuitemCopyFlags;
		private KryptonLabel kryptonLabelIndexData;
		private KryptonLabel kryptonLabelDesignationNameData;
		private KryptonLabel kryptonLabelEpochData;
		private KryptonLabel kryptonLabelMeanAnomalyData;
		private KryptonLabel kryptonLabelArgumentPerihelionData;
		private KryptonLabel kryptonLabelLongitudeAscendingNodeData;
		private KryptonLabel kryptonLabelInclinationData;
		private KryptonLabel kryptonLabelOrbitalEccentricityData;
		private KryptonLabel kryptonLabelMeanDailyMotionData;
		private KryptonLabel kryptonLabelSemiMajorAxisData;
		private KryptonLabel kryptonLabelAbsoluteMagnitudeData;
		private KryptonLabel kryptonLabelSlopeParameterData;
		private KryptonLabel kryptonLabelReferenceData;
		private KryptonLabel kryptonLabelNumberOppositionsData;
		private KryptonLabel kryptonLabelNumberObservationsData;
		private KryptonLabel kryptonLabelObservationSpanData;
		private KryptonLabel kryptonLabelRmsResidualData;
		private KryptonLabel kryptonLabelComputerNameData;
		private KryptonLabel kryptonLabelFlagsData;
		private KryptonLabel kryptonLabelDateLastObservationData;
		private KryptonLabel kryptonLabelIndexDesc;
		private KryptonLabel kryptonLabelDesignationNameDesc;
		private KryptonLabel kryptonLabelEpochDesc;
		private KryptonLabel kryptonLabelMeanAnomalyDesc;
		private KryptonLabel kryptonLabelArgumentPerihelionDesc;
		private KryptonLabel kryptonLabelLongitudeAscendingNodeDesc;
		private KryptonLabel kryptonLabelInclinationDesc;
		private KryptonLabel kryptonLabelOrbitalEccentricityDesc;
		private KryptonLabel kryptonLabelMeanDailyMotionDesc;
		private KryptonLabel kryptonLabelSemiMajorAxisDesc;
		private KryptonLabel kryptonLabelAbsoluteMagnitudeDesc;
		private KryptonLabel kryptonLabelSlopeParameterDesc;
		private KryptonLabel kryptonLabelReferenceDesc;
		private KryptonLabel kryptonLabelNumberOppositionsDesc;
		private KryptonLabel kryptonLabelNumberObservationsDesc;
		private KryptonLabel kryptonLabelObservationSpanDesc;
		private KryptonLabel kryptonLabelRmsResidualDesc;
		private KryptonLabel kryptonLabelComputerNameDesc;
		private KryptonLabel kryptonLabelFlagsDesc;
		private KryptonLabel kryptonLabelDateLastObservationDesc;
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
		private System.Windows.Forms.ToolStripMenuItem menuitemSearchNumberOfObservation;
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
		private System.Windows.Forms.ToolStripMenuItem menuitemDistributionDateOfTheLastObservation;
	}
}

