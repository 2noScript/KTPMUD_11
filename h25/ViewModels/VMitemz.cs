using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_z;

namespace h25.ViewModels
{
    class VMitemz:BaseViewModel
    {
        public btn btn { get; set; }
        public VMitemz()
        {
            btn = new btn();
        }
    }
}
