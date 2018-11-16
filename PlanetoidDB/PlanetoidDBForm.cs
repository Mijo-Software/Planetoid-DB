using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Office2007Rendering;
using VS2008StripRenderingLibrary;

namespace PlanetoidDB
{
	public partial class PlanetoidDBForm : Form
  {
		bool isDownloadCancelled = false;
		int currentPosition = 0, stepPosition = 0;
		ArrayList arrDB = new ArrayList(0);
    SplashScreenForm formSplashScreen = new SplashScreenForm();
    WebClient webClient = new WebClient();
		Uri uriMPCORB = new Uri(Planetoid_DB.Properties.Resources.strMpcorbUrl);

		private void Download(int i)
    {
      toolStripProgressBarBackgroundDownload.Visible = true;
      toolStripStatusLabelBackgroundDownload.Visible = true;
    }

    private void GotoCurrentPosition(int currentPosition)
    {
      //Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Lerrstrings sind.
      // if (teilstring == "0") zahl = 0; ...
			labelIndexValue.Text = arrDB[index: currentPosition].ToString().Substring(0, 7).Trim();
			labelMagAbsValue.Text = arrDB[index: currentPosition].ToString().Substring(8, 5).Trim();
			labelSlopeParamValue.Text = arrDB[index: currentPosition].ToString().Substring(14, 5).Trim();
      labelEpochValue.Text = arrDB[index: currentPosition].ToString().Substring(20, 5).Trim();
			labelMeanAnomalyValue.Text = arrDB[index: currentPosition].ToString().Substring(26, 9).Trim();
      labelArgPeriValue.Text = arrDB[index: currentPosition].ToString().Substring(37, 9).Trim();
      labelLongAscNodeValue.Text = arrDB[index: currentPosition].ToString().Substring(48, 9).Trim();
      labelInclValue.Text = arrDB[index: currentPosition].ToString().Substring(59, 9).Trim();
      labelOrbEccValue.Text = arrDB[index: currentPosition].ToString().Substring(70, 9).Trim();
      labelMotionValue.Text = arrDB[index: currentPosition].ToString().Substring(80, 11).Trim();
			labelSemiMajorAxisValue.Text = arrDB[index: currentPosition].ToString().Substring(92, 11).Trim();
			labelRefValue.Text = arrDB[index: currentPosition].ToString().Substring(107, 9).Trim();
			labelNumbObsValue.Text = arrDB[index: currentPosition].ToString().Substring(117, 5).Trim();
      labelNumbOpposValue.Text = arrDB[index: currentPosition].ToString().Substring(123, 3).Trim();
			labelObsSpanValue.Text = arrDB[index: currentPosition].ToString().Substring(127, 9).Trim();
			labelRmsResidualValue.Text = arrDB[index: currentPosition].ToString().Substring(137, 4).Trim();
      labelComputerNameValue.Text = arrDB[index: currentPosition].ToString().Substring(150, 10).Trim();
			labelFlagsValue.Text = arrDB[index: currentPosition].ToString().Substring(161, 4).Trim();
      labelDesgnNameValue.Text = arrDB[index: currentPosition].ToString().Substring(166, 28).Trim();
			labelObsLastDateValue.Text = arrDB[index: currentPosition].ToString().Substring(194, 8).Trim();
			labelIndexPos.Text = "Index: " + (currentPosition+1).ToString() + " / " + (arrDB.Count).ToString();
			trackBarIndex.Value = this.currentPosition;
    }

    /// <summary>
		/// 
		/// </summary>
		public PlanetoidDBForm()
    {
      InitializeComponent();
      this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
      clearLabelHelp();
    }

