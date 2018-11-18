using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Office2007Rendering;

namespace PlanetoidDB
{

  public partial class TableModeForm : Form
  {
    ArrayList arrDB = new ArrayList(0);
    int numberPlanetoids = 0;
    bool isCancelled = false;
		string strIndex, strMagAbs, strSlopeParam, strEpoch, strMeanAnomaly, strArgPeri, strLongAscNode, strIncl, strOrbEcc, strMotion, strSemiMajorAxis, strRef, strNumbObs, strNumbOppos, strObsSpan, strRmsResdiual, strComputerName, strFlags, strDesgnName, strObsLastDate;

		/// <summary>
		/// 
		/// </summary>
		public TableModeForm() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		public void SetProgressbar(int value) => progressBar.Value = value;//labelDataLoading.Text = "Loading data... " + value + "%";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arrTemp"></param>
		public void FillArray(ArrayList arrTemp)
    {
      arrDB = arrTemp;
      numberPlanetoids = arrDB.Count;
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text);
			MessageBox.Show("Copied to clipboard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// 
		/// </summary>
		private void ClearLabelHelp()
    {
      labelHelp.Text = "";
      labelHelp.Enabled = false;
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetLabelText(string text)
		{
			labelHelp.Text = text;
			labelHelp.Enabled = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="currentPosition"></param>
		private void FormatRow(int currentPosition)
    {
      //Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Lerrstrings sind.
      // if (teilstring == "0") zahl = 0; ...
      strIndex = arrDB[currentPosition].ToString().Substring(0, 7).Trim();
      strMagAbs = arrDB[currentPosition].ToString().Substring(8, 5).Trim();
      strSlopeParam = arrDB[currentPosition].ToString().Substring(14, 5).Trim();
      strEpoch = arrDB[currentPosition].ToString().Substring(20, 5).Trim();
      strMeanAnomaly = arrDB[currentPosition].ToString().Substring(26, 9).Trim();
      strArgPeri = arrDB[currentPosition].ToString().Substring(37, 9).Trim();
      strLongAscNode = arrDB[currentPosition].ToString().Substring(48, 9).Trim();
      strIncl = arrDB[currentPosition].ToString().Substring(59, 9).Trim();
      strOrbEcc = arrDB[currentPosition].ToString().Substring(70, 9).Trim();
      strMotion = arrDB[currentPosition].ToString().Substring(80, 11).Trim();
      strSemiMajorAxis = arrDB[currentPosition].ToString().Substring(92, 11).Trim();
      strRef = arrDB[currentPosition].ToString().Substring(107, 9).Trim();
      strNumbObs = arrDB[currentPosition].ToString().Substring(117, 5).Trim();
      strNumbOppos = arrDB[currentPosition].ToString().Substring(123, 3).Trim();
      strObsSpan = arrDB[currentPosition].ToString().Substring(127, 9).Trim();
      strRmsResdiual = arrDB[currentPosition].ToString().Substring(137, 4).Trim();
      strComputerName = arrDB[currentPosition].ToString().Substring(150, 10).Trim();
      strFlags = arrDB[currentPosition].ToString().Substring(161, 4).Trim();
      strDesgnName = arrDB[currentPosition].ToString().Substring(166, 28).Trim();
      strObsLastDate = arrDB[currentPosition].ToString().Substring(194, 8).Trim();
			ListViewItem listViewItem = new ListViewItem(text: strIndex)
			{
				ToolTipText = strIndex + ": " + strDesgnName
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

    /// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TableModeForm_Load(object sender, EventArgs e)
    {
      labelHelp.Text = "";
      labelHelp.Enabled = false;
      listViewTableMode.Visible = false;
      buttonCancel.Enabled = false;
      if (arrDB.Count > 0)
      {
        numericUpDownMinimum.Minimum = 1;
        numericUpDownMaximum.Minimum = 1;
        numericUpDownMinimum.Maximum = arrDB.Count;
        numericUpDownMaximum.Maximum = arrDB.Count;
        numericUpDownMinimum.Value = 1;
        numericUpDownMaximum.Value = arrDB.Count;
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
      this.Dispose();
    }

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
        TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: i, progressMax: (int)numericUpDownMaximum.Value);
        if (isCancelled) break;
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
      TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: 0, progressMax: 100);
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMinimum_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: buttonCancel.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMinimum_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMinimum.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMinimum_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumericUpDownMinimum_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: numericUpDownMinimum.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMaximum_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMaximum.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMaximum_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMaximum.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMaximum_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonList_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonList.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonList_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancel_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonCancel.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancel_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBoxWarning_DoubleClick(object sender, EventArgs e)
    {
			SoundPlayer sound = new SoundPlayer(Planetoid_DB.Properties.Resources.wav_redalert);
			sound.Play();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBoxWarning_MouseEnter(object sender, EventArgs e) => SetLabelText(text: pictureBoxWarning.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBoxWarning_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelWarning1_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelWarning1.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelWarning1_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelWarning1.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelWarning1_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelWarning2_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelWarning2.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelWarning2_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelWarning2.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelWarning2_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProgressBar_MouseEnter(object sender, EventArgs e) => SetLabelText(text: progressBar.AccessibleDescription + ": " + progressBar.Value);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProgressBar_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListViewTableMode_MouseEnter(object sender, EventArgs e) => SetLabelText(text: listViewTableMode.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListViewTableMode_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStatus_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelHelp.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelStatus_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListViewTableMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      //labelStatus.Text = listViewTableMode.SelectedItems[1].Text;
      if (listViewTableMode.SelectedIndices.Count <= 0) return;
      int intselectedindex = listViewTableMode.SelectedIndices[0];
      if (intselectedindex >= 0) SetLabelText(text: "Index: " + listViewTableMode.Items[intselectedindex].Text + " - " + listViewTableMode.Items[intselectedindex].SubItems[1].Text);
    }
  }
}
