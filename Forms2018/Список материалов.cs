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
    public partial class Список_материалов : Form
    {
        Model1 db = new Model1();
        public Список_материалов()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Список_материалов_Load(object sender, EventArgs e)
        {
            материалыBindingSource.DataSource = db.Материалы.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Материалы rl = (Материалы)материалыBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить материал с артикулом " + rl.Артикул.ToString() + "?",
                "Удаление поставки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Материалы.Remove(rl);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Успешно!");
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
                материалыBindingSource.DataSource = db.Материалы.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Изменить_материалы izm = new Изменить_материалы();
            izm.Show();
        }
    }
}
