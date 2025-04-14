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
	public partial class DownloadAstorbDatForm : KryptonForm
	{
		// NLog logger instance
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();
		// Filename for the ASTORB data file
		private readonly string strFilenameAstorb = Properties.Resources.FilenameAstorb;
		// Temporary filename for the ASTORB data file during download
		private readonly string strFilenameAstorbTemp = Properties.Resources.FilenameAstorbTemp;
		// URI for the ASTORB data file
		private readonly Uri uriASTORB = new(uriString: Properties.Settings.Default.systemAstorbDatGzUrl);
		// WebClient instance for handling the download
		private readonly WebClient webClient = new();

		// Flag to indicate if a download is in progress
		private bool isBusy = false;

		// Static HttpClient instance for making HTTP requests
		private static readonly HttpClient client = new();

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadAstorbDatForm"/> class.
		/// </summary>
		public DownloadAstorbDatForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += new KeyEventHandler(DownloadAstorbDatForm_KeyDown);
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
				logger.Error(message: "No internet connection available.");
				// Show an error message if there is no internet connection
				ShowErrorMessage(message: I10nStrings.NoInternetConnectionText);
			}
		}

		#endregion

		#region Form event handler

		/// <summary>
		/// Handles the Load event of the DownloadAstorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

		private void DownloadAstorbDatForm_Load(object? sender, EventArgs? e)
		{
			ClearStatusbar();
			labelStatusValue.Text = I10nStrings.StatusNothingToDoText;
			labelDateValue.Text = labelSizeValue.Text = labelSourceValue.Text = "";
			labelDateValue.Visible = labelSizeValue.Visible = labelSizeValue.Visible = labelSourceValue.Visible = buttonCancelDownload.Enabled = false;
			labelDownload.Text = I10nStrings.NumberZero + I10nStrings.PercentSign;
			webClient.Proxy = null;
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
		}

		/// <summary>
		/// Handles the FormClosed event of the DownloadAstorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
		private void DownloadAstorbDatForm_FormClosed(object? sender, FormClosedEventArgs? e)
		{
			webClient.CancelAsync();
			webClient.Dispose();
			Dispose();
		}

		/// <summary>
		/// Handles the DownloadProgressChanged event of the WebClient control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DownloadProgressChangedEventArgs"/> instance containing the event data.</param>
		private void ProgressChanged(object? sender, DownloadProgressChangedEventArgs e)
		{
			progressBarDownload.Value = e.ProgressPercentage;
			labelDownload.Text = e.ProgressPercentage.ToString() + I10nStrings.PercentSign;
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: e.ProgressPercentage, progressMax: 100);
		}

		/// <summary>
		/// Extracts a GZIP-compressed file to a specified output file.
		/// </summary>
		private static void ExtractGzipFile(string gzipFilePath, string outputFilePath)
		{
			using FileStream originalFileStream = new(path: gzipFilePath, mode: FileMode.Open, access: FileAccess.Read);
			using FileStream decompressedFileStream = new(path: outputFilePath, mode: FileMode.Create, access: FileAccess.Write);
			using GZipStream decompressionStream = new(stream: originalFileStream, mode: CompressionMode.Decompress);
			decompressionStream.CopyTo(destination: decompressedFileStream);
		}

		/// <summary>
		/// Handles the DownloadFileCompleted event of the WebClient control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.</param>
		private void Completed(object? sender, AsyncCompletedEventArgs e)
		{
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
			if (e.Error == null)
			{
				labelStatusValue.Text = I10nStrings.StatusRefreshingDatabaseText;
				File.Delete(path: strFilenameAstorb);
				progressBarDownload.Style = ProgressBarStyle.Marquee;
				ExtractGzipFile(gzipFilePath: strFilenameAstorbTemp, outputFilePath: strFilenameAstorb);
				//File.Copy(sourceFileName: strFilenameAstorbTemp, destFileName: strFilenameAstorb);
				labelStatusValue.Text = I10nStrings.StatusDownloadCompleteText;
				buttonDownload.Enabled = buttonCheckForUpdate.Enabled = true;
				DialogResult = DialogResult.OK;
				isBusy = false;
			}
			else
			{
				labelStatusValue.Text = e.Cancelled ? I10nStrings.StatusDownloadCancelled : $"{I10nStrings.StatusUnknownError} {e.Error}";
				labelSourceValue.Text = labelDateValue.Text = labelSizeValue.Text = string.Empty;
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				buttonCancelDownload.Enabled = false;
				progressBarDownload.Value = 0;
				labelDownload.Text = $"{progressBarDownload.Value}{I10nStrings.PercentSign}";
			}
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
			if (sender is Control control && control.AccessibleDescription != null)
			{
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
			buttonDownload.Enabled = false;
			buttonCancelDownload.Enabled = true;
			buttonCheckForUpdate.Enabled = false;
			labelSourceValue.Text = uriASTORB.AbsoluteUri;
			labelSourceValue.Visible = true;
			labelDateValue.Text = GetLastModified(uri: uriASTORB).ToString(provider: CultureInfo.InvariantCulture);
			labelDateValue.Visible = true;
			labelSizeValue.Text = $"{GetContentLength(uri: uriASTORB)} {I10nStrings.BytesText}";
			labelSizeValue.Visible = true;
			labelStatusValue.Text = I10nStrings.StatusTryToConnect;
			try
			{
				labelStatusValue.Text = I10nStrings.StatusDownloading;
				webClient.DownloadFileAsync(address: uriASTORB, fileName: strFilenameAstorbTemp);
				isBusy = true;
			}
			catch (Exception ex)
			{
				isBusy = false;
				labelStatusValue.Text = $"{I10nStrings.StatusUnknownError} {ex.Message}";
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				_ = MessageBox.Show(text: ex.Message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error, defaultButton: MessageBoxDefaultButton.Button1);
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
		/// Handles the FormClosing event of the DownloadAstorbDatForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		private void DownloadAstorbDatForm_FormClosing(object? sender, FormClosingEventArgs? e)
		{
			webClient.CancelAsync();
			if (File.Exists(path: strFilenameAstorbTemp))
			{
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
			ArgumentNullException.ThrowIfNull(argument: sender);
			if (sender is Control control)
			{
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
			if (!isBusy && e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		#endregion
	}
}
