namespace WindowsFormsApp1
{
    partial class Список_поступаемых_материалов
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
            this.материалDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупочнаяЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поступлениематериаловBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user4DataSet = new WindowsFormsApp1.user4DataSet();
            this.exit = new System.Windows.Forms.Button();
            this.поступление_материаловTableAdapter = new WindowsFormsApp1.user4DataSetTableAdapters.Поступление_материаловTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступлениематериаловBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user4DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.материалDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.закупочнаяЦенаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поступлениематериаловBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1008, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // материалDataGridViewTextBoxColumn
            // 
            this.материалDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.материалDataGridViewTextBoxColumn.DataPropertyName = "Материал";
            this.материалDataGridViewTextBoxColumn.HeaderText = "Материал";
            this.материалDataGridViewTextBoxColumn.Name = "материалDataGridViewTextBoxColumn";
            this.материалDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // закупочнаяЦенаDataGridViewTextBoxColumn
            // 
            this.закупочнаяЦенаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.закупочнаяЦенаDataGridViewTextBoxColumn.DataPropertyName = "Закупочная_Цена";
            this.закупочнаяЦенаDataGridViewTextBoxColumn.HeaderText = "Закупочная Цена";
            this.закупочнаяЦенаDataGridViewTextBoxColumn.Name = "закупочнаяЦенаDataGridViewTextBoxColumn";
            this.закупочнаяЦенаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // поступлениематериаловBindingSource
            // 
            this.поступлениематериаловBindingSource.DataMember = "Поступление_материалов";
            this.поступлениематериаловBindingSource.DataSource = this.user4DataSet;
            // 
            // user4DataSet
            // 
            this.user4DataSet.DataSetName = "user4DataSet";
            this.user4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(479, 488);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // поступление_материаловTableAdapter
            // 
            this.поступление_материаловTableAdapter.ClearBeforeFill = true;
            // 
            // Список_поступаемых_материалов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 514);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Список_поступаемых_материалов";
            this.Text = "Список поступаемых материалов";
            this.Load += new System.EventHandler(this.Список_поступаемых_материалов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступлениематериаловBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user4DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private user4DataSet user4DataSet;
        private System.Windows.Forms.BindingSource поступлениематериаловBindingSource;
        private user4DataSetTableAdapters.Поступление_материаловTableAdapter поступление_материаловTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn материалDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закупочнаяЦенаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
    }
}