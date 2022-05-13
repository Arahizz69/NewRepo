using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void комнатаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.комнатаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hostelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Комната". При необходимости она может быть перемещена или удалена.
            this.комнатаTableAdapter.Fill(this.hostelDataSet.Комната);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegestrationForm newForm = new RegestrationForm();
            newForm.Show();
        }
    }
}
