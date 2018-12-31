using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shop
{
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePass();
        }
        public void ChangePass()
        {
            string neww = null;
            string text1 = null;
            int j = 0;
            AccessToSystem.UserNow.Password = textBox1.Text;
            string text = File.ReadAllText("E:\\Shop\\Shop\\bin\\Debug\\Password.txt");
            string[] users = Regex.Split(text, "@");

            for (int i = 0; i < users.Length; i++)
            {
                string[] arr = Regex.Split(users[i], ";");
                if (AccessToSystem.UserNow.Name == arr[0])
                {
                    j = i;
                    arr[1] = textBox1.Text;
                    neww = arr[0] + ";" + arr[1] + ";" + arr[2];
                }
            }
            for (int i = 0; i < users.Length; i++)
            {
                if (i == j) text1 = text1 + neww + "@";
                else
                    text1 = text1 + users[i] + "@";
            }

            File.WriteAllText("E:\\Shop\\Shop\\bin\\Debug\\Password.txt", text1);
        }

    }
}
