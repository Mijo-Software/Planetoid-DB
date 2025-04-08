using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using NLog;

namespace Planetoid_DB
{
	internal static class Program
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
		private const int SET_FEATURE_ON_THREAD = 0x00000001;
		private const int SET_FEATURE_ON_PROCESS = 0x00000002;
		private const int SET_FEATURE_IN_REGISTRY = 0x00000004;
		private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;
		private const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;
		private const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;
		private const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;
		private const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;

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
			try
			{
				DisableNavigationSounds();
				ApplicationConfiguration.Initialize();

				if (!File.Exists(path: Properties.Resources.FilenameMpcorb))
				{
					HandleMissingFile();
				}
				else
				{
					Application.Run(mainForm: new PlanetoidDBForm());
				}
			}
			catch (FileNotFoundException ex)
			{
				Logger.Error(exception: ex, message: "File not found");
				ShowErrorMessage(message: $"File not found: {ex.Message}");
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			catch (NetworkInformationException ex)
			{
				Logger.Error(exception: ex, message: "network error");
				ShowErrorMessage(message: $"network error: {ex.Message}");
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			catch (Exception ex)
			{
				Logger.Error(exception: ex, message: "An unexpected error occurred.");
				ShowErrorMessage(message: $"An unexpected error occurred: {ex.Message}");
				Environment.Exit(exitCode: Environment.ExitCode);
			}
			finally
			{
				LogManager.Shutdown();
			}
		}

		/// <summary>
		/// Disables the navigation sounds.
		/// </summary>
		private static void DisableNavigationSounds()
		{
			_ = CoInternetSetFeatureEnabled(FeatureEntry: FEATURE_DISABLE_NAVIGATION_SOUNDS, dwFlags: SET_FEATURE_ON_PROCESS, fEnable: true);
		}

		/// <summary>
		/// Handles the case when the file is missing.
		/// </summary>
		private static void HandleMissingFile()
		{
			using PreloaderForm formPreloader = new();

			if (formPreloader.ShowDialog() == DialogResult.Cancel)
			{
				Environment.Exit(exitCode: Environment.ExitCode);
			}
		}

		/// <summary>
		/// Displays an error message.
		/// </summary>
		/// <param name="message">The error message.</param>
		private static void ShowErrorMessage(string message)
		{
			_ = MessageBox.Show(text: message, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}
	}
}
