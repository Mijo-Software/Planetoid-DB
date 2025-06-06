﻿using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using Krypton.Toolkit;
using NLog;
using static Planetoid_DB.Properties.Resources;
using static Planetoid_DB.Properties.Settings;

namespace Planetoid_DB
{
	/// <summary>
	/// Form to handle downloading updates for the application.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DownloadAstorbDatForm : KryptonForm
	{
		// NLog logger instance
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		// Filename for the ASTORB data file
		private readonly string strFilenameAstorb = FilenameAstorb;

		// Temporary filename for the ASTORB data file during download
		private readonly string strFilenameAstorbTemp = FilenameAstorbTemp;

		// URI for the ASTORB data file
		private readonly Uri strUriAstorb = new(uriString: Default.systemAstorbDatGzUrl);

		// WebClient instance for handling the download
		[Obsolete(message: "Obsolete")] private readonly WebClient webClient = new();
		// Replace the WebClient instance with HttpClient and refactor the code accordingly.
		private static readonly HttpClient HttpClient = new();

		// Flag to indicate if a download is in progress
		private bool isBusy;

		// Static HttpClient instance for making HTTP requests
		private static readonly HttpClient Client = new();

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadAstorbDatForm"/> class.
		/// </summary>
		public DownloadAstorbDatForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += DownloadAstorbDatForm_KeyDown;
			KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region helper methods

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
		/// Extracts a GZIP-compressed file to a specified output file.
		/// </summary>
		private static void ExtractGzipFile(string gzipFilePath, string outputFilePath)
		{
			// Open the gzip file and create a new file stream for the output file
			using FileStream originalFileStream = new(path: gzipFilePath, mode: FileMode.Open, access: FileAccess.Read);
			// Create a new file stream for the output file
			using FileStream decompressedFileStream = new(path: outputFilePath, mode: FileMode.Create, access: FileAccess.Write);
			// Create a new GZipStream for decompression
			using GZipStream decompressionStream = new(stream: originalFileStream, mode: CompressionMode.Decompress);
			// Copy the decompressed data to the output file stream
			decompressionStream.CopyTo(destination: decompressedFileStream);
		}

		/// <summary>
		/// Gets the last modified date of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The last modified date of the URI.</returns>
		private static DateTime GetLastModified(Uri uri)
		{
			try
			{
				// Create a new HttpRequestMessage with the HEAD method and the specified URI
				HttpRequestMessage request = new(method: HttpMethod.Head, requestUri: uri);
				// Send the request and get the response
				var response = Client.Send(request: request);
				// Check if the response is successful and return the last modified date
				// If the response is not successful, return DateTime.MinValue
				// If the response is successful, return the last modified date or DateTime.MinValue if not available
				return response.IsSuccessStatusCode ? response.Content.Headers.LastModified?.UtcDateTime ?? DateTime.MinValue : DateTime.MinValue;
			}
			// Catch any exceptions that occur during the request
			catch (Exception ex)
			{
				// Log the exception and show an error message
				Logger.Error(exception: ex, message: "Error retrieving last modified date.");
				// Show an error message with the exception message
				ShowErrorMessage(message: $"Error retrieving last modified date: {ex.Message}");
				// Return DateTime.MinValue to indicate an error
				return DateTime.MinValue;
			}
		}

		/// <summary>
		/// Gets the content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The content length of the URI.</returns>
		private static long GetContentLength(Uri uri)
		{
			try
			{
				// Create a new HttpRequestMessage with the HEAD method and the specified URI
				// Send the request and get the response
				// If the response is successful, return the content length or 0 if not available
				// If the response is not successful, return 0
				HttpRequestMessage request = new(method: HttpMethod.Head, requestUri: uri);
				// Send the request using the HttpClient instance
				var response = Client.Send(request: request);
				// Check if the response is successful and return the content length
				return response.IsSuccessStatusCode ? response.Content.Headers.ContentLength ?? 0 : 0;
			}
			// Catch any exceptions that occur during the request
			catch (Exception ex)
			{
				// Log the exception and show an error message
				Logger.Error(exception: ex, message: "Error retrieving content length.");
				// Show an error message with the exception message
				ShowErrorMessage(message: $"Error retrieving content length: {ex.Message}");
				// Return 0 to indicate an error
				return 0;
			}
		}

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
			if (string.IsNullOrWhiteSpace(value: text)) return;
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

		/// <summary>
		/// Shows the ASTORB data check form.
		/// </summary>
		private static void ShowAstorbDatCheck()
		{
			// Check if there is an internet connection available
			// If there is, create and show the CheckAstorbDatForm
			// Otherwise, log the error and show an error message
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				// Create and show the CheckAstorbDatForm
				using CheckAstorbDatForm formCheckAstorbDat = new();
				// Show the form as a dialog
				_ = formCheckAstorbDat.ShowDialog();
			}
			else
			{
				// Log the error if there is no internet connection
				Logger.Error(message: "No internet connection available.");
				// Show an error message if there is no internet connection
				ShowErrorMessage(message: I10nStrings.NoInternetConnectionText);
			}
		}

