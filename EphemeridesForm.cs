using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents the form for displaying ephemerides.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class EphemeridesForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="EphemeridesForm"/> class.
		/// </summary>
		public EphemeridesForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(EphemeridesForm_KeyDown);
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

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void EphemeridesForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		/// <summary>
		/// Handles the form closed event.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void EphemeridesForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region BackgroundWorker event handler

		/// <summary>
		/// Handles the DoWork event of the BackgroundWorker.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			// Implement background work here
		}

		/// <summary>
		/// Handles the ProgressChanged event of the BackgroundWorker.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="System.ComponentModel.ProgressChangedEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar.Value = e.ProgressPercentage;
		}

		/// <summary>
		/// Handles the RunWorkerCompleted event of the BackgroundWorker.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			// Implement completion logic here
		}

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
		/// Handles the Click event of the Calculate button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCalculate_Click(object sender, EventArgs e)
		{
			// Implement calculation logic here
		}

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void EphemeridesForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
