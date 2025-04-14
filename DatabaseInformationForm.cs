using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using Krypton.Toolkit;
using NLog;

namespace Planetoid_DB
{
	/// <summary>
	/// Form to display database information.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DatabaseInformationForm : KryptonForm
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger(); // NLog logger instance

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DatabaseInformationForm"/> class.
		/// </summary>
		public DatabaseInformationForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += new KeyEventHandler(DatabaseInformationForm_KeyDown);
			KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region Local methods

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
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusbar(string text, string additionalInfo = "")
		{
			// Check if the text is not null or whitespace
			if (!string.IsNullOrWhiteSpace(value: text))
			{
				// Set the status bar text and enable it
				labelInformation.Enabled = true;
				labelInformation.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
			}
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusbar()
		{
			// Clear the status bar text and disable it
			labelInformation.Enabled = false;
			labelInformation.Text = string.Empty;
		}

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event of the DatabaseInformationForm control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DatabaseInformationForm_Load(object sender, EventArgs e)
		{
			FileInfo fileInfo = new(fileName: Properties.Resources.FilenameMpcorb);
			FileAttributes attributes = File.GetAttributes(path: fileInfo.FullName);

			bool isArchive = (attributes & FileAttributes.Archive) == FileAttributes.Archive;
			bool isCompressed = (attributes & FileAttributes.Compressed) == FileAttributes.Compressed;
			bool isHidden = (attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
			bool isReadOnly = (attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
			bool isSystem = (attributes & FileAttributes.System) == FileAttributes.System;

			labelNameValue.Text = fileInfo.Name;
			labelDirectoryValue.Text = fileInfo.DirectoryName;
			labelSizeValue.Text = $"{fileInfo.Length} {I10nStrings.BytesText}";
			labelDateCreatedValue.Text = fileInfo.CreationTime.ToString(provider: CultureInfo.InvariantCulture);
			labelDateAccessedValue.Text = fileInfo.LastAccessTime.ToString(provider: CultureInfo.InvariantCulture);
			labelDateWritedValue.Text = fileInfo.LastWriteTime.ToString(provider: CultureInfo.InvariantCulture);

			StringBuilder attributesText = new(value: $"({fileInfo.Attributes})");
			if (isArchive)
			{
				_ = attributesText.Insert(0, value: "archive ");
			}

			if (isCompressed)
			{
				_ = attributesText.Insert(0, value: "compressed ");
			}

			if (isHidden)
			{
				_ = attributesText.Insert(0, value: "hidden ");
			}

			if (isReadOnly)
			{
				_ = attributesText.Insert(0, value: "readonly ");
			}

			if (isSystem)
			{
				_ = attributesText.Insert(0, value: "system ");
			}

			labelAttributesValue.Text = attributesText.ToString();
		}

		/// <summary>
		/// Handles the FormClosed event of the DatabaseInformationForm control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void DatabaseInformationForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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
		/// Handles the Leave event of a control to clear the status bar.
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

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the DatabaseInformationForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DatabaseInformationForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		#endregion
	}
}
