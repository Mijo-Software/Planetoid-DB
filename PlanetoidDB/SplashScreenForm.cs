using System;
using System.Diagnostics;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class SplashScreenForm : KryptonForm
	{
		#region local methods

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
		/// <param name="value"></param>
		public void SetProgressbar(int value) => progressBarSplash.Value = value;

		#endregion

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public SplashScreenForm() => InitializeComponent();

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SplashScreenForm_Load(object sender, EventArgs e)
		{
			labelDataLoading.Text = I10nStrings.DataLoading;
			labelTitle.Text = new AssemblyInfo().AssemblyProduct;
			labelVersion.Text = string.Format(format: I10nStrings.VersionTemplate, arg0: new AssemblyInfo().AssemblyVersion);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SplashScreenForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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
				case ToolStripProgressBar barProgress:
					CopyToClipboard(text: barProgress.Text);
					break;
				case ToolStripSeparator separator:
					CopyToClipboard(text: separator.Text);
					break;
				case ToolStripTextBox boxToolStripText:
					CopyToClipboard(text: boxToolStripText.Text);
					break;
			}
		}

		private string GetDebuggerDisplay()
		{
			return ToString();
		}

		#endregion
	}
}
