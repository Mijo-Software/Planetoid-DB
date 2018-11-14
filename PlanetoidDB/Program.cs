using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PlanetoidDB
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]

    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      string strFilenameMPCORB = "mpcorb.dat";
      if (!File.Exists(strFilenameMPCORB))
      {
        DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
        formDownloaderForMpcorbDat.ShowDialog();
      }
      Application.Run(new PlanetoidDBForm());
    }
  }
}
