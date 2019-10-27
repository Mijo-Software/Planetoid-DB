using System;
using System.IO;
using System.Windows.Forms;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DatabaseInformationForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		public DatabaseInformationForm() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DatabaseInformationForm_Load(object sender, EventArgs e)
		{
			FileInfo fileInfo = new FileInfo(fileName: Properties.Resources.strFilenameMPCORB);
			labelNameValue.Text = fileInfo.Name;
			labelDirectoryValue.Text = fileInfo.DirectoryName;
			labelSizeValue.Text = fileInfo.Length.ToString() + " " + I10nStrings.strBytesText;
			labelDateCreatedValue.Text = fileInfo.CreationTime.ToString();
			labelDateAccessedValue.Text = fileInfo.LastAccessTime.ToString();
			labelDateWritedValue.Text = fileInfo.LastWriteTime.ToString();
			labelAttributesValue.Text = fileInfo.Attributes.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DatabaseInformationForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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

		#region Click-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBoxInformation_Click(object sender, EventArgs e)
		{
			//todo: add something here
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Click(object sender, EventArgs e) => Close();

		#endregion

		#region DoubleClick-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelName_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelName.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDirectory_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDirectory.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSize_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSize.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateCreated_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDateCreated.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateAccessed_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDateAccessed.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateWrited_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDateWrited.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAttributes_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelAttributes.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNameValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelNameValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDirectoryValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDirectoryValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSizeValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSizeValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateCreatedValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDateCreatedValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateAccessedValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDateAccessedValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateWritedValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDateWritedValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAttributesValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelAttributesValue.Text);

		#endregion

		#region Enter-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelName_Enter(object sender, EventArgs e) => SetLabelText(text: labelName.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDirectory_Enter(object sender, EventArgs e) => SetLabelText(text: labelDirectory.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSize_Enter(object sender, EventArgs e) => SetLabelText(text: labelSize.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateCreated_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateCreated.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateAccessed_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateAccessed.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateWrited_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateWrited.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAttributes_Enter(object sender, EventArgs e) => SetLabelText(text: labelAttributes.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNameValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelNameValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDirectoryValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelDirectoryValue.AccessibleDescription);

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
		private void LabelDateCreatedValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateCreatedValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateAccessedValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateAccessedValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateWritedValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelDateWritedValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAttributesValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelAttributesValue.AccessibleDescription);

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
		private void LabelName_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDirectory_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSize_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateCreated_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateAccessed_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateWrited_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAttributes_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNameValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDirectoryValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

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
		private void LabelDateCreatedValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateAccessedValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateWritedValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAttributesValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion

		#region MouseEnter-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBoxInformation_MouseEnter(object sender, EventArgs e) => SetLabelText(text: pictureBoxInformation.AccessibleDescription);

		#endregion

		#region MouseLeave-Eventhandler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBoxInformation_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion
	}
}
