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

using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using saveImage = System.Drawing;
using p=System.IO;
using Microsoft.Win32;

namespace h25.Views
{
   
    public partial class t : Window
    {
        public string pth { get; set; }
        public t()
        {
            
            InitializeComponent();
            this.DataContext = this;
           // init();
            
                       
        }
        void init()
        {
            Uri fileUri = new Uri("/H/anh_ra_den.jpg", UriKind.Relative);// UriKind.Relative đường dẫn đến thư mục kp phải tuyệt đối
            i1.Source = new BitmapImage(fileUri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                string h = $"{k}";

                var a = p.Path.GetFullPath(k.Text);

            var uri = new Uri(a, UriKind.RelativeOrAbsolute);
            i1.Source = new BitmapImage(uri);
            //var ima = saveImage.Image.FromFile(a);
            //ima.Save(@"C:\Users\Administrator\Desktop\s\k.jpg");


            //i1.Source = null;
            //MessageBox.Show(k.Text);
            //System.GC.Collect(); 
            //System.GC.WaitForPendingFinalizers(); 
            //System.IO.File.Delete(a);
            //MessageBox.Show(System.IO.File.Exists(a).ToString());



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                k.Text = openFileDialog.FileName;
                Uri fileUri = new Uri(openFileDialog.FileName);
                i1.Source = new BitmapImage(fileUri);

            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //string h = $"../Images/{k.Text}";

            //var a = p.Path.GetFullPath(k.Text);

            //var uri = new Uri(a, UriKind.RelativeOrAbsolute);
            //i1.Source = new BitmapImage(uri);
            //var ima = saveImage.Image.FromFile(a);
            //ima.Save(@"C:\Users\Administrator\Desktop\s\k.jpg");
           // MessageBox.Show(System.IO.File.Exists(a).ToString());
           
        }
    }
}
