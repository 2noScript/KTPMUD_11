using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Base_z;

namespace h25.ViewModels
{
    class btn:BaseViewModel
    {
        public ICommand minsize { get; set; }
        
        public ICommand maxsize { get; set; }
        public ICommand close { get; set; }
        public ICommand dragMove { get; set; }
        public ICommand isWinDragMove{ get; set; }
        public btn()
        {
            minsize = new RelayCommand<Button>(p => { return true; }, p => { Window.GetWindow(p).WindowState = WindowState.Minimized; });
            maxsize = new RelayCommand<Button>(p => { return true; }, p =>
            {
                var a = Window.GetWindow(p);
                if (Window.GetWindow(p).WindowState == WindowState.Normal)
                    Window.GetWindow(p).WindowState = WindowState.Maximized;
                else
                    Window.GetWindow(p).WindowState = WindowState.Normal;
            });
            close = new RelayCommand<Button>(p => { return true; }, p => { Window.GetWindow(p).Close(); });
            dragMove = new RelayCommand<UserControl>(p => { return true; }, p => { Window.GetWindow(p).DragMove();});
            isWinDragMove = new RelayCommand<Window>(p => { return true; }, p => { p.DragMove();});
        }
    }
}
