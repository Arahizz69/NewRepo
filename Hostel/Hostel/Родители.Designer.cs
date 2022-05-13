namespace Hostel
{
    partial class Родители
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
            this.кодРодителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.родителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDataSet = new Hostel.HostelDataSet();
            this.родителиTableAdapter = new Hostel.HostelDataSetTableAdapters.РодителиTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРодителяDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.родителиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодРодителяDataGridViewTextBoxColumn
            // 
            this.кодРодителяDataGridViewTextBoxColumn.DataPropertyName = "КодРодителя";
            this.кодРодителяDataGridViewTextBoxColumn.HeaderText = "КодРодителя";
            this.кодРодителяDataGridViewTextBoxColumn.Name = "кодРодителяDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "КодСтудента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "КодСтудента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            // 
            // родителиBindingSource
            // 
            this.родителиBindingSource.DataMember = "Родители";
            this.родителиBindingSource.DataSource = this.hostelDataSet;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // родителиTableAdapter
            // 
            this.родителиTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Родители
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hostel.Properties.Resources.obshezhitie;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Родители";
            this.Text = "Родители";
            this.Load += new System.EventHandler(this.Родители_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource родителиBindingSource;
        private HostelDataSetTableAdapters.РодителиTableAdapter родителиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРодителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}