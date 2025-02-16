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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsSelectionForm));
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.checkButtonRecordSortDirectionDescending = new Krypton.Toolkit.KryptonCheckButton();
			this.checkButtonRecordSortDirectionAscending = new Krypton.Toolkit.KryptonCheckButton();
			this.buttonDateOfLastObservation = new Krypton.Toolkit.KryptonButton();
			this.buttonComputerName = new Krypton.Toolkit.KryptonButton();
			this.buttonRmsResidual = new Krypton.Toolkit.KryptonButton();
			this.buttonObservationSpan = new Krypton.Toolkit.KryptonButton();
			this.buttonNumberOfObservations = new Krypton.Toolkit.KryptonButton();
			this.buttonNumberOfOppositions = new Krypton.Toolkit.KryptonButton();
			this.buttonSlopeParameter = new Krypton.Toolkit.KryptonButton();
			this.buttonAbsoluteMagnitude = new Krypton.Toolkit.KryptonButton();
			this.buttonSemiMajorAxis = new Krypton.Toolkit.KryptonButton();
			this.buttonMeanDailyMotion = new Krypton.Toolkit.KryptonButton();
			this.buttonOrbitalEccentricity = new Krypton.Toolkit.KryptonButton();
			this.buttonInclination = new Krypton.Toolkit.KryptonButton();
			this.buttonArgumentOfPerihelion = new Krypton.Toolkit.KryptonButton();
			this.buttonLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonButton();
			this.buttonMeanAnomaly = new Krypton.Toolkit.KryptonButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the buttons";
			this.panel.AccessibleName = "Groups the buttons";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.checkButtonRecordSortDirectionDescending);
			this.panel.Controls.Add(this.checkButtonRecordSortDirectionAscending);
			this.panel.Controls.Add(this.buttonDateOfLastObservation);
			this.panel.Controls.Add(this.buttonComputerName);
			this.panel.Controls.Add(this.buttonRmsResidual);
			this.panel.Controls.Add(this.buttonObservationSpan);
			this.panel.Controls.Add(this.buttonNumberOfObservations);
			this.panel.Controls.Add(this.buttonNumberOfOppositions);
			this.panel.Controls.Add(this.buttonSlopeParameter);
			this.panel.Controls.Add(this.buttonAbsoluteMagnitude);
			this.panel.Controls.Add(this.buttonSemiMajorAxis);
			this.panel.Controls.Add(this.buttonMeanDailyMotion);
			this.panel.Controls.Add(this.buttonOrbitalEccentricity);
			this.panel.Controls.Add(this.buttonInclination);
			this.panel.Controls.Add(this.buttonArgumentOfPerihelion);
			this.panel.Controls.Add(this.buttonLongitudeOfTheAscendingNode);
			this.panel.Controls.Add(this.buttonMeanAnomaly);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.panel.Size = new System.Drawing.Size(556, 285);
			this.panel.TabIndex = 3;
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
			this.statusStrip.Location = new System.Drawing.Point(0, 263);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(556, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 22;
			this.statusStrip.Text = "status bar";
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
			// checkButtonRecordSortDirectionDescending
			// 
			this.checkButtonRecordSortDirectionDescending.AccessibleDescription = "Selects the descending sort direction";
			this.checkButtonRecordSortDirectionDescending.AccessibleName = "Sorted descending";
			this.checkButtonRecordSortDirectionDescending.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.checkButtonRecordSortDirectionDescending.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.checkButtonRecordSortDirectionDescending.Location = new System.Drawing.Point(417, 229);
			this.checkButtonRecordSortDirectionDescending.Name = "checkButtonRecordSortDirectionDescending";
			this.checkButtonRecordSortDirectionDescending.Size = new System.Drawing.Size(125, 25);
			this.checkButtonRecordSortDirectionDescending.TabIndex = 21;
			this.toolTip.SetToolTip(this.checkButtonRecordSortDirectionDescending, "Sorted descending");
			this.checkButtonRecordSortDirectionDescending.Values.Text = "Sorted &descending";
			this.checkButtonRecordSortDirectionDescending.Click += new System.EventHandler(this.CheckButtonRecordSortDirectionDescending_Click);
			this.checkButtonRecordSortDirectionDescending.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkButtonRecordSortDirectionDescending.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkButtonRecordSortDirectionDescending.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkButtonRecordSortDirectionDescending.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// checkButtonRecordSortDirectionAscending
			// 
			this.checkButtonRecordSortDirectionAscending.AccessibleDescription = "Selects the ascending sort direction";
			this.checkButtonRecordSortDirectionAscending.AccessibleName = "Sorted ascending";
			this.checkButtonRecordSortDirectionAscending.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.checkButtonRecordSortDirectionAscending.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.checkButtonRecordSortDirectionAscending.Checked = true;
			this.checkButtonRecordSortDirectionAscending.Location = new System.Drawing.Point(280, 229);
			this.checkButtonRecordSortDirectionAscending.Name = "checkButtonRecordSortDirectionAscending";
			this.checkButtonRecordSortDirectionAscending.Size = new System.Drawing.Size(125, 25);
			this.checkButtonRecordSortDirectionAscending.TabIndex = 20;
			this.toolTip.SetToolTip(this.checkButtonRecordSortDirectionAscending, "Sorted ascending");
			this.checkButtonRecordSortDirectionAscending.Values.Text = "Sorted &ascending";
			this.checkButtonRecordSortDirectionAscending.Click += new System.EventHandler(this.CheckButtonRecordSortDirectionAscending_Click);
			this.checkButtonRecordSortDirectionAscending.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkButtonRecordSortDirectionAscending.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkButtonRecordSortDirectionAscending.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkButtonRecordSortDirectionAscending.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDateOfLastObservation
			// 
			this.buttonDateOfLastObservation.AccessibleDescription = "Copy to clipboard: Date of last observation (YYYMMDD)";
			this.buttonDateOfLastObservation.AccessibleName = "Copy to clipboard: Date of last observation (YYYMMDD)";
			this.buttonDateOfLastObservation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDateOfLastObservation.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonDateOfLastObservation.Location = new System.Drawing.Point(280, 198);
			this.buttonDateOfLastObservation.Name = "buttonDateOfLastObservation";
			this.buttonDateOfLastObservation.Size = new System.Drawing.Size(262, 25);
			this.buttonDateOfLastObservation.TabIndex = 19;
			this.toolTip.SetToolTip(this.buttonDateOfLastObservation, "Copy to clipboard: Date of last observation (YYYMMDD)");
			this.buttonDateOfLastObservation.Values.Text = "Date of last obser&vation (YYYMMDD)";
			this.buttonDateOfLastObservation.Click += new System.EventHandler(this.ButtonDateOfLastObservation_Click);
			this.buttonDateOfLastObservation.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDateOfLastObservation.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDateOfLastObservation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDateOfLastObservation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonComputerName
			// 
			this.buttonComputerName.AccessibleDescription = "Copy to clipboard: Computer name";
			this.buttonComputerName.AccessibleName = "Copy to clipboard: Computer name";
			this.buttonComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonComputerName.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonComputerName.Location = new System.Drawing.Point(280, 167);
			this.buttonComputerName.Name = "buttonComputerName";
			this.buttonComputerName.Size = new System.Drawing.Size(262, 25);
			this.buttonComputerName.TabIndex = 17;
			this.toolTip.SetToolTip(this.buttonComputerName, "Copy to clipboard: Computer name");
			this.buttonComputerName.Values.Text = "&Computer name";
			this.buttonComputerName.Click += new System.EventHandler(this.ButtonComputername_Click);
			this.buttonComputerName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonComputerName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonComputerName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonComputerName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonRmsResidual
			// 
			this.buttonRmsResidual.AccessibleDescription = "Copy to clipboard: r.m.s. residual (\")";
			this.buttonRmsResidual.AccessibleName = "Copy to clipboard: r.m.s. residual (\")";
			this.buttonRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonRmsResidual.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonRmsResidual.Location = new System.Drawing.Point(280, 136);
			this.buttonRmsResidual.Name = "buttonRmsResidual";
			this.buttonRmsResidual.Size = new System.Drawing.Size(262, 25);
			this.buttonRmsResidual.TabIndex = 16;
			this.toolTip.SetToolTip(this.buttonRmsResidual, "Copy to clipboard: r.m.s. residual (\")");
			this.buttonRmsResidual.Values.Text = "r.m.s. &residual (\")";
			this.buttonRmsResidual.Click += new System.EventHandler(this.ButtonRmsResidual_Click);
			this.buttonRmsResidual.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonRmsResidual.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonRmsResidual.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonRmsResidual.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonObservationSpan
			// 
			this.buttonObservationSpan.AccessibleDescription = "Copy to clipboard: Observation span";
			this.buttonObservationSpan.AccessibleName = "Copy to clipboard: Observation span";
			this.buttonObservationSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonObservationSpan.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonObservationSpan.Location = new System.Drawing.Point(280, 105);
			this.buttonObservationSpan.Name = "buttonObservationSpan";
			this.buttonObservationSpan.Size = new System.Drawing.Size(262, 25);
			this.buttonObservationSpan.TabIndex = 15;
			this.toolTip.SetToolTip(this.buttonObservationSpan, "Copy to clipboard: Observation span");
			this.buttonObservationSpan.Values.Text = "Obser&vation span";
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
			this.buttonNumberOfObservations.Location = new System.Drawing.Point(280, 74);
			this.buttonNumberOfObservations.Name = "buttonNumberOfObservations";
			this.buttonNumberOfObservations.Size = new System.Drawing.Size(262, 25);
			this.buttonNumberOfObservations.TabIndex = 14;
			this.toolTip.SetToolTip(this.buttonNumberOfObservations, "Copy to clipboard: Number of observations");
			this.buttonNumberOfObservations.Values.Text = "Number of o&bservations";
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
			this.buttonNumberOfOppositions.Location = new System.Drawing.Point(280, 43);
			this.buttonNumberOfOppositions.Name = "buttonNumberOfOppositions";
			this.buttonNumberOfOppositions.Size = new System.Drawing.Size(262, 25);
			this.buttonNumberOfOppositions.TabIndex = 13;
			this.toolTip.SetToolTip(this.buttonNumberOfOppositions, "Copy to clipboard: Number of oppositions");
			this.buttonNumberOfOppositions.Values.Text = "Number of &oppositions";
			this.buttonNumberOfOppositions.Click += new System.EventHandler(this.ButtonNumberOfOppositions_Click);
			this.buttonNumberOfOppositions.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonNumberOfOppositions.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonNumberOfOppositions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonNumberOfOppositions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSlopeParameter
			// 
			this.buttonSlopeParameter.AccessibleDescription = "Copy to clipboard: Slope parameter, G";
			this.buttonSlopeParameter.AccessibleName = "Copy to clipboard: Slope parameter, G";
			this.buttonSlopeParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSlopeParameter.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonSlopeParameter.Location = new System.Drawing.Point(280, 12);
			this.buttonSlopeParameter.Name = "buttonSlopeParameter";
			this.buttonSlopeParameter.Size = new System.Drawing.Size(262, 25);
			this.buttonSlopeParameter.TabIndex = 11;
			this.toolTip.SetToolTip(this.buttonSlopeParameter, "Copy to clipboard: Slope parameter, G");
			this.buttonSlopeParameter.Values.Text = "Slope pa&rameter, G";
			this.buttonSlopeParameter.Click += new System.EventHandler(this.ButtonSlopeParameter_Click);
			this.buttonSlopeParameter.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSlopeParameter.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSlopeParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSlopeParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonAbsoluteMagnitude
			// 
			this.buttonAbsoluteMagnitude.AccessibleDescription = "Copy to clipboard: Absolute magnitude, H";
			this.buttonAbsoluteMagnitude.AccessibleName = "Copy to clipboard: Absolute magnitude, H";
			this.buttonAbsoluteMagnitude.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonAbsoluteMagnitude.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonAbsoluteMagnitude.Location = new System.Drawing.Point(12, 229);
			this.buttonAbsoluteMagnitude.Name = "buttonAbsoluteMagnitude";
			this.buttonAbsoluteMagnitude.Size = new System.Drawing.Size(262, 25);
			this.buttonAbsoluteMagnitude.TabIndex = 10;
			this.toolTip.SetToolTip(this.buttonAbsoluteMagnitude, "Copy to clipboard: Absolute magnitude, H");
			this.buttonAbsoluteMagnitude.Values.Text = "Absolute ma&gnitude, H";
			this.buttonAbsoluteMagnitude.Click += new System.EventHandler(this.ButtonAbsoluteMagnitude_Click);
			this.buttonAbsoluteMagnitude.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonAbsoluteMagnitude.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonAbsoluteMagnitude.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonAbsoluteMagnitude.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSemiMajorAxis
			// 
			this.buttonSemiMajorAxis.AccessibleDescription = "Copy to clipboard: Semi-major axis (AU)";
			this.buttonSemiMajorAxis.AccessibleName = "Copy to clipboard: Semi-major axis (AU)";
			this.buttonSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSemiMajorAxis.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonSemiMajorAxis.Location = new System.Drawing.Point(12, 198);
			this.buttonSemiMajorAxis.Name = "buttonSemiMajorAxis";
			this.buttonSemiMajorAxis.Size = new System.Drawing.Size(262, 25);
			this.buttonSemiMajorAxis.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonSemiMajorAxis, "Copy to clipboard: Semi-major axis (AU)");
			this.buttonSemiMajorAxis.Values.Text = "&Semi-major axis (AU)";
			this.buttonSemiMajorAxis.Click += new System.EventHandler(this.ButtonSemiMajorAxis_Click);
			this.buttonSemiMajorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSemiMajorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSemiMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSemiMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonMeanDailyMotion
			// 
			this.buttonMeanDailyMotion.AccessibleDescription = "Copy to clipboard: Mean daily motion (degrees per day)";
			this.buttonMeanDailyMotion.AccessibleName = "Copy to clipboard: Mean daily motion (degrees per day)";
			this.buttonMeanDailyMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonMeanDailyMotion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonMeanDailyMotion.Location = new System.Drawing.Point(12, 167);
			this.buttonMeanDailyMotion.Name = "buttonMeanDailyMotion";
			this.buttonMeanDailyMotion.Size = new System.Drawing.Size(262, 25);
			this.buttonMeanDailyMotion.TabIndex = 8;
			this.toolTip.SetToolTip(this.buttonMeanDailyMotion, "Copy to clipboard: Mean daily motion (degrees per day)");
			this.buttonMeanDailyMotion.Values.Text = "Mean daily &motion (°/day)";
			this.buttonMeanDailyMotion.Click += new System.EventHandler(this.ButtonMeanDailyMotion_Click);
			this.buttonMeanDailyMotion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanDailyMotion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonMeanDailyMotion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanDailyMotion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonOrbitalEccentricity
			// 
			this.buttonOrbitalEccentricity.AccessibleDescription = "Copy to clipboard: Orbital eccentricity";
			this.buttonOrbitalEccentricity.AccessibleName = "Copy to clipboard: Orbital eccentricity";
			this.buttonOrbitalEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOrbitalEccentricity.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonOrbitalEccentricity.Location = new System.Drawing.Point(12, 136);
			this.buttonOrbitalEccentricity.Name = "buttonOrbitalEccentricity";
			this.buttonOrbitalEccentricity.Size = new System.Drawing.Size(262, 25);
			this.buttonOrbitalEccentricity.TabIndex = 7;
			this.toolTip.SetToolTip(this.buttonOrbitalEccentricity, "Copy to clipboard: Orbital eccentricity");
			this.buttonOrbitalEccentricity.Values.Text = "Orbital &eccentricity";
			this.buttonOrbitalEccentricity.Click += new System.EventHandler(this.ButtonOrbitalEccentricity_Click);
			this.buttonOrbitalEccentricity.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOrbitalEccentricity.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOrbitalEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOrbitalEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonInclination
			// 
			this.buttonInclination.AccessibleDescription = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			this.buttonInclination.AccessibleName = "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)";
			this.buttonInclination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInclination.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonInclination.Location = new System.Drawing.Point(12, 105);
			this.buttonInclination.Name = "buttonInclination";
			this.buttonInclination.Size = new System.Drawing.Size(262, 25);
			this.buttonInclination.TabIndex = 6;
			this.toolTip.SetToolTip(this.buttonInclination, "Copy to clipboard: Inclination to the ecliptic, J2000.0 (degrees)");
			this.buttonInclination.Values.Text = "&Inclination to the ecliptic, J2000.0 (°)";
			this.buttonInclination.Click += new System.EventHandler(this.ButtonInclination_Click);
			this.buttonInclination.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInclination.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonInclination.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInclination.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonArgumentOfPerihelion
			// 
			this.buttonArgumentOfPerihelion.AccessibleDescription = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			this.buttonArgumentOfPerihelion.AccessibleName = "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)";
			this.buttonArgumentOfPerihelion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonArgumentOfPerihelion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonArgumentOfPerihelion.Location = new System.Drawing.Point(12, 43);
			this.buttonArgumentOfPerihelion.Name = "buttonArgumentOfPerihelion";
			this.buttonArgumentOfPerihelion.Size = new System.Drawing.Size(262, 25);
			this.buttonArgumentOfPerihelion.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonArgumentOfPerihelion, "Copy to clipboard: Argument of perihelion, J2000.0 (degrees)");
			this.buttonArgumentOfPerihelion.Values.Text = "Argument of peri&helion, J2000.0 (°)";
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
			this.buttonLongitudeOfTheAscendingNode.Location = new System.Drawing.Point(12, 74);
			this.buttonLongitudeOfTheAscendingNode.Name = "buttonLongitudeOfTheAscendingNode";
			this.buttonLongitudeOfTheAscendingNode.Size = new System.Drawing.Size(262, 25);
			this.buttonLongitudeOfTheAscendingNode.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonLongitudeOfTheAscendingNode, "Copy to clipboard: Longitude of the ascending node, J2000.0 (degrees)");
			this.buttonLongitudeOfTheAscendingNode.Values.Text = "&Longitude of the ascending node, J2000.0 (°)";
			this.buttonLongitudeOfTheAscendingNode.Click += new System.EventHandler(this.ButtonLongitudeOfTheAscendingNode_Click);
			this.buttonLongitudeOfTheAscendingNode.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLongitudeOfTheAscendingNode.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonLongitudeOfTheAscendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonLongitudeOfTheAscendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonMeanAnomaly
			// 
			this.buttonMeanAnomaly.AccessibleDescription = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			this.buttonMeanAnomaly.AccessibleName = "Copy to clipboard: Mean anomaly at the epoch (degrees)";
			this.buttonMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonMeanAnomaly.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			this.buttonMeanAnomaly.Location = new System.Drawing.Point(12, 12);
			this.buttonMeanAnomaly.Name = "buttonMeanAnomaly";
			this.buttonMeanAnomaly.Size = new System.Drawing.Size(262, 25);
			this.buttonMeanAnomaly.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonMeanAnomaly, "Copy to clipboard: Mean anomaly at the epoch (degrees)");
			this.buttonMeanAnomaly.Values.Text = "Mean anomal&y at the epoch (°)";
			this.buttonMeanAnomaly.Click += new System.EventHandler(this.ButtonMeanAnomaly_Click);
			this.buttonMeanAnomaly.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanAnomaly.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonMeanAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonMeanAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// RecordsSelectionForm
			// 
			this.AccessibleDescription = "Show the top ten records";
			this.AccessibleName = "Top ten records";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 285);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RecordsSelectionForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Top ten records";
			this.toolTip.SetToolTip(this, "Top ten records");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordsSelectionForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

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