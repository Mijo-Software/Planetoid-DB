using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using Krypton.Toolkit;
using NLog;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents a form that displays terminology information.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]

	public partial class PlanetoidDBForm : KryptonForm
	{
		// NLog logger instance
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		// Current position in the planetoid database
		private int currentPosition = 0, stepPosition = 0;

		// Planetoid database
		private readonly ArrayList planetoidDatabase = [];

		// Web client for downloading data
		private readonly WebClient webClient = new();

		// Splash screen form
		private readonly SplashScreenForm formSplashScreen = new();

		// Filenames for the MPCORB database
		private readonly string filenameMpcorb = Properties.Resources.FilenameMpcorb;
		private readonly string filenameMpcorbTemp = Properties.Resources.FilenameMpcorbTemp;

		// URI for the MPCORB database
		private readonly Uri uriMpcorb = new(uriString: Properties.Settings.Default.systemMpcorbDatGzUrl);

		// Flag to indicate if a download is in progress
		private bool isBusy = false;

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
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlanetoidDBForm"/> class with a specified MPCORB.DAT file path.
		/// </summary>
		/// <param name="mpcorbDatFilePath">The file path to the MPCORB.DAT file.</param>
		public PlanetoidDBForm(string mpcorbDatFilePath)
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += new KeyEventHandler(PlanetoidDBForm_KeyDown);
			KeyPreview = true; // Ensures the form receives key events before the controls
			TextExtra = $"{Assembly.GetExecutingAssembly().GetName().Version}";
			SetStatusbar(text: string.Empty);
			MpcOrbDatFilePath = mpcorbDatFilePath;
		}

		#endregion

		#region Local methods

		/// <summary>
		/// Gets the file path of the MPCORB.DAT file.
		/// </summary>
		private string MpcOrbDatFilePath { get; set; } = string.Empty;


		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Displays an error message.
		/// </summary>
		/// <param name="message">The error message.</param>
		private static void ShowErrorMessage(string message) =>
			// Show an error message box with the specified message
			_ = MessageBox.Show(text: message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

		/// <summary>
		/// Copies the specified text to the clipboard and displays a confirmation message.
		/// </summary>
		/// <param name="text">The text to be copied.</param>
		private static void CopyToClipboard(string text)
		{
			try
			{
				// Copy the text to the clipboard
				Clipboard.SetText(text: text);
				_ = MessageBox.Show(text: I10nStrings.CopiedToClipboard, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				// Log the exception and show an error message
				logger.Error(exception: ex, message: ex.Message);
				// Show an error message
				ShowErrorMessage(message: $"File not found: {ex.Message}");
			}
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusbar(string text, string additionalInfo = "")
		{
			// Check if the text is not null or whitespace
			if (!string.IsNullOrWhiteSpace(value: text))
			{
				// Set the status bar text and enable it
				labelInformation.Enabled = true;
				labelInformation.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
			}
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusbar()
		{
			// Clear the status bar text and disable it
			labelInformation.Enabled = false;
			labelInformation.Text = string.Empty;
		}

		/// <summary>
		/// Restarts the application.
		/// </summary>
		private void Restart()
		{
			// Close the current form and start a new instance of the application
			_ = Process.Start(fileName: Application.ExecutablePath);
			Close();
		}

		/// <summary>
		/// Asks the user if they want to restart the application after downloading the database.
		/// </summary>
		private void AskForRestartAfterDownloadingDatabase()
		{
			// Ask the user if they want to restart the application after downloading the database
			// and show a message box with the option to restart or not
			// The message box will have the text "Download complete. Do you want to restart the application?"
			// and the caption "Information"
			// If the user clicks "Yes", restart the application
			// If the user clicks "No", do nothing
			if (MessageBox.Show(text: I10nStrings.DownloadCompleteAndRestartQuestionText, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Information, defaultButton: MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				// Restart the application
				Restart();
			}
		}

		/// <summary>
		/// Navigates to the specified position in the planetoid database.
		/// </summary>
		/// <param name="currentPosition">The position to navigate to.</param>
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
		/// Gets the last modified date of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The last modified date of the URI.</returns>
		private static DateTime GetLastModified(Uri uri)
		{
			// Create a new HttpWebRequest to the specified URI
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			// Set the method to HEAD to only retrieve headers
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			// Check if the response status code is OK (200)
			// If so, return the last modified date
			// Otherwise, return a default DateTime value
			// Note: The default DateTime value is not a valid date, so it should be handled appropriately
			// in the calling code
			// The default DateTime value is 1/1/0001 12:00:00 AM
			return response.StatusCode == HttpStatusCode.OK ? response.LastModified : new DateTime(year: 0, month: 0, day: 0, hour: 0, minute: 0, second: 0);
		}

		/// <summary>
		/// Gets the content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The content length of the URI.</returns>
		private static long GetContentLength(Uri uri)
		{
			// Create a new HttpWebRequest to the specified URI
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri: uri);
			// Set the method to HEAD to only retrieve headers
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			// Check if the response status code is OK (200)
			// If so, return the content length
			// Otherwise, return 0
			// Note: The content length is the size of the response body in bytes
			return response.StatusCode == HttpStatusCode.OK ? Convert.ToInt64(value: response.ContentLength) : 0;
		}

		/// <summary>
		/// Checks if an update for the MPCORB database is available.
		/// </summary>
		/// <returns>true if an update is available, otherwise false.</returns>
		private bool IsMpcorbDatUpdateAvailable()
		{
			// Check if the file exists before attempting to delete it
			if (File.Exists(path: filenameMpcorb))
			{
				// Get the file information for the local file
				FileInfo fileInfo = new(fileName: filenameMpcorb);
				// Get the last modified date of the local file
				DateTime datetimeFileLocal = fileInfo.LastWriteTime;
				// Get the last modified date of the online file
				DateTime datetimeFileOnline = GetLastModified(uri: uriMpcorb);
				// Get the content length of the online file
				_ = GetContentLength(uri: uriMpcorb);
				// Get the content length of the local file
				_ = fileInfo.Length;
				// Check if the online file is larger than the local file
				// If it greater, return true (update available)
				// Otherwise, return false (no update available)
				return datetimeFileOnline > datetimeFileLocal;
			}
			else
			{
				return true; // If the file does not exist, return true (update available)
			}
		}

		/// <summary>
		/// Loads a random minor planet from the database.
		/// </summary>
		private void LoadRandomMinorPlanet() => GotoCurrentPosition(currentPosition: currentPosition = new Random().Next(maxValue: planetoidDatabase.Count + 1));

		/// <summary>
		/// Navigates to the beginning of the data.
		/// </summary>
		private void NavigateToTheBeginOfTheData() => GotoCurrentPosition(currentPosition: currentPosition = 0);

		/// <summary>
		/// Navigates backward by a specified step in the data.
		/// </summary>
		private void NavigateSomeDataBackward()
		{
			// Decrease the current position by the step size
			currentPosition -= stepPosition;
			if (currentPosition < 1)
			{
				// If the current position is less than 1, wrap around to the end of the database
				currentPosition += planetoidDatabase.Count;
			}
			// Navigate to the current position
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// Navigates to the previous data entry.
		/// </summary>
		private void NavigateToThePreviousData()
		{
			// If the current position is 0, wrap around to the last entry in the database
			if (currentPosition == 0)
			{
				// Set the current position to the last entry in the database
				// This ensures that when the user navigates backward from the first entry, they go to the last entry
				// This is useful for circular navigation
				currentPosition = planetoidDatabase.Count - 1;
			}
			else
			{
				// Decrease the current position by 1
				currentPosition--;
			}
			// Navigate to the current position
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// Navigates to the next data entry.
		/// </summary>
		private void NavigateToTheNextData()
		{
			// If the current position is the last entry in the database, wrap around to the first entry
			if (currentPosition == planetoidDatabase.Count - 1)
			{
				// Set the current position to 0 (the first entry in the database)
				// This ensures that when the user navigates forward from the last entry, they go to the first entry
				// This is useful for circular navigation
				currentPosition = 0;
			}
			else
			{
				// Increase the current position by 1
				currentPosition++;
			}
			// Navigate to the current position
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// Navigates forward by a specified step in the data.
		/// </summary>
		private void NavigateSomeDataForward()
		{
			// Increase the current position by the step size
			// This allows the user to navigate through the database in larger increments
			currentPosition += stepPosition;
			// If the current position exceeds the total number of entries in the database, wrap around to the beginning
			if (currentPosition > planetoidDatabase.Count)
			{
				// Set the current position to the beginning of the database
				// This ensures that when the user navigates forward from the last entry, they go to the first entry
				// This is useful for circular navigation
				currentPosition -= planetoidDatabase.Count;
			}
			// Navigate to the current position
			GotoCurrentPosition(currentPosition: currentPosition);
		}

		/// <summary>
		/// Navigates to the end of the data.
		/// </summary>
		private void NavigateToTheEndOfTheData() => GotoCurrentPosition(currentPosition: currentPosition = planetoidDatabase.Count - 1);

		/// <summary>
		/// Opens the terminology form with the specified index.
		/// </summary>
		/// <param name="index">The index to set active in the terminology form.</param>
		private void OpenTerminology(uint index)
		{
			// Create a new instance of the TerminologyForm
			using TerminologyForm formTerminology = new();
			// Set the active terminology based on the index
			switch (index)
			{
				case 0: formTerminology.SetIndexNumberActive(); break; // Index number
				case 1: formTerminology.SetReadableDesignationActive(); break; // Readable designation
				case 2: formTerminology.SetEpochActive(); break; // Epoch
				case 3: formTerminology.SetMeanAnomalyAtTheEpochActive(); break; // Mean anomaly at the epoch
				case 4: formTerminology.SetArgumentOfPerihelionActive(); break; // Argument of perihelion
				case 5: formTerminology.SetLongitudeOfTheAscendingNodeActive(); break; // Longitude of the ascending node
				case 6: formTerminology.SetInclinationToTheEclipticActive(); break; // Inclination to the ecliptic
				case 7: formTerminology.SetOrbitalEccentricityActive(); break; // Orbital eccentricity
				case 8: formTerminology.SetMeanDailyMotionActive(); break; // Mean daily motion
				case 9: formTerminology.SetSemiMajorAxisActive(); break; // Semi-major axis
				case 10: formTerminology.SetAbsoluteMagnitudeActive(); break; // Absolute magnitude
				case 11: formTerminology.SetSlopeParamActive(); break; // Slope parameter
				case 12: formTerminology.SetReferenceActive(); break; // Reference
				case 13: formTerminology.SetNumberOfOppositionsActive(); break; // Number of oppositions
				case 14: formTerminology.SetNumberOfObservationsActive(); break; // Number of observations
				case 15: formTerminology.SetObservationSpanActive(); break; // Observation span
				case 16: formTerminology.SetRmsResidualActive(); break; // r.m.s. residual
				case 17: formTerminology.SetComputerNameActive(); break; // Computer name
				case 18: formTerminology.SetFlagsActive(); break; // 4-hexdigit flags
				case 19: formTerminology.SetDateOfTheLastObservationActive(); break; // Date of last observation
				case 20: formTerminology.SetLinearEccentricityActive(); break; // Linear eccentricity
				case 21: formTerminology.SetSemiMinorAxisActive(); break; // Semi-minor axis
				case 22: formTerminology.SetMajorAxisActive(); break; // Major axis
				case 23: formTerminology.SetMinorAxisActive(); break; // Minor axis
				case 24: formTerminology.SetEccenctricAnomalyActive(); break; // Eccentric anomaly
				case 25: formTerminology.SetTrueAnomalyActive(); break; // True anomaly
				case 26: formTerminology.SetPerihelionDistanceActive(); break; // Perihelion distance
				case 27: formTerminology.SetAphelionDistanceActive(); break; // Aphelion distance
				case 28: formTerminology.SetLongitudeOfTheDescendingNodeActive(); break; // Longitude of the descending node
				case 29: formTerminology.SetArgumentOfTheAphelionActive(); break; // Argument of the aphelion
				case 30: formTerminology.SetFocalParameterActive(); break; // Focal parameter
				case 31: formTerminology.SetSemiLatusRectumActive(); break; // Semi-latus rectum
				case 32: formTerminology.SetLatusRectumActive(); break; // Latus rectum
				case 33: formTerminology.SetOrbitalPeriodActive(); break; // Orbital period
				case 34: formTerminology.SetOrbitalAreaActive(); break; // Orbital area
				case 35: formTerminology.SetOrbitalPerimeterActive(); break; // Orbital perimeter
				case 36: formTerminology.SetSemiMeanAxisActive(); break; // Semi-mean axis
				case 37: formTerminology.SetMeanAxisActive(); break; // Mean axis
				case 38: formTerminology.SetStandardGravitationalParameterActive(); break; // Standard gravitational parameter
				default: formTerminology.SetIndexNumberActive(); break; // Default to index number
			}
			// Set the TopMost property to true to keep the form on top of other windows
			formTerminology.TopMost = TopMost;
			// Show the terminology form as a modal dialog
			_ = formTerminology.ShowDialog();
		}

		/// <summary>
		/// Opens the table mode form.
		/// </summary>
		private void OpenTableMode()
		{
			// Create a new instance of the TableModeForm
			using TableModeForm formTableMode = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formTableMode.TopMost = TopMost;
			// Fill the form with the planetoid database
			formTableMode.FillArray(arrTemp: planetoidDatabase);
			// Show the table mode form as a modal dialog
			_ = formTableMode.ShowDialog();
		}

		/// <summary>
		/// Shows the application information form.
		/// </summary>
		private void ShowAppInfo()
		{
			// Create a new instance of the AppInfoForm
			using AppInfoForm formAppInfo = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formAppInfo.TopMost = TopMost;
			// Show the application information form as a modal dialog
			_ = formAppInfo.ShowDialog();
		}

		/// <summary>
		/// Shows the license form.
		/// </summary>
		private void ShowLicense()
		{
			// Create a new instance of the LicenseForm
			using LicenseForm formLicense = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formLicense.TopMost = TopMost;
			// Show the application information form as a modal dialog
			_ = formLicense.ShowDialog();
		}

		/// <summary>
		/// Shows the records selection form.
		/// </summary>
		private void ShowRecordsSelection()
		{
			// Create a new instance of the RecordsSelectionForm
			using RecordsSelectionForm formRecordsSelection = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formRecordsSelection.TopMost = TopMost;
			// Show the records selection form as a modal dialog
			_ = formRecordsSelection.ShowDialog();
		}

		/// <summary>
		/// Shows the main records form.
		/// </summary>
		private void ShowRecordsMain()
		{
			// Create a new instance of the RecordsMainForm
			using RecordsMainForm formRecordsMain = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formRecordsMain.TopMost = TopMost;
			// Show the records form as a modal dialog
			_ = formRecordsMain.ShowDialog();
		}

		/// <summary>
		/// Shows the MPCORB data check form.
		/// </summary>
		private void ShowMpcorbDatCheck()
		{
			// Check if the network is available before proceeding with the download
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				// Display an error message if the network is not available
				_ = MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				// Create and show the MPCORB data check form
				using CheckMpcorbDatForm formCheckMpcorbDat = new();
				// Set the TopMost property to true to keep the form on top of other windows
				formCheckMpcorbDat.TopMost = TopMost;
				// Show the MPCORB data check form as a modal dialog
				_ = formCheckMpcorbDat.ShowDialog();
			}
		}

		/// <summary>
		/// Shows the MPCORB data check form.
		/// </summary>
		private void ShowAstorbDatCheck()
		{
			// Check if the network is available before proceeding with the download
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				// Display an error message if the network is not available
				_ = MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				// Create and show the ASTORB data check form
				using CheckAstorbDatForm formCheckAstorbDat = new();
				// Set the TopMost property to true to keep the form on top of other windows
				formCheckAstorbDat.TopMost = TopMost;
				// Show the ASTORB data check form as a modal dialog
				_ = formCheckAstorbDat.ShowDialog();
			}
		}

		/// <summary>
		/// Shows the downloader form for the MPCORB database.
		/// </summary>
		private void ShowMpcorbDatDownloader()
		{
			// Check if the network is available before proceeding with the download
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				// Display an error message if the network is not available
				_ = MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				// Create and show the downloader form for the MPCORB database
				using DownloadMpcorbDatForm formDownloaderForMpcorbDat = new();
				// Set the TopMost property to true to keep the form on top of other windows
				formDownloaderForMpcorbDat.TopMost = TopMost;
				// Show the downloader form as a modal dialog
				if (formDownloaderForMpcorbDat.ShowDialog() == DialogResult.OK)
				{
					// Ask the user if they want to restart the application after downloading the database
					AskForRestartAfterDownloadingDatabase();
				}
			}
		}

		/// <summary>
		/// Shows the downloader form for the ASTORB database.
		/// </summary>
		private void ShowAstorbDatDownloader()
		{
			// Check if the network is available before proceeding with the download
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				// Display an error message if the network is not available
				_ = MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			else
			{
				// Create and show the downloader form for the ASTORB database
				using DownloadAstorbDatForm formDownloaderForAstorbDat = new();
				// Set the TopMost property to true to keep the form on top of other windows
				formDownloaderForAstorbDat.TopMost = TopMost;
				// Show the downloader form as a modal dialog
				_ = formDownloaderForAstorbDat.ShowDialog();
				/* Meanwhile not necessary
				if (formDownloaderForAstorbDat.ShowDialog() == DialogResult.OK)
				{
					// Ask the user if they want to restart the application after downloading the database
					AskForRestartAfterDownloadingDatabase();
				}
				*/
			}
		}

		/// <summary>
		/// Shows the database information form.
		/// </summary>
		private void ShowDatabaseInformation()
		{
			// Create a new instance of the DatabaseInformationForm
			using DatabaseInformationForm formDatabaseInformation = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formDatabaseInformation.TopMost = TopMost;
			// Fill the form with the planetoid database
			_ = formDatabaseInformation.ShowDialog();
		}

		/// <summary>
		/// Shows the form to copy data to the clipboard.
		/// </summary>
		private void ShowCopyDataToClipboard()
		{
			// Create a new ArrayList to store the data to copy
			// The capacity is set to 0 because we will add items dynamically
			// The items in the ArrayList are the labels that contain the data to be copied
			// The labels are accessed using their respective properties
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
			// Create a new list to store the data to copy
			List<string> dataToCopyList = [];
			// Iterate through each item in the dataToCopy array
			foreach (object? item in dataToCopy)
			{
				// Check if the item is not null
				if (item != null)
				{
					// Convert the item to a string representation
					string? itemString = item.ToString();
					// Check if the item is not null or empty
					if (!string.IsNullOrEmpty(value: itemString))
					{
						// Add the item to the list if it is not null or empty
						dataToCopyList.Add(item: itemString);
					}
				}
			}
			// Create a new instance of the CopyDataToClipboardForm
			using CopyDataToClipboardForm formCopyDataToClipboard = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formCopyDataToClipboard.TopMost = TopMost;
			// Fill the form with the data to copy
			formCopyDataToClipboard.SetDatabase(list: dataToCopyList);
			// Show the copy data to clipboard form as a modal dialog
			_ = formCopyDataToClipboard.ShowDialog();
		}

		/// <summary>
		/// Shows the search form.
		/// </summary>
		private void ShowSearch()
		{
			// Create a new instance of the SearchForm
			using SearchForm formSearch = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formSearch.TopMost = TopMost;
			// Fill the form with the planetoid database
			formSearch.FillArray(arrTemp: planetoidDatabase);
			// Set the maximum index for the search form
			formSearch.SetMaxIndex(maxIndex: planetoidDatabase.Count);
			// Show the search form as a modal dialog
			_ = formSearch.ShowDialog();
			// Check if the dialog result is OK and the selected index is greater than 0
			_ = MessageBox.Show(text: formSearch.GetSelectedIndex().ToString());
			// If so, navigate to the current position in the database
			if (formSearch.DialogResult == DialogResult.OK && formSearch.GetSelectedIndex() > 0)
			{
				// Navigate to the current position in the database
				GotoCurrentPosition(currentPosition: formSearch.GetSelectedIndex());
			}
		}

		/// <summary>
		/// Shows the filter form.
		/// </summary>
		private void ShowFilter()
		{
			// Create a new instance of the FilterForm
			using FilterForm formFilter = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formFilter.TopMost = TopMost;
			// Fill the form with the planetoid database
			_ = formFilter.ShowDialog();
		}

		/// <summary>
		/// Shows the settings form.
		/// </summary>
		private void ShowSettings()
		{
			// Create a new instance of the SettingsForm
			using SettingsForm formSettings = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formSettings.TopMost = TopMost;
			// Fill the form with the planetoid database
			_ = formSettings.ShowDialog();
		}

		/// <summary>
		/// Opens the database differences form.
		/// </summary>
		private void OpenDatabaseDifferences()
		{
			// Create a new instance of the DatabaseDifferencesForm
			using DatabaseDifferencesForm formDatabaseDifferences = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formDatabaseDifferences.TopMost = TopMost;
			// Fill the form with the planetoid database
			_ = formDatabaseDifferences.ShowDialog();
		}

		/// <summary>
		/// Lists readable designations.
		/// </summary>
		private void ListReadableDesignations()
		{
			// Create a new instance of the ListReadableDesignationsForm
			using ListReadableDesignationsForm formListReadableDesignations = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formListReadableDesignations.TopMost = TopMost;
			// Fill the form with the planetoid database
			formListReadableDesignations.FillArray(arrTemp: planetoidDatabase);
			// Set the maximum index for the form
			formListReadableDesignations.SetMaxIndex(maxIndex: planetoidDatabase.Count);
			// Show the list readable designations form as a modal dialog
			_ = formListReadableDesignations.ShowDialog();
			// Check if the dialog result is OK and the selected index is greater than 0
			if (formListReadableDesignations.DialogResult == DialogResult.OK && formListReadableDesignations.GetSelectedIndex() > 0)
			{
				// Navigate to the current position in the database
				GotoCurrentPosition(currentPosition: formListReadableDesignations.GetSelectedIndex());
			}
		}

		/// <summary>
		/// Exports the data sheet.
		/// </summary>
		private void ExportDataSheet()
		{
			// Create a new ArrayList to store the orbital elements
			ArrayList orbitalElements = [];
			// Create a specific culture for formatting
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
			// Create a new instance of the ExportDataSheetForm
			using ExportDataSheetForm formExportDataSheet = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formExportDataSheet.TopMost = TopMost;
			// Fill the form with the orbital elements
			formExportDataSheet.SetDatabase(list: [.. orbitalElements.Cast<string>()]);
			// Show the export data sheet form as a modal dialog
			_ = formExportDataSheet.ShowDialog();
		}

		/// <summary>
		/// Shows the print data sheet form.
		/// </summary>
		private void PrintDataSheet()
		{
			// Create a new instance of the PrintDataSheetForm
			using PrintDataSheetForm formPrintDataSheet = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formPrintDataSheet.TopMost = TopMost;
			// Fill the form with the planetoid database
			_ = formPrintDataSheet.ShowDialog();
		}

		/// <summary>
		/// Shows the derived orbit elements form.
		/// </summary>
		private void ShowDerivatedOrbitElements()
		{
			// Create a new ArrayList to store the derivated orbit elements
			ArrayList derivatedOrbitElements = [];
			// Create a specific culture for formatting
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
			// Create a new instance of the DerivatedOrbitElementsForm
			using DerivatedOrbitElementsForm formDerivatedOrbitElements = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formDerivatedOrbitElements.TopMost = TopMost;
			// Fill the form with the derivated orbit elements
			formDerivatedOrbitElements.SetDatabase(list: [.. derivatedOrbitElements.Cast<object>()]);
			// Show the derivated orbit elements form as a modal dialog
			_ = formDerivatedOrbitElements.ShowDialog();
		}

		/// <summary>
		/// Checks if the form should stay on top of other windows.
		/// </summary>
		private void CheckStayOnTop() => TopMost = menuitemOptionStayOnTop.Checked;

		#endregion

		#region Form* event handlers

		/// <summary>
		/// Handles the Load event of the PlanetoidDBForm.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PlanetoidDBForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			backgroundWorkerLoadingDatabase.WorkerReportsProgress = true;
			backgroundWorkerLoadingDatabase.WorkerSupportsCancellation = true;
#pragma warning disable CS8622 // The nullability of reference types in type of parameter doesn't match the target delegate.
			backgroundWorkerLoadingDatabase.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorkerLoadingDatabase_ProgressChanged);
			backgroundWorkerLoadingDatabase.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerLoadingDatabase_RunWorkerCompleted);
#pragma warning restore CS8622 // The nullability of reference types in type of parameter doesn't match the target delegate.
			backgroundWorkerLoadingDatabase.RunWorkerAsync();
			formSplashScreen.Show();
		}

		/// <summary>
		/// Handles the shown event of the PlanetoidDBForm.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PlanetoidDBForm_Shown(object sender, EventArgs e)
		{
			// Disable the background download label
			toolStripStatusLabelBackgroundDownload.Enabled = false;
			// Disable the background download progress bar
			toolStripProgressBarBackgroundDownload.Enabled = false;
			// Disable the cancel background download label
			toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
			// Hide the background download label
			toolStripStatusLabelBackgroundDownload.Visible = false;
			// Hide the background download progress bar
			toolStripProgressBarBackgroundDownload.Visible = false;
			// Hide the cancel background download label
			toolStripStatusLabelCancelBackgroundDownload.Visible = false;
			// Check if an update is available for the MPCORB database
			// and enable the timer for blinking the update label
			if (IsMpcorbDatUpdateAvailable())
			{
				timerBlinkForUpdateAvailable.Enabled = true;
				toolStripStatusLabelUpdate.Enabled = true;
			}
			// Otherwise, disable the timer and hide the update label
			else
			{
				timerBlinkForUpdateAvailable.Enabled = false;
				toolStripStatusLabelUpdate.Enabled = false;
				toolStripStatusLabelUpdate.Visible = false;
			}
			// Check if the form should stay on top of other windows
			CheckStayOnTop();
		}

		/// <summary>
		/// Handles the FormClosing event of the PlanetoidDBForm.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance that contains the event data.</param>
		private void PlanetoidDBForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Check if the file exists before attempting to delete it
			if (File.Exists(path: filenameMpcorbTemp))
			{
				// Delete the temporary file if it exists
				File.Delete(path: filenameMpcorbTemp);
			}
		}

		#endregion

		#region BackgroundWorker for database loading on start up

		/// <summary>
		/// Handles the DoWork event of the BackgroundWorker for loading the database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="DoWorkEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorkerLoadingDatabase_DoWork(object sender, DoWorkEventArgs e)
		{
			Enabled = false; // Disable the form while loading the database
			int lineNum = 0; // Variable to store the line number being read
			float percent; // Variable to store the percentage of the file read
			string readLine; // Variable to store the read line from the file
			string filename = !string.IsNullOrEmpty(value: MpcOrbDatFilePath) ? MpcOrbDatFilePath : filenameMpcorb; // Get the file name from the path
			FileInfo fileInfo = new(fileName: filename);
			long fileSize = fileInfo.Length, fileSizeReaded = 0; // Get the size of the file in bytes
																 // Open the file stream for reading
			using (FileStream fileStream = new(path: filename, mode: FileMode.Open))
			{
				// Create a new instance of the PlanetoidDatabase class
				StreamReader streamReader = new(stream: fileStream);
				// Show the splash screen
				formSplashScreen.Show();
				while (streamReader.Peek() != -1 && !backgroundWorkerLoadingDatabase.CancellationPending)
				{
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
					readLine = streamReader.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
					fileSizeReaded += readLine.Length;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
					percent = 100 * fileSizeReaded / fileSize;
					// Report progress to the background worker
					formSplashScreen.SetProgressbar(value: (int)percent);
					lineNum++;
					// Check if the line number is greater than or equal to 44
					if ((lineNum >= 44) && (!string.IsNullOrEmpty(value: readLine)))
					{
						// Add the read line to the planetoid database
						_ = planetoidDatabase.Add(value: readLine);
					}
				}
				fileStream.Close();
				streamReader.Close();
			}
			formSplashScreen.Close();
		}

		/// <summary>
		/// Handles the ProgressChanged event of the BackgroundWorker for loading the database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance that contains the event data.</param>
		private static void BackgroundWorkerLoadingDatabase_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
		}

		/// <summary>
		/// Handles the RunWorkerCompleted event of the BackgroundWorker for loading the database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorkerLoadingDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			toolStripTextBoxGotoIndex.Text = 1.ToString(); // Set the initial value of the goto index text box
			currentPosition = 0; // Set the current position to the first record
			stepPosition = 100; // Set the step position to 100
			GotoCurrentPosition(currentPosition: currentPosition); // Navigate to the current position
			Enabled = true; // Enable the form
			isBusy = false; // Set the busy state to false
		}

		#endregion

		#region Download and update database

		/// <summary>
		/// Handles the progress changed event during the download process.
		/// Updates the progress bar and taskbar progress.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="DownloadProgressChangedEventArgs"/> instance that contains the event data.</param>
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			// Update the progress bar value
			toolStripProgressBarBackgroundDownload.Value = e.ProgressPercentage;
			// Set the taskbar progress value
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
		}

		private static void ExtractGzipFile(string gzipFilePath, string outputFilePath)
		{
			// Create a new file stream for the gzip file
			using FileStream originalFileStream = new(path: gzipFilePath, mode: FileMode.Open, access: FileAccess.Read);
			// Create a new file stream for the output file
			using FileStream decompressedFileStream = new(path: outputFilePath, mode: FileMode.Create, access: FileAccess.Write);
			// Create a GZipStream for decompression
			using GZipStream decompressionStream = new(stream: originalFileStream, mode: CompressionMode.Decompress);
			// Copy the decompressed data to the output file stream
			decompressionStream.CopyTo(destination: decompressedFileStream);
		}

		/// <summary>
		/// Handles the completion of the download process.
		/// Manages file operations and updates the UI accordingly.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="AsyncCompletedEventArgs"/> instance that contains the event data.</param>
		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			webClient.Dispose();
			if (e.Error == null)
			{
				// Delete the old file if it exists
				File.Delete(path: filenameMpcorb);
				// Set the progress bar style to Marquee
				toolStripProgressBarBackgroundDownload.Style = ProgressBarStyle.Marquee;
				// Extract the downloaded gzip file
				ExtractGzipFile(gzipFilePath: filenameMpcorbTemp, outputFilePath: Properties.Resources.FilenameMpcorb);
				// Delete the temporary file after extraction
				File.Delete(path: filenameMpcorbTemp);
				// Show a message indicating that the download was successful
				AskForRestartAfterDownloadingDatabase();
			}
			else
			{
				// Show an error message if the download was cancelled or failed
				_ = e.Cancelled
					? MessageBox.Show(text: I10nStrings.DownloadCancelledText, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning)
					: MessageBox.Show(text: I10nStrings.DownloadUnknownError + "\n\r" + e.Error, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				// Delete the temporary file if it exists
				File.Delete(path: filenameMpcorbTemp);
			}
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
		/// Handles the tick event for checking new MPCORB data file.
		/// Calls the PlanetoidDBForm_Shown method.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TimerCheckForNewMpcorbDatFile_Tick(object sender, EventArgs e) => PlanetoidDBForm_Shown(sender: sender, e: e);

		/// <summary>
		/// Handles the tick event for blinking the update available status label.
		/// Toggles the ForeColor of the toolStripStatusLabelUpdate.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TimerBlinkForUpdateAvailable_Tick(object sender, EventArgs e) => toolStripStatusLabelUpdate.ForeColor = toolStripStatusLabelUpdate.ForeColor == SystemColors.HotTrack ? SystemColors.ControlText : SystemColors.HotTrack;

		#endregion

		#region Clear-Handler

		/// <summary>
		/// Clears the checked state of all navigation step menu items.
		/// </summary>
		private void ToolStripMenuItem_Clear()
		{
			// Clear the checked state of all navigation step menu items
			menuitemNavigateStep10.Checked = false;
			menuitemNavigateStep100.Checked = false;
			menuitemNavigateStep1000.Checked = false;
			menuitemNavigateStep10000.Checked = false;
			menuitemNavigateStep100000.Checked = false;
		}

		#endregion

		#region KeyPress-Handler

		/// <summary>
		/// Handles the KeyPress event for the ToolStripTextBoxGotoIndex.
		/// Ensures only numeric input and handles the Enter key to trigger navigation.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyPressEventArgs"/> instance that contains the event data.</param>
		private void ToolStripTextBoxGotoIndex_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check if the pressed key is a control character or a digit
			if (!char.IsControl(c: e.KeyChar) && !char.IsDigit(c: e.KeyChar))
			{
				// If the pressed key is not a digit or control character, suppress the key event
				e.Handled = true;
			}
			// Check if the pressed key is a digit or control character
			if (e.KeyChar == Convert.ToChar(value: Keys.Return, provider: CultureInfo.CurrentCulture))
			{
				// If the Enter key is pressed, trigger the click event for the ToolStripButtonGoToIndex
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
			// Set the status bar text based on the sender's accessible description
			switch (sender)
			{
				// If the sender is a control with an accessible description, set the status bar text
				// If the sender is a ToolStripItem with an accessible description, set the status bar text
				case Control control when control.AccessibleDescription != null:
					SetStatusbar(text: control.AccessibleDescription);
					break;
				case ToolStripItem item when item.AccessibleDescription != null:
					SetStatusbar(text: item.AccessibleDescription);
					break;
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
		/// Handles the click event for the ToolStripButtonStepToBegin.
		/// Navigates to the beginning of the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonStepToBegin_Click(object sender, EventArgs e) => NavigateToTheBeginOfTheData();

		/// <summary>
		/// Handles the click event for the ToolStripButtonStepBackward.
		/// Navigates backward by a specified step in the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonStepBackward_Click(object sender, EventArgs e) => NavigateSomeDataBackward();

		/// <summary>
		/// Handles the click event for the ToolStripButtonStepBackwardOne.
		/// Navigates to the previous data entry.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonStepBackwardOne_Click(object sender, EventArgs e) => NavigateToThePreviousData();

		/// <summary>
		/// Handles the click event for the ToolStripButtonStepForwardOne.
		/// Navigates to the next data entry.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonStepForwardOne_Click(object sender, EventArgs e) => NavigateToTheNextData();

		/// <summary>
		/// Handles the click event for the ToolStripButtonStepForward.
		/// Navigates forward by a specified step in the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonStepForward_Click(object sender, EventArgs e) => NavigateSomeDataForward();

		/// <summary>
		/// Handles the click event for the ToolStripButtonStepToEnd.
		/// Navigates to the end of the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonStepToEnd_Click(object sender, EventArgs e) => NavigateToTheEndOfTheData();

		/// <summary>
		/// Handles the click event for the ToolStripButtonGoToIndex.
		/// Navigates to the specified index in the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonGoToIndex_Click(object? sender, EventArgs? e)
		{
			int pos = 0;
			// Try to parse the index from the ToolStripTextBoxGotoIndex
			try
			{
				// Parse the index from the text box
				pos = int.Parse(s: toolStripTextBoxGotoIndex.Text, provider: CultureInfo.CurrentCulture);
			}
			// Catch any exceptions that occur during parsing
			catch (Exception ex)
			{
				// Log the error message
				logger.Error(message: ex.Message);
				// Show an error message box with the exception message
				ShowErrorMessage(message: $"{nameof(ToolStripButtonGoToIndex_Click)}  {ex.Message}");
				_ = MessageBox.Show(text: ex.Message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			// If the parsed index is out of range, show an error message
			// Otherwise, navigate to the specified index
			if (pos <= 0 || pos >= planetoidDatabase.Count + 1)
			{
				// Log the error message
				logger.Error(message: "Index out of range");
				// Show an error message if the index is out of range
				ShowErrorMessage(message: $"{I10nStrings.IndexOutOfRange}");
			}
			else
			{
				// Navigate to the specified index
				currentPosition = pos - 1;
				GotoCurrentPosition(currentPosition: currentPosition);
			}
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemTerminology.
		/// Opens the terminology form with the specified index.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemTerminology_Click(object sender, EventArgs e) => OpenTerminology(index: 0);

		/// <summary>
		/// Handles the click event for the ToolStripButtonTerminology.
		/// Opens the terminology form with the specified index.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonTerminology_Click(object sender, EventArgs e) => OpenTerminology(index: 0);

		/// <summary>
		/// Handles the click event for the ToolStripStatusLabelCancelBackgroundDownload.
		/// Cancels the ongoing download process.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripStatusLabelCancelBackgroundDownload_Click(object sender, EventArgs e)
		{
			// Cancel the background download
			toolStripStatusLabelBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Enabled = false;
			toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
			toolStripStatusLabelBackgroundDownload.Visible = false;
			toolStripProgressBarBackgroundDownload.Visible = false;
			toolStripStatusLabelCancelBackgroundDownload.Visible = false;
			webClient.CancelAsync();
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItem10.
		/// Sets the navigation step to 10 and updates the menu item checked state.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			// Set the step position to 10
			stepPosition = 10;
			// Clear the checked state of all other menu items
			ToolStripMenuItem_Clear();
			// Set the checked state of the menu item to true
			menuitemNavigateStep10.Checked = true;
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItem100.
		/// Sets the navigation step to 100 and updates the menu item checked state.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItem100_Click(object sender, EventArgs e)
		{
			// Set the step position to 100
			stepPosition = 100;
			// Clear the checked state of all other menu items
			ToolStripMenuItem_Clear();
			// Set the checked state of the menu item to true
			menuitemNavigateStep100.Checked = true;
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItem1000.
		/// Sets the navigation step to 1000 and updates the menu item checked state.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItem1000_Click(object sender, EventArgs e)
		{
			// Set the step position to 1000
			stepPosition = 1000;
			// Clear the checked state of all other menu items
			ToolStripMenuItem_Clear();
			// Set the checked state of the menu item to true
			menuitemNavigateStep1000.Checked = true;
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItem10000.
		/// Sets the navigation step to 10000 and updates the menu item checked state.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItem10000_Click(object sender, EventArgs e)
		{
			// Set the step position to 10000
			stepPosition = 10000;
			// Clear the checked state of all other menu items
			ToolStripMenuItem_Clear();
			// Set the checked state of the menu item to true
			menuitemNavigateStep10000.Checked = true;
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItem100000.
		/// Sets the navigation step to 100000 and updates the menu item checked state.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItem100000_Click(object sender, EventArgs e)
		{
			// Set the step position to 100000
			stepPosition = 100000;
			// Clear the checked state of all other menu items
			ToolStripMenuItem_Clear();
			// Set the checked state of the menu item to true
			menuitemNavigateStep100000.Checked = true;
		}

		/// <summary>
		/// Handles the click event for the MenuitemExit.
		/// Closes the application.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemExit_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// Handles the click event for the MenuitemAbout.
		/// Shows the application information form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemAbout_Click(object sender, EventArgs e) => ShowAppInfo();

		/// <summary>
		/// Handles the click event for the MenuitemLicense.
		/// Shows the license form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemLicense_Click(object sender, EventArgs e) => ShowLicense();

		/// <summary>
		/// Handles the click event for the MenuitemOpenWebsitePDB.
		/// Opens the Planetoid Database website.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemOpenWebsitePDB_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.Homepage);

		/// <summary>
		/// Handles the click event for the MenuitemOpenWebsiteMPC.
		/// Opens the Minor Planet Center website.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemOpenWebsiteMPC_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.WebsiteMpc);

		/// <summary>
		/// Handles the click event for the MenuitemOpenMPCORBWebsite.
		/// Opens the MPCORB website.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemOpenMPCORBWebsite_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.WebsiteMpcorb);

		/// <summary>
		/// Handles the click event for the MenuitemDownloadMpcorbDat.
		/// Shows the downloader form for the MPCORB database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemDownloadMpcorbDat_Click(object sender, EventArgs e) => ShowMpcorbDatDownloader();

		/// <summary>
		/// Handles the click event for the MenuitemDownloadAstorbDat.
		/// Shows the downloader form for the ASTORB database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemDownloadAstorbDat_Click(object sender, EventArgs e) => ShowAstorbDatDownloader();

		/// <summary>
		/// Handles the click event for the MenuitemCheckMpcorbDat.
		/// Shows the MPCORB data check form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemCheckMpcorbDat_Click(object sender, EventArgs e) => ShowMpcorbDatCheck();

		/// <summary>
		/// Handles the click event for the MenuitemCheckMpcorbDat.
		/// Shows the ASTORB data check form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemCheckAstorbDat_Click(object sender, EventArgs e) => ShowAstorbDatCheck();

		/// <summary>
		/// Handles the click event for the ToolStripStatusLabelUpdate.
		/// Asks the user if they want to download the latest MPCORB data file and manages the download process.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
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
		/// Handles the click event for the ToolStripButtonCheckMpcorbDat.
		/// Shows the MPCORB data check form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonCheckMpcorbDat_Click(object sender, EventArgs e) => ShowMpcorbDatCheck();

		/// <summary>
		/// Handles the click event for the ToolStripButtonDownloadMpcorbDat.
		/// Shows the downloader form for the MPCORB database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonDownloadMpcorbDat_Click(object sender, EventArgs e) => ShowMpcorbDatDownloader();

		/// <summary>
		/// Handles the click event for the ToolStripButtonAbout.
		/// Shows the application information form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonAbout_Click(object sender, EventArgs e) => ShowAppInfo();

		/// <summary>
		/// Handles the click event for the ToolStripButtonOpenWebsitePDB.
		/// Opens the Planetoid Database website.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e) => Process.Start(fileName: Properties.Resources.Homepage);

		/// <summary>
		/// Handles the click event for the ToolStripButtonTableMode.
		/// Opens the table mode form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonTableMode_Click(object sender, EventArgs e) => OpenTableMode();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemTableMode.
		/// Opens the table mode form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemTableMode_Click(object sender, EventArgs e) => OpenTableMode();

		/// <summary>
		/// Handles the click event for the ToolStripButtonDatabaseInformation.
		/// Shows the database information form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonDatabaseInformation_Click(object sender, EventArgs e) => ShowDatabaseInformation();

		/// <summary>
		/// Handles the click event for the ToolStripButtonPrint.
		/// Shows the print data sheet form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonPrint_Click(object sender, EventArgs e) => PrintDataSheet();

		/// <summary>
		/// Handles the click event for the ToolStripButtonCopyToClipboard.
		/// Shows the form to copy data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonCopyToClipboard_Click(object sender, EventArgs e) => ShowCopyDataToClipboard();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemPrint.
		/// Shows the print data sheet form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemPrint_Click(object sender, EventArgs e) => PrintDataSheet();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemSearch.
		/// Shows the search form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemSearch_Click(object sender, EventArgs e) => ShowSearch();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemDatabaseInformation.
		/// Shows the database information form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDatabaseInformation_Click(object sender, EventArgs e) => ShowDatabaseInformation();

		/// <summary>
		/// Handles the click event for the ToolStripButtonLoadRandomMinorPlanet.
		/// Loads a random minor planet from the database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonLoadRandomMinorPlanet_Click(object sender, EventArgs e) => LoadRandomMinorPlanet();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemRandomMinorPlanet.
		/// Loads a random minor planet from the database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemRandomMinorPlanet_Click(object sender, EventArgs e) => LoadRandomMinorPlanet();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemNavigateToTheBegin.
		/// Navigates to the beginning of the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemNavigateToTheBegin_Click(object sender, EventArgs e) => NavigateToTheBeginOfTheData();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemNavigateSomeDataBackward.
		/// Navigates backward by a specified step in the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemNavigateSomeDataBackward_Click(object sender, EventArgs e) => NavigateSomeDataBackward();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemNavigateToThePreviousData.
		/// Navigates to the previous data entry.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemNavigateToThePreviousData_Click(object sender, EventArgs e) => NavigateToThePreviousData();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemNavigateToTheNextData.
		/// Navigates to the next data entry.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemNavigateToTheNextData_Click(object sender, EventArgs e) => NavigateToTheNextData();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemNavigateSomeDataForward.
		/// Navigates forward by a specified step in the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemNavigateSomeDataForward_Click(object sender, EventArgs e) => NavigateSomeDataForward();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemNavigateToTheEnd.
		/// Navigates to the end of the data.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemNavigateToTheEnd_Click(object sender, EventArgs e) => NavigateToTheEndOfTheData();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemSettings.
		/// Shows the settings form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemSettings_Click(object sender, EventArgs e) => ShowSettings();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemFilter.
		/// Shows the filter form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemFilter_Click(object sender, EventArgs e) => ShowFilter();

		/// <summary>
		/// Handles the click event for the ToolStripButtonFilter.
		/// Shows the filter form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonFilter_Click(object sender, EventArgs e) => ShowFilter();

		/// <summary>
		/// Handles the click event for the ToolStripButtonDerivatedOrbitElements.
		/// Shows the derived orbit elements form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonDerivatedOrbitElements_Click(object sender, EventArgs e) => ShowDerivatedOrbitElements();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemRestart.
		/// Restarts the application.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemRestart_Click(object sender, EventArgs e) => Restart();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemDerivatedOrbitElements.
		/// Shows the derived orbit elements form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDerivatedOrbitElements_Click(object sender, EventArgs e) => ShowDerivatedOrbitElements();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemStayOnTop.
		/// Checks if the form should stay on top of other windows.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemStayOnTop_Click(object sender, EventArgs e) => CheckStayOnTop();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemEnableCopyingByDoubleClicking.
		/// Enables copying by double-clicking.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemEnableCopyingByDoubleClicking_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemEnableLinkingToTerminology.
		/// Enables linking to terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemEnableLinkingToTerminology_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemIconsetSilk.
		/// Sets the icon set to Silk.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemIconsetSilk_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemIconsetFugue.
		/// Sets the icon set to Fugue.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemIconsetFugue_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemIconsetFatcow.
		/// Sets the icon set to Fatcow.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemIconsetFatcow_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardIndexNumber.
		/// Copies the index number to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardIndexNumber_Click(object sender, EventArgs e) => CopyToClipboard(text: labelIndexData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardReadableDesignation.
		/// Copies the readable designation to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardReadableDesignation_Click(object sender, EventArgs e) => CopyToClipboard(text: labelReadableDesignationData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardEpoch.
		/// Copies the epoch to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardEpoch_Click(object sender, EventArgs e) => CopyToClipboard(text: labelEpochData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardMeanAnomaly.
		/// Copies the mean anomaly to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardMeanAnomaly_Click(object sender, EventArgs e) => CopyToClipboard(text: labelMeanAnomalyAtTheEpochData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardArgumentOfPerihelion.
		/// Copies the argument of perihelion to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardArgumentOfPerihelion_Click(object sender, EventArgs e) => CopyToClipboard(text: labelArgumentOfPerihelionData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode.
		/// Copies the longitude of the ascending node to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => CopyToClipboard(text: labelLongitudeOfTheAscendingNodeData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardInclinationToTheEcliptic.
		/// Copies the inclination to the ecliptic data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardInclinationToTheEcliptic_Click(object sender, EventArgs e) => CopyToClipboard(text: labelInclinationToTheEclipticData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardOrbitalEccentricity.
		/// Copies the orbital eccentricity data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardOrbitalEccentricity_Click(object sender, EventArgs e) => CopyToClipboard(text: labelOrbitalEccentricityData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardMeanDailyMotion.
		/// Copies the mean daily motion data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardMeanDailyMotion_Click(object sender, EventArgs e) => CopyToClipboard(text: labelMeanDailyMotionData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardSemiMajorAxis.
		/// Copies the semi-major axis data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardSemiMajorAxis_Click(object sender, EventArgs e) => CopyToClipboard(text: labelSemiMajorAxisData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardAbsoluteMagnitude.
		/// Copies the absolute magnitude data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardAbsoluteMagnitude_Click(object sender, EventArgs e) => CopyToClipboard(text: labelAbsoluteMagnitudeData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardSlopeParameter.
		/// Copies the slope parameter data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardSlopeParameter_Click(object sender, EventArgs e) => CopyToClipboard(text: labelSlopeParameterData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardReference.
		/// Copies the reference data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardReference_Click(object sender, EventArgs e) => CopyToClipboard(text: labelReferenceData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardNumberOfOppositions.
		/// Copies the number of oppositions data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardNumberOfOppositions_Click(object sender, EventArgs e) => CopyToClipboard(text: labelNumberOfOppositionsData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardNumberOfObservations.
		/// Copies the number of observations data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardNumberOfObservations_Click(object sender, EventArgs e) => CopyToClipboard(text: labelNumberOfObservationsData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardObservationSpan.
		/// Copies the observation span data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardObservationSpan_Click(object sender, EventArgs e) => CopyToClipboard(text: labelObservationSpanData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardRmsResidual.
		/// Copies the RMS residual data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardRmsResidual_Click(object sender, EventArgs e) => CopyToClipboard(text: labelRmsResidualData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardComputerName.
		/// Copies the computer name data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardComputerName_Click(object sender, EventArgs e) => CopyToClipboard(text: labelComputerNameData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardDateOfLastObservation.
		/// Copies the date of last observation data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardDateOfLastObservation_Click(object sender, EventArgs e) => CopyToClipboard(text: labelDateLastObservationData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemCopyToClipboardFlags.
		/// Copies the flags data to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemCopyToClipboardFlags_Click(object sender, EventArgs e) => CopyToClipboard(text: labelFlagsData.Text);

		/// <summary>
		/// Handles the click event for the ToolStripSplitButtonExport.
		/// Exports the data sheet.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripSplitButtonExport_Click(object sender, EventArgs e) => ExportDataSheet();

		/// <summary>
		/// Handles the click event for the MenuitemTopTenRecords.
		/// Shows the records selection form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemTopTenRecords_Click(object sender, EventArgs e) => ShowRecordsSelection();

		/// <summary>
		/// Handles the button click event for the SplitbuttonTopTenRecords.
		/// Shows the records selection form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SplitbuttonTopTenRecords_ButtonClick(object sender, EventArgs e) => ShowRecordsSelection();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsMeanAnomalyAtTheEpoch.
		/// Shows the main records form for mean anomaly at the epoch.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsMeanAnomalyAtTheEpoch_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsArgumentOfPerihelion.
		/// Shows the main records form for argument of perihelion.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsArgumentOfPerihelion_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsLongitudeOfTheAscendingNode.
		/// Shows the main records form for the longitude of the ascending node.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsLongitudeOfTheAscendingNode_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsInclination.
		/// Shows the main records form for inclination.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsInclination_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsOrbitalEccentricity.
		/// Shows the main records form for orbital eccentricity.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsOrbitalEccentricity_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsMeanDailyMotion.
		/// Shows the main records form for mean daily motion.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsMeanDailyMotion_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsSemiMajorAxis.
		/// Shows the main records form for semi-major axis.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsSemiMajorAxis_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsAbsoluteMagnitude.
		/// Shows the main records form for absolute magnitude.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsAbsoluteMagnitude_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsSlopeParameter.
		/// Shows the main records form for slope parameter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsSlopeParameter_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsNumberOfOppositions.
		/// Shows the main records form for number of oppositions.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsNumberOfOppositions_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsNumberOfObservations.
		/// Shows the main records form for number of observations.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsNumberOfObservations_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsObservationSpan.
		/// Shows the main records form for observation span.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsObservationSpan_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsRmsResidual.
		/// Shows the main records form for RMS residual.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsRmsResidual_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsComputername.
		/// Shows the main records form for computer name.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsComputername_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemRecordsDateOfTheLastObservation.
		/// Shows the main records form for date of the last observation.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsDateOfTheLastObservation_Click(object sender, EventArgs e) => ShowRecordsMain();

		/// <summary>
		/// Handles the click event for the MenuitemDistributionMeanAnomalyAtTheEpoch.
		/// Shows the distribution form for mean anomaly at the epoch.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionMeanAnomalyAtTheEpoch_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionArgumentOfPerihelion.
		/// Shows the distribution form for argument of perihelion.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionArgumentOfPerihelion_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionLongitudeOfTheAscendingNode.
		/// Shows the distribution form for longitude of the ascending node.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionLongitudeOfTheAscendingNode_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionInclination.
		/// Shows the distribution form for inclination.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionInclination_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionOrbitalEccentricity.
		/// Shows the distribution form for orbital eccentricity.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionOrbitalEccentricity_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionMeanDailyMotion.
		/// Shows the distribution form for mean daily motion.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionMeanDailyMotion_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionSemiMajorAxis.
		/// Shows the distribution form for semi-major axis.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionSemiMajorAxis_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionAbsoluteMagnitude.
		/// Shows the distribution form for absolute magnitude.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionAbsoluteMagnitude_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionSlopeParameter.
		/// Shows the distribution form for slope parameter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionSlopeParameter_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionNumberOfOppositions.
		/// Shows the distribution form for number of oppositions.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionNumberOfOppositions_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionNumberOfObservations.
		/// Shows the distribution form for number of observations.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionNumberOfObservations_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionObservationSpan.
		/// Shows the distribution form for observation span.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionObservationSpan_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionRmsResidual.
		/// Shows the distribution form for RMS residual.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionRmsResidual_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionComputerName.
		/// Shows the distribution form for computer name.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionComputerName_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the button click event for the SplitbuttonDistribution.
		/// Shows the distribution form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void SplitbuttonDistribution_ButtonClick(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistribution.
		/// Shows the distribution form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistribution_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Handles the click event for the ToolStripButtonListReadableDesignations.
		/// Lists readable designations.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonListReadableDesignations_Click(object sender, EventArgs e) => ListReadableDesignations();

		/// <summary>
		/// Handles the click event for the MenuitemListReadableDesignations.
		/// Lists readable designations.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemListReadableDesignations_Click(object sender, EventArgs e) => ListReadableDesignations();

		/// <summary>
		/// Handles the click event for the ToolStripButtonLicense.
		/// Opens th license.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonLicense_Click(object sender, EventArgs e) => ShowLicense();


		#endregion

		#region DoubleClick-Handler

		/// <summary>
		/// Called when a control is double-clicked to copy the text to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			if (sender is Control control)
			{
				// Copy the text to the clipboard
				CopyToClipboard(text: control.Text);
			}
		}

		/// <summary>
		/// Handles the double-click event to show an Easter egg message.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void EasterEgg_DoubleClick(object sender, EventArgs e) => MessageBox.Show(text: I10nStrings.EasterEgg, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		/// <summary>
		/// Handles the double-click event on the index label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelIndexDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 0);

		/// <summary>
		/// Handles the double-click event on the readable designation name label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelReadableDesignationNameDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 1);

		/// <summary>
		/// Handles the double-click event on the epoch label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelEpochDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 2);

		/// <summary>
		/// Handles the double-click event on the argument of perihelion label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelArgumentOfPerihelionDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 3);

		/// <summary>
		/// Handles the double-click event on the longitude of the ascending node label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelLongitudeOfTheAscendingNodeDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 4);

		/// <summary>
		/// Handles the double-click event on the mean anomaly at the epoch label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void KryptonLabelMeanAnomalyAtTheEpochDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 5);

		/// <summary>
		/// Handles the double-click event on the inclination to the ecliptic label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelInclinationToTheEclipticDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 6);

		/// <summary>
		/// Handles the double-click event on the orbital eccentricity label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelOrbitalEccentricityDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 7);

		/// <summary>
		/// Handles the double-click event on the mean daily motion label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelMeanDailyMotionDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 8);

		/// <summary>
		/// Handles the double-click event on the semi-major axis label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelSemiMajorAxisDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 9);

		/// <summary>
		/// Handles the double-click event on the absolute magnitude label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelAbsoluteMagnitudeDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 10);

		/// <summary>
		/// Handles the double-click event on the slope parameter label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelSlopeParameterDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 11);

		/// <summary>
		/// Handles the double-click event on the reference label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelReferenceDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 12);

		/// <summary>
		/// Handles the double-click event on the number of oppositions label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelNumberOfOppositionsDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 13);

		/// <summary>
		/// Handles the double-click event on the number of observations label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelNumberOfObservationsDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 14);

		/// <summary>
		/// Handles the double-click event on the observation span label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelObservationSpanDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 15);

		/// <summary>
		/// Handles the double-click event on the RMS residual label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelRmsResidualDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 16);

		/// <summary>
		/// Handles the double-click event on the computer name label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelComputerNameDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 17);

		/// <summary>
		/// Handles the double-click event on the flags label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelFlagsDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 18);

		/// <summary>
		/// Handles the double-click event on the date of last observation label to open the terminology form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelDateLastObservationDesc_DoubleClick(object sender, EventArgs e) => OpenTerminology(index: 19);

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the PlanetoidDBForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PlanetoidDBForm_KeyDown(object? sender, KeyEventArgs e)
		{
			// Check if the sender is null
			ArgumentNullException.ThrowIfNull(argument: sender);
			// Check if the Escape key is pressed
			if (e.KeyCode == Keys.Escape)
			{
				// Close the form
				Close();
			}
		}

		#endregion
	}
}