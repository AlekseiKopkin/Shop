namespace Shop
{
    partial class Client
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обращатьсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2_kopiaDataSet = new Shop.Database2_kopiaDataSet();
            this.заказаноBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.ДоставкаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.заказаноTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.ЗаказаноTableAdapter();
            this.клиентыTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.КлиентыTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.клиентыЗаказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.ЗаказыTableAdapter();
            this.кодЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказаноBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыЗаказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.обращатьсяDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.областьDataGridViewTextBoxColumn,
            this.индексDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.факсDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // обращатьсяDataGridViewTextBoxColumn
            // 
            this.обращатьсяDataGridViewTextBoxColumn.DataPropertyName = "Обращаться";
            this.обращатьсяDataGridViewTextBoxColumn.HeaderText = "Обращаться";
            this.обращатьсяDataGridViewTextBoxColumn.Name = "обращатьсяDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // областьDataGridViewTextBoxColumn
            // 
            this.областьDataGridViewTextBoxColumn.DataPropertyName = "Область";
            this.областьDataGridViewTextBoxColumn.HeaderText = "Область";
            this.областьDataGridViewTextBoxColumn.Name = "областьDataGridViewTextBoxColumn";
            // 
            // индексDataGridViewTextBoxColumn
            // 
            this.индексDataGridViewTextBoxColumn.DataPropertyName = "Индекс";
            this.индексDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.индексDataGridViewTextBoxColumn.Name = "индексDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // факсDataGridViewTextBoxColumn
            // 
            this.факсDataGridViewTextBoxColumn.DataPropertyName = "Факс";
            this.факсDataGridViewTextBoxColumn.HeaderText = "Факс";
            this.факсDataGridViewTextBoxColumn.Name = "факсDataGridViewTextBoxColumn";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.database2_kopiaDataSet;
            this.bindingSource1.Position = 0;
            // 
            // database2_kopiaDataSet
            // 
            this.database2_kopiaDataSet.DataSetName = "Database2_kopiaDataSet";
            this.database2_kopiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказаноBindingSource
            // 
            this.заказаноBindingSource.DataMember = "Заказано";
            this.заказаноBindingSource.DataSource = this.bindingSource1;
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.bindingSource1;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1054, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // заказаноTableAdapter
            // 
            this.заказаноTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(960, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаказаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn1,
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
            this.dataGridView2.DataSource = this.клиентыЗаказыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 139);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(936, 91);
            this.dataGridView2.TabIndex = 9;
            // 
            // клиентыЗаказыBindingSource
            // 
            this.клиентыЗаказыBindingSource.DataMember = "КлиентыЗаказы";
            this.клиентыЗаказыBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // кодЗаказаDataGridViewTextBoxColumn
            // 
            this.кодЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_Заказа";
            this.кодЗаказаDataGridViewTextBoxColumn.HeaderText = "Код_Заказа";
            this.кодЗаказаDataGridViewTextBoxColumn.Name = "кодЗаказаDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn1
            // 
            this.кодКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.HeaderText = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.Name = "кодКлиентаDataGridViewTextBoxColumn1";
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
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 443);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказаноBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыЗаказыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Database2_kopiaDataSet database2_kopiaDataSet;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private Database2_kopiaDataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource заказаноBindingSource;
        private Database2_kopiaDataSetTableAdapters.ЗаказаноTableAdapter заказаноTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Database2_kopiaDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обращатьсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факсDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource клиентыЗаказыBindingSource;
        private Database2_kopiaDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn1;
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
    }
}

