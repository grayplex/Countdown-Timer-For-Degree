using System;
using System.Windows;
using System.Windows.Threading;

namespace Countdown_Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime targetDate = new DateTime(2023, 12, 9, 23, 59, 59);
            TimeSpan remainingTime = targetDate - DateTime.Now;

            if (remainingTime.TotalSeconds <= 0) return;

            Application.Current.MainWindow.Title =
                $"{remainingTime.Days}d {remainingTime.Hours}h {remainingTime.Minutes}m {remainingTime.Seconds}s";
        }
    }
}
