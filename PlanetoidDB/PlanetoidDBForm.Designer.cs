namespace PlanetoidDB
{
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
      this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
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
      this.statusBar = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelUpdate = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabelBackgroundDownload = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripProgressBarBackgroundDownload = new System.Windows.Forms.ToolStripProgressBar();
      this.labelHelp = new System.Windows.Forms.ToolStripStatusLabel();
      this.numericUpDownGotoIndex = new System.Windows.Forms.NumericUpDown();
      this.labelIndexPos = new System.Windows.Forms.Label();
      this.menu = new System.Windows.Forms.MenuStrip();
      this.menuitemFile = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemCheckMpcorbDat = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemDownloadMpcorbDat = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemQuest = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparatorMisc = new System.Windows.Forms.ToolStripSeparator();
      this.menuitemOpenWebsitePDB = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemOpenWebsiteMPC = new System.Windows.Forms.ToolStripMenuItem();
      this.menuitemOpenMPCORBWebsite = new System.Windows.Forms.ToolStripMenuItem();
      this.trackBarIndex = new System.Windows.Forms.TrackBar();
      this.buttonGotoIndex = new System.Windows.Forms.Button();
      this.buttonStepForward = new System.Windows.Forms.Button();
      this.buttonStepToEnd = new System.Windows.Forms.Button();
      this.buttonStepForward1 = new System.Windows.Forms.Button();
      this.buttonStepBackward1 = new System.Windows.Forms.Button();
      this.buttonStepBackward = new System.Windows.Forms.Button();
      this.buttonStepToBegin = new System.Windows.Forms.Button();
      this.labelGottoIndex = new System.Windows.Forms.Label();
      this.ofd = new System.Windows.Forms.OpenFileDialog();
      this.backgroundWorkerLoadingDB = new System.ComponentModel.BackgroundWorker();
      this.timerUpdateBlink = new System.Windows.Forms.Timer(this.components);
      this.contextMenu.SuspendLayout();
      this.tableLayoutPanelData.SuspendLayout();
      this.statusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGotoIndex)).BeginInit();
      this.menu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarIndex)).BeginInit();
      this.SuspendLayout();
      // 
      // contextMenu
      // 
      this.contextMenu.AccessibleDescription = "Show the context name of data items";
      this.contextMenu.AccessibleName = "Context menu of items";
      this.contextMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
      this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem100,
            this.toolStripMenuItem1000,
            this.toolStripMenuItem10000,
            this.toolStripMenuItem100000});
      this.contextMenu.Name = "contextMenu";
      this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.contextMenu.ShowCheckMargin = true;
      this.contextMenu.ShowImageMargin = false;
      this.contextMenu.Size = new System.Drawing.Size(111, 114);
      this.contextMenu.Text = "contextMenu";
      this.toolTip.SetToolTip(this.contextMenu, "Show the context name of data items");
      // 
      // toolStripMenuItem10
      // 
      this.toolStripMenuItem10.CheckOnClick = true;
      this.toolStripMenuItem10.Name = "toolStripMenuItem10";
      this.toolStripMenuItem10.Size = new System.Drawing.Size(110, 22);
      this.toolStripMenuItem10.Text = "10";
      this.toolStripMenuItem10.ToolTipText = "Jump 10 items backward/forward";
      this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
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
      this.toolStripMenuItem100.Click += new System.EventHandler(this.toolStripMenuItem100_Click);
      // 
      // toolStripMenuItem1000
      // 
      this.toolStripMenuItem1000.CheckOnClick = true;
      this.toolStripMenuItem1000.Name = "toolStripMenuItem1000";
      this.toolStripMenuItem1000.Size = new System.Drawing.Size(110, 22);
      this.toolStripMenuItem1000.Text = "1000";
      this.toolStripMenuItem1000.ToolTipText = "Jump 1000 items backward/forward";
      this.toolStripMenuItem1000.Click += new System.EventHandler(this.toolStripMenuItem1000_Click);
      // 
      // toolStripMenuItem10000
      // 
      this.toolStripMenuItem10000.CheckOnClick = true;
      this.toolStripMenuItem10000.Name = "toolStripMenuItem10000";
      this.toolStripMenuItem10000.Size = new System.Drawing.Size(110, 22);
      this.toolStripMenuItem10000.Text = "10000";
      this.toolStripMenuItem10000.ToolTipText = "Jump 10000 items backward/forward";
      this.toolStripMenuItem10000.Click += new System.EventHandler(this.toolStripMenuItem10000_Click);
      // 
      // toolStripMenuItem100000
      // 
      this.toolStripMenuItem100000.CheckOnClick = true;
      this.toolStripMenuItem100000.Name = "toolStripMenuItem100000";
      this.toolStripMenuItem100000.Size = new System.Drawing.Size(110, 22);
      this.toolStripMenuItem100000.Text = "100000";
      this.toolStripMenuItem100000.ToolTipText = "Jump 100000 items backward/forward";
      this.toolStripMenuItem100000.Click += new System.EventHandler(this.toolStripMenuItem100000_Click);
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
      this.labelIndex.Click += new System.EventHandler(this.labelIndex_Click);
      this.labelIndex.DoubleClick += new System.EventHandler(this.labelIndex_DoubleClick);
      this.labelIndex.MouseEnter += new System.EventHandler(this.labelIndex_MouseEnter);
      this.labelIndex.MouseLeave += new System.EventHandler(this.labelIndex_MouseLeave);
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
      this.labelMagAbs.Click += new System.EventHandler(this.labelMagAbs_Click);
      this.labelMagAbs.DoubleClick += new System.EventHandler(this.labelMagAbs_DoubleClick);
      this.labelMagAbs.MouseEnter += new System.EventHandler(this.labelMagAbs_MouseEnter);
      this.labelMagAbs.MouseLeave += new System.EventHandler(this.labelMagAbs_MouseLeave);
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
      this.labelSlopeParam.Click += new System.EventHandler(this.labelSlopeParam_Click);
      this.labelSlopeParam.DoubleClick += new System.EventHandler(this.labelSlopeParam_DoubleClick);
      this.labelSlopeParam.MouseEnter += new System.EventHandler(this.labelSlopeParam_MouseEnter);
      this.labelSlopeParam.MouseLeave += new System.EventHandler(this.labelSlopeParam_MouseLeave);
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
      this.labelEpoch.Click += new System.EventHandler(this.labelEpoch_Click);
      this.labelEpoch.DoubleClick += new System.EventHandler(this.labelEpoch_DoubleClick);
      this.labelEpoch.MouseEnter += new System.EventHandler(this.labelEpoch_MouseEnter);
      this.labelEpoch.MouseLeave += new System.EventHandler(this.labelEpoch_MouseLeave);
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
      this.labelMeanAnomaly.Click += new System.EventHandler(this.labelMeanAnomaly_Click);
      this.labelMeanAnomaly.DoubleClick += new System.EventHandler(this.labelMeanAnomaly_DoubleClick);
      this.labelMeanAnomaly.MouseEnter += new System.EventHandler(this.labelMeanAnomaly_MouseEnter);
      this.labelMeanAnomaly.MouseLeave += new System.EventHandler(this.labelMeanAnomaly_MouseLeave);
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
      this.labelArgPeri.Click += new System.EventHandler(this.labelArgPeri_Click);
      this.labelArgPeri.DoubleClick += new System.EventHandler(this.labelArgPeri_DoubleClick);
      this.labelArgPeri.MouseEnter += new System.EventHandler(this.labelArgPeri_MouseEnter);
      this.labelArgPeri.MouseLeave += new System.EventHandler(this.labelArgPeri_MouseLeave);
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
      this.labelLongAscNode.Click += new System.EventHandler(this.labelLongAscNode_Click);
      this.labelLongAscNode.DoubleClick += new System.EventHandler(this.labelLongAscNode_DoubleClick);
      this.labelLongAscNode.MouseEnter += new System.EventHandler(this.labelLongAscNode_MouseEnter);
      this.labelLongAscNode.MouseLeave += new System.EventHandler(this.labelLongAscNode_MouseLeave);
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
      this.labelIncl.Click += new System.EventHandler(this.labelIncl_Click);
      this.labelIncl.DoubleClick += new System.EventHandler(this.labelIncl_DoubleClick);
      this.labelIncl.MouseEnter += new System.EventHandler(this.labelIncl_MouseEnter);
      this.labelIncl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelIncl_MouseMove);
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
      this.labelOrbEcc.Click += new System.EventHandler(this.labelOrbEcc_Click);
      this.labelOrbEcc.DoubleClick += new System.EventHandler(this.labelOrbEcc_DoubleClick);
      this.labelOrbEcc.MouseEnter += new System.EventHandler(this.labelOrbEcc_MouseEnter);
      this.labelOrbEcc.MouseLeave += new System.EventHandler(this.labelOrbEcc_MouseLeave);
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
      this.labelMotion.Click += new System.EventHandler(this.labelMotion_Click);
      this.labelMotion.DoubleClick += new System.EventHandler(this.labelMotion_DoubleClick);
      this.labelMotion.MouseEnter += new System.EventHandler(this.labelMotion_MouseEnter);
      this.labelMotion.MouseLeave += new System.EventHandler(this.labelMotion_MouseLeave);
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
      this.labelSemiMajorAxis.Click += new System.EventHandler(this.labelSemiMajorAxis_Click);
      this.labelSemiMajorAxis.DoubleClick += new System.EventHandler(this.labelSemiMajorAxis_DoubleClick);
      this.labelSemiMajorAxis.MouseEnter += new System.EventHandler(this.labelSemiMajorAxis_MouseEnter);
      this.labelSemiMajorAxis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelSemiMajorAxis_MouseMove);
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
      this.labelRef.Click += new System.EventHandler(this.labelRef_Click);
      this.labelRef.DoubleClick += new System.EventHandler(this.labelRef_DoubleClick);
      this.labelRef.MouseEnter += new System.EventHandler(this.labelRef_MouseEnter);
      this.labelRef.MouseLeave += new System.EventHandler(this.labelRef_MouseLeave);
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
      this.labelNumbObs.Click += new System.EventHandler(this.labelNumbObs_Click);
      this.labelNumbObs.DoubleClick += new System.EventHandler(this.labelNumbObs_DoubleClick);
      this.labelNumbObs.MouseEnter += new System.EventHandler(this.labelNumbObs_MouseEnter);
      this.labelNumbObs.MouseLeave += new System.EventHandler(this.labelNumbObs_MouseLeave);
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
      this.labelNumbOppos.Click += new System.EventHandler(this.labelNumbOppos_Click);
      this.labelNumbOppos.DoubleClick += new System.EventHandler(this.labelNumbOppos_DoubleClick);
      this.labelNumbOppos.MouseEnter += new System.EventHandler(this.labelNumbOppos_MouseEnter);
      this.labelNumbOppos.MouseLeave += new System.EventHandler(this.labelNumbOppos_MouseLeave);
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
      this.labelObsSpan.Size = new System.Drawing.Size(108, 21);
      this.labelObsSpan.TabIndex = 20;
      this.labelObsSpan.Text = "observation span";
      this.toolTip.SetToolTip(this.labelObsSpan, "Observation span");
      this.labelObsSpan.Click += new System.EventHandler(this.labelObsSpan_Click);
      this.labelObsSpan.DoubleClick += new System.EventHandler(this.labelObsSpan_DoubleClick);
      this.labelObsSpan.MouseEnter += new System.EventHandler(this.labelObsSpan_MouseEnter);
      this.labelObsSpan.MouseLeave += new System.EventHandler(this.labelObsSpan_MouseLeave);
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
      this.labelRmsResidual.Click += new System.EventHandler(this.labelRmsResidual_Click);
      this.labelRmsResidual.DoubleClick += new System.EventHandler(this.labelRmsResidual_DoubleClick);
      this.labelRmsResidual.MouseEnter += new System.EventHandler(this.labelRmsResidual_MouseEnter);
      this.labelRmsResidual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelRmsResidual_MouseMove);
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
      this.labelComputerName.Click += new System.EventHandler(this.labelComputerName_Click);
      this.labelComputerName.MouseCaptureChanged += new System.EventHandler(this.labelComputerName_MouseCaptureChanged);
      this.labelComputerName.MouseEnter += new System.EventHandler(this.labelComputerName_MouseEnter);
      this.labelComputerName.MouseLeave += new System.EventHandler(this.labelComputerName_MouseLeave);
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
      this.labelDesgnName.Click += new System.EventHandler(this.labelDesgnName_Click);
      this.labelDesgnName.DoubleClick += new System.EventHandler(this.labelDesgnName_DoubleClick);
      this.labelDesgnName.MouseEnter += new System.EventHandler(this.labelDesgnName_MouseEnter);
      this.labelDesgnName.MouseLeave += new System.EventHandler(this.labelDesgnName_MouseLeave);
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
      this.labelObsLastDate.Click += new System.EventHandler(this.labelObsLastDate_Click);
      this.labelObsLastDate.DoubleClick += new System.EventHandler(this.labelObsLastDate_DoubleClick);
      this.labelObsLastDate.MouseEnter += new System.EventHandler(this.labelObsLastDate_MouseEnter);
      this.labelObsLastDate.MouseLeave += new System.EventHandler(this.labelObsLastDate_MouseLeave);
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
      this.labelFlags.Click += new System.EventHandler(this.labelFlags_Click);
      this.labelFlags.MouseCaptureChanged += new System.EventHandler(this.labelFlags_MouseCaptureChanged);
      this.labelFlags.MouseEnter += new System.EventHandler(this.labelFlags_MouseEnter);
      this.labelFlags.MouseLeave += new System.EventHandler(this.labelFlags_MouseLeave);
      // 
      // tableLayoutPanelData
      // 
      this.tableLayoutPanelData.AccessibleDescription = "Group the data";
      this.tableLayoutPanelData.AccessibleName = "Table Panel";
      this.tableLayoutPanelData.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
      this.tableLayoutPanelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanelData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
      this.tableLayoutPanelData.Location = new System.Drawing.Point(12, 129);
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
      this.labelDesgnNameValue.DoubleClick += new System.EventHandler(this.labelDesgnNameValue_DoubleClick);
      this.labelDesgnNameValue.MouseEnter += new System.EventHandler(this.labelDesgnNameValue_MouseEnter);
      this.labelDesgnNameValue.MouseLeave += new System.EventHandler(this.labelDesgnNameValue_MouseLeave);
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
      this.labelEpochValue.DoubleClick += new System.EventHandler(this.labelEpochValue_DoubleClick);
      this.labelEpochValue.MouseEnter += new System.EventHandler(this.labelEpochValue_MouseEnter);
      this.labelEpochValue.MouseLeave += new System.EventHandler(this.labelEpochValue_MouseLeave);
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
      this.labelMeanAnomalyValue.DoubleClick += new System.EventHandler(this.labelMeanAnomalyValue_DoubleClick);
      this.labelMeanAnomalyValue.MouseEnter += new System.EventHandler(this.labelMeanAnomalyValue_MouseEnter);
      this.labelMeanAnomalyValue.MouseLeave += new System.EventHandler(this.labelMeanAnomalyValue_MouseLeave);
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
      this.labelArgPeriValue.DoubleClick += new System.EventHandler(this.labelArgPeriValue_DoubleClick);
      this.labelArgPeriValue.MouseEnter += new System.EventHandler(this.labelArgPeriValue_MouseEnter);
      this.labelArgPeriValue.MouseLeave += new System.EventHandler(this.labelArgPeriValue_MouseLeave);
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
      this.labelLongAscNodeValue.DoubleClick += new System.EventHandler(this.labelLongAscNodeValue_DoubleClick);
      this.labelLongAscNodeValue.MouseEnter += new System.EventHandler(this.labelLongAscNodeValue_MouseEnter);
      this.labelLongAscNodeValue.MouseLeave += new System.EventHandler(this.labelLongAscNodeValue_MouseLeave);
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
      this.labelInclValue.DoubleClick += new System.EventHandler(this.labelInclValue_DoubleClick);
      this.labelInclValue.MouseEnter += new System.EventHandler(this.labelInclValue_MouseEnter);
      this.labelInclValue.MouseLeave += new System.EventHandler(this.labelInclValue_MouseLeave);
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
      this.labelOrbEccValue.DoubleClick += new System.EventHandler(this.labelOrbEccValue_DoubleClick);
      this.labelOrbEccValue.MouseEnter += new System.EventHandler(this.labelOrbEccValue_MouseEnter);
      this.labelOrbEccValue.MouseLeave += new System.EventHandler(this.labelOrbEccValue_MouseLeave);
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
      this.labelMotionValue.DoubleClick += new System.EventHandler(this.labelMotionValue_DoubleClick);
      this.labelMotionValue.MouseEnter += new System.EventHandler(this.labelMotionValue_MouseEnter);
      this.labelMotionValue.MouseLeave += new System.EventHandler(this.labelMotionValue_MouseLeave);
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
      this.labelSemiMajorAxisValue.DoubleClick += new System.EventHandler(this.labelSemiMajorAxisValue_DoubleClick);
      this.labelSemiMajorAxisValue.MouseEnter += new System.EventHandler(this.labelSemiMajorAxisValue_MouseEnter);
      this.labelSemiMajorAxisValue.MouseLeave += new System.EventHandler(this.labelSemiMajorAxisValue_MouseLeave);
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
      this.labelSlopeParamValue.DoubleClick += new System.EventHandler(this.labelSlopeParamValue_DoubleClick);
      this.labelSlopeParamValue.MouseEnter += new System.EventHandler(this.labelSlopeParamValue_MouseEnter);
      this.labelSlopeParamValue.MouseLeave += new System.EventHandler(this.labelSlopeParamValue_MouseLeave);
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
      this.labelIndexValue.DoubleClick += new System.EventHandler(this.labelIndexValue_DoubleClick);
      this.labelIndexValue.MouseEnter += new System.EventHandler(this.labelIndexValue_MouseEnter);
      this.labelIndexValue.MouseLeave += new System.EventHandler(this.labelIndexValue_MouseLeave);
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
      this.labelMagAbsValue.DoubleClick += new System.EventHandler(this.labelMagAbsValue_DoubleClick);
      this.labelMagAbsValue.MouseEnter += new System.EventHandler(this.labelMagAbsValue_MouseEnter);
      this.labelMagAbsValue.MouseLeave += new System.EventHandler(this.labelMagAbsValue_MouseLeave);
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
      this.labelRefValue.DoubleClick += new System.EventHandler(this.labelRefValue_DoubleClick);
      this.labelRefValue.MouseEnter += new System.EventHandler(this.labelRefValue_MouseEnter);
      this.labelRefValue.MouseLeave += new System.EventHandler(this.labelRefValue_MouseLeave);
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
      this.labelNumbOpposValue.DoubleClick += new System.EventHandler(this.labelNumbOpposValue_DoubleClick);
      this.labelNumbOpposValue.MouseEnter += new System.EventHandler(this.labelNumbOpposValue_MouseEnter);
      this.labelNumbOpposValue.MouseLeave += new System.EventHandler(this.labelNumbOpposValue_MouseLeave);
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
      this.labelNumbObsValue.DoubleClick += new System.EventHandler(this.labelNumbObsValue_DoubleClick);
      this.labelNumbObsValue.MouseEnter += new System.EventHandler(this.labelNumbObsValue_MouseEnter);
      this.labelNumbObsValue.MouseLeave += new System.EventHandler(this.labelNumbObsValue_MouseLeave);
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
      this.labelObsSpanValue.DoubleClick += new System.EventHandler(this.labelObsSpanValue_DoubleClick);
      this.labelObsSpanValue.MouseEnter += new System.EventHandler(this.labelObsSpanValue_MouseEnter);
      this.labelObsSpanValue.MouseLeave += new System.EventHandler(this.labelObsSpanValue_MouseLeave);
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
      this.labelRmsResidualValue.DoubleClick += new System.EventHandler(this.labelRmsResidualValue_DoubleClick);
      this.labelRmsResidualValue.MouseEnter += new System.EventHandler(this.labelRmsResidualValue_MouseEnter);
      this.labelRmsResidualValue.MouseLeave += new System.EventHandler(this.labelRmsResidualValue_MouseLeave);
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
      this.labelComputerNameValue.DoubleClick += new System.EventHandler(this.labelComputerNameValue_DoubleClick);
      this.labelComputerNameValue.MouseEnter += new System.EventHandler(this.labelComputerNameValue_MouseEnter);
      this.labelComputerNameValue.MouseLeave += new System.EventHandler(this.labelComputerNameValue_MouseLeave);
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
      this.labelFlagsValue.DoubleClick += new System.EventHandler(this.labelFlagsValue_DoubleClick);
      this.labelFlagsValue.MouseEnter += new System.EventHandler(this.labelFlagsValue_MouseEnter);
      this.labelFlagsValue.MouseLeave += new System.EventHandler(this.labelFlagsValue_MouseLeave);
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
      this.labelObsLastDateValue.DoubleClick += new System.EventHandler(this.labelObsLastDateValue_DoubleClick);
      this.labelObsLastDateValue.MouseEnter += new System.EventHandler(this.labelObsLastDateValue_MouseEnter);
      this.labelObsLastDateValue.MouseLeave += new System.EventHandler(this.labelObsLastDateValue_MouseLeave);
      // 
      // statusBar
      // 
      this.statusBar.AccessibleDescription = "Shows some information";
      this.statusBar.AccessibleName = "Status bar of some inforamt";
      this.statusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
      this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUpdate,
            this.toolStripStatusLabelBackgroundDownload,
            this.toolStripProgressBarBackgroundDownload,
            this.labelHelp});
      this.statusBar.Location = new System.Drawing.Point(0, 377);
      this.statusBar.Name = "statusBar";
      this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.statusBar.ShowItemToolTips = true;
      this.statusBar.Size = new System.Drawing.Size(745, 22);
      this.statusBar.SizingGrip = false;
      this.statusBar.TabIndex = 13;
      this.statusBar.TabStop = true;
      this.statusBar.Text = "statusStrip";
      this.toolTip.SetToolTip(this.statusBar, "Shows some information");
      // 
      // toolStripStatusLabelUpdate
      // 
      this.toolStripStatusLabelUpdate.AccessibleDescription = "Show that an MPCORB.DAT update is aviable";
      this.toolStripStatusLabelUpdate.AccessibleName = "Update information";
      this.toolStripStatusLabelUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.toolStripStatusLabelUpdate.DoubleClickEnabled = true;
      this.toolStripStatusLabelUpdate.Image = global::PlanetoidDB.Properties.Resources.silk_lightning;
      this.toolStripStatusLabelUpdate.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
      this.toolStripStatusLabelUpdate.Name = "toolStripStatusLabelUpdate";
      this.toolStripStatusLabelUpdate.Size = new System.Drawing.Size(138, 17);
      this.toolStripStatusLabelUpdate.Text = "MPCORB.DAT update";
      this.toolStripStatusLabelUpdate.ToolTipText = "MPCORB.DAT update aviable";
      this.toolStripStatusLabelUpdate.Click += new System.EventHandler(this.toolStripStatusLabelUpdate_Click);
      this.toolStripStatusLabelUpdate.DoubleClick += new System.EventHandler(this.toolStripStatusLabelUpdate_DoubleClick);
      this.toolStripStatusLabelUpdate.MouseEnter += new System.EventHandler(this.toolStripStatusLabelUpdate_MouseEnter);
      this.toolStripStatusLabelUpdate.MouseLeave += new System.EventHandler(this.toolStripStatusLabelUpdate_MouseLeave);
      // 
      // toolStripStatusLabelBackgroundDownload
      // 
      this.toolStripStatusLabelBackgroundDownload.AccessibleDescription = "Show the download progres";
      this.toolStripStatusLabelBackgroundDownload.AccessibleName = "Download progress";
      this.toolStripStatusLabelBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.toolStripStatusLabelBackgroundDownload.DoubleClickEnabled = true;
      this.toolStripStatusLabelBackgroundDownload.Image = global::PlanetoidDB.Properties.Resources.silk_package_go;
      this.toolStripStatusLabelBackgroundDownload.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
      this.toolStripStatusLabelBackgroundDownload.Name = "toolStripStatusLabelBackgroundDownload";
      this.toolStripStatusLabelBackgroundDownload.Size = new System.Drawing.Size(80, 17);
      this.toolStripStatusLabelBackgroundDownload.Text = "Download:";
      this.toolStripStatusLabelBackgroundDownload.ToolTipText = "Show the download progres";
      this.toolStripStatusLabelBackgroundDownload.DoubleClick += new System.EventHandler(this.toolStripStatusLabelBackgroundDownload_DoubleClick);
      this.toolStripStatusLabelBackgroundDownload.MouseEnter += new System.EventHandler(this.toolStripStatusLabelBackgroundDownload_MouseEnter);
      this.toolStripStatusLabelBackgroundDownload.MouseLeave += new System.EventHandler(this.toolStripStatusLabelBackgroundDownload_MouseLeave);
      // 
      // toolStripProgressBarBackgroundDownload
      // 
      this.toolStripProgressBarBackgroundDownload.AccessibleDescription = "Show the download progres";
      this.toolStripProgressBarBackgroundDownload.AccessibleName = "Download progress";
      this.toolStripProgressBarBackgroundDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
      this.toolStripProgressBarBackgroundDownload.Enabled = false;
      this.toolStripProgressBarBackgroundDownload.Name = "toolStripProgressBarBackgroundDownload";
      this.toolStripProgressBarBackgroundDownload.Size = new System.Drawing.Size(100, 16);
      this.toolStripProgressBarBackgroundDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.toolStripProgressBarBackgroundDownload.ToolTipText = "Show the download progres";
      this.toolStripProgressBarBackgroundDownload.DoubleClick += new System.EventHandler(this.toolStripProgressBarBackgroundDownload_DoubleClick);
      this.toolStripProgressBarBackgroundDownload.MouseEnter += new System.EventHandler(this.toolStripProgressBarBackgroundDownload_MouseEnter);
      this.toolStripProgressBarBackgroundDownload.MouseLeave += new System.EventHandler(this.toolStripProgressBarBackgroundDownload_MouseLeave);
      // 
      // labelHelp
      // 
      this.labelHelp.AccessibleDescription = "Show some information";
      this.labelHelp.AccessibleName = "Show some information";
      this.labelHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelHelp.DoubleClickEnabled = true;
      this.labelHelp.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
      this.labelHelp.Name = "labelHelp";
      this.labelHelp.Size = new System.Drawing.Size(100, 17);
      this.labelHelp.Text = "Show tooltip here";
      this.labelHelp.ToolTipText = "Show some information";
      // 
      // numericUpDownGotoIndex
      // 
      this.numericUpDownGotoIndex.AccessibleDescription = "Enter the index no. of the planetoid";
      this.numericUpDownGotoIndex.AccessibleName = "Index field";
      this.numericUpDownGotoIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
      this.numericUpDownGotoIndex.Location = new System.Drawing.Point(620, 36);
      this.numericUpDownGotoIndex.Name = "numericUpDownGotoIndex";
      this.numericUpDownGotoIndex.Size = new System.Drawing.Size(78, 23);
      this.numericUpDownGotoIndex.TabIndex = 9;
      this.numericUpDownGotoIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip.SetToolTip(this.numericUpDownGotoIndex, "Enter the index no. of the planetoid");
      // 
      // labelIndexPos
      // 
      this.labelIndexPos.AccessibleDescription = "Show the current index position";
      this.labelIndexPos.AccessibleName = "Index-Info";
      this.labelIndexPos.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.labelIndexPos.AutoSize = true;
      this.labelIndexPos.Location = new System.Drawing.Point(292, 40);
      this.labelIndexPos.Name = "labelIndexPos";
      this.labelIndexPos.Size = new System.Drawing.Size(52, 15);
      this.labelIndexPos.TabIndex = 7;
      this.labelIndexPos.Text = "Index: ...";
      this.toolTip.SetToolTip(this.labelIndexPos, "Show the current index position");
      // 
      // menu
      // 
      this.menu.AccessibleDescription = "Show the menubar";
      this.menu.AccessibleName = "menu";
      this.menu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemFile,
            this.menuitemOptions,
            this.menuitemQuest});
      this.menu.Location = new System.Drawing.Point(0, 0);
      this.menu.Name = "menu";
      this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.menu.Size = new System.Drawing.Size(745, 24);
      this.menu.TabIndex = 0;
      this.menu.Text = "menu";
      this.toolTip.SetToolTip(this.menu, "Show the menubar");
      // 
      // menuitemFile
      // 
      this.menuitemFile.AccessibleDescription = "Show file operations";
      this.menuitemFile.AccessibleName = "File";
      this.menuitemFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
      this.menuitemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemExit});
      this.menuitemFile.Name = "menuitemFile";
      this.menuitemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
      this.menuitemFile.Size = new System.Drawing.Size(37, 20);
      this.menuitemFile.Text = "&File";
      this.menuitemFile.MouseEnter += new System.EventHandler(this.menuitemFile_MouseEnter);
      this.menuitemFile.MouseLeave += new System.EventHandler(this.menuitemFile_MouseLeave);
      // 
      // menuitemExit
      // 
      this.menuitemExit.AccessibleDescription = "Exit the application";
      this.menuitemExit.AccessibleName = "Exit";
      this.menuitemExit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.menuitemExit.Image = global::PlanetoidDB.Properties.Resources.silk_door_in;
      this.menuitemExit.Name = "menuitemExit";
      this.menuitemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
      this.menuitemExit.Size = new System.Drawing.Size(129, 22);
      this.menuitemExit.Text = "E&xit";
      this.menuitemExit.ToolTipText = "Exit the application";
      this.menuitemExit.Click += new System.EventHandler(this.menuitemExit_Click);
      this.menuitemExit.MouseEnter += new System.EventHandler(this.menuitemExit_MouseEnter);
      this.menuitemExit.MouseLeave += new System.EventHandler(this.menuitemExit_MouseLeave);
      // 
      // menuitemOptions
      // 
      this.menuitemOptions.AccessibleDescription = "Show the options";
      this.menuitemOptions.AccessibleName = "Options";
      this.menuitemOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
      this.menuitemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemCheckMpcorbDat,
            this.menuitemDownloadMpcorbDat});
      this.menuitemOptions.Name = "menuitemOptions";
      this.menuitemOptions.Size = new System.Drawing.Size(61, 20);
      this.menuitemOptions.Text = "&Options";
      this.menuitemOptions.ToolTipText = "Show the options";
      this.menuitemOptions.MouseEnter += new System.EventHandler(this.menuitemOptions_MouseEnter);
      this.menuitemOptions.MouseLeave += new System.EventHandler(this.menuitemOptions_MouseLeave);
      // 
      // menuitemCheckMpcorbDat
      // 
      this.menuitemCheckMpcorbDat.AccessibleDescription = "Check for updates of the database";
      this.menuitemCheckMpcorbDat.AccessibleName = "Check MPCORB.DAT";
      this.menuitemCheckMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.menuitemCheckMpcorbDat.Image = global::PlanetoidDB.Properties.Resources.silk_lightning;
      this.menuitemCheckMpcorbDat.Name = "menuitemCheckMpcorbDat";
      this.menuitemCheckMpcorbDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
      this.menuitemCheckMpcorbDat.Size = new System.Drawing.Size(244, 22);
      this.menuitemCheckMpcorbDat.Text = "&Check MPCORB.DAT";
      this.menuitemCheckMpcorbDat.ToolTipText = "Check for updates of the database";
      this.menuitemCheckMpcorbDat.Click += new System.EventHandler(this.menuitemCheckMpcorbDat_Click);
      this.menuitemCheckMpcorbDat.MouseEnter += new System.EventHandler(this.menuitemCheckMpcorbDat_MouseEnter);
      this.menuitemCheckMpcorbDat.MouseLeave += new System.EventHandler(this.menuitemCheckMpcorbDat_MouseLeave);
      // 
      // menuitemDownloadMpcorbDat
      // 
      this.menuitemDownloadMpcorbDat.AccessibleDescription = "Download the database";
      this.menuitemDownloadMpcorbDat.AccessibleName = "Download MPCORB.DAT";
      this.menuitemDownloadMpcorbDat.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.menuitemDownloadMpcorbDat.Image = global::PlanetoidDB.Properties.Resources.silk_package;
      this.menuitemDownloadMpcorbDat.Name = "menuitemDownloadMpcorbDat";
      this.menuitemDownloadMpcorbDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
      this.menuitemDownloadMpcorbDat.Size = new System.Drawing.Size(244, 22);
      this.menuitemDownloadMpcorbDat.Text = "&Download MPCORB.DAT";
      this.menuitemDownloadMpcorbDat.ToolTipText = "Download the database";
      this.menuitemDownloadMpcorbDat.Click += new System.EventHandler(this.menuitemDownloadMpcorbDat_Click);
      this.menuitemDownloadMpcorbDat.MouseEnter += new System.EventHandler(this.menuitemDownloadMpcorbDat_MouseEnter);
      this.menuitemDownloadMpcorbDat.MouseLeave += new System.EventHandler(this.menuitemDownloadMpcorbDat_MouseLeave);
      // 
      // menuitemQuest
      // 
      this.menuitemQuest.AccessibleDescription = "Show miscouellous";
      this.menuitemQuest.AccessibleName = "?";
      this.menuitemQuest.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
      this.menuitemQuest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemAbout,
            this.toolStripSeparatorMisc,
            this.menuitemOpenWebsitePDB,
            this.menuitemOpenWebsiteMPC,
            this.menuitemOpenMPCORBWebsite});
      this.menuitemQuest.Name = "menuitemQuest";
      this.menuitemQuest.Size = new System.Drawing.Size(24, 20);
      this.menuitemQuest.Text = "&?";
      this.menuitemQuest.ToolTipText = "Show miscouellous";
      this.menuitemQuest.MouseEnter += new System.EventHandler(this.menuitemQuest_MouseEnter);
      this.menuitemQuest.MouseLeave += new System.EventHandler(this.menuitemQuest_MouseLeave);
      // 
      // menuitemAbout
      // 
      this.menuitemAbout.AccessibleDescription = "More information about the application";
      this.menuitemAbout.AccessibleName = "About";
      this.menuitemAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.menuitemAbout.Image = global::PlanetoidDB.Properties.Resources.silk_information;
      this.menuitemAbout.Name = "menuitemAbout";
      this.menuitemAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
      this.menuitemAbout.Size = new System.Drawing.Size(231, 22);
      this.menuitemAbout.Text = "&About";
      this.menuitemAbout.ToolTipText = "More information about the application";
      this.menuitemAbout.Click += new System.EventHandler(this.menuitemAbout_Click);
      this.menuitemAbout.MouseEnter += new System.EventHandler(this.menuitemAbout_MouseEnter);
      this.menuitemAbout.MouseLeave += new System.EventHandler(this.menuitemAbout_MouseLeave);
      // 
      // toolStripSeparatorMisc
      // 
      this.toolStripSeparatorMisc.Name = "toolStripSeparatorMisc";
      this.toolStripSeparatorMisc.Size = new System.Drawing.Size(228, 6);
      this.toolStripSeparatorMisc.Click += new System.EventHandler(this.toolStripSeparatorMisc_Click);
      this.toolStripSeparatorMisc.MouseEnter += new System.EventHandler(this.toolStripSeparatorMisc_MouseEnter);
      this.toolStripSeparatorMisc.MouseLeave += new System.EventHandler(this.toolStripSeparatorMisc_MouseLeave);
      // 
      // menuitemOpenWebsitePDB
      // 
      this.menuitemOpenWebsitePDB.AccessibleDescription = "Opens the PlanetoidDB homepage";
      this.menuitemOpenWebsitePDB.AccessibleName = "Opens PlanetoidDB homepage";
      this.menuitemOpenWebsitePDB.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.menuitemOpenWebsitePDB.Image = global::PlanetoidDB.Properties.Resources.silk_world;
      this.menuitemOpenWebsitePDB.Name = "menuitemOpenWebsitePDB";
      this.menuitemOpenWebsitePDB.Size = new System.Drawing.Size(231, 22);
      this.menuitemOpenWebsitePDB.Text = "Open PlanetoidDB homepage";
      this.menuitemOpenWebsitePDB.ToolTipText = "Opens the PlanetoidDB homepage";
      this.menuitemOpenWebsitePDB.Click += new System.EventHandler(this.menuitemOpenWebsitePDB_Click);
      this.menuitemOpenWebsitePDB.MouseEnter += new System.EventHandler(this.menuitemOpenWebsitePDB_MouseEnter);
      this.menuitemOpenWebsitePDB.MouseLeave += new System.EventHandler(this.menuitemOpenWebsitePDB_MouseLeave);
      // 
      // menuitemOpenWebsiteMPC
      // 
      this.menuitemOpenWebsiteMPC.AccessibleDescription = "Opens the MPC homepage";
      this.menuitemOpenWebsiteMPC.AccessibleName = "Opens MPC homepage";
      this.menuitemOpenWebsiteMPC.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.menuitemOpenWebsiteMPC.Image = global::PlanetoidDB.Properties.Resources.silk_world;
      this.menuitemOpenWebsiteMPC.Name = "menuitemOpenWebsiteMPC";
      this.menuitemOpenWebsiteMPC.Size = new System.Drawing.Size(231, 22);
      this.menuitemOpenWebsiteMPC.Text = "Open MPC homepage";
      this.menuitemOpenWebsiteMPC.ToolTipText = "Opens the MPC homepage";
      this.menuitemOpenWebsiteMPC.Click += new System.EventHandler(this.menuitemOpenWebsiteMPC_Click);
      this.menuitemOpenWebsiteMPC.MouseEnter += new System.EventHandler(this.menuitemOpenWebsiteMPC_MouseEnter);
      this.menuitemOpenWebsiteMPC.MouseLeave += new System.EventHandler(this.menuitemOpenWebsiteMPC_MouseLeave);
      // 
      // menuitemOpenMPCORBWebsite
      // 
      this.menuitemOpenMPCORBWebsite.AccessibleDescription = "Opens the MPCORB website";
      this.menuitemOpenMPCORBWebsite.AccessibleName = "Opens MPCORB homepage";
      this.menuitemOpenMPCORBWebsite.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.menuitemOpenMPCORBWebsite.Image = global::PlanetoidDB.Properties.Resources.silk_world;
      this.menuitemOpenMPCORBWebsite.Name = "menuitemOpenMPCORBWebsite";
      this.menuitemOpenMPCORBWebsite.Size = new System.Drawing.Size(231, 22);
      this.menuitemOpenMPCORBWebsite.Text = "Open MPCORB website";
      this.menuitemOpenMPCORBWebsite.ToolTipText = "Opens the MPCORB website";
      this.menuitemOpenMPCORBWebsite.Click += new System.EventHandler(this.menuitemOpenMPCORBWebsite_Click);
      this.menuitemOpenMPCORBWebsite.MouseEnter += new System.EventHandler(this.menuitemOpenMPCORBWebsite_MouseEnter);
      this.menuitemOpenMPCORBWebsite.MouseLeave += new System.EventHandler(this.menuitemOpenMPCORBWebsite_MouseLeave);
      // 
      // trackBarIndex
      // 
      this.trackBarIndex.AccessibleDescription = "Shift to navigate in the data";
      this.trackBarIndex.AccessibleName = "Index range";
      this.trackBarIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
      this.trackBarIndex.LargeChange = 1;
      this.trackBarIndex.Location = new System.Drawing.Point(12, 64);
      this.trackBarIndex.Name = "trackBarIndex";
      this.trackBarIndex.Size = new System.Drawing.Size(723, 45);
      this.trackBarIndex.TabIndex = 11;
      this.trackBarIndex.TickFrequency = 100;
      this.trackBarIndex.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.toolTip.SetToolTip(this.trackBarIndex, "Shift to navigate in the data");
      this.trackBarIndex.Value = 1;
      this.trackBarIndex.Scroll += new System.EventHandler(this.trackBarIndex_Scroll);
      this.trackBarIndex.MouseEnter += new System.EventHandler(this.trackBarIndex_MouseEnter);
      this.trackBarIndex.MouseLeave += new System.EventHandler(this.trackBarIndex_MouseLeave);
      // 
      // buttonGotoIndex
      // 
      this.buttonGotoIndex.AccessibleDescription = "Click to show the data of the planetoid";
      this.buttonGotoIndex.AccessibleName = "Go to index";
      this.buttonGotoIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonGotoIndex.Image = global::PlanetoidDB.Properties.Resources.silk_go;
      this.buttonGotoIndex.Location = new System.Drawing.Point(704, 34);
      this.buttonGotoIndex.Name = "buttonGotoIndex";
      this.buttonGotoIndex.Size = new System.Drawing.Size(29, 26);
      this.buttonGotoIndex.TabIndex = 10;
      this.toolTip.SetToolTip(this.buttonGotoIndex, "Click to show the data of the planetoid");
      this.buttonGotoIndex.UseVisualStyleBackColor = true;
      this.buttonGotoIndex.Click += new System.EventHandler(this.buttonGotoIndex_Click);
      this.buttonGotoIndex.MouseEnter += new System.EventHandler(this.buttonGotoIndex_MouseEnter);
      this.buttonGotoIndex.MouseLeave += new System.EventHandler(this.buttonGotoIndex_MouseLeave);
      // 
      // buttonStepForward
      // 
      this.buttonStepForward.AccessibleDescription = "Navigate some data after";
      this.buttonStepForward.AccessibleName = "Navigate some data after";
      this.buttonStepForward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonStepForward.ContextMenuStrip = this.contextMenu;
      this.buttonStepForward.Image = global::PlanetoidDB.Properties.Resources.silk_forward;
      this.buttonStepForward.Location = new System.Drawing.Point(152, 32);
      this.buttonStepForward.Name = "buttonStepForward";
      this.buttonStepForward.Size = new System.Drawing.Size(29, 26);
      this.buttonStepForward.TabIndex = 5;
      this.toolTip.SetToolTip(this.buttonStepForward, "Navigate some data after");
      this.buttonStepForward.UseVisualStyleBackColor = true;
      this.buttonStepForward.Click += new System.EventHandler(this.buttonStepForward_Click);
      this.buttonStepForward.MouseEnter += new System.EventHandler(this.buttonStepForward_MouseEnter);
      this.buttonStepForward.MouseLeave += new System.EventHandler(this.buttonStepForward_MouseLeave);
      // 
      // buttonStepToEnd
      // 
      this.buttonStepToEnd.AccessibleDescription = "Navigate to the end of the data";
      this.buttonStepToEnd.AccessibleName = "End of the data";
      this.buttonStepToEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonStepToEnd.Image = global::PlanetoidDB.Properties.Resources.silk_forward_end;
      this.buttonStepToEnd.Location = new System.Drawing.Point(187, 32);
      this.buttonStepToEnd.Name = "buttonStepToEnd";
      this.buttonStepToEnd.Size = new System.Drawing.Size(29, 26);
      this.buttonStepToEnd.TabIndex = 6;
      this.toolTip.SetToolTip(this.buttonStepToEnd, "Navigate to the end of the dataset");
      this.buttonStepToEnd.UseVisualStyleBackColor = true;
      this.buttonStepToEnd.Click += new System.EventHandler(this.buttonStepToEnd_Click);
      this.buttonStepToEnd.MouseEnter += new System.EventHandler(this.buttonStepToEnd_MouseEnter);
      this.buttonStepToEnd.MouseLeave += new System.EventHandler(this.buttonStepToEnd_MouseLeave);
      // 
      // buttonStepForward1
      // 
      this.buttonStepForward1.AccessibleDescription = "Navigate to the next datafield";
      this.buttonStepForward1.AccessibleName = "Navigate to the next datafield";
      this.buttonStepForward1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonStepForward1.Image = global::PlanetoidDB.Properties.Resources.silk_forward_1;
      this.buttonStepForward1.Location = new System.Drawing.Point(117, 32);
      this.buttonStepForward1.Name = "buttonStepForward1";
      this.buttonStepForward1.Size = new System.Drawing.Size(29, 26);
      this.buttonStepForward1.TabIndex = 4;
      this.toolTip.SetToolTip(this.buttonStepForward1, "Navigate to the next datafield");
      this.buttonStepForward1.UseVisualStyleBackColor = true;
      this.buttonStepForward1.Click += new System.EventHandler(this.buttonStepForward1_Click);
      this.buttonStepForward1.MouseEnter += new System.EventHandler(this.buttonStepForward1_MouseEnter);
      this.buttonStepForward1.MouseLeave += new System.EventHandler(this.buttonStepForward1_MouseLeave);
      // 
      // buttonStepBackward1
      // 
      this.buttonStepBackward1.AccessibleDescription = "Navigate to the previous datafield";
      this.buttonStepBackward1.AccessibleName = "Navigate to the previous datafield";
      this.buttonStepBackward1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonStepBackward1.Image = global::PlanetoidDB.Properties.Resources.silk_backward_1;
      this.buttonStepBackward1.Location = new System.Drawing.Point(82, 32);
      this.buttonStepBackward1.Name = "buttonStepBackward1";
      this.buttonStepBackward1.Size = new System.Drawing.Size(29, 26);
      this.buttonStepBackward1.TabIndex = 3;
      this.toolTip.SetToolTip(this.buttonStepBackward1, "Navigate to the previous datafield");
      this.buttonStepBackward1.UseVisualStyleBackColor = true;
      this.buttonStepBackward1.Click += new System.EventHandler(this.buttonStepBackward1_Click);
      this.buttonStepBackward1.MouseEnter += new System.EventHandler(this.buttonStepBackward1_MouseEnter);
      this.buttonStepBackward1.MouseLeave += new System.EventHandler(this.buttonStepBackward1_MouseLeave);
      // 
      // buttonStepBackward
      // 
      this.buttonStepBackward.AccessibleDescription = "Navigate some data before";
      this.buttonStepBackward.AccessibleName = "Navigate some data before";
      this.buttonStepBackward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonStepBackward.ContextMenuStrip = this.contextMenu;
      this.buttonStepBackward.Image = global::PlanetoidDB.Properties.Resources.silk_backward;
      this.buttonStepBackward.Location = new System.Drawing.Point(47, 32);
      this.buttonStepBackward.Name = "buttonStepBackward";
      this.buttonStepBackward.Size = new System.Drawing.Size(29, 26);
      this.buttonStepBackward.TabIndex = 2;
      this.toolTip.SetToolTip(this.buttonStepBackward, "Navigate some data before");
      this.buttonStepBackward.UseVisualStyleBackColor = true;
      this.buttonStepBackward.Click += new System.EventHandler(this.buttonStepBackward_Click);
      this.buttonStepBackward.MouseEnter += new System.EventHandler(this.buttonStepBackward_MouseEnter);
      this.buttonStepBackward.MouseLeave += new System.EventHandler(this.buttonStepBackward_MouseLeave);
      // 
      // buttonStepToBegin
      // 
      this.buttonStepToBegin.AccessibleDescription = "Navigate to the begin of the data";
      this.buttonStepToBegin.AccessibleName = "Begin of the data";
      this.buttonStepToBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonStepToBegin.Image = global::PlanetoidDB.Properties.Resources.silk_backward_end;
      this.buttonStepToBegin.Location = new System.Drawing.Point(12, 32);
      this.buttonStepToBegin.Name = "buttonStepToBegin";
      this.buttonStepToBegin.Size = new System.Drawing.Size(29, 26);
      this.buttonStepToBegin.TabIndex = 1;
      this.toolTip.SetToolTip(this.buttonStepToBegin, "Navigate to the begin of the data");
      this.buttonStepToBegin.UseVisualStyleBackColor = true;
      this.buttonStepToBegin.Click += new System.EventHandler(this.buttonStepToBegin_Click);
      this.buttonStepToBegin.MouseEnter += new System.EventHandler(this.buttonStepToBegin_MouseEnter);
      this.buttonStepToBegin.MouseLeave += new System.EventHandler(this.buttonStepToBegin_MouseLeave);
      // 
      // labelGottoIndex
      // 
      this.labelGottoIndex.AccessibleDescription = "Go to index";
      this.labelGottoIndex.AccessibleName = "Index";
      this.labelGottoIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
      this.labelGottoIndex.AutoSize = true;
      this.labelGottoIndex.Location = new System.Drawing.Point(542, 40);
      this.labelGottoIndex.Name = "labelGottoIndex";
      this.labelGottoIndex.Size = new System.Drawing.Size(72, 15);
      this.labelGottoIndex.TabIndex = 8;
      this.labelGottoIndex.Text = "Go to Index:";
      // 
      // ofd
      // 
      this.ofd.DefaultExt = "dat";
      this.ofd.FileName = "mpcorb.dat";
      this.ofd.Filter = "DAT-Datei|*.dat|Alle Dateien|*.*";
      // 
      // backgroundWorkerLoadingDB
      // 
      this.backgroundWorkerLoadingDB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadingDB_DoWork);
      this.backgroundWorkerLoadingDB.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerLoadingDB_ProgressChanged);
      this.backgroundWorkerLoadingDB.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadingDB_RunWorkerCompleted);
      // 
      // timerUpdateBlink
      // 
      this.timerUpdateBlink.Interval = 500;
      this.timerUpdateBlink.Tick += new System.EventHandler(this.timerUpdateBlink_Tick);
      // 
      // PlanetoidDBForm
      // 
      this.AccessibleDescription = "Viewer for the MPC Orbit (MPCORB) Database";
      this.AccessibleName = "PlanetoidDB";
      this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(745, 399);
      this.Controls.Add(this.trackBarIndex);
      this.Controls.Add(this.buttonGotoIndex);
      this.Controls.Add(this.numericUpDownGotoIndex);
      this.Controls.Add(this.labelGottoIndex);
      this.Controls.Add(this.labelIndexPos);
      this.Controls.Add(this.buttonStepForward);
      this.Controls.Add(this.statusBar);
      this.Controls.Add(this.menu);
      this.Controls.Add(this.buttonStepToEnd);
      this.Controls.Add(this.buttonStepForward1);
      this.Controls.Add(this.tableLayoutPanelData);
      this.Controls.Add(this.buttonStepBackward1);
      this.Controls.Add(this.buttonStepBackward);
      this.Controls.Add(this.buttonStepToBegin);
      this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menu;
      this.MaximizeBox = false;
      this.Name = "PlanetoidDBForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PlanetoidDB";
      this.Load += new System.EventHandler(this.PlanetoidDBForm_Load);
      this.Shown += new System.EventHandler(this.PlanetoidDBForm_Shown);
      this.contextMenu.ResumeLayout(false);
      this.tableLayoutPanelData.ResumeLayout(false);
      this.tableLayoutPanelData.PerformLayout();
      this.statusBar.ResumeLayout(false);
      this.statusBar.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGotoIndex)).EndInit();
      this.menu.ResumeLayout(false);
      this.menu.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarIndex)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

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
    private System.Windows.Forms.OpenFileDialog ofd;
    private System.Windows.Forms.ContextMenuStrip contextMenu;
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
    private System.ComponentModel.BackgroundWorker backgroundWorkerLoadingDB;
    private System.Windows.Forms.TrackBar trackBarIndex;
    private System.Windows.Forms.ToolStripMenuItem menuitemCheckMpcorbDat;
    private System.Windows.Forms.ToolStripStatusLabel labelHelp;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUpdate;
    private System.Windows.Forms.Timer timerUpdateBlink;
  }
}

