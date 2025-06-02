﻿using System.Diagnostics;
using System.IO;
using System.Reflection;
using Krypton.Toolkit;
using NLog;

namespace Planetoid_DB
{
	/// <summary>
	/// A form that displays application information.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class LicenseForm : KryptonForm
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger(); // NLog logger instance

		#region constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="AppInfoForm"/> class.
		/// </summary>

		public LicenseForm()
		{
			// Initialize the form components
			InitializeComponent();
			KeyDown += LicenseForm_KeyDown;
			KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region helper methods

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
			// Check if the output directory exists, if not create it
			if (!Directory.Exists(path: outDir))
			{
				_ = Directory.CreateDirectory(path: outDir);
			}
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

		#endregion

		#region form event handler

		/// <summary>
		/// Fired when the form loads.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LicenseForm_Load(object sender, EventArgs e) => ClearStatusbar();

		/// <summary>
		/// Fired when the form closes.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void LicenseForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region enter event handlers

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			// Check if the sender is a control and has an accessible description
			if (sender is Control control && control.AccessibleDescription != null)
			{
				// Set the status bar text to the control's accessible description
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
		/// Saves the license to a file.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void KryptonButtonSaveLicense_Click(object sender, EventArgs e)
		{
			// Create a SaveFileDialog to prompt the user for a file location
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Get the selected file name
				string fullFileName = saveFileDialog.FileName;
				// Extract the LICENSE file from the embedded resources and copy it to the selected file location
				ExtractResource(nameSpace: "Planetoid_DB", outDir: Path.GetDirectoryName(path: fullFileName) ?? string.Empty, internFilePath: "", resourceName: "LICENSE");
				// Copy the LICENSE file to the selected file location
				File.Copy(sourceFileName: Path.Combine(Path.GetDirectoryName(path: fullFileName) ?? string.Empty, "LICENSE"), destFileName: fullFileName, overwrite: true);
				// Set the status bar text to indicate that the file has been saved
				File.Delete(path: Path.Combine(Path.GetDirectoryName(path: fullFileName) ?? string.Empty, "LICENSE"));
			}
		}

		private void KryptonButtonCopyLicenseToClipboard_Click(object sender, EventArgs e) =>
			// Copy the text from the KryptonTextBox to the clipboard
			CopyToClipboard(text: kryptonTextBoxLicense.Text);

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the LicenseForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LicenseForm_KeyDown(object? sender, KeyEventArgs e)
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
