
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
        public ICommand isLoad1 { get; set; }
        public ICommand isLoad2 { get; set; }
        public ICommand isLoad3 { get; set; }
        public ICommand createItem { get; set; }
        public ICommand closeOpenCreateItem { get; set; }
        public ICommand OpenCreateItem { get; set; }
        public ICommand openDialogImage { get; set; }
        public ICommand OpenDialogEditImage { get; set; }
        public ICommand closeOpenEditItem { get; set; }
        public ICommand UpdateEditItem { get; set; }
        public ICommand selectItem { get; set; }
        public ICommand itemDelete { get; set; }
        public ICommand selectF { get; set; }
        public ICommand isSearchOfNamez { get; set; }
        public Itemz itemDisplay { get; set; }

        public string warning { get; set; }
        public string SearchItem { get; set; }
        public ObservableCollection<Itemz> items { get; set; }
        public Itemz newItemz { get; set; }
        string str = @"server=127.0.0.1;database=gamoet1;user id=root;password=22022000;port=3306";
        private Image imageDisplay;
        private Image imageCreate;
        private ComboBox comboBoxCheck;

        // MySqlConnection connection;
        public VMadd()
        {

            InitializeComponent();


        }
        void InitializeComponent()
        {
            str = VMmain.connectionString;
            btn = new btn();
            newItemz = new Itemz();// khởi tạo đầu tiên
            itemDisplay = new Itemz();
            {
                items = new ObservableCollection<Itemz>();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(items);
                view.Filter = UserFilter;
            }
            
            isLoad1 = new RelayCommand<Image>(p => { return true; }, p => { imageDisplay = p; DeleteFilePathImage("pathImageRemove", str); });
            isLoad2 = new RelayCommand<Image>(p => { return true; }, p => { imageCreate = p;  });

            isLoad3 = new RelayCommand<object>(p => { return true; }, p =>
            {
                comboBoxCheck = p as ComboBox;
                UpdateData("saltyfood", str); // mặc đinh load đồ ăn mặn

            });
            isSearchOfNamez= new RelayCommand<object>(p => { return true; }, p => {
                CollectionViewSource.GetDefaultView(items).Refresh();
            });
            selectItem = new RelayCommand<ListView>(p => { return true; }, p =>
            {
                if (p.SelectedItem != null)
                {
                    LoadDisplayItem(p.SelectedItem as Itemz);
                }
            });
            createItem = new RelayCommand<object>(p => { return true; }, p =>
            {

                if (comboBoxCheck.SelectedIndex == 0)
                {
                    CreateData("saltyfood", str);
                }
                else if (comboBoxCheck.SelectedIndex == 1)
                {
                    CreateData("desserts", str);
                }
                else if (comboBoxCheck.SelectedIndex == 2)
                {
                    CreateData("drink", str);
                }
                // CreateData("drink", str); 
            });
            OpenCreateItem = new RelayCommand<object>(p => { return true; }, p => { });
            closeOpenCreateItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                newItemz.id = newItemz.namez = newItemz.price = newItemz.sale
                 = newItemz.information = newItemz.timeLine = newItemz.repaiTime = newItemz.pathImage = null;
                OnPropertyChanged("newItemz");
            });
            closeOpenEditItem= new RelayCommand<object>(p => { return true; }, p => {
                if (comboBoxCheck.SelectedIndex == 0)
                {
                    UpdateData("saltyfood", str);
                }
                else if (comboBoxCheck.SelectedIndex == 1)
                {

                    UpdateData("desserts", str);
                }
                else if (comboBoxCheck.SelectedIndex == 2)
                {
                    UpdateData("drink", str);
                }
            });
            UpdateEditItem = new RelayCommand<object>(p => { return true; }, p => {
                if (comboBoxCheck.SelectedIndex == 0)
                {
                    EditData("saltyfood", str);
                }
                else if (comboBoxCheck.SelectedIndex == 1)
                {

                   // UpdateData("desserts", str);
                    EditData("desserts", str);
                }
                else if (comboBoxCheck.SelectedIndex == 2)
                {
                   // UpdateData("drink", str);
                    EditData("drink", str);
                }
                

            });

            openDialogImage = new RelayCommand<object>(p => { return true; }, p =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    newItemz.pathImage = openFileDialog.FileName;
                    OnPropertyChanged("newItemz");                  
                }
            });
            OpenDialogEditImage = new RelayCommand<object>(p => { return true; }, p => {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                     itemDisplay.pathImage = openFileDialog.FileName;
                    OnPropertyChanged("itemDisplay");
                }

            });
            selectF = new RelayCommand<object>(p => { return true; }, p =>
            {
                if (comboBoxCheck.SelectedIndex == 0)
                {
                    UpdateData("saltyfood", str);
                }
                else if (comboBoxCheck.SelectedIndex == 1)
                {

                    UpdateData("desserts", str);
                }
                else if (comboBoxCheck.SelectedIndex == 2)
                {
                    UpdateData("drink", str);
                }
            });
            itemDelete = new RelayCommand<object>(p => { return true; }, p =>
            {
                if (comboBoxCheck.SelectedIndex == 0)
                {
                    DeleteData("saltyfood", str, itemDisplay);
                }
                else if (comboBoxCheck.SelectedIndex == 1)
                {

                    DeleteData("desserts", str, itemDisplay);
                }
                else if (comboBoxCheck.SelectedIndex == 2)
                {
                    DeleteData("drink", str, itemDisplay);
                }

            });
        }
        void isLoadData()
        {

        }
        void UpdateData(string tableName, string connectionString)
        {
            {// cho mặc định ko có dữ li
                itemFreeData(itemDisplay);
                OnPropertyChanged("itemDisplay");
                items.Clear();
            }
           
            using (var command = new MySqlCommand())
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"select * from {tableName}";
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    
                    while (result.Read())
                    {
                        items.Add(new Itemz(result));
                    }
                    result.Close();
                }
                connection.Close();
            }
            if (items.Count != 0)
            {
                LoadDisplayItem(items[0] as Itemz);
            }
           
        }
        void LoadDisplayItem(Itemz item)
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
        void itemFreeData(Itemz iz)
        {
            iz.id = iz.namez = iz.price = iz.sale
              = iz.information = iz.timeLine = iz.repaiTime = "unknow";
            iz.pathImage = null;
            // OnPropertyChanged("itemDisplay");
        }
        void CreateData(string tableName, string connectionString)
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
                    command.CommandText = $"insert into {tableName}(namez  ,price ,pathImage ,information ,sale ,timeLine,repaiTime ) " +
                        "values(@namez  ,@price ,@pathImage ,@information ,@sale ,@timeLine,@repaiTime )";
                    var a = DateTime.Now;
                    //dùng lam chuỗi lưu ảnh 
                    string ppath = a.Year.ToString() + a.Month.ToString() + a.Day.ToString() 
                        + a.Hour.ToString() + a.Minute.ToString() + a.Second.ToString() +a.Millisecond.ToString();
                    newItemz.timeLine = newItemz.repaiTime = a.ToString();
                    string sk = newItemz.pathImage;
                    newItemz.pathImage = $@"../Images/{ppath}.jpg";
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
                }
                warning = "tạo thành công ";
                OnPropertyChanged("warning");
                UpdateData(tableName, connectionString);
            }
        }
        void DeleteData(string tableName, string connectionString, Itemz isDeleteitem)
        {
            if (items.Count != 0)
            {
                using (var command = new MySqlCommand())
                {
                    command.Connection = new MySqlConnection(connectionString);
                    command.Connection.Open();
                    command.CommandText = $"delete from {tableName} where id=@id";
                    command.Parameters.AddWithValue("@id", isDeleteitem.id);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    items.Clear();
                }
                fileImageIsRemove("pathimageremove",connectionString,isDeleteitem.pathImage);
                UpdateData(tableName, connectionString);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa");
            }
        }
        void EditData(string tableName, string connectionString)
        {
            if (checkstr(itemDisplay.namez))
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
                     $" ,sale=@sale ,repaiTime=@repaiTime where id =@id";
                    command.Parameters.AddWithValue("@namez", itemDisplay.namez);
                    command.Parameters.AddWithValue("@id", itemDisplay.id);
                    command.Parameters.AddWithValue("@price", itemDisplay.price);
                    command.Parameters.AddWithValue("@pathImage", itemDisplay.pathImage);
                    command.Parameters.AddWithValue("@information", itemDisplay.information);
                    command.Parameters.AddWithValue("@sale", itemDisplay.sale);
                    //command.Parameters.AddWithValue("@timeLine", newItemz.timeLine);
                    command.Parameters.AddWithValue("@repaiTime", itemDisplay.repaiTime);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("cập nhật thành công");
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
        void fileImageIsRemove(string tablename,string connectionString,string PathImageRemove)
        {
            using (var command =new MySqlCommand())
            {
                command.Connection = new MySqlConnection(connectionString);
                command.Connection.Open();
                command.CommandText = $"insert into {tablename}(pathImage) values(@pathImage)";
                command.Parameters.AddWithValue("@pathImage", PathImageRemove);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
        void DeleteFilePathImage(string tablename, string connectionString)
        {
            using (var command = new MySqlCommand())
            {
                command.Connection = new MySqlConnection(connectionString);
                command.Connection.Open();
                command.CommandText = $"select * from {tablename}";
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
