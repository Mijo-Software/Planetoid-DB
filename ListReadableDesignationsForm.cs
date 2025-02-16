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
#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Fügen Sie ggf. den „erforderlichen“ Modifizierer hinzu, oder deklarieren Sie den Modifizierer als NULL-Werte zulassend.
		public ListReadableDesignationsForm() => InitializeComponent();
#pragma warning restore CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Fügen Sie ggf. den „erforderlichen“ Modifizierer hinzu, oder deklarieren Sie den Modifizierer als NULL-Werte zulassend.

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
		/// <param name="value"></param>
		public void SetProgressbar(int value) => progressBar.Value = value;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetStatusbar(string? text)
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
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
			strIndex = planetoidDatabase[index: currentPosition].ToString()[..7].Trim();
			strDesgnName = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 166, length: 28).Trim();
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
			ListViewItem listViewItem = new(text: strIndex)
			{
				ToolTipText = $"{strIndex}: {strDesgnName}"
			};
			_ = listViewItem.SubItems.Add(text: strDesgnName);
			_ = listView.Items.Add(value: listViewItem);
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
		private void ListReadableDesignationsForm_Load(object? sender, EventArgs? e)
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
		private void ListReadableDesignationsForm_FormClosed(object? sender, FormClosedEventArgs? e)
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
		private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs? e)
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
		private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e) => progressBar.Value = e.ProgressPercentage;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs? e)
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

		#region Leave event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object? sender, EventArgs? e) => ClearStatusbar();

		#endregion

		#region SelectedIndexChanged event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectedIndexChanged(object? sender, EventArgs? e)
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
		private void ButtonList_Click(object? sender, EventArgs? e)
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
		private void ButtonCancel_Click(object? sender, EventArgs? e) => isCancelled = true;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSaveAsCsv_Click(object? sender, EventArgs? e)
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
		private void ToolStripMenuItemSaveAsHtml_Click(object? sender, EventArgs? e)
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
		private void ToolStripMenuItemSaveAsXml_Click(object? sender, EventArgs? e)
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
		private void ToolStripMenuItemSaveAsJson_Click(object? sender, EventArgs? e)
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
		private void CopyToClipboard_DoubleClick(object? sender, EventArgs? e)
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
