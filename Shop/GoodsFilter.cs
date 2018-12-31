using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class GoodsFilter
    {
        static public List<Goods> filtrGoods;

        public void addGoods(Goods goods)
        {
            filtrGoods.Add(goods);
        }

        static public void fun()
        {
            int a = 1;
            foreach (Goods i in filtrGoods)
            {
                a++;
            }
        }
        public GoodsFilter()
        {
            filtrGoods = new List<Goods>();
        }
        static public int count()
        {
            return filtrGoods.Count();
        }
    }
}
