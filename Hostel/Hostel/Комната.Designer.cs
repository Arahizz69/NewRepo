namespace Hostel
{
    partial class Комната
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
            this.комнатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комнатаTableAdapter = new Hostel.HostelDataSetTableAdapters.КомнатаTableAdapter();
            this.кодКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЭтажаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПроживающихDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоМестВКомнатеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКомнатыDataGridViewTextBoxColumn,
            this.номерЭтажаDataGridViewTextBoxColumn,
            this.номерКомнатыDataGridViewTextBoxColumn,
            this.количествоПроживающихDataGridViewTextBoxColumn,
            this.количествоМестВКомнатеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.комнатаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // комнатаBindingSource
            // 
            this.комнатаBindingSource.DataMember = "Комната";
            this.комнатаBindingSource.DataSource = this.hostelDataSet;
            // 
            // комнатаTableAdapter
            // 
            this.комнатаTableAdapter.ClearBeforeFill = true;
            // 
            // кодКомнатыDataGridViewTextBoxColumn
            // 
            this.кодКомнатыDataGridViewTextBoxColumn.DataPropertyName = "КодКомнаты";
            this.кодКомнатыDataGridViewTextBoxColumn.HeaderText = "КодКомнаты";
            this.кодКомнатыDataGridViewTextBoxColumn.Name = "кодКомнатыDataGridViewTextBoxColumn";
            // 
            // номерЭтажаDataGridViewTextBoxColumn
            // 
            this.номерЭтажаDataGridViewTextBoxColumn.DataPropertyName = "НомерЭтажа";
            this.номерЭтажаDataGridViewTextBoxColumn.HeaderText = "НомерЭтажа";
            this.номерЭтажаDataGridViewTextBoxColumn.Name = "номерЭтажаDataGridViewTextBoxColumn";
            // 
            // номерКомнатыDataGridViewTextBoxColumn
            // 
            this.номерКомнатыDataGridViewTextBoxColumn.DataPropertyName = "НомерКомнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.HeaderText = "НомерКомнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.Name = "номерКомнатыDataGridViewTextBoxColumn";
            // 
            // количествоПроживающихDataGridViewTextBoxColumn
            // 
            this.количествоПроживающихDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.количествоПроживающихDataGridViewTextBoxColumn.DataPropertyName = "КоличествоПроживающих";
            this.количествоПроживающихDataGridViewTextBoxColumn.HeaderText = "КоличествоПроживающих";
            this.количествоПроживающихDataGridViewTextBoxColumn.Name = "количествоПроживающихDataGridViewTextBoxColumn";
            this.количествоПроживающихDataGridViewTextBoxColumn.Width = 165;
            // 
            // количествоМестВКомнатеDataGridViewTextBoxColumn
            // 
            this.количествоМестВКомнатеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.количествоМестВКомнатеDataGridViewTextBoxColumn.DataPropertyName = "КоличествоМестВКомнате";
            this.количествоМестВКомнатеDataGridViewTextBoxColumn.HeaderText = "КоличествоМестВКомнате";
            this.количествоМестВКомнатеDataGridViewTextBoxColumn.Name = "количествоМестВКомнатеDataGridViewTextBoxColumn";
            this.количествоМестВКомнатеDataGridViewTextBoxColumn.Width = 168;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Комната
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hostel.Properties.Resources.obshezhitie;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Комната";
            this.Text = "Комната";
            this.Load += new System.EventHandler(this.Комната_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource комнатаBindingSource;
        private HostelDataSetTableAdapters.КомнатаTableAdapter комнатаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЭтажаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПроживающихDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоМестВКомнатеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}