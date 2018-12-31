using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Filter
    {
        protected string value;
        protected string type;


        virtual public void setType(string newType) { type = newType; }
        virtual public void setValue(string newValue) { value = newValue; }
        virtual public bool check(Goods goods) { return true; }


    }

    class goodsFilter : Filter
    {
        override public bool check(Goods goods)
        {
            if (goods._type.Name == value)
            {
                return true;
            }
            else return false;
        }
    }




    class FilterFormFilterForm : Filter
    {
        override public bool check(Goods goods)
        {
            if (goods._cost.Value > Convert.ToDouble(value))
            {
                return true;
            }
            else return false;
        }
    }
    class priceToFilter : Filter
    {
        override public bool check(Goods goods)
        {
            if (goods._cost.Value < Convert.ToDouble(value))
            {
                return true;
            }
            else return false;
        }
    }
    class valutaFilter : Filter
    {
        override public bool check(Goods goods)
        {
            if (goods._valuta.Name == value)
            {
                return true;
            }
            else return false;
        }
    }
    class nameFilter : Filter
    {
        override public bool check(Goods goods)
        {
            if (goods._name.Name == value)
            {
                return true;
            }
            else return false;
        }
    }
}
