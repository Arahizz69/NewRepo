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
    public partial class Проживание : Form
    {
        public Проживание()
        {
            InitializeComponent();
        }

        private void Проживание_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Проживаение". При необходимости она может быть перемещена или удалена.
            this.проживаениеTableAdapter.Fill(this.hostelDataSet.Проживаение);

        }
    }
}
