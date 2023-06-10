﻿using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Planetoid_DB
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DownloadUpdateForm : Form
    {
        private readonly string strFilenameMpcorb = Properties.Resources.FilenameMpcorb;
        private readonly string strFilenameMpcorbTemp = Properties.Resources.FilenameMpcorbTemp;
        private readonly Uri uriMPCORB = new Uri(uriString: Properties.Resources.MpcorbUrl);
        private readonly WebClient webClient = new WebClient();

        #region local methods

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
        private void ShowMpcorbDatCheck()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            else
            {
                using (CheckMpcorbDatForm formCeckMpcorbDat = new CheckMpcorbDatForm())
                {
                    formCeckMpcorbDat.ShowDialog();
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        public DownloadUpdateForm() => InitializeComponent();

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
                if (e.Cancelled)
                {
                    labelStatusValue.Text = I10nStrings.StatusDownloadCancelled;
                }
                else
                {
                    labelStatusValue.Text = $"{I10nStrings.StatusUnknownError} {e.Error}";
                }
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
                case TextBox box:
                    SetStatusbar(text: box.AccessibleDescription);
                    break;
                case Button button:
                    SetStatusbar(text: button.AccessibleDescription);
                    break;
                case RadioButton buttonRadio:
                    SetStatusbar(text: buttonRadio.AccessibleDescription);
                    break;
                case CheckBox boxCheck:
                    SetStatusbar(text: boxCheck.AccessibleDescription);
                    break;
                case DateTimePicker picker:
                    SetStatusbar(text: picker.AccessibleDescription);
                    break;
                case Label label:
                    SetStatusbar(text: label.AccessibleDescription);
                    break;
                case PictureBox boxPicture:
                    SetStatusbar(text: boxPicture.AccessibleDescription);
                    break;
                case ToolStripButton buttonToolStrip:
                    SetStatusbar(text: buttonToolStrip.AccessibleDescription);
                    break;
                case ToolStripMenuItem item:
                    SetStatusbar(text: item.AccessibleDescription);
                    break;
                case ToolStripLabel labelToolStrip:
                    SetStatusbar(text: labelToolStrip.AccessibleDescription);
                    break;
                case ToolStripComboBox boxToolStripCombo:
                    SetStatusbar(text: boxToolStripCombo.AccessibleDescription);
                    break;
                case ToolStripDropDown downToolStripDrop:
                    SetStatusbar(text: downToolStripDrop.AccessibleDescription);
                    break;
                case ToolStripDropDownButton buttonToolStripDropDown:
                    SetStatusbar(text: buttonToolStripDropDown.AccessibleDescription);
                    break;
                case ToolStripDropDownItem itemToolStripDropDown:
                    SetStatusbar(text: itemToolStripDropDown.AccessibleDescription);
                    break;
                case ToolStripProgressBar bar:
                    SetStatusbar(text: bar.AccessibleDescription);
                    break;
                case ToolStripSeparator separator:
                    SetStatusbar(text: separator.AccessibleDescription);
                    break;
                case ToolStripTextBox boxToolStripText:
                    SetStatusbar(text: boxToolStripText.AccessibleDescription);
                    break;
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
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox box:
                    CopyToClipboard(text: box.Text);
                    break;
                case Button button:
                    CopyToClipboard(text: button.Text);
                    break;
                case RadioButton buttonRadio:
                    CopyToClipboard(text: buttonRadio.Text);
                    break;
                case CheckBox boxCheck:
                    CopyToClipboard(text: boxCheck.Text);
                    break;
                case DateTimePicker pickerDateTime:
                    CopyToClipboard(text: pickerDateTime.Text);
                    break;
                case Label label:
                    CopyToClipboard(text: label.Text);
                    break;
                case ToolStripButton buttonToolStrip:
                    CopyToClipboard(text: buttonToolStrip.Text);
                    break;
                case ToolStripMenuItem itemToolStripMenu:
                    CopyToClipboard(text: itemToolStripMenu.Text);
                    break;
                case ToolStripLabel labelToolStrip:
                    CopyToClipboard(text: labelToolStrip.Text);
                    break;
                case ToolStripComboBox boxToolStripCombo:
                    CopyToClipboard(text: boxToolStripCombo.Text);
                    break;
                case ToolStripDropDown downToolStripDrop:
                    CopyToClipboard(text: downToolStripDrop.Text);
                    break;
                case ToolStripDropDownButton buttonToolStripDropDown:
                    CopyToClipboard(text: buttonToolStripDropDown.Text);
                    break;
                case ToolStripDropDownItem itemToolStripDropDown:
                    CopyToClipboard(text: itemToolStripDropDown.Text);
                    break;
                case ToolStripProgressBar barToolStripProgress:
                    CopyToClipboard(text: barToolStripProgress.Text);
                    break;
                case ToolStripSeparator separatorToolStrip:
                    CopyToClipboard(text: separatorToolStrip.Text);
                    break;
                case ToolStripTextBox boxToolStripText:
                    CopyToClipboard(text: boxToolStripText.Text);
                    break;
            }
        }

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
    }
}
