using System;
using System.Diagnostics;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]

	public partial class AppInfoForm : KryptonForm
	{
		#region local methods

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		static private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(text: I10nStrings.CopiedToClipboard, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
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

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public AppInfoForm() => InitializeComponent();

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AppInfoForm_Load(object sender, EventArgs e)
		{
			labelTitle.Text = new AssemblyInfo().AssemblyProduct;
			labelVersion.Text = string.Format(format: I10nStrings.VersionTemplate, arg0: new AssemblyInfo().AssemblyVersion);
			labelDescription.Text = new AssemblyInfo().AssemblyDescription;
			labelCopyright.Text = new AssemblyInfo().AssemblyCopyright;
			linkLabelWWW.Text = $"{I10nStrings.Www}: {Properties.Resources.Homepage}";
			linkLabelWWW.Links.Add(start: 5, length: Properties.Resources.Homepage.Length, linkData: Properties.Resources.Homepage);
			linkLabelMailAddress.Text = $"{I10nStrings.Mail}: {Properties.Resources.HomepageMailExtern}";
			linkLabelMailAddress.Links.Add(start: 6, length: Properties.Resources.HomepageMailIntern.Length, linkData: Properties.Resources.HomepageMailIntern);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AppInfoForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case Button button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case KryptonButton kryptonButton:
					SetStatusbar(text: kryptonButton.AccessibleDescription);
					break;
				case RadioButton buttonRadio:
					SetStatusbar(text: buttonRadio.AccessibleDescription);
					break;
				case CheckBox boxCheck:
					SetStatusbar(text: boxCheck.AccessibleDescription);
					break;
				case DateTimePicker picker:
					SetStatusbar(text: picker.AccessibleDescription);
					break;
				case Label label:
					SetStatusbar(text: label.AccessibleDescription);
					break;
				case PictureBox boxPicture:
					SetStatusbar(text: boxPicture.AccessibleDescription);
					break;
				case ToolStripButton buttonToolStrip:
					SetStatusbar(text: buttonToolStrip.AccessibleDescription);
					break;
				case ToolStripMenuItem item:
					SetStatusbar(text: item.AccessibleDescription);
					break;
				case ToolStripLabel labelToolStrip:
					SetStatusbar(text: labelToolStrip.AccessibleDescription);
					break;
				case ToolStripComboBox boxToolStripCombo:
					SetStatusbar(text: boxToolStripCombo.AccessibleDescription);
					break;
				case ToolStripDropDown downToolStripDrop:
					SetStatusbar(text: downToolStripDrop.AccessibleDescription);
					break;
				case ToolStripDropDownButton buttonToolStripDropDown:
					SetStatusbar(text: buttonToolStripDropDown.AccessibleDescription);
					break;
				case ToolStripDropDownItem itemToolStripDropDown:
					SetStatusbar(text: itemToolStripDropDown.AccessibleDescription);
					break;
				case ToolStripProgressBar bar:
					SetStatusbar(text: bar.AccessibleDescription);
					break;
				case ToolStripSeparator separator:
					SetStatusbar(text: separator.AccessibleDescription);
					break;
				case ToolStripTextBox boxToolStripText:
					SetStatusbar(text: boxToolStripText.AccessibleDescription);
					break;
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

		#region Click event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelCopyright_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start(fileName: e.Link.LinkData.ToString());

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelWWW_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start(fileName: e.Link.LinkData.ToString());

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

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
				case CheckBox checkBox:
					CopyToClipboard(text: checkBox.Text);
					break;
				case DateTimePicker picker:
					CopyToClipboard(text: picker.Text);
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
				case ToolStripProgressBar bar:
					CopyToClipboard(text: bar.Text);
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
