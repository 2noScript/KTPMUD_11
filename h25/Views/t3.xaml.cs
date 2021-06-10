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

namespace h25.Views
{
    /// <summary>
    /// Interaction logic for t3.xaml
    /// </summary>
    public partial class t3 : Window
    {
        public t3()
        {
            InitializeComponent();
            
       
        }
    }
    public class Person
    {
        public int Age
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public override string ToString()
        {
            return Name + " - age: " + Age;
        }

    }
}
