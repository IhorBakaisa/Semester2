using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab5z2v1
{
    public partial class WF_lab5z2v1 : Form
    {
        private static double Skal(double[] x, double[] y, int n)
        {
            double d = 0;
            for (int i = 0; i < n; i++)
            {
                d += x[i] * y[i];
            }
            return d;
        }

        public WF_lab5z2v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox4.Text);

            string[] da = textBox1.Text.Split(' ');
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(da[i]);
            }

            string[] db = textBox2.Text.Split(' ');
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToDouble(db[i]);
            }

            string[] dc = textBox3.Text.Split(' ');
            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = Convert.ToDouble(dc[i]);
            }

            double z1 = Skal(a, b, n);
            double z2 = Skal(a, c, n);
            double s = (2 * z1) - (3 * z2);

            textBox5.Text = s.ToString();
        }
    }
}
