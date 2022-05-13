namespace Hostel
{
    partial class Проживание
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
            this.hostelDataSet = new Hostel.HostelDataSet();
            this.проживаениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проживаениеTableAdapter = new Hostel.HostelDataSetTableAdapters.ПроживаениеTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаселенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНарушенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проживаениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.кодКомнатыDataGridViewTextBoxColumn,
            this.датаЗаселенияDataGridViewTextBoxColumn,
            this.количествоНарушенийDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.проживаениеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // проживаениеBindingSource
            // 
            this.проживаениеBindingSource.DataMember = "Проживаение";
            this.проживаениеBindingSource.DataSource = this.hostelDataSet;
            // 
            // проживаениеTableAdapter
            // 
            this.проживаениеTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "КодСтудента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "КодСтудента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            // 
            // кодКомнатыDataGridViewTextBoxColumn
            // 
            this.кодКомнатыDataGridViewTextBoxColumn.DataPropertyName = "КодКомнаты";
            this.кодКомнатыDataGridViewTextBoxColumn.HeaderText = "КодКомнаты";
            this.кодКомнатыDataGridViewTextBoxColumn.Name = "кодКомнатыDataGridViewTextBoxColumn";
            // 
            // датаЗаселенияDataGridViewTextBoxColumn
            // 
            this.датаЗаселенияDataGridViewTextBoxColumn.DataPropertyName = "ДатаЗаселения";
            this.датаЗаселенияDataGridViewTextBoxColumn.HeaderText = "ДатаЗаселения";
            this.датаЗаселенияDataGridViewTextBoxColumn.Name = "датаЗаселенияDataGridViewTextBoxColumn";
            // 
            // количествоНарушенийDataGridViewTextBoxColumn
            // 
            this.количествоНарушенийDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.количествоНарушенийDataGridViewTextBoxColumn.DataPropertyName = "КоличествоНарушений";
            this.количествоНарушенийDataGridViewTextBoxColumn.HeaderText = "КоличествоНарушений";
            this.количествоНарушенийDataGridViewTextBoxColumn.Name = "количествоНарушенийDataGridViewTextBoxColumn";
            this.количествоНарушенийDataGridViewTextBoxColumn.Width = 148;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(614, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Проживание
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hostel.Properties.Resources.obshezhitie;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Проживание";
            this.Text = "Проживание";
            this.Load += new System.EventHandler(this.Проживание_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проживаениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource проживаениеBindingSource;
        private HostelDataSetTableAdapters.ПроживаениеTableAdapter проживаениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаселенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНарушенийDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}