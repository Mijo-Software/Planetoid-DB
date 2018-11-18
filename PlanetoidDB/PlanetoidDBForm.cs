using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Office2007Rendering;
using VS2008StripRenderingLibrary;

namespace PlanetoidDB
{
	public partial class PlanetoidDBForm : Form
	{
		bool isDownloadCancelled = false;
		int currentPosition = 0, stepPosition = 0;
		ArrayList arrDB = new ArrayList(0);
		SplashScreenForm formSplashScreen = new SplashScreenForm();
		WebClient webClient = new WebClient();
		Uri uriMPCORB = new Uri(Planetoid_DB.Properties.Resources.strMpcorbUrl);

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
			labelIndexPos.Text = "Index: " + (currentPosition + 1).ToString() + " / " + (arrDB.Count).ToString();
			trackBarIndex.Value = this.currentPosition;
		}

		/// <summary>
		/// 
		/// </summary>
		public PlanetoidDBForm()
		{
			InitializeComponent();
			this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
			ClearLabelHelp();
		}

		private void PlanetoidDBForm_Load(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new Office2007Renderer();
			bwLoadingDB.WorkerReportsProgress = true;
			bwLoadingDB.WorkerSupportsCancellation = true;
			bwLoadingDB.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorkerLoadingDB_ProgressChanged);
			bwLoadingDB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerLoadingDB_RunWorkerCompleted);
			bwLoadingDB.RunWorkerAsync();
			formSplashScreen.Show();
			formSplashScreen.Update();
		}

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

		private void ButtonStepToBegin_Click(object sender, EventArgs e)
		{
			currentPosition = 0;
			GotoCurrentPosition(currentPosition);
		}

		private void ButtonStepBackward_Click(object sender, EventArgs e)
		{
			currentPosition = currentPosition - stepPosition;
			if (currentPosition < 1) currentPosition = arrDB.Count + currentPosition;
			GotoCurrentPosition(currentPosition);
		}

		private void ButtonStepBackward1_Click(object sender, EventArgs e)
		{
			if (currentPosition == 0) currentPosition = arrDB.Count - 1; else currentPosition--;
			GotoCurrentPosition(currentPosition);
		}

		private void ButtonStepForward1_Click(object sender, EventArgs e)
		{
			if (currentPosition == arrDB.Count - 1) currentPosition = 0; else currentPosition++;
			GotoCurrentPosition(currentPosition);
		}

		private void ButtonStepForward_Click(object sender, EventArgs e)
		{
			currentPosition = currentPosition + stepPosition;
			if (currentPosition > arrDB.Count) currentPosition = currentPosition - arrDB.Count;
			GotoCurrentPosition(currentPosition);
		}

		private void ButtonStepToEnd_Click(object sender, EventArgs e)
		{
			currentPosition = arrDB.Count - 1;
			GotoCurrentPosition(currentPosition);
		}

		private void ButtonGotoIndex_Click(object sender, EventArgs e)
		{
			currentPosition = (int)numericUpDownGotoIndex.Value - 1;
			GotoCurrentPosition(currentPosition);
		}

		private void ToolStripMenuItem_Clear()
		{
			toolStripMenuItem10.Checked = false;
			toolStripMenuItem100.Checked = false;
			toolStripMenuItem1000.Checked = false;
			toolStripMenuItem10000.Checked = false;
			toolStripMenuItem100000.Checked = false;
		}

		private void ToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			stepPosition = 10;
			ToolStripMenuItem_Clear();
			toolStripMenuItem10.Checked = true;
		}

		private void ToolStripMenuItem100_Click(object sender, EventArgs e)
		{
			stepPosition = 100;
			ToolStripMenuItem_Clear();
			toolStripMenuItem100.Checked = true;
		}

		private void ToolStripMenuItem1000_Click(object sender, EventArgs e)
		{
			stepPosition = 1000;
			ToolStripMenuItem_Clear();
			toolStripMenuItem1000.Checked = true;
		}

		private void ToolStripMenuItem10000_Click(object sender, EventArgs e)
		{
			stepPosition = 10000;
			ToolStripMenuItem_Clear();
			toolStripMenuItem10000.Checked = true;
		}

		private void ToolStripMenuItem100000_Click(object sender, EventArgs e)
		{
			stepPosition = 100000;
			ToolStripMenuItem_Clear();
			toolStripMenuItem100000.Checked = true;
		}

		private void MenuitemExit_Click(object sender, EventArgs e) => Close();

		private void MenuitemAbout_Click(object sender, EventArgs e)
		{
			AppInfoForm formAppInfo = new AppInfoForm();
			formAppInfo.ShowDialog();
		}

		private void MenuitemOpenWebsitePDB_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(Planetoid_DB.Properties.Resources.strHomepage);

		private void MenuitemOpenWebsiteMPC_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(Planetoid_DB.Properties.Resources.strWebsiteMpc);

		private void MenuitemOpenMPCORBWebsite_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(Planetoid_DB.Properties.Resources.strWebsiteMpcorb);

		private void MenuitemDownloadMpcorbDat_Click(object sender, EventArgs e)
		{
			DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
			formDownloaderForMpcorbDat.ShowDialog();
		}

		private void TrackBarIndex_Scroll(object sender, EventArgs e)
		{
			currentPosition = trackBarIndex.Value;
			GotoCurrentPosition(currentPosition);
		}

		private void BackgroundWorkerLoadingDB_DoWork(object sender, DoWorkEventArgs e)
		{
			this.Enabled = false;
			string fileName = Planetoid_DB.Properties.Resources.strFilenameMPCORB;

			if (!File.Exists(fileName))
			{
				this.Hide();
				formSplashScreen.Close();
				MessageBox.Show("No file found. Program is quitting!\n\r\n\r1. Download \"" + uriMPCORB.ToString() + "\"!\n\r\n\r2. Copy it into \"" + Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\"!\n\r\n\r3. Restart!", "No file found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.Close();
			} else {
				formSplashScreen.Show();
			}

			FileInfo fi = new FileInfo(fileName);
			long fileSize = fi.Length, fileSizeReaded = 0;
			int step = 0, lineNum = 0;
			FileStream fs;
			StreamReader sr;
			string readLine;

			fs = new FileStream(fileName, FileMode.Open);
			sr = new StreamReader(fs);

			while (sr.Peek() != -1 && !bwLoadingDB.CancellationPending)
			{
				readLine = sr.ReadLine();
				fileSizeReaded = fileSizeReaded + readLine.Length;
				float percent = 100 * fileSizeReaded / fileSize;
				step = (int)percent;
				formSplashScreen.SetProgressbar(step);
				//TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: 0, progressMax: 100);
				lineNum++;
				if ((lineNum >= 44) && (readLine != "")) { arrDB.Add(readLine); }
			}

			fs.Close();
			sr.Close();
			formSplashScreen.Close();
			formSplashScreen.Dispose();
		}

		private void BackgroundWorkerLoadingDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			//formSplashScreen.setProgressbar(e.ProgressPercentage);
			//TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: 0, progressMax: 100);
		}

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
			TaskbarProgress.SetValue(windowHandle: this.Handle, progressValue: 0, progressMax: 100);
