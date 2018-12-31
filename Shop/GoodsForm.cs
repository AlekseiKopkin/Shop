using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccessToSystem.UserNow.Prioritet <= 3)
            {
                GoodsTypeCol obj1 =new GoodsTypeCol();
                   AddGoods obj = new AddGoods();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm(this);
            form.Show();
        }
        static public void openData()
        {
            string filename = "E:\\Shop\\Данные\\Goods.xlsx";

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                false, 0, true, 1, 0);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            int i = 1;
            int flag = 0;
            while (true)
            {
                dataGoods.Rows.Add(1);
                for (int j = 1; j <= dataGoods.ColumnCount; j++)
                {
                    dataGoods.Rows[i - 1].Cells[j - 1].Value = ExcelApp.Cells[i, j].Value;
                    if (dataGoods.Rows[i - 1].Cells[j - 1].Value == null)
                    {
                        flag = 1;
                        dataGoods.Rows.RemoveAt(i - 1);
                        break;

                    }

                }
                if (flag == 1)
                {

                    break;
                }
                ++i;
            }
            GoodFactory obj = new GoodFactory();
            ExcelApp.Quit();
        }
        static public void ShowFiltrGoods(List<Goods> goods)
        {
            for (int i = dataGoods.Rows.Count - 2; i > 0; i--)
            {
                dataGoods.Rows.RemoveAt(i);
            }
                dataGoods.Rows.RemoveAt(0);      

            foreach (Goods i in goods)
            {
                dataGoods.Rows.Add(i._code.Value, i._name.Name, i._type.Name, i._cost.Value, i._valuta.Name);
            }

        }
        static public void ShowNewTour(Goods newGoods)
        {

            dataGoods.Rows.Add(newGoods._code.Value, newGoods._name.Name, newGoods._type.Name,
              newGoods._cost.Value, newGoods._valuta.Name);

            string filename = "E:\\Shop\\Данные\\Goods.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[dataGoods.Rows.Count - 1, 1] = newGoods._code.Value;
            ExcelWorkSheet.Cells[dataGoods.Rows.Count - 1, 2] = newGoods._name.Name;
            ExcelWorkSheet.Cells[dataGoods.Rows.Count - 1, 3] = newGoods._type.Name;       
            ExcelWorkSheet.Cells[dataGoods.Rows.Count - 1, 4] = newGoods._cost.Value;
            ExcelWorkSheet.Cells[dataGoods.Rows.Count - 1, 5] = newGoods._valuta.Name;


            ExcelWorkBook.Save();
            ExcelApp.Quit();
        }
        static public void DeleteNewTour(int code)
        {
            int j = 0;
            for (int i = 0; i < dataGoods.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGoods[0, i].Value) == code)
                {
                    j = i;
                    dataGoods.Rows.RemoveAt(i);
                    break;
                }
            }

            string filename = "E:\\Shop\\Данные\\Goods.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);


            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.Rows[j + 1];
            rg.Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftUp);
            ExcelWorkBook.Save();
            ExcelApp.Quit();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (AccessToSystem.UserNow.Prioritet <= 3)
            {
                DelGoods obj = new DelGoods();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }
    }
}
