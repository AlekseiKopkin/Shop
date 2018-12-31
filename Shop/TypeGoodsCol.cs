using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class TypeGoodsCol
    {
        static public TypeGoods[] Coll_of_typeGoods;
        private int counter;
        public TypeGoodsCol()
        {

            for (int i = 0; i < TypeGoodsForm.dataTypeGoods.Rows.Count; i++)
            {
                if (TypeGoodsForm.dataTypeGoods[0, i].Value != null) counter++;
                else break;
            }
            Coll_of_typeGoods = new TypeGoods[counter];
            for (int i = 0; i < counter; i++)
            {

                Coll_of_typeGoods[i] = new TypeGoods();
                Coll_of_typeGoods[i].Name = (String)TypeGoodsForm.dataTypeGoods[1, i].Value;


            }
        }


        static public TypeGoods[] addCountriesToTour()
        {
            return Coll_of_typeGoods;
        }

        static public int count()
        {
            return Coll_of_typeGoods.Length;
        }
    }
}
