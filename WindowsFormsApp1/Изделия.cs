using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Изделия : Form
    {
        public Изделия()
        {
            InitializeComponent();
        }

        private void Изделия_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user4DataSet.Изделия". При необходимости она может быть перемещена или удалена.
            this.изделияTableAdapter.Fill(this.user4DataSet.Изделия);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(Авторизация.av == 1)
            {
                Form frm = new ЭкранДиректора();
                frm.Visible = true;
                this.Hide();
            }
            else if(Авторизация.av == 2)
            {
                Form frm = new ЭкранМенеджера();
                frm.Visible = true;
                this.Hide();
            }
        }
    }
}
