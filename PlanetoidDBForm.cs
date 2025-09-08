﻿using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;

using NLog;

using Planetoid_DB.Properties;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents a form that displays terminology information.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]

	public partial class PlanetoidDbForm : Form
	{
		// NLog logger instance
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		// Current position in the planetoids database
		private int currentPosition, stepPosition;

		// Planetoids database
		private readonly ArrayList planetoidsDatabase = [];

		// Splash screen form
		private readonly SplashScreenForm formSplashScreen = new();

		// Filenames for the MPCORB database
		private readonly string filenameMpcorb = Settings.Default.systemFilenameMpcorb;
		private readonly string filenameMpcorbTemp = Settings.Default.systemFilenameMpcorbTemp;

		// URI for the MPCORB database
		private readonly Uri uriMpcorb = new(uriString: Settings.Default.systemMpcorbDatGzUrl);

		// Cancellation token source for download operations
		private CancellationTokenSource? downloadCancellationTokenSource;

		// HttpClient instance for making HTTP requests
		private static readonly HttpClient httpClient = new();

		/*
		private readonly IProgress<int>? downloadProgress;
		private const int bufferSize = 81920; // 80 KB buffer size for downloading
		private const int defaultStepPosition = 10; // Default step position for navigation
		private const int maxRetries = 3; // Maximum number of retries for downloading
		private const int delayBetweenRetries = 2000; // Delay between retries in milliseconds
		private const int downloadTimeoutInSeconds = 300; // Timeout for download in seconds (5 minutes)
		private const int minFileSizeInBytes = 500_000; // Minimum file size in bytes (500 KB)
		private const int maxFileSizeInBytes = 50_000_000; // Maximum file size in bytes (50 MB)
		private const int mpcorbDatExpectedFileSizeInBytes = 12_000_000; // Expected file size for MPCORB.DAT (12 MB)
		private const int mpcorbDatGzExpectedFileSizeInBytes = 3_000_000; // Expected file size for MPCORB.DAT.GZ (3 MB)
		private const int minPlanetoidDatabaseEntries = 100_000; // Minimum number of entries in the planetoid database
		private const int maxPlanetoidDatabaseEntries = 1_000_000; // Maximum number of entries in the planetoid database
		private const int connectionTimeoutInSeconds = 10; // Timeout for connection in seconds
		private const int readWriteTimeoutInSeconds = 30; // Timeout for read/write operations in seconds
		private const int maxNetworkRetries = 3; // Maximum number of retries for network operations
		private const int delayBetweenNetworkRetries = 2000; // Delay between network retries in milliseconds
		private const string userAgentString = "PlanetoidDB/1.0"; // User-Agent string for HTTP requests
		private const string mpcorbDatGzFileExtension = ".gz"; // File extension for gzipped files
		private const string mpcorbDatFileExtension = ".dat"; // File extension for dat files
		private const string mpcorbDatBackupFileExtension = ".bak"; // File extension for backup files
		private const string mpcorbDatTempFileExtension = ".tmp"; // File extension for temporary files
		private const string mpcorbDatUrl = "https://minorplanetcenter.net/iau/MPCORB/MPCORB.DAT.gz"; // URL for the MPCORB.DAT.GZ file
		private const string mpcorbDatLocalFileName = "MPCORB.DAT"; // Local filename for the MPCORB.DAT file
		private const string mpcorbDatGzLocalFileName = "MPCORB.DAT.gz"; // Local filename for the MPCORB.DAT.GZ file
		private const string mpcorbDatBackupFileName = "MPCORB.DAT.bak"; // Local filename for the backup file
		private const string mpcorbDatTempFileName = "MPCORB.DAT.tmp"; // Local filename for the temporary file
		private const string dateFormat = "yyyy-MM-dd HH:mm:ss"; // Date format for displaying dates
		private const string isoDateFormat = "yyyy-MM-dd"; // ISO date format for parsing dates
		private const string timeFormat = "HH:mm:ss"; // Time format for displaying times
		private const string dateTimeFormat = "yyyy-MM-dd HH:mm:ss"; // DateTime format for displaying date and time
		private const string gZipMimeType = "application/gzip"; // MIME type for gzip files
		private const string octetStreamMimeType = "application/octet-stream"; // MIME type for binary files
		private const string textPlainMimeType = "text/plain"; // MIME type for plain text files
		private const string httpScheme = "http"; // HTTP scheme
		private const string httpsScheme = "https"; // HTTPS scheme
		private const string ftpScheme = "ftp"; // FTP scheme
		private const string fileScheme = "file"; // File scheme
		private const string localFilePrefix = "file://"; // Prefix for local file paths
		private const string tempFolderPath = "Temp"; // Temporary folder path
		private const string backupFolderPath = "Backup"; // Backup folder path
		private const string mpcorbDatFileHeader = "MPCORB"; // Expected header in the MPCORB.DAT file
		private const string mpcorbDatGzFileHeader = "\x1F\x8B"; // Expected header in the MPCORB.DAT.GZ file
		*/

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="PlanetoidDbForm"/> class.
		/// </summary>
		public PlanetoidDbForm()
		{
			InitializeComponent();
			KeyDown += PlanetoidDBForm_KeyDown;
			KeyPreview = true; // Ensures the form receives key events before the controls
							   //TextExtra = $"{Assembly.GetExecutingAssembly().GetName().Version}";
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlanetoidDbForm"/> class with a specified MPCORB.DAT file path.
		/// </summary>
		/// <param name="mpcorbDatFilePath">The file path to the MPCORB.DAT file.</param>
		public PlanetoidDbForm(string mpcorbDatFilePath)
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += PlanetoidDBForm_KeyDown;
			KeyPreview = true; // Ensures the form receives key events before the controls
							   //TextExtra = $"{Assembly.GetExecutingAssembly().GetName().Version}";
			SetStatusBar(text: string.Empty);
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
				Logger.Error(exception: ex, message: ex.Message);
				// Show an error message
				ShowErrorMessage(message: $"File not found: {ex.Message}");
			}
		}

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusBar(string text, string additionalInfo = "")
		{
			// Check if the text is not null or whitespace
			if (string.IsNullOrWhiteSpace(value: text))
			{
				return;
			}
			// Set the status bar text and enable it
			labelInformation.Enabled = true;
			labelInformation.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
		}

		/// <summary>
		/// Clears the status bar text.
		/// </summary>
		private void ClearStatusBar()
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
		/// Navigates to the specified position in the planetoids database.
		/// </summary>
		/// <param name="position">The position to navigate to.</param>
		private void GotoCurrentPosition(int position)
		{
			// Validate the position
			if (position < 0 || position >= planetoidsDatabase.Count)
			{
				return;
			}
			else if (planetoidsDatabase.Count == 0)
			{
				return;
			}
			// Extract and display the data for the specified position
			// Each field is extracted using substring operations based on fixed positions
			// The extracted strings are trimmed to remove leading and trailing whitespace
			// Example for extracting a field:
			// string teilstring = planetoidsDatabase[position].ToString().Substring(startIndex: 0, length: 7).Trim();
			// int zahl = int.Parse(s: teilstring, style: NumberStyles.Integer, provider: CultureInfo.InvariantCulture);
			// The above example extracts a substring from the database entry at the specified position,
			// trims it, and converts it to an integer using invariant culture
			// The same approach is used for all other fields, adjusting the start index and length as needed
			// Note: The field lengths and positions are based on the MPCORB.DAT file format specification
			// The following fields are extracted:
			// Index number (positions 0-6)
			// Absolute magnitude (positions 8-12)
			// Slope parameter (positions 14-18)
			// Epoch (positions 20-24)
			// Mean anomaly at the epoch (positions 26-34)
			// Argument of perihelion (positions 37-45)
			// Longitude of the ascending node (positions 48-56)
			// Inclination to the ecliptic (positions 59-67)
			// Orbital eccentricity (positions 70-78)
			// Mean daily motion (positions 80-90)
			// Semi-major axis (positions 92-102)
			// Reference (positions 107-115)
			// Number of observations (positions 117-121)
			// Number of oppositions (positions 123-125)
			// Observation span (positions 127-135)
			// r.m.s. residual (positions 137-140)
			// Computer name (positions 150-159)
			// Flags (positions 161-164)
			// Readable designation (positions 166-193)
			// Date of last observation (positions 194-201)
			// Note: The substring method uses zero-based indexing
			// The lengths are inclusive of the start index
			// Example: Substring(startIndex: 0, length: 7) extracts characters from index 0 to 6
			// The extracted strings are trimmed to remove any leading or trailing whitespace
			// The extracted values are then displayed in the corresponding labels on the form
			// Example: labelIndexData.Text = extractedIndexString;
			// The above example sets the text of the label to the extracted index string
			// This process is repeated for all other fields
			// Note: Error handling is not included in this method
			// It is assumed that the data in the database is well-formed and follows the expected format
			//Achtung: Wenn später die Teilstrings in Zahlen konvertiert werden, dann muss darauf geachtet werden, dass die eingelesenen Zeichenketten keine Leerstrings sind.
			// if (teilstring == "0") zahl = 0; ...

			object? entry = planetoidsDatabase[index: position];
			labelIndexData.Text = entry?.ToString() is string entryStr ? entryStr[..7].Trim() : string.Empty;
			labelAbsoluteMagnitudeData.Text = entry?.ToString() is string entryStr1 ? entryStr1.Substring(startIndex: 8, length: 5).Trim() : string.Empty;
			labelSlopeParameterData.Text = entry?.ToString() is string entryStr2 ? entryStr2.Substring(startIndex: 14, length: 5).Trim() : string.Empty;
			labelEpochData.Text = entry?.ToString() is string entryStr3 ? entryStr3.Substring(startIndex: 20, length: 5).Trim() : string.Empty;
			labelMeanAnomalyAtTheEpochData.Text = entry?.ToString() is string entryStr4 ? entryStr4.Substring(startIndex: 26, length: 9).Trim() : string.Empty;
			labelArgumentOfPerihelionData.Text = entry?.ToString() is string entryStr5 ? entryStr5.Substring(startIndex: 37, length: 9).Trim() : string.Empty;
			labelLongitudeOfTheAscendingNodeData.Text = entry?.ToString() is string entryStr6 ? entryStr6.Substring(startIndex: 48, length: 9).Trim() : string.Empty;
			labelInclinationToTheEclipticData.Text = entry?.ToString() is string entryStr7 ? entryStr7.Substring(startIndex: 59, length: 9).Trim() : string.Empty;
			labelOrbitalEccentricityData.Text = entry?.ToString() is string entryStr8 ? entryStr8.Substring(startIndex: 70, length: 9).Trim() : string.Empty;
			labelMeanDailyMotionData.Text = entry?.ToString() is string entryStr9 ? entryStr9.Substring(startIndex: 80, length: 11).Trim() : string.Empty;
			labelSemiMajorAxisData.Text = entry?.ToString() is string entryStr10 ? entryStr10.Substring(startIndex: 92, length: 11).Trim() : string.Empty;
			labelReferenceData.Text = entry?.ToString() is string entryStr11 ? entryStr11.Substring(startIndex: 107, length: 9).Trim() : string.Empty;
			labelNumberOfObservationsData.Text = entry?.ToString() is string entryStr12 ? entryStr12.Substring(startIndex: 117, length: 5).Trim() : string.Empty;
			labelNumberOfOppositionsData.Text = entry?.ToString() is string entryStr13 ? entryStr13.Substring(startIndex: 123, length: 3).Trim() : string.Empty;
			labelObservationSpanData.Text = entry?.ToString() is string entryStr14 ? entryStr14.Substring(startIndex: 127, length: 9).Trim() : string.Empty;
			labelRmsResidualData.Text = entry?.ToString() is string entryStr15 ? entryStr15.Substring(startIndex: 137, length: 4).Trim() : string.Empty;
			labelComputerNameData.Text = entry?.ToString() is string entryStr16 ? entryStr16.Substring(startIndex: 150, length: 10).Trim() : string.Empty;
			labelFlagsData.Text = entry?.ToString() is string entryStr17 ? entryStr17.Substring(startIndex: 161, length: 4).Trim() : string.Empty;
			labelReadableDesignationData.Text = entry?.ToString() is string entryStr18 ? entryStr18.Substring(startIndex: 166, length: 28).Trim() : string.Empty;
			labelDateLastObservationData.Text = entry?.ToString() is string entryStr19 ? entryStr19.Substring(startIndex: 194, length: 8).Trim() : string.Empty;
			toolStripLabelIndexPosition.Text = $@"{I10nStrings.Index}: {position + 1:N0} / {planetoidsDatabase.Count:N0}";
			/* Original code:
			labelAbsoluteMagnitudeData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 8, length: 5).Trim();
			labelSlopeParameterData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 14, length: 5).Trim();
			labelEpochData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 20, length: 5).Trim();
			labelMeanAnomalyAtTheEpochData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 26, length: 9).Trim();
			labelArgumentOfPerihelionData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 37, length: 9).Trim();
			labelLongitudeOfTheAscendingNodeData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 48, length: 9).Trim();
			labelInclinationToTheEclipticData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 59, length: 9).Trim();
			labelOrbitalEccentricityData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 70, length: 9).Trim();
			labelMeanDailyMotionData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 80, length: 11).Trim();
			labelSemiMajorAxisData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 92, length: 11).Trim();
			labelReferenceData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 107, length: 9).Trim();
			labelNumberOfObservationsData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 117, length: 5).Trim();
			labelNumberOfOppositionsData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 123, length: 3).Trim();
			labelObservationSpanData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 127, length: 9).Trim();
			labelRmsResidualData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 137, length: 4).Trim();
			labelComputerNameData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 150, length: 10).Trim();
			labelFlagsData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 161, length: 4).Trim();
			labelReadableDesignationData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 166, length: 28).Trim();
			labelDateLastObservationData.Text = planetoidsDatabase[index: position].ToString().Substring(startIndex: 194, length: 8).Trim();
			toolStripLabelIndexPosition.Text = $@"{I10nStrings.Index}: {position + 1:N0} / {planetoidsDatabase.Count:N0}";
			*/
		}

		/// <summary>
		/// Retrieves the last modified date and time (in UTC) of the resource at the specified URI.
		/// </summary>
		/// <param name="uri">The URI of the resource to check.</param>
		/// <returns>
		/// The <see cref="DateTime"/> representing the last modified date and time in UTC if available; 
		/// otherwise, <see cref="DateTime.MinValue"/>.
		/// </returns>
		private static DateTime GetLastModified(Uri uri)
		{
			// Validate the input URI
			ArgumentNullException.ThrowIfNull(argument: uri);
			// Use HttpClient to retrieve only the headers (HEAD request)
			using HttpClient client = new();
			// Create a HEAD request to get only the headers
			using HttpRequestMessage request = new(method: HttpMethod.Head, requestUri: uri);
			// Send the request and get the response
			using HttpResponseMessage response = client.Send(request);
			// Check if the request was successful
			if (response.IsSuccessStatusCode)
			{
				// Check if the Last-Modified header is present and return its value
				if (response.Content.Headers.LastModified.HasValue)
				{
					// Return the last modified date in UTC
					return response.Content.Headers.LastModified.Value.UtcDateTime;
				}
			}
			// If the Last-Modified header is not present or the request failed, return DateTime.MinValue
			return DateTime.MinValue;
		}

		/// <summary>
		/// Gets the content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI to check.</param>
		/// <returns>The content length of the URI.</returns>
		private static long GetContentLength(Uri uri)
		{
			// Validate the input URI
			ArgumentNullException.ThrowIfNull(argument: uri);
			// Use HttpClient to retrieve only the headers (HEAD request)
			using HttpClient client = new();
			// Create a HEAD request to get only the headers
			using HttpRequestMessage request = new(method: HttpMethod.Head, requestUri: uri);
			// Send the request and get the response
			using HttpResponseMessage response = client.Send(request);
			// Check if the request was successful
			if (response.IsSuccessStatusCode)
			{
				// Check if the Content-Length header is present and return its value
				if (response.Content.Headers.ContentLength.HasValue)
				{
					// Return the content length
					return response.Content.Headers.ContentLength.Value;
				}
			}
			// If the Content-Length header is not present or the request failed, return 0
			return 0;
		}

		/// <summary>
		/// Checks if an update for the MPCORB database is available.
		/// </summary>
		/// <returns>true if an update is available, otherwise false.</returns>
		private bool IsMpcorbDatUpdateAvailable()
		{
			// Check if the file exists before attempting to delete it
			if (!File.Exists(path: filenameMpcorb))
			{
				return true; // If the file does not exist, return true (update available)
			}
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

		/// <summary>
		/// Loads a random minor planet from the database.
		/// </summary>
		private void LoadRandomMinorPlanet() => GotoCurrentPosition(position: currentPosition = new Random().Next(maxValue: planetoidsDatabase.Count + 1));

		/// <summary>
		/// Navigates to the beginning of the data.
		/// </summary>
		private void NavigateToTheBeginOfTheData() => GotoCurrentPosition(position: currentPosition = 0);

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
				currentPosition += planetoidsDatabase.Count;
			}
			// Navigate to the current position
			GotoCurrentPosition(position: currentPosition);
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
				currentPosition = planetoidsDatabase.Count - 1;
			}
			else
			{
				// Decrease the current position by 1
				currentPosition--;
			}
			// Navigate to the current position
			GotoCurrentPosition(position: currentPosition);
		}

		/// <summary>
		/// Navigates to the next data entry.
		/// </summary>
		private void NavigateToTheNextData()
		{
			// If the current position is the last entry in the database, wrap around to the first entry
			if (currentPosition == planetoidsDatabase.Count - 1)
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
			GotoCurrentPosition(position: currentPosition);
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
			if (currentPosition > planetoidsDatabase.Count)
			{
				// Set the current position to the beginning of the database
				// This ensures that when the user navigates forward from the last entry, they go to the first entry
				// This is useful for circular navigation
				currentPosition -= planetoidsDatabase.Count;
			}
			// Navigate to the current position
			GotoCurrentPosition(position: currentPosition);
		}

		/// <summary>
		/// Navigates to the end of the data.
		/// </summary>
		private void NavigateToTheEndOfTheData() => GotoCurrentPosition(position: currentPosition = planetoidsDatabase.Count - 1);

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
				case 24: formTerminology.SetEccentricAnomalyActive(); break; // Eccentric anomaly
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
			// Fill the form with the planetoids database
			formTableMode.FillArray(arrTemp: planetoidsDatabase);
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
			// Fill the form with the planetoids database
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
			dataToCopyList.AddRange(collection: dataToCopy.OfType<object>().Select(selector: static item => item.ToString()).Where(predicate: static itemString => !string.IsNullOrEmpty(value: itemString))!);
			// Iterate through each item in the dataToCopy array
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
			// Fill the form with the planetoids database
			formSearch.FillArray(arrTemp: planetoidsDatabase);
			// Set the maximum index for the search form
			formSearch.SetMaxIndex(maxIndex: planetoidsDatabase.Count);
			// Show the search form as a modal dialog
			_ = formSearch.ShowDialog();
			// Check if the dialog result is OK and the selected index is greater than 0
			_ = MessageBox.Show(text: formSearch.GetSelectedIndex().ToString());
			// If so, navigate to the current position in the database
			if (formSearch.DialogResult == DialogResult.OK && formSearch.GetSelectedIndex() > 0)
			{
				// Navigate to the current position in the database
				GotoCurrentPosition(position: formSearch.GetSelectedIndex());
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
			// Fill the form with the planetoids database
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
			// Fill the form with the planetoids database
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
			// Fill the form with the planetoids database
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
			// Fill the form with the planetoids database
			formListReadableDesignations.FillArray(arrTemp: planetoidsDatabase);
			// Set the maximum index for the form
			formListReadableDesignations.SetMaxIndex(maxIndex: planetoidsDatabase.Count);
			// Show the list readable designations form as a modal dialog
			_ = formListReadableDesignations.ShowDialog();
			// Check if the dialog result is OK and the selected index is greater than 0
			if (formListReadableDesignations.DialogResult == DialogResult.OK && formListReadableDesignations.GetSelectedIndex() > 0)
			{
				// Navigate to the current position in the database
				GotoCurrentPosition(position: formListReadableDesignations.GetSelectedIndex());
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
			_ = orbitalElements.Add(value: CalculateArgumentOfAphelion(argumentAphelion: argumentAphelion).ToString(provider: provider));
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
			// Fill the form with the planetoids database
			_ = formPrintDataSheet.ShowDialog();
		}

		/// <summary>
		/// Shows the derived orbit elements form.
		/// </summary>
		private void ShowDerivativeOrbitElements()
		{
			// Create a new ArrayList to store the derivative orbit elements
			ArrayList derivativeOrbitElements = [];
			// Create a specific culture for formatting
			IFormatProvider provider = CultureInfo.CreateSpecificCulture(name: "en");
			double semiMajorAxis = double.Parse(s: labelSemiMajorAxisData.Text, provider: provider);
			double numericalEccentricity = double.Parse(s: labelOrbitalEccentricityData.Text, provider: provider);
			double meanAnomaly = double.Parse(s: labelMeanAnomalyAtTheEpochData.Text, provider: provider);
			double longitudeAscendingNode = double.Parse(s: labelLongitudeOfTheAscendingNodeData.Text, provider: provider);
			double argumentAphelion = double.Parse(s: labelArgumentOfPerihelionData.Text, provider: provider);
			_ = derivativeOrbitElements.Add(value: CalculateLinearEccentricity(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateSemiMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateMajorAxis(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateMinorAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateEccentricAnomaly(meanAnomaly: meanAnomaly, numericalEccentricity: numericalEccentricity, numberDecimalPlaces: 8).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateTrueAnomaly(meanAnomaly: meanAnomaly, numericalEccentricity: numericalEccentricity, numberDecimalPlaces: 8).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculatePerihelionDistance(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateAphelionDistance(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateLongitudeDescendingNode(longitudeAscendingNode: longitudeAscendingNode).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateArgumentOfAphelion(argumentAphelion: argumentAphelion).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateFocalParameter(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateSemiLatusRectum(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateLatusRectum(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculatePeriod(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateOrbitalArea(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateOrbitalPerimeter(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateSemiMeanAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateMeanAxis(semiMajorAxis: semiMajorAxis, numericalEccentricity: numericalEccentricity).ToString(provider: provider));
			_ = derivativeOrbitElements.Add(value: CalculateStandardGravitationalParameter(semiMajorAxis: semiMajorAxis).ToString(provider: provider));
			// Create a new instance of the DerivativeOrbitElementsForm
			using DerivativeOrbitElementsForm formDerivativeOrbitElements = new();
			// Set the TopMost property to true to keep the form on top of other windows
			formDerivativeOrbitElements.TopMost = TopMost;
			// Fill the form with the derivative orbit elements
			formDerivativeOrbitElements.SetDatabase(list: [.. derivativeOrbitElements.Cast<object>()]);
			// Show the derivative orbit elements form as a modal dialog
			_ = formDerivativeOrbitElements.ShowDialog();
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
			ClearStatusBar();
			backgroundWorkerLoadingDatabase.WorkerReportsProgress = true;
			backgroundWorkerLoadingDatabase.WorkerSupportsCancellation = true;
			backgroundWorkerLoadingDatabase.ProgressChanged += BackgroundWorkerLoadingDatabase_ProgressChanged;
			backgroundWorkerLoadingDatabase.RunWorkerCompleted += BackgroundWorkerLoadingDatabase_RunWorkerCompleted;
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
			string filename = !string.IsNullOrEmpty(value: MpcOrbDatFilePath) ? MpcOrbDatFilePath : filenameMpcorb; // Get the file name from the path
			FileInfo fileInfo = new(fileName: filename);
			long fileSize = fileInfo.Length, fileSizeRead = 0; // Get the size of the file in bytes
															   // Open the file stream for reading
			using (FileStream fileStream = new(path: filename, mode: FileMode.Open))
			{
				// Create a new instance of the PlanetoidDatabase class
				StreamReader streamReader = new(stream: fileStream);
				// Show the splash screen
				formSplashScreen.Show();
				while (streamReader.Peek() != -1 && !backgroundWorkerLoadingDatabase.CancellationPending)
				{
					string? readLine = streamReader.ReadLine(); // Variable to store the read line from the file
					if (readLine != null)
					{
						fileSizeRead += readLine.Length;
					}
					// ReSharper disable once PossibleLossOfFraction
					float percent = 100 * fileSizeRead / fileSize; // Variable to store the percentage of the file read
																   // Report progress to the background worker
					formSplashScreen.SetProgressbar(value: (int)percent);
					lineNum++;
					// Check if the line number is greater than or equal to 44
					if ((lineNum >= 44) && (!string.IsNullOrEmpty(value: readLine)))
					{
						// Add the read line to the planetoids database
						_ = planetoidsDatabase.Add(value: readLine);
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
		private static void BackgroundWorkerLoadingDatabase_ProgressChanged(object? sender, ProgressChangedEventArgs e)
		{
			//MessageBox.Show(text: e.ProgressPercentage.ToString());
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the RunWorkerCompleted event of the BackgroundWorker for loading the database.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance that contains the event data.</param>
		private void BackgroundWorkerLoadingDatabase_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
		{
			toolStripTextBoxGotoIndex.Text = 1.ToString(); // Set the initial value of the goto index text box
			currentPosition = 0; // Set the current position to the first record
			stepPosition = 100; // Set the step position to 100
			GotoCurrentPosition(position: currentPosition); // Navigate to the current position
			Enabled = true; // Enable the form
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
		private async void ToolStripStatusLabelUpdate_Click(object sender, EventArgs e)
		{
			// Check if the user wants to download the latest MPCORB.DAT file
			if (MessageBox.Show(text: I10nStrings.AskForDownloadingLatestMpcorbDatFile,
					caption: I10nStrings.AskForDownloadingLatestMpcorbDatFileCaption, buttons: MessageBoxButtons.YesNo,
					icon: MessageBoxIcon.Question) != DialogResult.Yes)
			{
				// User chose not to download the file, so we exit the method
				return;
			}

			// Start the download process
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

			downloadCancellationTokenSource = new CancellationTokenSource();

			try
			{
				// Define the URI for the MPCORB.DAT.gz file
				// Use HttpClient to download the file asynchronously
				using (HttpResponseMessage response = await httpClient.GetAsync(requestUri: uriMpcorb, completionOption: HttpCompletionOption.ResponseHeadersRead))
				{
					// Ensure the response indicates success
					_ = response.EnsureSuccessStatusCode();
					// Get the total number of bytes to download
					long totalBytes = response.Content.Headers.ContentLength ?? -1L;
					// Open the content stream for reading
					using Stream contentStream = await response.Content.ReadAsStreamAsync();
					// Create a file stream for writing the downloaded file
					using FileStream fileStream = new(path: Settings.Default.systemFilenameMpcorbTemp, mode: FileMode.Create, access: FileAccess.Write, share: FileShare.None, bufferSize: 8192, useAsync: true);
					// Buffer for reading data
					byte[] buffer = new byte[8192];
					// Variables to track progress
					long totalRead = 0;
					int read;
					// Set the progress bar style based on whether totalBytes is known
					toolStripProgressBarBackgroundDownload.Style = totalBytes > 0 ? ProgressBarStyle.Continuous : ProgressBarStyle.Marquee;
					// Read the content stream in chunks and write to the file stream
					while ((read = await contentStream.ReadAsync(buffer)) > 0)
					{
						// Check if the download has been cancelled
						await fileStream.WriteAsync(buffer: buffer.AsMemory(start: 0, length: read));
						totalRead += read;
						// Update progress if totalBytes is known
						if (totalBytes > 0)
						{
							int percent = (int)(totalRead * 100 / totalBytes);
							// Update the progress bar value
							toolStripProgressBarBackgroundDownload.Value = Math.Min(percent, 100);
							// Set the taskbar progress value
							TaskbarProgress.SetValue(windowHandle: Handle, progressValue: percent, progressMax: 100);
						}
					}
				}
				// Replace the old MPCORB.DAT file with the newly downloaded one
				File.Delete(path: filenameMpcorb);
				// Set the progress bar style to Marquee to indicate processing
				toolStripProgressBarBackgroundDownload.Style = ProgressBarStyle.Marquee;
				// Extract the downloaded GZIP file
				ExtractGzipFile(gzipFilePath: filenameMpcorbTemp, outputFilePath: Settings.Default.systemFilenameMpcorb);
				// Delete the temporary GZIP file
				File.Delete(path: filenameMpcorbTemp);
				// Notify the user that the update was successful
				AskForRestartAfterDownloadingDatabase();
			}
			catch (OperationCanceledException)
			{
				// Handle the cancellation of the download process
				toolStripStatusLabelBackgroundDownload.Enabled = false;
				toolStripProgressBarBackgroundDownload.Enabled = false;
				toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
				toolStripStatusLabelBackgroundDownload.Visible = false;
				toolStripProgressBarBackgroundDownload.Visible = false;
				toolStripStatusLabelCancelBackgroundDownload.Visible = false;
				File.Delete(path: filenameMpcorbTemp);
				_ = MessageBox.Show(text: "Download cancelled", caption: "Cancel", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				// Handle any errors that occur during the download process
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
				File.Delete(path: filenameMpcorbTemp);
			}
			// Reset the UI elements after the download process
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
			// Reset the taskbar progress
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
		private void SetStatusBar_Enter(object sender, EventArgs e)
		{
			// Set the status bar text based on the sender's accessible description
			switch (sender)
			{
				// If the sender is a control with an accessible description, set the status bar text
				// If the sender is a ToolStripItem with an accessible description, set the status bar text
				case Control { AccessibleDescription: not null } control:
					SetStatusBar(text: control.AccessibleDescription);
					break;
				case ToolStripItem { AccessibleDescription: not null } item:
					SetStatusBar(text: item.AccessibleDescription);
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
		private void ClearStatusBar_Leave(object sender, EventArgs e) => ClearStatusBar();

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
				Logger.Error(message: ex.Message);
				// Show an error message box with the exception message
				ShowErrorMessage(message: $"{nameof(ToolStripButtonGoToIndex_Click)}  {ex.Message}");
				_ = MessageBox.Show(text: ex.Message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			// If the parsed index is out of range, show an error message
			// Otherwise, navigate to the specified index
			if (pos <= 0 || pos >= planetoidsDatabase.Count + 1)
			{
				// Log the error message
				Logger.Error(message: "Index out of range");
				// Show an error message if the index is out of range
				ShowErrorMessage(message: $"{I10nStrings.IndexOutOfRange}");
			}
			else
			{
				// Navigate to the specified index
				currentPosition = pos - 1;
				GotoCurrentPosition(position: currentPosition);
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

		private void ToolStripStatusLabelCancelBackgroundDownload_Click(object sender, EventArgs e)
		{
			// Download abbrechen
			toolStripStatusLabelBackgroundDownload.Enabled = false;
			toolStripProgressBarBackgroundDownload.Enabled = false;
			toolStripStatusLabelCancelBackgroundDownload.Enabled = false;
			toolStripStatusLabelBackgroundDownload.Visible = false;
			toolStripProgressBarBackgroundDownload.Visible = false;
			toolStripStatusLabelCancelBackgroundDownload.Visible = false;
			downloadCancellationTokenSource?.Cancel();
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
		private void MenuitemOpenWebsitePDB_Click(object sender, EventArgs e) => Process.Start(fileName: Settings.Default.systemHomepage);

		/// <summary>
		/// Handles the click event for the MenuitemOpenWebsiteMPC.
		/// Opens the Minor Planet Center website.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemOpenWebsiteMPC_Click(object sender, EventArgs e) => Process.Start(fileName: Settings.Default.systemWebsiteMpc);

		/// <summary>
		/// Handles the click event for the MenuitemOpenMPCORBWebsite.
		/// Opens the MPCORB website.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemOpenMPCORBWebsite_Click(object sender, EventArgs e) => Process.Start(fileName: Settings.Default.systemWebsiteMpcorb);

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
		private void ToolStripButtonOpenWebsitePDB_Click(object sender, EventArgs e) => Process.Start(fileName: Settings.Default.systemHomepage);

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
		/// Handles the click event for the ToolStripButtonDerivativeOrbitElements.
		/// Shows the derived orbit elements form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonDerivativeOrbitElements_Click(object sender, EventArgs e) => ShowDerivativeOrbitElements();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemRestart.
		/// Restarts the application.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemRestart_Click(object sender, EventArgs e) => Restart();

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemDerivativeOrbitElements.
		/// Shows the derived orbit elements form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDerivativeOrbitElements_Click(object sender, EventArgs e) => ShowDerivativeOrbitElements();

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
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemEnableLinkingToTerminology.
		/// Enables linking to terminology.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemEnableLinkingToTerminology_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemIconSetSilk.
		/// Sets the icon set to Silk.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemIconSetSilk_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemIconSetFugue.
		/// Sets the icon set to Fugue.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemIconSetFugue_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the ToolStripMenuItemIconSetFatcow.
		/// Sets the icon set to Fatcow.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void ToolStripMenuItemIconSetFatcow_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
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
		/// Handles the button click event for the SplitButtonTopTenRecords.
		/// Shows the records selection form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SplitButtonTopTenRecords_ButtonClick(object sender, EventArgs e) => ShowRecordsSelection();

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
		/// Handles the click event for the MenuitemRecordsComputerName.
		/// Shows the main records form for computer name.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemRecordsComputerName_Click(object sender, EventArgs e) => ShowRecordsMain();

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
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionArgumentOfPerihelion.
		/// Shows the distribution form for argument of perihelion.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionArgumentOfPerihelion_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionLongitudeOfTheAscendingNode.
		/// Shows the distribution form for longitude of the ascending node.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionLongitudeOfTheAscendingNode_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionInclination.
		/// Shows the distribution form for inclination.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionInclination_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionOrbitalEccentricity.
		/// Shows the distribution form for orbital eccentricity.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionOrbitalEccentricity_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionMeanDailyMotion.
		/// Shows the distribution form for mean daily motion.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionMeanDailyMotion_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionSemiMajorAxis.
		/// Shows the distribution form for semi-major axis.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionSemiMajorAxis_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionAbsoluteMagnitude.
		/// Shows the distribution form for absolute magnitude.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionAbsoluteMagnitude_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionSlopeParameter.
		/// Shows the distribution form for slope parameter.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionSlopeParameter_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionNumberOfOppositions.
		/// Shows the distribution form for number of oppositions.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionNumberOfOppositions_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionNumberOfObservations.
		/// Shows the distribution form for number of observations.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionNumberOfObservations_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionObservationSpan.
		/// Shows the distribution form for observation span.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionObservationSpan_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionRmsResidual.
		/// Shows the distribution form for RMS residual.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionRmsResidual_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistributionComputerName.
		/// Shows the distribution form for computer name.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistributionComputerName_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the button click event for the SplitButtonDistribution.
		/// Shows the distribution form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void SplitButtonDistribution_ButtonClick(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the click event for the MenuitemDistribution.
		/// Shows the distribution form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private static void MenuitemDistribution_Click(object sender, EventArgs e)
		{
			// TODO: Not implemented yet
			MessageBox.Show(text: "Not implemented yet", caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
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