using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class SearchForm : KryptonForm
	{
		private ArrayList planetoidDatabase = new(capacity: 0);
		private int numberPlanetoids = 0, entriesFound = 0, selectedIndex = 0;
		private bool isCancelled = false;
		private string strIndex, strMagAbs, strSlopeParam, strEpoch, strMeanAnomaly, strArgPeri, strLongAscNode, strIncl, strOrbEcc, strMotion, strSemiMajorAxis, strRef, strNumbObs, strNumbOppos, strObsSpan, strRmsResdiual, strComputerName, strFlags, strDesgnName, strObsLastDate;

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Fügen Sie ggf. den „erforderlichen“ Modifizierer hinzu, oder deklarieren Sie den Modifizierer als NULL-Werte zulassend.
		public SearchForm() => InitializeComponent();
#pragma warning restore CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Fügen Sie ggf. den „erforderlichen“ Modifizierer hinzu, oder deklarieren Sie den Modifizierer als NULL-Werte zulassend.

		#endregion

		#region Local methods

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
		/// <param name="check"></param>
		private void CheckItems(bool check)
		{
			for (int i = 0; i < checkedListBox.Items.Count; i++)
			{
				checkedListBox.SetItemChecked(index: i, value: check);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void MarkAll() => CheckItems(check: true);

		/// <summary>
		/// 
		/// </summary>
		private void UnmarkAll() => CheckItems(check: false);

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
		/// <param name="currentPosition"></param>
		private void FormatRow(int currentPosition)
		{
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
			strIndex = planetoidDatabase[index: currentPosition].ToString()[..7].Trim();
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
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

			//MessageBox.Show(textBox.Text.Contains(value: strDesgnName).ToString());

			//if (String.Equals(textBox.Text, strDesgnName))

			if (strDesgnName.Contains(value: textBox.Text))
			{
				entriesFound++;
				ListViewItem listViewItem = new(text: strIndex)
				{
					ToolTipText = $"{strIndex}: {strDesgnName}"
				};
				_ = listViewItem.SubItems.Add(text: "readable designation");
				_ = listViewItem.SubItems.Add(text: strDesgnName);
				_ = listView.Items.Add(value: listViewItem);
				labelEntriesFound.Text = $"{entriesFound} entries found";
			}



			/**
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

			listView.Items.Add(value: listViewItem);
			*/

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="maxIndex"></param>
		public void SetMaxIndex(int maxIndex) => numberPlanetoids = maxIndex;

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public int GetSelectedIndex() => selectedIndex;

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchForm_Load(object sender, EventArgs e)
		{
			buttonLoad.Enabled = buttonSearch.Enabled = false;
			MarkAll();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region BackgroundWorker event handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			progressBar.Maximum = numberPlanetoids - 1;
			for (int i = 0; i < numberPlanetoids; i++)
			{
				FormatRow(currentPosition: i);
				backgroundWorker.ReportProgress(percentProgress: i);
				TaskbarProgress.SetValue(windowHandle: Handle, progressValue: i, progressMax: numberPlanetoids);
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
			listView.Visible = true;
			buttonCancel.Enabled = false;
			progressBar.Enabled = false;
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
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
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
			switch (sender)
			{
				case TextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case Button button: SetStatusbar(text: button.AccessibleDescription); break;
				case KryptonButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case RadioButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case KryptonRadioButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case CheckBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonCheckBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case CheckedListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonCheckedListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case DateTimePicker picker: SetStatusbar(text: picker.AccessibleDescription); break;
				case KryptonDateTimePicker picker: SetStatusbar(text: picker.AccessibleDescription); break;
				case Label label: SetStatusbar(text: label.AccessibleDescription); break;
				case KryptonLabel label: SetStatusbar(text: label.AccessibleDescription); break;
				case PictureBox boxPicture: SetStatusbar(text: boxPicture.AccessibleDescription); break;
				case ToolStripButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case ToolStripMenuItem menuitem: SetStatusbar(text: menuitem.AccessibleDescription); break;
				case ToolStripLabel label: SetStatusbar(text: label.AccessibleDescription); break;
				case ToolStripComboBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case ToolStripDropDown dropdown: SetStatusbar(text: dropdown.AccessibleDescription); break;
				case ToolStripDropDownButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case ToolStripDropDownItem item: SetStatusbar(text: item.AccessibleDescription); break;
				case ToolStripProgressBar bar: SetStatusbar(text: bar.AccessibleDescription); break;
				case ToolStripSeparator separator: SetStatusbar(text: separator.AccessibleDescription); break;
				case ToolStripTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case ComboBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonComboBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case DataGridView view: SetStatusbar(text: view.AccessibleDescription); break;
				case KryptonDropButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case GroupBox group: SetStatusbar(text: group.AccessibleDescription); break;
				case KryptonGroupBox group: SetStatusbar(text: group.AccessibleDescription); break;
				case ListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonListBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case ListView view: SetStatusbar(text: view.AccessibleDescription); break;
				case MaskedTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonMaskedTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case NumericUpDown numericUpDown: SetStatusbar(text: numericUpDown.AccessibleDescription); break;
				case KryptonNumericUpDown numericUpDown: SetStatusbar(text: numericUpDown.AccessibleDescription); break;
				case MonthCalendar calender: SetStatusbar(text: calender.AccessibleDescription); break;
				case KryptonMonthCalendar calender: SetStatusbar(text: calender.AccessibleDescription); break;
				case PropertyGrid grid: SetStatusbar(text: grid.AccessibleDescription); break;
				case RichTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonRichTextBox box: SetStatusbar(text: box.AccessibleDescription); break;
				case KryptonSeparator separator: SetStatusbar(text: separator.AccessibleDescription); break;
				case ScrollBar scroll: SetStatusbar(text: scroll.AccessibleDescription); break;
				case KryptonScrollBar scroll: SetStatusbar(text: scroll.AccessibleDescription); break;
				case TrackBar track: SetStatusbar(text: track.AccessibleDescription); break;
				case KryptonTrackBar track: SetStatusbar(text: track.AccessibleDescription); break;
				case TreeView view: SetStatusbar(text: view.AccessibleDescription); break;
				case KryptonTreeView view: SetStatusbar(text: view.AccessibleDescription); break;
				case WebBrowser browser: SetStatusbar(text: browser.AccessibleDescription); break;
				case KryptonColorButton button: SetStatusbar(text: button.AccessibleDescription); break;
				case KryptonBreadCrumb breadCrumb: SetStatusbar(text: breadCrumb.AccessibleDescription); break;
				case DomainUpDown domainUpDown: SetStatusbar(text: domainUpDown.AccessibleDescription); break;
				case KryptonDomainUpDown domainUpDown: SetStatusbar(text: domainUpDown.AccessibleDescription); break;
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

		#region Click & ButtonClick event handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonClear_Click(object sender, EventArgs e)
		{
			textBox.Text = string.Empty;
			buttonSearch.Enabled = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMarkAll_Click(object sender, EventArgs e) => MarkAll();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonUnmarkAll_Click(object sender, EventArgs e) => UnmarkAll();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSearch_Click(object sender, EventArgs e)
		{
			entriesFound = 0;
			isCancelled = false;
			listView.Visible = false;
			listView.Items.Clear();
			buttonLoad.Enabled = false;
			buttonCancel.Enabled = progressBar.Enabled = true;
			backgroundWorker.WorkerReportsProgress = backgroundWorker.WorkerSupportsCancellation = true;
#pragma warning disable CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
			backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);
			backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
#pragma warning restore CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
			backgroundWorker.RunWorkerAsync();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancel_Click(object sender, EventArgs e) => isCancelled = true;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void ButtonLoad_Click(object sender, EventArgs e)
		{
		}

		#endregion

		#region TextChanged event handlers
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TextBox_TextChanged(object sender, EventArgs e) => buttonSearch.Enabled = textBox.Text.Length > 0;

		#endregion

		#region SelectedIndexChanged
		private void ListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView.SelectedIndices.Count > 0)
			{
				int selectedIndex = listView.SelectedIndices[index: 0];
				if (selectedIndex >= 0)
				{
					SetStatusbar(text: $"{I10nStrings.Index}: {listView.Items[index: selectedIndex].Text} - {listView.Items[index: selectedIndex].SubItems[index: 1].Text}");
				}
				if (!buttonLoad.Enabled)
				{
					buttonLoad.Enabled = true;
				}
				this.selectedIndex = selectedIndex;
			}
		}

		#endregion
	}
}
