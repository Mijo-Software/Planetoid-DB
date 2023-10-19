using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Net;
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

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public DownloadUpdateForm() => InitializeComponent();

		#endregion

		#region local methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		private static DateTime GetLastModified(Uri uri)
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
		private static long GetContentLength(Uri uri)
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
		private static void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(text: I10nStrings.CopiedToClipboard, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetStatusbar(string text)
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
				MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				using CheckMpcorbDatForm formCeckMpcorbDat = new();
				formCeckMpcorbDat.ShowDialog();
			}
		}

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_Load(object sender, EventArgs e)
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
		private void DownloadUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
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
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
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
		private void Completed(object sender, AsyncCompletedEventArgs e)
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case Button button: SetStatusbar(text: button.AccessibleDescription); break;
				case KryptonButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case RadioButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case KryptonRadioButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case CheckBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonCheckBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case CheckedListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonCheckedListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case DateTimePicker picker: SetStatusbar(text: picker.AccessibleDescription); break;
				case KryptonDateTimePicker picker: SetStatusbar(text: picker.AccessibleDescription); break;
				case Label label: SetStatusbar(text: label.AccessibleDescription); break;
				case KryptonLabel label: SetStatusbar(text: label.AccessibleDescription); break;
				case PictureBox boxPicture: SetStatusbar(text: boxPicture.AccessibleDescription); break;
				case ToolStripButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case ToolStripMenuItem menuitem: SetStatusbar(text: menuitem.AccessibleDescription); break;
				case ToolStripLabel label: SetStatusbar(text: label.AccessibleDescription); break;
				case ToolStripComboBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case ToolStripDropDown dropdown: SetStatusbar(text: dropdown.AccessibleDescription); break;
				case ToolStripDropDownButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case ToolStripDropDownItem item: SetStatusbar(text: item.AccessibleDescription); break;
				case ToolStripProgressBar bar: SetStatusbar(text: bar.AccessibleDescription); break;
				case ToolStripSeparator separator: SetStatusbar(text: separator.AccessibleDescription); break;
				case ToolStripTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case ComboBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonComboBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case DataGridView view: SetStatusbar(text: view.AccessibleDescription); break;
				case KryptonDropButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case GroupBox group: SetStatusbar(text: group.AccessibleDescription); break;
				case KryptonGroupBox group: SetStatusbar(text: group.AccessibleDescription); break;
				case ListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case ListView view: SetStatusbar(text: view.AccessibleDescription); break;
				case MaskedTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonMaskedTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case NumericUpDown numericUpDown: SetStatusbar(text: numericUpDown.AccessibleDescription); break;
				case KryptonNumericUpDown numericUpDown: SetStatusbar(text: numericUpDown.AccessibleDescription); break;
				case MonthCalendar calender: SetStatusbar(text: calender.AccessibleDescription); break;
				case KryptonMonthCalendar calender: SetStatusbar(text: calender.AccessibleDescription); break;
				case PropertyGrid grid: SetStatusbar(text: grid.AccessibleDescription); break;
				case RichTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonRichTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonSeparator separator: SetStatusbar(text: separator.AccessibleDescription); break;
				case ScrollBar scroll: SetStatusbar(text: scroll.AccessibleDescription); break;
				case KryptonScrollBar scroll: SetStatusbar(text: scroll.AccessibleDescription); break;
				case TrackBar track: SetStatusbar(text: track.AccessibleDescription); break;
				case KryptonTrackBar track: SetStatusbar(text: track.AccessibleDescription); break;
				case TreeView view: SetStatusbar(text: view.AccessibleDescription); break;
				case KryptonTreeView view: SetStatusbar(text: view.AccessibleDescription); break;
				case WebBrowser browser: SetStatusbar(text: browser.AccessibleDescription); break;
				case KryptonColorButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case KryptonBreadCrumb breadCrumb: SetStatusbar(text: breadCrumb.AccessibleDescription); break;
				case DomainUpDown domainUpDown: SetStatusbar(text: domainUpDown.AccessibleDescription); break;
				case KryptonDomainUpDown domainUpDown: SetStatusbar(text: domainUpDown.AccessibleDescription); break;
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click event handlers

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
				MessageBox.Show(text: ex.Message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error, defaultButton: MessageBoxDefaultButton.Button1);
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
		private void ButtonCheckForUpdate_Click(object sender, EventArgs e) => ShowMpcorbDatCheck();

		#endregion

		#region DoubleClick event handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
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
