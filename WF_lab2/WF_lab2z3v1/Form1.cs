using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab2z3v1
{
    public partial class WF_lab2z3v1 : Form
    {
        public WF_lab2z3v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eps, x, a, n, s, b, k;

            eps = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox2.Text);

            a = Math.Log(x);
            s = 2;
            if (x > 0)
            {
                n = 1;
                b = 1 / (2 * n - 1) * (Math.Pow(x - 1 / x + 1, 2 * n - 1));
                while (Math.Abs(b) > eps)
                {
                    k = 1 / (2 * n - 1);
                    b = k * (Math.Pow(x - 1 / x + 1, 2 * n - 1));
                    s += b;
                    n += 1;
                }

            }
            else
            {
                textBox3.Text = "Error";
            }

            if (a == s)
            {
                textBox3.Text = "Рівність справедлива";
            }
            else
            {
                textBox3.Text = "Рівність несправедлива";
            }
        }
    }
}
