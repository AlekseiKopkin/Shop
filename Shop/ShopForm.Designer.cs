namespace Shop
{
    partial class ShopForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.Clients = new System.Windows.Forms.Button();
            this.TypeGoods = new System.Windows.Forms.Button();
            this.Managers = new System.Windows.Forms.Button();
            this.Goods = new System.Windows.Forms.Button();
            this.Odrers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_password = new System.Windows.Forms.Button();
            this.change_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(189, 403);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(149, 50);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // TypeGoods
            // 
            this.TypeGoods.Location = new System.Drawing.Point(189, 244);
            this.TypeGoods.Name = "TypeGoods";
            this.TypeGoods.Size = new System.Drawing.Size(149, 50);
            this.TypeGoods.TabIndex = 1;
            this.TypeGoods.Text = "Типы товара";
            this.TypeGoods.UseVisualStyleBackColor = true;
            this.TypeGoods.Click += new System.EventHandler(this.TypeGoods_Click);
            // 
            // Managers
            // 
            this.Managers.Location = new System.Drawing.Point(728, 244);
            this.Managers.Name = "Managers";
            this.Managers.Size = new System.Drawing.Size(146, 50);
            this.Managers.TabIndex = 3;
            this.Managers.Text = "Струдники";
            this.Managers.UseVisualStyleBackColor = true;
            this.Managers.Click += new System.EventHandler(this.Managers_Click);
            // 
            // Goods
            // 
            this.Goods.Location = new System.Drawing.Point(457, 321);
            this.Goods.Name = "Goods";
            this.Goods.Size = new System.Drawing.Size(149, 50);
            this.Goods.TabIndex = 4;
            this.Goods.Text = "Товары";
            this.Goods.UseVisualStyleBackColor = true;
            this.Goods.Click += new System.EventHandler(this.Goods_Click);
            // 
            // Odrers
            // 
            this.Odrers.Location = new System.Drawing.Point(728, 403);
            this.Odrers.Name = "Odrers";
            this.Odrers.Size = new System.Drawing.Size(146, 50);
            this.Odrers.TabIndex = 5;
            this.Odrers.Text = "Заказы";
            this.Odrers.UseVisualStyleBackColor = true;
            this.Odrers.Click += new System.EventHandler(this.Odrers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(861, 108);
            this.label2.TabIndex = 9;
            this.label2.Text = "Магазин \"Крепёж\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Change_password
            // 
            this.Change_password.Location = new System.Drawing.Point(12, 510);
            this.Change_password.Name = "Change_password";
            this.Change_password.Size = new System.Drawing.Size(187, 23);
            this.Change_password.TabIndex = 10;
            this.Change_password.Text = "Изменение пароля";
            this.Change_password.UseVisualStyleBackColor = true;
            this.Change_password.Click += new System.EventHandler(this.Change_password_Click);
            // 
            // change_user
            // 
            this.change_user.Location = new System.Drawing.Point(931, 510);
            this.change_user.Name = "change_user";
            this.change_user.Size = new System.Drawing.Size(185, 23);
            this.change_user.TabIndex = 11;
            this.change_user.Text = "Изменение юзера";
            this.change_user.UseVisualStyleBackColor = true;
            this.change_user.Click += new System.EventHandler(this.change_user_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1171, 545);
            this.Controls.Add(this.change_user);
            this.Controls.Add(this.Change_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Odrers);
            this.Controls.Add(this.Goods);
            this.Controls.Add(this.Managers);
            this.Controls.Add(this.TypeGoods);
            this.Controls.Add(this.Clients);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button TypeGoods;
        private System.Windows.Forms.Button Managers;
        private System.Windows.Forms.Button Goods;
        private System.Windows.Forms.Button Odrers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Change_password;
        private System.Windows.Forms.Button change_user;
    }
}

