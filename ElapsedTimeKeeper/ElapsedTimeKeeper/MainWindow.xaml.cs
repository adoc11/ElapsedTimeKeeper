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

namespace ElapsedTimeKeeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime clockInTime { get; set; }
        public DateTime clockOutTime { get; set; }
        public DateTime mealStartTime { get; set; }
        public DateTime mealStopTime { get; set; }
        public DateTime finalTime { get; set; }

        public int toggleCounter = 0;
        public int toggleCounter2 = 0;

        public MainWindow()
        {
            clockInTime = new DateTime();
            clockOutTime = new DateTime();
            mealStartTime = new DateTime();
            clockOutTime = new DateTime();
            InitializeComponent();
        }

        private void clockInOutTime_Click(object sender, RoutedEventArgs e)
        {
            if(toggleCounter > 0)
            {
                clockInOutBtn.Content = "CLOCK IN";
                toggleCounter--;
            }
            else
            {
                clockInTime = DateTime.Now;
                finalTime = clockInTime.AddHours(9);
                timeToLeaveResultLbl.Content = string.Format("{0:T}", finalTime);
                clockInOutBtn.Content = "CLOCK OUT";
                toggleCounter++;
            }
            
        }

        private void mealStartStop_Click(object sender, RoutedEventArgs e)
        {
            if(toggleCounter2 > 0)
            {
                mealStopTime = DateTime.Now;
                TimeSpan elapsedMealTime = Math.Abs(mealStopTime - mealStartTime);
            }
            else
            {
                mealStartTime = DateTime.Now;
            }
            
        }

        private void isFridayChk(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
