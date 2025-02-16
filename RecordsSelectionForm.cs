using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class RecordsSelectionForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public RecordsSelectionForm() => InitializeComponent();

		#endregion

		#region Local Methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

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
		private static void ShowRecordsMain()
		{
			using RecordsMainForm formRecordsMain = new();
			_ = formRecordsMain.ShowDialog();
		}

		#endregion

		#region Form*-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RecordsSelectionForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click & ButtonClick event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMeanAnomaly_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonArgumentOfPerihelion_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonInclination_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOrbitalEccentricity_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMeanDailyMotion_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSemiMajorAxis_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonAbsoluteMagnitude_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSlopeParameter_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonNumberOfOppositions_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonNumberOfObservations_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonObservationSpan_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonRmsResidual_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonComputername_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonDateOfLastObservation_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckButtonRecordSortDirectionAscending_Click(object sender, EventArgs e) => checkButtonRecordSortDirectionDescending.Checked = !checkButtonRecordSortDirectionAscending.Checked;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckButtonRecordSortDirectionDescending_Click(object sender, EventArgs e) => checkButtonRecordSortDirectionAscending.Checked = !checkButtonRecordSortDirectionDescending.Checked;

		#endregion
	}
}
