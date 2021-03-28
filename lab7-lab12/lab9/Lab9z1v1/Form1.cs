using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9z1v1
{
    public partial class Lab9z1v1 : Form
    {
        public Lab9z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector2D vek1 = new Vector2D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox5.Text = vek1.str();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector2D vek1 = new Vector2D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox5.Text = vek1.vector_length();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vector2D vek1 = new Vector2D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox5.Text = vek1.normalization_vector();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vector2D vek1 = new Vector2D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Vector2D vek2 = new Vector2D(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            textBox5.Text = vek1.comparison(vek2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vector2D vek1 = new Vector2D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Vector2D vek2 = new Vector2D(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            textBox5.Text = vek1.dod(vek2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vector2D vek1 = new Vector2D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Vector2D vek2 = new Vector2D(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            textBox5.Text = vek1.vid(vek2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vector2D vek1 = new Vector2D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Vector2D vek2 = new Vector2D(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            textBox5.Text = vek1.skall(vek2).ToString();
        }
    }
}
