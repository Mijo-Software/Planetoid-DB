using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using NLog;

namespace Planetoid_DB
{
	internal static class Program
	{
		// Logger instance for logging errors
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21; // Feature ID for disabling navigation sounds
		private const int SET_FEATURE_ON_THREAD = 0x00000001; // Set the feature on the current thread
		private const int SET_FEATURE_ON_PROCESS = 0x00000002; // Set the feature on the current process
		private const int SET_FEATURE_IN_REGISTRY = 0x00000004; // Set the feature in the registry
		private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008; // Set the feature on the current thread for local machine
		private const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010; // Set the feature on the current thread for intranet
		private const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020; // Set the feature on the current thread for trusted sites
		private const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040; // Set the feature on the current thread for internet
		private const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080; // Set the feature on the current thread for restricted sites

		/// <summary>
		/// Disables navigation sounds.
		/// </summary>
		/// <param name="FeatureEntry">The feature ID.</param>
		/// <param name="dwFlags">The flags.</param>
		/// <param name="fEnable">Specifies whether the feature should be enabled or disabled.</param>
		/// <returns>An HRESULT value indicating success or failure.</returns>
		[DllImport(dllName: "urlmon.dll")]
		[PreserveSig]
		[return: MarshalAs(unmanagedType: UnmanagedType.Error)]
		private static extern int CoInternetSetFeatureEnabled(int FeatureEntry, [MarshalAs(unmanagedType: UnmanagedType.U4)] int dwFlags, bool fEnable);

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			// Try to set the application to use the default font settings
			try
			{
				// Disable navigation sounds
				DisableNavigationSounds();
				// Initialize the application configuration
				ApplicationConfiguration.Initialize();

				if (!File.Exists(path: Properties.Resources.FilenameMpcorb))
				{
					// Show the preloader form if the file is missing
					HandleMissingFile();
				}
				else
				{
					// Start the main form
					Application.Run(mainForm: new PlanetoidDBForm());
				}
			}
			// Catch specific exceptions and handle them accordingly
			catch (UnauthorizedAccessException ex)
			{
				// Log the error and show a message box
				Logger.Error(exception: ex, message: "Access denied");
				ShowErrorMessage(message: $"Access denied: {ex.Message}");
				// Exit the application with a non-zero exit code
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			catch (FileNotFoundException ex)
			{
				// Log the error and show a message box
				Logger.Error(exception: ex, message: "File not found");
				ShowErrorMessage(message: $"File not found: {ex.Message}");
				// Exit the application with a non-zero exit code
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			catch (IOException ex)
			{
				// Log the error and show a message box
				Logger.Error(exception: ex, message: "I/O error");
				ShowErrorMessage(message: $"I/O error: {ex.Message}");
				// Exit the application with a non-zero exit code
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			catch (NetworkInformationException ex)
			{
				// Log the error and show a message box
				Logger.Error(exception: ex, message: "network error");
				ShowErrorMessage(message: $"network error: {ex.Message}");
				// Exit the application with a non-zero exit code
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			catch (Exception ex)
			{
				// Log the error and show a message box
				Logger.Error(exception: ex, message: "An unexpected error occurred.");
				ShowErrorMessage(message: $"An unexpected error occurred: {ex.Message}");
				// Exit the application with a non-zero exit code
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			finally
			{
				// Ensure that the logger is properly shut down
				LogManager.Shutdown();
			}
		}

		/// <summary>
		/// Disables the navigation sounds.
		/// </summary>
		private static void DisableNavigationSounds() =>
			// Disable navigation sounds for the current process
			_ = CoInternetSetFeatureEnabled(FeatureEntry: FEATURE_DISABLE_NAVIGATION_SOUNDS, dwFlags: SET_FEATURE_ON_PROCESS, fEnable: true);

		/// <summary>
		/// Handles the case when the file is missing.
		/// </summary>
		private static void HandleMissingFile()
		{
			// Create an instance of the preloader form
			using PreloaderForm formPreloader = new();
			// Show the preloader form
			_ = formPreloader.ShowDialog();
			// Check if the form is exited with a cancel result
			if (formPreloader.DialogResult == DialogResult.Cancel)
			{
				// Exit the application with a non-zero exit code
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			// Check if the file path is empty
			if (string.IsNullOrEmpty(value: formPreloader.MpcOrbDatFilePath))
			{
				// Show an error message if the file path is empty
				Logger.Error(message: "File not found");
				ShowErrorMessage(message: "File not found");
				// Exit the application with a non-zero exit code
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			else
			{
				// Start the main form with the specified file path
				Application.Run(mainForm: new PlanetoidDBForm(mpcorbDatFilePath: formPreloader.MpcOrbDatFilePath));
			}
		}

		/// <summary>
		/// Displays an error message.
		/// </summary>
		/// <param name="message">The error message.</param>
		private static void ShowErrorMessage(string message) =>
			// Log the error message
			_ = MessageBox.Show(text: message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
	}
}
