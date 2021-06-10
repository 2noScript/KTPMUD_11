using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using i=System.Drawing;
using p = System.IO;


namespace h25.Views
{
    /// <summary>
    /// Interaction logic for t1.xaml
    /// </summary>
    public partial class t1 : Window
    {
        string path;
        public t1()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                this.path = openFileDialog.FileName;
                Uri fileUri = new Uri(openFileDialog.FileName);
                one.Source = new BitmapImage(fileUri);
                               
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();

            //if (saveFileDialog.ShowDialog() == true)
            //{
            //    System.Drawing.Image bitmap = System.Drawing.Image.FromFile(this.path);
            //    bitmap.Save(saveFileDialog.FileName);
            //    MessageBox.Show(saveFileDialog.FileName);
            //}
            var ima = i.Image.FromFile(p.Path.GetFullPath(this.path));// lây s path và gán cho ima
            var a = DateTime.Now;
            string s = a.Day.ToString() + a.Month.ToString() + a.Year.ToString() + a.Hour.ToString() + a.Minute.ToString() + a.Second.ToString() + a.Millisecond.ToString();
            ima.Save($@"../Images/{s}.jpg");
               
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var a = DateTime.Now;
            MessageBox.Show(a.Day.ToString()+a.Month.ToString()+a.Year.ToString()+a.Hour.ToString()+a.Minute.ToString()+a.Second.ToString()+a.Millisecond.ToString());
        }
    }
}
