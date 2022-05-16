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
using System.Windows.Shapes;
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ProgressBar.xaml
    /// </summary>
    public partial class ProgressBar : Window
    {
        public ProgressBar()
        {
            InitializeComponent();
            ProgressBar_Loaded(null, null);
        }

        //run every frame
        private void ProgressBar_Loaded(object sender, RoutedEventArgs e)
        {
            //create a new thread
            Thread t0 = new Thread(Start);
            //start the thread
            t0.Start();
        }

        //method to run in the new thread
        private void Start()
        {
            do
            {
                if (MainWindow.isDone)
                {
                    this.Dispatcher.Invoke(
                        () =>
                        {
                            this.Close();
                        }
                    );
                    break;
                }
            } while (true);
            return;
        }
    }
}
