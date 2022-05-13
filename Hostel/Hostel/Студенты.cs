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
    public partial class Студенты : Form
    {
        public Студенты()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hostelDataSet);

        }

        private void Студенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.hostelDataSet.Студенты);

        }
    }
}
