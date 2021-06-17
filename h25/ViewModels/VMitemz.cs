using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_z;

namespace h25.ViewModels
{
    class VMitemz : BaseViewModel
    {

        public btn btn { get; set; }
        public string PathImage { get => pathImage; set { pathImage = value; OnPropertyChanged(); } }
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
        public string Price { get => price; set { price = value; OnPropertyChanged(); } }
        string pathImage;
        string name;
        string price;
            

        //public VMitemz(string pathImage,string Name,string Price)
        //{
        //    this.PathImage = pathImage;
        //    this.Name = Name;
        //    this.Price = Price;
        //    
                      
        //}
        public VMitemz() {
            btn = new btn();
        }

    }
   
}
