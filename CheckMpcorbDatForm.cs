using System.Diagnostics;
using System.IO;
using System.Net.Http;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// MPCORB Data Verification Form.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class CheckMpcorbDatForm : KryptonForm
	{
		/// <summary>
		/// The HttpClient instance used for making HTTP requests.
		/// </summary>
		private static readonly HttpClient client = new();

		// Indicates whether the application is currently busy.
		private bool isBusy = false;

		#region constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="CheckMpcorbDatForm"/> class.
		/// </summary>
		public CheckMpcorbDatForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(CheckMpcorbDatForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		#endregion

		#region local methods

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

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
		private void SetStatusbar(string text, string additionalInfo = "")
		{
			if (!string.IsNullOrWhiteSpace(value: text))
			{
				labelInformation.Enabled = true;
				labelInformation.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
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

		#endregion

		#region Task methods

		/// <summary>
		/// Retrieves the last modified date of the specified URI.
		/// </summary>
		/// <param name="uri">The URI of the resource.</param>
		/// <returns>The date of the last modification or <see cref="DateTime.MinValue"/> in case of an error.</returns>
		private static async Task<DateTime> GetLastModifiedAsync(Uri uri)
		{
			try
			{
				HttpResponseMessage response = await client.SendAsync(request: new HttpRequestMessage(method: HttpMethod.Head, requestUri: uri)).ConfigureAwait(false);
				return response.IsSuccessStatusCode ? response.Content.Headers.LastModified?.UtcDateTime ?? DateTime.MinValue : DateTime.MinValue;
			}
			catch (HttpRequestException)
			{
				return DateTime.MinValue;
			}
		}

		/// <summary>
		/// The content length of the specified URI.
		/// </summary>
		/// <param name="uri">The URI of the resource.</param>
		/// <returns>The content length or 0 in case of error.</returns>
		private static async Task<long> GetContentLengthAsync(Uri uri)
		{
			try
			{
				HttpResponseMessage response = await client.SendAsync(request: new HttpRequestMessage(method: HttpMethod.Head, requestUri: uri)).ConfigureAwait(false);
				return response.IsSuccessStatusCode ? response.Content.Headers.ContentLength ?? 0 : 0;
			}
			catch (HttpRequestException)
			{
				return 0;
			}
		}

		#endregion

		#region form event handler

		/// <summary>
		/// Event handler for loading the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private async void CheckMpcorbDatForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			isBusy = true;
			Uri uriMPCORB = new(uriString: Properties.Settings.Default.systemMpcorbDatUrl);
			DateTime datetimeFileLocal = DateTime.MinValue;
			DateTime datetimeFileOnline = await GetLastModifiedAsync(uri: uriMPCORB).ConfigureAwait(continueOnCapturedContext: false);

			if (!File.Exists(path: Properties.Resources.FilenameMpcorb))
			{
				labelContentLengthValueLocal.Text = I10nStrings.NoFileFoundText;
				labelModifiedDateValueLocal.Text = I10nStrings.NoFileFoundText;
			}
			else
			{
				FileInfo fileInfo = new(fileName: Properties.Resources.FilenameMpcorb);
				datetimeFileLocal = fileInfo.LastWriteTime;
				labelContentLengthValueLocal.Text = $"{fileInfo.Length} {I10nStrings.BytesText}";
				labelModifiedDateValueLocal.Text = datetimeFileLocal.ToString();
			}

			labelContentLengthValueOnline.Text = $"{await GetContentLengthAsync(uri: uriMPCORB).ConfigureAwait(continueOnCapturedContext: false)} {I10nStrings.BytesText}";
			labelModifiedDateValueOnline.Text = datetimeFileOnline.ToString();

			if (datetimeFileOnline > datetimeFileLocal)
			{
				labelUpdateNeeded.Values.Image = Properties.Resources.silk_new;
				labelUpdateNeeded.Text = I10nStrings.UpdateRecommendedText;
			}
			else
			{
				labelUpdateNeeded.Values.Image = Properties.Resources.silk_decline;
				labelUpdateNeeded.Text = I10nStrings.NoUpdateNeededText;
			}
			isBusy = false;
		}

		/// <summary>
		/// Event handler for closing the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void CheckMpcorbDatForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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

		#region double-click event handlers

		/// <summary>
		/// Event handler for double-clicking a control to copy the text to the clipboard.
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
		/// Event handler for double-clicking the "Update Needed" label to check for updates.
		/// Resets the displayed information and reloads the form data.
		/// </summary>
		/// <param name="sender">The event source, typically the label being double-clicked.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LabelUpdateNeeded_DoubleClick(object sender, EventArgs e)
		{
			ArgumentNullException.ThrowIfNull(argument: sender);
			labelContentLengthValueLocal.Text = string.Empty;
			labelModifiedDateValueLocal.Text = string.Empty;
			labelContentLengthValueOnline.Text = string.Empty;
			labelModifiedDateValueOnline.Text = string.Empty;
			labelUpdateNeeded.Text = string.Empty;
			labelUpdateNeeded.Values.Image = null;
			CheckMpcorbDatForm_Load(sender: sender, e: e);
		}


		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void CheckMpcorbDatForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (!isBusy && e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}
