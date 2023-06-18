using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class TerminologyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminologyForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelIndex = new System.Windows.Forms.Label();
			this.labelDesgnName = new System.Windows.Forms.Label();
			this.labelEpoch = new System.Windows.Forms.Label();
			this.labelMeanAnomaly = new System.Windows.Forms.Label();
			this.labelArgPeri = new System.Windows.Forms.Label();
			this.labelLongAscNode = new System.Windows.Forms.Label();
			this.labelIncl = new System.Windows.Forms.Label();
			this.labelOrbEcc = new System.Windows.Forms.Label();
			this.labelMotion = new System.Windows.Forms.Label();
			this.labelSemiMajorAxis = new System.Windows.Forms.Label();
			this.labelMagAbs = new System.Windows.Forms.Label();
			this.labelSlopeParam = new System.Windows.Forms.Label();
			this.labelRef = new System.Windows.Forms.Label();
			this.labelNumbOppos = new System.Windows.Forms.Label();
			this.labelNumbObs = new System.Windows.Forms.Label();
			this.labelObsSpan = new System.Windows.Forms.Label();
			this.labelRmsResidual = new System.Windows.Forms.Label();
			this.labelComputerName = new System.Windows.Forms.Label();
			this.labelFlags = new System.Windows.Forms.Label();
			this.labelObsLastDate = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelLinearEccentricity = new System.Windows.Forms.Label();
			this.labelSemiMinorAxis = new System.Windows.Forms.Label();
			this.labelMajorAxis = new System.Windows.Forms.Label();
			this.labelMinorAxis = new System.Windows.Forms.Label();
			this.labelEccenctricAnomaly = new System.Windows.Forms.Label();
			this.labelPerihelionDistance = new System.Windows.Forms.Label();
			this.labelAphelionDistance = new System.Windows.Forms.Label();
			this.labelLongitudeDescendingNode = new System.Windows.Forms.Label();
			this.labelArgumentAphelion = new System.Windows.Forms.Label();
			this.labelFocalParameter = new System.Windows.Forms.Label();
			this.labelSemiLatusRectum = new System.Windows.Forms.Label();
			this.labelLatusRectum = new System.Windows.Forms.Label();
			this.labelPeriod = new System.Windows.Forms.Label();
			this.labelOrbitalArea = new System.Windows.Forms.Label();
			this.labelOrbitalPerimeter = new System.Windows.Forms.Label();
			this.labelSemiMeanAxis = new System.Windows.Forms.Label();
			this.labelMeanAxis = new System.Windows.Forms.Label();
			this.labelStandardGravitationalParameter = new System.Windows.Forms.Label();
			this.labelTrueAnomaly = new System.Windows.Forms.Label();
			this.tableLayoutPanelLeft = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.tableLayoutPanelOuter = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.tableLayoutPanelRight = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanelLeft.SuspendLayout();
			this.tableLayoutPanelOuter.SuspendLayout();
			this.tableLayoutPanelRight.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelIndex
			// 
			this.labelIndex.AccessibleDescription = "Index No.";
			this.labelIndex.AccessibleName = "Index No.";
			this.labelIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelIndex.AutoSize = true;
			this.labelIndex.BackColor = System.Drawing.Color.Transparent;
			this.labelIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIndex.Location = new System.Drawing.Point(3, 0);
			this.labelIndex.Name = "labelIndex";
			this.labelIndex.Padding = new System.Windows.Forms.Padding(3);
			this.labelIndex.Size = new System.Drawing.Size(239, 21);
			this.labelIndex.TabIndex = 1;
			this.labelIndex.Text = "Index No.";
			this.labelIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelIndex, "Index No.");
			this.labelIndex.Click += new System.EventHandler(this.LabelIndex_Click);
			this.labelIndex.Enter += new System.EventHandler(this.LabelIndex_Enter);
			this.labelIndex.Leave += new System.EventHandler(this.LabelIndex_Leave);
			this.labelIndex.MouseEnter += new System.EventHandler(this.LabelIndex_Enter);
			this.labelIndex.MouseLeave += new System.EventHandler(this.LabelIndex_Leave);
			// 
			// labelDesgnName
			// 
			this.labelDesgnName.AccessibleDescription = "Readable designation";
			this.labelDesgnName.AccessibleName = "Readable designation";
			this.labelDesgnName.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelDesgnName.AutoSize = true;
			this.labelDesgnName.BackColor = System.Drawing.Color.Transparent;
			this.labelDesgnName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDesgnName.Location = new System.Drawing.Point(3, 21);
			this.labelDesgnName.Name = "labelDesgnName";
			this.labelDesgnName.Padding = new System.Windows.Forms.Padding(3);
			this.labelDesgnName.Size = new System.Drawing.Size(239, 21);
			this.labelDesgnName.TabIndex = 2;
			this.labelDesgnName.Text = "Readable designation";
			this.labelDesgnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelDesgnName, "Readable designation");
			this.labelDesgnName.Click += new System.EventHandler(this.LabelDesgnName_Click);
			this.labelDesgnName.Enter += new System.EventHandler(this.LabelDesgnName_Enter);
			this.labelDesgnName.Leave += new System.EventHandler(this.LabelDesgnName_Leave);
			this.labelDesgnName.MouseEnter += new System.EventHandler(this.LabelDesgnName_Enter);
			this.labelDesgnName.MouseLeave += new System.EventHandler(this.LabelDesgnName_Leave);
			// 
			// labelEpoch
			// 
			this.labelEpoch.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.AccessibleName = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelEpoch.AutoSize = true;
			this.labelEpoch.BackColor = System.Drawing.Color.Transparent;
			this.labelEpoch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEpoch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelEpoch.Location = new System.Drawing.Point(3, 42);
			this.labelEpoch.Name = "labelEpoch";
			this.labelEpoch.Padding = new System.Windows.Forms.Padding(3);
			this.labelEpoch.Size = new System.Drawing.Size(239, 21);
			this.labelEpoch.TabIndex = 3;
			this.labelEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelEpoch, "Epoch (in packed form, .0 TT)");
			this.labelEpoch.Click += new System.EventHandler(this.LabelEpoch_Click);
			this.labelEpoch.Enter += new System.EventHandler(this.LabelEpoch_Enter);
			this.labelEpoch.Leave += new System.EventHandler(this.LabelEpoch_Leave);
			this.labelEpoch.MouseEnter += new System.EventHandler(this.LabelEpoch_Enter);
			this.labelEpoch.MouseLeave += new System.EventHandler(this.LabelEpoch_Leave);
			// 
			// labelMeanAnomaly
			// 
			this.labelMeanAnomaly.AccessibleDescription = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.AccessibleName = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelMeanAnomaly.AutoSize = true;
			this.labelMeanAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.labelMeanAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAnomaly.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMeanAnomaly.Location = new System.Drawing.Point(3, 63);
			this.labelMeanAnomaly.Name = "labelMeanAnomaly";
			this.labelMeanAnomaly.Padding = new System.Windows.Forms.Padding(3);
			this.labelMeanAnomaly.Size = new System.Drawing.Size(239, 21);
			this.labelMeanAnomaly.TabIndex = 4;
			this.labelMeanAnomaly.Text = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMeanAnomaly, "Mean anomaly at the epoch, in degrees");
			this.labelMeanAnomaly.Click += new System.EventHandler(this.LabelMeanAnomaly_Click);
			this.labelMeanAnomaly.Enter += new System.EventHandler(this.LabelMeanAnomaly_Enter);
			this.labelMeanAnomaly.Leave += new System.EventHandler(this.LabelMeanAnomaly_Leave);
			this.labelMeanAnomaly.MouseEnter += new System.EventHandler(this.LabelMeanAnomaly_Enter);
			this.labelMeanAnomaly.MouseLeave += new System.EventHandler(this.LabelMeanAnomaly_Leave);
			// 
			// labelArgPeri
			// 
			this.labelArgPeri.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelArgPeri.AutoSize = true;
			this.labelArgPeri.BackColor = System.Drawing.Color.Transparent;
			this.labelArgPeri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgPeri.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelArgPeri.Location = new System.Drawing.Point(3, 84);
			this.labelArgPeri.Name = "labelArgPeri";
			this.labelArgPeri.Padding = new System.Windows.Forms.Padding(3);
			this.labelArgPeri.Size = new System.Drawing.Size(239, 21);
			this.labelArgPeri.TabIndex = 5;
			this.labelArgPeri.Text = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelArgPeri, "Argument of perihelion, J2000.0 (degrees)");
			this.labelArgPeri.Click += new System.EventHandler(this.LabelArgPeri_Click);
			this.labelArgPeri.Enter += new System.EventHandler(this.LabelArgPeri_Enter);
			this.labelArgPeri.Leave += new System.EventHandler(this.LabelArgPeri_Leave);
			this.labelArgPeri.MouseEnter += new System.EventHandler(this.LabelArgPeri_Enter);
			this.labelArgPeri.MouseLeave += new System.EventHandler(this.LabelArgPeri_Leave);
			// 
			// labelLongAscNode
			// 
			this.labelLongAscNode.AccessibleDescription = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.AccessibleName = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelLongAscNode.AutoSize = true;
			this.labelLongAscNode.BackColor = System.Drawing.Color.Transparent;
			this.labelLongAscNode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongAscNode.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelLongAscNode.Location = new System.Drawing.Point(3, 105);
			this.labelLongAscNode.Name = "labelLongAscNode";
			this.labelLongAscNode.Padding = new System.Windows.Forms.Padding(3);
			this.labelLongAscNode.Size = new System.Drawing.Size(239, 21);
			this.labelLongAscNode.TabIndex = 6;
			this.labelLongAscNode.Text = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelLongAscNode, "Longitude of the ascending node, J2000.0");
			this.labelLongAscNode.Click += new System.EventHandler(this.LabelLongAscNode_Click);
			this.labelLongAscNode.Enter += new System.EventHandler(this.LabelLongAscNode_Enter);
			this.labelLongAscNode.Leave += new System.EventHandler(this.LabelLongAscNode_Leave);
			this.labelLongAscNode.MouseEnter += new System.EventHandler(this.LabelLongAscNode_Enter);
			this.labelLongAscNode.MouseLeave += new System.EventHandler(this.LabelLongAscNode_Leave);
			// 
			// labelIncl
			// 
			this.labelIncl.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelIncl.AutoSize = true;
			this.labelIncl.BackColor = System.Drawing.Color.Transparent;
			this.labelIncl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIncl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelIncl.Location = new System.Drawing.Point(3, 126);
			this.labelIncl.Name = "labelIncl";
			this.labelIncl.Padding = new System.Windows.Forms.Padding(3);
			this.labelIncl.Size = new System.Drawing.Size(239, 21);
			this.labelIncl.TabIndex = 7;
			this.labelIncl.Text = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelIncl, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.labelIncl.Click += new System.EventHandler(this.LabelIncl_Click);
			this.labelIncl.Enter += new System.EventHandler(this.LabelIncl_Enter);
			this.labelIncl.Leave += new System.EventHandler(this.LabelIncl_Leave);
			this.labelIncl.MouseEnter += new System.EventHandler(this.LabelIncl_Enter);
			this.labelIncl.MouseLeave += new System.EventHandler(this.LabelIncl_Leave);
			// 
			// labelOrbEcc
			// 
			this.labelOrbEcc.AccessibleDescription = "Orbital eccentricity";
			this.labelOrbEcc.AccessibleName = "Orbital eccentricity";
			this.labelOrbEcc.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelOrbEcc.AutoSize = true;
			this.labelOrbEcc.BackColor = System.Drawing.Color.Transparent;
			this.labelOrbEcc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbEcc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelOrbEcc.Location = new System.Drawing.Point(3, 147);
			this.labelOrbEcc.Name = "labelOrbEcc";
			this.labelOrbEcc.Padding = new System.Windows.Forms.Padding(3);
			this.labelOrbEcc.Size = new System.Drawing.Size(239, 21);
			this.labelOrbEcc.TabIndex = 8;
			this.labelOrbEcc.Text = "Orbital eccentricity";
			this.labelOrbEcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelOrbEcc, "Orbital eccentricity");
			this.labelOrbEcc.Click += new System.EventHandler(this.LabelOrbEcc_Click);
			this.labelOrbEcc.Enter += new System.EventHandler(this.LabelOrbEcc_Enter);
			this.labelOrbEcc.Leave += new System.EventHandler(this.LabelOrbEcc_Leave);
			this.labelOrbEcc.MouseEnter += new System.EventHandler(this.LabelOrbEcc_Enter);
			this.labelOrbEcc.MouseLeave += new System.EventHandler(this.LabelOrbEcc_Leave);
			// 
			// labelMotion
			// 
			this.labelMotion.AccessibleDescription = "Mean daily motion (degrees per day)";
			this.labelMotion.AccessibleName = "Mean daily motion (degrees per day)";
			this.labelMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelMotion.AutoSize = true;
			this.labelMotion.BackColor = System.Drawing.Color.Transparent;
			this.labelMotion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMotion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMotion.Location = new System.Drawing.Point(3, 168);
			this.labelMotion.Name = "labelMotion";
			this.labelMotion.Padding = new System.Windows.Forms.Padding(3);
			this.labelMotion.Size = new System.Drawing.Size(239, 21);
			this.labelMotion.TabIndex = 9;
			this.labelMotion.Text = "Mean daily motion (degrees per day)";
			this.labelMotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMotion, "Mean daily motion (degrees per day)");
			this.labelMotion.Click += new System.EventHandler(this.LabelMotion_Click);
			this.labelMotion.Enter += new System.EventHandler(this.LabelMotion_Enter);
			this.labelMotion.Leave += new System.EventHandler(this.LabelMotion_Leave);
			this.labelMotion.MouseEnter += new System.EventHandler(this.LabelMotion_Enter);
			this.labelMotion.MouseLeave += new System.EventHandler(this.LabelMotion_Leave);
			// 
			// labelSemiMajorAxis
			// 
			this.labelSemiMajorAxis.AccessibleDescription = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.AccessibleName = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelSemiMajorAxis.AutoSize = true;
			this.labelSemiMajorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiMajorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMajorAxis.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSemiMajorAxis.Location = new System.Drawing.Point(3, 189);
			this.labelSemiMajorAxis.Name = "labelSemiMajorAxis";
			this.labelSemiMajorAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiMajorAxis.Size = new System.Drawing.Size(239, 21);
			this.labelSemiMajorAxis.TabIndex = 10;
			this.labelSemiMajorAxis.Text = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSemiMajorAxis, "Semimajor axis (AU)");
			this.labelSemiMajorAxis.Click += new System.EventHandler(this.LabelSemiMajorAxis_Click);
			this.labelSemiMajorAxis.Enter += new System.EventHandler(this.LabelSemiMajorAxis_Enter);
			this.labelSemiMajorAxis.Leave += new System.EventHandler(this.LabelSemiMajorAxis_Leave);
			this.labelSemiMajorAxis.MouseEnter += new System.EventHandler(this.LabelSemiMajorAxis_Enter);
			this.labelSemiMajorAxis.MouseLeave += new System.EventHandler(this.LabelSemiMajorAxis_Leave);
			// 
			// labelMagAbs
			// 
			this.labelMagAbs.AccessibleDescription = "Absolute magnitude, H";
			this.labelMagAbs.AccessibleName = "Absolute magnitude, H";
			this.labelMagAbs.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelMagAbs.AutoSize = true;
			this.labelMagAbs.BackColor = System.Drawing.Color.Transparent;
			this.labelMagAbs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMagAbs.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMagAbs.Location = new System.Drawing.Point(3, 210);
			this.labelMagAbs.Name = "labelMagAbs";
			this.labelMagAbs.Padding = new System.Windows.Forms.Padding(3);
			this.labelMagAbs.Size = new System.Drawing.Size(239, 21);
			this.labelMagAbs.TabIndex = 11;
			this.labelMagAbs.Text = "Absolute magnitude, H";
			this.labelMagAbs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMagAbs, "Absolute magnitude, H");
			this.labelMagAbs.Click += new System.EventHandler(this.LabelMagAbs_Click);
			this.labelMagAbs.Enter += new System.EventHandler(this.LabelMagAbs_Enter);
			this.labelMagAbs.Leave += new System.EventHandler(this.LabelMagAbs_Leave);
			this.labelMagAbs.MouseEnter += new System.EventHandler(this.LabelMagAbs_Enter);
			this.labelMagAbs.MouseLeave += new System.EventHandler(this.LabelMagAbs_Leave);
			// 
			// labelSlopeParam
			// 
			this.labelSlopeParam.AccessibleDescription = "Slope parameter, G";
			this.labelSlopeParam.AccessibleName = "Slope parameter, G";
			this.labelSlopeParam.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelSlopeParam.AutoSize = true;
			this.labelSlopeParam.BackColor = System.Drawing.Color.Transparent;
			this.labelSlopeParam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSlopeParam.Location = new System.Drawing.Point(3, 231);
			this.labelSlopeParam.Name = "labelSlopeParam";
			this.labelSlopeParam.Padding = new System.Windows.Forms.Padding(3);
			this.labelSlopeParam.Size = new System.Drawing.Size(239, 21);
			this.labelSlopeParam.TabIndex = 12;
			this.labelSlopeParam.Text = "Slope parameter, G";
			this.labelSlopeParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSlopeParam, "Slope parameter, G");
			this.labelSlopeParam.Click += new System.EventHandler(this.LabelSlopeParam_Click);
			this.labelSlopeParam.Enter += new System.EventHandler(this.LabelSlopeParam_Enter);
			this.labelSlopeParam.Leave += new System.EventHandler(this.LabelSlopeParam_Leave);
			this.labelSlopeParam.MouseEnter += new System.EventHandler(this.LabelSlopeParam_Enter);
			this.labelSlopeParam.MouseLeave += new System.EventHandler(this.LabelSlopeParam_Leave);
			// 
			// labelRef
			// 
			this.labelRef.AccessibleDescription = "Reference";
			this.labelRef.AccessibleName = "Reference";
			this.labelRef.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelRef.AutoSize = true;
			this.labelRef.BackColor = System.Drawing.Color.Transparent;
			this.labelRef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRef.Location = new System.Drawing.Point(3, 252);
			this.labelRef.Name = "labelRef";
			this.labelRef.Padding = new System.Windows.Forms.Padding(3);
			this.labelRef.Size = new System.Drawing.Size(239, 21);
			this.labelRef.TabIndex = 13;
			this.labelRef.Text = "Reference";
			this.labelRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelRef, "Reference");
			this.labelRef.Click += new System.EventHandler(this.LabelRef_Click);
			this.labelRef.Enter += new System.EventHandler(this.LabelRef_Enter);
			this.labelRef.Leave += new System.EventHandler(this.LabelRef_Leave);
			this.labelRef.MouseEnter += new System.EventHandler(this.LabelRef_Enter);
			this.labelRef.MouseLeave += new System.EventHandler(this.LabelRef_Leave);
			// 
			// labelNumbOppos
			// 
			this.labelNumbOppos.AccessibleDescription = "Number of oppositions";
			this.labelNumbOppos.AccessibleName = "Number of oppositions";
			this.labelNumbOppos.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelNumbOppos.AutoSize = true;
			this.labelNumbOppos.BackColor = System.Drawing.Color.Transparent;
			this.labelNumbOppos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumbOppos.Location = new System.Drawing.Point(3, 273);
			this.labelNumbOppos.Name = "labelNumbOppos";
			this.labelNumbOppos.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbOppos.Size = new System.Drawing.Size(239, 21);
			this.labelNumbOppos.TabIndex = 14;
			this.labelNumbOppos.Text = "Number of oppositions";
			this.labelNumbOppos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelNumbOppos, "Number of oppositions");
			this.labelNumbOppos.Click += new System.EventHandler(this.LabelNumbOppos_Click);
			this.labelNumbOppos.Enter += new System.EventHandler(this.LabelNumbOppos_Enter);
			this.labelNumbOppos.Leave += new System.EventHandler(this.LabelNumbOppos_Leave);
			this.labelNumbOppos.MouseEnter += new System.EventHandler(this.LabelNumbOppos_Enter);
			this.labelNumbOppos.MouseLeave += new System.EventHandler(this.LabelNumbOppos_Leave);
			// 
			// labelNumbObs
			// 
			this.labelNumbObs.AccessibleDescription = "Number of observations";
			this.labelNumbObs.AccessibleName = "Number of observations";
			this.labelNumbObs.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelNumbObs.AutoSize = true;
			this.labelNumbObs.BackColor = System.Drawing.Color.Transparent;
			this.labelNumbObs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumbObs.Location = new System.Drawing.Point(3, 294);
			this.labelNumbObs.Name = "labelNumbObs";
			this.labelNumbObs.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbObs.Size = new System.Drawing.Size(239, 21);
			this.labelNumbObs.TabIndex = 15;
			this.labelNumbObs.Text = "Number of observations";
			this.labelNumbObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelNumbObs, "Number of observations");
			this.labelNumbObs.Click += new System.EventHandler(this.LabelNumbObs_Click);
			this.labelNumbObs.Enter += new System.EventHandler(this.LabelNumbObs_Enter);
			this.labelNumbObs.Leave += new System.EventHandler(this.LabelNumbObs_Leave);
			this.labelNumbObs.MouseEnter += new System.EventHandler(this.LabelNumbObs_Enter);
			this.labelNumbObs.MouseLeave += new System.EventHandler(this.LabelNumbObs_Leave);
			// 
			// labelObsSpan
			// 
			this.labelObsSpan.AccessibleDescription = "Observation span";
			this.labelObsSpan.AccessibleName = "Observation span";
			this.labelObsSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelObsSpan.AutoSize = true;
			this.labelObsSpan.BackColor = System.Drawing.Color.Transparent;
			this.labelObsSpan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelObsSpan.Location = new System.Drawing.Point(3, 315);
			this.labelObsSpan.Name = "labelObsSpan";
			this.labelObsSpan.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsSpan.Size = new System.Drawing.Size(239, 21);
			this.labelObsSpan.TabIndex = 16;
			this.labelObsSpan.Text = "Observation span";
			this.labelObsSpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelObsSpan, "Observation span");
			this.labelObsSpan.Click += new System.EventHandler(this.LabelObsSpan_Click);
			this.labelObsSpan.Enter += new System.EventHandler(this.LabelObsSpan_Enter);
			this.labelObsSpan.Leave += new System.EventHandler(this.LabelObsSpan_Leave);
			this.labelObsSpan.MouseEnter += new System.EventHandler(this.LabelObsSpan_Enter);
			this.labelObsSpan.MouseLeave += new System.EventHandler(this.LabelObsSpan_Leave);
			// 
			// labelRmsResidual
			// 
			this.labelRmsResidual.AccessibleDescription = "r.m.s. residual (\")";
			this.labelRmsResidual.AccessibleName = "r.m.s. residual (\")";
			this.labelRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelRmsResidual.AutoSize = true;
			this.labelRmsResidual.BackColor = System.Drawing.Color.Transparent;
			this.labelRmsResidual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRmsResidual.Location = new System.Drawing.Point(3, 336);
			this.labelRmsResidual.Name = "labelRmsResidual";
			this.labelRmsResidual.Padding = new System.Windows.Forms.Padding(3);
			this.labelRmsResidual.Size = new System.Drawing.Size(239, 21);
			this.labelRmsResidual.TabIndex = 17;
			this.labelRmsResidual.Text = "r.m.s. residual (\")";
			this.labelRmsResidual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelRmsResidual, "r.m.s residual (\")");
			this.labelRmsResidual.Click += new System.EventHandler(this.LabelRmsResidual_Click);
			this.labelRmsResidual.Enter += new System.EventHandler(this.LabelRmsResidual_Enter);
			this.labelRmsResidual.Leave += new System.EventHandler(this.LabelRmsResidual_Leave);
			this.labelRmsResidual.MouseEnter += new System.EventHandler(this.LabelRmsResidual_Enter);
			this.labelRmsResidual.MouseLeave += new System.EventHandler(this.LabelRmsResidual_Leave);
			// 
			// labelComputerName
			// 
			this.labelComputerName.AccessibleDescription = "Computer name";
			this.labelComputerName.AccessibleName = "Computer name";
			this.labelComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelComputerName.AutoSize = true;
			this.labelComputerName.BackColor = System.Drawing.Color.Transparent;
			this.labelComputerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComputerName.Location = new System.Drawing.Point(3, 357);
			this.labelComputerName.Name = "labelComputerName";
			this.labelComputerName.Padding = new System.Windows.Forms.Padding(3);
			this.labelComputerName.Size = new System.Drawing.Size(239, 21);
			this.labelComputerName.TabIndex = 18;
			this.labelComputerName.Text = "Computer name";
			this.labelComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelComputerName, "Computer name");
			this.labelComputerName.Click += new System.EventHandler(this.LabelComputerName_Click);
			this.labelComputerName.Enter += new System.EventHandler(this.LabelComputerName_Enter);
			this.labelComputerName.Leave += new System.EventHandler(this.LabelComputerName_Leave);
			this.labelComputerName.MouseEnter += new System.EventHandler(this.LabelComputerName_Enter);
			this.labelComputerName.MouseLeave += new System.EventHandler(this.LabelComputerName_Leave);
			// 
			// labelFlags
			// 
			this.labelFlags.AccessibleDescription = "4-hexdigit flags";
			this.labelFlags.AccessibleName = "4-hexdigit flags";
			this.labelFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelFlags.AutoSize = true;
			this.labelFlags.BackColor = System.Drawing.Color.Transparent;
			this.labelFlags.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFlags.Location = new System.Drawing.Point(3, 378);
			this.labelFlags.Name = "labelFlags";
			this.labelFlags.Padding = new System.Windows.Forms.Padding(3);
			this.labelFlags.Size = new System.Drawing.Size(239, 21);
			this.labelFlags.TabIndex = 19;
			this.labelFlags.Text = "4-hexdigit flags";
			this.labelFlags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelFlags, "4-hexdigit flags");
			this.labelFlags.Click += new System.EventHandler(this.LabelFlags_Click);
			this.labelFlags.Enter += new System.EventHandler(this.LabelFlags_Enter);
			this.labelFlags.Leave += new System.EventHandler(this.LabelFlags_Leave);
			this.labelFlags.MouseEnter += new System.EventHandler(this.LabelFlags_Enter);
			this.labelFlags.MouseLeave += new System.EventHandler(this.LabelFlags_Leave);
			// 
			// labelObsLastDate
			// 
			this.labelObsLastDate.AccessibleDescription = "Date of last observation";
			this.labelObsLastDate.AccessibleName = "Date of last observation";
			this.labelObsLastDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelObsLastDate.AutoSize = true;
			this.labelObsLastDate.BackColor = System.Drawing.Color.Transparent;
			this.labelObsLastDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelObsLastDate.Location = new System.Drawing.Point(3, 399);
			this.labelObsLastDate.Name = "labelObsLastDate";
			this.labelObsLastDate.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsLastDate.Size = new System.Drawing.Size(239, 21);
			this.labelObsLastDate.TabIndex = 20;
			this.labelObsLastDate.Text = "Date of last observation";
			this.labelObsLastDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelObsLastDate, "Date of last observation");
			this.labelObsLastDate.Click += new System.EventHandler(this.LabelObsLastDate_Click);
			this.labelObsLastDate.Enter += new System.EventHandler(this.LabelObsLastDate_Enter);
			this.labelObsLastDate.Leave += new System.EventHandler(this.LabelObsLastDate_Leave);
			this.labelObsLastDate.MouseEnter += new System.EventHandler(this.LabelObsLastDate_Enter);
			this.labelObsLastDate.MouseLeave += new System.EventHandler(this.LabelObsLastDate_Leave);
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(3, 448);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(346, 49);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "Okay");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			this.buttonOK.Enter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ButtonOK_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.MouseLeave += new System.EventHandler(this.ButtonOK_Leave);
			// 
			// labelLinearEccentricity
			// 
			this.labelLinearEccentricity.AccessibleDescription = "Linear eccentricity";
			this.labelLinearEccentricity.AccessibleName = "Linear eccentricity";
			this.labelLinearEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelLinearEccentricity.AutoSize = true;
			this.labelLinearEccentricity.BackColor = System.Drawing.Color.Transparent;
			this.labelLinearEccentricity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLinearEccentricity.Location = new System.Drawing.Point(3, 420);
			this.labelLinearEccentricity.Name = "labelLinearEccentricity";
			this.labelLinearEccentricity.Padding = new System.Windows.Forms.Padding(3);
			this.labelLinearEccentricity.Size = new System.Drawing.Size(239, 21);
			this.labelLinearEccentricity.TabIndex = 21;
			this.labelLinearEccentricity.Text = "Linear eccentricity";
			this.labelLinearEccentricity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelLinearEccentricity, "Linear eccentricity");
			this.labelLinearEccentricity.Click += new System.EventHandler(this.LabelLinearEccentricity_Click);
			this.labelLinearEccentricity.Enter += new System.EventHandler(this.LabelLinearEccentricity_Enter);
			this.labelLinearEccentricity.Leave += new System.EventHandler(this.LabelLinearEccentricity_Leave);
			this.labelLinearEccentricity.MouseEnter += new System.EventHandler(this.LabelLinearEccentricity_Enter);
			this.labelLinearEccentricity.MouseLeave += new System.EventHandler(this.LabelLinearEccentricity_Leave);
			// 
			// labelSemiMinorAxis
			// 
			this.labelSemiMinorAxis.AccessibleDescription = "Semi-minor axis";
			this.labelSemiMinorAxis.AccessibleName = "Semi-minor axis";
			this.labelSemiMinorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelSemiMinorAxis.AutoSize = true;
			this.labelSemiMinorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiMinorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMinorAxis.Location = new System.Drawing.Point(3, 441);
			this.labelSemiMinorAxis.Name = "labelSemiMinorAxis";
			this.labelSemiMinorAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiMinorAxis.Size = new System.Drawing.Size(239, 21);
			this.labelSemiMinorAxis.TabIndex = 22;
			this.labelSemiMinorAxis.Text = "Semi-minor axis";
			this.labelSemiMinorAxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSemiMinorAxis, "Semi-minor axis");
			this.labelSemiMinorAxis.Click += new System.EventHandler(this.LabelSemiMinorAxis_Click);
			this.labelSemiMinorAxis.Enter += new System.EventHandler(this.LabelSemiMinorAxis_Enter);
			this.labelSemiMinorAxis.Leave += new System.EventHandler(this.LabelSemiMinorAxis_Leave);
			this.labelSemiMinorAxis.MouseEnter += new System.EventHandler(this.LabelSemiMinorAxis_Enter);
			this.labelSemiMinorAxis.MouseLeave += new System.EventHandler(this.LabelSemiMinorAxis_Leave);
			// 
			// labelMajorAxis
			// 
			this.labelMajorAxis.AccessibleDescription = "Major axis";
			this.labelMajorAxis.AccessibleName = "Major axis";
			this.labelMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelMajorAxis.AutoSize = true;
			this.labelMajorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelMajorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMajorAxis.Location = new System.Drawing.Point(3, 462);
			this.labelMajorAxis.Name = "labelMajorAxis";
			this.labelMajorAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelMajorAxis.Size = new System.Drawing.Size(239, 21);
			this.labelMajorAxis.TabIndex = 23;
			this.labelMajorAxis.Text = "Major axis";
			this.labelMajorAxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMajorAxis, "Major axis");
			this.labelMajorAxis.Click += new System.EventHandler(this.LabelMajorAxis_Click);
			this.labelMajorAxis.Enter += new System.EventHandler(this.LabelMajorAxis_Enter);
			this.labelMajorAxis.Leave += new System.EventHandler(this.LabelMajorAxis_Leave);
			this.labelMajorAxis.MouseEnter += new System.EventHandler(this.LabelMajorAxis_Enter);
			this.labelMajorAxis.MouseLeave += new System.EventHandler(this.LabelMajorAxis_Leave);
			// 
			// labelMinorAxis
			// 
			this.labelMinorAxis.AccessibleDescription = "Minor axis";
			this.labelMinorAxis.AccessibleName = "Minor axis";
			this.labelMinorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelMinorAxis.AutoSize = true;
			this.labelMinorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelMinorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinorAxis.Location = new System.Drawing.Point(3, 483);
			this.labelMinorAxis.Name = "labelMinorAxis";
			this.labelMinorAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelMinorAxis.Size = new System.Drawing.Size(239, 21);
			this.labelMinorAxis.TabIndex = 24;
			this.labelMinorAxis.Text = "Minor axis";
			this.labelMinorAxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMinorAxis, "Minor axis");
			this.labelMinorAxis.Click += new System.EventHandler(this.LabelMinorAxis_Click);
			this.labelMinorAxis.Enter += new System.EventHandler(this.LabelMinorAxis_Enter);
			this.labelMinorAxis.Leave += new System.EventHandler(this.LabelMinorAxis_Leave);
			this.labelMinorAxis.MouseEnter += new System.EventHandler(this.LabelMinorAxis_Enter);
			this.labelMinorAxis.MouseLeave += new System.EventHandler(this.LabelMinorAxis_Leave);
			// 
			// labelEccenctricAnomaly
			// 
			this.labelEccenctricAnomaly.AccessibleDescription = "Eccentric anomaly";
			this.labelEccenctricAnomaly.AccessibleName = "Eccentric anomaly";
			this.labelEccenctricAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelEccenctricAnomaly.AutoSize = true;
			this.labelEccenctricAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.labelEccenctricAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEccenctricAnomaly.Location = new System.Drawing.Point(3, 504);
			this.labelEccenctricAnomaly.Name = "labelEccenctricAnomaly";
			this.labelEccenctricAnomaly.Padding = new System.Windows.Forms.Padding(3);
			this.labelEccenctricAnomaly.Size = new System.Drawing.Size(239, 21);
			this.labelEccenctricAnomaly.TabIndex = 25;
			this.labelEccenctricAnomaly.Text = "Eccentric anomaly";
			this.labelEccenctricAnomaly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelEccenctricAnomaly, "Eccentric anomaly");
			this.labelEccenctricAnomaly.Click += new System.EventHandler(this.LabelEccenctricAnomaly_Click);
			this.labelEccenctricAnomaly.Enter += new System.EventHandler(this.LabelEccenctricAnomaly_Enter);
			this.labelEccenctricAnomaly.Leave += new System.EventHandler(this.LabelEccenctricAnomaly_Leave);
			this.labelEccenctricAnomaly.MouseEnter += new System.EventHandler(this.LabelEccenctricAnomaly_Enter);
			this.labelEccenctricAnomaly.MouseLeave += new System.EventHandler(this.LabelEccenctricAnomaly_Leave);
			// 
			// labelPerihelionDistance
			// 
			this.labelPerihelionDistance.AccessibleDescription = "Perihelion distance";
			this.labelPerihelionDistance.AccessibleName = "Perihelion distance";
			this.labelPerihelionDistance.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelPerihelionDistance.AutoSize = true;
			this.labelPerihelionDistance.BackColor = System.Drawing.Color.Transparent;
			this.labelPerihelionDistance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPerihelionDistance.Location = new System.Drawing.Point(3, 546);
			this.labelPerihelionDistance.Name = "labelPerihelionDistance";
			this.labelPerihelionDistance.Padding = new System.Windows.Forms.Padding(3);
			this.labelPerihelionDistance.Size = new System.Drawing.Size(239, 21);
			this.labelPerihelionDistance.TabIndex = 27;
			this.labelPerihelionDistance.Text = "Perihelion distance";
			this.labelPerihelionDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelPerihelionDistance, "Perihelion distance");
			this.labelPerihelionDistance.Click += new System.EventHandler(this.LabelPerihelionDistance_Click);
			this.labelPerihelionDistance.Enter += new System.EventHandler(this.LabelPerihelionDistance_Enter);
			this.labelPerihelionDistance.Leave += new System.EventHandler(this.LabelPerihelionDistance_Leave);
			this.labelPerihelionDistance.MouseEnter += new System.EventHandler(this.LabelPerihelionDistance_Enter);
			this.labelPerihelionDistance.MouseLeave += new System.EventHandler(this.LabelPerihelionDistance_Leave);
			// 
			// labelAphelionDistance
			// 
			this.labelAphelionDistance.AccessibleDescription = "Aphelion distance";
			this.labelAphelionDistance.AccessibleName = "Aphelion distance";
			this.labelAphelionDistance.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelAphelionDistance.AutoSize = true;
			this.labelAphelionDistance.BackColor = System.Drawing.Color.Transparent;
			this.labelAphelionDistance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAphelionDistance.Location = new System.Drawing.Point(3, 567);
			this.labelAphelionDistance.Name = "labelAphelionDistance";
			this.labelAphelionDistance.Padding = new System.Windows.Forms.Padding(3);
			this.labelAphelionDistance.Size = new System.Drawing.Size(239, 21);
			this.labelAphelionDistance.TabIndex = 28;
			this.labelAphelionDistance.Text = "Aphelion distance";
			this.labelAphelionDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelAphelionDistance, "Aphelion distance");
			this.labelAphelionDistance.Click += new System.EventHandler(this.LabelAphelionDistance_Click);
			this.labelAphelionDistance.Enter += new System.EventHandler(this.LabelAphelionDistance_Enter);
			this.labelAphelionDistance.Leave += new System.EventHandler(this.LabelAphelionDistance_Leave);
			this.labelAphelionDistance.MouseEnter += new System.EventHandler(this.LabelAphelionDistance_Enter);
			this.labelAphelionDistance.MouseLeave += new System.EventHandler(this.LabelAphelionDistance_Leave);
			// 
			// labelLongitudeDescendingNode
			// 
			this.labelLongitudeDescendingNode.AccessibleDescription = "Longitude of descending node";
			this.labelLongitudeDescendingNode.AccessibleName = "Longitude of descending node";
			this.labelLongitudeDescendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelLongitudeDescendingNode.AutoSize = true;
			this.labelLongitudeDescendingNode.BackColor = System.Drawing.Color.Transparent;
			this.labelLongitudeDescendingNode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeDescendingNode.Location = new System.Drawing.Point(3, 588);
			this.labelLongitudeDescendingNode.Name = "labelLongitudeDescendingNode";
			this.labelLongitudeDescendingNode.Padding = new System.Windows.Forms.Padding(3);
			this.labelLongitudeDescendingNode.Size = new System.Drawing.Size(239, 21);
			this.labelLongitudeDescendingNode.TabIndex = 29;
			this.labelLongitudeDescendingNode.Text = "Longitude of descending node";
			this.labelLongitudeDescendingNode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelLongitudeDescendingNode, "Longitude of descending node");
			this.labelLongitudeDescendingNode.Click += new System.EventHandler(this.LabelLongitudeDescendingNode_Click);
			this.labelLongitudeDescendingNode.Enter += new System.EventHandler(this.LabelLongitudeDescendingNode_Enter);
			this.labelLongitudeDescendingNode.Leave += new System.EventHandler(this.LabelLongitudeDescendingNode_Leave);
			this.labelLongitudeDescendingNode.MouseEnter += new System.EventHandler(this.LabelLongitudeDescendingNode_Enter);
			this.labelLongitudeDescendingNode.MouseLeave += new System.EventHandler(this.LabelLongitudeDescendingNode_Leave);
			// 
			// labelArgumentAphelion
			// 
			this.labelArgumentAphelion.AccessibleDescription = "Argument of aphelion";
			this.labelArgumentAphelion.AccessibleName = "Argument of aphelion";
			this.labelArgumentAphelion.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelArgumentAphelion.AutoSize = true;
			this.labelArgumentAphelion.BackColor = System.Drawing.Color.Transparent;
			this.labelArgumentAphelion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentAphelion.Location = new System.Drawing.Point(3, 609);
			this.labelArgumentAphelion.Name = "labelArgumentAphelion";
			this.labelArgumentAphelion.Padding = new System.Windows.Forms.Padding(3);
			this.labelArgumentAphelion.Size = new System.Drawing.Size(239, 21);
			this.labelArgumentAphelion.TabIndex = 30;
			this.labelArgumentAphelion.Text = "Argument of aphelion";
			this.labelArgumentAphelion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelArgumentAphelion, "Argument of aphelion");
			this.labelArgumentAphelion.Click += new System.EventHandler(this.LabelArgumentAphelion_Click);
			this.labelArgumentAphelion.Enter += new System.EventHandler(this.LabelArgumentAphelion_Enter);
			this.labelArgumentAphelion.Leave += new System.EventHandler(this.LabelArgumentAphelion_Leave);
			this.labelArgumentAphelion.MouseEnter += new System.EventHandler(this.LabelArgumentAphelion_Enter);
			this.labelArgumentAphelion.MouseLeave += new System.EventHandler(this.LabelArgumentAphelion_Leave);
			// 
			// labelFocalParameter
			// 
			this.labelFocalParameter.AccessibleDescription = "Focal parameter";
			this.labelFocalParameter.AccessibleName = "Focal parameter";
			this.labelFocalParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelFocalParameter.AutoSize = true;
			this.labelFocalParameter.BackColor = System.Drawing.Color.Transparent;
			this.labelFocalParameter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFocalParameter.Location = new System.Drawing.Point(3, 630);
			this.labelFocalParameter.Name = "labelFocalParameter";
			this.labelFocalParameter.Padding = new System.Windows.Forms.Padding(3);
			this.labelFocalParameter.Size = new System.Drawing.Size(239, 21);
			this.labelFocalParameter.TabIndex = 31;
			this.labelFocalParameter.Text = "Focal parameter";
			this.labelFocalParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelFocalParameter, "Focal parameter");
			this.labelFocalParameter.Click += new System.EventHandler(this.LabelFocalParameter_Click);
			this.labelFocalParameter.Enter += new System.EventHandler(this.LabelFocalParameter_Enter);
			this.labelFocalParameter.Leave += new System.EventHandler(this.LabelFocalParameter_Leave);
			this.labelFocalParameter.MouseEnter += new System.EventHandler(this.LabelFocalParameter_Enter);
			this.labelFocalParameter.MouseLeave += new System.EventHandler(this.LabelFocalParameter_Leave);
			// 
			// labelSemiLatusRectum
			// 
			this.labelSemiLatusRectum.AccessibleDescription = "Semi-latus rectum";
			this.labelSemiLatusRectum.AccessibleName = "Semi-latus rectum";
			this.labelSemiLatusRectum.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelSemiLatusRectum.AutoSize = true;
			this.labelSemiLatusRectum.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiLatusRectum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiLatusRectum.Location = new System.Drawing.Point(3, 651);
			this.labelSemiLatusRectum.Name = "labelSemiLatusRectum";
			this.labelSemiLatusRectum.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiLatusRectum.Size = new System.Drawing.Size(239, 21);
			this.labelSemiLatusRectum.TabIndex = 32;
			this.labelSemiLatusRectum.Text = "Semi-latus rectum";
			this.labelSemiLatusRectum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSemiLatusRectum, "Semi-latus rectum");
			this.labelSemiLatusRectum.Click += new System.EventHandler(this.LabelSemiLatusRectum_Click);
			this.labelSemiLatusRectum.Enter += new System.EventHandler(this.LabelSemiLatusRectum_Enter);
			this.labelSemiLatusRectum.Leave += new System.EventHandler(this.LabelSemiLatusRectum_Leave);
			this.labelSemiLatusRectum.MouseEnter += new System.EventHandler(this.LabelSemiLatusRectum_Enter);
			this.labelSemiLatusRectum.MouseLeave += new System.EventHandler(this.LabelSemiLatusRectum_Leave);
			// 
			// labelLatusRectum
			// 
			this.labelLatusRectum.AccessibleDescription = "Latus rectum";
			this.labelLatusRectum.AccessibleName = "Latus rectum";
			this.labelLatusRectum.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelLatusRectum.AutoSize = true;
			this.labelLatusRectum.BackColor = System.Drawing.Color.Transparent;
			this.labelLatusRectum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLatusRectum.Location = new System.Drawing.Point(3, 672);
			this.labelLatusRectum.Name = "labelLatusRectum";
			this.labelLatusRectum.Padding = new System.Windows.Forms.Padding(3);
			this.labelLatusRectum.Size = new System.Drawing.Size(239, 21);
			this.labelLatusRectum.TabIndex = 33;
			this.labelLatusRectum.Text = "Latus rectum";
			this.labelLatusRectum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelLatusRectum, "Latus rectum");
			this.labelLatusRectum.Click += new System.EventHandler(this.LabelLatusRectum_Click);
			this.labelLatusRectum.Enter += new System.EventHandler(this.LabelLatusRectum_Enter);
			this.labelLatusRectum.Leave += new System.EventHandler(this.LabelLatusRectum_Leave);
			this.labelLatusRectum.MouseEnter += new System.EventHandler(this.LabelLatusRectum_Enter);
			this.labelLatusRectum.MouseLeave += new System.EventHandler(this.LabelLatusRectum_Leave);
			// 
			// labelPeriod
			// 
			this.labelPeriod.AccessibleDescription = "Period";
			this.labelPeriod.AccessibleName = "Period";
			this.labelPeriod.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelPeriod.AutoSize = true;
			this.labelPeriod.BackColor = System.Drawing.Color.Transparent;
			this.labelPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPeriod.Location = new System.Drawing.Point(3, 693);
			this.labelPeriod.Name = "labelPeriod";
			this.labelPeriod.Padding = new System.Windows.Forms.Padding(3);
			this.labelPeriod.Size = new System.Drawing.Size(239, 21);
			this.labelPeriod.TabIndex = 34;
			this.labelPeriod.Text = "Period";
			this.labelPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelPeriod, "Period");
			this.labelPeriod.Click += new System.EventHandler(this.LabelPeriod_Click);
			this.labelPeriod.Enter += new System.EventHandler(this.LabelPeriod_Enter);
			this.labelPeriod.Leave += new System.EventHandler(this.LabelPeriod_Leave);
			this.labelPeriod.MouseEnter += new System.EventHandler(this.LabelPeriod_Enter);
			this.labelPeriod.MouseLeave += new System.EventHandler(this.LabelPeriod_Leave);
			// 
			// labelOrbitalArea
			// 
			this.labelOrbitalArea.AccessibleDescription = "Orbital area";
			this.labelOrbitalArea.AccessibleName = "Orbital area";
			this.labelOrbitalArea.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelOrbitalArea.AutoSize = true;
			this.labelOrbitalArea.BackColor = System.Drawing.Color.Transparent;
			this.labelOrbitalArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalArea.Location = new System.Drawing.Point(3, 714);
			this.labelOrbitalArea.Name = "labelOrbitalArea";
			this.labelOrbitalArea.Padding = new System.Windows.Forms.Padding(3);
			this.labelOrbitalArea.Size = new System.Drawing.Size(239, 21);
			this.labelOrbitalArea.TabIndex = 35;
			this.labelOrbitalArea.Text = "Orbital area";
			this.labelOrbitalArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelOrbitalArea, "Orbital area");
			this.labelOrbitalArea.Click += new System.EventHandler(this.LabelOrbitalArea_Click);
			this.labelOrbitalArea.Enter += new System.EventHandler(this.LabelOrbitalArea_Enter);
			this.labelOrbitalArea.Leave += new System.EventHandler(this.LabelOrbitalArea_Leave);
			this.labelOrbitalArea.MouseEnter += new System.EventHandler(this.LabelOrbitalArea_Enter);
			this.labelOrbitalArea.MouseLeave += new System.EventHandler(this.LabelOrbitalArea_Leave);
			// 
			// labelOrbitalPerimeter
			// 
			this.labelOrbitalPerimeter.AccessibleDescription = "Orbital perimeter";
			this.labelOrbitalPerimeter.AccessibleName = "Orbital perimeter";
			this.labelOrbitalPerimeter.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelOrbitalPerimeter.AutoSize = true;
			this.labelOrbitalPerimeter.BackColor = System.Drawing.Color.Transparent;
			this.labelOrbitalPerimeter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalPerimeter.Location = new System.Drawing.Point(3, 735);
			this.labelOrbitalPerimeter.Name = "labelOrbitalPerimeter";
			this.labelOrbitalPerimeter.Padding = new System.Windows.Forms.Padding(3);
			this.labelOrbitalPerimeter.Size = new System.Drawing.Size(239, 21);
			this.labelOrbitalPerimeter.TabIndex = 36;
			this.labelOrbitalPerimeter.Text = "Orbital perimeter";
			this.labelOrbitalPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelOrbitalPerimeter, "Orbital perimeter");
			this.labelOrbitalPerimeter.Click += new System.EventHandler(this.LabelOrbitalPerimeter_Click);
			this.labelOrbitalPerimeter.Enter += new System.EventHandler(this.LabelOrbitalPerimeter_Enter);
			this.labelOrbitalPerimeter.Leave += new System.EventHandler(this.LabelOrbitalPerimeter_Leave);
			this.labelOrbitalPerimeter.MouseEnter += new System.EventHandler(this.LabelOrbitalPerimeter_Enter);
			this.labelOrbitalPerimeter.MouseLeave += new System.EventHandler(this.LabelOrbitalPerimeter_Leave);
			// 
			// labelSemiMeanAxis
			// 
			this.labelSemiMeanAxis.AccessibleDescription = "Semi-mean axis";
			this.labelSemiMeanAxis.AccessibleName = "Semi-mean axis";
			this.labelSemiMeanAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelSemiMeanAxis.AutoSize = true;
			this.labelSemiMeanAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiMeanAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMeanAxis.Location = new System.Drawing.Point(3, 756);
			this.labelSemiMeanAxis.Name = "labelSemiMeanAxis";
			this.labelSemiMeanAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiMeanAxis.Size = new System.Drawing.Size(239, 21);
			this.labelSemiMeanAxis.TabIndex = 37;
			this.labelSemiMeanAxis.Text = "Semi-mean axis";
			this.labelSemiMeanAxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSemiMeanAxis, "Semi-mean axis");
			this.labelSemiMeanAxis.Click += new System.EventHandler(this.LabelSemiMeanAxis_Click);
			this.labelSemiMeanAxis.Enter += new System.EventHandler(this.LabelSemiMeanAxis_Enter);
			this.labelSemiMeanAxis.Leave += new System.EventHandler(this.LabelSemiMeanAxis_Leave);
			this.labelSemiMeanAxis.MouseEnter += new System.EventHandler(this.LabelSemiMeanAxis_Enter);
			this.labelSemiMeanAxis.MouseLeave += new System.EventHandler(this.LabelSemiMeanAxis_Leave);
			// 
			// labelMeanAxis
			// 
			this.labelMeanAxis.AccessibleDescription = "Mean axis";
			this.labelMeanAxis.AccessibleName = "Mean axis";
			this.labelMeanAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelMeanAxis.AutoSize = true;
			this.labelMeanAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelMeanAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAxis.Location = new System.Drawing.Point(3, 777);
			this.labelMeanAxis.Name = "labelMeanAxis";
			this.labelMeanAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelMeanAxis.Size = new System.Drawing.Size(239, 21);
			this.labelMeanAxis.TabIndex = 38;
			this.labelMeanAxis.Text = "Mean axis";
			this.labelMeanAxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMeanAxis, "Mean axis");
			this.labelMeanAxis.Click += new System.EventHandler(this.LabelMeanAxis_Click);
			this.labelMeanAxis.Enter += new System.EventHandler(this.LabelMeanAxis_Enter);
			this.labelMeanAxis.Leave += new System.EventHandler(this.LabelMeanAxis_Leave);
			this.labelMeanAxis.MouseEnter += new System.EventHandler(this.LabelMeanAxis_Enter);
			this.labelMeanAxis.MouseLeave += new System.EventHandler(this.LabelMeanAxis_Leave);
			// 
			// labelStandardGravitationalParameter
			// 
			this.labelStandardGravitationalParameter.AccessibleDescription = "Standard gravitational parameter";
			this.labelStandardGravitationalParameter.AccessibleName = "Standard gravitational parameter";
			this.labelStandardGravitationalParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelStandardGravitationalParameter.AutoSize = true;
			this.labelStandardGravitationalParameter.BackColor = System.Drawing.Color.Transparent;
			this.labelStandardGravitationalParameter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStandardGravitationalParameter.Location = new System.Drawing.Point(3, 798);
			this.labelStandardGravitationalParameter.Name = "labelStandardGravitationalParameter";
			this.labelStandardGravitationalParameter.Padding = new System.Windows.Forms.Padding(3);
			this.labelStandardGravitationalParameter.Size = new System.Drawing.Size(239, 21);
			this.labelStandardGravitationalParameter.TabIndex = 0;
			this.labelStandardGravitationalParameter.Text = "Standard gravitational parameter";
			this.labelStandardGravitationalParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelStandardGravitationalParameter, "Standard gravitational parameter");
			this.labelStandardGravitationalParameter.Click += new System.EventHandler(this.LabelStandardGravitationalParameter_Click);
			this.labelStandardGravitationalParameter.Enter += new System.EventHandler(this.LabelStandardGravitationalParameter_Enter);
			this.labelStandardGravitationalParameter.Leave += new System.EventHandler(this.LabelStandardGravitationalParameter_Leave);
			this.labelStandardGravitationalParameter.MouseEnter += new System.EventHandler(this.LabelStandardGravitationalParameter_Enter);
			this.labelStandardGravitationalParameter.MouseLeave += new System.EventHandler(this.LabelStandardGravitationalParameter_Leave);
			// 
			// labelTrueAnomaly
			// 
			this.labelTrueAnomaly.AccessibleDescription = "True anomaly";
			this.labelTrueAnomaly.AccessibleName = "True anomaly";
			this.labelTrueAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelTrueAnomaly.AutoSize = true;
			this.labelTrueAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.labelTrueAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTrueAnomaly.Location = new System.Drawing.Point(3, 525);
			this.labelTrueAnomaly.Name = "labelTrueAnomaly";
			this.labelTrueAnomaly.Padding = new System.Windows.Forms.Padding(3);
			this.labelTrueAnomaly.Size = new System.Drawing.Size(239, 21);
			this.labelTrueAnomaly.TabIndex = 26;
			this.labelTrueAnomaly.Text = "True anomaly";
			this.labelTrueAnomaly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelTrueAnomaly, "True anomaly");
			this.labelTrueAnomaly.Click += new System.EventHandler(this.LabelTrueAnomaly_Click);
			this.labelTrueAnomaly.Enter += new System.EventHandler(this.LabelTrueAnomaly_Enter);
			this.labelTrueAnomaly.Leave += new System.EventHandler(this.LabelTrueAnomaly_Leave);
			this.labelTrueAnomaly.MouseEnter += new System.EventHandler(this.LabelTrueAnomaly_Enter);
			this.labelTrueAnomaly.MouseLeave += new System.EventHandler(this.LabelTrueAnomaly_Leave);
			// 
			// tableLayoutPanelLeft
			// 
			this.tableLayoutPanelLeft.AutoScroll = true;
			this.tableLayoutPanelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanelLeft.BackgroundImage")));
			this.tableLayoutPanelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanelLeft.ColumnCount = 1;
			this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelLeft.Controls.Add(this.labelObsLastDate, 0, 19);
			this.tableLayoutPanelLeft.Controls.Add(this.labelIndex, 0, 0);
			this.tableLayoutPanelLeft.Controls.Add(this.labelDesgnName, 0, 1);
			this.tableLayoutPanelLeft.Controls.Add(this.labelEpoch, 0, 2);
			this.tableLayoutPanelLeft.Controls.Add(this.labelMeanAnomaly, 0, 3);
			this.tableLayoutPanelLeft.Controls.Add(this.labelLongAscNode, 0, 5);
			this.tableLayoutPanelLeft.Controls.Add(this.labelArgPeri, 0, 4);
			this.tableLayoutPanelLeft.Controls.Add(this.labelMotion, 0, 8);
			this.tableLayoutPanelLeft.Controls.Add(this.labelIncl, 0, 6);
			this.tableLayoutPanelLeft.Controls.Add(this.labelSlopeParam, 0, 11);
			this.tableLayoutPanelLeft.Controls.Add(this.labelOrbEcc, 0, 7);
			this.tableLayoutPanelLeft.Controls.Add(this.labelSemiMajorAxis, 0, 9);
			this.tableLayoutPanelLeft.Controls.Add(this.labelNumbOppos, 0, 13);
			this.tableLayoutPanelLeft.Controls.Add(this.labelMagAbs, 0, 10);
			this.tableLayoutPanelLeft.Controls.Add(this.labelRef, 0, 12);
			this.tableLayoutPanelLeft.Controls.Add(this.labelRmsResidual, 0, 16);
			this.tableLayoutPanelLeft.Controls.Add(this.labelNumbObs, 0, 14);
			this.tableLayoutPanelLeft.Controls.Add(this.labelFlags, 0, 18);
			this.tableLayoutPanelLeft.Controls.Add(this.labelObsSpan, 0, 15);
			this.tableLayoutPanelLeft.Controls.Add(this.labelComputerName, 0, 17);
			this.tableLayoutPanelLeft.Controls.Add(this.labelLinearEccentricity, 0, 20);
			this.tableLayoutPanelLeft.Controls.Add(this.labelSemiMinorAxis, 0, 21);
			this.tableLayoutPanelLeft.Controls.Add(this.labelMajorAxis, 0, 22);
			this.tableLayoutPanelLeft.Controls.Add(this.labelMinorAxis, 0, 23);
			this.tableLayoutPanelLeft.Controls.Add(this.labelEccenctricAnomaly, 0, 24);
			this.tableLayoutPanelLeft.Controls.Add(this.labelPerihelionDistance, 0, 26);
			this.tableLayoutPanelLeft.Controls.Add(this.labelAphelionDistance, 0, 27);
			this.tableLayoutPanelLeft.Controls.Add(this.labelLongitudeDescendingNode, 0, 28);
			this.tableLayoutPanelLeft.Controls.Add(this.labelArgumentAphelion, 0, 29);
			this.tableLayoutPanelLeft.Controls.Add(this.labelFocalParameter, 0, 30);
			this.tableLayoutPanelLeft.Controls.Add(this.labelSemiLatusRectum, 0, 31);
			this.tableLayoutPanelLeft.Controls.Add(this.labelLatusRectum, 0, 32);
			this.tableLayoutPanelLeft.Controls.Add(this.labelPeriod, 0, 33);
			this.tableLayoutPanelLeft.Controls.Add(this.labelOrbitalArea, 0, 34);
			this.tableLayoutPanelLeft.Controls.Add(this.labelOrbitalPerimeter, 0, 35);
			this.tableLayoutPanelLeft.Controls.Add(this.labelSemiMeanAxis, 0, 36);
			this.tableLayoutPanelLeft.Controls.Add(this.labelMeanAxis, 0, 37);
			this.tableLayoutPanelLeft.Controls.Add(this.labelStandardGravitationalParameter, 0, 38);
			this.tableLayoutPanelLeft.Controls.Add(this.labelTrueAnomaly, 0, 25);
			this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
			this.tableLayoutPanelLeft.RowCount = 39;
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelLeft.Size = new System.Drawing.Size(245, 500);
			this.tableLayoutPanelLeft.TabIndex = 0;
			this.tableLayoutPanelLeft.TabStop = true;
			// 
			// tableLayoutPanelOuter
			// 
			this.tableLayoutPanelOuter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanelOuter.BackgroundImage")));
			this.tableLayoutPanelOuter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanelOuter.ColumnCount = 2;
			this.tableLayoutPanelOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelOuter.Controls.Add(this.kryptonStatusStrip, 0, 1);
			this.tableLayoutPanelOuter.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
			this.tableLayoutPanelOuter.Controls.Add(this.tableLayoutPanelRight, 1, 0);
			this.tableLayoutPanelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelOuter.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelOuter.Name = "tableLayoutPanelOuter";
			this.tableLayoutPanelOuter.RowCount = 2;
			this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelOuter.Size = new System.Drawing.Size(609, 525);
			this.tableLayoutPanelOuter.TabIndex = 0;
			this.tableLayoutPanelOuter.TabStop = true;
			// 
			// tableLayoutPanelRight
			// 
			this.tableLayoutPanelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanelRight.BackgroundImage")));
			this.tableLayoutPanelRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanelRight.ColumnCount = 1;
			this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelRight.Controls.Add(this.buttonOK, 0, 1);
			this.tableLayoutPanelRight.Controls.Add(this.webBrowser, 0, 0);
			this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelRight.Location = new System.Drawing.Point(254, 3);
			this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
			this.tableLayoutPanelRight.RowCount = 2;
			this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.1253F));
			this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8747F));
			this.tableLayoutPanelRight.Size = new System.Drawing.Size(352, 500);
			this.tableLayoutPanelRight.TabIndex = 1;
			this.tableLayoutPanelRight.TabStop = true;
			// 
			// webBrowser
			// 
			this.webBrowser.AccessibleDescription = "Inform about some definitions";
			this.webBrowser.AccessibleName = "Webbrowser";
			this.webBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser.Location = new System.Drawing.Point(3, 3);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(346, 439);
			this.webBrowser.TabIndex = 0;
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.tableLayoutPanelOuter.SetColumnSpan(this.kryptonStatusStrip, 2);
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 506);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(609, 20);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 4;
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
			this.labelInformation.Size = new System.Drawing.Size(144, 15);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// TerminologyForm
			// 
			this.AccessibleDescription = "Inform about some definitions";
			this.AccessibleName = "Terminology";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 525);
			this.Controls.Add(this.tableLayoutPanelOuter);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TerminologyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.Text = "Terminology";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerminologyForm_FormClosed);
			this.Load += new System.EventHandler(this.TerminologyForm_Load);
			this.tableLayoutPanelLeft.ResumeLayout(false);
			this.tableLayoutPanelLeft.PerformLayout();
			this.tableLayoutPanelOuter.ResumeLayout(false);
			this.tableLayoutPanelOuter.PerformLayout();
			this.tableLayoutPanelRight.ResumeLayout(false);
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label labelIndex;
		private System.Windows.Forms.Label labelDesgnName;
		private System.Windows.Forms.Label labelEpoch;
		private System.Windows.Forms.Label labelMeanAnomaly;
		private System.Windows.Forms.Label labelArgPeri;
		private System.Windows.Forms.Label labelLongAscNode;
		private System.Windows.Forms.Label labelIncl;
		private System.Windows.Forms.Label labelOrbEcc;
		private System.Windows.Forms.Label labelMotion;
		private System.Windows.Forms.Label labelSemiMajorAxis;
		private System.Windows.Forms.Label labelMagAbs;
		private System.Windows.Forms.Label labelSlopeParam;
		private System.Windows.Forms.Label labelRef;
		private System.Windows.Forms.Label labelNumbOppos;
		private System.Windows.Forms.Label labelNumbObs;
		private System.Windows.Forms.Label labelObsSpan;
		private System.Windows.Forms.Label labelRmsResidual;
		private System.Windows.Forms.Label labelComputerName;
		private System.Windows.Forms.Label labelFlags;
		private System.Windows.Forms.Label labelObsLastDate;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Label labelLinearEccentricity;
		private System.Windows.Forms.Label labelSemiMinorAxis;
		private System.Windows.Forms.Label labelMajorAxis;
		private System.Windows.Forms.Label labelMinorAxis;
		private System.Windows.Forms.Label labelEccenctricAnomaly;
		private System.Windows.Forms.Label labelPerihelionDistance;
		private System.Windows.Forms.Label labelAphelionDistance;
		private System.Windows.Forms.Label labelLongitudeDescendingNode;
		private System.Windows.Forms.Label labelArgumentAphelion;
		private System.Windows.Forms.Label labelFocalParameter;
		private System.Windows.Forms.Label labelSemiLatusRectum;
		private System.Windows.Forms.Label labelLatusRectum;
		private System.Windows.Forms.Label labelPeriod;
		private System.Windows.Forms.Label labelOrbitalArea;
		private System.Windows.Forms.Label labelOrbitalPerimeter;
		private System.Windows.Forms.Label labelSemiMeanAxis;
		private System.Windows.Forms.Label labelMeanAxis;
		private System.Windows.Forms.Label labelStandardGravitationalParameter;
		private System.Windows.Forms.Label labelTrueAnomaly;
        private KryptonTableLayoutPanel tableLayoutPanelLeft;
        private KryptonTableLayoutPanel tableLayoutPanelOuter;
        private KryptonTableLayoutPanel tableLayoutPanelRight;
		private KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}