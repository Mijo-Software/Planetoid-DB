namespace Planetoid_DB
{
	partial class LicenseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
			panel = new Krypton.Toolkit.KryptonPanel();
			kryptonButtonSaveLicense = new Krypton.Toolkit.KryptonButton();
			kryptonButtonClose = new Krypton.Toolkit.KryptonButton();
			kryptonPictureBoxLicenseLogo = new Krypton.Toolkit.KryptonPictureBox();
			kryptonTextBoxLicense = new Krypton.Toolkit.KryptonTextBox();
			statusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolTip = new ToolTip(components);
			saveFileDialog = new SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)panel).BeginInit();
			panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPictureBoxLicenseLogo).BeginInit();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// panel
			// 
			panel.AccessibleDescription = "Groups the data";
			panel.AccessibleName = "pane";
			panel.AccessibleRole = AccessibleRole.Pane;
			panel.Controls.Add(kryptonButtonSaveLicense);
			panel.Controls.Add(kryptonButtonClose);
			panel.Controls.Add(kryptonPictureBoxLicenseLogo);
			panel.Controls.Add(kryptonTextBoxLicense);
			panel.Controls.Add(statusStrip);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
			panel.Size = new Size(577, 225);
			panel.TabIndex = 0;
			// 
			// kryptonButtonSaveLicense
			// 
			kryptonButtonSaveLicense.AccessibleDescription = "Saves the license to the hard drive";
			kryptonButtonSaveLicense.AccessibleName = "Save the license";
			kryptonButtonSaveLicense.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonSaveLicense.Location = new Point(439, 136);
			kryptonButtonSaveLicense.Name = "kryptonButtonSaveLicense";
			kryptonButtonSaveLicense.Size = new Size(127, 25);
			kryptonButtonSaveLicense.TabIndex = 1;
			toolTip.SetToolTip(kryptonButtonSaveLicense, "Save the license");
			kryptonButtonSaveLicense.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonSaveLicense.Values.Image = Properties.Resources.silk_disk;
			kryptonButtonSaveLicense.Values.Text = "Save license";
			kryptonButtonSaveLicense.Click += KryptonButtonSaveLicense_Click;
			kryptonButtonSaveLicense.Enter += SetStatusbar_Enter;
			kryptonButtonSaveLicense.Leave += ClearStatusbar_Leave;
			kryptonButtonSaveLicense.MouseEnter += SetStatusbar_Enter;
			kryptonButtonSaveLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// kryptonButtonClose
			// 
			kryptonButtonClose.AccessibleDescription = "Closes the form";
			kryptonButtonClose.AccessibleName = "Close the form";
			kryptonButtonClose.AccessibleRole = AccessibleRole.PushButton;
			kryptonButtonClose.DialogResult = DialogResult.Cancel;
			kryptonButtonClose.Location = new Point(439, 167);
			kryptonButtonClose.Name = "kryptonButtonClose";
			kryptonButtonClose.Size = new Size(127, 25);
			kryptonButtonClose.TabIndex = 2;
			toolTip.SetToolTip(kryptonButtonClose, "Close");
			kryptonButtonClose.Values.DropDownArrowColor = Color.Empty;
			kryptonButtonClose.Values.Image = Properties.Resources.silk_cancel;
			kryptonButtonClose.Values.Text = "Close";
			kryptonButtonClose.Enter += SetStatusbar_Enter;
			kryptonButtonClose.Leave += ClearStatusbar_Leave;
			kryptonButtonClose.MouseEnter += SetStatusbar_Enter;
			kryptonButtonClose.MouseLeave += ClearStatusbar_Leave;
			// 
			// kryptonPictureBoxLicenseLogo
			// 
			kryptonPictureBoxLicenseLogo.AccessibleDescription = "Shows the logo of the license";
			kryptonPictureBoxLicenseLogo.AccessibleName = "GPL Logo";
			kryptonPictureBoxLicenseLogo.AccessibleRole = AccessibleRole.Graphic;
			kryptonPictureBoxLicenseLogo.Image = (Image)resources.GetObject("kryptonPictureBoxLicenseLogo.Image");
			kryptonPictureBoxLicenseLogo.Location = new Point(439, 12);
			kryptonPictureBoxLicenseLogo.Name = "kryptonPictureBoxLicenseLogo";
			kryptonPictureBoxLicenseLogo.Size = new Size(127, 71);
			kryptonPictureBoxLicenseLogo.SizeMode = PictureBoxSizeMode.Zoom;
			kryptonPictureBoxLicenseLogo.TabIndex = 8;
			kryptonPictureBoxLicenseLogo.TabStop = false;
			toolTip.SetToolTip(kryptonPictureBoxLicenseLogo, "GPL v3 Logo");
			kryptonPictureBoxLicenseLogo.MouseEnter += SetStatusbar_Enter;
			kryptonPictureBoxLicenseLogo.MouseLeave += ClearStatusbar_Leave;
			// 
			// kryptonTextBoxLicense
			// 
			kryptonTextBoxLicense.AccessibleDescription = "Show the license";
			kryptonTextBoxLicense.AccessibleName = "License";
			kryptonTextBoxLicense.AccessibleRole = AccessibleRole.Text;
			kryptonTextBoxLicense.Location = new Point(12, 12);
			kryptonTextBoxLicense.Multiline = true;
			kryptonTextBoxLicense.Name = "kryptonTextBoxLicense";
			kryptonTextBoxLicense.ReadOnly = true;
			kryptonTextBoxLicense.ScrollBars = ScrollBars.Both;
			kryptonTextBoxLicense.Size = new Size(421, 180);
			kryptonTextBoxLicense.TabIndex = 0;
			kryptonTextBoxLicense.TabStop = false;
			kryptonTextBoxLicense.Text = resources.GetString("kryptonTextBoxLicense.Text");
			toolTip.SetToolTip(kryptonTextBoxLicense, "License");
			kryptonTextBoxLicense.Enter += SetStatusbar_Enter;
			kryptonTextBoxLicense.Leave += ClearStatusbar_Leave;
			kryptonTextBoxLicense.MouseEnter += SetStatusbar_Enter;
			kryptonTextBoxLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows some information";
			statusStrip.AccessibleName = "Status bar of some information";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 203);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(577, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 3;
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
			// saveFileDialog
			// 
			saveFileDialog.Filter = "all files|*.*";
			// 
			// LicenseForm
			// 
			AccessibleDescription = "Shows the license information";
			AccessibleName = "License information";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(577, 225);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "LicenseForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "License: GPL-3.0";
			toolTip.SetToolTip(this, "License information");
			FormClosed += LicenseForm_FormClosed;
			Load += LicenseForm_Load;
			KeyDown += LicenseForm_KeyDown;
			((System.ComponentModel.ISupportInitialize)panel).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPictureBoxLicenseLogo).EndInit();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Krypton.Toolkit.KryptonPanel panel;
		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolTip toolTip;
		private Krypton.Toolkit.KryptonTextBox kryptonTextBoxLicense;
		private Krypton.Toolkit.KryptonPictureBox kryptonPictureBoxLicenseLogo;
		private Krypton.Toolkit.KryptonButton kryptonButtonClose;
		private Krypton.Toolkit.KryptonButton kryptonButtonSaveLicense;
		private SaveFileDialog saveFileDialog;
	}
}