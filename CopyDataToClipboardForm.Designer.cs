namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	partial class CopyDataToClipboardForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDataToClipboardForm));
			buttonIndexNumber = new Krypton.Toolkit.KryptonButton();
			toolTip = new ToolTip(components);
			buttonReadableDesignation = new Krypton.Toolkit.KryptonButton();
			buttonEpoch = new Krypton.Toolkit.KryptonButton();
			buttonMeanAnomaly = new Krypton.Toolkit.KryptonButton();
			buttonArgumentOfPerihelion = new Krypton.Toolkit.KryptonButton();
			buttonLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonButton();
			buttonInclination = new Krypton.Toolkit.KryptonButton();
			buttonOrbitalEccentricity = new Krypton.Toolkit.KryptonButton();
			buttonMeanDailyMotion = new Krypton.Toolkit.KryptonButton();
			buttonSemimajorAxis = new Krypton.Toolkit.KryptonButton();
			buttonAbsoluteMagnitude = new Krypton.Toolkit.KryptonButton();
			buttonSlopeParameter = new Krypton.Toolkit.KryptonButton();
			buttonReference = new Krypton.Toolkit.KryptonButton();
			buttonObservationSpan = new Krypton.Toolkit.KryptonButton();
			buttonNumberOfObservations = new Krypton.Toolkit.KryptonButton();
			buttonNumberOfOppositions = new Krypton.Toolkit.KryptonButton();
			buttonFlags = new Krypton.Toolkit.KryptonButton();
			buttonComputername = new Krypton.Toolkit.KryptonButton();
			buttonRmsResidual = new Krypton.Toolkit.KryptonButton();
			buttonDateOfLastObservation = new Krypton.Toolkit.KryptonButton();
			panel = new Krypton.Toolkit.KryptonPanel();
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// buttonIndexNumber
			// 
			buttonIndexNumber.AccessibleDescription = "Copy to clipboard: Index No.";
			buttonIndexNumber.AccessibleName = "Copy to clipboard: Index No.";
			buttonIndexNumber.AccessibleRole = AccessibleRole.PushButton;
			buttonIndexNumber.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonIndexNumber.Location = new Point(14, 14);
			buttonIndexNumber.Margin = new Padding(4, 3, 4, 3);
			buttonIndexNumber.Name = "buttonIndexNumber";
			buttonIndexNumber.Size = new Size(306, 29);
			buttonIndexNumber.TabIndex = 0;
			toolTip.SetToolTip(buttonIndexNumber, "Index No.");
			buttonIndexNumber.Values.Text = "Index No.";
			buttonIndexNumber.Click += ButtonIndexNumber_Click;
			buttonIndexNumber.Enter += SetStatusbar_Enter;
			buttonIndexNumber.Leave += ClearStatusbar_Leave;
			buttonIndexNumber.MouseEnter += SetStatusbar_Enter;
			buttonIndexNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonReadableDesignation
			// 
			buttonReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			buttonReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			buttonReadableDesignation.AccessibleRole = AccessibleRole.PushButton;
			buttonReadableDesignation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonReadableDesignation.Location = new Point(14, 50);
			buttonReadableDesignation.Margin = new Padding(4, 3, 4, 3);
			buttonReadableDesignation.Name = "buttonReadableDesignation";
			buttonReadableDesignation.Size = new Size(306, 29);
			buttonReadableDesignation.TabIndex = 1;
			toolTip.SetToolTip(buttonReadableDesignation, "Readable designation");
			buttonReadableDesignation.Values.Text = "Readable designation";
			buttonReadableDesignation.Click += ButtonReadableDesignation_Click;
			buttonReadableDesignation.Enter += SetStatusbar_Enter;
			buttonReadableDesignation.Leave += ClearStatusbar_Leave;
			buttonReadableDesignation.MouseEnter += SetStatusbar_Enter;
			buttonReadableDesignation.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonEpoch
			// 
			buttonEpoch.AccessibleDescription = "Copy to clipboard: Epoch (in packed form, .0 TT)";
			buttonEpoch.AccessibleName = "Copy to clipboard: Epoch (in packed form, .0 TT)";
			buttonEpoch.AccessibleRole = AccessibleRole.PushButton;
			buttonEpoch.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonEpoch.Location = new Point(14, 85);
			buttonEpoch.Margin = new Padding(4, 3, 4, 3);
			buttonEpoch.Name = "buttonEpoch";
			buttonEpoch.Size = new Size(306, 29);
			buttonEpoch.TabIndex = 2;
			toolTip.SetToolTip(buttonEpoch, "Epoch (in packed form, .0 TT)");
			buttonEpoch.Values.Text = "Epoch (in packed form, .0 TT)";
			buttonEpoch.Click += ButtonEpoch_Click;
			buttonEpoch.Enter += SetStatusbar_Enter;
			buttonEpoch.Leave += ClearStatusbar_Leave;
			buttonEpoch.MouseEnter += SetStatusbar_Enter;
			buttonEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonMeanAnomaly
			// 
			buttonMeanAnomaly.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			buttonMeanAnomaly.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			buttonMeanAnomaly.AccessibleRole = AccessibleRole.PushButton;
			buttonMeanAnomaly.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonMeanAnomaly.Location = new Point(14, 121);
			buttonMeanAnomaly.Margin = new Padding(4, 3, 4, 3);
			buttonMeanAnomaly.Name = "buttonMeanAnomaly";
			buttonMeanAnomaly.Size = new Size(306, 29);
			buttonMeanAnomaly.TabIndex = 3;
			toolTip.SetToolTip(buttonMeanAnomaly, "Mean anomaly at the epoch (degrees)");
			buttonMeanAnomaly.Values.Text = "Mean anomaly at the epoch (°)";
			buttonMeanAnomaly.Click += ButtonMeanAnomaly_Click;
			buttonMeanAnomaly.Enter += SetStatusbar_Enter;
			buttonMeanAnomaly.Leave += ClearStatusbar_Leave;
			buttonMeanAnomaly.MouseEnter += SetStatusbar_Enter;
			buttonMeanAnomaly.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonArgumentOfPerihelion
			// 
			buttonArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			buttonArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			buttonArgumentOfPerihelion.AccessibleRole = AccessibleRole.PushButton;
			buttonArgumentOfPerihelion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonArgumentOfPerihelion.Location = new Point(14, 157);
			buttonArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			buttonArgumentOfPerihelion.Name = "buttonArgumentOfPerihelion";
			buttonArgumentOfPerihelion.Size = new Size(306, 29);
			buttonArgumentOfPerihelion.TabIndex = 4;
			toolTip.SetToolTip(buttonArgumentOfPerihelion, "Argument of perihelion, J2000.0 (degrees)");
			buttonArgumentOfPerihelion.Values.Text = "Argument of perihelion, J2000.0 (°)";
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
			buttonLongitudeOfTheAscendingNode.Location = new Point(14, 193);
			buttonLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			buttonLongitudeOfTheAscendingNode.Name = "buttonLongitudeOfTheAscendingNode";
			buttonLongitudeOfTheAscendingNode.Size = new Size(306, 29);
			buttonLongitudeOfTheAscendingNode.TabIndex = 5;
			toolTip.SetToolTip(buttonLongitudeOfTheAscendingNode, "Longitude of the ascending node, J2000.0 (degrees)");
			buttonLongitudeOfTheAscendingNode.Values.Text = "Longitude of the ascending node, J2000.0 (°)";
			buttonLongitudeOfTheAscendingNode.Click += ButtonLongitudeOfTheAscendingNode_Click;
			buttonLongitudeOfTheAscendingNode.Enter += SetStatusbar_Enter;
			buttonLongitudeOfTheAscendingNode.Leave += ClearStatusbar_Leave;
			buttonLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			buttonLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonInclination
			// 
			buttonInclination.AccessibleDescription = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			buttonInclination.AccessibleName = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			buttonInclination.AccessibleRole = AccessibleRole.PushButton;
			buttonInclination.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonInclination.Location = new Point(14, 228);
			buttonInclination.Margin = new Padding(4, 3, 4, 3);
			buttonInclination.Name = "buttonInclination";
			buttonInclination.Size = new Size(306, 29);
			buttonInclination.TabIndex = 6;
			toolTip.SetToolTip(buttonInclination, "Inclination to the ecliptic, J2000.0 (degrees)");
			buttonInclination.Values.Text = "Inclination to the ecliptic, J2000.0 (°)";
			buttonInclination.Click += ButtonInclination_Click;
			buttonInclination.Enter += SetStatusbar_Enter;
			buttonInclination.Leave += ClearStatusbar_Leave;
			buttonInclination.MouseEnter += SetStatusbar_Enter;
			buttonInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonOrbitalEccentricity
			// 
			buttonOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			buttonOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			buttonOrbitalEccentricity.AccessibleRole = AccessibleRole.PushButton;
			buttonOrbitalEccentricity.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonOrbitalEccentricity.Location = new Point(14, 264);
			buttonOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			buttonOrbitalEccentricity.Name = "buttonOrbitalEccentricity";
			buttonOrbitalEccentricity.Size = new Size(306, 29);
			buttonOrbitalEccentricity.TabIndex = 7;
			toolTip.SetToolTip(buttonOrbitalEccentricity, "Orbital eccentricity");
			buttonOrbitalEccentricity.Values.Text = "Orbital eccentricity";
			buttonOrbitalEccentricity.Click += ButtonOrbitalEccentricity_Click;
			buttonOrbitalEccentricity.Enter += SetStatusbar_Enter;
			buttonOrbitalEccentricity.Leave += ClearStatusbar_Leave;
			buttonOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			buttonOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonMeanDailyMotion
			// 
			buttonMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion (degrees per day)";
			buttonMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion (degrees per day)";
			buttonMeanDailyMotion.AccessibleRole = AccessibleRole.PushButton;
			buttonMeanDailyMotion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonMeanDailyMotion.Location = new Point(14, 300);
			buttonMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			buttonMeanDailyMotion.Name = "buttonMeanDailyMotion";
			buttonMeanDailyMotion.Size = new Size(306, 29);
			buttonMeanDailyMotion.TabIndex = 8;
			toolTip.SetToolTip(buttonMeanDailyMotion, "Mean daily motion (degrees per day)");
			buttonMeanDailyMotion.Values.Text = "Mean daily motion (°/day)";
			buttonMeanDailyMotion.Click += ButtonMeanDailyMotion_Click;
			buttonMeanDailyMotion.Enter += SetStatusbar_Enter;
			buttonMeanDailyMotion.Leave += ClearStatusbar_Leave;
			buttonMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			buttonMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSemimajorAxis
			// 
			buttonSemimajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis (AU)";
			buttonSemimajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis (AU)";
			buttonSemimajorAxis.AccessibleRole = AccessibleRole.PushButton;
			buttonSemimajorAxis.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonSemimajorAxis.Location = new Point(14, 336);
			buttonSemimajorAxis.Margin = new Padding(4, 3, 4, 3);
			buttonSemimajorAxis.Name = "buttonSemimajorAxis";
			buttonSemimajorAxis.Size = new Size(306, 29);
			buttonSemimajorAxis.TabIndex = 9;
			toolTip.SetToolTip(buttonSemimajorAxis, "Semi-major axis (AU)");
			buttonSemimajorAxis.Values.Text = "Semi-major axis (AU)";
			buttonSemimajorAxis.Click += ButtonSemimajorAxis_Click;
			buttonSemimajorAxis.Enter += SetStatusbar_Enter;
			buttonSemimajorAxis.Leave += ClearStatusbar_Leave;
			buttonSemimajorAxis.MouseEnter += SetStatusbar_Enter;
			buttonSemimajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonAbsoluteMagnitude
			// 
			buttonAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude, H";
			buttonAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude, H";
			buttonAbsoluteMagnitude.AccessibleRole = AccessibleRole.PushButton;
			buttonAbsoluteMagnitude.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonAbsoluteMagnitude.Location = new Point(327, 14);
			buttonAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			buttonAbsoluteMagnitude.Name = "buttonAbsoluteMagnitude";
			buttonAbsoluteMagnitude.Size = new Size(306, 29);
			buttonAbsoluteMagnitude.TabIndex = 10;
			toolTip.SetToolTip(buttonAbsoluteMagnitude, "Absolute magnitude, H");
			buttonAbsoluteMagnitude.Values.Text = "Absolute magnitude, H";
			buttonAbsoluteMagnitude.Click += ButtonAbsoluteMagnitude_Click;
			buttonAbsoluteMagnitude.Enter += SetStatusbar_Enter;
			buttonAbsoluteMagnitude.Leave += ClearStatusbar_Leave;
			buttonAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			buttonAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSlopeParameter
			// 
			buttonSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter, G";
			buttonSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter, G";
			buttonSlopeParameter.AccessibleRole = AccessibleRole.PushButton;
			buttonSlopeParameter.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonSlopeParameter.Location = new Point(327, 50);
			buttonSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			buttonSlopeParameter.Name = "buttonSlopeParameter";
			buttonSlopeParameter.Size = new Size(306, 29);
			buttonSlopeParameter.TabIndex = 11;
			toolTip.SetToolTip(buttonSlopeParameter, "Slope parameter, G");
			buttonSlopeParameter.Values.Text = "Slope parameter, G";
			buttonSlopeParameter.Click += ButtonSlopeParameter_Click;
			buttonSlopeParameter.Enter += SetStatusbar_Enter;
			buttonSlopeParameter.Leave += ClearStatusbar_Leave;
			buttonSlopeParameter.MouseEnter += SetStatusbar_Enter;
			buttonSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonReference
			// 
			buttonReference.AccessibleDescription = "Copy to clipboard: Reference";
			buttonReference.AccessibleName = "Copy to clipboard: Reference";
			buttonReference.AccessibleRole = AccessibleRole.PushButton;
			buttonReference.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonReference.Location = new Point(327, 85);
			buttonReference.Margin = new Padding(4, 3, 4, 3);
			buttonReference.Name = "buttonReference";
			buttonReference.Size = new Size(306, 29);
			buttonReference.TabIndex = 12;
			toolTip.SetToolTip(buttonReference, "Reference");
			buttonReference.Values.Text = "Reference";
			buttonReference.Click += ButtonReference_Click;
			buttonReference.Enter += SetStatusbar_Enter;
			buttonReference.Leave += ClearStatusbar_Leave;
			buttonReference.MouseEnter += SetStatusbar_Enter;
			buttonReference.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonObservationSpan
			// 
			buttonObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			buttonObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			buttonObservationSpan.AccessibleRole = AccessibleRole.PushButton;
			buttonObservationSpan.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonObservationSpan.Location = new Point(327, 193);
			buttonObservationSpan.Margin = new Padding(4, 3, 4, 3);
			buttonObservationSpan.Name = "buttonObservationSpan";
			buttonObservationSpan.Size = new Size(306, 29);
			buttonObservationSpan.TabIndex = 15;
			toolTip.SetToolTip(buttonObservationSpan, "Observation span");
			buttonObservationSpan.Values.Text = "Observation span";
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
			buttonNumberOfObservations.Location = new Point(327, 157);
			buttonNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			buttonNumberOfObservations.Name = "buttonNumberOfObservations";
			buttonNumberOfObservations.Size = new Size(306, 29);
			buttonNumberOfObservations.TabIndex = 14;
			toolTip.SetToolTip(buttonNumberOfObservations, "Number of observations");
			buttonNumberOfObservations.Values.Text = "Number of observations";
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
			buttonNumberOfOppositions.Location = new Point(327, 121);
			buttonNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			buttonNumberOfOppositions.Name = "buttonNumberOfOppositions";
			buttonNumberOfOppositions.Size = new Size(306, 29);
			buttonNumberOfOppositions.TabIndex = 13;
			toolTip.SetToolTip(buttonNumberOfOppositions, "Number of oppositions");
			buttonNumberOfOppositions.Values.Text = "Number of oppositions";
			buttonNumberOfOppositions.Click += ButtonNumberOfOppositions_Click;
			buttonNumberOfOppositions.Enter += SetStatusbar_Enter;
			buttonNumberOfOppositions.Leave += ClearStatusbar_Leave;
			buttonNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			buttonNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonFlags
			// 
			buttonFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			buttonFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			buttonFlags.AccessibleRole = AccessibleRole.PushButton;
			buttonFlags.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonFlags.Location = new Point(327, 300);
			buttonFlags.Margin = new Padding(4, 3, 4, 3);
			buttonFlags.Name = "buttonFlags";
			buttonFlags.Size = new Size(306, 29);
			buttonFlags.TabIndex = 18;
			toolTip.SetToolTip(buttonFlags, "4-hexdigit flags");
			buttonFlags.Values.Text = "4-hexdigit flags";
			buttonFlags.Click += ButtonFlags_Click;
			buttonFlags.Enter += SetStatusbar_Enter;
			buttonFlags.Leave += ClearStatusbar_Leave;
			buttonFlags.MouseEnter += SetStatusbar_Enter;
			buttonFlags.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonComputername
			// 
			buttonComputername.AccessibleDescription = "Copy to clipboard: Computer name";
			buttonComputername.AccessibleName = "Copy to clipboard: Computer name";
			buttonComputername.AccessibleRole = AccessibleRole.PushButton;
			buttonComputername.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonComputername.Location = new Point(327, 264);
			buttonComputername.Margin = new Padding(4, 3, 4, 3);
			buttonComputername.Name = "buttonComputername";
			buttonComputername.Size = new Size(306, 29);
			buttonComputername.TabIndex = 17;
			toolTip.SetToolTip(buttonComputername, "Computer name");
			buttonComputername.Values.Text = "Computer name";
			buttonComputername.Click += ButtonComputername_Click;
			buttonComputername.Enter += SetStatusbar_Enter;
			buttonComputername.Leave += ClearStatusbar_Leave;
			buttonComputername.MouseEnter += SetStatusbar_Enter;
			buttonComputername.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonRmsResidual
			// 
			buttonRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual (\")";
			buttonRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual (\")";
			buttonRmsResidual.AccessibleRole = AccessibleRole.PushButton;
			buttonRmsResidual.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonRmsResidual.Location = new Point(327, 228);
			buttonRmsResidual.Margin = new Padding(4, 3, 4, 3);
			buttonRmsResidual.Name = "buttonRmsResidual";
			buttonRmsResidual.Size = new Size(306, 29);
			buttonRmsResidual.TabIndex = 16;
			toolTip.SetToolTip(buttonRmsResidual, "r.m.s. residual (\")");
			buttonRmsResidual.Values.Text = "r.m.s. residual (\")";
			buttonRmsResidual.Click += ButtonRmsResidual_Click;
			buttonRmsResidual.Enter += SetStatusbar_Enter;
			buttonRmsResidual.Leave += ClearStatusbar_Leave;
			buttonRmsResidual.MouseEnter += SetStatusbar_Enter;
			buttonRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonDateOfLastObservation
			// 
			buttonDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation (YYYMMDD)";
			buttonDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation (YYYMMDD)";
			buttonDateOfLastObservation.AccessibleRole = AccessibleRole.PushButton;
			buttonDateOfLastObservation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonDateOfLastObservation.Location = new Point(327, 336);
			buttonDateOfLastObservation.Margin = new Padding(4, 3, 4, 3);
			buttonDateOfLastObservation.Name = "buttonDateOfLastObservation";
			buttonDateOfLastObservation.Size = new Size(306, 29);
			buttonDateOfLastObservation.TabIndex = 19;
			toolTip.SetToolTip(buttonDateOfLastObservation, "Date of last observation (YYYMMDD)");
			buttonDateOfLastObservation.Values.Text = "Date of last observation (YYYMMDD)";
			buttonDateOfLastObservation.Click += ButtonDateOfLastObservation_Click;
			buttonDateOfLastObservation.Enter += SetStatusbar_Enter;
			buttonDateOfLastObservation.Leave += ClearStatusbar_Leave;
			buttonDateOfLastObservation.MouseEnter += SetStatusbar_Enter;
			buttonDateOfLastObservation.MouseLeave += ClearStatusbar_Leave;
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(buttonDateOfLastObservation);
			panel.Controls.Add(buttonFlags);
			panel.Controls.Add(buttonComputername);
			panel.Controls.Add(buttonRmsResidual);
			panel.Controls.Add(buttonObservationSpan);
			panel.Controls.Add(buttonNumberOfObservations);
			panel.Controls.Add(buttonNumberOfOppositions);
			panel.Controls.Add(buttonReference);
			panel.Controls.Add(buttonSlopeParameter);
			panel.Controls.Add(buttonAbsoluteMagnitude);
			panel.Controls.Add(buttonSemimajorAxis);
			panel.Controls.Add(buttonMeanDailyMotion);
			panel.Controls.Add(buttonOrbitalEccentricity);
			panel.Controls.Add(buttonInclination);
			panel.Controls.Add(buttonArgumentOfPerihelion);
			panel.Controls.Add(buttonLongitudeOfTheAscendingNode);
			panel.Controls.Add(buttonEpoch);
			panel.Controls.Add(buttonMeanAnomaly);
			panel.Controls.Add(buttonIndexNumber);
			panel.Controls.Add(buttonReadableDesignation);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Margin = new Padding(4, 3, 4, 3);
			panel.Name = "panel";
			panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			panel.Size = new Size(644, 377);
			panel.TabIndex = 0;
			panel.TabStop = true;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(644, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 20;
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
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(panel);
			toolStripContainer.ContentPanel.Size = new Size(644, 377);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(644, 399);
			toolStripContainer.TabIndex = 1;
			// 
			// CopyDataToClipboardForm
			// 
			AccessibleDescription = "Copy data to clipboard";
			AccessibleName = "Copy data to clipboard";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(644, 399);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CopyDataToClipboardForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Copy data to clipboard";
			toolTip.SetToolTip(this, "Copy data to clipboard");
			FormClosed += CopyDataToClipboardForm_FormClosed;
			Load += CopyDataToClipboardForm_Load;
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Krypton.Toolkit.KryptonButton buttonIndexNumber;
		private ToolTip toolTip;
		private Krypton.Toolkit.KryptonButton buttonReadableDesignation;
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonButton buttonArgumentOfPerihelion;
		private Krypton.Toolkit.KryptonButton buttonLongitudeOfTheAscendingNode;
		private Krypton.Toolkit.KryptonButton buttonEpoch;
		private Krypton.Toolkit.KryptonButton buttonMeanAnomaly;
		private Krypton.Toolkit.KryptonButton buttonReference;
		private Krypton.Toolkit.KryptonButton buttonSlopeParameter;
		private Krypton.Toolkit.KryptonButton buttonAbsoluteMagnitude;
		private Krypton.Toolkit.KryptonButton buttonSemimajorAxis;
		private Krypton.Toolkit.KryptonButton buttonMeanDailyMotion;
		private Krypton.Toolkit.KryptonButton buttonOrbitalEccentricity;
		private Krypton.Toolkit.KryptonButton buttonInclination;
		private Krypton.Toolkit.KryptonButton buttonDateOfLastObservation;
		private Krypton.Toolkit.KryptonButton buttonFlags;
		private Krypton.Toolkit.KryptonButton buttonComputername;
		private Krypton.Toolkit.KryptonButton buttonRmsResidual;
		private Krypton.Toolkit.KryptonButton buttonObservationSpan;
		private Krypton.Toolkit.KryptonButton buttonNumberOfObservations;
		private Krypton.Toolkit.KryptonButton buttonNumberOfOppositions;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolStripContainer toolStripContainer;
	}
}