		/// <summary>
		/// Handles the DownloadProgressChanged event of the WebClient control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DownloadProgressChangedEventArgs"/> instance containing the event data.</param>
		private void ProgressChanged(object? sender, DownloadProgressChangedEventArgs e)
		{
			// Set the progress bar style to continuous
			progressBarDownload.Value = e.ProgressPercentage;
			// Update the label with the current progress percentage
			labelDownload.Text = e.ProgressPercentage + I10nStrings.PercentSign;
			// Update the status bar with the current progress
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: e.ProgressPercentage, progressMax: 100);
		}

		/// <summary>
		/// Handles the DownloadFileCompleted event of the WebClient control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.</param>
		private void Completed(object? sender, AsyncCompletedEventArgs e)
		{
			// Reset the taskbar progress
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
			if (e.Error == null)
			{
				// Set the status to "Refreshing database"
				labelStatusValue.Text = I10nStrings.StatusRefreshingDatabaseText;
				// Delete the existing file if it exists
				File.Delete(path: strFilenameAstorb);
				// Set the progress bar style to marquee
				progressBarDownload.Style = ProgressBarStyle.Marquee;
				// Extract the downloaded GZIP file
				ExtractGzipFile(gzipFilePath: strFilenameAstorbTemp, outputFilePath: strFilenameAstorb);
				// Set the status to "Download complete"
				labelStatusValue.Text = I10nStrings.StatusDownloadCompleteText;
				// Enable the download and check for update buttons
				buttonDownload.Enabled = buttonCheckForUpdate.Enabled = true;
				// Set the dialog result to OK
				DialogResult = DialogResult.OK;
				// Set the busy flag to false
				isBusy = false;
				// Show a message box indicating that the download is complete
				_ = MessageBox.Show(text: I10nStrings.DownloadCompleteText, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			else
			{
				// Handle the error
				labelStatusValue.Text = e.Cancelled ? I10nStrings.StatusDownloadCancelled : $"{I10nStrings.StatusUnknownError} {e.Error}";
				// Clear the labels
				labelSourceValue.Text = labelDateValue.Text = labelSizeValue.Text = string.Empty;
				// Enable the download button
				buttonDownload.Enabled = true;
				// Enable the check for update button
				buttonCheckForUpdate.Enabled = true;
				// Disable the cancel button
				buttonCancelDownload.Enabled = false;
				// Reset the progress bar
				progressBarDownload.Value = 0;
				// Reset the download label
				labelDownload.Text = $"{progressBarDownload.Value}{I10nStrings.PercentSign}";
			}
		}

		#endregion

		#region Form event handler

		/// <summary>
		/// Handles the Load event of the DownloadAstorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

		[Obsolete(message: "Obsolete")]
		private void DownloadAstorbDatForm_Load(object? sender, EventArgs? e)
		{
			// Clear the status bar text
			ClearStatusBar();
			// Set the initial status to "Nothing to do"
			labelStatusValue.Text = I10nStrings.StatusNothingToDoText;
			// Clear the labels
			labelDateValue.Text = labelSizeValue.Text = labelSourceValue.Text = "";
			// Hide the labels and disable the cancel button
			labelDateValue.Visible = labelSizeValue.Visible = labelSizeValue.Visible = labelSourceValue.Visible = buttonCancelDownload.Enabled = false;
			// Set the initial download progress to 0%
			labelDownload.Text = I10nStrings.NumberZero + I10nStrings.PercentSign;
			// Set the proxy to null to avoid using any proxy settings
			webClient.Proxy = null;
			// Event handler for download completion
			webClient.DownloadFileCompleted += Completed;
			// Event handler for download progress
			webClient.DownloadProgressChanged += ProgressChanged;
		}

		/// <summary>
		/// Handles the FormClosed event of the DownloadAstorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
		[Obsolete(message: "Obsolete")]
		private void DownloadAstorbDatForm_FormClosed(object? sender, FormClosedEventArgs? e)
		{
			webClient.CancelAsync();
			webClient.Dispose();
			Dispose();
		}

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
		/// Handles the Leave event of controls to clear the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClearStatusBar_Leave(object? sender, EventArgs? e) => ClearStatusBar();

		#endregion

		#region Click event handlers

		/// <summary>
		/// Handles the Click event of the Download button to start the download process.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		[Obsolete(message: "Obsolete")]
		private void ButtonDownload_Click(object? sender, EventArgs? e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if there is an internet connection available
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				// Log the error if there is no internet connection
				Logger.Error(message: "No internet connection available.");
				// Show an error message if there is no internet connection
				ShowErrorMessage(message: I10nStrings.NoInternetConnectionText);
				return;
			}
			// Disable the download button
			buttonDownload.Enabled = false;
			// Enable the cancel button
			buttonCancelDownload.Enabled = true;
			// Disable the check for update button
			buttonCheckForUpdate.Enabled = false;
			// Set the source value to the URI
			labelSourceValue.Text = strUriAstorb.AbsoluteUri;
			// Make the source value visible
			labelSourceValue.Visible = true;
			// Get the last modified date of the URI
			labelDateValue.Text = GetLastModified(uri: strUriAstorb).ToUniversalTime().ToString(CultureInfo.CurrentCulture);
			// Make the date value visible
			labelDateValue.Visible = true;
			// Set the size value to the content length of the URI
			labelSizeValue.Text = $"{GetContentLength(uri: strUriAstorb):N0} {I10nStrings.BytesText}";
			// Make the size value visible
			labelSizeValue.Visible = true;
			// Set the status value to "Try to connect"
			labelStatusValue.Text = I10nStrings.StatusTryToConnect;
			//Try to download the file
			try
			{
				// Set the status value to "Downloading"
				labelStatusValue.Text = I10nStrings.StatusDownloading;
				// Start the download asynchronously
				webClient.DownloadFileAsync(address: strUriAstorb, fileName: strFilenameAstorbTemp);
				// Set the busy flag to true
				isBusy = true;
			}
			// Catch any exceptions that occur during the download
			catch (Exception ex)
			{
				// Set the busy flag to false
				isBusy = false;
				// Set the status value to "Unknown error"
				labelStatusValue.Text = $"{I10nStrings.StatusUnknownError} {ex.Message}";
				// Enable the download button
				buttonDownload.Enabled = true;
				// Enable the check for update button
				buttonCheckForUpdate.Enabled = true;
				// Log and show an error message
				Logger.Error(exception: ex, message: ex.Message);
				ShowErrorMessage(message: $"{I10nStrings.StatusUnknownError} {ex.Message}");
			}
		}

		// Update the ButtonDownload_Click method to use HttpClient for downloading the file.
		private async void ButtonDownload2_Click(object? sender, EventArgs? e)
		{
			ArgumentNullException.ThrowIfNull(argument: sender);

			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				Logger.Error(message: "No internet connection available.");
				ShowErrorMessage(message: I10nStrings.NoInternetConnectionText);
				return;
			}

			buttonDownload.Enabled = false;
			buttonCancelDownload.Enabled = true;
			buttonCheckForUpdate.Enabled = false;

			labelSourceValue.Text = strUriAstorb.AbsoluteUri;
			labelSourceValue.Visible = true;

			labelDateValue.Text = GetLastModified(uri: strUriAstorb).ToUniversalTime().ToString();
			labelDateValue.Visible = true;

			labelSizeValue.Text = $"{GetContentLength(uri: strUriAstorb):N0} {I10nStrings.BytesText}";
			labelSizeValue.Visible = true;

			labelStatusValue.Text = I10nStrings.StatusTryToConnect;

			try
			{
				labelStatusValue.Text = I10nStrings.StatusDownloading;

				using var response = await HttpClient.GetAsync(requestUri: strUriAstorb, completionOption: HttpCompletionOption.ResponseHeadersRead);
				_ = response.EnsureSuccessStatusCode();

				using var contentStream = await response.Content.ReadAsStreamAsync();
				using FileStream fileStream = new(path: strFilenameAstorbTemp, mode: FileMode.Create, access: FileAccess.Write, share: FileShare.None);
				await contentStream.CopyToAsync(destination: fileStream);

				labelStatusValue.Text = I10nStrings.StatusRefreshingDatabaseText;

				File.Delete(path: strFilenameAstorb);
				ExtractGzipFile(gzipFilePath: strFilenameAstorbTemp, outputFilePath: strFilenameAstorb);

				labelStatusValue.Text = I10nStrings.StatusDownloadCompleteText;
				buttonDownload.Enabled = buttonCheckForUpdate.Enabled = true;
				DialogResult = DialogResult.OK;
				isBusy = false;
			}
			catch (Exception ex)
			{
				isBusy = false;
				labelStatusValue.Text = $"{I10nStrings.StatusUnknownError} {ex.Message}";
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				Logger.Error(exception: ex, message: ex.Message);
				ShowErrorMessage(message: $"{I10nStrings.StatusUnknownError} {ex.Message}");
			}
		}

		/// <summary>
		/// Handles the Click event of the Cancel Download button.
		/// Cancels the ongoing download operation if one is in progress.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		[Obsolete(message: "Obsolete")]
		private void ButtonCancelDownload_Click(object? sender, EventArgs? e) => webClient.CancelAsync();

		/// <summary>
		/// Handles the FormClosing event of the DownloadAstorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		[Obsolete(message: "Obsolete")]
		private void DownloadAstorbDatForm_FormClosing(object? sender, FormClosingEventArgs? e)
		{
			// Check if the form is closing and if a download is in progress
			// Cancel the download if it is in progress
			webClient.CancelAsync();
			// Dispose of the WebClient instance
			if (File.Exists(path: strFilenameAstorbTemp))
			{
				// Delete the temporary file if it exists
				File.Delete(path: strFilenameAstorbTemp);
			}
		}

		/// <summary>
		/// Handles the Click event of the Check for Update button to show the ASTORB data check form.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonCheckForUpdate_Click(object? sender, EventArgs? e) => ShowAstorbDatCheck();

		#endregion

		#region DoubleClick event handler

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
		/// Handles the KeyDown event of the DownloadAstorbDatForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DownloadAstorbDatForm_KeyDown(object? sender, KeyEventArgs e)
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
