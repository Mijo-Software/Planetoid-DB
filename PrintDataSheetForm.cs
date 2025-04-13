using System.Diagnostics;
using System.Drawing.Printing;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// Represents a form for printing data sheets.
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class PrintDataSheetForm : KryptonForm
	{
		private readonly PrintDocument printDoc;

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="PrintDataSheetForm"/> class.
		/// </summary>
		public PrintDataSheetForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(PrintDataSheetForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
			printDoc = new PrintDocument();
			printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);
		}

		#endregion

		#region Local methods

		/// <summary>
		/// Returns a string representation of the object for the debugger.
		/// </summary>
		/// <returns>A string representation of the object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Sets the status bar text.
		/// </summary>
		/// <param name="text">The main text to be displayed on the status bar.</param>
		/// <param name="additionalInfo">Additional information to be displayed alongside the main text.</param>
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

		#endregion

		#region Form event handlers

		/// <summary>
		/// Handles the Load event of the form.
		/// Checks all items in the checked list box when the form loads.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PrintDataSheetForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (checkedListBoxOrbitalElements.Items.Count != 0)
			{
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					checkedListBoxOrbitalElements.SetItemChecked(index: i, value: true);
				}
			}
		}

		/// <summary>
		/// Handles the FormClosed event of the form.
		/// Disposes the form when it is closed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance that contains the event data.</param>
		private void PrintDataSheetForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// Sets the status bar text to the control's accessible description.
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

		#region Leave event handlers

		/// <summary>
		/// Called when the mouse pointer leaves a control.
		/// Clears the status bar text.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click event handlers

		/// <summary>
		/// Handles the Click event of the print button.
		/// Opens a print dialog and prints the document if the user confirms.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonPrintDataSheet_Click(object sender, EventArgs e)
		{
			using PrintDialog dialogPrint = new();
			dialogPrint.Document = printDoc;
			dialogPrint.AllowSelection = true;
			dialogPrint.AllowSomePages = true;
			if (dialogPrint.ShowDialog() == DialogResult.OK)
			{
				try
				{
					printDoc.Print();
				}
				catch (Exception ex)
				{
					_ = MessageBox.Show(text: $"Error while printing: {ex.Message}", caption: "Printing error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				}
				Close();
			}
		}

		/// <summary>
		/// Handles the Click event of the cancel button.
		/// Closes the form without printing.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCancelPrint_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// Handles the Click event of the print preview button.
		/// Opens a print preview dialog to preview the document before printing.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonPrintPreview_Click(object sender, EventArgs e)
		{
			using PrintPreviewDialog previewDialog = new();
			previewDialog.Document = printDoc;
			_ = previewDialog.ShowDialog();
		}

		/// <summary>
		/// Handles the Click event of the page setup button.
		/// Opens a page setup dialog to configure page settings.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonPageSetup_Click(object sender, EventArgs e)
		{
			using PageSetupDialog pageSetupDialog = new();
			pageSetupDialog.Document = printDoc;
			pageSetupDialog.PageSettings = printDoc.DefaultPageSettings;
			pageSetupDialog.PrinterSettings = printDoc.PrinterSettings;
			if (pageSetupDialog.ShowDialog() == DialogResult.OK)
			{
				printDoc.DefaultPageSettings = pageSetupDialog.PageSettings;
			}
		}

		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the PrintDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void PrintDataSheetForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion

		#region PrintPage event handler

		/// <summary>
		/// Handles the PrintPage event of the PrintDocument.
		/// Configures the print settings and content.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="PrintPageEventArgs"/> instance that contains the event data.</param>
		private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
		{
			if (e.Graphics != null)
			{
				// Example: Draw a simple string on the document
				string textToPrint = "This is a sample data sheet.";
				Font printFont = new(familyName: "Arial", emSize: 12);
				e.Graphics.DrawString(s: textToPrint, font: printFont, brush: Brushes.Black, point: new PointF(x: 100, y: 100));

				// Indicate that no more pages are to be printed
				e.HasMorePages = false;
			}
		}

		#endregion
	}
}