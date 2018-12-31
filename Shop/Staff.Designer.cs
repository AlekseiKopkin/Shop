namespace Shop
{
    partial class Staff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обращениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНаймаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныйТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2_kopiaDataSet = new Shop.Database2_kopiaDataSet();
            this.сотрудникиTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.СотрудникиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.сотрудникиЗаказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.ЗаказыTableAdapter();
            this.кодЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиЗаказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.обращениеDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.датаНаймаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.областьDataGridViewTextBoxColumn,
            this.индексDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.контактныйТелефонDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1010, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код_Сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код_Сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // обращениеDataGridViewTextBoxColumn
            // 
            this.обращениеDataGridViewTextBoxColumn.DataPropertyName = "Обращение";
            this.обращениеDataGridViewTextBoxColumn.HeaderText = "Обращение";
            this.обращениеDataGridViewTextBoxColumn.Name = "обращениеDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата_Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // датаНаймаDataGridViewTextBoxColumn
            // 
            this.датаНаймаDataGridViewTextBoxColumn.DataPropertyName = "Дата_Найма";
            this.датаНаймаDataGridViewTextBoxColumn.HeaderText = "Дата_Найма";
            this.датаНаймаDataGridViewTextBoxColumn.Name = "датаНаймаDataGridViewTextBoxColumn";
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
            // контактныйТелефонDataGridViewTextBoxColumn
            // 
            this.контактныйТелефонDataGridViewTextBoxColumn.DataPropertyName = "Контактный_Телефон";
            this.контактныйТелефонDataGridViewTextBoxColumn.HeaderText = "Контактный_Телефон";
            this.контактныйТелефонDataGridViewTextBoxColumn.Name = "контактныйТелефонDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.database2_kopiaDataSet;
            // 
            // database2_kopiaDataSet
            // 
            this.database2_kopiaDataSet.DataSetName = "Database2_kopiaDataSet";
            this.database2_kopiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(950, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(852, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаказаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn1,
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
            this.dataGridView2.DataSource = this.сотрудникиЗаказыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(712, 113);
            this.dataGridView2.TabIndex = 5;
            // 
            // сотрудникиЗаказыBindingSource
            // 
            this.сотрудникиЗаказыBindingSource.DataMember = "СотрудникиЗаказы";
            this.сотрудникиЗаказыBindingSource.DataSource = this.сотрудникиBindingSource;
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
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код_Клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // кодСотрудникаDataGridViewTextBoxColumn1
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn1.DataPropertyName = "Код_Сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn1.HeaderText = "Код_Сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn1.Name = "кодСотрудникаDataGridViewTextBoxColumn1";
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
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 293);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиЗаказыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2_kopiaDataSet database2_kopiaDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Database2_kopiaDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обращениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНаймаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактныйТелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource сотрудникиЗаказыBindingSource;
        private Database2_kopiaDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn1;
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