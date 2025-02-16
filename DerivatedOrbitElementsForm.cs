using System.Collections;
using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DerivatedOrbitElementsForm : KryptonForm
	{
		private ArrayList derivatedOrbitElements = new(capacity: 0);

		#region Local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Copies the specified text to the clipboard and displays a confirmation message.
		/// </summary>
		/// <param name="text">The text to be copied.</param>
		private static void CopyToClipboard(string text)
		{
			try
			{
				Clipboard.SetText(text: text);
				_ = MessageBox.Show(text: I10nStrings.CopiedToClipboard, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(text: $"{I10nStrings.CopiedToClipboard}{ex.Message}", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void OpenTerminology(uint index)
		{
			using TerminologyForm formTerminology = new();
			switch (index)
			{
				case 0: formTerminology.SetIndexNumberActive(); break;
				case 1: formTerminology.SetReadableDesignationActive(); break;
				case 2: formTerminology.SetEpochActive(); break;
				case 3: formTerminology.SetMeanAnomalyAtTheEpochActive(); break;
				case 4: formTerminology.SetArgumentOfPerihelionActive(); break;
				case 5: formTerminology.SetLongitudeOfTheAscendingNodeActive(); break;
				case 6: formTerminology.SetInclinationToTheEclipticActive(); break;
				case 7: formTerminology.SetOrbitalEccentricityActive(); break;
				case 8: formTerminology.SetMeanDailyMotionActive(); break;
				case 9: formTerminology.SetSemiMajorAxisActive(); break;
				case 10: formTerminology.SetAbsoluteMagnitudeActive(); break;
				case 11: formTerminology.SetSlopeParamActive(); break;
				case 12: formTerminology.SetReferenceActive(); break;
				case 13: formTerminology.SetNumberOfOppositionsActive(); break;
				case 14: formTerminology.SetNumberOfObservationsActive(); break;
				case 15: formTerminology.SetObservationSpanActive(); break;
				case 16: formTerminology.SetRmsResidualActive(); break;
				case 17: formTerminology.SetComputerNameActive(); break;
				case 18: formTerminology.SetFlagsActive(); break;
				case 19: formTerminology.SetDateOfTheLastObservationActive(); break;
				case 20: formTerminology.SetLinearEccentricityActive(); break;
				case 21: formTerminology.SetSemiMinorAxisActive(); break;
				case 22: formTerminology.SetMajorAxisActive(); break;
				case 23: formTerminology.SetMinorAxisActive(); break;
				case 24: formTerminology.SetEccenctricAnomalyActive(); break;
				case 25: formTerminology.SetTrueAnomalyActive(); break;
				case 26: formTerminology.SetPerihelionDistanceActive(); break;
				case 27: formTerminology.SetAphelionDistanceActive(); break;
				case 28: formTerminology.SetLongitudeOfTheDescendingNodeActive(); break;
				case 29: formTerminology.SetArgumentOfTheAphelionActive(); break;
				case 30: formTerminology.SetFocalParameterActive(); break;
				case 31: formTerminology.SetSemiLatusRectumActive(); break;
				case 32: formTerminology.SetLatusRectumActive(); break;
				case 33: formTerminology.SetOrbitalPeriodActive(); break;
				case 34: formTerminology.SetOrbitalAreaActive(); break;
				case 35: formTerminology.SetOrbitalPerimeterActive(); break;
				case 36: formTerminology.SetSemiMeanAxisActive(); break;
				case 37: formTerminology.SetMeanAxisActive(); break;
				case 38: formTerminology.SetStandardGravitationalParameterActive(); break;
				default: formTerminology.SetIndexNumberActive(); break;
			}
			formTerminology.TopMost = TopMost;
			_ = formTerminology.ShowDialog();
		}

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
		/// <param name="arrayList"></param>
		public void SetDatabase(ArrayList arrayList) => derivatedOrbitElements = arrayList;

		#endregion

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public DerivatedOrbitElementsForm() => InitializeComponent();

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DerivatedOrbitElementsForm_Load(object sender, EventArgs e)
		{
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
			labelLinearEccentricityData.Text = derivatedOrbitElements[index: 0].ToString();
			labelSemiMinorAxisData.Text = derivatedOrbitElements[index: 1].ToString();
			labelMajorAxisData.Text = derivatedOrbitElements[index: 2].ToString();
			labelMinorAxisData.Text = derivatedOrbitElements[index: 3].ToString();
			labelEccentricAnomalyData.Text = derivatedOrbitElements[index: 4].ToString();
			labelTrueAnomalyData.Text = derivatedOrbitElements[index: 5].ToString();
			labelPerihelionDistanceData.Text = derivatedOrbitElements[index: 6].ToString();
			labelAphelionDistanceData.Text = derivatedOrbitElements[index: 7].ToString();
			labelLongitudeDescendingNodeData.Text = derivatedOrbitElements[index: 8].ToString();
			labelArgumentAphelionData.Text = derivatedOrbitElements[index: 9].ToString();
			labelFocalParameterData.Text = derivatedOrbitElements[index: 10].ToString();
			labelSemiLatusRectumData.Text = derivatedOrbitElements[index: 11].ToString();
			labelLatusRectumData.Text = derivatedOrbitElements[index: 12].ToString();
			labelPeriodData.Text = derivatedOrbitElements[index: 13].ToString();
			labelOrbitalAreaData.Text = derivatedOrbitElements[index: 14].ToString();
			labelOrbitalPerimeterData.Text = derivatedOrbitElements[index: 15].ToString();
			labelSemiMeanAxisData.Text = derivatedOrbitElements[index: 16].ToString();
			labelMeanAxisData.Text = derivatedOrbitElements[index: 17].ToString();
			labelStandardGravitationalParameterData.Text = derivatedOrbitElements[index: 18].ToString();
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DerivatedOrbitElementsForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control control && control.AccessibleDescription != null)
			{
				SetStatusbar(text: control.AccessibleDescription);
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			switch (sender)
			{
				case Label label: CopyToClipboard(text: label.Text); break;
				case KryptonLabel kryptonLabel: CopyToClipboard(text: kryptonLabel.Text); break;
				case ToolStripLabel labelToolStripCombo: CopyToClipboard(text: labelToolStripCombo.Text); break;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLinearEccentricityDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 20);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMinorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 21);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMajorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 22);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMinorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 23);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEccenctricAnomalyDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 24);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelTrueAnomalyDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 25);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelPerihelionDistanceDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 26);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAphelionDistanceDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 27);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongitudeDescendingNodeDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 28);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgumentAphelionDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 29);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFocalParameterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 30);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiLatusRectumDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 31);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLatusRectumDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 32);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbitalPeriodDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 33);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbitalAreaDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 34);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbitalPerimeterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 35);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMeanAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 36);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 37);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStandardGravitationalParameterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 38);

		#endregion
	}
}
