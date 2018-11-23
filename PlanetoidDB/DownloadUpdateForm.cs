using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Office2007Rendering;

namespace PlanetoidDB
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DownloadUpdateForm : Form
  {
		private Uri uriMPCORB = new Uri(uriString: Planetoid_DB.Properties.Resources.strMpcorbUrl);
		private string
			strFilenameMPCORB = Planetoid_DB.Properties.Resources.strFilenameMPCORB,
			strFilenameMPCORBtemp = Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp;
		private WebClient webClient = new WebClient();

		/// <summary>
		/// 
		/// </summary>
		public DownloadUpdateForm() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_Load(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new Office2007Renderer();
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

    /// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      progressBarDownload.Value = e.ProgressPercentage;
      labelDownload.Text = e.ProgressPercentage.ToString() + " %";
      TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: e.ProgressPercentage, progressMax: 100);
    }

    /// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Completed(object sender, AsyncCompletedEventArgs e)
    {
			if (e.Error == null)
			{
				labelStatus.Text = "Status: Updating database...";
				File.Delete(path: strFilenameMPCORB);
				File.Copy(sourceFileName: strFilenameMPCORBtemp, destFileName: strFilenameMPCORB);
				labelStatus.Text = "Status: Download complete";
				MessageBox.Show(text: "Download completed!", caption: "Complete", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				this.Close();
			}
			else
			{
				if (e.Cancelled)
				{
					labelStatus.Text = "Status: Cancelled...";
				}
				else
				{
					labelStatus.Text = "Status: Unknown error... " + e.Error;
				}
				labelSource.Text = "";
				labelDate.Text = "";
				labelSize.Text = "";
				buttonDownload.Enabled = true;
				buttonCheckForUpdate.Enabled = true;
				buttonCancelDownload.Enabled = false;
				progressBarDownload.Value = 0;
				labelDownload.Text = progressBarDownload.Value.ToString() + " %";
			}
      TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: 0, progressMax: 100);
    }

    /// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonDownload_Click(object sender, EventArgs e)
    {
      buttonDownload.Enabled = false;
      buttonCancelDownload.Enabled = true;
      buttonCheckForUpdate.Enabled = false;
      labelSource.Text = "Source: " + uriMPCORB.AbsoluteUri;
      labelSource.Visible = true;
      //labelDate.Text = "date: " + GetLastModified(uriLastModiefied: uriMPCORB);
      labelDate.Visible = true;
      //labelSize.Text = "size: " + GetContentLength(uri: uriMPCORB).ToString() + " Bytes";
      labelSize.Visible = true;
      labelStatus.Text = "Status: Try to connect...";
      try
      {
        labelStatus.Text = "Status: Downloading...";
        webClient.DownloadFileAsync(address: uriMPCORB, fileName: @strFilenameMPCORBtemp);
      }
      catch(Exception ex)
      {
        labelStatus.Text = "Status: An error occured...";
        buttonDownload.Enabled = true;
        buttonCheckForUpdate.Enabled = true;
        MessageBox.Show(text: ex.Message);
      }
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancelDownload_Click(object sender, EventArgs e) => webClient.CancelAsync();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (File.Exists(path: strFilenameMPCORBtemp))
			{
				File.Delete(path: strFilenameMPCORBtemp);
			}
		}

    /// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCheckForUpdate_Click(object sender, EventArgs e)
    {
      FileInfo fi;
      long fileSize = 0;
      DateTime datetimeFileLocal = DateTime.MinValue;
      DateTime datetimeFileOnline = GetLastModified(uriLastModiefied: uriMPCORB);
      string strInfoMpcorbDatLocal = "MPCORB.DAT local:\n\r\n\r";
      if (File.Exists(path: strFilenameMPCORB))
      {
        fi = new FileInfo(strFilenameMPCORB);
        fileSize = fi.Length;
        datetimeFileLocal = fi.CreationTime;
        datetimeFileOnline = GetLastModified(uriLastModiefied: uriMPCORB);
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
      strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "\n\r     Content Length: " + GetContentLength(uri: uriMPCORB).ToString() + " Bytes";
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
      MessageBox.Show(text: strInfoMpcorbDatLocal + "\n\r\n\r" + strInfoMpcorbDatOnline + "\n\r\n\r" + strUpdate, caption: "MPCORB.DAT infomations", buttons: MessageBoxButtons.OK, icon: mbi);
    }

    /// <summary>
		/// 
		/// </summary>
		/// <param name="uriLastModiefied"></param>
		/// <returns></returns>
		private DateTime GetLastModified(Uri uriLastModiefied)
    {
			/*
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriLastModiefied);
      HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
      return resp.LastModified;
			*/
			return new DateTime();
    }

    /// <summary>
		/// 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		private long GetContentLength(Uri uri)
    {
			//HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriContentLength);
			//HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			//long bytesTotal = Convert.ToInt64(value: resp.ContentLength);

			webClient.OpenRead(address: uri);
			long bytesTotal = Convert.ToInt64(value: webClient.ResponseHeaders["Content-Length"]);
      return bytesTotal;
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DownloadUpdateForm_FormClosed(object sender, FormClosedEventArgs e) => this.Dispose();
	}
}
