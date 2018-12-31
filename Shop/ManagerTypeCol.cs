using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ManagerTypeCol
    {
        private Dictionary<int, string> coll;
        static public ManagerType[] collection;
        private Dictionary<string, int> prioritets;

        public ManagerTypeCol()
        {
            coll = new Dictionary<int, string>();
            prioritets = new Dictionary<string, int>();
            collection = new ManagerType[6];
            AddDict();
            AddToCollection();
            AddPrior();
        }

        public void AddDict()
        {

            coll.Add(0, "Генеральный директор");//1
            coll.Add(1, "Директор по складу");//2
            coll.Add(2, "Заместитель генерального директора");//1
            coll.Add(3, "Старший ведущий продавец");//2
            coll.Add(4, "Ведущий продавец");//3
            coll.Add(5, "Продавец");//4

            prioritets.Add("Генеральный директор", 1);
            prioritets.Add("Директор по складу", 2);
            prioritets.Add("Заместитель генерального директора", 1);
            prioritets.Add("Старший ведущий продавец", 2);
            prioritets.Add("Ведущий продавец", 3);
            prioritets.Add("Продавец", 4);

        }

        public void AddToCollection()
        {
            for (int i = 0; i < 6; i++)
            {
                collection[i] = new ManagerType();
                collection[i].Type = coll[i];
            }
        }

        public void AddPrior()
        {
            foreach (ManagerType i in collection)
            {
                foreach (string j in prioritets.Keys)
                {
                    if (i.Type == j)
                    {
                        i.Prior = prioritets[j];
                    }
                }
            }
        }
        public int countDict()
        {
            return coll.Count;
        }

        static public int count()
        {
            return collection.Length;
        }
    }
}
