using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9z2v1
{
    public partial class Lab9z2v1 : Form
    {
        public Lab9z2v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TMoney a = new TMoney(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            textBox5.Text = a.str();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TMoney a = new TMoney(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            textBox5.Text = a.strkursdol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TMoney a = new TMoney(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            textBox5.Text = a.grndoldod(Convert.ToDouble(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TMoney a = new TMoney(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            textBox5.Text = a.grndolvid(Convert.ToDouble(textBox4.Text));
        }
    }
}
