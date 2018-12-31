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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_kopiaDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.database2_kopiaDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_kopiaDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.database2_kopiaDataSet.Сотрудники);

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
            this.сотрудникиTableAdapter.Update(this.database2_kopiaDataSet);
        }
    }
}
