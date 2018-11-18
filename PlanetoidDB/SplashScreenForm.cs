using System;
using System.Reflection;
using System.Windows.Forms;

using Office2007Rendering;

namespace PlanetoidDB
{
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
      labelDataLoading.Text = "Loading data...";
      labelTitle.Text = AssemblyProduct;
      labelVersion.Text = String.Format("Version: {0}", AssemblyVersion);
    }

    #region Assemblyattributaccessoren

    /// <summary>
		/// 
		/// </summary>
		public string AssemblyTitle
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        if (attributes.Length > 0)
        {
          AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
          if (titleAttribute.Title != "")
          {
            return titleAttribute.Title;
          }
        }
        return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
      }
    }

    /// <summary>
		/// 
		/// </summary>
		public string AssemblyVersion
    {
      get
      {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
    }

    /// <summary>
		/// 
		/// </summary>
		public string AssemblyDescription
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
      }
    }

    /// <summary>
		/// 
		/// </summary>
		public string AssemblyProduct
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyProductAttribute)attributes[0]).Product;
      }
    }

    /// <summary>
		/// 
		/// </summary>
		public string AssemblyCopyright
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    /// <summary>
		/// 
		/// </summary>
		private string AssemblyCompany
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyCompanyAttribute)attributes[0]).Company;
      }
    }

		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SplashScreenForm_FormClosed(object sender, FormClosedEventArgs e) => Dispose();
	}
}
