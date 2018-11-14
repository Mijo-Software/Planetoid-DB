using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

    public TableModeForm()
    {
      InitializeComponent();
    }

    public void setProgressbar(int value)
    {
      progressBar.Value = value;
      //labelDataLoading.Text = "Loading data... " + value + "%";
    }

    public void fillArray(ArrayList arrTemp)
    {
      arrDB = arrTemp;
      numberPlanetoids = arrDB.Count;
    }

    private void showMessageCopiedToClipboad()
    {
      MessageBox.Show("Copied to clipboard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void clearLabelHelp()
    {
      labelStatus.Text = "";
      labelStatus.Enabled = false;
    }

    private void preformatRow(int cp)
    {
      string strIndex, strMagAbs, strSlopeParam, strEpoch, strMeanAnomaly, strArgPeri, strLongAscNode, strIncl, strOrbEcc, strMotion, strSemiMajorAxis, strRef, strNumbObs, strNumbOppos, strObsSpan, strRmsResdiual, strComputerName, strFlags, strDesgnName, strObsLastDate;
      //Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Lerrstrings sind.
      // if (teilstring == "0") zahl = 0; ...
      strIndex = arrDB[cp].ToString().Substring(0, 7); strIndex = strIndex.Trim();
      strMagAbs = arrDB[cp].ToString().Substring(8, 5); strMagAbs = strMagAbs.Trim();
      strSlopeParam = arrDB[cp].ToString().Substring(14, 5); strSlopeParam = strSlopeParam.Trim();
      strEpoch = arrDB[cp].ToString().Substring(20, 5); strEpoch = strEpoch.Trim();
      strMeanAnomaly = arrDB[cp].ToString().Substring(26, 9); strMeanAnomaly = strMeanAnomaly.Trim();
      strArgPeri = arrDB[cp].ToString().Substring(37, 9); strArgPeri = strArgPeri.Trim();
      strLongAscNode = arrDB[cp].ToString().Substring(48, 9); strLongAscNode = strLongAscNode.Trim();
      strIncl = arrDB[cp].ToString().Substring(59, 9); strIncl = strIncl.Trim();
      strOrbEcc = arrDB[cp].ToString().Substring(70, 9); strOrbEcc = strOrbEcc.Trim();
      strMotion = arrDB[cp].ToString().Substring(80, 11); strMotion = strMotion.Trim();
      strSemiMajorAxis = arrDB[cp].ToString().Substring(92, 11); strSemiMajorAxis = strSemiMajorAxis.Trim();
      strRef = arrDB[cp].ToString().Substring(107, 9); strRef = strRef.Trim();
      strNumbObs = arrDB[cp].ToString().Substring(117, 5); strNumbObs = strNumbObs.Trim();
      strNumbOppos = arrDB[cp].ToString().Substring(123, 3); strNumbOppos = strNumbOppos.Trim();
      strObsSpan = arrDB[cp].ToString().Substring(127, 9); strObsSpan = strObsSpan.Trim();
      strRmsResdiual = arrDB[cp].ToString().Substring(137, 4); strRmsResdiual = strRmsResdiual.Trim();
      strComputerName = arrDB[cp].ToString().Substring(150, 10); strComputerName = strComputerName.Trim();
      strFlags = arrDB[cp].ToString().Substring(161, 4); strFlags = strFlags.Trim();
      strDesgnName = arrDB[cp].ToString().Substring(166, 28); strDesgnName = strDesgnName.Trim();
      strObsLastDate = arrDB[cp].ToString().Substring(194, 8); strObsLastDate = strObsLastDate.Trim();

      ListViewItem lvi = new ListViewItem(strIndex);
      lvi.ToolTipText = strIndex + ": " + strDesgnName;
      lvi.SubItems.Add(strDesgnName);
      lvi.SubItems.Add(strEpoch);
      lvi.SubItems.Add(strMeanAnomaly);
      lvi.SubItems.Add(strArgPeri);
      lvi.SubItems.Add(strLongAscNode);
      lvi.SubItems.Add(strIncl);
      lvi.SubItems.Add(strOrbEcc);
      lvi.SubItems.Add(strMotion);
      lvi.SubItems.Add(strSemiMajorAxis);
      lvi.SubItems.Add(strMagAbs);
      lvi.SubItems.Add(strSlopeParam);
      lvi.SubItems.Add(strRef);
      lvi.SubItems.Add(strNumbOppos);
      lvi.SubItems.Add(strNumbObs);
      lvi.SubItems.Add(strObsSpan);
      lvi.SubItems.Add(strRmsResdiual);
      lvi.SubItems.Add(strComputerName);
      lvi.SubItems.Add(strFlags);
      lvi.SubItems.Add(strObsLastDate);
      listViewTableMode.Items.Add(lvi);
    }

    private void TableModeForm_Load(object sender, EventArgs e)
    {
      labelStatus.Text = "";
      labelStatus.Enabled = false;
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

    private void TableModeForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      listViewTableMode.Dispose();
      this.Dispose();
    }

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      progressBar.Maximum = (int)numericUpDownMaximum.Value - 1;
      for (int i = (int)numericUpDownMinimum.Value - 1; i < (int)numericUpDownMaximum.Value; i++)
      {
        preformatRow(i);
        backgroundWorker.ReportProgress(i);
        TaskbarProgress.SetValue(this.Handle, i, (int)numericUpDownMaximum.Value);
        if (isCancelled) break;
      }
    }

    private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressBar.Value = e.ProgressPercentage;
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      listViewTableMode.Visible = true;
      numericUpDownMinimum.Enabled = true;
      numericUpDownMaximum.Enabled = true;
      buttonList.Enabled = true;
      buttonCancel.Enabled = false;
      progressBar.Enabled = false;
      TaskbarProgress.SetValue(this.Handle, 0, 100);
    }

    private void buttonList_Click(object sender, EventArgs e)
    {
      listViewTableMode.Clear();
      listViewTableMode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
      backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
      backgroundWorker.RunWorkerAsync();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      isCancelled = true;
    }

    private void labelMinimum_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(buttonCancel.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMinimum_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = labelMinimum.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void labelMinimum_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void numericUpDownMinimum_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(numericUpDownMinimum.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMaximum_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMaximum.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMaximum_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = labelMaximum.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void labelMaximum_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonList_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = buttonList.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void buttonList_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonCancel_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = buttonCancel.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void buttonCancel_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void pictureBoxWarning_DoubleClick(object sender, EventArgs e)
    {
      //easter egg | mini game ???
      // MP§: Houston, we have a problem!
    }

    private void pictureBoxWarning_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = pictureBoxWarning.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void pictureBoxWarning_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelWarning1_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelWarning1.Text);
      showMessageCopiedToClipboad();
    }

    private void labelWarning1_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = labelWarning1.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void labelWarning1_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelWarning2_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelWarning2.Text);
      showMessageCopiedToClipboad();
    }

    private void labelWarning2_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = labelWarning2.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void labelWarning2_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void progressBar_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = progressBar.AccessibleDescription + ": " + progressBar.Value;
      labelStatus.Enabled = true;
    }

    private void progressBar_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void listViewTableMode_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = listViewTableMode.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void listViewTableMode_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelStatus_MouseEnter(object sender, EventArgs e)
    {
      labelStatus.Text = labelStatus.AccessibleDescription;
      labelStatus.Enabled = true;
    }

    private void labelStatus_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void listViewTableMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      //labelStatus.Text = listViewTableMode.SelectedItems[1].Text;
      if (listViewTableMode.SelectedIndices.Count <= 0)
      {
        return;
      }
      int intselectedindex = listViewTableMode.SelectedIndices[0];
      if (intselectedindex >= 0)
      {
        labelStatus.Text = "Index: " + listViewTableMode.Items[intselectedindex].Text + " - " + listViewTableMode.Items[intselectedindex].SubItems[1].Text; 
      }
    }
  }
}
