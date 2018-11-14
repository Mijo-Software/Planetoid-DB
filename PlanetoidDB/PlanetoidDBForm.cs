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

namespace PlanetoidDB
{
  public partial class PlanetoidDBForm : Form
  {
    int currentPosition = 0, stepPosition = 0;
    string defaultFileName = "mpcorb.dat";
    Uri uriMPCORB = new Uri("http://www.minorplanetcenter.org/iau/MPCORB/MPCORB.DAT");
    SplashScreenForm formSplashScreen = new SplashScreenForm();


    ArrayList arrDB = new ArrayList(0);

    public void VisibleBackgroundDownload(bool visible)
    {
      toolStripProgressBarBackgroundDownload.Visible = visible;
      labelBackgroundDownload.Visible = visible;
    }

    public void Download(int i)
    {
      toolStripProgressBarBackgroundDownload.Visible = true;
      labelBackgroundDownload.Visible = true;
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
      VisibleBackgroundDownload(false);
      this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }

    private void PlanetoidDBForm_Load(object sender, EventArgs e)
    {
      backgroundWorkerLoadingDB.WorkerReportsProgress = true;
      backgroundWorkerLoadingDB.WorkerSupportsCancellation = true;
      backgroundWorkerLoadingDB.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerLoadingDB_ProgressChanged);
      backgroundWorkerLoadingDB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerLoadingDB_RunWorkerCompleted);
      backgroundWorkerLoadingDB.RunWorkerAsync();
      formSplashScreen.Show();
      formSplashScreen.Update();
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
      System.Diagnostics.Process.Start("http://www.planetoiddb.micjoh.de");
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
      DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm(this);
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
      string fileName = defaultFileName;
      if (!File.Exists(fileName))
      {
        if (ofd.ShowDialog() == DialogResult.OK)
        {
          fileName = Path.GetFullPath(ofd.FileName);
        }
        else
        {
          MessageBox.Show(defaultFileName.ToUpper() + " couldn't found!", defaultFileName.ToUpper() + " missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
          formSplashScreen.Close();
          this.Close();
        }
      }

      FileInfo fi = new FileInfo(fileName);
      long fileSize = fi.Length, fileSizeReaded = 0;
      int step = 0, lineNum = 0;
      FileStream fs;
      StreamReader sr;
      string readLine;

      fs = new FileStream(fileName, FileMode.Open);
      sr = new StreamReader(fs);

      while (sr.Peek() != -1 && !backgroundWorkerLoadingDB.CancellationPending)
      {
        readLine = sr.ReadLine();
        fileSizeReaded = fileSizeReaded + readLine.Length;
        float percent = 100 * fileSizeReaded / fileSize;
        step = (int)percent;

        //backgroundWorkerLoadingDB.ReportProgress(step);
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
      //MessageBox.Show("Asynchroner Thread kam bis zum Wert: " + e.Result.ToString());
    }

    private void menuitemCheckMpcorbDat_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Content Length: " + getContentLength(uriMPCORB).ToString() + " Bytes");
      MessageBox.Show("Last modified: " + getLastModified(uriMPCORB));
    }

    private string getLastModified(Uri uriLastModiefied)
    {
      HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uriLastModiefied);
      HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
      return resp.LastModified.ToString();
    }

    private void labelIndexValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelIndexValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelDesgnNameValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDesgnNameValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelEpochValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelEpochValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelMeanAnomalyValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMeanAnomalyValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelArgPeriValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelArgPeriValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelLongAscNodeValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelLongAscNodeValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelInclValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelInclValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelOrbEccValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelOrbEccValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelMotionValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMotionValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelSemiMajorAxisValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSemiMajorAxisValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelMagAbsValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMagAbsValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelSlopeParamValue_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSlopeParamValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelSlopeParamValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSlopeParamValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelRefValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelRefValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelNumbOpposValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelNumbOpposValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelNumbObsValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelNumbObsValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelObsSpanValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelObsSpanValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelRmsResidualValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelRmsResidualValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelComputerNameValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelComputerNameValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelFlagsValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelFlagsValue.Text);
      MessageBox.Show("Copied to clipboard.");
    }

    private void labelObsLastDateValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelObsLastDateValue.Text);
      MessageBox.Show("Copied to clipboard.");
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

  }
}
