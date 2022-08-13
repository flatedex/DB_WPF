using System;
using System.Data.Entity;

namespace DB_WPF
{
    public static class DataBase
    {
        public static void AddGoods(ApplicationContext DB)
        {
            GoodsWindow goodsWindow = new GoodsWindow(new Goods());
            if (goodsWindow.ShowDialog() == true)
            {
                Goods goods = goodsWindow.goods;
                DB.Goods.Add(goods);
                DB.SaveChanges();
            }
        }
        public static void AddGoods(ApplicationContext DB, String title, int left, int price)
        {
            Goods goods = new Goods();
            goods.Title = title;
            goods.Left = left;
            goods.Price = price;
            DB.Goods.Add(goods);
            DB.SaveChanges();
        }
        public static void EditGoods(Goods item, ApplicationContext DB, GoodsWindow goodsWindow)
        {
            item = DB.Goods.Find(goodsWindow.goods.id);
            if (item != null)
            {
                item.Title = goodsWindow.goods.Title;
                item.Left = goodsWindow.goods.Left;
                item.Price = goodsWindow.goods.Price;
                DB.Entry(item).State = EntityState.Modified;
                DB.SaveChanges();
            }
        }
        public static void EditGoods(Goods item, String newTitle, int newLeft, int newPrice, ApplicationContext DB, int id)
        {
            item = DB.Goods.Find(id);
            if (item != null)
            {
                item.Title = newTitle;
                item.Left = newLeft;
                item.Price = newPrice;
                DB.SaveChanges();
            }
        }
        public static void DeleteGoods(Goods item, ApplicationContext DB)
        {
            DB.Goods.Remove(item);
            DB.SaveChanges();
        }
    }
}
