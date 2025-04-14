using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using Krypton.Toolkit;
using NLog;
using Planetoid_DB.Properties;

namespace Planetoid_DB
{
	/// <summary>
	/// A form that gets the file MPCORB.DAT.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class PreloaderForm : KryptonForm
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger(); // NLog logger instance

		#region constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="AppInfoForm"/> class.
		/// </summary>

		public PreloaderForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += new KeyEventHandler(PreloaderForm_KeyDown);
			KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region Helpers

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
		/// Extracts an embedded resource from the assembly and writes it to a specified output directory.
		/// </summary>
		/// <param name="nameSpace">The namespace where the resource is located.</param>
		/// <param name="outDir">The output directory where the resource will be written.</param>
		/// <param name="internFilePath">The internal file path within the namespace (optional).</param>
		/// <param name="resourceName">The name of the resource to extract.</param>
		/// <exception cref="FileNotFoundException">Thrown if the specified resource is not found in the assembly.</exception>
		private static void ExtractResource(string nameSpace, string outDir, string internFilePath, string resourceName)
		{
			// Get the assembly and the resource path
			Assembly assembly = Assembly.GetExecutingAssembly();
			// Construct the resource path
			string resourcePath = $"{nameSpace}.{(string.IsNullOrEmpty(value: internFilePath) ? "" : internFilePath + ".")}{resourceName}";
			// Open the resource stream and read the bytes
			using Stream? s = assembly.GetManifestResourceStream(name: resourcePath) ?? throw new FileNotFoundException(message: $"Resource '{resourcePath}' not found in assembly.");
			// Create the output file stream
			using BinaryReader r = new(input: s);
			// Create the output file stream and write the bytes to it
			using FileStream fs = new(path: Path.Combine(outDir, resourceName), mode: FileMode.OpenOrCreate);
			// Ensure the file stream is writable
			using BinaryWriter w = new(output: fs);
			// Read the bytes from the resource stream and write them to the output file
			w.Write(buffer: r.ReadBytes(count: (int)s.Length));
		}

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
				logger.Error(exception: ex, message: "File not found");
				// Show an error message
				ShowErrorMessage(message: $"File not found: {ex.Message}");
				// Set the exit code to indicate an error
				Environment.ExitCode = 1;
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
		/// Gets the file path of the MPCORB.DAT file.
		/// </summary>
		[DesignerSerializationVisibility(visibility: DesignerSerializationVisibility.Hidden)]
		public string MpcOrbDatFilePath { get; set; } = string.Empty;

		#endregion

		#region form event handler

		/// <summary>
		/// Fired when the form loads.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PreloaderForm_Load(object sender, EventArgs e) => ClearStatusbar();

		/// <summary>
		/// Fired when the form closes.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void PreloaderForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Dispose();
			DialogResult = DialogResult.Cancel;
		}

		#endregion

		#region enter event handlers

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

		#region leave event handlers

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region click event handlers

		/// <summary>
		/// Handles the click event for opening a local MPCORB.DAT file.
		/// Prompts the user with a file dialog to select a file and sets the file path if a file is selected.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void KryptonCommandLinkButtonOpenLocalFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_ = MpcOrbDatFilePath = openFileDialog.FileName.ToString();
				DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		/// Handles the click event for downloading the MPCORB.DAT file.
		/// Checks for an active internet connection and opens a download form.
		/// Sets the file path if the download is successful.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void KryptonCommandLinkButtonDownloadMprcorbDat_Click(object sender, EventArgs e)
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				ShowErrorMessage(message: I10nStrings.NoInternetConnectionText);
			}
			else
			{
				using DownloadMpcorbDatForm formDownloaderForMpcorbDat = new();
				if (formDownloaderForMpcorbDat.ShowDialog() == DialogResult.OK)
				{
					_ = MpcOrbDatFilePath = Resources.FilenameMpcorb;
					DialogResult = DialogResult.OK;
				}
			}
		}

		/// <summary>
		/// Handles the click event for loading internal demo data.
		/// Extracts a demo data file from embedded resources and sets the file path to the extracted file.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void KryptonCommandLinkButtonLoadInternalDemoData_Click(object sender, EventArgs e)
		{
			ExtractResource(nameSpace: "Planetoid_DB", outDir: "", internFilePath: "Resources", resourceName: "demoset-10000.txt");
			_ = MpcOrbDatFilePath = "demoset-10000.txt";
			DialogResult = DialogResult.OK;
		}

		#endregion

		#region double-click event handler

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

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the PreloaderForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PreloaderForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		#endregion
	}
}
