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
    int intCurrentPosition = 0;

    ArrayList arrDB = new ArrayList(0);
    
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
      string strIndex,
      strMagAbs,
      strSlopeParam,
      strEpoch,
      strMeanAnomaly,
      strArgPeri,
      strLongAscNode,
      strIncl,
      strOrbEcc,
      strMotion,
      strSemiMajorAxis,
      strRef,
      strNumbObs,
      strNumbOppos,
      strObsSpan,
      strRmsResdiual,
      strComputerName,
      strFlags,
      strDesgnName,
      strObsLastDate;
      double doubleMagAbs,
      doubleSlopeParam,
      doubleMeanAnomaly,
      doubleArgPeri,
      doubleLongAscNode,
      doubleIncl,
      doubleOrbEcc,
      doubleMotion,
      doubleSemiMajorAxis,
      doubleNumbObs,
      doubleNumbOppos,
      doubleRmsResdiual,
      doubleObsLastDate;

      strIndex = arrDB[cp].ToString().Substring(0, 7); strIndex = strIndex.Trim();
      labelIndex.Text = strIndex;
      strMagAbs = arrDB[cp].ToString().Substring(8, 5); strMagAbs = strMagAbs.Trim();
      if (strMagAbs == "") doubleMagAbs = 0; else doubleMagAbs = Convert.ToDouble(strMagAbs);
      labelMagAbs.Text = strMagAbs;
      strSlopeParam = arrDB[cp].ToString().Substring(14, 5); strSlopeParam = strSlopeParam.Trim();
      if (strSlopeParam == "") doubleSlopeParam = 0; else doubleSlopeParam = Convert.ToDouble(strSlopeParam);
      labelSlopeParam.Text = strSlopeParam;
      strEpoch = arrDB[cp].ToString().Substring(20, 5); strEpoch = strEpoch.Trim();
      labelEpoch.Text = strEpoch;
      strMeanAnomaly = arrDB[cp].ToString().Substring(26, 9); strMeanAnomaly = strMeanAnomaly.Trim();
      if (strMeanAnomaly == "") doubleMeanAnomaly = 0; else doubleMeanAnomaly = Convert.ToDouble(strMeanAnomaly);
      labelMeanAnomaly.Text = strMeanAnomaly;
      strArgPeri = arrDB[cp].ToString().Substring(37, 9); strArgPeri = strArgPeri.Trim();
      if (strArgPeri == "") doubleArgPeri = 0; else doubleArgPeri = Convert.ToDouble(strArgPeri);
      labelArgPeri.Text = strArgPeri;
      strLongAscNode = arrDB[cp].ToString().Substring(48, 9); strLongAscNode = strLongAscNode.Trim();
      if (strLongAscNode == "") doubleLongAscNode = 0; else doubleLongAscNode = Convert.ToDouble(strLongAscNode);
      labelLongAscNode.Text = strLongAscNode;
      strIncl = arrDB[cp].ToString().Substring(59, 9); strIncl = strIncl.Trim();
      if (strIncl == "") doubleIncl = 0; else doubleIncl = Convert.ToDouble(strIncl);
      labelIncl.Text = strIncl;
      strOrbEcc = arrDB[cp].ToString().Substring(70, 9); strOrbEcc = strOrbEcc.Trim();
      if (strOrbEcc == "") doubleOrbEcc = 0; else doubleOrbEcc = Convert.ToDouble(strOrbEcc);
      labelOrbEcc.Text = strOrbEcc;
      strMotion = arrDB[cp].ToString().Substring(80, 11); strMotion = strMotion.Trim();
      if (strMotion == "") doubleMotion = 0; else doubleMotion = Convert.ToDouble(strMotion);
      labelMotion.Text = strMotion;
      strSemiMajorAxis = arrDB[cp].ToString().Substring(92, 11); strSemiMajorAxis = strSemiMajorAxis.Trim();
      if (strSemiMajorAxis == "") doubleSemiMajorAxis = 0; else doubleSemiMajorAxis = Convert.ToDouble(strSemiMajorAxis);
      labelSemiMajorAxis.Text = strSemiMajorAxis;
      strRef = arrDB[cp].ToString().Substring(107, 9); strRef = strRef.Trim();
      labelRef.Text = strRef;
      strNumbObs = arrDB[cp].ToString().Substring(117, 5); strNumbObs = strNumbObs.Trim();
      if (strNumbObs == "") doubleNumbObs = 0; else doubleNumbObs = Convert.ToDouble(strNumbObs);
      labelNumbObs.Text = strNumbObs;
      strNumbOppos = arrDB[cp].ToString().Substring(123, 3); strNumbOppos = strNumbOppos.Trim();
      if (strNumbOppos == "") doubleNumbOppos = 0; else doubleNumbOppos = Convert.ToDouble(strNumbOppos);
      labelNumbOppos.Text = strNumbOppos;
      strObsSpan = arrDB[cp].ToString().Substring(127, 9); strObsSpan = strObsSpan.Trim();
      labelObsSpan.Text = strObsSpan;
      strRmsResdiual = arrDB[cp].ToString().Substring(137, 4); strRmsResdiual = strRmsResdiual.Trim();
      if (strRmsResdiual == "") doubleRmsResdiual = 0; else doubleRmsResdiual = Convert.ToDouble(strRmsResdiual);
      labelRmsResidual.Text = strRmsResdiual;
      strComputerName = arrDB[cp].ToString().Substring(150, 10); strComputerName = strComputerName.Trim();
      labelComputerName.Text = strComputerName;
      strFlags = arrDB[cp].ToString().Substring(161, 4); strFlags = strFlags.Trim();
      labelFlags.Text = strFlags;
      strDesgnName = arrDB[cp].ToString().Substring(166, 28); strDesgnName = strDesgnName.Trim();
      labelDesgnName.Text = strDesgnName;
      strObsLastDate = arrDB[cp].ToString().Substring(194, 8); strObsLastDate = strObsLastDate.Trim();
      if (strObsLastDate == "") doubleObsLastDate = 0; else doubleObsLastDate = Convert.ToDouble(strObsLastDate);
      labelObsLastDate.Text = strObsLastDate;

      /*arrIndex.Add(strIndex);
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
      arrObsSpan.Add(strObsSpan);
      arrRmsResdiual.Add(strRmsResdiual);
      arrComputerName.Add(strComputerName);
      arrFlags.Add(strFlags);
      arrDesgnName.Add(strDesgnName);
      arrObsLastDate.Add(strObsLastDate);

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
      labelObsLastDate.Text = arrObsLastDate[cp].ToString();*/

      labelIndexPos.Text = "Index: " + (cp+1).ToString() + " / " + (arrDB.Count).ToString();
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
      int step = 0, lineNum = 0;
      FileStream fs;
      StreamReader sr;
      string readLine;

      /*string strIndex,
      strMagAbs,
      strSlopeParam,
      strEpoch,
      strMeanAnomaly,
      strArgPeri,
      strLongAscNode,
      strIncl,
      strOrbEcc,
      strMotion,
      strSemiMajorAxis,
      strRef,
      strNumbObs,
      strNumbOppos,
      strObsSpan,
      strRmsResdiual,
      strComputerName,
      strFlags,
      strDesgnName,
      strObsLastDate;
      double doubleMagAbs,
      doubleSlopeParam,
      doubleMeanAnomaly,
      doubleArgPeri,
      doubleLongAscNode,
      doubleIncl,
      doubleOrbEcc,
      doubleMotion,
      doubleSemiMajorAxis,
      doubleNumbObs,
      doubleNumbOppos,
      doubleRmsResdiual,
      doubleObsLastDate;

      ArrayList arrDB = new ArrayList(0);*/
      
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
            /*strIndex = readLine.Substring(0, 7); strIndex = strIndex.Trim();
            strMagAbs = readLine.Substring(8, 5); strMagAbs = strMagAbs.Trim();
            if (strMagAbs == "") doubleMagAbs = 0; else doubleMagAbs = Convert.ToDouble(strMagAbs);
            strSlopeParam = readLine.Substring(14, 5); strSlopeParam = strSlopeParam.Trim();
            if (strSlopeParam == "") doubleSlopeParam = 0; else doubleSlopeParam = Convert.ToDouble(strSlopeParam);
            strEpoch = readLine.Substring(20, 5); strEpoch = strEpoch.Trim();
            strMeanAnomaly = readLine.Substring(26, 9); strMeanAnomaly = strMeanAnomaly.Trim();
            if (strMeanAnomaly == "") doubleMeanAnomaly = 0; else doubleMeanAnomaly = Convert.ToDouble(strMeanAnomaly);
            strArgPeri = readLine.Substring(37, 9); strArgPeri = strArgPeri.Trim();
            if (strArgPeri == "") doubleArgPeri = 0; else doubleArgPeri = Convert.ToDouble(strArgPeri);
            strLongAscNode = readLine.Substring(48, 9); strLongAscNode = strLongAscNode.Trim();
            if (strLongAscNode == "") doubleLongAscNode = 0; else doubleLongAscNode = Convert.ToDouble(strLongAscNode);
            strIncl = readLine.Substring(59, 9); strIncl = strIncl.Trim();
            if (strIncl == "") doubleIncl = 0; else doubleIncl = Convert.ToDouble(strIncl);
            strOrbEcc = readLine.Substring(70, 9); strOrbEcc = strOrbEcc.Trim();
            if (strOrbEcc == "") doubleOrbEcc = 0; else doubleOrbEcc = Convert.ToDouble(strOrbEcc);
            strMotion = readLine.Substring(80, 11); strMotion = strMotion.Trim();
            if (strMotion == "") doubleMotion = 0; else doubleMotion = Convert.ToDouble(strMotion);
            strSemiMajorAxis = readLine.Substring(92, 11); strSemiMajorAxis = strSemiMajorAxis.Trim();
            if (strSemiMajorAxis == "") doubleSemiMajorAxis = 0; else doubleSemiMajorAxis = Convert.ToDouble(strSemiMajorAxis);
            strRef = readLine.Substring(107, 9); strRef = strRef.Trim();
            strNumbObs = readLine.Substring(117, 5); strNumbObs = strNumbObs.Trim();
            if (strNumbObs == "") doubleNumbObs = 0; else doubleNumbObs = Convert.ToDouble(strNumbObs);
            strNumbOppos = readLine.Substring(123, 3); strNumbOppos = strNumbOppos.Trim();
            if (strNumbOppos == "") doubleNumbOppos = 0; else doubleNumbOppos = Convert.ToDouble(strNumbOppos);
            strObsSpan = readLine.Substring(127, 9); strObsSpan = strObsSpan.Trim();
            strRmsResdiual = readLine.Substring(137, 4); strRmsResdiual = strRmsResdiual.Trim();
            if (strRmsResdiual == "") doubleRmsResdiual = 0; else doubleRmsResdiual = Convert.ToDouble(strRmsResdiual);
            strComputerName = readLine.Substring(150, 10); strComputerName = strComputerName.Trim();
            strFlags = readLine.Substring(161, 4); strFlags = strFlags.Trim();
            strDesgnName = readLine.Substring(166, 28); strDesgnName = strDesgnName.Trim();
            strObsLastDate = readLine.Substring(194, 8); strObsLastDate = strObsLastDate.Trim();
            if (strObsLastDate == "") doubleObsLastDate = 0; else doubleObsLastDate = Convert.ToDouble(strObsLastDate);

            arrIndex.Add(strIndex);
            arrMagAbs.Add(doubleMagAbs);
            arrSlopeParam.Add(doubleSlopeParam);
            arrEpoch.Add(strEpoch);
            arrMeanAnomaly.Add(doubleMeanAnomaly);
            arrArgPeri.Add(doubleArgPeri);
            arrLongAscNode.Add(doubleLongAscNode);
            arrIncl.Add(doubleIncl);
            arrOrbEcc.Add(doubleOrbEcc);
            arrMotion.Add(doubleMotion);
            arrSemiMajorAxis.Add(doubleSemiMajorAxis);
            arrRef.Add(strRef);
            arrNumbObs.Add(doubleNumbObs);
            arrNumbOppos.Add(doubleNumbOppos);
            arrObsSpan.Add(strObsSpan);
            arrRmsResdiual.Add(doubleRmsResdiual);
            arrComputerName.Add(strComputerName);
            arrFlags.Add(strFlags);
            arrDesgnName.Add(strDesgnName);
            arrObsLastDate.Add(doubleObsLastDate);*/

          }
        }
      }
      sr.Close();
      formSplashScreen.Close();

      /*for (int i = 0; i < arrDB.Count; i++)
      {
        strIndex = arrDB[i].ToString().Substring(0, 7); strIndex = strIndex.Trim();
        strMagAbs = arrDB[i].ToString().Substring(8, 5); strMagAbs = strMagAbs.Trim();
        if (strMagAbs == "") doubleMagAbs = 0; else doubleMagAbs = Convert.ToDouble(strMagAbs);
        strSlopeParam = arrDB[i].ToString().Substring(14, 5); strSlopeParam = strSlopeParam.Trim();
        if (strSlopeParam == "") doubleSlopeParam = 0; else doubleSlopeParam = Convert.ToDouble(strSlopeParam);
        strEpoch = arrDB[i].ToString().Substring(20, 5); strEpoch = strEpoch.Trim();
        strMeanAnomaly = arrDB[i].ToString().Substring(26, 9); strMeanAnomaly = strMeanAnomaly.Trim();
        if (strMeanAnomaly == "") doubleMeanAnomaly = 0; else doubleMeanAnomaly = Convert.ToDouble(strMeanAnomaly);
        strArgPeri = arrDB[i].ToString().Substring(37, 9); strArgPeri = strArgPeri.Trim();
        if (strArgPeri == "") doubleArgPeri = 0; else doubleArgPeri = Convert.ToDouble(strArgPeri);
        strLongAscNode = arrDB[i].ToString().Substring(48, 9); strLongAscNode = strLongAscNode.Trim();
        if (strLongAscNode == "") doubleLongAscNode = 0; else doubleLongAscNode = Convert.ToDouble(strLongAscNode);
        strIncl = arrDB[i].ToString().Substring(59, 9); strIncl = strIncl.Trim();
        if (strIncl == "") doubleIncl = 0; else doubleIncl = Convert.ToDouble(strIncl);
        strOrbEcc = arrDB[i].ToString().Substring(70, 9); strOrbEcc = strOrbEcc.Trim();
        if (strOrbEcc == "") doubleOrbEcc = 0; else doubleOrbEcc = Convert.ToDouble(strOrbEcc);
        strMotion = arrDB[i].ToString().Substring(80, 11); strMotion = strMotion.Trim();
        if (strSlopeParam == "") doubleMotion = 0; else doubleMotion = Convert.ToDouble(strMotion);
        strSemiMajorAxis = arrDB[i].ToString().Substring(92, 11); strSemiMajorAxis = strSemiMajorAxis.Trim();
        if (strSemiMajorAxis == "") doubleSemiMajorAxis = 0; else doubleSemiMajorAxis = Convert.ToDouble(strSemiMajorAxis);
        strRef = arrDB[i].ToString().Substring(107, 9); strRef = strRef.Trim();
        strNumbObs = arrDB[i].ToString().Substring(117, 5); strNumbObs = strNumbObs.Trim();
        if (strNumbObs == "") doubleNumbObs = 0; else doubleNumbObs = Convert.ToDouble(strNumbObs);
        strNumbOppos = arrDB[i].ToString().Substring(123, 3); strNumbOppos = strNumbOppos.Trim();
        if (strNumbOppos == "") doubleNumbOppos = 0; else doubleNumbOppos = Convert.ToDouble(strNumbOppos);
        strObsSpan = arrDB[i].ToString().Substring(127, 9); strObsSpan = strObsSpan.Trim();
        strRmsResdiual = arrDB[i].ToString().Substring(137, 4); strRmsResdiual = strRmsResdiual.Trim();
        if (strRmsResdiual == "") doubleRmsResdiual = 0; else doubleRmsResdiual = Convert.ToDouble(strRmsResdiual);
        strComputerName = arrDB[i].ToString().Substring(150, 10); strComputerName = strComputerName.Trim();
        strFlags = arrDB[i].ToString().Substring(161, 4); strFlags = strFlags.Trim();
        strDesgnName = arrDB[i].ToString().Substring(166, 28); strDesgnName = strDesgnName.Trim();
        strObsLastDate = arrDB[i].ToString().Substring(194, 8); strObsLastDate = strObsLastDate.Trim();
        if (strObsLastDate == "") doubleObsLastDate = 0; else doubleObsLastDate = Convert.ToDouble(strObsLastDate);

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
        arrObsSpan.Add(strObsSpan);
        arrRmsResdiual.Add(strRmsResdiual);
        arrComputerName.Add(strComputerName);
        arrFlags.Add(strFlags);
        arrDesgnName.Add(strDesgnName);
        arrObsLastDate.Add(strObsLastDate);

        float percent = 100 * i / (arrDB.Count - 1);
        step = (int)percent;
        formSplashScreen.setProgressbar(step);
      }

      
      arrDB.Clear();
       */


      numericUpDownGotoIndex.Minimum = 1;
      numericUpDownGotoIndex.Maximum = arrDB.Count;
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
      if (intCurrentPosition == 0) intCurrentPosition = arrDB.Count - 1; else intCurrentPosition--;
      GotoCurrentPosition(intCurrentPosition);
    }
    
    private void buttonStepForward1_Click(object sender, EventArgs e)
    {
      if (intCurrentPosition == arrDB.Count - 1) intCurrentPosition = 0; else intCurrentPosition++;
      GotoCurrentPosition(intCurrentPosition);
    }

    private void buttonStepForward_Click(object sender, EventArgs e)
    {
    }

    private void buttonStepToEnd_Click(object sender, EventArgs e)
    {
      intCurrentPosition = arrDB.Count - 1;
      GotoCurrentPosition(intCurrentPosition);
    }

    private void buttonGotoIndex_Click(object sender, EventArgs e)
    {
      intCurrentPosition = (int)numericUpDownGotoIndex.Value - 1;
      GotoCurrentPosition(intCurrentPosition);
    }

  }
}
