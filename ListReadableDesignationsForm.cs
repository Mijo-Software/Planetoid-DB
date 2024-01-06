using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class ListReadableDesignationsForm : KryptonForm
	{
		private ArrayList planetoidDatabase = new(capacity: 0);
		private int numberPlanetoids = 0, selectedIndex = 0;
		private bool isCancelled = false;
		private string strIndex, strDesgnName;

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public ListReadableDesignationsForm() => InitializeComponent();

		#endregion

		#region local methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		public void SetProgressbar(int value) => progressBar.Value = value;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private static void CopyToClipboard(string text)
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
			strDesgnName = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 166, length: 28).Trim();
			ListViewItem listViewItem = new(text: strIndex)
			{
				ToolTipText = $"{strIndex}: {strDesgnName}"
			};
			listViewItem.SubItems.Add(text: strDesgnName);
			listView.Items.Add(value: listViewItem);
		}

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
		private void ListReadableDesignationsForm_Load(object sender, EventArgs e)
		{
			labelInformation.Text = "";
			labelInformation.Enabled = listView.Visible = buttonCancel.Enabled = buttonLoad.Enabled = dropButtonSaveList.Enabled = false;
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
		private void ListReadableDesignationsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			listView.Dispose();
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
			listView.Visible = true;
			numericUpDownMinimum.Enabled = true;
			numericUpDownMaximum.Enabled = true;
			buttonList.Enabled = true;
			dropButtonSaveList.Enabled = true;
			buttonCancel.Enabled = false;
			buttonLoad.Enabled = false;
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
		private void SelectedIndexChanged(object sender, EventArgs e)
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

		#region Clicks event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonList_Click(object sender, EventArgs e)
		{
			listView.Clear();
			listView.Columns.AddRange(values: new ColumnHeader[] {
				 columnHeaderIndex,
				 columnHeaderReadableDesignation,});
			listView.Visible = false;
			numericUpDownMinimum.Enabled = false;
			numericUpDownMaximum.Enabled = false;
			buttonCancel.Enabled = true;
			buttonLoad.Enabled = false;
			buttonList.Enabled = false;
			dropButtonSaveList.Enabled = false;
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSaveAsCsv_Click(object sender, EventArgs e)
		{
			saveFileDialogCsv.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogCsv.FileName = $"Readable-Designation-List_{numericUpDownMinimum.Value}-{numericUpDownMaximum.Value}.{saveFileDialogCsv.DefaultExt}";
			if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogCsv.FileName);
				for (int i = (int)numericUpDownMinimum.Value - 1; i < listView.Items.Count; i++)
				{
					streamWriter.Write(value: $"{listView.Items[index: i].SubItems[index: 0].Text}; {listView.Items[index: i].SubItems[index: 1].Text}");
					if (i < listView.Items.Count - 1)
					{
						streamWriter.Write(value: Environment.NewLine);
					}
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSaveAsHtml_Click(object sender, EventArgs e)
		{
			saveFileDialogHtml.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogHtml.FileName = $"Readable-Designation-List_{numericUpDownMinimum.Value}-{numericUpDownMaximum.Value}.{saveFileDialogHtml.DefaultExt}";
			if (saveFileDialogHtml.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogHtml.FileName);
				streamWriter.WriteLine(value: $"<!DOCTYPE html>");
				streamWriter.WriteLine(value: $"<html lang=\"en\">");
				streamWriter.WriteLine(value: $"\t<head>");
				streamWriter.WriteLine(value: $"\t\t<meta charset=\"utf-8\">");
				streamWriter.WriteLine(value: $"\t\t<meta name=\"description\" content=\"\">");
				streamWriter.WriteLine(value: $"\t\t<meta name=\"keywords\" content=\"\">");
				streamWriter.WriteLine(value: $"\t\t<meta name=\"generator\" content=\"Planetoid-DB\">");
				streamWriter.WriteLine(value: $"\t\t<title>List of readable designations</title>");
				streamWriter.WriteLine(value: $"\t\t<style>");
				streamWriter.WriteLine(value: $"\t\t\t* {{font-family: sans-serif;}}");
				streamWriter.WriteLine(value: $"\t\t\t.italic {{font-style: italic;}}");
				streamWriter.WriteLine(value: $"\t\t\t.bold {{font-weight: bold;}}");
				streamWriter.WriteLine(value: $"\t\t\t.sup {{vertical-align: super; font-size: smaller;}}");
				streamWriter.WriteLine(value: $"\t\t\t.sub {{vertical-align: sub; font-size: smaller;}}");
				streamWriter.WriteLine(value: $"\t\t\t.block {{width:50px; display: inline-block;}}");
				streamWriter.WriteLine(value: $"\t\t</style>");
				streamWriter.WriteLine(value: $"\t</head>");
				streamWriter.WriteLine(value: $"\t<body>");
				streamWriter.WriteLine(value: $"\t\t<p>");
				for (int i = (int)numericUpDownMinimum.Value - 1; i < listView.Items.Count; i++)
				{
					streamWriter.Write(value: $"\t\t\t<span class=\"bold block\" xml:id=\"element-id-{i}\">{listView.Items[index: i].SubItems[index: 0].Text}:</span> <span xml:id=\"value-id-{i}\">{listView.Items[index: i].SubItems[index: 1].Text}</span>");
					if (i < listView.Items.Count - 1)
					{
						streamWriter.WriteLine(value: "<br />");
					}
				}
				streamWriter.WriteLine(value: $"\t\t</p>");
				streamWriter.WriteLine(value: $"\t</body>");
				streamWriter.Write(value: $"</html>");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSaveAsXml_Click(object sender, EventArgs e)
		{
			saveFileDialogXml.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogXml.FileName = $"Readable-Designation-List_{numericUpDownMinimum.Value}-{numericUpDownMaximum.Value}.{saveFileDialogXml.DefaultExt}";
			if (saveFileDialogXml.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogXml.FileName);
				streamWriter.WriteLine(value: $"<?xml version=\"1.0\" encoding=\"UTF.8\" standalone=\"yes\"?>");
				streamWriter.WriteLine(value: $"<ListReadableDesignations xmlns=\"https://planet-db.de\">");
				for (int i = (int)numericUpDownMinimum.Value - 1; i < listView.Items.Count; i++)
				{
					streamWriter.Write(value: $"\t<item xml:id=\"element-id-{i}\" index=\"{listView.Items[index: i].SubItems[index: 0].Text}\" name=\"{listView.Items[index: i].SubItems[index: 1].Text}\" />");
					if (i < listView.Items.Count - 1)
					{
						streamWriter.Write(value: Environment.NewLine);
					}
				}
				streamWriter.Write(value: $"</ListReadableDesignations>");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSaveAsJson_Click(object sender, EventArgs e)
		{
			saveFileDialogJson.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogJson.FileName = $"Readable-Designation-List_{numericUpDownMinimum.Value}-{numericUpDownMaximum.Value}.{saveFileDialogJson.DefaultExt}";
			if (saveFileDialogJson.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogJson.FileName);
				streamWriter.WriteLine(value: $"{{");
				for (int i = (int)numericUpDownMinimum.Value - 1; i < listView.Items.Count; i++)
				{
					streamWriter.WriteLine(value: $"\t\"item\"");
					streamWriter.WriteLine(value: $"\t{{");
					streamWriter.WriteLine(value: $"\t\t\"index\": \"{listView.Items[index: i].SubItems[index: 0].Text}\",");
					streamWriter.WriteLine(value: $"\t\t\"readable designations\": \"{listView.Items[index: i].SubItems[index: 1].Text}\"");
					streamWriter.WriteLine(value: $"\t}}");
				}
				streamWriter.Write(value: $"}}");
			}
		}

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			switch (sender)
			{
				case Label label: CopyToClipboard(text: label.Text); break;
				case KryptonLabel kryptonLabel: CopyToClipboard(text: kryptonLabel.Text); break;
				case ToolStripLabel labelToolStripCombo: CopyToClipboard(text: labelToolStripCombo.Text); break;
			}
		}

		#endregion
	}
}
