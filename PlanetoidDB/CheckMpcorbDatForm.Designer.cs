using Krypton.Toolkit;

namespace Planetoid_DB
{
	partial class CheckMpcorbDatForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckMpcorbDatForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelUpdateNeeded = new System.Windows.Forms.Label();
			this.labelMpcorbDatLocal = new System.Windows.Forms.Label();
			this.labelMpcorbDatOnline = new System.Windows.Forms.Label();
			this.labelContentLengthText = new System.Windows.Forms.Label();
			this.labelModifiedDateText = new System.Windows.Forms.Label();
			this.labelContentLengthValueLocal = new System.Windows.Forms.Label();
			this.labelModifiedDateValueLocal = new System.Windows.Forms.Label();
			this.labelContentLengthValueOnline = new System.Windows.Forms.Label();
			this.labelModifiedDateValueOnline = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			this.kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			this.kryptonStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(132, 77);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "Okay");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			this.buttonOK.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOK.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelUpdateNeeded
			// 
			this.labelUpdateNeeded.AccessibleDescription = "Inform if an update is recommended";
			this.labelUpdateNeeded.AccessibleName = "Update text";
			this.labelUpdateNeeded.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelUpdateNeeded.AutoSize = true;
			this.labelUpdateNeeded.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel.SetColumnSpan(this.labelUpdateNeeded, 3);
			this.labelUpdateNeeded.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelUpdateNeeded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUpdateNeeded.Location = new System.Drawing.Point(3, 45);
			this.labelUpdateNeeded.Name = "labelUpdateNeeded";
			this.labelUpdateNeeded.Size = new System.Drawing.Size(333, 23);
			this.labelUpdateNeeded.TabIndex = 8;
			this.labelUpdateNeeded.Text = "Update needed?";
			this.labelUpdateNeeded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelUpdateNeeded, "Inform if an update is recommended");
			this.labelUpdateNeeded.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelUpdateNeeded.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelUpdateNeeded.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelUpdateNeeded.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMpcorbDatLocal
			// 
			this.labelMpcorbDatLocal.AccessibleDescription = "Information about the local MPCORB.DAT file";
			this.labelMpcorbDatLocal.AccessibleName = "Local MPCORB.DAT file";
			this.labelMpcorbDatLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMpcorbDatLocal.AutoSize = true;
			this.labelMpcorbDatLocal.BackColor = System.Drawing.Color.Transparent;
			this.labelMpcorbDatLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMpcorbDatLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMpcorbDatLocal.Location = new System.Drawing.Point(98, 0);
			this.labelMpcorbDatLocal.Name = "labelMpcorbDatLocal";
			this.labelMpcorbDatLocal.Size = new System.Drawing.Size(109, 15);
			this.labelMpcorbDatLocal.TabIndex = 0;
			this.labelMpcorbDatLocal.Text = "MPCORB.DAT local";
			this.labelMpcorbDatLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelMpcorbDatLocal, "Information about the local MPCORB.DAT file");
			this.labelMpcorbDatLocal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatLocal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMpcorbDatLocal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatLocal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelMpcorbDatOnline
			// 
			this.labelMpcorbDatOnline.AccessibleDescription = "Information about the online MPCORB.DAT file";
			this.labelMpcorbDatOnline.AccessibleName = "Online MPCORB.DAT file";
			this.labelMpcorbDatOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMpcorbDatOnline.AutoSize = true;
			this.labelMpcorbDatOnline.BackColor = System.Drawing.Color.Transparent;
			this.labelMpcorbDatOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMpcorbDatOnline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMpcorbDatOnline.Location = new System.Drawing.Point(213, 0);
			this.labelMpcorbDatOnline.Name = "labelMpcorbDatOnline";
			this.labelMpcorbDatOnline.Size = new System.Drawing.Size(123, 15);
			this.labelMpcorbDatOnline.TabIndex = 1;
			this.labelMpcorbDatOnline.Text = "MPCORB.DAT online";
			this.labelMpcorbDatOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelMpcorbDatOnline, "Information about the online MPCORB.DAT file");
			this.labelMpcorbDatOnline.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatOnline.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelMpcorbDatOnline.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelMpcorbDatOnline.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelContentLengthText
			// 
			this.labelContentLengthText.AccessibleDescription = "Show the content length";
			this.labelContentLengthText.AccessibleName = "Content length";
			this.labelContentLengthText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelContentLengthText.AutoSize = true;
			this.labelContentLengthText.BackColor = System.Drawing.Color.Transparent;
			this.labelContentLengthText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.labelContentLengthText.Location = new System.Drawing.Point(3, 15);
			this.labelContentLengthText.Name = "labelContentLengthText";
			this.labelContentLengthText.Size = new System.Drawing.Size(89, 15);
			this.labelContentLengthText.TabIndex = 2;
			this.labelContentLengthText.Text = "Content length:";
			this.labelContentLengthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelContentLengthText, "Show the content length");
			this.labelContentLengthText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelContentLengthText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelModifiedDateText
			// 
			this.labelModifiedDateText.AccessibleDescription = "Show the modified date";
			this.labelModifiedDateText.AccessibleName = "Modified date";
			this.labelModifiedDateText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelModifiedDateText.AutoSize = true;
			this.labelModifiedDateText.BackColor = System.Drawing.Color.Transparent;
			this.labelModifiedDateText.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelModifiedDateText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.labelModifiedDateText.Location = new System.Drawing.Point(3, 30);
			this.labelModifiedDateText.Name = "labelModifiedDateText";
			this.labelModifiedDateText.Size = new System.Drawing.Size(84, 15);
			this.labelModifiedDateText.TabIndex = 5;
			this.labelModifiedDateText.Text = "Modified date:";
			this.labelModifiedDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelModifiedDateText, "Show the modified date");
			this.labelModifiedDateText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelModifiedDateText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelContentLengthValueLocal
			// 
			this.labelContentLengthValueLocal.AccessibleDescription = "Show the content length";
			this.labelContentLengthValueLocal.AccessibleName = "Local content length";
			this.labelContentLengthValueLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelContentLengthValueLocal.AutoSize = true;
			this.labelContentLengthValueLocal.BackColor = System.Drawing.Color.Transparent;
			this.labelContentLengthValueLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContentLengthValueLocal.Location = new System.Drawing.Point(98, 15);
			this.labelContentLengthValueLocal.Name = "labelContentLengthValueLocal";
			this.labelContentLengthValueLocal.Size = new System.Drawing.Size(109, 15);
			this.labelContentLengthValueLocal.TabIndex = 3;
			this.labelContentLengthValueLocal.Text = "123456789 bytes";
			this.labelContentLengthValueLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelContentLengthValueLocal, "Show the content length");
			this.labelContentLengthValueLocal.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelContentLengthValueLocal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueLocal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelContentLengthValueLocal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueLocal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelModifiedDateValueLocal
			// 
			this.labelModifiedDateValueLocal.AccessibleDescription = "Show the local modified date";
			this.labelModifiedDateValueLocal.AccessibleName = "Local modified date";
			this.labelModifiedDateValueLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelModifiedDateValueLocal.AutoSize = true;
			this.labelModifiedDateValueLocal.BackColor = System.Drawing.Color.Transparent;
			this.labelModifiedDateValueLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifiedDateValueLocal.Location = new System.Drawing.Point(98, 30);
			this.labelModifiedDateValueLocal.Name = "labelModifiedDateValueLocal";
			this.labelModifiedDateValueLocal.Size = new System.Drawing.Size(109, 15);
			this.labelModifiedDateValueLocal.TabIndex = 6;
			this.labelModifiedDateValueLocal.Text = "00.00.0000 00:00";
			this.labelModifiedDateValueLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelModifiedDateValueLocal, "Show the local modified date");
			this.labelModifiedDateValueLocal.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelModifiedDateValueLocal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueLocal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelModifiedDateValueLocal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueLocal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelContentLengthValueOnline
			// 
			this.labelContentLengthValueOnline.AccessibleDescription = "Show the online content length";
			this.labelContentLengthValueOnline.AccessibleName = "Online content length";
			this.labelContentLengthValueOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelContentLengthValueOnline.AutoSize = true;
			this.labelContentLengthValueOnline.BackColor = System.Drawing.Color.Transparent;
			this.labelContentLengthValueOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContentLengthValueOnline.Location = new System.Drawing.Point(213, 15);
			this.labelContentLengthValueOnline.Name = "labelContentLengthValueOnline";
			this.labelContentLengthValueOnline.Size = new System.Drawing.Size(123, 15);
			this.labelContentLengthValueOnline.TabIndex = 4;
			this.labelContentLengthValueOnline.Text = "123456789 bytes";
			this.labelContentLengthValueOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelContentLengthValueOnline, "Show the online content length");
			this.labelContentLengthValueOnline.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelContentLengthValueOnline.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueOnline.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelContentLengthValueOnline.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelContentLengthValueOnline.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelModifiedDateValueOnline
			// 
			this.labelModifiedDateValueOnline.AccessibleDescription = "Show the online modified date";
			this.labelModifiedDateValueOnline.AccessibleName = "Online Modified date";
			this.labelModifiedDateValueOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelModifiedDateValueOnline.AutoSize = true;
			this.labelModifiedDateValueOnline.BackColor = System.Drawing.Color.Transparent;
			this.labelModifiedDateValueOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifiedDateValueOnline.Location = new System.Drawing.Point(213, 30);
			this.labelModifiedDateValueOnline.Name = "labelModifiedDateValueOnline";
			this.labelModifiedDateValueOnline.Size = new System.Drawing.Size(123, 15);
			this.labelModifiedDateValueOnline.TabIndex = 7;
			this.labelModifiedDateValueOnline.Text = "00.00.0000 00:00";
			this.labelModifiedDateValueOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.labelModifiedDateValueOnline, "Show the online modified date");
			this.labelModifiedDateValueOnline.DoubleClick += new System.EventHandler(this.CopyToClipboard_Click);
			this.labelModifiedDateValueOnline.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueOnline.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelModifiedDateValueOnline.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelModifiedDateValueOnline.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the data";
			this.tableLayoutPanel.AccessibleName = "Group pane";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel.ColumnCount = 3;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.labelMpcorbDatLocal, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelMpcorbDatOnline, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.labelContentLengthText, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelModifiedDateText, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelContentLengthValueLocal, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelModifiedDateValueLocal, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelContentLengthValueOnline, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.labelModifiedDateValueOnline, 2, 2);
			this.tableLayoutPanel.Controls.Add(this.labelUpdateNeeded, 0, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(339, 68);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.Controls.Add(this.kryptonStatusStrip);
			this.kryptonPanel.Controls.Add(this.buttonOK);
			this.kryptonPanel.Controls.Add(this.tableLayoutPanel);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(339, 124);
			this.kryptonPanel.TabIndex = 3;
			// 
			// kryptonStatusStrip
			// 
			this.kryptonStatusStrip.AccessibleDescription = "Shows some information";
			this.kryptonStatusStrip.AccessibleName = "Status bar of some information";
			this.kryptonStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.kryptonStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.kryptonStatusStrip.Location = new System.Drawing.Point(0, 102);
			this.kryptonStatusStrip.Name = "kryptonStatusStrip";
			this.kryptonStatusStrip.ProgressBars = null;
			this.kryptonStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.kryptonStatusStrip.Size = new System.Drawing.Size(339, 22);
			this.kryptonStatusStrip.SizingGrip = false;
			this.kryptonStatusStrip.TabIndex = 2;
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
			// CheckMpcorbDatForm
			// 
			this.AccessibleDescription = "Show the informations about the MPCORB.DAT database local and online";
			this.AccessibleName = "Check MPCORB.DAT";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 124);
			this.Controls.Add(this.kryptonPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CheckMpcorbDatForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Check MPCORB.DAT";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckMpcorbDatForm_FormClosed);
			this.Load += new System.EventHandler(this.CheckMpcorbDatForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			this.kryptonStatusStrip.ResumeLayout(false);
			this.kryptonStatusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button buttonOK;
		private KryptonTableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelUpdateNeeded;
		private System.Windows.Forms.Label labelMpcorbDatLocal;
		private System.Windows.Forms.Label labelMpcorbDatOnline;
		private System.Windows.Forms.Label labelContentLengthText;
		private System.Windows.Forms.Label labelModifiedDateText;
		private System.Windows.Forms.Label labelContentLengthValueLocal;
		private System.Windows.Forms.Label labelModifiedDateValueLocal;
		private System.Windows.Forms.Label labelContentLengthValueOnline;
		private System.Windows.Forms.Label labelModifiedDateValueOnline;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private KryptonStatusStrip kryptonStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}