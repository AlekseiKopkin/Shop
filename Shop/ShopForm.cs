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
    public partial class ShopForm : Form
    {
        public Clients form_clients = null;
        public TypeGoodsForm form_typegoods = null;
        public managers form_managers = null;
        public GoodsForm form_goods = null;
        public OrdersForm form_orders = null;
        public ShopForm()
        {
            InitializeComponent();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            form_clients = new Clients();
            form_clients.Show();
            Shop.Clients.openData();
        }

        private void Managers_Click(object sender, EventArgs e)
        {
            form_managers = new managers();
            form_managers.Show();
            Shop.managers.openData();
        }

        private void TypeGoods_Click(object sender, EventArgs e)
        {
            form_typegoods = new TypeGoodsForm();

            form_typegoods.Show();
            TypeGoodsForm.openData();
        }

        private void Goods_Click(object sender, EventArgs e)
        {
            form_goods = new GoodsForm();
            form_goods.Show();
            if (form_clients == null)
            {
                form_clients = new Clients();
                Shop.Clients.openData();
            }
            GoodsForm.openData();
        }

        private void Odrers_Click(object sender, EventArgs e)
        {
            form_orders = new OrdersForm();
            form_orders.Show();
            if (form_managers == null)
            {
                form_managers = new managers();
                Shop.managers.openData();
            }
            if (form_clients == null)
            {
                form_clients = new Clients();
                Shop.Clients.openData();
            }
            if (form_goods == null)
            {
                form_goods = new GoodsForm();
                if (form_typegoods == null)
                {
                    form_typegoods = new TypeGoodsForm();
                    TypeGoodsForm.openData();
                }

                GoodsForm.openData();
            }

            OrdersForm.openData();
        }

        private void Change_password_Click(object sender, EventArgs e)
        {
            change_password form = new change_password();
            form.Show();
        }

        private void change_user_Click(object sender, EventArgs e)
        {
            Password form = new Password();
            form.Show();
            this.Close();
        }
    }
}
