using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12z1v1
{
    public partial class Lab12z1v1 : Form
    {
        public Lab12z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quadrangle1 q1 = new Quadrangle1(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox5.Text = q1.S().ToString();
            textBox6.Text = q1.P().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quadrangle2 q2 = new Quadrangle2(Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text), Convert.ToDouble(textBox11.Text), Convert.ToDouble(textBox12.Text), Convert.ToDouble(textBox13.Text), Convert.ToDouble(textBox14.Text));
            textBox15.Text = q2.S().ToString();
            textBox16.Text = q2.P().ToString();
        }
    }
}
