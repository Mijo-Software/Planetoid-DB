using System.Collections;
using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class CopyDataToClipboardForm : KryptonForm
	{
		private ArrayList dataToCopy = new(capacity: 0);

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public CopyDataToClipboardForm() => InitializeComponent();

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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arrayList"></param>
		public void SetDatabase(ArrayList arrayList) => dataToCopy = arrayList;

		#endregion

		#region Form* event handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyDataToClipboardForm_Load(object sender, EventArgs e)
		{
			buttonIndexNumber.Tag = dataToCopy[index: 0];
			buttonReadableDesignation.Tag = dataToCopy[index: 1];
			buttonEpoch.Tag = dataToCopy[index: 2];
			buttonMeanAnomaly.Tag = dataToCopy[index: 3];
			buttonArgumentOfPerihelion.Tag = dataToCopy[index: 4];
			buttonLongitudeOfTheAscendingNode.Tag = dataToCopy[index: 5];
			buttonInclination.Tag = dataToCopy[index: 6];
			buttonOrbitalEccentricity.Tag = dataToCopy[index: 7];
			buttonMeanDailyMotion.Tag = dataToCopy[index: 8];
			buttonSemimajorAxis.Tag = dataToCopy[index: 9];
			buttonAbsoluteMagnitude.Tag = dataToCopy[index: 10];
			buttonSlopeParameter.Tag = dataToCopy[index: 11];
			buttonReference.Tag = dataToCopy[index: 12];
			buttonNumberOfOppositions.Tag = dataToCopy[index: 13];
			buttonNumberOfObservations.Tag = dataToCopy[index: 14];
			buttonObservationSpan.Tag = dataToCopy[index: 15];
			buttonRmsResidual.Tag = dataToCopy[index: 16];
			buttonComputername.Tag = dataToCopy[index: 17];
			buttonFlags.Tag = dataToCopy[index: 18];
			buttonDateOfLastObservation.Tag = dataToCopy[index: 19];
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyDataToClipboardForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
				case TextBox box:
					SetStatusbar(text: $"{box.AccessibleDescription} ➔ {box.Tag}");
					break;
				case Button button:
					SetStatusbar(text: $"{button.AccessibleDescription} ➔ {button.Tag}");
					break;
				case KryptonButton kryptonButton:
					SetStatusbar(text: $"{kryptonButton.AccessibleDescription} ➔ {kryptonButton.Tag}");
					break;
				case RadioButton buttonRadio:
					SetStatusbar(text: $"{buttonRadio.AccessibleDescription} ➔ {buttonRadio.Tag}");
					break;
				case CheckBox boxCheck:
					SetStatusbar(text: $"{boxCheck.AccessibleDescription} ➔ {boxCheck.Tag}");
					break;
				case DateTimePicker picker:
					SetStatusbar(text: $"{picker.AccessibleDescription} ➔ {picker.Tag}");
					break;
				case Label label:
					SetStatusbar(text: $"{label.AccessibleDescription} ➔ {label.Tag}");
					break;
				case KryptonLabel label:
					SetStatusbar(text: $"{label.AccessibleDescription} ➔ {label.Tag}");
					break;
				case PictureBox boxPicture:
					SetStatusbar(text: $"{boxPicture.AccessibleDescription} ➔ {boxPicture.Tag}");
					break;
				case ToolStripButton buttonToolStrip:
					SetStatusbar(text: $"{buttonToolStrip.AccessibleDescription} ➔ {buttonToolStrip.Tag}");
					break;
				case ToolStripMenuItem item:
					SetStatusbar(text: $"{item.AccessibleDescription} ➔ {item.Tag}");
					break;
				case ToolStripLabel labelToolStrip:
					SetStatusbar(text: $"{labelToolStrip.AccessibleDescription} ➔ {labelToolStrip.Tag}");
					break;
				case ToolStripComboBox boxToolStripCombo:
					SetStatusbar(text: $"{boxToolStripCombo.AccessibleDescription} ➔ {boxToolStripCombo.Tag}");
					break;
				case ToolStripDropDown downToolStripDrop:
					SetStatusbar(text: $"{downToolStripDrop.AccessibleDescription} ➔ {downToolStripDrop.Tag}");
					break;
				case ToolStripDropDownButton buttonToolStripDropDown:
					SetStatusbar(text: $"{buttonToolStripDropDown.AccessibleDescription} ➔ {buttonToolStripDropDown.Tag}");
					break;
				case ToolStripDropDownItem itemToolStripDropDown:
					SetStatusbar(text: $"{itemToolStripDropDown.AccessibleDescription} ➔ {itemToolStripDropDown.Tag}");
					break;
				case ToolStripProgressBar bar:
					SetStatusbar(text: $"{bar.AccessibleDescription} ➔ {bar.Tag}");
					break;
				case ToolStripSeparator separator:
					SetStatusbar(text: $"{separator.AccessibleDescription} ➔ {separator.Tag}");
					break;
				case ToolStripTextBox boxToolStripText:
					SetStatusbar(text: $"{boxToolStripText.AccessibleDescription} ➔ {boxToolStripText.Tag}");
					break;
				case KryptonTextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonRadioButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case KryptonCheckBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case CheckedListBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonCheckedListBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonDateTimePicker picker:
					SetStatusbar(text: picker.AccessibleDescription);
					break;
				case ComboBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonComboBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case DataGridView view:
					SetStatusbar(text: view.AccessibleDescription);
					break;
				case KryptonDropButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case GroupBox group:
					SetStatusbar(text: group.AccessibleDescription);
					break;
				case KryptonGroupBox group:
					SetStatusbar(text: group.AccessibleDescription);
					break;
				case ListBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonListBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case ListView view:
					SetStatusbar(text: view.AccessibleDescription);
					break;
				case MaskedTextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonMaskedTextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case NumericUpDown numericUpDown:
					SetStatusbar(text: numericUpDown.AccessibleDescription);
					break;
				case KryptonNumericUpDown numericUpDown:
					SetStatusbar(text: numericUpDown.AccessibleDescription);
					break;
				case MonthCalendar calender:
					SetStatusbar(text: calender.AccessibleDescription);
					break;
				case KryptonMonthCalendar calender:
					SetStatusbar(text: calender.AccessibleDescription);
					break;
				case PropertyGrid grid:
					SetStatusbar(text: grid.AccessibleDescription);
					break;
				case RichTextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonRichTextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonSeparator separator:
					SetStatusbar(text: separator.AccessibleDescription);
					break;
				case ScrollBar scroll:
					SetStatusbar(text: scroll.AccessibleDescription);
					break;
				case KryptonScrollBar scroll:
					SetStatusbar(text: scroll.AccessibleDescription);
					break;
				case TrackBar track:
					SetStatusbar(text: track.AccessibleDescription);
					break;
				case KryptonTrackBar track:
					SetStatusbar(text: track.AccessibleDescription);
					break;
				case TreeView view:
					SetStatusbar(text: view.AccessibleDescription);
					break;
				case KryptonTreeView view:
					SetStatusbar(text: view.AccessibleDescription);
					break;
				case WebBrowser browser:
					SetStatusbar(text: browser.AccessibleDescription);
					break;
				case KryptonColorButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case KryptonBreadCrumb breadCrumb:
					SetStatusbar(text: breadCrumb.AccessibleDescription);
					break;
				case DomainUpDown domainUpDown:
					SetStatusbar(text: domainUpDown.AccessibleDescription);
					break;
				case KryptonDomainUpDown domainUpDown:
					SetStatusbar(text: domainUpDown.AccessibleDescription);
					break;
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
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

		#region Click-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonIndexNumber_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonIndexNumber.Tag.ToString());
#pragma warning restore CS8604 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
		private void ButtonReadableDesignation_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonReadableDesignation.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonEpoch_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonEpoch.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonMeanAnomaly_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonMeanAnomaly.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonArgumentOfPerihelion_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonArgumentOfPerihelion.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonLongitudeOfTheAscendingNode.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonInclination_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonInclination.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonOrbitalEccentricity_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonOrbitalEccentricity.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonMeanDailyMotion_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonMeanDailyMotion.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonSemimajorAxis_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonSemimajorAxis.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonAbsoluteMagnitude_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonAbsoluteMagnitude.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonSlopeParameter_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonSlopeParameter.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonReference_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonReference.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonNumberOfOppositions_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonNumberOfOppositions.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonNumberOfObservations_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonNumberOfObservations.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonObservationSpan_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonObservationSpan.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonRmsResidual_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonRmsResidual.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonComputername_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonComputername.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonFlags_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonFlags.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
#pragma warning disable CS8604 // Dereferenzierung eines möglichen Nullverweises.
		private void ButtonDateOfLastObservation_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonDateOfLastObservation.Tag.ToString());
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		#endregion

	}
}
