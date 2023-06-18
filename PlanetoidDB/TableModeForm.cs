using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class TableModeForm : KryptonForm
	{
		private ArrayList planetoidDatabase = new ArrayList(capacity: 0);
		private int numberPlanetoids = 0;
		private bool isCancelled = false;
		private string strIndex, strMagAbs, strSlopeParam, strEpoch, strMeanAnomaly, strArgPeri, strLongAscNode, strIncl, strOrbEcc, strMotion, strSemiMajorAxis, strRef, strNumbObs, strNumbOppos, strObsSpan, strRmsResdiual, strComputerName, strFlags, strDesgnName, strObsLastDate;

		#region local methods

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		public void SetProgressbar(int value) => progressBar.Value = value;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arrTemp"></param>
		public void FillArray(ArrayList arrTemp)
		{
			planetoidDatabase = arrTemp;
			numberPlanetoids = planetoidDatabase.Count;
		}

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
		/// <param name="currentPosition"></param>
		private void FormatRow(int currentPosition)
		{
			strIndex = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 0, length: 7).Trim();
			strMagAbs = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 8, length: 5).Trim();
			strSlopeParam = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 14, length: 5).Trim();
			strEpoch = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 20, length: 5).Trim();
			strMeanAnomaly = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 26, length: 9).Trim();
			strArgPeri = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 37, length: 9).Trim();
			strLongAscNode = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 48, length: 9).Trim();
			strIncl = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 59, length: 9).Trim();
			strOrbEcc = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 70, length: 9).Trim();
			strMotion = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 80, length: 11).Trim();
			strSemiMajorAxis = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 92, length: 11).Trim();
			strRef = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 107, length: 9).Trim();
			strNumbObs = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 117, length: 5).Trim();
			strNumbOppos = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 123, length: 3).Trim();
			strObsSpan = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 127, length: 9).Trim();
			strRmsResdiual = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 137, length: 4).Trim();
			strComputerName = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 150, length: 10).Trim();
			strFlags = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 161, length: 4).Trim();
			strDesgnName = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 166, length: 28).Trim();
			strObsLastDate = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 194, length: 8).Trim();
			ListViewItem listViewItem = new ListViewItem(text: strIndex)
			{
				ToolTipText = $"{strIndex}: {strDesgnName}"
			};
			listViewItem.SubItems.Add(text: strDesgnName);
			listViewItem.SubItems.Add(text: strEpoch);
			listViewItem.SubItems.Add(text: strMeanAnomaly);
			listViewItem.SubItems.Add(text: strArgPeri);
			listViewItem.SubItems.Add(text: strLongAscNode);
			listViewItem.SubItems.Add(text: strIncl);
			listViewItem.SubItems.Add(text: strOrbEcc);
			listViewItem.SubItems.Add(text: strMotion);
			listViewItem.SubItems.Add(text: strSemiMajorAxis);
			listViewItem.SubItems.Add(text: strMagAbs);
			listViewItem.SubItems.Add(text: strSlopeParam);
			listViewItem.SubItems.Add(text: strRef);
			listViewItem.SubItems.Add(text: strNumbOppos);
			listViewItem.SubItems.Add(text: strNumbObs);
			listViewItem.SubItems.Add(text: strObsSpan);
			listViewItem.SubItems.Add(text: strRmsResdiual);
			listViewItem.SubItems.Add(text: strComputerName);
			listViewItem.SubItems.Add(text: strFlags);
			listViewItem.SubItems.Add(text: strObsLastDate);
			listViewTableMode.Items.Add(value: listViewItem);
		}

		#endregion

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public TableModeForm() => InitializeComponent();

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TableModeForm_Load(object sender, EventArgs e)
		{
			labelInformation.Text = "";
			labelInformation.Enabled = listViewTableMode.Visible = buttonCancel.Enabled = false;
			if (planetoidDatabase.Count > 0)
			{
				numericUpDownMinimum.Minimum = 1;
				numericUpDownMaximum.Minimum = 1;
				numericUpDownMinimum.Maximum = planetoidDatabase.Count;
				numericUpDownMaximum.Maximum = planetoidDatabase.Count;
				numericUpDownMinimum.Value = 1;
				numericUpDownMaximum.Value = planetoidDatabase.Count;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TableModeForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			listViewTableMode.Dispose();
			Dispose();
		}

		#endregion

		#region BackgroundWorker

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			progressBar.Maximum = (int)numericUpDownMaximum.Value - 1;
			for (int i = (int)numericUpDownMinimum.Value - 1; i < (int)numericUpDownMaximum.Value; i++)
			{
				FormatRow(currentPosition: i);
				backgroundWorker.ReportProgress(percentProgress: i);
				TaskbarProgress.SetValue(windowHandle: Handle, progressValue: i, progressMax: (int)numericUpDownMaximum.Value);
				if (isCancelled)
				{
					break;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) => progressBar.Value = e.ProgressPercentage;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			listViewTableMode.Visible = true;
			numericUpDownMinimum.Enabled = true;
			numericUpDownMaximum.Enabled = true;
			buttonList.Enabled = true;
			buttonCancel.Enabled = false;
			progressBar.Enabled = false;
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
		}

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

		#region Leave event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region SelectedIndexChanged event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListViewTableMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewTableMode.SelectedIndices.Count > 0)
			{
				int selectedIndex = listViewTableMode.SelectedIndices[index: 0];
				if (selectedIndex >= 0)
				{
					SetStatusbar(text: $"{I10nStrings.Index}: {listViewTableMode.Items[selectedIndex].Text} - {listViewTableMode.Items[selectedIndex].SubItems[1].Text}");
				}
			}
		}
		#endregion

		#region Clicks event handlers

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
				case ToolStripSeparator separatorToolStrip:
					CopyToClipboard(text: separatorToolStrip.Text);
					break;
				case ToolStripTextBox boxToolStripText:
					CopyToClipboard(text: boxToolStripText.Text);
					break;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonList_Click(object sender, EventArgs e)
		{
			listViewTableMode.Clear();
			listViewTableMode.Columns.AddRange(values: new ColumnHeader[] {
				 columnHeaderIndex,
				 columnHeaderReadableDesignation,
				 columnHeaderEpoch,
				 columnHeaderMeanAnomaly,
				 columnHeaderArgumentPerihelion,
				 columnHeaderLongitudeAscendingNode,
				 columnHeaderInclination,
				 columnHeaderOrbitalEccentricity,
				 columnHeaderMeanDailyMotion,
				 columnHeaderSemimajorAxis,
				 columnHeaderAbsoluteMagnitude,
				 columnHeaderSlopeParameter,
				 columnHeaderReference,
				 columnHeaderNumberOppositions,
				 columnHeaderNumberObservations,
				 columnHeaderObservationSpan,
				 columnHeaderRmsResidual,
				 columnHeaderComputerName,
				 columnHeaderFlags,
				 columnHeaderDateLastObservation});
			listViewTableMode.Visible = false;
			numericUpDownMinimum.Enabled = false;
			numericUpDownMaximum.Enabled = false;
			buttonCancel.Enabled = true;
			buttonList.Enabled = false;
			isCancelled = false;
			progressBar.Enabled = true;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);
			backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
			backgroundWorker.RunWorkerAsync();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancel_Click(object sender, EventArgs e) => isCancelled = true;

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBoxWarning_DoubleClick(object sender, EventArgs e)
		{
			//SoundPlayer sound = new SoundPlayer(stream: Properties.Resources.wav_redalert);
			//sound.Play();
		}

		private string GetDebuggerDisplay()
		{
			return ToString();
		}

		#endregion
	}
}
