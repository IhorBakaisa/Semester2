using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10z1v1
{
    public partial class Lab10z1v1 : Form
    {
        public Lab10z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector3D vector1 = new Vector3D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox7.Text = vector1.str();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector3D vector1 = new Vector3D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox7.Text = vector1.vector_length();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vector3D vector1 = new Vector3D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox7.Text = vector1.normalization_vector();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vector3D vector1 = new Vector3D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            Vector3D vector2 = new Vector3D(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            textBox7.Text = vector1.comparison(vector2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vector3D vector1 = new Vector3D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            Vector3D vector2 = new Vector3D(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            textBox7.Text = vector1.dod(vector2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vector3D vector1 = new Vector3D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            Vector3D vector2 = new Vector3D(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            textBox7.Text = vector1.vid(vector2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vector3D vector1 = new Vector3D(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            Vector3D vector2 = new Vector3D(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            textBox7.Text = vector1.skall(vector2).ToString();
        }
    }
}
