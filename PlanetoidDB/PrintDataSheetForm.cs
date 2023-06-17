using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class PrintDataSheetForm : KryptonForm
	{
		#region Local methods

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void SetStatusbar(string text)
		{
			if (!string.IsNullOrEmpty(value: text))
			{
				labelInformation.Enabled = true;
				labelInformation.Text = text;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void ClearStatusbar()
		{
			labelInformation.Enabled = false;
			labelInformation.Text = string.Empty;
		}

		#endregion

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public PrintDataSheetForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Form* event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PrintDataSheetForm_Load(object sender, EventArgs e)
		{
			if (checkedListBoxOrbitalElements.Items.Count != 0)
			{
				for (int i = 0; i < checkedListBoxOrbitalElements.Items.Count; i++)
				{
					checkedListBoxOrbitalElements.SetItemChecked(index: i, value: true);
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PrintDataSheetForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#endregion

		#region Enter event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox box:
					SetStatusbar(text: box.AccessibleDescription);
					break;
				case Button button:
					SetStatusbar(text: button.AccessibleDescription);
					break;
				case RadioButton buttonRadio:
					SetStatusbar(text: buttonRadio.AccessibleDescription);
					break;
				case CheckBox boxCheck:
					SetStatusbar(text: boxCheck.AccessibleDescription);
					break;
				case DateTimePicker picker:
					SetStatusbar(text: picker.AccessibleDescription);
					break;
				case Label label:
					SetStatusbar(text: label.AccessibleDescription);
					break;
				case PictureBox boxPicture:
					SetStatusbar(text: boxPicture.AccessibleDescription);
					break;
				case ToolStripButton buttonToolStrip:
					SetStatusbar(text: buttonToolStrip.AccessibleDescription);
					break;
				case ToolStripMenuItem item:
					SetStatusbar(text: item.AccessibleDescription);
					break;
				case ToolStripLabel labelToolStrip:
					SetStatusbar(text: labelToolStrip.AccessibleDescription);
					break;
				case ToolStripComboBox boxToolStripCombo:
					SetStatusbar(text: boxToolStripCombo.AccessibleDescription);
					break;
				case ToolStripDropDown downToolStripDrop:
					SetStatusbar(text: downToolStripDrop.AccessibleDescription);
					break;
				case ToolStripDropDownButton buttonToolStripDropDown:
					SetStatusbar(text: buttonToolStripDropDown.AccessibleDescription);
					break;
				case ToolStripDropDownItem itemToolStripDropDown:
					SetStatusbar(text: itemToolStripDropDown.AccessibleDescription);
					break;
				case ToolStripProgressBar bar:
					SetStatusbar(text: bar.AccessibleDescription);
					break;
				case ToolStripSeparator separator:
					SetStatusbar(text: separator.AccessibleDescription);
					break;
				case ToolStripTextBox boxToolStripText:
					SetStatusbar(text: boxToolStripText.AccessibleDescription);
					break;
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonPrintDataSheet_Click(object sender, EventArgs e)
		{
			using (PrintDialog dialogPrint = new PrintDialog())
			{
				PrintDocument printDoc = new PrintDocument
				{
					DocumentName = "Data sheet"
				};
				dialogPrint.Document = printDoc;
				dialogPrint.AllowSelection = true;
				dialogPrint.AllowSomePages = true;
				if (dialogPrint.ShowDialog() == DialogResult.OK)
				{
					printDoc.Print();
					Close();
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancelPrint_Click(object sender, EventArgs e) => Close();

		private string GetDebuggerDisplay()
		{
			return ToString();
		}

		#endregion

	}
}
