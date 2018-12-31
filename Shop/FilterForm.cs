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
    public partial class FilterForm : Form
    {
        public GoodsForm goods;
        public FilterForm(GoodsForm b)
        {
            goods = b;
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(check() == false) MessageBox.Show("Enter correct data!");
            else
            {

                FilterCol obj = new FilterCol(this);
                obj.checkingBoxes();
                FilterContr contr = new FilterContr(obj);
                contr.filtering();

            }
            stdObj();
        }
        public void stdObj()
        {
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
     
            if (checkBox2.Checked == true) textBox3.Enabled = true;
            else textBox3.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label5.Enabled = true;
                label6.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                label5.Enabled = false;
                label6.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) textBox4.Enabled = true;
            else textBox4.Enabled = false;
        }
        public bool check()
        {
            try
            {
                if (checkBox3.Checked == true)
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "")) return false;
                    int a = Convert.ToInt32(textBox1.Text);
                    a = Convert.ToInt32(textBox2.Text);
                }
            }
            catch
            {

                return false;
            }

            if ((checkBox1.Checked == true) && (textBox5.Text == "")) return false;
            if ((checkBox2.Checked == true) && (textBox3.Text == "")) return false;
            if ((checkBox4.Checked == true) && (textBox4.Text == "")) return false;

            return true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) textBox5.Enabled = true;
            else textBox5.Enabled = false;
        }
    }
}
