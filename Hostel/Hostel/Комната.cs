﻿using System;
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
    public partial class Комната : Form
    {
        public Комната()
        {
            InitializeComponent();
        }

        private void Комната_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Комната". При необходимости она может быть перемещена или удалена.
            this.комнатаTableAdapter.Fill(this.hostelDataSet.Комната);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegForm newForm = new RegForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
