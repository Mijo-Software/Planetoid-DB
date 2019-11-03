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
			this.linkLabelLinearEccentricity = new System.Windows.Forms.LinkLabel();
			this.contextMenuCopyToClipboard = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelLinearEccentricity = new System.Windows.Forms.Label();
			this.linkLabelSemiMinorAxis = new System.Windows.Forms.LinkLabel();
			this.linkLabelMajorAxis = new System.Windows.Forms.LinkLabel();
			this.linkLabelMinorAxis = new System.Windows.Forms.LinkLabel();
			this.linkLabelEccenctricAnomaly = new System.Windows.Forms.LinkLabel();
			this.linkLabelTrueAnomaly = new System.Windows.Forms.LinkLabel();
			this.linkLabelPerihelionDistance = new System.Windows.Forms.LinkLabel();
			this.linkLabelAphelionDistance = new System.Windows.Forms.LinkLabel();
			this.linkLabelLongitudeDescendingNode = new System.Windows.Forms.LinkLabel();
			this.linkLabel1ArgumentAphelion = new System.Windows.Forms.LinkLabel();
			this.linkLabelFocalParameter = new System.Windows.Forms.LinkLabel();
			this.linkLabelSemiLatusRectum = new System.Windows.Forms.LinkLabel();
			this.linkLabelLatusRectum = new System.Windows.Forms.LinkLabel();
			this.linkLabelPeriod = new System.Windows.Forms.LinkLabel();
			this.labelSemiMinorAxis = new System.Windows.Forms.Label();
			this.labelMajorAxis = new System.Windows.Forms.Label();
			this.labelMinorAxis = new System.Windows.Forms.Label();
			this.labelEccentricAnomaly = new System.Windows.Forms.Label();
			this.labelTrueAnomaly = new System.Windows.Forms.Label();
			this.labelPerihelionDistance = new System.Windows.Forms.Label();
			this.labelAphelionDistance = new System.Windows.Forms.Label();
			this.labelLongitudeDescendingNode = new System.Windows.Forms.Label();
			this.labelArgumentAphelion = new System.Windows.Forms.Label();
			this.labelFocalParameter = new System.Windows.Forms.Label();
			this.labelSemiLatusRectum = new System.Windows.Forms.Label();
			this.labelLatusRectum = new System.Windows.Forms.Label();
			this.labelPeriod = new System.Windows.Forms.Label();
			this.linkLabelOrbitalArea = new System.Windows.Forms.LinkLabel();
			this.linkLabelOrbitalPerimeter = new System.Windows.Forms.LinkLabel();
			this.linkLabelSemiMeanAxis = new System.Windows.Forms.LinkLabel();
			this.linkLabelMeanAxis = new System.Windows.Forms.LinkLabel();
			this.labelOrbitalArea = new System.Windows.Forms.Label();
			this.labelOrbitalPerimeter = new System.Windows.Forms.Label();
			this.labelSemiMeanAxis = new System.Windows.Forms.Label();
			this.labelMeanAxis = new System.Windows.Forms.Label();
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
			this.statusStrip.Size = new System.Drawing.Size(374, 21);
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
			this.buttonOK.Size = new System.Drawing.Size(374, 36);
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
			// linkLabelLinearEccentricity
			// 
			this.linkLabelLinearEccentricity.AccessibleDescription = "Linear eccentricity";
			this.linkLabelLinearEccentricity.AccessibleName = "Linear eccentricity";
			this.linkLabelLinearEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelLinearEccentricity.AutoSize = true;
			this.linkLabelLinearEccentricity.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelLinearEccentricity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelLinearEccentricity.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelLinearEccentricity.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelLinearEccentricity.Location = new System.Drawing.Point(5, 2);
			this.linkLabelLinearEccentricity.Name = "linkLabelLinearEccentricity";
			this.linkLabelLinearEccentricity.Size = new System.Drawing.Size(178, 15);
			this.linkLabelLinearEccentricity.TabIndex = 0;
			this.linkLabelLinearEccentricity.TabStop = true;
			this.linkLabelLinearEccentricity.Text = "Linear eccentricity";
			this.toolTip.SetToolTip(this.linkLabelLinearEccentricity, "Linear eccentricity");
			this.linkLabelLinearEccentricity.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLinearEccentricity_LinkClicked);
			this.linkLabelLinearEccentricity.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLinearEccentricity.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelLinearEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLinearEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the data";
			this.tableLayoutPanel.AccessibleName = "Table pane";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Controls.Add(this.labelLinearEccentricity, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.linkLabelLinearEccentricity, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.linkLabelSemiMinorAxis, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.linkLabelMajorAxis, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.linkLabelMinorAxis, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.linkLabelEccenctricAnomaly, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.linkLabelTrueAnomaly, 0, 5);
			this.tableLayoutPanel.Controls.Add(this.linkLabelPerihelionDistance, 0, 6);
			this.tableLayoutPanel.Controls.Add(this.linkLabelAphelionDistance, 0, 7);
			this.tableLayoutPanel.Controls.Add(this.linkLabelLongitudeDescendingNode, 0, 8);
			this.tableLayoutPanel.Controls.Add(this.linkLabel1ArgumentAphelion, 0, 9);
			this.tableLayoutPanel.Controls.Add(this.linkLabelFocalParameter, 0, 10);
			this.tableLayoutPanel.Controls.Add(this.linkLabelSemiLatusRectum, 0, 11);
			this.tableLayoutPanel.Controls.Add(this.linkLabelLatusRectum, 0, 12);
			this.tableLayoutPanel.Controls.Add(this.linkLabelPeriod, 0, 13);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMinorAxis, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelMajorAxis, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelMinorAxis, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.labelEccentricAnomaly, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.labelTrueAnomaly, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.labelPerihelionDistance, 1, 6);
			this.tableLayoutPanel.Controls.Add(this.labelAphelionDistance, 1, 7);
			this.tableLayoutPanel.Controls.Add(this.labelLongitudeDescendingNode, 1, 8);
			this.tableLayoutPanel.Controls.Add(this.labelArgumentAphelion, 1, 9);
			this.tableLayoutPanel.Controls.Add(this.labelFocalParameter, 1, 10);
			this.tableLayoutPanel.Controls.Add(this.labelSemiLatusRectum, 1, 11);
			this.tableLayoutPanel.Controls.Add(this.labelLatusRectum, 1, 12);
			this.tableLayoutPanel.Controls.Add(this.labelPeriod, 1, 13);
			this.tableLayoutPanel.Controls.Add(this.linkLabelOrbitalArea, 0, 14);
			this.tableLayoutPanel.Controls.Add(this.linkLabelOrbitalPerimeter, 0, 15);
			this.tableLayoutPanel.Controls.Add(this.linkLabelSemiMeanAxis, 0, 16);
			this.tableLayoutPanel.Controls.Add(this.linkLabelMeanAxis, 0, 17);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalArea, 1, 14);
			this.tableLayoutPanel.Controls.Add(this.labelOrbitalPerimeter, 1, 15);
			this.tableLayoutPanel.Controls.Add(this.labelSemiMeanAxis, 1, 16);
			this.tableLayoutPanel.Controls.Add(this.labelMeanAxis, 1, 17);
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
			this.tableLayoutPanel.Size = new System.Drawing.Size(374, 310);
			this.tableLayoutPanel.TabIndex = 0;
			this.tableLayoutPanel.TabStop = true;
			// 
			// labelLinearEccentricity
			// 
			this.labelLinearEccentricity.AccessibleDescription = "Show the information of \"Linear eccentricity\"";
			this.labelLinearEccentricity.AccessibleName = "Show the information of \"Linear eccentricity\"";
			this.labelLinearEccentricity.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLinearEccentricity.AutoSize = true;
			this.labelLinearEccentricity.BackColor = System.Drawing.Color.Transparent;
			this.labelLinearEccentricity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLinearEccentricity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLinearEccentricity.Location = new System.Drawing.Point(191, 2);
			this.labelLinearEccentricity.Name = "labelLinearEccentricity";
			this.labelLinearEccentricity.Size = new System.Drawing.Size(178, 15);
			this.labelLinearEccentricity.TabIndex = 1;
			this.labelLinearEccentricity.Text = "...";
			this.toolTip.SetToolTip(this.labelLinearEccentricity, "Show the information of \"Linear eccentricity\"");
			this.labelLinearEccentricity.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelLinearEccentricity.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricity.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLinearEccentricity.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLinearEccentricity.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSemiMinorAxis
			// 
			this.linkLabelSemiMinorAxis.AccessibleDescription = "Semi-minor axis";
			this.linkLabelSemiMinorAxis.AccessibleName = "Semi-minor axis";
			this.linkLabelSemiMinorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSemiMinorAxis.AutoSize = true;
			this.linkLabelSemiMinorAxis.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelSemiMinorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSemiMinorAxis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSemiMinorAxis.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSemiMinorAxis.Location = new System.Drawing.Point(5, 19);
			this.linkLabelSemiMinorAxis.Name = "linkLabelSemiMinorAxis";
			this.linkLabelSemiMinorAxis.Size = new System.Drawing.Size(178, 15);
			this.linkLabelSemiMinorAxis.TabIndex = 2;
			this.linkLabelSemiMinorAxis.TabStop = true;
			this.linkLabelSemiMinorAxis.Text = "Semi-minor axis";
			this.toolTip.SetToolTip(this.linkLabelSemiMinorAxis, "Semi-minor axis");
			this.linkLabelSemiMinorAxis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSemiMinorAxis_LinkClicked);
			this.linkLabelSemiMinorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMinorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSemiMinorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMinorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMajorAxis
			// 
			this.linkLabelMajorAxis.AccessibleDescription = "Major axis";
			this.linkLabelMajorAxis.AccessibleName = "Major axis";
			this.linkLabelMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMajorAxis.AutoSize = true;
			this.linkLabelMajorAxis.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelMajorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMajorAxis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMajorAxis.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMajorAxis.Location = new System.Drawing.Point(5, 36);
			this.linkLabelMajorAxis.Name = "linkLabelMajorAxis";
			this.linkLabelMajorAxis.Size = new System.Drawing.Size(178, 15);
			this.linkLabelMajorAxis.TabIndex = 4;
			this.linkLabelMajorAxis.TabStop = true;
			this.linkLabelMajorAxis.Text = "Major axis";
			this.toolTip.SetToolTip(this.linkLabelMajorAxis, "Major axis");
			this.linkLabelMajorAxis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMajorAxis_LinkClicked);
			this.linkLabelMajorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMajorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMinorAxis
			// 
			this.linkLabelMinorAxis.AccessibleDescription = "Minor axis";
			this.linkLabelMinorAxis.AccessibleName = "Minor axis";
			this.linkLabelMinorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMinorAxis.AutoSize = true;
			this.linkLabelMinorAxis.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelMinorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMinorAxis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMinorAxis.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMinorAxis.Location = new System.Drawing.Point(5, 53);
			this.linkLabelMinorAxis.Name = "linkLabelMinorAxis";
			this.linkLabelMinorAxis.Size = new System.Drawing.Size(178, 15);
			this.linkLabelMinorAxis.TabIndex = 6;
			this.linkLabelMinorAxis.TabStop = true;
			this.linkLabelMinorAxis.Text = "Minor axis";
			this.toolTip.SetToolTip(this.linkLabelMinorAxis, "Minor axis");
			this.linkLabelMinorAxis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMinorAxis_LinkClicked);
			this.linkLabelMinorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMinorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMinorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMinorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelEccenctricAnomaly
			// 
			this.linkLabelEccenctricAnomaly.AccessibleDescription = "Eccentric anomaly";
			this.linkLabelEccenctricAnomaly.AccessibleName = "Eccentric anomaly";
			this.linkLabelEccenctricAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelEccenctricAnomaly.AutoSize = true;
			this.linkLabelEccenctricAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelEccenctricAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelEccenctricAnomaly.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelEccenctricAnomaly.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelEccenctricAnomaly.Location = new System.Drawing.Point(5, 70);
			this.linkLabelEccenctricAnomaly.Name = "linkLabelEccenctricAnomaly";
			this.linkLabelEccenctricAnomaly.Size = new System.Drawing.Size(178, 15);
			this.linkLabelEccenctricAnomaly.TabIndex = 8;
			this.linkLabelEccenctricAnomaly.TabStop = true;
			this.linkLabelEccenctricAnomaly.Text = "Eccentric anomaly";
			this.toolTip.SetToolTip(this.linkLabelEccenctricAnomaly, "Eccentric anomaly");
			this.linkLabelEccenctricAnomaly.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEccenctricAnomaly_LinkClicked);
			this.linkLabelEccenctricAnomaly.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEccenctricAnomaly.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelEccenctricAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelEccenctricAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelTrueAnomaly
			// 
			this.linkLabelTrueAnomaly.AccessibleDescription = "True anomaly";
			this.linkLabelTrueAnomaly.AccessibleName = "True anomaly";
			this.linkLabelTrueAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelTrueAnomaly.AutoSize = true;
			this.linkLabelTrueAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelTrueAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelTrueAnomaly.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelTrueAnomaly.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelTrueAnomaly.Location = new System.Drawing.Point(5, 87);
			this.linkLabelTrueAnomaly.Name = "linkLabelTrueAnomaly";
			this.linkLabelTrueAnomaly.Size = new System.Drawing.Size(178, 15);
			this.linkLabelTrueAnomaly.TabIndex = 10;
			this.linkLabelTrueAnomaly.TabStop = true;
			this.linkLabelTrueAnomaly.Text = "True anomaly";
			this.toolTip.SetToolTip(this.linkLabelTrueAnomaly, "True anomaly");
			this.linkLabelTrueAnomaly.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelTrueAnomaly_LinkClicked);
			this.linkLabelTrueAnomaly.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelTrueAnomaly.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelTrueAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelTrueAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelPerihelionDistance
			// 
			this.linkLabelPerihelionDistance.AccessibleDescription = "Perihelion distance";
			this.linkLabelPerihelionDistance.AccessibleName = "Perihelion distance";
			this.linkLabelPerihelionDistance.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelPerihelionDistance.AutoSize = true;
			this.linkLabelPerihelionDistance.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelPerihelionDistance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelPerihelionDistance.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelPerihelionDistance.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelPerihelionDistance.Location = new System.Drawing.Point(5, 104);
			this.linkLabelPerihelionDistance.Name = "linkLabelPerihelionDistance";
			this.linkLabelPerihelionDistance.Size = new System.Drawing.Size(178, 15);
			this.linkLabelPerihelionDistance.TabIndex = 12;
			this.linkLabelPerihelionDistance.TabStop = true;
			this.linkLabelPerihelionDistance.Text = "Perihelion distance";
			this.toolTip.SetToolTip(this.linkLabelPerihelionDistance, "Perihelion distance");
			this.linkLabelPerihelionDistance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPerihelionDistance_LinkClicked);
			this.linkLabelPerihelionDistance.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPerihelionDistance.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelPerihelionDistance.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPerihelionDistance.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelAphelionDistance
			// 
			this.linkLabelAphelionDistance.AccessibleDescription = "Aphelion distance";
			this.linkLabelAphelionDistance.AccessibleName = "Aphelion distance";
			this.linkLabelAphelionDistance.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelAphelionDistance.AutoSize = true;
			this.linkLabelAphelionDistance.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelAphelionDistance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelAphelionDistance.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelAphelionDistance.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelAphelionDistance.Location = new System.Drawing.Point(5, 121);
			this.linkLabelAphelionDistance.Name = "linkLabelAphelionDistance";
			this.linkLabelAphelionDistance.Size = new System.Drawing.Size(178, 15);
			this.linkLabelAphelionDistance.TabIndex = 14;
			this.linkLabelAphelionDistance.TabStop = true;
			this.linkLabelAphelionDistance.Text = "Aphelion distance";
			this.toolTip.SetToolTip(this.linkLabelAphelionDistance, "Aphelion distance");
			this.linkLabelAphelionDistance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAphelionDistance_LinkClicked);
			this.linkLabelAphelionDistance.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelAphelionDistance.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelAphelionDistance.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelAphelionDistance.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelLongitudeDescendingNode
			// 
			this.linkLabelLongitudeDescendingNode.AccessibleDescription = "Longitude of descending node";
			this.linkLabelLongitudeDescendingNode.AccessibleName = "Longitude of descending node";
			this.linkLabelLongitudeDescendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelLongitudeDescendingNode.AutoSize = true;
			this.linkLabelLongitudeDescendingNode.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelLongitudeDescendingNode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelLongitudeDescendingNode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelLongitudeDescendingNode.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelLongitudeDescendingNode.Location = new System.Drawing.Point(5, 138);
			this.linkLabelLongitudeDescendingNode.Name = "linkLabelLongitudeDescendingNode";
			this.linkLabelLongitudeDescendingNode.Size = new System.Drawing.Size(178, 15);
			this.linkLabelLongitudeDescendingNode.TabIndex = 16;
			this.linkLabelLongitudeDescendingNode.TabStop = true;
			this.linkLabelLongitudeDescendingNode.Text = "Longitude of descending node";
			this.toolTip.SetToolTip(this.linkLabelLongitudeDescendingNode, "Longitude of descending node");
			this.linkLabelLongitudeDescendingNode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLongitudeDescendingNode_LinkClicked);
			this.linkLabelLongitudeDescendingNode.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLongitudeDescendingNode.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelLongitudeDescendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLongitudeDescendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabel1ArgumentAphelion
			// 
			this.linkLabel1ArgumentAphelion.AccessibleDescription = "Argument of aphelion";
			this.linkLabel1ArgumentAphelion.AccessibleName = "Argument of aphelion";
			this.linkLabel1ArgumentAphelion.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabel1ArgumentAphelion.AutoSize = true;
			this.linkLabel1ArgumentAphelion.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1ArgumentAphelion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabel1ArgumentAphelion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel1ArgumentAphelion.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabel1ArgumentAphelion.Location = new System.Drawing.Point(5, 155);
			this.linkLabel1ArgumentAphelion.Name = "linkLabel1ArgumentAphelion";
			this.linkLabel1ArgumentAphelion.Size = new System.Drawing.Size(178, 15);
			this.linkLabel1ArgumentAphelion.TabIndex = 18;
			this.linkLabel1ArgumentAphelion.TabStop = true;
			this.linkLabel1ArgumentAphelion.Text = "Argument of aphelion";
			this.toolTip.SetToolTip(this.linkLabel1ArgumentAphelion, "Argument of aphelion");
			this.linkLabel1ArgumentAphelion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1ArgumentAphelion_LinkClicked);
			this.linkLabel1ArgumentAphelion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabel1ArgumentAphelion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabel1ArgumentAphelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabel1ArgumentAphelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelFocalParameter
			// 
			this.linkLabelFocalParameter.AccessibleDescription = "Focal parameter";
			this.linkLabelFocalParameter.AccessibleName = "Focal parameter";
			this.linkLabelFocalParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelFocalParameter.AutoSize = true;
			this.linkLabelFocalParameter.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelFocalParameter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelFocalParameter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelFocalParameter.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelFocalParameter.Location = new System.Drawing.Point(5, 172);
			this.linkLabelFocalParameter.Name = "linkLabelFocalParameter";
			this.linkLabelFocalParameter.Size = new System.Drawing.Size(178, 15);
			this.linkLabelFocalParameter.TabIndex = 20;
			this.linkLabelFocalParameter.TabStop = true;
			this.linkLabelFocalParameter.Text = "Focal parameter";
			this.toolTip.SetToolTip(this.linkLabelFocalParameter, "Focal parameter");
			this.linkLabelFocalParameter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelFocalParameter_LinkClicked);
			this.linkLabelFocalParameter.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelFocalParameter.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelFocalParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelFocalParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSemiLatusRectum
			// 
			this.linkLabelSemiLatusRectum.AccessibleDescription = "Semi-latus rectum";
			this.linkLabelSemiLatusRectum.AccessibleName = "Semi-latus rectum";
			this.linkLabelSemiLatusRectum.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSemiLatusRectum.AutoSize = true;
			this.linkLabelSemiLatusRectum.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelSemiLatusRectum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSemiLatusRectum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSemiLatusRectum.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSemiLatusRectum.Location = new System.Drawing.Point(5, 189);
			this.linkLabelSemiLatusRectum.Name = "linkLabelSemiLatusRectum";
			this.linkLabelSemiLatusRectum.Size = new System.Drawing.Size(178, 15);
			this.linkLabelSemiLatusRectum.TabIndex = 22;
			this.linkLabelSemiLatusRectum.TabStop = true;
			this.linkLabelSemiLatusRectum.Text = "Semi-latus rectum";
			this.toolTip.SetToolTip(this.linkLabelSemiLatusRectum, "Semi-latus rectum");
			this.linkLabelSemiLatusRectum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSemiLatusRectum_LinkClicked);
			this.linkLabelSemiLatusRectum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiLatusRectum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSemiLatusRectum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiLatusRectum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelLatusRectum
			// 
			this.linkLabelLatusRectum.AccessibleDescription = "Latus rectum";
			this.linkLabelLatusRectum.AccessibleName = "Latus rectum";
			this.linkLabelLatusRectum.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelLatusRectum.AutoSize = true;
			this.linkLabelLatusRectum.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelLatusRectum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelLatusRectum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelLatusRectum.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelLatusRectum.Location = new System.Drawing.Point(5, 206);
			this.linkLabelLatusRectum.Name = "linkLabelLatusRectum";
			this.linkLabelLatusRectum.Size = new System.Drawing.Size(178, 15);
			this.linkLabelLatusRectum.TabIndex = 24;
			this.linkLabelLatusRectum.TabStop = true;
			this.linkLabelLatusRectum.Text = "Latus rectum";
			this.toolTip.SetToolTip(this.linkLabelLatusRectum, "Latus rectum");
			this.linkLabelLatusRectum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLatusRectum_LinkClicked);
			this.linkLabelLatusRectum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLatusRectum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelLatusRectum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelLatusRectum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelPeriod
			// 
			this.linkLabelPeriod.AccessibleDescription = "Period";
			this.linkLabelPeriod.AccessibleName = "Period";
			this.linkLabelPeriod.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelPeriod.AutoSize = true;
			this.linkLabelPeriod.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelPeriod.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelPeriod.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelPeriod.Location = new System.Drawing.Point(5, 223);
			this.linkLabelPeriod.Name = "linkLabelPeriod";
			this.linkLabelPeriod.Size = new System.Drawing.Size(178, 15);
			this.linkLabelPeriod.TabIndex = 26;
			this.linkLabelPeriod.TabStop = true;
			this.linkLabelPeriod.Text = "Period";
			this.toolTip.SetToolTip(this.linkLabelPeriod, "Period");
			this.linkLabelPeriod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPeriod_LinkClicked);
			this.linkLabelPeriod.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPeriod.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelPeriod.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelPeriod.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMinorAxis
			// 
			this.labelSemiMinorAxis.AccessibleDescription = "Show the information of \"Semi-minor axis\"";
			this.labelSemiMinorAxis.AccessibleName = "Show the information of \"Semi-minor axis\"";
			this.labelSemiMinorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMinorAxis.AutoSize = true;
			this.labelSemiMinorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiMinorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMinorAxis.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSemiMinorAxis.Location = new System.Drawing.Point(191, 19);
			this.labelSemiMinorAxis.Name = "labelSemiMinorAxis";
			this.labelSemiMinorAxis.Size = new System.Drawing.Size(178, 15);
			this.labelSemiMinorAxis.TabIndex = 3;
			this.labelSemiMinorAxis.Text = "...";
			this.toolTip.SetToolTip(this.labelSemiMinorAxis, "Show the information of \"Semi-minor axis\"");
			this.labelSemiMinorAxis.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSemiMinorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMinorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMinorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMajorAxis
			// 
			this.labelMajorAxis.AccessibleDescription = "Show the information of \"Major axis\"";
			this.labelMajorAxis.AccessibleName = "Show the information of \"Major axis\"";
			this.labelMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMajorAxis.AutoSize = true;
			this.labelMajorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelMajorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMajorAxis.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMajorAxis.Location = new System.Drawing.Point(191, 36);
			this.labelMajorAxis.Name = "labelMajorAxis";
			this.labelMajorAxis.Size = new System.Drawing.Size(178, 15);
			this.labelMajorAxis.TabIndex = 5;
			this.labelMajorAxis.Text = "...";
			this.toolTip.SetToolTip(this.labelMajorAxis, "Show the information of \"Major axis\"");
			this.labelMajorAxis.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMajorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMajorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMajorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMinorAxis
			// 
			this.labelMinorAxis.AccessibleDescription = "Show the information of \"Minor axis\"";
			this.labelMinorAxis.AccessibleName = "Show the information of \"Minor axis\"";
			this.labelMinorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMinorAxis.AutoSize = true;
			this.labelMinorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelMinorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinorAxis.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMinorAxis.Location = new System.Drawing.Point(191, 53);
			this.labelMinorAxis.Name = "labelMinorAxis";
			this.labelMinorAxis.Size = new System.Drawing.Size(178, 15);
			this.labelMinorAxis.TabIndex = 7;
			this.labelMinorAxis.Text = "...";
			this.toolTip.SetToolTip(this.labelMinorAxis, "Show the information of \"Minor axis\"");
			this.labelMinorAxis.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMinorAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMinorAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMinorAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEccentricAnomaly
			// 
			this.labelEccentricAnomaly.AccessibleDescription = "Show the information of \"Eccentric anomaly\"";
			this.labelEccentricAnomaly.AccessibleName = "Show the information of \"Eccentric anomaly\"";
			this.labelEccentricAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEccentricAnomaly.AutoSize = true;
			this.labelEccentricAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.labelEccentricAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEccentricAnomaly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEccentricAnomaly.Location = new System.Drawing.Point(191, 70);
			this.labelEccentricAnomaly.Name = "labelEccentricAnomaly";
			this.labelEccentricAnomaly.Size = new System.Drawing.Size(178, 15);
			this.labelEccentricAnomaly.TabIndex = 9;
			this.labelEccentricAnomaly.Text = "...";
			this.toolTip.SetToolTip(this.labelEccentricAnomaly, "Show the information of \"Eccentric anomaly\"");
			this.labelEccentricAnomaly.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelEccentricAnomaly.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccentricAnomaly.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEccentricAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEccentricAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTrueAnomaly
			// 
			this.labelTrueAnomaly.AccessibleDescription = "Show the information of \"True anomaly\"";
			this.labelTrueAnomaly.AccessibleName = "Show the information of \"True anomaly\"";
			this.labelTrueAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTrueAnomaly.AutoSize = true;
			this.labelTrueAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.labelTrueAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTrueAnomaly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTrueAnomaly.Location = new System.Drawing.Point(191, 87);
			this.labelTrueAnomaly.Name = "labelTrueAnomaly";
			this.labelTrueAnomaly.Size = new System.Drawing.Size(178, 15);
			this.labelTrueAnomaly.TabIndex = 11;
			this.labelTrueAnomaly.Text = "...";
			this.toolTip.SetToolTip(this.labelTrueAnomaly, "Show the information of \"True anomaly\"");
			this.labelTrueAnomaly.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelTrueAnomaly.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomaly.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTrueAnomaly.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTrueAnomaly.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPerihelionDistance
			// 
			this.labelPerihelionDistance.AccessibleDescription = "Show the information of \"Perihelion distance\"";
			this.labelPerihelionDistance.AccessibleName = "Show the information of \"Perihelion distance\"";
			this.labelPerihelionDistance.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPerihelionDistance.AutoSize = true;
			this.labelPerihelionDistance.BackColor = System.Drawing.Color.Transparent;
			this.labelPerihelionDistance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPerihelionDistance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPerihelionDistance.Location = new System.Drawing.Point(191, 104);
			this.labelPerihelionDistance.Name = "labelPerihelionDistance";
			this.labelPerihelionDistance.Size = new System.Drawing.Size(178, 15);
			this.labelPerihelionDistance.TabIndex = 13;
			this.labelPerihelionDistance.Text = "...";
			this.toolTip.SetToolTip(this.labelPerihelionDistance, "Show the information of \"Perihelion distance\"");
			this.labelPerihelionDistance.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelPerihelionDistance.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistance.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPerihelionDistance.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPerihelionDistance.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelAphelionDistance
			// 
			this.labelAphelionDistance.AccessibleDescription = "Show the information of \"Aphelion distance\"";
			this.labelAphelionDistance.AccessibleName = "Show the information of \"Aphelion distance\"";
			this.labelAphelionDistance.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelAphelionDistance.AutoSize = true;
			this.labelAphelionDistance.BackColor = System.Drawing.Color.Transparent;
			this.labelAphelionDistance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAphelionDistance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAphelionDistance.Location = new System.Drawing.Point(191, 121);
			this.labelAphelionDistance.Name = "labelAphelionDistance";
			this.labelAphelionDistance.Size = new System.Drawing.Size(178, 15);
			this.labelAphelionDistance.TabIndex = 15;
			this.labelAphelionDistance.Text = "...";
			this.toolTip.SetToolTip(this.labelAphelionDistance, "Show the information of \"Aphelion distance\"");
			this.labelAphelionDistance.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelAphelionDistance.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAphelionDistance.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelAphelionDistance.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelAphelionDistance.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLongitudeDescendingNode
			// 
			this.labelLongitudeDescendingNode.AccessibleDescription = "Show the information of \"Longitude of descending node\"";
			this.labelLongitudeDescendingNode.AccessibleName = "Show the information of \"Longitude of descending node\"";
			this.labelLongitudeDescendingNode.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLongitudeDescendingNode.AutoSize = true;
			this.labelLongitudeDescendingNode.BackColor = System.Drawing.Color.Transparent;
			this.labelLongitudeDescendingNode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongitudeDescendingNode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLongitudeDescendingNode.Location = new System.Drawing.Point(191, 138);
			this.labelLongitudeDescendingNode.Name = "labelLongitudeDescendingNode";
			this.labelLongitudeDescendingNode.Size = new System.Drawing.Size(178, 15);
			this.labelLongitudeDescendingNode.TabIndex = 17;
			this.labelLongitudeDescendingNode.Text = "...";
			this.toolTip.SetToolTip(this.labelLongitudeDescendingNode, "Show the information of \"Longitude of descending node\"");
			this.labelLongitudeDescendingNode.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelLongitudeDescendingNode.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNode.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLongitudeDescendingNode.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLongitudeDescendingNode.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelArgumentAphelion
			// 
			this.labelArgumentAphelion.AccessibleDescription = "Show the information of \"Argument of aphelion\"";
			this.labelArgumentAphelion.AccessibleName = "Show the information of \"Argument of aphelion\"";
			this.labelArgumentAphelion.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelArgumentAphelion.AutoSize = true;
			this.labelArgumentAphelion.BackColor = System.Drawing.Color.Transparent;
			this.labelArgumentAphelion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgumentAphelion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelArgumentAphelion.Location = new System.Drawing.Point(191, 155);
			this.labelArgumentAphelion.Name = "labelArgumentAphelion";
			this.labelArgumentAphelion.Size = new System.Drawing.Size(178, 15);
			this.labelArgumentAphelion.TabIndex = 19;
			this.labelArgumentAphelion.Text = "...";
			this.toolTip.SetToolTip(this.labelArgumentAphelion, "Show the information of \"Argument of aphelion\"");
			this.labelArgumentAphelion.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelArgumentAphelion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelArgumentAphelion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelArgumentAphelion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelFocalParameter
			// 
			this.labelFocalParameter.AccessibleDescription = "Show the information of \"Focal parameter\"";
			this.labelFocalParameter.AccessibleName = "Show the information of \"Focal parameter\"";
			this.labelFocalParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFocalParameter.AutoSize = true;
			this.labelFocalParameter.BackColor = System.Drawing.Color.Transparent;
			this.labelFocalParameter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFocalParameter.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFocalParameter.Location = new System.Drawing.Point(191, 172);
			this.labelFocalParameter.Name = "labelFocalParameter";
			this.labelFocalParameter.Size = new System.Drawing.Size(178, 15);
			this.labelFocalParameter.TabIndex = 21;
			this.labelFocalParameter.Text = "...";
			this.toolTip.SetToolTip(this.labelFocalParameter, "Show the information of \"Focal parameter\"");
			this.labelFocalParameter.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelFocalParameter.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameter.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelFocalParameter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelFocalParameter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiLatusRectum
			// 
			this.labelSemiLatusRectum.AccessibleDescription = "Show the information of \"Semi-latus rectum\"";
			this.labelSemiLatusRectum.AccessibleName = "Show the information of \"Semi-latus rectum\"";
			this.labelSemiLatusRectum.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiLatusRectum.AutoSize = true;
			this.labelSemiLatusRectum.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiLatusRectum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiLatusRectum.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSemiLatusRectum.Location = new System.Drawing.Point(191, 189);
			this.labelSemiLatusRectum.Name = "labelSemiLatusRectum";
			this.labelSemiLatusRectum.Size = new System.Drawing.Size(178, 15);
			this.labelSemiLatusRectum.TabIndex = 23;
			this.labelSemiLatusRectum.Text = "...";
			this.toolTip.SetToolTip(this.labelSemiLatusRectum, "Show the information of \"Semi-latus rectum\"");
			this.labelSemiLatusRectum.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSemiLatusRectum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiLatusRectum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiLatusRectum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelLatusRectum
			// 
			this.labelLatusRectum.AccessibleDescription = "Show the information of \"Latus rectum\"";
			this.labelLatusRectum.AccessibleName = "Show the information of \"Latus rectum\"";
			this.labelLatusRectum.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLatusRectum.AutoSize = true;
			this.labelLatusRectum.BackColor = System.Drawing.Color.Transparent;
			this.labelLatusRectum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLatusRectum.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLatusRectum.Location = new System.Drawing.Point(191, 206);
			this.labelLatusRectum.Name = "labelLatusRectum";
			this.labelLatusRectum.Size = new System.Drawing.Size(178, 15);
			this.labelLatusRectum.TabIndex = 25;
			this.labelLatusRectum.Text = "...";
			this.toolTip.SetToolTip(this.labelLatusRectum, "Show the information of \"Latus rectum\"");
			this.labelLatusRectum.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelLatusRectum.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectum.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelLatusRectum.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelLatusRectum.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPeriod
			// 
			this.labelPeriod.AccessibleDescription = "Show the information of \"Period\"";
			this.labelPeriod.AccessibleName = "Show the information of \"Period\"";
			this.labelPeriod.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPeriod.AutoSize = true;
			this.labelPeriod.BackColor = System.Drawing.Color.Transparent;
			this.labelPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPeriod.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPeriod.Location = new System.Drawing.Point(191, 223);
			this.labelPeriod.Name = "labelPeriod";
			this.labelPeriod.Size = new System.Drawing.Size(178, 15);
			this.labelPeriod.TabIndex = 27;
			this.labelPeriod.Text = "...";
			this.toolTip.SetToolTip(this.labelPeriod, "Show the information of \"Period\"");
			this.labelPeriod.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelPeriod.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPeriod.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPeriod.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPeriod.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelOrbitalArea
			// 
			this.linkLabelOrbitalArea.AccessibleDescription = "Orbital area";
			this.linkLabelOrbitalArea.AccessibleName = "Orbital area";
			this.linkLabelOrbitalArea.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelOrbitalArea.AutoSize = true;
			this.linkLabelOrbitalArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelOrbitalArea.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelOrbitalArea.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelOrbitalArea.Location = new System.Drawing.Point(5, 240);
			this.linkLabelOrbitalArea.Name = "linkLabelOrbitalArea";
			this.linkLabelOrbitalArea.Size = new System.Drawing.Size(178, 15);
			this.linkLabelOrbitalArea.TabIndex = 28;
			this.linkLabelOrbitalArea.TabStop = true;
			this.linkLabelOrbitalArea.Text = "Orbital area";
			this.toolTip.SetToolTip(this.linkLabelOrbitalArea, "Orbital area");
			this.linkLabelOrbitalArea.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOrbitalArea_LinkClicked);
			this.linkLabelOrbitalArea.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalArea.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelOrbitalArea.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalArea.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelOrbitalPerimeter
			// 
			this.linkLabelOrbitalPerimeter.AccessibleDescription = "Orbital perimeter";
			this.linkLabelOrbitalPerimeter.AccessibleName = "Orbital perimeter";
			this.linkLabelOrbitalPerimeter.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelOrbitalPerimeter.AutoSize = true;
			this.linkLabelOrbitalPerimeter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelOrbitalPerimeter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelOrbitalPerimeter.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelOrbitalPerimeter.Location = new System.Drawing.Point(5, 257);
			this.linkLabelOrbitalPerimeter.Name = "linkLabelOrbitalPerimeter";
			this.linkLabelOrbitalPerimeter.Size = new System.Drawing.Size(178, 15);
			this.linkLabelOrbitalPerimeter.TabIndex = 30;
			this.linkLabelOrbitalPerimeter.TabStop = true;
			this.linkLabelOrbitalPerimeter.Text = "Orbital perimeter";
			this.toolTip.SetToolTip(this.linkLabelOrbitalPerimeter, "Orbital perimeter");
			this.linkLabelOrbitalPerimeter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOrbitalPerimeter_LinkClicked);
			this.linkLabelOrbitalPerimeter.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalPerimeter.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelOrbitalPerimeter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelOrbitalPerimeter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelSemiMeanAxis
			// 
			this.linkLabelSemiMeanAxis.AccessibleDescription = "Semi-mean axis";
			this.linkLabelSemiMeanAxis.AccessibleName = "Semi-mean axis";
			this.linkLabelSemiMeanAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelSemiMeanAxis.AutoSize = true;
			this.linkLabelSemiMeanAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelSemiMeanAxis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelSemiMeanAxis.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelSemiMeanAxis.Location = new System.Drawing.Point(5, 274);
			this.linkLabelSemiMeanAxis.Name = "linkLabelSemiMeanAxis";
			this.linkLabelSemiMeanAxis.Size = new System.Drawing.Size(178, 15);
			this.linkLabelSemiMeanAxis.TabIndex = 32;
			this.linkLabelSemiMeanAxis.TabStop = true;
			this.linkLabelSemiMeanAxis.Text = "Semi-mean axis";
			this.toolTip.SetToolTip(this.linkLabelSemiMeanAxis, "Semi-mean axis");
			this.linkLabelSemiMeanAxis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSemiMeanAxis_LinkClicked);
			this.linkLabelSemiMeanAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMeanAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelSemiMeanAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelSemiMeanAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// linkLabelMeanAxis
			// 
			this.linkLabelMeanAxis.AccessibleDescription = "Mean axis";
			this.linkLabelMeanAxis.AccessibleName = "Mean axis";
			this.linkLabelMeanAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.linkLabelMeanAxis.AutoSize = true;
			this.linkLabelMeanAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelMeanAxis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabelMeanAxis.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkLabelMeanAxis.Location = new System.Drawing.Point(5, 291);
			this.linkLabelMeanAxis.Name = "linkLabelMeanAxis";
			this.linkLabelMeanAxis.Size = new System.Drawing.Size(178, 17);
			this.linkLabelMeanAxis.TabIndex = 34;
			this.linkLabelMeanAxis.TabStop = true;
			this.linkLabelMeanAxis.Text = "Mean axis";
			this.toolTip.SetToolTip(this.linkLabelMeanAxis, "Mean axis");
			this.linkLabelMeanAxis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMeanAxis_LinkClicked);
			this.linkLabelMeanAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.linkLabelMeanAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.linkLabelMeanAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalArea
			// 
			this.labelOrbitalArea.AccessibleDescription = "Show the information of \"Orbital area\"";
			this.labelOrbitalArea.AccessibleName = "Show the information of \"Orbital area\"";
			this.labelOrbitalArea.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalArea.AutoSize = true;
			this.labelOrbitalArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalArea.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelOrbitalArea.Location = new System.Drawing.Point(191, 240);
			this.labelOrbitalArea.Name = "labelOrbitalArea";
			this.labelOrbitalArea.Size = new System.Drawing.Size(178, 15);
			this.labelOrbitalArea.TabIndex = 29;
			this.labelOrbitalArea.Text = "...";
			this.toolTip.SetToolTip(this.labelOrbitalArea, "Show the information of \"Orbital area\"");
			this.labelOrbitalArea.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelOrbitalArea.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalArea.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalArea.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalArea.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelOrbitalPerimeter
			// 
			this.labelOrbitalPerimeter.AccessibleDescription = "Show the information of \"Orbital perimeter\"";
			this.labelOrbitalPerimeter.AccessibleName = "Show the information of \"Orbital perimeter\"";
			this.labelOrbitalPerimeter.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelOrbitalPerimeter.AutoSize = true;
			this.labelOrbitalPerimeter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbitalPerimeter.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelOrbitalPerimeter.Location = new System.Drawing.Point(191, 257);
			this.labelOrbitalPerimeter.Name = "labelOrbitalPerimeter";
			this.labelOrbitalPerimeter.Size = new System.Drawing.Size(178, 15);
			this.labelOrbitalPerimeter.TabIndex = 31;
			this.labelOrbitalPerimeter.Text = "...";
			this.toolTip.SetToolTip(this.labelOrbitalPerimeter, "Show the information of \"Orbital perimeter\"");
			this.labelOrbitalPerimeter.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelOrbitalPerimeter.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeter.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelOrbitalPerimeter.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelOrbitalPerimeter.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSemiMeanAxis
			// 
			this.labelSemiMeanAxis.AccessibleDescription = "Show the information of \"Semi-mean axis\"";
			this.labelSemiMeanAxis.AccessibleName = "Show the information of \"Semi-mean axis\"";
			this.labelSemiMeanAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSemiMeanAxis.AutoSize = true;
			this.labelSemiMeanAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMeanAxis.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelSemiMeanAxis.Location = new System.Drawing.Point(191, 274);
			this.labelSemiMeanAxis.Name = "labelSemiMeanAxis";
			this.labelSemiMeanAxis.Size = new System.Drawing.Size(178, 15);
			this.labelSemiMeanAxis.TabIndex = 33;
			this.labelSemiMeanAxis.Text = "...";
			this.toolTip.SetToolTip(this.labelSemiMeanAxis, "Show the information of \"Semi-mean axis\"");
			this.labelSemiMeanAxis.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelSemiMeanAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSemiMeanAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSemiMeanAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMeanAxis
			// 
			this.labelMeanAxis.AccessibleDescription = "Show the information of \"Mean axis\"";
			this.labelMeanAxis.AccessibleName = "Show the information of \"Mean axis\"";
			this.labelMeanAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelMeanAxis.AutoSize = true;
			this.labelMeanAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAxis.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.labelMeanAxis.Location = new System.Drawing.Point(191, 291);
			this.labelMeanAxis.Name = "labelMeanAxis";
			this.labelMeanAxis.Size = new System.Drawing.Size(178, 17);
			this.labelMeanAxis.TabIndex = 35;
			this.labelMeanAxis.Text = "...";
			this.labelMeanAxis.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelMeanAxis.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxis.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMeanAxis.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMeanAxis.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// DerivatedOrbitElementsForm
			// 
			this.AccessibleDescription = "Calculate some derivated orbit elements";
			this.AccessibleName = "Derivated orbit elements";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 366);
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
		private System.Windows.Forms.Label labelLinearEccentricity;
		private System.Windows.Forms.LinkLabel linkLabelLinearEccentricity;
		private System.Windows.Forms.LinkLabel linkLabelSemiMinorAxis;
		private System.Windows.Forms.LinkLabel linkLabelMajorAxis;
		private System.Windows.Forms.LinkLabel linkLabelTrueAnomaly;
		private System.Windows.Forms.LinkLabel linkLabelPerihelionDistance;
		private System.Windows.Forms.LinkLabel linkLabelAphelionDistance;
		private System.Windows.Forms.LinkLabel linkLabelLongitudeDescendingNode;
		private System.Windows.Forms.LinkLabel linkLabel1ArgumentAphelion;
		private System.Windows.Forms.LinkLabel linkLabelFocalParameter;
		private System.Windows.Forms.LinkLabel linkLabelSemiLatusRectum;
		private System.Windows.Forms.LinkLabel linkLabelLatusRectum;
		private System.Windows.Forms.LinkLabel linkLabelPeriod;
		private System.Windows.Forms.LinkLabel linkLabelMinorAxis;
		private System.Windows.Forms.LinkLabel linkLabelEccenctricAnomaly;
		private System.Windows.Forms.Label labelPeriod;
		private System.Windows.Forms.Label labelSemiMinorAxis;
		private System.Windows.Forms.Label labelMajorAxis;
		private System.Windows.Forms.Label labelMinorAxis;
		private System.Windows.Forms.Label labelEccentricAnomaly;
		private System.Windows.Forms.Label labelTrueAnomaly;
		private System.Windows.Forms.Label labelPerihelionDistance;
		private System.Windows.Forms.Label labelAphelionDistance;
		private System.Windows.Forms.Label labelLongitudeDescendingNode;
		private System.Windows.Forms.Label labelArgumentAphelion;
		private System.Windows.Forms.Label labelFocalParameter;
		private System.Windows.Forms.Label labelSemiLatusRectum;
		private System.Windows.Forms.Label labelLatusRectum;
		private System.Windows.Forms.ContextMenuStrip contextMenuCopyToClipboard;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private System.Windows.Forms.LinkLabel linkLabelOrbitalArea;
		private System.Windows.Forms.LinkLabel linkLabelOrbitalPerimeter;
		private System.Windows.Forms.LinkLabel linkLabelSemiMeanAxis;
		private System.Windows.Forms.LinkLabel linkLabelMeanAxis;
		private System.Windows.Forms.Label labelOrbitalArea;
		private System.Windows.Forms.Label labelOrbitalPerimeter;
		private System.Windows.Forms.Label labelSemiMeanAxis;
		private System.Windows.Forms.Label labelMeanAxis;
	}
}