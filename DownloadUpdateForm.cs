using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Form to handle downloading updates for the application.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DownloadUpdateForm : KryptonForm
	{
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
		/// Initializes a new instance of the <see cref="DownloadUpdateForm"/> class.
		/// </summary>
		public DownloadUpdateForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(DownloadUpdateForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Gets the last modified date of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The last modified date of the URI.</returns>
		private static DateTime GetLastModified(Uri uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			return response.StatusCode == HttpStatusCode.OK ? response.LastModified : new DateTime(year: 0, month: 0, day: 0, hour: 0, minute: 0, second: 0);
		}

		/// <summary>
		/// Gets the content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The content length of the URI.</returns>
		private static long GetContentLength(Uri uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			return response.StatusCode == HttpStatusCode.OK ? Convert.ToInt64(value: response.ContentLength) : 0;
		}

		/// <summary>
		/// Gets the last modified date of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The last modified date of the URI.</returns>
		private static async Task<DateTime> GetLastModifiedAsync(Uri uri)
		{
			try
			{
				using HttpResponseMessage response = await client.GetAsync(requestUri: uri, completionOption: HttpCompletionOption.ResponseHeadersRead);
				return response.IsSuccessStatusCode ? response.Content.Headers.LastModified?.UtcDateTime ?? DateTime.MinValue : DateTime.MinValue;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(message: $"Error getting last modified date: {ex.Message}");
				return DateTime.MinValue;
			}
		}

		/// <summary>
		/// Gets the content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The content length of the URI.</returns>
		private static async Task<long> GetContentLengthAsync(Uri uri)
		{
			try
			{
				using HttpResponseMessage response = await client.GetAsync(requestUri: uri, completionOption: HttpCompletionOption.ResponseHeadersRead);
				return response.IsSuccessStatusCode ? response.Content.Headers.ContentLength ?? 0 : 0;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(message: $"Error getting content length: {ex.Message}");
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

		/// <summary>
		/// Shows the MPCORB data check form.
		/// </summary>
		private static void ShowMpcorbDatCheck()
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				_ = MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				using CheckMpcorbDatForm formCeckMpcorbDat = new();
				_ = formCeckMpcorbDat.ShowDialog();
			}
		}

		#endregion

		#region Form event handler

		/// <summary>
		/// Handles the Load event of the DownloadUpdateForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

		private void DownloadUpdateForm_Load(object? sender, EventArgs? e)
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
		/// Handles the FormClosed event of the DownloadUpdateForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
		private void DownloadUpdateForm_FormClosed(object? sender, FormClosedEventArgs? e)
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
				File.Delete(path: strFilenameMpcorb);
				progressBarDownload.Style = ProgressBarStyle.Marquee;
				ExtractGzipFile(gzipFilePath: strFilenameMpcorbTemp, outputFilePath: strFilenameMpcorb);
				//File.Copy(sourceFileName: strFilenameMpcorbTemp, destFileName: strFilenameMpcorb);
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
			labelSourceValue.Text = uriMPCORB.AbsoluteUri;
			labelSourceValue.Visible = true;
			labelDateValue.Text = GetLastModified(uri: uriMPCORB).ToString(provider: CultureInfo.InvariantCulture);
			labelDateValue.Visible = true;
			labelSizeValue.Text = $"{GetContentLength(uri: uriMPCORB)} {I10nStrings.BytesText}";
			labelSizeValue.Visible = true;
			labelStatusValue.Text = I10nStrings.StatusTryToConnect;
			try
			{
				labelStatusValue.Text = I10nStrings.StatusDownloading;
				webClient.DownloadFileAsync(address: uriMPCORB, fileName: strFilenameMpcorbTemp);
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
		/// Handles the FormClosing event of the DownloadUpdateForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		private void ButtonCancelDownload_Click(object? sender, EventArgs? e) => webClient.CancelAsync();

		/// <summary>
		/// Handles the FormClosing event of the DownloadUpdateForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		private void DownloadUpdateForm_FormClosing(object? sender, FormClosingEventArgs? e)
		{
			webClient.CancelAsync();
			if (File.Exists(path: strFilenameMpcorbTemp))
			{
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
			ArgumentNullException.ThrowIfNull(argument: sender);
			if (sender is Control control)
			{
				CopyToClipboard(text: control.Text);
			}
		}

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DownloadUpdateForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (!isBusy && e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion

	}
}
