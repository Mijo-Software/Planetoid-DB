﻿using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using Krypton.Toolkit;

namespace Planetoid_DB
{

	/// <summary>
	/// 
	/// </summary>

	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]

	public partial class PlanetoidDBForm : KryptonForm
	{
		private int currentPosition = 0, stepPosition = 0;
		private readonly ArrayList planetoidDatabase = [];
		private readonly WebClient webClient = new();
		private readonly SplashScreenForm formSplashScreen = new();
		private readonly string filenameMpcorb = Properties.Resources.FilenameMpcorb;
		private readonly string filenameMpcorbTemp = Properties.Resources.FilenameMpcorbTemp;
		private readonly Uri uriMpcorb = new(uriString: Properties.Resources.MpcorbUrl);

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="PlanetoidDBForm"/> class.
		/// </summary>
		public PlanetoidDBForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(PlanetoidDBForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
			TextExtra = $"{Assembly.GetExecutingAssembly().GetName().Version}";
			SetStatusbar(text: string.Empty);
		}

		#endregion

		#region Local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Copies the specified text to the clipboard and displays a confirmation message.
		/// </summary>
		/// <param name="text">The text to be copied.</param>
		private static void CopyToClipboard(string text)
		{
			try
			{
				Clipboard.SetText(text: text);
				_ = MessageBox.Show(text: I10nStrings.CopiedToClipboard, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(text: $"{I10nStrings.CopiedToClipboard}{ex.Message}", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		[System.Runtime.InteropServices.DllImport(dllName: "wininet.dll")]
		private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

		/// <summary>
		/// Check if internet is aviable
		/// </summary>
		/// <returns>true if internet is aviable, otherwise false</returns>
		private static bool CheckNet() => InternetGetConnectedState(Description: out _, ReservedValue: 0);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="control"></param>
		private static void SetDoubleBuffered(Control control)
		{
			if (SystemInformation.TerminalServerSession)
			{
				return;
			}
#pragma warning disable CS8600 // Das NULL-Literal oder ein möglicher NULL-Wert wird in einen Non-Nullable-Typ konvertiert.
			PropertyInfo aProp = typeof(Control).GetProperty(name: "DoubleBuffered", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance);
#pragma warning restore CS8600 // Das NULL-Literal oder ein möglicher NULL-Wert wird in einen Non-Nullable-Typ konvertiert.
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
			aProp.SetValue(obj: control, value: true, index: null);
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
		}

		/// <summary>
		/// 
		/// </summary>
		private void Restart()
		{
			_ = Process.Start(fileName: Application.ExecutablePath);
			Close();
		}

		/// <summary>
		/// 
		/// </summary>
		private void AskForRestartAfterDownloadingDatabase()
		{
			if (MessageBox.Show(text: I10nStrings.DownloadCompleteAndRestartQuestionText, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Information, defaultButton: MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				Restart();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="currentPosition"></param>
		private void GotoCurrentPosition(int currentPosition)
		{
			//Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Leerstrings sind.
			// if (teilstring == "0") zahl = 0; ...
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
			labelIndexData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 0, length: 7).Trim();
			labelAbsoluteMagnitudeData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 8, length: 5).Trim();
			labelSlopeParameterData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 14, length: 5).Trim();
			labelEpochData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 20, length: 5).Trim();
			labelMeanAnomalyAtTheEpochData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 26, length: 9).Trim();
			labelArgumentOfPerihelionData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 37, length: 9).Trim();
			labelLongitudeOfTheAscendingNodeData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 48, length: 9).Trim();
			labelInclinationToTheEclipticData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 59, length: 9).Trim();
			labelOrbitalEccentricityData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 70, length: 9).Trim();
			labelMeanDailyMotionData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 80, length: 11).Trim();
			labelSemiMajorAxisData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 92, length: 11).Trim();
			labelReferenceData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 107, length: 9).Trim();
			labelNumberOfObservationsData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 117, length: 5).Trim();
			labelNumberOfOppositionsData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 123, length: 3).Trim();
			labelObservationSpanData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 127, length: 9).Trim();
			labelRmsResidualData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 137, length: 4).Trim();
			labelComputerNameData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 150, length: 10).Trim();
			labelFlagsData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 161, length: 4).Trim();
			labelReadableDesignationData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 166, length: 28).Trim();
			labelDateLastObservationData.Text = planetoidDatabase[index: currentPosition].ToString().Substring(startIndex: 194, length: 8).Trim();
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
			toolStripLabelIndexPosition.Text = $"{I10nStrings.Index}: {currentPosition + 1} / {planetoidDatabase.Count}";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		private static DateTime GetLastModified(Uri uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			return response.StatusCode == HttpStatusCode.OK ? response.LastModified : new DateTime(year: 0, month: 0, day: 0, hour: 0, minute: 0, second: 0);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>		
		private static long GetContentLength(Uri uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			return response.StatusCode == HttpStatusCode.OK ? Convert.ToInt64(value: response.ContentLength) : 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool IsMpcorbDatUpdateAvailable()
		{
			FileInfo fileInfo = new(fileName: filenameMpcorb);
			DateTime datetimeFileLocal = fileInfo.LastWriteTime;
			DateTime datetimeFileOnline = GetLastModified(uri: uriMpcorb);
			return datetimeFileOnline > datetimeFileLocal;
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadRandomMinorPlanet() => GotoCurrentPosition(currentPosition: currentPosition = new Random().Next(maxValue: planetoidDatabase.Count + 1));

		/// <summary>
		/// 
		/// </summary>
		private void NavigateToTheBeginOfTheData() => GotoCurrentPosition(currentPosition: currentPosition = 0);

		/// <summary>
		/// 
		/// </summary>
		private void NavigateSomeDataBackward()
		{
			currentPosition -= stepPosition;
			if (currentPosition < 1)
			{
				currentPosition += planetoidDatabase.Count;
			}
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		private void NavigateToThePreviousData()
		{
			if (currentPosition == 0)
			{
				currentPosition = planetoidDatabase.Count - 1;
			}
			else
			{
				currentPosition--;
			}
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		private void NavigateToTheNextData()
		{
			if (currentPosition == planetoidDatabase.Count - 1)
			{
				currentPosition = 0;
			}
			else
			{
				currentPosition++;
			}
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		private void NavigateSomeDataForward()
		{
			currentPosition += stepPosition;
			if (currentPosition > planetoidDatabase.Count)
			{
				currentPosition -= planetoidDatabase.Count;
			}
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// 
		/// </summary>
		private void NavigateToTheEndOfTheData() => GotoCurrentPosition(currentPosition: currentPosition = planetoidDatabase.Count - 1);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		private void OpenTerminology(uint index)
		{
			using TerminologyForm formTerminology = new();
			switch (index)
			{
				case 0: formTerminology.SetIndexNumberActive(); break;
				case 1: formTerminology.SetReadableDesignationActive(); break;
				case 2: formTerminology.SetEpochActive(); break;
				case 3: formTerminology.SetMeanAnomalyAtTheEpochActive(); break;
				case 4: formTerminology.SetArgumentOfPerihelionActive(); break;
				case 5: formTerminology.SetLongitudeOfTheAscendingNodeActive(); break;
				case 6: formTerminology.SetInclinationToTheEclipticActive(); break;
				case 7: formTerminology.SetOrbitalEccentricityActive(); break;
				case 8: formTerminology.SetMeanDailyMotionActive(); break;
				case 9: formTerminology.SetSemiMajorAxisActive(); break;
				case 10: formTerminology.SetAbsoluteMagnitudeActive(); break;
				case 11: formTerminology.SetSlopeParamActive(); break;
				case 12: formTerminology.SetReferenceActive(); break;
				case 13: formTerminology.SetNumberOfOppositionsActive(); break;
				case 14: formTerminology.SetNumberOfObservationsActive(); break;
				case 15: formTerminology.SetObservationSpanActive(); break;
				case 16: formTerminology.SetRmsResidualActive(); break;
				case 17: formTerminology.SetComputerNameActive(); break;
				case 18: formTerminology.SetFlagsActive(); break;
				case 19: formTerminology.SetDateOfTheLastObservationActive(); break;
				case 20: formTerminology.SetLinearEccentricityActive(); break;
				case 21: formTerminology.SetSemiMinorAxisActive(); break;
				case 22: formTerminology.SetMajorAxisActive(); break;
				case 23: formTerminology.SetMinorAxisActive(); break;
				case 24: formTerminology.SetEccenctricAnomalyActive(); break;
				case 25: formTerminology.SetTrueAnomalyActive(); break;
				case 26: formTerminology.SetPerihelionDistanceActive(); break;
				case 27: formTerminology.SetAphelionDistanceActive(); break;
				case 28: formTerminology.SetLongitudeOfTheDescendingNodeActive(); break;
				case 29: formTerminology.SetArgumentOfTheAphelionActive(); break;
				case 30: formTerminology.SetFocalParameterActive(); break;
				case 31: formTerminology.SetSemiLatusRectumActive(); break;
				case 32: formTerminology.SetLatusRectumActive(); break;
				case 33: formTerminology.SetOrbitalPeriodActive(); break;
				case 34: formTerminology.SetOrbitalAreaActive(); break;
				case 35: formTerminology.SetOrbitalPerimeterActive(); break;
				case 36: formTerminology.SetSemiMeanAxisActive(); break;
				case 37: formTerminology.SetMeanAxisActive(); break;
				case 38: formTerminology.SetStandardGravitationalParameterActive(); break;
				default: formTerminology.SetIndexNumberActive(); break;
			}
			formTerminology.TopMost = TopMost;
			_ = formTerminology.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void OpenTableMode()
		{
			using TableModeForm formTableMode = new();
			formTableMode.TopMost = TopMost;
			formTableMode.FillArray(arrTemp: planetoidDatabase);
			_ = formTableMode.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowAppInfo()
		{
			using AppInfoForm formAppInfo = new();
			formAppInfo.TopMost = TopMost;
			_ = formAppInfo.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowRecordsSelection()
		{
			using RecordsSelectionForm formRecordsSelection = new();
			formRecordsSelection.TopMost = TopMost;
			_ = formRecordsSelection.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowRecordsMain()
		{
			using RecordsMainForm formRecordsMain = new();
			formRecordsMain.TopMost = TopMost;
			_ = formRecordsMain.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowMpcorbDatCheck()
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				_ = MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				using CheckMpcorbDatForm formCeckMpcorbDat = new();
				formCeckMpcorbDat.TopMost = TopMost;
				_ = formCeckMpcorbDat.ShowDialog();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowDownloader()
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				_ = MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				using DownloadUpdateForm formDownloaderForMpcorbDat = new();
				formDownloaderForMpcorbDat.TopMost = TopMost;
				if (formDownloaderForMpcorbDat.ShowDialog() == DialogResult.OK)
				{
					AskForRestartAfterDownloadingDatabase();
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowDatabaseInformation()
		{
			using DatabaseInformationForm formDatabaseInformation = new();
			formDatabaseInformation.TopMost = TopMost;
			_ = formDatabaseInformation.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowCopyDataToClipboard()
		{
			ArrayList dataToCopy = new(capacity: 0)
									{
										labelIndexData.Text,
										labelReadableDesignationData.Text,
										labelEpochData.Text,
										labelMeanAnomalyAtTheEpochData.Text,
										labelArgumentOfPerihelionData.Text,
										labelLongitudeOfTheAscendingNodeData.Text,
										labelInclinationToTheEclipticData.Text,
										labelOrbitalEccentricityData.Text,
										labelMeanDailyMotionData.Text,
										labelSemiMajorAxisData.Text,
										labelAbsoluteMagnitudeData.Text,
										labelSlopeParameterData.Text,
										labelReferenceData.Text,
										labelNumberOfOppositionsData.Text,
										labelNumberOfObservationsData.Text,
										labelObservationSpanData.Text,
										labelRmsResidualData.Text,
										labelComputerNameData.Text,
										labelFlagsData.Text,
										labelDateLastObservationData.Text
									};

			List<string> dataToCopyList = new();
			foreach (object? item in dataToCopy)
			{
				dataToCopyList.Add(item.ToString());
			}

			using CopyDataToClipboardForm formCopyDataToClipboard = new();
			formCopyDataToClipboard.TopMost = TopMost;
			formCopyDataToClipboard.SetDatabase(list: dataToCopyList);
			_ = formCopyDataToClipboard.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowSearch()
		{
			using SearchForm formSearch = new();
			formSearch.TopMost = TopMost;
			formSearch.FillArray(arrTemp: planetoidDatabase);
			formSearch.SetMaxIndex(maxIndex: planetoidDatabase.Count);
			_ = formSearch.ShowDialog();

			_ = MessageBox.Show(formSearch.GetSelectedIndex().ToString());

			if (formSearch.DialogResult == DialogResult.OK && formSearch.GetSelectedIndex() > 0)
			{
				GotoCurrentPosition(currentPosition: formSearch.GetSelectedIndex());
			}

		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowFilter()
		{
			using FilterForm formFilter = new();
			formFilter.TopMost = TopMost;
			_ = formFilter.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowSettings()
		{
			using SettingsForm formSettings = new();
			formSettings.TopMost = TopMost;
			_ = formSettings.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void OpenDatabaseDifferences()
		{
			using DatabaseDifferencesForm formDatabaseDifferences = new();
			formDatabaseDifferences.TopMost = TopMost;
			_ = formDatabaseDifferences.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ListReadableDesignations()
		{
			using ListReadableDesignationsForm formListReadableDesignations = new();
			formListReadableDesignations.TopMost = TopMost;
			formListReadableDesignations.FillArray(arrTemp: planetoidDatabase);
			formListReadableDesignations.SetMaxIndex(maxIndex: planetoidDatabase.Count);
			_ = formListReadableDesignations.ShowDialog();
			if (formListReadableDesignations.DialogResult == DialogResult.OK && formListReadableDesignations.GetSelectedIndex() > 0)
			{
				GotoCurrentPosition(currentPosition: formListReadableDesignations.GetSelectedIndex());
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void ExportDataSheet()
		{
			ArrayList orbitalElements = new(capacity: 0);
			IFormatProvider provider = CultureInfo.CreateSpecificCulture(name: "en");
			double semiMajorAxis = double.Parse(s: labelSemiMajorAxisData.Text, provider: provider);
			double numericalEccentricity = double.Parse(s: labelOrbitalEccentricityData.Text, provider: provider);
			double meanAnomaly = double.Parse(s: labelMeanAnomalyAtTheEpochData.Text, provider: provider);
			double longitudeAscendingNode = double.Parse(s: labelLongitudeOfTheAscendingNodeData.Text, provider: provider);
			double argumentAphelion = double.Parse(s: labelArgumentOfPerihelionData.Text, provider: provider);
			_ = orbitalElements.Add(value: labelIndexData.Text);
			_ = orbitalElements.Add(value: labelReadableDesignationData.Text);
			_ = orbitalElements.Add(value: labelEpochData.Text);
			_ = orbitalElements.Add(value: labelMeanAnomalyAtTheEpochData.Text);
			_ = orbitalElements.Add(value: labelArgumentOfPerihelionData.Text);
			_ = orbitalElements.Add(value: labelLongitudeOfTheAscendingNodeData.Text);
			_ = orbitalElements.Add(value: labelInclinationToTheEclipticData.Text);
			_ = orbitalElements.Add(value: labelOrbitalEccentricityData.Text);
			_ = orbitalElements.Add(value: labelMeanDailyMotionData.Text);
			_ = orbitalElements.Add(value: labelSemiMajorAxisData.Text);
			_ = orbitalElements.Add(value: labelAbsoluteMagnitudeData.Text);
			_ = orbitalElements.Add(value: labelSlopeParameterData.Text);
			_ = orbitalElements.Add(value: labelReferenceData.Text);
			_ = orbitalElements.Add(value: labelNumberOfOppositionsData.Text);
			_ = orbitalElements.Add(value: labelNumberOfObservationsData.Text);
			_ = orbitalElements.Add(value: labelObservationSpanData.Text);
			_ = orbitalElements.Add(value: labelRmsResidualData.Text);
			_ = orbitalElements.Add(value: labelComputerNameData.Text);
			_ = orbitalElements.Add(value: labelFlagsData.Text);
			_ = orbitalElements.Add(value: labelDateLastObservationData.Text);
			_ = orbitalElements.Add(value: CalculateLinearEccentricity(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateMajorAxis(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateEccentricAnomaly(meanAnomaly: meanAnomaly, numericalEccentricity: numericalEccentricity, numberDecimalPlaces: 8).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateTrueAnomaly(meanAnomaly: meanAnomaly, numericalEccentricity: numericalEccentricity, numberDecimalPlaces: 8).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculatePerihelionDistance(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateAphelionDistance(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateLongitudeDescendingNode(longitudeAscendingNode: longitudeAscendingNode).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateArgumenOfAphelion(argumentAphelion: argumentAphelion).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateFocalParameter(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateSemiLatusRectum(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateLatusRectum(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculatePeriod(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateOrbitalArea(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateOrbitalPerimeter(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateSemiMeanAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateMeanAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = orbitalElements.Add(value: CalculateStandardGravitationalParameter(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			using ExportDataSheetForm formExportDataSheet = new();
			formExportDataSheet.TopMost = TopMost;
			formExportDataSheet.SetDatabase(list: orbitalElements.Cast<string>().ToList());
			_ = formExportDataSheet.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void PrintDataSheet()
		{
			using PrintDataSheetForm formPrintDataSheet = new();
			formPrintDataSheet.TopMost = TopMost;
			_ = formPrintDataSheet.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		private void ShowDerivatedOrbitElements()
		{
			ArrayList derivatedOrbitElements = new(capacity: 0);
			IFormatProvider provider = CultureInfo.CreateSpecificCulture(name: "en");
			double semiMajorAxis = double.Parse(s: labelSemiMajorAxisData.Text, provider: provider);
			double numericalEccentricity = double.Parse(s: labelOrbitalEccentricityData.Text, provider: provider);
			double meanAnomaly = double.Parse(s: labelMeanAnomalyAtTheEpochData.Text, provider: provider);
			double longitudeAscendingNode = double.Parse(s: labelLongitudeOfTheAscendingNodeData.Text, provider: provider);
			double argumentAphelion = double.Parse(s: labelArgumentOfPerihelionData.Text, provider: provider);
			_ = derivatedOrbitElements.Add(value: CalculateLinearEccentricity(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateMajorAxis(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateEccentricAnomaly(meanAnomaly: meanAnomaly, numericalEccentricity: numericalEccentricity, numberDecimalPlaces: 8).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateTrueAnomaly(meanAnomaly: meanAnomaly, numericalEccentricity: numericalEccentricity, numberDecimalPlaces: 8).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculatePerihelionDistance(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateAphelionDistance(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateLongitudeDescendingNode(longitudeAscendingNode: longitudeAscendingNode).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateArgumenOfAphelion(argumentAphelion: argumentAphelion).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateFocalParameter(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateSemiLatusRectum(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateLatusRectum(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculatePeriod(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateOrbitalArea(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateOrbitalPerimeter(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateSemiMeanAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateMeanAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivatedOrbitElements.Add(value: CalculateStandardGravitationalParameter(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			using DerivatedOrbitElementsForm formDerivatedOrbitElements = new();
			formDerivatedOrbitElements.TopMost = TopMost;
			formDerivatedOrbitElements.SetDatabase(list: [.. derivatedOrbitElements.Cast<object>()]);
			_ = formDerivatedOrbitElements.ShowDialog();
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">Der anzuzeigende Text.</param>
		/// <param name="additionalInfo">Additional information to be displayed.</param>
		private void SetStatusbar(string text, string additionalInfo = "")
		{
			if (!string.IsNullOrEmpty(value: text))
			{
				labelInformation.Enabled = true;
				labelInformation.Text = string.IsNullOrEmpty(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
			}
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusbar()
		{
			labelInformation.Enabled = false;
			labelInformation.Text = string.Empty;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateSemiMinorAxis(double semiMajorAxis, double numericalEccentricity) => semiMajorAxis * Math.Sqrt(d: 1 - Math.Pow(x: numericalEccentricity, y: 2));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateLinearEccentricity(double semiMajorAxis, double numericalEccentricity)
		{
			switch (numericalEccentricity)
			{
				case 0:
					return 0;
				case < 1 and > 0:
					return Math.Sqrt(d: Math.Pow(x: semiMajorAxis, y: 2) - Math.Pow(x: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity), y: 2));
				case > 1:
					return Math.Sqrt(d: Math.Pow(x: semiMajorAxis, y: 2) + Math.Pow(x: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity), y: 2));
				default:
					break;
			}
			return 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <returns></returns>
		private static double CalculateMajorAxis(double semiMajorAxis) => 2 * semiMajorAxis;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateMinorAxis(double semiMajorAxis, double numericalEccentricity) => 2 * CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="meanAnomaly"></param>
		/// <param name="numericalEccentricity"></param>
		/// <param name="numberDecimalPlaces"></param>
		/// <returns></returns>
		private static double CalculateEccentricAnomaly(double meanAnomaly, double numericalEccentricity, double numberDecimalPlaces)
		{
			double K = Math.PI / 180.0;
			int maxIteration = 30, i = 0;
			double delta = Math.Pow(x: 10, y: -numberDecimalPlaces);
			double E, F;
			meanAnomaly /= 360.0;
			meanAnomaly = 2.0 * Math.PI * (meanAnomaly - Math.Floor(d: meanAnomaly));
			E = numericalEccentricity < 0.8 ? meanAnomaly : Math.PI;
			F = E - (numericalEccentricity * Math.Sin(a: meanAnomaly)) - meanAnomaly;
			while ((Math.Abs(value: F) > delta) && (i < maxIteration))
			{
				E -= F / (1.0 - (numericalEccentricity * Math.Cos(d: E)));
				F = E - (numericalEccentricity * Math.Sin(a: E)) - meanAnomaly;
				i += 1;
			}
			E /= K;
			return Math.Round(a: E * Math.Pow(x: 10, y: numberDecimalPlaces)) / Math.Pow(x: 10, y: numberDecimalPlaces);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="meanAnomaly"></param>
		/// <param name="numericalEccentricity"></param>
		/// <param name="numberDecimalPlaces"></param>
		/// <returns></returns>
		private static double CalculateTrueAnomaly(double meanAnomaly, double numericalEccentricity, double numberDecimalPlaces)
		{
			double E = CalculateEccentricAnomaly(meanAnomaly: meanAnomaly, numericalEccentricity: numericalEccentricity, numberDecimalPlaces: numberDecimalPlaces);
			double K = Math.PI / 180.0;
			double S = Math.Sin(a: E);
			double C = Math.Cos(d: E);
			double fak = Math.Sqrt(d: 1.0 - (numericalEccentricity * numericalEccentricity));
			double phi = Math.Atan2(y: fak * S, x: C - numericalEccentricity) / K;
			return Math.Round(a: phi * Math.Pow(x: 10, y: numberDecimalPlaces)) / Math.Pow(x: 10, y: numberDecimalPlaces);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculatePerihelionDistance(double semiMajorAxis, double numericalEccentricity) => (1 - numericalEccentricity) * semiMajorAxis;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateAphelionDistance(double semiMajorAxis, double numericalEccentricity) => (1 + numericalEccentricity) * semiMajorAxis;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="longitudeAscendingNode"></param>
		/// <returns></returns>
		private static double CalculateLongitudeDescendingNode(double longitudeAscendingNode)
		{
			if (longitudeAscendingNode is >= 0 and < 180)
			{
				return longitudeAscendingNode + 180;
			}
			else if (longitudeAscendingNode is >= 180 and < 360)
			{
				return longitudeAscendingNode - 180;
			}
			return -1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argumentAphelion"></param>
		/// <returns></returns>
		private static double CalculateArgumenOfAphelion(double argumentAphelion)
		{
			if (argumentAphelion is >= 0 and < 180)
			{
				return argumentAphelion + 180;
			}
			else if (argumentAphelion is >= 180 and < 360)
			{
				return argumentAphelion - 180;
			}
			return -1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateFocalParameter(double semiMajorAxis, double numericalEccentricity)
		{
			if (numericalEccentricity > 1)
			{
				return Math.Pow(x: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity), y: 2) / Math.Sqrt(d: Math.Pow(x: semiMajorAxis, y: 2) + Math.Pow(x: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity), y: 2));
			}
			else if (numericalEccentricity is > 0 and < 1)
			{
				return Math.Pow(x: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity), y: 2) / Math.Sqrt(d: Math.Pow(x: semiMajorAxis, y: 2) - Math.Pow(x: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity), y: 2));
			}
			return 2 * semiMajorAxis;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateSemiLatusRectum(double semiMajorAxis, double numericalEccentricity) => semiMajorAxis * (1 - Math.Pow(x: numericalEccentricity, y: 2));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateLatusRectum(double semiMajorAxis, double numericalEccentricity) => 2 * CalculateSemiLatusRectum(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <returns></returns>
		private static double CalculatePeriod(double semiMajorAxis) => Math.Sqrt(d: Math.Pow(x: semiMajorAxis, y: 3));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateOrbitalArea(double semiMajorAxis, double numericalEccentricity) => semiMajorAxis + CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity) + ((3 * Math.Pow(x: semiMajorAxis - CalculateSemiMinorAxis(semiMajorAxis, numericalEccentricity), y: 2) / 10 * (semiMajorAxis + CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity))) + Math.Sqrt(d: Math.Pow(x: semiMajorAxis, y: 2) + (14 * semiMajorAxis * CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity)) + Math.Pow(x: CalculateSemiMinorAxis(semiMajorAxis, numericalEccentricity), y: 2)));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateOrbitalPerimeter(double semiMajorAxis, double numericalEccentricity) => semiMajorAxis * CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity) * Math.PI;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateSemiMeanAxis(double semiMajorAxis, double numericalEccentricity) => (semiMajorAxis + CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity)) / 2;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <param name="numericalEccentricity"></param>
		/// <returns></returns>
		private static double CalculateMeanAxis(double semiMajorAxis, double numericalEccentricity) => 2 * CalculateSemiMeanAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semiMajorAxis"></param>
		/// <returns></returns>
		private static double CalculateStandardGravitationalParameter(double semiMajorAxis) => 4 * Math.Pow(x: Math.PI, y: 2) * Math.Pow(x: semiMajorAxis, y: 3) / CalculatePeriod(semiMajorAxis: semiMajorAxis);

		/// <summary>
		/// 
		/// </summary>
		private void CheckStayOnTop() => TopMost = menuitemOptionStayOnTop.Checked;

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlanetoidDBForm_Load(object sender, EventArgs e)
		{
			SetDoubleBuffered(control: tableLayoutPanelData);
			backgroundWorkerLoadingDatabase.WorkerReportsProgress = true;
			backgroundWorkerLoadingDatabase.WorkerSupportsCancellation = true;
#pragma warning disable CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
			backgroundWorkerLoadingDatabase.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorkerLoadingDatabase_ProgressChanged);
			backgroundWorkerLoadingDatabase.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerLoadingDatabase_RunWorkerCompleted);
#pragma warning restore CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
			backgroundWorkerLoadingDatabase.RunWorkerAsync();
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
			toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
			toolStripStatusLabelBackgroundDownload.Visible = false;
			toolStripProgressBarBackgroundDownload.Visible = false;
			toolStripStatusLabelCancelBackgroundDownload.Visible = false;
			if (IsMpcorbDatUpdateAvailable())
			{
				timerBlinkForUpdateAvailable.Enabled = true;
				toolStripStatusLabelUpdate.Enabled = true;
			}
			else
			{
				timerBlinkForUpdateAvailable.Enabled = false;
				toolStripStatusLabelUpdate.Enabled = false;
				toolStripStatusLabelUpdate.Visible = false;
			}
			CheckStayOnTop();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlanetoidDBForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (File.Exists(path: filenameMpcorbTemp))
			{
				File.Delete(path: filenameMpcorbTemp);
			}
		}

		#endregion

		#region BackgroundWorker for database loading on start up

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorkerLoadingDatabase_DoWork(object sender, DoWorkEventArgs e)
		{
			Enabled = false;
			int lineNum = 0;
			float percent;
			string readLine;
			FileInfo fileInfo = new(fileName: filenameMpcorb);
			long fileSize = fileInfo.Length, fileSizeReaded = 0;
			using (FileStream fileStream = new(path: filenameMpcorb, mode: FileMode.Open))
			{
				StreamReader streamReader = new(stream: fileStream);
				formSplashScreen.Show();
				while (streamReader.Peek() != -1 && !backgroundWorkerLoadingDatabase.CancellationPending)
				{
#pragma warning disable CS8600 // Das NULL-Literal oder ein möglicher NULL-Wert wird in einen Non-Nullable-Typ konvertiert.
					readLine = streamReader.ReadLine();
#pragma warning restore CS8600 // Das NULL-Literal oder ein möglicher NULL-Wert wird in einen Non-Nullable-Typ konvertiert.
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
					fileSizeReaded += readLine.Length;
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
					percent = 100 * fileSizeReaded / fileSize;
					formSplashScreen.SetProgressbar(value: (int)percent);
					lineNum++;
					if ((lineNum >= 44) && (!string.IsNullOrEmpty(value: readLine)))
					{
						_ = planetoidDatabase.Add(value: readLine);
					}
				}
				fileStream.Close();
				streamReader.Close();
			}
			formSplashScreen.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void BackgroundWorkerLoadingDatabase_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundWorkerLoadingDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			toolStripTextBoxGotoIndex.Text = 1.ToString();
			currentPosition = 0;
			stepPosition = 100;
			GotoCurrentPosition(currentPosition: currentPosition);
			Enabled = true;
		}

		#endregion

		#region Download and update database

		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			toolStripProgressBarBackgroundDownload.Value = e.ProgressPercentage;
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
		}

		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				File.Delete(path: filenameMpcorb);
				File.Copy(sourceFileName: filenameMpcorbTemp, destFileName: Properties.Resources.FilenameMpcorb);
				File.Delete(path: filenameMpcorbTemp);
				AskForRestartAfterDownloadingDatabase();
			}
			else
			{
				_ = e.Cancelled
					? MessageBox.Show(text: I10nStrings.DownloadCancelledText, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning)
					: MessageBox.Show(text: I10nStrings.DownloadUnknownError + "\n\r" + e.Error, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				File.Delete(path: filenameMpcorbTemp);
			}
			webClient.Dispose();
			toolStripStatusLabelBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Enabled = false;
			toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
			toolStripStatusLabelBackgroundDownload.Visible = false;
			toolStripProgressBarBackgroundDownload.Visible = false;
			toolStripStatusLabelCancelBackgroundDownload.Visible = false;
			toolStripStatusLabelUpdate.IsLink = false;
			toolStripStatusLabelUpdate.Enabled = false;
			toolStripStatusLabelUpdate.Visible = false;
			timerBlinkForUpdateAvailable.Enabled = false;
			toolStripProgressBarBackgroundDownload.Value = toolStripProgressBarBackgroundDownload.Minimum;
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
		}

		#endregion

		#region Timer

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TimerCheckForNewMpcorbDatFile_Tick(object sender, EventArgs e) => PlanetoidDBForm_Shown(sender: sender, e: e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TimerBlinkForUpdateAvailable_Tick(object sender, EventArgs e) => toolStripStatusLabelUpdate.ForeColor = toolStripStatusLabelUpdate.ForeColor == SystemColors.HotTrack ? SystemColors.ControlText : SystemColors.HotTrack;

		#endregion

		#region Clear-Handler

		/// <summary>
		/// 
		/// </summary>
		private void ToolStripMenuItem_Clear()
		{
			menuitemNavigateStep10.Checked = false;
			menuitemNavigateStep100.Checked = false;
			menuitemNavigateStep1000.Checked = false;
			menuitemNavigateStep10000.Checked = false;
			menuitemNavigateStep100000.Checked = false;
		}

		#endregion

		#region KeyPress-Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripTextBoxGotoIndex_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(c: e.KeyChar) && !char.IsDigit(c: e.KeyChar))
			{
				e.Handled = true;
			}
			if (e.KeyChar == Convert.ToChar(value: Keys.Return, provider: CultureInfo.CurrentCulture))
			{
				ToolStripButtonGoToIndex_Click(sender: null, e: null);
			}
		}

		#endregion

		#region Enter-Handler

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control control && control.AccessibleDescription != null)
			{
				SetStatusbar(text: control.AccessibleDescription);
			}
		}

		#endregion

		#region Leave-Handler

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click & ButtonClick Event Handler

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonStepToBegin_Click(object sender, EventArgs e) => NavigateToTheBeginOfTheData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonStepBackward_Click(object sender, EventArgs e) => NavigateSomeDataBackward();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonStepBackwardOne_Click(object sender, EventArgs e) => NavigateToThePreviousData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonStepForwardOne_Click(object sender, EventArgs e) => NavigateToTheNextData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonStepForward_Click(object sender, EventArgs e) => NavigateSomeDataForward();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonStepToEnd_Click(object sender, EventArgs e) => NavigateToTheEndOfTheData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonGoToIndex_Click(object? sender, EventArgs? e)
		{
			int pos = 0;
			try
			{
				pos = int.Parse(s: toolStripTextBoxGotoIndex.Text, provider: CultureInfo.CurrentCulture);
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(text: ex.Message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			if (pos <= 0 || pos >= planetoidDatabase.Count + 1)
			{
				_ = MessageBox.Show(text: I10nStrings.IndexOutOfRange, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				currentPosition = pos - 1;
				GotoCurrentPosition(currentPosition: currentPosition);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemTerminology_Click(object sender, EventArgs e) => OpenTerminology(index: 0);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonTerminology_Click(object sender, EventArgs e) => OpenTerminology(index: 0);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelCancelBackgroundDownload_Click(object sender, EventArgs e)
		{
			toolStripStatusLabelBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Enabled = false;
			toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
			toolStripStatusLabelBackgroundDownload.Visible = false;
			toolStripProgressBarBackgroundDownload.Visible = false;
			toolStripStatusLabelCancelBackgroundDownload.Visible = false;
			webClient.CancelAsync();
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
			menuitemNavigateStep10.Checked = true;
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
			menuitemNavigateStep100.Checked = true;
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
			menuitemNavigateStep1000.Checked = true;
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
			menuitemNavigateStep10000.Checked = true;
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
			menuitemNavigateStep100000.Checked = true;
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
		private void MenuitemAbout_Click(object sender, EventArgs e) => ShowAppInfo();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsitePDB_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.Homepage);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenWebsiteMPC_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.WebsiteMpc);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenMPCORBWebsite_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.WebsiteMpcorb);

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
		private void MenuitemCheckMpcorbDat_Click(object sender, EventArgs e) => ShowMpcorbDatCheck();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripStatusLabelUpdate_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(text: I10nStrings.AskForDownloadingLatestMpcorbDatFile, caption: I10nStrings.AskForDownloadingLatestMpcorbDatFileCaption, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question) == DialogResult.Yes)
			{
				toolStripStatusLabelUpdate.IsLink = false;
				toolStripStatusLabelUpdate.Enabled = false;
				toolStripStatusLabelUpdate.Visible = false;
				timerBlinkForUpdateAvailable.Enabled = false;
				toolStripStatusLabelBackgroundDownload.Visible = true;
				toolStripProgressBarBackgroundDownload.Visible = true;
				toolStripStatusLabelCancelBackgroundDownload.Visible = true;
				toolStripStatusLabelBackgroundDownload.Enabled = true;
				toolStripProgressBarBackgroundDownload.Enabled = true;
				toolStripStatusLabelCancelBackgroundDownload.Enabled = true;
				webClient.Proxy = WebRequest.DefaultWebProxy;
#pragma warning disable CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
				webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
#pragma warning restore CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
				webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
				try
				{
					webClient.DownloadFileAsync(address: uriMpcorb, fileName: Properties.Resources.FilenameMpcorbTemp);
				}
				catch (Exception ex)
				{
					_ = MessageBox.Show(text: ex.Message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error, defaultButton: MessageBoxDefaultButton.Button1);
					toolStripStatusLabelUpdate.IsLink = true;
					toolStripStatusLabelUpdate.Enabled = true;
					toolStripStatusLabelUpdate.Visible = true;
					timerBlinkForUpdateAvailable.Enabled = true;
					toolStripStatusLabelBackgroundDownload.Visible = false;
					toolStripProgressBarBackgroundDownload.Visible = false;
					toolStripStatusLabelCancelBackgroundDownload.Visible = false;
					toolStripStatusLabelBackgroundDownload.Enabled = false;
					toolStripProgressBarBackgroundDownload.Enabled = false;
					toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e) => ShowMpcorbDatCheck();

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
		private void ToolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.Homepage);

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
		private void ToolStripButtonPrint_Click(object sender, EventArgs e) => PrintDataSheet();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonCopyToClipboard_Click(object sender, EventArgs e) => ShowCopyDataToClipboard();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemPrint_Click(object sender, EventArgs e) => PrintDataSheet();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSearch_Click(object sender, EventArgs e) => ShowSearch();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemDatabaseInformation_Click(object sender, EventArgs e) => ShowDatabaseInformation();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonLoadRandomMinorPlanet_Click(object sender, EventArgs e) => LoadRandomMinorPlanet();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemRandomMinorPlanet_Click(object sender, EventArgs e) => LoadRandomMinorPlanet();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemNavigateToTheBegin_Click(object sender, EventArgs e) => NavigateToTheBeginOfTheData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemNavigateSomeDataBackward_Click(object sender, EventArgs e) => NavigateSomeDataBackward();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemNavigateToThePreviousData_Click(object sender, EventArgs e) => NavigateToThePreviousData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemNavigateToTheNextData_Click(object sender, EventArgs e) => NavigateToTheNextData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemNavigateSomeDataForward_Click(object sender, EventArgs e) => NavigateSomeDataForward();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemNavigateToTheEnd_Click(object sender, EventArgs e) => NavigateToTheEndOfTheData();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSettings_Click(object sender, EventArgs e) => ShowSettings();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemFilter_Click(object sender, EventArgs e) => ShowFilter();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonFilter_Click(object sender, EventArgs e) => ShowFilter();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonDerivatedOrbitElements_Click(object sender, EventArgs e) => ShowDerivatedOrbitElements();


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemRestart_Click(object sender, EventArgs e) => Restart();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemRestartWithDemoData_Click(object sender, EventArgs e)
		{
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemDerivatedOrbitElements_Click(object sender, EventArgs e) => ShowDerivatedOrbitElements();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemStayOnTop_Click(object sender, EventArgs e) => CheckStayOnTop();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void ToolStripMenuItemEnableCopyingByDoubleClicking_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void ToolStripMenuItemEnableLinkingToTerminology_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void ToolStripMenuItemIconsetSilk_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void ToolStripMenuItemIconsetFugue_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void ToolStripMenuItemIconsetFatcow_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardIndexNumber_Click(object sender, EventArgs e) => CopyToClipboard(text: labelIndexData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardReadableDesignation_Click(object sender, EventArgs e) => CopyToClipboard(text: labelReadableDesignationData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardEpoch_Click(object sender, EventArgs e) => CopyToClipboard(text: labelEpochData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardMeanAnomaly_Click(object sender, EventArgs e) => CopyToClipboard(text: labelMeanAnomalyAtTheEpochData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click(object sender, EventArgs e) => CopyToClipboard(text: labelArgumentOfPerihelionData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => CopyToClipboard(text: labelLongitudeOfTheAscendingNodeData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardInclinationToTheEcliptic_Click(object sender, EventArgs e) => CopyToClipboard(text: labelInclinationToTheEclipticData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click(object sender, EventArgs e) => CopyToClipboard(text: labelOrbitalEccentricityData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click(object sender, EventArgs e) => CopyToClipboard(text: labelMeanDailyMotionData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardSemiMajorAxis_Click(object sender, EventArgs e) => CopyToClipboard(text: labelSemiMajorAxisData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click(object sender, EventArgs e) => CopyToClipboard(text: labelAbsoluteMagnitudeData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardSlopeParameter_Click(object sender, EventArgs e) => CopyToClipboard(text: labelSlopeParameterData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardReference_Click(object sender, EventArgs e) => CopyToClipboard(text: labelReferenceData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click(object sender, EventArgs e) => CopyToClipboard(text: labelNumberOfOppositionsData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardNumberOfObservations_Click(object sender, EventArgs e) => CopyToClipboard(text: labelNumberOfObservationsData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardObservationSpan_Click(object sender, EventArgs e) => CopyToClipboard(text: labelObservationSpanData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardRmsResidual_Click(object sender, EventArgs e) => CopyToClipboard(text: labelRmsResidualData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardComputerName_Click(object sender, EventArgs e) => CopyToClipboard(text: labelComputerNameData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click(object sender, EventArgs e) => CopyToClipboard(text: labelDateLastObservationData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemCopyToClipboardFlags_Click(object sender, EventArgs e) => CopyToClipboard(text: labelFlagsData.Text);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripSplitButtonExport_Click(object sender, EventArgs e) => ExportDataSheet();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemTopTenRecords_Click(object sender, EventArgs e) => ShowRecordsSelection();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SplitbuttonTopTenRecords_ButtonClick(object sender, EventArgs e) => ShowRecordsSelection();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsMeanAnomalyAtTheEpoch_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsArgumentOfPerihelion_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsLongitudeOfTheAscendingNode_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsInclination_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsOrbitalEccentricity_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsMeanDailyMotion_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsSemiMajorAxis_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsAbsoluteMagnitude_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsSlopeParameter_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsNumberOfOppositions_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsNumberOfObservations_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsObservationSpan_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsRmsResidual_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsComputername_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemRecordsDateOfTheLastObservation_Click(object sender, EventArgs e)
		{
			ShowRecordsMain();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionMeanAnomalyAtTheEpoch_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionArgumentOfPerihelion_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionLongitudeOfTheAscendingNode_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionInclination_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionOrbitalEccentricity_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionMeanDailyMotion_Click(object sender, EventArgs e)
		{
		}

		private static void MenuitemDistributionSemiMajorAxis_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionAbsoluteMagnitude_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionSlopeParameter_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionNumberOfOppositions_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionNumberOfObservations_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionObservationSpan_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionRmsResidual_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistributionComputerName_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void SplitbuttonDistribution_ButtonClick(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void MenuitemDistribution_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemOpenALocalMpcorbdatFile_Click(object sender, EventArgs e)
		{
			OpenDatabaseDifferences();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonOpen_Click(object sender, EventArgs e)
		{
			OpenDatabaseDifferences();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripButtonListReadableDesignations_Click(object sender, EventArgs e)
		{
			ListReadableDesignations();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuitemListReadableDesignations_Click(object sender, EventArgs e)
		{
			ListReadableDesignations();
		}

		#endregion

		#region DoubleClick-Handler

		/// <summary>
		/// Called when a control is double-clicked to copy the text to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			ArgumentNullException.ThrowIfNull(argument: sender);
			if (sender is Control control)
			{
				CopyToClipboard(text: control.Text);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EasterEgg_DoubleClick(object sender, EventArgs e) => MessageBox.Show(text: I10nStrings.EasterEgg, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelIndexDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 0);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReadableDesignationNameDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 1);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelEpochDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 2);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelArgumentOfPerihelionDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 3);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelLongitudeOfTheAscendingNodeDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 4);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KryptonLabelMeanAnomalyAtTheEpochDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 5);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelInclinationToTheEclipticDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 6);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelOrbitalEccentricityDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 7);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelMeanDailyMotionDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 8);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSemiMajorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 9);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelAbsoluteMagnitudeDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 10);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelSlopeParameterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 11);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelReferenceDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 12);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumberOfOppositionsDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 13);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelNumberOfObservationsDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 14);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelObservationSpanDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 15);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelRmsResidualDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 16);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelComputerNameDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 17);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelFlagsDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 18);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LabelDateLastObservationDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 19);

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PlanetoidDBForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}