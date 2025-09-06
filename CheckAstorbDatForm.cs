﻿using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;

using NLog;

using Planetoid_DB.Properties;

namespace Planetoid_DB
{
	/// <summary>
	/// ASTRORB Data Verification Form.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class CheckAstorbDatForm : Form
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger(); // NLog logger instance

		// The HttpClient instance used for making HTTP requests.
		private static readonly HttpClient Client = new();

		#region constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="CheckAstorbDatForm"/> class.
		/// </summary>
		public CheckAstorbDatForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += CheckAstorbDatForm_KeyDown;
			KeyPreview = true; // Ensures the form receives key events before the controls
		}

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

		#region task methods

		/// <summary>
		/// Retrieves the last modified date of the specified URI.
		/// </summary>
		/// <param name="uri">The URI of the resource.</param>
		/// <returns>The date of the last modification or <see cref="DateTime.MinValue"/> in case of an error.</returns>
		private static async Task<DateTime> GetLastModifiedAsync(Uri uri)
		{
			try
			{
				// Send a HEAD request to the specified URI
				HttpResponseMessage response = await Client.SendAsync(request: new HttpRequestMessage(method: HttpMethod.Head, requestUri: uri)).ConfigureAwait(continueOnCapturedContext: false);
				// Check if the response is successful and return the last modified date
				return response.IsSuccessStatusCode ? response.Content.Headers.LastModified?.UtcDateTime ?? DateTime.MinValue : DateTime.MinValue;
			}
			catch (HttpRequestException)
			{
				// Log the exception
				Logger.Error(message: "Error retrieving last modified date.", exception: new HttpRequestException());
				// Show an error message
				ShowErrorMessage(message: new HttpRequestException().Message);
				// Return DateTime.MinValue to indicate an error
				return DateTime.MinValue;
			}
		}

		/// <summary>
		/// The content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI of the resource.</param>
		/// <returns>The content length or 0 in case of error.</returns>
		private static async Task<long> GetContentLengthAsync(Uri uri)
		{
			try
			{
				// Send a HEAD request to the specified URI
				HttpResponseMessage response = await Client.SendAsync(request: new HttpRequestMessage(method: HttpMethod.Head, requestUri: uri)).ConfigureAwait(continueOnCapturedContext: false);
				// Check if the response is successful and return the content length
				return response.IsSuccessStatusCode ? response.Content.Headers.ContentLength ?? 0 : 0;
			}
			catch (HttpRequestException)
			{
				// Log the exception
				Logger.Error(message: "Error retrieving last modified date.", exception: new HttpRequestException());
				// Show an error message
				ShowErrorMessage(message: new HttpRequestException().Message);
				// Log the exception and return 0
				return 0;
			}
		}

		#endregion

		#region form event handler

		/// <summary>
		/// Event handler for loading the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private async void CheckAstorbDatForm_Load(object sender, EventArgs e)
		{
			// Clear the status bar
			ClearStatusBar();
			// URL for the ASTRORB data file
			Uri uriAstorb = new(uriString: Settings.Default.systemAstorbDatUrl);
			// Local file last modified date
			DateTime datetimeFileLocal = DateTime.MinValue;
			// Online file last modified date
			DateTime datetimeFileOnline = await GetLastModifiedAsync(uri: uriAstorb).ConfigureAwait(continueOnCapturedContext: false);
			// Check if the local file exists
			if (!File.Exists(path: Resources.FilenameAstorb))
			{
				// Set the content length and modified date labels to indicate no file found
				labelContentLengthValueLocal.Text = I10nStrings.NoFileFoundText;
				// Set the modified date label to indicate no file found
				labelModifiedDateValueLocal.Text = I10nStrings.NoFileFoundText;
			}
			else
			{
				// Get the last modified date of the local file
				FileInfo fileInfo = new(fileName: Resources.FilenameAstorb);
				// Get the file attributes
				datetimeFileLocal = fileInfo.LastWriteTime;
				// Set the content length and modified date labels to the local file's information
				labelContentLengthValueLocal.Text = $"{fileInfo.Length:N0} {I10nStrings.BytesText}";
				// Set the modified date label to the local file's last write time
				labelModifiedDateValueLocal.Text = datetimeFileLocal.ToString(CultureInfo.CurrentCulture);
			}
			// Set the content length and modified date labels to the online file's information
			labelContentLengthValueOnline.Text = $"{await GetContentLengthAsync(uri: uriAstorb).ConfigureAwait(continueOnCapturedContext: false):N0} {I10nStrings.BytesText}";
			// Set the modified date label to the online file's last modified date
			labelModifiedDateValueOnline.Text = datetimeFileOnline.ToString(CultureInfo.CurrentCulture);
			// Compare the last modified dates of the local and online files
			if (datetimeFileOnline > datetimeFileLocal)
			{
				// Set the label to indicate an update is needed
				labelUpdateNeeded.Values.Image = Resources.silk_new;
				// Set the label text to indicate an update is recommended
				labelUpdateNeeded.Text = I10nStrings.UpdateRecommendedText;
			}
			else
			{
				// Set the label to indicate no update is needed
				labelUpdateNeeded.Values.Image = Resources.silk_decline;
				// Set the label text to indicate no update is needed
				labelUpdateNeeded.Text = I10nStrings.NoUpdateNeededText;
			}
		}

		/// <summary>
		/// Event handler for closing the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void CheckAstorbDatForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region enter event handlers

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

		#region leave event handlers

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e) => ClearStatusBar();

		#endregion

		#region double-click event handlers

		/// <summary>
		/// Event handler for double-clicking a control to copy the text to the clipboard.
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

		/// <summary>
		/// Event handler for double-clicking the "Update Needed" label to check for updates.
		/// Resets the displayed information and reloads the form data.
		/// </summary>
		/// <param name="sender">The event source, typically the label being double-clicked.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LabelUpdateNeeded_DoubleClick(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Reset the displayed information
			labelContentLengthValueLocal.Text = string.Empty;
			labelModifiedDateValueLocal.Text = string.Empty;
			labelContentLengthValueOnline.Text = string.Empty;
			labelModifiedDateValueOnline.Text = string.Empty;
			labelUpdateNeeded.Text = string.Empty;
			labelUpdateNeeded.Values.Image = null;
			// Reload the form data
			CheckAstorbDatForm_Load(sender: sender, e: e);
		}

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CheckAstorbDatForm_KeyDown(object? sender, KeyEventArgs e)
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
