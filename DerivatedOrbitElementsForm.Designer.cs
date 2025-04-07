﻿using Krypton.Toolkit;

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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DerivatedOrbitElementsForm));
			toolTip = new ToolTip(components);
			labelLinearEccentricityDesc = new KryptonLabel();
			labelLinearEccentricityData = new KryptonLabel();
			labelSemiMinorAxisDesc = new KryptonLabel();
			labelMajorAxisDesc = new KryptonLabel();
			labelMinorAxisDesc = new KryptonLabel();
			labelEccenctricAnomalyDesc = new KryptonLabel();
			labelTrueAnomalyDesc = new KryptonLabel();
			labelPerihelionDistanceDesc = new KryptonLabel();
			LabelAphelionDistanceDesc = new KryptonLabel();
			labelLongitudeDescendingNodeDesc = new KryptonLabel();
			labelArgumentAphelionDesc = new KryptonLabel();
			labelFocalParameterDesc = new KryptonLabel();
			labelSemiLatusRectumDesc = new KryptonLabel();
			labelLatusRectumDesc = new KryptonLabel();
			labelOrbitalPeriodDesc = new KryptonLabel();
			labelSemiMinorAxisData = new KryptonLabel();
			labelMajorAxisData = new KryptonLabel();
			labelMinorAxisData = new KryptonLabel();
			labelEccentricAnomalyData = new KryptonLabel();
			labelTrueAnomalyData = new KryptonLabel();
			labelPerihelionDistanceData = new KryptonLabel();
			labelAphelionDistanceData = new KryptonLabel();
			labelLongitudeDescendingNodeData = new KryptonLabel();
			labelArgumentAphelionData = new KryptonLabel();
			labelFocalParameterData = new KryptonLabel();
			labelSemiLatusRectumData = new KryptonLabel();
			labelLatusRectumData = new KryptonLabel();
			labelPeriodData = new KryptonLabel();
			labelOrbitalAreaDesc = new KryptonLabel();
			labelOrbitalPerimeterDesc = new KryptonLabel();
			labelSemiMeanAxisDesc = new KryptonLabel();
			labelMeanAxisDesc = new KryptonLabel();
			labelOrbitalAreaData = new KryptonLabel();
			labelOrbitalPerimeterData = new KryptonLabel();
			labelSemiMeanAxisData = new KryptonLabel();
			labelStandardGravitationalParameterDesc = new KryptonLabel();
			labelMeanAxisData = new KryptonLabel();
			labelStandardGravitationalParameterData = new KryptonLabel();
			toolStripContainer = new ToolStripContainer();
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			tableLayoutPanel = new KryptonTableLayoutPanel();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			statusStrip.SuspendLayout();
			tableLayoutPanel.SuspendLayout();
			SuspendLayout();
			// 
			// labelLinearEccentricityDesc
			// 
			labelLinearEccentricityDesc.AccessibleDescription = "Linear eccentricity (AU)";
			labelLinearEccentricityDesc.AccessibleName = "Linear eccentricity (AU)";
			labelLinearEccentricityDesc.AccessibleRole = AccessibleRole.StaticText;
			labelLinearEccentricityDesc.Dock = DockStyle.Fill;
			labelLinearEccentricityDesc.LabelStyle = LabelStyle.BoldPanel;
			labelLinearEccentricityDesc.Location = new Point(3, 3);
			labelLinearEccentricityDesc.Name = "labelLinearEccentricityDesc";
			labelLinearEccentricityDesc.Size = new Size(254, 20);
			labelLinearEccentricityDesc.TabIndex = 0;
			toolTip.SetToolTip(labelLinearEccentricityDesc, "Linear eccentricity (AU)");
			labelLinearEccentricityDesc.Values.ExtraText = "AU";
			labelLinearEccentricityDesc.Values.Text = "Linear eccentricity";
			labelLinearEccentricityDesc.DoubleClick += LabelLinearEccentricityDesc_DoubleClick;
			labelLinearEccentricityDesc.Enter += SetStatusbar_Enter;
			labelLinearEccentricityDesc.Leave += ClearStatusbar_Leave;
			labelLinearEccentricityDesc.MouseEnter += SetStatusbar_Enter;
			labelLinearEccentricityDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLinearEccentricityData
			// 
			labelLinearEccentricityData.AccessibleDescription = "Shows the information of \"Linear eccentricity\"";
			labelLinearEccentricityData.AccessibleName = "Shows the information of \"Linear eccentricity\"";
			labelLinearEccentricityData.AccessibleRole = AccessibleRole.StaticText;
			labelLinearEccentricityData.Dock = DockStyle.Fill;
			labelLinearEccentricityData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelLinearEccentricityData.Location = new Point(263, 3);
			labelLinearEccentricityData.Name = "labelLinearEccentricityData";
			labelLinearEccentricityData.Size = new Size(209, 20);
			labelLinearEccentricityData.TabIndex = 1;
			toolTip.SetToolTip(labelLinearEccentricityData, "Shows the information of \"Linear eccentricity\"");
			labelLinearEccentricityData.Values.Text = "..................";
			labelLinearEccentricityData.DoubleClick += CopyToClipboard_DoubleClick;
			labelLinearEccentricityData.Enter += SetStatusbar_Enter;
			labelLinearEccentricityData.Leave += ClearStatusbar_Leave;
			labelLinearEccentricityData.MouseEnter += SetStatusbar_Enter;
			labelLinearEccentricityData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiMinorAxisDesc
			// 
			labelSemiMinorAxisDesc.AccessibleDescription = "Semi-minor axis (AU)";
			labelSemiMinorAxisDesc.AccessibleName = "Semi-minor axis (AU)";
			labelSemiMinorAxisDesc.AccessibleRole = AccessibleRole.StaticText;
			labelSemiMinorAxisDesc.Dock = DockStyle.Fill;
			labelSemiMinorAxisDesc.LabelStyle = LabelStyle.BoldPanel;
			labelSemiMinorAxisDesc.Location = new Point(3, 29);
			labelSemiMinorAxisDesc.Name = "labelSemiMinorAxisDesc";
			labelSemiMinorAxisDesc.Size = new Size(254, 20);
			labelSemiMinorAxisDesc.TabIndex = 2;
			toolTip.SetToolTip(labelSemiMinorAxisDesc, "Semi-minor axis (AU)");
			labelSemiMinorAxisDesc.Values.ExtraText = "AU";
			labelSemiMinorAxisDesc.Values.Text = "Semi-minor axis";
			labelSemiMinorAxisDesc.DoubleClick += LabelSemiMinorAxisDesc_DoubleClick;
			labelSemiMinorAxisDesc.Enter += SetStatusbar_Enter;
			labelSemiMinorAxisDesc.Leave += ClearStatusbar_Leave;
			labelSemiMinorAxisDesc.MouseEnter += SetStatusbar_Enter;
			labelSemiMinorAxisDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMajorAxisDesc
			// 
			labelMajorAxisDesc.AccessibleDescription = "Major axis (AU)";
			labelMajorAxisDesc.AccessibleName = "Major axis (AU)";
			labelMajorAxisDesc.AccessibleRole = AccessibleRole.StaticText;
			labelMajorAxisDesc.Dock = DockStyle.Fill;
			labelMajorAxisDesc.LabelStyle = LabelStyle.BoldPanel;
			labelMajorAxisDesc.Location = new Point(3, 55);
			labelMajorAxisDesc.Name = "labelMajorAxisDesc";
			labelMajorAxisDesc.Size = new Size(254, 20);
			labelMajorAxisDesc.TabIndex = 4;
			toolTip.SetToolTip(labelMajorAxisDesc, "Major axis (AU)");
			labelMajorAxisDesc.Values.ExtraText = "AU";
			labelMajorAxisDesc.Values.Text = "Major axis";
			labelMajorAxisDesc.DoubleClick += LabelMajorAxisDesc_DoubleClick;
			labelMajorAxisDesc.Enter += SetStatusbar_Enter;
			labelMajorAxisDesc.Leave += ClearStatusbar_Leave;
			labelMajorAxisDesc.MouseEnter += SetStatusbar_Enter;
			labelMajorAxisDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMinorAxisDesc
			// 
			labelMinorAxisDesc.AccessibleDescription = "Minor axis (AU)";
			labelMinorAxisDesc.AccessibleName = "Minor axis (AU)";
			labelMinorAxisDesc.AccessibleRole = AccessibleRole.StaticText;
			labelMinorAxisDesc.Dock = DockStyle.Fill;
			labelMinorAxisDesc.LabelStyle = LabelStyle.BoldPanel;
			labelMinorAxisDesc.Location = new Point(3, 81);
			labelMinorAxisDesc.Name = "labelMinorAxisDesc";
			labelMinorAxisDesc.Size = new Size(254, 20);
			labelMinorAxisDesc.TabIndex = 6;
			toolTip.SetToolTip(labelMinorAxisDesc, "Minor axis (AU)");
			labelMinorAxisDesc.Values.ExtraText = "AU";
			labelMinorAxisDesc.Values.Text = "Minor axis";
			labelMinorAxisDesc.DoubleClick += LabelMinorAxisDesc_DoubleClick;
			labelMinorAxisDesc.Enter += SetStatusbar_Enter;
			labelMinorAxisDesc.Leave += ClearStatusbar_Leave;
			labelMinorAxisDesc.MouseEnter += SetStatusbar_Enter;
			labelMinorAxisDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelEccenctricAnomalyDesc
			// 
			labelEccenctricAnomalyDesc.AccessibleDescription = "Eccentric anomaly (degrees)";
			labelEccenctricAnomalyDesc.AccessibleName = "Eccentric anomaly (degrees)";
			labelEccenctricAnomalyDesc.AccessibleRole = AccessibleRole.StaticText;
			labelEccenctricAnomalyDesc.Dock = DockStyle.Fill;
			labelEccenctricAnomalyDesc.LabelStyle = LabelStyle.BoldPanel;
			labelEccenctricAnomalyDesc.Location = new Point(3, 107);
			labelEccenctricAnomalyDesc.Name = "labelEccenctricAnomalyDesc";
			labelEccenctricAnomalyDesc.Size = new Size(254, 20);
			labelEccenctricAnomalyDesc.TabIndex = 8;
			toolTip.SetToolTip(labelEccenctricAnomalyDesc, "Eccentric anomaly (°)");
			labelEccenctricAnomalyDesc.Values.ExtraText = "°";
			labelEccenctricAnomalyDesc.Values.Text = "Eccentric anomaly";
			labelEccenctricAnomalyDesc.DoubleClick += LabelEccenctricAnomalyDesc_DoubleClick;
			labelEccenctricAnomalyDesc.Enter += SetStatusbar_Enter;
			labelEccenctricAnomalyDesc.Leave += ClearStatusbar_Leave;
			labelEccenctricAnomalyDesc.MouseEnter += SetStatusbar_Enter;
			labelEccenctricAnomalyDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelTrueAnomalyDesc
			// 
			labelTrueAnomalyDesc.AccessibleDescription = "True anomaly (degrees)";
			labelTrueAnomalyDesc.AccessibleName = "True anomaly (degrees)";
			labelTrueAnomalyDesc.AccessibleRole = AccessibleRole.StaticText;
			labelTrueAnomalyDesc.Dock = DockStyle.Fill;
			labelTrueAnomalyDesc.LabelStyle = LabelStyle.BoldPanel;
			labelTrueAnomalyDesc.Location = new Point(3, 133);
			labelTrueAnomalyDesc.Name = "labelTrueAnomalyDesc";
			labelTrueAnomalyDesc.Size = new Size(254, 20);
			labelTrueAnomalyDesc.TabIndex = 10;
			toolTip.SetToolTip(labelTrueAnomalyDesc, "True anomaly (°)");
			labelTrueAnomalyDesc.Values.ExtraText = "°";
			labelTrueAnomalyDesc.Values.Text = "True anomaly";
			labelTrueAnomalyDesc.DoubleClick += LabelTrueAnomalyDesc_DoubleClick;
			labelTrueAnomalyDesc.Enter += SetStatusbar_Enter;
			labelTrueAnomalyDesc.Leave += ClearStatusbar_Leave;
			labelTrueAnomalyDesc.MouseEnter += SetStatusbar_Enter;
			labelTrueAnomalyDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPerihelionDistanceDesc
			// 
			labelPerihelionDistanceDesc.AccessibleDescription = "Perihelion distance (AU)";
			labelPerihelionDistanceDesc.AccessibleName = "Perihelion distance (AU)";
			labelPerihelionDistanceDesc.AccessibleRole = AccessibleRole.StaticText;
			labelPerihelionDistanceDesc.Dock = DockStyle.Fill;
			labelPerihelionDistanceDesc.LabelStyle = LabelStyle.BoldPanel;
			labelPerihelionDistanceDesc.Location = new Point(3, 159);
			labelPerihelionDistanceDesc.Name = "labelPerihelionDistanceDesc";
			labelPerihelionDistanceDesc.Size = new Size(254, 20);
			labelPerihelionDistanceDesc.TabIndex = 12;
			toolTip.SetToolTip(labelPerihelionDistanceDesc, "Perihelion distance (AU)");
			labelPerihelionDistanceDesc.Values.ExtraText = "AU";
			labelPerihelionDistanceDesc.Values.Text = "Perihelion distance";
			labelPerihelionDistanceDesc.DoubleClick += LabelPerihelionDistanceDesc_DoubleClick;
			labelPerihelionDistanceDesc.Enter += SetStatusbar_Enter;
			labelPerihelionDistanceDesc.Leave += ClearStatusbar_Leave;
			labelPerihelionDistanceDesc.MouseEnter += SetStatusbar_Enter;
			labelPerihelionDistanceDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// LabelAphelionDistanceDesc
			// 
			LabelAphelionDistanceDesc.AccessibleDescription = "Aphelion distance";
			LabelAphelionDistanceDesc.AccessibleName = "Aphelion distance";
			LabelAphelionDistanceDesc.AccessibleRole = AccessibleRole.StaticText;
			LabelAphelionDistanceDesc.Dock = DockStyle.Fill;
			LabelAphelionDistanceDesc.LabelStyle = LabelStyle.BoldPanel;
			LabelAphelionDistanceDesc.Location = new Point(3, 185);
			LabelAphelionDistanceDesc.Name = "LabelAphelionDistanceDesc";
			LabelAphelionDistanceDesc.Size = new Size(254, 20);
			LabelAphelionDistanceDesc.TabIndex = 14;
			toolTip.SetToolTip(LabelAphelionDistanceDesc, "Aphelion distance (AU)");
			LabelAphelionDistanceDesc.Values.ExtraText = "AU";
			LabelAphelionDistanceDesc.Values.Text = "Aphelion distance";
			LabelAphelionDistanceDesc.DoubleClick += LabelAphelionDistanceDesc_DoubleClick;
			LabelAphelionDistanceDesc.Enter += SetStatusbar_Enter;
			LabelAphelionDistanceDesc.Leave += ClearStatusbar_Leave;
			LabelAphelionDistanceDesc.MouseEnter += SetStatusbar_Enter;
			LabelAphelionDistanceDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLongitudeDescendingNodeDesc
			// 
			labelLongitudeDescendingNodeDesc.AccessibleDescription = "Longitude of the descending node (degrees)";
			labelLongitudeDescendingNodeDesc.AccessibleName = "Longitude of the descending node (degrees)";
			labelLongitudeDescendingNodeDesc.AccessibleRole = AccessibleRole.StaticText;
			labelLongitudeDescendingNodeDesc.Dock = DockStyle.Fill;
			labelLongitudeDescendingNodeDesc.LabelStyle = LabelStyle.BoldPanel;
			labelLongitudeDescendingNodeDesc.Location = new Point(3, 211);
			labelLongitudeDescendingNodeDesc.Name = "labelLongitudeDescendingNodeDesc";
			labelLongitudeDescendingNodeDesc.Size = new Size(254, 20);
			labelLongitudeDescendingNodeDesc.TabIndex = 16;
			toolTip.SetToolTip(labelLongitudeDescendingNodeDesc, "Longitude of the descending node (°)");
			labelLongitudeDescendingNodeDesc.Values.ExtraText = "°";
			labelLongitudeDescendingNodeDesc.Values.Text = "Longitude of the descending node";
			labelLongitudeDescendingNodeDesc.DoubleClick += LabelLongitudeDescendingNodeDesc_DoubleClick;
			labelLongitudeDescendingNodeDesc.Enter += SetStatusbar_Enter;
			labelLongitudeDescendingNodeDesc.Leave += ClearStatusbar_Leave;
			labelLongitudeDescendingNodeDesc.MouseEnter += SetStatusbar_Enter;
			labelLongitudeDescendingNodeDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelArgumentAphelionDesc
			// 
			labelArgumentAphelionDesc.AccessibleDescription = "Argument of aphelion (degrees)";
			labelArgumentAphelionDesc.AccessibleName = "Argument of aphelion (degrees)";
			labelArgumentAphelionDesc.AccessibleRole = AccessibleRole.StaticText;
			labelArgumentAphelionDesc.Dock = DockStyle.Fill;
			labelArgumentAphelionDesc.LabelStyle = LabelStyle.BoldPanel;
			labelArgumentAphelionDesc.Location = new Point(3, 237);
			labelArgumentAphelionDesc.Name = "labelArgumentAphelionDesc";
			labelArgumentAphelionDesc.Size = new Size(254, 20);
			labelArgumentAphelionDesc.TabIndex = 18;
			toolTip.SetToolTip(labelArgumentAphelionDesc, "Argument of aphelion (°)");
			labelArgumentAphelionDesc.Values.ExtraText = "°";
			labelArgumentAphelionDesc.Values.Text = "Argument of aphelion";
			labelArgumentAphelionDesc.DoubleClick += LabelArgumentAphelionDesc_DoubleClick;
			labelArgumentAphelionDesc.Enter += SetStatusbar_Enter;
			labelArgumentAphelionDesc.Leave += ClearStatusbar_Leave;
			labelArgumentAphelionDesc.MouseEnter += SetStatusbar_Enter;
			labelArgumentAphelionDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelFocalParameterDesc
			// 
			labelFocalParameterDesc.AccessibleDescription = "Focal parameter";
			labelFocalParameterDesc.AccessibleName = "Focal parameter";
			labelFocalParameterDesc.AccessibleRole = AccessibleRole.StaticText;
			labelFocalParameterDesc.Dock = DockStyle.Fill;
			labelFocalParameterDesc.LabelStyle = LabelStyle.BoldPanel;
			labelFocalParameterDesc.Location = new Point(3, 263);
			labelFocalParameterDesc.Name = "labelFocalParameterDesc";
			labelFocalParameterDesc.Size = new Size(254, 20);
			labelFocalParameterDesc.TabIndex = 20;
			toolTip.SetToolTip(labelFocalParameterDesc, "Focal parameter");
			labelFocalParameterDesc.Values.ExtraText = "AU";
			labelFocalParameterDesc.Values.Text = "Focal parameter";
			labelFocalParameterDesc.DoubleClick += LabelFocalParameterDesc_DoubleClick;
			labelFocalParameterDesc.Enter += SetStatusbar_Enter;
			labelFocalParameterDesc.Leave += ClearStatusbar_Leave;
			labelFocalParameterDesc.MouseEnter += SetStatusbar_Enter;
			labelFocalParameterDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiLatusRectumDesc
			// 
			labelSemiLatusRectumDesc.AccessibleDescription = "Semi-latus rectum (AU)";
			labelSemiLatusRectumDesc.AccessibleName = "Semi-latus rectum (AU)";
			labelSemiLatusRectumDesc.AccessibleRole = AccessibleRole.StaticText;
			labelSemiLatusRectumDesc.Dock = DockStyle.Fill;
			labelSemiLatusRectumDesc.LabelStyle = LabelStyle.BoldPanel;
			labelSemiLatusRectumDesc.Location = new Point(3, 289);
			labelSemiLatusRectumDesc.Name = "labelSemiLatusRectumDesc";
			labelSemiLatusRectumDesc.Size = new Size(254, 20);
			labelSemiLatusRectumDesc.TabIndex = 22;
			toolTip.SetToolTip(labelSemiLatusRectumDesc, "Semi-latus rectum (AU)");
			labelSemiLatusRectumDesc.Values.ExtraText = "AU";
			labelSemiLatusRectumDesc.Values.Text = "Semi-latus rectum";
			labelSemiLatusRectumDesc.DoubleClick += LabelSemiLatusRectumDesc_DoubleClick;
			labelSemiLatusRectumDesc.Enter += SetStatusbar_Enter;
			labelSemiLatusRectumDesc.Leave += ClearStatusbar_Leave;
			labelSemiLatusRectumDesc.MouseEnter += SetStatusbar_Enter;
			labelSemiLatusRectumDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLatusRectumDesc
			// 
			labelLatusRectumDesc.AccessibleDescription = "Latus rectum (AU)";
			labelLatusRectumDesc.AccessibleName = "Latus rectum (AU)";
			labelLatusRectumDesc.AccessibleRole = AccessibleRole.StaticText;
			labelLatusRectumDesc.Dock = DockStyle.Fill;
			labelLatusRectumDesc.LabelStyle = LabelStyle.BoldPanel;
			labelLatusRectumDesc.Location = new Point(3, 315);
			labelLatusRectumDesc.Name = "labelLatusRectumDesc";
			labelLatusRectumDesc.Size = new Size(254, 20);
			labelLatusRectumDesc.TabIndex = 24;
			toolTip.SetToolTip(labelLatusRectumDesc, "Latus rectum (AU)");
			labelLatusRectumDesc.Values.ExtraText = "AU";
			labelLatusRectumDesc.Values.Text = "Latus rectum";
			labelLatusRectumDesc.DoubleClick += LabelLatusRectumDesc_DoubleClick;
			labelLatusRectumDesc.Enter += SetStatusbar_Enter;
			labelLatusRectumDesc.Leave += ClearStatusbar_Leave;
			labelLatusRectumDesc.MouseEnter += SetStatusbar_Enter;
			labelLatusRectumDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalPeriodDesc
			// 
			labelOrbitalPeriodDesc.AccessibleDescription = "Orbital period (years)";
			labelOrbitalPeriodDesc.AccessibleName = "Orbital period (years)";
			labelOrbitalPeriodDesc.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalPeriodDesc.Dock = DockStyle.Fill;
			labelOrbitalPeriodDesc.LabelStyle = LabelStyle.BoldPanel;
			labelOrbitalPeriodDesc.Location = new Point(3, 341);
			labelOrbitalPeriodDesc.Name = "labelOrbitalPeriodDesc";
			labelOrbitalPeriodDesc.Size = new Size(254, 20);
			labelOrbitalPeriodDesc.TabIndex = 26;
			toolTip.SetToolTip(labelOrbitalPeriodDesc, "Orbital Period (years)");
			labelOrbitalPeriodDesc.Values.ExtraText = "years";
			labelOrbitalPeriodDesc.Values.Text = "Orbital period";
			labelOrbitalPeriodDesc.DoubleClick += LabelOrbitalPeriodDesc_DoubleClick;
			labelOrbitalPeriodDesc.Enter += SetStatusbar_Enter;
			labelOrbitalPeriodDesc.Leave += ClearStatusbar_Leave;
			labelOrbitalPeriodDesc.MouseEnter += SetStatusbar_Enter;
			labelOrbitalPeriodDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiMinorAxisData
			// 
			labelSemiMinorAxisData.AccessibleDescription = "Shows the information of \"Semi-minor axis\"";
			labelSemiMinorAxisData.AccessibleName = "Shows the information of \"Semi-minor axis\"";
			labelSemiMinorAxisData.AccessibleRole = AccessibleRole.StaticText;
			labelSemiMinorAxisData.Dock = DockStyle.Fill;
			labelSemiMinorAxisData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelSemiMinorAxisData.Location = new Point(263, 29);
			labelSemiMinorAxisData.Name = "labelSemiMinorAxisData";
			labelSemiMinorAxisData.Size = new Size(209, 20);
			labelSemiMinorAxisData.TabIndex = 3;
			toolTip.SetToolTip(labelSemiMinorAxisData, "Shows the information of \"Semi-minor axis\"");
			labelSemiMinorAxisData.Values.Text = "..................";
			labelSemiMinorAxisData.DoubleClick += CopyToClipboard_DoubleClick;
			labelSemiMinorAxisData.Enter += SetStatusbar_Enter;
			labelSemiMinorAxisData.Leave += ClearStatusbar_Leave;
			labelSemiMinorAxisData.MouseEnter += SetStatusbar_Enter;
			labelSemiMinorAxisData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMajorAxisData
			// 
			labelMajorAxisData.AccessibleDescription = "Shows the information of \"Major axis\"";
			labelMajorAxisData.AccessibleName = "Shows the information of \"Major axis\"";
			labelMajorAxisData.AccessibleRole = AccessibleRole.StaticText;
			labelMajorAxisData.Dock = DockStyle.Fill;
			labelMajorAxisData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelMajorAxisData.Location = new Point(263, 55);
			labelMajorAxisData.Name = "labelMajorAxisData";
			labelMajorAxisData.Size = new Size(209, 20);
			labelMajorAxisData.TabIndex = 5;
			toolTip.SetToolTip(labelMajorAxisData, "Shows the information of \"Major axis\"");
			labelMajorAxisData.Values.Text = "..................";
			labelMajorAxisData.DoubleClick += CopyToClipboard_DoubleClick;
			labelMajorAxisData.Enter += SetStatusbar_Enter;
			labelMajorAxisData.Leave += ClearStatusbar_Leave;
			labelMajorAxisData.MouseEnter += SetStatusbar_Enter;
			labelMajorAxisData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMinorAxisData
			// 
			labelMinorAxisData.AccessibleDescription = "Shows the information of \"Minor axis\"";
			labelMinorAxisData.AccessibleName = "Shows the information of \"Minor axis\"";
			labelMinorAxisData.AccessibleRole = AccessibleRole.StaticText;
			labelMinorAxisData.Dock = DockStyle.Fill;
			labelMinorAxisData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelMinorAxisData.Location = new Point(263, 81);
			labelMinorAxisData.Name = "labelMinorAxisData";
			labelMinorAxisData.Size = new Size(209, 20);
			labelMinorAxisData.TabIndex = 7;
			toolTip.SetToolTip(labelMinorAxisData, "Shows the information of \"Minor axis\"");
			labelMinorAxisData.Values.Text = "..................";
			labelMinorAxisData.DoubleClick += CopyToClipboard_DoubleClick;
			labelMinorAxisData.Enter += SetStatusbar_Enter;
			labelMinorAxisData.Leave += ClearStatusbar_Leave;
			labelMinorAxisData.MouseEnter += SetStatusbar_Enter;
			labelMinorAxisData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelEccentricAnomalyData
			// 
			labelEccentricAnomalyData.AccessibleDescription = "Shows the information of \"Eccentric anomaly\"";
			labelEccentricAnomalyData.AccessibleName = "Shows the information of \"Eccentric anomaly\"";
			labelEccentricAnomalyData.AccessibleRole = AccessibleRole.StaticText;
			labelEccentricAnomalyData.Dock = DockStyle.Fill;
			labelEccentricAnomalyData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelEccentricAnomalyData.Location = new Point(263, 107);
			labelEccentricAnomalyData.Name = "labelEccentricAnomalyData";
			labelEccentricAnomalyData.Size = new Size(209, 20);
			labelEccentricAnomalyData.TabIndex = 9;
			toolTip.SetToolTip(labelEccentricAnomalyData, "Shows the information of \"Eccentric anomaly\"");
			labelEccentricAnomalyData.Values.Text = "..................";
			labelEccentricAnomalyData.DoubleClick += CopyToClipboard_DoubleClick;
			labelEccentricAnomalyData.Enter += SetStatusbar_Enter;
			labelEccentricAnomalyData.Leave += ClearStatusbar_Leave;
			labelEccentricAnomalyData.MouseEnter += SetStatusbar_Enter;
			labelEccentricAnomalyData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelTrueAnomalyData
			// 
			labelTrueAnomalyData.AccessibleDescription = "Shows the information of \"True anomaly\"";
			labelTrueAnomalyData.AccessibleName = "Shows the information of \"True anomaly\"";
			labelTrueAnomalyData.AccessibleRole = AccessibleRole.StaticText;
			labelTrueAnomalyData.Dock = DockStyle.Fill;
			labelTrueAnomalyData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelTrueAnomalyData.Location = new Point(263, 133);
			labelTrueAnomalyData.Name = "labelTrueAnomalyData";
			labelTrueAnomalyData.Size = new Size(209, 20);
			labelTrueAnomalyData.TabIndex = 11;
			toolTip.SetToolTip(labelTrueAnomalyData, "Shows the information of \"True anomaly\"");
			labelTrueAnomalyData.Values.Text = "..................";
			labelTrueAnomalyData.DoubleClick += CopyToClipboard_DoubleClick;
			labelTrueAnomalyData.Enter += SetStatusbar_Enter;
			labelTrueAnomalyData.Leave += ClearStatusbar_Leave;
			labelTrueAnomalyData.MouseEnter += SetStatusbar_Enter;
			labelTrueAnomalyData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPerihelionDistanceData
			// 
			labelPerihelionDistanceData.AccessibleDescription = "Shows the information of \"Perihelion distance\"";
			labelPerihelionDistanceData.AccessibleName = "Shows the information of \"Perihelion distance\"";
			labelPerihelionDistanceData.AccessibleRole = AccessibleRole.StaticText;
			labelPerihelionDistanceData.Dock = DockStyle.Fill;
			labelPerihelionDistanceData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelPerihelionDistanceData.Location = new Point(263, 159);
			labelPerihelionDistanceData.Name = "labelPerihelionDistanceData";
			labelPerihelionDistanceData.Size = new Size(209, 20);
			labelPerihelionDistanceData.TabIndex = 13;
			toolTip.SetToolTip(labelPerihelionDistanceData, "Shows the information of \"Perihelion distance\"");
			labelPerihelionDistanceData.Values.Text = "..................";
			labelPerihelionDistanceData.DoubleClick += CopyToClipboard_DoubleClick;
			labelPerihelionDistanceData.Enter += SetStatusbar_Enter;
			labelPerihelionDistanceData.Leave += ClearStatusbar_Leave;
			labelPerihelionDistanceData.MouseEnter += SetStatusbar_Enter;
			labelPerihelionDistanceData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAphelionDistanceData
			// 
			labelAphelionDistanceData.AccessibleDescription = "Shows the information of \"Aphelion distance\"";
			labelAphelionDistanceData.AccessibleName = "Shows the information of \"Aphelion distance\"";
			labelAphelionDistanceData.AccessibleRole = AccessibleRole.StaticText;
			labelAphelionDistanceData.Dock = DockStyle.Fill;
			labelAphelionDistanceData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelAphelionDistanceData.Location = new Point(263, 185);
			labelAphelionDistanceData.Name = "labelAphelionDistanceData";
			labelAphelionDistanceData.Size = new Size(209, 20);
			labelAphelionDistanceData.TabIndex = 15;
			toolTip.SetToolTip(labelAphelionDistanceData, "Shows the information of \"Aphelion distance\"");
			labelAphelionDistanceData.Values.Text = "..................";
			labelAphelionDistanceData.DoubleClick += CopyToClipboard_DoubleClick;
			labelAphelionDistanceData.Enter += SetStatusbar_Enter;
			labelAphelionDistanceData.Leave += ClearStatusbar_Leave;
			labelAphelionDistanceData.MouseEnter += SetStatusbar_Enter;
			labelAphelionDistanceData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLongitudeDescendingNodeData
			// 
			labelLongitudeDescendingNodeData.AccessibleDescription = "Shows the information of \"Longitude of descending node\"";
			labelLongitudeDescendingNodeData.AccessibleName = "Shows the information of \"Longitude of descending node\"";
			labelLongitudeDescendingNodeData.AccessibleRole = AccessibleRole.StaticText;
			labelLongitudeDescendingNodeData.Dock = DockStyle.Fill;
			labelLongitudeDescendingNodeData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelLongitudeDescendingNodeData.Location = new Point(263, 211);
			labelLongitudeDescendingNodeData.Name = "labelLongitudeDescendingNodeData";
			labelLongitudeDescendingNodeData.Size = new Size(209, 20);
			labelLongitudeDescendingNodeData.TabIndex = 17;
			toolTip.SetToolTip(labelLongitudeDescendingNodeData, "Shows the information of \"Longitude of descending node\"");
			labelLongitudeDescendingNodeData.Values.Text = "..................";
			labelLongitudeDescendingNodeData.DoubleClick += CopyToClipboard_DoubleClick;
			labelLongitudeDescendingNodeData.Enter += SetStatusbar_Enter;
			labelLongitudeDescendingNodeData.Leave += ClearStatusbar_Leave;
			labelLongitudeDescendingNodeData.MouseEnter += SetStatusbar_Enter;
			labelLongitudeDescendingNodeData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelArgumentAphelionData
			// 
			labelArgumentAphelionData.AccessibleDescription = "Shows the information of \"Argument of aphelion\"";
			labelArgumentAphelionData.AccessibleName = "Shows the information of \"Argument of aphelion\"";
			labelArgumentAphelionData.AccessibleRole = AccessibleRole.StaticText;
			labelArgumentAphelionData.Dock = DockStyle.Fill;
			labelArgumentAphelionData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelArgumentAphelionData.Location = new Point(263, 237);
			labelArgumentAphelionData.Name = "labelArgumentAphelionData";
			labelArgumentAphelionData.Size = new Size(209, 20);
			labelArgumentAphelionData.TabIndex = 19;
			toolTip.SetToolTip(labelArgumentAphelionData, "Shows the information of \"Argument of aphelion\"");
			labelArgumentAphelionData.Values.Text = "..................";
			labelArgumentAphelionData.DoubleClick += CopyToClipboard_DoubleClick;
			labelArgumentAphelionData.Enter += SetStatusbar_Enter;
			labelArgumentAphelionData.Leave += ClearStatusbar_Leave;
			labelArgumentAphelionData.MouseEnter += SetStatusbar_Enter;
			labelArgumentAphelionData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelFocalParameterData
			// 
			labelFocalParameterData.AccessibleDescription = "Shows the information of \"Focal parameter\"";
			labelFocalParameterData.AccessibleName = "Shows the information of \"Focal parameter\"";
			labelFocalParameterData.AccessibleRole = AccessibleRole.StaticText;
			labelFocalParameterData.Dock = DockStyle.Fill;
			labelFocalParameterData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelFocalParameterData.Location = new Point(263, 263);
			labelFocalParameterData.Name = "labelFocalParameterData";
			labelFocalParameterData.Size = new Size(209, 20);
			labelFocalParameterData.TabIndex = 21;
			toolTip.SetToolTip(labelFocalParameterData, "Shows the information of \"Focal parameter\"");
			labelFocalParameterData.Values.Text = "..................";
			labelFocalParameterData.DoubleClick += CopyToClipboard_DoubleClick;
			labelFocalParameterData.Enter += SetStatusbar_Enter;
			labelFocalParameterData.Leave += ClearStatusbar_Leave;
			labelFocalParameterData.MouseEnter += SetStatusbar_Enter;
			labelFocalParameterData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiLatusRectumData
			// 
			labelSemiLatusRectumData.AccessibleDescription = "Shows the information of \"Semi-latus rectum\"";
			labelSemiLatusRectumData.AccessibleName = "Shows the information of \"Semi-latus rectum\"";
			labelSemiLatusRectumData.AccessibleRole = AccessibleRole.StaticText;
			labelSemiLatusRectumData.Dock = DockStyle.Fill;
			labelSemiLatusRectumData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelSemiLatusRectumData.Location = new Point(263, 289);
			labelSemiLatusRectumData.Name = "labelSemiLatusRectumData";
			labelSemiLatusRectumData.Size = new Size(209, 20);
			labelSemiLatusRectumData.TabIndex = 23;
			toolTip.SetToolTip(labelSemiLatusRectumData, "Shows the information of \"Semi-latus rectum\"");
			labelSemiLatusRectumData.Values.Text = "..................";
			labelSemiLatusRectumData.DoubleClick += CopyToClipboard_DoubleClick;
			labelSemiLatusRectumData.Enter += SetStatusbar_Enter;
			labelSemiLatusRectumData.Leave += ClearStatusbar_Leave;
			labelSemiLatusRectumData.MouseEnter += SetStatusbar_Enter;
			labelSemiLatusRectumData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLatusRectumData
			// 
			labelLatusRectumData.AccessibleDescription = "Shows the information of \"Latus rectum\"";
			labelLatusRectumData.AccessibleName = "Shows the information of \"Latus rectum\"";
			labelLatusRectumData.AccessibleRole = AccessibleRole.StaticText;
			labelLatusRectumData.Dock = DockStyle.Fill;
			labelLatusRectumData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelLatusRectumData.Location = new Point(263, 315);
			labelLatusRectumData.Name = "labelLatusRectumData";
			labelLatusRectumData.Size = new Size(209, 20);
			labelLatusRectumData.TabIndex = 25;
			toolTip.SetToolTip(labelLatusRectumData, "Shows the information of \"Latus rectum\"");
			labelLatusRectumData.Values.Text = "..................";
			labelLatusRectumData.DoubleClick += CopyToClipboard_DoubleClick;
			labelLatusRectumData.Enter += SetStatusbar_Enter;
			labelLatusRectumData.Leave += ClearStatusbar_Leave;
			labelLatusRectumData.MouseEnter += SetStatusbar_Enter;
			labelLatusRectumData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPeriodData
			// 
			labelPeriodData.AccessibleDescription = "Shows the information of \"Period\"";
			labelPeriodData.AccessibleName = "Shows the information of \"Period\"";
			labelPeriodData.AccessibleRole = AccessibleRole.StaticText;
			labelPeriodData.Dock = DockStyle.Fill;
			labelPeriodData.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelPeriodData.Location = new Point(263, 341);
			labelPeriodData.Name = "labelPeriodData";
			labelPeriodData.Size = new Size(209, 20);
			labelPeriodData.TabIndex = 27;
			toolTip.SetToolTip(labelPeriodData, "Shows the information of \"Period\"");
			labelPeriodData.Values.Text = "..................";
			labelPeriodData.DoubleClick += CopyToClipboard_DoubleClick;
			labelPeriodData.Enter += SetStatusbar_Enter;
			labelPeriodData.Leave += ClearStatusbar_Leave;
			labelPeriodData.MouseEnter += SetStatusbar_Enter;
			labelPeriodData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalAreaDesc
			// 
			labelOrbitalAreaDesc.AccessibleDescription = "Orbital area (AU²)";
			labelOrbitalAreaDesc.AccessibleName = "Orbital area (AU²)";
			labelOrbitalAreaDesc.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalAreaDesc.Dock = DockStyle.Fill;
			labelOrbitalAreaDesc.LabelStyle = LabelStyle.BoldPanel;
			labelOrbitalAreaDesc.Location = new Point(3, 367);
			labelOrbitalAreaDesc.Name = "labelOrbitalAreaDesc";
			labelOrbitalAreaDesc.Size = new Size(254, 20);
			labelOrbitalAreaDesc.TabIndex = 28;
			toolTip.SetToolTip(labelOrbitalAreaDesc, "Orbital area (AU²)");
			labelOrbitalAreaDesc.Values.ExtraText = "AU²";
			labelOrbitalAreaDesc.Values.Text = "Orbital area";
			labelOrbitalAreaDesc.DoubleClick += LabelOrbitalAreaDesc_DoubleClick;
			labelOrbitalAreaDesc.Enter += SetStatusbar_Enter;
			labelOrbitalAreaDesc.Leave += ClearStatusbar_Leave;
			labelOrbitalAreaDesc.MouseEnter += SetStatusbar_Enter;
			labelOrbitalAreaDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalPerimeterDesc
			// 
			labelOrbitalPerimeterDesc.AccessibleDescription = "Orbital perimeter (AU)";
			labelOrbitalPerimeterDesc.AccessibleName = "Orbital perimeter (AU)";
			labelOrbitalPerimeterDesc.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalPerimeterDesc.Dock = DockStyle.Fill;
			labelOrbitalPerimeterDesc.LabelStyle = LabelStyle.BoldPanel;
			labelOrbitalPerimeterDesc.Location = new Point(3, 393);
			labelOrbitalPerimeterDesc.Name = "labelOrbitalPerimeterDesc";
			labelOrbitalPerimeterDesc.Size = new Size(254, 20);
			labelOrbitalPerimeterDesc.TabIndex = 30;
			toolTip.SetToolTip(labelOrbitalPerimeterDesc, "Orbital perimeter (AU)");
			labelOrbitalPerimeterDesc.Values.ExtraText = "AU";
			labelOrbitalPerimeterDesc.Values.Text = "Orbital perimeter";
			labelOrbitalPerimeterDesc.DoubleClick += LabelOrbitalPerimeterDesc_DoubleClick;
			labelOrbitalPerimeterDesc.Enter += SetStatusbar_Enter;
			labelOrbitalPerimeterDesc.Leave += ClearStatusbar_Leave;
			labelOrbitalPerimeterDesc.MouseEnter += SetStatusbar_Enter;
			labelOrbitalPerimeterDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiMeanAxisDesc
			// 
			labelSemiMeanAxisDesc.AccessibleDescription = "Semi-mean axis (AU)";
			labelSemiMeanAxisDesc.AccessibleName = "Semi-mean axis (AU)";
			labelSemiMeanAxisDesc.AccessibleRole = AccessibleRole.StaticText;
			labelSemiMeanAxisDesc.Dock = DockStyle.Fill;
			labelSemiMeanAxisDesc.LabelStyle = LabelStyle.BoldPanel;
			labelSemiMeanAxisDesc.Location = new Point(3, 419);
			labelSemiMeanAxisDesc.Name = "labelSemiMeanAxisDesc";
			labelSemiMeanAxisDesc.Size = new Size(254, 20);
			labelSemiMeanAxisDesc.TabIndex = 32;
			toolTip.SetToolTip(labelSemiMeanAxisDesc, "Semi-mean axis (AU)");
			labelSemiMeanAxisDesc.Values.ExtraText = "AU";
			labelSemiMeanAxisDesc.Values.Text = "Semi-mean axis";
			labelSemiMeanAxisDesc.DoubleClick += LabelSemiMeanAxisDesc_DoubleClick;
			labelSemiMeanAxisDesc.Enter += SetStatusbar_Enter;
			labelSemiMeanAxisDesc.Leave += ClearStatusbar_Leave;
			labelSemiMeanAxisDesc.MouseEnter += SetStatusbar_Enter;
			labelSemiMeanAxisDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanAxisDesc
			// 
			labelMeanAxisDesc.AccessibleDescription = "Mean axis (AU)";
			labelMeanAxisDesc.AccessibleName = "Mean axis (AU)";
			labelMeanAxisDesc.AccessibleRole = AccessibleRole.StaticText;
			labelMeanAxisDesc.Dock = DockStyle.Fill;
			labelMeanAxisDesc.LabelStyle = LabelStyle.BoldPanel;
			labelMeanAxisDesc.Location = new Point(3, 445);
			labelMeanAxisDesc.Name = "labelMeanAxisDesc";
			labelMeanAxisDesc.Size = new Size(254, 20);
			labelMeanAxisDesc.TabIndex = 34;
			toolTip.SetToolTip(labelMeanAxisDesc, "Mean axis (AU)");
			labelMeanAxisDesc.Values.ExtraText = "AU";
			labelMeanAxisDesc.Values.Text = "Mean axis";
			labelMeanAxisDesc.DoubleClick += LabelMeanAxisDesc_DoubleClick;
			labelMeanAxisDesc.Enter += SetStatusbar_Enter;
			labelMeanAxisDesc.Leave += ClearStatusbar_Leave;
			labelMeanAxisDesc.MouseEnter += SetStatusbar_Enter;
			labelMeanAxisDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalAreaData
			// 
			labelOrbitalAreaData.AccessibleDescription = "Shows the information of \"Orbital area\"";
			labelOrbitalAreaData.AccessibleName = "Shows the information of \"Orbital area\"";
			labelOrbitalAreaData.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalAreaData.Dock = DockStyle.Fill;
			labelOrbitalAreaData.Font = new Font("Consolas", 8.25F);
			labelOrbitalAreaData.Location = new Point(263, 367);
			labelOrbitalAreaData.Name = "labelOrbitalAreaData";
			labelOrbitalAreaData.Size = new Size(209, 20);
			labelOrbitalAreaData.TabIndex = 29;
			toolTip.SetToolTip(labelOrbitalAreaData, "Shows the information of \"Orbital area\"");
			labelOrbitalAreaData.Values.Text = "..................";
			labelOrbitalAreaData.DoubleClick += CopyToClipboard_DoubleClick;
			labelOrbitalAreaData.Enter += SetStatusbar_Enter;
			labelOrbitalAreaData.Leave += ClearStatusbar_Leave;
			labelOrbitalAreaData.MouseEnter += SetStatusbar_Enter;
			labelOrbitalAreaData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalPerimeterData
			// 
			labelOrbitalPerimeterData.AccessibleDescription = "Shows the information of \"Orbital perimeter\"";
			labelOrbitalPerimeterData.AccessibleName = "Shows the information of \"Orbital perimeter\"";
			labelOrbitalPerimeterData.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalPerimeterData.Dock = DockStyle.Fill;
			labelOrbitalPerimeterData.Font = new Font("Consolas", 8.25F);
			labelOrbitalPerimeterData.Location = new Point(263, 393);
			labelOrbitalPerimeterData.Name = "labelOrbitalPerimeterData";
			labelOrbitalPerimeterData.Size = new Size(209, 20);
			labelOrbitalPerimeterData.TabIndex = 31;
			toolTip.SetToolTip(labelOrbitalPerimeterData, "Shows the information of \"Orbital perimeter\"");
			labelOrbitalPerimeterData.Values.Text = "..................";
			labelOrbitalPerimeterData.DoubleClick += CopyToClipboard_DoubleClick;
			labelOrbitalPerimeterData.Enter += SetStatusbar_Enter;
			labelOrbitalPerimeterData.Leave += ClearStatusbar_Leave;
			labelOrbitalPerimeterData.MouseEnter += SetStatusbar_Enter;
			labelOrbitalPerimeterData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiMeanAxisData
			// 
			labelSemiMeanAxisData.AccessibleDescription = "Shows the information of \"Semi-mean axis\"";
			labelSemiMeanAxisData.AccessibleName = "Shows the information of \"Semi-mean axis\"";
			labelSemiMeanAxisData.AccessibleRole = AccessibleRole.StaticText;
			labelSemiMeanAxisData.Dock = DockStyle.Fill;
			labelSemiMeanAxisData.Font = new Font("Consolas", 8.25F);
			labelSemiMeanAxisData.Location = new Point(263, 419);
			labelSemiMeanAxisData.Name = "labelSemiMeanAxisData";
			labelSemiMeanAxisData.Size = new Size(209, 20);
			labelSemiMeanAxisData.TabIndex = 33;
			toolTip.SetToolTip(labelSemiMeanAxisData, "Shows the information of \"Semi-mean axis\"");
			labelSemiMeanAxisData.Values.Text = "..................";
			labelSemiMeanAxisData.DoubleClick += CopyToClipboard_DoubleClick;
			labelSemiMeanAxisData.Enter += SetStatusbar_Enter;
			labelSemiMeanAxisData.Leave += ClearStatusbar_Leave;
			labelSemiMeanAxisData.MouseEnter += SetStatusbar_Enter;
			labelSemiMeanAxisData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelStandardGravitationalParameterDesc
			// 
			labelStandardGravitationalParameterDesc.AccessibleDescription = "Standard gravitational parameter (AU³/a²)";
			labelStandardGravitationalParameterDesc.AccessibleName = "Standard gravitational parameter (AU³/a²)";
			labelStandardGravitationalParameterDesc.AccessibleRole = AccessibleRole.StaticText;
			labelStandardGravitationalParameterDesc.Dock = DockStyle.Fill;
			labelStandardGravitationalParameterDesc.LabelStyle = LabelStyle.BoldPanel;
			labelStandardGravitationalParameterDesc.Location = new Point(3, 471);
			labelStandardGravitationalParameterDesc.Name = "labelStandardGravitationalParameterDesc";
			labelStandardGravitationalParameterDesc.Size = new Size(254, 20);
			labelStandardGravitationalParameterDesc.TabIndex = 36;
			toolTip.SetToolTip(labelStandardGravitationalParameterDesc, "Standard gravitational parameter (AU³/a²)");
			labelStandardGravitationalParameterDesc.Values.ExtraText = "AU³/a²";
			labelStandardGravitationalParameterDesc.Values.Text = "Standard gravitational parameter";
			labelStandardGravitationalParameterDesc.DoubleClick += LabelStandardGravitationalParameterDesc_DoubleClick;
			labelStandardGravitationalParameterDesc.Enter += SetStatusbar_Enter;
			labelStandardGravitationalParameterDesc.Leave += ClearStatusbar_Leave;
			labelStandardGravitationalParameterDesc.MouseEnter += SetStatusbar_Enter;
			labelStandardGravitationalParameterDesc.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanAxisData
			// 
			labelMeanAxisData.AccessibleDescription = "Shows the information of \"Mean axis\"";
			labelMeanAxisData.AccessibleName = "Shows the information of \"Mean axis\"";
			labelMeanAxisData.AccessibleRole = AccessibleRole.StaticText;
			labelMeanAxisData.Dock = DockStyle.Fill;
			labelMeanAxisData.Font = new Font("Consolas", 8.25F);
			labelMeanAxisData.Location = new Point(263, 445);
			labelMeanAxisData.Name = "labelMeanAxisData";
			labelMeanAxisData.Size = new Size(209, 20);
			labelMeanAxisData.TabIndex = 35;
			toolTip.SetToolTip(labelMeanAxisData, "Shows the information of \"Mean axis\"");
			labelMeanAxisData.Values.Text = "..................";
			labelMeanAxisData.DoubleClick += CopyToClipboard_DoubleClick;
			labelMeanAxisData.Enter += SetStatusbar_Enter;
			labelMeanAxisData.Leave += ClearStatusbar_Leave;
			labelMeanAxisData.MouseEnter += SetStatusbar_Enter;
			labelMeanAxisData.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelStandardGravitationalParameterData
			// 
			labelStandardGravitationalParameterData.AccessibleDescription = "Shows the information of \"Standard gravitational parameter\"";
			labelStandardGravitationalParameterData.AccessibleName = "Shows the information of \"Standard gravitational parameter\"";
			labelStandardGravitationalParameterData.AccessibleRole = AccessibleRole.StaticText;
			labelStandardGravitationalParameterData.Dock = DockStyle.Fill;
			labelStandardGravitationalParameterData.Font = new Font("Consolas", 8.25F);
			labelStandardGravitationalParameterData.Location = new Point(263, 471);
			labelStandardGravitationalParameterData.Name = "labelStandardGravitationalParameterData";
			labelStandardGravitationalParameterData.Size = new Size(209, 20);
			labelStandardGravitationalParameterData.TabIndex = 37;
			toolTip.SetToolTip(labelStandardGravitationalParameterData, "Shows the information of \"Standard gravitational parameter\"");
			labelStandardGravitationalParameterData.Values.Text = "..................";
			labelStandardGravitationalParameterData.DoubleClick += CopyToClipboard_DoubleClick;
			labelStandardGravitationalParameterData.Enter += SetStatusbar_Enter;
			labelStandardGravitationalParameterData.Leave += ClearStatusbar_Leave;
			labelStandardGravitationalParameterData.MouseEnter += SetStatusbar_Enter;
			labelStandardGravitationalParameterData.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Container to arrange the toolbars";
			toolStripContainer.AccessibleName = "Container to arrange the toolbars";
			toolStripContainer.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanel);
			toolStripContainer.ContentPanel.Size = new Size(475, 471);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(475, 518);
			toolStripContainer.TabIndex = 3;
			toolStripContainer.Text = "toolStripContainer";
			toolTip.SetToolTip(toolStripContainer, "Container to arrange the toolbars");
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(475, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 1;
			statusStrip.Text = "status bar";
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
			labelInformation.Size = new Size(144, 17);
			labelInformation.Text = "some information here";
			labelInformation.ToolTipText = "Shows some information";
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Group the data";
			tableLayoutPanel.AccessibleName = "Table pane";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel.BackgroundImage");
			tableLayoutPanel.BackgroundImageLayout = ImageLayout.None;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.75687F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.24313F));
			tableLayoutPanel.Controls.Add(labelLinearEccentricityData, 1, 0);
			tableLayoutPanel.Controls.Add(labelLinearEccentricityDesc, 0, 0);
			tableLayoutPanel.Controls.Add(labelSemiMinorAxisDesc, 0, 1);
			tableLayoutPanel.Controls.Add(labelMajorAxisDesc, 0, 2);
			tableLayoutPanel.Controls.Add(labelMinorAxisDesc, 0, 3);
			tableLayoutPanel.Controls.Add(labelEccenctricAnomalyDesc, 0, 4);
			tableLayoutPanel.Controls.Add(labelTrueAnomalyDesc, 0, 5);
			tableLayoutPanel.Controls.Add(labelPerihelionDistanceDesc, 0, 6);
			tableLayoutPanel.Controls.Add(LabelAphelionDistanceDesc, 0, 7);
			tableLayoutPanel.Controls.Add(labelLongitudeDescendingNodeDesc, 0, 8);
			tableLayoutPanel.Controls.Add(labelArgumentAphelionDesc, 0, 9);
			tableLayoutPanel.Controls.Add(labelFocalParameterDesc, 0, 10);
			tableLayoutPanel.Controls.Add(labelSemiLatusRectumDesc, 0, 11);
			tableLayoutPanel.Controls.Add(labelLatusRectumDesc, 0, 12);
			tableLayoutPanel.Controls.Add(labelOrbitalPeriodDesc, 0, 13);
			tableLayoutPanel.Controls.Add(labelSemiMinorAxisData, 1, 1);
			tableLayoutPanel.Controls.Add(labelMajorAxisData, 1, 2);
			tableLayoutPanel.Controls.Add(labelMinorAxisData, 1, 3);
			tableLayoutPanel.Controls.Add(labelEccentricAnomalyData, 1, 4);
			tableLayoutPanel.Controls.Add(labelTrueAnomalyData, 1, 5);
			tableLayoutPanel.Controls.Add(labelPerihelionDistanceData, 1, 6);
			tableLayoutPanel.Controls.Add(labelAphelionDistanceData, 1, 7);
			tableLayoutPanel.Controls.Add(labelLongitudeDescendingNodeData, 1, 8);
			tableLayoutPanel.Controls.Add(labelArgumentAphelionData, 1, 9);
			tableLayoutPanel.Controls.Add(labelFocalParameterData, 1, 10);
			tableLayoutPanel.Controls.Add(labelSemiLatusRectumData, 1, 11);
			tableLayoutPanel.Controls.Add(labelLatusRectumData, 1, 12);
			tableLayoutPanel.Controls.Add(labelPeriodData, 1, 13);
			tableLayoutPanel.Controls.Add(labelOrbitalAreaDesc, 0, 14);
			tableLayoutPanel.Controls.Add(labelOrbitalPerimeterDesc, 0, 15);
			tableLayoutPanel.Controls.Add(labelSemiMeanAxisDesc, 0, 16);
			tableLayoutPanel.Controls.Add(labelMeanAxisDesc, 0, 17);
			tableLayoutPanel.Controls.Add(labelOrbitalAreaData, 1, 14);
			tableLayoutPanel.Controls.Add(labelOrbitalPerimeterData, 1, 15);
			tableLayoutPanel.Controls.Add(labelSemiMeanAxisData, 1, 16);
			tableLayoutPanel.Controls.Add(labelMeanAxisData, 1, 17);
			tableLayoutPanel.Controls.Add(labelStandardGravitationalParameterData, 1, 18);
			tableLayoutPanel.Controls.Add(labelStandardGravitationalParameterDesc, 0, 18);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.PanelBackStyle = PaletteBackStyle.FormMain;
			tableLayoutPanel.RowCount = 19;
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel.Size = new Size(475, 471);
			tableLayoutPanel.TabIndex = 0;
			tableLayoutPanel.TabStop = true;
			// 
			// DerivatedOrbitElementsForm
			// 
			AccessibleDescription = "Calculates some derivated orbit elements";
			AccessibleName = "Derivated orbit elements";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(475, 518);
			Controls.Add(toolStripContainer);
			Font = new Font("Segoe UI", 8.5F);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DerivatedOrbitElementsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Derivated orbit elements";
			toolTip.SetToolTip(this, "Derivated orbit elements");
			FormClosed += DerivatedOrbitElementsForm_FormClosed;
			Load += DerivatedOrbitElementsForm_Load;
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			ResumeLayout(false);

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