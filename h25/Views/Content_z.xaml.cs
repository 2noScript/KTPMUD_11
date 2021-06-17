using h25.ViewModels;
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

namespace h25.Views
{
    /// <summary>
    /// Interaction logic for Content_z.xaml
    /// </summary>
    public partial class Content_z : UserControl
    {
        public Content_z()
        {
            InitializeComponent();
        }

        private void content_lbox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            System.Windows.MessageBox.Show("what");
        }



    }
}
