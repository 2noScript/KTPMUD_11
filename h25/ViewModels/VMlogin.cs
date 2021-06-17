using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Base_z;
using h25.Views;
using h25.Model;

namespace h25.ViewModels
{
    class VMlogin : BaseViewModel
    {
        //new RelayCommand<object>(p => { return true; }, p => { })


        public static Administration administration;
        public btn btn { get; set; }
        public ICommand SignIn { get; set; }
        public ICommand SignUp { get; set; }
        public ICommand ShowMainWindow { get; set; }
        public ICommand GetPasswordSignIn { get; set; }
        public ICommand GetPasswordSignUp { get; set; }
        public ICommand GetRPasswordSignUp { get; set; }
        public ICommand ClearNewAdministration { get; set; }
        public ICommand ResetWarning { get; set; }
        public string userNameSignIn { get; set; }
        public Administration newAdministration { get; set; }
        public string warning { get; set; }
        private PasswordBox passwordSignIn;
        private PasswordBox passwordSignUp;
        private PasswordBox RPasswordSignUP;
        private string connectionString;

        public VMlogin()
        {
            initialization();

            // MessageBox.Show(TableName.Administration);

        }
        void initialization()
        {

            btn = new btn();
            newAdministration = new Administration();
            userNameSignIn = "gamoet1";
            connectionString = VMmain.connectionString;
            connectionString = @"server=127.0.0.1;database=gamo;user id=root;password=22022000;port=3306";
            ShowMainWindow = new RelayCommand<object>(p => { return true; }, p => { if (VMmain.MainWindow != null) VMmain.MainWindow.Visibility = Visibility.Visible; });
            GetPasswordSignIn = new RelayCommand<PasswordBox>(p => { return true; }, p => { passwordSignIn = p; });
            GetPasswordSignUp = new RelayCommand<PasswordBox>(p => { return true; }, p => { passwordSignUp = p; });
            GetRPasswordSignUp = new RelayCommand<PasswordBox>(p => { return true; }, p => { RPasswordSignUP = p; });
            SignIn = new RelayCommand<object>(p => { return true; }, p =>
            {
                var a = loginIsSignIn(connectionString, TableName.Administration);
                if (a) if (VMmain.MainWindow != null)
                    {
                        var content = new Content_z();
                        var vm = content.DataContext as VMcontent_z;
                        vm.HideAdmin = Visibility.Visible;
                        vm.HideUser  = Visibility.Collapsed;
                        VMmain.ContentMainWindow.Content = content;
                        
                        VMmain.ControlBar.Opacity = 100;
                        (p as Login).Close();
                      
                    }
            });
            SignUp = new RelayCommand<object>(p => { return true; }, p => { loginIssignUp(connectionString, TableName.Administration); });
            ClearNewAdministration = new RelayCommand<object>(p => { return true; }, p => {
                warning = "";
                OnPropertyChanged("warning");
                newAdministration.ClearData(); OnPropertyChanged("newAdministration"); });


        }

        bool loginIsSignIn(string connectionString, string tableName)
        {
            using (var command = new MySqlCommand())
            {
                command.Connection = new MySqlConnection(connectionString);
                command.Connection.Open();
                command.CommandText = $"select * from {tableName} where userName=@userName and passwordz=@passwordz";
                command.Parameters.AddWithValue("@userName", userNameSignIn);
                command.Parameters.AddWithValue("@passwordz", passwordSignIn.Password);
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    result.Read();
                    administration = new Administration(result);
                    result.Close();
                    
                    command.Connection.Close();
                    return true;
                }
                else
                {
                    // MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    warning = "Tài Khoản hoặc mật khẩu không chính xác";
                    OnPropertyChanged("warning");
                    command.Connection.Close();
                    return false;
                }

            }
        }
        void loginIssignUp(string connectionString, string tableName)
        {
            if (checkstr(newAdministration.userName))
            {
                warning = "xin hãy nhập Tên tài khoản đăng nhập";
                OnPropertyChanged("warning");
            }
            else if (checkstr(newAdministration.fullName))
            {
                warning = "xin hãy nhập Tên của bạn";
                OnPropertyChanged("warning");
            }
            else if (checkstr(newAdministration.gmail))
            {
                warning = "Bạn chưa nhập mail";
                OnPropertyChanged("warning");
            }
            else if (passwordSignUp.Password.Length == 0)
            {
                warning = "Bạn chưa nhập mật khẩu";
                OnPropertyChanged("warning");
            }
            else if (passwordSignUp.Password != RPasswordSignUP.Password)
            {
                warning = "xin kiểm tra phần nhập lại mật khẩu, đảm bảo giống phần mật khẩu";
                OnPropertyChanged("warning");
            }
            else
            {
                using (var command = new MySqlCommand())
                {
                    command.Connection = new MySqlConnection(connectionString);
                    command.Connection.Open();
                    command.CommandText = $@"insert into {tableName}(userName,passwordz,fullname,gmail,pathImage,timeLine,repaiTime) 
                                                              values (@userName,@passwordz,@fullname,@gmail,@pathImage,@timeLine,@repaiTime);";
                    command.Parameters.AddWithValue("@username", newAdministration.userName.Trim());
                    command.Parameters.AddWithValue("@passwordz", passwordSignUp.Password);
                    command.Parameters.AddWithValue("@fullname", newAdministration.fullName);
                    command.Parameters.AddWithValue("@gmail", newAdministration.gmail);
                    command.Parameters.AddWithValue("@pathImage", newAdministration.pathImage = "unknow");
                    var a = DateTime.Now.ToString();
                    command.Parameters.AddWithValue("@timeLine", a);
                    command.Parameters.AddWithValue("@repaiTime", a);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    // newAdministration.ClearData();
                    MessageBox.Show("tạo thành công ");
                }
            }
        }
        
        bool checkstr(string strCheck)
        {
            if (strCheck == null) return true;
            else if (strCheck.Length == 0) return true;
            return false;
        }



    }
}
