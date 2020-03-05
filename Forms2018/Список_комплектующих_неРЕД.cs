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
    public partial class Список_комплектующих_неРЕД : Form
    {
        Model1 db = new Model1();
        public Список_комплектующих_неРЕД()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Список_комплектующих_неРЕД_Load(object sender, EventArgs e)
        {
            комплектующиеBindingSource.DataSource = db.Комплектующие.ToList();
        }
    }
}
