using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using Krypton.Toolkit;
using NLog;

namespace Planetoid_DB
{
	/// <summary>
	/// Form to handle downloading updates for the application.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DownloadMpcorbDatForm : KryptonForm
	{
		// NLog logger instance
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		// Filename for the MPCORB data file
		private readonly string strFilenameMpcorb = Properties.Resources.FilenameMpcorb;

		// Temporary filename for the MPCORB data file during download
		private readonly string strFilenameMpcorbTemp = Properties.Resources.FilenameMpcorbTemp;

		// URI for the MPCORB data file
		private readonly Uri uriMPCORB = new(uriString: Properties.Settings.Default.systemMpcorbDatGzUrl);

		// WebClient instance for handling the download
		private readonly WebClient webClient = new();

		// Flag to indicate if a download is in progress
		private bool isBusy = false;

		// Static HttpClient instance for making HTTP requests
		private static readonly HttpClient client = new();

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadMpcorbDatForm"/> class.
		/// </summary>
		public DownloadMpcorbDatForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += DownloadMpcorbDatForm_KeyDown;
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
			// Create a new HttpWebRequest to the specified URI
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			// Set the method to HEAD to only retrieve headers
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			// Check if the response status code is OK (200)
			// If so, return the last modified date
			// Otherwise, return a default DateTime value
			// Note: The default DateTime value is not a valid date, so it should be handled appropriately
			// in the calling code
			// The default DateTime value is 1/1/0001 12:00:00 AM
			return response.StatusCode == HttpStatusCode.OK ? response.LastModified : new DateTime(year: 0, month: 0, day: 0, hour: 0, minute: 0, second: 0);
		}

