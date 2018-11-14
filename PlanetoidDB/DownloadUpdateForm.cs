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
    
    bool isDownloadCancelled = true;
    Uri uriMPCORB = new Uri("http://www.minorplanetcenter.org/iau/MPCORB/MPCORB.DAT");
    string
      strFilenameMPCORB = "mpcorb.dat",
      strFilenameMPCORBtemp = "_";
    WebClient webClient = new WebClient();

    public DownloadUpdateForm(PlanetoidDBForm caller)
    {
      //formMain = caller;
      InitializeComponent();
    }

    private void DownloadUpdateForm_Load(object sender, EventArgs e)
    {
      strFilenameMPCORBtemp = "_" + strFilenameMPCORB;
      labelStatus.Text = "Status: nothing to do...";
      labelDate.Text = ""; labelDate.Visible = false;
      labelSize.Text = ""; labelSize.Visible = false;
      labelSource.Text = ""; labelSource.Visible = false;
      labelDownload.Text = "0 %";
      buttonClose.Enabled = false;
      buttonCancelDownload.Enabled = false;
      webClient.Proxy = null;
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
        File.Delete(strFilenameMPCORB);
        File.Copy(strFilenameMPCORBtemp, strFilenameMPCORB);
        labelStatus.Text = "Status: Download complete";
        MessageBox.Show("Download completed!");
        //formMain.VisibleBackgroundDownload(false);
        buttonDownload.Enabled = true;
        buttonCheckForUpdate.Enabled = true;
        //buttonCancelDownload.Enabled = false;
        this.Close();
      }
    }

    private void buttonDownload_Click(object sender, EventArgs e)
    {
      isDownloadCancelled = false;
      buttonDownload.Enabled = false;
      buttonCancelDownload.Enabled = true;
      buttonCheckForUpdate.Enabled = false;
      /*MessageBox.Show("Content Length: " + getContentLength(uriMPCORB).ToString() + " Bytes");
      MessageBox.Show("Last modified: " + getLastModified(uriMPCORB));*/
      labelSource.Text = "Source: " + uriMPCORB.AbsoluteUri;
      labelSource.Visible = true;
      labelDate.Text = "date: " + getLastModified(uriMPCORB);
      labelDate.Visible = true;
      //labelSize.Text = "size: " + getContentLength(uriMPCORB).ToString() + " Bytes";
      labelSize.Visible = true;


      labelStatus.Text = "Status: Try to connect...";
      try
      {
        labelStatus.Text = "Status: Downloading...";
        buttonClose.Enabled = true;
        webClient.DownloadFileAsync(uriMPCORB, @strFilenameMPCORBtemp);

      }
      catch(Exception ex)
      {
        //formMain.VisibleBackgroundDownload(false);
        labelStatus.Text = "Status: An error occured...";
        buttonDownload.Enabled = true;
        buttonCheckForUpdate.Enabled = true;
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
      buttonCheckForUpdate.Enabled = true;
      buttonCancelDownload.Enabled = false;
      buttonClose.Enabled = false;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void DownloadUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (File.Exists(strFilenameMPCORBtemp)) File.Delete(strFilenameMPCORBtemp);
    }

    private void buttonCheckForUpdate_Click(object sender, EventArgs e)
    {
        labelStatus.Text = "Status: checking for updates...";
        MessageBox.Show("Content Length: " + getContentLength(uriMPCORB).ToString() + " Bytes");
        MessageBox.Show("Last modified: " + getLastModified(uriMPCORB));
        labelStatus.Text = "Status:";
    }

    private string getLastModified(Uri uriLastModiefied)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uriLastModiefied);
        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        req.KeepAlive = false;
        string strLastModified = resp.LastModified.ToString();
        resp.Close();
        return strLastModified;
    }

    private Int64 getContentLength(Uri uriContentLength)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uriContentLength);
        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        req.KeepAlive = false;
        Int64 bytesTotal = Convert.ToInt64(resp.ContentLength);
        //webClient.OpenRead(uriContentLength);
        //Int64 bytesTotal = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
        resp.Close();
        return bytesTotal;
    }

  }
}
