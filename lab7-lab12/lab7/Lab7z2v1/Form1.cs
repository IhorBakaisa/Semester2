using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7z2v1
{
    public partial class Lab7z2v1 : Form
    {
        public Lab7z2v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisorientedEarl earl = new DisorientedEarl(Convert.ToInt32(textBox1.Text));
            textBox2.Text = earl.number_Top();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisorientedEarl earl = new DisorientedEarl(Convert.ToInt32(textBox1.Text));
            textBox2.Text = earl.numbers_ribs_Earl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisorientedEarl earl = new DisorientedEarl(Convert.ToInt32(textBox1.Text));
            textBox2.Text = earl.add_rib_Earl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisorientedEarl earl = new DisorientedEarl(Convert.ToInt32(textBox1.Text));
            textBox2.Text = earl.remove_rib_Earl();
        }
    }
}