    private void PlanetoidDBForm_Load(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new Office2007Renderer();
      bwLoadingDB.WorkerReportsProgress = true;
      bwLoadingDB.WorkerSupportsCancellation = true;
      bwLoadingDB.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorkerLoadingDB_ProgressChanged);
      bwLoadingDB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerLoadingDB_RunWorkerCompleted);
      bwLoadingDB.RunWorkerAsync();
      formSplashScreen.Show();
      formSplashScreen.Update();
    }

    private void PlanetoidDBForm_Shown(object sender, EventArgs e)
    {
      toolStripStatusLabelBackgroundDownload.Enabled = false;
      toolStripProgressBarBackgroundDownload.Enabled = false;
      if (IsMpcorbDatUpdateAviable() == true)
      {
        timerUpdateBlink.Enabled = true;
        toolStripStatusLabelUpdate.Enabled = true;
      }
      else
      {
        timerUpdateBlink.Enabled = false;
        toolStripStatusLabelUpdate.Enabled = false;
      }
    }

    private void ButtonStepToBegin_Click(object sender, EventArgs e)
    {
      currentPosition = 0;
      GotoCurrentPosition(currentPosition);
    }

    private void ButtonStepBackward_Click(object sender, EventArgs e)
    {
      currentPosition = currentPosition - stepPosition;
      if (currentPosition < 1) currentPosition = arrDB.Count + currentPosition;
      GotoCurrentPosition(currentPosition);
    }

    private void ButtonStepBackward1_Click(object sender, EventArgs e)
    {
      if (currentPosition == 0) currentPosition = arrDB.Count - 1; else currentPosition--;
      GotoCurrentPosition(currentPosition);
    }
    
    private void ButtonStepForward1_Click(object sender, EventArgs e)
    {
      if (currentPosition == arrDB.Count - 1) currentPosition = 0; else currentPosition++;
      GotoCurrentPosition(currentPosition);
    }

    private void ButtonStepForward_Click(object sender, EventArgs e)
    {
      currentPosition = currentPosition + stepPosition;
      if (currentPosition > arrDB.Count) currentPosition = currentPosition - arrDB.Count;
      GotoCurrentPosition(currentPosition);
    }

    private void ButtonStepToEnd_Click(object sender, EventArgs e)
    {
      currentPosition = arrDB.Count - 1;
      GotoCurrentPosition(currentPosition);
    }

    private void ButtonGotoIndex_Click(object sender, EventArgs e)
    {
      currentPosition = (int)numericUpDownGotoIndex.Value - 1;
      GotoCurrentPosition(currentPosition);
    }

    private void ToolStripMenuItem_Clear()
    {
      toolStripMenuItem10.Checked = false;
      toolStripMenuItem100.Checked = false;
      toolStripMenuItem1000.Checked = false;
      toolStripMenuItem10000.Checked = false;
      toolStripMenuItem100000.Checked = false;
    }

    private void ToolStripMenuItem10_Click(object sender, EventArgs e)
    {
      stepPosition = 10;
      ToolStripMenuItem_Clear();
      toolStripMenuItem10.Checked = true;
    }

    private void ToolStripMenuItem100_Click(object sender, EventArgs e)
    {
      stepPosition = 100;
      ToolStripMenuItem_Clear();
      toolStripMenuItem100.Checked = true;
    }

    private void ToolStripMenuItem1000_Click(object sender, EventArgs e)
    {
      stepPosition = 1000;
      ToolStripMenuItem_Clear();
      toolStripMenuItem1000.Checked = true;
    }

    private void ToolStripMenuItem10000_Click(object sender, EventArgs e)
    {
      stepPosition = 10000;
      ToolStripMenuItem_Clear();
      toolStripMenuItem10000.Checked = true;
    }

    private void ToolStripMenuItem100000_Click(object sender, EventArgs e)
    {
      stepPosition = 100000;
      ToolStripMenuItem_Clear();
      toolStripMenuItem100000.Checked = true;
    }

		private void MenuitemExit_Click(object sender, EventArgs e) => Close();

		private void MenuitemAbout_Click(object sender, EventArgs e)
    {
      AppInfoForm formAppInfo = new AppInfoForm();
      formAppInfo.ShowDialog();
    }

		private void MenuitemOpenWebsitePDB_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(Planetoid_DB.Properties.Resources.strHomepage);

		private void MenuitemOpenWebsiteMPC_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(Planetoid_DB.Properties.Resources.strWebsiteMpc);

		private void MenuitemOpenMPCORBWebsite_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(Planetoid_DB.Properties.Resources.strWebsiteMpcorb);

		private void MenuitemDownloadMpcorbDat_Click(object sender, EventArgs e)
    {
      DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
      formDownloaderForMpcorbDat.ShowDialog();
    }

    private void TrackBarIndex_Scroll(object sender, EventArgs e)
    {
      currentPosition = trackBarIndex.Value;
      GotoCurrentPosition(currentPosition);
    }

    private void BackgroundWorkerLoadingDB_DoWork(object sender, DoWorkEventArgs e)
    {
      this.Enabled = false;
      string fileName = Planetoid_DB.Properties.Resources.strFilenameMPCORB;

      if (!File.Exists(fileName))
      {
        this.Hide();
        formSplashScreen.Close();
        MessageBox.Show("No file found. Program is quitting!\n\r\n\r1. Download \"" + uriMPCORB.ToString() + "\"!\n\r\n\r2. Copy it into \"" + Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\"!\n\r\n\r3. Restart!", "No file found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Close();
      } else { 
        formSplashScreen.Show();
      }

      FileInfo fi = new FileInfo(fileName);
      long fileSize = fi.Length, fileSizeReaded = 0;
      int step = 0, lineNum = 0;
      FileStream fs;
      StreamReader sr;
      string readLine;

      fs = new FileStream(fileName, FileMode.Open);
      sr = new StreamReader(fs);

      while (sr.Peek() != -1 && !bwLoadingDB.CancellationPending)
      {
        readLine = sr.ReadLine();
        fileSizeReaded = fileSizeReaded + readLine.Length;
        float percent = 100 * fileSizeReaded / fileSize;
        step = (int)percent;
        formSplashScreen.setProgressbar(step);
        lineNum++;
        if ((lineNum >= 44) && (readLine != "")) { arrDB.Add(readLine); }
      }

      fs.Close();
      sr.Close();
      formSplashScreen.Close();
      formSplashScreen.Dispose();
    }

		private void BackgroundWorkerLoadingDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      //formSplashScreen.setProgressbar(e.ProgressPercentage);
      //TaskbarProgress.SetValue(this.Handle, e.ProgressPercentage, 100);
    }

		private void BackgroundWorkerLoadingDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      numericUpDownGotoIndex.Minimum = 1;
      numericUpDownGotoIndex.Maximum = arrDB.Count;
      currentPosition = 0;
      stepPosition = 100;
      GotoCurrentPosition(currentPosition);
      trackBarIndex.Value = 1;
      trackBarIndex.Maximum = arrDB.Count - 1;
      trackBarIndex.TickFrequency = 1;
      trackBarIndex.TickFrequency = (int)trackBarIndex.Maximum;
      this.Enabled = true;
      TaskbarProgress.SetValue(this.Handle, 0, 100);
			#if DEBUG
				Console.Write("Asynchroner Thread kam bis zum Wert: " + e.Result.ToString());
			#endif
		}

		private void MenuitemCheckMpcorbDat_Click(object sender, EventArgs e) => checkMpcorbDat();

		private DateTime GetLastModified(Uri uriLastModiefied)
    {
      HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriLastModiefied);
      HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
      return resp.LastModified;
    }

    private long GetContentLength(Uri uriContentLength)
    {
      HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriContentLength);
      HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			long bytesTotal = Convert.ToInt64(resp.ContentLength);
      //webClient.OpenRead(uriContentLength);
      //Int64 bytesTotal = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
      return bytesTotal;
    }

    private bool IsMpcorbDatUpdateAviable()
    {
      FileInfo fi = new FileInfo(fileName: Planetoid_DB.Properties.Resources.strFilenameMPCORB);
      long fileSize = fi.Length;
      DateTime datetimeFileLocal = fi.CreationTime;
      DateTime datetimeFileOnline = GetLastModified(uriLastModiefied: uriMPCORB);
      if (datetimeFileOnline > datetimeFileLocal) return true; else return false;
    }

		private void CopyToClipboad(string text)
		{
			Clipboard.SetText(text);
			MessageBox.Show("Copied to clipboard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LabelIndexValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelIndexValue.Text);

		private void LabelDesgnNameValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelDesgnNameValue.Text);

		private void LabelEpochValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelEpochValue.Text);

		private void LabelMeanAnomalyValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelMeanAnomalyValue.Text);

		private void LabelArgPeriValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelArgPeriValue.Text);

		private void LabelLongAscNodeValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelLongAscNodeValue.Text);

		private void LabelInclValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelLongAscNodeValue.Text);

		private void LabelOrbEccValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelOrbEccValue.Text);

		private void LabelMotionValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelMotionValue.Text);

		private void LabelSemiMajorAxisValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelSemiMajorAxisValue.Text);

		private void LabelMagAbsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelMagAbsValue.Text);

		private void LabelSlopeParamValue_Click(object sender, EventArgs e) => CopyToClipboad(labelSlopeParamValue.Text);

		private void LabelSlopeParamValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelSlopeParamValue.Text);

		private void LabelRefValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelRefValue.Text);

		private void LabelNumbOpposValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelNumbOpposValue.Text);

		private void LabelNumbObsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelNumbObsValue.Text);

		private void LabelObsSpanValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelObsSpanValue.Text);

		private void LabelRmsResidualValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelRmsResidualValue.Text);

		private void LabelComputerNameValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelComputerNameValue.Text);

		private void LabelFlagsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelFlagsValue.Text);

		private void LabelObsLastDateValue_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelObsLastDateValue.Text);

		private void LabelIndex_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelIndex.Text);

		private void LabelDesgnName_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelDesgnName.Text);

		private void LabelEpoch_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelEpoch.Text);

		private void LabelMeanAnomaly_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelMeanAnomaly.Text);

		private void LabelArgPeri_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelArgPeri.Text);

		private void LabelLongAscNode_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelLongAscNode.Text);

		private void LabelIncl_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelIncl.Text);

		private void LabelOrbEcc_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelOrbEcc.Text);

		private void LabelMotion_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelMotion.Text);

		private void LabelSemiMajorAxis_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelSemiMajorAxis.Text);

		private void LabelMagAbs_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelMagAbs.Text);

		private void LabelSlopeParam_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelSlopeParam.Text);

		private void LabelRef_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelRef.Text);

		private void LabelNumbOppos_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelNumbOppos.Text);

		private void LabelNumbObs_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelNumbObs.Text);

		private void LabelObsSpan_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelObsSpan.Text);

		private void LabelRmsResidual_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelRmsResidual.Text);

		private void LabelObsLastDate_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelObsLastDate.Text);

		private void LabelComputerName_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelComputerName.Text);

		private void LabelFlags_DoubleClick(object sender, EventArgs e) => CopyToClipboad(labelFlags.Text);

		private void ButtonStepToBegin_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepToBegin.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void ButtonStepToBegin_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void ButtonStepBackward_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepBackward.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void ButtonStepBackward_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void buttonStepBackward1_MouseEnter(object sender, EventArgs e)
    {h
      labelHelp.Text = buttonStepBackward1.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void buttonStepBackward1_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void buttonStepForward1_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepForward1.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void buttonStepForward1_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void buttonStepForward_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepForward.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void buttonStepForward_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void buttonStepToEnd_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepToEnd.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void buttonStepToEnd_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void buttonGotoIndex_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonGotoIndex.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void buttonGotoIndex_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void trackBarIndex_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = trackBarIndex.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void trackBarIndex_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemFile_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemFile.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemFile_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemExit_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemExit.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemExit_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemOptions_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOptions.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemOptions_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemCheckMpcorbDat_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemCheckMpcorbDat.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemCheckMpcorbDat_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemDownloadMpcorbDat_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemDownloadMpcorbDat.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemDownloadMpcorbDat_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemQuest_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemQuest.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemQuest_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemOpenWebsitePDB_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOpenWebsitePDB.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemOpenWebsitePDB_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemOpenWebsiteMPC_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOpenWebsiteMPC.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemOpenWebsiteMPC_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemOpenMPCORBWebsite_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOpenMPCORBWebsite.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemOpenMPCORBWebsite_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelIndexValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelIndexValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelIndexValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelDesgnNameValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelDesgnNameValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelDesgnNameValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelEpochValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelEpochValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelEpochValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelMeanAnomalyValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMeanAnomalyValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelMeanAnomalyValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelArgPeriValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelArgPeriValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelArgPeriValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelLongAscNodeValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelLongAscNodeValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelLongAscNodeValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelInclValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelInclValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelInclValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelOrbEccValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelOrbEccValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelOrbEccValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelMotionValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMotionValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelMotionValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelSemiMajorAxisValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSemiMajorAxisValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelSemiMajorAxisValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelMagAbsValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMagAbsValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelMagAbsValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelSlopeParamValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSlopeParamValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelSlopeParamValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelRefValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRefValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelRefValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelNumbOpposValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbOpposValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelNumbOpposValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelNumbObsValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbObsValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelNumbObsValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelObsSpanValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsSpanValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelObsSpanValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelRmsResidualValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRmsResidualValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelRmsResidualValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelComputerNameValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelComputerNameValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelComputerNameValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelFlagsValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelFlagsValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelFlagsValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelObsLastDateValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsLastDateValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelObsLastDateValue_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemAbout_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemAbout.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemAbout_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripSeparatorMisc_Click(object sender, EventArgs e)
    {
      //Reserved for later: easter egg
    }

    private void toolStripSeparatorMisc_MouseEnter(object sender, EventArgs e)
    {
      //Reserved for later: easter egg
    }

    private void toolStripSeparatorMisc_MouseLeave(object sender, EventArgs e)
    {
      //Reserved for later: easter egg
    }

    private void labelIndex_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelIndex.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelIndex_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelDesgnName_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelDesgnName.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelDesgnName_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelEpoch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelEpoch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelEpoch_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelMeanAnomaly_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMeanAnomaly.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelMeanAnomaly_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelArgPeri_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelArgPeri.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelArgPeri_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelLongAscNode_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelLongAscNode.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelLongAscNode_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelIncl_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelIncl.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelIncl_MouseMove(object sender, MouseEventArgs e) => clearLabelHelp();

		private void labelOrbEcc_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelOrbEcc.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelOrbEcc_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelMotion_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMotion.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelMotion_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelSemiMajorAxis_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSemiMajorAxis.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelSemiMajorAxis_MouseMove(object sender, MouseEventArgs e) => clearLabelHelp();

		private void labelMagAbs_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMagAbs.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelMagAbs_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelSlopeParam_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSlopeParam.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelSlopeParam_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelRef_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRef.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelRef_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelNumbOppos_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbOppos.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelNumbOppos_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelNumbObs_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbObs.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelNumbObs_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelObsSpan_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsSpan.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelObsSpan_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelRmsResidual_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRmsResidual.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelRmsResidual_MouseMove(object sender, MouseEventArgs e) => clearLabelHelp();

		private void labelComputerName_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelComputerName.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelComputerName_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelFlags_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelFlags.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelFlags_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelObsLastDate_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsLastDate.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelObsLastDate_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelIndex_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelDesgnName_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelEpoch_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelMeanAnomaly_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelArgPeri_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelLongAscNode_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelIncl_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelOrbEcc_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelMotion_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelSemiMajorAxis_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelMagAbs_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelSlopeParam_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelRef_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelNumbOppos_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelNumbObs_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelObsSpan_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelRmsResidual_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelComputerName_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelFlags_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void labelObsLastDate_Click(object sender, EventArgs e)
    {
      //Reserved für later: add a short message, what is; definition
    }

    private void clearLabelHelp()
    {
      labelHelp.Text = "";
      labelHelp.Enabled = false;
    }

    private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      toolStripProgressBarBackgroundDownload.Value = e.ProgressPercentage;
      TaskbarProgress.SetValue(this.Handle, 0, 100);
    }

    private void Completed(object sender, AsyncCompletedEventArgs e)
    {
      if (isDownloadCancelled == false)
      {
        File.Delete(Planetoid_DB.Properties.Resources.strFilenameMPCORB);
        File.Copy(Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp, Planetoid_DB.Properties.Resources.strFilenameMPCORB);
        File.Delete(Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp);
        MessageBox.Show("Download complete! You must restart the program to apply the update of the database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else {
        MessageBox.Show("Download cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        File.Delete(Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp);
      }
      toolStripStatusLabelBackgroundDownload.Enabled = false;
      toolStripProgressBarBackgroundDownload.Enabled = false;
      toolStripProgressBarBackgroundDownload.Value = toolStripProgressBarBackgroundDownload.Minimum;
      TaskbarProgress.SetValue(this.Handle, 0, 100);
    }

    private void timerUpdateBlink_Tick(object sender, EventArgs e)
    {
      if (toolStripStatusLabelUpdate.ForeColor == System.Drawing.SystemColors.HotTrack) toolStripStatusLabelUpdate.ForeColor = System.Drawing.SystemColors.ControlText; else toolStripStatusLabelUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
    }

    private void toolStripStatusLabelUpdate_Click(object sender, EventArgs e)
    {
      timerUpdateBlink.Enabled = false;
      if (MessageBox.Show("Do you want download the lastest MPCORB.DAT file?", "Download MPCORB.DAT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        toolStripStatusLabelBackgroundDownload.Enabled = true;
        toolStripProgressBarBackgroundDownload.Enabled = true;
        webClient.Proxy = null;
        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
        try
        {
          webClient.DownloadFileAsync(uriMPCORB, @Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      toolStripStatusLabelUpdate.Enabled = false;
      toolStripStatusLabelUpdate.IsLink = false;
    }

    private void toolStripStatusLabelUpdate_DoubleClick(object sender, EventArgs e)
    {
      timerUpdateBlink.Enabled = false;
      toolStripStatusLabelUpdate.Enabled = false;
    }

    private void toolStripStatusLabelBackgroundDownload_DoubleClick(object sender, EventArgs e)
    {
      isDownloadCancelled = true;
      webClient.CancelAsync();
    }

    private void toolStripProgressBarBackgroundDownload_DoubleClick(object sender, EventArgs e)
    {
      isDownloadCancelled = true;
      webClient.CancelAsync();
    }

    private void toolStripStatusLabelUpdate_MouseEnter(object sender, EventArgs e)
    {
      if (timerUpdateBlink.Enabled)
      {
        toolStripStatusLabelUpdate.IsLink = true;
      }
      labelHelp.Text = toolStripStatusLabelUpdate.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripStatusLabelUpdate_MouseLeave(object sender, EventArgs e)
    {
      if (timerUpdateBlink.Enabled)
      {
        toolStripStatusLabelUpdate.IsLink = false;
      }
      clearLabelHelp();
    }

    private void toolStripStatusLabelBackgroundDownload_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripStatusLabelBackgroundDownload.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripStatusLabelBackgroundDownload_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripProgressBarBackgroundDownload_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripProgressBarBackgroundDownload.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripProgressBarBackgroundDownload_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void labelIndexPos_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelIndexPos.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void labelIndexPos_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e) => checkMpcorbDat();

		private void toolStripButtonCheckMpcorbDat_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonCheckMpcorbDat.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonCheckMpcorbDat_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonDownloadMpcorbDat_Click(object sender, EventArgs e)
    {
      DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
      formDownloaderForMpcorbDat.ShowDialog();
    }

    private void toolStripButtonDownloadMpcorbDat_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonDownloadMpcorbDat.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonDownloadMpcorbDat_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonAbout_Click(object sender, EventArgs e)
    {
      AppInfoForm formAppInfo = new AppInfoForm();
      formAppInfo.ShowDialog();
    }

    private void toolStripButtonAbout_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonAbout.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonAbout_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(Planetoid_DB.Properties.Resources.strHomepage);
    }

    private void toolStripButtonOpenWebsitePDB_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonOpenWebsitePDB.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonOpenWebsitePDB_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void menuitemEdit_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemEdit.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void menuitemEdit_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonTableMode_Click(object sender, EventArgs e)
    {
      TableModeForm formTableMode = new TableModeForm();
      formTableMode.fillArray(arrDB);
      formTableMode.ShowDialog();
    }

    private void toolStripButtonTableMode_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonTableMode.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripMenuItemTableMode_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripMenuItemTableMode_Click(object sender, EventArgs e)
    {
      TableModeForm formTableMode = new TableModeForm();
      formTableMode.fillArray(arrDB);
      formTableMode.ShowDialog();
    }

    private void toolStripMenuItemTableMode_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemTableMode.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripButtonDatabaseInformation_Click(object sender, EventArgs e)
    {
      DatabaseInformationForm formDatabaseInformation = new DatabaseInformationForm();
      formDatabaseInformation.ShowDialog();
    }

		private void toolStripButtonTableMode_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void ToolStripMenuItemStyle_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = ToolStripMenuItemStyle.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void ToolStripMenuItemStyle_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void ToolStripMenuItemStyleOffice2007_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new Office2007Renderer();
      toolStripMenuItemStyleProfessional.Checked = false;
      toolStripMenuItemStyleOffice2007.Checked = true;
      toolStripMenuItemStyleSystem.Checked = false;
      toolStripMenuItemStyleVs2008.Checked = false;
    }

    private void ToolStripMenuItemStyleProfessionell_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new ToolStripProfessionalRenderer();
      toolStripMenuItemStyleProfessional.Checked = true;
      toolStripMenuItemStyleOffice2007.Checked = false;
      toolStripMenuItemStyleSystem.Checked = false;
      toolStripMenuItemStyleVs2008.Checked = false;
    }

    private void ToolStripMenuItemSystem_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new ToolStripSystemRenderer();
      toolStripMenuItemStyleProfessional.Checked = false;
      toolStripMenuItemStyleOffice2007.Checked = false;
      toolStripMenuItemStyleSystem.Checked = true;
      toolStripMenuItemStyleVs2008.Checked = false;
    }

    private void toolStripMenuItemVs2008_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new VS2008ToolStripRenderer();
      toolStripMenuItemStyleProfessional.Checked = false;
      toolStripMenuItemStyleOffice2007.Checked = false;
      toolStripMenuItemStyleSystem.Checked = false;
      toolStripMenuItemStyleVs2008.Checked = true;
    }

    private void ToolStripMenuItemStyleProfessionell_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemStyleProfessional.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void ToolStripMenuItemStyleProfessionell_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void ToolStripMenuItemSystem_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemStyleSystem.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void ToolStripMenuItemSystem_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripMenuItemVs2008_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemStyleVs2008.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void timerUpdate_Tick(object sender, EventArgs e) => PlanetoidDBForm_Shown(sender, e);

		private void notifyIconUpdate_Click(object sender, EventArgs e)
    {
      //contextMenuNotifyIcon.Show(notifyIconUpdate, 0, 100);
    }

    private void toolStripButtonPrint_Click(object sender, EventArgs e)
    {
    }

    private void toolStripButtonPrint_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonPrint.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonPrint_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonCopyToClipboard_Click(object sender, EventArgs e)
    {
    }

    private void toolStripButtonCopyToClipboard_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonCopyToClipboard.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonCopyToClipboard_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonDatabaseInformation_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonDatabaseInformation.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonDatabaseInformation_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItemPrint_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemPrint.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripMenuItemPrint_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripTextBoxSearch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripTextBoxSearch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripTextBoxSearch_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripButtonSearch_Click(object sender, EventArgs e)
    {
    }

    private void toolStripButtonSearch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonSearch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripButtonSearch_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripMenuItemCopytoClipboard_Click(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItemCopytoClipboard_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemCopytoClipboard.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripMenuItemCopytoClipboard_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripMenuItemSearch_Click(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItemSearch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemSearch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripMenuItemSearch_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripMenuItemDatabaseInformation_Click(object sender, EventArgs e)
    {
      DatabaseInformationForm formDatabaseInformation = new DatabaseInformationForm();
      formDatabaseInformation.ShowDialog();
    }

    private void toolStripMenuItemDatabaseInformation_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemDatabaseInformation.AccessibleDescription;
      labelHelp.Enabled = true;
    }

		private void toolStripMenuItemVs2008_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void toolStripMenuItemDatabaseInformation_MouseLeave(object sender, EventArgs e) => clearLabelHelp();

		private void checkMpcorbDat()
    {
      FileInfo fi = new FileInfo(Planetoid_DB.Properties.Resources.strFilenameMPCORB);
      long fileSize = fi.Length;
      DateTime datetimeFileLocal = fi.CreationTime;
      DateTime datetimeFileOnline = GetLastModified(uriMPCORB);

      string strInfoMpcorbDatLocal = "MPCORB.DAT local:\n\r\n\r";
      if (File.Exists(Planetoid_DB.Properties.Resources.strFilenameMPCORB))
      {
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "     URL: " + fi.FullName;
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "\n\r     Content Length: " + fileSize.ToString() + " Bytes";
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "\n\r     Last modified: " + datetimeFileLocal;
      }
      else
      {
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "no file found";
      }

      string strInfoMpcorbDatOnline = "MPCORB.DAT online:\n\r\n\r";
      strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "     URL: " + uriMPCORB;
      strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "\n\r     Content Length: " + GetContentLength(uriMPCORB).ToString() + " Bytes";
      strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "\n\r     Last modified: " + datetimeFileOnline;

      string strUpdate = "";
      MessageBoxIcon mbi = MessageBoxIcon.None;
      if (datetimeFileOnline > datetimeFileLocal)
      {
        strUpdate = "Update aviable!";
        mbi = MessageBoxIcon.Warning;
      }
      else
      {
        strUpdate = "No update needed!";
        mbi = MessageBoxIcon.Information;
      }

      MessageBox.Show(strInfoMpcorbDatLocal + "\n\r\n\r" + strInfoMpcorbDatOnline + "\n\r\n\r" + strUpdate, "MPCORB.DAT infomations", MessageBoxButtons.OK, mbi);
    }

  }
}
