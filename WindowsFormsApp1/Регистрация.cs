using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WindowsFormsApp1.Ado.NET;

namespace WindowsFormsApp1
{
    public partial class Регистрация : Form
    {
        Demo db = new Demo();
        public static Пользователи user { get; set; }

        public Регистрация()
        {
            InitializeComponent();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {
            string[] roles = { "Менеджер", "Директор", "Заказчик", "Кладовщик" };
            role.Items.AddRange(roles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = password.Text;
            //задаем условия проверки пароля
            var prov1 = new Regex(@"[0-9]+");
            var prov2 = new Regex(@"[A-z]+");
            var prov3 = new Regex(@"[!@#$%^.]+");

            bool proverka = prov1.IsMatch(pass) && prov2.IsMatch(pass) && prov3.IsMatch(pass);
            Пользователи usr = db.Пользователи.Find(login.Text);

            //проверка заполнения полей
            if (login.ToString() !="" && password.ToString() !="" && role.ToString() !="")
            {
                //проверяет существет ли пользователь с таким логинм, если нет, регистрирует его
                if(usr == null)
                {
                    //проверка условий для пароля 
                    if(proverka==true && pass.Length >=6)
                    {
                        //добавление пользователя 
                        usr = new Пользователи();
                        usr.Логин = login.Text;
                        usr.Пароль = password.Text;
                        usr.Роль = role.Text;
                        usr.Наименование = name.Text;
                        db.Пользователи.Add(usr);
                        try
                        {
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show("Пользователь зарегистрирован!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ff = new Авторизация();
            ff.Visible = true;
            this.Close();
        }
    }
}