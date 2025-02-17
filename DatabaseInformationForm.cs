using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Form to display database information.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DatabaseInformationForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DatabaseInformationForm"/> class.
		/// </summary>
		public DatabaseInformationForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(DatabaseInformationForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region Local methods

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
			catch (System.Runtime.InteropServices.ExternalException ex)
			{
				_ = MessageBox.Show(text: $"{I10nStrings.CopiedToClipboard}{ex.Message}", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The text to display.</param>
		/// <param name="additionalInfo">Additional information to be displayed.</param>
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

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event of the DatabaseInformationForm control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void DatabaseInformationForm_Load(object sender, EventArgs e)
		{
			FileInfo fileInfo = new(fileName: Properties.Resources.FilenameMpcorb);
			FileAttributes attributes = File.GetAttributes(path: fileInfo.FullName);

			bool isArchive = (attributes & FileAttributes.Archive) == FileAttributes.Archive;
			bool isCompressed = (attributes & FileAttributes.Compressed) == FileAttributes.Compressed;
			bool isHidden = (attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
			bool isReadOnly = (attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
			bool isSystem = (attributes & FileAttributes.System) == FileAttributes.System;

			labelNameValue.Text = fileInfo.Name;
			labelDirectoryValue.Text = fileInfo.DirectoryName;
			labelSizeValue.Text = $"{fileInfo.Length} {I10nStrings.BytesText}";
			labelDateCreatedValue.Text = fileInfo.CreationTime.ToString(provider: CultureInfo.InvariantCulture);
			labelDateAccessedValue.Text = fileInfo.LastAccessTime.ToString(provider: CultureInfo.InvariantCulture);
			labelDateWritedValue.Text = fileInfo.LastWriteTime.ToString(provider: CultureInfo.InvariantCulture);

			StringBuilder attributesText = new(value: $"({fileInfo.Attributes})");
			if (isArchive)
			{
				_ = attributesText.Insert(0, value: "archive ");
			}

			if (isCompressed)
			{
				_ = attributesText.Insert(0, value: "compressed ");
			}

			if (isHidden)
			{
				_ = attributesText.Insert(0, value: "hidden ");
			}

			if (isReadOnly)
			{
				_ = attributesText.Insert(0, value: "readonly ");
			}

			if (isSystem)
			{
				_ = attributesText.Insert(0, value: "system ");
			}

			labelAttributesValue.Text = attributesText.ToString();
		}

		/// <summary>
		/// Handles the FormClosed event of the DatabaseInformationForm control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
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
		/// Handles the Leave event of a control to clear the status bar.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region DoubleClick event handlers

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
		private void DatabaseInformationForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
