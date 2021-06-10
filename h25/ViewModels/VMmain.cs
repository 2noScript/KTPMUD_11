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
        public static bool isShow=true;       
        public string tx { get; set; }

        public static Window isVmain;
        public static ContentControl isContent;
        public static MySqlConnection connection;

        string strconnect;
        public string Strconnect { get => strconnect; set { strconnect = value; OnPropertyChanged(); } }
        public static string connectionString;
        public ICommand isload { get; set; }
        public ICommand isClosed { get; set; }
        public ICommand islogin { get; set; }
        public ICommand admin { get; set; }
       // public ICommand k { get; set; }

        public ICommand openSetting { get; set; }
        public ICommand isConnection { get; set; }


        public ICommand changeConnectionString { get; set; }
        private ContentControl cz { get; set; }
        
        //--------------------- 1 số cửa sổ khởi tạo -----------------------------               
        public VMmain()
        {
            Strconnect = @"server=127.0.0.1;database=gamoet1;user id=root;password=22022000;port=3306";
            connectionString = Strconnect;
            initialization();                               
        }
        void initialization()
        {
            btn = new btn();
            isload = new RelayCommand<object>(p => { return true; }, p => { isVmain = p as Window; });
            isClosed = new RelayCommand<object>(p => { return true; }, p => { if (connection != null) connection.Close(); });
            openSetting = new RelayCommand<object>(p => { return true; }, p => { var a = new settingdata(); a.ShowDialog(); });
            changeConnectionString= new RelayCommand<object>(p => { return true; }, p => { connectionString = strconnect; });
            admin = new RelayCommand<object>(p => { return true; }, p =>
            {
                try
                {
                    connection = new MySqlConnection(strconnect);
                    connection.Open();
                    isContent = p as ContentControl;
                    isVmain.Visibility = Visibility.Hidden;
                    Login login = new Login();
                    login.Show();
                }
                catch
                {
                    MessageBox.Show("Kiểm tra lại kết nối database");
                }

            });
            isConnection = new RelayCommand<object>(p => { return true; }, p =>
            {
                try
                {
                    connection = new MySqlConnection(Strconnect);
                    connection.Open();
                    MessageBox.Show("kết Nối Database thành công");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại!,xin tra lại connection string");
                }
            });
        }


    }

   
    
}
