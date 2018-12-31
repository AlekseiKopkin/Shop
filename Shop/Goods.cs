using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Goods
    {
        public int number;
        public Code _code;
        public Name _name;
        public GoodsType _type;
        public Cost _cost;
        public Valuta _valuta;

        public Goods()
        {
            _code = new Code();
            _name = new Name();
            _cost = new Cost();
            _valuta = new Valuta();
        }

        public void Type(string nameType)
        {
            GoodsTypeCol obj = new GoodsTypeCol();
            GoodsType[] arr = GoodsTypeCol.list;
            _type = new GoodsType();
            foreach (GoodsType i in arr)
            {
                if (nameType == i.Name)
                {
                    _type = i;
                }
            }
        }

        public void SetFields()
        {


            _code.Value = Convert.ToInt32(GoodsForm.dataGoods[0, number].Value);
            _name.Name = (String)GoodsForm.dataGoods[1, number].Value;
            _cost.Value = Convert.ToDouble(GoodsForm.dataGoods[3, number].Value);
            _valuta.Name = (String)GoodsForm.dataGoods[4, number].Value;
            Type((String)GoodsForm.dataGoods[2, number].Value);

        }
    }
}

