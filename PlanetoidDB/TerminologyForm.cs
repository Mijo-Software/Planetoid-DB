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
		private bool
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

		#region local methods

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
		private void SetStatusbar(string text)
		{
			labelInformation.Enabled = text == "" ? false : true;
			labelInformation.Text = text;
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="label"></param>
		/// <param name="backColor"></param>
		/// <param name="foreColor"></param>
		private void SetBackAndForeColors(ref Label label, Color backColor, Color foreColor)
		{
			label.BackColor = backColor;
			label.ForeColor = foreColor;
		}

		#endregion

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public TerminologyForm() => InitializeComponent();

		#endregion

		#region Form* event handlers

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
		private void TerminologyForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				SetStatusbar(text: ((TextBox)sender).AccessibleDescription);
			}
			else if (sender is Button)
			{
				SetStatusbar(text: ((Button)sender).AccessibleDescription);
			}
			else if (sender is RadioButton)
			{
				SetStatusbar(text: ((RadioButton)sender).AccessibleDescription);
			}
			else if (sender is CheckBox)
			{
				SetStatusbar(text: ((CheckBox)sender).AccessibleDescription);
			}
			else if (sender is DateTimePicker)
			{
				SetStatusbar(text: ((DateTimePicker)sender).AccessibleDescription);
			}
			else if (sender is Label)
			{
				SetStatusbar(text: ((Label)sender).AccessibleDescription);
			}
			else if (sender is PictureBox)
			{
				SetStatusbar(text: ((PictureBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripButton)
			{
				SetStatusbar(text: ((ToolStripButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem)
			{
				SetStatusbar(text: ((ToolStripMenuItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripLabel)
			{
				SetStatusbar(text: ((ToolStripLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripComboBox)
			{
				SetStatusbar(text: ((ToolStripComboBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDown)
			{
				SetStatusbar(text: ((ToolStripDropDown)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton)
			{
				SetStatusbar(text: ((ToolStripDropDownButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem)
			{
				SetStatusbar(text: ((ToolStripDropDownItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu)
			{
				SetStatusbar(text: ((ToolStripDropDownMenu)sender).AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar)
			{
				SetStatusbar(text: ((ToolStripProgressBar)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton)
			{
				SetStatusbar(text: ((ToolStripSplitButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSeparator)
			{
				SetStatusbar(text: ((ToolStripSeparator)sender).AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel)
			{
				SetStatusbar(text: ((ToolStripStatusLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripTextBox)
			{
				SetStatusbar(text: ((ToolStripTextBox)sender).AccessibleDescription);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_Enter(object sender, EventArgs e)
		{
			if (!isLabelIndexActive)
			{
				SetBackAndForeColors(label: ref labelIndex, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelDesgnName, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelEpoch, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelMeanAnomaly, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelArgPeri, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelLongAscNode, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelIncl, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelOrbEcc, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelMotion, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar(text: labelMotion.AccessibleDescription);
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
				SetBackAndForeColors(label: ref labelSemiMajorAxis, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelMagAbs, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelSlopeParam, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelRef, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelNumbOppos, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelNumbObs, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelObsSpan, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelRmsResidual, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelComputerName, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelFlags, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
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
				SetBackAndForeColors(label: ref labelObsLastDate, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
			}
			SetStatusbar_Enter(sender: sender, e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Enter(object sender, EventArgs e) => SetStatusbar_Enter(sender: sender, e: e);

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
				SetBackAndForeColors(label: ref labelIndex, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelDesgnName, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelEpoch, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelMeanAnomaly, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelArgPeri, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelLongAscNode, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelIncl, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelOrbEcc, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelMotion, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelSemiMajorAxis, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelMagAbs, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelSlopeParam, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelRef, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelNumbOppos, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelNumbObs, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelObsSpan, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelRmsResidual, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelComputerName, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelFlags, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
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
				SetBackAndForeColors(label: ref labelObsLastDate, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
			}
			SetStatusbar(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Leave(object sender, EventArgs e) => SetStatusbar(text: "");

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
