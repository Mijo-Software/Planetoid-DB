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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EphemeridesForm));
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			panel = new Krypton.Toolkit.KryptonPanel();
			buttonCalculate = new Krypton.Toolkit.KryptonButton();
			listView = new Krypton.Toolkit.KryptonListView();
			labelPercent = new Krypton.Toolkit.KryptonLabel();
			progressBar = new Krypton.Toolkit.KryptonProgressBar();
			labelEphemeridesStepsInDays = new Krypton.Toolkit.KryptonLabel();
			numericUpDownStepsInDays = new Krypton.Toolkit.KryptonNumericUpDown();
			labelEphemeridesEnd = new Krypton.Toolkit.KryptonLabel();
			dateTimePickerEphemeridesEnd = new Krypton.Toolkit.KryptonDateTimePicker();
			labelEphemeridesBegin = new Krypton.Toolkit.KryptonLabel();
			dateTimePickerEphemeridesBegin = new Krypton.Toolkit.KryptonDateTimePicker();
			toolTip = new ToolTip(components);
			backgroundWorker = new System.ComponentModel.BackgroundWorker();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(406, 22);
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
			labelInformation.ToolTipText = "Show some information";
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Groups the data";
			toolStripContainer.AccessibleName = "panel";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(panel);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(406, 406);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(406, 453);
			toolStripContainer.TabIndex = 11;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "panel";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(buttonCalculate);
			panel.Controls.Add(listView);
			panel.Controls.Add(labelPercent);
			panel.Controls.Add(progressBar);
			panel.Controls.Add(labelEphemeridesStepsInDays);
			panel.Controls.Add(numericUpDownStepsInDays);
			panel.Controls.Add(labelEphemeridesEnd);
			panel.Controls.Add(dateTimePickerEphemeridesEnd);
			panel.Controls.Add(labelEphemeridesBegin);
			panel.Controls.Add(dateTimePickerEphemeridesBegin);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Margin = new Padding(4, 3, 4, 3);
			panel.Name = "panel";
			panel.Size = new Size(406, 406);
			panel.TabIndex = 0;
			// 
			// buttonCalculate
			// 
			buttonCalculate.AccessibleDescription = "Calculates the ephemerides";
			buttonCalculate.AccessibleName = "Calculate the ephemerides";
			buttonCalculate.AccessibleRole = AccessibleRole.PushButton;
			buttonCalculate.Location = new Point(287, 115);
			buttonCalculate.Margin = new Padding(4, 3, 4, 3);
			buttonCalculate.Name = "buttonCalculate";
			buttonCalculate.Size = new Size(105, 29);
			buttonCalculate.TabIndex = 6;
			toolTip.SetToolTip(buttonCalculate, "Calculate the ephemerides");
			buttonCalculate.Values.DropDownArrowColor = Color.Empty;
			buttonCalculate.Values.Image = Properties.Resources.silk_calculator;
			buttonCalculate.Values.Text = "&Calculate";
			buttonCalculate.Click += ButtonCalculate_Click;
			buttonCalculate.Enter += SetStatusbar_Enter;
			buttonCalculate.Leave += ClearStatusbar_Leave;
			buttonCalculate.MouseEnter += SetStatusbar_Enter;
			buttonCalculate.MouseLeave += ClearStatusbar_Leave;
			// 
			// listView
			// 
			listView.AccessibleDescription = "Shows the search results";
			listView.AccessibleName = "Search results";
			listView.AccessibleRole = AccessibleRole.List;
			listView.HideSelection = false;
			listView.Location = new Point(14, 203);
			listView.Margin = new Padding(4, 3, 4, 3);
			listView.MultiSelect = false;
			listView.Name = "listView";
			listView.ShowItemToolTips = true;
			listView.Size = new Size(378, 209);
			listView.TabIndex = 9;
			toolTip.SetToolTip(listView, "Search results");
			listView.Enter += SetStatusbar_Enter;
			listView.Leave += ClearStatusbar_Leave;
			listView.MouseEnter += SetStatusbar_Enter;
			listView.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelPercent
			// 
			labelPercent.AccessibleDescription = "Shows the percent status of the search";
			labelPercent.AccessibleName = "Percent status of the search";
			labelPercent.AccessibleRole = AccessibleRole.StaticText;
			labelPercent.Location = new Point(341, 162);
			labelPercent.Margin = new Padding(4, 3, 4, 3);
			labelPercent.Name = "labelPercent";
			labelPercent.Size = new Size(44, 20);
			labelPercent.TabIndex = 8;
			toolTip.SetToolTip(labelPercent, "Shows the progress status of the search");
			labelPercent.Values.Text = "100 %";
			labelPercent.Enter += SetStatusbar_Enter;
			labelPercent.Leave += ClearStatusbar_Leave;
			labelPercent.MouseEnter += SetStatusbar_Enter;
			labelPercent.MouseLeave += ClearStatusbar_Leave;
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Shows the progress status of the search";
			progressBar.AccessibleName = "Progress bar";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Location = new Point(14, 165);
			progressBar.Margin = new Padding(4, 3, 4, 3);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(320, 20);
			progressBar.TabIndex = 7;
			toolTip.SetToolTip(progressBar, "Shows the progress status of the search");
			progressBar.Values.Text = "";
			progressBar.MouseEnter += SetStatusbar_Enter;
			progressBar.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelEphemeridesStepsInDays
			// 
			labelEphemeridesStepsInDays.AccessibleRole = AccessibleRole.StaticText;
			labelEphemeridesStepsInDays.Location = new Point(14, 78);
			labelEphemeridesStepsInDays.Margin = new Padding(4, 3, 4, 3);
			labelEphemeridesStepsInDays.Name = "labelEphemeridesStepsInDays";
			labelEphemeridesStepsInDays.Size = new Size(82, 20);
			labelEphemeridesStepsInDays.TabIndex = 4;
			labelEphemeridesStepsInDays.Values.Text = "&Steps in days";
			labelEphemeridesStepsInDays.Enter += SetStatusbar_Enter;
			labelEphemeridesStepsInDays.Leave += ClearStatusbar_Leave;
			labelEphemeridesStepsInDays.MouseEnter += SetStatusbar_Enter;
			labelEphemeridesStepsInDays.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownStepsInDays
			// 
			numericUpDownStepsInDays.AccessibleDescription = "Choose the steps in days";
			numericUpDownStepsInDays.AccessibleName = "Steps in days";
			numericUpDownStepsInDays.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownStepsInDays.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownStepsInDays.Location = new Point(159, 76);
			numericUpDownStepsInDays.Margin = new Padding(4, 3, 4, 3);
			numericUpDownStepsInDays.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownStepsInDays.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownStepsInDays.Name = "numericUpDownStepsInDays";
			numericUpDownStepsInDays.Size = new Size(92, 22);
			numericUpDownStepsInDays.TabIndex = 5;
			toolTip.SetToolTip(numericUpDownStepsInDays, "Steps in days");
			numericUpDownStepsInDays.Value = new decimal(new int[] { 0, 0, 0, 0 });
			numericUpDownStepsInDays.Enter += SetStatusbar_Enter;
			numericUpDownStepsInDays.Leave += ClearStatusbar_Leave;
			numericUpDownStepsInDays.MouseEnter += SetStatusbar_Enter;
			numericUpDownStepsInDays.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelEphemeridesEnd
			// 
			labelEphemeridesEnd.AccessibleDescription = "Sets the end of the ephemerides";
			labelEphemeridesEnd.AccessibleName = "Ephemerides end";
			labelEphemeridesEnd.AccessibleRole = AccessibleRole.StaticText;
			labelEphemeridesEnd.Location = new Point(14, 45);
			labelEphemeridesEnd.Margin = new Padding(4, 3, 4, 3);
			labelEphemeridesEnd.Name = "labelEphemeridesEnd";
			labelEphemeridesEnd.Size = new Size(108, 20);
			labelEphemeridesEnd.TabIndex = 2;
			toolTip.SetToolTip(labelEphemeridesEnd, "Ephemerides end");
			labelEphemeridesEnd.Values.Text = "Ephemerides &end:";
			labelEphemeridesEnd.Enter += SetStatusbar_Enter;
			labelEphemeridesEnd.Leave += ClearStatusbar_Leave;
			labelEphemeridesEnd.MouseEnter += SetStatusbar_Enter;
			labelEphemeridesEnd.MouseLeave += ClearStatusbar_Leave;
			// 
			// dateTimePickerEphemeridesEnd
			// 
			dateTimePickerEphemeridesEnd.AccessibleRole = AccessibleRole.DropList;
			dateTimePickerEphemeridesEnd.Location = new Point(159, 44);
			dateTimePickerEphemeridesEnd.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerEphemeridesEnd.Name = "dateTimePickerEphemeridesEnd";
			dateTimePickerEphemeridesEnd.Size = new Size(173, 21);
			dateTimePickerEphemeridesEnd.TabIndex = 3;
			toolTip.SetToolTip(dateTimePickerEphemeridesEnd, "Date of the ephemerides end");
			dateTimePickerEphemeridesEnd.Enter += SetStatusbar_Enter;
			dateTimePickerEphemeridesEnd.Leave += ClearStatusbar_Leave;
			dateTimePickerEphemeridesEnd.MouseEnter += SetStatusbar_Enter;
			dateTimePickerEphemeridesEnd.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelEphemeridesBegin
			// 
			labelEphemeridesBegin.AccessibleDescription = "Sets the begin of the ephemerides";
			labelEphemeridesBegin.AccessibleName = "Ephemerides begin";
			labelEphemeridesBegin.AccessibleRole = AccessibleRole.StaticText;
			labelEphemeridesBegin.Location = new Point(14, 14);
			labelEphemeridesBegin.Margin = new Padding(4, 3, 4, 3);
			labelEphemeridesBegin.Name = "labelEphemeridesBegin";
			labelEphemeridesBegin.Size = new Size(118, 20);
			labelEphemeridesBegin.TabIndex = 0;
			toolTip.SetToolTip(labelEphemeridesBegin, "Ephemerides begin");
			labelEphemeridesBegin.Values.Text = "Ephemerides &begin:";
			labelEphemeridesBegin.Enter += SetStatusbar_Enter;
			labelEphemeridesBegin.Leave += ClearStatusbar_Leave;
			labelEphemeridesBegin.MouseEnter += SetStatusbar_Enter;
			labelEphemeridesBegin.MouseLeave += ClearStatusbar_Leave;
			// 
			// dateTimePickerEphemeridesBegin
			// 
			dateTimePickerEphemeridesBegin.AccessibleRole = AccessibleRole.DropList;
			dateTimePickerEphemeridesBegin.Location = new Point(159, 13);
			dateTimePickerEphemeridesBegin.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerEphemeridesBegin.Name = "dateTimePickerEphemeridesBegin";
			dateTimePickerEphemeridesBegin.Size = new Size(173, 21);
			dateTimePickerEphemeridesBegin.TabIndex = 1;
			toolTip.SetToolTip(dateTimePickerEphemeridesBegin, "Date of the ephemerides begin");
			dateTimePickerEphemeridesBegin.Enter += SetStatusbar_Enter;
			dateTimePickerEphemeridesBegin.Leave += ClearStatusbar_Leave;
			dateTimePickerEphemeridesBegin.MouseEnter += SetStatusbar_Enter;
			dateTimePickerEphemeridesBegin.MouseLeave += ClearStatusbar_Leave;
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			// 
			// EphemeridesForm
			// 
			AccessibleDescription = "Calculates the ephemerides";
			AccessibleName = "Ephemerides";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(406, 453);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "EphemeridesForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Ephemerides";
			FormClosed += EphemeridesForm_FormClosed;
			Load += EphemeridesForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);

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