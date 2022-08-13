using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DB_WPF
{
    public class Goods : INotifyPropertyChanged
    {
        private String title;
        private int left;
        private int price;
        public int id { get; set; }

        public String Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public int Left
        {
            get { return left; }
            set
            {
                left = value;
                OnPropertyChanged("Left");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
