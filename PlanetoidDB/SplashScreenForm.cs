using System;
using System.Reflection;
using System.Windows.Forms;
using Office2007Rendering;

namespace PlanetoidDB
{
	/// <summary>
	/// 
	/// </summary>
	public partial class SplashScreenForm : Form
  {
		/// <summary>
		/// 
		/// </summary>
		public SplashScreenForm() => InitializeComponent();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		public void SetProgressbar(int value) => progressBarSplash.Value = value;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SplashScreenForm_Load(object sender, EventArgs e)
    {
			ToolStripManager.Renderer = new Office2007Renderer();
      labelDataLoading.Text = Planetoid_DB.I10nStrings.strDataLoading;
      labelTitle.Text = GetAssemblyProduct();
      labelVersion.Text = string.Format(format: Planetoid_DB.I10nStrings.strVersionTemplate, arg0: GetAssemblyVersion());
    }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SplashScreenForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

		#region Assemblyattributaccessoren

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyTitle()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
			if (attributes.Length > 0)
			{
				AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
				if (titleAttribute.Title != "")
				{
					return titleAttribute.Title;
				}
			}
			return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
		}

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyDescription()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyDescriptionAttribute)attributes[0]).Description;
		}

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyProduct()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyProductAttribute)attributes[0]).Product;
		}

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyCopyright()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
		}

		/// <summary>
		/// 
		/// </summary>
		private string GetAssemblyCompany()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCompanyAttribute)attributes[0]).Company;
		}

		#endregion
	}
}
