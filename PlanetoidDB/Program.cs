using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Planetoid_DB
{
	/// <summary>
	/// 
	/// </summary>
	internal static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
		private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			if (!File.Exists(path: Properties.Resources.strFilenameMPCORB))
			{
				if (MessageBox.Show(text: I10nStrings.strMpcorbDatNotFoundText, caption: I10nStrings.strMpcorbDatNotFoundCaption, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning, defaultButton: MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					if (!NetworkInterface.GetIsNetworkAvailable())
					{
						MessageBox.Show(text: I10nStrings.StrNoInternetConnectionText, caption: I10nStrings.strErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
						Application.Exit();
					}
					else
					{
						DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
						if (formDownloaderForMpcorbDat.ShowDialog() == DialogResult.OK)
						{
							Application.Run(mainForm: new PlanetoidDBForm());
						}
						else
						{
							Application.Exit();
						}
					}
				}
				else
				{
					Application.Exit();
				}
			}
			else
			{
				Application.Run(mainForm: new PlanetoidDBForm());
			}
    }
  }
}
