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
    public partial class Изменить_материалы : Form
    {
        public Model1 db {get; set;}
        public Материалы rg { get; set; }
        public Изменить_материалы()
        {
            InitializeComponent();
        }

        private void Изменить_материалы_Load(object sender, EventArgs e)
        {
            textBox1.Text = rg.Артикул;
            textBox2.Text = rg.Наименование;
            textBox3.Text = Convert.ToString(rg.Количество);
            textBox4.Text = rg.Единица_изметререния;
            textBox5.Text = Convert.ToString(rg.Закупочная_цена);
            textBox6.Text = rg.Основной_поставщик;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rg.Артикул = textBox1.Text;
            rg.Наименование = textBox2.Text;
            rg.Количество = Convert.ToInt32(textBox3.Text);
            rg.Единица_изметререния = textBox4.Text;
            rg.Закупочная_цена = textBox5.Text;
            rg.Основной_поставщик = textBox6.Text;
            try
            {
                db.SaveChanges();
                MessageBox.Show("Данные успешно изменены");
            }
            catch(Exception x)
            {
                MessageBox.Show("Ошибка!" + x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
