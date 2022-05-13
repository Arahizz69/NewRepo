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
    public partial class Родители : Form
    {
        public Родители()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Родители_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter.Fill(this.hostelDataSet.Родители);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegForm newForm = new RegForm();
            newForm.Show();
        }
    }
}
