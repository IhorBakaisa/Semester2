using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11z1v1
{
    public partial class Lab11z1v1 : Form
    {
        public Lab11z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TPrism prism;

            TPrism3 p3 = new TPrism3(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            TPrism4 p4 = new TPrism4(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox9.Text));

            prism = p3;
            textBox10.Text = prism.str();

            prism = p4;
            textBox11.Text = prism.str();

            double sumvolume3 = 0;
            double sumarea4 = 0;

            Random rand = new Random(DateTime.Now.Millisecond);
            TPrism[] arr = new TPrism[Convert.ToInt32(textBox12.Text)];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (rand.Next(1, 3))
                {
                    case 1:
                        arr[i] = new TPrism3(rand.Next(-10, 20), rand.Next(-10, 20), rand.Next(-10, 20), rand.Next(1, 20));
                        sumvolume3 += arr[i].volumePrism();
                        break;
                    case 2:
                        arr[i] = new TPrism4(rand.Next(-10, 20), rand.Next(-10, 20), rand.Next(-10, 20), rand.Next(-10, 20), rand.Next(1, 20));
                        sumarea4 += arr[i].area_full_prism();
                        break;
                }
            }

            textBox13.Text = sumvolume3.ToString();
            textBox14.Text = sumarea4.ToString();
        }
    }
}
