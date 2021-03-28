using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9z3v1
{
    public partial class Lab9z3v1 : Form
    {
        public Lab9z3v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox3.Text);

            string[] dx = textBox1.Text.Split(' ');
            if (n > dx.Length)
            {
                MessageBox.Show("Довжина масиву x не відповідає кількості n");
                return;
            }
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
                x[i] = Convert.ToInt32(dx[i]);

            Array arr = new Array(x);
            textBox2.Text = arr.str();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox3.Text);

            string[] dx = textBox1.Text.Split(' ');
            if (n > dx.Length)
            {
                MessageBox.Show("Довжина масиву x не відповідає кількості n");
                return;
            }
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
                x[i] = Convert.ToInt32(dx[i]);

            Array arr = new Array(x);
            textBox2.Text = arr.maxElement().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox3.Text);

            string[] dx = textBox1.Text.Split(' ');
            if (n > dx.Length)
            {
                MessageBox.Show("Довжина масиву x не відповідає кількості n");
                return;
            }
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
                x[i] = Convert.ToInt32(dx[i]);

            Array arr = new Array(x);
            textBox2.Text = arr.minElement().ToString();
        }
    }
}
