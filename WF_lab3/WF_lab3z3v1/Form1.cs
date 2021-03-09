using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab3z3v1
{
    public partial class WF_lab3z3v1 : Form
    {
        public WF_lab3z3v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            string[] dx = textBox2.Text.Split(' ');
            if (n > dx.Length)
            {
                MessageBox.Show("Довжина масиву x не відповідає кількості n");
                return;
            }
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = Convert.ToDouble(dx[i]);

            string[] dy = textBox2.Text.Split(' ');
            if (n > dy.Length)
            {
                MessageBox.Show("Довжина масиву y не відповідає кількості n");
                return;
            }
            double[] y = new double[n];
            for (int i = 0; i < n; i++)
                y[i] = Convert.ToDouble(dy[i]);

            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = x[i] + y[i];
            }
            for (int i = 0; i < n; i++)
            {
                SumVectors.Items.Add(c[i]);
            }
        }
    }
}
