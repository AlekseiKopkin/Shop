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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            AccessToSystem obj = new AccessToSystem();

            if (User.Check(name, password))
            {
                this.Hide();
                ShopForm mainform = new ShopForm();
                mainform.Show();


            }
            else
            {
                MessageBox.Show("You entered incorrect password or name of user. Try again. ", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
