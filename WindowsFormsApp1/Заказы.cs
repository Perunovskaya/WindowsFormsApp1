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
            this.заказTableAdapter.Fill(this.garmentFactoryDataSet.Заказ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form men = new ЭкранМенеджера();
            men.Visible = true;
            this.Close();
        }

        private void заказBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.garmentFactoryDataSet);

        }

        private void Заказы_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "garmentFactoryDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.garmentFactoryDataSet.Заказ);

        }
    }
}
