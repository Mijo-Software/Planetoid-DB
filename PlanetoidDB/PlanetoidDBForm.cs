using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using Office2007Rendering;
using VS2008StripRenderingLibrary;

namespace PlanetoidDB
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PlanetoidDBForm : Form
	{
		private bool isDownloadCancelled = false;
		private int currentPosition = 0, stepPosition = 0;
		private ArrayList arrDB = new ArrayList(capacity: 0);
		private SplashScreenForm formSplashScreen = new SplashScreenForm();
		private WebClient webClient = new WebClient();
		private Uri uriMPCORB = new Uri(uriString: Planetoid_DB.Properties.Resources.strMpcorbUrl);

		#region Constructor and FormEvent-Handlers

		/// <summary>
		/// 
		/// </summary>
		public PlanetoidDBForm()
		{
			InitializeComponent();
			this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlanetoidDBForm_Load(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new Office2007Renderer();
			bwLoadingDB.WorkerReportsProgress = true;
			bwLoadingDB.WorkerSupportsCancellation = true;
			bwLoadingDB.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorkerLoadingDB_ProgressChanged);
			bwLoadingDB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerLoadingDB_RunWorkerCompleted);
			bwLoadingDB.RunWorkerAsync();
			formSplashScreen.Show();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlanetoidDBForm_Shown(object sender, EventArgs e)
		{
			toolStripStatusLabelBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Enabled = false;
			if (IsMpcorbDatUpdateAviable() == true)
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

		#endregion

		#region main functions

		private void Download(int i)
		{
			toolStripProgressBarBackgroundDownload.Visible = true;
			toolStripStatusLabelBackgroundDownload.Visible = true;
		}

		private void GotoCurrentPosition(int currentPosition)
		{
			//Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Lerrstrings sind.
			// if (teilstring == "0") zahl = 0; ...
			labelIndexValue.Text = arrDB[index: currentPosition].ToString().Substring(0, 7).Trim();
			labelMagAbsValue.Text = arrDB[index: currentPosition].ToString().Substring(8, 5).Trim();
			labelSlopeParamValue.Text = arrDB[index: currentPosition].ToString().Substring(14, 5).Trim();
			labelEpochValue.Text = arrDB[index: currentPosition].ToString().Substring(20, 5).Trim();
			labelMeanAnomalyValue.Text = arrDB[index: currentPosition].ToString().Substring(26, 9).Trim();
			labelArgPeriValue.Text = arrDB[index: currentPosition].ToString().Substring(37, 9).Trim();
			labelLongAscNodeValue.Text = arrDB[index: currentPosition].ToString().Substring(48, 9).Trim();
			labelInclValue.Text = arrDB[index: currentPosition].ToString().Substring(59, 9).Trim();
			labelOrbEccValue.Text = arrDB[index: currentPosition].ToString().Substring(70, 9).Trim();
			labelMotionValue.Text = arrDB[index: currentPosition].ToString().Substring(80, 11).Trim();
			labelSemiMajorAxisValue.Text = arrDB[index: currentPosition].ToString().Substring(92, 11).Trim();
			labelRefValue.Text = arrDB[index: currentPosition].ToString().Substring(107, 9).Trim();
			labelNumbObsValue.Text = arrDB[index: currentPosition].ToString().Substring(117, 5).Trim();
			labelNumbOpposValue.Text = arrDB[index: currentPosition].ToString().Substring(123, 3).Trim();
			labelObsSpanValue.Text = arrDB[index: currentPosition].ToString().Substring(127, 9).Trim();
			labelRmsResidualValue.Text = arrDB[index: currentPosition].ToString().Substring(137, 4).Trim();
			labelComputerNameValue.Text = arrDB[index: currentPosition].ToString().Substring(150, 10).Trim();
			labelFlagsValue.Text = arrDB[index: currentPosition].ToString().Substring(161, 4).Trim();
			labelDesgnNameValue.Text = arrDB[index: currentPosition].ToString().Substring(166, 28).Trim();
			labelObsLastDateValue.Text = arrDB[index: currentPosition].ToString().Substring(194, 8).Trim();
			labelIndexPos.Text = Planetoid_DB.I10nStrings.strIndex + ": " + (currentPosition + 1).ToString() + " / " + (arrDB.Count).ToString();
			trackBarIndex.Value = this.currentPosition;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="uriLastModiefied"></param>
		/// <returns></returns>
		private DateTime GetLastModified(Uri uriLastModiefied)
		{
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriLastModiefied);
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			return resp.LastModified;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="uriContentLength"></param>
		/// <returns></returns>
		private long GetContentLength(Uri uriContentLength)
		{
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriContentLength);
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			long bytesTotal = Convert.ToInt64(value: resp.ContentLength);
			//webClient.OpenRead(uriContentLength);
			//Int64 bytesTotal = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
			return bytesTotal;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool IsMpcorbDatUpdateAviable()
		{
			FileInfo fi = new FileInfo(fileName: Planetoid_DB.Properties.Resources.strFilenameMPCORB);
			long fileSize = fi.Length;
			DateTime datetimeFileLocal = fi.CreationTime;
			DateTime datetimeFileOnline = GetLastModified(uriLastModiefied: uriMPCORB);
			if (datetimeFileOnline > datetimeFileLocal) return true; else return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(text: Planetoid_DB.I10nStrings.strCopiedToClipboard, caption: "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// 
		/// </summary>
		private void OpenTableMode()
		{
			TableModeForm formTableMode = new TableModeForm();
			formTableMode.FillArray(arrTemp: arrDB);
			formTableMode.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowAppInfo()
		{
			AppInfoForm formAppInfo = new AppInfoForm();
			formAppInfo.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowDownloader()
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				MessageBox.Show(text: Planetoid_DB.I10nStrings.StrNoInternetConnectionText, caption: Planetoid_DB.I10nStrings.strErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
				formDownloaderForMpcorbDat.ShowDialog();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowDatabaseInformation()
		{
			DatabaseInformationForm formDatabaseInformation = new DatabaseInformationForm();
			formDatabaseInformation.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetLabelText(string text)
		{
			if (text == "")
			{
				labelHelp.Enabled = false;
			}
			else
			{
				labelHelp.Enabled = true;
			}
			labelHelp.Text = text;
		}

		/// <summary>
		/// 
		/// </summary>
		private void CheckMpcorbDat()
		{
			FileInfo fi = new FileInfo(fileName: Planetoid_DB.Properties.Resources.strFilenameMPCORB);
			long fileSize = fi.Length;
			DateTime datetimeFileLocal = fi.CreationTime;
			DateTime datetimeFileOnline = GetLastModified(uriLastModiefied: uriMPCORB);

			string strInfoMpcorbDatLocal = "MPCORB.DAT local:\n\r\n\r";
			if (File.Exists(path: Planetoid_DB.Properties.Resources.strFilenameMPCORB))
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
			strInfoMpcorbDatOnline = strInfoMpcorbDatOnline + "\n\r     Content Length: " + GetContentLength(uriMPCORB).ToString() + " Bytes";
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

		#endregion

		#region BackgroundWorker

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorkerLoadingDB_DoWork(object sender, DoWorkEventArgs e)
		{
			this.Enabled = false;
			string fileName = Planetoid_DB.Properties.Resources.strFilenameMPCORB;

			if (!File.Exists(path: fileName))
			{
				this.Hide();
				formSplashScreen.Close();
				MessageBox.Show("No file found. Program is quitting!\n\r\n\r1. Download \"" + uriMPCORB.ToString() + "\"!\n\r\n\r2. Copy it into \"" + Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\"!\n\r\n\r3. Restart!", "No file found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.Close();
			} else {
				formSplashScreen.Show();
				FileInfo fi = new FileInfo(fileName: fileName);
				long fileSize = fi.Length, fileSizeReaded = 0;
				int step = 0, lineNum = 0;
				FileStream fileStream = new FileStream(path: fileName, mode: FileMode.Open);
				StreamReader streamReader = new StreamReader(stream: fileStream);
				string readLine;

				while (streamReader.Peek() != -1 && !bwLoadingDB.CancellationPending)
				{
					readLine = streamReader.ReadLine();
					fileSizeReaded = fileSizeReaded + readLine.Length;
					float percent = 100 * fileSizeReaded / fileSize;
					step = (int)percent;
					formSplashScreen.SetProgressbar(value: step);
					lineNum++;
					if ((lineNum >= 44) && (readLine != "")) { arrDB.Add(value: readLine); }
				}

				fileStream.Close();
				streamReader.Close();
				formSplashScreen.Close();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorkerLoadingDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorkerLoadingDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
#if DEBUG
			Console.Write("Asynchroner Thread kam bis zum Wert: " + e.Result.ToString());
#endif
		}

		#endregion

		#region Download and DB update

		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			toolStripProgressBarBackgroundDownload.Value = e.ProgressPercentage;
			TaskbarProgress.SetValue(this.Handle, 0, 100);
		}

		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			if (isDownloadCancelled == false)
			{
				File.Delete(Planetoid_DB.Properties.Resources.strFilenameMPCORB);
				File.Copy(Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp, Planetoid_DB.Properties.Resources.strFilenameMPCORB);
				File.Delete(Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp);
				MessageBox.Show("Download complete! You must restart the program to apply the update of the database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				MessageBox.Show("Download cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				File.Delete(Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp);
			}
			toolStripStatusLabelBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Value = toolStripProgressBarBackgroundDownload.Minimum;
			TaskbarProgress.SetValue(this.Handle, 0, 100);
		}

		#endregion

		#region Timer

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TimerUpdate_Tick(object sender, EventArgs e) => PlanetoidDBForm_Shown(sender: sender, e: e);

		private void TimerUpdateBlink_Tick(object sender, EventArgs e)
		{
			if (toolStripStatusLabelUpdate.ForeColor == System.Drawing.SystemColors.HotTrack)
			{
				toolStripStatusLabelUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
			}
			else
			{
				toolStripStatusLabelUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
			}
		}

		#endregion

		#region Clear-Handler

		/// <summary>
		/// 
		/// </summary>
		private void ToolStripMenuItem_Clear()
		{
			toolStripMenuItem10.Checked = false;
			toolStripMenuItem100.Checked = false;
			toolStripMenuItem1000.Checked = false;
			toolStripMenuItem10000.Checked = false;
			toolStripMenuItem100000.Checked = false;
		}

		#endregion

		#region Scroll-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TrackBarIndex_Scroll(object sender, EventArgs e)
		{
			currentPosition = trackBarIndex.Value;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		#endregion

		#region Enter-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepToBegin_Enter(object sender, EventArgs e) => SetLabelText(text: buttonStepToBegin.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepBackward_Enter(object sender, EventArgs e) => SetLabelText(text: buttonStepBackward.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepBackward1_Enter(object sender, EventArgs e) => SetLabelText(text: buttonStepBackward1.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepForward1_Enter(object sender, EventArgs e) => SetLabelText(text: buttonStepForward1.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepForward_Enter(object sender, EventArgs e) => SetLabelText(text: buttonStepForward.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepToEnd_Enter(object sender, EventArgs e) => SetLabelText(text: buttonStepToEnd.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonGotoIndex_Enter(object sender, EventArgs e) => SetLabelText(text: buttonGotoIndex.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_Enter(object sender, EventArgs e) => SetLabelText(text: labelIndex.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnName_Enter(object sender, EventArgs e) => SetLabelText(text: labelDesgnName.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpoch_Enter(object sender, EventArgs e) => SetLabelText(text: labelEpoch.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxis_Enter(object sender, EventArgs e) => SetLabelText(text: labelSemiMajorAxis.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomaly_Enter(object sender, EventArgs e) => SetLabelText(text: labelMeanAnomaly.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeri_Enter(object sender, EventArgs e) => SetLabelText(text: labelArgPeri.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNode_Enter(object sender, EventArgs e) => SetLabelText(text: labelLongAscNode.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_Enter(object sender, EventArgs e) => SetLabelText(text: labelIncl.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEcc_Enter(object sender, EventArgs e) => SetLabelText(text: labelOrbEcc.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotion_Enter(object sender, EventArgs e) => SetLabelText(text: labelMotion.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbs_Enter(object sender, EventArgs e) => SetLabelText(text: labelMagAbs.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParam_Enter(object sender, EventArgs e) => SetLabelText(text: labelSlopeParam.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRef_Enter(object sender, EventArgs e) => SetLabelText(text: labelRef.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOppos_Enter(object sender, EventArgs e) => SetLabelText(text: labelNumbOppos.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObs_Enter(object sender, EventArgs e) => SetLabelText(text: labelNumbObs.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpan_Enter(object sender, EventArgs e) => SetLabelText(text: labelObsSpan.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_Enter(object sender, EventArgs e) => SetLabelText(text: labelRmsResidual.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerName_Enter(object sender, EventArgs e) => SetLabelText(text: labelComputerName.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlags_Enter(object sender, EventArgs e) => SetLabelText(text: labelFlags.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDate_Enter(object sender, EventArgs e) => SetLabelText(text: labelObsLastDate.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndexPos_Enter(object sender, EventArgs e) => SetLabelText(text: labelIndexPos.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndexValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelIndexValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnNameValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelDesgnNameValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpochValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelEpochValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomalyValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelMeanAnomalyValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeriValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelArgPeriValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNodeValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelLongAscNodeValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelInclValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelInclValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEccValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelOrbEccValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotionValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelMotionValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxisValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelSemiMajorAxisValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbsValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelMagAbsValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParamValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelSlopeParamValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelRefValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOpposValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelNumbOpposValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObsValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelNumbObsValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpanValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelObsSpanValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidualValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelRmsResidualValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerNameValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelComputerNameValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlagsValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelFlagsValue.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDateValue_Enter(object sender, EventArgs e) => SetLabelText(text: labelObsLastDateValue.AccessibleDescription);

		#endregion

		#region MouseEnter-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TrackBarIndex_MouseEnter(object sender, EventArgs e) => SetLabelText(text: trackBarIndex.AccessibleDescription);
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOptions_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOptions.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemExit_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemExit.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemCheckMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemCheckMpcorbDat.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemDownloadMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemDownloadMpcorbDat.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemQuest_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemQuest.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsitePDB_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOpenWebsitePDB.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsiteMPC_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOpenWebsiteMPC.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenMPCORBWebsite_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOpenMPCORBWebsite.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemAbout_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemAbout.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripSeparatorMisc_MouseEnter(object sender, EventArgs e)
		{
			//todo: easter egg			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelUpdate_MouseEnter(object sender, EventArgs e)
		{
			if (timerUpdateBlink.Enabled) toolStripStatusLabelUpdate.IsLink = true;
			SetLabelText(text: toolStripStatusLabelUpdate.AccessibleDescription);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelBackgroundDownload_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripStatusLabelBackgroundDownload.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripProgressBarBackgroundDownload_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripProgressBarBackgroundDownload.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCheckMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonCheckMpcorbDat.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonDownloadMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonDownloadMpcorbDat.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonAbout_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonAbout.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonOpenWebsitePDB_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonOpenWebsitePDB.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemEdit_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemEdit.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonTableMode_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonTableMode.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemTableMode_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemTableMode.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemStyle_MouseEnter(object sender, EventArgs e) => SetLabelText(text: ToolStripMenuItemStyle.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemStyleProfessionell_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemStyleProfessional.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSystem_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemStyleSystem.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemVs2008_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemStyleVs2008.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonPrint_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonPrint.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCopyToClipboard_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonCopyToClipboard.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonDatabaseInformation_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonDatabaseInformation.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemPrint_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemPrint.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripTextBoxSearch_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripTextBoxSearch.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonSearch_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonSearch.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopytoClipboard_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemCopytoClipboard.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSearch_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemSearch.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemDatabaseInformation_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemDatabaseInformation.AccessibleDescription);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemFile_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemFile.AccessibleDescription);

		#endregion

		#region Leave-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndexPos_Leave(object sender, EventArgs e) => SetLabelText(text: "");
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepToBegin_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepBackward_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepBackward1_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepForward1_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepForward_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepToEnd_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonGotoIndex_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnNameValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpochValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomalyValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeriValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNodeValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelInclValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEccValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotionValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxisValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbsValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnName_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpoch_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomaly_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeri_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNode_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_Leave(object sender, MouseEventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEcc_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotion_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndexValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxis_Leave(object sender, MouseEventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbs_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_Leave(object sender, EventArgs e) => SetLabelText(text: ""); private void LabelSemiMajorAxis_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParam_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParamValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOpposValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObsValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpanValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidualValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerNameValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlagsValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDateValue_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRef_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOppos_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObs_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpan_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_Leave(object sender, MouseEventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerName_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlags_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDate_Leave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion

		#region MouseLeave-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TrackBarIndex_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemFile_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemExit_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOptions_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemCheckMpcorbDat_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemDownloadMpcorbDat_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemQuest_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsitePDB_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsiteMPC_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenMPCORBWebsite_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemAbout_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripSeparatorMisc_MouseLeave(object sender, EventArgs e)
		{
			//todo: easter egg			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelUpdate_MouseLeave(object sender, EventArgs e)
		{
			if (timerUpdateBlink.Enabled) toolStripStatusLabelUpdate.IsLink = false;
			SetLabelText(text: "");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelBackgroundDownload_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripProgressBarBackgroundDownload_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCheckMpcorbDat_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonDownloadMpcorbDat_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonAbout_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonOpenWebsitePDB_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemEdit_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemTableMode_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonTableMode_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemStyle_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemStyleProfessionell_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSystem_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonPrint_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCopyToClipboard_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonDatabaseInformation_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemPrint_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripTextBoxSearch_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonSearch_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopytoClipboard_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSearch_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemVs2008_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemDatabaseInformation_MouseLeave(object sender, EventArgs e) => SetLabelText(text: "");

		#endregion

		#region Click-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepToBegin_Click(object sender, EventArgs e)
		{
			currentPosition = 0;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepBackward_Click(object sender, EventArgs e)
		{
			currentPosition = currentPosition - stepPosition;
			if (currentPosition < 1) currentPosition = arrDB.Count + currentPosition;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepBackward1_Click(object sender, EventArgs e)
		{
			if (currentPosition == 0) currentPosition = arrDB.Count - 1; else currentPosition--;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepForward1_Click(object sender, EventArgs e)
		{
			if (currentPosition == arrDB.Count - 1) currentPosition = 0; else currentPosition++;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepForward_Click(object sender, EventArgs e)
		{
			currentPosition = currentPosition + stepPosition;
			if (currentPosition > arrDB.Count) currentPosition = currentPosition - arrDB.Count;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStepToEnd_Click(object sender, EventArgs e)
		{
			currentPosition = arrDB.Count - 1;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonGotoIndex_Click(object sender, EventArgs e)
		{
			currentPosition = (int)numericUpDownGotoIndex.Value - 1;
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			stepPosition = 10;
			ToolStripMenuItem_Clear();
			toolStripMenuItem10.Checked = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItem100_Click(object sender, EventArgs e)
		{
			stepPosition = 100;
			ToolStripMenuItem_Clear();
			toolStripMenuItem100.Checked = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItem1000_Click(object sender, EventArgs e)
		{
			stepPosition = 1000;
			ToolStripMenuItem_Clear();
			toolStripMenuItem1000.Checked = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItem10000_Click(object sender, EventArgs e)
		{
			stepPosition = 10000;
			ToolStripMenuItem_Clear();
			toolStripMenuItem10000.Checked = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItem100000_Click(object sender, EventArgs e)
		{
			stepPosition = 100000;
			ToolStripMenuItem_Clear();
			toolStripMenuItem100000.Checked = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemExit_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemAbout_Click(object sender, EventArgs e)
		{
			AppInfoForm formAppInfo = new AppInfoForm();
			formAppInfo.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsitePDB_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(fileName: Planetoid_DB.Properties.Resources.strHomepage);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsiteMPC_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(fileName: Planetoid_DB.Properties.Resources.strWebsiteMpc);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenMPCORBWebsite_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(fileName: Planetoid_DB.Properties.Resources.strWebsiteMpcorb);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemDownloadMpcorbDat_Click(object sender, EventArgs e) => ShowDownloader();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemCheckMpcorbDat_Click(object sender, EventArgs e)
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				MessageBox.Show(text: Planetoid_DB.I10nStrings.StrNoInternetConnectionText, caption: Planetoid_DB.I10nStrings.strErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				CheckMpcorbDat();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParamValue_Click(object sender, EventArgs e) => CopyToClipboard(text: labelSlopeParamValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripSeparatorMisc_Click(object sender, EventArgs e)
		{
			//todo: easter egg

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnName_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpoch_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomaly_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeri_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNode_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_Click(object sender, EventArgs e)
		{
			//v: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEcc_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotion_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxis_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbs_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParam_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRef_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOppos_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObs_Click(object sender, EventArgs e)
		{

			//todo: add a short message, what is; definition
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpan_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerName_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlags_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDate_Click(object sender, EventArgs e)
		{
			//todo: add a short message, what is; definition

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelUpdate_Click(object sender, EventArgs e)
		{
			timerUpdateBlink.Enabled = false;
			if (MessageBox.Show(text: "Do you want download the lastest MPCORB.DAT file?", caption: "Download MPCORB.DAT?", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question) == DialogResult.Yes)
			{
				toolStripStatusLabelBackgroundDownload.Enabled = true;
				toolStripProgressBarBackgroundDownload.Enabled = true;
				webClient.Proxy = null;
				webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
				webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
				try
				{
					webClient.DownloadFileAsync(address: uriMPCORB, fileName: @Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp);
				}
				catch (Exception ex)
				{
					MessageBox.Show(text: ex.Message);
				}
			}
			toolStripStatusLabelUpdate.Enabled = false;
			toolStripStatusLabelUpdate.IsLink = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e)
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				MessageBox.Show(text: Planetoid_DB.I10nStrings.StrNoInternetConnectionText, caption: Planetoid_DB.I10nStrings.strErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				CheckMpcorbDat();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonDownloadMpcorbDat_Click(object sender, EventArgs e) => ShowDownloader();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonAbout_Click(object sender, EventArgs e) => ShowAppInfo();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(fileName: Planetoid_DB.Properties.Resources.strHomepage);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonTableMode_Click(object sender, EventArgs e) => OpenTableMode();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemTableMode_Click(object sender, EventArgs e) => OpenTableMode();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonDatabaseInformation_Click(object sender, EventArgs e) => ShowDatabaseInformation();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemStyleOffice2007_Click(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new Office2007Renderer();
			toolStripMenuItemStyleProfessional.Checked = false;
			toolStripMenuItemStyleOffice2007.Checked = true;
			toolStripMenuItemStyleSystem.Checked = false;
			toolStripMenuItemStyleVs2008.Checked = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemStyleProfessionell_Click(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new ToolStripProfessionalRenderer();
			toolStripMenuItemStyleProfessional.Checked = true;
			toolStripMenuItemStyleOffice2007.Checked = false;
			toolStripMenuItemStyleSystem.Checked = false;
			toolStripMenuItemStyleVs2008.Checked = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSystem_Click(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new ToolStripSystemRenderer();
			toolStripMenuItemStyleProfessional.Checked = false;
			toolStripMenuItemStyleOffice2007.Checked = false;
			toolStripMenuItemStyleSystem.Checked = true;
			toolStripMenuItemStyleVs2008.Checked = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemVs2008_Click(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new VS2008ToolStripRenderer();
			toolStripMenuItemStyleProfessional.Checked = false;
			toolStripMenuItemStyleOffice2007.Checked = false;
			toolStripMenuItemStyleSystem.Checked = false;
			toolStripMenuItemStyleVs2008.Checked = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NotifyIconUpdate_Click(object sender, EventArgs e)
		{
			//todo: add NotifyIcon here

			//contextMenuNotifyIcon.Show(notifyIconUpdate, 0, 100);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonPrint_Click(object sender, EventArgs e)
		{
			//todo: add Print here

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCopyToClipboard_Click(object sender, EventArgs e)
		{
			//todo: add CopyToClipboard here

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemPrint_Click(object sender, EventArgs e)
		{
			//todo: add Print here

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonSearch_Click(object sender, EventArgs e)
		{
			//todo: add Search here

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopytoClipboard_Click(object sender, EventArgs e)
		{
			//todo: add CopyToClipboard here

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSearch_Click(object sender, EventArgs e)
		{
			//todo: add Search here

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemDatabaseInformation_Click(object sender, EventArgs e) => ShowDatabaseInformation();

		#endregion

		#region DoubleClick-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndexValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelIndexValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnNameValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDesgnNameValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpochValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelEpochValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomalyValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMeanAnomalyValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeriValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelArgPeriValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNodeValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLongAscNodeValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelInclValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLongAscNodeValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEccValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelOrbEccValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotionValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMotionValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxisValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSemiMajorAxisValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMagAbsValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParamValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSlopeParamValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRefValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelRefValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOpposValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelNumbOpposValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelNumbObsValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpanValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelObsSpanValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidualValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelRmsResidualValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerNameValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelComputerNameValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlagsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelFlagsValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDateValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelObsLastDateValue.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndex_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelIndex.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDesgnName_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelDesgnName.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpoch_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelEpoch.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanAnomaly_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMeanAnomaly.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgPeri_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelArgPeri.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongAscNode_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelLongAscNode.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIncl_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelIncl.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbEcc_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelOrbEcc.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMotion_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMotion.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxis_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSemiMajorAxis.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMagAbs_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelMagAbs.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParam_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelSlopeParam.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRef_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelRef.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbOppos_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelNumbOppos.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumbObs_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelNumbObs.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsSpan_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelObsSpan.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidual_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelRmsResidual.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObsLastDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelObsLastDate.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerName_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelComputerName.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlags_DoubleClick(object sender, EventArgs e) => CopyToClipboard(text: labelFlags.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelUpdate_DoubleClick(object sender, EventArgs e)
		{
			timerUpdateBlink.Enabled = false;
			toolStripStatusLabelUpdate.Enabled = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelBackgroundDownload_DoubleClick(object sender, EventArgs e)
		{
			isDownloadCancelled = true;
			webClient.CancelAsync();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripProgressBarBackgroundDownload_DoubleClick(object sender, EventArgs e)
		{
			isDownloadCancelled = true;
			webClient.CancelAsync();
		}

		#endregion

	}
}
