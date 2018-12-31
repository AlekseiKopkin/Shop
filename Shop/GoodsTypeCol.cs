using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class GoodsTypeCol
    {
        private Dictionary<int, string> dict;
        static public GoodsType[] list;
        public GoodsTypeCol()
        {
            dict = new Dictionary<int, string>();
            list = new GoodsType[6];
            AddToList();
            for (int i = 0; i < 6; i++)
            {
                list[i] = new GoodsType();
                list[i].Name = dict[i];
            }
        }

        public void AddToList()
        {
            dict.Add(0, "Саморез");
            dict.Add(1, "Болты");
            dict.Add(2, "Замки");
            dict.Add(3, "Шурупы");
            dict.Add(4, "Клей");
            dict.Add(5, "Отвертки");
        }

        static public int count()
        {
            return list.Length;
        }
    }
}
