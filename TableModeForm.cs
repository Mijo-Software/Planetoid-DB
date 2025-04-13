using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents the form for displaying planetoid data in table mode.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class TableModeForm : KryptonForm
	{
		/// <summary>
		/// The database of planetoids.
		/// </summary>
		private List<string> planetoidDatabase = [];

		// Indicates whether the application is currently busy.
		private bool isBusy = false;

		/// <summary>
		/// The number of planetoids in the database.
		/// </summary>
		private int numberPlanetoids = 0;

		/// <summary>
		/// Indicates whether the operation is cancelled.
		/// </summary>
		private bool isCancelled = false;

		/// <summary>
		/// The index of the planetoid.
		/// </summary>
		private string strIndex = string.Empty;

		/// <summary>
		/// The absolute magnitude of the planetoid.
		/// </summary>
		private string strMagAbs = string.Empty;

		/// <summary>
		/// The slope parameter of the planetoid.
		/// </summary>
		private string strSlopeParam = string.Empty;

		/// <summary>
		/// The epoch of the planetoid.
		/// </summary>
		private string strEpoch = string.Empty;

		/// <summary>
		/// The mean anomaly of the planetoid.
		/// </summary>
		private string strMeanAnomaly = string.Empty;

		/// <summary>
		/// The argument of perihelion of the planetoid.
		/// </summary>
		private string strArgPeri = string.Empty;

		/// <summary>
		/// The longitude of the ascending node of the planetoid.
		/// </summary>
		private string strLongAscNode = string.Empty;

		/// <summary>
		/// The inclination of the planetoid.
		/// </summary>
		private string strIncl = string.Empty;

		/// <summary>
		/// The orbital eccentricity of the planetoid.
		/// </summary>
		private string strOrbEcc = string.Empty;

		/// <summary>
		/// The mean daily motion of the planetoid.
		/// </summary>
		private string strMotion = string.Empty;

		/// <summary>
		/// The semi-major axis of the planetoid.
		/// </summary>
		private string strSemiMajorAxis = string.Empty;

		/// <summary>
		/// The reference for the planetoid data.
		/// </summary>
		private string strRef = string.Empty;

		/// <summary>
		/// The number of observations of the planetoid.
		/// </summary>
		private string strNumbObs = string.Empty;

		/// <summary>
		/// The number of oppositions of the planetoid.
		/// </summary>
		private string strNumbOppos = string.Empty;

		/// <summary>
		/// The observation span of the planetoid.
		/// </summary>
		private string strObsSpan = string.Empty;

		/// <summary>
		/// The RMS residual of the planetoid.
		/// </summary>
		private string strRmsResdiual = string.Empty;

		/// <summary>
		/// The name of the computer that processed the planetoid data.
		/// </summary>
		private string strComputerName = string.Empty;

		/// <summary>
		/// The flags associated with the planetoid.
		/// </summary>
		private string strFlags = string.Empty;

		/// <summary>
		/// The designation name of the planetoid.
		/// </summary>
		private string strDesgnName = string.Empty;

		/// <summary>
		/// The date of the last observation of the planetoid.
		/// </summary>
		private string strObsLastDate = string.Empty;

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="TableModeForm"/> class.
		/// </summary>
		public TableModeForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(TableModeForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

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
		/// Fills the planetoid database with the specified array.
		/// </summary>
		/// <param name="arrTemp">The array to fill the database with.</param>
		public void FillArray(ArrayList arrTemp)
		{
			planetoidDatabase = [.. arrTemp.Cast<string>()];
			numberPlanetoids = planetoidDatabase.Count;
		}

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
		/// Formats the row at the specified position.
		/// </summary>
		/// <param name="currentPosition">The position of the row to format.</param>
		private void FormatRow(int currentPosition)
		{
			string? planetoid = planetoidDatabase[index: currentPosition]?.ToString();
			if (planetoid != null)
			{
				strIndex = planetoid[..7].Trim();
				strMagAbs = planetoid.Substring(startIndex: 8, length: 5).Trim();
				strSlopeParam = planetoid.Substring(startIndex: 14, length: 5).Trim();
				strEpoch = planetoid.Substring(startIndex: 20, length: 5).Trim();
				strMeanAnomaly = planetoid.Substring(startIndex: 26, length: 9).Trim();
				strArgPeri = planetoid.Substring(startIndex: 37, length: 9).Trim();
				strLongAscNode = planetoid.Substring(startIndex: 48, length: 9).Trim();
				strIncl = planetoid.Substring(startIndex: 59, length: 9).Trim();
				strOrbEcc = planetoid.Substring(startIndex: 70, length: 9).Trim();
				strMotion = planetoid.Substring(startIndex: 80, length: 11).Trim();
				strSemiMajorAxis = planetoid.Substring(startIndex: 92, length: 11).Trim();
				strRef = planetoid.Substring(startIndex: 107, length: 9).Trim();
				strNumbObs = planetoid.Substring(startIndex: 117, length: 5).Trim();
				strNumbOppos = planetoid.Substring(startIndex: 123, length: 3).Trim();
				strObsSpan = planetoid.Substring(startIndex: 127, length: 9).Trim();
				strRmsResdiual = planetoid.Substring(startIndex: 137, length: 4).Trim();
				strComputerName = planetoid.Substring(startIndex: 150, length: 10).Trim();
				strFlags = planetoid.Substring(startIndex: 161, length: 4).Trim();
				strDesgnName = planetoid.Substring(startIndex: 166, length: 28).Trim();
				strObsLastDate = planetoid.Substring(startIndex: 194, length: 8).Trim();
				ListViewItem listViewItem = new(text: strIndex)
				{
					ToolTipText = $"{strIndex}: {strDesgnName}"
				};
				_ = listViewItem.SubItems.Add(text: strDesgnName);
				_ = listViewItem.SubItems.Add(text: strEpoch);
				_ = listViewItem.SubItems.Add(text: strMeanAnomaly);
				_ = listViewItem.SubItems.Add(text: strArgPeri);
				_ = listViewItem.SubItems.Add(text: strLongAscNode);
				_ = listViewItem.SubItems.Add(text: strIncl);
				_ = listViewItem.SubItems.Add(text: strOrbEcc);
				_ = listViewItem.SubItems.Add(text: strMotion);
				_ = listViewItem.SubItems.Add(text: strSemiMajorAxis);
				_ = listViewItem.SubItems.Add(text: strMagAbs);
				_ = listViewItem.SubItems.Add(text: strSlopeParam);
				_ = listViewItem.SubItems.Add(text: strRef);
				_ = listViewItem.SubItems.Add(text: strNumbOppos);
				_ = listViewItem.SubItems.Add(text: strNumbObs);
				_ = listViewItem.SubItems.Add(text: strObsSpan);
				_ = listViewItem.SubItems.Add(text: strRmsResdiual);
				_ = listViewItem.SubItems.Add(text: strComputerName);
				_ = listViewItem.SubItems.Add(text: strFlags);
				_ = listViewItem.SubItems.Add(text: strObsLastDate);
				_ = listView.Items.Add(value: listViewItem);
			}
		}

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event of the TableModeForm.
		/// Initializes the form controls and sets their initial values.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TableModeForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelInformation.Enabled = listView.Visible = buttonCancel.Enabled = false;
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
		/// Handles the FormClosed event of the TableModeForm.
		/// Disposes the list view and the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void TableModeForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			listView.Dispose();
			Dispose();
		}

		#endregion

		#region BackgroundWorker

		/// <summary>
		/// Handles the DoWork event of the BackgroundWorker.
		/// Processes the planetoid data in the background.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="DoWorkEventArgs"/> instance that contains the event data.</param>
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
		/// Handles the ProgressChanged event of the BackgroundWorker.
		/// Updates the progress bar with the current progress.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e) => progressBar.Value = e.ProgressPercentage;

		/// <summary>
		/// Handles the RunWorkerCompleted event of the BackgroundWorker.
		/// Finalizes the background work and updates the UI.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
		{
			isBusy = false;
			listView.Visible = true;
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
		/// Called when the mouse pointer moves over a control.
		/// Sets the status bar text to the control's accessible description.
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
		/// Called when the mouse pointer leaves a control.
		/// Clears the status bar text.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region SelectedIndexChanged event handlers

		/// <summary>
		/// Handles the SelectedIndexChanged event of the ListView.
		/// Updates the status bar with the selected planetoid's index and designation name.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ListViewTableMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView.SelectedIndices.Count > 0)
			{
				int selectedIndex = listView.SelectedIndices[index: 0];
				if (selectedIndex >= 0)
				{
					SetStatusbar(text: $"{I10nStrings.Index}: {listView.Items[index: selectedIndex].Text} - {listView.Items[index: selectedIndex].SubItems[index: 1].Text}");
				}
			}
		}
		#endregion

		#region Clicks event handlers

		/// <summary>
		/// Handles the Click event of the List button.
		/// Starts the background worker to process the planetoid data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonList_Click(object sender, EventArgs e)
		{
			listView.Clear();
			listView.Columns.AddRange(values: [
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
				 columnHeaderDateLastObservation]);
			listView.Visible = false;
			numericUpDownMinimum.Enabled = false;
			numericUpDownMaximum.Enabled = false;
			buttonCancel.Enabled = true;
			buttonList.Enabled = false;
			isCancelled = false;
			progressBar.Enabled = true;
			isBusy = true;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);
			backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
			backgroundWorker.RunWorkerAsync();
		}

		/// <summary>
		/// Handles the Click event of the Cancel button.
		/// Cancels the background worker operation.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			isCancelled = true;
			isBusy = false;
		}

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// Called when a control is double-clicked to copy the text to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			ArgumentNullException.ThrowIfNull(argument: sender);
			if (sender is Control control)
			{
				CopyToClipboard(text: control.Text);
			}
		}

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the TableModeForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TableModeForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (!isBusy && e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
