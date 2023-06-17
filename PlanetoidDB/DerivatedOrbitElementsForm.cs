using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class DerivatedOrbitElementsForm : KryptonForm
	{
		private ArrayList derivatedOrbitElementsDatabase = new ArrayList(capacity: 0);

		#region Local methods

		/// <summary>
		/// 
		/// </summary>
		private void OpenTerminology(uint index)
		{
			using (TerminologyForm formTerminology = new TerminologyForm())
			{
				switch (index)
				{
					case 0: formTerminology.SetLabelLinearEccentricityActive(sender: null, e: null); break;
					case 1: formTerminology.SetLabelSemiMinorAxisActive(sender: null, e: null); break;
					case 2: formTerminology.SetLabelMajorAxisActive(sender: null, e: null); break;
					case 3: formTerminology.SetLabelMinorAxisActive(sender: null, e: null); break;
					case 4: formTerminology.SetLabelEccenctricAnomalyActive(sender: null, e: null); break;
					case 5: formTerminology.SetLabelTrueAnomalyActive(sender: null, e: null); break;
					case 6: formTerminology.SetLabelPerihelionDistanceActive(sender: null, e: null); break;
					case 7: formTerminology.SetLabelAphelionDistanceActive(sender: null, e: null); break;
					case 8: formTerminology.SetLabelLongitudeDescendingNodeActive(sender: null, e: null); break;
					case 9: formTerminology.SetLabelArgumentAphelionActive(sender: null, e: null); break;
					case 10: formTerminology.SetLabelFocalParameterActive(sender: null, e: null); break;
					case 11: formTerminology.SetLabelSemiLatusRectumActive(sender: null, e: null); break;
					case 12: formTerminology.SetLabelLatusRectumActive(sender: null, e: null); break;
					case 13: formTerminology.SetLabelPeriodActive(sender: null, e: null); break;
					case 14: formTerminology.SetLabelOrbitalAreaActive(sender: null, e: null); break;
					case 15: formTerminology.SetLabelOrbitalPerimeterActive(sender: null, e: null); break;
					case 16: formTerminology.SetLabelSemiMeanAxisActive(sender: null, e: null); break;
					case 17: formTerminology.SetLabelMeanAxisActive(sender: null, e: null); break;
					case 18: formTerminology.SetLabelStandardGravitationalParameterActive(sender: null, e: null); break;
					default: break;
				}
				formTerminology.ShowDialog();
			}
		}

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
			PropertyInfo aProp = typeof(Control).GetProperty(name: "DoubleBuffered", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance);
			aProp.SetValue(obj: control, value: true, index: null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(text: I10nStrings.CopiedToClipboard, caption: I10nStrings.InformationCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arrayList"></param>
		public void SetDatabase(ArrayList arrayList) => derivatedOrbitElementsDatabase = arrayList;

		#endregion

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public DerivatedOrbitElementsForm()
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
		private void DerivatedOrbitElementsForm_Load(object sender, EventArgs e)
		{
			SetDoubleBuffered(control: tableLayoutPanel);
			labelLinearEccentricityData.Text = derivatedOrbitElementsDatabase[index: 0].ToString();
			labelSemiMinorAxisData.Text = derivatedOrbitElementsDatabase[index: 1].ToString();
			labelMajorAxisData.Text = derivatedOrbitElementsDatabase[index: 2].ToString();
			labelMinorAxisData.Text = derivatedOrbitElementsDatabase[index: 3].ToString();
			labelEccentricAnomalyData.Text = derivatedOrbitElementsDatabase[index: 4].ToString();
			labelTrueAnomalyData.Text = derivatedOrbitElementsDatabase[index: 5].ToString();
			labelPerihelionDistanceData.Text = derivatedOrbitElementsDatabase[index: 6].ToString();
			labelAphelionDistanceData.Text = derivatedOrbitElementsDatabase[index: 7].ToString();
			labelLongitudeDescendingNodeData.Text = derivatedOrbitElementsDatabase[index: 8].ToString();
			labelArgumentAphelionData.Text = derivatedOrbitElementsDatabase[index: 9].ToString();
			labelFocalParameterData.Text = derivatedOrbitElementsDatabase[index: 10].ToString();
			labelSemiLatusRectumData.Text = derivatedOrbitElementsDatabase[index: 11].ToString();
			labelLatusRectumData.Text = derivatedOrbitElementsDatabase[index: 12].ToString();
			labelPeriodData.Text = derivatedOrbitElementsDatabase[index: 13].ToString();
			labelOrbitalAreaData.Text = derivatedOrbitElementsDatabase[index: 14].ToString();
			labelOrbitalPerimeterData.Text = derivatedOrbitElementsDatabase[index: 15].ToString();
			labelSemiMeanAxisData.Text = derivatedOrbitElementsDatabase[index: 16].ToString();
			labelMeanAxisData.Text = derivatedOrbitElementsDatabase[index: 17].ToString();
			labelStandardGravitationalParameterData.Text = derivatedOrbitElementsDatabase[index: 18].ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DerivatedOrbitElementsForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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
		private void ButtonOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelLinearEccentricity_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 0);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelSemiMinorAxis_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 1);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelMajorAxis_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 2);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelMinorAxis_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 3);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelEccenctricAnomaly_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 4);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelTrueAnomaly_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 5);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelPerihelionDistance_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 6);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelAphelionDistance_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 7);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelLongitudeDescendingNode_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 8);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelArgumentAphelion_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 9);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelFocalParameter_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 10);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelSemiLatusRectum_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 11);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelLatusRectum_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 12);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelPeriod_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 13);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelOrbitalArea_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 14);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelOrbitalPerimeter_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 15);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelSemiMeanAxis_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 16);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelMeanAxis_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 17);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelStandardGravitationalParameterDesc_Clicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenTerminology(index: 18);

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox box:
					CopyToClipboard(text: box.Text);
					break;
				case Button button:
					CopyToClipboard(text: button.Text);
					break;
				case RadioButton buttonRadio:
					CopyToClipboard(text: buttonRadio.Text);
					break;
				case CheckBox boxCheck:
					CopyToClipboard(text: boxCheck.Text);
					break;
				case DateTimePicker pickerDateTime:
					CopyToClipboard(text: pickerDateTime.Text);
					break;
				case Label label:
					CopyToClipboard(text: label.Text);
					break;
				case ToolStripButton buttonToolStrip:
					CopyToClipboard(text: buttonToolStrip.Text);
					break;
				case ToolStripMenuItem itemToolStripMenu:
					CopyToClipboard(text: itemToolStripMenu.Text);
					break;
				case ToolStripLabel labelToolStrip:
					CopyToClipboard(text: labelToolStrip.Text);
					break;
				case ToolStripComboBox boxToolStripCombo:
					CopyToClipboard(text: boxToolStripCombo.Text);
					break;
				case ToolStripDropDown downToolStripDrop:
					CopyToClipboard(text: downToolStripDrop.Text);
					break;
				case ToolStripDropDownButton buttonToolStripDropDown:
					CopyToClipboard(text: buttonToolStripDropDown.Text);
					break;
				case ToolStripDropDownItem itemToolStripDropDown:
					CopyToClipboard(text: itemToolStripDropDown.Text);
					break;
				case ToolStripProgressBar barToolStripProgress:
					CopyToClipboard(text: barToolStripProgress.Text);
					break;
				case ToolStripSeparator separatorToolStrip:
					CopyToClipboard(text: separatorToolStrip.Text);
					break;
				case ToolStripTextBox boxToolStripText:
					CopyToClipboard(text: boxToolStripText.Text);
					break;
			}
		}

		private string GetDebuggerDisplay()
		{
			return ToString();
		}

		#endregion
	}
}
