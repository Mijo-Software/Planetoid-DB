using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PlanetoidDB
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
			if (!File.Exists(path: Planetoid_DB.Properties.Resources.strFilenameMPCORB))
			{
				if (MessageBox.Show(text: Planetoid_DB.I10nStrings.strMpcorbDatNotFoundText, caption: Planetoid_DB.I10nStrings.strMpcorbDatNotFoundCaption, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning, defaultButton: MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					if (!NetworkInterface.GetIsNetworkAvailable())
					{
						MessageBox.Show(text: Planetoid_DB.I10nStrings.StrNoInternetConnectionText, caption: Planetoid_DB.I10nStrings.strErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
						Application.Exit();
					}
					else
					{
						DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm();
						formDownloaderForMpcorbDat.ShowDialog();
						Application.Run(mainForm: new PlanetoidDBForm());
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
