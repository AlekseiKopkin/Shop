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
    public partial class AddGoods : Form
    {

        static string[] values;
        public AddGoods()
        {
            InitializeComponent();
            textBox1.Text = (GoodFactory.count() + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num_fields = 5;

            values = new string[num_fields];
            values[0] = textBox1.Text;
            values[1] = textBox2.Text;
            values[2] = comboBox1.Text;
            values[3] = textBox3.Text;
            values[4] = textBox4.Text;

            if (check(values) == 1)
            {
                GoodFactory.Add_Goods(values);
                textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                textBox2.Text = "";
                comboBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
        private int check(string[] arr)
        {

            try
            {
                int a = Convert.ToInt16(values[3]);
            }
            catch
            {
                MessageBox.Show("Enter the number in the price!");
                return 0;
            }

            for (int i = 0; i < 5; i++)
            {
                if (values[i] == "")
                {
                    MessageBox.Show("Complete all fields!");
                    return 0;
                }

            }
            return 1;
        }

        private void AddGoods_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GoodsTypeCol.count(); i++)
            {
                comboBox1.Items.Add(GoodsTypeCol.list[i].Name);
            }
        }

        private void AddGoods_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < GoodsTypeCol.count(); i++)
            {
                comboBox1.Items.Add(GoodsTypeCol.list[i].Name);
            }
        }
    }
}
