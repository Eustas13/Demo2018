using System;
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
    public partial class Конструктор : Form
    {
        public Конструктор()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Список_комплектующих_неРЕД sp = new Список_комплектующих_неРЕД();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Список_материалов_неРЕД sp = new Список_материалов_неРЕД();
            sp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
