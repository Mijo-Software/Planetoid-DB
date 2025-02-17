using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents the settings form of the application.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class SettingsForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsForm"/> class.
		/// </summary>
		public SettingsForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(SettingsForm_KeyDown);
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

		#region Enter event handler

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

		#region Leave-Handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		/// <summary>
		/// Handles the click event of the Print button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonPrint_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Copy to Clipboard button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonCopyToClipboard_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Database Information button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonDatabaseInformation_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Table Mode button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonTableMode_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Terminology button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonTerminology_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Check MPCORB.DAT button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Download MPCORB.DAT button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonDownloadMpcorbDat_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the About button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonAbout_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Open Website PDB button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the click event of the Search button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonSearch_Click(object sender, EventArgs e)
		{

		}

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the SettingsForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void SettingsForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}