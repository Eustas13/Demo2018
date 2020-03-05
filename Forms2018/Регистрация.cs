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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Нужно задать все данные");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (textBox4.Text != "Заказчик")
            {
                MessageBox.Show("Задана неверная роль");
                return;
            }
            Пользователи usr = db.Пользователи.Find(textBox1.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть");
                return;
            }
            usr = new Пользователи();
            usr.Логин = textBox1.Text;
            usr.Пароль = textBox2.Text;
            usr.Роль = textBox4.Text;
            usr.ФИО = textBox5.Text;
            db.Пользователи.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + usr.Логин + " зарегистрирован");
            Form1.FORMA.Show();
            this.Close();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.FORMA.Show();
        }
    }
}
