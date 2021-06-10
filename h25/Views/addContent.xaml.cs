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
    /// Interaction logic for addContent.xaml
    /// </summary>
    public partial class addContent : UserControl
    {
        public addContent()
        {
            InitializeComponent();
           
            //List<prop> p = new List<prop>();
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //p.Add(new prop());
            //li.ItemsSource = p;
        }
        public class prop
        {
            public string name { get; set; }
            public string price { get; set; }
            public string time { get; set; }
            public int id { get; set; }
            public prop()
            {
                name = "gà rán";
                price = "12000000";
                time = DateTime.Now.ToString();
                id = 1;
            }

        }
    }
}
