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
        public string userName { get; set; }
        public string warning { get; set; }
        public string warning1 { get; set; }

        public administration newAdmin { get; set; }

        private PasswordBox passwordz;
        private PasswordBox newPasswordz;
        private PasswordBox rePasswordz;
        public btn btn { get; set; }
        public List<ICommand> listLoad { get; set; }
        public ICommand islogin { get; set; }
        public ICommand isLoad { get; set; }
        public ICommand isClose { get; set; }
        public ICommand isSignUp { get; set; }
        public static administration administrationz;// lấy thông tin tài khoản hiện đang sử dụng 

        public VMlogin()
        {
            initialization();
            userName = "gamoet1";
            login();
        }
        void clearBufferNewAccount()
        {
            newAdmin.userName = newAdmin.fullName = newAdmin.gmail = null;
        }
        bool checkstr(string strCheck)
        {
            if (strCheck == null) return true;
            else if (strCheck.Length == 0) return true;
            return false;
        }
        void login()
        {
            isSignUp = new RelayCommand<object>(p => { return true; }, p =>
            {
                var connect = VMmain.connection;
                using (var command = new MySqlCommand())
                {
                    if (checkstr(newAdmin.userName))
                    {
                        warning1 = "xin hãy nhập Tên tài khoản đăng nhập";
                        OnPropertyChanged("warning1");
                    }
                    else if (checkstr(newAdmin.fullName))
                    {
                        warning1 = "xin hãy nhập Tên của bạn";
                        OnPropertyChanged("warning1");
                    }
                    else if (checkstr(newAdmin.gmail))
                    {
                        warning1 = "Bạn chưa nhập mail";
                        OnPropertyChanged("warning1");
                    }
                    else if (newPasswordz.Password.Length == 0)
                    {
                        warning1 = "Bạn chưa nhập mật khẩu";
                        OnPropertyChanged("warning1");
                    }
                    else if (newPasswordz.Password != rePasswordz.Password)
                    {
                        warning1 = "xin kiểm tra phần nhập lại mật khẩu, đảm bảo giống phần mật khẩu";
                        OnPropertyChanged("warning1");
                    }
                    else
                    {
                        try
                        {
                            command.Connection = connect;
                            command.CommandText = @"insert into administration(userName,passwordz,fullname,gmail,pathImage,timeLine) 
                                                              values (@userName,@passwordz,@fullname,@gmail,@pathImage,@timeLine);";
                            command.Parameters.AddWithValue("@username", newAdmin.userName.Trim());
                            command.Parameters.AddWithValue("@passwordz", newPasswordz.Password);
                            command.Parameters.AddWithValue("@fullname", newAdmin.fullName);
                            command.Parameters.AddWithValue("@gmail", newAdmin.gmail);
                            command.Parameters.AddWithValue("@pathImage", newAdmin.pathImage = "unknow");
                            command.Parameters.AddWithValue("@timeLine", DateTime.Now.ToString());
                            var result = command.ExecuteNonQuery();                           
                                warning1 = "Tài khoản tạo thành công";
                                OnPropertyChanged("warning1");                                                    
                        }
                        catch
                        {
                            warning1 = "Tên Đăng nhập đã tồn tại ! xin tạo tên đăng nhập khác";
                            OnPropertyChanged("warning1");
                        }
                        
                    }
                }

            });
            islogin = new RelayCommand<Window>(p => { return true; }, p =>
            {
                var connect = VMmain.connection;// lấy được connection
                using (var command = new MySqlCommand())
                {
                    command.Connection = connect;
                    command.CommandText = @"select * from administration where username=@username and passwordz=@passwordz";
                    command.Parameters.AddWithValue("@username", userName.Trim());
                    command.Parameters.AddWithValue("@passwordz", passwordz.Password);

                    var sqlReader = command.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        p.Close();
                        VMmain.isVmain.Visibility = Visibility.Visible;
                        var a = new Content_z();
                        var b = a.DataContext as VMcontent_z;
                        b.IsHide = Visibility.Visible;
                        b.IsHide_z = Visibility.Collapsed;
                        VMmain.isContent.Content = a;
                        administrationz = new administration();
                        sqlReader.Read();
                        administrationz.copydata(sqlReader);
                        //administrationz.display();
                    }
                    else
                    {
                        warning = "Tên đăng nhập hoặc mật Khẩu không chính xác";
                        OnPropertyChanged("warning");
                    }
                    sqlReader.Close();
                }
            });
        }
        void initialization()
        {
            newAdmin = new administration();
            btn = new btn();
            listLoad = new List<ICommand>();
            listLoad.Add(new RelayCommand<object>(p => { return true; }, p => { passwordz = p as PasswordBox; }));
            listLoad.Add(new RelayCommand<object>(p => { return true; }, p => { newPasswordz = p as PasswordBox; }));
            listLoad.Add(new RelayCommand<object>(p => { return true; }, p => { rePasswordz = p as PasswordBox; }));
            isClose = new RelayCommand<object>(p => { return true; }, p => { VMmain.isVmain.Visibility = Visibility.Visible; clearBufferNewAccount();});
        }

    }
}
