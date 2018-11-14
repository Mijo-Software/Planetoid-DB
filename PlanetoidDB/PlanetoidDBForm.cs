using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PlanetoidDB
{
  public partial class PlanetoidDBForm : Form
  {
    int currentPosition = 0, stepPosition = 0;

    ArrayList arrDB = new ArrayList(0);
    
    private void GotoCurrentPosition(int cp)
    {
      string strIndex, strMagAbs, strSlopeParam, strEpoch, strMeanAnomaly, strArgPeri, strLongAscNode, strIncl, strOrbEcc, strMotion, strSemiMajorAxis, strRef, strNumbObs, strNumbOppos, strObsSpan, strRmsResdiual, strComputerName, strFlags, strDesgnName, strObsLastDate;
      
      //Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Lerrstrings sind.
      // if (teilstring == "0") zahl = 0; ...
      strIndex = arrDB[cp].ToString().Substring(0, 7); strIndex = strIndex.Trim();
      labelIndex.Text = strIndex;
      strMagAbs = arrDB[cp].ToString().Substring(8, 5); strMagAbs = strMagAbs.Trim();
      labelMagAbs.Text = strMagAbs;
      strSlopeParam = arrDB[cp].ToString().Substring(14, 5); strSlopeParam = strSlopeParam.Trim();
      labelSlopeParam.Text = strSlopeParam;
      strEpoch = arrDB[cp].ToString().Substring(20, 5); strEpoch = strEpoch.Trim();
      labelEpoch.Text = strEpoch;
      strMeanAnomaly = arrDB[cp].ToString().Substring(26, 9); strMeanAnomaly = strMeanAnomaly.Trim();
      labelMeanAnomaly.Text = strMeanAnomaly;
      strArgPeri = arrDB[cp].ToString().Substring(37, 9); strArgPeri = strArgPeri.Trim();
      labelArgPeri.Text = strArgPeri;
      strLongAscNode = arrDB[cp].ToString().Substring(48, 9); strLongAscNode = strLongAscNode.Trim();
      labelLongAscNode.Text = strLongAscNode;
      strIncl = arrDB[cp].ToString().Substring(59, 9); strIncl = strIncl.Trim();
      labelIncl.Text = strIncl;
      strOrbEcc = arrDB[cp].ToString().Substring(70, 9); strOrbEcc = strOrbEcc.Trim();
      labelOrbEcc.Text = strOrbEcc;
      strMotion = arrDB[cp].ToString().Substring(80, 11); strMotion = strMotion.Trim();
      labelMotion.Text = strMotion;
      strSemiMajorAxis = arrDB[cp].ToString().Substring(92, 11); strSemiMajorAxis = strSemiMajorAxis.Trim();
      labelSemiMajorAxis.Text = strSemiMajorAxis;
      strRef = arrDB[cp].ToString().Substring(107, 9); strRef = strRef.Trim();
      labelRef.Text = strRef;
      strNumbObs = arrDB[cp].ToString().Substring(117, 5); strNumbObs = strNumbObs.Trim();
      labelNumbObs.Text = strNumbObs;
      strNumbOppos = arrDB[cp].ToString().Substring(123, 3); strNumbOppos = strNumbOppos.Trim();
      labelNumbOppos.Text = strNumbOppos;
      strObsSpan = arrDB[cp].ToString().Substring(127, 9); strObsSpan = strObsSpan.Trim();
      labelObsSpan.Text = strObsSpan;
      strRmsResdiual = arrDB[cp].ToString().Substring(137, 4); strRmsResdiual = strRmsResdiual.Trim();
      labelRmsResidual.Text = strRmsResdiual;
      strComputerName = arrDB[cp].ToString().Substring(150, 10); strComputerName = strComputerName.Trim();
      labelComputerName.Text = strComputerName;
      strFlags = arrDB[cp].ToString().Substring(161, 4); strFlags = strFlags.Trim();
      labelFlags.Text = strFlags;
      strDesgnName = arrDB[cp].ToString().Substring(166, 28); strDesgnName = strDesgnName.Trim();
      labelDesgnName.Text = strDesgnName;
      strObsLastDate = arrDB[cp].ToString().Substring(194, 8); strObsLastDate = strObsLastDate.Trim();
      labelObsLastDate.Text = strObsLastDate;

      labelIndexPos.Text = "Index: " + (cp+1).ToString() + " / " + (arrDB.Count).ToString();
    }

    public PlanetoidDBForm()
    {
      InitializeComponent();
    }

    private void PlanetoidDBForm_Load(object sender, EventArgs e)
    {
      string defaultFileName = "mpcorb.dat", fileName = defaultFileName;

      SplashScreenForm formSplashScreen = new SplashScreenForm();
      formSplashScreen.Show();
      formSplashScreen.Update();

      if (!File.Exists(fileName))
      {
        if (ofd.ShowDialog() == DialogResult.OK) 
        {
          fileName = Path.GetFullPath(ofd.FileName);
        } else {
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

      while (sr.Peek() != -1)
      {
        readLine = sr.ReadLine();
        fileSizeReaded = fileSizeReaded + readLine.Length;
        float percent = 100 * fileSizeReaded / fileSize;
        step = (int)percent;
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

      numericUpDownGotoIndex.Minimum = 1;
      numericUpDownGotoIndex.Maximum = arrDB.Count;
      currentPosition = 0;
      stepPosition = 100;
      GotoCurrentPosition(currentPosition);
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

    private void toolStripMenuItem10_Click(object sender, EventArgs e)
    {
      stepPosition = 10;
      toolStripMenuItem10.Checked = true;
      toolStripMenuItem100.Checked = false;
      toolStripMenuItem1000.Checked = false;
      toolStripMenuItem10000.Checked = false;
      toolStripMenuItem100000.Checked = false;
    }

    private void toolStripMenuItem100_Click(object sender, EventArgs e)
    {
      stepPosition = 100;
      toolStripMenuItem10.Checked = false;
      toolStripMenuItem100.Checked = true;
      toolStripMenuItem1000.Checked = false;
      toolStripMenuItem10000.Checked = false;
      toolStripMenuItem100000.Checked = false;
    }

    private void toolStripMenuItem1000_Click(object sender, EventArgs e)
    {
      stepPosition = 1000;
      toolStripMenuItem10.Checked = false;
      toolStripMenuItem100.Checked = false;
      toolStripMenuItem1000.Checked = true;
      toolStripMenuItem10000.Checked = false;
      toolStripMenuItem100000.Checked = false;
    }

    private void toolStripMenuItem10000_Click(object sender, EventArgs e)
    {
      stepPosition = 10000;
      toolStripMenuItem10.Checked = false;
      toolStripMenuItem100.Checked = false;
      toolStripMenuItem1000.Checked = false;
      toolStripMenuItem10000.Checked = true;
      toolStripMenuItem100000.Checked = false;
    }

    private void toolStripMenuItem100000_Click(object sender, EventArgs e)
    {
      stepPosition = 100000;
      toolStripMenuItem10.Checked = false;
      toolStripMenuItem100.Checked = false;
      toolStripMenuItem1000.Checked = false;
      toolStripMenuItem10000.Checked = false;
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

  }
}
