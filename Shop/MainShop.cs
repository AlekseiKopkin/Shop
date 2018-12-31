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
    public partial class MainShop : Form
    {

        public MainShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form clientForm = new Client(); // Вот здесь новый экземпляр создаёшь 
            clientForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form staffForm = new Staff(); // Вот здесь новый экземпляр создаёшь 
            staffForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ordersForm = new Orders(); // Вот здесь новый экземпляр создаёшь 
            ordersForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form goodsForm = new Goods(); // Вот здесь новый экземпляр создаёшь 
            goodsForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
