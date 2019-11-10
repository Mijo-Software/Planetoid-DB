using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;

namespace Planetoid_DB
{
	public partial class DerivatedOrbitElementsForm : Form
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
			labelInformation.Enabled = text == "" ? false : true;
			labelInformation.Text = text;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arrayList"></param>
		public void SetDatabase(ArrayList arrayList)
		{
			derivatedOrbitElementsDatabase = arrayList;
		}

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
			labelLinearEccentricityData.Text = derivatedOrbitElementsDatabase[0].ToString();
			labelSemiMinorAxisData.Text = derivatedOrbitElementsDatabase[1].ToString();
			labelMajorAxisData.Text = derivatedOrbitElementsDatabase[2].ToString();
			labelMinorAxisData.Text = derivatedOrbitElementsDatabase[3].ToString();
			labelEccentricAnomalyData.Text = derivatedOrbitElementsDatabase[4].ToString();
			labelTrueAnomalyData.Text = derivatedOrbitElementsDatabase[5].ToString();
			labelPerihelionDistanceData.Text = derivatedOrbitElementsDatabase[6].ToString();
			labelAphelionDistanceData.Text = derivatedOrbitElementsDatabase[7].ToString();
			labelLongitudeDescendingNodeData.Text = derivatedOrbitElementsDatabase[8].ToString();
			labelArgumentAphelionData.Text = derivatedOrbitElementsDatabase[9].ToString();
			labelFocalParameterData.Text = derivatedOrbitElementsDatabase[10].ToString();
			labelSemiLatusRectumData.Text = derivatedOrbitElementsDatabase[11].ToString();
			labelLatusRectumData.Text = derivatedOrbitElementsDatabase[12].ToString();
			labelPeriodData.Text = derivatedOrbitElementsDatabase[13].ToString();
			labelOrbitalAreaData.Text = derivatedOrbitElementsDatabase[14].ToString();
			labelOrbitalPerimeterData.Text = derivatedOrbitElementsDatabase[15].ToString();
			labelSemiMeanAxisData.Text = derivatedOrbitElementsDatabase[16].ToString();
			labelMeanAxisData.Text = derivatedOrbitElementsDatabase[17].ToString();
			labelStandardGravitationalParameterData.Text = derivatedOrbitElementsDatabase[18].ToString();
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
			if (sender is TextBox)
			{
				SetStatusbar(text: ((TextBox)sender).AccessibleDescription);
			}
			else if (sender is Button)
			{
				SetStatusbar(text: ((Button)sender).AccessibleDescription);
			}
			else if (sender is RadioButton)
			{
				SetStatusbar(text: ((RadioButton)sender).AccessibleDescription);
			}
			else if (sender is CheckBox)
			{
				SetStatusbar(text: ((CheckBox)sender).AccessibleDescription);
			}
			else if (sender is DateTimePicker)
			{
				SetStatusbar(text: ((DateTimePicker)sender).AccessibleDescription);
			}
			else if (sender is Label)
			{
				SetStatusbar(text: ((Label)sender).AccessibleDescription);
			}
			else if (sender is PictureBox)
			{
				SetStatusbar(text: ((PictureBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripButton)
			{
				SetStatusbar(text: ((ToolStripButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem)
			{
				SetStatusbar(text: ((ToolStripMenuItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripLabel)
			{
				SetStatusbar(text: ((ToolStripLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripComboBox)
			{
				SetStatusbar(text: ((ToolStripComboBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDown)
			{
				SetStatusbar(text: ((ToolStripDropDown)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton)
			{
				SetStatusbar(text: ((ToolStripDropDownButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem)
			{
				SetStatusbar(text: ((ToolStripDropDownItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu)
			{
				SetStatusbar(text: ((ToolStripDropDownMenu)sender).AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar)
			{
				SetStatusbar(text: ((ToolStripProgressBar)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton)
			{
				SetStatusbar(text: ((ToolStripSplitButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSeparator)
			{
				SetStatusbar(text: ((ToolStripSeparator)sender).AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel)
			{
				SetStatusbar(text: ((ToolStripStatusLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripTextBox)
			{
				SetStatusbar(text: ((ToolStripTextBox)sender).AccessibleDescription);
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbar(text: "");

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
		private void CopyToClipboard_Click(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				CopyToClipboard(text: ((TextBox)sender).Text);
			}
			else if (sender is Button)
			{
				CopyToClipboard(text: ((Button)sender).Text);
			}
			else if (sender is RadioButton)
			{
				CopyToClipboard(text: ((RadioButton)sender).Text);
			}
			else if (sender is CheckBox)
			{
				CopyToClipboard(text: ((CheckBox)sender).Text);
			}
			else if (sender is DateTimePicker)
			{
				CopyToClipboard(text: ((DateTimePicker)sender).Text);
			}
			else if (sender is Label)
			{
				CopyToClipboard(text: ((Label)sender).Text);
			}
			else if (sender is ToolStripButton)
			{
				CopyToClipboard(text: ((ToolStripButton)sender).Text);
			}
			else if (sender is ToolStripMenuItem)
			{
				CopyToClipboard(text: ((ToolStripMenuItem)sender).Text);
			}
			else if (sender is ToolStripLabel)
			{
				CopyToClipboard(text: ((ToolStripLabel)sender).Text);
			}
			else if (sender is ToolStripComboBox)
			{
				CopyToClipboard(text: ((ToolStripComboBox)sender).Text);
			}
			else if (sender is ToolStripDropDown)
			{
				CopyToClipboard(text: ((ToolStripDropDown)sender).Text);
			}
			else if (sender is ToolStripDropDownButton)
			{
				CopyToClipboard(text: ((ToolStripDropDownButton)sender).Text);
			}
			else if (sender is ToolStripDropDownItem)
			{
				CopyToClipboard(text: ((ToolStripDropDownItem)sender).Text);
			}
			else if (sender is ToolStripDropDownMenu)
			{
				CopyToClipboard(text: ((ToolStripDropDownMenu)sender).Text);
			}
			else if (sender is ToolStripProgressBar)
			{
				CopyToClipboard(text: ((ToolStripProgressBar)sender).Text);
			}
			else if (sender is ToolStripSplitButton)
			{
				CopyToClipboard(text: ((ToolStripSplitButton)sender).Text);
			}
			else if (sender is ToolStripSeparator)
			{
				CopyToClipboard(text: ((ToolStripSeparator)sender).Text);
			}
			else if (sender is ToolStripStatusLabel)
			{
				CopyToClipboard(text: ((ToolStripStatusLabel)sender).Text);
			}
			else if (sender is ToolStripTextBox)
			{
				CopyToClipboard(text: ((ToolStripTextBox)sender).Text);
			}
		}

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
	}
}
