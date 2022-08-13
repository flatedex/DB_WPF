using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace DB_WPF
{
    /// <summary>
    /// Interaction logic for goodsWindow.xaml
    /// </summary>
    public partial class GoodsWindow : Window
    {
        public Goods goods { get; set; }
        public GoodsWindow(Goods item)
        {
            InitializeComponent();
            goods = item;
            this.DataContext = goods;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void LeftChangedEvent(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
        private void PriceChangedEvent(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".") && (!PriceBox.Text.Contains(".") && PriceBox.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
    }
}
