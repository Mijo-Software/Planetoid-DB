using Office2007Rendering;
using VS2008StripRenderingLibrary;
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
using System.Runtime.InteropServices;

namespace PlanetoidDB
{

  public partial class PlanetoidDBForm : Form
  {
    int currentPosition = 0, stepPosition = 0;
    Uri uriMPCORB = new Uri("http://www.minorplanetcenter.org/iau/MPCORB/MPCORB.DAT");
    //For local only: Uri uriMPCORB = new Uri("http://localhost/MPCORB.DAT");
    string
      strFilenameMPCORB = "mpcorb.dat",
      strFilenameMPCORBtemp = "_",
      strHomepage= "http://www.planetoiddb.micjoh.de";
    SplashScreenForm formSplashScreen = new SplashScreenForm();
    WebClient webClient = new WebClient();
    bool isDownloadCancelled = false;

    ArrayList arrDB = new ArrayList(0);

    public void Download(int i)
    {
      toolStripProgressBarBackgroundDownload.Visible = true;
      toolStripStatusLabelBackgroundDownload.Visible = true;
    }

    private void GotoCurrentPosition(int cp)
    {
      string strIndex, strMagAbs, strSlopeParam, strEpoch, strMeanAnomaly, strArgPeri, strLongAscNode, strIncl, strOrbEcc, strMotion, strSemiMajorAxis, strRef, strNumbObs, strNumbOppos, strObsSpan, strRmsResdiual, strComputerName, strFlags, strDesgnName, strObsLastDate;
      //Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Lerrstrings sind.
      // if (teilstring == "0") zahl = 0; ...
      strIndex = arrDB[cp].ToString().Substring(0, 7); strIndex = strIndex.Trim();
      labelIndexValue.Text = strIndex;
      strMagAbs = arrDB[cp].ToString().Substring(8, 5); strMagAbs = strMagAbs.Trim();
      labelMagAbsValue.Text = strMagAbs;
      strSlopeParam = arrDB[cp].ToString().Substring(14, 5); strSlopeParam = strSlopeParam.Trim();
      labelSlopeParamValue.Text = strSlopeParam;
      strEpoch = arrDB[cp].ToString().Substring(20, 5); strEpoch = strEpoch.Trim();
      labelEpochValue.Text = strEpoch;
      strMeanAnomaly = arrDB[cp].ToString().Substring(26, 9); strMeanAnomaly = strMeanAnomaly.Trim();
      labelMeanAnomalyValue.Text = strMeanAnomaly;
      strArgPeri = arrDB[cp].ToString().Substring(37, 9); strArgPeri = strArgPeri.Trim();
      labelArgPeriValue.Text = strArgPeri;
      strLongAscNode = arrDB[cp].ToString().Substring(48, 9); strLongAscNode = strLongAscNode.Trim();
      labelLongAscNodeValue.Text = strLongAscNode;
      strIncl = arrDB[cp].ToString().Substring(59, 9); strIncl = strIncl.Trim();
      labelInclValue.Text = strIncl;
      strOrbEcc = arrDB[cp].ToString().Substring(70, 9); strOrbEcc = strOrbEcc.Trim();
      labelOrbEccValue.Text = strOrbEcc;
      strMotion = arrDB[cp].ToString().Substring(80, 11); strMotion = strMotion.Trim();
      labelMotionValue.Text = strMotion;
      strSemiMajorAxis = arrDB[cp].ToString().Substring(92, 11); strSemiMajorAxis = strSemiMajorAxis.Trim();
      labelSemiMajorAxisValue.Text = strSemiMajorAxis;
      strRef = arrDB[cp].ToString().Substring(107, 9); strRef = strRef.Trim();
      labelRefValue.Text = strRef;
      strNumbObs = arrDB[cp].ToString().Substring(117, 5); strNumbObs = strNumbObs.Trim();
      labelNumbObsValue.Text = strNumbObs;
      strNumbOppos = arrDB[cp].ToString().Substring(123, 3); strNumbOppos = strNumbOppos.Trim();
      labelNumbOpposValue.Text = strNumbOppos;
      strObsSpan = arrDB[cp].ToString().Substring(127, 9); strObsSpan = strObsSpan.Trim();
      labelObsSpanValue.Text = strObsSpan;
      strRmsResdiual = arrDB[cp].ToString().Substring(137, 4); strRmsResdiual = strRmsResdiual.Trim();
      labelRmsResidualValue.Text = strRmsResdiual;
      strComputerName = arrDB[cp].ToString().Substring(150, 10); strComputerName = strComputerName.Trim();
      labelComputerNameValue.Text = strComputerName;
      strFlags = arrDB[cp].ToString().Substring(161, 4); strFlags = strFlags.Trim();
      labelFlagsValue.Text = strFlags;
      strDesgnName = arrDB[cp].ToString().Substring(166, 28); strDesgnName = strDesgnName.Trim();
      labelDesgnNameValue.Text = strDesgnName;
      strObsLastDate = arrDB[cp].ToString().Substring(194, 8); strObsLastDate = strObsLastDate.Trim();
      labelObsLastDateValue.Text = strObsLastDate;

      labelIndexPos.Text = "Index: " + (cp+1).ToString() + " / " + (arrDB.Count).ToString();
      trackBarIndex.Value = currentPosition;
    }

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
      bwLoadingDB.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerLoadingDB_ProgressChanged);
      bwLoadingDB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerLoadingDB_RunWorkerCompleted);
      bwLoadingDB.RunWorkerAsync();
      formSplashScreen.Show();
      formSplashScreen.Update();
    }

    private void PlanetoidDBForm_Shown(object sender, EventArgs e)
    {
      toolStripStatusLabelBackgroundDownload.Enabled = false;
      toolStripProgressBarBackgroundDownload.Enabled = false;
      if (isMpcorbDatUpdateAviable() == true)
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

    private void buttonStepToBegin_Click(object sender, EventArgs e)
    {
      currentPosition = 0;
      GotoCurrentPosition(currentPosition);
    }

    private void buttonStepBackward_Click(object sender, EventArgs e)
    {
      currentPosition = currentPosition - stepPosition;
      if (currentPosition < 1) currentPosition = arrDB.Count + currentPosition;
      GotoCurrentPosition(currentPosition);
    }

    private void buttonStepBackward1_Click(object sender, EventArgs e)
    {
      if (currentPosition == 0) currentPosition = arrDB.Count - 1; else currentPosition--;
      GotoCurrentPosition(currentPosition);
    }
    
    private void buttonStepForward1_Click(object sender, EventArgs e)
    {
      if (currentPosition == arrDB.Count - 1) currentPosition = 0; else currentPosition++;
      GotoCurrentPosition(currentPosition);
    }

    private void buttonStepForward_Click(object sender, EventArgs e)
    {
      currentPosition = currentPosition + stepPosition;
      if (currentPosition > arrDB.Count) currentPosition = currentPosition - arrDB.Count;
      GotoCurrentPosition(currentPosition);
    }

    private void buttonStepToEnd_Click(object sender, EventArgs e)
    {
      currentPosition = arrDB.Count - 1;
      GotoCurrentPosition(currentPosition);
    }

    private void buttonGotoIndex_Click(object sender, EventArgs e)
    {
      currentPosition = (int)numericUpDownGotoIndex.Value - 1;
      GotoCurrentPosition(currentPosition);
    }

    private void toolStripMenuItem_Clear()
    {
      toolStripMenuItem10.Checked = false;
      toolStripMenuItem100.Checked = false;
      toolStripMenuItem1000.Checked = false;
      toolStripMenuItem10000.Checked = false;
      toolStripMenuItem100000.Checked = false;
    }

    private void toolStripMenuItem10_Click(object sender, EventArgs e)
    {
      stepPosition = 10;
      toolStripMenuItem_Clear();
      toolStripMenuItem10.Checked = true;
    }

    private void toolStripMenuItem100_Click(object sender, EventArgs e)
    {
      stepPosition = 100;
      toolStripMenuItem_Clear();
      toolStripMenuItem100.Checked = true;
    }

    private void toolStripMenuItem1000_Click(object sender, EventArgs e)
    {
      stepPosition = 1000;
      toolStripMenuItem_Clear();
      toolStripMenuItem1000.Checked = true;
    }

    private void toolStripMenuItem10000_Click(object sender, EventArgs e)
    {
      stepPosition = 10000;
      toolStripMenuItem_Clear();
      toolStripMenuItem10000.Checked = true;
    }

    private void toolStripMenuItem100000_Click(object sender, EventArgs e)
    {
      stepPosition = 100000;
      toolStripMenuItem_Clear();
      toolStripMenuItem100000.Checked = true;
    }

    private void menuitemExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void menuitemAbout_Click(object sender, EventArgs e)
    {
      AppInfoForm formAppInfo = new AppInfoForm();
      formAppInfo.ShowDialog();
    }

    private void menuitemOpenWebsitePDB_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(strHomepage);
    }

    private void menuitemOpenWebsiteMPC_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.minorplanetcenter.org/iau/mpc.html");
    }

    private void menuitemOpenMPCORBWebsite_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.minorplanetcenter.org/iau/MPCORB.html");
    }

    private void menuitemDownloadMpcorbDat_Click(object sender, EventArgs e)
    {
      DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
      formDownloaderForMpcorbDat.ShowDialog();
    }

    private void trackBarIndex_Scroll(object sender, EventArgs e)
    {
      currentPosition = trackBarIndex.Value;
      GotoCurrentPosition(currentPosition);
    }

    private void backgroundWorkerLoadingDB_DoWork(object sender, DoWorkEventArgs e)
    {
      this.Enabled = false;
      string fileName = strFilenameMPCORB;

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

        //bwLoadingDB.ReportProgress(step);
        formSplashScreen.setProgressbar(step);

        lineNum++;
        if (lineNum >= 42)
        {
          if (readLine != "")
          {
            arrDB.Add(readLine);
          }
        }
      }

      fs.Close();
      sr.Close();
      formSplashScreen.Close();
      formSplashScreen.Dispose();
    }

    void backgroundWorkerLoadingDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      //formSplashScreen.setProgressbar(e.ProgressPercentage);
      //TaskbarProgress.SetValue(this.Handle, e.ProgressPercentage, 100);
    }

    void backgroundWorkerLoadingDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
      //MessageBox.Show("Asynchroner Thread kam bis zum Wert: " + e.Result.ToString());
    }

    private void menuitemCheckMpcorbDat_Click(object sender, EventArgs e)
    {
      checkMpcorbDat();
    }

    private DateTime getLastModified(Uri uriLastModiefied)
    {
      HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uriLastModiefied);
      HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
      return resp.LastModified;
    }

    private Int64 getContentLength(Uri uriContentLength)
    {
      HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uriContentLength);
      HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
      Int64 bytesTotal = Convert.ToInt64(resp.ContentLength);
      //webClient.OpenRead(uriContentLength);
      //Int64 bytesTotal = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
      return bytesTotal;
    }

    private bool isMpcorbDatUpdateAviable()
    {
      FileInfo fi = new FileInfo(strFilenameMPCORB);
      long fileSize = fi.Length;
      DateTime datetimeFileLocal = fi.CreationTime;
      DateTime datetimeFileOnline = getLastModified(uriMPCORB);
      if (datetimeFileOnline > datetimeFileLocal) return true; else return false;
    }

    private void labelIndexValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelIndexValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDesgnNameValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDesgnNameValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelEpochValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelEpochValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMeanAnomalyValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMeanAnomalyValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelArgPeriValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelArgPeriValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelLongAscNodeValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelLongAscNodeValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelInclValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelInclValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelOrbEccValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelOrbEccValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMotionValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMotionValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelSemiMajorAxisValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSemiMajorAxisValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMagAbsValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMagAbsValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelSlopeParamValue_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSlopeParamValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelSlopeParamValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSlopeParamValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelRefValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelRefValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelNumbOpposValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelNumbOpposValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelNumbObsValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelNumbObsValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelObsSpanValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelObsSpanValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelRmsResidualValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelRmsResidualValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelComputerNameValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelComputerNameValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelFlagsValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelFlagsValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelObsLastDateValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelObsLastDateValue.Text);
      showMessageCopiedToClipboad();
    }

    private void buttonStepToBegin_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepToBegin.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void buttonStepToBegin_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonStepBackward_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepBackward.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void buttonStepBackward_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonStepBackward1_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepBackward1.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void buttonStepBackward1_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonStepForward1_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepForward1.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void buttonStepForward1_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonStepForward_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepForward.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void buttonStepForward_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonStepToEnd_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonStepToEnd.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void buttonStepToEnd_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void buttonGotoIndex_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = buttonGotoIndex.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void buttonGotoIndex_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void trackBarIndex_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = trackBarIndex.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void trackBarIndex_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemFile_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemFile.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemFile_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemExit_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemExit.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemExit_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemOptions_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOptions.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemOptions_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemCheckMpcorbDat_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemCheckMpcorbDat.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemCheckMpcorbDat_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemDownloadMpcorbDat_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemDownloadMpcorbDat.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemDownloadMpcorbDat_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemQuest_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemQuest.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemQuest_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemOpenWebsitePDB_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOpenWebsitePDB.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemOpenWebsitePDB_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemOpenWebsiteMPC_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOpenWebsiteMPC.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemOpenWebsiteMPC_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemOpenMPCORBWebsite_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemOpenMPCORBWebsite.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemOpenMPCORBWebsite_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelIndexValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelIndexValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelIndexValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelDesgnNameValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelDesgnNameValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelDesgnNameValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelEpochValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelEpochValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelEpochValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelMeanAnomalyValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMeanAnomalyValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelMeanAnomalyValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelArgPeriValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelArgPeriValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelArgPeriValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelLongAscNodeValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelLongAscNodeValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelLongAscNodeValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelInclValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelInclValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelInclValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelOrbEccValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelOrbEccValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelOrbEccValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelMotionValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMotionValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelMotionValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelSemiMajorAxisValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSemiMajorAxisValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelSemiMajorAxisValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelMagAbsValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMagAbsValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelMagAbsValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelSlopeParamValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSlopeParamValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelSlopeParamValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelRefValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRefValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelRefValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelNumbOpposValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbOpposValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelNumbOpposValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelNumbObsValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbObsValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelNumbObsValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelObsSpanValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsSpanValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelObsSpanValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelRmsResidualValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRmsResidualValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelRmsResidualValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelComputerNameValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelComputerNameValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelComputerNameValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelFlagsValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelFlagsValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelFlagsValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelObsLastDateValue_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsLastDateValue.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelObsLastDateValue_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemAbout_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemAbout.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemAbout_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

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

    private void labelIndex_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelDesgnName_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelDesgnName.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelDesgnName_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelEpoch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelEpoch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelEpoch_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelMeanAnomaly_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMeanAnomaly.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelMeanAnomaly_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelArgPeri_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelArgPeri.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelArgPeri_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelLongAscNode_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelLongAscNode.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelLongAscNode_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelIncl_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelIncl.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelIncl_MouseMove(object sender, MouseEventArgs e)
    {
      clearLabelHelp();
    }

    private void labelOrbEcc_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelOrbEcc.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelOrbEcc_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelMotion_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMotion.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelMotion_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelSemiMajorAxis_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSemiMajorAxis.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelSemiMajorAxis_MouseMove(object sender, MouseEventArgs e)
    {
      clearLabelHelp();
    }

    private void labelMagAbs_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelMagAbs.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelMagAbs_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelSlopeParam_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelSlopeParam.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelSlopeParam_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelRef_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRef.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelRef_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelNumbOppos_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbOppos.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelNumbOppos_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelNumbObs_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelNumbObs.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelNumbObs_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelObsSpan_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsSpan.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelObsSpan_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelRmsResidual_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelRmsResidual.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelRmsResidual_MouseMove(object sender, MouseEventArgs e)
    {
      clearLabelHelp();
    }

    private void labelComputerName_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelComputerName.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelComputerName_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelFlags_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelFlags.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelFlags_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelObsLastDate_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelObsLastDate.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelObsLastDate_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelIndex_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelIndex.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDesgnName_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDesgnName.Text);
      showMessageCopiedToClipboad();
    }

    private void labelEpoch_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelEpoch.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMeanAnomaly_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMeanAnomaly.Text);
      showMessageCopiedToClipboad();
    }

    private void labelArgPeri_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelArgPeri.Text);
      showMessageCopiedToClipboad();
    }

    private void labelLongAscNode_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelLongAscNode.Text);
      showMessageCopiedToClipboad();
    }

    private void labelIncl_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelIncl.Text);
      showMessageCopiedToClipboad();
    }

    private void labelOrbEcc_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelOrbEcc.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMotion_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMotion.Text);
      showMessageCopiedToClipboad();
    }

    private void labelSemiMajorAxis_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSemiMajorAxis.Text);
      showMessageCopiedToClipboad();
    }

    private void labelMagAbs_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMagAbs.Text);
      showMessageCopiedToClipboad();
    }

    private void labelSlopeParam_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSlopeParam.Text);
      showMessageCopiedToClipboad();
    }

    private void labelRef_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelRef.Text);
      showMessageCopiedToClipboad();
    }

    private void labelNumbOppos_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelNumbOppos.Text);
      showMessageCopiedToClipboad();
    }

    private void labelNumbObs_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelNumbObs.Text);
      showMessageCopiedToClipboad();
    }

    private void labelObsSpan_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelObsSpan.Text);
      showMessageCopiedToClipboad();
    }

    private void labelRmsResidual_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelRmsResidual.Text);
      showMessageCopiedToClipboad();
    }

    private void labelObsLastDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelObsLastDate.Text);
      showMessageCopiedToClipboad();
    }

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
        File.Delete(strFilenameMPCORB);
        File.Copy(strFilenameMPCORBtemp, strFilenameMPCORB);
        File.Delete(strFilenameMPCORBtemp);
        MessageBox.Show("Download complete! You must restart the program to apply the update of the database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else {
        MessageBox.Show("Download cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        File.Delete(strFilenameMPCORBtemp);
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
          webClient.DownloadFileAsync(uriMPCORB, @strFilenameMPCORBtemp);
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

    private void toolStripStatusLabelBackgroundDownload_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }
    private void toolStripProgressBarBackgroundDownload_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripProgressBarBackgroundDownload.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripProgressBarBackgroundDownload_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void labelIndexPos_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = labelIndexPos.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void labelIndexPos_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e)
    {
      checkMpcorbDat();
    }

    private void toolStripButtonCheckMpcorbDat_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonCheckMpcorbDat.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripButtonCheckMpcorbDat_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

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

    private void toolStripButtonDownloadMpcorbDat_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

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

    private void toolStripButtonAbout_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(strHomepage);
    }

    private void toolStripButtonOpenWebsitePDB_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonOpenWebsitePDB.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripButtonOpenWebsitePDB_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void menuitemEdit_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = menuitemEdit.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void menuitemEdit_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

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

    private void toolStripMenuItemTableMode_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

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

    private void labelComputerName_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelComputerName.Text);
      showMessageCopiedToClipboad();
    }

    private void labelFlags_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelFlags.Text);
      showMessageCopiedToClipboad();
    }

    private void toolStripButtonDatabaseInformation_Click(object sender, EventArgs e)
    {
      DatabaseInformationForm formDatabaseInformation = new DatabaseInformationForm();
      formDatabaseInformation.ShowDialog();
    }

    private void toolStripButtonTableMode_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void ToolStripMenuItemStyle_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = ToolStripMenuItemStyle.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void ToolStripMenuItemStyle_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

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

    private void ToolStripMenuItemStyleProfessionell_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void ToolStripMenuItemSystem_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemStyleSystem.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void ToolStripMenuItemSystem_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripMenuItemVs2008_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemStyleVs2008.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void timerUpdate_Tick(object sender, EventArgs e)
    {
      PlanetoidDBForm_Shown(sender, e);
    }

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

    private void toolStripButtonPrint_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripButtonCopyToClipboard_Click(object sender, EventArgs e)
    {
    }

    private void toolStripButtonCopyToClipboard_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonCopyToClipboard.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripButtonCopyToClipboard_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripButtonDatabaseInformation_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonDatabaseInformation.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripButtonDatabaseInformation_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItemPrint_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemPrint.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripMenuItemPrint_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripTextBoxSearch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripTextBoxSearch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripTextBoxSearch_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripButtonSearch_Click(object sender, EventArgs e)
    {
    }

    private void toolStripButtonSearch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripButtonSearch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripButtonSearch_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripMenuItemCopytoClipboard_Click(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItemCopytoClipboard_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemCopytoClipboard.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripMenuItemCopytoClipboard_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripMenuItemSearch_Click(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItemSearch_MouseEnter(object sender, EventArgs e)
    {
      labelHelp.Text = toolStripMenuItemSearch.AccessibleDescription;
      labelHelp.Enabled = true;
    }

    private void toolStripMenuItemSearch_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

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

    private void toolStripMenuItemVs2008_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }

    private void toolStripMenuItemDatabaseInformation_MouseLeave(object sender, EventArgs e)
    {
      clearLabelHelp();
    }
    
    private void showMessageCopiedToClipboad()
    {
      MessageBox.Show("Copied to clipboard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void checkMpcorbDat()
    {
      FileInfo fi = new FileInfo(strFilenameMPCORB);
      long fileSize = fi.Length;
      DateTime datetimeFileLocal = fi.CreationTime;
      DateTime datetimeFileOnline = getLastModified(uriMPCORB);

      string strInfoMpcorbDatLocal = "MPCORB.DAT local:\n\r\n\r";
      if (File.Exists(strFilenameMPCORB))
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
      strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "\n\r     Content Length: " + getContentLength(uriMPCORB).ToString() + " Bytes";
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
