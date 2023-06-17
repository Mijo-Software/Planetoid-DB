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
            this.checkedListBoxOrbitalElements = new System.Windows.Forms.CheckedListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonPrintDataSheet = new System.Windows.Forms.Button();
            this.buttonCancelPrint = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxOrbitalElements
            // 
            this.checkedListBoxOrbitalElements.AccessibleDescription = "Check some orbital elements to print on a data sheet";
            this.checkedListBoxOrbitalElements.AccessibleName = "Check orbital elements";
            this.checkedListBoxOrbitalElements.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.checkedListBoxOrbitalElements.CheckOnClick = true;
            this.checkedListBoxOrbitalElements.FormattingEnabled = true;
            this.checkedListBoxOrbitalElements.HorizontalScrollbar = true;
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
            this.checkedListBoxOrbitalElements.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.checkedListBoxOrbitalElements.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.checkedListBoxOrbitalElements.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.checkedListBoxOrbitalElements.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonPrintDataSheet
            // 
            this.buttonPrintDataSheet.AccessibleDescription = "Print a data sheet with some orbit elements";
            this.buttonPrintDataSheet.AccessibleName = "Print data sheet";
            this.buttonPrintDataSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPrintDataSheet.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonPrintDataSheet.Image = global::Planetoid_DB.Properties.Resources.silk_printer;
            this.buttonPrintDataSheet.Location = new System.Drawing.Point(12, 238);
            this.buttonPrintDataSheet.Name = "buttonPrintDataSheet";
            this.buttonPrintDataSheet.Size = new System.Drawing.Size(132, 36);
            this.buttonPrintDataSheet.TabIndex = 1;
            this.buttonPrintDataSheet.Text = "&Print the sheet";
            this.buttonPrintDataSheet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrintDataSheet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonPrintDataSheet, "Print a data sheet with some orbit elements");
            this.buttonPrintDataSheet.UseVisualStyleBackColor = true;
            this.buttonPrintDataSheet.Click += new System.EventHandler(this.ButtonPrintDataSheet_Click);
            this.buttonPrintDataSheet.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonPrintDataSheet.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonPrintDataSheet.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonPrintDataSheet.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCancelPrint
            // 
            this.buttonCancelPrint.AccessibleDescription = "Cancel the print";
            this.buttonCancelPrint.AccessibleName = "Cancel print";
            this.buttonCancelPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancelPrint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonCancelPrint.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
            this.buttonCancelPrint.Location = new System.Drawing.Point(164, 238);
            this.buttonCancelPrint.Name = "buttonCancelPrint";
            this.buttonCancelPrint.Size = new System.Drawing.Size(128, 36);
            this.buttonCancelPrint.TabIndex = 2;
            this.buttonCancelPrint.Text = "&Cancel print";
            this.buttonCancelPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCancelPrint, "Cancel the print");
            this.buttonCancelPrint.UseVisualStyleBackColor = true;
            this.buttonCancelPrint.Click += new System.EventHandler(this.ButtonCancelPrint_Click);
            this.buttonCancelPrint.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCancelPrint.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCancelPrint.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCancelPrint.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // statusStrip
            // 
            this.statusStrip.AccessibleDescription = "Show the status";
            this.statusStrip.AccessibleName = "Status bar";
            this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 287);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(306, 21);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.checkedListBoxOrbitalElements);
            this.kryptonPanel1.Controls.Add(this.buttonPrintDataSheet);
            this.kryptonPanel1.Controls.Add(this.buttonCancelPrint);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(306, 287);
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.TabStop = true;
            // 
            // PrintDataSheetForm
            // 
            this.AccessibleDescription = "Print a data sheet with some orbit elements";
            this.AccessibleName = "Print data sheet";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 308);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintDataSheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print data sheet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintDataSheetForm_FormClosed);
            this.Load += new System.EventHandler(this.PrintDataSheetForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxOrbitalElements;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelInformation;
        private System.Windows.Forms.Button buttonPrintDataSheet;
        private System.Windows.Forms.Button buttonCancelPrint;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}