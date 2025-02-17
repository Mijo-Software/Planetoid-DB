using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents the form for selecting records.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class RecordsSelectionForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="RecordsSelectionForm"/> class.
		/// </summary>
		public RecordsSelectionForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(RecordsSelectionForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region Local Methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

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
		/// Shows the main records form.
		/// </summary>
		private static void ShowRecordsMain()
		{
			using RecordsMainForm formRecordsMain = new();
			_ = formRecordsMain.ShowDialog();
		}

		#endregion

		#region Form event handler

		/// <summary>
		/// Handles the FormClosed event of the RecordsSelectionForm.
		/// Disposes the form when it is closed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void RecordsSelectionForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter event handler

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

		#region Leave event handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click & ButtonClick event handlers

		/// <summary>
		/// Handles the Click event of the ButtonMeanAnomaly control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMeanAnomaly_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonArgumentOfPerihelion control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonArgumentOfPerihelion_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonLongitudeOfTheAscendingNode control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonInclination control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonInclination_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonOrbitalEccentricity control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonOrbitalEccentricity_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonMeanDailyMotion control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMeanDailyMotion_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonSemiMajorAxis control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonSemiMajorAxis_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonAbsoluteMagnitude control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonAbsoluteMagnitude_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonSlopeParameter control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonSlopeParameter_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonNumberOfOppositions control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonNumberOfOppositions_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonNumberOfObservations control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonNumberOfObservations_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonObservationSpan control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonObservationSpan_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonRmsResidual control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonRmsResidual_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonComputername control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonComputername_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the ButtonDateOfLastObservation control.
		/// Shows the main records form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonDateOfLastObservation_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the Click event of the CheckButtonRecordSortDirectionAscending control.
		/// Toggles the checked state of the descending sort direction button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CheckButtonRecordSortDirectionAscending_Click(object sender, EventArgs e) => checkButtonRecordSortDirectionDescending.Checked = !checkButtonRecordSortDirectionAscending.Checked;

		/// <summary>
		/// Handles the Click event of the CheckButtonRecordSortDirectionDescending control.
		/// Toggles the checked state of the ascending sort direction button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CheckButtonRecordSortDirectionDescending_Click(object sender, EventArgs e) => checkButtonRecordSortDirectionAscending.Checked = !checkButtonRecordSortDirectionDescending.Checked;

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the RecordsSelectionForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void RecordsSelectionForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}