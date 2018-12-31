namespace Shop
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРазмещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНазначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИсполненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаполучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2_kopiaDataSet = new Shop.Database2_kopiaDataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.ЗаказыTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодЗаказаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыЗаказаноBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказаноTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.ЗаказаноTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыЗаказаноBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаказаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.датаРазмещенияDataGridViewTextBoxColumn,
            this.датаНазначенияDataGridViewTextBoxColumn,
            this.датаИсполненияDataGridViewTextBoxColumn,
            this.кодДоставкиDataGridViewTextBoxColumn,
            this.стоимостьДоставкиDataGridViewTextBoxColumn,
            this.названиеПолучателяDataGridViewTextBoxColumn,
            this.адресПолучателяDataGridViewTextBoxColumn,
            this.городПолучателяDataGridViewTextBoxColumn,
            this.областьПолучателяDataGridViewTextBoxColumn,
            this.индексПолучателяDataGridViewTextBoxColumn,
            this.странаполучателяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1066, 144);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодЗаказаDataGridViewTextBoxColumn
            // 
            this.кодЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_Заказа";
            this.кодЗаказаDataGridViewTextBoxColumn.HeaderText = "Код_Заказа";
            this.кодЗаказаDataGridViewTextBoxColumn.Name = "кодЗаказаDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код_Сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код_Сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            // 
            // датаРазмещенияDataGridViewTextBoxColumn
            // 
            this.датаРазмещенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Размещения";
            this.датаРазмещенияDataGridViewTextBoxColumn.HeaderText = "Дата_Размещения";
            this.датаРазмещенияDataGridViewTextBoxColumn.Name = "датаРазмещенияDataGridViewTextBoxColumn";
            // 
            // датаНазначенияDataGridViewTextBoxColumn
            // 
            this.датаНазначенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Назначения";
            this.датаНазначенияDataGridViewTextBoxColumn.HeaderText = "Дата_Назначения";
            this.датаНазначенияDataGridViewTextBoxColumn.Name = "датаНазначенияDataGridViewTextBoxColumn";
            // 
            // датаИсполненияDataGridViewTextBoxColumn
            // 
            this.датаИсполненияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Исполнения";
            this.датаИсполненияDataGridViewTextBoxColumn.HeaderText = "Дата_Исполнения";
            this.датаИсполненияDataGridViewTextBoxColumn.Name = "датаИсполненияDataGridViewTextBoxColumn";
            // 
            // кодДоставкиDataGridViewTextBoxColumn
            // 
            this.кодДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Код_Доставки";
            this.кодДоставкиDataGridViewTextBoxColumn.HeaderText = "Код_Доставки";
            this.кодДоставкиDataGridViewTextBoxColumn.Name = "кодДоставкиDataGridViewTextBoxColumn";
            // 
            // стоимостьДоставкиDataGridViewTextBoxColumn
            // 
            this.стоимостьДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_Доставки";
            this.стоимостьДоставкиDataGridViewTextBoxColumn.HeaderText = "Стоимость_Доставки";
            this.стоимостьДоставкиDataGridViewTextBoxColumn.Name = "стоимостьДоставкиDataGridViewTextBoxColumn";
            // 
            // названиеПолучателяDataGridViewTextBoxColumn
            // 
            this.названиеПолучателяDataGridViewTextBoxColumn.DataPropertyName = "Название_Получателя";
            this.названиеПолучателяDataGridViewTextBoxColumn.HeaderText = "Название_Получателя";
            this.названиеПолучателяDataGridViewTextBoxColumn.Name = "названиеПолучателяDataGridViewTextBoxColumn";
            // 
            // адресПолучателяDataGridViewTextBoxColumn
            // 
            this.адресПолучателяDataGridViewTextBoxColumn.DataPropertyName = "Адрес_Получателя";
            this.адресПолучателяDataGridViewTextBoxColumn.HeaderText = "Адрес_Получателя";
            this.адресПолучателяDataGridViewTextBoxColumn.Name = "адресПолучателяDataGridViewTextBoxColumn";
            // 
            // городПолучателяDataGridViewTextBoxColumn
            // 
            this.городПолучателяDataGridViewTextBoxColumn.DataPropertyName = "Город_Получателя";
            this.городПолучателяDataGridViewTextBoxColumn.HeaderText = "Город_Получателя";
            this.городПолучателяDataGridViewTextBoxColumn.Name = "городПолучателяDataGridViewTextBoxColumn";
            // 
            // областьПолучателяDataGridViewTextBoxColumn
            // 
            this.областьПолучателяDataGridViewTextBoxColumn.DataPropertyName = "Область_Получателя";
            this.областьПолучателяDataGridViewTextBoxColumn.HeaderText = "Область_Получателя";
            this.областьПолучателяDataGridViewTextBoxColumn.Name = "областьПолучателяDataGridViewTextBoxColumn";
            // 
            // индексПолучателяDataGridViewTextBoxColumn
            // 
            this.индексПолучателяDataGridViewTextBoxColumn.DataPropertyName = "Индекс_Получателя";
            this.индексПолучателяDataGridViewTextBoxColumn.HeaderText = "Индекс_Получателя";
            this.индексПолучателяDataGridViewTextBoxColumn.Name = "индексПолучателяDataGridViewTextBoxColumn";
            // 
            // странаполучателяDataGridViewTextBoxColumn
            // 
            this.странаполучателяDataGridViewTextBoxColumn.DataPropertyName = "Страна_получателя";
            this.странаполучателяDataGridViewTextBoxColumn.HeaderText = "Страна_получателя";
            this.странаполучателяDataGridViewTextBoxColumn.Name = "странаполучателяDataGridViewTextBoxColumn";
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.database2_kopiaDataSet;
            // 
            // database2_kopiaDataSet
            // 
            this.database2_kopiaDataSet.DataSetName = "Database2_kopiaDataSet";
            this.database2_kopiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.database2_kopiaDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаказаDataGridViewTextBoxColumn1,
            this.кодТовараDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.заказыЗаказаноBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 184);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(569, 91);
            this.dataGridView2.TabIndex = 2;
            // 
            // кодЗаказаDataGridViewTextBoxColumn1
            // 
            this.кодЗаказаDataGridViewTextBoxColumn1.DataPropertyName = "Код_Заказа";
            this.кодЗаказаDataGridViewTextBoxColumn1.HeaderText = "Код_Заказа";
            this.кодЗаказаDataGridViewTextBoxColumn1.Name = "кодЗаказаDataGridViewTextBoxColumn1";
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "Код_Товара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "Код_Товара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            // 
            // заказыЗаказаноBindingSource
            // 
            this.заказыЗаказаноBindingSource.DataMember = "ЗаказыЗаказано";
            this.заказыЗаказаноBindingSource.DataSource = this.заказыBindingSource;
            // 
            // заказаноTableAdapter
            // 
            this.заказаноTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(844, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(925, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 300);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыЗаказаноBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2_kopiaDataSet database2_kopiaDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Database2_kopiaDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРазмещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНазначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИсполненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаполучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource заказыЗаказаноBindingSource;
        private Database2_kopiaDataSetTableAdapters.ЗаказаноTableAdapter заказаноTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаказаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}