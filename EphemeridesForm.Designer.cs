namespace Planetoid_DB
{
	partial class EphemeridesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EphemeridesForm));
			this.statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.buttonCalculate = new Krypton.Toolkit.KryptonButton();
			this.listView = new Krypton.Toolkit.KryptonListView();
			this.labelPercent = new Krypton.Toolkit.KryptonLabel();
			this.progressBar = new Krypton.Toolkit.KryptonProgressBar();
			this.labelEphemeridesStepsInDays = new Krypton.Toolkit.KryptonLabel();
			this.numericUpDownStepsInDays = new Krypton.Toolkit.KryptonNumericUpDown();
			this.labelEphemeridesEnd = new Krypton.Toolkit.KryptonLabel();
			this.dateTimePickerEphemeridesEnd = new Krypton.Toolkit.KryptonDateTimePicker();
			this.labelEphemeridesBegin = new Krypton.Toolkit.KryptonLabel();
			this.dateTimePickerEphemeridesBegin = new Krypton.Toolkit.KryptonDateTimePicker();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Shows some information";
			this.statusStrip.AccessibleName = "Status bar of some information";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ProgressBars = null;
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(348, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
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
			this.labelInformation.ToolTipText = "Show some information";
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Groups the data";
			this.toolStripContainer.AccessibleName = "panel";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.panel);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(348, 371);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(348, 393);
			this.toolStripContainer.TabIndex = 11;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// panel
			// 
			this.panel.AccessibleDescription = "Groups the data";
			this.panel.AccessibleName = "panel";
			this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panel.Controls.Add(this.buttonCalculate);
			this.panel.Controls.Add(this.listView);
			this.panel.Controls.Add(this.labelPercent);
			this.panel.Controls.Add(this.progressBar);
			this.panel.Controls.Add(this.labelEphemeridesStepsInDays);
			this.panel.Controls.Add(this.numericUpDownStepsInDays);
			this.panel.Controls.Add(this.labelEphemeridesEnd);
			this.panel.Controls.Add(this.dateTimePickerEphemeridesEnd);
			this.panel.Controls.Add(this.labelEphemeridesBegin);
			this.panel.Controls.Add(this.dateTimePickerEphemeridesBegin);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(348, 371);
			this.panel.TabIndex = 0;
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.AccessibleDescription = "Calculates the ephemerides";
			this.buttonCalculate.AccessibleName = "Calculate the ephemerides";
			this.buttonCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCalculate.CornerRoundingRadius = -1F;
			this.buttonCalculate.Location = new System.Drawing.Point(246, 100);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(90, 25);
			this.buttonCalculate.TabIndex = 6;
			this.toolTip.SetToolTip(this.buttonCalculate, "Calculate the ephemerides");
			this.buttonCalculate.Values.Image = global::Planetoid_DB.Properties.Resources.silk_calculator;
			this.buttonCalculate.Values.Text = "&Calculate";
			this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
			this.buttonCalculate.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCalculate.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCalculate.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCalculate.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// listView
			// 
			this.listView.AccessibleDescription = "Shows the search results";
			this.listView.AccessibleName = "Search results";
			this.listView.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.listView.HideSelection = false;
			this.listView.ItemStyle = Krypton.Toolkit.ButtonStyle.ListItem;
			this.listView.Location = new System.Drawing.Point(12, 176);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.OwnerDraw = true;
			this.listView.ShowItemToolTips = true;
			this.listView.Size = new System.Drawing.Size(324, 181);
			this.listView.StateCommon.Item.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
			this.listView.StateCommon.Item.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.listView.StateCommon.Item.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.listView.TabIndex = 9;
			this.toolTip.SetToolTip(this.listView, "Search results");
			this.listView.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listView.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.listView.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listView.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPercent
			// 
			this.labelPercent.AccessibleDescription = "Shows the percent status of the search";
			this.labelPercent.AccessibleName = "Percent status of the search";
			this.labelPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPercent.Location = new System.Drawing.Point(292, 140);
			this.labelPercent.Name = "labelPercent";
			this.labelPercent.Size = new System.Drawing.Size(44, 20);
			this.labelPercent.TabIndex = 8;
			this.toolTip.SetToolTip(this.labelPercent, "Shows the progress status of the search");
			this.labelPercent.Values.Text = "100 %";
			this.labelPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// progressBar
			// 
			this.progressBar.AccessibleDescription = "Shows the progress status of the search";
			this.progressBar.AccessibleName = "Progress bar";
			this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBar.Location = new System.Drawing.Point(12, 143);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(274, 17);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 7;
			this.toolTip.SetToolTip(this.progressBar, "Shows the progress status of the search");
			this.progressBar.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBar.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEphemeridesStepsInDays
			// 
			this.labelEphemeridesStepsInDays.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEphemeridesStepsInDays.Location = new System.Drawing.Point(12, 68);
			this.labelEphemeridesStepsInDays.Name = "labelEphemeridesStepsInDays";
			this.labelEphemeridesStepsInDays.Size = new System.Drawing.Size(82, 20);
			this.labelEphemeridesStepsInDays.TabIndex = 4;
			this.labelEphemeridesStepsInDays.Values.Text = "&Steps in days";
			this.labelEphemeridesStepsInDays.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEphemeridesStepsInDays.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEphemeridesStepsInDays.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEphemeridesStepsInDays.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericUpDownStepsInDays
			// 
			this.numericUpDownStepsInDays.AccessibleDescription = "Choose the steps in days";
			this.numericUpDownStepsInDays.AccessibleName = "Steps in days";
			this.numericUpDownStepsInDays.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownStepsInDays.Location = new System.Drawing.Point(136, 66);
			this.numericUpDownStepsInDays.Name = "numericUpDownStepsInDays";
			this.numericUpDownStepsInDays.Size = new System.Drawing.Size(79, 22);
			this.numericUpDownStepsInDays.TabIndex = 5;
			this.toolTip.SetToolTip(this.numericUpDownStepsInDays, "Steps in days");
			this.numericUpDownStepsInDays.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownStepsInDays.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.numericUpDownStepsInDays.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownStepsInDays.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEphemeridesEnd
			// 
			this.labelEphemeridesEnd.AccessibleDescription = "Sets the end of the ephemerides";
			this.labelEphemeridesEnd.AccessibleName = "Ephemerides end";
			this.labelEphemeridesEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEphemeridesEnd.Location = new System.Drawing.Point(12, 39);
			this.labelEphemeridesEnd.Name = "labelEphemeridesEnd";
			this.labelEphemeridesEnd.Size = new System.Drawing.Size(108, 20);
			this.labelEphemeridesEnd.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelEphemeridesEnd, "Ephemerides end");
			this.labelEphemeridesEnd.Values.Text = "Ephemerides &end:";
			this.labelEphemeridesEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEphemeridesEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEphemeridesEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEphemeridesEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerEphemeridesEnd
			// 
			this.dateTimePickerEphemeridesEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
			this.dateTimePickerEphemeridesEnd.CornerRoundingRadius = -1F;
			this.dateTimePickerEphemeridesEnd.Location = new System.Drawing.Point(136, 38);
			this.dateTimePickerEphemeridesEnd.Name = "dateTimePickerEphemeridesEnd";
			this.dateTimePickerEphemeridesEnd.Size = new System.Drawing.Size(148, 21);
			this.dateTimePickerEphemeridesEnd.TabIndex = 3;
			this.toolTip.SetToolTip(this.dateTimePickerEphemeridesEnd, "Date of the ephemerides end");
			this.dateTimePickerEphemeridesEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEphemeridesEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerEphemeridesEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEphemeridesEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelEphemeridesBegin
			// 
			this.labelEphemeridesBegin.AccessibleDescription = "Sets the begin of the ephemerides";
			this.labelEphemeridesBegin.AccessibleName = "Ephemerides begin";
			this.labelEphemeridesBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelEphemeridesBegin.Location = new System.Drawing.Point(12, 12);
			this.labelEphemeridesBegin.Name = "labelEphemeridesBegin";
			this.labelEphemeridesBegin.Size = new System.Drawing.Size(118, 20);
			this.labelEphemeridesBegin.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelEphemeridesBegin, "Ephemerides begin");
			this.labelEphemeridesBegin.Values.Text = "Ephemerides &begin:";
			this.labelEphemeridesBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEphemeridesBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelEphemeridesBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelEphemeridesBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerEphemeridesBegin
			// 
			this.dateTimePickerEphemeridesBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
			this.dateTimePickerEphemeridesBegin.CornerRoundingRadius = -1F;
			this.dateTimePickerEphemeridesBegin.Location = new System.Drawing.Point(136, 11);
			this.dateTimePickerEphemeridesBegin.Name = "dateTimePickerEphemeridesBegin";
			this.dateTimePickerEphemeridesBegin.Size = new System.Drawing.Size(148, 21);
			this.dateTimePickerEphemeridesBegin.TabIndex = 1;
			this.toolTip.SetToolTip(this.dateTimePickerEphemeridesBegin, "Date of the ephemerides begin");
			this.dateTimePickerEphemeridesBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEphemeridesBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerEphemeridesBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEphemeridesBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// EphemeridesForm
			// 
			this.AccessibleDescription = "Calculates the ephemerides";
			this.AccessibleName = "Ephemerides";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 393);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EphemeridesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ephemerides";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EphemeridesForm_FormClosed);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonDateTimePicker dateTimePickerEphemeridesBegin;
		private System.Windows.Forms.ToolTip toolTip;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private Krypton.Toolkit.KryptonLabel labelEphemeridesEnd;
		private Krypton.Toolkit.KryptonDateTimePicker dateTimePickerEphemeridesEnd;
		private Krypton.Toolkit.KryptonLabel labelEphemeridesBegin;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownStepsInDays;
		private Krypton.Toolkit.KryptonLabel labelEphemeridesStepsInDays;
		private Krypton.Toolkit.KryptonLabel labelPercent;
		private Krypton.Toolkit.KryptonProgressBar progressBar;
		private Krypton.Toolkit.KryptonButton buttonCalculate;
		private Krypton.Toolkit.KryptonListView listView;
	}
}