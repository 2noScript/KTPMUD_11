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
        Visibility isHide;
        Visibility isHide_z;
        public Visibility IsHide { get => isHide; set { isHide = value; OnPropertyChanged(); } }
        public Visibility IsHide_z { get => isHide_z; set { isHide_z = value; OnPropertyChanged(); } }
        private List<Button> buttons;
        public List<ICommand> listIsLoad { get; set; }
        public ICommand checkz { get; set; }

        public ICommand thongbao { get; set; }
        public ICommand rethongbao { get; set; }
        public ICommand openItem { get; set; }
        public ICommand openAdd { get; set; }
        public ICommand isSearchOfNamez { get; set; }

        public ICommand slectContentListItem { get; set; }
        string connectionString = VMmain.connectionString;
        public ObservableCollection<Itemz> listItem { get; set; }
        public string SearchItem { get; set; }
        public VMcontent_z()
        {
            initialization();
            LoadData("saltyfood", connectionString);
        }

        void initialization()
        {
            buttons = new List<Button>();            

            {
                listItem = new ObservableCollection<Itemz>();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listItem);
                view.Filter = UserFilter;
                
            }
            isSearchOfNamez = new RelayCommand<object>(p => { return true; }, p => {
                //CollectionViewSource.GetDefaultView(listItem).Refresh();
                MessageBox.Show("what");
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
                var item = new itemz();
                item.ShowDialog();
            });
            openAdd = new RelayCommand<object>(p => { return true; }, p => { var add = new Add(); add.ShowDialog(); });
            slectContentListItem = new RelayCommand<Button>(p => { return true; }, p =>
            {
                if (p.Name == "btn1")
                {
                    LoadData("saltyfood", connectionString);
                    //MessageBox.Show(p.Name);
                }
                else if (p.Name == "btn2")
                {
                    //MessageBox.Show(p.Name);
                    LoadData("desserts", connectionString);
                }
                else if (p.Name == "btn3")
                {
                    LoadData("drink", connectionString);
                }
            });
        }
        
        void LoadData(string tableName, string connectionString)
        {
            using (var command = new MySqlCommand())
            {
                command.Connection = new MySqlConnection(connectionString);
                command.Connection.Open();
                command.CommandText = $"select * from {tableName}";
                listItem.Clear();
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        var a = new Itemz(result);
                        a.pathImage = System.IO.Path.GetFullPath(a.pathImage);

                        if (int.Parse(a.sale) != 0)
                        {
                            var g = double.Parse(a.price) * (1 - double.Parse(a.sale) / 100);
                            a.price = $@"{(int)g} vnđ ( {a.price} vnđ)";
                        }
                        a.sale = $@"{a.sale} %";
                        listItem.Add(a);
                    }
                    result.Close();
                }

                command.Connection.Close();
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
