
using Base_z;
using MySql.Data.MySqlClient;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using h25.Model;
using System.Windows;
using System;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Windows.Data;

namespace h25.ViewModels
{
    class VMadd : BaseViewModel
    {
        public btn btn { get; set; }
        public ICommand DeletePathImageItem { get; set; }
        //public ICommand isLoad2 { get; set; }
        public ICommand GetComboBox { get; set; }
        public ICommand CommandCreateItem { get; set; }
        public ICommand CloseViewCreateItem { get; set; }
        public ICommand OpenCreateItem { get; set; }
        public ICommand OpenDialogImageCreateItem { get; set; }
        public ICommand OpenDialogImageEditItem { get; set; }

        public ICommand UpdateDataOfEditItem { get; set; }
        public ICommand SelectItem { get; set; }
        public ICommand DeleteOneItem { get; set; }
        public ICommand SelectDispalayListItem { get; set; }
        public ICommand SearchOfNameItem { get; set; }
        public ICommand LoadDefaultListItem { get; set; }
        public Itemz itemDisplay { get; set; }

        public string warning { get; set; }
        public string SearchItem { get; set; }
        public ObservableCollection<Itemz> ListItem { get; set; }
        public Itemz newItemz { get; set; }
        string str = @"server=127.0.0.1;database=gamo;user id=root;password=22022000;port=3306";
        private string diuz;
        private ComboBox TypeOfItem;
        private string AdminName;
        enum TypeDIU
        {
            Delete, Insert, Update
        }
        public VMadd()
        {

            InitializeComponent();


        }
        void InitializeComponent()
        {
            // str = VMmain.connectionString;
            AdminName = "gamoet1";
            btn = new btn();
            newItemz = new Itemz();// khởi tạo đầu tiên
            itemDisplay = new Itemz();
            {
                ListItem = new ObservableCollection<Itemz>();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListItem);
                view.Filter = UserFilter;
            }

            DeletePathImageItem = new RelayCommand<object>(p => { return true; }, p => { DeleteFilePathImage(AdminName, TableName.historyOfData, TypeDIU.Delete, str); });
            OpenCreateItem = new RelayCommand<object>(p => { return true; }, p => { warning = "";OnPropertyChanged("warning"); });
            LoadDefaultListItem = new RelayCommand<object>(p => { return true; }, p => { UpdateListItem(AdminName, TableName.Saltyfood, str); DefaultDisplayItems(); });
            GetComboBox = new RelayCommand<object>(p => { return true; }, p =>
            {
                TypeOfItem = p as ComboBox;
                //UpdateDataListItem("saltyfood", str); // mặc đinh load đồ ăn mặn

            });
            SearchOfNameItem = new RelayCommand<object>(p => { return true; }, p => { CollectionViewSource.GetDefaultView(ListItem).Refresh(); });
            SelectItem = new RelayCommand<ListView>(p => { return true; }, p =>
            {
                if (p.SelectedItem != null)
                {
                    DisplayItems(p.SelectedItem as Itemz);
                }
            });

            OpenDialogImageCreateItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    newItemz.pathImage = openFileDialog.FileName;
                    OnPropertyChanged("newItemz");
                }
            });
            OpenDialogImageEditItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    itemDisplay.pathImage = openFileDialog.FileName;
                    OnPropertyChanged("itemDisplay");
                }

            });


            CommandCreateItem = new RelayCommand<object>(p => { return true; }, p =>
            {

                if (TypeOfItem.SelectedIndex == 0)
                {
                    CreateItem(AdminName, TableName.Saltyfood, str);
                    // DefaultDisplayItems();
                }
                else if (TypeOfItem.SelectedIndex == 1)
                {
                    CreateItem(AdminName, TableName.Desserts, str);
                    //DefaultDisplayItems();

                }
                else if (TypeOfItem.SelectedIndex == 2)
                {
                    CreateItem(AdminName, TableName.Drink, str);
                    //DefaultDisplayItems();

                }


            });
            //OpenCreateItem = new RelayCommand<object>(p => { return true; }, p => { });
            CloseViewCreateItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                newItemz.id = newItemz.namez = newItemz.price = newItemz.sale
                 = newItemz.information = newItemz.timeLine = newItemz.repaiTime = newItemz.pathImage = null;
                OnPropertyChanged("newItemz");
            });


            UpdateDataOfEditItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                var a = p as ListView;
                if (itemDisplay.id == "unknow")
                { MessageBox.Show("không có dữ liệu để cập nhập"); DefaultDisplayItems(); }
                else if (TypeOfItem.SelectedIndex == 0)
                {
                    EditItem(AdminName, TableName.Saltyfood, str);
                }
                else if (TypeOfItem.SelectedIndex == 1)
                {

                    EditItem(AdminName, TableName.Desserts, str);
                }
                else if (TypeOfItem.SelectedIndex == 2)
                {

                    EditItem(AdminName, TableName.Drink, str);
                }

            });


            SelectDispalayListItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                if (TypeOfItem.SelectedIndex == 0)
                {
                    UpdateListItem(AdminName, TableName.Saltyfood, str);
                    DefaultDisplayItems();
                }
                else if (TypeOfItem.SelectedIndex == 1)
                {
                    UpdateListItem(AdminName, TableName.Desserts, str);
                    DefaultDisplayItems();

                }
                else if (TypeOfItem.SelectedIndex == 2)
                {
                    UpdateListItem(AdminName, TableName.Drink, str);
                    DefaultDisplayItems();

                }
            });

            DeleteOneItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                if (TypeOfItem.SelectedIndex == 0)
                {
                    DeleteItem(AdminName, TableName.Saltyfood, str, itemDisplay);
                }
                else if (TypeOfItem.SelectedIndex == 1)
                {

                    DeleteItem(AdminName, TableName.Desserts, str, itemDisplay);
                }
                else if (TypeOfItem.SelectedIndex == 2)
                {
                    DeleteItem(AdminName, TableName.Drink, str, itemDisplay);
                }

            });
        }


        void UpdateListItem(string AdminName, string tableName, string connectionString)
        {
            ListItem.Clear();
            using (var command = new MySqlCommand())
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                command.Connection = connection;
                command.CommandText = $@"select * from {tableName} where userAdmin=@userAdmin";
                command.Parameters.AddWithValue("@userAdmin", AdminName);
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        ListItem.Add(new Itemz(result));
                    }
                    result.Close();
                }
                connection.Close();
            }


        }
        void DefaultDisplayItems()
        {
            if (ListItem.Count != 0)
            {
                DisplayItems(ListItem[0] as Itemz);// mặc định display item đầu tiên
            }
            else
            {
                FreeDataItem(itemDisplay);
                OnPropertyChanged("itemDisplay");
            }
        }
        void DisplayItems(Itemz item)
        {
            try
            {
                itemDisplay = item;
                itemDisplay.pathImage = System.IO.Path.GetFullPath(itemDisplay.pathImage);
                OnPropertyChanged("itemDisplay");
            }
            catch
            {

            }
        }
        void FreeDataItem(Itemz iz)
        {
            iz.id = iz.namez = iz.price = iz.sale
              = iz.information = iz.timeLine = iz.repaiTime = "unknow";
            iz.pathImage = null;
            // OnPropertyChanged("itemDisplay");
        }
        void CreateItem(string AdmimName, string tableName, string connectionString)
        {
            // kiểm tra dữ liệu đầu vào 

            if (checkstr(newItemz.namez))
            {
                warning = "xin hãy nhập tên sản phẩm";
                OnPropertyChanged("warning");

            }
            else if (checkstr(newItemz.price))
            {
                warning = "xin hãy nhập giá sản phẩm";
                OnPropertyChanged("warning");
            }
            else if (!checkint(newItemz.price))
            {
                warning = "xin hãy nhập giá là số nguyên";
                OnPropertyChanged("warning");
            }
            else if (checkstr(newItemz.sale))
            {
                warning = "xin hãy nhập mã giảm giá ";
                OnPropertyChanged("warning");
            }
            else if (!checkint(newItemz.sale))
            {
                warning = "xin hãy nhập mã giảm giá là số nguyên";
                OnPropertyChanged("warning");
            }
            else if (int.Parse(newItemz.sale.Trim()) < 0 || int.Parse(newItemz.sale.Trim()) > 100)
            {
                warning = "xin hãy nhập mã giảm giá từ 0 đến 100";
                OnPropertyChanged("warning");
            }
            else if (checkstr(newItemz.information))
            {
                warning = "xin hãy nhập thông tin sản phẩm";
                OnPropertyChanged("warning");
            }
            else if (checkstr(newItemz.pathImage))
            {
                warning = "xin hãy chọn hình ảnh";
                OnPropertyChanged("warning");
            }
            else
            {
                using (var command = new MySqlCommand())
                {
                    command.Connection = new MySqlConnection(connectionString);
                    command.Connection.Open();
                    command.CommandText = $"insert into {tableName}(namez  ,price ,pathImage ,information ,sale ,timeLine,repaiTime,userAdmin ) " +
                        "values(@namez  ,@price ,@pathImage ,@information ,@sale ,@timeLine,@repaiTime,@userAdmin )";
                    var a = DateTime.Now;
                    //dùng lam chuỗi lưu ảnh 
                    string ppath = a.Year.ToString() + a.Month.ToString() + a.Day.ToString()
                        + a.Hour.ToString() + a.Minute.ToString() + a.Second.ToString() + a.Millisecond.ToString();
                    newItemz.timeLine = newItemz.repaiTime = a.ToString();
                    string sk = newItemz.pathImage;
                    newItemz.pathImage = $@"../Images/{ppath}.jpg";
                    command.Parameters.AddWithValue("@userAdmin", AdmimName);
                    command.Parameters.AddWithValue("@namez", newItemz.namez);
                    command.Parameters.AddWithValue("@price", newItemz.price);
                    command.Parameters.AddWithValue("@pathImage", newItemz.pathImage);
                    command.Parameters.AddWithValue("@information", newItemz.information);
                    command.Parameters.AddWithValue("@sale", newItemz.sale);
                    command.Parameters.AddWithValue("@timeLine", newItemz.timeLine);
                    command.Parameters.AddWithValue("@repaiTime", newItemz.repaiTime);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    var s = System.Drawing.Image.FromFile(sk);
                    s.Save(newItemz.pathImage);
                    warning = "tạo thành công ";
                    OnPropertyChanged("warning");
                    HistoryData(AdminName, tableName, TypeDIU.Insert, connectionString, newItemz);
                    UpdateListItem(AdmimName, tableName, connectionString);
                    if (itemDisplay.pathImage == null) DefaultDisplayItems();
                }
            }
        }


        bool checkstr(string strCheck)
        {
            if (strCheck == null) return true;
            else if (strCheck.Length == 0) return true;
            else if (strCheck.Trim().Length == 0) return true;
            return false;
        }
        bool checkint(string strCheck)
        {
            try
            {
                int a = int.Parse(strCheck.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        void DeleteItem(string AdminName, string tableName, string connectionString, Itemz isDeleteitem)
        {
            if (ListItem.Count != 0)
            {
                using (var command = new MySqlCommand())
                {
                    command.Connection = new MySqlConnection(connectionString);
                    command.Connection.Open();
                    command.CommandText = $"delete from {tableName} where id=@id and userAdmin=@userAdmin";
                    command.Parameters.AddWithValue("@id", isDeleteitem.id);
                    command.Parameters.AddWithValue("@userAdmin", AdminName);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    ListItem.Clear();
                }
                UpdateListItem(AdminName, tableName, connectionString);
                if (ListItem.Count != 0)
                {
                    HistoryData(AdminName, tableName, TypeDIU.Delete, connectionString, isDeleteitem);
                    DefaultDisplayItems();
                }
                else
                {
                    HistoryData(AdminName, tableName, TypeDIU.Delete, connectionString, isDeleteitem);
                    DefaultDisplayItems();
                }

            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa");
            }
        }
        void EditItem(string AdminName, string tableName, string connectionString)
        {
            if (itemDisplay == null || itemDisplay.id == null) MessageBox.Show("Không có dữ liệu");
            else if (checkstr(itemDisplay.namez))
            {
                warning = "xin hãy nhập tên sản phẩm";
                OnPropertyChanged("warning");

            }
            else if (checkstr(itemDisplay.price))
            {
                warning = "xin hãy nhập giá sản phẩm";
                OnPropertyChanged("warning");
            }
            else if (!checkint(itemDisplay.price))
            {
                warning = "xin hãy nhập giá là số nguyên";
                OnPropertyChanged("warning");
            }
            else if (checkstr(itemDisplay.sale))
            {
                warning = "xin hãy nhập mã giảm giá ";
                OnPropertyChanged("warning");
            }
            else if (!checkint(itemDisplay.sale))
            {
                warning = "xin hãy nhập mã giảm giá là số nguyên";
                OnPropertyChanged("warning");
            }
            else if (int.Parse(itemDisplay.sale.Trim()) < 0 || int.Parse(itemDisplay.sale.Trim()) > 100)
            {
                warning = "xin hãy nhập mã giảm giá từ 0 đến 100";
                OnPropertyChanged("warning");
            }
            else if (checkstr(itemDisplay.information))
            {
                warning = "xin hãy nhập thông tin sản phẩm";
                OnPropertyChanged("warning");
            }
            else if (checkstr(itemDisplay.pathImage))
            {
                warning = "xin hãy chọn hình ảnh";
                OnPropertyChanged("warning");
            }
            else
            {

                using (var command = new MySqlCommand())
                {
                    command.Connection = new MySqlConnection(connectionString);
                    command.Connection.Open();

                    command.CommandText = $"update {tableName} set namez=@namez  , price=@price ,pathImage=@pathImage , information=@information" +
                     $" ,sale=@sale ,repaiTime=@repaiTime where id =@id and userAdmin=@userAdmin";
                    command.Parameters.AddWithValue("@namez", itemDisplay.namez);
                    command.Parameters.AddWithValue("@id", itemDisplay.id);
                    command.Parameters.AddWithValue("@price", itemDisplay.price);
                    command.Parameters.AddWithValue("@pathImage", itemDisplay.pathImage);
                    command.Parameters.AddWithValue("@information", itemDisplay.information);
                    command.Parameters.AddWithValue("@sale", itemDisplay.sale);
                    command.Parameters.AddWithValue("@userAdmin", AdminName);
                    command.Parameters.AddWithValue("@repaiTime", DateTime.Now.ToString());
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("cập nhật thành công");
                    HistoryData(AdminName, tableName, TypeDIU.Update, connectionString, itemDisplay);
                    UpdateListItem(AdminName, tableName, connectionString);


                }

            }

        }

        void HistoryData(string userAdmin, string tableName, TypeDIU typeDIU, string connectionString, Itemz itemDelete)
        {
            
            if (typeDIU == TypeDIU.Delete)
                diuz = "Delete";
            else if (typeDIU == TypeDIU.Insert)
                diuz = "Insert";
            else if (typeDIU == TypeDIU.Update) 
                diuz = "Update";

                using (var command = new MySqlCommand())
                {
                    command.Connection = new MySqlConnection(connectionString);
                    command.Connection.Open();
                    command.CommandText = $"insert into historyOfData(userAdmin,diu,tableName,id,namez,timeLine,pathImage) " +
                            $"values(@userAdmin,@diu,@tableName,@id,@namez,@timeLine,@pathImage)";
                    command.Parameters.AddWithValue("@pathImage", itemDelete.pathImage);
                    command.Parameters.AddWithValue("@userAdmin", AdminName);
                    command.Parameters.AddWithValue("@diu", $"{diuz}");
                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@id", itemDelete.id);
                    command.Parameters.AddWithValue("@namez", itemDelete.namez);
                    command.Parameters.AddWithValue("@timeLine", DateTime.Now.ToString());
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
        }
        void DeleteFilePathImage(string userAdmin, string tableName, TypeDIU typeDIU, string connectionString)
        {
            if (typeDIU == TypeDIU.Delete)
                using (var command = new MySqlCommand())
                {
                    command.Connection = new MySqlConnection(connectionString);
                    command.Connection.Open();
                    command.CommandText = $"select pathImage from {tableName} where userAdmin=@userAdmin and diu=@diu";
                    command.Parameters.AddWithValue("@userAdmin", userAdmin);
                    command.Parameters.AddWithValue("@diu", "Delete");
                    var result = command.ExecuteReader();
                    ObservableCollection<string> l = new ObservableCollection<string>();
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {
                            l.Add(result.GetString("pathImage"));
                        }
                        result.Close();
                    }
                    command.Connection.Close();
                    foreach (var item in l)
                    {
                        try
                        {
                            if (System.IO.File.Exists(item))
                            {

                                System.IO.File.Delete(item);
                            }

                        }
                        catch
                        {

                        }

                    }
                }
        }

        private bool UserFilter(object it)
        {
            if (String.IsNullOrEmpty(SearchItem))
                return true;
            else
                return ((it as Itemz).namez.IndexOf(SearchItem, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
