using System.Diagnostics;
using System.IO;
using System.Text;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Form for exporting data sheets with various formats.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class ExportDataSheetForm : KryptonForm
	{
		/// <summary>
		/// List of orbit elements to be exported.
		/// </summary>
		private List<string> orbitElements = [];

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="ExportDataSheetForm"/> class.
		/// </summary>
		public ExportDataSheetForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(ExportDataSheetForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region Local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusbar(string text, string additionalInfo = "")
		{
			if (!string.IsNullOrWhiteSpace(value: text))
			{
				labelInformation.Enabled = true;
				labelInformation.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
			}
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusbar()
		{
			labelInformation.Enabled = false;
			labelInformation.Text = string.Empty;
		}

		/// <summary>
		/// Sets the database with the provided list of orbit elements.
		/// </summary>
		/// <param name="list">The list of orbit elements.</param>
		public void SetDatabase(List<string> list) => orbitElements = list;

		/// <summary>
		/// Checks or unchecks all items in the list.
		/// </summary>
		/// <param name="check">True to check all items, false to uncheck all items.</param>
		private void CheckIt(bool check)
		{
			for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
			{
				checkedListBoxOrbitalElements.SetItemChecked(index: i, value: check);
			}
			buttonExportAsTxt.Enabled = buttonExportAsHtml.Enabled = buttonExportAsXml.Enabled = buttonExportAsJson.Enabled = check;
		}

		/// <summary>
		/// Marks all items in the list.
		/// </summary>
		private void MarkAll() => CheckIt(check: true);

		/// <summary>
		/// Unmarks all items in the list.
		/// </summary>
		private void UnmarkAll() => CheckIt(check: false);

		/// <summary>
		/// Determines whether all items are unmarked.
		/// </summary>
		/// <returns>True if all items are unmarked, otherwise false.</returns>
		private bool IsAllUnmarked()
		{
			foreach (object? item in checkedListBoxOrbitalElements.Items)
			{
				if (item != null)
				{
					string itemString = item.ToString() ?? string.Empty;
					bool isChecked = checkedListBoxOrbitalElements.GetItemChecked(index: checkedListBoxOrbitalElements.FindStringExact(str: itemString));
					if (isChecked)
					{
						return false;
					}
				}
			}
			return true;
		}

		#endregion

		#region Form event handler

		/// <summary>
		/// Handles the Load event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ExportDataSheetForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			MarkAll();
		}

		#endregion

		#region Enter-Handler

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control control && control.AccessibleDescription != null)
			{
				SetStatusbar(control.AccessibleDescription);
			}
		}

		#endregion

		#region Leave-Handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click & ButtonClick event handler

		/// <summary>
		/// Handles the Click event of the ButtonExportAsTxt control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
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
		/// Handles the Click event of the ButtonExportAsHtml control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonExportAsHtml_Click(object sender, EventArgs e)
		{
			saveFileDialogHtml.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogHtml.FileName = $"{orbitElements[index: 0]}.{saveFileDialogHtml.DefaultExt}";
			if (saveFileDialogHtml.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogHtml.FileName);
				StringBuilder sb = new();
				_ = sb.AppendLine(value: "<!DOCTYPE html>");
				_ = sb.AppendLine(value: "<html lang=\"en\">");
				_ = sb.AppendLine(value: "\t<head>");
				_ = sb.AppendLine(value: "\t\t<meta charset=\"utf-8\">");
				_ = sb.AppendLine(value: "\t\t<meta name=\"description\" content=\"\">");
				_ = sb.AppendLine(value: "\t\t<meta name=\"keywords\" content=\"\">");
				_ = sb.AppendLine(value: "\t\t<meta name=\"generator\" content=\"Planetoid-DB\">");
				_ = sb.AppendLine($"\t\t<title>Export for [{orbitElements[index: 0]}] {orbitElements[index: 1]}</title>");
				_ = sb.AppendLine(value: "\t\t<style>");
				_ = sb.AppendLine(value: "\t\t\t* {font-family: sans-serif;}");
				_ = sb.AppendLine(value: "\t\t\t.italic {font-style: italic;}");
				_ = sb.AppendLine(value: "\t\t\t.bold {font-weight: bold;}");
				_ = sb.AppendLine(value: "\t\t\t.sup {vertical-align: super; font-size: smaller;}");
				_ = sb.AppendLine(value: "\t\t\t.sub {vertical-align: sub; font-size: smaller;}");
				_ = sb.AppendLine(value: "\t\t\t.block {width:350px; display: inline-block;}");
				_ = sb.AppendLine(value: "\t\t</style>");
				_ = sb.AppendLine(value: "\t</head>");
				_ = sb.AppendLine(value: "\t<body>");
				_ = sb.AppendLine(value: "\t\t<p>");
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					if (checkedListBoxOrbitalElements.GetItemChecked(index: i))
					{
						_ = sb.AppendLine(handler: $"\t\t\t<span class=\"bold block\" xml:id=\"element-id-{i}\">{checkedListBoxOrbitalElements.Items[index: i]}:</span> <span xml:id=\"value-id-{i}\">{orbitElements[index: i]}</span><br />");
					}
				}
				_ = sb.AppendLine(value: "\t\t</p>");
				_ = sb.AppendLine(value: "\t</body>");
				_ = sb.Append(value: "</html>");
				streamWriter.Write(value: sb.ToString());
			}
		}

		/// <summary>
		/// Handles the Click event of the ButtonExportAsXml control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonExportAsXml_Click(object sender, EventArgs e)
		{
			saveFileDialogXml.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogXml.FileName = $"{orbitElements[index: 0]}.{saveFileDialogXml.DefaultExt}";
			if (saveFileDialogXml.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogXml.FileName);
				StringBuilder sb = new();
				_ = sb.AppendLine(value: "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
				_ = sb.AppendLine(value: "<MinorPlanet xmlns=\"https://planet-db.de\">");
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					if (checkedListBoxOrbitalElements.GetItemChecked(index: i))
					{
						_ = sb.AppendLine(value: i switch
						{
							0 => $"\t<Index value=\"{orbitElements[index: i]}\"/>",
							1 => $"\t<ReadableDesignation value=\"{orbitElements[index: i]}\"/>",
							2 => $"\t<Epoch value=\"{orbitElements[index: i]}\"/>",
							3 => $"\t<MeanAnomalyAtTheEpoch unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							4 => $"\t<ArgumentOfPerihelion unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							5 => $"\t<LongitudeOfTheAscendingNode unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							6 => $"\t<InclinationToTheEcliptic unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							7 => $"\t<OrbitalEcentricity value=\"{orbitElements[index: i]}\"/>",
							8 => $"\t<MeanDailyMotion unit=\"degrees per day\" value=\"{orbitElements[index: i]}\"/>",
							9 => $"\t<SemiMajorAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							10 => $"\t<AbsoluteMagnitude unit=\"mag\" value=\"{orbitElements[index: i]}\"/>",
							11 => $"\t<SlopeParameter value=\"{orbitElements[index: i]}\"/>",
							12 => $"\t<Reference value=\"{orbitElements[index: i]}\"/>",
							13 => $"\t<NumberOfOppositions value=\"{orbitElements[index: i]}\"/>",
							14 => $"\t<NumberOfObservations value=\"{orbitElements[index: i]}\"/>",
							15 => $"\t<ObservationSpan value=\"{orbitElements[index: i]}\"/>",
							16 => $"\t<RmsResidual unit=\"arcseconds\" value=\"{orbitElements[index: i]}\"/>",
							17 => $"\t<ComputerName value=\"{orbitElements[index: i]}\"/>",
							18 => $"\t<FourHexdigitFlags value=\"{orbitElements[index: i]}\"/>",
							19 => $"\t<DateOfLastObservation unit=\"yyyymmdd\" value=\"{orbitElements[index: i]}\"/>",
							20 => $"\t<LinearEccentricity value=\"{orbitElements[index: i]}\"/>",
							21 => $"\t<SemiMinorAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							22 => $"\t<MajorAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							23 => $"\t<MinorAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							24 => $"\t<EccenctricAnomaly unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							25 => $"\t<TrueAnomaly unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							26 => $"\t<PerihelionDistance unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							27 => $"\t<AphelionDistance unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							28 => $"\t<LongitudeOfDescendingNode unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							29 => $"\t<ArgumentOfAphelion unit=\"degrees\" value=\"{orbitElements[index: i]}\"/>",
							30 => $"\t<FocalParameter unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							31 => $"\t<SemiLatusRectum unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							32 => $"\t<LatusRectum unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							33 => $"\t<OrbitalPeriod unit=\"years\" value=\"{orbitElements[index: i]}\"/>",
							34 => $"\t<OrbitalArea unit=\"squared astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							35 => $"\t<OrbitalPerimeter unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							36 => $"\t<SemiMeanAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							37 => $"\t<MeanAxis unit=\"astronomical units\" value=\"{orbitElements[index: i]}\"/>",
							38 => $"\t<StandardGravitationalParameter unit=\"AU³/a²\" value=\"{orbitElements[index: i]}\"/>",
							_ => string.Empty
						});
					}
				}
				_ = sb.Append(value: "</MinorPlanet>");
				streamWriter.Write(value: sb.ToString());
			}
		}

		/// <summary>
		/// Handles the Click event of the ButtonExportAsJson control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonExportAsJson_Click(object sender, EventArgs e)
		{
			saveFileDialogJson.InitialDirectory = Environment.GetFolderPath(folder: Environment.SpecialFolder.MyDocuments);
			saveFileDialogJson.FileName = $"{orbitElements[index: 0]}.{saveFileDialogJson.DefaultExt}";
			if (saveFileDialogJson.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter streamWriter = new(path: saveFileDialogJson.FileName);
				StringBuilder sb = new();
				_ = sb.AppendLine(value: "{");
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					if (checkedListBoxOrbitalElements.GetItemChecked(index: i))
					{
						_ = sb.AppendLine(value: i switch
						{
							0 => $"\t\"Index\": \"{orbitElements[index: i]}\",",
							1 => $"\t\"ReadableDesignation\": \"{orbitElements[index: i]}\",",
							2 => $"\t\"Epoch\": \"{orbitElements[index: i]}\",",
							3 => $"\t\"MeanAnomalyAtTheEpoch\": {orbitElements[index: i]},",
							4 => $"\t\"ArgumentOfPerihelion\": {orbitElements[index: i]},",
							5 => $"\t\"LongitudeOfTheAscendingNode\": {orbitElements[index: i]},",
							6 => $"\t\"InclinationToTheEcliptic\": {orbitElements[index: i]},",
							7 => $"\t\"OrbitalEcentricity\": {orbitElements[index: i]},",
							8 => $"\t\"MeanDailyMotion\": {orbitElements[index: i]},",
							9 => $"\t\"SemiMajorAxis\": {orbitElements[index: i]},",
							10 => $"\t\"AbsoluteMagnitude\": {orbitElements[index: i]},",
							11 => $"\t\"SlopeParameter\": {orbitElements[index: i]} ",
							12 => $"\t\"Reference\": \"{orbitElements[index: i]}\",",
							13 => $"\t\"NumberOfOppositions\": {orbitElements[index: i]},",
							14 => $"\t\"NumberOfObservations\": {orbitElements[index: i]},",
							15 => $"\t\"ObservationSpan\": \"{orbitElements[index: i]}\",",
							16 => $"\t\"RmsResidual\": {orbitElements[index: i]},",
							17 => $"\t\"ComputerName\": \"{orbitElements[index: i]}\",",
							18 => $"\t\"FourHexdigitFlags\": \"{orbitElements[index: i]}\",",
							19 => $"\t\"DateOfLastObservation\": \"{orbitElements[index: i]}\",",
							20 => $"\t\"LinearEccentricity\": {orbitElements[index: i]},",
							21 => $"\t\"SemiMinorAxis\": {orbitElements[index: i]},",
							22 => $"\t\"MajorAxis\": {orbitElements[index: i]},",
							23 => $"\t\"MinorAxis\": {orbitElements[index: i]},",
							24 => $"\t\"EccenctricAnomaly\": {orbitElements[index: i]},",
							25 => $"\t\"TrueAnomaly\": {orbitElements[index: i]},",
							26 => $"\t\"PerihelionDistance\": {orbitElements[index: i]},",
							27 => $"\t\"AphelionDistance\": {orbitElements[index: i]},",
							28 => $"\t\"LongitudeOfDescendingNode\": {orbitElements[index: i]},",
							29 => $"\t\"ArgumentOfAphelion\": {orbitElements[index: i]},",
							30 => $"\t\"FocalParameter\": {orbitElements[index: i]},",
							31 => $"\t\"SemiLatusRectum\": {orbitElements[index: i]},",
							32 => $"\t\"LatusRectum\": {orbitElements[index: i]},",
							33 => $"\t\"OrbitalPeriod\": {orbitElements[index: i]},",
							34 => $"\t\"OrbitalArea\": {orbitElements[index: i]},",
							35 => $"\t\"OrbitalPerimeter\": {orbitElements[index: i]},",
							36 => $"\t\"SemiMeanAxis\": {orbitElements[index: i]},",
							37 => $"\t\"MeanAxis\": {orbitElements[index: i]},",
							38 => $"\t\"StandardGravitationalParameter\": {orbitElements[index: i]}",
							_ => string.Empty
						});
					}
				}
				_ = sb.AppendLine(value: "}");
				streamWriter.Write(value: sb.ToString());
			}
		}

		/// <summary>
		/// Handles the Click event of the ButtonMarkAll control.
		/// Marks all items in the list.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMarkAll_Click(object sender, EventArgs e) => MarkAll();

		/// <summary>
		/// Handles the Click event of the ButtonUnmarkAll control.
		/// Unmarks all items in the list.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonUnmarkAll_Click(object sender, EventArgs e) => UnmarkAll();

		#endregion

		/// <summary>
		/// Handles the ItemCheck event of the CheckedListBoxOrbitalElements control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CheckedListBoxOrbitalElements_ItemCheck(object sender, ItemCheckEventArgs e)
		{
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the CheckedListBoxOrbitalElements control.
		/// Enables or disables export buttons based on whether all items are unmarked.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CheckedListBoxOrbitalElements_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonExportAsTxt.Enabled = IsAllUnmarked()
				? (buttonExportAsHtml.Enabled = buttonExportAsXml.Enabled = buttonExportAsJson.Enabled = false)
				: (buttonExportAsHtml.Enabled = buttonExportAsXml.Enabled = buttonExportAsJson.Enabled = true);
		}

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ExportDataSheetForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
