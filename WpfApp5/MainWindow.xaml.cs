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
using System.Windows.Threading;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            //timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(1);
            //timer.Tick += Timer_Tick;
            //timer.Start();
        }
        public int Counter { get; set; } = 0;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            //++Counter;
            //if (Counter % 2 == 0)
            //{
            //mypath.Fill = Brushes.SpringGreen;
            //}
            //else
            //{
            //mypath.Fill = Brushes.Brown;
            //}
        }
    }
}
