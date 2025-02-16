using System.IO;
using System.Reflection;

namespace Planetoid_DB
{
	/// <summary>
	/// Provide some assembly information
	/// </summary>
	public static class AssemblyInfo
	{
		#region Assembly attribute accessors

		/// <summary>
		/// Return the title of the assembly
		/// </summary>
		public static string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute? titleAttribute = attributes[0] as AssemblyTitleAttribute;
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
					if (!string.IsNullOrEmpty(value: titleAttribute.Title))
					{
						return titleAttribute.Title;
					}
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
				}
#pragma warning disable CS8603 // Mögliche Nullverweisrückgabe.
				return Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
#pragma warning restore CS8603 // Mögliche Nullverweisrückgabe.
			}
		}

		/// <summary>
		/// Return the version of the assembly
		/// </summary>
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
		public static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.

		/// <summary>
		/// Return the description of the assembly
		/// </summary>
		public static string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
				return attributes.Length == 0 ? string.Empty : ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		/// <summary>
		/// Return the product name of the assembly
		/// </summary>
		public static string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
				return attributes.Length == 0 ? string.Empty : ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		/// <summary>
		/// Return the copyright of the assembly
		/// </summary>
		public static string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
				return attributes.Length == 0 ? string.Empty : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		/// <summary>
		/// Return the company name of the assembly
		/// </summary>
		public static string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
				return attributes.Length == 0 ? string.Empty : ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion
	}
}
