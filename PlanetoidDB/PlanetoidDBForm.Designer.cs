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
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1000 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10000 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem100000 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNavigateSomeDataBackward = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNavigateSomeDataForward = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButtonStepForward = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSplitButtonStepBackward = new System.Windows.Forms.ToolStripSplitButton();
			this.tableLayoutPanelData = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.linkLabelDateLastObservationDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelFlagsDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelComputerNameDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelRmsResidualDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelObservationSpanDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelNumberObservationsDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelNumberOppositionsDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelReferenceDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelSlopeParameterDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelAbsoluteMagnitudeDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelSemiMajorAxisDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelMeanDailyMotionDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelOrbitalEccentricityDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelInclinationDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelLongitudeAscendingNodeDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelArgumentPerihelionDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelMeanAnomalyDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelEpochDesc = new System.Windows.Forms.LinkLabel();
			this.labelDesignationNameData = new System.Windows.Forms.Label();
			this.contextMenuCopyToClipboard = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelEpochData = new System.Windows.Forms.Label();
			this.labelMeanAnomalyData = new System.Windows.Forms.Label();
			this.labelArgumentPerihelionData = new System.Windows.Forms.Label();
			this.labelLongitudeAscendingNodeData = new System.Windows.Forms.Label();
			this.labelInclinationData = new System.Windows.Forms.Label();
			this.labelOrbitalEccentricityData = new System.Windows.Forms.Label();
			this.labelMeanDailyMotionData = new System.Windows.Forms.Label();
			this.labelSemiMajorAxisData = new System.Windows.Forms.Label();
			this.labelSlopeParameterData = new System.Windows.Forms.Label();
			this.labelIndexData = new System.Windows.Forms.Label();
			this.labelAbsoluteMagnitudeData = new System.Windows.Forms.Label();
			this.labelReferenceData = new System.Windows.Forms.Label();
			this.labelNumberOppositionsData = new System.Windows.Forms.Label();
			this.labelNumberObservationsData = new System.Windows.Forms.Label();
			this.labelObservationSpanData = new System.Windows.Forms.Label();
			this.labelRmsResidualData = new System.Windows.Forms.Label();
			this.labelComputerNameData = new System.Windows.Forms.Label();
			this.labelFlagsData = new System.Windows.Forms.Label();
			this.labelDateLastObservationData = new System.Windows.Forms.Label();
			this.linkLabelIndexDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelDesignationNameDesc = new System.Windows.Forms.LinkLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelUpdate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBarBackgroundDownload = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelCancelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.menuitemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemOpenALocalMpcorbdatFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.exportDataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExportDataEntryAsTxt = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExportDataEntryAsHtml = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExportDataEntryAsXml = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExportDataEntryAsJson = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemRestart = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopytoClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardIndexNumber = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardReadableDesignation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardMeanAnomaly = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardInclination = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardSemimajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardSlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardReference = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardComputername = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyToClipboardFlags = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemRandomMinorPlanet = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorNavigation1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemNavigateToTheBeginning = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNavigateToThePreviousData = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNavigateToTheNextData = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNavigateToTheEnd = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDerivatedOrbitElements = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorTools1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sortDirectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.meanAnomalyAtTheEpochToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.argumentOfThePerihelionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longitudeTheTheAscendingNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inclinationToTheEclipticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.orbitalEccentricityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.meanDailyMotionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.semimajorAxisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.absoluteMagnitudeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.slopeParameterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.numberOfOppositionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.numberOfObservationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.observationSpanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.rmsResidualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.computerNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.dateOfTheLastObservationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.chartBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.meanAnomalyAtTheEpochToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.argumentOfPerihelionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longitudeOfTheAscendingNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inclinationToTheEclipticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.orbitalEccentricityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.meanDailyMotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.semimajorAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.absoluteMagnitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.slopeParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.numberOfOppositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.numberOfObservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.observationSpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rmsResiduaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.computerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dateOfTheLastObservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorTools2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemDatabaseInformation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTableMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTerminology = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemCheckMpcorbDat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemStyle = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemIconsetSilk = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemIconsetFugue = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemIconsetFatcow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorOptions = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemStayOnTop = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemEnabledCopyingByDoubleClicking = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemEnableLinkingToTerminology = new System.Windows.Forms.ToolStripMenuItem();
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
			this.toolStripSplitButtonExport = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemExportAsTxt = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExportAsHtml = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExportAsXml = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExportAsJson = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButtonCopyToClipboard = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemCopyIndexNumber = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyReadableDesignation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyArgumentOfPerihelion = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyInclination = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyEccentricity = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyMeanDailyMotion = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopySemimajorAxis = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyAbsoluteMagnitude = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopySlopeParameter = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyReference = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyNumberOfOppositions = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyNumberOfObservations = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyObservationSpan = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyRmsResidual = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyComputername = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyDateOfLastObservation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyFlags = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonDatabaseInformation = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTableMode = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTerminology = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonCheckMpcorbDat = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDownloadMpcorbDat = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpenWebsitePDB = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelQuickSearch = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
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
			this.contextMenuCopyToClipboard.SuspendLayout();
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
			this.contextMenuNavigationStep.AccessibleDescription = "Show the context name of data items";
			this.contextMenuNavigationStep.AccessibleName = "Context menu of items";
			this.contextMenuNavigationStep.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuNavigationStep.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuNavigationStep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem100,
            this.toolStripMenuItem1000,
            this.toolStripMenuItem10000,
            this.toolStripMenuItem100000});
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
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.AccessibleDescription = "Jump 10 items backward/forward";
			this.toolStripMenuItem10.AccessibleName = "Jump 10 items backward/forward";
			this.toolStripMenuItem10.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItem10.CheckOnClick = true;
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem10.Text = "10";
			this.toolStripMenuItem10.ToolTipText = "Jump 10 items backward/forward";
			this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
			this.toolStripMenuItem10.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem10.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem100
			// 
			this.toolStripMenuItem100.AccessibleDescription = "Jump 100 items backward/forward";
			this.toolStripMenuItem100.AccessibleName = "Jump 100 items backward/forward";
			this.toolStripMenuItem100.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItem100.Checked = true;
			this.toolStripMenuItem100.CheckOnClick = true;
			this.toolStripMenuItem100.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItem100.Name = "toolStripMenuItem100";
			this.toolStripMenuItem100.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem100.Text = "100";
			this.toolStripMenuItem100.ToolTipText = "Jump 100 items backward/forward";
			this.toolStripMenuItem100.Click += new System.EventHandler(this.ToolStripMenuItem100_Click);
			this.toolStripMenuItem100.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem100.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem1000
			// 
			this.toolStripMenuItem1000.AccessibleDescription = "Jump 1000 items backward/forward";
			this.toolStripMenuItem1000.AccessibleName = "Jump 1000 items backward/forward";
			this.toolStripMenuItem1000.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItem1000.CheckOnClick = true;
			this.toolStripMenuItem1000.Name = "toolStripMenuItem1000";
			this.toolStripMenuItem1000.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem1000.Text = "1000";
			this.toolStripMenuItem1000.ToolTipText = "Jump 1000 items backward/forward";
			this.toolStripMenuItem1000.Click += new System.EventHandler(this.ToolStripMenuItem1000_Click);
			this.toolStripMenuItem1000.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem1000.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem10000
			// 
			this.toolStripMenuItem10000.AccessibleDescription = "Jump 10000 items backward/forward";
			this.toolStripMenuItem10000.AccessibleName = "Jump 10000 items backward/forward";
			this.toolStripMenuItem10000.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItem10000.CheckOnClick = true;
			this.toolStripMenuItem10000.Name = "toolStripMenuItem10000";
			this.toolStripMenuItem10000.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem10000.Text = "10000";
			this.toolStripMenuItem10000.ToolTipText = "Jump 10000 items backward/forward";
			this.toolStripMenuItem10000.Click += new System.EventHandler(this.ToolStripMenuItem10000_Click);
			this.toolStripMenuItem10000.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem10000.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem100000
			// 
			this.toolStripMenuItem100000.AccessibleDescription = "Jump 100000 items backward/forward";
			this.toolStripMenuItem100000.AccessibleName = "Jump 100000 items backward/forward";
			this.toolStripMenuItem100000.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItem100000.CheckOnClick = true;
			this.toolStripMenuItem100000.Name = "toolStripMenuItem100000";
			this.toolStripMenuItem100000.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem100000.Text = "100000";
			this.toolStripMenuItem100000.ToolTipText = "Jump 100000 items backward/forward";
			this.toolStripMenuItem100000.Click += new System.EventHandler(this.ToolStripMenuItem100000_Click);
			this.toolStripMenuItem100000.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem100000.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemNavigateSomeDataBackward
			// 
			this.toolStripMenuItemNavigateSomeDataBackward.AccessibleDescription = "Navigate some data backward";
			this.toolStripMenuItemNavigateSomeDataBackward.AccessibleName = "Navigate some data backward";
			this.toolStripMenuItemNavigateSomeDataBackward.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemNavigateSomeDataBackward.AutoToolTip = true;
			this.toolStripMenuItemNavigateSomeDataBackward.DoubleClickEnabled = true;
			this.toolStripMenuItemNavigateSomeDataBackward.DropDown = this.contextMenuNavigationStep;
			this.toolStripMenuItemNavigateSomeDataBackward.Image = global::Planetoid_DB.Properties.Resources.silk_backward_green;
			this.toolStripMenuItemNavigateSomeDataBackward.Name = "toolStripMenuItemNavigateSomeDataBackward";
			this.toolStripMenuItemNavigateSomeDataBackward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
			this.toolStripMenuItemNavigateSomeDataBackward.Size = new System.Drawing.Size(274, 22);
			this.toolStripMenuItemNavigateSomeDataBackward.Text = "Navigate some data back&ward";
			this.toolStripMenuItemNavigateSomeDataBackward.Click += new System.EventHandler(this.ToolStripMenuItemNavigateSomeDataBackward_Click);
			this.toolStripMenuItemNavigateSomeDataBackward.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemNavigateSomeDataBackward.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemNavigateSomeDataForward
			// 
			this.toolStripMenuItemNavigateSomeDataForward.AccessibleDescription = "Navigate some data forward";
			this.toolStripMenuItemNavigateSomeDataForward.AccessibleName = "Navigate some data forward";
			this.toolStripMenuItemNavigateSomeDataForward.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemNavigateSomeDataForward.AutoToolTip = true;
			this.toolStripMenuItemNavigateSomeDataForward.DoubleClickEnabled = true;
			this.toolStripMenuItemNavigateSomeDataForward.DropDown = this.contextMenuNavigationStep;
			this.toolStripMenuItemNavigateSomeDataForward.Image = global::Planetoid_DB.Properties.Resources.silk_forward_green;
			this.toolStripMenuItemNavigateSomeDataForward.Name = "toolStripMenuItemNavigateSomeDataForward";
			this.toolStripMenuItemNavigateSomeDataForward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.toolStripMenuItemNavigateSomeDataForward.Size = new System.Drawing.Size(274, 22);
			this.toolStripMenuItemNavigateSomeDataForward.Text = "Navigate some data &forward";
			this.toolStripMenuItemNavigateSomeDataForward.Click += new System.EventHandler(this.ToolStripMenuItemNavigateSomeDataForward_Click);
			this.toolStripMenuItemNavigateSomeDataForward.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemNavigateSomeDataForward.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.tableLayoutPanelData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.tableLayoutPanelData.ColumnCount = 4;
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelData.Controls.Add(this.linkLabelDateLastObservationDesc, 2, 9);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelFlagsDesc, 2, 8);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelComputerNameDesc, 2, 7);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelRmsResidualDesc, 2, 6);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelObservationSpanDesc, 2, 5);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelNumberObservationsDesc, 2, 4);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelNumberOppositionsDesc, 2, 3);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelReferenceDesc, 2, 2);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelSlopeParameterDesc, 2, 1);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelAbsoluteMagnitudeDesc, 0, 10);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelSemiMajorAxisDesc, 0, 9);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelMeanDailyMotionDesc, 0, 8);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelOrbitalEccentricityDesc, 0, 7);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelInclinationDesc, 0, 6);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelLongitudeAscendingNodeDesc, 0, 5);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelArgumentPerihelionDesc, 0, 4);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelMeanAnomalyDesc, 0, 3);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelEpochDesc, 0, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelDesignationNameData, 1, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelEpochData, 1, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanAnomalyData, 1, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelArgumentPerihelionData, 1, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelLongitudeAscendingNodeData, 1, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelInclinationData, 1, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelOrbitalEccentricityData, 1, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelMeanDailyMotionData, 1, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelSemiMajorAxisData, 1, 9);
			this.tableLayoutPanelData.Controls.Add(this.labelSlopeParameterData, 3, 1);
			this.tableLayoutPanelData.Controls.Add(this.labelIndexData, 1, 0);
			this.tableLayoutPanelData.Controls.Add(this.labelAbsoluteMagnitudeData, 1, 10);
			this.tableLayoutPanelData.Controls.Add(this.labelReferenceData, 3, 2);
			this.tableLayoutPanelData.Controls.Add(this.labelNumberOppositionsData, 3, 3);
			this.tableLayoutPanelData.Controls.Add(this.labelNumberObservationsData, 3, 4);
			this.tableLayoutPanelData.Controls.Add(this.labelObservationSpanData, 3, 5);
			this.tableLayoutPanelData.Controls.Add(this.labelRmsResidualData, 3, 6);
			this.tableLayoutPanelData.Controls.Add(this.labelComputerNameData, 3, 7);
			this.tableLayoutPanelData.Controls.Add(this.labelFlagsData, 3, 8);
			this.tableLayoutPanelData.Controls.Add(this.labelDateLastObservationData, 3, 9);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelIndexDesc, 0, 0);
			this.tableLayoutPanelData.Controls.Add(this.linkLabelDesignationNameDesc, 0, 1);
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
			this.tableLayoutPanelData.Size = new System.Drawing.Size(770, 235);
			this.tableLayoutPanelData.TabIndex = 0;
			this.tableLayoutPanelData.TabStop = true;
			// 
			// linkLabelDateLastObservationDesc
			// 
			this.linkLabelDateLastObservationDesc.AccessibleDescription = "Date of last observation (YYYYMMDD)";
			this.linkLabelDateLastObservationDesc.AccessibleName = "Date of last observation (YYYYMMDD)";
			this.linkLabelDateLastObservationDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelDateLastObservationDesc.AutoEllipsis = true;
			this.linkLabelDateLastObservationDesc.AutoSize = true;
			this.linkLabelDateLastObservationDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelDateLastObservationDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelDateLastObservationDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelDateLastObservationDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelDateLastObservationDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelDateLastObservationDesc.Location = new System.Drawing.Point(405, 191);
			this.linkLabelDateLastObservationDesc.Name = "linkLabelDateLastObservationDesc";
			this.linkLabelDateLastObservationDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelDateLastObservationDesc.TabIndex = 38;
			this.linkLabelDateLastObservationDesc.TabStop = true;
			this.linkLabelDateLastObservationDesc.Text = "Date of last observation (YYYMMDD)";
			this.linkLabelDateLastObservationDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelDateLastObservationDesc, "Date of last observation (YYYYMMDD)");
			this.linkLabelDateLastObservationDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelObsLastDate_Click);
			this.linkLabelDateLastObservationDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelDateLastObservationDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelDateLastObservationDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelDateLastObservationDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelFlagsDesc
			// 
			this.linkLabelFlagsDesc.AccessibleDescription = "4-hexdigit flags";
			this.linkLabelFlagsDesc.AccessibleName = "4-hexdigit flags";
			this.linkLabelFlagsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelFlagsDesc.AutoEllipsis = true;
			this.linkLabelFlagsDesc.AutoSize = true;
			this.linkLabelFlagsDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelFlagsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelFlagsDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelFlagsDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelFlagsDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelFlagsDesc.Location = new System.Drawing.Point(405, 170);
			this.linkLabelFlagsDesc.Name = "linkLabelFlagsDesc";
			this.linkLabelFlagsDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelFlagsDesc.TabIndex = 36;
			this.linkLabelFlagsDesc.TabStop = true;
			this.linkLabelFlagsDesc.Text = "4-hexdigit flags";
			this.linkLabelFlagsDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelFlagsDesc, "4-hexdigit flags");
			this.linkLabelFlagsDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelFlags_Click);
			this.linkLabelFlagsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelFlagsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelFlagsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelFlagsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelComputerNameDesc
			// 
			this.linkLabelComputerNameDesc.AccessibleDescription = "Computer name";
			this.linkLabelComputerNameDesc.AccessibleName = "Computer name";
			this.linkLabelComputerNameDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelComputerNameDesc.AutoEllipsis = true;
			this.linkLabelComputerNameDesc.AutoSize = true;
			this.linkLabelComputerNameDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelComputerNameDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelComputerNameDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelComputerNameDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelComputerNameDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelComputerNameDesc.Location = new System.Drawing.Point(405, 149);
			this.linkLabelComputerNameDesc.Name = "linkLabelComputerNameDesc";
			this.linkLabelComputerNameDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelComputerNameDesc.TabIndex = 34;
			this.linkLabelComputerNameDesc.TabStop = true;
			this.linkLabelComputerNameDesc.Text = "Computer name";
			this.linkLabelComputerNameDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelComputerNameDesc, "Computer name");
			this.linkLabelComputerNameDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelComputerName_Click);
			this.linkLabelComputerNameDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelComputerNameDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelComputerNameDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelComputerNameDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelRmsResidualDesc
			// 
			this.linkLabelRmsResidualDesc.AccessibleDescription = "r.m.s. residual (\")";
			this.linkLabelRmsResidualDesc.AccessibleName = "r.m.s. residual (\")";
			this.linkLabelRmsResidualDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelRmsResidualDesc.AutoEllipsis = true;
			this.linkLabelRmsResidualDesc.AutoSize = true;
			this.linkLabelRmsResidualDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelRmsResidualDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelRmsResidualDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelRmsResidualDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelRmsResidualDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelRmsResidualDesc.Location = new System.Drawing.Point(405, 128);
			this.linkLabelRmsResidualDesc.Name = "linkLabelRmsResidualDesc";
			this.linkLabelRmsResidualDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelRmsResidualDesc.TabIndex = 32;
			this.linkLabelRmsResidualDesc.TabStop = true;
			this.linkLabelRmsResidualDesc.Text = "r.m.s. residual (\")";
			this.linkLabelRmsResidualDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelRmsResidualDesc, "r.m.s. residual (\")");
			this.linkLabelRmsResidualDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelRmsResidual_Click);
			this.linkLabelRmsResidualDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelRmsResidualDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelRmsResidualDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelRmsResidualDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelObservationSpanDesc
			// 
			this.linkLabelObservationSpanDesc.AccessibleDescription = "Observation span";
			this.linkLabelObservationSpanDesc.AccessibleName = "Observation span";
			this.linkLabelObservationSpanDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelObservationSpanDesc.AutoEllipsis = true;
			this.linkLabelObservationSpanDesc.AutoSize = true;
			this.linkLabelObservationSpanDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelObservationSpanDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelObservationSpanDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelObservationSpanDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelObservationSpanDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelObservationSpanDesc.Location = new System.Drawing.Point(405, 107);
			this.linkLabelObservationSpanDesc.Name = "linkLabelObservationSpanDesc";
			this.linkLabelObservationSpanDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelObservationSpanDesc.TabIndex = 30;
			this.linkLabelObservationSpanDesc.TabStop = true;
			this.linkLabelObservationSpanDesc.Text = "Observation span";
			this.linkLabelObservationSpanDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelObservationSpanDesc, "Observation span");
			this.linkLabelObservationSpanDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelObsSpan_Click);
			this.linkLabelObservationSpanDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelObservationSpanDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelObservationSpanDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelObservationSpanDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelNumberObservationsDesc
			// 
			this.linkLabelNumberObservationsDesc.AccessibleDescription = "Number of observations";
			this.linkLabelNumberObservationsDesc.AccessibleName = "Number of observations";
			this.linkLabelNumberObservationsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelNumberObservationsDesc.AutoEllipsis = true;
			this.linkLabelNumberObservationsDesc.AutoSize = true;
			this.linkLabelNumberObservationsDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelNumberObservationsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelNumberObservationsDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelNumberObservationsDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelNumberObservationsDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelNumberObservationsDesc.Location = new System.Drawing.Point(405, 86);
			this.linkLabelNumberObservationsDesc.Name = "linkLabelNumberObservationsDesc";
			this.linkLabelNumberObservationsDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelNumberObservationsDesc.TabIndex = 28;
			this.linkLabelNumberObservationsDesc.TabStop = true;
			this.linkLabelNumberObservationsDesc.Text = "Number of observations";
			this.linkLabelNumberObservationsDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelNumberObservationsDesc, "Number of observations");
			this.linkLabelNumberObservationsDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelNumbObs_Click);
			this.linkLabelNumberObservationsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelNumberObservationsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelNumberObservationsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelNumberObservationsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelNumberOppositionsDesc
			// 
			this.linkLabelNumberOppositionsDesc.AccessibleDescription = "Number of oppositions";
			this.linkLabelNumberOppositionsDesc.AccessibleName = "Number of oppositions";
			this.linkLabelNumberOppositionsDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelNumberOppositionsDesc.AutoEllipsis = true;
			this.linkLabelNumberOppositionsDesc.AutoSize = true;
			this.linkLabelNumberOppositionsDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelNumberOppositionsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelNumberOppositionsDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelNumberOppositionsDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelNumberOppositionsDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelNumberOppositionsDesc.Location = new System.Drawing.Point(405, 65);
			this.linkLabelNumberOppositionsDesc.Name = "linkLabelNumberOppositionsDesc";
			this.linkLabelNumberOppositionsDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelNumberOppositionsDesc.TabIndex = 26;
			this.linkLabelNumberOppositionsDesc.TabStop = true;
			this.linkLabelNumberOppositionsDesc.Text = "Number of oppositions";
			this.linkLabelNumberOppositionsDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelNumberOppositionsDesc, "Number of oppositions");
			this.linkLabelNumberOppositionsDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelNumbOppos_Enter);
			this.linkLabelNumberOppositionsDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelNumberOppositionsDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelNumberOppositionsDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelNumberOppositionsDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelReferenceDesc
			// 
			this.linkLabelReferenceDesc.AccessibleDescription = "Reference";
			this.linkLabelReferenceDesc.AccessibleName = "Reference";
			this.linkLabelReferenceDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelReferenceDesc.AutoEllipsis = true;
			this.linkLabelReferenceDesc.AutoSize = true;
			this.linkLabelReferenceDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelReferenceDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelReferenceDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelReferenceDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelReferenceDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelReferenceDesc.Location = new System.Drawing.Point(405, 44);
			this.linkLabelReferenceDesc.Name = "linkLabelReferenceDesc";
			this.linkLabelReferenceDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelReferenceDesc.TabIndex = 24;
			this.linkLabelReferenceDesc.TabStop = true;
			this.linkLabelReferenceDesc.Text = "Reference";
			this.linkLabelReferenceDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelReferenceDesc, "Reference");
			this.linkLabelReferenceDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelRef_Click);
			this.linkLabelReferenceDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelReferenceDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelReferenceDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelReferenceDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSlopeParameterDesc
			// 
			this.linkLabelSlopeParameterDesc.AccessibleDescription = "Slope parameter, G";
			this.linkLabelSlopeParameterDesc.AccessibleName = "Slope parameter, G";
			this.linkLabelSlopeParameterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSlopeParameterDesc.AutoEllipsis = true;
			this.linkLabelSlopeParameterDesc.AutoSize = true;
			this.linkLabelSlopeParameterDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelSlopeParameterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSlopeParameterDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelSlopeParameterDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSlopeParameterDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSlopeParameterDesc.Location = new System.Drawing.Point(405, 23);
			this.linkLabelSlopeParameterDesc.Name = "linkLabelSlopeParameterDesc";
			this.linkLabelSlopeParameterDesc.Size = new System.Drawing.Size(201, 19);
			this.linkLabelSlopeParameterDesc.TabIndex = 22;
			this.linkLabelSlopeParameterDesc.TabStop = true;
			this.linkLabelSlopeParameterDesc.Text = "Slope parameter, G";
			this.linkLabelSlopeParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelSlopeParameterDesc, "Slope parameter, G");
			this.linkLabelSlopeParameterDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelSlopeParam_Click);
			this.linkLabelSlopeParameterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSlopeParameterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSlopeParameterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSlopeParameterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelAbsoluteMagnitudeDesc
			// 
			this.linkLabelAbsoluteMagnitudeDesc.AccessibleDescription = "Absolute magnitude, H";
			this.linkLabelAbsoluteMagnitudeDesc.AccessibleName = "Absolute magnitude, H";
			this.linkLabelAbsoluteMagnitudeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelAbsoluteMagnitudeDesc.AutoEllipsis = true;
			this.linkLabelAbsoluteMagnitudeDesc.AutoSize = true;
			this.linkLabelAbsoluteMagnitudeDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelAbsoluteMagnitudeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelAbsoluteMagnitudeDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelAbsoluteMagnitudeDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelAbsoluteMagnitudeDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelAbsoluteMagnitudeDesc.Location = new System.Drawing.Point(5, 212);
			this.linkLabelAbsoluteMagnitudeDesc.Name = "linkLabelAbsoluteMagnitudeDesc";
			this.linkLabelAbsoluteMagnitudeDesc.Size = new System.Drawing.Size(241, 21);
			this.linkLabelAbsoluteMagnitudeDesc.TabIndex = 20;
			this.linkLabelAbsoluteMagnitudeDesc.TabStop = true;
			this.linkLabelAbsoluteMagnitudeDesc.Text = "Absolute magnitude, H";
			this.linkLabelAbsoluteMagnitudeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelAbsoluteMagnitudeDesc, "Absolute magnitude, H");
			this.linkLabelAbsoluteMagnitudeDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelMagAbs_Enter);
			this.linkLabelAbsoluteMagnitudeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelAbsoluteMagnitudeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelAbsoluteMagnitudeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelAbsoluteMagnitudeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSemiMajorAxisDesc
			// 
			this.linkLabelSemiMajorAxisDesc.AccessibleDescription = "Semi-major axis (AU)";
			this.linkLabelSemiMajorAxisDesc.AccessibleName = "Semi-major axis (AU)";
			this.linkLabelSemiMajorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSemiMajorAxisDesc.AutoEllipsis = true;
			this.linkLabelSemiMajorAxisDesc.AutoSize = true;
			this.linkLabelSemiMajorAxisDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelSemiMajorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSemiMajorAxisDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelSemiMajorAxisDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSemiMajorAxisDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSemiMajorAxisDesc.Location = new System.Drawing.Point(5, 191);
			this.linkLabelSemiMajorAxisDesc.Name = "linkLabelSemiMajorAxisDesc";
			this.linkLabelSemiMajorAxisDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelSemiMajorAxisDesc.TabIndex = 18;
			this.linkLabelSemiMajorAxisDesc.TabStop = true;
			this.linkLabelSemiMajorAxisDesc.Text = "Semi-major axis (AU)";
			this.linkLabelSemiMajorAxisDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelSemiMajorAxisDesc, "Semi-major axis (AU)");
			this.linkLabelSemiMajorAxisDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelSemiMajorAxis_Click);
			this.linkLabelSemiMajorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMajorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSemiMajorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMajorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMeanDailyMotionDesc
			// 
			this.linkLabelMeanDailyMotionDesc.AccessibleDescription = "Mean daily motion (degrees per day)";
			this.linkLabelMeanDailyMotionDesc.AccessibleName = "Mean daily motion (degrees per day)";
			this.linkLabelMeanDailyMotionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMeanDailyMotionDesc.AutoEllipsis = true;
			this.linkLabelMeanDailyMotionDesc.AutoSize = true;
			this.linkLabelMeanDailyMotionDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelMeanDailyMotionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMeanDailyMotionDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelMeanDailyMotionDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMeanDailyMotionDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMeanDailyMotionDesc.Location = new System.Drawing.Point(5, 170);
			this.linkLabelMeanDailyMotionDesc.Name = "linkLabelMeanDailyMotionDesc";
			this.linkLabelMeanDailyMotionDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelMeanDailyMotionDesc.TabIndex = 16;
			this.linkLabelMeanDailyMotionDesc.TabStop = true;
			this.linkLabelMeanDailyMotionDesc.Text = "Mean daily motion (°/day)";
			this.linkLabelMeanDailyMotionDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelMeanDailyMotionDesc, "Mean daily motion (degrees per day)");
			this.linkLabelMeanDailyMotionDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelMotion_Enter);
			this.linkLabelMeanDailyMotionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanDailyMotionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMeanDailyMotionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanDailyMotionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelOrbitalEccentricityDesc
			// 
			this.linkLabelOrbitalEccentricityDesc.AccessibleDescription = "Orbital eccentricity";
			this.linkLabelOrbitalEccentricityDesc.AccessibleName = "Orbital eccentricity";
			this.linkLabelOrbitalEccentricityDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelOrbitalEccentricityDesc.AutoEllipsis = true;
			this.linkLabelOrbitalEccentricityDesc.AutoSize = true;
			this.linkLabelOrbitalEccentricityDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelOrbitalEccentricityDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelOrbitalEccentricityDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelOrbitalEccentricityDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelOrbitalEccentricityDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelOrbitalEccentricityDesc.Location = new System.Drawing.Point(5, 149);
			this.linkLabelOrbitalEccentricityDesc.Name = "linkLabelOrbitalEccentricityDesc";
			this.linkLabelOrbitalEccentricityDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelOrbitalEccentricityDesc.TabIndex = 14;
			this.linkLabelOrbitalEccentricityDesc.TabStop = true;
			this.linkLabelOrbitalEccentricityDesc.Text = "Orbital eccentricity";
			this.linkLabelOrbitalEccentricityDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelOrbitalEccentricityDesc, "Orbital eccentricity");
			this.linkLabelOrbitalEccentricityDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelOrbEcc_Enter);
			this.linkLabelOrbitalEccentricityDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalEccentricityDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelOrbitalEccentricityDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalEccentricityDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelInclinationDesc
			// 
			this.linkLabelInclinationDesc.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.linkLabelInclinationDesc.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.linkLabelInclinationDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelInclinationDesc.AutoEllipsis = true;
			this.linkLabelInclinationDesc.AutoSize = true;
			this.linkLabelInclinationDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelInclinationDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelInclinationDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelInclinationDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelInclinationDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelInclinationDesc.Location = new System.Drawing.Point(5, 128);
			this.linkLabelInclinationDesc.Name = "linkLabelInclinationDesc";
			this.linkLabelInclinationDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelInclinationDesc.TabIndex = 12;
			this.linkLabelInclinationDesc.TabStop = true;
			this.linkLabelInclinationDesc.Text = "Inclination to the ecliptic, J2000.0 (°)";
			this.linkLabelInclinationDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelInclinationDesc, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.linkLabelInclinationDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelIncl_Enter);
			this.linkLabelInclinationDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelInclinationDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelInclinationDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelInclinationDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelLongitudeAscendingNodeDesc
			// 
			this.linkLabelLongitudeAscendingNodeDesc.AccessibleDescription = "Longitude of the ascending node, J2000.0 (degrees)";
			this.linkLabelLongitudeAscendingNodeDesc.AccessibleName = "Longitude of the ascending node, J2000.0 (degrees)";
			this.linkLabelLongitudeAscendingNodeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelLongitudeAscendingNodeDesc.AutoEllipsis = true;
			this.linkLabelLongitudeAscendingNodeDesc.AutoSize = true;
			this.linkLabelLongitudeAscendingNodeDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelLongitudeAscendingNodeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelLongitudeAscendingNodeDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelLongitudeAscendingNodeDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelLongitudeAscendingNodeDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelLongitudeAscendingNodeDesc.Location = new System.Drawing.Point(5, 107);
			this.linkLabelLongitudeAscendingNodeDesc.Name = "linkLabelLongitudeAscendingNodeDesc";
			this.linkLabelLongitudeAscendingNodeDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelLongitudeAscendingNodeDesc.TabIndex = 10;
			this.linkLabelLongitudeAscendingNodeDesc.TabStop = true;
			this.linkLabelLongitudeAscendingNodeDesc.Text = "Longitude of the ascending node, J2000.0 (°)";
			this.linkLabelLongitudeAscendingNodeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelLongitudeAscendingNodeDesc, "Longitude of the ascending node, J2000.0 (degrees)");
			this.linkLabelLongitudeAscendingNodeDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelLongAscNode_Click);
			this.linkLabelLongitudeAscendingNodeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLongitudeAscendingNodeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelLongitudeAscendingNodeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLongitudeAscendingNodeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelArgumentPerihelionDesc
			// 
			this.linkLabelArgumentPerihelionDesc.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			this.linkLabelArgumentPerihelionDesc.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			this.linkLabelArgumentPerihelionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelArgumentPerihelionDesc.AutoEllipsis = true;
			this.linkLabelArgumentPerihelionDesc.AutoSize = true;
			this.linkLabelArgumentPerihelionDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelArgumentPerihelionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelArgumentPerihelionDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelArgumentPerihelionDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelArgumentPerihelionDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelArgumentPerihelionDesc.Location = new System.Drawing.Point(5, 86);
			this.linkLabelArgumentPerihelionDesc.Name = "linkLabelArgumentPerihelionDesc";
			this.linkLabelArgumentPerihelionDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelArgumentPerihelionDesc.TabIndex = 8;
			this.linkLabelArgumentPerihelionDesc.TabStop = true;
			this.linkLabelArgumentPerihelionDesc.Text = "Argument of perihelion, J2000.0 (°)";
			this.linkLabelArgumentPerihelionDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelArgumentPerihelionDesc, "Argument of perihelion, J2000.0 (degrees)");
			this.linkLabelArgumentPerihelionDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelArgPeri_Click);
			this.linkLabelArgumentPerihelionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelArgumentPerihelionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelArgumentPerihelionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelArgumentPerihelionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMeanAnomalyDesc
			// 
			this.linkLabelMeanAnomalyDesc.AccessibleDescription = "Mean anomaly at the epoch (degrees)";
			this.linkLabelMeanAnomalyDesc.AccessibleName = "Mean anomaly at the epoch (degrees)";
			this.linkLabelMeanAnomalyDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMeanAnomalyDesc.AutoEllipsis = true;
			this.linkLabelMeanAnomalyDesc.AutoSize = true;
			this.linkLabelMeanAnomalyDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelMeanAnomalyDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMeanAnomalyDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelMeanAnomalyDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMeanAnomalyDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMeanAnomalyDesc.Location = new System.Drawing.Point(5, 65);
			this.linkLabelMeanAnomalyDesc.Name = "linkLabelMeanAnomalyDesc";
			this.linkLabelMeanAnomalyDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelMeanAnomalyDesc.TabIndex = 6;
			this.linkLabelMeanAnomalyDesc.TabStop = true;
			this.linkLabelMeanAnomalyDesc.Text = "Mean anomaly at the epoch (°)";
			this.linkLabelMeanAnomalyDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelMeanAnomalyDesc, "Mean anomaly at the epoch (degrees)");
			this.linkLabelMeanAnomalyDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelMeanAnomaly_Click);
			this.linkLabelMeanAnomalyDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanAnomalyDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMeanAnomalyDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanAnomalyDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelEpochDesc
			// 
			this.linkLabelEpochDesc.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			this.linkLabelEpochDesc.AccessibleName = "Epoch (in packed form, .0 TT)";
			this.linkLabelEpochDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelEpochDesc.AutoEllipsis = true;
			this.linkLabelEpochDesc.AutoSize = true;
			this.linkLabelEpochDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelEpochDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelEpochDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelEpochDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelEpochDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelEpochDesc.Location = new System.Drawing.Point(5, 44);
			this.linkLabelEpochDesc.Name = "linkLabelEpochDesc";
			this.linkLabelEpochDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelEpochDesc.TabIndex = 4;
			this.linkLabelEpochDesc.TabStop = true;
			this.linkLabelEpochDesc.Text = "Epoch (in packed form, .0 TT)";
			this.linkLabelEpochDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelEpochDesc, "Epoch (in packed form, .0 TT)");
			this.linkLabelEpochDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelEpoch_Click);
			this.linkLabelEpochDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEpochDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelEpochDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEpochDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDesignationNameData
			// 
			this.labelDesignationNameData.AccessibleDescription = "Show the information of \"Readable designation\"";
			this.labelDesignationNameData.AccessibleName = "Show the information of \"Readable designation\"";
			this.labelDesignationNameData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDesignationNameData.AutoEllipsis = true;
			this.labelDesignationNameData.AutoSize = true;
			this.labelDesignationNameData.BackColor = System.Drawing.Color.Transparent;
			this.labelDesignationNameData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelDesignationNameData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDesignationNameData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDesignationNameData.Location = new System.Drawing.Point(254, 23);
			this.labelDesignationNameData.Name = "labelDesignationNameData";
			this.labelDesignationNameData.Padding = new System.Windows.Forms.Padding(3);
			this.labelDesignationNameData.Size = new System.Drawing.Size(143, 19);
			this.labelDesignationNameData.TabIndex = 3;
			this.labelDesignationNameData.Text = "..................";
			this.labelDesignationNameData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelDesignationNameData, "Show the information of  \"Readable designation\"");
			this.labelDesignationNameData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDesignationNameData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDesignationNameData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDesignationNameData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDesignationNameData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuCopyToClipboard
			// 
			this.contextMenuCopyToClipboard.AccessibleDescription = "Show the context menu of copying to clipboard";
			this.contextMenuCopyToClipboard.AccessibleName = "Context menu of copying to clipboard";
			this.contextMenuCopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuCopyToClipboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
			this.contextMenuCopyToClipboard.Name = "contextMenuCopyToClipboard";
			this.contextMenuCopyToClipboard.Size = new System.Drawing.Size(68, 26);
			this.contextMenuCopyToClipboard.TabStop = true;
			this.contextMenuCopyToClipboard.Text = "Copy to clipboard";
			this.toolTip.SetToolTip(this.contextMenuCopyToClipboard, "Copy to clipboard");
			this.contextMenuCopyToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.contextMenuCopyToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			// 
			// labelEpochData
			// 
			this.labelEpochData.AccessibleDescription = "Show the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochData.AccessibleName = "Show the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEpochData.AutoEllipsis = true;
			this.labelEpochData.AutoSize = true;
			this.labelEpochData.BackColor = System.Drawing.Color.Transparent;
			this.labelEpochData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelEpochData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEpochData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEpochData.Location = new System.Drawing.Point(254, 44);
			this.labelEpochData.Name = "labelEpochData";
			this.labelEpochData.Padding = new System.Windows.Forms.Padding(3);
			this.labelEpochData.Size = new System.Drawing.Size(143, 19);
			this.labelEpochData.TabIndex = 5;
			this.labelEpochData.Text = "..................";
			this.labelEpochData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelEpochData, "Show the information of \"Epoch (in packed form, .0 TT)\"");
			this.labelEpochData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelEpochData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEpochData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEpochData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEpochData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanAnomalyData
			// 
			this.labelMeanAnomalyData.AccessibleDescription = "Show the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyData.AccessibleName = "Show the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanAnomalyData.AutoEllipsis = true;
			this.labelMeanAnomalyData.AutoSize = true;
			this.labelMeanAnomalyData.BackColor = System.Drawing.Color.Transparent;
			this.labelMeanAnomalyData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelMeanAnomalyData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAnomalyData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMeanAnomalyData.Location = new System.Drawing.Point(254, 65);
			this.labelMeanAnomalyData.Name = "labelMeanAnomalyData";
			this.labelMeanAnomalyData.Padding = new System.Windows.Forms.Padding(3);
			this.labelMeanAnomalyData.Size = new System.Drawing.Size(143, 19);
			this.labelMeanAnomalyData.TabIndex = 7;
			this.labelMeanAnomalyData.Text = "..................";
			this.labelMeanAnomalyData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMeanAnomalyData, "Show the information of \"Mean anomaly at the epoch, in degrees\"");
			this.labelMeanAnomalyData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelMeanAnomalyData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAnomalyData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanAnomalyData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAnomalyData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelArgumentPerihelionData
			// 
			this.labelArgumentPerihelionData.AccessibleDescription = "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgumentPerihelionData.AccessibleName = "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgumentPerihelionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelArgumentPerihelionData.AutoEllipsis = true;
			this.labelArgumentPerihelionData.AutoSize = true;
			this.labelArgumentPerihelionData.BackColor = System.Drawing.Color.Transparent;
			this.labelArgumentPerihelionData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelArgumentPerihelionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentPerihelionData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelArgumentPerihelionData.Location = new System.Drawing.Point(254, 86);
			this.labelArgumentPerihelionData.Name = "labelArgumentPerihelionData";
			this.labelArgumentPerihelionData.Padding = new System.Windows.Forms.Padding(3);
			this.labelArgumentPerihelionData.Size = new System.Drawing.Size(143, 19);
			this.labelArgumentPerihelionData.TabIndex = 9;
			this.labelArgumentPerihelionData.Text = "..................";
			this.labelArgumentPerihelionData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelArgumentPerihelionData, "Show the information of \"Argument of perihelion, J2000.0 (degrees)\"");
			this.labelArgumentPerihelionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelArgumentPerihelionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentPerihelionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelArgumentPerihelionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentPerihelionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLongitudeAscendingNodeData
			// 
			this.labelLongitudeAscendingNodeData.AccessibleDescription = "Show the information of \"Longitude of the ascending node, J2000.0\"";
			this.labelLongitudeAscendingNodeData.AccessibleName = "Show the information of \"Longitude of the ascending node, J2000.0\"";
			this.labelLongitudeAscendingNodeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLongitudeAscendingNodeData.AutoEllipsis = true;
			this.labelLongitudeAscendingNodeData.AutoSize = true;
			this.labelLongitudeAscendingNodeData.BackColor = System.Drawing.Color.Transparent;
			this.labelLongitudeAscendingNodeData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelLongitudeAscendingNodeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeAscendingNodeData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLongitudeAscendingNodeData.Location = new System.Drawing.Point(254, 107);
			this.labelLongitudeAscendingNodeData.Name = "labelLongitudeAscendingNodeData";
			this.labelLongitudeAscendingNodeData.Padding = new System.Windows.Forms.Padding(3);
			this.labelLongitudeAscendingNodeData.Size = new System.Drawing.Size(143, 19);
			this.labelLongitudeAscendingNodeData.TabIndex = 11;
			this.labelLongitudeAscendingNodeData.Text = "..................";
			this.labelLongitudeAscendingNodeData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelLongitudeAscendingNodeData, "Show the information of \"Longitude of the ascending node, J2000.0\"");
			this.labelLongitudeAscendingNodeData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelLongitudeAscendingNodeData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeAscendingNodeData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLongitudeAscendingNodeData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeAscendingNodeData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelInclinationData
			// 
			this.labelInclinationData.AccessibleDescription = "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclinationData.AccessibleName = "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclinationData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelInclinationData.AutoEllipsis = true;
			this.labelInclinationData.AutoSize = true;
			this.labelInclinationData.BackColor = System.Drawing.Color.Transparent;
			this.labelInclinationData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelInclinationData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInclinationData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInclinationData.Location = new System.Drawing.Point(254, 128);
			this.labelInclinationData.Name = "labelInclinationData";
			this.labelInclinationData.Padding = new System.Windows.Forms.Padding(3);
			this.labelInclinationData.Size = new System.Drawing.Size(143, 19);
			this.labelInclinationData.TabIndex = 13;
			this.labelInclinationData.Text = "..................";
			this.labelInclinationData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelInclinationData, "Show the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"");
			this.labelInclinationData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelInclinationData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInclinationData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelInclinationData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInclinationData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalEccentricityData
			// 
			this.labelOrbitalEccentricityData.AccessibleDescription = "Show the information of \"Orbital eccentricity\"";
			this.labelOrbitalEccentricityData.AccessibleName = "Show the information of \"Orbital eccentricity\"";
			this.labelOrbitalEccentricityData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalEccentricityData.AutoEllipsis = true;
			this.labelOrbitalEccentricityData.AutoSize = true;
			this.labelOrbitalEccentricityData.BackColor = System.Drawing.Color.Transparent;
			this.labelOrbitalEccentricityData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelOrbitalEccentricityData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalEccentricityData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrbitalEccentricityData.Location = new System.Drawing.Point(254, 149);
			this.labelOrbitalEccentricityData.Name = "labelOrbitalEccentricityData";
			this.labelOrbitalEccentricityData.Padding = new System.Windows.Forms.Padding(3);
			this.labelOrbitalEccentricityData.Size = new System.Drawing.Size(143, 19);
			this.labelOrbitalEccentricityData.TabIndex = 15;
			this.labelOrbitalEccentricityData.Text = "..................";
			this.labelOrbitalEccentricityData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelOrbitalEccentricityData, "Show the information of \"Orbital eccentricity\"");
			this.labelOrbitalEccentricityData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelOrbitalEccentricityData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalEccentricityData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalEccentricityData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalEccentricityData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanDailyMotionData
			// 
			this.labelMeanDailyMotionData.AccessibleDescription = "Show the information of \"Mean daily motion (degrees per day)\"";
			this.labelMeanDailyMotionData.AccessibleName = "Show the information of \"Mean daily motion (degrees per day)\"";
			this.labelMeanDailyMotionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanDailyMotionData.AutoEllipsis = true;
			this.labelMeanDailyMotionData.AutoSize = true;
			this.labelMeanDailyMotionData.BackColor = System.Drawing.Color.Transparent;
			this.labelMeanDailyMotionData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelMeanDailyMotionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanDailyMotionData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMeanDailyMotionData.Location = new System.Drawing.Point(254, 170);
			this.labelMeanDailyMotionData.Name = "labelMeanDailyMotionData";
			this.labelMeanDailyMotionData.Padding = new System.Windows.Forms.Padding(3);
			this.labelMeanDailyMotionData.Size = new System.Drawing.Size(143, 19);
			this.labelMeanDailyMotionData.TabIndex = 17;
			this.labelMeanDailyMotionData.Text = "..................";
			this.labelMeanDailyMotionData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMeanDailyMotionData, "Show the information of \"Mean daily motion (degrees per day)\"");
			this.labelMeanDailyMotionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelMeanDailyMotionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanDailyMotionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanDailyMotionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanDailyMotionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMajorAxisData
			// 
			this.labelSemiMajorAxisData.AccessibleDescription = "Show the information of \"Semimajor axis (AU)\"";
			this.labelSemiMajorAxisData.AccessibleName = "Show the information of \"Semimajor axis (AU)\"";
			this.labelSemiMajorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMajorAxisData.AutoEllipsis = true;
			this.labelSemiMajorAxisData.AutoSize = true;
			this.labelSemiMajorAxisData.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiMajorAxisData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelSemiMajorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMajorAxisData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSemiMajorAxisData.Location = new System.Drawing.Point(254, 191);
			this.labelSemiMajorAxisData.Name = "labelSemiMajorAxisData";
			this.labelSemiMajorAxisData.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiMajorAxisData.Size = new System.Drawing.Size(143, 19);
			this.labelSemiMajorAxisData.TabIndex = 19;
			this.labelSemiMajorAxisData.Text = "..................";
			this.labelSemiMajorAxisData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSemiMajorAxisData, "Show the information of \"Semimajor axis (AU)\"");
			this.labelSemiMajorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSemiMajorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMajorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMajorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMajorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSlopeParameterData
			// 
			this.labelSlopeParameterData.AccessibleDescription = "Show the information of \"Slope parameter, G\"";
			this.labelSlopeParameterData.AccessibleName = "Show the information of \"Slope parameter, G\"";
			this.labelSlopeParameterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSlopeParameterData.AutoEllipsis = true;
			this.labelSlopeParameterData.AutoSize = true;
			this.labelSlopeParameterData.BackColor = System.Drawing.Color.Transparent;
			this.labelSlopeParameterData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelSlopeParameterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSlopeParameterData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSlopeParameterData.Location = new System.Drawing.Point(614, 23);
			this.labelSlopeParameterData.Name = "labelSlopeParameterData";
			this.labelSlopeParameterData.Padding = new System.Windows.Forms.Padding(3);
			this.labelSlopeParameterData.Size = new System.Drawing.Size(151, 19);
			this.labelSlopeParameterData.TabIndex = 23;
			this.labelSlopeParameterData.Text = "..................";
			this.labelSlopeParameterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSlopeParameterData, "Show the information of \"Slope parameter, G\"");
			this.labelSlopeParameterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSlopeParameterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSlopeParameterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSlopeParameterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSlopeParameterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelIndexData
			// 
			this.labelIndexData.AccessibleDescription = "Show the information of \"Index No.\"";
			this.labelIndexData.AccessibleName = "Show the information of \"Index No.\"";
			this.labelIndexData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelIndexData.AutoEllipsis = true;
			this.labelIndexData.AutoSize = true;
			this.labelIndexData.BackColor = System.Drawing.Color.Transparent;
			this.labelIndexData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelIndexData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIndexData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIndexData.Location = new System.Drawing.Point(254, 2);
			this.labelIndexData.Name = "labelIndexData";
			this.labelIndexData.Padding = new System.Windows.Forms.Padding(3);
			this.labelIndexData.Size = new System.Drawing.Size(143, 19);
			this.labelIndexData.TabIndex = 1;
			this.labelIndexData.Text = "..................";
			this.labelIndexData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelIndexData, "Show the information of \"Index No.\"");
			this.labelIndexData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelIndexData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelIndexData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelIndexData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelIndexData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAbsoluteMagnitudeData
			// 
			this.labelAbsoluteMagnitudeData.AccessibleDescription = "Show the information of \"Absolute magnitude, H\"";
			this.labelAbsoluteMagnitudeData.AccessibleName = "Show the information of \"Absolute magnitude, H\"";
			this.labelAbsoluteMagnitudeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelAbsoluteMagnitudeData.AutoEllipsis = true;
			this.labelAbsoluteMagnitudeData.AutoSize = true;
			this.labelAbsoluteMagnitudeData.BackColor = System.Drawing.Color.Transparent;
			this.labelAbsoluteMagnitudeData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelAbsoluteMagnitudeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAbsoluteMagnitudeData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAbsoluteMagnitudeData.Location = new System.Drawing.Point(254, 212);
			this.labelAbsoluteMagnitudeData.Name = "labelAbsoluteMagnitudeData";
			this.labelAbsoluteMagnitudeData.Padding = new System.Windows.Forms.Padding(3);
			this.labelAbsoluteMagnitudeData.Size = new System.Drawing.Size(143, 21);
			this.labelAbsoluteMagnitudeData.TabIndex = 21;
			this.labelAbsoluteMagnitudeData.Text = "..................";
			this.labelAbsoluteMagnitudeData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelAbsoluteMagnitudeData, "Show the information of \"Absolute magnitude, H\"");
			this.labelAbsoluteMagnitudeData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelAbsoluteMagnitudeData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAbsoluteMagnitudeData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAbsoluteMagnitudeData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAbsoluteMagnitudeData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelReferenceData
			// 
			this.labelReferenceData.AccessibleDescription = "Show the information of \"Reference\"";
			this.labelReferenceData.AccessibleName = "Show the information of \"Reference\"";
			this.labelReferenceData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelReferenceData.AutoEllipsis = true;
			this.labelReferenceData.AutoSize = true;
			this.labelReferenceData.BackColor = System.Drawing.Color.Transparent;
			this.labelReferenceData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelReferenceData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReferenceData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelReferenceData.Location = new System.Drawing.Point(614, 44);
			this.labelReferenceData.Name = "labelReferenceData";
			this.labelReferenceData.Padding = new System.Windows.Forms.Padding(3);
			this.labelReferenceData.Size = new System.Drawing.Size(151, 19);
			this.labelReferenceData.TabIndex = 25;
			this.labelReferenceData.Text = "..................";
			this.labelReferenceData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelReferenceData, "Show the information of \"Reference\"");
			this.labelReferenceData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelReferenceData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReferenceData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelReferenceData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelReferenceData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNumberOppositionsData
			// 
			this.labelNumberOppositionsData.AccessibleDescription = "Show the information of \"Number of oppositions\"";
			this.labelNumberOppositionsData.AccessibleName = "Show the information of \"Number of oppositions\"";
			this.labelNumberOppositionsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelNumberOppositionsData.AutoEllipsis = true;
			this.labelNumberOppositionsData.AutoSize = true;
			this.labelNumberOppositionsData.BackColor = System.Drawing.Color.Transparent;
			this.labelNumberOppositionsData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelNumberOppositionsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumberOppositionsData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumberOppositionsData.Location = new System.Drawing.Point(614, 65);
			this.labelNumberOppositionsData.Name = "labelNumberOppositionsData";
			this.labelNumberOppositionsData.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumberOppositionsData.Size = new System.Drawing.Size(151, 19);
			this.labelNumberOppositionsData.TabIndex = 27;
			this.labelNumberOppositionsData.Text = "..................";
			this.labelNumberOppositionsData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelNumberOppositionsData, "Show the information of \"Number of oppositions\"");
			this.labelNumberOppositionsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelNumberOppositionsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOppositionsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNumberOppositionsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberOppositionsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelNumberObservationsData
			// 
			this.labelNumberObservationsData.AccessibleDescription = "Show the information of \"Number of observations\"";
			this.labelNumberObservationsData.AccessibleName = "Show the information of \"Number of observations\"";
			this.labelNumberObservationsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelNumberObservationsData.AutoEllipsis = true;
			this.labelNumberObservationsData.AutoSize = true;
			this.labelNumberObservationsData.BackColor = System.Drawing.Color.Transparent;
			this.labelNumberObservationsData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelNumberObservationsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumberObservationsData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumberObservationsData.Location = new System.Drawing.Point(614, 86);
			this.labelNumberObservationsData.Name = "labelNumberObservationsData";
			this.labelNumberObservationsData.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumberObservationsData.Size = new System.Drawing.Size(151, 19);
			this.labelNumberObservationsData.TabIndex = 29;
			this.labelNumberObservationsData.Text = "..................";
			this.labelNumberObservationsData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelNumberObservationsData, "Show the information of \"Number of observations\"");
			this.labelNumberObservationsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelNumberObservationsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberObservationsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelNumberObservationsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelNumberObservationsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelObservationSpanData
			// 
			this.labelObservationSpanData.AccessibleDescription = "Show the information of \"Observation span\"";
			this.labelObservationSpanData.AccessibleName = "Show the information of \"Observation span\"";
			this.labelObservationSpanData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelObservationSpanData.AutoEllipsis = true;
			this.labelObservationSpanData.AutoSize = true;
			this.labelObservationSpanData.BackColor = System.Drawing.Color.Transparent;
			this.labelObservationSpanData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelObservationSpanData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelObservationSpanData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelObservationSpanData.Location = new System.Drawing.Point(614, 107);
			this.labelObservationSpanData.Name = "labelObservationSpanData";
			this.labelObservationSpanData.Padding = new System.Windows.Forms.Padding(3);
			this.labelObservationSpanData.Size = new System.Drawing.Size(151, 19);
			this.labelObservationSpanData.TabIndex = 31;
			this.labelObservationSpanData.Text = "..................";
			this.labelObservationSpanData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelObservationSpanData, "Show the information of \"Observation span\"");
			this.labelObservationSpanData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelObservationSpanData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelObservationSpanData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelObservationSpanData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelObservationSpanData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelRmsResidualData
			// 
			this.labelRmsResidualData.AccessibleDescription = "Show the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualData.AccessibleName = "Show the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRmsResidualData.AutoEllipsis = true;
			this.labelRmsResidualData.AutoSize = true;
			this.labelRmsResidualData.BackColor = System.Drawing.Color.Transparent;
			this.labelRmsResidualData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelRmsResidualData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRmsResidualData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRmsResidualData.Location = new System.Drawing.Point(614, 128);
			this.labelRmsResidualData.Name = "labelRmsResidualData";
			this.labelRmsResidualData.Padding = new System.Windows.Forms.Padding(3);
			this.labelRmsResidualData.Size = new System.Drawing.Size(151, 19);
			this.labelRmsResidualData.TabIndex = 33;
			this.labelRmsResidualData.Text = "..................";
			this.labelRmsResidualData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelRmsResidualData, "Show the information of \"r.m.s residual (\")\"");
			this.labelRmsResidualData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelRmsResidualData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRmsResidualData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelRmsResidualData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRmsResidualData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelComputerNameData
			// 
			this.labelComputerNameData.AccessibleDescription = "Show the information of \"Computer name\"";
			this.labelComputerNameData.AccessibleName = "Show the information of \"Computer name\"";
			this.labelComputerNameData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelComputerNameData.AutoEllipsis = true;
			this.labelComputerNameData.AutoSize = true;
			this.labelComputerNameData.BackColor = System.Drawing.Color.Transparent;
			this.labelComputerNameData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelComputerNameData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComputerNameData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelComputerNameData.Location = new System.Drawing.Point(614, 149);
			this.labelComputerNameData.Name = "labelComputerNameData";
			this.labelComputerNameData.Padding = new System.Windows.Forms.Padding(3);
			this.labelComputerNameData.Size = new System.Drawing.Size(151, 19);
			this.labelComputerNameData.TabIndex = 35;
			this.labelComputerNameData.Text = "..................";
			this.labelComputerNameData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelComputerNameData, "Show the information of \"Computer name\"");
			this.labelComputerNameData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelComputerNameData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelComputerNameData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelComputerNameData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelComputerNameData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelFlagsData
			// 
			this.labelFlagsData.AccessibleDescription = "Show the information of \"4-hexdigit flags\"";
			this.labelFlagsData.AccessibleName = "Show the information of \"4-hexdigit flags\"";
			this.labelFlagsData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFlagsData.AutoEllipsis = true;
			this.labelFlagsData.AutoSize = true;
			this.labelFlagsData.BackColor = System.Drawing.Color.Transparent;
			this.labelFlagsData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelFlagsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFlagsData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFlagsData.Location = new System.Drawing.Point(614, 170);
			this.labelFlagsData.Name = "labelFlagsData";
			this.labelFlagsData.Padding = new System.Windows.Forms.Padding(3);
			this.labelFlagsData.Size = new System.Drawing.Size(151, 19);
			this.labelFlagsData.TabIndex = 37;
			this.labelFlagsData.Text = "..................";
			this.labelFlagsData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelFlagsData, "Show the information of \"4-hexdigit flags\"");
			this.labelFlagsData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelFlagsData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFlagsData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelFlagsData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFlagsData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateLastObservationData
			// 
			this.labelDateLastObservationData.AccessibleDescription = "Show the information of \"Date of last observation\"";
			this.labelDateLastObservationData.AccessibleName = "Show the information of \"Date of last observation\"";
			this.labelDateLastObservationData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateLastObservationData.AutoEllipsis = true;
			this.labelDateLastObservationData.AutoSize = true;
			this.labelDateLastObservationData.BackColor = System.Drawing.Color.Transparent;
			this.labelDateLastObservationData.ContextMenuStrip = this.contextMenuCopyToClipboard;
			this.labelDateLastObservationData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDateLastObservationData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDateLastObservationData.Location = new System.Drawing.Point(614, 191);
			this.labelDateLastObservationData.Name = "labelDateLastObservationData";
			this.labelDateLastObservationData.Padding = new System.Windows.Forms.Padding(3);
			this.labelDateLastObservationData.Size = new System.Drawing.Size(151, 19);
			this.labelDateLastObservationData.TabIndex = 39;
			this.labelDateLastObservationData.Text = "..................";
			this.labelDateLastObservationData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelDateLastObservationData, "Show the information of \"Date of last observation\"");
			this.labelDateLastObservationData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelDateLastObservationData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateLastObservationData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateLastObservationData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateLastObservationData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelIndexDesc
			// 
			this.linkLabelIndexDesc.AccessibleDescription = "Index No.";
			this.linkLabelIndexDesc.AccessibleName = "Index No.";
			this.linkLabelIndexDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelIndexDesc.AutoEllipsis = true;
			this.linkLabelIndexDesc.AutoSize = true;
			this.linkLabelIndexDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelIndexDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelIndexDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelIndexDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelIndexDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelIndexDesc.Location = new System.Drawing.Point(5, 2);
			this.linkLabelIndexDesc.Name = "linkLabelIndexDesc";
			this.linkLabelIndexDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelIndexDesc.TabIndex = 0;
			this.linkLabelIndexDesc.TabStop = true;
			this.linkLabelIndexDesc.Text = "Index No.";
			this.linkLabelIndexDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelIndexDesc, "Index No.");
			this.linkLabelIndexDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelIndex_Click);
			this.linkLabelIndexDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelIndexDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelIndexDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelIndexDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelDesignationNameDesc
			// 
			this.linkLabelDesignationNameDesc.AccessibleDescription = "Readable designation";
			this.linkLabelDesignationNameDesc.AccessibleName = "Readable designation";
			this.linkLabelDesignationNameDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelDesignationNameDesc.AutoEllipsis = true;
			this.linkLabelDesignationNameDesc.AutoSize = true;
			this.linkLabelDesignationNameDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelDesignationNameDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelDesignationNameDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.linkLabelDesignationNameDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelDesignationNameDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelDesignationNameDesc.Location = new System.Drawing.Point(5, 23);
			this.linkLabelDesignationNameDesc.Name = "linkLabelDesignationNameDesc";
			this.linkLabelDesignationNameDesc.Size = new System.Drawing.Size(241, 19);
			this.linkLabelDesignationNameDesc.TabIndex = 2;
			this.linkLabelDesignationNameDesc.TabStop = true;
			this.linkLabelDesignationNameDesc.Text = "Readable designation";
			this.linkLabelDesignationNameDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.linkLabelDesignationNameDesc, "Readable designation");
			this.linkLabelDesignationNameDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelDesgnName_Click);
			this.linkLabelDesignationNameDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelDesignationNameDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelDesignationNameDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelDesignationNameDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.statusBar.Size = new System.Drawing.Size(770, 22);
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
            this.navigationToolStripMenuItem,
            this.toolStripMenuItemTools,
            this.updateToolStripMenuItem,
            this.menuitemOptions,
            this.menuitemHelp});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.menu.ShowItemToolTips = true;
			this.menu.Size = new System.Drawing.Size(770, 24);
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
            this.toolStripMenuItemOpenALocalMpcorbdatFile,
            this.toolStripSeparator13,
            this.exportDataEntryToolStripMenuItem,
            this.toolStripMenuItemPrint,
            this.toolStripSeparatorFile1,
            this.toolStripMenuItemRestart,
            this.menuitemExit});
			this.menuitemFile.Name = "menuitemFile";
			this.menuitemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.menuitemFile.Size = new System.Drawing.Size(37, 24);
			this.menuitemFile.Text = "&File";
			this.menuitemFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemOpenALocalMpcorbdatFile
			// 
			this.toolStripMenuItemOpenALocalMpcorbdatFile.AccessibleDescription = "Open a local MPCORB.DAT file";
			this.toolStripMenuItemOpenALocalMpcorbdatFile.AccessibleName = "Open";
			this.toolStripMenuItemOpenALocalMpcorbdatFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemOpenALocalMpcorbdatFile.AutoToolTip = true;
			this.toolStripMenuItemOpenALocalMpcorbdatFile.Enabled = false;
			this.toolStripMenuItemOpenALocalMpcorbdatFile.Image = global::Planetoid_DB.Properties.Resources.silk_folder;
			this.toolStripMenuItemOpenALocalMpcorbdatFile.Name = "toolStripMenuItemOpenALocalMpcorbdatFile";
			this.toolStripMenuItemOpenALocalMpcorbdatFile.Size = new System.Drawing.Size(235, 22);
			this.toolStripMenuItemOpenALocalMpcorbdatFile.Text = "&Open a local MPCORB.DAT file";
			this.toolStripMenuItemOpenALocalMpcorbdatFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemOpenALocalMpcorbdatFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator13
			// 
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new System.Drawing.Size(232, 6);
			this.toolStripSeparator13.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator13.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// exportDataEntryToolStripMenuItem
			// 
			this.exportDataEntryToolStripMenuItem.AccessibleDescription = "Export data entry";
			this.exportDataEntryToolStripMenuItem.AccessibleName = "Export";
			this.exportDataEntryToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.exportDataEntryToolStripMenuItem.AutoToolTip = true;
			this.exportDataEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportDataEntryAsTxt,
            this.toolStripMenuItemExportDataEntryAsHtml,
            this.toolStripMenuItemExportDataEntryAsXml,
            this.toolStripMenuItemExportDataEntryAsJson});
			this.exportDataEntryToolStripMenuItem.Enabled = false;
			this.exportDataEntryToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_page_save;
			this.exportDataEntryToolStripMenuItem.Name = "exportDataEntryToolStripMenuItem";
			this.exportDataEntryToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.exportDataEntryToolStripMenuItem.Text = "&Export data entry";
			this.exportDataEntryToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.exportDataEntryToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportDataEntryAsTxt
			// 
			this.toolStripMenuItemExportDataEntryAsTxt.AccessibleDescription = "Export data entry as TXT";
			this.toolStripMenuItemExportDataEntryAsTxt.AccessibleName = "Export data entry as TXT";
			this.toolStripMenuItemExportDataEntryAsTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportDataEntryAsTxt.Enabled = false;
			this.toolStripMenuItemExportDataEntryAsTxt.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_text;
			this.toolStripMenuItemExportDataEntryAsTxt.Name = "toolStripMenuItemExportDataEntryAsTxt";
			this.toolStripMenuItemExportDataEntryAsTxt.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemExportDataEntryAsTxt.Text = "as &TXT";
			this.toolStripMenuItemExportDataEntryAsTxt.ToolTipText = "Export data entry as TXT";
			this.toolStripMenuItemExportDataEntryAsTxt.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportDataEntryAsTxt.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportDataEntryAsHtml
			// 
			this.toolStripMenuItemExportDataEntryAsHtml.AccessibleDescription = "Export data entry as HTML";
			this.toolStripMenuItemExportDataEntryAsHtml.AccessibleName = "Export data entry as HTML";
			this.toolStripMenuItemExportDataEntryAsHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportDataEntryAsHtml.Enabled = false;
			this.toolStripMenuItemExportDataEntryAsHtml.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExportDataEntryAsHtml.Image")));
			this.toolStripMenuItemExportDataEntryAsHtml.Name = "toolStripMenuItemExportDataEntryAsHtml";
			this.toolStripMenuItemExportDataEntryAsHtml.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemExportDataEntryAsHtml.Text = "as &HTML";
			this.toolStripMenuItemExportDataEntryAsHtml.ToolTipText = "Export data entry as HTML";
			this.toolStripMenuItemExportDataEntryAsHtml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportDataEntryAsHtml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportDataEntryAsXml
			// 
			this.toolStripMenuItemExportDataEntryAsXml.AccessibleDescription = "Export data entry as XML";
			this.toolStripMenuItemExportDataEntryAsXml.AccessibleName = "Export data entry as XML";
			this.toolStripMenuItemExportDataEntryAsXml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportDataEntryAsXml.Enabled = false;
			this.toolStripMenuItemExportDataEntryAsXml.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExportDataEntryAsXml.Image")));
			this.toolStripMenuItemExportDataEntryAsXml.Name = "toolStripMenuItemExportDataEntryAsXml";
			this.toolStripMenuItemExportDataEntryAsXml.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemExportDataEntryAsXml.Text = "as &XML";
			this.toolStripMenuItemExportDataEntryAsXml.ToolTipText = "Export data entry as XML";
			this.toolStripMenuItemExportDataEntryAsXml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportDataEntryAsXml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportDataEntryAsJson
			// 
			this.toolStripMenuItemExportDataEntryAsJson.AccessibleDescription = "Export data entry as JSON";
			this.toolStripMenuItemExportDataEntryAsJson.AccessibleName = "Export data entry as JSON";
			this.toolStripMenuItemExportDataEntryAsJson.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportDataEntryAsJson.Enabled = false;
			this.toolStripMenuItemExportDataEntryAsJson.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExportDataEntryAsJson.Image")));
			this.toolStripMenuItemExportDataEntryAsJson.Name = "toolStripMenuItemExportDataEntryAsJson";
			this.toolStripMenuItemExportDataEntryAsJson.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemExportDataEntryAsJson.Text = "as &JSON";
			this.toolStripMenuItemExportDataEntryAsJson.ToolTipText = "Export data entry as JSON";
			this.toolStripMenuItemExportDataEntryAsJson.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportDataEntryAsJson.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemPrint
			// 
			this.toolStripMenuItemPrint.AccessibleDescription = "Print the information";
			this.toolStripMenuItemPrint.AccessibleName = "Print";
			this.toolStripMenuItemPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemPrint.AutoToolTip = true;
			this.toolStripMenuItemPrint.Enabled = false;
			this.toolStripMenuItemPrint.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
			this.toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
			this.toolStripMenuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.toolStripMenuItemPrint.Size = new System.Drawing.Size(235, 22);
			this.toolStripMenuItemPrint.Text = "&Print data sheet";
			this.toolStripMenuItemPrint.Click += new System.EventHandler(this.ToolStripMenuItemPrint_Click);
			this.toolStripMenuItemPrint.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemPrint.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorFile1
			// 
			this.toolStripSeparatorFile1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			this.toolStripSeparatorFile1.Size = new System.Drawing.Size(232, 6);
			this.toolStripSeparatorFile1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorFile1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemRestart
			// 
			this.toolStripMenuItemRestart.AccessibleDescription = "Restart the application";
			this.toolStripMenuItemRestart.AccessibleName = "Restart";
			this.toolStripMenuItemRestart.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemRestart.AutoToolTip = true;
			this.toolStripMenuItemRestart.Image = global::Planetoid_DB.Properties.Resources.silk_reload;
			this.toolStripMenuItemRestart.Name = "toolStripMenuItemRestart";
			this.toolStripMenuItemRestart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.toolStripMenuItemRestart.Size = new System.Drawing.Size(235, 22);
			this.toolStripMenuItemRestart.Text = "&Restart";
			this.toolStripMenuItemRestart.Click += new System.EventHandler(this.ToolStripMenuItemRestart_Click);
			this.toolStripMenuItemRestart.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemRestart.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
            this.toolStripMenuItemCopytoClipboard,
            this.toolStripMenuItemSearch});
			this.menuitemEdit.Name = "menuitemEdit";
			this.menuitemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
			this.menuitemEdit.Size = new System.Drawing.Size(39, 24);
			this.menuitemEdit.Text = "&Edit";
			this.menuitemEdit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemEdit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopytoClipboard
			// 
			this.toolStripMenuItemCopytoClipboard.AccessibleDescription = "Copy to clipboard";
			this.toolStripMenuItemCopytoClipboard.AccessibleName = "Copy to clipboard";
			this.toolStripMenuItemCopytoClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopytoClipboard.AutoToolTip = true;
			this.toolStripMenuItemCopytoClipboard.DoubleClickEnabled = true;
			this.toolStripMenuItemCopytoClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopyToClipboardIndexNumber,
            this.toolStripMenuItemCopyToClipboardReadableDesignation,
            this.toolStripMenuItemCopyToClipboardEpoch,
            this.toolStripMenuItemCopyToClipboardMeanAnomaly,
            this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion,
            this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode,
            this.toolStripMenuItemCopyToClipboardInclination,
            this.toolStripMenuItemCopyToClipboardEccentricity,
            this.toolStripMenuItemCopyToClipboardMeanDailyMotion,
            this.toolStripMenuItemCopyToClipboardSemimajorAxis,
            this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude,
            this.toolStripMenuItemCopyToClipboardSlopeParameter,
            this.toolStripMenuItemCopyToClipboardReference,
            this.toolStripMenuItemCopyToClipboardNumberOfOppositions,
            this.toolStripMenuItemCopyToClipboardNumberOfObservations,
            this.toolStripMenuItemCopyToClipboardObservationSpan,
            this.toolStripMenuItemCopyToClipboardRmsResidual,
            this.toolStripMenuItemCopyToClipboardComputername,
            this.toolStripMenuItemCopyToClipboardDateOfLastObservation,
            this.toolStripMenuItemCopyToClipboardFlags});
			this.toolStripMenuItemCopytoClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.toolStripMenuItemCopytoClipboard.Name = "toolStripMenuItemCopytoClipboard";
			this.toolStripMenuItemCopytoClipboard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.toolStripMenuItemCopytoClipboard.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemCopytoClipboard.Text = "&Copy";
			this.toolStripMenuItemCopytoClipboard.Click += new System.EventHandler(this.ToolStripButtonCopyToClipboard_Click);
			this.toolStripMenuItemCopytoClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopytoClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardIndexNumber
			// 
			this.toolStripMenuItemCopyToClipboardIndexNumber.AccessibleDescription = "Copy to clipboard: Index number";
			this.toolStripMenuItemCopyToClipboardIndexNumber.AccessibleName = "Copy to clipboard: Index number";
			this.toolStripMenuItemCopyToClipboardIndexNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardIndexNumber.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardIndexNumber.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardIndexNumber.Image")));
			this.toolStripMenuItemCopyToClipboardIndexNumber.Name = "toolStripMenuItemCopyToClipboardIndexNumber";
			this.toolStripMenuItemCopyToClipboardIndexNumber.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardIndexNumber.Text = "Index No.";
			this.toolStripMenuItemCopyToClipboardIndexNumber.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardIndexNumber_Click);
			this.toolStripMenuItemCopyToClipboardIndexNumber.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardIndexNumber.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardReadableDesignation
			// 
			this.toolStripMenuItemCopyToClipboardReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			this.toolStripMenuItemCopyToClipboardReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			this.toolStripMenuItemCopyToClipboardReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardReadableDesignation.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardReadableDesignation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardReadableDesignation.Image")));
			this.toolStripMenuItemCopyToClipboardReadableDesignation.Name = "toolStripMenuItemCopyToClipboardReadableDesignation";
			this.toolStripMenuItemCopyToClipboardReadableDesignation.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardReadableDesignation.Text = "Readable designation";
			this.toolStripMenuItemCopyToClipboardReadableDesignation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReadableDesignation_Click);
			this.toolStripMenuItemCopyToClipboardReadableDesignation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardReadableDesignation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardEpoch
			// 
			this.toolStripMenuItemCopyToClipboardEpoch.AccessibleDescription = "Copy to clipboard: Epoch";
			this.toolStripMenuItemCopyToClipboardEpoch.AccessibleName = "Copy to clipboard: Epoch";
			this.toolStripMenuItemCopyToClipboardEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardEpoch.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardEpoch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardEpoch.Image")));
			this.toolStripMenuItemCopyToClipboardEpoch.Name = "toolStripMenuItemCopyToClipboardEpoch";
			this.toolStripMenuItemCopyToClipboardEpoch.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.toolStripMenuItemCopyToClipboardEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardEpoch_Click);
			this.toolStripMenuItemCopyToClipboardEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardMeanAnomaly
			// 
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch";
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch";
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardMeanAnomaly.Image")));
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.Name = "toolStripMenuItemCopyToClipboardMeanAnomaly";
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.Text = "Mean anomaly at the epoch (degrees)";
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanAnomaly_Click);
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardMeanAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardArgumentOfPerihelion
			// 
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion";
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion";
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardArgumentOfPerihelion.Image")));
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.Name = "toolStripMenuItemCopyToClipboardArgumentOfPerihelion";
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (degrees)";
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click);
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode
			// 
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node";
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node";
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.Image")));
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.Name = "toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode";
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0";
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click);
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardInclination
			// 
			this.toolStripMenuItemCopyToClipboardInclination.AccessibleDescription = "Copy to clipboard: Inclination";
			this.toolStripMenuItemCopyToClipboardInclination.AccessibleName = "Copy to clipboard: Inclination";
			this.toolStripMenuItemCopyToClipboardInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardInclination.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardInclination.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardInclination.Image")));
			this.toolStripMenuItemCopyToClipboardInclination.Name = "toolStripMenuItemCopyToClipboardInclination";
			this.toolStripMenuItemCopyToClipboardInclination.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardInclination.Text = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.toolStripMenuItemCopyToClipboardInclination.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardInclination_Click);
			this.toolStripMenuItemCopyToClipboardInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardEccentricity
			// 
			this.toolStripMenuItemCopyToClipboardEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.toolStripMenuItemCopyToClipboardEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.toolStripMenuItemCopyToClipboardEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardEccentricity.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardEccentricity.Image")));
			this.toolStripMenuItemCopyToClipboardEccentricity.Name = "toolStripMenuItemCopyToClipboardEccentricity";
			this.toolStripMenuItemCopyToClipboardEccentricity.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardEccentricity.Text = "Orbital eccentricity";
			this.toolStripMenuItemCopyToClipboardEccentricity.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click);
			this.toolStripMenuItemCopyToClipboardEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardMeanDailyMotion
			// 
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion";
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion";
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardMeanDailyMotion.Image")));
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.Name = "toolStripMenuItemCopyToClipboardMeanDailyMotion";
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.Text = "Mean daily motion (degrees per day)";
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click);
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardSemimajorAxis
			// 
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis";
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis";
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardSemimajorAxis.Image")));
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.Name = "toolStripMenuItemCopyToClipboardSemimajorAxis";
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.Text = "Semi-major axis (AU)";
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardSemimajorAxis_Click);
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardSemimajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardAbsoluteMagnitude
			// 
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude";
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude";
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardAbsoluteMagnitude.Image")));
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.Name = "toolStripMenuItemCopyToClipboardAbsoluteMagnitude";
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.Text = "Absolute magnitude, H";
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click);
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardSlopeParameter
			// 
			this.toolStripMenuItemCopyToClipboardSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter";
			this.toolStripMenuItemCopyToClipboardSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter";
			this.toolStripMenuItemCopyToClipboardSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardSlopeParameter.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardSlopeParameter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardSlopeParameter.Image")));
			this.toolStripMenuItemCopyToClipboardSlopeParameter.Name = "toolStripMenuItemCopyToClipboardSlopeParameter";
			this.toolStripMenuItemCopyToClipboardSlopeParameter.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardSlopeParameter.Text = "Slope parameter, G";
			this.toolStripMenuItemCopyToClipboardSlopeParameter.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardSlopeParameter_Click);
			this.toolStripMenuItemCopyToClipboardSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardReference
			// 
			this.toolStripMenuItemCopyToClipboardReference.AccessibleDescription = "Copy to clipboard: Reference";
			this.toolStripMenuItemCopyToClipboardReference.AccessibleName = "Copy to clipboard: Reference";
			this.toolStripMenuItemCopyToClipboardReference.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardReference.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardReference.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardReference.Image")));
			this.toolStripMenuItemCopyToClipboardReference.Name = "toolStripMenuItemCopyToClipboardReference";
			this.toolStripMenuItemCopyToClipboardReference.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardReference.Text = "Reference";
			this.toolStripMenuItemCopyToClipboardReference.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReference_Click);
			this.toolStripMenuItemCopyToClipboardReference.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardReference.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardNumberOfOppositions
			// 
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions ";
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardNumberOfOppositions.Image")));
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.Name = "toolStripMenuItemCopyToClipboardNumberOfOppositions";
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.Text = "Number of oppositions";
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click);
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardNumberOfObservations
			// 
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardNumberOfObservations.Image")));
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.Name = "toolStripMenuItemCopyToClipboardNumberOfObservations";
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.Text = "Number of observations";
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfObservations_Click);
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardObservationSpan
			// 
			this.toolStripMenuItemCopyToClipboardObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.toolStripMenuItemCopyToClipboardObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.toolStripMenuItemCopyToClipboardObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardObservationSpan.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardObservationSpan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardObservationSpan.Image")));
			this.toolStripMenuItemCopyToClipboardObservationSpan.Name = "toolStripMenuItemCopyToClipboardObservationSpan";
			this.toolStripMenuItemCopyToClipboardObservationSpan.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardObservationSpan.Text = "Observation span";
			this.toolStripMenuItemCopyToClipboardObservationSpan.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardObservationSpan_Click);
			this.toolStripMenuItemCopyToClipboardObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardRmsResidual
			// 
			this.toolStripMenuItemCopyToClipboardRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual";
			this.toolStripMenuItemCopyToClipboardRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual";
			this.toolStripMenuItemCopyToClipboardRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardRmsResidual.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardRmsResidual.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardRmsResidual.Image")));
			this.toolStripMenuItemCopyToClipboardRmsResidual.Name = "toolStripMenuItemCopyToClipboardRmsResidual";
			this.toolStripMenuItemCopyToClipboardRmsResidual.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardRmsResidual.Text = "r.m.s. residual (\")";
			this.toolStripMenuItemCopyToClipboardRmsResidual.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardRmsResidual_Click);
			this.toolStripMenuItemCopyToClipboardRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardComputername
			// 
			this.toolStripMenuItemCopyToClipboardComputername.AccessibleDescription = "Copy to clipboard: Computer name";
			this.toolStripMenuItemCopyToClipboardComputername.AccessibleName = "Copy to clipboard: Computer name";
			this.toolStripMenuItemCopyToClipboardComputername.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardComputername.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardComputername.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardComputername.Image")));
			this.toolStripMenuItemCopyToClipboardComputername.Name = "toolStripMenuItemCopyToClipboardComputername";
			this.toolStripMenuItemCopyToClipboardComputername.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardComputername.Text = "Computer name";
			this.toolStripMenuItemCopyToClipboardComputername.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardComputername_Click);
			this.toolStripMenuItemCopyToClipboardComputername.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardComputername.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardDateOfLastObservation
			// 
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation";
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation";
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardDateOfLastObservation.Image")));
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.Name = "toolStripMenuItemCopyToClipboardDateOfLastObservation";
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.Text = "Date of last observation";
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click);
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardDateOfLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyToClipboardFlags
			// 
			this.toolStripMenuItemCopyToClipboardFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.toolStripMenuItemCopyToClipboardFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.toolStripMenuItemCopyToClipboardFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyToClipboardFlags.AutoToolTip = true;
			this.toolStripMenuItemCopyToClipboardFlags.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyToClipboardFlags.Image")));
			this.toolStripMenuItemCopyToClipboardFlags.Name = "toolStripMenuItemCopyToClipboardFlags";
			this.toolStripMenuItemCopyToClipboardFlags.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyToClipboardFlags.Text = "4-hexdigit flags";
			this.toolStripMenuItemCopyToClipboardFlags.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardFlags_Click);
			this.toolStripMenuItemCopyToClipboardFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyToClipboardFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripMenuItemSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.toolStripMenuItemSearch.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSearch.Text = "&Search";
			this.toolStripMenuItemSearch.Click += new System.EventHandler(this.ToolStripMenuItemSearch_Click);
			this.toolStripMenuItemSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// navigationToolStripMenuItem
			// 
			this.navigationToolStripMenuItem.AccessibleDescription = "Open the menu \"navigation\"";
			this.navigationToolStripMenuItem.AccessibleName = "Navigation";
			this.navigationToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.navigationToolStripMenuItem.AutoToolTip = true;
			this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRandomMinorPlanet,
            this.toolStripSeparatorNavigation1,
            this.toolStripMenuItemNavigateToTheBeginning,
            this.toolStripMenuItemNavigateSomeDataBackward,
            this.toolStripMenuItemNavigateToThePreviousData,
            this.toolStripMenuItemNavigateToTheNextData,
            this.toolStripMenuItemNavigateSomeDataForward,
            this.toolStripMenuItemNavigateToTheEnd});
			this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
			this.navigationToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
			this.navigationToolStripMenuItem.Text = "&Navigation";
			this.navigationToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.navigationToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemRandomMinorPlanet
			// 
			this.toolStripMenuItemRandomMinorPlanet.AccessibleDescription = "Load a random minor planet";
			this.toolStripMenuItemRandomMinorPlanet.AccessibleName = "Random minor planet";
			this.toolStripMenuItemRandomMinorPlanet.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemRandomMinorPlanet.AutoToolTip = true;
			this.toolStripMenuItemRandomMinorPlanet.DoubleClickEnabled = true;
			this.toolStripMenuItemRandomMinorPlanet.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_refresh;
			this.toolStripMenuItemRandomMinorPlanet.Name = "toolStripMenuItemRandomMinorPlanet";
			this.toolStripMenuItemRandomMinorPlanet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.toolStripMenuItemRandomMinorPlanet.Size = new System.Drawing.Size(274, 22);
			this.toolStripMenuItemRandomMinorPlanet.Text = "&Random minor planet";
			this.toolStripMenuItemRandomMinorPlanet.Click += new System.EventHandler(this.ToolStripMenuItemRandomMinorPlanet_Click);
			this.toolStripMenuItemRandomMinorPlanet.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemRandomMinorPlanet.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorNavigation1
			// 
			this.toolStripSeparatorNavigation1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorNavigation1.Name = "toolStripSeparatorNavigation1";
			this.toolStripSeparatorNavigation1.Size = new System.Drawing.Size(271, 6);
			this.toolStripSeparatorNavigation1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorNavigation1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemNavigateToTheBeginning
			// 
			this.toolStripMenuItemNavigateToTheBeginning.AccessibleDescription = "Navigate to the beginning of the data";
			this.toolStripMenuItemNavigateToTheBeginning.AccessibleName = "Navigate to the beginning";
			this.toolStripMenuItemNavigateToTheBeginning.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemNavigateToTheBeginning.AutoToolTip = true;
			this.toolStripMenuItemNavigateToTheBeginning.DoubleClickEnabled = true;
			this.toolStripMenuItemNavigateToTheBeginning.Image = global::Planetoid_DB.Properties.Resources.silk_backward_end_green;
			this.toolStripMenuItemNavigateToTheBeginning.Name = "toolStripMenuItemNavigateToTheBeginning";
			this.toolStripMenuItemNavigateToTheBeginning.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
			this.toolStripMenuItemNavigateToTheBeginning.Size = new System.Drawing.Size(274, 22);
			this.toolStripMenuItemNavigateToTheBeginning.Text = "Navigate to the &beginning";
			this.toolStripMenuItemNavigateToTheBeginning.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToTheBegin_Click);
			this.toolStripMenuItemNavigateToTheBeginning.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemNavigateToTheBeginning.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemNavigateToThePreviousData
			// 
			this.toolStripMenuItemNavigateToThePreviousData.AccessibleDescription = "Navigate to the previous data";
			this.toolStripMenuItemNavigateToThePreviousData.AccessibleName = "Navigate to the previous";
			this.toolStripMenuItemNavigateToThePreviousData.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemNavigateToThePreviousData.AutoToolTip = true;
			this.toolStripMenuItemNavigateToThePreviousData.DoubleClickEnabled = true;
			this.toolStripMenuItemNavigateToThePreviousData.Image = global::Planetoid_DB.Properties.Resources.silk_backward_1_green;
			this.toolStripMenuItemNavigateToThePreviousData.Name = "toolStripMenuItemNavigateToThePreviousData";
			this.toolStripMenuItemNavigateToThePreviousData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.toolStripMenuItemNavigateToThePreviousData.Size = new System.Drawing.Size(274, 22);
			this.toolStripMenuItemNavigateToThePreviousData.Text = "Navigate to the &previous";
			this.toolStripMenuItemNavigateToThePreviousData.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToThePreviousData_Click);
			this.toolStripMenuItemNavigateToThePreviousData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemNavigateToThePreviousData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemNavigateToTheNextData
			// 
			this.toolStripMenuItemNavigateToTheNextData.AccessibleDescription = "Navigate to the next data";
			this.toolStripMenuItemNavigateToTheNextData.AccessibleName = "Navigate to the next";
			this.toolStripMenuItemNavigateToTheNextData.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemNavigateToTheNextData.AutoToolTip = true;
			this.toolStripMenuItemNavigateToTheNextData.DoubleClickEnabled = true;
			this.toolStripMenuItemNavigateToTheNextData.Image = global::Planetoid_DB.Properties.Resources.silk_forward_1_green;
			this.toolStripMenuItemNavigateToTheNextData.Name = "toolStripMenuItemNavigateToTheNextData";
			this.toolStripMenuItemNavigateToTheNextData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
			this.toolStripMenuItemNavigateToTheNextData.Size = new System.Drawing.Size(274, 22);
			this.toolStripMenuItemNavigateToTheNextData.Text = "Navigate to the &next";
			this.toolStripMenuItemNavigateToTheNextData.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToTheNextData_Click);
			this.toolStripMenuItemNavigateToTheNextData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemNavigateToTheNextData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemNavigateToTheEnd
			// 
			this.toolStripMenuItemNavigateToTheEnd.AccessibleDescription = "Navigate to the end of the data";
			this.toolStripMenuItemNavigateToTheEnd.AccessibleName = "Navigate to the end";
			this.toolStripMenuItemNavigateToTheEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemNavigateToTheEnd.AutoToolTip = true;
			this.toolStripMenuItemNavigateToTheEnd.DoubleClickEnabled = true;
			this.toolStripMenuItemNavigateToTheEnd.Image = global::Planetoid_DB.Properties.Resources.silk_forward_end_green;
			this.toolStripMenuItemNavigateToTheEnd.Name = "toolStripMenuItemNavigateToTheEnd";
			this.toolStripMenuItemNavigateToTheEnd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
			this.toolStripMenuItemNavigateToTheEnd.Size = new System.Drawing.Size(274, 22);
			this.toolStripMenuItemNavigateToTheEnd.Text = "Navigate to the &end";
			this.toolStripMenuItemNavigateToTheEnd.Click += new System.EventHandler(this.ToolStripMenuItemNavigateToTheEnd_Click);
			this.toolStripMenuItemNavigateToTheEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemNavigateToTheEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemTools
			// 
			this.toolStripMenuItemTools.AccessibleDescription = "Open the menu \"tools\"";
			this.toolStripMenuItemTools.AccessibleName = "Tools";
			this.toolStripMenuItemTools.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.toolStripMenuItemTools.AutoToolTip = true;
			this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDerivatedOrbitElements,
            this.toolStripMenuItemFilter,
            this.toolStripSeparatorTools1,
            this.toolStripMenuItem1,
            this.toolStripSeparator10,
            this.chartBarToolStripMenuItem,
            this.toolStripSeparatorTools2,
            this.toolStripMenuItemDatabaseInformation,
            this.toolStripMenuItemTableMode,
            this.toolStripMenuItemTerminology});
			this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
			this.toolStripMenuItemTools.Size = new System.Drawing.Size(46, 24);
			this.toolStripMenuItemTools.Text = "&Tools";
			this.toolStripMenuItemTools.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemTools.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemDerivatedOrbitElements
			// 
			this.toolStripMenuItemDerivatedOrbitElements.AccessibleDescription = "Calculate derivated orbital elements";
			this.toolStripMenuItemDerivatedOrbitElements.AccessibleName = "Derivated orbital elements";
			this.toolStripMenuItemDerivatedOrbitElements.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemDerivatedOrbitElements.AutoToolTip = true;
			this.toolStripMenuItemDerivatedOrbitElements.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_branch;
			this.toolStripMenuItemDerivatedOrbitElements.Name = "toolStripMenuItemDerivatedOrbitElements";
			this.toolStripMenuItemDerivatedOrbitElements.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItemDerivatedOrbitElements.Size = new System.Drawing.Size(251, 22);
			this.toolStripMenuItemDerivatedOrbitElements.Text = "Derivated &orbital elements";
			this.toolStripMenuItemDerivatedOrbitElements.Click += new System.EventHandler(this.ToolStripMenuItemDerivatedOrbitElements_Click);
			this.toolStripMenuItemDerivatedOrbitElements.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemDerivatedOrbitElements.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemFilter
			// 
			this.toolStripMenuItemFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemFilter.AutoToolTip = true;
			this.toolStripMenuItemFilter.Enabled = false;
			this.toolStripMenuItemFilter.Image = global::Planetoid_DB.Properties.Resources.silk_arrow_divide;
			this.toolStripMenuItemFilter.Name = "toolStripMenuItemFilter";
			this.toolStripMenuItemFilter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.toolStripMenuItemFilter.Size = new System.Drawing.Size(251, 22);
			this.toolStripMenuItemFilter.Text = "&Filter";
			this.toolStripMenuItemFilter.Click += new System.EventHandler(this.ToolStripMenuItemFilter_Click);
			this.toolStripMenuItemFilter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemFilter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorTools1
			// 
			this.toolStripSeparatorTools1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorTools1.Name = "toolStripSeparatorTools1";
			this.toolStripSeparatorTools1.Size = new System.Drawing.Size(248, 6);
			this.toolStripSeparatorTools1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorTools1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.AutoToolTip = true;
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortDirectionToolStripMenuItem,
            this.toolStripSeparator11,
            this.meanAnomalyAtTheEpochToolStripMenuItem1,
            this.argumentOfThePerihelionToolStripMenuItem,
            this.longitudeTheTheAscendingNodeToolStripMenuItem,
            this.inclinationToTheEclipticToolStripMenuItem1,
            this.orbitalEccentricityToolStripMenuItem1,
            this.meanDailyMotionToolStripMenuItem1,
            this.semimajorAxisToolStripMenuItem1,
            this.absoluteMagnitudeToolStripMenuItem1,
            this.slopeParameterToolStripMenuItem1,
            this.numberOfOppositionsToolStripMenuItem1,
            this.numberOfObservationsToolStripMenuItem1,
            this.observationSpanToolStripMenuItem1,
            this.rmsResidualToolStripMenuItem,
            this.computerNameToolStripMenuItem1,
            this.dateOfTheLastObservationToolStripMenuItem1});
			this.toolStripMenuItem1.Enabled = false;
			this.toolStripMenuItem1.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_numbers;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.toolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
			this.toolStripMenuItem1.Text = "Top ten &records";
			this.toolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// sortDirectionToolStripMenuItem
			// 
			this.sortDirectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
			this.sortDirectionToolStripMenuItem.Enabled = false;
			this.sortDirectionToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_cog;
			this.sortDirectionToolStripMenuItem.Name = "sortDirectionToolStripMenuItem";
			this.sortDirectionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.sortDirectionToolStripMenuItem.Text = "Sort direction";
			this.sortDirectionToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.sortDirectionToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// ascendingToolStripMenuItem
			// 
			this.ascendingToolStripMenuItem.Checked = true;
			this.ascendingToolStripMenuItem.CheckOnClick = true;
			this.ascendingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ascendingToolStripMenuItem.Enabled = false;
			this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
			this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.ascendingToolStripMenuItem.Text = "Ascending";
			this.ascendingToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.ascendingToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// descendingToolStripMenuItem
			// 
			this.descendingToolStripMenuItem.CheckOnClick = true;
			this.descendingToolStripMenuItem.Enabled = false;
			this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
			this.descendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.descendingToolStripMenuItem.Text = "Descending";
			this.descendingToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.descendingToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(252, 6);
			this.toolStripSeparator11.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator11.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// meanAnomalyAtTheEpochToolStripMenuItem1
			// 
			this.meanAnomalyAtTheEpochToolStripMenuItem1.Enabled = false;
			this.meanAnomalyAtTheEpochToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("meanAnomalyAtTheEpochToolStripMenuItem1.Image")));
			this.meanAnomalyAtTheEpochToolStripMenuItem1.Name = "meanAnomalyAtTheEpochToolStripMenuItem1";
			this.meanAnomalyAtTheEpochToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.meanAnomalyAtTheEpochToolStripMenuItem1.Text = "Mean anomaly at the epoch";
			this.meanAnomalyAtTheEpochToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.meanAnomalyAtTheEpochToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// argumentOfThePerihelionToolStripMenuItem
			// 
			this.argumentOfThePerihelionToolStripMenuItem.Enabled = false;
			this.argumentOfThePerihelionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("argumentOfThePerihelionToolStripMenuItem.Image")));
			this.argumentOfThePerihelionToolStripMenuItem.Name = "argumentOfThePerihelionToolStripMenuItem";
			this.argumentOfThePerihelionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.argumentOfThePerihelionToolStripMenuItem.Text = "Argument of the perihelion";
			this.argumentOfThePerihelionToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.argumentOfThePerihelionToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// longitudeTheTheAscendingNodeToolStripMenuItem
			// 
			this.longitudeTheTheAscendingNodeToolStripMenuItem.Enabled = false;
			this.longitudeTheTheAscendingNodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("longitudeTheTheAscendingNodeToolStripMenuItem.Image")));
			this.longitudeTheTheAscendingNodeToolStripMenuItem.Name = "longitudeTheTheAscendingNodeToolStripMenuItem";
			this.longitudeTheTheAscendingNodeToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.longitudeTheTheAscendingNodeToolStripMenuItem.Text = "Longitude the the ascending node";
			this.longitudeTheTheAscendingNodeToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.longitudeTheTheAscendingNodeToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// inclinationToTheEclipticToolStripMenuItem1
			// 
			this.inclinationToTheEclipticToolStripMenuItem1.Enabled = false;
			this.inclinationToTheEclipticToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("inclinationToTheEclipticToolStripMenuItem1.Image")));
			this.inclinationToTheEclipticToolStripMenuItem1.Name = "inclinationToTheEclipticToolStripMenuItem1";
			this.inclinationToTheEclipticToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.inclinationToTheEclipticToolStripMenuItem1.Text = "Inclination to the ecliptic";
			this.inclinationToTheEclipticToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.inclinationToTheEclipticToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// orbitalEccentricityToolStripMenuItem1
			// 
			this.orbitalEccentricityToolStripMenuItem1.Enabled = false;
			this.orbitalEccentricityToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("orbitalEccentricityToolStripMenuItem1.Image")));
			this.orbitalEccentricityToolStripMenuItem1.Name = "orbitalEccentricityToolStripMenuItem1";
			this.orbitalEccentricityToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.orbitalEccentricityToolStripMenuItem1.Text = "Orbital eccentricity";
			this.orbitalEccentricityToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.orbitalEccentricityToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// meanDailyMotionToolStripMenuItem1
			// 
			this.meanDailyMotionToolStripMenuItem1.Enabled = false;
			this.meanDailyMotionToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("meanDailyMotionToolStripMenuItem1.Image")));
			this.meanDailyMotionToolStripMenuItem1.Name = "meanDailyMotionToolStripMenuItem1";
			this.meanDailyMotionToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.meanDailyMotionToolStripMenuItem1.Text = "Mean daily motion";
			this.meanDailyMotionToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.meanDailyMotionToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// semimajorAxisToolStripMenuItem1
			// 
			this.semimajorAxisToolStripMenuItem1.Enabled = false;
			this.semimajorAxisToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("semimajorAxisToolStripMenuItem1.Image")));
			this.semimajorAxisToolStripMenuItem1.Name = "semimajorAxisToolStripMenuItem1";
			this.semimajorAxisToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.semimajorAxisToolStripMenuItem1.Text = "Semimajor axis";
			this.semimajorAxisToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.semimajorAxisToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// absoluteMagnitudeToolStripMenuItem1
			// 
			this.absoluteMagnitudeToolStripMenuItem1.Enabled = false;
			this.absoluteMagnitudeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("absoluteMagnitudeToolStripMenuItem1.Image")));
			this.absoluteMagnitudeToolStripMenuItem1.Name = "absoluteMagnitudeToolStripMenuItem1";
			this.absoluteMagnitudeToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.absoluteMagnitudeToolStripMenuItem1.Text = "Absolute magnitude";
			this.absoluteMagnitudeToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.absoluteMagnitudeToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// slopeParameterToolStripMenuItem1
			// 
			this.slopeParameterToolStripMenuItem1.Enabled = false;
			this.slopeParameterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("slopeParameterToolStripMenuItem1.Image")));
			this.slopeParameterToolStripMenuItem1.Name = "slopeParameterToolStripMenuItem1";
			this.slopeParameterToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.slopeParameterToolStripMenuItem1.Text = "Slope parameter";
			this.slopeParameterToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.slopeParameterToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numberOfOppositionsToolStripMenuItem1
			// 
			this.numberOfOppositionsToolStripMenuItem1.Enabled = false;
			this.numberOfOppositionsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("numberOfOppositionsToolStripMenuItem1.Image")));
			this.numberOfOppositionsToolStripMenuItem1.Name = "numberOfOppositionsToolStripMenuItem1";
			this.numberOfOppositionsToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.numberOfOppositionsToolStripMenuItem1.Text = "Number of oppositions";
			this.numberOfOppositionsToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numberOfOppositionsToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numberOfObservationsToolStripMenuItem1
			// 
			this.numberOfObservationsToolStripMenuItem1.Enabled = false;
			this.numberOfObservationsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("numberOfObservationsToolStripMenuItem1.Image")));
			this.numberOfObservationsToolStripMenuItem1.Name = "numberOfObservationsToolStripMenuItem1";
			this.numberOfObservationsToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.numberOfObservationsToolStripMenuItem1.Text = "Number of observations";
			this.numberOfObservationsToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numberOfObservationsToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// observationSpanToolStripMenuItem1
			// 
			this.observationSpanToolStripMenuItem1.Enabled = false;
			this.observationSpanToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("observationSpanToolStripMenuItem1.Image")));
			this.observationSpanToolStripMenuItem1.Name = "observationSpanToolStripMenuItem1";
			this.observationSpanToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.observationSpanToolStripMenuItem1.Text = "Observation span";
			this.observationSpanToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.observationSpanToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// rmsResidualToolStripMenuItem
			// 
			this.rmsResidualToolStripMenuItem.Enabled = false;
			this.rmsResidualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rmsResidualToolStripMenuItem.Image")));
			this.rmsResidualToolStripMenuItem.Name = "rmsResidualToolStripMenuItem";
			this.rmsResidualToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.rmsResidualToolStripMenuItem.Text = "r.m.s. residual";
			this.rmsResidualToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.rmsResidualToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// computerNameToolStripMenuItem1
			// 
			this.computerNameToolStripMenuItem1.Enabled = false;
			this.computerNameToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("computerNameToolStripMenuItem1.Image")));
			this.computerNameToolStripMenuItem1.Name = "computerNameToolStripMenuItem1";
			this.computerNameToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.computerNameToolStripMenuItem1.Text = "Computer name";
			this.computerNameToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.computerNameToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateOfTheLastObservationToolStripMenuItem1
			// 
			this.dateOfTheLastObservationToolStripMenuItem1.Enabled = false;
			this.dateOfTheLastObservationToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("dateOfTheLastObservationToolStripMenuItem1.Image")));
			this.dateOfTheLastObservationToolStripMenuItem1.Name = "dateOfTheLastObservationToolStripMenuItem1";
			this.dateOfTheLastObservationToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
			this.dateOfTheLastObservationToolStripMenuItem1.Text = "Date of the last observation";
			this.dateOfTheLastObservationToolStripMenuItem1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateOfTheLastObservationToolStripMenuItem1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(248, 6);
			// 
			// chartBarToolStripMenuItem
			// 
			this.chartBarToolStripMenuItem.AutoToolTip = true;
			this.chartBarToolStripMenuItem.DoubleClickEnabled = true;
			this.chartBarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanAnomalyAtTheEpochToolStripMenuItem,
            this.argumentOfPerihelionToolStripMenuItem,
            this.longitudeOfTheAscendingNodeToolStripMenuItem,
            this.inclinationToTheEclipticToolStripMenuItem,
            this.orbitalEccentricityToolStripMenuItem,
            this.meanDailyMotionToolStripMenuItem,
            this.semimajorAxisToolStripMenuItem,
            this.absoluteMagnitudeToolStripMenuItem,
            this.slopeParameterToolStripMenuItem,
            this.numberOfOppositionsToolStripMenuItem,
            this.numberOfObservationsToolStripMenuItem,
            this.observationSpanToolStripMenuItem,
            this.rmsResiduaToolStripMenuItem,
            this.computerNameToolStripMenuItem,
            this.dateOfTheLastObservationToolStripMenuItem});
			this.chartBarToolStripMenuItem.Enabled = false;
			this.chartBarToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.chartBarToolStripMenuItem.Name = "chartBarToolStripMenuItem";
			this.chartBarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.chartBarToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
			this.chartBarToolStripMenuItem.Text = "&Distributions";
			this.chartBarToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.chartBarToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// meanAnomalyAtTheEpochToolStripMenuItem
			// 
			this.meanAnomalyAtTheEpochToolStripMenuItem.Enabled = false;
			this.meanAnomalyAtTheEpochToolStripMenuItem.Name = "meanAnomalyAtTheEpochToolStripMenuItem";
			this.meanAnomalyAtTheEpochToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.meanAnomalyAtTheEpochToolStripMenuItem.Text = "Mean anomaly at the epoch";
			// 
			// argumentOfPerihelionToolStripMenuItem
			// 
			this.argumentOfPerihelionToolStripMenuItem.Enabled = false;
			this.argumentOfPerihelionToolStripMenuItem.Name = "argumentOfPerihelionToolStripMenuItem";
			this.argumentOfPerihelionToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.argumentOfPerihelionToolStripMenuItem.Text = "Argument of perihelion";
			// 
			// longitudeOfTheAscendingNodeToolStripMenuItem
			// 
			this.longitudeOfTheAscendingNodeToolStripMenuItem.Enabled = false;
			this.longitudeOfTheAscendingNodeToolStripMenuItem.Name = "longitudeOfTheAscendingNodeToolStripMenuItem";
			this.longitudeOfTheAscendingNodeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.longitudeOfTheAscendingNodeToolStripMenuItem.Text = "Longitude of the ascending node";
			// 
			// inclinationToTheEclipticToolStripMenuItem
			// 
			this.inclinationToTheEclipticToolStripMenuItem.Enabled = false;
			this.inclinationToTheEclipticToolStripMenuItem.Name = "inclinationToTheEclipticToolStripMenuItem";
			this.inclinationToTheEclipticToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.inclinationToTheEclipticToolStripMenuItem.Text = "Inclination to the ecliptic";
			// 
			// orbitalEccentricityToolStripMenuItem
			// 
			this.orbitalEccentricityToolStripMenuItem.Enabled = false;
			this.orbitalEccentricityToolStripMenuItem.Name = "orbitalEccentricityToolStripMenuItem";
			this.orbitalEccentricityToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.orbitalEccentricityToolStripMenuItem.Text = "Orbital eccentricity";
			// 
			// meanDailyMotionToolStripMenuItem
			// 
			this.meanDailyMotionToolStripMenuItem.Enabled = false;
			this.meanDailyMotionToolStripMenuItem.Name = "meanDailyMotionToolStripMenuItem";
			this.meanDailyMotionToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.meanDailyMotionToolStripMenuItem.Text = "Mean daily motion";
			// 
			// semimajorAxisToolStripMenuItem
			// 
			this.semimajorAxisToolStripMenuItem.Enabled = false;
			this.semimajorAxisToolStripMenuItem.Name = "semimajorAxisToolStripMenuItem";
			this.semimajorAxisToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.semimajorAxisToolStripMenuItem.Text = "Semimajor axis";
			// 
			// absoluteMagnitudeToolStripMenuItem
			// 
			this.absoluteMagnitudeToolStripMenuItem.Enabled = false;
			this.absoluteMagnitudeToolStripMenuItem.Name = "absoluteMagnitudeToolStripMenuItem";
			this.absoluteMagnitudeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.absoluteMagnitudeToolStripMenuItem.Text = "Absolute magnitude";
			// 
			// slopeParameterToolStripMenuItem
			// 
			this.slopeParameterToolStripMenuItem.Enabled = false;
			this.slopeParameterToolStripMenuItem.Name = "slopeParameterToolStripMenuItem";
			this.slopeParameterToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.slopeParameterToolStripMenuItem.Text = "Slope parameter";
			// 
			// numberOfOppositionsToolStripMenuItem
			// 
			this.numberOfOppositionsToolStripMenuItem.Enabled = false;
			this.numberOfOppositionsToolStripMenuItem.Name = "numberOfOppositionsToolStripMenuItem";
			this.numberOfOppositionsToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.numberOfOppositionsToolStripMenuItem.Text = "Number of oppositions";
			// 
			// numberOfObservationsToolStripMenuItem
			// 
			this.numberOfObservationsToolStripMenuItem.Enabled = false;
			this.numberOfObservationsToolStripMenuItem.Name = "numberOfObservationsToolStripMenuItem";
			this.numberOfObservationsToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.numberOfObservationsToolStripMenuItem.Text = "Number of observations";
			// 
			// observationSpanToolStripMenuItem
			// 
			this.observationSpanToolStripMenuItem.Enabled = false;
			this.observationSpanToolStripMenuItem.Name = "observationSpanToolStripMenuItem";
			this.observationSpanToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.observationSpanToolStripMenuItem.Text = "Observation span";
			// 
			// rmsResiduaToolStripMenuItem
			// 
			this.rmsResiduaToolStripMenuItem.Enabled = false;
			this.rmsResiduaToolStripMenuItem.Name = "rmsResiduaToolStripMenuItem";
			this.rmsResiduaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.rmsResiduaToolStripMenuItem.Text = "r.m.s. residua";
			// 
			// computerNameToolStripMenuItem
			// 
			this.computerNameToolStripMenuItem.Enabled = false;
			this.computerNameToolStripMenuItem.Name = "computerNameToolStripMenuItem";
			this.computerNameToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.computerNameToolStripMenuItem.Text = "Computer name";
			// 
			// dateOfTheLastObservationToolStripMenuItem
			// 
			this.dateOfTheLastObservationToolStripMenuItem.Enabled = false;
			this.dateOfTheLastObservationToolStripMenuItem.Name = "dateOfTheLastObservationToolStripMenuItem";
			this.dateOfTheLastObservationToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.dateOfTheLastObservationToolStripMenuItem.Text = "Date of the last observation";
			// 
			// toolStripSeparatorTools2
			// 
			this.toolStripSeparatorTools2.Name = "toolStripSeparatorTools2";
			this.toolStripSeparatorTools2.Size = new System.Drawing.Size(248, 6);
			this.toolStripSeparatorTools2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorTools2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripMenuItemDatabaseInformation.Size = new System.Drawing.Size(251, 22);
			this.toolStripMenuItemDatabaseInformation.Text = "Database &information";
			this.toolStripMenuItemDatabaseInformation.Click += new System.EventHandler(this.ToolStripMenuItemDatabaseInformation_Click);
			this.toolStripMenuItemDatabaseInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemDatabaseInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripMenuItemTableMode.Size = new System.Drawing.Size(251, 22);
			this.toolStripMenuItemTableMode.Text = "&Table mode";
			this.toolStripMenuItemTableMode.Click += new System.EventHandler(this.ToolStripMenuItemTableMode_Click);
			this.toolStripMenuItemTableMode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemTableMode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemTerminology
			// 
			this.toolStripMenuItemTerminology.AccessibleDescription = "Show the terminology";
			this.toolStripMenuItemTerminology.AccessibleName = "Terminology";
			this.toolStripMenuItemTerminology.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemTerminology.AutoToolTip = true;
			this.toolStripMenuItemTerminology.DoubleClickEnabled = true;
			this.toolStripMenuItemTerminology.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_bullets;
			this.toolStripMenuItemTerminology.Name = "toolStripMenuItemTerminology";
			this.toolStripMenuItemTerminology.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
			this.toolStripMenuItemTerminology.Size = new System.Drawing.Size(251, 22);
			this.toolStripMenuItemTerminology.Text = "Terminolog&y";
			this.toolStripMenuItemTerminology.Click += new System.EventHandler(this.ToolStripMenuItemTerminology_Click);
			this.toolStripMenuItemTerminology.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemTerminology.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem41,
            this.menuitemCheckMpcorbDat});
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
			this.updateToolStripMenuItem.Text = "&Update";
			this.updateToolStripMenuItem.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.updateToolStripMenuItem.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem41
			// 
			this.toolStripMenuItem41.AccessibleDescription = "Check for updates of the database";
			this.toolStripMenuItem41.AccessibleName = "Check MPCORB.DAT";
			this.toolStripMenuItem41.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItem41.AutoToolTip = true;
			this.toolStripMenuItem41.DoubleClickEnabled = true;
			this.toolStripMenuItem41.Image = global::Planetoid_DB.Properties.Resources.silk_database_lightning;
			this.toolStripMenuItem41.Name = "toolStripMenuItem41";
			this.toolStripMenuItem41.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.toolStripMenuItem41.Size = new System.Drawing.Size(242, 22);
			this.toolStripMenuItem41.Text = "&Check MPCORB.DAT";
			this.toolStripMenuItem41.Click += new System.EventHandler(this.MenuitemCheckMpcorbDat_Click);
			this.toolStripMenuItem41.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem41.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemCheckMpcorbDat
			// 
			this.menuitemCheckMpcorbDat.AccessibleDescription = "Download the database";
			this.menuitemCheckMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			this.menuitemCheckMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.menuitemCheckMpcorbDat.AutoToolTip = true;
			this.menuitemCheckMpcorbDat.DoubleClickEnabled = true;
			this.menuitemCheckMpcorbDat.Image = global::Planetoid_DB.Properties.Resources.silk_package;
			this.menuitemCheckMpcorbDat.Name = "menuitemCheckMpcorbDat";
			this.menuitemCheckMpcorbDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.menuitemCheckMpcorbDat.Size = new System.Drawing.Size(242, 22);
			this.menuitemCheckMpcorbDat.Text = "&Download MPCORB.DAT";
			this.menuitemCheckMpcorbDat.Click += new System.EventHandler(this.MenuitemDownloadMpcorbDat_Click);
			this.menuitemCheckMpcorbDat.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemCheckMpcorbDat.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemOptions
			// 
			this.menuitemOptions.AccessibleDescription = "Open the menu \"options\"";
			this.menuitemOptions.AccessibleName = "Options";
			this.menuitemOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.menuitemOptions.AutoToolTip = true;
			this.menuitemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettings,
            this.toolStripMenuItemStyle,
            this.toolStripSeparatorOptions,
            this.toolStripMenuItemStayOnTop,
            this.toolStripMenuItemEnabledCopyingByDoubleClicking,
            this.toolStripMenuItemEnableLinkingToTerminology});
			this.menuitemOptions.Name = "menuitemOptions";
			this.menuitemOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.menuitemOptions.Size = new System.Drawing.Size(61, 24);
			this.menuitemOptions.Text = "&Options";
			this.menuitemOptions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemOptions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemSettings
			// 
			this.toolStripMenuItemSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemSettings.AutoToolTip = true;
			this.toolStripMenuItemSettings.Enabled = false;
			this.toolStripMenuItemSettings.Image = global::Planetoid_DB.Properties.Resources.silk_wrench;
			this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
			this.toolStripMenuItemSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.toolStripMenuItemSettings.Size = new System.Drawing.Size(302, 22);
			this.toolStripMenuItemSettings.Text = "&Settings";
			this.toolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
			this.toolStripMenuItemSettings.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemSettings.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemStyle
			// 
			this.toolStripMenuItemStyle.AccessibleDescription = "Change the style";
			this.toolStripMenuItemStyle.AccessibleName = "Look and Feel";
			this.toolStripMenuItemStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStyle.AutoToolTip = true;
			this.toolStripMenuItemStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemIconsetSilk,
            this.toolStripMenuItemIconsetFugue,
            this.toolStripMenuItemIconsetFatcow});
			this.toolStripMenuItemStyle.Image = global::Planetoid_DB.Properties.Resources.silk_theme;
			this.toolStripMenuItemStyle.Name = "toolStripMenuItemStyle";
			this.toolStripMenuItemStyle.ShortcutKeyDisplayString = "";
			this.toolStripMenuItemStyle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
			this.toolStripMenuItemStyle.Size = new System.Drawing.Size(302, 22);
			this.toolStripMenuItemStyle.Text = "&Look and Feel";
			this.toolStripMenuItemStyle.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemStyle.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemIconsetSilk
			// 
			this.toolStripMenuItemIconsetSilk.AccessibleDescription = "Change the icon set to Silk icons";
			this.toolStripMenuItemIconsetSilk.AccessibleName = "Silk icons";
			this.toolStripMenuItemIconsetSilk.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemIconsetSilk.AutoToolTip = true;
			this.toolStripMenuItemIconsetSilk.Checked = true;
			this.toolStripMenuItemIconsetSilk.CheckOnClick = true;
			this.toolStripMenuItemIconsetSilk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemIconsetSilk.Enabled = false;
			this.toolStripMenuItemIconsetSilk.Name = "toolStripMenuItemIconsetSilk";
			this.toolStripMenuItemIconsetSilk.Size = new System.Drawing.Size(143, 22);
			this.toolStripMenuItemIconsetSilk.Text = "Silk icons";
			this.toolStripMenuItemIconsetSilk.Click += new System.EventHandler(this.ToolStripMenuItemIconsetSilk_Click);
			this.toolStripMenuItemIconsetSilk.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemIconsetSilk.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemIconsetFugue
			// 
			this.toolStripMenuItemIconsetFugue.AccessibleDescription = "Change the icon set to Fugue icons";
			this.toolStripMenuItemIconsetFugue.AccessibleName = "Fugue icons";
			this.toolStripMenuItemIconsetFugue.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemIconsetFugue.AutoToolTip = true;
			this.toolStripMenuItemIconsetFugue.CheckOnClick = true;
			this.toolStripMenuItemIconsetFugue.Enabled = false;
			this.toolStripMenuItemIconsetFugue.Name = "toolStripMenuItemIconsetFugue";
			this.toolStripMenuItemIconsetFugue.Size = new System.Drawing.Size(143, 22);
			this.toolStripMenuItemIconsetFugue.Text = "Fugue icons";
			this.toolStripMenuItemIconsetFugue.Click += new System.EventHandler(this.ToolStripMenuItemIconsetFugue_Click);
			this.toolStripMenuItemIconsetFugue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemIconsetFugue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemIconsetFatcow
			// 
			this.toolStripMenuItemIconsetFatcow.AccessibleDescription = "Change the icon set to Fatcow icons";
			this.toolStripMenuItemIconsetFatcow.AccessibleName = "Fatcow icons";
			this.toolStripMenuItemIconsetFatcow.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemIconsetFatcow.AutoToolTip = true;
			this.toolStripMenuItemIconsetFatcow.CheckOnClick = true;
			this.toolStripMenuItemIconsetFatcow.Enabled = false;
			this.toolStripMenuItemIconsetFatcow.Name = "toolStripMenuItemIconsetFatcow";
			this.toolStripMenuItemIconsetFatcow.Size = new System.Drawing.Size(143, 22);
			this.toolStripMenuItemIconsetFatcow.Text = "Fatcow icons";
			this.toolStripMenuItemIconsetFatcow.Click += new System.EventHandler(this.ToolStripMenuItemIconsetFatcow_Click);
			this.toolStripMenuItemIconsetFatcow.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemIconsetFatcow.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparatorOptions
			// 
			this.toolStripSeparatorOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
			this.toolStripSeparatorOptions.Name = "toolStripSeparatorOptions";
			this.toolStripSeparatorOptions.Size = new System.Drawing.Size(299, 6);
			this.toolStripSeparatorOptions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparatorOptions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemStayOnTop
			// 
			this.toolStripMenuItemStayOnTop.AccessibleDescription = "Stay the application always on top";
			this.toolStripMenuItemStayOnTop.AccessibleName = "Stay always on top";
			this.toolStripMenuItemStayOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStayOnTop.AutoToolTip = true;
			this.toolStripMenuItemStayOnTop.CheckOnClick = true;
			this.toolStripMenuItemStayOnTop.Name = "toolStripMenuItemStayOnTop";
			this.toolStripMenuItemStayOnTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
			this.toolStripMenuItemStayOnTop.Size = new System.Drawing.Size(302, 22);
			this.toolStripMenuItemStayOnTop.Text = "Stay always on &top";
			this.toolStripMenuItemStayOnTop.Click += new System.EventHandler(this.ToolStripMenuItemStayOnTop_Click);
			this.toolStripMenuItemStayOnTop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemStayOnTop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemEnabledCopyingByDoubleClicking
			// 
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.AccessibleDescription = "Enabled copying data to the clipboard by double-clicking";
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.AccessibleName = "Enabled copying by double-clicking";
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.AutoToolTip = true;
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.Checked = true;
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.CheckOnClick = true;
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.Name = "toolStripMenuItemEnabledCopyingByDoubleClicking";
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.Size = new System.Drawing.Size(302, 22);
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.Text = "Enabled &copying by double-clicking";
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.Click += new System.EventHandler(this.ToolStripMenuItemEnableCopyingByDoubleClicking_Click);
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemEnabledCopyingByDoubleClicking.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemEnableLinkingToTerminology
			// 
			this.toolStripMenuItemEnableLinkingToTerminology.AccessibleDescription = "Enable linking to terminology";
			this.toolStripMenuItemEnableLinkingToTerminology.AccessibleName = "Enable linking to terminology";
			this.toolStripMenuItemEnableLinkingToTerminology.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemEnableLinkingToTerminology.AutoToolTip = true;
			this.toolStripMenuItemEnableLinkingToTerminology.Checked = true;
			this.toolStripMenuItemEnableLinkingToTerminology.CheckOnClick = true;
			this.toolStripMenuItemEnableLinkingToTerminology.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemEnableLinkingToTerminology.Enabled = false;
			this.toolStripMenuItemEnableLinkingToTerminology.Name = "toolStripMenuItemEnableLinkingToTerminology";
			this.toolStripMenuItemEnableLinkingToTerminology.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
			this.toolStripMenuItemEnableLinkingToTerminology.Size = new System.Drawing.Size(302, 22);
			this.toolStripMenuItemEnableLinkingToTerminology.Text = "Enable linking to terminolog&y";
			this.toolStripMenuItemEnableLinkingToTerminology.Click += new System.EventHandler(this.ToolStripMenuItemEnableLinkingToTerminology_Click);
			this.toolStripMenuItemEnableLinkingToTerminology.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemEnableLinkingToTerminology.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
            this.toolStripSplitButtonExport,
            this.toolStripButtonPrint,
            this.toolStripSplitButtonCopyToClipboard,
            this.toolStripSeparator4,
            this.toolStripButtonDatabaseInformation,
            this.toolStripButtonTableMode,
            this.toolStripButtonTerminology,
            this.toolStripSeparator3,
            this.toolStripSplitButton2,
            this.toolStripSplitButton1,
            this.toolStripSeparator5,
            this.toolStripButtonCheckMpcorbDat,
            this.toolStripButtonDownloadMpcorbDat,
            this.toolStripSeparator1,
            this.toolStripButtonAbout,
            this.toolStripButtonOpenWebsitePDB,
            this.toolStripSeparator2,
            this.toolStripLabelQuickSearch,
            this.toolStripTextBoxSearch,
            this.toolStripButtonSearch});
			this.toolStripIcons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripIcons.Location = new System.Drawing.Point(0, 24);
			this.toolStripIcons.Name = "toolStripIcons";
			this.toolStripIcons.Size = new System.Drawing.Size(770, 25);
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
			// toolStripSplitButtonExport
			// 
			this.toolStripSplitButtonExport.AccessibleDescription = "ExprtDataEntry";
			this.toolStripSplitButtonExport.AccessibleName = "Export";
			this.toolStripSplitButtonExport.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportAsTxt,
            this.toolStripMenuItemExportAsHtml,
            this.toolStripMenuItemExportAsXml,
            this.toolStripMenuItemExportAsJson});
			this.toolStripSplitButtonExport.Enabled = false;
			this.toolStripSplitButtonExport.Image = global::Planetoid_DB.Properties.Resources.silk_page_save;
			this.toolStripSplitButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonExport.Name = "toolStripSplitButtonExport";
			this.toolStripSplitButtonExport.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButtonExport.Text = "Export";
			this.toolStripSplitButtonExport.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButtonExport.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportAsTxt
			// 
			this.toolStripMenuItemExportAsTxt.AccessibleDescription = "Export data entry as TXT";
			this.toolStripMenuItemExportAsTxt.AccessibleName = "Export data entry as TXT";
			this.toolStripMenuItemExportAsTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportAsTxt.Enabled = false;
			this.toolStripMenuItemExportAsTxt.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_text;
			this.toolStripMenuItemExportAsTxt.Name = "toolStripMenuItemExportAsTxt";
			this.toolStripMenuItemExportAsTxt.Size = new System.Drawing.Size(120, 22);
			this.toolStripMenuItemExportAsTxt.Text = "as &TXT";
			this.toolStripMenuItemExportAsTxt.ToolTipText = "Export data entry as TXT";
			this.toolStripMenuItemExportAsTxt.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportAsTxt.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportAsHtml
			// 
			this.toolStripMenuItemExportAsHtml.AccessibleDescription = "Export data entry as HTML";
			this.toolStripMenuItemExportAsHtml.AccessibleName = "Export data entry as HTML";
			this.toolStripMenuItemExportAsHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportAsHtml.Enabled = false;
			this.toolStripMenuItemExportAsHtml.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExportAsHtml.Image")));
			this.toolStripMenuItemExportAsHtml.Name = "toolStripMenuItemExportAsHtml";
			this.toolStripMenuItemExportAsHtml.Size = new System.Drawing.Size(120, 22);
			this.toolStripMenuItemExportAsHtml.Text = "as &HTML";
			this.toolStripMenuItemExportAsHtml.ToolTipText = "Export data entry as HTML";
			this.toolStripMenuItemExportAsHtml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportAsHtml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportAsXml
			// 
			this.toolStripMenuItemExportAsXml.AccessibleDescription = "Export data entry as XML";
			this.toolStripMenuItemExportAsXml.AccessibleName = "Export data entry as XML";
			this.toolStripMenuItemExportAsXml.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportAsXml.Enabled = false;
			this.toolStripMenuItemExportAsXml.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExportAsXml.Image")));
			this.toolStripMenuItemExportAsXml.Name = "toolStripMenuItemExportAsXml";
			this.toolStripMenuItemExportAsXml.Size = new System.Drawing.Size(120, 22);
			this.toolStripMenuItemExportAsXml.Text = "as &XML";
			this.toolStripMenuItemExportAsXml.ToolTipText = "Export data entry as XML";
			this.toolStripMenuItemExportAsXml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportAsXml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemExportAsJson
			// 
			this.toolStripMenuItemExportAsJson.AccessibleDescription = "Export data entry as JSON";
			this.toolStripMenuItemExportAsJson.AccessibleName = "Export data entry as JSON";
			this.toolStripMenuItemExportAsJson.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemExportAsJson.Enabled = false;
			this.toolStripMenuItemExportAsJson.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExportAsJson.Image")));
			this.toolStripMenuItemExportAsJson.Name = "toolStripMenuItemExportAsJson";
			this.toolStripMenuItemExportAsJson.Size = new System.Drawing.Size(120, 22);
			this.toolStripMenuItemExportAsJson.Text = "as &JSON";
			this.toolStripMenuItemExportAsJson.ToolTipText = "Export data entry as JSON";
			this.toolStripMenuItemExportAsJson.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemExportAsJson.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripButtonPrint.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonPrint.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSplitButtonCopyToClipboard
			// 
			this.toolStripSplitButtonCopyToClipboard.AccessibleDescription = "Copy to clipboard";
			this.toolStripSplitButtonCopyToClipboard.AccessibleName = "Copy to clipboard";
			this.toolStripSplitButtonCopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButtonCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonCopyToClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopyIndexNumber,
            this.toolStripMenuItemCopyReadableDesignation,
            this.toolStripMenuItemCopyEpoch,
            this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch,
            this.toolStripMenuItemCopyArgumentOfPerihelion,
            this.toolStripMenuItemCopyLongitudeOfTheAscendingNode,
            this.toolStripMenuItemCopyInclination,
            this.toolStripMenuItemCopyEccentricity,
            this.toolStripMenuItemCopyMeanDailyMotion,
            this.toolStripMenuItemCopySemimajorAxis,
            this.toolStripMenuItemCopyAbsoluteMagnitude,
            this.toolStripMenuItemCopySlopeParameter,
            this.toolStripMenuItemCopyReference,
            this.toolStripMenuItemCopyNumberOfOppositions,
            this.toolStripMenuItemCopyNumberOfObservations,
            this.toolStripMenuItemCopyObservationSpan,
            this.toolStripMenuItemCopyRmsResidual,
            this.toolStripMenuItemCopyComputername,
            this.toolStripMenuItemCopyDateOfLastObservation,
            this.toolStripMenuItemCopyFlags});
			this.toolStripSplitButtonCopyToClipboard.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.toolStripSplitButtonCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonCopyToClipboard.Name = "toolStripSplitButtonCopyToClipboard";
			this.toolStripSplitButtonCopyToClipboard.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButtonCopyToClipboard.Text = "Copy to clipboard";
			this.toolStripSplitButtonCopyToClipboard.ButtonClick += new System.EventHandler(this.ToolStripButtonCopyToClipboard_Click);
			this.toolStripSplitButtonCopyToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButtonCopyToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyIndexNumber
			// 
			this.toolStripMenuItemCopyIndexNumber.AccessibleDescription = "Copy to clipboard: Index number";
			this.toolStripMenuItemCopyIndexNumber.AccessibleName = "Copy to clipboard: Index number";
			this.toolStripMenuItemCopyIndexNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyIndexNumber.AutoToolTip = true;
			this.toolStripMenuItemCopyIndexNumber.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyIndexNumber.Image")));
			this.toolStripMenuItemCopyIndexNumber.Name = "toolStripMenuItemCopyIndexNumber";
			this.toolStripMenuItemCopyIndexNumber.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyIndexNumber.Text = "Index No.";
			this.toolStripMenuItemCopyIndexNumber.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardIndexNumber_Click);
			this.toolStripMenuItemCopyIndexNumber.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyIndexNumber.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyReadableDesignation
			// 
			this.toolStripMenuItemCopyReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			this.toolStripMenuItemCopyReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			this.toolStripMenuItemCopyReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyReadableDesignation.AutoToolTip = true;
			this.toolStripMenuItemCopyReadableDesignation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyReadableDesignation.Image")));
			this.toolStripMenuItemCopyReadableDesignation.Name = "toolStripMenuItemCopyReadableDesignation";
			this.toolStripMenuItemCopyReadableDesignation.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyReadableDesignation.Text = "Readable designation";
			this.toolStripMenuItemCopyReadableDesignation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReadableDesignation_Click);
			this.toolStripMenuItemCopyReadableDesignation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyReadableDesignation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyEpoch
			// 
			this.toolStripMenuItemCopyEpoch.AccessibleDescription = "Copy to clipboard: Epoch";
			this.toolStripMenuItemCopyEpoch.AccessibleName = "Copy to clipboard: Epoch";
			this.toolStripMenuItemCopyEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyEpoch.AutoToolTip = true;
			this.toolStripMenuItemCopyEpoch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyEpoch.Image")));
			this.toolStripMenuItemCopyEpoch.Name = "toolStripMenuItemCopyEpoch";
			this.toolStripMenuItemCopyEpoch.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.toolStripMenuItemCopyEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardEpoch_Click);
			this.toolStripMenuItemCopyEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyMeanAnomalyAtTheEpoch
			// 
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch";
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch";
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.AutoToolTip = true;
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyMeanAnomalyAtTheEpoch.Image")));
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.Name = "toolStripMenuItemCopyMeanAnomalyAtTheEpoch";
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch (degrees)";
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanAnomaly_Click);
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyMeanAnomalyAtTheEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyArgumentOfPerihelion
			// 
			this.toolStripMenuItemCopyArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion";
			this.toolStripMenuItemCopyArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion";
			this.toolStripMenuItemCopyArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyArgumentOfPerihelion.AutoToolTip = true;
			this.toolStripMenuItemCopyArgumentOfPerihelion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyArgumentOfPerihelion.Image")));
			this.toolStripMenuItemCopyArgumentOfPerihelion.Name = "toolStripMenuItemCopyArgumentOfPerihelion";
			this.toolStripMenuItemCopyArgumentOfPerihelion.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (degrees)";
			this.toolStripMenuItemCopyArgumentOfPerihelion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click);
			this.toolStripMenuItemCopyArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyLongitudeOfTheAscendingNode
			// 
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node";
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node";
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyLongitudeOfTheAscendingNode.Image")));
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.Name = "toolStripMenuItemCopyLongitudeOfTheAscendingNode";
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0";
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click);
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyInclination
			// 
			this.toolStripMenuItemCopyInclination.AccessibleDescription = "Copy to clipboard: Inclination";
			this.toolStripMenuItemCopyInclination.AccessibleName = "Copy to clipboard: Inclination";
			this.toolStripMenuItemCopyInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyInclination.AutoToolTip = true;
			this.toolStripMenuItemCopyInclination.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyInclination.Image")));
			this.toolStripMenuItemCopyInclination.Name = "toolStripMenuItemCopyInclination";
			this.toolStripMenuItemCopyInclination.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyInclination.Text = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.toolStripMenuItemCopyInclination.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardInclination_Click);
			this.toolStripMenuItemCopyInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyEccentricity
			// 
			this.toolStripMenuItemCopyEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.toolStripMenuItemCopyEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.toolStripMenuItemCopyEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyEccentricity.AutoToolTip = true;
			this.toolStripMenuItemCopyEccentricity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyEccentricity.Image")));
			this.toolStripMenuItemCopyEccentricity.Name = "toolStripMenuItemCopyEccentricity";
			this.toolStripMenuItemCopyEccentricity.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyEccentricity.Text = "Orbital eccentricity";
			this.toolStripMenuItemCopyEccentricity.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click);
			this.toolStripMenuItemCopyEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyMeanDailyMotion
			// 
			this.toolStripMenuItemCopyMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion";
			this.toolStripMenuItemCopyMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion";
			this.toolStripMenuItemCopyMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyMeanDailyMotion.AutoToolTip = true;
			this.toolStripMenuItemCopyMeanDailyMotion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyMeanDailyMotion.Image")));
			this.toolStripMenuItemCopyMeanDailyMotion.Name = "toolStripMenuItemCopyMeanDailyMotion";
			this.toolStripMenuItemCopyMeanDailyMotion.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyMeanDailyMotion.Text = "Mean daily motion (degrees per day)";
			this.toolStripMenuItemCopyMeanDailyMotion.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click);
			this.toolStripMenuItemCopyMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopySemimajorAxis
			// 
			this.toolStripMenuItemCopySemimajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis";
			this.toolStripMenuItemCopySemimajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis";
			this.toolStripMenuItemCopySemimajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopySemimajorAxis.AutoToolTip = true;
			this.toolStripMenuItemCopySemimajorAxis.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopySemimajorAxis.Image")));
			this.toolStripMenuItemCopySemimajorAxis.Name = "toolStripMenuItemCopySemimajorAxis";
			this.toolStripMenuItemCopySemimajorAxis.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopySemimajorAxis.Text = "Semi-major axis (AU)";
			this.toolStripMenuItemCopySemimajorAxis.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardSemimajorAxis_Click);
			this.toolStripMenuItemCopySemimajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopySemimajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyAbsoluteMagnitude
			// 
			this.toolStripMenuItemCopyAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude";
			this.toolStripMenuItemCopyAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude";
			this.toolStripMenuItemCopyAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyAbsoluteMagnitude.AutoToolTip = true;
			this.toolStripMenuItemCopyAbsoluteMagnitude.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyAbsoluteMagnitude.Image")));
			this.toolStripMenuItemCopyAbsoluteMagnitude.Name = "toolStripMenuItemCopyAbsoluteMagnitude";
			this.toolStripMenuItemCopyAbsoluteMagnitude.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyAbsoluteMagnitude.Text = "Absolute magnitude, H";
			this.toolStripMenuItemCopyAbsoluteMagnitude.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click);
			this.toolStripMenuItemCopyAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopySlopeParameter
			// 
			this.toolStripMenuItemCopySlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter";
			this.toolStripMenuItemCopySlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter";
			this.toolStripMenuItemCopySlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopySlopeParameter.AutoToolTip = true;
			this.toolStripMenuItemCopySlopeParameter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopySlopeParameter.Image")));
			this.toolStripMenuItemCopySlopeParameter.Name = "toolStripMenuItemCopySlopeParameter";
			this.toolStripMenuItemCopySlopeParameter.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopySlopeParameter.Text = "Slope parameter, G";
			this.toolStripMenuItemCopySlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopySlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyReference
			// 
			this.toolStripMenuItemCopyReference.AccessibleDescription = "Copy to clipboard: Reference";
			this.toolStripMenuItemCopyReference.AccessibleName = "Copy to clipboard: Reference";
			this.toolStripMenuItemCopyReference.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyReference.AutoToolTip = true;
			this.toolStripMenuItemCopyReference.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyReference.Image")));
			this.toolStripMenuItemCopyReference.Name = "toolStripMenuItemCopyReference";
			this.toolStripMenuItemCopyReference.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyReference.Text = "Reference";
			this.toolStripMenuItemCopyReference.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardReference_Click);
			this.toolStripMenuItemCopyReference.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyReference.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyNumberOfOppositions
			// 
			this.toolStripMenuItemCopyNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			this.toolStripMenuItemCopyNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions ";
			this.toolStripMenuItemCopyNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyNumberOfOppositions.AutoToolTip = true;
			this.toolStripMenuItemCopyNumberOfOppositions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyNumberOfOppositions.Image")));
			this.toolStripMenuItemCopyNumberOfOppositions.Name = "toolStripMenuItemCopyNumberOfOppositions";
			this.toolStripMenuItemCopyNumberOfOppositions.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyNumberOfOppositions.Text = "Number of oppositions";
			this.toolStripMenuItemCopyNumberOfOppositions.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click);
			this.toolStripMenuItemCopyNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyNumberOfObservations
			// 
			this.toolStripMenuItemCopyNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			this.toolStripMenuItemCopyNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			this.toolStripMenuItemCopyNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyNumberOfObservations.AutoToolTip = true;
			this.toolStripMenuItemCopyNumberOfObservations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyNumberOfObservations.Image")));
			this.toolStripMenuItemCopyNumberOfObservations.Name = "toolStripMenuItemCopyNumberOfObservations";
			this.toolStripMenuItemCopyNumberOfObservations.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyNumberOfObservations.Text = "Number of observations";
			this.toolStripMenuItemCopyNumberOfObservations.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardNumberOfObservations_Click);
			this.toolStripMenuItemCopyNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyObservationSpan
			// 
			this.toolStripMenuItemCopyObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.toolStripMenuItemCopyObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.toolStripMenuItemCopyObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyObservationSpan.AutoToolTip = true;
			this.toolStripMenuItemCopyObservationSpan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyObservationSpan.Image")));
			this.toolStripMenuItemCopyObservationSpan.Name = "toolStripMenuItemCopyObservationSpan";
			this.toolStripMenuItemCopyObservationSpan.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyObservationSpan.Text = "Observation span";
			this.toolStripMenuItemCopyObservationSpan.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardObservationSpan_Click);
			this.toolStripMenuItemCopyObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyRmsResidual
			// 
			this.toolStripMenuItemCopyRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual";
			this.toolStripMenuItemCopyRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual";
			this.toolStripMenuItemCopyRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyRmsResidual.AutoToolTip = true;
			this.toolStripMenuItemCopyRmsResidual.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyRmsResidual.Image")));
			this.toolStripMenuItemCopyRmsResidual.Name = "toolStripMenuItemCopyRmsResidual";
			this.toolStripMenuItemCopyRmsResidual.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyRmsResidual.Text = "r.m.s. residual (\")";
			this.toolStripMenuItemCopyRmsResidual.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardRmsResidual_Click);
			this.toolStripMenuItemCopyRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyComputername
			// 
			this.toolStripMenuItemCopyComputername.AccessibleDescription = "Copy to clipboard: Computer name";
			this.toolStripMenuItemCopyComputername.AccessibleName = "Copy to clipboard: Computer name";
			this.toolStripMenuItemCopyComputername.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyComputername.AutoToolTip = true;
			this.toolStripMenuItemCopyComputername.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyComputername.Image")));
			this.toolStripMenuItemCopyComputername.Name = "toolStripMenuItemCopyComputername";
			this.toolStripMenuItemCopyComputername.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyComputername.Text = "Computer name";
			this.toolStripMenuItemCopyComputername.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardComputername_Click);
			this.toolStripMenuItemCopyComputername.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyComputername.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyDateOfLastObservation
			// 
			this.toolStripMenuItemCopyDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation";
			this.toolStripMenuItemCopyDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation";
			this.toolStripMenuItemCopyDateOfLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyDateOfLastObservation.AutoToolTip = true;
			this.toolStripMenuItemCopyDateOfLastObservation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyDateOfLastObservation.Image")));
			this.toolStripMenuItemCopyDateOfLastObservation.Name = "toolStripMenuItemCopyDateOfLastObservation";
			this.toolStripMenuItemCopyDateOfLastObservation.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyDateOfLastObservation.Text = "Date of last observation";
			this.toolStripMenuItemCopyDateOfLastObservation.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click);
			this.toolStripMenuItemCopyDateOfLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyDateOfLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyFlags
			// 
			this.toolStripMenuItemCopyFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.toolStripMenuItemCopyFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.toolStripMenuItemCopyFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemCopyFlags.AutoToolTip = true;
			this.toolStripMenuItemCopyFlags.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopyFlags.Image")));
			this.toolStripMenuItemCopyFlags.Name = "toolStripMenuItemCopyFlags";
			this.toolStripMenuItemCopyFlags.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItemCopyFlags.Text = "4-hexdigit flags";
			this.toolStripMenuItemCopyFlags.Click += new System.EventHandler(this.ToolStripMenuItemCopyToClipboardFlags_Click);
			this.toolStripMenuItemCopyFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			// toolStripSplitButton2
			// 
			this.toolStripSplitButton2.AccessibleDescription = "Chart bar";
			this.toolStripSplitButton2.AccessibleName = "Chart bar";
			this.toolStripSplitButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton2.DoubleClickEnabled = true;
			this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripSeparator14,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21});
			this.toolStripSplitButton2.Enabled = false;
			this.toolStripSplitButton2.Image = global::Planetoid_DB.Properties.Resources.silk_text_list_numbers;
			this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton2.Name = "toolStripSplitButton2";
			this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton2.Text = "Top ten records";
			this.toolStripSplitButton2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButton2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
			this.toolStripMenuItem3.Enabled = false;
			this.toolStripMenuItem3.Image = global::Planetoid_DB.Properties.Resources.silk_cog;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem3.Text = "Sort direction";
			this.toolStripMenuItem3.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem3.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Checked = true;
			this.toolStripMenuItem4.CheckOnClick = true;
			this.toolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItem4.Enabled = false;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(136, 22);
			this.toolStripMenuItem4.Text = "Ascending";
			this.toolStripMenuItem4.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem4.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.CheckOnClick = true;
			this.toolStripMenuItem5.Enabled = false;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(136, 22);
			this.toolStripMenuItem5.Text = "Descending";
			this.toolStripMenuItem5.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem5.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSeparator14
			// 
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new System.Drawing.Size(252, 6);
			this.toolStripSeparator14.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSeparator14.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Enabled = false;
			this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem6.Text = "Mean anomaly at the epoch";
			this.toolStripMenuItem6.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem6.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Enabled = false;
			this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem7.Text = "Argument of the perihelion";
			this.toolStripMenuItem7.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem7.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Enabled = false;
			this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem8.Text = "Longitude the the ascending node";
			this.toolStripMenuItem8.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem8.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Enabled = false;
			this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem9.Text = "Inclination to the ecliptic";
			this.toolStripMenuItem9.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem9.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Enabled = false;
			this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem11.Text = "Orbital eccentricity";
			this.toolStripMenuItem11.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem11.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Enabled = false;
			this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem12.Text = "Mean daily motion";
			this.toolStripMenuItem12.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem12.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.Enabled = false;
			this.toolStripMenuItem13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem13.Image")));
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem13.Text = "Semimajor axis";
			this.toolStripMenuItem13.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem13.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.Enabled = false;
			this.toolStripMenuItem14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem14.Image")));
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem14.Text = "Absolute magnitude";
			this.toolStripMenuItem14.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem14.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem15
			// 
			this.toolStripMenuItem15.Enabled = false;
			this.toolStripMenuItem15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem15.Image")));
			this.toolStripMenuItem15.Name = "toolStripMenuItem15";
			this.toolStripMenuItem15.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem15.Text = "Slope parameter";
			this.toolStripMenuItem15.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem15.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem16
			// 
			this.toolStripMenuItem16.Enabled = false;
			this.toolStripMenuItem16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem16.Image")));
			this.toolStripMenuItem16.Name = "toolStripMenuItem16";
			this.toolStripMenuItem16.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem16.Text = "Number of oppositions";
			this.toolStripMenuItem16.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem16.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem17
			// 
			this.toolStripMenuItem17.Enabled = false;
			this.toolStripMenuItem17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem17.Image")));
			this.toolStripMenuItem17.Name = "toolStripMenuItem17";
			this.toolStripMenuItem17.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem17.Text = "Number of observations";
			this.toolStripMenuItem17.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem17.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem18
			// 
			this.toolStripMenuItem18.Enabled = false;
			this.toolStripMenuItem18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem18.Image")));
			this.toolStripMenuItem18.Name = "toolStripMenuItem18";
			this.toolStripMenuItem18.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem18.Text = "Observation span";
			this.toolStripMenuItem18.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem18.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem19
			// 
			this.toolStripMenuItem19.Enabled = false;
			this.toolStripMenuItem19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem19.Image")));
			this.toolStripMenuItem19.Name = "toolStripMenuItem19";
			this.toolStripMenuItem19.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem19.Text = "r.m.s. residual";
			this.toolStripMenuItem19.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem19.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem20
			// 
			this.toolStripMenuItem20.Enabled = false;
			this.toolStripMenuItem20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem20.Image")));
			this.toolStripMenuItem20.Name = "toolStripMenuItem20";
			this.toolStripMenuItem20.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem20.Text = "Date of the last observation";
			this.toolStripMenuItem20.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem20.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem21
			// 
			this.toolStripMenuItem21.Enabled = false;
			this.toolStripMenuItem21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem21.Image")));
			this.toolStripMenuItem21.Name = "toolStripMenuItem21";
			this.toolStripMenuItem21.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem21.Text = "Computer name";
			this.toolStripMenuItem21.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem21.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.AccessibleDescription = "Chart bar";
			this.toolStripSplitButton1.AccessibleName = "Chart bar";
			this.toolStripSplitButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.DoubleClickEnabled = true;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.toolStripMenuItem28,
            this.toolStripMenuItem29,
            this.toolStripMenuItem30,
            this.toolStripMenuItem31,
            this.toolStripMenuItem32,
            this.toolStripMenuItem33,
            this.toolStripMenuItem34,
            this.toolStripMenuItem35,
            this.toolStripMenuItem36});
			this.toolStripSplitButton1.Enabled = false;
			this.toolStripSplitButton1.Image = global::Planetoid_DB.Properties.Resources.silk_chart_bar;
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton1.Text = "Distributions";
			this.toolStripSplitButton1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButton1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem22
			// 
			this.toolStripMenuItem22.Enabled = false;
			this.toolStripMenuItem22.Name = "toolStripMenuItem22";
			this.toolStripMenuItem22.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem22.Text = "Mean anomaly at the epoch";
			this.toolStripMenuItem22.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem22.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem23
			// 
			this.toolStripMenuItem23.Enabled = false;
			this.toolStripMenuItem23.Name = "toolStripMenuItem23";
			this.toolStripMenuItem23.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem23.Text = "Argument of perihelion";
			this.toolStripMenuItem23.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem23.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem24
			// 
			this.toolStripMenuItem24.Enabled = false;
			this.toolStripMenuItem24.Name = "toolStripMenuItem24";
			this.toolStripMenuItem24.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem24.Text = "Longitude of the ascending node";
			this.toolStripMenuItem24.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem24.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem25
			// 
			this.toolStripMenuItem25.Enabled = false;
			this.toolStripMenuItem25.Name = "toolStripMenuItem25";
			this.toolStripMenuItem25.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem25.Text = "Inclination to the ecliptic";
			this.toolStripMenuItem25.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem25.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem26
			// 
			this.toolStripMenuItem26.Enabled = false;
			this.toolStripMenuItem26.Name = "toolStripMenuItem26";
			this.toolStripMenuItem26.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem26.Text = "Orbital eccentricity";
			this.toolStripMenuItem26.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem26.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem27
			// 
			this.toolStripMenuItem27.Enabled = false;
			this.toolStripMenuItem27.Name = "toolStripMenuItem27";
			this.toolStripMenuItem27.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem27.Text = "Mean daily motion";
			this.toolStripMenuItem27.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem27.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem28
			// 
			this.toolStripMenuItem28.Enabled = false;
			this.toolStripMenuItem28.Name = "toolStripMenuItem28";
			this.toolStripMenuItem28.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem28.Text = "Semimajor axis";
			this.toolStripMenuItem28.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem28.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem29
			// 
			this.toolStripMenuItem29.Enabled = false;
			this.toolStripMenuItem29.Name = "toolStripMenuItem29";
			this.toolStripMenuItem29.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem29.Text = "Absolute magnitude";
			this.toolStripMenuItem29.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem29.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem30
			// 
			this.toolStripMenuItem30.Enabled = false;
			this.toolStripMenuItem30.Name = "toolStripMenuItem30";
			this.toolStripMenuItem30.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem30.Text = "Slope parameter";
			this.toolStripMenuItem30.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem30.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem31
			// 
			this.toolStripMenuItem31.Enabled = false;
			this.toolStripMenuItem31.Name = "toolStripMenuItem31";
			this.toolStripMenuItem31.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem31.Text = "Number of oppositions";
			this.toolStripMenuItem31.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem31.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem32
			// 
			this.toolStripMenuItem32.Enabled = false;
			this.toolStripMenuItem32.Name = "toolStripMenuItem32";
			this.toolStripMenuItem32.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem32.Text = "Number of observations";
			this.toolStripMenuItem32.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem32.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem33
			// 
			this.toolStripMenuItem33.Enabled = false;
			this.toolStripMenuItem33.Name = "toolStripMenuItem33";
			this.toolStripMenuItem33.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem33.Text = "Observation span";
			this.toolStripMenuItem33.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem33.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem34
			// 
			this.toolStripMenuItem34.Enabled = false;
			this.toolStripMenuItem34.Name = "toolStripMenuItem34";
			this.toolStripMenuItem34.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem34.Text = "r.m.s. residua";
			this.toolStripMenuItem34.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem34.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem35
			// 
			this.toolStripMenuItem35.Enabled = false;
			this.toolStripMenuItem35.Name = "toolStripMenuItem35";
			this.toolStripMenuItem35.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem35.Text = "Computer name";
			this.toolStripMenuItem35.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem35.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItem36
			// 
			this.toolStripMenuItem36.Enabled = false;
			this.toolStripMenuItem36.Name = "toolStripMenuItem36";
			this.toolStripMenuItem36.Size = new System.Drawing.Size(249, 22);
			this.toolStripMenuItem36.Text = "Date of the last observation";
			this.toolStripMenuItem36.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItem36.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripLabelQuickSearch.Enabled = false;
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
			this.toolStripTextBoxSearch.Enabled = false;
			this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
			this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxSearch.ToolTipText = "Search";
			this.toolStripTextBoxSearch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripTextBoxSearch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.toolStripTextBoxSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripTextBoxSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripButtonSearch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripButtonSearch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripNavigation.Size = new System.Drawing.Size(770, 25);
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
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(770, 235);
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
			this.toolStripContainer.Size = new System.Drawing.Size(770, 331);
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
			this.ClientSize = new System.Drawing.Size(770, 331);
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
			this.contextMenuCopyToClipboard.ResumeLayout(false);
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
    private System.Windows.Forms.Label labelFlagsData;
    private System.Windows.Forms.Label labelReferenceData;
    private System.Windows.Forms.Label labelDesignationNameData;
    private System.Windows.Forms.Label labelEpochData;
    private System.Windows.Forms.Label labelMeanAnomalyData;
    private System.Windows.Forms.Label labelArgumentPerihelionData;
    private System.Windows.Forms.Label labelLongitudeAscendingNodeData;
    private System.Windows.Forms.Label labelInclinationData;
    private System.Windows.Forms.Label labelOrbitalEccentricityData;
    private System.Windows.Forms.Label labelMeanDailyMotionData;
    private System.Windows.Forms.Label labelSemiMajorAxisData;
    private System.Windows.Forms.Label labelSlopeParameterData;
    private System.Windows.Forms.Label labelNumberOppositionsData;
    private System.Windows.Forms.Label labelNumberObservationsData;
    private System.Windows.Forms.Label labelObservationSpanData;
    private System.Windows.Forms.Label labelRmsResidualData;
    private System.Windows.Forms.Label labelComputerNameData;
    private System.Windows.Forms.Label labelDateLastObservationData;
    private System.Windows.Forms.Label labelIndexData;
    private System.Windows.Forms.Label labelAbsoluteMagnitudeData;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.StatusStrip statusBar;
    private System.Windows.Forms.ContextMenuStrip contextMenuNavigationStep;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1000;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10000;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100000;
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
    private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
    private System.Windows.Forms.ToolStripButton toolStripButtonTableMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton toolStripButtonDatabaseInformation;
    private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
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
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopytoClipboard;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrint;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTableMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions1;
    private System.Windows.Forms.ToolStripMenuItem chartBarToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions2;
    private System.Windows.Forms.ToolStripContainer toolStripContainer;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyle;
    private System.Windows.Forms.Timer timerCheckForNewMpcorbDatFile;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCancelBackgroundDownload;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTerminology;
		private System.Windows.Forms.ToolStripButton toolStripButtonTerminology;
		private System.Windows.Forms.LinkLabel linkLabelIndexDesc;
		private System.Windows.Forms.LinkLabel linkLabelDesignationNameDesc;
		private System.Windows.Forms.LinkLabel linkLabelEpochDesc;
		private System.Windows.Forms.LinkLabel linkLabelMeanAnomalyDesc;
		private System.Windows.Forms.LinkLabel linkLabelArgumentPerihelionDesc;
		private System.Windows.Forms.LinkLabel linkLabelLongitudeAscendingNodeDesc;
		private System.Windows.Forms.LinkLabel linkLabelInclinationDesc;
		private System.Windows.Forms.LinkLabel linkLabelOrbitalEccentricityDesc;
		private System.Windows.Forms.LinkLabel linkLabelMeanDailyMotionDesc;
		private System.Windows.Forms.LinkLabel linkLabelSemiMajorAxisDesc;
		private System.Windows.Forms.LinkLabel linkLabelAbsoluteMagnitudeDesc;
		private System.Windows.Forms.LinkLabel linkLabelSlopeParameterDesc;
		private System.Windows.Forms.LinkLabel linkLabelReferenceDesc;
		private System.Windows.Forms.LinkLabel linkLabelNumberOppositionsDesc;
		private System.Windows.Forms.LinkLabel linkLabelNumberObservationsDesc;
		private System.Windows.Forms.LinkLabel linkLabelObservationSpanDesc;
		private System.Windows.Forms.LinkLabel linkLabelRmsResidualDesc;
		private System.Windows.Forms.LinkLabel linkLabelComputerNameDesc;
		private System.Windows.Forms.LinkLabel linkLabelFlagsDesc;
		private System.Windows.Forms.LinkLabel linkLabelDateLastObservationDesc;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStepBackward;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStepForward;
		private System.Windows.Forms.ContextMenuStrip contextMenuCopyToClipboard;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButtonLoadRandomMinorPlanet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRandomMinorPlanet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorNavigation1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavigateToTheBeginning;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavigateSomeDataBackward;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavigateToThePreviousData;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavigateToTheNextData;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavigateSomeDataForward;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavigateToTheEnd;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDatabaseInformation;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOptions;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRestart;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDerivatedOrbitElements;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton toolStripButtonDerivatedOrbitElements;
        private System.Windows.Forms.ToolStripMenuItem exportDataEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportDataEntryAsTxt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportDataEntryAsHtml;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportDataEntryAsXml;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportDataEntryAsJson;
        private System.Windows.Forms.ToolStripMenuItem meanAnomalyAtTheEpochToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem argumentOfPerihelionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longitudeOfTheAscendingNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inclinationToTheEclipticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orbitalEccentricityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanDailyMotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semimajorAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absoluteMagnitudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slopeParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfOppositionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfObservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observationSpanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rmsResiduaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateOfTheLastObservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem meanAnomalyAtTheEpochToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem argumentOfThePerihelionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longitudeTheTheAscendingNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inclinationToTheEclipticToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orbitalEccentricityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem meanDailyMotionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem semimajorAxisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem absoluteMagnitudeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem slopeParameterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem numberOfOppositionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem numberOfObservationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem observationSpanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rmsResidualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateOfTheLastObservationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortDirectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIconsetSilk;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIconsetFatcow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIconsetFugue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenALocalMpcorbdatFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardIndexNumber;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardReadableDesignation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardEpoch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardMeanAnomaly;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardArgumentOfPerihelion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardInclination;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardEccentricity;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardMeanDailyMotion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardSemimajorAxis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardAbsoluteMagnitude;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardSlopeParameter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardReference;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardNumberOfOppositions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardNumberOfObservations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardObservationSpan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardRmsResidual;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardComputername;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardFlags;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyToClipboardDateOfLastObservation;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStayOnTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnabledCopyingByDoubleClicking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnableLinkingToTerminology;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem41;
        private System.Windows.Forms.ToolStripMenuItem menuitemCheckMpcorbDat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFilter;
        private KryptonTableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportAsTxt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportAsHtml;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportAsXml;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportAsJson;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyIndexNumber;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyReadableDesignation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyEpoch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyMeanAnomalyAtTheEpoch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyArgumentOfPerihelion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyLongitudeOfTheAscendingNode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyInclination;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyEccentricity;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyMeanDailyMotion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopySemimajorAxis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyAbsoluteMagnitude;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopySlopeParameter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyReference;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyNumberOfOppositions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyNumberOfObservations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyObservationSpan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyRmsResidual;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyComputername;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyDateOfLastObservation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyFlags;
    }
}

