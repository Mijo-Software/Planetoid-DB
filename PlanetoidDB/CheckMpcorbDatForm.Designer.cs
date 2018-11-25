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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelHelp = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelIsUpdateNeeded = new System.Windows.Forms.Label();
			this.labelMpcorbDatLocal = new System.Windows.Forms.Label();
			this.labelMpcorbDatOnline = new System.Windows.Forms.Label();
			this.labelContentLengthText = new System.Windows.Forms.Label();
			this.labelModifiedDateText = new System.Windows.Forms.Label();
			this.labelContentLengthValueLocal = new System.Windows.Forms.Label();
			this.labelModifiedDateValueLocal = new System.Windows.Forms.Label();
			this.labelContentLengthValueOnline = new System.Windows.Forms.Label();
			this.labelModifiedDateValueOnline = new System.Windows.Forms.Label();
			this.statusStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(184, 92);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "Okay");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			this.buttonOK.Enter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.Leave += new System.EventHandler(this.ButtonOK_Leave);
			this.buttonOK.MouseEnter += new System.EventHandler(this.ButtonOK_Enter);
			this.buttonOK.MouseHover += new System.EventHandler(this.ButtonOK_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the status";
			this.statusStrip.AccessibleName = "Status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelHelp});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 118);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(444, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 2;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelHelp
			// 
			this.labelHelp.AccessibleDescription = "Show some important informations";
			this.labelHelp.AccessibleName = "Information field";
			this.labelHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelHelp.Image = global::Planetoid_DB.Properties.Resources.silk_lightbulb;
			this.labelHelp.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(170, 16);
			this.labelHelp.Text = "Show informative messages";
			this.labelHelp.ToolTipText = "Show informative messages";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.labelIsUpdateNeeded, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelMpcorbDatLocal, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelMpcorbDatOnline, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelContentLengthText, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelModifiedDateText, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelContentLengthValueLocal, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelModifiedDateValueLocal, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelContentLengthValueOnline, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelModifiedDateValueOnline, 2, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 68);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// labelIsUpdateNeeded
			// 
			this.labelIsUpdateNeeded.AutoSize = true;
			this.labelIsUpdateNeeded.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIsUpdateNeeded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIsUpdateNeeded.Location = new System.Drawing.Point(142, 45);
			this.labelIsUpdateNeeded.Name = "labelIsUpdateNeeded";
			this.labelIsUpdateNeeded.Size = new System.Drawing.Size(134, 23);
			this.labelIsUpdateNeeded.TabIndex = 8;
			this.labelIsUpdateNeeded.Text = "Update needed?";
			this.labelIsUpdateNeeded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelIsUpdateNeeded.Enter += new System.EventHandler(this.LabelIsUpdateNeeded_Enter);
			this.labelIsUpdateNeeded.Leave += new System.EventHandler(this.LabelIsUpdateNeeded_Leave);
			this.labelIsUpdateNeeded.MouseEnter += new System.EventHandler(this.LabelIsUpdateNeeded_Enter);
			this.labelIsUpdateNeeded.MouseLeave += new System.EventHandler(this.LabelIsUpdateNeeded_Leave);
			// 
			// labelMpcorbDatLocal
			// 
			this.labelMpcorbDatLocal.AutoSize = true;
			this.labelMpcorbDatLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMpcorbDatLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMpcorbDatLocal.Location = new System.Drawing.Point(142, 0);
			this.labelMpcorbDatLocal.Name = "labelMpcorbDatLocal";
			this.labelMpcorbDatLocal.Size = new System.Drawing.Size(134, 15);
			this.labelMpcorbDatLocal.TabIndex = 0;
			this.labelMpcorbDatLocal.Text = "MPCORB.DAT local";
			this.labelMpcorbDatLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMpcorbDatLocal.Enter += new System.EventHandler(this.LabelMpcorbDatLocal_Enter);
			this.labelMpcorbDatLocal.Leave += new System.EventHandler(this.LabelMpcorbDatLocal_Leave);
			this.labelMpcorbDatLocal.MouseEnter += new System.EventHandler(this.LabelMpcorbDatLocal_Enter);
			this.labelMpcorbDatLocal.MouseLeave += new System.EventHandler(this.LabelMpcorbDatLocal_Leave);
			// 
			// labelMpcorbDatOnline
			// 
			this.labelMpcorbDatOnline.AutoSize = true;
			this.labelMpcorbDatOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMpcorbDatOnline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.labelMpcorbDatOnline.Location = new System.Drawing.Point(282, 0);
			this.labelMpcorbDatOnline.Name = "labelMpcorbDatOnline";
			this.labelMpcorbDatOnline.Size = new System.Drawing.Size(135, 15);
			this.labelMpcorbDatOnline.TabIndex = 1;
			this.labelMpcorbDatOnline.Text = "MPCORB.DAT online";
			this.labelMpcorbDatOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMpcorbDatOnline.Enter += new System.EventHandler(this.LabelMpcorbDatOnline_Enter);
			this.labelMpcorbDatOnline.Leave += new System.EventHandler(this.LabelMpcorbDatOnline_Leave);
			this.labelMpcorbDatOnline.MouseEnter += new System.EventHandler(this.LabelMpcorbDatOnline_Enter);
			this.labelMpcorbDatOnline.MouseLeave += new System.EventHandler(this.LabelMpcorbDatOnline_Leave);
			// 
			// labelContentLengthText
			// 
			this.labelContentLengthText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.labelContentLengthText.AutoSize = true;
			this.labelContentLengthText.Location = new System.Drawing.Point(3, 15);
			this.labelContentLengthText.Name = "labelContentLengthText";
			this.labelContentLengthText.Size = new System.Drawing.Size(90, 15);
			this.labelContentLengthText.TabIndex = 2;
			this.labelContentLengthText.Text = "Content length:";
			this.labelContentLengthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelContentLengthText.Enter += new System.EventHandler(this.LabelContentLengthText_Enter);
			this.labelContentLengthText.Leave += new System.EventHandler(this.LabelContentLengthText_Leave);
			this.labelContentLengthText.MouseEnter += new System.EventHandler(this.LabelContentLengthText_Enter);
			// 
			// labelModifiedDateText
			// 
			this.labelModifiedDateText.AutoSize = true;
			this.labelModifiedDateText.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelModifiedDateText.Location = new System.Drawing.Point(3, 30);
			this.labelModifiedDateText.Name = "labelModifiedDateText";
			this.labelModifiedDateText.Size = new System.Drawing.Size(84, 15);
			this.labelModifiedDateText.TabIndex = 5;
			this.labelModifiedDateText.Text = "Modified date:";
			this.labelModifiedDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelModifiedDateText.Enter += new System.EventHandler(this.LabelModifiedDateText_Enter);
			this.labelModifiedDateText.Leave += new System.EventHandler(this.LabelModifiedDateText_Leave);
			this.labelModifiedDateText.MouseEnter += new System.EventHandler(this.LabelModifiedDateText_Enter);
			this.labelModifiedDateText.MouseLeave += new System.EventHandler(this.LabelModifiedDateText_Leave);
			// 
			// labelContentLengthValueLocal
			// 
			this.labelContentLengthValueLocal.AutoSize = true;
			this.labelContentLengthValueLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContentLengthValueLocal.Location = new System.Drawing.Point(142, 15);
			this.labelContentLengthValueLocal.Name = "labelContentLengthValueLocal";
			this.labelContentLengthValueLocal.Size = new System.Drawing.Size(134, 15);
			this.labelContentLengthValueLocal.TabIndex = 3;
			this.labelContentLengthValueLocal.Text = "123456789 bytes";
			this.labelContentLengthValueLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelContentLengthValueLocal.Enter += new System.EventHandler(this.LabelContentLengthValueLocal_Enter);
			this.labelContentLengthValueLocal.Leave += new System.EventHandler(this.LabelContentLengthValueLocal_Leave);
			this.labelContentLengthValueLocal.MouseEnter += new System.EventHandler(this.LabelContentLengthValueLocal_Enter);
			this.labelContentLengthValueLocal.MouseLeave += new System.EventHandler(this.LabelContentLengthText_Leave);
			// 
			// labelModifiedDateValueLocal
			// 
			this.labelModifiedDateValueLocal.AutoSize = true;
			this.labelModifiedDateValueLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifiedDateValueLocal.Location = new System.Drawing.Point(142, 30);
			this.labelModifiedDateValueLocal.Name = "labelModifiedDateValueLocal";
			this.labelModifiedDateValueLocal.Size = new System.Drawing.Size(134, 15);
			this.labelModifiedDateValueLocal.TabIndex = 6;
			this.labelModifiedDateValueLocal.Text = "00.00.0000 00:00";
			this.labelModifiedDateValueLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelModifiedDateValueLocal.Enter += new System.EventHandler(this.LabelModifiedDateValueLocal_Enter);
			this.labelModifiedDateValueLocal.Leave += new System.EventHandler(this.LabelModifiedDateValueLocal_Leave);
			this.labelModifiedDateValueLocal.MouseEnter += new System.EventHandler(this.LabelModifiedDateValueLocal_Enter);
			this.labelModifiedDateValueLocal.MouseLeave += new System.EventHandler(this.LabelModifiedDateValueLocal_Leave);
			// 
			// labelContentLengthValueOnline
			// 
			this.labelContentLengthValueOnline.AutoSize = true;
			this.labelContentLengthValueOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContentLengthValueOnline.Location = new System.Drawing.Point(282, 15);
			this.labelContentLengthValueOnline.Name = "labelContentLengthValueOnline";
			this.labelContentLengthValueOnline.Size = new System.Drawing.Size(135, 15);
			this.labelContentLengthValueOnline.TabIndex = 4;
			this.labelContentLengthValueOnline.Text = "123456789 bytes";
			this.labelContentLengthValueOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelContentLengthValueOnline.Enter += new System.EventHandler(this.LabelContentLengthValueOnline_Enter);
			this.labelContentLengthValueOnline.Leave += new System.EventHandler(this.LabelContentLengthValueOnline_Leave);
			this.labelContentLengthValueOnline.MouseEnter += new System.EventHandler(this.LabelContentLengthValueOnline_Enter);
			this.labelContentLengthValueOnline.MouseLeave += new System.EventHandler(this.LabelContentLengthValueOnline_Leave);
			// 
			// labelModifiedDateValueOnline
			// 
			this.labelModifiedDateValueOnline.AutoSize = true;
			this.labelModifiedDateValueOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifiedDateValueOnline.Location = new System.Drawing.Point(282, 30);
			this.labelModifiedDateValueOnline.Name = "labelModifiedDateValueOnline";
			this.labelModifiedDateValueOnline.Size = new System.Drawing.Size(135, 15);
			this.labelModifiedDateValueOnline.TabIndex = 7;
			this.labelModifiedDateValueOnline.Text = "00.00.0000 00:00";
			this.labelModifiedDateValueOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelModifiedDateValueOnline.Enter += new System.EventHandler(this.LabelModifiedDateValueOnline_Enter);
			this.labelModifiedDateValueOnline.Leave += new System.EventHandler(this.LabelModifiedDateValueOnline_Leave);
			this.labelModifiedDateValueOnline.MouseEnter += new System.EventHandler(this.LabelModifiedDateValueOnline_Enter);
			this.labelModifiedDateValueOnline.MouseLeave += new System.EventHandler(this.LabelModifiedDateValueOnline_Leave);
			// 
			// CheckMpcorbDatForm
			// 
			this.AccessibleDescription = "Show the informations about the MPCORB.DAT database local and online";
			this.AccessibleName = "MPCORB.DAT comparator";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 139);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CheckMpcorbDatForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MPCORB.DAT comparator";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckMpcorbDatForm_FormClosed);
			this.Load += new System.EventHandler(this.CheckMpcorbDatForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelHelp;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelIsUpdateNeeded;
		private System.Windows.Forms.Label labelMpcorbDatLocal;
		private System.Windows.Forms.Label labelMpcorbDatOnline;
		private System.Windows.Forms.Label labelContentLengthText;
		private System.Windows.Forms.Label labelModifiedDateText;
		private System.Windows.Forms.Label labelContentLengthValueLocal;
		private System.Windows.Forms.Label labelModifiedDateValueLocal;
		private System.Windows.Forms.Label labelContentLengthValueOnline;
		private System.Windows.Forms.Label labelModifiedDateValueOnline;
	}
}