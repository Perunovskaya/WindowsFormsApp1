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
    public partial class Список_поступаемых_материалов : Form
    {
        public Список_поступаемых_материалов()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form pm = new Поступление_материалов();
            pm.Visible = true;
            this.Close();
        }

        private void Список_поступаемых_материалов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user4DataSet.Поступление_материалов". При необходимости она может быть перемещена или удалена.
            this.поступление_материаловTableAdapter.Fill(this.user4DataSet.Поступление_материалов);

        }
    }
}
