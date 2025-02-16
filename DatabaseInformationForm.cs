using System.Diagnostics;
using System.Globalization;
using System.IO;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DatabaseInformationForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public DatabaseInformationForm() => InitializeComponent();

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

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DatabaseInformationForm_Load(object sender, EventArgs e)
		{
			FileInfo fileInfo = new(fileName: Properties.Resources.FilenameMpcorb);
			bool isArchive = (File.GetAttributes(path: fileInfo.FullName) & FileAttributes.Archive) == FileAttributes.Archive;
			bool isCompressed = (File.GetAttributes(path: fileInfo.FullName) & FileAttributes.Compressed) == FileAttributes.Compressed;
			bool isHidden = (File.GetAttributes(path: fileInfo.FullName) & FileAttributes.Hidden) == FileAttributes.Hidden;
			bool isReadOnly = (File.GetAttributes(path: fileInfo.FullName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
			bool isSystem = (File.GetAttributes(path: fileInfo.FullName) & FileAttributes.System) == FileAttributes.System;
			labelNameValue.Text = fileInfo.Name;
			labelDirectoryValue.Text = fileInfo.DirectoryName;
			labelSizeValue.Text = $"{fileInfo.Length} {I10nStrings.BytesText}";
			labelDateCreatedValue.Text = fileInfo.CreationTime.ToString(provider: CultureInfo.InvariantCulture);
			labelDateAccessedValue.Text = fileInfo.LastAccessTime.ToString(provider: CultureInfo.InvariantCulture);
			labelDateWritedValue.Text = fileInfo.LastWriteTime.ToString(provider: CultureInfo.InvariantCulture);
			labelAttributesValue.Text = $"({fileInfo.Attributes})";
			if (isArchive)
			{
				labelAttributesValue.Text = $"archive {labelAttributesValue.Text}";
			}
			if (isCompressed)
			{
				labelAttributesValue.Text = $"compressed {labelAttributesValue.Text}";
			}
			if (isHidden)
			{
				labelAttributesValue.Text = $"hidden {labelAttributesValue.Text}";
			}
			if (isReadOnly)
			{
				labelAttributesValue.Text = $"readonly {labelAttributesValue.Text}";
			}
			if (isSystem)
			{
				labelAttributesValue.Text = $"system {labelAttributesValue.Text}";
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DatabaseInformationForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region DoubleClick event handlers

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
