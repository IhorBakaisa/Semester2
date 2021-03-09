using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab1z4v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, C, N, y;
            A = Convert.ToDouble(textBox1.Text);
            C = Convert.ToDouble(textBox2.Text);
            N = Convert.ToDouble(textBox3.Text);

            if (A == C && C == N)
            {
                y = Math.Cos(A + C + N);
            }
            else if (A < C && C == N)
            {
                y = Math.Cos(A * C * N);
            }
            else if (A < C && C < N)
            {
                y = Math.Cos((A + C) * N);
            }
            else
            {
                y = 0.0;
            }

            textBox4.Text = y.ToString();
        }
    }
}
