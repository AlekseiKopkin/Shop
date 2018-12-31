

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop;

namespace TestShop
{
    [TestClass]
    public class tests
    {

        [TestMethod]
        public void checkDelManager()
        {
            managers form = new managers();
            //add 3 records
            managers.dataManagers.Rows.Add("1", "Petya", "8888", "Менеджер", "petya","22 мая");
            managers.dataManagers.Rows.Add("2", "Vasya", "6666", "Менеджер", "vas", "22 мая");
            managers.dataManagers.Rows.Add("3", "Egor", "3333", "Менеджер", "egor", "22 мая");

            ManagerTypeCol coll = new ManagerTypeCol();
            ManagerFactory fact = new ManagerFactory();
            int a = ManagerFactory.count();
            ManagerFactory.DeleteManager(1);
            Assert.AreEqual(a - 1, ManagerFactory.count());
        }

        [TestMethod]
        public void checkDelClien()
        {

            Clients form = new Clients();
            Clients.dataClients.Rows.Add("1", "Petya", "1@gmail.com", "88-88", "12 may 1990", "true", "VIP");
            Clients.dataClients.Rows.Add("2", "Vasya", "12gmail.com", "66-66", "13 may 1990", "false", "VIP");
            Clients.dataClients.Rows.Add("3", "Egor", "123@gmail.com", "333-3", "14 may 1990", "true", "VIP");

            ClientTypeCol col = new ClientTypeCol();
            ClientFactory fact = new ClientFactory();
            int a = ClientFactory.count();
            ClientFactory.DeleteCLient(1);
            Assert.AreEqual(a - 1, ClientFactory.count());

        }

        [TestMethod]
        public void checkAddClien()
        {
            string[] client = new string[7];
            client[0] = "225";
            client[1] = "Petr";
            client[2] = "petr@gmail.com";
            client[3] = "8932422-34";
            client[4] = "11 may 1990";
            client[5] = "VIP";

            Clients form = new Clients();
            Clients.dataClients.Rows.Add("1", "Petya", "1@gmail.com", "88-88", "12 may 1990", "VIP");
            Clients.dataClients.Rows.Add("2", "Vasya", "12gmail.com", "66-66", "13 may 1990", "VIP");
            Clients.dataClients.Rows.Add("3", "Egor", "123@gmail.com", "333-3", "14 may 1990", "VIP");

            ClientTypeCol col = new ClientTypeCol();
            ClientFactory fact = new ClientFactory();
            int a = ClientFactory.count();
            ClientFactory.AddClient(client);
            Assert.AreEqual(a + 1, ClientFactory.count());

        }
        [TestMethod]
        public void checkAddOrder()
        {
            string[] order = new string[5];
            order[0] = "225";
            order[1] = "Petr";
            order[2] = "Vasya";
            order[3] = "12 may 2013";
            order[4] = "goods";

            Clients formCL = new Clients();
            Clients.dataClients.Rows.Add("1", "Pet", "1@gmail.com", "88-88", "12 may 1990",  "VIP");
            ClientTypeCol col = new ClientTypeCol();
            ClientFactory factCl = new ClientFactory();

            managers formMan = new managers();
            managers.dataManagers.Rows.Add("1", "Petya", "8888", "Менеджер", "petya"," 22 мая");
            ManagerTypeCol coll = new ManagerTypeCol();
            ManagerFactory factMan = new ManagerFactory();

            OrdersForm formOrd = new OrdersForm();
            OrdersForm.dataOrders.Rows.Add("Pet", "Petya", "12 may 2015", "1", "Goods1");
            OrdersForm.dataOrders.Rows.Add("Pet", "Petya", "13 may 2014", "2", "Goods2");
            OrdersForm.dataOrders.Rows.Add("Pet", "Petya", "14 may 2014", "3", "Goods3");

            TypeGoodsForm type = new TypeGoodsForm();
            TypeGoodsForm.dataTypeGoods.Rows.Add("1", "Саморез");
            TypeGoodsCol obj = new TypeGoodsCol();

            GoodsTypeCol goodstype = new GoodsTypeCol();

            GoodsForm formGoods = new GoodsForm();
            GoodsForm.dataGoods.Rows.Add("1", "goods", "type", "12000", "Рубль");
            GoodFactory factTour = new GoodFactory();
            OrderFactory fact = new OrderFactory();
            int a = OrderFactory.count();
            OrderFactory.AddOrder(order);
            Assert.AreEqual(a + 1, OrderFactory.count());

        }
        [TestMethod]
        public void checkDelTour()
        {

            TypeGoodsForm contr = new TypeGoodsForm();
            TypeGoodsForm.dataTypeGoods.Rows.Add("1", "Саморез");
            TypeGoodsCol obj = new TypeGoodsCol();

            GoodsForm formTour = new GoodsForm();
            GoodsForm.dataGoods.Rows.Add("1", "goods", "Type", "12000", "Рубль");
            GoodsForm.dataGoods.Rows.Add("2", "goods", "Type", "12000", "Рубль");
            GoodsForm.dataGoods.Rows.Add("3", "goods", "Type", "12000", "Рубль");

            GoodsTypeCol tourtype = new GoodsTypeCol();

            GoodFactory factTour = new GoodFactory();
            int a = GoodFactory.count();
            GoodFactory.DeleteGoods(1);
            Assert.AreEqual(a - 1, GoodFactory.count());
        }
        [TestMethod]
        public void checkAddTour()
        {

            string[] goods = new string[10];
            goods[0] = "2";
            goods[1] = "goods";
            goods[2] = "Type ";
            goods[3] = "35500";
            goods[4] = "Доллар";

            TypeGoodsForm contr = new TypeGoodsForm();
            TypeGoodsForm.dataTypeGoods.Rows.Add("1", "Саморез");
            TypeGoodsCol obj = new TypeGoodsCol();

            GoodsForm formTour = new GoodsForm();
            GoodsForm.dataGoods.Rows.Add("1", "goods", "VIP туры", "12000", "Рубль");
          
            GoodsTypeCol tourtype = new GoodsTypeCol();

            GoodFactory factTour = new GoodFactory();
            int a = GoodFactory.count();
            GoodFactory.Add_Goods(goods);
            Assert.AreEqual(a + 1, GoodFactory.count());
        }

        [TestMethod]
        public void checkWrongPassword()
        {
            AccessToSystem acc = new AccessToSystem();
            Assert.AreNotEqual(User.Check("Anisimov", "fjdsfadfaf"), true);

        }

        [TestMethod]
        public void checkCorrectPassword()
        {
            AccessToSystem acc = new AccessToSystem();
            Assert.AreEqual(User.Check("Kornilov", "password"), true);
        }

        [TestMethod]
        public void changePassword()
        {
            AccessToSystem acc = new AccessToSystem();
            User.Check("Kornilov", "password");

            change_password form = new change_password();
            form.textBox1.Text = "pass";
            form.ChangePass();
            Assert.AreEqual(User.Check("Kornilov", "pass"), true);
        }
    }
}
