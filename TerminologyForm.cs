using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class TerminologyForm : KryptonForm
	{
		private int selectedElement = 0;

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public TerminologyForm() => InitializeComponent();

		#endregion

		#region local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		private void SetActiveElement()
		{
			webBrowser.DocumentText = selectedElement switch
			{
				0 => I10nStrings.terminology_IndexNumber,
				1 => I10nStrings.terminology_ReadableDesignaton,
				2 => I10nStrings.terminology_Epoch,
				3 => I10nStrings.terminology_MeanAnomalyAtTheEpoch,
				4 => I10nStrings.terminology_ArgumentOfPerihelion,
				5 => I10nStrings.terminology_LongitudeOfTheAscendingNode,
				6 => I10nStrings.terminology_InclinationToTheEcliptic,
				7 => I10nStrings.terminology_OrbitalEccentricity,
				8 => I10nStrings.terminology_MeanDailyMotion,
				9 => I10nStrings.terminology_SemiMajorAxis,
				10 => I10nStrings.terminology_AbsoluteMagnitude,
				11 => I10nStrings.terminology_SlopeParameter,
				12 => I10nStrings.terminology_Reference,
				13 => I10nStrings.terminology_NumberOfOppositions,
				14 => I10nStrings.terminology_NumberOfObservations,
				15 => I10nStrings.terminology_ObservationSpan,
				16 => I10nStrings.terminology_RmsResidual,
				17 => I10nStrings.terminology_ComputerName,
				18 => I10nStrings.terminology_Flags,
				19 => I10nStrings.terminology_DateOfLastObservation,
				20 => I10nStrings.terminology_LinearEccentricity,
				21 => I10nStrings.terminology_SemiMinorAxis,
				22 => I10nStrings.terminology_MajorAxis,
				23 => I10nStrings.terminology_MinorAxis,
				24 => I10nStrings.terminology_EccenctricAnomaly,
				25 => I10nStrings.terminology_TrueAnomaly,
				26 => I10nStrings.terminology_PerihelionDistance,
				27 => I10nStrings.terminology_AphelionDistance,
				28 => I10nStrings.terminology_LongitudeOfTheDescendingNode,
				29 => I10nStrings.terminology_ArgumentOfAphelion,
				30 => I10nStrings.terminology_FocalParameter,
				31 => I10nStrings.terminology_SemiLatusRectum,
				32 => I10nStrings.terminology_LatusRectum,
				33 => I10nStrings.terminology_OrbitalPeriod,
				34 => I10nStrings.terminology_OrbitalArea,
				35 => I10nStrings.terminology_OrbitalPerimeter,
				36 => I10nStrings.terminology_SemiMeanAxis,
				37 => I10nStrings.terminology_MeanAxis,
				38 => I10nStrings.terminology_StandardGravitationalParameter,
				_ => I10nStrings.terminology_IndexNumber,
			};
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
		public void SetIndexNumberActive() => selectedElement = 0;

		/// <summary>
		/// 
		/// </summary>
		public void SetReadableDesignationActive() => selectedElement = 1;

		/// <summary>
		/// 
		/// </summary>
		public void SetEpochActive() => selectedElement = 2;

		/// <summary>
		/// 
		/// </summary>
		public void SetMeanAnomalyAtTheEpochActive() => selectedElement = 3;

		/// <summary>
		/// 
		/// </summary>
		public void SetArgumentOfPerihelionActive() => selectedElement = 4;

		/// <summary>
		/// 
		/// </summary>
		public void SetLongitudeOfTheAscendingNodeActive() => selectedElement = 5;

		/// <summary>
		/// 
		/// </summary>
		public void SetInclinationToTheEclipticActive() => selectedElement = 6;

		/// <summary>
		/// 
		/// </summary>
		public void SetOrbitalEccentricityActive() => selectedElement = 7;

		/// <summary>
		/// 
		/// </summary>
		public void SetMeanDailyMotionActive() => selectedElement = 8;

		/// <summary>
		/// 
		/// </summary>
		public void SetSemiMajorAxisActive() => selectedElement = 9;

		/// <summary>
		/// 
		/// </summary>
		public void SetAbsoluteMagnitudeActive() => selectedElement = 10;

		/// <summary>
		/// 
		/// </summary>
		public void SetSlopeParamActive() => selectedElement = 11;

		/// <summary>
		/// 
		/// </summary>
		public void SetReferenceActive() => selectedElement = 12;

		/// <summary>
		/// 
		/// </summary>
		public void SetNumberOfOppositionsActive() => selectedElement = 13;

		/// <summary>
		/// 
		/// </summary>
		public void SetNumberOfObservationsActive() => selectedElement = 14;

		/// <summary>
		/// 
		/// </summary>
		public void SetObservationSpanActive() => selectedElement = 15;

		/// <summary>
		/// 
		/// </summary>
		public void SetRmsResidualActive() => selectedElement = 16;

		/// <summary>
		/// 
		/// </summary>
		public void SetComputerNameActive() => selectedElement = 17;

		/// <summary>
		/// 
		/// </summary>
		public void SetFlagsActive() => selectedElement = 18;

		/// <summary>
		/// 
		/// </summary>
		public void SetDateOfTheLastObservationActive() => selectedElement = 19;

		/// <summary>
		/// 
		/// </summary>
		public void SetLinearEccentricityActive() => selectedElement = 20;

		/// <summary>
		/// 
		/// </summary>
		public void SetSemiMinorAxisActive() => selectedElement = 21;

		/// <summary>
		/// 
		/// </summary>
		public void SetMajorAxisActive() => selectedElement = 22;

		/// <summary>
		/// 
		/// </summary>
		public void SetMinorAxisActive() => selectedElement = 23;

		/// <summary>
		/// 
		/// </summary>
		public void SetEccenctricAnomalyActive() => selectedElement = 24;

		/// <summary>
		/// 
		/// </summary>
		public void SetTrueAnomalyActive() => selectedElement = 25;

		/// <summary>
		/// 
		/// </summary>
		public void SetPerihelionDistanceActive() => selectedElement = 26;

		/// <summary>
		/// 
		/// </summary>
		public void SetAphelionDistanceActive() => selectedElement = 27;

		/// <summary>
		/// 
		/// </summary>
		public void SetLongitudeOfTheDescendingNodeActive() => selectedElement = 28;

		/// <summary>
		/// 
		/// </summary>
		public void SetArgumentOfTheAphelionActive() => selectedElement = 29;

		/// <summary>
		/// 
		/// </summary>
		public void SetFocalParameterActive() => selectedElement = 30;

		/// <summary>
		/// 
		/// </summary>
		public void SetSemiLatusRectumActive() => selectedElement = 31;

		/// <summary>
		/// 
		/// </summary>
		public void SetLatusRectumActive() => selectedElement = 32;

		/// <summary>
		/// 
		/// </summary>
		public void SetOrbitalPeriodActive() => selectedElement = 33;

		/// <summary>
		/// 
		/// </summary>
		public void SetOrbitalAreaActive() => selectedElement = 34;

		/// <summary>
		/// 
		/// </summary>
		public void SetOrbitalPerimeterActive() => selectedElement = 35;

		/// <summary>
		/// 
		/// </summary>
		public void SetSemiMeanAxisActive() => selectedElement = 36;

		/// <summary>
		/// 
		/// </summary>
		public void SetMeanAxisActive() => selectedElement = 37;

		/// <summary>
		/// 
		/// </summary>
		public void SetStandardGravitationalParameterActive() => selectedElement = 38;

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TerminologyForm_Load(object sender, EventArgs e) => SetActiveElement();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TerminologyForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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

		#region Leave-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region SelectedValueChanged event handler

		private void ListBox_SelectedValueChanged(object sender, EventArgs e)
		{
			selectedElement = listBox.SelectedIndex;
			SetActiveElement();
		}

		#endregion
	}
}
