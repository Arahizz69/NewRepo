namespace Hostel
{
    partial class Студенты
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
            this.hostelDataSet = new Hostel.HostelDataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new Hostel.HostelDataSetTableAdapters.СтудентыTableAdapter();
            this.tableAdapterManager = new Hostel.HostelDataSetTableAdapters.TableAdapterManager();
            this.студентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.hostelDataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Hostel.HostelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КомнатаTableAdapter = null;
            this.tableAdapterManager.ПроживаениеTableAdapter = null;
            this.tableAdapterManager.РодителиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            // 
            // студентыDataGridView
            // 
            this.студентыDataGridView.AutoGenerateColumns = false;
            this.студентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.студентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.студентыDataGridView.DataSource = this.студентыBindingSource;
            this.студентыDataGridView.Location = new System.Drawing.Point(0, 12);
            this.студентыDataGridView.Name = "студентыDataGridView";
            this.студентыDataGridView.Size = new System.Drawing.Size(754, 430);
            this.студентыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодСтудента";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодСтудента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "НомерТелефона";
            this.dataGridViewTextBoxColumn5.HeaderText = "НомерТелефона";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "КодКомнаты";
            this.dataGridViewTextBoxColumn6.HeaderText = "КодКомнаты";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "КодРодителя";
            this.dataGridViewTextBoxColumn7.HeaderText = "КодРодителя";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 99;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(760, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Студенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hostel.Properties.Resources.obshezhitie;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.студентыDataGridView);
            this.Name = "Студенты";
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.Студенты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private HostelDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private HostelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView студентыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}