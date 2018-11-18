using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Office2007Rendering;

namespace PlanetoidDB
{
	public partial class DownloadUpdateForm : Form
  {
    
    bool isDownloadCancelled = true;
    Uri uriMPCORB = new Uri("http://www.minorplanetcenter.org/iau/MPCORB/MPCORB.DAT");
    string
      strFilenameMPCORB = "mpcorb.dat",
      strFilenameMPCORBtemp = "_";
    WebClient webClient = new WebClient();

    public DownloadUpdateForm()
    {
      InitializeComponent();
    }

    private void DownloadUpdateForm_Load(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new Office2007Renderer();
      strFilenameMPCORBtemp = "_" + strFilenameMPCORB;
      labelStatus.Text = "Status: nothing to do...";
      labelDate.Text = ""; labelDate.Visible = false;
      labelSize.Text = ""; labelSize.Visible = false;
      labelSource.Text = ""; labelSource.Visible = false;
      labelDownload.Text = "0 %";
      buttonCancelDownload.Enabled = false;
      webClient.Proxy = null;
      webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
    }

    private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      progressBarDownload.Value = e.ProgressPercentage;
      labelDownload.Text = e.ProgressPercentage.ToString() + " %";
      TaskbarProgress.SetValue(this.Handle, e.ProgressPercentage, 100);
    }

    private void Completed(object sender, AsyncCompletedEventArgs e)
    {
      if (!isDownloadCancelled)
      {
        labelStatus.Text = "Status: Refresh database...";
        File.Delete(strFilenameMPCORB);
        File.Copy(strFilenameMPCORBtemp, strFilenameMPCORB);
        labelStatus.Text = "Status: Download complete";
        MessageBox.Show("Download completed!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        buttonDownload.Enabled = true;
        buttonCheckForUpdate.Enabled = true;
        this.Close();
      } else {
        labelStatus.Text = "Status: Cancelled...";
        labelSource.Text = "";
        labelDate.Text = "";
        labelSize.Text = "";
        buttonDownload.Enabled = true;
        buttonCheckForUpdate.Enabled = true;
        buttonCancelDownload.Enabled = false;
        progressBarDownload.Value = 0;
        labelDownload.Text = progressBarDownload.Value.ToString() + " %";
      }
      TaskbarProgress.SetValue(this.Handle, 0, 100);
    }

    private void buttonDownload_Click(object sender, EventArgs e)
    {
      isDownloadCancelled = false;
      buttonDownload.Enabled = false;
      buttonCancelDownload.Enabled = true;
      buttonCheckForUpdate.Enabled = false;
      labelSource.Text = "Source: " + uriMPCORB.AbsoluteUri;
      labelSource.Visible = true;
      labelDate.Text = "date: " + getLastModified(uriMPCORB);
      labelDate.Visible = true;
      labelSize.Text = "size: " + getContentLength(uriMPCORB).ToString() + " Bytes";
      labelSize.Visible = true;
      labelStatus.Text = "Status: Try to connect...";
      try
      {
        labelStatus.Text = "Status: Downloading...";
        webClient.DownloadFileAsync(uriMPCORB, @strFilenameMPCORBtemp);
      }
      catch(Exception ex)
      {
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
    }

    private void DownloadUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (File.Exists(strFilenameMPCORBtemp)) File.Delete(strFilenameMPCORBtemp);
    }

    private void buttonCheckForUpdate_Click(object sender, EventArgs e)
    {
      FileInfo fi;
      long fileSize = 0;
      DateTime datetimeFileLocal = DateTime.MinValue;
      DateTime datetimeFileOnline = getLastModified(uriMPCORB);

      string strInfoMpcorbDatLocal = "MPCORB.DAT local:\n\r\n\r";
      if (File.Exists(strFilenameMPCORB))
      {
        fi = new FileInfo(strFilenameMPCORB);
        fileSize = fi.Length;
        datetimeFileLocal = fi.CreationTime;
        datetimeFileOnline = getLastModified(uriMPCORB);
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "     URL: " + fi.FullName;
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "\n\r     Content Length: " + fileSize.ToString() + " Bytes";
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "\n\r     Last modified: " + datetimeFileLocal;
      }
      else
      {
        strInfoMpcorbDatLocal = strInfoMpcorbDatLocal + "     no file found";
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

    private void DownloadUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.Dispose();
    }
  }
}
