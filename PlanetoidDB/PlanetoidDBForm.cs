using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PlanetoidDB
{
  public partial class PlanetoidDBForm : Form
  {
    int intCurrentPosition = 0;
    
    ArrayList arrIndex = new ArrayList();
    ArrayList arrMagAbs = new ArrayList();
    ArrayList arrSlopeParam = new ArrayList();
    ArrayList arrEpoch = new ArrayList();
    ArrayList arrMeanAnomaly = new ArrayList();
    ArrayList arrArgPeri = new ArrayList();
    ArrayList arrLongAscNode = new ArrayList();
    ArrayList arrIncl = new ArrayList();
    ArrayList arrOrbEcc = new ArrayList();
    ArrayList arrMotion = new ArrayList();
    ArrayList arrSemiMajorAxis = new ArrayList();
    ArrayList arrRef = new ArrayList();
    ArrayList arrNumbObs = new ArrayList();
    ArrayList arrNumbOppos = new ArrayList();
    ArrayList arrObsSpan = new ArrayList();
    ArrayList arrRmsResdiual = new ArrayList();
    ArrayList arrComputerName = new ArrayList();
    ArrayList arrFlags = new ArrayList();
    ArrayList arrDesgnName = new ArrayList();
    ArrayList arrObsLastDate = new ArrayList();

    private void GotoCurrentPosition(int cp)
    {
      labelIndex.Text = arrIndex[cp].ToString();
      labelMagAbs.Text = arrMagAbs[cp].ToString();
      labelSlopeParam.Text = arrSlopeParam[cp].ToString();
      labelEpoch.Text = arrEpoch[cp].ToString();
      labelMeanAnomaly.Text = arrMeanAnomaly[cp].ToString();
      labelArgPeri.Text = arrArgPeri[cp].ToString();
      labelLongAscNode.Text = arrLongAscNode[cp].ToString();
      labelIncl.Text = arrIncl[cp].ToString();
      labelOrbEcc.Text = arrOrbEcc[cp].ToString();
      labelMotion.Text = arrMotion[cp].ToString();
      labelSemiMajorAxis.Text = arrSemiMajorAxis[cp].ToString();
      labelRef.Text = arrRef[cp].ToString();
      labelNumbObs.Text = arrNumbObs[cp].ToString();
      labelNumbOppos.Text = arrNumbOppos[cp].ToString();
      labelObsSpan.Text = arrObsSpan[cp].ToString();
      labelRmsResidual.Text = arrRmsResdiual[cp].ToString();
      labelComputerName.Text = arrComputerName[cp].ToString();
      labelFlags.Text = arrFlags[cp].ToString();
      labelDesgnName.Text = arrDesgnName[cp].ToString();
      labelObsLastDate.Text = arrObsLastDate[cp].ToString();
    }

    public PlanetoidDBForm()
    {
      InitializeComponent();
    }

    private void PlanetoidDBForm_Load(object sender, EventArgs e)
    {
      SplashScreenForm formSplashScreen = new SplashScreenForm();
      formSplashScreen.Show();
      formSplashScreen.Update();

      string fileName = "mpcorb.dat";
      FileInfo fi = new FileInfo(fileName);
      long fileSize = fi.Length, fileSizeReaded = 0;
      int step = 0, lineNum = 0, entryNumb = 0;
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
            string strIndex = readLine.Substring(0, 7); strIndex = strIndex.Trim();
            string strMagAbs = readLine.Substring(8, 5); strMagAbs = strMagAbs.Trim();
            string strSlopeParam = readLine.Substring(14, 5); strSlopeParam = strSlopeParam.Trim();
            string strEpoch = readLine.Substring(20, 5); strEpoch = strEpoch.Trim();
            string strMeanAnomaly = readLine.Substring(26, 9); strMeanAnomaly = strMeanAnomaly.Trim();
            string strArgPeri = readLine.Substring(37, 9); strArgPeri = strArgPeri.Trim();
            string strLongAscNode = readLine.Substring(48, 9); strLongAscNode = strLongAscNode.Trim();
            string strIncl = readLine.Substring(59, 9); strIncl = strIncl.Trim();
            string strOrbEcc = readLine.Substring(70, 9); strOrbEcc = strOrbEcc.Trim();
            string strMotion = readLine.Substring(80, 11); strMotion = strMotion.Trim();
            string strSemiMajorAxis = readLine.Substring(92, 11); strSemiMajorAxis = strSemiMajorAxis.Trim();
            string strRef = readLine.Substring(107, 9); strRef = strRef.Trim();
            string strNumbObs = readLine.Substring(117, 5); strNumbObs = strNumbObs.Trim();
            string strNumbOppos = readLine.Substring(123, 3); strNumbOppos = strNumbOppos.Trim();
            string strObsSpan = readLine.Substring(127, 9); strObsSpan = strObsSpan.Trim();
            string strRmsResiual = readLine.Substring(137, 4); strRmsResiual = strRmsResiual.Trim();
            string strComputerName = readLine.Substring(150, 10); strComputerName = strComputerName.Trim();
            string strFlags = readLine.Substring(161, 4); strFlags = strFlags.Trim();
            string strDesgnName = readLine.Substring(166, 28); strDesgnName = strDesgnName.Trim();
            string strObsLastDate = readLine.Substring(194, 8); strObsLastDate = strObsLastDate.Trim();

            entryNumb++;

            arrIndex.Add(strIndex);
            arrMagAbs.Add(strMagAbs);
            arrSlopeParam.Add(strSlopeParam);
            arrEpoch.Add(strEpoch);
            arrMeanAnomaly.Add(strMeanAnomaly);
            arrArgPeri.Add(strArgPeri);
            arrLongAscNode.Add(strLongAscNode);
            arrIncl.Add(strIncl);
            arrOrbEcc.Add(strOrbEcc);
            arrMotion.Add(strMotion);
            arrSemiMajorAxis.Add(strSemiMajorAxis);
            arrRef.Add(strRef);
            arrNumbObs.Add(strNumbObs);
            arrNumbOppos.Add(strNumbOppos);
            arrObsSpan.Add(strObsLastDate);
            arrRmsResdiual.Add(strRmsResiual);
            arrComputerName.Add(strComputerName);
            arrFlags.Add(strFlags);
            arrDesgnName.Add(strDesgnName);
            arrObsLastDate.Add(strObsLastDate);

          }
        }
      }
      sr.Close();
      formSplashScreen.Close();

      intCurrentPosition = 0;
      GotoCurrentPosition(intCurrentPosition);      
    }

    private void buttonStepToBegin_Click(object sender, EventArgs e)
    {
      intCurrentPosition = 0;
      GotoCurrentPosition(intCurrentPosition);
    }

    private void buttonStepBackward_Click(object sender, EventArgs e)
    {
    }

    private void buttonStepBackward1_Click(object sender, EventArgs e)
    {
      if (intCurrentPosition == 0) intCurrentPosition = arrDesgnName.Count - 1; else intCurrentPosition--;
      GotoCurrentPosition(intCurrentPosition);
    }
    
    private void buttonStepForward1_Click(object sender, EventArgs e)
    {
      if (intCurrentPosition == arrDesgnName.Count - 1) intCurrentPosition = 0; else intCurrentPosition++;
      GotoCurrentPosition(intCurrentPosition);
    }

    private void buttonStepForward_Click(object sender, EventArgs e)
    {
    }

    private void buttonStepToEnd_Click(object sender, EventArgs e)
    {
      intCurrentPosition = arrDesgnName.Count - 1;
      GotoCurrentPosition(intCurrentPosition);
    }

  }
}
