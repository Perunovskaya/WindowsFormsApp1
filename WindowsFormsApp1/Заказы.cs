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
    public partial class Заказы : Form
    {
        public Заказы()
        {
            InitializeComponent();
        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user4DataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.user4DataSet.Заказ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form men = new ЭкранМенеджера();
            men.Visible = true;
            this.Close();
        }
    }
}
