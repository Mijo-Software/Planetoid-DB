namespace Planetoid_DB
{
	partial class RecordsSelectionForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsSelectionForm));
			panel = new Krypton.Toolkit.KryptonPanel();
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			checkButtonRecordSortDirectionDescending = new Krypton.Toolkit.KryptonCheckButton();
			checkButtonRecordSortDirectionAscending = new Krypton.Toolkit.KryptonCheckButton();
			buttonDateOfLastObservation = new Krypton.Toolkit.KryptonButton();
			buttonComputerName = new Krypton.Toolkit.KryptonButton();
			buttonRmsResidual = new Krypton.Toolkit.KryptonButton();
			buttonObservationSpan = new Krypton.Toolkit.KryptonButton();
			buttonNumberOfObservations = new Krypton.Toolkit.KryptonButton();
			buttonNumberOfOppositions = new Krypton.Toolkit.KryptonButton();
			buttonSlopeParameter = new Krypton.Toolkit.KryptonButton();
			buttonAbsoluteMagnitude = new Krypton.Toolkit.KryptonButton();
			buttonSemiMajorAxis = new Krypton.Toolkit.KryptonButton();
			buttonMeanDailyMotion = new Krypton.Toolkit.KryptonButton();
			buttonOrbitalEccentricity = new Krypton.Toolkit.KryptonButton();
			buttonInclination = new Krypton.Toolkit.KryptonButton();
			buttonArgumentOfPerihelion = new Krypton.Toolkit.KryptonButton();
			buttonLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonButton();
			buttonMeanAnomaly = new Krypton.Toolkit.KryptonButton();
			toolTip = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the buttons";
			panel.AccessibleName = "Groups the buttons";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(statusStrip);
			panel.Controls.Add(checkButtonRecordSortDirectionDescending);
			panel.Controls.Add(checkButtonRecordSortDirectionAscending);
			panel.Controls.Add(buttonDateOfLastObservation);
			panel.Controls.Add(buttonComputerName);
			panel.Controls.Add(buttonRmsResidual);
			panel.Controls.Add(buttonObservationSpan);
			panel.Controls.Add(buttonNumberOfObservations);
			panel.Controls.Add(buttonNumberOfOppositions);
			panel.Controls.Add(buttonSlopeParameter);
			panel.Controls.Add(buttonAbsoluteMagnitude);
			panel.Controls.Add(buttonSemiMajorAxis);
			panel.Controls.Add(buttonMeanDailyMotion);
			panel.Controls.Add(buttonOrbitalEccentricity);
			panel.Controls.Add(buttonInclination);
			panel.Controls.Add(buttonArgumentOfPerihelion);
			panel.Controls.Add(buttonLongitudeOfTheAscendingNode);
			panel.Controls.Add(buttonMeanAnomaly);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Margin = new Padding(4, 3, 4, 3);
			panel.Name = "panel";
			panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			panel.Size = new Size(649, 329);
			panel.TabIndex = 3;
			panel.TabStop = true;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 307);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(649, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 22;
			statusStrip.Text = "status bar";
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Show some information";
			labelInformation.AccessibleName = "Show some information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Image = Properties.Resources.silk_lightbulb;
			labelInformation.Margin = new Padding(5, 3, 0, 2);
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(144, 17);
			labelInformation.Text = "some information here";
			labelInformation.ToolTipText = "Show some information";
			// 
			// checkButtonRecordSortDirectionDescending
			// 
			checkButtonRecordSortDirectionDescending.AccessibleDescription = "Selects the descending sort direction";
			checkButtonRecordSortDirectionDescending.AccessibleName = "Sorted descending";
			checkButtonRecordSortDirectionDescending.AccessibleRole = AccessibleRole.PushButton;
			checkButtonRecordSortDirectionDescending.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			checkButtonRecordSortDirectionDescending.Location = new Point(486, 264);
			checkButtonRecordSortDirectionDescending.Margin = new Padding(4, 3, 4, 3);
			checkButtonRecordSortDirectionDescending.Name = "checkButtonRecordSortDirectionDescending";
			checkButtonRecordSortDirectionDescending.Size = new Size(146, 29);
			checkButtonRecordSortDirectionDescending.TabIndex = 21;
			toolTip.SetToolTip(checkButtonRecordSortDirectionDescending, "Sorted descending");
			checkButtonRecordSortDirectionDescending.Values.DropDownArrowColor = Color.Empty;
			checkButtonRecordSortDirectionDescending.Values.Text = "Sorted &descending";
			checkButtonRecordSortDirectionDescending.Click += CheckButtonRecordSortDirectionDescending_Click;
			checkButtonRecordSortDirectionDescending.Enter += SetStatusbar_Enter;
			checkButtonRecordSortDirectionDescending.Leave += ClearStatusbar_Leave;
			checkButtonRecordSortDirectionDescending.MouseEnter += SetStatusbar_Enter;
			checkButtonRecordSortDirectionDescending.MouseLeave += ClearStatusbar_Leave;
			// 
			// checkButtonRecordSortDirectionAscending
			// 
			checkButtonRecordSortDirectionAscending.AccessibleDescription = "Selects the ascending sort direction";
			checkButtonRecordSortDirectionAscending.AccessibleName = "Sorted ascending";
			checkButtonRecordSortDirectionAscending.AccessibleRole = AccessibleRole.PushButton;
			checkButtonRecordSortDirectionAscending.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			checkButtonRecordSortDirectionAscending.Checked = true;
			checkButtonRecordSortDirectionAscending.Location = new Point(327, 264);
			checkButtonRecordSortDirectionAscending.Margin = new Padding(4, 3, 4, 3);
			checkButtonRecordSortDirectionAscending.Name = "checkButtonRecordSortDirectionAscending";
			checkButtonRecordSortDirectionAscending.Size = new Size(146, 29);
			checkButtonRecordSortDirectionAscending.TabIndex = 20;
			toolTip.SetToolTip(checkButtonRecordSortDirectionAscending, "Sorted ascending");
			checkButtonRecordSortDirectionAscending.Values.DropDownArrowColor = Color.Empty;
			checkButtonRecordSortDirectionAscending.Values.Text = "Sorted &ascending";
			checkButtonRecordSortDirectionAscending.Click += CheckButtonRecordSortDirectionAscending_Click;
			checkButtonRecordSortDirectionAscending.Enter += SetStatusbar_Enter;
			checkButtonRecordSortDirectionAscending.Leave += ClearStatusbar_Leave;
			checkButtonRecordSortDirectionAscending.MouseEnter += SetStatusbar_Enter;
			checkButtonRecordSortDirectionAscending.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonDateOfLastObservation
			// 
			buttonDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation (YYYMMDD)";
			buttonDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation (YYYMMDD)";
			buttonDateOfLastObservation.AccessibleRole = AccessibleRole.PushButton;
			buttonDateOfLastObservation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonDateOfLastObservation.Location = new Point(327, 228);
			buttonDateOfLastObservation.Margin = new Padding(4, 3, 4, 3);
			buttonDateOfLastObservation.Name = "buttonDateOfLastObservation";
			buttonDateOfLastObservation.Size = new Size(306, 29);
			buttonDateOfLastObservation.TabIndex = 19;
			toolTip.SetToolTip(buttonDateOfLastObservation, "Copy to clipboard: Date of last observation (YYYMMDD)");
			buttonDateOfLastObservation.Values.DropDownArrowColor = Color.Empty;
			buttonDateOfLastObservation.Values.Text = "Date of last obser&vation (YYYMMDD)";
			buttonDateOfLastObservation.Click += ButtonDateOfLastObservation_Click;
			buttonDateOfLastObservation.Enter += SetStatusbar_Enter;
			buttonDateOfLastObservation.Leave += ClearStatusbar_Leave;
			buttonDateOfLastObservation.MouseEnter += SetStatusbar_Enter;
			buttonDateOfLastObservation.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonComputerName
			// 
			buttonComputerName.AccessibleDescription = "Copy to clipboard: Computer name";
			buttonComputerName.AccessibleName = "Copy to clipboard: Computer name";
			buttonComputerName.AccessibleRole = AccessibleRole.PushButton;
			buttonComputerName.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonComputerName.Location = new Point(327, 193);
			buttonComputerName.Margin = new Padding(4, 3, 4, 3);
			buttonComputerName.Name = "buttonComputerName";
			buttonComputerName.Size = new Size(306, 29);
			buttonComputerName.TabIndex = 17;
			toolTip.SetToolTip(buttonComputerName, "Copy to clipboard: Computer name");
			buttonComputerName.Values.DropDownArrowColor = Color.Empty;
			buttonComputerName.Values.Text = "&Computer name";
			buttonComputerName.Click += ButtonComputername_Click;
			buttonComputerName.Enter += SetStatusbar_Enter;
			buttonComputerName.Leave += ClearStatusbar_Leave;
			buttonComputerName.MouseEnter += SetStatusbar_Enter;
			buttonComputerName.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonRmsResidual
			// 
			buttonRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual (\")";
			buttonRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual (\")";
			buttonRmsResidual.AccessibleRole = AccessibleRole.PushButton;
			buttonRmsResidual.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonRmsResidual.Location = new Point(327, 157);
			buttonRmsResidual.Margin = new Padding(4, 3, 4, 3);
			buttonRmsResidual.Name = "buttonRmsResidual";
			buttonRmsResidual.Size = new Size(306, 29);
			buttonRmsResidual.TabIndex = 16;
			toolTip.SetToolTip(buttonRmsResidual, "Copy to clipboard: r.m.s. residual (\")");
			buttonRmsResidual.Values.DropDownArrowColor = Color.Empty;
			buttonRmsResidual.Values.Text = "r.m.s. &residual (\")";
			buttonRmsResidual.Click += ButtonRmsResidual_Click;
			buttonRmsResidual.Enter += SetStatusbar_Enter;
			buttonRmsResidual.Leave += ClearStatusbar_Leave;
			buttonRmsResidual.MouseEnter += SetStatusbar_Enter;
			buttonRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonObservationSpan
			// 
			buttonObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			buttonObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			buttonObservationSpan.AccessibleRole = AccessibleRole.PushButton;
			buttonObservationSpan.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonObservationSpan.Location = new Point(327, 121);
			buttonObservationSpan.Margin = new Padding(4, 3, 4, 3);
			buttonObservationSpan.Name = "buttonObservationSpan";
			buttonObservationSpan.Size = new Size(306, 29);
			buttonObservationSpan.TabIndex = 15;
			toolTip.SetToolTip(buttonObservationSpan, "Copy to clipboard: Observation span");
			buttonObservationSpan.Values.DropDownArrowColor = Color.Empty;
			buttonObservationSpan.Values.Text = "Obser&vation span";
			buttonObservationSpan.Click += ButtonObservationSpan_Click;
			buttonObservationSpan.Enter += SetStatusbar_Enter;
			buttonObservationSpan.Leave += ClearStatusbar_Leave;
			buttonObservationSpan.MouseEnter += SetStatusbar_Enter;
			buttonObservationSpan.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonNumberOfObservations
			// 
			buttonNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			buttonNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			buttonNumberOfObservations.AccessibleRole = AccessibleRole.PushButton;
			buttonNumberOfObservations.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonNumberOfObservations.Location = new Point(327, 85);
			buttonNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			buttonNumberOfObservations.Name = "buttonNumberOfObservations";
			buttonNumberOfObservations.Size = new Size(306, 29);
			buttonNumberOfObservations.TabIndex = 14;
			toolTip.SetToolTip(buttonNumberOfObservations, "Copy to clipboard: Number of observations");
			buttonNumberOfObservations.Values.DropDownArrowColor = Color.Empty;
			buttonNumberOfObservations.Values.Text = "Number of o&bservations";
			buttonNumberOfObservations.Click += ButtonNumberOfObservations_Click;
			buttonNumberOfObservations.Enter += SetStatusbar_Enter;
			buttonNumberOfObservations.Leave += ClearStatusbar_Leave;
			buttonNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			buttonNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonNumberOfOppositions
			// 
			buttonNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			buttonNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions";
			buttonNumberOfOppositions.AccessibleRole = AccessibleRole.PushButton;
			buttonNumberOfOppositions.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonNumberOfOppositions.Location = new Point(327, 50);
			buttonNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			buttonNumberOfOppositions.Name = "buttonNumberOfOppositions";
			buttonNumberOfOppositions.Size = new Size(306, 29);
			buttonNumberOfOppositions.TabIndex = 13;
			toolTip.SetToolTip(buttonNumberOfOppositions, "Copy to clipboard: Number of oppositions");
			buttonNumberOfOppositions.Values.DropDownArrowColor = Color.Empty;
			buttonNumberOfOppositions.Values.Text = "Number of &oppositions";
			buttonNumberOfOppositions.Click += ButtonNumberOfOppositions_Click;
			buttonNumberOfOppositions.Enter += SetStatusbar_Enter;
			buttonNumberOfOppositions.Leave += ClearStatusbar_Leave;
			buttonNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			buttonNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSlopeParameter
			// 
			buttonSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter, G";
			buttonSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter, G";
			buttonSlopeParameter.AccessibleRole = AccessibleRole.PushButton;
			buttonSlopeParameter.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonSlopeParameter.Location = new Point(327, 14);
			buttonSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			buttonSlopeParameter.Name = "buttonSlopeParameter";
			buttonSlopeParameter.Size = new Size(306, 29);
			buttonSlopeParameter.TabIndex = 11;
			toolTip.SetToolTip(buttonSlopeParameter, "Copy to clipboard: Slope parameter, G");
			buttonSlopeParameter.Values.DropDownArrowColor = Color.Empty;
			buttonSlopeParameter.Values.Text = "Slope pa&rameter, G";
			buttonSlopeParameter.Click += ButtonSlopeParameter_Click;
			buttonSlopeParameter.Enter += SetStatusbar_Enter;
			buttonSlopeParameter.Leave += ClearStatusbar_Leave;
			buttonSlopeParameter.MouseEnter += SetStatusbar_Enter;
			buttonSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonAbsoluteMagnitude
			// 
			buttonAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude, H";
			buttonAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude, H";
			buttonAbsoluteMagnitude.AccessibleRole = AccessibleRole.PushButton;
			buttonAbsoluteMagnitude.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonAbsoluteMagnitude.Location = new Point(14, 264);
			buttonAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			buttonAbsoluteMagnitude.Name = "buttonAbsoluteMagnitude";
			buttonAbsoluteMagnitude.Size = new Size(306, 29);
			buttonAbsoluteMagnitude.TabIndex = 10;
			toolTip.SetToolTip(buttonAbsoluteMagnitude, "Copy to clipboard: Absolute magnitude, H");
			buttonAbsoluteMagnitude.Values.DropDownArrowColor = Color.Empty;
			buttonAbsoluteMagnitude.Values.Text = "Absolute ma&gnitude, H";
			buttonAbsoluteMagnitude.Click += ButtonAbsoluteMagnitude_Click;
			buttonAbsoluteMagnitude.Enter += SetStatusbar_Enter;
			buttonAbsoluteMagnitude.Leave += ClearStatusbar_Leave;
			buttonAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			buttonAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSemiMajorAxis
			// 
			buttonSemiMajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis (AU)";
			buttonSemiMajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis (AU)";
			buttonSemiMajorAxis.AccessibleRole = AccessibleRole.PushButton;
			buttonSemiMajorAxis.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonSemiMajorAxis.Location = new Point(14, 228);
			buttonSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			buttonSemiMajorAxis.Name = "buttonSemiMajorAxis";
			buttonSemiMajorAxis.Size = new Size(306, 29);
			buttonSemiMajorAxis.TabIndex = 9;
			toolTip.SetToolTip(buttonSemiMajorAxis, "Copy to clipboard: Semi-major axis (AU)");
			buttonSemiMajorAxis.Values.DropDownArrowColor = Color.Empty;
			buttonSemiMajorAxis.Values.Text = "&Semi-major axis (AU)";
			buttonSemiMajorAxis.Click += ButtonSemiMajorAxis_Click;
			buttonSemiMajorAxis.Enter += SetStatusbar_Enter;
			buttonSemiMajorAxis.Leave += ClearStatusbar_Leave;
			buttonSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			buttonSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonMeanDailyMotion
			// 
			buttonMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion (degrees per day)";
			buttonMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion (degrees per day)";
			buttonMeanDailyMotion.AccessibleRole = AccessibleRole.PushButton;
			buttonMeanDailyMotion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonMeanDailyMotion.Location = new Point(14, 193);
			buttonMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			buttonMeanDailyMotion.Name = "buttonMeanDailyMotion";
			buttonMeanDailyMotion.Size = new Size(306, 29);
			buttonMeanDailyMotion.TabIndex = 8;
			toolTip.SetToolTip(buttonMeanDailyMotion, "Copy to clipboard: Mean daily motion (degrees per day)");
			buttonMeanDailyMotion.Values.DropDownArrowColor = Color.Empty;
			buttonMeanDailyMotion.Values.Text = "Mean daily &motion (°/day)";
			buttonMeanDailyMotion.Click += ButtonMeanDailyMotion_Click;
			buttonMeanDailyMotion.Enter += SetStatusbar_Enter;
			buttonMeanDailyMotion.Leave += ClearStatusbar_Leave;
			buttonMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			buttonMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonOrbitalEccentricity
			// 
			buttonOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			buttonOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			buttonOrbitalEccentricity.AccessibleRole = AccessibleRole.PushButton;
			buttonOrbitalEccentricity.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonOrbitalEccentricity.Location = new Point(14, 157);
			buttonOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			buttonOrbitalEccentricity.Name = "buttonOrbitalEccentricity";
			buttonOrbitalEccentricity.Size = new Size(306, 29);
			buttonOrbitalEccentricity.TabIndex = 7;
			toolTip.SetToolTip(buttonOrbitalEccentricity, "Copy to clipboard: Orbital eccentricity");
			buttonOrbitalEccentricity.Values.DropDownArrowColor = Color.Empty;
			buttonOrbitalEccentricity.Values.Text = "Orbital &eccentricity";
			buttonOrbitalEccentricity.Click += ButtonOrbitalEccentricity_Click;
			buttonOrbitalEccentricity.Enter += SetStatusbar_Enter;
			buttonOrbitalEccentricity.Leave += ClearStatusbar_Leave;
			buttonOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			buttonOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonInclination
			// 
			buttonInclination.AccessibleDescription = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			buttonInclination.AccessibleName = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			buttonInclination.AccessibleRole = AccessibleRole.PushButton;
			buttonInclination.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonInclination.Location = new Point(14, 121);
			buttonInclination.Margin = new Padding(4, 3, 4, 3);
			buttonInclination.Name = "buttonInclination";
			buttonInclination.Size = new Size(306, 29);
			buttonInclination.TabIndex = 6;
			toolTip.SetToolTip(buttonInclination, "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)");
			buttonInclination.Values.DropDownArrowColor = Color.Empty;
			buttonInclination.Values.Text = "&Inclination to the ecliptic, J2000.0 (°)";
			buttonInclination.Click += ButtonInclination_Click;
			buttonInclination.Enter += SetStatusbar_Enter;
			buttonInclination.Leave += ClearStatusbar_Leave;
			buttonInclination.MouseEnter += SetStatusbar_Enter;
			buttonInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonArgumentOfPerihelion
			// 
			buttonArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			buttonArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			buttonArgumentOfPerihelion.AccessibleRole = AccessibleRole.PushButton;
			buttonArgumentOfPerihelion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonArgumentOfPerihelion.Location = new Point(14, 50);
			buttonArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			buttonArgumentOfPerihelion.Name = "buttonArgumentOfPerihelion";
			buttonArgumentOfPerihelion.Size = new Size(306, 29);
			buttonArgumentOfPerihelion.TabIndex = 4;
			toolTip.SetToolTip(buttonArgumentOfPerihelion, "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)");
			buttonArgumentOfPerihelion.Values.DropDownArrowColor = Color.Empty;
			buttonArgumentOfPerihelion.Values.Text = "Argument of peri&helion, J2000.0 (°)";
			buttonArgumentOfPerihelion.Click += ButtonArgumentOfPerihelion_Click;
			buttonArgumentOfPerihelion.Enter += SetStatusbar_Enter;
			buttonArgumentOfPerihelion.Leave += ClearStatusbar_Leave;
			buttonArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			buttonArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonLongitudeOfTheAscendingNode
			// 
			buttonLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)";
			buttonLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)";
			buttonLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.PushButton;
			buttonLongitudeOfTheAscendingNode.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonLongitudeOfTheAscendingNode.Location = new Point(14, 85);
			buttonLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			buttonLongitudeOfTheAscendingNode.Name = "buttonLongitudeOfTheAscendingNode";
			buttonLongitudeOfTheAscendingNode.Size = new Size(306, 29);
			buttonLongitudeOfTheAscendingNode.TabIndex = 5;
			toolTip.SetToolTip(buttonLongitudeOfTheAscendingNode, "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)");
			buttonLongitudeOfTheAscendingNode.Values.DropDownArrowColor = Color.Empty;
			buttonLongitudeOfTheAscendingNode.Values.Text = "&Longitude of the ascending node, J2000.0 (°)";
			buttonLongitudeOfTheAscendingNode.Click += ButtonLongitudeOfTheAscendingNode_Click;
			buttonLongitudeOfTheAscendingNode.Enter += SetStatusbar_Enter;
			buttonLongitudeOfTheAscendingNode.Leave += ClearStatusbar_Leave;
			buttonLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			buttonLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonMeanAnomaly
			// 
			buttonMeanAnomaly.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			buttonMeanAnomaly.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			buttonMeanAnomaly.AccessibleRole = AccessibleRole.PushButton;
			buttonMeanAnomaly.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonMeanAnomaly.Location = new Point(14, 14);
			buttonMeanAnomaly.Margin = new Padding(4, 3, 4, 3);
			buttonMeanAnomaly.Name = "buttonMeanAnomaly";
			buttonMeanAnomaly.Size = new Size(306, 29);
			buttonMeanAnomaly.TabIndex = 3;
			toolTip.SetToolTip(buttonMeanAnomaly, "Copy to clipboard: Mean anomaly at the epoch (degrees)");
			buttonMeanAnomaly.Values.DropDownArrowColor = Color.Empty;
			buttonMeanAnomaly.Values.Text = "Mean anomal&y at the epoch (°)";
			buttonMeanAnomaly.Click += ButtonMeanAnomaly_Click;
			buttonMeanAnomaly.Enter += SetStatusbar_Enter;
			buttonMeanAnomaly.Leave += ClearStatusbar_Leave;
			buttonMeanAnomaly.MouseEnter += SetStatusbar_Enter;
			buttonMeanAnomaly.MouseLeave += ClearStatusbar_Leave;
			// 
			// RecordsSelectionForm
			// 
			AccessibleDescription = "Show the top ten records";
			AccessibleName = "Top ten records";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(649, 329);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "RecordsSelectionForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Top ten records";
			toolTip.SetToolTip(this, "Top ten records");
			UseDropShadow = true;
			FormClosed += RecordsSelectionForm_FormClosed;
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);

		}

		#endregion
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonButton buttonDateOfLastObservation;
		private Krypton.Toolkit.KryptonButton buttonComputerName;
		private Krypton.Toolkit.KryptonButton buttonRmsResidual;
		private Krypton.Toolkit.KryptonButton buttonObservationSpan;
		private Krypton.Toolkit.KryptonButton buttonNumberOfObservations;
		private Krypton.Toolkit.KryptonButton buttonNumberOfOppositions;
		private Krypton.Toolkit.KryptonButton buttonSlopeParameter;
		private Krypton.Toolkit.KryptonButton buttonAbsoluteMagnitude;
		private Krypton.Toolkit.KryptonButton buttonSemiMajorAxis;
		private Krypton.Toolkit.KryptonButton buttonMeanDailyMotion;
		private Krypton.Toolkit.KryptonButton buttonOrbitalEccentricity;
		private Krypton.Toolkit.KryptonButton buttonInclination;
		private Krypton.Toolkit.KryptonButton buttonArgumentOfPerihelion;
		private Krypton.Toolkit.KryptonButton buttonLongitudeOfTheAscendingNode;
		private Krypton.Toolkit.KryptonButton buttonMeanAnomaly;
		private Krypton.Toolkit.KryptonCheckButton checkButtonRecordSortDirectionAscending;
		private Krypton.Toolkit.KryptonCheckButton checkButtonRecordSortDirectionDescending;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
	}
}