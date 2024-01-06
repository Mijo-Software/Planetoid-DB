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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetoidDBForm));
			contextMenuNavigationStep = new ContextMenuStrip(components);
			menuitemNavigateStep10 = new ToolStripMenuItem();
			menuitemNavigateStep100 = new ToolStripMenuItem();
			menuitemNavigateStep1000 = new ToolStripMenuItem();
			menuitemNavigateStep10000 = new ToolStripMenuItem();
			menuitemNavigateStep100000 = new ToolStripMenuItem();
			menuitemNavigateSomeDataForward = new ToolStripMenuItem();
			toolStripSplitButtonStepForward = new ToolStripSplitButton();
			toolStripSplitButtonStepBackward = new ToolStripSplitButton();
			menuitemNavigateSomeDataBackward = new ToolStripMenuItem();
			tableLayoutPanelData = new KryptonTableLayoutPanel();
			labelIndexData = new KryptonLabel();
			labelReadableDesignationData = new KryptonLabel();
			labelEpochData = new KryptonLabel();
			labelMeanAnomalyAtTheEpochData = new KryptonLabel();
			labelArgumentOfPerihelionData = new KryptonLabel();
			labelLongitudeOfTheAscendingNodeData = new KryptonLabel();
			labelInclinationToTheEclipticData = new KryptonLabel();
			labelOrbitalEccentricityData = new KryptonLabel();
			labelMeanDailyMotionData = new KryptonLabel();
			labelSemiMajorAxisData = new KryptonLabel();
			labelAbsoluteMagnitudeData = new KryptonLabel();
			labelSlopeParameterData = new KryptonLabel();
			labelReferenceData = new KryptonLabel();
			labelNumberOfOppositionsData = new KryptonLabel();
			labelNumberOfObservationsData = new KryptonLabel();
			labelObservationSpanData = new KryptonLabel();
			labelRmsResidualData = new KryptonLabel();
			labelComputerNameData = new KryptonLabel();
			labelFlagsData = new KryptonLabel();
			labelDateLastObservationData = new KryptonLabel();
			labelIndexDesc = new KryptonLabel();
			labelReadableDesignationDesc = new KryptonLabel();
			labelEpochDesc = new KryptonLabel();
			labelMeanAnomalyAtTheEpochDesc = new KryptonLabel();
			labelArgumentOfPerihelionDesc = new KryptonLabel();
			labelLongitudeOfTheAscendingNodeDesc = new KryptonLabel();
			labelInclinationToTheEclipticDesc = new KryptonLabel();
			labelOrbitalEccentricityDesc = new KryptonLabel();
			labelMeanDailyMotionDesc = new KryptonLabel();
			labelSemiMajorAxisDesc = new KryptonLabel();
			labelAbsoluteMagnitudeDesc = new KryptonLabel();
			labelSlopeParameterDesc = new KryptonLabel();
			labelReferenceDesc = new KryptonLabel();
			labelNumberOfOppositionsDesc = new KryptonLabel();
			labelNumberOfObservationsDesc = new KryptonLabel();
			labelObservationSpanDesc = new KryptonLabel();
			labelRmsResidualDesc = new KryptonLabel();
			labelComputerNameDesc = new KryptonLabel();
			labelFlagsDesc = new KryptonLabel();
			labelDateLastObservationDesc = new KryptonLabel();
			toolTip = new ToolTip(components);
			contextMenuTopTenRecords = new ContextMenuStrip(components);
			menuitemRecordsSortDirection = new ToolStripMenuItem();
			menuitemRecordsSortDirectionAscending = new ToolStripMenuItem();
			menuitemRecordsSortDirectionDescending = new ToolStripMenuItem();
			toolStripSeparator12 = new ToolStripSeparator();
			menuitemRecordsMeanAnomalyAtTheEpoch = new ToolStripMenuItem();
			menuitemRecordsArgumentOfPerihelion = new ToolStripMenuItem();
			menuitemRecordsLongitudeOfTheAscendingNode = new ToolStripMenuItem();
			menuitemRecordsInclination = new ToolStripMenuItem();
			menuitemRecordsOrbitalEccentricity = new ToolStripMenuItem();
			menuitemRecordsMeanDailyMotion = new ToolStripMenuItem();
			menuitemRecordsSemiMajorAxis = new ToolStripMenuItem();
			menuitemRecordsAbsoluteMagnitude = new ToolStripMenuItem();
			menuitemRecordsSlopeParameter = new ToolStripMenuItem();
			menuitemRecordsNumberOfOppositions = new ToolStripMenuItem();
			menuitemRecordsNumberOfObservations = new ToolStripMenuItem();
			menuitemRecordsObservationSpan = new ToolStripMenuItem();
			menuitemRecordsRmsResidual = new ToolStripMenuItem();
			menuitemRecordsComputername = new ToolStripMenuItem();
			menuitemRecordsDateOfTheLastObservation = new ToolStripMenuItem();
			menuitemRecords = new ToolStripMenuItem();
			contextMenuDistributions = new ContextMenuStrip(components);
			menuitemDistributionMeanAnomalyAtTheEpoch = new ToolStripMenuItem();
			menuitemDistributionArgumentOfPerihelion = new ToolStripMenuItem();
			menuitemDistributionLongitudeOfTheAscendingNode = new ToolStripMenuItem();
			menuitemDistributionInclination = new ToolStripMenuItem();
			menuitemDistributionOrbitalEccentricity = new ToolStripMenuItem();
			menuitemDistributionMeanDailyMotion = new ToolStripMenuItem();
			menuitemDistributionSemiMajorAxis = new ToolStripMenuItem();
			menuitemDistributionAbsoluteMagnitude = new ToolStripMenuItem();
			menuitemDistributionSlopeParameter = new ToolStripMenuItem();
			menuitemDistributionNumberOfOppositions = new ToolStripMenuItem();
			menuitemDistributionNumberOfObservations = new ToolStripMenuItem();
			menuitemDistributionObservationSpan = new ToolStripMenuItem();
			menuitemDistributionRmsResidual = new ToolStripMenuItem();
			menuitemDistributionComputerName = new ToolStripMenuItem();
			menuitemDistribution = new ToolStripMenuItem();
			contextMenuCopyToClipboardOrbitalElements = new ContextMenuStrip(components);
			menuitemCopyToClipboardIndexNumber = new ToolStripMenuItem();
			menuitemCopyToClipboardReadableDesignation = new ToolStripMenuItem();
			menuitemCopyToClipboardEpoch = new ToolStripMenuItem();
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch = new ToolStripMenuItem();
			menuitemCopyToClipboardArgumentOfPerihelion = new ToolStripMenuItem();
			menuitemCopyToClipboardLongitudeOfTheAscendingNode = new ToolStripMenuItem();
			menuitemCopyToClipboardInclinationToTheEcliptic = new ToolStripMenuItem();
			menuitemCopyToClipboardOrbitalEccentricity = new ToolStripMenuItem();
			menuitemCopyToClipboardMeanDailyMotion = new ToolStripMenuItem();
			menuitemCopyToClipboardSemiMajorAxis = new ToolStripMenuItem();
			menuitemCopyToClipboardAbsoluteMagnitude = new ToolStripMenuItem();
			menuitemCopyToClipboardSlopeParameter = new ToolStripMenuItem();
			menuitemCopyToClipboardReference = new ToolStripMenuItem();
			menuitemCopyToClipboardNumberOfOppositions = new ToolStripMenuItem();
			menuitemCopyToClipboardNumberOfObservations = new ToolStripMenuItem();
			menuitemCopyToClipboardObservationSpan = new ToolStripMenuItem();
			menuitemCopyToClipboardRmsResidual = new ToolStripMenuItem();
			menuitemCopyToClipboardComputerName = new ToolStripMenuItem();
			menuitemCopyToClipboardDateOfTheLastObservation = new ToolStripMenuItem();
			menuitemCopyToClipboardFlags = new ToolStripMenuItem();
			menuitemCopytoClipboard = new ToolStripMenuItem();
			menu = new MenuStrip();
			menuitemFile = new ToolStripMenuItem();
			menuitemOpenALocalMpcorbdatFile = new ToolStripMenuItem();
			toolStripSeparator13 = new ToolStripSeparator();
			menuitemExportDataEntry = new ToolStripMenuItem();
			menuitemPrint = new ToolStripMenuItem();
			toolStripSeparatorFile1 = new ToolStripSeparator();
			menuitemRestart = new ToolStripMenuItem();
			menuitemRestartWithDemoData = new ToolStripMenuItem();
			menuitemExit = new ToolStripMenuItem();
			menuitemEdit = new ToolStripMenuItem();
			menuitemSearch = new ToolStripMenuItem();
			menuitemNavigation = new ToolStripMenuItem();
			menuitemRandomMinorPlanet = new ToolStripMenuItem();
			toolStripSeparatorNavigation1 = new ToolStripSeparator();
			menuitemNavigateToTheBeginning = new ToolStripMenuItem();
			menuitemNavigateToThePreviousData = new ToolStripMenuItem();
			menuitemNavigateToTheNextData = new ToolStripMenuItem();
			menuitemNavigateToTheEnd = new ToolStripMenuItem();
			toolStripSeparator11 = new ToolStripSeparator();
			menuitemListReadableDesignations = new ToolStripMenuItem();
			menuitemTools = new ToolStripMenuItem();
			menuitemDerivatedOrbitElements = new ToolStripMenuItem();
			menuitemFilter = new ToolStripMenuItem();
			toolStripSeparatorTools1 = new ToolStripSeparator();
			toolStripSeparator10 = new ToolStripSeparator();
			toolStripSeparatorTools2 = new ToolStripSeparator();
			menuitemDatabaseInformation = new ToolStripMenuItem();
			menuitemTableMode = new ToolStripMenuItem();
			menuitemTerminology = new ToolStripMenuItem();
			menuitemUpdate = new ToolStripMenuItem();
			menuitemCheckMpcorbDat = new ToolStripMenuItem();
			menuitemDownloadMpcorbDat = new ToolStripMenuItem();
			menuitemOptions = new ToolStripMenuItem();
			menuitemSettings = new ToolStripMenuItem();
			menuitemStyle = new ToolStripMenuItem();
			menuitemIconsetSilk = new ToolStripMenuItem();
			menuitemIconsetFugue = new ToolStripMenuItem();
			menuitemIconsetFatcow = new ToolStripMenuItem();
			toolStripSeparatorOptions = new ToolStripSeparator();
			menuitemOptionStayOnTop = new ToolStripMenuItem();
			menuitemOptionEnabledCopyingByDoubleClicking = new ToolStripMenuItem();
			menuitemOptionEnableLinkingToTerminology = new ToolStripMenuItem();
			menuitemHelp = new ToolStripMenuItem();
			menuitemAbout = new ToolStripMenuItem();
			toolStripSeparatorMisc1 = new ToolStripSeparator();
			menuitemOpenWebsitePDB = new ToolStripMenuItem();
			menuitemOpenWebsiteMPC = new ToolStripMenuItem();
			menuitemOpenMPCORBWebsite = new ToolStripMenuItem();
			toolStripContainer = new ToolStripContainer();
			statusBar = new KryptonStatusStrip();
			toolStripStatusLabelUpdate = new ToolStripStatusLabel();
			toolStripStatusLabelBackgroundDownload = new ToolStripStatusLabel();
			toolStripProgressBarBackgroundDownload = new ToolStripProgressBar();
			toolStripStatusLabelCancelBackgroundDownload = new ToolStripStatusLabel();
			labelInformation = new ToolStripStatusLabel();
			toolStripIcons = new ToolStrip();
			toolStripButtonOpen = new ToolStripButton();
			toolStripButtonExport = new ToolStripButton();
			toolStripButtonPrint = new ToolStripButton();
			splitbuttonCopyToClipboard = new ToolStripSplitButton();
			toolStripSeparator4 = new ToolStripSeparator();
			toolStripButtonDatabaseInformation = new ToolStripButton();
			toolStripButtonTableMode = new ToolStripButton();
			toolStripButtonTerminology = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			splitbuttonTopTenRecords = new ToolStripSplitButton();
			splitbuttonDistribution = new ToolStripSplitButton();
			toolStripSeparator5 = new ToolStripSeparator();
			toolStripButtonCheckMpcorbDat = new ToolStripButton();
			toolStripButtonDownloadMpcorbDat = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButtonAbout = new ToolStripButton();
			toolStripButtonOpenWebsitePDB = new ToolStripButton();
			toolStripButtonSearch = new ToolStripButton();
			toolStripNavigation = new ToolStrip();
			toolStripButtonLoadRandomMinorPlanet = new ToolStripButton();
			toolStripSeparator8 = new ToolStripSeparator();
			toolStripButtonStepToBegin = new ToolStripButton();
			toolStripButtonStepBackwardOne = new ToolStripButton();
			toolStripButtonStepForwardOne = new ToolStripButton();
			toolStripButtonStepToEnd = new ToolStripButton();
			toolStripSeparator6 = new ToolStripSeparator();
			toolStripLabelIndexPosition = new ToolStripLabel();
			toolStripSeparator7 = new ToolStripSeparator();
			toolStripLabelGoToIndex = new ToolStripLabel();
			toolStripTextBoxGotoIndex = new ToolStripTextBox();
			toolStripButtonGoToIndex = new ToolStripButton();
			toolStripButtonListReadableDesignations = new ToolStripButton();
			toolStripSeparator9 = new ToolStripSeparator();
			toolStripButtonDerivatedOrbitElements = new ToolStripButton();
			toolStripButtonFilter = new ToolStripButton();
			toolStripSeparatorOptions2 = new ToolStripSeparator();
			toolStripSeparatorOptions1 = new ToolStripSeparator();
			backgroundWorkerLoadingDatabase = new System.ComponentModel.BackgroundWorker();
			timerBlinkForUpdateAvailable = new System.Windows.Forms.Timer(components);
			timerCheckForNewMpcorbDatFile = new System.Windows.Forms.Timer(components);
			contextMenuNavigationStep.SuspendLayout();
			tableLayoutPanelData.SuspendLayout();
			contextMenuTopTenRecords.SuspendLayout();
			contextMenuDistributions.SuspendLayout();
			contextMenuCopyToClipboardOrbitalElements.SuspendLayout();
			menu.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.TopToolStripPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			statusBar.SuspendLayout();
			toolStripIcons.SuspendLayout();
			toolStripNavigation.SuspendLayout();
			SuspendLayout();
			// 
			// contextMenuNavigationStep
			// 
			contextMenuNavigationStep.AccessibleDescription = "Shows the context menu of data items";
			contextMenuNavigationStep.AccessibleName = "Context menu of items";
			contextMenuNavigationStep.AccessibleRole = AccessibleRole.MenuPopup;
			contextMenuNavigationStep.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			contextMenuNavigationStep.Items.AddRange(new ToolStripItem[] { menuitemNavigateStep10, menuitemNavigateStep100, menuitemNavigateStep1000, menuitemNavigateStep10000, menuitemNavigateStep100000 });
			contextMenuNavigationStep.Name = "contextMenu";
			contextMenuNavigationStep.OwnerItem = menuitemNavigateSomeDataBackward;
			contextMenuNavigationStep.ShowCheckMargin = true;
			contextMenuNavigationStep.ShowImageMargin = false;
			contextMenuNavigationStep.Size = new Size(111, 114);
			contextMenuNavigationStep.TabStop = true;
			contextMenuNavigationStep.Text = "Navigation step";
			toolTip.SetToolTip(contextMenuNavigationStep, "Show the context name of data items");
			contextMenuNavigationStep.MouseEnter += SetStatusbar_Enter;
			contextMenuNavigationStep.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateStep10
			// 
			menuitemNavigateStep10.AccessibleDescription = "Jumps 10 items backward/forward";
			menuitemNavigateStep10.AccessibleName = "Jumps 10 items backward/forward";
			menuitemNavigateStep10.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateStep10.CheckOnClick = true;
			menuitemNavigateStep10.Name = "menuitemNavigateStep10";
			menuitemNavigateStep10.Size = new Size(110, 22);
			menuitemNavigateStep10.Text = "10";
			menuitemNavigateStep10.ToolTipText = "Jump 10 items backward/forward";
			menuitemNavigateStep10.Click += ToolStripMenuItem10_Click;
			menuitemNavigateStep10.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateStep10.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateStep100
			// 
			menuitemNavigateStep100.AccessibleDescription = "Jumps 100 items backward/forward";
			menuitemNavigateStep100.AccessibleName = "Jumps 100 items backward/forward";
			menuitemNavigateStep100.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateStep100.Checked = true;
			menuitemNavigateStep100.CheckOnClick = true;
			menuitemNavigateStep100.CheckState = CheckState.Checked;
			menuitemNavigateStep100.Name = "menuitemNavigateStep100";
			menuitemNavigateStep100.Size = new Size(110, 22);
			menuitemNavigateStep100.Text = "100";
			menuitemNavigateStep100.ToolTipText = "Jump 100 items backward/forward";
			menuitemNavigateStep100.Click += ToolStripMenuItem100_Click;
			menuitemNavigateStep100.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateStep100.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateStep1000
			// 
			menuitemNavigateStep1000.AccessibleDescription = "Jumps 1000 items backward/forward";
			menuitemNavigateStep1000.AccessibleName = "Jumps 1000 items backward/forward";
			menuitemNavigateStep1000.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateStep1000.CheckOnClick = true;
			menuitemNavigateStep1000.Name = "menuitemNavigateStep1000";
			menuitemNavigateStep1000.Size = new Size(110, 22);
			menuitemNavigateStep1000.Text = "1000";
			menuitemNavigateStep1000.ToolTipText = "Jump 1000 items backward/forward";
			menuitemNavigateStep1000.Click += ToolStripMenuItem1000_Click;
			menuitemNavigateStep1000.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateStep1000.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateStep10000
			// 
			menuitemNavigateStep10000.AccessibleDescription = "Jumps 10000 items backward/forward";
			menuitemNavigateStep10000.AccessibleName = "Jumps 10000 items backward/forward";
			menuitemNavigateStep10000.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateStep10000.CheckOnClick = true;
			menuitemNavigateStep10000.Name = "menuitemNavigateStep10000";
			menuitemNavigateStep10000.Size = new Size(110, 22);
			menuitemNavigateStep10000.Text = "10000";
			menuitemNavigateStep10000.ToolTipText = "Jump 10000 items backward/forward";
			menuitemNavigateStep10000.Click += ToolStripMenuItem10000_Click;
			menuitemNavigateStep10000.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateStep10000.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateStep100000
			// 
			menuitemNavigateStep100000.AccessibleDescription = "Jumps 100000 items backward/forward";
			menuitemNavigateStep100000.AccessibleName = "Jumps 100000 items backward/forward";
			menuitemNavigateStep100000.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateStep100000.CheckOnClick = true;
			menuitemNavigateStep100000.Name = "menuitemNavigateStep100000";
			menuitemNavigateStep100000.Size = new Size(110, 22);
			menuitemNavigateStep100000.Text = "100000";
			menuitemNavigateStep100000.ToolTipText = "Jump 100000 items backward/forward";
			menuitemNavigateStep100000.Click += ToolStripMenuItem100000_Click;
			menuitemNavigateStep100000.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateStep100000.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateSomeDataForward
			// 
			menuitemNavigateSomeDataForward.AccessibleDescription = "Navigates some data forward";
			menuitemNavigateSomeDataForward.AccessibleName = "Navigates some data forward";
			menuitemNavigateSomeDataForward.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateSomeDataForward.AutoToolTip = true;
			menuitemNavigateSomeDataForward.DoubleClickEnabled = true;
			menuitemNavigateSomeDataForward.DropDown = contextMenuNavigationStep;
			menuitemNavigateSomeDataForward.Image = Properties.Resources.silk_forward_green;
			menuitemNavigateSomeDataForward.Name = "menuitemNavigateSomeDataForward";
			menuitemNavigateSomeDataForward.ShortcutKeys = Keys.Control | Keys.D5;
			menuitemNavigateSomeDataForward.Size = new Size(275, 22);
			menuitemNavigateSomeDataForward.Text = "Navigate some data &forward";
			menuitemNavigateSomeDataForward.Click += ToolStripMenuItemNavigateSomeDataForward_Click;
			menuitemNavigateSomeDataForward.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateSomeDataForward.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSplitButtonStepForward
			// 
			toolStripSplitButtonStepForward.AccessibleDescription = "Navigates some data forward";
			toolStripSplitButtonStepForward.AccessibleName = "Navigate some data forward";
			toolStripSplitButtonStepForward.AccessibleRole = AccessibleRole.SplitButton;
			toolStripSplitButtonStepForward.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripSplitButtonStepForward.DropDown = contextMenuNavigationStep;
			toolStripSplitButtonStepForward.Image = Properties.Resources.silk_forward_green;
			toolStripSplitButtonStepForward.ImageTransparentColor = Color.Magenta;
			toolStripSplitButtonStepForward.Name = "toolStripSplitButtonStepForward";
			toolStripSplitButtonStepForward.Size = new Size(32, 22);
			toolStripSplitButtonStepForward.Text = "Navigate some data forward";
			toolStripSplitButtonStepForward.ButtonClick += ToolStripButtonStepForward_Click;
			toolStripSplitButtonStepForward.MouseEnter += SetStatusbar_Enter;
			toolStripSplitButtonStepForward.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSplitButtonStepBackward
			// 
			toolStripSplitButtonStepBackward.AccessibleDescription = "Navigates some data backward";
			toolStripSplitButtonStepBackward.AccessibleName = "Navigate some data backward";
			toolStripSplitButtonStepBackward.AccessibleRole = AccessibleRole.SplitButton;
			toolStripSplitButtonStepBackward.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripSplitButtonStepBackward.DropDown = contextMenuNavigationStep;
			toolStripSplitButtonStepBackward.Image = Properties.Resources.silk_backward_green;
			toolStripSplitButtonStepBackward.ImageTransparentColor = Color.Magenta;
			toolStripSplitButtonStepBackward.Name = "toolStripSplitButtonStepBackward";
			toolStripSplitButtonStepBackward.Size = new Size(32, 22);
			toolStripSplitButtonStepBackward.Text = "Navigate some data backward";
			toolStripSplitButtonStepBackward.ButtonClick += ToolStripButtonStepBackward_Click;
			toolStripSplitButtonStepBackward.MouseEnter += SetStatusbar_Enter;
			toolStripSplitButtonStepBackward.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateSomeDataBackward
			// 
			menuitemNavigateSomeDataBackward.AccessibleDescription = "Navigates some data backward";
			menuitemNavigateSomeDataBackward.AccessibleName = "Navigates some data backward";
			menuitemNavigateSomeDataBackward.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateSomeDataBackward.AutoToolTip = true;
			menuitemNavigateSomeDataBackward.DoubleClickEnabled = true;
			menuitemNavigateSomeDataBackward.DropDown = contextMenuNavigationStep;
			menuitemNavigateSomeDataBackward.Image = Properties.Resources.silk_backward_green;
			menuitemNavigateSomeDataBackward.Name = "menuitemNavigateSomeDataBackward";
			menuitemNavigateSomeDataBackward.ShortcutKeys = Keys.Control | Keys.D2;
			menuitemNavigateSomeDataBackward.Size = new Size(275, 22);
			menuitemNavigateSomeDataBackward.Text = "Navigate some data back&ward";
			menuitemNavigateSomeDataBackward.Click += ToolStripMenuItemNavigateSomeDataBackward_Click;
			menuitemNavigateSomeDataBackward.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateSomeDataBackward.MouseLeave += ClearStatusbar_Leave;
			// 
			// tableLayoutPanelData
			// 
			tableLayoutPanelData.AccessibleDescription = "Groups the data";
			tableLayoutPanelData.AccessibleName = "Table panel";
			tableLayoutPanelData.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelData.BackgroundImage = (Image)resources.GetObject("tableLayoutPanelData.BackgroundImage");
			tableLayoutPanelData.BackgroundImageLayout = ImageLayout.None;
			tableLayoutPanelData.ColumnCount = 4;
			tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
			tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelData.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelData.Controls.Add(labelIndexData, 1, 0);
			tableLayoutPanelData.Controls.Add(labelReadableDesignationData, 1, 1);
			tableLayoutPanelData.Controls.Add(labelEpochData, 1, 2);
			tableLayoutPanelData.Controls.Add(labelMeanAnomalyAtTheEpochData, 1, 3);
			tableLayoutPanelData.Controls.Add(labelArgumentOfPerihelionData, 1, 4);
			tableLayoutPanelData.Controls.Add(labelLongitudeOfTheAscendingNodeData, 1, 5);
			tableLayoutPanelData.Controls.Add(labelInclinationToTheEclipticData, 1, 6);
			tableLayoutPanelData.Controls.Add(labelOrbitalEccentricityData, 1, 7);
			tableLayoutPanelData.Controls.Add(labelMeanDailyMotionData, 1, 8);
			tableLayoutPanelData.Controls.Add(labelSemiMajorAxisData, 1, 9);
			tableLayoutPanelData.Controls.Add(labelAbsoluteMagnitudeData, 1, 10);
			tableLayoutPanelData.Controls.Add(labelSlopeParameterData, 3, 1);
			tableLayoutPanelData.Controls.Add(labelReferenceData, 3, 2);
			tableLayoutPanelData.Controls.Add(labelNumberOfOppositionsData, 3, 3);
			tableLayoutPanelData.Controls.Add(labelNumberOfObservationsData, 3, 4);
			tableLayoutPanelData.Controls.Add(labelObservationSpanData, 3, 5);
			tableLayoutPanelData.Controls.Add(labelRmsResidualData, 3, 6);
			tableLayoutPanelData.Controls.Add(labelComputerNameData, 3, 7);
			tableLayoutPanelData.Controls.Add(labelFlagsData, 3, 8);
			tableLayoutPanelData.Controls.Add(labelDateLastObservationData, 3, 9);
			tableLayoutPanelData.Controls.Add(labelIndexDesc, 0, 0);
			tableLayoutPanelData.Controls.Add(labelReadableDesignationDesc, 0, 1);
			tableLayoutPanelData.Controls.Add(labelEpochDesc, 0, 2);
			tableLayoutPanelData.Controls.Add(labelMeanAnomalyAtTheEpochDesc, 0, 3);
			tableLayoutPanelData.Controls.Add(labelArgumentOfPerihelionDesc, 0, 4);
			tableLayoutPanelData.Controls.Add(labelLongitudeOfTheAscendingNodeDesc, 0, 5);
			tableLayoutPanelData.Controls.Add(labelInclinationToTheEclipticDesc, 0, 6);
			tableLayoutPanelData.Controls.Add(labelOrbitalEccentricityDesc, 0, 7);
			tableLayoutPanelData.Controls.Add(labelMeanDailyMotionDesc, 0, 8);
			tableLayoutPanelData.Controls.Add(labelSemiMajorAxisDesc, 0, 9);
			tableLayoutPanelData.Controls.Add(labelAbsoluteMagnitudeDesc, 0, 10);
			tableLayoutPanelData.Controls.Add(labelSlopeParameterDesc, 2, 1);
			tableLayoutPanelData.Controls.Add(labelReferenceDesc, 2, 2);
			tableLayoutPanelData.Controls.Add(labelNumberOfOppositionsDesc, 2, 3);
			tableLayoutPanelData.Controls.Add(labelNumberOfObservationsDesc, 2, 4);
			tableLayoutPanelData.Controls.Add(labelObservationSpanDesc, 2, 5);
			tableLayoutPanelData.Controls.Add(labelRmsResidualDesc, 2, 6);
			tableLayoutPanelData.Controls.Add(labelComputerNameDesc, 2, 7);
			tableLayoutPanelData.Controls.Add(labelFlagsDesc, 2, 8);
			tableLayoutPanelData.Controls.Add(labelDateLastObservationDesc, 2, 9);
			tableLayoutPanelData.Dock = DockStyle.Fill;
			tableLayoutPanelData.Location = new Point(0, 0);
			tableLayoutPanelData.Name = "tableLayoutPanelData";
			tableLayoutPanelData.PanelBackStyle = PaletteBackStyle.FormMain;
			tableLayoutPanelData.RowCount = 11;
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle());
			tableLayoutPanelData.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
			tableLayoutPanelData.Size = new Size(804, 290);
			tableLayoutPanelData.TabIndex = 0;
			tableLayoutPanelData.TabStop = true;
			toolTip.SetToolTip(tableLayoutPanelData, "table panel");
			tableLayoutPanelData.Enter += SetStatusbar_Enter;
			tableLayoutPanelData.Leave += ClearStatusbar_Leave;
			tableLayoutPanelData.MouseEnter += SetStatusbar_Enter;
			tableLayoutPanelData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelIndexData
			// 
			labelIndexData.AccessibleDescription = "Shows the information of \"Index No.\"";
			labelIndexData.AccessibleName = "Shows the information of \"Index No.\"";
			labelIndexData.AccessibleRole = AccessibleRole.StatusBar;
			labelIndexData.Dock = DockStyle.Fill;
			labelIndexData.Location = new Point(273, 3);
			labelIndexData.Name = "labelIndexData";
			labelIndexData.Size = new Size(143, 20);
			labelIndexData.TabIndex = 1;
			toolTip.SetToolTip(labelIndexData, "Shows the information of \"Index No.\"");
			labelIndexData.Values.Text = "..................";
			labelIndexData.DoubleClick += CopyToClipboard_DoubleClick;
			labelIndexData.Enter += SetStatusbar_Enter;
			labelIndexData.Leave += ClearStatusbar_Leave;
			labelIndexData.MouseEnter += SetStatusbar_Enter;
			labelIndexData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelReadableDesignationData
			// 
			labelReadableDesignationData.AccessibleDescription = "Shows the information of \"Readable designation\"";
			labelReadableDesignationData.AccessibleName = "Shows the information of \"Readable designation\"";
			labelReadableDesignationData.AccessibleRole = AccessibleRole.StaticText;
			labelReadableDesignationData.Dock = DockStyle.Fill;
			labelReadableDesignationData.Location = new Point(273, 29);
			labelReadableDesignationData.Name = "labelReadableDesignationData";
			labelReadableDesignationData.Size = new Size(143, 20);
			labelReadableDesignationData.TabIndex = 3;
			toolTip.SetToolTip(labelReadableDesignationData, "Shows the information of \"Readable designation\"");
			labelReadableDesignationData.Values.Text = "..................";
			labelReadableDesignationData.DoubleClick += CopyToClipboard_DoubleClick;
			labelReadableDesignationData.Enter += SetStatusbar_Enter;
			labelReadableDesignationData.Leave += ClearStatusbar_Leave;
			labelReadableDesignationData.MouseEnter += SetStatusbar_Enter;
			labelReadableDesignationData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelEpochData
			// 
			labelEpochData.AccessibleDescription = "Shows the information of \"Epoch (in packed form, .0 TT)\"";
			labelEpochData.AccessibleName = "Shows the information of \"Epoch (in packed form, .0 TT)\"";
			labelEpochData.AccessibleRole = AccessibleRole.StatusBar;
			labelEpochData.Dock = DockStyle.Fill;
			labelEpochData.Location = new Point(273, 55);
			labelEpochData.Name = "labelEpochData";
			labelEpochData.Size = new Size(143, 20);
			labelEpochData.TabIndex = 5;
			toolTip.SetToolTip(labelEpochData, "Shows the information of \"Epoch (in packed form, .0 TT)\"");
			labelEpochData.Values.Text = "..................";
			labelEpochData.DoubleClick += CopyToClipboard_DoubleClick;
			labelEpochData.Enter += SetStatusbar_Enter;
			labelEpochData.Leave += ClearStatusbar_Leave;
			labelEpochData.MouseEnter += SetStatusbar_Enter;
			labelEpochData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanAnomalyAtTheEpochData
			// 
			labelMeanAnomalyAtTheEpochData.AccessibleDescription = "Shows the information of \"Mean anomaly at the epoch, in degrees\"";
			labelMeanAnomalyAtTheEpochData.AccessibleName = "Shows the information of \"Mean anomaly at the epoch, in degrees\"";
			labelMeanAnomalyAtTheEpochData.AccessibleRole = AccessibleRole.StaticText;
			labelMeanAnomalyAtTheEpochData.Dock = DockStyle.Fill;
			labelMeanAnomalyAtTheEpochData.Location = new Point(273, 81);
			labelMeanAnomalyAtTheEpochData.Name = "labelMeanAnomalyAtTheEpochData";
			labelMeanAnomalyAtTheEpochData.Size = new Size(143, 20);
			labelMeanAnomalyAtTheEpochData.TabIndex = 7;
			toolTip.SetToolTip(labelMeanAnomalyAtTheEpochData, "Shows the information of \"Mean anomaly at the epoch, in degrees\"");
			labelMeanAnomalyAtTheEpochData.Values.Text = "..................";
			labelMeanAnomalyAtTheEpochData.DoubleClick += CopyToClipboard_DoubleClick;
			labelMeanAnomalyAtTheEpochData.Enter += SetStatusbar_Enter;
			labelMeanAnomalyAtTheEpochData.Leave += ClearStatusbar_Leave;
			labelMeanAnomalyAtTheEpochData.MouseEnter += SetStatusbar_Enter;
			labelMeanAnomalyAtTheEpochData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelArgumentOfPerihelionData
			// 
			labelArgumentOfPerihelionData.AccessibleDescription = "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			labelArgumentOfPerihelionData.AccessibleName = "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"";
			labelArgumentOfPerihelionData.AccessibleRole = AccessibleRole.StaticText;
			labelArgumentOfPerihelionData.Dock = DockStyle.Fill;
			labelArgumentOfPerihelionData.Location = new Point(273, 107);
			labelArgumentOfPerihelionData.Name = "labelArgumentOfPerihelionData";
			labelArgumentOfPerihelionData.Size = new Size(143, 20);
			labelArgumentOfPerihelionData.TabIndex = 9;
			toolTip.SetToolTip(labelArgumentOfPerihelionData, "Shows the information of \"Argument of perihelion, J2000.0 (degrees)\"");
			labelArgumentOfPerihelionData.Values.Text = "..................";
			labelArgumentOfPerihelionData.DoubleClick += CopyToClipboard_DoubleClick;
			labelArgumentOfPerihelionData.Enter += SetStatusbar_Enter;
			labelArgumentOfPerihelionData.Leave += ClearStatusbar_Leave;
			labelArgumentOfPerihelionData.MouseEnter += SetStatusbar_Enter;
			labelArgumentOfPerihelionData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLongitudeOfTheAscendingNodeData
			// 
			labelLongitudeOfTheAscendingNodeData.AccessibleDescription = "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			labelLongitudeOfTheAscendingNodeData.AccessibleName = "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"";
			labelLongitudeOfTheAscendingNodeData.AccessibleRole = AccessibleRole.StaticText;
			labelLongitudeOfTheAscendingNodeData.Dock = DockStyle.Fill;
			labelLongitudeOfTheAscendingNodeData.Location = new Point(273, 133);
			labelLongitudeOfTheAscendingNodeData.Name = "labelLongitudeOfTheAscendingNodeData";
			labelLongitudeOfTheAscendingNodeData.Size = new Size(143, 20);
			labelLongitudeOfTheAscendingNodeData.TabIndex = 11;
			toolTip.SetToolTip(labelLongitudeOfTheAscendingNodeData, "Shows the information of \"Longitude of the ascending node, J2000.0 (degrees)\"");
			labelLongitudeOfTheAscendingNodeData.Values.Text = "..................";
			// 
			// labelInclinationToTheEclipticData
			// 
			labelInclinationToTheEclipticData.AccessibleDescription = "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			labelInclinationToTheEclipticData.AccessibleName = "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"";
			labelInclinationToTheEclipticData.AccessibleRole = AccessibleRole.StaticText;
			labelInclinationToTheEclipticData.Dock = DockStyle.Fill;
			labelInclinationToTheEclipticData.Location = new Point(273, 159);
			labelInclinationToTheEclipticData.Name = "labelInclinationToTheEclipticData";
			labelInclinationToTheEclipticData.Size = new Size(143, 20);
			labelInclinationToTheEclipticData.TabIndex = 13;
			toolTip.SetToolTip(labelInclinationToTheEclipticData, "Shows the information of \"Inclination to the ecliptic, J2000.0 (degrees)\"");
			labelInclinationToTheEclipticData.Values.Text = "..................";
			labelInclinationToTheEclipticData.DoubleClick += CopyToClipboard_DoubleClick;
			labelInclinationToTheEclipticData.Enter += SetStatusbar_Enter;
			labelInclinationToTheEclipticData.Leave += ClearStatusbar_Leave;
			labelInclinationToTheEclipticData.MouseEnter += SetStatusbar_Enter;
			labelInclinationToTheEclipticData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalEccentricityData
			// 
			labelOrbitalEccentricityData.AccessibleDescription = "Shows the information of \"Orbital eccentricity\"";
			labelOrbitalEccentricityData.AccessibleName = "Shows the information of \"Orbital eccentricity\"";
			labelOrbitalEccentricityData.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalEccentricityData.Dock = DockStyle.Fill;
			labelOrbitalEccentricityData.Location = new Point(273, 185);
			labelOrbitalEccentricityData.Name = "labelOrbitalEccentricityData";
			labelOrbitalEccentricityData.Size = new Size(143, 20);
			labelOrbitalEccentricityData.TabIndex = 15;
			toolTip.SetToolTip(labelOrbitalEccentricityData, "Shows the information of \"Orbital eccentricity\"");
			labelOrbitalEccentricityData.Values.Text = "..................";
			labelOrbitalEccentricityData.DoubleClick += CopyToClipboard_DoubleClick;
			labelOrbitalEccentricityData.Enter += SetStatusbar_Enter;
			labelOrbitalEccentricityData.Leave += ClearStatusbar_Leave;
			labelOrbitalEccentricityData.MouseEnter += SetStatusbar_Enter;
			labelOrbitalEccentricityData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanDailyMotionData
			// 
			labelMeanDailyMotionData.AccessibleDescription = "Shows the information of \"Mean daily motion (degrees per day)\"";
			labelMeanDailyMotionData.AccessibleName = "Shows the information of \"Mean daily motion (degrees per day)\"";
			labelMeanDailyMotionData.AccessibleRole = AccessibleRole.StaticText;
			labelMeanDailyMotionData.Dock = DockStyle.Fill;
			labelMeanDailyMotionData.Location = new Point(273, 211);
			labelMeanDailyMotionData.Name = "labelMeanDailyMotionData";
			labelMeanDailyMotionData.Size = new Size(143, 20);
			labelMeanDailyMotionData.TabIndex = 17;
			toolTip.SetToolTip(labelMeanDailyMotionData, "Shows the information of \"Mean daily motion (degrees per day)\"");
			labelMeanDailyMotionData.Values.Text = "..................";
			labelMeanDailyMotionData.DoubleClick += CopyToClipboard_DoubleClick;
			labelMeanDailyMotionData.Enter += SetStatusbar_Enter;
			labelMeanDailyMotionData.Leave += ClearStatusbar_Leave;
			labelMeanDailyMotionData.MouseEnter += SetStatusbar_Enter;
			labelMeanDailyMotionData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiMajorAxisData
			// 
			labelSemiMajorAxisData.AccessibleDescription = "Shows the information of \"Semi-major axis (AU)\"";
			labelSemiMajorAxisData.AccessibleName = "Shows the information of \"Semi-major axis (AU)\"";
			labelSemiMajorAxisData.AccessibleRole = AccessibleRole.StaticText;
			labelSemiMajorAxisData.Dock = DockStyle.Fill;
			labelSemiMajorAxisData.Location = new Point(273, 237);
			labelSemiMajorAxisData.Name = "labelSemiMajorAxisData";
			labelSemiMajorAxisData.Size = new Size(143, 20);
			labelSemiMajorAxisData.TabIndex = 19;
			toolTip.SetToolTip(labelSemiMajorAxisData, "Shows the information of \"Semi-major axis (AU)\"");
			labelSemiMajorAxisData.Values.Text = "..................";
			labelSemiMajorAxisData.DoubleClick += CopyToClipboard_DoubleClick;
			labelSemiMajorAxisData.Enter += SetStatusbar_Enter;
			labelSemiMajorAxisData.Leave += ClearStatusbar_Leave;
			labelSemiMajorAxisData.MouseEnter += SetStatusbar_Enter;
			labelSemiMajorAxisData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAbsoluteMagnitudeData
			// 
			labelAbsoluteMagnitudeData.AccessibleDescription = "Shows the information of \"Absolute magnitude, H\"";
			labelAbsoluteMagnitudeData.AccessibleName = "Shows the information of \"Absolute magnitude, H\"";
			labelAbsoluteMagnitudeData.AccessibleRole = AccessibleRole.StaticText;
			labelAbsoluteMagnitudeData.Dock = DockStyle.Fill;
			labelAbsoluteMagnitudeData.Location = new Point(273, 263);
			labelAbsoluteMagnitudeData.Name = "labelAbsoluteMagnitudeData";
			labelAbsoluteMagnitudeData.Size = new Size(143, 24);
			labelAbsoluteMagnitudeData.TabIndex = 21;
			toolTip.SetToolTip(labelAbsoluteMagnitudeData, "Shows the information of \"Absolute magnitude, H\"");
			labelAbsoluteMagnitudeData.Values.Text = "..................";
			labelAbsoluteMagnitudeData.DoubleClick += CopyToClipboard_DoubleClick;
			labelAbsoluteMagnitudeData.Enter += SetStatusbar_Enter;
			labelAbsoluteMagnitudeData.Leave += ClearStatusbar_Leave;
			labelAbsoluteMagnitudeData.MouseEnter += SetStatusbar_Enter;
			labelAbsoluteMagnitudeData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSlopeParameterData
			// 
			labelSlopeParameterData.AccessibleDescription = "Shows the information of \"Slope parameter, G\"";
			labelSlopeParameterData.AccessibleName = "Shows the information of \"Slope parameter, G\"";
			labelSlopeParameterData.AccessibleRole = AccessibleRole.StaticText;
			labelSlopeParameterData.Dock = DockStyle.Fill;
			labelSlopeParameterData.Location = new Point(650, 29);
			labelSlopeParameterData.Name = "labelSlopeParameterData";
			labelSlopeParameterData.Size = new Size(151, 20);
			labelSlopeParameterData.TabIndex = 23;
			toolTip.SetToolTip(labelSlopeParameterData, "Shows the information of \"Slope parameter, G\"");
			labelSlopeParameterData.Values.Text = "..................";
			labelSlopeParameterData.DoubleClick += CopyToClipboard_DoubleClick;
			labelSlopeParameterData.Enter += SetStatusbar_Enter;
			labelSlopeParameterData.Leave += ClearStatusbar_Leave;
			labelSlopeParameterData.MouseEnter += SetStatusbar_Enter;
			labelSlopeParameterData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelReferenceData
			// 
			labelReferenceData.AccessibleDescription = "Shows the information of \"Reference\"";
			labelReferenceData.AccessibleName = "Shows the information of \"Reference\"";
			labelReferenceData.AccessibleRole = AccessibleRole.StaticText;
			labelReferenceData.Dock = DockStyle.Fill;
			labelReferenceData.Location = new Point(650, 55);
			labelReferenceData.Name = "labelReferenceData";
			labelReferenceData.Size = new Size(151, 20);
			labelReferenceData.TabIndex = 25;
			toolTip.SetToolTip(labelReferenceData, "Shows the information of \"Reference\"");
			labelReferenceData.Values.Text = "..................";
			labelReferenceData.DoubleClick += CopyToClipboard_DoubleClick;
			labelReferenceData.Enter += SetStatusbar_Enter;
			labelReferenceData.Leave += ClearStatusbar_Leave;
			labelReferenceData.MouseEnter += SetStatusbar_Enter;
			labelReferenceData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNumberOfOppositionsData
			// 
			labelNumberOfOppositionsData.AccessibleDescription = "Shows the information of \"Number of oppositions\"";
			labelNumberOfOppositionsData.AccessibleName = "Shows the information of \"Number of oppositions\"";
			labelNumberOfOppositionsData.AccessibleRole = AccessibleRole.StaticText;
			labelNumberOfOppositionsData.Dock = DockStyle.Fill;
			labelNumberOfOppositionsData.Location = new Point(650, 81);
			labelNumberOfOppositionsData.Name = "labelNumberOfOppositionsData";
			labelNumberOfOppositionsData.Size = new Size(151, 20);
			labelNumberOfOppositionsData.TabIndex = 27;
			toolTip.SetToolTip(labelNumberOfOppositionsData, "Shows the information of \"Number of oppositions\"");
			labelNumberOfOppositionsData.Values.Text = "..................";
			labelNumberOfOppositionsData.DoubleClick += CopyToClipboard_DoubleClick;
			labelNumberOfOppositionsData.Enter += SetStatusbar_Enter;
			labelNumberOfOppositionsData.Leave += ClearStatusbar_Leave;
			labelNumberOfOppositionsData.MouseEnter += SetStatusbar_Enter;
			labelNumberOfOppositionsData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNumberOfObservationsData
			// 
			labelNumberOfObservationsData.AccessibleDescription = "Shows the information of \"Number of observations\"";
			labelNumberOfObservationsData.AccessibleName = "Shows the information of \"Number of observations\"";
			labelNumberOfObservationsData.AccessibleRole = AccessibleRole.StaticText;
			labelNumberOfObservationsData.Dock = DockStyle.Fill;
			labelNumberOfObservationsData.Location = new Point(650, 107);
			labelNumberOfObservationsData.Name = "labelNumberOfObservationsData";
			labelNumberOfObservationsData.Size = new Size(151, 20);
			labelNumberOfObservationsData.TabIndex = 29;
			toolTip.SetToolTip(labelNumberOfObservationsData, "Shows the information of \"Number of observations\"");
			labelNumberOfObservationsData.Values.Text = "..................";
			labelNumberOfObservationsData.DoubleClick += CopyToClipboard_DoubleClick;
			labelNumberOfObservationsData.Enter += SetStatusbar_Enter;
			labelNumberOfObservationsData.Leave += ClearStatusbar_Leave;
			labelNumberOfObservationsData.MouseEnter += SetStatusbar_Enter;
			labelNumberOfObservationsData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelObservationSpanData
			// 
			labelObservationSpanData.AccessibleDescription = "Shows the information of \"Observation span\"";
			labelObservationSpanData.AccessibleName = "Shows the information of \"Observation span\"";
			labelObservationSpanData.AccessibleRole = AccessibleRole.StaticText;
			labelObservationSpanData.Dock = DockStyle.Fill;
			labelObservationSpanData.Location = new Point(650, 133);
			labelObservationSpanData.Name = "labelObservationSpanData";
			labelObservationSpanData.Size = new Size(151, 20);
			labelObservationSpanData.TabIndex = 31;
			toolTip.SetToolTip(labelObservationSpanData, "Shows the information of \"Observation span\"");
			labelObservationSpanData.Values.Text = "..................";
			labelObservationSpanData.DoubleClick += CopyToClipboard_DoubleClick;
			labelObservationSpanData.Enter += SetStatusbar_Enter;
			labelObservationSpanData.Leave += ClearStatusbar_Leave;
			labelObservationSpanData.MouseEnter += SetStatusbar_Enter;
			labelObservationSpanData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelRmsResidualData
			// 
			labelRmsResidualData.AccessibleDescription = "Shows the information of \"r.m.s residual (\")\"";
			labelRmsResidualData.AccessibleName = "Shows the information of \"r.m.s residual (\")\"";
			labelRmsResidualData.AccessibleRole = AccessibleRole.StaticText;
			labelRmsResidualData.Dock = DockStyle.Fill;
			labelRmsResidualData.Location = new Point(650, 159);
			labelRmsResidualData.Name = "labelRmsResidualData";
			labelRmsResidualData.Size = new Size(151, 20);
			labelRmsResidualData.TabIndex = 33;
			toolTip.SetToolTip(labelRmsResidualData, "Shows the information of \"r.m.s residual (\")\"");
			labelRmsResidualData.Values.Text = "..................";
			labelRmsResidualData.DoubleClick += CopyToClipboard_DoubleClick;
			labelRmsResidualData.Enter += SetStatusbar_Enter;
			labelRmsResidualData.Leave += ClearStatusbar_Leave;
			labelRmsResidualData.MouseEnter += SetStatusbar_Enter;
			labelRmsResidualData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelComputerNameData
			// 
			labelComputerNameData.AccessibleDescription = "Shows the information of \"Computer name\"";
			labelComputerNameData.AccessibleName = "Shows the information of \"Computer name\"";
			labelComputerNameData.AccessibleRole = AccessibleRole.StaticText;
			labelComputerNameData.Dock = DockStyle.Fill;
			labelComputerNameData.Location = new Point(650, 185);
			labelComputerNameData.Name = "labelComputerNameData";
			labelComputerNameData.Size = new Size(151, 20);
			labelComputerNameData.TabIndex = 35;
			toolTip.SetToolTip(labelComputerNameData, "Shows the information of \"Computer name\"");
			labelComputerNameData.Values.Text = "..................";
			labelComputerNameData.DoubleClick += CopyToClipboard_DoubleClick;
			labelComputerNameData.Enter += SetStatusbar_Enter;
			labelComputerNameData.Leave += ClearStatusbar_Leave;
			labelComputerNameData.MouseEnter += SetStatusbar_Enter;
			labelComputerNameData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelFlagsData
			// 
			labelFlagsData.AccessibleDescription = "Shows the information of \"4-hexdigit flags\"";
			labelFlagsData.AccessibleName = "Shows the information of \"4-hexdigit flags\"";
			labelFlagsData.AccessibleRole = AccessibleRole.StaticText;
			labelFlagsData.Dock = DockStyle.Fill;
			labelFlagsData.Location = new Point(650, 211);
			labelFlagsData.Name = "labelFlagsData";
			labelFlagsData.Size = new Size(151, 20);
			labelFlagsData.TabIndex = 37;
			toolTip.SetToolTip(labelFlagsData, "Shows the information of \"4-hexdigit flags\"");
			labelFlagsData.Values.Text = "..................";
			labelFlagsData.DoubleClick += CopyToClipboard_DoubleClick;
			labelFlagsData.Enter += SetStatusbar_Enter;
			labelFlagsData.Leave += ClearStatusbar_Leave;
			labelFlagsData.MouseEnter += SetStatusbar_Enter;
			labelFlagsData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateLastObservationData
			// 
			labelDateLastObservationData.AccessibleDescription = "Shows the information of \"Date of last observation\"";
			labelDateLastObservationData.AccessibleName = "Shows the information of \"Date of last observation\"";
			labelDateLastObservationData.AccessibleRole = AccessibleRole.StaticText;
			labelDateLastObservationData.Dock = DockStyle.Fill;
			labelDateLastObservationData.Location = new Point(650, 237);
			labelDateLastObservationData.Name = "labelDateLastObservationData";
			labelDateLastObservationData.Size = new Size(151, 20);
			labelDateLastObservationData.TabIndex = 39;
			toolTip.SetToolTip(labelDateLastObservationData, "Shows the information of \"Date of last observation\"");
			labelDateLastObservationData.Values.Text = "..................";
			labelDateLastObservationData.DoubleClick += CopyToClipboard_DoubleClick;
			labelDateLastObservationData.Enter += SetStatusbar_Enter;
			labelDateLastObservationData.Leave += ClearStatusbar_Leave;
			labelDateLastObservationData.MouseEnter += SetStatusbar_Enter;
			labelDateLastObservationData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelIndexDesc
			// 
			labelIndexDesc.AccessibleDescription = "Index No.";
			labelIndexDesc.AccessibleName = "Index No.";
			labelIndexDesc.AccessibleRole = AccessibleRole.StaticText;
			labelIndexDesc.Dock = DockStyle.Fill;
			labelIndexDesc.LabelStyle = LabelStyle.BoldControl;
			labelIndexDesc.Location = new Point(3, 3);
			labelIndexDesc.Name = "labelIndexDesc";
			labelIndexDesc.Size = new Size(264, 20);
			labelIndexDesc.TabIndex = 0;
			toolTip.SetToolTip(labelIndexDesc, "Index No.");
			labelIndexDesc.Values.Text = "Index No.";
			labelIndexDesc.DoubleClick += LabelIndexDesc_DoubleClick;
			labelIndexDesc.Enter += SetStatusbar_Enter;
			labelIndexDesc.Leave += ClearStatusbar_Leave;
			labelIndexDesc.MouseEnter += SetStatusbar_Enter;
			labelIndexDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelReadableDesignationDesc
			// 
			labelReadableDesignationDesc.AccessibleDescription = "Readable designation";
			labelReadableDesignationDesc.AccessibleName = "Readable designation";
			labelReadableDesignationDesc.AccessibleRole = AccessibleRole.StaticText;
			labelReadableDesignationDesc.Dock = DockStyle.Fill;
			labelReadableDesignationDesc.LabelStyle = LabelStyle.BoldPanel;
			labelReadableDesignationDesc.Location = new Point(3, 29);
			labelReadableDesignationDesc.Name = "labelReadableDesignationDesc";
			labelReadableDesignationDesc.Size = new Size(264, 20);
			labelReadableDesignationDesc.TabIndex = 2;
			toolTip.SetToolTip(labelReadableDesignationDesc, "Readable designation");
			labelReadableDesignationDesc.Values.Text = "Readable designation";
			labelReadableDesignationDesc.DoubleClick += LabelReadableDesignationNameDesc_DoubleClick;
			labelReadableDesignationDesc.Enter += SetStatusbar_Enter;
			labelReadableDesignationDesc.Leave += ClearStatusbar_Leave;
			labelReadableDesignationDesc.MouseEnter += SetStatusbar_Enter;
			labelReadableDesignationDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelEpochDesc
			// 
			labelEpochDesc.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			labelEpochDesc.AccessibleName = "Epoch (in packed form, .0 TT)";
			labelEpochDesc.AccessibleRole = AccessibleRole.StaticText;
			labelEpochDesc.Dock = DockStyle.Fill;
			labelEpochDesc.LabelStyle = LabelStyle.BoldPanel;
			labelEpochDesc.Location = new Point(3, 55);
			labelEpochDesc.Name = "labelEpochDesc";
			labelEpochDesc.Size = new Size(264, 20);
			labelEpochDesc.TabIndex = 4;
			toolTip.SetToolTip(labelEpochDesc, "Epoch (in packed form, .0 TT)");
			labelEpochDesc.Values.Text = "Epoch (in packed form, .0 TT)";
			labelEpochDesc.DoubleClick += LabelEpochDesc_DoubleClick;
			labelEpochDesc.Enter += SetStatusbar_Enter;
			labelEpochDesc.Leave += ClearStatusbar_Leave;
			labelEpochDesc.MouseEnter += SetStatusbar_Enter;
			labelEpochDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanAnomalyAtTheEpochDesc
			// 
			labelMeanAnomalyAtTheEpochDesc.AccessibleDescription = "Mean anomaly at the epoch (degrees)";
			labelMeanAnomalyAtTheEpochDesc.AccessibleName = "Mean anomaly at the epoch (degrees)";
			labelMeanAnomalyAtTheEpochDesc.AccessibleRole = AccessibleRole.StaticText;
			labelMeanAnomalyAtTheEpochDesc.Dock = DockStyle.Fill;
			labelMeanAnomalyAtTheEpochDesc.LabelStyle = LabelStyle.BoldPanel;
			labelMeanAnomalyAtTheEpochDesc.Location = new Point(3, 81);
			labelMeanAnomalyAtTheEpochDesc.Name = "labelMeanAnomalyAtTheEpochDesc";
			labelMeanAnomalyAtTheEpochDesc.Size = new Size(264, 20);
			labelMeanAnomalyAtTheEpochDesc.TabIndex = 6;
			toolTip.SetToolTip(labelMeanAnomalyAtTheEpochDesc, "Mean anomaly at the epoch (degrees)");
			labelMeanAnomalyAtTheEpochDesc.Values.ExtraText = "°";
			labelMeanAnomalyAtTheEpochDesc.Values.Text = "Mean anomaly at the epoch";
			labelMeanAnomalyAtTheEpochDesc.DoubleClick += KryptonLabelMeanAnomalyAtTheEpochDesc_DoubleClick;
			labelMeanAnomalyAtTheEpochDesc.Enter += SetStatusbar_Enter;
			labelMeanAnomalyAtTheEpochDesc.Leave += ClearStatusbar_Leave;
			labelMeanAnomalyAtTheEpochDesc.MouseEnter += SetStatusbar_Enter;
			labelMeanAnomalyAtTheEpochDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelArgumentOfPerihelionDesc
			// 
			labelArgumentOfPerihelionDesc.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			labelArgumentOfPerihelionDesc.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			labelArgumentOfPerihelionDesc.AccessibleRole = AccessibleRole.StaticText;
			labelArgumentOfPerihelionDesc.Dock = DockStyle.Fill;
			labelArgumentOfPerihelionDesc.LabelStyle = LabelStyle.BoldPanel;
			labelArgumentOfPerihelionDesc.Location = new Point(3, 107);
			labelArgumentOfPerihelionDesc.Name = "labelArgumentOfPerihelionDesc";
			labelArgumentOfPerihelionDesc.Size = new Size(264, 20);
			labelArgumentOfPerihelionDesc.TabIndex = 8;
			toolTip.SetToolTip(labelArgumentOfPerihelionDesc, "Argument of perihelion, J2000.0 (degrees)");
			labelArgumentOfPerihelionDesc.Values.ExtraText = "°";
			labelArgumentOfPerihelionDesc.Values.Text = "Argument of perihelion, J2000.0";
			labelArgumentOfPerihelionDesc.DoubleClick += LabelArgumentOfPerihelionDesc_DoubleClick;
			labelArgumentOfPerihelionDesc.Enter += SetStatusbar_Enter;
			labelArgumentOfPerihelionDesc.Leave += ClearStatusbar_Leave;
			labelArgumentOfPerihelionDesc.MouseEnter += SetStatusbar_Enter;
			labelArgumentOfPerihelionDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLongitudeOfTheAscendingNodeDesc
			// 
			labelLongitudeOfTheAscendingNodeDesc.AccessibleDescription = "Longitude of the ascending node, J2000.0 (degrees)";
			labelLongitudeOfTheAscendingNodeDesc.AccessibleName = "Longitude of the ascending node, J2000.0 (degrees)";
			labelLongitudeOfTheAscendingNodeDesc.AccessibleRole = AccessibleRole.StaticText;
			labelLongitudeOfTheAscendingNodeDesc.Dock = DockStyle.Fill;
			labelLongitudeOfTheAscendingNodeDesc.LabelStyle = LabelStyle.BoldPanel;
			labelLongitudeOfTheAscendingNodeDesc.Location = new Point(3, 133);
			labelLongitudeOfTheAscendingNodeDesc.Name = "labelLongitudeOfTheAscendingNodeDesc";
			labelLongitudeOfTheAscendingNodeDesc.Size = new Size(264, 20);
			labelLongitudeOfTheAscendingNodeDesc.TabIndex = 10;
			toolTip.SetToolTip(labelLongitudeOfTheAscendingNodeDesc, "Longitude of the ascending node, J2000.0 (degrees)");
			labelLongitudeOfTheAscendingNodeDesc.Values.ExtraText = "°";
			labelLongitudeOfTheAscendingNodeDesc.Values.Text = "Longitude of the ascending node, J2000.0";
			labelLongitudeOfTheAscendingNodeDesc.DoubleClick += LabelLongitudeOfTheAscendingNodeDesc_DoubleClick;
			labelLongitudeOfTheAscendingNodeDesc.Enter += SetStatusbar_Enter;
			labelLongitudeOfTheAscendingNodeDesc.Leave += ClearStatusbar_Leave;
			labelLongitudeOfTheAscendingNodeDesc.MouseEnter += SetStatusbar_Enter;
			labelLongitudeOfTheAscendingNodeDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelInclinationToTheEclipticDesc
			// 
			labelInclinationToTheEclipticDesc.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			labelInclinationToTheEclipticDesc.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			labelInclinationToTheEclipticDesc.AccessibleRole = AccessibleRole.StaticText;
			labelInclinationToTheEclipticDesc.Dock = DockStyle.Fill;
			labelInclinationToTheEclipticDesc.LabelStyle = LabelStyle.BoldPanel;
			labelInclinationToTheEclipticDesc.Location = new Point(3, 159);
			labelInclinationToTheEclipticDesc.Name = "labelInclinationToTheEclipticDesc";
			labelInclinationToTheEclipticDesc.Size = new Size(264, 20);
			labelInclinationToTheEclipticDesc.TabIndex = 12;
			toolTip.SetToolTip(labelInclinationToTheEclipticDesc, "Inclination to the ecliptic, J2000.0 (degrees)");
			labelInclinationToTheEclipticDesc.Values.ExtraText = "°";
			labelInclinationToTheEclipticDesc.Values.Text = "Inclination to the ecliptic, J2000.0";
			labelInclinationToTheEclipticDesc.DoubleClick += LabelInclinationToTheEclipticDesc_DoubleClick;
			labelInclinationToTheEclipticDesc.Enter += SetStatusbar_Enter;
			labelInclinationToTheEclipticDesc.Leave += ClearStatusbar_Leave;
			labelInclinationToTheEclipticDesc.MouseEnter += SetStatusbar_Enter;
			labelInclinationToTheEclipticDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalEccentricityDesc
			// 
			labelOrbitalEccentricityDesc.AccessibleDescription = "Orbital eccentricity";
			labelOrbitalEccentricityDesc.AccessibleName = "Orbital eccentricity";
			labelOrbitalEccentricityDesc.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalEccentricityDesc.Dock = DockStyle.Fill;
			labelOrbitalEccentricityDesc.LabelStyle = LabelStyle.BoldPanel;
			labelOrbitalEccentricityDesc.Location = new Point(3, 185);
			labelOrbitalEccentricityDesc.Name = "labelOrbitalEccentricityDesc";
			labelOrbitalEccentricityDesc.Size = new Size(264, 20);
			labelOrbitalEccentricityDesc.TabIndex = 14;
			toolTip.SetToolTip(labelOrbitalEccentricityDesc, "Orbital eccentricity");
			labelOrbitalEccentricityDesc.Values.Text = "Orbital eccentricity";
			labelOrbitalEccentricityDesc.DoubleClick += LabelOrbitalEccentricityDesc_DoubleClick;
			labelOrbitalEccentricityDesc.Enter += SetStatusbar_Enter;
			labelOrbitalEccentricityDesc.Leave += ClearStatusbar_Leave;
			labelOrbitalEccentricityDesc.MouseEnter += SetStatusbar_Enter;
			labelOrbitalEccentricityDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanDailyMotionDesc
			// 
			labelMeanDailyMotionDesc.AccessibleDescription = "Mean daily motion (degrees per day)";
			labelMeanDailyMotionDesc.AccessibleName = "Mean daily motion (degrees per day)";
			labelMeanDailyMotionDesc.AccessibleRole = AccessibleRole.StaticText;
			labelMeanDailyMotionDesc.Dock = DockStyle.Fill;
			labelMeanDailyMotionDesc.LabelStyle = LabelStyle.BoldPanel;
			labelMeanDailyMotionDesc.Location = new Point(3, 211);
			labelMeanDailyMotionDesc.Name = "labelMeanDailyMotionDesc";
			labelMeanDailyMotionDesc.Size = new Size(264, 20);
			labelMeanDailyMotionDesc.TabIndex = 16;
			toolTip.SetToolTip(labelMeanDailyMotionDesc, "Mean daily motion (degrees per day)");
			labelMeanDailyMotionDesc.Values.ExtraText = "°/day";
			labelMeanDailyMotionDesc.Values.Text = "Mean daily motion";
			labelMeanDailyMotionDesc.DoubleClick += LabelMeanDailyMotionDesc_DoubleClick;
			labelMeanDailyMotionDesc.Enter += SetStatusbar_Enter;
			labelMeanDailyMotionDesc.Leave += ClearStatusbar_Leave;
			labelMeanDailyMotionDesc.MouseEnter += SetStatusbar_Enter;
			labelMeanDailyMotionDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiMajorAxisDesc
			// 
			labelSemiMajorAxisDesc.AccessibleDescription = "Semi-major axis (AU)";
			labelSemiMajorAxisDesc.AccessibleName = "Semi-major axis (AU)";
			labelSemiMajorAxisDesc.AccessibleRole = AccessibleRole.StaticText;
			labelSemiMajorAxisDesc.Dock = DockStyle.Fill;
			labelSemiMajorAxisDesc.LabelStyle = LabelStyle.BoldPanel;
			labelSemiMajorAxisDesc.Location = new Point(3, 237);
			labelSemiMajorAxisDesc.Name = "labelSemiMajorAxisDesc";
			labelSemiMajorAxisDesc.Size = new Size(264, 20);
			labelSemiMajorAxisDesc.TabIndex = 18;
			toolTip.SetToolTip(labelSemiMajorAxisDesc, "Semi-major axis (AU)");
			labelSemiMajorAxisDesc.Values.ExtraText = "AU";
			labelSemiMajorAxisDesc.Values.Text = "Semi-major axis";
			labelSemiMajorAxisDesc.DoubleClick += LabelSemiMajorAxisDesc_DoubleClick;
			labelSemiMajorAxisDesc.Enter += SetStatusbar_Enter;
			labelSemiMajorAxisDesc.Leave += ClearStatusbar_Leave;
			labelSemiMajorAxisDesc.MouseEnter += SetStatusbar_Enter;
			labelSemiMajorAxisDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAbsoluteMagnitudeDesc
			// 
			labelAbsoluteMagnitudeDesc.AccessibleDescription = "Absolute magnitude, H";
			labelAbsoluteMagnitudeDesc.AccessibleName = "Absolute magnitude, H";
			labelAbsoluteMagnitudeDesc.AccessibleRole = AccessibleRole.StaticText;
			labelAbsoluteMagnitudeDesc.Dock = DockStyle.Fill;
			labelAbsoluteMagnitudeDesc.LabelStyle = LabelStyle.BoldPanel;
			labelAbsoluteMagnitudeDesc.Location = new Point(3, 263);
			labelAbsoluteMagnitudeDesc.Name = "labelAbsoluteMagnitudeDesc";
			labelAbsoluteMagnitudeDesc.Size = new Size(264, 24);
			labelAbsoluteMagnitudeDesc.TabIndex = 20;
			toolTip.SetToolTip(labelAbsoluteMagnitudeDesc, "Absolute magnitude, H");
			labelAbsoluteMagnitudeDesc.Values.ExtraText = "mag";
			labelAbsoluteMagnitudeDesc.Values.Text = "Absolute magnitude, H";
			labelAbsoluteMagnitudeDesc.DoubleClick += LabelAbsoluteMagnitudeDesc_DoubleClick;
			labelAbsoluteMagnitudeDesc.Enter += SetStatusbar_Enter;
			labelAbsoluteMagnitudeDesc.Leave += ClearStatusbar_Leave;
			labelAbsoluteMagnitudeDesc.MouseEnter += SetStatusbar_Enter;
			labelAbsoluteMagnitudeDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSlopeParameterDesc
			// 
			labelSlopeParameterDesc.AccessibleDescription = "Slope parameter, G";
			labelSlopeParameterDesc.AccessibleName = "Slope parameter, G";
			labelSlopeParameterDesc.AccessibleRole = AccessibleRole.StaticText;
			labelSlopeParameterDesc.Dock = DockStyle.Fill;
			labelSlopeParameterDesc.LabelStyle = LabelStyle.BoldControl;
			labelSlopeParameterDesc.Location = new Point(422, 29);
			labelSlopeParameterDesc.Name = "labelSlopeParameterDesc";
			labelSlopeParameterDesc.Size = new Size(222, 20);
			labelSlopeParameterDesc.TabIndex = 22;
			toolTip.SetToolTip(labelSlopeParameterDesc, "Slope parameter, G");
			labelSlopeParameterDesc.Values.Text = "Slope parameter, G";
			labelSlopeParameterDesc.DoubleClick += LabelSlopeParameterDesc_DoubleClick;
			labelSlopeParameterDesc.Enter += SetStatusbar_Enter;
			labelSlopeParameterDesc.Leave += ClearStatusbar_Leave;
			labelSlopeParameterDesc.MouseEnter += SetStatusbar_Enter;
			labelSlopeParameterDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelReferenceDesc
			// 
			labelReferenceDesc.AccessibleDescription = "Reference";
			labelReferenceDesc.AccessibleName = "Reference";
			labelReferenceDesc.AccessibleRole = AccessibleRole.StaticText;
			labelReferenceDesc.Dock = DockStyle.Fill;
			labelReferenceDesc.LabelStyle = LabelStyle.BoldPanel;
			labelReferenceDesc.Location = new Point(422, 55);
			labelReferenceDesc.Name = "labelReferenceDesc";
			labelReferenceDesc.Size = new Size(222, 20);
			labelReferenceDesc.TabIndex = 24;
			toolTip.SetToolTip(labelReferenceDesc, "Reference");
			labelReferenceDesc.Values.Text = "Reference";
			labelReferenceDesc.DoubleClick += LabelReferenceDesc_DoubleClick;
			labelReferenceDesc.Enter += SetStatusbar_Enter;
			labelReferenceDesc.Leave += ClearStatusbar_Leave;
			labelReferenceDesc.MouseEnter += SetStatusbar_Enter;
			labelReferenceDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNumberOfOppositionsDesc
			// 
			labelNumberOfOppositionsDesc.AccessibleDescription = "Number of oppositions";
			labelNumberOfOppositionsDesc.AccessibleName = "Number of oppositions";
			labelNumberOfOppositionsDesc.AccessibleRole = AccessibleRole.StaticText;
			labelNumberOfOppositionsDesc.Dock = DockStyle.Fill;
			labelNumberOfOppositionsDesc.LabelStyle = LabelStyle.BoldPanel;
			labelNumberOfOppositionsDesc.Location = new Point(422, 81);
			labelNumberOfOppositionsDesc.Name = "labelNumberOfOppositionsDesc";
			labelNumberOfOppositionsDesc.Size = new Size(222, 20);
			labelNumberOfOppositionsDesc.TabIndex = 26;
			toolTip.SetToolTip(labelNumberOfOppositionsDesc, "Number of oppositions");
			labelNumberOfOppositionsDesc.Values.Text = "Number of oppositions";
			labelNumberOfOppositionsDesc.DoubleClick += LabelNumberOfOppositionsDesc_DoubleClick;
			labelNumberOfOppositionsDesc.Enter += SetStatusbar_Enter;
			labelNumberOfOppositionsDesc.Leave += ClearStatusbar_Leave;
			labelNumberOfOppositionsDesc.MouseEnter += SetStatusbar_Enter;
			labelNumberOfOppositionsDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNumberOfObservationsDesc
			// 
			labelNumberOfObservationsDesc.AccessibleDescription = "Number of observations";
			labelNumberOfObservationsDesc.AccessibleName = "Number of observations";
			labelNumberOfObservationsDesc.AccessibleRole = AccessibleRole.StaticText;
			labelNumberOfObservationsDesc.Dock = DockStyle.Fill;
			labelNumberOfObservationsDesc.LabelStyle = LabelStyle.BoldPanel;
			labelNumberOfObservationsDesc.Location = new Point(422, 107);
			labelNumberOfObservationsDesc.Name = "labelNumberOfObservationsDesc";
			labelNumberOfObservationsDesc.Size = new Size(222, 20);
			labelNumberOfObservationsDesc.TabIndex = 28;
			toolTip.SetToolTip(labelNumberOfObservationsDesc, "Number of observations");
			labelNumberOfObservationsDesc.Values.Text = "Number of observations";
			labelNumberOfObservationsDesc.DoubleClick += LabelNumberOfObservationsDesc_DoubleClick;
			labelNumberOfObservationsDesc.Enter += SetStatusbar_Enter;
			labelNumberOfObservationsDesc.Leave += ClearStatusbar_Leave;
			labelNumberOfObservationsDesc.MouseEnter += SetStatusbar_Enter;
			labelNumberOfObservationsDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelObservationSpanDesc
			// 
			labelObservationSpanDesc.AccessibleDescription = "Observation span";
			labelObservationSpanDesc.AccessibleName = "Observation span";
			labelObservationSpanDesc.AccessibleRole = AccessibleRole.StaticText;
			labelObservationSpanDesc.Dock = DockStyle.Fill;
			labelObservationSpanDesc.LabelStyle = LabelStyle.BoldPanel;
			labelObservationSpanDesc.Location = new Point(422, 133);
			labelObservationSpanDesc.Name = "labelObservationSpanDesc";
			labelObservationSpanDesc.Size = new Size(222, 20);
			labelObservationSpanDesc.TabIndex = 30;
			toolTip.SetToolTip(labelObservationSpanDesc, "Observation span");
			labelObservationSpanDesc.Values.Text = "Observation span";
			labelObservationSpanDesc.DoubleClick += LabelObservationSpanDesc_DoubleClick;
			labelObservationSpanDesc.Enter += SetStatusbar_Enter;
			labelObservationSpanDesc.Leave += ClearStatusbar_Leave;
			labelObservationSpanDesc.MouseEnter += SetStatusbar_Enter;
			labelObservationSpanDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelRmsResidualDesc
			// 
			labelRmsResidualDesc.AccessibleDescription = "r.m.s. residual (arcseconds)";
			labelRmsResidualDesc.AccessibleName = "r.m.s. residual (arcseconds)";
			labelRmsResidualDesc.AccessibleRole = AccessibleRole.StaticText;
			labelRmsResidualDesc.Dock = DockStyle.Fill;
			labelRmsResidualDesc.LabelStyle = LabelStyle.BoldPanel;
			labelRmsResidualDesc.Location = new Point(422, 159);
			labelRmsResidualDesc.Name = "labelRmsResidualDesc";
			labelRmsResidualDesc.Size = new Size(222, 20);
			labelRmsResidualDesc.TabIndex = 32;
			toolTip.SetToolTip(labelRmsResidualDesc, "r.m.s. residual (arcseconds)");
			labelRmsResidualDesc.Values.ExtraText = "\"";
			labelRmsResidualDesc.Values.Text = "r.m.s. residual";
			labelRmsResidualDesc.DoubleClick += LabelRmsResidualDesc_DoubleClick;
			labelRmsResidualDesc.Enter += SetStatusbar_Enter;
			labelRmsResidualDesc.Leave += ClearStatusbar_Leave;
			labelRmsResidualDesc.MouseEnter += SetStatusbar_Enter;
			labelRmsResidualDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelComputerNameDesc
			// 
			labelComputerNameDesc.AccessibleDescription = "Computer name";
			labelComputerNameDesc.AccessibleName = "Computer name";
			labelComputerNameDesc.AccessibleRole = AccessibleRole.StaticText;
			labelComputerNameDesc.Dock = DockStyle.Fill;
			labelComputerNameDesc.LabelStyle = LabelStyle.BoldPanel;
			labelComputerNameDesc.Location = new Point(422, 185);
			labelComputerNameDesc.Name = "labelComputerNameDesc";
			labelComputerNameDesc.Size = new Size(222, 20);
			labelComputerNameDesc.TabIndex = 34;
			toolTip.SetToolTip(labelComputerNameDesc, "Computer name");
			labelComputerNameDesc.Values.Text = "Computer name";
			labelComputerNameDesc.DoubleClick += LabelComputerNameDesc_DoubleClick;
			labelComputerNameDesc.Enter += SetStatusbar_Enter;
			labelComputerNameDesc.Leave += ClearStatusbar_Leave;
			labelComputerNameDesc.MouseEnter += SetStatusbar_Enter;
			labelComputerNameDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelFlagsDesc
			// 
			labelFlagsDesc.AccessibleDescription = "4-hexdigit flags";
			labelFlagsDesc.AccessibleName = "4-hexdigit flags";
			labelFlagsDesc.AccessibleRole = AccessibleRole.StaticText;
			labelFlagsDesc.Dock = DockStyle.Fill;
			labelFlagsDesc.LabelStyle = LabelStyle.BoldPanel;
			labelFlagsDesc.Location = new Point(422, 211);
			labelFlagsDesc.Name = "labelFlagsDesc";
			labelFlagsDesc.Size = new Size(222, 20);
			labelFlagsDesc.TabIndex = 36;
			toolTip.SetToolTip(labelFlagsDesc, "4-hexdigit flags");
			labelFlagsDesc.Values.Text = "4-hexdigit flags";
			labelFlagsDesc.DoubleClick += LabelFlagsDesc_DoubleClick;
			labelFlagsDesc.Enter += SetStatusbar_Enter;
			labelFlagsDesc.Leave += ClearStatusbar_Leave;
			labelFlagsDesc.MouseEnter += SetStatusbar_Enter;
			labelFlagsDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateLastObservationDesc
			// 
			labelDateLastObservationDesc.AccessibleDescription = "Date of last observation (YYYYMMDD)";
			labelDateLastObservationDesc.AccessibleName = "Date of last observation (YYYYMMDD)";
			labelDateLastObservationDesc.AccessibleRole = AccessibleRole.StaticText;
			labelDateLastObservationDesc.Dock = DockStyle.Fill;
			labelDateLastObservationDesc.LabelStyle = LabelStyle.BoldPanel;
			labelDateLastObservationDesc.Location = new Point(422, 237);
			labelDateLastObservationDesc.Name = "labelDateLastObservationDesc";
			labelDateLastObservationDesc.Size = new Size(222, 20);
			labelDateLastObservationDesc.TabIndex = 38;
			toolTip.SetToolTip(labelDateLastObservationDesc, "Date of last observation (YYYYMMDD)");
			labelDateLastObservationDesc.Values.ExtraText = "YYYYMMDD";
			labelDateLastObservationDesc.Values.Text = "Date of last observation";
			labelDateLastObservationDesc.DoubleClick += LabelDateLastObservationDesc_DoubleClick;
			labelDateLastObservationDesc.Enter += SetStatusbar_Enter;
			labelDateLastObservationDesc.Leave += ClearStatusbar_Leave;
			labelDateLastObservationDesc.MouseEnter += SetStatusbar_Enter;
			labelDateLastObservationDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// contextMenuTopTenRecords
			// 
			contextMenuTopTenRecords.AccessibleDescription = "Shows the context menu of the top ten records";
			contextMenuTopTenRecords.AccessibleName = "context menu of the top ten records";
			contextMenuTopTenRecords.AccessibleRole = AccessibleRole.MenuPopup;
			contextMenuTopTenRecords.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			contextMenuTopTenRecords.Items.AddRange(new ToolStripItem[] { menuitemRecordsSortDirection, toolStripSeparator12, menuitemRecordsMeanAnomalyAtTheEpoch, menuitemRecordsArgumentOfPerihelion, menuitemRecordsLongitudeOfTheAscendingNode, menuitemRecordsInclination, menuitemRecordsOrbitalEccentricity, menuitemRecordsMeanDailyMotion, menuitemRecordsSemiMajorAxis, menuitemRecordsAbsoluteMagnitude, menuitemRecordsSlopeParameter, menuitemRecordsNumberOfOppositions, menuitemRecordsNumberOfObservations, menuitemRecordsObservationSpan, menuitemRecordsRmsResidual, menuitemRecordsComputername, menuitemRecordsDateOfTheLastObservation });
			contextMenuTopTenRecords.Name = "contextMenuTopTenRecords";
			contextMenuTopTenRecords.OwnerItem = splitbuttonTopTenRecords;
			contextMenuTopTenRecords.Size = new Size(250, 362);
			contextMenuTopTenRecords.TabStop = true;
			contextMenuTopTenRecords.Text = "Top ten records";
			toolTip.SetToolTip(contextMenuTopTenRecords, "Top ten records");
			contextMenuTopTenRecords.MouseEnter += SetStatusbar_Enter;
			contextMenuTopTenRecords.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsSortDirection
			// 
			menuitemRecordsSortDirection.AccessibleDescription = "Shows the sort direction of the top ten records";
			menuitemRecordsSortDirection.AccessibleName = "Sort direction";
			menuitemRecordsSortDirection.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemRecordsSortDirection.AutoToolTip = true;
			menuitemRecordsSortDirection.DropDownItems.AddRange(new ToolStripItem[] { menuitemRecordsSortDirectionAscending, menuitemRecordsSortDirectionDescending });
			menuitemRecordsSortDirection.Enabled = false;
			menuitemRecordsSortDirection.Image = Properties.Resources.silk_cog;
			menuitemRecordsSortDirection.Name = "menuitemRecordsSortDirection";
			menuitemRecordsSortDirection.Size = new Size(249, 22);
			menuitemRecordsSortDirection.Text = "Sort direction";
			menuitemRecordsSortDirection.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsSortDirection.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsSortDirectionAscending
			// 
			menuitemRecordsSortDirectionAscending.AccessibleDescription = "Chooses the ascending sort direction of the top ten records";
			menuitemRecordsSortDirectionAscending.AccessibleName = "Sorted ascending";
			menuitemRecordsSortDirectionAscending.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsSortDirectionAscending.Checked = true;
			menuitemRecordsSortDirectionAscending.CheckOnClick = true;
			menuitemRecordsSortDirectionAscending.CheckState = CheckState.Checked;
			menuitemRecordsSortDirectionAscending.Enabled = false;
			menuitemRecordsSortDirectionAscending.Name = "menuitemRecordsSortDirectionAscending";
			menuitemRecordsSortDirectionAscending.Size = new Size(136, 22);
			menuitemRecordsSortDirectionAscending.Text = "Ascending";
			menuitemRecordsSortDirectionAscending.ToolTipText = "Ascending sort direction";
			menuitemRecordsSortDirectionAscending.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsSortDirectionAscending.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsSortDirectionDescending
			// 
			menuitemRecordsSortDirectionDescending.AccessibleDescription = "Chooses the descending sort direction of the top ten records";
			menuitemRecordsSortDirectionDescending.AccessibleName = "Sorted descending";
			menuitemRecordsSortDirectionDescending.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsSortDirectionDescending.CheckOnClick = true;
			menuitemRecordsSortDirectionDescending.Enabled = false;
			menuitemRecordsSortDirectionDescending.Name = "menuitemRecordsSortDirectionDescending";
			menuitemRecordsSortDirectionDescending.Size = new Size(136, 22);
			menuitemRecordsSortDirectionDescending.Text = "Descending";
			menuitemRecordsSortDirectionDescending.ToolTipText = "Descending sort direction";
			menuitemRecordsSortDirectionDescending.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsSortDirectionDescending.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator12
			// 
			toolStripSeparator12.AccessibleDescription = "Just a separator";
			toolStripSeparator12.AccessibleName = "Just a separator";
			toolStripSeparator12.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator12.Name = "toolStripSeparator12";
			toolStripSeparator12.Size = new Size(246, 6);
			toolStripSeparator12.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator12.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsMeanAnomalyAtTheEpoch
			// 
			menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the record of the mean anomaly at the epoch";
			menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleName = "Record of the mean anomaly at the epoch";
			menuitemRecordsMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsMeanAnomalyAtTheEpoch.Enabled = false;
			menuitemRecordsMeanAnomalyAtTheEpoch.Image = (Image)resources.GetObject("menuitemRecordsMeanAnomalyAtTheEpoch.Image");
			menuitemRecordsMeanAnomalyAtTheEpoch.Name = "menuitemRecordsMeanAnomalyAtTheEpoch";
			menuitemRecordsMeanAnomalyAtTheEpoch.Size = new Size(249, 22);
			menuitemRecordsMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch";
			menuitemRecordsMeanAnomalyAtTheEpoch.Click += MenuitemRecordsMeanAnomalyAtTheEpoch_Click;
			menuitemRecordsMeanAnomalyAtTheEpoch.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsMeanAnomalyAtTheEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsArgumentOfPerihelion
			// 
			menuitemRecordsArgumentOfPerihelion.AccessibleDescription = "Shows the record of the argument of the perihelion";
			menuitemRecordsArgumentOfPerihelion.AccessibleName = "Record of the argument of the perihelion";
			menuitemRecordsArgumentOfPerihelion.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsArgumentOfPerihelion.Enabled = false;
			menuitemRecordsArgumentOfPerihelion.Image = (Image)resources.GetObject("menuitemRecordsArgumentOfPerihelion.Image");
			menuitemRecordsArgumentOfPerihelion.Name = "menuitemRecordsArgumentOfPerihelion";
			menuitemRecordsArgumentOfPerihelion.Size = new Size(249, 22);
			menuitemRecordsArgumentOfPerihelion.Text = "Argument of perihelion";
			menuitemRecordsArgumentOfPerihelion.Click += MenuitemRecordsArgumentOfPerihelion_Click;
			menuitemRecordsArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsLongitudeOfTheAscendingNode
			// 
			menuitemRecordsLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the record of the longitude of the ascending node";
			menuitemRecordsLongitudeOfTheAscendingNode.AccessibleName = "Record of the longitude of the ascending node";
			menuitemRecordsLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsLongitudeOfTheAscendingNode.Enabled = false;
			menuitemRecordsLongitudeOfTheAscendingNode.Image = (Image)resources.GetObject("menuitemRecordsLongitudeOfTheAscendingNode.Image");
			menuitemRecordsLongitudeOfTheAscendingNode.Name = "menuitemRecordsLongitudeOfTheAscendingNode";
			menuitemRecordsLongitudeOfTheAscendingNode.Size = new Size(249, 22);
			menuitemRecordsLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node";
			menuitemRecordsLongitudeOfTheAscendingNode.Click += MenuitemRecordsLongitudeOfTheAscendingNode_Click;
			menuitemRecordsLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsInclination
			// 
			menuitemRecordsInclination.AccessibleDescription = "Shows the record of the inclination to the ecliptic";
			menuitemRecordsInclination.AccessibleName = "Record of the inclination to the ecliptic";
			menuitemRecordsInclination.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsInclination.Enabled = false;
			menuitemRecordsInclination.Image = (Image)resources.GetObject("menuitemRecordsInclination.Image");
			menuitemRecordsInclination.Name = "menuitemRecordsInclination";
			menuitemRecordsInclination.Size = new Size(249, 22);
			menuitemRecordsInclination.Text = "Inclination to the ecliptic";
			menuitemRecordsInclination.Click += MenuitemRecordsInclination_Click;
			menuitemRecordsInclination.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsOrbitalEccentricity
			// 
			menuitemRecordsOrbitalEccentricity.AccessibleDescription = "Shows the record of the orbital eccentricity";
			menuitemRecordsOrbitalEccentricity.AccessibleName = "Record of the orbital eccentricity";
			menuitemRecordsOrbitalEccentricity.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsOrbitalEccentricity.Enabled = false;
			menuitemRecordsOrbitalEccentricity.Image = (Image)resources.GetObject("menuitemRecordsOrbitalEccentricity.Image");
			menuitemRecordsOrbitalEccentricity.Name = "menuitemRecordsOrbitalEccentricity";
			menuitemRecordsOrbitalEccentricity.Size = new Size(249, 22);
			menuitemRecordsOrbitalEccentricity.Text = "Orbital eccentricity";
			menuitemRecordsOrbitalEccentricity.Click += MenuitemRecordsOrbitalEccentricity_Click;
			menuitemRecordsOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsMeanDailyMotion
			// 
			menuitemRecordsMeanDailyMotion.AccessibleDescription = "Shows the record of the mean daily motion";
			menuitemRecordsMeanDailyMotion.AccessibleName = "Record of the mean daily motion";
			menuitemRecordsMeanDailyMotion.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsMeanDailyMotion.Enabled = false;
			menuitemRecordsMeanDailyMotion.Image = (Image)resources.GetObject("menuitemRecordsMeanDailyMotion.Image");
			menuitemRecordsMeanDailyMotion.Name = "menuitemRecordsMeanDailyMotion";
			menuitemRecordsMeanDailyMotion.Size = new Size(249, 22);
			menuitemRecordsMeanDailyMotion.Text = "Mean daily motion";
			menuitemRecordsMeanDailyMotion.Click += MenuitemRecordsMeanDailyMotion_Click;
			menuitemRecordsMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsSemiMajorAxis
			// 
			menuitemRecordsSemiMajorAxis.AccessibleDescription = "Shows the record of the semi-major axis";
			menuitemRecordsSemiMajorAxis.AccessibleName = "Record of the semi-major axis";
			menuitemRecordsSemiMajorAxis.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsSemiMajorAxis.Enabled = false;
			menuitemRecordsSemiMajorAxis.Image = (Image)resources.GetObject("menuitemRecordsSemiMajorAxis.Image");
			menuitemRecordsSemiMajorAxis.Name = "menuitemRecordsSemiMajorAxis";
			menuitemRecordsSemiMajorAxis.Size = new Size(249, 22);
			menuitemRecordsSemiMajorAxis.Text = "Semi-major axis";
			menuitemRecordsSemiMajorAxis.Click += MenuitemRecordsSemiMajorAxis_Click;
			menuitemRecordsSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsAbsoluteMagnitude
			// 
			menuitemRecordsAbsoluteMagnitude.AccessibleDescription = "Shows the record of the absolute magnitude";
			menuitemRecordsAbsoluteMagnitude.AccessibleName = "Record of the absolute magnitude";
			menuitemRecordsAbsoluteMagnitude.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsAbsoluteMagnitude.Enabled = false;
			menuitemRecordsAbsoluteMagnitude.Image = (Image)resources.GetObject("menuitemRecordsAbsoluteMagnitude.Image");
			menuitemRecordsAbsoluteMagnitude.Name = "menuitemRecordsAbsoluteMagnitude";
			menuitemRecordsAbsoluteMagnitude.Size = new Size(249, 22);
			menuitemRecordsAbsoluteMagnitude.Text = "Absolute magnitude";
			menuitemRecordsAbsoluteMagnitude.Click += MenuitemRecordsAbsoluteMagnitude_Click;
			menuitemRecordsAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsSlopeParameter
			// 
			menuitemRecordsSlopeParameter.AccessibleDescription = "Shows the record of the slope parameter";
			menuitemRecordsSlopeParameter.AccessibleName = "Record of the slope parameter";
			menuitemRecordsSlopeParameter.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsSlopeParameter.Enabled = false;
			menuitemRecordsSlopeParameter.Image = (Image)resources.GetObject("menuitemRecordsSlopeParameter.Image");
			menuitemRecordsSlopeParameter.Name = "menuitemRecordsSlopeParameter";
			menuitemRecordsSlopeParameter.Size = new Size(249, 22);
			menuitemRecordsSlopeParameter.Text = "Slope parameter";
			menuitemRecordsSlopeParameter.Click += MenuitemRecordsSlopeParameter_Click;
			menuitemRecordsSlopeParameter.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsNumberOfOppositions
			// 
			menuitemRecordsNumberOfOppositions.AccessibleDescription = "Shows the record of the number of oppositions";
			menuitemRecordsNumberOfOppositions.AccessibleName = "Record of the number of oppositions";
			menuitemRecordsNumberOfOppositions.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsNumberOfOppositions.Enabled = false;
			menuitemRecordsNumberOfOppositions.Image = (Image)resources.GetObject("menuitemRecordsNumberOfOppositions.Image");
			menuitemRecordsNumberOfOppositions.Name = "menuitemRecordsNumberOfOppositions";
			menuitemRecordsNumberOfOppositions.Size = new Size(249, 22);
			menuitemRecordsNumberOfOppositions.Text = "Number of oppositions";
			menuitemRecordsNumberOfOppositions.Click += MenuitemRecordsNumberOfOppositions_Click;
			menuitemRecordsNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsNumberOfObservations
			// 
			menuitemRecordsNumberOfObservations.AccessibleDescription = "Shows the record of the number of observations";
			menuitemRecordsNumberOfObservations.AccessibleName = "Record of the number of observations";
			menuitemRecordsNumberOfObservations.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsNumberOfObservations.Enabled = false;
			menuitemRecordsNumberOfObservations.Image = (Image)resources.GetObject("menuitemRecordsNumberOfObservations.Image");
			menuitemRecordsNumberOfObservations.Name = "menuitemRecordsNumberOfObservations";
			menuitemRecordsNumberOfObservations.Size = new Size(249, 22);
			menuitemRecordsNumberOfObservations.Text = "Number of observations";
			menuitemRecordsNumberOfObservations.Click += MenuitemRecordsNumberOfObservations_Click;
			menuitemRecordsNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsObservationSpan
			// 
			menuitemRecordsObservationSpan.AccessibleDescription = "Shows the record of the observation span";
			menuitemRecordsObservationSpan.AccessibleName = "Record of the observation span";
			menuitemRecordsObservationSpan.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsObservationSpan.Enabled = false;
			menuitemRecordsObservationSpan.Image = (Image)resources.GetObject("menuitemRecordsObservationSpan.Image");
			menuitemRecordsObservationSpan.Name = "menuitemRecordsObservationSpan";
			menuitemRecordsObservationSpan.Size = new Size(249, 22);
			menuitemRecordsObservationSpan.Text = "Observation span";
			menuitemRecordsObservationSpan.Click += MenuitemRecordsObservationSpan_Click;
			menuitemRecordsObservationSpan.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsObservationSpan.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsRmsResidual
			// 
			menuitemRecordsRmsResidual.AccessibleDescription = "Shows the record of the r.m.s. residual";
			menuitemRecordsRmsResidual.AccessibleName = "Record of the r.m.s. residual";
			menuitemRecordsRmsResidual.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsRmsResidual.Enabled = false;
			menuitemRecordsRmsResidual.Image = (Image)resources.GetObject("menuitemRecordsRmsResidual.Image");
			menuitemRecordsRmsResidual.Name = "menuitemRecordsRmsResidual";
			menuitemRecordsRmsResidual.Size = new Size(249, 22);
			menuitemRecordsRmsResidual.Text = "r.m.s. residual";
			menuitemRecordsRmsResidual.Click += MenuitemRecordsRmsResidual_Click;
			menuitemRecordsRmsResidual.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsComputername
			// 
			menuitemRecordsComputername.AccessibleDescription = "Shows the record of the computer name";
			menuitemRecordsComputername.AccessibleName = "Record of the computer name";
			menuitemRecordsComputername.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsComputername.Enabled = false;
			menuitemRecordsComputername.Image = (Image)resources.GetObject("menuitemRecordsComputername.Image");
			menuitemRecordsComputername.Name = "menuitemRecordsComputername";
			menuitemRecordsComputername.Size = new Size(249, 22);
			menuitemRecordsComputername.Text = "Computer name";
			menuitemRecordsComputername.Click += MenuitemRecordsComputername_Click;
			menuitemRecordsComputername.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsComputername.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecordsDateOfTheLastObservation
			// 
			menuitemRecordsDateOfTheLastObservation.AccessibleDescription = "Shows the record of the date of the last observation";
			menuitemRecordsDateOfTheLastObservation.AccessibleName = "Record of the date of the last observation";
			menuitemRecordsDateOfTheLastObservation.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecordsDateOfTheLastObservation.Enabled = false;
			menuitemRecordsDateOfTheLastObservation.Image = (Image)resources.GetObject("menuitemRecordsDateOfTheLastObservation.Image");
			menuitemRecordsDateOfTheLastObservation.Name = "menuitemRecordsDateOfTheLastObservation";
			menuitemRecordsDateOfTheLastObservation.Size = new Size(249, 22);
			menuitemRecordsDateOfTheLastObservation.Text = "Date of the last observation";
			menuitemRecordsDateOfTheLastObservation.Click += MenuitemRecordsDateOfTheLastObservation_Click;
			menuitemRecordsDateOfTheLastObservation.MouseEnter += SetStatusbar_Enter;
			menuitemRecordsDateOfTheLastObservation.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRecords
			// 
			menuitemRecords.AccessibleDescription = "Shows some topn ten records";
			menuitemRecords.AccessibleName = "Top ten records";
			menuitemRecords.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRecords.AutoToolTip = true;
			menuitemRecords.DropDown = contextMenuTopTenRecords;
			menuitemRecords.Enabled = false;
			menuitemRecords.Image = Properties.Resources.silk_text_list_numbers;
			menuitemRecords.Name = "menuitemRecords";
			menuitemRecords.ShortcutKeys = Keys.Control | Keys.T;
			menuitemRecords.Size = new Size(227, 22);
			menuitemRecords.Text = "Top ten &records";
			menuitemRecords.Click += MenuitemTopTenRecords_Click;
			menuitemRecords.MouseEnter += SetStatusbar_Enter;
			menuitemRecords.MouseLeave += ClearStatusbar_Leave;
			// 
			// contextMenuDistributions
			// 
			contextMenuDistributions.AccessibleDescription = "Shows the context menu of the distributions";
			contextMenuDistributions.AccessibleName = "context menu of the distributions";
			contextMenuDistributions.AccessibleRole = AccessibleRole.MenuPopup;
			contextMenuDistributions.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			contextMenuDistributions.Items.AddRange(new ToolStripItem[] { menuitemDistributionMeanAnomalyAtTheEpoch, menuitemDistributionArgumentOfPerihelion, menuitemDistributionLongitudeOfTheAscendingNode, menuitemDistributionInclination, menuitemDistributionOrbitalEccentricity, menuitemDistributionMeanDailyMotion, menuitemDistributionSemiMajorAxis, menuitemDistributionAbsoluteMagnitude, menuitemDistributionSlopeParameter, menuitemDistributionNumberOfOppositions, menuitemDistributionNumberOfObservations, menuitemDistributionObservationSpan, menuitemDistributionRmsResidual, menuitemDistributionComputerName });
			contextMenuDistributions.Name = "contextMenuDistributions";
			contextMenuDistributions.OwnerItem = splitbuttonDistribution;
			contextMenuDistributions.Size = new Size(250, 312);
			contextMenuDistributions.Text = "Distributions";
			toolTip.SetToolTip(contextMenuDistributions, "Distributions");
			// 
			// menuitemDistributionMeanAnomalyAtTheEpoch
			// 
			menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the distribution of mean anomaly at the epoch";
			menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleName = "Distribution of mean anomaly at the epoch";
			menuitemDistributionMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionMeanAnomalyAtTheEpoch.AutoToolTip = true;
			menuitemDistributionMeanAnomalyAtTheEpoch.Enabled = false;
			menuitemDistributionMeanAnomalyAtTheEpoch.Image = (Image)resources.GetObject("menuitemDistributionMeanAnomalyAtTheEpoch.Image");
			menuitemDistributionMeanAnomalyAtTheEpoch.Name = "menuitemDistributionMeanAnomalyAtTheEpoch";
			menuitemDistributionMeanAnomalyAtTheEpoch.Size = new Size(249, 22);
			menuitemDistributionMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch";
			menuitemDistributionMeanAnomalyAtTheEpoch.Click += MenuitemDistributionMeanAnomalyAtTheEpoch_Click;
			menuitemDistributionMeanAnomalyAtTheEpoch.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionMeanAnomalyAtTheEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionArgumentOfPerihelion
			// 
			menuitemDistributionArgumentOfPerihelion.AccessibleDescription = "Shows the distribution of the argument of perihelion";
			menuitemDistributionArgumentOfPerihelion.AccessibleName = "Distribution of the argument of perihelion";
			menuitemDistributionArgumentOfPerihelion.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionArgumentOfPerihelion.AutoToolTip = true;
			menuitemDistributionArgumentOfPerihelion.Enabled = false;
			menuitemDistributionArgumentOfPerihelion.Image = (Image)resources.GetObject("menuitemDistributionArgumentOfPerihelion.Image");
			menuitemDistributionArgumentOfPerihelion.Name = "menuitemDistributionArgumentOfPerihelion";
			menuitemDistributionArgumentOfPerihelion.Size = new Size(249, 22);
			menuitemDistributionArgumentOfPerihelion.Text = "Argument of perihelion";
			menuitemDistributionArgumentOfPerihelion.Click += MenuitemDistributionArgumentOfPerihelion_Click;
			menuitemDistributionArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionLongitudeOfTheAscendingNode
			// 
			menuitemDistributionLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the distribution of the longitude of the ascending node";
			menuitemDistributionLongitudeOfTheAscendingNode.AccessibleName = "Distribution of the longitude of the ascending node";
			menuitemDistributionLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionLongitudeOfTheAscendingNode.AutoToolTip = true;
			menuitemDistributionLongitudeOfTheAscendingNode.Enabled = false;
			menuitemDistributionLongitudeOfTheAscendingNode.Image = (Image)resources.GetObject("menuitemDistributionLongitudeOfTheAscendingNode.Image");
			menuitemDistributionLongitudeOfTheAscendingNode.Name = "menuitemDistributionLongitudeOfTheAscendingNode";
			menuitemDistributionLongitudeOfTheAscendingNode.Size = new Size(249, 22);
			menuitemDistributionLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node";
			menuitemDistributionLongitudeOfTheAscendingNode.Click += MenuitemDistributionLongitudeOfTheAscendingNode_Click;
			menuitemDistributionLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionInclination
			// 
			menuitemDistributionInclination.AccessibleDescription = "Shows the distribution of the inclination to the ecliptic";
			menuitemDistributionInclination.AccessibleName = "Distribution of the inclination to the ecliptic";
			menuitemDistributionInclination.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionInclination.AutoToolTip = true;
			menuitemDistributionInclination.Enabled = false;
			menuitemDistributionInclination.Image = (Image)resources.GetObject("menuitemDistributionInclination.Image");
			menuitemDistributionInclination.Name = "menuitemDistributionInclination";
			menuitemDistributionInclination.Size = new Size(249, 22);
			menuitemDistributionInclination.Text = "Inclination to the ecliptic";
			menuitemDistributionInclination.Click += MenuitemDistributionInclination_Click;
			menuitemDistributionInclination.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionOrbitalEccentricity
			// 
			menuitemDistributionOrbitalEccentricity.AccessibleDescription = "Shows the distribution of the orbital eccentricity";
			menuitemDistributionOrbitalEccentricity.AccessibleName = "Distribution of the orbital eccentricity";
			menuitemDistributionOrbitalEccentricity.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionOrbitalEccentricity.AutoToolTip = true;
			menuitemDistributionOrbitalEccentricity.Enabled = false;
			menuitemDistributionOrbitalEccentricity.Image = (Image)resources.GetObject("menuitemDistributionOrbitalEccentricity.Image");
			menuitemDistributionOrbitalEccentricity.Name = "menuitemDistributionOrbitalEccentricity";
			menuitemDistributionOrbitalEccentricity.Size = new Size(249, 22);
			menuitemDistributionOrbitalEccentricity.Text = "Orbital eccentricity";
			menuitemDistributionOrbitalEccentricity.Click += MenuitemDistributionOrbitalEccentricity_Click;
			menuitemDistributionOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionMeanDailyMotion
			// 
			menuitemDistributionMeanDailyMotion.AccessibleDescription = "Shows the distribution of the mean daily motion";
			menuitemDistributionMeanDailyMotion.AccessibleName = "Distribution of the mean daily motion";
			menuitemDistributionMeanDailyMotion.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionMeanDailyMotion.AutoToolTip = true;
			menuitemDistributionMeanDailyMotion.Enabled = false;
			menuitemDistributionMeanDailyMotion.Image = (Image)resources.GetObject("menuitemDistributionMeanDailyMotion.Image");
			menuitemDistributionMeanDailyMotion.Name = "menuitemDistributionMeanDailyMotion";
			menuitemDistributionMeanDailyMotion.Size = new Size(249, 22);
			menuitemDistributionMeanDailyMotion.Text = "Mean daily motion";
			menuitemDistributionMeanDailyMotion.Click += MenuitemDistributionMeanDailyMotion_Click;
			menuitemDistributionMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionSemiMajorAxis
			// 
			menuitemDistributionSemiMajorAxis.AccessibleDescription = "Shows the distribution of the semi-major axis";
			menuitemDistributionSemiMajorAxis.AccessibleName = "Distribution of the semi-major axis";
			menuitemDistributionSemiMajorAxis.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionSemiMajorAxis.AutoToolTip = true;
			menuitemDistributionSemiMajorAxis.Enabled = false;
			menuitemDistributionSemiMajorAxis.Image = (Image)resources.GetObject("menuitemDistributionSemiMajorAxis.Image");
			menuitemDistributionSemiMajorAxis.Name = "menuitemDistributionSemiMajorAxis";
			menuitemDistributionSemiMajorAxis.Size = new Size(249, 22);
			menuitemDistributionSemiMajorAxis.Text = "Semi-major axis";
			menuitemDistributionSemiMajorAxis.Click += MenuitemDistributionSemiMajorAxis_Click;
			menuitemDistributionSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionAbsoluteMagnitude
			// 
			menuitemDistributionAbsoluteMagnitude.AccessibleDescription = "Shows the distribution of the absolute magnitude";
			menuitemDistributionAbsoluteMagnitude.AccessibleName = "Distribution of the absolute magnitude";
			menuitemDistributionAbsoluteMagnitude.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionAbsoluteMagnitude.AutoToolTip = true;
			menuitemDistributionAbsoluteMagnitude.Enabled = false;
			menuitemDistributionAbsoluteMagnitude.Image = (Image)resources.GetObject("menuitemDistributionAbsoluteMagnitude.Image");
			menuitemDistributionAbsoluteMagnitude.Name = "menuitemDistributionAbsoluteMagnitude";
			menuitemDistributionAbsoluteMagnitude.Size = new Size(249, 22);
			menuitemDistributionAbsoluteMagnitude.Text = "Absolute magnitude";
			menuitemDistributionAbsoluteMagnitude.Click += MenuitemDistributionAbsoluteMagnitude_Click;
			menuitemDistributionAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionSlopeParameter
			// 
			menuitemDistributionSlopeParameter.AccessibleDescription = "Shows the distribution of the slope parameter";
			menuitemDistributionSlopeParameter.AccessibleName = "Distribution of the slope parameter";
			menuitemDistributionSlopeParameter.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionSlopeParameter.AutoToolTip = true;
			menuitemDistributionSlopeParameter.Enabled = false;
			menuitemDistributionSlopeParameter.Image = (Image)resources.GetObject("menuitemDistributionSlopeParameter.Image");
			menuitemDistributionSlopeParameter.Name = "menuitemDistributionSlopeParameter";
			menuitemDistributionSlopeParameter.Size = new Size(249, 22);
			menuitemDistributionSlopeParameter.Text = "Slope parameter";
			menuitemDistributionSlopeParameter.Click += MenuitemDistributionSlopeParameter_Click;
			menuitemDistributionSlopeParameter.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionNumberOfOppositions
			// 
			menuitemDistributionNumberOfOppositions.AccessibleDescription = "Shows the distribution of the number of oppositions";
			menuitemDistributionNumberOfOppositions.AccessibleName = "Distribution of the number of oppositions";
			menuitemDistributionNumberOfOppositions.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionNumberOfOppositions.AutoToolTip = true;
			menuitemDistributionNumberOfOppositions.Enabled = false;
			menuitemDistributionNumberOfOppositions.Image = (Image)resources.GetObject("menuitemDistributionNumberOfOppositions.Image");
			menuitemDistributionNumberOfOppositions.Name = "menuitemDistributionNumberOfOppositions";
			menuitemDistributionNumberOfOppositions.Size = new Size(249, 22);
			menuitemDistributionNumberOfOppositions.Text = "Number of oppositions";
			menuitemDistributionNumberOfOppositions.Click += MenuitemDistributionNumberOfOppositions_Click;
			menuitemDistributionNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionNumberOfObservations
			// 
			menuitemDistributionNumberOfObservations.AccessibleDescription = "Show the distribution of the number of observations";
			menuitemDistributionNumberOfObservations.AccessibleName = "Distribution of the number of observations";
			menuitemDistributionNumberOfObservations.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionNumberOfObservations.AutoToolTip = true;
			menuitemDistributionNumberOfObservations.Enabled = false;
			menuitemDistributionNumberOfObservations.Image = (Image)resources.GetObject("menuitemDistributionNumberOfObservations.Image");
			menuitemDistributionNumberOfObservations.Name = "menuitemDistributionNumberOfObservations";
			menuitemDistributionNumberOfObservations.Size = new Size(249, 22);
			menuitemDistributionNumberOfObservations.Text = "Number of observations";
			menuitemDistributionNumberOfObservations.Click += MenuitemDistributionNumberOfObservations_Click;
			menuitemDistributionNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionObservationSpan
			// 
			menuitemDistributionObservationSpan.AccessibleDescription = "Shows the distribution of the observation span";
			menuitemDistributionObservationSpan.AccessibleName = "Distribution of the observation span";
			menuitemDistributionObservationSpan.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionObservationSpan.AutoToolTip = true;
			menuitemDistributionObservationSpan.Enabled = false;
			menuitemDistributionObservationSpan.Image = (Image)resources.GetObject("menuitemDistributionObservationSpan.Image");
			menuitemDistributionObservationSpan.Name = "menuitemDistributionObservationSpan";
			menuitemDistributionObservationSpan.Size = new Size(249, 22);
			menuitemDistributionObservationSpan.Text = "Observation span";
			menuitemDistributionObservationSpan.Click += MenuitemDistributionObservationSpan_Click;
			menuitemDistributionObservationSpan.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionObservationSpan.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionRmsResidual
			// 
			menuitemDistributionRmsResidual.AccessibleDescription = "Shows the distribution of the r.m.s. residual";
			menuitemDistributionRmsResidual.AccessibleName = "Distribution of the r.m.s. residual";
			menuitemDistributionRmsResidual.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionRmsResidual.AutoToolTip = true;
			menuitemDistributionRmsResidual.Enabled = false;
			menuitemDistributionRmsResidual.Image = (Image)resources.GetObject("menuitemDistributionRmsResidual.Image");
			menuitemDistributionRmsResidual.Name = "menuitemDistributionRmsResidual";
			menuitemDistributionRmsResidual.Size = new Size(249, 22);
			menuitemDistributionRmsResidual.Text = "r.m.s. residual";
			menuitemDistributionRmsResidual.Click += MenuitemDistributionRmsResidual_Click;
			menuitemDistributionRmsResidual.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistributionComputerName
			// 
			menuitemDistributionComputerName.AccessibleDescription = "Shows the distribution of the computer name";
			menuitemDistributionComputerName.AccessibleName = "Distribution of the computer name";
			menuitemDistributionComputerName.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistributionComputerName.AutoToolTip = true;
			menuitemDistributionComputerName.Enabled = false;
			menuitemDistributionComputerName.Image = (Image)resources.GetObject("menuitemDistributionComputerName.Image");
			menuitemDistributionComputerName.Name = "menuitemDistributionComputerName";
			menuitemDistributionComputerName.Size = new Size(249, 22);
			menuitemDistributionComputerName.Text = "Computer name";
			menuitemDistributionComputerName.Click += MenuitemDistributionComputerName_Click;
			menuitemDistributionComputerName.MouseEnter += SetStatusbar_Enter;
			menuitemDistributionComputerName.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDistribution
			// 
			menuitemDistribution.AccessibleDescription = "Shows some distributions";
			menuitemDistribution.AccessibleName = "Distributions";
			menuitemDistribution.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDistribution.AutoToolTip = true;
			menuitemDistribution.DoubleClickEnabled = true;
			menuitemDistribution.DropDown = contextMenuDistributions;
			menuitemDistribution.Enabled = false;
			menuitemDistribution.Image = Properties.Resources.silk_chart_bar;
			menuitemDistribution.Name = "menuitemDistribution";
			menuitemDistribution.ShortcutKeys = Keys.Control | Keys.D;
			menuitemDistribution.Size = new Size(227, 22);
			menuitemDistribution.Text = "&Distributions";
			menuitemDistribution.Click += MenuitemDistribution_Click;
			menuitemDistribution.MouseEnter += SetStatusbar_Enter;
			menuitemDistribution.MouseLeave += ClearStatusbar_Leave;
			// 
			// contextMenuCopyToClipboardOrbitalElements
			// 
			contextMenuCopyToClipboardOrbitalElements.AccessibleDescription = "Shows the context menu of the orbital elements to copy to clipboard";
			contextMenuCopyToClipboardOrbitalElements.AccessibleName = "context menu of the orbital elements to copy to clipboard";
			contextMenuCopyToClipboardOrbitalElements.AccessibleRole = AccessibleRole.MenuPopup;
			contextMenuCopyToClipboardOrbitalElements.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			contextMenuCopyToClipboardOrbitalElements.Items.AddRange(new ToolStripItem[] { menuitemCopyToClipboardIndexNumber, menuitemCopyToClipboardReadableDesignation, menuitemCopyToClipboardEpoch, menuitemCopyToClipboardMeanAnomalyAtTheEpoch, menuitemCopyToClipboardArgumentOfPerihelion, menuitemCopyToClipboardLongitudeOfTheAscendingNode, menuitemCopyToClipboardInclinationToTheEcliptic, menuitemCopyToClipboardOrbitalEccentricity, menuitemCopyToClipboardMeanDailyMotion, menuitemCopyToClipboardSemiMajorAxis, menuitemCopyToClipboardAbsoluteMagnitude, menuitemCopyToClipboardSlopeParameter, menuitemCopyToClipboardReference, menuitemCopyToClipboardNumberOfOppositions, menuitemCopyToClipboardNumberOfObservations, menuitemCopyToClipboardObservationSpan, menuitemCopyToClipboardRmsResidual, menuitemCopyToClipboardComputerName, menuitemCopyToClipboardDateOfTheLastObservation, menuitemCopyToClipboardFlags });
			contextMenuCopyToClipboardOrbitalElements.Name = "contextMenuCopyToClipboardOrbitalElements";
			contextMenuCopyToClipboardOrbitalElements.OwnerItem = splitbuttonCopyToClipboard;
			contextMenuCopyToClipboardOrbitalElements.Size = new Size(309, 444);
			contextMenuCopyToClipboardOrbitalElements.Text = "Copy to clipboard";
			toolTip.SetToolTip(contextMenuCopyToClipboardOrbitalElements, "Copy to clipboard");
			// 
			// menuitemCopyToClipboardIndexNumber
			// 
			menuitemCopyToClipboardIndexNumber.AccessibleDescription = "Copy to clipboard: Index number";
			menuitemCopyToClipboardIndexNumber.AccessibleName = "Copy to clipboard: Index number";
			menuitemCopyToClipboardIndexNumber.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardIndexNumber.AutoToolTip = true;
			menuitemCopyToClipboardIndexNumber.Image = (Image)resources.GetObject("menuitemCopyToClipboardIndexNumber.Image");
			menuitemCopyToClipboardIndexNumber.Name = "menuitemCopyToClipboardIndexNumber";
			menuitemCopyToClipboardIndexNumber.Size = new Size(308, 22);
			menuitemCopyToClipboardIndexNumber.Text = "Index No.";
			menuitemCopyToClipboardIndexNumber.Click += ToolStripMenuItemCopyToClipboardIndexNumber_Click;
			menuitemCopyToClipboardIndexNumber.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardIndexNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardReadableDesignation
			// 
			menuitemCopyToClipboardReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			menuitemCopyToClipboardReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			menuitemCopyToClipboardReadableDesignation.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardReadableDesignation.AutoToolTip = true;
			menuitemCopyToClipboardReadableDesignation.Image = (Image)resources.GetObject("menuitemCopyToClipboardReadableDesignation.Image");
			menuitemCopyToClipboardReadableDesignation.Name = "menuitemCopyToClipboardReadableDesignation";
			menuitemCopyToClipboardReadableDesignation.Size = new Size(308, 22);
			menuitemCopyToClipboardReadableDesignation.Text = "Readable designation";
			menuitemCopyToClipboardReadableDesignation.Click += ToolStripMenuItemCopyToClipboardReadableDesignation_Click;
			menuitemCopyToClipboardReadableDesignation.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardReadableDesignation.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardEpoch
			// 
			menuitemCopyToClipboardEpoch.AccessibleDescription = "Copy to clipboard: Epoch";
			menuitemCopyToClipboardEpoch.AccessibleName = "Copy to clipboard: Epoch";
			menuitemCopyToClipboardEpoch.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardEpoch.AutoToolTip = true;
			menuitemCopyToClipboardEpoch.Image = (Image)resources.GetObject("menuitemCopyToClipboardEpoch.Image");
			menuitemCopyToClipboardEpoch.Name = "menuitemCopyToClipboardEpoch";
			menuitemCopyToClipboardEpoch.Size = new Size(308, 22);
			menuitemCopyToClipboardEpoch.Text = "Epoch (in packed form, .0 TT)";
			menuitemCopyToClipboardEpoch.Click += ToolStripMenuItemCopyToClipboardEpoch_Click;
			menuitemCopyToClipboardEpoch.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardMeanAnomalyAtTheEpoch
			// 
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch";
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch";
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.AutoToolTip = true;
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Image = (Image)resources.GetObject("menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Image");
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Name = "menuitemCopyToClipboardMeanAnomalyAtTheEpoch";
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Size = new Size(308, 22);
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Text = "Mean anomaly at the epoch (°)";
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.Click += ToolStripMenuItemCopyToClipboardMeanAnomaly_Click;
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardMeanAnomalyAtTheEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardArgumentOfPerihelion
			// 
			menuitemCopyToClipboardArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion";
			menuitemCopyToClipboardArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion";
			menuitemCopyToClipboardArgumentOfPerihelion.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardArgumentOfPerihelion.AutoToolTip = true;
			menuitemCopyToClipboardArgumentOfPerihelion.Image = (Image)resources.GetObject("menuitemCopyToClipboardArgumentOfPerihelion.Image");
			menuitemCopyToClipboardArgumentOfPerihelion.Name = "menuitemCopyToClipboardArgumentOfPerihelion";
			menuitemCopyToClipboardArgumentOfPerihelion.Size = new Size(308, 22);
			menuitemCopyToClipboardArgumentOfPerihelion.Text = "Argument of perihelion, J2000.0 (°)";
			menuitemCopyToClipboardArgumentOfPerihelion.Click += ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click;
			menuitemCopyToClipboardArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardLongitudeOfTheAscendingNode
			// 
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node";
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node";
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.AutoToolTip = true;
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.Image = (Image)resources.GetObject("menuitemCopyToClipboardLongitudeOfTheAscendingNode.Image");
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.Name = "menuitemCopyToClipboardLongitudeOfTheAscendingNode";
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.Size = new Size(308, 22);
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.Text = "Longitude of the ascending node, J2000.0 (°)";
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.Click += ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click;
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardInclinationToTheEcliptic
			// 
			menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleDescription = "Copy to clipboard: Inclination";
			menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleName = "Copy to clipboard: Inclination";
			menuitemCopyToClipboardInclinationToTheEcliptic.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardInclinationToTheEcliptic.AutoToolTip = true;
			menuitemCopyToClipboardInclinationToTheEcliptic.Image = (Image)resources.GetObject("menuitemCopyToClipboardInclinationToTheEcliptic.Image");
			menuitemCopyToClipboardInclinationToTheEcliptic.Name = "menuitemCopyToClipboardInclinationToTheEcliptic";
			menuitemCopyToClipboardInclinationToTheEcliptic.Size = new Size(308, 22);
			menuitemCopyToClipboardInclinationToTheEcliptic.Text = "Inclination to the ecliptic, J2000.0 (°)";
			menuitemCopyToClipboardInclinationToTheEcliptic.Click += ToolStripMenuItemCopyToClipboardInclinationToTheEcliptic_Click;
			menuitemCopyToClipboardInclinationToTheEcliptic.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardInclinationToTheEcliptic.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardOrbitalEccentricity
			// 
			menuitemCopyToClipboardOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			menuitemCopyToClipboardOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			menuitemCopyToClipboardOrbitalEccentricity.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardOrbitalEccentricity.AutoToolTip = true;
			menuitemCopyToClipboardOrbitalEccentricity.Image = (Image)resources.GetObject("menuitemCopyToClipboardOrbitalEccentricity.Image");
			menuitemCopyToClipboardOrbitalEccentricity.Name = "menuitemCopyToClipboardOrbitalEccentricity";
			menuitemCopyToClipboardOrbitalEccentricity.Size = new Size(308, 22);
			menuitemCopyToClipboardOrbitalEccentricity.Text = "Orbital eccentricity";
			menuitemCopyToClipboardOrbitalEccentricity.Click += ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click;
			menuitemCopyToClipboardOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardMeanDailyMotion
			// 
			menuitemCopyToClipboardMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion";
			menuitemCopyToClipboardMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion";
			menuitemCopyToClipboardMeanDailyMotion.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardMeanDailyMotion.AutoToolTip = true;
			menuitemCopyToClipboardMeanDailyMotion.Image = (Image)resources.GetObject("menuitemCopyToClipboardMeanDailyMotion.Image");
			menuitemCopyToClipboardMeanDailyMotion.Name = "menuitemCopyToClipboardMeanDailyMotion";
			menuitemCopyToClipboardMeanDailyMotion.Size = new Size(308, 22);
			menuitemCopyToClipboardMeanDailyMotion.Text = "Mean daily motion (°/day)";
			menuitemCopyToClipboardMeanDailyMotion.Click += ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click;
			menuitemCopyToClipboardMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardSemiMajorAxis
			// 
			menuitemCopyToClipboardSemiMajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis";
			menuitemCopyToClipboardSemiMajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis";
			menuitemCopyToClipboardSemiMajorAxis.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardSemiMajorAxis.AutoToolTip = true;
			menuitemCopyToClipboardSemiMajorAxis.Image = (Image)resources.GetObject("menuitemCopyToClipboardSemiMajorAxis.Image");
			menuitemCopyToClipboardSemiMajorAxis.Name = "menuitemCopyToClipboardSemiMajorAxis";
			menuitemCopyToClipboardSemiMajorAxis.Size = new Size(308, 22);
			menuitemCopyToClipboardSemiMajorAxis.Text = "Semi-major axis (AU)";
			menuitemCopyToClipboardSemiMajorAxis.Click += ToolStripMenuItemCopyToClipboardSemiMajorAxis_Click;
			menuitemCopyToClipboardSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardAbsoluteMagnitude
			// 
			menuitemCopyToClipboardAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude";
			menuitemCopyToClipboardAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude";
			menuitemCopyToClipboardAbsoluteMagnitude.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardAbsoluteMagnitude.AutoToolTip = true;
			menuitemCopyToClipboardAbsoluteMagnitude.Image = (Image)resources.GetObject("menuitemCopyToClipboardAbsoluteMagnitude.Image");
			menuitemCopyToClipboardAbsoluteMagnitude.Name = "menuitemCopyToClipboardAbsoluteMagnitude";
			menuitemCopyToClipboardAbsoluteMagnitude.Size = new Size(308, 22);
			menuitemCopyToClipboardAbsoluteMagnitude.Text = "Absolute magnitude, H";
			menuitemCopyToClipboardAbsoluteMagnitude.Click += ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click;
			menuitemCopyToClipboardAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardSlopeParameter
			// 
			menuitemCopyToClipboardSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter";
			menuitemCopyToClipboardSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter";
			menuitemCopyToClipboardSlopeParameter.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardSlopeParameter.AutoToolTip = true;
			menuitemCopyToClipboardSlopeParameter.Image = (Image)resources.GetObject("menuitemCopyToClipboardSlopeParameter.Image");
			menuitemCopyToClipboardSlopeParameter.Name = "menuitemCopyToClipboardSlopeParameter";
			menuitemCopyToClipboardSlopeParameter.Size = new Size(308, 22);
			menuitemCopyToClipboardSlopeParameter.Text = "Slope parameter, G";
			menuitemCopyToClipboardSlopeParameter.Click += ToolStripMenuItemCopyToClipboardSlopeParameter_Click;
			menuitemCopyToClipboardSlopeParameter.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardReference
			// 
			menuitemCopyToClipboardReference.AccessibleDescription = "Copy to clipboard: Reference";
			menuitemCopyToClipboardReference.AccessibleName = "Copy to clipboard: Reference";
			menuitemCopyToClipboardReference.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardReference.AutoToolTip = true;
			menuitemCopyToClipboardReference.Image = (Image)resources.GetObject("menuitemCopyToClipboardReference.Image");
			menuitemCopyToClipboardReference.Name = "menuitemCopyToClipboardReference";
			menuitemCopyToClipboardReference.Size = new Size(308, 22);
			menuitemCopyToClipboardReference.Text = "Reference";
			menuitemCopyToClipboardReference.Click += ToolStripMenuItemCopyToClipboardReference_Click;
			menuitemCopyToClipboardReference.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardReference.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardNumberOfOppositions
			// 
			menuitemCopyToClipboardNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			menuitemCopyToClipboardNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions ";
			menuitemCopyToClipboardNumberOfOppositions.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardNumberOfOppositions.AutoToolTip = true;
			menuitemCopyToClipboardNumberOfOppositions.Image = (Image)resources.GetObject("menuitemCopyToClipboardNumberOfOppositions.Image");
			menuitemCopyToClipboardNumberOfOppositions.Name = "menuitemCopyToClipboardNumberOfOppositions";
			menuitemCopyToClipboardNumberOfOppositions.Size = new Size(308, 22);
			menuitemCopyToClipboardNumberOfOppositions.Text = "Number of oppositions";
			menuitemCopyToClipboardNumberOfOppositions.Click += ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click;
			menuitemCopyToClipboardNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardNumberOfObservations
			// 
			menuitemCopyToClipboardNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			menuitemCopyToClipboardNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			menuitemCopyToClipboardNumberOfObservations.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardNumberOfObservations.AutoToolTip = true;
			menuitemCopyToClipboardNumberOfObservations.Image = (Image)resources.GetObject("menuitemCopyToClipboardNumberOfObservations.Image");
			menuitemCopyToClipboardNumberOfObservations.Name = "menuitemCopyToClipboardNumberOfObservations";
			menuitemCopyToClipboardNumberOfObservations.Size = new Size(308, 22);
			menuitemCopyToClipboardNumberOfObservations.Text = "Number of observations";
			menuitemCopyToClipboardNumberOfObservations.Click += ToolStripMenuItemCopyToClipboardNumberOfObservations_Click;
			menuitemCopyToClipboardNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardObservationSpan
			// 
			menuitemCopyToClipboardObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			menuitemCopyToClipboardObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			menuitemCopyToClipboardObservationSpan.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardObservationSpan.AutoToolTip = true;
			menuitemCopyToClipboardObservationSpan.Image = (Image)resources.GetObject("menuitemCopyToClipboardObservationSpan.Image");
			menuitemCopyToClipboardObservationSpan.Name = "menuitemCopyToClipboardObservationSpan";
			menuitemCopyToClipboardObservationSpan.Size = new Size(308, 22);
			menuitemCopyToClipboardObservationSpan.Text = "Observation span";
			menuitemCopyToClipboardObservationSpan.Click += ToolStripMenuItemCopyToClipboardObservationSpan_Click;
			menuitemCopyToClipboardObservationSpan.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardObservationSpan.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardRmsResidual
			// 
			menuitemCopyToClipboardRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual";
			menuitemCopyToClipboardRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual";
			menuitemCopyToClipboardRmsResidual.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardRmsResidual.AutoToolTip = true;
			menuitemCopyToClipboardRmsResidual.Image = (Image)resources.GetObject("menuitemCopyToClipboardRmsResidual.Image");
			menuitemCopyToClipboardRmsResidual.Name = "menuitemCopyToClipboardRmsResidual";
			menuitemCopyToClipboardRmsResidual.Size = new Size(308, 22);
			menuitemCopyToClipboardRmsResidual.Text = "r.m.s. residual (\")";
			menuitemCopyToClipboardRmsResidual.Click += ToolStripMenuItemCopyToClipboardRmsResidual_Click;
			menuitemCopyToClipboardRmsResidual.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardComputerName
			// 
			menuitemCopyToClipboardComputerName.AccessibleDescription = "Copy to clipboard: Computer name";
			menuitemCopyToClipboardComputerName.AccessibleName = "Copy to clipboard: Computer name";
			menuitemCopyToClipboardComputerName.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardComputerName.AutoToolTip = true;
			menuitemCopyToClipboardComputerName.Image = (Image)resources.GetObject("menuitemCopyToClipboardComputerName.Image");
			menuitemCopyToClipboardComputerName.Name = "menuitemCopyToClipboardComputerName";
			menuitemCopyToClipboardComputerName.Size = new Size(308, 22);
			menuitemCopyToClipboardComputerName.Text = "Computer name";
			menuitemCopyToClipboardComputerName.Click += ToolStripMenuItemCopyToClipboardComputerName_Click;
			menuitemCopyToClipboardComputerName.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardComputerName.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardDateOfTheLastObservation
			// 
			menuitemCopyToClipboardDateOfTheLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation";
			menuitemCopyToClipboardDateOfTheLastObservation.AccessibleName = "Copy to clipboard: Date of last observation";
			menuitemCopyToClipboardDateOfTheLastObservation.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardDateOfTheLastObservation.AutoToolTip = true;
			menuitemCopyToClipboardDateOfTheLastObservation.Image = (Image)resources.GetObject("menuitemCopyToClipboardDateOfTheLastObservation.Image");
			menuitemCopyToClipboardDateOfTheLastObservation.Name = "menuitemCopyToClipboardDateOfTheLastObservation";
			menuitemCopyToClipboardDateOfTheLastObservation.Size = new Size(308, 22);
			menuitemCopyToClipboardDateOfTheLastObservation.Text = "Date of last observation";
			menuitemCopyToClipboardDateOfTheLastObservation.Click += ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click;
			menuitemCopyToClipboardDateOfTheLastObservation.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardDateOfTheLastObservation.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopyToClipboardFlags
			// 
			menuitemCopyToClipboardFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			menuitemCopyToClipboardFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			menuitemCopyToClipboardFlags.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopyToClipboardFlags.AutoToolTip = true;
			menuitemCopyToClipboardFlags.Image = (Image)resources.GetObject("menuitemCopyToClipboardFlags.Image");
			menuitemCopyToClipboardFlags.Name = "menuitemCopyToClipboardFlags";
			menuitemCopyToClipboardFlags.Size = new Size(308, 22);
			menuitemCopyToClipboardFlags.Text = "4-hexdigit flags";
			menuitemCopyToClipboardFlags.Click += MenuitemRecordsDateOfTheLastObservation_Click;
			menuitemCopyToClipboardFlags.MouseEnter += SetStatusbar_Enter;
			menuitemCopyToClipboardFlags.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCopytoClipboard
			// 
			menuitemCopytoClipboard.AccessibleDescription = "Copy to clipboard";
			menuitemCopytoClipboard.AccessibleName = "Copy to clipboard";
			menuitemCopytoClipboard.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCopytoClipboard.AutoToolTip = true;
			menuitemCopytoClipboard.DoubleClickEnabled = true;
			menuitemCopytoClipboard.DropDown = contextMenuCopyToClipboardOrbitalElements;
			menuitemCopytoClipboard.Image = Properties.Resources.silk_page_copy;
			menuitemCopytoClipboard.Name = "menuitemCopytoClipboard";
			menuitemCopytoClipboard.ShortcutKeys = Keys.Control | Keys.C;
			menuitemCopytoClipboard.Size = new Size(151, 22);
			menuitemCopytoClipboard.Text = "&Copy";
			menuitemCopytoClipboard.Click += ToolStripButtonCopyToClipboard_Click;
			menuitemCopytoClipboard.MouseEnter += SetStatusbar_Enter;
			menuitemCopytoClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// menu
			// 
			menu.AccessibleDescription = "Shows the menubar";
			menu.AccessibleName = "menu";
			menu.AccessibleRole = AccessibleRole.MenuBar;
			menu.AllowItemReorder = true;
			menu.Dock = DockStyle.None;
			menu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			menu.GripMargin = new Padding(0);
			menu.GripStyle = ToolStripGripStyle.Visible;
			menu.Items.AddRange(new ToolStripItem[] { menuitemFile, menuitemEdit, menuitemNavigation, menuitemTools, menuitemUpdate, menuitemOptions, menuitemHelp });
			menu.Location = new Point(0, 0);
			menu.Name = "menu";
			menu.Padding = new Padding(2, 0, 0, 0);
			menu.ShowItemToolTips = true;
			menu.Size = new Size(804, 24);
			menu.TabIndex = 0;
			menu.Text = "menu";
			toolTip.SetToolTip(menu, "Menu");
			menu.Enter += SetStatusbar_Enter;
			menu.Leave += ClearStatusbar_Leave;
			menu.MouseEnter += SetStatusbar_Enter;
			menu.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemFile
			// 
			menuitemFile.AccessibleDescription = "Opens the menu \"file\"";
			menuitemFile.AccessibleName = "File";
			menuitemFile.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemFile.AutoToolTip = true;
			menuitemFile.DropDownItems.AddRange(new ToolStripItem[] { menuitemOpenALocalMpcorbdatFile, toolStripSeparator13, menuitemExportDataEntry, menuitemPrint, toolStripSeparatorFile1, menuitemRestart, menuitemRestartWithDemoData, menuitemExit });
			menuitemFile.Name = "menuitemFile";
			menuitemFile.ShortcutKeys = Keys.Alt | Keys.F;
			menuitemFile.Size = new Size(37, 24);
			menuitemFile.Text = "&File";
			menuitemFile.MouseEnter += SetStatusbar_Enter;
			menuitemFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOpenALocalMpcorbdatFile
			// 
			menuitemOpenALocalMpcorbdatFile.AccessibleDescription = "Opens a local MPCORB.DAT file";
			menuitemOpenALocalMpcorbdatFile.AccessibleName = "Open";
			menuitemOpenALocalMpcorbdatFile.AccessibleRole = AccessibleRole.MenuItem;
			menuitemOpenALocalMpcorbdatFile.AutoToolTip = true;
			menuitemOpenALocalMpcorbdatFile.Enabled = false;
			menuitemOpenALocalMpcorbdatFile.Image = Properties.Resources.silk_folder;
			menuitemOpenALocalMpcorbdatFile.Name = "menuitemOpenALocalMpcorbdatFile";
			menuitemOpenALocalMpcorbdatFile.Size = new Size(326, 22);
			menuitemOpenALocalMpcorbdatFile.Text = "&Open a local MPCORB.DAT file";
			menuitemOpenALocalMpcorbdatFile.Click += MenuitemOpenALocalMpcorbdatFile_Click;
			menuitemOpenALocalMpcorbdatFile.MouseEnter += SetStatusbar_Enter;
			menuitemOpenALocalMpcorbdatFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator13
			// 
			toolStripSeparator13.AccessibleDescription = "Just a separator";
			toolStripSeparator13.AccessibleName = "Just a separator";
			toolStripSeparator13.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator13.Name = "toolStripSeparator13";
			toolStripSeparator13.Size = new Size(323, 6);
			toolStripSeparator13.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator13.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemExportDataEntry
			// 
			menuitemExportDataEntry.AccessibleDescription = "Exports data entry";
			menuitemExportDataEntry.AccessibleName = "Export";
			menuitemExportDataEntry.AccessibleRole = AccessibleRole.MenuItem;
			menuitemExportDataEntry.AutoToolTip = true;
			menuitemExportDataEntry.Image = Properties.Resources.silk_page_save;
			menuitemExportDataEntry.Name = "menuitemExportDataEntry";
			menuitemExportDataEntry.Size = new Size(326, 22);
			menuitemExportDataEntry.Text = "&Export data entry";
			menuitemExportDataEntry.Click += ToolStripSplitButtonExport_Click;
			menuitemExportDataEntry.MouseEnter += SetStatusbar_Enter;
			menuitemExportDataEntry.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemPrint
			// 
			menuitemPrint.AccessibleDescription = "Prints the information";
			menuitemPrint.AccessibleName = "Print";
			menuitemPrint.AccessibleRole = AccessibleRole.MenuItem;
			menuitemPrint.AutoToolTip = true;
			menuitemPrint.Image = Properties.Resources.silk_printer;
			menuitemPrint.Name = "menuitemPrint";
			menuitemPrint.Size = new Size(326, 22);
			menuitemPrint.Text = "&Print data sheet";
			menuitemPrint.Click += ToolStripMenuItemPrint_Click;
			menuitemPrint.MouseEnter += SetStatusbar_Enter;
			menuitemPrint.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparatorFile1
			// 
			toolStripSeparatorFile1.AccessibleDescription = "Just a separator";
			toolStripSeparatorFile1.AccessibleName = "Just a separator";
			toolStripSeparatorFile1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			toolStripSeparatorFile1.Size = new Size(323, 6);
			toolStripSeparatorFile1.MouseEnter += SetStatusbar_Enter;
			toolStripSeparatorFile1.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRestart
			// 
			menuitemRestart.AccessibleDescription = "Restarts the application";
			menuitemRestart.AccessibleName = "Restart";
			menuitemRestart.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRestart.AutoToolTip = true;
			menuitemRestart.Image = Properties.Resources.silk_reload;
			menuitemRestart.Name = "menuitemRestart";
			menuitemRestart.ShortcutKeys = Keys.Alt | Keys.F3;
			menuitemRestart.Size = new Size(326, 22);
			menuitemRestart.Text = "&Restart";
			menuitemRestart.Click += ToolStripMenuItemRestart_Click;
			menuitemRestart.MouseEnter += SetStatusbar_Enter;
			menuitemRestart.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRestartWithDemoData
			// 
			menuitemRestartWithDemoData.AccessibleDescription = "Restarts the application with demo data";
			menuitemRestartWithDemoData.AccessibleName = "Restart with demo data";
			menuitemRestartWithDemoData.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRestartWithDemoData.AutoToolTip = true;
			menuitemRestartWithDemoData.Enabled = false;
			menuitemRestartWithDemoData.Image = Properties.Resources.silk_reload;
			menuitemRestartWithDemoData.Name = "menuitemRestartWithDemoData";
			menuitemRestartWithDemoData.Size = new Size(326, 22);
			menuitemRestartWithDemoData.Text = "Restart with &demo data (10000-20231226133106)";
			menuitemRestartWithDemoData.Click += MenuitemRestartWithDemoData_Click;
			menuitemRestartWithDemoData.MouseEnter += SetStatusbar_Enter;
			menuitemRestartWithDemoData.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemExit
			// 
			menuitemExit.AccessibleDescription = "Exits the application";
			menuitemExit.AccessibleName = "Exit";
			menuitemExit.AccessibleRole = AccessibleRole.MenuItem;
			menuitemExit.AutoToolTip = true;
			menuitemExit.DoubleClickEnabled = true;
			menuitemExit.Image = Properties.Resources.silk_door_in;
			menuitemExit.Name = "menuitemExit";
			menuitemExit.ShortcutKeys = Keys.Alt | Keys.F4;
			menuitemExit.Size = new Size(326, 22);
			menuitemExit.Text = "E&xit";
			menuitemExit.Click += MenuitemExit_Click;
			menuitemExit.MouseEnter += SetStatusbar_Enter;
			menuitemExit.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemEdit
			// 
			menuitemEdit.AccessibleDescription = "Opens the menu \"edit\"";
			menuitemEdit.AccessibleName = "Edit";
			menuitemEdit.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemEdit.AutoToolTip = true;
			menuitemEdit.DropDownItems.AddRange(new ToolStripItem[] { menuitemCopytoClipboard, menuitemSearch });
			menuitemEdit.Name = "menuitemEdit";
			menuitemEdit.ShortcutKeys = Keys.Alt | Keys.E;
			menuitemEdit.Size = new Size(39, 24);
			menuitemEdit.Text = "&Edit";
			menuitemEdit.MouseEnter += SetStatusbar_Enter;
			menuitemEdit.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemSearch
			// 
			menuitemSearch.AccessibleDescription = "Search";
			menuitemSearch.AccessibleName = "Search";
			menuitemSearch.AccessibleRole = AccessibleRole.MenuItem;
			menuitemSearch.AutoToolTip = true;
			menuitemSearch.DoubleClickEnabled = true;
			menuitemSearch.Image = Properties.Resources.silk_magnifier;
			menuitemSearch.Name = "menuitemSearch";
			menuitemSearch.ShortcutKeys = Keys.Control | Keys.S;
			menuitemSearch.Size = new Size(151, 22);
			menuitemSearch.Text = "&Search";
			menuitemSearch.Click += ToolStripMenuItemSearch_Click;
			menuitemSearch.MouseEnter += SetStatusbar_Enter;
			menuitemSearch.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigation
			// 
			menuitemNavigation.AccessibleDescription = "Opens the menu \"navigation\"";
			menuitemNavigation.AccessibleName = "Navigation";
			menuitemNavigation.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemNavigation.AutoToolTip = true;
			menuitemNavigation.DropDownItems.AddRange(new ToolStripItem[] { menuitemRandomMinorPlanet, toolStripSeparatorNavigation1, menuitemNavigateToTheBeginning, menuitemNavigateSomeDataBackward, menuitemNavigateToThePreviousData, menuitemNavigateToTheNextData, menuitemNavigateSomeDataForward, menuitemNavigateToTheEnd, toolStripSeparator11, menuitemListReadableDesignations });
			menuitemNavigation.Name = "menuitemNavigation";
			menuitemNavigation.Size = new Size(77, 24);
			menuitemNavigation.Text = "&Navigation";
			menuitemNavigation.MouseEnter += SetStatusbar_Enter;
			menuitemNavigation.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemRandomMinorPlanet
			// 
			menuitemRandomMinorPlanet.AccessibleDescription = "Loads a random minor planet";
			menuitemRandomMinorPlanet.AccessibleName = "Random minor planet";
			menuitemRandomMinorPlanet.AccessibleRole = AccessibleRole.MenuItem;
			menuitemRandomMinorPlanet.AutoToolTip = true;
			menuitemRandomMinorPlanet.DoubleClickEnabled = true;
			menuitemRandomMinorPlanet.Image = Properties.Resources.silk_arrow_refresh;
			menuitemRandomMinorPlanet.Name = "menuitemRandomMinorPlanet";
			menuitemRandomMinorPlanet.ShortcutKeys = Keys.Control | Keys.R;
			menuitemRandomMinorPlanet.Size = new Size(275, 22);
			menuitemRandomMinorPlanet.Text = "&Random minor planet";
			menuitemRandomMinorPlanet.Click += ToolStripMenuItemRandomMinorPlanet_Click;
			menuitemRandomMinorPlanet.MouseEnter += SetStatusbar_Enter;
			menuitemRandomMinorPlanet.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparatorNavigation1
			// 
			toolStripSeparatorNavigation1.AccessibleDescription = "Just a separator";
			toolStripSeparatorNavigation1.AccessibleName = "Just a separator";
			toolStripSeparatorNavigation1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparatorNavigation1.Name = "toolStripSeparatorNavigation1";
			toolStripSeparatorNavigation1.Size = new Size(272, 6);
			toolStripSeparatorNavigation1.MouseEnter += SetStatusbar_Enter;
			toolStripSeparatorNavigation1.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateToTheBeginning
			// 
			menuitemNavigateToTheBeginning.AccessibleDescription = "Navigates to the beginning of the data";
			menuitemNavigateToTheBeginning.AccessibleName = "Navigates to the beginning";
			menuitemNavigateToTheBeginning.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateToTheBeginning.AutoToolTip = true;
			menuitemNavigateToTheBeginning.DoubleClickEnabled = true;
			menuitemNavigateToTheBeginning.Image = Properties.Resources.silk_backward_end_green;
			menuitemNavigateToTheBeginning.Name = "menuitemNavigateToTheBeginning";
			menuitemNavigateToTheBeginning.ShortcutKeys = Keys.Control | Keys.D1;
			menuitemNavigateToTheBeginning.Size = new Size(275, 22);
			menuitemNavigateToTheBeginning.Text = "Navigate to the &beginning";
			menuitemNavigateToTheBeginning.Click += ToolStripMenuItemNavigateToTheBegin_Click;
			menuitemNavigateToTheBeginning.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateToTheBeginning.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateToThePreviousData
			// 
			menuitemNavigateToThePreviousData.AccessibleDescription = "Navigates to the previous data";
			menuitemNavigateToThePreviousData.AccessibleName = "Navigates to the previous";
			menuitemNavigateToThePreviousData.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateToThePreviousData.AutoToolTip = true;
			menuitemNavigateToThePreviousData.DoubleClickEnabled = true;
			menuitemNavigateToThePreviousData.Image = Properties.Resources.silk_backward_1_green;
			menuitemNavigateToThePreviousData.Name = "menuitemNavigateToThePreviousData";
			menuitemNavigateToThePreviousData.ShortcutKeys = Keys.Control | Keys.D3;
			menuitemNavigateToThePreviousData.Size = new Size(275, 22);
			menuitemNavigateToThePreviousData.Text = "Navigate to the &previous";
			menuitemNavigateToThePreviousData.Click += ToolStripMenuItemNavigateToThePreviousData_Click;
			menuitemNavigateToThePreviousData.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateToThePreviousData.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateToTheNextData
			// 
			menuitemNavigateToTheNextData.AccessibleDescription = "Navigates to the next data";
			menuitemNavigateToTheNextData.AccessibleName = "Navigates to the next";
			menuitemNavigateToTheNextData.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateToTheNextData.AutoToolTip = true;
			menuitemNavigateToTheNextData.DoubleClickEnabled = true;
			menuitemNavigateToTheNextData.Image = Properties.Resources.silk_forward_1_green;
			menuitemNavigateToTheNextData.Name = "menuitemNavigateToTheNextData";
			menuitemNavigateToTheNextData.ShortcutKeys = Keys.Control | Keys.D4;
			menuitemNavigateToTheNextData.Size = new Size(275, 22);
			menuitemNavigateToTheNextData.Text = "Navigate to the &next";
			menuitemNavigateToTheNextData.Click += ToolStripMenuItemNavigateToTheNextData_Click;
			menuitemNavigateToTheNextData.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateToTheNextData.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemNavigateToTheEnd
			// 
			menuitemNavigateToTheEnd.AccessibleDescription = "Navigates to the end of the data";
			menuitemNavigateToTheEnd.AccessibleName = "Navigates to the end";
			menuitemNavigateToTheEnd.AccessibleRole = AccessibleRole.MenuItem;
			menuitemNavigateToTheEnd.AutoToolTip = true;
			menuitemNavigateToTheEnd.DoubleClickEnabled = true;
			menuitemNavigateToTheEnd.Image = Properties.Resources.silk_forward_end_green;
			menuitemNavigateToTheEnd.Name = "menuitemNavigateToTheEnd";
			menuitemNavigateToTheEnd.ShortcutKeys = Keys.Control | Keys.D6;
			menuitemNavigateToTheEnd.Size = new Size(275, 22);
			menuitemNavigateToTheEnd.Text = "Navigate to the &end";
			menuitemNavigateToTheEnd.Click += ToolStripMenuItemNavigateToTheEnd_Click;
			menuitemNavigateToTheEnd.MouseEnter += SetStatusbar_Enter;
			menuitemNavigateToTheEnd.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator11
			// 
			toolStripSeparator11.AccessibleDescription = "Just a separator";
			toolStripSeparator11.AccessibleName = "Just a separator";
			toolStripSeparator11.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator11.Name = "toolStripSeparator11";
			toolStripSeparator11.Size = new Size(272, 6);
			toolStripSeparator11.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator11.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemListReadableDesignations
			// 
			menuitemListReadableDesignations.AccessibleDescription = "Click to show the list pf the readable designations";
			menuitemListReadableDesignations.AccessibleName = "List readable designations";
			menuitemListReadableDesignations.AccessibleRole = AccessibleRole.MenuItem;
			menuitemListReadableDesignations.AutoToolTip = true;
			menuitemListReadableDesignations.Image = Properties.Resources.silk_page_white_text;
			menuitemListReadableDesignations.Name = "menuitemListReadableDesignations";
			menuitemListReadableDesignations.Size = new Size(275, 22);
			menuitemListReadableDesignations.Text = "&List readable designations";
			menuitemListReadableDesignations.Click += MenuitemListReadableDesignations_Click;
			menuitemListReadableDesignations.MouseEnter += SetStatusbar_Enter;
			menuitemListReadableDesignations.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemTools
			// 
			menuitemTools.AccessibleDescription = "Opens the menu \"tools\"";
			menuitemTools.AccessibleName = "Tools";
			menuitemTools.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemTools.AutoToolTip = true;
			menuitemTools.DropDownItems.AddRange(new ToolStripItem[] { menuitemDerivatedOrbitElements, menuitemFilter, toolStripSeparatorTools1, menuitemRecords, toolStripSeparator10, menuitemDistribution, toolStripSeparatorTools2, menuitemDatabaseInformation, menuitemTableMode, menuitemTerminology });
			menuitemTools.Name = "menuitemTools";
			menuitemTools.Size = new Size(46, 24);
			menuitemTools.Text = "&Tools";
			menuitemTools.MouseEnter += SetStatusbar_Enter;
			menuitemTools.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDerivatedOrbitElements
			// 
			menuitemDerivatedOrbitElements.AccessibleDescription = "Calculates derivated orbital elements";
			menuitemDerivatedOrbitElements.AccessibleName = "Derivated orbital elements";
			menuitemDerivatedOrbitElements.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDerivatedOrbitElements.AutoToolTip = true;
			menuitemDerivatedOrbitElements.Image = Properties.Resources.silk_arrow_branch;
			menuitemDerivatedOrbitElements.Name = "menuitemDerivatedOrbitElements";
			menuitemDerivatedOrbitElements.Size = new Size(227, 22);
			menuitemDerivatedOrbitElements.Text = "Derivated &orbital elements";
			menuitemDerivatedOrbitElements.Click += ToolStripMenuItemDerivatedOrbitElements_Click;
			menuitemDerivatedOrbitElements.MouseEnter += SetStatusbar_Enter;
			menuitemDerivatedOrbitElements.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemFilter
			// 
			menuitemFilter.AccessibleDescription = "Filters the orbital elements in some ranges";
			menuitemFilter.AccessibleName = "Filter";
			menuitemFilter.AccessibleRole = AccessibleRole.MenuItem;
			menuitemFilter.AutoToolTip = true;
			menuitemFilter.Enabled = false;
			menuitemFilter.Image = Properties.Resources.silk_arrow_divide;
			menuitemFilter.Name = "menuitemFilter";
			menuitemFilter.Size = new Size(227, 22);
			menuitemFilter.Text = "&Filter";
			menuitemFilter.Click += ToolStripMenuItemFilter_Click;
			menuitemFilter.MouseEnter += SetStatusbar_Enter;
			menuitemFilter.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparatorTools1
			// 
			toolStripSeparatorTools1.AccessibleDescription = "Just a separator";
			toolStripSeparatorTools1.AccessibleName = "Just a separator";
			toolStripSeparatorTools1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparatorTools1.Name = "toolStripSeparatorTools1";
			toolStripSeparatorTools1.Size = new Size(224, 6);
			toolStripSeparatorTools1.MouseEnter += SetStatusbar_Enter;
			toolStripSeparatorTools1.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator10
			// 
			toolStripSeparator10.AccessibleDescription = "Just a separator";
			toolStripSeparator10.AccessibleName = "Just a separator";
			toolStripSeparator10.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator10.Name = "toolStripSeparator10";
			toolStripSeparator10.Size = new Size(224, 6);
			// 
			// toolStripSeparatorTools2
			// 
			toolStripSeparatorTools2.AccessibleDescription = "Just a separator";
			toolStripSeparatorTools2.AccessibleName = "Just a separator";
			toolStripSeparatorTools2.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparatorTools2.Name = "toolStripSeparatorTools2";
			toolStripSeparatorTools2.Size = new Size(224, 6);
			toolStripSeparatorTools2.MouseEnter += SetStatusbar_Enter;
			toolStripSeparatorTools2.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDatabaseInformation
			// 
			menuitemDatabaseInformation.AccessibleDescription = "Shows the information of the MPCORB.DAT databbase";
			menuitemDatabaseInformation.AccessibleName = "Database information";
			menuitemDatabaseInformation.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDatabaseInformation.AutoToolTip = true;
			menuitemDatabaseInformation.DoubleClickEnabled = true;
			menuitemDatabaseInformation.Image = Properties.Resources.silk_database;
			menuitemDatabaseInformation.Name = "menuitemDatabaseInformation";
			menuitemDatabaseInformation.ShortcutKeys = Keys.Control | Keys.I;
			menuitemDatabaseInformation.Size = new Size(227, 22);
			menuitemDatabaseInformation.Text = "Database &information";
			menuitemDatabaseInformation.Click += ToolStripMenuItemDatabaseInformation_Click;
			menuitemDatabaseInformation.MouseEnter += SetStatusbar_Enter;
			menuitemDatabaseInformation.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemTableMode
			// 
			menuitemTableMode.AccessibleDescription = "Activates the table mode";
			menuitemTableMode.AccessibleName = "Table mode";
			menuitemTableMode.AccessibleRole = AccessibleRole.MenuItem;
			menuitemTableMode.AutoToolTip = true;
			menuitemTableMode.DoubleClickEnabled = true;
			menuitemTableMode.Image = Properties.Resources.silk_table;
			menuitemTableMode.Name = "menuitemTableMode";
			menuitemTableMode.ShortcutKeys = Keys.Control | Keys.M;
			menuitemTableMode.Size = new Size(227, 22);
			menuitemTableMode.Text = "&Table mode";
			menuitemTableMode.Click += ToolStripMenuItemTableMode_Click;
			menuitemTableMode.MouseEnter += SetStatusbar_Enter;
			menuitemTableMode.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemTerminology
			// 
			menuitemTerminology.AccessibleDescription = "Shows the terminology";
			menuitemTerminology.AccessibleName = "Terminology";
			menuitemTerminology.AccessibleRole = AccessibleRole.MenuItem;
			menuitemTerminology.AutoToolTip = true;
			menuitemTerminology.DoubleClickEnabled = true;
			menuitemTerminology.Image = Properties.Resources.silk_text_list_bullets;
			menuitemTerminology.Name = "menuitemTerminology";
			menuitemTerminology.ShortcutKeys = Keys.Control | Keys.L;
			menuitemTerminology.Size = new Size(227, 22);
			menuitemTerminology.Text = "Terminolog&y";
			menuitemTerminology.Click += ToolStripMenuItemTerminology_Click;
			menuitemTerminology.MouseEnter += SetStatusbar_Enter;
			menuitemTerminology.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemUpdate
			// 
			menuitemUpdate.AccessibleDescription = "Opens the menu \"updates\"";
			menuitemUpdate.AccessibleName = "Update";
			menuitemUpdate.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemUpdate.DropDownItems.AddRange(new ToolStripItem[] { menuitemCheckMpcorbDat, menuitemDownloadMpcorbDat });
			menuitemUpdate.Name = "menuitemUpdate";
			menuitemUpdate.Size = new Size(57, 24);
			menuitemUpdate.Text = "&Update";
			menuitemUpdate.MouseEnter += SetStatusbar_Enter;
			menuitemUpdate.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemCheckMpcorbDat
			// 
			menuitemCheckMpcorbDat.AccessibleDescription = "Checks for updates of the database";
			menuitemCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			menuitemCheckMpcorbDat.AccessibleRole = AccessibleRole.MenuItem;
			menuitemCheckMpcorbDat.AutoToolTip = true;
			menuitemCheckMpcorbDat.DoubleClickEnabled = true;
			menuitemCheckMpcorbDat.Image = Properties.Resources.silk_database_lightning;
			menuitemCheckMpcorbDat.Name = "menuitemCheckMpcorbDat";
			menuitemCheckMpcorbDat.Size = new Size(204, 22);
			menuitemCheckMpcorbDat.Text = "&Check MPCORB.DAT";
			menuitemCheckMpcorbDat.Click += MenuitemCheckMpcorbDat_Click;
			menuitemCheckMpcorbDat.MouseEnter += SetStatusbar_Enter;
			menuitemCheckMpcorbDat.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemDownloadMpcorbDat
			// 
			menuitemDownloadMpcorbDat.AccessibleDescription = "Downloads the database";
			menuitemDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			menuitemDownloadMpcorbDat.AccessibleRole = AccessibleRole.MenuItem;
			menuitemDownloadMpcorbDat.AutoToolTip = true;
			menuitemDownloadMpcorbDat.DoubleClickEnabled = true;
			menuitemDownloadMpcorbDat.Image = Properties.Resources.silk_package;
			menuitemDownloadMpcorbDat.Name = "menuitemDownloadMpcorbDat";
			menuitemDownloadMpcorbDat.Size = new Size(204, 22);
			menuitemDownloadMpcorbDat.Text = "&Download MPCORB.DAT";
			menuitemDownloadMpcorbDat.Click += MenuitemDownloadMpcorbDat_Click;
			menuitemDownloadMpcorbDat.MouseEnter += SetStatusbar_Enter;
			menuitemDownloadMpcorbDat.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOptions
			// 
			menuitemOptions.AccessibleDescription = "Opens the menu \"options\"";
			menuitemOptions.AccessibleName = "Options";
			menuitemOptions.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemOptions.AutoToolTip = true;
			menuitemOptions.DropDownItems.AddRange(new ToolStripItem[] { menuitemSettings, menuitemStyle, toolStripSeparatorOptions, menuitemOptionStayOnTop, menuitemOptionEnabledCopyingByDoubleClicking, menuitemOptionEnableLinkingToTerminology });
			menuitemOptions.Name = "menuitemOptions";
			menuitemOptions.ShortcutKeys = Keys.Alt | Keys.O;
			menuitemOptions.Size = new Size(61, 24);
			menuitemOptions.Text = "&Options";
			menuitemOptions.MouseEnter += SetStatusbar_Enter;
			menuitemOptions.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemSettings
			// 
			menuitemSettings.AccessibleDescription = "Changes the settings";
			menuitemSettings.AccessibleName = "settings";
			menuitemSettings.AccessibleRole = AccessibleRole.MenuItem;
			menuitemSettings.AutoToolTip = true;
			menuitemSettings.Enabled = false;
			menuitemSettings.Image = Properties.Resources.silk_wrench;
			menuitemSettings.Name = "menuitemSettings";
			menuitemSettings.Size = new Size(264, 22);
			menuitemSettings.Text = "&Settings";
			menuitemSettings.Click += ToolStripMenuItemSettings_Click;
			menuitemSettings.MouseEnter += SetStatusbar_Enter;
			menuitemSettings.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemStyle
			// 
			menuitemStyle.AccessibleDescription = "Changes the style";
			menuitemStyle.AccessibleName = "Look and Feel";
			menuitemStyle.AccessibleRole = AccessibleRole.MenuItem;
			menuitemStyle.AutoToolTip = true;
			menuitemStyle.DropDownItems.AddRange(new ToolStripItem[] { menuitemIconsetSilk, menuitemIconsetFugue, menuitemIconsetFatcow });
			menuitemStyle.Image = Properties.Resources.silk_theme;
			menuitemStyle.Name = "menuitemStyle";
			menuitemStyle.ShortcutKeyDisplayString = "";
			menuitemStyle.Size = new Size(264, 22);
			menuitemStyle.Text = "&Look and Feel";
			menuitemStyle.MouseEnter += SetStatusbar_Enter;
			menuitemStyle.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemIconsetSilk
			// 
			menuitemIconsetSilk.AccessibleDescription = "Changes the icon set to Silk icons";
			menuitemIconsetSilk.AccessibleName = "Silk icons";
			menuitemIconsetSilk.AccessibleRole = AccessibleRole.MenuItem;
			menuitemIconsetSilk.AutoToolTip = true;
			menuitemIconsetSilk.Checked = true;
			menuitemIconsetSilk.CheckOnClick = true;
			menuitemIconsetSilk.CheckState = CheckState.Checked;
			menuitemIconsetSilk.Enabled = false;
			menuitemIconsetSilk.Name = "menuitemIconsetSilk";
			menuitemIconsetSilk.Size = new Size(143, 22);
			menuitemIconsetSilk.Text = "Silk icons";
			menuitemIconsetSilk.Click += ToolStripMenuItemIconsetSilk_Click;
			menuitemIconsetSilk.MouseEnter += SetStatusbar_Enter;
			menuitemIconsetSilk.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemIconsetFugue
			// 
			menuitemIconsetFugue.AccessibleDescription = "Changes the icon set to Fugue icons";
			menuitemIconsetFugue.AccessibleName = "Fugue icons";
			menuitemIconsetFugue.AccessibleRole = AccessibleRole.MenuItem;
			menuitemIconsetFugue.AutoToolTip = true;
			menuitemIconsetFugue.CheckOnClick = true;
			menuitemIconsetFugue.Enabled = false;
			menuitemIconsetFugue.Name = "menuitemIconsetFugue";
			menuitemIconsetFugue.Size = new Size(143, 22);
			menuitemIconsetFugue.Text = "Fugue icons";
			menuitemIconsetFugue.Click += ToolStripMenuItemIconsetFugue_Click;
			menuitemIconsetFugue.MouseEnter += SetStatusbar_Enter;
			menuitemIconsetFugue.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemIconsetFatcow
			// 
			menuitemIconsetFatcow.AccessibleDescription = "Changes the icon set to Fatcow icons";
			menuitemIconsetFatcow.AccessibleName = "Fatcow icons";
			menuitemIconsetFatcow.AccessibleRole = AccessibleRole.MenuItem;
			menuitemIconsetFatcow.AutoToolTip = true;
			menuitemIconsetFatcow.CheckOnClick = true;
			menuitemIconsetFatcow.Enabled = false;
			menuitemIconsetFatcow.Name = "menuitemIconsetFatcow";
			menuitemIconsetFatcow.Size = new Size(143, 22);
			menuitemIconsetFatcow.Text = "Fatcow icons";
			menuitemIconsetFatcow.Click += ToolStripMenuItemIconsetFatcow_Click;
			menuitemIconsetFatcow.MouseEnter += SetStatusbar_Enter;
			menuitemIconsetFatcow.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparatorOptions
			// 
			toolStripSeparatorOptions.AccessibleDescription = "Just a separator";
			toolStripSeparatorOptions.AccessibleName = "Just a separator";
			toolStripSeparatorOptions.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparatorOptions.Name = "toolStripSeparatorOptions";
			toolStripSeparatorOptions.Size = new Size(261, 6);
			toolStripSeparatorOptions.MouseEnter += SetStatusbar_Enter;
			toolStripSeparatorOptions.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOptionStayOnTop
			// 
			menuitemOptionStayOnTop.AccessibleDescription = "Stays the application always on top";
			menuitemOptionStayOnTop.AccessibleName = "Stays always on top";
			menuitemOptionStayOnTop.AccessibleRole = AccessibleRole.MenuItem;
			menuitemOptionStayOnTop.AutoToolTip = true;
			menuitemOptionStayOnTop.CheckOnClick = true;
			menuitemOptionStayOnTop.Name = "menuitemOptionStayOnTop";
			menuitemOptionStayOnTop.Size = new Size(264, 22);
			menuitemOptionStayOnTop.Text = "Stay always on &top";
			menuitemOptionStayOnTop.Click += ToolStripMenuItemStayOnTop_Click;
			menuitemOptionStayOnTop.MouseEnter += SetStatusbar_Enter;
			menuitemOptionStayOnTop.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOptionEnabledCopyingByDoubleClicking
			// 
			menuitemOptionEnabledCopyingByDoubleClicking.AccessibleDescription = "Enableds copying data to the clipboard by double-clicking";
			menuitemOptionEnabledCopyingByDoubleClicking.AccessibleName = "Enableds copying by double-clicking";
			menuitemOptionEnabledCopyingByDoubleClicking.AccessibleRole = AccessibleRole.MenuItem;
			menuitemOptionEnabledCopyingByDoubleClicking.AutoToolTip = true;
			menuitemOptionEnabledCopyingByDoubleClicking.Checked = true;
			menuitemOptionEnabledCopyingByDoubleClicking.CheckOnClick = true;
			menuitemOptionEnabledCopyingByDoubleClicking.CheckState = CheckState.Checked;
			menuitemOptionEnabledCopyingByDoubleClicking.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			menuitemOptionEnabledCopyingByDoubleClicking.Name = "menuitemOptionEnabledCopyingByDoubleClicking";
			menuitemOptionEnabledCopyingByDoubleClicking.Size = new Size(264, 22);
			menuitemOptionEnabledCopyingByDoubleClicking.Text = "Enabled &copying by double-clicking";
			menuitemOptionEnabledCopyingByDoubleClicking.Click += ToolStripMenuItemEnableCopyingByDoubleClicking_Click;
			menuitemOptionEnabledCopyingByDoubleClicking.MouseEnter += SetStatusbar_Enter;
			menuitemOptionEnabledCopyingByDoubleClicking.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOptionEnableLinkingToTerminology
			// 
			menuitemOptionEnableLinkingToTerminology.AccessibleDescription = "Enables linking to terminology";
			menuitemOptionEnableLinkingToTerminology.AccessibleName = "Enables linking to terminology";
			menuitemOptionEnableLinkingToTerminology.AccessibleRole = AccessibleRole.MenuItem;
			menuitemOptionEnableLinkingToTerminology.AutoToolTip = true;
			menuitemOptionEnableLinkingToTerminology.Checked = true;
			menuitemOptionEnableLinkingToTerminology.CheckOnClick = true;
			menuitemOptionEnableLinkingToTerminology.CheckState = CheckState.Checked;
			menuitemOptionEnableLinkingToTerminology.Enabled = false;
			menuitemOptionEnableLinkingToTerminology.Name = "menuitemOptionEnableLinkingToTerminology";
			menuitemOptionEnableLinkingToTerminology.Size = new Size(264, 22);
			menuitemOptionEnableLinkingToTerminology.Text = "Enable linking to terminolog&y";
			menuitemOptionEnableLinkingToTerminology.Click += ToolStripMenuItemEnableLinkingToTerminology_Click;
			menuitemOptionEnableLinkingToTerminology.MouseEnter += SetStatusbar_Enter;
			menuitemOptionEnableLinkingToTerminology.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemHelp
			// 
			menuitemHelp.AccessibleDescription = "Opens the menu \"help\"";
			menuitemHelp.AccessibleName = "Help";
			menuitemHelp.AccessibleRole = AccessibleRole.MenuPopup;
			menuitemHelp.AutoToolTip = true;
			menuitemHelp.DoubleClickEnabled = true;
			menuitemHelp.DropDownItems.AddRange(new ToolStripItem[] { menuitemAbout, toolStripSeparatorMisc1, menuitemOpenWebsitePDB, menuitemOpenWebsiteMPC, menuitemOpenMPCORBWebsite });
			menuitemHelp.Name = "menuitemHelp";
			menuitemHelp.ShortcutKeys = Keys.Alt | Keys.H;
			menuitemHelp.Size = new Size(44, 24);
			menuitemHelp.Text = "&Help";
			menuitemHelp.MouseEnter += SetStatusbar_Enter;
			menuitemHelp.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemAbout
			// 
			menuitemAbout.AccessibleDescription = "More information about the application";
			menuitemAbout.AccessibleName = "About";
			menuitemAbout.AccessibleRole = AccessibleRole.MenuItem;
			menuitemAbout.AutoToolTip = true;
			menuitemAbout.DoubleClickEnabled = true;
			menuitemAbout.Image = Properties.Resources.silk_information;
			menuitemAbout.Name = "menuitemAbout";
			menuitemAbout.Size = new Size(236, 22);
			menuitemAbout.Text = "&About";
			menuitemAbout.ToolTipText = "More information about the application";
			menuitemAbout.Click += MenuitemAbout_Click;
			menuitemAbout.MouseEnter += SetStatusbar_Enter;
			menuitemAbout.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparatorMisc1
			// 
			toolStripSeparatorMisc1.AccessibleDescription = "Just a separator";
			toolStripSeparatorMisc1.AccessibleName = "Just a separator";
			toolStripSeparatorMisc1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparatorMisc1.Name = "toolStripSeparatorMisc1";
			toolStripSeparatorMisc1.Size = new Size(233, 6);
			toolStripSeparatorMisc1.MouseEnter += SetStatusbar_Enter;
			toolStripSeparatorMisc1.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOpenWebsitePDB
			// 
			menuitemOpenWebsitePDB.AccessibleDescription = "Opens the Planetoid-DB homepage";
			menuitemOpenWebsitePDB.AccessibleName = "Opens Planetoid-DB homepage";
			menuitemOpenWebsitePDB.AccessibleRole = AccessibleRole.MenuItem;
			menuitemOpenWebsitePDB.AutoToolTip = true;
			menuitemOpenWebsitePDB.DoubleClickEnabled = true;
			menuitemOpenWebsitePDB.Image = Properties.Resources.silk_house;
			menuitemOpenWebsitePDB.Name = "menuitemOpenWebsitePDB";
			menuitemOpenWebsitePDB.Size = new Size(236, 22);
			menuitemOpenWebsitePDB.Text = "Open Planetoid-DB homepage";
			menuitemOpenWebsitePDB.ToolTipText = "Opens the Planetoid-DB homepage";
			menuitemOpenWebsitePDB.Click += MenuitemOpenWebsitePDB_Click;
			menuitemOpenWebsitePDB.MouseEnter += SetStatusbar_Enter;
			menuitemOpenWebsitePDB.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOpenWebsiteMPC
			// 
			menuitemOpenWebsiteMPC.AccessibleDescription = "Opens the MPC homepage";
			menuitemOpenWebsiteMPC.AccessibleName = "Opens MPC homepage";
			menuitemOpenWebsiteMPC.AccessibleRole = AccessibleRole.MenuItem;
			menuitemOpenWebsiteMPC.AutoToolTip = true;
			menuitemOpenWebsiteMPC.DoubleClickEnabled = true;
			menuitemOpenWebsiteMPC.Image = Properties.Resources.silk_world;
			menuitemOpenWebsiteMPC.Name = "menuitemOpenWebsiteMPC";
			menuitemOpenWebsiteMPC.Size = new Size(236, 22);
			menuitemOpenWebsiteMPC.Text = "Open MPC homepage";
			menuitemOpenWebsiteMPC.ToolTipText = "Opens the MPC homepage";
			menuitemOpenWebsiteMPC.Click += MenuitemOpenWebsiteMPC_Click;
			menuitemOpenWebsiteMPC.MouseEnter += SetStatusbar_Enter;
			menuitemOpenWebsiteMPC.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemOpenMPCORBWebsite
			// 
			menuitemOpenMPCORBWebsite.AccessibleDescription = "Opens the MPCORB website";
			menuitemOpenMPCORBWebsite.AccessibleName = "Opens MPCORB homepage";
			menuitemOpenMPCORBWebsite.AccessibleRole = AccessibleRole.MenuItem;
			menuitemOpenMPCORBWebsite.AutoToolTip = true;
			menuitemOpenMPCORBWebsite.DoubleClickEnabled = true;
			menuitemOpenMPCORBWebsite.Image = Properties.Resources.silk_world;
			menuitemOpenMPCORBWebsite.Name = "menuitemOpenMPCORBWebsite";
			menuitemOpenMPCORBWebsite.Size = new Size(236, 22);
			menuitemOpenMPCORBWebsite.Text = "Open MPCORB website";
			menuitemOpenMPCORBWebsite.ToolTipText = "Opens the MPCORB website";
			menuitemOpenMPCORBWebsite.Click += MenuitemOpenMPCORBWebsite_Click;
			menuitemOpenMPCORBWebsite.MouseEnter += SetStatusbar_Enter;
			menuitemOpenMPCORBWebsite.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Container";
			toolStripContainer.AccessibleName = "Container";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.AccessibleDescription = "Lower part of the control panel";
			toolStripContainer.BottomToolStripPanel.AccessibleName = "Lower part of the control panel";
			toolStripContainer.BottomToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusBar);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.AccessibleDescription = "Group the controls";
			toolStripContainer.ContentPanel.AccessibleName = "Container Panel";
			toolStripContainer.ContentPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.ContentPanel.AutoScroll = true;
			toolStripContainer.ContentPanel.BackColor = Color.Transparent;
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanelData);
			toolStripContainer.ContentPanel.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			toolStripContainer.ContentPanel.Size = new Size(804, 290);
			toolStripContainer.Dock = DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			toolStripContainer.LeftToolStripPanel.AccessibleDescription = "Left part of the container panel";
			toolStripContainer.LeftToolStripPanel.AccessibleName = "Left part of the container panel";
			toolStripContainer.LeftToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			toolStripContainer.RightToolStripPanel.AccessibleDescription = "Right part of the container panel";
			toolStripContainer.RightToolStripPanel.AccessibleName = "Right part of the container panel";
			toolStripContainer.RightToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.Size = new Size(804, 386);
			toolStripContainer.TabIndex = 16;
			toolTip.SetToolTip(toolStripContainer, "container");
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.AccessibleDescription = "Upper part of the container panel";
			toolStripContainer.TopToolStripPanel.AccessibleName = "Upper part of the container panel";
			toolStripContainer.TopToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.TopToolStripPanel.Controls.Add(menu);
			toolStripContainer.TopToolStripPanel.Controls.Add(toolStripIcons);
			toolStripContainer.TopToolStripPanel.Controls.Add(toolStripNavigation);
			// 
			// statusBar
			// 
			statusBar.AccessibleDescription = "Shows some information";
			statusBar.AccessibleName = "Status bar of some information";
			statusBar.AccessibleRole = AccessibleRole.StatusBar;
			statusBar.Dock = DockStyle.None;
			statusBar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			statusBar.GripStyle = ToolStripGripStyle.Visible;
			statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUpdate, toolStripStatusLabelBackgroundDownload, toolStripProgressBarBackgroundDownload, toolStripStatusLabelCancelBackgroundDownload, labelInformation });
			statusBar.LayoutStyle = ToolStripLayoutStyle.Flow;
			statusBar.Location = new Point(0, 0);
			statusBar.Name = "statusBar";
			statusBar.ProgressBars = null;
			statusBar.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusBar.ShowItemToolTips = true;
			statusBar.Size = new Size(804, 22);
			statusBar.SizingGrip = false;
			statusBar.TabIndex = 0;
			statusBar.TabStop = true;
			statusBar.Text = "statusStrip";
			// 
			// toolStripStatusLabelUpdate
			// 
			toolStripStatusLabelUpdate.AccessibleDescription = "Shows that an MPCORB.DAT update is aviable";
			toolStripStatusLabelUpdate.AccessibleName = "Update information";
			toolStripStatusLabelUpdate.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelUpdate.AutoToolTip = true;
			toolStripStatusLabelUpdate.Image = Properties.Resources.silk_database_lightning;
			toolStripStatusLabelUpdate.IsLink = true;
			toolStripStatusLabelUpdate.LinkBehavior = LinkBehavior.HoverUnderline;
			toolStripStatusLabelUpdate.LinkColor = SystemColors.ControlText;
			toolStripStatusLabelUpdate.Margin = new Padding(5, 3, 0, 2);
			toolStripStatusLabelUpdate.Name = "toolStripStatusLabelUpdate";
			toolStripStatusLabelUpdate.Size = new Size(185, 16);
			toolStripStatusLabelUpdate.Text = "MPCORB.DAT update available";
			toolStripStatusLabelUpdate.ToolTipText = "MPCORB.DAT update aviable";
			toolStripStatusLabelUpdate.Click += ToolStripStatusLabelUpdate_Click;
			toolStripStatusLabelUpdate.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelUpdate.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripStatusLabelBackgroundDownload
			// 
			toolStripStatusLabelBackgroundDownload.AccessibleDescription = "Shows the download progres";
			toolStripStatusLabelBackgroundDownload.AccessibleName = "Download progress";
			toolStripStatusLabelBackgroundDownload.AccessibleRole = AccessibleRole.StatusBar;
			toolStripStatusLabelBackgroundDownload.AutoToolTip = true;
			toolStripStatusLabelBackgroundDownload.Image = Properties.Resources.silk_package_go;
			toolStripStatusLabelBackgroundDownload.Margin = new Padding(5, 3, 0, 2);
			toolStripStatusLabelBackgroundDownload.Name = "toolStripStatusLabelBackgroundDownload";
			toolStripStatusLabelBackgroundDownload.Size = new Size(80, 16);
			toolStripStatusLabelBackgroundDownload.Text = "Download:";
			toolStripStatusLabelBackgroundDownload.ToolTipText = "Show the download progres";
			toolStripStatusLabelBackgroundDownload.DoubleClick += EasterEgg_DoubleClick;
			toolStripStatusLabelBackgroundDownload.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelBackgroundDownload.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripProgressBarBackgroundDownload
			// 
			toolStripProgressBarBackgroundDownload.AccessibleDescription = "Shows the download progres";
			toolStripProgressBarBackgroundDownload.AccessibleName = "Download progress";
			toolStripProgressBarBackgroundDownload.AccessibleRole = AccessibleRole.ProgressBar;
			toolStripProgressBarBackgroundDownload.AutoToolTip = true;
			toolStripProgressBarBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Name = "toolStripProgressBarBackgroundDownload";
			toolStripProgressBarBackgroundDownload.Size = new Size(100, 16);
			toolStripProgressBarBackgroundDownload.Style = ProgressBarStyle.Continuous;
			toolStripProgressBarBackgroundDownload.ToolTipText = "Show the download progres";
			toolStripProgressBarBackgroundDownload.DoubleClick += EasterEgg_DoubleClick;
			toolStripProgressBarBackgroundDownload.MouseEnter += SetStatusbar_Enter;
			toolStripProgressBarBackgroundDownload.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripStatusLabelCancelBackgroundDownload
			// 
			toolStripStatusLabelCancelBackgroundDownload.AccessibleDescription = "Cancels the background download";
			toolStripStatusLabelCancelBackgroundDownload.AccessibleName = "Cancel download";
			toolStripStatusLabelCancelBackgroundDownload.AccessibleRole = AccessibleRole.Graphic;
			toolStripStatusLabelCancelBackgroundDownload.AutoToolTip = true;
			toolStripStatusLabelCancelBackgroundDownload.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripStatusLabelCancelBackgroundDownload.Image = Properties.Resources.silk_cancel;
			toolStripStatusLabelCancelBackgroundDownload.Name = "toolStripStatusLabelCancelBackgroundDownload";
			toolStripStatusLabelCancelBackgroundDownload.Size = new Size(16, 16);
			toolStripStatusLabelCancelBackgroundDownload.Text = "Cancel background download";
			toolStripStatusLabelCancelBackgroundDownload.Click += ToolStripStatusLabelCancelBackgroundDownload_Click;
			toolStripStatusLabelCancelBackgroundDownload.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelCancelBackgroundDownload.MouseLeave += ClearStatusbar_Leave;
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
			labelInformation.Size = new Size(144, 16);
			labelInformation.Text = "some information here";
			labelInformation.ToolTipText = "Shows some information";
			// 
			// toolStripIcons
			// 
			toolStripIcons.AccessibleDescription = "Toolbar of main functions";
			toolStripIcons.AccessibleName = "Toolbar of main functions";
			toolStripIcons.AccessibleRole = AccessibleRole.ToolBar;
			toolStripIcons.Dock = DockStyle.None;
			toolStripIcons.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			toolStripIcons.Items.AddRange(new ToolStripItem[] { toolStripButtonOpen, toolStripButtonExport, toolStripButtonPrint, splitbuttonCopyToClipboard, toolStripButtonSearch, toolStripSeparator4, toolStripButtonDatabaseInformation, toolStripButtonTableMode, toolStripButtonTerminology, toolStripSeparator3, splitbuttonTopTenRecords, splitbuttonDistribution, toolStripSeparator5, toolStripButtonCheckMpcorbDat, toolStripButtonDownloadMpcorbDat, toolStripSeparator1, toolStripButtonAbout, toolStripButtonOpenWebsitePDB });
			toolStripIcons.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			toolStripIcons.Location = new Point(0, 24);
			toolStripIcons.Name = "toolStripIcons";
			toolStripIcons.Size = new Size(804, 25);
			toolStripIcons.Stretch = true;
			toolStripIcons.TabIndex = 1;
			toolStripIcons.TabStop = true;
			toolStripIcons.Text = "Toolbar of main functions";
			toolStripIcons.Enter += SetStatusbar_Enter;
			toolStripIcons.Leave += ClearStatusbar_Leave;
			toolStripIcons.MouseEnter += SetStatusbar_Enter;
			toolStripIcons.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonOpen
			// 
			toolStripButtonOpen.AccessibleDescription = "Opens a local MPCORB.DAT file";
			toolStripButtonOpen.AccessibleName = "Open";
			toolStripButtonOpen.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonOpen.Enabled = false;
			toolStripButtonOpen.Image = Properties.Resources.silk_folder;
			toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
			toolStripButtonOpen.Name = "toolStripButtonOpen";
			toolStripButtonOpen.Size = new Size(23, 22);
			toolStripButtonOpen.Text = "Open";
			toolStripButtonOpen.Click += ToolStripButtonOpen_Click;
			toolStripButtonOpen.MouseEnter += SetStatusbar_Enter;
			toolStripButtonOpen.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonExport
			// 
			toolStripButtonExport.AccessibleDescription = "Exports data entry";
			toolStripButtonExport.AccessibleName = "Export";
			toolStripButtonExport.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonExport.Image = Properties.Resources.silk_page_save;
			toolStripButtonExport.ImageTransparentColor = Color.Magenta;
			toolStripButtonExport.Name = "toolStripButtonExport";
			toolStripButtonExport.Size = new Size(23, 22);
			toolStripButtonExport.Text = "Export";
			toolStripButtonExport.Click += ToolStripSplitButtonExport_Click;
			toolStripButtonExport.MouseEnter += SetStatusbar_Enter;
			toolStripButtonExport.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonPrint
			// 
			toolStripButtonPrint.AccessibleDescription = "Prints the information";
			toolStripButtonPrint.AccessibleName = "Print";
			toolStripButtonPrint.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonPrint.Image = Properties.Resources.silk_printer;
			toolStripButtonPrint.ImageTransparentColor = Color.Magenta;
			toolStripButtonPrint.Name = "toolStripButtonPrint";
			toolStripButtonPrint.Size = new Size(23, 22);
			toolStripButtonPrint.Text = "Print";
			toolStripButtonPrint.Click += ToolStripButtonPrint_Click;
			toolStripButtonPrint.MouseEnter += SetStatusbar_Enter;
			toolStripButtonPrint.MouseLeave += ClearStatusbar_Leave;
			// 
			// splitbuttonCopyToClipboard
			// 
			splitbuttonCopyToClipboard.AccessibleDescription = "Copys to clipboard";
			splitbuttonCopyToClipboard.AccessibleName = "Copy to clipboard";
			splitbuttonCopyToClipboard.AccessibleRole = AccessibleRole.SplitButton;
			splitbuttonCopyToClipboard.DisplayStyle = ToolStripItemDisplayStyle.Image;
			splitbuttonCopyToClipboard.DropDown = contextMenuCopyToClipboardOrbitalElements;
			splitbuttonCopyToClipboard.Image = Properties.Resources.silk_page_copy;
			splitbuttonCopyToClipboard.ImageTransparentColor = Color.Magenta;
			splitbuttonCopyToClipboard.Name = "splitbuttonCopyToClipboard";
			splitbuttonCopyToClipboard.Size = new Size(32, 22);
			splitbuttonCopyToClipboard.Text = "Copy to clipboard";
			splitbuttonCopyToClipboard.ButtonClick += ToolStripButtonCopyToClipboard_Click;
			splitbuttonCopyToClipboard.MouseEnter += SetStatusbar_Enter;
			splitbuttonCopyToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.AccessibleDescription = "Just a separator";
			toolStripSeparator4.AccessibleName = "Just a separator";
			toolStripSeparator4.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(6, 25);
			toolStripSeparator4.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator4.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonDatabaseInformation
			// 
			toolStripButtonDatabaseInformation.AccessibleDescription = "Shows some information of the MPCORB.DAT database";
			toolStripButtonDatabaseInformation.AccessibleName = "Database Information";
			toolStripButtonDatabaseInformation.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonDatabaseInformation.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonDatabaseInformation.Image = Properties.Resources.silk_database;
			toolStripButtonDatabaseInformation.ImageTransparentColor = Color.Magenta;
			toolStripButtonDatabaseInformation.Name = "toolStripButtonDatabaseInformation";
			toolStripButtonDatabaseInformation.Size = new Size(23, 22);
			toolStripButtonDatabaseInformation.Text = "Database information";
			toolStripButtonDatabaseInformation.Click += ToolStripButtonDatabaseInformation_Click;
			toolStripButtonDatabaseInformation.MouseEnter += SetStatusbar_Enter;
			toolStripButtonDatabaseInformation.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonTableMode
			// 
			toolStripButtonTableMode.AccessibleDescription = "Activates the table mode";
			toolStripButtonTableMode.AccessibleName = "Table mode";
			toolStripButtonTableMode.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonTableMode.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonTableMode.Image = Properties.Resources.silk_table;
			toolStripButtonTableMode.ImageTransparentColor = Color.Magenta;
			toolStripButtonTableMode.Name = "toolStripButtonTableMode";
			toolStripButtonTableMode.Size = new Size(23, 22);
			toolStripButtonTableMode.Text = "Table mode";
			toolStripButtonTableMode.ToolTipText = "Activate the table mode";
			toolStripButtonTableMode.Click += ToolStripButtonTableMode_Click;
			toolStripButtonTableMode.MouseEnter += SetStatusbar_Enter;
			toolStripButtonTableMode.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonTerminology
			// 
			toolStripButtonTerminology.AccessibleDescription = "Shows the terminology";
			toolStripButtonTerminology.AccessibleName = "Terminology";
			toolStripButtonTerminology.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonTerminology.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonTerminology.Image = Properties.Resources.silk_text_list_bullets;
			toolStripButtonTerminology.ImageTransparentColor = Color.Magenta;
			toolStripButtonTerminology.Name = "toolStripButtonTerminology";
			toolStripButtonTerminology.Size = new Size(23, 22);
			toolStripButtonTerminology.Text = "Terminology";
			toolStripButtonTerminology.ToolTipText = "Show the terminology";
			toolStripButtonTerminology.Click += ToolStripButtonTerminology_Click;
			toolStripButtonTerminology.MouseEnter += SetStatusbar_Enter;
			toolStripButtonTerminology.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.AccessibleDescription = "Just a separator";
			toolStripSeparator3.AccessibleName = "Just a separator";
			toolStripSeparator3.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 25);
			toolStripSeparator3.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator3.MouseLeave += ClearStatusbar_Leave;
			// 
			// splitbuttonTopTenRecords
			// 
			splitbuttonTopTenRecords.AccessibleDescription = "Shows the top ten records";
			splitbuttonTopTenRecords.AccessibleName = "Top ten records";
			splitbuttonTopTenRecords.AccessibleRole = AccessibleRole.SplitButton;
			splitbuttonTopTenRecords.DisplayStyle = ToolStripItemDisplayStyle.Image;
			splitbuttonTopTenRecords.DropDown = contextMenuTopTenRecords;
			splitbuttonTopTenRecords.Enabled = false;
			splitbuttonTopTenRecords.Image = Properties.Resources.silk_text_list_numbers;
			splitbuttonTopTenRecords.ImageTransparentColor = Color.Magenta;
			splitbuttonTopTenRecords.Name = "splitbuttonTopTenRecords";
			splitbuttonTopTenRecords.Size = new Size(32, 22);
			splitbuttonTopTenRecords.Text = "Top ten records";
			splitbuttonTopTenRecords.ButtonClick += SplitbuttonTopTenRecords_ButtonClick;
			splitbuttonTopTenRecords.MouseEnter += SetStatusbar_Enter;
			splitbuttonTopTenRecords.MouseLeave += ClearStatusbar_Leave;
			// 
			// splitbuttonDistribution
			// 
			splitbuttonDistribution.AccessibleDescription = "Shows some distributions";
			splitbuttonDistribution.AccessibleName = "Distributions";
			splitbuttonDistribution.AccessibleRole = AccessibleRole.SplitButton;
			splitbuttonDistribution.DisplayStyle = ToolStripItemDisplayStyle.Image;
			splitbuttonDistribution.DropDown = contextMenuDistributions;
			splitbuttonDistribution.Enabled = false;
			splitbuttonDistribution.Image = Properties.Resources.silk_chart_bar;
			splitbuttonDistribution.ImageTransparentColor = Color.Magenta;
			splitbuttonDistribution.Name = "splitbuttonDistribution";
			splitbuttonDistribution.Size = new Size(32, 22);
			splitbuttonDistribution.Text = "Distributions";
			splitbuttonDistribution.ButtonClick += SplitbuttonDistribution_ButtonClick;
			splitbuttonDistribution.MouseEnter += SetStatusbar_Enter;
			splitbuttonDistribution.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.AccessibleDescription = "Just a separator";
			toolStripSeparator5.AccessibleName = "Just a separator";
			toolStripSeparator5.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(6, 25);
			toolStripSeparator5.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator5.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonCheckMpcorbDat
			// 
			toolStripButtonCheckMpcorbDat.AccessibleDescription = "Checks for updates of the database";
			toolStripButtonCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
			toolStripButtonCheckMpcorbDat.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonCheckMpcorbDat.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonCheckMpcorbDat.Image = Properties.Resources.silk_database_lightning;
			toolStripButtonCheckMpcorbDat.ImageTransparentColor = Color.Magenta;
			toolStripButtonCheckMpcorbDat.Name = "toolStripButtonCheckMpcorbDat";
			toolStripButtonCheckMpcorbDat.Size = new Size(23, 22);
			toolStripButtonCheckMpcorbDat.Text = "Check MPCORB.DAT";
			toolStripButtonCheckMpcorbDat.ToolTipText = "Check MPCORB.DAT";
			toolStripButtonCheckMpcorbDat.Click += ToolStripButtonCheckMpcorbDat_Click;
			toolStripButtonCheckMpcorbDat.MouseEnter += SetStatusbar_Enter;
			toolStripButtonCheckMpcorbDat.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonDownloadMpcorbDat
			// 
			toolStripButtonDownloadMpcorbDat.AccessibleDescription = "Downloads the database";
			toolStripButtonDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
			toolStripButtonDownloadMpcorbDat.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonDownloadMpcorbDat.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonDownloadMpcorbDat.Image = Properties.Resources.silk_package_go;
			toolStripButtonDownloadMpcorbDat.ImageTransparentColor = Color.Transparent;
			toolStripButtonDownloadMpcorbDat.Name = "toolStripButtonDownloadMpcorbDat";
			toolStripButtonDownloadMpcorbDat.Size = new Size(23, 22);
			toolStripButtonDownloadMpcorbDat.Text = "Download MPCORB.DAT";
			toolStripButtonDownloadMpcorbDat.ToolTipText = "Download the database";
			toolStripButtonDownloadMpcorbDat.Click += ToolStripButtonDownloadMpcorbDat_Click;
			toolStripButtonDownloadMpcorbDat.MouseEnter += SetStatusbar_Enter;
			toolStripButtonDownloadMpcorbDat.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.AccessibleDescription = "Just a separator";
			toolStripSeparator1.AccessibleName = "Just a separator";
			toolStripSeparator1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			toolStripSeparator1.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator1.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonAbout
			// 
			toolStripButtonAbout.AccessibleDescription = "More information about the application";
			toolStripButtonAbout.AccessibleName = "About";
			toolStripButtonAbout.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonAbout.Image = Properties.Resources.silk_information;
			toolStripButtonAbout.ImageTransparentColor = Color.Magenta;
			toolStripButtonAbout.Name = "toolStripButtonAbout";
			toolStripButtonAbout.Size = new Size(23, 22);
			toolStripButtonAbout.Text = "About";
			toolStripButtonAbout.ToolTipText = "More information about the application";
			toolStripButtonAbout.Click += ToolStripButtonAbout_Click;
			toolStripButtonAbout.MouseEnter += SetStatusbar_Enter;
			toolStripButtonAbout.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonOpenWebsitePDB
			// 
			toolStripButtonOpenWebsitePDB.AccessibleDescription = "Opens the Planetoid-DB homepage";
			toolStripButtonOpenWebsitePDB.AccessibleName = "Open Planetoid-DB homepage";
			toolStripButtonOpenWebsitePDB.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonOpenWebsitePDB.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonOpenWebsitePDB.Image = Properties.Resources.silk_house;
			toolStripButtonOpenWebsitePDB.ImageTransparentColor = Color.Magenta;
			toolStripButtonOpenWebsitePDB.Name = "toolStripButtonOpenWebsitePDB";
			toolStripButtonOpenWebsitePDB.Size = new Size(23, 22);
			toolStripButtonOpenWebsitePDB.Text = "Open Planetoid-DB homepage";
			toolStripButtonOpenWebsitePDB.Click += ToolStripButtonOpenWebsitePDB_Click;
			toolStripButtonOpenWebsitePDB.MouseEnter += SetStatusbar_Enter;
			toolStripButtonOpenWebsitePDB.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonSearch
			// 
			toolStripButtonSearch.AccessibleDescription = "Search";
			toolStripButtonSearch.AccessibleName = "Search";
			toolStripButtonSearch.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonSearch.Image = Properties.Resources.silk_magnifier;
			toolStripButtonSearch.ImageTransparentColor = Color.Magenta;
			toolStripButtonSearch.Name = "toolStripButtonSearch";
			toolStripButtonSearch.Size = new Size(23, 22);
			toolStripButtonSearch.Text = "Search";
			toolStripButtonSearch.Click += ToolStripMenuItemSearch_Click;
			toolStripButtonSearch.MouseEnter += SetStatusbar_Enter;
			toolStripButtonSearch.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripNavigation
			// 
			toolStripNavigation.AccessibleDescription = "Toolbar of the navigation";
			toolStripNavigation.AccessibleName = "Toolbar of the navigation";
			toolStripNavigation.AccessibleRole = AccessibleRole.ToolBar;
			toolStripNavigation.Dock = DockStyle.None;
			toolStripNavigation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			toolStripNavigation.Items.AddRange(new ToolStripItem[] { toolStripButtonLoadRandomMinorPlanet, toolStripSeparator8, toolStripButtonStepToBegin, toolStripSplitButtonStepBackward, toolStripButtonStepBackwardOne, toolStripButtonStepForwardOne, toolStripSplitButtonStepForward, toolStripButtonStepToEnd, toolStripSeparator6, toolStripLabelIndexPosition, toolStripSeparator7, toolStripLabelGoToIndex, toolStripTextBoxGotoIndex, toolStripButtonGoToIndex, toolStripButtonListReadableDesignations, toolStripSeparator9, toolStripButtonDerivatedOrbitElements, toolStripButtonFilter });
			toolStripNavigation.Location = new Point(0, 49);
			toolStripNavigation.Name = "toolStripNavigation";
			toolStripNavigation.Size = new Size(804, 25);
			toolStripNavigation.Stretch = true;
			toolStripNavigation.TabIndex = 2;
			toolStripNavigation.Text = "Navigation";
			toolStripNavigation.Enter += SetStatusbar_Enter;
			toolStripNavigation.Leave += ClearStatusbar_Leave;
			toolStripNavigation.MouseEnter += SetStatusbar_Enter;
			toolStripNavigation.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonLoadRandomMinorPlanet
			// 
			toolStripButtonLoadRandomMinorPlanet.AccessibleDescription = "Loads a random minor planet";
			toolStripButtonLoadRandomMinorPlanet.AccessibleName = "Random minor planet";
			toolStripButtonLoadRandomMinorPlanet.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonLoadRandomMinorPlanet.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonLoadRandomMinorPlanet.Image = Properties.Resources.silk_arrow_refresh;
			toolStripButtonLoadRandomMinorPlanet.ImageTransparentColor = Color.Magenta;
			toolStripButtonLoadRandomMinorPlanet.Name = "toolStripButtonLoadRandomMinorPlanet";
			toolStripButtonLoadRandomMinorPlanet.Size = new Size(23, 22);
			toolStripButtonLoadRandomMinorPlanet.Text = "Random minor planet";
			toolStripButtonLoadRandomMinorPlanet.Click += ToolStripButtonLoadRandomMinorPlanet_Click;
			toolStripButtonLoadRandomMinorPlanet.MouseEnter += SetStatusbar_Enter;
			toolStripButtonLoadRandomMinorPlanet.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator8
			// 
			toolStripSeparator8.AccessibleDescription = "Just a separator";
			toolStripSeparator8.AccessibleName = "Just a separator";
			toolStripSeparator8.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator8.Name = "toolStripSeparator8";
			toolStripSeparator8.Size = new Size(6, 25);
			toolStripSeparator8.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator8.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonStepToBegin
			// 
			toolStripButtonStepToBegin.AccessibleDescription = "Navigates to the begin of the data";
			toolStripButtonStepToBegin.AccessibleName = "Begin of the data";
			toolStripButtonStepToBegin.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonStepToBegin.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonStepToBegin.Image = Properties.Resources.silk_backward_end_green;
			toolStripButtonStepToBegin.ImageTransparentColor = Color.Magenta;
			toolStripButtonStepToBegin.Name = "toolStripButtonStepToBegin";
			toolStripButtonStepToBegin.Size = new Size(23, 22);
			toolStripButtonStepToBegin.Text = "Begin of the data";
			toolStripButtonStepToBegin.Click += ToolStripButtonStepToBegin_Click;
			toolStripButtonStepToBegin.MouseEnter += SetStatusbar_Enter;
			toolStripButtonStepToBegin.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonStepBackwardOne
			// 
			toolStripButtonStepBackwardOne.AccessibleDescription = "Navigates to the previous data";
			toolStripButtonStepBackwardOne.AccessibleName = "Navigate to the previous data";
			toolStripButtonStepBackwardOne.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonStepBackwardOne.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonStepBackwardOne.Image = Properties.Resources.silk_backward_1_green;
			toolStripButtonStepBackwardOne.ImageTransparentColor = Color.Magenta;
			toolStripButtonStepBackwardOne.Name = "toolStripButtonStepBackwardOne";
			toolStripButtonStepBackwardOne.Size = new Size(23, 22);
			toolStripButtonStepBackwardOne.Text = "Navigate to the previous data";
			toolStripButtonStepBackwardOne.Click += ToolStripButtonStepBackwardOne_Click;
			toolStripButtonStepBackwardOne.MouseEnter += SetStatusbar_Enter;
			toolStripButtonStepBackwardOne.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonStepForwardOne
			// 
			toolStripButtonStepForwardOne.AccessibleDescription = "Navigates to the next data";
			toolStripButtonStepForwardOne.AccessibleName = "Navigate to the next data";
			toolStripButtonStepForwardOne.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonStepForwardOne.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonStepForwardOne.Image = Properties.Resources.silk_forward_1_green;
			toolStripButtonStepForwardOne.ImageTransparentColor = Color.Magenta;
			toolStripButtonStepForwardOne.Name = "toolStripButtonStepForwardOne";
			toolStripButtonStepForwardOne.Size = new Size(23, 22);
			toolStripButtonStepForwardOne.Text = "Navigate to the next data";
			toolStripButtonStepForwardOne.Click += ToolStripButtonStepForwardOne_Click;
			toolStripButtonStepForwardOne.MouseEnter += SetStatusbar_Enter;
			toolStripButtonStepForwardOne.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonStepToEnd
			// 
			toolStripButtonStepToEnd.AccessibleDescription = "Navigates to the end of the data";
			toolStripButtonStepToEnd.AccessibleName = "End of the data";
			toolStripButtonStepToEnd.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonStepToEnd.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonStepToEnd.Image = Properties.Resources.silk_forward_end_green;
			toolStripButtonStepToEnd.ImageTransparentColor = Color.Magenta;
			toolStripButtonStepToEnd.Name = "toolStripButtonStepToEnd";
			toolStripButtonStepToEnd.Size = new Size(23, 22);
			toolStripButtonStepToEnd.Text = "End of the data";
			toolStripButtonStepToEnd.Click += ToolStripButtonStepToEnd_Click;
			toolStripButtonStepToEnd.MouseEnter += SetStatusbar_Enter;
			toolStripButtonStepToEnd.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator6
			// 
			toolStripSeparator6.AccessibleDescription = "Just a separator";
			toolStripSeparator6.AccessibleName = "Just a separator";
			toolStripSeparator6.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator6.Name = "toolStripSeparator6";
			toolStripSeparator6.Size = new Size(6, 25);
			toolStripSeparator6.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator6.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripLabelIndexPosition
			// 
			toolStripLabelIndexPosition.AccessibleDescription = "Shows the current index position";
			toolStripLabelIndexPosition.AccessibleName = "Index info";
			toolStripLabelIndexPosition.AccessibleRole = AccessibleRole.StaticText;
			toolStripLabelIndexPosition.AutoToolTip = true;
			toolStripLabelIndexPosition.Name = "toolStripLabelIndexPosition";
			toolStripLabelIndexPosition.Size = new Size(125, 22);
			toolStripLabelIndexPosition.Text = "index: 123456 / 999999";
			toolStripLabelIndexPosition.MouseEnter += SetStatusbar_Enter;
			toolStripLabelIndexPosition.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator7
			// 
			toolStripSeparator7.AccessibleDescription = "Just a separator";
			toolStripSeparator7.AccessibleName = "Just a separator";
			toolStripSeparator7.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator7.Name = "toolStripSeparator7";
			toolStripSeparator7.Size = new Size(6, 25);
			toolStripSeparator7.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator7.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripLabelGoToIndex
			// 
			toolStripLabelGoToIndex.AccessibleDescription = "Go to index";
			toolStripLabelGoToIndex.AccessibleName = "Index";
			toolStripLabelGoToIndex.AccessibleRole = AccessibleRole.StaticText;
			toolStripLabelGoToIndex.AutoToolTip = true;
			toolStripLabelGoToIndex.Name = "toolStripLabelGoToIndex";
			toolStripLabelGoToIndex.Size = new Size(71, 22);
			toolStripLabelGoToIndex.Text = "Go to index:";
			toolStripLabelGoToIndex.MouseEnter += SetStatusbar_Enter;
			toolStripLabelGoToIndex.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripTextBoxGotoIndex
			// 
			toolStripTextBoxGotoIndex.AcceptsReturn = true;
			toolStripTextBoxGotoIndex.AccessibleDescription = "Enter the index number of the planetoid";
			toolStripTextBoxGotoIndex.AccessibleName = "Index field";
			toolStripTextBoxGotoIndex.AccessibleRole = AccessibleRole.Text;
			toolStripTextBoxGotoIndex.AutoToolTip = true;
			toolStripTextBoxGotoIndex.Name = "toolStripTextBoxGotoIndex";
			toolStripTextBoxGotoIndex.Size = new Size(80, 25);
			toolStripTextBoxGotoIndex.TextBoxTextAlign = HorizontalAlignment.Center;
			toolStripTextBoxGotoIndex.Enter += SetStatusbar_Enter;
			toolStripTextBoxGotoIndex.Leave += ClearStatusbar_Leave;
			toolStripTextBoxGotoIndex.KeyPress += ToolStripTextBoxGotoIndex_KeyPress;
			toolStripTextBoxGotoIndex.MouseEnter += SetStatusbar_Enter;
			toolStripTextBoxGotoIndex.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonGoToIndex
			// 
			toolStripButtonGoToIndex.AccessibleDescription = "Click to show the data of the planetoid";
			toolStripButtonGoToIndex.AccessibleName = "Go to index";
			toolStripButtonGoToIndex.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonGoToIndex.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonGoToIndex.Image = Properties.Resources.silk_go;
			toolStripButtonGoToIndex.ImageTransparentColor = Color.Magenta;
			toolStripButtonGoToIndex.Name = "toolStripButtonGoToIndex";
			toolStripButtonGoToIndex.Size = new Size(23, 22);
			toolStripButtonGoToIndex.Text = "Go to index";
			toolStripButtonGoToIndex.Click += ToolStripButtonGoToIndex_Click;
			toolStripButtonGoToIndex.MouseEnter += SetStatusbar_Enter;
			toolStripButtonGoToIndex.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonListReadableDesignations
			// 
			toolStripButtonListReadableDesignations.AccessibleDescription = "Click to show the list pf the readable designations";
			toolStripButtonListReadableDesignations.AccessibleName = "List readable designations";
			toolStripButtonListReadableDesignations.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonListReadableDesignations.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonListReadableDesignations.Image = Properties.Resources.silk_page_white_text;
			toolStripButtonListReadableDesignations.ImageTransparentColor = Color.Magenta;
			toolStripButtonListReadableDesignations.Name = "toolStripButtonListReadableDesignations";
			toolStripButtonListReadableDesignations.Size = new Size(23, 22);
			toolStripButtonListReadableDesignations.Text = "List readable designations";
			toolStripButtonListReadableDesignations.Click += ToolStripButtonListReadableDesignations_Click;
			toolStripButtonListReadableDesignations.MouseEnter += SetStatusbar_Enter;
			toolStripButtonListReadableDesignations.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator9
			// 
			toolStripSeparator9.AccessibleDescription = "Just a separator";
			toolStripSeparator9.AccessibleName = "Just a separator";
			toolStripSeparator9.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator9.Name = "toolStripSeparator9";
			toolStripSeparator9.Size = new Size(6, 25);
			toolStripSeparator9.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator9.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonDerivatedOrbitElements
			// 
			toolStripButtonDerivatedOrbitElements.AccessibleDescription = "Calculates derivated orbital elements";
			toolStripButtonDerivatedOrbitElements.AccessibleName = "Derivated orbit elements";
			toolStripButtonDerivatedOrbitElements.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonDerivatedOrbitElements.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonDerivatedOrbitElements.Image = Properties.Resources.silk_arrow_branch;
			toolStripButtonDerivatedOrbitElements.ImageTransparentColor = Color.Magenta;
			toolStripButtonDerivatedOrbitElements.Name = "toolStripButtonDerivatedOrbitElements";
			toolStripButtonDerivatedOrbitElements.Size = new Size(23, 22);
			toolStripButtonDerivatedOrbitElements.Text = "Derivated orbit elements";
			toolStripButtonDerivatedOrbitElements.Click += ToolStripButtonDerivatedOrbitElements_Click;
			toolStripButtonDerivatedOrbitElements.MouseEnter += SetStatusbar_Enter;
			toolStripButtonDerivatedOrbitElements.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonFilter
			// 
			toolStripButtonFilter.AccessibleDescription = "Filters the orbital elements in some ranges";
			toolStripButtonFilter.AccessibleName = "Filter";
			toolStripButtonFilter.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonFilter.Enabled = false;
			toolStripButtonFilter.Image = Properties.Resources.silk_arrow_divide;
			toolStripButtonFilter.ImageTransparentColor = Color.Magenta;
			toolStripButtonFilter.Name = "toolStripButtonFilter";
			toolStripButtonFilter.Size = new Size(23, 22);
			toolStripButtonFilter.Text = "Filter";
			toolStripButtonFilter.Click += ToolStripButtonFilter_Click;
			toolStripButtonFilter.MouseEnter += SetStatusbar_Enter;
			toolStripButtonFilter.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparatorOptions2
			// 
			toolStripSeparatorOptions2.AccessibleDescription = "Just a separator";
			toolStripSeparatorOptions2.AccessibleName = "Just a separator";
			toolStripSeparatorOptions2.Name = "toolStripSeparatorOptions2";
			toolStripSeparatorOptions2.Size = new Size(6, 6);
			// 
			// toolStripSeparatorOptions1
			// 
			toolStripSeparatorOptions1.AccessibleDescription = "Just a separator";
			toolStripSeparatorOptions1.AccessibleName = "Just a separator";
			toolStripSeparatorOptions1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparatorOptions1.Name = "toolStripSeparatorOptions1";
			toolStripSeparatorOptions1.Size = new Size(6, 6);
			// 
			// backgroundWorkerLoadingDatabase
			// 
			backgroundWorkerLoadingDatabase.WorkerReportsProgress = true;
			backgroundWorkerLoadingDatabase.WorkerSupportsCancellation = true;
			backgroundWorkerLoadingDatabase.DoWork += BackgroundWorkerLoadingDatabase_DoWork;
			backgroundWorkerLoadingDatabase.ProgressChanged += BackgroundWorkerLoadingDatabase_ProgressChanged;
			backgroundWorkerLoadingDatabase.RunWorkerCompleted += BackgroundWorkerLoadingDatabase_RunWorkerCompleted;
			// 
			// timerBlinkForUpdateAvailable
			// 
			timerBlinkForUpdateAvailable.Interval = 500;
			timerBlinkForUpdateAvailable.Tick += TimerBlinkForUpdateAvailable_Tick;
			// 
			// timerCheckForNewMpcorbDatFile
			// 
			timerCheckForNewMpcorbDatFile.Enabled = true;
			timerCheckForNewMpcorbDatFile.Interval = 1440000;
			timerCheckForNewMpcorbDatFile.Tick += TimerCheckForNewMpcorbDatFile_Tick;
			// 
			// PlanetoidDBForm
			// 
			AccessibleDescription = "Viewer for the MPC Orbit (MPCORB) Database";
			AccessibleName = "Planetoid-DB";
			AccessibleRole = AccessibleRole.Window;
			AllowButtonSpecToolTips = true;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoValidate = AutoValidate.EnablePreventFocusChange;
			ClientSize = new Size(804, 386);
			Controls.Add(toolStripContainer);
			CornerRoundingRadius = 5F;
			Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menu;
			MaximizeBox = false;
			Name = "PlanetoidDBForm";
			StartPosition = FormStartPosition.CenterScreen;
			StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
			StateCommon.Border.Rounding = 5F;
			Text = "Planetoid-DB";
			TextExtra = "x.x.x.x";
			toolTip.SetToolTip(this, "Planetoid-DB");
			FormClosing += PlanetoidDBForm_FormClosing;
			Load += PlanetoidDBForm_Load;
			Shown += PlanetoidDBForm_Shown;
			contextMenuNavigationStep.ResumeLayout(false);
			tableLayoutPanelData.ResumeLayout(false);
			tableLayoutPanelData.PerformLayout();
			contextMenuTopTenRecords.ResumeLayout(false);
			contextMenuDistributions.ResumeLayout(false);
			contextMenuCopyToClipboardOrbitalElements.ResumeLayout(false);
			menu.ResumeLayout(false);
			menu.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			statusBar.ResumeLayout(false);
			statusBar.PerformLayout();
			toolStripIcons.ResumeLayout(false);
			toolStripIcons.PerformLayout();
			toolStripNavigation.ResumeLayout(false);
			toolStripNavigation.PerformLayout();
			ResumeLayout(false);
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
		private ToolStripButton toolStripButtonListReadableDesignations;
		private ToolStripSeparator toolStripSeparator11;
		private ToolStripMenuItem menuitemListReadableDesignations;
		private ToolStripMenuItem menuitemRestartWithDemoData;
		private ToolStripButton toolStripButtonSearch;
	}
}

