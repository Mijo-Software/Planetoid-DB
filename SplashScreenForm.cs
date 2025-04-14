using System.Diagnostics;
using Krypton.Toolkit;
using NLog;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents the splash screen form of the application.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class SplashScreenForm : KryptonForm
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger(); // NLog logger instance

		#region constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="SplashScreenForm"/> class.
		/// </summary>
		public SplashScreenForm() => InitializeComponent();

		#endregion

		#region local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Displays an error message.
		/// </summary>
		/// <param name="message">The error message.</param>
		private static void ShowErrorMessage(string message) =>
			// Show an error message box with the specified message
			_ = MessageBox.Show(text: message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

		/// <summary>
		/// Copies the specified text to the clipboard and displays a confirmation message.
		/// </summary>
		/// <param name="text">The text to be copied.</param>
		private static void CopyToClipboard(string text)
		{
			try
			{
				// Copy the text to the clipboard
				Clipboard.SetText(text: text);
				_ = MessageBox.Show(text: I10nStrings.CopiedToClipboard, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				// Log the exception and show an error message
				logger.Error(exception: ex, message: ex.Message);
				// Show an error message
				ShowErrorMessage(message: $"File not found: {ex.Message}");
			}
		}

		/// <summary>
		/// Sets the value of the progress bar.
		/// </summary>
		/// <param name="value">The progress value.</param>
		public void SetProgressbar(int value)
		{
			// Validate the value
			// Check if the value is within the range of the progress bar
			// If the value is less than the minimum or greater than the maximum, throw an exception
			if (value < progressBarSplash.Minimum || value > progressBarSplash.Maximum)
			{
				// Log the error and throw an exception
				logger.Error(message: $"Value {value} is out of range for the progress bar. Minimum: {progressBarSplash.Minimum}, Maximum: {progressBarSplash.Maximum}");
				// Throw an exception indicating that the value is out of range
				throw new ArgumentOutOfRangeException(paramName: nameof(value), message: I10nStrings.IndexOutOfRange);
			}
			// Set the value of the progress bar
			progressBarSplash.Value = value;
		}

		#endregion

		#region form event handler

		/// <summary>
		/// Fired when the form loads.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SplashScreenForm_Load(object sender, EventArgs e)
		{
			labelTitle.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = string.Format(format: I10nStrings.VersionTemplate, arg0: AssemblyInfo.AssemblyVersion);

			// Asynchronous initialization
			//await InitializeAsync();
		}

		/// <summary>
		/// Fired when the form closes.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void SplashScreenForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region double-click event handler

		/// <summary>
		/// Occurs when a control is double-clicked to copy the text to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			switch (sender)
			{
				case Label label when label.Text != null:
					CopyToClipboard(text: label.Text);
					break;
				case KryptonLabel kryptonLabel when kryptonLabel.Text != null:
					CopyToClipboard(text: kryptonLabel.Text);
					break;
				case ToolStripLabel labelToolStripCombo when labelToolStripCombo.Text != null:
					CopyToClipboard(text: labelToolStripCombo.Text);
					break;
			}
		}

		#endregion

		#region asynchronous initialization

		/// <summary>
		/// Initializes the application asynchronously.
		/// </summary>
		/// <returns>A task that represents the asynchronous initialization.</returns>
		private async Task InitializeAsync()
		{
			await Task.Run(action: static () => Thread.Sleep(millisecondsTimeout: 2000));
			Invoke(method: new Action(Close));
		}

		#endregion
	}
}