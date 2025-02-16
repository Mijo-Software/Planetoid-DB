﻿using System.IO;
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
		public static string? AssemblyTitle
		{
			get
			{
				var attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
				return attributes.Length > 0 && attributes[0] is AssemblyTitleAttribute titleAttribute
					? !string.IsNullOrEmpty(value: titleAttribute.Title) ? titleAttribute.Title : Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().Location)
					: Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().Location);
			}
		}

		/// <summary>
		/// Return the version of the assembly
		/// </summary>
		public static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";

		/// <summary>
		/// Return the description of the assembly
		/// </summary>
		public static string AssemblyDescription
		{
			get
			{
				var attributes = Assembly.GetExecutingAssembly()
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
				var attributes = Assembly.GetExecutingAssembly()
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
				var attributes = Assembly.GetExecutingAssembly()
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
				var attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
				return attributes.Length == 0 ? string.Empty : ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion
	}
}