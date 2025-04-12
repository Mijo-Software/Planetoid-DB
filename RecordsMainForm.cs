﻿using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Main form for managing records in the Planetoid database.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class RecordsMainForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="RecordsMainForm"/> class.
		/// </summary>
		public RecordsMainForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(RecordsMainForm_KeyDown);
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

		#endregion

		#region Form event handler

		/// <summary>
		/// Handles the Load event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RecordsMainForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		/// <summary>
		/// Handles the FormClosed event of the RecordsMainForm.
		/// Disposes the form when it is closed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void RecordsMainForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter event handler

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// Sets the status bar text to the control's accessible description.
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

		#region Leave event handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click event handler

		/// <summary>
		/// Handles the Click event of the ButtonStart control.
		/// Starts the main process.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonStart_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonExportAsTxt control.
		/// Exports data as a TXT file.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonExportAsTxt_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonExportAsHtml control.
		/// Exports data as an HTML file.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonExportAsHtml_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonExportAsXml control.
		/// Exports data as an XML file.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonExportAsXml_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonExportAsJson control.
		/// Exports data as a JSON file.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonExportAsJson_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto01 control.
		/// Navigates to the first record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto01_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto02 control.
		/// Navigates to the second record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto02_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto03 control.
		/// Navigates to the third record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto03_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto04 control.
		/// Navigates to the fourth record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto04_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto05 control.
		/// Navigates to the fifth record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto05_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto06 control.
		/// Navigates to the sixth record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto06_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto07 control.
		/// Navigates to the seventh record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto07_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto08 control.
		/// Navigates to the eighth record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto08_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto09 control.
		/// Navigates to the ninth record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto09_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the Click event of the ButtonGoto10 control.
		/// Navigates to the tenth record.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonGoto10_Click(object sender, EventArgs e)
		{
		}

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
		private void RecordsMainForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
