using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Net.Http;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Path = "";

        public static bool isDone { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthorName_Click(object sender, RoutedEventArgs e)
        {
            //Display a message box
            MessageBox.Show(
                "Programmato da:\n"
                    + "- Gabriele Lopez (Code and design) \n"
                    + "- Giovanni Sansonetti & Gabriele Mancini (Original Program and Idea)\n",
                "Authors"
            );
            var uri = "https://github.com/Gabri3445/Scuola";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void PathChoose_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                PathText.Text = dialog.FileName;
                Path = dialog.FileName;
            }
        }

        private void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            if (Path != "")
            {
                //Checkbox bool array
                bool?[] checkBox = new bool?[]
                {
                    SteamCheck.IsChecked,
                    DiscordCheck.IsChecked,
                    uTorrentCheck.IsChecked,
                    MinecraftPRCheck.IsChecked,
                    EpicGamesCheck.IsChecked,
                    BattleNetCheck.IsChecked,
                    LogitechCheck.IsChecked,
                    OriginCheck.IsChecked,
                    MinecraftCRCheck.IsChecked,
                    VS2022Check.IsChecked,
                    VSCCheck.IsChecked,
                    SublimeTextCheck.IsChecked,
                    PyCharmCheck.IsChecked,
                    BlenderCheck.IsChecked,
                    EclipseCheck.IsChecked,
                    DevCCheck.IsChecked,
                    NodeJSCheck.IsChecked,
                    QtDesigner.IsChecked,
                    AMDCheck.IsChecked,
                    WinRarCheck.IsChecked,
                    SevZipCheck.IsChecked,
                    OBSCheck.IsChecked,
                    GeForceCheck.IsChecked,
                    VirtualBoxCheck.IsChecked,
                    SpotifyCheck.IsChecked,
                    VLCCheck.IsChecked,
                    AdobeInstallerCheck.IsChecked,
                };
                isDone = false;
                ProgressBar pr = new ProgressBar();
                pr.Show();
                Thread t1 = new Thread(() => Download(checkBox));
                t1.IsBackground = true;
                t1.Start();
            }
            else
            {
                MessageBox.Show("Select a folder first!", "Error");
            }
        }

        public void Download(bool?[] checkBox)
        {
#pragma warning disable CS8629 // Nullable value type may be null.
            isDone = false;
            if ((bool)checkBox[0])
            {
                DownloadFile(
                    "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe",
                    "SteamSetup.exe"
                );
            }

            if ((bool)checkBox[1])
            {
                DownloadFile(
                    "https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86",
                    "DiscordSetup.exe"
                );
            }

            if ((bool)checkBox[2])
            {
                DownloadFile(
                    "https://download-hr.utorrent.com/track/stable/endpoint/utorrent/os/windows",
                    "utorrent-installer.exe"
                );
            }

            if ((bool)checkBox[3])
            {
                DownloadFile(
                    "https://launcher.mojang.com/download/MinecraftInstaller.exe",
                    "MinecraftLauncher.exe"
                );
            }

            if ((bool)checkBox[4])
            {
                DownloadFile(
                    "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi",
                    "EpicGamesLauncherInstaller.msi"
                );
            }

            if ((bool)checkBox[5])
            {
                DownloadFile(
                    "https://www.battle.net/download/getInstallerForGame?os=win&gameProgram=BATTLENET_APP&version=Live&id=548869183.1649688146",
                    "BattleNet.exe"
                );
            }

            if ((bool)checkBox[6])
            {
                DownloadFile(
                    "https://download01.logi.com/web/ftp/pub/techsupport/gaming/lghub_installer.exe",
                    "Logitech-installer.exe"
                );
            }

            if ((bool)checkBox[7])
            {
                DownloadFile("https://www.dm.origin.com/download", "OriginSetup.exe");
            }

            if ((bool)checkBox[8])
            {
                DownloadFile("https://tlauncher.org/installer", "Tlauncher.exe");
            }

            if ((bool)checkBox[9])
            {
                DownloadFile(
                    "https://c2rsetup.officeapps.live.com/c2r/downloadVS.aspx?sku=community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030",
                    "VisualStudio-Setup.exe"
                );
            }

            if ((bool)checkBox[10])
            {
                DownloadFile(
                    "https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user",
                    "VisualStudioCode-Setup.exe"
                );
            }

            if ((bool)checkBox[11])
            {
                DownloadFile(
                    "https://download.sublimetext.com/sublime_text_build_4126_x64_setup.exe",
                    "SublimeText-Build.exe"
                );
            }

            if ((bool)checkBox[12])
            {
                DownloadFile(
                    "https://download.jetbrains.com/python/pycharm-community-2021.3.3.exe?_ga=2.185222057.1085385846.1649606918-1947123728.1649606918&_gl=1*ifgtn3*_ga*MTk0NzEyMzcyOC4xNjQ5NjA2OTE4*_ga_V0XZL7QHEB*MTY0OTY5MDcwOS4yLjEuMTY0OTY5MDcxMi4w",
                    "PyCharm-Community.exe"
                );
            }

            if ((bool)checkBox[13])
            {
                DownloadFile(
                    "https://ftp.nluug.nl/pub/graphics/blender/release/Blender3.1/blender-3.1.2-windows-x64.msi",
                    "Blender-Setup.msi"
                );
            }

            if ((bool)checkBox[14])
            {
                DownloadFile(
                    "https://ftp.acc.umu.se/mirror/eclipse.org/oomph/epp/2022-03/R/eclipse-inst-jre-win64.exe",
                    "Eclipse-Setup.exe"
                );
            }

            if ((bool)checkBox[15])
            {
                DownloadFile(
                    "https://sourceforge.net/projects/orwelldevcpp/files/latest/download",
                    "DevCPP.exe"
                );
            }

            if ((bool)checkBox[16])
            {
                DownloadFile(
                    "https://nodejs.org/dist/v16.14.2/node-v16.14.2-x64.msi",
                    "NodeJS.msi"
                );
            }

            if ((bool)checkBox[17])
            {
                DownloadFile(
                    "https://d13lb3tujbc8s0.cloudfront.net/onlineinstallers/qt-unified-windows-x86-4.3.0-1-online.exe",
                    "QtDesigner.exe"
                );
            }

            if ((bool)checkBox[18])
            {
                DownloadFile(
                    "https://files02.tchspt.com/tempd/AMD-Software-Adrenalin-Edition-22.4.2-Win10-Win11-April25.exe",
                    "amd-software-adrenalin-edition.exe"
                );
            }

            if ((bool)checkBox[19])
            {
                DownloadFile(
                    "https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-611it.exe",
                    "WinRar-Setup.exe"
                );
            }

            if ((bool)checkBox[20])
            {
                DownloadFile("https://www.7-zip.org/a/7z2107-x64.exe", "7-zip.exe");
            }

            if ((bool)checkBox[21])
            {
                DownloadFile(
                    "https://cdn-fastly.obsproject.com/downloads/OBS-Studio-27.2.4-Full-Installer-x64.exe",
                    "Obs-Full-Installer.exe"
                );
            }

            if ((bool)checkBox[22])
            {
                DownloadFile(
                    "https://it.download.nvidia.com/GFE/GFEClient/3.25.1.27/GeForce_Experience_v3.25.1.27.exe",
                    "GeForce_Experience_v3.25.1.27.exe"
                );
            }

            if ((bool)checkBox[23])
            {
                DownloadFile(
                    "https://download.virtualbox.org/virtualbox/6.1.32/VirtualBox-6.1.32-149290-Win.exe",
                    "Virtual-Box-Windows.exe"
                );
            }

            if ((bool)checkBox[24])
            {
                DownloadFile("https://download.scdn.co/SpotifySetup.exe", "SpotifySetup.exe");
            }

            if ((bool)checkBox[25])
            {
                DownloadFile(
                    "https://get.videolan.org/vlc/3.0.16/win64/vlc-3.0.16-win64.exe",
                    "vlcsetup.exe"
                );
            }

            if ((bool)checkBox[26])
            {
                DownloadFile("https://www.dropbox.com/download?plat=win", "Dropbox-Setup.exe");
            }

#pragma warning restore CS8629 // Nullable value type may be null.
            isDone = true;
            return;
        }

        private void DownloadFile(string url, string fileName)
        {
            //Add \\ to the start of fileName
            fileName = "\\" + fileName;
            HttpClient hc = new HttpClient();
            hc.GetAsync(url)
                .ContinueWith(
                    t =>
                    {
                        if (t.IsCompleted)
                        {
                            string path = Path + fileName;
                            System.IO.File.WriteAllBytes(
                                path,
                                t.Result.Content.ReadAsByteArrayAsync().Result
                            );
                        }
                    }
                );
            Thread.Sleep(1500);
            return;
        }
    }
}
