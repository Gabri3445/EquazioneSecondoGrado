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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Path;

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
            bool[] checkBox = new bool[]
            {
                (bool)SteamCheck.IsChecked,
                (bool)DiscordCheck.IsChecked,
                (bool)uTorrentCheck.IsChecked,
                (bool)MinecraftPRCheck.IsChecked,
                (bool)EpicGamesCheck.IsChecked,
                (bool)BattleNetCheck.IsChecked,
                (bool)LogitechCheck.IsChecked,
                (bool)OriginCheck.IsChecked,
                (bool)MinecraftCRCheck.IsChecked,
                (bool)VS2022Check.IsChecked,
                (bool)VSCCheck.IsChecked,
                (bool)SublimeTextCheck.IsChecked,
                (bool)PyCharmCheck.IsChecked,
                (bool)BlenderCheck.IsChecked,
                (bool)EclipseCheck.IsChecked,
                (bool)DevCCheck.IsChecked,
                (bool)NodeJSCheck.IsChecked,
                (bool)QtDesigner.IsChecked,
                (bool)AMDCheck.IsChecked,
                (bool)WinRarCheck.IsChecked,
                (bool)SevZipCheck.IsChecked,
                (bool)OBSCheck.IsChecked,
                (bool)GeForceCheck.IsChecked,
                (bool)VirtualBoxCheck.IsChecked,
                (bool)SpotifyCheck.IsChecked,
                (bool)VLCCheck.IsChecked,
                (bool)AdobeInstallerCheck.IsChecked,
            };
        }
    }
}
