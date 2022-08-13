using DB_WPF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DBTest
{
    [TestClass]
    public class UnitTest1
    {
        ApplicationContext DB = new ApplicationContext("shopGoodsDBTests.db");

        [TestMethod]
        public void TestMethod1()
        {
            DataBase.AddGoods(DB, "TestProduct0", 5, 69);
            var listDB = DB.Goods.ToList();
            Goods afterInsert = listDB[listDB.Count - 1];
            Assert.AreEqual("TestProdut", afterInsert.Title);
            Assert.AreEqual("5", afterInsert.Left);
            Assert.AreEqual("69", afterInsert.Price);
            DB.Goods.Remove(afterInsert);
            DB.SaveChanges();
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataBase.AddGoods(DB, "TestProduct1", 10, 24);
            var listDB = DB.Goods.ToList();
            Goods toDelete = listDB[listDB.Count - 1];
            DataBase.DeleteGoods(toDelete, DB);
            var listAfterDelete = DB.Goods.ToList();
            Goods afterDelete = listAfterDelete[listAfterDelete.Count - 1];
            Assert.AreNotEqual("TestProdut", afterDelete.Title);
            Assert.AreNotEqual("5", afterDelete.Left);
            Assert.AreNotEqual("69", afterDelete.Price);
            DB.SaveChanges();
        }
        [TestMethod]
        public void TestMethod3()
        {
            var listDB = DB.Goods.ToList();
            Goods toUpdate = listDB[0];
            int id = toUpdate.id;
            DataBase.EditGoods(toUpdate, "newTitle", 50, 999, DB, id);
            var listAfterUpdate = DB.Goods.ToList();
            Goods AfterUpdate = listAfterUpdate[0];
            Assert.AreEqual("NewTitle", AfterUpdate.Title);
            Assert.AreEqual("50", AfterUpdate.Left);
            Assert.AreEqual("999", AfterUpdate.Price);
            DB.SaveChanges();
        }
    }
}