#if DEBUG
			Console.Write("Asynchroner Thread kam bis zum Wert: " + e.Result.ToString());
#endif
		}

		private void MenuitemCheckMpcorbDat_Click(object sender, EventArgs e) => CheckMpcorbDat();

		private DateTime GetLastModified(Uri uriLastModiefied)
		{
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriLastModiefied);
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			return resp.LastModified;
		}

		private long GetContentLength(Uri uriContentLength)
		{
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUri: uriContentLength);
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			long bytesTotal = Convert.ToInt64(resp.ContentLength);
			//webClient.OpenRead(uriContentLength);
			//Int64 bytesTotal = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
			return bytesTotal;
		}

		private bool IsMpcorbDatUpdateAviable()
		{
			FileInfo fi = new FileInfo(fileName: Planetoid_DB.Properties.Resources.strFilenameMPCORB);
			long fileSize = fi.Length;
			DateTime datetimeFileLocal = fi.CreationTime;
			DateTime datetimeFileOnline = GetLastModified(uriLastModiefied: uriMPCORB);
			if (datetimeFileOnline > datetimeFileLocal) return true; else return false;
		}

		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text);
			MessageBox.Show("Copied to clipboard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void OpenTableMode()
		{
			TableModeForm formTableMode = new TableModeForm();
			formTableMode.FillArray(arrDB);
			formTableMode.ShowDialog();
		}

		private void ShowAppInfo()
		{
			AppInfoForm formAppInfo = new AppInfoForm();
			formAppInfo.ShowDialog();
		}

		private void ShowDownloader()
		{
			DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
			formDownloaderForMpcorbDat.ShowDialog();
		}

		private void ShowDatabaseInformation()
		{
			DatabaseInformationForm formDatabaseInformation = new DatabaseInformationForm();
			formDatabaseInformation.ShowDialog();
		}

		private void LabelIndexValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelIndexValue.Text);

		private void LabelDesgnNameValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelDesgnNameValue.Text);

		private void LabelEpochValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelEpochValue.Text);

		private void LabelMeanAnomalyValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMeanAnomalyValue.Text);

		private void LabelArgPeriValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelArgPeriValue.Text);

		private void LabelLongAscNodeValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelLongAscNodeValue.Text);

		private void LabelInclValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelLongAscNodeValue.Text);

		private void LabelOrbEccValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelOrbEccValue.Text);

		private void LabelMotionValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMotionValue.Text);

		private void LabelSemiMajorAxisValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelSemiMajorAxisValue.Text);

		private void LabelMagAbsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMagAbsValue.Text);

		private void LabelSlopeParamValue_Click(object sender, EventArgs e) => CopyToClipboard(labelSlopeParamValue.Text);

		private void LabelSlopeParamValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelSlopeParamValue.Text);

		private void LabelRefValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelRefValue.Text);

		private void LabelNumbOpposValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelNumbOpposValue.Text);

		private void LabelNumbObsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelNumbObsValue.Text);

		private void LabelObsSpanValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelObsSpanValue.Text);

		private void LabelRmsResidualValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelRmsResidualValue.Text);

		private void LabelComputerNameValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelComputerNameValue.Text);

		private void LabelFlagsValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelFlagsValue.Text);

		private void LabelObsLastDateValue_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelObsLastDateValue.Text);

		private void LabelIndex_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelIndex.Text);

		private void LabelDesgnName_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelDesgnName.Text);

		private void LabelEpoch_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelEpoch.Text);

		private void LabelMeanAnomaly_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMeanAnomaly.Text);

		private void LabelArgPeri_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelArgPeri.Text);

		private void LabelLongAscNode_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelLongAscNode.Text);

		private void LabelIncl_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelIncl.Text);

		private void LabelOrbEcc_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelOrbEcc.Text);

		private void LabelMotion_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMotion.Text);

		private void LabelSemiMajorAxis_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelSemiMajorAxis.Text);

		private void LabelMagAbs_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelMagAbs.Text);

		private void LabelSlopeParam_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelSlopeParam.Text);

		private void LabelRef_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelRef.Text);

		private void LabelNumbOppos_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelNumbOppos.Text);

		private void LabelNumbObs_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelNumbObs.Text);

		private void LabelObsSpan_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelObsSpan.Text);

		private void LabelRmsResidual_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelRmsResidual.Text);

		private void LabelObsLastDate_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelObsLastDate.Text);

		private void LabelComputerName_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelComputerName.Text);

		private void LabelFlags_DoubleClick(object sender, EventArgs e) => CopyToClipboard(labelFlags.Text);

		private void ButtonStepToBegin_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonStepToBegin.AccessibleDescription);

		private void ButtonStepToBegin_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ButtonStepBackward_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonStepBackward.AccessibleDescription);

		private void ButtonStepBackward_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ButtonStepBackward1_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonStepBackward1.AccessibleDescription);

		private void ButtonStepBackward1_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ButtonStepForward1_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonStepForward1.AccessibleDescription);

		private void ButtonStepForward1_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ButtonStepForward_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonStepForward.AccessibleDescription);

		private void ButtonStepForward_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ButtonStepToEnd_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonStepToEnd.AccessibleDescription);

		private void ButtonStepToEnd_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ButtonGotoIndex_MouseEnter(object sender, EventArgs e) => SetLabelText(text: buttonGotoIndex.AccessibleDescription);

		private void ButtonGotoIndex_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void TrackBarIndex_MouseEnter(object sender, EventArgs e) => SetLabelText(text: trackBarIndex.AccessibleDescription);

		private void TrackBarIndex_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemFile_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemFile.AccessibleDescription);

		private void MenuitemFile_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemExit_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemExit.AccessibleDescription);

		private void MenuitemExit_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemOptions_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOptions.AccessibleDescription);

		private void MenuitemOptions_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemCheckMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemCheckMpcorbDat.AccessibleDescription);

		private void MenuitemCheckMpcorbDat_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemDownloadMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemDownloadMpcorbDat.AccessibleDescription);

		private void MenuitemDownloadMpcorbDat_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemQuest_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemQuest.AccessibleDescription);

		private void MenuitemQuest_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemOpenWebsitePDB_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOpenWebsitePDB.AccessibleDescription);

		private void MenuitemOpenWebsitePDB_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemOpenWebsiteMPC_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOpenWebsiteMPC.AccessibleDescription);

		private void MenuitemOpenWebsiteMPC_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemOpenMPCORBWebsite_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemOpenMPCORBWebsite.AccessibleDescription);

		private void MenuitemOpenMPCORBWebsite_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelIndexValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelIndexValue.AccessibleDescription);

		private void LabelIndexValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelDesgnNameValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelDesgnNameValue.AccessibleDescription);

		private void LabelDesgnNameValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelEpochValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelEpochValue.AccessibleDescription);

		private void LabelEpochValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelMeanAnomalyValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMeanAnomalyValue.AccessibleDescription);

		private void LabelMeanAnomalyValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelArgPeriValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelArgPeriValue.AccessibleDescription);

		private void LabelArgPeriValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelLongAscNodeValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelLongAscNodeValue.AccessibleDescription);

		private void LabelLongAscNodeValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelInclValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelInclValue.AccessibleDescription);

		private void LabelInclValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelOrbEccValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelOrbEccValue.AccessibleDescription);

		private void LabelOrbEccValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelMotionValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMotionValue.AccessibleDescription);

		private void LabelMotionValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelSemiMajorAxisValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelSemiMajorAxisValue.AccessibleDescription);

		private void LabelSemiMajorAxisValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelMagAbsValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMagAbsValue.AccessibleDescription);

		private void LabelMagAbsValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelSlopeParamValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelSlopeParamValue.AccessibleDescription);

		private void LabelSlopeParamValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelRefValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelRefValue.AccessibleDescription);

		private void LabelRefValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelNumbOpposValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelNumbOpposValue.AccessibleDescription);

		private void LabelNumbOpposValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelNumbObsValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelNumbObsValue.AccessibleDescription);

		private void LabelNumbObsValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelObsSpanValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelObsSpanValue.AccessibleDescription);

		private void LabelObsSpanValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelRmsResidualValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelRmsResidualValue.AccessibleDescription);

		private void LabelRmsResidualValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelComputerNameValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelComputerNameValue.AccessibleDescription);

		private void LabelComputerNameValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelFlagsValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelFlagsValue.AccessibleDescription);

		private void LabelFlagsValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelObsLastDateValue_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelObsLastDateValue.AccessibleDescription);

		private void LabelObsLastDateValue_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemAbout_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemAbout.AccessibleDescription);

		private void MenuitemAbout_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripSeparatorMisc_Click(object sender, EventArgs e)
		{
			//Reserved for later: easter egg
		}

		private void ToolStripSeparatorMisc_MouseEnter(object sender, EventArgs e)
		{
			//Reserved for later: easter egg
		}

		private void ToolStripSeparatorMisc_MouseLeave(object sender, EventArgs e)
		{
			//Reserved for later: easter egg
		}

		private void LabelIndex_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelIndex.AccessibleDescription);

		private void LabelIndex_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelDesgnName_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelDesgnName.AccessibleDescription);

		private void LabelDesgnName_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelEpoch_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelEpoch.AccessibleDescription);

		private void LabelEpoch_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelMeanAnomaly_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMeanAnomaly.AccessibleDescription);

		private void LabelMeanAnomaly_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelArgPeri_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelArgPeri.AccessibleDescription);

		private void LabelArgPeri_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelLongAscNode_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelLongAscNode.AccessibleDescription);

		private void LabelLongAscNode_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelIncl_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelIncl.AccessibleDescription);

		private void LabelIncl_MouseMove(object sender, MouseEventArgs e) => ClearLabelHelp();

		private void LabelOrbEcc_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelOrbEcc.AccessibleDescription);

		private void LabelOrbEcc_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelMotion_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMotion.AccessibleDescription);

		private void LabelMotion_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelSemiMajorAxis_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelSemiMajorAxis.AccessibleDescription);

		private void LabelSemiMajorAxis_MouseMove(object sender, MouseEventArgs e) => ClearLabelHelp();

		private void LabelMagAbs_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelMagAbs.AccessibleDescription);

		private void LabelMagAbs_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelSlopeParam_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelSlopeParam.AccessibleDescription);

		private void LabelSlopeParam_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelRef_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelRef.AccessibleDescription);

		private void LabelRef_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelNumbOppos_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelNumbOppos.AccessibleDescription);

		private void LabelNumbOppos_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelNumbObs_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelNumbObs.AccessibleDescription);

		private void LabelNumbObs_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelObsSpan_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelObsSpan.AccessibleDescription);

		private void LabelObsSpan_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelRmsResidual_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelRmsResidual.AccessibleDescription);

		private void LabelRmsResidual_MouseMove(object sender, MouseEventArgs e) => ClearLabelHelp();

		private void LabelComputerName_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelComputerName.AccessibleDescription);

		private void LabelComputerName_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelFlags_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelFlags.AccessibleDescription);

		private void LabelFlags_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelObsLastDate_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelObsLastDate.AccessibleDescription);

		private void LabelObsLastDate_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelIndex_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelDesgnName_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelEpoch_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelMeanAnomaly_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelArgPeri_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelLongAscNode_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelIncl_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelOrbEcc_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelMotion_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelSemiMajorAxis_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelMagAbs_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelSlopeParam_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelRef_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelNumbOppos_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelNumbObs_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelObsSpan_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelRmsResidual_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelComputerName_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelFlags_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void LabelObsLastDate_Click(object sender, EventArgs e)
		{
			//Reserved für later: add a short message, what is; definition
		}

		private void ClearLabelHelp()
		{
			labelHelp.Text = "";
			labelHelp.Enabled = false;
		}

		private void SetLabelText(string text)
		{
			labelHelp.Text = text;
			labelHelp.Enabled = true;
		}

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

		private void TimerUpdateBlink_Tick(object sender, EventArgs e)
		{
			if (toolStripStatusLabelUpdate.ForeColor == System.Drawing.SystemColors.HotTrack) toolStripStatusLabelUpdate.ForeColor = System.Drawing.SystemColors.ControlText; else toolStripStatusLabelUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
		}

		private void ToolStripStatusLabelUpdate_Click(object sender, EventArgs e)
		{
			timerUpdateBlink.Enabled = false;
			if (MessageBox.Show("Do you want download the lastest MPCORB.DAT file?", "Download MPCORB.DAT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				toolStripStatusLabelBackgroundDownload.Enabled = true;
				toolStripProgressBarBackgroundDownload.Enabled = true;
				webClient.Proxy = null;
				webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
				webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
				try
				{
					webClient.DownloadFileAsync(uriMPCORB, @Planetoid_DB.Properties.Resources.strFilenameMPCORBtemp);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			toolStripStatusLabelUpdate.Enabled = false;
			toolStripStatusLabelUpdate.IsLink = false;
		}

		private void ToolStripStatusLabelUpdate_DoubleClick(object sender, EventArgs e)
		{
			timerUpdateBlink.Enabled = false;
			toolStripStatusLabelUpdate.Enabled = false;
		}

		private void ToolStripStatusLabelBackgroundDownload_DoubleClick(object sender, EventArgs e)
		{
			isDownloadCancelled = true;
			webClient.CancelAsync();
		}

		private void ToolStripProgressBarBackgroundDownload_DoubleClick(object sender, EventArgs e)
		{
			isDownloadCancelled = true;
			webClient.CancelAsync();
		}

		private void ToolStripStatusLabelUpdate_MouseEnter(object sender, EventArgs e)
		{
			if (timerUpdateBlink.Enabled) toolStripStatusLabelUpdate.IsLink = true;
			SetLabelText(text: toolStripStatusLabelUpdate.AccessibleDescription);
		}

		private void ToolStripStatusLabelUpdate_MouseLeave(object sender, EventArgs e)
		{
			if (timerUpdateBlink.Enabled) toolStripStatusLabelUpdate.IsLink = false;
			ClearLabelHelp();
		}

		private void ToolStripStatusLabelBackgroundDownload_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripStatusLabelBackgroundDownload.AccessibleDescription);

		private void ToolStripStatusLabelBackgroundDownload_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripProgressBarBackgroundDownload_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripProgressBarBackgroundDownload.AccessibleDescription);

		private void ToolStripProgressBarBackgroundDownload_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void LabelIndexPos_MouseEnter(object sender, EventArgs e) => SetLabelText(text: labelIndexPos.AccessibleDescription);

		private void LabelIndexPos_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e) => CheckMpcorbDat();

		private void ToolStripButtonCheckMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonCheckMpcorbDat.AccessibleDescription);

		private void ToolStripButtonCheckMpcorbDat_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonDownloadMpcorbDat_Click(object sender, EventArgs e) => ShowDownloader();

		private void ToolStripButtonDownloadMpcorbDat_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonDownloadMpcorbDat.AccessibleDescription);

		private void ToolStripButtonDownloadMpcorbDat_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonAbout_Click(object sender, EventArgs e) => ShowAppInfo();

		private void ToolStripButtonAbout_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonAbout.AccessibleDescription);

		private void ToolStripButtonAbout_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(fileName: Planetoid_DB.Properties.Resources.strHomepage);

		private void ToolStripButtonOpenWebsitePDB_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonOpenWebsitePDB.AccessibleDescription);

		private void ToolStripButtonOpenWebsitePDB_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void MenuitemEdit_MouseEnter(object sender, EventArgs e) => SetLabelText(text: menuitemEdit.AccessibleDescription);

		private void MenuitemEdit_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonTableMode_Click(object sender, EventArgs e) => OpenTableMode();

		private void ToolStripButtonTableMode_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonTableMode.AccessibleDescription);

		private void ToolStripMenuItemTableMode_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemTableMode_Click(object sender, EventArgs e) => OpenTableMode();

		private void ToolStripMenuItemTableMode_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemTableMode.AccessibleDescription);

		private void ToolStripButtonDatabaseInformation_Click(object sender, EventArgs e) => ShowDatabaseInformation();

		private void ToolStripButtonTableMode_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemStyle_MouseEnter(object sender, EventArgs e) => SetLabelText(text: ToolStripMenuItemStyle.AccessibleDescription);

		private void ToolStripMenuItemStyle_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemStyleOffice2007_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new Office2007Renderer();
      toolStripMenuItemStyleProfessional.Checked = false;
      toolStripMenuItemStyleOffice2007.Checked = true;
      toolStripMenuItemStyleSystem.Checked = false;
      toolStripMenuItemStyleVs2008.Checked = false;
    }

    private void ToolStripMenuItemStyleProfessionell_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new ToolStripProfessionalRenderer();
      toolStripMenuItemStyleProfessional.Checked = true;
      toolStripMenuItemStyleOffice2007.Checked = false;
      toolStripMenuItemStyleSystem.Checked = false;
      toolStripMenuItemStyleVs2008.Checked = false;
    }

    private void ToolStripMenuItemSystem_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new ToolStripSystemRenderer();
      toolStripMenuItemStyleProfessional.Checked = false;
      toolStripMenuItemStyleOffice2007.Checked = false;
      toolStripMenuItemStyleSystem.Checked = true;
      toolStripMenuItemStyleVs2008.Checked = false;
    }

    private void ToolStripMenuItemVs2008_Click(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new VS2008ToolStripRenderer();
      toolStripMenuItemStyleProfessional.Checked = false;
      toolStripMenuItemStyleOffice2007.Checked = false;
      toolStripMenuItemStyleSystem.Checked = false;
      toolStripMenuItemStyleVs2008.Checked = true;
    }

		private void ToolStripMenuItemStyleProfessionell_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemStyleProfessional.AccessibleDescription);

		private void ToolStripMenuItemStyleProfessionell_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemSystem_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemStyleSystem.AccessibleDescription);

		private void ToolStripMenuItemSystem_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemVs2008_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemStyleVs2008.AccessibleDescription);

		private void TimerUpdate_Tick(object sender, EventArgs e) => PlanetoidDBForm_Shown(sender, e);

		private void NotifyIconUpdate_Click(object sender, EventArgs e)
    {
      //contextMenuNotifyIcon.Show(notifyIconUpdate, 0, 100);
    }

    private void ToolStripButtonPrint_Click(object sender, EventArgs e)
    {
    }

		private void ToolStripButtonPrint_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonPrint.AccessibleDescription);

		private void ToolStripButtonPrint_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonCopyToClipboard_Click(object sender, EventArgs e)
    {
    }

		private void ToolStripButtonCopyToClipboard_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonCopyToClipboard.AccessibleDescription);

		private void ToolStripButtonCopyToClipboard_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonDatabaseInformation_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonDatabaseInformation.AccessibleDescription);

		private void ToolStripButtonDatabaseInformation_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemPrint_Click(object sender, EventArgs e)
    {
    }

		private void ToolStripMenuItemPrint_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemPrint.AccessibleDescription);

		private void ToolStripMenuItemPrint_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripTextBoxSearch_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripTextBoxSearch.AccessibleDescription);

		private void ToolStripTextBoxSearch_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripButtonSearch_Click(object sender, EventArgs e)
    {
    }

		private void ToolStripButtonSearch_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripButtonSearch.AccessibleDescription);

		private void ToolStripButtonSearch_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemCopytoClipboard_Click(object sender, EventArgs e)
    {
    }

		private void ToolStripMenuItemCopytoClipboard_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemCopytoClipboard.AccessibleDescription);

		private void ToolStripMenuItemCopytoClipboard_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemSearch_Click(object sender, EventArgs e)
    {
    }

		private void ToolStripMenuItemSearch_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemSearch.AccessibleDescription);

		private void ToolStripMenuItemSearch_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemDatabaseInformation_Click(object sender, EventArgs e) => ShowDatabaseInformation();

		private void ToolStripMenuItemDatabaseInformation_MouseEnter(object sender, EventArgs e) => SetLabelText(text: toolStripMenuItemDatabaseInformation.AccessibleDescription);

		private void ToolStripMenuItemVs2008_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

		private void ToolStripMenuItemDatabaseInformation_MouseLeave(object sender, EventArgs e) => ClearLabelHelp();

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

  }
}
