using System.ComponentModel;
using Krypton.Toolkit;
using Planetoid_DB.Properties;
using Planetoid_DB.Resources;

using Timer = System.Windows.Forms.Timer;

namespace Planetoid_DB
{
  /// <summary>
	/// 
	/// </summary>
	partial class PlanetoidDbForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private IContainer components = null;

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
			this.components = new Container();
			var resources = new ComponentResourceManager(typeof(PlanetoidDbForm));
			this.contextMenuNavigationStep = new ContextMenuStrip(this.components);
			this.menuitemNavigateStep10 = new ToolStripMenuItem();
			this.menuitemNavigateStep100 = new ToolStripMenuItem();
			this.menuitemNavigateStep1000 = new ToolStripMenuItem();
			this.menuitemNavigateStep10000 = new ToolStripMenuItem();
			this.menuitemNavigateStep100000 = new ToolStripMenuItem();
			this.menuitemNavigateSomeDataForward = new ToolStripMenuItem();
			this.toolStripSplitButtonStepForward = new ToolStripSplitButton();
			this.toolStripSplitButtonStepBackward = new ToolStripSplitButton();
			this.menuitemNavigateSomeDataBackward = new ToolStripMenuItem();
			this.tableLayoutPanelData = new KryptonTableLayoutPanel();
			this.labelIndexData = new KryptonLabel();
			this.labelReadableDesignationData = new KryptonLabel();
			this.labelEpochData = new KryptonLabel();
			this.labelMeanAnomalyAtTheEpochData = new KryptonLabel();
			this.labelArgumentOfPerihelionData = new KryptonLabel();
			this.labelLongitudeOfTheAscendingNodeData = new KryptonLabel();
			this.labelInclinationToTheEclipticData = new KryptonLabel();
			this.labelOrbitalEccentricityData = new KryptonLabel();
			this.labelMeanDailyMotionData = new KryptonLabel();
			this.labelSemiMajorAxisData = new KryptonLabel();
			this.labelAbsoluteMagnitudeData = new KryptonLabel();
			this.labelSlopeParameterData = new KryptonLabel();
			this.labelReferenceData = new KryptonLabel();
			this.labelNumberOfOppositionsData = new KryptonLabel();
			this.labelNumberOfObservationsData = new KryptonLabel();
			this.labelObservationSpanData = new KryptonLabel();
			this.labelRmsResidualData = new KryptonLabel();
			this.labelComputerNameData = new KryptonLabel();
			this.labelFlagsData = new KryptonLabel();
			this.labelDateLastObservationData = new KryptonLabel();
			this.labelIndexDesc = new KryptonLabel();
			this.labelReadableDesignationDesc = new KryptonLabel();
			this.labelEpochDesc = new KryptonLabel();
			this.labelMeanAnomalyAtTheEpochDesc = new KryptonLabel();
			this.labelArgumentOfPerihelionDesc = new KryptonLabel();
			this.labelLongitudeOfTheAscendingNodeDesc = new KryptonLabel();
			this.labelInclinationToTheEclipticDesc = new KryptonLabel();
			this.labelOrbitalEccentricityDesc = new KryptonLabel();
			this.labelMeanDailyMotionDesc = new KryptonLabel();
			this.labelSemiMajorAxisDesc = new KryptonLabel();
			this.labelAbsoluteMagnitudeDesc = new KryptonLabel();
			this.labelSlopeParameterDesc = new KryptonLabel();
			this.labelReferenceDesc = new KryptonLabel();
			this.labelNumberOfOppositionsDesc = new KryptonLabel();
			this.labelNumberOfObservationsDesc = new KryptonLabel();
			this.labelObservationSpanDesc = new KryptonLabel();
			this.labelRmsResidualDesc = new KryptonLabel();
			this.labelComputerNameDesc = new KryptonLabel();
			this.labelFlagsDesc = new KryptonLabel();
			this.labelDateLastObservationDesc = new KryptonLabel();
			this.toolTip = new ToolTip(this.components);
			this.contextMenuTopTenRecords = new ContextMenuStrip(this.components);
			this.menuitemRecordsSortDirection = new ToolStripMenuItem();
			this.menuitemRecordsSortDirectionAscending = new ToolStripMenuItem();
			this.menuitemRecordsSortDirectionDescending = new ToolStripMenuItem();
			this.toolStripSeparator12 = new ToolStripSeparator();
			this.menuitemRecordsMeanAnomalyAtTheEpoch = new ToolStripMenuItem();
			this.menuitemRecordsArgumentOfPerihelion = new ToolStripMenuItem();
			this.menuitemRecordsLongitudeOfTheAscendingNode = new ToolStripMenuItem();
			this.menuitemRecordsInclination = new ToolStripMenuItem();
			this.menuitemRecordsOrbitalEccentricity = new ToolStripMenuItem();
			this.menuitemRecordsMeanDailyMotion = new ToolStripMenuItem();
			this.menuitemRecordsSemiMajorAxis = new ToolStripMenuItem();
			this.menuitemRecordsAbsoluteMagnitude = new ToolStripMenuItem();
			this.menuitemRecordsSlopeParameter = new ToolStripMenuItem();
			this.menuitemRecordsNumberOfOppositions = new ToolStripMenuItem();
			this.menuitemRecordsNumberOfObservations = new ToolStripMenuItem();
			this.menuitemRecordsObservationSpan = new ToolStripMenuItem();
			this.menuitemRecordsRmsResidual = new ToolStripMenuItem();
			this.menuitemRecordsComputername = new ToolStripMenuItem();
			this.menuitemRecordsDateOfTheLastObservation = new ToolStripMenuItem();
			this.splitbuttonTopTenRecords = new ToolStripSplitButton();
			this.contextMenuDistributions = new ContextMenuStrip(this.components);
			this.menuitemDistributionMeanAnomalyAtTheEpoch = new ToolStripMenuItem();
			this.menuitemDistributionArgumentOfPerihelion = new ToolStripMenuItem();
			this.menuitemDistributionLongitudeOfTheAscendingNode = new ToolStripMenuItem();
			this.menuitemDistributionInclination = new ToolStripMenuItem();
			this.menuitemDistributionOrbitalEccentricity = new ToolStripMenuItem();
			this.menuitemDistributionMeanDailyMotion = new ToolStripMenuItem();
			this.menuitemDistributionSemiMajorAxis = new ToolStripMenuItem();
			this.menuitemDistributionAbsoluteMagnitude = new ToolStripMenuItem();
			this.menuitemDistributionSlopeParameter = new ToolStripMenuItem();
			this.menuitemDistributionNumberOfOppositions = new ToolStripMenuItem();
			this.menuitemDistributionNumberOfObservations = new ToolStripMenuItem();
			this.menuitemDistributionObservationSpan = new ToolStripMenuItem();
			this.menuitemDistributionRmsResidual = new ToolStripMenuItem();
			this.menuitemDistributionComputerName = new ToolStripMenuItem();
			this.menuitemDistribution = new ToolStripMenuItem();
			this.contextMenuCopyToClipboardOrbitalElements = new ContextMenuStrip(this.components);
			this.menuitemCopyToClipboardIndexNumber = new ToolStripMenuItem();
			this.menuitemCopyToClipboardReadableDesignation = new ToolStripMenuItem();
			this.menuitemCopyToClipboardEpoch = new ToolStripMenuItem();
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch = new ToolStripMenuItem();
			this.menuitemCopyToClipboardArgumentOfPerihelion = new ToolStripMenuItem();
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode = new ToolStripMenuItem();
			this.menuitemCopyToClipboardInclinationToTheEcliptic = new ToolStripMenuItem();
			this.menuitemCopyToClipboardOrbitalEccentricity = new ToolStripMenuItem();
			this.menuitemCopyToClipboardMeanDailyMotion = new ToolStripMenuItem();
			this.menuitemCopyToClipboardSemiMajorAxis = new ToolStripMenuItem();
			this.menuitemCopyToClipboardAbsoluteMagnitude = new ToolStripMenuItem();
			this.menuitemCopyToClipboardSlopeParameter = new ToolStripMenuItem();
			this.menuitemCopyToClipboardReference = new ToolStripMenuItem();
			this.menuitemCopyToClipboardNumberOfOppositions = new ToolStripMenuItem();
			this.menuitemCopyToClipboardNumberOfObservations = new ToolStripMenuItem();
			this.menuitemCopyToClipboardObservationSpan = new ToolStripMenuItem();
			this.menuitemCopyToClipboardRmsResidual = new ToolStripMenuItem();
			this.menuitemCopyToClipboardComputerName = new ToolStripMenuItem();
			this.menuitemCopyToClipboardDateOfTheLastObservation = new ToolStripMenuItem();
			this.menuitemCopyToClipboardFlags = new ToolStripMenuItem();
			this.splitbuttonCopyToClipboard = new ToolStripSplitButton();
			this.menu = new MenuStrip();
			this.menuitemFile = new ToolStripMenuItem();
			this.menuitemExportDataEntry = new ToolStripMenuItem();
			this.menuitemPrint = new ToolStripMenuItem();
			this.toolStripSeparatorFile1 = new ToolStripSeparator();
			this.menuitemRestart = new ToolStripMenuItem();
			this.menuitemExit = new ToolStripMenuItem();
			this.menuitemEdit = new ToolStripMenuItem();
			this.menuitemCopytoClipboard = new ToolStripMenuItem();
			this.menuitemSearch = new ToolStripMenuItem();
			this.menuitemNavigation = new ToolStripMenuItem();
			this.menuitemRandomMinorPlanet = new ToolStripMenuItem();
			this.toolStripSeparatorNavigation1 = new ToolStripSeparator();
			this.menuitemNavigateToTheBeginning = new ToolStripMenuItem();
			this.menuitemNavigateToThePreviousData = new ToolStripMenuItem();
			this.menuitemNavigateToTheNextData = new ToolStripMenuItem();
			this.menuitemNavigateToTheEnd = new ToolStripMenuItem();
			this.toolStripSeparator11 = new ToolStripSeparator();
			this.menuitemListReadableDesignations = new ToolStripMenuItem();
			this.menuitemTools = new ToolStripMenuItem();
			this.menuitemDerivatedOrbitElements = new ToolStripMenuItem();
			this.menuitemFilter = new ToolStripMenuItem();
			this.toolStripSeparatorTools1 = new ToolStripSeparator();
			this.menuitemRecords = new ToolStripMenuItem();
			this.toolStripSeparator10 = new ToolStripSeparator();
			this.toolStripSeparatorTools2 = new ToolStripSeparator();
			this.menuitemDatabaseInformation = new ToolStripMenuItem();
			this.menuitemTableMode = new ToolStripMenuItem();
			this.menuitemTerminology = new ToolStripMenuItem();
			this.menuitemUpdate = new ToolStripMenuItem();
			this.menuitemCheckMpcorbDat = new ToolStripMenuItem();
			this.menuitemDownloadMpcorbDat = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.menuitemCheckAstorbDat = new ToolStripMenuItem();
			this.menuitemDownloadAstorbDat = new ToolStripMenuItem();
			this.menuitemOptions = new ToolStripMenuItem();
			this.menuitemSettings = new ToolStripMenuItem();
			this.menuitemStyle = new ToolStripMenuItem();
			this.menuitemIconsetFatcow = new ToolStripMenuItem();
			this.menuitemIconsetSilk = new ToolStripMenuItem();
			this.menuitemIconsetFugue = new ToolStripMenuItem();
			this.toolStripSeparatorOptions = new ToolStripSeparator();
			this.menuitemOptionStayOnTop = new ToolStripMenuItem();
			this.menuitemOptionEnabledCopyingByDoubleClicking = new ToolStripMenuItem();
			this.menuitemOptionEnableLinkingToTerminology = new ToolStripMenuItem();
			this.menuitemHelp = new ToolStripMenuItem();
			this.menuitemAbout = new ToolStripMenuItem();
			this.menuitemLicense = new ToolStripMenuItem();
			this.toolStripSeparatorMisc1 = new ToolStripSeparator();
			this.menuitemOpenWebsitePDB = new ToolStripMenuItem();
			this.menuitemOpenWebsiteMPC = new ToolStripMenuItem();
			this.menuitemOpenMPCORBWebsite = new ToolStripMenuItem();
			this.toolStripContainer = new ToolStripContainer();
			this.statusBar = new KryptonStatusStrip();
			this.toolStripStatusLabelUpdate = new ToolStripStatusLabel();
			this.toolStripStatusLabelBackgroundDownload = new ToolStripStatusLabel();
			this.toolStripProgressBarBackgroundDownload = new ToolStripProgressBar();
			this.toolStripStatusLabelCancelBackgroundDownload = new ToolStripStatusLabel();
			this.labelInformation = new ToolStripStatusLabel();
			this.toolStripIcons = new ToolStrip();
			this.toolStripButtonExport = new ToolStripButton();
			this.toolStripButtonPrint = new ToolStripButton();
			this.toolStripButtonSearch = new ToolStripButton();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.toolStripButtonDatabaseInformation = new ToolStripButton();
			this.toolStripButtonTableMode = new ToolStripButton();
			this.toolStripButtonTerminology = new ToolStripButton();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.splitbuttonDistribution = new ToolStripSplitButton();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.toolStripButtonCheckMpcorbDat = new ToolStripButton();
			this.toolStripButtonDownloadMpcorbDat = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.toolStripButtonAbout = new ToolStripButton();
			this.toolStripButtonLicense = new ToolStripButton();
			this.toolStripButtonOpenWebsitePDB = new ToolStripButton();
			this.toolStripNavigation = new ToolStrip();
			this.toolStripButtonLoadRandomMinorPlanet = new ToolStripButton();
			this.toolStripSeparator8 = new ToolStripSeparator();
			this.toolStripButtonStepToBegin = new ToolStripButton();
			this.toolStripButtonStepBackwardOne = new ToolStripButton();
			this.toolStripButtonStepForwardOne = new ToolStripButton();
			this.toolStripButtonStepToEnd = new ToolStripButton();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.toolStripLabelIndexPosition = new ToolStripLabel();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.toolStripLabelGoToIndex = new ToolStripLabel();
			this.toolStripTextBoxGotoIndex = new ToolStripTextBox();
			this.toolStripButtonGoToIndex = new ToolStripButton();
			this.toolStripButtonListReadableDesignations = new ToolStripButton();
			this.toolStripSeparator9 = new ToolStripSeparator();
			this.toolStripButtonDerivatedOrbitElements = new ToolStripButton();
			this.toolStripButtonFilter = new ToolStripButton();
			this.toolStripSeparatorOptions2 = new ToolStripSeparator();
			this.toolStripSeparatorOptions1 = new ToolStripSeparator();
			this.backgroundWorkerLoadingDatabase = new BackgroundWorker();
			this.timerBlinkForUpdateAvailable = new Timer(this.components);
			this.timerCheckForNewMpcorbDatFile = new Timer(this.components);
			this.openFileDialog = new OpenFileDialog();
			this.kryptonManager = new KryptonManager(this.components);
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
			this.contextMenuNavigationStep.AccessibleRole = AccessibleRole.MenuPopup;
			this.contextMenuNavigationStep.Font = new Font("Segoe UI", 9F);
			this.contextMenuNavigationStep.Items.AddRange(new ToolStripItem[] { this.menuitemNavigateStep10, this.menuitemNavigateStep100, this.menuitemNavigateStep1000, this.menuitemNavigateStep10000, this.menuitemNavigateStep100000 });
			this.contextMenuNavigationStep.Name = "contextMenu";
			this.contextMenuNavigationStep.ShowCheckMargin = true;
			this.contextMenuNavigationStep.ShowImageMargin = false;
			this.contextMenuNavigationStep.Size = new Size(111, 114);
			this.contextMenuNavigationStep.TabStop = true;
			this.contextMenuNavigationStep.Text = "Navigation step";
			this.toolTip.SetToolTip(this.contextMenuNavigationStep, "Show the context name of data items");
			this.contextMenuNavigationStep.MouseEnter += this.SetStatusBar_Enter;
			this.contextMenuNavigationStep.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateStep10
			// 
			this.menuitemNavigateStep10.AccessibleDescription = "Jumps 10 items backward/forward";
			this.menuitemNavigateStep10.AccessibleName = "Jumps 10 items backward/forward";
			this.menuitemNavigateStep10.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateStep10.CheckOnClick = true;
			this.menuitemNavigateStep10.Name = "menuitemNavigateStep10";
			this.menuitemNavigateStep10.Size = new Size(110, 22);
			this.menuitemNavigateStep10.Text = "10";
			this.menuitemNavigateStep10.ToolTipText = "Jump 10 items backward/forward";
			this.menuitemNavigateStep10.Click += ToolStripMenuItem10_Click;
			this.menuitemNavigateStep10.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateStep10.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateStep100
			// 
			this.menuitemNavigateStep100.AccessibleDescription = "Jumps 100 items backward/forward";
			this.menuitemNavigateStep100.AccessibleName = "Jumps 100 items backward/forward";
			this.menuitemNavigateStep100.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateStep100.Checked = true;
			this.menuitemNavigateStep100.CheckOnClick = true;
			this.menuitemNavigateStep100.CheckState = CheckState.Checked;
			this.menuitemNavigateStep100.Name = "menuitemNavigateStep100";
			this.menuitemNavigateStep100.Size = new Size(110, 22);
			this.menuitemNavigateStep100.Text = "100";
			this.menuitemNavigateStep100.ToolTipText = "Jump 100 items backward/forward";
			this.menuitemNavigateStep100.Click += ToolStripMenuItem100_Click;
			this.menuitemNavigateStep100.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateStep100.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateStep1000
			// 
			this.menuitemNavigateStep1000.AccessibleDescription = "Jumps 1000 items backward/forward";
			this.menuitemNavigateStep1000.AccessibleName = "Jumps 1000 items backward/forward";
			this.menuitemNavigateStep1000.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateStep1000.CheckOnClick = true;
			this.menuitemNavigateStep1000.Name = "menuitemNavigateStep1000";
			this.menuitemNavigateStep1000.Size = new Size(110, 22);
			this.menuitemNavigateStep1000.Text = "1000";
			this.menuitemNavigateStep1000.ToolTipText = "Jump 1000 items backward/forward";
			this.menuitemNavigateStep1000.Click += ToolStripMenuItem1000_Click;
			this.menuitemNavigateStep1000.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateStep1000.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateStep10000
			// 
			this.menuitemNavigateStep10000.AccessibleDescription = "Jumps 10000 items backward/forward";
			this.menuitemNavigateStep10000.AccessibleName = "Jumps 10000 items backward/forward";
			this.menuitemNavigateStep10000.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateStep10000.CheckOnClick = true;
			this.menuitemNavigateStep10000.Name = "menuitemNavigateStep10000";
			this.menuitemNavigateStep10000.Size = new Size(110, 22);
			this.menuitemNavigateStep10000.Text = "10000";
			this.menuitemNavigateStep10000.ToolTipText = "Jump 10000 items backward/forward";
			this.menuitemNavigateStep10000.Click += ToolStripMenuItem10000_Click;
			this.menuitemNavigateStep10000.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateStep10000.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateStep100000
			// 
			this.menuitemNavigateStep100000.AccessibleDescription = "Jumps 100000 items backward/forward";
			this.menuitemNavigateStep100000.AccessibleName = "Jumps 100000 items backward/forward";
			this.menuitemNavigateStep100000.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateStep100000.CheckOnClick = true;
			this.menuitemNavigateStep100000.Name = "menuitemNavigateStep100000";
			this.menuitemNavigateStep100000.Size = new Size(110, 22);
			this.menuitemNavigateStep100000.Text = "100000";
			this.menuitemNavigateStep100000.ToolTipText = "Jump 100000 items backward/forward";
			this.menuitemNavigateStep100000.Click += ToolStripMenuItem100000_Click;
			this.menuitemNavigateStep100000.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateStep100000.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateSomeDataForward
			// 
			this.menuitemNavigateSomeDataForward.AccessibleDescription = "Navigates some data forward";
			this.menuitemNavigateSomeDataForward.AccessibleName = "Navigates some data forward";
			this.menuitemNavigateSomeDataForward.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateSomeDataForward.AutoToolTip = true;
			this.menuitemNavigateSomeDataForward.DoubleClickEnabled = true;
			this.menuitemNavigateSomeDataForward.DropDown = this.contextMenuNavigationStep;
			this.menuitemNavigateSomeDataForward.Image = FatcowIcons16px.fatcow_control_fastforward_blue_16px;
			this.menuitemNavigateSomeDataForward.Name = "menuitemNavigateSomeDataForward";
			this.menuitemNavigateSomeDataForward.ShortcutKeys = Keys.Control | Keys.D5;
			this.menuitemNavigateSomeDataForward.Size = new Size(275, 22);
			this.menuitemNavigateSomeDataForward.Text = "Navigate some data &forward";
			this.menuitemNavigateSomeDataForward.Click += ToolStripMenuItemNavigateSomeDataForward_Click;
			this.menuitemNavigateSomeDataForward.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateSomeDataForward.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSplitButtonStepForward
			// 
			this.toolStripSplitButtonStepForward.AccessibleDescription = "Navigates some data forward";
			this.toolStripSplitButtonStepForward.AccessibleName = "Navigate some data forward";
			this.toolStripSplitButtonStepForward.AccessibleRole = AccessibleRole.SplitButton;
			this.toolStripSplitButtonStepForward.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonStepForward.DropDown = this.contextMenuNavigationStep;
			this.toolStripSplitButtonStepForward.Image = FatcowIcons16px.fatcow_control_fastforward_blue_16px;
			this.toolStripSplitButtonStepForward.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButtonStepForward.Name = "toolStripSplitButtonStepForward";
			this.toolStripSplitButtonStepForward.Size = new Size(32, 22);
			this.toolStripSplitButtonStepForward.Text = "Navigate some data forward";
			this.toolStripSplitButtonStepForward.ButtonClick += this.ToolStripButtonStepForward_Click;
			this.toolStripSplitButtonStepForward.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSplitButtonStepForward.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSplitButtonStepBackward
			// 
			this.toolStripSplitButtonStepBackward.AccessibleDescription = "Navigates some data backward";
			this.toolStripSplitButtonStepBackward.AccessibleName = "Navigate some data backward";
			this.toolStripSplitButtonStepBackward.AccessibleRole = AccessibleRole.SplitButton;
			this.toolStripSplitButtonStepBackward.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonStepBackward.DropDown = this.contextMenuNavigationStep;
			this.toolStripSplitButtonStepBackward.Image = FatcowIcons16px.fatcow_control_rewind_blue_16px;
			this.toolStripSplitButtonStepBackward.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButtonStepBackward.Name = "toolStripSplitButtonStepBackward";
			this.toolStripSplitButtonStepBackward.Size = new Size(32, 22);
			this.toolStripSplitButtonStepBackward.Text = "Navigate some data backward";
			this.toolStripSplitButtonStepBackward.ButtonClick += this.ToolStripButtonStepBackward_Click;
			this.toolStripSplitButtonStepBackward.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSplitButtonStepBackward.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateSomeDataBackward
			// 
			this.menuitemNavigateSomeDataBackward.AccessibleDescription = "Navigates some data backward";
			this.menuitemNavigateSomeDataBackward.AccessibleName = "Navigates some data backward";
			this.menuitemNavigateSomeDataBackward.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateSomeDataBackward.AutoToolTip = true;
			this.menuitemNavigateSomeDataBackward.DoubleClickEnabled = true;
			this.menuitemNavigateSomeDataBackward.DropDown = this.contextMenuNavigationStep;
			this.menuitemNavigateSomeDataBackward.Image = FatcowIcons16px.fatcow_control_rewind_blue_16px;
			this.menuitemNavigateSomeDataBackward.Name = "menuitemNavigateSomeDataBackward";
			this.menuitemNavigateSomeDataBackward.ShortcutKeys = Keys.Control | Keys.D2;
			this.menuitemNavigateSomeDataBackward.Size = new Size(275, 22);
			this.menuitemNavigateSomeDataBackward.Text = "Navigate some data back&ward";
			this.menuitemNavigateSomeDataBackward.Click += ToolStripMenuItemNavigateSomeDataBackward_Click;
			this.menuitemNavigateSomeDataBackward.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateSomeDataBackward.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// tableLayoutPanelData
			// 
			this.tableLayoutPanelData.AccessibleDescription = "Groups the data";
			this.tableLayoutPanelData.AccessibleName = "Table panel";
			this.tableLayoutPanelData.AccessibleRole = AccessibleRole.Pane;
			this.tableLayoutPanelData.ColumnCount = 4;
			this.tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
			this.tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle());
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
			this.tableLayoutPanelData.Dock = DockStyle.Fill;
			this.tableLayoutPanelData.Location = new Point(0, 0);
			this.tableLayoutPanelData.Name = "tableLayoutPanelData";
			this.tableLayoutPanelData.RowCount = 11;
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle());
			this.tableLayoutPanelData.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
			this.tableLayoutPanelData.Size = new Size(852, 285);
			this.tableLayoutPanelData.TabIndex = 0;
			this.tableLayoutPanelData.TabStop = true;
			this.toolTip.SetToolTip(this.tableLayoutPanelData, "table panel");
			this.tableLayoutPanelData.Enter += this.SetStatusBar_Enter;
			this.tableLayoutPanelData.Leave += this.ClearStatusBar_Leave;
			this.tableLayoutPanelData.MouseEnter += this.SetStatusBar_Enter;
			this.tableLayoutPanelData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelIndexData
			// 
			this.labelIndexData.AccessibleDescription = "Shows the information of \"Index No.\"";
			this.labelIndexData.AccessibleName = "Shows the information of \"Index No.\"";
			this.labelIndexData.AccessibleRole = AccessibleRole.StatusBar;
			this.labelIndexData.Dock = DockStyle.Fill;
			this.labelIndexData.Location = new Point(273, 3);
			this.labelIndexData.Name = "labelIndexData";
			this.labelIndexData.Size = new Size(143, 20);
			this.labelIndexData.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelIndexData, "Shows the information of \"Index No.\"");
			this.labelIndexData.Values.Text = "..................";
			this.labelIndexData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelIndexData.Enter += this.SetStatusBar_Enter;
			this.labelIndexData.Leave += this.ClearStatusBar_Leave;
			this.labelIndexData.MouseEnter += this.SetStatusBar_Enter;
			this.labelIndexData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelReadableDesignationData
			// 
			this.labelReadableDesignationData.AccessibleDescription = "Shows the information of \"Readable designation\"";
			this.labelReadableDesignationData.AccessibleName = "Shows the information of \"Readable designation\"";
			this.labelReadableDesignationData.AccessibleRole = AccessibleRole.StaticText;
			this.labelReadableDesignationData.Dock = DockStyle.Fill;
			this.labelReadableDesignationData.Location = new Point(273, 29);
			this.labelReadableDesignationData.Name = "labelReadableDesignationData";
			this.labelReadableDesignationData.Size = new Size(143, 20);
			this.labelReadableDesignationData.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelReadableDesignationData, "Shows the information of \"Readable designation\"");
			this.labelReadableDesignationData.Values.Text = "..................";
			this.labelReadableDesignationData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelReadableDesignationData.Enter += this.SetStatusBar_Enter;
			this.labelReadableDesignationData.Leave += this.ClearStatusBar_Leave;
			this.labelReadableDesignationData.MouseEnter += this.SetStatusBar_Enter;
			this.labelReadableDesignationData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelEpochData
			// 
			this.labelEpochData.AccessibleDescription = "Shows the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochData.AccessibleName = "Shows the information of \"Epoch (in packed form, .0 TT)\"";
			this.labelEpochData.AccessibleRole = AccessibleRole.StatusBar;
			this.labelEpochData.Dock = DockStyle.Fill;
			this.labelEpochData.Location = new Point(273, 55);
			this.labelEpochData.Name = "labelEpochData";
			this.labelEpochData.Size = new Size(143, 20);
			this.labelEpochData.TabIndex = 5;
			this.toolTip.SetToolTip(this.labelEpochData, "Shows the information of \"Epoch (in packed form, .0 TT)\"");
			this.labelEpochData.Values.Text = "..................";
			this.labelEpochData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelEpochData.Enter += this.SetStatusBar_Enter;
			this.labelEpochData.Leave += this.ClearStatusBar_Leave;
			this.labelEpochData.MouseEnter += this.SetStatusBar_Enter;
			this.labelEpochData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelMeanAnomalyAtTheEpochData
			// 
			this.labelMeanAnomalyAtTheEpochData.AccessibleDescription = "Shows the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyAtTheEpochData.AccessibleName = "Shows the information of \"Mean anomaly at the epoch, in degrees\"";
			this.labelMeanAnomalyAtTheEpochData.AccessibleRole = AccessibleRole.StaticText;
			this.labelMeanAnomalyAtTheEpochData.Dock = DockStyle.Fill;
			this.labelMeanAnomalyAtTheEpochData.Location = new Point(273, 81);
			this.labelMeanAnomalyAtTheEpochData.Name = "labelMeanAnomalyAtTheEpochData";
			this.labelMeanAnomalyAtTheEpochData.Size = new Size(143, 20);
			this.labelMeanAnomalyAtTheEpochData.TabIndex = 7;
			this.toolTip.SetToolTip(this.labelMeanAnomalyAtTheEpochData, "Shows the information of \"Mean anomaly at the epoch, in degrees\"");
			this.labelMeanAnomalyAtTheEpochData.Values.Text = "..................";
			this.labelMeanAnomalyAtTheEpochData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelMeanAnomalyAtTheEpochData.Enter += this.SetStatusBar_Enter;
			this.labelMeanAnomalyAtTheEpochData.Leave += this.ClearStatusBar_Leave;
			this.labelMeanAnomalyAtTheEpochData.MouseEnter += this.SetStatusBar_Enter;
			this.labelMeanAnomalyAtTheEpochData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelArgumentOfPerihelionData
			// 
			this.labelArgumentOfPerihelionData.AccessibleDescription = "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgumentOfPerihelionData.AccessibleName = "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			this.labelArgumentOfPerihelionData.AccessibleRole = AccessibleRole.StaticText;
			this.labelArgumentOfPerihelionData.Dock = DockStyle.Fill;
			this.labelArgumentOfPerihelionData.Location = new Point(273, 107);
			this.labelArgumentOfPerihelionData.Name = "labelArgumentOfPerihelionData";
			this.labelArgumentOfPerihelionData.Size = new Size(143, 20);
			this.labelArgumentOfPerihelionData.TabIndex = 9;
			this.toolTip.SetToolTip(this.labelArgumentOfPerihelionData, "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"");
			this.labelArgumentOfPerihelionData.Values.Text = "..................";
			this.labelArgumentOfPerihelionData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelArgumentOfPerihelionData.Enter += this.SetStatusBar_Enter;
			this.labelArgumentOfPerihelionData.Leave += this.ClearStatusBar_Leave;
			this.labelArgumentOfPerihelionData.MouseEnter += this.SetStatusBar_Enter;
			this.labelArgumentOfPerihelionData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelLongitudeOfTheAscendingNodeData
			// 
			this.labelLongitudeOfTheAscendingNodeData.AccessibleDescription = "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			this.labelLongitudeOfTheAscendingNodeData.AccessibleName = "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			this.labelLongitudeOfTheAscendingNodeData.AccessibleRole = AccessibleRole.StaticText;
			this.labelLongitudeOfTheAscendingNodeData.Dock = DockStyle.Fill;
			this.labelLongitudeOfTheAscendingNodeData.Location = new Point(273, 133);
			this.labelLongitudeOfTheAscendingNodeData.Name = "labelLongitudeOfTheAscendingNodeData";
			this.labelLongitudeOfTheAscendingNodeData.Size = new Size(143, 20);
			this.labelLongitudeOfTheAscendingNodeData.TabIndex = 11;
			this.toolTip.SetToolTip(this.labelLongitudeOfTheAscendingNodeData, "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"");
			this.labelLongitudeOfTheAscendingNodeData.Values.Text = "..................";
			// 
			// labelInclinationToTheEclipticData
			// 
			this.labelInclinationToTheEclipticData.AccessibleDescription = "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclinationToTheEclipticData.AccessibleName = "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			this.labelInclinationToTheEclipticData.AccessibleRole = AccessibleRole.StaticText;
			this.labelInclinationToTheEclipticData.Dock = DockStyle.Fill;
			this.labelInclinationToTheEclipticData.Location = new Point(273, 159);
			this.labelInclinationToTheEclipticData.Name = "labelInclinationToTheEclipticData";
			this.labelInclinationToTheEclipticData.Size = new Size(143, 20);
			this.labelInclinationToTheEclipticData.TabIndex = 13;
			this.toolTip.SetToolTip(this.labelInclinationToTheEclipticData, "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"");
			this.labelInclinationToTheEclipticData.Values.Text = "..................";
			this.labelInclinationToTheEclipticData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelInclinationToTheEclipticData.Enter += this.SetStatusBar_Enter;
			this.labelInclinationToTheEclipticData.Leave += this.ClearStatusBar_Leave;
			this.labelInclinationToTheEclipticData.MouseEnter += this.SetStatusBar_Enter;
			this.labelInclinationToTheEclipticData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelOrbitalEccentricityData
			// 
			this.labelOrbitalEccentricityData.AccessibleDescription = "Shows the information of \"Orbital eccentricity\"";
			this.labelOrbitalEccentricityData.AccessibleName = "Shows the information of \"Orbital eccentricity\"";
			this.labelOrbitalEccentricityData.AccessibleRole = AccessibleRole.StaticText;
			this.labelOrbitalEccentricityData.Dock = DockStyle.Fill;
			this.labelOrbitalEccentricityData.Location = new Point(273, 185);
			this.labelOrbitalEccentricityData.Name = "labelOrbitalEccentricityData";
			this.labelOrbitalEccentricityData.Size = new Size(143, 20);
			this.labelOrbitalEccentricityData.TabIndex = 15;
			this.toolTip.SetToolTip(this.labelOrbitalEccentricityData, "Shows the information of \"Orbital eccentricity\"");
			this.labelOrbitalEccentricityData.Values.Text = "..................";
			this.labelOrbitalEccentricityData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelOrbitalEccentricityData.Enter += this.SetStatusBar_Enter;
			this.labelOrbitalEccentricityData.Leave += this.ClearStatusBar_Leave;
			this.labelOrbitalEccentricityData.MouseEnter += this.SetStatusBar_Enter;
			this.labelOrbitalEccentricityData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelMeanDailyMotionData
			// 
			this.labelMeanDailyMotionData.AccessibleDescription = "Shows the information of \"Mean daily motion (degrees per day)\"";
			this.labelMeanDailyMotionData.AccessibleName = "Shows the information of \"Mean daily motion (degrees per day)\"";
			this.labelMeanDailyMotionData.AccessibleRole = AccessibleRole.StaticText;
			this.labelMeanDailyMotionData.Dock = DockStyle.Fill;
			this.labelMeanDailyMotionData.Location = new Point(273, 211);
			this.labelMeanDailyMotionData.Name = "labelMeanDailyMotionData";
			this.labelMeanDailyMotionData.Size = new Size(143, 20);
			this.labelMeanDailyMotionData.TabIndex = 17;
			this.toolTip.SetToolTip(this.labelMeanDailyMotionData, "Shows the information of \"Mean daily motion (degrees per day)\"");
			this.labelMeanDailyMotionData.Values.Text = "..................";
			this.labelMeanDailyMotionData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelMeanDailyMotionData.Enter += this.SetStatusBar_Enter;
			this.labelMeanDailyMotionData.Leave += this.ClearStatusBar_Leave;
			this.labelMeanDailyMotionData.MouseEnter += this.SetStatusBar_Enter;
			this.labelMeanDailyMotionData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelSemiMajorAxisData
			// 
			this.labelSemiMajorAxisData.AccessibleDescription = "Shows the information of \"Semi-major axis (AU)\"";
			this.labelSemiMajorAxisData.AccessibleName = "Shows the information of \"Semi-major axis (AU)\"";
			this.labelSemiMajorAxisData.AccessibleRole = AccessibleRole.StaticText;
			this.labelSemiMajorAxisData.Dock = DockStyle.Fill;
			this.labelSemiMajorAxisData.Location = new Point(273, 237);
			this.labelSemiMajorAxisData.Name = "labelSemiMajorAxisData";
			this.labelSemiMajorAxisData.Size = new Size(143, 20);
			this.labelSemiMajorAxisData.TabIndex = 19;
			this.toolTip.SetToolTip(this.labelSemiMajorAxisData, "Shows the information of \"Semi-major axis (AU)\"");
			this.labelSemiMajorAxisData.Values.Text = "..................";
			this.labelSemiMajorAxisData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelSemiMajorAxisData.Enter += this.SetStatusBar_Enter;
			this.labelSemiMajorAxisData.Leave += this.ClearStatusBar_Leave;
			this.labelSemiMajorAxisData.MouseEnter += this.SetStatusBar_Enter;
			this.labelSemiMajorAxisData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelAbsoluteMagnitudeData
			// 
			this.labelAbsoluteMagnitudeData.AccessibleDescription = "Shows the information of \"Absolute magnitude, H\"";
			this.labelAbsoluteMagnitudeData.AccessibleName = "Shows the information of \"Absolute magnitude, H\"";
			this.labelAbsoluteMagnitudeData.AccessibleRole = AccessibleRole.StaticText;
			this.labelAbsoluteMagnitudeData.Dock = DockStyle.Fill;
			this.labelAbsoluteMagnitudeData.Location = new Point(273, 263);
			this.labelAbsoluteMagnitudeData.Name = "labelAbsoluteMagnitudeData";
			this.labelAbsoluteMagnitudeData.Size = new Size(143, 20);
			this.labelAbsoluteMagnitudeData.TabIndex = 21;
			this.toolTip.SetToolTip(this.labelAbsoluteMagnitudeData, "Shows the information of \"Absolute magnitude, H\"");
			this.labelAbsoluteMagnitudeData.Values.Text = "..................";
			this.labelAbsoluteMagnitudeData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelAbsoluteMagnitudeData.Enter += this.SetStatusBar_Enter;
			this.labelAbsoluteMagnitudeData.Leave += this.ClearStatusBar_Leave;
			this.labelAbsoluteMagnitudeData.MouseEnter += this.SetStatusBar_Enter;
			this.labelAbsoluteMagnitudeData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelSlopeParameterData
			// 
			this.labelSlopeParameterData.AccessibleDescription = "Shows the information of \"Slope parameter, G\"";
			this.labelSlopeParameterData.AccessibleName = "Shows the information of \"Slope parameter, G\"";
			this.labelSlopeParameterData.AccessibleRole = AccessibleRole.StaticText;
			this.labelSlopeParameterData.Dock = DockStyle.Fill;
			this.labelSlopeParameterData.Location = new Point(650, 29);
			this.labelSlopeParameterData.Name = "labelSlopeParameterData";
			this.labelSlopeParameterData.Size = new Size(199, 20);
			this.labelSlopeParameterData.TabIndex = 23;
			this.toolTip.SetToolTip(this.labelSlopeParameterData, "Shows the information of \"Slope parameter, G\"");
			this.labelSlopeParameterData.Values.Text = "..................";
			this.labelSlopeParameterData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelSlopeParameterData.Enter += this.SetStatusBar_Enter;
			this.labelSlopeParameterData.Leave += this.ClearStatusBar_Leave;
			this.labelSlopeParameterData.MouseEnter += this.SetStatusBar_Enter;
			this.labelSlopeParameterData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelReferenceData
			// 
			this.labelReferenceData.AccessibleDescription = "Shows the information of \"Reference\"";
			this.labelReferenceData.AccessibleName = "Shows the information of \"Reference\"";
			this.labelReferenceData.AccessibleRole = AccessibleRole.StaticText;
			this.labelReferenceData.Dock = DockStyle.Fill;
			this.labelReferenceData.Location = new Point(650, 55);
			this.labelReferenceData.Name = "labelReferenceData";
			this.labelReferenceData.Size = new Size(199, 20);
			this.labelReferenceData.TabIndex = 25;
			this.toolTip.SetToolTip(this.labelReferenceData, "Shows the information of \"Reference\"");
			this.labelReferenceData.Values.Text = "..................";
			this.labelReferenceData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelReferenceData.Enter += this.SetStatusBar_Enter;
			this.labelReferenceData.Leave += this.ClearStatusBar_Leave;
			this.labelReferenceData.MouseEnter += this.SetStatusBar_Enter;
			this.labelReferenceData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelNumberOfOppositionsData
			// 
			this.labelNumberOfOppositionsData.AccessibleDescription = "Shows the information of \"Number of oppositions\"";
			this.labelNumberOfOppositionsData.AccessibleName = "Shows the information of \"Number of oppositions\"";
			this.labelNumberOfOppositionsData.AccessibleRole = AccessibleRole.StaticText;
			this.labelNumberOfOppositionsData.Dock = DockStyle.Fill;
			this.labelNumberOfOppositionsData.Location = new Point(650, 81);
			this.labelNumberOfOppositionsData.Name = "labelNumberOfOppositionsData";
			this.labelNumberOfOppositionsData.Size = new Size(199, 20);
			this.labelNumberOfOppositionsData.TabIndex = 27;
			this.toolTip.SetToolTip(this.labelNumberOfOppositionsData, "Shows the information of \"Number of oppositions\"");
			this.labelNumberOfOppositionsData.Values.Text = "..................";
			this.labelNumberOfOppositionsData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelNumberOfOppositionsData.Enter += this.SetStatusBar_Enter;
			this.labelNumberOfOppositionsData.Leave += this.ClearStatusBar_Leave;
			this.labelNumberOfOppositionsData.MouseEnter += this.SetStatusBar_Enter;
			this.labelNumberOfOppositionsData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelNumberOfObservationsData
			// 
			this.labelNumberOfObservationsData.AccessibleDescription = "Shows the information of \"Number of observations\"";
			this.labelNumberOfObservationsData.AccessibleName = "Shows the information of \"Number of observations\"";
			this.labelNumberOfObservationsData.AccessibleRole = AccessibleRole.StaticText;
			this.labelNumberOfObservationsData.Dock = DockStyle.Fill;
			this.labelNumberOfObservationsData.Location = new Point(650, 107);
			this.labelNumberOfObservationsData.Name = "labelNumberOfObservationsData";
			this.labelNumberOfObservationsData.Size = new Size(199, 20);
			this.labelNumberOfObservationsData.TabIndex = 29;
			this.toolTip.SetToolTip(this.labelNumberOfObservationsData, "Shows the information of \"Number of observations\"");
			this.labelNumberOfObservationsData.Values.Text = "..................";
			this.labelNumberOfObservationsData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelNumberOfObservationsData.Enter += this.SetStatusBar_Enter;
			this.labelNumberOfObservationsData.Leave += this.ClearStatusBar_Leave;
			this.labelNumberOfObservationsData.MouseEnter += this.SetStatusBar_Enter;
			this.labelNumberOfObservationsData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelObservationSpanData
			// 
			this.labelObservationSpanData.AccessibleDescription = "Shows the information of \"Observation span\"";
			this.labelObservationSpanData.AccessibleName = "Shows the information of \"Observation span\"";
			this.labelObservationSpanData.AccessibleRole = AccessibleRole.StaticText;
			this.labelObservationSpanData.Dock = DockStyle.Fill;
			this.labelObservationSpanData.Location = new Point(650, 133);
			this.labelObservationSpanData.Name = "labelObservationSpanData";
			this.labelObservationSpanData.Size = new Size(199, 20);
			this.labelObservationSpanData.TabIndex = 31;
			this.toolTip.SetToolTip(this.labelObservationSpanData, "Shows the information of \"Observation span\"");
			this.labelObservationSpanData.Values.Text = "..................";
			this.labelObservationSpanData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelObservationSpanData.Enter += this.SetStatusBar_Enter;
			this.labelObservationSpanData.Leave += this.ClearStatusBar_Leave;
			this.labelObservationSpanData.MouseEnter += this.SetStatusBar_Enter;
			this.labelObservationSpanData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelRmsResidualData
			// 
			this.labelRmsResidualData.AccessibleDescription = "Shows the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualData.AccessibleName = "Shows the information of \"r.m.s residual (\")\"";
			this.labelRmsResidualData.AccessibleRole = AccessibleRole.StaticText;
			this.labelRmsResidualData.Dock = DockStyle.Fill;
			this.labelRmsResidualData.Location = new Point(650, 159);
			this.labelRmsResidualData.Name = "labelRmsResidualData";
			this.labelRmsResidualData.Size = new Size(199, 20);
			this.labelRmsResidualData.TabIndex = 33;
			this.toolTip.SetToolTip(this.labelRmsResidualData, "Shows the information of \"r.m.s residual (\")\"");
			this.labelRmsResidualData.Values.Text = "..................";
			this.labelRmsResidualData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelRmsResidualData.Enter += this.SetStatusBar_Enter;
			this.labelRmsResidualData.Leave += this.ClearStatusBar_Leave;
			this.labelRmsResidualData.MouseEnter += this.SetStatusBar_Enter;
			this.labelRmsResidualData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelComputerNameData
			// 
			this.labelComputerNameData.AccessibleDescription = "Shows the information of \"Computer name\"";
			this.labelComputerNameData.AccessibleName = "Shows the information of \"Computer name\"";
			this.labelComputerNameData.AccessibleRole = AccessibleRole.StaticText;
			this.labelComputerNameData.Dock = DockStyle.Fill;
			this.labelComputerNameData.Location = new Point(650, 185);
			this.labelComputerNameData.Name = "labelComputerNameData";
			this.labelComputerNameData.Size = new Size(199, 20);
			this.labelComputerNameData.TabIndex = 35;
			this.toolTip.SetToolTip(this.labelComputerNameData, "Shows the information of \"Computer name\"");
			this.labelComputerNameData.Values.Text = "..................";
			this.labelComputerNameData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelComputerNameData.Enter += this.SetStatusBar_Enter;
			this.labelComputerNameData.Leave += this.ClearStatusBar_Leave;
			this.labelComputerNameData.MouseEnter += this.SetStatusBar_Enter;
			this.labelComputerNameData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelFlagsData
			// 
			this.labelFlagsData.AccessibleDescription = "Shows the information of \"4-hexdigit flags\"";
			this.labelFlagsData.AccessibleName = "Shows the information of \"4-hexdigit flags\"";
			this.labelFlagsData.AccessibleRole = AccessibleRole.StaticText;
			this.labelFlagsData.Dock = DockStyle.Fill;
			this.labelFlagsData.Location = new Point(650, 211);
			this.labelFlagsData.Name = "labelFlagsData";
			this.labelFlagsData.Size = new Size(199, 20);
			this.labelFlagsData.TabIndex = 37;
			this.toolTip.SetToolTip(this.labelFlagsData, "Shows the information of \"4-hexdigit flags\"");
			this.labelFlagsData.Values.Text = "..................";
			this.labelFlagsData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelFlagsData.Enter += this.SetStatusBar_Enter;
			this.labelFlagsData.Leave += this.ClearStatusBar_Leave;
			this.labelFlagsData.MouseEnter += this.SetStatusBar_Enter;
			this.labelFlagsData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelDateLastObservationData
			// 
			this.labelDateLastObservationData.AccessibleDescription = "Shows the information of \"Date of last observation\"";
			this.labelDateLastObservationData.AccessibleName = "Shows the information of \"Date of last observation\"";
			this.labelDateLastObservationData.AccessibleRole = AccessibleRole.StaticText;
			this.labelDateLastObservationData.Dock = DockStyle.Fill;
			this.labelDateLastObservationData.Location = new Point(650, 237);
			this.labelDateLastObservationData.Name = "labelDateLastObservationData";
			this.labelDateLastObservationData.Size = new Size(199, 20);
			this.labelDateLastObservationData.TabIndex = 39;
			this.toolTip.SetToolTip(this.labelDateLastObservationData, "Shows the information of \"Date of last observation\"");
			this.labelDateLastObservationData.Values.Text = "..................";
			this.labelDateLastObservationData.DoubleClick += this.CopyToClipboard_DoubleClick;
			this.labelDateLastObservationData.Enter += this.SetStatusBar_Enter;
			this.labelDateLastObservationData.Leave += this.ClearStatusBar_Leave;
			this.labelDateLastObservationData.MouseEnter += this.SetStatusBar_Enter;
			this.labelDateLastObservationData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelIndexDesc
			// 
			this.labelIndexDesc.AccessibleDescription = "Index No.";
			this.labelIndexDesc.AccessibleName = "Index No.";
			this.labelIndexDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelIndexDesc.Dock = DockStyle.Fill;
			this.labelIndexDesc.LabelStyle = LabelStyle.BoldControl;
			this.labelIndexDesc.Location = new Point(3, 3);
			this.labelIndexDesc.Name = "labelIndexDesc";
			this.labelIndexDesc.Size = new Size(264, 20);
			this.labelIndexDesc.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelIndexDesc, "Index No.");
			this.labelIndexDesc.Values.Text = "Index No.";
			this.labelIndexDesc.DoubleClick += this.LabelIndexDesc_DoubleClick;
			this.labelIndexDesc.Enter += this.SetStatusBar_Enter;
			this.labelIndexDesc.Leave += this.ClearStatusBar_Leave;
			this.labelIndexDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelIndexDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelReadableDesignationDesc
			// 
			this.labelReadableDesignationDesc.AccessibleDescription = "Readable designation";
			this.labelReadableDesignationDesc.AccessibleName = "Readable designation";
			this.labelReadableDesignationDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelReadableDesignationDesc.Dock = DockStyle.Fill;
			this.labelReadableDesignationDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelReadableDesignationDesc.Location = new Point(3, 29);
			this.labelReadableDesignationDesc.Name = "labelReadableDesignationDesc";
			this.labelReadableDesignationDesc.Size = new Size(264, 20);
			this.labelReadableDesignationDesc.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelReadableDesignationDesc, "Readable designation");
			this.labelReadableDesignationDesc.Values.Text = "Readable designation";
			this.labelReadableDesignationDesc.DoubleClick += this.LabelReadableDesignationNameDesc_DoubleClick;
			this.labelReadableDesignationDesc.Enter += this.SetStatusBar_Enter;
			this.labelReadableDesignationDesc.Leave += this.ClearStatusBar_Leave;
			this.labelReadableDesignationDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelReadableDesignationDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelEpochDesc
			// 
			this.labelEpochDesc.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			this.labelEpochDesc.AccessibleName = "Epoch (in packed form, .0 TT)";
			this.labelEpochDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelEpochDesc.Dock = DockStyle.Fill;
			this.labelEpochDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelEpochDesc.Location = new Point(3, 55);
			this.labelEpochDesc.Name = "labelEpochDesc";
			this.labelEpochDesc.Size = new Size(264, 20);
			this.labelEpochDesc.TabIndex = 4;
			this.toolTip.SetToolTip(this.labelEpochDesc, "Epoch (in packed form, .0 TT)");
			this.labelEpochDesc.Values.Text = "Epoch (in packed form, .0 TT)";
			this.labelEpochDesc.DoubleClick += this.LabelEpochDesc_DoubleClick;
			this.labelEpochDesc.Enter += this.SetStatusBar_Enter;
			this.labelEpochDesc.Leave += this.ClearStatusBar_Leave;
			this.labelEpochDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelEpochDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelMeanAnomalyAtTheEpochDesc
			// 
			this.labelMeanAnomalyAtTheEpochDesc.AccessibleDescription = "Mean anomaly at the epoch (degrees)";
			this.labelMeanAnomalyAtTheEpochDesc.AccessibleName = "Mean anomaly at the epoch (degrees)";
			this.labelMeanAnomalyAtTheEpochDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelMeanAnomalyAtTheEpochDesc.Dock = DockStyle.Fill;
			this.labelMeanAnomalyAtTheEpochDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelMeanAnomalyAtTheEpochDesc.Location = new Point(3, 81);
			this.labelMeanAnomalyAtTheEpochDesc.Name = "labelMeanAnomalyAtTheEpochDesc";
			this.labelMeanAnomalyAtTheEpochDesc.Size = new Size(264, 20);
			this.labelMeanAnomalyAtTheEpochDesc.TabIndex = 6;
			this.toolTip.SetToolTip(this.labelMeanAnomalyAtTheEpochDesc, "Mean anomaly at the epoch (degrees)");
			this.labelMeanAnomalyAtTheEpochDesc.Values.ExtraText = "°";
			this.labelMeanAnomalyAtTheEpochDesc.Values.Text = "Mean anomaly at the epoch";
			this.labelMeanAnomalyAtTheEpochDesc.DoubleClick += this.KryptonLabelMeanAnomalyAtTheEpochDesc_DoubleClick;
			this.labelMeanAnomalyAtTheEpochDesc.Enter += this.SetStatusBar_Enter;
			this.labelMeanAnomalyAtTheEpochDesc.Leave += this.ClearStatusBar_Leave;
			this.labelMeanAnomalyAtTheEpochDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelMeanAnomalyAtTheEpochDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelArgumentOfPerihelionDesc
			// 
			this.labelArgumentOfPerihelionDesc.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgumentOfPerihelionDesc.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgumentOfPerihelionDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelArgumentOfPerihelionDesc.Dock = DockStyle.Fill;
			this.labelArgumentOfPerihelionDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelArgumentOfPerihelionDesc.Location = new Point(3, 107);
			this.labelArgumentOfPerihelionDesc.Name = "labelArgumentOfPerihelionDesc";
			this.labelArgumentOfPerihelionDesc.Size = new Size(264, 20);
			this.labelArgumentOfPerihelionDesc.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelArgumentOfPerihelionDesc, "Argument of perihelion, J2000.0 (degrees)");
			this.labelArgumentOfPerihelionDesc.Values.ExtraText = "°";
			this.labelArgumentOfPerihelionDesc.Values.Text = "Argument of perihelion, J2000.0";
			this.labelArgumentOfPerihelionDesc.DoubleClick += this.LabelArgumentOfPerihelionDesc_DoubleClick;
			this.labelArgumentOfPerihelionDesc.Enter += this.SetStatusBar_Enter;
			this.labelArgumentOfPerihelionDesc.Leave += this.ClearStatusBar_Leave;
			this.labelArgumentOfPerihelionDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelArgumentOfPerihelionDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelLongitudeOfTheAscendingNodeDesc
			// 
			this.labelLongitudeOfTheAscendingNodeDesc.AccessibleDescription = "Longitude of the ascending node, J2000.0 (degrees)";
			this.labelLongitudeOfTheAscendingNodeDesc.AccessibleName = "Longitude of the ascending node, J2000.0 (degrees)";
			this.labelLongitudeOfTheAscendingNodeDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelLongitudeOfTheAscendingNodeDesc.Dock = DockStyle.Fill;
			this.labelLongitudeOfTheAscendingNodeDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelLongitudeOfTheAscendingNodeDesc.Location = new Point(3, 133);
			this.labelLongitudeOfTheAscendingNodeDesc.Name = "labelLongitudeOfTheAscendingNodeDesc";
			this.labelLongitudeOfTheAscendingNodeDesc.Size = new Size(264, 20);
			this.labelLongitudeOfTheAscendingNodeDesc.TabIndex = 10;
			this.toolTip.SetToolTip(this.labelLongitudeOfTheAscendingNodeDesc, "Longitude of the ascending node, J2000.0 (degrees)");
			this.labelLongitudeOfTheAscendingNodeDesc.Values.ExtraText = "°";
			this.labelLongitudeOfTheAscendingNodeDesc.Values.Text = "Longitude of the ascending node, J2000.0";
			this.labelLongitudeOfTheAscendingNodeDesc.DoubleClick += this.LabelLongitudeOfTheAscendingNodeDesc_DoubleClick;
			this.labelLongitudeOfTheAscendingNodeDesc.Enter += this.SetStatusBar_Enter;
			this.labelLongitudeOfTheAscendingNodeDesc.Leave += this.ClearStatusBar_Leave;
			this.labelLongitudeOfTheAscendingNodeDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelLongitudeOfTheAscendingNodeDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelInclinationToTheEclipticDesc
			// 
			this.labelInclinationToTheEclipticDesc.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelInclinationToTheEclipticDesc.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelInclinationToTheEclipticDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelInclinationToTheEclipticDesc.Dock = DockStyle.Fill;
			this.labelInclinationToTheEclipticDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelInclinationToTheEclipticDesc.Location = new Point(3, 159);
			this.labelInclinationToTheEclipticDesc.Name = "labelInclinationToTheEclipticDesc";
			this.labelInclinationToTheEclipticDesc.Size = new Size(264, 20);
			this.labelInclinationToTheEclipticDesc.TabIndex = 12;
			this.toolTip.SetToolTip(this.labelInclinationToTheEclipticDesc, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.labelInclinationToTheEclipticDesc.Values.ExtraText = "°";
			this.labelInclinationToTheEclipticDesc.Values.Text = "Inclination to the ecliptic, J2000.0";
			this.labelInclinationToTheEclipticDesc.DoubleClick += this.LabelInclinationToTheEclipticDesc_DoubleClick;
			this.labelInclinationToTheEclipticDesc.Enter += this.SetStatusBar_Enter;
			this.labelInclinationToTheEclipticDesc.Leave += this.ClearStatusBar_Leave;
			this.labelInclinationToTheEclipticDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelInclinationToTheEclipticDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelOrbitalEccentricityDesc
			// 
			this.labelOrbitalEccentricityDesc.AccessibleDescription = "Orbital eccentricity";
			this.labelOrbitalEccentricityDesc.AccessibleName = "Orbital eccentricity";
			this.labelOrbitalEccentricityDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelOrbitalEccentricityDesc.Dock = DockStyle.Fill;
			this.labelOrbitalEccentricityDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelOrbitalEccentricityDesc.Location = new Point(3, 185);
			this.labelOrbitalEccentricityDesc.Name = "labelOrbitalEccentricityDesc";
			this.labelOrbitalEccentricityDesc.Size = new Size(264, 20);
			this.labelOrbitalEccentricityDesc.TabIndex = 14;
			this.toolTip.SetToolTip(this.labelOrbitalEccentricityDesc, "Orbital eccentricity");
			this.labelOrbitalEccentricityDesc.Values.Text = "Orbital eccentricity";
			this.labelOrbitalEccentricityDesc.DoubleClick += this.LabelOrbitalEccentricityDesc_DoubleClick;
			this.labelOrbitalEccentricityDesc.Enter += this.SetStatusBar_Enter;
			this.labelOrbitalEccentricityDesc.Leave += this.ClearStatusBar_Leave;
			this.labelOrbitalEccentricityDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelOrbitalEccentricityDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelMeanDailyMotionDesc
			// 
			this.labelMeanDailyMotionDesc.AccessibleDescription = "Mean daily motion (degrees per day)";
			this.labelMeanDailyMotionDesc.AccessibleName = "Mean daily motion (degrees per day)";
			this.labelMeanDailyMotionDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelMeanDailyMotionDesc.Dock = DockStyle.Fill;
			this.labelMeanDailyMotionDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelMeanDailyMotionDesc.Location = new Point(3, 211);
			this.labelMeanDailyMotionDesc.Name = "labelMeanDailyMotionDesc";
			this.labelMeanDailyMotionDesc.Size = new Size(264, 20);
			this.labelMeanDailyMotionDesc.TabIndex = 16;
			this.toolTip.SetToolTip(this.labelMeanDailyMotionDesc, "Mean daily motion (degrees per day)");
			this.labelMeanDailyMotionDesc.Values.ExtraText = "°/day";
			this.labelMeanDailyMotionDesc.Values.Text = "Mean daily motion";
			this.labelMeanDailyMotionDesc.DoubleClick += this.LabelMeanDailyMotionDesc_DoubleClick;
			this.labelMeanDailyMotionDesc.Enter += this.SetStatusBar_Enter;
			this.labelMeanDailyMotionDesc.Leave += this.ClearStatusBar_Leave;
			this.labelMeanDailyMotionDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelMeanDailyMotionDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelSemiMajorAxisDesc
			// 
			this.labelSemiMajorAxisDesc.AccessibleDescription = "Semi-major axis (AU)";
			this.labelSemiMajorAxisDesc.AccessibleName = "Semi-major axis (AU)";
			this.labelSemiMajorAxisDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelSemiMajorAxisDesc.Dock = DockStyle.Fill;
			this.labelSemiMajorAxisDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelSemiMajorAxisDesc.Location = new Point(3, 237);
			this.labelSemiMajorAxisDesc.Name = "labelSemiMajorAxisDesc";
			this.labelSemiMajorAxisDesc.Size = new Size(264, 20);
			this.labelSemiMajorAxisDesc.TabIndex = 18;
			this.toolTip.SetToolTip(this.labelSemiMajorAxisDesc, "Semi-major axis (AU)");
			this.labelSemiMajorAxisDesc.Values.ExtraText = "AU";
			this.labelSemiMajorAxisDesc.Values.Text = "Semi-major axis";
			this.labelSemiMajorAxisDesc.DoubleClick += this.LabelSemiMajorAxisDesc_DoubleClick;
			this.labelSemiMajorAxisDesc.Enter += this.SetStatusBar_Enter;
			this.labelSemiMajorAxisDesc.Leave += this.ClearStatusBar_Leave;
			this.labelSemiMajorAxisDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelSemiMajorAxisDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelAbsoluteMagnitudeDesc
			// 
			this.labelAbsoluteMagnitudeDesc.AccessibleDescription = "Absolute magnitude, H";
			this.labelAbsoluteMagnitudeDesc.AccessibleName = "Absolute magnitude, H";
			this.labelAbsoluteMagnitudeDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelAbsoluteMagnitudeDesc.Dock = DockStyle.Fill;
			this.labelAbsoluteMagnitudeDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelAbsoluteMagnitudeDesc.Location = new Point(3, 263);
			this.labelAbsoluteMagnitudeDesc.Name = "labelAbsoluteMagnitudeDesc";
			this.labelAbsoluteMagnitudeDesc.Size = new Size(264, 20);
			this.labelAbsoluteMagnitudeDesc.TabIndex = 20;
			this.toolTip.SetToolTip(this.labelAbsoluteMagnitudeDesc, "Absolute magnitude, H");
			this.labelAbsoluteMagnitudeDesc.Values.ExtraText = "mag";
			this.labelAbsoluteMagnitudeDesc.Values.Text = "Absolute magnitude, H";
			this.labelAbsoluteMagnitudeDesc.DoubleClick += this.LabelAbsoluteMagnitudeDesc_DoubleClick;
			this.labelAbsoluteMagnitudeDesc.Enter += this.SetStatusBar_Enter;
			this.labelAbsoluteMagnitudeDesc.Leave += this.ClearStatusBar_Leave;
			this.labelAbsoluteMagnitudeDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelAbsoluteMagnitudeDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelSlopeParameterDesc
			// 
			this.labelSlopeParameterDesc.AccessibleDescription = "Slope parameter, G";
			this.labelSlopeParameterDesc.AccessibleName = "Slope parameter, G";
			this.labelSlopeParameterDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelSlopeParameterDesc.Dock = DockStyle.Fill;
			this.labelSlopeParameterDesc.LabelStyle = LabelStyle.BoldControl;
			this.labelSlopeParameterDesc.Location = new Point(422, 29);
			this.labelSlopeParameterDesc.Name = "labelSlopeParameterDesc";
			this.labelSlopeParameterDesc.Size = new Size(222, 20);
			this.labelSlopeParameterDesc.TabIndex = 22;
			this.toolTip.SetToolTip(this.labelSlopeParameterDesc, "Slope parameter, G");
			this.labelSlopeParameterDesc.Values.Text = "Slope parameter, G";
			this.labelSlopeParameterDesc.DoubleClick += this.LabelSlopeParameterDesc_DoubleClick;
			this.labelSlopeParameterDesc.Enter += this.SetStatusBar_Enter;
			this.labelSlopeParameterDesc.Leave += this.ClearStatusBar_Leave;
			this.labelSlopeParameterDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelSlopeParameterDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelReferenceDesc
			// 
			this.labelReferenceDesc.AccessibleDescription = "Reference";
			this.labelReferenceDesc.AccessibleName = "Reference";
			this.labelReferenceDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelReferenceDesc.Dock = DockStyle.Fill;
			this.labelReferenceDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelReferenceDesc.Location = new Point(422, 55);
			this.labelReferenceDesc.Name = "labelReferenceDesc";
			this.labelReferenceDesc.Size = new Size(222, 20);
			this.labelReferenceDesc.TabIndex = 24;
			this.toolTip.SetToolTip(this.labelReferenceDesc, "Reference");
			this.labelReferenceDesc.Values.Text = "Reference";
			this.labelReferenceDesc.DoubleClick += this.LabelReferenceDesc_DoubleClick;
			this.labelReferenceDesc.Enter += this.SetStatusBar_Enter;
			this.labelReferenceDesc.Leave += this.ClearStatusBar_Leave;
			this.labelReferenceDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelReferenceDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelNumberOfOppositionsDesc
			// 
			this.labelNumberOfOppositionsDesc.AccessibleDescription = "Number of oppositions";
			this.labelNumberOfOppositionsDesc.AccessibleName = "Number of oppositions";
			this.labelNumberOfOppositionsDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelNumberOfOppositionsDesc.Dock = DockStyle.Fill;
			this.labelNumberOfOppositionsDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelNumberOfOppositionsDesc.Location = new Point(422, 81);
			this.labelNumberOfOppositionsDesc.Name = "labelNumberOfOppositionsDesc";
			this.labelNumberOfOppositionsDesc.Size = new Size(222, 20);
			this.labelNumberOfOppositionsDesc.TabIndex = 26;
			this.toolTip.SetToolTip(this.labelNumberOfOppositionsDesc, "Number of oppositions");
			this.labelNumberOfOppositionsDesc.Values.Text = "Number of oppositions";
			this.labelNumberOfOppositionsDesc.DoubleClick += this.LabelNumberOfOppositionsDesc_DoubleClick;
			this.labelNumberOfOppositionsDesc.Enter += this.SetStatusBar_Enter;
			this.labelNumberOfOppositionsDesc.Leave += this.ClearStatusBar_Leave;
			this.labelNumberOfOppositionsDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelNumberOfOppositionsDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelNumberOfObservationsDesc
			// 
			this.labelNumberOfObservationsDesc.AccessibleDescription = "Number of observations";
			this.labelNumberOfObservationsDesc.AccessibleName = "Number of observations";
			this.labelNumberOfObservationsDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelNumberOfObservationsDesc.Dock = DockStyle.Fill;
			this.labelNumberOfObservationsDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelNumberOfObservationsDesc.Location = new Point(422, 107);
			this.labelNumberOfObservationsDesc.Name = "labelNumberOfObservationsDesc";
			this.labelNumberOfObservationsDesc.Size = new Size(222, 20);
			this.labelNumberOfObservationsDesc.TabIndex = 28;
			this.toolTip.SetToolTip(this.labelNumberOfObservationsDesc, "Number of observations");
			this.labelNumberOfObservationsDesc.Values.Text = "Number of observations";
			this.labelNumberOfObservationsDesc.DoubleClick += this.LabelNumberOfObservationsDesc_DoubleClick;
			this.labelNumberOfObservationsDesc.Enter += this.SetStatusBar_Enter;
			this.labelNumberOfObservationsDesc.Leave += this.ClearStatusBar_Leave;
			this.labelNumberOfObservationsDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelNumberOfObservationsDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelObservationSpanDesc
			// 
			this.labelObservationSpanDesc.AccessibleDescription = "Observation span";
			this.labelObservationSpanDesc.AccessibleName = "Observation span";
			this.labelObservationSpanDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelObservationSpanDesc.Dock = DockStyle.Fill;
			this.labelObservationSpanDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelObservationSpanDesc.Location = new Point(422, 133);
			this.labelObservationSpanDesc.Name = "labelObservationSpanDesc";
			this.labelObservationSpanDesc.Size = new Size(222, 20);
			this.labelObservationSpanDesc.TabIndex = 30;
			this.toolTip.SetToolTip(this.labelObservationSpanDesc, "Observation span");
			this.labelObservationSpanDesc.Values.Text = "Observation span";
			this.labelObservationSpanDesc.DoubleClick += this.LabelObservationSpanDesc_DoubleClick;
			this.labelObservationSpanDesc.Enter += this.SetStatusBar_Enter;
			this.labelObservationSpanDesc.Leave += this.ClearStatusBar_Leave;
			this.labelObservationSpanDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelObservationSpanDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelRmsResidualDesc
			// 
			this.labelRmsResidualDesc.AccessibleDescription = "r.m.s. residual (arcseconds)";
			this.labelRmsResidualDesc.AccessibleName = "r.m.s. residual (arcseconds)";
			this.labelRmsResidualDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelRmsResidualDesc.Dock = DockStyle.Fill;
			this.labelRmsResidualDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelRmsResidualDesc.Location = new Point(422, 159);
			this.labelRmsResidualDesc.Name = "labelRmsResidualDesc";
			this.labelRmsResidualDesc.Size = new Size(222, 20);
			this.labelRmsResidualDesc.TabIndex = 32;
			this.toolTip.SetToolTip(this.labelRmsResidualDesc, "r.m.s. residual (arcseconds)");
			this.labelRmsResidualDesc.Values.ExtraText = "\"";
			this.labelRmsResidualDesc.Values.Text = "r.m.s. residual";
			this.labelRmsResidualDesc.DoubleClick += this.LabelRmsResidualDesc_DoubleClick;
			this.labelRmsResidualDesc.Enter += this.SetStatusBar_Enter;
			this.labelRmsResidualDesc.Leave += this.ClearStatusBar_Leave;
			this.labelRmsResidualDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelRmsResidualDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelComputerNameDesc
			// 
			this.labelComputerNameDesc.AccessibleDescription = "Computer name";
			this.labelComputerNameDesc.AccessibleName = "Computer name";
			this.labelComputerNameDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelComputerNameDesc.Dock = DockStyle.Fill;
			this.labelComputerNameDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelComputerNameDesc.Location = new Point(422, 185);
			this.labelComputerNameDesc.Name = "labelComputerNameDesc";
			this.labelComputerNameDesc.Size = new Size(222, 20);
			this.labelComputerNameDesc.TabIndex = 34;
			this.toolTip.SetToolTip(this.labelComputerNameDesc, "Computer name");
			this.labelComputerNameDesc.Values.Text = "Computer name";
			this.labelComputerNameDesc.DoubleClick += this.LabelComputerNameDesc_DoubleClick;
			this.labelComputerNameDesc.Enter += this.SetStatusBar_Enter;
			this.labelComputerNameDesc.Leave += this.ClearStatusBar_Leave;
			this.labelComputerNameDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelComputerNameDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelFlagsDesc
			// 
			this.labelFlagsDesc.AccessibleDescription = "4-hexdigit flags";
			this.labelFlagsDesc.AccessibleName = "4-hexdigit flags";
			this.labelFlagsDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelFlagsDesc.Dock = DockStyle.Fill;
			this.labelFlagsDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelFlagsDesc.Location = new Point(422, 211);
			this.labelFlagsDesc.Name = "labelFlagsDesc";
			this.labelFlagsDesc.Size = new Size(222, 20);
			this.labelFlagsDesc.TabIndex = 36;
			this.toolTip.SetToolTip(this.labelFlagsDesc, "4-hexdigit flags");
			this.labelFlagsDesc.Values.Text = "4-hexdigit flags";
			this.labelFlagsDesc.DoubleClick += this.LabelFlagsDesc_DoubleClick;
			this.labelFlagsDesc.Enter += this.SetStatusBar_Enter;
			this.labelFlagsDesc.Leave += this.ClearStatusBar_Leave;
			this.labelFlagsDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelFlagsDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelDateLastObservationDesc
			// 
			this.labelDateLastObservationDesc.AccessibleDescription = "Date of last observation (YYYYMMDD)";
			this.labelDateLastObservationDesc.AccessibleName = "Date of last observation (YYYYMMDD)";
			this.labelDateLastObservationDesc.AccessibleRole = AccessibleRole.StaticText;
			this.labelDateLastObservationDesc.Dock = DockStyle.Fill;
			this.labelDateLastObservationDesc.LabelStyle = LabelStyle.BoldPanel;
			this.labelDateLastObservationDesc.Location = new Point(422, 237);
			this.labelDateLastObservationDesc.Name = "labelDateLastObservationDesc";
			this.labelDateLastObservationDesc.Size = new Size(222, 20);
			this.labelDateLastObservationDesc.TabIndex = 38;
			this.toolTip.SetToolTip(this.labelDateLastObservationDesc, "Date of last observation (YYYYMMDD)");
			this.labelDateLastObservationDesc.Values.ExtraText = "YYYYMMDD";
			this.labelDateLastObservationDesc.Values.Text = "Date of last observation";
			this.labelDateLastObservationDesc.DoubleClick += this.LabelDateLastObservationDesc_DoubleClick;
			this.labelDateLastObservationDesc.Enter += this.SetStatusBar_Enter;
			this.labelDateLastObservationDesc.Leave += this.ClearStatusBar_Leave;
			this.labelDateLastObservationDesc.MouseEnter += this.SetStatusBar_Enter;
			this.labelDateLastObservationDesc.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// contextMenuTopTenRecords
			// 
			this.contextMenuTopTenRecords.AccessibleDescription = "Shows the context menu of the top ten records";
			this.contextMenuTopTenRecords.AccessibleName = "context menu of the top ten records";
			this.contextMenuTopTenRecords.AccessibleRole = AccessibleRole.MenuPopup;
			this.contextMenuTopTenRecords.Font = new Font("Segoe UI", 9F);
			this.contextMenuTopTenRecords.Items.AddRange(new ToolStripItem[] { this.menuitemRecordsSortDirection, this.toolStripSeparator12, this.menuitemRecordsMeanAnomalyAtTheEpoch, this.menuitemRecordsArgumentOfPerihelion, this.menuitemRecordsLongitudeOfTheAscendingNode, this.menuitemRecordsInclination, this.menuitemRecordsOrbitalEccentricity, this.menuitemRecordsMeanDailyMotion, this.menuitemRecordsSemiMajorAxis, this.menuitemRecordsAbsoluteMagnitude, this.menuitemRecordsSlopeParameter, this.menuitemRecordsNumberOfOppositions, this.menuitemRecordsNumberOfObservations, this.menuitemRecordsObservationSpan, this.menuitemRecordsRmsResidual, this.menuitemRecordsComputername, this.menuitemRecordsDateOfTheLastObservation });
			this.contextMenuTopTenRecords.Name = "contextMenuTopTenRecords";
			this.contextMenuTopTenRecords.OwnerItem = this.menuitemRecords;
			this.contextMenuTopTenRecords.Size = new Size(250, 362);
			this.contextMenuTopTenRecords.TabStop = true;
			this.contextMenuTopTenRecords.Text = "Top ten records";
			this.toolTip.SetToolTip(this.contextMenuTopTenRecords, "Top ten records");
			this.contextMenuTopTenRecords.MouseEnter += this.SetStatusBar_Enter;
			this.contextMenuTopTenRecords.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsSortDirection
			// 
			this.menuitemRecordsSortDirection.AccessibleDescription = "Shows the sort direction of the top ten records";
			this.menuitemRecordsSortDirection.AccessibleName = "Sort direction";
			this.menuitemRecordsSortDirection.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemRecordsSortDirection.AutoToolTip = true;
			this.menuitemRecordsSortDirection.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemRecordsSortDirectionAscending, this.menuitemRecordsSortDirectionDescending });
			this.menuitemRecordsSortDirection.Enabled = false;
			this.menuitemRecordsSortDirection.Image = FatcowIcons16px.fatcow_cog_16px;
			this.menuitemRecordsSortDirection.Name = "menuitemRecordsSortDirection";
			this.menuitemRecordsSortDirection.Size = new Size(249, 22);
			this.menuitemRecordsSortDirection.Text = "Sort direction";
			this.menuitemRecordsSortDirection.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsSortDirection.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsSortDirectionAscending
			// 
			this.menuitemRecordsSortDirectionAscending.AccessibleDescription = "Chooses the ascending sort direction of the top ten records";
			this.menuitemRecordsSortDirectionAscending.AccessibleName = "Sorted ascending";
			this.menuitemRecordsSortDirectionAscending.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsSortDirectionAscending.Checked = true;
			this.menuitemRecordsSortDirectionAscending.CheckOnClick = true;
			this.menuitemRecordsSortDirectionAscending.CheckState = CheckState.Checked;
			this.menuitemRecordsSortDirectionAscending.Enabled = false;
			this.menuitemRecordsSortDirectionAscending.Name = "menuitemRecordsSortDirectionAscending";
			this.menuitemRecordsSortDirectionAscending.Size = new Size(136, 22);
			this.menuitemRecordsSortDirectionAscending.Text = "Ascending";
			this.menuitemRecordsSortDirectionAscending.ToolTipText = "Ascending sort direction";
			this.menuitemRecordsSortDirectionAscending.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsSortDirectionAscending.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsSortDirectionDescending
			// 
			this.menuitemRecordsSortDirectionDescending.AccessibleDescription = "Chooses the descending sort direction of the top ten records";
			this.menuitemRecordsSortDirectionDescending.AccessibleName = "Sorted descending";
			this.menuitemRecordsSortDirectionDescending.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsSortDirectionDescending.CheckOnClick = true;
			this.menuitemRecordsSortDirectionDescending.Enabled = false;
			this.menuitemRecordsSortDirectionDescending.Name = "menuitemRecordsSortDirectionDescending";
			this.menuitemRecordsSortDirectionDescending.Size = new Size(136, 22);
			this.menuitemRecordsSortDirectionDescending.Text = "Descending";
			this.menuitemRecordsSortDirectionDescending.ToolTipText = "Descending sort direction";
			this.menuitemRecordsSortDirectionDescending.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsSortDirectionDescending.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.AccessibleDescription = "Just a separator";
			this.toolStripSeparator12.AccessibleName = "Just a separator";
			this.toolStripSeparator12.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new Size(246, 6);
			this.toolStripSeparator12.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator12.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsMeanAnomalyAtTheEpoch
			// 
			this.menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the record of the mean anomaly at the epoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleName = "Record of the mean anomaly at the epoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Enabled = false;
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Image = (Image)resources.GetObject("menuitemRecordsMeanAnomalyAtTheEpoch.Image");
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Name = "menuitemRecordsMeanAnomalyAtTheEpoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Size = new Size(249, 22);
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch";
			this.menuitemRecordsMeanAnomalyAtTheEpoch.Click += MenuitemRecordsMeanAnomalyAtTheEpoch_Click;
			this.menuitemRecordsMeanAnomalyAtTheEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsMeanAnomalyAtTheEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsArgumentOfPerihelion
			// 
			this.menuitemRecordsArgumentOfPerihelion.AccessibleDescription = "Shows the record of the argument of the perihelion";
			this.menuitemRecordsArgumentOfPerihelion.AccessibleName = "Record of the argument of the perihelion";
			this.menuitemRecordsArgumentOfPerihelion.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsArgumentOfPerihelion.Enabled = false;
			this.menuitemRecordsArgumentOfPerihelion.Image = (Image)resources.GetObject("menuitemRecordsArgumentOfPerihelion.Image");
			this.menuitemRecordsArgumentOfPerihelion.Name = "menuitemRecordsArgumentOfPerihelion";
			this.menuitemRecordsArgumentOfPerihelion.Size = new Size(249, 22);
			this.menuitemRecordsArgumentOfPerihelion.Text = "Argument of perihelion";
			this.menuitemRecordsArgumentOfPerihelion.Click += MenuitemRecordsArgumentOfPerihelion_Click;
			this.menuitemRecordsArgumentOfPerihelion.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsArgumentOfPerihelion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsLongitudeOfTheAscendingNode
			// 
			this.menuitemRecordsLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the record of the longitude of the ascending node";
			this.menuitemRecordsLongitudeOfTheAscendingNode.AccessibleName = "Record of the longitude of the ascending node";
			this.menuitemRecordsLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsLongitudeOfTheAscendingNode.Enabled = false;
			this.menuitemRecordsLongitudeOfTheAscendingNode.Image = (Image)resources.GetObject("menuitemRecordsLongitudeOfTheAscendingNode.Image");
			this.menuitemRecordsLongitudeOfTheAscendingNode.Name = "menuitemRecordsLongitudeOfTheAscendingNode";
			this.menuitemRecordsLongitudeOfTheAscendingNode.Size = new Size(249, 22);
			this.menuitemRecordsLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node";
			this.menuitemRecordsLongitudeOfTheAscendingNode.Click += MenuitemRecordsLongitudeOfTheAscendingNode_Click;
			this.menuitemRecordsLongitudeOfTheAscendingNode.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsLongitudeOfTheAscendingNode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsInclination
			// 
			this.menuitemRecordsInclination.AccessibleDescription = "Shows the record of the inclination to the ecliptic";
			this.menuitemRecordsInclination.AccessibleName = "Record of the inclination to the ecliptic";
			this.menuitemRecordsInclination.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsInclination.Enabled = false;
			this.menuitemRecordsInclination.Image = (Image)resources.GetObject("menuitemRecordsInclination.Image");
			this.menuitemRecordsInclination.Name = "menuitemRecordsInclination";
			this.menuitemRecordsInclination.Size = new Size(249, 22);
			this.menuitemRecordsInclination.Text = "Inclination to the ecliptic";
			this.menuitemRecordsInclination.Click += MenuitemRecordsInclination_Click;
			this.menuitemRecordsInclination.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsInclination.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsOrbitalEccentricity
			// 
			this.menuitemRecordsOrbitalEccentricity.AccessibleDescription = "Shows the record of the orbital eccentricity";
			this.menuitemRecordsOrbitalEccentricity.AccessibleName = "Record of the orbital eccentricity";
			this.menuitemRecordsOrbitalEccentricity.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsOrbitalEccentricity.Enabled = false;
			this.menuitemRecordsOrbitalEccentricity.Image = (Image)resources.GetObject("menuitemRecordsOrbitalEccentricity.Image");
			this.menuitemRecordsOrbitalEccentricity.Name = "menuitemRecordsOrbitalEccentricity";
			this.menuitemRecordsOrbitalEccentricity.Size = new Size(249, 22);
			this.menuitemRecordsOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemRecordsOrbitalEccentricity.Click += MenuitemRecordsOrbitalEccentricity_Click;
			this.menuitemRecordsOrbitalEccentricity.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsOrbitalEccentricity.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsMeanDailyMotion
			// 
			this.menuitemRecordsMeanDailyMotion.AccessibleDescription = "Shows the record of the mean daily motion";
			this.menuitemRecordsMeanDailyMotion.AccessibleName = "Record of the mean daily motion";
			this.menuitemRecordsMeanDailyMotion.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsMeanDailyMotion.Enabled = false;
			this.menuitemRecordsMeanDailyMotion.Image = (Image)resources.GetObject("menuitemRecordsMeanDailyMotion.Image");
			this.menuitemRecordsMeanDailyMotion.Name = "menuitemRecordsMeanDailyMotion";
			this.menuitemRecordsMeanDailyMotion.Size = new Size(249, 22);
			this.menuitemRecordsMeanDailyMotion.Text = "Mean daily motion";
			this.menuitemRecordsMeanDailyMotion.Click += MenuitemRecordsMeanDailyMotion_Click;
			this.menuitemRecordsMeanDailyMotion.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsMeanDailyMotion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsSemiMajorAxis
			// 
			this.menuitemRecordsSemiMajorAxis.AccessibleDescription = "Shows the record of the semi-major axis";
			this.menuitemRecordsSemiMajorAxis.AccessibleName = "Record of the semi-major axis";
			this.menuitemRecordsSemiMajorAxis.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsSemiMajorAxis.Enabled = false;
			this.menuitemRecordsSemiMajorAxis.Image = (Image)resources.GetObject("menuitemRecordsSemiMajorAxis.Image");
			this.menuitemRecordsSemiMajorAxis.Name = "menuitemRecordsSemiMajorAxis";
			this.menuitemRecordsSemiMajorAxis.Size = new Size(249, 22);
			this.menuitemRecordsSemiMajorAxis.Text = "Semi-major axis";
			this.menuitemRecordsSemiMajorAxis.Click += MenuitemRecordsSemiMajorAxis_Click;
			this.menuitemRecordsSemiMajorAxis.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsSemiMajorAxis.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsAbsoluteMagnitude
			// 
			this.menuitemRecordsAbsoluteMagnitude.AccessibleDescription = "Shows the record of the absolute magnitude";
			this.menuitemRecordsAbsoluteMagnitude.AccessibleName = "Record of the absolute magnitude";
			this.menuitemRecordsAbsoluteMagnitude.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsAbsoluteMagnitude.Enabled = false;
			this.menuitemRecordsAbsoluteMagnitude.Image = (Image)resources.GetObject("menuitemRecordsAbsoluteMagnitude.Image");
			this.menuitemRecordsAbsoluteMagnitude.Name = "menuitemRecordsAbsoluteMagnitude";
			this.menuitemRecordsAbsoluteMagnitude.Size = new Size(249, 22);
			this.menuitemRecordsAbsoluteMagnitude.Text = "Absolute magnitude";
			this.menuitemRecordsAbsoluteMagnitude.Click += MenuitemRecordsAbsoluteMagnitude_Click;
			this.menuitemRecordsAbsoluteMagnitude.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsAbsoluteMagnitude.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsSlopeParameter
			// 
			this.menuitemRecordsSlopeParameter.AccessibleDescription = "Shows the record of the slope parameter";
			this.menuitemRecordsSlopeParameter.AccessibleName = "Record of the slope parameter";
			this.menuitemRecordsSlopeParameter.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsSlopeParameter.Enabled = false;
			this.menuitemRecordsSlopeParameter.Image = (Image)resources.GetObject("menuitemRecordsSlopeParameter.Image");
			this.menuitemRecordsSlopeParameter.Name = "menuitemRecordsSlopeParameter";
			this.menuitemRecordsSlopeParameter.Size = new Size(249, 22);
			this.menuitemRecordsSlopeParameter.Text = "Slope parameter";
			this.menuitemRecordsSlopeParameter.Click += MenuitemRecordsSlopeParameter_Click;
			this.menuitemRecordsSlopeParameter.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsSlopeParameter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsNumberOfOppositions
			// 
			this.menuitemRecordsNumberOfOppositions.AccessibleDescription = "Shows the record of the number of oppositions";
			this.menuitemRecordsNumberOfOppositions.AccessibleName = "Record of the number of oppositions";
			this.menuitemRecordsNumberOfOppositions.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsNumberOfOppositions.Enabled = false;
			this.menuitemRecordsNumberOfOppositions.Image = (Image)resources.GetObject("menuitemRecordsNumberOfOppositions.Image");
			this.menuitemRecordsNumberOfOppositions.Name = "menuitemRecordsNumberOfOppositions";
			this.menuitemRecordsNumberOfOppositions.Size = new Size(249, 22);
			this.menuitemRecordsNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemRecordsNumberOfOppositions.Click += MenuitemRecordsNumberOfOppositions_Click;
			this.menuitemRecordsNumberOfOppositions.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsNumberOfOppositions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsNumberOfObservations
			// 
			this.menuitemRecordsNumberOfObservations.AccessibleDescription = "Shows the record of the number of observations";
			this.menuitemRecordsNumberOfObservations.AccessibleName = "Record of the number of observations";
			this.menuitemRecordsNumberOfObservations.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsNumberOfObservations.Enabled = false;
			this.menuitemRecordsNumberOfObservations.Image = (Image)resources.GetObject("menuitemRecordsNumberOfObservations.Image");
			this.menuitemRecordsNumberOfObservations.Name = "menuitemRecordsNumberOfObservations";
			this.menuitemRecordsNumberOfObservations.Size = new Size(249, 22);
			this.menuitemRecordsNumberOfObservations.Text = "Number of observations";
			this.menuitemRecordsNumberOfObservations.Click += MenuitemRecordsNumberOfObservations_Click;
			this.menuitemRecordsNumberOfObservations.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsNumberOfObservations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsObservationSpan
			// 
			this.menuitemRecordsObservationSpan.AccessibleDescription = "Shows the record of the observation span";
			this.menuitemRecordsObservationSpan.AccessibleName = "Record of the observation span";
			this.menuitemRecordsObservationSpan.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsObservationSpan.Enabled = false;
			this.menuitemRecordsObservationSpan.Image = (Image)resources.GetObject("menuitemRecordsObservationSpan.Image");
			this.menuitemRecordsObservationSpan.Name = "menuitemRecordsObservationSpan";
			this.menuitemRecordsObservationSpan.Size = new Size(249, 22);
			this.menuitemRecordsObservationSpan.Text = "Observation span";
			this.menuitemRecordsObservationSpan.Click += MenuitemRecordsObservationSpan_Click;
			this.menuitemRecordsObservationSpan.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsObservationSpan.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsRmsResidual
			// 
			this.menuitemRecordsRmsResidual.AccessibleDescription = "Shows the record of the r.m.s. residual";
			this.menuitemRecordsRmsResidual.AccessibleName = "Record of the r.m.s. residual";
			this.menuitemRecordsRmsResidual.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsRmsResidual.Enabled = false;
			this.menuitemRecordsRmsResidual.Image = (Image)resources.GetObject("menuitemRecordsRmsResidual.Image");
			this.menuitemRecordsRmsResidual.Name = "menuitemRecordsRmsResidual";
			this.menuitemRecordsRmsResidual.Size = new Size(249, 22);
			this.menuitemRecordsRmsResidual.Text = "r.m.s. residual";
			this.menuitemRecordsRmsResidual.Click += MenuitemRecordsRmsResidual_Click;
			this.menuitemRecordsRmsResidual.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsRmsResidual.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsComputername
			// 
			this.menuitemRecordsComputername.AccessibleDescription = "Shows the record of the computer name";
			this.menuitemRecordsComputername.AccessibleName = "Record of the computer name";
			this.menuitemRecordsComputername.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsComputername.Enabled = false;
			this.menuitemRecordsComputername.Image = (Image)resources.GetObject("menuitemRecordsComputername.Image");
			this.menuitemRecordsComputername.Name = "menuitemRecordsComputername";
			this.menuitemRecordsComputername.Size = new Size(249, 22);
			this.menuitemRecordsComputername.Text = "Computer name";
			this.menuitemRecordsComputername.Click += MenuitemRecordsComputerName_Click;
			this.menuitemRecordsComputername.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsComputername.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecordsDateOfTheLastObservation
			// 
			this.menuitemRecordsDateOfTheLastObservation.AccessibleDescription = "Shows the record of the date of the last observation";
			this.menuitemRecordsDateOfTheLastObservation.AccessibleName = "Record of the date of the last observation";
			this.menuitemRecordsDateOfTheLastObservation.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecordsDateOfTheLastObservation.Enabled = false;
			this.menuitemRecordsDateOfTheLastObservation.Image = (Image)resources.GetObject("menuitemRecordsDateOfTheLastObservation.Image");
			this.menuitemRecordsDateOfTheLastObservation.Name = "menuitemRecordsDateOfTheLastObservation";
			this.menuitemRecordsDateOfTheLastObservation.Size = new Size(249, 22);
			this.menuitemRecordsDateOfTheLastObservation.Text = "Date of the last observation";
			this.menuitemRecordsDateOfTheLastObservation.Click += MenuitemRecordsDateOfTheLastObservation_Click;
			this.menuitemRecordsDateOfTheLastObservation.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecordsDateOfTheLastObservation.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// splitbuttonTopTenRecords
			// 
			this.splitbuttonTopTenRecords.AccessibleDescription = "Shows the top ten records";
			this.splitbuttonTopTenRecords.AccessibleName = "Top ten records";
			this.splitbuttonTopTenRecords.AccessibleRole = AccessibleRole.SplitButton;
			this.splitbuttonTopTenRecords.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.splitbuttonTopTenRecords.DropDown = this.contextMenuTopTenRecords;
			this.splitbuttonTopTenRecords.Enabled = false;
			this.splitbuttonTopTenRecords.Image = FatcowIcons16px.fatcow_text_list_numbers_16px;
			this.splitbuttonTopTenRecords.ImageTransparentColor = Color.Magenta;
			this.splitbuttonTopTenRecords.Name = "splitbuttonTopTenRecords";
			this.splitbuttonTopTenRecords.Size = new Size(32, 22);
			this.splitbuttonTopTenRecords.Text = "Top ten records";
			this.splitbuttonTopTenRecords.ButtonClick += this.SplitButtonTopTenRecords_ButtonClick;
			this.splitbuttonTopTenRecords.MouseEnter += this.SetStatusBar_Enter;
			this.splitbuttonTopTenRecords.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// contextMenuDistributions
			// 
			this.contextMenuDistributions.AccessibleDescription = "Shows the context menu of the distributions";
			this.contextMenuDistributions.AccessibleName = "context menu of the distributions";
			this.contextMenuDistributions.AccessibleRole = AccessibleRole.MenuPopup;
			this.contextMenuDistributions.Font = new Font("Segoe UI", 9F);
			this.contextMenuDistributions.Items.AddRange(new ToolStripItem[] { this.menuitemDistributionMeanAnomalyAtTheEpoch, this.menuitemDistributionArgumentOfPerihelion, this.menuitemDistributionLongitudeOfTheAscendingNode, this.menuitemDistributionInclination, this.menuitemDistributionOrbitalEccentricity, this.menuitemDistributionMeanDailyMotion, this.menuitemDistributionSemiMajorAxis, this.menuitemDistributionAbsoluteMagnitude, this.menuitemDistributionSlopeParameter, this.menuitemDistributionNumberOfOppositions, this.menuitemDistributionNumberOfObservations, this.menuitemDistributionObservationSpan, this.menuitemDistributionRmsResidual, this.menuitemDistributionComputerName });
			this.contextMenuDistributions.Name = "contextMenuDistributions";
			this.contextMenuDistributions.OwnerItem = this.splitbuttonDistribution;
			this.contextMenuDistributions.Size = new Size(250, 312);
			this.contextMenuDistributions.Text = "Distributions";
			this.toolTip.SetToolTip(this.contextMenuDistributions, "Distributions");
			// 
			// menuitemDistributionMeanAnomalyAtTheEpoch
			// 
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the distribution of mean anomaly at the epoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleName = "Distribution of mean anomaly at the epoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.AutoToolTip = true;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Enabled = false;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Image = (Image)resources.GetObject("menuitemDistributionMeanAnomalyAtTheEpoch.Image");
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Name = "menuitemDistributionMeanAnomalyAtTheEpoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Size = new Size(249, 22);
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch";
			this.menuitemDistributionMeanAnomalyAtTheEpoch.Click += MenuitemDistributionMeanAnomalyAtTheEpoch_Click;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionMeanAnomalyAtTheEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionArgumentOfPerihelion
			// 
			this.menuitemDistributionArgumentOfPerihelion.AccessibleDescription = "Shows the distribution of the argument of perihelion";
			this.menuitemDistributionArgumentOfPerihelion.AccessibleName = "Distribution of the argument of perihelion";
			this.menuitemDistributionArgumentOfPerihelion.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionArgumentOfPerihelion.AutoToolTip = true;
			this.menuitemDistributionArgumentOfPerihelion.Enabled = false;
			this.menuitemDistributionArgumentOfPerihelion.Image = (Image)resources.GetObject("menuitemDistributionArgumentOfPerihelion.Image");
			this.menuitemDistributionArgumentOfPerihelion.Name = "menuitemDistributionArgumentOfPerihelion";
			this.menuitemDistributionArgumentOfPerihelion.Size = new Size(249, 22);
			this.menuitemDistributionArgumentOfPerihelion.Text = "Argument of perihelion";
			this.menuitemDistributionArgumentOfPerihelion.Click += MenuitemDistributionArgumentOfPerihelion_Click;
			this.menuitemDistributionArgumentOfPerihelion.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionArgumentOfPerihelion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionLongitudeOfTheAscendingNode
			// 
			this.menuitemDistributionLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the distribution of the longitude of the ascending node";
			this.menuitemDistributionLongitudeOfTheAscendingNode.AccessibleName = "Distribution of the longitude of the ascending node";
			this.menuitemDistributionLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.menuitemDistributionLongitudeOfTheAscendingNode.Enabled = false;
			this.menuitemDistributionLongitudeOfTheAscendingNode.Image = (Image)resources.GetObject("menuitemDistributionLongitudeOfTheAscendingNode.Image");
			this.menuitemDistributionLongitudeOfTheAscendingNode.Name = "menuitemDistributionLongitudeOfTheAscendingNode";
			this.menuitemDistributionLongitudeOfTheAscendingNode.Size = new Size(249, 22);
			this.menuitemDistributionLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node";
			this.menuitemDistributionLongitudeOfTheAscendingNode.Click += MenuitemDistributionLongitudeOfTheAscendingNode_Click;
			this.menuitemDistributionLongitudeOfTheAscendingNode.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionLongitudeOfTheAscendingNode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionInclination
			// 
			this.menuitemDistributionInclination.AccessibleDescription = "Shows the distribution of the inclination to the ecliptic";
			this.menuitemDistributionInclination.AccessibleName = "Distribution of the inclination to the ecliptic";
			this.menuitemDistributionInclination.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionInclination.AutoToolTip = true;
			this.menuitemDistributionInclination.Enabled = false;
			this.menuitemDistributionInclination.Image = (Image)resources.GetObject("menuitemDistributionInclination.Image");
			this.menuitemDistributionInclination.Name = "menuitemDistributionInclination";
			this.menuitemDistributionInclination.Size = new Size(249, 22);
			this.menuitemDistributionInclination.Text = "Inclination to the ecliptic";
			this.menuitemDistributionInclination.Click += MenuitemDistributionInclination_Click;
			this.menuitemDistributionInclination.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionInclination.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionOrbitalEccentricity
			// 
			this.menuitemDistributionOrbitalEccentricity.AccessibleDescription = "Shows the distribution of the orbital eccentricity";
			this.menuitemDistributionOrbitalEccentricity.AccessibleName = "Distribution of the orbital eccentricity";
			this.menuitemDistributionOrbitalEccentricity.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionOrbitalEccentricity.AutoToolTip = true;
			this.menuitemDistributionOrbitalEccentricity.Enabled = false;
			this.menuitemDistributionOrbitalEccentricity.Image = (Image)resources.GetObject("menuitemDistributionOrbitalEccentricity.Image");
			this.menuitemDistributionOrbitalEccentricity.Name = "menuitemDistributionOrbitalEccentricity";
			this.menuitemDistributionOrbitalEccentricity.Size = new Size(249, 22);
			this.menuitemDistributionOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemDistributionOrbitalEccentricity.Click += MenuitemDistributionOrbitalEccentricity_Click;
			this.menuitemDistributionOrbitalEccentricity.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionOrbitalEccentricity.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionMeanDailyMotion
			// 
			this.menuitemDistributionMeanDailyMotion.AccessibleDescription = "Shows the distribution of the mean daily motion";
			this.menuitemDistributionMeanDailyMotion.AccessibleName = "Distribution of the mean daily motion";
			this.menuitemDistributionMeanDailyMotion.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionMeanDailyMotion.AutoToolTip = true;
			this.menuitemDistributionMeanDailyMotion.Enabled = false;
			this.menuitemDistributionMeanDailyMotion.Image = (Image)resources.GetObject("menuitemDistributionMeanDailyMotion.Image");
			this.menuitemDistributionMeanDailyMotion.Name = "menuitemDistributionMeanDailyMotion";
			this.menuitemDistributionMeanDailyMotion.Size = new Size(249, 22);
			this.menuitemDistributionMeanDailyMotion.Text = "Mean daily motion";
			this.menuitemDistributionMeanDailyMotion.Click += MenuitemDistributionMeanDailyMotion_Click;
			this.menuitemDistributionMeanDailyMotion.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionMeanDailyMotion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionSemiMajorAxis
			// 
			this.menuitemDistributionSemiMajorAxis.AccessibleDescription = "Shows the distribution of the semi-major axis";
			this.menuitemDistributionSemiMajorAxis.AccessibleName = "Distribution of the semi-major axis";
			this.menuitemDistributionSemiMajorAxis.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionSemiMajorAxis.AutoToolTip = true;
			this.menuitemDistributionSemiMajorAxis.Enabled = false;
			this.menuitemDistributionSemiMajorAxis.Image = (Image)resources.GetObject("menuitemDistributionSemiMajorAxis.Image");
			this.menuitemDistributionSemiMajorAxis.Name = "menuitemDistributionSemiMajorAxis";
			this.menuitemDistributionSemiMajorAxis.Size = new Size(249, 22);
			this.menuitemDistributionSemiMajorAxis.Text = "Semi-major axis";
			this.menuitemDistributionSemiMajorAxis.Click += MenuitemDistributionSemiMajorAxis_Click;
			this.menuitemDistributionSemiMajorAxis.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionSemiMajorAxis.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionAbsoluteMagnitude
			// 
			this.menuitemDistributionAbsoluteMagnitude.AccessibleDescription = "Shows the distribution of the absolute magnitude";
			this.menuitemDistributionAbsoluteMagnitude.AccessibleName = "Distribution of the absolute magnitude";
			this.menuitemDistributionAbsoluteMagnitude.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionAbsoluteMagnitude.AutoToolTip = true;
			this.menuitemDistributionAbsoluteMagnitude.Enabled = false;
			this.menuitemDistributionAbsoluteMagnitude.Image = (Image)resources.GetObject("menuitemDistributionAbsoluteMagnitude.Image");
			this.menuitemDistributionAbsoluteMagnitude.Name = "menuitemDistributionAbsoluteMagnitude";
			this.menuitemDistributionAbsoluteMagnitude.Size = new Size(249, 22);
			this.menuitemDistributionAbsoluteMagnitude.Text = "Absolute magnitude";
			this.menuitemDistributionAbsoluteMagnitude.Click += MenuitemDistributionAbsoluteMagnitude_Click;
			this.menuitemDistributionAbsoluteMagnitude.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionAbsoluteMagnitude.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionSlopeParameter
			// 
			this.menuitemDistributionSlopeParameter.AccessibleDescription = "Shows the distribution of the slope parameter";
			this.menuitemDistributionSlopeParameter.AccessibleName = "Distribution of the slope parameter";
			this.menuitemDistributionSlopeParameter.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionSlopeParameter.AutoToolTip = true;
			this.menuitemDistributionSlopeParameter.Enabled = false;
			this.menuitemDistributionSlopeParameter.Image = (Image)resources.GetObject("menuitemDistributionSlopeParameter.Image");
			this.menuitemDistributionSlopeParameter.Name = "menuitemDistributionSlopeParameter";
			this.menuitemDistributionSlopeParameter.Size = new Size(249, 22);
			this.menuitemDistributionSlopeParameter.Text = "Slope parameter";
			this.menuitemDistributionSlopeParameter.Click += MenuitemDistributionSlopeParameter_Click;
			this.menuitemDistributionSlopeParameter.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionSlopeParameter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionNumberOfOppositions
			// 
			this.menuitemDistributionNumberOfOppositions.AccessibleDescription = "Shows the distribution of the number of oppositions";
			this.menuitemDistributionNumberOfOppositions.AccessibleName = "Distribution of the number of oppositions";
			this.menuitemDistributionNumberOfOppositions.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionNumberOfOppositions.AutoToolTip = true;
			this.menuitemDistributionNumberOfOppositions.Enabled = false;
			this.menuitemDistributionNumberOfOppositions.Image = (Image)resources.GetObject("menuitemDistributionNumberOfOppositions.Image");
			this.menuitemDistributionNumberOfOppositions.Name = "menuitemDistributionNumberOfOppositions";
			this.menuitemDistributionNumberOfOppositions.Size = new Size(249, 22);
			this.menuitemDistributionNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemDistributionNumberOfOppositions.Click += MenuitemDistributionNumberOfOppositions_Click;
			this.menuitemDistributionNumberOfOppositions.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionNumberOfOppositions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionNumberOfObservations
			// 
			this.menuitemDistributionNumberOfObservations.AccessibleDescription = "Show the distribution of the number of observations";
			this.menuitemDistributionNumberOfObservations.AccessibleName = "Distribution of the number of observations";
			this.menuitemDistributionNumberOfObservations.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionNumberOfObservations.AutoToolTip = true;
			this.menuitemDistributionNumberOfObservations.Enabled = false;
			this.menuitemDistributionNumberOfObservations.Image = (Image)resources.GetObject("menuitemDistributionNumberOfObservations.Image");
			this.menuitemDistributionNumberOfObservations.Name = "menuitemDistributionNumberOfObservations";
			this.menuitemDistributionNumberOfObservations.Size = new Size(249, 22);
			this.menuitemDistributionNumberOfObservations.Text = "Number of observations";
			this.menuitemDistributionNumberOfObservations.Click += MenuitemDistributionNumberOfObservations_Click;
			this.menuitemDistributionNumberOfObservations.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionNumberOfObservations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionObservationSpan
			// 
			this.menuitemDistributionObservationSpan.AccessibleDescription = "Shows the distribution of the observation span";
			this.menuitemDistributionObservationSpan.AccessibleName = "Distribution of the observation span";
			this.menuitemDistributionObservationSpan.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionObservationSpan.AutoToolTip = true;
			this.menuitemDistributionObservationSpan.Enabled = false;
			this.menuitemDistributionObservationSpan.Image = (Image)resources.GetObject("menuitemDistributionObservationSpan.Image");
			this.menuitemDistributionObservationSpan.Name = "menuitemDistributionObservationSpan";
			this.menuitemDistributionObservationSpan.Size = new Size(249, 22);
			this.menuitemDistributionObservationSpan.Text = "Observation span";
			this.menuitemDistributionObservationSpan.Click += MenuitemDistributionObservationSpan_Click;
			this.menuitemDistributionObservationSpan.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionObservationSpan.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionRmsResidual
			// 
			this.menuitemDistributionRmsResidual.AccessibleDescription = "Shows the distribution of the r.m.s. residual";
			this.menuitemDistributionRmsResidual.AccessibleName = "Distribution of the r.m.s. residual";
			this.menuitemDistributionRmsResidual.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionRmsResidual.AutoToolTip = true;
			this.menuitemDistributionRmsResidual.Enabled = false;
			this.menuitemDistributionRmsResidual.Image = (Image)resources.GetObject("menuitemDistributionRmsResidual.Image");
			this.menuitemDistributionRmsResidual.Name = "menuitemDistributionRmsResidual";
			this.menuitemDistributionRmsResidual.Size = new Size(249, 22);
			this.menuitemDistributionRmsResidual.Text = "r.m.s. residual";
			this.menuitemDistributionRmsResidual.Click += MenuitemDistributionRmsResidual_Click;
			this.menuitemDistributionRmsResidual.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionRmsResidual.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistributionComputerName
			// 
			this.menuitemDistributionComputerName.AccessibleDescription = "Shows the distribution of the computer name";
			this.menuitemDistributionComputerName.AccessibleName = "Distribution of the computer name";
			this.menuitemDistributionComputerName.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistributionComputerName.AutoToolTip = true;
			this.menuitemDistributionComputerName.Enabled = false;
			this.menuitemDistributionComputerName.Image = (Image)resources.GetObject("menuitemDistributionComputerName.Image");
			this.menuitemDistributionComputerName.Name = "menuitemDistributionComputerName";
			this.menuitemDistributionComputerName.Size = new Size(249, 22);
			this.menuitemDistributionComputerName.Text = "Computer name";
			this.menuitemDistributionComputerName.Click += MenuitemDistributionComputerName_Click;
			this.menuitemDistributionComputerName.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistributionComputerName.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDistribution
			// 
			this.menuitemDistribution.AccessibleDescription = "Shows some distributions";
			this.menuitemDistribution.AccessibleName = "Distributions";
			this.menuitemDistribution.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDistribution.AutoToolTip = true;
			this.menuitemDistribution.DoubleClickEnabled = true;
			this.menuitemDistribution.DropDown = this.contextMenuDistributions;
			this.menuitemDistribution.Enabled = false;
			this.menuitemDistribution.Image = FatcowIcons16px.fatcow_chart_bar_16px;
			this.menuitemDistribution.Name = "menuitemDistribution";
			this.menuitemDistribution.ShortcutKeys = Keys.Control | Keys.D;
			this.menuitemDistribution.Size = new Size(227, 22);
			this.menuitemDistribution.Text = "&Distributions";
			this.menuitemDistribution.Click += MenuitemDistribution_Click;
			this.menuitemDistribution.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDistribution.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// contextMenuCopyToClipboardOrbitalElements
			// 
			this.contextMenuCopyToClipboardOrbitalElements.AccessibleDescription = "Shows the context menu of the orbital elements to copy to clipboard";
			this.contextMenuCopyToClipboardOrbitalElements.AccessibleName = "context menu of the orbital elements to copy to clipboard";
			this.contextMenuCopyToClipboardOrbitalElements.AccessibleRole = AccessibleRole.MenuPopup;
			this.contextMenuCopyToClipboardOrbitalElements.Font = new Font("Segoe UI", 9F);
			this.contextMenuCopyToClipboardOrbitalElements.Items.AddRange(new ToolStripItem[] { this.menuitemCopyToClipboardIndexNumber, this.menuitemCopyToClipboardReadableDesignation, this.menuitemCopyToClipboardEpoch, this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch, this.menuitemCopyToClipboardArgumentOfPerihelion, this.menuitemCopyToClipboardLongitudeOfTheAscendingNode, this.menuitemCopyToClipboardInclinationToTheEcliptic, this.menuitemCopyToClipboardOrbitalEccentricity, this.menuitemCopyToClipboardMeanDailyMotion, this.menuitemCopyToClipboardSemiMajorAxis, this.menuitemCopyToClipboardAbsoluteMagnitude, this.menuitemCopyToClipboardSlopeParameter, this.menuitemCopyToClipboardReference, this.menuitemCopyToClipboardNumberOfOppositions, this.menuitemCopyToClipboardNumberOfObservations, this.menuitemCopyToClipboardObservationSpan, this.menuitemCopyToClipboardRmsResidual, this.menuitemCopyToClipboardComputerName, this.menuitemCopyToClipboardDateOfTheLastObservation, this.menuitemCopyToClipboardFlags });
			this.contextMenuCopyToClipboardOrbitalElements.Name = resources.GetString("contextMenuCopyToClipboardOrbitalElements.Name");
			this.contextMenuCopyToClipboardOrbitalElements.OwnerItem = this.menuitemCopytoClipboard;
			this.contextMenuCopyToClipboardOrbitalElements.Size = new Size(309, 444);
			this.contextMenuCopyToClipboardOrbitalElements.Text = "Copy to clipboard";
			this.toolTip.SetToolTip(this.contextMenuCopyToClipboardOrbitalElements, "Copy to clipboard");
			// 
			// menuitemCopyToClipboardIndexNumber
			// 
			this.menuitemCopyToClipboardIndexNumber.AccessibleDescription = "Copy to clipboard: Index number";
			this.menuitemCopyToClipboardIndexNumber.AccessibleName = "Copy to clipboard: Index number";
			this.menuitemCopyToClipboardIndexNumber.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardIndexNumber.AutoToolTip = true;
			this.menuitemCopyToClipboardIndexNumber.Image = (Image)resources.GetObject("menuitemCopyToClipboardIndexNumber.Image");
			this.menuitemCopyToClipboardIndexNumber.Name = "menuitemCopyToClipboardIndexNumber";
			this.menuitemCopyToClipboardIndexNumber.Size = new Size(308, 22);
			this.menuitemCopyToClipboardIndexNumber.Text = "Index No.";
			this.menuitemCopyToClipboardIndexNumber.Click += ToolStripMenuItemCopyToClipboardIndexNumber_Click;
			this.menuitemCopyToClipboardIndexNumber.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardIndexNumber.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardReadableDesignation
			// 
			this.menuitemCopyToClipboardReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			this.menuitemCopyToClipboardReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			this.menuitemCopyToClipboardReadableDesignation.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardReadableDesignation.AutoToolTip = true;
			this.menuitemCopyToClipboardReadableDesignation.Image = (Image)resources.GetObject("menuitemCopyToClipboardReadableDesignation.Image");
			this.menuitemCopyToClipboardReadableDesignation.Name = "menuitemCopyToClipboardReadableDesignation";
			this.menuitemCopyToClipboardReadableDesignation.Size = new Size(308, 22);
			this.menuitemCopyToClipboardReadableDesignation.Text = "Readable designation";
			this.menuitemCopyToClipboardReadableDesignation.Click += ToolStripMenuItemCopyToClipboardReadableDesignation_Click;
			this.menuitemCopyToClipboardReadableDesignation.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardReadableDesignation.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardEpoch
			// 
			this.menuitemCopyToClipboardEpoch.AccessibleDescription = "Copy to clipboard: Epoch";
			this.menuitemCopyToClipboardEpoch.AccessibleName = "Copy to clipboard: Epoch";
			this.menuitemCopyToClipboardEpoch.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardEpoch.AutoToolTip = true;
			this.menuitemCopyToClipboardEpoch.Image = (Image)resources.GetObject("menuitemCopyToClipboardEpoch.Image");
			this.menuitemCopyToClipboardEpoch.Name = "menuitemCopyToClipboardEpoch";
			this.menuitemCopyToClipboardEpoch.Size = new Size(308, 22);
			this.menuitemCopyToClipboardEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.menuitemCopyToClipboardEpoch.Click += ToolStripMenuItemCopyToClipboardEpoch_Click;
			this.menuitemCopyToClipboardEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardMeanAnomalyAtTheEpoch
			// 
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AutoToolTip = true;
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Image = (Image)resources.GetObject("menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Image");
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Name = "menuitemCopyToClipboardMeanAnomalyAtTheEpoch";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Size = new Size(308, 22);
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch (°)";
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Click += ToolStripMenuItemCopyToClipboardMeanAnomaly_Click;
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardMeanAnomalyAtTheEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardArgumentOfPerihelion
			// 
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardArgumentOfPerihelion.AutoToolTip = true;
			this.menuitemCopyToClipboardArgumentOfPerihelion.Image = (Image)resources.GetObject("menuitemCopyToClipboardArgumentOfPerihelion.Image");
			this.menuitemCopyToClipboardArgumentOfPerihelion.Name = "menuitemCopyToClipboardArgumentOfPerihelion";
			this.menuitemCopyToClipboardArgumentOfPerihelion.Size = new Size(308, 22);
			this.menuitemCopyToClipboardArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (°)";
			this.menuitemCopyToClipboardArgumentOfPerihelion.Click += ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click;
			this.menuitemCopyToClipboardArgumentOfPerihelion.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardArgumentOfPerihelion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardLongitudeOfTheAscendingNode
			// 
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.AutoToolTip = true;
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Image = (Image)resources.GetObject("menuitemCopyToClipboardLongitudeOfTheAscendingNode.Image");
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Name = "menuitemCopyToClipboardLongitudeOfTheAscendingNode";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Size = new Size(308, 22);
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0 (°)";
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.Click += ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click;
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardInclinationToTheEcliptic
			// 
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleDescription = "Copy to clipboard: Inclination";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleName = "Copy to clipboard: Inclination";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardInclinationToTheEcliptic.AutoToolTip = true;
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Image = (Image)resources.GetObject("menuitemCopyToClipboardInclinationToTheEcliptic.Image");
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Name = "menuitemCopyToClipboardInclinationToTheEcliptic";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Size = new Size(308, 22);
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Text = "Inclination to the ecliptic, J2000.0 (°)";
			this.menuitemCopyToClipboardInclinationToTheEcliptic.Click += ToolStripMenuItemCopyToClipboardInclinationToTheEcliptic_Click;
			this.menuitemCopyToClipboardInclinationToTheEcliptic.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardInclinationToTheEcliptic.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardOrbitalEccentricity
			// 
			this.menuitemCopyToClipboardOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardOrbitalEccentricity.AutoToolTip = true;
			this.menuitemCopyToClipboardOrbitalEccentricity.Image = (Image)resources.GetObject("menuitemCopyToClipboardOrbitalEccentricity.Image");
			this.menuitemCopyToClipboardOrbitalEccentricity.Name = "menuitemCopyToClipboardOrbitalEccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.Size = new Size(308, 22);
			this.menuitemCopyToClipboardOrbitalEccentricity.Text = "Orbital eccentricity";
			this.menuitemCopyToClipboardOrbitalEccentricity.Click += ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click;
			this.menuitemCopyToClipboardOrbitalEccentricity.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardOrbitalEccentricity.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardMeanDailyMotion
			// 
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion";
			this.menuitemCopyToClipboardMeanDailyMotion.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardMeanDailyMotion.AutoToolTip = true;
			this.menuitemCopyToClipboardMeanDailyMotion.Image = (Image)resources.GetObject("menuitemCopyToClipboardMeanDailyMotion.Image");
			this.menuitemCopyToClipboardMeanDailyMotion.Name = "menuitemCopyToClipboardMeanDailyMotion";
			this.menuitemCopyToClipboardMeanDailyMotion.Size = new Size(308, 22);
			this.menuitemCopyToClipboardMeanDailyMotion.Text = "Mean daily motion (°/day)";
			this.menuitemCopyToClipboardMeanDailyMotion.Click += ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click;
			this.menuitemCopyToClipboardMeanDailyMotion.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardMeanDailyMotion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardSemiMajorAxis
			// 
			this.menuitemCopyToClipboardSemiMajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis";
			this.menuitemCopyToClipboardSemiMajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis";
			this.menuitemCopyToClipboardSemiMajorAxis.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardSemiMajorAxis.AutoToolTip = true;
			this.menuitemCopyToClipboardSemiMajorAxis.Image = (Image)resources.GetObject("menuitemCopyToClipboardSemiMajorAxis.Image");
			this.menuitemCopyToClipboardSemiMajorAxis.Name = "menuitemCopyToClipboardSemiMajorAxis";
			this.menuitemCopyToClipboardSemiMajorAxis.Size = new Size(308, 22);
			this.menuitemCopyToClipboardSemiMajorAxis.Text = "Semi-major axis (AU)";
			this.menuitemCopyToClipboardSemiMajorAxis.Click += ToolStripMenuItemCopyToClipboardSemiMajorAxis_Click;
			this.menuitemCopyToClipboardSemiMajorAxis.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardSemiMajorAxis.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardAbsoluteMagnitude
			// 
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardAbsoluteMagnitude.AutoToolTip = true;
			this.menuitemCopyToClipboardAbsoluteMagnitude.Image = (Image)resources.GetObject("menuitemCopyToClipboardAbsoluteMagnitude.Image");
			this.menuitemCopyToClipboardAbsoluteMagnitude.Name = "menuitemCopyToClipboardAbsoluteMagnitude";
			this.menuitemCopyToClipboardAbsoluteMagnitude.Size = new Size(308, 22);
			this.menuitemCopyToClipboardAbsoluteMagnitude.Text = "Absolute magnitude, H";
			this.menuitemCopyToClipboardAbsoluteMagnitude.Click += ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click;
			this.menuitemCopyToClipboardAbsoluteMagnitude.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardAbsoluteMagnitude.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardSlopeParameter
			// 
			this.menuitemCopyToClipboardSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter";
			this.menuitemCopyToClipboardSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter";
			this.menuitemCopyToClipboardSlopeParameter.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardSlopeParameter.AutoToolTip = true;
			this.menuitemCopyToClipboardSlopeParameter.Image = (Image)resources.GetObject("menuitemCopyToClipboardSlopeParameter.Image");
			this.menuitemCopyToClipboardSlopeParameter.Name = "menuitemCopyToClipboardSlopeParameter";
			this.menuitemCopyToClipboardSlopeParameter.Size = new Size(308, 22);
			this.menuitemCopyToClipboardSlopeParameter.Text = "Slope parameter, G";
			this.menuitemCopyToClipboardSlopeParameter.Click += ToolStripMenuItemCopyToClipboardSlopeParameter_Click;
			this.menuitemCopyToClipboardSlopeParameter.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardSlopeParameter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardReference
			// 
			this.menuitemCopyToClipboardReference.AccessibleDescription = "Copy to clipboard: Reference";
			this.menuitemCopyToClipboardReference.AccessibleName = "Copy to clipboard: Reference";
			this.menuitemCopyToClipboardReference.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardReference.AutoToolTip = true;
			this.menuitemCopyToClipboardReference.Image = (Image)resources.GetObject("menuitemCopyToClipboardReference.Image");
			this.menuitemCopyToClipboardReference.Name = "menuitemCopyToClipboardReference";
			this.menuitemCopyToClipboardReference.Size = new Size(308, 22);
			this.menuitemCopyToClipboardReference.Text = "Reference";
			this.menuitemCopyToClipboardReference.Click += ToolStripMenuItemCopyToClipboardReference_Click;
			this.menuitemCopyToClipboardReference.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardReference.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardNumberOfOppositions
			// 
			this.menuitemCopyToClipboardNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			this.menuitemCopyToClipboardNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions ";
			this.menuitemCopyToClipboardNumberOfOppositions.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardNumberOfOppositions.AutoToolTip = true;
			this.menuitemCopyToClipboardNumberOfOppositions.Image = (Image)resources.GetObject("menuitemCopyToClipboardNumberOfOppositions.Image");
			this.menuitemCopyToClipboardNumberOfOppositions.Name = "menuitemCopyToClipboardNumberOfOppositions";
			this.menuitemCopyToClipboardNumberOfOppositions.Size = new Size(308, 22);
			this.menuitemCopyToClipboardNumberOfOppositions.Text = "Number of oppositions";
			this.menuitemCopyToClipboardNumberOfOppositions.Click += ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click;
			this.menuitemCopyToClipboardNumberOfOppositions.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardNumberOfOppositions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardNumberOfObservations
			// 
			this.menuitemCopyToClipboardNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			this.menuitemCopyToClipboardNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			this.menuitemCopyToClipboardNumberOfObservations.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardNumberOfObservations.AutoToolTip = true;
			this.menuitemCopyToClipboardNumberOfObservations.Image = (Image)resources.GetObject("menuitemCopyToClipboardNumberOfObservations.Image");
			this.menuitemCopyToClipboardNumberOfObservations.Name = "menuitemCopyToClipboardNumberOfObservations";
			this.menuitemCopyToClipboardNumberOfObservations.Size = new Size(308, 22);
			this.menuitemCopyToClipboardNumberOfObservations.Text = "Number of observations";
			this.menuitemCopyToClipboardNumberOfObservations.Click += ToolStripMenuItemCopyToClipboardNumberOfObservations_Click;
			this.menuitemCopyToClipboardNumberOfObservations.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardNumberOfObservations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardObservationSpan
			// 
			this.menuitemCopyToClipboardObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.menuitemCopyToClipboardObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.menuitemCopyToClipboardObservationSpan.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardObservationSpan.AutoToolTip = true;
			this.menuitemCopyToClipboardObservationSpan.Image = (Image)resources.GetObject("menuitemCopyToClipboardObservationSpan.Image");
			this.menuitemCopyToClipboardObservationSpan.Name = "menuitemCopyToClipboardObservationSpan";
			this.menuitemCopyToClipboardObservationSpan.Size = new Size(308, 22);
			this.menuitemCopyToClipboardObservationSpan.Text = "Observation span";
			this.menuitemCopyToClipboardObservationSpan.Click += ToolStripMenuItemCopyToClipboardObservationSpan_Click;
			this.menuitemCopyToClipboardObservationSpan.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardObservationSpan.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardRmsResidual
			// 
			this.menuitemCopyToClipboardRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual";
			this.menuitemCopyToClipboardRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual";
			this.menuitemCopyToClipboardRmsResidual.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardRmsResidual.AutoToolTip = true;
			this.menuitemCopyToClipboardRmsResidual.Image = (Image)resources.GetObject("menuitemCopyToClipboardRmsResidual.Image");
			this.menuitemCopyToClipboardRmsResidual.Name = "menuitemCopyToClipboardRmsResidual";
			this.menuitemCopyToClipboardRmsResidual.Size = new Size(308, 22);
			this.menuitemCopyToClipboardRmsResidual.Text = "r.m.s. residual (\")";
			this.menuitemCopyToClipboardRmsResidual.Click += ToolStripMenuItemCopyToClipboardRmsResidual_Click;
			this.menuitemCopyToClipboardRmsResidual.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardRmsResidual.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardComputerName
			// 
			this.menuitemCopyToClipboardComputerName.AccessibleDescription = "Copy to clipboard: Computer name";
			this.menuitemCopyToClipboardComputerName.AccessibleName = "Copy to clipboard: Computer name";
			this.menuitemCopyToClipboardComputerName.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardComputerName.AutoToolTip = true;
			this.menuitemCopyToClipboardComputerName.Image = (Image)resources.GetObject("menuitemCopyToClipboardComputerName.Image");
			this.menuitemCopyToClipboardComputerName.Name = "menuitemCopyToClipboardComputerName";
			this.menuitemCopyToClipboardComputerName.Size = new Size(308, 22);
			this.menuitemCopyToClipboardComputerName.Text = "Computer name";
			this.menuitemCopyToClipboardComputerName.Click += ToolStripMenuItemCopyToClipboardComputerName_Click;
			this.menuitemCopyToClipboardComputerName.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardComputerName.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardDateOfTheLastObservation
			// 
			this.menuitemCopyToClipboardDateOfTheLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.AccessibleName = "Copy to clipboard: Date of last observation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardDateOfTheLastObservation.AutoToolTip = true;
			this.menuitemCopyToClipboardDateOfTheLastObservation.Image = (Image)resources.GetObject("menuitemCopyToClipboardDateOfTheLastObservation.Image");
			this.menuitemCopyToClipboardDateOfTheLastObservation.Name = "menuitemCopyToClipboardDateOfTheLastObservation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.Size = new Size(308, 22);
			this.menuitemCopyToClipboardDateOfTheLastObservation.Text = "Date of last observation";
			this.menuitemCopyToClipboardDateOfTheLastObservation.Click += ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click;
			this.menuitemCopyToClipboardDateOfTheLastObservation.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardDateOfTheLastObservation.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopyToClipboardFlags
			// 
			this.menuitemCopyToClipboardFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopyToClipboardFlags.AutoToolTip = true;
			this.menuitemCopyToClipboardFlags.Image = (Image)resources.GetObject("menuitemCopyToClipboardFlags.Image");
			this.menuitemCopyToClipboardFlags.Name = "menuitemCopyToClipboardFlags";
			this.menuitemCopyToClipboardFlags.Size = new Size(308, 22);
			this.menuitemCopyToClipboardFlags.Text = "4-hexdigit flags";
			this.menuitemCopyToClipboardFlags.Click += MenuitemRecordsDateOfTheLastObservation_Click;
			this.menuitemCopyToClipboardFlags.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopyToClipboardFlags.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// splitbuttonCopyToClipboard
			// 
			this.splitbuttonCopyToClipboard.AccessibleDescription = "Copys to clipboard";
			this.splitbuttonCopyToClipboard.AccessibleName = "Copy to clipboard";
			this.splitbuttonCopyToClipboard.AccessibleRole = AccessibleRole.SplitButton;
			this.splitbuttonCopyToClipboard.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.splitbuttonCopyToClipboard.DropDown = this.contextMenuCopyToClipboardOrbitalElements;
			this.splitbuttonCopyToClipboard.Image = FatcowIcons16px.fatcow_page_copy_16px;
			this.splitbuttonCopyToClipboard.ImageTransparentColor = Color.Magenta;
			this.splitbuttonCopyToClipboard.Name = "splitbuttonCopyToClipboard";
			this.splitbuttonCopyToClipboard.Size = new Size(32, 22);
			this.splitbuttonCopyToClipboard.Text = "Copy to clipboard";
			this.splitbuttonCopyToClipboard.ButtonClick += this.ToolStripButtonCopyToClipboard_Click;
			this.splitbuttonCopyToClipboard.MouseEnter += this.SetStatusBar_Enter;
			this.splitbuttonCopyToClipboard.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menu
			// 
			this.menu.AccessibleDescription = "Shows the menubar";
			this.menu.AccessibleName = "menu";
			this.menu.AccessibleRole = AccessibleRole.MenuBar;
			this.menu.AllowItemReorder = true;
			this.menu.Dock = DockStyle.None;
			this.menu.Font = new Font("Segoe UI", 9F);
			this.menu.GripMargin = new Padding(0);
			this.menu.GripStyle = ToolStripGripStyle.Visible;
			this.menu.Items.AddRange(new ToolStripItem[] { this.menuitemFile, this.menuitemEdit, this.menuitemNavigation, this.menuitemTools, this.menuitemUpdate, this.menuitemOptions, this.menuitemHelp });
			this.menu.Location = new Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Padding = new Padding(2, 0, 0, 0);
			this.menu.ShowItemToolTips = true;
			this.menu.Size = new Size(852, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menu";
			this.toolTip.SetToolTip(this.menu, "Menu");
			this.menu.Enter += this.SetStatusBar_Enter;
			this.menu.Leave += this.ClearStatusBar_Leave;
			this.menu.MouseEnter += this.SetStatusBar_Enter;
			this.menu.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemFile
			// 
			this.menuitemFile.AccessibleDescription = "Opens the menu \"file\"";
			this.menuitemFile.AccessibleName = "File";
			this.menuitemFile.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemFile.AutoToolTip = true;
			this.menuitemFile.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemExportDataEntry, this.menuitemPrint, this.toolStripSeparatorFile1, this.menuitemRestart, this.menuitemExit });
			this.menuitemFile.Name = "menuitemFile";
			this.menuitemFile.ShortcutKeys = Keys.Alt | Keys.F;
			this.menuitemFile.Size = new Size(37, 24);
			this.menuitemFile.Text = "&File";
			this.menuitemFile.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemFile.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemExportDataEntry
			// 
			this.menuitemExportDataEntry.AccessibleDescription = "Exports data entry";
			this.menuitemExportDataEntry.AccessibleName = "Export";
			this.menuitemExportDataEntry.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemExportDataEntry.AutoToolTip = true;
			this.menuitemExportDataEntry.Image = FatcowIcons16px.fatcow_diskette_16px;
			this.menuitemExportDataEntry.Name = "menuitemExportDataEntry";
			this.menuitemExportDataEntry.Size = new Size(180, 22);
			this.menuitemExportDataEntry.Text = "&Export data entry";
			this.menuitemExportDataEntry.Click += ToolStripSplitButtonExport_Click;
			this.menuitemExportDataEntry.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemExportDataEntry.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemPrint
			// 
			this.menuitemPrint.AccessibleDescription = "Prints the information";
			this.menuitemPrint.AccessibleName = "Print";
			this.menuitemPrint.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemPrint.AutoToolTip = true;
			this.menuitemPrint.Image = FatcowIcons16px.fatcow_printer_16px;
			this.menuitemPrint.Name = "menuitemPrint";
			this.menuitemPrint.Size = new Size(180, 22);
			this.menuitemPrint.Text = "&Print data sheet";
			this.menuitemPrint.Click += ToolStripMenuItemPrint_Click;
			this.menuitemPrint.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemPrint.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparatorFile1
			// 
			this.toolStripSeparatorFile1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorFile1.AccessibleName = "Just a separator";
			this.toolStripSeparatorFile1.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			this.toolStripSeparatorFile1.Size = new Size(177, 6);
			this.toolStripSeparatorFile1.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparatorFile1.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRestart
			// 
			this.menuitemRestart.AccessibleDescription = "Restarts the application";
			this.menuitemRestart.AccessibleName = "Restart";
			this.menuitemRestart.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRestart.AutoToolTip = true;
			this.menuitemRestart.Image = FatcowIcons16px.fatcow_update_16px;
			this.menuitemRestart.Name = "menuitemRestart";
			this.menuitemRestart.ShortcutKeys = Keys.Alt | Keys.F3;
			this.menuitemRestart.Size = new Size(180, 22);
			this.menuitemRestart.Text = "&Restart";
			this.menuitemRestart.Click += ToolStripMenuItemRestart_Click;
			this.menuitemRestart.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRestart.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemExit
			// 
			this.menuitemExit.AccessibleDescription = "Exits the application";
			this.menuitemExit.AccessibleName = "Exit";
			this.menuitemExit.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemExit.AutoToolTip = true;
			this.menuitemExit.DoubleClickEnabled = true;
			this.menuitemExit.Image = FatcowIcons16px.fatcow_door_in_16px;
			this.menuitemExit.Name = "menuitemExit";
			this.menuitemExit.ShortcutKeys = Keys.Alt | Keys.F4;
			this.menuitemExit.Size = new Size(180, 22);
			this.menuitemExit.Text = "E&xit";
			this.menuitemExit.Click += MenuitemExit_Click;
			this.menuitemExit.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemExit.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemEdit
			// 
			this.menuitemEdit.AccessibleDescription = "Opens the menu \"edit\"";
			this.menuitemEdit.AccessibleName = "Edit";
			this.menuitemEdit.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemEdit.AutoToolTip = true;
			this.menuitemEdit.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemCopytoClipboard, this.menuitemSearch });
			this.menuitemEdit.Name = "menuitemEdit";
			this.menuitemEdit.ShortcutKeys = Keys.Alt | Keys.E;
			this.menuitemEdit.Size = new Size(39, 24);
			this.menuitemEdit.Text = "&Edit";
			this.menuitemEdit.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemEdit.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCopytoClipboard
			// 
			this.menuitemCopytoClipboard.AccessibleDescription = "Copy to clipboard";
			this.menuitemCopytoClipboard.AccessibleName = "Copy to clipboard";
			this.menuitemCopytoClipboard.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCopytoClipboard.AutoToolTip = true;
			this.menuitemCopytoClipboard.DoubleClickEnabled = true;
			this.menuitemCopytoClipboard.DropDown = this.contextMenuCopyToClipboardOrbitalElements;
			this.menuitemCopytoClipboard.Image = FatcowIcons16px.fatcow_page_white_copy_16px;
			this.menuitemCopytoClipboard.Name = "menuitemCopytoClipboard";
			this.menuitemCopytoClipboard.ShortcutKeys = Keys.Control | Keys.C;
			this.menuitemCopytoClipboard.Size = new Size(180, 22);
			this.menuitemCopytoClipboard.Text = "&Copy";
			this.menuitemCopytoClipboard.Click += ToolStripButtonCopyToClipboard_Click;
			this.menuitemCopytoClipboard.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCopytoClipboard.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemSearch
			// 
			this.menuitemSearch.AccessibleDescription = "Search";
			this.menuitemSearch.AccessibleName = "Search";
			this.menuitemSearch.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemSearch.AutoToolTip = true;
			this.menuitemSearch.DoubleClickEnabled = true;
			this.menuitemSearch.Enabled = false;
			this.menuitemSearch.Image = FatcowIcons16px.fatcow_zoom_16px;
			this.menuitemSearch.Name = "menuitemSearch";
			this.menuitemSearch.ShortcutKeys = Keys.Control | Keys.S;
			this.menuitemSearch.Size = new Size(180, 22);
			this.menuitemSearch.Text = "&Search";
			this.menuitemSearch.Click += ToolStripMenuItemSearch_Click;
			this.menuitemSearch.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemSearch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigation
			// 
			this.menuitemNavigation.AccessibleDescription = "Opens the menu \"navigation\"";
			this.menuitemNavigation.AccessibleName = "Navigation";
			this.menuitemNavigation.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemNavigation.AutoToolTip = true;
			this.menuitemNavigation.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemRandomMinorPlanet, this.toolStripSeparatorNavigation1, this.menuitemNavigateToTheBeginning, this.menuitemNavigateSomeDataBackward, this.menuitemNavigateToThePreviousData, this.menuitemNavigateToTheNextData, this.menuitemNavigateSomeDataForward, this.menuitemNavigateToTheEnd, this.toolStripSeparator11, this.menuitemListReadableDesignations });
			this.menuitemNavigation.Name = "menuitemNavigation";
			this.menuitemNavigation.Size = new Size(77, 24);
			this.menuitemNavigation.Text = "&Navigation";
			this.menuitemNavigation.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigation.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRandomMinorPlanet
			// 
			this.menuitemRandomMinorPlanet.AccessibleDescription = "Loads a random minor planet";
			this.menuitemRandomMinorPlanet.AccessibleName = "Random minor planet";
			this.menuitemRandomMinorPlanet.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRandomMinorPlanet.AutoToolTip = true;
			this.menuitemRandomMinorPlanet.DoubleClickEnabled = true;
			this.menuitemRandomMinorPlanet.Image = FatcowIcons16px.fatcow_arrow_refresh_16px;
			this.menuitemRandomMinorPlanet.Name = "menuitemRandomMinorPlanet";
			this.menuitemRandomMinorPlanet.ShortcutKeys = Keys.Control | Keys.R;
			this.menuitemRandomMinorPlanet.Size = new Size(275, 22);
			this.menuitemRandomMinorPlanet.Text = "&Random minor planet";
			this.menuitemRandomMinorPlanet.Click += ToolStripMenuItemRandomMinorPlanet_Click;
			this.menuitemRandomMinorPlanet.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRandomMinorPlanet.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparatorNavigation1
			// 
			this.toolStripSeparatorNavigation1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorNavigation1.AccessibleName = "Just a separator";
			this.toolStripSeparatorNavigation1.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparatorNavigation1.Name = "toolStripSeparatorNavigation1";
			this.toolStripSeparatorNavigation1.Size = new Size(272, 6);
			this.toolStripSeparatorNavigation1.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparatorNavigation1.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateToTheBeginning
			// 
			this.menuitemNavigateToTheBeginning.AccessibleDescription = "Navigates to the beginning of the data";
			this.menuitemNavigateToTheBeginning.AccessibleName = "Navigates to the beginning";
			this.menuitemNavigateToTheBeginning.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateToTheBeginning.AutoToolTip = true;
			this.menuitemNavigateToTheBeginning.DoubleClickEnabled = true;
			this.menuitemNavigateToTheBeginning.Image = FatcowIcons16px.fatcow_control_start_blue_16px;
			this.menuitemNavigateToTheBeginning.Name = "menuitemNavigateToTheBeginning";
			this.menuitemNavigateToTheBeginning.ShortcutKeys = Keys.Control | Keys.D1;
			this.menuitemNavigateToTheBeginning.Size = new Size(275, 22);
			this.menuitemNavigateToTheBeginning.Text = "Navigate to the &beginning";
			this.menuitemNavigateToTheBeginning.Click += ToolStripMenuItemNavigateToTheBegin_Click;
			this.menuitemNavigateToTheBeginning.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateToTheBeginning.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateToThePreviousData
			// 
			this.menuitemNavigateToThePreviousData.AccessibleDescription = "Navigates to the previous data";
			this.menuitemNavigateToThePreviousData.AccessibleName = "Navigates to the previous";
			this.menuitemNavigateToThePreviousData.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateToThePreviousData.AutoToolTip = true;
			this.menuitemNavigateToThePreviousData.DoubleClickEnabled = true;
			this.menuitemNavigateToThePreviousData.Image = FatcowIcons16px.fatcow_control_play_backward_blue_16px;
			this.menuitemNavigateToThePreviousData.Name = "menuitemNavigateToThePreviousData";
			this.menuitemNavigateToThePreviousData.ShortcutKeys = Keys.Control | Keys.D3;
			this.menuitemNavigateToThePreviousData.Size = new Size(275, 22);
			this.menuitemNavigateToThePreviousData.Text = "Navigate to the &previous";
			this.menuitemNavigateToThePreviousData.Click += ToolStripMenuItemNavigateToThePreviousData_Click;
			this.menuitemNavigateToThePreviousData.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateToThePreviousData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateToTheNextData
			// 
			this.menuitemNavigateToTheNextData.AccessibleDescription = "Navigates to the next data";
			this.menuitemNavigateToTheNextData.AccessibleName = "Navigates to the next";
			this.menuitemNavigateToTheNextData.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateToTheNextData.AutoToolTip = true;
			this.menuitemNavigateToTheNextData.DoubleClickEnabled = true;
			this.menuitemNavigateToTheNextData.Image = FatcowIcons16px.fatcow_control_play_blue_16px;
			this.menuitemNavigateToTheNextData.Name = "menuitemNavigateToTheNextData";
			this.menuitemNavigateToTheNextData.ShortcutKeys = Keys.Control | Keys.D4;
			this.menuitemNavigateToTheNextData.Size = new Size(275, 22);
			this.menuitemNavigateToTheNextData.Text = "Navigate to the &next";
			this.menuitemNavigateToTheNextData.Click += ToolStripMenuItemNavigateToTheNextData_Click;
			this.menuitemNavigateToTheNextData.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateToTheNextData.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemNavigateToTheEnd
			// 
			this.menuitemNavigateToTheEnd.AccessibleDescription = "Navigates to the end of the data";
			this.menuitemNavigateToTheEnd.AccessibleName = "Navigates to the end";
			this.menuitemNavigateToTheEnd.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemNavigateToTheEnd.AutoToolTip = true;
			this.menuitemNavigateToTheEnd.DoubleClickEnabled = true;
			this.menuitemNavigateToTheEnd.Image = FatcowIcons16px.fatcow_control_end_blue_16px;
			this.menuitemNavigateToTheEnd.Name = "menuitemNavigateToTheEnd";
			this.menuitemNavigateToTheEnd.ShortcutKeys = Keys.Control | Keys.D6;
			this.menuitemNavigateToTheEnd.Size = new Size(275, 22);
			this.menuitemNavigateToTheEnd.Text = "Navigate to the &end";
			this.menuitemNavigateToTheEnd.Click += ToolStripMenuItemNavigateToTheEnd_Click;
			this.menuitemNavigateToTheEnd.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemNavigateToTheEnd.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.AccessibleDescription = "Just a separator";
			this.toolStripSeparator11.AccessibleName = "Just a separator";
			this.toolStripSeparator11.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new Size(272, 6);
			this.toolStripSeparator11.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator11.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemListReadableDesignations
			// 
			this.menuitemListReadableDesignations.AccessibleDescription = "Click to show the list pf the readable designations";
			this.menuitemListReadableDesignations.AccessibleName = "List readable designations";
			this.menuitemListReadableDesignations.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemListReadableDesignations.AutoToolTip = true;
			this.menuitemListReadableDesignations.Image = FatcowIcons16px.fatcow_page_white_text_16px;
			this.menuitemListReadableDesignations.Name = "menuitemListReadableDesignations";
			this.menuitemListReadableDesignations.Size = new Size(275, 22);
			this.menuitemListReadableDesignations.Text = "&List readable designations";
			this.menuitemListReadableDesignations.Click += MenuitemListReadableDesignations_Click;
			this.menuitemListReadableDesignations.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemListReadableDesignations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemTools
			// 
			this.menuitemTools.AccessibleDescription = "Opens the menu \"tools\"";
			this.menuitemTools.AccessibleName = "Tools";
			this.menuitemTools.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemTools.AutoToolTip = true;
			this.menuitemTools.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemDerivatedOrbitElements, this.menuitemFilter, this.toolStripSeparatorTools1, this.menuitemRecords, this.toolStripSeparator10, this.menuitemDistribution, this.toolStripSeparatorTools2, this.menuitemDatabaseInformation, this.menuitemTableMode, this.menuitemTerminology });
			this.menuitemTools.Name = "menuitemTools";
			this.menuitemTools.Size = new Size(46, 24);
			this.menuitemTools.Text = "&Tools";
			this.menuitemTools.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemTools.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDerivatedOrbitElements
			// 
			this.menuitemDerivatedOrbitElements.AccessibleDescription = "Calculates derivated orbital elements";
			this.menuitemDerivatedOrbitElements.AccessibleName = "Derivated orbital elements";
			this.menuitemDerivatedOrbitElements.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDerivatedOrbitElements.AutoToolTip = true;
			this.menuitemDerivatedOrbitElements.Image = FatcowIcons16px.fatcow_page_white_text_16px;
			this.menuitemDerivatedOrbitElements.Name = "menuitemDerivatedOrbitElements";
			this.menuitemDerivatedOrbitElements.Size = new Size(227, 22);
			this.menuitemDerivatedOrbitElements.Text = "Derivated &orbital elements";
			this.menuitemDerivatedOrbitElements.Click += ToolStripMenuItemDerivativeOrbitElements_Click;
			this.menuitemDerivatedOrbitElements.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDerivatedOrbitElements.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemFilter
			// 
			this.menuitemFilter.AccessibleDescription = "Filters the orbital elements in some ranges";
			this.menuitemFilter.AccessibleName = "Filter";
			this.menuitemFilter.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemFilter.AutoToolTip = true;
			this.menuitemFilter.Enabled = false;
			this.menuitemFilter.Image = FatcowIcons16px.fatcow_arrow_divide_16px;
			this.menuitemFilter.Name = "menuitemFilter";
			this.menuitemFilter.Size = new Size(227, 22);
			this.menuitemFilter.Text = "&Filter";
			this.menuitemFilter.Click += ToolStripMenuItemFilter_Click;
			this.menuitemFilter.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemFilter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparatorTools1
			// 
			this.toolStripSeparatorTools1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorTools1.AccessibleName = "Just a separator";
			this.toolStripSeparatorTools1.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparatorTools1.Name = "toolStripSeparatorTools1";
			this.toolStripSeparatorTools1.Size = new Size(224, 6);
			this.toolStripSeparatorTools1.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparatorTools1.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemRecords
			// 
			this.menuitemRecords.AccessibleDescription = "Shows some topn ten records";
			this.menuitemRecords.AccessibleName = "Top ten records";
			this.menuitemRecords.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemRecords.AutoToolTip = true;
			this.menuitemRecords.DropDown = this.contextMenuTopTenRecords;
			this.menuitemRecords.Enabled = false;
			this.menuitemRecords.Image = FatcowIcons16px.fatcow_page_white_text_16px;
			this.menuitemRecords.Name = "menuitemRecords";
			this.menuitemRecords.ShortcutKeys = Keys.Control | Keys.T;
			this.menuitemRecords.Size = new Size(227, 22);
			this.menuitemRecords.Text = "Top ten &records";
			this.menuitemRecords.Click += MenuitemTopTenRecords_Click;
			this.menuitemRecords.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemRecords.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.AccessibleDescription = "Just a separator";
			this.toolStripSeparator10.AccessibleName = "Just a separator";
			this.toolStripSeparator10.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new Size(224, 6);
			// 
			// toolStripSeparatorTools2
			// 
			this.toolStripSeparatorTools2.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorTools2.AccessibleName = "Just a separator";
			this.toolStripSeparatorTools2.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparatorTools2.Name = "toolStripSeparatorTools2";
			this.toolStripSeparatorTools2.Size = new Size(224, 6);
			this.toolStripSeparatorTools2.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparatorTools2.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDatabaseInformation
			// 
			this.menuitemDatabaseInformation.AccessibleDescription = "Shows the information of the MPCORB.DAT databbase";
			this.menuitemDatabaseInformation.AccessibleName = "Database information";
			this.menuitemDatabaseInformation.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDatabaseInformation.AutoToolTip = true;
			this.menuitemDatabaseInformation.DoubleClickEnabled = true;
			this.menuitemDatabaseInformation.Image = FatcowIcons16px.fatcow_database_16px;
			this.menuitemDatabaseInformation.Name = "menuitemDatabaseInformation";
			this.menuitemDatabaseInformation.ShortcutKeys = Keys.Control | Keys.I;
			this.menuitemDatabaseInformation.Size = new Size(227, 22);
			this.menuitemDatabaseInformation.Text = "Database &information";
			this.menuitemDatabaseInformation.Click += ToolStripMenuItemDatabaseInformation_Click;
			this.menuitemDatabaseInformation.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDatabaseInformation.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemTableMode
			// 
			this.menuitemTableMode.AccessibleDescription = "Activates the table mode";
			this.menuitemTableMode.AccessibleName = "Table mode";
			this.menuitemTableMode.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemTableMode.AutoToolTip = true;
			this.menuitemTableMode.DoubleClickEnabled = true;
			this.menuitemTableMode.Image = FatcowIcons16px.fatcow_table_16px;
			this.menuitemTableMode.Name = "menuitemTableMode";
			this.menuitemTableMode.ShortcutKeys = Keys.Control | Keys.M;
			this.menuitemTableMode.Size = new Size(227, 22);
			this.menuitemTableMode.Text = "&Table mode";
			this.menuitemTableMode.Click += ToolStripMenuItemTableMode_Click;
			this.menuitemTableMode.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemTableMode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemTerminology
			// 
			this.menuitemTerminology.AccessibleDescription = "Shows the terminology";
			this.menuitemTerminology.AccessibleName = "Terminology";
			this.menuitemTerminology.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemTerminology.AutoToolTip = true;
			this.menuitemTerminology.DoubleClickEnabled = true;
			this.menuitemTerminology.Image = FatcowIcons16px.fatcow_text_list_bullets_16px;
			this.menuitemTerminology.Name = "menuitemTerminology";
			this.menuitemTerminology.ShortcutKeys = Keys.Control | Keys.L;
			this.menuitemTerminology.Size = new Size(227, 22);
			this.menuitemTerminology.Text = "Terminolog&y";
			this.menuitemTerminology.Click += ToolStripMenuItemTerminology_Click;
			this.menuitemTerminology.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemTerminology.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemUpdate
			// 
			this.menuitemUpdate.AccessibleDescription = "Opens the menu \"updates\"";
			this.menuitemUpdate.AccessibleName = "Update";
			this.menuitemUpdate.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemUpdate.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemCheckMpcorbDat, this.menuitemDownloadMpcorbDat, this.toolStripSeparator2, this.menuitemCheckAstorbDat, this.menuitemDownloadAstorbDat });
			this.menuitemUpdate.Name = "menuitemUpdate";
			this.menuitemUpdate.Size = new Size(57, 24);
			this.menuitemUpdate.Text = "&Update";
			this.menuitemUpdate.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemUpdate.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemCheckMpcorbDat
			// 
			this.menuitemCheckMpcorbDat.AccessibleDescription = "Checks for updates of the database MPCORB.DAT";
			this.menuitemCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			this.menuitemCheckMpcorbDat.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCheckMpcorbDat.AutoToolTip = true;
			this.menuitemCheckMpcorbDat.DoubleClickEnabled = true;
			this.menuitemCheckMpcorbDat.Image = FatcowIcons16px.fatcow_database_lightning_16px;
			this.menuitemCheckMpcorbDat.Name = "menuitemCheckMpcorbDat";
			this.menuitemCheckMpcorbDat.Size = new Size(204, 22);
			this.menuitemCheckMpcorbDat.Text = "&Check MPCORB.DAT";
			this.menuitemCheckMpcorbDat.Click += MenuitemCheckMpcorbDat_Click;
			this.menuitemCheckMpcorbDat.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCheckMpcorbDat.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDownloadMpcorbDat
			// 
			this.menuitemDownloadMpcorbDat.AccessibleDescription = "Downloads the database MPCORB.DAT";
			this.menuitemDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			this.menuitemDownloadMpcorbDat.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDownloadMpcorbDat.AutoToolTip = true;
			this.menuitemDownloadMpcorbDat.DoubleClickEnabled = true;
			this.menuitemDownloadMpcorbDat.Image = FatcowIcons16px.fatcow_package_16px;
			this.menuitemDownloadMpcorbDat.Name = "menuitemDownloadMpcorbDat";
			this.menuitemDownloadMpcorbDat.Size = new Size(204, 22);
			this.menuitemDownloadMpcorbDat.Text = "&Download MPCORB.DAT";
			this.menuitemDownloadMpcorbDat.Click += MenuitemDownloadMpcorbDat_Click;
			this.menuitemDownloadMpcorbDat.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDownloadMpcorbDat.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(201, 6);
			// 
			// menuitemCheckAstorbDat
			// 
			this.menuitemCheckAstorbDat.AccessibleDescription = "Checks for updates of the database ASTORB";
			this.menuitemCheckAstorbDat.AccessibleName = "Check ASTORB.DAT";
			this.menuitemCheckAstorbDat.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemCheckAstorbDat.AutoToolTip = true;
			this.menuitemCheckAstorbDat.DoubleClickEnabled = true;
			this.menuitemCheckAstorbDat.Image = FatcowIcons16px.fatcow_database_lightning_16px;
			this.menuitemCheckAstorbDat.Name = "menuitemCheckAstorbDat";
			this.menuitemCheckAstorbDat.Size = new Size(204, 22);
			this.menuitemCheckAstorbDat.Text = "Check ASTORB.DAT";
			this.menuitemCheckAstorbDat.Click += MenuitemCheckAstorbDat_Click;
			this.menuitemCheckAstorbDat.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemCheckAstorbDat.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemDownloadAstorbDat
			// 
			this.menuitemDownloadAstorbDat.AccessibleDescription = "Downloads the database ASTORB.DAT";
			this.menuitemDownloadAstorbDat.AccessibleName = "Download ASTORB.DAT";
			this.menuitemDownloadAstorbDat.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemDownloadAstorbDat.AutoToolTip = true;
			this.menuitemDownloadAstorbDat.DoubleClickEnabled = true;
			this.menuitemDownloadAstorbDat.Image = FatcowIcons16px.fatcow_package_16px;
			this.menuitemDownloadAstorbDat.Name = "menuitemDownloadAstorbDat";
			this.menuitemDownloadAstorbDat.Size = new Size(204, 22);
			this.menuitemDownloadAstorbDat.Text = "Download ASTORB.DAT";
			this.menuitemDownloadAstorbDat.Click += MenuitemDownloadAstorbDat_Click;
			this.menuitemDownloadAstorbDat.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemDownloadAstorbDat.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemOptions
			// 
			this.menuitemOptions.AccessibleDescription = "Opens the menu \"options\"";
			this.menuitemOptions.AccessibleName = "Options";
			this.menuitemOptions.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemOptions.AutoToolTip = true;
			this.menuitemOptions.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemSettings, this.menuitemStyle, this.toolStripSeparatorOptions, this.menuitemOptionStayOnTop, this.menuitemOptionEnabledCopyingByDoubleClicking, this.menuitemOptionEnableLinkingToTerminology });
			this.menuitemOptions.Name = "menuitemOptions";
			this.menuitemOptions.ShortcutKeys = Keys.Alt | Keys.O;
			this.menuitemOptions.Size = new Size(61, 24);
			this.menuitemOptions.Text = "&Options";
			this.menuitemOptions.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemOptions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemSettings
			// 
			this.menuitemSettings.AccessibleDescription = "Changes the settings";
			this.menuitemSettings.AccessibleName = "settings";
			this.menuitemSettings.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemSettings.AutoToolTip = true;
			this.menuitemSettings.Image = FatcowIcons16px.fatcow_wrench_16px;
			this.menuitemSettings.Name = "menuitemSettings";
			this.menuitemSettings.Size = new Size(264, 22);
			this.menuitemSettings.Text = "&Settings";
			this.menuitemSettings.Click += ToolStripMenuItemSettings_Click;
			this.menuitemSettings.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemSettings.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemStyle
			// 
			this.menuitemStyle.AccessibleDescription = "Changes the style";
			this.menuitemStyle.AccessibleName = "Look and Feel";
			this.menuitemStyle.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemStyle.AutoToolTip = true;
			this.menuitemStyle.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemIconsetFatcow, this.menuitemIconsetSilk, this.menuitemIconsetFugue });
			this.menuitemStyle.Image = FatcowIcons16px.fatcow_style_16px;
			this.menuitemStyle.Name = "menuitemStyle";
			this.menuitemStyle.ShortcutKeyDisplayString = "";
			this.menuitemStyle.Size = new Size(264, 22);
			this.menuitemStyle.Text = "&Look and Feel";
			this.menuitemStyle.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemStyle.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemIconsetFatcow
			// 
			this.menuitemIconsetFatcow.AccessibleDescription = "Changes the icon set to Fatcow icons";
			this.menuitemIconsetFatcow.AccessibleName = "Fatcow icons";
			this.menuitemIconsetFatcow.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemIconsetFatcow.AutoToolTip = true;
			this.menuitemIconsetFatcow.CheckOnClick = true;
			this.menuitemIconsetFatcow.Enabled = false;
			this.menuitemIconsetFatcow.Name = "menuitemIconsetFatcow";
			this.menuitemIconsetFatcow.Size = new Size(143, 22);
			this.menuitemIconsetFatcow.Text = "Fatcow icons";
			this.menuitemIconsetFatcow.Click += ToolStripMenuItemIconSetFatcow_Click;
			this.menuitemIconsetFatcow.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemIconsetFatcow.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemIconsetSilk
			// 
			this.menuitemIconsetSilk.AccessibleDescription = "Changes the icon set to Silk icons";
			this.menuitemIconsetSilk.AccessibleName = "Silk icons";
			this.menuitemIconsetSilk.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemIconsetSilk.AutoToolTip = true;
			this.menuitemIconsetSilk.Checked = true;
			this.menuitemIconsetSilk.CheckOnClick = true;
			this.menuitemIconsetSilk.CheckState = CheckState.Checked;
			this.menuitemIconsetSilk.Enabled = false;
			this.menuitemIconsetSilk.Name = "menuitemIconsetSilk";
			this.menuitemIconsetSilk.Size = new Size(143, 22);
			this.menuitemIconsetSilk.Text = "Silk icons";
			this.menuitemIconsetSilk.Click += ToolStripMenuItemIconSetSilk_Click;
			this.menuitemIconsetSilk.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemIconsetSilk.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemIconsetFugue
			// 
			this.menuitemIconsetFugue.AccessibleDescription = "Changes the icon set to Fugue icons";
			this.menuitemIconsetFugue.AccessibleName = "Fugue icons";
			this.menuitemIconsetFugue.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemIconsetFugue.AutoToolTip = true;
			this.menuitemIconsetFugue.CheckOnClick = true;
			this.menuitemIconsetFugue.Enabled = false;
			this.menuitemIconsetFugue.Name = "menuitemIconsetFugue";
			this.menuitemIconsetFugue.Size = new Size(143, 22);
			this.menuitemIconsetFugue.Text = "Fugue icons";
			this.menuitemIconsetFugue.Click += ToolStripMenuItemIconSetFugue_Click;
			this.menuitemIconsetFugue.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemIconsetFugue.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparatorOptions
			// 
			this.toolStripSeparatorOptions.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorOptions.AccessibleName = "Just a separator";
			this.toolStripSeparatorOptions.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparatorOptions.Name = "toolStripSeparatorOptions";
			this.toolStripSeparatorOptions.Size = new Size(261, 6);
			this.toolStripSeparatorOptions.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparatorOptions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemOptionStayOnTop
			// 
			this.menuitemOptionStayOnTop.AccessibleDescription = "Stays the application always on top";
			this.menuitemOptionStayOnTop.AccessibleName = "Stays always on top";
			this.menuitemOptionStayOnTop.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemOptionStayOnTop.AutoToolTip = true;
			this.menuitemOptionStayOnTop.CheckOnClick = true;
			this.menuitemOptionStayOnTop.Name = "menuitemOptionStayOnTop";
			this.menuitemOptionStayOnTop.Size = new Size(264, 22);
			this.menuitemOptionStayOnTop.Text = "Stay always on &top";
			this.menuitemOptionStayOnTop.Click += ToolStripMenuItemStayOnTop_Click;
			this.menuitemOptionStayOnTop.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemOptionStayOnTop.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemOptionEnabledCopyingByDoubleClicking
			// 
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleDescription = "Enableds copying data to the clipboard by double-clicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleName = "Enableds copying by double-clicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemOptionEnabledCopyingByDoubleClicking.AutoToolTip = true;
			this.menuitemOptionEnabledCopyingByDoubleClicking.Checked = true;
			this.menuitemOptionEnabledCopyingByDoubleClicking.CheckOnClick = true;
			this.menuitemOptionEnabledCopyingByDoubleClicking.CheckState = CheckState.Checked;
			this.menuitemOptionEnabledCopyingByDoubleClicking.Font = new Font("Segoe UI", 9F);
			this.menuitemOptionEnabledCopyingByDoubleClicking.Name = "menuitemOptionEnabledCopyingByDoubleClicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.Size = new Size(264, 22);
			this.menuitemOptionEnabledCopyingByDoubleClicking.Text = "Enabled &copying by double-clicking";
			this.menuitemOptionEnabledCopyingByDoubleClicking.Click += ToolStripMenuItemEnableCopyingByDoubleClicking_Click;
			this.menuitemOptionEnabledCopyingByDoubleClicking.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemOptionEnabledCopyingByDoubleClicking.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemOptionEnableLinkingToTerminology
			// 
			this.menuitemOptionEnableLinkingToTerminology.AccessibleDescription = "Enables linking to terminology";
			this.menuitemOptionEnableLinkingToTerminology.AccessibleName = "Enables linking to terminology";
			this.menuitemOptionEnableLinkingToTerminology.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemOptionEnableLinkingToTerminology.AutoToolTip = true;
			this.menuitemOptionEnableLinkingToTerminology.Checked = true;
			this.menuitemOptionEnableLinkingToTerminology.CheckOnClick = true;
			this.menuitemOptionEnableLinkingToTerminology.CheckState = CheckState.Checked;
			this.menuitemOptionEnableLinkingToTerminology.Enabled = false;
			this.menuitemOptionEnableLinkingToTerminology.Name = "menuitemOptionEnableLinkingToTerminology";
			this.menuitemOptionEnableLinkingToTerminology.Size = new Size(264, 22);
			this.menuitemOptionEnableLinkingToTerminology.Text = "Enable linking to terminolog&y";
			this.menuitemOptionEnableLinkingToTerminology.Click += ToolStripMenuItemEnableLinkingToTerminology_Click;
			this.menuitemOptionEnableLinkingToTerminology.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemOptionEnableLinkingToTerminology.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemHelp
			// 
			this.menuitemHelp.AccessibleDescription = "Opens the menu \"help\"";
			this.menuitemHelp.AccessibleName = "Help";
			this.menuitemHelp.AccessibleRole = AccessibleRole.MenuPopup;
			this.menuitemHelp.AutoToolTip = true;
			this.menuitemHelp.DoubleClickEnabled = true;
			this.menuitemHelp.DropDownItems.AddRange(new ToolStripItem[] { this.menuitemAbout, this.menuitemLicense, this.toolStripSeparatorMisc1, this.menuitemOpenWebsitePDB, this.menuitemOpenWebsiteMPC, this.menuitemOpenMPCORBWebsite });
			this.menuitemHelp.Name = "menuitemHelp";
			this.menuitemHelp.ShortcutKeys = Keys.Alt | Keys.H;
			this.menuitemHelp.Size = new Size(44, 24);
			this.menuitemHelp.Text = "&Help";
			this.menuitemHelp.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemHelp.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemAbout
			// 
			this.menuitemAbout.AccessibleDescription = "More information about the application";
			this.menuitemAbout.AccessibleName = "About";
			this.menuitemAbout.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemAbout.AutoToolTip = true;
			this.menuitemAbout.DoubleClickEnabled = true;
			this.menuitemAbout.Image = FatcowIcons16px.fatcow_information_16px;
			this.menuitemAbout.Name = "menuitemAbout";
			this.menuitemAbout.Size = new Size(236, 22);
			this.menuitemAbout.Text = "&About";
			this.menuitemAbout.ToolTipText = "More information about the application";
			this.menuitemAbout.Click += MenuitemAbout_Click;
			this.menuitemAbout.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemAbout.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemLicense
			// 
			this.menuitemLicense.AccessibleDescription = "License information about the application";
			this.menuitemLicense.AccessibleName = "License";
			this.menuitemLicense.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemLicense.AutoToolTip = true;
			this.menuitemLicense.DoubleClickEnabled = true;
			this.menuitemLicense.Image = FatcowIcons16px.fatcow_script_16px;
			this.menuitemLicense.Name = "menuitemLicense";
			this.menuitemLicense.Size = new Size(236, 22);
			this.menuitemLicense.Text = "License";
			this.menuitemLicense.Click += MenuitemLicense_Click;
			this.menuitemLicense.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemLicense.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparatorMisc1
			// 
			this.toolStripSeparatorMisc1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorMisc1.AccessibleName = "Just a separator";
			this.toolStripSeparatorMisc1.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparatorMisc1.Name = "toolStripSeparatorMisc1";
			this.toolStripSeparatorMisc1.Size = new Size(233, 6);
			this.toolStripSeparatorMisc1.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparatorMisc1.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemOpenWebsitePDB
			// 
			this.menuitemOpenWebsitePDB.AccessibleDescription = "Opens the Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.AccessibleName = "Opens Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemOpenWebsitePDB.AutoToolTip = true;
			this.menuitemOpenWebsitePDB.DoubleClickEnabled = true;
			this.menuitemOpenWebsitePDB.Image = FatcowIcons16px.fatcow_house_16px;
			this.menuitemOpenWebsitePDB.Name = "menuitemOpenWebsitePDB";
			this.menuitemOpenWebsitePDB.Size = new Size(236, 22);
			this.menuitemOpenWebsitePDB.Text = "Open Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.ToolTipText = "Opens the Planetoid-DB homepage";
			this.menuitemOpenWebsitePDB.Click += MenuitemOpenWebsitePDB_Click;
			this.menuitemOpenWebsitePDB.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemOpenWebsitePDB.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemOpenWebsiteMPC
			// 
			this.menuitemOpenWebsiteMPC.AccessibleDescription = "Opens the MPC homepage";
			this.menuitemOpenWebsiteMPC.AccessibleName = "Opens MPC homepage";
			this.menuitemOpenWebsiteMPC.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemOpenWebsiteMPC.AutoToolTip = true;
			this.menuitemOpenWebsiteMPC.DoubleClickEnabled = true;
			this.menuitemOpenWebsiteMPC.Image = FatcowIcons16px.fatcow_world_16px;
			this.menuitemOpenWebsiteMPC.Name = "menuitemOpenWebsiteMPC";
			this.menuitemOpenWebsiteMPC.Size = new Size(236, 22);
			this.menuitemOpenWebsiteMPC.Text = "Open MPC homepage";
			this.menuitemOpenWebsiteMPC.ToolTipText = "Opens the MPC homepage";
			this.menuitemOpenWebsiteMPC.Click += MenuitemOpenWebsiteMPC_Click;
			this.menuitemOpenWebsiteMPC.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemOpenWebsiteMPC.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// menuitemOpenMPCORBWebsite
			// 
			this.menuitemOpenMPCORBWebsite.AccessibleDescription = "Opens the MPCORB website";
			this.menuitemOpenMPCORBWebsite.AccessibleName = "Opens MPCORB homepage";
			this.menuitemOpenMPCORBWebsite.AccessibleRole = AccessibleRole.MenuItem;
			this.menuitemOpenMPCORBWebsite.AutoToolTip = true;
			this.menuitemOpenMPCORBWebsite.DoubleClickEnabled = true;
			this.menuitemOpenMPCORBWebsite.Image = FatcowIcons16px.fatcow_world_16px;
			this.menuitemOpenMPCORBWebsite.Name = "menuitemOpenMPCORBWebsite";
			this.menuitemOpenMPCORBWebsite.Size = new Size(236, 22);
			this.menuitemOpenMPCORBWebsite.Text = "Open MPCORB website";
			this.menuitemOpenMPCORBWebsite.ToolTipText = "Opens the MPCORB website";
			this.menuitemOpenMPCORBWebsite.Click += MenuitemOpenMPCORBWebsite_Click;
			this.menuitemOpenMPCORBWebsite.MouseEnter += this.SetStatusBar_Enter;
			this.menuitemOpenMPCORBWebsite.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Container";
			this.toolStripContainer.AccessibleName = "Container";
			this.toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.AccessibleDescription = "Lower part of the control panel";
			this.toolStripContainer.BottomToolStripPanel.AccessibleName = "Lower part of the control panel";
			this.toolStripContainer.BottomToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusBar);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.AccessibleDescription = "Group the controls";
			this.toolStripContainer.ContentPanel.AccessibleName = "Container Panel";
			this.toolStripContainer.ContentPanel.AccessibleRole = AccessibleRole.Pane;
			this.toolStripContainer.ContentPanel.AutoScroll = true;
			this.toolStripContainer.ContentPanel.BackColor = Color.Transparent;
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanelData);
			this.toolStripContainer.ContentPanel.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			this.toolStripContainer.ContentPanel.Size = new Size(852, 285);
			this.toolStripContainer.Dock = DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			this.toolStripContainer.LeftToolStripPanel.AccessibleDescription = "Left part of the container panel";
			this.toolStripContainer.LeftToolStripPanel.AccessibleName = "Left part of the container panel";
			this.toolStripContainer.LeftToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			this.toolStripContainer.Location = new Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			this.toolStripContainer.RightToolStripPanel.AccessibleDescription = "Right part of the container panel";
			this.toolStripContainer.RightToolStripPanel.AccessibleName = "Right part of the container panel";
			this.toolStripContainer.RightToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			this.toolStripContainer.Size = new Size(852, 381);
			this.toolStripContainer.TabIndex = 16;
			this.toolTip.SetToolTip(this.toolStripContainer, "container");
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.AccessibleDescription = "Upper part of the container panel";
			this.toolStripContainer.TopToolStripPanel.AccessibleName = "Upper part of the container panel";
			this.toolStripContainer.TopToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menu);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripIcons);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripNavigation);
			// 
			// statusBar
			// 
			this.statusBar.AccessibleDescription = "Shows some information";
			this.statusBar.AccessibleName = "Status bar of some information";
			this.statusBar.AccessibleRole = AccessibleRole.StatusBar;
			this.statusBar.Dock = DockStyle.None;
			this.statusBar.Font = new Font("Segoe UI", 9F);
			this.statusBar.GripStyle = ToolStripGripStyle.Visible;
			this.statusBar.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabelUpdate, this.toolStripStatusLabelBackgroundDownload, this.toolStripProgressBarBackgroundDownload, this.toolStripStatusLabelCancelBackgroundDownload, this.labelInformation });
			this.statusBar.LayoutStyle = ToolStripLayoutStyle.Flow;
			this.statusBar.Location = new Point(0, 0);
			this.statusBar.Name = "statusBar";
			this.statusBar.ProgressBars = null;
			this.statusBar.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			this.statusBar.ShowItemToolTips = true;
			this.statusBar.Size = new Size(852, 22);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 0;
			this.statusBar.TabStop = true;
			this.statusBar.Text = "statusStrip";
			// 
			// toolStripStatusLabelUpdate
			// 
			this.toolStripStatusLabelUpdate.AccessibleDescription = "Shows that an MPCORB.DAT update is aviable";
			this.toolStripStatusLabelUpdate.AccessibleName = "Update information";
			this.toolStripStatusLabelUpdate.AccessibleRole = AccessibleRole.StaticText;
			this.toolStripStatusLabelUpdate.AutoToolTip = true;
			this.toolStripStatusLabelUpdate.Image = FatcowIcons16px.fatcow_database_lightning_16px;
			this.toolStripStatusLabelUpdate.IsLink = true;
			this.toolStripStatusLabelUpdate.LinkBehavior = LinkBehavior.HoverUnderline;
			this.toolStripStatusLabelUpdate.LinkColor = SystemColors.ControlText;
			this.toolStripStatusLabelUpdate.Margin = new Padding(5, 3, 0, 2);
			this.toolStripStatusLabelUpdate.Name = "toolStripStatusLabelUpdate";
			this.toolStripStatusLabelUpdate.Size = new Size(185, 16);
			this.toolStripStatusLabelUpdate.Text = "MPCORB.DAT update available";
			this.toolStripStatusLabelUpdate.ToolTipText = "MPCORB.DAT update aviable";
			this.toolStripStatusLabelUpdate.Click += ToolStripStatusLabelUpdate_Click;
			this.toolStripStatusLabelUpdate.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripStatusLabelUpdate.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripStatusLabelBackgroundDownload
			// 
			this.toolStripStatusLabelBackgroundDownload.AccessibleDescription = "Shows the download progress";
			this.toolStripStatusLabelBackgroundDownload.AccessibleName = "Download progress";
			this.toolStripStatusLabelBackgroundDownload.AccessibleRole = AccessibleRole.StatusBar;
			this.toolStripStatusLabelBackgroundDownload.AutoToolTip = true;
			this.toolStripStatusLabelBackgroundDownload.Image = FatcowIcons16px.fatcow_package_go_16px;
			this.toolStripStatusLabelBackgroundDownload.Margin = new Padding(5, 3, 0, 2);
			this.toolStripStatusLabelBackgroundDownload.Name = "toolStripStatusLabelBackgroundDownload";
			this.toolStripStatusLabelBackgroundDownload.Size = new Size(80, 16);
			this.toolStripStatusLabelBackgroundDownload.Text = "Download:";
			this.toolStripStatusLabelBackgroundDownload.ToolTipText = "Show the download progress";
			this.toolStripStatusLabelBackgroundDownload.DoubleClick += this.EasterEgg_DoubleClick;
			this.toolStripStatusLabelBackgroundDownload.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripStatusLabelBackgroundDownload.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripProgressBarBackgroundDownload
			// 
			this.toolStripProgressBarBackgroundDownload.AccessibleDescription = "Shows the download progress";
			this.toolStripProgressBarBackgroundDownload.AccessibleName = "Download progress";
			this.toolStripProgressBarBackgroundDownload.AccessibleRole = AccessibleRole.ProgressBar;
			this.toolStripProgressBarBackgroundDownload.AutoToolTip = true;
			this.toolStripProgressBarBackgroundDownload.Enabled = false;
			this.toolStripProgressBarBackgroundDownload.Name = "toolStripProgressBarBackgroundDownload";
			this.toolStripProgressBarBackgroundDownload.Size = new Size(100, 16);
			this.toolStripProgressBarBackgroundDownload.Style = ProgressBarStyle.Continuous;
			this.toolStripProgressBarBackgroundDownload.ToolTipText = "Show the download progress";
			this.toolStripProgressBarBackgroundDownload.DoubleClick += this.EasterEgg_DoubleClick;
			this.toolStripProgressBarBackgroundDownload.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripProgressBarBackgroundDownload.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripStatusLabelCancelBackgroundDownload
			// 
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleDescription = "Cancels the background download";
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleName = "Cancel download";
			this.toolStripStatusLabelCancelBackgroundDownload.AccessibleRole = AccessibleRole.Graphic;
			this.toolStripStatusLabelCancelBackgroundDownload.AutoToolTip = true;
			this.toolStripStatusLabelCancelBackgroundDownload.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripStatusLabelCancelBackgroundDownload.Image = FatcowIcons16px.fatcow_cancel_16px;
			this.toolStripStatusLabelCancelBackgroundDownload.Name = "toolStripStatusLabelCancelBackgroundDownload";
			this.toolStripStatusLabelCancelBackgroundDownload.Size = new Size(16, 16);
			this.toolStripStatusLabelCancelBackgroundDownload.Text = "Cancel background download";
			this.toolStripStatusLabelCancelBackgroundDownload.Click += ToolStripStatusLabelCancelBackgroundDownload_Click;
			this.toolStripStatusLabelCancelBackgroundDownload.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripStatusLabelCancelBackgroundDownload.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Shows some information";
			this.labelInformation.AccessibleName = "Shows some information";
			this.labelInformation.AccessibleRole = AccessibleRole.StaticText;
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Image = FatcowIcons16px.fatcow_lightbulb_16px;
			this.labelInformation.Margin = new Padding(5, 3, 0, 2);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new Size(144, 16);
			this.labelInformation.Spring = true;
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Shows some information";
			// 
			// toolStripIcons
			// 
			this.toolStripIcons.AccessibleDescription = "Toolbar of main functions";
			this.toolStripIcons.AccessibleName = "Toolbar of main functions";
			this.toolStripIcons.AccessibleRole = AccessibleRole.ToolBar;
			this.toolStripIcons.Dock = DockStyle.None;
			this.toolStripIcons.Font = new Font("Segoe UI", 9F);
			this.toolStripIcons.Items.AddRange(new ToolStripItem[] { this.toolStripButtonExport, this.toolStripButtonPrint, this.splitbuttonCopyToClipboard, this.toolStripButtonSearch, this.toolStripSeparator4, this.toolStripButtonDatabaseInformation, this.toolStripButtonTableMode, this.toolStripButtonTerminology, this.toolStripSeparator3, this.splitbuttonTopTenRecords, this.splitbuttonDistribution, this.toolStripSeparator5, this.toolStripButtonCheckMpcorbDat, this.toolStripButtonDownloadMpcorbDat, this.toolStripSeparator1, this.toolStripButtonAbout, this.toolStripButtonLicense, this.toolStripButtonOpenWebsitePDB });
			this.toolStripIcons.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripIcons.Location = new Point(0, 24);
			this.toolStripIcons.Name = "toolStripIcons";
			this.toolStripIcons.Size = new Size(852, 25);
			this.toolStripIcons.Stretch = true;
			this.toolStripIcons.TabIndex = 1;
			this.toolStripIcons.TabStop = true;
			this.toolStripIcons.Text = "Toolbar of main functions";
			this.toolStripIcons.Enter += this.SetStatusBar_Enter;
			this.toolStripIcons.Leave += this.ClearStatusBar_Leave;
			this.toolStripIcons.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripIcons.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonExport
			// 
			this.toolStripButtonExport.AccessibleDescription = "Exports data entry";
			this.toolStripButtonExport.AccessibleName = "Export";
			this.toolStripButtonExport.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExport.Image = FatcowIcons16px.fatcow_page_save_16px;
			this.toolStripButtonExport.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonExport.Name = "toolStripButtonExport";
			this.toolStripButtonExport.Size = new Size(23, 22);
			this.toolStripButtonExport.Text = "Export";
			this.toolStripButtonExport.Click += ToolStripSplitButtonExport_Click;
			this.toolStripButtonExport.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonExport.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonPrint
			// 
			this.toolStripButtonPrint.AccessibleDescription = "Prints the information";
			this.toolStripButtonPrint.AccessibleName = "Print";
			this.toolStripButtonPrint.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = FatcowIcons16px.fatcow_printer_16px;
			this.toolStripButtonPrint.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new Size(23, 22);
			this.toolStripButtonPrint.Text = "Print";
			this.toolStripButtonPrint.Click += ToolStripButtonPrint_Click;
			this.toolStripButtonPrint.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonPrint.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonSearch
			// 
			this.toolStripButtonSearch.AccessibleDescription = "Search";
			this.toolStripButtonSearch.AccessibleName = "Search";
			this.toolStripButtonSearch.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSearch.Enabled = false;
			this.toolStripButtonSearch.Image = FatcowIcons16px.fatcow_magnifier_16px;
			this.toolStripButtonSearch.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonSearch.Name = "toolStripButtonSearch";
			this.toolStripButtonSearch.Size = new Size(23, 22);
			this.toolStripButtonSearch.Text = "Search";
			this.toolStripButtonSearch.Click += ToolStripMenuItemSearch_Click;
			this.toolStripButtonSearch.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonSearch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AccessibleDescription = "Just a separator";
			this.toolStripSeparator4.AccessibleName = "Just a separator";
			this.toolStripSeparator4.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(6, 25);
			this.toolStripSeparator4.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator4.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonDatabaseInformation
			// 
			this.toolStripButtonDatabaseInformation.AccessibleDescription = "Shows some information of the MPCORB.DAT database";
			this.toolStripButtonDatabaseInformation.AccessibleName = "Database Information";
			this.toolStripButtonDatabaseInformation.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonDatabaseInformation.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDatabaseInformation.Image = FatcowIcons16px.fatcow_database_16px;
			this.toolStripButtonDatabaseInformation.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonDatabaseInformation.Name = "toolStripButtonDatabaseInformation";
			this.toolStripButtonDatabaseInformation.Size = new Size(23, 22);
			this.toolStripButtonDatabaseInformation.Text = "Database information";
			this.toolStripButtonDatabaseInformation.Click += ToolStripButtonDatabaseInformation_Click;
			this.toolStripButtonDatabaseInformation.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonDatabaseInformation.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonTableMode
			// 
			this.toolStripButtonTableMode.AccessibleDescription = "Activates the table mode";
			this.toolStripButtonTableMode.AccessibleName = "Table mode";
			this.toolStripButtonTableMode.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonTableMode.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTableMode.Image = FatcowIcons16px.fatcow_table_16px;
			this.toolStripButtonTableMode.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonTableMode.Name = "toolStripButtonTableMode";
			this.toolStripButtonTableMode.Size = new Size(23, 22);
			this.toolStripButtonTableMode.Text = "Table mode";
			this.toolStripButtonTableMode.ToolTipText = "Activate the table mode";
			this.toolStripButtonTableMode.Click += ToolStripButtonTableMode_Click;
			this.toolStripButtonTableMode.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonTableMode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonTerminology
			// 
			this.toolStripButtonTerminology.AccessibleDescription = "Shows the terminology";
			this.toolStripButtonTerminology.AccessibleName = "Terminology";
			this.toolStripButtonTerminology.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonTerminology.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTerminology.Image = FatcowIcons16px.fatcow_text_list_bullets_16px;
			this.toolStripButtonTerminology.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonTerminology.Name = "toolStripButtonTerminology";
			this.toolStripButtonTerminology.Size = new Size(23, 22);
			this.toolStripButtonTerminology.Text = "Terminology";
			this.toolStripButtonTerminology.ToolTipText = "Show the terminology";
			this.toolStripButtonTerminology.Click += ToolStripButtonTerminology_Click;
			this.toolStripButtonTerminology.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonTerminology.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AccessibleDescription = "Just a separator";
			this.toolStripSeparator3.AccessibleName = "Just a separator";
			this.toolStripSeparator3.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(6, 25);
			this.toolStripSeparator3.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator3.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// splitbuttonDistribution
			// 
			this.splitbuttonDistribution.AccessibleDescription = "Shows some distributions";
			this.splitbuttonDistribution.AccessibleName = "Distributions";
			this.splitbuttonDistribution.AccessibleRole = AccessibleRole.SplitButton;
			this.splitbuttonDistribution.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.splitbuttonDistribution.DropDown = this.contextMenuDistributions;
			this.splitbuttonDistribution.Enabled = false;
			this.splitbuttonDistribution.Image = FatcowIcons16px.fatcow_chart_bar_16px;
			this.splitbuttonDistribution.ImageTransparentColor = Color.Magenta;
			this.splitbuttonDistribution.Name = "splitbuttonDistribution";
			this.splitbuttonDistribution.Size = new Size(32, 22);
			this.splitbuttonDistribution.Text = "Distributions";
			this.splitbuttonDistribution.ButtonClick += SplitButtonDistribution_ButtonClick;
			this.splitbuttonDistribution.MouseEnter += this.SetStatusBar_Enter;
			this.splitbuttonDistribution.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.AccessibleDescription = "Just a separator";
			this.toolStripSeparator5.AccessibleName = "Just a separator";
			this.toolStripSeparator5.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(6, 25);
			this.toolStripSeparator5.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator5.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonCheckMpcorbDat
			// 
			this.toolStripButtonCheckMpcorbDat.AccessibleDescription = "Checks for updates of the database MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonCheckMpcorbDat.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCheckMpcorbDat.Image = FatcowIcons16px.fatcow_database_lightning_16px;
			this.toolStripButtonCheckMpcorbDat.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonCheckMpcorbDat.Name = "toolStripButtonCheckMpcorbDat";
			this.toolStripButtonCheckMpcorbDat.Size = new Size(23, 22);
			this.toolStripButtonCheckMpcorbDat.Text = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.ToolTipText = "Check MPCORB.DAT";
			this.toolStripButtonCheckMpcorbDat.Click += ToolStripButtonCheckMpcorbDat_Click;
			this.toolStripButtonCheckMpcorbDat.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonCheckMpcorbDat.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonDownloadMpcorbDat
			// 
			this.toolStripButtonDownloadMpcorbDat.AccessibleDescription = "Downloads the database MPCORB.DAT";
			this.toolStripButtonDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			this.toolStripButtonDownloadMpcorbDat.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonDownloadMpcorbDat.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDownloadMpcorbDat.Image = FatcowIcons16px.fatcow_package_go_16px;
			this.toolStripButtonDownloadMpcorbDat.ImageTransparentColor = Color.Transparent;
			this.toolStripButtonDownloadMpcorbDat.Name = "toolStripButtonDownloadMpcorbDat";
			this.toolStripButtonDownloadMpcorbDat.Size = new Size(23, 22);
			this.toolStripButtonDownloadMpcorbDat.Text = "Download MPCORB.DAT";
			this.toolStripButtonDownloadMpcorbDat.ToolTipText = "Download the database";
			this.toolStripButtonDownloadMpcorbDat.Click += ToolStripButtonDownloadMpcorbDat_Click;
			this.toolStripButtonDownloadMpcorbDat.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonDownloadMpcorbDat.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AccessibleDescription = "Just a separator";
			this.toolStripSeparator1.AccessibleName = "Just a separator";
			this.toolStripSeparator1.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 25);
			this.toolStripSeparator1.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator1.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.AccessibleDescription = "More information about the application";
			this.toolStripButtonAbout.AccessibleName = "About";
			this.toolStripButtonAbout.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.Image = FatcowIcons16px.fatcow_information_16px;
			this.toolStripButtonAbout.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Size = new Size(23, 22);
			this.toolStripButtonAbout.Text = "About";
			this.toolStripButtonAbout.ToolTipText = "More information about the application";
			this.toolStripButtonAbout.Click += ToolStripButtonAbout_Click;
			this.toolStripButtonAbout.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonAbout.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonLicense
			// 
			this.toolStripButtonLicense.AccessibleDescription = "Opens the license information";
			this.toolStripButtonLicense.AccessibleName = "License";
			this.toolStripButtonLicense.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonLicense.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonLicense.Image = FatcowIcons16px.fatcow_script_16px;
			this.toolStripButtonLicense.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonLicense.Name = "toolStripButtonLicense";
			this.toolStripButtonLicense.Size = new Size(23, 22);
			this.toolStripButtonLicense.Text = "License";
			this.toolStripButtonLicense.Click += ToolStripButtonLicense_Click;
			this.toolStripButtonLicense.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonLicense.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonOpenWebsitePDB
			// 
			this.toolStripButtonOpenWebsitePDB.AccessibleDescription = "Opens the Planetoid-DB homepage";
			this.toolStripButtonOpenWebsitePDB.AccessibleName = "Open Planetoid-DB homepage";
			this.toolStripButtonOpenWebsitePDB.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonOpenWebsitePDB.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpenWebsitePDB.Image = FatcowIcons16px.fatcow_house_16px;
			this.toolStripButtonOpenWebsitePDB.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonOpenWebsitePDB.Name = "toolStripButtonOpenWebsitePDB";
			this.toolStripButtonOpenWebsitePDB.Size = new Size(23, 22);
			this.toolStripButtonOpenWebsitePDB.Text = "Open Planetoid-DB homepage";
			this.toolStripButtonOpenWebsitePDB.Click += ToolStripButtonOpenWebsitePDB_Click;
			this.toolStripButtonOpenWebsitePDB.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonOpenWebsitePDB.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripNavigation
			// 
			this.toolStripNavigation.AccessibleDescription = "Toolbar of the navigation";
			this.toolStripNavigation.AccessibleName = "Toolbar of the navigation";
			this.toolStripNavigation.AccessibleRole = AccessibleRole.ToolBar;
			this.toolStripNavigation.Dock = DockStyle.None;
			this.toolStripNavigation.Font = new Font("Segoe UI", 9F);
			this.toolStripNavigation.Items.AddRange(new ToolStripItem[] { this.toolStripButtonLoadRandomMinorPlanet, this.toolStripSeparator8, this.toolStripButtonStepToBegin, this.toolStripSplitButtonStepBackward, this.toolStripButtonStepBackwardOne, this.toolStripButtonStepForwardOne, this.toolStripSplitButtonStepForward, this.toolStripButtonStepToEnd, this.toolStripSeparator6, this.toolStripLabelIndexPosition, this.toolStripSeparator7, this.toolStripLabelGoToIndex, this.toolStripTextBoxGotoIndex, this.toolStripButtonGoToIndex, this.toolStripButtonListReadableDesignations, this.toolStripSeparator9, this.toolStripButtonDerivatedOrbitElements, this.toolStripButtonFilter });
			this.toolStripNavigation.Location = new Point(0, 49);
			this.toolStripNavigation.Name = "toolStripNavigation";
			this.toolStripNavigation.Size = new Size(852, 25);
			this.toolStripNavigation.Stretch = true;
			this.toolStripNavigation.TabIndex = 2;
			this.toolStripNavigation.Text = "Navigation";
			this.toolStripNavigation.Enter += this.SetStatusBar_Enter;
			this.toolStripNavigation.Leave += this.ClearStatusBar_Leave;
			this.toolStripNavigation.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripNavigation.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonLoadRandomMinorPlanet
			// 
			this.toolStripButtonLoadRandomMinorPlanet.AccessibleDescription = "Loads a random minor planet";
			this.toolStripButtonLoadRandomMinorPlanet.AccessibleName = "Random minor planet";
			this.toolStripButtonLoadRandomMinorPlanet.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonLoadRandomMinorPlanet.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonLoadRandomMinorPlanet.Image = FatcowIcons16px.fatcow_arrow_refresh_16px;
			this.toolStripButtonLoadRandomMinorPlanet.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonLoadRandomMinorPlanet.Name = "toolStripButtonLoadRandomMinorPlanet";
			this.toolStripButtonLoadRandomMinorPlanet.Size = new Size(23, 22);
			this.toolStripButtonLoadRandomMinorPlanet.Text = "Random minor planet";
			this.toolStripButtonLoadRandomMinorPlanet.Click += ToolStripButtonLoadRandomMinorPlanet_Click;
			this.toolStripButtonLoadRandomMinorPlanet.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonLoadRandomMinorPlanet.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.AccessibleDescription = "Just a separator";
			this.toolStripSeparator8.AccessibleName = "Just a separator";
			this.toolStripSeparator8.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new Size(6, 25);
			this.toolStripSeparator8.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator8.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonStepToBegin
			// 
			this.toolStripButtonStepToBegin.AccessibleDescription = "Navigates to the begin of the data";
			this.toolStripButtonStepToBegin.AccessibleName = "Begin of the data";
			this.toolStripButtonStepToBegin.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonStepToBegin.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepToBegin.Image = FatcowIcons16px.fatcow_control_start_blue_16px;
			this.toolStripButtonStepToBegin.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonStepToBegin.Name = "toolStripButtonStepToBegin";
			this.toolStripButtonStepToBegin.Size = new Size(23, 22);
			this.toolStripButtonStepToBegin.Text = "Begin of the data";
			this.toolStripButtonStepToBegin.Click += ToolStripButtonStepToBegin_Click;
			this.toolStripButtonStepToBegin.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonStepToBegin.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonStepBackwardOne
			// 
			this.toolStripButtonStepBackwardOne.AccessibleDescription = "Navigates to the previous data";
			this.toolStripButtonStepBackwardOne.AccessibleName = "Navigate to the previous data";
			this.toolStripButtonStepBackwardOne.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonStepBackwardOne.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepBackwardOne.Image = FatcowIcons16px.fatcow_control_play_backward_blue_16px;
			this.toolStripButtonStepBackwardOne.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonStepBackwardOne.Name = "toolStripButtonStepBackwardOne";
			this.toolStripButtonStepBackwardOne.Size = new Size(23, 22);
			this.toolStripButtonStepBackwardOne.Text = "Navigate to the previous data";
			this.toolStripButtonStepBackwardOne.Click += ToolStripButtonStepBackwardOne_Click;
			this.toolStripButtonStepBackwardOne.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonStepBackwardOne.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonStepForwardOne
			// 
			this.toolStripButtonStepForwardOne.AccessibleDescription = "Navigates to the next data";
			this.toolStripButtonStepForwardOne.AccessibleName = "Navigate to the next data";
			this.toolStripButtonStepForwardOne.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonStepForwardOne.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepForwardOne.Image = FatcowIcons16px.fatcow_control_play_blue_16px;
			this.toolStripButtonStepForwardOne.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonStepForwardOne.Name = "toolStripButtonStepForwardOne";
			this.toolStripButtonStepForwardOne.Size = new Size(23, 22);
			this.toolStripButtonStepForwardOne.Text = "Navigate to the next data";
			this.toolStripButtonStepForwardOne.Click += ToolStripButtonStepForwardOne_Click;
			this.toolStripButtonStepForwardOne.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonStepForwardOne.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonStepToEnd
			// 
			this.toolStripButtonStepToEnd.AccessibleDescription = "Navigates to the end of the data";
			this.toolStripButtonStepToEnd.AccessibleName = "End of the data";
			this.toolStripButtonStepToEnd.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonStepToEnd.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStepToEnd.Image = FatcowIcons16px.fatcow_control_end_blue_16px;
			this.toolStripButtonStepToEnd.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonStepToEnd.Name = "toolStripButtonStepToEnd";
			this.toolStripButtonStepToEnd.Size = new Size(23, 22);
			this.toolStripButtonStepToEnd.Text = "End of the data";
			this.toolStripButtonStepToEnd.Click += ToolStripButtonStepToEnd_Click;
			this.toolStripButtonStepToEnd.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonStepToEnd.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.AccessibleDescription = "Just a separator";
			this.toolStripSeparator6.AccessibleName = "Just a separator";
			this.toolStripSeparator6.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new Size(6, 25);
			this.toolStripSeparator6.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator6.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripLabelIndexPosition
			// 
			this.toolStripLabelIndexPosition.AccessibleDescription = "Shows the current index position";
			this.toolStripLabelIndexPosition.AccessibleName = "Index info";
			this.toolStripLabelIndexPosition.AccessibleRole = AccessibleRole.StaticText;
			this.toolStripLabelIndexPosition.AutoToolTip = true;
			this.toolStripLabelIndexPosition.Name = "toolStripLabelIndexPosition";
			this.toolStripLabelIndexPosition.Size = new Size(125, 22);
			this.toolStripLabelIndexPosition.Text = "index: 123456 / 999999";
			this.toolStripLabelIndexPosition.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripLabelIndexPosition.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.AccessibleDescription = "Just a separator";
			this.toolStripSeparator7.AccessibleName = "Just a separator";
			this.toolStripSeparator7.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new Size(6, 25);
			this.toolStripSeparator7.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator7.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripLabelGoToIndex
			// 
			this.toolStripLabelGoToIndex.AccessibleDescription = "Go to index";
			this.toolStripLabelGoToIndex.AccessibleName = "Index";
			this.toolStripLabelGoToIndex.AccessibleRole = AccessibleRole.StaticText;
			this.toolStripLabelGoToIndex.AutoToolTip = true;
			this.toolStripLabelGoToIndex.Name = "toolStripLabelGoToIndex";
			this.toolStripLabelGoToIndex.Size = new Size(71, 22);
			this.toolStripLabelGoToIndex.Text = "Go to index:";
			this.toolStripLabelGoToIndex.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripLabelGoToIndex.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripTextBoxGotoIndex
			// 
			this.toolStripTextBoxGotoIndex.AcceptsReturn = true;
			this.toolStripTextBoxGotoIndex.AccessibleDescription = "Enter the index number of the planetoid";
			this.toolStripTextBoxGotoIndex.AccessibleName = "Index field";
			this.toolStripTextBoxGotoIndex.AccessibleRole = AccessibleRole.Text;
			this.toolStripTextBoxGotoIndex.AutoToolTip = true;
			this.toolStripTextBoxGotoIndex.Name = "toolStripTextBoxGotoIndex";
			this.toolStripTextBoxGotoIndex.Size = new Size(80, 25);
			this.toolStripTextBoxGotoIndex.TextBoxTextAlign = HorizontalAlignment.Center;
			this.toolStripTextBoxGotoIndex.Enter += this.SetStatusBar_Enter;
			this.toolStripTextBoxGotoIndex.Leave += this.ClearStatusBar_Leave;
			this.toolStripTextBoxGotoIndex.KeyPress += this.ToolStripTextBoxGotoIndex_KeyPress;
			this.toolStripTextBoxGotoIndex.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripTextBoxGotoIndex.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonGoToIndex
			// 
			this.toolStripButtonGoToIndex.AccessibleDescription = "Click to show the data of the planetoid";
			this.toolStripButtonGoToIndex.AccessibleName = "Go to index";
			this.toolStripButtonGoToIndex.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonGoToIndex.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonGoToIndex.Image = FatcowIcons16px.fatcow_bullet_go_16px;
			this.toolStripButtonGoToIndex.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonGoToIndex.Name = "toolStripButtonGoToIndex";
			this.toolStripButtonGoToIndex.Size = new Size(23, 22);
			this.toolStripButtonGoToIndex.Text = "Go to index";
			this.toolStripButtonGoToIndex.Click += ToolStripButtonGoToIndex_Click;
			this.toolStripButtonGoToIndex.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonGoToIndex.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonListReadableDesignations
			// 
			this.toolStripButtonListReadableDesignations.AccessibleDescription = "Click to show the list pf the readable designations";
			this.toolStripButtonListReadableDesignations.AccessibleName = "List readable designations";
			this.toolStripButtonListReadableDesignations.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonListReadableDesignations.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonListReadableDesignations.Image = FatcowIcons16px.fatcow_page_white_text_16px;
			this.toolStripButtonListReadableDesignations.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonListReadableDesignations.Name = "toolStripButtonListReadableDesignations";
			this.toolStripButtonListReadableDesignations.Size = new Size(23, 22);
			this.toolStripButtonListReadableDesignations.Text = "List readable designations";
			this.toolStripButtonListReadableDesignations.Click += ToolStripButtonListReadableDesignations_Click;
			this.toolStripButtonListReadableDesignations.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonListReadableDesignations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.AccessibleDescription = "Just a separator";
			this.toolStripSeparator9.AccessibleName = "Just a separator";
			this.toolStripSeparator9.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new Size(6, 25);
			this.toolStripSeparator9.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripSeparator9.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonDerivatedOrbitElements
			// 
			this.toolStripButtonDerivatedOrbitElements.AccessibleDescription = "Calculates derivated orbital elements";
			this.toolStripButtonDerivatedOrbitElements.AccessibleName = "Derivated orbit elements";
			this.toolStripButtonDerivatedOrbitElements.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonDerivatedOrbitElements.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDerivatedOrbitElements.Image = FatcowIcons16px.fatcow_arrow_branch_16px;
			this.toolStripButtonDerivatedOrbitElements.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonDerivatedOrbitElements.Name = "toolStripButtonDerivatedOrbitElements";
			this.toolStripButtonDerivatedOrbitElements.Size = new Size(23, 22);
			this.toolStripButtonDerivatedOrbitElements.Text = "Derivated orbit elements";
			this.toolStripButtonDerivatedOrbitElements.Click += ToolStripButtonDerivativeOrbitElements_Click;
			this.toolStripButtonDerivatedOrbitElements.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonDerivatedOrbitElements.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripButtonFilter
			// 
			this.toolStripButtonFilter.AccessibleDescription = "Filters the orbital elements in some ranges";
			this.toolStripButtonFilter.AccessibleName = "Filter";
			this.toolStripButtonFilter.AccessibleRole = AccessibleRole.PushButton;
			this.toolStripButtonFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFilter.Enabled = false;
			this.toolStripButtonFilter.Image = FatcowIcons16px.fatcow_arrow_divide_16px;
			this.toolStripButtonFilter.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonFilter.Name = "toolStripButtonFilter";
			this.toolStripButtonFilter.Size = new Size(23, 22);
			this.toolStripButtonFilter.Text = "Filter";
			this.toolStripButtonFilter.Click += ToolStripButtonFilter_Click;
			this.toolStripButtonFilter.MouseEnter += this.SetStatusBar_Enter;
			this.toolStripButtonFilter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// toolStripSeparatorOptions2
			// 
			this.toolStripSeparatorOptions2.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorOptions2.AccessibleName = "Just a separator";
			this.toolStripSeparatorOptions2.Name = "toolStripSeparatorOptions2";
			this.toolStripSeparatorOptions2.Size = new Size(6, 6);
			// 
			// toolStripSeparatorOptions1
			// 
			this.toolStripSeparatorOptions1.AccessibleDescription = "Just a separator";
			this.toolStripSeparatorOptions1.AccessibleName = "Just a separator";
			this.toolStripSeparatorOptions1.AccessibleRole = AccessibleRole.Separator;
			this.toolStripSeparatorOptions1.Name = "toolStripSeparatorOptions1";
			this.toolStripSeparatorOptions1.Size = new Size(6, 6);
			// 
			// backgroundWorkerLoadingDatabase
			// 
			this.backgroundWorkerLoadingDatabase.WorkerReportsProgress = true;
			this.backgroundWorkerLoadingDatabase.WorkerSupportsCancellation = true;
			this.backgroundWorkerLoadingDatabase.DoWork += this.BackgroundWorkerLoadingDatabase_DoWork;
			this.backgroundWorkerLoadingDatabase.ProgressChanged += BackgroundWorkerLoadingDatabase_ProgressChanged;
			this.backgroundWorkerLoadingDatabase.RunWorkerCompleted += this.BackgroundWorkerLoadingDatabase_RunWorkerCompleted;
			// 
			// timerBlinkForUpdateAvailable
			// 
			this.timerBlinkForUpdateAvailable.Interval = 500;
			this.timerBlinkForUpdateAvailable.Tick += this.TimerBlinkForUpdateAvailable_Tick;
			// 
			// timerCheckForNewMpcorbDatFile
			// 
			this.timerCheckForNewMpcorbDatFile.Enabled = true;
			this.timerCheckForNewMpcorbDatFile.Interval = 1440000;
			this.timerCheckForNewMpcorbDatFile.Tick += this.TimerCheckForNewMpcorbDatFile_Tick;
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "dat";
			this.openFileDialog.FileName = "mpcorb.dat";
			this.openFileDialog.Filter = "DAT files|*.dat|all files|*.*";
			this.openFileDialog.Title = "Open MPCORB.DAT";
			// 
			// kryptonManager
			// 
			this.kryptonManager.GlobalPaletteMode = PaletteMode.Global;
			// 
			// PlanetoidDbForm
			// 
			this.AccessibleDescription = "Viewer for the MPC Orbit (MPCORB) Database";
			this.AccessibleName = "Planetoid-DB";
			this.AccessibleRole = AccessibleRole.Window;
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.AutoValidate = AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new Size(852, 381);
			this.Controls.Add(this.toolStripContainer);
			this.Font = new Font("Segoe UI", 8.5F);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this.menu;
			this.MaximizeBox = false;
			this.Name = "PlanetoidDbForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Planetoid-DB";
			this.toolTip.SetToolTip(this, "Planetoid-DB");
			this.FormClosing += this.PlanetoidDBForm_FormClosing;
			this.Load += this.PlanetoidDBForm_Load;
			this.Shown += this.PlanetoidDBForm_Shown;
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
		private ToolTip toolTip;
    private KryptonStatusStrip statusBar;
    private ContextMenuStrip contextMenuNavigationStep;
    private ToolStripMenuItem menuitemNavigateStep10;
    private ToolStripMenuItem menuitemNavigateStep100;
    private ToolStripMenuItem menuitemNavigateStep1000;
    private ToolStripMenuItem menuitemNavigateStep10000;
    private ToolStripMenuItem menuitemNavigateStep100000;
    private MenuStrip menu;
    private ToolStripMenuItem menuitemFile;
    private ToolStripMenuItem menuitemExit;
    private ToolStripMenuItem menuitemHelp;
    private ToolStripMenuItem menuitemAbout;
    private ToolStripSeparator toolStripSeparatorMisc1;
    private ToolStripMenuItem menuitemOpenWebsitePDB;
    private ToolStripMenuItem menuitemOpenWebsiteMPC;
    private ToolStripMenuItem menuitemOpenMPCORBWebsite;
    private ToolStripMenuItem menuitemOptions;
    private ToolStripProgressBar toolStripProgressBarBackgroundDownload;
    private ToolStripStatusLabel toolStripStatusLabelBackgroundDownload;
    private BackgroundWorker backgroundWorkerLoadingDatabase;
    private ToolStripStatusLabel labelInformation;
    private ToolStripStatusLabel toolStripStatusLabelUpdate;
    private Timer timerBlinkForUpdateAvailable;
    private ToolStrip toolStripIcons;
    private ToolStripButton toolStripButtonCheckMpcorbDat;
    private ToolStripButton toolStripButtonDownloadMpcorbDat;
    private ToolStripButton toolStripButtonAbout;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton toolStripButtonOpenWebsitePDB;
    private ToolStripButton toolStripButtonTableMode;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripButton toolStripButtonDatabaseInformation;
    private ToolStripSplitButton splitbuttonDistribution;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStrip toolStripNavigation;
    private ToolStripButton toolStripButtonStepToBegin;
    private ToolStripButton toolStripButtonStepBackwardOne;
    private ToolStripButton toolStripButtonStepForwardOne;
    private ToolStripButton toolStripButtonStepToEnd;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripLabel toolStripLabelIndexPosition;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripLabel toolStripLabelGoToIndex;
    private ToolStripTextBox toolStripTextBoxGotoIndex;
    private ToolStripButton toolStripButtonGoToIndex;
    private ToolStripButton toolStripButtonPrint;
    private ToolStripMenuItem menuitemEdit;
    private ToolStripMenuItem menuitemCopytoClipboard;
    private ToolStripMenuItem menuitemSearch;
    private ToolStripMenuItem menuitemPrint;
    private ToolStripMenuItem menuitemTableMode;
    private ToolStripSeparator toolStripSeparatorOptions1;
    private ToolStripMenuItem menuitemDistribution;
    private ToolStripSeparator toolStripSeparatorOptions2;
    private ToolStripContainer toolStripContainer;
    private ToolStripMenuItem menuitemStyle;
    private Timer timerCheckForNewMpcorbDatFile;
		private ToolStripStatusLabel toolStripStatusLabelCancelBackgroundDownload;
		private ToolStripMenuItem menuitemTerminology;
		private ToolStripButton toolStripButtonTerminology;
		private ToolStripSplitButton toolStripSplitButtonStepBackward;
		private ToolStripSplitButton toolStripSplitButtonStepForward;
		private ToolStripButton toolStripButtonLoadRandomMinorPlanet;
		private ToolStripSeparator toolStripSeparator8;
		private ToolStripMenuItem menuitemNavigation;
		private ToolStripMenuItem menuitemRandomMinorPlanet;
		private ToolStripSeparator toolStripSeparatorNavigation1;
		private ToolStripMenuItem menuitemNavigateToTheBeginning;
		private ToolStripMenuItem menuitemNavigateSomeDataBackward;
		private ToolStripMenuItem menuitemNavigateToThePreviousData;
		private ToolStripMenuItem menuitemNavigateToTheNextData;
		private ToolStripMenuItem menuitemNavigateSomeDataForward;
		private ToolStripMenuItem menuitemNavigateToTheEnd;
		private ToolStripMenuItem menuitemTools;
		private ToolStripMenuItem menuitemDatabaseInformation;
		private ToolStripSeparator toolStripSeparatorTools1;
		private ToolStripMenuItem menuitemSettings;
		private ToolStripSeparator toolStripSeparatorOptions;
		private ToolStripSeparator toolStripSeparatorFile1;
		private ToolStripMenuItem menuitemRestart;
		private ToolStripMenuItem menuitemDerivatedOrbitElements;
		private ToolStripSeparator toolStripSeparatorTools2;
		private ToolStripSeparator toolStripSeparator9;
		private ToolStripButton toolStripButtonDerivatedOrbitElements;
        private ToolStripMenuItem menuitemExportDataEntry;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem menuitemRecords;
        private ToolStripMenuItem menuitemIconsetSilk;
        private ToolStripMenuItem menuitemIconsetFatcow;
        private ToolStripMenuItem menuitemIconsetFugue;
        private ToolStripSplitButton splitbuttonTopTenRecords;
        private ToolStripMenuItem menuitemOptionStayOnTop;
        private ToolStripMenuItem menuitemOptionEnabledCopyingByDoubleClicking;
        private ToolStripMenuItem menuitemOptionEnableLinkingToTerminology;
        private ToolStripMenuItem menuitemUpdate;
        private ToolStripMenuItem menuitemCheckMpcorbDat;
        private ToolStripMenuItem menuitemDownloadMpcorbDat;
        private ToolStripMenuItem menuitemFilter;
        private KryptonTableLayoutPanel tableLayoutPanelData;
        private ToolStripSplitButton splitbuttonCopyToClipboard;
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
		private ContextMenuStrip contextMenuTopTenRecords;
		private ToolStripMenuItem menuitemRecordsSortDirection;
		private ToolStripMenuItem menuitemRecordsSortDirectionAscending;
		private ToolStripMenuItem menuitemRecordsSortDirectionDescending;
		private ToolStripSeparator toolStripSeparator12;
		private ToolStripMenuItem menuitemRecordsMeanAnomalyAtTheEpoch;
		private ToolStripMenuItem menuitemRecordsArgumentOfPerihelion;
		private ToolStripMenuItem menuitemRecordsLongitudeOfTheAscendingNode;
		private ToolStripMenuItem menuitemRecordsInclination;
		private ToolStripMenuItem menuitemRecordsOrbitalEccentricity;
		private ToolStripMenuItem menuitemRecordsMeanDailyMotion;
		private ToolStripMenuItem menuitemRecordsSemiMajorAxis;
		private ToolStripMenuItem menuitemRecordsAbsoluteMagnitude;
		private ToolStripMenuItem menuitemRecordsSlopeParameter;
		private ToolStripMenuItem menuitemRecordsNumberOfOppositions;
		private ToolStripMenuItem menuitemRecordsNumberOfObservations;
		private ToolStripMenuItem menuitemRecordsObservationSpan;
		private ToolStripMenuItem menuitemRecordsRmsResidual;
		private ToolStripMenuItem menuitemRecordsComputername;
		private ToolStripMenuItem menuitemRecordsDateOfTheLastObservation;
		private ContextMenuStrip contextMenuDistributions;
		private ToolStripMenuItem menuitemDistributionMeanAnomalyAtTheEpoch;
		private ToolStripMenuItem menuitemDistributionArgumentOfPerihelion;
		private ToolStripMenuItem menuitemDistributionLongitudeOfTheAscendingNode;
		private ToolStripMenuItem menuitemDistributionInclination;
		private ToolStripMenuItem menuitemDistributionOrbitalEccentricity;
		private ToolStripMenuItem menuitemDistributionMeanDailyMotion;
		private ToolStripMenuItem menuitemDistributionSemiMajorAxis;
		private ToolStripMenuItem menuitemDistributionAbsoluteMagnitude;
		private ToolStripMenuItem menuitemDistributionSlopeParameter;
		private ToolStripMenuItem menuitemDistributionNumberOfOppositions;
		private ToolStripMenuItem menuitemDistributionNumberOfObservations;
		private ToolStripMenuItem menuitemDistributionObservationSpan;
		private ToolStripMenuItem menuitemDistributionRmsResidual;
		private ToolStripMenuItem menuitemDistributionComputerName;
		private ToolStripButton toolStripButtonExport;
		private ToolStripButton toolStripButtonFilter;
		private ContextMenuStrip contextMenuCopyToClipboardOrbitalElements;
		private ToolStripMenuItem menuitemCopyToClipboardIndexNumber;
		private ToolStripMenuItem menuitemCopyToClipboardReadableDesignation;
		private ToolStripMenuItem menuitemCopyToClipboardEpoch;
		private ToolStripMenuItem menuitemCopyToClipboardMeanAnomalyAtTheEpoch;
		private ToolStripMenuItem menuitemCopyToClipboardArgumentOfPerihelion;
		private ToolStripMenuItem menuitemCopyToClipboardLongitudeOfTheAscendingNode;
		private ToolStripMenuItem menuitemCopyToClipboardInclinationToTheEcliptic;
		private ToolStripMenuItem menuitemCopyToClipboardOrbitalEccentricity;
		private ToolStripMenuItem menuitemCopyToClipboardMeanDailyMotion;
		private ToolStripMenuItem menuitemCopyToClipboardSemiMajorAxis;
		private ToolStripMenuItem menuitemCopyToClipboardAbsoluteMagnitude;
		private ToolStripMenuItem menuitemCopyToClipboardSlopeParameter;
		private ToolStripMenuItem menuitemCopyToClipboardReference;
		private ToolStripMenuItem menuitemCopyToClipboardNumberOfOppositions;
		private ToolStripMenuItem menuitemCopyToClipboardNumberOfObservations;
		private ToolStripMenuItem menuitemCopyToClipboardObservationSpan;
		private ToolStripMenuItem menuitemCopyToClipboardRmsResidual;
		private ToolStripMenuItem menuitemCopyToClipboardComputerName;
		private ToolStripMenuItem menuitemCopyToClipboardDateOfTheLastObservation;
		private ToolStripMenuItem menuitemCopyToClipboardFlags;
		private ToolStripButton toolStripButtonListReadableDesignations;
		private ToolStripSeparator toolStripSeparator11;
		private ToolStripMenuItem menuitemListReadableDesignations;
		private ToolStripButton toolStripButtonSearch;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem menuitemCheckAstorbDat;
		private ToolStripMenuItem menuitemDownloadAstorbDat;
		private ToolStripMenuItem menuitemLicense;
		private ToolStripButton toolStripButtonLicense;
		private OpenFileDialog openFileDialog;
		private KryptonManager kryptonManager;
	}
}

