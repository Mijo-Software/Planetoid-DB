namespace Planetoid_DB
{
    partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tabControlSettings = new System.Windows.Forms.TabControl();
			this.tabPageGeneral = new System.Windows.Forms.TabPage();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.tabPageNavigator = new System.Windows.Forms.TabPage();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.tabPageUpdate = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.tabPageLookAndFeel = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton11 = new System.Windows.Forms.RadioButton();
			this.radioButton12 = new System.Windows.Forms.RadioButton();
			this.toolStripIcons = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonLoadDefaultSettings = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainerSettings = new System.Windows.Forms.ToolStripContainer();
			this.panel = new Krypton.Toolkit.KryptonPanel();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControlSettings.SuspendLayout();
			this.tabPageGeneral.SuspendLayout();
			this.tabPageNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabPageUpdate.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPageLookAndFeel.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.toolStripIcons.SuspendLayout();
			this.toolStripContainerSettings.ContentPanel.SuspendLayout();
			this.toolStripContainerSettings.TopToolStripPanel.SuspendLayout();
			this.toolStripContainerSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlSettings
			// 
			this.tabControlSettings.Controls.Add(this.tabPageGeneral);
			this.tabControlSettings.Controls.Add(this.tabPageNavigator);
			this.tabControlSettings.Controls.Add(this.tabPageUpdate);
			this.tabControlSettings.Controls.Add(this.tabPageLookAndFeel);
			this.tabControlSettings.Location = new System.Drawing.Point(3, 3);
			this.tabControlSettings.Name = "tabControlSettings";
			this.tabControlSettings.SelectedIndex = 0;
			this.tabControlSettings.ShowToolTips = true;
			this.tabControlSettings.Size = new System.Drawing.Size(415, 252);
			this.tabControlSettings.TabIndex = 0;
			// 
			// tabPageGeneral
			// 
			this.tabPageGeneral.Controls.Add(this.checkBox10);
			this.tabPageGeneral.Controls.Add(this.checkBox9);
			this.tabPageGeneral.Controls.Add(this.checkBox8);
			this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabPageGeneral.Name = "tabPageGeneral";
			this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGeneral.Size = new System.Drawing.Size(407, 226);
			this.tabPageGeneral.TabIndex = 3;
			this.tabPageGeneral.Text = "General";
			this.tabPageGeneral.UseVisualStyleBackColor = true;
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.Location = new System.Drawing.Point(8, 56);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(182, 19);
			this.checkBox10.TabIndex = 2;
			this.checkBox10.Text = "Enable linking to terminology";
			this.checkBox10.UseVisualStyleBackColor = true;
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Location = new System.Drawing.Point(8, 31);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(283, 19);
			this.checkBox9.TabIndex = 1;
			this.checkBox9.Text = "Enabled copying to clipboard by double-clicking";
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Location = new System.Drawing.Point(8, 6);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(124, 19);
			this.checkBox8.TabIndex = 0;
			this.checkBox8.Text = "Stay always on top";
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// tabPageNavigator
			// 
			this.tabPageNavigator.Controls.Add(this.radioButton9);
			this.tabPageNavigator.Controls.Add(this.numericUpDown1);
			this.tabPageNavigator.Controls.Add(this.radioButton4);
			this.tabPageNavigator.Controls.Add(this.radioButton3);
			this.tabPageNavigator.Controls.Add(this.radioButton2);
			this.tabPageNavigator.Controls.Add(this.radioButton1);
			this.tabPageNavigator.Location = new System.Drawing.Point(4, 22);
			this.tabPageNavigator.Name = "tabPageNavigator";
			this.tabPageNavigator.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageNavigator.Size = new System.Drawing.Size(407, 226);
			this.tabPageNavigator.TabIndex = 0;
			this.tabPageNavigator.Text = "Navigator";
			this.tabPageNavigator.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Location = new System.Drawing.Point(8, 6);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(171, 19);
			this.radioButton9.TabIndex = 5;
			this.radioButton9.TabStop = true;
			this.radioButton9.Text = "Start with the last used item";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(28, 131);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(101, 23);
			this.numericUpDown1.TabIndex = 4;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(8, 106);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(154, 19);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Start with a specific item";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(8, 81);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(156, 19);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Start with a random item";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(8, 56);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(143, 19);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Start with the last item";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(8, 31);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(145, 19);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Start with the first item";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// tabPageUpdate
			// 
			this.tabPageUpdate.Controls.Add(this.groupBox2);
			this.tabPageUpdate.Controls.Add(this.groupBox1);
			this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
			this.tabPageUpdate.Name = "tabPageUpdate";
			this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageUpdate.Size = new System.Drawing.Size(407, 226);
			this.tabPageUpdate.TabIndex = 1;
			this.tabPageUpdate.Text = "MPCORB.DAT Update";
			this.tabPageUpdate.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.checkBox6);
			this.groupBox2.Controls.Add(this.checkBox4);
			this.groupBox2.Controls.Add(this.checkBox5);
			this.groupBox2.Location = new System.Drawing.Point(8, 112);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(391, 101);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Background update";
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(6, 72);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(262, 19);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "Ask for restart after the MPCORB.DAT update";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(6, 22);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(337, 19);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Check the MPCORB.DAT update every hour in background ";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(6, 47);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(371, 19);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Download automatically the MPCORB.DAT update in background";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(391, 100);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Startup update";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(6, 22);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(252, 19);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Check the MPCORB.DAT update on startup";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(6, 47);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(348, 19);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Download automatically the MPCORB.DAT update on startup";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(6, 72);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(262, 19);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Ask for restart after the MPCORB.DAT update";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// tabPageLookAndFeel
			// 
			this.tabPageLookAndFeel.Controls.Add(this.groupBox4);
			this.tabPageLookAndFeel.Location = new System.Drawing.Point(4, 22);
			this.tabPageLookAndFeel.Name = "tabPageLookAndFeel";
			this.tabPageLookAndFeel.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLookAndFeel.Size = new System.Drawing.Size(407, 226);
			this.tabPageLookAndFeel.TabIndex = 2;
			this.tabPageLookAndFeel.Text = "Look and feel";
			this.tabPageLookAndFeel.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.radioButton10);
			this.groupBox4.Controls.Add(this.radioButton11);
			this.groupBox4.Controls.Add(this.radioButton12);
			this.groupBox4.Location = new System.Drawing.Point(145, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(131, 137);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Icons";
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.Location = new System.Drawing.Point(6, 72);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(89, 19);
			this.radioButton10.TabIndex = 3;
			this.radioButton10.TabStop = true;
			this.radioButton10.Text = "Fugue icons";
			this.radioButton10.UseVisualStyleBackColor = true;
			// 
			// radioButton11
			// 
			this.radioButton11.AutoSize = true;
			this.radioButton11.Location = new System.Drawing.Point(6, 47);
			this.radioButton11.Name = "radioButton11";
			this.radioButton11.Size = new System.Drawing.Size(96, 19);
			this.radioButton11.TabIndex = 2;
			this.radioButton11.TabStop = true;
			this.radioButton11.Text = "FatCow icons";
			this.radioButton11.UseVisualStyleBackColor = true;
			// 
			// radioButton12
			// 
			this.radioButton12.AutoSize = true;
			this.radioButton12.Location = new System.Drawing.Point(6, 22);
			this.radioButton12.Name = "radioButton12";
			this.radioButton12.Size = new System.Drawing.Size(74, 19);
			this.radioButton12.TabIndex = 1;
			this.radioButton12.TabStop = true;
			this.radioButton12.Text = "Silk icons";
			this.radioButton12.UseVisualStyleBackColor = true;
			// 
			// toolStripIcons
			// 
			this.toolStripIcons.AccessibleDescription = "Toolbar of main functions";
			this.toolStripIcons.AccessibleName = "Toolbar of main functions";
			this.toolStripIcons.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.toolStripIcons.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripIcons.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonCancel,
            this.toolStripSeparator1,
            this.toolStripButtonLoadDefaultSettings});
			this.toolStripIcons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripIcons.Location = new System.Drawing.Point(0, 0);
			this.toolStripIcons.Name = "toolStripIcons";
			this.toolStripIcons.Size = new System.Drawing.Size(415, 25);
			this.toolStripIcons.Stretch = true;
			this.toolStripIcons.TabIndex = 0;
			this.toolStripIcons.TabStop = true;
			this.toolStripIcons.Text = "Toolbar of main functions";
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.AccessibleDescription = "Save the settings";
			this.toolStripButtonSave.AccessibleName = "Save";
			this.toolStripButtonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonSave.DoubleClickEnabled = true;
			this.toolStripButtonSave.Image = global::Planetoid_DB.Properties.Resources.silk_disk;
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(51, 22);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.ToolTipText = "Save the settings";
			// 
			// toolStripButtonCancel
			// 
			this.toolStripButtonCancel.AccessibleDescription = "Cancel the settings";
			this.toolStripButtonCancel.AccessibleName = "Cancel";
			this.toolStripButtonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonCancel.DoubleClickEnabled = true;
			this.toolStripButtonCancel.Image = global::Planetoid_DB.Properties.Resources.silk_cancel;
			this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCancel.Name = "toolStripButtonCancel";
			this.toolStripButtonCancel.Size = new System.Drawing.Size(63, 22);
			this.toolStripButtonCancel.Text = "Cancel";
			this.toolStripButtonCancel.ToolTipText = "Cancel the settings";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonLoadDefaultSettings
			// 
			this.toolStripButtonLoadDefaultSettings.AccessibleDescription = "Load the default settings";
			this.toolStripButtonLoadDefaultSettings.AccessibleName = "Default settings";
			this.toolStripButtonLoadDefaultSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonLoadDefaultSettings.DoubleClickEnabled = true;
			this.toolStripButtonLoadDefaultSettings.Image = global::Planetoid_DB.Properties.Resources.silk_cog;
			this.toolStripButtonLoadDefaultSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonLoadDefaultSettings.Name = "toolStripButtonLoadDefaultSettings";
			this.toolStripButtonLoadDefaultSettings.Size = new System.Drawing.Size(109, 22);
			this.toolStripButtonLoadDefaultSettings.Text = "Default settings";
			this.toolStripButtonLoadDefaultSettings.ToolTipText = "Load default settings";
			// 
			// toolStripContainerSettings
			// 
			// 
			// toolStripContainerSettings.ContentPanel
			// 
			this.toolStripContainerSettings.ContentPanel.Controls.Add(this.panel);
			this.toolStripContainerSettings.ContentPanel.Size = new System.Drawing.Size(415, 273);
			this.toolStripContainerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainerSettings.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainerSettings.Name = "toolStripContainerSettings";
			this.toolStripContainerSettings.Size = new System.Drawing.Size(415, 298);
			this.toolStripContainerSettings.TabIndex = 7;
			this.toolStripContainerSettings.Text = "Settings";
			// 
			// toolStripContainerSettings.TopToolStripPanel
			// 
			this.toolStripContainerSettings.TopToolStripPanel.Controls.Add(this.toolStripIcons);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.tabControlSettings);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			this.panel.Size = new System.Drawing.Size(415, 273);
			this.panel.TabIndex = 0;
			this.panel.TabStop = true;
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 276);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(415, 22);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 8;
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
			// SettingsForm
			// 
			this.AccessibleDescription = "Show the settings";
			this.AccessibleName = "Settings";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 298);
			this.Controls.Add(this.kryptonStatusStrip);
			this.Controls.Add(this.toolStripContainerSettings);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.tabControlSettings.ResumeLayout(false);
			this.tabPageGeneral.ResumeLayout(false);
			this.tabPageGeneral.PerformLayout();
			this.tabPageNavigator.ResumeLayout(false);
			this.tabPageNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabPageUpdate.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPageLookAndFeel.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.toolStripIcons.ResumeLayout(false);
			this.toolStripIcons.PerformLayout();
			this.toolStripContainerSettings.ContentPanel.ResumeLayout(false);
			this.toolStripContainerSettings.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainerSettings.TopToolStripPanel.PerformLayout();
			this.toolStripContainerSettings.ResumeLayout(false);
			this.toolStripContainerSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageNavigator;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TabPage tabPageLookAndFeel;
        private System.Windows.Forms.ToolStrip toolStripIcons;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadDefaultSettings;
        private System.Windows.Forms.ToolStripContainer toolStripContainerSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.RadioButton radioButton9;
        private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}