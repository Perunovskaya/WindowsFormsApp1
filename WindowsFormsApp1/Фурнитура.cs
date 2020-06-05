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
    public partial class Фурнитура : Form
    {
        public Фурнитура()
        {
            InitializeComponent();
        }

        private void Фурнитура_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user4DataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.garmentFactoryDataSet.Фурнитура);

        }

        private void фурнитураBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фурнитураBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.garmentFactoryDataSet);

        }

        private void Фурнитура_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "garmentFactoryDataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.garmentFactoryDataSet.Фурнитура);

        }
    }
}
