using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents a form for filtering data in the Planetoid database.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class FilterForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="FilterForm"/> class.
		/// </summary>
		public FilterForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(FilterForm_KeyDown);
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

		#endregion

		#region Form event handler

		/// <summary>
		/// Handles the FormClosed event of the FilterForm.
		/// Disposes the form when it is closed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void FilterForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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

		#region Leave-Handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click & ButtonClick event handlers

		/// <summary>
		/// Handles the Click event of the ButtonResetMeanAnomalyAtTheEpoch.
		/// Resets the mean anomaly at the epoch filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetMeanAnomalyAtTheEpoch_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetArgumentOfPerihelion.
		/// Resets the argument of perihelion filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetArgumentOfPerihelion_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetLongitudeOfTheAscendingNode.
		/// Resets the longitude of the ascending node filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetLongitudeOfTheAscendingNode_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetInclination.
		/// Resets the inclination filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetInclination_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetOrbitalEccentricity.
		/// Resets the orbital eccentricity filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetOrbitalEccentricity_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetMeanDailyMotion.
		/// Resets the mean daily motion filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetMeanDailyMotion_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetSemiMajorAxis.
		/// Resets the semi-major axis filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetSemiMajorAxis_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetAbsoluteMagnitude.
		/// Resets the absolute magnitude filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetAbsoluteMagnitude_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetSlopeParameter.
		/// Resets the slope parameter filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetSlopeParameter_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonNumberOfOppositions.
		/// Resets the number of oppositions filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonNumberOfOppositions_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetNumberOfObservations.
		/// Resets the number of observations filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetNumberOfObservations_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonResetRmsResidual.
		/// Resets the RMS residual filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonResetRmsResidual_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonApply.
		/// Applies the filter settings.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonApply_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonCancel.
		/// Cancels the filter settings and closes the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonReset.
		/// Resets all filter settings to their default values.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonReset_Click(object sender, EventArgs e)
		{
		}

		#endregion

		#region ValueChanged-Handler

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumMeanAnomalyAtTheEpoch.
		/// Updates the minimum mean anomaly at the epoch filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumMeanAnomalyAtTheEpoch_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumMeanAnomalyAtTheEpoch.
		/// Updates the maximum mean anomaly at the epoch filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumMeanAnomalyAtTheEpoch_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumArgumentOfPerihelion.
		/// Updates the minimum argument of perihelion filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumArgumentOfPerihelion_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumArgumentOfPerihelion.
		/// Updates the maximum argument of perihelion filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumArgumentOfPerihelion_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumLongitudeOfTheAscendingNode.
		/// Updates the minimum longitude of the ascending node filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumLongitudeOfTheAscendingNode_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumLongitudeOfTheAscendingNode.
		/// Updates the maximum longitude of the ascending node filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumLongitudeOfTheAscendingNode_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumInclination.
		/// Updates the minimum inclination filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumInclination_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumInclination.
		/// Updates the maximum inclination filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumInclination_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumOrbitalEccentricity.
		/// Updates the minimum orbital eccentricity filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumOrbitalEccentricity_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumOrbitalEccentricity.
		/// Updates the maximum orbital eccentricity filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumOrbitalEccentricity_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumMeanDailyMotion.
		/// Updates the minimum mean daily motion filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumMeanDailyMotion_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumMeanDailyMotion.
		/// Updates the maximum mean daily motion filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumMeanDailyMotion_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumSemiMajorAxis.
		/// Updates the minimum semi-major axis filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumSemiMajorAxis_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumSemiMajorAxis.
		/// Updates the maximum semi-major axis filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumSemiMajorAxis_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumAbsoluteMagnitude.
		/// Updates the minimum absolute magnitude filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumAbsoluteMagnitude_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumAbsoluteMagnitude.
		/// Updates the maximum absolute magnitude filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumAbsoluteMagnitude_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumSlopeParameter.
		/// Updates the minimum slope parameter filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumSlopeParameter_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumSlopeParameter.
		/// Updates the maximum slope parameter filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumSlopeParameter_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumNumberOfOppositions.
		/// Updates the minimum number of oppositions filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumNumberOfOppositions_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumNumberOfOppositions.
		/// Updates the maximum number of oppositions filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumNumberOfOppositions_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumNumberOfObservations.
		/// Updates the minimum number of observations filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumNumberOfObservations_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumNumberOfObservations.
		/// Updates the maximum number of observations filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumNumberOfObservations_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMinimumRmsResidual.
		/// Updates the minimum RMS residual filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMinimumRmsResidual_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownMaximumRmsResidual.
		/// Updates the maximum RMS residual filter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownMaximumRmsResidual_ValueChanged(object sender, EventArgs e)
		{
		}

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FilterForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
