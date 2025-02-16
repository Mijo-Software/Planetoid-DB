using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DownloadUpdateForm : KryptonForm
	{
		private readonly string strFilenameMpcorb = Properties.Resources.FilenameMpcorb;
		private readonly string strFilenameMpcorbTemp = Properties.Resources.FilenameMpcorbTemp;
		private readonly Uri uriMPCORB = new(uriString: Properties.Resources.MpcorbUrl);
		private readonly WebClient webClient = new();

		private static readonly HttpClient client = new();

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public DownloadUpdateForm() => InitializeComponent();

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
		/// <param name="uri"></param>
		/// <returns></returns>
		private static DateTime GetLastModified(Uri uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			return response.StatusCode == HttpStatusCode.OK ? response.LastModified : new DateTime(year: 0, month: 0, day: 0, hour: 0, minute: 0, second: 0);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		private static long GetContentLength(Uri uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			return response.StatusCode == HttpStatusCode.OK ? Convert.ToInt64(value: response.ContentLength) : 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetStatusbar(string? text)
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

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_Load(object? sender, EventArgs? e)
		{
			labelStatusValue.Text = I10nStrings.StatusNothingToDoText;
			labelDateValue.Text = labelSizeValue.Text = labelSourceValue.Text = "";
			labelDateValue.Visible = labelSizeValue.Visible = labelSizeValue.Visible = labelSourceValue.Visible = buttonCancelDownload.Enabled = false;
			labelDownload.Text = I10nStrings.NumberZero + I10nStrings.PercentSign;
			webClient.Proxy = null;
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_FormClosed(object? sender, FormClosedEventArgs? e)
		{
			webClient.CancelAsync();
			webClient.Dispose();
			Dispose();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProgressChanged(object? sender, DownloadProgressChangedEventArgs e)
		{
			progressBarDownload.Value = e.ProgressPercentage;
			labelDownload.Text = e.ProgressPercentage.ToString() + I10nStrings.PercentSign;
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: e.ProgressPercentage, progressMax: 100);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Completed(object? sender, AsyncCompletedEventArgs e)
		{
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
			if (e.Error == null)
			{
				labelStatusValue.Text = I10nStrings.StatusRefreshingDatabaseText;
				File.Delete(path: strFilenameMpcorb);
				File.Copy(sourceFileName: strFilenameMpcorbTemp, destFileName: strFilenameMpcorb);
				labelStatusValue.Text = I10nStrings.StatusDownloadCompleteText;
				buttonDownload.Enabled = buttonCheckForUpdate.Enabled = true;
				DialogResult = DialogResult.OK;
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object? sender, EventArgs? e) => ClearStatusbar();

		#endregion

		#region Click event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			}
			catch (Exception ex)
			{
				labelStatusValue.Text = $"{I10nStrings.StatusUnknownError} {ex.Message}";
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				_ = MessageBox.Show(text: ex.Message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error, defaultButton: MessageBoxDefaultButton.Button1);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancelDownload_Click(object? sender, EventArgs? e) => webClient.CancelAsync();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_FormClosing(object? sender, FormClosingEventArgs? e)
		{
			webClient.CancelAsync();
			if (File.Exists(path: strFilenameMpcorbTemp))
			{
				File.Delete(path: strFilenameMpcorbTemp);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCheckForUpdate_Click(object? sender, EventArgs? e) => ShowMpcorbDatCheck();

		#endregion

		#region DoubleClick event handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyToClipboard_DoubleClick(object? sender, EventArgs? e)
		{
			switch (sender)
			{
				case Label label: CopyToClipboard(text: label.Text); break;
				case KryptonLabel kryptonLabel: CopyToClipboard(text: kryptonLabel.Text); break;
				case ToolStripLabel labelToolStripCombo: CopyToClipboard(text: labelToolStripCombo.Text); break;
			}
		}

		#endregion
	}
}
