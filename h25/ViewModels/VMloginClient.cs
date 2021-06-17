using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Base_z;

namespace h25.ViewModels
{

    class VMloginClient:BaseViewModel
    {
        public btn btn { get; set; }
        public ICommand CloseLoginClient { get; set; }
        public ICommand CommandloginClient { get; set; }
        public string warning { get; set; }
        public VMloginClient()
        {
            btn = new btn();
            CloseLoginClient = new RelayCommand<object>(p => { return true; }, p => {
                VMmain.MainWindow.Visibility = System.Windows.Visibility.Visible;
            });
        }
    }
}
