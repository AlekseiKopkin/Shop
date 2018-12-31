using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public partial class FilterClass
    {

        FilterForm filterForm = new FilterForm();
        string namberTable;
        string value;
        public void SetNamberTable (string NamberTable)
        {
            this.namberTable = NamberTable;
        }
        public int GetNumberTable()
        {
            int j = -1;
            switch (this.namberTable)
            {
                case "Код_Заказа":
                    return 0;
                case "Код_Клиента":
                    return 1;
                case "Код_Сотрудника":
                    return 2;
                case "Код_Доставки":
                    return 3;
                case "Стоимость_Доставки":
                    return 4;
                case "Название_Получателя":
                    return 5;
                case "Адрес_Получателя":
                    return 6;
                default:
                    return -1;
            }
        }
        public void SetValue(string value)
        {
            this.value = value;
        }
        public string GetValue()
        {
            return this.value;
        }
    }
}
