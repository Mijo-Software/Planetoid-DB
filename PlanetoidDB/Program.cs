using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Planetoid_DB
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Program
    {
        private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        private const int SET_FEATURE_ON_THREAD = 0x00000001;
        private const int SET_FEATURE_ON_PROCESS = 0x00000002;
        private const int SET_FEATURE_IN_REGISTRY = 0x00000004;
        private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;
        private const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;
        private const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;
        private const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;
        private const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;

        // Necessary dll import
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FeatureEntry"></param>
        /// <param name="dwFlags"></param>
        /// <param name="fEnable"></param>
        /// <returns></returns>
        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]

        static extern int CoInternetSetFeatureEnabled(int FeatureEntry, [MarshalAs(UnmanagedType.U4)] int dwFlags, bool fEnable);

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CoInternetSetFeatureEnabled(FeatureEntry: FEATURE_DISABLE_NAVIGATION_SOUNDS, dwFlags: SET_FEATURE_ON_PROCESS, fEnable: true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: false);
            if (!File.Exists(path: Properties.Resources.FilenameMpcorb))
            {
                if (MessageBox.Show(text: I10nStrings.MpcorbDatNotFoundText, caption: I10nStrings.MpcorbDatNotFoundCaption, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning, defaultButton: MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (!NetworkInterface.GetIsNetworkAvailable())
                    {
                        MessageBox.Show(text: I10nStrings.NoInternetConnectionText, caption: I10nStrings.ErrorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        using (DownloadUpdateForm formDownloaderForMpcorbDat = new DownloadUpdateForm())
                        {
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
