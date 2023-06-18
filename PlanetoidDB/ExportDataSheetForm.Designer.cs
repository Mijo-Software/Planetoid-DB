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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportDataSheetForm));
			this.kryptonTableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.kryptonButtonExportAsJson = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonExportAsTxt = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonExportAsXml = new Krypton.Toolkit.KryptonButton();
			this.kryptonButtonExportAsHtml = new Krypton.Toolkit.KryptonButton();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.kryptonTableLayoutPanel.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// kryptonTableLayoutPanel
			// 
			this.kryptonTableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.kryptonTableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel.BackgroundImage")));
			this.kryptonTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.kryptonTableLayoutPanel.ColumnCount = 4;
			this.kryptonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.kryptonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.kryptonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.kryptonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.kryptonTableLayoutPanel.Controls.Add(this.kryptonButtonExportAsJson, 3, 0);
			this.kryptonTableLayoutPanel.Controls.Add(this.kryptonButtonExportAsTxt, 0, 0);
			this.kryptonTableLayoutPanel.Controls.Add(this.kryptonButtonExportAsXml, 2, 0);
			this.kryptonTableLayoutPanel.Controls.Add(this.kryptonButtonExportAsHtml, 1, 0);
			this.kryptonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonTableLayoutPanel.Name = "kryptonTableLayoutPanel";
			this.kryptonTableLayoutPanel.RowCount = 1;
			this.kryptonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.kryptonTableLayoutPanel.Size = new System.Drawing.Size(406, 46);
			this.kryptonTableLayoutPanel.TabIndex = 0;
			// 
			// kryptonButtonExportAsJson
			// 
			this.kryptonButtonExportAsJson.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonExportAsJson.CornerRoundingRadius = -1F;
			this.kryptonButtonExportAsJson.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonExportAsJson.Location = new System.Drawing.Point(306, 3);
			this.kryptonButtonExportAsJson.Name = "kryptonButtonExportAsJson";
			this.kryptonButtonExportAsJson.Size = new System.Drawing.Size(97, 40);
			this.kryptonButtonExportAsJson.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.kryptonButtonExportAsJson.TabIndex = 3;
			this.kryptonButtonExportAsJson.Values.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_code;
			this.kryptonButtonExportAsJson.Values.Text = "Export as JSON";
			this.kryptonButtonExportAsJson.Click += new System.EventHandler(this.KryptonButtonExportAsJson_Click);
			this.kryptonButtonExportAsJson.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsJson.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonExportAsJson.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsJson.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonExportAsTxt
			// 
			this.kryptonButtonExportAsTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonExportAsTxt.CornerRoundingRadius = -1F;
			this.kryptonButtonExportAsTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonExportAsTxt.Location = new System.Drawing.Point(3, 3);
			this.kryptonButtonExportAsTxt.Name = "kryptonButtonExportAsTxt";
			this.kryptonButtonExportAsTxt.Size = new System.Drawing.Size(95, 40);
			this.kryptonButtonExportAsTxt.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.kryptonButtonExportAsTxt.TabIndex = 0;
			this.kryptonButtonExportAsTxt.Values.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_text;
			this.kryptonButtonExportAsTxt.Values.Text = "Export as TXT";
			this.kryptonButtonExportAsTxt.Click += new System.EventHandler(this.KryptonButtonExportAsTxt_Click);
			this.kryptonButtonExportAsTxt.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsTxt.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonExportAsTxt.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsTxt.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonExportAsXml
			// 
			this.kryptonButtonExportAsXml.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonExportAsXml.CornerRoundingRadius = -1F;
			this.kryptonButtonExportAsXml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonExportAsXml.Location = new System.Drawing.Point(205, 3);
			this.kryptonButtonExportAsXml.Name = "kryptonButtonExportAsXml";
			this.kryptonButtonExportAsXml.Size = new System.Drawing.Size(95, 40);
			this.kryptonButtonExportAsXml.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.kryptonButtonExportAsXml.TabIndex = 2;
			this.kryptonButtonExportAsXml.Values.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_code;
			this.kryptonButtonExportAsXml.Values.Text = "Export as XML";
			this.kryptonButtonExportAsXml.Click += new System.EventHandler(this.KryptonButtonExportAsXml_Click);
			this.kryptonButtonExportAsXml.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsXml.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonExportAsXml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsXml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonExportAsHtml
			// 
			this.kryptonButtonExportAsHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonExportAsHtml.CornerRoundingRadius = -1F;
			this.kryptonButtonExportAsHtml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonExportAsHtml.Location = new System.Drawing.Point(104, 3);
			this.kryptonButtonExportAsHtml.Name = "kryptonButtonExportAsHtml";
			this.kryptonButtonExportAsHtml.Size = new System.Drawing.Size(95, 40);
			this.kryptonButtonExportAsHtml.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.kryptonButtonExportAsHtml.TabIndex = 1;
			this.kryptonButtonExportAsHtml.Values.Image = global::Planetoid_DB.Properties.Resources.silk_page_white_code;
			this.kryptonButtonExportAsHtml.Values.Text = "Export as HTML";
			this.kryptonButtonExportAsHtml.Click += new System.EventHandler(this.KryptonButtonExportAsHtml_Click);
			this.kryptonButtonExportAsHtml.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsHtml.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonExportAsHtml.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonExportAsHtml.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 45);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(406, 22);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 1;
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
			// ExportDataSheetForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 67);
			this.Controls.Add(this.kryptonStatusStrip);
			this.Controls.Add(this.kryptonTableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ExportDataSheetForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Export data sheet";
			this.kryptonTableLayoutPanel.ResumeLayout(false);
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel;
		private Krypton.Toolkit.KryptonButton kryptonButtonExportAsHtml;
		private Krypton.Toolkit.KryptonButton kryptonButtonExportAsTxt;
		private Krypton.Toolkit.KryptonButton kryptonButtonExportAsXml;
		private Krypton.Toolkit.KryptonButton kryptonButtonExportAsJson;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
	}
}