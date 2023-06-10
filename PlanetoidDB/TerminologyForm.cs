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
            isLabelObsLastDateActive = false,
            isLabelLinearEccentricityActive = false,
            isLabelSemiMinorAxisActive = false,
            isLabelMajorAxisActive = false,
            isLabelMinorAxisActive = false,
            isLabelEccenctricAnomalyActive = false,
            isLabelTrueAnomalyActive = false,
            isLabelPerihelionDistanceActive = false,
            isLabelAphelionDistanceActive = false,
            isLabelLongitudeDescendingNodeActive = false,
            isLabelArgumentAphelionActive = false,
            isLabelFocalParameterActive = false,
            isLabelSemiLatusRectumActive = false,
            isLabelLatusRectumActive = false,
            isLabelPeriodActive = false,
            isLabelOrbitalAreaActive = false,
            isLabelOrbitalPerimeterActive = false,
            isLabelSemiMeanAxisActive = false,
            isLabelMeanAxisActive = false,
            isLabelStandardGravitationalParameterActive = false;

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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelLinearEccentricityActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelSemiMinorAxisActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelMajorAxisActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelMinorAxisActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelEccenctricAnomalyActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelTrueAnomalyActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelPerihelionDistanceActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelAphelionDistanceActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelLongitudeDescendingNodeActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelArgumentAphelionActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelFocalParameterActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelSemiLatusRectumActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelLatusRectumActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelPeriodActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelOrbitalAreaActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelOrbitalPerimeterActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelSemiMeanAxisActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelMeanAxisActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetLabelStandardGravitationalParameterActive(object sender, EventArgs e) => LabelObsLastDate_Click(sender: sender, e: e);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        private void SetStatusbar(string text)
        {
            if (!string.IsNullOrEmpty(value: text))
            {
                labelInformation.Enabled = true;
                labelInformation.Text = text;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ClearStatusbar()
        {
            labelInformation.Enabled = false;
            labelInformation.Text = string.Empty;
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
            isLabelLinearEccentricityActive = false;
            isLabelSemiMinorAxisActive = false;
            isLabelMajorAxisActive = false;
            isLabelMinorAxisActive = false;
            isLabelEccenctricAnomalyActive = false;
            isLabelTrueAnomalyActive = false;
            isLabelPerihelionDistanceActive = false;
            isLabelAphelionDistanceActive = false;
            isLabelLongitudeDescendingNodeActive = false;
            isLabelArgumentAphelionActive = false;
            isLabelFocalParameterActive = false;
            isLabelSemiLatusRectumActive = false;
            isLabelLatusRectumActive = false;
            isLabelPeriodActive = false;
            isLabelOrbitalAreaActive = false;
            isLabelOrbitalPerimeterActive = false;
            isLabelSemiMeanAxisActive = false;
            isLabelMeanAxisActive = false;
            isLabelStandardGravitationalParameterActive = false;
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
            LabelLinearEccentricity_Leave(sender: null, e: null);
            LabelSemiMinorAxis_Leave(sender: null, e: null);
            LabelMajorAxis_Leave(sender: null, e: null);
            LabelMinorAxis_Leave(sender: null, e: null);
            LabelEccenctricAnomaly_Leave(sender: null, e: null);
            LabelTrueAnomaly_Leave(sender: null, e: null);
            LabelPerihelionDistance_Leave(sender: null, e: null);
            LabelAphelionDistance_Leave(sender: null, e: null);
            LabelLongitudeDescendingNode_Leave(sender: null, e: null);
            LabelArgumentAphelion_Leave(sender: null, e: null);
            LabelFocalParameter_Leave(sender: null, e: null);
            LabelSemiLatusRectum_Leave(sender: null, e: null);
            LabelLatusRectum_Leave(sender: null, e: null);
            LabelPeriod_Leave(sender: null, e: null);
            LabelOrbitalArea_Leave(sender: null, e: null);
            LabelOrbitalPerimeter_Leave(sender: null, e: null);
            LabelSemiMeanAxis_Leave(sender: null, e: null);
            LabelMeanAxis_Leave(sender: null, e: null);
            LabelStandardGravitationalParameter_Leave(sender: null, e: null);
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
        private void TerminologyForm_Load(object sender, EventArgs e) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TerminologyForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

        #endregion

        #region Enter event handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetStatusbar_Enter(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox box:
                    SetStatusbar(text: box.AccessibleDescription);
                    break;
                case Button button:
                    SetStatusbar(text: button.AccessibleDescription);
                    break;
                case RadioButton buttonRadio:
                    SetStatusbar(text: buttonRadio.AccessibleDescription);
                    break;
                case CheckBox boxCheck:
                    SetStatusbar(text: boxCheck.AccessibleDescription);
                    break;
                case DateTimePicker picker:
                    SetStatusbar(text: picker.AccessibleDescription);
                    break;
                case Label label:
                    SetStatusbar(text: label.AccessibleDescription);
                    break;
                case PictureBox boxPicture:
                    SetStatusbar(text: boxPicture.AccessibleDescription);
                    break;
                case ToolStripButton buttonToolStrip:
                    SetStatusbar(text: buttonToolStrip.AccessibleDescription);
                    break;
                case ToolStripMenuItem item:
                    SetStatusbar(text: item.AccessibleDescription);
                    break;
                case ToolStripLabel labelToolStrip:
                    SetStatusbar(text: labelToolStrip.AccessibleDescription);
                    break;
                case ToolStripComboBox boxToolStripCombo:
                    SetStatusbar(text: boxToolStripCombo.AccessibleDescription);
                    break;
                case ToolStripDropDown downToolStripDrop:
                    SetStatusbar(text: downToolStripDrop.AccessibleDescription);
                    break;
                case ToolStripDropDownButton buttonToolStripDropDown:
                    SetStatusbar(text: buttonToolStripDropDown.AccessibleDescription);
                    break;
                case ToolStripDropDownItem itemToolStripDropDown:
                    SetStatusbar(text: itemToolStripDropDown.AccessibleDescription);
                    break;
                case ToolStripProgressBar bar:
                    SetStatusbar(text: bar.AccessibleDescription);
                    break;
                case ToolStripSeparator separator:
                    SetStatusbar(text: separator.AccessibleDescription);
                    break;
                case ToolStripTextBox boxToolStripText:
                    SetStatusbar(text: boxToolStripText.AccessibleDescription);
                    break;
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
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
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiMinorAxis_Enter(object sender, EventArgs e)
        {
            if (!isLabelSemiMinorAxisActive)
            {
                SetBackAndForeColors(label: ref labelSemiMinorAxis, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMinorAxis_Enter(object sender, EventArgs e)
        {
            if (!isLabelMinorAxisActive)
            {
                SetBackAndForeColors(label: ref labelMinorAxis, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelEccenctricAnomaly_Enter(object sender, EventArgs e)
        {
            if (!isLabelEccenctricAnomalyActive)
            {
                SetBackAndForeColors(label: ref labelEccenctricAnomaly, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelTrueAnomaly_Enter(object sender, EventArgs e)
        {
            if (!isLabelTrueAnomalyActive)
            {
                SetBackAndForeColors(label: ref labelTrueAnomaly, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPerihelionDistance_Enter(object sender, EventArgs e)
        {
            if (!isLabelPerihelionDistanceActive)
            {
                SetBackAndForeColors(label: ref labelPerihelionDistance, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelAphelionDistance_Enter(object sender, EventArgs e)
        {
            if (!isLabelAphelionDistanceActive)
            {
                SetBackAndForeColors(label: ref labelAphelionDistance, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLongitudeDescendingNode_Enter(object sender, EventArgs e)
        {
            if (!isLabelLongitudeDescendingNodeActive)
            {
                SetBackAndForeColors(label: ref labelLongitudeDescendingNode, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelArgumentAphelion_Enter(object sender, EventArgs e)
        {
            if (!isLabelArgumentAphelionActive)
            {
                SetBackAndForeColors(label: ref labelArgumentAphelion, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelFocalParameter_Enter(object sender, EventArgs e)
        {
            if (!isLabelFocalParameterActive)
            {
                SetBackAndForeColors(label: ref labelFocalParameter, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiLatusRectum_Enter(object sender, EventArgs e)
        {
            if (!isLabelSemiLatusRectumActive)
            {
                SetBackAndForeColors(label: ref labelSemiLatusRectum, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLatusRectum_Enter(object sender, EventArgs e)
        {
            if (!isLabelLatusRectumActive)
            {
                SetBackAndForeColors(label: ref labelLatusRectum, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPeriod_Enter(object sender, EventArgs e)
        {
            if (!isLabelPeriodActive)
            {
                SetBackAndForeColors(label: ref labelPeriod, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelOrbitalArea_Enter(object sender, EventArgs e)
        {
            if (!isLabelOrbitalAreaActive)
            {
                SetBackAndForeColors(label: ref labelOrbitalArea, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelOrbitalPerimeter_Enter(object sender, EventArgs e)
        {
            if (!isLabelOrbitalPerimeterActive)
            {
                SetBackAndForeColors(label: ref labelOrbitalPerimeter, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiMeanAxis_Enter(object sender, EventArgs e)
        {
            if (!isLabelSemiMeanAxisActive)
            {
                SetBackAndForeColors(label: ref labelSemiMeanAxis, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMeanAxis_Enter(object sender, EventArgs e)
        {
            if (!isLabelMeanAxisActive)
            {
                SetBackAndForeColors(label: ref labelMeanAxis, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelStandardGravitationalParameter_Enter(object sender, EventArgs e)
        {
            if (!isLabelStandardGravitationalParameterActive)
            {
                SetBackAndForeColors(label: ref labelStandardGravitationalParameter, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMajorAxis_Enter(object sender, EventArgs e)
        {
            if (!isLabelMajorAxisActive)
            {
                SetBackAndForeColors(label: ref labelMajorAxis, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLinearEccentricity_Enter(object sender, EventArgs e)
        {
            if (!isLabelLinearEccentricityActive)
            {
                SetBackAndForeColors(label: ref labelLinearEccentricity, backColor: SystemColors.Highlight, foreColor: SystemColors.HighlightText);
            }
            SetStatusbar_Enter(sender: sender, e: e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Enter(object sender, EventArgs e) => SetStatusbar_Enter(sender: sender, e: e);

        #endregion

        #region Leave event handlers

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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
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
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLinearEccentricity_Leave(object sender, EventArgs e)
        {
            if (!isLabelLinearEccentricityActive)
            {
                SetBackAndForeColors(label: ref labelLinearEccentricity, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiMinorAxis_Leave(object sender, EventArgs e)
        {
            if (!isLabelSemiMinorAxisActive)
            {
                SetBackAndForeColors(label: ref labelSemiMinorAxis, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMajorAxis_Leave(object sender, EventArgs e)
        {
            if (!isLabelMajorAxisActive)
            {
                SetBackAndForeColors(label: ref labelMajorAxis, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMinorAxis_Leave(object sender, EventArgs e)
        {
            if (!isLabelMinorAxisActive)
            {
                SetBackAndForeColors(label: ref labelMinorAxis, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelEccenctricAnomaly_Leave(object sender, EventArgs e)
        {
            if (!isLabelEccenctricAnomalyActive)
            {
                SetBackAndForeColors(label: ref labelEccenctricAnomaly, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelTrueAnomaly_Leave(object sender, EventArgs e)
        {
            if (!isLabelTrueAnomalyActive)
            {
                SetBackAndForeColors(label: ref labelTrueAnomaly, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPerihelionDistance_Leave(object sender, EventArgs e)
        {
            if (!isLabelPerihelionDistanceActive)
            {
                SetBackAndForeColors(label: ref labelPerihelionDistance, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelAphelionDistance_Leave(object sender, EventArgs e)
        {
            if (!isLabelAphelionDistanceActive)
            {
                SetBackAndForeColors(label: ref labelAphelionDistance, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLongitudeDescendingNode_Leave(object sender, EventArgs e)
        {
            if (!isLabelLongitudeDescendingNodeActive)
            {
                SetBackAndForeColors(label: ref labelLongitudeDescendingNode, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelArgumentAphelion_Leave(object sender, EventArgs e)
        {
            if (!isLabelArgumentAphelionActive)
            {
                SetBackAndForeColors(label: ref labelArgumentAphelion, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelFocalParameter_Leave(object sender, EventArgs e)
        {
            if (!isLabelFocalParameterActive)
            {
                SetBackAndForeColors(label: ref labelFocalParameter, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiLatusRectum_Leave(object sender, EventArgs e)
        {
            if (!isLabelSemiLatusRectumActive)
            {
                SetBackAndForeColors(label: ref labelSemiLatusRectum, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLatusRectum_Leave(object sender, EventArgs e)
        {
            if (!isLabelLatusRectumActive)
            {
                SetBackAndForeColors(label: ref labelLatusRectum, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPeriod_Leave(object sender, EventArgs e)
        {
            if (!isLabelPeriodActive)
            {
                SetBackAndForeColors(label: ref labelPeriod, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelOrbitalArea_Leave(object sender, EventArgs e)
        {
            if (!isLabelOrbitalAreaActive)
            {
                SetBackAndForeColors(label: ref labelOrbitalArea, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelOrbitalPerimeter_Leave(object sender, EventArgs e)
        {
            if (!isLabelOrbitalPerimeterActive)
            {
                SetBackAndForeColors(label: ref labelOrbitalPerimeter, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiMeanAxis_Leave(object sender, EventArgs e)
        {
            if (!isLabelSemiMeanAxisActive)
            {
                SetBackAndForeColors(label: ref labelSemiMeanAxis, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMeanAxis_Leave(object sender, EventArgs e)
        {
            if (!isLabelMeanAxisActive)
            {
                SetBackAndForeColors(label: ref labelMeanAxis, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelStandardGravitationalParameter_Leave(object sender, EventArgs e)
        {
            if (!isLabelStandardGravitationalParameterActive)
            {
                SetBackAndForeColors(label: ref labelStandardGravitationalParameter, backColor: SystemColors.Control, foreColor: SystemColors.ControlText);
            }
            ClearStatusbar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Leave(object sender, EventArgs e) => ClearStatusbar();

        #endregion

        #region Click event handlers

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLinearEccentricity_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelLinearEccentricityActive = true;
            labelLinearEccentricity.BackColor = SystemColors.ControlText;
            labelLinearEccentricity.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_LinearEccentricity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiMinorAxis_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelSemiMinorAxisActive = true;
            labelSemiMinorAxis.BackColor = SystemColors.ControlText;
            labelSemiMinorAxis.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_SemiMinorAxis;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMajorAxis_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelMajorAxisActive = true;
            labelMajorAxis.BackColor = SystemColors.ControlText;
            labelMajorAxis.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_MajorAxis;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMinorAxis_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelMinorAxisActive = true;
            labelMinorAxis.BackColor = SystemColors.ControlText;
            labelMinorAxis.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_MinorAxis;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelEccenctricAnomaly_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelEccenctricAnomalyActive = true;
            labelEccenctricAnomaly.BackColor = SystemColors.ControlText;
            labelEccenctricAnomaly.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_EccenctricAnomaly;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelTrueAnomaly_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelTrueAnomalyActive = true;
            labelTrueAnomaly.BackColor = SystemColors.ControlText;
            labelTrueAnomaly.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_TrueAnomaly;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPerihelionDistance_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelPerihelionDistanceActive = true;
            labelPerihelionDistance.BackColor = SystemColors.ControlText;
            labelPerihelionDistance.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_PerihelionDistance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelAphelionDistance_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelAphelionDistanceActive = true;
            labelAphelionDistance.BackColor = SystemColors.ControlText;
            labelAphelionDistance.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_AphelionDistance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLongitudeDescendingNode_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelLongitudeDescendingNodeActive = true;
            labelLongitudeDescendingNode.BackColor = SystemColors.ControlText;
            labelLongitudeDescendingNode.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_LongitudeDescendingNode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelArgumentAphelion_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelArgumentAphelionActive = true;
            labelArgumentAphelion.BackColor = SystemColors.ControlText;
            labelArgumentAphelion.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_ArgumentAphelion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelFocalParameter_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelFocalParameterActive = true;
            labelFocalParameter.BackColor = SystemColors.ControlText;
            labelFocalParameter.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_FocalParameter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiLatusRectum_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelSemiLatusRectumActive = true;
            labelSemiLatusRectum.BackColor = SystemColors.ControlText;
            labelSemiLatusRectum.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_SemiLatusRectum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLatusRectum_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelLatusRectumActive = true;
            labelLatusRectum.BackColor = SystemColors.ControlText;
            labelLatusRectum.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_LatusRectum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPeriod_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelPeriodActive = true;
            labelPeriod.BackColor = SystemColors.ControlText;
            labelPeriod.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_Period;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelOrbitalArea_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelOrbitalAreaActive = true;
            labelOrbitalArea.BackColor = SystemColors.ControlText;
            labelOrbitalArea.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_OrbitalArea;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelOrbitalPerimeter_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelOrbitalPerimeterActive = true;
            labelOrbitalPerimeter.BackColor = SystemColors.ControlText;
            labelOrbitalPerimeter.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_OrbitalPerimeter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSemiMeanAxis_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelSemiMeanAxisActive = true;
            labelSemiMeanAxis.BackColor = SystemColors.ControlText;
            labelSemiMeanAxis.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_SemiMeanAxis;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMeanAxis_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelMeanAxisActive = true;
            labelMeanAxis.BackColor = SystemColors.ControlText;
            labelMeanAxis.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_MeanAxis;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelStandardGravitationalParameter_Click(object sender, EventArgs e)
        {
            DeselectAllFields();
            isLabelStandardGravitationalParameterActive = true;
            labelStandardGravitationalParameter.BackColor = SystemColors.ControlText;
            labelStandardGravitationalParameter.ForeColor = SystemColors.Control;
            webBrowser.DocumentText = I10nStrings.terminology_StandardGravitationalParameter;
        }

        #endregion
    }
}
