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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
    }
}
