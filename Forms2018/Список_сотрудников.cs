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
    public partial class Список_сотрудников : Form
    {
        Model2 db = new Model2();
        public Список_сотрудников()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Список_сотрудников_Load(object sender, EventArgs e)
        {
            сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
        }
    }
}
