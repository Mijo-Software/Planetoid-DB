﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class RecordsSelectionForm : KryptonForm
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public RecordsSelectionForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Local Methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		/// 
		/// </summary>
		private void ShowRecordsMain()
		{
			using (RecordsMainForm formRecordsMain = new RecordsMainForm())
			{
				formRecordsMain.ShowDialog();
			}
		}

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
				case TextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case KryptonTextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case Button button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case KryptonButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case RadioButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case KryptonRadioButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case CheckBox box:
					SetStatusbar(text: box.AccessibleDescription);
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
				case DateTimePicker picker:
					SetStatusbar(text: picker.AccessibleDescription);
					break;
				case KryptonDateTimePicker picker:
					SetStatusbar(text: picker.AccessibleDescription);
					break;
				case Label label:
					SetStatusbar(text: label.AccessibleDescription);
					break;
				case KryptonLabel label:
					SetStatusbar(text: label.AccessibleDescription);
					break;
				case PictureBox boxPicture:
					SetStatusbar(text: boxPicture.AccessibleDescription);
					break;
				case ToolStripButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case ToolStripMenuItem menuitem:
					SetStatusbar(text: menuitem.AccessibleDescription);
					break;
				case ToolStripLabel label:
					SetStatusbar(text: label.AccessibleDescription);
					break;
				case ToolStripComboBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case ToolStripDropDown dropdown:
					SetStatusbar(text: dropdown.AccessibleDescription);
					break;
				case ToolStripDropDownButton button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case ToolStripDropDownItem item:
					SetStatusbar(text: item.AccessibleDescription);
					break;
				case ToolStripProgressBar bar:
					SetStatusbar(text: bar.AccessibleDescription);
					break;
				case ToolStripSeparator separator:
					SetStatusbar(text: separator.AccessibleDescription);
					break;
				case ToolStripTextBox box:
					SetStatusbar(text: box.AccessibleDescription);
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

		#region Click & ButtonClick event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonMeanAnomaly_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonArgumentOfPerihelion_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonLongitudeOfTheAscendingNode_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonInclination_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonOrbitalEccentricity_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonMeanDailyMotion_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonSemiMajorAxis_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonAbsoluteMagnitude_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonSlopeParameter_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonNumberOfOppositions_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonNumberOfObservations_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonObservationSpan_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonRmsResidual_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonComputername_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonButtonDateOfLastObservation_Click(object sender, System.EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonCheckButtonRecordSortDirectionAscending_Click(object sender, System.EventArgs e)
		{
			kryptonCheckButtonRecordSortDirectionDescending.Checked = !kryptonCheckButtonRecordSortDirectionAscending.Checked;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonCheckButtonRecordSortDirectionDescending_Click(object sender, System.EventArgs e)
		{
			kryptonCheckButtonRecordSortDirectionAscending.Checked = !kryptonCheckButtonRecordSortDirectionDescending.Checked;
		}

		#endregion
	}
}
