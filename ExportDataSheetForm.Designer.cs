namespace Planetoid_DB
{
	partial class ExportDataSheetForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportDataSheetForm));
			buttonExportAsJson = new Krypton.Toolkit.KryptonButton();
			buttonExportAsTxt = new Krypton.Toolkit.KryptonButton();
			buttonExportAsXml = new Krypton.Toolkit.KryptonButton();
			buttonExportAsHtml = new Krypton.Toolkit.KryptonButton();
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolTip = new ToolTip(components);
			buttonUnmarkAll = new Krypton.Toolkit.KryptonButton();
			buttonMarkAll = new Krypton.Toolkit.KryptonButton();
			toolStripContainer = new ToolStripContainer();
			panel = new Krypton.Toolkit.KryptonPanel();
			checkedListBoxOrbitalElements = new Krypton.Toolkit.KryptonCheckedListBox();
			saveFileDialogTxt = new SaveFileDialog();
			saveFileDialogHtml = new SaveFileDialog();
			saveFileDialogXml = new SaveFileDialog();
			saveFileDialogJson = new SaveFileDialog();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// buttonExportAsJson
			// 
			buttonExportAsJson.AccessibleDescription = "Exports the data sheet as JSON file";
			buttonExportAsJson.AccessibleName = "Export as JSON";
			buttonExportAsJson.AccessibleRole = AccessibleRole.PushButton;
			buttonExportAsJson.Location = new Point(348, 245);
			buttonExportAsJson.Margin = new Padding(4, 3, 4, 3);
			buttonExportAsJson.Name = "buttonExportAsJson";
			buttonExportAsJson.Size = new Size(111, 46);
			buttonExportAsJson.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			buttonExportAsJson.TabIndex = 6;
			toolTip.SetToolTip(buttonExportAsJson, "Export as JSON");
			buttonExportAsJson.Values.Image = Properties.Resources.silk_page_white_code;
			buttonExportAsJson.Values.Text = "Export as JSON";
			buttonExportAsJson.Click += ButtonExportAsJson_Click;
			buttonExportAsJson.Enter += SetStatusbar_Enter;
			buttonExportAsJson.Leave += ClearStatusbar_Leave;
			buttonExportAsJson.MouseEnter += SetStatusbar_Enter;
			buttonExportAsJson.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonExportAsTxt
			// 
			buttonExportAsTxt.AccessibleDescription = "Exports the data sheet as text file";
			buttonExportAsTxt.AccessibleName = "Export as TXT";
			buttonExportAsTxt.AccessibleRole = AccessibleRole.PushButton;
			buttonExportAsTxt.Location = new Point(348, 85);
			buttonExportAsTxt.Margin = new Padding(4, 3, 4, 3);
			buttonExportAsTxt.Name = "buttonExportAsTxt";
			buttonExportAsTxt.Size = new Size(112, 46);
			buttonExportAsTxt.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			buttonExportAsTxt.TabIndex = 3;
			toolTip.SetToolTip(buttonExportAsTxt, "Export as TXT");
			buttonExportAsTxt.Values.Image = Properties.Resources.silk_page_white_text;
			buttonExportAsTxt.Values.Text = "Export as TXT";
			buttonExportAsTxt.Click += ButtonExportAsTxt_Click;
			buttonExportAsTxt.Enter += SetStatusbar_Enter;
			buttonExportAsTxt.Leave += ClearStatusbar_Leave;
			buttonExportAsTxt.MouseEnter += SetStatusbar_Enter;
			buttonExportAsTxt.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonExportAsXml
			// 
			buttonExportAsXml.AccessibleDescription = "Exports the data sheet as XML file";
			buttonExportAsXml.AccessibleName = "Export as XML";
			buttonExportAsXml.AccessibleRole = AccessibleRole.PushButton;
			buttonExportAsXml.Location = new Point(349, 192);
			buttonExportAsXml.Margin = new Padding(4, 3, 4, 3);
			buttonExportAsXml.Name = "buttonExportAsXml";
			buttonExportAsXml.Size = new Size(111, 46);
			buttonExportAsXml.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			buttonExportAsXml.TabIndex = 5;
			toolTip.SetToolTip(buttonExportAsXml, "Export as XML");
			buttonExportAsXml.Values.Image = Properties.Resources.silk_page_white_code;
			buttonExportAsXml.Values.Text = "Export as XML";
			buttonExportAsXml.Click += ButtonExportAsXml_Click;
			buttonExportAsXml.Enter += SetStatusbar_Enter;
			buttonExportAsXml.Leave += ClearStatusbar_Leave;
			buttonExportAsXml.MouseEnter += SetStatusbar_Enter;
			buttonExportAsXml.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonExportAsHtml
			// 
			buttonExportAsHtml.AccessibleDescription = "Exports the data sheet as HTML file";
			buttonExportAsHtml.AccessibleName = "Export as HTML";
			buttonExportAsHtml.AccessibleRole = AccessibleRole.PushButton;
			buttonExportAsHtml.Location = new Point(348, 138);
			buttonExportAsHtml.Margin = new Padding(4, 3, 4, 3);
			buttonExportAsHtml.Name = "buttonExportAsHtml";
			buttonExportAsHtml.Size = new Size(111, 46);
			buttonExportAsHtml.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			buttonExportAsHtml.TabIndex = 4;
			toolTip.SetToolTip(buttonExportAsHtml, "Export as HTML");
			buttonExportAsHtml.Values.Image = Properties.Resources.silk_page_white_code;
			buttonExportAsHtml.Values.Text = "Export as HTML";
			buttonExportAsHtml.Click += ButtonExportAsHtml_Click;
			buttonExportAsHtml.Enter += SetStatusbar_Enter;
			buttonExportAsHtml.Leave += ClearStatusbar_Leave;
			buttonExportAsHtml.MouseEnter += SetStatusbar_Enter;
			buttonExportAsHtml.MouseLeave += ClearStatusbar_Leave;
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
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(474, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
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
			// buttonUnmarkAll
			// 
			buttonUnmarkAll.AccessibleDescription = "Umarks all orbital elements";
			buttonUnmarkAll.AccessibleName = "Umark all orbital elements";
			buttonUnmarkAll.AccessibleRole = AccessibleRole.PushButton;
			buttonUnmarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonUnmarkAll.Location = new Point(349, 50);
			buttonUnmarkAll.Margin = new Padding(4, 3, 4, 3);
			buttonUnmarkAll.Name = "buttonUnmarkAll";
			buttonUnmarkAll.Size = new Size(110, 29);
			buttonUnmarkAll.TabIndex = 2;
			toolTip.SetToolTip(buttonUnmarkAll, "Umark all orbital elements");
			buttonUnmarkAll.Values.Text = "&Unmark all";
			buttonUnmarkAll.Click += ButtonUnmarkAll_Click;
			buttonUnmarkAll.Enter += SetStatusbar_Enter;
			buttonUnmarkAll.Leave += ClearStatusbar_Leave;
			buttonUnmarkAll.MouseEnter += SetStatusbar_Enter;
			buttonUnmarkAll.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonMarkAll
			// 
			buttonMarkAll.AccessibleDescription = "Marks all orbital elements";
			buttonMarkAll.AccessibleName = "Mark all orbital elements";
			buttonMarkAll.AccessibleRole = AccessibleRole.PushButton;
			buttonMarkAll.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
			buttonMarkAll.Location = new Point(349, 14);
			buttonMarkAll.Margin = new Padding(4, 3, 4, 3);
			buttonMarkAll.Name = "buttonMarkAll";
			buttonMarkAll.Size = new Size(110, 29);
			buttonMarkAll.TabIndex = 1;
			toolTip.SetToolTip(buttonMarkAll, "Mark all orbital elements");
			buttonMarkAll.Values.Image = Properties.Resources.silk_asterisk_orange;
			buttonMarkAll.Values.Text = "&Mark all";
			buttonMarkAll.Click += ButtonMarkAll_Click;
			buttonMarkAll.Enter += SetStatusbar_Enter;
			buttonMarkAll.Leave += ClearStatusbar_Leave;
			buttonMarkAll.MouseEnter += SetStatusbar_Enter;
			buttonMarkAll.MouseLeave += ClearStatusbar_Leave;
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
			toolStripContainer.ContentPanel.Controls.Add(panel);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(474, 308);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(474, 330);
			toolStripContainer.TabIndex = 3;
			toolTip.SetToolTip(toolStripContainer, "Container to arrange the toolbars");
			// 
			// panel
			// 
			panel.AccessibleDescription = "Grpups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(buttonExportAsJson);
			panel.Controls.Add(buttonUnmarkAll);
			panel.Controls.Add(buttonExportAsXml);
			panel.Controls.Add(buttonExportAsTxt);
			panel.Controls.Add(buttonExportAsHtml);
			panel.Controls.Add(checkedListBoxOrbitalElements);
			panel.Controls.Add(buttonMarkAll);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Margin = new Padding(4, 3, 4, 3);
			panel.Name = "panel";
			panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			panel.Size = new Size(474, 308);
			panel.TabIndex = 0;
			panel.TabStop = true;
			// 
			// checkedListBoxOrbitalElements
			// 
			checkedListBoxOrbitalElements.AccessibleDescription = "Checks some orbital elements to print on a data sheet";
			checkedListBoxOrbitalElements.AccessibleName = "Check orbital elements";
			checkedListBoxOrbitalElements.AccessibleRole = AccessibleRole.List;
			checkedListBoxOrbitalElements.BackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
			checkedListBoxOrbitalElements.CheckOnClick = true;
			checkedListBoxOrbitalElements.FormattingEnabled = true;
			checkedListBoxOrbitalElements.HorizontalScrollbar = true;
			checkedListBoxOrbitalElements.Items.AddRange(new object[] { "Index No.", "Readable designation", "Epoch (in packed form, .0 TT)", "Mean anomaly at the epoch (degrees)", "Argument of perihelion, J2000.0 (degrees)", "Longitude of the ascending node, J2000.0", "Inclination to the ecliptic, J2000.0 (degrees)", "Orbital eccentricity", "Mean daily motion (degrees per day)", "Semimajor axis (AU)", "Absolute magnitude, H (mag)", "Slope parameter, G", "Reference", "Number of oppositions", "Number of observations", "Observation span", "r.m.s. residual (arseconds)", "Computer name", "4-hexdigit flags", "Date of last observation (YYYMMDD)", "Linear eccentricity (AU)", "Semi-minor axis (AU)", "Major axis (AU)", "Minor axis (AU)", "Eccenctric anomaly (degrees)", "True anomaly (degrees)", "Perihelion distance (AU)", "Aphelion distance (AU)", "Longitude of Descending node (degrees)", "Argument of aphelion (degrees)", "Focal parameter (AU)", "Semi-latus rectum (AU)", "Latus rectum (AU)", "Orbital period (years)", "Orbital area (AU²)", "Orbital perimeter (AU)", "Semi-mean axis (AU)", "Mean axis (AU)", "Standard gravitational parameter (AU³/a²)" });
			checkedListBoxOrbitalElements.Location = new Point(14, 14);
			checkedListBoxOrbitalElements.Margin = new Padding(4, 3, 4, 3);
			checkedListBoxOrbitalElements.Name = "checkedListBoxOrbitalElements";
			checkedListBoxOrbitalElements.Size = new Size(327, 277);
			checkedListBoxOrbitalElements.TabIndex = 0;
			toolTip.SetToolTip(checkedListBoxOrbitalElements, "Check orbital elements");
			checkedListBoxOrbitalElements.SelectedIndexChanged += CheckedListBoxOrbitalElements_SelectedIndexChanged;
			checkedListBoxOrbitalElements.ItemCheck += CheckedListBoxOrbitalElements_ItemCheck;
			checkedListBoxOrbitalElements.Enter += SetStatusbar_Enter;
			checkedListBoxOrbitalElements.Leave += ClearStatusbar_Leave;
			checkedListBoxOrbitalElements.MouseEnter += SetStatusbar_Enter;
			checkedListBoxOrbitalElements.MouseLeave += ClearStatusbar_Leave;
			// 
			// saveFileDialogTxt
			// 
			saveFileDialogTxt.DefaultExt = "txt";
			saveFileDialogTxt.Filter = "text files|*.txt|all files|*.*";
			// 
			// saveFileDialogHtml
			// 
			saveFileDialogHtml.DefaultExt = "html";
			saveFileDialogHtml.Filter = "HTML files|*.html|all files|*.*";
			// 
			// saveFileDialogXml
			// 
			saveFileDialogXml.DefaultExt = "xml";
			saveFileDialogXml.Filter = "XML files|*.xml|all files|*.*";
			// 
			// saveFileDialogJson
			// 
			saveFileDialogJson.DefaultExt = "json";
			saveFileDialogJson.Filter = "JSON files|*.json|all files|*.*";
			// 
			// ExportDataSheetForm
			// 
			AccessibleDescription = "Exports data sheet";
			AccessibleName = "Export data sheet";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(474, 330);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ExportDataSheetForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Export data sheet";
			toolTip.SetToolTip(this, "Export data sheet");
			Load += ExportDataSheetForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Krypton.Toolkit.KryptonButton buttonExportAsHtml;
		private Krypton.Toolkit.KryptonButton buttonExportAsTxt;
		private Krypton.Toolkit.KryptonButton buttonExportAsXml;
		private Krypton.Toolkit.KryptonButton buttonExportAsJson;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolTip toolTip;
		private SaveFileDialog saveFileDialogTxt;
		private SaveFileDialog saveFileDialogHtml;
		private SaveFileDialog saveFileDialogXml;
		private SaveFileDialog saveFileDialogJson;
		private ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonCheckedListBox checkedListBoxOrbitalElements;
		private Krypton.Toolkit.KryptonButton buttonUnmarkAll;
		private Krypton.Toolkit.KryptonButton buttonMarkAll;
	}
}