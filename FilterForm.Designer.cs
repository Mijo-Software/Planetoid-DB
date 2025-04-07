namespace Planetoid_DB
{
	partial class FilterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
			panel = new Krypton.Toolkit.KryptonPanel();
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			buttonReset = new Krypton.Toolkit.KryptonButton();
			buttonCancel = new Krypton.Toolkit.KryptonButton();
			buttonApply = new Krypton.Toolkit.KryptonButton();
			tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			labelHeaderReset = new Krypton.Toolkit.KryptonLabel();
			labelHeaderMaximum = new Krypton.Toolkit.KryptonLabel();
			labelHeaderMinimum = new Krypton.Toolkit.KryptonLabel();
			buttonResetRmsResidual = new Krypton.Toolkit.KryptonButton();
			buttonResetNumberOfObservations = new Krypton.Toolkit.KryptonButton();
			buttonNumberOfOppositions = new Krypton.Toolkit.KryptonButton();
			buttonResetSlopeParameter = new Krypton.Toolkit.KryptonButton();
			buttonResetAbsoluteMagnitude = new Krypton.Toolkit.KryptonButton();
			buttonResetSemiMajorAxis = new Krypton.Toolkit.KryptonButton();
			buttonResetMeanDailyMotion = new Krypton.Toolkit.KryptonButton();
			buttonResetLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonButton();
			buttonResetArgumentOfPerihelion = new Krypton.Toolkit.KryptonButton();
			buttonResetMeanAnomalyAtTheEpoch = new Krypton.Toolkit.KryptonButton();
			numericUpDownMaximumRmsResidual = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumNumberOfObservations = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumNumberOfOppositions = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumSlopeParameter = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumAbsoluteMagnitude = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumSemiMajorAxis = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumMeanDailyMotion = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumOrbitalEccentricity = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumInclination = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumArgumentOfPerihelion = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMaximumMeanAnomalyAtTheEpoch = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumRmsResidual = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumNumberOfObservations = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumNumberOfOppositions = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumSlopeParameter = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumAbsoluteMagnitude = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumSemiMajorAxis = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumMeanDailyMotion = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumOrbitalEccentricity = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumInclination = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonNumericUpDown();
			numericUpDownMinimumArgumentOfPerihelion = new Krypton.Toolkit.KryptonNumericUpDown();
			labelArgumentOfPerihelion = new Krypton.Toolkit.KryptonLabel();
			numericUpDownMinimumMeanAnomalyAtTheEpoch = new Krypton.Toolkit.KryptonNumericUpDown();
			labelRmsResidual = new Krypton.Toolkit.KryptonLabel();
			labelLongitudeOfTheAscendingNode = new Krypton.Toolkit.KryptonLabel();
			labelNumberOfObservations = new Krypton.Toolkit.KryptonLabel();
			labelInclination = new Krypton.Toolkit.KryptonLabel();
			labelNumberOfOppositions = new Krypton.Toolkit.KryptonLabel();
			labelOrbitalEccentricity = new Krypton.Toolkit.KryptonLabel();
			labelSlopeParameter = new Krypton.Toolkit.KryptonLabel();
			labelMeanDailyMotion = new Krypton.Toolkit.KryptonLabel();
			labelAbsoluteMagnitude = new Krypton.Toolkit.KryptonLabel();
			labelSemiMajorAxis = new Krypton.Toolkit.KryptonLabel();
			labelMeanAnomalyAtTheEpoch = new Krypton.Toolkit.KryptonLabel();
			buttonResetInclination = new Krypton.Toolkit.KryptonButton();
			buttonResetOrbitalEccentricity = new Krypton.Toolkit.KryptonButton();
			labelHeaderElement = new Krypton.Toolkit.KryptonLabel();
			toolTip = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			statusStrip.SuspendLayout();
			tableLayoutPanel.SuspendLayout();
			SuspendLayout();
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(statusStrip);
			panel.Controls.Add(buttonReset);
			panel.Controls.Add(buttonCancel);
			panel.Controls.Add(buttonApply);
			panel.Controls.Add(tableLayoutPanel);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Margin = new Padding(4, 3, 4, 3);
			panel.Name = "panel";
			panel.Size = new Size(603, 482);
			panel.TabIndex = 0;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 460);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(603, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 4;
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
			// buttonReset
			// 
			buttonReset.AccessibleDescription = "Resets the filter settings";
			buttonReset.AccessibleName = "Reset the filter settings";
			buttonReset.AccessibleRole = AccessibleRole.PushButton;
			buttonReset.Location = new Point(336, 416);
			buttonReset.Margin = new Padding(4, 3, 4, 3);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(105, 29);
			buttonReset.TabIndex = 3;
			toolTip.SetToolTip(buttonReset, "Reset the filter settings");
			buttonReset.Values.DropDownArrowColor = Color.Empty;
			buttonReset.Values.Image = Properties.Resources.silk_reload;
			buttonReset.Values.Text = "&Reset all";
			buttonReset.Click += ButtonReset_Click;
			buttonReset.Enter += SetStatusbar_Enter;
			buttonReset.Leave += ClearStatusbar_Leave;
			buttonReset.MouseEnter += SetStatusbar_Enter;
			buttonReset.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCancel
			// 
			buttonCancel.AccessibleDescription = "Cancels the filter settings";
			buttonCancel.AccessibleName = "Cancel the filter settings";
			buttonCancel.AccessibleRole = AccessibleRole.PushButton;
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Location = new Point(224, 416);
			buttonCancel.Margin = new Padding(4, 3, 4, 3);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(105, 29);
			buttonCancel.TabIndex = 2;
			toolTip.SetToolTip(buttonCancel, "Cancel the filter settings");
			buttonCancel.Values.DropDownArrowColor = Color.Empty;
			buttonCancel.Values.Image = Properties.Resources.silk_cancel;
			buttonCancel.Values.Text = "&Cancel";
			buttonCancel.Click += ButtonCancel_Click;
			buttonCancel.Enter += SetStatusbar_Enter;
			buttonCancel.Leave += ClearStatusbar_Leave;
			buttonCancel.MouseEnter += SetStatusbar_Enter;
			buttonCancel.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonApply
			// 
			buttonApply.AccessibleDescription = "Applys the filter settings";
			buttonApply.AccessibleName = "Apply the filter settings";
			buttonApply.AccessibleRole = AccessibleRole.PushButton;
			buttonApply.DialogResult = DialogResult.OK;
			buttonApply.Location = new Point(112, 416);
			buttonApply.Margin = new Padding(4, 3, 4, 3);
			buttonApply.Name = "buttonApply";
			buttonApply.Size = new Size(105, 29);
			buttonApply.TabIndex = 1;
			toolTip.SetToolTip(buttonApply, "Apply the filter settings");
			buttonApply.Values.DropDownArrowColor = Color.Empty;
			buttonApply.Values.Image = Properties.Resources.silk_accept;
			buttonApply.Values.Text = "&Apply";
			buttonApply.Click += ButtonApply_Click;
			buttonApply.Enter += SetStatusbar_Enter;
			buttonApply.Leave += ClearStatusbar_Leave;
			buttonApply.MouseEnter += SetStatusbar_Enter;
			buttonApply.MouseLeave += ClearStatusbar_Leave;
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Groups the data";
			tableLayoutPanel.AccessibleName = "pane";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel.BackgroundImage");
			tableLayoutPanel.BackgroundImageLayout = ImageLayout.None;
			tableLayoutPanel.ColumnCount = 4;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.Controls.Add(labelHeaderReset, 3, 0);
			tableLayoutPanel.Controls.Add(labelHeaderMaximum, 2, 0);
			tableLayoutPanel.Controls.Add(labelHeaderMinimum, 1, 0);
			tableLayoutPanel.Controls.Add(buttonResetRmsResidual, 3, 13);
			tableLayoutPanel.Controls.Add(buttonResetNumberOfObservations, 3, 12);
			tableLayoutPanel.Controls.Add(buttonNumberOfOppositions, 3, 11);
			tableLayoutPanel.Controls.Add(buttonResetSlopeParameter, 3, 10);
			tableLayoutPanel.Controls.Add(buttonResetAbsoluteMagnitude, 3, 9);
			tableLayoutPanel.Controls.Add(buttonResetSemiMajorAxis, 3, 8);
			tableLayoutPanel.Controls.Add(buttonResetMeanDailyMotion, 3, 7);
			tableLayoutPanel.Controls.Add(buttonResetLongitudeOfTheAscendingNode, 3, 4);
			tableLayoutPanel.Controls.Add(buttonResetArgumentOfPerihelion, 3, 3);
			tableLayoutPanel.Controls.Add(buttonResetMeanAnomalyAtTheEpoch, 3, 2);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumRmsResidual, 2, 13);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumNumberOfObservations, 2, 12);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumNumberOfOppositions, 2, 11);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumSlopeParameter, 2, 10);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumAbsoluteMagnitude, 2, 9);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumSemiMajorAxis, 2, 8);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumMeanDailyMotion, 2, 7);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumOrbitalEccentricity, 2, 6);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumInclination, 2, 5);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumLongitudeOfTheAscendingNode, 2, 4);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumArgumentOfPerihelion, 2, 3);
			tableLayoutPanel.Controls.Add(numericUpDownMaximumMeanAnomalyAtTheEpoch, 2, 2);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumRmsResidual, 1, 13);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumNumberOfObservations, 1, 12);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumNumberOfOppositions, 1, 11);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumSlopeParameter, 1, 10);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumAbsoluteMagnitude, 1, 9);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumSemiMajorAxis, 1, 8);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumMeanDailyMotion, 1, 7);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumOrbitalEccentricity, 1, 6);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumInclination, 1, 5);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumLongitudeOfTheAscendingNode, 1, 4);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumArgumentOfPerihelion, 1, 3);
			tableLayoutPanel.Controls.Add(labelArgumentOfPerihelion, 0, 3);
			tableLayoutPanel.Controls.Add(numericUpDownMinimumMeanAnomalyAtTheEpoch, 1, 2);
			tableLayoutPanel.Controls.Add(labelRmsResidual, 0, 13);
			tableLayoutPanel.Controls.Add(labelLongitudeOfTheAscendingNode, 0, 4);
			tableLayoutPanel.Controls.Add(labelNumberOfObservations, 0, 12);
			tableLayoutPanel.Controls.Add(labelInclination, 0, 5);
			tableLayoutPanel.Controls.Add(labelNumberOfOppositions, 0, 11);
			tableLayoutPanel.Controls.Add(labelOrbitalEccentricity, 0, 6);
			tableLayoutPanel.Controls.Add(labelSlopeParameter, 0, 10);
			tableLayoutPanel.Controls.Add(labelMeanDailyMotion, 0, 7);
			tableLayoutPanel.Controls.Add(labelAbsoluteMagnitude, 0, 9);
			tableLayoutPanel.Controls.Add(labelSemiMajorAxis, 0, 8);
			tableLayoutPanel.Controls.Add(labelMeanAnomalyAtTheEpoch, 0, 2);
			tableLayoutPanel.Controls.Add(buttonResetInclination, 3, 5);
			tableLayoutPanel.Controls.Add(buttonResetOrbitalEccentricity, 3, 6);
			tableLayoutPanel.Controls.Add(labelHeaderElement, 0, 0);
			tableLayoutPanel.Location = new Point(4, 3);
			tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			tableLayoutPanel.RowCount = 14;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
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
			tableLayoutPanel.Size = new Size(595, 397);
			tableLayoutPanel.TabIndex = 0;
			// 
			// labelHeaderReset
			// 
			labelHeaderReset.AccessibleDescription = "Shows the header of the reset buttons";
			labelHeaderReset.AccessibleName = "Header of the reset buttons";
			labelHeaderReset.AccessibleRole = AccessibleRole.StaticText;
			labelHeaderReset.Dock = DockStyle.Fill;
			labelHeaderReset.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelHeaderReset.Location = new Point(506, 3);
			labelHeaderReset.Margin = new Padding(4, 3, 4, 3);
			labelHeaderReset.Name = "labelHeaderReset";
			labelHeaderReset.Size = new Size(85, 17);
			labelHeaderReset.TabIndex = 3;
			toolTip.SetToolTip(labelHeaderReset, "Header of the reset buttons");
			labelHeaderReset.Values.Text = "Reset";
			labelHeaderReset.Enter += SetStatusbar_Enter;
			labelHeaderReset.Leave += ClearStatusbar_Leave;
			labelHeaderReset.MouseEnter += SetStatusbar_Enter;
			labelHeaderReset.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelHeaderMaximum
			// 
			labelHeaderMaximum.AccessibleDescription = "Shows the header of the maximum spin buttons";
			labelHeaderMaximum.AccessibleName = "Header of the maximum spin buttons";
			labelHeaderMaximum.AccessibleRole = AccessibleRole.StaticText;
			labelHeaderMaximum.Dock = DockStyle.Fill;
			labelHeaderMaximum.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelHeaderMaximum.Location = new Point(378, 3);
			labelHeaderMaximum.Margin = new Padding(4, 3, 4, 3);
			labelHeaderMaximum.Name = "labelHeaderMaximum";
			labelHeaderMaximum.Size = new Size(120, 17);
			labelHeaderMaximum.TabIndex = 2;
			toolTip.SetToolTip(labelHeaderMaximum, "Header of the maximum spin buttons");
			labelHeaderMaximum.Values.Text = "Maximum";
			labelHeaderMaximum.Enter += SetStatusbar_Enter;
			labelHeaderMaximum.Leave += ClearStatusbar_Leave;
			labelHeaderMaximum.MouseEnter += SetStatusbar_Enter;
			labelHeaderMaximum.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelHeaderMinimum
			// 
			labelHeaderMinimum.AccessibleDescription = "Shows the header of the minimum spin buttons";
			labelHeaderMinimum.AccessibleName = "Header of the minimum spin buttons";
			labelHeaderMinimum.AccessibleRole = AccessibleRole.StaticText;
			labelHeaderMinimum.Dock = DockStyle.Fill;
			labelHeaderMinimum.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelHeaderMinimum.Location = new Point(250, 3);
			labelHeaderMinimum.Margin = new Padding(4, 3, 4, 3);
			labelHeaderMinimum.Name = "labelHeaderMinimum";
			labelHeaderMinimum.Size = new Size(120, 17);
			labelHeaderMinimum.TabIndex = 1;
			toolTip.SetToolTip(labelHeaderMinimum, "Header of the minimum spin buttons");
			labelHeaderMinimum.Values.Text = "Minimum";
			labelHeaderMinimum.Enter += SetStatusbar_Enter;
			labelHeaderMinimum.Leave += ClearStatusbar_Leave;
			labelHeaderMinimum.MouseEnter += SetStatusbar_Enter;
			labelHeaderMinimum.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetRmsResidual
			// 
			buttonResetRmsResidual.AccessibleDescription = "Resets the minimum and maximum of ";
			buttonResetRmsResidual.AccessibleName = "Reset the minimum and maximum of ";
			buttonResetRmsResidual.AccessibleRole = AccessibleRole.PushButton;
			buttonResetRmsResidual.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetRmsResidual.Dock = DockStyle.Fill;
			buttonResetRmsResidual.Location = new Point(506, 367);
			buttonResetRmsResidual.Margin = new Padding(4, 3, 4, 3);
			buttonResetRmsResidual.Name = "buttonResetRmsResidual";
			buttonResetRmsResidual.Size = new Size(85, 27);
			buttonResetRmsResidual.TabIndex = 51;
			toolTip.SetToolTip(buttonResetRmsResidual, "Reset the minimum and maximum of ");
			buttonResetRmsResidual.ToolTipValues.EnableToolTips = true;
			buttonResetRmsResidual.Values.DropDownArrowColor = Color.Empty;
			buttonResetRmsResidual.Values.Image = Properties.Resources.silk_reload;
			buttonResetRmsResidual.Values.Text = "";
			buttonResetRmsResidual.Click += ButtonResetRmsResidual_Click;
			buttonResetRmsResidual.Enter += SetStatusbar_Enter;
			buttonResetRmsResidual.Leave += ClearStatusbar_Leave;
			buttonResetRmsResidual.MouseEnter += SetStatusbar_Enter;
			buttonResetRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetNumberOfObservations
			// 
			buttonResetNumberOfObservations.AccessibleDescription = "Resets the minimum and maximum of number of observations";
			buttonResetNumberOfObservations.AccessibleName = "Reset the minimum and maximum of number of observations";
			buttonResetNumberOfObservations.AccessibleRole = AccessibleRole.PushButton;
			buttonResetNumberOfObservations.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetNumberOfObservations.Dock = DockStyle.Fill;
			buttonResetNumberOfObservations.Location = new Point(506, 336);
			buttonResetNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			buttonResetNumberOfObservations.Name = "buttonResetNumberOfObservations";
			buttonResetNumberOfObservations.Size = new Size(85, 25);
			buttonResetNumberOfObservations.TabIndex = 47;
			toolTip.SetToolTip(buttonResetNumberOfObservations, "Reset the minimum and maximum of number of observations");
			buttonResetNumberOfObservations.ToolTipValues.EnableToolTips = true;
			buttonResetNumberOfObservations.Values.DropDownArrowColor = Color.Empty;
			buttonResetNumberOfObservations.Values.Image = Properties.Resources.silk_reload;
			buttonResetNumberOfObservations.Values.Text = "";
			buttonResetNumberOfObservations.Click += ButtonResetNumberOfObservations_Click;
			buttonResetNumberOfObservations.Enter += SetStatusbar_Enter;
			buttonResetNumberOfObservations.Leave += ClearStatusbar_Leave;
			buttonResetNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			buttonResetNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonNumberOfOppositions
			// 
			buttonNumberOfOppositions.AccessibleDescription = "Resets the minimum and maximum of number of oppositions";
			buttonNumberOfOppositions.AccessibleName = "Reset the minimum and maximum of number of oppositions";
			buttonNumberOfOppositions.AccessibleRole = AccessibleRole.PushButton;
			buttonNumberOfOppositions.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonNumberOfOppositions.Dock = DockStyle.Fill;
			buttonNumberOfOppositions.Location = new Point(506, 305);
			buttonNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			buttonNumberOfOppositions.Name = "buttonNumberOfOppositions";
			buttonNumberOfOppositions.Size = new Size(85, 25);
			buttonNumberOfOppositions.TabIndex = 43;
			toolTip.SetToolTip(buttonNumberOfOppositions, "Reset the minimum and maximum of number of oppositions");
			buttonNumberOfOppositions.ToolTipValues.EnableToolTips = true;
			buttonNumberOfOppositions.Values.DropDownArrowColor = Color.Empty;
			buttonNumberOfOppositions.Values.Image = Properties.Resources.silk_reload;
			buttonNumberOfOppositions.Values.Text = "";
			buttonNumberOfOppositions.Click += ButtonNumberOfOppositions_Click;
			buttonNumberOfOppositions.Enter += SetStatusbar_Enter;
			buttonNumberOfOppositions.Leave += ClearStatusbar_Leave;
			buttonNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			buttonNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetSlopeParameter
			// 
			buttonResetSlopeParameter.AccessibleDescription = "Resets the minimum and maximum of slope parameter";
			buttonResetSlopeParameter.AccessibleName = "Reset the minimum and maximum of slope parameter";
			buttonResetSlopeParameter.AccessibleRole = AccessibleRole.PushButton;
			buttonResetSlopeParameter.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetSlopeParameter.Dock = DockStyle.Fill;
			buttonResetSlopeParameter.Location = new Point(506, 274);
			buttonResetSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			buttonResetSlopeParameter.Name = "buttonResetSlopeParameter";
			buttonResetSlopeParameter.Size = new Size(85, 25);
			buttonResetSlopeParameter.TabIndex = 39;
			toolTip.SetToolTip(buttonResetSlopeParameter, "Reset the minimum and maximum of slope parameter");
			buttonResetSlopeParameter.ToolTipValues.EnableToolTips = true;
			buttonResetSlopeParameter.Values.DropDownArrowColor = Color.Empty;
			buttonResetSlopeParameter.Values.Image = Properties.Resources.silk_reload;
			buttonResetSlopeParameter.Values.Text = "";
			buttonResetSlopeParameter.Click += ButtonResetSlopeParameter_Click;
			buttonResetSlopeParameter.Enter += SetStatusbar_Enter;
			buttonResetSlopeParameter.Leave += ClearStatusbar_Leave;
			buttonResetSlopeParameter.MouseEnter += SetStatusbar_Enter;
			buttonResetSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetAbsoluteMagnitude
			// 
			buttonResetAbsoluteMagnitude.AccessibleDescription = "Resets the minimum and maximum of absolute magnitude";
			buttonResetAbsoluteMagnitude.AccessibleName = "Reset the minimum and maximum of absolute magnitude";
			buttonResetAbsoluteMagnitude.AccessibleRole = AccessibleRole.PushButton;
			buttonResetAbsoluteMagnitude.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetAbsoluteMagnitude.Dock = DockStyle.Fill;
			buttonResetAbsoluteMagnitude.Location = new Point(506, 243);
			buttonResetAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			buttonResetAbsoluteMagnitude.Name = "buttonResetAbsoluteMagnitude";
			buttonResetAbsoluteMagnitude.Size = new Size(85, 25);
			buttonResetAbsoluteMagnitude.TabIndex = 35;
			toolTip.SetToolTip(buttonResetAbsoluteMagnitude, "Reset the minimum and maximum of absolute magnitude");
			buttonResetAbsoluteMagnitude.ToolTipValues.EnableToolTips = true;
			buttonResetAbsoluteMagnitude.Values.DropDownArrowColor = Color.Empty;
			buttonResetAbsoluteMagnitude.Values.Image = Properties.Resources.silk_reload;
			buttonResetAbsoluteMagnitude.Values.Text = "";
			buttonResetAbsoluteMagnitude.Click += ButtonResetAbsoluteMagnitude_Click;
			buttonResetAbsoluteMagnitude.Enter += SetStatusbar_Enter;
			buttonResetAbsoluteMagnitude.Leave += ClearStatusbar_Leave;
			buttonResetAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			buttonResetAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetSemiMajorAxis
			// 
			buttonResetSemiMajorAxis.AccessibleDescription = "Resets the minimum and maximum of semi-major axis";
			buttonResetSemiMajorAxis.AccessibleName = "Reset the minimum and maximum of semi-major axis";
			buttonResetSemiMajorAxis.AccessibleRole = AccessibleRole.PushButton;
			buttonResetSemiMajorAxis.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetSemiMajorAxis.Dock = DockStyle.Fill;
			buttonResetSemiMajorAxis.Location = new Point(506, 212);
			buttonResetSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			buttonResetSemiMajorAxis.Name = "buttonResetSemiMajorAxis";
			buttonResetSemiMajorAxis.Size = new Size(85, 25);
			buttonResetSemiMajorAxis.TabIndex = 31;
			toolTip.SetToolTip(buttonResetSemiMajorAxis, "Reset the minimum and maximum of semi-major axis");
			buttonResetSemiMajorAxis.ToolTipValues.EnableToolTips = true;
			buttonResetSemiMajorAxis.Values.DropDownArrowColor = Color.Empty;
			buttonResetSemiMajorAxis.Values.Image = Properties.Resources.silk_reload;
			buttonResetSemiMajorAxis.Values.Text = "";
			buttonResetSemiMajorAxis.Click += ButtonResetSemiMajorAxis_Click;
			buttonResetSemiMajorAxis.Enter += SetStatusbar_Enter;
			buttonResetSemiMajorAxis.Leave += ClearStatusbar_Leave;
			buttonResetSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			buttonResetSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetMeanDailyMotion
			// 
			buttonResetMeanDailyMotion.AccessibleDescription = "Resets the minimum and maximum of mean daily motion";
			buttonResetMeanDailyMotion.AccessibleName = "Reset the minimum and maximum of mean daily motion";
			buttonResetMeanDailyMotion.AccessibleRole = AccessibleRole.PushButton;
			buttonResetMeanDailyMotion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetMeanDailyMotion.Dock = DockStyle.Fill;
			buttonResetMeanDailyMotion.Location = new Point(506, 181);
			buttonResetMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			buttonResetMeanDailyMotion.Name = "buttonResetMeanDailyMotion";
			buttonResetMeanDailyMotion.Size = new Size(85, 25);
			buttonResetMeanDailyMotion.TabIndex = 27;
			toolTip.SetToolTip(buttonResetMeanDailyMotion, "Reset the minimum and maximum of mean daily motion");
			buttonResetMeanDailyMotion.ToolTipValues.EnableToolTips = true;
			buttonResetMeanDailyMotion.Values.DropDownArrowColor = Color.Empty;
			buttonResetMeanDailyMotion.Values.Image = Properties.Resources.silk_reload;
			buttonResetMeanDailyMotion.Values.Text = "";
			buttonResetMeanDailyMotion.Click += ButtonResetMeanDailyMotion_Click;
			buttonResetMeanDailyMotion.Enter += SetStatusbar_Enter;
			buttonResetMeanDailyMotion.Leave += ClearStatusbar_Leave;
			buttonResetMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			buttonResetMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetLongitudeOfTheAscendingNode
			// 
			buttonResetLongitudeOfTheAscendingNode.AccessibleDescription = "Resets the minimum and maximum of longitude of the ascending node";
			buttonResetLongitudeOfTheAscendingNode.AccessibleName = "Reset the minimum and maximum of longitude of the ascending node";
			buttonResetLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.PushButton;
			buttonResetLongitudeOfTheAscendingNode.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			buttonResetLongitudeOfTheAscendingNode.Location = new Point(506, 88);
			buttonResetLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			buttonResetLongitudeOfTheAscendingNode.Name = "buttonResetLongitudeOfTheAscendingNode";
			buttonResetLongitudeOfTheAscendingNode.Size = new Size(85, 25);
			buttonResetLongitudeOfTheAscendingNode.TabIndex = 15;
			toolTip.SetToolTip(buttonResetLongitudeOfTheAscendingNode, "Reset the minimum and maximum of longitude of the ascending node");
			buttonResetLongitudeOfTheAscendingNode.ToolTipValues.EnableToolTips = true;
			buttonResetLongitudeOfTheAscendingNode.Values.DropDownArrowColor = Color.Empty;
			buttonResetLongitudeOfTheAscendingNode.Values.Image = Properties.Resources.silk_reload;
			buttonResetLongitudeOfTheAscendingNode.Values.Text = "";
			buttonResetLongitudeOfTheAscendingNode.Click += ButtonResetLongitudeOfTheAscendingNode_Click;
			buttonResetLongitudeOfTheAscendingNode.Enter += SetStatusbar_Enter;
			buttonResetLongitudeOfTheAscendingNode.Leave += ClearStatusbar_Leave;
			buttonResetLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			buttonResetLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetArgumentOfPerihelion
			// 
			buttonResetArgumentOfPerihelion.AccessibleDescription = "Resets the minimum and maximum of argument of perihelion";
			buttonResetArgumentOfPerihelion.AccessibleName = "Reset the minimum and maximum of argument of perihelion";
			buttonResetArgumentOfPerihelion.AccessibleRole = AccessibleRole.PushButton;
			buttonResetArgumentOfPerihelion.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetArgumentOfPerihelion.Dock = DockStyle.Fill;
			buttonResetArgumentOfPerihelion.Location = new Point(506, 57);
			buttonResetArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			buttonResetArgumentOfPerihelion.Name = "buttonResetArgumentOfPerihelion";
			buttonResetArgumentOfPerihelion.Size = new Size(85, 25);
			buttonResetArgumentOfPerihelion.TabIndex = 11;
			toolTip.SetToolTip(buttonResetArgumentOfPerihelion, "Reset the minimum and maximum of argument of perihelion");
			buttonResetArgumentOfPerihelion.ToolTipValues.EnableToolTips = true;
			buttonResetArgumentOfPerihelion.Values.DropDownArrowColor = Color.Empty;
			buttonResetArgumentOfPerihelion.Values.Image = Properties.Resources.silk_reload;
			buttonResetArgumentOfPerihelion.Values.Text = "";
			buttonResetArgumentOfPerihelion.Click += ButtonResetArgumentOfPerihelion_Click;
			buttonResetArgumentOfPerihelion.Enter += SetStatusbar_Enter;
			buttonResetArgumentOfPerihelion.Leave += ClearStatusbar_Leave;
			buttonResetArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			buttonResetArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetMeanAnomalyAtTheEpoch
			// 
			buttonResetMeanAnomalyAtTheEpoch.AccessibleDescription = "Resets the minimum and maximum of mean anomaly at the epoch";
			buttonResetMeanAnomalyAtTheEpoch.AccessibleName = "Reset the minimum and maximum of mean anomaly at the epoch";
			buttonResetMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.PushButton;
			buttonResetMeanAnomalyAtTheEpoch.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			buttonResetMeanAnomalyAtTheEpoch.Location = new Point(506, 26);
			buttonResetMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			buttonResetMeanAnomalyAtTheEpoch.Name = "buttonResetMeanAnomalyAtTheEpoch";
			buttonResetMeanAnomalyAtTheEpoch.Size = new Size(85, 25);
			buttonResetMeanAnomalyAtTheEpoch.TabIndex = 7;
			toolTip.SetToolTip(buttonResetMeanAnomalyAtTheEpoch, "Reset the minimum and maximum of mean anomaly at the epoch");
			buttonResetMeanAnomalyAtTheEpoch.ToolTipValues.EnableToolTips = true;
			buttonResetMeanAnomalyAtTheEpoch.Values.DropDownArrowColor = Color.Empty;
			buttonResetMeanAnomalyAtTheEpoch.Values.Image = Properties.Resources.silk_reload;
			buttonResetMeanAnomalyAtTheEpoch.Values.Text = "";
			buttonResetMeanAnomalyAtTheEpoch.Click += ButtonResetMeanAnomalyAtTheEpoch_Click;
			buttonResetMeanAnomalyAtTheEpoch.Enter += SetStatusbar_Enter;
			buttonResetMeanAnomalyAtTheEpoch.Leave += ClearStatusbar_Leave;
			buttonResetMeanAnomalyAtTheEpoch.MouseEnter += SetStatusbar_Enter;
			buttonResetMeanAnomalyAtTheEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumRmsResidual
			// 
			numericUpDownMaximumRmsResidual.AccessibleDescription = "Shows the maximum of r.m.s. residual";
			numericUpDownMaximumRmsResidual.AccessibleName = "Maximum of r.m.s. residual";
			numericUpDownMaximumRmsResidual.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumRmsResidual.AllowDecimals = true;
			numericUpDownMaximumRmsResidual.DecimalPlaces = 8;
			numericUpDownMaximumRmsResidual.Dock = DockStyle.Fill;
			numericUpDownMaximumRmsResidual.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumRmsResidual.Location = new Point(378, 367);
			numericUpDownMaximumRmsResidual.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumRmsResidual.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumRmsResidual.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumRmsResidual.Name = "numericUpDownMaximumRmsResidual";
			numericUpDownMaximumRmsResidual.Size = new Size(120, 22);
			numericUpDownMaximumRmsResidual.TabIndex = 50;
			numericUpDownMaximumRmsResidual.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumRmsResidual, "Maximum of r.m.s. residual");
			numericUpDownMaximumRmsResidual.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumRmsResidual.ValueChanged += NumericUpDownMaximumRmsResidual_ValueChanged;
			numericUpDownMaximumRmsResidual.Enter += SetStatusbar_Enter;
			numericUpDownMaximumRmsResidual.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumRmsResidual.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumNumberOfObservations
			// 
			numericUpDownMaximumNumberOfObservations.AccessibleDescription = "Shows the maximum ofnumber of observations ";
			numericUpDownMaximumNumberOfObservations.AccessibleName = "Maximum of number of observations";
			numericUpDownMaximumNumberOfObservations.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumNumberOfObservations.AllowDecimals = true;
			numericUpDownMaximumNumberOfObservations.DecimalPlaces = 8;
			numericUpDownMaximumNumberOfObservations.Dock = DockStyle.Fill;
			numericUpDownMaximumNumberOfObservations.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumNumberOfObservations.Location = new Point(378, 336);
			numericUpDownMaximumNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumNumberOfObservations.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumNumberOfObservations.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumNumberOfObservations.Name = "numericUpDownMaximumNumberOfObservations";
			numericUpDownMaximumNumberOfObservations.Size = new Size(120, 25);
			numericUpDownMaximumNumberOfObservations.TabIndex = 46;
			numericUpDownMaximumNumberOfObservations.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumNumberOfObservations, "Maximum of number of observations");
			numericUpDownMaximumNumberOfObservations.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumNumberOfObservations.ValueChanged += NumericUpDownMaximumNumberOfObservations_ValueChanged;
			numericUpDownMaximumNumberOfObservations.Enter += SetStatusbar_Enter;
			numericUpDownMaximumNumberOfObservations.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumNumberOfOppositions
			// 
			numericUpDownMaximumNumberOfOppositions.AccessibleDescription = "Shows the maximum of number of oppositions";
			numericUpDownMaximumNumberOfOppositions.AccessibleName = "Maximum of number of oppositions";
			numericUpDownMaximumNumberOfOppositions.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumNumberOfOppositions.AllowDecimals = true;
			numericUpDownMaximumNumberOfOppositions.DecimalPlaces = 8;
			numericUpDownMaximumNumberOfOppositions.Dock = DockStyle.Fill;
			numericUpDownMaximumNumberOfOppositions.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumNumberOfOppositions.Location = new Point(378, 305);
			numericUpDownMaximumNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumNumberOfOppositions.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumNumberOfOppositions.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumNumberOfOppositions.Name = "numericUpDownMaximumNumberOfOppositions";
			numericUpDownMaximumNumberOfOppositions.Size = new Size(120, 25);
			numericUpDownMaximumNumberOfOppositions.TabIndex = 42;
			numericUpDownMaximumNumberOfOppositions.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumNumberOfOppositions, "Maximum of number of oppositions");
			numericUpDownMaximumNumberOfOppositions.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumNumberOfOppositions.ValueChanged += NumericUpDownMaximumNumberOfOppositions_ValueChanged;
			numericUpDownMaximumNumberOfOppositions.Enter += SetStatusbar_Enter;
			numericUpDownMaximumNumberOfOppositions.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumSlopeParameter
			// 
			numericUpDownMaximumSlopeParameter.AccessibleDescription = "Shows the maximum of slope parameter";
			numericUpDownMaximumSlopeParameter.AccessibleName = "Maximum of slope parameter";
			numericUpDownMaximumSlopeParameter.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumSlopeParameter.AllowDecimals = true;
			numericUpDownMaximumSlopeParameter.DecimalPlaces = 8;
			numericUpDownMaximumSlopeParameter.Dock = DockStyle.Fill;
			numericUpDownMaximumSlopeParameter.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumSlopeParameter.Location = new Point(378, 274);
			numericUpDownMaximumSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumSlopeParameter.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumSlopeParameter.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumSlopeParameter.Name = "numericUpDownMaximumSlopeParameter";
			numericUpDownMaximumSlopeParameter.Size = new Size(120, 25);
			numericUpDownMaximumSlopeParameter.TabIndex = 38;
			numericUpDownMaximumSlopeParameter.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumSlopeParameter, "Maximum of slope parameter");
			numericUpDownMaximumSlopeParameter.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumSlopeParameter.ValueChanged += NumericUpDownMaximumSlopeParameter_ValueChanged;
			numericUpDownMaximumSlopeParameter.Enter += SetStatusbar_Enter;
			numericUpDownMaximumSlopeParameter.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumSlopeParameter.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumAbsoluteMagnitude
			// 
			numericUpDownMaximumAbsoluteMagnitude.AccessibleDescription = "Shows the maximum of absolute magnitude";
			numericUpDownMaximumAbsoluteMagnitude.AccessibleName = "Maximum of absolute magnitude";
			numericUpDownMaximumAbsoluteMagnitude.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumAbsoluteMagnitude.AllowDecimals = true;
			numericUpDownMaximumAbsoluteMagnitude.DecimalPlaces = 8;
			numericUpDownMaximumAbsoluteMagnitude.Dock = DockStyle.Fill;
			numericUpDownMaximumAbsoluteMagnitude.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumAbsoluteMagnitude.Location = new Point(378, 243);
			numericUpDownMaximumAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumAbsoluteMagnitude.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumAbsoluteMagnitude.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumAbsoluteMagnitude.Name = "numericUpDownMaximumAbsoluteMagnitude";
			numericUpDownMaximumAbsoluteMagnitude.Size = new Size(120, 25);
			numericUpDownMaximumAbsoluteMagnitude.TabIndex = 34;
			numericUpDownMaximumAbsoluteMagnitude.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumAbsoluteMagnitude, "Maximum of absolute magnitude");
			numericUpDownMaximumAbsoluteMagnitude.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumAbsoluteMagnitude.ValueChanged += NumericUpDownMaximumAbsoluteMagnitude_ValueChanged;
			numericUpDownMaximumAbsoluteMagnitude.Enter += SetStatusbar_Enter;
			numericUpDownMaximumAbsoluteMagnitude.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumSemiMajorAxis
			// 
			numericUpDownMaximumSemiMajorAxis.AccessibleDescription = "Shows the maximum of semi-major axis";
			numericUpDownMaximumSemiMajorAxis.AccessibleName = "Maximum of semi-major axis";
			numericUpDownMaximumSemiMajorAxis.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumSemiMajorAxis.AllowDecimals = true;
			numericUpDownMaximumSemiMajorAxis.DecimalPlaces = 8;
			numericUpDownMaximumSemiMajorAxis.Dock = DockStyle.Fill;
			numericUpDownMaximumSemiMajorAxis.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumSemiMajorAxis.Location = new Point(378, 212);
			numericUpDownMaximumSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumSemiMajorAxis.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumSemiMajorAxis.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumSemiMajorAxis.Name = "numericUpDownMaximumSemiMajorAxis";
			numericUpDownMaximumSemiMajorAxis.Size = new Size(120, 25);
			numericUpDownMaximumSemiMajorAxis.TabIndex = 30;
			numericUpDownMaximumSemiMajorAxis.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumSemiMajorAxis, "Maximum of semi-major axis");
			numericUpDownMaximumSemiMajorAxis.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumSemiMajorAxis.ValueChanged += NumericUpDownMaximumSemiMajorAxis_ValueChanged;
			numericUpDownMaximumSemiMajorAxis.Enter += SetStatusbar_Enter;
			numericUpDownMaximumSemiMajorAxis.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumMeanDailyMotion
			// 
			numericUpDownMaximumMeanDailyMotion.AccessibleDescription = "Shows the maximum of mean daily motion";
			numericUpDownMaximumMeanDailyMotion.AccessibleName = "Maximum of mean daily motion";
			numericUpDownMaximumMeanDailyMotion.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumMeanDailyMotion.AllowDecimals = true;
			numericUpDownMaximumMeanDailyMotion.DecimalPlaces = 8;
			numericUpDownMaximumMeanDailyMotion.Dock = DockStyle.Fill;
			numericUpDownMaximumMeanDailyMotion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumMeanDailyMotion.Location = new Point(378, 181);
			numericUpDownMaximumMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumMeanDailyMotion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumMeanDailyMotion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumMeanDailyMotion.Name = "numericUpDownMaximumMeanDailyMotion";
			numericUpDownMaximumMeanDailyMotion.Size = new Size(120, 25);
			numericUpDownMaximumMeanDailyMotion.TabIndex = 26;
			numericUpDownMaximumMeanDailyMotion.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumMeanDailyMotion, "Maximum of mean daily motion");
			numericUpDownMaximumMeanDailyMotion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumMeanDailyMotion.ValueChanged += NumericUpDownMaximumMeanDailyMotion_ValueChanged;
			numericUpDownMaximumMeanDailyMotion.Enter += SetStatusbar_Enter;
			numericUpDownMaximumMeanDailyMotion.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumOrbitalEccentricity
			// 
			numericUpDownMaximumOrbitalEccentricity.AccessibleDescription = "Shows the maximum of orbital eccentricity";
			numericUpDownMaximumOrbitalEccentricity.AccessibleName = "Maximum of orbital eccentricity";
			numericUpDownMaximumOrbitalEccentricity.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumOrbitalEccentricity.AllowDecimals = true;
			numericUpDownMaximumOrbitalEccentricity.DecimalPlaces = 8;
			numericUpDownMaximumOrbitalEccentricity.Dock = DockStyle.Fill;
			numericUpDownMaximumOrbitalEccentricity.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumOrbitalEccentricity.Location = new Point(378, 150);
			numericUpDownMaximumOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumOrbitalEccentricity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumOrbitalEccentricity.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumOrbitalEccentricity.Name = "numericUpDownMaximumOrbitalEccentricity";
			numericUpDownMaximumOrbitalEccentricity.Size = new Size(120, 25);
			numericUpDownMaximumOrbitalEccentricity.TabIndex = 22;
			numericUpDownMaximumOrbitalEccentricity.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumOrbitalEccentricity, "Maximum of orbital eccentricity");
			numericUpDownMaximumOrbitalEccentricity.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumOrbitalEccentricity.ValueChanged += NumericUpDownMaximumOrbitalEccentricity_ValueChanged;
			numericUpDownMaximumOrbitalEccentricity.Enter += SetStatusbar_Enter;
			numericUpDownMaximumOrbitalEccentricity.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumInclination
			// 
			numericUpDownMaximumInclination.AccessibleDescription = "Shows the maximum of inclination to the ecliptic";
			numericUpDownMaximumInclination.AccessibleName = "Maximum of inclination to the ecliptic";
			numericUpDownMaximumInclination.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumInclination.AllowDecimals = true;
			numericUpDownMaximumInclination.DecimalPlaces = 8;
			numericUpDownMaximumInclination.Dock = DockStyle.Fill;
			numericUpDownMaximumInclination.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumInclination.Location = new Point(378, 119);
			numericUpDownMaximumInclination.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumInclination.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumInclination.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumInclination.Name = "numericUpDownMaximumInclination";
			numericUpDownMaximumInclination.Size = new Size(120, 25);
			numericUpDownMaximumInclination.TabIndex = 18;
			numericUpDownMaximumInclination.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumInclination, "Maximum of inclination to the ecliptic");
			numericUpDownMaximumInclination.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumInclination.ValueChanged += NumericUpDownMaximumInclination_ValueChanged;
			numericUpDownMaximumInclination.Enter += SetStatusbar_Enter;
			numericUpDownMaximumInclination.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumInclination.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumLongitudeOfTheAscendingNode
			// 
			numericUpDownMaximumLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the maximum of longitude of the ascending node";
			numericUpDownMaximumLongitudeOfTheAscendingNode.AccessibleName = "Maximum of longitude of the ascending node";
			numericUpDownMaximumLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumLongitudeOfTheAscendingNode.AllowDecimals = true;
			numericUpDownMaximumLongitudeOfTheAscendingNode.DecimalPlaces = 8;
			numericUpDownMaximumLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			numericUpDownMaximumLongitudeOfTheAscendingNode.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumLongitudeOfTheAscendingNode.Location = new Point(378, 88);
			numericUpDownMaximumLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumLongitudeOfTheAscendingNode.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumLongitudeOfTheAscendingNode.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumLongitudeOfTheAscendingNode.Name = "numericUpDownMaximumLongitudeOfTheAscendingNode";
			numericUpDownMaximumLongitudeOfTheAscendingNode.Size = new Size(120, 25);
			numericUpDownMaximumLongitudeOfTheAscendingNode.TabIndex = 14;
			numericUpDownMaximumLongitudeOfTheAscendingNode.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumLongitudeOfTheAscendingNode, "Maximum of longitude of the ascending node");
			numericUpDownMaximumLongitudeOfTheAscendingNode.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumLongitudeOfTheAscendingNode.ValueChanged += NumericUpDownMaximumLongitudeOfTheAscendingNode_ValueChanged;
			numericUpDownMaximumLongitudeOfTheAscendingNode.Enter += SetStatusbar_Enter;
			numericUpDownMaximumLongitudeOfTheAscendingNode.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumArgumentOfPerihelion
			// 
			numericUpDownMaximumArgumentOfPerihelion.AccessibleDescription = "Shows the maximum of argument of perihelion";
			numericUpDownMaximumArgumentOfPerihelion.AccessibleName = "Maximum of argument of perihelion";
			numericUpDownMaximumArgumentOfPerihelion.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumArgumentOfPerihelion.AllowDecimals = true;
			numericUpDownMaximumArgumentOfPerihelion.DecimalPlaces = 8;
			numericUpDownMaximumArgumentOfPerihelion.Dock = DockStyle.Fill;
			numericUpDownMaximumArgumentOfPerihelion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumArgumentOfPerihelion.Location = new Point(378, 57);
			numericUpDownMaximumArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumArgumentOfPerihelion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumArgumentOfPerihelion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumArgumentOfPerihelion.Name = "numericUpDownMaximumArgumentOfPerihelion";
			numericUpDownMaximumArgumentOfPerihelion.Size = new Size(120, 25);
			numericUpDownMaximumArgumentOfPerihelion.TabIndex = 10;
			numericUpDownMaximumArgumentOfPerihelion.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumArgumentOfPerihelion, "Maximum of argument of perihelion");
			numericUpDownMaximumArgumentOfPerihelion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumArgumentOfPerihelion.ValueChanged += NumericUpDownMaximumArgumentOfPerihelion_ValueChanged;
			numericUpDownMaximumArgumentOfPerihelion.Enter += SetStatusbar_Enter;
			numericUpDownMaximumArgumentOfPerihelion.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMaximumMeanAnomalyAtTheEpoch
			// 
			numericUpDownMaximumMeanAnomalyAtTheEpoch.AccessibleDescription = "Show the maximum of mean anomaly at the epoch";
			numericUpDownMaximumMeanAnomalyAtTheEpoch.AccessibleName = "Maximum of mean anomaly at the epoch";
			numericUpDownMaximumMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.AllowDecimals = true;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.DecimalPlaces = 8;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Location = new Point(378, 26);
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Name = "numericUpDownMaximumMeanAnomalyAtTheEpoch";
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Size = new Size(120, 25);
			numericUpDownMaximumMeanAnomalyAtTheEpoch.TabIndex = 6;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMaximumMeanAnomalyAtTheEpoch, "Maximum of mean anomaly at the epoch");
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMaximumMeanAnomalyAtTheEpoch.ValueChanged += NumericUpDownMaximumMeanAnomalyAtTheEpoch_ValueChanged;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Enter += SetStatusbar_Enter;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.Leave += ClearStatusbar_Leave;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.MouseEnter += SetStatusbar_Enter;
			numericUpDownMaximumMeanAnomalyAtTheEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumRmsResidual
			// 
			numericUpDownMinimumRmsResidual.AccessibleDescription = "Shows the minimum of r.m.s. residual";
			numericUpDownMinimumRmsResidual.AccessibleName = "Minimum of r.m.s. residual";
			numericUpDownMinimumRmsResidual.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumRmsResidual.AllowDecimals = true;
			numericUpDownMinimumRmsResidual.DecimalPlaces = 8;
			numericUpDownMinimumRmsResidual.Dock = DockStyle.Fill;
			numericUpDownMinimumRmsResidual.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumRmsResidual.Location = new Point(250, 367);
			numericUpDownMinimumRmsResidual.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumRmsResidual.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumRmsResidual.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumRmsResidual.Name = "numericUpDownMinimumRmsResidual";
			numericUpDownMinimumRmsResidual.Size = new Size(120, 22);
			numericUpDownMinimumRmsResidual.TabIndex = 49;
			numericUpDownMinimumRmsResidual.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumRmsResidual, "Minimum of r.m.s. residual");
			numericUpDownMinimumRmsResidual.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumRmsResidual.ValueChanged += NumericUpDownMinimumRmsResidual_ValueChanged;
			numericUpDownMinimumRmsResidual.Enter += SetStatusbar_Enter;
			numericUpDownMinimumRmsResidual.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumRmsResidual.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumNumberOfObservations
			// 
			numericUpDownMinimumNumberOfObservations.AccessibleDescription = "Shows the minimum of number of observations";
			numericUpDownMinimumNumberOfObservations.AccessibleName = "Minimum of number of observations";
			numericUpDownMinimumNumberOfObservations.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumNumberOfObservations.AllowDecimals = true;
			numericUpDownMinimumNumberOfObservations.DecimalPlaces = 8;
			numericUpDownMinimumNumberOfObservations.Dock = DockStyle.Fill;
			numericUpDownMinimumNumberOfObservations.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumNumberOfObservations.Location = new Point(250, 336);
			numericUpDownMinimumNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumNumberOfObservations.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumNumberOfObservations.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumNumberOfObservations.Name = "numericUpDownMinimumNumberOfObservations";
			numericUpDownMinimumNumberOfObservations.Size = new Size(120, 25);
			numericUpDownMinimumNumberOfObservations.TabIndex = 45;
			numericUpDownMinimumNumberOfObservations.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumNumberOfObservations, "Minimum of number of observations");
			numericUpDownMinimumNumberOfObservations.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumNumberOfObservations.ValueChanged += NumericUpDownMinimumNumberOfObservations_ValueChanged;
			numericUpDownMinimumNumberOfObservations.Enter += SetStatusbar_Enter;
			numericUpDownMinimumNumberOfObservations.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumNumberOfOppositions
			// 
			numericUpDownMinimumNumberOfOppositions.AccessibleDescription = "Shows the minimum of number of oppositions";
			numericUpDownMinimumNumberOfOppositions.AccessibleName = "Minimum of number of oppositions";
			numericUpDownMinimumNumberOfOppositions.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumNumberOfOppositions.AllowDecimals = true;
			numericUpDownMinimumNumberOfOppositions.DecimalPlaces = 8;
			numericUpDownMinimumNumberOfOppositions.Dock = DockStyle.Fill;
			numericUpDownMinimumNumberOfOppositions.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumNumberOfOppositions.Location = new Point(250, 305);
			numericUpDownMinimumNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumNumberOfOppositions.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumNumberOfOppositions.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumNumberOfOppositions.Name = "numericUpDownMinimumNumberOfOppositions";
			numericUpDownMinimumNumberOfOppositions.Size = new Size(120, 25);
			numericUpDownMinimumNumberOfOppositions.TabIndex = 41;
			numericUpDownMinimumNumberOfOppositions.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumNumberOfOppositions, "Minimum of number of oppositions");
			numericUpDownMinimumNumberOfOppositions.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumNumberOfOppositions.ValueChanged += NumericUpDownMinimumNumberOfOppositions_ValueChanged;
			numericUpDownMinimumNumberOfOppositions.Enter += SetStatusbar_Enter;
			numericUpDownMinimumNumberOfOppositions.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumSlopeParameter
			// 
			numericUpDownMinimumSlopeParameter.AccessibleDescription = "Shows the minimum of slope parameter";
			numericUpDownMinimumSlopeParameter.AccessibleName = "Minimum of slope parameter";
			numericUpDownMinimumSlopeParameter.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumSlopeParameter.AllowDecimals = true;
			numericUpDownMinimumSlopeParameter.DecimalPlaces = 8;
			numericUpDownMinimumSlopeParameter.Dock = DockStyle.Fill;
			numericUpDownMinimumSlopeParameter.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumSlopeParameter.Location = new Point(250, 274);
			numericUpDownMinimumSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumSlopeParameter.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumSlopeParameter.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumSlopeParameter.Name = "numericUpDownMinimumSlopeParameter";
			numericUpDownMinimumSlopeParameter.Size = new Size(120, 25);
			numericUpDownMinimumSlopeParameter.TabIndex = 37;
			numericUpDownMinimumSlopeParameter.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumSlopeParameter, "Minimum of slope parameter");
			numericUpDownMinimumSlopeParameter.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumSlopeParameter.ValueChanged += NumericUpDownMinimumSlopeParameter_ValueChanged;
			numericUpDownMinimumSlopeParameter.Enter += SetStatusbar_Enter;
			numericUpDownMinimumSlopeParameter.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumSlopeParameter.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumAbsoluteMagnitude
			// 
			numericUpDownMinimumAbsoluteMagnitude.AccessibleDescription = "Shows the minimum of absolute magnitude";
			numericUpDownMinimumAbsoluteMagnitude.AccessibleName = "Minimum of absolute magnitude";
			numericUpDownMinimumAbsoluteMagnitude.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumAbsoluteMagnitude.AllowDecimals = true;
			numericUpDownMinimumAbsoluteMagnitude.DecimalPlaces = 8;
			numericUpDownMinimumAbsoluteMagnitude.Dock = DockStyle.Fill;
			numericUpDownMinimumAbsoluteMagnitude.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumAbsoluteMagnitude.Location = new Point(250, 243);
			numericUpDownMinimumAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumAbsoluteMagnitude.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumAbsoluteMagnitude.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumAbsoluteMagnitude.Name = "numericUpDownMinimumAbsoluteMagnitude";
			numericUpDownMinimumAbsoluteMagnitude.Size = new Size(120, 25);
			numericUpDownMinimumAbsoluteMagnitude.TabIndex = 33;
			numericUpDownMinimumAbsoluteMagnitude.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumAbsoluteMagnitude, "Minimum of absolute magnitude");
			numericUpDownMinimumAbsoluteMagnitude.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumAbsoluteMagnitude.ValueChanged += NumericUpDownMinimumAbsoluteMagnitude_ValueChanged;
			numericUpDownMinimumAbsoluteMagnitude.Enter += SetStatusbar_Enter;
			numericUpDownMinimumAbsoluteMagnitude.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumSemiMajorAxis
			// 
			numericUpDownMinimumSemiMajorAxis.AccessibleDescription = "Shows the minimum of semi-major axis";
			numericUpDownMinimumSemiMajorAxis.AccessibleName = "Minimum of semi-major axis";
			numericUpDownMinimumSemiMajorAxis.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumSemiMajorAxis.AllowDecimals = true;
			numericUpDownMinimumSemiMajorAxis.DecimalPlaces = 8;
			numericUpDownMinimumSemiMajorAxis.Dock = DockStyle.Fill;
			numericUpDownMinimumSemiMajorAxis.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumSemiMajorAxis.Location = new Point(250, 212);
			numericUpDownMinimumSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumSemiMajorAxis.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumSemiMajorAxis.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumSemiMajorAxis.Name = "numericUpDownMinimumSemiMajorAxis";
			numericUpDownMinimumSemiMajorAxis.Size = new Size(120, 25);
			numericUpDownMinimumSemiMajorAxis.TabIndex = 29;
			numericUpDownMinimumSemiMajorAxis.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumSemiMajorAxis, "Minimum of semi-major axis");
			numericUpDownMinimumSemiMajorAxis.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumSemiMajorAxis.ValueChanged += NumericUpDownMinimumSemiMajorAxis_ValueChanged;
			numericUpDownMinimumSemiMajorAxis.Enter += SetStatusbar_Enter;
			numericUpDownMinimumSemiMajorAxis.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumMeanDailyMotion
			// 
			numericUpDownMinimumMeanDailyMotion.AccessibleDescription = "Shows the minimum of mean daily motion";
			numericUpDownMinimumMeanDailyMotion.AccessibleName = "Minimum of mean daily motion";
			numericUpDownMinimumMeanDailyMotion.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumMeanDailyMotion.AllowDecimals = true;
			numericUpDownMinimumMeanDailyMotion.DecimalPlaces = 8;
			numericUpDownMinimumMeanDailyMotion.Dock = DockStyle.Fill;
			numericUpDownMinimumMeanDailyMotion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumMeanDailyMotion.Location = new Point(250, 181);
			numericUpDownMinimumMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumMeanDailyMotion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumMeanDailyMotion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumMeanDailyMotion.Name = "numericUpDownMinimumMeanDailyMotion";
			numericUpDownMinimumMeanDailyMotion.Size = new Size(120, 25);
			numericUpDownMinimumMeanDailyMotion.TabIndex = 25;
			numericUpDownMinimumMeanDailyMotion.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumMeanDailyMotion, "Minimum of mean daily motion");
			numericUpDownMinimumMeanDailyMotion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumMeanDailyMotion.ValueChanged += NumericUpDownMinimumMeanDailyMotion_ValueChanged;
			numericUpDownMinimumMeanDailyMotion.Enter += SetStatusbar_Enter;
			numericUpDownMinimumMeanDailyMotion.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumOrbitalEccentricity
			// 
			numericUpDownMinimumOrbitalEccentricity.AccessibleDescription = "Shows the minimum of orbital eccentricity";
			numericUpDownMinimumOrbitalEccentricity.AccessibleName = "Minimum of orbital eccentricity";
			numericUpDownMinimumOrbitalEccentricity.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumOrbitalEccentricity.AllowDecimals = true;
			numericUpDownMinimumOrbitalEccentricity.DecimalPlaces = 8;
			numericUpDownMinimumOrbitalEccentricity.Dock = DockStyle.Fill;
			numericUpDownMinimumOrbitalEccentricity.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumOrbitalEccentricity.Location = new Point(250, 150);
			numericUpDownMinimumOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumOrbitalEccentricity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumOrbitalEccentricity.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumOrbitalEccentricity.Name = "numericUpDownMinimumOrbitalEccentricity";
			numericUpDownMinimumOrbitalEccentricity.Size = new Size(120, 25);
			numericUpDownMinimumOrbitalEccentricity.TabIndex = 21;
			numericUpDownMinimumOrbitalEccentricity.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumOrbitalEccentricity, "Minimum of orbital eccentricity");
			numericUpDownMinimumOrbitalEccentricity.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumOrbitalEccentricity.ValueChanged += NumericUpDownMinimumOrbitalEccentricity_ValueChanged;
			numericUpDownMinimumOrbitalEccentricity.Enter += SetStatusbar_Enter;
			numericUpDownMinimumOrbitalEccentricity.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumInclination
			// 
			numericUpDownMinimumInclination.AccessibleDescription = "Shows the minimum of inclination to the ecliptic";
			numericUpDownMinimumInclination.AccessibleName = "Minimum of inclination to the ecliptic";
			numericUpDownMinimumInclination.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumInclination.AllowDecimals = true;
			numericUpDownMinimumInclination.DecimalPlaces = 8;
			numericUpDownMinimumInclination.Dock = DockStyle.Fill;
			numericUpDownMinimumInclination.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumInclination.Location = new Point(250, 119);
			numericUpDownMinimumInclination.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumInclination.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumInclination.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumInclination.Name = "numericUpDownMinimumInclination";
			numericUpDownMinimumInclination.Size = new Size(120, 25);
			numericUpDownMinimumInclination.TabIndex = 17;
			numericUpDownMinimumInclination.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumInclination, "Minimum of inclination to the ecliptic");
			numericUpDownMinimumInclination.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumInclination.ValueChanged += NumericUpDownMinimumInclination_ValueChanged;
			numericUpDownMinimumInclination.Enter += SetStatusbar_Enter;
			numericUpDownMinimumInclination.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumInclination.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumLongitudeOfTheAscendingNode
			// 
			numericUpDownMinimumLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the minimum of longitude of the ascending node";
			numericUpDownMinimumLongitudeOfTheAscendingNode.AccessibleName = "Minimum of longitude of the ascending node";
			numericUpDownMinimumLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumLongitudeOfTheAscendingNode.AllowDecimals = true;
			numericUpDownMinimumLongitudeOfTheAscendingNode.DecimalPlaces = 8;
			numericUpDownMinimumLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			numericUpDownMinimumLongitudeOfTheAscendingNode.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumLongitudeOfTheAscendingNode.Location = new Point(250, 88);
			numericUpDownMinimumLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumLongitudeOfTheAscendingNode.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumLongitudeOfTheAscendingNode.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumLongitudeOfTheAscendingNode.Name = "numericUpDownMinimumLongitudeOfTheAscendingNode";
			numericUpDownMinimumLongitudeOfTheAscendingNode.Size = new Size(120, 25);
			numericUpDownMinimumLongitudeOfTheAscendingNode.TabIndex = 13;
			numericUpDownMinimumLongitudeOfTheAscendingNode.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumLongitudeOfTheAscendingNode, "Minimum of longitude of the ascending node");
			numericUpDownMinimumLongitudeOfTheAscendingNode.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumLongitudeOfTheAscendingNode.ValueChanged += NumericUpDownMinimumLongitudeOfTheAscendingNode_ValueChanged;
			numericUpDownMinimumLongitudeOfTheAscendingNode.Enter += SetStatusbar_Enter;
			numericUpDownMinimumLongitudeOfTheAscendingNode.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumArgumentOfPerihelion
			// 
			numericUpDownMinimumArgumentOfPerihelion.AccessibleDescription = "Shows the minimum of argument of perihelion";
			numericUpDownMinimumArgumentOfPerihelion.AccessibleName = "Minimum of argument of perihelion";
			numericUpDownMinimumArgumentOfPerihelion.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumArgumentOfPerihelion.AllowDecimals = true;
			numericUpDownMinimumArgumentOfPerihelion.DecimalPlaces = 8;
			numericUpDownMinimumArgumentOfPerihelion.Dock = DockStyle.Fill;
			numericUpDownMinimumArgumentOfPerihelion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumArgumentOfPerihelion.Location = new Point(250, 57);
			numericUpDownMinimumArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumArgumentOfPerihelion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumArgumentOfPerihelion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumArgumentOfPerihelion.Name = "numericUpDownMinimumArgumentOfPerihelion";
			numericUpDownMinimumArgumentOfPerihelion.Size = new Size(120, 25);
			numericUpDownMinimumArgumentOfPerihelion.TabIndex = 9;
			numericUpDownMinimumArgumentOfPerihelion.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumArgumentOfPerihelion, "Minimum of argument of perihelion");
			numericUpDownMinimumArgumentOfPerihelion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumArgumentOfPerihelion.ValueChanged += NumericUpDownMinimumArgumentOfPerihelion_ValueChanged;
			numericUpDownMinimumArgumentOfPerihelion.Enter += SetStatusbar_Enter;
			numericUpDownMinimumArgumentOfPerihelion.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelArgumentOfPerihelion
			// 
			labelArgumentOfPerihelion.AccessibleDescription = "Shows the minimum and maximum of argument of perihelion";
			labelArgumentOfPerihelion.AccessibleName = "Argument of perihelion";
			labelArgumentOfPerihelion.AccessibleRole = AccessibleRole.StaticText;
			labelArgumentOfPerihelion.Dock = DockStyle.Fill;
			labelArgumentOfPerihelion.Location = new Point(4, 57);
			labelArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			labelArgumentOfPerihelion.Name = "labelArgumentOfPerihelion";
			labelArgumentOfPerihelion.Size = new Size(238, 25);
			labelArgumentOfPerihelion.TabIndex = 8;
			toolTip.SetToolTip(labelArgumentOfPerihelion, "Argument of perihelion, J2000.0");
			labelArgumentOfPerihelion.Values.Text = "Argument of perihelion, J2000.0";
			labelArgumentOfPerihelion.Enter += SetStatusbar_Enter;
			labelArgumentOfPerihelion.Leave += ClearStatusbar_Leave;
			labelArgumentOfPerihelion.MouseEnter += SetStatusbar_Enter;
			labelArgumentOfPerihelion.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownMinimumMeanAnomalyAtTheEpoch
			// 
			numericUpDownMinimumMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the minimum of mean anomaly at the epoch";
			numericUpDownMinimumMeanAnomalyAtTheEpoch.AccessibleName = "Minimum of mean anomaly at the epoch";
			numericUpDownMinimumMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.AllowDecimals = true;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.DecimalPlaces = 8;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Location = new Point(250, 26);
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Name = "numericUpDownMinimumMeanAnomalyAtTheEpoch";
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Size = new Size(120, 25);
			numericUpDownMinimumMeanAnomalyAtTheEpoch.TabIndex = 5;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.ThousandsSeparator = true;
			toolTip.SetToolTip(numericUpDownMinimumMeanAnomalyAtTheEpoch, "Minimum of mean anomaly at the epoch");
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownMinimumMeanAnomalyAtTheEpoch.ValueChanged += NumericUpDownMinimumMeanAnomalyAtTheEpoch_ValueChanged;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Enter += SetStatusbar_Enter;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.Leave += ClearStatusbar_Leave;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.MouseEnter += SetStatusbar_Enter;
			numericUpDownMinimumMeanAnomalyAtTheEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelRmsResidual
			// 
			labelRmsResidual.AccessibleDescription = "Shows the minimum and maximum of r.m.s. residual";
			labelRmsResidual.AccessibleName = "r.m.s. residual";
			labelRmsResidual.AccessibleRole = AccessibleRole.StaticText;
			labelRmsResidual.Dock = DockStyle.Fill;
			labelRmsResidual.Location = new Point(4, 367);
			labelRmsResidual.Margin = new Padding(4, 3, 4, 3);
			labelRmsResidual.Name = "labelRmsResidual";
			labelRmsResidual.Size = new Size(238, 27);
			labelRmsResidual.TabIndex = 48;
			toolTip.SetToolTip(labelRmsResidual, "r.m.s. residual");
			labelRmsResidual.Values.Text = "r.m.s. residual";
			labelRmsResidual.Enter += SetStatusbar_Enter;
			labelRmsResidual.Leave += ClearStatusbar_Leave;
			labelRmsResidual.MouseEnter += SetStatusbar_Enter;
			labelRmsResidual.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelLongitudeOfTheAscendingNode
			// 
			labelLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the minimum and maximum of longitude of the ascending node";
			labelLongitudeOfTheAscendingNode.AccessibleName = "Longitude of the ascending node";
			labelLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.StaticText;
			labelLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			labelLongitudeOfTheAscendingNode.Location = new Point(4, 88);
			labelLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			labelLongitudeOfTheAscendingNode.Name = "labelLongitudeOfTheAscendingNode";
			labelLongitudeOfTheAscendingNode.Size = new Size(238, 25);
			labelLongitudeOfTheAscendingNode.TabIndex = 12;
			toolTip.SetToolTip(labelLongitudeOfTheAscendingNode, "Longitude of the ascending node, J2000.0");
			labelLongitudeOfTheAscendingNode.Values.Text = "Longitude of the ascending node, J2000.0";
			labelLongitudeOfTheAscendingNode.Enter += SetStatusbar_Enter;
			labelLongitudeOfTheAscendingNode.Leave += ClearStatusbar_Leave;
			labelLongitudeOfTheAscendingNode.MouseEnter += SetStatusbar_Enter;
			labelLongitudeOfTheAscendingNode.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNumberOfObservations
			// 
			labelNumberOfObservations.AccessibleDescription = "Shows the minimum and maximum of number of observations";
			labelNumberOfObservations.AccessibleName = "Number of observations";
			labelNumberOfObservations.AccessibleRole = AccessibleRole.StaticText;
			labelNumberOfObservations.Dock = DockStyle.Fill;
			labelNumberOfObservations.Location = new Point(4, 336);
			labelNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			labelNumberOfObservations.Name = "labelNumberOfObservations";
			labelNumberOfObservations.Size = new Size(238, 25);
			labelNumberOfObservations.TabIndex = 44;
			toolTip.SetToolTip(labelNumberOfObservations, "Number of observations");
			labelNumberOfObservations.Values.Text = "Number of observations";
			labelNumberOfObservations.Enter += SetStatusbar_Enter;
			labelNumberOfObservations.Leave += ClearStatusbar_Leave;
			labelNumberOfObservations.MouseEnter += SetStatusbar_Enter;
			labelNumberOfObservations.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelInclination
			// 
			labelInclination.AccessibleDescription = "Shows the minimum and maximum of inclination to the ecliptic";
			labelInclination.AccessibleName = "Inclination to the ecliptic";
			labelInclination.AccessibleRole = AccessibleRole.StaticText;
			labelInclination.Dock = DockStyle.Fill;
			labelInclination.Location = new Point(4, 119);
			labelInclination.Margin = new Padding(4, 3, 4, 3);
			labelInclination.Name = "labelInclination";
			labelInclination.Size = new Size(238, 25);
			labelInclination.TabIndex = 16;
			toolTip.SetToolTip(labelInclination, "Inclination to the ecliptic, J2000.0");
			labelInclination.Values.Text = "Inclination to the ecliptic, J2000.0";
			labelInclination.Enter += SetStatusbar_Enter;
			labelInclination.Leave += ClearStatusbar_Leave;
			labelInclination.MouseEnter += SetStatusbar_Enter;
			labelInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNumberOfOppositions
			// 
			labelNumberOfOppositions.AccessibleDescription = "Shows the minimum and maximum of number of oppositions";
			labelNumberOfOppositions.AccessibleName = "Number of oppositions";
			labelNumberOfOppositions.AccessibleRole = AccessibleRole.StaticText;
			labelNumberOfOppositions.Dock = DockStyle.Fill;
			labelNumberOfOppositions.Location = new Point(4, 305);
			labelNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			labelNumberOfOppositions.Name = "labelNumberOfOppositions";
			labelNumberOfOppositions.Size = new Size(238, 25);
			labelNumberOfOppositions.TabIndex = 40;
			toolTip.SetToolTip(labelNumberOfOppositions, "Number of oppositions");
			labelNumberOfOppositions.Values.Text = "Number of oppositions";
			labelNumberOfOppositions.Enter += SetStatusbar_Enter;
			labelNumberOfOppositions.Leave += ClearStatusbar_Leave;
			labelNumberOfOppositions.MouseEnter += SetStatusbar_Enter;
			labelNumberOfOppositions.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelOrbitalEccentricity
			// 
			labelOrbitalEccentricity.AccessibleDescription = "Shows the minimum and maximum of orbital eccentricity";
			labelOrbitalEccentricity.AccessibleName = "Orbital eccentricity";
			labelOrbitalEccentricity.AccessibleRole = AccessibleRole.StaticText;
			labelOrbitalEccentricity.Dock = DockStyle.Fill;
			labelOrbitalEccentricity.Location = new Point(4, 150);
			labelOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			labelOrbitalEccentricity.Name = "labelOrbitalEccentricity";
			labelOrbitalEccentricity.Size = new Size(238, 25);
			labelOrbitalEccentricity.TabIndex = 20;
			toolTip.SetToolTip(labelOrbitalEccentricity, "Orbital eccentricity");
			labelOrbitalEccentricity.Values.Text = "Orbital eccentricity";
			labelOrbitalEccentricity.Enter += SetStatusbar_Enter;
			labelOrbitalEccentricity.Leave += ClearStatusbar_Leave;
			labelOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			labelOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSlopeParameter
			// 
			labelSlopeParameter.AccessibleDescription = "Shows the minimum and maximum of slope parameter";
			labelSlopeParameter.AccessibleName = "Slope parameter";
			labelSlopeParameter.AccessibleRole = AccessibleRole.StaticText;
			labelSlopeParameter.Dock = DockStyle.Fill;
			labelSlopeParameter.Location = new Point(4, 274);
			labelSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			labelSlopeParameter.Name = "labelSlopeParameter";
			labelSlopeParameter.Size = new Size(238, 25);
			labelSlopeParameter.TabIndex = 36;
			toolTip.SetToolTip(labelSlopeParameter, "Slope parameter, G");
			labelSlopeParameter.Values.Text = "Slope parameter, G";
			labelSlopeParameter.Enter += SetStatusbar_Enter;
			labelSlopeParameter.Leave += ClearStatusbar_Leave;
			labelSlopeParameter.MouseEnter += SetStatusbar_Enter;
			labelSlopeParameter.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanDailyMotion
			// 
			labelMeanDailyMotion.AccessibleDescription = "Shows the minimum and maximum of mean daily motion";
			labelMeanDailyMotion.AccessibleName = "Mean daily motion";
			labelMeanDailyMotion.AccessibleRole = AccessibleRole.StaticText;
			labelMeanDailyMotion.Dock = DockStyle.Fill;
			labelMeanDailyMotion.Location = new Point(4, 181);
			labelMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			labelMeanDailyMotion.Name = "labelMeanDailyMotion";
			labelMeanDailyMotion.Size = new Size(238, 25);
			labelMeanDailyMotion.TabIndex = 24;
			toolTip.SetToolTip(labelMeanDailyMotion, "Mean daily motion");
			labelMeanDailyMotion.Values.Text = "Mean daily motion";
			labelMeanDailyMotion.Enter += SetStatusbar_Enter;
			labelMeanDailyMotion.Leave += ClearStatusbar_Leave;
			labelMeanDailyMotion.MouseEnter += SetStatusbar_Enter;
			labelMeanDailyMotion.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelAbsoluteMagnitude
			// 
			labelAbsoluteMagnitude.AccessibleDescription = "Shows the minimum and maximum of absolute magnitude";
			labelAbsoluteMagnitude.AccessibleName = "Absolute magnitude";
			labelAbsoluteMagnitude.AccessibleRole = AccessibleRole.StaticText;
			labelAbsoluteMagnitude.Dock = DockStyle.Fill;
			labelAbsoluteMagnitude.Location = new Point(4, 243);
			labelAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			labelAbsoluteMagnitude.Name = "labelAbsoluteMagnitude";
			labelAbsoluteMagnitude.Size = new Size(238, 25);
			labelAbsoluteMagnitude.TabIndex = 32;
			toolTip.SetToolTip(labelAbsoluteMagnitude, "Absolute magnitude, H");
			labelAbsoluteMagnitude.Values.Text = "Absolute magnitude, H";
			labelAbsoluteMagnitude.Enter += SetStatusbar_Enter;
			labelAbsoluteMagnitude.Leave += ClearStatusbar_Leave;
			labelAbsoluteMagnitude.MouseEnter += SetStatusbar_Enter;
			labelAbsoluteMagnitude.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSemiMajorAxis
			// 
			labelSemiMajorAxis.AccessibleDescription = "Shows the minimum and maximum of semi-major axis";
			labelSemiMajorAxis.AccessibleName = "Semi-major axis";
			labelSemiMajorAxis.AccessibleRole = AccessibleRole.StaticText;
			labelSemiMajorAxis.Dock = DockStyle.Fill;
			labelSemiMajorAxis.Location = new Point(4, 212);
			labelSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			labelSemiMajorAxis.Name = "labelSemiMajorAxis";
			labelSemiMajorAxis.Size = new Size(238, 25);
			labelSemiMajorAxis.TabIndex = 28;
			toolTip.SetToolTip(labelSemiMajorAxis, "Semi-major axis");
			labelSemiMajorAxis.Values.Text = "Semi-major axis";
			labelSemiMajorAxis.Enter += SetStatusbar_Enter;
			labelSemiMajorAxis.Leave += ClearStatusbar_Leave;
			labelSemiMajorAxis.MouseEnter += SetStatusbar_Enter;
			labelSemiMajorAxis.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMeanAnomalyAtTheEpoch
			// 
			labelMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the minimum and maximum of mean anomaly at the epoch";
			labelMeanAnomalyAtTheEpoch.AccessibleName = "Mean anomaly at the epoch";
			labelMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.StaticText;
			labelMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			labelMeanAnomalyAtTheEpoch.Location = new Point(4, 26);
			labelMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			labelMeanAnomalyAtTheEpoch.Name = "labelMeanAnomalyAtTheEpoch";
			labelMeanAnomalyAtTheEpoch.Size = new Size(238, 25);
			labelMeanAnomalyAtTheEpoch.TabIndex = 4;
			toolTip.SetToolTip(labelMeanAnomalyAtTheEpoch, "Mean anomaly at the epoch");
			labelMeanAnomalyAtTheEpoch.Values.Text = "Mean anomaly at the epoch";
			labelMeanAnomalyAtTheEpoch.Enter += SetStatusbar_Enter;
			labelMeanAnomalyAtTheEpoch.Leave += ClearStatusbar_Leave;
			labelMeanAnomalyAtTheEpoch.MouseEnter += SetStatusbar_Enter;
			labelMeanAnomalyAtTheEpoch.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetInclination
			// 
			buttonResetInclination.AccessibleDescription = "Resets the minimum and maximum of inclination to the ecliptic";
			buttonResetInclination.AccessibleName = "Reset the minimum and maximum of inclination to the ecliptic";
			buttonResetInclination.AccessibleRole = AccessibleRole.PushButton;
			buttonResetInclination.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetInclination.Dock = DockStyle.Fill;
			buttonResetInclination.Location = new Point(506, 119);
			buttonResetInclination.Margin = new Padding(4, 3, 4, 3);
			buttonResetInclination.Name = "buttonResetInclination";
			buttonResetInclination.Size = new Size(85, 25);
			buttonResetInclination.TabIndex = 19;
			toolTip.SetToolTip(buttonResetInclination, "Reset the minimum and maximum of inclination to the ecliptic");
			buttonResetInclination.ToolTipValues.EnableToolTips = true;
			buttonResetInclination.Values.DropDownArrowColor = Color.Empty;
			buttonResetInclination.Values.Image = Properties.Resources.silk_reload;
			buttonResetInclination.Values.Text = "";
			buttonResetInclination.Click += ButtonResetInclination_Click;
			buttonResetInclination.Enter += SetStatusbar_Enter;
			buttonResetInclination.Leave += ClearStatusbar_Leave;
			buttonResetInclination.MouseEnter += SetStatusbar_Enter;
			buttonResetInclination.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonResetOrbitalEccentricity
			// 
			buttonResetOrbitalEccentricity.AccessibleDescription = "Resets the minimum and maximum of orbital eccentricity";
			buttonResetOrbitalEccentricity.AccessibleName = "Reset the minimum and maximum of orbital eccentricity";
			buttonResetOrbitalEccentricity.AccessibleRole = AccessibleRole.PushButton;
			buttonResetOrbitalEccentricity.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonResetOrbitalEccentricity.Dock = DockStyle.Fill;
			buttonResetOrbitalEccentricity.Location = new Point(506, 150);
			buttonResetOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			buttonResetOrbitalEccentricity.Name = "buttonResetOrbitalEccentricity";
			buttonResetOrbitalEccentricity.Size = new Size(85, 25);
			buttonResetOrbitalEccentricity.TabIndex = 23;
			toolTip.SetToolTip(buttonResetOrbitalEccentricity, "Reset the minimum and maximum of orbital eccentricity");
			buttonResetOrbitalEccentricity.ToolTipValues.EnableToolTips = true;
			buttonResetOrbitalEccentricity.Values.DropDownArrowColor = Color.Empty;
			buttonResetOrbitalEccentricity.Values.Image = Properties.Resources.silk_reload;
			buttonResetOrbitalEccentricity.Values.Text = "";
			buttonResetOrbitalEccentricity.Click += ButtonResetOrbitalEccentricity_Click;
			buttonResetOrbitalEccentricity.Enter += SetStatusbar_Enter;
			buttonResetOrbitalEccentricity.Leave += ClearStatusbar_Leave;
			buttonResetOrbitalEccentricity.MouseEnter += SetStatusbar_Enter;
			buttonResetOrbitalEccentricity.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelHeaderElement
			// 
			labelHeaderElement.AccessibleDescription = "Shows the header of the orbital elements";
			labelHeaderElement.AccessibleName = "Header of the orbital elements";
			labelHeaderElement.AccessibleRole = AccessibleRole.StaticText;
			labelHeaderElement.Dock = DockStyle.Fill;
			labelHeaderElement.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
			labelHeaderElement.Location = new Point(4, 3);
			labelHeaderElement.Margin = new Padding(4, 3, 4, 3);
			labelHeaderElement.Name = "labelHeaderElement";
			labelHeaderElement.Size = new Size(238, 17);
			labelHeaderElement.TabIndex = 0;
			toolTip.SetToolTip(labelHeaderElement, "Header of the orbital elements");
			labelHeaderElement.Values.Text = "Element";
			labelHeaderElement.Enter += SetStatusbar_Enter;
			labelHeaderElement.Leave += ClearStatusbar_Leave;
			labelHeaderElement.MouseEnter += SetStatusbar_Enter;
			labelHeaderElement.MouseLeave += ClearStatusbar_Leave;
			// 
			// FilterForm
			// 
			AccessibleDescription = "Shows the filter";
			AccessibleName = "Filter";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(603, 482);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FilterForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Filter";
			toolTip.SetToolTip(this, "Filter");
			FormClosed += FilterForm_FormClosed;
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			ResumeLayout(false);

		}

		#endregion
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonLabel labelMeanAnomalyAtTheEpoch;
		private Krypton.Toolkit.KryptonLabel labelArgumentOfPerihelion;
		private Krypton.Toolkit.KryptonLabel labelNumberOfOppositions;
		private Krypton.Toolkit.KryptonLabel labelSlopeParameter;
		private Krypton.Toolkit.KryptonLabel labelAbsoluteMagnitude;
		private Krypton.Toolkit.KryptonLabel labelSemiMajorAxis;
		private Krypton.Toolkit.KryptonLabel labelMeanDailyMotion;
		private Krypton.Toolkit.KryptonLabel labelOrbitalEccentricity;
		private Krypton.Toolkit.KryptonLabel labelInclination;
		private Krypton.Toolkit.KryptonLabel labelLongitudeOfTheAscendingNode;
		private Krypton.Toolkit.KryptonLabel labelRmsResidual;
		private Krypton.Toolkit.KryptonLabel labelNumberOfObservations;
		private Krypton.Toolkit.KryptonTableLayoutPanel tableLayoutPanel;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumMeanAnomalyAtTheEpoch;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumArgumentOfPerihelion;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumInclination;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumLongitudeOfTheAscendingNode;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumAbsoluteMagnitude;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumSemiMajorAxis;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumMeanDailyMotion;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumOrbitalEccentricity;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumInclination;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumLongitudeOfTheAscendingNode;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumArgumentOfPerihelion;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumMeanAnomalyAtTheEpoch;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumRmsResidual;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumNumberOfObservations;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumNumberOfOppositions;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumSlopeParameter;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumAbsoluteMagnitude;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumSemiMajorAxis;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumMeanDailyMotion;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMinimumOrbitalEccentricity;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumRmsResidual;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumNumberOfObservations;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumNumberOfOppositions;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownMaximumSlopeParameter;
		private Krypton.Toolkit.KryptonButton buttonResetMeanAnomalyAtTheEpoch;
		private Krypton.Toolkit.KryptonButton buttonResetRmsResidual;
		private Krypton.Toolkit.KryptonButton buttonResetNumberOfObservations;
		private Krypton.Toolkit.KryptonButton buttonNumberOfOppositions;
		private Krypton.Toolkit.KryptonButton buttonResetSlopeParameter;
		private Krypton.Toolkit.KryptonButton buttonResetAbsoluteMagnitude;
		private Krypton.Toolkit.KryptonButton buttonResetSemiMajorAxis;
		private Krypton.Toolkit.KryptonButton buttonResetMeanDailyMotion;
		private Krypton.Toolkit.KryptonButton buttonResetLongitudeOfTheAscendingNode;
		private Krypton.Toolkit.KryptonButton buttonResetArgumentOfPerihelion;
		private Krypton.Toolkit.KryptonButton buttonResetInclination;
		private Krypton.Toolkit.KryptonButton buttonResetOrbitalEccentricity;
		private Krypton.Toolkit.KryptonLabel labelHeaderReset;
		private Krypton.Toolkit.KryptonLabel labelHeaderMaximum;
		private Krypton.Toolkit.KryptonLabel labelHeaderMinimum;
		private Krypton.Toolkit.KryptonLabel labelHeaderElement;
		private Krypton.Toolkit.KryptonButton buttonApply;
		private Krypton.Toolkit.KryptonButton buttonReset;
		private Krypton.Toolkit.KryptonButton buttonCancel;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
	}
}