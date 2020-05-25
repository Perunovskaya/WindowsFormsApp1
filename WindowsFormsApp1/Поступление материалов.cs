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
    public partial class Поступление_материалов : Form
    {
        public Поступление_материалов()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
                label6.Text = sum.ToString();
            }
            catch (System.FormatException)
            { 
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
                label6.Text = sum.ToString();
            }
            catch (System.FormatException)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form spm = new Список_поступаемых_материалов();
            spm.Visible = true;
            this.Close();
        }
    }
}
