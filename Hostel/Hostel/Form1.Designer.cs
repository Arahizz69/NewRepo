namespace Hostel
{
    partial class Form1
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
            this.hostelDataSet = new Hostel.HostelDataSet();
            this.комнатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комнатаTableAdapter = new Hostel.HostelDataSetTableAdapters.КомнатаTableAdapter();
            this.tableAdapterManager = new Hostel.HostelDataSetTableAdapters.TableAdapterManager();
            this.комнатаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Hostel.HostelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КомнатаTableAdapter = this.комнатаTableAdapter;
            this.tableAdapterManager.ПроживаениеTableAdapter = null;
            this.tableAdapterManager.РодителиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            // 
            // комнатаBindingSource1
            // 
            this.комнатаBindingSource1.DataMember = "Комната";
            this.комнатаBindingSource1.DataSource = this.hostelDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(143, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общежитие";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseMnemonic = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(169, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(264, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Зарегистрировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Hostel.Properties.Resources.obshezhitie;
            this.ClientSize = new System.Drawing.Size(479, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource комнатаBindingSource;
        private HostelDataSetTableAdapters.КомнатаTableAdapter комнатаTableAdapter;
        private HostelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource комнатаBindingSource1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}

