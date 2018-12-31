using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class FilterCol
    {
        private FilterForm form;
        static public List<Filter> filtres;
        public FilterCol(FilterForm obj)
        {
            filtres = new List<Filter>();
            form = obj;
        }

        public void checkingBoxes()
        {
            if (form.checkBox1.Checked == true)
            {
                goodsFilter type = new goodsFilter();
                string a = form.textBox5.Text;
                type.setValue(form.textBox5.Text);
                type.setType("string");
                filtres.Add(type);
            }
            if (form.checkBox2.Checked == true)
            {
                nameFilter name = new nameFilter();
                name.setValue(form.textBox3.Text);
                name.setType("string");
                filtres.Add(name);
            }   
            if (form.checkBox3.Checked == true)
            {
                FilterFormFilterForm price_from = new FilterFormFilterForm();
                priceToFilter price_to = new priceToFilter();
                price_from.setValue(form.textBox1.Text);
                price_to.setValue(form.textBox2.Text);
                price_from.setType("double");
                price_to.setType("double");
                filtres.Add(price_from);
                filtres.Add(price_to);
            }
            if (form.checkBox4.Checked == true)
            {
                valutaFilter valuta = new valutaFilter();
                valuta.setValue(form.textBox4.Text);
                valuta.setType("string");
                filtres.Add(valuta);
            }
        }
    }
}
