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
    public partial class Ткани : Form
    {
        public Ткани()
        {
            InitializeComponent();
        }

        private void Ткани_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user4DataSet.Ткань". При необходимости она может быть перемещена или удалена.
            this.тканьTableAdapter.Fill(this.garmentFactoryDataSet.Ткань);

        }

        private void тканьBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тканьBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.garmentFactoryDataSet);

        }

        private void Ткани_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "garmentFactoryDataSet.Ткань". При необходимости она может быть перемещена или удалена.
            this.тканьTableAdapter.Fill(this.garmentFactoryDataSet.Ткань);

        }
    }
}
