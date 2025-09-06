﻿using System.Diagnostics;
using System.IO;
using System.Text;
using NLog;
using Planetoid_DB.Properties;

namespace Planetoid_DB
{
	/// <summary>
	/// Form to display database information.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DatabaseInformationForm : Form
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger(); // NLog logger instance

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DatabaseInformationForm"/> class.
		/// </summary>
		public DatabaseInformationForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += DatabaseInformationForm_KeyDown;
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
				Logger.Error(exception: ex, message: ex.Message);
				// Show an error message
				ShowErrorMessage(message: $"File not found: {ex.Message}");
			}
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusBar(string text, string additionalInfo = "")
		{
			// Check if the text is not null or whitespace
			if (string.IsNullOrWhiteSpace(value: text))
			{
				return;
			}
			// Set the status bar text and enable it
			labelInformation.Enabled = true;
			labelInformation.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusBar()
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
			// Path to the database file
			FileInfo fileInfo = new(fileName: Resources.FilenameMpcorb);
			// Get the file attributes
			FileAttributes attributes = File.GetAttributes(path: fileInfo.FullName);
			// Check if the file is an archive
			bool isArchive = (attributes & FileAttributes.Archive) == FileAttributes.Archive;
			// Check if the file is compressed
			bool isCompressed = (attributes & FileAttributes.Compressed) == FileAttributes.Compressed;
			// Check if the file is hidden
			bool isHidden = (attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
			// Check if the file is read-only
			bool isReadOnly = (attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
			// Check if the file is a system file
			bool isSystem = (attributes & FileAttributes.System) == FileAttributes.System;
			// Set the file information in the labels
			labelNameValue.Text = fileInfo.Name;
			// Set the file name in the label
			labelDirectoryValue.Text = fileInfo.DirectoryName;
			// Set the file size in the label
			labelSizeValue.Text = $"{fileInfo.Length:N0} {I10nStrings.BytesText}";
			// Set the file type in the label
			labelDateCreatedValue.Text = fileInfo.CreationTime.ToString();
			// Set the file creation time in the label
			labelDateAccessedValue.Text = fileInfo.LastAccessTime.ToString();
			// Set the file last access time in the label
			labelDateWritedValue.Text = fileInfo.LastWriteTime.ToString();
			// Set the file attributes in the label
			StringBuilder attributesText = new(value: $"({fileInfo.Attributes})");
			// Check if the file is an archive, compressed, hidden, read-only, or a system file
			// and prepend the corresponding attribute name to the attributes text
			// Check if the file is an archive
			if (isArchive)
			{
				// Prepend "archive" to the attributes text
				_ = attributesText.Insert(index: 0, value: "archive, ");
			}
			// Check if the file is compressed
			if (isCompressed)
			{
				// Prepend "compressed" to the attributes text
				_ = attributesText.Insert(index: 0, value: "compressed, ");
			}
			// Check if the file is hidden
			if (isHidden)
			{
				// Prepend "hidden" to the attributes text
				_ = attributesText.Insert(index: 0, value: "hidden, ");
			}
			// Check if the file is read-only
			if (isReadOnly)
			{
				// Prepend "read-only" to the attributes text
				_ = attributesText.Insert(index: 0, value: "readonly, ");
			}
			// Check if the file is a system file
			if (isSystem)
			{
				// Prepend "system" to the attributes text
				_ = attributesText.Insert(index: 0, value: "system, ");
			}
			// Set the file attributes text in the label
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
		private void SetStatusBar_Enter(object sender, EventArgs e)
		{
			// Set the status bar text based on the sender's accessible description
			switch (sender)
			{
				// If the sender is a control with an accessible description, set the status bar text
				// If the sender is a ToolStripItem with an accessible description, set the status bar text
				case Control { AccessibleDescription: not null } control:
					SetStatusBar(text: control.AccessibleDescription);
					break;
				case ToolStripItem { AccessibleDescription: not null } item:
					SetStatusBar(text: item.AccessibleDescription);
					break;
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Handles the Leave event of a control to clear the status bar.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e) => ClearStatusBar();

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// Called when a control is double-clicked to copy the text to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			if (sender is Control control)
			{
				// Copy the text to the clipboard
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
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the Escape key is pressed
			if (e.KeyCode == Keys.Escape)
			{
				// Close the form
				Close();
			}
		}

		#endregion
	}
}
