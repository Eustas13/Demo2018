﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2018
{
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Список_комплектующих sp = new Список_комплектующих();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Список_материалов sp = new Список_материалов();
            sp.Show();
        }
    }
}
