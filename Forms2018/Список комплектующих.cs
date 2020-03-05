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
    public partial class Список_комплектующих : Form
    {
        Model1 db = new Model1();
        public Список_комплектующих()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Список_комплектующих_Load(object sender, EventArgs e)
        {
            комплектующиеBindingSource.DataSource = db.Комплектующие.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Комплектующие rl = (Комплектующие)комплектующиеBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить комплектующие с артикулом " + rl.Артикул.ToString() + "?",
                "Удаление поставки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Комплектующие.Remove(rl);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Успешно!");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
                комплектующиеBindingSource.DataSource = db.Комплектующие.ToList();
            }
        }
    }
}
