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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonOK = new System.Windows.Forms.Button();
			this.linkLabelLinearEccentricityDesc = new System.Windows.Forms.LinkLabel();
			this.contextMenuCopyToClipboard = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelLinearEccentricityData = new System.Windows.Forms.Label();
			this.linkLabelSemiMinorAxisDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelMajorAxisDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelMinorAxisDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelEccenctricAnomalyDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelTrueAnomalyDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelPerihelionDistanceDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelAphelionDistanceDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelLongitudeDescendingNodeDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabel1ArgumentAphelionDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelFocalParameterDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelSemiLatusRectumDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelLatusRectumDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelPeriodDesc = new System.Windows.Forms.LinkLabel();
			this.labelSemiMinorAxisData = new System.Windows.Forms.Label();
			this.labelMajorAxisData = new System.Windows.Forms.Label();
			this.labelMinorAxisData = new System.Windows.Forms.Label();
			this.labelEccentricAnomalyData = new System.Windows.Forms.Label();
			this.labelTrueAnomalyData = new System.Windows.Forms.Label();
			this.labelPerihelionDistanceData = new System.Windows.Forms.Label();
			this.labelAphelionDistanceData = new System.Windows.Forms.Label();
			this.labelLongitudeDescendingNodeData = new System.Windows.Forms.Label();
			this.labelArgumentAphelionData = new System.Windows.Forms.Label();
			this.labelFocalParameterData = new System.Windows.Forms.Label();
			this.labelSemiLatusRectumData = new System.Windows.Forms.Label();
			this.labelLatusRectumData = new System.Windows.Forms.Label();
			this.labelPeriodData = new System.Windows.Forms.Label();
			this.linkLabelOrbitalAreaDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelOrbitalPerimeterDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelSemiMeanAxisDesc = new System.Windows.Forms.LinkLabel();
			this.linkLabelMeanAxisDesc = new System.Windows.Forms.LinkLabel();
			this.labelOrbitalAreaData = new System.Windows.Forms.Label();
			this.labelOrbitalPerimeterData = new System.Windows.Forms.Label();
			this.labelSemiMeanAxisData = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelMeanAxisData = new System.Windows.Forms.Label();
			this.statusStrip.SuspendLayout();
			this.contextMenuCopyToClipboard.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the status";
			this.statusStrip.AccessibleName = "Status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 345);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(389, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 2;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Show some important informations";
			this.labelInformation.AccessibleName = "Information field";
			this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelInformation.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelInformation.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(170, 16);
			this.labelInformation.Text = "Show informative messages";
			this.labelInformation.ToolTipText = "Show informative messages";
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Okay";
			this.buttonOK.AccessibleName = "OK";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(0, 309);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(389, 36);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "OK");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			this.buttonOK.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelLinearEccentricityDesc
			// 
			this.linkLabelLinearEccentricityDesc.AccessibleDescription = "Linear eccentricity";
			this.linkLabelLinearEccentricityDesc.AccessibleName = "Linear eccentricity";
			this.linkLabelLinearEccentricityDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelLinearEccentricityDesc.AutoSize = true;
			this.linkLabelLinearEccentricityDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelLinearEccentricityDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelLinearEccentricityDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelLinearEccentricityDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelLinearEccentricityDesc.Location = new System.Drawing.Point(5, 2);
			this.linkLabelLinearEccentricityDesc.Name = "linkLabelLinearEccentricityDesc";
			this.linkLabelLinearEccentricityDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelLinearEccentricityDesc.TabIndex = 0;
			this.linkLabelLinearEccentricityDesc.TabStop = true;
			this.linkLabelLinearEccentricityDesc.Text = "Linear eccentricity";
			this.toolTip.SetToolTip(this.linkLabelLinearEccentricityDesc, "Linear eccentricity");
			this.linkLabelLinearEccentricityDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLinearEccentricity_LinkClicked);
			this.linkLabelLinearEccentricityDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLinearEccentricityDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelLinearEccentricityDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLinearEccentricityDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuCopyToClipboard
			// 
			this.contextMenuCopyToClipboard.AccessibleDescription = "Show the context menu of copying to clipboard";
			this.contextMenuCopyToClipboard.AccessibleName = "Context menu of copying to clipboard";
			this.contextMenuCopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
			this.contextMenuCopyToClipboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
			this.contextMenuCopyToClipboard.Name = "contextMenuCopyToClipboard";
			this.contextMenuCopyToClipboard.Size = new System.Drawing.Size(208, 26);
			this.contextMenuCopyToClipboard.TabStop = true;
			this.contextMenuCopyToClipboard.Text = "Copy to clipboard";
			this.toolTip.SetToolTip(this.contextMenuCopyToClipboard, "Copy to clipboard");
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.AccessibleDescription = "Click to copy into the clipboard";
			this.copyToClipboardToolStripMenuItem.AccessibleName = "Copy to clipboard";
			this.copyToClipboardToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.copyToClipboardToolStripMenuItem.AutoToolTip = true;
			this.copyToClipboardToolStripMenuItem.Image = global::Planetoid_DB.Properties.Resources.silk_page_copy;
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.copyToClipboardToolStripMenuItem.Text = "&Copy to clipboard";
			// 
			// labelLinearEccentricityData
			// 
			this.labelLinearEccentricityData.AccessibleDescription = "Show the information of \"Linear eccentricity\"";
			this.labelLinearEccentricityData.AccessibleName = "Show the information of \"Linear eccentricity\"";
			this.labelLinearEccentricityData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLinearEccentricityData.AutoSize = true;
			this.labelLinearEccentricityData.BackColor = System.Drawing.Color.Transparent;
			this.labelLinearEccentricityData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLinearEccentricityData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLinearEccentricityData.Location = new System.Drawing.Point(198, 2);
			this.labelLinearEccentricityData.Name = "labelLinearEccentricityData";
			this.labelLinearEccentricityData.Size = new System.Drawing.Size(186, 15);
			this.labelLinearEccentricityData.TabIndex = 1;
			this.labelLinearEccentricityData.Text = "...";
			this.toolTip.SetToolTip(this.labelLinearEccentricityData, "Show the information of \"Linear eccentricity\"");
			this.labelLinearEccentricityData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelLinearEccentricityData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricityData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLinearEccentricityData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricityData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSemiMinorAxisDesc
			// 
			this.linkLabelSemiMinorAxisDesc.AccessibleDescription = "Semi-minor axis";
			this.linkLabelSemiMinorAxisDesc.AccessibleName = "Semi-minor axis";
			this.linkLabelSemiMinorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSemiMinorAxisDesc.AutoSize = true;
			this.linkLabelSemiMinorAxisDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelSemiMinorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSemiMinorAxisDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSemiMinorAxisDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSemiMinorAxisDesc.Location = new System.Drawing.Point(5, 19);
			this.linkLabelSemiMinorAxisDesc.Name = "linkLabelSemiMinorAxisDesc";
			this.linkLabelSemiMinorAxisDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelSemiMinorAxisDesc.TabIndex = 2;
			this.linkLabelSemiMinorAxisDesc.TabStop = true;
			this.linkLabelSemiMinorAxisDesc.Text = "Semi-minor axis (AU)";
			this.toolTip.SetToolTip(this.linkLabelSemiMinorAxisDesc, "Semi-minor axis");
			this.linkLabelSemiMinorAxisDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSemiMinorAxis_LinkClicked);
			this.linkLabelSemiMinorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMinorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSemiMinorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMinorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMajorAxisDesc
			// 
			this.linkLabelMajorAxisDesc.AccessibleDescription = "Major axis";
			this.linkLabelMajorAxisDesc.AccessibleName = "Major axis";
			this.linkLabelMajorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMajorAxisDesc.AutoSize = true;
			this.linkLabelMajorAxisDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelMajorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMajorAxisDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMajorAxisDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMajorAxisDesc.Location = new System.Drawing.Point(5, 36);
			this.linkLabelMajorAxisDesc.Name = "linkLabelMajorAxisDesc";
			this.linkLabelMajorAxisDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelMajorAxisDesc.TabIndex = 4;
			this.linkLabelMajorAxisDesc.TabStop = true;
			this.linkLabelMajorAxisDesc.Text = "Major axis (AU)";
			this.toolTip.SetToolTip(this.linkLabelMajorAxisDesc, "Major axis");
			this.linkLabelMajorAxisDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMajorAxis_LinkClicked);
			this.linkLabelMajorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMajorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMajorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMajorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMinorAxisDesc
			// 
			this.linkLabelMinorAxisDesc.AccessibleDescription = "Minor axis";
			this.linkLabelMinorAxisDesc.AccessibleName = "Minor axis";
			this.linkLabelMinorAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMinorAxisDesc.AutoSize = true;
			this.linkLabelMinorAxisDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelMinorAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMinorAxisDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMinorAxisDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMinorAxisDesc.Location = new System.Drawing.Point(5, 53);
			this.linkLabelMinorAxisDesc.Name = "linkLabelMinorAxisDesc";
			this.linkLabelMinorAxisDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelMinorAxisDesc.TabIndex = 6;
			this.linkLabelMinorAxisDesc.TabStop = true;
			this.linkLabelMinorAxisDesc.Text = "Minor axis (AU)";
			this.toolTip.SetToolTip(this.linkLabelMinorAxisDesc, "Minor axis");
			this.linkLabelMinorAxisDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMinorAxis_LinkClicked);
			this.linkLabelMinorAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMinorAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMinorAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMinorAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelEccenctricAnomalyDesc
			// 
			this.linkLabelEccenctricAnomalyDesc.AccessibleDescription = "Eccentric anomaly";
			this.linkLabelEccenctricAnomalyDesc.AccessibleName = "Eccentric anomaly";
			this.linkLabelEccenctricAnomalyDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelEccenctricAnomalyDesc.AutoSize = true;
			this.linkLabelEccenctricAnomalyDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelEccenctricAnomalyDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelEccenctricAnomalyDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelEccenctricAnomalyDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelEccenctricAnomalyDesc.Location = new System.Drawing.Point(5, 70);
			this.linkLabelEccenctricAnomalyDesc.Name = "linkLabelEccenctricAnomalyDesc";
			this.linkLabelEccenctricAnomalyDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelEccenctricAnomalyDesc.TabIndex = 8;
			this.linkLabelEccenctricAnomalyDesc.TabStop = true;
			this.linkLabelEccenctricAnomalyDesc.Text = "Eccentric anomaly (°)";
			this.toolTip.SetToolTip(this.linkLabelEccenctricAnomalyDesc, "Eccentric anomaly");
			this.linkLabelEccenctricAnomalyDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEccenctricAnomaly_LinkClicked);
			this.linkLabelEccenctricAnomalyDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEccenctricAnomalyDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelEccenctricAnomalyDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEccenctricAnomalyDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelTrueAnomalyDesc
			// 
			this.linkLabelTrueAnomalyDesc.AccessibleDescription = "True anomaly";
			this.linkLabelTrueAnomalyDesc.AccessibleName = "True anomaly";
			this.linkLabelTrueAnomalyDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelTrueAnomalyDesc.AutoSize = true;
			this.linkLabelTrueAnomalyDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelTrueAnomalyDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelTrueAnomalyDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelTrueAnomalyDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelTrueAnomalyDesc.Location = new System.Drawing.Point(5, 87);
			this.linkLabelTrueAnomalyDesc.Name = "linkLabelTrueAnomalyDesc";
			this.linkLabelTrueAnomalyDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelTrueAnomalyDesc.TabIndex = 10;
			this.linkLabelTrueAnomalyDesc.TabStop = true;
			this.linkLabelTrueAnomalyDesc.Text = "True anomaly (°)";
			this.toolTip.SetToolTip(this.linkLabelTrueAnomalyDesc, "True anomaly");
			this.linkLabelTrueAnomalyDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelTrueAnomaly_LinkClicked);
			this.linkLabelTrueAnomalyDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelTrueAnomalyDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelTrueAnomalyDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelTrueAnomalyDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelPerihelionDistanceDesc
			// 
			this.linkLabelPerihelionDistanceDesc.AccessibleDescription = "Perihelion distance";
			this.linkLabelPerihelionDistanceDesc.AccessibleName = "Perihelion distance";
			this.linkLabelPerihelionDistanceDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelPerihelionDistanceDesc.AutoSize = true;
			this.linkLabelPerihelionDistanceDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelPerihelionDistanceDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelPerihelionDistanceDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelPerihelionDistanceDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelPerihelionDistanceDesc.Location = new System.Drawing.Point(5, 104);
			this.linkLabelPerihelionDistanceDesc.Name = "linkLabelPerihelionDistanceDesc";
			this.linkLabelPerihelionDistanceDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelPerihelionDistanceDesc.TabIndex = 12;
			this.linkLabelPerihelionDistanceDesc.TabStop = true;
			this.linkLabelPerihelionDistanceDesc.Text = "Perihelion distance (AU)";
			this.toolTip.SetToolTip(this.linkLabelPerihelionDistanceDesc, "Perihelion distance");
			this.linkLabelPerihelionDistanceDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPerihelionDistance_LinkClicked);
			this.linkLabelPerihelionDistanceDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPerihelionDistanceDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelPerihelionDistanceDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPerihelionDistanceDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelAphelionDistanceDesc
			// 
			this.linkLabelAphelionDistanceDesc.AccessibleDescription = "Aphelion distance";
			this.linkLabelAphelionDistanceDesc.AccessibleName = "Aphelion distance";
			this.linkLabelAphelionDistanceDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelAphelionDistanceDesc.AutoSize = true;
			this.linkLabelAphelionDistanceDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelAphelionDistanceDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelAphelionDistanceDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelAphelionDistanceDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelAphelionDistanceDesc.Location = new System.Drawing.Point(5, 121);
			this.linkLabelAphelionDistanceDesc.Name = "linkLabelAphelionDistanceDesc";
			this.linkLabelAphelionDistanceDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelAphelionDistanceDesc.TabIndex = 14;
			this.linkLabelAphelionDistanceDesc.TabStop = true;
			this.linkLabelAphelionDistanceDesc.Text = "Aphelion distance (AU)";
			this.toolTip.SetToolTip(this.linkLabelAphelionDistanceDesc, "Aphelion distance");
			this.linkLabelAphelionDistanceDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAphelionDistance_LinkClicked);
			this.linkLabelAphelionDistanceDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelAphelionDistanceDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelAphelionDistanceDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelAphelionDistanceDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelLongitudeDescendingNodeDesc
			// 
			this.linkLabelLongitudeDescendingNodeDesc.AccessibleDescription = "Longitude of descending node";
			this.linkLabelLongitudeDescendingNodeDesc.AccessibleName = "Longitude of descending node";
			this.linkLabelLongitudeDescendingNodeDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelLongitudeDescendingNodeDesc.AutoSize = true;
			this.linkLabelLongitudeDescendingNodeDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelLongitudeDescendingNodeDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelLongitudeDescendingNodeDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelLongitudeDescendingNodeDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelLongitudeDescendingNodeDesc.Location = new System.Drawing.Point(5, 138);
			this.linkLabelLongitudeDescendingNodeDesc.Name = "linkLabelLongitudeDescendingNodeDesc";
			this.linkLabelLongitudeDescendingNodeDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelLongitudeDescendingNodeDesc.TabIndex = 16;
			this.linkLabelLongitudeDescendingNodeDesc.TabStop = true;
			this.linkLabelLongitudeDescendingNodeDesc.Text = "Longitude of descending node (°)";
			this.toolTip.SetToolTip(this.linkLabelLongitudeDescendingNodeDesc, "Longitude of descending node");
			this.linkLabelLongitudeDescendingNodeDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLongitudeDescendingNode_LinkClicked);
			this.linkLabelLongitudeDescendingNodeDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLongitudeDescendingNodeDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelLongitudeDescendingNodeDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLongitudeDescendingNodeDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabel1ArgumentAphelionDesc
			// 
			this.linkLabel1ArgumentAphelionDesc.AccessibleDescription = "Argument of aphelion";
			this.linkLabel1ArgumentAphelionDesc.AccessibleName = "Argument of aphelion";
			this.linkLabel1ArgumentAphelionDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabel1ArgumentAphelionDesc.AutoSize = true;
			this.linkLabel1ArgumentAphelionDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1ArgumentAphelionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabel1ArgumentAphelionDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel1ArgumentAphelionDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabel1ArgumentAphelionDesc.Location = new System.Drawing.Point(5, 155);
			this.linkLabel1ArgumentAphelionDesc.Name = "linkLabel1ArgumentAphelionDesc";
			this.linkLabel1ArgumentAphelionDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabel1ArgumentAphelionDesc.TabIndex = 18;
			this.linkLabel1ArgumentAphelionDesc.TabStop = true;
			this.linkLabel1ArgumentAphelionDesc.Text = "Argument of aphelion (°)";
			this.toolTip.SetToolTip(this.linkLabel1ArgumentAphelionDesc, "Argument of aphelion");
			this.linkLabel1ArgumentAphelionDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1ArgumentAphelion_LinkClicked);
			this.linkLabel1ArgumentAphelionDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabel1ArgumentAphelionDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabel1ArgumentAphelionDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabel1ArgumentAphelionDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelFocalParameterDesc
			// 
			this.linkLabelFocalParameterDesc.AccessibleDescription = "Focal parameter";
			this.linkLabelFocalParameterDesc.AccessibleName = "Focal parameter";
			this.linkLabelFocalParameterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelFocalParameterDesc.AutoSize = true;
			this.linkLabelFocalParameterDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelFocalParameterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelFocalParameterDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelFocalParameterDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelFocalParameterDesc.Location = new System.Drawing.Point(5, 172);
			this.linkLabelFocalParameterDesc.Name = "linkLabelFocalParameterDesc";
			this.linkLabelFocalParameterDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelFocalParameterDesc.TabIndex = 20;
			this.linkLabelFocalParameterDesc.TabStop = true;
			this.linkLabelFocalParameterDesc.Text = "Focal parameter";
			this.toolTip.SetToolTip(this.linkLabelFocalParameterDesc, "Focal parameter");
			this.linkLabelFocalParameterDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelFocalParameter_LinkClicked);
			this.linkLabelFocalParameterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelFocalParameterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelFocalParameterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelFocalParameterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSemiLatusRectumDesc
			// 
			this.linkLabelSemiLatusRectumDesc.AccessibleDescription = "Semi-latus rectum";
			this.linkLabelSemiLatusRectumDesc.AccessibleName = "Semi-latus rectum";
			this.linkLabelSemiLatusRectumDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSemiLatusRectumDesc.AutoSize = true;
			this.linkLabelSemiLatusRectumDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelSemiLatusRectumDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSemiLatusRectumDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSemiLatusRectumDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSemiLatusRectumDesc.Location = new System.Drawing.Point(5, 189);
			this.linkLabelSemiLatusRectumDesc.Name = "linkLabelSemiLatusRectumDesc";
			this.linkLabelSemiLatusRectumDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelSemiLatusRectumDesc.TabIndex = 22;
			this.linkLabelSemiLatusRectumDesc.TabStop = true;
			this.linkLabelSemiLatusRectumDesc.Text = "Semi-latus rectum (AU)";
			this.toolTip.SetToolTip(this.linkLabelSemiLatusRectumDesc, "Semi-latus rectum");
			this.linkLabelSemiLatusRectumDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSemiLatusRectum_LinkClicked);
			this.linkLabelSemiLatusRectumDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiLatusRectumDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSemiLatusRectumDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiLatusRectumDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelLatusRectumDesc
			// 
			this.linkLabelLatusRectumDesc.AccessibleDescription = "Latus rectum";
			this.linkLabelLatusRectumDesc.AccessibleName = "Latus rectum";
			this.linkLabelLatusRectumDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelLatusRectumDesc.AutoSize = true;
			this.linkLabelLatusRectumDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelLatusRectumDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelLatusRectumDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelLatusRectumDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelLatusRectumDesc.Location = new System.Drawing.Point(5, 206);
			this.linkLabelLatusRectumDesc.Name = "linkLabelLatusRectumDesc";
			this.linkLabelLatusRectumDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelLatusRectumDesc.TabIndex = 24;
			this.linkLabelLatusRectumDesc.TabStop = true;
			this.linkLabelLatusRectumDesc.Text = "Latus rectum (AU)";
			this.toolTip.SetToolTip(this.linkLabelLatusRectumDesc, "Latus rectum");
			this.linkLabelLatusRectumDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLatusRectum_LinkClicked);
			this.linkLabelLatusRectumDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLatusRectumDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelLatusRectumDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLatusRectumDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelPeriodDesc
			// 
			this.linkLabelPeriodDesc.AccessibleDescription = "Period";
			this.linkLabelPeriodDesc.AccessibleName = "Period";
			this.linkLabelPeriodDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelPeriodDesc.AutoSize = true;
			this.linkLabelPeriodDesc.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelPeriodDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelPeriodDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelPeriodDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelPeriodDesc.Location = new System.Drawing.Point(5, 223);
			this.linkLabelPeriodDesc.Name = "linkLabelPeriodDesc";
			this.linkLabelPeriodDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelPeriodDesc.TabIndex = 26;
			this.linkLabelPeriodDesc.TabStop = true;
			this.linkLabelPeriodDesc.Text = "Period (years)";
			this.toolTip.SetToolTip(this.linkLabelPeriodDesc, "Period");
			this.linkLabelPeriodDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPeriod_LinkClicked);
			this.linkLabelPeriodDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPeriodDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelPeriodDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPeriodDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMinorAxisData
			// 
			this.labelSemiMinorAxisData.AccessibleDescription = "Show the information of \"Semi-minor axis\"";
			this.labelSemiMinorAxisData.AccessibleName = "Show the information of \"Semi-minor axis\"";
			this.labelSemiMinorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMinorAxisData.AutoSize = true;
			this.labelSemiMinorAxisData.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiMinorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMinorAxisData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSemiMinorAxisData.Location = new System.Drawing.Point(198, 19);
			this.labelSemiMinorAxisData.Name = "labelSemiMinorAxisData";
			this.labelSemiMinorAxisData.Size = new System.Drawing.Size(186, 15);
			this.labelSemiMinorAxisData.TabIndex = 3;
			this.labelSemiMinorAxisData.Text = "...";
			this.toolTip.SetToolTip(this.labelSemiMinorAxisData, "Show the information of \"Semi-minor axis\"");
			this.labelSemiMinorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSemiMinorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMinorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMajorAxisData
			// 
			this.labelMajorAxisData.AccessibleDescription = "Show the information of \"Major axis\"";
			this.labelMajorAxisData.AccessibleName = "Show the information of \"Major axis\"";
			this.labelMajorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMajorAxisData.AutoSize = true;
			this.labelMajorAxisData.BackColor = System.Drawing.Color.Transparent;
			this.labelMajorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMajorAxisData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMajorAxisData.Location = new System.Drawing.Point(198, 36);
			this.labelMajorAxisData.Name = "labelMajorAxisData";
			this.labelMajorAxisData.Size = new System.Drawing.Size(186, 15);
			this.labelMajorAxisData.TabIndex = 5;
			this.labelMajorAxisData.Text = "...";
			this.toolTip.SetToolTip(this.labelMajorAxisData, "Show the information of \"Major axis\"");
			this.labelMajorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMajorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMajorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMinorAxisData
			// 
			this.labelMinorAxisData.AccessibleDescription = "Show the information of \"Minor axis\"";
			this.labelMinorAxisData.AccessibleName = "Show the information of \"Minor axis\"";
			this.labelMinorAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMinorAxisData.AutoSize = true;
			this.labelMinorAxisData.BackColor = System.Drawing.Color.Transparent;
			this.labelMinorAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinorAxisData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMinorAxisData.Location = new System.Drawing.Point(198, 53);
			this.labelMinorAxisData.Name = "labelMinorAxisData";
			this.labelMinorAxisData.Size = new System.Drawing.Size(186, 15);
			this.labelMinorAxisData.TabIndex = 7;
			this.labelMinorAxisData.Text = "...";
			this.toolTip.SetToolTip(this.labelMinorAxisData, "Show the information of \"Minor axis\"");
			this.labelMinorAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMinorAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMinorAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEccentricAnomalyData
			// 
			this.labelEccentricAnomalyData.AccessibleDescription = "Show the information of \"Eccentric anomaly\"";
			this.labelEccentricAnomalyData.AccessibleName = "Show the information of \"Eccentric anomaly\"";
			this.labelEccentricAnomalyData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEccentricAnomalyData.AutoSize = true;
			this.labelEccentricAnomalyData.BackColor = System.Drawing.Color.Transparent;
			this.labelEccentricAnomalyData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEccentricAnomalyData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEccentricAnomalyData.Location = new System.Drawing.Point(198, 70);
			this.labelEccentricAnomalyData.Name = "labelEccentricAnomalyData";
			this.labelEccentricAnomalyData.Size = new System.Drawing.Size(186, 15);
			this.labelEccentricAnomalyData.TabIndex = 9;
			this.labelEccentricAnomalyData.Text = "...";
			this.toolTip.SetToolTip(this.labelEccentricAnomalyData, "Show the information of \"Eccentric anomaly\"");
			this.labelEccentricAnomalyData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelEccentricAnomalyData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccentricAnomalyData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEccentricAnomalyData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccentricAnomalyData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTrueAnomalyData
			// 
			this.labelTrueAnomalyData.AccessibleDescription = "Show the information of \"True anomaly\"";
			this.labelTrueAnomalyData.AccessibleName = "Show the information of \"True anomaly\"";
			this.labelTrueAnomalyData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTrueAnomalyData.AutoSize = true;
			this.labelTrueAnomalyData.BackColor = System.Drawing.Color.Transparent;
			this.labelTrueAnomalyData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTrueAnomalyData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTrueAnomalyData.Location = new System.Drawing.Point(198, 87);
			this.labelTrueAnomalyData.Name = "labelTrueAnomalyData";
			this.labelTrueAnomalyData.Size = new System.Drawing.Size(186, 15);
			this.labelTrueAnomalyData.TabIndex = 11;
			this.labelTrueAnomalyData.Text = "...";
			this.toolTip.SetToolTip(this.labelTrueAnomalyData, "Show the information of \"True anomaly\"");
			this.labelTrueAnomalyData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelTrueAnomalyData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomalyData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTrueAnomalyData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomalyData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPerihelionDistanceData
			// 
			this.labelPerihelionDistanceData.AccessibleDescription = "Show the information of \"Perihelion distance\"";
			this.labelPerihelionDistanceData.AccessibleName = "Show the information of \"Perihelion distance\"";
			this.labelPerihelionDistanceData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPerihelionDistanceData.AutoSize = true;
			this.labelPerihelionDistanceData.BackColor = System.Drawing.Color.Transparent;
			this.labelPerihelionDistanceData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPerihelionDistanceData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPerihelionDistanceData.Location = new System.Drawing.Point(198, 104);
			this.labelPerihelionDistanceData.Name = "labelPerihelionDistanceData";
			this.labelPerihelionDistanceData.Size = new System.Drawing.Size(186, 15);
			this.labelPerihelionDistanceData.TabIndex = 13;
			this.labelPerihelionDistanceData.Text = "...";
			this.toolTip.SetToolTip(this.labelPerihelionDistanceData, "Show the information of \"Perihelion distance\"");
			this.labelPerihelionDistanceData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelPerihelionDistanceData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistanceData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPerihelionDistanceData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistanceData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAphelionDistanceData
			// 
			this.labelAphelionDistanceData.AccessibleDescription = "Show the information of \"Aphelion distance\"";
			this.labelAphelionDistanceData.AccessibleName = "Show the information of \"Aphelion distance\"";
			this.labelAphelionDistanceData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelAphelionDistanceData.AutoSize = true;
			this.labelAphelionDistanceData.BackColor = System.Drawing.Color.Transparent;
			this.labelAphelionDistanceData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAphelionDistanceData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAphelionDistanceData.Location = new System.Drawing.Point(198, 121);
			this.labelAphelionDistanceData.Name = "labelAphelionDistanceData";
			this.labelAphelionDistanceData.Size = new System.Drawing.Size(186, 15);
			this.labelAphelionDistanceData.TabIndex = 15;
			this.labelAphelionDistanceData.Text = "...";
			this.toolTip.SetToolTip(this.labelAphelionDistanceData, "Show the information of \"Aphelion distance\"");
			this.labelAphelionDistanceData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelAphelionDistanceData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAphelionDistanceData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAphelionDistanceData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAphelionDistanceData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLongitudeDescendingNodeData
			// 
			this.labelLongitudeDescendingNodeData.AccessibleDescription = "Show the information of \"Longitude of descending node\"";
			this.labelLongitudeDescendingNodeData.AccessibleName = "Show the information of \"Longitude of descending node\"";
			this.labelLongitudeDescendingNodeData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLongitudeDescendingNodeData.AutoSize = true;
			this.labelLongitudeDescendingNodeData.BackColor = System.Drawing.Color.Transparent;
			this.labelLongitudeDescendingNodeData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeDescendingNodeData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLongitudeDescendingNodeData.Location = new System.Drawing.Point(198, 138);
			this.labelLongitudeDescendingNodeData.Name = "labelLongitudeDescendingNodeData";
			this.labelLongitudeDescendingNodeData.Size = new System.Drawing.Size(186, 15);
			this.labelLongitudeDescendingNodeData.TabIndex = 17;
			this.labelLongitudeDescendingNodeData.Text = "...";
			this.toolTip.SetToolTip(this.labelLongitudeDescendingNodeData, "Show the information of \"Longitude of descending node\"");
			this.labelLongitudeDescendingNodeData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelLongitudeDescendingNodeData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNodeData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLongitudeDescendingNodeData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNodeData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelArgumentAphelionData
			// 
			this.labelArgumentAphelionData.AccessibleDescription = "Show the information of \"Argument of aphelion\"";
			this.labelArgumentAphelionData.AccessibleName = "Show the information of \"Argument of aphelion\"";
			this.labelArgumentAphelionData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelArgumentAphelionData.AutoSize = true;
			this.labelArgumentAphelionData.BackColor = System.Drawing.Color.Transparent;
			this.labelArgumentAphelionData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentAphelionData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelArgumentAphelionData.Location = new System.Drawing.Point(198, 155);
			this.labelArgumentAphelionData.Name = "labelArgumentAphelionData";
			this.labelArgumentAphelionData.Size = new System.Drawing.Size(186, 15);
			this.labelArgumentAphelionData.TabIndex = 19;
			this.labelArgumentAphelionData.Text = "...";
			this.toolTip.SetToolTip(this.labelArgumentAphelionData, "Show the information of \"Argument of aphelion\"");
			this.labelArgumentAphelionData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelArgumentAphelionData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelionData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelArgumentAphelionData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelionData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelFocalParameterData
			// 
			this.labelFocalParameterData.AccessibleDescription = "Show the information of \"Focal parameter\"";
			this.labelFocalParameterData.AccessibleName = "Show the information of \"Focal parameter\"";
			this.labelFocalParameterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFocalParameterData.AutoSize = true;
			this.labelFocalParameterData.BackColor = System.Drawing.Color.Transparent;
			this.labelFocalParameterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFocalParameterData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFocalParameterData.Location = new System.Drawing.Point(198, 172);
			this.labelFocalParameterData.Name = "labelFocalParameterData";
			this.labelFocalParameterData.Size = new System.Drawing.Size(186, 15);
			this.labelFocalParameterData.TabIndex = 21;
			this.labelFocalParameterData.Text = "...";
			this.toolTip.SetToolTip(this.labelFocalParameterData, "Show the information of \"Focal parameter\"");
			this.labelFocalParameterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelFocalParameterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelFocalParameterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiLatusRectumData
			// 
			this.labelSemiLatusRectumData.AccessibleDescription = "Show the information of \"Semi-latus rectum\"";
			this.labelSemiLatusRectumData.AccessibleName = "Show the information of \"Semi-latus rectum\"";
			this.labelSemiLatusRectumData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiLatusRectumData.AutoSize = true;
			this.labelSemiLatusRectumData.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiLatusRectumData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiLatusRectumData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSemiLatusRectumData.Location = new System.Drawing.Point(198, 189);
			this.labelSemiLatusRectumData.Name = "labelSemiLatusRectumData";
			this.labelSemiLatusRectumData.Size = new System.Drawing.Size(186, 15);
			this.labelSemiLatusRectumData.TabIndex = 23;
			this.labelSemiLatusRectumData.Text = "...";
			this.toolTip.SetToolTip(this.labelSemiLatusRectumData, "Show the information of \"Semi-latus rectum\"");
			this.labelSemiLatusRectumData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSemiLatusRectumData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectumData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiLatusRectumData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectumData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLatusRectumData
			// 
			this.labelLatusRectumData.AccessibleDescription = "Show the information of \"Latus rectum\"";
			this.labelLatusRectumData.AccessibleName = "Show the information of \"Latus rectum\"";
			this.labelLatusRectumData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLatusRectumData.AutoSize = true;
			this.labelLatusRectumData.BackColor = System.Drawing.Color.Transparent;
			this.labelLatusRectumData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLatusRectumData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLatusRectumData.Location = new System.Drawing.Point(198, 206);
			this.labelLatusRectumData.Name = "labelLatusRectumData";
			this.labelLatusRectumData.Size = new System.Drawing.Size(186, 15);
			this.labelLatusRectumData.TabIndex = 25;
			this.labelLatusRectumData.Text = "...";
			this.toolTip.SetToolTip(this.labelLatusRectumData, "Show the information of \"Latus rectum\"");
			this.labelLatusRectumData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelLatusRectumData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectumData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLatusRectumData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectumData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPeriodData
			// 
			this.labelPeriodData.AccessibleDescription = "Show the information of \"Period\"";
			this.labelPeriodData.AccessibleName = "Show the information of \"Period\"";
			this.labelPeriodData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPeriodData.AutoSize = true;
			this.labelPeriodData.BackColor = System.Drawing.Color.Transparent;
			this.labelPeriodData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPeriodData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPeriodData.Location = new System.Drawing.Point(198, 223);
			this.labelPeriodData.Name = "labelPeriodData";
			this.labelPeriodData.Size = new System.Drawing.Size(186, 15);
			this.labelPeriodData.TabIndex = 27;
			this.labelPeriodData.Text = "...";
			this.toolTip.SetToolTip(this.labelPeriodData, "Show the information of \"Period\"");
			this.labelPeriodData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelPeriodData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPeriodData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPeriodData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPeriodData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelOrbitalAreaDesc
			// 
			this.linkLabelOrbitalAreaDesc.AccessibleDescription = "Orbital area";
			this.linkLabelOrbitalAreaDesc.AccessibleName = "Orbital area";
			this.linkLabelOrbitalAreaDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelOrbitalAreaDesc.AutoSize = true;
			this.linkLabelOrbitalAreaDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelOrbitalAreaDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelOrbitalAreaDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelOrbitalAreaDesc.Location = new System.Drawing.Point(5, 240);
			this.linkLabelOrbitalAreaDesc.Name = "linkLabelOrbitalAreaDesc";
			this.linkLabelOrbitalAreaDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelOrbitalAreaDesc.TabIndex = 28;
			this.linkLabelOrbitalAreaDesc.TabStop = true;
			this.linkLabelOrbitalAreaDesc.Text = "Orbital area (AU²)";
			this.toolTip.SetToolTip(this.linkLabelOrbitalAreaDesc, "Orbital area");
			this.linkLabelOrbitalAreaDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOrbitalArea_LinkClicked);
			this.linkLabelOrbitalAreaDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalAreaDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelOrbitalAreaDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalAreaDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelOrbitalPerimeterDesc
			// 
			this.linkLabelOrbitalPerimeterDesc.AccessibleDescription = "Orbital perimeter";
			this.linkLabelOrbitalPerimeterDesc.AccessibleName = "Orbital perimeter";
			this.linkLabelOrbitalPerimeterDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelOrbitalPerimeterDesc.AutoSize = true;
			this.linkLabelOrbitalPerimeterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelOrbitalPerimeterDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelOrbitalPerimeterDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelOrbitalPerimeterDesc.Location = new System.Drawing.Point(5, 257);
			this.linkLabelOrbitalPerimeterDesc.Name = "linkLabelOrbitalPerimeterDesc";
			this.linkLabelOrbitalPerimeterDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelOrbitalPerimeterDesc.TabIndex = 30;
			this.linkLabelOrbitalPerimeterDesc.TabStop = true;
			this.linkLabelOrbitalPerimeterDesc.Text = "Orbital perimeter (AU)";
			this.toolTip.SetToolTip(this.linkLabelOrbitalPerimeterDesc, "Orbital perimeter");
			this.linkLabelOrbitalPerimeterDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOrbitalPerimeter_LinkClicked);
			this.linkLabelOrbitalPerimeterDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalPerimeterDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelOrbitalPerimeterDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalPerimeterDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSemiMeanAxisDesc
			// 
			this.linkLabelSemiMeanAxisDesc.AccessibleDescription = "Semi-mean axis";
			this.linkLabelSemiMeanAxisDesc.AccessibleName = "Semi-mean axis";
			this.linkLabelSemiMeanAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSemiMeanAxisDesc.AutoSize = true;
			this.linkLabelSemiMeanAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSemiMeanAxisDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSemiMeanAxisDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSemiMeanAxisDesc.Location = new System.Drawing.Point(5, 274);
			this.linkLabelSemiMeanAxisDesc.Name = "linkLabelSemiMeanAxisDesc";
			this.linkLabelSemiMeanAxisDesc.Size = new System.Drawing.Size(185, 15);
			this.linkLabelSemiMeanAxisDesc.TabIndex = 32;
			this.linkLabelSemiMeanAxisDesc.TabStop = true;
			this.linkLabelSemiMeanAxisDesc.Text = "Semi-mean axis (AU)";
			this.toolTip.SetToolTip(this.linkLabelSemiMeanAxisDesc, "Semi-mean axis");
			this.linkLabelSemiMeanAxisDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSemiMeanAxis_LinkClicked);
			this.linkLabelSemiMeanAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMeanAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSemiMeanAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMeanAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMeanAxisDesc
			// 
			this.linkLabelMeanAxisDesc.AccessibleDescription = "Mean axis";
			this.linkLabelMeanAxisDesc.AccessibleName = "Mean axis";
			this.linkLabelMeanAxisDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMeanAxisDesc.AutoSize = true;
			this.linkLabelMeanAxisDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMeanAxisDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMeanAxisDesc.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMeanAxisDesc.Location = new System.Drawing.Point(5, 291);
			this.linkLabelMeanAxisDesc.Name = "linkLabelMeanAxisDesc";
			this.linkLabelMeanAxisDesc.Size = new System.Drawing.Size(185, 17);
			this.linkLabelMeanAxisDesc.TabIndex = 34;
			this.linkLabelMeanAxisDesc.TabStop = true;
			this.linkLabelMeanAxisDesc.Text = "Mean axis (AU)";
			this.toolTip.SetToolTip(this.linkLabelMeanAxisDesc, "Mean axis");
			this.linkLabelMeanAxisDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMeanAxis_LinkClicked);
			this.linkLabelMeanAxisDesc.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanAxisDesc.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMeanAxisDesc.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanAxisDesc.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalAreaData
			// 
			this.labelOrbitalAreaData.AccessibleDescription = "Show the information of \"Orbital area\"";
			this.labelOrbitalAreaData.AccessibleName = "Show the information of \"Orbital area\"";
			this.labelOrbitalAreaData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalAreaData.AutoSize = true;
			this.labelOrbitalAreaData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalAreaData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelOrbitalAreaData.Location = new System.Drawing.Point(198, 240);
			this.labelOrbitalAreaData.Name = "labelOrbitalAreaData";
			this.labelOrbitalAreaData.Size = new System.Drawing.Size(186, 15);
			this.labelOrbitalAreaData.TabIndex = 29;
			this.labelOrbitalAreaData.Text = "...";
			this.toolTip.SetToolTip(this.labelOrbitalAreaData, "Show the information of \"Orbital area\"");
			this.labelOrbitalAreaData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelOrbitalAreaData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalAreaData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalAreaData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalAreaData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalPerimeterData
			// 
			this.labelOrbitalPerimeterData.AccessibleDescription = "Show the information of \"Orbital perimeter\"";
			this.labelOrbitalPerimeterData.AccessibleName = "Show the information of \"Orbital perimeter\"";
			this.labelOrbitalPerimeterData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalPerimeterData.AutoSize = true;
			this.labelOrbitalPerimeterData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalPerimeterData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelOrbitalPerimeterData.Location = new System.Drawing.Point(198, 257);
			this.labelOrbitalPerimeterData.Name = "labelOrbitalPerimeterData";
			this.labelOrbitalPerimeterData.Size = new System.Drawing.Size(186, 15);
			this.labelOrbitalPerimeterData.TabIndex = 31;
			this.labelOrbitalPerimeterData.Text = "...";
			this.toolTip.SetToolTip(this.labelOrbitalPerimeterData, "Show the information of \"Orbital perimeter\"");
			this.labelOrbitalPerimeterData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelOrbitalPerimeterData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeterData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalPerimeterData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeterData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMeanAxisData
			// 
			this.labelSemiMeanAxisData.AccessibleDescription = "Show the information of \"Semi-mean axis\"";
			this.labelSemiMeanAxisData.AccessibleName = "Show the information of \"Semi-mean axis\"";
			this.labelSemiMeanAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMeanAxisData.AutoSize = true;
			this.labelSemiMeanAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMeanAxisData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelSemiMeanAxisData.Location = new System.Drawing.Point(198, 274);
			this.labelSemiMeanAxisData.Name = "labelSemiMeanAxisData";
			this.labelSemiMeanAxisData.Size = new System.Drawing.Size(186, 15);
			this.labelSemiMeanAxisData.TabIndex = 33;
			this.labelSemiMeanAxisData.Text = "...";
			this.toolTip.SetToolTip(this.labelSemiMeanAxisData, "Show the information of \"Semi-mean axis\"");
			this.labelSemiMeanAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSemiMeanAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMeanAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the data";
			this.tableLayoutPanel.AccessibleName = "Table pane";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Controls.Add(this.labelLinearEccentricityData, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.linkLabelLinearEccentricityDesc, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.linkLabelSemiMinorAxisDesc, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.linkLabelMajorAxisDesc, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.linkLabelMinorAxisDesc, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.linkLabelEccenctricAnomalyDesc, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.linkLabelTrueAnomalyDesc, 0, 5);
			this.tableLayoutPanel.Controls.Add(this.linkLabelPerihelionDistanceDesc, 0, 6);
			this.tableLayoutPanel.Controls.Add(this.linkLabelAphelionDistanceDesc, 0, 7);
			this.tableLayoutPanel.Controls.Add(this.linkLabelLongitudeDescendingNodeDesc, 0, 8);
			this.tableLayoutPanel.Controls.Add(this.linkLabel1ArgumentAphelionDesc, 0, 9);
			this.tableLayoutPanel.Controls.Add(this.linkLabelFocalParameterDesc, 0, 10);
			this.tableLayoutPanel.Controls.Add(this.linkLabelSemiLatusRectumDesc, 0, 11);
			this.tableLayoutPanel.Controls.Add(this.linkLabelLatusRectumDesc, 0, 12);
			this.tableLayoutPanel.Controls.Add(this.linkLabelPeriodDesc, 0, 13);
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
			this.tableLayoutPanel.Controls.Add(this.linkLabelOrbitalAreaDesc, 0, 14);
			this.tableLayoutPanel.Controls.Add(this.linkLabelOrbitalPerimeterDesc, 0, 15);
			this.tableLayoutPanel.Controls.Add(this.linkLabelSemiMeanAxisDesc, 0, 16);
			this.tableLayoutPanel.Controls.Add(this.linkLabelMeanAxisDesc, 0, 17);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalAreaData, 1, 14);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalPerimeterData, 1, 15);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMeanAxisData, 1, 16);
			this.tableLayoutPanel.Controls.Add(this.labelMeanAxisData, 1, 17);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 18;
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
			this.tableLayoutPanel.Size = new System.Drawing.Size(389, 310);
			this.tableLayoutPanel.TabIndex = 0;
			this.tableLayoutPanel.TabStop = true;
			// 
			// labelMeanAxisData
			// 
			this.labelMeanAxisData.AccessibleDescription = "Show the information of \"Mean axis\"";
			this.labelMeanAxisData.AccessibleName = "Show the information of \"Mean axis\"";
			this.labelMeanAxisData.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanAxisData.AutoSize = true;
			this.labelMeanAxisData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAxisData.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelMeanAxisData.Location = new System.Drawing.Point(198, 291);
			this.labelMeanAxisData.Name = "labelMeanAxisData";
			this.labelMeanAxisData.Size = new System.Drawing.Size(186, 17);
			this.labelMeanAxisData.TabIndex = 35;
			this.labelMeanAxisData.Text = "...";
			this.labelMeanAxisData.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMeanAxisData.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxisData.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanAxisData.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxisData.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// DerivatedOrbitElementsForm
			// 
			this.AccessibleDescription = "Calculate some derivated orbit elements";
			this.AccessibleName = "Derivated orbit elements";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 366);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DerivatedOrbitElementsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Derivated orbit elements";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DerivatedOrbitElementsForm_FormClosed);
			this.Load += new System.EventHandler(this.DerivatedOrbitElementsForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.contextMenuCopyToClipboard.ResumeLayout(false);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelLinearEccentricityData;
		private System.Windows.Forms.LinkLabel linkLabelLinearEccentricityDesc;
		private System.Windows.Forms.LinkLabel linkLabelSemiMinorAxisDesc;
		private System.Windows.Forms.LinkLabel linkLabelMajorAxisDesc;
		private System.Windows.Forms.LinkLabel linkLabelTrueAnomalyDesc;
		private System.Windows.Forms.LinkLabel linkLabelPerihelionDistanceDesc;
		private System.Windows.Forms.LinkLabel linkLabelAphelionDistanceDesc;
		private System.Windows.Forms.LinkLabel linkLabelLongitudeDescendingNodeDesc;
		private System.Windows.Forms.LinkLabel linkLabel1ArgumentAphelionDesc;
		private System.Windows.Forms.LinkLabel linkLabelFocalParameterDesc;
		private System.Windows.Forms.LinkLabel linkLabelSemiLatusRectumDesc;
		private System.Windows.Forms.LinkLabel linkLabelLatusRectumDesc;
		private System.Windows.Forms.LinkLabel linkLabelPeriodDesc;
		private System.Windows.Forms.LinkLabel linkLabelMinorAxisDesc;
		private System.Windows.Forms.LinkLabel linkLabelEccenctricAnomalyDesc;
		private System.Windows.Forms.Label labelPeriodData;
		private System.Windows.Forms.Label labelSemiMinorAxisData;
		private System.Windows.Forms.Label labelMajorAxisData;
		private System.Windows.Forms.Label labelMinorAxisData;
		private System.Windows.Forms.Label labelEccentricAnomalyData;
		private System.Windows.Forms.Label labelTrueAnomalyData;
		private System.Windows.Forms.Label labelPerihelionDistanceData;
		private System.Windows.Forms.Label labelAphelionDistanceData;
		private System.Windows.Forms.Label labelLongitudeDescendingNodeData;
		private System.Windows.Forms.Label labelArgumentAphelionData;
		private System.Windows.Forms.Label labelFocalParameterData;
		private System.Windows.Forms.Label labelSemiLatusRectumData;
		private System.Windows.Forms.Label labelLatusRectumData;
		private System.Windows.Forms.ContextMenuStrip contextMenuCopyToClipboard;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private System.Windows.Forms.LinkLabel linkLabelOrbitalAreaDesc;
		private System.Windows.Forms.LinkLabel linkLabelOrbitalPerimeterDesc;
		private System.Windows.Forms.LinkLabel linkLabelSemiMeanAxisDesc;
		private System.Windows.Forms.LinkLabel linkLabelMeanAxisDesc;
		private System.Windows.Forms.Label labelOrbitalAreaData;
		private System.Windows.Forms.Label labelOrbitalPerimeterData;
		private System.Windows.Forms.Label labelSemiMeanAxisData;
		private System.Windows.Forms.Label labelMeanAxisData;
	}
}