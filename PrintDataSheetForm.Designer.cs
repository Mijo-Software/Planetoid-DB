namespace Planetoid_DB
{
    partial class PrintDataSheetForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintDataSheetForm));
			this.checkedListBoxOrbitalElements = new Krypton.Toolkit.KryptonCheckedListBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonPrintDataSheet = new Krypton.Toolkit.KryptonButton();
			this.buttonCancelPrint = new Krypton.Toolkit.KryptonButton();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkedListBoxOrbitalElements
			// 
			this.checkedListBoxOrbitalElements.AccessibleDescription = "Checks some orbital elements to print on a data sheet";
			this.checkedListBoxOrbitalElements.AccessibleName = "Checks orbital elements";
			this.checkedListBoxOrbitalElements.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.checkedListBoxOrbitalElements.BackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
			this.checkedListBoxOrbitalElements.CheckOnClick = true;
			this.checkedListBoxOrbitalElements.CornerRoundingRadius = -1F;
			this.checkedListBoxOrbitalElements.FormattingEnabled = true;
			this.checkedListBoxOrbitalElements.HorizontalScrollbar = true;
			this.checkedListBoxOrbitalElements.ItemCornerRoundingRadius = -1F;
			this.checkedListBoxOrbitalElements.Items.AddRange(new object[] {
            "Index No.",
            "Readable designation",
            "Epoch (in packed form, .0 TT)",
            "Mean anomaly at the epoch, in degrees",
            "Argument of perihelion, J2000.0 (degrees)",
            "Longitude of the ascending node, J2000.0",
            "Inclination to the ecliptic, J2000.0 (degrees)",
            "Orbital eccentricity",
            "Mean daily motion (degrees per day)",
            "Semimajor axis (AU)",
            "Absolute magnitude, H",
            "Slope parameter, G",
            "Reference",
            "Number of oppositions",
            "Number of observations",
            "Observation span",
            "r.m.s. residual (\")",
            "Computer name",
            "4-hexdigit flags",
            "Date of last observation",
            "Linear eccentricity",
            "Semi-minor axis",
            "Major axis",
            "Minor axis",
            "Eccenctric anomaly",
            "True anomaly",
            "Perihelion distance",
            "Aphelion distance",
            "Longitude of Descending node",
            "Argument of aphelion",
            "Focal parameter",
            "Semi-latus rectum",
            "Latus rectum",
            "Period",
            "Orbital area",
            "Orbital perimeter",
            "Semi-mean axis",
            "Mean axis",
            "Standard gravitational parameter"});
			this.checkedListBoxOrbitalElements.Location = new System.Drawing.Point(12, 12);
			this.checkedListBoxOrbitalElements.Name = "checkedListBoxOrbitalElements";
			this.checkedListBoxOrbitalElements.Size = new System.Drawing.Size(280, 220);
			this.checkedListBoxOrbitalElements.TabIndex = 0;
			this.toolTip.SetToolTip(this.checkedListBoxOrbitalElements, "Checks some orbital elements to print on a data sheet");
			this.checkedListBoxOrbitalElements.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkedListBoxOrbitalElements.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkedListBoxOrbitalElements.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkedListBoxOrbitalElements.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonPrintDataSheet
			// 
			this.buttonPrintDataSheet.AccessibleDescription = "Prints a data sheet with some orbit elements";
			this.buttonPrintDataSheet.AccessibleName = "Print data sheet";
			this.buttonPrintDataSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonPrintDataSheet.CornerRoundingRadius = -1F;
			this.buttonPrintDataSheet.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonPrintDataSheet.Location = new System.Drawing.Point(12, 238);
			this.buttonPrintDataSheet.Name = "buttonPrintDataSheet";
			this.buttonPrintDataSheet.Size = new System.Drawing.Size(132, 36);
			this.buttonPrintDataSheet.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonPrintDataSheet, "Print a data sheet with some orbit elements");
			this.buttonPrintDataSheet.Values.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
			this.buttonPrintDataSheet.Values.Text = "&Print the sheet";
			this.buttonPrintDataSheet.Click += new System.EventHandler(this.ButtonPrintDataSheet_Click);
			this.buttonPrintDataSheet.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonPrintDataSheet.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonPrintDataSheet.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonPrintDataSheet.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCancelPrint
			// 
			this.buttonCancelPrint.AccessibleDescription = "Cancels the print";
			this.buttonCancelPrint.AccessibleName = "Cancel print";
			this.buttonCancelPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancelPrint.CornerRoundingRadius = -1F;
			this.buttonCancelPrint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonCancelPrint.Location = new System.Drawing.Point(164, 238);
			this.buttonCancelPrint.Name = "buttonCancelPrint";
			this.buttonCancelPrint.Size = new System.Drawing.Size(128, 36);
			this.buttonCancelPrint.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonCancelPrint, "Cancel the print");
			this.buttonCancelPrint.Values.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.buttonCancelPrint.Values.Text = "&Cancel print";
			this.buttonCancelPrint.Click += new System.EventHandler(this.ButtonCancelPrint_Click);
			this.buttonCancelPrint.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelPrint.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCancelPrint.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCancelPrint.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "pane";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.statusStrip);
			this.panel.Controls.Add(this.checkedListBoxOrbitalElements);
			this.panel.Controls.Add(this.buttonPrintDataSheet);
			this.panel.Controls.Add(this.buttonCancelPrint);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.panel.Size = new System.Drawing.Size(306, 308);
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
			this.statusStrip.Location = new System.Drawing.Point(0, 286);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(306, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 3;
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
			// PrintDataSheetForm
			// 
			this.AccessibleDescription = "Prints a data sheet with some orbit elements";
			this.AccessibleName = "Print data sheet";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 308);
			this.Controls.Add(this.panel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintDataSheetForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Print data sheet";
			this.toolTip.SetToolTip(this, "Print data sheet");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintDataSheetForm_FormClosed);
			this.Load += new System.EventHandler(this.PrintDataSheetForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonCheckedListBox checkedListBoxOrbitalElements;
        private System.Windows.Forms.ToolTip toolTip;
        private Krypton.Toolkit.KryptonButton buttonPrintDataSheet;
        private Krypton.Toolkit.KryptonButton buttonCancelPrint;
        private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}