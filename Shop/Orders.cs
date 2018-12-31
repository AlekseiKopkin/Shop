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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_kopiaDataSet.Заказано". При необходимости она может быть перемещена или удалена.
            this.заказаноTableAdapter.Fill(this.database2_kopiaDataSet.Заказано);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_kopiaDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.database2_kopiaDataSet.Заказы);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainShop = new MainShop();
            mainShop.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказаноTableAdapter.Update(this.database2_kopiaDataSet);
            this.заказыTableAdapter.Update(this.database2_kopiaDataSet);
        }
    }
}
