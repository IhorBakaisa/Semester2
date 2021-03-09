using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab4z5v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int maxValue = 10;
            int minValue = -10;

            double[][] matrix = new double[n][];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = Convert.ToInt32(rnd.NextDouble() * (maxValue - minValue) + minValue);
                }
            }
 
            double d = 0;
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                int c = i + 1;
                for (int j = 0; j < m; j++)
                {
                    int z = j + 1;
                    if (matrix[i][j] == 0)
                    {
                        p += 1;
                        break;
                    }
                }
            }
            int y = n - p;

            textBox3.Text = y.ToString();
        }
    }
}
