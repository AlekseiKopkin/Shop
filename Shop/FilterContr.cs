using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class FilterContr
    {
        private Goods[] allGoods;
        private GoodsFilter filtrationGoods;

        public FilterContr(FilterCol obj)
        {
            filtrationGoods = new GoodsFilter();

            allGoods = GoodFactory.getGoods();
        }

        public void filtering()
        {
            foreach (Goods i in allGoods)
            {
                bool res = true;
                foreach (Filter j in FilterCol.filtres)
                    if (!(res = j.check(i))) break;
                if (res) filtrationGoods.addGoods(i);

            }

            GoodsForm.ShowFiltrGoods(GoodsFilter.filtrGoods);
        }


    }
}
