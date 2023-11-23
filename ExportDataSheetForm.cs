using System.Collections;
using System.Diagnostics;
using System.IO;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
	public partial class ExportDataSheetForm : KryptonForm
	{
		private ArrayList orbitElements = new(capacity: 0);

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public ExportDataSheetForm() => InitializeComponent();

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
		/// <param name="arrayList"></param>
		public void SetDatabase(ArrayList arrayList) => orbitElements = arrayList;

		/// <summary>
		/// 
		/// </summary>
		private void MarkAll()
		{
			for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
			{
				checkedListBoxOrbitalElements.SetItemChecked(index: i, value: true);
			}
			buttonExportAsTxt.Enabled = true;
			buttonExportAsHtml.Enabled = true;
			buttonExportAsXml.Enabled = true;
			buttonExportAsJson.Enabled = true;
		}

		/// <summary>
		/// 
		/// </summary>
		private void UnmarkAll()
		{
			for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
			{
				checkedListBoxOrbitalElements.SetItemChecked(index: i, value: false);
			}
			buttonExportAsTxt.Enabled = false;
			buttonExportAsHtml.Enabled = false;
			buttonExportAsXml.Enabled = false;
			buttonExportAsJson.Enabled = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool IsAllUnmarked()
		{
			int unMarked = 0;
			foreach (string item in checkedListBoxOrbitalElements.Items)
			{
				bool isChecked = checkedListBoxOrbitalElements.GetItemChecked(index: checkedListBoxOrbitalElements.FindStringExact(str: item));
				if (!isChecked)
				{
					unMarked++;
				}
			}
			return unMarked == checkedListBoxOrbitalElements.Items.Count;
			/*
			int unMarked = 0;
			for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count + 0; i++)
			{
				if (checkedListBoxOrbitalElements.GetItemChecked(index: i) == false)
				{
					unMarked++;
					toolStripStatusLabel1.Text = "Item " + i.ToString() + " ist unmarkiert. Unmarked: " + unMarked.ToString();
				}
			}
			bool allUnmarked = unMarked == checkedListBoxOrbitalElements.Items.Count;
			return allUnmarked;
			*/
		}

		#endregion

		#region Form* event handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExportDataSheetForm_Load(object sender, EventArgs e) => MarkAll();

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
		private void ButtonExportAsTxt_Click(object sender, EventArgs e)
		{
			saveFileDialogTxt.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogTxt.FileName = $"{orbitElements[index: 0]}.{saveFileDialogTxt.DefaultExt}";
			if (saveFileDialogTxt.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogTxt.FileName);
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					if (checkedListBoxOrbitalElements.GetItemChecked(index: i))
					{
						streamWriter.Write(value: $"{checkedListBoxOrbitalElements.Items[index: i]}: {orbitElements[index: i]}");
						if (i < checkedListBoxOrbitalElements.Items.Count - 1)
						{
							streamWriter.Write(value: Environment.NewLine);
						}
					}
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonExportAsHtml_Click(object sender, EventArgs e)
		{
			saveFileDialogHtml.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogHtml.FileName = $"{orbitElements[index: 0]}.{saveFileDialogHtml.DefaultExt}";
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
				streamWriter.WriteLine(value: $"\t\t<title>Export for [{orbitElements[index: 0]}] {orbitElements[index: 1]}</title>");
				streamWriter.WriteLine(value: $"\t\t<style>");
				streamWriter.WriteLine(value: $"\t\t\t* {{font-family:sans-serif;}}");
				streamWriter.WriteLine(value: $"\t\t\t.italic {{font-style: italic;}}");
				streamWriter.WriteLine(value: $"\t\t\t.bold {{font-weight: bold;}}");
				streamWriter.WriteLine(value: $"\t\t\t.sup {{vertical-align: super; font-size: smaller;}}");
				streamWriter.WriteLine(value: $"\t\t\t.sub {{vertical-align: sub; font-size: smaller;}}");
				streamWriter.WriteLine(value: $"\t\t\t.block {{width:350px; display: inline-block;}}");
				streamWriter.WriteLine(value: $"\t\t</style>");
				streamWriter.WriteLine(value: $"\t</head>");
				streamWriter.WriteLine(value: $"\t<body>");
				streamWriter.WriteLine(value: $"\t\t<p>");
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					if (checkedListBoxOrbitalElements.GetItemChecked(index: i))
					{
						streamWriter.WriteLine(value: $"\t\t\t<span class=\"bold block\" xml:id=\"element-id-{i}\">{checkedListBoxOrbitalElements.Items[index: i]}:</span> <span xml:id=\"value-id-{i}\">{orbitElements[index: i]}</span><br />");
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
		private void ButtonExportAsXml_Click(object sender, EventArgs e)
		{

			saveFileDialogXml.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogXml.FileName = $"{orbitElements[index: 0]}.{saveFileDialogXml.DefaultExt}";
			if (saveFileDialogXml.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogXml.FileName);
				streamWriter.WriteLine(value: $"<?xml version=\"1.0\" encoding=\"UTF.8\" standalone=\"yes\"?>");
				streamWriter.WriteLine(value: $"<MinorPlanet xmlns=\"https://planet-db.org\">");
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					if (checkedListBoxOrbitalElements.GetItemChecked(index: i))
					{
						switch (i)
						{
							case 0: streamWriter.WriteLine(value: $"\t<Index value=\"{orbitElements[index: i]}\"/>"); break;
							case 1: streamWriter.WriteLine(value: $"\t<ReadableDesignation value=\"{orbitElements[index: i]}\"/>"); break;
							case 2: streamWriter.WriteLine(value: $"\t<Epoch value=\"{orbitElements[index: i]}\"/>"); break;
							case 3: streamWriter.WriteLine(value: $"\t<MeanAnomalyAtTheEpoch unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 4: streamWriter.WriteLine(value: $"\t<ArgumentOfPerihelion unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 5: streamWriter.WriteLine(value: $"\t<LongitudeOfTheAscendingNode unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 6: streamWriter.WriteLine(value: $"\t<InclinationToTheEcliptic unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 7: streamWriter.WriteLine(value: $"\t<OrbitalEcentricity value=\"{orbitElements[index: i]}\"/>"); break;
							case 8: streamWriter.WriteLine(value: $"\t<MeanDailyMotion unit=\"degrees per day\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 9: streamWriter.WriteLine(value: $"\t<SemiMajorAxis unit=\"astronimical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 10: streamWriter.WriteLine(value: $"\t<AbsoluteMagnitude unit=\"mag\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 11: streamWriter.WriteLine(value: $"\t<SlopeParameter value=\"{orbitElements[index: i]}\"/>"); break;
							case 12: streamWriter.WriteLine(value: $"\t<Reference value=\"{orbitElements[index: i]}\"/>"); break;
							case 13: streamWriter.WriteLine(value: $"\t<NumberOfOppositions value=\"{orbitElements[index: i]}\"/>"); break;
							case 14: streamWriter.WriteLine(value: $"\t<NumberOfObservations value=\"{orbitElements[index: i]}\"/>"); break;
							case 15: streamWriter.WriteLine(value: $"\t<ObservationSpan value=\"{orbitElements[index: i]}\"/>"); break;
							case 16: streamWriter.WriteLine(value: $"\t<RmsResidual unit=\"arcseconds\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 17: streamWriter.WriteLine(value: $"\t<ComputerName value=\"{orbitElements[index: i]}\"/>"); break;
							case 18: streamWriter.WriteLine(value: $"\t<FourHexdigitFlags value=\"{orbitElements[index: i]}\"/>"); break;
							case 19: streamWriter.WriteLine(value: $"\t<DateOfLastObservation unit=\"yyyymmdd\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 20: streamWriter.WriteLine(value: $"\t<LinearEccentricity value=\"{orbitElements[index: i]}\"/>"); break;
							case 21: streamWriter.WriteLine(value: $"\t<SemiMinorAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 22: streamWriter.WriteLine(value: $"\t<MajorAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 23: streamWriter.WriteLine(value: $"\t<MinorAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 24: streamWriter.WriteLine(value: $"\t<EccenctricAnomaly unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 25: streamWriter.WriteLine(value: $"\t<TrueAnomaly unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 26: streamWriter.WriteLine(value: $"\t<PerihelionDistance unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 27: streamWriter.WriteLine(value: $"\t<AphelionDistance unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 28: streamWriter.WriteLine(value: $"\t<LongitudeOfDescendingNode unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 29: streamWriter.WriteLine(value: $"\t<ArgumentOfAphelion unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 30: streamWriter.WriteLine(value: $"\t<FocalParameter unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 31: streamWriter.WriteLine(value: $"\t<SemiLatusRectum unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 32: streamWriter.WriteLine(value: $"\t<LatusRectum unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 33: streamWriter.WriteLine(value: $"\t<OrbitalPeriod unit=\"years\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 34: streamWriter.WriteLine(value: $"\t<OrbitalArea unit=\"squared astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 35: streamWriter.WriteLine(value: $"\t<OrbitalPerimeter unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 36: streamWriter.WriteLine(value: $"\t<SemiMeanAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 37: streamWriter.WriteLine(value: $"\t<MeanAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>"); break;
							case 38: streamWriter.WriteLine(value: $"\t<StandardGravitationalParameter unit=\"AU³/a²\" value=\"{orbitElements[index: i]}\"/>"); break;
						}
					}
				}
				streamWriter.Write(value: $"</MinorPlanet>");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonExportAsJson_Click(object sender, EventArgs e)
		{
			saveFileDialogJson.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogJson.FileName = $"{orbitElements[index: 0]}.{saveFileDialogJson.DefaultExt}";
			if (saveFileDialogJson.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogJson.FileName);
				streamWriter.WriteLine(value: $"{{");
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					if (checkedListBoxOrbitalElements.GetItemChecked(index: i))
					{
						switch (i)
						{
							case 0: streamWriter.WriteLine(value: $"\t\"Index\": \"{orbitElements[index: i]}\""); break;
							case 1: streamWriter.WriteLine(value: $"\t\"ReadableDesignation\": \"{orbitElements[index: i]}\""); break;
							case 2: streamWriter.WriteLine(value: $"\t\"Epoch\": \"{orbitElements[index: i]}\""); break;
							case 3: streamWriter.WriteLine(value: $"\t\"MeanAnomalyAtTheEpoch\": {orbitElements[index: i]}"); break;
							case 4: streamWriter.WriteLine(value: $"\t\"ArgumentOfPerihelion\": {orbitElements[index: i]}"); break;
							case 5: streamWriter.WriteLine(value: $"\t\"LongitudeOfTheAscendingNode\": {orbitElements[index: i]}"); break;
							case 6: streamWriter.WriteLine(value: $"\t\"InclinationToTheEcliptic\": {orbitElements[index: i]}"); break;
							case 7: streamWriter.WriteLine(value: $"\t\"OrbitalEcentricity\": {orbitElements[index: i]}"); break;
							case 8: streamWriter.WriteLine(value: $"\t\"MeanDailyMotion\": {orbitElements[index: i]}"); break;
							case 9: streamWriter.WriteLine(value: $"\t\"SemiMajorAxis\": {orbitElements[index: i]}"); break;
							case 10: streamWriter.WriteLine(value: $"\t\"AbsoluteMagnitude\": {orbitElements[index: i]}"); break;
							case 11: streamWriter.WriteLine(value: $"\t\"SlopeParameter\": {orbitElements[index: i]}"); break;
							case 12: streamWriter.WriteLine(value: $"\t\"Reference\": \"{orbitElements[index: i]}\""); break;
							case 13: streamWriter.WriteLine(value: $"\t\"NumberOfOppositions\": {orbitElements[index: i]}"); break;
							case 14: streamWriter.WriteLine(value: $"\t\"NumberOfObservations\": {orbitElements[index: i]}"); break;
							case 15: streamWriter.WriteLine(value: $"\t\"ObservationSpan\": \"{orbitElements[index: i]}\""); break;
							case 16: streamWriter.WriteLine(value: $"\t\"RmsResidual\": {orbitElements[index: i]}"); break;
							case 17: streamWriter.WriteLine(value: $"\t\"ComputerName\": \"{orbitElements[index: i]}\""); break;
							case 18: streamWriter.WriteLine(value: $"\t\"FourHexdigitFlags\": \"{orbitElements[index: i]}\""); break;
							case 19: streamWriter.WriteLine(value: $"\t\"DateOfLastObservation\": \"{orbitElements[index: i]}\""); break;
							case 20: streamWriter.WriteLine(value: $"\t\"LinearEccentricity\": {orbitElements[index: i]}"); break;
							case 21: streamWriter.WriteLine(value: $"\t\"SemiMinorAxis\": {orbitElements[index: i]}"); break;
							case 22: streamWriter.WriteLine(value: $"\t\"MajorAxis\": {orbitElements[index: i]}"); break;
							case 23: streamWriter.WriteLine(value: $"\t\"MinorAxis\": {orbitElements[index: i]}"); break;
							case 24: streamWriter.WriteLine(value: $"\t\"EccenctricAnomaly\": {orbitElements[index: i]}"); break;
							case 25: streamWriter.WriteLine(value: $"\t\"TrueAnomaly\": {orbitElements[index: i]}"); break;
							case 26: streamWriter.WriteLine(value: $"\t\"PerihelionDistance\": {orbitElements[index: i]}"); break;
							case 27: streamWriter.WriteLine(value: $"\t\"AphelionDistance\": {orbitElements[index: i]}"); break;
							case 28: streamWriter.WriteLine(value: $"\t\"LongitudeOfDescendingNode\": {orbitElements[index: i]}"); break;
							case 29: streamWriter.WriteLine(value: $"\t\"ArgumentOfAphelion\": {orbitElements[index: i]}"); break;
							case 30: streamWriter.WriteLine(value: $"\t\"FocalParameter\": {orbitElements[index: i]}"); break;
							case 31: streamWriter.WriteLine(value: $"\t\"SemiLatusRectum\": {orbitElements[index: i]}"); break;
							case 32: streamWriter.WriteLine(value: $"\t\"LatusRectum\": {orbitElements[index: i]}"); break;
							case 33: streamWriter.WriteLine(value: $"\t\"OrbitalPeriod\": {orbitElements[index: i]}"); break;
							case 34: streamWriter.WriteLine(value: $"\t\"OrbitalArea\": {orbitElements[index: i]}"); break;
							case 35: streamWriter.WriteLine(value: $"\t\"OrbitalPerimeter\": {orbitElements[index: i]}"); break;
							case 36: streamWriter.WriteLine(value: $"\t\"SemiMeanAxis\": {orbitElements[index: i]}"); break;
							case 37: streamWriter.WriteLine(value: $"\t\"MeanAxis\": {orbitElements[index: i]}"); break;
							case 38: streamWriter.WriteLine(value: $"\t\"StandardGravitationalParameter\": {orbitElements[index: i]}"); break;
						}
					}
				}
				streamWriter.Write(value: $"}}");
			}
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

		#endregion

		private void CheckedListBoxOrbitalElements_ItemCheck(object sender, ItemCheckEventArgs e)
		{
		}

		private void CheckedListBoxOrbitalElements_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (IsAllUnmarked())
			{
				buttonExportAsTxt.Enabled = false;
				buttonExportAsHtml.Enabled = false;
				buttonExportAsXml.Enabled = false;
				buttonExportAsJson.Enabled = false;
			}
			else
			{
				buttonExportAsTxt.Enabled = true;
				buttonExportAsHtml.Enabled = true;
				buttonExportAsXml.Enabled = true;
				buttonExportAsJson.Enabled = true;
			}
		}
	}
}
