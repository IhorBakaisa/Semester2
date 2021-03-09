using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab5z1v1
{
    public partial class WF_lab5z1v1 : Form
    {
        private static double f(double x, double y)
        {
            if (x > y)
            {
                return Math.Pow(x, 3) + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 4));
            }
            else
            {
                return (Math.Pow(x, 2) - (2 * x) + Math.Sqrt(x)) / (Math.Pow(x, 3) / 5.0);
            }
        }

        public WF_lab5z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double u = f(a, b) + f(2, a) + 2;
            textBox3.Text = u.ToString();
        }
    }
}
