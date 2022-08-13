using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Windows;


namespace DB_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ApplicationContext DB;
        public MainWindow()
        {
            InitializeComponent();

            DB = new ApplicationContext("shopGoodsDB.db");
            DB.Goods.Load();
            this.DataContext = DB.Goods.Local.ToBindingList();

            bool showAbout = bool.Parse(ConfigurationManager.AppSettings["showHello"]);
            CheckAbout.IsChecked = showAbout;

            if (showAbout)
            {
                ShowGreetingForm();
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DataBase.AddGoods(DB);
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (goodsList.SelectedItem == null) return;

            Goods item = goodsList.SelectedItem as Goods;

            GoodsWindow goodsWindow = new GoodsWindow(new Goods
            {
                id = item.id,
                Title = item.Title,
                Left = item.Left,
                Price = item.Price
            });

            if (goodsWindow.ShowDialog() == true)
            {
                DataBase.EditGoods(item, DB, goodsWindow);
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (goodsList.SelectedItem == null) return;
            Goods item = goodsList.SelectedItem as Goods;
            DataBase.DeleteGoods(item, DB);
        }
        private void ShowGreetingForm()
        {
            new About().Show();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            ShowGreetingForm();
        }
        private void CheckAbout_Click(object sender, RoutedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            bool show = !bool.Parse(ConfigurationManager.AppSettings["showHello"]);
            config.AppSettings.Settings["showHello"].Value = (show).ToString();
            config.Save();
            CheckAbout.IsChecked = show;
            ConfigurationManager.RefreshSection("appSettings");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void File_Click(object sender, RoutedEventArgs e)
        {
            var goods = new List<Goods>(DB.Goods.ToList());
            var data = new List<String>();
            String str = "";

            foreach (Goods item in goods)
            {
                str = item.Title + " " + item.Left + " " + item.Price;
                data.Add(str);
            }

            FileWork.SaveToFile(data);
        }
    }
}