		/// <summary>
		/// Gets the content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The content length of the URI.</returns>
		private static long GetContentLength(Uri uri)
		{
			// Create a new HttpWebRequest to the specified URI
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			// Set the method to HEAD to only retrieve headers
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			// Check if the response status code is OK (200)
			// If so, return the content length
			// Otherwise, return 0
			// Note: The content length is the size of the response body in bytes
			return response.StatusCode == HttpStatusCode.OK ? Convert.ToInt64(value: response.ContentLength) : 0;
		}

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
				HttpResponseMessage response = await client.SendAsync(request: new HttpRequestMessage(method: HttpMethod.Head, requestUri: uri)).ConfigureAwait(continueOnCapturedContext: false);
				// Check if the response is successful and return the last modified date
				return response.IsSuccessStatusCode ? response.Content.Headers.LastModified?.UtcDateTime ?? DateTime.MinValue : DateTime.MinValue;
			}
			catch (HttpRequestException)
			{
				// Log the exception
				logger.Error(message: "Error retrieving last modified date.", exception: new HttpRequestException());
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
				HttpResponseMessage response = await client.SendAsync(request: new HttpRequestMessage(method: HttpMethod.Head, requestUri: uri)).ConfigureAwait(continueOnCapturedContext: false);
				// Check if the response is successful and return the content length
				return response.IsSuccessStatusCode ? response.Content.Headers.ContentLength ?? 0 : 0;
			}
			catch (HttpRequestException)
			{
				// Log the exception
				logger.Error(message: "Error retrieving last modified date.", exception: new HttpRequestException());
				// Show an error message
				ShowErrorMessage(message: new HttpRequestException().Message);
				// Log the exception and return 0
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

		/// <summary>
		/// Shows the MPCORB data check form.
		/// </summary>
		private static void ShowMpcorbDatCheck()
		{
			// Check if there is an internet connection available
			// If there is, create and show the CheckMpcorbDatForm
			// Otherwise, log the error and show an error message
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				// Create and show the CheckMpcorbDatForm
				using CheckMpcorbDatForm formCheckMpcorbDat = new();
				// Show the form as a dialog
				_ = formCheckMpcorbDat.ShowDialog();
			}
			else
			{
				// Log the error if there is no internet connection
				logger.Error(message: "No internet connection available.");
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
			labelDownload.Text = e.ProgressPercentage.ToString() + I10nStrings.PercentSign;
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
				File.Delete(path: strFilenameMpcorb);
				// Set the progress bar style to marquee
				progressBarDownload.Style = ProgressBarStyle.Marquee;
				// Extract the downloaded GZIP file
				ExtractGzipFile(gzipFilePath: strFilenameMpcorbTemp, outputFilePath: strFilenameMpcorb);
				// Set the status to "Download complete"
				labelStatusValue.Text = I10nStrings.StatusDownloadCompleteText;
				// Enable the download and check for update buttons
				buttonDownload.Enabled = buttonCheckForUpdate.Enabled = true;
				// Set the dialog result to OK
				DialogResult = DialogResult.OK;
				// Set the busy flag to false
				isBusy = false;
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
		/// Handles the Load event of the DownloadMpcorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

		private void DownloadMpcorbDatForm_Load(object? sender, EventArgs? e)
		{
			// Clear the status bar text
			ClearStatusbar();
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
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			// Event handler for download progress
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
		}

		/// <summary>
		/// Handles the FormClosed event of the DownloadMpcorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
		private void DownloadMpcorbDatForm_FormClosed(object? sender, FormClosedEventArgs? e)
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
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			// Check if the sender is a control and has an accessible description
			if (sender is Control control && control.AccessibleDescription != null)
			{
				// Set the status bar text to the control's accessible description
				SetStatusbar(text: control.AccessibleDescription);
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Handles the Leave event of controls to clear the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClearStatusbar_Leave(object? sender, EventArgs? e) => ClearStatusbar();

		#endregion

		#region Click event handlers

		/// <summary>
		/// Handles the Click event of the Download button to start the download process.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonDownload_Click(object? sender, EventArgs? e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if there is an internet connection available
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				// Log the error if there is no internet connection
				logger.Error(message: "No internet connection available.");
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
			labelSourceValue.Text = uriMPCORB.AbsoluteUri;
			// Make the source value visible
			labelSourceValue.Visible = true;
			// Get the last modified date of the URI
			labelDateValue.Text = GetLastModified(uri: uriMPCORB).ToString(provider: CultureInfo.InvariantCulture);
			// Make the date value visible
			labelDateValue.Visible = true;
			// Set the size value to the content length of the URI
			labelSizeValue.Text = $"{GetContentLength(uri: uriMPCORB)} {I10nStrings.BytesText}";
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
				webClient.DownloadFileAsync(address: uriMPCORB, fileName: strFilenameMpcorbTemp);
				// Set the busy flag to true
				isBusy = true;
			}
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
				logger.Error(exception: ex, message: ex.Message);
				ShowErrorMessage(message: $"{I10nStrings.StatusUnknownError} {ex.Message}");
			}
		}

		/// <summary>
		/// Handles the Click event of the Cancel Download button.
		/// Cancels the ongoing download operation if one is in progress.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonCancelDownload_Click(object? sender, EventArgs? e) => webClient.CancelAsync();

		/// <summary>
		/// Handles the FormClosing event of the DownloadMpcorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		private void DownloadMpcorbDatForm_FormClosing(object? sender, FormClosingEventArgs? e)
		{
			// Check if the form is closing and if a download is in progress
			// Cancel the download if it is in progress
			webClient.CancelAsync();
			// Dispose of the WebClient instance
			if (File.Exists(path: strFilenameMpcorbTemp))
			{
				// Delete the temporary file if it exists
				File.Delete(path: strFilenameMpcorbTemp);
			}
		}

		/// <summary>
		/// Handles the Click event of the Check for Update button to show the MPCORB data check form.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonCheckForUpdate_Click(object? sender, EventArgs? e) => ShowMpcorbDatCheck();

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
		/// Handles the KeyDown event of the DownloadMpcorbDatForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DownloadMpcorbDatForm_KeyDown(object? sender, KeyEventArgs e)
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
