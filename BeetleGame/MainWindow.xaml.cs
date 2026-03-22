using System;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace BeetleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Beetle _beetle;
        private Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            int x;
            do
            {
                x = _random.Next(30, Convert.ToInt32(paperCanvas.Width - 30));
            }
            while (x != paperCanvas.Width / 2 + 100 && x != paperCanvas.Width / 2 - 100);

            int y;
            do
            {
                y = _random.Next(30, Convert.ToInt32(paperCanvas.Height - 30));
            }
            while (y != paperCanvas.Height / 2 + 100 && y != paperCanvas.Height / 2 - 100); 

            _beetle = new Beetle(paperCanvas,x,y,Convert.ToInt32(sizeSlider.Value));
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartStopButton_Click(object sender, RoutedEventArgs e)
        {
            
            if(StartStopButton.Name == "Start")
            {
                StartStopButton.Name = "Stop";
            }
            else
            {
                StartStopButton.Name = "Start";
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
};

