using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Form for displaying derived orbit elements.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DerivatedOrbitElementsForm : KryptonForm
	{
		/// <summary>
		/// List of derived orbit elements.
		/// </summary>
		private List<object> derivatedOrbitElements = [];

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DerivatedOrbitElementsForm"/> class.
		/// </summary>
		public DerivatedOrbitElementsForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(DerivatedOrbitElementsForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

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
		/// Opens the terminology form with the specified index.
		/// </summary>
		/// <param name="index">The index of the terminology to open.</param>
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
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusbar(string text, string additionalInfo = "")
		{
			if (!string.IsNullOrEmpty(value: text))
			{
				labelInformation.Enabled = true;
				labelInformation.Text = string.IsNullOrEmpty(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
			}
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusbar()
		{
			labelInformation.Enabled = false;
			labelInformation.Text = string.Empty;
		}

		/// <summary>
		/// Sets the database with the provided list of derived orbit elements.
		/// </summary>
		/// <param name="list">The list of derived orbit elements.</param>
		public void SetDatabase(List<object> list) => derivatedOrbitElements = list;

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DerivatedOrbitElementsForm_Load(object sender, EventArgs e)
		{
			if (derivatedOrbitElements == null || derivatedOrbitElements.Count < 19)
			{
				_ = MessageBox.Show(text: "Invalid data", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				return;
			}

			labelLinearEccentricityData.Text = derivatedOrbitElements[index: 0]?.ToString();
			labelSemiMinorAxisData.Text = derivatedOrbitElements[index: 1]?.ToString();
			labelMajorAxisData.Text = derivatedOrbitElements[index: 2]?.ToString();
			labelMinorAxisData.Text = derivatedOrbitElements[index: 3]?.ToString();
			labelEccentricAnomalyData.Text = derivatedOrbitElements[index: 4]?.ToString();
			labelTrueAnomalyData.Text = derivatedOrbitElements[index: 5]?.ToString();
			labelPerihelionDistanceData.Text = derivatedOrbitElements[index: 6]?.ToString();
			labelAphelionDistanceData.Text = derivatedOrbitElements[index: 7]?.ToString();
			labelLongitudeDescendingNodeData.Text = derivatedOrbitElements[index: 8]?.ToString();
			labelArgumentAphelionData.Text = derivatedOrbitElements[index: 9]?.ToString();
			labelFocalParameterData.Text = derivatedOrbitElements[index: 10]?.ToString();
			labelSemiLatusRectumData.Text = derivatedOrbitElements[index: 11]?.ToString();
			labelLatusRectumData.Text = derivatedOrbitElements[index: 12]?.ToString();
			labelPeriodData.Text = derivatedOrbitElements[index: 13]?.ToString();
			labelOrbitalAreaData.Text = derivatedOrbitElements[index: 14]?.ToString();
			labelOrbitalPerimeterData.Text = derivatedOrbitElements[index: 15]?.ToString();
			labelSemiMeanAxisData.Text = derivatedOrbitElements[index: 16]?.ToString();
			labelMeanAxisData.Text = derivatedOrbitElements[index: 17]?.ToString();
			labelStandardGravitationalParameterData.Text = derivatedOrbitElements[index: 18]?.ToString();
		}

		/// <summary>
		/// Handles the FormClosed event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
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
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// Called when a control is double-clicked to copy the text to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			ArgumentNullException.ThrowIfNull(argument: sender);
			if (sender is Control control)
			{
				CopyToClipboard(text: control.Text);
			}
		}

		/// <summary>
		/// Called when the Linear Eccentricity label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelLinearEccentricityDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 20);

		/// <summary>
		/// Called when the Semi Minor Axis label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelSemiMinorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 21);

		/// <summary>
		/// Called when the Major Axis label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelMajorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 22);

		/// <summary>
		/// Called when the Minor Axis label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelMinorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 23);

		/// <summary>
		/// Called when the Eccentric Anomaly label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelEccenctricAnomalyDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 24);

		/// <summary>
		/// Called when the True Anomaly label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelTrueAnomalyDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 25);

		/// <summary>
		/// Called when the Perihelion Distance label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelPerihelionDistanceDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 26);

		/// <summary>
		/// Called when the Aphelion Distance label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelAphelionDistanceDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 27);

		/// <summary>
		/// Called when the Longitude of the Descending Node label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelLongitudeDescendingNodeDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 28);

		/// <summary>
		/// Called when the Argument of the Aphelion label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelArgumentAphelionDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 29);

		/// <summary>
		/// Called when the Focal Parameter label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelFocalParameterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 30);

		/// <summary>
		/// Called when the Semi Latus Rectum label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelSemiLatusRectumDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 31);

		/// <summary>
		/// Called when the Latus Rectum label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelLatusRectumDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 32);

		/// <summary>
		/// Called when the Orbital Period label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelOrbitalPeriodDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 33);

		/// <summary>
		/// Called when the Orbital Area label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelOrbitalAreaDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 34);

		/// <summary>
		/// Called when the Orbital Perimeter label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelOrbitalPerimeterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 35);

		/// <summary>
		/// Called when the Orbital Semi-major axis label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelSemiMeanAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 36);

		/// <summary>
		/// Called when the Semi-mean Axis label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelMeanAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 37);

		/// <summary>
		/// Called when the Gravitational Parameter label is double-clicked to open the terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelStandardGravitationalParameterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 38);

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DerivatedOrbitElementsForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}