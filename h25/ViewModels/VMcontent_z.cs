using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Base_z;
using System.Windows.Media;
using System.Windows.Documents;
using h25.Views;
using h25.Model;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;
using System.Windows.Data;

namespace h25.ViewModels
{
    class VMcontent_z : BaseViewModel
    {
        Visibility hideAdmin;
        Visibility hideUser;
        public Visibility HideAdmin { get => hideAdmin; set { hideAdmin = value; OnPropertyChanged(); } }
        public Visibility HideUser { get => hideUser; set { hideUser = value; OnPropertyChanged(); } }
        private List<Button> buttons;
        public List<ICommand> listIsLoad { get; set; }
        public btn btn { get; set; }
        public ICommand checkz { get; set; }
        public ICommand thongbao { get; set; }
        public ICommand rethongbao { get; set; }
        public ICommand openItem { get; set; }
        public ICommand OpenAdminDIU { get; set; }
        public ICommand SearchNamezOfItem { get; set; }
        public ICommand SlectContentListItem { get; set; }
        public ICommand GetLisViewItem { get; set; }
        string connectionString = VMmain.connectionString;
        public ObservableCollection<Itemz> ListItem { get; set; }
        public static ListBox ListViewItem { get; set; }
        public string SearchItem { get; set; }
        private VItemz item;
        public VMcontent_z()
        {
            initialization();

        }

        void initialization()
        {
            btn = new btn();
            item = new VItemz();
            buttons = new List<Button>();
            {
                ListItem = new ObservableCollection<Itemz>();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListItem);
                view.Filter = UserFilter;

            }
            GetLisViewItem = new RelayCommand<ListBox>(p => { return true; }, p => { ListViewItem = p; });
            SearchNamezOfItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                CollectionViewSource.GetDefaultView(ListItem).Refresh();
                OnPropertyChanged("listItem");
            });
            listIsLoad = new List<ICommand>();
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));
            listIsLoad.Add(new RelayCommand<Button>(p => { return true; }, p => { buttons.Add(p); }));

            checkz = new RelayCommand<Button>(p => { return true; }, p =>
            {
                var g = p.Content as Border;
                g.MinWidth = 50;

                g.BorderBrush = new SolidColorBrush(Color.FromRgb(122, 129, 206));
                g.BorderThickness = new Thickness(0, 0, 0, 4);
                foreach (var item in buttons)
                {
                    if (p != item)
                    {
                        var g1 = item.Content as Border;

                        g1.BorderThickness = new Thickness(0, 0, 0, 0);

                    }
                }

            });
            openItem = new RelayCommand<object>(p => { return true; }, p =>
            {
                VItemz a = new VItemz();
                a.ShowDialog();

            });
            OpenAdminDIU = new RelayCommand<object>(p => { return true; }, p =>
            {
                VMmain.MainWindow.Visibility = Visibility.Collapsed;
                var add = new Add(); add.ShowDialog();
                VMmain.MainWindow.Visibility = Visibility.Visible;
            });

            SlectContentListItem = new RelayCommand<Button>(p => { return true; }, p =>
            {
                if (p.Name == "saltyfood")
                {
                    LoadListItem("gamoet1", TableName.Saltyfood, connectionString);

                }
                else if (p.Name == "desserts")
                {

                    LoadListItem("gamoet1", TableName.Desserts, connectionString);
                }
                else if (p.Name == "drink")
                {
                    LoadListItem("gamoet1", TableName.Drink, connectionString);
                }
            });
        }

        void LoadListItem(string adminName, string tableName, string connectionString)
        {
            using (var command = new MySqlCommand())
            {
                command.Connection = new MySqlConnection(connectionString);
                command.Connection.Open();
                command.CommandText = $"select * from {tableName} where userAdmin=@userAdmin";
                command.Parameters.AddWithValue("@userAdmin", adminName);
                ListItem.Clear();// xóa dư liệu danh sách hiện tại để chuản bị cập nhật
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        var item = new Itemz(result);
                        item.pathImage = System.IO.Path.GetFullPath(item.pathImage);

                        if (int.Parse(item.sale) != 0)
                        {
                            var g = double.Parse(item.price) * (1 - double.Parse(item.sale) / 100);
                            item.price = $@"{(int)g} vnđ ( {item.price} vnđ)";
                        }
                        else
                        {
                            item.price = $@" {item.price} vnđ";
                        }
                        item.sale = $@"{item.sale} %";
                        ListItem.Add(item);
                    }
                    result.Close();
                }
                command.Connection.Close();
            }
        }
        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(SearchItem))
                return true;
            else
                return ((item as Itemz).namez.IndexOf(SearchItem, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
