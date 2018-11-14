using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PlanetoidDB
{
  public partial class DownloadUpdateForm : Form
  {
    //PlanetoidDBForm formMain;
    WebClient webClient = new WebClient();
    bool isDownloadCancelled = true;

    public DownloadUpdateForm(PlanetoidDBForm caller)
    {
      //formMain = caller;
      InitializeComponent();
    }

    private void DownloadUpdateForm_Load(object sender, EventArgs e)
    {
      labelStatus.Text = "Status: nothing to do...";
      labelDownload.Text = "0 %";
      buttonClose.Enabled = false;
      buttonCancelDownload.Enabled = false;
      webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
    }

    private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      progressBarDownload.Value = e.ProgressPercentage;
      labelDownload.Text = e.ProgressPercentage.ToString() + " %";
      //formMain.Download(e.ProgressPercentage);
    }

    private void Completed(object sender, AsyncCompletedEventArgs e)
    {
      if (!isDownloadCancelled)
      {
        labelStatus.Text = "Status: Refresh database...";
        File.Delete("mpcorb.dat");
        File.Copy("_mpcorb.dat", "mpcorb.dat");
        //File.Delete("_mpcorb.dat");
        labelStatus.Text = "Status: Download complete";
        MessageBox.Show("Download completed!");
        //formMain.VisibleBackgroundDownload(false);
        buttonDownload.Enabled = true;
        //buttonCancelDownload.Enabled = false;
        this.Close();
      }
    }

    private void buttonDownload_Click(object sender, EventArgs e)
    {
      isDownloadCancelled = false;
      buttonDownload.Enabled = false;
      buttonCancelDownload.Enabled = true;
      //formMain.VisibleBackgroundDownload(true);
      labelStatus.Text = "Status: Try to connect...";
      try
      {
        labelStatus.Text = "Status: Downloading...";
        buttonClose.Enabled = true;
        webClient.DownloadFileAsync(new Uri("http://www.minorplanetcenter.org/iau/MPCORB/MPCORB.DAT"), @"_mpcorb.dat");
      }
      catch(Exception ex)
      {
        //formMain.VisibleBackgroundDownload(false);
        labelStatus.Text = "Status: An error occured...";
        buttonDownload.Enabled = true;
        MessageBox.Show(ex.Message);
      }
    }

    private void buttonCancelDownload_Click(object sender, EventArgs e)
    {
      isDownloadCancelled = true;
      webClient.CancelAsync();
      labelStatus.Text = "Status: Cancelled...";
      progressBarDownload.Value = 0;
      labelDownload.Text = progressBarDownload.Value.ToString() + " %";
      //formMain.Download(progressBarDownload.Value);
      //formMain.VisibleBackgroundDownload(false);
      buttonDownload.Enabled = true;
      buttonCancelDownload.Enabled = false;
      buttonClose.Enabled = false;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void DownloadUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (File.Exists("_mpcorb.dat")) File.Delete("_mpcorb.dat");
    }

  }
}
