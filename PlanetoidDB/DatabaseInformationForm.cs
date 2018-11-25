using System;
using System.IO;
using System.Windows.Forms;

namespace PlanetoidDB
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
		/// <param name="text"></param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text);
			MessageBox.Show(text: Planetoid_DB.I10nStrings.strCopiedToClipboard, caption: "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DatabaseInformationForm_Load(object sender, EventArgs e)
    {
			FileInfo fileInfo = new FileInfo(fileName: Planetoid_DB.Properties.Resources.strFilenameMPCORB);
      labelNameValue.Text = fileInfo.Name;
      labelDirectoryValue.Text = fileInfo.DirectoryName;
      labelSizeValue.Text = fileInfo.Length.ToString() + " " + Planetoid_DB.I10nStrings.strBytesText;
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
		private void DatabaseInformationForm_FormClosed(object sender, FormClosedEventArgs e) => this.Dispose();

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
		private void ButtonOK_Click(object sender, EventArgs e) => this.Close();

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
	}
}
