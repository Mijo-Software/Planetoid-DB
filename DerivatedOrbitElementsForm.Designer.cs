using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class DerivatedOrbitElementsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DerivatedOrbitElementsForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelLinearEccentricityDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelLinearEccentricityData = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiMinorAxisDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelMajorAxisDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelMinorAxisDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelEccenctricAnomalyDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelTrueAnomalyDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelPerihelionDistanceDesc = new Krypton.Toolkit.KryptonLabel();
			this.LabelAphelionDistanceDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelLongitudeDescendingNodeDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelArgumentAphelionDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelFocalParameterDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiLatusRectumDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelLatusRectumDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelOrbitalPeriodDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiMinorAxisData = new Krypton.Toolkit.KryptonLabel();
			this.labelMajorAxisData = new Krypton.Toolkit.KryptonLabel();
			this.labelMinorAxisData = new Krypton.Toolkit.KryptonLabel();
			this.labelEccentricAnomalyData = new Krypton.Toolkit.KryptonLabel();
			this.labelTrueAnomalyData = new Krypton.Toolkit.KryptonLabel();
			this.labelPerihelionDistanceData = new Krypton.Toolkit.KryptonLabel();
			this.labelAphelionDistanceData = new Krypton.Toolkit.KryptonLabel();
			this.labelLongitudeDescendingNodeData = new Krypton.Toolkit.KryptonLabel();
			this.labelArgumentAphelionData = new Krypton.Toolkit.KryptonLabel();
			this.labelFocalParameterData = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiLatusRectumData = new Krypton.Toolkit.KryptonLabel();
			this.labelLatusRectumData = new Krypton.Toolkit.KryptonLabel();
			this.labelPeriodData = new Krypton.Toolkit.KryptonLabel();
			this.labelOrbitalAreaDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelOrbitalPerimeterDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiMeanAxisDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelMeanAxisDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelOrbitalAreaData = new Krypton.Toolkit.KryptonLabel();
			this.labelOrbitalPerimeterData = new Krypton.Toolkit.KryptonLabel();
			this.labelSemiMeanAxisData = new Krypton.Toolkit.KryptonLabel();
			this.labelStandardGravitationalParameterDesc = new Krypton.Toolkit.KryptonLabel();
			this.labelMeanAxisData = new Krypton.Toolkit.KryptonLabel();
			this.labelStandardGravitationalParameterData = new Krypton.Toolkit.KryptonLabel();
			this.tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.tableLayoutPanel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelLinearEccentricityDesc
			// 
			this.labelLinearEccentricityDesc.AccessibleDescription = "Linear eccentricity (AU)";
			this.labelLinearEccentricityDesc.AccessibleName = "Linear eccentricity (AU)";
			this.labelLinearEccentricityDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLinearEccentricityDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLinearEccentricityDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelLinearEccentricityDesc.Location = new System.Drawing.Point(3, 3);
			this.labelLinearEccentricityDesc.Name = "labelLinearEccentricityDesc";
			this.labelLinearEccentricityDesc.Size = new System.Drawing.Size(254, 20);
			this.labelLinearEccentricityDesc.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelLinearEccentricityDesc, "Linear eccentricity (AU)");
			this.labelLinearEccentricityDesc.Values.ExtraText = "AU";
			this.labelLinearEccentricityDesc.Values.Text = "Linear eccentricity";
			this.labelLinearEccentricityDesc.DoubleClick += new System.EventHandler(this.LabelLinearEccentricityDesc_DoubleClick);
			this.labelLinearEccentricityDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricityDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLinearEccentricityDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricityDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLinearEccentricityData
			// 
			this.labelLinearEccentricityData.AccessibleDescription = "Shows the information of \"Linear eccentricity\"";
			this.labelLinearEccentricityData.AccessibleName = "Shows the information of \"Linear eccentricity\"";
			this.labelLinearEccentricityData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLinearEccentricityData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLinearEccentricityData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLinearEccentricityData.Location = new System.Drawing.Point(263, 3);
			this.labelLinearEccentricityData.Name = "labelLinearEccentricityData";
			this.labelLinearEccentricityData.Size = new System.Drawing.Size(209, 20);
			this.labelLinearEccentricityData.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelLinearEccentricityData, "Shows the information of \"Linear eccentricity\"");
			this.labelLinearEccentricityData.Values.Text = "..................";
			this.labelLinearEccentricityData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelLinearEccentricityData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricityData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLinearEccentricityData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricityData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMinorAxisDesc
			// 
			this.labelSemiMinorAxisDesc.AccessibleDescription = "Semi-minor axis (AU)";
			this.labelSemiMinorAxisDesc.AccessibleName = "Semi-minor axis (AU)";
			this.labelSemiMinorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMinorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMinorAxisDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelSemiMinorAxisDesc.Location = new System.Drawing.Point(3, 29);
			this.labelSemiMinorAxisDesc.Name = "labelSemiMinorAxisDesc";
			this.labelSemiMinorAxisDesc.Size = new System.Drawing.Size(254, 20);
			this.labelSemiMinorAxisDesc.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelSemiMinorAxisDesc, "Semi-minor axis (AU)");
			this.labelSemiMinorAxisDesc.Values.ExtraText = "AU";
			this.labelSemiMinorAxisDesc.Values.Text = "Semi-minor axis";
			this.labelSemiMinorAxisDesc.DoubleClick += new System.EventHandler(this.LabelSemiMinorAxisDesc_DoubleClick);
			this.labelSemiMinorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMinorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMajorAxisDesc
			// 
			this.labelMajorAxisDesc.AccessibleDescription = "Major axis (AU)";
			this.labelMajorAxisDesc.AccessibleName = "Major axis (AU)";
			this.labelMajorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMajorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMajorAxisDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelMajorAxisDesc.Location = new System.Drawing.Point(3, 55);
			this.labelMajorAxisDesc.Name = "labelMajorAxisDesc";
			this.labelMajorAxisDesc.Size = new System.Drawing.Size(254, 20);
			this.labelMajorAxisDesc.TabIndex = 4;
			this.toolTip.SetToolTip(this.labelMajorAxisDesc, "Major axis (AU)");
			this.labelMajorAxisDesc.Values.ExtraText = "AU";
			this.labelMajorAxisDesc.Values.Text = "Major axis";
			this.labelMajorAxisDesc.DoubleClick += new System.EventHandler(this.LabelMajorAxisDesc_DoubleClick);
			this.labelMajorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMajorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMinorAxisDesc
			// 
			this.labelMinorAxisDesc.AccessibleDescription = "Minor axis (AU)";
			this.labelMinorAxisDesc.AccessibleName = "Minor axis (AU)";
			this.labelMinorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMinorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinorAxisDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelMinorAxisDesc.Location = new System.Drawing.Point(3, 81);
			this.labelMinorAxisDesc.Name = "labelMinorAxisDesc";
			this.labelMinorAxisDesc.Size = new System.Drawing.Size(254, 20);
			this.labelMinorAxisDesc.TabIndex = 6;
			this.toolTip.SetToolTip(this.labelMinorAxisDesc, "Minor axis (AU)");
			this.labelMinorAxisDesc.Values.ExtraText = "AU";
			this.labelMinorAxisDesc.Values.Text = "Minor axis";
			this.labelMinorAxisDesc.DoubleClick += new System.EventHandler(this.LabelMinorAxisDesc_DoubleClick);
			this.labelMinorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMinorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEccenctricAnomalyDesc
			// 
			this.labelEccenctricAnomalyDesc.AccessibleDescription = "Eccentric anomaly (degrees)";
			this.labelEccenctricAnomalyDesc.AccessibleName = "Eccentric anomaly (degrees)";
			this.labelEccenctricAnomalyDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEccenctricAnomalyDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEccenctricAnomalyDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelEccenctricAnomalyDesc.Location = new System.Drawing.Point(3, 107);
			this.labelEccenctricAnomalyDesc.Name = "labelEccenctricAnomalyDesc";
			this.labelEccenctricAnomalyDesc.Size = new System.Drawing.Size(254, 20);
			this.labelEccenctricAnomalyDesc.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelEccenctricAnomalyDesc, "Eccentric anomaly (°)");
			this.labelEccenctricAnomalyDesc.Values.ExtraText = "°";
			this.labelEccenctricAnomalyDesc.Values.Text = "Eccentric anomaly";
			this.labelEccenctricAnomalyDesc.DoubleClick += new System.EventHandler(this.LabelEccenctricAnomalyDesc_DoubleClick);
			this.labelEccenctricAnomalyDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccenctricAnomalyDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEccenctricAnomalyDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccenctricAnomalyDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTrueAnomalyDesc
			// 
			this.labelTrueAnomalyDesc.AccessibleDescription = "True anomaly (degrees)";
			this.labelTrueAnomalyDesc.AccessibleName = "True anomaly (degrees)";
			this.labelTrueAnomalyDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTrueAnomalyDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTrueAnomalyDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelTrueAnomalyDesc.Location = new System.Drawing.Point(3, 133);
			this.labelTrueAnomalyDesc.Name = "labelTrueAnomalyDesc";
			this.labelTrueAnomalyDesc.Size = new System.Drawing.Size(254, 20);
			this.labelTrueAnomalyDesc.TabIndex = 10;
			this.toolTip.SetToolTip(this.labelTrueAnomalyDesc, "True anomaly (°)");
			this.labelTrueAnomalyDesc.Values.ExtraText = "°";
			this.labelTrueAnomalyDesc.Values.Text = "True anomaly";
			this.labelTrueAnomalyDesc.DoubleClick += new System.EventHandler(this.LabelTrueAnomalyDesc_DoubleClick);
			this.labelTrueAnomalyDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomalyDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTrueAnomalyDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomalyDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPerihelionDistanceDesc
			// 
			this.labelPerihelionDistanceDesc.AccessibleDescription = "Perihelion distance (AU)";
			this.labelPerihelionDistanceDesc.AccessibleName = "Perihelion distance (AU)";
			this.labelPerihelionDistanceDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPerihelionDistanceDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPerihelionDistanceDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelPerihelionDistanceDesc.Location = new System.Drawing.Point(3, 159);
			this.labelPerihelionDistanceDesc.Name = "labelPerihelionDistanceDesc";
			this.labelPerihelionDistanceDesc.Size = new System.Drawing.Size(254, 20);
			this.labelPerihelionDistanceDesc.TabIndex = 12;
			this.toolTip.SetToolTip(this.labelPerihelionDistanceDesc, "Perihelion distance (AU)");
			this.labelPerihelionDistanceDesc.Values.ExtraText = "AU";
			this.labelPerihelionDistanceDesc.Values.Text = "Perihelion distance";
			this.labelPerihelionDistanceDesc.DoubleClick += new System.EventHandler(this.LabelPerihelionDistanceDesc_DoubleClick);
			this.labelPerihelionDistanceDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistanceDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPerihelionDistanceDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistanceDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// LabelAphelionDistanceDesc
			// 
			this.LabelAphelionDistanceDesc.AccessibleDescription = "Aphelion distance";
			this.LabelAphelionDistanceDesc.AccessibleName = "Aphelion distance";
			this.LabelAphelionDistanceDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.LabelAphelionDistanceDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAphelionDistanceDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.LabelAphelionDistanceDesc.Location = new System.Drawing.Point(3, 185);
			this.LabelAphelionDistanceDesc.Name = "LabelAphelionDistanceDesc";
			this.LabelAphelionDistanceDesc.Size = new System.Drawing.Size(254, 20);
			this.LabelAphelionDistanceDesc.TabIndex = 14;
			this.toolTip.SetToolTip(this.LabelAphelionDistanceDesc, "Aphelion distance (AU)");
			this.LabelAphelionDistanceDesc.Values.ExtraText = "AU";
			this.LabelAphelionDistanceDesc.Values.Text = "Aphelion distance";
			this.LabelAphelionDistanceDesc.DoubleClick += new System.EventHandler(this.LabelAphelionDistanceDesc_DoubleClick);
			this.LabelAphelionDistanceDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.LabelAphelionDistanceDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.LabelAphelionDistanceDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.LabelAphelionDistanceDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLongitudeDescendingNodeDesc
			// 
			this.labelLongitudeDescendingNodeDesc.AccessibleDescription = "Longitude of the descending node (degrees)";
			this.labelLongitudeDescendingNodeDesc.AccessibleName = "Longitude of the descending node (degrees)";
			this.labelLongitudeDescendingNodeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLongitudeDescendingNodeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeDescendingNodeDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelLongitudeDescendingNodeDesc.Location = new System.Drawing.Point(3, 211);
			this.labelLongitudeDescendingNodeDesc.Name = "labelLongitudeDescendingNodeDesc";
			this.labelLongitudeDescendingNodeDesc.Size = new System.Drawing.Size(254, 20);
			this.labelLongitudeDescendingNodeDesc.TabIndex = 16;
			this.toolTip.SetToolTip(this.labelLongitudeDescendingNodeDesc, "Longitude of the descending node (°)");
			this.labelLongitudeDescendingNodeDesc.Values.ExtraText = "°";
			this.labelLongitudeDescendingNodeDesc.Values.Text = "Longitude of the descending node";
			this.labelLongitudeDescendingNodeDesc.DoubleClick += new System.EventHandler(this.LabelLongitudeDescendingNodeDesc_DoubleClick);
			this.labelLongitudeDescendingNodeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNodeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLongitudeDescendingNodeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNodeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelArgumentAphelionDesc
			// 
			this.labelArgumentAphelionDesc.AccessibleDescription = "Argument of aphelion (degrees)";
			this.labelArgumentAphelionDesc.AccessibleName = "Argument of aphelion (degrees)";
			this.labelArgumentAphelionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelArgumentAphelionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentAphelionDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelArgumentAphelionDesc.Location = new System.Drawing.Point(3, 237);
			this.labelArgumentAphelionDesc.Name = "labelArgumentAphelionDesc";
			this.labelArgumentAphelionDesc.Size = new System.Drawing.Size(254, 20);
			this.labelArgumentAphelionDesc.TabIndex = 18;
			this.toolTip.SetToolTip(this.labelArgumentAphelionDesc, "Argument of aphelion (°)");
			this.labelArgumentAphelionDesc.Values.ExtraText = "°";
			this.labelArgumentAphelionDesc.Values.Text = "Argument of aphelion";
			this.labelArgumentAphelionDesc.DoubleClick += new System.EventHandler(this.LabelArgumentAphelionDesc_DoubleClick);
			this.labelArgumentAphelionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelArgumentAphelionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelFocalParameterDesc
			// 
			this.labelFocalParameterDesc.AccessibleDescription = "Focal parameter";
			this.labelFocalParameterDesc.AccessibleName = "Focal parameter";
			this.labelFocalParameterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFocalParameterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFocalParameterDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelFocalParameterDesc.Location = new System.Drawing.Point(3, 263);
			this.labelFocalParameterDesc.Name = "labelFocalParameterDesc";
			this.labelFocalParameterDesc.Size = new System.Drawing.Size(254, 20);
			this.labelFocalParameterDesc.TabIndex = 20;
			this.toolTip.SetToolTip(this.labelFocalParameterDesc, "Focal parameter");
			this.labelFocalParameterDesc.Values.ExtraText = "AU";
			this.labelFocalParameterDesc.Values.Text = "Focal parameter";
			this.labelFocalParameterDesc.DoubleClick += new System.EventHandler(this.LabelFocalParameterDesc_DoubleClick);
			this.labelFocalParameterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelFocalParameterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiLatusRectumDesc
			// 
			this.labelSemiLatusRectumDesc.AccessibleDescription = "Semi-latus rectum (AU)";
			this.labelSemiLatusRectumDesc.AccessibleName = "Semi-latus rectum (AU)";
			this.labelSemiLatusRectumDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiLatusRectumDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiLatusRectumDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelSemiLatusRectumDesc.Location = new System.Drawing.Point(3, 289);
			this.labelSemiLatusRectumDesc.Name = "labelSemiLatusRectumDesc";
			this.labelSemiLatusRectumDesc.Size = new System.Drawing.Size(254, 20);
			this.labelSemiLatusRectumDesc.TabIndex = 22;
			this.toolTip.SetToolTip(this.labelSemiLatusRectumDesc, "Semi-latus rectum (AU)");
			this.labelSemiLatusRectumDesc.Values.ExtraText = "AU";
			this.labelSemiLatusRectumDesc.Values.Text = "Semi-latus rectum";
			this.labelSemiLatusRectumDesc.DoubleClick += new System.EventHandler(this.LabelSemiLatusRectumDesc_DoubleClick);
			this.labelSemiLatusRectumDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectumDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiLatusRectumDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectumDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLatusRectumDesc
			// 
			this.labelLatusRectumDesc.AccessibleDescription = "Latus rectum (AU)";
			this.labelLatusRectumDesc.AccessibleName = "Latus rectum (AU)";
			this.labelLatusRectumDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLatusRectumDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLatusRectumDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelLatusRectumDesc.Location = new System.Drawing.Point(3, 315);
			this.labelLatusRectumDesc.Name = "labelLatusRectumDesc";
			this.labelLatusRectumDesc.Size = new System.Drawing.Size(254, 20);
			this.labelLatusRectumDesc.TabIndex = 24;
			this.toolTip.SetToolTip(this.labelLatusRectumDesc, "Latus rectum (AU)");
			this.labelLatusRectumDesc.Values.ExtraText = "AU";
			this.labelLatusRectumDesc.Values.Text = "Latus rectum";
			this.labelLatusRectumDesc.DoubleClick += new System.EventHandler(this.LabelLatusRectumDesc_DoubleClick);
			this.labelLatusRectumDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectumDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLatusRectumDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectumDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalPeriodDesc
			// 
			this.labelOrbitalPeriodDesc.AccessibleDescription = "Orbital period (years)";
			this.labelOrbitalPeriodDesc.AccessibleName = "Orbital period (years)";
			this.labelOrbitalPeriodDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalPeriodDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalPeriodDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelOrbitalPeriodDesc.Location = new System.Drawing.Point(3, 341);
			this.labelOrbitalPeriodDesc.Name = "labelOrbitalPeriodDesc";
			this.labelOrbitalPeriodDesc.Size = new System.Drawing.Size(254, 20);
			this.labelOrbitalPeriodDesc.TabIndex = 26;
			this.toolTip.SetToolTip(this.labelOrbitalPeriodDesc, "Orbital Period (years)");
			this.labelOrbitalPeriodDesc.Values.ExtraText = "years";
			this.labelOrbitalPeriodDesc.Values.Text = "Orbital period";
			this.labelOrbitalPeriodDesc.DoubleClick += new System.EventHandler(this.LabelOrbitalPeriodDesc_DoubleClick);
			this.labelOrbitalPeriodDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPeriodDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalPeriodDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPeriodDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMinorAxisData
			// 
			this.labelSemiMinorAxisData.AccessibleDescription = "Shows the information of \"Semi-minor axis\"";
			this.labelSemiMinorAxisData.AccessibleName = "Shows the information of \"Semi-minor axis\"";
			this.labelSemiMinorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMinorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMinorAxisData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSemiMinorAxisData.Location = new System.Drawing.Point(263, 29);
			this.labelSemiMinorAxisData.Name = "labelSemiMinorAxisData";
			this.labelSemiMinorAxisData.Size = new System.Drawing.Size(209, 20);
			this.labelSemiMinorAxisData.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelSemiMinorAxisData, "Shows the information of \"Semi-minor axis\"");
			this.labelSemiMinorAxisData.Values.Text = "..................";
			this.labelSemiMinorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSemiMinorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMinorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMajorAxisData
			// 
			this.labelMajorAxisData.AccessibleDescription = "Shows the information of \"Major axis\"";
			this.labelMajorAxisData.AccessibleName = "Shows the information of \"Major axis\"";
			this.labelMajorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMajorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMajorAxisData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMajorAxisData.Location = new System.Drawing.Point(263, 55);
			this.labelMajorAxisData.Name = "labelMajorAxisData";
			this.labelMajorAxisData.Size = new System.Drawing.Size(209, 20);
			this.labelMajorAxisData.TabIndex = 5;
			this.toolTip.SetToolTip(this.labelMajorAxisData, "Shows the information of \"Major axis\"");
			this.labelMajorAxisData.Values.Text = "..................";
			this.labelMajorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelMajorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMajorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMinorAxisData
			// 
			this.labelMinorAxisData.AccessibleDescription = "Shows the information of \"Minor axis\"";
			this.labelMinorAxisData.AccessibleName = "Shows the information of \"Minor axis\"";
			this.labelMinorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMinorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinorAxisData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMinorAxisData.Location = new System.Drawing.Point(263, 81);
			this.labelMinorAxisData.Name = "labelMinorAxisData";
			this.labelMinorAxisData.Size = new System.Drawing.Size(209, 20);
			this.labelMinorAxisData.TabIndex = 7;
			this.toolTip.SetToolTip(this.labelMinorAxisData, "Shows the information of \"Minor axis\"");
			this.labelMinorAxisData.Values.Text = "..................";
			this.labelMinorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelMinorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMinorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEccentricAnomalyData
			// 
			this.labelEccentricAnomalyData.AccessibleDescription = "Shows the information of \"Eccentric anomaly\"";
			this.labelEccentricAnomalyData.AccessibleName = "Shows the information of \"Eccentric anomaly\"";
			this.labelEccentricAnomalyData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEccentricAnomalyData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEccentricAnomalyData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEccentricAnomalyData.Location = new System.Drawing.Point(263, 107);
			this.labelEccentricAnomalyData.Name = "labelEccentricAnomalyData";
			this.labelEccentricAnomalyData.Size = new System.Drawing.Size(209, 20);
			this.labelEccentricAnomalyData.TabIndex = 9;
			this.toolTip.SetToolTip(this.labelEccentricAnomalyData, "Shows the information of \"Eccentric anomaly\"");
			this.labelEccentricAnomalyData.Values.Text = "..................";
			this.labelEccentricAnomalyData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelEccentricAnomalyData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccentricAnomalyData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEccentricAnomalyData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccentricAnomalyData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTrueAnomalyData
			// 
			this.labelTrueAnomalyData.AccessibleDescription = "Shows the information of \"True anomaly\"";
			this.labelTrueAnomalyData.AccessibleName = "Shows the information of \"True anomaly\"";
			this.labelTrueAnomalyData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTrueAnomalyData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTrueAnomalyData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTrueAnomalyData.Location = new System.Drawing.Point(263, 133);
			this.labelTrueAnomalyData.Name = "labelTrueAnomalyData";
			this.labelTrueAnomalyData.Size = new System.Drawing.Size(209, 20);
			this.labelTrueAnomalyData.TabIndex = 11;
			this.toolTip.SetToolTip(this.labelTrueAnomalyData, "Shows the information of \"True anomaly\"");
			this.labelTrueAnomalyData.Values.Text = "..................";
			this.labelTrueAnomalyData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelTrueAnomalyData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomalyData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTrueAnomalyData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomalyData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPerihelionDistanceData
			// 
			this.labelPerihelionDistanceData.AccessibleDescription = "Shows the information of \"Perihelion distance\"";
			this.labelPerihelionDistanceData.AccessibleName = "Shows the information of \"Perihelion distance\"";
			this.labelPerihelionDistanceData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPerihelionDistanceData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPerihelionDistanceData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPerihelionDistanceData.Location = new System.Drawing.Point(263, 159);
			this.labelPerihelionDistanceData.Name = "labelPerihelionDistanceData";
			this.labelPerihelionDistanceData.Size = new System.Drawing.Size(209, 20);
			this.labelPerihelionDistanceData.TabIndex = 13;
			this.toolTip.SetToolTip(this.labelPerihelionDistanceData, "Shows the information of \"Perihelion distance\"");
			this.labelPerihelionDistanceData.Values.Text = "..................";
			this.labelPerihelionDistanceData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelPerihelionDistanceData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistanceData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPerihelionDistanceData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistanceData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAphelionDistanceData
			// 
			this.labelAphelionDistanceData.AccessibleDescription = "Shows the information of \"Aphelion distance\"";
			this.labelAphelionDistanceData.AccessibleName = "Shows the information of \"Aphelion distance\"";
			this.labelAphelionDistanceData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelAphelionDistanceData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAphelionDistanceData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAphelionDistanceData.Location = new System.Drawing.Point(263, 185);
			this.labelAphelionDistanceData.Name = "labelAphelionDistanceData";
			this.labelAphelionDistanceData.Size = new System.Drawing.Size(209, 20);
			this.labelAphelionDistanceData.TabIndex = 15;
			this.toolTip.SetToolTip(this.labelAphelionDistanceData, "Shows the information of \"Aphelion distance\"");
			this.labelAphelionDistanceData.Values.Text = "..................";
			this.labelAphelionDistanceData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelAphelionDistanceData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAphelionDistanceData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAphelionDistanceData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAphelionDistanceData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLongitudeDescendingNodeData
			// 
			this.labelLongitudeDescendingNodeData.AccessibleDescription = "Shows the information of \"Longitude of descending node\"";
			this.labelLongitudeDescendingNodeData.AccessibleName = "Shows the information of \"Longitude of descending node\"";
			this.labelLongitudeDescendingNodeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLongitudeDescendingNodeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeDescendingNodeData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLongitudeDescendingNodeData.Location = new System.Drawing.Point(263, 211);
			this.labelLongitudeDescendingNodeData.Name = "labelLongitudeDescendingNodeData";
			this.labelLongitudeDescendingNodeData.Size = new System.Drawing.Size(209, 20);
			this.labelLongitudeDescendingNodeData.TabIndex = 17;
			this.toolTip.SetToolTip(this.labelLongitudeDescendingNodeData, "Shows the information of \"Longitude of descending node\"");
			this.labelLongitudeDescendingNodeData.Values.Text = "..................";
			this.labelLongitudeDescendingNodeData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelLongitudeDescendingNodeData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNodeData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLongitudeDescendingNodeData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNodeData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelArgumentAphelionData
			// 
			this.labelArgumentAphelionData.AccessibleDescription = "Shows the information of \"Argument of aphelion\"";
			this.labelArgumentAphelionData.AccessibleName = "Shows the information of \"Argument of aphelion\"";
			this.labelArgumentAphelionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelArgumentAphelionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentAphelionData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelArgumentAphelionData.Location = new System.Drawing.Point(263, 237);
			this.labelArgumentAphelionData.Name = "labelArgumentAphelionData";
			this.labelArgumentAphelionData.Size = new System.Drawing.Size(209, 20);
			this.labelArgumentAphelionData.TabIndex = 19;
			this.toolTip.SetToolTip(this.labelArgumentAphelionData, "Shows the information of \"Argument of aphelion\"");
			this.labelArgumentAphelionData.Values.Text = "..................";
			this.labelArgumentAphelionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelArgumentAphelionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelArgumentAphelionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelFocalParameterData
			// 
			this.labelFocalParameterData.AccessibleDescription = "Shows the information of \"Focal parameter\"";
			this.labelFocalParameterData.AccessibleName = "Shows the information of \"Focal parameter\"";
			this.labelFocalParameterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFocalParameterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFocalParameterData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFocalParameterData.Location = new System.Drawing.Point(263, 263);
			this.labelFocalParameterData.Name = "labelFocalParameterData";
			this.labelFocalParameterData.Size = new System.Drawing.Size(209, 20);
			this.labelFocalParameterData.TabIndex = 21;
			this.toolTip.SetToolTip(this.labelFocalParameterData, "Shows the information of \"Focal parameter\"");
			this.labelFocalParameterData.Values.Text = "..................";
			this.labelFocalParameterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelFocalParameterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelFocalParameterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiLatusRectumData
			// 
			this.labelSemiLatusRectumData.AccessibleDescription = "Shows the information of \"Semi-latus rectum\"";
			this.labelSemiLatusRectumData.AccessibleName = "Shows the information of \"Semi-latus rectum\"";
			this.labelSemiLatusRectumData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiLatusRectumData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiLatusRectumData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSemiLatusRectumData.Location = new System.Drawing.Point(263, 289);
			this.labelSemiLatusRectumData.Name = "labelSemiLatusRectumData";
			this.labelSemiLatusRectumData.Size = new System.Drawing.Size(209, 20);
			this.labelSemiLatusRectumData.TabIndex = 23;
			this.toolTip.SetToolTip(this.labelSemiLatusRectumData, "Shows the information of \"Semi-latus rectum\"");
			this.labelSemiLatusRectumData.Values.Text = "..................";
			this.labelSemiLatusRectumData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSemiLatusRectumData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectumData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiLatusRectumData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectumData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLatusRectumData
			// 
			this.labelLatusRectumData.AccessibleDescription = "Shows the information of \"Latus rectum\"";
			this.labelLatusRectumData.AccessibleName = "Shows the information of \"Latus rectum\"";
			this.labelLatusRectumData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLatusRectumData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLatusRectumData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLatusRectumData.Location = new System.Drawing.Point(263, 315);
			this.labelLatusRectumData.Name = "labelLatusRectumData";
			this.labelLatusRectumData.Size = new System.Drawing.Size(209, 20);
			this.labelLatusRectumData.TabIndex = 25;
			this.toolTip.SetToolTip(this.labelLatusRectumData, "Shows the information of \"Latus rectum\"");
			this.labelLatusRectumData.Values.Text = "..................";
			this.labelLatusRectumData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelLatusRectumData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectumData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLatusRectumData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectumData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPeriodData
			// 
			this.labelPeriodData.AccessibleDescription = "Shows the information of \"Period\"";
			this.labelPeriodData.AccessibleName = "Shows the information of \"Period\"";
			this.labelPeriodData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPeriodData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPeriodData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPeriodData.Location = new System.Drawing.Point(263, 341);
			this.labelPeriodData.Name = "labelPeriodData";
			this.labelPeriodData.Size = new System.Drawing.Size(209, 20);
			this.labelPeriodData.TabIndex = 27;
			this.toolTip.SetToolTip(this.labelPeriodData, "Shows the information of \"Period\"");
			this.labelPeriodData.Values.Text = "..................";
			this.labelPeriodData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelPeriodData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPeriodData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPeriodData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPeriodData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalAreaDesc
			// 
			this.labelOrbitalAreaDesc.AccessibleDescription = "Orbital area (AU²)";
			this.labelOrbitalAreaDesc.AccessibleName = "Orbital area (AU²)";
			this.labelOrbitalAreaDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalAreaDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalAreaDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelOrbitalAreaDesc.Location = new System.Drawing.Point(3, 367);
			this.labelOrbitalAreaDesc.Name = "labelOrbitalAreaDesc";
			this.labelOrbitalAreaDesc.Size = new System.Drawing.Size(254, 20);
			this.labelOrbitalAreaDesc.TabIndex = 28;
			this.toolTip.SetToolTip(this.labelOrbitalAreaDesc, "Orbital area (AU²)");
			this.labelOrbitalAreaDesc.Values.ExtraText = "AU²";
			this.labelOrbitalAreaDesc.Values.Text = "Orbital area";
			this.labelOrbitalAreaDesc.DoubleClick += new System.EventHandler(this.LabelOrbitalAreaDesc_DoubleClick);
			this.labelOrbitalAreaDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalAreaDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalAreaDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalAreaDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalPerimeterDesc
			// 
			this.labelOrbitalPerimeterDesc.AccessibleDescription = "Orbital perimeter (AU)";
			this.labelOrbitalPerimeterDesc.AccessibleName = "Orbital perimeter (AU)";
			this.labelOrbitalPerimeterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalPerimeterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalPerimeterDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelOrbitalPerimeterDesc.Location = new System.Drawing.Point(3, 393);
			this.labelOrbitalPerimeterDesc.Name = "labelOrbitalPerimeterDesc";
			this.labelOrbitalPerimeterDesc.Size = new System.Drawing.Size(254, 20);
			this.labelOrbitalPerimeterDesc.TabIndex = 30;
			this.toolTip.SetToolTip(this.labelOrbitalPerimeterDesc, "Orbital perimeter (AU)");
			this.labelOrbitalPerimeterDesc.Values.ExtraText = "AU";
			this.labelOrbitalPerimeterDesc.Values.Text = "Orbital perimeter";
			this.labelOrbitalPerimeterDesc.DoubleClick += new System.EventHandler(this.LabelOrbitalPerimeterDesc_DoubleClick);
			this.labelOrbitalPerimeterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalPerimeterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMeanAxisDesc
			// 
			this.labelSemiMeanAxisDesc.AccessibleDescription = "Semi-mean axis (AU)";
			this.labelSemiMeanAxisDesc.AccessibleName = "Semi-mean axis (AU)";
			this.labelSemiMeanAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMeanAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMeanAxisDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelSemiMeanAxisDesc.Location = new System.Drawing.Point(3, 419);
			this.labelSemiMeanAxisDesc.Name = "labelSemiMeanAxisDesc";
			this.labelSemiMeanAxisDesc.Size = new System.Drawing.Size(254, 20);
			this.labelSemiMeanAxisDesc.TabIndex = 32;
			this.toolTip.SetToolTip(this.labelSemiMeanAxisDesc, "Semi-mean axis (AU)");
			this.labelSemiMeanAxisDesc.Values.ExtraText = "AU";
			this.labelSemiMeanAxisDesc.Values.Text = "Semi-mean axis";
			this.labelSemiMeanAxisDesc.DoubleClick += new System.EventHandler(this.LabelSemiMeanAxisDesc_DoubleClick);
			this.labelSemiMeanAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMeanAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanAxisDesc
			// 
			this.labelMeanAxisDesc.AccessibleDescription = "Mean axis (AU)";
			this.labelMeanAxisDesc.AccessibleName = "Mean axis (AU)";
			this.labelMeanAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAxisDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelMeanAxisDesc.Location = new System.Drawing.Point(3, 445);
			this.labelMeanAxisDesc.Name = "labelMeanAxisDesc";
			this.labelMeanAxisDesc.Size = new System.Drawing.Size(254, 20);
			this.labelMeanAxisDesc.TabIndex = 34;
			this.toolTip.SetToolTip(this.labelMeanAxisDesc, "Mean axis (AU)");
			this.labelMeanAxisDesc.Values.ExtraText = "AU";
			this.labelMeanAxisDesc.Values.Text = "Mean axis";
			this.labelMeanAxisDesc.DoubleClick += new System.EventHandler(this.LabelMeanAxisDesc_DoubleClick);
			this.labelMeanAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalAreaData
			// 
			this.labelOrbitalAreaData.AccessibleDescription = "Shows the information of \"Orbital area\"";
			this.labelOrbitalAreaData.AccessibleName = "Shows the information of \"Orbital area\"";
			this.labelOrbitalAreaData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalAreaData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalAreaData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelOrbitalAreaData.Location = new System.Drawing.Point(263, 367);
			this.labelOrbitalAreaData.Name = "labelOrbitalAreaData";
			this.labelOrbitalAreaData.Size = new System.Drawing.Size(209, 20);
			this.labelOrbitalAreaData.TabIndex = 29;
			this.toolTip.SetToolTip(this.labelOrbitalAreaData, "Shows the information of \"Orbital area\"");
			this.labelOrbitalAreaData.Values.Text = "..................";
			this.labelOrbitalAreaData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelOrbitalAreaData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalAreaData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalAreaData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalAreaData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalPerimeterData
			// 
			this.labelOrbitalPerimeterData.AccessibleDescription = "Shows the information of \"Orbital perimeter\"";
			this.labelOrbitalPerimeterData.AccessibleName = "Shows the information of \"Orbital perimeter\"";
			this.labelOrbitalPerimeterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalPerimeterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalPerimeterData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelOrbitalPerimeterData.Location = new System.Drawing.Point(263, 393);
			this.labelOrbitalPerimeterData.Name = "labelOrbitalPerimeterData";
			this.labelOrbitalPerimeterData.Size = new System.Drawing.Size(209, 20);
			this.labelOrbitalPerimeterData.TabIndex = 31;
			this.toolTip.SetToolTip(this.labelOrbitalPerimeterData, "Shows the information of \"Orbital perimeter\"");
			this.labelOrbitalPerimeterData.Values.Text = "..................";
			this.labelOrbitalPerimeterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelOrbitalPerimeterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalPerimeterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMeanAxisData
			// 
			this.labelSemiMeanAxisData.AccessibleDescription = "Shows the information of \"Semi-mean axis\"";
			this.labelSemiMeanAxisData.AccessibleName = "Shows the information of \"Semi-mean axis\"";
			this.labelSemiMeanAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMeanAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMeanAxisData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelSemiMeanAxisData.Location = new System.Drawing.Point(263, 419);
			this.labelSemiMeanAxisData.Name = "labelSemiMeanAxisData";
			this.labelSemiMeanAxisData.Size = new System.Drawing.Size(209, 20);
			this.labelSemiMeanAxisData.TabIndex = 33;
			this.toolTip.SetToolTip(this.labelSemiMeanAxisData, "Shows the information of \"Semi-mean axis\"");
			this.labelSemiMeanAxisData.Values.Text = "..................";
			this.labelSemiMeanAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelSemiMeanAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMeanAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelStandardGravitationalParameterDesc
			// 
			this.labelStandardGravitationalParameterDesc.AccessibleDescription = "Standard gravitational parameter (AU³/a²)";
			this.labelStandardGravitationalParameterDesc.AccessibleName = "Standard gravitational parameter (AU³/a²)";
			this.labelStandardGravitationalParameterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelStandardGravitationalParameterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStandardGravitationalParameterDesc.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			this.labelStandardGravitationalParameterDesc.Location = new System.Drawing.Point(3, 471);
			this.labelStandardGravitationalParameterDesc.Name = "labelStandardGravitationalParameterDesc";
			this.labelStandardGravitationalParameterDesc.Size = new System.Drawing.Size(254, 20);
			this.labelStandardGravitationalParameterDesc.TabIndex = 36;
			this.toolTip.SetToolTip(this.labelStandardGravitationalParameterDesc, "Standard gravitational parameter (AU³/a²)");
			this.labelStandardGravitationalParameterDesc.Values.ExtraText = "AU³/a²";
			this.labelStandardGravitationalParameterDesc.Values.Text = "Standard gravitational parameter";
			this.labelStandardGravitationalParameterDesc.DoubleClick += new System.EventHandler(this.LabelStandardGravitationalParameterDesc_DoubleClick);
			this.labelStandardGravitationalParameterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStandardGravitationalParameterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelStandardGravitationalParameterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStandardGravitationalParameterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanAxisData
			// 
			this.labelMeanAxisData.AccessibleDescription = "Shows the information of \"Mean axis\"";
			this.labelMeanAxisData.AccessibleName = "Shows the information of \"Mean axis\"";
			this.labelMeanAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAxisData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelMeanAxisData.Location = new System.Drawing.Point(263, 445);
			this.labelMeanAxisData.Name = "labelMeanAxisData";
			this.labelMeanAxisData.Size = new System.Drawing.Size(209, 20);
			this.labelMeanAxisData.TabIndex = 35;
			this.toolTip.SetToolTip(this.labelMeanAxisData, "Shows the information of \"Mean axis\"");
			this.labelMeanAxisData.Values.Text = "..................";
			this.labelMeanAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelMeanAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelStandardGravitationalParameterData
			// 
			this.labelStandardGravitationalParameterData.AccessibleDescription = "Shows the information of \"Standard gravitational parameter\"";
			this.labelStandardGravitationalParameterData.AccessibleName = "Shows the information of \"Standard gravitational parameter\"";
			this.labelStandardGravitationalParameterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelStandardGravitationalParameterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStandardGravitationalParameterData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelStandardGravitationalParameterData.Location = new System.Drawing.Point(263, 471);
			this.labelStandardGravitationalParameterData.Name = "labelStandardGravitationalParameterData";
			this.labelStandardGravitationalParameterData.Size = new System.Drawing.Size(209, 20);
			this.labelStandardGravitationalParameterData.TabIndex = 37;
			this.toolTip.SetToolTip(this.labelStandardGravitationalParameterData, "Shows the information of \"Standard gravitational parameter\"");
			this.labelStandardGravitationalParameterData.Values.Text = "..................";
			this.labelStandardGravitationalParameterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_DoubleClick);
			this.labelStandardGravitationalParameterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStandardGravitationalParameterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelStandardGravitationalParameterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelStandardGravitationalParameterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the data";
			this.tableLayoutPanel.AccessibleName = "Table pane";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.tableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel.BackgroundImage")));
			this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.75687F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.24313F));
			this.tableLayoutPanel.Controls.Add(this.labelLinearEccentricityData, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelLinearEccentricityDesc, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMinorAxisDesc, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelMajorAxisDesc, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelMinorAxisDesc, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.labelEccenctricAnomalyDesc, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.labelTrueAnomalyDesc, 0, 5);
			this.tableLayoutPanel.Controls.Add(this.labelPerihelionDistanceDesc, 0, 6);
			this.tableLayoutPanel.Controls.Add(this.LabelAphelionDistanceDesc, 0, 7);
			this.tableLayoutPanel.Controls.Add(this.labelLongitudeDescendingNodeDesc, 0, 8);
			this.tableLayoutPanel.Controls.Add(this.labelArgumentAphelionDesc, 0, 9);
			this.tableLayoutPanel.Controls.Add(this.labelFocalParameterDesc, 0, 10);
			this.tableLayoutPanel.Controls.Add(this.labelSemiLatusRectumDesc, 0, 11);
			this.tableLayoutPanel.Controls.Add(this.labelLatusRectumDesc, 0, 12);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalPeriodDesc, 0, 13);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMinorAxisData, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelMajorAxisData, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelMinorAxisData, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.labelEccentricAnomalyData, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.labelTrueAnomalyData, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.labelPerihelionDistanceData, 1, 6);
			this.tableLayoutPanel.Controls.Add(this.labelAphelionDistanceData, 1, 7);
			this.tableLayoutPanel.Controls.Add(this.labelLongitudeDescendingNodeData, 1, 8);
			this.tableLayoutPanel.Controls.Add(this.labelArgumentAphelionData, 1, 9);
			this.tableLayoutPanel.Controls.Add(this.labelFocalParameterData, 1, 10);
			this.tableLayoutPanel.Controls.Add(this.labelSemiLatusRectumData, 1, 11);
			this.tableLayoutPanel.Controls.Add(this.labelLatusRectumData, 1, 12);
			this.tableLayoutPanel.Controls.Add(this.labelPeriodData, 1, 13);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalAreaDesc, 0, 14);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalPerimeterDesc, 0, 15);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMeanAxisDesc, 0, 16);
			this.tableLayoutPanel.Controls.Add(this.labelMeanAxisDesc, 0, 17);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalAreaData, 1, 14);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalPerimeterData, 1, 15);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMeanAxisData, 1, 16);
			this.tableLayoutPanel.Controls.Add(this.labelMeanAxisData, 1, 17);
			this.tableLayoutPanel.Controls.Add(this.labelStandardGravitationalParameterData, 1, 18);
			this.tableLayoutPanel.Controls.Add(this.labelStandardGravitationalParameterDesc, 0, 18);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.tableLayoutPanel.RowCount = 19;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(475, 471);
			this.tableLayoutPanel.TabIndex = 0;
			this.tableLayoutPanel.TabStop = true;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(475, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "status bar";
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
			this.labelInformation.Size = new System.Drawing.Size(144, 17);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Shows some information";
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Container to arrange the toolbars";
			this.toolStripContainer.AccessibleName = "Container to arrange the toolbars";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(475, 471);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(475, 518);
			this.toolStripContainer.TabIndex = 3;
			this.toolStripContainer.Text = "toolStripContainer";
			this.toolTip.SetToolTip(this.toolStripContainer, "Container to arrange the toolbars");
			// 
			// DerivatedOrbitElementsForm
			// 
			this.AccessibleDescription = "Calculates some derivated orbit elements";
			this.AccessibleName = "Derivated orbit elements";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 518);
			this.Controls.Add(this.toolStripContainer);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DerivatedOrbitElementsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Derivated orbit elements";
			this.toolTip.SetToolTip(this, "Derivated orbit elements");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DerivatedOrbitElementsForm_FormClosed);
			this.Load += new System.EventHandler(this.DerivatedOrbitElementsForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolTip toolTip;
		private KryptonTableLayoutPanel tableLayoutPanel;
		private KryptonLabel labelLinearEccentricityData;
		private KryptonLabel labelLinearEccentricityDesc;
		private KryptonLabel labelSemiMinorAxisDesc;
		private KryptonLabel labelMajorAxisDesc;
		private KryptonLabel labelTrueAnomalyDesc;
		private KryptonLabel labelPerihelionDistanceDesc;
		private KryptonLabel LabelAphelionDistanceDesc;
		private KryptonLabel labelLongitudeDescendingNodeDesc;
		private KryptonLabel labelArgumentAphelionDesc;
		private KryptonLabel labelFocalParameterDesc;
		private KryptonLabel labelSemiLatusRectumDesc;
		private KryptonLabel labelLatusRectumDesc;
		private KryptonLabel labelOrbitalPeriodDesc;
		private KryptonLabel labelMinorAxisDesc;
		private KryptonLabel labelEccenctricAnomalyDesc;
		private KryptonLabel labelPeriodData;
		private KryptonLabel labelSemiMinorAxisData;
		private KryptonLabel labelMajorAxisData;
		private KryptonLabel labelMinorAxisData;
		private KryptonLabel labelEccentricAnomalyData;
		private KryptonLabel labelTrueAnomalyData;
		private KryptonLabel labelPerihelionDistanceData;
		private KryptonLabel labelAphelionDistanceData;
		private KryptonLabel labelLongitudeDescendingNodeData;
		private KryptonLabel labelArgumentAphelionData;
		private KryptonLabel labelFocalParameterData;
		private KryptonLabel labelSemiLatusRectumData;
		private KryptonLabel labelLatusRectumData;
		private KryptonLabel labelOrbitalAreaDesc;
		private KryptonLabel labelOrbitalPerimeterDesc;
		private KryptonLabel labelSemiMeanAxisDesc;
		private KryptonLabel labelMeanAxisDesc;
		private KryptonLabel labelOrbitalAreaData;
		private KryptonLabel labelOrbitalPerimeterData;
		private KryptonLabel labelSemiMeanAxisData;
		private KryptonLabel labelMeanAxisData;
		private KryptonLabel labelStandardGravitationalParameterData;
		private KryptonLabel labelStandardGravitationalParameterDesc;
		private KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
	}
}