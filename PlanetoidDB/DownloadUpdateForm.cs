using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PlanetoidDB
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DownloadUpdateForm : Form
  {
		private string
			strFilenameMPCORB = Planetoid_DB.Properties.Resources.strFilenameMPCORB,
			strFilenameMPCORBtemp = Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp;
		private Uri uriMPCORB = new Uri(uriString: Planetoid_DB.Properties.Resources.strMpcorbUrl);
		private WebClient webClient = new WebClient();

		/// <summary>
		/// 
		/// </summary>
		public DownloadUpdateForm() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_Load(object sender, EventArgs e)
    {
      labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusNothingToDoText;
      labelDateValue.Text = ""; labelDateValue.Visible = false;
      labelSizeValue.Text = ""; labelSizeValue.Visible = false;
      labelSourceValue.Text = ""; labelSourceValue.Visible = false;
      labelDownload.Text = Planetoid_DB.I10nStrings.strNumberZero + Planetoid_DB.I10nStrings.strPercentSign;
      buttonCancelDownload.Enabled = false;
      webClient.Proxy = null;
      webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_FormClosed(object sender, FormClosedEventArgs e) => this.Dispose();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      progressBarDownload.Value = e.ProgressPercentage;
      labelDownload.Text = e.ProgressPercentage.ToString() + Planetoid_DB.I10nStrings.strPercentSign;
      TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: e.ProgressPercentage, progressMax: 100);
    }

    /// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Completed(object sender, AsyncCompletedEventArgs e)
    {
			TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: 0, progressMax: 100);
			if (e.Error == null)
			{
				labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusRefreshingDatabaseText;
				File.Delete(path: strFilenameMPCORB);
				File.Copy(sourceFileName: strFilenameMPCORBtemp, destFileName: strFilenameMPCORB);
				labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusDownloadCompleteText;
				MessageBox.Show(text: Planetoid_DB.I10nStrings.strDownloadCompleteText, caption: Planetoid_DB.I10nStrings.strCompleteCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				if (e.Cancelled)
				{
					labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusDownloadCancelled;
				}
				else
				{
					labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusUnknownError + " " + e.Error;
				}
				labelSourceValue.Text = "";
				labelDateValue.Text = "";
				labelSizeValue.Text = "";
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				buttonCancelDownload.Enabled = false;
				progressBarDownload.Value = 0;
				labelDownload.Text = progressBarDownload.Value.ToString() + Planetoid_DB.I10nStrings.strPercentSign;
			}
    }

		/// <summary>
		/// 
		/// </summary>
		private void CheckMpcorbDat()
		{
			DateTime datetimeFileLocal = DateTime.MinValue;
			DateTime datetimeFileOnline = GetLastModified(uri: uriMPCORB);
			string strInfoMpcorbDatLocal = Planetoid_DB.I10nStrings.strInfoMpcorbDatLocal + ":\n\r\n\r";
			if (File.Exists(path: strFilenameMPCORB))
			{
				FileInfo fileInfo = new FileInfo(fileName: strFilenameMPCORB);
				long fileSize = fileInfo.Length;
				datetimeFileLocal = fileInfo.CreationTime;
				datetimeFileOnline = GetLastModified(uri: uriMPCORB);
				strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "  " + Planetoid_DB.I10nStrings.strUrlText + ": " + fileInfo.FullName;
				strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "\n\r  " + Planetoid_DB.I10nStrings.strContenLenghtText + ": " + fileSize.ToString() + " " + Planetoid_DB.I10nStrings.strBytesText;
				strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "\n\r  " + Planetoid_DB.I10nStrings.strLastModifiedText + ": " + datetimeFileLocal;
			}
			else
			{
				strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "  " + Planetoid_DB.I10nStrings.strNoFileFoundText;
			}

			string strInfoMpcorbDatOnline = Planetoid_DB.I10nStrings.strInfoMpcorbDatOnline + ":\n\r\n\r";
			strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "  " + Planetoid_DB.I10nStrings.strUrlText + ": " + uriMPCORB;
			strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "\n\r  " + Planetoid_DB.I10nStrings.strContenLenghtText + ": " + GetContentLength(uri: uriMPCORB).ToString() + " " + Planetoid_DB.I10nStrings.strBytesText;
			strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "\n\r  " + Planetoid_DB.I10nStrings.strLastModifiedText + ": " + datetimeFileOnline;

			string strUpdate = "";
			MessageBoxIcon mbi = MessageBoxIcon.None;
			if (datetimeFileOnline > datetimeFileLocal)
			{
				strUpdate = Planetoid_DB.I10nStrings.strUpdateAvailabletText;
				mbi = MessageBoxIcon.Warning;
			}
			else
			{
				strUpdate = Planetoid_DB.I10nStrings.strNoUpdateNeededText;
				mbi = MessageBoxIcon.Information;
			}
			MessageBox.Show(text: strInfoMpcorbDatLocal + "\n\r\n\r" + strInfoMpcorbDatOnline + "\n\r\n\r" + strUpdate, caption: Planetoid_DB.I10nStrings.strMpcorbDatInformationCaption, buttons: MessageBoxButtons.OK, icon: mbi);
		}

    /// <summary>
		/// 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		private DateTime GetLastModified(Uri uri)
    {
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uri);
      HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			resp.Close();
      return resp.LastModified;
    }

    /// <summary>
		/// 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		private long GetContentLength(Uri uri)
    {
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			resp.Close();
			return Convert.ToInt64(value: resp.ContentLength);
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(text: Planetoid_DB.I10nStrings.strCopiedToClipboard, caption: "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetLabelText(string text)
		{
			if (text == "")
			{
				labelHelp.Enabled = false;
			}
			else
			{
				labelHelp.Enabled = true;
			}
			labelHelp.Text = text;
		}

		#region Enter-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStatusText_Enter(object sender, EventArgs e) => SetLabelText(text: labelStatusText.AccessibleDescription);

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateText_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateText.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSourceText_Enter(object sender, EventArgs e) => SetLabelText(text: labelSourceText.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSizeText_Enter(object sender, EventArgs e) => SetLabelText(text: labelSizeText.AccessibleDescription);
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStatusValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelStatusValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSourceValue_Enter(object sender, EventArgs e) => SetLabelText(text: progressBarDownload.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSizeValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelSizeValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDownload_Enter(object sender, EventArgs e) => SetLabelText(text: labelDownload.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCheckForUpdate_Enter(object sender, EventArgs e) => SetLabelText(text: buttonCheckForUpdate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonDownload_Enter(object sender, EventArgs e) => SetLabelText(text: buttonDownload.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancelDownload_Enter(object sender, EventArgs e) => SetLabelText(text: buttonCancelDownload.AccessibleDescription);

		#endregion

		#region Leave-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStatusText_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateText_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSourceText_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSizeText_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStatusValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSourceValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSizeValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDownload_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCheckForUpdate_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonDownload_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancelDownload_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion

		#region MouseEnter-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProgressBarDownload_MouseEnter(object sender, EventArgs e) => SetLabelText(text: progressBarDownload.AccessibleDescription);

		#endregion

		#region MouseLeave-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProgressBarDownload_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion

		#region Click-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonDownload_Click(object sender, EventArgs e)
		{
			buttonDownload.Enabled = false;
			buttonCancelDownload.Enabled = true;
			buttonCheckForUpdate.Enabled = false;
			labelSourceValue.Text = uriMPCORB.AbsoluteUri;
			labelSourceValue.Visible = true;
			labelDateValue.Text = GetLastModified(uri: uriMPCORB).ToString();
			labelDateValue.Visible = true;
			labelSizeValue.Text = GetContentLength(uri: uriMPCORB).ToString() + " " + Planetoid_DB.I10nStrings.strBytesText;
			labelSizeValue.Visible = true;
			labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusTryToConnect;
			try
			{
				labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusDownloading;
				webClient.DownloadFileAsync(address: uriMPCORB, fileName: @strFilenameMPCORBtemp);
			}
			catch (Exception ex)
			{
				labelStatusValue.Text = Planetoid_DB.I10nStrings.strStatusUnknownError + " " + ex.Message;
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				MessageBox.Show(text: ex.Message);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancelDownload_Click(object sender, EventArgs e) => webClient.CancelAsync();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			webClient.CancelAsync();
			if (File.Exists(path: strFilenameMPCORBtemp))
			{
				File.Delete(path: strFilenameMPCORBtemp);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCheckForUpdate_Click(object sender, EventArgs e) => CheckMpcorbDat();

		#endregion

		#region DoubleClick-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStatusValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelStatusValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDateValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSourceValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSourceValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSizeValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSizeValue.Text);

		#endregion

	}
}
