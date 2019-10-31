namespace Planetoid_DB
{
	partial class TerminologyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminologyForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelIndex = new System.Windows.Forms.Label();
			this.labelDesgnName = new System.Windows.Forms.Label();
			this.labelEpoch = new System.Windows.Forms.Label();
			this.labelMeanAnomaly = new System.Windows.Forms.Label();
			this.labelArgPeri = new System.Windows.Forms.Label();
			this.labelLongAscNode = new System.Windows.Forms.Label();
			this.labelIncl = new System.Windows.Forms.Label();
			this.labelOrbEcc = new System.Windows.Forms.Label();
			this.labelMotion = new System.Windows.Forms.Label();
			this.labelSemiMajorAxis = new System.Windows.Forms.Label();
			this.labelMagAbs = new System.Windows.Forms.Label();
			this.labelSlopeParam = new System.Windows.Forms.Label();
			this.labelRef = new System.Windows.Forms.Label();
			this.labelNumbOppos = new System.Windows.Forms.Label();
			this.labelNumbObs = new System.Windows.Forms.Label();
			this.labelObsSpan = new System.Windows.Forms.Label();
			this.labelRmsResidual = new System.Windows.Forms.Label();
			this.labelComputerName = new System.Windows.Forms.Label();
			this.labelFlags = new System.Windows.Forms.Label();
			this.labelObsLastDate = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.statusStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelIndex
			// 
			this.labelIndex.AccessibleDescription = "Index No.";
			this.labelIndex.AccessibleName = "Index No.";
			this.labelIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelIndex.AutoSize = true;
			this.labelIndex.BackColor = System.Drawing.Color.Transparent;
			this.labelIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIndex.Location = new System.Drawing.Point(3, 0);
			this.labelIndex.Name = "labelIndex";
			this.labelIndex.Padding = new System.Windows.Forms.Padding(3);
			this.labelIndex.Size = new System.Drawing.Size(250, 21);
			this.labelIndex.TabIndex = 0;
			this.labelIndex.Text = "Index No.";
			this.labelIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelIndex, "Index No.");
			this.labelIndex.Click += new System.EventHandler(this.LabelIndex_Click);
			this.labelIndex.Enter += new System.EventHandler(this.LabelIndex_Enter);
			this.labelIndex.Leave += new System.EventHandler(this.LabelIndex_Leave);
			this.labelIndex.MouseEnter += new System.EventHandler(this.LabelIndex_Enter);
			this.labelIndex.MouseLeave += new System.EventHandler(this.LabelIndex_Leave);
			// 
			// labelDesgnName
			// 
			this.labelDesgnName.AccessibleDescription = "Readable designation";
			this.labelDesgnName.AccessibleName = "Readable designation";
			this.labelDesgnName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelDesgnName.AutoSize = true;
			this.labelDesgnName.BackColor = System.Drawing.Color.Transparent;
			this.labelDesgnName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDesgnName.Location = new System.Drawing.Point(3, 21);
			this.labelDesgnName.Name = "labelDesgnName";
			this.labelDesgnName.Padding = new System.Windows.Forms.Padding(3);
			this.labelDesgnName.Size = new System.Drawing.Size(250, 21);
			this.labelDesgnName.TabIndex = 1;
			this.labelDesgnName.Text = "Readable designation";
			this.labelDesgnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelDesgnName, "Readable designation");
			this.labelDesgnName.Click += new System.EventHandler(this.LabelDesgnName_Click);
			this.labelDesgnName.Enter += new System.EventHandler(this.LabelDesgnName_Enter);
			this.labelDesgnName.Leave += new System.EventHandler(this.LabelDesgnName_Leave);
			this.labelDesgnName.MouseEnter += new System.EventHandler(this.LabelDesgnName_Enter);
			this.labelDesgnName.MouseLeave += new System.EventHandler(this.LabelDesgnName_Leave);
			// 
			// labelEpoch
			// 
			this.labelEpoch.AccessibleDescription = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.AccessibleName = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelEpoch.AutoSize = true;
			this.labelEpoch.BackColor = System.Drawing.Color.Transparent;
			this.labelEpoch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEpoch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelEpoch.Location = new System.Drawing.Point(3, 42);
			this.labelEpoch.Name = "labelEpoch";
			this.labelEpoch.Padding = new System.Windows.Forms.Padding(3);
			this.labelEpoch.Size = new System.Drawing.Size(250, 21);
			this.labelEpoch.TabIndex = 2;
			this.labelEpoch.Text = "Epoch (in packed form, .0 TT)";
			this.labelEpoch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelEpoch, "Epoch (in packed form, .0 TT)");
			this.labelEpoch.Click += new System.EventHandler(this.LabelEpoch_Click);
			this.labelEpoch.Enter += new System.EventHandler(this.LabelEpoch_Enter);
			this.labelEpoch.Leave += new System.EventHandler(this.LabelEpoch_Leave);
			this.labelEpoch.MouseEnter += new System.EventHandler(this.LabelEpoch_Enter);
			this.labelEpoch.MouseLeave += new System.EventHandler(this.LabelEpoch_Leave);
			// 
			// labelMeanAnomaly
			// 
			this.labelMeanAnomaly.AccessibleDescription = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.AccessibleName = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMeanAnomaly.AutoSize = true;
			this.labelMeanAnomaly.BackColor = System.Drawing.Color.Transparent;
			this.labelMeanAnomaly.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeanAnomaly.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMeanAnomaly.Location = new System.Drawing.Point(3, 63);
			this.labelMeanAnomaly.Name = "labelMeanAnomaly";
			this.labelMeanAnomaly.Padding = new System.Windows.Forms.Padding(3);
			this.labelMeanAnomaly.Size = new System.Drawing.Size(250, 21);
			this.labelMeanAnomaly.TabIndex = 3;
			this.labelMeanAnomaly.Text = "Mean anomaly at the epoch, in degrees";
			this.labelMeanAnomaly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMeanAnomaly, "Mean anomaly at the epoch, in degrees");
			this.labelMeanAnomaly.Click += new System.EventHandler(this.LabelMeanAnomaly_Click);
			this.labelMeanAnomaly.Enter += new System.EventHandler(this.LabelMeanAnomaly_Enter);
			this.labelMeanAnomaly.Leave += new System.EventHandler(this.LabelMeanAnomaly_Leave);
			this.labelMeanAnomaly.MouseEnter += new System.EventHandler(this.LabelMeanAnomaly_Enter);
			this.labelMeanAnomaly.MouseLeave += new System.EventHandler(this.LabelMeanAnomaly_Leave);
			// 
			// labelArgPeri
			// 
			this.labelArgPeri.AccessibleDescription = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.AccessibleName = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelArgPeri.AutoSize = true;
			this.labelArgPeri.BackColor = System.Drawing.Color.Transparent;
			this.labelArgPeri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArgPeri.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelArgPeri.Location = new System.Drawing.Point(3, 84);
			this.labelArgPeri.Name = "labelArgPeri";
			this.labelArgPeri.Padding = new System.Windows.Forms.Padding(3);
			this.labelArgPeri.Size = new System.Drawing.Size(250, 21);
			this.labelArgPeri.TabIndex = 4;
			this.labelArgPeri.Text = "Argument of perihelion, J2000.0 (degrees)";
			this.labelArgPeri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelArgPeri, "Argument of perihelion, J2000.0 (degrees)");
			this.labelArgPeri.Click += new System.EventHandler(this.LabelArgPeri_Click);
			this.labelArgPeri.Enter += new System.EventHandler(this.LabelArgPeri_Enter);
			this.labelArgPeri.Leave += new System.EventHandler(this.LabelArgPeri_Leave);
			this.labelArgPeri.MouseEnter += new System.EventHandler(this.LabelArgPeri_Enter);
			this.labelArgPeri.MouseLeave += new System.EventHandler(this.LabelArgPeri_Leave);
			// 
			// labelLongAscNode
			// 
			this.labelLongAscNode.AccessibleDescription = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.AccessibleName = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelLongAscNode.AutoSize = true;
			this.labelLongAscNode.BackColor = System.Drawing.Color.Transparent;
			this.labelLongAscNode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLongAscNode.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelLongAscNode.Location = new System.Drawing.Point(3, 105);
			this.labelLongAscNode.Name = "labelLongAscNode";
			this.labelLongAscNode.Padding = new System.Windows.Forms.Padding(3);
			this.labelLongAscNode.Size = new System.Drawing.Size(250, 21);
			this.labelLongAscNode.TabIndex = 5;
			this.labelLongAscNode.Text = "Longitude of the ascending node, J2000.0";
			this.labelLongAscNode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelLongAscNode, "Longitude of the ascending node, J2000.0");
			this.labelLongAscNode.Click += new System.EventHandler(this.LabelLongAscNode_Click);
			this.labelLongAscNode.Enter += new System.EventHandler(this.LabelLongAscNode_Enter);
			this.labelLongAscNode.Leave += new System.EventHandler(this.LabelLongAscNode_Leave);
			this.labelLongAscNode.MouseEnter += new System.EventHandler(this.LabelLongAscNode_Enter);
			this.labelLongAscNode.MouseLeave += new System.EventHandler(this.LabelLongAscNode_Leave);
			// 
			// labelIncl
			// 
			this.labelIncl.AccessibleDescription = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.AccessibleName = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelIncl.AutoSize = true;
			this.labelIncl.BackColor = System.Drawing.Color.Transparent;
			this.labelIncl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIncl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelIncl.Location = new System.Drawing.Point(3, 126);
			this.labelIncl.Name = "labelIncl";
			this.labelIncl.Padding = new System.Windows.Forms.Padding(3);
			this.labelIncl.Size = new System.Drawing.Size(250, 21);
			this.labelIncl.TabIndex = 6;
			this.labelIncl.Text = "Inclination to the ecliptic, J2000.0 (degrees)";
			this.labelIncl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelIncl, "Inclination to the ecliptic, J2000.0 (degrees)");
			this.labelIncl.Click += new System.EventHandler(this.LabelIncl_Click);
			this.labelIncl.Enter += new System.EventHandler(this.LabelIncl_Enter);
			this.labelIncl.Leave += new System.EventHandler(this.LabelIncl_Leave);
			this.labelIncl.MouseEnter += new System.EventHandler(this.LabelIncl_Enter);
			this.labelIncl.MouseLeave += new System.EventHandler(this.LabelIncl_Leave);
			// 
			// labelOrbEcc
			// 
			this.labelOrbEcc.AccessibleDescription = "Orbital eccentricity";
			this.labelOrbEcc.AccessibleName = "Orbital eccentricity";
			this.labelOrbEcc.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelOrbEcc.AutoSize = true;
			this.labelOrbEcc.BackColor = System.Drawing.Color.Transparent;
			this.labelOrbEcc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelOrbEcc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelOrbEcc.Location = new System.Drawing.Point(3, 147);
			this.labelOrbEcc.Name = "labelOrbEcc";
			this.labelOrbEcc.Padding = new System.Windows.Forms.Padding(3);
			this.labelOrbEcc.Size = new System.Drawing.Size(250, 21);
			this.labelOrbEcc.TabIndex = 7;
			this.labelOrbEcc.Text = "Orbital eccentricity";
			this.labelOrbEcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelOrbEcc, "Orbital eccentricity");
			this.labelOrbEcc.Click += new System.EventHandler(this.LabelOrbEcc_Click);
			this.labelOrbEcc.Enter += new System.EventHandler(this.LabelOrbEcc_Enter);
			this.labelOrbEcc.Leave += new System.EventHandler(this.LabelOrbEcc_Leave);
			this.labelOrbEcc.MouseEnter += new System.EventHandler(this.LabelOrbEcc_Enter);
			this.labelOrbEcc.MouseLeave += new System.EventHandler(this.LabelOrbEcc_Leave);
			// 
			// labelMotion
			// 
			this.labelMotion.AccessibleDescription = "Mean daily motion (degrees per day)";
			this.labelMotion.AccessibleName = "Mean daily motion (degrees per day)";
			this.labelMotion.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMotion.AutoSize = true;
			this.labelMotion.BackColor = System.Drawing.Color.Transparent;
			this.labelMotion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMotion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMotion.Location = new System.Drawing.Point(3, 168);
			this.labelMotion.Name = "labelMotion";
			this.labelMotion.Padding = new System.Windows.Forms.Padding(3);
			this.labelMotion.Size = new System.Drawing.Size(250, 21);
			this.labelMotion.TabIndex = 8;
			this.labelMotion.Text = "Mean daily motion (degrees per day)";
			this.labelMotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMotion, "Mean daily motion (degrees per day)");
			this.labelMotion.Click += new System.EventHandler(this.LabelMotion_Click);
			this.labelMotion.Enter += new System.EventHandler(this.LabelMotion_Enter);
			this.labelMotion.Leave += new System.EventHandler(this.LabelMotion_Leave);
			this.labelMotion.MouseEnter += new System.EventHandler(this.LabelMotion_Enter);
			this.labelMotion.MouseLeave += new System.EventHandler(this.LabelMotion_Leave);
			// 
			// labelSemiMajorAxis
			// 
			this.labelSemiMajorAxis.AccessibleDescription = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.AccessibleName = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSemiMajorAxis.AutoSize = true;
			this.labelSemiMajorAxis.BackColor = System.Drawing.Color.Transparent;
			this.labelSemiMajorAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSemiMajorAxis.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelSemiMajorAxis.Location = new System.Drawing.Point(3, 189);
			this.labelSemiMajorAxis.Name = "labelSemiMajorAxis";
			this.labelSemiMajorAxis.Padding = new System.Windows.Forms.Padding(3);
			this.labelSemiMajorAxis.Size = new System.Drawing.Size(250, 21);
			this.labelSemiMajorAxis.TabIndex = 9;
			this.labelSemiMajorAxis.Text = "Semimajor axis (AU)";
			this.labelSemiMajorAxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSemiMajorAxis, "Semimajor axis (AU)");
			this.labelSemiMajorAxis.Click += new System.EventHandler(this.LabelSemiMajorAxis_Click);
			this.labelSemiMajorAxis.Enter += new System.EventHandler(this.LabelSemiMajorAxis_Enter);
			this.labelSemiMajorAxis.Leave += new System.EventHandler(this.LabelSemiMajorAxis_Leave);
			this.labelSemiMajorAxis.MouseEnter += new System.EventHandler(this.LabelSemiMajorAxis_Enter);
			this.labelSemiMajorAxis.MouseLeave += new System.EventHandler(this.LabelSemiMajorAxis_Leave);
			// 
			// labelMagAbs
			// 
			this.labelMagAbs.AccessibleDescription = "Absolute magnitude, H";
			this.labelMagAbs.AccessibleName = "Absolute magnitude, H";
			this.labelMagAbs.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelMagAbs.AutoSize = true;
			this.labelMagAbs.BackColor = System.Drawing.Color.Transparent;
			this.labelMagAbs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMagAbs.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.labelMagAbs.Location = new System.Drawing.Point(3, 210);
			this.labelMagAbs.Name = "labelMagAbs";
			this.labelMagAbs.Padding = new System.Windows.Forms.Padding(3);
			this.labelMagAbs.Size = new System.Drawing.Size(250, 21);
			this.labelMagAbs.TabIndex = 10;
			this.labelMagAbs.Text = "Absolute magnitude, H";
			this.labelMagAbs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelMagAbs, "Absolute magnitude, H");
			this.labelMagAbs.Click += new System.EventHandler(this.LabelMagAbs_Click);
			this.labelMagAbs.Enter += new System.EventHandler(this.LabelMagAbs_Enter);
			this.labelMagAbs.Leave += new System.EventHandler(this.LabelMagAbs_Leave);
			this.labelMagAbs.MouseEnter += new System.EventHandler(this.LabelMagAbs_Enter);
			this.labelMagAbs.MouseLeave += new System.EventHandler(this.LabelMagAbs_Leave);
			// 
			// labelSlopeParam
			// 
			this.labelSlopeParam.AccessibleDescription = "Slope parameter, G";
			this.labelSlopeParam.AccessibleName = "Slope parameter, G";
			this.labelSlopeParam.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelSlopeParam.AutoSize = true;
			this.labelSlopeParam.BackColor = System.Drawing.Color.Transparent;
			this.labelSlopeParam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSlopeParam.Location = new System.Drawing.Point(3, 231);
			this.labelSlopeParam.Name = "labelSlopeParam";
			this.labelSlopeParam.Padding = new System.Windows.Forms.Padding(3);
			this.labelSlopeParam.Size = new System.Drawing.Size(250, 21);
			this.labelSlopeParam.TabIndex = 11;
			this.labelSlopeParam.Text = "Slope parameter, G";
			this.labelSlopeParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSlopeParam, "Slope parameter, G");
			this.labelSlopeParam.Click += new System.EventHandler(this.LabelSlopeParam_Click);
			this.labelSlopeParam.Enter += new System.EventHandler(this.LabelSlopeParam_Enter);
			this.labelSlopeParam.Leave += new System.EventHandler(this.LabelSlopeParam_Leave);
			this.labelSlopeParam.MouseEnter += new System.EventHandler(this.LabelSlopeParam_Enter);
			this.labelSlopeParam.MouseLeave += new System.EventHandler(this.LabelSlopeParam_Leave);
			// 
			// labelRef
			// 
			this.labelRef.AccessibleDescription = "Reference";
			this.labelRef.AccessibleName = "Reference";
			this.labelRef.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRef.AutoSize = true;
			this.labelRef.BackColor = System.Drawing.Color.Transparent;
			this.labelRef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRef.Location = new System.Drawing.Point(3, 252);
			this.labelRef.Name = "labelRef";
			this.labelRef.Padding = new System.Windows.Forms.Padding(3);
			this.labelRef.Size = new System.Drawing.Size(250, 21);
			this.labelRef.TabIndex = 12;
			this.labelRef.Text = "Reference";
			this.labelRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelRef, "Reference");
			this.labelRef.Click += new System.EventHandler(this.LabelRef_Click);
			this.labelRef.Enter += new System.EventHandler(this.LabelRef_Enter);
			this.labelRef.Leave += new System.EventHandler(this.LabelRef_Leave);
			this.labelRef.MouseEnter += new System.EventHandler(this.LabelRef_Enter);
			this.labelRef.MouseLeave += new System.EventHandler(this.LabelRef_Leave);
			// 
			// labelNumbOppos
			// 
			this.labelNumbOppos.AccessibleDescription = "Number of oppositions";
			this.labelNumbOppos.AccessibleName = "Number of oppositions";
			this.labelNumbOppos.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNumbOppos.AutoSize = true;
			this.labelNumbOppos.BackColor = System.Drawing.Color.Transparent;
			this.labelNumbOppos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumbOppos.Location = new System.Drawing.Point(3, 273);
			this.labelNumbOppos.Name = "labelNumbOppos";
			this.labelNumbOppos.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbOppos.Size = new System.Drawing.Size(250, 21);
			this.labelNumbOppos.TabIndex = 13;
			this.labelNumbOppos.Text = "Number of oppositions";
			this.labelNumbOppos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelNumbOppos, "Number of oppositions");
			this.labelNumbOppos.Click += new System.EventHandler(this.LabelNumbOppos_Click);
			this.labelNumbOppos.Enter += new System.EventHandler(this.LabelNumbOppos_Enter);
			this.labelNumbOppos.Leave += new System.EventHandler(this.LabelNumbOppos_Leave);
			this.labelNumbOppos.MouseEnter += new System.EventHandler(this.LabelNumbOppos_Enter);
			this.labelNumbOppos.MouseLeave += new System.EventHandler(this.LabelNumbOppos_Leave);
			// 
			// labelNumbObs
			// 
			this.labelNumbObs.AccessibleDescription = "Number of observations";
			this.labelNumbObs.AccessibleName = "Number of observations";
			this.labelNumbObs.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelNumbObs.AutoSize = true;
			this.labelNumbObs.BackColor = System.Drawing.Color.Transparent;
			this.labelNumbObs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumbObs.Location = new System.Drawing.Point(3, 294);
			this.labelNumbObs.Name = "labelNumbObs";
			this.labelNumbObs.Padding = new System.Windows.Forms.Padding(3);
			this.labelNumbObs.Size = new System.Drawing.Size(250, 21);
			this.labelNumbObs.TabIndex = 14;
			this.labelNumbObs.Text = "Number of observations";
			this.labelNumbObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelNumbObs, "Number of observations");
			this.labelNumbObs.Click += new System.EventHandler(this.LabelNumbObs_Click);
			this.labelNumbObs.Enter += new System.EventHandler(this.LabelNumbObs_Enter);
			this.labelNumbObs.Leave += new System.EventHandler(this.LabelNumbObs_Leave);
			this.labelNumbObs.MouseEnter += new System.EventHandler(this.LabelNumbObs_Enter);
			this.labelNumbObs.MouseLeave += new System.EventHandler(this.LabelNumbObs_Leave);
			// 
			// labelObsSpan
			// 
			this.labelObsSpan.AccessibleDescription = "Observation span";
			this.labelObsSpan.AccessibleName = "Observation span";
			this.labelObsSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelObsSpan.AutoSize = true;
			this.labelObsSpan.BackColor = System.Drawing.Color.Transparent;
			this.labelObsSpan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelObsSpan.Location = new System.Drawing.Point(3, 315);
			this.labelObsSpan.Name = "labelObsSpan";
			this.labelObsSpan.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsSpan.Size = new System.Drawing.Size(250, 21);
			this.labelObsSpan.TabIndex = 15;
			this.labelObsSpan.Text = "Observation span";
			this.labelObsSpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelObsSpan, "Observation span");
			this.labelObsSpan.Click += new System.EventHandler(this.LabelObsSpan_Click);
			this.labelObsSpan.Enter += new System.EventHandler(this.LabelObsSpan_Enter);
			this.labelObsSpan.Leave += new System.EventHandler(this.LabelObsSpan_Leave);
			this.labelObsSpan.MouseEnter += new System.EventHandler(this.LabelObsSpan_Enter);
			this.labelObsSpan.MouseLeave += new System.EventHandler(this.LabelObsSpan_Leave);
			// 
			// labelRmsResidual
			// 
			this.labelRmsResidual.AccessibleDescription = "r.m.s. residual (\")";
			this.labelRmsResidual.AccessibleName = "r.m.s. residual (\")";
			this.labelRmsResidual.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelRmsResidual.AutoSize = true;
			this.labelRmsResidual.BackColor = System.Drawing.Color.Transparent;
			this.labelRmsResidual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRmsResidual.Location = new System.Drawing.Point(3, 336);
			this.labelRmsResidual.Name = "labelRmsResidual";
			this.labelRmsResidual.Padding = new System.Windows.Forms.Padding(3);
			this.labelRmsResidual.Size = new System.Drawing.Size(250, 21);
			this.labelRmsResidual.TabIndex = 16;
			this.labelRmsResidual.Text = "r.m.s. residual (\")";
			this.labelRmsResidual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelRmsResidual, "r.m.s residual (\")");
			this.labelRmsResidual.Click += new System.EventHandler(this.LabelRmsResidual_Click);
			this.labelRmsResidual.Enter += new System.EventHandler(this.LabelRmsResidual_Enter);
			this.labelRmsResidual.Leave += new System.EventHandler(this.LabelRmsResidual_Leave);
			this.labelRmsResidual.MouseEnter += new System.EventHandler(this.LabelRmsResidual_Enter);
			this.labelRmsResidual.MouseLeave += new System.EventHandler(this.LabelRmsResidual_Leave);
			// 
			// labelComputerName
			// 
			this.labelComputerName.AccessibleDescription = "Computer name";
			this.labelComputerName.AccessibleName = "Computer name";
			this.labelComputerName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelComputerName.AutoSize = true;
			this.labelComputerName.BackColor = System.Drawing.Color.Transparent;
			this.labelComputerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComputerName.Location = new System.Drawing.Point(3, 357);
			this.labelComputerName.Name = "labelComputerName";
			this.labelComputerName.Padding = new System.Windows.Forms.Padding(3);
			this.labelComputerName.Size = new System.Drawing.Size(250, 21);
			this.labelComputerName.TabIndex = 17;
			this.labelComputerName.Text = "Computer name";
			this.labelComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelComputerName, "Computer name");
			this.labelComputerName.Click += new System.EventHandler(this.LabelComputerName_Click);
			this.labelComputerName.Enter += new System.EventHandler(this.LabelComputerName_Enter);
			this.labelComputerName.Leave += new System.EventHandler(this.LabelComputerName_Leave);
			this.labelComputerName.MouseEnter += new System.EventHandler(this.LabelComputerName_Enter);
			this.labelComputerName.MouseLeave += new System.EventHandler(this.LabelComputerName_Leave);
			// 
			// labelFlags
			// 
			this.labelFlags.AccessibleDescription = "4-hexdigit flags";
			this.labelFlags.AccessibleName = "4-hexdigit flags";
			this.labelFlags.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelFlags.AutoSize = true;
			this.labelFlags.BackColor = System.Drawing.Color.Transparent;
			this.labelFlags.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFlags.Location = new System.Drawing.Point(3, 378);
			this.labelFlags.Name = "labelFlags";
			this.labelFlags.Padding = new System.Windows.Forms.Padding(3);
			this.labelFlags.Size = new System.Drawing.Size(250, 21);
			this.labelFlags.TabIndex = 18;
			this.labelFlags.Text = "4-hexdigit flags";
			this.labelFlags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelFlags, "4-hexdigit flags");
			this.labelFlags.Click += new System.EventHandler(this.LabelFlags_Click);
			this.labelFlags.Enter += new System.EventHandler(this.LabelFlags_Enter);
			this.labelFlags.Leave += new System.EventHandler(this.LabelFlags_Leave);
			this.labelFlags.MouseEnter += new System.EventHandler(this.LabelFlags_Enter);
			this.labelFlags.MouseLeave += new System.EventHandler(this.LabelFlags_Leave);
			// 
			// labelObsLastDate
			// 
			this.labelObsLastDate.AccessibleDescription = "Date of last observation";
			this.labelObsLastDate.AccessibleName = "Date of last observation";
			this.labelObsLastDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.labelObsLastDate.AutoSize = true;
			this.labelObsLastDate.BackColor = System.Drawing.Color.Transparent;
			this.labelObsLastDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelObsLastDate.Location = new System.Drawing.Point(3, 399);
			this.labelObsLastDate.Name = "labelObsLastDate";
			this.labelObsLastDate.Padding = new System.Windows.Forms.Padding(3);
			this.labelObsLastDate.Size = new System.Drawing.Size(250, 22);
			this.labelObsLastDate.TabIndex = 19;
			this.labelObsLastDate.Text = "Date of last observation";
			this.labelObsLastDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelObsLastDate, "Date of last observation");
			this.labelObsLastDate.Click += new System.EventHandler(this.LabelObsLastDate_Click);
			this.labelObsLastDate.Enter += new System.EventHandler(this.LabelObsLastDate_Enter);
			this.labelObsLastDate.Leave += new System.EventHandler(this.LabelObsLastDate_Leave);
			this.labelObsLastDate.MouseEnter += new System.EventHandler(this.LabelObsLastDate_Enter);
			this.labelObsLastDate.MouseLeave += new System.EventHandler(this.LabelObsLastDate_Leave);
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = "Close the application form";
			this.buttonOK.AccessibleName = "Okay";
			this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.buttonOK.Image = global::Planetoid_DB.Properties.Resources.silk_tick;
			this.buttonOK.Location = new System.Drawing.Point(3, 380);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(305, 40);
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
			this.buttonOK.MouseLeave += new System.EventHandler(this.ButtonOK_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the status";
			this.statusStrip.AccessibleName = "Status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip.Location = new System.Drawing.Point(0, 429);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(576, 21);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 1;
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.labelObsLastDate, 0, 19);
			this.tableLayoutPanel1.Controls.Add(this.labelIndex, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelDesgnName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelEpoch, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelMeanAnomaly, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelLongAscNode, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelArgPeri, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelMotion, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelIncl, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelSlopeParam, 0, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelOrbEcc, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelSemiMajorAxis, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelNumbOppos, 0, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelMagAbs, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelRef, 0, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelRmsResidual, 0, 16);
			this.tableLayoutPanel1.Controls.Add(this.labelNumbObs, 0, 14);
			this.tableLayoutPanel1.Controls.Add(this.labelFlags, 0, 18);
			this.tableLayoutPanel1.Controls.Add(this.labelObsSpan, 0, 15);
			this.tableLayoutPanel1.Controls.Add(this.labelComputerName, 0, 17);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 20;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 421);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 429);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.buttonOK, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.webBrowser, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(265, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.1253F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8747F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(311, 423);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// webBrowser
			// 
			this.webBrowser.AccessibleDescription = "Inform about some definitions";
			this.webBrowser.AccessibleName = "Webbrowser";
			this.webBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser.Location = new System.Drawing.Point(3, 3);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(305, 371);
			this.webBrowser.TabIndex = 0;
			// 
			// TerminologyForm
			// 
			this.AccessibleDescription = "Inform about some definitions";
			this.AccessibleName = "Terminology";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 450);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TerminologyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Terminology";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerminologyForm_FormClosed);
			this.Load += new System.EventHandler(this.TerminologyForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.Label labelIndex;
		private System.Windows.Forms.Label labelDesgnName;
		private System.Windows.Forms.Label labelEpoch;
		private System.Windows.Forms.Label labelMeanAnomaly;
		private System.Windows.Forms.Label labelArgPeri;
		private System.Windows.Forms.Label labelLongAscNode;
		private System.Windows.Forms.Label labelIncl;
		private System.Windows.Forms.Label labelOrbEcc;
		private System.Windows.Forms.Label labelMotion;
		private System.Windows.Forms.Label labelSemiMajorAxis;
		private System.Windows.Forms.Label labelMagAbs;
		private System.Windows.Forms.Label labelSlopeParam;
		private System.Windows.Forms.Label labelRef;
		private System.Windows.Forms.Label labelNumbOppos;
		private System.Windows.Forms.Label labelNumbObs;
		private System.Windows.Forms.Label labelObsSpan;
		private System.Windows.Forms.Label labelRmsResidual;
		private System.Windows.Forms.Label labelComputerName;
		private System.Windows.Forms.Label labelFlags;
		private System.Windows.Forms.Label labelObsLastDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.WebBrowser webBrowser;
	}
}