using Base_z;
using h25.Views;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace h25.ViewModels
{
    class VMmain : BaseViewModel
    {
        public btn btn { get; set; }
        public ICommand isConnection { get; set; }
        public ICommand changeConnectionString { get; set; }       
        public static string connectionString;
        public string strConnect { get; set; }
        public static Window MainWindow;
        public static ContentControl ContentMainWindow;
        public static ControlBar_z ControlBar;
        public ICommand GetMainWindow { get; set; }
        public ICommand GetContentMainWindow { get; set; }
        public ICommand OpenWindowAdministration { get; set; }
        public ICommand OpenSetting { get; set; }
        public ICommand CheckConnectionString { get; set; }
        public ICommand ShowControlBar { get; set; }
        public ICommand HideControlBar { get; set; }
        public ICommand GetControlBar { get; set; }
        public ICommand OpenLoginClient { get; set; }
        public ICommand CloseMainWindow { get; set; }
       

        //--------------------- 1 số cửa sổ khởi tạo -----------------------------               
        public VMmain()
        {
            strConnect = @"server=127.0.0.1;database=gamo;user id=root;password=22022000;port=3306";
            connectionString = strConnect;
            initialization();
        }
        void initialization()
        {
            btn = new btn();
            GetMainWindow = new RelayCommand<object>(p => { return true; }, p => { MainWindow = p as Window; });
            ShowControlBar = new RelayCommand<object>(p => { return true; }, p => { if ((p as ControlBar_z).Opacity != 100) (p as ControlBar_z).Opacity = 99; });
            HideControlBar = new RelayCommand<object>(p => { return true; }, p => { if ((p as ControlBar_z).Opacity != 100) (p as ControlBar_z).Opacity = 0; });
            GetControlBar = new RelayCommand<object>(p => { return true; }, p => { ControlBar = (p as ControlBar_z); });

            GetContentMainWindow = new RelayCommand<object>(p => { return true; }, p => { ContentMainWindow = p as ContentControl; });
            OpenLoginClient = new RelayCommand<object>(p => { return true; }, p =>
            {
                MainWindow.Visibility = Visibility.Collapsed;
                LoginClient loginClient = new LoginClient();
                loginClient.ShowDialog();
                //MainWindow.Visibility = Visibility.Visible;

            });
           
            OpenWindowAdministration = new RelayCommand<object>(p => { return true; }, p =>
            {
                MainWindow.Visibility = Visibility.Collapsed;
                Login login = new Login(); login.ShowDialog();
            });
            OpenSetting = new RelayCommand<object>(p => { return true; }, p => { var a = new settingdata(); a.ShowDialog(); });
            changeConnectionString = new RelayCommand<object>(p => { return true; }, p => { connectionString = strConnect; });
            CheckConnectionString = new RelayCommand<object>(p => { return true; }, p =>
            {
                try
                {
                    var connection = new MySqlConnection(strConnect);
                    connection.Open();
                    MessageBox.Show("kết Nối Database thành công");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại!,xin tra lại connection string");
                }
            });
            CloseMainWindow = new RelayCommand<object>(p=> { return true; },p=> {Application.Current.Shutdown(); });
        }


    }



}
