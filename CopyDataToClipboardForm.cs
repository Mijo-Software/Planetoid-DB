using System.Collections;
using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class CopyDataToClipboardForm : KryptonForm
	{
		private ArrayList dataToCopy = new(capacity: 0);

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public CopyDataToClipboardForm() => InitializeComponent();

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
			catch (Exception ex)
			{
				_ = MessageBox.Show(text: $"{I10nStrings.CopiedToClipboard}{ex.Message}", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
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
		public void SetDatabase(ArrayList arrayList) => dataToCopy = arrayList;

		#endregion

		#region Form* event handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyDataToClipboardForm_Load(object sender, EventArgs e)
		{
			buttonIndexNumber.Tag = dataToCopy[index: 0];
			buttonReadableDesignation.Tag = dataToCopy[index: 1];
			buttonEpoch.Tag = dataToCopy[index: 2];
			buttonMeanAnomaly.Tag = dataToCopy[index: 3];
			buttonArgumentOfPerihelion.Tag = dataToCopy[index: 4];
			buttonLongitudeOfTheAscendingNode.Tag = dataToCopy[index: 5];
			buttonInclination.Tag = dataToCopy[index: 6];
			buttonOrbitalEccentricity.Tag = dataToCopy[index: 7];
			buttonMeanDailyMotion.Tag = dataToCopy[index: 8];
			buttonSemimajorAxis.Tag = dataToCopy[index: 9];
			buttonAbsoluteMagnitude.Tag = dataToCopy[index: 10];
			buttonSlopeParameter.Tag = dataToCopy[index: 11];
			buttonReference.Tag = dataToCopy[index: 12];
			buttonNumberOfOppositions.Tag = dataToCopy[index: 13];
			buttonNumberOfObservations.Tag = dataToCopy[index: 14];
			buttonObservationSpan.Tag = dataToCopy[index: 15];
			buttonRmsResidual.Tag = dataToCopy[index: 16];
			buttonComputername.Tag = dataToCopy[index: 17];
			buttonFlags.Tag = dataToCopy[index: 18];
			buttonDateOfLastObservation.Tag = dataToCopy[index: 19];
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonIndexNumber_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonIndexNumber.Tag.ToString());
#pragma warning restore CS8604 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
		private void ButtonReadableDesignation_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonReadableDesignation.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonEpoch_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonEpoch.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonMeanAnomaly_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonMeanAnomaly.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonArgumentOfPerihelion_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonArgumentOfPerihelion.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonLongitudeOfTheAscendingNode.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonInclination_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonInclination.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonOrbitalEccentricity_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonOrbitalEccentricity.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonMeanDailyMotion_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonMeanDailyMotion.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonSemimajorAxis_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonSemimajorAxis.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonAbsoluteMagnitude_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonAbsoluteMagnitude.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonSlopeParameter_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonSlopeParameter.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonReference_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonReference.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonNumberOfOppositions_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonNumberOfOppositions.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonNumberOfObservations_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonNumberOfObservations.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonObservationSpan_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonObservationSpan.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonRmsResidual_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonRmsResidual.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonComputername_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonComputername.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonFlags_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonFlags.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonDateOfLastObservation_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonDateOfLastObservation.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		#endregion

	}
}
