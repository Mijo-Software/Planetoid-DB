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
			this.kryptonButtonIndexNumber = new Krypton.Toolkit.KryptonButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.kryptonButtonReadableDesignation = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonEpoch = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonMeanAnomaly = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonArgumentOfPerihelion = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonInclination = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonOrbitalEccentricity = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonMeanDailyMotion = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonSemimajorAxis = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonAbsoluteMagnitude = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonSlopeParameter = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonReference = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonObservationSpan = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonNumberOfObservations = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonNumberOfOppositions = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonFlags = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonComputername = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonRmsResidual = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonDateOfLastObservation = new Krypton.Toolkit.KryptonButton();
			this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// kryptonButtonIndexNumber
			// 
			this.kryptonButtonIndexNumber.AccessibleDescription = "Copy to clipboard: Index No.";
			this.kryptonButtonIndexNumber.AccessibleName = "Copy to clipboard: Index No.";
			this.kryptonButtonIndexNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonIndexNumber.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonIndexNumber.CornerRoundingRadius = -1F;
			this.kryptonButtonIndexNumber.Location = new System.Drawing.Point(12, 12);
			this.kryptonButtonIndexNumber.Name = "kryptonButtonIndexNumber";
			this.kryptonButtonIndexNumber.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonIndexNumber.TabIndex = 0;
			this.toolTip.SetToolTip(this.kryptonButtonIndexNumber, "Index No.");
			this.kryptonButtonIndexNumber.Values.Text = "Index No.";
			this.kryptonButtonIndexNumber.Click += new System.EventHandler(this.KryptonButtonIndexNumber_Click);
			this.kryptonButtonIndexNumber.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonIndexNumber.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonIndexNumber.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonIndexNumber.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonReadableDesignation
			// 
			this.kryptonButtonReadableDesignation.AccessibleDescription = "Copy to clipboard: Readable designation";
			this.kryptonButtonReadableDesignation.AccessibleName = "Copy to clipboard: Readable designation";
			this.kryptonButtonReadableDesignation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonReadableDesignation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonReadableDesignation.CornerRoundingRadius = -1F;
			this.kryptonButtonReadableDesignation.Location = new System.Drawing.Point(12, 43);
			this.kryptonButtonReadableDesignation.Name = "kryptonButtonReadableDesignation";
			this.kryptonButtonReadableDesignation.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonReadableDesignation.TabIndex = 1;
			this.toolTip.SetToolTip(this.kryptonButtonReadableDesignation, "Readable designation");
			this.kryptonButtonReadableDesignation.Values.Text = "Readable designation";
			this.kryptonButtonReadableDesignation.Click += new System.EventHandler(this.KryptonButtonReadableDesignation_Click);
			this.kryptonButtonReadableDesignation.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonReadableDesignation.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonReadableDesignation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonReadableDesignation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonEpoch
			// 
			this.kryptonButtonEpoch.AccessibleDescription = "Copy to clipboard: Epoch (in packed form, .0 TT)";
			this.kryptonButtonEpoch.AccessibleName = "Copy to clipboard: Epoch (in packed form, .0 TT)";
			this.kryptonButtonEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonEpoch.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonEpoch.CornerRoundingRadius = -1F;
			this.kryptonButtonEpoch.Location = new System.Drawing.Point(12, 74);
			this.kryptonButtonEpoch.Name = "kryptonButtonEpoch";
			this.kryptonButtonEpoch.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonEpoch.TabIndex = 2;
			this.toolTip.SetToolTip(this.kryptonButtonEpoch, "Epoch (in packed form, .0 TT)");
			this.kryptonButtonEpoch.Values.Text = "Epoch (in packed form, .0 TT)";
			this.kryptonButtonEpoch.Click += new System.EventHandler(this.KryptonButtonEpoch_Click);
			this.kryptonButtonEpoch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonEpoch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonEpoch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonEpoch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonMeanAnomaly
			// 
			this.kryptonButtonMeanAnomaly.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			this.kryptonButtonMeanAnomaly.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			this.kryptonButtonMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonMeanAnomaly.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonMeanAnomaly.CornerRoundingRadius = -1F;
			this.kryptonButtonMeanAnomaly.Location = new System.Drawing.Point(12, 105);
			this.kryptonButtonMeanAnomaly.Name = "kryptonButtonMeanAnomaly";
			this.kryptonButtonMeanAnomaly.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonMeanAnomaly.TabIndex = 3;
			this.toolTip.SetToolTip(this.kryptonButtonMeanAnomaly, "Mean anomaly at the epoch (degrees)");
			this.kryptonButtonMeanAnomaly.Values.Text = "Mean anomaly at the epoch (°)";
			this.kryptonButtonMeanAnomaly.Click += new System.EventHandler(this.KryptonButtonMeanAnomaly_Click);
			this.kryptonButtonMeanAnomaly.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonMeanAnomaly.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonMeanAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonMeanAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonArgumentOfPerihelion
			// 
			this.kryptonButtonArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			this.kryptonButtonArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			this.kryptonButtonArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonArgumentOfPerihelion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonArgumentOfPerihelion.CornerRoundingRadius = -1F;
			this.kryptonButtonArgumentOfPerihelion.Location = new System.Drawing.Point(12, 136);
			this.kryptonButtonArgumentOfPerihelion.Name = "kryptonButtonArgumentOfPerihelion";
			this.kryptonButtonArgumentOfPerihelion.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonArgumentOfPerihelion.TabIndex = 4;
			this.toolTip.SetToolTip(this.kryptonButtonArgumentOfPerihelion, "Argument of perihelion, J2000.0 (degrees)");
			this.kryptonButtonArgumentOfPerihelion.Values.Text = "Argument of perihelion, J2000.0 (°)";
			this.kryptonButtonArgumentOfPerihelion.Click += new System.EventHandler(this.KryptonButtonArgumentOfPerihelion_Click);
			this.kryptonButtonArgumentOfPerihelion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonArgumentOfPerihelion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonArgumentOfPerihelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonArgumentOfPerihelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonLongitudeOfTheAscendingNode
			// 
			this.kryptonButtonLongitudeOfTheAscendingNode.AccessibleDescription = "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)";
			this.kryptonButtonLongitudeOfTheAscendingNode.AccessibleName = "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)";
			this.kryptonButtonLongitudeOfTheAscendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonLongitudeOfTheAscendingNode.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonLongitudeOfTheAscendingNode.CornerRoundingRadius = -1F;
			this.kryptonButtonLongitudeOfTheAscendingNode.Location = new System.Drawing.Point(12, 167);
			this.kryptonButtonLongitudeOfTheAscendingNode.Name = "kryptonButtonLongitudeOfTheAscendingNode";
			this.kryptonButtonLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonLongitudeOfTheAscendingNode.TabIndex = 5;
			this.toolTip.SetToolTip(this.kryptonButtonLongitudeOfTheAscendingNode, "Longitude of the ascending node, J2000.0 (degrees)");
			this.kryptonButtonLongitudeOfTheAscendingNode.Values.Text = "Longitude of the ascending node, J2000.0 (°)";
			this.kryptonButtonLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.KryptonButtonLongitudeOfTheAscendingNode_Click);
			this.kryptonButtonLongitudeOfTheAscendingNode.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonLongitudeOfTheAscendingNode.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonInclination
			// 
			this.kryptonButtonInclination.AccessibleDescription = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			this.kryptonButtonInclination.AccessibleName = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			this.kryptonButtonInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonInclination.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonInclination.CornerRoundingRadius = -1F;
			this.kryptonButtonInclination.Location = new System.Drawing.Point(12, 198);
			this.kryptonButtonInclination.Name = "kryptonButtonInclination";
			this.kryptonButtonInclination.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonInclination.TabIndex = 6;
			this.toolTip.SetToolTip(this.kryptonButtonInclination, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.kryptonButtonInclination.Values.Text = "Inclination to the ecliptic, J2000.0 (°)";
			this.kryptonButtonInclination.Click += new System.EventHandler(this.KryptonButtonInclination_Click);
			this.kryptonButtonInclination.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonInclination.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonOrbitalEccentricity
			// 
			this.kryptonButtonOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.kryptonButtonOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.kryptonButtonOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonOrbitalEccentricity.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonOrbitalEccentricity.CornerRoundingRadius = -1F;
			this.kryptonButtonOrbitalEccentricity.Location = new System.Drawing.Point(12, 229);
			this.kryptonButtonOrbitalEccentricity.Name = "kryptonButtonOrbitalEccentricity";
			this.kryptonButtonOrbitalEccentricity.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonOrbitalEccentricity.TabIndex = 7;
			this.toolTip.SetToolTip(this.kryptonButtonOrbitalEccentricity, "Orbital eccentricity");
			this.kryptonButtonOrbitalEccentricity.Values.Text = "Orbital eccentricity";
			this.kryptonButtonOrbitalEccentricity.Click += new System.EventHandler(this.KryptonButtonOrbitalEccentricity_Click);
			this.kryptonButtonOrbitalEccentricity.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonOrbitalEccentricity.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonMeanDailyMotion
			// 
			this.kryptonButtonMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion (degrees per day)";
			this.kryptonButtonMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion (degrees per day)";
			this.kryptonButtonMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonMeanDailyMotion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonMeanDailyMotion.CornerRoundingRadius = -1F;
			this.kryptonButtonMeanDailyMotion.Location = new System.Drawing.Point(12, 260);
			this.kryptonButtonMeanDailyMotion.Name = "kryptonButtonMeanDailyMotion";
			this.kryptonButtonMeanDailyMotion.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonMeanDailyMotion.TabIndex = 8;
			this.toolTip.SetToolTip(this.kryptonButtonMeanDailyMotion, "Mean daily motion (degrees per day)");
			this.kryptonButtonMeanDailyMotion.Values.Text = "Mean daily motion (°/day)";
			this.kryptonButtonMeanDailyMotion.Click += new System.EventHandler(this.KryptonButtonMeanDailyMotion_Click);
			this.kryptonButtonMeanDailyMotion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonMeanDailyMotion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonSemimajorAxis
			// 
			this.kryptonButtonSemimajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis (AU)";
			this.kryptonButtonSemimajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis (AU)";
			this.kryptonButtonSemimajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonSemimajorAxis.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonSemimajorAxis.CornerRoundingRadius = -1F;
			this.kryptonButtonSemimajorAxis.Location = new System.Drawing.Point(12, 291);
			this.kryptonButtonSemimajorAxis.Name = "kryptonButtonSemimajorAxis";
			this.kryptonButtonSemimajorAxis.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonSemimajorAxis.TabIndex = 9;
			this.toolTip.SetToolTip(this.kryptonButtonSemimajorAxis, "Semi-major axis (AU)");
			this.kryptonButtonSemimajorAxis.Values.Text = "Semi-major axis (AU)";
			this.kryptonButtonSemimajorAxis.Click += new System.EventHandler(this.KryptonButtonSemimajorAxis_Click);
			this.kryptonButtonSemimajorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonSemimajorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonSemimajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonSemimajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonAbsoluteMagnitude
			// 
			this.kryptonButtonAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude, H";
			this.kryptonButtonAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude, H";
			this.kryptonButtonAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonAbsoluteMagnitude.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonAbsoluteMagnitude.CornerRoundingRadius = -1F;
			this.kryptonButtonAbsoluteMagnitude.Location = new System.Drawing.Point(280, 12);
			this.kryptonButtonAbsoluteMagnitude.Name = "kryptonButtonAbsoluteMagnitude";
			this.kryptonButtonAbsoluteMagnitude.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonAbsoluteMagnitude.TabIndex = 10;
			this.toolTip.SetToolTip(this.kryptonButtonAbsoluteMagnitude, "Absolute magnitude, H");
			this.kryptonButtonAbsoluteMagnitude.Values.Text = "Absolute magnitude, H";
			this.kryptonButtonAbsoluteMagnitude.Click += new System.EventHandler(this.KryptonButtonAbsoluteMagnitude_Click);
			this.kryptonButtonAbsoluteMagnitude.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonAbsoluteMagnitude.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonSlopeParameter
			// 
			this.kryptonButtonSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter, G";
			this.kryptonButtonSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter, G";
			this.kryptonButtonSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonSlopeParameter.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonSlopeParameter.CornerRoundingRadius = -1F;
			this.kryptonButtonSlopeParameter.Location = new System.Drawing.Point(280, 43);
			this.kryptonButtonSlopeParameter.Name = "kryptonButtonSlopeParameter";
			this.kryptonButtonSlopeParameter.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonSlopeParameter.TabIndex = 11;
			this.toolTip.SetToolTip(this.kryptonButtonSlopeParameter, "Slope parameter, G");
			this.kryptonButtonSlopeParameter.Values.Text = "Slope parameter, G";
			this.kryptonButtonSlopeParameter.Click += new System.EventHandler(this.KryptonButtonSlopeParameter_Click);
			this.kryptonButtonSlopeParameter.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonSlopeParameter.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonReference
			// 
			this.kryptonButtonReference.AccessibleDescription = "Copy to clipboard: Reference";
			this.kryptonButtonReference.AccessibleName = "Copy to clipboard: Reference";
			this.kryptonButtonReference.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonReference.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonReference.CornerRoundingRadius = -1F;
			this.kryptonButtonReference.Location = new System.Drawing.Point(280, 74);
			this.kryptonButtonReference.Name = "kryptonButtonReference";
			this.kryptonButtonReference.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonReference.TabIndex = 12;
			this.toolTip.SetToolTip(this.kryptonButtonReference, "Reference");
			this.kryptonButtonReference.Values.Text = "Reference";
			this.kryptonButtonReference.Click += new System.EventHandler(this.KryptonButtonReference_Click);
			this.kryptonButtonReference.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonReference.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonReference.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonReference.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonObservationSpan
			// 
			this.kryptonButtonObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.kryptonButtonObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.kryptonButtonObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonObservationSpan.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonObservationSpan.CornerRoundingRadius = -1F;
			this.kryptonButtonObservationSpan.Location = new System.Drawing.Point(280, 167);
			this.kryptonButtonObservationSpan.Name = "kryptonButtonObservationSpan";
			this.kryptonButtonObservationSpan.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonObservationSpan.TabIndex = 15;
			this.toolTip.SetToolTip(this.kryptonButtonObservationSpan, "Observation span");
			this.kryptonButtonObservationSpan.Values.Text = "Observation span";
			this.kryptonButtonObservationSpan.Click += new System.EventHandler(this.KryptonButtonObservationSpan_Click);
			this.kryptonButtonObservationSpan.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonObservationSpan.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonObservationSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonObservationSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonNumberOfObservations
			// 
			this.kryptonButtonNumberOfObservations.AccessibleDescription = "Copy to clipboard: Number of observations";
			this.kryptonButtonNumberOfObservations.AccessibleName = "Copy to clipboard: Number of observations";
			this.kryptonButtonNumberOfObservations.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonNumberOfObservations.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonNumberOfObservations.CornerRoundingRadius = -1F;
			this.kryptonButtonNumberOfObservations.Location = new System.Drawing.Point(280, 136);
			this.kryptonButtonNumberOfObservations.Name = "kryptonButtonNumberOfObservations";
			this.kryptonButtonNumberOfObservations.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonNumberOfObservations.TabIndex = 14;
			this.toolTip.SetToolTip(this.kryptonButtonNumberOfObservations, "Number of observations");
			this.kryptonButtonNumberOfObservations.Values.Text = "Number of observations";
			this.kryptonButtonNumberOfObservations.Click += new System.EventHandler(this.KryptonButtonNumberOfObservations_Click);
			this.kryptonButtonNumberOfObservations.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonNumberOfObservations.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonNumberOfObservations.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonNumberOfObservations.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonNumberOfOppositions
			// 
			this.kryptonButtonNumberOfOppositions.AccessibleDescription = "Copy to clipboard: Number of oppositions";
			this.kryptonButtonNumberOfOppositions.AccessibleName = "Copy to clipboard: Number of oppositions";
			this.kryptonButtonNumberOfOppositions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonNumberOfOppositions.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonNumberOfOppositions.CornerRoundingRadius = -1F;
			this.kryptonButtonNumberOfOppositions.Location = new System.Drawing.Point(280, 105);
			this.kryptonButtonNumberOfOppositions.Name = "kryptonButtonNumberOfOppositions";
			this.kryptonButtonNumberOfOppositions.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonNumberOfOppositions.TabIndex = 13;
			this.toolTip.SetToolTip(this.kryptonButtonNumberOfOppositions, "Number of oppositions");
			this.kryptonButtonNumberOfOppositions.Values.Text = "Number of oppositions";
			this.kryptonButtonNumberOfOppositions.Click += new System.EventHandler(this.KryptonButtonNumberOfOppositions_Click);
			this.kryptonButtonNumberOfOppositions.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonNumberOfOppositions.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonFlags
			// 
			this.kryptonButtonFlags.AccessibleDescription = "Copy to clipboard: 4-hexdigit flags";
			this.kryptonButtonFlags.AccessibleName = "Copy to clipboard: 4-hexdigit flags";
			this.kryptonButtonFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonFlags.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonFlags.CornerRoundingRadius = -1F;
			this.kryptonButtonFlags.Location = new System.Drawing.Point(280, 260);
			this.kryptonButtonFlags.Name = "kryptonButtonFlags";
			this.kryptonButtonFlags.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonFlags.TabIndex = 18;
			this.toolTip.SetToolTip(this.kryptonButtonFlags, "4-hexdigit flags");
			this.kryptonButtonFlags.Values.Text = "4-hexdigit flags";
			this.kryptonButtonFlags.Click += new System.EventHandler(this.KryptonButtonFlags_Click);
			this.kryptonButtonFlags.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonFlags.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonFlags.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonFlags.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonComputername
			// 
			this.kryptonButtonComputername.AccessibleDescription = "Copy to clipboard: Computer name";
			this.kryptonButtonComputername.AccessibleName = "Copy to clipboard: Computer name";
			this.kryptonButtonComputername.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonComputername.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonComputername.CornerRoundingRadius = -1F;
			this.kryptonButtonComputername.Location = new System.Drawing.Point(280, 229);
			this.kryptonButtonComputername.Name = "kryptonButtonComputername";
			this.kryptonButtonComputername.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonComputername.TabIndex = 17;
			this.toolTip.SetToolTip(this.kryptonButtonComputername, "Computer name");
			this.kryptonButtonComputername.Values.Text = "Computer name";
			this.kryptonButtonComputername.Click += new System.EventHandler(this.KryptonButtonComputername_Click);
			this.kryptonButtonComputername.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonComputername.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonComputername.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonComputername.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonRmsResidual
			// 
			this.kryptonButtonRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual (\")";
			this.kryptonButtonRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual (\")";
			this.kryptonButtonRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonRmsResidual.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonRmsResidual.CornerRoundingRadius = -1F;
			this.kryptonButtonRmsResidual.Location = new System.Drawing.Point(280, 198);
			this.kryptonButtonRmsResidual.Name = "kryptonButtonRmsResidual";
			this.kryptonButtonRmsResidual.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonRmsResidual.TabIndex = 16;
			this.toolTip.SetToolTip(this.kryptonButtonRmsResidual, "r.m.s. residual (\")");
			this.kryptonButtonRmsResidual.Values.Text = "r.m.s. residual (\")";
			this.kryptonButtonRmsResidual.Click += new System.EventHandler(this.KryptonButtonRmsResidual_Click);
			this.kryptonButtonRmsResidual.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonRmsResidual.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonDateOfLastObservation
			// 
			this.kryptonButtonDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation (YYYMMDD)";
			this.kryptonButtonDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation (YYYMMDD)";
			this.kryptonButtonDateOfLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonDateOfLastObservation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.kryptonButtonDateOfLastObservation.CornerRoundingRadius = -1F;
			this.kryptonButtonDateOfLastObservation.Location = new System.Drawing.Point(280, 291);
			this.kryptonButtonDateOfLastObservation.Name = "kryptonButtonDateOfLastObservation";
			this.kryptonButtonDateOfLastObservation.Size = new System.Drawing.Size(262, 25);
			this.kryptonButtonDateOfLastObservation.TabIndex = 19;
			this.toolTip.SetToolTip(this.kryptonButtonDateOfLastObservation, "Date of last observation (YYYMMDD)");
			this.kryptonButtonDateOfLastObservation.Values.Text = "Date of last observation (YYYMMDD)";
			this.kryptonButtonDateOfLastObservation.Click += new System.EventHandler(this.KryptonButtonDateOfLastObservation_Click);
			this.kryptonButtonDateOfLastObservation.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonDateOfLastObservation.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonDateOfLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonDateOfLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.kryptonPanel.Controls.Add(this.kryptonStatusStrip);
			this.kryptonPanel.Controls.Add(this.kryptonButtonDateOfLastObservation);
			this.kryptonPanel.Controls.Add(this.kryptonButtonFlags);
			this.kryptonPanel.Controls.Add(this.kryptonButtonComputername);
			this.kryptonPanel.Controls.Add(this.kryptonButtonRmsResidual);
			this.kryptonPanel.Controls.Add(this.kryptonButtonObservationSpan);
			this.kryptonPanel.Controls.Add(this.kryptonButtonNumberOfObservations);
			this.kryptonPanel.Controls.Add(this.kryptonButtonNumberOfOppositions);
			this.kryptonPanel.Controls.Add(this.kryptonButtonReference);
			this.kryptonPanel.Controls.Add(this.kryptonButtonSlopeParameter);
			this.kryptonPanel.Controls.Add(this.kryptonButtonAbsoluteMagnitude);
			this.kryptonPanel.Controls.Add(this.kryptonButtonSemimajorAxis);
			this.kryptonPanel.Controls.Add(this.kryptonButtonMeanDailyMotion);
			this.kryptonPanel.Controls.Add(this.kryptonButtonOrbitalEccentricity);
			this.kryptonPanel.Controls.Add(this.kryptonButtonInclination);
			this.kryptonPanel.Controls.Add(this.kryptonButtonArgumentOfPerihelion);
			this.kryptonPanel.Controls.Add(this.kryptonButtonLongitudeOfTheAscendingNode);
			this.kryptonPanel.Controls.Add(this.kryptonButtonEpoch);
			this.kryptonPanel.Controls.Add(this.kryptonButtonMeanAnomaly);
			this.kryptonPanel.Controls.Add(this.kryptonButtonIndexNumber);
			this.kryptonPanel.Controls.Add(this.kryptonButtonReadableDesignation);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(552, 346);
			this.kryptonPanel.TabIndex = 0;
			this.kryptonPanel.TabStop = true;
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 324);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(552, 22);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 20;
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
			this.labelInformation.Size = new System.Drawing.Size(144, 17);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// CopyDataToClipboardForm
			// 
			this.AccessibleDescription = "Copy data to clipboard";
			this.AccessibleName = "Copy data to clipboard";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 346);
			this.Controls.Add(this.kryptonPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CopyDataToClipboardForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Copy data to clipboard";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CopyDataToClipboardForm_FormClosed);
			this.Load += new System.EventHandler(this.CopyDataToClipboardForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonButton kryptonButtonIndexNumber;
		private System.Windows.Forms.ToolTip toolTip;
		private Krypton.Toolkit.KryptonButton kryptonButtonReadableDesignation;
		private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private Krypton.Toolkit.KryptonButton kryptonButtonArgumentOfPerihelion;
		private Krypton.Toolkit.KryptonButton kryptonButtonLongitudeOfTheAscendingNode;
		private Krypton.Toolkit.KryptonButton kryptonButtonEpoch;
		private Krypton.Toolkit.KryptonButton kryptonButtonMeanAnomaly;
		private Krypton.Toolkit.KryptonButton kryptonButtonReference;
		private Krypton.Toolkit.KryptonButton kryptonButtonSlopeParameter;
		private Krypton.Toolkit.KryptonButton kryptonButtonAbsoluteMagnitude;
		private Krypton.Toolkit.KryptonButton kryptonButtonSemimajorAxis;
		private Krypton.Toolkit.KryptonButton kryptonButtonMeanDailyMotion;
		private Krypton.Toolkit.KryptonButton kryptonButtonOrbitalEccentricity;
		private Krypton.Toolkit.KryptonButton kryptonButtonInclination;
		private Krypton.Toolkit.KryptonButton kryptonButtonDateOfLastObservation;
		private Krypton.Toolkit.KryptonButton kryptonButtonFlags;
		private Krypton.Toolkit.KryptonButton kryptonButtonComputername;
		private Krypton.Toolkit.KryptonButton kryptonButtonRmsResidual;
		private Krypton.Toolkit.KryptonButton kryptonButtonObservationSpan;
		private Krypton.Toolkit.KryptonButton kryptonButtonNumberOfObservations;
		private Krypton.Toolkit.KryptonButton kryptonButtonNumberOfOppositions;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}