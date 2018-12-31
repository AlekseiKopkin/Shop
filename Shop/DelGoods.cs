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
    public partial class DelGoods : Form
    {
        public DelGoods()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(textBox1.Text);
                GoodFactory.DeleteGoods(code);
            }
            catch
            {
                MessageBox.Show("Enter the number!");
            }

        }
    }
}
