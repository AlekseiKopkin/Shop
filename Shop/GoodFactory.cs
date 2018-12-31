using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class GoodFactory
    {

        static public Goods[] array_Goods;
        static private Goods new_goods;
        private int counter;

        public GoodFactory()
        {
            for (int i = 0; i < GoodsForm.dataGoods.Rows.Count; i++)
            {
                if (GoodsForm.dataGoods[0, i].Value != null) counter++;
                else break;
            }
            array_Goods = new Goods[counter];
            for (int i = 0; i < counter; i++)
            {
                array_Goods[i] = new Goods();
                array_Goods[i].number = i;
                array_Goods[i].SetFields();
            }


        }

        static public Goods[] getGoods()
        {
            return array_Goods;
        }

        static public int count()
        {
            return array_Goods.Length;
        }

        static public void Add_Goods(string[] tour)
        {

            new_goods = new Goods();
            new_goods._code.Value = Convert.ToInt32(tour[0]);
            new_goods._name.Name = tour[1];
            new_goods.Type(tour[2]);
            new_goods._cost.Value = Convert.ToDouble(tour[3]);
            new_goods._valuta.Name = tour[4];
            Goods[] new_arr = new Goods[count() + 1];
            for (int i = 0; i < new_arr.Length; i++)
            {
                if (i == new_arr.Length - 1)
                {
                    new_arr[i] = new_goods;
                    break;
                }
                new_arr[i] = array_Goods[i];
            }
            array_Goods = new_arr;
            new_arr = null;
            GoodsForm.ShowNewTour(new_goods);
        }

        static public void DeleteGoods(int code)
        {

            for (int i = 0; i < count(); i++)
            {
                if (array_Goods[i]._code.Value == code)
                {
                    array_Goods[i] = null;
                }

            }

            Goods[] arr = new Goods[count() - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (array_Goods[i] == null) continue;
                arr[i] = array_Goods[i];
            }

            array_Goods = arr;
            arr = null;
            GoodsForm.DeleteNewTour(code);
        }
    }
}
