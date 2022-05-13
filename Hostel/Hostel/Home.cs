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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Студенты newForm = new Студенты();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Родители newForm = new Родители();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Комната newForm = new Комната();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Проживание newForm = new Проживание();
            newForm.Show();
        }
    }
}
