using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

		#endregion

		public DerivatedOrbitElementsForm()
		{
			InitializeComponent();
		}

		public void SetDatabase(ArrayList arrayList)
		{
			derivatedOrbitElementsDatabase = arrayList;
		}

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
			linkLabelStandardGravitationalParameterDesc.Text = derivatedOrbitElementsDatabase[18].ToString();
		}

		private void DerivatedOrbitElementsForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

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

		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbar(text: "");

		private void ButtonOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

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

		private void LinkLabelLinearEccentricity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelSemiMinorAxis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelMajorAxis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelMinorAxis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelEccenctricAnomaly_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelTrueAnomaly_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelPerihelionDistance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelAphelionDistance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelLongitudeDescendingNode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabel1ArgumentAphelion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelFocalParameter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelSemiLatusRectum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelLatusRectum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelPeriod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelOrbitalArea_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelOrbitalPerimeter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelSemiMeanAxis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelMeanAxis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void LinkLabelStandardGravitationalParameterDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}
	}
}
