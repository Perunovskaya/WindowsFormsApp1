using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Ado.NET;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Авторизация : Form
        
    {
        public static Пользователь user { get; set; }
        Demo db = new Demo();
        public static int av = 0;
        public Авторизация()
        {
            InitializeComponent();
            
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            Пользователь usr = db.Пользователь.Find(login.Text);

            if ((usr != null) && (usr.Пароль == password.Text))
            {

                user = usr;
   
                if (usr.Роль == "Директор")
                {
                    // создаем форму директора
                    Form frm = new ЭкранДиректора();
                    // показываем форму директора
                    frm.Visible = true;
                    //  форму подключения скрываем 
                    this.Hide();
                    av = 1;
                }
                else if (usr.Роль == "Менеджер")
                {
                    // создаем форму менеджера
                    Form frm = new ЭкранМенеджера();
                    // показываем форму менеджера
                    frm.Visible = true;
                    //  форму подключения скрываем 
                    this.Hide();
                    av = 2;
                }
                else if (usr.Роль == "Заказчик")
                {
                    // создаем форму заказчика
                    Form frm = new ЭкранЗаказчика();
                    // показываем форму заказчика
                    frm.Visible = true;
                    //  форму подключения скрываем 
                    this.Hide();
                }
                else if (usr.Роль == "Кладовщик")
                {
                    // создаем форму кладовщика
                    Form frm = new ЭкранКладовщика();
                    // показываем форму кладовщика
                    frm.Visible = true;
                    //  форму подключения скрываем 
                    this.Hide();
                }
            }
            else
            {
                // если данные введены не правильно, то показываем сообщение
                MessageBox.Show("Такого пользователя не существует или неверно введен пароль!");
                return;
            }
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Form frm = new Регистрация();
            // показываем форму регистрации
            frm.Visible = true;
            //  форму подключения скрываем 
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

