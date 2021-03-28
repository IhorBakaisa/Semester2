using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7z1v1
{
    public partial class Lab7z1v1 : Form
    {
        public Lab7z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text text1 = new Text(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox6.Text = text1.str();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text text1 = new Text(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox6.Text = text1.number_of_characters();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text text1 = new Text(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox6.Text = text1.number_of_words();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Text text1 = new Text(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox6.Text = text1.letter_replacement();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Text text1 = new Text(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox6.Text = text1.delete_words();
        }
    }
}
