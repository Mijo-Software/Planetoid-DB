using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class SettingsForm : KryptonForm
	{
		#region Constructor
		/// <summary>
		/// 
		/// </summary>
		public SettingsForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		private void ToolStripButtonPrint_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonCopyToClipboard_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonDatabaseInformation_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonTableMode_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonTerminology_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonDownloadMpcorbDat_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonAbout_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonSearch_Click(object sender, EventArgs e)
		{

		}
	}
}
