namespace Shop
{
    partial class Goods
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
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицыИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ожидаетсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальныйЗапасDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставкиПрекращеныDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2_kopiaDataSet = new Shop.Database2_kopiaDataSet();
            this.товарыTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.ТоварыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодТовараDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодХарактеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.значениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарыХарактиристикиТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.характиристики_ТоваровTableAdapter = new Shop.Database2_kopiaDataSetTableAdapters.Характиристики_ТоваровTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыХарактиристикиТоваровBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.типтовараDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.единицыИзмеренияDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.наСкладеDataGridViewTextBoxColumn,
            this.ожидаетсяDataGridViewTextBoxColumn,
            this.минимальныйЗапасDataGridViewTextBoxColumn,
            this.поставкиПрекращеныDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.товарыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1102, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "Код_Товара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "Код_Товара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            // 
            // типтовараDataGridViewTextBoxColumn
            // 
            this.типтовараDataGridViewTextBoxColumn.DataPropertyName = "Тип_товара";
            this.типтовараDataGridViewTextBoxColumn.HeaderText = "Тип_товара";
            this.типтовараDataGridViewTextBoxColumn.Name = "типтовараDataGridViewTextBoxColumn";
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // единицыИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицыИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единицы_Измерения";
            this.единицыИзмеренияDataGridViewTextBoxColumn.HeaderText = "Единицы_Измерения";
            this.единицыИзмеренияDataGridViewTextBoxColumn.Name = "единицыИзмеренияDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // наСкладеDataGridViewTextBoxColumn
            // 
            this.наСкладеDataGridViewTextBoxColumn.DataPropertyName = "На_Складе";
            this.наСкладеDataGridViewTextBoxColumn.HeaderText = "На_Складе";
            this.наСкладеDataGridViewTextBoxColumn.Name = "наСкладеDataGridViewTextBoxColumn";
            // 
            // ожидаетсяDataGridViewTextBoxColumn
            // 
            this.ожидаетсяDataGridViewTextBoxColumn.DataPropertyName = "Ожидается";
            this.ожидаетсяDataGridViewTextBoxColumn.HeaderText = "Ожидается";
            this.ожидаетсяDataGridViewTextBoxColumn.Name = "ожидаетсяDataGridViewTextBoxColumn";
            // 
            // минимальныйЗапасDataGridViewTextBoxColumn
            // 
            this.минимальныйЗапасDataGridViewTextBoxColumn.DataPropertyName = "Минимальный_Запас";
            this.минимальныйЗапасDataGridViewTextBoxColumn.HeaderText = "Минимальный_Запас";
            this.минимальныйЗапасDataGridViewTextBoxColumn.Name = "минимальныйЗапасDataGridViewTextBoxColumn";
            // 
            // поставкиПрекращеныDataGridViewCheckBoxColumn
            // 
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.DataPropertyName = "Поставки_Прекращены";
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.HeaderText = "Поставки_Прекращены";
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.Name = "поставкиПрекращеныDataGridViewCheckBoxColumn";
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.database2_kopiaDataSet;
            // 
            // database2_kopiaDataSet
            // 
            this.database2_kopiaDataSet.DataSetName = "Database2_kopiaDataSet";
            this.database2_kopiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1039, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn1,
            this.кодХарактеристикиDataGridViewTextBoxColumn,
            this.значениеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.товарыХарактиристикиТоваровBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 187);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(473, 85);
            this.dataGridView2.TabIndex = 2;
            // 
            // кодТовараDataGridViewTextBoxColumn1
            // 
            this.кодТовараDataGridViewTextBoxColumn1.DataPropertyName = "Код_Товара";
            this.кодТовараDataGridViewTextBoxColumn1.HeaderText = "Код_Товара";
            this.кодТовараDataGridViewTextBoxColumn1.Name = "кодТовараDataGridViewTextBoxColumn1";
            // 
            // кодХарактеристикиDataGridViewTextBoxColumn
            // 
            this.кодХарактеристикиDataGridViewTextBoxColumn.DataPropertyName = "Код_Характеристики";
            this.кодХарактеристикиDataGridViewTextBoxColumn.HeaderText = "Код_Характеристики";
            this.кодХарактеристикиDataGridViewTextBoxColumn.Name = "кодХарактеристикиDataGridViewTextBoxColumn";
            // 
            // значениеDataGridViewTextBoxColumn
            // 
            this.значениеDataGridViewTextBoxColumn.DataPropertyName = "Значение";
            this.значениеDataGridViewTextBoxColumn.HeaderText = "Значение";
            this.значениеDataGridViewTextBoxColumn.Name = "значениеDataGridViewTextBoxColumn";
            // 
            // товарыХарактиристикиТоваровBindingSource
            // 
            this.товарыХарактиристикиТоваровBindingSource.DataMember = "ТоварыХарактиристики_Товаров";
            this.товарыХарактиристикиТоваровBindingSource.DataSource = this.товарыBindingSource;
            // 
            // характиристики_ТоваровTableAdapter
            // 
            this.характиристики_ТоваровTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(791, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(918, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 295);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Goods";
            this.Text = "Goods";
            this.Load += new System.EventHandler(this.Goods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_kopiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыХарактиристикиТоваровBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2_kopiaDataSet database2_kopiaDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private Database2_kopiaDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицыИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ожидаетсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальныйЗапасDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn поставкиПрекращеныDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource товарыХарактиристикиТоваровBindingSource;
        private Database2_kopiaDataSetTableAdapters.Характиристики_ТоваровTableAdapter характиристики_ТоваровTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодХарактеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn значениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}