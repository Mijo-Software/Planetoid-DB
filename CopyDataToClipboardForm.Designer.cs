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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDataToClipboardForm));
			this.buttonIndexNumber = new Krypton.Toolkit.KryptonButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonReadableDesignation = new Krypton.Toolkit.KryptonButton();
			this.buttonEpoch = new Krypton.Toolkit.KryptonButton();
			this.buttonMeanAnomaly = new Krypton.Toolkit.KryptonButton();
			this.buttonArgumentOfPerihelion = new Krypton.Toolkit.KryptonButton();
			this.buttonLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonButton();
			this.buttonInclination = new Krypton.Toolkit.KryptonButton();
			this.buttonOrbitalEccentricity = new Krypton.Toolkit.KryptonButton();
			this.buttonMeanDailyMotion = new Krypton.Toolkit.KryptonButton();
			this.buttonSemimajorAxis = new Krypton.Toolkit.KryptonButton();
			this.buttonAbsoluteMagnitude = new Krypton.Toolkit.KryptonButton();
			this.buttonSlopeParameter = new Krypton.Toolkit.KryptonButton();
			this.buttonReference = new Krypton.Toolkit.KryptonButton();
			this.buttonObservationSpan = new Krypton.Toolkit.KryptonButton();
			this.buttonNumberOfObservations = new Krypton.Toolkit.KryptonButton();
			this.buttonNumberOfOppositions = new Krypton.Toolkit.KryptonButton();
			this.buttonFlags = new Krypton.Toolkit.KryptonButton();
			this.buttonComputername = new Krypton.Toolkit.KryptonButton();
			this.buttonRmsResidual = new Krypton.Toolkit.KryptonButton();
			this.buttonDateOfLastObservation = new Krypton.Toolkit.KryptonButton();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonIndexNumber
			// 
			this.buttonIndexNumber.AccessibleDescription = "Copy to clipboard: Index No.";
			this.buttonIndexNumber.AccessibleName = "Copy to clipboard: Index No.";
			this.buttonIndexNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonIndexNumber.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonIndexNumber.CornerRoundingRadius = -1F;
			this.buttonIndexNumber.Location = new System.Drawing.Point(12, 12);
			this.buttonIndexNumber.Name = "buttonIndexNumber";
			this.buttonIndexNumber.Size = new System.Drawing.Size(262, 25);
			this.buttonIndexNumber.TabIndex = 0;
			this.toolTip.SetToolTip(this.buttonIndexNumber, "Index No.");
			this.buttonIndexNumber.Values.Text = "Index No.";
			this.buttonIndexNumber.Click += new System.EventHandler(this.ButtonIndexNumber_Click);
			this.buttonIndexNumber.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonIndexNumber.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonIndexNumber.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonIndexNumber.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonReadableDesignation
			// 
			this.buttonReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			this.buttonReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			this.buttonReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonReadableDesignation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonReadableDesignation.CornerRoundingRadius = -1F;
			this.buttonReadableDesignation.Location = new System.Drawing.Point(12, 43);
			this.buttonReadableDesignation.Name = "buttonReadableDesignation";
			this.buttonReadableDesignation.Size = new System.Drawing.Size(262, 25);
			this.buttonReadableDesignation.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonReadableDesignation, "Readable designation");
			this.buttonReadableDesignation.Values.Text = "Readable designation";
			this.buttonReadableDesignation.Click += new System.EventHandler(this.ButtonReadableDesignation_Click);
			this.buttonReadableDesignation.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonReadableDesignation.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonReadableDesignation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonReadableDesignation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonEpoch
			// 
			this.buttonEpoch.AccessibleDescription = "Copy to clipboard: Epoch (in packed form, .0 TT)";
			this.buttonEpoch.AccessibleName = "Copy to clipboard: Epoch (in packed form, .0 TT)";
			this.buttonEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonEpoch.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonEpoch.CornerRoundingRadius = -1F;
			this.buttonEpoch.Location = new System.Drawing.Point(12, 74);
			this.buttonEpoch.Name = "buttonEpoch";
			this.buttonEpoch.Size = new System.Drawing.Size(262, 25);
			this.buttonEpoch.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonEpoch, "Epoch (in packed form, .0 TT)");
			this.buttonEpoch.Values.Text = "Epoch (in packed form, .0 TT)";
			this.buttonEpoch.Click += new System.EventHandler(this.ButtonEpoch_Click);
			this.buttonEpoch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonEpoch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonMeanAnomaly
			// 
			this.buttonMeanAnomaly.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			this.buttonMeanAnomaly.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			this.buttonMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonMeanAnomaly.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonMeanAnomaly.CornerRoundingRadius = -1F;
			this.buttonMeanAnomaly.Location = new System.Drawing.Point(12, 105);
			this.buttonMeanAnomaly.Name = "buttonMeanAnomaly";
			this.buttonMeanAnomaly.Size = new System.Drawing.Size(262, 25);
			this.buttonMeanAnomaly.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonMeanAnomaly, "Mean anomaly at the epoch (degrees)");
			this.buttonMeanAnomaly.Values.Text = "Mean anomaly at the epoch (°)";
			this.buttonMeanAnomaly.Click += new System.EventHandler(this.ButtonMeanAnomaly_Click);
			this.buttonMeanAnomaly.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanAnomaly.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonMeanAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonArgumentOfPerihelion
			// 
			this.buttonArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			this.buttonArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			this.buttonArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonArgumentOfPerihelion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonArgumentOfPerihelion.CornerRoundingRadius = -1F;
			this.buttonArgumentOfPerihelion.Location = new System.Drawing.Point(12, 136);
			this.buttonArgumentOfPerihelion.Name = "buttonArgumentOfPerihelion";
			this.buttonArgumentOfPerihelion.Size = new System.Drawing.Size(262, 25);
			this.buttonArgumentOfPerihelion.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonArgumentOfPerihelion, "Argument of perihelion, J2000.0 (degrees)");
			this.buttonArgumentOfPerihelion.Values.Text = "Argument of perihelion, J2000.0 (°)";
			this.buttonArgumentOfPerihelion.Click += new System.EventHandler(this.ButtonArgumentOfPerihelion_Click);
			this.buttonArgumentOfPerihelion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonArgumentOfPerihelion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonLongitudeOfTheAscendingNode
			// 
			this.buttonLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)";
			this.buttonLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)";
			this.buttonLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonLongitudeOfTheAscendingNode.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonLongitudeOfTheAscendingNode.CornerRoundingRadius = -1F;
			this.buttonLongitudeOfTheAscendingNode.Location = new System.Drawing.Point(12, 167);
			this.buttonLongitudeOfTheAscendingNode.Name = "buttonLongitudeOfTheAscendingNode";
			this.buttonLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(262, 25);
			this.buttonLongitudeOfTheAscendingNode.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonLongitudeOfTheAscendingNode, "Longitude of the ascending node, J2000.0 (degrees)");
			this.buttonLongitudeOfTheAscendingNode.Values.Text = "Longitude of the ascending node, J2000.0 (°)";
			this.buttonLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.ButtonLongitudeOfTheAscendingNode_Click);
			this.buttonLongitudeOfTheAscendingNode.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLongitudeOfTheAscendingNode.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonInclination
			// 
			this.buttonInclination.AccessibleDescription = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			this.buttonInclination.AccessibleName = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			this.buttonInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInclination.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonInclination.CornerRoundingRadius = -1F;
			this.buttonInclination.Location = new System.Drawing.Point(12, 198);
			this.buttonInclination.Name = "buttonInclination";
			this.buttonInclination.Size = new System.Drawing.Size(262, 25);
			this.buttonInclination.TabIndex = 6;
			this.toolTip.SetToolTip(this.buttonInclination, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.buttonInclination.Values.Text = "Inclination to the ecliptic, J2000.0 (°)";
			this.buttonInclination.Click += new System.EventHandler(this.ButtonInclination_Click);
			this.buttonInclination.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInclination.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonOrbitalEccentricity
			// 
			this.buttonOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.buttonOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.buttonOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOrbitalEccentricity.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonOrbitalEccentricity.CornerRoundingRadius = -1F;
			this.buttonOrbitalEccentricity.Location = new System.Drawing.Point(12, 229);
			this.buttonOrbitalEccentricity.Name = "buttonOrbitalEccentricity";
			this.buttonOrbitalEccentricity.Size = new System.Drawing.Size(262, 25);
			this.buttonOrbitalEccentricity.TabIndex = 7;
			this.toolTip.SetToolTip(this.buttonOrbitalEccentricity, "Orbital eccentricity");
			this.buttonOrbitalEccentricity.Values.Text = "Orbital eccentricity";
			this.buttonOrbitalEccentricity.Click += new System.EventHandler(this.ButtonOrbitalEccentricity_Click);
			this.buttonOrbitalEccentricity.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOrbitalEccentricity.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonMeanDailyMotion
			// 
			this.buttonMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion (degrees per day)";
			this.buttonMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion (degrees per day)";
			this.buttonMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonMeanDailyMotion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonMeanDailyMotion.CornerRoundingRadius = -1F;
			this.buttonMeanDailyMotion.Location = new System.Drawing.Point(12, 260);
			this.buttonMeanDailyMotion.Name = "buttonMeanDailyMotion";
			this.buttonMeanDailyMotion.Size = new System.Drawing.Size(262, 25);
			this.buttonMeanDailyMotion.TabIndex = 8;
			this.toolTip.SetToolTip(this.buttonMeanDailyMotion, "Mean daily motion (degrees per day)");
			this.buttonMeanDailyMotion.Values.Text = "Mean daily motion (°/day)";
			this.buttonMeanDailyMotion.Click += new System.EventHandler(this.ButtonMeanDailyMotion_Click);
			this.buttonMeanDailyMotion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanDailyMotion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSemimajorAxis
			// 
			this.buttonSemimajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis (AU)";
			this.buttonSemimajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis (AU)";
			this.buttonSemimajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSemimajorAxis.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonSemimajorAxis.CornerRoundingRadius = -1F;
			this.buttonSemimajorAxis.Location = new System.Drawing.Point(12, 291);
			this.buttonSemimajorAxis.Name = "buttonSemimajorAxis";
			this.buttonSemimajorAxis.Size = new System.Drawing.Size(262, 25);
			this.buttonSemimajorAxis.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonSemimajorAxis, "Semi-major axis (AU)");
			this.buttonSemimajorAxis.Values.Text = "Semi-major axis (AU)";
			this.buttonSemimajorAxis.Click += new System.EventHandler(this.ButtonSemimajorAxis_Click);
			this.buttonSemimajorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSemimajorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSemimajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSemimajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonAbsoluteMagnitude
			// 
			this.buttonAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude, H";
			this.buttonAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude, H";
			this.buttonAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonAbsoluteMagnitude.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonAbsoluteMagnitude.CornerRoundingRadius = -1F;
			this.buttonAbsoluteMagnitude.Location = new System.Drawing.Point(280, 12);
			this.buttonAbsoluteMagnitude.Name = "buttonAbsoluteMagnitude";
			this.buttonAbsoluteMagnitude.Size = new System.Drawing.Size(262, 25);
			this.buttonAbsoluteMagnitude.TabIndex = 10;
			this.toolTip.SetToolTip(this.buttonAbsoluteMagnitude, "Absolute magnitude, H");
			this.buttonAbsoluteMagnitude.Values.Text = "Absolute magnitude, H";
			this.buttonAbsoluteMagnitude.Click += new System.EventHandler(this.ButtonAbsoluteMagnitude_Click);
			this.buttonAbsoluteMagnitude.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonAbsoluteMagnitude.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSlopeParameter
			// 
			this.buttonSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter, G";
			this.buttonSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter, G";
			this.buttonSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSlopeParameter.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonSlopeParameter.CornerRoundingRadius = -1F;
			this.buttonSlopeParameter.Location = new System.Drawing.Point(280, 43);
			this.buttonSlopeParameter.Name = "buttonSlopeParameter";
			this.buttonSlopeParameter.Size = new System.Drawing.Size(262, 25);
			this.buttonSlopeParameter.TabIndex = 11;
			this.toolTip.SetToolTip(this.buttonSlopeParameter, "Slope parameter, G");
			this.buttonSlopeParameter.Values.Text = "Slope parameter, G";
			this.buttonSlopeParameter.Click += new System.EventHandler(this.ButtonSlopeParameter_Click);
			this.buttonSlopeParameter.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSlopeParameter.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonReference
			// 
			this.buttonReference.AccessibleDescription = "Copy to clipboard: Reference";
			this.buttonReference.AccessibleName = "Copy to clipboard: Reference";
			this.buttonReference.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonReference.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonReference.CornerRoundingRadius = -1F;
			this.buttonReference.Location = new System.Drawing.Point(280, 74);
			this.buttonReference.Name = "buttonReference";
			this.buttonReference.Size = new System.Drawing.Size(262, 25);
			this.buttonReference.TabIndex = 12;
			this.toolTip.SetToolTip(this.buttonReference, "Reference");
			this.buttonReference.Values.Text = "Reference";
			this.buttonReference.Click += new System.EventHandler(this.ButtonReference_Click);
			this.buttonReference.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonReference.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonReference.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonReference.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonObservationSpan
			// 
			this.buttonObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.buttonObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.buttonObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonObservationSpan.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonObservationSpan.CornerRoundingRadius = -1F;
			this.buttonObservationSpan.Location = new System.Drawing.Point(280, 167);
			this.buttonObservationSpan.Name = "buttonObservationSpan";
			this.buttonObservationSpan.Size = new System.Drawing.Size(262, 25);
			this.buttonObservationSpan.TabIndex = 15;
			this.toolTip.SetToolTip(this.buttonObservationSpan, "Observation span");
			this.buttonObservationSpan.Values.Text = "Observation span";
			this.buttonObservationSpan.Click += new System.EventHandler(this.ButtonObservationSpan_Click);
			this.buttonObservationSpan.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonObservationSpan.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonNumberOfObservations
			// 
			this.buttonNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			this.buttonNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			this.buttonNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonNumberOfObservations.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonNumberOfObservations.CornerRoundingRadius = -1F;
			this.buttonNumberOfObservations.Location = new System.Drawing.Point(280, 136);
			this.buttonNumberOfObservations.Name = "buttonNumberOfObservations";
			this.buttonNumberOfObservations.Size = new System.Drawing.Size(262, 25);
			this.buttonNumberOfObservations.TabIndex = 14;
			this.toolTip.SetToolTip(this.buttonNumberOfObservations, "Number of observations");
			this.buttonNumberOfObservations.Values.Text = "Number of observations";
			this.buttonNumberOfObservations.Click += new System.EventHandler(this.ButtonNumberOfObservations_Click);
			this.buttonNumberOfObservations.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonNumberOfObservations.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonNumberOfOppositions
			// 
			this.buttonNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			this.buttonNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions";
			this.buttonNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonNumberOfOppositions.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonNumberOfOppositions.CornerRoundingRadius = -1F;
			this.buttonNumberOfOppositions.Location = new System.Drawing.Point(280, 105);
			this.buttonNumberOfOppositions.Name = "buttonNumberOfOppositions";
			this.buttonNumberOfOppositions.Size = new System.Drawing.Size(262, 25);
			this.buttonNumberOfOppositions.TabIndex = 13;
			this.toolTip.SetToolTip(this.buttonNumberOfOppositions, "Number of oppositions");
			this.buttonNumberOfOppositions.Values.Text = "Number of oppositions";
			this.buttonNumberOfOppositions.Click += new System.EventHandler(this.ButtonNumberOfOppositions_Click);
			this.buttonNumberOfOppositions.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonNumberOfOppositions.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonFlags
			// 
			this.buttonFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.buttonFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.buttonFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonFlags.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonFlags.CornerRoundingRadius = -1F;
			this.buttonFlags.Location = new System.Drawing.Point(280, 260);
			this.buttonFlags.Name = "buttonFlags";
			this.buttonFlags.Size = new System.Drawing.Size(262, 25);
			this.buttonFlags.TabIndex = 18;
			this.toolTip.SetToolTip(this.buttonFlags, "4-hexdigit flags");
			this.buttonFlags.Values.Text = "4-hexdigit flags";
			this.buttonFlags.Click += new System.EventHandler(this.ButtonFlags_Click);
			this.buttonFlags.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonFlags.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonComputername
			// 
			this.buttonComputername.AccessibleDescription = "Copy to clipboard: Computer name";
			this.buttonComputername.AccessibleName = "Copy to clipboard: Computer name";
			this.buttonComputername.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonComputername.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonComputername.CornerRoundingRadius = -1F;
			this.buttonComputername.Location = new System.Drawing.Point(280, 229);
			this.buttonComputername.Name = "buttonComputername";
			this.buttonComputername.Size = new System.Drawing.Size(262, 25);
			this.buttonComputername.TabIndex = 17;
			this.toolTip.SetToolTip(this.buttonComputername, "Computer name");
			this.buttonComputername.Values.Text = "Computer name";
			this.buttonComputername.Click += new System.EventHandler(this.ButtonComputername_Click);
			this.buttonComputername.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonComputername.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonComputername.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonComputername.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonRmsResidual
			// 
			this.buttonRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual (\")";
			this.buttonRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual (\")";
			this.buttonRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonRmsResidual.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonRmsResidual.CornerRoundingRadius = -1F;
			this.buttonRmsResidual.Location = new System.Drawing.Point(280, 198);
			this.buttonRmsResidual.Name = "buttonRmsResidual";
			this.buttonRmsResidual.Size = new System.Drawing.Size(262, 25);
			this.buttonRmsResidual.TabIndex = 16;
			this.toolTip.SetToolTip(this.buttonRmsResidual, "r.m.s. residual (\")");
			this.buttonRmsResidual.Values.Text = "r.m.s. residual (\")";
			this.buttonRmsResidual.Click += new System.EventHandler(this.ButtonRmsResidual_Click);
			this.buttonRmsResidual.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonRmsResidual.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDateOfLastObservation
			// 
			this.buttonDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation (YYYMMDD)";
			this.buttonDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation (YYYMMDD)";
			this.buttonDateOfLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDateOfLastObservation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonDateOfLastObservation.CornerRoundingRadius = -1F;
			this.buttonDateOfLastObservation.Location = new System.Drawing.Point(280, 291);
			this.buttonDateOfLastObservation.Name = "buttonDateOfLastObservation";
			this.buttonDateOfLastObservation.Size = new System.Drawing.Size(262, 25);
			this.buttonDateOfLastObservation.TabIndex = 19;
			this.toolTip.SetToolTip(this.buttonDateOfLastObservation, "Date of last observation (YYYMMDD)");
			this.buttonDateOfLastObservation.Values.Text = "Date of last observation (YYYMMDD)";
			this.buttonDateOfLastObservation.Click += new System.EventHandler(this.ButtonDateOfLastObservation_Click);
			this.buttonDateOfLastObservation.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDateOfLastObservation.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDateOfLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDateOfLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "pane";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.buttonDateOfLastObservation);
			this.panel.Controls.Add(this.buttonFlags);
			this.panel.Controls.Add(this.buttonComputername);
			this.panel.Controls.Add(this.buttonRmsResidual);
			this.panel.Controls.Add(this.buttonObservationSpan);
			this.panel.Controls.Add(this.buttonNumberOfObservations);
			this.panel.Controls.Add(this.buttonNumberOfOppositions);
			this.panel.Controls.Add(this.buttonReference);
			this.panel.Controls.Add(this.buttonSlopeParameter);
			this.panel.Controls.Add(this.buttonAbsoluteMagnitude);
			this.panel.Controls.Add(this.buttonSemimajorAxis);
			this.panel.Controls.Add(this.buttonMeanDailyMotion);
			this.panel.Controls.Add(this.buttonOrbitalEccentricity);
			this.panel.Controls.Add(this.buttonInclination);
			this.panel.Controls.Add(this.buttonArgumentOfPerihelion);
			this.panel.Controls.Add(this.buttonLongitudeOfTheAscendingNode);
			this.panel.Controls.Add(this.buttonEpoch);
			this.panel.Controls.Add(this.buttonMeanAnomaly);
			this.panel.Controls.Add(this.buttonIndexNumber);
			this.panel.Controls.Add(this.buttonReadableDesignation);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.panel.Size = new System.Drawing.Size(552, 346);
			this.panel.TabIndex = 0;
			this.panel.TabStop = true;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 324);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(552, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 20;
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
			// CopyDataToClipboardForm
			// 
			this.AccessibleDescription = "Copy data to clipboard";
			this.AccessibleName = "Copy data to clipboard";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 346);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CopyDataToClipboardForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Copy data to clipboard";
			this.toolTip.SetToolTip(this, "Copy data to clipboard");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CopyDataToClipboardForm_FormClosed);
			this.Load += new System.EventHandler(this.CopyDataToClipboardForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonButton buttonIndexNumber;
		private System.Windows.Forms.ToolTip toolTip;
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
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}