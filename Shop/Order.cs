using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Order
    {

        public int number;
        public string client;
        public string manager;
        private string _dateOrder;
        private double _code;
        public Goods _goods;

        public Order()
        {

        }

        public string DateOrder
        {
            set { _dateOrder = value; }
            get { return _dateOrder; }
        }
        public double Code
        {
            set { _code = value; }
            get { return _code; }
        }

        public string IsYourClient
        {
            set { client = value; }
            get { return client; }
        }
        public void IsYourGoods(string nameGoods)
        {
            Goods[] arr = GoodFactory.array_Goods;
            foreach (Goods i in arr)
            {
                if (nameGoods == i._name.Name)
                {
                    _goods = i;
                }
            }
        }

        public string ISYourManager
        {
            set { manager = value; }
            get { return manager; }
        }

        public void SetFields()
        {
            DateOrder = (String)OrdersForm.dataOrders[2, number].Value;
            Code = Convert.ToDouble(OrdersForm.dataOrders[3, number].Value);
            IsYourClient=((String)OrdersForm.dataOrders[0, number].Value);
            ISYourManager=((String)OrdersForm.dataOrders[1, number].Value);
            IsYourGoods((String)OrdersForm.dataOrders[4, number].Value);
        }
    }
}
