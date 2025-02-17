using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// A form that allows users to copy data to the clipboard.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class CopyDataToClipboardForm : KryptonForm
	{
		/// <summary>
		/// The list of data to be copied to the clipboard.
		/// </summary>
		private List<string> dataToCopy = [];

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="CopyDataToClipboardForm"/> class.
		/// </summary>
		public CopyDataToClipboardForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(CopyDataToClipboardForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region local methods

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
			catch (System.Runtime.InteropServices.ExternalException ex)
			{
				_ = MessageBox.Show(text: $"{I10nStrings.CopiedToClipboard}{ex.Message}", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(text: $"{I10nStrings.CopiedToClipboard}{ex.Message}", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The text to be displayed.</param>
		/// <param name="additionalInfo">Additional information to be displayed.</param>
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
		/// Sets the data to be copied to the clipboard.
		/// </summary>
		/// <param name="list">The list of data to be copied.</param>
		public void SetDatabase(List<string> list) => dataToCopy = list;

		#endregion

		#region Form* event handler

		/// <summary>
		/// Handles the Load event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyDataToClipboardForm_Load(object sender, EventArgs e)
		{
			KryptonButton[] buttons =
			[
				buttonIndexNumber, buttonReadableDesignation, buttonEpoch, buttonMeanAnomaly, buttonArgumentOfPerihelion,
				buttonLongitudeOfTheAscendingNode, buttonInclination, buttonOrbitalEccentricity, buttonMeanDailyMotion,
				buttonSemimajorAxis, buttonAbsoluteMagnitude, buttonSlopeParameter, buttonReference, buttonNumberOfOppositions,
				buttonNumberOfObservations, buttonObservationSpan, buttonRmsResidual, buttonComputername, buttonFlags, buttonDateOfLastObservation
			];

			for (int i = 0; i < buttons.Length; i++)
			{
				buttons[i].Tag = dataToCopy.Count > i ? dataToCopy[index: i] : string.Empty;
			}
		}

		/// <summary>
		/// Handles the FormClosed event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void CopyDataToClipboardForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter-Handler

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
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click-Handler

		/// <summary>
		/// Handles the Click event of the buttonIndexNumber control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonIndexNumber_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonIndexNumber.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonReadableDesignation control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonReadableDesignation_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonReadableDesignation.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonEpoch control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonEpoch_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonEpoch.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonMeanAnomaly control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMeanAnomaly_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonMeanAnomaly.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonArgumentOfPerihelion control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonArgumentOfPerihelion_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonArgumentOfPerihelion.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonLongitudeOfTheAscendingNode control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonLongitudeOfTheAscendingNode.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonInclination control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonInclination_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonInclination.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonOrbitalEccentricity control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonOrbitalEccentricity_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonOrbitalEccentricity.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonMeanDailyMotion control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMeanDailyMotion_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonMeanDailyMotion.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonSemimajorAxis control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonSemimajorAxis_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonSemimajorAxis.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonAbsoluteMagnitude control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonAbsoluteMagnitude_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonAbsoluteMagnitude.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonSlopeParameter control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonSlopeParameter_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonSlopeParameter.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonReference control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonReference_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonReference.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonNumberOfOppositions control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonNumberOfOppositions_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonNumberOfOppositions.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonNumberOfObservations control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonNumberOfObservations_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonNumberOfObservations.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonObservationSpan control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonObservationSpan_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonObservationSpan.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonRmsResidual control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonRmsResidual_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonRmsResidual.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonComputername control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonComputername_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonComputername.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonFlags control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonFlags_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonFlags.Tag?.ToString() ?? string.Empty);

		/// <summary>
		/// Handles the Click event of the buttonDateOfLastObservation control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonDateOfLastObservation_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonDateOfLastObservation.Tag?.ToString() ?? string.Empty);

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyDataToClipboardForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}