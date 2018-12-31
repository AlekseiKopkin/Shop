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
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
        }

        private void AddOrders_Load(object sender, EventArgs e)
        {
            textBox1.Text = (OrderFactory.count() + 1).ToString();
        
            for (int i = 0; i < GoodFactory.count(); i++)
            {
                comboBox3.Items.Add(GoodFactory.array_Goods[i]._name.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check() == 0)
            {
                MessageBox.Show("Enter all fields!");
            }
            else
            {
                string[] arr = new string[5];
                arr[0] = textBox1.Text;
                arr[1] = textBox3.Text;
                arr[2] = textBox4.Text;
                arr[3] = textBox2.Text;
                arr[4] = comboBox3.Text;
                OrderFactory.AddOrder(arr);

                textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox3.Text = "";
            }
        }
        private int check()
        {
            if ((textBox1.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox2.Text == "") || (comboBox3.Text == "")) return 0;
            else return 1;
        }
    }
}
