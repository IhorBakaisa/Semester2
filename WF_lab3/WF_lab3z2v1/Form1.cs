using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab3z2v1
{
    public partial class WF_lab3z2v1 : Form
    {
        public WF_lab3z2v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            double x = Convert.ToInt32(textBox2.Text);
            double y = Convert.ToInt32(textBox3.Text);
            double z = Convert.ToInt32(textBox4.Text);

            double[] A = new double[n];

            A[0] = x;
            A[1] = x;
            A[2] = y;

            for (int i = 3; i < n; i++)
            {
                A[i] = A[i - 2] + (A[i - 1] / Math.Pow(2, i - 1) * A[i - 3]);
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > z)
                {
                    k += 1;
                }
            }

            textBox5.Text = k.ToString();
        }
    }
}
