using System;
using System.Drawing;
using System.Windows.Forms;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	public partial class TerminologyForm : Form
	{

		bool
			isLabelIndexActive = false,
			isLabelDesgnNameActive = false,
			isLabelEpochActive = false,
			isLabelMeanAnomalyActive = false,
			isLabelArgPeriActive = false,
			isLabelLongAscNodeActive = false,
			isLabelInclActive = false,
			isLabelOrbEccActive = false,
			isLabelMotionActive = false,
			isLabelSemiMajorAxisActive = false,
			isLabelMagAbsActive = false,
			isLabelSlopeParamActive = false,
			isLabelRefActive = false,
			isLabelNumbOpposActive = false,
			isLabelNumbObsActive = false,
			isLabelObsSpanActive = false,
			isLabelRmsResidualActive = false,
			isLabelComputerNameActive = false,
			isLabelFlagsActive = false,
			isLabelObsLastDateActive = false;

		#region Constructor und Form

		/// <summary>
		/// 
		/// </summary>
		public TerminologyForm() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TerminologyForm_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TerminologyForm_FormClosed(object sender, FormClosedEventArgs e) => this.Dispose();

		#endregion

		#region main functions

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelIndexActive(object sender, EventArgs e) => LabelIndex_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelDesgnNameActive(object sender, EventArgs e) => LabelDesgnName_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelEpochActive(object sender, EventArgs e) => LabelEpoch_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelMeanAnomalyActive(object sender, EventArgs e) => LabelMeanAnomaly_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelArgPeriActive(object sender, EventArgs e) => LabelArgPeri_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelLongAscNodeActive(object sender, EventArgs e) => LabelLongAscNode_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelInclActive(object sender, EventArgs e) => LabelIncl_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelOrbEccActive(object sender, EventArgs e) => LabelOrbEcc_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelMotionActive(object sender, EventArgs e) => LabelMotion_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelSemiMajorAxisActive(object sender, EventArgs e) => LabelSemiMajorAxis_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelMagAbsActive(object sender, EventArgs e) => LabelMagAbs_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelSlopeParamActive(object sender, EventArgs e) => LabelSlopeParam_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelRefActive(object sender, EventArgs e) => LabelRef_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelNumbOpposActive(object sender, EventArgs e) => LabelNumbOppos_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelNumbObsActive(object sender, EventArgs e) => LabelNumbObs_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelObsSpanActive(object sender, EventArgs e) => LabelObsSpan_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelRmsResidualActive(object sender, EventArgs e) => LabelRmsResidual_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelComputerNameActive(object sender, EventArgs e) => LabelComputerName_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelFlagsActive(object sender, EventArgs e) => LabelFlags_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SetLabelObsLastDateActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(text: I10nStrings.strCopiedToClipboard, caption: I10nStrings.strInformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetLabelText(string text)
		{
			labelHelp.Enabled = text == "" ? false : true;
			labelHelp.Text = text;
		}

		/// <summary>
		/// 
		/// </summary>
		private void DeselectAllFields()
		{
			isLabelIndexActive = false;
			isLabelDesgnNameActive = false;
			isLabelEpochActive = false;
			isLabelMeanAnomalyActive = false;
			isLabelArgPeriActive = false;
			isLabelLongAscNodeActive = false;
			isLabelInclActive = false;
			isLabelOrbEccActive = false;
			isLabelMotionActive = false;
			isLabelSemiMajorAxisActive = false;
			isLabelMagAbsActive = false;
			isLabelSlopeParamActive = false;
			isLabelRefActive = false;
			isLabelNumbOpposActive = false;
			isLabelNumbObsActive = false;
			isLabelObsSpanActive = false;
			isLabelRmsResidualActive = false;
			isLabelComputerNameActive = false;
			isLabelFlagsActive = false;
			isLabelObsLastDateActive = false;
			LabelIndex_Leave(sender: null, e: null);
			LabelDesgnName_Leave(sender: null, e: null);
			LabelEpoch_Leave(sender: null, e: null);
			LabelMeanAnomaly_Leave(sender: null, e: null);
			LabelArgPeri_Leave(sender: null, e: null);
			LabelLongAscNode_Leave(sender: null, e: null);
			LabelIncl_Leave(sender: null, e: null);
			LabelOrbEcc_Leave(sender: null, e: null);
			LabelMotion_Leave(sender: null, e: null);
			LabelSemiMajorAxis_Leave(sender: null, e: null);
			LabelMagAbs_Leave(sender: null, e: null);
			LabelSlopeParam_Leave(sender: null, e: null);
			LabelRef_Leave(sender: null, e: null);
			LabelNumbOppos_Leave(sender: null, e: null);
			LabelNumbObs_Leave(sender: null, e: null);
			LabelObsSpan_Leave(sender: null, e: null);
			LabelRmsResidual_Leave(sender: null, e: null);
			LabelComputerName_Leave(sender: null, e: null);
			LabelFlags_Leave(sender: null, e: null);
			LabelObsLastDate_Leave(sender: null, e: null);
		}

		#endregion

		#region Enter-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_Enter(object sender, EventArgs e)
		{
			if (!isLabelIndexActive)
			{
				labelIndex.BackColor = SystemColors.Highlight;
				labelIndex.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelIndex.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnName_Enter(object sender, EventArgs e)
		{
			if (!isLabelDesgnNameActive)
			{
				labelDesgnName.BackColor = SystemColors.Highlight;
				labelDesgnName.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelDesgnName.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpoch_Enter(object sender, EventArgs e)
		{
			if (!isLabelEpochActive)
			{
				labelEpoch.BackColor = SystemColors.Highlight;
				labelEpoch.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelEpoch.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomaly_Enter(object sender, EventArgs e)
		{
			if (!isLabelMeanAnomalyActive)
			{
				labelMeanAnomaly.BackColor = SystemColors.Highlight;
				labelMeanAnomaly.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelMeanAnomaly.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeri_Enter(object sender, EventArgs e)
		{
			if (!isLabelArgPeriActive)
			{
				labelArgPeri.BackColor = SystemColors.Highlight;
				labelArgPeri.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelArgPeri.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNode_Enter(object sender, EventArgs e)
		{
			if (!isLabelLongAscNodeActive)
			{
				labelLongAscNode.BackColor = SystemColors.Highlight;
				labelLongAscNode.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelLongAscNode.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_Enter(object sender, EventArgs e)
		{
			if (!isLabelInclActive)
			{
				labelIncl.BackColor = SystemColors.Highlight;
				labelIncl.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelIncl.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEcc_Enter(object sender, EventArgs e)
		{
			if (!isLabelOrbEccActive)
			{
				labelOrbEcc.BackColor = SystemColors.Highlight;
				labelOrbEcc.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelOrbEcc.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotion_Enter(object sender, EventArgs e)
		{
			if (!isLabelMotionActive)
			{
				labelMotion.BackColor = SystemColors.Highlight;
				labelMotion.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelMotion.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxis_Enter(object sender, EventArgs e)
		{
			if (!isLabelSemiMajorAxisActive)
			{
				labelSemiMajorAxis.BackColor = SystemColors.Highlight;
				labelSemiMajorAxis.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelSemiMajorAxis.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbs_Enter(object sender, EventArgs e)
		{
			if (!isLabelMagAbsActive)
			{
				labelMagAbs.BackColor = SystemColors.Highlight;
				labelMagAbs.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelMagAbs.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParam_Enter(object sender, EventArgs e)
		{
			if (!isLabelSlopeParamActive)
			{
				labelSlopeParam.BackColor = SystemColors.Highlight;
				labelSlopeParam.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelSlopeParam.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRef_Enter(object sender, EventArgs e)
		{
			if (!isLabelRefActive)
			{
				labelRef.BackColor = SystemColors.Highlight;
				labelRef.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelRef.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOppos_Enter(object sender, EventArgs e)
		{
			if (!isLabelNumbOpposActive)
			{
				labelNumbOppos.BackColor = SystemColors.Highlight;
				labelNumbOppos.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelNumbOppos.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObs_Enter(object sender, EventArgs e)
		{
			if (!isLabelNumbObsActive)
			{
				labelNumbObs.BackColor = SystemColors.Highlight;
				labelNumbObs.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelNumbObs.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpan_Enter(object sender, EventArgs e)
		{
			if (!isLabelObsSpanActive)
			{
				labelObsSpan.BackColor = SystemColors.Highlight;
				labelObsSpan.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelObsSpan.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_Enter(object sender, EventArgs e)
		{
			if (!isLabelRmsResidualActive)
			{
				labelRmsResidual.BackColor = SystemColors.Highlight;
				labelRmsResidual.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelRmsResidual.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerName_Enter(object sender, EventArgs e)
		{
			if (!isLabelComputerNameActive)
			{
				labelComputerName.BackColor = SystemColors.Highlight;
				labelComputerName.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelComputerName.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlags_Enter(object sender, EventArgs e)
		{
			if (!isLabelFlagsActive)
			{
				labelFlags.BackColor = SystemColors.Highlight;
				labelFlags.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelFlags.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDate_Enter(object sender, EventArgs e)
		{
			if (!isLabelObsLastDateActive)
			{
				labelObsLastDate.BackColor = SystemColors.Highlight;
				labelObsLastDate.ForeColor = SystemColors.HighlightText;
			}
			SetLabelText(text: labelObsLastDate.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Enter(object sender, EventArgs e) => SetLabelText(text: buttonOK.AccessibleDescription);

		#endregion

		#region Leave-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_Leave(object sender, EventArgs e)
		{
			if (!isLabelIndexActive)
			{
				labelIndex.BackColor = SystemColors.Control;
				labelIndex.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnName_Leave(object sender, EventArgs e)
		{
			if (!isLabelDesgnNameActive)
			{
				labelDesgnName.BackColor = SystemColors.Control;
				labelDesgnName.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpoch_Leave(object sender, EventArgs e)
		{
			if (!isLabelEpochActive)
			{
				labelEpoch.BackColor = SystemColors.Control;
				labelEpoch.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomaly_Leave(object sender, EventArgs e)
		{
			if (!isLabelMeanAnomalyActive)
			{
				labelMeanAnomaly.BackColor = SystemColors.Control;
				labelMeanAnomaly.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeri_Leave(object sender, EventArgs e)
		{
			if (!isLabelArgPeriActive)
			{
				labelArgPeri.BackColor = SystemColors.Control;
				labelArgPeri.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNode_Leave(object sender, EventArgs e)
		{
			if (!isLabelLongAscNodeActive)
			{
				labelLongAscNode.BackColor = SystemColors.Control;
				labelLongAscNode.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_Leave(object sender, EventArgs e)
		{
			if (!isLabelInclActive)
			{
				labelIncl.BackColor = SystemColors.Control;
				labelIncl.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEcc_Leave(object sender, EventArgs e)
		{
			if (!isLabelOrbEccActive)
			{
				labelOrbEcc.BackColor = SystemColors.Control;
				labelOrbEcc.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotion_Leave(object sender, EventArgs e)
		{
			if (!isLabelMotionActive)
			{
				labelMotion.BackColor = SystemColors.Control;
				labelMotion.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxis_Leave(object sender, EventArgs e)
		{
			if (!isLabelSemiMajorAxisActive)
			{
				labelSemiMajorAxis.BackColor = SystemColors.Control;
				labelSemiMajorAxis.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbs_Leave(object sender, EventArgs e)
		{
			if (!isLabelMagAbsActive)
			{
				labelMagAbs.BackColor = SystemColors.Control;
				labelMagAbs.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParam_Leave(object sender, EventArgs e)
		{
			if (!isLabelSlopeParamActive)
			{
				labelSlopeParam.BackColor = SystemColors.Control;
				labelSlopeParam.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRef_Leave(object sender, EventArgs e)
		{
			if (!isLabelRefActive)
			{
				labelRef.BackColor = SystemColors.Control;
				labelRef.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOppos_Leave(object sender, EventArgs e)
		{
			if (!isLabelNumbOpposActive)
			{
				labelNumbOppos.BackColor = SystemColors.Control;
				labelNumbOppos.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObs_Leave(object sender, EventArgs e)
		{
			if (!isLabelNumbObsActive)
			{
				labelNumbObs.BackColor = SystemColors.Control;
				labelNumbObs.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpan_Leave(object sender, EventArgs e)
		{
			if (!isLabelObsSpanActive)
			{
				labelObsSpan.BackColor = SystemColors.Control;
				labelObsSpan.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_Leave(object sender, EventArgs e)
		{
			if (!isLabelRmsResidualActive)
			{
				labelRmsResidual.BackColor = SystemColors.Control;
				labelRmsResidual.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerName_Leave(object sender, EventArgs e)
		{
			if (!isLabelComputerNameActive)
			{
				labelComputerName.BackColor = SystemColors.Control;
				labelComputerName.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlags_Leave(object sender, EventArgs e)
		{
			if (!isLabelFlagsActive)
			{
				labelFlags.BackColor = SystemColors.Control;
				labelFlags.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDate_Leave(object sender, EventArgs e)
		{
			if (!isLabelObsLastDateActive)
			{
				labelObsLastDate.BackColor = SystemColors.Control;
				labelObsLastDate.ForeColor = SystemColors.ControlText;
			}
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion

		#region Click-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelIndexActive = true;
			labelIndex.BackColor = SystemColors.ControlText;
			labelIndex.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_IndexNo;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnName_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelDesgnNameActive = true;
			labelDesgnName.BackColor = SystemColors.ControlText;
			labelDesgnName.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_DesgnName;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpoch_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelEpochActive = true;
			labelEpoch.BackColor = SystemColors.ControlText;
			labelEpoch.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_Epoch;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomaly_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelMeanAnomalyActive = true;
			labelMeanAnomaly.BackColor = SystemColors.ControlText;
			labelMeanAnomaly.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_MeanAnomaly;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeri_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelArgPeriActive = true;
			labelArgPeri.BackColor = SystemColors.ControlText;
			labelArgPeri.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_ArgPeri;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNode_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelLongAscNodeActive = true;
			labelLongAscNode.BackColor = SystemColors.ControlText;
			labelLongAscNode.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_LongAscNode;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelInclActive = true;
			labelIncl.BackColor = SystemColors.ControlText;
			labelIncl.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_Incl;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEcc_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelOrbEccActive = true;
			labelOrbEcc.BackColor = SystemColors.ControlText;
			labelOrbEcc.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_OrbEcc;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotion_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelMotionActive = true;
			labelMotion.BackColor = SystemColors.ControlText;
			labelMotion.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_Motion;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxis_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelSemiMajorAxisActive = true;
			labelSemiMajorAxis.BackColor = SystemColors.ControlText;
			labelSemiMajorAxis.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_SemiMajorAxis;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbs_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelMagAbsActive = true;
			labelMagAbs.BackColor = SystemColors.ControlText;
			labelMagAbs.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_MagAbs;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParam_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelSlopeParamActive = true;
			labelSlopeParam.BackColor = SystemColors.ControlText;
			labelSlopeParam.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_SlopeParam;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRef_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelRefActive = true;
			labelRef.BackColor = SystemColors.ControlText;
			labelRef.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_Ref;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOppos_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelNumbOpposActive = true;
			labelNumbOppos.BackColor = SystemColors.ControlText;
			labelNumbOppos.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_NumbOppos;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObs_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelNumbObsActive = true;
			labelNumbObs.BackColor = SystemColors.ControlText;
			labelNumbObs.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_NumbObs;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpan_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelObsSpanActive = true;
			labelObsSpan.BackColor = SystemColors.ControlText;
			labelObsSpan.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_ObsSpan;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelRmsResidualActive = true;
			labelRmsResidual.BackColor = SystemColors.ControlText;
			labelRmsResidual.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_RmsResidual;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerName_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelComputerNameActive = true;
			labelComputerName.BackColor = SystemColors.ControlText;
			labelComputerName.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_ComputerName;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlags_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelFlagsActive = true;
			labelFlags.BackColor = SystemColors.ControlText;
			labelFlags.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_Flags;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDate_Click(object sender, EventArgs e)
		{
			DeselectAllFields();
			isLabelObsLastDateActive = true;
			labelObsLastDate.BackColor = SystemColors.ControlText;
			labelObsLastDate.ForeColor = SystemColors.Control;
			webBrowser.DocumentText = I10nStrings.terminology_ObsLastDate;
		}

		#endregion
	}
}
