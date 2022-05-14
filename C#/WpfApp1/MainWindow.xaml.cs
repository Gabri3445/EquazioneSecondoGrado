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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Path;

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
            ProgressBar pr = new ProgressBar();
            pr.Show();
            Thread t1 = new Thread(() => Download(checkBox));
            t1.IsBackground = true;
            t1.Start();
        }

        public void Download(bool?[] checkBox)
        {
            isDone = false;
            if ((bool)checkBox[1])
            {
                Thread.Sleep(6000);
                MessageBox.Show("Discrod");
            }
            isDone = true;
        }

        //When this gets closed close every other window

    }
}
