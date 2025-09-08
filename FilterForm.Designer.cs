using System.ComponentModel;

using Krypton.Toolkit;

using Planetoid_DB.Resources;

namespace Planetoid_DB
{
	partial class FilterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.components = new Container();
			var resources = new ComponentResourceManager(typeof(FilterForm));
			this.panel = new KryptonPanel();
			this.statusStrip = new KryptonStatusStrip();
			this.labelInformation = new ToolStripStatusLabel();
			this.buttonReset = new KryptonButton();
			this.buttonCancel = new KryptonButton();
			this.buttonApply = new KryptonButton();
			this.tableLayoutPanel = new KryptonTableLayoutPanel();
			this.labelHeaderReset = new KryptonLabel();
			this.labelHeaderMaximum = new KryptonLabel();
			this.labelHeaderMinimum = new KryptonLabel();
			this.buttonResetRmsResidual = new KryptonButton();
			this.buttonResetNumberOfObservations = new KryptonButton();
			this.buttonNumberOfOppositions = new KryptonButton();
			this.buttonResetSlopeParameter = new KryptonButton();
			this.buttonResetAbsoluteMagnitude = new KryptonButton();
			this.buttonResetSemiMajorAxis = new KryptonButton();
			this.buttonResetMeanDailyMotion = new KryptonButton();
			this.buttonResetLongitudeOfTheAscendingNode = new KryptonButton();
			this.buttonResetArgumentOfPerihelion = new KryptonButton();
			this.buttonResetMeanAnomalyAtTheEpoch = new KryptonButton();
			this.numericUpDownMaximumRmsResidual = new KryptonNumericUpDown();
			this.numericUpDownMaximumNumberOfObservations = new KryptonNumericUpDown();
			this.numericUpDownMaximumNumberOfOppositions = new KryptonNumericUpDown();
			this.numericUpDownMaximumSlopeParameter = new KryptonNumericUpDown();
			this.numericUpDownMaximumAbsoluteMagnitude = new KryptonNumericUpDown();
			this.numericUpDownMaximumSemiMajorAxis = new KryptonNumericUpDown();
			this.numericUpDownMaximumMeanDailyMotion = new KryptonNumericUpDown();
			this.numericUpDownMaximumOrbitalEccentricity = new KryptonNumericUpDown();
			this.numericUpDownMaximumInclination = new KryptonNumericUpDown();
			this.numericUpDownMaximumLongitudeOfTheAscendingNode = new KryptonNumericUpDown();
			this.numericUpDownMaximumArgumentOfPerihelion = new KryptonNumericUpDown();
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch = new KryptonNumericUpDown();
			this.numericUpDownMinimumRmsResidual = new KryptonNumericUpDown();
			this.numericUpDownMinimumNumberOfObservations = new KryptonNumericUpDown();
			this.numericUpDownMinimumNumberOfOppositions = new KryptonNumericUpDown();
			this.numericUpDownMinimumSlopeParameter = new KryptonNumericUpDown();
			this.numericUpDownMinimumAbsoluteMagnitude = new KryptonNumericUpDown();
			this.numericUpDownMinimumSemiMajorAxis = new KryptonNumericUpDown();
			this.numericUpDownMinimumMeanDailyMotion = new KryptonNumericUpDown();
			this.numericUpDownMinimumOrbitalEccentricity = new KryptonNumericUpDown();
			this.numericUpDownMinimumInclination = new KryptonNumericUpDown();
			this.numericUpDownMinimumLongitudeOfTheAscendingNode = new KryptonNumericUpDown();
			this.numericUpDownMinimumArgumentOfPerihelion = new KryptonNumericUpDown();
			this.labelArgumentOfPerihelion = new KryptonLabel();
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch = new KryptonNumericUpDown();
			this.labelRmsResidual = new KryptonLabel();
			this.labelLongitudeOfTheAscendingNode = new KryptonLabel();
			this.labelNumberOfObservations = new KryptonLabel();
			this.labelInclination = new KryptonLabel();
			this.labelNumberOfOppositions = new KryptonLabel();
			this.labelOrbitalEccentricity = new KryptonLabel();
			this.labelSlopeParameter = new KryptonLabel();
			this.labelMeanDailyMotion = new KryptonLabel();
			this.labelAbsoluteMagnitude = new KryptonLabel();
			this.labelSemiMajorAxis = new KryptonLabel();
			this.labelMeanAnomalyAtTheEpoch = new KryptonLabel();
			this.buttonResetInclination = new KryptonButton();
			this.buttonResetOrbitalEccentricity = new KryptonButton();
			this.labelHeaderElement = new KryptonLabel();
			this.toolTip = new ToolTip(this.components);
			this.kryptonManager = new KryptonManager(this.components);
			((ISupportInitialize)this.panel).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "pane";
			this.panel.AccessibleRole = AccessibleRole.Pane;
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.buttonReset);
			this.panel.Controls.Add(this.buttonCancel);
			this.panel.Controls.Add(this.buttonApply);
			this.panel.Controls.Add(this.tableLayoutPanel);
			this.panel.Dock = DockStyle.Fill;
			this.panel.Location = new Point(0, 0);
			this.panel.Margin = new Padding(4, 3, 4, 3);
			this.panel.Name = "panel";
			this.panel.Size = new Size(607, 470);
			this.panel.TabIndex = 0;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			this.statusStrip.Font = new Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new ToolStripItem[] { this.labelInformation });
			this.statusStrip.Location = new Point(0, 448);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new Padding(1, 0, 16, 0);
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new Size(607, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 4;
			this.statusStrip.Text = "status bar";
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Shows some information";
			this.labelInformation.AccessibleName = "Shows some information";
			this.labelInformation.AccessibleRole = AccessibleRole.StaticText;
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Image = FatcowIcons16px.fatcow_lightbulb_16px;
			this.labelInformation.Margin = new Padding(5, 3, 0, 2);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new Size(144, 17);
			this.labelInformation.Text = "some information here";
			this.labelInformation.ToolTipText = "Shows some information";
			// 
			// buttonReset
			// 
			this.buttonReset.AccessibleDescription = "Resets the filter settings";
			this.buttonReset.AccessibleName = "Reset the filter settings";
			this.buttonReset.AccessibleRole = AccessibleRole.PushButton;
			this.buttonReset.Location = new Point(336, 416);
			this.buttonReset.Margin = new Padding(4, 3, 4, 3);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new Size(105, 29);
			this.buttonReset.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonReset, "Reset the filter settings");
			this.buttonReset.Values.DropDownArrowColor = Color.Empty;
			this.buttonReset.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonReset.Values.Text = "&Reset all";
			this.buttonReset.Click += this.ButtonReset_Click;
			this.buttonReset.Enter += this.SetStatusBar_Enter;
			this.buttonReset.Leave += this.ClearStatusBar_Leave;
			this.buttonReset.MouseEnter += this.SetStatusBar_Enter;
			this.buttonReset.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleDescription = "Cancels the filter settings";
			this.buttonCancel.AccessibleName = "Cancel the filter settings";
			this.buttonCancel.AccessibleRole = AccessibleRole.PushButton;
			this.buttonCancel.DialogResult = DialogResult.Cancel;
			this.buttonCancel.Location = new Point(224, 416);
			this.buttonCancel.Margin = new Padding(4, 3, 4, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new Size(105, 29);
			this.buttonCancel.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonCancel, "Cancel the filter settings");
			this.buttonCancel.Values.DropDownArrowColor = Color.Empty;
			this.buttonCancel.Values.Image = FatcowIcons16px.fatcow_cancel_16px;
			this.buttonCancel.Values.Text = "&Cancel";
			this.buttonCancel.Click += this.ButtonCancel_Click;
			this.buttonCancel.Enter += this.SetStatusBar_Enter;
			this.buttonCancel.Leave += this.ClearStatusBar_Leave;
			this.buttonCancel.MouseEnter += this.SetStatusBar_Enter;
			this.buttonCancel.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonApply
			// 
			this.buttonApply.AccessibleDescription = "Applys the filter settings";
			this.buttonApply.AccessibleName = "Apply the filter settings";
			this.buttonApply.AccessibleRole = AccessibleRole.PushButton;
			this.buttonApply.DialogResult = DialogResult.OK;
			this.buttonApply.Location = new Point(112, 416);
			this.buttonApply.Margin = new Padding(4, 3, 4, 3);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new Size(105, 29);
			this.buttonApply.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonApply, "Apply the filter settings");
			this.buttonApply.Values.DropDownArrowColor = Color.Empty;
			this.buttonApply.Values.Image = FatcowIcons16px.fatcow_accept_button_16px;
			this.buttonApply.Values.Text = "&Apply";
			this.buttonApply.Click += this.ButtonApply_Click;
			this.buttonApply.Enter += this.SetStatusBar_Enter;
			this.buttonApply.Leave += this.ClearStatusBar_Leave;
			this.buttonApply.MouseEnter += this.SetStatusBar_Enter;
			this.buttonApply.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Groups the data";
			this.tableLayoutPanel.AccessibleName = "pane";
			this.tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			this.tableLayoutPanel.ColumnCount = 4;
			this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.labelHeaderReset, 3, 0);
			this.tableLayoutPanel.Controls.Add(this.labelHeaderMaximum, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.labelHeaderMinimum, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.buttonResetRmsResidual, 3, 13);
			this.tableLayoutPanel.Controls.Add(this.buttonResetNumberOfObservations, 3, 12);
			this.tableLayoutPanel.Controls.Add(this.buttonNumberOfOppositions, 3, 11);
			this.tableLayoutPanel.Controls.Add(this.buttonResetSlopeParameter, 3, 10);
			this.tableLayoutPanel.Controls.Add(this.buttonResetAbsoluteMagnitude, 3, 9);
			this.tableLayoutPanel.Controls.Add(this.buttonResetSemiMajorAxis, 3, 8);
			this.tableLayoutPanel.Controls.Add(this.buttonResetMeanDailyMotion, 3, 7);
			this.tableLayoutPanel.Controls.Add(this.buttonResetLongitudeOfTheAscendingNode, 3, 4);
			this.tableLayoutPanel.Controls.Add(this.buttonResetArgumentOfPerihelion, 3, 3);
			this.tableLayoutPanel.Controls.Add(this.buttonResetMeanAnomalyAtTheEpoch, 3, 2);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumRmsResidual, 2, 13);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumNumberOfObservations, 2, 12);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumNumberOfOppositions, 2, 11);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumSlopeParameter, 2, 10);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumAbsoluteMagnitude, 2, 9);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumSemiMajorAxis, 2, 8);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumMeanDailyMotion, 2, 7);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumOrbitalEccentricity, 2, 6);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumInclination, 2, 5);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumLongitudeOfTheAscendingNode, 2, 4);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumArgumentOfPerihelion, 2, 3);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaximumMeanAnomalyAtTheEpoch, 2, 2);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumRmsResidual, 1, 13);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumNumberOfObservations, 1, 12);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumNumberOfOppositions, 1, 11);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumSlopeParameter, 1, 10);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumAbsoluteMagnitude, 1, 9);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumSemiMajorAxis, 1, 8);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumMeanDailyMotion, 1, 7);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumOrbitalEccentricity, 1, 6);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumInclination, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumLongitudeOfTheAscendingNode, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumArgumentOfPerihelion, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.labelArgumentOfPerihelion, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMinimumMeanAnomalyAtTheEpoch, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelRmsResidual, 0, 13);
			this.tableLayoutPanel.Controls.Add(this.labelLongitudeOfTheAscendingNode, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.labelNumberOfObservations, 0, 12);
			this.tableLayoutPanel.Controls.Add(this.labelInclination, 0, 5);
			this.tableLayoutPanel.Controls.Add(this.labelNumberOfOppositions, 0, 11);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalEccentricity, 0, 6);
			this.tableLayoutPanel.Controls.Add(this.labelSlopeParameter, 0, 10);
			this.tableLayoutPanel.Controls.Add(this.labelMeanDailyMotion, 0, 7);
			this.tableLayoutPanel.Controls.Add(this.labelAbsoluteMagnitude, 0, 9);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMajorAxis, 0, 8);
			this.tableLayoutPanel.Controls.Add(this.labelMeanAnomalyAtTheEpoch, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.buttonResetInclination, 3, 5);
			this.tableLayoutPanel.Controls.Add(this.buttonResetOrbitalEccentricity, 3, 6);
			this.tableLayoutPanel.Controls.Add(this.labelHeaderElement, 0, 0);
			this.tableLayoutPanel.Location = new Point(4, 3);
			this.tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.PanelBackStyle = PaletteBackStyle.FormMain;
			this.tableLayoutPanel.RowCount = 14;
			this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel.Size = new Size(595, 397);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// labelHeaderReset
			// 
			this.labelHeaderReset.AccessibleDescription = "Shows the header of the reset buttons";
			this.labelHeaderReset.AccessibleName = "Header of the reset buttons";
			this.labelHeaderReset.AccessibleRole = AccessibleRole.StaticText;
			this.labelHeaderReset.Dock = DockStyle.Fill;
			this.labelHeaderReset.LabelStyle = LabelStyle.BoldPanel;
			this.labelHeaderReset.Location = new Point(506, 3);
			this.labelHeaderReset.Margin = new Padding(4, 3, 4, 3);
			this.labelHeaderReset.Name = "labelHeaderReset";
			this.labelHeaderReset.Size = new Size(85, 17);
			this.labelHeaderReset.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelHeaderReset, "Header of the reset buttons");
			this.labelHeaderReset.Values.Text = "Reset";
			this.labelHeaderReset.Enter += this.SetStatusBar_Enter;
			this.labelHeaderReset.Leave += this.ClearStatusBar_Leave;
			this.labelHeaderReset.MouseEnter += this.SetStatusBar_Enter;
			this.labelHeaderReset.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelHeaderMaximum
			// 
			this.labelHeaderMaximum.AccessibleDescription = "Shows the header of the maximum spin buttons";
			this.labelHeaderMaximum.AccessibleName = "Header of the maximum spin buttons";
			this.labelHeaderMaximum.AccessibleRole = AccessibleRole.StaticText;
			this.labelHeaderMaximum.Dock = DockStyle.Fill;
			this.labelHeaderMaximum.LabelStyle = LabelStyle.BoldPanel;
			this.labelHeaderMaximum.Location = new Point(378, 3);
			this.labelHeaderMaximum.Margin = new Padding(4, 3, 4, 3);
			this.labelHeaderMaximum.Name = "labelHeaderMaximum";
			this.labelHeaderMaximum.Size = new Size(120, 17);
			this.labelHeaderMaximum.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelHeaderMaximum, "Header of the maximum spin buttons");
			this.labelHeaderMaximum.Values.Text = "Maximum";
			this.labelHeaderMaximum.Enter += this.SetStatusBar_Enter;
			this.labelHeaderMaximum.Leave += this.ClearStatusBar_Leave;
			this.labelHeaderMaximum.MouseEnter += this.SetStatusBar_Enter;
			this.labelHeaderMaximum.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelHeaderMinimum
			// 
			this.labelHeaderMinimum.AccessibleDescription = "Shows the header of the minimum spin buttons";
			this.labelHeaderMinimum.AccessibleName = "Header of the minimum spin buttons";
			this.labelHeaderMinimum.AccessibleRole = AccessibleRole.StaticText;
			this.labelHeaderMinimum.Dock = DockStyle.Fill;
			this.labelHeaderMinimum.LabelStyle = LabelStyle.BoldPanel;
			this.labelHeaderMinimum.Location = new Point(250, 3);
			this.labelHeaderMinimum.Margin = new Padding(4, 3, 4, 3);
			this.labelHeaderMinimum.Name = "labelHeaderMinimum";
			this.labelHeaderMinimum.Size = new Size(120, 17);
			this.labelHeaderMinimum.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelHeaderMinimum, "Header of the minimum spin buttons");
			this.labelHeaderMinimum.Values.Text = "Minimum";
			this.labelHeaderMinimum.Enter += this.SetStatusBar_Enter;
			this.labelHeaderMinimum.Leave += this.ClearStatusBar_Leave;
			this.labelHeaderMinimum.MouseEnter += this.SetStatusBar_Enter;
			this.labelHeaderMinimum.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetRmsResidual
			// 
			this.buttonResetRmsResidual.AccessibleDescription = "Resets the minimum and maximum of ";
			this.buttonResetRmsResidual.AccessibleName = "Reset the minimum and maximum of ";
			this.buttonResetRmsResidual.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetRmsResidual.ButtonStyle = ButtonStyle.Form;
			this.buttonResetRmsResidual.Dock = DockStyle.Fill;
			this.buttonResetRmsResidual.Location = new Point(506, 367);
			this.buttonResetRmsResidual.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetRmsResidual.Name = "buttonResetRmsResidual";
			this.buttonResetRmsResidual.Size = new Size(85, 27);
			this.buttonResetRmsResidual.TabIndex = 51;
			this.toolTip.SetToolTip(this.buttonResetRmsResidual, "Reset the minimum and maximum of ");
			this.buttonResetRmsResidual.ToolTipValues.EnableToolTips = true;
			this.buttonResetRmsResidual.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetRmsResidual.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetRmsResidual.Values.Text = "";
			this.buttonResetRmsResidual.Click += this.ButtonResetRmsResidual_Click;
			this.buttonResetRmsResidual.Enter += this.SetStatusBar_Enter;
			this.buttonResetRmsResidual.Leave += this.ClearStatusBar_Leave;
			this.buttonResetRmsResidual.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetRmsResidual.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetNumberOfObservations
			// 
			this.buttonResetNumberOfObservations.AccessibleDescription = "Resets the minimum and maximum of number of observations";
			this.buttonResetNumberOfObservations.AccessibleName = "Reset the minimum and maximum of number of observations";
			this.buttonResetNumberOfObservations.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetNumberOfObservations.ButtonStyle = ButtonStyle.Form;
			this.buttonResetNumberOfObservations.Dock = DockStyle.Fill;
			this.buttonResetNumberOfObservations.Location = new Point(506, 336);
			this.buttonResetNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetNumberOfObservations.Name = "buttonResetNumberOfObservations";
			this.buttonResetNumberOfObservations.Size = new Size(85, 25);
			this.buttonResetNumberOfObservations.TabIndex = 47;
			this.toolTip.SetToolTip(this.buttonResetNumberOfObservations, "Reset the minimum and maximum of number of observations");
			this.buttonResetNumberOfObservations.ToolTipValues.EnableToolTips = true;
			this.buttonResetNumberOfObservations.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetNumberOfObservations.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetNumberOfObservations.Values.Text = "";
			this.buttonResetNumberOfObservations.Click += this.ButtonResetNumberOfObservations_Click;
			this.buttonResetNumberOfObservations.Enter += this.SetStatusBar_Enter;
			this.buttonResetNumberOfObservations.Leave += this.ClearStatusBar_Leave;
			this.buttonResetNumberOfObservations.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetNumberOfObservations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonNumberOfOppositions
			// 
			this.buttonNumberOfOppositions.AccessibleDescription = "Resets the minimum and maximum of number of oppositions";
			this.buttonNumberOfOppositions.AccessibleName = "Reset the minimum and maximum of number of oppositions";
			this.buttonNumberOfOppositions.AccessibleRole = AccessibleRole.PushButton;
			this.buttonNumberOfOppositions.ButtonStyle = ButtonStyle.Form;
			this.buttonNumberOfOppositions.Dock = DockStyle.Fill;
			this.buttonNumberOfOppositions.Location = new Point(506, 305);
			this.buttonNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			this.buttonNumberOfOppositions.Name = "buttonNumberOfOppositions";
			this.buttonNumberOfOppositions.Size = new Size(85, 25);
			this.buttonNumberOfOppositions.TabIndex = 43;
			this.toolTip.SetToolTip(this.buttonNumberOfOppositions, "Reset the minimum and maximum of number of oppositions");
			this.buttonNumberOfOppositions.ToolTipValues.EnableToolTips = true;
			this.buttonNumberOfOppositions.Values.DropDownArrowColor = Color.Empty;
			this.buttonNumberOfOppositions.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonNumberOfOppositions.Values.Text = "";
			this.buttonNumberOfOppositions.Click += this.ButtonNumberOfOppositions_Click;
			this.buttonNumberOfOppositions.Enter += this.SetStatusBar_Enter;
			this.buttonNumberOfOppositions.Leave += this.ClearStatusBar_Leave;
			this.buttonNumberOfOppositions.MouseEnter += this.SetStatusBar_Enter;
			this.buttonNumberOfOppositions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetSlopeParameter
			// 
			this.buttonResetSlopeParameter.AccessibleDescription = "Resets the minimum and maximum of slope parameter";
			this.buttonResetSlopeParameter.AccessibleName = "Reset the minimum and maximum of slope parameter";
			this.buttonResetSlopeParameter.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetSlopeParameter.ButtonStyle = ButtonStyle.Form;
			this.buttonResetSlopeParameter.Dock = DockStyle.Fill;
			this.buttonResetSlopeParameter.Location = new Point(506, 274);
			this.buttonResetSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetSlopeParameter.Name = "buttonResetSlopeParameter";
			this.buttonResetSlopeParameter.Size = new Size(85, 25);
			this.buttonResetSlopeParameter.TabIndex = 39;
			this.toolTip.SetToolTip(this.buttonResetSlopeParameter, "Reset the minimum and maximum of slope parameter");
			this.buttonResetSlopeParameter.ToolTipValues.EnableToolTips = true;
			this.buttonResetSlopeParameter.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetSlopeParameter.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetSlopeParameter.Values.Text = "";
			this.buttonResetSlopeParameter.Click += this.ButtonResetSlopeParameter_Click;
			this.buttonResetSlopeParameter.Enter += this.SetStatusBar_Enter;
			this.buttonResetSlopeParameter.Leave += this.ClearStatusBar_Leave;
			this.buttonResetSlopeParameter.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetSlopeParameter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetAbsoluteMagnitude
			// 
			this.buttonResetAbsoluteMagnitude.AccessibleDescription = "Resets the minimum and maximum of absolute magnitude";
			this.buttonResetAbsoluteMagnitude.AccessibleName = "Reset the minimum and maximum of absolute magnitude";
			this.buttonResetAbsoluteMagnitude.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetAbsoluteMagnitude.ButtonStyle = ButtonStyle.Form;
			this.buttonResetAbsoluteMagnitude.Dock = DockStyle.Fill;
			this.buttonResetAbsoluteMagnitude.Location = new Point(506, 243);
			this.buttonResetAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetAbsoluteMagnitude.Name = "buttonResetAbsoluteMagnitude";
			this.buttonResetAbsoluteMagnitude.Size = new Size(85, 25);
			this.buttonResetAbsoluteMagnitude.TabIndex = 35;
			this.toolTip.SetToolTip(this.buttonResetAbsoluteMagnitude, "Reset the minimum and maximum of absolute magnitude");
			this.buttonResetAbsoluteMagnitude.ToolTipValues.EnableToolTips = true;
			this.buttonResetAbsoluteMagnitude.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetAbsoluteMagnitude.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetAbsoluteMagnitude.Values.Text = "";
			this.buttonResetAbsoluteMagnitude.Click += this.ButtonResetAbsoluteMagnitude_Click;
			this.buttonResetAbsoluteMagnitude.Enter += this.SetStatusBar_Enter;
			this.buttonResetAbsoluteMagnitude.Leave += this.ClearStatusBar_Leave;
			this.buttonResetAbsoluteMagnitude.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetAbsoluteMagnitude.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetSemiMajorAxis
			// 
			this.buttonResetSemiMajorAxis.AccessibleDescription = "Resets the minimum and maximum of semi-major axis";
			this.buttonResetSemiMajorAxis.AccessibleName = "Reset the minimum and maximum of semi-major axis";
			this.buttonResetSemiMajorAxis.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetSemiMajorAxis.ButtonStyle = ButtonStyle.Form;
			this.buttonResetSemiMajorAxis.Dock = DockStyle.Fill;
			this.buttonResetSemiMajorAxis.Location = new Point(506, 212);
			this.buttonResetSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetSemiMajorAxis.Name = "buttonResetSemiMajorAxis";
			this.buttonResetSemiMajorAxis.Size = new Size(85, 25);
			this.buttonResetSemiMajorAxis.TabIndex = 31;
			this.toolTip.SetToolTip(this.buttonResetSemiMajorAxis, "Reset the minimum and maximum of semi-major axis");
			this.buttonResetSemiMajorAxis.ToolTipValues.EnableToolTips = true;
			this.buttonResetSemiMajorAxis.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetSemiMajorAxis.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetSemiMajorAxis.Values.Text = "";
			this.buttonResetSemiMajorAxis.Click += this.ButtonResetSemiMajorAxis_Click;
			this.buttonResetSemiMajorAxis.Enter += this.SetStatusBar_Enter;
			this.buttonResetSemiMajorAxis.Leave += this.ClearStatusBar_Leave;
			this.buttonResetSemiMajorAxis.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetSemiMajorAxis.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetMeanDailyMotion
			// 
			this.buttonResetMeanDailyMotion.AccessibleDescription = "Resets the minimum and maximum of mean daily motion";
			this.buttonResetMeanDailyMotion.AccessibleName = "Reset the minimum and maximum of mean daily motion";
			this.buttonResetMeanDailyMotion.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetMeanDailyMotion.ButtonStyle = ButtonStyle.Form;
			this.buttonResetMeanDailyMotion.Dock = DockStyle.Fill;
			this.buttonResetMeanDailyMotion.Location = new Point(506, 181);
			this.buttonResetMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetMeanDailyMotion.Name = "buttonResetMeanDailyMotion";
			this.buttonResetMeanDailyMotion.Size = new Size(85, 25);
			this.buttonResetMeanDailyMotion.TabIndex = 27;
			this.toolTip.SetToolTip(this.buttonResetMeanDailyMotion, "Reset the minimum and maximum of mean daily motion");
			this.buttonResetMeanDailyMotion.ToolTipValues.EnableToolTips = true;
			this.buttonResetMeanDailyMotion.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetMeanDailyMotion.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetMeanDailyMotion.Values.Text = "";
			this.buttonResetMeanDailyMotion.Click += this.ButtonResetMeanDailyMotion_Click;
			this.buttonResetMeanDailyMotion.Enter += this.SetStatusBar_Enter;
			this.buttonResetMeanDailyMotion.Leave += this.ClearStatusBar_Leave;
			this.buttonResetMeanDailyMotion.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetMeanDailyMotion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetLongitudeOfTheAscendingNode
			// 
			this.buttonResetLongitudeOfTheAscendingNode.AccessibleDescription = "Resets the minimum and maximum of longitude of the ascending node";
			this.buttonResetLongitudeOfTheAscendingNode.AccessibleName = "Reset the minimum and maximum of longitude of the ascending node";
			this.buttonResetLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetLongitudeOfTheAscendingNode.ButtonStyle = ButtonStyle.Form;
			this.buttonResetLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			this.buttonResetLongitudeOfTheAscendingNode.Location = new Point(506, 88);
			this.buttonResetLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetLongitudeOfTheAscendingNode.Name = "buttonResetLongitudeOfTheAscendingNode";
			this.buttonResetLongitudeOfTheAscendingNode.Size = new Size(85, 25);
			this.buttonResetLongitudeOfTheAscendingNode.TabIndex = 15;
			this.toolTip.SetToolTip(this.buttonResetLongitudeOfTheAscendingNode, "Reset the minimum and maximum of longitude of the ascending node");
			this.buttonResetLongitudeOfTheAscendingNode.ToolTipValues.EnableToolTips = true;
			this.buttonResetLongitudeOfTheAscendingNode.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetLongitudeOfTheAscendingNode.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetLongitudeOfTheAscendingNode.Values.Text = "";
			this.buttonResetLongitudeOfTheAscendingNode.Click += this.ButtonResetLongitudeOfTheAscendingNode_Click;
			this.buttonResetLongitudeOfTheAscendingNode.Enter += this.SetStatusBar_Enter;
			this.buttonResetLongitudeOfTheAscendingNode.Leave += this.ClearStatusBar_Leave;
			this.buttonResetLongitudeOfTheAscendingNode.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetLongitudeOfTheAscendingNode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetArgumentOfPerihelion
			// 
			this.buttonResetArgumentOfPerihelion.AccessibleDescription = "Resets the minimum and maximum of argument of perihelion";
			this.buttonResetArgumentOfPerihelion.AccessibleName = "Reset the minimum and maximum of argument of perihelion";
			this.buttonResetArgumentOfPerihelion.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetArgumentOfPerihelion.ButtonStyle = ButtonStyle.Form;
			this.buttonResetArgumentOfPerihelion.Dock = DockStyle.Fill;
			this.buttonResetArgumentOfPerihelion.Location = new Point(506, 57);
			this.buttonResetArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetArgumentOfPerihelion.Name = "buttonResetArgumentOfPerihelion";
			this.buttonResetArgumentOfPerihelion.Size = new Size(85, 25);
			this.buttonResetArgumentOfPerihelion.TabIndex = 11;
			this.toolTip.SetToolTip(this.buttonResetArgumentOfPerihelion, "Reset the minimum and maximum of argument of perihelion");
			this.buttonResetArgumentOfPerihelion.ToolTipValues.EnableToolTips = true;
			this.buttonResetArgumentOfPerihelion.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetArgumentOfPerihelion.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetArgumentOfPerihelion.Values.Text = "";
			this.buttonResetArgumentOfPerihelion.Click += this.ButtonResetArgumentOfPerihelion_Click;
			this.buttonResetArgumentOfPerihelion.Enter += this.SetStatusBar_Enter;
			this.buttonResetArgumentOfPerihelion.Leave += this.ClearStatusBar_Leave;
			this.buttonResetArgumentOfPerihelion.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetArgumentOfPerihelion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetMeanAnomalyAtTheEpoch
			// 
			this.buttonResetMeanAnomalyAtTheEpoch.AccessibleDescription = "Resets the minimum and maximum of mean anomaly at the epoch";
			this.buttonResetMeanAnomalyAtTheEpoch.AccessibleName = "Reset the minimum and maximum of mean anomaly at the epoch";
			this.buttonResetMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetMeanAnomalyAtTheEpoch.ButtonStyle = ButtonStyle.Form;
			this.buttonResetMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			this.buttonResetMeanAnomalyAtTheEpoch.Location = new Point(506, 26);
			this.buttonResetMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetMeanAnomalyAtTheEpoch.Name = "buttonResetMeanAnomalyAtTheEpoch";
			this.buttonResetMeanAnomalyAtTheEpoch.Size = new Size(85, 25);
			this.buttonResetMeanAnomalyAtTheEpoch.TabIndex = 7;
			this.toolTip.SetToolTip(this.buttonResetMeanAnomalyAtTheEpoch, "Reset the minimum and maximum of mean anomaly at the epoch");
			this.buttonResetMeanAnomalyAtTheEpoch.ToolTipValues.EnableToolTips = true;
			this.buttonResetMeanAnomalyAtTheEpoch.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetMeanAnomalyAtTheEpoch.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetMeanAnomalyAtTheEpoch.Values.Text = "";
			this.buttonResetMeanAnomalyAtTheEpoch.Click += this.ButtonResetMeanAnomalyAtTheEpoch_Click;
			this.buttonResetMeanAnomalyAtTheEpoch.Enter += this.SetStatusBar_Enter;
			this.buttonResetMeanAnomalyAtTheEpoch.Leave += this.ClearStatusBar_Leave;
			this.buttonResetMeanAnomalyAtTheEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetMeanAnomalyAtTheEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumRmsResidual
			// 
			this.numericUpDownMaximumRmsResidual.AccessibleDescription = "Shows the maximum of r.m.s. residual";
			this.numericUpDownMaximumRmsResidual.AccessibleName = "Maximum of r.m.s. residual";
			this.numericUpDownMaximumRmsResidual.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumRmsResidual.AllowDecimals = true;
			this.numericUpDownMaximumRmsResidual.DecimalPlaces = 8;
			this.numericUpDownMaximumRmsResidual.Dock = DockStyle.Fill;
			this.numericUpDownMaximumRmsResidual.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumRmsResidual.Location = new Point(378, 367);
			this.numericUpDownMaximumRmsResidual.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumRmsResidual.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumRmsResidual.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumRmsResidual.Name = "numericUpDownMaximumRmsResidual";
			this.numericUpDownMaximumRmsResidual.Size = new Size(120, 22);
			this.numericUpDownMaximumRmsResidual.TabIndex = 50;
			this.numericUpDownMaximumRmsResidual.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumRmsResidual, "Maximum of r.m.s. residual");
			this.numericUpDownMaximumRmsResidual.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumRmsResidual.ValueChanged += this.NumericUpDownMaximumRmsResidual_ValueChanged;
			this.numericUpDownMaximumRmsResidual.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumRmsResidual.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumRmsResidual.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumRmsResidual.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumNumberOfObservations
			// 
			this.numericUpDownMaximumNumberOfObservations.AccessibleDescription = "Shows the maximum ofnumber of observations ";
			this.numericUpDownMaximumNumberOfObservations.AccessibleName = "Maximum of number of observations";
			this.numericUpDownMaximumNumberOfObservations.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumNumberOfObservations.AllowDecimals = true;
			this.numericUpDownMaximumNumberOfObservations.DecimalPlaces = 8;
			this.numericUpDownMaximumNumberOfObservations.Dock = DockStyle.Fill;
			this.numericUpDownMaximumNumberOfObservations.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfObservations.Location = new Point(378, 336);
			this.numericUpDownMaximumNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumNumberOfObservations.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfObservations.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfObservations.Name = "numericUpDownMaximumNumberOfObservations";
			this.numericUpDownMaximumNumberOfObservations.Size = new Size(120, 22);
			this.numericUpDownMaximumNumberOfObservations.TabIndex = 46;
			this.numericUpDownMaximumNumberOfObservations.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumNumberOfObservations, "Maximum of number of observations");
			this.numericUpDownMaximumNumberOfObservations.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfObservations.ValueChanged += this.NumericUpDownMaximumNumberOfObservations_ValueChanged;
			this.numericUpDownMaximumNumberOfObservations.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumNumberOfObservations.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumNumberOfObservations.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumNumberOfObservations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumNumberOfOppositions
			// 
			this.numericUpDownMaximumNumberOfOppositions.AccessibleDescription = "Shows the maximum of number of oppositions";
			this.numericUpDownMaximumNumberOfOppositions.AccessibleName = "Maximum of number of oppositions";
			this.numericUpDownMaximumNumberOfOppositions.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumNumberOfOppositions.AllowDecimals = true;
			this.numericUpDownMaximumNumberOfOppositions.DecimalPlaces = 8;
			this.numericUpDownMaximumNumberOfOppositions.Dock = DockStyle.Fill;
			this.numericUpDownMaximumNumberOfOppositions.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfOppositions.Location = new Point(378, 305);
			this.numericUpDownMaximumNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumNumberOfOppositions.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfOppositions.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfOppositions.Name = "numericUpDownMaximumNumberOfOppositions";
			this.numericUpDownMaximumNumberOfOppositions.Size = new Size(120, 22);
			this.numericUpDownMaximumNumberOfOppositions.TabIndex = 42;
			this.numericUpDownMaximumNumberOfOppositions.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumNumberOfOppositions, "Maximum of number of oppositions");
			this.numericUpDownMaximumNumberOfOppositions.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumNumberOfOppositions.ValueChanged += this.NumericUpDownMaximumNumberOfOppositions_ValueChanged;
			this.numericUpDownMaximumNumberOfOppositions.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumNumberOfOppositions.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumNumberOfOppositions.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumNumberOfOppositions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumSlopeParameter
			// 
			this.numericUpDownMaximumSlopeParameter.AccessibleDescription = "Shows the maximum of slope parameter";
			this.numericUpDownMaximumSlopeParameter.AccessibleName = "Maximum of slope parameter";
			this.numericUpDownMaximumSlopeParameter.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumSlopeParameter.AllowDecimals = true;
			this.numericUpDownMaximumSlopeParameter.DecimalPlaces = 8;
			this.numericUpDownMaximumSlopeParameter.Dock = DockStyle.Fill;
			this.numericUpDownMaximumSlopeParameter.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumSlopeParameter.Location = new Point(378, 274);
			this.numericUpDownMaximumSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumSlopeParameter.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumSlopeParameter.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumSlopeParameter.Name = "numericUpDownMaximumSlopeParameter";
			this.numericUpDownMaximumSlopeParameter.Size = new Size(120, 22);
			this.numericUpDownMaximumSlopeParameter.TabIndex = 38;
			this.numericUpDownMaximumSlopeParameter.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumSlopeParameter, "Maximum of slope parameter");
			this.numericUpDownMaximumSlopeParameter.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumSlopeParameter.ValueChanged += this.NumericUpDownMaximumSlopeParameter_ValueChanged;
			this.numericUpDownMaximumSlopeParameter.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumSlopeParameter.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumSlopeParameter.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumSlopeParameter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumAbsoluteMagnitude
			// 
			this.numericUpDownMaximumAbsoluteMagnitude.AccessibleDescription = "Shows the maximum of absolute magnitude";
			this.numericUpDownMaximumAbsoluteMagnitude.AccessibleName = "Maximum of absolute magnitude";
			this.numericUpDownMaximumAbsoluteMagnitude.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumAbsoluteMagnitude.AllowDecimals = true;
			this.numericUpDownMaximumAbsoluteMagnitude.DecimalPlaces = 8;
			this.numericUpDownMaximumAbsoluteMagnitude.Dock = DockStyle.Fill;
			this.numericUpDownMaximumAbsoluteMagnitude.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumAbsoluteMagnitude.Location = new Point(378, 243);
			this.numericUpDownMaximumAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumAbsoluteMagnitude.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumAbsoluteMagnitude.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumAbsoluteMagnitude.Name = "numericUpDownMaximumAbsoluteMagnitude";
			this.numericUpDownMaximumAbsoluteMagnitude.Size = new Size(120, 22);
			this.numericUpDownMaximumAbsoluteMagnitude.TabIndex = 34;
			this.numericUpDownMaximumAbsoluteMagnitude.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumAbsoluteMagnitude, "Maximum of absolute magnitude");
			this.numericUpDownMaximumAbsoluteMagnitude.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumAbsoluteMagnitude.ValueChanged += this.NumericUpDownMaximumAbsoluteMagnitude_ValueChanged;
			this.numericUpDownMaximumAbsoluteMagnitude.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumAbsoluteMagnitude.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumAbsoluteMagnitude.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumAbsoluteMagnitude.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumSemiMajorAxis
			// 
			this.numericUpDownMaximumSemiMajorAxis.AccessibleDescription = "Shows the maximum of semi-major axis";
			this.numericUpDownMaximumSemiMajorAxis.AccessibleName = "Maximum of semi-major axis";
			this.numericUpDownMaximumSemiMajorAxis.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumSemiMajorAxis.AllowDecimals = true;
			this.numericUpDownMaximumSemiMajorAxis.DecimalPlaces = 8;
			this.numericUpDownMaximumSemiMajorAxis.Dock = DockStyle.Fill;
			this.numericUpDownMaximumSemiMajorAxis.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumSemiMajorAxis.Location = new Point(378, 212);
			this.numericUpDownMaximumSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumSemiMajorAxis.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumSemiMajorAxis.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumSemiMajorAxis.Name = "numericUpDownMaximumSemiMajorAxis";
			this.numericUpDownMaximumSemiMajorAxis.Size = new Size(120, 22);
			this.numericUpDownMaximumSemiMajorAxis.TabIndex = 30;
			this.numericUpDownMaximumSemiMajorAxis.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumSemiMajorAxis, "Maximum of semi-major axis");
			this.numericUpDownMaximumSemiMajorAxis.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumSemiMajorAxis.ValueChanged += this.NumericUpDownMaximumSemiMajorAxis_ValueChanged;
			this.numericUpDownMaximumSemiMajorAxis.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumSemiMajorAxis.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumSemiMajorAxis.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumSemiMajorAxis.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumMeanDailyMotion
			// 
			this.numericUpDownMaximumMeanDailyMotion.AccessibleDescription = "Shows the maximum of mean daily motion";
			this.numericUpDownMaximumMeanDailyMotion.AccessibleName = "Maximum of mean daily motion";
			this.numericUpDownMaximumMeanDailyMotion.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumMeanDailyMotion.AllowDecimals = true;
			this.numericUpDownMaximumMeanDailyMotion.DecimalPlaces = 8;
			this.numericUpDownMaximumMeanDailyMotion.Dock = DockStyle.Fill;
			this.numericUpDownMaximumMeanDailyMotion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumMeanDailyMotion.Location = new Point(378, 181);
			this.numericUpDownMaximumMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumMeanDailyMotion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumMeanDailyMotion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumMeanDailyMotion.Name = "numericUpDownMaximumMeanDailyMotion";
			this.numericUpDownMaximumMeanDailyMotion.Size = new Size(120, 22);
			this.numericUpDownMaximumMeanDailyMotion.TabIndex = 26;
			this.numericUpDownMaximumMeanDailyMotion.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumMeanDailyMotion, "Maximum of mean daily motion");
			this.numericUpDownMaximumMeanDailyMotion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumMeanDailyMotion.ValueChanged += this.NumericUpDownMaximumMeanDailyMotion_ValueChanged;
			this.numericUpDownMaximumMeanDailyMotion.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumMeanDailyMotion.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumMeanDailyMotion.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumMeanDailyMotion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumOrbitalEccentricity
			// 
			this.numericUpDownMaximumOrbitalEccentricity.AccessibleDescription = "Shows the maximum of orbital eccentricity";
			this.numericUpDownMaximumOrbitalEccentricity.AccessibleName = "Maximum of orbital eccentricity";
			this.numericUpDownMaximumOrbitalEccentricity.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumOrbitalEccentricity.AllowDecimals = true;
			this.numericUpDownMaximumOrbitalEccentricity.DecimalPlaces = 8;
			this.numericUpDownMaximumOrbitalEccentricity.Dock = DockStyle.Fill;
			this.numericUpDownMaximumOrbitalEccentricity.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumOrbitalEccentricity.Location = new Point(378, 150);
			this.numericUpDownMaximumOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumOrbitalEccentricity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumOrbitalEccentricity.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumOrbitalEccentricity.Name = "numericUpDownMaximumOrbitalEccentricity";
			this.numericUpDownMaximumOrbitalEccentricity.Size = new Size(120, 22);
			this.numericUpDownMaximumOrbitalEccentricity.TabIndex = 22;
			this.numericUpDownMaximumOrbitalEccentricity.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumOrbitalEccentricity, "Maximum of orbital eccentricity");
			this.numericUpDownMaximumOrbitalEccentricity.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumOrbitalEccentricity.ValueChanged += this.NumericUpDownMaximumOrbitalEccentricity_ValueChanged;
			this.numericUpDownMaximumOrbitalEccentricity.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumOrbitalEccentricity.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumOrbitalEccentricity.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumOrbitalEccentricity.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumInclination
			// 
			this.numericUpDownMaximumInclination.AccessibleDescription = "Shows the maximum of inclination to the ecliptic";
			this.numericUpDownMaximumInclination.AccessibleName = "Maximum of inclination to the ecliptic";
			this.numericUpDownMaximumInclination.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumInclination.AllowDecimals = true;
			this.numericUpDownMaximumInclination.DecimalPlaces = 8;
			this.numericUpDownMaximumInclination.Dock = DockStyle.Fill;
			this.numericUpDownMaximumInclination.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumInclination.Location = new Point(378, 119);
			this.numericUpDownMaximumInclination.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumInclination.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumInclination.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumInclination.Name = "numericUpDownMaximumInclination";
			this.numericUpDownMaximumInclination.Size = new Size(120, 22);
			this.numericUpDownMaximumInclination.TabIndex = 18;
			this.numericUpDownMaximumInclination.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumInclination, "Maximum of inclination to the ecliptic");
			this.numericUpDownMaximumInclination.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumInclination.ValueChanged += this.NumericUpDownMaximumInclination_ValueChanged;
			this.numericUpDownMaximumInclination.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumInclination.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumInclination.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumInclination.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumLongitudeOfTheAscendingNode
			// 
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the maximum of longitude of the ascending node";
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.AccessibleName = "Maximum of longitude of the ascending node";
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.AllowDecimals = true;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.DecimalPlaces = 8;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Location = new Point(378, 88);
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Name = "numericUpDownMaximumLongitudeOfTheAscendingNode";
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Size = new Size(120, 22);
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.TabIndex = 14;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumLongitudeOfTheAscendingNode, "Maximum of longitude of the ascending node");
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.ValueChanged += this.NumericUpDownMaximumLongitudeOfTheAscendingNode_ValueChanged;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumLongitudeOfTheAscendingNode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumArgumentOfPerihelion
			// 
			this.numericUpDownMaximumArgumentOfPerihelion.AccessibleDescription = "Shows the maximum of argument of perihelion";
			this.numericUpDownMaximumArgumentOfPerihelion.AccessibleName = "Maximum of argument of perihelion";
			this.numericUpDownMaximumArgumentOfPerihelion.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumArgumentOfPerihelion.AllowDecimals = true;
			this.numericUpDownMaximumArgumentOfPerihelion.DecimalPlaces = 8;
			this.numericUpDownMaximumArgumentOfPerihelion.Dock = DockStyle.Fill;
			this.numericUpDownMaximumArgumentOfPerihelion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumArgumentOfPerihelion.Location = new Point(378, 57);
			this.numericUpDownMaximumArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumArgumentOfPerihelion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumArgumentOfPerihelion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumArgumentOfPerihelion.Name = "numericUpDownMaximumArgumentOfPerihelion";
			this.numericUpDownMaximumArgumentOfPerihelion.Size = new Size(120, 22);
			this.numericUpDownMaximumArgumentOfPerihelion.TabIndex = 10;
			this.numericUpDownMaximumArgumentOfPerihelion.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumArgumentOfPerihelion, "Maximum of argument of perihelion");
			this.numericUpDownMaximumArgumentOfPerihelion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumArgumentOfPerihelion.ValueChanged += this.NumericUpDownMaximumArgumentOfPerihelion_ValueChanged;
			this.numericUpDownMaximumArgumentOfPerihelion.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumArgumentOfPerihelion.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumArgumentOfPerihelion.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumArgumentOfPerihelion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMaximumMeanAnomalyAtTheEpoch
			// 
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.AccessibleDescription = "Show the maximum of mean anomaly at the epoch";
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.AccessibleName = "Maximum of mean anomaly at the epoch";
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.AllowDecimals = true;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.DecimalPlaces = 8;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Location = new Point(378, 26);
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Name = "numericUpDownMaximumMeanAnomalyAtTheEpoch";
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Size = new Size(120, 22);
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.TabIndex = 6;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMaximumMeanAnomalyAtTheEpoch, "Maximum of mean anomaly at the epoch");
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.ValueChanged += this.NumericUpDownMaximumMeanAnomalyAtTheEpoch_ValueChanged;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMaximumMeanAnomalyAtTheEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumRmsResidual
			// 
			this.numericUpDownMinimumRmsResidual.AccessibleDescription = "Shows the minimum of r.m.s. residual";
			this.numericUpDownMinimumRmsResidual.AccessibleName = "Minimum of r.m.s. residual";
			this.numericUpDownMinimumRmsResidual.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumRmsResidual.AllowDecimals = true;
			this.numericUpDownMinimumRmsResidual.DecimalPlaces = 8;
			this.numericUpDownMinimumRmsResidual.Dock = DockStyle.Fill;
			this.numericUpDownMinimumRmsResidual.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumRmsResidual.Location = new Point(250, 367);
			this.numericUpDownMinimumRmsResidual.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumRmsResidual.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumRmsResidual.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumRmsResidual.Name = "numericUpDownMinimumRmsResidual";
			this.numericUpDownMinimumRmsResidual.Size = new Size(120, 22);
			this.numericUpDownMinimumRmsResidual.TabIndex = 49;
			this.numericUpDownMinimumRmsResidual.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumRmsResidual, "Minimum of r.m.s. residual");
			this.numericUpDownMinimumRmsResidual.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumRmsResidual.ValueChanged += this.NumericUpDownMinimumRmsResidual_ValueChanged;
			this.numericUpDownMinimumRmsResidual.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumRmsResidual.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumRmsResidual.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumRmsResidual.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumNumberOfObservations
			// 
			this.numericUpDownMinimumNumberOfObservations.AccessibleDescription = "Shows the minimum of number of observations";
			this.numericUpDownMinimumNumberOfObservations.AccessibleName = "Minimum of number of observations";
			this.numericUpDownMinimumNumberOfObservations.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumNumberOfObservations.AllowDecimals = true;
			this.numericUpDownMinimumNumberOfObservations.DecimalPlaces = 8;
			this.numericUpDownMinimumNumberOfObservations.Dock = DockStyle.Fill;
			this.numericUpDownMinimumNumberOfObservations.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfObservations.Location = new Point(250, 336);
			this.numericUpDownMinimumNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumNumberOfObservations.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfObservations.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfObservations.Name = "numericUpDownMinimumNumberOfObservations";
			this.numericUpDownMinimumNumberOfObservations.Size = new Size(120, 22);
			this.numericUpDownMinimumNumberOfObservations.TabIndex = 45;
			this.numericUpDownMinimumNumberOfObservations.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumNumberOfObservations, "Minimum of number of observations");
			this.numericUpDownMinimumNumberOfObservations.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfObservations.ValueChanged += this.NumericUpDownMinimumNumberOfObservations_ValueChanged;
			this.numericUpDownMinimumNumberOfObservations.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumNumberOfObservations.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumNumberOfObservations.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumNumberOfObservations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumNumberOfOppositions
			// 
			this.numericUpDownMinimumNumberOfOppositions.AccessibleDescription = "Shows the minimum of number of oppositions";
			this.numericUpDownMinimumNumberOfOppositions.AccessibleName = "Minimum of number of oppositions";
			this.numericUpDownMinimumNumberOfOppositions.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumNumberOfOppositions.AllowDecimals = true;
			this.numericUpDownMinimumNumberOfOppositions.DecimalPlaces = 8;
			this.numericUpDownMinimumNumberOfOppositions.Dock = DockStyle.Fill;
			this.numericUpDownMinimumNumberOfOppositions.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfOppositions.Location = new Point(250, 305);
			this.numericUpDownMinimumNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumNumberOfOppositions.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfOppositions.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfOppositions.Name = "numericUpDownMinimumNumberOfOppositions";
			this.numericUpDownMinimumNumberOfOppositions.Size = new Size(120, 22);
			this.numericUpDownMinimumNumberOfOppositions.TabIndex = 41;
			this.numericUpDownMinimumNumberOfOppositions.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumNumberOfOppositions, "Minimum of number of oppositions");
			this.numericUpDownMinimumNumberOfOppositions.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumNumberOfOppositions.ValueChanged += this.NumericUpDownMinimumNumberOfOppositions_ValueChanged;
			this.numericUpDownMinimumNumberOfOppositions.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumNumberOfOppositions.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumNumberOfOppositions.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumNumberOfOppositions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumSlopeParameter
			// 
			this.numericUpDownMinimumSlopeParameter.AccessibleDescription = "Shows the minimum of slope parameter";
			this.numericUpDownMinimumSlopeParameter.AccessibleName = "Minimum of slope parameter";
			this.numericUpDownMinimumSlopeParameter.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumSlopeParameter.AllowDecimals = true;
			this.numericUpDownMinimumSlopeParameter.DecimalPlaces = 8;
			this.numericUpDownMinimumSlopeParameter.Dock = DockStyle.Fill;
			this.numericUpDownMinimumSlopeParameter.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumSlopeParameter.Location = new Point(250, 274);
			this.numericUpDownMinimumSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumSlopeParameter.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumSlopeParameter.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumSlopeParameter.Name = "numericUpDownMinimumSlopeParameter";
			this.numericUpDownMinimumSlopeParameter.Size = new Size(120, 22);
			this.numericUpDownMinimumSlopeParameter.TabIndex = 37;
			this.numericUpDownMinimumSlopeParameter.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumSlopeParameter, "Minimum of slope parameter");
			this.numericUpDownMinimumSlopeParameter.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumSlopeParameter.ValueChanged += this.NumericUpDownMinimumSlopeParameter_ValueChanged;
			this.numericUpDownMinimumSlopeParameter.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumSlopeParameter.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumSlopeParameter.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumSlopeParameter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumAbsoluteMagnitude
			// 
			this.numericUpDownMinimumAbsoluteMagnitude.AccessibleDescription = "Shows the minimum of absolute magnitude";
			this.numericUpDownMinimumAbsoluteMagnitude.AccessibleName = "Minimum of absolute magnitude";
			this.numericUpDownMinimumAbsoluteMagnitude.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumAbsoluteMagnitude.AllowDecimals = true;
			this.numericUpDownMinimumAbsoluteMagnitude.DecimalPlaces = 8;
			this.numericUpDownMinimumAbsoluteMagnitude.Dock = DockStyle.Fill;
			this.numericUpDownMinimumAbsoluteMagnitude.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumAbsoluteMagnitude.Location = new Point(250, 243);
			this.numericUpDownMinimumAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumAbsoluteMagnitude.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumAbsoluteMagnitude.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumAbsoluteMagnitude.Name = "numericUpDownMinimumAbsoluteMagnitude";
			this.numericUpDownMinimumAbsoluteMagnitude.Size = new Size(120, 22);
			this.numericUpDownMinimumAbsoluteMagnitude.TabIndex = 33;
			this.numericUpDownMinimumAbsoluteMagnitude.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumAbsoluteMagnitude, "Minimum of absolute magnitude");
			this.numericUpDownMinimumAbsoluteMagnitude.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumAbsoluteMagnitude.ValueChanged += this.NumericUpDownMinimumAbsoluteMagnitude_ValueChanged;
			this.numericUpDownMinimumAbsoluteMagnitude.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumAbsoluteMagnitude.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumAbsoluteMagnitude.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumAbsoluteMagnitude.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumSemiMajorAxis
			// 
			this.numericUpDownMinimumSemiMajorAxis.AccessibleDescription = "Shows the minimum of semi-major axis";
			this.numericUpDownMinimumSemiMajorAxis.AccessibleName = "Minimum of semi-major axis";
			this.numericUpDownMinimumSemiMajorAxis.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumSemiMajorAxis.AllowDecimals = true;
			this.numericUpDownMinimumSemiMajorAxis.DecimalPlaces = 8;
			this.numericUpDownMinimumSemiMajorAxis.Dock = DockStyle.Fill;
			this.numericUpDownMinimumSemiMajorAxis.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumSemiMajorAxis.Location = new Point(250, 212);
			this.numericUpDownMinimumSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumSemiMajorAxis.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumSemiMajorAxis.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumSemiMajorAxis.Name = "numericUpDownMinimumSemiMajorAxis";
			this.numericUpDownMinimumSemiMajorAxis.Size = new Size(120, 22);
			this.numericUpDownMinimumSemiMajorAxis.TabIndex = 29;
			this.numericUpDownMinimumSemiMajorAxis.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumSemiMajorAxis, "Minimum of semi-major axis");
			this.numericUpDownMinimumSemiMajorAxis.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumSemiMajorAxis.ValueChanged += this.NumericUpDownMinimumSemiMajorAxis_ValueChanged;
			this.numericUpDownMinimumSemiMajorAxis.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumSemiMajorAxis.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumSemiMajorAxis.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumSemiMajorAxis.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumMeanDailyMotion
			// 
			this.numericUpDownMinimumMeanDailyMotion.AccessibleDescription = "Shows the minimum of mean daily motion";
			this.numericUpDownMinimumMeanDailyMotion.AccessibleName = "Minimum of mean daily motion";
			this.numericUpDownMinimumMeanDailyMotion.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumMeanDailyMotion.AllowDecimals = true;
			this.numericUpDownMinimumMeanDailyMotion.DecimalPlaces = 8;
			this.numericUpDownMinimumMeanDailyMotion.Dock = DockStyle.Fill;
			this.numericUpDownMinimumMeanDailyMotion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumMeanDailyMotion.Location = new Point(250, 181);
			this.numericUpDownMinimumMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumMeanDailyMotion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumMeanDailyMotion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumMeanDailyMotion.Name = "numericUpDownMinimumMeanDailyMotion";
			this.numericUpDownMinimumMeanDailyMotion.Size = new Size(120, 22);
			this.numericUpDownMinimumMeanDailyMotion.TabIndex = 25;
			this.numericUpDownMinimumMeanDailyMotion.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumMeanDailyMotion, "Minimum of mean daily motion");
			this.numericUpDownMinimumMeanDailyMotion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumMeanDailyMotion.ValueChanged += this.NumericUpDownMinimumMeanDailyMotion_ValueChanged;
			this.numericUpDownMinimumMeanDailyMotion.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumMeanDailyMotion.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumMeanDailyMotion.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumMeanDailyMotion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumOrbitalEccentricity
			// 
			this.numericUpDownMinimumOrbitalEccentricity.AccessibleDescription = "Shows the minimum of orbital eccentricity";
			this.numericUpDownMinimumOrbitalEccentricity.AccessibleName = "Minimum of orbital eccentricity";
			this.numericUpDownMinimumOrbitalEccentricity.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumOrbitalEccentricity.AllowDecimals = true;
			this.numericUpDownMinimumOrbitalEccentricity.DecimalPlaces = 8;
			this.numericUpDownMinimumOrbitalEccentricity.Dock = DockStyle.Fill;
			this.numericUpDownMinimumOrbitalEccentricity.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumOrbitalEccentricity.Location = new Point(250, 150);
			this.numericUpDownMinimumOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumOrbitalEccentricity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumOrbitalEccentricity.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumOrbitalEccentricity.Name = "numericUpDownMinimumOrbitalEccentricity";
			this.numericUpDownMinimumOrbitalEccentricity.Size = new Size(120, 22);
			this.numericUpDownMinimumOrbitalEccentricity.TabIndex = 21;
			this.numericUpDownMinimumOrbitalEccentricity.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumOrbitalEccentricity, "Minimum of orbital eccentricity");
			this.numericUpDownMinimumOrbitalEccentricity.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumOrbitalEccentricity.ValueChanged += this.NumericUpDownMinimumOrbitalEccentricity_ValueChanged;
			this.numericUpDownMinimumOrbitalEccentricity.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumOrbitalEccentricity.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumOrbitalEccentricity.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumOrbitalEccentricity.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumInclination
			// 
			this.numericUpDownMinimumInclination.AccessibleDescription = "Shows the minimum of inclination to the ecliptic";
			this.numericUpDownMinimumInclination.AccessibleName = "Minimum of inclination to the ecliptic";
			this.numericUpDownMinimumInclination.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumInclination.AllowDecimals = true;
			this.numericUpDownMinimumInclination.DecimalPlaces = 8;
			this.numericUpDownMinimumInclination.Dock = DockStyle.Fill;
			this.numericUpDownMinimumInclination.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumInclination.Location = new Point(250, 119);
			this.numericUpDownMinimumInclination.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumInclination.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumInclination.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumInclination.Name = "numericUpDownMinimumInclination";
			this.numericUpDownMinimumInclination.Size = new Size(120, 22);
			this.numericUpDownMinimumInclination.TabIndex = 17;
			this.numericUpDownMinimumInclination.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumInclination, "Minimum of inclination to the ecliptic");
			this.numericUpDownMinimumInclination.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumInclination.ValueChanged += this.NumericUpDownMinimumInclination_ValueChanged;
			this.numericUpDownMinimumInclination.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumInclination.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumInclination.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumInclination.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumLongitudeOfTheAscendingNode
			// 
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the minimum of longitude of the ascending node";
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.AccessibleName = "Minimum of longitude of the ascending node";
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.AllowDecimals = true;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.DecimalPlaces = 8;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Location = new Point(250, 88);
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Name = "numericUpDownMinimumLongitudeOfTheAscendingNode";
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Size = new Size(120, 22);
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.TabIndex = 13;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumLongitudeOfTheAscendingNode, "Minimum of longitude of the ascending node");
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.ValueChanged += this.NumericUpDownMinimumLongitudeOfTheAscendingNode_ValueChanged;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumLongitudeOfTheAscendingNode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumArgumentOfPerihelion
			// 
			this.numericUpDownMinimumArgumentOfPerihelion.AccessibleDescription = "Shows the minimum of argument of perihelion";
			this.numericUpDownMinimumArgumentOfPerihelion.AccessibleName = "Minimum of argument of perihelion";
			this.numericUpDownMinimumArgumentOfPerihelion.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumArgumentOfPerihelion.AllowDecimals = true;
			this.numericUpDownMinimumArgumentOfPerihelion.DecimalPlaces = 8;
			this.numericUpDownMinimumArgumentOfPerihelion.Dock = DockStyle.Fill;
			this.numericUpDownMinimumArgumentOfPerihelion.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumArgumentOfPerihelion.Location = new Point(250, 57);
			this.numericUpDownMinimumArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumArgumentOfPerihelion.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumArgumentOfPerihelion.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumArgumentOfPerihelion.Name = "numericUpDownMinimumArgumentOfPerihelion";
			this.numericUpDownMinimumArgumentOfPerihelion.Size = new Size(120, 22);
			this.numericUpDownMinimumArgumentOfPerihelion.TabIndex = 9;
			this.numericUpDownMinimumArgumentOfPerihelion.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumArgumentOfPerihelion, "Minimum of argument of perihelion");
			this.numericUpDownMinimumArgumentOfPerihelion.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumArgumentOfPerihelion.ValueChanged += this.NumericUpDownMinimumArgumentOfPerihelion_ValueChanged;
			this.numericUpDownMinimumArgumentOfPerihelion.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumArgumentOfPerihelion.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumArgumentOfPerihelion.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumArgumentOfPerihelion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelArgumentOfPerihelion
			// 
			this.labelArgumentOfPerihelion.AccessibleDescription = "Shows the minimum and maximum of argument of perihelion";
			this.labelArgumentOfPerihelion.AccessibleName = "Argument of perihelion";
			this.labelArgumentOfPerihelion.AccessibleRole = AccessibleRole.StaticText;
			this.labelArgumentOfPerihelion.Dock = DockStyle.Fill;
			this.labelArgumentOfPerihelion.Location = new Point(4, 57);
			this.labelArgumentOfPerihelion.Margin = new Padding(4, 3, 4, 3);
			this.labelArgumentOfPerihelion.Name = "labelArgumentOfPerihelion";
			this.labelArgumentOfPerihelion.Size = new Size(238, 25);
			this.labelArgumentOfPerihelion.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelArgumentOfPerihelion, "Argument of perihelion, J2000.0");
			this.labelArgumentOfPerihelion.Values.Text = "Argument of perihelion, J2000.0";
			this.labelArgumentOfPerihelion.Enter += this.SetStatusBar_Enter;
			this.labelArgumentOfPerihelion.Leave += this.ClearStatusBar_Leave;
			this.labelArgumentOfPerihelion.MouseEnter += this.SetStatusBar_Enter;
			this.labelArgumentOfPerihelion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// numericUpDownMinimumMeanAnomalyAtTheEpoch
			// 
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the minimum of mean anomaly at the epoch";
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.AccessibleName = "Minimum of mean anomaly at the epoch";
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.SpinButton;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.AllowDecimals = true;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.DecimalPlaces = 8;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Location = new Point(250, 26);
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Name = "numericUpDownMinimumMeanAnomalyAtTheEpoch";
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Size = new Size(120, 22);
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.TabIndex = 5;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.ThousandsSeparator = true;
			this.toolTip.SetToolTip(this.numericUpDownMinimumMeanAnomalyAtTheEpoch, "Minimum of mean anomaly at the epoch");
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Value = new decimal(new int[] { 0, 0, 0, 0 });
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.ValueChanged += this.NumericUpDownMinimumMeanAnomalyAtTheEpoch_ValueChanged;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Enter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.Leave += this.ClearStatusBar_Leave;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.numericUpDownMinimumMeanAnomalyAtTheEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelRmsResidual
			// 
			this.labelRmsResidual.AccessibleDescription = "Shows the minimum and maximum of r.m.s. residual";
			this.labelRmsResidual.AccessibleName = "r.m.s. residual";
			this.labelRmsResidual.AccessibleRole = AccessibleRole.StaticText;
			this.labelRmsResidual.Dock = DockStyle.Fill;
			this.labelRmsResidual.Location = new Point(4, 367);
			this.labelRmsResidual.Margin = new Padding(4, 3, 4, 3);
			this.labelRmsResidual.Name = "labelRmsResidual";
			this.labelRmsResidual.Size = new Size(238, 27);
			this.labelRmsResidual.TabIndex = 48;
			this.toolTip.SetToolTip(this.labelRmsResidual, "r.m.s. residual");
			this.labelRmsResidual.Values.Text = "r.m.s. residual";
			this.labelRmsResidual.Enter += this.SetStatusBar_Enter;
			this.labelRmsResidual.Leave += this.ClearStatusBar_Leave;
			this.labelRmsResidual.MouseEnter += this.SetStatusBar_Enter;
			this.labelRmsResidual.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelLongitudeOfTheAscendingNode
			// 
			this.labelLongitudeOfTheAscendingNode.AccessibleDescription = "Shows the minimum and maximum of longitude of the ascending node";
			this.labelLongitudeOfTheAscendingNode.AccessibleName = "Longitude of the ascending node";
			this.labelLongitudeOfTheAscendingNode.AccessibleRole = AccessibleRole.StaticText;
			this.labelLongitudeOfTheAscendingNode.Dock = DockStyle.Fill;
			this.labelLongitudeOfTheAscendingNode.Location = new Point(4, 88);
			this.labelLongitudeOfTheAscendingNode.Margin = new Padding(4, 3, 4, 3);
			this.labelLongitudeOfTheAscendingNode.Name = "labelLongitudeOfTheAscendingNode";
			this.labelLongitudeOfTheAscendingNode.Size = new Size(238, 25);
			this.labelLongitudeOfTheAscendingNode.TabIndex = 12;
			this.toolTip.SetToolTip(this.labelLongitudeOfTheAscendingNode, "Longitude of the ascending node, J2000.0");
			this.labelLongitudeOfTheAscendingNode.Values.Text = "Longitude of the ascending node, J2000.0";
			this.labelLongitudeOfTheAscendingNode.Enter += this.SetStatusBar_Enter;
			this.labelLongitudeOfTheAscendingNode.Leave += this.ClearStatusBar_Leave;
			this.labelLongitudeOfTheAscendingNode.MouseEnter += this.SetStatusBar_Enter;
			this.labelLongitudeOfTheAscendingNode.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelNumberOfObservations
			// 
			this.labelNumberOfObservations.AccessibleDescription = "Shows the minimum and maximum of number of observations";
			this.labelNumberOfObservations.AccessibleName = "Number of observations";
			this.labelNumberOfObservations.AccessibleRole = AccessibleRole.StaticText;
			this.labelNumberOfObservations.Dock = DockStyle.Fill;
			this.labelNumberOfObservations.Location = new Point(4, 336);
			this.labelNumberOfObservations.Margin = new Padding(4, 3, 4, 3);
			this.labelNumberOfObservations.Name = "labelNumberOfObservations";
			this.labelNumberOfObservations.Size = new Size(238, 25);
			this.labelNumberOfObservations.TabIndex = 44;
			this.toolTip.SetToolTip(this.labelNumberOfObservations, "Number of observations");
			this.labelNumberOfObservations.Values.Text = "Number of observations";
			this.labelNumberOfObservations.Enter += this.SetStatusBar_Enter;
			this.labelNumberOfObservations.Leave += this.ClearStatusBar_Leave;
			this.labelNumberOfObservations.MouseEnter += this.SetStatusBar_Enter;
			this.labelNumberOfObservations.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelInclination
			// 
			this.labelInclination.AccessibleDescription = "Shows the minimum and maximum of inclination to the ecliptic";
			this.labelInclination.AccessibleName = "Inclination to the ecliptic";
			this.labelInclination.AccessibleRole = AccessibleRole.StaticText;
			this.labelInclination.Dock = DockStyle.Fill;
			this.labelInclination.Location = new Point(4, 119);
			this.labelInclination.Margin = new Padding(4, 3, 4, 3);
			this.labelInclination.Name = "labelInclination";
			this.labelInclination.Size = new Size(238, 25);
			this.labelInclination.TabIndex = 16;
			this.toolTip.SetToolTip(this.labelInclination, "Inclination to the ecliptic, J2000.0");
			this.labelInclination.Values.Text = "Inclination to the ecliptic, J2000.0";
			this.labelInclination.Enter += this.SetStatusBar_Enter;
			this.labelInclination.Leave += this.ClearStatusBar_Leave;
			this.labelInclination.MouseEnter += this.SetStatusBar_Enter;
			this.labelInclination.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelNumberOfOppositions
			// 
			this.labelNumberOfOppositions.AccessibleDescription = "Shows the minimum and maximum of number of oppositions";
			this.labelNumberOfOppositions.AccessibleName = "Number of oppositions";
			this.labelNumberOfOppositions.AccessibleRole = AccessibleRole.StaticText;
			this.labelNumberOfOppositions.Dock = DockStyle.Fill;
			this.labelNumberOfOppositions.Location = new Point(4, 305);
			this.labelNumberOfOppositions.Margin = new Padding(4, 3, 4, 3);
			this.labelNumberOfOppositions.Name = "labelNumberOfOppositions";
			this.labelNumberOfOppositions.Size = new Size(238, 25);
			this.labelNumberOfOppositions.TabIndex = 40;
			this.toolTip.SetToolTip(this.labelNumberOfOppositions, "Number of oppositions");
			this.labelNumberOfOppositions.Values.Text = "Number of oppositions";
			this.labelNumberOfOppositions.Enter += this.SetStatusBar_Enter;
			this.labelNumberOfOppositions.Leave += this.ClearStatusBar_Leave;
			this.labelNumberOfOppositions.MouseEnter += this.SetStatusBar_Enter;
			this.labelNumberOfOppositions.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelOrbitalEccentricity
			// 
			this.labelOrbitalEccentricity.AccessibleDescription = "Shows the minimum and maximum of orbital eccentricity";
			this.labelOrbitalEccentricity.AccessibleName = "Orbital eccentricity";
			this.labelOrbitalEccentricity.AccessibleRole = AccessibleRole.StaticText;
			this.labelOrbitalEccentricity.Dock = DockStyle.Fill;
			this.labelOrbitalEccentricity.Location = new Point(4, 150);
			this.labelOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			this.labelOrbitalEccentricity.Name = "labelOrbitalEccentricity";
			this.labelOrbitalEccentricity.Size = new Size(238, 25);
			this.labelOrbitalEccentricity.TabIndex = 20;
			this.toolTip.SetToolTip(this.labelOrbitalEccentricity, "Orbital eccentricity");
			this.labelOrbitalEccentricity.Values.Text = "Orbital eccentricity";
			this.labelOrbitalEccentricity.Enter += this.SetStatusBar_Enter;
			this.labelOrbitalEccentricity.Leave += this.ClearStatusBar_Leave;
			this.labelOrbitalEccentricity.MouseEnter += this.SetStatusBar_Enter;
			this.labelOrbitalEccentricity.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelSlopeParameter
			// 
			this.labelSlopeParameter.AccessibleDescription = "Shows the minimum and maximum of slope parameter";
			this.labelSlopeParameter.AccessibleName = "Slope parameter";
			this.labelSlopeParameter.AccessibleRole = AccessibleRole.StaticText;
			this.labelSlopeParameter.Dock = DockStyle.Fill;
			this.labelSlopeParameter.Location = new Point(4, 274);
			this.labelSlopeParameter.Margin = new Padding(4, 3, 4, 3);
			this.labelSlopeParameter.Name = "labelSlopeParameter";
			this.labelSlopeParameter.Size = new Size(238, 25);
			this.labelSlopeParameter.TabIndex = 36;
			this.toolTip.SetToolTip(this.labelSlopeParameter, "Slope parameter, G");
			this.labelSlopeParameter.Values.Text = "Slope parameter, G";
			this.labelSlopeParameter.Enter += this.SetStatusBar_Enter;
			this.labelSlopeParameter.Leave += this.ClearStatusBar_Leave;
			this.labelSlopeParameter.MouseEnter += this.SetStatusBar_Enter;
			this.labelSlopeParameter.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelMeanDailyMotion
			// 
			this.labelMeanDailyMotion.AccessibleDescription = "Shows the minimum and maximum of mean daily motion";
			this.labelMeanDailyMotion.AccessibleName = "Mean daily motion";
			this.labelMeanDailyMotion.AccessibleRole = AccessibleRole.StaticText;
			this.labelMeanDailyMotion.Dock = DockStyle.Fill;
			this.labelMeanDailyMotion.Location = new Point(4, 181);
			this.labelMeanDailyMotion.Margin = new Padding(4, 3, 4, 3);
			this.labelMeanDailyMotion.Name = "labelMeanDailyMotion";
			this.labelMeanDailyMotion.Size = new Size(238, 25);
			this.labelMeanDailyMotion.TabIndex = 24;
			this.toolTip.SetToolTip(this.labelMeanDailyMotion, "Mean daily motion");
			this.labelMeanDailyMotion.Values.Text = "Mean daily motion";
			this.labelMeanDailyMotion.Enter += this.SetStatusBar_Enter;
			this.labelMeanDailyMotion.Leave += this.ClearStatusBar_Leave;
			this.labelMeanDailyMotion.MouseEnter += this.SetStatusBar_Enter;
			this.labelMeanDailyMotion.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelAbsoluteMagnitude
			// 
			this.labelAbsoluteMagnitude.AccessibleDescription = "Shows the minimum and maximum of absolute magnitude";
			this.labelAbsoluteMagnitude.AccessibleName = "Absolute magnitude";
			this.labelAbsoluteMagnitude.AccessibleRole = AccessibleRole.StaticText;
			this.labelAbsoluteMagnitude.Dock = DockStyle.Fill;
			this.labelAbsoluteMagnitude.Location = new Point(4, 243);
			this.labelAbsoluteMagnitude.Margin = new Padding(4, 3, 4, 3);
			this.labelAbsoluteMagnitude.Name = "labelAbsoluteMagnitude";
			this.labelAbsoluteMagnitude.Size = new Size(238, 25);
			this.labelAbsoluteMagnitude.TabIndex = 32;
			this.toolTip.SetToolTip(this.labelAbsoluteMagnitude, "Absolute magnitude, H");
			this.labelAbsoluteMagnitude.Values.Text = "Absolute magnitude, H";
			this.labelAbsoluteMagnitude.Enter += this.SetStatusBar_Enter;
			this.labelAbsoluteMagnitude.Leave += this.ClearStatusBar_Leave;
			this.labelAbsoluteMagnitude.MouseEnter += this.SetStatusBar_Enter;
			this.labelAbsoluteMagnitude.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelSemiMajorAxis
			// 
			this.labelSemiMajorAxis.AccessibleDescription = "Shows the minimum and maximum of semi-major axis";
			this.labelSemiMajorAxis.AccessibleName = "Semi-major axis";
			this.labelSemiMajorAxis.AccessibleRole = AccessibleRole.StaticText;
			this.labelSemiMajorAxis.Dock = DockStyle.Fill;
			this.labelSemiMajorAxis.Location = new Point(4, 212);
			this.labelSemiMajorAxis.Margin = new Padding(4, 3, 4, 3);
			this.labelSemiMajorAxis.Name = "labelSemiMajorAxis";
			this.labelSemiMajorAxis.Size = new Size(238, 25);
			this.labelSemiMajorAxis.TabIndex = 28;
			this.toolTip.SetToolTip(this.labelSemiMajorAxis, "Semi-major axis");
			this.labelSemiMajorAxis.Values.Text = "Semi-major axis";
			this.labelSemiMajorAxis.Enter += this.SetStatusBar_Enter;
			this.labelSemiMajorAxis.Leave += this.ClearStatusBar_Leave;
			this.labelSemiMajorAxis.MouseEnter += this.SetStatusBar_Enter;
			this.labelSemiMajorAxis.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelMeanAnomalyAtTheEpoch
			// 
			this.labelMeanAnomalyAtTheEpoch.AccessibleDescription = "Shows the minimum and maximum of mean anomaly at the epoch";
			this.labelMeanAnomalyAtTheEpoch.AccessibleName = "Mean anomaly at the epoch";
			this.labelMeanAnomalyAtTheEpoch.AccessibleRole = AccessibleRole.StaticText;
			this.labelMeanAnomalyAtTheEpoch.Dock = DockStyle.Fill;
			this.labelMeanAnomalyAtTheEpoch.Location = new Point(4, 26);
			this.labelMeanAnomalyAtTheEpoch.Margin = new Padding(4, 3, 4, 3);
			this.labelMeanAnomalyAtTheEpoch.Name = "labelMeanAnomalyAtTheEpoch";
			this.labelMeanAnomalyAtTheEpoch.Size = new Size(238, 25);
			this.labelMeanAnomalyAtTheEpoch.TabIndex = 4;
			this.toolTip.SetToolTip(this.labelMeanAnomalyAtTheEpoch, "Mean anomaly at the epoch");
			this.labelMeanAnomalyAtTheEpoch.Values.Text = "Mean anomaly at the epoch";
			this.labelMeanAnomalyAtTheEpoch.Enter += this.SetStatusBar_Enter;
			this.labelMeanAnomalyAtTheEpoch.Leave += this.ClearStatusBar_Leave;
			this.labelMeanAnomalyAtTheEpoch.MouseEnter += this.SetStatusBar_Enter;
			this.labelMeanAnomalyAtTheEpoch.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetInclination
			// 
			this.buttonResetInclination.AccessibleDescription = "Resets the minimum and maximum of inclination to the ecliptic";
			this.buttonResetInclination.AccessibleName = "Reset the minimum and maximum of inclination to the ecliptic";
			this.buttonResetInclination.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetInclination.ButtonStyle = ButtonStyle.Form;
			this.buttonResetInclination.Dock = DockStyle.Fill;
			this.buttonResetInclination.Location = new Point(506, 119);
			this.buttonResetInclination.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetInclination.Name = "buttonResetInclination";
			this.buttonResetInclination.Size = new Size(85, 25);
			this.buttonResetInclination.TabIndex = 19;
			this.toolTip.SetToolTip(this.buttonResetInclination, "Reset the minimum and maximum of inclination to the ecliptic");
			this.buttonResetInclination.ToolTipValues.EnableToolTips = true;
			this.buttonResetInclination.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetInclination.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetInclination.Values.Text = "";
			this.buttonResetInclination.Click += this.ButtonResetInclination_Click;
			this.buttonResetInclination.Enter += this.SetStatusBar_Enter;
			this.buttonResetInclination.Leave += this.ClearStatusBar_Leave;
			this.buttonResetInclination.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetInclination.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// buttonResetOrbitalEccentricity
			// 
			this.buttonResetOrbitalEccentricity.AccessibleDescription = "Resets the minimum and maximum of orbital eccentricity";
			this.buttonResetOrbitalEccentricity.AccessibleName = "Reset the minimum and maximum of orbital eccentricity";
			this.buttonResetOrbitalEccentricity.AccessibleRole = AccessibleRole.PushButton;
			this.buttonResetOrbitalEccentricity.ButtonStyle = ButtonStyle.Form;
			this.buttonResetOrbitalEccentricity.Dock = DockStyle.Fill;
			this.buttonResetOrbitalEccentricity.Location = new Point(506, 150);
			this.buttonResetOrbitalEccentricity.Margin = new Padding(4, 3, 4, 3);
			this.buttonResetOrbitalEccentricity.Name = "buttonResetOrbitalEccentricity";
			this.buttonResetOrbitalEccentricity.Size = new Size(85, 25);
			this.buttonResetOrbitalEccentricity.TabIndex = 23;
			this.toolTip.SetToolTip(this.buttonResetOrbitalEccentricity, "Reset the minimum and maximum of orbital eccentricity");
			this.buttonResetOrbitalEccentricity.ToolTipValues.EnableToolTips = true;
			this.buttonResetOrbitalEccentricity.Values.DropDownArrowColor = Color.Empty;
			this.buttonResetOrbitalEccentricity.Values.Image = FatcowIcons16px.fatcow_update_16px;
			this.buttonResetOrbitalEccentricity.Values.Text = "";
			this.buttonResetOrbitalEccentricity.Click += this.ButtonResetOrbitalEccentricity_Click;
			this.buttonResetOrbitalEccentricity.Enter += this.SetStatusBar_Enter;
			this.buttonResetOrbitalEccentricity.Leave += this.ClearStatusBar_Leave;
			this.buttonResetOrbitalEccentricity.MouseEnter += this.SetStatusBar_Enter;
			this.buttonResetOrbitalEccentricity.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// labelHeaderElement
			// 
			this.labelHeaderElement.AccessibleDescription = "Shows the header of the orbital elements";
			this.labelHeaderElement.AccessibleName = "Header of the orbital elements";
			this.labelHeaderElement.AccessibleRole = AccessibleRole.StaticText;
			this.labelHeaderElement.Dock = DockStyle.Fill;
			this.labelHeaderElement.LabelStyle = LabelStyle.BoldPanel;
			this.labelHeaderElement.Location = new Point(4, 3);
			this.labelHeaderElement.Margin = new Padding(4, 3, 4, 3);
			this.labelHeaderElement.Name = "labelHeaderElement";
			this.labelHeaderElement.Size = new Size(238, 17);
			this.labelHeaderElement.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelHeaderElement, "Header of the orbital elements");
			this.labelHeaderElement.Values.Text = "Element";
			this.labelHeaderElement.Enter += this.SetStatusBar_Enter;
			this.labelHeaderElement.Leave += this.ClearStatusBar_Leave;
			this.labelHeaderElement.MouseEnter += this.SetStatusBar_Enter;
			this.labelHeaderElement.MouseLeave += this.ClearStatusBar_Leave;
			// 
			// kryptonManager
			// 
			this.kryptonManager.GlobalPaletteMode = PaletteMode.Global;
			// 
			// FilterForm
			// 
			this.AccessibleDescription = "Shows the filter";
			this.AccessibleName = "Filter";
			this.AccessibleRole = AccessibleRole.Dialog;
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(607, 470);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Margin = new Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FilterForm";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Filter";
			this.toolTip.SetToolTip(this, "Filter");
			this.FormClosed += this.FilterForm_FormClosed;
			this.Load += this.FilterForm_Load;
			((ISupportInitialize)this.panel).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private KryptonPanel panel;
		private KryptonLabel labelMeanAnomalyAtTheEpoch;
		private KryptonLabel labelArgumentOfPerihelion;
		private KryptonLabel labelNumberOfOppositions;
		private KryptonLabel labelSlopeParameter;
		private KryptonLabel labelAbsoluteMagnitude;
		private KryptonLabel labelSemiMajorAxis;
		private KryptonLabel labelMeanDailyMotion;
		private KryptonLabel labelOrbitalEccentricity;
		private KryptonLabel labelInclination;
		private KryptonLabel labelLongitudeOfTheAscendingNode;
		private KryptonLabel labelRmsResidual;
		private KryptonLabel labelNumberOfObservations;
		private KryptonTableLayoutPanel tableLayoutPanel;
		private KryptonNumericUpDown numericUpDownMinimumMeanAnomalyAtTheEpoch;
		private KryptonNumericUpDown numericUpDownMinimumArgumentOfPerihelion;
		private KryptonNumericUpDown numericUpDownMinimumInclination;
		private KryptonNumericUpDown numericUpDownMinimumLongitudeOfTheAscendingNode;
		private KryptonNumericUpDown numericUpDownMaximumAbsoluteMagnitude;
		private KryptonNumericUpDown numericUpDownMaximumSemiMajorAxis;
		private KryptonNumericUpDown numericUpDownMaximumMeanDailyMotion;
		private KryptonNumericUpDown numericUpDownMaximumOrbitalEccentricity;
		private KryptonNumericUpDown numericUpDownMaximumInclination;
		private KryptonNumericUpDown numericUpDownMaximumLongitudeOfTheAscendingNode;
		private KryptonNumericUpDown numericUpDownMaximumArgumentOfPerihelion;
		private KryptonNumericUpDown numericUpDownMaximumMeanAnomalyAtTheEpoch;
		private KryptonNumericUpDown numericUpDownMinimumRmsResidual;
		private KryptonNumericUpDown numericUpDownMinimumNumberOfObservations;
		private KryptonNumericUpDown numericUpDownMinimumNumberOfOppositions;
		private KryptonNumericUpDown numericUpDownMinimumSlopeParameter;
		private KryptonNumericUpDown numericUpDownMinimumAbsoluteMagnitude;
		private KryptonNumericUpDown numericUpDownMinimumSemiMajorAxis;
		private KryptonNumericUpDown numericUpDownMinimumMeanDailyMotion;
		private KryptonNumericUpDown numericUpDownMinimumOrbitalEccentricity;
		private KryptonNumericUpDown numericUpDownMaximumRmsResidual;
		private KryptonNumericUpDown numericUpDownMaximumNumberOfObservations;
		private KryptonNumericUpDown numericUpDownMaximumNumberOfOppositions;
		private KryptonNumericUpDown numericUpDownMaximumSlopeParameter;
		private KryptonButton buttonResetMeanAnomalyAtTheEpoch;
		private KryptonButton buttonResetRmsResidual;
		private KryptonButton buttonResetNumberOfObservations;
		private KryptonButton buttonNumberOfOppositions;
		private KryptonButton buttonResetSlopeParameter;
		private KryptonButton buttonResetAbsoluteMagnitude;
		private KryptonButton buttonResetSemiMajorAxis;
		private KryptonButton buttonResetMeanDailyMotion;
		private KryptonButton buttonResetLongitudeOfTheAscendingNode;
		private KryptonButton buttonResetArgumentOfPerihelion;
		private KryptonButton buttonResetInclination;
		private KryptonButton buttonResetOrbitalEccentricity;
		private KryptonLabel labelHeaderReset;
		private KryptonLabel labelHeaderMaximum;
		private KryptonLabel labelHeaderMinimum;
		private KryptonLabel labelHeaderElement;
		private KryptonButton buttonApply;
		private KryptonButton buttonReset;
		private KryptonButton buttonCancel;
		private KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolTip toolTip;
		private KryptonManager kryptonManager;
	}
}