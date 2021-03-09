using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab1z3v1
{
    public partial class WF_lab1z3v1 : Form
    {
        public static double side(double x, double y, double z, double f)
        {
            return Math.Sqrt(Math.Pow(x - y, 2) + Math.Pow(z - f, 2));
        }

        public WF_lab1z3v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1, x2, y2, x3, y3;
            x1 = Convert.ToDouble(textBox1.Text);
            y1 = Convert.ToDouble(textBox2.Text);
            x2 = Convert.ToDouble(textBox3.Text);
            y2 = Convert.ToDouble(textBox4.Text);
            x3 = Convert.ToDouble(textBox5.Text);
            y3 = Convert.ToDouble(textBox6.Text);

            double a, b, c, p, s;
            a = side(x2, x1, y2, y1);
            b = side(x3, x2, y3, y2);
            c = side(x1, x3, y1, y3);

            if (a + b > c || a + c > b || b + c > a)
            {
                textBox7.Text = "Трикутник вироджений";
            }
            else
            {
                textBox7.Text = "Трикутник не вироджений";
            }
        }
    }
}
