using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    abstract public class field
    {
        protected string name;
        virtual public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }

    public class GoodsType : field { }
    public class TypeGoods : field { }
    public class Name : field { }
    public class Cost : field
    {
        new private double name;
        public double Value
        {
            set { name = value; }
            get { return name; }
        }
    }
    public class Valuta : field { }

    public class Code : field
    {
        new private int name;
        public int Value
        {
            set { name = value; }
            get { return name; }
        }
    }
}
