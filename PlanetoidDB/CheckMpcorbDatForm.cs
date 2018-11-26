using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CheckMpcorbDatForm : Form
	{
		#region Constructor and Form-Handler

		/// <summary>
		/// 
		/// </summary>
		public CheckMpcorbDatForm() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckMpcorbDatForm_Load(object sender, EventArgs e)
		{
			Uri uriMPCORB = new Uri(uriString: Properties.Resources.strMpcorbUrl);
			DateTime
				datetimeFileLocal = DateTime.MinValue,
				datetimeFileOnline = GetLastModified(uri: uriMPCORB);
			if (!File.Exists(path: Properties.Resources.strFilenameMPCORB))
			{
				labelContentLengthValueLocal.Text = I10nStrings.strNoFileFoundText;
				labelModifiedDateValueLocal.Text = I10nStrings.strNoFileFoundText;
			}
			else
			{
				FileInfo fileInfo = new FileInfo(fileName: Properties.Resources.strFilenameMPCORB);
				datetimeFileLocal = fileInfo.LastWriteTime;
				labelContentLengthValueLocal.Text = fileInfo.Length.ToString() + " " + I10nStrings.strBytesText;
				labelModifiedDateValueLocal.Text = datetimeFileLocal.ToString();
			}
			labelContentLengthValueOnline.Text = GetContentLength(uri: uriMPCORB).ToString() + " " + I10nStrings.strBytesText;
			labelModifiedDateValueOnline.Text = datetimeFileOnline.ToString();
			labelIsUpdateNeeded.Text = datetimeFileOnline > datetimeFileLocal ? I10nStrings.strUpdateRecommendedText : I10nStrings.strNoUpdateNeededText;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckMpcorbDatForm_FormClosed(object sender, FormClosedEventArgs e) => this.Dispose();

		#endregion

		#region main functions

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(text: I10nStrings.strCopiedToClipboard, caption: I10nStrings.strInformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
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

		#endregion

		#region Click-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

		#endregion

		#region Enter-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMpcorbDatLocal_Enter(object sender, EventArgs e) => SetLabelText(text: labelMpcorbDatLocal.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMpcorbDatOnline_Enter(object sender, EventArgs e) => SetLabelText(text: labelMpcorbDatOnline.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelContentLengthText_Enter(object sender, EventArgs e) => SetLabelText(text: labelContentLengthText.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelContentLengthValueLocal_Enter(object sender, EventArgs e) => SetLabelText(text: labelContentLengthValueLocal.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelContentLengthValueOnline_Enter(object sender, EventArgs e) => SetLabelText(text: labelContentLengthValueOnline.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedDateText_Enter(object sender, EventArgs e) => SetLabelText(text: labelModifiedDateText.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedDateValueLocal_Enter(object sender, EventArgs e) => SetLabelText(text: labelModifiedDateValueLocal.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedDateValueOnline_Enter(object sender, EventArgs e) => SetLabelText(text: labelModifiedDateValueOnline.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIsUpdateNeeded_Enter(object sender, EventArgs e) => SetLabelText(text: labelIsUpdateNeeded.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Enter(object sender, EventArgs e) => SetLabelText(text: buttonOK.AccessibleDescription);

		#endregion

		#region Leave-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMpcorbDatLocal_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMpcorbDatOnline_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelContentLengthText_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelContentLengthValueLocal_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelContentLengthValueOnline_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedDateText_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedDateValueLocal_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelModifiedDateValueOnline_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIsUpdateNeeded_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion
	}
}
