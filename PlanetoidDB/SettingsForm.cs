using System;
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
		/// <summary>
		/// 
		/// </summary>
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void ToolStripButtonPrint_Click(object sender, EventArgs e)
		{

		}

		private void SetStatusbar_Enter(object sender, EventArgs e)
		{

		}

		private void ClearStatusbar_Leave(object sender, EventArgs e)
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

		private string GetDebuggerDisplay()
		{
			return ToString();
		}
	}
}
