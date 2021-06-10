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
using System.Windows.Threading;

namespace h25.Views
{
    /// <summary>
    /// Interaction logic for t2.xaml
    /// </summary>
    public partial class t2 : Window
    {
        public t2()
        {
           
            InitializeComponent();
            //da.Is24Hours = true;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);// 2 giây gọi sự kiện 
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToLongTimeString();
            if (da.SelectedTime != null)
            {
                if (DateTime.Now.Minute == da.SelectedTime.Value.Minute)
                {
                    MessageBox.Show("báo thức");
                }
            }
           
            //da.SelectedTimeFormat = DatePickerFormat.Long;
            //da.SelectedTime = DateTime.Now;
        }
    }
}
